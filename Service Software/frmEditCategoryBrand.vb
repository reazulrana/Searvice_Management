Public Class frmEditCategoryBrand
    Public strPreviousCategory As String = String.Empty
    Public strPreviousBrand As String = String.Empty
    Public intCategoryBrandFlag As Integer = 0
    Public strTempCategory As String = String.Empty
    Dim frmTempCategory As New frmCategory
    Public strChangeStatusFlag As String = String.Empty





    Private Sub frmEditCategoryBrand_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If intCategoryBrandFlag = 2 Then
            Me.Height = 120
            Me.Width = 330
            Me.Text = "Update Category"
            grpCategory.Visible = True
            grpCategory.Left = 2
            grpCategory.Top = 2
            txtUpdateCategory.Select()

        ElseIf intCategoryBrandFlag = 4 Then
            Me.Height = 150
            Me.Width = 330
            Me.Text = "Update Brand"
            grpBrand.Visible = True
            grpBrand.Left = 2
            grpBrand.Top = 2
            lblCategory.Text = strTempCategory
            txtUpdateBrand.Select()

        End If

        If intCategoryBrandFlag = 2 Then
            Me.Text = "Edit Category : (Replaced Category : " & strPreviousCategory & ")"
        ElseIf intCategoryBrandFlag = 4 Then
            Me.Text = "Edit Brand : (Replaced Brand : " & strPreviousBrand & ")"
        End If



        cmdUpdate.Top = Me.ClientSize.Height - cmdUpdate.Height - 2
        cmdClose.Top = cmdUpdate.Top
        cmdUpdate.Width = grpCategory.Width / 2
        cmdClose.Width = grpCategory.Width / 2
        cmdUpdate.Left = 2
        cmdClose.Left = cmdUpdate.Left + cmdUpdate.Width
        Me.Left = 150
        Me.Top = 250




    End Sub

    Private Sub frmEditCategoryBrand_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        strPreviousCategory = String.Empty
        strPreviousBrand = String.Empty
        intCategoryBrandFlag = 0
        strTempCategory = String.Empty
        strChangeStatusFlag = String.Empty

    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click

        Me.Hide()


    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        If intCategoryBrandFlag = 2 Then
            UpdateRecords("cType", "'" & UCase(txtUpdateCategory.Text) & "'", "cType", "cType.cType='" & strPreviousCategory & "'")
            UpdateRecords("cType", "'" & UCase(txtUpdateCategory.Text) & "'", "Brand", "Brand.cType='" & strPreviousCategory & "'")
            MessageBox.Show("Category: " & txtUpdateCategory.Text & " Upated Successfully (Previous Category:" & strPreviousCategory)
        ElseIf intCategoryBrandFlag = 4 Then
            UpdateRecords("Brand", "'" & UCase(txtUpdateBrand.Text) & "'", "Brand", "Brand.Brand='" & strPreviousBrand & "' and Brand.cType='" & strTempCategory & "'")
            MessageBox.Show("Brand: " & txtUpdateBrand.Text & " Upated Successfully (Previous Brand:" & strPreviousBrand)
        End If
        strChangeStatusFlag = "C"
        cmdClose_Click(sender, e)
    End Sub

    Private Sub txtUpdateBrand_TextChanged(sender As Object, e As EventArgs) Handles txtUpdateBrand.TextChanged

    End Sub

    Private Sub txtUpdateBrand_Leave(sender As Object, e As EventArgs) Handles txtUpdateBrand.Leave
        txtUpdateBrand.Text = UCase(txtUpdateBrand.Text)
    End Sub

    Private Sub txtUpdateCategory_TextChanged(sender As Object, e As EventArgs) Handles txtUpdateCategory.TextChanged

    End Sub

    Private Sub txtUpdateCategory_Leave(sender As Object, e As EventArgs) Handles txtUpdateCategory.Leave
        txtUpdateCategory.Text = UCase(txtUpdateCategory.Text)
    End Sub

    Private Sub txtUpdateBrand_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUpdateBrand.KeyPress
        If CheckCharacterSymbol(e.KeyChar, False) = True Then
            e.Handled = True
            tlBrand.Show("You Cannot Type <>,./?';:[{]}\|=+_-()*&^%$#@!~`", txtUpdateBrand)

        Else
            tlBrand.Hide(txtUpdateBrand)

        End If

    End Sub

    Private Sub tlBrand_Popup(sender As Object, e As PopupEventArgs) Handles tlBrand.Popup

    End Sub

    Private Sub txtUpdateCategory_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUpdateCategory.KeyPress
        If CheckCharacterSymbol(e.KeyChar, False) = True Then
            e.Handled = True
            tlBrand.Show("You Cannot Type <>,./?';:[{]}\|=+_-()*&^%$#@!~`", txtUpdateCategory)

        Else
            tlBrand.Hide(txtUpdateCategory)

        End If
    End Sub
End Class