<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmtbStorageSet
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtSearchJob = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpProductInformation = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtAccessories = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtFault = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtReceptDate = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSerial = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBrand = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtWarrType = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBranch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtJobCode = New System.Windows.Forms.TextBox()
        Me.dgvJobList = New System.Windows.Forms.DataGridView()
        Me.cmbBranch = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtBin = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtLocaltion = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.dtpStorage = New System.Windows.Forms.DateTimePicker()
        Me.grpProductInformation.SuspendLayout()
        CType(Me.dgvJobList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSearchJob
        '
        Me.txtSearchJob.BackColor = System.Drawing.Color.LavenderBlush
        Me.txtSearchJob.ForeColor = System.Drawing.Color.Black
        Me.txtSearchJob.Location = New System.Drawing.Point(73, 12)
        Me.txtSearchJob.Name = "txtSearchJob"
        Me.txtSearchJob.Size = New System.Drawing.Size(187, 20)
        Me.txtSearchJob.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Job Code:"
        '
        'grpProductInformation
        '
        Me.grpProductInformation.Controls.Add(Me.Label13)
        Me.grpProductInformation.Controls.Add(Me.txtAccessories)
        Me.grpProductInformation.Controls.Add(Me.Label12)
        Me.grpProductInformation.Controls.Add(Me.txtItem)
        Me.grpProductInformation.Controls.Add(Me.Label11)
        Me.grpProductInformation.Controls.Add(Me.txtFault)
        Me.grpProductInformation.Controls.Add(Me.Label10)
        Me.grpProductInformation.Controls.Add(Me.txtReceptDate)
        Me.grpProductInformation.Controls.Add(Me.Label9)
        Me.grpProductInformation.Controls.Add(Me.txtSerial)
        Me.grpProductInformation.Controls.Add(Me.Label8)
        Me.grpProductInformation.Controls.Add(Me.txtModel)
        Me.grpProductInformation.Controls.Add(Me.Label7)
        Me.grpProductInformation.Controls.Add(Me.txtBrand)
        Me.grpProductInformation.Controls.Add(Me.Label6)
        Me.grpProductInformation.Controls.Add(Me.txtCategory)
        Me.grpProductInformation.Controls.Add(Me.Label5)
        Me.grpProductInformation.Controls.Add(Me.txtStatus)
        Me.grpProductInformation.Controls.Add(Me.Label4)
        Me.grpProductInformation.Controls.Add(Me.txtWarrType)
        Me.grpProductInformation.Controls.Add(Me.Label3)
        Me.grpProductInformation.Controls.Add(Me.txtBranch)
        Me.grpProductInformation.Controls.Add(Me.Label2)
        Me.grpProductInformation.Controls.Add(Me.txtJobCode)
        Me.grpProductInformation.ForeColor = System.Drawing.Color.Magenta
        Me.grpProductInformation.Location = New System.Drawing.Point(3, 70)
        Me.grpProductInformation.Name = "grpProductInformation"
        Me.grpProductInformation.Size = New System.Drawing.Size(578, 220)
        Me.grpProductInformation.TabIndex = 2
        Me.grpProductInformation.TabStop = False
        Me.grpProductInformation.Text = "Product Information"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.DeepPink
        Me.Label13.Location = New System.Drawing.Point(273, 104)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 13)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Accessories:"
        '
        'txtAccessories
        '
        Me.txtAccessories.BackColor = System.Drawing.Color.PaleVioletRed
        Me.txtAccessories.ForeColor = System.Drawing.Color.White
        Me.txtAccessories.Location = New System.Drawing.Point(276, 120)
        Me.txtAccessories.Multiline = True
        Me.txtAccessories.Name = "txtAccessories"
        Me.txtAccessories.ReadOnly = True
        Me.txtAccessories.Size = New System.Drawing.Size(290, 33)
        Me.txtAccessories.TabIndex = 24
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.DeepPink
        Me.Label12.Location = New System.Drawing.Point(136, 104)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(30, 13)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Item:"
        '
        'txtItem
        '
        Me.txtItem.BackColor = System.Drawing.Color.PaleVioletRed
        Me.txtItem.ForeColor = System.Drawing.Color.White
        Me.txtItem.Location = New System.Drawing.Point(136, 120)
        Me.txtItem.Multiline = True
        Me.txtItem.Name = "txtItem"
        Me.txtItem.ReadOnly = True
        Me.txtItem.Size = New System.Drawing.Size(134, 33)
        Me.txtItem.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.DeepPink
        Me.Label11.Location = New System.Drawing.Point(11, 144)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Fault:"
        '
        'txtFault
        '
        Me.txtFault.BackColor = System.Drawing.Color.PaleVioletRed
        Me.txtFault.ForeColor = System.Drawing.Color.White
        Me.txtFault.Location = New System.Drawing.Point(11, 159)
        Me.txtFault.Multiline = True
        Me.txtFault.Name = "txtFault"
        Me.txtFault.ReadOnly = True
        Me.txtFault.Size = New System.Drawing.Size(555, 47)
        Me.txtFault.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.DeepPink
        Me.Label10.Location = New System.Drawing.Point(11, 104)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Rec. Date:"
        '
        'txtReceptDate
        '
        Me.txtReceptDate.BackColor = System.Drawing.Color.PaleVioletRed
        Me.txtReceptDate.ForeColor = System.Drawing.Color.White
        Me.txtReceptDate.Location = New System.Drawing.Point(11, 120)
        Me.txtReceptDate.Name = "txtReceptDate"
        Me.txtReceptDate.ReadOnly = True
        Me.txtReceptDate.Size = New System.Drawing.Size(121, 20)
        Me.txtReceptDate.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.DeepPink
        Me.Label9.Location = New System.Drawing.Point(397, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Serial:"
        '
        'txtSerial
        '
        Me.txtSerial.BackColor = System.Drawing.Color.PaleVioletRed
        Me.txtSerial.ForeColor = System.Drawing.Color.White
        Me.txtSerial.Location = New System.Drawing.Point(397, 81)
        Me.txtSerial.Name = "txtSerial"
        Me.txtSerial.ReadOnly = True
        Me.txtSerial.Size = New System.Drawing.Size(169, 20)
        Me.txtSerial.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.DeepPink
        Me.Label8.Location = New System.Drawing.Point(264, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Model:"
        '
        'txtModel
        '
        Me.txtModel.BackColor = System.Drawing.Color.PaleVioletRed
        Me.txtModel.ForeColor = System.Drawing.Color.White
        Me.txtModel.Location = New System.Drawing.Point(264, 81)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.ReadOnly = True
        Me.txtModel.Size = New System.Drawing.Size(128, 20)
        Me.txtModel.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.DeepPink
        Me.Label7.Location = New System.Drawing.Point(136, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Brand:"
        '
        'txtBrand
        '
        Me.txtBrand.BackColor = System.Drawing.Color.PaleVioletRed
        Me.txtBrand.ForeColor = System.Drawing.Color.White
        Me.txtBrand.Location = New System.Drawing.Point(136, 81)
        Me.txtBrand.Name = "txtBrand"
        Me.txtBrand.ReadOnly = True
        Me.txtBrand.Size = New System.Drawing.Size(124, 20)
        Me.txtBrand.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.DeepPink
        Me.Label6.Location = New System.Drawing.Point(11, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Category:"
        '
        'txtCategory
        '
        Me.txtCategory.BackColor = System.Drawing.Color.PaleVioletRed
        Me.txtCategory.ForeColor = System.Drawing.Color.White
        Me.txtCategory.Location = New System.Drawing.Point(11, 81)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.ReadOnly = True
        Me.txtCategory.Size = New System.Drawing.Size(121, 20)
        Me.txtCategory.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.DeepPink
        Me.Label5.Location = New System.Drawing.Point(397, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Status:"
        '
        'txtStatus
        '
        Me.txtStatus.BackColor = System.Drawing.Color.PaleVioletRed
        Me.txtStatus.ForeColor = System.Drawing.Color.White
        Me.txtStatus.Location = New System.Drawing.Point(397, 37)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(169, 20)
        Me.txtStatus.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.DeepPink
        Me.Label4.Location = New System.Drawing.Point(264, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Warr-Type"
        '
        'txtWarrType
        '
        Me.txtWarrType.BackColor = System.Drawing.Color.PaleVioletRed
        Me.txtWarrType.ForeColor = System.Drawing.Color.White
        Me.txtWarrType.Location = New System.Drawing.Point(264, 37)
        Me.txtWarrType.Name = "txtWarrType"
        Me.txtWarrType.ReadOnly = True
        Me.txtWarrType.Size = New System.Drawing.Size(128, 20)
        Me.txtWarrType.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.DeepPink
        Me.Label3.Location = New System.Drawing.Point(136, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Branch:"
        '
        'txtBranch
        '
        Me.txtBranch.BackColor = System.Drawing.Color.PaleVioletRed
        Me.txtBranch.ForeColor = System.Drawing.Color.White
        Me.txtBranch.Location = New System.Drawing.Point(136, 37)
        Me.txtBranch.Name = "txtBranch"
        Me.txtBranch.ReadOnly = True
        Me.txtBranch.Size = New System.Drawing.Size(124, 20)
        Me.txtBranch.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.DeepPink
        Me.Label2.Location = New System.Drawing.Point(11, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Job No:"
        '
        'txtJobCode
        '
        Me.txtJobCode.BackColor = System.Drawing.Color.PaleVioletRed
        Me.txtJobCode.ForeColor = System.Drawing.Color.White
        Me.txtJobCode.Location = New System.Drawing.Point(11, 37)
        Me.txtJobCode.Name = "txtJobCode"
        Me.txtJobCode.ReadOnly = True
        Me.txtJobCode.Size = New System.Drawing.Size(121, 20)
        Me.txtJobCode.TabIndex = 2
        '
        'dgvJobList
        '
        Me.dgvJobList.AllowUserToAddRows = False
        Me.dgvJobList.AllowUserToDeleteRows = False
        Me.dgvJobList.AllowUserToResizeColumns = False
        Me.dgvJobList.AllowUserToResizeRows = False
        Me.dgvJobList.BackgroundColor = System.Drawing.Color.PaleVioletRed
        Me.dgvJobList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvJobList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvJobList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvJobList.Location = New System.Drawing.Point(302, 2)
        Me.dgvJobList.MultiSelect = False
        Me.dgvJobList.Name = "dgvJobList"
        Me.dgvJobList.ReadOnly = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleVioletRed
        Me.dgvJobList.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvJobList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvJobList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvJobList.Size = New System.Drawing.Size(240, 40)
        Me.dgvJobList.TabIndex = 5
        '
        'cmbBranch
        '
        Me.cmbBranch.BackColor = System.Drawing.Color.PaleVioletRed
        Me.cmbBranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbBranch.ForeColor = System.Drawing.Color.White
        Me.cmbBranch.FormattingEnabled = True
        Me.cmbBranch.Location = New System.Drawing.Point(69, 330)
        Me.cmbBranch.Name = "cmbBranch"
        Me.cmbBranch.Size = New System.Drawing.Size(169, 21)
        Me.cmbBranch.TabIndex = 46
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.DeepPink
        Me.Label18.Location = New System.Drawing.Point(19, 334)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(44, 13)
        Me.Label18.TabIndex = 45
        Me.Label18.Text = "Branch:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.DeepPink
        Me.Label14.Location = New System.Drawing.Point(244, 334)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 13)
        Me.Label14.TabIndex = 44
        Me.Label14.Text = "Remarks:"
        '
        'txtRemarks
        '
        Me.txtRemarks.BackColor = System.Drawing.Color.PaleVioletRed
        Me.txtRemarks.ForeColor = System.Drawing.Color.White
        Me.txtRemarks.Location = New System.Drawing.Point(302, 331)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(267, 20)
        Me.txtRemarks.TabIndex = 43
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.DeepPink
        Me.Label15.Location = New System.Drawing.Point(446, 309)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(42, 13)
        Me.Label15.TabIndex = 42
        Me.Label15.Text = "Bin No:"
        '
        'txtBin
        '
        Me.txtBin.BackColor = System.Drawing.Color.PaleVioletRed
        Me.txtBin.ForeColor = System.Drawing.Color.Transparent
        Me.txtBin.Location = New System.Drawing.Point(494, 305)
        Me.txtBin.Name = "txtBin"
        Me.txtBin.Size = New System.Drawing.Size(75, 20)
        Me.txtBin.TabIndex = 41
        Me.txtBin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.DeepPink
        Me.Label16.Location = New System.Drawing.Point(262, 309)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(73, 13)
        Me.Label16.TabIndex = 40
        Me.Label16.Text = "Storage Date:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.DeepPink
        Me.Label17.Location = New System.Drawing.Point(12, 309)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(51, 13)
        Me.Label17.TabIndex = 38
        Me.Label17.Text = "Location:"
        '
        'txtLocaltion
        '
        Me.txtLocaltion.BackColor = System.Drawing.Color.PaleVioletRed
        Me.txtLocaltion.ForeColor = System.Drawing.Color.White
        Me.txtLocaltion.Location = New System.Drawing.Point(69, 305)
        Me.txtLocaltion.Name = "txtLocaltion"
        Me.txtLocaltion.Size = New System.Drawing.Size(169, 20)
        Me.txtLocaltion.TabIndex = 37
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Pink
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.ForeColor = System.Drawing.Color.Crimson
        Me.btnExit.Location = New System.Drawing.Point(391, 356)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(176, 22)
        Me.btnExit.TabIndex = 47
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'cmdClear
        '
        Me.cmdClear.BackColor = System.Drawing.Color.Pink
        Me.cmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClear.ForeColor = System.Drawing.Color.Crimson
        Me.cmdClear.Location = New System.Drawing.Point(200, 356)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(188, 22)
        Me.cmdClear.TabIndex = 48
        Me.cmdClear.Text = "&Clear"
        Me.cmdClear.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Pink
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.Crimson
        Me.btnSave.Location = New System.Drawing.Point(18, 356)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(179, 22)
        Me.btnSave.TabIndex = 49
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'dtpStorage
        '
        Me.dtpStorage.CalendarMonthBackground = System.Drawing.Color.PaleVioletRed
        Me.dtpStorage.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStorage.Location = New System.Drawing.Point(341, 305)
        Me.dtpStorage.Name = "dtpStorage"
        Me.dtpStorage.Size = New System.Drawing.Size(88, 20)
        Me.dtpStorage.TabIndex = 50
        '
        'frmtbStorageSet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Pink
        Me.ClientSize = New System.Drawing.Size(585, 384)
        Me.Controls.Add(Me.dtpStorage)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.cmbBranch)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtBin)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtLocaltion)
        Me.Controls.Add(Me.dgvJobList)
        Me.Controls.Add(Me.grpProductInformation)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSearchJob)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmtbStorageSet"
        Me.Text = "Product Storage"
        Me.grpProductInformation.ResumeLayout(False)
        Me.grpProductInformation.PerformLayout()
        CType(Me.dgvJobList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSearchJob As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents grpProductInformation As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtWarrType As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBranch As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtJobCode As TextBox
    Friend WithEvents dgvJobList As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents txtBrand As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtItem As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtFault As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtReceptDate As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtSerial As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtModel As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtAccessories As TextBox
    Friend WithEvents cmbBranch As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtBin As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtLocaltion As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents cmdClear As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents dtpStorage As DateTimePicker
End Class
