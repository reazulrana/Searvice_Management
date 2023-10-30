<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProductEntry
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
        Me.lstProductList = New System.Windows.Forms.ListView()
        Me.colLstSLNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.collstProductCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colProductName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colProMeasure = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColProductListUnitPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.txtPartNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPartNo = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblMeasure = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.txtUnitPrice = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.dtpServiceDate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chkRemarks = New System.Windows.Forms.CheckBox()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.lblTechnicianName = New System.Windows.Forms.Label()
        Me.cmbServiceby = New System.Windows.Forms.ComboBox()
        Me.cmdDeleteRecord = New System.Windows.Forms.Button()
        Me.lblTotalParts = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lstPartsDetails = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmdSaveAndMail = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstProductList
        '
        Me.lstProductList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colLstSLNo, Me.collstProductCode, Me.colProductName, Me.colProMeasure, Me.ColProductListUnitPrice})
        Me.lstProductList.FullRowSelect = True
        Me.lstProductList.Location = New System.Drawing.Point(54, 182)
        Me.lstProductList.Name = "lstProductList"
        Me.lstProductList.Size = New System.Drawing.Size(579, 163)
        Me.lstProductList.TabIndex = 18
        Me.lstProductList.UseCompatibleStateImageBehavior = False
        Me.lstProductList.View = System.Windows.Forms.View.Details
        '
        'colLstSLNo
        '
        Me.colLstSLNo.Text = "SL"
        Me.colLstSLNo.Width = 45
        '
        'collstProductCode
        '
        Me.collstProductCode.Text = "ProductCode"
        Me.collstProductCode.Width = 150
        '
        'colProductName
        '
        Me.colProductName.Text = "Description"
        Me.colProductName.Width = 200
        '
        'colProMeasure
        '
        Me.colProMeasure.Text = "Measure"
        Me.colProMeasure.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colProMeasure.Width = 90
        '
        'ColProductListUnitPrice
        '
        Me.ColProductListUnitPrice.Text = "Unit Price"
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(381, 48)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(78, 23)
        Me.cmdAdd.TabIndex = 4
        Me.cmdAdd.Text = "&Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'txtPartNo
        '
        Me.txtPartNo.Location = New System.Drawing.Point(54, 50)
        Me.txtPartNo.Name = "txtPartNo"
        Me.txtPartNo.Size = New System.Drawing.Size(126, 20)
        Me.txtPartNo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Part No:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Pink
        Me.Label2.Location = New System.Drawing.Point(55, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Part No:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Pink
        Me.Label3.Location = New System.Drawing.Point(230, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Description:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPartNo
        '
        Me.lblPartNo.BackColor = System.Drawing.Color.PaleVioletRed
        Me.lblPartNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPartNo.Location = New System.Drawing.Point(9, 24)
        Me.lblPartNo.Name = "lblPartNo"
        Me.lblPartNo.Size = New System.Drawing.Size(146, 20)
        Me.lblPartNo.TabIndex = 7
        Me.lblPartNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDescription
        '
        Me.lblDescription.BackColor = System.Drawing.Color.PaleVioletRed
        Me.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDescription.Location = New System.Drawing.Point(158, 24)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(232, 20)
        Me.lblDescription.TabIndex = 9
        Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Pink
        Me.Label6.Location = New System.Drawing.Point(405, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Measure:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMeasure
        '
        Me.lblMeasure.BackColor = System.Drawing.Color.PaleVioletRed
        Me.lblMeasure.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMeasure.Location = New System.Drawing.Point(393, 24)
        Me.lblMeasure.Name = "lblMeasure"
        Me.lblMeasure.Size = New System.Drawing.Size(81, 20)
        Me.lblMeasure.TabIndex = 11
        Me.lblMeasure.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Pink
        Me.Label8.Location = New System.Drawing.Point(487, 3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 20)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Qty:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Pink
        Me.Label11.Location = New System.Drawing.Point(546, 3)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 20)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Unit Price:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Pink
        Me.Label13.Location = New System.Drawing.Point(635, 3)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 20)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Total:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(476, 24)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(59, 20)
        Me.txtQty.TabIndex = 2
        Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.Location = New System.Drawing.Point(540, 24)
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.Size = New System.Drawing.Size(75, 20)
        Me.txtUnitPrice.TabIndex = 3
        Me.txtUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.PaleVioletRed
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(620, 24)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(75, 20)
        Me.lblTotal.TabIndex = 15
        Me.lblTotal.Text = "0"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(182, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Description:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(245, 50)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(135, 20)
        Me.txtDescription.TabIndex = 1
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(387, 393)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(73, 23)
        Me.cmdClose.TabIndex = 12
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'dtpServiceDate
        '
        Me.dtpServiceDate.CustomFormat = "DD-MMM-YY"
        Me.dtpServiceDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpServiceDate.Location = New System.Drawing.Point(378, 344)
        Me.dtpServiceDate.Name = "dtpServiceDate"
        Me.dtpServiceDate.Size = New System.Drawing.Size(82, 20)
        Me.dtpServiceDate.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(2, 348)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Service By"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(300, 348)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Service Date"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkRemarks
        '
        Me.chkRemarks.AutoSize = True
        Me.chkRemarks.Location = New System.Drawing.Point(469, 347)
        Me.chkRemarks.Name = "chkRemarks"
        Me.chkRemarks.Size = New System.Drawing.Size(15, 14)
        Me.chkRemarks.TabIndex = 8
        Me.chkRemarks.UseVisualStyleBackColor = True
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(487, 344)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(212, 20)
        Me.txtRemarks.TabIndex = 9
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(66, 393)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(73, 23)
        Me.cmdSave.TabIndex = 11
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'lblTechnicianName
        '
        Me.lblTechnicianName.BackColor = System.Drawing.Color.PaleVioletRed
        Me.lblTechnicianName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTechnicianName.Location = New System.Drawing.Point(118, 344)
        Me.lblTechnicianName.Name = "lblTechnicianName"
        Me.lblTechnicianName.Size = New System.Drawing.Size(180, 20)
        Me.lblTechnicianName.TabIndex = 27
        Me.lblTechnicianName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbServiceby
        '
        Me.cmbServiceby.FormattingEnabled = True
        Me.cmbServiceby.Location = New System.Drawing.Point(66, 343)
        Me.cmbServiceby.Name = "cmbServiceby"
        Me.cmbServiceby.Size = New System.Drawing.Size(49, 21)
        Me.cmbServiceby.TabIndex = 6
        '
        'cmdDeleteRecord
        '
        Me.cmdDeleteRecord.Location = New System.Drawing.Point(459, 48)
        Me.cmdDeleteRecord.Name = "cmdDeleteRecord"
        Me.cmdDeleteRecord.Size = New System.Drawing.Size(78, 23)
        Me.cmdDeleteRecord.TabIndex = 13
        Me.cmdDeleteRecord.Text = "&Delete"
        Me.cmdDeleteRecord.UseVisualStyleBackColor = True
        '
        'lblTotalParts
        '
        Me.lblTotalParts.BackColor = System.Drawing.Color.Orange
        Me.lblTotalParts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalParts.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalParts.Location = New System.Drawing.Point(620, 49)
        Me.lblTotalParts.Name = "lblTotalParts"
        Me.lblTotalParts.Size = New System.Drawing.Size(75, 20)
        Me.lblTotalParts.TabIndex = 32
        Me.lblTotalParts.Text = "0"
        Me.lblTotalParts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Pink
        Me.Label10.Location = New System.Drawing.Point(553, 49)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 20)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Total Parts:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lstPartsDetails
        '
        Me.lstPartsDetails.BackColor = System.Drawing.Color.PaleVioletRed
        Me.lstPartsDetails.BackgroundImageTiled = True
        Me.lstPartsDetails.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lstPartsDetails.ForeColor = System.Drawing.Color.White
        Me.lstPartsDetails.FullRowSelect = True
        Me.lstPartsDetails.GridLines = True
        Me.lstPartsDetails.Location = New System.Drawing.Point(9, 76)
        Me.lstPartsDetails.Name = "lstPartsDetails"
        Me.lstPartsDetails.Size = New System.Drawing.Size(686, 142)
        Me.lstPartsDetails.TabIndex = 5
        Me.lstPartsDetails.UseCompatibleStateImageBehavior = False
        Me.lstPartsDetails.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "SL"
        Me.ColumnHeader1.Width = 50
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Product Code"
        Me.ColumnHeader2.Width = 125
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Description"
        Me.ColumnHeader3.Width = 170
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Unit"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 80
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Qty"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 75
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Unit Price"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 80
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Total"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 90
        '
        'cmdSaveAndMail
        '
        Me.cmdSaveAndMail.Location = New System.Drawing.Point(158, 393)
        Me.cmdSaveAndMail.Name = "cmdSaveAndMail"
        Me.cmdSaveAndMail.Size = New System.Drawing.Size(198, 23)
        Me.cmdSaveAndMail.TabIndex = 33
        Me.cmdSaveAndMail.Text = "&Save and Mail"
        Me.cmdSaveAndMail.UseVisualStyleBackColor = True
        '
        'frmProductEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Pink
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(705, 416)
        Me.Controls.Add(Me.cmdSaveAndMail)
        Me.Controls.Add(Me.lstPartsDetails)
        Me.Controls.Add(Me.lblTotalParts)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmdDeleteRecord)
        Me.Controls.Add(Me.cmbServiceby)
        Me.Controls.Add(Me.lblTechnicianName)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.chkRemarks)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtpServiceDate)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtUnitPrice)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblMeasure)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblPartNo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPartNo)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.lstProductList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProductEntry"
        Me.Text = "Product Repair"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstProductList As ListView
    Friend WithEvents colLstSLNo As ColumnHeader
    Friend WithEvents collstProductCode As ColumnHeader
    Friend WithEvents colProductName As ColumnHeader
    Friend WithEvents cmdAdd As Button
    Friend WithEvents txtPartNo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblPartNo As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblMeasure As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtQty As TextBox
    Friend WithEvents txtUnitPrice As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents colProMeasure As ColumnHeader
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents ColProductListUnitPrice As ColumnHeader
    Friend WithEvents cmdClose As Button
    Friend WithEvents dtpServiceDate As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents chkRemarks As CheckBox
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents cmdSave As Button
    Friend WithEvents lblTechnicianName As Label
    Friend WithEvents cmbServiceby As ComboBox
    Friend WithEvents cmdDeleteRecord As Button
    Friend WithEvents lblTotalParts As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Private WithEvents lstPartsDetails As ListView
    Friend WithEvents cmdSaveAndMail As Button
End Class
