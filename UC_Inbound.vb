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
        Me.ReportViewer1.Dock = DockStyle.Fill
        Me.ReportViewer1.ZoomMode = ZoomMode.PageWidth

        txtNettoInbound.ReadOnly = True
        txtTiketInbound.ReadOnly = True

        LoadSuppliers()
        GenerateTiket()
        FormHelper.RefreshReportInbound(ReportViewer1)
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        FormHelper.RefreshReportInbound(ReportViewer1)
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

End Class