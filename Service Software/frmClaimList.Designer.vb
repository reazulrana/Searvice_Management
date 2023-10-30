<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClaimList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClaimList))
        Me.lstClaimList = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cntxMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.picClose = New System.Windows.Forms.PictureBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFault = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkEnable = New System.Windows.Forms.CheckBox()
        Me.cntxMenu.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstClaimList
        '
        Me.lstClaimList.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lstClaimList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lstClaimList.ContextMenuStrip = Me.cntxMenu
        Me.lstClaimList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lstClaimList.FullRowSelect = True
        Me.lstClaimList.GridLines = True
        Me.lstClaimList.Location = New System.Drawing.Point(12, 134)
        Me.lstClaimList.Name = "lstClaimList"
        Me.lstClaimList.Size = New System.Drawing.Size(363, 249)
        Me.lstClaimList.TabIndex = 0
        Me.lstClaimList.UseCompatibleStateImageBehavior = False
        Me.lstClaimList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "SL"
        Me.ColumnHeader1.Width = 38
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Category"
        Me.ColumnHeader2.Width = 104
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Fault Name"
        Me.ColumnHeader3.Width = 212
        '
        'cntxMenu
        '
        Me.cntxMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNew, Me.mnuEdit, Me.mnuDelete})
        Me.cntxMenu.Name = "cntxMenu"
        Me.cntxMenu.Size = New System.Drawing.Size(153, 92)
        '
        'mnuNew
        '
        Me.mnuNew.Name = "mnuNew"
        Me.mnuNew.Size = New System.Drawing.Size(152, 22)
        Me.mnuNew.Text = "&New"
        '
        'mnuEdit
        '
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(152, 22)
        Me.mnuEdit.Text = "&Edit"
        '
        'mnuDelete
        '
        Me.mnuDelete.Name = "mnuDelete"
        Me.mnuDelete.Size = New System.Drawing.Size(152, 22)
        Me.mnuDelete.Text = "&Delete"
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.picClose)
        Me.pnlHeader.Controls.Add(Me.lblHeader)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(387, 39)
        Me.pnlHeader.TabIndex = 1
        '
        'picClose
        '
        Me.picClose.Image = CType(resources.GetObject("picClose.Image"), System.Drawing.Image)
        Me.picClose.Location = New System.Drawing.Point(349, 8)
        Me.picClose.Name = "picClose"
        Me.picClose.Size = New System.Drawing.Size(26, 23)
        Me.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picClose.TabIndex = 10
        Me.picClose.TabStop = False
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.White
        Me.lblHeader.Location = New System.Drawing.Point(10, 5)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(119, 31)
        Me.lblHeader.TabIndex = 9
        Me.lblHeader.Text = "Fault List"
        '
        'pnlBottom
        '
        Me.pnlBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(0, 389)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(387, 10)
        Me.pnlBottom.TabIndex = 2
        '
        'btnSave
        '
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.Location = New System.Drawing.Point(13, 105)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(177, 23)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(198, 105)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(177, 23)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'cmbCategory
        '
        Me.cmbCategory.Enabled = False
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(106, 53)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(253, 21)
        Me.cmbCategory.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Choose Category"
        '
        'txtFault
        '
        Me.txtFault.Location = New System.Drawing.Point(106, 80)
        Me.txtFault.Name = "txtFault"
        Me.txtFault.Size = New System.Drawing.Size(253, 20)
        Me.txtFault.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Fault"
        '
        'chkEnable
        '
        Me.chkEnable.AutoSize = True
        Me.chkEnable.Location = New System.Drawing.Point(362, 55)
        Me.chkEnable.Name = "chkEnable"
        Me.chkEnable.Size = New System.Drawing.Size(15, 14)
        Me.chkEnable.TabIndex = 9
        Me.chkEnable.UseVisualStyleBackColor = True
        '
        'frmClaimList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(387, 399)
        Me.Controls.Add(Me.chkEnable)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFault)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.lstClaimList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmClaimList"
        Me.Text = "frmClaimList"
        Me.cntxMenu.ResumeLayout(False)
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstClaimList As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents pnlBottom As Panel
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFault As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents picClose As PictureBox
    Friend WithEvents lblHeader As Label
    Friend WithEvents chkEnable As CheckBox
    Friend WithEvents cntxMenu As ContextMenuStrip
    Friend WithEvents mnuNew As ToolStripMenuItem
    Friend WithEvents mnuEdit As ToolStripMenuItem
    Friend WithEvents mnuDelete As ToolStripMenuItem
End Class
