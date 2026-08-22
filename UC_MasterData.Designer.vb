<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_MasterData
    Inherits System.Windows.Forms.UserControl

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlMainDashboard = New System.Windows.Forms.Panel()
        Me.pnlAktivitas = New System.Windows.Forms.Panel()
        Me.dgvAktivitas = New System.Windows.Forms.DataGridView()
        Me.lblAktivitas = New ReaLTaiizor.Controls.MetroLabel()
        Me.pnlSummaryWrap = New System.Windows.Forms.Panel()
        Me.tbllytDashboard = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlTiketMsk = New System.Windows.Forms.Panel()
        Me.lblJumTikMsk = New ReaLTaiizor.Controls.MetroLabel()
        Me.lblTikMsk = New ReaLTaiizor.Controls.MetroLabel()
        Me.pnlTonMsk = New System.Windows.Forms.Panel()
        Me.lblTonMsk = New ReaLTaiizor.Controls.MetroLabel()
        Me.lblJumTonMsk = New ReaLTaiizor.Controls.MetroLabel()
        Me.pnlPending = New System.Windows.Forms.Panel()
        Me.lblJumPending = New ReaLTaiizor.Controls.MetroLabel()
        Me.lblPending = New ReaLTaiizor.Controls.MetroLabel()
        Me.pnlTonKlr = New System.Windows.Forms.Panel()
        Me.lblJumTonKlr = New ReaLTaiizor.Controls.MetroLabel()
        Me.lblTonKlr = New ReaLTaiizor.Controls.MetroLabel()
        Me.pnlTotGudang = New System.Windows.Forms.Panel()
        Me.lblJumTotGudang = New ReaLTaiizor.Controls.MetroLabel()
        Me.lblTotGudang = New ReaLTaiizor.Controls.MetroLabel()
        Me.pnlSupplier = New System.Windows.Forms.Panel()
        Me.lblJumSupplier = New ReaLTaiizor.Controls.MetroLabel()
        Me.lblSupplier = New ReaLTaiizor.Controls.MetroLabel()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblWelcome = New ReaLTaiizor.Controls.NightLabel()
        Me.lblHeader = New ReaLTaiizor.Controls.NightLabel()
        Me.lblJamTanggal = New ReaLTaiizor.Controls.NightLabel()
        Me.TimerJam = New System.Windows.Forms.Timer(Me.components)
        Me.pnlMainDashboard.SuspendLayout()
        Me.pnlAktivitas.SuspendLayout()
        CType(Me.dgvAktivitas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSummaryWrap.SuspendLayout()
        Me.tbllytDashboard.SuspendLayout()
        Me.pnlTiketMsk.SuspendLayout()
        Me.pnlTonMsk.SuspendLayout()
        Me.pnlPending.SuspendLayout()
        Me.pnlTonKlr.SuspendLayout()
        Me.pnlTotGudang.SuspendLayout()
        Me.pnlSupplier.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMainDashboard
        '
        Me.pnlMainDashboard.Controls.Add(Me.pnlAktivitas)
        Me.pnlMainDashboard.Controls.Add(Me.pnlSummaryWrap)
        Me.pnlMainDashboard.Controls.Add(Me.pnlHeader)
        Me.pnlMainDashboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMainDashboard.Location = New System.Drawing.Point(0, 0)
        Me.pnlMainDashboard.Name = "pnlMainDashboard"
        Me.pnlMainDashboard.Size = New System.Drawing.Size(1035, 783)
        Me.pnlMainDashboard.TabIndex = 0
        '
        'pnlAktivitas
        '
        Me.pnlAktivitas.Controls.Add(Me.dgvAktivitas)
        Me.pnlAktivitas.Controls.Add(Me.lblAktivitas)
        Me.pnlAktivitas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlAktivitas.Location = New System.Drawing.Point(0, 362)
        Me.pnlAktivitas.Name = "pnlAktivitas"
        Me.pnlAktivitas.Padding = New System.Windows.Forms.Padding(10, 5, 10, 10)
        Me.pnlAktivitas.Size = New System.Drawing.Size(1035, 421)
        Me.pnlAktivitas.TabIndex = 2
        '
        'dgvAktivitas
        '
        Me.dgvAktivitas.AllowUserToAddRows = False
        Me.dgvAktivitas.AllowUserToDeleteRows = False
        Me.dgvAktivitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAktivitas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.dgvAktivitas.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAktivitas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvAktivitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(55, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAktivitas.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvAktivitas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvAktivitas.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.dgvAktivitas.Location = New System.Drawing.Point(10, 35)
        Me.dgvAktivitas.Name = "dgvAktivitas"
        Me.dgvAktivitas.ReadOnly = True
        Me.dgvAktivitas.RowHeadersVisible = False
        Me.dgvAktivitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAktivitas.Size = New System.Drawing.Size(1015, 376)
        Me.dgvAktivitas.TabIndex = 1
        '
        'lblAktivitas
        '
        Me.lblAktivitas.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblAktivitas.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblAktivitas.IsDerivedStyle = True
        Me.lblAktivitas.Location = New System.Drawing.Point(10, 5)
        Me.lblAktivitas.Name = "lblAktivitas"
        Me.lblAktivitas.Size = New System.Drawing.Size(1015, 30)
        Me.lblAktivitas.Style = ReaLTaiizor.[Enum].Metro.Style.Dark
        Me.lblAktivitas.StyleManager = Nothing
        Me.lblAktivitas.TabIndex = 0
        Me.lblAktivitas.Text = "📋  Aktivitas Terakhir"
        Me.lblAktivitas.ThemeAuthor = "Taiizor"
        Me.lblAktivitas.ThemeName = "MetroDark"
        '
        'pnlSummaryWrap
        '
        Me.pnlSummaryWrap.Controls.Add(Me.tbllytDashboard)
        Me.pnlSummaryWrap.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSummaryWrap.Location = New System.Drawing.Point(0, 72)
        Me.pnlSummaryWrap.Name = "pnlSummaryWrap"
        Me.pnlSummaryWrap.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlSummaryWrap.Size = New System.Drawing.Size(1035, 290)
        Me.pnlSummaryWrap.TabIndex = 1
        '
        'tbllytDashboard
        '
        Me.tbllytDashboard.ColumnCount = 3
        Me.tbllytDashboard.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3!))
        Me.tbllytDashboard.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3!))
        Me.tbllytDashboard.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.4!))
        Me.tbllytDashboard.Controls.Add(Me.pnlTiketMsk, 0, 0)
        Me.tbllytDashboard.Controls.Add(Me.pnlTonMsk, 1, 0)
        Me.tbllytDashboard.Controls.Add(Me.pnlPending, 2, 0)
        Me.tbllytDashboard.Controls.Add(Me.pnlTonKlr, 0, 1)
        Me.tbllytDashboard.Controls.Add(Me.pnlTotGudang, 1, 1)
        Me.tbllytDashboard.Controls.Add(Me.pnlSupplier, 2, 1)
        Me.tbllytDashboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbllytDashboard.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.tbllytDashboard.Location = New System.Drawing.Point(10, 10)
        Me.tbllytDashboard.Name = "tbllytDashboard"
        Me.tbllytDashboard.RowCount = 2
        Me.tbllytDashboard.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tbllytDashboard.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tbllytDashboard.Size = New System.Drawing.Size(1015, 270)
        Me.tbllytDashboard.TabIndex = 0
        '
        'pnlTiketMsk
        '
        Me.pnlTiketMsk.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.pnlTiketMsk.Controls.Add(Me.lblJumTikMsk)
        Me.pnlTiketMsk.Controls.Add(Me.lblTikMsk)
        Me.pnlTiketMsk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTiketMsk.Location = New System.Drawing.Point(5, 5)
        Me.pnlTiketMsk.Margin = New System.Windows.Forms.Padding(5)
        Me.pnlTiketMsk.Name = "pnlTiketMsk"
        Me.pnlTiketMsk.Size = New System.Drawing.Size(327, 125)
        Me.pnlTiketMsk.TabIndex = 0
        '
        'lblJumTikMsk
        '
        Me.lblJumTikMsk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblJumTikMsk.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold)
        Me.lblJumTikMsk.IsDerivedStyle = True
        Me.lblJumTikMsk.Location = New System.Drawing.Point(0, 28)
        Me.lblJumTikMsk.Name = "lblJumTikMsk"
        Me.lblJumTikMsk.Size = New System.Drawing.Size(327, 97)
        Me.lblJumTikMsk.Style = ReaLTaiizor.[Enum].Metro.Style.Light
        Me.lblJumTikMsk.StyleManager = Nothing
        Me.lblJumTikMsk.TabIndex = 1
        Me.lblJumTikMsk.Text = "—"
        Me.lblJumTikMsk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblJumTikMsk.ThemeAuthor = "Taiizor"
        Me.lblJumTikMsk.ThemeName = "MetroLight"
        '
        'lblTikMsk
        '
        Me.lblTikMsk.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTikMsk.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblTikMsk.IsDerivedStyle = True
        Me.lblTikMsk.Location = New System.Drawing.Point(0, 0)
        Me.lblTikMsk.Name = "lblTikMsk"
        Me.lblTikMsk.Size = New System.Drawing.Size(327, 28)
        Me.lblTikMsk.Style = ReaLTaiizor.[Enum].Metro.Style.Light
        Me.lblTikMsk.StyleManager = Nothing
        Me.lblTikMsk.TabIndex = 0
        Me.lblTikMsk.Text = "🎫  TIKET MASUK HARI INI"
        Me.lblTikMsk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblTikMsk.ThemeAuthor = "Taiizor"
        Me.lblTikMsk.ThemeName = "MetroLight"
        '
        'pnlTonMsk
        '
        Me.pnlTonMsk.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.pnlTonMsk.Controls.Add(Me.lblTonMsk)
        Me.pnlTonMsk.Controls.Add(Me.lblJumTonMsk)
        Me.pnlTonMsk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTonMsk.Location = New System.Drawing.Point(342, 5)
        Me.pnlTonMsk.Margin = New System.Windows.Forms.Padding(5)
        Me.pnlTonMsk.Name = "pnlTonMsk"
        Me.pnlTonMsk.Size = New System.Drawing.Size(327, 125)
        Me.pnlTonMsk.TabIndex = 1
        '
        'lblTonMsk
        '
        Me.lblTonMsk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTonMsk.Font = New System.Drawing.Font("Segoe UI", 28.0!, System.Drawing.FontStyle.Bold)
        Me.lblTonMsk.IsDerivedStyle = True
        Me.lblTonMsk.Location = New System.Drawing.Point(0, 28)
        Me.lblTonMsk.Name = "lblTonMsk"
        Me.lblTonMsk.Size = New System.Drawing.Size(327, 97)
        Me.lblTonMsk.Style = ReaLTaiizor.[Enum].Metro.Style.Light
        Me.lblTonMsk.StyleManager = Nothing
        Me.lblTonMsk.TabIndex = 1
        Me.lblTonMsk.Text = "— Kg"
        Me.lblTonMsk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblTonMsk.ThemeAuthor = "Taiizor"
        Me.lblTonMsk.ThemeName = "MetroLight"
        '
        'lblJumTonMsk
        '
        Me.lblJumTonMsk.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblJumTonMsk.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblJumTonMsk.IsDerivedStyle = True
        Me.lblJumTonMsk.Location = New System.Drawing.Point(0, 0)
        Me.lblJumTonMsk.Name = "lblJumTonMsk"
        Me.lblJumTonMsk.Size = New System.Drawing.Size(327, 28)
        Me.lblJumTonMsk.Style = ReaLTaiizor.[Enum].Metro.Style.Light
        Me.lblJumTonMsk.StyleManager = Nothing
        Me.lblJumTonMsk.TabIndex = 0
        Me.lblJumTonMsk.Text = "⚖  TONASE MASUK (NETTO)"
        Me.lblJumTonMsk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblJumTonMsk.ThemeAuthor = "Taiizor"
        Me.lblJumTonMsk.ThemeName = "MetroLight"
        '
        'pnlPending
        '
        Me.pnlPending.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnlPending.Controls.Add(Me.lblJumPending)
        Me.pnlPending.Controls.Add(Me.lblPending)
        Me.pnlPending.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlPending.Location = New System.Drawing.Point(679, 5)
        Me.pnlPending.Margin = New System.Windows.Forms.Padding(5)
        Me.pnlPending.Name = "pnlPending"
        Me.pnlPending.Size = New System.Drawing.Size(331, 125)
        Me.pnlPending.TabIndex = 2
        '
        'lblJumPending
        '
        Me.lblJumPending.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblJumPending.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold)
        Me.lblJumPending.IsDerivedStyle = True
        Me.lblJumPending.Location = New System.Drawing.Point(0, 28)
        Me.lblJumPending.Name = "lblJumPending"
        Me.lblJumPending.Size = New System.Drawing.Size(331, 97)
        Me.lblJumPending.Style = ReaLTaiizor.[Enum].Metro.Style.Light
        Me.lblJumPending.StyleManager = Nothing
        Me.lblJumPending.TabIndex = 1
        Me.lblJumPending.Text = "—"
        Me.lblJumPending.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblJumPending.ThemeAuthor = "Taiizor"
        Me.lblJumPending.ThemeName = "MetroLight"
        '
        'lblPending
        '
        Me.lblPending.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPending.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblPending.IsDerivedStyle = True
        Me.lblPending.Location = New System.Drawing.Point(0, 0)
        Me.lblPending.Name = "lblPending"
        Me.lblPending.Size = New System.Drawing.Size(331, 28)
        Me.lblPending.Style = ReaLTaiizor.[Enum].Metro.Style.Light
        Me.lblPending.StyleManager = Nothing
        Me.lblPending.TabIndex = 0
        Me.lblPending.Text = "⏳  PENDING QC"
        Me.lblPending.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblPending.ThemeAuthor = "Taiizor"
        Me.lblPending.ThemeName = "MetroLight"
        '
        'pnlTonKlr
        '
        Me.pnlTonKlr.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pnlTonKlr.Controls.Add(Me.lblJumTonKlr)
        Me.pnlTonKlr.Controls.Add(Me.lblTonKlr)
        Me.pnlTonKlr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTonKlr.Location = New System.Drawing.Point(5, 140)
        Me.pnlTonKlr.Margin = New System.Windows.Forms.Padding(5)
        Me.pnlTonKlr.Name = "pnlTonKlr"
        Me.pnlTonKlr.Size = New System.Drawing.Size(327, 125)
        Me.pnlTonKlr.TabIndex = 3
        '
        'lblJumTonKlr
        '
        Me.lblJumTonKlr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblJumTonKlr.Font = New System.Drawing.Font("Segoe UI", 28.0!, System.Drawing.FontStyle.Bold)
        Me.lblJumTonKlr.IsDerivedStyle = True
        Me.lblJumTonKlr.Location = New System.Drawing.Point(0, 28)
        Me.lblJumTonKlr.Name = "lblJumTonKlr"
        Me.lblJumTonKlr.Size = New System.Drawing.Size(327, 97)
        Me.lblJumTonKlr.Style = ReaLTaiizor.[Enum].Metro.Style.Light
        Me.lblJumTonKlr.StyleManager = Nothing
        Me.lblJumTonKlr.TabIndex = 1
        Me.lblJumTonKlr.Text = "— Kg"
        Me.lblJumTonKlr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblJumTonKlr.ThemeAuthor = "Taiizor"
        Me.lblJumTonKlr.ThemeName = "MetroLight"
        '
        'lblTonKlr
        '
        Me.lblTonKlr.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTonKlr.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblTonKlr.IsDerivedStyle = True
        Me.lblTonKlr.Location = New System.Drawing.Point(0, 0)
        Me.lblTonKlr.Name = "lblTonKlr"
        Me.lblTonKlr.Size = New System.Drawing.Size(327, 28)
        Me.lblTonKlr.Style = ReaLTaiizor.[Enum].Metro.Style.Light
        Me.lblTonKlr.StyleManager = Nothing
        Me.lblTonKlr.TabIndex = 0
        Me.lblTonKlr.Text = "📦  TONASE KELUAR"
        Me.lblTonKlr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblTonKlr.ThemeAuthor = "Taiizor"
        Me.lblTonKlr.ThemeName = "MetroLight"
        '
        'pnlTotGudang
        '
        Me.pnlTotGudang.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.pnlTotGudang.Controls.Add(Me.lblJumTotGudang)
        Me.pnlTotGudang.Controls.Add(Me.lblTotGudang)
        Me.pnlTotGudang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTotGudang.Location = New System.Drawing.Point(342, 140)
        Me.pnlTotGudang.Margin = New System.Windows.Forms.Padding(5)
        Me.pnlTotGudang.Name = "pnlTotGudang"
        Me.pnlTotGudang.Size = New System.Drawing.Size(327, 125)
        Me.pnlTotGudang.TabIndex = 4
        '
        'lblJumTotGudang
        '
        Me.lblJumTotGudang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblJumTotGudang.Font = New System.Drawing.Font("Segoe UI", 28.0!, System.Drawing.FontStyle.Bold)
        Me.lblJumTotGudang.IsDerivedStyle = True
        Me.lblJumTotGudang.Location = New System.Drawing.Point(0, 28)
        Me.lblJumTotGudang.Name = "lblJumTotGudang"
        Me.lblJumTotGudang.Size = New System.Drawing.Size(327, 97)
        Me.lblJumTotGudang.Style = ReaLTaiizor.[Enum].Metro.Style.Light
        Me.lblJumTotGudang.StyleManager = Nothing
        Me.lblJumTotGudang.TabIndex = 1
        Me.lblJumTotGudang.Text = "— Kg"
        Me.lblJumTotGudang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblJumTotGudang.ThemeAuthor = "Taiizor"
        Me.lblJumTotGudang.ThemeName = "MetroLight"
        '
        'lblTotGudang
        '
        Me.lblTotGudang.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTotGudang.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotGudang.IsDerivedStyle = True
        Me.lblTotGudang.Location = New System.Drawing.Point(0, 0)
        Me.lblTotGudang.Name = "lblTotGudang"
        Me.lblTotGudang.Size = New System.Drawing.Size(327, 28)
        Me.lblTotGudang.Style = ReaLTaiizor.[Enum].Metro.Style.Light
        Me.lblTotGudang.StyleManager = Nothing
        Me.lblTotGudang.TabIndex = 0
        Me.lblTotGudang.Text = "🏭  TOTAL STOK GUDANG"
        Me.lblTotGudang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblTotGudang.ThemeAuthor = "Taiizor"
        Me.lblTotGudang.ThemeName = "MetroLight"
        '
        'pnlSupplier
        '
        Me.pnlSupplier.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.pnlSupplier.Controls.Add(Me.lblJumSupplier)
        Me.pnlSupplier.Controls.Add(Me.lblSupplier)
        Me.pnlSupplier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSupplier.Location = New System.Drawing.Point(679, 140)
        Me.pnlSupplier.Margin = New System.Windows.Forms.Padding(5)
        Me.pnlSupplier.Name = "pnlSupplier"
        Me.pnlSupplier.Size = New System.Drawing.Size(331, 125)
        Me.pnlSupplier.TabIndex = 5
        '
        'lblJumSupplier
        '
        Me.lblJumSupplier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblJumSupplier.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold)
        Me.lblJumSupplier.IsDerivedStyle = True
        Me.lblJumSupplier.Location = New System.Drawing.Point(0, 28)
        Me.lblJumSupplier.Name = "lblJumSupplier"
        Me.lblJumSupplier.Size = New System.Drawing.Size(331, 97)
        Me.lblJumSupplier.Style = ReaLTaiizor.[Enum].Metro.Style.Light
        Me.lblJumSupplier.StyleManager = Nothing
        Me.lblJumSupplier.TabIndex = 1
        Me.lblJumSupplier.Text = "—"
        Me.lblJumSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblJumSupplier.ThemeAuthor = "Taiizor"
        Me.lblJumSupplier.ThemeName = "MetroLight"
        '
        'lblSupplier
        '
        Me.lblSupplier.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblSupplier.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblSupplier.IsDerivedStyle = True
        Me.lblSupplier.Location = New System.Drawing.Point(0, 0)
        Me.lblSupplier.Name = "lblSupplier"
        Me.lblSupplier.Size = New System.Drawing.Size(331, 28)
        Me.lblSupplier.Style = ReaLTaiizor.[Enum].Metro.Style.Light
        Me.lblSupplier.StyleManager = Nothing
        Me.lblSupplier.TabIndex = 0
        Me.lblSupplier.Text = "👥  SUPPLIER AKTIF"
        Me.lblSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblSupplier.ThemeAuthor = "Taiizor"
        Me.lblSupplier.ThemeName = "MetroLight"
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblJamTanggal)
        Me.pnlHeader.Controls.Add(Me.lblWelcome)
        Me.pnlHeader.Controls.Add(Me.lblHeader)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1035, 72)
        Me.pnlHeader.TabIndex = 0
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblWelcome.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.lblWelcome.Location = New System.Drawing.Point(22, 46)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(104, 15)
        Me.lblWelcome.TabIndex = 1
        Me.lblWelcome.Text = "Selamat datang, ..."
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.BackColor = System.Drawing.Color.Transparent
        Me.lblHeader.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeader.ForeColor = System.Drawing.Color.White
        Me.lblHeader.Location = New System.Drawing.Point(20, 10)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(416, 32)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "🏠  RMD APP — Dashboard Utama"
        '
        'lblJamTanggal
        '
        Me.lblJamTanggal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblJamTanggal.AutoSize = True
        Me.lblJamTanggal.BackColor = System.Drawing.Color.Transparent
        Me.lblJamTanggal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblJamTanggal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.lblJamTanggal.Location = New System.Drawing.Point(983, 27)
        Me.lblJamTanggal.Name = "lblJamTanggal"
        Me.lblJamTanggal.Size = New System.Drawing.Size(28, 15)
        Me.lblJamTanggal.TabIndex = 2
        Me.lblJamTanggal.Text = "Jam"
        Me.lblJamTanggal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TimerJam
        '
        Me.TimerJam.Enabled = True
        Me.TimerJam.Interval = 1000
        '
        'UC_MasterData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Controls.Add(Me.pnlMainDashboard)
        Me.Name = "UC_MasterData"
        Me.Size = New System.Drawing.Size(1035, 783)
        Me.pnlMainDashboard.ResumeLayout(False)
        Me.pnlAktivitas.ResumeLayout(False)
        CType(Me.dgvAktivitas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSummaryWrap.ResumeLayout(False)
        Me.tbllytDashboard.ResumeLayout(False)
        Me.pnlTiketMsk.ResumeLayout(False)
        Me.pnlTonMsk.ResumeLayout(False)
        Me.pnlPending.ResumeLayout(False)
        Me.pnlTonKlr.ResumeLayout(False)
        Me.pnlTotGudang.ResumeLayout(False)
        Me.pnlSupplier.ResumeLayout(False)
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMainDashboard As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblHeader As ReaLTaiizor.Controls.NightLabel
    Friend WithEvents lblWelcome As ReaLTaiizor.Controls.NightLabel
    Friend WithEvents pnlSummaryWrap As Panel
    Friend WithEvents tbllytDashboard As TableLayoutPanel
    Friend WithEvents pnlTiketMsk As Panel
    Friend WithEvents pnlTonMsk As Panel
    Friend WithEvents pnlPending As Panel
    Friend WithEvents pnlTonKlr As Panel
    Friend WithEvents pnlTotGudang As Panel
    Friend WithEvents pnlSupplier As Panel
    Friend WithEvents lblJumTonMsk As ReaLTaiizor.Controls.MetroLabel
    Friend WithEvents lblTonMsk As ReaLTaiizor.Controls.MetroLabel
    Friend WithEvents lblJumPending As ReaLTaiizor.Controls.MetroLabel
    Friend WithEvents lblPending As ReaLTaiizor.Controls.MetroLabel
    Friend WithEvents lblJumTikMsk As ReaLTaiizor.Controls.MetroLabel
    Friend WithEvents lblTikMsk As ReaLTaiizor.Controls.MetroLabel
    Friend WithEvents lblJumTonKlr As ReaLTaiizor.Controls.MetroLabel
    Friend WithEvents lblTonKlr As ReaLTaiizor.Controls.MetroLabel
    Friend WithEvents lblTotGudang As ReaLTaiizor.Controls.MetroLabel
    Friend WithEvents lblJumTotGudang As ReaLTaiizor.Controls.MetroLabel
    Friend WithEvents lblSupplier As ReaLTaiizor.Controls.MetroLabel
    Friend WithEvents lblJumSupplier As ReaLTaiizor.Controls.MetroLabel
    Friend WithEvents pnlAktivitas As Panel
    Friend WithEvents lblAktivitas As ReaLTaiizor.Controls.MetroLabel
    Friend WithEvents dgvAktivitas As DataGridView
    Friend WithEvents lblJamTanggal As ReaLTaiizor.Controls.NightLabel
    Friend WithEvents TimerJam As Timer
End Class
