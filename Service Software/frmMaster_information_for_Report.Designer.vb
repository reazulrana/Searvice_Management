<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMaster_information
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
        Me.grpStatus = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkEstimateRefuse = New System.Windows.Forms.CheckBox()
        Me.optByDelivery = New System.Windows.Forms.RadioButton()
        Me.optByRepaired = New System.Windows.Forms.RadioButton()
        Me.optByReceive = New System.Windows.Forms.RadioButton()
        Me.chkReplaceDelivery = New System.Windows.Forms.CheckBox()
        Me.chkReplace = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblLine1 = New System.Windows.Forms.Label()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.chkCR = New System.Windows.Forms.CheckBox()
        Me.chkNR = New System.Windows.Forms.CheckBox()
        Me.chkPending = New System.Windows.Forms.CheckBox()
        Me.chkDelivered = New System.Windows.Forms.CheckBox()
        Me.chkRepaired = New System.Windows.Forms.CheckBox()
        Me.chkWaitingforService = New System.Windows.Forms.CheckBox()
        Me.cmdShowReport = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.chkReportServiceWarranty = New System.Windows.Forms.CheckBox()
        Me.chkReportNonWarranty = New System.Windows.Forms.CheckBox()
        Me.chkReportSalesWarranty = New System.Windows.Forms.CheckBox()
        Me.grpGroupSelection = New System.Windows.Forms.GroupBox()
        Me.txtSearchModel = New System.Windows.Forms.TextBox()
        Me.SearchModel = New System.Windows.Forms.PictureBox()
        Me.txtSearchBrand = New System.Windows.Forms.TextBox()
        Me.SearchBrand = New System.Windows.Forms.PictureBox()
        Me.txtSearchCategory = New System.Windows.Forms.TextBox()
        Me.SearchCategory = New System.Windows.Forms.PictureBox()
        Me.txtSearchBranch = New System.Windows.Forms.TextBox()
        Me.SearchBranch = New System.Windows.Forms.PictureBox()
        Me.lstReportModel = New System.Windows.Forms.ListView()
        Me.lstReportBrand = New System.Windows.Forms.ListView()
        Me.lstReportCategory = New System.Windows.Forms.ListView()
        Me.lstReportBranch = New System.Windows.Forms.ListView()
        Me.chkReportModel = New System.Windows.Forms.CheckBox()
        Me.chkReportBrand = New System.Windows.Forms.CheckBox()
        Me.chkReportCategory = New System.Windows.Forms.CheckBox()
        Me.chkReportBranch = New System.Windows.Forms.CheckBox()
        Me.grpSingleSelection = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbModel = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbBrand = New System.Windows.Forms.ComboBox()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.cmbBranch = New System.Windows.Forms.ComboBox()
        Me.optSingleSelection = New System.Windows.Forms.RadioButton()
        Me.optGroupSelection = New System.Windows.Forms.RadioButton()
        Me.chkSalesWarrPrice = New System.Windows.Forms.CheckBox()
        Me.grpStatus.SuspendLayout()
        Me.grpGroupSelection.SuspendLayout()
        CType(Me.SearchModel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchBrand, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchBranch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSingleSelection.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpStatus
        '
        Me.grpStatus.Controls.Add(Me.chkSalesWarrPrice)
        Me.grpStatus.Controls.Add(Me.Label4)
        Me.grpStatus.Controls.Add(Me.chkEstimateRefuse)
        Me.grpStatus.Controls.Add(Me.optByDelivery)
        Me.grpStatus.Controls.Add(Me.optByRepaired)
        Me.grpStatus.Controls.Add(Me.optByReceive)
        Me.grpStatus.Controls.Add(Me.chkReplaceDelivery)
        Me.grpStatus.Controls.Add(Me.chkReplace)
        Me.grpStatus.Controls.Add(Me.Label3)
        Me.grpStatus.Controls.Add(Me.lblLine1)
        Me.grpStatus.Controls.Add(Me.cmdClose)
        Me.grpStatus.Controls.Add(Me.chkCR)
        Me.grpStatus.Controls.Add(Me.chkNR)
        Me.grpStatus.Controls.Add(Me.chkPending)
        Me.grpStatus.Controls.Add(Me.chkDelivered)
        Me.grpStatus.Controls.Add(Me.chkRepaired)
        Me.grpStatus.Controls.Add(Me.chkWaitingforService)
        Me.grpStatus.Controls.Add(Me.cmdShowReport)
        Me.grpStatus.Controls.Add(Me.Label2)
        Me.grpStatus.Controls.Add(Me.Label1)
        Me.grpStatus.Controls.Add(Me.dtpTo)
        Me.grpStatus.Controls.Add(Me.dtpFrom)
        Me.grpStatus.Controls.Add(Me.chkReportServiceWarranty)
        Me.grpStatus.Controls.Add(Me.chkReportNonWarranty)
        Me.grpStatus.Controls.Add(Me.chkReportSalesWarranty)
        Me.grpStatus.Location = New System.Drawing.Point(8, 5)
        Me.grpStatus.Name = "grpStatus"
        Me.grpStatus.Size = New System.Drawing.Size(687, 100)
        Me.grpStatus.TabIndex = 14
        Me.grpStatus.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(4, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(679, 1)
        Me.Label4.TabIndex = 45
        '
        'chkEstimateRefuse
        '
        Me.chkEstimateRefuse.AutoSize = True
        Me.chkEstimateRefuse.Location = New System.Drawing.Point(425, 72)
        Me.chkEstimateRefuse.Name = "chkEstimateRefuse"
        Me.chkEstimateRefuse.Size = New System.Drawing.Size(78, 17)
        Me.chkEstimateRefuse.TabIndex = 44
        Me.chkEstimateRefuse.Text = "Est Refuse"
        Me.chkEstimateRefuse.UseVisualStyleBackColor = True
        '
        'optByDelivery
        '
        Me.optByDelivery.AutoSize = True
        Me.optByDelivery.Location = New System.Drawing.Point(561, 46)
        Me.optByDelivery.Name = "optByDelivery"
        Me.optByDelivery.Size = New System.Drawing.Size(78, 17)
        Me.optByDelivery.TabIndex = 43
        Me.optByDelivery.TabStop = True
        Me.optByDelivery.Text = "By Delivery"
        Me.optByDelivery.UseVisualStyleBackColor = True
        '
        'optByRepaired
        '
        Me.optByRepaired.AutoSize = True
        Me.optByRepaired.Location = New System.Drawing.Point(465, 46)
        Me.optByRepaired.Name = "optByRepaired"
        Me.optByRepaired.Size = New System.Drawing.Size(83, 17)
        Me.optByRepaired.TabIndex = 42
        Me.optByRepaired.TabStop = True
        Me.optByRepaired.Text = "By Repaired"
        Me.optByRepaired.UseVisualStyleBackColor = True
        '
        'optByReceive
        '
        Me.optByReceive.AutoSize = True
        Me.optByReceive.Location = New System.Drawing.Point(372, 46)
        Me.optByReceive.Name = "optByReceive"
        Me.optByReceive.Size = New System.Drawing.Size(80, 17)
        Me.optByReceive.TabIndex = 41
        Me.optByReceive.TabStop = True
        Me.optByReceive.Text = "By Receive"
        Me.optByReceive.UseVisualStyleBackColor = True
        '
        'chkReplaceDelivery
        '
        Me.chkReplaceDelivery.AutoSize = True
        Me.chkReplaceDelivery.Location = New System.Drawing.Point(569, 73)
        Me.chkReplaceDelivery.Name = "chkReplaceDelivery"
        Me.chkReplaceDelivery.Size = New System.Drawing.Size(107, 17)
        Me.chkReplaceDelivery.TabIndex = 40
        Me.chkReplaceDelivery.Text = "Replace Delivery"
        Me.chkReplaceDelivery.UseVisualStyleBackColor = True
        '
        'chkReplace
        '
        Me.chkReplace.AutoSize = True
        Me.chkReplace.Location = New System.Drawing.Point(505, 73)
        Me.chkReplace.Name = "chkReplace"
        Me.chkReplace.Size = New System.Drawing.Size(66, 17)
        Me.chkReplace.TabIndex = 39
        Me.chkReplace.Text = "Replace"
        Me.chkReplace.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(6, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(679, 1)
        Me.Label3.TabIndex = 38
        '
        'lblLine1
        '
        Me.lblLine1.BackColor = System.Drawing.Color.White
        Me.lblLine1.Location = New System.Drawing.Point(7, 67)
        Me.lblLine1.Name = "lblLine1"
        Me.lblLine1.Size = New System.Drawing.Size(679, 1)
        Me.lblLine1.TabIndex = 37
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(486, 16)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(179, 23)
        Me.cmdClose.TabIndex = 36
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'chkCR
        '
        Me.chkCR.AutoSize = True
        Me.chkCR.Location = New System.Drawing.Point(380, 73)
        Me.chkCR.Name = "chkCR"
        Me.chkCR.Size = New System.Drawing.Size(46, 17)
        Me.chkCR.TabIndex = 35
        Me.chkCR.Text = "C/R"
        Me.chkCR.UseVisualStyleBackColor = True
        '
        'chkNR
        '
        Me.chkNR.AutoSize = True
        Me.chkNR.Location = New System.Drawing.Point(333, 73)
        Me.chkNR.Name = "chkNR"
        Me.chkNR.Size = New System.Drawing.Size(47, 17)
        Me.chkNR.TabIndex = 34
        Me.chkNR.Text = "N/R"
        Me.chkNR.UseVisualStyleBackColor = True
        '
        'chkPending
        '
        Me.chkPending.AutoSize = True
        Me.chkPending.Location = New System.Drawing.Point(268, 73)
        Me.chkPending.Name = "chkPending"
        Me.chkPending.Size = New System.Drawing.Size(65, 17)
        Me.chkPending.TabIndex = 33
        Me.chkPending.Text = "Pending"
        Me.chkPending.UseVisualStyleBackColor = True
        '
        'chkDelivered
        '
        Me.chkDelivered.AutoSize = True
        Me.chkDelivered.Location = New System.Drawing.Point(198, 73)
        Me.chkDelivered.Name = "chkDelivered"
        Me.chkDelivered.Size = New System.Drawing.Size(71, 17)
        Me.chkDelivered.TabIndex = 32
        Me.chkDelivered.Text = "Delivered"
        Me.chkDelivered.UseVisualStyleBackColor = True
        '
        'chkRepaired
        '
        Me.chkRepaired.AutoSize = True
        Me.chkRepaired.Location = New System.Drawing.Point(131, 73)
        Me.chkRepaired.Name = "chkRepaired"
        Me.chkRepaired.Size = New System.Drawing.Size(69, 17)
        Me.chkRepaired.TabIndex = 31
        Me.chkRepaired.Text = "Repaired"
        Me.chkRepaired.UseVisualStyleBackColor = True
        '
        'chkWaitingforService
        '
        Me.chkWaitingforService.AutoSize = True
        Me.chkWaitingforService.Location = New System.Drawing.Point(18, 73)
        Me.chkWaitingforService.Name = "chkWaitingforService"
        Me.chkWaitingforService.Size = New System.Drawing.Size(116, 17)
        Me.chkWaitingforService.TabIndex = 30
        Me.chkWaitingforService.Text = "Waiting for Service"
        Me.chkWaitingforService.UseVisualStyleBackColor = True
        '
        'cmdShowReport
        '
        Me.cmdShowReport.Location = New System.Drawing.Point(307, 16)
        Me.cmdShowReport.Name = "cmdShowReport"
        Me.cmdShowReport.Size = New System.Drawing.Size(179, 23)
        Me.cmdShowReport.TabIndex = 29
        Me.cmdShowReport.Text = "Show Report"
        Me.cmdShowReport.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(161, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "To:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "From:"
        '
        'dtpTo
        '
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTo.Location = New System.Drawing.Point(190, 17)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(101, 20)
        Me.dtpTo.TabIndex = 21
        Me.dtpTo.Value = New Date(2017, 3, 1, 0, 0, 0, 0)
        '
        'dtpFrom
        '
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFrom.Location = New System.Drawing.Point(47, 17)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(101, 20)
        Me.dtpFrom.TabIndex = 20
        Me.dtpFrom.Value = New Date(2017, 3, 1, 0, 0, 0, 0)
        '
        'chkReportServiceWarranty
        '
        Me.chkReportServiceWarranty.AutoSize = True
        Me.chkReportServiceWarranty.Location = New System.Drawing.Point(218, 46)
        Me.chkReportServiceWarranty.Name = "chkReportServiceWarranty"
        Me.chkReportServiceWarranty.Size = New System.Drawing.Size(108, 17)
        Me.chkReportServiceWarranty.TabIndex = 19
        Me.chkReportServiceWarranty.Text = "Service Warranty"
        Me.chkReportServiceWarranty.UseVisualStyleBackColor = True
        '
        'chkReportNonWarranty
        '
        Me.chkReportNonWarranty.AutoSize = True
        Me.chkReportNonWarranty.Location = New System.Drawing.Point(121, 46)
        Me.chkReportNonWarranty.Name = "chkReportNonWarranty"
        Me.chkReportNonWarranty.Size = New System.Drawing.Size(92, 17)
        Me.chkReportNonWarranty.TabIndex = 18
        Me.chkReportNonWarranty.Text = "Non Warranty"
        Me.chkReportNonWarranty.UseVisualStyleBackColor = True
        '
        'chkReportSalesWarranty
        '
        Me.chkReportSalesWarranty.AutoSize = True
        Me.chkReportSalesWarranty.Location = New System.Drawing.Point(18, 46)
        Me.chkReportSalesWarranty.Name = "chkReportSalesWarranty"
        Me.chkReportSalesWarranty.Size = New System.Drawing.Size(98, 17)
        Me.chkReportSalesWarranty.TabIndex = 17
        Me.chkReportSalesWarranty.Text = "Sales Warranty"
        Me.chkReportSalesWarranty.UseVisualStyleBackColor = True
        '
        'grpGroupSelection
        '
        Me.grpGroupSelection.Controls.Add(Me.txtSearchModel)
        Me.grpGroupSelection.Controls.Add(Me.SearchModel)
        Me.grpGroupSelection.Controls.Add(Me.txtSearchBrand)
        Me.grpGroupSelection.Controls.Add(Me.SearchBrand)
        Me.grpGroupSelection.Controls.Add(Me.txtSearchCategory)
        Me.grpGroupSelection.Controls.Add(Me.SearchCategory)
        Me.grpGroupSelection.Controls.Add(Me.txtSearchBranch)
        Me.grpGroupSelection.Controls.Add(Me.SearchBranch)
        Me.grpGroupSelection.Controls.Add(Me.lstReportModel)
        Me.grpGroupSelection.Controls.Add(Me.lstReportBrand)
        Me.grpGroupSelection.Controls.Add(Me.lstReportCategory)
        Me.grpGroupSelection.Controls.Add(Me.lstReportBranch)
        Me.grpGroupSelection.Controls.Add(Me.chkReportModel)
        Me.grpGroupSelection.Controls.Add(Me.chkReportBrand)
        Me.grpGroupSelection.Controls.Add(Me.chkReportCategory)
        Me.grpGroupSelection.Controls.Add(Me.chkReportBranch)
        Me.grpGroupSelection.Location = New System.Drawing.Point(11, 179)
        Me.grpGroupSelection.Name = "grpGroupSelection"
        Me.grpGroupSelection.Size = New System.Drawing.Size(684, 277)
        Me.grpGroupSelection.TabIndex = 15
        Me.grpGroupSelection.TabStop = False
        '
        'txtSearchModel
        '
        Me.txtSearchModel.Location = New System.Drawing.Point(523, 249)
        Me.txtSearchModel.Name = "txtSearchModel"
        Me.txtSearchModel.Size = New System.Drawing.Size(132, 20)
        Me.txtSearchModel.TabIndex = 43
        '
        'SearchModel
        '
        Me.SearchModel.BackColor = System.Drawing.SystemColors.Control
        Me.SearchModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SearchModel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SearchModel.Image = Global.Service_Software.My.Resources.Resources.search_480
        Me.SearchModel.Location = New System.Drawing.Point(658, 248)
        Me.SearchModel.Name = "SearchModel"
        Me.SearchModel.Size = New System.Drawing.Size(22, 22)
        Me.SearchModel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SearchModel.TabIndex = 42
        Me.SearchModel.TabStop = False
        '
        'txtSearchBrand
        '
        Me.txtSearchBrand.Location = New System.Drawing.Point(355, 249)
        Me.txtSearchBrand.Name = "txtSearchBrand"
        Me.txtSearchBrand.Size = New System.Drawing.Size(132, 20)
        Me.txtSearchBrand.TabIndex = 41
        '
        'SearchBrand
        '
        Me.SearchBrand.BackColor = System.Drawing.SystemColors.Control
        Me.SearchBrand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SearchBrand.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SearchBrand.Image = Global.Service_Software.My.Resources.Resources.search_480
        Me.SearchBrand.Location = New System.Drawing.Point(490, 248)
        Me.SearchBrand.Name = "SearchBrand"
        Me.SearchBrand.Size = New System.Drawing.Size(22, 22)
        Me.SearchBrand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SearchBrand.TabIndex = 40
        Me.SearchBrand.TabStop = False
        '
        'txtSearchCategory
        '
        Me.txtSearchCategory.Location = New System.Drawing.Point(183, 249)
        Me.txtSearchCategory.Name = "txtSearchCategory"
        Me.txtSearchCategory.Size = New System.Drawing.Size(132, 20)
        Me.txtSearchCategory.TabIndex = 39
        '
        'SearchCategory
        '
        Me.SearchCategory.BackColor = System.Drawing.SystemColors.Control
        Me.SearchCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SearchCategory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SearchCategory.Image = Global.Service_Software.My.Resources.Resources.search_480
        Me.SearchCategory.Location = New System.Drawing.Point(318, 248)
        Me.SearchCategory.Name = "SearchCategory"
        Me.SearchCategory.Size = New System.Drawing.Size(22, 22)
        Me.SearchCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SearchCategory.TabIndex = 38
        Me.SearchCategory.TabStop = False
        '
        'txtSearchBranch
        '
        Me.txtSearchBranch.Location = New System.Drawing.Point(10, 249)
        Me.txtSearchBranch.Name = "txtSearchBranch"
        Me.txtSearchBranch.Size = New System.Drawing.Size(132, 20)
        Me.txtSearchBranch.TabIndex = 37
        '
        'SearchBranch
        '
        Me.SearchBranch.BackColor = System.Drawing.SystemColors.Control
        Me.SearchBranch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SearchBranch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SearchBranch.Image = Global.Service_Software.My.Resources.Resources.search_480
        Me.SearchBranch.Location = New System.Drawing.Point(145, 248)
        Me.SearchBranch.Name = "SearchBranch"
        Me.SearchBranch.Size = New System.Drawing.Size(22, 22)
        Me.SearchBranch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.SearchBranch.TabIndex = 36
        Me.SearchBranch.TabStop = False
        '
        'lstReportModel
        '
        Me.lstReportModel.BackColor = System.Drawing.Color.Wheat
        Me.lstReportModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstReportModel.CheckBoxes = True
        Me.lstReportModel.FullRowSelect = True
        Me.lstReportModel.Location = New System.Drawing.Point(525, 36)
        Me.lstReportModel.Name = "lstReportModel"
        Me.lstReportModel.Size = New System.Drawing.Size(154, 210)
        Me.lstReportModel.TabIndex = 31
        Me.lstReportModel.UseCompatibleStateImageBehavior = False
        Me.lstReportModel.View = System.Windows.Forms.View.Details
        '
        'lstReportBrand
        '
        Me.lstReportBrand.BackColor = System.Drawing.Color.Wheat
        Me.lstReportBrand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstReportBrand.CheckBoxes = True
        Me.lstReportBrand.FullRowSelect = True
        Me.lstReportBrand.Location = New System.Drawing.Point(357, 36)
        Me.lstReportBrand.Name = "lstReportBrand"
        Me.lstReportBrand.Size = New System.Drawing.Size(153, 210)
        Me.lstReportBrand.TabIndex = 30
        Me.lstReportBrand.UseCompatibleStateImageBehavior = False
        Me.lstReportBrand.View = System.Windows.Forms.View.Details
        '
        'lstReportCategory
        '
        Me.lstReportCategory.BackColor = System.Drawing.Color.Wheat
        Me.lstReportCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstReportCategory.CheckBoxes = True
        Me.lstReportCategory.FullRowSelect = True
        Me.lstReportCategory.Location = New System.Drawing.Point(183, 36)
        Me.lstReportCategory.Name = "lstReportCategory"
        Me.lstReportCategory.Size = New System.Drawing.Size(158, 210)
        Me.lstReportCategory.TabIndex = 29
        Me.lstReportCategory.UseCompatibleStateImageBehavior = False
        Me.lstReportCategory.View = System.Windows.Forms.View.Details
        '
        'lstReportBranch
        '
        Me.lstReportBranch.BackColor = System.Drawing.Color.Wheat
        Me.lstReportBranch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstReportBranch.CheckBoxes = True
        Me.lstReportBranch.FullRowSelect = True
        Me.lstReportBranch.Location = New System.Drawing.Point(10, 36)
        Me.lstReportBranch.Name = "lstReportBranch"
        Me.lstReportBranch.Size = New System.Drawing.Size(157, 210)
        Me.lstReportBranch.TabIndex = 28
        Me.lstReportBranch.UseCompatibleStateImageBehavior = False
        Me.lstReportBranch.View = System.Windows.Forms.View.Details
        '
        'chkReportModel
        '
        Me.chkReportModel.AutoSize = True
        Me.chkReportModel.Location = New System.Drawing.Point(525, 18)
        Me.chkReportModel.Name = "chkReportModel"
        Me.chkReportModel.Size = New System.Drawing.Size(70, 17)
        Me.chkReportModel.TabIndex = 35
        Me.chkReportModel.Text = "Select All"
        Me.chkReportModel.UseVisualStyleBackColor = True
        '
        'chkReportBrand
        '
        Me.chkReportBrand.AutoSize = True
        Me.chkReportBrand.Location = New System.Drawing.Point(357, 18)
        Me.chkReportBrand.Name = "chkReportBrand"
        Me.chkReportBrand.Size = New System.Drawing.Size(70, 17)
        Me.chkReportBrand.TabIndex = 34
        Me.chkReportBrand.Text = "Select All"
        Me.chkReportBrand.UseVisualStyleBackColor = True
        '
        'chkReportCategory
        '
        Me.chkReportCategory.AutoSize = True
        Me.chkReportCategory.Location = New System.Drawing.Point(183, 18)
        Me.chkReportCategory.Name = "chkReportCategory"
        Me.chkReportCategory.Size = New System.Drawing.Size(70, 17)
        Me.chkReportCategory.TabIndex = 33
        Me.chkReportCategory.Text = "Select All"
        Me.chkReportCategory.UseVisualStyleBackColor = True
        '
        'chkReportBranch
        '
        Me.chkReportBranch.AutoSize = True
        Me.chkReportBranch.Location = New System.Drawing.Point(10, 18)
        Me.chkReportBranch.Name = "chkReportBranch"
        Me.chkReportBranch.Size = New System.Drawing.Size(70, 17)
        Me.chkReportBranch.TabIndex = 32
        Me.chkReportBranch.Text = "Select All"
        Me.chkReportBranch.UseVisualStyleBackColor = True
        '
        'grpSingleSelection
        '
        Me.grpSingleSelection.Controls.Add(Me.Label8)
        Me.grpSingleSelection.Controls.Add(Me.cmbModel)
        Me.grpSingleSelection.Controls.Add(Me.Label7)
        Me.grpSingleSelection.Controls.Add(Me.Label6)
        Me.grpSingleSelection.Controls.Add(Me.Label5)
        Me.grpSingleSelection.Controls.Add(Me.cmbBrand)
        Me.grpSingleSelection.Controls.Add(Me.cmbCategory)
        Me.grpSingleSelection.Controls.Add(Me.cmbBranch)
        Me.grpSingleSelection.Location = New System.Drawing.Point(11, 123)
        Me.grpSingleSelection.Name = "grpSingleSelection"
        Me.grpSingleSelection.Size = New System.Drawing.Size(684, 40)
        Me.grpSingleSelection.TabIndex = 16
        Me.grpSingleSelection.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(519, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Model"
        '
        'cmbModel
        '
        Me.cmbModel.FormattingEnabled = True
        Me.cmbModel.Location = New System.Drawing.Point(556, 13)
        Me.cmbModel.Name = "cmbModel"
        Me.cmbModel.Size = New System.Drawing.Size(122, 21)
        Me.cmbModel.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(356, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Brand"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(177, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Category"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Branch"
        '
        'cmbBrand
        '
        Me.cmbBrand.FormattingEnabled = True
        Me.cmbBrand.Location = New System.Drawing.Point(393, 13)
        Me.cmbBrand.Name = "cmbBrand"
        Me.cmbBrand.Size = New System.Drawing.Size(122, 21)
        Me.cmbBrand.TabIndex = 2
        '
        'cmbCategory
        '
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(228, 13)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(122, 21)
        Me.cmbCategory.TabIndex = 1
        '
        'cmbBranch
        '
        Me.cmbBranch.FormattingEnabled = True
        Me.cmbBranch.Location = New System.Drawing.Point(51, 13)
        Me.cmbBranch.Name = "cmbBranch"
        Me.cmbBranch.Size = New System.Drawing.Size(122, 21)
        Me.cmbBranch.TabIndex = 0
        '
        'optSingleSelection
        '
        Me.optSingleSelection.AutoSize = True
        Me.optSingleSelection.Checked = True
        Me.optSingleSelection.Location = New System.Drawing.Point(14, 111)
        Me.optSingleSelection.Name = "optSingleSelection"
        Me.optSingleSelection.Size = New System.Drawing.Size(107, 17)
        Me.optSingleSelection.TabIndex = 17
        Me.optSingleSelection.TabStop = True
        Me.optSingleSelection.Text = "Single Selectioon"
        Me.optSingleSelection.UseVisualStyleBackColor = True
        '
        'optGroupSelection
        '
        Me.optGroupSelection.AutoSize = True
        Me.optGroupSelection.Location = New System.Drawing.Point(14, 168)
        Me.optGroupSelection.Name = "optGroupSelection"
        Me.optGroupSelection.Size = New System.Drawing.Size(101, 17)
        Me.optGroupSelection.TabIndex = 18
        Me.optGroupSelection.Text = "Group Selection"
        Me.optGroupSelection.UseVisualStyleBackColor = True
        '
        'chkSalesWarrPrice
        '
        Me.chkSalesWarrPrice.AutoSize = True
        Me.chkSalesWarrPrice.Location = New System.Drawing.Point(164, 107)
        Me.chkSalesWarrPrice.Name = "chkSalesWarrPrice"
        Me.chkSalesWarrPrice.Size = New System.Drawing.Size(105, 17)
        Me.chkSalesWarrPrice.TabIndex = 46
        Me.chkSalesWarrPrice.Text = "Sales Warr Price"
        Me.chkSalesWarrPrice.UseVisualStyleBackColor = True
        Me.chkSalesWarrPrice.Visible = False
        '
        'frmMaster_information
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(704, 462)
        Me.Controls.Add(Me.optGroupSelection)
        Me.Controls.Add(Me.optSingleSelection)
        Me.Controls.Add(Me.grpSingleSelection)
        Me.Controls.Add(Me.grpGroupSelection)
        Me.Controls.Add(Me.grpStatus)
        Me.Name = "frmMaster_information"
        Me.Text = "Master Report"
        Me.grpStatus.ResumeLayout(False)
        Me.grpStatus.PerformLayout()
        Me.grpGroupSelection.ResumeLayout(False)
        Me.grpGroupSelection.PerformLayout()
        CType(Me.SearchModel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchBrand, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchBranch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSingleSelection.ResumeLayout(False)
        Me.grpSingleSelection.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpStatus As GroupBox
    Friend WithEvents chkReportServiceWarranty As CheckBox
    Friend WithEvents chkReportNonWarranty As CheckBox
    Friend WithEvents chkReportSalesWarranty As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents chkCR As CheckBox
    Friend WithEvents chkNR As CheckBox
    Friend WithEvents chkPending As CheckBox
    Friend WithEvents chkDelivered As CheckBox
    Friend WithEvents chkRepaired As CheckBox
    Friend WithEvents chkWaitingforService As CheckBox
    Friend WithEvents cmdShowReport As Button
    Friend WithEvents cmdClose As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblLine1 As Label
    Friend WithEvents chkReplaceDelivery As CheckBox
    Friend WithEvents chkReplace As CheckBox
    Friend WithEvents optByDelivery As RadioButton
    Friend WithEvents optByRepaired As RadioButton
    Friend WithEvents optByReceive As RadioButton
    Friend WithEvents chkEstimateRefuse As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents grpGroupSelection As GroupBox
    Friend WithEvents lstReportModel As ListView
    Friend WithEvents lstReportBrand As ListView
    Friend WithEvents lstReportCategory As ListView
    Friend WithEvents lstReportBranch As ListView
    Friend WithEvents chkReportModel As CheckBox
    Friend WithEvents chkReportBrand As CheckBox
    Friend WithEvents chkReportCategory As CheckBox
    Friend WithEvents chkReportBranch As CheckBox
    Friend WithEvents grpSingleSelection As GroupBox
    Friend WithEvents optSingleSelection As RadioButton
    Friend WithEvents optGroupSelection As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbModel As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbBrand As ComboBox
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents cmbBranch As ComboBox
    Friend WithEvents txtSearchModel As TextBox
    Friend WithEvents SearchModel As PictureBox
    Friend WithEvents txtSearchBrand As TextBox
    Friend WithEvents SearchBrand As PictureBox
    Friend WithEvents txtSearchCategory As TextBox
    Friend WithEvents SearchCategory As PictureBox
    Friend WithEvents txtSearchBranch As TextBox
    Friend WithEvents SearchBranch As PictureBox
    Friend WithEvents chkSalesWarrPrice As CheckBox
End Class
