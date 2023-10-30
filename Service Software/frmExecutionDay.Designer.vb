<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExecutionDay
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExecutionDay))
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.picClose = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdDone = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkFri = New System.Windows.Forms.CheckBox()
        Me.chkThu = New System.Windows.Forms.CheckBox()
        Me.chkWed = New System.Windows.Forms.CheckBox()
        Me.chkTue = New System.Windows.Forms.CheckBox()
        Me.chkMon = New System.Windows.Forms.CheckBox()
        Me.chkSun = New System.Windows.Forms.CheckBox()
        Me.chkSat = New System.Windows.Forms.CheckBox()
        Me.pnlHeader.SuspendLayout()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFooter.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.Khaki
        Me.pnlHeader.Controls.Add(Me.picClose)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(310, 41)
        Me.pnlHeader.TabIndex = 0
        '
        'picClose
        '
        Me.picClose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.picClose.Image = CType(resources.GetObject("picClose.Image"), System.Drawing.Image)
        Me.picClose.Location = New System.Drawing.Point(272, 6)
        Me.picClose.Name = "picClose"
        Me.picClose.Size = New System.Drawing.Size(30, 27)
        Me.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picClose.TabIndex = 33
        Me.picClose.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Olive
        Me.lblTitle.Location = New System.Drawing.Point(10, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(120, 20)
        Me.lblTitle.TabIndex = 32
        Me.lblTitle.Text = "Schedule Day"
        '
        'pnlFooter
        '
        Me.pnlFooter.BackColor = System.Drawing.Color.Khaki
        Me.pnlFooter.Controls.Add(Me.lblStatus)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 230)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(310, 29)
        Me.pnlFooter.TabIndex = 1
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.Olive
        Me.lblStatus.Location = New System.Drawing.Point(6, 5)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 13)
        Me.lblStatus.TabIndex = 41
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdDone)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.chkFri)
        Me.GroupBox1.Controls.Add(Me.chkThu)
        Me.GroupBox1.Controls.Add(Me.chkWed)
        Me.GroupBox1.Controls.Add(Me.chkTue)
        Me.GroupBox1.Controls.Add(Me.chkMon)
        Me.GroupBox1.Controls.Add(Me.chkSun)
        Me.GroupBox1.Controls.Add(Me.chkSat)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(289, 149)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'cmdDone
        '
        Me.cmdDone.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cmdDone.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod
        Me.cmdDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDone.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDone.ForeColor = System.Drawing.Color.Olive
        Me.cmdDone.Location = New System.Drawing.Point(13, 108)
        Me.cmdDone.Name = "cmdDone"
        Me.cmdDone.Size = New System.Drawing.Size(264, 26)
        Me.cmdDone.TabIndex = 41
        Me.cmdDone.Text = "&DONE"
        Me.cmdDone.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Olive
        Me.Label5.Location = New System.Drawing.Point(13, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 15)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Execution Day"
        '
        'chkFri
        '
        Me.chkFri.AutoSize = True
        Me.chkFri.Location = New System.Drawing.Point(77, 85)
        Me.chkFri.Name = "chkFri"
        Me.chkFri.Size = New System.Drawing.Size(37, 17)
        Me.chkFri.TabIndex = 39
        Me.chkFri.Text = "Fri"
        Me.chkFri.UseVisualStyleBackColor = True
        '
        'chkThu
        '
        Me.chkThu.AutoSize = True
        Me.chkThu.Location = New System.Drawing.Point(16, 85)
        Me.chkThu.Name = "chkThu"
        Me.chkThu.Size = New System.Drawing.Size(45, 17)
        Me.chkThu.TabIndex = 38
        Me.chkThu.Text = "Thu"
        Me.chkThu.UseVisualStyleBackColor = True
        '
        'chkWed
        '
        Me.chkWed.AutoSize = True
        Me.chkWed.Location = New System.Drawing.Point(228, 52)
        Me.chkWed.Name = "chkWed"
        Me.chkWed.Size = New System.Drawing.Size(49, 17)
        Me.chkWed.TabIndex = 37
        Me.chkWed.Text = "Wed"
        Me.chkWed.UseVisualStyleBackColor = True
        '
        'chkTue
        '
        Me.chkTue.AutoSize = True
        Me.chkTue.Location = New System.Drawing.Point(177, 52)
        Me.chkTue.Name = "chkTue"
        Me.chkTue.Size = New System.Drawing.Size(45, 17)
        Me.chkTue.TabIndex = 36
        Me.chkTue.Text = "Tue"
        Me.chkTue.UseVisualStyleBackColor = True
        '
        'chkMon
        '
        Me.chkMon.AutoSize = True
        Me.chkMon.Location = New System.Drawing.Point(128, 52)
        Me.chkMon.Name = "chkMon"
        Me.chkMon.Size = New System.Drawing.Size(47, 17)
        Me.chkMon.TabIndex = 35
        Me.chkMon.Text = "Mon"
        Me.chkMon.UseVisualStyleBackColor = True
        '
        'chkSun
        '
        Me.chkSun.AutoSize = True
        Me.chkSun.Location = New System.Drawing.Point(77, 52)
        Me.chkSun.Name = "chkSun"
        Me.chkSun.Size = New System.Drawing.Size(45, 17)
        Me.chkSun.TabIndex = 34
        Me.chkSun.Text = "Sun"
        Me.chkSun.UseVisualStyleBackColor = True
        '
        'chkSat
        '
        Me.chkSat.AutoSize = True
        Me.chkSat.Location = New System.Drawing.Point(16, 52)
        Me.chkSat.Name = "chkSat"
        Me.chkSat.Size = New System.Drawing.Size(42, 17)
        Me.chkSat.TabIndex = 33
        Me.chkSat.Text = "Sat"
        Me.chkSat.UseVisualStyleBackColor = True
        '
        'frmExecutionDay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(310, 259)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pnlFooter)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmExecutionDay"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFooter.ResumeLayout(False)
        Me.pnlFooter.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents pnlFooter As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmdDone As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents chkFri As CheckBox
    Friend WithEvents chkThu As CheckBox
    Friend WithEvents chkWed As CheckBox
    Friend WithEvents chkTue As CheckBox
    Friend WithEvents chkMon As CheckBox
    Friend WithEvents chkSun As CheckBox
    Friend WithEvents chkSat As CheckBox
    Friend WithEvents picClose As PictureBox
    Friend WithEvents lblStatus As Label
End Class
