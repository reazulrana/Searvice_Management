<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCashSalesReport
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
        Me.lblBottom = New System.Windows.Forms.Label()
        Me.grpInformation = New System.Windows.Forms.GroupBox()
        Me.chkSvcWarranty = New System.Windows.Forms.CheckBox()
        Me.chkNonWarranty = New System.Windows.Forms.CheckBox()
        Me.chkSalesWarranty = New System.Windows.Forms.CheckBox()
        Me.cmbModel = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbBrand = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbBranch = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnReportShow = New System.Windows.Forms.Button()
        Me.grpInformation.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeader.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.Maroon
        Me.lblHeader.Location = New System.Drawing.Point(0, 0)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblHeader.Size = New System.Drawing.Size(317, 21)
        Me.lblHeader.TabIndex = 12
        Me.lblHeader.Text = "Cash Sales"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBottom
        '
        Me.lblBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblBottom.Location = New System.Drawing.Point(0, 284)
        Me.lblBottom.Name = "lblBottom"
        Me.lblBottom.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblBottom.Size = New System.Drawing.Size(317, 10)
        Me.lblBottom.TabIndex = 13
        Me.lblBottom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grpInformation
        '
        Me.grpInformation.Controls.Add(Me.chkSvcWarranty)
        Me.grpInformation.Controls.Add(Me.chkNonWarranty)
        Me.grpInformation.Controls.Add(Me.chkSalesWarranty)
        Me.grpInformation.Controls.Add(Me.cmbModel)
        Me.grpInformation.Controls.Add(Me.Label4)
        Me.grpInformation.Controls.Add(Me.cmbBrand)
        Me.grpInformation.Controls.Add(Me.Label3)
        Me.grpInformation.Controls.Add(Me.cmbCategory)
        Me.grpInformation.Controls.Add(Me.Label2)
        Me.grpInformation.Controls.Add(Me.cmbBranch)
        Me.grpInformation.Controls.Add(Me.Label1)
        Me.grpInformation.Location = New System.Drawing.Point(9, 111)
        Me.grpInformation.Name = "grpInformation"
        Me.grpInformation.Size = New System.Drawing.Size(299, 142)
        Me.grpInformation.TabIndex = 14
        Me.grpInformation.TabStop = False
        Me.grpInformation.Text = "Information"
        '
        'chkSvcWarranty
        '
        Me.chkSvcWarranty.AutoSize = True
        Me.chkSvcWarranty.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSvcWarranty.Location = New System.Drawing.Point(202, 120)
        Me.chkSvcWarranty.Name = "chkSvcWarranty"
        Me.chkSvcWarranty.Size = New System.Drawing.Size(88, 17)
        Me.chkSvcWarranty.TabIndex = 20
        Me.chkSvcWarranty.Text = "Svc-Warranty"
        Me.chkSvcWarranty.UseVisualStyleBackColor = True
        '
        'chkNonWarranty
        '
        Me.chkNonWarranty.AutoSize = True
        Me.chkNonWarranty.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNonWarranty.Location = New System.Drawing.Point(107, 120)
        Me.chkNonWarranty.Name = "chkNonWarranty"
        Me.chkNonWarranty.Size = New System.Drawing.Size(89, 17)
        Me.chkNonWarranty.TabIndex = 19
        Me.chkNonWarranty.Text = "Non-Warranty"
        Me.chkNonWarranty.UseVisualStyleBackColor = True
        '
        'chkSalesWarranty
        '
        Me.chkSalesWarranty.AutoSize = True
        Me.chkSalesWarranty.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSalesWarranty.Location = New System.Drawing.Point(9, 120)
        Me.chkSalesWarranty.Name = "chkSalesWarranty"
        Me.chkSalesWarranty.Size = New System.Drawing.Size(96, 17)
        Me.chkSalesWarranty.TabIndex = 18
        Me.chkSalesWarranty.Text = "Sales Warranty"
        Me.chkSalesWarranty.UseVisualStyleBackColor = True
        '
        'cmbModel
        '
        Me.cmbModel.FormattingEnabled = True
        Me.cmbModel.Location = New System.Drawing.Point(64, 93)
        Me.cmbModel.Name = "cmbModel"
        Me.cmbModel.Size = New System.Drawing.Size(221, 21)
        Me.cmbModel.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Model"
        '
        'cmbBrand
        '
        Me.cmbBrand.FormattingEnabled = True
        Me.cmbBrand.Location = New System.Drawing.Point(64, 68)
        Me.cmbBrand.Name = "cmbBrand"
        Me.cmbBrand.Size = New System.Drawing.Size(221, 21)
        Me.cmbBrand.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Brand"
        '
        'cmbCategory
        '
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(64, 43)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(221, 21)
        Me.cmbCategory.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Category"
        '
        'cmbBranch
        '
        Me.cmbBranch.FormattingEnabled = True
        Me.cmbBranch.Location = New System.Drawing.Point(64, 18)
        Me.cmbBranch.Name = "cmbBranch"
        Me.cmbBranch.Size = New System.Drawing.Size(221, 21)
        Me.cmbBranch.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Branch"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblTo)
        Me.GroupBox2.Controls.Add(Me.lblFrom)
        Me.GroupBox2.Controls.Add(Me.dtpTo)
        Me.GroupBox2.Controls.Add(Me.dtpFrom)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(296, 76)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Date Information"
        '
        'lblTo
        '
        Me.lblTo.Location = New System.Drawing.Point(10, 49)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(111, 13)
        Me.lblTo.TabIndex = 15
        Me.lblTo.Text = "To"
        Me.lblTo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFrom
        '
        Me.lblFrom.Location = New System.Drawing.Point(10, 23)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(111, 13)
        Me.lblFrom.TabIndex = 14
        Me.lblFrom.Text = "From"
        Me.lblFrom.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpTo
        '
        Me.dtpTo.CustomFormat = "DD-MMM-YY"
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTo.Location = New System.Drawing.Point(125, 45)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(162, 20)
        Me.dtpTo.TabIndex = 13
        '
        'dtpFrom
        '
        Me.dtpFrom.CustomFormat = "DD-MMM-YY"
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFrom.Location = New System.Drawing.Point(125, 19)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(162, 20)
        Me.dtpFrom.TabIndex = 12
        '
        'lblClose
        '
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblClose.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.ForeColor = System.Drawing.Color.Maroon
        Me.lblClose.Location = New System.Drawing.Point(298, 0)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(17, 19)
        Me.lblClose.TabIndex = 16
        Me.lblClose.Text = "x"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(160, 257)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(145, 23)
        Me.btnClose.TabIndex = 19
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnReportShow
        '
        Me.btnReportShow.Location = New System.Drawing.Point(12, 257)
        Me.btnReportShow.Name = "btnReportShow"
        Me.btnReportShow.Size = New System.Drawing.Size(141, 23)
        Me.btnReportShow.TabIndex = 18
        Me.btnReportShow.Text = "&Report"
        Me.btnReportShow.UseVisualStyleBackColor = True
        '
        'frmCashSalesReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(317, 294)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnReportShow)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grpInformation)
        Me.Controls.Add(Me.lblBottom)
        Me.Controls.Add(Me.lblHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCashSalesReport"
        Me.Text = "frmCashSalesReport"
        Me.grpInformation.ResumeLayout(False)
        Me.grpInformation.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHeader As Label
    Friend WithEvents lblBottom As Label
    Friend WithEvents grpInformation As GroupBox
    Friend WithEvents cmbModel As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbBrand As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbBranch As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblTo As Label
    Friend WithEvents lblFrom As Label
    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents lblClose As Label
    Friend WithEvents chkSvcWarranty As CheckBox
    Friend WithEvents chkNonWarranty As CheckBox
    Friend WithEvents chkSalesWarranty As CheckBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnReportShow As Button
End Class
