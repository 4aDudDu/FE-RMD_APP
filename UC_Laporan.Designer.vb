<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Laporan
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
        Me.pnlHeader = New ReaLTaiizor.Controls.ParrotGradientPanel()
        Me.BtnTampilkan = New ReaLTaiizor.Controls.HopeButton()
        Me.DtpEndDate = New ReaLTaiizor.Controls.PoisonDateTime()
        Me.LblEnd = New ReaLTaiizor.Controls.ForeverLabel()
        Me.DtpStartDate = New ReaLTaiizor.Controls.PoisonDateTime()
        Me.LblStart = New ReaLTaiizor.Controls.ForeverLabel()
        Me.CmbJenisLaporan = New ReaLTaiizor.Controls.PoisonComboBox()
        Me.LblJenis = New ReaLTaiizor.Controls.ForeverLabel()
        Me.PnlViewer = New System.Windows.Forms.Panel()
        Me.RpvLaporan = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.pnlHeader.SuspendLayout()
        Me.PnlViewer.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BottomLeft = System.Drawing.Color.LightCyan
        Me.pnlHeader.BottomRight = System.Drawing.Color.DeepSkyBlue
        Me.pnlHeader.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality
        Me.pnlHeader.Controls.Add(Me.BtnTampilkan)
        Me.pnlHeader.Controls.Add(Me.DtpEndDate)
        Me.pnlHeader.Controls.Add(Me.LblEnd)
        Me.pnlHeader.Controls.Add(Me.DtpStartDate)
        Me.pnlHeader.Controls.Add(Me.LblStart)
        Me.pnlHeader.Controls.Add(Me.CmbJenisLaporan)
        Me.pnlHeader.Controls.Add(Me.LblJenis)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality
        Me.pnlHeader.PrimerColor = System.Drawing.Color.White
        Me.pnlHeader.Size = New System.Drawing.Size(1232, 125)
        Me.pnlHeader.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        Me.pnlHeader.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners
        Me.pnlHeader.TabIndex = 0
        Me.pnlHeader.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.pnlHeader.TopLeft = System.Drawing.Color.DeepSkyBlue
        Me.pnlHeader.TopRight = System.Drawing.Color.DeepSkyBlue
        '
        'BtnTampilkan
        '
        Me.BtnTampilkan.BorderColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.BtnTampilkan.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary
        Me.BtnTampilkan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTampilkan.DangerColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.BtnTampilkan.DefaultColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnTampilkan.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnTampilkan.HoverTextColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.BtnTampilkan.InfoColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BtnTampilkan.Location = New System.Drawing.Point(727, 22)
        Me.BtnTampilkan.Name = "BtnTampilkan"
        Me.BtnTampilkan.PrimaryColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnTampilkan.Size = New System.Drawing.Size(120, 29)
        Me.BtnTampilkan.SuccessColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.BtnTampilkan.TabIndex = 6
        Me.BtnTampilkan.Text = "Cari"
        Me.BtnTampilkan.TextColor = System.Drawing.Color.White
        Me.BtnTampilkan.WarningColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(60, Byte), Integer))
        '
        'DtpEndDate
        '
        Me.DtpEndDate.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium
        Me.DtpEndDate.Location = New System.Drawing.Point(505, 70)
        Me.DtpEndDate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.DtpEndDate.Name = "DtpEndDate"
        Me.DtpEndDate.Size = New System.Drawing.Size(200, 29)
        Me.DtpEndDate.TabIndex = 5
        '
        'LblEnd
        '
        Me.LblEnd.AutoSize = True
        Me.LblEnd.BackColor = System.Drawing.Color.Transparent
        Me.LblEnd.Font = New System.Drawing.Font("Super Jello", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEnd.ForeColor = System.Drawing.Color.Black
        Me.LblEnd.Location = New System.Drawing.Point(430, 77)
        Me.LblEnd.Name = "LblEnd"
        Me.LblEnd.Size = New System.Drawing.Size(69, 17)
        Me.LblEnd.TabIndex = 4
        Me.LblEnd.Text = "Sampai:"
        '
        'DtpStartDate
        '
        Me.DtpStartDate.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium
        Me.DtpStartDate.Location = New System.Drawing.Point(505, 22)
        Me.DtpStartDate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.DtpStartDate.Name = "DtpStartDate"
        Me.DtpStartDate.Size = New System.Drawing.Size(200, 29)
        Me.DtpStartDate.TabIndex = 3
        '
        'LblStart
        '
        Me.LblStart.AutoSize = True
        Me.LblStart.BackColor = System.Drawing.Color.Transparent
        Me.LblStart.Font = New System.Drawing.Font("Super Jello", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStart.ForeColor = System.Drawing.Color.Black
        Me.LblStart.Location = New System.Drawing.Point(386, 27)
        Me.LblStart.Name = "LblStart"
        Me.LblStart.Size = New System.Drawing.Size(113, 17)
        Me.LblStart.TabIndex = 2
        Me.LblStart.Text = "Dari Tanggal:"
        '
        'CmbJenisLaporan
        '
        Me.CmbJenisLaporan.FormattingEnabled = True
        Me.CmbJenisLaporan.ItemHeight = 23
        Me.CmbJenisLaporan.Location = New System.Drawing.Point(164, 22)
        Me.CmbJenisLaporan.Name = "CmbJenisLaporan"
        Me.CmbJenisLaporan.Size = New System.Drawing.Size(200, 29)
        Me.CmbJenisLaporan.TabIndex = 1
        Me.CmbJenisLaporan.UseSelectable = True
        '
        'LblJenis
        '
        Me.LblJenis.AutoSize = True
        Me.LblJenis.BackColor = System.Drawing.Color.Transparent
        Me.LblJenis.Font = New System.Drawing.Font("Super Jello", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblJenis.ForeColor = System.Drawing.Color.Black
        Me.LblJenis.Location = New System.Drawing.Point(35, 27)
        Me.LblJenis.Name = "LblJenis"
        Me.LblJenis.Size = New System.Drawing.Size(123, 17)
        Me.LblJenis.TabIndex = 0
        Me.LblJenis.Text = "Jenis Laporan:"
        '
        'PnlViewer
        '
        Me.PnlViewer.Controls.Add(Me.RpvLaporan)
        Me.PnlViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlViewer.Location = New System.Drawing.Point(0, 125)
        Me.PnlViewer.Name = "PnlViewer"
        Me.PnlViewer.Size = New System.Drawing.Size(1232, 541)
        Me.PnlViewer.TabIndex = 1
        '
        'RpvLaporan
        '
        Me.RpvLaporan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RpvLaporan.Location = New System.Drawing.Point(0, 0)
        Me.RpvLaporan.Name = "RpvLaporan"
        Me.RpvLaporan.ServerReport.BearerToken = Nothing
        Me.RpvLaporan.Size = New System.Drawing.Size(1232, 541)
        Me.RpvLaporan.TabIndex = 0
        Me.RpvLaporan.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage
        '
        'UC_Laporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PnlViewer)
        Me.Controls.Add(Me.pnlHeader)
        Me.Name = "UC_Laporan"
        Me.Size = New System.Drawing.Size(1232, 666)
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.PnlViewer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As ReaLTaiizor.Controls.ParrotGradientPanel
    Friend WithEvents CmbJenisLaporan As ReaLTaiizor.Controls.PoisonComboBox
    Friend WithEvents LblJenis As ReaLTaiizor.Controls.ForeverLabel
    Friend WithEvents LblStart As ReaLTaiizor.Controls.ForeverLabel
    Friend WithEvents DtpStartDate As ReaLTaiizor.Controls.PoisonDateTime
    Friend WithEvents BtnTampilkan As ReaLTaiizor.Controls.HopeButton
    Friend WithEvents DtpEndDate As ReaLTaiizor.Controls.PoisonDateTime
    Friend WithEvents LblEnd As ReaLTaiizor.Controls.ForeverLabel
    Friend WithEvents PnlViewer As Panel
    Friend WithEvents RpvLaporan As Microsoft.Reporting.WinForms.ReportViewer
End Class
