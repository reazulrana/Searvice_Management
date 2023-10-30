<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmJobUpdate
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
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblBottomStatus = New System.Windows.Forms.Label()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(9, 55)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(130, 23)
        Me.btnLoad.TabIndex = 1
        Me.btnLoad.Text = "&Reset"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(152, 55)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "&Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblBottomStatus
        '
        Me.lblBottomStatus.BackColor = System.Drawing.Color.Silver
        Me.lblBottomStatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblBottomStatus.ForeColor = System.Drawing.Color.White
        Me.lblBottomStatus.Location = New System.Drawing.Point(0, 92)
        Me.lblBottomStatus.Name = "lblBottomStatus"
        Me.lblBottomStatus.Size = New System.Drawing.Size(291, 28)
        Me.lblBottomStatus.TabIndex = 4
        '
        'lblHeader
        '
        Me.lblHeader.BackColor = System.Drawing.Color.Silver
        Me.lblHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.Black
        Me.lblHeader.Location = New System.Drawing.Point(0, 0)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(291, 34)
        Me.lblHeader.TabIndex = 5
        Me.lblHeader.Text = "Reset Job"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblClose
        '
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.Color.Silver
        Me.lblClose.ForeColor = System.Drawing.Color.Black
        Me.lblClose.Location = New System.Drawing.Point(268, 9)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(14, 13)
        Me.lblClose.TabIndex = 6
        Me.lblClose.Text = "X"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(6, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Note: Job will be started from 1"
        '
        'frmJobUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(291, 120)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.lblBottomStatus)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnLoad)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmJobUpdate"
        Me.Text = "frmJobUpdate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLoad As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lblBottomStatus As Label
    Friend WithEvents lblHeader As Label
    Friend WithEvents lblClose As Label
    Friend WithEvents Label1 As Label
End Class
