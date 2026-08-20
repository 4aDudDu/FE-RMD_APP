Imports Newtonsoft.Json.Linq
Imports RestSharp
Imports Microsoft.Reporting.WinForms

Public Class UC_Laporan

    Private Sub UC_Laporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmbJenisLaporan.Items.Clear()
        CmbJenisLaporan.Items.Add("Laporan Inbound (Barang Masuk)")
        CmbJenisLaporan.Items.Add("Laporan Outbound (Barang Keluar)")
        CmbJenisLaporan.SelectedIndex = 0

        DtpStartDate.Value = New DateTime(Now.Year, Now.Month, 1)
        DtpEndDate.Value = Now.Date
        RpvLaporan.ZoomMode = ZoomMode.PageWidth
    End Sub

    Private Sub BtnTampilkan_Click(sender As Object, e As EventArgs) Handles BtnTampilkan.Click
        If CmbJenisLaporan.SelectedIndex = -1 Then
            MessageBox.Show("Silakan pilih jenis laporan terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim startDateStr As String = DtpStartDate.Value.ToString("yyyy-MM-dd 00:00:00")
        Dim endDateStr As String = DtpEndDate.Value.ToString("yyyy-MM-dd 23:59:59")

        If CmbJenisLaporan.SelectedIndex = 0 Then
            LoadReportInbound(startDateStr, endDateStr)
        Else
            LoadReportOutbound(startDateStr, endDateStr)
        End If
    End Sub

    Private Sub LoadReportInbound(startDate As String, endDate As String)
        Try
            Dim client = FormHelper.GetApiClient()
            Dim request = New RestRequest("/api/reports/daily-inbound", Method.Post)
            request.AddJsonBody(New With {.StartDate = startDate, .EndDate = endDate})

            Dim response = client.Execute(request)

            If response.IsSuccessful Then
                Dim jsonResponse = JObject.Parse(response.Content)
                Dim listData = jsonResponse("data").ToObject(Of List(Of Dictionary(Of String, Object)))()

                Dim dt As New DataTable("DataSet1")
                dt.Columns.Add("ticket_no", GetType(String))
                dt.Columns.Add("supplier_name", GetType(String))
                dt.Columns.Add("truck_plate", GetType(String))
                dt.Columns.Add("weight_netto", GetType(Decimal))

                For Each item In listData
                    Dim row = dt.NewRow()
                    row("ticket_no") = item("ticketNo")?.ToString()
                    row("supplier_name") = item("supplierName")?.ToString()
                    row("truck_plate") = item("truckPlate")?.ToString()
                    row("weight_netto") = If(item("weightNetto") IsNot Nothing, Convert.ToDecimal(item("weightNetto")), 0D)
                    dt.Rows.Add(row)
                Next

                RpvLaporan.LocalReport.DataSources.Clear()
                RpvLaporan.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", dt))
                RpvLaporan.LocalReport.ReportEmbeddedResource = "RMD_APP.RptRiwayatInbound.rdlc"
                RpvLaporan.RefreshReport()
            Else
                MessageBox.Show("Gagal mengambil laporan Inbound: " & response.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan sistem: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadReportOutbound(startDate As String, endDate As String)
        Try
            Dim client = FormHelper.GetApiClient()
            Dim request = New RestRequest("/api/reports/daily-outbound", Method.Post)
            request.AddJsonBody(New With {.StartDate = startDate, .EndDate = endDate})

            Dim response = client.Execute(request)

            If response.IsSuccessful Then
                Dim jsonResponse = JObject.Parse(response.Content)
                Dim listData = jsonResponse("data").ToObject(Of List(Of Dictionary(Of String, Object)))()

                Dim dt As New DataTable("DataSet1")
                dt.Columns.Add("issue_no", GetType(String))
                dt.Columns.Add("issue_date", GetType(DateTime))
                dt.Columns.Add("shift", GetType(String))
                dt.Columns.Add("destination", GetType(String))
                dt.Columns.Add("grade_name", GetType(String))
                dt.Columns.Add("qty", GetType(Decimal))
                dt.Columns.Add("created_by", GetType(String))

                For Each item In listData
                    Dim row = dt.NewRow()
                    row("issue_no") = item("issueNo")?.ToString()
                    row("issue_date") = If(item("issueDate") IsNot Nothing, Convert.ToDateTime(item("issueDate")), DBNull.Value)
                    row("shift") = item("shift")?.ToString()
                    row("destination") = item("destination")?.ToString()
                    row("grade_name") = item("gradeName")?.ToString()
                    row("qty") = If(item("qty") IsNot Nothing, Convert.ToDecimal(item("qty")), 0D)
                    row("created_by") = item("createdBy")?.ToString()
                    dt.Rows.Add(row)
                Next

                RpvLaporan.LocalReport.DataSources.Clear()
                RpvLaporan.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", dt))
                RpvLaporan.LocalReport.ReportEmbeddedResource = "RMD_APP.RptRiwayatOutbound.rdlc"
                RpvLaporan.RefreshReport()
            Else
                MessageBox.Show("Gagal mengambil laporan Outbound: " & response.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan sistem: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class