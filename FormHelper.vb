Imports System.Data
Imports RestSharp
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports Microsoft.Reporting.WinForms
Imports System.Windows.Forms

Module FormHelper

    Public Const ApiBaseUrl As String = "http://localhost:5041/"

    ' Variabel Global Session
    Public LoggedInUserId As Integer = 1
    Public LoggedInUsername As String = "Admin"
    Public LoggedInFullName As String = "Administrator"
    Public LoggedInRole As String = "Unknown"

    Public Function GetApiClient() As RestClient
        Return New RestClient(ApiBaseUrl)
    End Function

    Public Sub ExitApplication()
        Application.Exit()
    End Sub

    Public Sub RefreshReportInbound(ByVal reportViewer As ReportViewer)
        Try
            Dim hariIni As String = DateTime.Now.ToString("yyyy-MM-dd")

            Dim client = GetApiClient()
            Dim request = New RestRequest("api/reports/daily-inbound", Method.Post)

            request.AddJsonBody(New With {
                .StartDate = hariIni & " 00:00:00",
                .EndDate = hariIni & " 23:59:59"
            })

            Dim response = client.Execute(request)

            If response.IsSuccessful Then
                Dim jsonResponse = JObject.Parse(response.Content)
                Dim isSuccess = jsonResponse("success").Value(Of Boolean)

                If isSuccess Then
                    Dim jsonArrayData As String = jsonResponse("data").ToString()
                    Dim dt As DataTable = JsonConvert.DeserializeObject(Of DataTable)(jsonArrayData)

                    If dt.Columns.Contains("ticketNo") Then dt.Columns("ticketNo").ColumnName = "ticket_no"
                    If dt.Columns.Contains("TicketNo") Then dt.Columns("TicketNo").ColumnName = "ticket_no"
                    If dt.Columns.Contains("supplierName") Then dt.Columns("supplierName").ColumnName = "supplier_name"
                    If dt.Columns.Contains("SupplierName") Then dt.Columns("SupplierName").ColumnName = "supplier_name"
                    If dt.Columns.Contains("truckPlate") Then dt.Columns("truckPlate").ColumnName = "truck_plate"
                    If dt.Columns.Contains("TruckPlate") Then dt.Columns("TruckPlate").ColumnName = "truck_plate"
                    If dt.Columns.Contains("weightNetto") Then dt.Columns("weightNetto").ColumnName = "weight_netto"
                    If dt.Columns.Contains("WeightNetto") Then dt.Columns("WeightNetto").ColumnName = "weight_netto"

                    Dim rds As New ReportDataSource("DataSet1", dt)

                    reportViewer.LocalReport.DataSources.Clear()
                    reportViewer.LocalReport.DataSources.Add(rds)

                    reportViewer.LocalReport.ReportEmbeddedResource = "RMD_APP.RptRiwayatInbound.rdlc"

                    reportViewer.RefreshReport()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Gagal memuat riwayat: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub RefreshReportOutbound(ByVal reportViewer As ReportViewer)
        Try
            Dim hariIni As String = DateTime.Now.ToString("yyyy-MM-dd")

            Dim client = GetApiClient()
            Dim request = New RestRequest("api/reports/daily-outbound", Method.Post)

            request.AddJsonBody(New With {
                .StartDate = hariIni & " 00:00:00",
                .EndDate = hariIni & " 23:59:59"
            })

            Dim response = client.Execute(request)

            If response.IsSuccessful Then
                Dim jsonResponse = JObject.Parse(response.Content)
                Dim isSuccess = jsonResponse("success").Value(Of Boolean)

                If isSuccess Then
                    Dim jsonArrayData As String = jsonResponse("data").ToString()
                    Dim dt As DataTable = JsonConvert.DeserializeObject(Of DataTable)(jsonArrayData)

                    If dt.Columns.Contains("issueNo") Then dt.Columns("issueNo").ColumnName = "issue_no"
                    If dt.Columns.Contains("IssueNo") Then dt.Columns("IssueNo").ColumnName = "issue_no"
                    If dt.Columns.Contains("issueDate") Then dt.Columns("issueDate").ColumnName = "issue_date"
                    If dt.Columns.Contains("IssueDate") Then dt.Columns("IssueDate").ColumnName = "issue_date"
                    If dt.Columns.Contains("shift") Then dt.Columns("shift").ColumnName = "shift"
                    If dt.Columns.Contains("Shift") Then dt.Columns("Shift").ColumnName = "shift"
                    If dt.Columns.Contains("destination") Then dt.Columns("destination").ColumnName = "destination"
                    If dt.Columns.Contains("Destination") Then dt.Columns("Destination").ColumnName = "destination"
                    If dt.Columns.Contains("gradeName") Then dt.Columns("gradeName").ColumnName = "grade_name"
                    If dt.Columns.Contains("GradeName") Then dt.Columns("GradeName").ColumnName = "grade_name"
                    If dt.Columns.Contains("qty") Then dt.Columns("qty").ColumnName = "qty"
                    If dt.Columns.Contains("Qty") Then dt.Columns("Qty").ColumnName = "qty"
                    If dt.Columns.Contains("createdBy") Then dt.Columns("createdBy").ColumnName = "created_by"
                    If dt.Columns.Contains("CreatedBy") Then dt.Columns("CreatedBy").ColumnName = "created_by"

                    Dim rds As New ReportDataSource("DataSet1", dt)

                    reportViewer.LocalReport.DataSources.Clear()
                    reportViewer.LocalReport.DataSources.Add(rds)

                    reportViewer.LocalReport.ReportEmbeddedResource = "RMD_APP.RptRiwayatOutbound.rdlc"

                    reportViewer.RefreshReport()
                End If
            Else
                MessageBox.Show("API Outbound gagal dipanggil. Status: " & response.StatusCode.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Gagal memuat riwayat: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub RefreshReportInventory(reportViewer As Microsoft.Reporting.WinForms.ReportViewer)
        Try
            Dim client = GetApiClient()
            Dim request = New RestSharp.RestRequest("/api/reports/stock", RestSharp.Method.Get)
            Dim response = client.Execute(request)

            If response.IsSuccessful Then
                Dim jsonResponse = Newtonsoft.Json.Linq.JObject.Parse(response.Content)
                Dim listStock = jsonResponse("data").ToObject(Of List(Of Dictionary(Of String, Object)))()

                Dim dt As New DataTable("DataSet1")
                dt.Columns.Add("grade_name", GetType(String))
                dt.Columns.Add("current_stock", GetType(Decimal))
                dt.Columns.Add("last_updated", GetType(DateTime))

                For Each item In listStock
                    Dim row = dt.NewRow()
                    row("grade_name") = item("gradeName").ToString()
                    row("current_stock") = Convert.ToDecimal(item("currentStock"))
                    row("last_updated") = Convert.ToDateTime(item("lastUpdated"))
                    dt.Rows.Add(row)
                Next

                reportViewer.LocalReport.DataSources.Clear()
                Dim rds As New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt)
                reportViewer.LocalReport.DataSources.Add(rds)
                reportViewer.LocalReport.ReportEmbeddedResource = "RMD_APP.RptInventory.rdlc"
                reportViewer.RefreshReport()
            Else
                MessageBox.Show("Gagal mengambil data inventori: " & response.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan sistem: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Module