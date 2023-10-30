<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetBranch
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
        Me.cmdSet = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmbBranch = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CachedrptBillPayment1 = New Service_Software.CachedrptBillPayment()
        Me.SuspendLayout()
        '
        'cmdSet
        '
        Me.cmdSet.BackColor = System.Drawing.Color.LightSeaGreen
        Me.cmdSet.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSet.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise
        Me.cmdSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSet.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.cmdSet.Location = New System.Drawing.Point(13, 43)
        Me.cmdSet.Name = "cmdSet"
        Me.cmdSet.Size = New System.Drawing.Size(129, 23)
        Me.cmdSet.TabIndex = 0
        Me.cmdSet.Text = "&Set"
        Me.cmdSet.UseVisualStyleBackColor = False
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.Color.LightSeaGreen
        Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdClose.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClose.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.cmdClose.Location = New System.Drawing.Point(148, 43)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(129, 23)
        Me.cmdClose.TabIndex = 1
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'cmbBranch
        '
        Me.cmbBranch.BackColor = System.Drawing.Color.Teal
        Me.cmbBranch.DropDownHeight = 70
        Me.cmbBranch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbBranch.ForeColor = System.Drawing.Color.White
        Me.cmbBranch.FormattingEnabled = True
        Me.cmbBranch.IntegralHeight = False
        Me.cmbBranch.Location = New System.Drawing.Point(13, 72)
        Me.cmbBranch.Name = "cmbBranch"
        Me.cmbBranch.Size = New System.Drawing.Size(264, 21)
        Me.cmbBranch.Sorted = True
        Me.cmbBranch.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Teal
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(-3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(297, 28)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Set Branch"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblClose
        '
        Me.lblClose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.Color.Teal
        Me.lblClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblClose.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.ForeColor = System.Drawing.Color.White
        Me.lblClose.Location = New System.Drawing.Point(271, 5)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(15, 14)
        Me.lblClose.TabIndex = 4
        Me.lblClose.Text = "X"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Teal
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(-3, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Label2.Size = New System.Drawing.Size(297, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Go To Branch List"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmSetBranch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(291, 152)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbBranch)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdSet)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSetBranch"
        Me.Text = "Set Branch"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdSet As Button
    Friend WithEvents cmdClose As Button
    Friend WithEvents cmbBranch As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblClose As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CachedrptBillPayment1 As CachedrptBillPayment
End Class
