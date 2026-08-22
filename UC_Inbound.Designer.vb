<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_Inbound
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.SplitContainerInbound = New System.Windows.Forms.SplitContainer()
        Me.txtPlatInbound = New ReaLTaiizor.Controls.PoisonTextBox()
        Me.lblPlatInbound = New ReaLTaiizor.Controls.LabelEdit()
        Me.lblSupKendaraanInbound = New ReaLTaiizor.Controls.LabelEdit()
        Me.cmbKendaraanInbound = New ReaLTaiizor.Controls.PoisonComboBox()
        Me.lblTanggalKendaraanInbound = New ReaLTaiizor.Controls.LabelEdit()
        Me.txtTiketInbound = New ReaLTaiizor.Controls.PoisonTextBox()
        Me.dtTanggalKendaraanInbound = New ReaLTaiizor.Controls.PoisonDateTime()
        Me.lblTiketInbound = New ReaLTaiizor.Controls.LabelEdit()
        Me.lblInformasiKendaraanInbound = New ReaLTaiizor.Controls.HeaderLabel()
        Me.btnSimpanInbound = New ReaLTaiizor.Controls.LostButton()
        Me.btnResetInbound = New ReaLTaiizor.Controls.LostButton()
        Me.txtNettoInbound = New ReaLTaiizor.Controls.PoisonTextBox()
        Me.lblNettoInbound = New ReaLTaiizor.Controls.LabelEdit()
        Me.txtTaraInbound = New ReaLTaiizor.Controls.PoisonTextBox()
        Me.lblTaraInbound = New ReaLTaiizor.Controls.LabelEdit()
        Me.txtBrutoInbound = New ReaLTaiizor.Controls.PoisonTextBox()
        Me.lblBrutoInbound = New ReaLTaiizor.Controls.LabelEdit()
        Me.lblDatTim = New ReaLTaiizor.Controls.HeaderLabel()
        Me.pnlGrapInbound = New System.Windows.Forms.Panel()
        Me.btnRefresh = New ReaLTaiizor.Controls.LostButton()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.SplitContainerInbound, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerInbound.Panel1.SuspendLayout()
        Me.SplitContainerInbound.Panel2.SuspendLayout()
        Me.SplitContainerInbound.SuspendLayout()
        Me.pnlGrapInbound.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainerInbound
        '
        Me.SplitContainerInbound.Dock = System.Windows.Forms.DockStyle.Left
        Me.SplitContainerInbound.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerInbound.Name = "SplitContainerInbound"
        Me.SplitContainerInbound.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainerInbound.Panel1
        '
        Me.SplitContainerInbound.Panel1.BackColor = System.Drawing.Color.Purple
        Me.SplitContainerInbound.Panel1.Controls.Add(Me.txtPlatInbound)
        Me.SplitContainerInbound.Panel1.Controls.Add(Me.lblPlatInbound)
        Me.SplitContainerInbound.Panel1.Controls.Add(Me.lblSupKendaraanInbound)
        Me.SplitContainerInbound.Panel1.Controls.Add(Me.cmbKendaraanInbound)
        Me.SplitContainerInbound.Panel1.Controls.Add(Me.lblTanggalKendaraanInbound)
        Me.SplitContainerInbound.Panel1.Controls.Add(Me.txtTiketInbound)
        Me.SplitContainerInbound.Panel1.Controls.Add(Me.dtTanggalKendaraanInbound)
        Me.SplitContainerInbound.Panel1.Controls.Add(Me.lblTiketInbound)
        Me.SplitContainerInbound.Panel1.Controls.Add(Me.lblInformasiKendaraanInbound)
        '
        'SplitContainerInbound.Panel2
        '
        Me.SplitContainerInbound.Panel2.BackColor = System.Drawing.Color.Purple
        Me.SplitContainerInbound.Panel2.Controls.Add(Me.btnSimpanInbound)
        Me.SplitContainerInbound.Panel2.Controls.Add(Me.btnResetInbound)
        Me.SplitContainerInbound.Panel2.Controls.Add(Me.txtNettoInbound)
        Me.SplitContainerInbound.Panel2.Controls.Add(Me.lblNettoInbound)
        Me.SplitContainerInbound.Panel2.Controls.Add(Me.txtTaraInbound)
        Me.SplitContainerInbound.Panel2.Controls.Add(Me.lblTaraInbound)
        Me.SplitContainerInbound.Panel2.Controls.Add(Me.txtBrutoInbound)
        Me.SplitContainerInbound.Panel2.Controls.Add(Me.lblBrutoInbound)
        Me.SplitContainerInbound.Panel2.Controls.Add(Me.lblDatTim)
        Me.SplitContainerInbound.Size = New System.Drawing.Size(466, 670)
        Me.SplitContainerInbound.SplitterDistance = 325
        Me.SplitContainerInbound.TabIndex = 0
        '
        'txtPlatInbound
        '
        '
        '
        '
        Me.txtPlatInbound.CustomButton.Image = Nothing
        Me.txtPlatInbound.CustomButton.Location = New System.Drawing.Point(286, 1)
        Me.txtPlatInbound.CustomButton.Name = ""
        Me.txtPlatInbound.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtPlatInbound.CustomButton.Style = ReaLTaiizor.[Enum].Poison.ColorStyle.Blue
        Me.txtPlatInbound.CustomButton.TabIndex = 1
        Me.txtPlatInbound.CustomButton.Theme = ReaLTaiizor.[Enum].Poison.ThemeStyle.Light
        Me.txtPlatInbound.CustomButton.UseSelectable = True
        Me.txtPlatInbound.CustomButton.Visible = False
        Me.txtPlatInbound.Lines = New String(-1) {}
        Me.txtPlatInbound.Location = New System.Drawing.Point(99, 225)
        Me.txtPlatInbound.MaxLength = 32767
        Me.txtPlatInbound.Name = "txtPlatInbound"
        Me.txtPlatInbound.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPlatInbound.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPlatInbound.SelectedText = ""
        Me.txtPlatInbound.SelectionLength = 0
        Me.txtPlatInbound.SelectionStart = 0
        Me.txtPlatInbound.ShortcutsEnabled = True
        Me.txtPlatInbound.Size = New System.Drawing.Size(308, 23)
        Me.txtPlatInbound.TabIndex = 9
        Me.txtPlatInbound.UseSelectable = True
        Me.txtPlatInbound.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPlatInbound.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblPlatInbound
        '
        Me.lblPlatInbound.AutoSize = True
        Me.lblPlatInbound.BackColor = System.Drawing.Color.Transparent
        Me.lblPlatInbound.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblPlatInbound.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.lblPlatInbound.Location = New System.Drawing.Point(29, 228)
        Me.lblPlatInbound.Name = "lblPlatInbound"
        Me.lblPlatInbound.Size = New System.Drawing.Size(29, 17)
        Me.lblPlatInbound.TabIndex = 8
        Me.lblPlatInbound.Text = "Plat"
        '
        'lblSupKendaraanInbound
        '
        Me.lblSupKendaraanInbound.AutoSize = True
        Me.lblSupKendaraanInbound.BackColor = System.Drawing.Color.Transparent
        Me.lblSupKendaraanInbound.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblSupKendaraanInbound.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.lblSupKendaraanInbound.Location = New System.Drawing.Point(25, 181)
        Me.lblSupKendaraanInbound.Name = "lblSupKendaraanInbound"
        Me.lblSupKendaraanInbound.Size = New System.Drawing.Size(56, 17)
        Me.lblSupKendaraanInbound.TabIndex = 7
        Me.lblSupKendaraanInbound.Text = "Supplier"
        '
        'cmbKendaraanInbound
        '
        Me.cmbKendaraanInbound.FormattingEnabled = True
        Me.cmbKendaraanInbound.ItemHeight = 23
        Me.cmbKendaraanInbound.Location = New System.Drawing.Point(98, 176)
        Me.cmbKendaraanInbound.Name = "cmbKendaraanInbound"
        Me.cmbKendaraanInbound.Size = New System.Drawing.Size(308, 29)
        Me.cmbKendaraanInbound.TabIndex = 6
        Me.cmbKendaraanInbound.UseSelectable = True
        '
        'lblTanggalKendaraanInbound
        '
        Me.lblTanggalKendaraanInbound.AutoSize = True
        Me.lblTanggalKendaraanInbound.BackColor = System.Drawing.Color.Transparent
        Me.lblTanggalKendaraanInbound.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblTanggalKendaraanInbound.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.lblTanggalKendaraanInbound.Location = New System.Drawing.Point(25, 135)
        Me.lblTanggalKendaraanInbound.Name = "lblTanggalKendaraanInbound"
        Me.lblTanggalKendaraanInbound.Size = New System.Drawing.Size(54, 17)
        Me.lblTanggalKendaraanInbound.TabIndex = 5
        Me.lblTanggalKendaraanInbound.Text = "Tanggal"
        '
        'txtTiketInbound
        '
        '
        '
        '
        Me.txtTiketInbound.CustomButton.Image = Nothing
        Me.txtTiketInbound.CustomButton.Location = New System.Drawing.Point(286, 1)
        Me.txtTiketInbound.CustomButton.Name = ""
        Me.txtTiketInbound.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtTiketInbound.CustomButton.Style = ReaLTaiizor.[Enum].Poison.ColorStyle.Blue
        Me.txtTiketInbound.CustomButton.TabIndex = 1
        Me.txtTiketInbound.CustomButton.Theme = ReaLTaiizor.[Enum].Poison.ThemeStyle.Light
        Me.txtTiketInbound.CustomButton.UseSelectable = True
        Me.txtTiketInbound.CustomButton.Visible = False
        Me.txtTiketInbound.Lines = New String(-1) {}
        Me.txtTiketInbound.Location = New System.Drawing.Point(98, 82)
        Me.txtTiketInbound.MaxLength = 32767
        Me.txtTiketInbound.Name = "txtTiketInbound"
        Me.txtTiketInbound.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTiketInbound.ReadOnly = True
        Me.txtTiketInbound.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTiketInbound.SelectedText = ""
        Me.txtTiketInbound.SelectionLength = 0
        Me.txtTiketInbound.SelectionStart = 0
        Me.txtTiketInbound.ShortcutsEnabled = True
        Me.txtTiketInbound.Size = New System.Drawing.Size(308, 23)
        Me.txtTiketInbound.TabIndex = 4
        Me.txtTiketInbound.UseSelectable = True
        Me.txtTiketInbound.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTiketInbound.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'dtTanggalKendaraanInbound
        '
        Me.dtTanggalKendaraanInbound.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium
        Me.dtTanggalKendaraanInbound.Location = New System.Drawing.Point(98, 128)
        Me.dtTanggalKendaraanInbound.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtTanggalKendaraanInbound.Name = "dtTanggalKendaraanInbound"
        Me.dtTanggalKendaraanInbound.Size = New System.Drawing.Size(308, 29)
        Me.dtTanggalKendaraanInbound.TabIndex = 3
        '
        'lblTiketInbound
        '
        Me.lblTiketInbound.AutoSize = True
        Me.lblTiketInbound.BackColor = System.Drawing.Color.Transparent
        Me.lblTiketInbound.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblTiketInbound.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.lblTiketInbound.Location = New System.Drawing.Point(26, 84)
        Me.lblTiketInbound.Name = "lblTiketInbound"
        Me.lblTiketInbound.Size = New System.Drawing.Size(60, 17)
        Me.lblTiketInbound.TabIndex = 1
        Me.lblTiketInbound.Text = "No. Tiket"
        '
        'lblInformasiKendaraanInbound
        '
        Me.lblInformasiKendaraanInbound.AutoSize = True
        Me.lblInformasiKendaraanInbound.BackColor = System.Drawing.Color.Transparent
        Me.lblInformasiKendaraanInbound.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInformasiKendaraanInbound.ForeColor = System.Drawing.Color.White
        Me.lblInformasiKendaraanInbound.Location = New System.Drawing.Point(94, 19)
        Me.lblInformasiKendaraanInbound.Name = "lblInformasiKendaraanInbound"
        Me.lblInformasiKendaraanInbound.Size = New System.Drawing.Size(268, 20)
        Me.lblInformasiKendaraanInbound.TabIndex = 0
        Me.lblInformasiKendaraanInbound.Text = "INFORMASI KENDARAAN PEMASOK"
        '
        'btnSimpanInbound
        '
        Me.btnSimpanInbound.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnSimpanInbound.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSimpanInbound.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnSimpanInbound.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSimpanInbound.ForeColor = System.Drawing.Color.White
        Me.btnSimpanInbound.HoverColor = System.Drawing.Color.DodgerBlue
        Me.btnSimpanInbound.Image = Nothing
        Me.btnSimpanInbound.Location = New System.Drawing.Point(0, 261)
        Me.btnSimpanInbound.Name = "btnSimpanInbound"
        Me.btnSimpanInbound.Size = New System.Drawing.Size(466, 40)
        Me.btnSimpanInbound.TabIndex = 19
        Me.btnSimpanInbound.Text = "SIMPAN"
        '
        'btnResetInbound
        '
        Me.btnResetInbound.BackColor = System.Drawing.Color.Red
        Me.btnResetInbound.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnResetInbound.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnResetInbound.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnResetInbound.ForeColor = System.Drawing.Color.White
        Me.btnResetInbound.HoverColor = System.Drawing.Color.DarkRed
        Me.btnResetInbound.Image = Nothing
        Me.btnResetInbound.Location = New System.Drawing.Point(0, 301)
        Me.btnResetInbound.Name = "btnResetInbound"
        Me.btnResetInbound.Size = New System.Drawing.Size(466, 40)
        Me.btnResetInbound.TabIndex = 18
        Me.btnResetInbound.Text = "RESET"
        '
        'txtNettoInbound
        '
        '
        '
        '
        Me.txtNettoInbound.CustomButton.Image = Nothing
        Me.txtNettoInbound.CustomButton.Location = New System.Drawing.Point(286, 1)
        Me.txtNettoInbound.CustomButton.Name = ""
        Me.txtNettoInbound.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtNettoInbound.CustomButton.Style = ReaLTaiizor.[Enum].Poison.ColorStyle.Blue
        Me.txtNettoInbound.CustomButton.TabIndex = 1
        Me.txtNettoInbound.CustomButton.Theme = ReaLTaiizor.[Enum].Poison.ThemeStyle.Light
        Me.txtNettoInbound.CustomButton.UseSelectable = True
        Me.txtNettoInbound.CustomButton.Visible = False
        Me.txtNettoInbound.Lines = New String(-1) {}
        Me.txtNettoInbound.Location = New System.Drawing.Point(98, 195)
        Me.txtNettoInbound.MaxLength = 32767
        Me.txtNettoInbound.Name = "txtNettoInbound"
        Me.txtNettoInbound.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNettoInbound.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNettoInbound.SelectedText = ""
        Me.txtNettoInbound.SelectionLength = 0
        Me.txtNettoInbound.SelectionStart = 0
        Me.txtNettoInbound.ShortcutsEnabled = True
        Me.txtNettoInbound.Size = New System.Drawing.Size(308, 23)
        Me.txtNettoInbound.TabIndex = 15
        Me.txtNettoInbound.UseSelectable = True
        Me.txtNettoInbound.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNettoInbound.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblNettoInbound
        '
        Me.lblNettoInbound.AutoSize = True
        Me.lblNettoInbound.BackColor = System.Drawing.Color.Transparent
        Me.lblNettoInbound.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblNettoInbound.ForeColor = System.Drawing.Color.LightGreen
        Me.lblNettoInbound.Location = New System.Drawing.Point(28, 198)
        Me.lblNettoInbound.Name = "lblNettoInbound"
        Me.lblNettoInbound.Size = New System.Drawing.Size(43, 17)
        Me.lblNettoInbound.TabIndex = 14
        Me.lblNettoInbound.Text = "Netto"
        '
        'txtTaraInbound
        '
        '
        '
        '
        Me.txtTaraInbound.CustomButton.Image = Nothing
        Me.txtTaraInbound.CustomButton.Location = New System.Drawing.Point(286, 1)
        Me.txtTaraInbound.CustomButton.Name = ""
        Me.txtTaraInbound.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtTaraInbound.CustomButton.Style = ReaLTaiizor.[Enum].Poison.ColorStyle.Blue
        Me.txtTaraInbound.CustomButton.TabIndex = 1
        Me.txtTaraInbound.CustomButton.Theme = ReaLTaiizor.[Enum].Poison.ThemeStyle.Light
        Me.txtTaraInbound.CustomButton.UseSelectable = True
        Me.txtTaraInbound.CustomButton.Visible = False
        Me.txtTaraInbound.Lines = New String(-1) {}
        Me.txtTaraInbound.Location = New System.Drawing.Point(98, 148)
        Me.txtTaraInbound.MaxLength = 32767
        Me.txtTaraInbound.Name = "txtTaraInbound"
        Me.txtTaraInbound.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTaraInbound.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTaraInbound.SelectedText = ""
        Me.txtTaraInbound.SelectionLength = 0
        Me.txtTaraInbound.SelectionStart = 0
        Me.txtTaraInbound.ShortcutsEnabled = True
        Me.txtTaraInbound.Size = New System.Drawing.Size(308, 23)
        Me.txtTaraInbound.TabIndex = 13
        Me.txtTaraInbound.UseSelectable = True
        Me.txtTaraInbound.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTaraInbound.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblTaraInbound
        '
        Me.lblTaraInbound.AutoSize = True
        Me.lblTaraInbound.BackColor = System.Drawing.Color.Transparent
        Me.lblTaraInbound.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblTaraInbound.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.lblTaraInbound.Location = New System.Drawing.Point(28, 151)
        Me.lblTaraInbound.Name = "lblTaraInbound"
        Me.lblTaraInbound.Size = New System.Drawing.Size(33, 17)
        Me.lblTaraInbound.TabIndex = 12
        Me.lblTaraInbound.Text = "Tara"
        '
        'txtBrutoInbound
        '
        '
        '
        '
        Me.txtBrutoInbound.CustomButton.Image = Nothing
        Me.txtBrutoInbound.CustomButton.Location = New System.Drawing.Point(286, 1)
        Me.txtBrutoInbound.CustomButton.Name = ""
        Me.txtBrutoInbound.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtBrutoInbound.CustomButton.Style = ReaLTaiizor.[Enum].Poison.ColorStyle.Blue
        Me.txtBrutoInbound.CustomButton.TabIndex = 1
        Me.txtBrutoInbound.CustomButton.Theme = ReaLTaiizor.[Enum].Poison.ThemeStyle.Light
        Me.txtBrutoInbound.CustomButton.UseSelectable = True
        Me.txtBrutoInbound.CustomButton.Visible = False
        Me.txtBrutoInbound.Lines = New String(-1) {}
        Me.txtBrutoInbound.Location = New System.Drawing.Point(98, 103)
        Me.txtBrutoInbound.MaxLength = 32767
        Me.txtBrutoInbound.Name = "txtBrutoInbound"
        Me.txtBrutoInbound.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBrutoInbound.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBrutoInbound.SelectedText = ""
        Me.txtBrutoInbound.SelectionLength = 0
        Me.txtBrutoInbound.SelectionStart = 0
        Me.txtBrutoInbound.ShortcutsEnabled = True
        Me.txtBrutoInbound.Size = New System.Drawing.Size(308, 23)
        Me.txtBrutoInbound.TabIndex = 11
        Me.txtBrutoInbound.UseSelectable = True
        Me.txtBrutoInbound.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBrutoInbound.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblBrutoInbound
        '
        Me.lblBrutoInbound.AutoSize = True
        Me.lblBrutoInbound.BackColor = System.Drawing.Color.Transparent
        Me.lblBrutoInbound.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblBrutoInbound.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.lblBrutoInbound.Location = New System.Drawing.Point(28, 106)
        Me.lblBrutoInbound.Name = "lblBrutoInbound"
        Me.lblBrutoInbound.Size = New System.Drawing.Size(39, 17)
        Me.lblBrutoInbound.TabIndex = 10
        Me.lblBrutoInbound.Text = "Bruto"
        '
        'lblDatTim
        '
        Me.lblDatTim.AutoSize = True
        Me.lblDatTim.BackColor = System.Drawing.Color.Transparent
        Me.lblDatTim.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatTim.ForeColor = System.Drawing.Color.White
        Me.lblDatTim.Location = New System.Drawing.Point(161, 27)
        Me.lblDatTim.Name = "lblDatTim"
        Me.lblDatTim.Size = New System.Drawing.Size(148, 20)
        Me.lblDatTim.TabIndex = 10
        Me.lblDatTim.Text = "DATA TIMBANGAN"
        '
        'pnlGrapInbound
        '
        Me.pnlGrapInbound.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.pnlGrapInbound.Controls.Add(Me.btnRefresh)
        Me.pnlGrapInbound.Controls.Add(Me.ReportViewer1)
        Me.pnlGrapInbound.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGrapInbound.Location = New System.Drawing.Point(466, 0)
        Me.pnlGrapInbound.Name = "pnlGrapInbound"
        Me.pnlGrapInbound.Size = New System.Drawing.Size(585, 670)
        Me.pnlGrapInbound.TabIndex = 1
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
        Me.btnRefresh.Location = New System.Drawing.Point(0, 630)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(585, 40)
        Me.btnRefresh.TabIndex = 1
        Me.btnRefresh.Text = "Refresh"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(585, 670)
        Me.ReportViewer1.TabIndex = 0
        '
        'UC_Inbound
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Controls.Add(Me.pnlGrapInbound)
        Me.Controls.Add(Me.SplitContainerInbound)
        Me.Name = "UC_Inbound"
        Me.Size = New System.Drawing.Size(1051, 670)
        Me.SplitContainerInbound.Panel1.ResumeLayout(False)
        Me.SplitContainerInbound.Panel1.PerformLayout()
        Me.SplitContainerInbound.Panel2.ResumeLayout(False)
        Me.SplitContainerInbound.Panel2.PerformLayout()
        CType(Me.SplitContainerInbound, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerInbound.ResumeLayout(False)
        Me.pnlGrapInbound.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainerInbound As SplitContainer
    Friend WithEvents pnlGrapInbound As Panel
    Friend WithEvents lblInformasiKendaraanInbound As ReaLTaiizor.Controls.HeaderLabel
    Friend WithEvents lblTanggalKendaraanInbound As ReaLTaiizor.Controls.LabelEdit
    Friend WithEvents txtTiketInbound As ReaLTaiizor.Controls.PoisonTextBox
    Friend WithEvents dtTanggalKendaraanInbound As ReaLTaiizor.Controls.PoisonDateTime
    Friend WithEvents lblTiketInbound As ReaLTaiizor.Controls.LabelEdit
    Friend WithEvents txtPlatInbound As ReaLTaiizor.Controls.PoisonTextBox
    Friend WithEvents lblPlatInbound As ReaLTaiizor.Controls.LabelEdit
    Friend WithEvents lblSupKendaraanInbound As ReaLTaiizor.Controls.LabelEdit
    Friend WithEvents cmbKendaraanInbound As ReaLTaiizor.Controls.PoisonComboBox
    Friend WithEvents txtNettoInbound As ReaLTaiizor.Controls.PoisonTextBox
    Friend WithEvents lblNettoInbound As ReaLTaiizor.Controls.LabelEdit
    Friend WithEvents txtTaraInbound As ReaLTaiizor.Controls.PoisonTextBox
    Friend WithEvents lblTaraInbound As ReaLTaiizor.Controls.LabelEdit
    Friend WithEvents txtBrutoInbound As ReaLTaiizor.Controls.PoisonTextBox
    Friend WithEvents lblBrutoInbound As ReaLTaiizor.Controls.LabelEdit
    Friend WithEvents lblDatTim As ReaLTaiizor.Controls.HeaderLabel
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents btnResetInbound As ReaLTaiizor.Controls.LostButton
    Friend WithEvents btnSimpanInbound As ReaLTaiizor.Controls.LostButton
    Friend WithEvents btnRefresh As ReaLTaiizor.Controls.LostButton
End Class





