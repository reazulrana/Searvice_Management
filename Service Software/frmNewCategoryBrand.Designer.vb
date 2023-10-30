<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewCategoryBrand
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
        Me.grpBrand = New System.Windows.Forms.GroupBox()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBrand = New System.Windows.Forms.TextBox()
        Me.grpCategory = New System.Windows.Forms.GroupBox()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.tltpNewCategoryBRand = New System.Windows.Forms.ToolTip(Me.components)
        Me.timerNewCategory = New System.Windows.Forms.Timer(Me.components)
        Me.grpBrand.SuspendLayout()
        Me.grpCategory.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpBrand
        '
        Me.grpBrand.Controls.Add(Me.lblCategory)
        Me.grpBrand.Controls.Add(Me.Label3)
        Me.grpBrand.Controls.Add(Me.Label2)
        Me.grpBrand.Controls.Add(Me.txtBrand)
        Me.grpBrand.Location = New System.Drawing.Point(6, 0)
        Me.grpBrand.Name = "grpBrand"
        Me.grpBrand.Size = New System.Drawing.Size(284, 76)
        Me.grpBrand.TabIndex = 0
        Me.grpBrand.TabStop = False
        Me.grpBrand.Visible = False
        '
        'lblCategory
        '
        Me.lblCategory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategory.Location = New System.Drawing.Point(100, 18)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(177, 23)
        Me.lblCategory.TabIndex = 3
        Me.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Category Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "New Brand:"
        '
        'txtBrand
        '
        Me.txtBrand.Location = New System.Drawing.Point(100, 49)
        Me.txtBrand.Name = "txtBrand"
        Me.txtBrand.Size = New System.Drawing.Size(177, 20)
        Me.txtBrand.TabIndex = 0
        '
        'grpCategory
        '
        Me.grpCategory.Controls.Add(Me.txtCategory)
        Me.grpCategory.Controls.Add(Me.Label1)
        Me.grpCategory.Location = New System.Drawing.Point(6, 79)
        Me.grpCategory.Name = "grpCategory"
        Me.grpCategory.Size = New System.Drawing.Size(284, 49)
        Me.grpCategory.TabIndex = 1
        Me.grpCategory.TabStop = False
        Me.grpCategory.Visible = False
        '
        'txtCategory
        '
        Me.txtCategory.Location = New System.Drawing.Point(100, 18)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(177, 20)
        Me.txtCategory.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "New Category:"
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(187, 134)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 2
        Me.cmdClose.Text = "C&lose"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(99, 134)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 3
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'timerNewCategory
        '
        Me.timerNewCategory.Interval = 2000
        '
        'frmNewCategoryBrand
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 166)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.grpCategory)
        Me.Controls.Add(Me.grpBrand)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNewCategoryBrand"
        Me.grpBrand.ResumeLayout(False)
        Me.grpBrand.PerformLayout()
        Me.grpCategory.ResumeLayout(False)
        Me.grpCategory.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpBrand As GroupBox
    Friend WithEvents grpCategory As GroupBox
    Friend WithEvents lblCategory As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBrand As TextBox
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdClose As Button
    Friend WithEvents cmdSave As Button
    Friend WithEvents tltpNewCategoryBRand As ToolTip
    Friend WithEvents timerNewCategory As Timer
End Class
