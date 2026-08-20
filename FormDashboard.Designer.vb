<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDashboard))
        Me.pnlMenuDashboard = New ReaLTaiizor.Controls.ParrotGradientPanel()
        Me.btnLogout = New ReaLTaiizor.Controls.LostCancelButton()
        Me.btnExit = New ReaLTaiizor.Controls.LostCancelButton()
        Me.pctSambuGroup = New System.Windows.Forms.PictureBox()
        Me.pnlMenuStrip = New ReaLTaiizor.Controls.ParrotFlatMenuStrip()
        Me.MasterDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InboundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OutboundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.pnlMenuDashboard.BottomLeft = System.Drawing.Color.DeepSkyBlue
        Me.pnlMenuDashboard.BottomRight = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.pnlMenuDashboard.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality
        Me.pnlMenuDashboard.Controls.Add(Me.btnLogout)
        Me.pnlMenuDashboard.Controls.Add(Me.btnExit)
        Me.pnlMenuDashboard.Controls.Add(Me.pctSambuGroup)
        Me.pnlMenuDashboard.Controls.Add(Me.pnlMenuStrip)
        Me.pnlMenuDashboard.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenuDashboard.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear
        Me.pnlMenuDashboard.Location = New System.Drawing.Point(0, 0)
        Me.pnlMenuDashboard.Name = "pnlMenuDashboard"
        Me.pnlMenuDashboard.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality
        Me.pnlMenuDashboard.PrimerColor = System.Drawing.Color.DarkTurquoise
        Me.pnlMenuDashboard.Size = New System.Drawing.Size(168, 604)
        Me.pnlMenuDashboard.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        Me.pnlMenuDashboard.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners
        Me.pnlMenuDashboard.TabIndex = 0
        Me.pnlMenuDashboard.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.pnlMenuDashboard.TopLeft = System.Drawing.Color.LightBlue
        Me.pnlMenuDashboard.TopRight = System.Drawing.Color.LightSkyBlue
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Crimson
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.Font = New System.Drawing.Font("Super Jello", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.HoverColor = System.Drawing.Color.IndianRed
        Me.btnLogout.Image = Nothing
        Me.btnLogout.Location = New System.Drawing.Point(0, 544)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(168, 30)
        Me.btnLogout.TabIndex = 3
        Me.btnLogout.Text = "LOGOUT"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnExit.Font = New System.Drawing.Font("Super Jello", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.HoverColor = System.Drawing.Color.IndianRed
        Me.btnExit.Image = Nothing
        Me.btnExit.Location = New System.Drawing.Point(0, 574)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(168, 30)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "EXIT"
        '
        'pctSambuGroup
        '
        Me.pctSambuGroup.BackColor = System.Drawing.Color.Transparent
        Me.pctSambuGroup.Dock = System.Windows.Forms.DockStyle.Top
        Me.pctSambuGroup.Image = CType(resources.GetObject("pctSambuGroup.Image"), System.Drawing.Image)
        Me.pctSambuGroup.Location = New System.Drawing.Point(0, 0)
        Me.pctSambuGroup.Margin = New System.Windows.Forms.Padding(0)
        Me.pctSambuGroup.Name = "pctSambuGroup"
        Me.pctSambuGroup.Size = New System.Drawing.Size(168, 95)
        Me.pctSambuGroup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctSambuGroup.TabIndex = 0
        Me.pctSambuGroup.TabStop = False
        '
        'pnlMenuStrip
        '
        Me.pnlMenuStrip.BackColor = System.Drawing.Color.Transparent
        Me.pnlMenuStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.pnlMenuStrip.Font = New System.Drawing.Font("Super Jello", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlMenuStrip.HoverBackColor = System.Drawing.Color.DeepSkyBlue
        Me.pnlMenuStrip.HoverTextColor = System.Drawing.Color.White
        Me.pnlMenuStrip.ItemBackColor = System.Drawing.Color.DimGray
        Me.pnlMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterDataToolStripMenuItem, Me.InboundToolStripMenuItem, Me.OutboundToolStripMenuItem, Me.InventoryToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.SettingsToolStripMenuItem})
        Me.pnlMenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.pnlMenuStrip.Location = New System.Drawing.Point(0, 113)
        Me.pnlMenuStrip.Name = "pnlMenuStrip"
        Me.pnlMenuStrip.Padding = New System.Windows.Forms.Padding(0)
        Me.pnlMenuStrip.SelectedBackColor = System.Drawing.Color.DeepSkyBlue
        Me.pnlMenuStrip.SelectedTextColor = System.Drawing.Color.White
        Me.pnlMenuStrip.SeparatorColor = System.Drawing.Color.White
        Me.pnlMenuStrip.Size = New System.Drawing.Size(172, 308)
        Me.pnlMenuStrip.TabIndex = 1
        Me.pnlMenuStrip.Text = "ParrotFlatMenuStrip1"
        Me.pnlMenuStrip.TextColor = System.Drawing.Color.White
        '
        'MasterDataToolStripMenuItem
        '
        Me.MasterDataToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.MasterDataToolStripMenuItem.Name = "MasterDataToolStripMenuItem"
        Me.MasterDataToolStripMenuItem.Padding = New System.Windows.Forms.Padding(20, 15, 40, 15)
        Me.MasterDataToolStripMenuItem.Size = New System.Drawing.Size(171, 51)
        Me.MasterDataToolStripMenuItem.Text = "Master Data"
        '
        'InboundToolStripMenuItem
        '
        Me.InboundToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.InboundToolStripMenuItem.Name = "InboundToolStripMenuItem"
        Me.InboundToolStripMenuItem.Padding = New System.Windows.Forms.Padding(20, 15, 40, 15)
        Me.InboundToolStripMenuItem.Size = New System.Drawing.Size(171, 51)
        Me.InboundToolStripMenuItem.Text = "Inbound"
        '
        'OutboundToolStripMenuItem
        '
        Me.OutboundToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.OutboundToolStripMenuItem.Name = "OutboundToolStripMenuItem"
        Me.OutboundToolStripMenuItem.Padding = New System.Windows.Forms.Padding(20, 15, 40, 15)
        Me.OutboundToolStripMenuItem.Size = New System.Drawing.Size(171, 51)
        Me.OutboundToolStripMenuItem.Text = "Outbound"
        '
        'InventoryToolStripMenuItem
        '
        Me.InventoryToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.InventoryToolStripMenuItem.Name = "InventoryToolStripMenuItem"
        Me.InventoryToolStripMenuItem.Padding = New System.Windows.Forms.Padding(20, 15, 40, 15)
        Me.InventoryToolStripMenuItem.Size = New System.Drawing.Size(171, 51)
        Me.InventoryToolStripMenuItem.Text = "Inventory"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Padding = New System.Windows.Forms.Padding(20, 15, 40, 15)
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(171, 51)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Padding = New System.Windows.Forms.Padding(20, 15, 40, 15)
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(171, 51)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'pnlContent
        '
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(168, 0)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(997, 604)
        Me.pnlContent.TabIndex = 1
        '
        'progLoading
        '
        Me.progLoading.Location = New System.Drawing.Point(609, 223)
        Me.progLoading.MinimumSize = New System.Drawing.Size(50, 50)
        Me.progLoading.Name = "progLoading"
        Me.progLoading.P_AnimationColor = System.Drawing.Color.DimGray
        Me.progLoading.P_AnimationSpeed = 100
        Me.progLoading.P_BaseColor = System.Drawing.Color.DarkGray
        Me.progLoading.Size = New System.Drawing.Size(80, 80)
        Me.progLoading.TabIndex = 0
        Me.progLoading.Text = "ProgressIndicator1"
        Me.progLoading.Visible = False
        '
        'pnlBorder
        '
        Me.pnlBorder.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pnlBorder.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.pnlBorder.Location = New System.Drawing.Point(168, 1)
        Me.pnlBorder.Name = "pnlBorder"
        Me.pnlBorder.Size = New System.Drawing.Size(10, 603)
        Me.pnlBorder.TabIndex = 0
        '
        'FormDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1165, 604)
        Me.Controls.Add(Me.progLoading)
        Me.Controls.Add(Me.pnlBorder)
        Me.Controls.Add(Me.pnlContent)
        Me.Controls.Add(Me.pnlMenuDashboard)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.pnlMenuStrip
        Me.Name = "FormDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RMD APP"
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
    Friend WithEvents InventoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pnlContent As Panel
    Friend WithEvents btnExit As ReaLTaiizor.Controls.LostCancelButton
    Friend WithEvents btnLogout As ReaLTaiizor.Controls.LostCancelButton
    Friend WithEvents progLoading As ReaLTaiizor.Controls.ProgressIndicator
    Friend WithEvents pnlBorder As Panel
End Class
