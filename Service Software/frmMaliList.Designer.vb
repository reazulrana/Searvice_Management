<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaliList
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
        Me.lstMailList = New System.Windows.Forms.ListView()
        Me.ColSL = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMail = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.conAuditList = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ConAddAuditList = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConRemoveAuditList = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConDeleteMail = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMailno = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.conAuditList.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstMailList
        '
        Me.lstMailList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColSL, Me.colMail})
        Me.lstMailList.ContextMenuStrip = Me.conAuditList
        Me.lstMailList.FullRowSelect = True
        Me.lstMailList.Location = New System.Drawing.Point(7, 60)
        Me.lstMailList.Name = "lstMailList"
        Me.lstMailList.Size = New System.Drawing.Size(324, 248)
        Me.lstMailList.TabIndex = 0
        Me.lstMailList.UseCompatibleStateImageBehavior = False
        Me.lstMailList.View = System.Windows.Forms.View.Details
        '
        'ColSL
        '
        Me.ColSL.Text = "SL"
        Me.ColSL.Width = 50
        '
        'colMail
        '
        Me.colMail.Text = "Mail No"
        Me.colMail.Width = 247
        '
        'conAuditList
        '
        Me.conAuditList.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConAddAuditList, Me.ConRemoveAuditList, Me.ConDeleteMail})
        Me.conAuditList.Name = "conAuditList"
        Me.conAuditList.Size = New System.Drawing.Size(171, 70)
        '
        'ConAddAuditList
        '
        Me.ConAddAuditList.Name = "ConAddAuditList"
        Me.ConAddAuditList.Size = New System.Drawing.Size(170, 22)
        Me.ConAddAuditList.Text = "&Add Audit List"
        '
        'ConRemoveAuditList
        '
        Me.ConRemoveAuditList.Name = "ConRemoveAuditList"
        Me.ConRemoveAuditList.Size = New System.Drawing.Size(170, 22)
        Me.ConRemoveAuditList.Text = "&Remove Audit List"
        '
        'ConDeleteMail
        '
        Me.ConDeleteMail.Name = "ConDeleteMail"
        Me.ConDeleteMail.Size = New System.Drawing.Size(170, 22)
        Me.ConDeleteMail.Text = "&Delete Mail"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "New Mail"
        '
        'txtMailno
        '
        Me.txtMailno.Location = New System.Drawing.Point(7, 34)
        Me.txtMailno.Name = "txtMailno"
        Me.txtMailno.Size = New System.Drawing.Size(324, 20)
        Me.txtMailno.TabIndex = 3
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(7, 311)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(155, 23)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(176, 311)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(155, 23)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "C&lose"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmMaliList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(339, 341)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtMailno)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstMailList)
        Me.Name = "frmMaliList"
        Me.Text = "Mail List"
        Me.conAuditList.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstMailList As ListView
    Friend WithEvents ColSL As ColumnHeader
    Friend WithEvents colMail As ColumnHeader
    Friend WithEvents conAuditList As ContextMenuStrip
    Friend WithEvents ConAddAuditList As ToolStripMenuItem
    Friend WithEvents ConRemoveAuditList As ToolStripMenuItem
    Friend WithEvents ConDeleteMail As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMailno As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClose As Button
End Class
