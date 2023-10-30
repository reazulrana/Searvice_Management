<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMergeDatabase
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
        Me.components = New System.ComponentModel.Container()
        Me.dlgFileOpen = New System.Windows.Forms.OpenFileDialog()
        Me.btnOpenFile = New System.Windows.Forms.Button()
        Me.btnMerge = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.lblElapseTime = New System.Windows.Forms.Label()
        Me.prgbarMerger = New System.Windows.Forms.ProgressBar()
        Me.lblPercentage = New System.Windows.Forms.Label()
        Me.lblStartTime = New System.Windows.Forms.Label()
        Me.lblEndTime = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblProcessingTable = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.optFastLoad = New System.Windows.Forms.RadioButton()
        Me.optNormalLoad = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnOpenFile
        '
        Me.btnOpenFile.Location = New System.Drawing.Point(12, 65)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(106, 23)
        Me.btnOpenFile.TabIndex = 0
        Me.btnOpenFile.Text = "Open &File"
        Me.btnOpenFile.UseVisualStyleBackColor = True
        '
        'btnMerge
        '
        Me.btnMerge.Location = New System.Drawing.Point(129, 65)
        Me.btnMerge.Name = "btnMerge"
        Me.btnMerge.Size = New System.Drawing.Size(106, 23)
        Me.btnMerge.TabIndex = 1
        Me.btnMerge.Text = "Import Data"
        Me.btnMerge.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.BackColor = System.Drawing.Color.DarkRed
        Me.lblMessage.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblMessage.ForeColor = System.Drawing.Color.White
        Me.lblMessage.Location = New System.Drawing.Point(0, 379)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblMessage.Size = New System.Drawing.Size(356, 27)
        Me.lblMessage.TabIndex = 2
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DarkRed
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(-6, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label2.Size = New System.Drawing.Size(370, 28)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Data Transformation"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblClose
        '
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.Color.DarkRed
        Me.lblClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClose.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.ForeColor = System.Drawing.Color.White
        Me.lblClose.Location = New System.Drawing.Point(336, 6)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(14, 13)
        Me.lblClose.TabIndex = 4
        Me.lblClose.Text = "X"
        '
        'lblElapseTime
        '
        Me.lblElapseTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblElapseTime.Location = New System.Drawing.Point(16, 198)
        Me.lblElapseTime.Name = "lblElapseTime"
        Me.lblElapseTime.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblElapseTime.Size = New System.Drawing.Size(331, 21)
        Me.lblElapseTime.TabIndex = 6
        '
        'prgbarMerger
        '
        Me.prgbarMerger.Location = New System.Drawing.Point(13, 305)
        Me.prgbarMerger.Name = "prgbarMerger"
        Me.prgbarMerger.Size = New System.Drawing.Size(334, 23)
        Me.prgbarMerger.TabIndex = 7
        '
        'lblPercentage
        '
        Me.lblPercentage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPercentage.Location = New System.Drawing.Point(16, 282)
        Me.lblPercentage.Name = "lblPercentage"
        Me.lblPercentage.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblPercentage.Size = New System.Drawing.Size(331, 19)
        Me.lblPercentage.TabIndex = 8
        Me.lblPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStartTime
        '
        Me.lblStartTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblStartTime.Location = New System.Drawing.Point(16, 112)
        Me.lblStartTime.Name = "lblStartTime"
        Me.lblStartTime.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblStartTime.Size = New System.Drawing.Size(331, 21)
        Me.lblStartTime.TabIndex = 9
        '
        'lblEndTime
        '
        Me.lblEndTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEndTime.Location = New System.Drawing.Point(16, 156)
        Me.lblEndTime.Name = "lblEndTime"
        Me.lblEndTime.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblEndTime.Size = New System.Drawing.Size(331, 21)
        Me.lblEndTime.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Start Time"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "End Time"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = " Elapse Time"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(241, 65)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(106, 23)
        Me.btnClose.TabIndex = 14
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 267)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Percentage"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 224)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Time"
        '
        'lblTime
        '
        Me.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTime.Location = New System.Drawing.Point(16, 239)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblTime.Size = New System.Drawing.Size(331, 21)
        Me.lblTime.TabIndex = 16
        '
        'lblProcessingTable
        '
        Me.lblProcessingTable.Location = New System.Drawing.Point(16, 332)
        Me.lblProcessingTable.Name = "lblProcessingTable"
        Me.lblProcessingTable.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.lblProcessingTable.Size = New System.Drawing.Size(331, 37)
        Me.lblProcessingTable.TabIndex = 18
        '
        'Timer1
        '
        '
        'optFastLoad
        '
        Me.optFastLoad.AutoSize = True
        Me.optFastLoad.Location = New System.Drawing.Point(12, 42)
        Me.optFastLoad.Name = "optFastLoad"
        Me.optFastLoad.Size = New System.Drawing.Size(72, 17)
        Me.optFastLoad.TabIndex = 20
        Me.optFastLoad.TabStop = True
        Me.optFastLoad.Text = "Fast Load"
        Me.optFastLoad.UseVisualStyleBackColor = True
        '
        'optNormalLoad
        '
        Me.optNormalLoad.AutoSize = True
        Me.optNormalLoad.Location = New System.Drawing.Point(108, 42)
        Me.optNormalLoad.Name = "optNormalLoad"
        Me.optNormalLoad.Size = New System.Drawing.Size(85, 17)
        Me.optNormalLoad.TabIndex = 21
        Me.optNormalLoad.TabStop = True
        Me.optNormalLoad.Text = "Normal Load"
        Me.optNormalLoad.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Maroon
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(3, 382)
        Me.Label7.Name = "Label7"
        Me.Label7.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label7.Size = New System.Drawing.Size(341, 19)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Note: Transfer old Database to New and Blank Database "
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmMergeDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Bisque
        Me.ClientSize = New System.Drawing.Size(356, 406)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.optNormalLoad)
        Me.Controls.Add(Me.optFastLoad)
        Me.Controls.Add(Me.lblProcessingTable)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblEndTime)
        Me.Controls.Add(Me.lblStartTime)
        Me.Controls.Add(Me.lblPercentage)
        Me.Controls.Add(Me.prgbarMerger)
        Me.Controls.Add(Me.lblElapseTime)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnMerge)
        Me.Controls.Add(Me.btnOpenFile)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMergeDatabase"
        Me.Text = "Merge Database"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dlgFileOpen As OpenFileDialog
    Friend WithEvents btnOpenFile As Button
    Friend WithEvents btnMerge As Button
    Friend WithEvents lblMessage As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblClose As Label
    Friend WithEvents lblElapseTime As Label
    Friend WithEvents prgbarMerger As ProgressBar
    Friend WithEvents lblPercentage As Label
    Friend WithEvents lblStartTime As Label
    Friend WithEvents lblEndTime As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents lblProcessingTable As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents optFastLoad As RadioButton
    Friend WithEvents optNormalLoad As RadioButton
    Friend WithEvents Label7 As Label
End Class
