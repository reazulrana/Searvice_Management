<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreateUser
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lstUser = New System.Windows.Forms.ListView()
        Me.colUserSL = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colUserName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPassword = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colUserType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colUserPrivilege = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cntxDelete = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtOldPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkSelect = New System.Windows.Forms.CheckBox()
        Me.chkDelete = New System.Windows.Forms.CheckBox()
        Me.chkUpdate = New System.Windows.Forms.CheckBox()
        Me.chkInsert = New System.Windows.Forms.CheckBox()
        Me.cmbUserType = New System.Windows.Forms.ComboBox()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.cntxDelete.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.GroupBox1.Controls.Add(Me.lblID)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lstUser)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtOldPassword)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.chkSelect)
        Me.GroupBox1.Controls.Add(Me.chkDelete)
        Me.GroupBox1.Controls.Add(Me.chkUpdate)
        Me.GroupBox1.Controls.Add(Me.chkInsert)
        Me.GroupBox1.Controls.Add(Me.cmbUserType)
        Me.GroupBox1.Controls.Add(Me.txtNewPassword)
        Me.GroupBox1.Controls.Add(Me.txtUserName)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Snow
        Me.GroupBox1.Location = New System.Drawing.Point(4, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(507, 335)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        '
        'lblID
        '
        Me.lblID.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.ForeColor = System.Drawing.Color.Red
        Me.lblID.Location = New System.Drawing.Point(107, 13)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(65, 4)
        Me.lblID.TabIndex = 32
        Me.lblID.Visible = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(-3, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(514, 1)
        Me.Label5.TabIndex = 31
        '
        'lstUser
        '
        Me.lstUser.BackColor = System.Drawing.Color.DarkKhaki
        Me.lstUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstUser.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colUserSL, Me.colUserName, Me.colPassword, Me.colUserType, Me.colUserPrivilege})
        Me.lstUser.ContextMenuStrip = Me.cntxDelete
        Me.lstUser.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lstUser.FullRowSelect = True
        Me.lstUser.GridLines = True
        Me.lstUser.Location = New System.Drawing.Point(7, 149)
        Me.lstUser.Name = "lstUser"
        Me.lstUser.Size = New System.Drawing.Size(492, 180)
        Me.lstUser.TabIndex = 30
        Me.lstUser.UseCompatibleStateImageBehavior = False
        Me.lstUser.View = System.Windows.Forms.View.Details
        '
        'colUserSL
        '
        Me.colUserSL.Text = "SL"
        Me.colUserSL.Width = 26
        '
        'colUserName
        '
        Me.colUserName.Text = "User Name"
        Me.colUserName.Width = 130
        '
        'colPassword
        '
        Me.colPassword.Text = "Password"
        Me.colPassword.Width = 85
        '
        'colUserType
        '
        Me.colUserType.Text = "Type"
        Me.colUserType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colUserType.Width = 56
        '
        'colUserPrivilege
        '
        Me.colUserPrivilege.Text = "Privilege"
        Me.colUserPrivilege.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colUserPrivilege.Width = 189
        '
        'cntxDelete
        '
        Me.cntxDelete.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDelete})
        Me.cntxDelete.Name = "cntxDelete"
        Me.cntxDelete.Size = New System.Drawing.Size(108, 26)
        '
        'mnuDelete
        '
        Me.mnuDelete.Name = "mnuDelete"
        Me.mnuDelete.Size = New System.Drawing.Size(107, 22)
        Me.mnuDelete.Text = "&Delete"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(19, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 15)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Old Password"
        '
        'txtOldPassword
        '
        Me.txtOldPassword.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOldPassword.Location = New System.Drawing.Point(101, 45)
        Me.txtOldPassword.Name = "txtOldPassword"
        Me.txtOldPassword.Size = New System.Drawing.Size(398, 22)
        Me.txtOldPassword.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(35, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 15)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "User Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(13, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 15)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "New Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(31, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 15)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "User Name"
        '
        'chkSelect
        '
        Me.chkSelect.AutoSize = True
        Me.chkSelect.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSelect.ForeColor = System.Drawing.Color.Red
        Me.chkSelect.Location = New System.Drawing.Point(440, 117)
        Me.chkSelect.Name = "chkSelect"
        Me.chkSelect.Size = New System.Drawing.Size(58, 19)
        Me.chkSelect.TabIndex = 24
        Me.chkSelect.Text = "Select"
        Me.chkSelect.UseVisualStyleBackColor = True
        '
        'chkDelete
        '
        Me.chkDelete.AutoSize = True
        Me.chkDelete.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDelete.ForeColor = System.Drawing.Color.Red
        Me.chkDelete.Location = New System.Drawing.Point(319, 117)
        Me.chkDelete.Name = "chkDelete"
        Me.chkDelete.Size = New System.Drawing.Size(60, 19)
        Me.chkDelete.TabIndex = 23
        Me.chkDelete.Text = "Delete"
        Me.chkDelete.UseVisualStyleBackColor = True
        '
        'chkUpdate
        '
        Me.chkUpdate.AutoSize = True
        Me.chkUpdate.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkUpdate.ForeColor = System.Drawing.Color.Red
        Me.chkUpdate.Location = New System.Drawing.Point(204, 117)
        Me.chkUpdate.Name = "chkUpdate"
        Me.chkUpdate.Size = New System.Drawing.Size(65, 19)
        Me.chkUpdate.TabIndex = 22
        Me.chkUpdate.Text = "Update"
        Me.chkUpdate.UseVisualStyleBackColor = True
        '
        'chkInsert
        '
        Me.chkInsert.AutoSize = True
        Me.chkInsert.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkInsert.ForeColor = System.Drawing.Color.Red
        Me.chkInsert.Location = New System.Drawing.Point(101, 117)
        Me.chkInsert.Name = "chkInsert"
        Me.chkInsert.Size = New System.Drawing.Size(57, 19)
        Me.chkInsert.TabIndex = 21
        Me.chkInsert.Text = "Insert"
        Me.chkInsert.UseVisualStyleBackColor = True
        '
        'cmbUserType
        '
        Me.cmbUserType.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUserType.FormattingEnabled = True
        Me.cmbUserType.Items.AddRange(New Object() {"Admin", "User"})
        Me.cmbUserType.Location = New System.Drawing.Point(101, 92)
        Me.cmbUserType.Name = "cmbUserType"
        Me.cmbUserType.Size = New System.Drawing.Size(398, 23)
        Me.cmbUserType.TabIndex = 20
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPassword.Location = New System.Drawing.Point(101, 68)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.Size = New System.Drawing.Size(398, 22)
        Me.txtNewPassword.TabIndex = 19
        '
        'txtUserName
        '
        Me.txtUserName.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.Location = New System.Drawing.Point(101, 21)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(398, 22)
        Me.txtUserName.TabIndex = 18
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnEdit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.Crimson
        Me.btnEdit.Location = New System.Drawing.Point(108, 375)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(98, 24)
        Me.btnEdit.TabIndex = 23
        Me.btnEdit.Text = "&Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnExit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Crimson
        Me.btnExit.Location = New System.Drawing.Point(413, 375)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(98, 24)
        Me.btnExit.TabIndex = 22
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnSave.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Crimson
        Me.btnSave.Location = New System.Drawing.Point(312, 375)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(98, 24)
        Me.btnSave.TabIndex = 21
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCreate
        '
        Me.btnCreate.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnCreate.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.ForeColor = System.Drawing.Color.Crimson
        Me.btnCreate.Location = New System.Drawing.Point(4, 375)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(98, 24)
        Me.btnCreate.TabIndex = 20
        Me.btnCreate.Text = "&Create"
        Me.btnCreate.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnReset.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.Crimson
        Me.btnReset.Location = New System.Drawing.Point(210, 375)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(98, 24)
        Me.btnReset.TabIndex = 24
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'lblHeader
        '
        Me.lblHeader.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.lblHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeader.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblHeader.Location = New System.Drawing.Point(0, 0)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblHeader.Size = New System.Drawing.Size(518, 33)
        Me.lblHeader.TabIndex = 25
        Me.lblHeader.Text = "User Information"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblClose
        '
        Me.lblClose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.lblClose.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.Location = New System.Drawing.Point(495, 10)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(16, 15)
        Me.lblClose.TabIndex = 26
        Me.lblClose.Text = "X"
        '
        'frmCreateUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Moccasin
        Me.ClientSize = New System.Drawing.Size(518, 404)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCreateUser"
        Me.Text = "User Information"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.cntxDelete.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtOldPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents chkSelect As CheckBox
    Friend WithEvents chkDelete As CheckBox
    Friend WithEvents chkUpdate As CheckBox
    Friend WithEvents chkInsert As CheckBox
    Friend WithEvents cmbUserType As ComboBox
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lstUser As ListView
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents lblHeader As Label
    Friend WithEvents lblClose As Label
    Friend WithEvents colUserSL As ColumnHeader
    Friend WithEvents colUserName As ColumnHeader
    Friend WithEvents colUserType As ColumnHeader
    Friend WithEvents colUserPrivilege As ColumnHeader
    Friend WithEvents lblID As Label
    Friend WithEvents colPassword As ColumnHeader
    Friend WithEvents cntxDelete As ContextMenuStrip
    Friend WithEvents mnuDelete As ToolStripMenuItem
End Class
