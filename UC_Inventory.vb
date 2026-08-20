Imports Microsoft.Reporting.WinForms

Public Class UC_Inventory
    Private Sub BtnRefreshInventory_Click(sender As Object, e As EventArgs) Handles BtnRefreshInventory.Click
        FormHelper.RefreshReportInventory(RpvInventory)
    End Sub

    Private Sub UC_Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RpvInventory.Dock = DockStyle.Fill
        RpvInventory.ZoomMode = ZoomMode.PageWidth
        FormHelper.RefreshReportInventory(RpvInventory)
    End Sub
End Class
