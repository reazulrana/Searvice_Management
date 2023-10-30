<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMerge
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
        Me.cmdLoad = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.PBLoad = New System.Windows.Forms.ProgressBar()
        Me.lblPercentage = New System.Windows.Forms.Label()
        Me.lstUpdateStatus = New System.Windows.Forms.ListBox()
        Me.lblTotalRecord = New System.Windows.Forms.Label()
        Me.lblProgressRecord = New System.Windows.Forms.Label()
        Me.cmdCreateTable = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdLoad
        '
        Me.cmdLoad.Location = New System.Drawing.Point(16, 272)
        Me.cmdLoad.Name = "cmdLoad"
        Me.cmdLoad.Size = New System.Drawing.Size(99, 23)
        Me.cmdLoad.TabIndex = 0
        Me.cmdLoad.Text = "&Merge Data"
        Me.cmdLoad.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(224, 272)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(99, 23)
        Me.cmdClose.TabIndex = 1
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'PBLoad
        '
        Me.PBLoad.Location = New System.Drawing.Point(12, 12)
        Me.PBLoad.Name = "PBLoad"
        Me.PBLoad.Size = New System.Drawing.Size(377, 23)
        Me.PBLoad.TabIndex = 4
        '
        'lblPercentage
        '
        Me.lblPercentage.AutoSize = True
        Me.lblPercentage.Location = New System.Drawing.Point(201, 9)
        Me.lblPercentage.Name = "lblPercentage"
        Me.lblPercentage.Size = New System.Drawing.Size(0, 13)
        Me.lblPercentage.TabIndex = 5
        '
        'lstUpdateStatus
        '
        Me.lstUpdateStatus.FormattingEnabled = True
        Me.lstUpdateStatus.Location = New System.Drawing.Point(12, 67)
        Me.lstUpdateStatus.Name = "lstUpdateStatus"
        Me.lstUpdateStatus.Size = New System.Drawing.Size(377, 160)
        Me.lstUpdateStatus.TabIndex = 7
        '
        'lblTotalRecord
        '
        Me.lblTotalRecord.AutoSize = True
        Me.lblTotalRecord.Location = New System.Drawing.Point(13, 42)
        Me.lblTotalRecord.Name = "lblTotalRecord"
        Me.lblTotalRecord.Size = New System.Drawing.Size(75, 13)
        Me.lblTotalRecord.TabIndex = 8
        Me.lblTotalRecord.Text = "Total Record :"
        '
        'lblProgressRecord
        '
        Me.lblProgressRecord.AutoSize = True
        Me.lblProgressRecord.Location = New System.Drawing.Point(185, 42)
        Me.lblProgressRecord.Name = "lblProgressRecord"
        Me.lblProgressRecord.Size = New System.Drawing.Size(0, 13)
        Me.lblProgressRecord.TabIndex = 9
        '
        'cmdCreateTable
        '
        Me.cmdCreateTable.Location = New System.Drawing.Point(121, 272)
        Me.cmdCreateTable.Name = "cmdCreateTable"
        Me.cmdCreateTable.Size = New System.Drawing.Size(98, 23)
        Me.cmdCreateTable.TabIndex = 10
        Me.cmdCreateTable.Text = "Create Table"
        Me.cmdCreateTable.UseVisualStyleBackColor = True
        '
        'frmMerge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 328)
        Me.Controls.Add(Me.cmdCreateTable)
        Me.Controls.Add(Me.lblProgressRecord)
        Me.Controls.Add(Me.lblTotalRecord)
        Me.Controls.Add(Me.lstUpdateStatus)
        Me.Controls.Add(Me.lblPercentage)
        Me.Controls.Add(Me.PBLoad)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdLoad)
        Me.Name = "frmMerge"
        Me.Text = "Merge"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdLoad As Button
    Friend WithEvents cmdClose As Button
    Friend WithEvents PBLoad As ProgressBar
    Friend WithEvents lblPercentage As Label
    Friend WithEvents lstUpdateStatus As ListBox
    Friend WithEvents lblTotalRecord As Label
    Friend WithEvents lblProgressRecord As Label
    Friend WithEvents cmdCreateTable As Button
End Class
