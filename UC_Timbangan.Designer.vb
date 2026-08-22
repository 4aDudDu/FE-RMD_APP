<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Timbangan
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
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.lblTitle = New ReaLTaiizor.Controls.HeaderLabel()
        Me.PanelSerial = New System.Windows.Forms.Panel()
        Me.CmbComPort = New ReaLTaiizor.Controls.PoisonComboBox()
        Me.BtnConnect = New ReaLTaiizor.Controls.LostButton()
        Me.LblRealtimeWeight = New ReaLTaiizor.Controls.HeaderLabel()
        Me.LblStatus = New ReaLTaiizor.Controls.HeaderLabel()
        Me.PanelInput = New System.Windows.Forms.Panel()
        Me.lblTxType = New ReaLTaiizor.Controls.HeaderLabel()
        Me.CmbTransactionType = New ReaLTaiizor.Controls.PoisonComboBox()
        Me.PanelDynamic = New System.Windows.Forms.Panel()
        Me.BtnInputData = New ReaLTaiizor.Controls.LostButton()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        
        Me.PanelTop.SuspendLayout()
        Me.PanelSerial.SuspendLayout()
        Me.PanelInput.SuspendLayout()
        Me.SuspendLayout()
        
        'PanelTop
        Me.PanelTop.Controls.Add(Me.lblTitle)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(950, 60)
        Me.PanelTop.TabIndex = 0
        
        'lblTitle
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(20, 15)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(250, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "INTEGRASI TIMBANGAN"
        
        'PanelSerial
        Me.PanelSerial.Controls.Add(Me.CmbComPort)
        Me.PanelSerial.Controls.Add(Me.BtnConnect)
        Me.PanelSerial.Controls.Add(Me.LblRealtimeWeight)
        Me.PanelSerial.Controls.Add(Me.LblStatus)
        Me.PanelSerial.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSerial.Location = New System.Drawing.Point(0, 60)
        Me.PanelSerial.Name = "PanelSerial"
        Me.PanelSerial.Size = New System.Drawing.Size(950, 120)
        Me.PanelSerial.TabIndex = 1
        
        'CmbComPort
        Me.CmbComPort.FormattingEnabled = True
        Me.CmbComPort.ItemHeight = 23
        Me.CmbComPort.Location = New System.Drawing.Point(25, 20)
        Me.CmbComPort.Name = "CmbComPort"
        Me.CmbComPort.Size = New System.Drawing.Size(150, 29)
        Me.CmbComPort.TabIndex = 0
        Me.CmbComPort.UseSelectable = True
        
        'BtnConnect
        Me.BtnConnect.BackColor = System.Drawing.Color.SeaGreen
        Me.BtnConnect.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnConnect.ForeColor = System.Drawing.Color.White
        Me.BtnConnect.HoverColor = System.Drawing.Color.MediumSeaGreen
        Me.BtnConnect.Image = Nothing
        Me.BtnConnect.Location = New System.Drawing.Point(190, 20)
        Me.BtnConnect.Name = "BtnConnect"
        Me.BtnConnect.Size = New System.Drawing.Size(120, 30)
        Me.BtnConnect.TabIndex = 1
        Me.BtnConnect.Text = "Connect"
        
        'LblStatus
        Me.LblStatus.AutoSize = True
        Me.LblStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LblStatus.ForeColor = System.Drawing.Color.LightCoral
        Me.LblStatus.Location = New System.Drawing.Point(25, 60)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(100, 19)
        Me.LblStatus.TabIndex = 2
        Me.LblStatus.Text = "Disconnected"
        
        'LblRealtimeWeight
        Me.LblRealtimeWeight.AutoSize = True
        Me.LblRealtimeWeight.Font = New System.Drawing.Font("Consolas", 48.0!, System.Drawing.FontStyle.Bold)
        Me.LblRealtimeWeight.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblRealtimeWeight.Location = New System.Drawing.Point(400, 15)
        Me.LblRealtimeWeight.Name = "LblRealtimeWeight"
        Me.LblRealtimeWeight.Size = New System.Drawing.Size(170, 75)
        Me.LblRealtimeWeight.TabIndex = 3
        Me.LblRealtimeWeight.Text = "0.00"
        
        'PanelInput
        Me.PanelInput.Controls.Add(Me.lblTxType)
        Me.PanelInput.Controls.Add(Me.CmbTransactionType)
        Me.PanelInput.Controls.Add(Me.BtnInputData)
        Me.PanelInput.Controls.Add(Me.PanelDynamic)
        Me.PanelInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelInput.Location = New System.Drawing.Point(0, 180)
        Me.PanelInput.Name = "PanelInput"
        Me.PanelInput.Size = New System.Drawing.Size(950, 400)
        Me.PanelInput.TabIndex = 2
        
        'lblTxType
        Me.lblTxType.AutoSize = True
        Me.lblTxType.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lblTxType.ForeColor = System.Drawing.Color.White
        Me.lblTxType.Location = New System.Drawing.Point(25, 10)
        Me.lblTxType.Name = "lblTxType"
        Me.lblTxType.Size = New System.Drawing.Size(100, 20)
        Me.lblTxType.TabIndex = 0
        Me.lblTxType.Text = "Tipe Transaksi:"
        
        'CmbTransactionType
        Me.CmbTransactionType.FormattingEnabled = True
        Me.CmbTransactionType.ItemHeight = 23
        Me.CmbTransactionType.Items.AddRange(New Object() {"INBOUND (Barang Masuk)", "OUTBOUND (Barang Keluar)"})
        Me.CmbTransactionType.Location = New System.Drawing.Point(140, 5)
        Me.CmbTransactionType.Name = "CmbTransactionType"
        Me.CmbTransactionType.Size = New System.Drawing.Size(250, 29)
        Me.CmbTransactionType.TabIndex = 1
        Me.CmbTransactionType.UseSelectable = True
        
        'PanelDynamic
        Me.PanelDynamic.Location = New System.Drawing.Point(25, 50)
        Me.PanelDynamic.Name = "PanelDynamic"
        Me.PanelDynamic.Size = New System.Drawing.Size(500, 250)
        Me.PanelDynamic.TabIndex = 2
        
        'BtnInputData
        Me.BtnInputData.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnInputData.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnInputData.ForeColor = System.Drawing.Color.White
        Me.BtnInputData.HoverColor = System.Drawing.Color.DeepSkyBlue
        Me.BtnInputData.Image = Nothing
        Me.BtnInputData.Location = New System.Drawing.Point(25, 320)
        Me.BtnInputData.Name = "BtnInputData"
        Me.BtnInputData.Size = New System.Drawing.Size(250, 45)
        Me.BtnInputData.TabIndex = 3
        Me.BtnInputData.Text = "Simpan & Input Data"
        
        'UC_Timbangan
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Controls.Add(Me.PanelInput)
        Me.Controls.Add(Me.PanelSerial)
        Me.Controls.Add(Me.PanelTop)
        Me.Name = "UC_Timbangan"
        Me.Size = New System.Drawing.Size(950, 580)
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTop.PerformLayout()
        Me.PanelSerial.ResumeLayout(False)
        Me.PanelSerial.PerformLayout()
        Me.PanelInput.ResumeLayout(False)
        Me.PanelInput.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    
    Friend WithEvents PanelTop As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As ReaLTaiizor.Controls.HeaderLabel
    Friend WithEvents PanelSerial As System.Windows.Forms.Panel
    Friend WithEvents CmbComPort As ReaLTaiizor.Controls.PoisonComboBox
    Friend WithEvents BtnConnect As ReaLTaiizor.Controls.LostButton
    Friend WithEvents LblRealtimeWeight As ReaLTaiizor.Controls.HeaderLabel
    Friend WithEvents LblStatus As ReaLTaiizor.Controls.HeaderLabel
    Friend WithEvents PanelInput As System.Windows.Forms.Panel
    Friend WithEvents lblTxType As ReaLTaiizor.Controls.HeaderLabel
    Friend WithEvents CmbTransactionType As ReaLTaiizor.Controls.PoisonComboBox
    Friend WithEvents PanelDynamic As System.Windows.Forms.Panel
    Friend WithEvents BtnInputData As ReaLTaiizor.Controls.LostButton
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort

End Class
