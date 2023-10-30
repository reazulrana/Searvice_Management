<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NewCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewCustomer))
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.lstFaultList = New System.Windows.Forms.ListView()
        Me.cmdSaveandPrint = New System.Windows.Forms.Button()
        Me.cmdFind = New System.Windows.Forms.Button()
        Me.cmdService = New System.Windows.Forms.Button()
        Me.cmdBill = New System.Windows.Forms.Button()
        Me.cmdReport = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdCanceljob = New System.Windows.Forms.Button()
        Me.cmdTransferJob = New System.Windows.Forms.Button()
        Me.lstAccessoriesList = New System.Windows.Forms.ListView()
        Me.txtJobCode = New System.Windows.Forms.TextBox()
        Me.txtCustReference = New System.Windows.Forms.TextBox()
        Me.cmbBranchName = New System.Windows.Forms.ComboBox()
        Me.lblJobCode = New System.Windows.Forms.Label()
        Me.lblCustGrade = New System.Windows.Forms.Label()
        Me.lblCustReference = New System.Windows.Forms.Label()
        Me.lblBranchName = New System.Windows.Forms.Label()
        Me.cmbCustGrade = New System.Windows.Forms.ComboBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblCustomerInformation = New System.Windows.Forms.Label()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.chkREL = New System.Windows.Forms.CheckBox()
        Me.dtpReceiveDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpDelDTApprox = New System.Windows.Forms.DateTimePicker()
        Me.cmbJobAssigntoCode = New System.Windows.Forms.ComboBox()
        Me.lblJobAssignto = New System.Windows.Forms.Label()
        Me.lblReceivedDate = New System.Windows.Forms.Label()
        Me.lblDelDTApprox = New System.Windows.Forms.Label()
        Me.lblAssignDate = New System.Windows.Forms.Label()
        Me.dtpAssignDate = New System.Windows.Forms.DateTimePicker()
        Me.cmbReceivedbyCode = New System.Windows.Forms.ComboBox()
        Me.lblReceivedby = New System.Windows.Forms.Label()
        Me.lblTechCode = New System.Windows.Forms.Label()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.cmbBrand = New System.Windows.Forms.ComboBox()
        Me.lblBrand = New System.Windows.Forms.Label()
        Me.cmbModel = New System.Windows.Forms.ComboBox()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblSerialIMEI = New System.Windows.Forms.Label()
        Me.txtSerialIMEI = New System.Windows.Forms.TextBox()
        Me.lblESNNo = New System.Windows.Forms.Label()
        Me.txtESNNo = New System.Windows.Forms.TextBox()
        Me.optSalesWarranty = New System.Windows.Forms.RadioButton()
        Me.optNonWarranty = New System.Windows.Forms.RadioButton()
        Me.optServiceWarranty = New System.Windows.Forms.RadioButton()
        Me.txtAccessoriesReceived = New System.Windows.Forms.TextBox()
        Me.lblDateofPurchase = New System.Windows.Forms.Label()
        Me.dtpDateofPurchase = New System.Windows.Forms.DateTimePicker()
        Me.txtReturnedItem = New System.Windows.Forms.TextBox()
        Me.txtPhysicalCondition = New System.Windows.Forms.TextBox()
        Me.txtOtherFault = New System.Windows.Forms.TextBox()
        Me.lblProductInformation = New System.Windows.Forms.Label()
        Me.lblDateInformation = New System.Windows.Forms.Label()
        Me.lblAccessories = New System.Windows.Forms.Label()
        Me.lblPreviousJob = New System.Windows.Forms.Label()
        Me.txtPreviousJob = New System.Windows.Forms.TextBox()
        Me.lblPhysicalCondition = New System.Windows.Forms.Label()
        Me.lblReturnedItem = New System.Windows.Forms.Label()
        Me.lblFailurDescription = New System.Windows.Forms.Label()
        Me.lblOtherFault = New System.Windows.Forms.Label()
        Me.chkMakeDuplicate = New System.Windows.Forms.CheckBox()
        Me.lblSetBranch = New System.Windows.Forms.Label()
        Me.lblEMail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.picNotification = New System.Windows.Forms.PictureBox()
        Me.cmbSalesWarranty = New System.Windows.Forms.ComboBox()
        Me.lblWarrantyType = New System.Windows.Forms.Label()
        Me.lblWarrLevel = New System.Windows.Forms.Label()
        Me.chkOldFrom = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblReceivedByCode = New System.Windows.Forms.Label()
        Me.lblJobAssigntoCode = New System.Windows.Forms.Label()
        Me.picCategoryRefress = New System.Windows.Forms.PictureBox()
        Me.picBrandRefresh = New System.Windows.Forms.PictureBox()
        Me.Tool = New System.Windows.Forms.ToolTip(Me.components)
        Me.picRefreshAccesorries = New System.Windows.Forms.PictureBox()
        Me.picCreateAccessories = New System.Windows.Forms.PictureBox()
        Me.picCreateFault = New System.Windows.Forms.PictureBox()
        Me.picRefreshFault = New System.Windows.Forms.PictureBox()
        Me.picDeleteAccessories = New System.Windows.Forms.PictureBox()
        Me.picDeleteFault = New System.Windows.Forms.PictureBox()
        CType(Me.picNotification, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCategoryRefress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrandRefresh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRefreshAccesorries, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCreateAccessories, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCreateFault, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRefreshFault, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDeleteAccessories, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDeleteFault, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.Color.DeepPink
        Me.cmdSave.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSave.ForeColor = System.Drawing.Color.White
        Me.cmdSave.Location = New System.Drawing.Point(0, 828)
        Me.cmdSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(129, 35)
        Me.cmdSave.TabIndex = 28
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'lstFaultList
        '
        Me.lstFaultList.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstFaultList.BackColor = System.Drawing.Color.White
        Me.lstFaultList.BackgroundImageTiled = True
        Me.lstFaultList.CheckBoxes = True
        Me.lstFaultList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstFaultList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lstFaultList.HideSelection = False
        Me.lstFaultList.Location = New System.Drawing.Point(18, 508)
        Me.lstFaultList.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstFaultList.Name = "lstFaultList"
        Me.lstFaultList.Size = New System.Drawing.Size(1147, 273)
        Me.lstFaultList.TabIndex = 26
        Me.lstFaultList.UseCompatibleStateImageBehavior = False
        Me.lstFaultList.View = System.Windows.Forms.View.List
        '
        'cmdSaveandPrint
        '
        Me.cmdSaveandPrint.BackColor = System.Drawing.Color.DeepPink
        Me.cmdSaveandPrint.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen
        Me.cmdSaveandPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSaveandPrint.ForeColor = System.Drawing.Color.White
        Me.cmdSaveandPrint.Location = New System.Drawing.Point(130, 828)
        Me.cmdSaveandPrint.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdSaveandPrint.Name = "cmdSaveandPrint"
        Me.cmdSaveandPrint.Size = New System.Drawing.Size(129, 35)
        Me.cmdSaveandPrint.TabIndex = 29
        Me.cmdSaveandPrint.Text = "Save and &Print"
        Me.cmdSaveandPrint.UseVisualStyleBackColor = False
        '
        'cmdFind
        '
        Me.cmdFind.BackColor = System.Drawing.Color.DeepPink
        Me.cmdFind.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen
        Me.cmdFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFind.ForeColor = System.Drawing.Color.White
        Me.cmdFind.Location = New System.Drawing.Point(261, 828)
        Me.cmdFind.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(129, 35)
        Me.cmdFind.TabIndex = 30
        Me.cmdFind.Text = "&Find"
        Me.cmdFind.UseVisualStyleBackColor = False
        '
        'cmdService
        '
        Me.cmdService.BackColor = System.Drawing.Color.DeepPink
        Me.cmdService.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen
        Me.cmdService.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdService.ForeColor = System.Drawing.Color.White
        Me.cmdService.Location = New System.Drawing.Point(393, 828)
        Me.cmdService.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdService.Name = "cmdService"
        Me.cmdService.Size = New System.Drawing.Size(129, 35)
        Me.cmdService.TabIndex = 31
        Me.cmdService.Text = "Se&rvice"
        Me.cmdService.UseVisualStyleBackColor = False
        '
        'cmdBill
        '
        Me.cmdBill.BackColor = System.Drawing.Color.DeepPink
        Me.cmdBill.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen
        Me.cmdBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBill.ForeColor = System.Drawing.Color.White
        Me.cmdBill.Location = New System.Drawing.Point(522, 828)
        Me.cmdBill.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdBill.Name = "cmdBill"
        Me.cmdBill.Size = New System.Drawing.Size(129, 35)
        Me.cmdBill.TabIndex = 32
        Me.cmdBill.Text = "&Bill"
        Me.cmdBill.UseVisualStyleBackColor = False
        '
        'cmdReport
        '
        Me.cmdReport.BackColor = System.Drawing.Color.DeepPink
        Me.cmdReport.Enabled = False
        Me.cmdReport.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen
        Me.cmdReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdReport.ForeColor = System.Drawing.Color.White
        Me.cmdReport.Location = New System.Drawing.Point(651, 828)
        Me.cmdReport.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdReport.Name = "cmdReport"
        Me.cmdReport.Size = New System.Drawing.Size(129, 35)
        Me.cmdReport.TabIndex = 33
        Me.cmdReport.Text = "&Report"
        Me.cmdReport.UseVisualStyleBackColor = False
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.Color.DeepPink
        Me.cmdClose.CausesValidation = False
        Me.cmdClose.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClose.ForeColor = System.Drawing.Color.White
        Me.cmdClose.Location = New System.Drawing.Point(780, 828)
        Me.cmdClose.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(129, 35)
        Me.cmdClose.TabIndex = 34
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'cmdCanceljob
        '
        Me.cmdCanceljob.BackColor = System.Drawing.Color.DeepPink
        Me.cmdCanceljob.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen
        Me.cmdCanceljob.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCanceljob.ForeColor = System.Drawing.Color.White
        Me.cmdCanceljob.Location = New System.Drawing.Point(909, 828)
        Me.cmdCanceljob.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdCanceljob.Name = "cmdCanceljob"
        Me.cmdCanceljob.Size = New System.Drawing.Size(129, 35)
        Me.cmdCanceljob.TabIndex = 35
        Me.cmdCanceljob.Text = "Cancel &Job"
        Me.cmdCanceljob.UseVisualStyleBackColor = False
        '
        'cmdTransferJob
        '
        Me.cmdTransferJob.BackColor = System.Drawing.Color.DeepPink
        Me.cmdTransferJob.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen
        Me.cmdTransferJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdTransferJob.ForeColor = System.Drawing.Color.White
        Me.cmdTransferJob.Location = New System.Drawing.Point(1038, 828)
        Me.cmdTransferJob.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdTransferJob.Name = "cmdTransferJob"
        Me.cmdTransferJob.Size = New System.Drawing.Size(129, 35)
        Me.cmdTransferJob.TabIndex = 36
        Me.cmdTransferJob.Text = "&Transfer Job"
        Me.cmdTransferJob.UseVisualStyleBackColor = False
        '
        'lstAccessoriesList
        '
        Me.lstAccessoriesList.BackColor = System.Drawing.Color.White
        Me.lstAccessoriesList.BackgroundImageTiled = True
        Me.lstAccessoriesList.CheckBoxes = True
        Me.lstAccessoriesList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstAccessoriesList.HideSelection = False
        Me.lstAccessoriesList.Location = New System.Drawing.Point(369, 285)
        Me.lstAccessoriesList.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstAccessoriesList.Name = "lstAccessoriesList"
        Me.lstAccessoriesList.Size = New System.Drawing.Size(511, 79)
        Me.lstAccessoriesList.TabIndex = 13
        Me.lstAccessoriesList.UseCompatibleStateImageBehavior = False
        Me.lstAccessoriesList.View = System.Windows.Forms.View.List
        '
        'txtJobCode
        '
        Me.txtJobCode.Location = New System.Drawing.Point(117, 45)
        Me.txtJobCode.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtJobCode.Name = "txtJobCode"
        Me.txtJobCode.Size = New System.Drawing.Size(130, 26)
        Me.txtJobCode.TabIndex = 0
        '
        'txtCustReference
        '
        Me.txtCustReference.Location = New System.Drawing.Point(645, 45)
        Me.txtCustReference.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCustReference.Name = "txtCustReference"
        Me.txtCustReference.Size = New System.Drawing.Size(186, 26)
        Me.txtCustReference.TabIndex = 2
        '
        'cmbBranchName
        '
        Me.cmbBranchName.DropDownHeight = 80
        Me.cmbBranchName.FormattingEnabled = True
        Me.cmbBranchName.IntegralHeight = False
        Me.cmbBranchName.Location = New System.Drawing.Point(966, 45)
        Me.cmbBranchName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbBranchName.Name = "cmbBranchName"
        Me.cmbBranchName.Size = New System.Drawing.Size(194, 28)
        Me.cmbBranchName.TabIndex = 4
        '
        'lblJobCode
        '
        Me.lblJobCode.AutoSize = True
        Me.lblJobCode.ForeColor = System.Drawing.Color.Red
        Me.lblJobCode.Location = New System.Drawing.Point(30, 51)
        Me.lblJobCode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJobCode.Name = "lblJobCode"
        Me.lblJobCode.Size = New System.Drawing.Size(75, 20)
        Me.lblJobCode.TabIndex = 19
        Me.lblJobCode.Text = "**Job No."
        '
        'lblCustGrade
        '
        Me.lblCustGrade.AutoSize = True
        Me.lblCustGrade.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCustGrade.Location = New System.Drawing.Point(260, 51)
        Me.lblCustGrade.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCustGrade.Name = "lblCustGrade"
        Me.lblCustGrade.Size = New System.Drawing.Size(95, 20)
        Me.lblCustGrade.TabIndex = 20
        Me.lblCustGrade.Text = "Cust. Grade"
        '
        'lblCustReference
        '
        Me.lblCustReference.AutoSize = True
        Me.lblCustReference.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCustReference.Location = New System.Drawing.Point(519, 51)
        Me.lblCustReference.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCustReference.Name = "lblCustReference"
        Me.lblCustReference.Size = New System.Drawing.Size(125, 20)
        Me.lblCustReference.TabIndex = 21
        Me.lblCustReference.Text = "Cust. Reference"
        '
        'lblBranchName
        '
        Me.lblBranchName.AutoSize = True
        Me.lblBranchName.ForeColor = System.Drawing.Color.Red
        Me.lblBranchName.Location = New System.Drawing.Point(838, 51)
        Me.lblBranchName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBranchName.Name = "lblBranchName"
        Me.lblBranchName.Size = New System.Drawing.Size(118, 20)
        Me.lblBranchName.TabIndex = 22
        Me.lblBranchName.Text = "**Branch Name"
        '
        'cmbCustGrade
        '
        Me.cmbCustGrade.DropDownHeight = 80
        Me.cmbCustGrade.FormattingEnabled = True
        Me.cmbCustGrade.IntegralHeight = False
        Me.cmbCustGrade.Location = New System.Drawing.Point(356, 45)
        Me.cmbCustGrade.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbCustGrade.Name = "cmbCustGrade"
        Me.cmbCustGrade.Size = New System.Drawing.Size(162, 28)
        Me.cmbCustGrade.TabIndex = 1
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.ForeColor = System.Drawing.Color.Red
        Me.lblAddress.Location = New System.Drawing.Point(24, 148)
        Me.lblAddress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(84, 20)
        Me.lblAddress.TabIndex = 27
        Me.lblAddress.Text = "**Address:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.ForeColor = System.Drawing.Color.Red
        Me.lblName.Location = New System.Drawing.Point(39, 115)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(67, 20)
        Me.lblName.TabIndex = 26
        Me.lblName.Text = "**Name:"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(117, 142)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(464, 26)
        Me.txtAddress.TabIndex = 5
        '
        'txtName
        '
        Me.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtName.Location = New System.Drawing.Point(117, 109)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(350, 26)
        Me.txtName.TabIndex = 3
        '
        'lblCustomerInformation
        '
        Me.lblCustomerInformation.AutoSize = True
        Me.lblCustomerInformation.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerInformation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCustomerInformation.Location = New System.Drawing.Point(20, 80)
        Me.lblCustomerInformation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCustomerInformation.Name = "lblCustomerInformation"
        Me.lblCustomerInformation.Size = New System.Drawing.Size(185, 20)
        Me.lblCustomerInformation.TabIndex = 31
        Me.lblCustomerInformation.Text = "Customer Information"
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblContact.Location = New System.Drawing.Point(38, 180)
        Me.lblContact.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(69, 20)
        Me.lblContact.TabIndex = 30
        Me.lblContact.Text = "Contact:"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(117, 174)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(464, 26)
        Me.txtPhone.TabIndex = 6
        '
        'chkREL
        '
        Me.chkREL.AutoSize = True
        Me.chkREL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkREL.Location = New System.Drawing.Point(474, 109)
        Me.chkREL.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkREL.Name = "chkREL"
        Me.chkREL.Size = New System.Drawing.Size(67, 24)
        Me.chkREL.TabIndex = 4
        Me.chkREL.Text = "REL"
        Me.chkREL.UseVisualStyleBackColor = True
        '
        'dtpReceiveDate
        '
        Me.dtpReceiveDate.CustomFormat = "dd-Jul-yy"
        Me.dtpReceiveDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpReceiveDate.Location = New System.Drawing.Point(758, 109)
        Me.dtpReceiveDate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpReceiveDate.Name = "dtpReceiveDate"
        Me.dtpReceiveDate.Size = New System.Drawing.Size(145, 26)
        Me.dtpReceiveDate.TabIndex = 8
        Me.dtpReceiveDate.Value = New Date(2017, 1, 22, 0, 0, 0, 0)
        '
        'dtpDelDTApprox
        '
        Me.dtpDelDTApprox.CustomFormat = "dd-MMM-yy"
        Me.dtpDelDTApprox.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDelDTApprox.Location = New System.Drawing.Point(758, 145)
        Me.dtpDelDTApprox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpDelDTApprox.Name = "dtpDelDTApprox"
        Me.dtpDelDTApprox.Size = New System.Drawing.Size(145, 26)
        Me.dtpDelDTApprox.TabIndex = 9
        '
        'cmbJobAssigntoCode
        '
        Me.cmbJobAssigntoCode.DropDownHeight = 80
        Me.cmbJobAssigntoCode.FormattingEnabled = True
        Me.cmbJobAssigntoCode.IntegralHeight = False
        Me.cmbJobAssigntoCode.Location = New System.Drawing.Point(1020, 183)
        Me.cmbJobAssigntoCode.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbJobAssigntoCode.Name = "cmbJobAssigntoCode"
        Me.cmbJobAssigntoCode.Size = New System.Drawing.Size(145, 28)
        Me.cmbJobAssigntoCode.TabIndex = 12
        '
        'lblJobAssignto
        '
        Me.lblJobAssignto.AutoSize = True
        Me.lblJobAssignto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblJobAssignto.Location = New System.Drawing.Point(938, 189)
        Me.lblJobAssignto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJobAssignto.Name = "lblJobAssignto"
        Me.lblJobAssignto.Size = New System.Drawing.Size(75, 20)
        Me.lblJobAssignto.TabIndex = 35
        Me.lblJobAssignto.Text = "Assign to"
        '
        'lblReceivedDate
        '
        Me.lblReceivedDate.AutoSize = True
        Me.lblReceivedDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblReceivedDate.Location = New System.Drawing.Point(640, 115)
        Me.lblReceivedDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReceivedDate.Name = "lblReceivedDate"
        Me.lblReceivedDate.Size = New System.Drawing.Size(105, 20)
        Me.lblReceivedDate.TabIndex = 37
        Me.lblReceivedDate.Text = "Receive Date"
        '
        'lblDelDTApprox
        '
        Me.lblDelDTApprox.AutoSize = True
        Me.lblDelDTApprox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDelDTApprox.Location = New System.Drawing.Point(636, 151)
        Me.lblDelDTApprox.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDelDTApprox.Name = "lblDelDTApprox"
        Me.lblDelDTApprox.Size = New System.Drawing.Size(114, 20)
        Me.lblDelDTApprox.TabIndex = 38
        Me.lblDelDTApprox.Text = "Del Dt(Approx)"
        '
        'lblAssignDate
        '
        Me.lblAssignDate.AutoSize = True
        Me.lblAssignDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAssignDate.Location = New System.Drawing.Point(916, 115)
        Me.lblAssignDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAssignDate.Name = "lblAssignDate"
        Me.lblAssignDate.Size = New System.Drawing.Size(96, 20)
        Me.lblAssignDate.TabIndex = 40
        Me.lblAssignDate.Text = "Assign Date"
        '
        'dtpAssignDate
        '
        Me.dtpAssignDate.CustomFormat = "dd-MMM-yy"
        Me.dtpAssignDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAssignDate.Location = New System.Drawing.Point(1020, 109)
        Me.dtpAssignDate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpAssignDate.Name = "dtpAssignDate"
        Me.dtpAssignDate.Size = New System.Drawing.Size(145, 26)
        Me.dtpAssignDate.TabIndex = 11
        '
        'cmbReceivedbyCode
        '
        Me.cmbReceivedbyCode.DropDownHeight = 80
        Me.cmbReceivedbyCode.DropDownWidth = 40
        Me.cmbReceivedbyCode.FormattingEnabled = True
        Me.cmbReceivedbyCode.IntegralHeight = False
        Me.cmbReceivedbyCode.Location = New System.Drawing.Point(758, 183)
        Me.cmbReceivedbyCode.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbReceivedbyCode.Name = "cmbReceivedbyCode"
        Me.cmbReceivedbyCode.Size = New System.Drawing.Size(145, 28)
        Me.cmbReceivedbyCode.TabIndex = 10
        '
        'lblReceivedby
        '
        Me.lblReceivedby.AutoSize = True
        Me.lblReceivedby.ForeColor = System.Drawing.Color.Red
        Me.lblReceivedby.Location = New System.Drawing.Point(636, 189)
        Me.lblReceivedby.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReceivedby.Name = "lblReceivedby"
        Me.lblReceivedby.Size = New System.Drawing.Size(109, 20)
        Me.lblReceivedby.TabIndex = 41
        Me.lblReceivedby.Text = "**Received By"
        '
        'lblTechCode
        '
        Me.lblTechCode.AutoSize = True
        Me.lblTechCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblTechCode.Location = New System.Drawing.Point(518, 257)
        Me.lblTechCode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTechCode.MaximumSize = New System.Drawing.Size(135, 20)
        Me.lblTechCode.Name = "lblTechCode"
        Me.lblTechCode.Size = New System.Drawing.Size(0, 20)
        Me.lblTechCode.TabIndex = 10
        '
        'cmbCategory
        '
        Me.cmbCategory.CausesValidation = False
        Me.cmbCategory.DropDownHeight = 80
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.IntegralHeight = False
        Me.cmbCategory.Location = New System.Drawing.Point(118, 274)
        Me.cmbCategory.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(205, 28)
        Me.cmbCategory.TabIndex = 13
        Me.Tool.SetToolTip(Me.cmbCategory, "Category")
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.ForeColor = System.Drawing.Color.Red
        Me.lblCategory.Location = New System.Drawing.Point(22, 280)
        Me.lblCategory.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(85, 20)
        Me.lblCategory.TabIndex = 44
        Me.lblCategory.Text = "**Category"
        '
        'cmbBrand
        '
        Me.cmbBrand.DropDownHeight = 80
        Me.cmbBrand.FormattingEnabled = True
        Me.cmbBrand.IntegralHeight = False
        Me.cmbBrand.Location = New System.Drawing.Point(118, 309)
        Me.cmbBrand.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbBrand.Name = "cmbBrand"
        Me.cmbBrand.Size = New System.Drawing.Size(205, 28)
        Me.cmbBrand.TabIndex = 14
        '
        'lblBrand
        '
        Me.lblBrand.AutoSize = True
        Me.lblBrand.ForeColor = System.Drawing.Color.Red
        Me.lblBrand.Location = New System.Drawing.Point(44, 315)
        Me.lblBrand.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.Size = New System.Drawing.Size(64, 20)
        Me.lblBrand.TabIndex = 46
        Me.lblBrand.Text = "**Brand"
        '
        'cmbModel
        '
        Me.cmbModel.DropDownHeight = 80
        Me.cmbModel.FormattingEnabled = True
        Me.cmbModel.IntegralHeight = False
        Me.cmbModel.Location = New System.Drawing.Point(118, 345)
        Me.cmbModel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbModel.Name = "cmbModel"
        Me.cmbModel.Size = New System.Drawing.Size(205, 28)
        Me.cmbModel.TabIndex = 15
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.ForeColor = System.Drawing.Color.Red
        Me.lblModel.Location = New System.Drawing.Point(42, 351)
        Me.lblModel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(64, 20)
        Me.lblModel.TabIndex = 48
        Me.lblModel.Text = "**Model"
        '
        'lblSerialIMEI
        '
        Me.lblSerialIMEI.AutoSize = True
        Me.lblSerialIMEI.ForeColor = System.Drawing.Color.Red
        Me.lblSerialIMEI.Location = New System.Drawing.Point(6, 386)
        Me.lblSerialIMEI.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSerialIMEI.Name = "lblSerialIMEI"
        Me.lblSerialIMEI.Size = New System.Drawing.Size(99, 20)
        Me.lblSerialIMEI.TabIndex = 51
        Me.lblSerialIMEI.Text = "**Serial/IMEI"
        '
        'txtSerialIMEI
        '
        Me.txtSerialIMEI.Location = New System.Drawing.Point(118, 380)
        Me.txtSerialIMEI.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSerialIMEI.Name = "txtSerialIMEI"
        Me.txtSerialIMEI.Size = New System.Drawing.Size(205, 26)
        Me.txtSerialIMEI.TabIndex = 16
        '
        'lblESNNo
        '
        Me.lblESNNo.AutoSize = True
        Me.lblESNNo.ForeColor = System.Drawing.Color.Black
        Me.lblESNNo.Location = New System.Drawing.Point(34, 420)
        Me.lblESNNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblESNNo.Name = "lblESNNo"
        Me.lblESNNo.Size = New System.Drawing.Size(70, 20)
        Me.lblESNNo.TabIndex = 53
        Me.lblESNNo.Text = "ESN No."
        '
        'txtESNNo
        '
        Me.txtESNNo.Location = New System.Drawing.Point(118, 414)
        Me.txtESNNo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtESNNo.Name = "txtESNNo"
        Me.txtESNNo.Size = New System.Drawing.Size(205, 26)
        Me.txtESNNo.TabIndex = 17
        '
        'optSalesWarranty
        '
        Me.optSalesWarranty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.optSalesWarranty.Location = New System.Drawing.Point(543, 397)
        Me.optSalesWarranty.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.optSalesWarranty.Name = "optSalesWarranty"
        Me.optSalesWarranty.Size = New System.Drawing.Size(78, 25)
        Me.optSalesWarranty.TabIndex = 21
        Me.optSalesWarranty.TabStop = True
        Me.optSalesWarranty.Text = "Sales"
        Me.optSalesWarranty.UseVisualStyleBackColor = True
        '
        'optNonWarranty
        '
        Me.optNonWarranty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.optNonWarranty.Location = New System.Drawing.Point(630, 397)
        Me.optNonWarranty.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.optNonWarranty.Name = "optNonWarranty"
        Me.optNonWarranty.Size = New System.Drawing.Size(105, 25)
        Me.optNonWarranty.TabIndex = 22
        Me.optNonWarranty.TabStop = True
        Me.optNonWarranty.Text = "Payment"
        Me.optNonWarranty.UseVisualStyleBackColor = True
        '
        'optServiceWarranty
        '
        Me.optServiceWarranty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.optServiceWarranty.Location = New System.Drawing.Point(759, 397)
        Me.optServiceWarranty.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.optServiceWarranty.Name = "optServiceWarranty"
        Me.optServiceWarranty.Size = New System.Drawing.Size(93, 25)
        Me.optServiceWarranty.TabIndex = 23
        Me.optServiceWarranty.TabStop = True
        Me.optServiceWarranty.Text = "Service"
        Me.optServiceWarranty.UseVisualStyleBackColor = True
        '
        'txtAccessoriesReceived
        '
        Me.txtAccessoriesReceived.BackColor = System.Drawing.Color.White
        Me.txtAccessoriesReceived.Location = New System.Drawing.Point(442, 363)
        Me.txtAccessoriesReceived.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAccessoriesReceived.Name = "txtAccessoriesReceived"
        Me.txtAccessoriesReceived.Size = New System.Drawing.Size(438, 26)
        Me.txtAccessoriesReceived.TabIndex = 18
        '
        'lblDateofPurchase
        '
        Me.lblDateofPurchase.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDateofPurchase.Location = New System.Drawing.Point(627, 442)
        Me.lblDateofPurchase.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDateofPurchase.Name = "lblDateofPurchase"
        Me.lblDateofPurchase.Size = New System.Drawing.Size(117, 20)
        Me.lblDateofPurchase.TabIndex = 60
        Me.lblDateofPurchase.Text = "Purchase Date"
        Me.lblDateofPurchase.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpDateofPurchase
        '
        Me.dtpDateofPurchase.CustomFormat = "dd-MMM-yy"
        Me.dtpDateofPurchase.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateofPurchase.Location = New System.Drawing.Point(747, 435)
        Me.dtpDateofPurchase.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpDateofPurchase.Name = "dtpDateofPurchase"
        Me.dtpDateofPurchase.Size = New System.Drawing.Size(139, 26)
        Me.dtpDateofPurchase.TabIndex = 24
        '
        'txtReturnedItem
        '
        Me.txtReturnedItem.BackColor = System.Drawing.Color.White
        Me.txtReturnedItem.Location = New System.Drawing.Point(915, 291)
        Me.txtReturnedItem.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtReturnedItem.Multiline = True
        Me.txtReturnedItem.Name = "txtReturnedItem"
        Me.txtReturnedItem.Size = New System.Drawing.Size(250, 64)
        Me.txtReturnedItem.TabIndex = 19
        '
        'txtPhysicalCondition
        '
        Me.txtPhysicalCondition.BackColor = System.Drawing.Color.White
        Me.txtPhysicalCondition.Location = New System.Drawing.Point(915, 391)
        Me.txtPhysicalCondition.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPhysicalCondition.Multiline = True
        Me.txtPhysicalCondition.Name = "txtPhysicalCondition"
        Me.txtPhysicalCondition.Size = New System.Drawing.Size(250, 96)
        Me.txtPhysicalCondition.TabIndex = 20
        '
        'txtOtherFault
        '
        Me.txtOtherFault.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtOtherFault.Location = New System.Drawing.Point(682, 786)
        Me.txtOtherFault.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtOtherFault.Name = "txtOtherFault"
        Me.txtOtherFault.Size = New System.Drawing.Size(130, 26)
        Me.txtOtherFault.TabIndex = 27
        '
        'lblProductInformation
        '
        Me.lblProductInformation.AutoSize = True
        Me.lblProductInformation.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductInformation.Location = New System.Drawing.Point(20, 246)
        Me.lblProductInformation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProductInformation.Name = "lblProductInformation"
        Me.lblProductInformation.Size = New System.Drawing.Size(129, 20)
        Me.lblProductInformation.TabIndex = 31
        Me.lblProductInformation.Text = "Product Details"
        '
        'lblDateInformation
        '
        Me.lblDateInformation.AutoSize = True
        Me.lblDateInformation.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateInformation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblDateInformation.Location = New System.Drawing.Point(636, 80)
        Me.lblDateInformation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDateInformation.Name = "lblDateInformation"
        Me.lblDateInformation.Size = New System.Drawing.Size(145, 20)
        Me.lblDateInformation.TabIndex = 31
        Me.lblDateInformation.Text = "Date Information"
        '
        'lblAccessories
        '
        Me.lblAccessories.AutoSize = True
        Me.lblAccessories.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccessories.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAccessories.Location = New System.Drawing.Point(372, 257)
        Me.lblAccessories.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAccessories.Name = "lblAccessories"
        Me.lblAccessories.Size = New System.Drawing.Size(171, 20)
        Me.lblAccessories.TabIndex = 31
        Me.lblAccessories.Text = "Accessories Received"
        '
        'lblPreviousJob
        '
        Me.lblPreviousJob.AutoSize = True
        Me.lblPreviousJob.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPreviousJob.Location = New System.Drawing.Point(352, 478)
        Me.lblPreviousJob.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPreviousJob.Name = "lblPreviousJob"
        Me.lblPreviousJob.Size = New System.Drawing.Size(99, 20)
        Me.lblPreviousJob.TabIndex = 69
        Me.lblPreviousJob.Text = "Previous Job"
        Me.lblPreviousJob.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPreviousJob
        '
        Me.txtPreviousJob.Location = New System.Drawing.Point(460, 472)
        Me.txtPreviousJob.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPreviousJob.Multiline = True
        Me.txtPreviousJob.Name = "txtPreviousJob"
        Me.txtPreviousJob.Size = New System.Drawing.Size(426, 24)
        Me.txtPreviousJob.TabIndex = 25
        '
        'lblPhysicalCondition
        '
        Me.lblPhysicalCondition.AutoSize = True
        Me.lblPhysicalCondition.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhysicalCondition.Location = New System.Drawing.Point(916, 362)
        Me.lblPhysicalCondition.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPhysicalCondition.Name = "lblPhysicalCondition"
        Me.lblPhysicalCondition.Size = New System.Drawing.Size(157, 20)
        Me.lblPhysicalCondition.TabIndex = 70
        Me.lblPhysicalCondition.Text = "Physical Condition"
        '
        'lblReturnedItem
        '
        Me.lblReturnedItem.AutoSize = True
        Me.lblReturnedItem.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReturnedItem.Location = New System.Drawing.Point(916, 262)
        Me.lblReturnedItem.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReturnedItem.Name = "lblReturnedItem"
        Me.lblReturnedItem.Size = New System.Drawing.Size(122, 20)
        Me.lblReturnedItem.TabIndex = 71
        Me.lblReturnedItem.Text = "Returned Item"
        '
        'lblFailurDescription
        '
        Me.lblFailurDescription.AutoSize = True
        Me.lblFailurDescription.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFailurDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblFailurDescription.Location = New System.Drawing.Point(21, 478)
        Me.lblFailurDescription.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFailurDescription.Name = "lblFailurDescription"
        Me.lblFailurDescription.Size = New System.Drawing.Size(149, 20)
        Me.lblFailurDescription.TabIndex = 74
        Me.lblFailurDescription.Text = "Failur Description"
        '
        'lblOtherFault
        '
        Me.lblOtherFault.AutoSize = True
        Me.lblOtherFault.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOtherFault.Location = New System.Drawing.Point(315, 791)
        Me.lblOtherFault.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOtherFault.Name = "lblOtherFault"
        Me.lblOtherFault.Size = New System.Drawing.Size(167, 20)
        Me.lblOtherFault.TabIndex = 75
        Me.lblOtherFault.Text = "Customer Complain"
        '
        'chkMakeDuplicate
        '
        Me.chkMakeDuplicate.AutoSize = True
        Me.chkMakeDuplicate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkMakeDuplicate.Location = New System.Drawing.Point(34, 12)
        Me.chkMakeDuplicate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkMakeDuplicate.Name = "chkMakeDuplicate"
        Me.chkMakeDuplicate.Size = New System.Drawing.Size(145, 24)
        Me.chkMakeDuplicate.TabIndex = 78
        Me.chkMakeDuplicate.Text = "Make Duplicate"
        Me.chkMakeDuplicate.UseVisualStyleBackColor = True
        '
        'lblSetBranch
        '
        Me.lblSetBranch.AutoSize = True
        Me.lblSetBranch.Location = New System.Drawing.Point(957, 14)
        Me.lblSetBranch.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSetBranch.Name = "lblSetBranch"
        Me.lblSetBranch.Size = New System.Drawing.Size(89, 20)
        Me.lblSetBranch.TabIndex = 80
        Me.lblSetBranch.Text = "Set &Branch"
        '
        'lblEMail
        '
        Me.lblEMail.AutoSize = True
        Me.lblEMail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblEMail.Location = New System.Drawing.Point(56, 212)
        Me.lblEMail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEMail.Name = "lblEMail"
        Me.lblEMail.Size = New System.Drawing.Size(52, 20)
        Me.lblEMail.TabIndex = 82
        Me.lblEMail.Text = "Email:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(117, 206)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(464, 26)
        Me.txtEmail.TabIndex = 7
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'picNotification
        '
        Me.picNotification.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picNotification.Location = New System.Drawing.Point(330, 352)
        Me.picNotification.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.picNotification.Name = "picNotification"
        Me.picNotification.Size = New System.Drawing.Size(22, 23)
        Me.picNotification.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picNotification.TabIndex = 79
        Me.picNotification.TabStop = False
        '
        'cmbSalesWarranty
        '
        Me.cmbSalesWarranty.DropDownHeight = 80
        Me.cmbSalesWarranty.FormattingEnabled = True
        Me.cmbSalesWarranty.IntegralHeight = False
        Me.cmbSalesWarranty.Items.AddRange(New Object() {"Full", "Parts", "Service Charge"})
        Me.cmbSalesWarranty.Location = New System.Drawing.Point(462, 435)
        Me.cmbSalesWarranty.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbSalesWarranty.Name = "cmbSalesWarranty"
        Me.cmbSalesWarranty.Size = New System.Drawing.Size(160, 28)
        Me.cmbSalesWarranty.TabIndex = 83
        Me.cmbSalesWarranty.Visible = False
        '
        'lblWarrantyType
        '
        Me.lblWarrantyType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWarrantyType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblWarrantyType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblWarrantyType.Location = New System.Drawing.Point(351, 397)
        Me.lblWarrantyType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWarrantyType.Name = "lblWarrantyType"
        Me.lblWarrantyType.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.lblWarrantyType.Size = New System.Drawing.Size(183, 25)
        Me.lblWarrantyType.TabIndex = 84
        Me.lblWarrantyType.Text = "Warranty Type"
        Me.lblWarrantyType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblWarrLevel
        '
        Me.lblWarrLevel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblWarrLevel.Location = New System.Drawing.Point(351, 440)
        Me.lblWarrLevel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWarrLevel.Name = "lblWarrLevel"
        Me.lblWarrLevel.Size = New System.Drawing.Size(102, 23)
        Me.lblWarrLevel.TabIndex = 85
        Me.lblWarrLevel.Text = "Warr. Level"
        Me.lblWarrLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblWarrLevel.Visible = False
        '
        'chkOldFrom
        '
        Me.chkOldFrom.AutoSize = True
        Me.chkOldFrom.Enabled = False
        Me.chkOldFrom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkOldFrom.Location = New System.Drawing.Point(352, 12)
        Me.chkOldFrom.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkOldFrom.Name = "chkOldFrom"
        Me.chkOldFrom.Size = New System.Drawing.Size(100, 24)
        Me.chkOldFrom.TabIndex = 86
        Me.chkOldFrom.Text = "Old Form"
        Me.chkOldFrom.UseVisualStyleBackColor = True
        Me.chkOldFrom.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(364, 369)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 20)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "Remarks"
        '
        'lblReceivedByCode
        '
        Me.lblReceivedByCode.BackColor = System.Drawing.Color.White
        Me.lblReceivedByCode.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceivedByCode.Location = New System.Drawing.Point(636, 222)
        Me.lblReceivedByCode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReceivedByCode.Name = "lblReceivedByCode"
        Me.lblReceivedByCode.Padding = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReceivedByCode.Size = New System.Drawing.Size(268, 31)
        Me.lblReceivedByCode.TabIndex = 67
        Me.lblReceivedByCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblJobAssigntoCode
        '
        Me.lblJobAssigntoCode.BackColor = System.Drawing.Color.White
        Me.lblJobAssigntoCode.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJobAssigntoCode.Location = New System.Drawing.Point(914, 222)
        Me.lblJobAssigntoCode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJobAssigntoCode.Name = "lblJobAssigntoCode"
        Me.lblJobAssigntoCode.Padding = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJobAssigntoCode.Size = New System.Drawing.Size(254, 31)
        Me.lblJobAssigntoCode.TabIndex = 73
        Me.lblJobAssigntoCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picCategoryRefress
        '
        Me.picCategoryRefress.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picCategoryRefress.Image = CType(resources.GetObject("picCategoryRefress.Image"), System.Drawing.Image)
        Me.picCategoryRefress.Location = New System.Drawing.Point(330, 277)
        Me.picCategoryRefress.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.picCategoryRefress.Name = "picCategoryRefress"
        Me.picCategoryRefress.Size = New System.Drawing.Size(22, 23)
        Me.picCategoryRefress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCategoryRefress.TabIndex = 89
        Me.picCategoryRefress.TabStop = False
        Me.Tool.SetToolTip(Me.picCategoryRefress, "Refresh Category")
        '
        'picBrandRefresh
        '
        Me.picBrandRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picBrandRefresh.Image = CType(resources.GetObject("picBrandRefresh.Image"), System.Drawing.Image)
        Me.picBrandRefresh.Location = New System.Drawing.Point(330, 315)
        Me.picBrandRefresh.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.picBrandRefresh.Name = "picBrandRefresh"
        Me.picBrandRefresh.Size = New System.Drawing.Size(22, 23)
        Me.picBrandRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrandRefresh.TabIndex = 90
        Me.picBrandRefresh.TabStop = False
        Me.Tool.SetToolTip(Me.picBrandRefresh, "Refresh Brand")
        '
        'picRefreshAccesorries
        '
        Me.picRefreshAccesorries.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picRefreshAccesorries.Image = CType(resources.GetObject("picRefreshAccesorries.Image"), System.Drawing.Image)
        Me.picRefreshAccesorries.Location = New System.Drawing.Point(574, 257)
        Me.picRefreshAccesorries.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.picRefreshAccesorries.Name = "picRefreshAccesorries"
        Me.picRefreshAccesorries.Size = New System.Drawing.Size(22, 23)
        Me.picRefreshAccesorries.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRefreshAccesorries.TabIndex = 91
        Me.picRefreshAccesorries.TabStop = False
        Me.Tool.SetToolTip(Me.picRefreshAccesorries, "Refresh Accessories")
        '
        'picCreateAccessories
        '
        Me.picCreateAccessories.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picCreateAccessories.Image = CType(resources.GetObject("picCreateAccessories.Image"), System.Drawing.Image)
        Me.picCreateAccessories.Location = New System.Drawing.Point(549, 257)
        Me.picCreateAccessories.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.picCreateAccessories.Name = "picCreateAccessories"
        Me.picCreateAccessories.Size = New System.Drawing.Size(22, 23)
        Me.picCreateAccessories.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCreateAccessories.TabIndex = 92
        Me.picCreateAccessories.TabStop = False
        Me.Tool.SetToolTip(Me.picCreateAccessories, "Create Accessories")
        '
        'picCreateFault
        '
        Me.picCreateFault.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picCreateFault.Image = CType(resources.GetObject("picCreateFault.Image"), System.Drawing.Image)
        Me.picCreateFault.Location = New System.Drawing.Point(186, 478)
        Me.picCreateFault.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.picCreateFault.Name = "picCreateFault"
        Me.picCreateFault.Size = New System.Drawing.Size(22, 23)
        Me.picCreateFault.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCreateFault.TabIndex = 94
        Me.picCreateFault.TabStop = False
        Me.Tool.SetToolTip(Me.picCreateFault, "Create New Fault")
        '
        'picRefreshFault
        '
        Me.picRefreshFault.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picRefreshFault.Image = CType(resources.GetObject("picRefreshFault.Image"), System.Drawing.Image)
        Me.picRefreshFault.Location = New System.Drawing.Point(213, 478)
        Me.picRefreshFault.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.picRefreshFault.Name = "picRefreshFault"
        Me.picRefreshFault.Size = New System.Drawing.Size(22, 23)
        Me.picRefreshFault.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRefreshFault.TabIndex = 93
        Me.picRefreshFault.TabStop = False
        Me.Tool.SetToolTip(Me.picRefreshFault, "Refresh Failure Description")
        '
        'picDeleteAccessories
        '
        Me.picDeleteAccessories.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picDeleteAccessories.Image = CType(resources.GetObject("picDeleteAccessories.Image"), System.Drawing.Image)
        Me.picDeleteAccessories.Location = New System.Drawing.Point(602, 257)
        Me.picDeleteAccessories.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.picDeleteAccessories.Name = "picDeleteAccessories"
        Me.picDeleteAccessories.Size = New System.Drawing.Size(22, 23)
        Me.picDeleteAccessories.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDeleteAccessories.TabIndex = 95
        Me.picDeleteAccessories.TabStop = False
        Me.Tool.SetToolTip(Me.picDeleteAccessories, "Delete Accessories")
        '
        'picDeleteFault
        '
        Me.picDeleteFault.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picDeleteFault.Image = CType(resources.GetObject("picDeleteFault.Image"), System.Drawing.Image)
        Me.picDeleteFault.Location = New System.Drawing.Point(240, 478)
        Me.picDeleteFault.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.picDeleteFault.Name = "picDeleteFault"
        Me.picDeleteFault.Size = New System.Drawing.Size(22, 23)
        Me.picDeleteFault.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDeleteFault.TabIndex = 96
        Me.picDeleteFault.TabStop = False
        Me.Tool.SetToolTip(Me.picDeleteFault, "Delete Accessories")
        '
        'NewCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(1176, 865)
        Me.Controls.Add(Me.picDeleteFault)
        Me.Controls.Add(Me.picDeleteAccessories)
        Me.Controls.Add(Me.picCreateFault)
        Me.Controls.Add(Me.picRefreshFault)
        Me.Controls.Add(Me.picCreateAccessories)
        Me.Controls.Add(Me.picRefreshAccesorries)
        Me.Controls.Add(Me.picBrandRefresh)
        Me.Controls.Add(Me.picCategoryRefress)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkOldFrom)
        Me.Controls.Add(Me.lblWarrLevel)
        Me.Controls.Add(Me.lblWarrantyType)
        Me.Controls.Add(Me.cmbSalesWarranty)
        Me.Controls.Add(Me.lblEMail)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblSetBranch)
        Me.Controls.Add(Me.picNotification)
        Me.Controls.Add(Me.chkMakeDuplicate)
        Me.Controls.Add(Me.lblOtherFault)
        Me.Controls.Add(Me.lblFailurDescription)
        Me.Controls.Add(Me.lblJobAssigntoCode)
        Me.Controls.Add(Me.lblReturnedItem)
        Me.Controls.Add(Me.lblPhysicalCondition)
        Me.Controls.Add(Me.lblPreviousJob)
        Me.Controls.Add(Me.txtPreviousJob)
        Me.Controls.Add(Me.lblReceivedByCode)
        Me.Controls.Add(Me.txtOtherFault)
        Me.Controls.Add(Me.txtPhysicalCondition)
        Me.Controls.Add(Me.txtReturnedItem)
        Me.Controls.Add(Me.lblDateofPurchase)
        Me.Controls.Add(Me.dtpDateofPurchase)
        Me.Controls.Add(Me.txtAccessoriesReceived)
        Me.Controls.Add(Me.optServiceWarranty)
        Me.Controls.Add(Me.optNonWarranty)
        Me.Controls.Add(Me.optSalesWarranty)
        Me.Controls.Add(Me.lblESNNo)
        Me.Controls.Add(Me.txtESNNo)
        Me.Controls.Add(Me.lblSerialIMEI)
        Me.Controls.Add(Me.txtSerialIMEI)
        Me.Controls.Add(Me.cmbModel)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.cmbBrand)
        Me.Controls.Add(Me.lblBrand)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.lblCategory)
        Me.Controls.Add(Me.lblTechCode)
        Me.Controls.Add(Me.cmbReceivedbyCode)
        Me.Controls.Add(Me.lblReceivedby)
        Me.Controls.Add(Me.lblAssignDate)
        Me.Controls.Add(Me.dtpAssignDate)
        Me.Controls.Add(Me.lblDelDTApprox)
        Me.Controls.Add(Me.lblReceivedDate)
        Me.Controls.Add(Me.cmbJobAssigntoCode)
        Me.Controls.Add(Me.lblJobAssignto)
        Me.Controls.Add(Me.dtpDelDTApprox)
        Me.Controls.Add(Me.dtpReceiveDate)
        Me.Controls.Add(Me.chkREL)
        Me.Controls.Add(Me.lblAccessories)
        Me.Controls.Add(Me.lblProductInformation)
        Me.Controls.Add(Me.lblDateInformation)
        Me.Controls.Add(Me.lblCustomerInformation)
        Me.Controls.Add(Me.lblContact)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.cmbCustGrade)
        Me.Controls.Add(Me.lblBranchName)
        Me.Controls.Add(Me.lblCustReference)
        Me.Controls.Add(Me.lblCustGrade)
        Me.Controls.Add(Me.lblJobCode)
        Me.Controls.Add(Me.cmbBranchName)
        Me.Controls.Add(Me.txtCustReference)
        Me.Controls.Add(Me.txtJobCode)
        Me.Controls.Add(Me.lstAccessoriesList)
        Me.Controls.Add(Me.cmdTransferJob)
        Me.Controls.Add(Me.cmdCanceljob)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdReport)
        Me.Controls.Add(Me.cmdBill)
        Me.Controls.Add(Me.cmdService)
        Me.Controls.Add(Me.cmdFind)
        Me.Controls.Add(Me.cmdSaveandPrint)
        Me.Controls.Add(Me.lstFaultList)
        Me.Controls.Add(Me.cmdSave)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "NewCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Customer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picNotification, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCategoryRefress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrandRefresh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRefreshAccesorries, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCreateAccessories, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCreateFault, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRefreshFault, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDeleteAccessories, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDeleteFault, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdSave As Button
    Friend WithEvents lstFaultList As ListView
    Friend WithEvents cmdSaveandPrint As Button
    Friend WithEvents cmdFind As Button
    Friend WithEvents cmdService As Button
    Friend WithEvents cmdBill As Button
    Friend WithEvents cmdReport As Button
    Friend WithEvents cmdClose As Button
    Friend WithEvents cmdCanceljob As Button
    Friend WithEvents cmdTransferJob As Button
    Friend WithEvents lstAccessoriesList As ListView
    Friend WithEvents txtJobCode As TextBox
    Friend WithEvents txtCustReference As TextBox
    Friend WithEvents cmbBranchName As ComboBox
    Friend WithEvents lblJobCode As Label
    Friend WithEvents lblCustGrade As Label
    Friend WithEvents lblCustReference As Label
    Friend WithEvents lblBranchName As Label
    Friend WithEvents cmbCustGrade As ComboBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblName As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblCustomerInformation As Label
    Friend WithEvents lblContact As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents chkREL As CheckBox
    Friend WithEvents dtpReceiveDate As DateTimePicker
    Friend WithEvents dtpDelDTApprox As DateTimePicker
    Friend WithEvents lblJobAssignto As Label
    Friend WithEvents lblReceivedDate As Label
    Friend WithEvents lblDelDTApprox As Label
    Friend WithEvents lblAssignDate As Label
    Friend WithEvents dtpAssignDate As DateTimePicker
    Friend WithEvents lblReceivedby As Label
    Friend WithEvents lblTechCode As Label
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents lblCategory As Label
    Friend WithEvents cmbBrand As ComboBox
    Friend WithEvents lblBrand As Label
    Friend WithEvents cmbModel As ComboBox
    Friend WithEvents lblModel As Label
    Friend WithEvents lblSerialIMEI As Label
    Friend WithEvents txtSerialIMEI As TextBox
    Friend WithEvents lblESNNo As Label
    Friend WithEvents txtESNNo As TextBox
    Friend WithEvents optSalesWarranty As RadioButton
    Friend WithEvents optNonWarranty As RadioButton
    Friend WithEvents optServiceWarranty As RadioButton
    Friend WithEvents txtAccessoriesReceived As TextBox
    Friend WithEvents lblDateofPurchase As Label
    Friend WithEvents dtpDateofPurchase As DateTimePicker
    Friend WithEvents txtReturnedItem As TextBox
    Friend WithEvents txtPhysicalCondition As TextBox
    Friend WithEvents txtOtherFault As TextBox
    Friend WithEvents lblProductInformation As Label
    Friend WithEvents lblDateInformation As Label
    Friend WithEvents lblAccessories As Label
    Friend WithEvents lblPreviousJob As Label
    Friend WithEvents txtPreviousJob As TextBox
    Friend WithEvents lblPhysicalCondition As Label
    Friend WithEvents lblReturnedItem As Label
    Friend WithEvents lblFailurDescription As Label
    Friend WithEvents lblOtherFault As Label
    Friend WithEvents picNotification As PictureBox
    Friend WithEvents chkMakeDuplicate As CheckBox
    Friend WithEvents lblSetBranch As Label
    Friend WithEvents lblEMail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents cmbSalesWarranty As ComboBox
    Friend WithEvents lblWarrantyType As Label
    Friend WithEvents lblWarrLevel As Label
    Friend WithEvents chkOldFrom As CheckBox
    Friend WithEvents Label1 As Label
    Public WithEvents cmbJobAssigntoCode As ComboBox
    Public WithEvents cmbReceivedbyCode As ComboBox
    Public WithEvents lblReceivedByCode As Label
    Public WithEvents lblJobAssigntoCode As Label
    Friend WithEvents picCategoryRefress As PictureBox
    Friend WithEvents picBrandRefresh As PictureBox
    Friend WithEvents Tool As ToolTip
    Friend WithEvents picRefreshAccesorries As PictureBox
    Friend WithEvents picCreateAccessories As PictureBox
    Friend WithEvents picCreateFault As PictureBox
    Friend WithEvents picRefreshFault As PictureBox
    Friend WithEvents picDeleteAccessories As PictureBox
    Friend WithEvents picDeleteFault As PictureBox
End Class
