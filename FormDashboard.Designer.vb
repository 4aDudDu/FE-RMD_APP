<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDashboard
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDashboard))
        Me.pnlMenuDashboard = New ReaLTaiizor.Controls.ParrotGradientPanel()
        Me.lblAppVersion = New System.Windows.Forms.Label()
        Me.btnLogout = New ReaLTaiizor.Controls.LostCancelButton()
        Me.btnExit = New ReaLTaiizor.Controls.LostCancelButton()
        Me.pctSambuGroup = New System.Windows.Forms.PictureBox()
        Me.lblAppTitle = New System.Windows.Forms.Label()
        Me.pnlMenuStrip = New ReaLTaiizor.Controls.ParrotFlatMenuStrip()
        Me.MasterDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InboundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OutboundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimbanganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.progLoading = New ReaLTaiizor.Controls.ProgressIndicator()
        Me.pnlBorder = New System.Windows.Forms.Panel()
        Me.pnlMenuDashboard.SuspendLayout()
        CType(Me.pctSambuGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMenuDashboard
        '
        Me.pnlMenuDashboard.BottomLeft = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pnlMenuDashboard.BottomRight = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.pnlMenuDashboard.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality
        Me.pnlMenuDashboard.Controls.Add(Me.lblAppVersion)
        Me.pnlMenuDashboard.Controls.Add(Me.btnLogout)
        Me.pnlMenuDashboard.Controls.Add(Me.btnExit)
        Me.pnlMenuDashboard.Controls.Add(Me.pctSambuGroup)
        Me.pnlMenuDashboard.Controls.Add(Me.lblAppTitle)
        Me.pnlMenuDashboard.Controls.Add(Me.pnlMenuStrip)
        Me.pnlMenuDashboard.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenuDashboard.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear
        Me.pnlMenuDashboard.Location = New System.Drawing.Point(0, 0)
        Me.pnlMenuDashboard.Name = "pnlMenuDashboard"
        Me.pnlMenuDashboard.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality
        Me.pnlMenuDashboard.PrimerColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.pnlMenuDashboard.Size = New System.Drawing.Size(200, 604)
        Me.pnlMenuDashboard.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        Me.pnlMenuDashboard.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners
        Me.pnlMenuDashboard.TabIndex = 0
        Me.pnlMenuDashboard.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.pnlMenuDashboard.TopLeft = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.pnlMenuDashboard.TopRight = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(55, Byte), Integer))
        '
        'lblAppVersion
        '
        Me.lblAppVersion.BackColor = System.Drawing.Color.Transparent
        Me.lblAppVersion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblAppVersion.Font = New System.Drawing.Font("Segoe UI", 7.5!)
        Me.lblAppVersion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.lblAppVersion.Location = New System.Drawing.Point(0, 524)
        Me.lblAppVersion.Name = "lblAppVersion"
        Me.lblAppVersion.Size = New System.Drawing.Size(200, 20)
        Me.lblAppVersion.TabIndex = 11
        Me.lblAppVersion.Text = "  © 2026 RMD Group"
        Me.lblAppVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.HoverColor = System.Drawing.Color.Crimson
        Me.btnLogout.Image = Nothing
        Me.btnLogout.Location = New System.Drawing.Point(0, 544)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(200, 32)
        Me.btnLogout.TabIndex = 3
        Me.btnLogout.Text = "Logout"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnExit.HoverColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnExit.Image = Nothing
        Me.btnExit.Location = New System.Drawing.Point(0, 576)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(200, 28)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Keluar Aplikasi"
        '
        'pctSambuGroup
        '
        Me.pctSambuGroup.BackColor = System.Drawing.Color.Transparent
        Me.pctSambuGroup.Dock = System.Windows.Forms.DockStyle.Top
        Me.pctSambuGroup.Image = CType(resources.GetObject("pctSambuGroup.Image"), System.Drawing.Image)
        Me.pctSambuGroup.Location = New System.Drawing.Point(0, 22)
        Me.pctSambuGroup.Margin = New System.Windows.Forms.Padding(0)
        Me.pctSambuGroup.Name = "pctSambuGroup"
        Me.pctSambuGroup.Size = New System.Drawing.Size(200, 90)
        Me.pctSambuGroup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctSambuGroup.TabIndex = 0
        Me.pctSambuGroup.TabStop = False
        '
        'lblAppTitle
        '
        Me.lblAppTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblAppTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblAppTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblAppTitle.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.lblAppTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblAppTitle.Name = "lblAppTitle"
        Me.lblAppTitle.Size = New System.Drawing.Size(200, 22)
        Me.lblAppTitle.TabIndex = 10
        Me.lblAppTitle.Text = "RMD APP - v1.0"
        Me.lblAppTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlMenuStrip
        '
        Me.pnlMenuStrip.BackColor = System.Drawing.Color.Transparent
        Me.pnlMenuStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.pnlMenuStrip.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlMenuStrip.HoverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.pnlMenuStrip.HoverTextColor = System.Drawing.Color.White
        Me.pnlMenuStrip.ItemBackColor = System.Drawing.Color.Transparent
        Me.pnlMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterDataToolStripMenuItem, Me.InboundToolStripMenuItem, Me.OutboundToolStripMenuItem, Me.TimbanganToolStripMenuItem, Me.InventoryToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.SettingsToolStripMenuItem})
        Me.pnlMenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.pnlMenuStrip.Location = New System.Drawing.Point(10, 120)
        Me.pnlMenuStrip.Name = "pnlMenuStrip"
        Me.pnlMenuStrip.Padding = New System.Windows.Forms.Padding(0)
        Me.pnlMenuStrip.SelectedBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.pnlMenuStrip.SelectedTextColor = System.Drawing.Color.White
        Me.pnlMenuStrip.SeparatorColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.pnlMenuStrip.Size = New System.Drawing.Size(118, 345)
        Me.pnlMenuStrip.TabIndex = 1
        Me.pnlMenuStrip.Text = "pnlMenuStrip"
        Me.pnlMenuStrip.TextColor = System.Drawing.Color.LightSteelBlue
        '
        'MasterDataToolStripMenuItem
        '
        Me.MasterDataToolStripMenuItem.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.MasterDataToolStripMenuItem.Name = "MasterDataToolStripMenuItem"
        Me.MasterDataToolStripMenuItem.Padding = New System.Windows.Forms.Padding(18, 13, 10, 13)
        Me.MasterDataToolStripMenuItem.Size = New System.Drawing.Size(117, 49)
        Me.MasterDataToolStripMenuItem.Text = "Dashboard"
        '
        'InboundToolStripMenuItem
        '
        Me.InboundToolStripMenuItem.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.InboundToolStripMenuItem.Name = "InboundToolStripMenuItem"
        Me.InboundToolStripMenuItem.Padding = New System.Windows.Forms.Padding(18, 13, 10, 13)
        Me.InboundToolStripMenuItem.Size = New System.Drawing.Size(117, 49)
        Me.InboundToolStripMenuItem.Text = "Inbound"
        '
        'OutboundToolStripMenuItem
        '
        Me.OutboundToolStripMenuItem.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.OutboundToolStripMenuItem.Name = "OutboundToolStripMenuItem"
        Me.OutboundToolStripMenuItem.Padding = New System.Windows.Forms.Padding(18, 13, 10, 13)
        Me.OutboundToolStripMenuItem.Size = New System.Drawing.Size(117, 49)
        Me.OutboundToolStripMenuItem.Text = "Outbound"
        '
        'TimbanganToolStripMenuItem
        '
        Me.TimbanganToolStripMenuItem.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.TimbanganToolStripMenuItem.Name = "TimbanganToolStripMenuItem"
        Me.TimbanganToolStripMenuItem.Padding = New System.Windows.Forms.Padding(18, 13, 10, 13)
        Me.TimbanganToolStripMenuItem.Size = New System.Drawing.Size(117, 49)
        Me.TimbanganToolStripMenuItem.Text = "Timbangan"
        '
        'InventoryToolStripMenuItem
        '
        Me.InventoryToolStripMenuItem.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.InventoryToolStripMenuItem.Name = "InventoryToolStripMenuItem"
        Me.InventoryToolStripMenuItem.Padding = New System.Windows.Forms.Padding(18, 13, 10, 13)
        Me.InventoryToolStripMenuItem.Size = New System.Drawing.Size(117, 49)
        Me.InventoryToolStripMenuItem.Text = "Inventory"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Padding = New System.Windows.Forms.Padding(18, 13, 10, 13)
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(117, 49)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Padding = New System.Windows.Forms.Padding(18, 13, 10, 13)
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(117, 49)
        Me.SettingsToolStripMenuItem.Text = "Pengaturan"
        '
        'pnlContent
        '
        Me.pnlContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(200, 0)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(965, 604)
        Me.pnlContent.TabIndex = 1
        '
        'progLoading
        '
        Me.progLoading.Location = New System.Drawing.Point(609, 223)
        Me.progLoading.MinimumSize = New System.Drawing.Size(50, 50)
        Me.progLoading.Name = "progLoading"
        Me.progLoading.P_AnimationColor = System.Drawing.Color.DeepSkyBlue
        Me.progLoading.P_AnimationSpeed = 80
        Me.progLoading.P_BaseColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.progLoading.Size = New System.Drawing.Size(80, 80)
        Me.progLoading.TabIndex = 0
        Me.progLoading.Text = "progLoading"
        Me.progLoading.Visible = False
        '
        'pnlBorder
        '
        Me.pnlBorder.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlBorder.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.pnlBorder.Location = New System.Drawing.Point(200, 0)
        Me.pnlBorder.Name = "pnlBorder"
        Me.pnlBorder.Size = New System.Drawing.Size(2, 604)
        Me.pnlBorder.TabIndex = 0
        '
        'FormDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1165, 604)
        Me.Controls.Add(Me.progLoading)
        Me.Controls.Add(Me.pnlContent)
        Me.Controls.Add(Me.pnlBorder)
        Me.Controls.Add(Me.pnlMenuDashboard)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.pnlMenuStrip
        Me.MinimumSize = New System.Drawing.Size(900, 600)
        Me.Name = "FormDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RMD APP - Sistem Manajemen Gudang"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlMenuDashboard.ResumeLayout(False)
        Me.pnlMenuDashboard.PerformLayout()
        CType(Me.pctSambuGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMenuStrip.ResumeLayout(False)
        Me.pnlMenuStrip.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMenuDashboard As ReaLTaiizor.Controls.ParrotGradientPanel
    Friend WithEvents pctSambuGroup As PictureBox
    Friend WithEvents pnlMenuStrip As ReaLTaiizor.Controls.ParrotFlatMenuStrip
    Friend WithEvents MasterDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InboundToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OutboundToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TimbanganToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pnlContent As Panel
    Friend WithEvents btnExit As ReaLTaiizor.Controls.LostCancelButton
    Friend WithEvents btnLogout As ReaLTaiizor.Controls.LostCancelButton
    Friend WithEvents progLoading As ReaLTaiizor.Controls.ProgressIndicator
    Friend WithEvents pnlBorder As Panel
    Friend WithEvents lblAppTitle As Label
    Friend WithEvents lblAppVersion As Label
End Class


