<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReplaceEntry
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
        Me.grpJobInformation = New System.Windows.Forms.GroupBox()
        Me.txtReplaceNrDate = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtReplaceJobCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpReplaceSetDetails = New System.Windows.Forms.GroupBox()
        Me.cmbReplaceModel = New System.Windows.Forms.ComboBox()
        Me.cmbReplaceBrand = New System.Windows.Forms.ComboBox()
        Me.txtReplaceOthers = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtReplaceESNB = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtReplaceESN = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtReplaceSLno = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grpReplaceInformation = New System.Windows.Forms.GroupBox()
        Me.cmbReplaceby = New System.Windows.Forms.ComboBox()
        Me.lblReplaceByName = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpReplaceDate = New System.Windows.Forms.DateTimePicker()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.grpJobInformation.SuspendLayout()
        Me.grpReplaceSetDetails.SuspendLayout()
        Me.grpReplaceInformation.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpJobInformation
        '
        Me.grpJobInformation.Controls.Add(Me.txtReplaceNrDate)
        Me.grpJobInformation.Controls.Add(Me.Label2)
        Me.grpJobInformation.Controls.Add(Me.txtReplaceJobCode)
        Me.grpJobInformation.Controls.Add(Me.Label1)
        Me.grpJobInformation.Location = New System.Drawing.Point(9, 5)
        Me.grpJobInformation.Name = "grpJobInformation"
        Me.grpJobInformation.Size = New System.Drawing.Size(463, 43)
        Me.grpJobInformation.TabIndex = 0
        Me.grpJobInformation.TabStop = False
        Me.grpJobInformation.Text = "Job Information"
        '
        'txtReplaceNrDate
        '
        Me.txtReplaceNrDate.Enabled = False
        Me.txtReplaceNrDate.Location = New System.Drawing.Point(356, 16)
        Me.txtReplaceNrDate.Name = "txtReplaceNrDate"
        Me.txtReplaceNrDate.Size = New System.Drawing.Size(100, 20)
        Me.txtReplaceNrDate.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(287, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NR Date"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtReplaceJobCode
        '
        Me.txtReplaceJobCode.Enabled = False
        Me.txtReplaceJobCode.Location = New System.Drawing.Point(71, 16)
        Me.txtReplaceJobCode.Name = "txtReplaceJobCode"
        Me.txtReplaceJobCode.Size = New System.Drawing.Size(100, 20)
        Me.txtReplaceJobCode.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Job No."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grpReplaceSetDetails
        '
        Me.grpReplaceSetDetails.Controls.Add(Me.cmbReplaceModel)
        Me.grpReplaceSetDetails.Controls.Add(Me.cmbReplaceBrand)
        Me.grpReplaceSetDetails.Controls.Add(Me.txtReplaceOthers)
        Me.grpReplaceSetDetails.Controls.Add(Me.Label8)
        Me.grpReplaceSetDetails.Controls.Add(Me.txtReplaceESNB)
        Me.grpReplaceSetDetails.Controls.Add(Me.Label7)
        Me.grpReplaceSetDetails.Controls.Add(Me.txtReplaceESN)
        Me.grpReplaceSetDetails.Controls.Add(Me.Label6)
        Me.grpReplaceSetDetails.Controls.Add(Me.txtReplaceSLno)
        Me.grpReplaceSetDetails.Controls.Add(Me.Label5)
        Me.grpReplaceSetDetails.Controls.Add(Me.Label4)
        Me.grpReplaceSetDetails.Controls.Add(Me.Label3)
        Me.grpReplaceSetDetails.Location = New System.Drawing.Point(9, 55)
        Me.grpReplaceSetDetails.Name = "grpReplaceSetDetails"
        Me.grpReplaceSetDetails.Size = New System.Drawing.Size(463, 101)
        Me.grpReplaceSetDetails.TabIndex = 1
        Me.grpReplaceSetDetails.TabStop = False
        Me.grpReplaceSetDetails.Text = "Replace Set Details"
        '
        'cmbReplaceModel
        '
        Me.cmbReplaceModel.FormattingEnabled = True
        Me.cmbReplaceModel.Location = New System.Drawing.Point(61, 46)
        Me.cmbReplaceModel.Name = "cmbReplaceModel"
        Me.cmbReplaceModel.Size = New System.Drawing.Size(121, 21)
        Me.cmbReplaceModel.TabIndex = 15
        '
        'cmbReplaceBrand
        '
        Me.cmbReplaceBrand.FormattingEnabled = True
        Me.cmbReplaceBrand.Location = New System.Drawing.Point(61, 19)
        Me.cmbReplaceBrand.Name = "cmbReplaceBrand"
        Me.cmbReplaceBrand.Size = New System.Drawing.Size(121, 21)
        Me.cmbReplaceBrand.TabIndex = 14
        '
        'txtReplaceOthers
        '
        Me.txtReplaceOthers.Location = New System.Drawing.Point(335, 73)
        Me.txtReplaceOthers.Name = "txtReplaceOthers"
        Me.txtReplaceOthers.Size = New System.Drawing.Size(121, 20)
        Me.txtReplaceOthers.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(223, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Others"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtReplaceESNB
        '
        Me.txtReplaceESNB.Location = New System.Drawing.Point(335, 47)
        Me.txtReplaceESNB.Name = "txtReplaceESNB"
        Me.txtReplaceESNB.Size = New System.Drawing.Size(121, 20)
        Me.txtReplaceESNB.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(223, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "ESN No(Body)"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtReplaceESN
        '
        Me.txtReplaceESN.Location = New System.Drawing.Point(335, 21)
        Me.txtReplaceESN.Name = "txtReplaceESN"
        Me.txtReplaceESN.Size = New System.Drawing.Size(121, 20)
        Me.txtReplaceESN.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(223, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "ESN No(PCB)"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtReplaceSLno
        '
        Me.txtReplaceSLno.Location = New System.Drawing.Point(61, 71)
        Me.txtReplaceSLno.Name = "txtReplaceSLno"
        Me.txtReplaceSLno.Size = New System.Drawing.Size(121, 20)
        Me.txtReplaceSLno.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(10, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Serial"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(10, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Model"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(10, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Brand"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grpReplaceInformation
        '
        Me.grpReplaceInformation.Controls.Add(Me.cmbReplaceby)
        Me.grpReplaceInformation.Controls.Add(Me.lblReplaceByName)
        Me.grpReplaceInformation.Controls.Add(Me.Label10)
        Me.grpReplaceInformation.Controls.Add(Me.Label9)
        Me.grpReplaceInformation.Controls.Add(Me.dtpReplaceDate)
        Me.grpReplaceInformation.Location = New System.Drawing.Point(9, 162)
        Me.grpReplaceInformation.Name = "grpReplaceInformation"
        Me.grpReplaceInformation.Size = New System.Drawing.Size(463, 46)
        Me.grpReplaceInformation.TabIndex = 2
        Me.grpReplaceInformation.TabStop = False
        Me.grpReplaceInformation.Text = "Replace Information"
        '
        'cmbReplaceby
        '
        Me.cmbReplaceby.FormattingEnabled = True
        Me.cmbReplaceby.Location = New System.Drawing.Point(75, 18)
        Me.cmbReplaceby.Name = "cmbReplaceby"
        Me.cmbReplaceby.Size = New System.Drawing.Size(49, 21)
        Me.cmbReplaceby.TabIndex = 15
        '
        'lblReplaceByName
        '
        Me.lblReplaceByName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblReplaceByName.Location = New System.Drawing.Point(128, 18)
        Me.lblReplaceByName.Name = "lblReplaceByName"
        Me.lblReplaceByName.Size = New System.Drawing.Size(170, 20)
        Me.lblReplaceByName.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(13, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 16)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Replace by"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(301, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 16)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Replace Date"
        '
        'dtpReplaceDate
        '
        Me.dtpReplaceDate.CustomFormat = "DD-MMM-YY"
        Me.dtpReplaceDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpReplaceDate.Location = New System.Drawing.Point(377, 18)
        Me.dtpReplaceDate.Name = "dtpReplaceDate"
        Me.dtpReplaceDate.Size = New System.Drawing.Size(79, 20)
        Me.dtpReplaceDate.TabIndex = 0
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(8, 214)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 3
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(119, 213)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 4
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'frmReplaceEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(481, 245)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.grpReplaceInformation)
        Me.Controls.Add(Me.grpReplaceSetDetails)
        Me.Controls.Add(Me.grpJobInformation)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReplaceEntry"
        Me.Text = "Replace Entry"
        Me.grpJobInformation.ResumeLayout(False)
        Me.grpJobInformation.PerformLayout()
        Me.grpReplaceSetDetails.ResumeLayout(False)
        Me.grpReplaceSetDetails.PerformLayout()
        Me.grpReplaceInformation.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpJobInformation As GroupBox
    Friend WithEvents txtReplaceNrDate As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtReplaceJobCode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents grpReplaceSetDetails As GroupBox
    Friend WithEvents txtReplaceOthers As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtReplaceESNB As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtReplaceESN As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtReplaceSLno As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents grpReplaceInformation As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents dtpReplaceDate As DateTimePicker
    Friend WithEvents lblReplaceByName As Label
    Friend WithEvents cmdSave As Button
    Friend WithEvents cmdClose As Button
    Friend WithEvents cmbReplaceModel As ComboBox
    Friend WithEvents cmbReplaceBrand As ComboBox
    Friend WithEvents cmbReplaceby As ComboBox
End Class
