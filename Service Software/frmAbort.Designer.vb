<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbort
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
        Me.grpAbortDescription = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRefuseAmount = New System.Windows.Forms.TextBox()
        Me.chkEstimateRefuse = New System.Windows.Forms.CheckBox()
        Me.chkOpenOutside = New System.Windows.Forms.CheckBox()
        Me.chkSetLock = New System.Windows.Forms.CheckBox()
        Me.chkOthers = New System.Windows.Forms.CheckBox()
        Me.chkPCBCrack = New System.Windows.Forms.CheckBox()
        Me.chkConnectAnotherCharger = New System.Windows.Forms.CheckBox()
        Me.txtAbortOthers = New System.Windows.Forms.TextBox()
        Me.chkTechnicalProblem = New System.Windows.Forms.CheckBox()
        Me.chkUnavilableParts = New System.Windows.Forms.CheckBox()
        Me.chkSoftwareProblem = New System.Windows.Forms.CheckBox()
        Me.chkDroponthefloor = New System.Windows.Forms.CheckBox()
        Me.chkDropinthewater = New System.Windows.Forms.CheckBox()
        Me.chkPCBDamage = New System.Windows.Forms.CheckBox()
        Me.cmdAbortClose = New System.Windows.Forms.Button()
        Me.cmdAbortSave = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpAbort = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblAnortEmployeeName = New System.Windows.Forms.Label()
        Me.cmbAbortedby = New System.Windows.Forms.ComboBox()
        Me.cmdSaveAndMail = New System.Windows.Forms.Button()
        Me.grpAbortDescription.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpAbortDescription
        '
        Me.grpAbortDescription.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.grpAbortDescription.Controls.Add(Me.Label3)
        Me.grpAbortDescription.Controls.Add(Me.txtRefuseAmount)
        Me.grpAbortDescription.Controls.Add(Me.chkEstimateRefuse)
        Me.grpAbortDescription.Controls.Add(Me.chkOpenOutside)
        Me.grpAbortDescription.Controls.Add(Me.chkSetLock)
        Me.grpAbortDescription.Controls.Add(Me.chkOthers)
        Me.grpAbortDescription.Controls.Add(Me.chkPCBCrack)
        Me.grpAbortDescription.Controls.Add(Me.chkConnectAnotherCharger)
        Me.grpAbortDescription.Controls.Add(Me.txtAbortOthers)
        Me.grpAbortDescription.Controls.Add(Me.chkTechnicalProblem)
        Me.grpAbortDescription.Controls.Add(Me.chkUnavilableParts)
        Me.grpAbortDescription.Controls.Add(Me.chkSoftwareProblem)
        Me.grpAbortDescription.Controls.Add(Me.chkDroponthefloor)
        Me.grpAbortDescription.Controls.Add(Me.chkDropinthewater)
        Me.grpAbortDescription.Controls.Add(Me.chkPCBDamage)
        Me.grpAbortDescription.Location = New System.Drawing.Point(7, 9)
        Me.grpAbortDescription.Name = "grpAbortDescription"
        Me.grpAbortDescription.Size = New System.Drawing.Size(447, 238)
        Me.grpAbortDescription.TabIndex = 0
        Me.grpAbortDescription.TabStop = False
        Me.grpAbortDescription.Text = "Abort Description"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(237, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Refuse Amount:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtRefuseAmount
        '
        Me.txtRefuseAmount.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtRefuseAmount.Location = New System.Drawing.Point(324, 155)
        Me.txtRefuseAmount.Multiline = True
        Me.txtRefuseAmount.Name = "txtRefuseAmount"
        Me.txtRefuseAmount.Size = New System.Drawing.Size(103, 19)
        Me.txtRefuseAmount.TabIndex = 12
        '
        'chkEstimateRefuse
        '
        Me.chkEstimateRefuse.AutoSize = True
        Me.chkEstimateRefuse.Location = New System.Drawing.Point(324, 134)
        Me.chkEstimateRefuse.Name = "chkEstimateRefuse"
        Me.chkEstimateRefuse.Size = New System.Drawing.Size(103, 17)
        Me.chkEstimateRefuse.TabIndex = 11
        Me.chkEstimateRefuse.Text = "Estimate Refuse"
        Me.chkEstimateRefuse.UseVisualStyleBackColor = True
        '
        'chkOpenOutside
        '
        Me.chkOpenOutside.AutoSize = True
        Me.chkOpenOutside.Location = New System.Drawing.Point(324, 111)
        Me.chkOpenOutside.Name = "chkOpenOutside"
        Me.chkOpenOutside.Size = New System.Drawing.Size(91, 17)
        Me.chkOpenOutside.TabIndex = 10
        Me.chkOpenOutside.Text = "Open Outside"
        Me.chkOpenOutside.UseVisualStyleBackColor = True
        '
        'chkSetLock
        '
        Me.chkSetLock.AutoSize = True
        Me.chkSetLock.Location = New System.Drawing.Point(324, 88)
        Me.chkSetLock.Name = "chkSetLock"
        Me.chkSetLock.Size = New System.Drawing.Size(69, 17)
        Me.chkSetLock.TabIndex = 9
        Me.chkSetLock.Text = "Set Lock"
        Me.chkSetLock.UseVisualStyleBackColor = True
        '
        'chkOthers
        '
        Me.chkOthers.AutoSize = True
        Me.chkOthers.Location = New System.Drawing.Point(10, 134)
        Me.chkOthers.Name = "chkOthers"
        Me.chkOthers.Size = New System.Drawing.Size(57, 17)
        Me.chkOthers.TabIndex = 5
        Me.chkOthers.Text = "Others"
        Me.chkOthers.UseVisualStyleBackColor = True
        '
        'chkPCBCrack
        '
        Me.chkPCBCrack.AutoSize = True
        Me.chkPCBCrack.Location = New System.Drawing.Point(10, 111)
        Me.chkPCBCrack.Name = "chkPCBCrack"
        Me.chkPCBCrack.Size = New System.Drawing.Size(78, 17)
        Me.chkPCBCrack.TabIndex = 4
        Me.chkPCBCrack.Text = "PCB Crack"
        Me.chkPCBCrack.UseVisualStyleBackColor = True
        '
        'chkConnectAnotherCharger
        '
        Me.chkConnectAnotherCharger.AutoSize = True
        Me.chkConnectAnotherCharger.Location = New System.Drawing.Point(10, 88)
        Me.chkConnectAnotherCharger.Name = "chkConnectAnotherCharger"
        Me.chkConnectAnotherCharger.Size = New System.Drawing.Size(146, 17)
        Me.chkConnectAnotherCharger.TabIndex = 3
        Me.chkConnectAnotherCharger.Text = "Connect Another Charger"
        Me.chkConnectAnotherCharger.UseVisualStyleBackColor = True
        '
        'txtAbortOthers
        '
        Me.txtAbortOthers.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtAbortOthers.Location = New System.Drawing.Point(10, 179)
        Me.txtAbortOthers.Multiline = True
        Me.txtAbortOthers.Name = "txtAbortOthers"
        Me.txtAbortOthers.Size = New System.Drawing.Size(428, 53)
        Me.txtAbortOthers.TabIndex = 13
        '
        'chkTechnicalProblem
        '
        Me.chkTechnicalProblem.AutoSize = True
        Me.chkTechnicalProblem.Location = New System.Drawing.Point(324, 65)
        Me.chkTechnicalProblem.Name = "chkTechnicalProblem"
        Me.chkTechnicalProblem.Size = New System.Drawing.Size(114, 17)
        Me.chkTechnicalProblem.TabIndex = 8
        Me.chkTechnicalProblem.Text = "Technical Problem"
        Me.chkTechnicalProblem.UseVisualStyleBackColor = True
        '
        'chkUnavilableParts
        '
        Me.chkUnavilableParts.AutoSize = True
        Me.chkUnavilableParts.Location = New System.Drawing.Point(324, 42)
        Me.chkUnavilableParts.Name = "chkUnavilableParts"
        Me.chkUnavilableParts.Size = New System.Drawing.Size(103, 17)
        Me.chkUnavilableParts.TabIndex = 7
        Me.chkUnavilableParts.Text = "Unavilable Parts"
        Me.chkUnavilableParts.UseVisualStyleBackColor = True
        '
        'chkSoftwareProblem
        '
        Me.chkSoftwareProblem.AutoSize = True
        Me.chkSoftwareProblem.Location = New System.Drawing.Point(324, 19)
        Me.chkSoftwareProblem.Name = "chkSoftwareProblem"
        Me.chkSoftwareProblem.Size = New System.Drawing.Size(109, 17)
        Me.chkSoftwareProblem.TabIndex = 6
        Me.chkSoftwareProblem.Text = "Software Problem"
        Me.chkSoftwareProblem.UseVisualStyleBackColor = True
        '
        'chkDroponthefloor
        '
        Me.chkDroponthefloor.AutoSize = True
        Me.chkDroponthefloor.Location = New System.Drawing.Point(10, 65)
        Me.chkDroponthefloor.Name = "chkDroponthefloor"
        Me.chkDroponthefloor.Size = New System.Drawing.Size(105, 17)
        Me.chkDroponthefloor.TabIndex = 2
        Me.chkDroponthefloor.Text = "Drop on the floor"
        Me.chkDroponthefloor.UseVisualStyleBackColor = True
        '
        'chkDropinthewater
        '
        Me.chkDropinthewater.AutoSize = True
        Me.chkDropinthewater.Location = New System.Drawing.Point(10, 42)
        Me.chkDropinthewater.Name = "chkDropinthewater"
        Me.chkDropinthewater.Size = New System.Drawing.Size(107, 17)
        Me.chkDropinthewater.TabIndex = 1
        Me.chkDropinthewater.Text = "Drop in the water"
        Me.chkDropinthewater.UseVisualStyleBackColor = True
        '
        'chkPCBDamage
        '
        Me.chkPCBDamage.AutoSize = True
        Me.chkPCBDamage.Location = New System.Drawing.Point(10, 19)
        Me.chkPCBDamage.Name = "chkPCBDamage"
        Me.chkPCBDamage.Size = New System.Drawing.Size(90, 17)
        Me.chkPCBDamage.TabIndex = 0
        Me.chkPCBDamage.Text = "PCB Damage"
        Me.chkPCBDamage.UseVisualStyleBackColor = True
        '
        'cmdAbortClose
        '
        Me.cmdAbortClose.Location = New System.Drawing.Point(286, 301)
        Me.cmdAbortClose.Name = "cmdAbortClose"
        Me.cmdAbortClose.Size = New System.Drawing.Size(136, 23)
        Me.cmdAbortClose.TabIndex = 5
        Me.cmdAbortClose.Text = "&Close"
        Me.cmdAbortClose.UseVisualStyleBackColor = True
        '
        'cmdAbortSave
        '
        Me.cmdAbortSave.Location = New System.Drawing.Point(7, 301)
        Me.cmdAbortSave.Name = "cmdAbortSave"
        Me.cmdAbortSave.Size = New System.Drawing.Size(136, 23)
        Me.cmdAbortSave.TabIndex = 4
        Me.cmdAbortSave.Text = "&Save"
        Me.cmdAbortSave.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(338, 257)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Date:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpAbort
        '
        Me.dtpAbort.CustomFormat = "DD-MMM-YY"
        Me.dtpAbort.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAbort.Location = New System.Drawing.Point(375, 253)
        Me.dtpAbort.Name = "dtpAbort"
        Me.dtpAbort.Size = New System.Drawing.Size(76, 20)
        Me.dtpAbort.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(7, 257)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Aborted By:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAnortEmployeeName
        '
        Me.lblAnortEmployeeName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAnortEmployeeName.Location = New System.Drawing.Point(132, 253)
        Me.lblAnortEmployeeName.Name = "lblAnortEmployeeName"
        Me.lblAnortEmployeeName.Size = New System.Drawing.Size(199, 20)
        Me.lblAnortEmployeeName.TabIndex = 14
        Me.lblAnortEmployeeName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbAbortedby
        '
        Me.cmbAbortedby.FormattingEnabled = True
        Me.cmbAbortedby.Location = New System.Drawing.Point(73, 253)
        Me.cmbAbortedby.Name = "cmbAbortedby"
        Me.cmbAbortedby.Size = New System.Drawing.Size(54, 21)
        Me.cmbAbortedby.TabIndex = 1
        '
        'cmdSaveAndMail
        '
        Me.cmdSaveAndMail.Location = New System.Drawing.Point(144, 301)
        Me.cmdSaveAndMail.Name = "cmdSaveAndMail"
        Me.cmdSaveAndMail.Size = New System.Drawing.Size(136, 23)
        Me.cmdSaveAndMail.TabIndex = 15
        Me.cmdSaveAndMail.Text = "&Save and Mail"
        Me.cmdSaveAndMail.UseVisualStyleBackColor = True
        '
        'frmAbort
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(457, 323)
        Me.Controls.Add(Me.cmdSaveAndMail)
        Me.Controls.Add(Me.cmbAbortedby)
        Me.Controls.Add(Me.lblAnortEmployeeName)
        Me.Controls.Add(Me.grpAbortDescription)
        Me.Controls.Add(Me.cmdAbortClose)
        Me.Controls.Add(Me.cmdAbortSave)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpAbort)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAbort"
        Me.Text = "Abort Form"
        Me.grpAbortDescription.ResumeLayout(False)
        Me.grpAbortDescription.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpAbortDescription As GroupBox
    Friend WithEvents txtAbortOthers As TextBox
    Friend WithEvents chkTechnicalProblem As CheckBox
    Friend WithEvents chkUnavilableParts As CheckBox
    Friend WithEvents chkSoftwareProblem As CheckBox
    Friend WithEvents chkDroponthefloor As CheckBox
    Friend WithEvents chkDropinthewater As CheckBox
    Friend WithEvents chkPCBDamage As CheckBox
    Friend WithEvents cmdAbortClose As Button
    Friend WithEvents cmdAbortSave As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpAbort As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents chkOpenOutside As CheckBox
    Friend WithEvents chkSetLock As CheckBox
    Friend WithEvents chkOthers As CheckBox
    Friend WithEvents chkPCBCrack As CheckBox
    Friend WithEvents chkConnectAnotherCharger As CheckBox
    Friend WithEvents lblAnortEmployeeName As Label
    Friend WithEvents chkEstimateRefuse As CheckBox
    Friend WithEvents cmbAbortedby As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtRefuseAmount As TextBox
    Friend WithEvents cmdSaveAndMail As Button
End Class
