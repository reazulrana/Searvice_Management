<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOpenCustomerClaim
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
        Me.cmbBranch = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdOpen = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.txtSearchJob = New System.Windows.Forms.TextBox()
        Me.dgvFindList = New System.Windows.Forms.DataGridView()
        Me.optJobCode = New System.Windows.Forms.RadioButton()
        Me.optCustomerName = New System.Windows.Forms.RadioButton()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.optContact = New System.Windows.Forms.RadioButton()
        Me.optAddress = New System.Windows.Forms.RadioButton()
        Me.optEmail = New System.Windows.Forms.RadioButton()
        CType(Me.dgvFindList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbBranch
        '
        Me.cmbBranch.DropDownHeight = 80
        Me.cmbBranch.FormattingEnabled = True
        Me.cmbBranch.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmbBranch.IntegralHeight = False
        Me.cmbBranch.Location = New System.Drawing.Point(56, 11)
        Me.cmbBranch.Name = "cmbBranch"
        Me.cmbBranch.Size = New System.Drawing.Size(216, 21)
        Me.cmbBranch.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Branch"
        '
        'cmdOpen
        '
        Me.cmdOpen.Location = New System.Drawing.Point(529, 61)
        Me.cmdOpen.Name = "cmdOpen"
        Me.cmdOpen.Size = New System.Drawing.Size(109, 23)
        Me.cmdOpen.TabIndex = 2
        Me.cmdOpen.Text = "&Open"
        Me.cmdOpen.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.Location = New System.Drawing.Point(643, 61)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(109, 23)
        Me.cmdClose.TabIndex = 3
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'txtSearchJob
        '
        Me.txtSearchJob.Location = New System.Drawing.Point(59, 62)
        Me.txtSearchJob.Name = "txtSearchJob"
        Me.txtSearchJob.Size = New System.Drawing.Size(464, 20)
        Me.txtSearchJob.TabIndex = 1
        '
        'dgvFindList
        '
        Me.dgvFindList.AllowUserToAddRows = False
        Me.dgvFindList.AllowUserToDeleteRows = False
        Me.dgvFindList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFindList.Location = New System.Drawing.Point(12, 86)
        Me.dgvFindList.Name = "dgvFindList"
        Me.dgvFindList.ReadOnly = True
        Me.dgvFindList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFindList.Size = New System.Drawing.Size(740, 188)
        Me.dgvFindList.TabIndex = 4
        '
        'optJobCode
        '
        Me.optJobCode.AutoSize = True
        Me.optJobCode.Location = New System.Drawing.Point(59, 39)
        Me.optJobCode.Name = "optJobCode"
        Me.optJobCode.Size = New System.Drawing.Size(59, 17)
        Me.optJobCode.TabIndex = 8
        Me.optJobCode.TabStop = True
        Me.optJobCode.Text = "&Job No"
        Me.optJobCode.UseVisualStyleBackColor = True
        '
        'optCustomerName
        '
        Me.optCustomerName.AutoSize = True
        Me.optCustomerName.Location = New System.Drawing.Point(122, 39)
        Me.optCustomerName.Name = "optCustomerName"
        Me.optCustomerName.Size = New System.Drawing.Size(69, 17)
        Me.optCustomerName.TabIndex = 10
        Me.optCustomerName.TabStop = True
        Me.optCustomerName.Text = "C&ustomer"
        Me.optCustomerName.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.DarkOrange
        Me.lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblStatus.ForeColor = System.Drawing.Color.Maroon
        Me.lblStatus.Location = New System.Drawing.Point(0, 289)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(754, 19)
        Me.lblStatus.TabIndex = 11
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Search"
        '
        'optContact
        '
        Me.optContact.AutoSize = True
        Me.optContact.Location = New System.Drawing.Point(266, 39)
        Me.optContact.Name = "optContact"
        Me.optContact.Size = New System.Drawing.Size(62, 17)
        Me.optContact.TabIndex = 14
        Me.optContact.TabStop = True
        Me.optContact.Text = "&Contact"
        Me.optContact.UseVisualStyleBackColor = True
        '
        'optAddress
        '
        Me.optAddress.AutoSize = True
        Me.optAddress.Location = New System.Drawing.Point(197, 39)
        Me.optAddress.Name = "optAddress"
        Me.optAddress.Size = New System.Drawing.Size(63, 17)
        Me.optAddress.TabIndex = 13
        Me.optAddress.TabStop = True
        Me.optAddress.Text = "&Address"
        Me.optAddress.UseVisualStyleBackColor = True
        '
        'optEmail
        '
        Me.optEmail.AutoSize = True
        Me.optEmail.Location = New System.Drawing.Point(334, 39)
        Me.optEmail.Name = "optEmail"
        Me.optEmail.Size = New System.Drawing.Size(50, 17)
        Me.optEmail.TabIndex = 15
        Me.optEmail.TabStop = True
        Me.optEmail.Text = "&Email"
        Me.optEmail.UseVisualStyleBackColor = True
        '
        'frmOpenCustomerClaim
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.CancelButton = Me.cmdClose
        Me.ClientSize = New System.Drawing.Size(754, 308)
        Me.Controls.Add(Me.optEmail)
        Me.Controls.Add(Me.optContact)
        Me.Controls.Add(Me.optAddress)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.optCustomerName)
        Me.Controls.Add(Me.optJobCode)
        Me.Controls.Add(Me.dgvFindList)
        Me.Controls.Add(Me.txtSearchJob)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdOpen)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbBranch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmOpenCustomerClaim"
        Me.Text = "Open Customer Claim"
        CType(Me.dgvFindList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbBranch As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdOpen As Button
    Friend WithEvents cmdClose As Button
    Friend WithEvents txtSearchJob As TextBox
    Friend WithEvents dgvFindList As DataGridView
    Friend WithEvents optJobCode As RadioButton
    Friend WithEvents optCustomerName As RadioButton
    Friend WithEvents lblStatus As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents optContact As RadioButton
    Friend WithEvents optAddress As RadioButton
    Friend WithEvents optEmail As RadioButton
End Class
