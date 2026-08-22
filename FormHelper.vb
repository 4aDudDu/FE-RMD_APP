Imports System.Data
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports RestSharp
Imports Microsoft.Reporting.WinForms

Module FormHelper
    Public LoggedInUserId As Integer = 0
    Public LoggedInUsername As String = ""
    Public LoggedInRole As String = ""
    Public LoggedInFullName As String = ""

    Public ApiBaseUrl As String = "http://localhost:5041"

    Public Function GetApiClient() As RestClient
        Return New RestClient(ApiBaseUrl)
    End Function

    Public Sub ExitApplication()
        Application.Exit()
    End Sub

    Public Sub RefreshReportInbound(ByVal reportViewer As ReportViewer)
        Try
            Dim startDate As String = DateTime.Now.AddDays(-7).ToString("yyyy-MM-dd")
            Dim endDate As String = DateTime.Now.ToString("yyyy-MM-dd")

            Dim client = GetApiClient()
            Dim request = New RestRequest("api/reports/daily-inbound", Method.Post)

            request.AddJsonBody(New With {
                .StartDate = startDate & " 00:00:00",
                .EndDate = endDate & " 23:59:59"
            })

            Dim response = client.Execute(request)

            If response.IsSuccessful Then
                Dim jsonResponse = JObject.Parse(response.Content)
                Dim isSuccess = If(jsonResponse("success") IsNot Nothing, jsonResponse("success").Value(Of Boolean), False)

                If isSuccess Then
                    Dim listData = jsonResponse("data").ToObject(Of List(Of Dictionary(Of String, Object)))()
                    
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
                        
                        row("weight_bruto") = If(item.ContainsKey("weightBruto") AndAlso item("weightBruto") IsNot Nothing, Convert.ToDecimal(item("weightBruto")).ToString("N0"), "0")
                        row("weight_tara") = If(item.ContainsKey("weightTara") AndAlso item("weightTara") IsNot Nothing, Convert.ToDecimal(item("weightTara")).ToString("N0"), "0")
                        row("status") = If(item.ContainsKey("status") AndAlso item("status") IsNot Nothing, item("status").ToString(), "")
                        
                        dt.Rows.Add(row)
                    Next

                    Dim rds As New ReportDataSource("DataSet1", dt)
                    reportViewer.LocalReport.DataSources.Clear()
                    reportViewer.LocalReport.DataSources.Add(rds)
                    reportViewer.LocalReport.ReportEmbeddedResource = "RMD_APP.RptRiwayatInbound.rdlc"
                    reportViewer.RefreshReport()
                    reportViewer.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Gagal memuat riwayat: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub RefreshReportOutbound(ByVal reportViewer As ReportViewer)
        Try
            Dim startDate As String = DateTime.Now.AddDays(-7).ToString("yyyy-MM-dd")
            Dim endDate As String = DateTime.Now.ToString("yyyy-MM-dd")

            Dim client = GetApiClient()
            Dim request = New RestRequest("api/reports/daily-outbound", Method.Post)

            request.AddJsonBody(New With {
                .StartDate = startDate & " 00:00:00",
                .EndDate = endDate & " 23:59:59"
            })

            Dim response = client.Execute(request)

            If response.IsSuccessful Then
                Dim jsonResponse = JObject.Parse(response.Content)
                Dim isSuccess = If(jsonResponse("success") IsNot Nothing, jsonResponse("success").Value(Of Boolean), False)

                If isSuccess Then
                    Dim listData = jsonResponse("data").ToObject(Of List(Of Dictionary(Of String, Object)))()
                    
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

                    Dim rds As New ReportDataSource("DataSet1", dt)
                    reportViewer.LocalReport.DataSources.Clear()
                    reportViewer.LocalReport.DataSources.Add(rds)
                    reportViewer.LocalReport.ReportEmbeddedResource = "RMD_APP.RptRiwayatOutbound.rdlc"
                    reportViewer.RefreshReport()
                    reportViewer.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
                End If
            Else
                MessageBox.Show("API Outbound gagal dipanggil. Status: " & response.StatusCode.ToString() & vbCrLf & response.Content, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                ' Konversi DateTime langsung
                dt.Columns.Add("last_updated", GetType(DateTimeOffset))

                For Each item In listStock
                    Dim row = dt.NewRow()
                    row("grade_name") = If(item.ContainsKey("gradeName") AndAlso item("gradeName") IsNot Nothing, item("gradeName").ToString(), "")
                    row("current_stock") = If(item.ContainsKey("currentStock") AndAlso item("currentStock") IsNot Nothing, Convert.ToDecimal(item("currentStock")), 0D)
                    
                    Dim dateVal As DateTime
                    If item.ContainsKey("lastUpdated") AndAlso item("lastUpdated") IsNot Nothing AndAlso DateTime.TryParse(item("lastUpdated").ToString(), dateVal) Then
                        row("last_updated") = New DateTimeOffset(dateVal)
                    Else
                        row("last_updated") = DateTimeOffset.Now
                    End If
                    dt.Rows.Add(row)
                Next

                reportViewer.LocalReport.DataSources.Clear()
                Dim rds As New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt)
                reportViewer.LocalReport.DataSources.Add(rds)
                reportViewer.LocalReport.ReportEmbeddedResource = "RMD_APP.RptInventory.rdlc"
                reportViewer.RefreshReport()
                reportViewer.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
            Else
                MessageBox.Show("Gagal mengambil data inventori: " & response.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan sistem: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function GetDataTable(query As String) As DataTable
        Dim dt As New DataTable()
        Try
            Using conn = New SqlClient.SqlConnection("Server=localhost\SQLEXPRESS;Database=DB_RMD_Sambu;Trusted_Connection=True;")
                conn.Open()
                Using cmd = New SqlClient.SqlCommand(query, conn)
                    Using da = New SqlClient.SqlDataAdapter(cmd)
                        da.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As Exception
        End Try
        Return dt
    End Function
End Module

