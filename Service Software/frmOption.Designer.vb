<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOption
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
        Me.components = New System.ComponentModel.Container()
        Me.tbComapny = New System.Windows.Forms.TabControl()
        Me.tbCompanylist = New System.Windows.Forms.TabPage()
        Me.lblDefaultCompanyName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdMakeDefault = New System.Windows.Forms.Button()
        Me.lstCompanylist = New System.Windows.Forms.ListView()
        Me.colCompanyInformationSl = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCompanyName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colOwnerName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colAddress = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colContactNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDepartment = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTotalEmployee = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tbEmailSMS = New System.Windows.Forms.TabPage()
        Me.grpMailList = New System.Windows.Forms.GroupBox()
        Me.btnMailRefresh = New System.Windows.Forms.Button()
        Me.btnMailDelete = New System.Windows.Forms.Button()
        Me.lstMailList = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cntxMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetDefaultToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnMailUpdate = New System.Windows.Forms.Button()
        Me.grpMailSection = New System.Windows.Forms.GroupBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.optCustom = New System.Windows.Forms.RadioButton()
        Me.optGmail = New System.Windows.Forms.RadioButton()
        Me.optHotMail = New System.Windows.Forms.RadioButton()
        Me.optYahoo = New System.Windows.Forms.RadioButton()
        Me.grpClientInformaion = New System.Windows.Forms.GroupBox()
        Me.chkssl = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtsmtp = New System.Windows.Forms.TextBox()
        Me.btnMailClear = New System.Windows.Forms.Button()
        Me.btnMailAdd = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.optNone = New System.Windows.Forms.RadioButton()
        Me.optSMS = New System.Windows.Forms.RadioButton()
        Me.optMail = New System.Windows.Forms.RadioButton()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.tbComapny.SuspendLayout()
        Me.tbCompanylist.SuspendLayout()
        Me.tbEmailSMS.SuspendLayout()
        Me.grpMailList.SuspendLayout()
        Me.cntxMenu.SuspendLayout()
        Me.grpMailSection.SuspendLayout()
        Me.grpClientInformaion.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbComapny
        '
        Me.tbComapny.Controls.Add(Me.tbCompanylist)
        Me.tbComapny.Controls.Add(Me.tbEmailSMS)
        Me.tbComapny.Location = New System.Drawing.Point(8, 12)
        Me.tbComapny.Name = "tbComapny"
        Me.tbComapny.SelectedIndex = 0
        Me.tbComapny.Size = New System.Drawing.Size(749, 374)
        Me.tbComapny.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.tbComapny.TabIndex = 0
        '
        'tbCompanylist
        '
        Me.tbCompanylist.BackColor = System.Drawing.SystemColors.Control
        Me.tbCompanylist.Controls.Add(Me.lblDefaultCompanyName)
        Me.tbCompanylist.Controls.Add(Me.Label1)
        Me.tbCompanylist.Controls.Add(Me.cmdMakeDefault)
        Me.tbCompanylist.Controls.Add(Me.lstCompanylist)
        Me.tbCompanylist.Location = New System.Drawing.Point(4, 22)
        Me.tbCompanylist.Name = "tbCompanylist"
        Me.tbCompanylist.Padding = New System.Windows.Forms.Padding(3)
        Me.tbCompanylist.Size = New System.Drawing.Size(741, 348)
        Me.tbCompanylist.TabIndex = 0
        Me.tbCompanylist.Text = "Company"
        '
        'lblDefaultCompanyName
        '
        Me.lblDefaultCompanyName.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblDefaultCompanyName.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDefaultCompanyName.Location = New System.Drawing.Point(174, 6)
        Me.lblDefaultCompanyName.Name = "lblDefaultCompanyName"
        Me.lblDefaultCompanyName.Size = New System.Drawing.Size(554, 23)
        Me.lblDefaultCompanyName.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Default Company Set for Report:"
        '
        'cmdMakeDefault
        '
        Me.cmdMakeDefault.Location = New System.Drawing.Point(594, 323)
        Me.cmdMakeDefault.Name = "cmdMakeDefault"
        Me.cmdMakeDefault.Size = New System.Drawing.Size(141, 23)
        Me.cmdMakeDefault.TabIndex = 15
        Me.cmdMakeDefault.Text = "Make Default"
        Me.cmdMakeDefault.UseVisualStyleBackColor = True
        '
        'lstCompanylist
        '
        Me.lstCompanylist.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colCompanyInformationSl, Me.colCompanyName, Me.colOwnerName, Me.colAddress, Me.colContactNo, Me.colDepartment, Me.colTotalEmployee})
        Me.lstCompanylist.FullRowSelect = True
        Me.lstCompanylist.Location = New System.Drawing.Point(5, 33)
        Me.lstCompanylist.Name = "lstCompanylist"
        Me.lstCompanylist.Size = New System.Drawing.Size(730, 287)
        Me.lstCompanylist.TabIndex = 14
        Me.lstCompanylist.UseCompatibleStateImageBehavior = False
        Me.lstCompanylist.View = System.Windows.Forms.View.Details
        '
        'colCompanyInformationSl
        '
        Me.colCompanyInformationSl.Text = "SL"
        Me.colCompanyInformationSl.Width = 30
        '
        'colCompanyName
        '
        Me.colCompanyName.Text = "Name of Company"
        Me.colCompanyName.Width = 150
        '
        'colOwnerName
        '
        Me.colOwnerName.Text = "Owner Name"
        Me.colOwnerName.Width = 140
        '
        'colAddress
        '
        Me.colAddress.Text = "Address"
        Me.colAddress.Width = 180
        '
        'colContactNo
        '
        Me.colContactNo.Text = "Contact No."
        Me.colContactNo.Width = 80
        '
        'colDepartment
        '
        Me.colDepartment.Text = "Department"
        Me.colDepartment.Width = 75
        '
        'colTotalEmployee
        '
        Me.colTotalEmployee.Text = "Employee"
        '
        'tbEmailSMS
        '
        Me.tbEmailSMS.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tbEmailSMS.Controls.Add(Me.grpMailList)
        Me.tbEmailSMS.Controls.Add(Me.grpMailSection)
        Me.tbEmailSMS.Controls.Add(Me.Label4)
        Me.tbEmailSMS.Controls.Add(Me.optNone)
        Me.tbEmailSMS.Controls.Add(Me.optSMS)
        Me.tbEmailSMS.Controls.Add(Me.optMail)
        Me.tbEmailSMS.Location = New System.Drawing.Point(4, 22)
        Me.tbEmailSMS.Name = "tbEmailSMS"
        Me.tbEmailSMS.Padding = New System.Windows.Forms.Padding(3)
        Me.tbEmailSMS.Size = New System.Drawing.Size(741, 348)
        Me.tbEmailSMS.TabIndex = 1
        Me.tbEmailSMS.Text = "EMAIL/SMS"
        '
        'grpMailList
        '
        Me.grpMailList.Controls.Add(Me.btnMailRefresh)
        Me.grpMailList.Controls.Add(Me.btnMailDelete)
        Me.grpMailList.Controls.Add(Me.lstMailList)
        Me.grpMailList.Controls.Add(Me.btnMailUpdate)
        Me.grpMailList.Location = New System.Drawing.Point(17, 171)
        Me.grpMailList.Name = "grpMailList"
        Me.grpMailList.Size = New System.Drawing.Size(689, 173)
        Me.grpMailList.TabIndex = 23
        Me.grpMailList.TabStop = False
        '
        'btnMailRefresh
        '
        Me.btnMailRefresh.Location = New System.Drawing.Point(477, 142)
        Me.btnMailRefresh.Name = "btnMailRefresh"
        Me.btnMailRefresh.Size = New System.Drawing.Size(200, 23)
        Me.btnMailRefresh.TabIndex = 13
        Me.btnMailRefresh.Text = "&Refresh"
        Me.btnMailRefresh.UseVisualStyleBackColor = True
        '
        'btnMailDelete
        '
        Me.btnMailDelete.Location = New System.Drawing.Point(243, 142)
        Me.btnMailDelete.Name = "btnMailDelete"
        Me.btnMailDelete.Size = New System.Drawing.Size(200, 23)
        Me.btnMailDelete.TabIndex = 12
        Me.btnMailDelete.Text = "&Delete"
        Me.btnMailDelete.UseVisualStyleBackColor = True
        '
        'lstMailList
        '
        Me.lstMailList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lstMailList.ContextMenuStrip = Me.cntxMenu
        Me.lstMailList.FullRowSelect = True
        Me.lstMailList.Location = New System.Drawing.Point(11, 14)
        Me.lstMailList.Name = "lstMailList"
        Me.lstMailList.Size = New System.Drawing.Size(666, 128)
        Me.lstMailList.TabIndex = 14
        Me.lstMailList.UseCompatibleStateImageBehavior = False
        Me.lstMailList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "SL"
        Me.ColumnHeader1.Width = 40
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Email ID"
        Me.ColumnHeader2.Width = 249
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "SMTP"
        Me.ColumnHeader3.Width = 160
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "PORT"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 53
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Type"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 66
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Active"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 70
        '
        'cntxMenu
        '
        Me.cntxMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem, Me.SetDefaultToolStripMenuItem})
        Me.cntxMenu.Name = "cntxMenu"
        Me.cntxMenu.Size = New System.Drawing.Size(132, 48)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.DeleteToolStripMenuItem.Text = "&Delete"
        '
        'SetDefaultToolStripMenuItem
        '
        Me.SetDefaultToolStripMenuItem.Name = "SetDefaultToolStripMenuItem"
        Me.SetDefaultToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.SetDefaultToolStripMenuItem.Text = "&Set Default"
        '
        'btnMailUpdate
        '
        Me.btnMailUpdate.Location = New System.Drawing.Point(11, 142)
        Me.btnMailUpdate.Name = "btnMailUpdate"
        Me.btnMailUpdate.Size = New System.Drawing.Size(200, 23)
        Me.btnMailUpdate.TabIndex = 11
        Me.btnMailUpdate.Text = "&Set Default"
        Me.btnMailUpdate.UseVisualStyleBackColor = True
        '
        'grpMailSection
        '
        Me.grpMailSection.Controls.Add(Me.btnUpdate)
        Me.grpMailSection.Controls.Add(Me.optCustom)
        Me.grpMailSection.Controls.Add(Me.optGmail)
        Me.grpMailSection.Controls.Add(Me.optHotMail)
        Me.grpMailSection.Controls.Add(Me.optYahoo)
        Me.grpMailSection.Controls.Add(Me.grpClientInformaion)
        Me.grpMailSection.Controls.Add(Me.btnMailClear)
        Me.grpMailSection.Controls.Add(Me.btnMailAdd)
        Me.grpMailSection.Controls.Add(Me.Label3)
        Me.grpMailSection.Controls.Add(Me.Label2)
        Me.grpMailSection.Controls.Add(Me.txtPassword)
        Me.grpMailSection.Controls.Add(Me.txtEmail)
        Me.grpMailSection.Location = New System.Drawing.Point(17, 41)
        Me.grpMailSection.Name = "grpMailSection"
        Me.grpMailSection.Size = New System.Drawing.Size(689, 130)
        Me.grpMailSection.TabIndex = 22
        Me.grpMailSection.TabStop = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(156, 101)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(86, 23)
        Me.btnUpdate.TabIndex = 27
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'optCustom
        '
        Me.optCustom.AutoSize = True
        Me.optCustom.Location = New System.Drawing.Point(271, 18)
        Me.optCustom.Name = "optCustom"
        Me.optCustom.Size = New System.Drawing.Size(60, 17)
        Me.optCustom.TabIndex = 26
        Me.optCustom.Text = "Custom"
        Me.optCustom.UseVisualStyleBackColor = True
        '
        'optGmail
        '
        Me.optGmail.AutoSize = True
        Me.optGmail.Checked = True
        Me.optGmail.Location = New System.Drawing.Point(69, 19)
        Me.optGmail.Name = "optGmail"
        Me.optGmail.Size = New System.Drawing.Size(51, 17)
        Me.optGmail.TabIndex = 23
        Me.optGmail.TabStop = True
        Me.optGmail.Text = "Gmail"
        Me.optGmail.UseVisualStyleBackColor = True
        '
        'optHotMail
        '
        Me.optHotMail.AutoSize = True
        Me.optHotMail.Location = New System.Drawing.Point(201, 19)
        Me.optHotMail.Name = "optHotMail"
        Me.optHotMail.Size = New System.Drawing.Size(64, 17)
        Me.optHotMail.TabIndex = 25
        Me.optHotMail.Text = "Hot Mail"
        Me.optHotMail.UseVisualStyleBackColor = True
        '
        'optYahoo
        '
        Me.optYahoo.AutoSize = True
        Me.optYahoo.Location = New System.Drawing.Point(135, 19)
        Me.optYahoo.Name = "optYahoo"
        Me.optYahoo.Size = New System.Drawing.Size(56, 17)
        Me.optYahoo.TabIndex = 24
        Me.optYahoo.Text = "Yahoo"
        Me.optYahoo.UseVisualStyleBackColor = True
        '
        'grpClientInformaion
        '
        Me.grpClientInformaion.Controls.Add(Me.chkssl)
        Me.grpClientInformaion.Controls.Add(Me.Label6)
        Me.grpClientInformaion.Controls.Add(Me.txtPort)
        Me.grpClientInformaion.Controls.Add(Me.Label5)
        Me.grpClientInformaion.Controls.Add(Me.txtsmtp)
        Me.grpClientInformaion.Location = New System.Drawing.Point(358, 19)
        Me.grpClientInformaion.Name = "grpClientInformaion"
        Me.grpClientInformaion.Size = New System.Drawing.Size(320, 78)
        Me.grpClientInformaion.TabIndex = 22
        Me.grpClientInformaion.TabStop = False
        '
        'chkssl
        '
        Me.chkssl.AutoSize = True
        Me.chkssl.Location = New System.Drawing.Point(232, 53)
        Me.chkssl.Name = "chkssl"
        Me.chkssl.Size = New System.Drawing.Size(46, 17)
        Me.chkssl.TabIndex = 2
        Me.chkssl.Text = "SSL"
        Me.chkssl.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(55, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "PORT"
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(98, 49)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(128, 20)
        Me.txtPort.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "SMTP SERVER"
        '
        'txtsmtp
        '
        Me.txtsmtp.Location = New System.Drawing.Point(98, 16)
        Me.txtsmtp.Multiline = True
        Me.txtsmtp.Name = "txtsmtp"
        Me.txtsmtp.Size = New System.Drawing.Size(161, 27)
        Me.txtsmtp.TabIndex = 0
        '
        'btnMailClear
        '
        Me.btnMailClear.Location = New System.Drawing.Point(245, 101)
        Me.btnMailClear.Name = "btnMailClear"
        Me.btnMailClear.Size = New System.Drawing.Size(86, 23)
        Me.btnMailClear.TabIndex = 21
        Me.btnMailClear.Text = "&Clear"
        Me.btnMailClear.UseVisualStyleBackColor = True
        '
        'btnMailAdd
        '
        Me.btnMailAdd.Location = New System.Drawing.Point(68, 101)
        Me.btnMailAdd.Name = "btnMailAdd"
        Me.btnMailAdd.Size = New System.Drawing.Size(86, 23)
        Me.btnMailAdd.TabIndex = 20
        Me.btnMailAdd.Text = "&Add New"
        Me.btnMailAdd.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Email ID"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(68, 66)
        Me.txtPassword.Multiline = True
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.ShortcutsEnabled = False
        Me.txtPassword.Size = New System.Drawing.Size(265, 31)
        Me.txtPassword.TabIndex = 19
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(68, 41)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(265, 20)
        Me.txtEmail.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Mail Type"
        '
        'optNone
        '
        Me.optNone.AutoSize = True
        Me.optNone.Checked = True
        Me.optNone.Location = New System.Drawing.Point(77, 18)
        Me.optNone.Name = "optNone"
        Me.optNone.Size = New System.Drawing.Size(51, 17)
        Me.optNone.TabIndex = 0
        Me.optNone.TabStop = True
        Me.optNone.Text = "None"
        Me.optNone.UseVisualStyleBackColor = True
        '
        'optSMS
        '
        Me.optSMS.AutoSize = True
        Me.optSMS.Enabled = False
        Me.optSMS.Location = New System.Drawing.Point(210, 18)
        Me.optSMS.Name = "optSMS"
        Me.optSMS.Size = New System.Drawing.Size(48, 17)
        Me.optSMS.TabIndex = 2
        Me.optSMS.Text = "SMS"
        Me.optSMS.UseVisualStyleBackColor = True
        '
        'optMail
        '
        Me.optMail.AutoSize = True
        Me.optMail.Location = New System.Drawing.Point(144, 18)
        Me.optMail.Name = "optMail"
        Me.optMail.Size = New System.Drawing.Size(50, 17)
        Me.optMail.TabIndex = 1
        Me.optMail.Text = "MAIL"
        Me.optMail.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(539, 392)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(218, 23)
        Me.cmdClose.TabIndex = 0
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'frmOption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(764, 419)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.tbComapny)
        Me.Name = "frmOption"
        Me.Text = "Option"
        Me.tbComapny.ResumeLayout(False)
        Me.tbCompanylist.ResumeLayout(False)
        Me.tbCompanylist.PerformLayout()
        Me.tbEmailSMS.ResumeLayout(False)
        Me.tbEmailSMS.PerformLayout()
        Me.grpMailList.ResumeLayout(False)
        Me.cntxMenu.ResumeLayout(False)
        Me.grpMailSection.ResumeLayout(False)
        Me.grpMailSection.PerformLayout()
        Me.grpClientInformaion.ResumeLayout(False)
        Me.grpClientInformaion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbComapny As TabControl
    Friend WithEvents tbCompanylist As TabPage
    Friend WithEvents lstCompanylist As ListView
    Friend WithEvents colCompanyInformationSl As ColumnHeader
    Friend WithEvents colCompanyName As ColumnHeader
    Friend WithEvents colOwnerName As ColumnHeader
    Friend WithEvents colAddress As ColumnHeader
    Friend WithEvents colContactNo As ColumnHeader
    Friend WithEvents colDepartment As ColumnHeader
    Friend WithEvents colTotalEmployee As ColumnHeader
    Friend WithEvents cmdMakeDefault As Button
    Friend WithEvents cmdClose As Button
    Friend WithEvents lblDefaultCompanyName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbEmailSMS As TabPage
    Friend WithEvents optSMS As RadioButton
    Friend WithEvents optMail As RadioButton
    Friend WithEvents optNone As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents grpMailSection As GroupBox
    Friend WithEvents grpClientInformaion As GroupBox
    Friend WithEvents chkssl As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPort As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtsmtp As TextBox
    Friend WithEvents btnMailClear As Button
    Friend WithEvents btnMailAdd As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents optCustom As RadioButton
    Friend WithEvents optGmail As RadioButton
    Friend WithEvents optHotMail As RadioButton
    Friend WithEvents optYahoo As RadioButton
    Friend WithEvents btnUpdate As Button
    Friend WithEvents cntxMenu As ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents grpMailList As GroupBox
    Friend WithEvents btnMailRefresh As Button
    Friend WithEvents btnMailDelete As Button
    Friend WithEvents lstMailList As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents btnMailUpdate As Button
    Friend WithEvents SetDefaultToolStripMenuItem As ToolStripMenuItem
End Class
