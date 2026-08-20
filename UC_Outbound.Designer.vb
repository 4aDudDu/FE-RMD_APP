<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Outbound
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SplitContainerOutbound = New System.Windows.Forms.SplitContainer()
        Me.lblTujuanOutbound = New ReaLTaiizor.Controls.LabelEdit()
        Me.cmbTujuanOutbound = New ReaLTaiizor.Controls.PoisonComboBox()
        Me.lblShiftOutbound = New ReaLTaiizor.Controls.LabelEdit()
        Me.cmbShiftOutbound = New ReaLTaiizor.Controls.PoisonComboBox()
        Me.lblTanggalOutbound = New ReaLTaiizor.Controls.LabelEdit()
        Me.dtTanggalOutbound = New ReaLTaiizor.Controls.PoisonDateTime()
        Me.txtIssueOutbound = New ReaLTaiizor.Controls.PoisonTextBox()
        Me.lblDocOutbound = New ReaLTaiizor.Controls.LabelEdit()
        Me.lblInfoPengOutbound = New ReaLTaiizor.Controls.HeaderLabel()
        Me.btnSimpanOutbound = New ReaLTaiizor.Controls.LostButton()
        Me.btnResetOutbound = New ReaLTaiizor.Controls.LostButton()
        Me.lblJumlahOutbound = New ReaLTaiizor.Controls.LabelEdit()
        Me.txtQty = New ReaLTaiizor.Controls.PoisonTextBox()
        Me.LabelEdit2 = New ReaLTaiizor.Controls.LabelEdit()
        Me.cmbGradeOutbound = New ReaLTaiizor.Controls.PoisonComboBox()
        Me.lblDatMatOutbound = New ReaLTaiizor.Controls.HeaderLabel()
        Me.lblMaterialOutbound = New ReaLTaiizor.Controls.LabelEdit()
        Me.cmbMaterialOutbound = New ReaLTaiizor.Controls.PoisonComboBox()
        Me.pnlGrapOutbound = New System.Windows.Forms.Panel()
        Me.btnRefresh = New ReaLTaiizor.Controls.LostButton()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.SplitContainerOutbound, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerOutbound.Panel1.SuspendLayout()
        Me.SplitContainerOutbound.Panel2.SuspendLayout()
        Me.SplitContainerOutbound.SuspendLayout()
        Me.pnlGrapOutbound.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainerOutbound
        '
        Me.SplitContainerOutbound.Dock = System.Windows.Forms.DockStyle.Left
        Me.SplitContainerOutbound.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerOutbound.Name = "SplitContainerOutbound"
        Me.SplitContainerOutbound.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainerOutbound.Panel1
        '
        Me.SplitContainerOutbound.Panel1.Controls.Add(Me.lblTujuanOutbound)
        Me.SplitContainerOutbound.Panel1.Controls.Add(Me.cmbTujuanOutbound)
        Me.SplitContainerOutbound.Panel1.Controls.Add(Me.lblShiftOutbound)
        Me.SplitContainerOutbound.Panel1.Controls.Add(Me.cmbShiftOutbound)
        Me.SplitContainerOutbound.Panel1.Controls.Add(Me.lblTanggalOutbound)
        Me.SplitContainerOutbound.Panel1.Controls.Add(Me.dtTanggalOutbound)
        Me.SplitContainerOutbound.Panel1.Controls.Add(Me.txtIssueOutbound)
        Me.SplitContainerOutbound.Panel1.Controls.Add(Me.lblDocOutbound)
        Me.SplitContainerOutbound.Panel1.Controls.Add(Me.lblInfoPengOutbound)
        '
        'SplitContainerOutbound.Panel2
        '
        Me.SplitContainerOutbound.Panel2.Controls.Add(Me.btnSimpanOutbound)
        Me.SplitContainerOutbound.Panel2.Controls.Add(Me.btnResetOutbound)
        Me.SplitContainerOutbound.Panel2.Controls.Add(Me.lblJumlahOutbound)
        Me.SplitContainerOutbound.Panel2.Controls.Add(Me.txtQty)
        Me.SplitContainerOutbound.Panel2.Controls.Add(Me.LabelEdit2)
        Me.SplitContainerOutbound.Panel2.Controls.Add(Me.cmbGradeOutbound)
        Me.SplitContainerOutbound.Panel2.Controls.Add(Me.lblDatMatOutbound)
        Me.SplitContainerOutbound.Panel2.Controls.Add(Me.lblMaterialOutbound)
        Me.SplitContainerOutbound.Panel2.Controls.Add(Me.cmbMaterialOutbound)
        Me.SplitContainerOutbound.Size = New System.Drawing.Size(488, 653)
        Me.SplitContainerOutbound.SplitterDistance = 330
        Me.SplitContainerOutbound.TabIndex = 0
        '
        'lblTujuanOutbound
        '
        Me.lblTujuanOutbound.AutoSize = True
        Me.lblTujuanOutbound.BackColor = System.Drawing.Color.Transparent
        Me.lblTujuanOutbound.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblTujuanOutbound.ForeColor = System.Drawing.Color.Black
        Me.lblTujuanOutbound.Location = New System.Drawing.Point(77, 219)
        Me.lblTujuanOutbound.Name = "lblTujuanOutbound"
        Me.lblTujuanOutbound.Size = New System.Drawing.Size(45, 15)
        Me.lblTujuanOutbound.TabIndex = 12
        Me.lblTujuanOutbound.Text = "Tujuan"
        '
        'cmbTujuanOutbound
        '
        Me.cmbTujuanOutbound.FormattingEnabled = True
        Me.cmbTujuanOutbound.ItemHeight = 23
        Me.cmbTujuanOutbound.Location = New System.Drawing.Point(128, 213)
        Me.cmbTujuanOutbound.Name = "cmbTujuanOutbound"
        Me.cmbTujuanOutbound.Size = New System.Drawing.Size(308, 29)
        Me.cmbTujuanOutbound.TabIndex = 11
        Me.cmbTujuanOutbound.UseSelectable = True
        '
        'lblShiftOutbound
        '
        Me.lblShiftOutbound.AutoSize = True
        Me.lblShiftOutbound.BackColor = System.Drawing.Color.Transparent
        Me.lblShiftOutbound.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblShiftOutbound.ForeColor = System.Drawing.Color.Black
        Me.lblShiftOutbound.Location = New System.Drawing.Point(89, 175)
        Me.lblShiftOutbound.Name = "lblShiftOutbound"
        Me.lblShiftOutbound.Size = New System.Drawing.Size(31, 15)
        Me.lblShiftOutbound.TabIndex = 10
        Me.lblShiftOutbound.Text = "Shift"
        '
        'cmbShiftOutbound
        '
        Me.cmbShiftOutbound.FormattingEnabled = True
        Me.cmbShiftOutbound.ItemHeight = 23
        Me.cmbShiftOutbound.Location = New System.Drawing.Point(128, 169)
        Me.cmbShiftOutbound.Name = "cmbShiftOutbound"
        Me.cmbShiftOutbound.Size = New System.Drawing.Size(308, 29)
        Me.cmbShiftOutbound.TabIndex = 9
        Me.cmbShiftOutbound.UseSelectable = True
        '
        'lblTanggalOutbound
        '
        Me.lblTanggalOutbound.AutoSize = True
        Me.lblTanggalOutbound.BackColor = System.Drawing.Color.Transparent
        Me.lblTanggalOutbound.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblTanggalOutbound.ForeColor = System.Drawing.Color.Black
        Me.lblTanggalOutbound.Location = New System.Drawing.Point(70, 129)
        Me.lblTanggalOutbound.Name = "lblTanggalOutbound"
        Me.lblTanggalOutbound.Size = New System.Drawing.Size(52, 15)
        Me.lblTanggalOutbound.TabIndex = 8
        Me.lblTanggalOutbound.Text = "Tanggal"
        '
        'dtTanggalOutbound
        '
        Me.dtTanggalOutbound.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium
        Me.dtTanggalOutbound.Location = New System.Drawing.Point(128, 123)
        Me.dtTanggalOutbound.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtTanggalOutbound.Name = "dtTanggalOutbound"
        Me.dtTanggalOutbound.Size = New System.Drawing.Size(308, 29)
        Me.dtTanggalOutbound.TabIndex = 7
        '
        'txtIssueOutbound
        '
        '
        '
        '
        Me.txtIssueOutbound.CustomButton.Image = Nothing
        Me.txtIssueOutbound.CustomButton.Location = New System.Drawing.Point(286, 1)
        Me.txtIssueOutbound.CustomButton.Name = ""
        Me.txtIssueOutbound.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtIssueOutbound.CustomButton.Style = ReaLTaiizor.[Enum].Poison.ColorStyle.Blue
        Me.txtIssueOutbound.CustomButton.TabIndex = 1
        Me.txtIssueOutbound.CustomButton.Theme = ReaLTaiizor.[Enum].Poison.ThemeStyle.Light
        Me.txtIssueOutbound.CustomButton.UseSelectable = True
        Me.txtIssueOutbound.CustomButton.Visible = False
        Me.txtIssueOutbound.Lines = New String(-1) {}
        Me.txtIssueOutbound.Location = New System.Drawing.Point(128, 78)
        Me.txtIssueOutbound.MaxLength = 32767
        Me.txtIssueOutbound.Name = "txtIssueOutbound"
        Me.txtIssueOutbound.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIssueOutbound.ReadOnly = True
        Me.txtIssueOutbound.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtIssueOutbound.SelectedText = ""
        Me.txtIssueOutbound.SelectionLength = 0
        Me.txtIssueOutbound.SelectionStart = 0
        Me.txtIssueOutbound.ShortcutsEnabled = True
        Me.txtIssueOutbound.Size = New System.Drawing.Size(308, 23)
        Me.txtIssueOutbound.TabIndex = 6
        Me.txtIssueOutbound.UseSelectable = True
        Me.txtIssueOutbound.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtIssueOutbound.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblDocOutbound
        '
        Me.lblDocOutbound.AutoSize = True
        Me.lblDocOutbound.BackColor = System.Drawing.Color.Transparent
        Me.lblDocOutbound.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblDocOutbound.ForeColor = System.Drawing.Color.Black
        Me.lblDocOutbound.Location = New System.Drawing.Point(40, 80)
        Me.lblDocOutbound.Name = "lblDocOutbound"
        Me.lblDocOutbound.Size = New System.Drawing.Size(83, 15)
        Me.lblDocOutbound.TabIndex = 5
        Me.lblDocOutbound.Text = "No. Dokumen"
        '
        'lblInfoPengOutbound
        '
        Me.lblInfoPengOutbound.AutoSize = True
        Me.lblInfoPengOutbound.BackColor = System.Drawing.Color.Transparent
        Me.lblInfoPengOutbound.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblInfoPengOutbound.ForeColor = System.Drawing.Color.Black
        Me.lblInfoPengOutbound.Location = New System.Drawing.Point(140, 21)
        Me.lblInfoPengOutbound.Name = "lblInfoPengOutbound"
        Me.lblInfoPengOutbound.Size = New System.Drawing.Size(208, 20)
        Me.lblInfoPengOutbound.TabIndex = 1
        Me.lblInfoPengOutbound.Text = "INFORMASI PENGELUARAN"
        '
        'btnSimpanOutbound
        '
        Me.btnSimpanOutbound.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnSimpanOutbound.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSimpanOutbound.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnSimpanOutbound.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSimpanOutbound.ForeColor = System.Drawing.Color.White
        Me.btnSimpanOutbound.HoverColor = System.Drawing.Color.DodgerBlue
        Me.btnSimpanOutbound.Image = Nothing
        Me.btnSimpanOutbound.Location = New System.Drawing.Point(0, 239)
        Me.btnSimpanOutbound.Name = "btnSimpanOutbound"
        Me.btnSimpanOutbound.Size = New System.Drawing.Size(488, 40)
        Me.btnSimpanOutbound.TabIndex = 21
        Me.btnSimpanOutbound.Text = "SIMPAN"
        '
        'btnResetOutbound
        '
        Me.btnResetOutbound.BackColor = System.Drawing.Color.Red
        Me.btnResetOutbound.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnResetOutbound.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnResetOutbound.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnResetOutbound.ForeColor = System.Drawing.Color.White
        Me.btnResetOutbound.HoverColor = System.Drawing.Color.DarkRed
        Me.btnResetOutbound.Image = Nothing
        Me.btnResetOutbound.Location = New System.Drawing.Point(0, 279)
        Me.btnResetOutbound.Name = "btnResetOutbound"
        Me.btnResetOutbound.Size = New System.Drawing.Size(488, 40)
        Me.btnResetOutbound.TabIndex = 20
        Me.btnResetOutbound.Text = "RESET"
        '
        'lblJumlahOutbound
        '
        Me.lblJumlahOutbound.AutoSize = True
        Me.lblJumlahOutbound.BackColor = System.Drawing.Color.Transparent
        Me.lblJumlahOutbound.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblJumlahOutbound.ForeColor = System.Drawing.Color.Black
        Me.lblJumlahOutbound.Location = New System.Drawing.Point(76, 182)
        Me.lblJumlahOutbound.Name = "lblJumlahOutbound"
        Me.lblJumlahOutbound.Size = New System.Drawing.Size(48, 15)
        Me.lblJumlahOutbound.TabIndex = 17
        Me.lblJumlahOutbound.Text = "Jumlah"
        '
        'txtQty
        '
        '
        '
        '
        Me.txtQty.CustomButton.Image = Nothing
        Me.txtQty.CustomButton.Location = New System.Drawing.Point(286, 1)
        Me.txtQty.CustomButton.Name = ""
        Me.txtQty.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtQty.CustomButton.Style = ReaLTaiizor.[Enum].Poison.ColorStyle.Blue
        Me.txtQty.CustomButton.TabIndex = 1
        Me.txtQty.CustomButton.Theme = ReaLTaiizor.[Enum].Poison.ThemeStyle.Light
        Me.txtQty.CustomButton.UseSelectable = True
        Me.txtQty.CustomButton.Visible = False
        Me.txtQty.Lines = New String(-1) {}
        Me.txtQty.Location = New System.Drawing.Point(128, 179)
        Me.txtQty.MaxLength = 32767
        Me.txtQty.Name = "txtQty"
        Me.txtQty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtQty.ReadOnly = False
        Me.txtQty.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtQty.SelectedText = ""
        Me.txtQty.SelectionLength = 0
        Me.txtQty.SelectionStart = 0
        Me.txtQty.ShortcutsEnabled = True
        Me.txtQty.Size = New System.Drawing.Size(308, 23)
        Me.txtQty.TabIndex = 13
        Me.txtQty.UseSelectable = True
        Me.txtQty.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtQty.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'LabelEdit2
        '
        Me.LabelEdit2.AutoSize = True
        Me.LabelEdit2.BackColor = System.Drawing.Color.Transparent
        Me.LabelEdit2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.LabelEdit2.ForeColor = System.Drawing.Color.Black
        Me.LabelEdit2.Location = New System.Drawing.Point(77, 136)
        Me.LabelEdit2.Name = "LabelEdit2"
        Me.LabelEdit2.Size = New System.Drawing.Size(51, 15)
        Me.LabelEdit2.TabIndex = 16
        Me.LabelEdit2.Text = "Kualitas"
        '
        'cmbGradeOutbound
        '
        Me.cmbGradeOutbound.FormattingEnabled = True
        Me.cmbGradeOutbound.ItemHeight = 23
        Me.cmbGradeOutbound.Location = New System.Drawing.Point(128, 130)
        Me.cmbGradeOutbound.Name = "cmbGradeOutbound"
        Me.cmbGradeOutbound.Size = New System.Drawing.Size(308, 29)
        Me.cmbGradeOutbound.TabIndex = 15
        Me.cmbGradeOutbound.UseSelectable = True
        '
        'lblDatMatOutbound
        '
        Me.lblDatMatOutbound.AutoSize = True
        Me.lblDatMatOutbound.BackColor = System.Drawing.Color.Transparent
        Me.lblDatMatOutbound.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblDatMatOutbound.ForeColor = System.Drawing.Color.Black
        Me.lblDatMatOutbound.Location = New System.Drawing.Point(185, 45)
        Me.lblDatMatOutbound.Name = "lblDatMatOutbound"
        Me.lblDatMatOutbound.Size = New System.Drawing.Size(128, 20)
        Me.lblDatMatOutbound.TabIndex = 13
        Me.lblDatMatOutbound.Text = "DATA MATERIAL"
        '
        'lblMaterialOutbound
        '
        Me.lblMaterialOutbound.AutoSize = True
        Me.lblMaterialOutbound.BackColor = System.Drawing.Color.Transparent
        Me.lblMaterialOutbound.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblMaterialOutbound.ForeColor = System.Drawing.Color.Black
        Me.lblMaterialOutbound.Location = New System.Drawing.Point(75, 88)
        Me.lblMaterialOutbound.Name = "lblMaterialOutbound"
        Me.lblMaterialOutbound.Size = New System.Drawing.Size(52, 15)
        Me.lblMaterialOutbound.TabIndex = 14
        Me.lblMaterialOutbound.Text = "Material"
        '
        'cmbMaterialOutbound
        '
        Me.cmbMaterialOutbound.FormattingEnabled = True
        Me.cmbMaterialOutbound.ItemHeight = 23
        Me.cmbMaterialOutbound.Location = New System.Drawing.Point(128, 82)
        Me.cmbMaterialOutbound.Name = "cmbMaterialOutbound"
        Me.cmbMaterialOutbound.Size = New System.Drawing.Size(308, 29)
        Me.cmbMaterialOutbound.TabIndex = 13
        Me.cmbMaterialOutbound.UseSelectable = True
        '
        'pnlGrapOutbound
        '
        Me.pnlGrapOutbound.Controls.Add(Me.btnRefresh)
        Me.pnlGrapOutbound.Controls.Add(Me.ReportViewer1)
        Me.pnlGrapOutbound.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGrapOutbound.Location = New System.Drawing.Point(488, 0)
        Me.pnlGrapOutbound.Name = "pnlGrapOutbound"
        Me.pnlGrapOutbound.Size = New System.Drawing.Size(597, 653)
        Me.pnlGrapOutbound.TabIndex = 1
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.HoverColor = System.Drawing.Color.DodgerBlue
        Me.btnRefresh.Image = Nothing
        Me.btnRefresh.Location = New System.Drawing.Point(0, 613)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(597, 40)
        Me.btnRefresh.TabIndex = 2
        Me.btnRefresh.Text = "Refresh"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(597, 653)
        Me.ReportViewer1.TabIndex = 0
        '
        'UC_Outbound
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.pnlGrapOutbound)
        Me.Controls.Add(Me.SplitContainerOutbound)
        Me.Name = "UC_Outbound"
        Me.Size = New System.Drawing.Size(1085, 653)
        Me.SplitContainerOutbound.Panel1.ResumeLayout(False)
        Me.SplitContainerOutbound.Panel1.PerformLayout()
        Me.SplitContainerOutbound.Panel2.ResumeLayout(False)
        Me.SplitContainerOutbound.Panel2.PerformLayout()
        CType(Me.SplitContainerOutbound, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerOutbound.ResumeLayout(False)
        Me.pnlGrapOutbound.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainerOutbound As SplitContainer
    Friend WithEvents pnlGrapOutbound As Panel
    Friend WithEvents lblInfoPengOutbound As ReaLTaiizor.Controls.HeaderLabel
    Friend WithEvents txtIssueOutbound As ReaLTaiizor.Controls.PoisonTextBox
    Friend WithEvents lblDocOutbound As ReaLTaiizor.Controls.LabelEdit
    Friend WithEvents lblTanggalOutbound As ReaLTaiizor.Controls.LabelEdit
    Friend WithEvents dtTanggalOutbound As ReaLTaiizor.Controls.PoisonDateTime
    Friend WithEvents lblShiftOutbound As ReaLTaiizor.Controls.LabelEdit
    Friend WithEvents cmbShiftOutbound As ReaLTaiizor.Controls.PoisonComboBox
    Friend WithEvents lblTujuanOutbound As ReaLTaiizor.Controls.LabelEdit
    Friend WithEvents cmbTujuanOutbound As ReaLTaiizor.Controls.PoisonComboBox
    Friend WithEvents lblDatMatOutbound As ReaLTaiizor.Controls.HeaderLabel
    Friend WithEvents lblMaterialOutbound As ReaLTaiizor.Controls.LabelEdit
    Friend WithEvents LabelEdit2 As ReaLTaiizor.Controls.LabelEdit
    Friend WithEvents cmbGradeOutbound As ReaLTaiizor.Controls.PoisonComboBox
    Friend WithEvents cmbMaterialOutbound As ReaLTaiizor.Controls.PoisonComboBox
    Friend WithEvents lblJumlahOutbound As ReaLTaiizor.Controls.LabelEdit
    Friend WithEvents txtQty As ReaLTaiizor.Controls.PoisonTextBox
    Friend WithEvents btnSimpanOutbound As ReaLTaiizor.Controls.LostButton
    Friend WithEvents btnResetOutbound As ReaLTaiizor.Controls.LostButton
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents btnRefresh As ReaLTaiizor.Controls.LostButton
End Class
