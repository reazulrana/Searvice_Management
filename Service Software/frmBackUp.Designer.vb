<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBackUp
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
        Me.txtDestination = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdSetLocation = New System.Windows.Forms.Button()
        Me.cmdBackUp = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.fldLocation = New System.Windows.Forms.FolderBrowserDialog()
        Me.cmdSourceFile = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSourceFile = New System.Windows.Forms.TextBox()
        Me.OFDSourceFile = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'txtDestination
        '
        Me.txtDestination.Location = New System.Drawing.Point(9, 65)
        Me.txtDestination.Name = "txtDestination"
        Me.txtDestination.Size = New System.Drawing.Size(335, 20)
        Me.txtDestination.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Backup Destination"
        '
        'cmdSetLocation
        '
        Me.cmdSetLocation.Location = New System.Drawing.Point(345, 63)
        Me.cmdSetLocation.Name = "cmdSetLocation"
        Me.cmdSetLocation.Size = New System.Drawing.Size(28, 23)
        Me.cmdSetLocation.TabIndex = 2
        Me.cmdSetLocation.Text = "..."
        Me.cmdSetLocation.UseVisualStyleBackColor = True
        '
        'cmdBackUp
        '
        Me.cmdBackUp.Location = New System.Drawing.Point(109, 89)
        Me.cmdBackUp.Name = "cmdBackUp"
        Me.cmdBackUp.Size = New System.Drawing.Size(94, 23)
        Me.cmdBackUp.TabIndex = 3
        Me.cmdBackUp.Text = "Back Up "
        Me.cmdBackUp.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(209, 89)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(94, 23)
        Me.cmdClose.TabIndex = 4
        Me.cmdClose.Text = "Clsoe"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdSourceFile
        '
        Me.cmdSourceFile.Location = New System.Drawing.Point(345, 23)
        Me.cmdSourceFile.Name = "cmdSourceFile"
        Me.cmdSourceFile.Size = New System.Drawing.Size(28, 23)
        Me.cmdSourceFile.TabIndex = 7
        Me.cmdSourceFile.Text = "..."
        Me.cmdSourceFile.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Source File"
        '
        'txtSourceFile
        '
        Me.txtSourceFile.Location = New System.Drawing.Point(9, 25)
        Me.txtSourceFile.Name = "txtSourceFile"
        Me.txtSourceFile.Size = New System.Drawing.Size(335, 20)
        Me.txtSourceFile.TabIndex = 5
        '
        'frmBackUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 115)
        Me.Controls.Add(Me.cmdSourceFile)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSourceFile)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdBackUp)
        Me.Controls.Add(Me.cmdSetLocation)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDestination)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBackUp"
        Me.Text = "Back up Database"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDestination As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdSetLocation As Button
    Friend WithEvents cmdBackUp As Button
    Friend WithEvents cmdClose As Button
    Friend WithEvents fldLocation As FolderBrowserDialog
    Friend WithEvents cmdSourceFile As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSourceFile As TextBox
    Friend WithEvents OFDSourceFile As OpenFileDialog
End Class
