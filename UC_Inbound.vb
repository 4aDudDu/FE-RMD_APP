Imports System.Data
Imports RestSharp
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports Microsoft.Reporting.WinForms

Public Class UC_Inbound

    Private Sub LoadSuppliers()
        Try
            Dim client = FormHelper.GetApiClient()
            Dim request = New RestRequest("api/master/suppliers", Method.Get)
            Dim response = client.Execute(request)

            If response.IsSuccessful Then
                Dim jsonResponse = JObject.Parse(response.Content)

                Dim isSuccess As Boolean = False
                If jsonResponse("success") IsNot Nothing Then
                    isSuccess = jsonResponse("success").Value(Of Boolean)()
                End If

                If isSuccess Then
                    Dim dt As DataTable = JsonConvert.DeserializeObject(Of DataTable)(jsonResponse("data").ToString())
                    cmbKendaraanInbound.DataSource = dt
                    cmbKendaraanInbound.DisplayMember = "supplierName"
                    cmbKendaraanInbound.ValueMember = "id"
                    cmbKendaraanInbound.SelectedIndex = -1
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub GenerateTiket()
        txtTiketInbound.Text = "TCK-" & DateTime.Now.ToString("yyMMdd-HHmmss")
    End Sub

    Private Sub HitungNetto()
        Dim bruto As Decimal = 0
        Dim tara As Decimal = 0

        Decimal.TryParse(txtBrutoInbound.Text, bruto)
        Decimal.TryParse(txtTaraInbound.Text, tara)

        txtNettoInbound.Text = (bruto - tara).ToString()
    End Sub

    Private Sub ResetForm()
        txtPlatInbound.Clear()
        txtBrutoInbound.Clear()
        txtTaraInbound.Clear()
        txtNettoInbound.Clear()
        cmbKendaraanInbound.SelectedIndex = -1
        dtTanggalKendaraanInbound.Value = DateTime.Now
        GenerateTiket()
    End Sub

    Private Sub UC_Inbound_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNettoInbound.ReadOnly = True
        txtTiketInbound.ReadOnly = True

        LoadSuppliers()
        GenerateTiket()
        FormHelper.RefreshReportInbound(ReportViewer1)
        InitDeleteControls()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        FormHelper.RefreshReportInbound(ReportViewer1)
        InitDeleteControls()
    End Sub

    Private Sub txtBrutoInbound_TextChanged(sender As Object, e As EventArgs) Handles txtBrutoInbound.TextChanged
        HitungNetto()
    End Sub

    Private Sub txtTaraInbound_TextChanged(sender As Object, e As EventArgs) Handles txtTaraInbound.TextChanged
        HitungNetto()
    End Sub

    Private Sub btnResetInbound_Click(sender As Object, e As EventArgs) Handles btnResetInbound.Click
        ResetForm()
    End Sub

    Private Sub btnSimpanInbound_Click(sender As Object, e As EventArgs) Handles btnSimpanInbound.Click
        If String.IsNullOrWhiteSpace(txtPlatInbound.Text) OrElse cmbKendaraanInbound.SelectedIndex = -1 OrElse String.IsNullOrWhiteSpace(txtBrutoInbound.Text) Then
            MessageBox.Show("Mohon lengkapi data supplier, plat truk, dan berat bruto!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim bruto As Decimal = 0
        Dim tara As Decimal = 0
        Dim suppId As Integer = 0

        Decimal.TryParse(txtBrutoInbound.Text, bruto)
        Decimal.TryParse(txtTaraInbound.Text, tara)
        Integer.TryParse(cmbKendaraanInbound.SelectedValue.ToString(), suppId)

        Try
            Dim client = FormHelper.GetApiClient()
            Dim request = New RestRequest("api/inbound/ticket", Method.Post)

            request.AddJsonBody(New With {
                .ticketNo = txtTiketInbound.Text,
                .supplierId = suppId,
                .truckPlate = txtPlatInbound.Text,
                .weightBruto = bruto,
                .weightTara = tara
            })

            Dim response = client.Execute(request)

            If response.IsSuccessful Then
                Dim jsonResponse = JObject.Parse(response.Content)

                Dim isSuccess As Boolean = False
                If jsonResponse("success") IsNot Nothing Then
                    isSuccess = jsonResponse("success").Value(Of Boolean)()
                End If

                If isSuccess Then
                    MessageBox.Show("Data timbangan berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ResetForm()
                    FormHelper.RefreshReportInbound(ReportViewer1)
        InitDeleteControls()
                Else
                    Dim errorMsg = If(jsonResponse("message") IsNot Nothing, jsonResponse("message").ToString(), "Gagal menyimpan data.")
                    MessageBox.Show(errorMsg, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("Gagal menyimpan data ke server. Status: " & response.StatusCode.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private WithEvents pnlDelete As New Panel()
    Private WithEvents CmbHapusTiket As New ComboBox()
    Private WithEvents BtnHapusTiket As New ReaLTaiizor.Controls.LostButton()
    Private WithEvents lblHapus As New Label()
    Private isDeleteInit As Boolean = False

    Private Sub InitDeleteControls()
        If isDeleteInit Then
            LoadDeleteCombo()
            Return
        End If
        isDeleteInit = True

        pnlDelete.Dock = DockStyle.Bottom
        pnlDelete.Height = 70
        pnlDelete.BackColor = Color.Transparent

        lblHapus.Text = "Hapus Transaksi (Pilih Tiket):"
        lblHapus.ForeColor = Color.White
        lblHapus.AutoSize = True
        lblHapus.Location = New Point(10, 5)

        CmbHapusTiket.Font = New Font("Segoe UI", 10)
        CmbHapusTiket.DropDownStyle = ComboBoxStyle.DropDownList
        CmbHapusTiket.Width = 200
        CmbHapusTiket.Location = New Point(10, 30)

        BtnHapusTiket.Text = "Hapus"
        BtnHapusTiket.BackColor = Color.Crimson
        BtnHapusTiket.ForeColor = Color.White
        BtnHapusTiket.Cursor = Cursors.Hand
        BtnHapusTiket.Width = 80
        BtnHapusTiket.Height = CmbHapusTiket.Height + 5
        BtnHapusTiket.Location = New Point(CmbHapusTiket.Right + 10, CmbHapusTiket.Top)

        pnlDelete.Controls.Add(lblHapus)
        pnlDelete.Controls.Add(CmbHapusTiket)
        pnlDelete.Controls.Add(BtnHapusTiket)

        SplitContainerInbound.Panel2.Controls.Add(pnlDelete)
        pnlDelete.BringToFront()

        LoadDeleteCombo()
    End Sub

    Private Sub LoadDeleteCombo()
        Try
            Dim dt = FormHelper.GetDataTable("SELECT id, ticket_no FROM InboundTickets ORDER BY id DESC")
            CmbHapusTiket.DataSource = dt
            CmbHapusTiket.DisplayMember = "ticket_no"
            CmbHapusTiket.ValueMember = "id"
            CmbHapusTiket.SelectedIndex = -1
        Catch ex As Exception
        End Try
    End Sub

    Private Async Sub BtnHapusTiket_Click(sender As Object, e As EventArgs) Handles BtnHapusTiket.Click
        If CmbHapusTiket.SelectedIndex = -1 Then
            MessageBox.Show("Pilih tiket yang ingin dihapus terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim id = CmbHapusTiket.SelectedValue.ToString()
        If MessageBox.Show("Yakin ingin menghapus tiket ini? Stok inventory akan dikembalikan jika sudah di-QC.", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                Dim client = FormHelper.GetApiClient()
                Dim request = New RestRequest("/api/inbound/" & id, Method.Delete)
                Dim response = Await client.ExecuteAsync(request)
                If response.IsSuccessful Then
                    MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadDeleteCombo()
                    FormHelper.RefreshReportInbound(ReportViewer1)
                Else
                    MessageBox.Show("Gagal menghapus data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class


