Imports System.IO.Ports
Imports System.Text.RegularExpressions
Imports Newtonsoft.Json.Linq
Imports RestSharp

Public Class UC_Timbangan
    ' Dictionary untuk menyimpan daftar Supplier dan Grade dari API
    Private supplierDict As New Dictionary(Of String, Integer)
    Private gradeDict As New Dictionary(Of String, Integer)

    ' Dynamic Controls
    Private cmbSupplierDyn As ComboBox
    Private txtTicketDyn As TextBox
    Private txtPlatDyn As TextBox
    Private txtTaraDyn As TextBox

    Private txtIssueDyn As TextBox
    Private cmbShiftDyn As ComboBox
    Private txtDestinationDyn As TextBox
    Private cmbGradeDyn As ComboBox

    Private Sub UC_Timbangan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load COM Ports
        CmbComPort.Items.Clear()
        For Each sp As String In My.Computer.Ports.SerialPortNames
            CmbComPort.Items.Add(sp)
        Next
        If CmbComPort.Items.Count > 0 Then CmbComPort.SelectedIndex = 0

        ' Setup Transaction Type
        CmbTransactionType.SelectedIndex = 0
        LoadDynamicUI()
    End Sub

    Private Sub CmbTransactionType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTransactionType.SelectedIndexChanged
        LoadDynamicUI()
    End Sub

    Private Async Sub LoadDynamicUI()
        PanelDynamic.Controls.Clear()
        Dim isOutbound = (CmbTransactionType.SelectedIndex = 1)
        Dim yPos = 10

        If Not isOutbound Then
            ' INBOUND UI
            Dim lblTiket As New Label() With {.Text = "No Tiket:", .Location = New Point(0, yPos), .AutoSize = True, .ForeColor = Color.White}
            txtTicketDyn = New TextBox() With {.Location = New Point(120, yPos), .Width = 200}
            PanelDynamic.Controls.Add(lblTiket)
            PanelDynamic.Controls.Add(txtTicketDyn)
            yPos += 40

            Dim lblSupplier As New Label() With {.Text = "Supplier:", .Location = New Point(0, yPos), .AutoSize = True, .ForeColor = Color.White}
            cmbSupplierDyn = New ComboBox() With {.Location = New Point(120, yPos), .Width = 200, .DropDownStyle = ComboBoxStyle.DropDownList}
            PanelDynamic.Controls.Add(lblSupplier)
            PanelDynamic.Controls.Add(cmbSupplierDyn)
            yPos += 40

            Dim lblPlat As New Label() With {.Text = "Plat Mobil:", .Location = New Point(0, yPos), .AutoSize = True, .ForeColor = Color.White}
            txtPlatDyn = New TextBox() With {.Location = New Point(120, yPos), .Width = 200}
            PanelDynamic.Controls.Add(lblPlat)
            PanelDynamic.Controls.Add(txtPlatDyn)
            yPos += 40

            Dim lblTara As New Label() With {.Text = "Berat Tara (Kosong):", .Location = New Point(0, yPos), .AutoSize = True, .ForeColor = Color.White}
            txtTaraDyn = New TextBox() With {.Location = New Point(120, yPos), .Width = 200}
            PanelDynamic.Controls.Add(lblTara)
            PanelDynamic.Controls.Add(txtTaraDyn)

            Await LoadSuppliersAsync()
        Else
            ' OUTBOUND UI
            Dim lblIssue As New Label() With {.Text = "No Issue:", .Location = New Point(0, yPos), .AutoSize = True, .ForeColor = Color.White}
            txtIssueDyn = New TextBox() With {.Location = New Point(120, yPos), .Width = 200}
            PanelDynamic.Controls.Add(lblIssue)
            PanelDynamic.Controls.Add(txtIssueDyn)
            yPos += 40

            Dim lblShift As New Label() With {.Text = "Shift:", .Location = New Point(0, yPos), .AutoSize = True, .ForeColor = Color.White}
            cmbShiftDyn = New ComboBox() With {.Location = New Point(120, yPos), .Width = 200, .DropDownStyle = ComboBoxStyle.DropDownList}
            cmbShiftDyn.Items.AddRange(New String() {"Shift 1", "Shift 2", "Shift 3"})
            If cmbShiftDyn.Items.Count > 0 Then cmbShiftDyn.SelectedIndex = 0
            PanelDynamic.Controls.Add(lblShift)
            PanelDynamic.Controls.Add(cmbShiftDyn)
            yPos += 40

            Dim lblDest As New Label() With {.Text = "Tujuan:", .Location = New Point(0, yPos), .AutoSize = True, .ForeColor = Color.White}
            txtDestinationDyn = New TextBox() With {.Location = New Point(120, yPos), .Width = 200}
            PanelDynamic.Controls.Add(lblDest)
            PanelDynamic.Controls.Add(txtDestinationDyn)
            yPos += 40

            Dim lblGrade As New Label() With {.Text = "Grade Kelapa:", .Location = New Point(0, yPos), .AutoSize = True, .ForeColor = Color.White}
            cmbGradeDyn = New ComboBox() With {.Location = New Point(120, yPos), .Width = 200, .DropDownStyle = ComboBoxStyle.DropDownList}
            PanelDynamic.Controls.Add(lblGrade)
            PanelDynamic.Controls.Add(cmbGradeDyn)

            Await LoadGradesAsync()
        End If
    End Sub

    Private Async Function LoadSuppliersAsync() As Task
        Try
            Dim client = FormHelper.GetApiClient()
            Dim req = New RestRequest("/api/master/suppliers", Method.Get)
            Dim res = Await client.ExecuteAsync(req)
            If res.IsSuccessful Then
                Dim json = JObject.Parse(res.Content)
                Dim data = json("data").ToObject(Of List(Of Dictionary(Of String, Object)))()
                cmbSupplierDyn.Items.Clear()
                supplierDict.Clear()
                For Each item In data
                    Dim id = Convert.ToInt32(item("id"))
                    Dim name = item("supplierName").ToString()
                    cmbSupplierDyn.Items.Add(name)
                    supplierDict(name) = id
                Next
                If cmbSupplierDyn.Items.Count > 0 Then cmbSupplierDyn.SelectedIndex = 0
            End If
        Catch ex As Exception
        End Try
    End Function

    Private Async Function LoadGradesAsync() As Task
        Try
            Dim client = FormHelper.GetApiClient()
            Dim req = New RestRequest("/api/master/grades", Method.Get)
            Dim res = Await client.ExecuteAsync(req)
            If res.IsSuccessful Then
                Dim json = JObject.Parse(res.Content)
                Dim data = json("data").ToObject(Of List(Of Dictionary(Of String, Object)))()
                cmbGradeDyn.Items.Clear()
                gradeDict.Clear()
                For Each item In data
                    Dim id = Convert.ToInt32(item("id"))
                    Dim name = item("gradeName").ToString()
                    cmbGradeDyn.Items.Add(name)
                    gradeDict(name) = id
                Next
                If cmbGradeDyn.Items.Count > 0 Then cmbGradeDyn.SelectedIndex = 0
            End If
        Catch ex As Exception
        End Try
    End Function

    Private Sub BtnConnect_Click(sender As Object, e As EventArgs) Handles BtnConnect.Click
        If SerialPort1.IsOpen Then
            SerialPort1.Close()
            BtnConnect.Text = "Connect"
            BtnConnect.BackColor = Color.SeaGreen
            LblStatus.Text = "Disconnected"
            LblStatus.ForeColor = Color.LightCoral
        Else
            Try
                If CmbComPort.SelectedItem Is Nothing Then
                    MessageBox.Show("Pilih COM Port dulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                SerialPort1.PortName = CmbComPort.SelectedItem.ToString()
                SerialPort1.BaudRate = 9600
                SerialPort1.Open()

                BtnConnect.Text = "Disconnect"
                BtnConnect.BackColor = Color.Crimson
                LblStatus.Text = "Connected to " & SerialPort1.PortName
                LblStatus.ForeColor = Color.LimeGreen
            Catch ex As Exception
                MessageBox.Show("Gagal terkoneksi: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Try
            Dim data As String = SerialPort1.ReadLine()
            ' Ekstrak angka dari data (bisa "Distance: 197.69" atau murni angka)
            Dim match = Regex.Match(data, "\d+(\.\d+)?")
            If match.Success Then
                Dim weightStr As String = match.Value
                ' Perbarui UI dari thread Serial
                Me.Invoke(Sub()
                              LblRealtimeWeight.Text = weightStr
                          End Sub)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Async Sub BtnInputData_Click(sender As Object, e As EventArgs) Handles BtnInputData.Click
        Try
            Dim beratRealtime As Decimal
            If Not Decimal.TryParse(LblRealtimeWeight.Text, beratRealtime) Then
                MessageBox.Show("Berat timbangan tidak valid atau belum terhubung!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim client = FormHelper.GetApiClient()
            Dim isOutbound = (CmbTransactionType.SelectedIndex = 1)

            If Not isOutbound Then
                ' POST INBOUND TICKET
                If String.IsNullOrWhiteSpace(txtTicketDyn.Text) OrElse cmbSupplierDyn.SelectedIndex = -1 Then
                    MessageBox.Show("No Tiket dan Supplier harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                Dim beratTara As Decimal = 0
                Decimal.TryParse(txtTaraDyn.Text, beratTara)

                Dim suppId As Integer = supplierDict(cmbSupplierDyn.SelectedItem.ToString())

                Dim request = New RestRequest("/api/inbound/ticket", Method.Post)
                request.AddJsonBody(New With {
                    .TicketNo = txtTicketDyn.Text,
                    .SupplierId = suppId,
                    .TruckPlate = txtPlatDyn.Text,
                    .WeightBruto = beratRealtime,
                    .WeightTara = beratTara
                })

                Dim res = Await client.ExecuteAsync(request)
                If res.IsSuccessful Then
                    MessageBox.Show("Tiket Inbound berhasil disimpan dengan berat " & beratRealtime & "!\", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If SerialPort1.IsOpen Then SerialPort1.Write("1")
                    txtTicketDyn.Clear()
                    txtPlatDyn.Clear()
                    txtTaraDyn.Clear()
                Else
                    MessageBox.Show("Gagal menyimpan tiket: " & res.Content, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Else
                ' POST OUTBOUND ISSUE
                If String.IsNullOrWhiteSpace(txtIssueDyn.Text) OrElse cmbGradeDyn.SelectedIndex = -1 Then
                    MessageBox.Show("No Issue dan Grade harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                Dim gradeId As Integer = gradeDict(cmbGradeDyn.SelectedItem.ToString())

                Dim request = New RestRequest("/api/outbound/issue", Method.Post)
                request.AddJsonBody(New With {
                    .IssueNo = txtIssueDyn.Text,
                    .Shift = cmbShiftDyn.SelectedItem.ToString(),
                    .Destination = txtDestinationDyn.Text,
                    .GradeId = gradeId,
                    .Qty = beratRealtime,
                    .CreatedBy = FormHelper.LoggedInUserId
                })

                Dim res = Await client.ExecuteAsync(request)
                If res.IsSuccessful Then
                    MessageBox.Show("Outbound Issue berhasil disimpan dengan kuantitas " & beratRealtime & "!\", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If SerialPort1.IsOpen Then SerialPort1.Write("1")
                    txtIssueDyn.Clear()
                    txtDestinationDyn.Clear()
                Else
                    MessageBox.Show("Gagal menyimpan outbound: " & res.Content, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan sistem: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnConnect_DragDrop(sender As Object, e As DragEventArgs) Handles BtnConnect.DragDrop

    End Sub
End Class




