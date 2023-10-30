Imports System
Imports System.Data.OleDb
Imports System.Data
Imports System.Configuration
Imports System.ComponentModel

Public Class frmCashsale

    Public strFormMode As String
    Dim IntBrandId As Integer = 0
    Dim intListviewIndex As Integer
    Dim strMRValue As String



    Private Sub frmCashsale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterForm(Me)

        Try


            If strFormMode = UCase("New") Then

                Me.Text = "New Cash Sale"
                cmdSave.Text = "&Save"
                cmdDeleteMR.Enabled = False

            Else
                Me.Text = "Update Cash Sale"
                cmdSave.Text = "&Update"
                If Not IsNothing(ActiveUser) Then
                    If ActiveUser.UserType.ToLower = LCase("Admin") Then
                        cmdDeleteMR.Enabled = True
                    Else
                        cmdDeleteMR.Enabled = False
                    End If

                End If


            End If


            ClearField("All")
            CategoryLoad()
            BranchLoad()
            SellCodeLoad()

            If IsNothing(My.Computer.Registry.CurrentUser.OpenSubKey("Software\Company Software\Service").GetValue("Default_Branch")) Then


                Dim setbranch As frmSetBranch = New frmSetBranch
                setbranch.ShowDialog()
                cmbBranch.Text = My.Computer.Registry.CurrentUser.OpenSubKey("Software\Company Software\Service").GetValue("Default_Branch")
            Else
                cmbBranch.Text = My.Computer.Registry.CurrentUser.OpenSubKey("Software\Company Software\Service").GetValue("Default_Branch")
            End If


        Catch ex As Exception

            MessageBox.Show(ex.Message)

                Me.Dispose()
      
        End Try


    End Sub

    Private Sub BranchLoad()

        Dim ConLoadBranch As New OleDbConnection(strProvider)

        Dim drLoadBranch As OleDbDataReader = Nothing


        LoadAllInformation(ConLoadBranch, drLoadBranch, strProvider, "Branch", "Branch", "Branch.flag=-1")



        If drLoadBranch.HasRows = True Then
            While drLoadBranch.Read
                cmbBranch.Items.Add(drLoadBranch("Branch").ToString)
            End While
        End If



    End Sub






    Private Sub SellCodeLoad()


        Dim ConLoadSellCode As New OleDbConnection(strProvider)

        Dim drLoadSellCode As OleDbDataReader = Nothing


        LoadAllInformation(ConLoadSellCode, drLoadSellCode, strProvider, "Personal", "EmpCode", "")


        If drLoadSellCode.HasRows = True Then
            While drLoadSellCode.Read
                cmbSellBy.Items.Add(drLoadSellCode("EmpCode").ToString)
            End While
        End If



    End Sub














    Private Sub CategoryLoad()


        Dim ConLoadCategory As New OleDbConnection(strProvider)

        Dim drLoadCategory As OleDbDataReader = Nothing


        LoadAllInformation(ConLoadCategory, drLoadCategory, strProvider, "cType", "Ctype", "")



        If drLoadCategory.HasRows = True Then
            While drLoadCategory.Read
                cmbCategory.Items.Add(drLoadCategory("Ctype").ToString)
            End While
        End If



    End Sub




    Private Sub BrandLoad()


        Dim ConLoadBrand As New OleDbConnection(strProvider)

        Dim drLoadBRand As OleDbDataReader = Nothing


        LoadAllInformation(ConLoadBrand, drLoadBRand, strProvider, "Brand", "Distinct Brand", "Brand.Ctype='" & cmbCategory.Text & "'")



        If drLoadBRand.HasRows = True Then
            cmbBrand.Items.Clear()

            While drLoadBRand.Read
                cmbBrand.Items.Add(drLoadBRand("Brand").ToString)
            End While
        End If



    End Sub


    Private Sub ModelLoad()


        Dim ConLoadModel As New OleDbConnection(strProvider)

        Dim drLoadModel As OleDbDataReader = Nothing


        LoadAllInformation(ConLoadModel, drLoadModel, strProvider, "BrandModel", "Distinct Model", "BrandModel.brdid=" & IntBrandId)



        If drLoadModel.HasRows = True Then
            cmbModel.Items.Clear()

            While drLoadModel.Read
                cmbModel.Items.Add(drLoadModel("Model").ToString)
            End While
        End If



    End Sub




    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()

    End Sub

    Private Sub cmSellBy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSellBy.SelectedIndexChanged
        Dim ConLoadSellCodeName As New OleDbConnection(strProvider)

        Dim drLoadSellCodeName As OleDbDataReader = Nothing

        Try


            LoadAllInformation(ConLoadSellCodeName, drLoadSellCodeName, strProvider, "Personal", "Empname", "Personal.EmpCode='" & cmbSellBy.Text & "'")



            If drLoadSellCodeName.HasRows = True Then
                While drLoadSellCodeName.Read
                    lblSellBy.Text = drLoadSellCodeName("EmpName").ToString
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub













    Private Sub cmbSellBy_Validating(sender As Object, e As CancelEventArgs) Handles cmbSellBy.Validating
        If RecordVerification(strProvider, "Personal", "Personal.EmpCode='" & cmbSellBy.Text & "'") = False Then
            MessageBox.Show("Employee Code is not found in the 'Database'")
            cmbSellBy.Select()
            cmbSellBy.SelectionStart = 0
            cmbSellBy.SelectionLength = cmbSellBy.Text.Length
        Else
            cmSellBy_SelectedIndexChanged(sender, e)
        End If
    End Sub

    Private Sub txtPartNo_TextChanged(sender As Object, e As EventArgs) Handles txtPartNo.TextChanged



        If String.IsNullOrEmpty(txtPartNo.Text) Then
            dgvPartsInformation.Visible = False
            Exit Sub
        End If



        LoadPartNo("Code")
    End Sub

    Private Sub txtMRNO_TextChanged(sender As Object, e As EventArgs) Handles txtMRNO.TextChanged
        If strFormMode = UCase("Edit") Then
            If txtMRNO.Text = String.Empty Then
                dgvMRNO.Visible = False

                Exit Sub
            End If
            LoadCashsalesMrNo()

        End If
    End Sub

    Private Sub cmbBranch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBranch.SelectedIndexChanged

    End Sub

    Private Sub cmbBranch_Validating(sender As Object, e As CancelEventArgs) Handles cmbBranch.Validating
        If RecordVerification(strProvider, "Branch", "Branch.Branch='" & cmbBranch.Text & "'") = False Then
            MessageBox.Show("Branch is not found in the 'Database'")
            cmbBranch.Select()
            cmbBranch.SelectionStart = 0
            cmbBranch.SelectionLength = cmbBranch.Text.Length
        End If
    End Sub

    Private Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged

    End Sub

    Private Sub cmbCategory_Validating(sender As Object, e As CancelEventArgs) Handles cmbCategory.Validating
        If cmbCategory.Text <> String.Empty Then
            If RecordVerification(strProvider, "Ctype", "Ctype.Ctype='" & cmbCategory.Text & "'") = False Then
                MessageBox.Show("Category is not found in the 'Database'")
                cmbCategory.Select()
                cmbCategory.SelectionStart = 0
                cmbCategory.SelectionLength = cmbCategory.Text.Length
            Else
                BrandLoad()
            End If
        End If
    End Sub

    Private Sub cmbBrand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBrand.SelectedIndexChanged

    End Sub

    Private Sub cmbBrand_Validating(sender As Object, e As CancelEventArgs) Handles cmbBrand.Validating

        If cmbBrand.Text <> String.Empty Then


            If RecordVerification(strProvider, "Brand", "Brand.Ctype='" & cmbCategory.Text & "' and Brand.Brand='" & cmbBrand.Text & "'") = False Then
                MessageBox.Show("Brand Is not found in the Database")
                cmbBrand.Select()
                cmbBrand.SelectionStart = 0
                cmbBrand.SelectionLength = cmbBrand.Text.Length
            Else
                Dim conBrandId As New OleDbConnection(strProvider)
                Dim drBrandId As OleDbDataReader = Nothing

                Try


                    LoadAllInformation(conBrandId, drBrandId, strProvider, "Brand", "brdid", "Brand.ctype='" & cmbCategory.Text & "' and Brand.Brand='" & cmbBrand.Text & "'")


                    If drBrandId.HasRows = True Then

                        While drBrandId.Read

                            IntBrandId = Convert.ToInt32(drBrandId("brdid").ToString)
                        End While

                    End If



                    ModelLoad()

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If

        End If
    End Sub



    Private Sub cmbModel_Validating(sender As Object, e As CancelEventArgs) Handles cmbModel.Validating
        If cmbModel.Text <> String.Empty Then
            If RecordVerification(strProvider, "BrandModel", "BrandModel.Model='" & cmbModel.Text & "' and BrandModel.brdid=" & IntBrandId) = False Then
                MessageBox.Show("Model is not found in the 'Database'")
                cmbModel.Select()
                cmbModel.SelectionStart = 0
                cmbModel.SelectionLength = cmbModel.Text.Length
            End If
        End If

    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        Dim lstItem As ListViewItem = Nothing


        If VerifyField() = True Then
            MessageBox.Show("Branch/Sell Code/Category/Brand/Model Must be Filled" & vbNewLine & "Please Check One of these Field is Blank?")
            Exit Sub
        End If

        Try


            If RecordVerification(strProvider, "Product", "Product.code='" & txtPartNo.Text & "'") = False Then
                MessageBox.Show("Please fill the correct part no")
                Exit Sub

            End If


            Dim dblQty As Double

            Dim dblUnitPrice As Double

            If Integer.TryParse(txtUnitPrice.Text, dblUnitPrice) = False Then

                MessageBox.Show("Check Unit Price is '0' or invalid syntax")
                txtUnitPrice.Select()
                Exit Sub

            End If

            If Integer.TryParse(txtQty.Text, dblQty) = False Then

                MessageBox.Show("Check Qty Field  is '0' or invalid syntax")
                txtQty.Select()
                Exit Sub

            End If






            lstItem = lstProductList.Items.Add(lstProductList.Items.Count + 1)

            lstItem.SubItems.Add(txtPartNo.Text)
            lstItem.SubItems.Add(txtDescription.Text)
            lstItem.SubItems.Add(cmbCategory.Text)
            lstItem.SubItems.Add(cmbBrand.Text)
            lstItem.SubItems.Add(cmbModel.Text)
            lstItem.SubItems.Add(dblUnitPrice)
            lstItem.SubItems.Add(dblQty)
            lstItem.SubItems.Add(Convert.ToDouble(txtUnitPrice.Text) * Convert.ToDouble(txtQty.Text))
            lstItem.SubItems.Add(txtSerial.Text)
            lstItem.SubItems.Add(txtESNNO.Text)

            PaybleAmount()
            ClearField("")
            txtPartNo.Select()



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try




    End Sub

    Private Function VerifyField() As Boolean

        If String.IsNullOrEmpty(cmbCategory.Text) Then
            Return True
        End If


        If String.IsNullOrEmpty(cmbBranch.Text) Then
            Return True
        End If


        If String.IsNullOrEmpty(cmbBrand.Text) Then
            Return True
        End If



        If String.IsNullOrEmpty(cmbModel.Text) Then
            Return True
        End If


        If String.IsNullOrEmpty(cmbSellBy.Text) Then
            Return True
        End If

        Return False




    End Function


    Private Sub LoadPartNo(ByVal SearchColumn As String)

        Dim conLoadPartNo As New OleDbConnection(strProvider)
        Dim drLoadPartNo As OleDbDataReader = Nothing

        Dim dtLoadPartno As New DataTable


        Try

            If SearchColumn.ToUpper = UCase("Code") Then
                LoadAllInformation(conLoadPartNo, drLoadPartNo, strProvider, "Product", "Product.Code,Product.ProdName,Product.Model,Product.UnitPrice", "left(Product.Code," & txtPartNo.Text.Length & ") ='" & txtPartNo.Text & "'")
                dgvPartsInformation.Left = txtPartNo.Left
                dgvPartsInformation.Top = txtPartNo.Top + txtPartNo.Height + 1
            Else
                LoadAllInformation(conLoadPartNo, drLoadPartNo, strProvider, "Product", "Product.Code,Product.ProdName,Product.Model,Product.UnitPrice", "left(Product.prodName," & txtDescription.Text.Length & ") ='" & txtDescription.Text & "'")
                dgvPartsInformation.Left = txtDescription.Left
                dgvPartsInformation.Top = txtDescription.Top + txtDescription.Height + 1
            End If





            If drLoadPartNo.HasRows = True Then

                dgvPartsInformation.Visible = True

                dtLoadPartno.Load(drLoadPartNo)

                dgvPartsInformation.DataSource = Nothing
                dgvPartsInformation.Rows.Clear()

                dgvPartsInformation.DataSource = dtLoadPartno
                dgvPartsInformation.AutoGenerateColumns = True

                'If dgvPartsInformation.Rows(0).Selected = True Then
                '    dgvPartsInformation.Rows(0).Selected = False

                'End If



            Else
                dgvPartsInformation.Visible = False


            End If





        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try






    End Sub

    Private Sub txtPartNo_KeyUp(sender As Object, e As KeyEventArgs) Handles txtPartNo.KeyUp
        If e.KeyCode = Keys.Down Then
            dgvPartsInformation.Select()
        End If



    End Sub

    Private Sub dgvPartsInformation_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPartsInformation.CellContentClick

    End Sub



    Private Sub txtDescription_TextChanged(sender As Object, e As EventArgs) Handles txtDescription.TextChanged



        If String.IsNullOrEmpty(txtDescription.Text) Then
            dgvPartsInformation.Visible = False
            Exit Sub
        End If




        LoadPartNo("Product")
    End Sub




    Private Sub cmdRefresh_Click(sender As Object, e As EventArgs) Handles cmdRefresh.Click
        CategoryLoad()

        If cmbCategory.Text <> String.Empty Then
            BrandLoad()
        End If

        If IntBrandId > 0 Then
            ModelLoad()
        End If


    End Sub





    Private Sub dgvPartsInformation_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvPartsInformation.KeyDown
        If e.KeyCode = Keys.Enter Then

            txtPartNo.Text = dgvPartsInformation.Rows(dgvPartsInformation.CurrentRow.Index).Cells(0).Value
            txtDescription.Text = dgvPartsInformation.Rows(dgvPartsInformation.CurrentRow.Index).Cells(1).Value
            txtUnitPrice.Text = dgvPartsInformation.Rows(dgvPartsInformation.CurrentRow.Index).Cells(3).Value
            cmbCategory.Select()
            dgvPartsInformation.Visible = False
        End If
    End Sub

    Private Sub txtDescription_KeyUp(sender As Object, e As KeyEventArgs) Handles txtDescription.KeyUp
        If e.KeyCode = Keys.Down Then
            dgvPartsInformation.Select()
        End If



    End Sub



    Private Sub txtJobCode_KeyUp(sender As Object, e As KeyEventArgs) Handles txtJobCode.KeyUp
        If e.KeyCode = Keys.Enter Then
            cmbBranch.Select()

        End If
    End Sub

    Private Sub cmbBranch_KeyUp(sender As Object, e As KeyEventArgs) Handles cmbBranch.KeyUp
        If e.KeyCode = Keys.Enter Then
            cmbSellBy.Select()

        End If
    End Sub








    Private Sub ClearField(ByVal strClearAllField As String)


        txtPartNo.Text = String.Empty
        txtDescription.Text = String.Empty

        txtUnitPrice.Text = CInt("0")
        txtQty.Text = CInt("0")


        If strClearAllField.ToUpper = UCase("All") Then
            txtJobCode.Text = "Case Sale"
            cmbSellBy.Text = String.Empty
            lblSellBy.Text = String.Empty
            txtName.Text = String.Empty
            txtAddress.Text = String.Empty
            txtContact.Text = String.Empty
            txtMRNO.Text = String.Empty
            txtTotalAmount.Text = CInt("0")
            lblTotalAmont.Text = CInt("0")
            txtDiscount.Text = CInt("0")
            lstProductList.Items.Clear()
            cmbCategory.Text = String.Empty
            cmbBrand.Text = String.Empty
            cmbModel.Text = String.Empty
            txtSerial.Text = String.Empty
            txtESNNO.Text = String.Empty

        End If




    End Sub

    Private Sub txtAddress_MouseHover(sender As Object, e As EventArgs) Handles txtAddress.MouseHover

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        ClearField("All")

    End Sub


    Private Function CheckValidation(ByRef strMessage As String) As Boolean
        Dim blnFlag As Boolean = True
        If lstProductList.Items.Count <= 0 Then
            strMessage = "Enter at least one Item"
            blnFlag = False

        End If


        If txtMRNO.Text.Length <= 0 Then
            strMessage = "Enter at least one Item"

            blnFlag = False
        End If
        Return blnFlag
    End Function

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click


        Dim strMessage As String

        If CheckValidation(strMessage) = False Then

            MessageBox.Show(strMessage)
            Exit Sub

        End If


        SaveCashsales()







    End Sub

    Private Sub SaveCashsales()
        Try
            Dim cashsalesMethods As clsCashsalesMethods = New clsCashsalesMethods
            Dim cashsale As clsCashsales = New clsCashsales




            cashsale.MRNO = txtMRNO.Text
            cashsale.JobCode = txtJobCode.Text
            cashsale.Branch = cmbBranch.Text
            cashsale.CustName = txtName.Text
            cashsale.CustAddress1 = txtAddress.Text
            cashsale.CustAddress2 = txtContact.Text
            cashsale.PrdAmt = Convert.ToDouble(lblTotalAmont.Text)
            cashsale.Dis = Convert.ToDouble(txtDiscount.Text)
            cashsale.NetAmnt = Convert.ToInt32(txtTotalAmount.Text)
            cashsale.ReceptDate = dtpSellDate.Value.ToShortDateString
            cashsale.ReceptBy = cmbSellBy.Text
            cashsale.Log_Date = dtpSellDate.Value.ToShortDateString


            For Each Item As ListViewItem In lstProductList.Items
                cashsale.Brand = Item.SubItems(4).Text
                cashsale.ModelNo = Item.SubItems(5).Text
                cashsale.ESN = Item.SubItems(10).Text
                cashsale.SLNo = Item.SubItems(9).Text
                cashsale.Code = Item.SubItems(1).Text
                cashsale.ProdName = Item.SubItems(2).Text
                cashsale.Rate = Double.Parse(Item.SubItems(6).Text)
                cashsale.Qty = Integer.Parse(Item.SubItems(7).Text)
                cashsale.Amount = Double.Parse(Item.SubItems(8).Text)
                cashsale.DFlag = Integer.Parse("0")
                cashsale.Category = Item.SubItems(3).Text

                If strFormMode.ToUpper = UCase("New") Then
                    cashsalesMethods.Save(cashsale)
                ElseIf strFormMode = UCase("Edit") Then

                    ' Delete Non Exist Data From Database
                    DeleteNonExistItemfromDatabase()

                    If cashsalesMethods.IsExist(strMRValue, cashsale.Code) = True Then
                        cashsalesMethods.Update(cashsale, strMRValue, cashsale.Code)
                    Else
                        cashsalesMethods.Save(cashsale)
                    End If

                End If



            Next


            'ElseIf strFormMode = UCase("Edit") Then





            'Dim strSQLValueUpdateInsert As String = Nothing
            '    For intLoop = 0 To lstProductList.Items.Count - 1
            '        cashsale.Brand = lstProductList.Items(intLoop).SubItems(4).Text
            '        cashsale.ModelNo = lstProductList.Items(intLoop).SubItems(5).Text
            '        cashsale.ESN = lstProductList.Items(intLoop).SubItems(10).Text
            '        cashsale.SLNo = lstProductList.Items(intLoop).SubItems(9).Text
            '        cashsale.ReceptDate = dtpSellDate.Value.ToShortDateString
            '        cashsale.ReceptBy = cmbSellBy.Text
            '        cashsale.Code = lstProductList.Items(intLoop).SubItems(1).Text
            '        cashsale.ProdName = lstProductList.Items(intLoop).SubItems(2).Text
            '        cashsale.Rate = Double.Parse(lstProductList.Items(intLoop).SubItems(6).Text)
            '        cashsale.Qty = lstProductList.Items(intLoop).SubItems(7).Text
            '        cashsale.Amount = Double.Parse(lstProductList.Items(intLoop).SubItems(8).Text)

            '        cashsale.Log_Date = dtpSellDate.Value.ToShortDateString
            '        cashsale.DFlag = Integer.Parse("0")
            '        cashsale.Category = lstProductList.Items(intLoop).SubItems(3).Text



            'Next
            'End If

            MessageBox.Show("Record Save Successfully")
            ClearField("All")
            txtJobCode.Select()


        Catch ex As Exception

            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub DeleteNonExistItemfromDatabase()
        Dim cashsalesMethods As clsCashsalesMethods = New clsCashsalesMethods


        Dim strQuery As String = " Cashsales.MRno='" & strMRValue & "'"
        Dim dtCashsales As DataTable = cashsalesMethods.GetCashsales(strQuery)
        Dim bln As Boolean
        If dtCashsales.Rows.Count > 0 Then
            For Each dtrow As DataRow In dtCashsales.Rows
                For Each CashsaleItem As ListViewItem In lstProductList.Items
                    Dim strValue As String = dtrow("Code")
                    If strValue.ToLower = CashsaleItem.SubItems(1).Text.ToLower Then
                        bln = True
                        Exit For
                    Else
                        bln = False
                    End If
                Next
                If bln = False Then
                    cashsalesMethods.DeleteMR(dtrow("MRNO"), dtrow("Code"))
                End If

            Next
        End If
    End Sub



    Private Sub txtDiscount_TextChanged(sender As Object, e As EventArgs) Handles txtDiscount.TextChanged
        PaybleAmount()
    End Sub

    Private Sub PaybleAmount()
        Dim dblTotal As Double
        Dim dbpayble As Double
        Dim dblDiscount As Double


        Dim dblAmount As Double = 0
        For Each item As ListViewItem In lstProductList.Items

            dblAmount += Double.Parse(item.SubItems(8).Text)


        Next

        lblTotalAmont.Text = dblAmount


        If Double.TryParse(lblTotalAmont.Text, dblTotal) = False Then
            dblTotal = Integer.Parse("0")
        End If

        If Double.TryParse(txtDiscount.Text, dblDiscount) = False Then
            dblDiscount = Integer.Parse("0")
        End If


        txtTotalAmount.Text = dblTotal - dblDiscount


    End Sub

    Private Sub lstProductList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstProductList.SelectedIndexChanged
        With lstProductList
            txtPartNo.Text = .FocusedItem.SubItems(1).Text
            txtDescription.Text = .FocusedItem.SubItems(2).Text
            cmbCategory.Text = .FocusedItem.SubItems(3).Text
            cmbBrand.Text = .FocusedItem.SubItems(4).Text
            cmbModel.Text = .FocusedItem.SubItems(5).Text
            txtUnitPrice.Text = .FocusedItem.SubItems(6).Text
            txtQty.Text = .FocusedItem.SubItems(7).Text
            txtSerial.Text = .FocusedItem.SubItems(9).Text
            txtESNNO.Text = .FocusedItem.SubItems(10).Text
        End With
        dgvPartsInformation.Visible = False

        intListviewIndex = lstProductList.FocusedItem.Index



    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        Dim clm As clsCashsalesMethods = New clsCashsalesMethods

        lblTotalAmont.Text = 0
        If lstProductList.Items.Count > 0 Then
            lstProductList.Items(intListviewIndex).Remove()
            ClearField("")


        End If


        PaybleAmount()






    End Sub

    Private Sub cmbSellBy_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbSellBy.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtName.Select()

        End If
    End Sub

    Private Sub txtPartNo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPartNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtDescription.Select()

        End If
    End Sub

    Private Sub txtDescription_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDescription.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbCategory.Select()

        End If
    End Sub



    Private Sub cmbBrand_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbBrand.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbModel.Select()

        End If
    End Sub

    Private Sub cmbCategory_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbCategory.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbBrand.Select()

        End If
    End Sub

    Private Sub cmbModel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbModel.SelectedIndexChanged

    End Sub

    Private Sub cmbModel_SizeChanged(sender As Object, e As EventArgs) Handles cmbModel.SizeChanged

    End Sub

    Private Sub cmbModel_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbModel.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtSerial.Select()

        End If
    End Sub

    Private Sub txtSerial_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSerial.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtESNNO.Select()

        End If
    End Sub

    Private Sub txtESNNO_TextChanged(sender As Object, e As EventArgs) Handles txtESNNO.TextChanged

    End Sub

    Private Sub txtSerial_Layout(sender As Object, e As LayoutEventArgs) Handles txtSerial.Layout

    End Sub

    Private Sub txtSerial_TextChanged(sender As Object, e As EventArgs) Handles txtSerial.TextChanged

    End Sub

    Private Sub txtSerial_StyleChanged(sender As Object, e As EventArgs) Handles txtSerial.StyleChanged

    End Sub

    Private Sub txtESNNO_KeyDown(sender As Object, e As KeyEventArgs) Handles txtESNNO.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtUnitPrice.Select()

        End If
    End Sub

    Private Sub txtUnitPrice_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUnitPrice.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtQty.Select()

        End If
    End Sub

    Private Sub txtQty_KeyDown(sender As Object, e As KeyEventArgs) Handles txtQty.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdAdd.Select()
        End If
    End Sub

    Private Sub txtContact_TextChanged(sender As Object, e As EventArgs) Handles txtContact.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ClearField("")
    End Sub


    Private Sub LoadCashsalesMrNo()
        Dim dtMRNO As New DataTable


        Dim conMRNO As New OleDbConnection(strProvider)

        Dim drMRNo As OleDbDataReader = Nothing

        LoadAllInformation(conMRNO, drMRNo, strProvider, "Cashsales", "Distinct MRNO", "left(Cashsales.MrNo, " & txtMRNO.Text.Length & ") ='" & txtMRNO.Text & "'")



            If drMRNo.HasRows = True Then
            dgvMRNO.Visible = True
            dgvMRNO.Height = 250
            dgvMRNO.Top = txtMRNO.Top - dgvMRNO.Height

            dgvMRNO.DataSource = Nothing
            dgvMRNO.Rows.Clear()

            dtMRNO.Load(drMRNo)




            dgvMRNO.DataSource = dtMRNO
            dgvMRNO.CurrentRow.Selected = False
            'dgvMRNO.AutoGenerateColumns = True
        Else
            dgvMRNO.Visible = False

        End If




    End Sub

    Private Sub txtMRNO_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMRNO.KeyDown
        If e.KeyCode = Keys.Down Then
            dgvMRNO.Select()
            dgvMRNO.CurrentRow.Selected = True

        End If
    End Sub

    Private Sub dgvMRNO_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMRNO.CellContentClick

    End Sub

    Private Sub dgvMRNO_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvMRNO.KeyDown
        If e.KeyCode = Keys.Enter Then

            LoadCashsalesInformation(dgvMRNO.Rows(dgvMRNO.CurrentRow.Index).Cells(0).Value)


            dgvMRNO.Visible = False



        End If


    End Sub



    Private Sub LoadCashsalesInformation(byval strSQLCriteria As String)
        Dim conCashsale As New OleDbConnection(strProvider)
        Dim drCashSale As OleDbDataReader = Nothing
        Dim lstItem As ListViewItem = Nothing

        Dim E As New EventArgs
        Dim Sender As New Object

        conCashsale.Open()

        LoadAllInformation(conCashsale, drCashSale, strProvider, "Cashsales", "MrNo,JobCode,Branch,CustName,CustAddress1,CustAddress2,Brand,ModelNo,ESN,SLNo,ReceptDate,Receptby,Code,
                ProdName,Rate,Qty,Amount,Prdamt,Dis,NetAmnt,Log_User,Log_Date,Dflag", "Cashsales.MRNo='" & strSQLCriteria.ToString & "'")

        If drCashSale.HasRows = True Then
            lstProductList.Items.Clear()

            While drCashSale.Read

                txtJobCode.Text = drCashSale("JobCode").ToString
                cmbBranch.Text = drCashSale("Branch").ToString
                cmbSellBy.Text = drCashSale("Receptby").ToString
                txtName.Text = drCashSale("CustName").ToString
                txtAddress.Text = drCashSale("CustAddress1").ToString
                txtContact.Text = drCashSale("CustAddress2").ToString
                lblTotalAmont.Text = drCashSale("Prdamt").ToString
                txtMRNO.Text = drCashSale("MrNo").ToString

                txtDiscount.Text = drCashSale("Dis").ToString

                txtTotalAmount.Text = drCashSale("NetAmnt").ToString

                dtpSellDate.Value = drCashSale("ReceptDate").ToString

                cmSellBy_SelectedIndexChanged(Sender, E)



                lstItem = lstProductList.Items.Add(lstProductList.Items.Count + 1)
                lstItem.SubItems.Add(drCashSale("COde").ToString)
                lstItem.SubItems.Add(drCashSale("ProdName").ToString)
                lstItem.SubItems.Add("")
                lstItem.SubItems.Add(drCashSale("Brand").ToString)
                lstItem.SubItems.Add(drCashSale("ModelNo").ToString)
                lstItem.SubItems.Add(drCashSale("Rate").ToString)
                lstItem.SubItems.Add(drCashSale("Qty").ToString)
                lstItem.SubItems.Add(drCashSale("Amount").ToString)
                lstItem.SubItems.Add(drCashSale("SlNo").ToString)
                lstItem.SubItems.Add(drCashSale("ESN").ToString)


            End While


            strMRValue = txtMRNO.Text

        End If


        PaybleAmount()


        'conCashsale.Dispose()


    End Sub



    Private Sub cmdDeleteMR_Click(sender As Object, e As EventArgs) Handles cmdDeleteMR.Click
        Dim clm As clsCashsalesMethods = New clsCashsalesMethods
        If clm.IsExist(strMRValue) = True Then
            clm.DeleteMR(strMRValue)
        End If
        'DeleteRecord("Cashsales", "Cashsales.MrNo='" & strMRValue & "'", "ON")
        ClearField("All")
    End Sub

    Private Sub grpCustomerInformation_Enter(sender As Object, e As EventArgs) Handles grpCustomerInformation.Enter

    End Sub

    Private Sub txtJobCode_TextChanged(sender As Object, e As EventArgs) Handles txtJobCode.TextChanged

    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        Dim ReportShow As frmReportShow = New frmReportShow

        Dim csm As clsCashsalesMethods = New clsCashsalesMethods

        ReportShow.CashSales.MRNO = txtMRNO.Text
        If csm.IsExist(txtMRNO.Text) = False Then
            Dim strMessage As String

            If CheckValidation(strMessage) = False Then

                MessageBox.Show(strMessage)
                Exit Sub

            End If


            SaveCashsales()
        End If
        ReportIdentification = "CashSales"

        ReportShow.ShowDialog()






    End Sub
End Class