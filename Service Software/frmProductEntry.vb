Imports System.Data.OleDb
Imports Microsoft
Imports System.Configuration
Imports System.Linq



Public Class frmProductEntry
    Dim sngPartsAmount As Single ' Define for takine totalamount of parts
    Dim dtIssueDate As Date

    Dim intSavingMode As Integer = 0


    Private Sub frmProductEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'If publicClaiminfo.cFlag = 100 Then
        '    MessageBox.Show("You Can not open the job Because The Job is delivered ('Customer Returnd')")
        '    Exit Sub
        'ElseIf publicClaiminfo.cFlag = 102 Then
        '    MessageBox.Show("You Can not open the job Because The Job is delivered ('Replace Product')")
        '    Exit Sub
        'End If


        'If Not IsNothing(ActiveUser) Then

        '    If publicClaiminfo.cFlag = 0 Or publicClaiminfo.cFlag = 2 Then
        '        If ActiveUser.UserType.ToLower = LCase("Admin") Then
        '            chkSaveByForce.Visible = True
        '        Else
        '            chkSaveByForce.Visible = False
        '        End If

        '    ElseIf publicClaiminfo.cFlag = 1 Then

        '        If ActiveUser.UserType.ToLower = LCase("Admin") Then
        '            chkSaveByForce.Visible = True
        '        Else
        '            chkSaveByForce.Visible = False

        '        End If
        '    Else
        '        chkSaveByForce.Visible = False
        '    End If
        'Else
        '    chkSaveByForce.Visible = False


        'End If




        intSavingMode = 1 ' Parts Option Enabled
        chkRemarks.Checked = False



        Me.Left = (My.Computer.Screen.Bounds.Width - Me.Width) / 2
        Me.Top = (My.Computer.Screen.Bounds.Height - Me.Height) / 2

        Dim cFlag As Integer = 0
        Dim MrNo As String = String.Empty

        cFlag = publicClaiminfo.cFlag
        MrNo = publicClaiminfo.MRNO
        lstProductList.Visible = False
        LoadEmployee()

        If (cFlag = 1 Or cFlag = 2 Or cFlag = 0) And MrNo.ToLower <> LCase("est refuse") Then
            LoadProductList()
        End If

    End Sub





    Private Sub LoadEmployee()

        Dim EmpMethods As clsPersonalMethods = New clsPersonalMethods
        Dim EmpList As List(Of clsPersonal) = EmpMethods.LoadTechnician


        If EmpList.Count > 0 Then
            For Each e In EmpList
                cmbServiceby.Items.Add(e.EmpCode)
            Next

        End If


    End Sub





    Private Sub ProductList(ByVal strTempProductCode As String, ByVal strSearchField As String)
        Dim strSQLProductList As String = ""
        If strSearchField = "Code" Then
            strSQLProductList = "Select Product.Code,Product.ProdName,Product.UnitPrice,Product.Measure from Product where Product.Code LIKE ('" & strTempProductCode & "%')"
        Else

            strSQLProductList = "Select Product.Code,Product.ProdName,Product.UnitPrice,Product.Measure from Product where Product.ProdName LIKE ('" & strTempProductCode & "%')"
        End If


        Dim dcProductList As New OleDbCommand(strSQLProductList, MyCon)

        Dim drProductList As OleDbDataReader
        Dim lsttmpProductList As ListViewItem = Nothing

        Try
            drProductList = dcProductList.ExecuteReader





            If drProductList.HasRows = True Then
                If lstProductList.Visible = False Then
                    lstProductList.Visible = True

                End If
                Dim shrtRowCount As Short = 0
                lstProductList.Items.Clear()

                If lstProductList.Visible = False Then
                    lstProductList.Visible = True
                End If

                While drProductList.Read
                    shrtRowCount = shrtRowCount + 1
                    lsttmpProductList = lstProductList.Items.Add(shrtRowCount)
                    lsttmpProductList.SubItems.Add(drProductList("Code").ToString)
                    lsttmpProductList.SubItems.Add(drProductList("ProdName").ToString)
                    lsttmpProductList.SubItems.Add(drProductList("Measure").ToString)
                    lsttmpProductList.SubItems.Add(drProductList("UnitPrice").ToString)

                End While

            Else
                If lstProductList.Visible = True Then
                    lstProductList.Visible = False


                End If
            End If

        Catch ProductError As Exception
            MsgBox(ProductError.Message, vbCritical, "Err Search (Event Name:ProductList")

        End Try





    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtPartNo.TextChanged


        If txtPartNo.Text <> "" Then
            lstProductList.Left = txtPartNo.Left
            lstProductList.Top = txtPartNo.Top + txtPartNo.Height
            lstProductList.BringToFront()
            ProductList(txtPartNo.Text, "Code")


        End If

    End Sub





    Private Sub dgvProductInformation_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs)

        If MsgBox("Are you sure to delete the selected row", vbYesNo, "Delete Record") = vbYes Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If



    End Sub

    Private Sub txtDescription_TextChanged(sender As Object, e As EventArgs) Handles txtDescription.TextChanged



        If txtDescription.Text <> "" Then
            lstProductList.Left = txtDescription.Left
            lstProductList.Top = txtDescription.Top + txtDescription.Height
            lstProductList.BringToFront()
            ProductList(txtDescription.Text, "Product")

        End If
    End Sub

    Private Sub txtPartNo_GotFocus(sender As Object, e As EventArgs) Handles txtPartNo.GotFocus


        If txtDescription.Text <> "" Then
            txtDescription.Text = String.Empty
            If lstProductList.Visible = True Then
                lstProductList.Visible = False

            End If
        End If
    End Sub

    Private Sub txtDescription_GotFocus(sender As Object, e As EventArgs) Handles txtDescription.GotFocus



        If txtPartNo.Text <> "" Then
            txtPartNo.Text = String.Empty

            If lstProductList.Visible = True Then
                lstProductList.Visible = False

            End If

        End If


    End Sub

    Private Sub txtPartNo_KeyUp(sender As Object, e As KeyEventArgs) Handles txtPartNo.KeyUp

    End Sub

    Private Sub txtDescription_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDescription.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            If lstProductList.Visible = True Then
                lstProductList.Select()
                lstProductList.Items(0).Selected = True
                lblPartNo.Text = lstProductList.SelectedItems(0).SubItems(1).Text
                lblDescription.Text = lstProductList.SelectedItems(0).SubItems(2).Text
                lblMeasure.Text = lstProductList.SelectedItems(0).SubItems(3).Text
                txtUnitPrice.Text = lstProductList.SelectedItems(0).SubItems(4).Text
            End If
        End If
    End Sub



    Private Sub lstProductList_KeyUp(sender As Object, e As KeyEventArgs) Handles lstProductList.KeyUp

        If e.KeyCode = Keys.Escape Or e.KeyCode = Keys.Enter Then
            If lstProductList.Visible = True Then
                txtQty.Select()
                lstProductList.Visible = False


            End If

        ElseIf e.KeyCode = Keys.Down Or e.KeyCode = Keys.Up Then




            lblPartNo.Text = lstProductList.FocusedItem.SubItems(1).Text
            lblDescription.Text = lstProductList.FocusedItem.SubItems(2).Text
            lblMeasure.Text = lstProductList.FocusedItem.SubItems(3).Text
            txtUnitPrice.Text = lstProductList.FocusedItem.SubItems(4).Text


        End If
    End Sub


    Private Sub txtQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQty.KeyPress


        If VisualBasic.Asc(e.KeyChar) = 8 Then
            e.Handled = False
            Exit Sub
        End If


        If VisualBasic.Asc(e.KeyChar) = 13 Then
            e.Handled = False
            txtUnitPrice.Select()

        End If



    End Sub



    Private Sub txtUnitPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUnitPrice.KeyPress


        If VisualBasic.Asc(e.KeyChar) = 8 Then
            e.Handled = False
            Exit Sub
        End If


        If VisualBasic.Asc(e.KeyChar) = 13 Then
            e.Handled = False
            cmdAdd.Select()

        End If
    End Sub



    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click



        Try


            lstProductList.Visible = False

            Dim PriceValidationMessage As String = String.Empty

            If PriceValidation(PriceValidationMessage) = False Then
                If PriceValidationMessage.ToLower = "Qty".ToLower Then
                    MessageBox.Show("Qty Field is invalid format")
                    txtQty.Select()
                End If

                If PriceValidationMessage.ToLower = "Price".ToLower Then
                    MessageBox.Show("Unit Price Field is invalid format")
                    txtUnitPrice.Select()
                End If
                Exit Sub
            End If


            If Convert.ToDouble(txtQty.Text) <= 0 Then

                MessageBox.Show("Qty is negetive or 0")
                txtQty.Select()
                Exit Sub
            End If

            If Convert.ToDouble(txtUnitPrice.Text) <= 0 Then
                MessageBox.Show("Price is negetive or 0")
                txtUnitPrice.Select()
                Exit Sub
            End If




            Dim dblQty As Single
            Dim dblunitprice As Single
            Dim dbTotal As Single

            TotalAmount()
            If Parts_Duplicate(lblPartNo.Text) = True Then
                MessageBox.Show("This parts is already exist in the list")
                Exit Sub
            End If


            If String.IsNullOrEmpty(lblPartNo.Text) Then
                MessageBox.Show("Part no Field is blank")
                txtPartNo.Select()
                Exit Sub
            End If

            If Integer.TryParse(txtQty.Text, dblQty) = False Then
                MessageBox.Show("Quantity Field should be Number")
                txtQty.Select()
                Exit Sub
            End If


            If Integer.TryParse(txtUnitPrice.Text, dblunitprice) = False Then
                MessageBox.Show("unit price Field should be Number")
                txtUnitPrice.Select()
                Exit Sub
            End If


            If Integer.TryParse(lblTotal.Text, dbTotal) = False Then
                MessageBox.Show("Total Field should be Number")
                Exit Sub
            End If




            Dim lstitem As ListViewItem = New ListViewItem

            lstitem = lstPartsDetails.Items.Add(lstPartsDetails.Items.Count + 1)

            lstitem.SubItems.Add(lblPartNo.Text)
            lstitem.SubItems.Add(RemoveCommafromText(lblDescription.Text))
            lstitem.SubItems.Add(lblMeasure.Text)
            lstitem.SubItems.Add(dblQty)
            lstitem.SubItems.Add(dblunitprice)
            lstitem.SubItems.Add(dbTotal)
   

            lstitem.SubItems(0).Tag = "Sl"
            lstitem.SubItems(1).Tag = "Part No"
            lstitem.SubItems(2).Tag = "Description"
            lstitem.SubItems(3).Tag = "Measure"
            lstitem.SubItems(4).Tag = "Qty"
            lstitem.SubItems(5).Tag = "UnitPrice"
            lstitem.SubItems(6).Tag = "Total"


            Getpartsamount()

            ClearField()
            txtPartNo.Select()




        Catch ex As Exception
            MessageBox.Show(ex.Message, "Add Failure (Event Name: cmdAdd_Click)")



        End Try

    End Sub


    Private Function RemoveCommafromText(ByVal Remove As String) As String

        Dim strReturnValue As String = String.Empty
        For Each tmpstr In Remove
            If tmpstr = "," Then
                strReturnValue += "-"
            Else
                strReturnValue += tmpstr
            End If

        Next
        Return strReturnValue

    End Function

    Private Function Parts_Duplicate(ByVal strPartNo As String) As Boolean

        For Each lstitem As ListViewItem In lstPartsDetails.Items
            If lstitem.SubItems(1).Text = strPartNo Then
                Return True
            End If
        Next
        Return False

    End Function






    Private Sub Getpartsamount()
        lblTotalParts.Text = Integer.Parse("0")
        Dim intAmount As Integer = 0

        For Each lstView As ListViewItem In lstPartsDetails.Items

            intAmount += lstView.SubItems(6).Text


        Next
        lblTotalParts.Text = intAmount


    End Sub

    Private Sub TotalAmount()
        Dim intqty As Integer = 0
        Dim intUnitPrice As Integer
        If String.IsNullOrEmpty(lblPartNo.Text) Then
            MsgBox("No Parts Enterd", vbInformation, "Qty Error")
            txtPartNo.Select()
            Exit Sub
        End If

        If Integer.TryParse(txtQty.Text, intqty) = True Then
            If Integer.TryParse(txtUnitPrice.Text, intUnitPrice) = True Then
                lblTotal.Text = (intqty * intUnitPrice)
            Else
                MessageBox.Show("Unit Price Field is invalid format")
                txtUnitPrice.Select()
                Exit Sub
            End If
        Else
            MessageBox.Show("Qty Field is invalid format")
            txtQty.Select()
            Exit Sub
        End If




    End Sub
    Private Sub ClearField()

        txtPartNo.Text = String.Empty
        txtDescription.Text = String.Empty
        lblPartNo.Text = String.Empty
        lblDescription.Text = String.Empty
        lblMeasure.Text = String.Empty
        txtQty.Text = "0"
        txtUnitPrice.Text = "0"
        lblTotal.Text = "0"



    End Sub



    Private Sub chkRemarks_CheckedChanged(sender As Object, e As EventArgs) Handles chkRemarks.CheckedChanged
        If chkRemarks.Checked = True Then
            If lstPartsDetails.Items.Count > 0 Then
                If MessageBox.Show("Already Parts Exist in the list do you want to enable Remarks the items will be lost", "Error", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    lstPartsDetails.Items.Clear()
                    txtRemarks.Enabled = True
                    intSavingMode = 2 'Remarks Option Enabled
                    DisableControl("Service")
                Else
                    chkRemarks.Checked = False

                End If
            Else
                DisableControl("Service")
                intSavingMode = 2 'Remarks Option Enabled
            End If
        ElseIf chkRemarks.Checked = False Then
            DisableControl("Remarks")
            intSavingMode = 1 'Parts Option Enabled
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        'sngPartsAmount = 0
        Me.Close()




    End Sub


    Private Sub DisableControl(ByVal strTempStatus As String)
        If strTempStatus.ToLower = LCase("Service") Then
            ClearField()
            txtPartNo.Enabled = False
            txtDescription.Enabled = False
            txtQty.Enabled = False
            txtUnitPrice.Enabled = False
            lstPartsDetails.Enabled = False
            cmdAdd.Enabled = False
            cmdDeleteRecord.Enabled = False
            txtRemarks.Enabled = True
            txtRemarks.Select()
            lblTotalParts.Text = "0"
            lblTotal.Text = "0"

        ElseIf strTempStatus.ToLower = LCase("Remarks") Then
            txtPartNo.Enabled = True
            txtDescription.Enabled = True
            txtQty.Enabled = True
            txtUnitPrice.Enabled = True
            lstPartsDetails.Enabled = True
            cmdAdd.Enabled = True
            cmdDeleteRecord.Enabled = True
            txtRemarks.Text = String.Empty
            txtRemarks.Enabled = False
            txtPartNo.Select()
        End If


    End Sub



    Private Sub cmdDeleteRecord_Click(sender As Object, e As EventArgs) Handles cmdDeleteRecord.Click


        For Each tempItem As ListViewItem In lstPartsDetails.Items
            If tempItem.Selected = True Then
                tempItem.Remove()
            End If


        Next
        Getpartsamount()


        'Dim shrtLoop As Short = 0


        'If dgvProductInformation.Rows().Count = 1 Then
        '    MsgBox("Product list is empty")
        '    Exit Sub
        'Else
        '    lstDeleteParts.Items.Clear()

        '    For shrtLoop = 0 To dgvProductInformation.Rows().Count - 1

        '        '
        '        'stDeleteParts.Items.Add(dgvProductInformation.Rows(shrtLoop))
        '        If Not String.IsNullOrEmpty(dgvProductInformation.Rows(shrtLoop).Cells(0).Value) Then
        '            lstDeleteParts.Items.Add(dgvProductInformation.Rows(shrtLoop).Cells(0).Value)
        '        End If





        '    Next


        'End If
        'lstDeleteParts.Top = cmdDeleteRecord.Top + cmdDeleteRecord.Height
        'lstDeleteParts.Width = cmdDeleteRecord.Width
        'lstDeleteParts.Left = cmdDeleteRecord.Left
        'lstDeleteParts.Show()

    End Sub




    Private Sub LoadProductList()


        Try

            Dim claiminfoMethods As clsClaiminfoMethods = New clsClaiminfoMethods
        Dim claiminfo As clsClaiminfo = claiminfoMethods.LoadClaiminfo_byJobCode(publicClaiminfo.Jobcode)

        Dim EmployeeMethods As clsPersonalMethods = New clsPersonalMethods
        Dim Employee As List(Of clsPersonal) = EmployeeMethods.LoadTechnician(claiminfo.ServiceBy)
        Dim ServiceDetailsMethods As clsServiceDetailsMethods = New clsServiceDetailsMethods

            If ServiceDetailsMethods.IsExist(claiminfo.Jobcode) = False Then
                Exit Sub
            End If

            Dim ServiceDetails As clsServiceDetails = ServiceDetailsMethods.GetPartsDetails(claiminfo.Jobcode)


            If String.IsNullOrEmpty(ServiceDetails.Description) Then
                Exit Sub
            End If

            Dim lstViewItem As ListViewItem = New ListViewItem
            lstPartsDetails.Items.Clear()

            Dim strPartsDetails As String = ServiceDetails.Description
            Dim strSubItem() = strPartsDetails.Split("|")

            For Each strItem As String In strSubItem


                Dim strSubItem1() As String = strItem.Split(",")
                If Not String.IsNullOrEmpty(strSubItem1(0)) Then
                    If strSubItem1(0).Length >= 7 Then


                        If strSubItem1(0).Substring(0, 7).ToLower = LCase("Remarks") Then

                            strSubItem1(0) = strSubItem1(0).Substring(8, strSubItem1(0).Length - 8)
                            txtRemarks.Text = strSubItem1(0)
                            chkRemarks.Checked = True

                        Else

                            lstViewItem = lstPartsDetails.Items.Add(lstPartsDetails.Items.Count + 1)

                            lstViewItem.SubItems.Add(strSubItem1(0))

                            lstViewItem.SubItems.Add(strSubItem1(1))
                            lstViewItem.SubItems.Add(String.Empty)

                            lstViewItem.SubItems.Add(strSubItem1(2))
                            lstViewItem.SubItems.Add(strSubItem1(3))
                            lstViewItem.SubItems.Add(Integer.Parse(strSubItem1(2)) * Integer.Parse(strSubItem1(3)))
                            lblTotalParts.Text += Convert.ToInt32(lstViewItem.SubItems(6).Text)


                            lstViewItem.SubItems(0).Tag = "Sl"
                            lstViewItem.SubItems(1).Tag = "Part No"
                            lstViewItem.SubItems(2).Tag = "Description"
                            lstViewItem.SubItems(3).Tag = "Measure"
                            lstViewItem.SubItems(4).Tag = "Qty"
                            lstViewItem.SubItems(5).Tag = "UnitPrice"
                            lstViewItem.SubItems(6).Tag = "Total"
                        End If
                    Else
                        lstViewItem = lstPartsDetails.Items.Add(lstPartsDetails.Items.Count + 1)

                        lstViewItem.SubItems.Add(strSubItem1(0))

                        lstViewItem.SubItems.Add(strSubItem1(1))
                        lstViewItem.SubItems.Add(String.Empty)

                        lstViewItem.SubItems.Add(strSubItem1(2))
                        lstViewItem.SubItems.Add(strSubItem1(3))
                        lstViewItem.SubItems.Add(Integer.Parse(strSubItem1(2)) * Integer.Parse(strSubItem1(3)))
                        lblTotalParts.Text += Convert.ToInt32(lstViewItem.SubItems(6).Text)


                        lstViewItem.SubItems(0).Tag = "Sl"
                        lstViewItem.SubItems(1).Tag = "Part No"
                        lstViewItem.SubItems(2).Tag = "Description"
                        lstViewItem.SubItems(3).Tag = "Measure"
                        lstViewItem.SubItems(4).Tag = "Qty"
                        lstViewItem.SubItems(5).Tag = "UnitPrice"
                        lstViewItem.SubItems(6).Tag = "Total"
                    End If
                End If
            Next


            If Employee.Count > 0 Then
                For Each E As clsPersonal In Employee
                    cmbServiceby.Text = E.EmpCode
                    lblTechnicianName.Text = E.EmpName
                    dtpServiceDate.Value = publicClaiminfo.SDate

                Next
            Else
                cmbServiceby.Text = claiminfo.ServiceBy
                lblTechnicianName.Text = "'Technician Code' Not Found"

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source)

        End Try

    End Sub


    Private Function isEmptyRecord() As Boolean
        Dim blnFlag As Boolean = False

        If chkRemarks.Checked = True Then

            If txtRemarks.Text.Length > 0 Then
                blnFlag = True
            End If
        End If

        If lstPartsDetails.Items.Count > 0 Then
            blnFlag = True
        End If


        Return blnFlag

    End Function

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click

        Dim EstmateRefuse As clsEstimateRefusedMethods = New clsEstimateRefusedMethods
        Dim ER As clsEstimateRefused = EstmateRefuse.GetEstimateRefuse(publicClaiminfo.Jobcode)



        If isEmptyRecord() = False Then
            MessageBox.Show("No Record found to Save")
            txtPartNo.Select()
            Exit Sub
        End If

        'If Not IsNothing(ActiveUser) Then
        '    If publicClaiminfo.cFlag = 0 Or publicClaiminfo.cFlag = 2 Or publicClaiminfo.cFlag = 100 Or publicClaiminfo.cFlag = 102 Then
        '        If ActiveUser.UserType.ToLower = LCase("Admin") Then
        '            If chkSaveByForce.Checked = False Then
        '                MessageBox.Show("The Product is already 'Delivered on Date " & publicClaiminfo.DDate & vbNewLine & "' You can not save untli tick 'Save by Force'")
        '                Exit Sub
        '            End If
        '        Else

        '            MessageBox.Show("The Product is already 'Delivered on Date " & publicClaiminfo.DDate & vbNewLine & "' Only 'Admin User Can Edit/Update'")
        '            Exit Sub

        '        End If
        '    ElseIf publicClaiminfo.cFlag = 1 And IsNothing(ER.JobCode) Then
        '        If ActiveUser.UserType.ToLower = LCase("Admin") Then
        '            If chkSaveByForce.Checked = False Then
        '                MessageBox.Show("The Product is already 'Repaired on Date " & publicClaiminfo.SDate & vbNewLine & "' You can not save untli tick 'Save by Force'")
        '                Exit Sub
        '            End If
        '        Else

        '            MessageBox.Show("The Product is already 'Repaired on Date " & publicClaiminfo.SDate & vbNewLine & "' Only 'Admin User Can Edit/Update'")
        '            Exit Sub

        '        End If
        '    End If

        '    If ActiveUser.UserType.ToLower = LCase("user") Then

        '        If ActiveUser.Ins = False Then
        '            MessageBox.Show("You are permitted to save Data", "Save Failed", MessageBoxButtons.OK)
        '            Exit Sub

        '        End If

        '    End If

        'End If


        Dim empMethods As clsPersonalMethods = New clsPersonalMethods
        Dim empList As List(Of clsPersonal) = empMethods.LoadTechnician(cmbServiceby.Text).ToList

        If empList.Count <> 1 Then
            MessageBox.Show("Code is not found in the datavase")
            Exit Sub
        ElseIf DateTime.Compare(dtpServiceDate.Value.ToShortDateString, publicClaiminfo.ReceptDate.ToShortDateString) = -1 Then
            MessageBox.Show("Receive Date is Greater Than Repair Date ")
            Exit Sub
        End If


        If intSavingMode = 1 Then ' Parts Option
            SaveParts(False)
        ElseIf intSavingMode = 2 Then ' Remarks Option

            SaveRemarks(False)
        End If
    End Sub


    Private Sub SaveParts(ByVal blnSendMail As Boolean)

        Dim claiminfmethods As clsClaiminfoMethods = New clsClaiminfoMethods
        Dim claiminfo As clsClaiminfo = New clsClaiminfo
        Dim servicedetailsmethods As clsServiceDetailsMethods = New clsServiceDetailsMethods
        Dim servicedetails As clsServiceDetails = New clsServiceDetails
        Dim pending As clsPendingMethods = New clsPendingMethods
        Dim VerifyPendingJob As clsPending = pending.GetPending(publicClaiminfo.Jobcode)
        Dim NRDetails As clsNrdetailsMethods = New clsNrdetailsMethods
        Dim verifyNRDetailsJob As clsNrdetails = NRDetails.GetNR(publicClaiminfo.Jobcode)
        Dim EstmateRefuse As clsEstimateRefusedMethods = New clsEstimateRefusedMethods
        Dim Replace As clsReplaceMethods = New clsReplaceMethods
        Dim ER As clsEstimateRefused = EstmateRefuse.GetEstimateRefuse(publicClaiminfo.Jobcode)

        Dim cFlag As String = String.Empty
        Dim MrNo As String = String.Empty
        Dim strProductDescription As String = String.Empty




        Try
            Dim listServiceDetails As List(Of clsServiceDetails) = New List(Of clsServiceDetails)



            For Each tempListItem As ListViewItem In lstPartsDetails.Items
                Dim PartsTemp As clsServiceDetails = New clsServiceDetails

                PartsTemp.Jobcode = publicClaiminfo.Jobcode
                PartsTemp.ProductCode = tempListItem.SubItems(1).Text
                PartsTemp.Qty = tempListItem.SubItems(4).Text
                PartsTemp.UnitPrice = tempListItem.SubItems(5).Text

                listServiceDetails.Add(PartsTemp)

                For Each lstSubitem As ListViewItem.ListViewSubItem In tempListItem.SubItems
                    If lstSubitem.Tag.ToString.ToLower <> LCase("sl") Then
                        If lstSubitem.Tag.ToString.ToLower <> LCase("Measure") Then
                            If lstSubitem.Tag.ToString.ToLower <> LCase("Total") Then
                                If lstSubitem.Tag.ToString.ToLower = LCase("Description") Then
                                    strProductDescription += RemoveComma(lstSubitem.Text) & ","
                                Else
                                    strProductDescription += lstSubitem.Text & ","
                                End If

                            End If

                        End If

                    End If
                Next

                If Not String.IsNullOrEmpty(Trim(strProductDescription)) Then
                    If strProductDescription.Substring(strProductDescription.Length - 1) = "," Then
                        strProductDescription = strProductDescription.Substring(0, strProductDescription.Length - 1)
                        strProductDescription = strProductDescription & "|"
                    End If
                Else
                    MessageBox.Show("Remarks and Parts list is blank")
                    Exit Sub
                End If

            Next





            claiminfo = publicClaiminfo
            Dim strJobCode As String = String.Empty
            strJobCode = claiminfo.Jobcode

            servicedetails.Jobcode = strJobCode
            servicedetails.Description = strProductDescription





            cFlag = claiminfo.cFlag
            MrNo = claiminfo.MRNO




            claiminfo.SDate = dtpServiceDate.Value.ToShortDateString
            claiminfo.ServiceBy = cmbServiceby.Text

            If Not (claiminfo.cFlag = 0 Or claiminfo.cFlag = 2) Then
                If claiminfo.WCondition = 0 Or claiminfo.WCondition = 2 Then ' ' Check Prooduct Sales Warranty or Non Warranty
                    claiminfo.PrdAmt = 0
                Else
                    claiminfo.PrdAmt = Integer.Parse(lblTotalParts.Text)
                End If
            Else
                claiminfo.PrdAmt = Integer.Parse(lblTotalParts.Text)
            End If

            If cFlag = 0 Then ' Check Prooduct Delivered or Repaired Condition
                claiminfo.cFlag = Integer.Parse("0")
            ElseIf cFlag = 2 Then
                claiminfo.cFlag = Integer.Parse("2")

            Else
                claiminfo.cFlag = Integer.Parse("1")
                claiminfo.MRNO = String.Empty
            End If

            claiminfmethods.updateclaiminfo(claiminfo, publicClaiminfo.Jobcode)



            Dim verifyJob As clsServiceDetails = servicedetailsmethods.GetPartsDetails(servicedetails.Jobcode)


            If IsNothing(verifyJob.Jobcode) Then
                servicedetailsmethods.save(servicedetails)
                MessageBox.Show("Record Save Succesfully")
            Else
                servicedetailsmethods.Update(servicedetails, strJobCode)
                MessageBox.Show("Record Update Succesfully")
            End If

            If isExist(publicClaiminfo.Jobcode) = True Then
                Delete(publicClaiminfo.Jobcode)
            End If
            SaveServiceDetailsDetails(listServiceDetails)

            If Not IsNothing(VerifyPendingJob.JobCode) Then
                pending.Delete(VerifyPendingJob.JobCode)
            End If

            If Not IsNothing(verifyNRDetailsJob.JobCode) Then
                NRDetails.Delete(verifyNRDetailsJob.JobCode)
            End If
            If Not IsNothing(ER.JobCode) Then
                EstmateRefuse.Delete(ER.JobCode)
            End If




            Dim mailOption As clsOptionMethods = New clsOptionMethods


            If mailOption.IsExistMail = True Then
                If mailOption.IsMailActive = True Then
                    If blnSendMail = True Then
                        SendMail()
                    End If
                End If
            Else

                If MessageBox.Show("Mail is not active", "Do you want set mail", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                    Dim optionForm As frmOption = New frmOption


                    optionForm.strTabName = "Mail"
                    optionForm.ShowDialog()
                    SendMail()

                End If

            End If






            Me.Close()

            Exit Sub




        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString & " Invalid Email")
            Me.Close()
        End Try






    End Sub


    Private Function RemoveComma(ByVal searchComma As String)
        Dim strGetValaue As String = String.Empty

        For Each S As String In searchComma

            If S = "," Then
                strGetValaue += "-"
            Else
                strGetValaue += S
            End If

        Next

        Return strGetValaue
    End Function


    Private Sub SendMail()
        Dim intServiceCharge As Integer = 0
        Dim strBody As String = String.Empty


        Dim mailMethods As clsOptionMethods = New clsOptionMethods
        Dim mail As clsOption = mailMethods.GetActiveMail
        Dim aMail As clsMail = New clsMail 'aMail = Active Mail

        Dim security As clsSecurity = New clsSecurity





        Dim myNetwork As clsNetwork = New clsNetwork




        If IsNothing(mail.MailFrom) Then
            Exit Sub
        Else
            aMail.MailID = mail.MailFrom
            aMail.Password = mail.Crediantial
            aMail.SMTP = mail.SMTP
            aMail.PORT = mail.Port
            aMail.SSL = mail.SSL

            aMail.MailTo = publicClaiminfo.Email.ToString

        End If


        If myNetwork.VerifyMail(security.Decrypt(mail.MailFrom)) = False Then

            MessageBox.Show("Invalid Sending Mail")
            Me.Close()
            Exit Sub
        End If




        If myNetwork.VerifyMail(aMail.MailTo) = False Then
            MessageBox.Show("Invalid Mail  'Check Customer Email")
            Me.Close()
            Exit Sub
        End If

        aMail.From = mail.MailFrom




        If publicClaiminfo.WCondition = 1 Then
            If Integer.TryParse(InputBox("", "Enter Service Charge", "0"), intServiceCharge) = False Then
                intServiceCharge = Integer.Parse("0")
            End If


            strBody = "Dear Sir/Madam" & vbCrLf
            strBody = strBody & publicClaiminfo.CustName & vbNewLine
            strBody = strBody & " Your Product Is Ready for Delivery (" & vbNewLine
            strBody = strBody & "Job No: '" & publicClaiminfo.Jobcode & "'," & vbNewLine
            strBody = strBody & "Delivery Branch: '" & publicClaiminfo.Branch & "'," & vbNewLine
            strBody = strBody & " Mailing Date : " & Now() & vbNewLine
            strBody = strBody & " Type of Warranty : Non Warranty" & vbNewLine
            strBody = strBody & " Product Status : Repaired" & vbNewLine
            strBody = strBody & ", Amount of Parts : ' " & lblTotalParts.Text & "')" & vbNewLine
            strBody = strBody & ", Repaired Charge : ' " & intServiceCharge & "')" & vbNewLine
            strBody = strBody & ", Total Amount : ' " & Integer.Parse(lblTotalParts.Text) + intServiceCharge & "')"




        Else


            strBody = "Dear Sir/Madam" & vbNewLine
            strBody = strBody & publicClaiminfo.CustName & vbNewLine
            strBody = strBody & " Your Product Is Ready for Delivery (" & vbNewLine
            strBody = strBody & "Job No: '" & publicClaiminfo.Jobcode & "'," & vbNewLine
            strBody = strBody & "Delivery Branch: '" & publicClaiminfo.Branch & "'," & vbNewLine
            If publicClaiminfo.WCondition = 0 Then
                strBody = strBody & " Type of Warranty : Sales Warranty" & vbNewLine
            Else
                strBody = strBody & " Type of Warranty : Service Warranty" & vbNewLine
            End If

            strBody = strBody & " Mailing Date : " & Now() & ")"


        End If


        aMail.Body = strBody
        aMail.Subject = "Prduct Service"



        With myNetwork
            If .isInternet = True Then
                .SendMail(aMail)
            Else
                MessageBox.Show("Mail is not sent due to 'Internet connection failur'")
            End If


        End With
    End Sub
    Private Sub SaveRemarks(ByVal blnSendMail As Boolean)
        Dim claiminfmethods As clsClaiminfoMethods = New clsClaiminfoMethods
        Dim claiminfo As clsClaiminfo = New clsClaiminfo
        Dim servicedetailsmethods As clsServiceDetailsMethods = New clsServiceDetailsMethods
        Dim servicedetails As clsServiceDetails = New clsServiceDetails
        Dim verifyServiceDetails As clsServiceDetails = servicedetailsmethods.GetPartsDetails(publicClaiminfo.Jobcode)
        Dim pending As clsPendingMethods = New clsPendingMethods
        Dim VerifyPendingJob As clsPending = pending.GetPending(publicClaiminfo.Jobcode)
        Dim NRDetails As clsNrdetailsMethods = New clsNrdetailsMethods
        Dim verifyNRDetails As clsNrdetails = NRDetails.GetNR(publicClaiminfo.Jobcode)
        Dim EstmateRefuse As clsEstimateRefusedMethods = New clsEstimateRefusedMethods
        Dim verifyER As clsEstimateRefused = EstmateRefuse.GetEstimateRefuse(publicClaiminfo.Jobcode)
        Dim Replace As clsReplaceMethods = New clsReplaceMethods



        Dim cFlag As String = String.Empty
        Dim MrNo As String = String.Empty
        Dim strProductDescription As String = String.Empty




        Try

            Dim listServiceDetails As List(Of clsServiceDetails) = New List(Of clsServiceDetails)

            Dim PartsTemp As clsServiceDetails = New clsServiceDetails


            strProductDescription = txtRemarks.Text
            If Not String.IsNullOrEmpty(strProductDescription.Trim) Then
                PartsTemp.Jobcode = publicClaiminfo.Jobcode
                PartsTemp.ProductCode = 0
                PartsTemp.Qty = 0
                PartsTemp.UnitPrice = 0
                PartsTemp.Remarks = strProductDescription

                strProductDescription = "Remarks:" & RemoveCommafromText(strProductDescription)

            End If
            listServiceDetails.Add(PartsTemp)




            claiminfo = publicClaiminfo


            Dim strJobCode As String = String.Empty

            strJobCode = claiminfo.Jobcode

            servicedetails.Jobcode = strJobCode
            servicedetails.Description = strProductDescription & "|"







            cFlag = claiminfo.cFlag
            MrNo = claiminfo.MRNO




            claiminfo.SDate = dtpServiceDate.Value.ToShortDateString
            claiminfo.ServiceBy = cmbServiceby.Text


            If Not (claiminfo.cFlag = 0 Or claiminfo.cFlag = 2) Then
                If claiminfo.WCondition = 0 Or claiminfo.WCondition = 2 Then ' ' Check Prooduct Sales Warranty or Non Warranty
                    claiminfo.PrdAmt = 0
                Else
                    claiminfo.PrdAmt = Integer.Parse(lblTotalParts.Text)
                End If
            Else
                claiminfo.PrdAmt = Integer.Parse(lblTotalParts.Text)
            End If

            If cFlag = 0 Then
                claiminfo.cFlag = Integer.Parse("0")
            ElseIf cFlag = 2 Then
                claiminfo.cFlag = Integer.Parse("2")

            Else
                claiminfo.cFlag = Integer.Parse("1")
                claiminfo.MRNO = String.Empty
            End If

            claiminfmethods.updateclaiminfo(claiminfo, publicClaiminfo.Jobcode)



            If IsNothing(verifyServiceDetails.Jobcode) Then
                servicedetailsmethods.save(servicedetails)
                MessageBox.Show("Record Save Succesfully")
            Else
                servicedetailsmethods.Update(servicedetails, strJobCode)
                MessageBox.Show("Record Update Succesfully")


            End If

            If isExist(publicClaiminfo.Jobcode) = True Then
                Delete(publicClaiminfo.Jobcode)
            End If
            SaveServiceDetailsDetails(listServiceDetails)

            If Not IsNothing(VerifyPendingJob.JobCode) Then
                pending.Delete(VerifyPendingJob.JobCode)
            End If

            If Not IsNothing(verifyNRDetails.JobCode) Then
                NRDetails.Delete(verifyNRDetails.JobCode)
            End If

            If Not IsNothing(verifyER.JobCode) Then
                EstmateRefuse.Delete(verifyER.JobCode)
            End If

            If blnSendMail = True Then
                SendMail()
            End If
            Me.Close()








        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Message")
            Me.Close()
        End Try

    End Sub





    Private Sub cmbServiceby_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbServiceby.SelectedIndexChanged
        TechnicianName(cmbServiceby.Text, lblTechnicianName)

    End Sub




    Private Sub frmProductEntry_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        ResizeControl(Me, cmdSave, 0, 3)
        ResizeControl(Me, cmdSaveAndMail, cmdSave.Left + cmdSave.Width, 3)
        ResizeControl(Me, cmdClose, cmdSaveAndMail.Left + cmdSaveAndMail.Width, 3)

    End Sub




    Private Sub getIssueDate()

        Dim drIssuedate As OleDbDataReader = Nothing
        Dim conIssuedate As New OleDbConnection(strProvider)


        LoadAllInformation(conIssuedate, drIssuedate, strProvider, "Claiminfo", "Claiminfo.IsssueDate", "Claiminfo.JobCOde='" & strtmpJobCode & "'")

            If drIssuedate.HasRows = True Then
            While drIssuedate.Read
                dtIssueDate = Convert.ToDateTime(drIssuedate("IsssueDate").ToString).ToShortDateString
            End While
        End If






    End Sub

    Private Sub frmProductEntry_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        dtIssueDate = Convert.ToDateTime("01-01-01").ToShortDateString

        Dispose(sngPartsAmount)
    End Sub


    Private Sub lstPartsDetails_DoubleClick(sender As Object, e As EventArgs) Handles lstPartsDetails.DoubleClick
        If lstPartsDetails.Items.Count > 0 Then
            If MsgBox("do you want to delete", vbYesNo, "Delete Record") = vbYes Then
                lstPartsDetails.FocusedItem.Remove()
                Getpartsamount()
            End If

        End If


    End Sub



    Private Sub txtQty_Leave(sender As Object, e As EventArgs) Handles txtQty.Leave

    End Sub

    Private Function PriceValidation(ByRef ValdationMessage) As Boolean

        Dim intqty As Double
        PriceValidation = True
        If Integer.TryParse(txtQty.Text, intqty) = False Then
            ValdationMessage = "Qty"
            PriceValidation = False
            Exit Function

        End If


        Dim intunitprice As Double

        If Integer.TryParse(txtUnitPrice.Text, intunitprice) = False Then
            ValdationMessage = "Price"
            PriceValidation = False
            Exit Function

        End If

    End Function


    Private Sub txtUnitPrice_Leave(sender As Object, e As EventArgs) Handles txtUnitPrice.Leave

    End Sub

    Private Sub txtQty_TextChanged(sender As Object, e As EventArgs) Handles txtQty.TextChanged

    End Sub

    Private Sub lstProductList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstProductList.SelectedIndexChanged

    End Sub

    Private Sub txtPartNo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPartNo.KeyDown
        If e.KeyCode = Keys.Down Then
            If lstProductList.Visible = True Then
                lstProductList.Select()
                lstProductList.Items(0).Selected = True
                lblPartNo.Text = lstProductList.SelectedItems(0).SubItems(1).Text
                lblDescription.Text = lstProductList.SelectedItems(0).SubItems(2).Text
                lblMeasure.Text = lstProductList.SelectedItems(0).SubItems(3).Text
                txtUnitPrice.Text = lstProductList.SelectedItems(0).SubItems(4).Text
            End If
        End If
    End Sub



    Public Sub Delete(ByVal DeleteCriteria As String)

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim strDeleteQuery As String = "Delete * from ServiceDetailsDetails where ServiceDetailsDetails.JobCode=@JobCode"
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcSaveService As OleDbCommand = New OleDbCommand(strDeleteQuery, con)
            dcSaveService.CommandType = CommandType.Text
            dcSaveService.Parameters.Add("@JobCode", OleDbType.Char, 255).Value = DeleteCriteria

            con.Open()
            dcSaveService.ExecuteNonQuery()




        End Using

    End Sub

    Private Sub SaveServiceDetailsDetails(ByVal ServiceDetailsList As List(Of clsServiceDetails))
        If ServiceDetailsList.Count > 0 Then
            For Each serviceDetails As clsServiceDetails In ServiceDetailsList
                Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
                Dim strSqlQuery As String = String.Empty
                strSqlQuery = "Insert Into ServiceDetailsDetails(JobCode,ProductCode,Qty,UnitPrice,Remarks) Values(@JobCode,@ProductCode,@Qty,@UnitPrice,@Remarks)"
                Using con As OleDbConnection = New OleDbConnection(cs)
                    Dim dcSaveService As OleDbCommand = New OleDbCommand(strSqlQuery, con)
                    dcSaveService.CommandType = CommandType.Text
                    dcSaveService.Parameters.Add("@JobCode", OleDbType.Char, 255).Value = serviceDetails.Jobcode
                    dcSaveService.Parameters.Add("@ProductCode", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(serviceDetails.ProductCode.Trim), DBNull.Value, serviceDetails.ProductCode)
                    dcSaveService.Parameters.Add("@Qty", OleDbType.Double).Value = If(String.IsNullOrEmpty(serviceDetails.Qty), DBNull.Value, serviceDetails.Qty)
                    dcSaveService.Parameters.Add("@UnitPrice", OleDbType.Double).Value = If(String.IsNullOrEmpty(serviceDetails.UnitPrice), DBNull.Value, serviceDetails.UnitPrice)
                    dcSaveService.Parameters.Add("@Remarks", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(serviceDetails.Remarks), DBNull.Value, serviceDetails.Remarks)
                    con.Open()
                    dcSaveService.ExecuteNonQuery()
                End Using
            Next
        End If
    End Sub


    Private Sub UpdateServiceDetailsDetails(ByVal ServiceDetailsList As List(Of clsServiceDetails), ByVal UpdateCriteria As clsServiceDetails)
        If ServiceDetailsList.Count > 0 Then
            For Each serviceDetails As clsServiceDetails In ServiceDetailsList
                Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
                Dim strSqlQuery As String = String.Empty
                strSqlQuery = "Update ServiceDetailsDetails set JobCode=@JobCode,ProductCode=@ProductCode,Qty=@Qty,UnitPrice=@UnitPrice,Remarks=@Remarks where JobCode=@JobCode1 and ProductCode=@ProductCode1"
                Using con As OleDbConnection = New OleDbConnection(cs)
                    Dim dcSaveService As OleDbCommand = New OleDbCommand(strSqlQuery, con)
                    dcSaveService.CommandType = CommandType.Text
                    dcSaveService.Parameters.Add("@JobCode", OleDbType.Char, 255).Value = serviceDetails.Jobcode
                    dcSaveService.Parameters.Add("@ProductCode", OleDbType.Char, 255).Value = serviceDetails.ProductCode
                    dcSaveService.Parameters.Add("@Qty", OleDbType.Double).Value = serviceDetails.Qty
                    dcSaveService.Parameters.Add("@UnitPrice", OleDbType.Double).Value = serviceDetails.UnitPrice
                    dcSaveService.Parameters.Add("@JobCode1", OleDbType.Char, 255).Value = UpdateCriteria.Jobcode
                    dcSaveService.Parameters.Add("@ProductCode1", OleDbType.Char, 255).Value = UpdateCriteria.ProductCode
                    con.Open()
                    dcSaveService.ExecuteNonQuery()
                End Using
            Next
        End If
    End Sub



    Private Function isExist(ByVal CheckID As String) As Boolean

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim strSqlQuery As String = String.Empty
        strSqlQuery = "Select * from ServiceDetailsDetails where ServiceDetailsDetails.JobCode=@JobCode"
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcSaveService As OleDbCommand = New OleDbCommand(strSqlQuery, con)
            dcSaveService.CommandType = CommandType.Text
            dcSaveService.Parameters.Add("@JobCode", OleDbType.Char, 255).Value = CheckID
            con.Open()
            Dim drExist As OleDbDataReader = dcSaveService.ExecuteReader

            If drExist.HasRows = True Then
                Return True
            End If
            Return False
        End Using

    End Function

    Private Sub cmbServiceby_KeyUp(sender As Object, e As KeyEventArgs) Handles cmbServiceby.KeyUp
        If e.KeyCode = Keys.Enter Then
            dtpServiceDate.Select()

        End If
    End Sub

    Private Sub dtpServiceDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpServiceDate.ValueChanged

    End Sub

    Private Sub dtpServiceDate_KeyUp(sender As Object, e As KeyEventArgs) Handles dtpServiceDate.KeyUp
        If e.KeyCode = Keys.Enter Then
            cmbServiceby.Select()

        End If
    End Sub

    Private Sub cmdSaveAndMail_Click(sender As Object, e As EventArgs) Handles cmdSaveAndMail.Click

        Dim EstmateRefuse As clsEstimateRefusedMethods = New clsEstimateRefusedMethods
        Dim ER As clsEstimateRefused = EstmateRefuse.GetEstimateRefuse(publicClaiminfo.Jobcode)




        If isEmptyRecord() = False Then
            MessageBox.Show("No Record found to Save")
            txtPartNo.Select()
            Exit Sub
        End If

        'If Not IsNothing(ActiveUser) Then
        '    If publicClaiminfo.cFlag = 0 Or publicClaiminfo.cFlag = 2 Or publicClaiminfo.cFlag = 100 Or publicClaiminfo.cFlag = 102 Then
        '        If ActiveUser.UserType.ToLower = LCase("Admin") Then
        '            If chkSaveByForce.Checked = False Then
        '                MessageBox.Show("The Product is already 'Delivered on Date " & publicClaiminfo.DDate & vbNewLine & "' You can not save untli tick 'Save by Force'")
        '                Exit Sub
        '            End If
        '        Else

        '            MessageBox.Show("The Product is already 'Delivered on Date " & publicClaiminfo.DDate & vbNewLine & "' Only 'Admin User Can Edit/Update'")
        '            Exit Sub

        '        End If
        '    ElseIf publicClaiminfo.cFlag = 1 And IsNothing(ER.JobCode) Then
        '        If ActiveUser.UserType.ToLower = LCase("Admin") Then
        '            If chkSaveByForce.Checked = False Then
        '                MessageBox.Show("The Product is already 'Repaired on Date " & publicClaiminfo.SDate & vbNewLine & "' You can not save untli tick 'Save by Force'")
        '                Exit Sub
        '            End If
        '        Else

        '            MessageBox.Show("The Product is already 'Repaired on Date " & publicClaiminfo.SDate & vbNewLine & "' Only 'Admin User Can Edit/Update'")
        '            Exit Sub

        '        End If
        '    End If

        '    If ActiveUser.UserType.ToLower = LCase("user") Then

        '        If ActiveUser.Ins = False Then
        '            MessageBox.Show("You are permitted to save Data", "Save Failed", MessageBoxButtons.OK)
        '            Exit Sub

        '        End If

        '    End If

        'End If


        Dim empMethods As clsPersonalMethods = New clsPersonalMethods
        Dim empList As List(Of clsPersonal) = empMethods.LoadTechnician(cmbServiceby.Text).ToList

        If empList.Count <> 1 Then
            MessageBox.Show("Code is not found in the datavase")
            Exit Sub
        ElseIf DateTime.Compare(dtpServiceDate.Value.ToShortDateString, publicClaiminfo.ReceptDate.ToShortDateString) = -1 Then
            MessageBox.Show("Receive Date is Greater Than Repair Date ")
            Exit Sub
        End If


        If intSavingMode = 1 Then ' Save in ServiceDetails  Code, Description, Qty, Amount (Parts Option)
            SaveParts(True)
        ElseIf intSavingMode = 2 Then ' Save in ServiceDetails Remarks Field

            SaveRemarks(True)
        End If
    End Sub

    Private Sub lstProductList_DoubleClick(sender As Object, e As EventArgs) Handles lstProductList.DoubleClick

    End Sub

    Private Sub lstProductList_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lstProductList.MouseDoubleClick
        Dim lstItem As ListViewItem = GetSeletedItem()

        If Not lstItem Is Nothing Then
            lblPartNo.Text = lstItem.SubItems(1).Text
            lblDescription.Text = lstItem.SubItems(2).Text
            txtUnitPrice.Text = lstItem.SubItems(4).Text
            txtQty.Select()
            lstProductList.Visible = False
            txtPartNo.Text = ""
            txtDescription.Text = ""
        End If


    End Sub

    Private Sub lstProductList_MouseClick(sender As Object, e As MouseEventArgs) Handles lstProductList.MouseClick
        Dim lstItem As ListViewItem = GetSeletedItem()

        If Not lstItem Is Nothing Then
            lblPartNo.Text = lstItem.SubItems(1).Text
            lblDescription.Text = lstItem.SubItems(2).Text
            txtUnitPrice.Text = lstItem.SubItems(4).Text
        End If
    End Sub


    Private Function GetSeletedItem() As ListViewItem
        Dim lstgetItem As ListViewItem = Nothing
        If lstProductList.Items.Count > 0 Then


            lstgetItem = lstProductList.FocusedItem            'lstProductList.HitTest(e.Location).Item







        End If
        GetSeletedItem = lstgetItem

    End Function
End Class
