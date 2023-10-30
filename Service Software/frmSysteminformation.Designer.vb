<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSysteminformation
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
        Me.tbComputerInformation = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtRam = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtProcessor = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtOSVersion = New System.Windows.Forms.TextBox()
        Me.txtSubnetMask = New System.Windows.Forms.TextBox()
        Me.txtIpAddress = New System.Windows.Forms.TextBox()
        Me.txtMACAddress = New System.Windows.Forms.TextBox()
        Me.txtOSBit = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.txtOS = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbComputerInformation.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbComputerInformation
        '
        Me.tbComputerInformation.Controls.Add(Me.TabPage2)
        Me.tbComputerInformation.Location = New System.Drawing.Point(3, 2)
        Me.tbComputerInformation.Name = "tbComputerInformation"
        Me.tbComputerInformation.SelectedIndex = 0
        Me.tbComputerInformation.Size = New System.Drawing.Size(461, 260)
        Me.tbComputerInformation.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Moccasin
        Me.TabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TabPage2.Controls.Add(Me.txtRam)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.txtProcessor)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.txtOSVersion)
        Me.TabPage2.Controls.Add(Me.txtSubnetMask)
        Me.TabPage2.Controls.Add(Me.txtIpAddress)
        Me.TabPage2.Controls.Add(Me.txtMACAddress)
        Me.TabPage2.Controls.Add(Me.txtOSBit)
        Me.TabPage2.Controls.Add(Me.txtUserName)
        Me.TabPage2.Controls.Add(Me.txtOS)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(453, 234)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "System Information"
        '
        'txtRam
        '
        Me.txtRam.BackColor = System.Drawing.Color.PapayaWhip
        Me.txtRam.Enabled = False
        Me.txtRam.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtRam.ForeColor = System.Drawing.Color.Red
        Me.txtRam.Location = New System.Drawing.Point(109, 132)
        Me.txtRam.Name = "txtRam"
        Me.txtRam.Size = New System.Drawing.Size(340, 23)
        Me.txtRam.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(71, 136)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "RAM"
        '
        'txtProcessor
        '
        Me.txtProcessor.BackColor = System.Drawing.Color.PapayaWhip
        Me.txtProcessor.Enabled = False
        Me.txtProcessor.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtProcessor.ForeColor = System.Drawing.Color.Red
        Me.txtProcessor.Location = New System.Drawing.Point(109, 108)
        Me.txtProcessor.Name = "txtProcessor"
        Me.txtProcessor.Size = New System.Drawing.Size(340, 23)
        Me.txtProcessor.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(48, 112)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Processor"
        '
        'txtOSVersion
        '
        Me.txtOSVersion.BackColor = System.Drawing.Color.PapayaWhip
        Me.txtOSVersion.Enabled = False
        Me.txtOSVersion.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtOSVersion.ForeColor = System.Drawing.Color.Red
        Me.txtOSVersion.Location = New System.Drawing.Point(109, 60)
        Me.txtOSVersion.Name = "txtOSVersion"
        Me.txtOSVersion.Size = New System.Drawing.Size(340, 23)
        Me.txtOSVersion.TabIndex = 13
        '
        'txtSubnetMask
        '
        Me.txtSubnetMask.BackColor = System.Drawing.Color.PapayaWhip
        Me.txtSubnetMask.Enabled = False
        Me.txtSubnetMask.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtSubnetMask.ForeColor = System.Drawing.Color.Red
        Me.txtSubnetMask.Location = New System.Drawing.Point(109, 204)
        Me.txtSubnetMask.Name = "txtSubnetMask"
        Me.txtSubnetMask.Size = New System.Drawing.Size(340, 23)
        Me.txtSubnetMask.TabIndex = 12
        '
        'txtIpAddress
        '
        Me.txtIpAddress.BackColor = System.Drawing.Color.PapayaWhip
        Me.txtIpAddress.Enabled = False
        Me.txtIpAddress.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtIpAddress.ForeColor = System.Drawing.Color.Red
        Me.txtIpAddress.Location = New System.Drawing.Point(109, 180)
        Me.txtIpAddress.Name = "txtIpAddress"
        Me.txtIpAddress.Size = New System.Drawing.Size(340, 23)
        Me.txtIpAddress.TabIndex = 11
        '
        'txtMACAddress
        '
        Me.txtMACAddress.BackColor = System.Drawing.Color.PapayaWhip
        Me.txtMACAddress.Enabled = False
        Me.txtMACAddress.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtMACAddress.ForeColor = System.Drawing.Color.Red
        Me.txtMACAddress.Location = New System.Drawing.Point(109, 156)
        Me.txtMACAddress.Name = "txtMACAddress"
        Me.txtMACAddress.Size = New System.Drawing.Size(340, 23)
        Me.txtMACAddress.TabIndex = 10
        '
        'txtOSBit
        '
        Me.txtOSBit.BackColor = System.Drawing.Color.PapayaWhip
        Me.txtOSBit.Enabled = False
        Me.txtOSBit.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtOSBit.ForeColor = System.Drawing.Color.Red
        Me.txtOSBit.Location = New System.Drawing.Point(109, 84)
        Me.txtOSBit.Name = "txtOSBit"
        Me.txtOSBit.Size = New System.Drawing.Size(340, 23)
        Me.txtOSBit.TabIndex = 9
        '
        'txtUserName
        '
        Me.txtUserName.BackColor = System.Drawing.Color.PapayaWhip
        Me.txtUserName.Enabled = False
        Me.txtUserName.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtUserName.ForeColor = System.Drawing.Color.Red
        Me.txtUserName.Location = New System.Drawing.Point(109, 11)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(340, 23)
        Me.txtUserName.TabIndex = 8
        '
        'txtOS
        '
        Me.txtOS.BackColor = System.Drawing.Color.PapayaWhip
        Me.txtOS.Enabled = False
        Me.txtOS.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtOS.ForeColor = System.Drawing.Color.Red
        Me.txtOS.Location = New System.Drawing.Point(109, 36)
        Me.txtOS.Name = "txtOS"
        Me.txtOS.Size = New System.Drawing.Size(340, 23)
        Me.txtOS.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(60, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Version"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(32, 208)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Subnet Mask"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(44, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "IP Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(31, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "MAC Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(53, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "OS Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(42, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "User Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(9, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Operating System"
        '
        'frmSysteminformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(462, 264)
        Me.Controls.Add(Me.tbComputerInformation)
        Me.Name = "frmSysteminformation"
        Me.Text = "System Information"
        Me.tbComputerInformation.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbComputerInformation As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txtOSVersion As TextBox
    Friend WithEvents txtSubnetMask As TextBox
    Friend WithEvents txtIpAddress As TextBox
    Friend WithEvents txtMACAddress As TextBox
    Friend WithEvents txtOSBit As TextBox
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents txtOS As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtRam As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtProcessor As TextBox
    Friend WithEvents Label10 As Label
End Class
