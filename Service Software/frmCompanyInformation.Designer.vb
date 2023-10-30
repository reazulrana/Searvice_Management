<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompanyInformation
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstCompanylist = New System.Windows.Forms.ListView()
        Me.colCompanyInformationSl = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colCompanyName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colOwnerName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colAddress = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colContactNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDepartment = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTotalEmployee = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.grpCompanyDetails = New System.Windows.Forms.GroupBox()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTotalEmployee = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDepartment = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtContactNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtOwnerName = New System.Windows.Forms.TextBox()
        Me.txtCompanyName = New System.Windows.Forms.TextBox()
        Me.lblCompanyDetails = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.grpCompanyDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstCompanylist)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 191)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(767, 185)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Company Information List"
        '
        'lstCompanylist
        '
        Me.lstCompanylist.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colCompanyInformationSl, Me.colCompanyName, Me.colOwnerName, Me.colAddress, Me.colContactNo, Me.colDepartment, Me.colTotalEmployee})
        Me.lstCompanylist.FullRowSelect = True
        Me.lstCompanylist.Location = New System.Drawing.Point(4, 17)
        Me.lstCompanylist.Name = "lstCompanylist"
        Me.lstCompanylist.Size = New System.Drawing.Size(760, 162)
        Me.lstCompanylist.TabIndex = 13
        Me.lstCompanylist.UseCompatibleStateImageBehavior = False
        Me.lstCompanylist.View = System.Windows.Forms.View.Details
        '
        'colCompanyInformationSl
        '
        Me.colCompanyInformationSl.Text = "SL"
        Me.colCompanyInformationSl.Width = 30
        '
        'colCompanyName
        '
        Me.colCompanyName.Text = "Name of Company"
        Me.colCompanyName.Width = 160
        '
        'colOwnerName
        '
        Me.colOwnerName.Text = "Owner Name"
        Me.colOwnerName.Width = 150
        '
        'colAddress
        '
        Me.colAddress.Text = "Address"
        Me.colAddress.Width = 185
        '
        'colContactNo
        '
        Me.colContactNo.Text = "Contact No."
        Me.colContactNo.Width = 85
        '
        'colDepartment
        '
        Me.colDepartment.Text = "Department"
        Me.colDepartment.Width = 80
        '
        'colTotalEmployee
        '
        Me.colTotalEmployee.Text = "Employee"
        '
        'grpCompanyDetails
        '
        Me.grpCompanyDetails.Controls.Add(Me.cmdDelete)
        Me.grpCompanyDetails.Controls.Add(Me.cmdClose)
        Me.grpCompanyDetails.Controls.Add(Me.cmdClear)
        Me.grpCompanyDetails.Controls.Add(Me.cmdSave)
        Me.grpCompanyDetails.Controls.Add(Me.Label6)
        Me.grpCompanyDetails.Controls.Add(Me.txtTotalEmployee)
        Me.grpCompanyDetails.Controls.Add(Me.Label5)
        Me.grpCompanyDetails.Controls.Add(Me.txtDepartment)
        Me.grpCompanyDetails.Controls.Add(Me.Label4)
        Me.grpCompanyDetails.Controls.Add(Me.txtContactNo)
        Me.grpCompanyDetails.Controls.Add(Me.Label3)
        Me.grpCompanyDetails.Controls.Add(Me.Label2)
        Me.grpCompanyDetails.Controls.Add(Me.Label1)
        Me.grpCompanyDetails.Controls.Add(Me.txtAddress)
        Me.grpCompanyDetails.Controls.Add(Me.txtOwnerName)
        Me.grpCompanyDetails.Controls.Add(Me.txtCompanyName)
        Me.grpCompanyDetails.Controls.Add(Me.lblCompanyDetails)
        Me.grpCompanyDetails.Location = New System.Drawing.Point(4, 2)
        Me.grpCompanyDetails.Name = "grpCompanyDetails"
        Me.grpCompanyDetails.Size = New System.Drawing.Size(764, 183)
        Me.grpCompanyDetails.TabIndex = 13
        Me.grpCompanyDetails.TabStop = False
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(572, 83)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(186, 23)
        Me.cmdDelete.TabIndex = 35
        Me.cmdDelete.Text = "&Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(572, 129)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(186, 23)
        Me.cmdClose.TabIndex = 31
        Me.cmdClose.Text = "C&lose"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        Me.cmdClear.Location = New System.Drawing.Point(572, 106)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(186, 23)
        Me.cmdClear.TabIndex = 30
        Me.cmdClear.Text = "&Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(572, 60)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(186, 23)
        Me.cmdSave.TabIndex = 29
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(386, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Total Employee:"
        '
        'txtTotalEmployee
        '
        Me.txtTotalEmployee.Location = New System.Drawing.Point(475, 153)
        Me.txtTotalEmployee.Name = "txtTotalEmployee"
        Me.txtTotalEmployee.Size = New System.Drawing.Size(89, 20)
        Me.txtTotalEmployee.TabIndex = 27
        Me.txtTotalEmployee.Text = "0"
        Me.txtTotalEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(41, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "* Department:"
        '
        'txtDepartment
        '
        Me.txtDepartment.Location = New System.Drawing.Point(116, 153)
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.Size = New System.Drawing.Size(267, 20)
        Me.txtDepartment.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(49, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Contact No:"
        '
        'txtContactNo
        '
        Me.txtContactNo.Location = New System.Drawing.Point(116, 130)
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.Size = New System.Drawing.Size(448, 20)
        Me.txtContactNo.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(65, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Address:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Owner Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(9, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "* Name of Company:"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(116, 107)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(448, 20)
        Me.txtAddress.TabIndex = 19
        '
        'txtOwnerName
        '
        Me.txtOwnerName.Location = New System.Drawing.Point(116, 84)
        Me.txtOwnerName.Name = "txtOwnerName"
        Me.txtOwnerName.Size = New System.Drawing.Size(448, 20)
        Me.txtOwnerName.TabIndex = 18
        '
        'txtCompanyName
        '
        Me.txtCompanyName.Location = New System.Drawing.Point(116, 61)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Size = New System.Drawing.Size(448, 20)
        Me.txtCompanyName.TabIndex = 17
        '
        'lblCompanyDetails
        '
        Me.lblCompanyDetails.AutoSize = True
        Me.lblCompanyDetails.Font = New System.Drawing.Font("Times New Roman", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompanyDetails.ForeColor = System.Drawing.Color.Red
        Me.lblCompanyDetails.Location = New System.Drawing.Point(253, 14)
        Me.lblCompanyDetails.Name = "lblCompanyDetails"
        Me.lblCompanyDetails.Size = New System.Drawing.Size(267, 38)
        Me.lblCompanyDetails.TabIndex = 32
        Me.lblCompanyDetails.Text = "Company Details"
        '
        'frmCompanyInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(776, 378)
        Me.Controls.Add(Me.grpCompanyDetails)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCompanyInformation"
        Me.Text = "New Company"
        Me.GroupBox1.ResumeLayout(False)
        Me.grpCompanyDetails.ResumeLayout(False)
        Me.grpCompanyDetails.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lstCompanylist As ListView
    Friend WithEvents colCompanyInformationSl As ColumnHeader
    Friend WithEvents colCompanyName As ColumnHeader
    Friend WithEvents colOwnerName As ColumnHeader
    Friend WithEvents colAddress As ColumnHeader
    Friend WithEvents colContactNo As ColumnHeader
    Friend WithEvents colDepartment As ColumnHeader
    Friend WithEvents colTotalEmployee As ColumnHeader
    Friend WithEvents grpCompanyDetails As GroupBox
    Friend WithEvents cmdClose As Button
    Friend WithEvents cmdClear As Button
    Friend WithEvents cmdSave As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTotalEmployee As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDepartment As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtContactNo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtOwnerName As TextBox
    Friend WithEvents txtCompanyName As TextBox
    Friend WithEvents lblCompanyDetails As Label
    Friend WithEvents cmdDelete As Button
End Class
