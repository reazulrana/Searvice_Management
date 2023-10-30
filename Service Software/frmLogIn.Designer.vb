<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogIn
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
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.txtPassoword = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblClose = New System.Windows.Forms.Label()
        Me.btnSignin = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tooltipLogin = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtUserName
        '
        Me.txtUserName.BackColor = System.Drawing.Color.White
        Me.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserName.ForeColor = System.Drawing.Color.Black
        Me.txtUserName.Location = New System.Drawing.Point(266, 162)
        Me.txtUserName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(458, 26)
        Me.txtUserName.TabIndex = 1
        Me.txtUserName.Text = "User Name"
        Me.tooltipLogin.SetToolTip(Me.txtUserName, "Enter User Name")
        '
        'txtPassoword
        '
        Me.txtPassoword.BackColor = System.Drawing.Color.White
        Me.txtPassoword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassoword.ForeColor = System.Drawing.Color.Black
        Me.txtPassoword.Location = New System.Drawing.Point(266, 209)
        Me.txtPassoword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPassoword.Name = "txtPassoword"
        Me.txtPassoword.Size = New System.Drawing.Size(458, 26)
        Me.txtPassoword.TabIndex = 3
        Me.txtPassoword.Text = "Password"
        Me.tooltipLogin.SetToolTip(Me.txtPassoword, "Enter Password")
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.White
        Me.lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblStatus.ForeColor = System.Drawing.Color.White
        Me.lblStatus.Location = New System.Drawing.Point(236, 322)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.lblStatus.Size = New System.Drawing.Size(526, 63)
        Me.lblStatus.TabIndex = 7
        '
        'lblClose
        '
        Me.lblClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblClose.AutoSize = True
        Me.lblClose.BackColor = System.Drawing.Color.White
        Me.lblClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClose.ForeColor = System.Drawing.Color.Black
        Me.lblClose.Location = New System.Drawing.Point(477, 14)
        Me.lblClose.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblClose.Name = "lblClose"
        Me.lblClose.Size = New System.Drawing.Size(31, 29)
        Me.lblClose.TabIndex = 10
        Me.lblClose.Text = "X"
        Me.lblClose.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnSignin
        '
        Me.btnSignin.BackColor = System.Drawing.Color.Black
        Me.btnSignin.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSignin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnSignin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSignin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSignin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSignin.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignin.ForeColor = System.Drawing.Color.White
        Me.btnSignin.Location = New System.Drawing.Point(266, 257)
        Me.btnSignin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSignin.Name = "btnSignin"
        Me.btnSignin.Size = New System.Drawing.Size(458, 40)
        Me.btnSignin.TabIndex = 14
        Me.btnSignin.Text = "Log In"
        Me.btnSignin.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(236, 385)
        Me.Panel1.TabIndex = 15
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.Service_Software.My.Resources.Resources.user_icon
        Me.PictureBox1.Location = New System.Drawing.Point(18, 71)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(194, 225)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(266, 71)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(478, 57)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Log In"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.lblClose)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(236, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(526, 62)
        Me.Panel2.TabIndex = 16
        '
        'tooltipLogin
        '
        Me.tooltipLogin.BackColor = System.Drawing.Color.White
        '
        'frmLogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(762, 385)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnSignin)
        Me.Controls.Add(Me.txtPassoword)
        Me.Controls.Add(Me.txtUserName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmLogIn"
        Me.Opacity = 0.95R
        Me.Text = "Log In"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents txtPassoword As TextBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblClose As Label
    Friend WithEvents btnSignin As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents tooltipLogin As ToolTip
End Class
