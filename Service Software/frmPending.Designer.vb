<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPending
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
        Me.grpPendingDescription = New System.Windows.Forms.GroupBox()
        Me.txtPendingOthers = New System.Windows.Forms.TextBox()
        Me.chkUnderEstimate = New System.Windows.Forms.CheckBox()
        Me.chkTechnicalHelp = New System.Windows.Forms.CheckBox()
        Me.chkTechnicalProblem = New System.Windows.Forms.CheckBox()
        Me.chkOthers = New System.Windows.Forms.CheckBox()
        Me.chkWatingForParts = New System.Windows.Forms.CheckBox()
        Me.chkWaitingforServiceManual = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpPending = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdPendingSave = New System.Windows.Forms.Button()
        Me.cmdPendingClose = New System.Windows.Forms.Button()
        Me.lblPendingEmployeeName = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbPendingCode = New System.Windows.Forms.ComboBox()
        Me.grpPendingDescription.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpPendingDescription
        '
        Me.grpPendingDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpPendingDescription.Controls.Add(Me.txtPendingOthers)
        Me.grpPendingDescription.Controls.Add(Me.chkUnderEstimate)
        Me.grpPendingDescription.Controls.Add(Me.chkTechnicalHelp)
        Me.grpPendingDescription.Controls.Add(Me.chkTechnicalProblem)
        Me.grpPendingDescription.Controls.Add(Me.chkOthers)
        Me.grpPendingDescription.Controls.Add(Me.chkWatingForParts)
        Me.grpPendingDescription.Controls.Add(Me.chkWaitingforServiceManual)
        Me.grpPendingDescription.Location = New System.Drawing.Point(5, 12)
        Me.grpPendingDescription.Name = "grpPendingDescription"
        Me.grpPendingDescription.Size = New System.Drawing.Size(439, 164)
        Me.grpPendingDescription.TabIndex = 0
        Me.grpPendingDescription.TabStop = False
        Me.grpPendingDescription.Text = "Pending Description"
        '
        'txtPendingOthers
        '
        Me.txtPendingOthers.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtPendingOthers.Location = New System.Drawing.Point(5, 88)
        Me.txtPendingOthers.Multiline = True
        Me.txtPendingOthers.Name = "txtPendingOthers"
        Me.txtPendingOthers.Size = New System.Drawing.Size(430, 71)
        Me.txtPendingOthers.TabIndex = 6
        '
        'chkUnderEstimate
        '
        Me.chkUnderEstimate.AutoSize = True
        Me.chkUnderEstimate.Location = New System.Drawing.Point(319, 65)
        Me.chkUnderEstimate.Name = "chkUnderEstimate"
        Me.chkUnderEstimate.Size = New System.Drawing.Size(98, 17)
        Me.chkUnderEstimate.TabIndex = 5
        Me.chkUnderEstimate.Text = "Under Estimate"
        Me.chkUnderEstimate.UseVisualStyleBackColor = True
        '
        'chkTechnicalHelp
        '
        Me.chkTechnicalHelp.AutoSize = True
        Me.chkTechnicalHelp.Location = New System.Drawing.Point(319, 42)
        Me.chkTechnicalHelp.Name = "chkTechnicalHelp"
        Me.chkTechnicalHelp.Size = New System.Drawing.Size(98, 17)
        Me.chkTechnicalHelp.TabIndex = 4
        Me.chkTechnicalHelp.Text = "Technical Help"
        Me.chkTechnicalHelp.UseVisualStyleBackColor = True
        '
        'chkTechnicalProblem
        '
        Me.chkTechnicalProblem.AutoSize = True
        Me.chkTechnicalProblem.Location = New System.Drawing.Point(319, 19)
        Me.chkTechnicalProblem.Name = "chkTechnicalProblem"
        Me.chkTechnicalProblem.Size = New System.Drawing.Size(114, 17)
        Me.chkTechnicalProblem.TabIndex = 3
        Me.chkTechnicalProblem.Text = "Technical Problem"
        Me.chkTechnicalProblem.UseVisualStyleBackColor = True
        '
        'chkOthers
        '
        Me.chkOthers.AutoSize = True
        Me.chkOthers.Location = New System.Drawing.Point(6, 65)
        Me.chkOthers.Name = "chkOthers"
        Me.chkOthers.Size = New System.Drawing.Size(57, 17)
        Me.chkOthers.TabIndex = 2
        Me.chkOthers.Text = "Others"
        Me.chkOthers.UseVisualStyleBackColor = True
        '
        'chkWatingForParts
        '
        Me.chkWatingForParts.AutoSize = True
        Me.chkWatingForParts.Location = New System.Drawing.Point(6, 42)
        Me.chkWatingForParts.Name = "chkWatingForParts"
        Me.chkWatingForParts.Size = New System.Drawing.Size(105, 17)
        Me.chkWatingForParts.TabIndex = 1
        Me.chkWatingForParts.Text = "Wating For Parts"
        Me.chkWatingForParts.UseVisualStyleBackColor = True
        '
        'chkWaitingforServiceManual
        '
        Me.chkWaitingforServiceManual.AutoSize = True
        Me.chkWaitingforServiceManual.Location = New System.Drawing.Point(6, 19)
        Me.chkWaitingforServiceManual.Name = "chkWaitingforServiceManual"
        Me.chkWaitingforServiceManual.Size = New System.Drawing.Size(154, 17)
        Me.chkWaitingforServiceManual.TabIndex = 0
        Me.chkWaitingforServiceManual.Text = "Waiting for Service Manual"
        Me.chkWaitingforServiceManual.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(5, 187)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pending By:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpPending
        '
        Me.dtpPending.CustomFormat = "DD-MMM-YY"
        Me.dtpPending.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPending.Location = New System.Drawing.Point(368, 182)
        Me.dtpPending.Name = "dtpPending"
        Me.dtpPending.Size = New System.Drawing.Size(76, 20)
        Me.dtpPending.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(331, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Date:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdPendingSave
        '
        Me.cmdPendingSave.Location = New System.Drawing.Point(5, 232)
        Me.cmdPendingSave.Name = "cmdPendingSave"
        Me.cmdPendingSave.Size = New System.Drawing.Size(79, 27)
        Me.cmdPendingSave.TabIndex = 4
        Me.cmdPendingSave.Text = "&Save"
        Me.cmdPendingSave.UseVisualStyleBackColor = True
        '
        'cmdPendingClose
        '
        Me.cmdPendingClose.Location = New System.Drawing.Point(86, 232)
        Me.cmdPendingClose.Name = "cmdPendingClose"
        Me.cmdPendingClose.Size = New System.Drawing.Size(79, 27)
        Me.cmdPendingClose.TabIndex = 5
        Me.cmdPendingClose.Text = "&Close"
        Me.cmdPendingClose.UseVisualStyleBackColor = True
        '
        'lblPendingEmployeeName
        '
        Me.lblPendingEmployeeName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPendingEmployeeName.Location = New System.Drawing.Point(127, 182)
        Me.lblPendingEmployeeName.Name = "lblPendingEmployeeName"
        Me.lblPendingEmployeeName.Size = New System.Drawing.Size(203, 20)
        Me.lblPendingEmployeeName.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Location = New System.Drawing.Point(8, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Pending By:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbPendingCode
        '
        Me.cmbPendingCode.FormattingEnabled = True
        Me.cmbPendingCode.Location = New System.Drawing.Point(71, 181)
        Me.cmbPendingCode.Name = "cmbPendingCode"
        Me.cmbPendingCode.Size = New System.Drawing.Size(54, 21)
        Me.cmbPendingCode.TabIndex = 1
        '
        'frmPending
        '
        Me.AcceptButton = Me.cmdPendingSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(449, 260)
        Me.Controls.Add(Me.cmbPendingCode)
        Me.Controls.Add(Me.lblPendingEmployeeName)
        Me.Controls.Add(Me.cmdPendingClose)
        Me.Controls.Add(Me.cmdPendingSave)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpPending)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grpPendingDescription)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPending"
        Me.Text = "Pending Form"
        Me.grpPendingDescription.ResumeLayout(False)
        Me.grpPendingDescription.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpPendingDescription As GroupBox
    Friend WithEvents txtPendingOthers As TextBox
    Friend WithEvents chkUnderEstimate As CheckBox
    Friend WithEvents chkTechnicalHelp As CheckBox
    Friend WithEvents chkTechnicalProblem As CheckBox
    Friend WithEvents chkOthers As CheckBox
    Friend WithEvents chkWatingForParts As CheckBox
    Friend WithEvents chkWaitingforServiceManual As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpPending As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdPendingSave As Button
    Friend WithEvents cmdPendingClose As Button
    Friend WithEvents lblPendingEmployeeName As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbPendingCode As ComboBox
End Class
