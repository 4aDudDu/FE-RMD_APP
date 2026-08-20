Imports System.Threading.Tasks

Public Class FormDashboard

    Private isNavigating As Boolean = False
    Private Async Sub TampilkanHalaman(ByVal uc As UserControl)
        If isNavigating Then Exit Sub
        isNavigating = True

        Try
            progLoading.Parent = Me

            progLoading.Left = pnlContent.Left + (pnlContent.Width - progLoading.Width) / 2
            progLoading.Top = pnlContent.Top + (pnlContent.Height - progLoading.Height) / 2

            progLoading.BringToFront()
            progLoading.Visible = True
            pnlContent.Controls.Clear()
            Await Task.Delay(500)

            uc.Dock = DockStyle.Fill
            pnlContent.Controls.Add(uc)
            uc.BringToFront()

        Catch ex As Exception
            MessageBox.Show("Terjadi masalah saat memuat halaman: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            progLoading.Visible = False
            isNavigating = False
        End Try
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        FormLogin.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub MasterDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterDataToolStripMenuItem.Click
        Dim uc As New UC_MasterData()
        TampilkanHalaman(uc)
    End Sub

    Private Sub InboundToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InboundToolStripMenuItem.Click
        Dim uc As New UC_Inbound()
        TampilkanHalaman(uc)
    End Sub

    Private Sub OutboundToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OutboundToolStripMenuItem.Click
        Dim uc As New UC_Outbound()
        TampilkanHalaman(uc)
    End Sub

    Private Sub InventoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventoryToolStripMenuItem.Click
        Dim uc As New UC_Inventory()
        TampilkanHalaman(uc)
    End Sub

    Private Sub LaporanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanToolStripMenuItem.Click
        Dim uc As New UC_Laporan()
        TampilkanHalaman(uc)
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Dim uc As New UC_Settings()
        TampilkanHalaman(uc)
    End Sub
    Private Sub FormDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class