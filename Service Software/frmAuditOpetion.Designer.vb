<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAuditOpetion
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
        Me.chkService = New System.Windows.Forms.CheckBox()
        Me.chkNR = New System.Windows.Forms.CheckBox()
        Me.chkEstimateRefuse = New System.Windows.Forms.CheckBox()
        Me.chkPending = New System.Windows.Forms.CheckBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.chkAfterIssue = New System.Windows.Forms.CheckBox()
        Me.chkWaitingForDelivery = New System.Windows.Forms.CheckBox()
        Me.chkNotIssued = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'chkService
        '
        Me.chkService.AutoSize = True
        Me.chkService.Location = New System.Drawing.Point(35, 52)
        Me.chkService.Name = "chkService"
        Me.chkService.Size = New System.Drawing.Size(62, 17)
        Me.chkService.TabIndex = 0
        Me.chkService.Text = "Service"
        Me.chkService.UseVisualStyleBackColor = True
        '
        'chkNR
        '
        Me.chkNR.AutoSize = True
        Me.chkNR.Location = New System.Drawing.Point(224, 52)
        Me.chkNR.Name = "chkNR"
        Me.chkNR.Size = New System.Drawing.Size(42, 17)
        Me.chkNR.TabIndex = 1
        Me.chkNR.Text = "NR"
        Me.chkNR.UseVisualStyleBackColor = True
        '
        'chkEstimateRefuse
        '
        Me.chkEstimateRefuse.AutoSize = True
        Me.chkEstimateRefuse.Location = New System.Drawing.Point(109, 52)
        Me.chkEstimateRefuse.Name = "chkEstimateRefuse"
        Me.chkEstimateRefuse.Size = New System.Drawing.Size(103, 17)
        Me.chkEstimateRefuse.TabIndex = 2
        Me.chkEstimateRefuse.Text = "Estimate Refuse"
        Me.chkEstimateRefuse.UseVisualStyleBackColor = True
        '
        'chkPending
        '
        Me.chkPending.AutoSize = True
        Me.chkPending.Location = New System.Drawing.Point(287, 52)
        Me.chkPending.Name = "chkPending"
        Me.chkPending.Size = New System.Drawing.Size(65, 17)
        Me.chkPending.TabIndex = 3
        Me.chkPending.Text = "Pending"
        Me.chkPending.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.DarkRed
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnOK.Location = New System.Drawing.Point(11, 152)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(179, 23)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "&Ok"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.DarkRed
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnClose.Location = New System.Drawing.Point(191, 152)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(179, 23)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'lblMail
        '
        Me.lblMail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMail.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMail.Location = New System.Drawing.Point(13, 13)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(363, 21)
        Me.lblMail.TabIndex = 6
        '
        'chkAfterIssue
        '
        Me.chkAfterIssue.AutoSize = True
        Me.chkAfterIssue.Enabled = False
        Me.chkAfterIssue.Location = New System.Drawing.Point(136, 113)
        Me.chkAfterIssue.Name = "chkAfterIssue"
        Me.chkAfterIssue.Size = New System.Drawing.Size(69, 17)
        Me.chkAfterIssue.TabIndex = 9
        Me.chkAfterIssue.Text = "Assigned"
        Me.chkAfterIssue.UseVisualStyleBackColor = True
        '
        'chkWaitingForDelivery
        '
        Me.chkWaitingForDelivery.AutoSize = True
        Me.chkWaitingForDelivery.Enabled = False
        Me.chkWaitingForDelivery.Location = New System.Drawing.Point(218, 113)
        Me.chkWaitingForDelivery.Name = "chkWaitingForDelivery"
        Me.chkWaitingForDelivery.Size = New System.Drawing.Size(118, 17)
        Me.chkWaitingForDelivery.TabIndex = 8
        Me.chkWaitingForDelivery.Text = "Waiting for Delivery"
        Me.chkWaitingForDelivery.UseVisualStyleBackColor = True
        '
        'chkNotIssued
        '
        Me.chkNotIssued.AutoSize = True
        Me.chkNotIssued.Enabled = False
        Me.chkNotIssued.Location = New System.Drawing.Point(35, 113)
        Me.chkNotIssued.Name = "chkNotIssued"
        Me.chkNotIssued.Size = New System.Drawing.Size(77, 17)
        Me.chkNotIssued.TabIndex = 7
        Me.chkNotIssued.Text = "Not Issued"
        Me.chkNotIssued.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 17)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Job Status"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(400, 1)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(-9, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(400, 1)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Label3"
        '
        'frmAuditOpetion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(382, 181)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkAfterIssue)
        Me.Controls.Add(Me.chkWaitingForDelivery)
        Me.Controls.Add(Me.chkNotIssued)
        Me.Controls.Add(Me.lblMail)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.chkPending)
        Me.Controls.Add(Me.chkEstimateRefuse)
        Me.Controls.Add(Me.chkNR)
        Me.Controls.Add(Me.chkService)
        Me.Name = "frmAuditOpetion"
        Me.Text = "Audit Opetion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkService As CheckBox
    Friend WithEvents chkNR As CheckBox
    Friend WithEvents chkEstimateRefuse As CheckBox
    Friend WithEvents chkPending As CheckBox
    Friend WithEvents btnOK As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lblMail As Label
    Friend WithEvents chkAfterIssue As CheckBox
    Friend WithEvents chkWaitingForDelivery As CheckBox
    Friend WithEvents chkNotIssued As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
