<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewProduct
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
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.lblBottom = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPartno = New System.Windows.Forms.TextBox()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.cmbModel = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtUnitPrice = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbSource = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lstProductList = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtSearchCode = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkEdit = New System.Windows.Forms.CheckBox()
        Me.txtSearchProduct = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnSearchProduct = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.BackColor = System.Drawing.Color.LightCoral
        Me.lblHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeader.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.Snow
        Me.lblHeader.Location = New System.Drawing.Point(0, 0)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.lblHeader.Size = New System.Drawing.Size(723, 25)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "New Product"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblClose
        '
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.Color.LightCoral
        Me.lblClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.ForeColor = System.Drawing.Color.Snow
        Me.lblClose.Location = New System.Drawing.Point(702, 5)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(15, 17)
        Me.lblClose.TabIndex = 1
        Me.lblClose.Text = "x"
        Me.lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBottom
        '
        Me.lblBottom.BackColor = System.Drawing.Color.LightCoral
        Me.lblBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblBottom.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBottom.ForeColor = System.Drawing.Color.Transparent
        Me.lblBottom.Location = New System.Drawing.Point(0, 475)
        Me.lblBottom.Name = "lblBottom"
        Me.lblBottom.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.lblBottom.Size = New System.Drawing.Size(723, 25)
        Me.lblBottom.TabIndex = 2
        Me.lblBottom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Part No"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(356, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Description"
        '
        'txtPartno
        '
        Me.txtPartno.Location = New System.Drawing.Point(80, 38)
        Me.txtPartno.Name = "txtPartno"
        Me.txtPartno.Size = New System.Drawing.Size(198, 20)
        Me.txtPartno.TabIndex = 5
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(421, 39)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(280, 20)
        Me.txtProductName.TabIndex = 6
        '
        'cmbModel
        '
        Me.cmbModel.FormattingEnabled = True
        Me.cmbModel.Location = New System.Drawing.Point(80, 66)
        Me.cmbModel.Name = "cmbModel"
        Me.cmbModel.Size = New System.Drawing.Size(159, 21)
        Me.cmbModel.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Model"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(287, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Unit Price"
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.Location = New System.Drawing.Point(351, 66)
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.Size = New System.Drawing.Size(92, 20)
        Me.txtUnitPrice.TabIndex = 11
        Me.txtUnitPrice.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(497, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Source"
        '
        'cmbSource
        '
        Me.cmbSource.FormattingEnabled = True
        Me.cmbSource.Location = New System.Drawing.Point(544, 65)
        Me.cmbSource.Name = "cmbSource"
        Me.cmbSource.Size = New System.Drawing.Size(157, 21)
        Me.cmbSource.TabIndex = 13
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(64, 102)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(110, 23)
        Me.btnAdd.TabIndex = 14
        Me.btnAdd.Text = "&Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(193, 102)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(110, 23)
        Me.btnDelete.TabIndex = 15
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(319, 102)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(110, 23)
        Me.btnClear.TabIndex = 16
        Me.btnClear.Text = "&Reset"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(450, 102)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(110, 23)
        Me.btnRefresh.TabIndex = 17
        Me.btnRefresh.Text = "&Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(575, 102)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(110, 23)
        Me.btnClose.TabIndex = 18
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lstProductList
        '
        Me.lstProductList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lstProductList.FullRowSelect = True
        Me.lstProductList.GridLines = True
        Me.lstProductList.Location = New System.Drawing.Point(4, 195)
        Me.lstProductList.Name = "lstProductList"
        Me.lstProductList.Size = New System.Drawing.Size(713, 277)
        Me.lstProductList.TabIndex = 19
        Me.lstProductList.UseCompatibleStateImageBehavior = False
        Me.lstProductList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "SL"
        Me.ColumnHeader1.Width = 48
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Part No"
        Me.ColumnHeader2.Width = 139
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Description"
        Me.ColumnHeader3.Width = 237
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Model"
        Me.ColumnHeader4.Width = 96
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Unit Price"
        Me.ColumnHeader5.Width = 74
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Source"
        Me.ColumnHeader6.Width = 100
        '
        'txtSearchCode
        '
        Me.txtSearchCode.Enabled = False
        Me.txtSearchCode.Location = New System.Drawing.Point(138, 169)
        Me.txtSearchCode.Name = "txtSearchCode"
        Me.txtSearchCode.Size = New System.Drawing.Size(136, 20)
        Me.txtSearchCode.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Enabled = False
        Me.Label6.Location = New System.Drawing.Point(60, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Product Code"
        '
        'chkEdit
        '
        Me.chkEdit.AutoSize = True
        Me.chkEdit.Location = New System.Drawing.Point(10, 171)
        Me.chkEdit.Name = "chkEdit"
        Me.chkEdit.Size = New System.Drawing.Size(44, 17)
        Me.chkEdit.TabIndex = 22
        Me.chkEdit.Text = "&Edit"
        Me.chkEdit.UseVisualStyleBackColor = True
        '
        'txtSearchProduct
        '
        Me.txtSearchProduct.Enabled = False
        Me.txtSearchProduct.Location = New System.Drawing.Point(344, 169)
        Me.txtSearchProduct.Name = "txtSearchProduct"
        Me.txtSearchProduct.Size = New System.Drawing.Size(212, 20)
        Me.txtSearchProduct.TabIndex = 24
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Enabled = False
        Me.Label7.Location = New System.Drawing.Point(278, 173)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Description"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Coral
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(-1, 139)
        Me.Label8.Name = "Label8"
        Me.Label8.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.Label8.Size = New System.Drawing.Size(741, 20)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Edit Option"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSearchProduct
        '
        Me.btnSearchProduct.Location = New System.Drawing.Point(562, 168)
        Me.btnSearchProduct.Name = "btnSearchProduct"
        Me.btnSearchProduct.Size = New System.Drawing.Size(140, 23)
        Me.btnSearchProduct.TabIndex = 26
        Me.btnSearchProduct.Text = "&Search"
        Me.btnSearchProduct.UseVisualStyleBackColor = True
        '
        'frmNewProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(723, 500)
        Me.Controls.Add(Me.btnSearchProduct)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtSearchProduct)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.chkEdit)
        Me.Controls.Add(Me.txtSearchCode)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lstProductList)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.cmbSource)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtUnitPrice)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbModel)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.txtPartno)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblBottom)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.lblHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmNewProduct"
        Me.Text = "New Product"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents lblClose As Label
    Friend WithEvents lblBottom As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPartno As TextBox
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents cmbModel As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtUnitPrice As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbSource As ComboBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lstProductList As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents txtSearchCode As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents chkEdit As CheckBox
    Friend WithEvents txtSearchProduct As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnSearchProduct As Button
End Class
