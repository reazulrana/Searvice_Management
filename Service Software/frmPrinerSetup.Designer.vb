<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrinerSetup
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
        Me.lstPrinterList = New System.Windows.Forms.ListBox()
        Me.cmdSetDefault = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.PrintDoc = New System.Drawing.Printing.PrintDocument()
        Me.lblPrinterList = New System.Windows.Forms.Label()
        Me.lblDefaultPrinter = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstPrinterList
        '
        Me.lstPrinterList.FormattingEnabled = True
        Me.lstPrinterList.Location = New System.Drawing.Point(12, 11)
        Me.lstPrinterList.Name = "lstPrinterList"
        Me.lstPrinterList.Size = New System.Drawing.Size(379, 173)
        Me.lstPrinterList.TabIndex = 0
        '
        'cmdSetDefault
        '
        Me.cmdSetDefault.Location = New System.Drawing.Point(22, 190)
        Me.cmdSetDefault.Name = "cmdSetDefault"
        Me.cmdSetDefault.Size = New System.Drawing.Size(75, 23)
        Me.cmdSetDefault.TabIndex = 1
        Me.cmdSetDefault.Text = "&Set Default"
        Me.cmdSetDefault.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(106, 190)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 2
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'lblPrinterList
        '
        Me.lblPrinterList.AutoSize = True
        Me.lblPrinterList.Location = New System.Drawing.Point(41, 230)
        Me.lblPrinterList.Name = "lblPrinterList"
        Me.lblPrinterList.Size = New System.Drawing.Size(56, 13)
        Me.lblPrinterList.TabIndex = 3
        Me.lblPrinterList.Text = "Printer List"
        '
        'lblDefaultPrinter
        '
        Me.lblDefaultPrinter.AutoSize = True
        Me.lblDefaultPrinter.Location = New System.Drawing.Point(160, 240)
        Me.lblDefaultPrinter.Name = "lblDefaultPrinter"
        Me.lblDefaultPrinter.Size = New System.Drawing.Size(0, 13)
        Me.lblDefaultPrinter.TabIndex = 4
        '
        'frmPrinerSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 262)
        Me.Controls.Add(Me.lblDefaultPrinter)
        Me.Controls.Add(Me.lblPrinterList)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdSetDefault)
        Me.Controls.Add(Me.lstPrinterList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPrinerSetup"
        Me.Text = "Printer Setup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstPrinterList As ListBox
    Friend WithEvents cmdSetDefault As Button
    Friend WithEvents cmdClose As Button
    Friend WithEvents PrintDoc As Printing.PrintDocument
    Friend WithEvents lblPrinterList As Label
    Friend WithEvents lblDefaultPrinter As Label
End Class
