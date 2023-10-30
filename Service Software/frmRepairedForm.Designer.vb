<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRepairedForm
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
        Me.lstRepairedStatus = New System.Windows.Forms.ListView()
        Me.colSL = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colJob = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colBranch = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCategory = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColSlNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colReceiveDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colRepair = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDelDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colWarr = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMrNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colAmount = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDescription = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstCategory = New System.Windows.Forms.ListView()
        Me.cmbBrand = New System.Windows.Forms.ComboBox()
        Me.cmdLoadData = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.lblBrand = New System.Windows.Forms.Label()
        Me.DirectoryEntry1 = New System.DirectoryServices.DirectoryEntry()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.LBLdtpto = New System.Windows.Forms.Label()
        Me.lbldtpFrom = New System.Windows.Forms.Label()
        Me.grpProductStatus = New System.Windows.Forms.GroupBox()
        Me.optSAll = New System.Windows.Forms.RadioButton()
        Me.optDelivery = New System.Windows.Forms.RadioButton()
        Me.optRepaired = New System.Windows.Forms.RadioButton()
        Me.optReceive = New System.Windows.Forms.RadioButton()
        Me.grpWarrantyType = New System.Windows.Forms.GroupBox()
        Me.optSvcWarranty = New System.Windows.Forms.RadioButton()
        Me.optNonWarranty = New System.Windows.Forms.RadioButton()
        Me.optSlsWarranty = New System.Windows.Forms.RadioButton()
        Me.optAll = New System.Windows.Forms.RadioButton()
        Me.chkSlsWarrantyPrice = New System.Windows.Forms.CheckBox()
        Me.grpProductStatus.SuspendLayout()
        Me.grpWarrantyType.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstRepairedStatus
        '
        Me.lstRepairedStatus.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colSL, Me.colJob, Me.colBranch, Me.colCategory, Me.colModel, Me.ColSlNo, Me.colReceiveDate, Me.colRepair, Me.colDelDate, Me.colWarr, Me.colMrNo, Me.colAmount, Me.colDescription})
        Me.lstRepairedStatus.Location = New System.Drawing.Point(12, 148)
        Me.lstRepairedStatus.Name = "lstRepairedStatus"
        Me.lstRepairedStatus.Size = New System.Drawing.Size(1029, 246)
        Me.lstRepairedStatus.TabIndex = 0
        Me.lstRepairedStatus.UseCompatibleStateImageBehavior = False
        Me.lstRepairedStatus.View = System.Windows.Forms.View.Details
        '
        'colSL
        '
        Me.colSL.Text = "SL"
        '
        'colJob
        '
        Me.colJob.Text = "Job Code"
        '
        'colBranch
        '
        Me.colBranch.Text = "Branch"
        '
        'colCategory
        '
        Me.colCategory.Text = "Category"
        '
        'colModel
        '
        Me.colModel.Text = "Model"
        '
        'ColSlNo
        '
        Me.ColSlNo.Text = "Sl No."
        '
        'colReceiveDate
        '
        Me.colReceiveDate.Text = "Rcvd Date"
        '
        'colRepair
        '
        Me.colRepair.Text = "Repair Date"
        '
        'colDelDate
        '
        Me.colDelDate.Text = "Del. Date"
        '
        'colWarr
        '
        Me.colWarr.Text = "Warr-Type"
        Me.colWarr.Width = 300
        '
        'colMrNo
        '
        Me.colMrNo.Text = "Mr No."
        '
        'colAmount
        '
        Me.colAmount.Text = "Amount"
        '
        'colDescription
        '
        Me.colDescription.Text = "Description"
        '
        'lstCategory
        '
        Me.lstCategory.CheckBoxes = True
        Me.lstCategory.GridLines = True
        Me.lstCategory.Location = New System.Drawing.Point(12, 44)
        Me.lstCategory.Name = "lstCategory"
        Me.lstCategory.Size = New System.Drawing.Size(770, 94)
        Me.lstCategory.TabIndex = 1
        Me.lstCategory.UseCompatibleStateImageBehavior = False
        Me.lstCategory.View = System.Windows.Forms.View.List
        '
        'cmbBrand
        '
        Me.cmbBrand.DropDownHeight = 90
        Me.cmbBrand.FormattingEnabled = True
        Me.cmbBrand.IntegralHeight = False
        Me.cmbBrand.Location = New System.Drawing.Point(118, 9)
        Me.cmbBrand.Name = "cmbBrand"
        Me.cmbBrand.Size = New System.Drawing.Size(121, 21)
        Me.cmbBrand.TabIndex = 2
        '
        'cmdLoadData
        '
        Me.cmdLoadData.Location = New System.Drawing.Point(245, 8)
        Me.cmdLoadData.Name = "cmdLoadData"
        Me.cmdLoadData.Size = New System.Drawing.Size(75, 23)
        Me.cmdLoadData.TabIndex = 3
        Me.cmdLoadData.Text = "Load &Data"
        Me.cmdLoadData.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(326, 8)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 4
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'lblBrand
        '
        Me.lblBrand.AutoSize = True
        Me.lblBrand.Location = New System.Drawing.Point(54, 13)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.Size = New System.Drawing.Size(38, 13)
        Me.lblBrand.TabIndex = 5
        Me.lblBrand.Text = "Brand:"
        '
        'dtpFrom
        '
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFrom.Location = New System.Drawing.Point(445, 9)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(80, 20)
        Me.dtpFrom.TabIndex = 6
        '
        'dtpTo
        '
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTo.Location = New System.Drawing.Point(554, 9)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(80, 20)
        Me.dtpTo.TabIndex = 7
        '
        'LBLdtpto
        '
        Me.LBLdtpto.AutoSize = True
        Me.LBLdtpto.Location = New System.Drawing.Point(531, 13)
        Me.LBLdtpto.Name = "LBLdtpto"
        Me.LBLdtpto.Size = New System.Drawing.Size(20, 13)
        Me.LBLdtpto.TabIndex = 8
        Me.LBLdtpto.Text = "To"
        '
        'lbldtpFrom
        '
        Me.lbldtpFrom.AutoSize = True
        Me.lbldtpFrom.Location = New System.Drawing.Point(406, 13)
        Me.lbldtpFrom.Name = "lbldtpFrom"
        Me.lbldtpFrom.Size = New System.Drawing.Size(33, 13)
        Me.lbldtpFrom.TabIndex = 9
        Me.lbldtpFrom.Text = "From:"
        '
        'grpProductStatus
        '
        Me.grpProductStatus.Controls.Add(Me.optSAll)
        Me.grpProductStatus.Controls.Add(Me.optDelivery)
        Me.grpProductStatus.Controls.Add(Me.optRepaired)
        Me.grpProductStatus.Controls.Add(Me.optReceive)
        Me.grpProductStatus.Location = New System.Drawing.Point(642, 2)
        Me.grpProductStatus.Name = "grpProductStatus"
        Me.grpProductStatus.Size = New System.Drawing.Size(256, 35)
        Me.grpProductStatus.TabIndex = 14
        Me.grpProductStatus.TabStop = False
        '
        'optSAll
        '
        Me.optSAll.AutoSize = True
        Me.optSAll.Location = New System.Drawing.Point(6, 11)
        Me.optSAll.Name = "optSAll"
        Me.optSAll.Size = New System.Drawing.Size(36, 17)
        Me.optSAll.TabIndex = 20
        Me.optSAll.TabStop = True
        Me.optSAll.Text = "All"
        Me.optSAll.UseVisualStyleBackColor = True
        '
        'optDelivery
        '
        Me.optDelivery.AutoSize = True
        Me.optDelivery.Location = New System.Drawing.Point(193, 11)
        Me.optDelivery.Name = "optDelivery"
        Me.optDelivery.Size = New System.Drawing.Size(63, 17)
        Me.optDelivery.TabIndex = 19
        Me.optDelivery.TabStop = True
        Me.optDelivery.Text = "Delivery"
        Me.optDelivery.UseVisualStyleBackColor = True
        '
        'optRepaired
        '
        Me.optRepaired.AutoSize = True
        Me.optRepaired.Location = New System.Drawing.Point(116, 11)
        Me.optRepaired.Name = "optRepaired"
        Me.optRepaired.Size = New System.Drawing.Size(68, 17)
        Me.optRepaired.TabIndex = 18
        Me.optRepaired.TabStop = True
        Me.optRepaired.Text = "Repaired"
        Me.optRepaired.UseVisualStyleBackColor = True
        '
        'optReceive
        '
        Me.optReceive.AutoSize = True
        Me.optReceive.Location = New System.Drawing.Point(45, 11)
        Me.optReceive.Name = "optReceive"
        Me.optReceive.Size = New System.Drawing.Size(65, 17)
        Me.optReceive.TabIndex = 17
        Me.optReceive.TabStop = True
        Me.optReceive.Text = "Receive"
        Me.optReceive.UseVisualStyleBackColor = True
        '
        'grpWarrantyType
        '
        Me.grpWarrantyType.Controls.Add(Me.optSvcWarranty)
        Me.grpWarrantyType.Controls.Add(Me.optNonWarranty)
        Me.grpWarrantyType.Controls.Add(Me.optSlsWarranty)
        Me.grpWarrantyType.Controls.Add(Me.optAll)
        Me.grpWarrantyType.Location = New System.Drawing.Point(919, 2)
        Me.grpWarrantyType.Name = "grpWarrantyType"
        Me.grpWarrantyType.Size = New System.Drawing.Size(275, 35)
        Me.grpWarrantyType.TabIndex = 15
        Me.grpWarrantyType.TabStop = False
        '
        'optSvcWarranty
        '
        Me.optSvcWarranty.AutoSize = True
        Me.optSvcWarranty.Location = New System.Drawing.Point(205, 11)
        Me.optSvcWarranty.Name = "optSvcWarranty"
        Me.optSvcWarranty.Size = New System.Drawing.Size(70, 17)
        Me.optSvcWarranty.TabIndex = 17
        Me.optSvcWarranty.TabStop = True
        Me.optSvcWarranty.Text = "Svc-Warr"
        Me.optSvcWarranty.UseVisualStyleBackColor = True
        '
        'optNonWarranty
        '
        Me.optNonWarranty.AutoSize = True
        Me.optNonWarranty.Location = New System.Drawing.Point(128, 11)
        Me.optNonWarranty.Name = "optNonWarranty"
        Me.optNonWarranty.Size = New System.Drawing.Size(71, 17)
        Me.optNonWarranty.TabIndex = 16
        Me.optNonWarranty.TabStop = True
        Me.optNonWarranty.Text = "Non-Warr"
        Me.optNonWarranty.UseVisualStyleBackColor = True
        '
        'optSlsWarranty
        '
        Me.optSlsWarranty.AutoSize = True
        Me.optSlsWarranty.Location = New System.Drawing.Point(57, 11)
        Me.optSlsWarranty.Name = "optSlsWarranty"
        Me.optSlsWarranty.Size = New System.Drawing.Size(65, 17)
        Me.optSlsWarranty.TabIndex = 15
        Me.optSlsWarranty.TabStop = True
        Me.optSlsWarranty.Text = "Sls-Warr"
        Me.optSlsWarranty.UseVisualStyleBackColor = True
        '
        'optAll
        '
        Me.optAll.AutoSize = True
        Me.optAll.Location = New System.Drawing.Point(15, 11)
        Me.optAll.Name = "optAll"
        Me.optAll.Size = New System.Drawing.Size(36, 17)
        Me.optAll.TabIndex = 14
        Me.optAll.TabStop = True
        Me.optAll.Text = "All"
        Me.optAll.UseVisualStyleBackColor = True
        '
        'chkSlsWarrantyPrice
        '
        Me.chkSlsWarrantyPrice.AutoSize = True
        Me.chkSlsWarrantyPrice.Location = New System.Drawing.Point(1200, 11)
        Me.chkSlsWarrantyPrice.Name = "chkSlsWarrantyPrice"
        Me.chkSlsWarrantyPrice.Size = New System.Drawing.Size(81, 17)
        Me.chkSlsWarrantyPrice.TabIndex = 16
        Me.chkSlsWarrantyPrice.Text = "CheckBox1"
        Me.chkSlsWarrantyPrice.UseVisualStyleBackColor = True
        '
        'frmRepairedForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 562)
        Me.Controls.Add(Me.chkSlsWarrantyPrice)
        Me.Controls.Add(Me.grpWarrantyType)
        Me.Controls.Add(Me.grpProductStatus)
        Me.Controls.Add(Me.lbldtpFrom)
        Me.Controls.Add(Me.LBLdtpto)
        Me.Controls.Add(Me.dtpTo)
        Me.Controls.Add(Me.dtpFrom)
        Me.Controls.Add(Me.lblBrand)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdLoadData)
        Me.Controls.Add(Me.cmbBrand)
        Me.Controls.Add(Me.lstCategory)
        Me.Controls.Add(Me.lstRepairedStatus)
        Me.Name = "frmRepairedForm"
        Me.Text = "frmRepairedForm"
        Me.grpProductStatus.ResumeLayout(False)
        Me.grpProductStatus.PerformLayout()
        Me.grpWarrantyType.ResumeLayout(False)
        Me.grpWarrantyType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstRepairedStatus As ListView
    Friend WithEvents colSL As ColumnHeader
    Friend WithEvents colJob As ColumnHeader
    Friend WithEvents colBranch As ColumnHeader
    Friend WithEvents colCategory As ColumnHeader
    Friend WithEvents colModel As ColumnHeader
    Friend WithEvents ColSlNo As ColumnHeader
    Friend WithEvents colReceiveDate As ColumnHeader
    Friend WithEvents colRepair As ColumnHeader
    Friend WithEvents colDelDate As ColumnHeader
    Friend WithEvents colWarr As ColumnHeader
    Friend WithEvents lstCategory As ListView
    Friend WithEvents cmbBrand As ComboBox
    Friend WithEvents cmdLoadData As Button
    Friend WithEvents cmdClose As Button
    Friend WithEvents lblBrand As Label
    Friend WithEvents DirectoryEntry1 As DirectoryServices.DirectoryEntry
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents LBLdtpto As Label
    Friend WithEvents lbldtpFrom As Label
    Friend WithEvents colMrNo As ColumnHeader
    Friend WithEvents colAmount As ColumnHeader
    Friend WithEvents colDescription As ColumnHeader
    Friend WithEvents grpProductStatus As GroupBox
    Friend WithEvents optDelivery As RadioButton
    Friend WithEvents optRepaired As RadioButton
    Friend WithEvents optReceive As RadioButton
    Friend WithEvents optSAll As RadioButton
    Friend WithEvents grpWarrantyType As GroupBox
    Friend WithEvents optSvcWarranty As RadioButton
    Friend WithEvents optNonWarranty As RadioButton
    Friend WithEvents optSlsWarranty As RadioButton
    Friend WithEvents optAll As RadioButton
    Friend WithEvents chkSlsWarrantyPrice As CheckBox
End Class
