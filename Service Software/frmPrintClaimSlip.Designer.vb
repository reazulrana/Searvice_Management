<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintClaimSlip
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
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.optAll = New System.Windows.Forms.RadioButton()
        Me.optClaimSlip = New System.Windows.Forms.RadioButton()
        Me.optJobSlip1 = New System.Windows.Forms.RadioButton()
        Me.optJobSlip2 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.txtAdvance = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTransportCharge = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtServiceCharge = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.BackColor = System.Drawing.Color.LightCoral
        Me.lblHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeader.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.Maroon
        Me.lblHeader.Location = New System.Drawing.Point(0, 0)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.lblHeader.Size = New System.Drawing.Size(385, 29)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Customer Claim Report"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Salmon
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(0, 186)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(385, 10)
        Me.Label1.TabIndex = 1
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LightCoral
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(366, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "X"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'optAll
        '
        Me.optAll.AutoSize = True
        Me.optAll.Location = New System.Drawing.Point(12, 61)
        Me.optAll.Name = "optAll"
        Me.optAll.Size = New System.Drawing.Size(56, 17)
        Me.optAll.TabIndex = 5
        Me.optAll.TabStop = True
        Me.optAll.Text = "All Slip"
        Me.optAll.UseVisualStyleBackColor = True
        '
        'optClaimSlip
        '
        Me.optClaimSlip.AutoSize = True
        Me.optClaimSlip.Location = New System.Drawing.Point(97, 62)
        Me.optClaimSlip.Name = "optClaimSlip"
        Me.optClaimSlip.Size = New System.Drawing.Size(70, 17)
        Me.optClaimSlip.TabIndex = 6
        Me.optClaimSlip.TabStop = True
        Me.optClaimSlip.Text = "Claim Slip"
        Me.optClaimSlip.UseVisualStyleBackColor = True
        '
        'optJobSlip1
        '
        Me.optJobSlip1.AutoSize = True
        Me.optJobSlip1.Location = New System.Drawing.Point(197, 62)
        Me.optJobSlip1.Name = "optJobSlip1"
        Me.optJobSlip1.Size = New System.Drawing.Size(71, 17)
        Me.optJobSlip1.TabIndex = 7
        Me.optJobSlip1.TabStop = True
        Me.optJobSlip1.Text = "Job Slip 1"
        Me.optJobSlip1.UseVisualStyleBackColor = True
        '
        'optJobSlip2
        '
        Me.optJobSlip2.AutoSize = True
        Me.optJobSlip2.Location = New System.Drawing.Point(291, 62)
        Me.optJobSlip2.Name = "optJobSlip2"
        Me.optJobSlip2.Size = New System.Drawing.Size(71, 17)
        Me.optJobSlip2.TabIndex = 8
        Me.optJobSlip2.TabStop = True
        Me.optJobSlip2.Text = "Job Slip 2"
        Me.optJobSlip2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.MistyRose
        Me.GroupBox1.Controls.Add(Me.cmdClose)
        Me.GroupBox1.Controls.Add(Me.cmdPrint)
        Me.GroupBox1.Controls.Add(Me.txtAdvance)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtTransportCharge)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtServiceCharge)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 97)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(379, 84)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Charges"
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClose.ForeColor = System.Drawing.Color.Maroon
        Me.cmdClose.Location = New System.Drawing.Point(205, 55)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(169, 23)
        Me.cmdClose.TabIndex = 22
        Me.cmdClose.Text = "C&lose"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdPrint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPrint.ForeColor = System.Drawing.Color.Maroon
        Me.cmdPrint.Location = New System.Drawing.Point(11, 55)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(169, 23)
        Me.cmdPrint.TabIndex = 21
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.UseVisualStyleBackColor = False
        '
        'txtAdvance
        '
        Me.txtAdvance.Location = New System.Drawing.Point(301, 20)
        Me.txtAdvance.Name = "txtAdvance"
        Me.txtAdvance.Size = New System.Drawing.Size(67, 20)
        Me.txtAdvance.TabIndex = 20
        Me.txtAdvance.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(249, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Advance"
        '
        'txtTransportCharge
        '
        Me.txtTransportCharge.Location = New System.Drawing.Point(177, 20)
        Me.txtTransportCharge.Name = "txtTransportCharge"
        Me.txtTransportCharge.Size = New System.Drawing.Size(67, 20)
        Me.txtTransportCharge.TabIndex = 18
        Me.txtTransportCharge.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(123, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Transport"
        '
        'txtServiceCharge
        '
        Me.txtServiceCharge.Location = New System.Drawing.Point(51, 21)
        Me.txtServiceCharge.Name = "txtServiceCharge"
        Me.txtServiceCharge.ReadOnly = True
        Me.txtServiceCharge.Size = New System.Drawing.Size(67, 20)
        Me.txtServiceCharge.TabIndex = 16
        Me.txtServiceCharge.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Service"
        '
        'frmPrintClaimSlip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(385, 196)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.optJobSlip2)
        Me.Controls.Add(Me.optJobSlip1)
        Me.Controls.Add(Me.optClaimSlip)
        Me.Controls.Add(Me.optAll)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPrintClaimSlip"
        Me.Text = "frmPrintClaimSlip"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents optAll As RadioButton
    Friend WithEvents optClaimSlip As RadioButton
    Friend WithEvents optJobSlip1 As RadioButton
    Friend WithEvents optJobSlip2 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmdClose As Button
    Friend WithEvents cmdPrint As Button
    Friend WithEvents txtAdvance As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTransportCharge As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtServiceCharge As TextBox
    Friend WithEvents Label3 As Label
End Class
