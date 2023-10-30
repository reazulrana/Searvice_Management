Public Class frmNewProduct
    Private Sub chkEdit_CheckedChanged(sender As Object, e As EventArgs) Handles chkEdit.CheckedChanged
        endbleControl()
    End Sub


    Dim strUpdate As Boolean ' Use for Add and Uppdate 
    Dim strSearchType As String = String.Empty
    Dim strPreviousCode As String = String.Empty
    Dim intIndex As Integer

    Private Sub endbleControl()

        If chkEdit.Checked = True Then
            txtSearchCode.Enabled = True
            txtSearchProduct.Enabled = True
            btnAdd.Text = "&Update"
            txtSearchCode.Select()
            strUpdate = True
        Else
            txtSearchCode.Enabled = False
            txtSearchCode.Text = ""
            txtSearchProduct.Enabled = False
            txtSearchProduct.Text = ""
            btnAdd.Text = "&Add"
            strUpdate = False
        End If


    End Sub

    Private Sub frmNewProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try



            CenterForm(Me)
            LoadProduct()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Me.Close()

        End Try
    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Me.Close()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub lstProductList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstProductList.SelectedIndexChanged
        If strUpdate = True Then
            If lstProductList.Items.Count > 0 Then
                Dim lstItem As ListViewItem = New ListViewItem
                lstItem = lstProductList.FocusedItem
                txtPartno.Text = lstItem.SubItems(1).Text
                txtProductName.Text = lstItem.SubItems(2).Text
                cmbModel.Text = lstItem.SubItems(3).Text
                txtUnitPrice.Text = lstItem.SubItems(4).Text
                cmbSource.Text = lstItem.SubItems(5).Text
                strPreviousCode = lstItem.SubItems(1).Text
                intIndex = lstItem.Index
            End If


        End If
    End Sub


    Private Sub LoadProduct()

        Dim PListMethods As clsProductMethods = New clsProductMethods
        Dim lstItem As ListViewItem = New ListViewItem


        lstProductList.Items.Clear()




        Dim pList As List(Of clsProduct) = PListMethods.GetProductList().ToList




        If pList.Count > 0 Then

            For Each p As clsProduct In pList

                lstItem = lstProductList.Items.Add(lstProductList.Items.Count + 1)
                lstItem.SubItems.Add(p.Code)
                lstItem.SubItems.Add(p.ProdName)
                lstItem.SubItems.Add(p.Model)
                lstItem.SubItems.Add(p.UnitPrice)
                lstItem.SubItems.Add(p.Country)


            Next


        End If


        cmbModel.DisplayMember = "Model"
        cmbModel.ValueMember = "Model"
        cmbModel.DataSource = PListMethods.LoadProductModel


        cmbSource.DisplayMember = "Country"
        cmbSource.ValueMember = "Country"
        cmbSource.DataSource = PListMethods.LoadProductSource







    End Sub

    Private Sub btnSearchProduct_Click(sender As Object, e As EventArgs) Handles btnSearchProduct.Click
        Try

            If lstProductList.Items.Count = 0 Then
            MessageBox.Show("No Product is in List")
            Exit Sub
        End If

        Dim blnMessage As String = String.Empty
        blnMessage = "Record Not Found in the  Product List"





        If strSearchType.ToLower = LCase("Code") Then

            If String.IsNullOrEmpty(txtSearchCode.Text) Then
                MessageBox.Show("Search Code Is Blank")
                txtSearchCode.Select()
                Exit Sub
            End If


            Dim lst As ListViewItem = New ListViewItem
            For Each i As ListViewItem In lstProductList.Items

                If i.SubItems(1).Text.ToUpper = txtSearchCode.Text.ToUpper Then
                    lstProductList.Select()
                    i.Selected = True
                    i.Focused() = True

                    i.EnsureVisible()


                    i = lstProductList.FocusedItem
                    txtPartno.Text = i.SubItems(1).Text
                    txtProductName.Text = i.SubItems(2).Text
                    cmbModel.Text = i.SubItems(3).Text
                    txtUnitPrice.Text = i.SubItems(4).Text
                    cmbSource.Text = i.SubItems(5).Text
                    blnMessage = "Record is Found"

                End If

            Next

        ElseIf strSearchType.ToLower = LCase("Product") Then

            If String.IsNullOrEmpty(txtSearchProduct.Text) Then
                MessageBox.Show("Search Product Is Blank")
                txtSearchProduct.Select()
                Exit Sub


            End If


            Dim lst As ListViewItem = New ListViewItem

            For Each i As ListViewItem In lstProductList.Items

                If i.SubItems(2).Text.ToUpper = txtSearchProduct.Text.ToUpper Then
                    lstProductList.Select()
                    i.Selected = True
                    i.Focused() = True

                    i.EnsureVisible()


                    i = lstProductList.FocusedItem
                    txtPartno.Text = i.SubItems(1).Text
                    txtProductName.Text = i.SubItems(2).Text
                    cmbModel.Text = i.SubItems(3).Text
                    txtUnitPrice.Text = i.SubItems(4).Text
                    cmbSource.Text = i.SubItems(5).Text
                    blnMessage = "Record is Found"
                End If

            Next

        End If


            lblBottom.Text = blnMessage



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub txtSearchCode_TextChanged(sender As Object, e As EventArgs) Handles txtSearchCode.TextChanged

    End Sub

    Private Sub txtSearchCode_GotFocus(sender As Object, e As EventArgs) Handles txtSearchCode.GotFocus
        strSearchType = "Code"
    End Sub

    Private Sub txtSearchProduct_TextChanged(sender As Object, e As EventArgs) Handles txtSearchProduct.TextChanged
        strSearchType = "Product"
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim deleteMethods As clsProductMethods = New clsProductMethods

        Try


            If lstProductList.Items.Count <= 0 Then
            MessageBox.Show("No Item Seleted to Delete")
            Exit Sub
        End If
        lblBottom.Text = ""


            If lstProductList.SelectedItems(intIndex).Selected = True Then

                Dim lst As ListViewItem = New ListViewItem
                lst = lstProductList.FocusedItem
                deleteMethods.Delete(lst.SubItems(1).Text)
                lstProductList.Items(intIndex).Remove()
                MessageBox.Show("Product Deleted Successfully", "Successfull")
            Else
                MessageBox.Show("Select Product")
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try

            If String.IsNullOrEmpty(txtPartno.Text) Then
            MessageBox.Show("Prodcut Code is Blank")
            txtPartno.Select()
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtProductName.Text) Then
            MessageBox.Show("Description is Blank ")
            txtProductName.Select()
            Exit Sub
        End If

        Dim strMessage As String = String.Empty



        Dim dblPrice As Double

        If Integer.TryParse(txtUnitPrice.Text, dblPrice) = False Then
            MessageBox.Show("You have enter Numeric Digit (0-9)")
            txtUnitPrice.Select()
            Exit Sub
        End If





        txtPartno.Text = UCase(txtPartno.Text)
        txtProductName.Text = UCase(txtProductName.Text)
        If Not String.IsNullOrEmpty(cmbModel.Text) Then
            cmbModel.Text = UCase(cmbModel.Text)
        End If

        If Not String.IsNullOrEmpty(cmbSource.Text) Then
            cmbSource.Text = UCase(cmbSource.Text)
        End If




        Dim pMethods As clsProductMethods = New clsProductMethods

        If strUpdate = False Then

            Dim Newproduct As clsProduct = New clsProduct
            Newproduct.ProductID = pMethods.GetMaxID
            Newproduct.Code = txtPartno.Text
            Newproduct.ProdName = txtProductName.Text
            Newproduct.Model = cmbModel.Text
            Newproduct.UnitPrice = txtUnitPrice.Text
            Newproduct.Country = cmbSource.Text
            pMethods.Save(Newproduct)
                strMessage = "Product Save Successfylly"
                clearAll()
            ElseIf strUpdate = True Then
            If Not String.IsNullOrEmpty(strPreviousCode) Then
                Dim Updateproduct As clsProduct = New clsProduct
                Updateproduct.Code = txtPartno.Text
                Updateproduct.ProdName = txtProductName.Text
                Updateproduct.Model = cmbModel.Text
                Updateproduct.UnitPrice = txtUnitPrice.Text
                Updateproduct.Country = cmbSource.Text
                pMethods.Update(Updateproduct, strPreviousCode)
                    strMessage = "Product Update Successfylly"



                    lstProductList.Items(intIndex).SubItems(1).Text = txtPartno.Text
                    lstProductList.Items(intIndex).SubItems(2).Text = txtProductName.Text
                    lstProductList.Items(intIndex).SubItems(3).Text = cmbModel.Text
                    lstProductList.Items(intIndex).SubItems(4).Text = txtUnitPrice.Text
                    lstProductList.Items(intIndex).SubItems(5).Text = cmbSource.Text

                    clearAll()
                Else
                strMessage = "The Product Is Not Selected"
            End If
        End If
            MessageBox.Show(strMessage)


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub




    Private Sub clearAll()


        strPreviousCode = ""
        txtPartno.Text = ""
        txtProductName.Text = ""
        cmbModel.Text = ""
        txtUnitPrice.Text = 0
        cmbSource.Text = ""
        txtPartno.Select()



    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPartno.Text = ""
        txtProductName.Text = ""
        cmbModel.Text = ""
        txtUnitPrice.Text = 0
        cmbModel.Text = ""
        strPreviousCode = ""
        btnAdd.Text = "&Add"
        chkEdit.Checked = False



    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click

        Try

            LoadProduct()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtPartno_TextChanged(sender As Object, e As EventArgs) Handles txtPartno.TextChanged

    End Sub

    Private Sub txtPartno_KeyUp(sender As Object, e As KeyEventArgs) Handles txtPartno.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtProductName.Select()

        End If
    End Sub

    Private Sub txtProductName_TextChanged(sender As Object, e As EventArgs) Handles txtProductName.TextChanged

    End Sub

    Private Sub cmbModel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbModel.SelectedIndexChanged

    End Sub

    Private Sub cmbModel_KeyUp(sender As Object, e As KeyEventArgs) Handles cmbModel.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtUnitPrice.Select()

        End If
    End Sub

    Private Sub cmbSource_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSource.SelectedIndexChanged

    End Sub

    Private Sub txtUnitPrice_TextChanged(sender As Object, e As EventArgs) Handles txtUnitPrice.TextChanged

    End Sub

    Private Sub txtUnitPrice_KeyUp(sender As Object, e As KeyEventArgs) Handles txtUnitPrice.KeyUp
        If e.KeyCode = Keys.Enter Then
            cmbSource.Select()

        End If
    End Sub

    Private Sub txtProductName_KeyUp(sender As Object, e As KeyEventArgs) Handles txtProductName.KeyUp
        If e.KeyCode = Keys.Enter Then
            cmbModel.Select()

        End If
    End Sub

    Private Sub lblHeader_Click(sender As Object, e As EventArgs) Handles lblHeader.Click

    End Sub

    Private Sub lblHeader_MouseDown(sender As Object, e As MouseEventArgs) Handles lblHeader.MouseDown
        ReleaseCapture()
        SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
    End Sub

    Private Sub frmNewProduct_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        ReleaseCapture()
        SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
    End Sub
End Class