CREATE PROCEDURE [dbo].[sp_DeleteInboundTicket]
    @ticket_id INT
AS
BEGIN
    BEGIN TRANSACTION;
    BEGIN TRY
        -- Revert Inventory if QC was done
        DECLARE @grade_id INT, @qty DECIMAL(10,2);
        SELECT @grade_id = grade_id, @qty = qty FROM InboundQC WHERE ticket_id = @ticket_id;
        
        IF @grade_id IS NOT NULL
        BEGIN
            UPDATE Inventory SET current_stock = current_stock - @qty, last_updated = GETDATE() WHERE grade_id = @grade_id;
            -- Delete StockLedger if necessary (optional depending on how strict the audit is, but since we are completely deleting the transaction, we delete it to keep it clean)
            -- But we don't have the exact StockLedger ID. We'd have to delete by transaction_date or something, or we can just leave ledger. We'll leave ledger for audit or just reverse it.
            INSERT INTO StockLedger (transaction_date, grade_id, transaction_type, qty, reference_no, created_at)
            SELECT GETDATE(), @grade_id, 'REVERSE_IN', @qty, ticket_no, GETDATE() FROM InboundTickets WHERE id = @ticket_id;
        END

        -- Delete InboundQC
        DELETE FROM InboundQC WHERE ticket_id = @ticket_id;
        -- Delete InboundTickets
        DELETE FROM InboundTickets WHERE id = @ticket_id;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END
GO

CREATE PROCEDURE [dbo].[sp_DeleteOutboundIssue]
    @issue_id INT
AS
BEGIN
    BEGIN TRANSACTION;
    BEGIN TRY
        -- Revert Inventory (Add stock back)
        DECLARE @grade_id INT, @qty DECIMAL(10,2);
        SELECT @grade_id = grade_id, @qty = qty FROM OutboundIssueDetails WHERE issue_id = @issue_id;
        
        IF @grade_id IS NOT NULL
        BEGIN
            UPDATE Inventory SET current_stock = current_stock + @qty, last_updated = GETDATE() WHERE grade_id = @grade_id;
            
            INSERT INTO StockLedger (transaction_date, grade_id, transaction_type, qty, reference_no, created_at)
            SELECT GETDATE(), @grade_id, 'REVERSE_OUT', @qty, issue_no, GETDATE() FROM OutboundIssues WHERE id = @issue_id;
        END

        -- Delete OutboundIssueDetails
        DELETE FROM OutboundIssueDetails WHERE issue_id = @issue_id;
        -- Delete OutboundIssues
        DELETE FROM OutboundIssues WHERE id = @issue_id;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END
