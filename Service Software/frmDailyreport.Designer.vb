<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDailyreport
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblBranchName = New System.Windows.Forms.Label()
        Me.cmbBranch = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.optMail = New System.Windows.Forms.RadioButton()
        Me.optSMS = New System.Windows.Forms.RadioButton()
        Me.grpMail = New System.Windows.Forms.GroupBox()
        Me.lblLine = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtReceiver = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtSender = New System.Windows.Forms.TextBox()
        Me.optHotmail = New System.Windows.Forms.RadioButton()
        Me.optYahoo = New System.Windows.Forms.RadioButton()
        Me.optGmail = New System.Windows.Forms.RadioButton()
        Me.optSummery = New System.Windows.Forms.RadioButton()
        Me.optDetails = New System.Windows.Forms.RadioButton()
        Me.grpMailOption = New System.Windows.Forms.GroupBox()
        Me.grpReport = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.grpMail.SuspendLayout()
        Me.grpMailOption.SuspendLayout()
        Me.grpReport.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblBranchName)
        Me.GroupBox1.Controls.Add(Me.cmbBranch)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpTo)
        Me.GroupBox1.Controls.Add(Me.dtpFrom)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(358, 86)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Date Information"
        '
        'lblBranchName
        '
        Me.lblBranchName.BackColor = System.Drawing.Color.DarkViolet
        Me.lblBranchName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBranchName.ForeColor = System.Drawing.Color.White
        Me.lblBranchName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblBranchName.Location = New System.Drawing.Point(206, 19)
        Me.lblBranchName.Name = "lblBranchName"
        Me.lblBranchName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblBranchName.Size = New System.Drawing.Size(135, 18)
        Me.lblBranchName.TabIndex = 9
        '
        'cmbBranch
        '
        Me.cmbBranch.FormattingEnabled = True
        Me.cmbBranch.Location = New System.Drawing.Point(59, 16)
        Me.cmbBranch.Name = "cmbBranch"
        Me.cmbBranch.Size = New System.Drawing.Size(134, 21)
        Me.cmbBranch.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Branch"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(206, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "To"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "From"
        '
        'dtpTo
        '
        Me.dtpTo.CustomFormat = "dd-MMM-yy"
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTo.Location = New System.Drawing.Point(233, 49)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(108, 20)
        Me.dtpTo.TabIndex = 4
        '
        'dtpFrom
        '
        Me.dtpFrom.CustomFormat = "dd-MMM-yy"
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFrom.Location = New System.Drawing.Point(59, 49)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(134, 20)
        Me.dtpFrom.TabIndex = 3
        '
        'btnSend
        '
        Me.btnSend.BackColor = System.Drawing.Color.Purple
        Me.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSend.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSend.ForeColor = System.Drawing.Color.White
        Me.btnSend.Location = New System.Drawing.Point(13, 281)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(173, 24)
        Me.btnSend.TabIndex = 1
        Me.btnSend.Text = "&Send"
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Purple
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(204, 281)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(173, 24)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'optMail
        '
        Me.optMail.AutoSize = True
        Me.optMail.Location = New System.Drawing.Point(12, 14)
        Me.optMail.Name = "optMail"
        Me.optMail.Size = New System.Drawing.Size(44, 17)
        Me.optMail.TabIndex = 3
        Me.optMail.TabStop = True
        Me.optMail.Text = "Mail"
        Me.optMail.UseVisualStyleBackColor = True
        '
        'optSMS
        '
        Me.optSMS.AutoSize = True
        Me.optSMS.Enabled = False
        Me.optSMS.Location = New System.Drawing.Point(82, 14)
        Me.optSMS.Name = "optSMS"
        Me.optSMS.Size = New System.Drawing.Size(48, 17)
        Me.optSMS.TabIndex = 4
        Me.optSMS.TabStop = True
        Me.optSMS.Text = "SMS"
        Me.optSMS.UseVisualStyleBackColor = True
        '
        'grpMail
        '
        Me.grpMail.Controls.Add(Me.lblLine)
        Me.grpMail.Controls.Add(Me.Label5)
        Me.grpMail.Controls.Add(Me.Label4)
        Me.grpMail.Controls.Add(Me.Label3)
        Me.grpMail.Controls.Add(Me.txtReceiver)
        Me.grpMail.Controls.Add(Me.txtPassword)
        Me.grpMail.Controls.Add(Me.txtSender)
        Me.grpMail.Controls.Add(Me.optHotmail)
        Me.grpMail.Controls.Add(Me.optYahoo)
        Me.grpMail.Controls.Add(Me.optGmail)
        Me.grpMail.Location = New System.Drawing.Point(12, 147)
        Me.grpMail.Name = "grpMail"
        Me.grpMail.Size = New System.Drawing.Size(362, 131)
        Me.grpMail.TabIndex = 16
        Me.grpMail.TabStop = False
        '
        'lblLine
        '
        Me.lblLine.BackColor = System.Drawing.Color.White
        Me.lblLine.Location = New System.Drawing.Point(5, 38)
        Me.lblLine.Name = "lblLine"
        Me.lblLine.Size = New System.Drawing.Size(353, 1)
        Me.lblLine.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Receiver"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Sender"
        '
        'txtReceiver
        '
        Me.txtReceiver.Location = New System.Drawing.Point(72, 99)
        Me.txtReceiver.Name = "txtReceiver"
        Me.txtReceiver.Size = New System.Drawing.Size(280, 20)
        Me.txtReceiver.TabIndex = 24
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(72, 73)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(280, 20)
        Me.txtPassword.TabIndex = 20
        '
        'txtSender
        '
        Me.txtSender.Location = New System.Drawing.Point(72, 47)
        Me.txtSender.Name = "txtSender"
        Me.txtSender.Size = New System.Drawing.Size(280, 20)
        Me.txtSender.TabIndex = 19
        '
        'optHotmail
        '
        Me.optHotmail.AutoSize = True
        Me.optHotmail.Location = New System.Drawing.Point(192, 15)
        Me.optHotmail.Name = "optHotmail"
        Me.optHotmail.Size = New System.Drawing.Size(64, 17)
        Me.optHotmail.TabIndex = 18
        Me.optHotmail.TabStop = True
        Me.optHotmail.Text = "Hot Mail"
        Me.optHotmail.UseVisualStyleBackColor = True
        '
        'optYahoo
        '
        Me.optYahoo.AutoSize = True
        Me.optYahoo.Location = New System.Drawing.Point(130, 15)
        Me.optYahoo.Name = "optYahoo"
        Me.optYahoo.Size = New System.Drawing.Size(56, 17)
        Me.optYahoo.TabIndex = 17
        Me.optYahoo.TabStop = True
        Me.optYahoo.Text = "Yahoo"
        Me.optYahoo.UseVisualStyleBackColor = True
        '
        'optGmail
        '
        Me.optGmail.AutoSize = True
        Me.optGmail.Location = New System.Drawing.Point(74, 15)
        Me.optGmail.Name = "optGmail"
        Me.optGmail.Size = New System.Drawing.Size(51, 17)
        Me.optGmail.TabIndex = 16
        Me.optGmail.TabStop = True
        Me.optGmail.Text = "Gmail"
        Me.optGmail.UseVisualStyleBackColor = True
        '
        'optSummery
        '
        Me.optSummery.AutoSize = True
        Me.optSummery.Location = New System.Drawing.Point(89, 14)
        Me.optSummery.Name = "optSummery"
        Me.optSummery.Size = New System.Drawing.Size(68, 17)
        Me.optSummery.TabIndex = 18
        Me.optSummery.TabStop = True
        Me.optSummery.Text = "&Semmery"
        Me.optSummery.UseVisualStyleBackColor = True
        '
        'optDetails
        '
        Me.optDetails.AutoSize = True
        Me.optDetails.Enabled = False
        Me.optDetails.Location = New System.Drawing.Point(19, 14)
        Me.optDetails.Name = "optDetails"
        Me.optDetails.Size = New System.Drawing.Size(57, 17)
        Me.optDetails.TabIndex = 17
        Me.optDetails.TabStop = True
        Me.optDetails.Text = "&Details"
        Me.optDetails.UseVisualStyleBackColor = True
        '
        'grpMailOption
        '
        Me.grpMailOption.Controls.Add(Me.optMail)
        Me.grpMailOption.Controls.Add(Me.optSMS)
        Me.grpMailOption.Location = New System.Drawing.Point(11, 104)
        Me.grpMailOption.Name = "grpMailOption"
        Me.grpMailOption.Size = New System.Drawing.Size(166, 37)
        Me.grpMailOption.TabIndex = 19
        Me.grpMailOption.TabStop = False
        '
        'grpReport
        '
        Me.grpReport.Controls.Add(Me.optDetails)
        Me.grpReport.Controls.Add(Me.optSummery)
        Me.grpReport.Location = New System.Drawing.Point(183, 104)
        Me.grpReport.Name = "grpReport"
        Me.grpReport.Size = New System.Drawing.Size(187, 37)
        Me.grpReport.TabIndex = 20
        Me.grpReport.TabStop = False
        '
        'frmDailyreport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(382, 305)
        Me.Controls.Add(Me.grpReport)
        Me.Controls.Add(Me.grpMailOption)
        Me.Controls.Add(Me.grpMail)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDailyreport"
        Me.Text = "Daily  In Out"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpMail.ResumeLayout(False)
        Me.grpMail.PerformLayout()
        Me.grpMailOption.ResumeLayout(False)
        Me.grpMailOption.PerformLayout()
        Me.grpReport.ResumeLayout(False)
        Me.grpReport.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents btnSend As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents optMail As RadioButton
    Friend WithEvents optSMS As RadioButton
    Friend WithEvents grpMail As GroupBox
    Friend WithEvents optHotmail As RadioButton
    Friend WithEvents optYahoo As RadioButton
    Friend WithEvents optGmail As RadioButton
    Friend WithEvents lblLine As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtReceiver As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtSender As TextBox
    Friend WithEvents optSummery As RadioButton
    Friend WithEvents optDetails As RadioButton
    Friend WithEvents grpMailOption As GroupBox
    Friend WithEvents grpReport As GroupBox
    Friend WithEvents lblBranchName As Label
    Friend WithEvents cmbBranch As ComboBox
    Friend WithEvents Label6 As Label
End Class
