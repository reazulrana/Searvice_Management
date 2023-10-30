<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVAT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVAT))
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtServicecharge = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.picClose = New System.Windows.Forms.PictureBox()
        Me.txtParts = New System.Windows.Forms.TextBox()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.cntxMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMakeDefault = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstVatList = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chkMakeDefault = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        Me.cntxMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCreate
        '
        Me.btnCreate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.btnCreate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.ForeColor = System.Drawing.Color.Red
        Me.btnCreate.Location = New System.Drawing.Point(13, 277)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(159, 23)
        Me.btnCreate.TabIndex = 0
        Me.btnCreate.Text = "&Save"
        Me.btnCreate.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Red
        Me.btnClose.Location = New System.Drawing.Point(197, 277)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(159, 23)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "C&lose"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(13, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Service Charge"
        '
        'txtServicecharge
        '
        Me.txtServicecharge.Location = New System.Drawing.Point(99, 45)
        Me.txtServicecharge.Name = "txtServicecharge"
        Me.txtServicecharge.Size = New System.Drawing.Size(110, 20)
        Me.txtServicecharge.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.txtServicecharge, "Type Amount")
        '
        'picClose
        '
        Me.picClose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.picClose.Image = CType(resources.GetObject("picClose.Image"), System.Drawing.Image)
        Me.picClose.Location = New System.Drawing.Point(338, 3)
        Me.picClose.Name = "picClose"
        Me.picClose.Size = New System.Drawing.Size(24, 23)
        Me.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picClose.TabIndex = 0
        Me.picClose.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picClose, "Close")
        '
        'txtParts
        '
        Me.txtParts.Location = New System.Drawing.Point(251, 45)
        Me.txtParts.Name = "txtParts"
        Me.txtParts.Size = New System.Drawing.Size(110, 20)
        Me.txtParts.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.txtParts, "Type Amount")
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.Label2)
        Me.pnlHeader.Controls.Add(Me.picClose)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(368, 29)
        Me.pnlHeader.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(6, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Create VAT "
        '
        'pnlBottom
        '
        Me.pnlBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(0, 304)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(368, 10)
        Me.pnlBottom.TabIndex = 6
        '
        'cntxMenu
        '
        Me.cntxMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDelete, Me.mnuMakeDefault})
        Me.cntxMenu.Name = "cntxMenu"
        Me.cntxMenu.Size = New System.Drawing.Size(153, 70)
        '
        'mnuDelete
        '
        Me.mnuDelete.Name = "mnuDelete"
        Me.mnuDelete.Size = New System.Drawing.Size(152, 22)
        Me.mnuDelete.Text = "&Delete"
        '
        'mnuMakeDefault
        '
        Me.mnuMakeDefault.Name = "mnuMakeDefault"
        Me.mnuMakeDefault.Size = New System.Drawing.Size(152, 22)
        Me.mnuMakeDefault.Text = "&Make Default"
        '
        'lstVatList
        '
        Me.lstVatList.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.lstVatList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lstVatList.ContextMenuStrip = Me.cntxMenu
        Me.lstVatList.ForeColor = System.Drawing.Color.White
        Me.lstVatList.FullRowSelect = True
        Me.lstVatList.GridLines = True
        Me.lstVatList.Location = New System.Drawing.Point(13, 90)
        Me.lstVatList.Name = "lstVatList"
        Me.lstVatList.Size = New System.Drawing.Size(348, 185)
        Me.lstVatList.TabIndex = 9
        Me.lstVatList.UseCompatibleStateImageBehavior = False
        Me.lstVatList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "SL NO"
        Me.ColumnHeader1.Width = 46
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Service Charge"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 94
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Parts"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 93
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "IsSelected"
        Me.ColumnHeader4.Width = 109
        '
        'chkMakeDefault
        '
        Me.chkMakeDefault.AutoSize = True
        Me.chkMakeDefault.ForeColor = System.Drawing.Color.Red
        Me.chkMakeDefault.Location = New System.Drawing.Point(99, 71)
        Me.chkMakeDefault.Name = "chkMakeDefault"
        Me.chkMakeDefault.Size = New System.Drawing.Size(90, 17)
        Me.chkMakeDefault.TabIndex = 10
        Me.chkMakeDefault.Text = "Make Default"
        Me.chkMakeDefault.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(214, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Parts"
        '
        'frmVAT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(368, 314)
        Me.Controls.Add(Me.txtParts)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.chkMakeDefault)
        Me.Controls.Add(Me.lstVatList)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.txtServicecharge)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCreate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmVAT"
        Me.Text = "Vat Information"
        CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.cntxMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCreate As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtServicecharge As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents pnlBottom As Panel
    Friend WithEvents picClose As PictureBox
    Friend WithEvents cntxMenu As ContextMenuStrip
    Friend WithEvents lstVatList As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents chkMakeDefault As CheckBox
    Friend WithEvents mnuDelete As ToolStripMenuItem
    Friend WithEvents mnuMakeDefault As ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents txtParts As TextBox
    Friend WithEvents Label3 As Label
End Class
