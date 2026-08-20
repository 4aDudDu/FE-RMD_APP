<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLoading
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLoading))
        Me.pctSambuLogin = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgLogin = New ReaLTaiizor.Controls.PoisonProgressBar()
        CType(Me.pctSambuLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pctSambuLogin
        '
        Me.pctSambuLogin.Image = CType(resources.GetObject("pctSambuLogin.Image"), System.Drawing.Image)
        Me.pctSambuLogin.Location = New System.Drawing.Point(101, 142)
        Me.pctSambuLogin.Name = "pctSambuLogin"
        Me.pctSambuLogin.Size = New System.Drawing.Size(136, 179)
        Me.pctSambuLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctSambuLogin.TabIndex = 1
        Me.pctSambuLogin.TabStop = False
        '
        'Timer1
        '
        '
        'ProgLogin
        '
        Me.ProgLogin.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProgLogin.Location = New System.Drawing.Point(0, 457)
        Me.ProgLogin.Name = "ProgLogin"
        Me.ProgLogin.ProgressBarMarqueeWidth = 115
        Me.ProgLogin.Size = New System.Drawing.Size(346, 23)
        Me.ProgLogin.TabIndex = 2
        '
        'FrmLoading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(346, 480)
        Me.Controls.Add(Me.ProgLogin)
        Me.Controls.Add(Me.pctSambuLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(261, 61)
        Me.Name = "FrmLoading"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        CType(Me.pctSambuLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pctSambuLogin As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ProgLogin As ReaLTaiizor.Controls.PoisonProgressBar
End Class
