USE DB_RMD_Sambu;
GO

ALTER PROCEDURE [dbo].[sp_DeleteInboundTicket]
    @ticket_id INT
AS
BEGIN
    BEGIN TRANSACTION;
    BEGIN TRY
        UPDATE i
        SET i.current_stock = i.current_stock - q.qty,
            i.last_updated = GETDATE()
        FROM Inventory i
        INNER JOIN InboundQC q ON i.grade_id = q.grade_id
        WHERE q.ticket_id = @ticket_id;
        
        INSERT INTO StockLedger (transaction_date, grade_id, transaction_type, qty, reference_no, created_at)
        SELECT GETDATE(), q.grade_id, 'REVERSE_IN', q.qty, t.ticket_no, GETDATE() 
        FROM InboundQC q
        INNER JOIN InboundTickets t ON q.ticket_id = t.id
        WHERE q.ticket_id = @ticket_id;

        DELETE FROM InboundQC WHERE ticket_id = @ticket_id;
        DELETE FROM InboundTickets WHERE id = @ticket_id;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END
GO
