<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCategory
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
        Me.trCategory = New System.Windows.Forms.TreeView()
        Me.cntxmsCategoryBrand = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmNewCategory = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmEditCategory = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmNewBrand = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmEditBrand = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstModel = New System.Windows.Forms.ListView()
        Me.colModelSL = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colModelModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.comModelCharge = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colModelWarrantyPeriod = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colModelItem = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colModelItemSl = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSize = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colModelCreatedDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cntxmnuModel = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuNewModel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditModel = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.txtSearchModel = New System.Windows.Forms.TextBox()
        Me.lblSearchModel = New System.Windows.Forms.Label()
        Me.txtFindingModel = New System.Windows.Forms.TextBox()
        Me.cntxmsCategoryBrand.SuspendLayout()
        Me.cntxmnuModel.SuspendLayout()
        Me.SuspendLayout()
        '
        'trCategory
        '
        Me.trCategory.ContextMenuStrip = Me.cntxmsCategoryBrand
        Me.trCategory.Location = New System.Drawing.Point(12, 12)
        Me.trCategory.Name = "trCategory"
        Me.trCategory.Size = New System.Drawing.Size(353, 454)
        Me.trCategory.TabIndex = 0
        '
        'cntxmsCategoryBrand
        '
        Me.cntxmsCategoryBrand.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmNewCategory, Me.tsmEditCategory, Me.tsmNewBrand, Me.tsmEditBrand})
        Me.cntxmsCategoryBrand.Name = "cntxmsCategoryBrand"
        Me.cntxmsCategoryBrand.Size = New System.Drawing.Size(153, 114)
        '
        'tsmNewCategory
        '
        Me.tsmNewCategory.Name = "tsmNewCategory"
        Me.tsmNewCategory.Size = New System.Drawing.Size(152, 22)
        Me.tsmNewCategory.Text = "&New Category"
        '
        'tsmEditCategory
        '
        Me.tsmEditCategory.Name = "tsmEditCategory"
        Me.tsmEditCategory.Size = New System.Drawing.Size(152, 22)
        Me.tsmEditCategory.Text = "&Edit Category"
        '
        'tsmNewBrand
        '
        Me.tsmNewBrand.Name = "tsmNewBrand"
        Me.tsmNewBrand.Size = New System.Drawing.Size(152, 22)
        Me.tsmNewBrand.Text = "&New Brand"
        '
        'tsmEditBrand
        '
        Me.tsmEditBrand.Name = "tsmEditBrand"
        Me.tsmEditBrand.Size = New System.Drawing.Size(152, 22)
        Me.tsmEditBrand.Text = "&Edit Brand"
        '
        'lstModel
        '
        Me.lstModel.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colModelSL, Me.colModelModel, Me.comModelCharge, Me.colModelWarrantyPeriod, Me.colModelItem, Me.colModelItemSl, Me.colSize, Me.colModelCreatedDate, Me.ColumnHeader1})
        Me.lstModel.ContextMenuStrip = Me.cntxmnuModel
        Me.lstModel.FullRowSelect = True
        Me.lstModel.Location = New System.Drawing.Point(383, 12)
        Me.lstModel.Name = "lstModel"
        Me.lstModel.Size = New System.Drawing.Size(470, 291)
        Me.lstModel.TabIndex = 1
        Me.lstModel.UseCompatibleStateImageBehavior = False
        Me.lstModel.View = System.Windows.Forms.View.Details
        '
        'colModelSL
        '
        Me.colModelSL.Text = "SL"
        '
        'colModelModel
        '
        Me.colModelModel.Text = "Model"
        Me.colModelModel.Width = 120
        '
        'comModelCharge
        '
        Me.comModelCharge.Text = "Charge"
        Me.comModelCharge.Width = 80
        '
        'colModelWarrantyPeriod
        '
        Me.colModelWarrantyPeriod.Text = "W.Period"
        Me.colModelWarrantyPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'colModelItem
        '
        Me.colModelItem.Text = "Item"
        Me.colModelItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colModelItem.Width = 120
        '
        'colModelItemSl
        '
        Me.colModelItemSl.Text = "Item SL#"
        Me.colModelItemSl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'colSize
        '
        Me.colSize.Text = "Size"
        '
        'colModelCreatedDate
        '
        Me.colModelCreatedDate.Text = "Created Date"
        Me.colModelCreatedDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.colModelCreatedDate.Width = 120
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Remarks"
        Me.ColumnHeader1.Width = 100
        '
        'cntxmnuModel
        '
        Me.cntxmnuModel.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNewModel, Me.mnuEditModel})
        Me.cntxmnuModel.Name = "ContextMenuStrip1"
        Me.cntxmnuModel.Size = New System.Drawing.Size(136, 48)
        '
        'mnuNewModel
        '
        Me.mnuNewModel.Name = "mnuNewModel"
        Me.mnuNewModel.Size = New System.Drawing.Size(135, 22)
        Me.mnuNewModel.Text = "New &Model"
        '
        'mnuEditModel
        '
        Me.mnuEditModel.Name = "mnuEditModel"
        Me.mnuEditModel.Size = New System.Drawing.Size(135, 22)
        Me.mnuEditModel.Text = "&Edit Model"
        '
        'cmdSearch
        '
        Me.cmdSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdSearch.Location = New System.Drawing.Point(467, 434)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(75, 23)
        Me.cmdSearch.TabIndex = 2
        Me.cmdSearch.Text = "&Search"
        Me.cmdSearch.UseVisualStyleBackColor = False
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdClose.Location = New System.Drawing.Point(651, 434)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 5
        Me.cmdClose.Text = "C&lose"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'txtSearchModel
        '
        Me.txtSearchModel.Location = New System.Drawing.Point(447, 527)
        Me.txtSearchModel.Name = "txtSearchModel"
        Me.txtSearchModel.Size = New System.Drawing.Size(188, 20)
        Me.txtSearchModel.TabIndex = 6
        '
        'lblSearchModel
        '
        Me.lblSearchModel.AutoSize = True
        Me.lblSearchModel.Location = New System.Drawing.Point(380, 531)
        Me.lblSearchModel.Name = "lblSearchModel"
        Me.lblSearchModel.Size = New System.Drawing.Size(73, 13)
        Me.lblSearchModel.TabIndex = 7
        Me.lblSearchModel.Text = "Search Model"
        '
        'txtFindingModel
        '
        Me.txtFindingModel.Location = New System.Drawing.Point(335, 271)
        Me.txtFindingModel.Multiline = True
        Me.txtFindingModel.Name = "txtFindingModel"
        Me.txtFindingModel.Size = New System.Drawing.Size(391, 20)
        Me.txtFindingModel.TabIndex = 8
        '
        'frmCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(859, 562)
        Me.Controls.Add(Me.txtFindingModel)
        Me.Controls.Add(Me.lblSearchModel)
        Me.Controls.Add(Me.txtSearchModel)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.lstModel)
        Me.Controls.Add(Me.trCategory)
        Me.Name = "frmCategory"
        Me.Text = "frmCategory"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.cntxmsCategoryBrand.ResumeLayout(False)
        Me.cntxmnuModel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents trCategory As TreeView
    Friend WithEvents lstModel As ListView
    Friend WithEvents colModelSL As ColumnHeader
    Friend WithEvents colModelModel As ColumnHeader
    Friend WithEvents comModelCharge As ColumnHeader
    Friend WithEvents colModelWarrantyPeriod As ColumnHeader
    Friend WithEvents colModelItem As ColumnHeader
    Friend WithEvents colModelItemSl As ColumnHeader
    Friend WithEvents cmdSearch As Button
    Friend WithEvents cmdClose As Button
    Friend WithEvents cntxmsCategoryBrand As ContextMenuStrip
    Friend WithEvents colModelCreatedDate As ColumnHeader
    Friend WithEvents tsmNewCategory As ToolStripMenuItem
    Friend WithEvents tsmEditCategory As ToolStripMenuItem
    Friend WithEvents tsmNewBrand As ToolStripMenuItem
    Friend WithEvents tsmEditBrand As ToolStripMenuItem
    Friend WithEvents txtSearchModel As TextBox
    Friend WithEvents lblSearchModel As Label
    Friend WithEvents txtFindingModel As TextBox
    Friend WithEvents colSize As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents cntxmnuModel As ContextMenuStrip
    Friend WithEvents mnuNewModel As ToolStripMenuItem
    Friend WithEvents mnuEditModel As ToolStripMenuItem
End Class
