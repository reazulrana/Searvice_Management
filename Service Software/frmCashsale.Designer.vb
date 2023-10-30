<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCashsale
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
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.grpProductInformation = New System.Windows.Forms.GroupBox()
        Me.dgvMRNO = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.dgvPartsInformation = New System.Windows.Forms.DataGridView()
        Me.lstProductList = New System.Windows.Forms.ListView()
        Me.colsl = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPartNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDescription = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCategory = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colBrand = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colUnitPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colQty = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTotal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSerial = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colESN = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmdRefresh = New System.Windows.Forms.Button()
        Me.lblTotalAmont = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtUnitPrice = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtESNNO = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSerial = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbModel = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbBrand = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPartNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.grpCustomerInformation = New System.Windows.Forms.GroupBox()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbSellBy = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbBranch = New System.Windows.Forms.ComboBox()
        Me.txtJobCode = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpSellDate = New System.Windows.Forms.DateTimePicker()
        Me.lblSellBy = New System.Windows.Forms.Label()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.txtMRNO = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtTotalAmount = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmdDeleteMR = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.grpProductInformation.SuspendLayout()
        CType(Me.dgvMRNO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPartsInformation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCustomerInformation.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdClose
        '
        Me.cmdClose.CausesValidation = False
        Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdClose.Location = New System.Drawing.Point(689, 436)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(58, 23)
        Me.cmdClose.TabIndex = 10
        Me.cmdClose.Text = "C&lose"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'grpProductInformation
        '
        Me.grpProductInformation.Controls.Add(Me.dgvMRNO)
        Me.grpProductInformation.Controls.Add(Me.Button1)
        Me.grpProductInformation.Controls.Add(Me.cmdDelete)
        Me.grpProductInformation.Controls.Add(Me.dgvPartsInformation)
        Me.grpProductInformation.Controls.Add(Me.lstProductList)
        Me.grpProductInformation.Controls.Add(Me.cmdRefresh)
        Me.grpProductInformation.Controls.Add(Me.lblTotalAmont)
        Me.grpProductInformation.Controls.Add(Me.Label22)
        Me.grpProductInformation.Controls.Add(Me.txtUnitPrice)
        Me.grpProductInformation.Controls.Add(Me.Label19)
        Me.grpProductInformation.Controls.Add(Me.txtQty)
        Me.grpProductInformation.Controls.Add(Me.Label18)
        Me.grpProductInformation.Controls.Add(Me.txtESNNO)
        Me.grpProductInformation.Controls.Add(Me.Label7)
        Me.grpProductInformation.Controls.Add(Me.txtSerial)
        Me.grpProductInformation.Controls.Add(Me.Label6)
        Me.grpProductInformation.Controls.Add(Me.Label5)
        Me.grpProductInformation.Controls.Add(Me.cmbModel)
        Me.grpProductInformation.Controls.Add(Me.Label4)
        Me.grpProductInformation.Controls.Add(Me.cmbBrand)
        Me.grpProductInformation.Controls.Add(Me.Label3)
        Me.grpProductInformation.Controls.Add(Me.cmbCategory)
        Me.grpProductInformation.Controls.Add(Me.txtDescription)
        Me.grpProductInformation.Controls.Add(Me.Label2)
        Me.grpProductInformation.Controls.Add(Me.txtPartNo)
        Me.grpProductInformation.Controls.Add(Me.Label1)
        Me.grpProductInformation.Controls.Add(Me.cmdAdd)
        Me.grpProductInformation.Location = New System.Drawing.Point(5, 99)
        Me.grpProductInformation.Name = "grpProductInformation"
        Me.grpProductInformation.Size = New System.Drawing.Size(747, 332)
        Me.grpProductInformation.TabIndex = 10
        Me.grpProductInformation.TabStop = False
        Me.grpProductInformation.Text = "Product Information"
        '
        'dgvMRNO
        '
        Me.dgvMRNO.AllowUserToAddRows = False
        Me.dgvMRNO.AllowUserToDeleteRows = False
        Me.dgvMRNO.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvMRNO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMRNO.Location = New System.Drawing.Point(60, 164)
        Me.dgvMRNO.Name = "dgvMRNO"
        Me.dgvMRNO.ReadOnly = True
        Me.dgvMRNO.Size = New System.Drawing.Size(149, 161)
        Me.dgvMRNO.TabIndex = 56
        Me.dgvMRNO.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(637, 45)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 28)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "&Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(531, 45)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(104, 28)
        Me.cmdDelete.TabIndex = 8
        Me.cmdDelete.Text = "&Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'dgvPartsInformation
        '
        Me.dgvPartsInformation.AllowUserToAddRows = False
        Me.dgvPartsInformation.AllowUserToDeleteRows = False
        Me.dgvPartsInformation.AllowUserToResizeColumns = False
        Me.dgvPartsInformation.AllowUserToResizeRows = False
        Me.dgvPartsInformation.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgvPartsInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPartsInformation.Location = New System.Drawing.Point(215, 154)
        Me.dgvPartsInformation.MultiSelect = False
        Me.dgvPartsInformation.Name = "dgvPartsInformation"
        Me.dgvPartsInformation.ReadOnly = True
        Me.dgvPartsInformation.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvPartsInformation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPartsInformation.Size = New System.Drawing.Size(438, 146)
        Me.dgvPartsInformation.TabIndex = 52
        Me.dgvPartsInformation.Visible = False
        '
        'lstProductList
        '
        Me.lstProductList.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lstProductList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colsl, Me.colPartNo, Me.colDescription, Me.colCategory, Me.colBrand, Me.ColModel, Me.colUnitPrice, Me.colQty, Me.colTotal, Me.colSerial, Me.colESN})
        Me.lstProductList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstProductList.FullRowSelect = True
        Me.lstProductList.Location = New System.Drawing.Point(0, 109)
        Me.lstProductList.Name = "lstProductList"
        Me.lstProductList.Size = New System.Drawing.Size(743, 216)
        Me.lstProductList.TabIndex = 53
        Me.lstProductList.UseCompatibleStateImageBehavior = False
        Me.lstProductList.View = System.Windows.Forms.View.Details
        '
        'colsl
        '
        Me.colsl.Text = "SL"
        Me.colsl.Width = 30
        '
        'colPartNo
        '
        Me.colPartNo.Text = "Part No"
        Me.colPartNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colPartNo.Width = 120
        '
        'colDescription
        '
        Me.colDescription.Text = "Description"
        Me.colDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colDescription.Width = 145
        '
        'colCategory
        '
        Me.colCategory.Text = "Category"
        Me.colCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colCategory.Width = 65
        '
        'colBrand
        '
        Me.colBrand.Text = "Brand"
        Me.colBrand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colBrand.Width = 65
        '
        'ColModel
        '
        Me.ColModel.Text = "Model"
        Me.ColModel.Width = 70
        '
        'colUnitPrice
        '
        Me.colUnitPrice.DisplayIndex = 8
        Me.colUnitPrice.Text = "Unit Price"
        Me.colUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colUnitPrice.Width = 55
        '
        'colQty
        '
        Me.colQty.DisplayIndex = 9
        Me.colQty.Text = "Qty"
        Me.colQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colQty.Width = 40
        '
        'colTotal
        '
        Me.colTotal.DisplayIndex = 10
        Me.colTotal.Text = "Total"
        Me.colTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colTotal.Width = 75
        '
        'colSerial
        '
        Me.colSerial.DisplayIndex = 6
        Me.colSerial.Text = "Serial"
        Me.colSerial.Width = 35
        '
        'colESN
        '
        Me.colESN.DisplayIndex = 7
        Me.colESN.Text = "ESNNo"
        Me.colESN.Width = 35
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Location = New System.Drawing.Point(637, 15)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(104, 28)
        Me.cmdRefresh.TabIndex = 9
        Me.cmdRefresh.Text = "&Refresh"
        Me.cmdRefresh.UseVisualStyleBackColor = True
        '
        'lblTotalAmont
        '
        Me.lblTotalAmont.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalAmont.Location = New System.Drawing.Point(644, 82)
        Me.lblTotalAmont.Name = "lblTotalAmont"
        Me.lblTotalAmont.Size = New System.Drawing.Size(93, 21)
        Me.lblTotalAmont.TabIndex = 50
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(566, 86)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(73, 13)
        Me.Label22.TabIndex = 49
        Me.Label22.Text = "Total Amount:"
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.Location = New System.Drawing.Point(343, 84)
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.Size = New System.Drawing.Size(75, 20)
        Me.txtUnitPrice.TabIndex = 15
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(272, 88)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(67, 13)
        Me.Label19.TabIndex = 41
        Me.Label19.Text = "** Unit Price:"
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(467, 83)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(59, 20)
        Me.txtQty.TabIndex = 16
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(424, 87)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(37, 13)
        Me.Label18.TabIndex = 39
        Me.Label18.Text = "** Qty:"
        '
        'txtESNNO
        '
        Me.txtESNNO.Location = New System.Drawing.Point(78, 80)
        Me.txtESNNO.Name = "txtESNNO"
        Me.txtESNNO.Size = New System.Drawing.Size(183, 20)
        Me.txtESNNO.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 84)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "ESN No:"
        '
        'txtSerial
        '
        Me.txtSerial.Location = New System.Drawing.Point(343, 58)
        Me.txtSerial.Name = "txtSerial"
        Me.txtSerial.Size = New System.Drawing.Size(183, 20)
        Me.txtSerial.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(303, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Serial:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(25, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "** Model:"
        '
        'cmbModel
        '
        Me.cmbModel.DropDownHeight = 60
        Me.cmbModel.FormattingEnabled = True
        Me.cmbModel.IntegralHeight = False
        Me.cmbModel.Location = New System.Drawing.Point(78, 58)
        Me.cmbModel.Name = "cmbModel"
        Me.cmbModel.Size = New System.Drawing.Size(183, 21)
        Me.cmbModel.Sorted = True
        Me.cmbModel.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(290, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "** Brand:"
        '
        'cmbBrand
        '
        Me.cmbBrand.DropDownHeight = 60
        Me.cmbBrand.FormattingEnabled = True
        Me.cmbBrand.IntegralHeight = False
        Me.cmbBrand.Location = New System.Drawing.Point(343, 36)
        Me.cmbBrand.Name = "cmbBrand"
        Me.cmbBrand.Size = New System.Drawing.Size(183, 21)
        Me.cmbBrand.Sorted = True
        Me.cmbBrand.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(12, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "** Category:"
        '
        'cmbCategory
        '
        Me.cmbCategory.DropDownHeight = 60
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.IntegralHeight = False
        Me.cmbCategory.Location = New System.Drawing.Point(78, 36)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(183, 21)
        Me.cmbCategory.Sorted = True
        Me.cmbCategory.TabIndex = 2
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(343, 15)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(183, 20)
        Me.txtDescription.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(265, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "** Description:"
        '
        'txtPartNo
        '
        Me.txtPartNo.Location = New System.Drawing.Point(78, 15)
        Me.txtPartNo.Name = "txtPartNo"
        Me.txtPartNo.Size = New System.Drawing.Size(183, 20)
        Me.txtPartNo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(7, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "** Part Code:"
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(531, 15)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(104, 28)
        Me.cmdAdd.TabIndex = 7
        Me.cmdAdd.Text = "&Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'grpCustomerInformation
        '
        Me.grpCustomerInformation.Controls.Add(Me.txtContact)
        Me.grpCustomerInformation.Controls.Add(Me.Label8)
        Me.grpCustomerInformation.Controls.Add(Me.txtAddress)
        Me.grpCustomerInformation.Controls.Add(Me.Label9)
        Me.grpCustomerInformation.Controls.Add(Me.txtName)
        Me.grpCustomerInformation.Controls.Add(Me.Label13)
        Me.grpCustomerInformation.Location = New System.Drawing.Point(5, 37)
        Me.grpCustomerInformation.Name = "grpCustomerInformation"
        Me.grpCustomerInformation.Size = New System.Drawing.Size(747, 60)
        Me.grpCustomerInformation.TabIndex = 38
        Me.grpCustomerInformation.TabStop = False
        Me.grpCustomerInformation.Text = "Customer Information"
        '
        'txtContact
        '
        Me.txtContact.Location = New System.Drawing.Point(610, 16)
        Me.txtContact.Multiline = True
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(132, 38)
        Me.txtContact.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(559, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Contact:"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(267, 16)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(291, 38)
        Me.txtAddress.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(215, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Address:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(50, 16)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(163, 38)
        Me.txtName.TabIndex = 0
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(11, 29)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(38, 13)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Name:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(436, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 13)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "**Sell Code:"
        '
        'cmbSellBy
        '
        Me.cmbSellBy.DropDownHeight = 60
        Me.cmbSellBy.FormattingEnabled = True
        Me.cmbSellBy.IntegralHeight = False
        Me.cmbSellBy.Location = New System.Drawing.Point(500, 11)
        Me.cmbSellBy.Name = "cmbSellBy"
        Me.cmbSellBy.Size = New System.Drawing.Size(63, 21)
        Me.cmbSellBy.Sorted = True
        Me.cmbSellBy.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(147, 13)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 13)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "**Branch:"
        '
        'cmbBranch
        '
        Me.cmbBranch.DropDownHeight = 60
        Me.cmbBranch.FormattingEnabled = True
        Me.cmbBranch.IntegralHeight = False
        Me.cmbBranch.Location = New System.Drawing.Point(197, 9)
        Me.cmbBranch.Name = "cmbBranch"
        Me.cmbBranch.Size = New System.Drawing.Size(114, 21)
        Me.cmbBranch.Sorted = True
        Me.cmbBranch.TabIndex = 1
        '
        'txtJobCode
        '
        Me.txtJobCode.Location = New System.Drawing.Point(63, 10)
        Me.txtJobCode.Name = "txtJobCode"
        Me.txtJobCode.Size = New System.Drawing.Size(82, 20)
        Me.txtJobCode.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(7, 14)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 13)
        Me.Label14.TabIndex = 44
        Me.Label14.Text = "Job Code:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(312, 13)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "Sell Date:"
        '
        'dtpSellDate
        '
        Me.dtpSellDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSellDate.Location = New System.Drawing.Point(366, 10)
        Me.dtpSellDate.Name = "dtpSellDate"
        Me.dtpSellDate.Size = New System.Drawing.Size(71, 20)
        Me.dtpSellDate.TabIndex = 2
        '
        'lblSellBy
        '
        Me.lblSellBy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSellBy.Location = New System.Drawing.Point(566, 11)
        Me.lblSellBy.Name = "lblSellBy"
        Me.lblSellBy.Size = New System.Drawing.Size(185, 21)
        Me.lblSellBy.TabIndex = 47
        '
        'cmdCancel
        '
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdCancel.Location = New System.Drawing.Point(629, 436)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(58, 23)
        Me.cmdCancel.TabIndex = 9
        Me.cmdCancel.Text = "&Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdSave.Location = New System.Drawing.Point(569, 436)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(58, 23)
        Me.cmdSave.TabIndex = 8
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'txtMRNO
        '
        Me.txtMRNO.Location = New System.Drawing.Point(65, 437)
        Me.txtMRNO.Name = "txtMRNO"
        Me.txtMRNO.Size = New System.Drawing.Size(93, 20)
        Me.txtMRNO.TabIndex = 4
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(7, 441)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 13)
        Me.Label15.TabIndex = 55
        Me.Label15.Text = "** MR NO:"
        '
        'txtDiscount
        '
        Me.txtDiscount.Location = New System.Drawing.Point(285, 437)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(55, 20)
        Me.txtDiscount.TabIndex = 5
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(232, 441)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 13)
        Me.Label16.TabIndex = 57
        Me.Label16.Text = "Discount:"
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Enabled = False
        Me.txtTotalAmount.Location = New System.Drawing.Point(432, 437)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.Size = New System.Drawing.Size(73, 20)
        Me.txtTotalAmount.TabIndex = 6
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(345, 441)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(87, 13)
        Me.Label17.TabIndex = 59
        Me.Label17.Text = "Payable Amount:"
        '
        'cmdDeleteMR
        '
        Me.cmdDeleteMR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdDeleteMR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdDeleteMR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdDeleteMR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDeleteMR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdDeleteMR.Location = New System.Drawing.Point(160, 436)
        Me.cmdDeleteMR.Name = "cmdDeleteMR"
        Me.cmdDeleteMR.Size = New System.Drawing.Size(68, 23)
        Me.cmdDeleteMR.TabIndex = 60
        Me.cmdDeleteMR.Text = "&Delete MR"
        Me.cmdDeleteMR.UseVisualStyleBackColor = True
        '
        'cmdPrint
        '
        Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdPrint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPrint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdPrint.Location = New System.Drawing.Point(509, 436)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(58, 23)
        Me.cmdPrint.TabIndex = 7
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.UseVisualStyleBackColor = True
        '
        'frmCashsale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(754, 462)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdDeleteMR)
        Me.Controls.Add(Me.cmbSellBy)
        Me.Controls.Add(Me.txtTotalAmount)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtDiscount)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtMRNO)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.lblSellBy)
        Me.Controls.Add(Me.dtpSellDate)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtJobCode)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cmbBranch)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.grpCustomerInformation)
        Me.Controls.Add(Me.grpProductInformation)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCashsale"
        Me.Text = "Cash Sale"
        Me.grpProductInformation.ResumeLayout(False)
        Me.grpProductInformation.PerformLayout()
        CType(Me.dgvMRNO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPartsInformation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCustomerInformation.ResumeLayout(False)
        Me.grpCustomerInformation.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdClose As Button
    Friend WithEvents grpProductInformation As GroupBox
    Friend WithEvents txtESNNO As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSerial As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbModel As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbBrand As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPartNo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdAdd As Button
    Friend WithEvents grpCustomerInformation As GroupBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbSellBy As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cmbBranch As ComboBox
    Friend WithEvents txtJobCode As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents dtpSellDate As DateTimePicker
    Friend WithEvents lblSellBy As Label
    Friend WithEvents cmdCancel As Button
    Friend WithEvents cmdSave As Button
    Friend WithEvents txtMRNO As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtDiscount As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtTotalAmount As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtUnitPrice As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtQty As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents lblTotalAmont As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents cmdRefresh As Button
    Friend WithEvents dgvPartsInformation As DataGridView
    Friend WithEvents lstProductList As ListView
    Friend WithEvents colsl As ColumnHeader
    Friend WithEvents colPartNo As ColumnHeader
    Friend WithEvents colDescription As ColumnHeader
    Friend WithEvents colCategory As ColumnHeader
    Friend WithEvents colBrand As ColumnHeader
    Friend WithEvents ColModel As ColumnHeader
    Friend WithEvents colUnitPrice As ColumnHeader
    Friend WithEvents colQty As ColumnHeader
    Friend WithEvents colTotal As ColumnHeader
    Friend WithEvents colSerial As ColumnHeader
    Friend WithEvents colESN As ColumnHeader
    Friend WithEvents Button1 As Button
    Friend WithEvents cmdDelete As Button
    Friend WithEvents dgvMRNO As DataGridView
    Friend WithEvents cmdDeleteMR As Button
    Friend WithEvents cmdPrint As Button
End Class
