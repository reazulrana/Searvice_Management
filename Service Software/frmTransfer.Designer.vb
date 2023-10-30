<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTransfer
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbBranch = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbTansferby = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.dtTrDate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTransferby = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.chkActiveJob = New System.Windows.Forms.CheckBox()
        Me.txtJobCode = New System.Windows.Forms.TextBox()
        Me.chkActiveBranch = New System.Windows.Forms.CheckBox()
        Me.cmbBranchFrom = New System.Windows.Forms.ComboBox()
        Me.dgvJobList = New System.Windows.Forms.DataGridView()
        Me.pnlBottomStatus = New System.Windows.Forms.Panel()
        Me.lblStatus = New System.Windows.Forms.Label()
        CType(Me.dgvJobList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBottomStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(25, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Job No:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(238, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Transfer From:"
        '
        'cmbBranch
        '
        Me.cmbBranch.FormattingEnabled = True
        Me.cmbBranch.Location = New System.Drawing.Point(315, 39)
        Me.cmbBranch.Name = "cmbBranch"
        Me.cmbBranch.Size = New System.Drawing.Size(171, 21)
        Me.cmbBranch.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(248, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Transfer To:"
        '
        'cmbTansferby
        '
        Me.cmbTansferby.FormattingEnabled = True
        Me.cmbTansferby.Location = New System.Drawing.Point(73, 127)
        Me.cmbTansferby.Name = "cmbTansferby"
        Me.cmbTansferby.Size = New System.Drawing.Size(91, 21)
        Me.cmbTansferby.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(11, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Tranfer by:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(17, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Remarks:"
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(73, 65)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(413, 56)
        Me.txtRemarks.TabIndex = 8
        '
        'dtTrDate
        '
        Me.dtTrDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtTrDate.Location = New System.Drawing.Point(73, 39)
        Me.dtTrDate.Name = "dtTrDate"
        Me.dtTrDate.Size = New System.Drawing.Size(130, 20)
        Me.dtTrDate.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(36, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Date:"
        '
        'lblTransferby
        '
        Me.lblTransferby.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTransferby.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransferby.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblTransferby.Location = New System.Drawing.Point(170, 127)
        Me.lblTransferby.Name = "lblTransferby"
        Me.lblTransferby.Size = New System.Drawing.Size(316, 21)
        Me.lblTransferby.TabIndex = 12
        '
        'btnSave
        '
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSave.Location = New System.Drawing.Point(170, 157)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(154, 23)
        Me.btnSave.TabIndex = 15
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.CausesValidation = False
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnExit.Location = New System.Drawing.Point(332, 157)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(154, 23)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'chkActiveJob
        '
        Me.chkActiveJob.AutoSize = True
        Me.chkActiveJob.CausesValidation = False
        Me.chkActiveJob.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkActiveJob.Location = New System.Drawing.Point(206, 15)
        Me.chkActiveJob.Name = "chkActiveJob"
        Me.chkActiveJob.Size = New System.Drawing.Size(15, 14)
        Me.chkActiveJob.TabIndex = 18
        Me.chkActiveJob.UseVisualStyleBackColor = True
        '
        'txtJobCode
        '
        Me.txtJobCode.Enabled = False
        Me.txtJobCode.Location = New System.Drawing.Point(73, 12)
        Me.txtJobCode.Name = "txtJobCode"
        Me.txtJobCode.Size = New System.Drawing.Size(130, 20)
        Me.txtJobCode.TabIndex = 19
        '
        'chkActiveBranch
        '
        Me.chkActiveBranch.AutoSize = True
        Me.chkActiveBranch.CausesValidation = False
        Me.chkActiveBranch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.chkActiveBranch.Location = New System.Drawing.Point(488, 14)
        Me.chkActiveBranch.Name = "chkActiveBranch"
        Me.chkActiveBranch.Size = New System.Drawing.Size(15, 14)
        Me.chkActiveBranch.TabIndex = 21
        Me.chkActiveBranch.UseVisualStyleBackColor = True
        '
        'cmbBranchFrom
        '
        Me.cmbBranchFrom.CausesValidation = False
        Me.cmbBranchFrom.Enabled = False
        Me.cmbBranchFrom.FormattingEnabled = True
        Me.cmbBranchFrom.Location = New System.Drawing.Point(315, 11)
        Me.cmbBranchFrom.Name = "cmbBranchFrom"
        Me.cmbBranchFrom.Size = New System.Drawing.Size(171, 21)
        Me.cmbBranchFrom.TabIndex = 22
        '
        'dgvJobList
        '
        Me.dgvJobList.AllowUserToAddRows = False
        Me.dgvJobList.AllowUserToDeleteRows = False
        Me.dgvJobList.AllowUserToOrderColumns = True
        Me.dgvJobList.BackgroundColor = System.Drawing.Color.White
        Me.dgvJobList.CausesValidation = False
        Me.dgvJobList.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvJobList.Location = New System.Drawing.Point(73, 33)
        Me.dgvJobList.MultiSelect = False
        Me.dgvJobList.Name = "dgvJobList"
        Me.dgvJobList.ReadOnly = True
        Me.dgvJobList.RowHeadersVisible = False
        Me.dgvJobList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvJobList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvJobList.Size = New System.Drawing.Size(413, 88)
        Me.dgvJobList.TabIndex = 24
        Me.dgvJobList.Visible = False
        '
        'pnlBottomStatus
        '
        Me.pnlBottomStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBottomStatus.Controls.Add(Me.lblStatus)
        Me.pnlBottomStatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottomStatus.Location = New System.Drawing.Point(0, 196)
        Me.pnlBottomStatus.Name = "pnlBottomStatus"
        Me.pnlBottomStatus.Size = New System.Drawing.Size(510, 26)
        Me.pnlBottomStatus.TabIndex = 25
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.ForeColor = System.Drawing.Color.DimGray
        Me.lblStatus.Location = New System.Drawing.Point(13, 6)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(318, 13)
        Me.lblStatus.TabIndex = 0
        Me.lblStatus.Text = "Note: only 'Non Service Job and Pending' is applicable for transfer"
        '
        'frmTransfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(510, 222)
        Me.Controls.Add(Me.pnlBottomStatus)
        Me.Controls.Add(Me.dgvJobList)
        Me.Controls.Add(Me.cmbBranchFrom)
        Me.Controls.Add(Me.chkActiveBranch)
        Me.Controls.Add(Me.txtJobCode)
        Me.Controls.Add(Me.chkActiveJob)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblTransferby)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtTrDate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.cmbTansferby)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbBranch)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTransfer"
        Me.Text = "Job Transfer"
        CType(Me.dgvJobList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBottomStatus.ResumeLayout(False)
        Me.pnlBottomStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbBranch As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbTansferby As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents dtTrDate As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents lblTransferby As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents chkActiveJob As CheckBox
    Friend WithEvents txtJobCode As TextBox
    Friend WithEvents chkActiveBranch As CheckBox
    Friend WithEvents cmbBranchFrom As ComboBox
    Friend WithEvents dgvJobList As DataGridView
    Friend WithEvents pnlBottomStatus As Panel
    Friend WithEvents lblStatus As Label
End Class
