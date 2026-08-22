USE DB_RMD_Sambu;
GO

ALTER PROCEDURE [dbo].[sp_DeleteOutboundIssue]
    @issue_id INT
AS
BEGIN
    BEGIN TRANSACTION;
    BEGIN TRY
        UPDATE i
        SET i.current_stock = i.current_stock + d.qty,
            i.last_updated = GETDATE()
        FROM Inventory i
        INNER JOIN OutboundIssueDetails d ON i.grade_id = d.grade_id
        WHERE d.issue_id = @issue_id;

        INSERT INTO StockLedger (transaction_date, grade_id, transaction_type, qty, reference_no, created_at)
        SELECT GETDATE(), d.grade_id, 'REVERSE_OUT', d.qty, o.issue_no, GETDATE()
        FROM OutboundIssueDetails d
        INNER JOIN OutboundIssues o ON d.issue_id = o.id
        WHERE d.issue_id = @issue_id;

        DELETE FROM OutboundIssueDetails WHERE issue_id = @issue_id;
        DELETE FROM OutboundIssues WHERE id = @issue_id;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END
GO
