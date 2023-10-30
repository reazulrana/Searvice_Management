<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuotation
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtPrintDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTo = New System.Windows.Forms.TextBox()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtHeadLine = New System.Windows.Forms.TextBox()
        Me.txtJobNo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSpareCost = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTechnicalCharge = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtvat = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTotalAmount = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPayment = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDelivery = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtDeliveryTime = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmbVatPercent = New System.Windows.Forms.ComboBox()
        Me.HeadLine = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.cmbBranch = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.grpMail = New System.Windows.Forms.GroupBox()
        Me.txtMailTo = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtMailFrom = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.grpManual = New System.Windows.Forms.GroupBox()
        Me.chkSSL = New System.Windows.Forms.CheckBox()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtSMTP = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.optCustom = New System.Windows.Forms.RadioButton()
        Me.optHotmail = New System.Windows.Forms.RadioButton()
        Me.optYahoo = New System.Windows.Forms.RadioButton()
        Me.optGmail = New System.Windows.Forms.RadioButton()
        Me.optManual = New System.Windows.Forms.RadioButton()
        Me.optQuickMail = New System.Windows.Forms.RadioButton()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSendMail = New System.Windows.Forms.Button()
        Me.txtPreparedby = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtDesignation = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtValidity = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtCondition = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.grpMail.SuspendLayout()
        Me.grpManual.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(291, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date"
        '
        'dtPrintDate
        '
        Me.dtPrintDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtPrintDate.Location = New System.Drawing.Point(325, 138)
        Me.dtPrintDate.Name = "dtPrintDate"
        Me.dtPrintDate.Size = New System.Drawing.Size(132, 20)
        Me.dtPrintDate.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(76, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "To"
        '
        'txtTo
        '
        Me.txtTo.ForeColor = System.Drawing.Color.Black
        Me.txtTo.Location = New System.Drawing.Point(108, 167)
        Me.txtTo.Multiline = True
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(512, 29)
        Me.txtTo.TabIndex = 2
        '
        'txtSubject
        '
        Me.txtSubject.ForeColor = System.Drawing.Color.Black
        Me.txtSubject.Location = New System.Drawing.Point(108, 204)
        Me.txtSubject.Multiline = True
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(512, 19)
        Me.txtSubject.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Subject"
        '
        'txtHeadLine
        '
        Me.txtHeadLine.ForeColor = System.Drawing.Color.Black
        Me.txtHeadLine.Location = New System.Drawing.Point(108, 229)
        Me.txtHeadLine.Multiline = True
        Me.txtHeadLine.Name = "txtHeadLine"
        Me.txtHeadLine.Size = New System.Drawing.Size(512, 35)
        Me.txtHeadLine.TabIndex = 4
        '
        'txtJobNo
        '
        Me.txtJobNo.ForeColor = System.Drawing.Color.Black
        Me.txtJobNo.Location = New System.Drawing.Point(108, 270)
        Me.txtJobNo.Multiline = True
        Me.txtJobNo.Name = "txtJobNo"
        Me.txtJobNo.Size = New System.Drawing.Size(205, 19)
        Me.txtJobNo.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(60, 273)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Job No"
        '
        'txtItem
        '
        Me.txtItem.ForeColor = System.Drawing.Color.Black
        Me.txtItem.Location = New System.Drawing.Point(386, 270)
        Me.txtItem.Multiline = True
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(234, 19)
        Me.txtItem.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(352, 273)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Item"
        '
        'txtSpareCost
        '
        Me.txtSpareCost.ForeColor = System.Drawing.Color.Black
        Me.txtSpareCost.Location = New System.Drawing.Point(108, 296)
        Me.txtSpareCost.Multiline = True
        Me.txtSpareCost.Name = "txtSpareCost"
        Me.txtSpareCost.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSpareCost.Size = New System.Drawing.Size(113, 19)
        Me.txtSpareCost.TabIndex = 7
        Me.txtSpareCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 299)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Spare Parts Cost"
        '
        'txtTechnicalCharge
        '
        Me.txtTechnicalCharge.ForeColor = System.Drawing.Color.Black
        Me.txtTechnicalCharge.Location = New System.Drawing.Point(314, 296)
        Me.txtTechnicalCharge.Multiline = True
        Me.txtTechnicalCharge.Name = "txtTechnicalCharge"
        Me.txtTechnicalCharge.Size = New System.Drawing.Size(113, 19)
        Me.txtTechnicalCharge.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(222, 299)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Technical Charge"
        '
        'txtvat
        '
        Me.txtvat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvat.Location = New System.Drawing.Point(466, 298)
        Me.txtvat.Multiline = True
        Me.txtvat.Name = "txtvat"
        Me.txtvat.ReadOnly = True
        Me.txtvat.Size = New System.Drawing.Size(81, 19)
        Me.txtvat.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(436, 301)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Vat"
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAmount.ForeColor = System.Drawing.Color.Black
        Me.txtTotalAmount.Location = New System.Drawing.Point(108, 323)
        Me.txtTotalAmount.Multiline = True
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.ReadOnly = True
        Me.txtTotalAmount.Size = New System.Drawing.Size(260, 19)
        Me.txtTotalAmount.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 327)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Total Amount (TK)"
        '
        'txtPayment
        '
        Me.txtPayment.ForeColor = System.Drawing.Color.Black
        Me.txtPayment.Location = New System.Drawing.Point(108, 347)
        Me.txtPayment.Multiline = True
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.Size = New System.Drawing.Size(512, 19)
        Me.txtPayment.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 350)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Mode of Payment"
        '
        'txtDelivery
        '
        Me.txtDelivery.ForeColor = System.Drawing.Color.Black
        Me.txtDelivery.Location = New System.Drawing.Point(108, 372)
        Me.txtDelivery.Multiline = True
        Me.txtDelivery.Name = "txtDelivery"
        Me.txtDelivery.Size = New System.Drawing.Size(512, 27)
        Me.txtDelivery.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(17, 375)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Point of Delivery"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(550, 300)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(15, 13)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "%"
        '
        'txtDeliveryTime
        '
        Me.txtDeliveryTime.ForeColor = System.Drawing.Color.Black
        Me.txtDeliveryTime.Location = New System.Drawing.Point(108, 405)
        Me.txtDeliveryTime.Multiline = True
        Me.txtDeliveryTime.Name = "txtDeliveryTime"
        Me.txtDeliveryTime.Size = New System.Drawing.Size(512, 19)
        Me.txtDeliveryTime.TabIndex = 14
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(18, 408)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 13)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Time of Delivery"
        '
        'cmbVatPercent
        '
        Me.cmbVatPercent.ForeColor = System.Drawing.Color.Black
        Me.cmbVatPercent.FormattingEnabled = True
        Me.cmbVatPercent.Location = New System.Drawing.Point(568, 296)
        Me.cmbVatPercent.Name = "cmbVatPercent"
        Me.cmbVatPercent.Size = New System.Drawing.Size(52, 21)
        Me.cmbVatPercent.TabIndex = 10
        '
        'HeadLine
        '
        Me.HeadLine.AutoSize = True
        Me.HeadLine.Location = New System.Drawing.Point(45, 240)
        Me.HeadLine.Name = "HeadLine"
        Me.HeadLine.Size = New System.Drawing.Size(56, 13)
        Me.HeadLine.TabIndex = 29
        Me.HeadLine.Text = "Head Line"
        '
        'txtRemarks
        '
        Me.txtRemarks.ForeColor = System.Drawing.Color.Black
        Me.txtRemarks.Location = New System.Drawing.Point(107, 507)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(512, 28)
        Me.txtRemarks.TabIndex = 19
        '
        'cmbBranch
        '
        Me.cmbBranch.ForeColor = System.Drawing.Color.Black
        Me.cmbBranch.FormattingEnabled = True
        Me.cmbBranch.Location = New System.Drawing.Point(108, 138)
        Me.cmbBranch.Name = "cmbBranch"
        Me.cmbBranch.Size = New System.Drawing.Size(173, 21)
        Me.cmbBranch.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(60, 141)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 13)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Branch"
        '
        'grpMail
        '
        Me.grpMail.Controls.Add(Me.txtMailTo)
        Me.grpMail.Controls.Add(Me.Label17)
        Me.grpMail.Controls.Add(Me.txtPassword)
        Me.grpMail.Controls.Add(Me.Label16)
        Me.grpMail.Controls.Add(Me.txtMailFrom)
        Me.grpMail.Controls.Add(Me.Label15)
        Me.grpMail.Controls.Add(Me.grpManual)
        Me.grpMail.Controls.Add(Me.optManual)
        Me.grpMail.Controls.Add(Me.optQuickMail)
        Me.grpMail.Location = New System.Drawing.Point(6, 2)
        Me.grpMail.Name = "grpMail"
        Me.grpMail.Size = New System.Drawing.Size(639, 118)
        Me.grpMail.TabIndex = 33
        Me.grpMail.TabStop = False
        Me.grpMail.Text = "Mail Settings"
        '
        'txtMailTo
        '
        Me.txtMailTo.Location = New System.Drawing.Point(66, 90)
        Me.txtMailTo.Multiline = True
        Me.txtMailTo.Name = "txtMailTo"
        Me.txtMailTo.Size = New System.Drawing.Size(268, 19)
        Me.txtMailTo.TabIndex = 4
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(42, 93)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(20, 13)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "To"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(66, 65)
        Me.txtPassword.Multiline = True
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(268, 19)
        Me.txtPassword.TabIndex = 3
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(9, 68)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(53, 13)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Password"
        '
        'txtMailFrom
        '
        Me.txtMailFrom.Location = New System.Drawing.Point(66, 40)
        Me.txtMailFrom.Multiline = True
        Me.txtMailFrom.Name = "txtMailFrom"
        Me.txtMailFrom.Size = New System.Drawing.Size(268, 19)
        Me.txtMailFrom.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(32, 43)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(30, 13)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "From"
        '
        'grpManual
        '
        Me.grpManual.Controls.Add(Me.chkSSL)
        Me.grpManual.Controls.Add(Me.txtPort)
        Me.grpManual.Controls.Add(Me.Label19)
        Me.grpManual.Controls.Add(Me.txtSMTP)
        Me.grpManual.Controls.Add(Me.Label18)
        Me.grpManual.Controls.Add(Me.optCustom)
        Me.grpManual.Controls.Add(Me.optHotmail)
        Me.grpManual.Controls.Add(Me.optYahoo)
        Me.grpManual.Controls.Add(Me.optGmail)
        Me.grpManual.Location = New System.Drawing.Point(340, 33)
        Me.grpManual.Name = "grpManual"
        Me.grpManual.Size = New System.Drawing.Size(293, 79)
        Me.grpManual.TabIndex = 2
        Me.grpManual.TabStop = False
        '
        'chkSSL
        '
        Me.chkSSL.AutoSize = True
        Me.chkSSL.Location = New System.Drawing.Point(103, 56)
        Me.chkSSL.Name = "chkSSL"
        Me.chkSSL.Size = New System.Drawing.Size(46, 17)
        Me.chkSSL.TabIndex = 6
        Me.chkSSL.Text = "SSL"
        Me.chkSSL.UseVisualStyleBackColor = True
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(49, 54)
        Me.txtPort.Multiline = True
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(48, 17)
        Me.txtPort.TabIndex = 5
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(20, 57)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(26, 13)
        Me.Label19.TabIndex = 8
        Me.Label19.Text = "Port"
        '
        'txtSMTP
        '
        Me.txtSMTP.Location = New System.Drawing.Point(49, 35)
        Me.txtSMTP.Multiline = True
        Me.txtSMTP.Name = "txtSMTP"
        Me.txtSMTP.Size = New System.Drawing.Size(228, 17)
        Me.txtSMTP.TabIndex = 4
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(8, 37)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(37, 13)
        Me.Label18.TabIndex = 6
        Me.Label18.Text = "SMTP"
        '
        'optCustom
        '
        Me.optCustom.AutoSize = True
        Me.optCustom.Location = New System.Drawing.Point(217, 12)
        Me.optCustom.Name = "optCustom"
        Me.optCustom.Size = New System.Drawing.Size(60, 17)
        Me.optCustom.TabIndex = 3
        Me.optCustom.TabStop = True
        Me.optCustom.Text = "Custom"
        Me.optCustom.UseVisualStyleBackColor = True
        '
        'optHotmail
        '
        Me.optHotmail.AutoSize = True
        Me.optHotmail.Location = New System.Drawing.Point(147, 12)
        Me.optHotmail.Name = "optHotmail"
        Me.optHotmail.Size = New System.Drawing.Size(64, 17)
        Me.optHotmail.TabIndex = 2
        Me.optHotmail.TabStop = True
        Me.optHotmail.Text = "Hot Mail"
        Me.optHotmail.UseVisualStyleBackColor = True
        '
        'optYahoo
        '
        Me.optYahoo.AutoSize = True
        Me.optYahoo.Location = New System.Drawing.Point(81, 12)
        Me.optYahoo.Name = "optYahoo"
        Me.optYahoo.Size = New System.Drawing.Size(56, 17)
        Me.optYahoo.TabIndex = 1
        Me.optYahoo.TabStop = True
        Me.optYahoo.Text = "Yahoo"
        Me.optYahoo.UseVisualStyleBackColor = True
        '
        'optGmail
        '
        Me.optGmail.AutoSize = True
        Me.optGmail.Location = New System.Drawing.Point(15, 12)
        Me.optGmail.Name = "optGmail"
        Me.optGmail.Size = New System.Drawing.Size(51, 17)
        Me.optGmail.TabIndex = 0
        Me.optGmail.TabStop = True
        Me.optGmail.Text = "Gmail"
        Me.optGmail.UseVisualStyleBackColor = True
        '
        'optManual
        '
        Me.optManual.AutoSize = True
        Me.optManual.Location = New System.Drawing.Point(421, 17)
        Me.optManual.Name = "optManual"
        Me.optManual.Size = New System.Drawing.Size(60, 17)
        Me.optManual.TabIndex = 1
        Me.optManual.TabStop = True
        Me.optManual.Text = "Manual"
        Me.optManual.UseVisualStyleBackColor = True
        '
        'optQuickMail
        '
        Me.optQuickMail.AutoSize = True
        Me.optQuickMail.Location = New System.Drawing.Point(340, 17)
        Me.optQuickMail.Name = "optQuickMail"
        Me.optQuickMail.Size = New System.Drawing.Size(75, 17)
        Me.optQuickMail.TabIndex = 0
        Me.optQuickMail.TabStop = True
        Me.optQuickMail.Text = "Quick Mail"
        Me.optQuickMail.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(463, 536)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(157, 23)
        Me.btnClose.TabIndex = 21
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSendMail
        '
        Me.btnSendMail.Location = New System.Drawing.Point(300, 536)
        Me.btnSendMail.Name = "btnSendMail"
        Me.btnSendMail.Size = New System.Drawing.Size(157, 23)
        Me.btnSendMail.TabIndex = 20
        Me.btnSendMail.Text = "&Send Mail"
        Me.btnSendMail.UseVisualStyleBackColor = True
        '
        'txtPreparedby
        '
        Me.txtPreparedby.ForeColor = System.Drawing.Color.Black
        Me.txtPreparedby.Location = New System.Drawing.Point(107, 482)
        Me.txtPreparedby.Multiline = True
        Me.txtPreparedby.Name = "txtPreparedby"
        Me.txtPreparedby.Size = New System.Drawing.Size(232, 19)
        Me.txtPreparedby.TabIndex = 17
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(37, 485)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(64, 13)
        Me.Label20.TabIndex = 36
        Me.Label20.Text = "Prepared by"
        '
        'txtDesignation
        '
        Me.txtDesignation.ForeColor = System.Drawing.Color.Black
        Me.txtDesignation.Location = New System.Drawing.Point(411, 482)
        Me.txtDesignation.Multiline = True
        Me.txtDesignation.Name = "txtDesignation"
        Me.txtDesignation.Size = New System.Drawing.Size(209, 19)
        Me.txtDesignation.TabIndex = 18
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(342, 485)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(63, 13)
        Me.Label21.TabIndex = 38
        Me.Label21.Text = "Designation"
        '
        'txtValidity
        '
        Me.txtValidity.ForeColor = System.Drawing.Color.Black
        Me.txtValidity.Location = New System.Drawing.Point(108, 430)
        Me.txtValidity.Multiline = True
        Me.txtValidity.Name = "txtValidity"
        Me.txtValidity.Size = New System.Drawing.Size(512, 19)
        Me.txtValidity.TabIndex = 15
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(12, 433)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(89, 13)
        Me.Label22.TabIndex = 40
        Me.Label22.Text = "Quotation Validity"
        '
        'txtCondition
        '
        Me.txtCondition.ForeColor = System.Drawing.Color.Black
        Me.txtCondition.Location = New System.Drawing.Point(108, 456)
        Me.txtCondition.Multiline = True
        Me.txtCondition.Name = "txtCondition"
        Me.txtCondition.Size = New System.Drawing.Size(512, 19)
        Me.txtCondition.TabIndex = 16
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(50, 459)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(51, 13)
        Me.Label23.TabIndex = 42
        Me.Label23.Text = "Condition"
        '
        'frmQuotation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(649, 562)
        Me.Controls.Add(Me.txtCondition)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.txtValidity)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.txtDesignation)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtPreparedby)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.btnSendMail)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.grpMail)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cmbBranch)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.HeadLine)
        Me.Controls.Add(Me.cmbVatPercent)
        Me.Controls.Add(Me.txtDeliveryTime)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtDelivery)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtPayment)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtTotalAmount)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtvat)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtTechnicalCharge)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtSpareCost)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtItem)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtJobNo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtHeadLine)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtPrintDate)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmQuotation"
        Me.Text = "Quotation"
        Me.grpMail.ResumeLayout(False)
        Me.grpMail.PerformLayout()
        Me.grpManual.ResumeLayout(False)
        Me.grpManual.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dtPrintDate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTo As TextBox
    Friend WithEvents txtSubject As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtHeadLine As TextBox
    Friend WithEvents txtJobNo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtItem As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSpareCost As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTechnicalCharge As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtvat As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTotalAmount As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPayment As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtDelivery As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtDeliveryTime As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cmbVatPercent As ComboBox
    Friend WithEvents HeadLine As Label
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents cmbBranch As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents grpMail As GroupBox
    Friend WithEvents txtMailTo As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtMailFrom As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents grpManual As GroupBox
    Friend WithEvents chkSSL As CheckBox
    Friend WithEvents txtPort As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtSMTP As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents optCustom As RadioButton
    Friend WithEvents optHotmail As RadioButton
    Friend WithEvents optYahoo As RadioButton
    Friend WithEvents optGmail As RadioButton
    Friend WithEvents optManual As RadioButton
    Friend WithEvents optQuickMail As RadioButton
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSendMail As Button
    Friend WithEvents txtPreparedby As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtDesignation As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtValidity As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtCondition As TextBox
    Friend WithEvents Label23 As Label
End Class
