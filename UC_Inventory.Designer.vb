<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Inventory
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
        Me.lblInventory = New ReaLTaiizor.Controls.BigLabel()
        Me.pnlHeaderInventory = New System.Windows.Forms.Panel()
        Me.RpvInventory = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BtnRefreshInventory = New ReaLTaiizor.Controls.ForeverButton()
        Me.pnlHeaderInventory.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblInventory
        '
        Me.lblInventory.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblInventory.AutoSize = True
        Me.lblInventory.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblInventory.Font = New System.Drawing.Font("Segoe UI", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInventory.ForeColor = System.Drawing.Color.White
        Me.lblInventory.Location = New System.Drawing.Point(515, 28)
        Me.lblInventory.Name = "lblInventory"
        Me.lblInventory.Size = New System.Drawing.Size(207, 45)
        Me.lblInventory.TabIndex = 0
        Me.lblInventory.Text = "INVENTORY"
        '
        'pnlHeaderInventory
        '
        Me.pnlHeaderInventory.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnlHeaderInventory.Controls.Add(Me.BtnRefreshInventory)
        Me.pnlHeaderInventory.Controls.Add(Me.lblInventory)
        Me.pnlHeaderInventory.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeaderInventory.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeaderInventory.Name = "pnlHeaderInventory"
        Me.pnlHeaderInventory.Size = New System.Drawing.Size(1211, 100)
        Me.pnlHeaderInventory.TabIndex = 2
        '
        'RpvInventory
        '
        Me.RpvInventory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RpvInventory.Location = New System.Drawing.Point(0, 0)
        Me.RpvInventory.Name = "RpvInventory"
        Me.RpvInventory.ServerReport.BearerToken = Nothing
        Me.RpvInventory.Size = New System.Drawing.Size(1211, 548)
        Me.RpvInventory.TabIndex = 3
        '
        'BtnRefreshInventory
        '
        Me.BtnRefreshInventory.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRefreshInventory.BackColor = System.Drawing.Color.Transparent
        Me.BtnRefreshInventory.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.BtnRefreshInventory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRefreshInventory.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BtnRefreshInventory.Location = New System.Drawing.Point(1062, 28)
        Me.BtnRefreshInventory.Name = "BtnRefreshInventory"
        Me.BtnRefreshInventory.Rounded = False
        Me.BtnRefreshInventory.Size = New System.Drawing.Size(120, 40)
        Me.BtnRefreshInventory.TabIndex = 1
        Me.BtnRefreshInventory.Text = "Refresh"
        Me.BtnRefreshInventory.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'UC_Inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.RpvInventory)
        Me.Controls.Add(Me.pnlHeaderInventory)
        Me.Name = "UC_Inventory"
        Me.Size = New System.Drawing.Size(1211, 648)
        Me.pnlHeaderInventory.ResumeLayout(False)
        Me.pnlHeaderInventory.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblInventory As ReaLTaiizor.Controls.BigLabel
    Friend WithEvents pnlHeaderInventory As Panel
    Friend WithEvents BtnRefreshInventory As ReaLTaiizor.Controls.ForeverButton
    Friend WithEvents RpvInventory As Microsoft.Reporting.WinForms.ReportViewer
End Class
