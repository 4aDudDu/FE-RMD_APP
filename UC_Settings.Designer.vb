<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Settings
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
        Me.pnlSettings = New ReaLTaiizor.Controls.NightPanel()
        Me.btnVersion = New ReaLTaiizor.Controls.DreamButton()
        Me.btnSubmitPass = New ReaLTaiizor.Controls.DreamButton()
        Me.lblPass = New ReaLTaiizor.Controls.FoxLabel()
        Me.txtPassSettings = New ReaLTaiizor.Controls.DreamTextBox()
        Me.txtIDSettings = New ReaLTaiizor.Controls.DreamTextBox()
        Me.lblPassSettings = New ReaLTaiizor.Controls.FoxLabel()
        Me.lblPasswordSettings = New ReaLTaiizor.Controls.FoxLabel()
        Me.pnlSettings.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSettings
        '
        Me.pnlSettings.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlSettings.Controls.Add(Me.btnVersion)
        Me.pnlSettings.Controls.Add(Me.btnSubmitPass)
        Me.pnlSettings.Controls.Add(Me.lblPass)
        Me.pnlSettings.Controls.Add(Me.txtPassSettings)
        Me.pnlSettings.Controls.Add(Me.txtIDSettings)
        Me.pnlSettings.Controls.Add(Me.lblPassSettings)
        Me.pnlSettings.Controls.Add(Me.lblPasswordSettings)
        Me.pnlSettings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.pnlSettings.LeftSideColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlSettings.Location = New System.Drawing.Point(314, 119)
        Me.pnlSettings.MinimumSize = New System.Drawing.Size(126, 50)
        Me.pnlSettings.Name = "pnlSettings"
        Me.pnlSettings.RightSideColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnlSettings.Side = ReaLTaiizor.Controls.NightPanel.PanelSide.Left
        Me.pnlSettings.Size = New System.Drawing.Size(525, 409)
        Me.pnlSettings.TabIndex = 0
        '
        'btnVersion
        '
        Me.btnVersion.ColorA = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnVersion.ColorB = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btnVersion.ColorC = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnVersion.ColorD = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnVersion.ColorE = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnVersion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVersion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnVersion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnVersion.Location = New System.Drawing.Point(0, 369)
        Me.btnVersion.Name = "btnVersion"
        Me.btnVersion.Size = New System.Drawing.Size(525, 40)
        Me.btnVersion.TabIndex = 6
        Me.btnVersion.Text = "Check Updates"
        Me.btnVersion.UseVisualStyleBackColor = True
        '
        'btnSubmitPass
        '
        Me.btnSubmitPass.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSubmitPass.ColorA = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.btnSubmitPass.ColorB = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btnSubmitPass.ColorC = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnSubmitPass.ColorD = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSubmitPass.ColorE = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSubmitPass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubmitPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSubmitPass.Location = New System.Drawing.Point(187, 175)
        Me.btnSubmitPass.Name = "btnSubmitPass"
        Me.btnSubmitPass.Size = New System.Drawing.Size(158, 40)
        Me.btnSubmitPass.TabIndex = 5
        Me.btnSubmitPass.Text = "Ganti Password"
        Me.btnSubmitPass.UseVisualStyleBackColor = True
        '
        'lblPass
        '
        Me.lblPass.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblPass.BackColor = System.Drawing.Color.Transparent
        Me.lblPass.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass.ForeColor = System.Drawing.Color.White
        Me.lblPass.Location = New System.Drawing.Point(186, 32)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(167, 39)
        Me.lblPass.TabIndex = 4
        Me.lblPass.Text = "Ganti Password"
        '
        'txtPassSettings
        '
        Me.txtPassSettings.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtPassSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.txtPassSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassSettings.ColorA = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.txtPassSettings.ColorB = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.txtPassSettings.ColorC = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txtPassSettings.ColorD = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtPassSettings.ColorE = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassSettings.ColorF = System.Drawing.Color.Black
        Me.txtPassSettings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassSettings.Location = New System.Drawing.Point(111, 127)
        Me.txtPassSettings.Name = "txtPassSettings"
        Me.txtPassSettings.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassSettings.Size = New System.Drawing.Size(364, 20)
        Me.txtPassSettings.TabIndex = 3
        '
        'txtIDSettings
        '
        Me.txtIDSettings.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtIDSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.txtIDSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIDSettings.ColorA = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.txtIDSettings.ColorB = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.txtIDSettings.ColorC = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txtIDSettings.ColorD = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtIDSettings.ColorE = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIDSettings.ColorF = System.Drawing.Color.Black
        Me.txtIDSettings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtIDSettings.Location = New System.Drawing.Point(111, 86)
        Me.txtIDSettings.Name = "txtIDSettings"
        Me.txtIDSettings.ReadOnly = True
        Me.txtIDSettings.Size = New System.Drawing.Size(364, 20)
        Me.txtIDSettings.TabIndex = 2
        '
        'lblPassSettings
        '
        Me.lblPassSettings.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblPassSettings.BackColor = System.Drawing.Color.Transparent
        Me.lblPassSettings.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblPassSettings.ForeColor = System.Drawing.Color.White
        Me.lblPassSettings.Location = New System.Drawing.Point(24, 127)
        Me.lblPassSettings.Name = "lblPassSettings"
        Me.lblPassSettings.Size = New System.Drawing.Size(128, 23)
        Me.lblPassSettings.TabIndex = 1
        Me.lblPassSettings.Text = "Password"
        '
        'lblPasswordSettings
        '
        Me.lblPasswordSettings.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblPasswordSettings.BackColor = System.Drawing.Color.Transparent
        Me.lblPasswordSettings.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblPasswordSettings.ForeColor = System.Drawing.Color.White
        Me.lblPasswordSettings.Location = New System.Drawing.Point(24, 87)
        Me.lblPasswordSettings.Name = "lblPasswordSettings"
        Me.lblPasswordSettings.Size = New System.Drawing.Size(128, 23)
        Me.lblPasswordSettings.TabIndex = 0
        Me.lblPasswordSettings.Text = "ID"
        '
        'UC_Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Controls.Add(Me.pnlSettings)
        Me.Name = "UC_Settings"
        Me.Size = New System.Drawing.Size(1131, 715)
        Me.pnlSettings.ResumeLayout(False)
        Me.pnlSettings.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSettings As ReaLTaiizor.Controls.NightPanel
    Friend WithEvents lblPass As ReaLTaiizor.Controls.FoxLabel
    Friend WithEvents txtPassSettings As ReaLTaiizor.Controls.DreamTextBox
    Friend WithEvents txtIDSettings As ReaLTaiizor.Controls.DreamTextBox
    Friend WithEvents lblPassSettings As ReaLTaiizor.Controls.FoxLabel
    Friend WithEvents lblPasswordSettings As ReaLTaiizor.Controls.FoxLabel
    Friend WithEvents btnVersion As ReaLTaiizor.Controls.DreamButton
    Friend WithEvents btnSubmitPass As ReaLTaiizor.Controls.DreamButton
End Class
