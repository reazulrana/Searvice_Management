<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJobInformationForm
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
        Me.grpJobInformation = New System.Windows.Forms.GroupBox()
        Me.lblBranch = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblServiceProduct = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblJobNo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpCustomerInformation = New System.Windows.Forms.GroupBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblAddress2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblAddress1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.grpDateInformation = New System.Windows.Forms.GroupBox()
        Me.lblServiceDate = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.lblServiceby = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblAssignDate = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblAssignto = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lblReceivedBy = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblExpDelivery = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblReceptDate = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.grpProductDetails = New System.Windows.Forms.GroupBox()
        Me.lblESNno = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.lblSerial = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.lblBrand = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.lblTCategory = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbItem = New System.Windows.Forms.TabPage()
        Me.lstTBItemList = New System.Windows.Forms.ListView()
        Me.lstItemSL = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstItemName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtTBPreviousJobno = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtTBPurchaseDate = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.optTBServiceWarranty = New System.Windows.Forms.RadioButton()
        Me.optTBNonWarranty = New System.Windows.Forms.RadioButton()
        Me.optTBSalesWarranty = New System.Windows.Forms.RadioButton()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lstTBFaultList = New System.Windows.Forms.ListView()
        Me.ColTBFaultSL = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTBFaultList = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.grpServiceStatus = New System.Windows.Forms.GroupBox()
        Me.lblJobStatus = New System.Windows.Forms.Label()
        Me.lstPartsInformation = New System.Windows.Forms.ListView()
        Me.chSL = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chDescription = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chUnit = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chQty = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chUnitPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chTotal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmdService = New System.Windows.Forms.Button()
        Me.cmdPending = New System.Windows.Forms.Button()
        Me.cmdAbort = New System.Windows.Forms.Button()
        Me.cmdReplace = New System.Windows.Forms.Button()
        Me.cmdBill = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.grpJobInformation.SuspendLayout()
        Me.grpCustomerInformation.SuspendLayout()
        Me.grpDateInformation.SuspendLayout()
        Me.grpProductDetails.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tbItem.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.grpServiceStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpJobInformation
        '
        Me.grpJobInformation.BackColor = System.Drawing.Color.PapayaWhip
        Me.grpJobInformation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.grpJobInformation.Controls.Add(Me.lblBranch)
        Me.grpJobInformation.Controls.Add(Me.Label5)
        Me.grpJobInformation.Controls.Add(Me.lblServiceProduct)
        Me.grpJobInformation.Controls.Add(Me.Label3)
        Me.grpJobInformation.Controls.Add(Me.lblJobNo)
        Me.grpJobInformation.Controls.Add(Me.Label1)
        Me.grpJobInformation.Location = New System.Drawing.Point(2, 2)
        Me.grpJobInformation.Name = "grpJobInformation"
        Me.grpJobInformation.Size = New System.Drawing.Size(752, 41)
        Me.grpJobInformation.TabIndex = 0
        Me.grpJobInformation.TabStop = False
        '
        'lblBranch
        '
        Me.lblBranch.BackColor = System.Drawing.Color.DarkGray
        Me.lblBranch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBranch.ForeColor = System.Drawing.Color.White
        Me.lblBranch.Location = New System.Drawing.Point(572, 16)
        Me.lblBranch.Name = "lblBranch"
        Me.lblBranch.Size = New System.Drawing.Size(148, 18)
        Me.lblBranch.TabIndex = 5
        Me.lblBranch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Crimson
        Me.Label5.Location = New System.Drawing.Point(522, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Branch:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblServiceProduct
        '
        Me.lblServiceProduct.BackColor = System.Drawing.Color.DarkGray
        Me.lblServiceProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServiceProduct.ForeColor = System.Drawing.Color.White
        Me.lblServiceProduct.Location = New System.Drawing.Point(326, 16)
        Me.lblServiceProduct.Name = "lblServiceProduct"
        Me.lblServiceProduct.Size = New System.Drawing.Size(150, 18)
        Me.lblServiceProduct.TabIndex = 3
        Me.lblServiceProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Crimson
        Me.Label3.Location = New System.Drawing.Point(235, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Service Product:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblJobNo
        '
        Me.lblJobNo.BackColor = System.Drawing.Color.DarkGray
        Me.lblJobNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJobNo.ForeColor = System.Drawing.Color.White
        Me.lblJobNo.Location = New System.Drawing.Point(67, 16)
        Me.lblJobNo.Name = "lblJobNo"
        Me.lblJobNo.Size = New System.Drawing.Size(156, 18)
        Me.lblJobNo.TabIndex = 1
        Me.lblJobNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Crimson
        Me.Label1.Location = New System.Drawing.Point(17, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Job No:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grpCustomerInformation
        '
        Me.grpCustomerInformation.BackColor = System.Drawing.Color.PapayaWhip
        Me.grpCustomerInformation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.grpCustomerInformation.Controls.Add(Me.lblEmail)
        Me.grpCustomerInformation.Controls.Add(Me.Label10)
        Me.grpCustomerInformation.Controls.Add(Me.lblAddress2)
        Me.grpCustomerInformation.Controls.Add(Me.Label11)
        Me.grpCustomerInformation.Controls.Add(Me.lblAddress1)
        Me.grpCustomerInformation.Controls.Add(Me.Label9)
        Me.grpCustomerInformation.Controls.Add(Me.lblName)
        Me.grpCustomerInformation.Controls.Add(Me.Label2)
        Me.grpCustomerInformation.Controls.Add(Me.Label6)
        Me.grpCustomerInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCustomerInformation.ForeColor = System.Drawing.Color.Crimson
        Me.grpCustomerInformation.Location = New System.Drawing.Point(2, 45)
        Me.grpCustomerInformation.Name = "grpCustomerInformation"
        Me.grpCustomerInformation.Size = New System.Drawing.Size(357, 101)
        Me.grpCustomerInformation.TabIndex = 1
        Me.grpCustomerInformation.TabStop = False
        Me.grpCustomerInformation.Text = "Customer Information"
        '
        'lblEmail
        '
        Me.lblEmail.BackColor = System.Drawing.Color.DarkGray
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.White
        Me.lblEmail.Location = New System.Drawing.Point(65, 76)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(284, 18)
        Me.lblEmail.TabIndex = 9
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Crimson
        Me.Label10.Location = New System.Drawing.Point(28, 76)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Email:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAddress2
        '
        Me.lblAddress2.BackColor = System.Drawing.Color.DarkGray
        Me.lblAddress2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress2.ForeColor = System.Drawing.Color.White
        Me.lblAddress2.Location = New System.Drawing.Point(65, 57)
        Me.lblAddress2.Name = "lblAddress2"
        Me.lblAddress2.Size = New System.Drawing.Size(284, 18)
        Me.lblAddress2.TabIndex = 7
        Me.lblAddress2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Crimson
        Me.Label11.Location = New System.Drawing.Point(16, 57)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 13)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Contact:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAddress1
        '
        Me.lblAddress1.BackColor = System.Drawing.Color.DarkGray
        Me.lblAddress1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress1.ForeColor = System.Drawing.Color.White
        Me.lblAddress1.Location = New System.Drawing.Point(65, 38)
        Me.lblAddress1.Name = "lblAddress1"
        Me.lblAddress1.Size = New System.Drawing.Size(284, 18)
        Me.lblAddress1.TabIndex = 5
        Me.lblAddress1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Crimson
        Me.Label9.Location = New System.Drawing.Point(15, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Address:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.DarkGray
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(65, 19)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(284, 18)
        Me.lblName.TabIndex = 3
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(61, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(290, 20)
        Me.Label2.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Crimson
        Me.Label6.Location = New System.Drawing.Point(25, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Name:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grpDateInformation
        '
        Me.grpDateInformation.BackColor = System.Drawing.Color.PapayaWhip
        Me.grpDateInformation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.grpDateInformation.Controls.Add(Me.lblServiceDate)
        Me.grpDateInformation.Controls.Add(Me.Label25)
        Me.grpDateInformation.Controls.Add(Me.lblServiceby)
        Me.grpDateInformation.Controls.Add(Me.Label19)
        Me.grpDateInformation.Controls.Add(Me.lblAssignDate)
        Me.grpDateInformation.Controls.Add(Me.Label21)
        Me.grpDateInformation.Controls.Add(Me.lblAssignto)
        Me.grpDateInformation.Controls.Add(Me.Label23)
        Me.grpDateInformation.Controls.Add(Me.lblReceivedBy)
        Me.grpDateInformation.Controls.Add(Me.Label17)
        Me.grpDateInformation.Controls.Add(Me.lblExpDelivery)
        Me.grpDateInformation.Controls.Add(Me.Label15)
        Me.grpDateInformation.Controls.Add(Me.lblReceptDate)
        Me.grpDateInformation.Controls.Add(Me.Label13)
        Me.grpDateInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDateInformation.ForeColor = System.Drawing.Color.Crimson
        Me.grpDateInformation.Location = New System.Drawing.Point(364, 45)
        Me.grpDateInformation.Name = "grpDateInformation"
        Me.grpDateInformation.Size = New System.Drawing.Size(390, 101)
        Me.grpDateInformation.TabIndex = 2
        Me.grpDateInformation.TabStop = False
        Me.grpDateInformation.Text = "Date Information"
        '
        'lblServiceDate
        '
        Me.lblServiceDate.BackColor = System.Drawing.Color.DarkGray
        Me.lblServiceDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServiceDate.ForeColor = System.Drawing.Color.White
        Me.lblServiceDate.Location = New System.Drawing.Point(274, 76)
        Me.lblServiceDate.Name = "lblServiceDate"
        Me.lblServiceDate.Size = New System.Drawing.Size(111, 18)
        Me.lblServiceDate.TabIndex = 17
        Me.lblServiceDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Crimson
        Me.Label25.Location = New System.Drawing.Point(198, 76)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(72, 13)
        Me.Label25.TabIndex = 16
        Me.Label25.Text = "Service Date:"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblServiceby
        '
        Me.lblServiceby.BackColor = System.Drawing.Color.DarkGray
        Me.lblServiceby.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServiceby.ForeColor = System.Drawing.Color.White
        Me.lblServiceby.Location = New System.Drawing.Point(274, 55)
        Me.lblServiceby.Name = "lblServiceby"
        Me.lblServiceby.Size = New System.Drawing.Size(111, 18)
        Me.lblServiceby.TabIndex = 15
        Me.lblServiceby.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Crimson
        Me.Label19.Location = New System.Drawing.Point(210, 55)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(60, 13)
        Me.Label19.TabIndex = 14
        Me.Label19.Text = "Service by:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAssignDate
        '
        Me.lblAssignDate.BackColor = System.Drawing.Color.DarkGray
        Me.lblAssignDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAssignDate.ForeColor = System.Drawing.Color.White
        Me.lblAssignDate.Location = New System.Drawing.Point(274, 34)
        Me.lblAssignDate.Name = "lblAssignDate"
        Me.lblAssignDate.Size = New System.Drawing.Size(111, 18)
        Me.lblAssignDate.TabIndex = 13
        Me.lblAssignDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Crimson
        Me.Label21.Location = New System.Drawing.Point(203, 34)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(67, 13)
        Me.Label21.TabIndex = 12
        Me.Label21.Text = "Assign Date:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAssignto
        '
        Me.lblAssignto.BackColor = System.Drawing.Color.DarkGray
        Me.lblAssignto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAssignto.ForeColor = System.Drawing.Color.White
        Me.lblAssignto.Location = New System.Drawing.Point(274, 13)
        Me.lblAssignto.Name = "lblAssignto"
        Me.lblAssignto.Size = New System.Drawing.Size(111, 18)
        Me.lblAssignto.TabIndex = 11
        Me.lblAssignto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Crimson
        Me.Label23.Location = New System.Drawing.Point(217, 13)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(53, 13)
        Me.Label23.TabIndex = 10
        Me.Label23.Text = "Assign to:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblReceivedBy
        '
        Me.lblReceivedBy.BackColor = System.Drawing.Color.DarkGray
        Me.lblReceivedBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceivedBy.ForeColor = System.Drawing.Color.White
        Me.lblReceivedBy.Location = New System.Drawing.Point(83, 61)
        Me.lblReceivedBy.Name = "lblReceivedBy"
        Me.lblReceivedBy.Size = New System.Drawing.Size(111, 18)
        Me.lblReceivedBy.TabIndex = 9
        Me.lblReceivedBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Crimson
        Me.Label17.Location = New System.Drawing.Point(7, 61)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(70, 13)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "Received by:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblExpDelivery
        '
        Me.lblExpDelivery.BackColor = System.Drawing.Color.DarkGray
        Me.lblExpDelivery.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpDelivery.ForeColor = System.Drawing.Color.White
        Me.lblExpDelivery.Location = New System.Drawing.Point(83, 40)
        Me.lblExpDelivery.Name = "lblExpDelivery"
        Me.lblExpDelivery.Size = New System.Drawing.Size(111, 18)
        Me.lblExpDelivery.TabIndex = 7
        Me.lblExpDelivery.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Crimson
        Me.Label15.Location = New System.Drawing.Point(7, 40)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 13)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "Exp. Delivery:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblReceptDate
        '
        Me.lblReceptDate.BackColor = System.Drawing.Color.DarkGray
        Me.lblReceptDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceptDate.ForeColor = System.Drawing.Color.White
        Me.lblReceptDate.Location = New System.Drawing.Point(83, 19)
        Me.lblReceptDate.Name = "lblReceptDate"
        Me.lblReceptDate.Size = New System.Drawing.Size(111, 18)
        Me.lblReceptDate.TabIndex = 5
        Me.lblReceptDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Crimson
        Me.Label13.Location = New System.Drawing.Point(7, 19)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 13)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Recept Date:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grpProductDetails
        '
        Me.grpProductDetails.BackColor = System.Drawing.Color.PapayaWhip
        Me.grpProductDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.grpProductDetails.Controls.Add(Me.lblESNno)
        Me.grpProductDetails.Controls.Add(Me.Label35)
        Me.grpProductDetails.Controls.Add(Me.lblSerial)
        Me.grpProductDetails.Controls.Add(Me.Label33)
        Me.grpProductDetails.Controls.Add(Me.lblModel)
        Me.grpProductDetails.Controls.Add(Me.Label31)
        Me.grpProductDetails.Controls.Add(Me.lblBrand)
        Me.grpProductDetails.Controls.Add(Me.Label29)
        Me.grpProductDetails.Controls.Add(Me.lblCategory)
        Me.grpProductDetails.Controls.Add(Me.lblTCategory)
        Me.grpProductDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpProductDetails.ForeColor = System.Drawing.Color.Crimson
        Me.grpProductDetails.Location = New System.Drawing.Point(2, 148)
        Me.grpProductDetails.Name = "grpProductDetails"
        Me.grpProductDetails.Size = New System.Drawing.Size(359, 139)
        Me.grpProductDetails.TabIndex = 2
        Me.grpProductDetails.TabStop = False
        Me.grpProductDetails.Text = "Product Details"
        '
        'lblESNno
        '
        Me.lblESNno.BackColor = System.Drawing.Color.DarkGray
        Me.lblESNno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblESNno.ForeColor = System.Drawing.Color.White
        Me.lblESNno.Location = New System.Drawing.Point(70, 103)
        Me.lblESNno.Name = "lblESNno"
        Me.lblESNno.Size = New System.Drawing.Size(278, 18)
        Me.lblESNno.TabIndex = 13
        Me.lblESNno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Crimson
        Me.Label35.Location = New System.Drawing.Point(17, 103)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(49, 13)
        Me.Label35.TabIndex = 12
        Me.Label35.Text = "ESN No."
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSerial
        '
        Me.lblSerial.BackColor = System.Drawing.Color.DarkGray
        Me.lblSerial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSerial.ForeColor = System.Drawing.Color.White
        Me.lblSerial.Location = New System.Drawing.Point(70, 82)
        Me.lblSerial.Name = "lblSerial"
        Me.lblSerial.Size = New System.Drawing.Size(278, 18)
        Me.lblSerial.TabIndex = 11
        Me.lblSerial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Crimson
        Me.Label33.Location = New System.Drawing.Point(13, 82)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(53, 13)
        Me.Label33.TabIndex = 10
        Me.Label33.Text = "Serial No."
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblModel
        '
        Me.lblModel.BackColor = System.Drawing.Color.DarkGray
        Me.lblModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModel.ForeColor = System.Drawing.Color.White
        Me.lblModel.Location = New System.Drawing.Point(70, 61)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(278, 18)
        Me.lblModel.TabIndex = 9
        Me.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Crimson
        Me.Label31.Location = New System.Drawing.Point(27, 61)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(39, 13)
        Me.Label31.TabIndex = 8
        Me.Label31.Text = "Model:"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBrand
        '
        Me.lblBrand.BackColor = System.Drawing.Color.DarkGray
        Me.lblBrand.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrand.ForeColor = System.Drawing.Color.White
        Me.lblBrand.Location = New System.Drawing.Point(70, 40)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.Size = New System.Drawing.Size(278, 18)
        Me.lblBrand.TabIndex = 7
        Me.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Crimson
        Me.Label29.Location = New System.Drawing.Point(28, 40)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(38, 13)
        Me.Label29.TabIndex = 6
        Me.Label29.Text = "Brand:"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCategory
        '
        Me.lblCategory.BackColor = System.Drawing.Color.DarkGray
        Me.lblCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategory.ForeColor = System.Drawing.Color.White
        Me.lblCategory.Location = New System.Drawing.Point(70, 19)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(278, 18)
        Me.lblCategory.TabIndex = 5
        Me.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTCategory
        '
        Me.lblTCategory.AutoSize = True
        Me.lblTCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTCategory.ForeColor = System.Drawing.Color.Crimson
        Me.lblTCategory.Location = New System.Drawing.Point(14, 19)
        Me.lblTCategory.Name = "lblTCategory"
        Me.lblTCategory.Size = New System.Drawing.Size(52, 13)
        Me.lblTCategory.TabIndex = 4
        Me.lblTCategory.Text = "Category:"
        Me.lblTCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tbItem)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.ItemSize = New System.Drawing.Size(42, 16)
        Me.TabControl1.Location = New System.Drawing.Point(364, 148)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(390, 139)
        Me.TabControl1.TabIndex = 3
        '
        'tbItem
        '
        Me.tbItem.BackColor = System.Drawing.Color.PeachPuff
        Me.tbItem.Controls.Add(Me.lstTBItemList)
        Me.tbItem.Location = New System.Drawing.Point(4, 20)
        Me.tbItem.Name = "tbItem"
        Me.tbItem.Padding = New System.Windows.Forms.Padding(3)
        Me.tbItem.Size = New System.Drawing.Size(382, 115)
        Me.tbItem.TabIndex = 0
        Me.tbItem.Text = "Item"
        '
        'lstTBItemList
        '
        Me.lstTBItemList.BackColor = System.Drawing.Color.DarkGray
        Me.lstTBItemList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lstItemSL, Me.lstItemName})
        Me.lstTBItemList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTBItemList.ForeColor = System.Drawing.Color.White
        Me.lstTBItemList.FullRowSelect = True
        Me.lstTBItemList.GridLines = True
        Me.lstTBItemList.Location = New System.Drawing.Point(2, 1)
        Me.lstTBItemList.Name = "lstTBItemList"
        Me.lstTBItemList.Size = New System.Drawing.Size(378, 111)
        Me.lstTBItemList.TabIndex = 0
        Me.lstTBItemList.UseCompatibleStateImageBehavior = False
        Me.lstTBItemList.View = System.Windows.Forms.View.Details
        '
        'lstItemSL
        '
        Me.lstItemSL.Text = "SL"
        Me.lstItemSL.Width = 30
        '
        'lstItemName
        '
        Me.lstItemName.Text = "Name of Item"
        Me.lstItemName.Width = 340
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.DarkGray
        Me.TabPage2.Controls.Add(Me.txtTBPreviousJobno)
        Me.TabPage2.Controls.Add(Me.Label18)
        Me.TabPage2.Controls.Add(Me.txtTBPurchaseDate)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.optTBServiceWarranty)
        Me.TabPage2.Controls.Add(Me.optTBNonWarranty)
        Me.TabPage2.Controls.Add(Me.optTBSalesWarranty)
        Me.TabPage2.Location = New System.Drawing.Point(4, 20)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(382, 115)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Warranty"
        '
        'txtTBPreviousJobno
        '
        Me.txtTBPreviousJobno.BackColor = System.Drawing.Color.DarkGray
        Me.txtTBPreviousJobno.Enabled = False
        Me.txtTBPreviousJobno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTBPreviousJobno.ForeColor = System.Drawing.Color.Lime
        Me.txtTBPreviousJobno.Location = New System.Drawing.Point(230, 58)
        Me.txtTBPreviousJobno.Multiline = True
        Me.txtTBPreviousJobno.Name = "txtTBPreviousJobno"
        Me.txtTBPreviousJobno.Size = New System.Drawing.Size(144, 51)
        Me.txtTBPreviousJobno.TabIndex = 20
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.Transparent
        Me.Label18.Location = New System.Drawing.Point(140, 58)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(88, 13)
        Me.Label18.TabIndex = 19
        Me.Label18.Text = "Previous Job No:"
        '
        'txtTBPurchaseDate
        '
        Me.txtTBPurchaseDate.BackColor = System.Drawing.Color.DarkGray
        Me.txtTBPurchaseDate.Enabled = False
        Me.txtTBPurchaseDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTBPurchaseDate.ForeColor = System.Drawing.Color.Lime
        Me.txtTBPurchaseDate.Location = New System.Drawing.Point(230, 20)
        Me.txtTBPurchaseDate.Multiline = True
        Me.txtTBPurchaseDate.Name = "txtTBPurchaseDate"
        Me.txtTBPurchaseDate.Size = New System.Drawing.Size(144, 21)
        Me.txtTBPurchaseDate.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(147, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Purchase Date:"
        '
        'optTBServiceWarranty
        '
        Me.optTBServiceWarranty.AutoSize = True
        Me.optTBServiceWarranty.Enabled = False
        Me.optTBServiceWarranty.ForeColor = System.Drawing.Color.Transparent
        Me.optTBServiceWarranty.Location = New System.Drawing.Point(11, 75)
        Me.optTBServiceWarranty.Name = "optTBServiceWarranty"
        Me.optTBServiceWarranty.Size = New System.Drawing.Size(107, 17)
        Me.optTBServiceWarranty.TabIndex = 16
        Me.optTBServiceWarranty.TabStop = True
        Me.optTBServiceWarranty.Text = "S&ervice Warranty"
        Me.optTBServiceWarranty.UseVisualStyleBackColor = True
        '
        'optTBNonWarranty
        '
        Me.optTBNonWarranty.AutoSize = True
        Me.optTBNonWarranty.Enabled = False
        Me.optTBNonWarranty.ForeColor = System.Drawing.Color.Transparent
        Me.optTBNonWarranty.Location = New System.Drawing.Point(11, 49)
        Me.optTBNonWarranty.Name = "optTBNonWarranty"
        Me.optTBNonWarranty.Size = New System.Drawing.Size(91, 17)
        Me.optTBNonWarranty.TabIndex = 15
        Me.optTBNonWarranty.TabStop = True
        Me.optTBNonWarranty.Text = "&Non Warranty"
        Me.optTBNonWarranty.UseVisualStyleBackColor = True
        '
        'optTBSalesWarranty
        '
        Me.optTBSalesWarranty.AutoSize = True
        Me.optTBSalesWarranty.Enabled = False
        Me.optTBSalesWarranty.ForeColor = System.Drawing.Color.Transparent
        Me.optTBSalesWarranty.Location = New System.Drawing.Point(11, 22)
        Me.optTBSalesWarranty.Name = "optTBSalesWarranty"
        Me.optTBSalesWarranty.Size = New System.Drawing.Size(97, 17)
        Me.optTBSalesWarranty.TabIndex = 14
        Me.optTBSalesWarranty.TabStop = True
        Me.optTBSalesWarranty.Text = "&Sales Warranty"
        Me.optTBSalesWarranty.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lstTBFaultList)
        Me.TabPage1.Location = New System.Drawing.Point(4, 20)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(382, 115)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Failur Description"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lstTBFaultList
        '
        Me.lstTBFaultList.BackColor = System.Drawing.Color.DarkGray
        Me.lstTBFaultList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColTBFaultSL, Me.colTBFaultList})
        Me.lstTBFaultList.ForeColor = System.Drawing.Color.White
        Me.lstTBFaultList.GridLines = True
        Me.lstTBFaultList.Location = New System.Drawing.Point(5, 4)
        Me.lstTBFaultList.Name = "lstTBFaultList"
        Me.lstTBFaultList.Size = New System.Drawing.Size(374, 107)
        Me.lstTBFaultList.TabIndex = 1
        Me.lstTBFaultList.UseCompatibleStateImageBehavior = False
        Me.lstTBFaultList.View = System.Windows.Forms.View.Details
        '
        'ColTBFaultSL
        '
        Me.ColTBFaultSL.Text = "SL"
        Me.ColTBFaultSL.Width = 30
        '
        'colTBFaultList
        '
        Me.colTBFaultList.Text = "List of Failure"
        Me.colTBFaultList.Width = 340
        '
        'grpServiceStatus
        '
        Me.grpServiceStatus.BackColor = System.Drawing.Color.PapayaWhip
        Me.grpServiceStatus.Controls.Add(Me.lblJobStatus)
        Me.grpServiceStatus.Controls.Add(Me.lstPartsInformation)
        Me.grpServiceStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpServiceStatus.ForeColor = System.Drawing.Color.Red
        Me.grpServiceStatus.Location = New System.Drawing.Point(3, 288)
        Me.grpServiceStatus.Name = "grpServiceStatus"
        Me.grpServiceStatus.Size = New System.Drawing.Size(751, 193)
        Me.grpServiceStatus.TabIndex = 4
        Me.grpServiceStatus.TabStop = False
        Me.grpServiceStatus.Text = "Service Status"
        '
        'lblJobStatus
        '
        Me.lblJobStatus.BackColor = System.Drawing.Color.DarkGray
        Me.lblJobStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblJobStatus.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJobStatus.ForeColor = System.Drawing.Color.White
        Me.lblJobStatus.Location = New System.Drawing.Point(5, 15)
        Me.lblJobStatus.Name = "lblJobStatus"
        Me.lblJobStatus.Size = New System.Drawing.Size(742, 23)
        Me.lblJobStatus.TabIndex = 2
        Me.lblJobStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstPartsInformation
        '
        Me.lstPartsInformation.BackColor = System.Drawing.Color.DarkGray
        Me.lstPartsInformation.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chSL, Me.chCode, Me.chDescription, Me.chUnit, Me.chQty, Me.chUnitPrice, Me.chTotal})
        Me.lstPartsInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPartsInformation.ForeColor = System.Drawing.Color.White
        Me.lstPartsInformation.FullRowSelect = True
        Me.lstPartsInformation.GridLines = True
        Me.lstPartsInformation.Location = New System.Drawing.Point(5, 43)
        Me.lstPartsInformation.Name = "lstPartsInformation"
        Me.lstPartsInformation.Size = New System.Drawing.Size(744, 145)
        Me.lstPartsInformation.TabIndex = 1
        Me.lstPartsInformation.UseCompatibleStateImageBehavior = False
        Me.lstPartsInformation.View = System.Windows.Forms.View.Details
        '
        'chSL
        '
        Me.chSL.Text = "SL"
        Me.chSL.Width = 30
        '
        'chCode
        '
        Me.chCode.Text = "Code"
        Me.chCode.Width = 150
        '
        'chDescription
        '
        Me.chDescription.Text = "Description"
        Me.chDescription.Width = 240
        '
        'chUnit
        '
        Me.chUnit.Text = "Unit"
        Me.chUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chQty
        '
        Me.chQty.Text = "Qty"
        Me.chQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chQty.Width = 80
        '
        'chUnitPrice
        '
        Me.chUnitPrice.Text = "Unit Price"
        Me.chUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chUnitPrice.Width = 90
        '
        'chTotal
        '
        Me.chTotal.Text = "Total"
        Me.chTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chTotal.Width = 90
        '
        'cmdService
        '
        Me.cmdService.BackColor = System.Drawing.Color.Navy
        Me.cmdService.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.cmdService.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdService.ForeColor = System.Drawing.Color.White
        Me.cmdService.Location = New System.Drawing.Point(1, 478)
        Me.cmdService.Name = "cmdService"
        Me.cmdService.Size = New System.Drawing.Size(117, 24)
        Me.cmdService.TabIndex = 5
        Me.cmdService.Text = "&Service"
        Me.cmdService.UseVisualStyleBackColor = False
        '
        'cmdPending
        '
        Me.cmdPending.BackColor = System.Drawing.Color.Navy
        Me.cmdPending.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.cmdPending.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPending.ForeColor = System.Drawing.Color.White
        Me.cmdPending.Location = New System.Drawing.Point(117, 478)
        Me.cmdPending.Name = "cmdPending"
        Me.cmdPending.Size = New System.Drawing.Size(117, 24)
        Me.cmdPending.TabIndex = 6
        Me.cmdPending.Text = "&Pending"
        Me.cmdPending.UseVisualStyleBackColor = False
        '
        'cmdAbort
        '
        Me.cmdAbort.BackColor = System.Drawing.Color.Navy
        Me.cmdAbort.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.cmdAbort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAbort.ForeColor = System.Drawing.Color.White
        Me.cmdAbort.Location = New System.Drawing.Point(233, 478)
        Me.cmdAbort.Name = "cmdAbort"
        Me.cmdAbort.Size = New System.Drawing.Size(117, 24)
        Me.cmdAbort.TabIndex = 7
        Me.cmdAbort.Text = "&Abort"
        Me.cmdAbort.UseVisualStyleBackColor = False
        '
        'cmdReplace
        '
        Me.cmdReplace.BackColor = System.Drawing.Color.Navy
        Me.cmdReplace.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.cmdReplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdReplace.ForeColor = System.Drawing.Color.White
        Me.cmdReplace.Location = New System.Drawing.Point(405, 478)
        Me.cmdReplace.Name = "cmdReplace"
        Me.cmdReplace.Size = New System.Drawing.Size(117, 24)
        Me.cmdReplace.TabIndex = 8
        Me.cmdReplace.Text = "&Replace"
        Me.cmdReplace.UseVisualStyleBackColor = False
        '
        'cmdBill
        '
        Me.cmdBill.BackColor = System.Drawing.Color.Navy
        Me.cmdBill.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.cmdBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBill.ForeColor = System.Drawing.Color.White
        Me.cmdBill.Location = New System.Drawing.Point(521, 478)
        Me.cmdBill.Name = "cmdBill"
        Me.cmdBill.Size = New System.Drawing.Size(117, 24)
        Me.cmdBill.TabIndex = 9
        Me.cmdBill.Text = "&Bill"
        Me.cmdBill.UseVisualStyleBackColor = False
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.Color.Navy
        Me.cmdClose.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClose.ForeColor = System.Drawing.Color.White
        Me.cmdClose.Location = New System.Drawing.Point(636, 478)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(117, 24)
        Me.cmdClose.TabIndex = 10
        Me.cmdClose.Text = "C&lose"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'frmJobInformationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(757, 506)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdBill)
        Me.Controls.Add(Me.cmdReplace)
        Me.Controls.Add(Me.cmdAbort)
        Me.Controls.Add(Me.cmdPending)
        Me.Controls.Add(Me.cmdService)
        Me.Controls.Add(Me.grpServiceStatus)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.grpProductDetails)
        Me.Controls.Add(Me.grpDateInformation)
        Me.Controls.Add(Me.grpCustomerInformation)
        Me.Controls.Add(Me.grpJobInformation)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmJobInformationForm"
        Me.Text = "Service Slip"
        Me.grpJobInformation.ResumeLayout(False)
        Me.grpJobInformation.PerformLayout()
        Me.grpCustomerInformation.ResumeLayout(False)
        Me.grpCustomerInformation.PerformLayout()
        Me.grpDateInformation.ResumeLayout(False)
        Me.grpDateInformation.PerformLayout()
        Me.grpProductDetails.ResumeLayout(False)
        Me.grpProductDetails.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tbItem.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.grpServiceStatus.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpJobInformation As GroupBox
    Friend WithEvents grpCustomerInformation As GroupBox
    Friend WithEvents grpDateInformation As GroupBox
    Friend WithEvents grpProductDetails As GroupBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tbItem As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lblBranch As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblServiceProduct As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblJobNo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lstTBItemList As ListView
    Friend WithEvents lstItemSL As ColumnHeader
    Friend WithEvents lstItemName As ColumnHeader
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents lblAddress2 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblAddress1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblReceivedBy As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lblExpDelivery As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lblReceptDate As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblServiceDate As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents lblServiceby As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents lblAssignDate As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents lblAssignto As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents lblESNno As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents lblSerial As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents lblModel As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents lblBrand As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents lblCategory As Label
    Friend WithEvents lblTCategory As Label
    Friend WithEvents grpServiceStatus As GroupBox
    Friend WithEvents lstPartsInformation As ListView
    Friend WithEvents chSL As ColumnHeader
    Friend WithEvents chCode As ColumnHeader
    Friend WithEvents chDescription As ColumnHeader
    Friend WithEvents chUnit As ColumnHeader
    Friend WithEvents chQty As ColumnHeader
    Friend WithEvents chUnitPrice As ColumnHeader
    Friend WithEvents chTotal As ColumnHeader
    Friend WithEvents cmdService As Button
    Friend WithEvents cmdPending As Button
    Friend WithEvents cmdAbort As Button
    Friend WithEvents cmdReplace As Button
    Friend WithEvents cmdBill As Button
    Friend WithEvents cmdClose As Button
    Friend WithEvents lblJobStatus As Label
    Friend WithEvents txtTBPreviousJobno As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtTBPurchaseDate As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents optTBServiceWarranty As RadioButton
    Friend WithEvents optTBNonWarranty As RadioButton
    Friend WithEvents optTBSalesWarranty As RadioButton
    Friend WithEvents lstTBFaultList As ListView
    Friend WithEvents ColTBFaultSL As ColumnHeader
    Friend WithEvents colTBFaultList As ColumnHeader
    Friend WithEvents lblEmail As Label
    Friend WithEvents Label10 As Label
End Class
