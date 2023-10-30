Public Class frmNewCategoryBrand



    Public IntCategoryBrandFlag As Integer = 0
    Public strTempCategory As String = String.Empty
    Dim frmTempCategory As New frmCategory
    Public Status As String


    Private Sub frmNewCategoryBrand_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        IntCategoryBrandFlag = 0
        strTempCategory = String.Empty

    End Sub

    Private Sub frmNewCategoryBrand_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IntCategoryBrandFlag = 1 Then
            grpCategory.Visible = True
            grpCategory.Top = 1
            Me.Height = 120
            Me.Width = 315
            Me.Text = "New Category"
            'Me.Height = 204
            'Me.Width = 315
            txtCategory.Select()

        ElseIf IntCategoryBrandFlag = 2 Or IntCategoryBrandFlag = 4 Then

            grpBrand.Visible = True
            grpBrand.Top = 1
            Me.Height = 150
            Me.Width = 315
            Me.Text = "New Brand"
            lblCategory.Text = strTempCategory
            txtBrand.Select()
        End If


        If IntCategoryBrandFlag = 1 Then
            Me.Text = "New Category"
        ElseIf IntCategoryBrandFlag = 2 Or IntCategoryBrandFlag = 4 Then
            Me.Text = "New Brand"
        End If


        cmdClose.Top = Me.ClientSize.Height - (cmdClose.Height + 2)
        cmdSave.Top = cmdClose.Top

        Me.Left = 150
        Me.Top = 250

    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Status = "Cancel"

        Me.Hide()

    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim cm As clscTypeMethods = New clscTypeMethods
        Dim bm As clsBrandMethods = New clsBrandMethods
        Dim catagory As clscType = New clscType
        Dim brand As clsBrand = New clsBrand





        If IntCategoryBrandFlag = 1 Then
            If txtCategory.Text.Length > 0 Then
                catagory.CategoryName = txtCategory.Text
            Else
                MessageBox.Show("Category Field is blank ")
                txtCategory.Select()
                Exit Sub
            End If
            cm.Save(catagory)
            '    InsertNewRecord(strProvider, "Ctype", "Ctype", "'" & UCase(txtCategory.Text) & "'")
            MessageBox.Show("Category: " & txtBrand.Text & " Created Successfully")
            ClearFiled()


        ElseIf IntCategoryBrandFlag = 2 Then

            If txtBrand.Text.Length > 0 Then
                brand.CategoryName = lblCategory.Text
                brand.Brand = txtBrand.Text

            Else
                MessageBox.Show("Brand Field is blank ")
                txtBrand.Select()
                Exit Sub

            End If
            bm.Save(brand)
            ' InsertNewRecord(strProvider, "Brand", "Ctype,Brand", "'" & UCase(lblCategory.Text) & "','" & UCase(txtBrand.Text) & "'")
            MessageBox.Show("Brand: " & txtBrand.Text & " Created Successfully")
            ClearFiled()


        End If

        Status = "Insert"
        Me.Hide()


    End Sub

    Private Sub ClearFiled()

        txtBrand.Text = String.Empty
        txtCategory.Text = String.Empty

    End Sub

    Private Sub txtCategory_TextChanged(sender As Object, e As EventArgs) Handles txtCategory.TextChanged

    End Sub

    Private Sub txtCategory_Leave(sender As Object, e As EventArgs) Handles txtCategory.Leave
        txtCategory.Text = UCase(txtCategory.Text)
    End Sub

    Private Sub txtBrand_TextChanged(sender As Object, e As EventArgs) Handles txtBrand.TextChanged

    End Sub

    Private Sub txtBrand_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBrand.KeyPress
        If CheckCharacterSymbol(e.KeyChar, False) = True Then
            tltpNewCategoryBRand.Tag = UCase("Brand")
            e.Handled = True

            tltpNewCategoryBRand.Show("You Cannot Type <>,./?';:[{]}\|=+_-()*&^%$#@!~`", txtBrand)

        Else
            tltpNewCategoryBRand.Hide(txtBrand)

        End If
    End Sub

    Private Sub txtCategory_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCategory.KeyPress
        If CheckCharacterSymbol(e.KeyChar, False) = True Then
            e.Handled = True
            tltpNewCategoryBRand.Tag = UCase("Category")
            tltpNewCategoryBRand.Show("You Cannot Type <>,./?';:[{]}\|=+_-()*&^%$#@!~`", txtBrand)

        Else
            tltpNewCategoryBRand.Hide(txtBrand)
        End If
    End Sub

    Private Sub timerNewCategory_Tick(sender As Object, e As EventArgs) Handles timerNewCategory.Tick
        If tltpNewCategoryBRand.Tag = UCase("Brand") Then
            tltpNewCategoryBRand.Hide(txtBrand)
        ElseIf tltpNewCategoryBRand.Tag = UCase("Category") Then
            tltpNewCategoryBRand.Hide(txtCategory)
        End If
        timerNewCategory.Enabled = False

    End Sub
End Class