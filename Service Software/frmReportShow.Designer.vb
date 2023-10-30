<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportShow
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
        Me.crvReportShow = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        ' Me.crvReportShow = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'crvReportShow
        '
        Me.crvReportShow.ActiveViewIndex = -1
        Me.crvReportShow.AutoSize = True
        Me.crvReportShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvReportShow.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvReportShow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvReportShow.Location = New System.Drawing.Point(0, 0)
        Me.crvReportShow.Name = "crvReportShow"
        Me.crvReportShow.Size = New System.Drawing.Size(691, 262)
        Me.crvReportShow.TabIndex = 0
        Me.crvReportShow.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'crvReportShow
        '
        Me.crvReportShow.ActiveViewIndex = -1
        Me.crvReportShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvReportShow.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvReportShow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvReportShow.Location = New System.Drawing.Point(0, 0)
        Me.crvReportShow.Name = "crvReportShow"
        Me.crvReportShow.Size = New System.Drawing.Size(1036, 403)
        Me.crvReportShow.TabIndex = 0
        '
        'frmReportShow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1036, 403)
        Me.Controls.Add(Me.crvReportShow)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmReportShow"
        Me.Text = "Bill Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents crvReportShow As CrystalDecisions.Windows.Forms.CrystalReportViewer
    'Friend WithEvents crvReportShow As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
