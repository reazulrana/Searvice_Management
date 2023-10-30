<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmproductsearch
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DsBillPayment = New Service_Software.dsBillPayment()
        Me.DsBillPaymentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataTable1TableAdapter = New Service_Software.dsBillPaymentTableAdapters.DataTable1TableAdapter()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.lblStop = New System.Windows.Forms.Label()
        Me.grpSearchCriteria = New System.Windows.Forms.GroupBox()
        Me.txtForthCriteria = New System.Windows.Forms.TextBox()
        Me.txtThirdCriteria = New System.Windows.Forms.TextBox()
        Me.txtSecondCriteria = New System.Windows.Forms.TextBox()
        Me.txtFirstCriteria = New System.Windows.Forms.TextBox()
        Me.cmbForthSearchOperator = New System.Windows.Forms.ComboBox()
        Me.cmbThirdSearchOperator = New System.Windows.Forms.ComboBox()
        Me.cmbSecondSearchOperator = New System.Windows.Forms.ComboBox()
        Me.cmbFirstSearchOperator = New System.Windows.Forms.ComboBox()
        Me.cmbForthCriteria = New System.Windows.Forms.ComboBox()
        Me.cmbThirdCriteria = New System.Windows.Forms.ComboBox()
        Me.cmbSecondCriteria = New System.Windows.Forms.ComboBox()
        Me.cmbFirstCriteria = New System.Windows.Forms.ComboBox()
        Me.dgvProductInformation = New System.Windows.Forms.DataGridView()
        Me.cmdDump = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.lstSearchField = New System.Windows.Forms.ListView()
        Me.colFieldName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.lblProductInformation = New System.Windows.Forms.Label()
        Me.chkPartsinformation = New System.Windows.Forms.CheckBox()
        Me.optProduct = New System.Windows.Forms.RadioButton()
        Me.optCashSales = New System.Windows.Forms.RadioButton()
        Me.lblRecourdCount = New System.Windows.Forms.Label()
        CType(Me.DsBillPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsBillPaymentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSearchCriteria.SuspendLayout()
        CType(Me.dgvProductInformation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DsBillPayment
        '
        Me.DsBillPayment.DataSetName = "dsBillPayment"
        Me.DsBillPayment.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DsBillPaymentBindingSource
        '
        Me.DsBillPaymentBindingSource.DataSource = Me.DsBillPayment
        Me.DsBillPaymentBindingSource.Position = 0
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.DsBillPaymentBindingSource
        '
        'DataTable1TableAdapter
        '
        Me.DataTable1TableAdapter.ClearBeforeFill = True
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.Location = New System.Drawing.Point(12, 503)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(0, 13)
        Me.lblStart.TabIndex = 4
        '
        'lblStop
        '
        Me.lblStop.AutoSize = True
        Me.lblStop.Location = New System.Drawing.Point(128, 503)
        Me.lblStop.Name = "lblStop"
        Me.lblStop.Size = New System.Drawing.Size(0, 13)
        Me.lblStop.TabIndex = 5
        '
        'grpSearchCriteria
        '
        Me.grpSearchCriteria.Controls.Add(Me.txtForthCriteria)
        Me.grpSearchCriteria.Controls.Add(Me.txtThirdCriteria)
        Me.grpSearchCriteria.Controls.Add(Me.txtSecondCriteria)
        Me.grpSearchCriteria.Controls.Add(Me.txtFirstCriteria)
        Me.grpSearchCriteria.Controls.Add(Me.cmbForthSearchOperator)
        Me.grpSearchCriteria.Controls.Add(Me.cmbThirdSearchOperator)
        Me.grpSearchCriteria.Controls.Add(Me.cmbSecondSearchOperator)
        Me.grpSearchCriteria.Controls.Add(Me.cmbFirstSearchOperator)
        Me.grpSearchCriteria.Controls.Add(Me.cmbForthCriteria)
        Me.grpSearchCriteria.Controls.Add(Me.cmbThirdCriteria)
        Me.grpSearchCriteria.Controls.Add(Me.cmbSecondCriteria)
        Me.grpSearchCriteria.Controls.Add(Me.cmbFirstCriteria)
        Me.grpSearchCriteria.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSearchCriteria.Location = New System.Drawing.Point(3, 30)
        Me.grpSearchCriteria.Name = "grpSearchCriteria"
        Me.grpSearchCriteria.Size = New System.Drawing.Size(281, 119)
        Me.grpSearchCriteria.TabIndex = 6
        Me.grpSearchCriteria.TabStop = False
        Me.grpSearchCriteria.Text = "Search Criteria"
        '
        'txtForthCriteria
        '
        Me.txtForthCriteria.Location = New System.Drawing.Point(176, 93)
        Me.txtForthCriteria.Name = "txtForthCriteria"
        Me.txtForthCriteria.Size = New System.Drawing.Size(102, 20)
        Me.txtForthCriteria.TabIndex = 18
        '
        'txtThirdCriteria
        '
        Me.txtThirdCriteria.Location = New System.Drawing.Point(176, 68)
        Me.txtThirdCriteria.Name = "txtThirdCriteria"
        Me.txtThirdCriteria.Size = New System.Drawing.Size(102, 20)
        Me.txtThirdCriteria.TabIndex = 17
        '
        'txtSecondCriteria
        '
        Me.txtSecondCriteria.Location = New System.Drawing.Point(176, 43)
        Me.txtSecondCriteria.Name = "txtSecondCriteria"
        Me.txtSecondCriteria.Size = New System.Drawing.Size(102, 20)
        Me.txtSecondCriteria.TabIndex = 16
        '
        'txtFirstCriteria
        '
        Me.txtFirstCriteria.Location = New System.Drawing.Point(176, 18)
        Me.txtFirstCriteria.Name = "txtFirstCriteria"
        Me.txtFirstCriteria.Size = New System.Drawing.Size(102, 20)
        Me.txtFirstCriteria.TabIndex = 8
        '
        'cmbForthSearchOperator
        '
        Me.cmbForthSearchOperator.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbForthSearchOperator.ForeColor = System.Drawing.Color.Blue
        Me.cmbForthSearchOperator.FormattingEnabled = True
        Me.cmbForthSearchOperator.Location = New System.Drawing.Point(103, 93)
        Me.cmbForthSearchOperator.Name = "cmbForthSearchOperator"
        Me.cmbForthSearchOperator.Size = New System.Drawing.Size(72, 22)
        Me.cmbForthSearchOperator.TabIndex = 15
        '
        'cmbThirdSearchOperator
        '
        Me.cmbThirdSearchOperator.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbThirdSearchOperator.ForeColor = System.Drawing.Color.Blue
        Me.cmbThirdSearchOperator.FormattingEnabled = True
        Me.cmbThirdSearchOperator.Location = New System.Drawing.Point(103, 68)
        Me.cmbThirdSearchOperator.Name = "cmbThirdSearchOperator"
        Me.cmbThirdSearchOperator.Size = New System.Drawing.Size(72, 22)
        Me.cmbThirdSearchOperator.TabIndex = 14
        '
        'cmbSecondSearchOperator
        '
        Me.cmbSecondSearchOperator.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSecondSearchOperator.ForeColor = System.Drawing.Color.Blue
        Me.cmbSecondSearchOperator.FormattingEnabled = True
        Me.cmbSecondSearchOperator.Location = New System.Drawing.Point(102, 43)
        Me.cmbSecondSearchOperator.Name = "cmbSecondSearchOperator"
        Me.cmbSecondSearchOperator.Size = New System.Drawing.Size(72, 22)
        Me.cmbSecondSearchOperator.TabIndex = 13
        '
        'cmbFirstSearchOperator
        '
        Me.cmbFirstSearchOperator.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFirstSearchOperator.ForeColor = System.Drawing.Color.Blue
        Me.cmbFirstSearchOperator.FormattingEnabled = True
        Me.cmbFirstSearchOperator.Location = New System.Drawing.Point(103, 18)
        Me.cmbFirstSearchOperator.Name = "cmbFirstSearchOperator"
        Me.cmbFirstSearchOperator.Size = New System.Drawing.Size(72, 22)
        Me.cmbFirstSearchOperator.TabIndex = 12
        '
        'cmbForthCriteria
        '
        Me.cmbForthCriteria.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbForthCriteria.ForeColor = System.Drawing.Color.Blue
        Me.cmbForthCriteria.FormattingEnabled = True
        Me.cmbForthCriteria.Location = New System.Drawing.Point(5, 93)
        Me.cmbForthCriteria.Name = "cmbForthCriteria"
        Me.cmbForthCriteria.Size = New System.Drawing.Size(97, 22)
        Me.cmbForthCriteria.TabIndex = 11
        '
        'cmbThirdCriteria
        '
        Me.cmbThirdCriteria.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbThirdCriteria.ForeColor = System.Drawing.Color.Blue
        Me.cmbThirdCriteria.FormattingEnabled = True
        Me.cmbThirdCriteria.Location = New System.Drawing.Point(5, 68)
        Me.cmbThirdCriteria.Name = "cmbThirdCriteria"
        Me.cmbThirdCriteria.Size = New System.Drawing.Size(97, 22)
        Me.cmbThirdCriteria.TabIndex = 10
        '
        'cmbSecondCriteria
        '
        Me.cmbSecondCriteria.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSecondCriteria.ForeColor = System.Drawing.Color.Blue
        Me.cmbSecondCriteria.FormattingEnabled = True
        Me.cmbSecondCriteria.Location = New System.Drawing.Point(5, 43)
        Me.cmbSecondCriteria.Name = "cmbSecondCriteria"
        Me.cmbSecondCriteria.Size = New System.Drawing.Size(97, 22)
        Me.cmbSecondCriteria.TabIndex = 9
        '
        'cmbFirstCriteria
        '
        Me.cmbFirstCriteria.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFirstCriteria.ForeColor = System.Drawing.Color.Blue
        Me.cmbFirstCriteria.FormattingEnabled = True
        Me.cmbFirstCriteria.Location = New System.Drawing.Point(5, 18)
        Me.cmbFirstCriteria.Name = "cmbFirstCriteria"
        Me.cmbFirstCriteria.Size = New System.Drawing.Size(97, 22)
        Me.cmbFirstCriteria.TabIndex = 8
        '
        'dgvProductInformation
        '
        Me.dgvProductInformation.BackgroundColor = System.Drawing.Color.Beige
        Me.dgvProductInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductInformation.Location = New System.Drawing.Point(285, 37)
        Me.dgvProductInformation.Name = "dgvProductInformation"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Navy
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvProductInformation.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvProductInformation.Size = New System.Drawing.Size(496, 528)
        Me.dgvProductInformation.TabIndex = 10
        '
        'cmdDump
        '
        Me.cmdDump.BackColor = System.Drawing.Color.Beige
        Me.cmdDump.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod
        Me.cmdDump.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDump.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDump.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.cmdDump.Location = New System.Drawing.Point(549, 571)
        Me.cmdDump.Name = "cmdDump"
        Me.cmdDump.Size = New System.Drawing.Size(99, 27)
        Me.cmdDump.TabIndex = 11
        Me.cmdDump.Text = "E&xport In Excel"
        Me.cmdDump.UseVisualStyleBackColor = False
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.Color.Beige
        Me.cmdClose.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.cmdClose.Location = New System.Drawing.Point(680, 571)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(80, 27)
        Me.cmdClose.TabIndex = 12
        Me.cmdClose.Text = "C&lose"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'lstSearchField
        '
        Me.lstSearchField.BackColor = System.Drawing.Color.Beige
        Me.lstSearchField.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colFieldName})
        Me.lstSearchField.Location = New System.Drawing.Point(3, 150)
        Me.lstSearchField.Name = "lstSearchField"
        Me.lstSearchField.Size = New System.Drawing.Size(281, 415)
        Me.lstSearchField.TabIndex = 13
        Me.lstSearchField.UseCompatibleStateImageBehavior = False
        Me.lstSearchField.View = System.Windows.Forms.View.List
        '
        'colFieldName
        '
        Me.colFieldName.Text = "Field Name"
        Me.colFieldName.Width = 120
        '
        'cmdSearch
        '
        Me.cmdSearch.BackColor = System.Drawing.Color.Beige
        Me.cmdSearch.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod
        Me.cmdSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSearch.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.cmdSearch.Location = New System.Drawing.Point(3, 571)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(99, 27)
        Me.cmdSearch.TabIndex = 14
        Me.cmdSearch.Text = "&Search"
        Me.cmdSearch.UseVisualStyleBackColor = False
        '
        'lblProductInformation
        '
        Me.lblProductInformation.AutoSize = True
        Me.lblProductInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductInformation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblProductInformation.Location = New System.Drawing.Point(278, 7)
        Me.lblProductInformation.Name = "lblProductInformation"
        Me.lblProductInformation.Size = New System.Drawing.Size(147, 25)
        Me.lblProductInformation.TabIndex = 15
        Me.lblProductInformation.Text = "Search Product"
        '
        'chkPartsinformation
        '
        Me.chkPartsinformation.AutoSize = True
        Me.chkPartsinformation.Location = New System.Drawing.Point(8, 12)
        Me.chkPartsinformation.Name = "chkPartsinformation"
        Me.chkPartsinformation.Size = New System.Drawing.Size(105, 17)
        Me.chkPartsinformation.TabIndex = 16
        Me.chkPartsinformation.Text = "Parts Information"
        Me.chkPartsinformation.UseVisualStyleBackColor = True
        '
        'optProduct
        '
        Me.optProduct.AutoSize = True
        Me.optProduct.Location = New System.Drawing.Point(118, 12)
        Me.optProduct.Name = "optProduct"
        Me.optProduct.Size = New System.Drawing.Size(62, 17)
        Me.optProduct.TabIndex = 18
        Me.optProduct.TabStop = True
        Me.optProduct.Text = "Product"
        Me.optProduct.UseVisualStyleBackColor = True
        '
        'optCashSales
        '
        Me.optCashSales.AutoSize = True
        Me.optCashSales.Location = New System.Drawing.Point(186, 12)
        Me.optCashSales.Name = "optCashSales"
        Me.optCashSales.Size = New System.Drawing.Size(76, 17)
        Me.optCashSales.TabIndex = 19
        Me.optCashSales.TabStop = True
        Me.optCashSales.Text = "Cash sales"
        Me.optCashSales.UseVisualStyleBackColor = True
        '
        'lblRecourdCount
        '
        Me.lblRecourdCount.AutoSize = True
        Me.lblRecourdCount.Location = New System.Drawing.Point(471, 18)
        Me.lblRecourdCount.Name = "lblRecourdCount"
        Me.lblRecourdCount.Size = New System.Drawing.Size(0, 13)
        Me.lblRecourdCount.TabIndex = 20
        '
        'frmproductsearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(784, 609)
        Me.Controls.Add(Me.lblRecourdCount)
        Me.Controls.Add(Me.optCashSales)
        Me.Controls.Add(Me.optProduct)
        Me.Controls.Add(Me.chkPartsinformation)
        Me.Controls.Add(Me.lblProductInformation)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.lstSearchField)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdDump)
        Me.Controls.Add(Me.dgvProductInformation)
        Me.Controls.Add(Me.grpSearchCriteria)
        Me.Controls.Add(Me.lblStop)
        Me.Controls.Add(Me.lblStart)
        Me.HelpButton = True
        Me.Name = "frmproductsearch"
        Me.Text = "Search Product"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DsBillPayment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsBillPaymentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSearchCriteria.ResumeLayout(False)
        Me.grpSearchCriteria.PerformLayout()
        CType(Me.dgvProductInformation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsBillPaymentBindingSource As BindingSource
    Friend WithEvents DsBillPayment As dsBillPayment
    Friend WithEvents DataTable1BindingSource As BindingSource
    Friend WithEvents DataTable1TableAdapter As dsBillPaymentTableAdapters.DataTable1TableAdapter
    Friend WithEvents lblStart As Label
    Friend WithEvents lblStop As Label
    Friend WithEvents grpSearchCriteria As GroupBox
    Friend WithEvents txtForthCriteria As TextBox
    Friend WithEvents txtThirdCriteria As TextBox
    Friend WithEvents txtSecondCriteria As TextBox
    Friend WithEvents txtFirstCriteria As TextBox
    Friend WithEvents cmbForthSearchOperator As ComboBox
    Friend WithEvents cmbThirdSearchOperator As ComboBox
    Friend WithEvents cmbSecondSearchOperator As ComboBox
    Friend WithEvents cmbFirstSearchOperator As ComboBox
    Friend WithEvents cmbForthCriteria As ComboBox
    Friend WithEvents cmbThirdCriteria As ComboBox
    Friend WithEvents cmbSecondCriteria As ComboBox
    Friend WithEvents cmbFirstCriteria As ComboBox
    Friend WithEvents dgvProductInformation As DataGridView
    Friend WithEvents cmdDump As Button
    Friend WithEvents cmdClose As Button
    Friend WithEvents lstSearchField As ListView
    Friend WithEvents colFieldName As ColumnHeader
    Friend WithEvents cmdSearch As Button
    Friend WithEvents lblProductInformation As Label
    Friend WithEvents chkPartsinformation As CheckBox
    Friend WithEvents optProduct As RadioButton
    Friend WithEvents optCashSales As RadioButton
    Friend WithEvents lblRecourdCount As Label
End Class
