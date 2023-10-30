<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditCategoryBrand
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
        Me.components = New System.ComponentModel.Container()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.grpCategory = New System.Windows.Forms.GroupBox()
        Me.txtUpdateCategory = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpBrand = New System.Windows.Forms.GroupBox()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUpdateBrand = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tlBrand = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpCategory.SuspendLayout()
        Me.grpBrand.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Location = New System.Drawing.Point(121, 140)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(75, 23)
        Me.cmdUpdate.TabIndex = 0
        Me.cmdUpdate.Text = "&Update"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(202, 140)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 1
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'grpCategory
        '
        Me.grpCategory.Controls.Add(Me.txtUpdateCategory)
        Me.grpCategory.Controls.Add(Me.Label1)
        Me.grpCategory.Location = New System.Drawing.Point(12, 12)
        Me.grpCategory.Name = "grpCategory"
        Me.grpCategory.Size = New System.Drawing.Size(294, 51)
        Me.grpCategory.TabIndex = 2
        Me.grpCategory.TabStop = False
        Me.grpCategory.Visible = False
        '
        'txtUpdateCategory
        '
        Me.txtUpdateCategory.Location = New System.Drawing.Point(113, 19)
        Me.txtUpdateCategory.Name = "txtUpdateCategory"
        Me.txtUpdateCategory.Size = New System.Drawing.Size(161, 20)
        Me.txtUpdateCategory.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Replace Category:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'grpBrand
        '
        Me.grpBrand.Controls.Add(Me.lblCategory)
        Me.grpBrand.Controls.Add(Me.Label3)
        Me.grpBrand.Controls.Add(Me.txtUpdateBrand)
        Me.grpBrand.Controls.Add(Me.Label2)
        Me.grpBrand.Location = New System.Drawing.Point(12, 55)
        Me.grpBrand.Name = "grpBrand"
        Me.grpBrand.Size = New System.Drawing.Size(294, 82)
        Me.grpBrand.TabIndex = 3
        Me.grpBrand.TabStop = False
        Me.grpBrand.Visible = False
        '
        'lblCategory
        '
        Me.lblCategory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategory.Location = New System.Drawing.Point(113, 15)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(161, 23)
        Me.lblCategory.TabIndex = 3
        Me.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Category:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtUpdateBrand
        '
        Me.txtUpdateBrand.Location = New System.Drawing.Point(113, 45)
        Me.txtUpdateBrand.Name = "txtUpdateBrand"
        Me.txtUpdateBrand.Size = New System.Drawing.Size(161, 20)
        Me.txtUpdateBrand.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Replace Brand:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tlBrand
        '
        Me.tlBrand.AutoPopDelay = 0
        Me.tlBrand.InitialDelay = 500
        Me.tlBrand.IsBalloon = True
        Me.tlBrand.ReshowDelay = 100
        Me.tlBrand.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'frmEditCategoryBrand
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 163)
        Me.Controls.Add(Me.grpBrand)
        Me.Controls.Add(Me.grpCategory)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdUpdate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEditCategoryBrand"
        Me.Text = "frmEditCategoryBrand"
        Me.grpCategory.ResumeLayout(False)
        Me.grpCategory.PerformLayout()
        Me.grpBrand.ResumeLayout(False)
        Me.grpBrand.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdUpdate As Button
    Friend WithEvents cmdClose As Button
    Friend WithEvents grpCategory As GroupBox
    Friend WithEvents txtUpdateCategory As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents grpBrand As GroupBox
    Friend WithEvents lblCategory As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUpdateBrand As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tlBrand As ToolTip
End Class
