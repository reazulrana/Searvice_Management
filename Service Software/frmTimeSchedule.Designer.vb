<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimeSchedule
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTimeSchedule))
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.picClose = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.grpAction = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTimeFormate = New System.Windows.Forms.Label()
        Me.dtWaitingForDelivery = New System.Windows.Forms.TextBox()
        Me.dtAfterIssue = New System.Windows.Forms.TextBox()
        Me.dtNotIssued = New System.Windows.Forms.TextBox()
        Me.lblLine = New System.Windows.Forms.Label()
        Me.cmbClose = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtWaitingForDelivery = New System.Windows.Forms.TextBox()
        Me.txtAfterIssue = New System.Windows.Forms.TextBox()
        Me.txtNotIssued = New System.Windows.Forms.TextBox()
        Me.chkWaitingForDelivery = New System.Windows.Forms.CheckBox()
        Me.chkAfterIssue = New System.Windows.Forms.CheckBox()
        Me.chkNotIssued = New System.Windows.Forms.CheckBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlHeader.SuspendLayout()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFooter.SuspendLayout()
        Me.grpAction.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdSave.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.ForeColor = System.Drawing.Color.Olive
        Me.cmdSave.Location = New System.Drawing.Point(15, 149)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(188, 26)
        Me.cmdSave.TabIndex = 0
        Me.cmdSave.Text = "&Set"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.Khaki
        Me.pnlHeader.Controls.Add(Me.picClose)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(468, 34)
        Me.pnlHeader.TabIndex = 1
        '
        'picClose
        '
        Me.picClose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.picClose.Image = CType(resources.GetObject("picClose.Image"), System.Drawing.Image)
        Me.picClose.Location = New System.Drawing.Point(432, 3)
        Me.picClose.Name = "picClose"
        Me.picClose.Size = New System.Drawing.Size(27, 24)
        Me.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picClose.TabIndex = 4
        Me.picClose.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Olive
        Me.lblTitle.Location = New System.Drawing.Point(17, 8)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(114, 20)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Task Schedule"
        '
        'pnlFooter
        '
        Me.pnlFooter.BackColor = System.Drawing.Color.Khaki
        Me.pnlFooter.Controls.Add(Me.lblStatus)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 259)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(468, 25)
        Me.pnlFooter.TabIndex = 2
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.Olive
        Me.lblStatus.Location = New System.Drawing.Point(9, 5)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 13)
        Me.lblStatus.TabIndex = 6
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grpAction
        '
        Me.grpAction.Controls.Add(Me.Label5)
        Me.grpAction.Controls.Add(Me.Label4)
        Me.grpAction.Controls.Add(Me.lblTimeFormate)
        Me.grpAction.Controls.Add(Me.dtWaitingForDelivery)
        Me.grpAction.Controls.Add(Me.dtAfterIssue)
        Me.grpAction.Controls.Add(Me.dtNotIssued)
        Me.grpAction.Controls.Add(Me.lblLine)
        Me.grpAction.Controls.Add(Me.cmbClose)
        Me.grpAction.Controls.Add(Me.cmdSave)
        Me.grpAction.Controls.Add(Me.Label3)
        Me.grpAction.Controls.Add(Me.Label2)
        Me.grpAction.Controls.Add(Me.Label1)
        Me.grpAction.Controls.Add(Me.txtWaitingForDelivery)
        Me.grpAction.Controls.Add(Me.txtAfterIssue)
        Me.grpAction.Controls.Add(Me.txtNotIssued)
        Me.grpAction.Controls.Add(Me.chkWaitingForDelivery)
        Me.grpAction.Controls.Add(Me.chkAfterIssue)
        Me.grpAction.Controls.Add(Me.chkNotIssued)
        Me.grpAction.Location = New System.Drawing.Point(12, 45)
        Me.grpAction.Name = "grpAction"
        Me.grpAction.Size = New System.Drawing.Size(447, 193)
        Me.grpAction.TabIndex = 3
        Me.grpAction.TabStop = False
        Me.grpAction.Text = "Action"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Olive
        Me.Label5.Location = New System.Drawing.Point(352, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "h:mm:ss AM/PM"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Olive
        Me.Label4.Location = New System.Drawing.Point(352, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "h:mm:ss AM/PM"
        '
        'lblTimeFormate
        '
        Me.lblTimeFormate.AutoSize = True
        Me.lblTimeFormate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeFormate.ForeColor = System.Drawing.Color.Olive
        Me.lblTimeFormate.Location = New System.Drawing.Point(352, 57)
        Me.lblTimeFormate.Name = "lblTimeFormate"
        Me.lblTimeFormate.Size = New System.Drawing.Size(85, 13)
        Me.lblTimeFormate.TabIndex = 25
        Me.lblTimeFormate.Text = "h:mm:ss AM/PM"
        '
        'dtWaitingForDelivery
        '
        Me.dtWaitingForDelivery.Enabled = False
        Me.dtWaitingForDelivery.Location = New System.Drawing.Point(214, 109)
        Me.dtWaitingForDelivery.Name = "dtWaitingForDelivery"
        Me.dtWaitingForDelivery.Size = New System.Drawing.Size(132, 20)
        Me.dtWaitingForDelivery.TabIndex = 24
        Me.dtWaitingForDelivery.Text = "12:00:00 AM"
        Me.dtWaitingForDelivery.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtAfterIssue
        '
        Me.dtAfterIssue.Enabled = False
        Me.dtAfterIssue.Location = New System.Drawing.Point(214, 83)
        Me.dtAfterIssue.Name = "dtAfterIssue"
        Me.dtAfterIssue.Size = New System.Drawing.Size(132, 20)
        Me.dtAfterIssue.TabIndex = 23
        Me.dtAfterIssue.Text = "12:00:00 AM"
        Me.dtAfterIssue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtNotIssued
        '
        Me.dtNotIssued.Enabled = False
        Me.dtNotIssued.Location = New System.Drawing.Point(214, 55)
        Me.dtNotIssued.Name = "dtNotIssued"
        Me.dtNotIssued.Size = New System.Drawing.Size(132, 20)
        Me.dtNotIssued.TabIndex = 22
        Me.dtNotIssued.Text = "12:00:00 AM"
        Me.dtNotIssued.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblLine
        '
        Me.lblLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblLine.Location = New System.Drawing.Point(0, 140)
        Me.lblLine.Name = "lblLine"
        Me.lblLine.Size = New System.Drawing.Size(451, 1)
        Me.lblLine.TabIndex = 21
        '
        'cmbClose
        '
        Me.cmbClose.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmbClose.CausesValidation = False
        Me.cmbClose.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod
        Me.cmbClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbClose.ForeColor = System.Drawing.Color.Olive
        Me.cmbClose.Location = New System.Drawing.Point(243, 149)
        Me.cmbClose.Name = "cmbClose"
        Me.cmbClose.Size = New System.Drawing.Size(188, 26)
        Me.cmbClose.TabIndex = 20
        Me.cmbClose.Text = "&Close"
        Me.cmbClose.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Olive
        Me.Label3.Location = New System.Drawing.Point(215, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Set Execution Time"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Olive
        Me.Label2.Location = New System.Drawing.Point(149, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Period"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Olive
        Me.Label1.Location = New System.Drawing.Point(15, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Action Name"
        '
        'txtWaitingForDelivery
        '
        Me.txtWaitingForDelivery.Enabled = False
        Me.txtWaitingForDelivery.Location = New System.Drawing.Point(151, 109)
        Me.txtWaitingForDelivery.Name = "txtWaitingForDelivery"
        Me.txtWaitingForDelivery.Size = New System.Drawing.Size(45, 20)
        Me.txtWaitingForDelivery.TabIndex = 8
        Me.txtWaitingForDelivery.Text = "0"
        Me.txtWaitingForDelivery.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAfterIssue
        '
        Me.txtAfterIssue.Enabled = False
        Me.txtAfterIssue.Location = New System.Drawing.Point(151, 83)
        Me.txtAfterIssue.Name = "txtAfterIssue"
        Me.txtAfterIssue.Size = New System.Drawing.Size(45, 20)
        Me.txtAfterIssue.TabIndex = 7
        Me.txtAfterIssue.Text = "0"
        Me.txtAfterIssue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNotIssued
        '
        Me.txtNotIssued.Enabled = False
        Me.txtNotIssued.Location = New System.Drawing.Point(151, 55)
        Me.txtNotIssued.Name = "txtNotIssued"
        Me.txtNotIssued.Size = New System.Drawing.Size(45, 20)
        Me.txtNotIssued.TabIndex = 6
        Me.txtNotIssued.Text = "0"
        Me.txtNotIssued.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chkWaitingForDelivery
        '
        Me.chkWaitingForDelivery.AutoSize = True
        Me.chkWaitingForDelivery.Location = New System.Drawing.Point(15, 111)
        Me.chkWaitingForDelivery.Name = "chkWaitingForDelivery"
        Me.chkWaitingForDelivery.Size = New System.Drawing.Size(118, 17)
        Me.chkWaitingForDelivery.TabIndex = 4
        Me.chkWaitingForDelivery.Text = "Waiting for Delivery"
        Me.chkWaitingForDelivery.UseVisualStyleBackColor = True
        '
        'chkAfterIssue
        '
        Me.chkAfterIssue.AutoSize = True
        Me.chkAfterIssue.Location = New System.Drawing.Point(15, 85)
        Me.chkAfterIssue.Name = "chkAfterIssue"
        Me.chkAfterIssue.Size = New System.Drawing.Size(69, 17)
        Me.chkAfterIssue.TabIndex = 2
        Me.chkAfterIssue.Text = "Assigned"
        Me.chkAfterIssue.UseVisualStyleBackColor = True
        '
        'chkNotIssued
        '
        Me.chkNotIssued.AutoSize = True
        Me.chkNotIssued.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkNotIssued.Location = New System.Drawing.Point(15, 57)
        Me.chkNotIssued.Name = "chkNotIssued"
        Me.chkNotIssued.Size = New System.Drawing.Size(77, 17)
        Me.chkNotIssued.TabIndex = 0
        Me.chkNotIssued.Text = "Not Issued"
        Me.chkNotIssued.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'frmTimeSchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(468, 284)
        Me.Controls.Add(Me.grpAction)
        Me.Controls.Add(Me.pnlFooter)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTimeSchedule"
        Me.Text = "Notification"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFooter.ResumeLayout(False)
        Me.pnlFooter.PerformLayout()
        Me.grpAction.ResumeLayout(False)
        Me.grpAction.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdSave As Button
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents picClose As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlFooter As Panel
    Friend WithEvents grpAction As GroupBox
    Friend WithEvents chkNotIssued As CheckBox
    Friend WithEvents chkWaitingForDelivery As CheckBox
    Friend WithEvents chkAfterIssue As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtWaitingForDelivery As TextBox
    Friend WithEvents txtAfterIssue As TextBox
    Friend WithEvents txtNotIssued As TextBox
    Friend WithEvents cmbClose As Button
    Friend WithEvents lblLine As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents dtWaitingForDelivery As TextBox
    Friend WithEvents dtAfterIssue As TextBox
    Friend WithEvents dtNotIssued As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTimeFormate As Label
    Friend WithEvents Timer1 As Timer
End Class
