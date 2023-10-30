<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProductInformation
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductInformation))
        Me.dgvJobStatus = New System.Windows.Forms.DataGridView()
        Me.grpControl = New System.Windows.Forms.GroupBox()
        Me.grpDate = New System.Windows.Forms.GroupBox()
        Me.optDelivery = New System.Windows.Forms.RadioButton()
        Me.optRepaired = New System.Windows.Forms.RadioButton()
        Me.optReceive = New System.Windows.Forms.RadioButton()
        Me.chkSvcWarr = New System.Windows.Forms.CheckBox()
        Me.chkNonWarr = New System.Windows.Forms.CheckBox()
        Me.chkSlsWarr = New System.Windows.Forms.CheckBox()
        Me.lblLine2 = New System.Windows.Forms.Label()
        Me.chkEstimateRefuse = New System.Windows.Forms.CheckBox()
        Me.chkReplace = New System.Windows.Forms.CheckBox()
        Me.chkCR = New System.Windows.Forms.CheckBox()
        Me.chkNR = New System.Windows.Forms.CheckBox()
        Me.chkDelivery = New System.Windows.Forms.CheckBox()
        Me.chkService = New System.Windows.Forms.CheckBox()
        Me.chkPending = New System.Windows.Forms.CheckBox()
        Me.chkNotService = New System.Windows.Forms.CheckBox()
        Me.optDateRange = New System.Windows.Forms.RadioButton()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.optAll = New System.Windows.Forms.RadioButton()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.lblBrand = New System.Windows.Forms.Label()
        Me.spltButton = New System.Windows.Forms.Splitter()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdLoad = New System.Windows.Forms.Button()
        Me.lblRecordCount = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cmdExport = New System.Windows.Forms.Button()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lstBranch = New System.Windows.Forms.CheckedListBox()
        Me.lstBrand = New System.Windows.Forms.CheckedListBox()
        Me.lstCustomerName = New System.Windows.Forms.CheckedListBox()
        Me.lstAddress = New System.Windows.Forms.CheckedListBox()
        Me.lstCategory = New System.Windows.Forms.CheckedListBox()
        Me.lblBranch = New System.Windows.Forms.Label()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.picLoadCustomer = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.picLoadAddress = New System.Windows.Forms.PictureBox()
        CType(Me.dgvJobStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpControl.SuspendLayout()
        Me.grpDate.SuspendLayout()
        CType(Me.picLoadCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLoadAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvJobStatus
        '
        Me.dgvJobStatus.BackgroundColor = System.Drawing.Color.NavajoWhite
        Me.dgvJobStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvJobStatus.GridColor = System.Drawing.Color.White
        Me.dgvJobStatus.Location = New System.Drawing.Point(0, 115)
        Me.dgvJobStatus.Name = "dgvJobStatus"
        Me.dgvJobStatus.ReadOnly = True
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.dgvJobStatus.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvJobStatus.Size = New System.Drawing.Size(784, 410)
        Me.dgvJobStatus.TabIndex = 0
        '
        'grpControl
        '
        Me.grpControl.BackColor = System.Drawing.Color.Moccasin
        Me.grpControl.Controls.Add(Me.grpDate)
        Me.grpControl.Controls.Add(Me.chkSvcWarr)
        Me.grpControl.Controls.Add(Me.chkNonWarr)
        Me.grpControl.Controls.Add(Me.chkSlsWarr)
        Me.grpControl.Controls.Add(Me.lblLine2)
        Me.grpControl.Controls.Add(Me.chkEstimateRefuse)
        Me.grpControl.Controls.Add(Me.chkReplace)
        Me.grpControl.Controls.Add(Me.chkCR)
        Me.grpControl.Controls.Add(Me.chkNR)
        Me.grpControl.Controls.Add(Me.chkDelivery)
        Me.grpControl.Controls.Add(Me.chkService)
        Me.grpControl.Controls.Add(Me.chkPending)
        Me.grpControl.Controls.Add(Me.chkNotService)
        Me.grpControl.Controls.Add(Me.optDateRange)
        Me.grpControl.Controls.Add(Me.lblTo)
        Me.grpControl.Controls.Add(Me.optAll)
        Me.grpControl.Controls.Add(Me.dtpTo)
        Me.grpControl.Controls.Add(Me.lblFrom)
        Me.grpControl.Controls.Add(Me.dtpFrom)
        Me.grpControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpControl.Location = New System.Drawing.Point(0, 0)
        Me.grpControl.Name = "grpControl"
        Me.grpControl.Size = New System.Drawing.Size(784, 82)
        Me.grpControl.TabIndex = 1
        Me.grpControl.TabStop = False
        '
        'grpDate
        '
        Me.grpDate.Controls.Add(Me.optDelivery)
        Me.grpDate.Controls.Add(Me.optRepaired)
        Me.grpDate.Controls.Add(Me.optReceive)
        Me.grpDate.ForeColor = System.Drawing.Color.White
        Me.grpDate.Location = New System.Drawing.Point(356, 15)
        Me.grpDate.Name = "grpDate"
        Me.grpDate.Size = New System.Drawing.Size(209, 33)
        Me.grpDate.TabIndex = 31
        Me.grpDate.TabStop = False
        '
        'optDelivery
        '
        Me.optDelivery.AutoSize = True
        Me.optDelivery.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.optDelivery.Location = New System.Drawing.Point(142, 11)
        Me.optDelivery.Name = "optDelivery"
        Me.optDelivery.Size = New System.Drawing.Size(63, 17)
        Me.optDelivery.TabIndex = 36
        Me.optDelivery.TabStop = True
        Me.optDelivery.Text = "&Delivery"
        Me.optDelivery.UseVisualStyleBackColor = True
        '
        'optRepaired
        '
        Me.optRepaired.AutoSize = True
        Me.optRepaired.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.optRepaired.Location = New System.Drawing.Point(73, 11)
        Me.optRepaired.Name = "optRepaired"
        Me.optRepaired.Size = New System.Drawing.Size(68, 17)
        Me.optRepaired.TabIndex = 35
        Me.optRepaired.TabStop = True
        Me.optRepaired.Text = "Re&paired"
        Me.optRepaired.UseVisualStyleBackColor = True
        '
        'optReceive
        '
        Me.optReceive.AutoSize = True
        Me.optReceive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.optReceive.Location = New System.Drawing.Point(5, 11)
        Me.optReceive.Name = "optReceive"
        Me.optReceive.Size = New System.Drawing.Size(71, 17)
        Me.optReceive.TabIndex = 34
        Me.optReceive.TabStop = True
        Me.optReceive.Text = "&Received"
        Me.optReceive.UseVisualStyleBackColor = True
        '
        'chkSvcWarr
        '
        Me.chkSvcWarr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkSvcWarr.Location = New System.Drawing.Point(705, 26)
        Me.chkSvcWarr.Name = "chkSvcWarr"
        Me.chkSvcWarr.Size = New System.Drawing.Size(72, 17)
        Me.chkSvcWarr.TabIndex = 30
        Me.chkSvcWarr.Text = "Svc Warr"
        Me.chkSvcWarr.UseVisualStyleBackColor = True
        '
        'chkNonWarr
        '
        Me.chkNonWarr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkNonWarr.Location = New System.Drawing.Point(636, 26)
        Me.chkNonWarr.Name = "chkNonWarr"
        Me.chkNonWarr.Size = New System.Drawing.Size(72, 17)
        Me.chkNonWarr.TabIndex = 29
        Me.chkNonWarr.Text = "Non Warr"
        Me.chkNonWarr.UseVisualStyleBackColor = True
        '
        'chkSlsWarr
        '
        Me.chkSlsWarr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkSlsWarr.Location = New System.Drawing.Point(567, 26)
        Me.chkSlsWarr.Name = "chkSlsWarr"
        Me.chkSlsWarr.Size = New System.Drawing.Size(66, 17)
        Me.chkSlsWarr.TabIndex = 28
        Me.chkSlsWarr.Text = "Sls-Warr"
        Me.chkSlsWarr.UseVisualStyleBackColor = True
        '
        'lblLine2
        '
        Me.lblLine2.BackColor = System.Drawing.Color.DarkKhaki
        Me.lblLine2.Location = New System.Drawing.Point(2, 77)
        Me.lblLine2.Name = "lblLine2"
        Me.lblLine2.Size = New System.Drawing.Size(800, 1)
        Me.lblLine2.TabIndex = 27
        '
        'chkEstimateRefuse
        '
        Me.chkEstimateRefuse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkEstimateRefuse.Location = New System.Drawing.Point(673, 58)
        Me.chkEstimateRefuse.Name = "chkEstimateRefuse"
        Me.chkEstimateRefuse.Size = New System.Drawing.Size(83, 17)
        Me.chkEstimateRefuse.TabIndex = 11
        Me.chkEstimateRefuse.Text = "Est Refuse"
        Me.chkEstimateRefuse.UseVisualStyleBackColor = True
        '
        'chkReplace
        '
        Me.chkReplace.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkReplace.Location = New System.Drawing.Point(594, 58)
        Me.chkReplace.Name = "chkReplace"
        Me.chkReplace.Size = New System.Drawing.Size(66, 17)
        Me.chkReplace.TabIndex = 10
        Me.chkReplace.Text = "Replace"
        Me.chkReplace.UseVisualStyleBackColor = True
        '
        'chkCR
        '
        Me.chkCR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkCR.Location = New System.Drawing.Point(485, 58)
        Me.chkCR.Name = "chkCR"
        Me.chkCR.Size = New System.Drawing.Size(83, 17)
        Me.chkCR.TabIndex = 9
        Me.chkCR.Text = "C/R"
        Me.chkCR.UseVisualStyleBackColor = True
        '
        'chkNR
        '
        Me.chkNR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkNR.Location = New System.Drawing.Point(387, 58)
        Me.chkNR.Name = "chkNR"
        Me.chkNR.Size = New System.Drawing.Size(83, 17)
        Me.chkNR.TabIndex = 8
        Me.chkNR.Text = "N/R"
        Me.chkNR.UseVisualStyleBackColor = True
        '
        'chkDelivery
        '
        Me.chkDelivery.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkDelivery.Location = New System.Drawing.Point(202, 58)
        Me.chkDelivery.Name = "chkDelivery"
        Me.chkDelivery.Size = New System.Drawing.Size(83, 17)
        Me.chkDelivery.TabIndex = 7
        Me.chkDelivery.Text = "Delivery"
        Me.chkDelivery.UseVisualStyleBackColor = True
        '
        'chkService
        '
        Me.chkService.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkService.Location = New System.Drawing.Point(112, 58)
        Me.chkService.Name = "chkService"
        Me.chkService.Size = New System.Drawing.Size(83, 17)
        Me.chkService.TabIndex = 6
        Me.chkService.Text = "Service"
        Me.chkService.UseVisualStyleBackColor = True
        '
        'chkPending
        '
        Me.chkPending.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkPending.Location = New System.Drawing.Point(293, 58)
        Me.chkPending.Name = "chkPending"
        Me.chkPending.Size = New System.Drawing.Size(83, 17)
        Me.chkPending.TabIndex = 5
        Me.chkPending.Text = "Pending"
        Me.chkPending.UseVisualStyleBackColor = True
        '
        'chkNotService
        '
        Me.chkNotService.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkNotService.Location = New System.Drawing.Point(22, 58)
        Me.chkNotService.Name = "chkNotService"
        Me.chkNotService.Size = New System.Drawing.Size(83, 17)
        Me.chkNotService.TabIndex = 4
        Me.chkNotService.Text = "Not Service"
        Me.chkNotService.UseVisualStyleBackColor = True
        '
        'optDateRange
        '
        Me.optDateRange.AutoSize = True
        Me.optDateRange.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.optDateRange.Location = New System.Drawing.Point(42, 26)
        Me.optDateRange.Name = "optDateRange"
        Me.optDateRange.Size = New System.Drawing.Size(57, 17)
        Me.optDateRange.TabIndex = 3
        Me.optDateRange.TabStop = True
        Me.optDateRange.Text = "Range"
        Me.optDateRange.UseVisualStyleBackColor = True
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTo.Location = New System.Drawing.Point(231, 28)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(23, 13)
        Me.lblTo.TabIndex = 3
        Me.lblTo.Text = "To:"
        '
        'optAll
        '
        Me.optAll.AutoSize = True
        Me.optAll.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.optAll.Location = New System.Drawing.Point(7, 26)
        Me.optAll.Name = "optAll"
        Me.optAll.Size = New System.Drawing.Size(36, 17)
        Me.optAll.TabIndex = 2
        Me.optAll.TabStop = True
        Me.optAll.Text = "All"
        Me.optAll.UseVisualStyleBackColor = True
        '
        'dtpTo
        '
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTo.Location = New System.Drawing.Point(256, 24)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(98, 20)
        Me.dtpTo.TabIndex = 3
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblFrom.Location = New System.Drawing.Point(99, 28)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(33, 13)
        Me.lblFrom.TabIndex = 2
        Me.lblFrom.Text = "From:"
        '
        'dtpFrom
        '
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFrom.Location = New System.Drawing.Point(133, 24)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(98, 20)
        Me.dtpFrom.TabIndex = 2
        '
        'lblBrand
        '
        Me.lblBrand.BackColor = System.Drawing.Color.Orange
        Me.lblBrand.ForeColor = System.Drawing.Color.Black
        Me.lblBrand.Location = New System.Drawing.Point(307, 86)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.Size = New System.Drawing.Size(134, 16)
        Me.lblBrand.TabIndex = 25
        Me.lblBrand.Text = "Brand:"
        Me.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'spltButton
        '
        Me.spltButton.BackColor = System.Drawing.Color.Moccasin
        Me.spltButton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.spltButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.spltButton.Location = New System.Drawing.Point(0, 528)
        Me.spltButton.Name = "spltButton"
        Me.spltButton.Size = New System.Drawing.Size(784, 34)
        Me.spltButton.TabIndex = 15
        Me.spltButton.TabStop = False
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.Color.Moccasin
        Me.cmdClose.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.Color.Maroon
        Me.cmdClose.Location = New System.Drawing.Point(692, 532)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(82, 27)
        Me.cmdClose.TabIndex = 16
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'cmdLoad
        '
        Me.cmdLoad.BackColor = System.Drawing.Color.Moccasin
        Me.cmdLoad.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod
        Me.cmdLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLoad.ForeColor = System.Drawing.Color.Maroon
        Me.cmdLoad.Location = New System.Drawing.Point(446, 532)
        Me.cmdLoad.Name = "cmdLoad"
        Me.cmdLoad.Size = New System.Drawing.Size(82, 27)
        Me.cmdLoad.TabIndex = 18
        Me.cmdLoad.Text = "&Load Data"
        Me.cmdLoad.UseVisualStyleBackColor = False
        '
        'lblRecordCount
        '
        Me.lblRecordCount.BackColor = System.Drawing.Color.Moccasin
        Me.lblRecordCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRecordCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblRecordCount.Location = New System.Drawing.Point(6, 534)
        Me.lblRecordCount.Name = "lblRecordCount"
        Me.lblRecordCount.Size = New System.Drawing.Size(425, 23)
        Me.lblRecordCount.TabIndex = 19
        Me.lblRecordCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'cmdExport
        '
        Me.cmdExport.BackColor = System.Drawing.Color.Moccasin
        Me.cmdExport.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod
        Me.cmdExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdExport.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExport.ForeColor = System.Drawing.Color.Maroon
        Me.cmdExport.Location = New System.Drawing.Point(534, 532)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(82, 27)
        Me.cmdExport.TabIndex = 20
        Me.cmdExport.Text = "&Export Data"
        Me.cmdExport.UseVisualStyleBackColor = False
        '
        'lblCustomerName
        '
        Me.lblCustomerName.BackColor = System.Drawing.Color.Orange
        Me.lblCustomerName.ForeColor = System.Drawing.Color.Black
        Me.lblCustomerName.Location = New System.Drawing.Point(457, 86)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(151, 16)
        Me.lblCustomerName.TabIndex = 28
        Me.lblCustomerName.Text = "Customer Name:"
        Me.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAddress
        '
        Me.lblAddress.BackColor = System.Drawing.Color.Orange
        Me.lblAddress.ForeColor = System.Drawing.Color.Black
        Me.lblAddress.Location = New System.Drawing.Point(630, 86)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(136, 16)
        Me.lblAddress.TabIndex = 30
        Me.lblAddress.Text = "Address:"
        Me.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lstBranch
        '
        Me.lstBranch.FormattingEnabled = True
        Me.lstBranch.Location = New System.Drawing.Point(5, 102)
        Me.lstBranch.Name = "lstBranch"
        Me.lstBranch.Size = New System.Drawing.Size(134, 4)
        Me.lstBranch.TabIndex = 31
        '
        'lstBrand
        '
        Me.lstBrand.FormattingEnabled = True
        Me.lstBrand.Location = New System.Drawing.Point(307, 102)
        Me.lstBrand.Name = "lstBrand"
        Me.lstBrand.Size = New System.Drawing.Size(134, 4)
        Me.lstBrand.TabIndex = 33
        '
        'lstCustomerName
        '
        Me.lstCustomerName.FormattingEnabled = True
        Me.lstCustomerName.Location = New System.Drawing.Point(457, 102)
        Me.lstCustomerName.Name = "lstCustomerName"
        Me.lstCustomerName.Size = New System.Drawing.Size(151, 4)
        Me.lstCustomerName.TabIndex = 34
        '
        'lstAddress
        '
        Me.lstAddress.FormattingEnabled = True
        Me.lstAddress.Location = New System.Drawing.Point(630, 102)
        Me.lstAddress.Name = "lstAddress"
        Me.lstAddress.Size = New System.Drawing.Size(136, 4)
        Me.lstAddress.TabIndex = 35
        '
        'lstCategory
        '
        Me.lstCategory.FormattingEnabled = True
        Me.lstCategory.Location = New System.Drawing.Point(156, 102)
        Me.lstCategory.Name = "lstCategory"
        Me.lstCategory.Size = New System.Drawing.Size(134, 4)
        Me.lstCategory.TabIndex = 38
        '
        'lblBranch
        '
        Me.lblBranch.BackColor = System.Drawing.Color.Orange
        Me.lblBranch.ForeColor = System.Drawing.Color.Black
        Me.lblBranch.Location = New System.Drawing.Point(5, 87)
        Me.lblBranch.Name = "lblBranch"
        Me.lblBranch.Size = New System.Drawing.Size(134, 15)
        Me.lblBranch.TabIndex = 36
        Me.lblBranch.Text = "Branch :"
        Me.lblBranch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCategory
        '
        Me.lblCategory.BackColor = System.Drawing.Color.Orange
        Me.lblCategory.ForeColor = System.Drawing.Color.Black
        Me.lblCategory.Location = New System.Drawing.Point(156, 86)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(134, 16)
        Me.lblCategory.TabIndex = 37
        Me.lblCategory.Text = "Category:"
        Me.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picLoadCustomer
        '
        Me.picLoadCustomer.Image = CType(resources.GetObject("picLoadCustomer.Image"), System.Drawing.Image)
        Me.picLoadCustomer.Location = New System.Drawing.Point(611, 88)
        Me.picLoadCustomer.Name = "picLoadCustomer"
        Me.picLoadCustomer.Size = New System.Drawing.Size(15, 15)
        Me.picLoadCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLoadCustomer.TabIndex = 39
        Me.picLoadCustomer.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picLoadCustomer, "Load Customer")
        '
        'picLoadAddress
        '
        Me.picLoadAddress.Image = CType(resources.GetObject("picLoadAddress.Image"), System.Drawing.Image)
        Me.picLoadAddress.Location = New System.Drawing.Point(767, 88)
        Me.picLoadAddress.Name = "picLoadAddress"
        Me.picLoadAddress.Size = New System.Drawing.Size(15, 15)
        Me.picLoadAddress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLoadAddress.TabIndex = 40
        Me.picLoadAddress.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picLoadAddress, "Load Customer")
        '
        'frmProductInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Moccasin
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.picLoadAddress)
        Me.Controls.Add(Me.picLoadCustomer)
        Me.Controls.Add(Me.lstCategory)
        Me.Controls.Add(Me.lblBranch)
        Me.Controls.Add(Me.lblCategory)
        Me.Controls.Add(Me.lstAddress)
        Me.Controls.Add(Me.lstCustomerName)
        Me.Controls.Add(Me.lstBrand)
        Me.Controls.Add(Me.lstBranch)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblCustomerName)
        Me.Controls.Add(Me.cmdExport)
        Me.Controls.Add(Me.lblRecordCount)
        Me.Controls.Add(Me.cmdLoad)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.spltButton)
        Me.Controls.Add(Me.grpControl)
        Me.Controls.Add(Me.dgvJobStatus)
        Me.Controls.Add(Me.lblBrand)
        Me.Name = "frmProductInformation"
        Me.Text = "Product Information"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvJobStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpControl.ResumeLayout(False)
        Me.grpControl.PerformLayout()
        Me.grpDate.ResumeLayout(False)
        Me.grpDate.PerformLayout()
        CType(Me.picLoadCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLoadAddress, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvJobStatus As DataGridView
    Friend WithEvents grpControl As GroupBox
    Friend WithEvents lblTo As Label
    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents lblFrom As Label
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents optAll As RadioButton
    Friend WithEvents optDateRange As RadioButton
    Friend WithEvents chkEstimateRefuse As CheckBox
    Friend WithEvents chkReplace As CheckBox
    Friend WithEvents chkCR As CheckBox
    Friend WithEvents chkNR As CheckBox
    Friend WithEvents chkDelivery As CheckBox
    Friend WithEvents chkService As CheckBox
    Friend WithEvents chkPending As CheckBox
    Friend WithEvents chkNotService As CheckBox
    Friend WithEvents spltButton As Splitter
    Friend WithEvents cmdClose As Button
    Friend WithEvents cmdLoad As Button
    Friend WithEvents lblRecordCount As Label
    Friend WithEvents lblBrand As Label
    Friend WithEvents lblLine2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents chkSvcWarr As CheckBox
    Friend WithEvents chkNonWarr As CheckBox
    Friend WithEvents chkSlsWarr As CheckBox
    Friend WithEvents grpDate As GroupBox
    Friend WithEvents optDelivery As RadioButton
    Friend WithEvents optRepaired As RadioButton
    Friend WithEvents optReceive As RadioButton
    Friend WithEvents cmdExport As Button
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lstBranch As CheckedListBox
    Friend WithEvents lstBrand As CheckedListBox
    Friend WithEvents lstCustomerName As CheckedListBox
    Friend WithEvents lstAddress As CheckedListBox
    Friend WithEvents lstCategory As CheckedListBox
    Friend WithEvents lblBranch As Label
    Friend WithEvents lblCategory As Label
    Friend WithEvents picLoadCustomer As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents picLoadAddress As PictureBox
End Class
