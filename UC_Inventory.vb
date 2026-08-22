Imports Microsoft.Reporting.WinForms

Public Class UC_Inventory
    Private WithEvents pnlEdit As New Panel()
    Private WithEvents cmbGrade As New ComboBox()
    Private WithEvents txtAdjustQty As New TextBox()
    Private WithEvents btnUpdate As New Button()
    Private isEditInit As Boolean = False

    Private Sub BtnRefreshInventory_Click(sender As Object, e As EventArgs) Handles BtnRefreshInventory.Click
        FormHelper.RefreshReportInventory(RpvInventory)
    End Sub

    Private Sub UC_Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormHelper.RefreshReportInventory(RpvInventory)
        InitEditControls()
    End Sub

    Private Sub InitEditControls()
        If isEditInit Then
            LoadGrades()
            Return
        End If
        isEditInit = True

        pnlEdit.Dock = DockStyle.Bottom
        pnlEdit.Height = 70
        pnlEdit.BackColor = Color.Transparent

        Dim lblTitle As New Label()
        lblTitle.Text = "Edit / Penyesuaian Stok Gudang:"
        lblTitle.ForeColor = Color.White
        lblTitle.AutoSize = True
        lblTitle.Location = New Point(10, 5)
        lblTitle.Font = New Font("Segoe UI", 10, FontStyle.Bold)

        cmbGrade.Font = New Font("Segoe UI", 10)
        cmbGrade.DropDownStyle = ComboBoxStyle.DropDownList
        cmbGrade.Width = 250
        cmbGrade.Location = New Point(10, 30)

        Dim lblQty As New Label()
        lblQty.Text = "Jumlah (Kg):"
        lblQty.ForeColor = Color.White
        lblQty.AutoSize = True
        lblQty.Location = New Point(270, 32)

        txtAdjustQty.Font = New Font("Segoe UI", 10)
        txtAdjustQty.Width = 100
        txtAdjustQty.Location = New Point(360, 30)

        Dim lblHelp As New Label()
        lblHelp.Text = "*(Gunakan minus (-) untuk mengurangi stok)*"
        lblHelp.ForeColor = Color.LightGray
        lblHelp.AutoSize = True
        lblHelp.Location = New Point(470, 32)

        btnUpdate.Text = "Update Stok"
        btnUpdate.BackColor = Color.DarkOrange
        btnUpdate.ForeColor = Color.White
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        btnUpdate.Location = New Point(700, 28)
        btnUpdate.Width = 120
        btnUpdate.Height = 30

        pnlEdit.Controls.Add(lblTitle)
        pnlEdit.Controls.Add(cmbGrade)
        pnlEdit.Controls.Add(lblQty)
        pnlEdit.Controls.Add(txtAdjustQty)
        pnlEdit.Controls.Add(lblHelp)
        pnlEdit.Controls.Add(btnUpdate)

        Me.Controls.Add(pnlEdit)
        pnlEdit.BringToFront()

        LoadGrades()
    End Sub

    Private Sub LoadGrades()
        Try
            Dim dt = FormHelper.GetDataTable("SELECT id, grade_name FROM MaterialGrades ORDER BY id")
            cmbGrade.DataSource = dt
            cmbGrade.DisplayMember = "grade_name"
            cmbGrade.ValueMember = "id"
            cmbGrade.SelectedIndex = -1
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If cmbGrade.SelectedIndex = -1 Then
            MessageBox.Show("Pilih Material Grade terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim qty As Decimal
        If Not Decimal.TryParse(txtAdjustQty.Text, qty) Then
            MessageBox.Show("Jumlah penyesuaian harus berupa angka yang valid!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim gradeId = Convert.ToInt32(cmbGrade.SelectedValue)
        Dim gradeName = cmbGrade.Text

        If MessageBox.Show($"Yakin ingin menyesuaikan stok untuk {gradeName} sebanyak {qty} Kg?", "Konfirmasi Edit Stok", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                Dim params As New Dictionary(Of String, Object) From {
                    {"@grade_id", gradeId},
                    {"@adjust_qty", qty}
                }
                
                FormHelper.ExecuteNonQuery("EXEC sp_AdjustInventory @grade_id, @adjust_qty", params)
                
                MessageBox.Show("Stok berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtAdjustQty.Clear()
                cmbGrade.SelectedIndex = -1
                FormHelper.RefreshReportInventory(RpvInventory)
            Catch ex As Exception
                MessageBox.Show("Gagal mengupdate stok: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class



