<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOnpayment_Bill_Format
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtBranch = New System.Windows.Forms.TextBox()
        Me.txtWarrStatus = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtProductStatus = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtJobCode = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtEstimateRefuse = New System.Windows.Forms.TextBox()
        Me.txtServiceDate = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtServiceby = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtReceivedBy = New System.Windows.Forms.TextBox()
        Me.txtApproxDate = New System.Windows.Forms.TextBox()
        Me.txtReceiptDate = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtAddress2 = New System.Windows.Forms.TextBox()
        Me.txtAddress1 = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtESN = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtSerial = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.txtBrand = New System.Windows.Forms.TextBox()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbJobStatus = New System.Windows.Forms.TabControl()
        Me.tbItem = New System.Windows.Forms.TabPage()
        Me.lstTBItem = New System.Windows.Forms.ListView()
        Me.colTBItemSL = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTBListofItem = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tbWarranty = New System.Windows.Forms.TabPage()
        Me.txtTBPreviousJobno = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtTBPurchaseDate = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.optTBServiceWarranty = New System.Windows.Forms.RadioButton()
        Me.optTBNonWarranty = New System.Windows.Forms.RadioButton()
        Me.optTBSalesWarranty = New System.Windows.Forms.RadioButton()
        Me.tbFailurDescription = New System.Windows.Forms.TabPage()
        Me.lstTBFaultList = New System.Windows.Forms.ListView()
        Me.ColTBFaultSL = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTBFaultList = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstPartsList = New System.Windows.Forms.ListView()
        Me.colDelSLNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDelCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDelDescription = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDelUnit = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDelQty = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDelUnitPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDelTotal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.txtMR = New System.Windows.Forms.TextBox()
        Me.chkVatAmount = New System.Windows.Forms.CheckBox()
        Me.chkFreeofcost = New System.Windows.Forms.CheckBox()
        Me.cmdBill = New System.Windows.Forms.Button()
        Me.cmdPreview = New System.Windows.Forms.Button()
        Me.cmdCR = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.grpBillDescription = New System.Windows.Forms.GroupBox()
        Me.chkParts = New System.Windows.Forms.CheckBox()
        Me.txtOtherCharge = New System.Windows.Forms.TextBox()
        Me.lblVatAmount = New System.Windows.Forms.Label()
        Me.chkSpareAmount = New System.Windows.Forms.CheckBox()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.lblTotalSpareCost = New System.Windows.Forms.Label()
        Me.lblNetPayable = New System.Windows.Forms.Label()
        Me.txtAdvanceAmount = New System.Windows.Forms.TextBox()
        Me.lblAdvanceamount = New System.Windows.Forms.Label()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.lblOtherCharge = New System.Windows.Forms.Label()
        Me.lblVat = New System.Windows.Forms.Label()
        Me.txtRepairCharge = New System.Windows.Forms.TextBox()
        Me.lblRepairCharge = New System.Windows.Forms.Label()
        Me.txtFaultFindingCharge = New System.Windows.Forms.TextBox()
        Me.lblFaultFindingCharge = New System.Windows.Forms.Label()
        Me.lblTotalcostofspare = New System.Windows.Forms.Label()
        Me.lblDeliveryby = New System.Windows.Forms.Label()
        Me.lblEmployeeName = New System.Windows.Forms.Label()
        Me.cmbEmployeeCode = New System.Windows.Forms.ComboBox()
        Me.lblDeliveryDate = New System.Windows.Forms.Label()
        Me.dtpDelivery = New System.Windows.Forms.DateTimePicker()
        Me.chkRemarkEnabled = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.tbJobStatus.SuspendLayout()
        Me.tbItem.SuspendLayout()
        Me.tbWarranty.SuspendLayout()
        Me.tbFailurDescription.SuspendLayout()
        Me.grpBillDescription.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtBranch)
        Me.GroupBox1.Controls.Add(Me.txtWarrStatus)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.txtProductStatus)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.txtJobCode)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(735, 38)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Claim Information"
        '
        'txtBranch
        '
        Me.txtBranch.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtBranch.Location = New System.Drawing.Point(595, 16)
        Me.txtBranch.Multiline = True
        Me.txtBranch.Name = "txtBranch"
        Me.txtBranch.Size = New System.Drawing.Size(129, 18)
        Me.txtBranch.TabIndex = 20
        '
        'txtWarrStatus
        '
        Me.txtWarrStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtWarrStatus.Enabled = False
        Me.txtWarrStatus.Location = New System.Drawing.Point(221, 13)
        Me.txtWarrStatus.Multiline = True
        Me.txtWarrStatus.Name = "txtWarrStatus"
        Me.txtWarrStatus.Size = New System.Drawing.Size(120, 18)
        Me.txtWarrStatus.TabIndex = 19
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(155, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(66, 13)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "Warr-Status:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(552, 17)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(44, 13)
        Me.Label27.TabIndex = 8
        Me.Label27.Text = "Branch:"
        '
        'txtProductStatus
        '
        Me.txtProductStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtProductStatus.Location = New System.Drawing.Point(421, 14)
        Me.txtProductStatus.Multiline = True
        Me.txtProductStatus.Name = "txtProductStatus"
        Me.txtProductStatus.Size = New System.Drawing.Size(129, 18)
        Me.txtProductStatus.TabIndex = 7
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(343, 17)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(80, 13)
        Me.Label26.TabIndex = 6
        Me.Label26.Text = "Product Status:"
        '
        'txtJobCode
        '
        Me.txtJobCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtJobCode.Enabled = False
        Me.txtJobCode.Location = New System.Drawing.Point(53, 14)
        Me.txtJobCode.Multiline = True
        Me.txtJobCode.Name = "txtJobCode"
        Me.txtJobCode.Size = New System.Drawing.Size(103, 18)
        Me.txtJobCode.TabIndex = 5
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(11, 17)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(44, 13)
        Me.Label25.TabIndex = 4
        Me.Label25.Text = "Job No:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 39)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(735, 92)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtEstimateRefuse)
        Me.GroupBox5.Controls.Add(Me.txtServiceDate)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.txtServiceby)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.txtReceivedBy)
        Me.GroupBox5.Controls.Add(Me.txtApproxDate)
        Me.GroupBox5.Controls.Add(Me.txtReceiptDate)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Location = New System.Drawing.Point(293, 9)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(437, 78)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Date Information"
        '
        'txtEstimateRefuse
        '
        Me.txtEstimateRefuse.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.txtEstimateRefuse.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEstimateRefuse.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstimateRefuse.Location = New System.Drawing.Point(266, 57)
        Me.txtEstimateRefuse.Multiline = True
        Me.txtEstimateRefuse.Name = "txtEstimateRefuse"
        Me.txtEstimateRefuse.Size = New System.Drawing.Size(165, 16)
        Me.txtEstimateRefuse.TabIndex = 17
        Me.txtEstimateRefuse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtServiceDate
        '
        Me.txtServiceDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtServiceDate.Enabled = False
        Me.txtServiceDate.Location = New System.Drawing.Point(266, 36)
        Me.txtServiceDate.Multiline = True
        Me.txtServiceDate.Name = "txtServiceDate"
        Me.txtServiceDate.Size = New System.Drawing.Size(165, 18)
        Me.txtServiceDate.TabIndex = 15
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(188, 39)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 13)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Service Date:"
        '
        'txtServiceby
        '
        Me.txtServiceby.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtServiceby.Enabled = False
        Me.txtServiceby.Location = New System.Drawing.Point(251, 15)
        Me.txtServiceby.Multiline = True
        Me.txtServiceby.Name = "txtServiceby"
        Me.txtServiceby.Size = New System.Drawing.Size(180, 18)
        Me.txtServiceby.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(188, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Service By:"
        '
        'txtReceivedBy
        '
        Me.txtReceivedBy.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtReceivedBy.Enabled = False
        Me.txtReceivedBy.Location = New System.Drawing.Point(89, 56)
        Me.txtReceivedBy.Multiline = True
        Me.txtReceivedBy.Name = "txtReceivedBy"
        Me.txtReceivedBy.Size = New System.Drawing.Size(154, 18)
        Me.txtReceivedBy.TabIndex = 11
        '
        'txtApproxDate
        '
        Me.txtApproxDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtApproxDate.Enabled = False
        Me.txtApproxDate.Location = New System.Drawing.Point(89, 36)
        Me.txtApproxDate.Multiline = True
        Me.txtApproxDate.Name = "txtApproxDate"
        Me.txtApproxDate.Size = New System.Drawing.Size(95, 18)
        Me.txtApproxDate.TabIndex = 10
        '
        'txtReceiptDate
        '
        Me.txtReceiptDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtReceiptDate.Enabled = False
        Me.txtReceiptDate.Location = New System.Drawing.Point(89, 16)
        Me.txtReceiptDate.Multiline = True
        Me.txtReceiptDate.Name = "txtReceiptDate"
        Me.txtReceiptDate.Size = New System.Drawing.Size(95, 18)
        Me.txtReceiptDate.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Received by:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Del. Dt(Approx):"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Recept Date:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtAddress2)
        Me.GroupBox4.Controls.Add(Me.txtAddress1)
        Me.GroupBox4.Controls.Add(Me.txtName)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Location = New System.Drawing.Point(7, 9)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(284, 78)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Customer Information"
        '
        'txtAddress2
        '
        Me.txtAddress2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtAddress2.Enabled = False
        Me.txtAddress2.Location = New System.Drawing.Point(60, 56)
        Me.txtAddress2.Multiline = True
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.Size = New System.Drawing.Size(218, 18)
        Me.txtAddress2.TabIndex = 5
        '
        'txtAddress1
        '
        Me.txtAddress1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtAddress1.Enabled = False
        Me.txtAddress1.Location = New System.Drawing.Point(60, 36)
        Me.txtAddress1.Multiline = True
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.Size = New System.Drawing.Size(218, 18)
        Me.txtAddress1.TabIndex = 4
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtName.Enabled = False
        Me.txtName.Location = New System.Drawing.Point(60, 16)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(218, 18)
        Me.txtName.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Address2:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Address1:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtESN)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txtSerial)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txtModel)
        Me.GroupBox3.Controls.Add(Me.txtBrand)
        Me.GroupBox3.Controls.Add(Me.txtCategory)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Location = New System.Drawing.Point(5, 132)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(306, 127)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Set Details"
        '
        'txtESN
        '
        Me.txtESN.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtESN.Enabled = False
        Me.txtESN.Location = New System.Drawing.Point(67, 101)
        Me.txtESN.Multiline = True
        Me.txtESN.Name = "txtESN"
        Me.txtESN.Size = New System.Drawing.Size(231, 19)
        Me.txtESN.TabIndex = 15
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(18, 105)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Esn No:"
        '
        'txtSerial
        '
        Me.txtSerial.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtSerial.Enabled = False
        Me.txtSerial.Location = New System.Drawing.Point(67, 79)
        Me.txtSerial.Multiline = True
        Me.txtSerial.Name = "txtSerial"
        Me.txtSerial.Size = New System.Drawing.Size(231, 19)
        Me.txtSerial.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 83)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Serial No:"
        '
        'txtModel
        '
        Me.txtModel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtModel.Enabled = False
        Me.txtModel.Location = New System.Drawing.Point(67, 57)
        Me.txtModel.Multiline = True
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(231, 19)
        Me.txtModel.TabIndex = 11
        '
        'txtBrand
        '
        Me.txtBrand.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtBrand.Enabled = False
        Me.txtBrand.Location = New System.Drawing.Point(67, 35)
        Me.txtBrand.Multiline = True
        Me.txtBrand.Name = "txtBrand"
        Me.txtBrand.Size = New System.Drawing.Size(231, 19)
        Me.txtBrand.TabIndex = 10
        '
        'txtCategory
        '
        Me.txtCategory.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtCategory.Enabled = False
        Me.txtCategory.Location = New System.Drawing.Point(67, 13)
        Me.txtCategory.Multiline = True
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(231, 19)
        Me.txtCategory.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Model:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(25, 39)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Brand:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Category:"
        '
        'tbJobStatus
        '
        Me.tbJobStatus.Controls.Add(Me.tbItem)
        Me.tbJobStatus.Controls.Add(Me.tbWarranty)
        Me.tbJobStatus.Controls.Add(Me.tbFailurDescription)
        Me.tbJobStatus.Location = New System.Drawing.Point(319, 139)
        Me.tbJobStatus.Name = "tbJobStatus"
        Me.tbJobStatus.SelectedIndex = 0
        Me.tbJobStatus.Size = New System.Drawing.Size(422, 120)
        Me.tbJobStatus.TabIndex = 3
        '
        'tbItem
        '
        Me.tbItem.Controls.Add(Me.lstTBItem)
        Me.tbItem.Location = New System.Drawing.Point(4, 22)
        Me.tbItem.Name = "tbItem"
        Me.tbItem.Padding = New System.Windows.Forms.Padding(3)
        Me.tbItem.Size = New System.Drawing.Size(414, 94)
        Me.tbItem.TabIndex = 0
        Me.tbItem.Text = "Item"
        Me.tbItem.UseVisualStyleBackColor = True
        '
        'lstTBItem
        '
        Me.lstTBItem.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colTBItemSL, Me.colTBListofItem})
        Me.lstTBItem.Location = New System.Drawing.Point(4, 4)
        Me.lstTBItem.Name = "lstTBItem"
        Me.lstTBItem.Size = New System.Drawing.Size(408, 86)
        Me.lstTBItem.TabIndex = 0
        Me.lstTBItem.UseCompatibleStateImageBehavior = False
        Me.lstTBItem.View = System.Windows.Forms.View.Details
        '
        'colTBItemSL
        '
        Me.colTBItemSL.Text = "SL"
        '
        'colTBListofItem
        '
        Me.colTBListofItem.Text = "List of Item"
        Me.colTBListofItem.Width = 250
        '
        'tbWarranty
        '
        Me.tbWarranty.Controls.Add(Me.txtTBPreviousJobno)
        Me.tbWarranty.Controls.Add(Me.Label18)
        Me.tbWarranty.Controls.Add(Me.txtTBPurchaseDate)
        Me.tbWarranty.Controls.Add(Me.Label17)
        Me.tbWarranty.Controls.Add(Me.optTBServiceWarranty)
        Me.tbWarranty.Controls.Add(Me.optTBNonWarranty)
        Me.tbWarranty.Controls.Add(Me.optTBSalesWarranty)
        Me.tbWarranty.Location = New System.Drawing.Point(4, 22)
        Me.tbWarranty.Name = "tbWarranty"
        Me.tbWarranty.Padding = New System.Windows.Forms.Padding(3)
        Me.tbWarranty.Size = New System.Drawing.Size(414, 94)
        Me.tbWarranty.TabIndex = 1
        Me.tbWarranty.Text = "Warranty"
        Me.tbWarranty.UseVisualStyleBackColor = True
        '
        'txtTBPreviousJobno
        '
        Me.txtTBPreviousJobno.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtTBPreviousJobno.Enabled = False
        Me.txtTBPreviousJobno.Location = New System.Drawing.Point(287, 61)
        Me.txtTBPreviousJobno.Multiline = True
        Me.txtTBPreviousJobno.Name = "txtTBPreviousJobno"
        Me.txtTBPreviousJobno.Size = New System.Drawing.Size(116, 21)
        Me.txtTBPreviousJobno.TabIndex = 13
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(186, 65)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(88, 13)
        Me.Label18.TabIndex = 12
        Me.Label18.Text = "Previous Job No:"
        '
        'txtTBPurchaseDate
        '
        Me.txtTBPurchaseDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtTBPurchaseDate.Enabled = False
        Me.txtTBPurchaseDate.Location = New System.Drawing.Point(287, 8)
        Me.txtTBPurchaseDate.Multiline = True
        Me.txtTBPurchaseDate.Name = "txtTBPurchaseDate"
        Me.txtTBPurchaseDate.Size = New System.Drawing.Size(116, 21)
        Me.txtTBPurchaseDate.TabIndex = 11
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(193, 12)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(81, 13)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "Purchase Date:"
        '
        'optTBServiceWarranty
        '
        Me.optTBServiceWarranty.AutoSize = True
        Me.optTBServiceWarranty.Location = New System.Drawing.Point(16, 63)
        Me.optTBServiceWarranty.Name = "optTBServiceWarranty"
        Me.optTBServiceWarranty.Size = New System.Drawing.Size(107, 17)
        Me.optTBServiceWarranty.TabIndex = 2
        Me.optTBServiceWarranty.TabStop = True
        Me.optTBServiceWarranty.Text = "S&ervice Warranty"
        Me.optTBServiceWarranty.UseVisualStyleBackColor = True
        '
        'optTBNonWarranty
        '
        Me.optTBNonWarranty.AutoSize = True
        Me.optTBNonWarranty.Location = New System.Drawing.Point(16, 37)
        Me.optTBNonWarranty.Name = "optTBNonWarranty"
        Me.optTBNonWarranty.Size = New System.Drawing.Size(91, 17)
        Me.optTBNonWarranty.TabIndex = 1
        Me.optTBNonWarranty.TabStop = True
        Me.optTBNonWarranty.Text = "&Non Warranty"
        Me.optTBNonWarranty.UseVisualStyleBackColor = True
        '
        'optTBSalesWarranty
        '
        Me.optTBSalesWarranty.AutoSize = True
        Me.optTBSalesWarranty.Location = New System.Drawing.Point(16, 10)
        Me.optTBSalesWarranty.Name = "optTBSalesWarranty"
        Me.optTBSalesWarranty.Size = New System.Drawing.Size(97, 17)
        Me.optTBSalesWarranty.TabIndex = 0
        Me.optTBSalesWarranty.TabStop = True
        Me.optTBSalesWarranty.Text = "&Sales Warranty"
        Me.optTBSalesWarranty.UseVisualStyleBackColor = True
        '
        'tbFailurDescription
        '
        Me.tbFailurDescription.Controls.Add(Me.lstTBFaultList)
        Me.tbFailurDescription.Location = New System.Drawing.Point(4, 22)
        Me.tbFailurDescription.Name = "tbFailurDescription"
        Me.tbFailurDescription.Padding = New System.Windows.Forms.Padding(3)
        Me.tbFailurDescription.Size = New System.Drawing.Size(414, 94)
        Me.tbFailurDescription.TabIndex = 2
        Me.tbFailurDescription.Text = "Failur Description"
        Me.tbFailurDescription.UseVisualStyleBackColor = True
        '
        'lstTBFaultList
        '
        Me.lstTBFaultList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColTBFaultSL, Me.colTBFaultList})
        Me.lstTBFaultList.Location = New System.Drawing.Point(5, 5)
        Me.lstTBFaultList.Name = "lstTBFaultList"
        Me.lstTBFaultList.Size = New System.Drawing.Size(405, 84)
        Me.lstTBFaultList.TabIndex = 0
        Me.lstTBFaultList.UseCompatibleStateImageBehavior = False
        Me.lstTBFaultList.View = System.Windows.Forms.View.Details
        '
        'ColTBFaultSL
        '
        Me.ColTBFaultSL.Text = "SL"
        '
        'colTBFaultList
        '
        Me.colTBFaultList.Text = "List of Failure"
        Me.colTBFaultList.Width = 250
        '
        'lstPartsList
        '
        Me.lstPartsList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colDelSLNo, Me.colDelCode, Me.colDelDescription, Me.colDelUnit, Me.colDelQty, Me.colDelUnitPrice, Me.colDelTotal})
        Me.lstPartsList.Location = New System.Drawing.Point(5, 261)
        Me.lstPartsList.Name = "lstPartsList"
        Me.lstPartsList.Size = New System.Drawing.Size(461, 145)
        Me.lstPartsList.TabIndex = 35
        Me.lstPartsList.UseCompatibleStateImageBehavior = False
        Me.lstPartsList.View = System.Windows.Forms.View.Details
        '
        'colDelSLNo
        '
        Me.colDelSLNo.Text = "SL."
        Me.colDelSLNo.Width = 30
        '
        'colDelCode
        '
        Me.colDelCode.Text = "Code"
        Me.colDelCode.Width = 90
        '
        'colDelDescription
        '
        Me.colDelDescription.Text = "Description"
        Me.colDelDescription.Width = 122
        '
        'colDelUnit
        '
        Me.colDelUnit.Text = "Unit"
        Me.colDelUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colDelUnit.Width = 50
        '
        'colDelQty
        '
        Me.colDelQty.Text = "Qty"
        Me.colDelQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colDelQty.Width = 40
        '
        'colDelUnitPrice
        '
        Me.colDelUnitPrice.Text = "Unit Price"
        '
        'colDelTotal
        '
        Me.colDelTotal.Text = "Total"
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(83, 407)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(383, 18)
        Me.txtRemarks.TabIndex = 17
        '
        'txtMR
        '
        Me.txtMR.Location = New System.Drawing.Point(62, 431)
        Me.txtMR.Multiline = True
        Me.txtMR.Name = "txtMR"
        Me.txtMR.Size = New System.Drawing.Size(80, 18)
        Me.txtMR.TabIndex = 37
        '
        'chkVatAmount
        '
        Me.chkVatAmount.AutoSize = True
        Me.chkVatAmount.Location = New System.Drawing.Point(5, 433)
        Me.chkVatAmount.Name = "chkVatAmount"
        Me.chkVatAmount.Size = New System.Drawing.Size(53, 17)
        Me.chkVatAmount.TabIndex = 38
        Me.chkVatAmount.Text = "MR#:"
        Me.chkVatAmount.UseVisualStyleBackColor = True
        '
        'chkFreeofcost
        '
        Me.chkFreeofcost.AutoSize = True
        Me.chkFreeofcost.Location = New System.Drawing.Point(7, 454)
        Me.chkFreeofcost.Name = "chkFreeofcost"
        Me.chkFreeofcost.Size = New System.Drawing.Size(162, 17)
        Me.chkFreeofcost.TabIndex = 39
        Me.chkFreeofcost.Text = "Free of Cost / Complimentary"
        Me.chkFreeofcost.UseVisualStyleBackColor = True
        '
        'cmdBill
        '
        Me.cmdBill.Location = New System.Drawing.Point(144, 429)
        Me.cmdBill.Name = "cmdBill"
        Me.cmdBill.Size = New System.Drawing.Size(65, 23)
        Me.cmdBill.TabIndex = 42
        Me.cmdBill.Text = "&Bill"
        Me.cmdBill.UseVisualStyleBackColor = True
        '
        'cmdPreview
        '
        Me.cmdPreview.Location = New System.Drawing.Point(207, 429)
        Me.cmdPreview.Name = "cmdPreview"
        Me.cmdPreview.Size = New System.Drawing.Size(65, 23)
        Me.cmdPreview.TabIndex = 43
        Me.cmdPreview.Text = "&Preview"
        Me.cmdPreview.UseVisualStyleBackColor = True
        '
        'cmdCR
        '
        Me.cmdCR.Enabled = False
        Me.cmdCR.Location = New System.Drawing.Point(270, 429)
        Me.cmdCR.Name = "cmdCR"
        Me.cmdCR.Size = New System.Drawing.Size(65, 23)
        Me.cmdCR.TabIndex = 44
        Me.cmdCR.Text = "&CR"
        Me.cmdCR.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(333, 429)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(65, 23)
        Me.cmdClose.TabIndex = 45
        Me.cmdClose.Text = "C&lose"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdPrint
        '
        Me.cmdPrint.Location = New System.Drawing.Point(396, 429)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(65, 23)
        Me.cmdPrint.TabIndex = 46
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.UseVisualStyleBackColor = True
        '
        'grpBillDescription
        '
        Me.grpBillDescription.Controls.Add(Me.chkParts)
        Me.grpBillDescription.Controls.Add(Me.txtOtherCharge)
        Me.grpBillDescription.Controls.Add(Me.lblVatAmount)
        Me.grpBillDescription.Controls.Add(Me.chkSpareAmount)
        Me.grpBillDescription.Controls.Add(Me.lblTotalAmount)
        Me.grpBillDescription.Controls.Add(Me.lblTotalSpareCost)
        Me.grpBillDescription.Controls.Add(Me.lblNetPayable)
        Me.grpBillDescription.Controls.Add(Me.txtAdvanceAmount)
        Me.grpBillDescription.Controls.Add(Me.lblAdvanceamount)
        Me.grpBillDescription.Controls.Add(Me.txtDiscount)
        Me.grpBillDescription.Controls.Add(Me.lblDiscount)
        Me.grpBillDescription.Controls.Add(Me.lblOtherCharge)
        Me.grpBillDescription.Controls.Add(Me.lblVat)
        Me.grpBillDescription.Controls.Add(Me.txtRepairCharge)
        Me.grpBillDescription.Controls.Add(Me.lblRepairCharge)
        Me.grpBillDescription.Controls.Add(Me.txtFaultFindingCharge)
        Me.grpBillDescription.Controls.Add(Me.lblFaultFindingCharge)
        Me.grpBillDescription.Controls.Add(Me.lblTotalcostofspare)
        Me.grpBillDescription.Controls.Add(Me.lblDeliveryby)
        Me.grpBillDescription.Controls.Add(Me.lblEmployeeName)
        Me.grpBillDescription.Controls.Add(Me.cmbEmployeeCode)
        Me.grpBillDescription.Controls.Add(Me.lblDeliveryDate)
        Me.grpBillDescription.Controls.Add(Me.dtpDelivery)
        Me.grpBillDescription.Location = New System.Drawing.Point(469, 261)
        Me.grpBillDescription.Name = "grpBillDescription"
        Me.grpBillDescription.Size = New System.Drawing.Size(275, 218)
        Me.grpBillDescription.TabIndex = 47
        Me.grpBillDescription.TabStop = False
        Me.grpBillDescription.Text = "Bill Description"
        '
        'chkParts
        '
        Me.chkParts.AutoSize = True
        Me.chkParts.Location = New System.Drawing.Point(256, 60)
        Me.chkParts.Name = "chkParts"
        Me.chkParts.Size = New System.Drawing.Size(15, 14)
        Me.chkParts.TabIndex = 49
        Me.ToolTip1.SetToolTip(Me.chkParts, "Enable Vat")
        Me.chkParts.UseVisualStyleBackColor = True
        '
        'txtOtherCharge
        '
        Me.txtOtherCharge.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtherCharge.Location = New System.Drawing.Point(132, 133)
        Me.txtOtherCharge.Name = "txtOtherCharge"
        Me.txtOtherCharge.Size = New System.Drawing.Size(120, 20)
        Me.txtOtherCharge.TabIndex = 86
        Me.txtOtherCharge.Text = "0"
        Me.txtOtherCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblVatAmount
        '
        Me.lblVatAmount.BackColor = System.Drawing.Color.Green
        Me.lblVatAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblVatAmount.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVatAmount.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblVatAmount.Location = New System.Drawing.Point(132, 116)
        Me.lblVatAmount.Name = "lblVatAmount"
        Me.lblVatAmount.Size = New System.Drawing.Size(120, 18)
        Me.lblVatAmount.TabIndex = 85
        Me.lblVatAmount.Text = "0"
        Me.lblVatAmount.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'chkSpareAmount
        '
        Me.chkSpareAmount.AutoSize = True
        Me.chkSpareAmount.Location = New System.Drawing.Point(115, 59)
        Me.chkSpareAmount.Name = "chkSpareAmount"
        Me.chkSpareAmount.Size = New System.Drawing.Size(15, 14)
        Me.chkSpareAmount.TabIndex = 84
        Me.chkSpareAmount.UseVisualStyleBackColor = True
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalAmount.Font = New System.Drawing.Font("Times New Roman", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblTotalAmount.Location = New System.Drawing.Point(132, 193)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(120, 20)
        Me.lblTotalAmount.TabIndex = 83
        Me.lblTotalAmount.Text = "0"
        Me.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalSpareCost
        '
        Me.lblTotalSpareCost.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblTotalSpareCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalSpareCost.Font = New System.Drawing.Font("Times New Roman", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSpareCost.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTotalSpareCost.Location = New System.Drawing.Point(132, 57)
        Me.lblTotalSpareCost.Name = "lblTotalSpareCost"
        Me.lblTotalSpareCost.Size = New System.Drawing.Size(120, 18)
        Me.lblTotalSpareCost.TabIndex = 82
        Me.lblTotalSpareCost.Text = "0"
        Me.lblTotalSpareCost.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblNetPayable
        '
        Me.lblNetPayable.AutoSize = True
        Me.lblNetPayable.Location = New System.Drawing.Point(61, 197)
        Me.lblNetPayable.Name = "lblNetPayable"
        Me.lblNetPayable.Size = New System.Drawing.Size(68, 13)
        Me.lblNetPayable.TabIndex = 81
        Me.lblNetPayable.Text = "Net Payable:"
        '
        'txtAdvanceAmount
        '
        Me.txtAdvanceAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtAdvanceAmount.Enabled = False
        Me.txtAdvanceAmount.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdvanceAmount.Location = New System.Drawing.Point(132, 172)
        Me.txtAdvanceAmount.Name = "txtAdvanceAmount"
        Me.txtAdvanceAmount.Size = New System.Drawing.Size(120, 20)
        Me.txtAdvanceAmount.TabIndex = 80
        Me.txtAdvanceAmount.Text = "0"
        Me.txtAdvanceAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblAdvanceamount
        '
        Me.lblAdvanceamount.AutoSize = True
        Me.lblAdvanceamount.Location = New System.Drawing.Point(29, 175)
        Me.lblAdvanceamount.Name = "lblAdvanceamount"
        Me.lblAdvanceamount.Size = New System.Drawing.Size(100, 13)
        Me.lblAdvanceamount.TabIndex = 79
        Me.lblAdvanceamount.Text = "Advance Receved:"
        '
        'txtDiscount
        '
        Me.txtDiscount.AutoCompleteCustomSource.AddRange(New String() {"0"})
        Me.txtDiscount.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscount.Location = New System.Drawing.Point(132, 153)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(120, 20)
        Me.txtDiscount.TabIndex = 78
        Me.txtDiscount.Text = "0"
        Me.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Location = New System.Drawing.Point(77, 156)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(52, 13)
        Me.lblDiscount.TabIndex = 77
        Me.lblDiscount.Text = "Discount:"
        '
        'lblOtherCharge
        '
        Me.lblOtherCharge.AutoSize = True
        Me.lblOtherCharge.Location = New System.Drawing.Point(52, 136)
        Me.lblOtherCharge.Name = "lblOtherCharge"
        Me.lblOtherCharge.Size = New System.Drawing.Size(77, 13)
        Me.lblOtherCharge.TabIndex = 75
        Me.lblOtherCharge.Text = "Other charges:"
        '
        'lblVat
        '
        Me.lblVat.AutoSize = True
        Me.lblVat.Location = New System.Drawing.Point(98, 117)
        Me.lblVat.Name = "lblVat"
        Me.lblVat.Size = New System.Drawing.Size(31, 13)
        Me.lblVat.TabIndex = 73
        Me.lblVat.Text = "VAT:"
        '
        'txtRepairCharge
        '
        Me.txtRepairCharge.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRepairCharge.Location = New System.Drawing.Point(132, 95)
        Me.txtRepairCharge.Name = "txtRepairCharge"
        Me.txtRepairCharge.Size = New System.Drawing.Size(120, 20)
        Me.txtRepairCharge.TabIndex = 72
        Me.txtRepairCharge.Text = "0"
        Me.txtRepairCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblRepairCharge
        '
        Me.lblRepairCharge.AutoSize = True
        Me.lblRepairCharge.Location = New System.Drawing.Point(47, 98)
        Me.lblRepairCharge.Name = "lblRepairCharge"
        Me.lblRepairCharge.Size = New System.Drawing.Size(82, 13)
        Me.lblRepairCharge.TabIndex = 71
        Me.lblRepairCharge.Text = "Repair charges:"
        '
        'txtFaultFindingCharge
        '
        Me.txtFaultFindingCharge.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFaultFindingCharge.Location = New System.Drawing.Point(132, 76)
        Me.txtFaultFindingCharge.Name = "txtFaultFindingCharge"
        Me.txtFaultFindingCharge.Size = New System.Drawing.Size(120, 20)
        Me.txtFaultFindingCharge.TabIndex = 70
        Me.txtFaultFindingCharge.Text = "0"
        Me.txtFaultFindingCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblFaultFindingCharge
        '
        Me.lblFaultFindingCharge.AutoSize = True
        Me.lblFaultFindingCharge.Location = New System.Drawing.Point(26, 79)
        Me.lblFaultFindingCharge.Name = "lblFaultFindingCharge"
        Me.lblFaultFindingCharge.Size = New System.Drawing.Size(103, 13)
        Me.lblFaultFindingCharge.TabIndex = 69
        Me.lblFaultFindingCharge.Text = "Fault finding charge:"
        '
        'lblTotalcostofspare
        '
        Me.lblTotalcostofspare.AutoSize = True
        Me.lblTotalcostofspare.Location = New System.Drawing.Point(10, 60)
        Me.lblTotalcostofspare.Name = "lblTotalcostofspare"
        Me.lblTotalcostofspare.Size = New System.Drawing.Size(103, 13)
        Me.lblTotalcostofspare.TabIndex = 64
        Me.lblTotalcostofspare.Text = "Total cost of spares:"
        Me.lblTotalcostofspare.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDeliveryby
        '
        Me.lblDeliveryby.AutoSize = True
        Me.lblDeliveryby.Location = New System.Drawing.Point(9, 38)
        Me.lblDeliveryby.Name = "lblDeliveryby"
        Me.lblDeliveryby.Size = New System.Drawing.Size(69, 13)
        Me.lblDeliveryby.TabIndex = 68
        Me.lblDeliveryby.Text = "Delivered by:"
        '
        'lblEmployeeName
        '
        Me.lblEmployeeName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployeeName.Location = New System.Drawing.Point(132, 35)
        Me.lblEmployeeName.Name = "lblEmployeeName"
        Me.lblEmployeeName.Size = New System.Drawing.Size(120, 18)
        Me.lblEmployeeName.TabIndex = 67
        '
        'cmbEmployeeCode
        '
        Me.cmbEmployeeCode.DropDownHeight = 50
        Me.cmbEmployeeCode.FormattingEnabled = True
        Me.cmbEmployeeCode.IntegralHeight = False
        Me.cmbEmployeeCode.Location = New System.Drawing.Point(86, 34)
        Me.cmbEmployeeCode.Name = "cmbEmployeeCode"
        Me.cmbEmployeeCode.Size = New System.Drawing.Size(44, 21)
        Me.cmbEmployeeCode.TabIndex = 66
        '
        'lblDeliveryDate
        '
        Me.lblDeliveryDate.AutoSize = True
        Me.lblDeliveryDate.Location = New System.Drawing.Point(9, 16)
        Me.lblDeliveryDate.Name = "lblDeliveryDate"
        Me.lblDeliveryDate.Size = New System.Drawing.Size(81, 13)
        Me.lblDeliveryDate.TabIndex = 65
        Me.lblDeliveryDate.Text = "Delivered Date:"
        '
        'dtpDelivery
        '
        Me.dtpDelivery.CustomFormat = "DD-MMM-YY"
        Me.dtpDelivery.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDelivery.Location = New System.Drawing.Point(100, 12)
        Me.dtpDelivery.Name = "dtpDelivery"
        Me.dtpDelivery.Size = New System.Drawing.Size(149, 20)
        Me.dtpDelivery.TabIndex = 63
        '
        'chkRemarkEnabled
        '
        Me.chkRemarkEnabled.AutoSize = True
        Me.chkRemarkEnabled.Location = New System.Drawing.Point(7, 410)
        Me.chkRemarkEnabled.Name = "chkRemarkEnabled"
        Me.chkRemarkEnabled.Size = New System.Drawing.Size(71, 17)
        Me.chkRemarkEnabled.TabIndex = 48
        Me.chkRemarkEnabled.Text = "Remarks:"
        Me.chkRemarkEnabled.UseVisualStyleBackColor = True
        '
        'frmOnpayment_Bill_Format
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(754, 482)
        Me.Controls.Add(Me.chkRemarkEnabled)
        Me.Controls.Add(Me.grpBillDescription)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdCR)
        Me.Controls.Add(Me.cmdPreview)
        Me.Controls.Add(Me.cmdBill)
        Me.Controls.Add(Me.chkFreeofcost)
        Me.Controls.Add(Me.chkVatAmount)
        Me.Controls.Add(Me.txtMR)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.lstPartsList)
        Me.Controls.Add(Me.tbJobStatus)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOnpayment_Bill_Format"
        Me.Text = "Invoice Slip"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.tbJobStatus.ResumeLayout(False)
        Me.tbItem.ResumeLayout(False)
        Me.tbWarranty.ResumeLayout(False)
        Me.tbWarranty.PerformLayout()
        Me.tbFailurDescription.ResumeLayout(False)
        Me.grpBillDescription.ResumeLayout(False)
        Me.grpBillDescription.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents tbJobStatus As TabControl
    Friend WithEvents tbItem As TabPage
    Friend WithEvents tbWarranty As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtReceivedBy As TextBox
    Friend WithEvents txtApproxDate As TextBox
    Friend WithEvents txtReceiptDate As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAddress2 As TextBox
    Friend WithEvents txtAddress1 As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtServiceby As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbFailurDescription As TabPage
    Friend WithEvents txtESN As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtSerial As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtModel As TextBox
    Friend WithEvents txtBrand As TextBox
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtServiceDate As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents lstPartsList As ListView
    Friend WithEvents colDelSLNo As ColumnHeader
    Friend WithEvents colDelCode As ColumnHeader
    Friend WithEvents colDelDescription As ColumnHeader
    Friend WithEvents colDelUnit As ColumnHeader
    Friend WithEvents colDelQty As ColumnHeader
    Friend WithEvents colDelUnitPrice As ColumnHeader
    Friend WithEvents colDelTotal As ColumnHeader
    Friend WithEvents Label27 As Label
    Friend WithEvents txtProductStatus As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents txtJobCode As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents txtMR As TextBox
    Friend WithEvents chkVatAmount As CheckBox
    Friend WithEvents chkFreeofcost As CheckBox
    Friend WithEvents cmdBill As Button
    Friend WithEvents cmdPreview As Button
    Friend WithEvents cmdCR As Button
    Friend WithEvents cmdClose As Button
    Friend WithEvents cmdPrint As Button
    Friend WithEvents grpBillDescription As GroupBox
    Friend WithEvents chkSpareAmount As CheckBox
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents lblTotalSpareCost As Label
    Friend WithEvents lblNetPayable As Label
    Friend WithEvents txtAdvanceAmount As TextBox
    Friend WithEvents lblAdvanceamount As Label
    Friend WithEvents txtDiscount As TextBox
    Friend WithEvents lblDiscount As Label
    Friend WithEvents lblOtherCharge As Label
    Friend WithEvents lblVat As Label
    Friend WithEvents txtRepairCharge As TextBox
    Friend WithEvents lblRepairCharge As Label
    Friend WithEvents txtFaultFindingCharge As TextBox
    Friend WithEvents lblFaultFindingCharge As Label
    Friend WithEvents lblTotalcostofspare As Label
    Friend WithEvents lblDeliveryby As Label
    Friend WithEvents lblEmployeeName As Label
    Friend WithEvents cmbEmployeeCode As ComboBox
    Friend WithEvents lblDeliveryDate As Label
    Friend WithEvents dtpDelivery As DateTimePicker
    Friend WithEvents lstTBItem As ListView
    Friend WithEvents txtTBPreviousJobno As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtTBPurchaseDate As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents optTBServiceWarranty As RadioButton
    Friend WithEvents optTBNonWarranty As RadioButton
    Friend WithEvents optTBSalesWarranty As RadioButton
    Friend WithEvents colTBItemSL As ColumnHeader
    Friend WithEvents colTBListofItem As ColumnHeader
    Friend WithEvents lstTBFaultList As ListView
    Friend WithEvents ColTBFaultSL As ColumnHeader
    Friend WithEvents colTBFaultList As ColumnHeader
    Friend WithEvents txtWarrStatus As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtEstimateRefuse As TextBox
    Friend WithEvents txtBranch As TextBox
    Friend WithEvents lblVatAmount As Label
    Friend WithEvents txtOtherCharge As TextBox
    Friend WithEvents chkRemarkEnabled As CheckBox
    Friend WithEvents chkParts As CheckBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
