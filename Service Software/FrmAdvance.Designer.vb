<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAdvance
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
        Me.grpCustomerAdvance = New System.Windows.Forms.GroupBox()
        Me.lblCustomerAdvanceInfo = New System.Windows.Forms.Label()
        Me.grpJobInformation = New System.Windows.Forms.GroupBox()
        Me.lstJobMR = New System.Windows.Forms.ListView()
        Me.colSL = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colJobNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColMrNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PicJobNotification = New System.Windows.Forms.PictureBox()
        Me.txtMR = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbBranch = New System.Windows.Forms.ComboBox()
        Me.txtSLNo = New System.Windows.Forms.TextBox()
        Me.txtModelNo = New System.Windows.Forms.TextBox()
        Me.txtReceiveDate = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.txtJobCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.grpPaymentType = New System.Windows.Forms.GroupBox()
        Me.lblLineDraw = New System.Windows.Forms.Label()
        Me.dtpPaymentDate = New System.Windows.Forms.DateTimePicker()
        Me.txtBankName = New System.Windows.Forms.TextBox()
        Me.txtChecque = New System.Windows.Forms.TextBox()
        Me.cmbPayType = New System.Windows.Forms.ComboBox()
        Me.txtPayment = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.grpButton = New System.Windows.Forms.GroupBox()
        Me.chkPrintPreview = New System.Windows.Forms.CheckBox()
        Me.cmdNew = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpCustomerAdvance.SuspendLayout()
        Me.grpJobInformation.SuspendLayout()
        CType(Me.PicJobNotification, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPaymentType.SuspendLayout()
        Me.grpButton.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCustomerAdvance
        '
        Me.grpCustomerAdvance.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.grpCustomerAdvance.Controls.Add(Me.lblCustomerAdvanceInfo)
        Me.grpCustomerAdvance.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCustomerAdvance.Location = New System.Drawing.Point(5, -3)
        Me.grpCustomerAdvance.Name = "grpCustomerAdvance"
        Me.grpCustomerAdvance.Size = New System.Drawing.Size(475, 44)
        Me.grpCustomerAdvance.TabIndex = 13
        Me.grpCustomerAdvance.TabStop = False
        '
        'lblCustomerAdvanceInfo
        '
        Me.lblCustomerAdvanceInfo.AutoSize = True
        Me.lblCustomerAdvanceInfo.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblCustomerAdvanceInfo.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerAdvanceInfo.ForeColor = System.Drawing.Color.Red
        Me.lblCustomerAdvanceInfo.Location = New System.Drawing.Point(107, 13)
        Me.lblCustomerAdvanceInfo.Name = "lblCustomerAdvanceInfo"
        Me.lblCustomerAdvanceInfo.Size = New System.Drawing.Size(242, 25)
        Me.lblCustomerAdvanceInfo.TabIndex = 0
        Me.lblCustomerAdvanceInfo.Text = "Customer Advance Info."
        Me.lblCustomerAdvanceInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpJobInformation
        '
        Me.grpJobInformation.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.grpJobInformation.Controls.Add(Me.lstJobMR)
        Me.grpJobInformation.Controls.Add(Me.PicJobNotification)
        Me.grpJobInformation.Controls.Add(Me.txtMR)
        Me.grpJobInformation.Controls.Add(Me.Label9)
        Me.grpJobInformation.Controls.Add(Me.Label8)
        Me.grpJobInformation.Controls.Add(Me.Label7)
        Me.grpJobInformation.Controls.Add(Me.Label5)
        Me.grpJobInformation.Controls.Add(Me.Label4)
        Me.grpJobInformation.Controls.Add(Me.Label3)
        Me.grpJobInformation.Controls.Add(Me.cmbBranch)
        Me.grpJobInformation.Controls.Add(Me.txtSLNo)
        Me.grpJobInformation.Controls.Add(Me.txtModelNo)
        Me.grpJobInformation.Controls.Add(Me.txtReceiveDate)
        Me.grpJobInformation.Controls.Add(Me.txtPhone)
        Me.grpJobInformation.Controls.Add(Me.txtAddress)
        Me.grpJobInformation.Controls.Add(Me.txtCustomerName)
        Me.grpJobInformation.Controls.Add(Me.txtJobCode)
        Me.grpJobInformation.Controls.Add(Me.Label1)
        Me.grpJobInformation.Controls.Add(Me.Label2)
        Me.grpJobInformation.Controls.Add(Me.Label6)
        Me.grpJobInformation.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpJobInformation.Location = New System.Drawing.Point(5, 37)
        Me.grpJobInformation.Name = "grpJobInformation"
        Me.grpJobInformation.Size = New System.Drawing.Size(475, 173)
        Me.grpJobInformation.TabIndex = 15
        Me.grpJobInformation.TabStop = False
        '
        'lstJobMR
        '
        Me.lstJobMR.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colSL, Me.colJobNo, Me.ColMrNo})
        Me.lstJobMR.FullRowSelect = True
        Me.lstJobMR.Location = New System.Drawing.Point(155, 49)
        Me.lstJobMR.Name = "lstJobMR"
        Me.lstJobMR.Size = New System.Drawing.Size(273, 127)
        Me.lstJobMR.TabIndex = 45
        Me.lstJobMR.UseCompatibleStateImageBehavior = False
        Me.lstJobMR.View = System.Windows.Forms.View.Details
        '
        'colSL
        '
        Me.colSL.Text = "SL No."
        Me.colSL.Width = 44
        '
        'colJobNo
        '
        Me.colJobNo.Text = "Job No"
        Me.colJobNo.Width = 80
        '
        'ColMrNo
        '
        Me.ColMrNo.Text = "MR No"
        Me.ColMrNo.Width = 70
        '
        'PicJobNotification
        '
        Me.PicJobNotification.Location = New System.Drawing.Point(295, 26)
        Me.PicJobNotification.Name = "PicJobNotification"
        Me.PicJobNotification.Size = New System.Drawing.Size(19, 22)
        Me.PicJobNotification.TabIndex = 46
        Me.PicJobNotification.TabStop = False
        '
        'txtMR
        '
        Me.txtMR.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMR.Location = New System.Drawing.Point(6, 27)
        Me.txtMR.Name = "txtMR"
        Me.txtMR.Size = New System.Drawing.Size(147, 20)
        Me.txtMR.TabIndex = 42
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(178, 127)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 15)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Serial No:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(267, 127)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 15)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Model:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(356, 127)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 15)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Receive Date:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(6, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 15)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Phone:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(6, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 15)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Address:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(6, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 15)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Cust. Name:"
        '
        'cmbBranch
        '
        Me.cmbBranch.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBranch.FormattingEnabled = True
        Me.cmbBranch.Location = New System.Drawing.Point(317, 27)
        Me.cmbBranch.Name = "cmbBranch"
        Me.cmbBranch.Size = New System.Drawing.Size(152, 22)
        Me.cmbBranch.TabIndex = 30
        '
        'txtSLNo
        '
        Me.txtSLNo.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSLNo.Location = New System.Drawing.Point(178, 143)
        Me.txtSLNo.Name = "txtSLNo"
        Me.txtSLNo.Size = New System.Drawing.Size(88, 20)
        Me.txtSLNo.TabIndex = 29
        '
        'txtModelNo
        '
        Me.txtModelNo.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModelNo.Location = New System.Drawing.Point(267, 143)
        Me.txtModelNo.Name = "txtModelNo"
        Me.txtModelNo.Size = New System.Drawing.Size(88, 20)
        Me.txtModelNo.TabIndex = 28
        '
        'txtReceiveDate
        '
        Me.txtReceiveDate.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceiveDate.Location = New System.Drawing.Point(356, 143)
        Me.txtReceiveDate.Name = "txtReceiveDate"
        Me.txtReceiveDate.Size = New System.Drawing.Size(115, 20)
        Me.txtReceiveDate.TabIndex = 27
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(6, 143)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(171, 20)
        Me.txtPhone.TabIndex = 26
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(6, 103)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(463, 20)
        Me.txtAddress.TabIndex = 25
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName.Location = New System.Drawing.Point(6, 65)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(463, 20)
        Me.txtCustomerName.TabIndex = 24
        '
        'txtJobCode
        '
        Me.txtJobCode.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJobCode.Location = New System.Drawing.Point(156, 27)
        Me.txtJobCode.Name = "txtJobCode"
        Me.txtJobCode.Size = New System.Drawing.Size(137, 20)
        Me.txtJobCode.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(6, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 15)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "MR No:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(152, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 15)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Job Code:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(317, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 15)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Branch Name:"
        '
        'grpPaymentType
        '
        Me.grpPaymentType.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.grpPaymentType.Controls.Add(Me.lblLineDraw)
        Me.grpPaymentType.Controls.Add(Me.dtpPaymentDate)
        Me.grpPaymentType.Controls.Add(Me.txtBankName)
        Me.grpPaymentType.Controls.Add(Me.txtChecque)
        Me.grpPaymentType.Controls.Add(Me.cmbPayType)
        Me.grpPaymentType.Controls.Add(Me.txtPayment)
        Me.grpPaymentType.Controls.Add(Me.Label12)
        Me.grpPaymentType.Controls.Add(Me.Label11)
        Me.grpPaymentType.Controls.Add(Me.Label10)
        Me.grpPaymentType.Controls.Add(Me.Label14)
        Me.grpPaymentType.Controls.Add(Me.Label13)
        Me.grpPaymentType.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPaymentType.Location = New System.Drawing.Point(5, 206)
        Me.grpPaymentType.Name = "grpPaymentType"
        Me.grpPaymentType.Size = New System.Drawing.Size(475, 95)
        Me.grpPaymentType.TabIndex = 19
        Me.grpPaymentType.TabStop = False
        '
        'lblLineDraw
        '
        Me.lblLineDraw.BackColor = System.Drawing.Color.AliceBlue
        Me.lblLineDraw.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLineDraw.Location = New System.Drawing.Point(4, 53)
        Me.lblLineDraw.Name = "lblLineDraw"
        Me.lblLineDraw.Size = New System.Drawing.Size(467, 1)
        Me.lblLineDraw.TabIndex = 51
        '
        'dtpPaymentDate
        '
        Me.dtpPaymentDate.CustomFormat = ""
        Me.dtpPaymentDate.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPaymentDate.Location = New System.Drawing.Point(357, 27)
        Me.dtpPaymentDate.Name = "dtpPaymentDate"
        Me.dtpPaymentDate.Size = New System.Drawing.Size(112, 20)
        Me.dtpPaymentDate.TabIndex = 46
        Me.dtpPaymentDate.Value = New Date(2017, 3, 4, 0, 0, 0, 0)
        '
        'txtBankName
        '
        Me.txtBankName.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBankName.Location = New System.Drawing.Point(202, 70)
        Me.txtBankName.Multiline = True
        Me.txtBankName.Name = "txtBankName"
        Me.txtBankName.Size = New System.Drawing.Size(267, 20)
        Me.txtBankName.TabIndex = 22
        '
        'txtChecque
        '
        Me.txtChecque.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChecque.Location = New System.Drawing.Point(11, 70)
        Me.txtChecque.Name = "txtChecque"
        Me.txtChecque.Size = New System.Drawing.Size(185, 20)
        Me.txtChecque.TabIndex = 21
        '
        'cmbPayType
        '
        Me.cmbPayType.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPayType.FormattingEnabled = True
        Me.cmbPayType.Location = New System.Drawing.Point(11, 27)
        Me.cmbPayType.Name = "cmbPayType"
        Me.cmbPayType.Size = New System.Drawing.Size(185, 22)
        Me.cmbPayType.TabIndex = 20
        '
        'txtPayment
        '
        Me.txtPayment.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPayment.Location = New System.Drawing.Point(202, 27)
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.Size = New System.Drawing.Size(149, 20)
        Me.txtPayment.TabIndex = 19
        Me.txtPayment.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(11, 10)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(36, 15)
        Me.Label12.TabIndex = 48
        Me.Label12.Text = "Type:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(202, 10)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 15)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Payment:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(357, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 15)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Payment Date:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(202, 54)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(66, 15)
        Me.Label14.TabIndex = 50
        Me.Label14.Text = "Bank Name:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(11, 54)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 15)
        Me.Label13.TabIndex = 49
        Me.Label13.Text = "Cheque/Card No:"
        '
        'grpButton
        '
        Me.grpButton.Controls.Add(Me.chkPrintPreview)
        Me.grpButton.Controls.Add(Me.cmdNew)
        Me.grpButton.Controls.Add(Me.cmdEdit)
        Me.grpButton.Controls.Add(Me.cmdDelete)
        Me.grpButton.Controls.Add(Me.cmdSave)
        Me.grpButton.Controls.Add(Me.cmdClose)
        Me.grpButton.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpButton.Location = New System.Drawing.Point(6, 339)
        Me.grpButton.Name = "grpButton"
        Me.grpButton.Size = New System.Drawing.Size(475, 38)
        Me.grpButton.TabIndex = 20
        Me.grpButton.TabStop = False
        '
        'chkPrintPreview
        '
        Me.chkPrintPreview.AutoSize = True
        Me.chkPrintPreview.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.chkPrintPreview.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPrintPreview.ForeColor = System.Drawing.Color.Red
        Me.chkPrintPreview.Location = New System.Drawing.Point(7, 13)
        Me.chkPrintPreview.Name = "chkPrintPreview"
        Me.chkPrintPreview.Size = New System.Drawing.Size(100, 19)
        Me.chkPrintPreview.TabIndex = 22
        Me.chkPrintPreview.Text = "Print Preview ?"
        Me.chkPrintPreview.UseVisualStyleBackColor = False
        '
        'cmdNew
        '
        Me.cmdNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdNew.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.cmdNew.FlatAppearance.BorderSize = 2
        Me.cmdNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.cmdNew.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNew.ForeColor = System.Drawing.Color.Maroon
        Me.cmdNew.Location = New System.Drawing.Point(106, 10)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(69, 24)
        Me.cmdNew.TabIndex = 21
        Me.cmdNew.Text = "&New"
        Me.cmdNew.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdEdit.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.cmdEdit.FlatAppearance.BorderSize = 2
        Me.cmdEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.cmdEdit.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.ForeColor = System.Drawing.Color.Maroon
        Me.cmdEdit.Location = New System.Drawing.Point(173, 10)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(69, 24)
        Me.cmdEdit.TabIndex = 20
        Me.cmdEdit.Text = "&Edit"
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdDelete.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.cmdDelete.FlatAppearance.BorderSize = 2
        Me.cmdDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.cmdDelete.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.ForeColor = System.Drawing.Color.Maroon
        Me.cmdDelete.Location = New System.Drawing.Point(240, 10)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(71, 24)
        Me.cmdDelete.TabIndex = 19
        Me.cmdDelete.Text = "&Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdSave.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.cmdSave.FlatAppearance.BorderSize = 2
        Me.cmdSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.cmdSave.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.ForeColor = System.Drawing.Color.Maroon
        Me.cmdSave.Location = New System.Drawing.Point(309, 10)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(82, 24)
        Me.cmdSave.TabIndex = 18
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdClose.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.cmdClose.FlatAppearance.BorderSize = 2
        Me.cmdClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.cmdClose.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.Color.Maroon
        Me.cmdClose.Location = New System.Drawing.Point(389, 10)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(83, 24)
        Me.cmdClose.TabIndex = 17
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'txtRemarks
        '
        Me.txtRemarks.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.Location = New System.Drawing.Point(5, 320)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(475, 20)
        Me.txtRemarks.TabIndex = 52
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(5, 304)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 15)
        Me.Label15.TabIndex = 53
        Me.Label15.Text = "Remarks:"
        '
        'FrmAdvance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.ClientSize = New System.Drawing.Size(484, 378)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.grpButton)
        Me.Controls.Add(Me.grpCustomerAdvance)
        Me.Controls.Add(Me.grpJobInformation)
        Me.Controls.Add(Me.grpPaymentType)
        Me.Name = "FrmAdvance"
        Me.Text = "Customer Advance"
        Me.grpCustomerAdvance.ResumeLayout(False)
        Me.grpCustomerAdvance.PerformLayout()
        Me.grpJobInformation.ResumeLayout(False)
        Me.grpJobInformation.PerformLayout()
        CType(Me.PicJobNotification, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPaymentType.ResumeLayout(False)
        Me.grpPaymentType.PerformLayout()
        Me.grpButton.ResumeLayout(False)
        Me.grpButton.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpCustomerAdvance As GroupBox
    Friend WithEvents lblCustomerAdvanceInfo As Label
    Friend WithEvents grpJobInformation As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbBranch As ComboBox
    Friend WithEvents txtSLNo As TextBox
    Friend WithEvents txtModelNo As TextBox
    Friend WithEvents txtReceiveDate As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents txtJobCode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMR As TextBox
    Friend WithEvents grpPaymentType As GroupBox
    Friend WithEvents txtBankName As TextBox
    Friend WithEvents txtChecque As TextBox
    Friend WithEvents cmbPayType As ComboBox
    Friend WithEvents txtPayment As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents dtpPaymentDate As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblLineDraw As Label
    Friend WithEvents grpButton As GroupBox
    Friend WithEvents cmdClose As Button
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents chkPrintPreview As CheckBox
    Friend WithEvents cmdNew As Button
    Friend WithEvents cmdEdit As Button
    Friend WithEvents cmdDelete As Button
    Friend WithEvents cmdSave As Button
    Friend WithEvents lstJobMR As ListView
    Friend WithEvents PicJobNotification As PictureBox
    Friend WithEvents colSL As ColumnHeader
    Friend WithEvents colJobNo As ColumnHeader
    Friend WithEvents ColMrNo As ColumnHeader
    Friend WithEvents ToolTip As ToolTip
End Class
