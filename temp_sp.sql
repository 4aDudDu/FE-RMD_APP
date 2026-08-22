CREATE PROCEDURE sp_AdjustInventory
    @grade_id INT,
    @adjust_qty DECIMAL(18,2)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRANSACTION;
        
        -- Get current stock
        DECLARE @CurrentStock DECIMAL(18,2);
        SELECT @CurrentStock = current_stock FROM Inventory WHERE grade_id = @grade_id;
        
        IF (@CurrentStock + @adjust_qty < 0)
        BEGIN
            RAISERROR('Stok tidak boleh minus!', 16, 1);
            ROLLBACK TRANSACTION;
            RETURN;
        END

        -- Update Inventory
        UPDATE Inventory 
        SET current_stock = current_stock + @adjust_qty, 
            last_updated = GETDATE() 
        WHERE grade_id = @grade_id;
        
        -- Insert into StockLedger
        DECLARE @transType VARCHAR(20) = CASE WHEN @adjust_qty >= 0 THEN 'ADJUST_IN' ELSE 'ADJUST_OUT' END;
        DECLARE @absQty DECIMAL(18,2) = ABS(@adjust_qty);
        
        INSERT INTO StockLedger (grade_id, transaction_type, qty, reference_no)
        VALUES (@grade_id, @transType, @absQty, 'MANUAL_ADJUST');
        
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
