Imports System.Data
Imports RestSharp
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports Microsoft.Reporting.WinForms

Public Class UC_Outbound

    ' Simpan semua grade dari API untuk filter berdasarkan material
    Private _allGrades As DataTable = Nothing

    Private Sub GenerateIssueNo()
        txtIssueOutbound.Text = "ISS-" & DateTime.Now.ToString("yyMMdd-HHmmss")
    End Sub

    Private Sub LoadStaticData()
        cmbShiftOutbound.Items.Clear()
        cmbShiftOutbound.Items.Add("Shift 1")
        cmbShiftOutbound.Items.Add("Shift 2")
        cmbShiftOutbound.Items.Add("Shift 3")

        cmbTujuanOutbound.Items.Clear()
        cmbTujuanOutbound.Items.Add("Pabrik Kelapa")
        cmbTujuanOutbound.Items.Add("Pabrik Santan")
        cmbTujuanOutbound.Items.Add("Gudang Ekspor")
    End Sub

    Private Sub LoadMaterials()
        Try
            Dim client = FormHelper.GetApiClient()
            Dim request = New RestRequest("api/master/grades", Method.Get)
            Dim response = client.Execute(request)

            If response.IsSuccessful Then
                Dim jsonResponse = JObject.Parse(response.Content)
                Dim isSuccess As Boolean = False
                If jsonResponse("success") IsNot Nothing Then
                    isSuccess = jsonResponse("success").Value(Of Boolean)()
                End If

                If isSuccess Then
                    ' Simpan semua grade
                    _allGrades = JsonConvert.DeserializeObject(Of DataTable)(jsonResponse("data").ToString())

                    ' Ambil nama material yang unik untuk cmbMaterial
                    Dim materials = _allGrades.DefaultView.ToTable(True, "materialName")
                    cmbMaterialOutbound.DataSource = Nothing
                    cmbMaterialOutbound.DataSource = materials
                    cmbMaterialOutbound.DisplayMember = "materialName"
                    cmbMaterialOutbound.ValueMember = "materialName"
                    cmbMaterialOutbound.SelectedIndex = -1
                End If
            Else
                MessageBox.Show("Gagal memuat data Material dari server.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Error load material: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FilterGradeByMaterial()
        If _allGrades Is Nothing OrElse cmbMaterialOutbound.SelectedIndex = -1 Then
            cmbGradeOutbound.DataSource = Nothing
            Return
        End If

        ' Gunakan .Text untuk ambil teks yang tampil di combobox (lebih aman dari SelectedValue)
        Dim selectedMaterial As String = cmbMaterialOutbound.Text
        If String.IsNullOrEmpty(selectedMaterial) Then Return

        ' Filter grade berdasarkan material yang dipilih
        Dim filtered() As DataRow = _allGrades.Select("materialName = '" & selectedMaterial.Replace("'", "''") & "'")
        Dim filteredDt As DataTable = _allGrades.Clone()
        For Each row As DataRow In filtered
            filteredDt.ImportRow(row)
        Next

        cmbGradeOutbound.DataSource = Nothing
        cmbGradeOutbound.DataSource = filteredDt
        cmbGradeOutbound.DisplayMember = "gradeName"
        cmbGradeOutbound.ValueMember = "id"
        cmbGradeOutbound.SelectedIndex = -1
    End Sub

    Private Sub ResetForm()
        dtTanggalOutbound.Value = DateTime.Now
        cmbShiftOutbound.SelectedIndex = -1
        cmbTujuanOutbound.SelectedIndex = -1
        cmbMaterialOutbound.SelectedIndex = -1
        cmbGradeOutbound.DataSource = Nothing
        txtQty.Clear()
        GenerateIssueNo()
    End Sub

    Private Sub UC_Outbound_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIssueOutbound.ReadOnly = True

        LoadStaticData()
        LoadMaterials()
        GenerateIssueNo()
        FormHelper.RefreshReportOutbound(ReportViewer1)
        InitDeleteControls()
    End Sub

    Private Sub cmbMaterialOutbound_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMaterialOutbound.SelectedIndexChanged
        FilterGradeByMaterial()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        FormHelper.RefreshReportOutbound(ReportViewer1)
        InitDeleteControls()
    End Sub

    Private Sub btnResetOutbound_Click(sender As Object, e As EventArgs) Handles btnResetOutbound.Click
        ResetForm()
    End Sub

    Private Sub btnSimpanOutbound_Click(sender As Object, e As EventArgs) Handles btnSimpanOutbound.Click
        ' Validasi
        If cmbShiftOutbound.SelectedIndex = -1 Then
            MessageBox.Show("Mohon pilih Shift terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If cmbTujuanOutbound.SelectedIndex = -1 Then
            MessageBox.Show("Mohon pilih Tujuan terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If cmbGradeOutbound.SelectedIndex = -1 Then
            MessageBox.Show("Mohon pilih Grade/Kualitas terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If String.IsNullOrWhiteSpace(txtQty.Text) Then
            MessageBox.Show("Mohon isi Jumlah!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim qty As Decimal = 0
        If Not Decimal.TryParse(txtQty.Text, qty) OrElse qty <= 0 Then
            MessageBox.Show("Jumlah harus berupa angka positif!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim gradeId As Integer = 0
        Integer.TryParse(cmbGradeOutbound.SelectedValue?.ToString(), gradeId)

        Try
            Dim client = FormHelper.GetApiClient()
            Dim request = New RestRequest("api/outbound/issue", Method.Post)

            request.AddJsonBody(New With {
                .issueNo = txtIssueOutbound.Text,
                .shift = cmbShiftOutbound.SelectedItem.ToString(),
                .destination = cmbTujuanOutbound.SelectedItem.ToString(),
                .gradeId = gradeId,
                .qty = qty,
                .createdBy = 1
            })

            Dim response = client.Execute(request)

            If response.IsSuccessful Then
                Dim jsonResponse = JObject.Parse(response.Content)
                Dim isSuccess As Boolean = False
                If jsonResponse("success") IsNot Nothing Then
                    isSuccess = jsonResponse("success").Value(Of Boolean)()
                End If

                If isSuccess Then
                    MessageBox.Show("Data Outbound berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ResetForm()
                    FormHelper.RefreshReportOutbound(ReportViewer1)
        InitDeleteControls()
                Else
                    Dim errorMsg = If(jsonResponse("message") IsNot Nothing, jsonResponse("message").ToString(), "Gagal menyimpan data.")
                    MessageBox.Show(errorMsg, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                Dim body = If(Not String.IsNullOrEmpty(response.Content), response.Content, "Tidak ada response dari server.")
                MessageBox.Show("Gagal: " & response.StatusCode.ToString() & vbCrLf & body, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan sistem: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private WithEvents pnlDelete As New Panel()
    Private WithEvents CmbHapusIssue As New ComboBox()
    Private WithEvents BtnHapusIssue As New ReaLTaiizor.Controls.LostButton()
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

        lblHapus.Text = "Hapus Transaksi (Pilih Issue No):"
        lblHapus.ForeColor = Color.White
        lblHapus.AutoSize = True
        lblHapus.Location = New Point(10, 5)

        CmbHapusIssue.Font = New Font("Segoe UI", 10)
        CmbHapusIssue.DropDownStyle = ComboBoxStyle.DropDownList
        CmbHapusIssue.Width = 200
        CmbHapusIssue.Location = New Point(10, 30)

        BtnHapusIssue.Text = "Hapus"
        BtnHapusIssue.BackColor = Color.Crimson
        BtnHapusIssue.ForeColor = Color.White
        BtnHapusIssue.Cursor = Cursors.Hand
        BtnHapusIssue.Width = 80
        BtnHapusIssue.Height = CmbHapusIssue.Height + 5
        BtnHapusIssue.Location = New Point(CmbHapusIssue.Right + 10, CmbHapusIssue.Top)

        pnlDelete.Controls.Add(lblHapus)
        pnlDelete.Controls.Add(CmbHapusIssue)
        pnlDelete.Controls.Add(BtnHapusIssue)

        SplitContainerOutbound.Panel2.Controls.Add(pnlDelete)
        pnlDelete.BringToFront()

        LoadDeleteCombo()
    End Sub

    Private Sub LoadDeleteCombo()
        Try
            Dim dt = FormHelper.GetDataTable("SELECT id, issue_no FROM OutboundIssues ORDER BY id DESC")
            CmbHapusIssue.DataSource = dt
            CmbHapusIssue.DisplayMember = "issue_no"
            CmbHapusIssue.ValueMember = "id"
            CmbHapusIssue.SelectedIndex = -1
        Catch ex As Exception
        End Try
    End Sub

    Private Async Sub BtnHapusIssue_Click(sender As Object, e As EventArgs) Handles BtnHapusIssue.Click
        If CmbHapusIssue.SelectedIndex = -1 Then
            MessageBox.Show("Pilih issue yang ingin dihapus terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim id = CmbHapusIssue.SelectedValue.ToString()
        If MessageBox.Show("Yakin ingin menghapus issue ini? Stok inventory akan dikembalikan.", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                Dim client = FormHelper.GetApiClient()
                Dim request = New RestRequest("/api/outbound/" & id, Method.Delete)
                Dim response = Await client.ExecuteAsync(request)
                If response.IsSuccessful Then
                    MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadDeleteCombo()
                    FormHelper.RefreshReportOutbound(ReportViewer1)
                Else
                    MessageBox.Show("Gagal menghapus data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class


