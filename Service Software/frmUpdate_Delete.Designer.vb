<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUpdate_Delete
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
        Me.tbPriceUpdate = New System.Windows.Forms.TabControl()
        Me.tbpPriceUpdate = New System.Windows.Forms.TabPage()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.grpModel = New System.Windows.Forms.GroupBox()
        Me.optWithoutCharge = New System.Windows.Forms.RadioButton()
        Me.optAll = New System.Windows.Forms.RadioButton()
        Me.lstModelDetails = New System.Windows.Forms.ListView()
        Me.colModelSL = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colModelCharge = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colModelWarrPeriod = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colModelItem = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colModelSerial = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColModelSize = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colModelRemarks = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chkSelectAll = New System.Windows.Forms.CheckBox()
        Me.grpBrand = New System.Windows.Forms.GroupBox()
        Me.lblNotification = New System.Windows.Forms.Label()
        Me.txtSetValue = New System.Windows.Forms.TextBox()
        Me.lblValue = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbField = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbBrand = New System.Windows.Forms.ComboBox()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.tbpDeleteCategory = New System.Windows.Forms.TabPage()
        Me.lblLine1 = New System.Windows.Forms.Label()
        Me.lblDeleteRemarks = New System.Windows.Forms.Label()
        Me.cmdLoadModel = New System.Windows.Forms.Button()
        Me.cmdDeleteClose = New System.Windows.Forms.Button()
        Me.cmdDeleteClear = New System.Windows.Forms.Button()
        Me.chkDeleteBrand = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbDeleteBrand = New System.Windows.Forms.ComboBox()
        Me.cmbDeleteCategory = New System.Windows.Forms.ComboBox()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.optCustomDelete = New System.Windows.Forms.RadioButton()
        Me.grpcustomDelete = New System.Windows.Forms.GroupBox()
        Me.lstDeleteModel = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.optQuickDelete = New System.Windows.Forms.RadioButton()
        Me.tbPriceUpdate.SuspendLayout()
        Me.tbpPriceUpdate.SuspendLayout()
        Me.grpModel.SuspendLayout()
        Me.grpBrand.SuspendLayout()
        Me.tbpDeleteCategory.SuspendLayout()
        Me.grpcustomDelete.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbPriceUpdate
        '
        Me.tbPriceUpdate.Controls.Add(Me.tbpPriceUpdate)
        Me.tbPriceUpdate.Controls.Add(Me.tbpDeleteCategory)
        Me.tbPriceUpdate.Location = New System.Drawing.Point(3, 1)
        Me.tbPriceUpdate.Name = "tbPriceUpdate"
        Me.tbPriceUpdate.SelectedIndex = 0
        Me.tbPriceUpdate.Size = New System.Drawing.Size(781, 549)
        Me.tbPriceUpdate.TabIndex = 0
        '
        'tbpPriceUpdate
        '
        Me.tbpPriceUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tbpPriceUpdate.Controls.Add(Me.cmdUpdate)
        Me.tbpPriceUpdate.Controls.Add(Me.cmdClose)
        Me.tbpPriceUpdate.Controls.Add(Me.grpModel)
        Me.tbpPriceUpdate.Controls.Add(Me.grpBrand)
        Me.tbpPriceUpdate.Location = New System.Drawing.Point(4, 22)
        Me.tbpPriceUpdate.Name = "tbpPriceUpdate"
        Me.tbpPriceUpdate.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpPriceUpdate.Size = New System.Drawing.Size(773, 523)
        Me.tbpPriceUpdate.TabIndex = 0
        Me.tbpPriceUpdate.Text = "Price Update "
        '
        'cmdUpdate
        '
        Me.cmdUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdUpdate.Location = New System.Drawing.Point(383, 492)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(187, 23)
        Me.cmdUpdate.TabIndex = 5
        Me.cmdUpdate.Text = "&Update"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdClose.Location = New System.Drawing.Point(576, 492)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(187, 23)
        Me.cmdClose.TabIndex = 4
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'grpModel
        '
        Me.grpModel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpModel.Controls.Add(Me.optWithoutCharge)
        Me.grpModel.Controls.Add(Me.optAll)
        Me.grpModel.Controls.Add(Me.lstModelDetails)
        Me.grpModel.Controls.Add(Me.chkSelectAll)
        Me.grpModel.Location = New System.Drawing.Point(6, 51)
        Me.grpModel.Name = "grpModel"
        Me.grpModel.Size = New System.Drawing.Size(759, 428)
        Me.grpModel.TabIndex = 3
        Me.grpModel.TabStop = False
        '
        'optWithoutCharge
        '
        Me.optWithoutCharge.AutoSize = True
        Me.optWithoutCharge.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.optWithoutCharge.Location = New System.Drawing.Point(211, 11)
        Me.optWithoutCharge.Name = "optWithoutCharge"
        Me.optWithoutCharge.Size = New System.Drawing.Size(99, 17)
        Me.optWithoutCharge.TabIndex = 8
        Me.optWithoutCharge.TabStop = True
        Me.optWithoutCharge.Text = "Without &Charge"
        Me.optWithoutCharge.UseVisualStyleBackColor = True
        '
        'optAll
        '
        Me.optAll.AutoSize = True
        Me.optAll.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.optAll.Location = New System.Drawing.Point(115, 11)
        Me.optAll.Name = "optAll"
        Me.optAll.Size = New System.Drawing.Size(36, 17)
        Me.optAll.TabIndex = 7
        Me.optAll.TabStop = True
        Me.optAll.Text = "&All"
        Me.optAll.UseVisualStyleBackColor = True
        '
        'lstModelDetails
        '
        Me.lstModelDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.lstModelDetails.CheckBoxes = True
        Me.lstModelDetails.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colModelSL, Me.colModel, Me.colModelCharge, Me.colModelWarrPeriod, Me.colModelItem, Me.colModelSerial, Me.ColModelSize, Me.colModelRemarks})
        Me.lstModelDetails.GridLines = True
        Me.lstModelDetails.Location = New System.Drawing.Point(8, 31)
        Me.lstModelDetails.Name = "lstModelDetails"
        Me.lstModelDetails.Size = New System.Drawing.Size(749, 393)
        Me.lstModelDetails.TabIndex = 6
        Me.lstModelDetails.UseCompatibleStateImageBehavior = False
        Me.lstModelDetails.View = System.Windows.Forms.View.Details
        '
        'colModelSL
        '
        Me.colModelSL.Text = "SL."
        '
        'colModel
        '
        Me.colModel.Text = "Model"
        Me.colModel.Width = 130
        '
        'colModelCharge
        '
        Me.colModelCharge.Text = "Charge"
        Me.colModelCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colModelCharge.Width = 80
        '
        'colModelWarrPeriod
        '
        Me.colModelWarrPeriod.Text = "W.Period"
        Me.colModelWarrPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'colModelItem
        '
        Me.colModelItem.Text = "Item"
        Me.colModelItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colModelItem.Width = 80
        '
        'colModelSerial
        '
        Me.colModelSerial.Text = "Item SL"
        Me.colModelSerial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColModelSize
        '
        Me.ColModelSize.Text = "Size"
        Me.ColModelSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColModelSize.Width = 50
        '
        'colModelRemarks
        '
        Me.colModelRemarks.Text = "Remarks"
        Me.colModelRemarks.Width = 200
        '
        'chkSelectAll
        '
        Me.chkSelectAll.AutoSize = True
        Me.chkSelectAll.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkSelectAll.Location = New System.Drawing.Point(8, 11)
        Me.chkSelectAll.Name = "chkSelectAll"
        Me.chkSelectAll.Size = New System.Drawing.Size(70, 17)
        Me.chkSelectAll.TabIndex = 5
        Me.chkSelectAll.Text = "&Select All"
        Me.chkSelectAll.UseVisualStyleBackColor = True
        '
        'grpBrand
        '
        Me.grpBrand.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpBrand.Controls.Add(Me.lblNotification)
        Me.grpBrand.Controls.Add(Me.txtSetValue)
        Me.grpBrand.Controls.Add(Me.lblValue)
        Me.grpBrand.Controls.Add(Me.Label3)
        Me.grpBrand.Controls.Add(Me.cmbField)
        Me.grpBrand.Controls.Add(Me.Label2)
        Me.grpBrand.Controls.Add(Me.Label1)
        Me.grpBrand.Controls.Add(Me.cmbBrand)
        Me.grpBrand.Controls.Add(Me.cmbCategory)
        Me.grpBrand.Location = New System.Drawing.Point(6, 1)
        Me.grpBrand.Name = "grpBrand"
        Me.grpBrand.Size = New System.Drawing.Size(759, 46)
        Me.grpBrand.TabIndex = 2
        Me.grpBrand.TabStop = False
        '
        'lblNotification
        '
        Me.lblNotification.AutoSize = True
        Me.lblNotification.Location = New System.Drawing.Point(11, 40)
        Me.lblNotification.Name = "lblNotification"
        Me.lblNotification.Size = New System.Drawing.Size(0, 13)
        Me.lblNotification.TabIndex = 10
        '
        'txtSetValue
        '
        Me.txtSetValue.Location = New System.Drawing.Point(558, 13)
        Me.txtSetValue.Name = "txtSetValue"
        Me.txtSetValue.Size = New System.Drawing.Size(193, 20)
        Me.txtSetValue.TabIndex = 9
        '
        'lblValue
        '
        Me.lblValue.AutoSize = True
        Me.lblValue.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblValue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblValue.Location = New System.Drawing.Point(496, 17)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(53, 13)
        Me.lblValue.TabIndex = 8
        Me.lblValue.Text = "Set Value"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(337, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Field:"
        '
        'cmbField
        '
        Me.cmbField.DropDownHeight = 70
        Me.cmbField.FormattingEnabled = True
        Me.cmbField.IntegralHeight = False
        Me.cmbField.Location = New System.Drawing.Point(375, 13)
        Me.cmbField.Name = "cmbField"
        Me.cmbField.Size = New System.Drawing.Size(114, 21)
        Me.cmbField.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(178, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Brand:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(8, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Category:"
        '
        'cmbBrand
        '
        Me.cmbBrand.DropDownHeight = 50
        Me.cmbBrand.FormattingEnabled = True
        Me.cmbBrand.IntegralHeight = False
        Me.cmbBrand.Location = New System.Drawing.Point(216, 13)
        Me.cmbBrand.Name = "cmbBrand"
        Me.cmbBrand.Size = New System.Drawing.Size(114, 21)
        Me.cmbBrand.TabIndex = 3
        '
        'cmbCategory
        '
        Me.cmbCategory.DropDownHeight = 80
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.IntegralHeight = False
        Me.cmbCategory.Location = New System.Drawing.Point(62, 13)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(114, 21)
        Me.cmbCategory.TabIndex = 2
        '
        'tbpDeleteCategory
        '
        Me.tbpDeleteCategory.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tbpDeleteCategory.Controls.Add(Me.lblLine1)
        Me.tbpDeleteCategory.Controls.Add(Me.lblDeleteRemarks)
        Me.tbpDeleteCategory.Controls.Add(Me.cmdLoadModel)
        Me.tbpDeleteCategory.Controls.Add(Me.cmdDeleteClose)
        Me.tbpDeleteCategory.Controls.Add(Me.cmdDeleteClear)
        Me.tbpDeleteCategory.Controls.Add(Me.chkDeleteBrand)
        Me.tbpDeleteCategory.Controls.Add(Me.Label5)
        Me.tbpDeleteCategory.Controls.Add(Me.Label4)
        Me.tbpDeleteCategory.Controls.Add(Me.cmbDeleteBrand)
        Me.tbpDeleteCategory.Controls.Add(Me.cmbDeleteCategory)
        Me.tbpDeleteCategory.Controls.Add(Me.cmdDelete)
        Me.tbpDeleteCategory.Controls.Add(Me.optCustomDelete)
        Me.tbpDeleteCategory.Controls.Add(Me.grpcustomDelete)
        Me.tbpDeleteCategory.Controls.Add(Me.optQuickDelete)
        Me.tbpDeleteCategory.Location = New System.Drawing.Point(4, 22)
        Me.tbpDeleteCategory.Name = "tbpDeleteCategory"
        Me.tbpDeleteCategory.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpDeleteCategory.Size = New System.Drawing.Size(773, 523)
        Me.tbpDeleteCategory.TabIndex = 1
        Me.tbpDeleteCategory.Text = "Delete Brand/Model"
        '
        'lblLine1
        '
        Me.lblLine1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLine1.Location = New System.Drawing.Point(0, 38)
        Me.lblLine1.Name = "lblLine1"
        Me.lblLine1.Size = New System.Drawing.Size(774, 2)
        Me.lblLine1.TabIndex = 14
        '
        'lblDeleteRemarks
        '
        Me.lblDeleteRemarks.AutoSize = True
        Me.lblDeleteRemarks.Location = New System.Drawing.Point(434, 48)
        Me.lblDeleteRemarks.Name = "lblDeleteRemarks"
        Me.lblDeleteRemarks.Size = New System.Drawing.Size(0, 13)
        Me.lblDeleteRemarks.TabIndex = 13
        '
        'cmdLoadModel
        '
        Me.cmdLoadModel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdLoadModel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLoadModel.ForeColor = System.Drawing.Color.Maroon
        Me.cmdLoadModel.Location = New System.Drawing.Point(392, 10)
        Me.cmdLoadModel.Name = "cmdLoadModel"
        Me.cmdLoadModel.Size = New System.Drawing.Size(75, 23)
        Me.cmdLoadModel.TabIndex = 12
        Me.cmdLoadModel.Text = "Load Model"
        Me.cmdLoadModel.UseVisualStyleBackColor = True
        '
        'cmdDeleteClose
        '
        Me.cmdDeleteClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdDeleteClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDeleteClose.ForeColor = System.Drawing.Color.Maroon
        Me.cmdDeleteClose.Location = New System.Drawing.Point(635, 10)
        Me.cmdDeleteClose.Name = "cmdDeleteClose"
        Me.cmdDeleteClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdDeleteClose.TabIndex = 11
        Me.cmdDeleteClose.Text = "C&lose"
        Me.cmdDeleteClose.UseVisualStyleBackColor = True
        '
        'cmdDeleteClear
        '
        Me.cmdDeleteClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdDeleteClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDeleteClear.ForeColor = System.Drawing.Color.Maroon
        Me.cmdDeleteClear.Location = New System.Drawing.Point(554, 10)
        Me.cmdDeleteClear.Name = "cmdDeleteClear"
        Me.cmdDeleteClear.Size = New System.Drawing.Size(75, 23)
        Me.cmdDeleteClear.TabIndex = 10
        Me.cmdDeleteClear.Text = "&Clear"
        Me.cmdDeleteClear.UseVisualStyleBackColor = True
        '
        'chkDeleteBrand
        '
        Me.chkDeleteBrand.AutoSize = True
        Me.chkDeleteBrand.ForeColor = System.Drawing.Color.DarkBlue
        Me.chkDeleteBrand.Location = New System.Drawing.Point(256, 13)
        Me.chkDeleteBrand.Name = "chkDeleteBrand"
        Me.chkDeleteBrand.Size = New System.Drawing.Size(133, 17)
        Me.chkDeleteBrand.TabIndex = 9
        Me.chkDeleteBrand.Text = "Delete Permission OFF"
        Me.chkDeleteBrand.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(212, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Brand"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(17, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Category"
        '
        'cmbDeleteBrand
        '
        Me.cmbDeleteBrand.FormattingEnabled = True
        Me.cmbDeleteBrand.Location = New System.Drawing.Point(253, 44)
        Me.cmbDeleteBrand.Name = "cmbDeleteBrand"
        Me.cmbDeleteBrand.Size = New System.Drawing.Size(121, 21)
        Me.cmbDeleteBrand.TabIndex = 6
        '
        'cmbDeleteCategory
        '
        Me.cmbDeleteCategory.DropDownHeight = 80
        Me.cmbDeleteCategory.FormattingEnabled = True
        Me.cmbDeleteCategory.IntegralHeight = False
        Me.cmbDeleteCategory.Location = New System.Drawing.Point(72, 44)
        Me.cmbDeleteCategory.Name = "cmbDeleteCategory"
        Me.cmbDeleteCategory.Size = New System.Drawing.Size(121, 21)
        Me.cmbDeleteCategory.TabIndex = 5
        '
        'cmdDelete
        '
        Me.cmdDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDelete.ForeColor = System.Drawing.Color.Maroon
        Me.cmdDelete.Location = New System.Drawing.Point(473, 10)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(75, 23)
        Me.cmdDelete.TabIndex = 3
        Me.cmdDelete.Text = "&Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'optCustomDelete
        '
        Me.optCustomDelete.AutoSize = True
        Me.optCustomDelete.ForeColor = System.Drawing.Color.Maroon
        Me.optCustomDelete.Location = New System.Drawing.Point(127, 13)
        Me.optCustomDelete.Name = "optCustomDelete"
        Me.optCustomDelete.Size = New System.Drawing.Size(94, 17)
        Me.optCustomDelete.TabIndex = 2
        Me.optCustomDelete.Text = "Custom Delete"
        Me.optCustomDelete.UseVisualStyleBackColor = True
        '
        'grpcustomDelete
        '
        Me.grpcustomDelete.Controls.Add(Me.lstDeleteModel)
        Me.grpcustomDelete.Location = New System.Drawing.Point(11, 67)
        Me.grpcustomDelete.Name = "grpcustomDelete"
        Me.grpcustomDelete.Size = New System.Drawing.Size(752, 416)
        Me.grpcustomDelete.TabIndex = 1
        Me.grpcustomDelete.TabStop = False
        '
        'lstDeleteModel
        '
        Me.lstDeleteModel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.lstDeleteModel.CheckBoxes = True
        Me.lstDeleteModel.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.lstDeleteModel.GridLines = True
        Me.lstDeleteModel.Location = New System.Drawing.Point(8, 17)
        Me.lstDeleteModel.Name = "lstDeleteModel"
        Me.lstDeleteModel.Size = New System.Drawing.Size(735, 393)
        Me.lstDeleteModel.TabIndex = 7
        Me.lstDeleteModel.UseCompatibleStateImageBehavior = False
        Me.lstDeleteModel.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "SL."
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Model"
        Me.ColumnHeader2.Width = 130
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Charge"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 80
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "W.Period"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Item"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 80
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Item SL"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Size"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 50
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Remarks"
        Me.ColumnHeader8.Width = 200
        '
        'optQuickDelete
        '
        Me.optQuickDelete.AutoSize = True
        Me.optQuickDelete.Checked = True
        Me.optQuickDelete.ForeColor = System.Drawing.Color.Maroon
        Me.optQuickDelete.Location = New System.Drawing.Point(14, 13)
        Me.optQuickDelete.Name = "optQuickDelete"
        Me.optQuickDelete.Size = New System.Drawing.Size(87, 17)
        Me.optQuickDelete.TabIndex = 1
        Me.optQuickDelete.TabStop = True
        Me.optQuickDelete.Text = "Quick Delete"
        Me.optQuickDelete.UseVisualStyleBackColor = True
        '
        'frmUpdate_Delete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.tbPriceUpdate)
        Me.Name = "frmUpdate_Delete"
        Me.Text = "frmUpdate_Delete"
        Me.tbPriceUpdate.ResumeLayout(False)
        Me.tbpPriceUpdate.ResumeLayout(False)
        Me.grpModel.ResumeLayout(False)
        Me.grpModel.PerformLayout()
        Me.grpBrand.ResumeLayout(False)
        Me.grpBrand.PerformLayout()
        Me.tbpDeleteCategory.ResumeLayout(False)
        Me.tbpDeleteCategory.PerformLayout()
        Me.grpcustomDelete.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbPriceUpdate As TabControl
    Friend WithEvents tbpPriceUpdate As TabPage
    Friend WithEvents tbpDeleteCategory As TabPage
    Friend WithEvents grpBrand As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbField As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbBrand As ComboBox
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents lblValue As Label
    Friend WithEvents txtSetValue As TextBox
    Friend WithEvents cmdUpdate As Button
    Friend WithEvents cmdClose As Button
    Friend WithEvents lblNotification As Label
    Friend WithEvents optQuickDelete As RadioButton
    Friend WithEvents grpcustomDelete As GroupBox
    Friend WithEvents optCustomDelete As RadioButton
    Friend WithEvents cmdDelete As Button
    Friend WithEvents lstDeleteModel As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents chkDeleteBrand As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbDeleteBrand As ComboBox
    Friend WithEvents cmbDeleteCategory As ComboBox
    Friend WithEvents cmdDeleteClose As Button
    Friend WithEvents cmdDeleteClear As Button
    Friend WithEvents cmdLoadModel As Button
    Friend WithEvents lblDeleteRemarks As Label
    Friend WithEvents grpModel As GroupBox
    Friend WithEvents optWithoutCharge As RadioButton
    Friend WithEvents optAll As RadioButton
    Friend WithEvents lstModelDetails As ListView
    Friend WithEvents colModelSL As ColumnHeader
    Friend WithEvents colModel As ColumnHeader
    Friend WithEvents colModelCharge As ColumnHeader
    Friend WithEvents colModelWarrPeriod As ColumnHeader
    Friend WithEvents colModelItem As ColumnHeader
    Friend WithEvents colModelSerial As ColumnHeader
    Friend WithEvents ColModelSize As ColumnHeader
    Friend WithEvents colModelRemarks As ColumnHeader
    Friend WithEvents chkSelectAll As CheckBox
    Friend WithEvents lblLine1 As Label
End Class
