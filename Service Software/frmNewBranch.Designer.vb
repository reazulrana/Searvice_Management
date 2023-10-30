<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewBranch
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
        Me.lstNewBranch = New System.Windows.Forms.ListView()
        Me.colSL = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colBranchName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Contact = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colBranchcondition = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colBranchHour = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colHoliday = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colAddress = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblBranch = New System.Windows.Forms.Label()
        Me.cmdNewBranch = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.txtBranchName = New System.Windows.Forms.TextBox()
        Me.txtContactName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtHoliday = New System.Windows.Forms.TextBox()
        Me.txtOfficeTime = New System.Windows.Forms.TextBox()
        Me.chkEdit = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.lblBottomLayer = New System.Windows.Forms.Label()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstNewBranch
        '
        Me.lstNewBranch.BackColor = System.Drawing.Color.Olive
        Me.lstNewBranch.CheckBoxes = True
        Me.lstNewBranch.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colSL, Me.colBranchName, Me.Contact, Me.colBranchcondition, Me.colBranchHour, Me.colHoliday, Me.colAddress})
        Me.lstNewBranch.FullRowSelect = True
        Me.lstNewBranch.GridLines = True
        Me.lstNewBranch.Location = New System.Drawing.Point(4, 62)
        Me.lstNewBranch.Name = "lstNewBranch"
        Me.lstNewBranch.Size = New System.Drawing.Size(679, 367)
        Me.lstNewBranch.TabIndex = 0
        Me.lstNewBranch.UseCompatibleStateImageBehavior = False
        Me.lstNewBranch.View = System.Windows.Forms.View.Details
        '
        'colSL
        '
        Me.colSL.Text = "SL"
        Me.colSL.Width = 33
        '
        'colBranchName
        '
        Me.colBranchName.Text = "Branch Name"
        Me.colBranchName.Width = 97
        '
        'Contact
        '
        Me.Contact.Text = "Contact Information"
        Me.Contact.Width = 151
        '
        'colBranchcondition
        '
        Me.colBranchcondition.Text = "Status"
        Me.colBranchcondition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colBranchcondition.Width = 80
        '
        'colBranchHour
        '
        Me.colBranchHour.Text = "Office Hour"
        Me.colBranchHour.Width = 102
        '
        'colHoliday
        '
        Me.colHoliday.Text = "Holiday"
        Me.colHoliday.Width = 80
        '
        'colAddress
        '
        Me.colAddress.Text = "Address"
        Me.colAddress.Width = 129
        '
        'lblBranch
        '
        Me.lblBranch.AutoSize = True
        Me.lblBranch.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBranch.ForeColor = System.Drawing.Color.White
        Me.lblBranch.Location = New System.Drawing.Point(6, 42)
        Me.lblBranch.Name = "lblBranch"
        Me.lblBranch.Size = New System.Drawing.Size(107, 17)
        Me.lblBranch.TabIndex = 1
        Me.lblBranch.Text = "Total Branches"
        '
        'cmdNewBranch
        '
        Me.cmdNewBranch.BackColor = System.Drawing.Color.Olive
        Me.cmdNewBranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdNewBranch.ForeColor = System.Drawing.Color.White
        Me.cmdNewBranch.Location = New System.Drawing.Point(114, 493)
        Me.cmdNewBranch.Name = "cmdNewBranch"
        Me.cmdNewBranch.Size = New System.Drawing.Size(81, 22)
        Me.cmdNewBranch.TabIndex = 4
        Me.cmdNewBranch.Text = "&New Branch"
        Me.cmdNewBranch.UseVisualStyleBackColor = False
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.Color.Olive
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClose.ForeColor = System.Drawing.Color.White
        Me.cmdClose.Location = New System.Drawing.Point(288, 493)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(81, 22)
        Me.cmdClose.TabIndex = 5
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'txtBranchName
        '
        Me.txtBranchName.BackColor = System.Drawing.Color.White
        Me.txtBranchName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBranchName.ForeColor = System.Drawing.Color.Black
        Me.txtBranchName.Location = New System.Drawing.Point(98, 436)
        Me.txtBranchName.Multiline = True
        Me.txtBranchName.Name = "txtBranchName"
        Me.txtBranchName.Size = New System.Drawing.Size(147, 20)
        Me.txtBranchName.TabIndex = 0
        '
        'txtContactName
        '
        Me.txtContactName.BackColor = System.Drawing.Color.White
        Me.txtContactName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContactName.ForeColor = System.Drawing.Color.Black
        Me.txtContactName.Location = New System.Drawing.Point(98, 459)
        Me.txtContactName.Multiline = True
        Me.txtContactName.Name = "txtContactName"
        Me.txtContactName.Size = New System.Drawing.Size(147, 20)
        Me.txtContactName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.Label2.Location = New System.Drawing.Point(10, 439)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Branch Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.Label3.Location = New System.Drawing.Point(45, 462)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Contact"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.Label1.Location = New System.Drawing.Point(510, 462)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 15)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Holiday"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.Label4.Location = New System.Drawing.Point(250, 462)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 15)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Office Time"
        '
        'txtHoliday
        '
        Me.txtHoliday.BackColor = System.Drawing.Color.White
        Me.txtHoliday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHoliday.ForeColor = System.Drawing.Color.Black
        Me.txtHoliday.Location = New System.Drawing.Point(557, 459)
        Me.txtHoliday.Multiline = True
        Me.txtHoliday.Name = "txtHoliday"
        Me.txtHoliday.Size = New System.Drawing.Size(119, 20)
        Me.txtHoliday.TabIndex = 3
        '
        'txtOfficeTime
        '
        Me.txtOfficeTime.BackColor = System.Drawing.Color.White
        Me.txtOfficeTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOfficeTime.ForeColor = System.Drawing.Color.Black
        Me.txtOfficeTime.Location = New System.Drawing.Point(324, 459)
        Me.txtOfficeTime.Multiline = True
        Me.txtOfficeTime.Name = "txtOfficeTime"
        Me.txtOfficeTime.Size = New System.Drawing.Size(180, 20)
        Me.txtOfficeTime.TabIndex = 2
        '
        'chkEdit
        '
        Me.chkEdit.AutoSize = True
        Me.chkEdit.ForeColor = System.Drawing.Color.White
        Me.chkEdit.Location = New System.Drawing.Point(155, 42)
        Me.chkEdit.Name = "chkEdit"
        Me.chkEdit.Size = New System.Drawing.Size(74, 17)
        Me.chkEdit.TabIndex = 13
        Me.chkEdit.Text = "Edit Mode"
        Me.chkEdit.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Olive
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(-9, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.Label5.Size = New System.Drawing.Size(698, 30)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Branch Information"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblClose
        '
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.Color.Olive
        Me.lblClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblClose.Location = New System.Drawing.Point(655, 9)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(17, 16)
        Me.lblClose.TabIndex = 15
        Me.lblClose.Text = "X"
        '
        'lblBottomLayer
        '
        Me.lblBottomLayer.BackColor = System.Drawing.Color.Olive
        Me.lblBottomLayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblBottomLayer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBottomLayer.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblBottomLayer.Location = New System.Drawing.Point(-3, 518)
        Me.lblBottomLayer.Name = "lblBottomLayer"
        Me.lblBottomLayer.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.lblBottomLayer.Size = New System.Drawing.Size(698, 9)
        Me.lblBottomLayer.TabIndex = 16
        Me.lblBottomLayer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdDelete
        '
        Me.cmdDelete.BackColor = System.Drawing.Color.Olive
        Me.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDelete.ForeColor = System.Drawing.Color.White
        Me.cmdDelete.Location = New System.Drawing.Point(201, 493)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(81, 22)
        Me.cmdDelete.TabIndex = 17
        Me.cmdDelete.Text = "&Delete"
        Me.cmdDelete.UseVisualStyleBackColor = False
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.Color.White
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress.ForeColor = System.Drawing.Color.Black
        Me.txtAddress.Location = New System.Drawing.Point(305, 436)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(371, 20)
        Me.txtAddress.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.Label6.Location = New System.Drawing.Point(250, 439)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 15)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Address"
        '
        'frmNewBranch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(684, 527)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.lblBottomLayer)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtHoliday)
        Me.Controls.Add(Me.txtOfficeTime)
        Me.Controls.Add(Me.txtContactName)
        Me.Controls.Add(Me.txtBranchName)
        Me.Controls.Add(Me.chkEdit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdNewBranch)
        Me.Controls.Add(Me.lblBranch)
        Me.Controls.Add(Me.lstNewBranch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNewBranch"
        Me.Text = "New Branch"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstNewBranch As ListView
    Friend WithEvents lblBranch As Label
    Friend WithEvents cmdNewBranch As Button
    Friend WithEvents cmdClose As Button
    Friend WithEvents txtBranchName As TextBox
    Friend WithEvents txtContactName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents colSL As ColumnHeader
    Friend WithEvents colBranchName As ColumnHeader
    Friend WithEvents Contact As ColumnHeader
    Friend WithEvents colBranchcondition As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtHoliday As TextBox
    Friend WithEvents txtOfficeTime As TextBox
    Friend WithEvents chkEdit As CheckBox
    Friend WithEvents colBranchHour As ColumnHeader
    Friend WithEvents colHoliday As ColumnHeader
    Friend WithEvents Label5 As Label
    Friend WithEvents lblClose As Label
    Friend WithEvents lblBottomLayer As Label
    Friend WithEvents cmdDelete As Button
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents colAddress As ColumnHeader
End Class
