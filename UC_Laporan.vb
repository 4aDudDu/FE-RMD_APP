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

                ' Kolom sesuai alias yang di-return SP: TicketNo, DateIn, SupplierName, TruckPlate,
                ' WeightBruto, WeightTara, WeightNetto, Status
                Dim dt As New DataTable("DataSet1")
                dt.Columns.Add("ticket_no", GetType(String))
                dt.Columns.Add("date_in", GetType(String))
                dt.Columns.Add("supplier_name", GetType(String))
                dt.Columns.Add("truck_plate", GetType(String))
                dt.Columns.Add("weight_bruto", GetType(String))
                dt.Columns.Add("weight_tara", GetType(String))
                dt.Columns.Add("weight_netto", GetType(String))
                dt.Columns.Add("status", GetType(String))

                For Each item In listData
                    Dim row = dt.NewRow()
                    row("ticket_no") = If(item.ContainsKey("ticketNo") AndAlso item("ticketNo") IsNot Nothing, item("ticketNo").ToString(), "")
                    
                    Dim dateVal As DateTime
                    If item.ContainsKey("dateIn") AndAlso item("dateIn") IsNot Nothing AndAlso DateTime.TryParse(item("dateIn").ToString(), dateVal) Then
                        row("date_in") = dateVal.ToString("dd/MM/yyyy HH:mm")
                    Else
                        row("date_in") = ""
                    End If

                    row("supplier_name") = If(item.ContainsKey("supplierName") AndAlso item("supplierName") IsNot Nothing, item("supplierName").ToString(), "")
                    row("truck_plate") = If(item.ContainsKey("truckPlate") AndAlso item("truckPlate") IsNot Nothing, item("truckPlate").ToString(), "")
                    
                    Dim wNetto As Decimal = If(item.ContainsKey("weightNetto") AndAlso item("weightNetto") IsNot Nothing, Convert.ToDecimal(item("weightNetto")), 0D)
                    row("weight_netto") = wNetto.ToString("N0")
                    
                    ' Kolom ekstra (tidak ada di RDLC tapi diisi saja)
                    row("weight_bruto") = If(item.ContainsKey("weightBruto") AndAlso item("weightBruto") IsNot Nothing, Convert.ToDecimal(item("weightBruto")).ToString("N0"), "0")
                    row("weight_tara") = If(item.ContainsKey("weightTara") AndAlso item("weightTara") IsNot Nothing, Convert.ToDecimal(item("weightTara")).ToString("N0"), "0")
                    row("status") = If(item.ContainsKey("status") AndAlso item("status") IsNot Nothing, item("status").ToString(), "")
                    
                    dt.Rows.Add(row)
                Next

                RpvLaporan.LocalReport.DataSources.Clear()
                RpvLaporan.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", dt))
                RpvLaporan.LocalReport.ReportEmbeddedResource = "RMD_APP.RptRiwayatInbound.rdlc"
                RpvLaporan.RefreshReport()
            Else
                MessageBox.Show("Gagal mengambil laporan Inbound." & vbNewLine & response.Content, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

                ' Kolom sesuai alias SP: IssueNo, IssueDate, Shift, Destination, GradeName, Qty, CreatedBy
                Dim dt As New DataTable("DataSet1")
                dt.Columns.Add("issue_no", GetType(String))
                dt.Columns.Add("issue_date", GetType(String))
                dt.Columns.Add("shift", GetType(String))
                dt.Columns.Add("destination", GetType(String))
                dt.Columns.Add("grade_name", GetType(String))
                dt.Columns.Add("qty", GetType(String))
                dt.Columns.Add("created_by", GetType(String))

                For Each item In listData
                    Dim row = dt.NewRow()
                    row("issue_no") = If(item.ContainsKey("issueNo") AndAlso item("issueNo") IsNot Nothing, item("issueNo").ToString(), "")
                    
                    Dim dateVal As DateTime
                    If item.ContainsKey("issueDate") AndAlso item("issueDate") IsNot Nothing AndAlso DateTime.TryParse(item("issueDate").ToString(), dateVal) Then
                        row("issue_date") = dateVal.ToString("dd/MM/yyyy HH:mm")
                    Else
                        row("issue_date") = ""
                    End If

                    row("shift") = If(item.ContainsKey("shift") AndAlso item("shift") IsNot Nothing, item("shift").ToString(), "")
                    row("destination") = If(item.ContainsKey("destination") AndAlso item("destination") IsNot Nothing, item("destination").ToString(), "")
                    row("grade_name") = If(item.ContainsKey("gradeName") AndAlso item("gradeName") IsNot Nothing, item("gradeName").ToString(), "")
                    
                    Dim qtyVal As Decimal = If(item.ContainsKey("qty") AndAlso item("qty") IsNot Nothing, Convert.ToDecimal(item("qty")), 0D)
                    row("qty") = qtyVal.ToString("N0")
                    
                    row("created_by") = If(item.ContainsKey("createdBy") AndAlso item("createdBy") IsNot Nothing, item("createdBy").ToString(), "")
                    dt.Rows.Add(row)
                Next

                RpvLaporan.LocalReport.DataSources.Clear()
                RpvLaporan.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", dt))
                RpvLaporan.LocalReport.ReportEmbeddedResource = "RMD_APP.RptRiwayatOutbound.rdlc"
                RpvLaporan.RefreshReport()
            Else
                MessageBox.Show("Gagal mengambil laporan Outbound." & vbNewLine & response.Content, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan sistem: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class