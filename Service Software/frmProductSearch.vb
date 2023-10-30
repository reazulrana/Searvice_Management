Imports System.Data
Imports System.Data.OleDb
Imports System.Reflection
Imports Microsoft.Office.Interop


Public Class frmproductsearch

    Dim FOp As String
    Dim SOp As String
    Dim TOp As String
    Dim FrOp As String

    Private Sub frmproductsearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            ResizeForm(Me, False)
            lstSearchField.CheckBoxes = True
            lstSearchField.View = View.Details

            optProduct.Checked = True

            AddOperator()
            'SelectSearchField()




        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub




    Private Function reverseCashsales(ByVal value As String) As String

        Dim strRCashSales = String.Empty



        Select Case value.ToLower


            Case LCase("JobID")
                strRCashSales = "JobID"
            Case LCase("MRNO")
                strRCashSales = "MRNO"
            Case LCase("JobCOde")
                strRCashSales = "JobCode"
            Case LCase("Branch")
                strRCashSales = "Branch"
            Case LCase("CustName")
                strRCashSales = "CustName"
            Case LCase("CustAddress1")
                strRCashSales = "CustAddress1"
            Case LCase("CustAddress2")
                strRCashSales = "CustAddress2"
            Case LCase("Brand")
                strRCashSales = "Brand"
            Case LCase("ModelNo")
                strRCashSales = "ModelNo"
            Case LCase("ESN")
                strRCashSales = "ESN"
            Case LCase("SLNo")
                strRCashSales = "SLNo"
            Case LCase("ReceptDate")
                strRCashSales = "ReceptDate"
            Case LCase("ReceptBy")
                strRCashSales = "ReceptBy"
            Case LCase("Code")
                strRCashSales = "Code"
            Case LCase("ProdName")
                strRCashSales = "ProdName"
            Case LCase("Rate")
                strRCashSales = "Rate"
            Case LCase("Qty")
                strRCashSales = "Qty"
            Case LCase("Amount")
                strRCashSales = "Amount"
            Case LCase("PrdAmt")
                strRCashSales = "PrdAmt"
            Case LCase("Dis")
                strRCashSales = "Dis"
            Case LCase("NetAmnt")
                strRCashSales = "NetAmnt"
            Case LCase("Log_User")
                strRCashSales = "Log_User"
            Case LCase("Log_Date")
                strRCashSales = "Log_Date"
            Case LCase("DFlag")
                strRCashSales = "DFlag"
            Case LCase("Category")
                strRCashSales = "Category"

        End Select
        Return strRCashSales

    End Function
    Private Sub SelectSearchField()
        If cmbFirstCriteria.Items.Count > -1 Then
            cmbFirstCriteria.Text = cmbFirstCriteria.Items(0).ToString
        End If

        If cmbSecondCriteria.Items.Count > -1 Then
            cmbSecondCriteria.Text = cmbSecondCriteria.Items(0).ToString

        End If


        If cmbThirdCriteria.Items.Count > -1 Then
            cmbThirdCriteria.Text = cmbThirdCriteria.Items(0).ToString

        End If
        If cmbForthCriteria.Items.Count > -1 Then
            cmbForthCriteria.Text = cmbForthCriteria.Items(0).ToString
        End If

        If cmbFirstSearchOperator.Items.Count > -1 Then
            cmbFirstSearchOperator.Text = cmbFirstSearchOperator.Items(0).ToString

        End If

        If cmbSecondSearchOperator.Items.Count > -1 Then
            cmbSecondSearchOperator.Text = cmbSecondSearchOperator.Items(0).ToString

        End If
        If cmbThirdSearchOperator.Items.Count > -1 Then
            cmbThirdSearchOperator.Text = cmbThirdSearchOperator.Items(0).ToString

        End If
        If cmbForthSearchOperator.Items.Count > -1 Then
            cmbForthSearchOperator.Text = cmbForthSearchOperator.Items(0).ToString

        End If

    End Sub

    Private Sub loadCriteriaField()

        Dim DrLoadField As OleDbDataReader = Nothing

        Dim conLoadField As New OleDbConnection(strProvider)
        Dim strSQLLoadField As String = String.Empty
        Dim lstFieldLoad As ListViewItem = Nothing
        Dim strFieldName As String = String.Empty

        If optProduct.Checked = True Then
            strSQLLoadField = "Select * from Claiminfo"
        ElseIf optCashSales.Checked = True Then
            strSQLLoadField = "Select * from Cashsales"
        End If


        Dim dcLoadField As New OleDbCommand(strSQLLoadField, conLoadField)
        conLoadField.Open()
        DrLoadField = dcLoadField.ExecuteReader
        Dim intCount = 1
        lstSearchField.Items.Clear()
        If DrLoadField.HasRows = True Then
            While intCount <= DrLoadField.FieldCount - 1
                If optProduct.Checked = True Then
                    strFieldName = SelectValue(DrLoadField.GetName(intCount))
                Else
                    strFieldName = DrLoadField.GetName(intCount)
                End If

                cmbFirstCriteria.Items.Add(strFieldName)
                cmbSecondCriteria.Items.Add(strFieldName)
                cmbThirdCriteria.Items.Add(strFieldName)
                cmbForthCriteria.Items.Add(strFieldName)
                lstFieldLoad = lstSearchField.Items.Add(strFieldName)


                intCount = intCount + 1

            End While

        End If

        Dim strFieldArray(4) As String


        strFieldArray(1) = "Description"

        intCount = 0

        If optProduct.Checked = True Then

            cmbFirstCriteria.Items.Add("Description")
                cmbSecondCriteria.Items.Add("Description")
                cmbThirdCriteria.Items.Add("Description")
                cmbForthCriteria.Items.Add("Description")
                lstFieldLoad = lstSearchField.Items.Add("Description")
                intCount = intCount + 1

        End If



        TempConnectionDispose(conLoadField)



    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdDump.Click

        If dgvProductInformation.Rows.Count > 0 Then
            ExportDataIntoExcel(dgvProductInformation)
        Else
            MessageBox.Show("Data is not loaded")
        End If




    End Sub

    Private Sub frmproductsearch_Resize(sender As Object, e As EventArgs) Handles Me.Resize


        cmdDump.Top = Me.ClientSize.Height - (cmdDump.Height + 2)
        cmdClose.Top = cmdDump.Top
        cmdSearch.Top = cmdClose.Top






        cmdSearch.Left = lstSearchField.Left
        cmdSearch.Width = lstSearchField.Width
        grpSearchCriteria.Top = lblProductInformation.Top + lblProductInformation.Height + 2
        lstSearchField.Top = grpSearchCriteria.Top + grpSearchCriteria.Height + 2
        lstSearchField.Height = Me.ClientSize.Height - (lstSearchField.Top + cmdSearch.Height + 2)

        dgvProductInformation.Left = grpSearchCriteria.Left + grpSearchCriteria.Width + 2
        dgvProductInformation.Width = Me.ClientSize.Width - (grpSearchCriteria.Left + grpSearchCriteria.Width + 5)
        dgvProductInformation.Top = lblProductInformation.Top + lblProductInformation.Height + 8
        dgvProductInformation.Height = Me.ClientSize.Height - (dgvProductInformation.Top + cmdClose.Height + 2)
        cmdDump.Width = (dgvProductInformation.Width / 2) - 25
        cmdClose.Width = (dgvProductInformation.Width / 2) - 25
        cmdClose.Left = (dgvProductInformation.Left + dgvProductInformation.Width - cmdClose.Width)
        cmdDump.Left = cmdClose.Left - cmdClose.Width - 50


    End Sub



    Private Function SelectValue(ByVal strFieldName As String) As String
        Select Case strFieldName.ToLower
            Case LCase("JobCode")
                Return "Job Code"

            Case LCase("Branch")
                Return "Branch"

            Case LCase("CustName")
                Return "Customer Name"

            Case LCase("CustAddress1")
                Return "Customer Address"

            Case LCase("CustAddress2")
                Return "Customer Contact"


            Case LCase("Brand")
                Return "Brand"

            Case LCase("ModelNo")
                Return "Model"

            Case LCase("MobileNo")
                Return "Mobile"

            Case LCase("ESN")
                Return "ESN"

            Case LCase("SLNo")
                Return "Serial No"

            Case LCase("ReceptDate")
                Return "Receive Date"

            Case LCase("AppDelDate")
                Return "Approximate Delivery Date"


            Case LCase("ServiceType")
                Return "Category"


            Case LCase("PDate")
                Return "Purchase Date"

            Case LCase("ReceptBy")
                Return "Received By"

            Case LCase("IssueTo")
                Return "Assign to"

            Case LCase("IsssueDate")
                Return "Assign Date"

            Case LCase("SDate")
                Return "Repaired Date"

            Case LCase("ServiceBy")
                Return "Repaired By"

            Case LCase("DDate")
                Return "Delivery Date"

            Case LCase("DeliverBy")
                Return "Deliver By"

            Case LCase("WCondition")
                Return "Warranty Status"

            Case LCase("cFlag")
                Return "Product Status"
                'Modification on 28-02-2017
            Case LCase("SvAmt")
                Return "Service Charge"

            Case LCase("PrdAmt")
                Return "Product Amount"

            Case LCase("OtherAmt")
                Return "Other Charge"

            Case LCase("Dis")
                Return "Discount"

            Case LCase("SRFlag")
                Return "SRFlag"

            Case LCase("Remk")
                Return "cRemarks"

            Case LCase("PhyCond")
                Return "Physical Condition"

            Case LCase("Log_User")
                Return "Log_User"

            Case LCase("Log_Date")
                Return "Log_Date"

            Case LCase("MRNO")
                Return "Money Recept"

            Case LCase("LastJobNO")
                Return "LastJobNO"

            Case LCase("cAdvance")
                Return "cAdvance"

            Case LCase("cTransportCrg")
                Return "cTransportCrg"

            Case LCase("ReturnedItems")
                Return "Returned Items"

            Case LCase("ItemRemarks")
                Return "Item Remarks"

            Case LCase("FreeOfCost")
                Return "FreeOfCost"

            Case LCase("AdvanceAmnt")
                Return "Advance Amount"

            Case LCase("VatAmnt")
                Return "Vat Amount"
            Case LCase("Email")
                Return "Email"
            Case Else
                Return False

        End Select
        Return True

    End Function




    Private Function ReverseFieldName(ByVal strFieldName As String) As String
        Select Case strFieldName.ToLower
            Case LCase("Job Code")
                Return "JobCode"

            Case LCase("Branch")
                Return "Branch"

            Case LCase("Customer Name")
                Return "CustName"

            Case LCase("Customer Address")
                Return "CustAddress1"

            Case LCase("Customer Contact")
                Return "CustAddress2"


            Case LCase("Brand")
                Return "Brand"

            Case LCase("Model")
                Return "ModelNo"

            Case LCase("Mobile")
                Return "MobileNo"

            Case LCase("ESN")
                Return "ESN"

            Case LCase("Serial No")
                Return "SLNo"

            Case LCase("Receive Date")
                Return "ReceptDate"

            Case LCase("Approximate Delivery Date")
                Return "AppDelDate"


            Case LCase("Category")
                Return "ServiceType"


            Case LCase("Purchase Date")
                Return "PDate"

            Case LCase("Received By")
                Return "ReceptBy"

            Case LCase("Assign to")
                Return "IssueTo"

            Case LCase("Assign Date")
                Return "IsssueDate"

            Case LCase("Repaired Date")
                Return "SDate"

            Case LCase("Repaired By")
                Return "ServiceBy"

            Case LCase("Delivery Date")
                Return "DDate"

            Case LCase("Deliver By")
                Return "DeliverBy"

            Case LCase("Warranty Status")
                Return "WCondition"

            Case LCase("Product Status")
                Return "cFlag"
            Case LCase("Description")
                Return "Description"
                '________________________________________________________________________________
            Case LCase("Service Charge")
                Return "SvAmt"

            Case LCase("Product Amount")
                Return "PrdAmt"

            Case LCase("Other Charge")
                Return "OtherAmt"

            Case LCase("Discount")
                Return "Dis"

            Case LCase("SRFlag")
                Return "SRFlag"

            Case LCase("cRemarks")
                Return "Remk"

            Case LCase("Physical Condition")
                Return "PhyCond"

            Case LCase("Log_User")
                Return "Log_User"

            Case LCase("Log_Date")
                Return "Log_Date"

            Case LCase("Money Recept")
                Return "MRNO"

            Case LCase("LastJobNO")
                Return "LastJobNo"

            Case LCase("cAdvance")
                Return "cAdvance"

            Case LCase("cTransportCrg")
                Return "cTransportCrg"

            Case LCase("Returned Items")
                Return "ReturnedItems"

            Case LCase("Item Remarks")
                Return "ItemRemarks"

            Case LCase("FreeOfCost")
                Return "FreeOfCost"

            Case LCase("Advance Amount")
                Return "AdvanceAmnt"

            Case LCase("Vat Amount")
                Return "VatAmnt"
            Case LCase("Email")
                Return "Email"
            Case Else
                Return ""

        End Select
        Return True

    End Function




    Private Function RemoveAliasName(ByVal strFieldName As String) As String
        Select Case strFieldName.ToLower
            Case LCase("Job Code")
                Return "Claiminfo.JobCode"

            Case LCase("Branch")
                Return "Claiminfo.Branch"

            Case LCase("Customer Name")
                Return "Claiminfo.CustName"

            Case LCase("Customer Address")
                Return "Claiminfo.CustAddress1"

            Case LCase("Customer Contact")
                Return "Claiminfo.CustAddress2"


            Case LCase("Brand")
                Return "Claiminfo.Brand"

            Case LCase("Model")
                Return "Claiminfo.ModelNo"

            Case LCase("Mobile")
                Return "Claiminfo.MobileNo"

            Case LCase("ESN")
                Return "Claiminfo.ESN"

            Case LCase("Serial No")
                Return "Claiminfo.SLNo"

            Case LCase("Receive Date")
                Return "Claiminfo.ReceptDate"

            Case LCase("Approximate Delivery Date")
                Return "Claiminfo.AppDelDate"


            Case LCase("Category")
                Return "Claiminfo.ServiceType"


            Case LCase("Purchase Date")
                Return "Claiminfo.PDate"

            Case LCase("Received By")
                Return "Claiminfo.ReceptBy"

            Case LCase("Assign to")
                Return "Claiminfo.IssueTo"

            Case LCase("Assign Date")
                Return "Claiminfo.IsssueDate"

            Case LCase("Repaired Date")
                Return "Claiminfo.SDate"

            Case LCase("Repaired By")
                Return "Claiminfo.ServiceBy"

            Case LCase("Delivery Date")
                Return "Claiminfo.DDate"

            Case LCase("Deliver By")
                Return "Claiminfo.DeliverBy"

            Case LCase("WCondition")
                Return "Claiminfo.WCondition"

            Case LCase("Product Status")
                Return "Claiminfo.cFlag"


            Case LCase("Description")
                Return "ServiceDetails.Description"

                '________________________________________________________________________________________________
            Case LCase("Service Charge")
                Return "Claiminfo.SvAmt"

            Case LCase("Product Amount")
                Return "Claiminfo.PrdAmt"

            Case LCase("Other Charge")
                Return "Claiminfo.OtherAmt"

            Case LCase("Discount")
                Return "Claiminfo.Dis"

            Case LCase("SRFlag")
                Return "Claiminfo.SRFlag"

            Case LCase("cRemarks")
                Return "Claiminfo.Remk"

            Case LCase("Physical Condition")
                Return "Claiminfo.PhyCond"

            Case LCase("Log_User")
                Return "Claiminfo.Log_User"

            Case LCase("Log_Date")
                Return "Claiminfo.Log_Date"

            Case LCase("Money Recept")
                Return "Claiminfo.MRNO"

            Case LCase("LastJobNo")
                Return "Claiminfo.LastJobNo"

            Case LCase("cAdvance")
                Return "Claiminfo.cAdvance"

            Case LCase("cTransportCrg")
                Return "Claiminfo.cTransportCrg"

            Case LCase("Returned Items")
                Return "Claiminfo.ReturnedItems"

            Case LCase("Item Remarks")
                Return "Claiminfo.ItemRemarks"

            Case LCase("FreeOfCost")
                Return "Claiminfo.FreeOfCost"

            Case LCase("Advance Amount")
                Return "Claiminfo.AdvanceAmnt"

            Case LCase("Vat Amount")
                Return "Claiminfo.VatAmnt"
            Case Else
                Return ""

        End Select
        Return True

    End Function






    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click





        Dim conSearch As New OleDbConnection(strProvider)


        Try


            Dim strGetValue As String = String.Empty



            If optCashSales.Checked = True Then

                If Not String.IsNullOrEmpty(cmbFirstCriteria.Text) And Not String.IsNullOrEmpty(txtFirstCriteria.Text) Then
                    checkoperator(cmbFirstSearchOperator.Text)
                    If cmbFirstSearchOperator.Text.ToLower = LCase("Match Case") Then

                        strGetValue = strGetValue & reverseCashsales(cmbFirstCriteria.Text) & FOp.ToString & "'" & txtFirstCriteria.Text.ToString & "'" & " and "

                    Else

                        If CheckFieldDataType(cmbFirstCriteria.Text) = "Integer" Then
                            strGetValue = strGetValue & reverseCashsales(cmbFirstCriteria.Text) & FOp.ToString & Convert.ToInt32(txtFirstCriteria.Text.ToString) & " and "
                        ElseIf CheckFieldDataType(cmbFirstCriteria.Text) = "String" Then
                            strGetValue = strGetValue & reverseCashsales(cmbFirstCriteria.Text) & FOp.ToString & "'" & txtFirstCriteria.Text.ToString & "'" & " and "
                        Else
                            strGetValue = strGetValue & reverseCashsales(cmbFirstCriteria.Text) & FOp.ToString & "#" & txtFirstCriteria.Text.ToString & "#" & " and "
                        End If
                    End If

                End If



                If Not String.IsNullOrEmpty(cmbSecondCriteria.Text) And Not String.IsNullOrEmpty(txtSecondCriteria.Text) Then
                    checkoperator(cmbSecondSearchOperator.Text)
                    If cmbSecondSearchOperator.Text.ToLower = LCase("Match Case") Then

                        strGetValue = strGetValue & reverseCashsales(cmbSecondCriteria.Text) & FOp.ToString & "'" & txtSecondCriteria.Text.ToString & "'" & " and "
                    Else
                        If CheckFieldDataType(cmbSecondCriteria.Text) = "Integer" Then
                            strGetValue = strGetValue & reverseCashsales(cmbSecondCriteria.Text) & FOp.ToString & Convert.ToInt32(txtSecondCriteria.Text.ToString) & " and "
                        ElseIf CheckFieldDataType(cmbSecondCriteria.Text) = "String" Then
                            strGetValue = strGetValue & reverseCashsales(cmbSecondCriteria.Text) & FOp.ToString & "'" & txtSecondCriteria.Text.ToString & "'" & " and "
                        ElseIf CheckFieldDataType(cmbSecondCriteria.Text) = "Date" Then
                            strGetValue = strGetValue & reverseCashsales(cmbSecondCriteria.Text) & FOp.ToString & "#" & txtSecondCriteria.Text.ToString & "#" & " and "
                        End If
                    End If

                End If


                If Not String.IsNullOrEmpty(cmbThirdCriteria.Text) And Not String.IsNullOrEmpty(txtThirdCriteria.Text) Then
                    checkoperator(cmbThirdSearchOperator.Text)
                    If cmbThirdSearchOperator.Text.ToLower = LCase("Match Case") Then

                        strGetValue = strGetValue & reverseCashsales(cmbSecondCriteria.Text) & FOp.ToString & "'" & txtSecondCriteria.Text.ToString & "'" & " and "
                    Else
                        If CheckFieldDataType(cmbThirdCriteria.Text) = "Integer" Then
                            strGetValue = strGetValue & reverseCashsales(cmbThirdCriteria.Text) & FOp.ToString & Convert.ToInt32(txtThirdCriteria.Text.ToString) & " and "
                        ElseIf CheckFieldDataType(cmbThirdCriteria.Text) = "String" Then
                            strGetValue = strGetValue & reverseCashsales(cmbThirdCriteria.Text) & FOp.ToString & "'" & txtThirdCriteria.Text.ToString & "'" & " and "
                        ElseIf CheckFieldDataType(cmbThirdCriteria.Text) = "Date" Then
                            strGetValue = strGetValue & reverseCashsales(cmbThirdCriteria.Text) & FOp.ToString & "#" & txtThirdCriteria.Text.ToString & "#" & " and "
                        End If
                    End If
                End If



                If Not String.IsNullOrEmpty(cmbForthCriteria.Text) And Not String.IsNullOrEmpty(txtForthCriteria.Text) Then
                    checkoperator(cmbForthSearchOperator.Text)
                    If cmbForthSearchOperator.Text.ToLower = LCase("Match Case") Then

                        strGetValue = strGetValue & reverseCashsales(cmbForthCriteria.Text) & FOp.ToString & "'" & txtForthCriteria.Text.ToString & "'" & " and "
                    Else
                        If CheckFieldDataType(cmbForthCriteria.Text) = "Integer" Then
                            strGetValue = strGetValue & reverseCashsales(cmbForthCriteria.Text) & FOp.ToString & Convert.ToInt32(txtForthCriteria.Text.ToString) & " and "
                        ElseIf CheckFieldDataType(cmbForthCriteria.Text) = "String" Then
                            strGetValue = strGetValue & reverseCashsales(cmbForthCriteria.Text) & FOp.ToString & "'" & txtForthCriteria.Text.ToString & "'" & " and "
                        ElseIf CheckFieldDataType(cmbForthCriteria.Text) = "Date" Then
                            strGetValue = strGetValue & reverseCashsales(cmbForthCriteria.Text) & FOp.ToString & "#" & txtForthCriteria.Text.ToString & "#" & " and "
                        End If
                    End If
                End If



            ElseIf optProduct.Checked = True Then

                If Not String.IsNullOrEmpty(cmbFirstCriteria.Text) And Not String.IsNullOrEmpty(txtFirstCriteria.Text) Then
                    checkoperator(cmbFirstSearchOperator.Text)




                    If cmbFirstSearchOperator.Text.ToLower = LCase("Match Case") Then

                        strGetValue = strGetValue & RemoveAliasName(cmbFirstCriteria.Text) & FOp.ToString & "'" & txtFirstCriteria.Text.ToString & "'" & " and "

                    Else
                        If CheckFieldDataType(cmbFirstCriteria.Text) = "Integer" Then
                            strGetValue = strGetValue & RemoveAliasName(cmbFirstCriteria.Text) & FOp.ToString & Convert.ToInt32(txtFirstCriteria.Text.ToString) & " and "
                        ElseIf CheckFieldDataType(cmbFirstCriteria.Text) = "String" Then
                            strGetValue = strGetValue & RemoveAliasName(cmbFirstCriteria.Text) & FOp.ToString & "'" & txtFirstCriteria.Text.ToString & "'" & " and "
                        Else
                            strGetValue = strGetValue & RemoveAliasName(cmbFirstCriteria.Text) & FOp.ToString & "#" & txtFirstCriteria.Text.ToString & "#" & " and "
                        End If
                    End If
                End If



                If Not String.IsNullOrEmpty(cmbSecondCriteria.Text) And Not String.IsNullOrEmpty(txtSecondCriteria.Text) Then
                    checkoperator(cmbSecondSearchOperator.Text)



                    If cmbSecondSearchOperator.Text.ToLower = LCase("Match Case") Then

                        strGetValue = strGetValue & RemoveAliasName(cmbSecondCriteria.Text) & FOp.ToString & "'" & txtSecondCriteria.Text.ToString & "'" & " and "

                    Else
                        If CheckFieldDataType(cmbSecondCriteria.Text) = "Integer" Then
                            strGetValue = strGetValue & RemoveAliasName(cmbSecondCriteria.Text) & FOp.ToString & Convert.ToInt32(txtSecondCriteria.Text.ToString) & " and "
                        ElseIf CheckFieldDataType(cmbSecondCriteria.Text) = "String" Then
                            strGetValue = strGetValue & RemoveAliasName(cmbSecondCriteria.Text) & FOp.ToString & "'" & txtSecondCriteria.Text.ToString & "'" & " and "
                        ElseIf CheckFieldDataType(cmbSecondCriteria.Text) = "Date" Then
                            strGetValue = strGetValue & RemoveAliasName(cmbSecondCriteria.Text) & FOp.ToString & "#" & txtSecondCriteria.Text.ToString & "#" & " and "
                        End If
                    End If

                End If
                If Not String.IsNullOrEmpty(cmbThirdCriteria.Text) And Not String.IsNullOrEmpty(txtThirdCriteria.Text) Then
                        checkoperator(cmbThirdSearchOperator.Text)



                    If cmbThirdSearchOperator.Text.ToLower = LCase("Match Case") Then

                        strGetValue = strGetValue & RemoveAliasName(cmbThirdCriteria.Text) & FOp.ToString & "'" & txtThirdCriteria.Text.ToString & "'" & " and "

                    Else
                        If CheckFieldDataType(cmbThirdCriteria.Text) = "Integer" Then
                            strGetValue = strGetValue & RemoveAliasName(cmbThirdCriteria.Text) & FOp.ToString & Convert.ToInt32(txtThirdCriteria.Text.ToString) & " and "
                        ElseIf CheckFieldDataType(cmbThirdCriteria.Text) = "String" Then
                            strGetValue = strGetValue & RemoveAliasName(cmbThirdCriteria.Text) & FOp.ToString & "'" & txtThirdCriteria.Text.ToString & "'" & " and "
                        ElseIf CheckFieldDataType(cmbThirdCriteria.Text) = "Date" Then
                            strGetValue = strGetValue & RemoveAliasName(cmbThirdCriteria.Text) & FOp.ToString & "#" & txtThirdCriteria.Text.ToString & "#" & " and "
                        End If
                    End If
                End If



                    If Not String.IsNullOrEmpty(cmbForthCriteria.Text) And Not String.IsNullOrEmpty(txtForthCriteria.Text) Then
                        checkoperator(cmbForthSearchOperator.Text)



                    If cmbForthSearchOperator.Text.ToLower = LCase("Match Case") Then

                        strGetValue = strGetValue & RemoveAliasName(cmbForthCriteria.Text) & FOp.ToString & "'" & txtForthCriteria.Text.ToString & "'" & " and "

                    Else
                        If CheckFieldDataType(cmbForthCriteria.Text) = "Integer" Then
                            strGetValue = strGetValue & RemoveAliasName(cmbForthCriteria.Text) & FOp.ToString & Convert.ToInt32(txtForthCriteria.Text.ToString) & " and "
                        ElseIf CheckFieldDataType(cmbForthCriteria.Text) = "String" Then
                            strGetValue = strGetValue & RemoveAliasName(cmbForthCriteria.Text) & FOp.ToString & "'" & txtForthCriteria.Text.ToString & "'" & " and "
                        ElseIf CheckFieldDataType(cmbForthCriteria.Text) = "Date" Then
                            strGetValue =strGetValue & RemoveAliasName(cmbForthCriteria.Text) & FOp.ToString & "#" & txtForthCriteria.Text.ToString & "#" & " and "
                        End If
                    End If

                End If


                End If







            If strGetValue.Substring(strGetValue.Length - 5) = " and " Then
                strGetValue = strGetValue.Substring(0, strGetValue.Length - 5)
            Else


            End If












            Dim dt As DataTable = New DataTable
            If optCashSales.Checked = True Then
                Dim clscashsale As clsCashsalesMethods = New clsCashsalesMethods


                dt = clscashsale.GetCashsales(strGetValue)


                For Each TemplstItem As ListViewItem In lstSearchField.Items

                    If TemplstItem.Checked = False Then


                        dt.Columns.Remove(reverseCashsales(TemplstItem.Text))



                    End If





                Next


            ElseIf optProduct.Checked = True Then
                Dim ServiceDetailsMethods As clsServiceDetailsMethods = New clsServiceDetailsMethods

                dt = ServiceDetailsMethods.SearchoDetails(strGetValue)







                For Each TemplstItem As ListViewItem In lstSearchField.Items

                    If TemplstItem.Checked = False Then


                        dt.Columns.Remove(ReverseFieldName(TemplstItem.Text))



                    End If





                Next





            End If


            dgvProductInformation.DataSource = dt






        Catch ex As Exception
            MsgBox(ex.Message)
        End Try




    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Dispose()

    End Sub


    Private Sub AddOperator()
        cmbFirstSearchOperator.Items.Add("Equal to")
        cmbFirstSearchOperator.Items.Add("Greater Than")
        cmbFirstSearchOperator.Items.Add("Smaller Than")
        cmbFirstSearchOperator.Items.Add("Not Equal to")
        cmbFirstSearchOperator.Items.Add("Match Case")


        cmbSecondSearchOperator.Items.Add("Equal to")
        cmbSecondSearchOperator.Items.Add("Greater Than")
        cmbSecondSearchOperator.Items.Add("Smaller Than")
        cmbSecondSearchOperator.Items.Add("Not Equal to")
        cmbSecondSearchOperator.Items.Add("Match Case")


        cmbThirdSearchOperator.Items.Add("Equal to")
        cmbThirdSearchOperator.Items.Add("Greater Than")
        cmbThirdSearchOperator.Items.Add("Smaller Than")
        cmbThirdSearchOperator.Items.Add("Not Equal to")
        cmbThirdSearchOperator.Items.Add("Match Case")



        cmbForthSearchOperator.Items.Add("Equal to")
        cmbForthSearchOperator.Items.Add("Greater Than")
        cmbForthSearchOperator.Items.Add("Smaller Than")
        cmbForthSearchOperator.Items.Add("Not Equal to")
        cmbForthSearchOperator.Items.Add("Match Case")



    End Sub


    Private Sub checkoperator(ByVal tmpvalue As String)

        If tmpvalue.ToLower = LCase("Equal to") Then
            FOp = "="
        ElseIf tmpvalue.ToLower = LCase("Greater Than") Then
            FOp = ">"
        ElseIf tmpvalue.ToLower = LCase("Smaller Than") Then
            FOp = "<"
        ElseIf tmpvalue.ToLower = LCase("Not Equal to") Then
            FOp = "<>"
        ElseIf tmpvalue.ToLower = LCase("Match Case") Then
            FOp = " Like "
        End If



    End Sub



    Private Sub optProduct_CheckedChanged(sender As Object, e As EventArgs) Handles optProduct.CheckedChanged
        ClearField()
        loadCriteriaField()
    End Sub

    Private Sub optCashSales_CheckedChanged(sender As Object, e As EventArgs) Handles optCashSales.CheckedChanged
        ClearField()
        loadCriteriaField()
    End Sub


    Private Sub ClearField()
        cmbFirstCriteria.Items.Clear()
        cmbSecondCriteria.Items.Clear()
        cmbThirdCriteria.Items.Clear()
        cmbForthCriteria.Items.Clear()
        FOp = ""
        SOp = ""
        TOp = ""
        FrOp = ""
        cmbFirstSearchOperator.Text = ""
        cmbSecondSearchOperator.Text = ""
        cmbThirdSearchOperator.Text = ""
        cmbForthSearchOperator.Text = ""
        txtFirstCriteria.Text = ""
        txtSecondCriteria.Text = ""
        txtThirdCriteria.Text = ""
        txtForthCriteria.Text = ""

    End Sub



    Private Function CheckFieldDataType(ByVal strFieldDataType As String) As String

        Select Case strFieldDataType
            Case "Job Code"
                Return "String"
            Case "Branch"
                Return "String"
            Case "Customer Name"
                Return "String"
            Case "Customer Address"
                Return "String"
            Case "Customer Contact"
                Return "String"
            Case "Brand"
                Return "String"
            Case "Model"
                Return "String"
            Case "Mobile"
                Return "String"
            Case "ESN"
                Return "String"
            Case "Serial No"
                Return "String"
            Case "Category"
                Return "String"
            Case "Received By"
                Return "String"
            Case "Assign to"
                Return "String"
            Case "Repaired By"
                Return "String"
            Case "Deliver By"
                Return "String"
            Case "Returned Items"
                Return "String"
            Case "Item Remarks"
                Return "String"
            Case "Money Recept"
                Return "String"
            Case "LastJobNo"
                Return "String"
            Case "cRemarks"
                Return "String"
            Case "Physical Condition"
                Return "String"
            Case "Log_User"
                Return "String"
            Case "Product Code"
                Return "String"
            Case "Description"
                Return "String"
            Case "Remarks"
                Return "String"
            Case "MRNO"
                Return "String"
            Case "JobCode"
                Return "String"
            Case "Branch"
                Return "String"
            Case "CustName"
                Return "String"
            Case "CustAddress1"
                Return "String"
            Case "CustAddress2"
                Return "String"
            Case "Brand"
                Return "String"
            Case "ModelNo"
                Return "String"
            Case "ESN"
                Return "String"
            Case "SLNo"
                Return "String"
            Case "ReceptBy"
                Return "String"
            Case "Code"
                Return "String"
            Case "ProdName"
                Return "String"


                '__________________ Num Start below


            Case "Rate"
                Return "Integer"
            Case "Qty"
                Return "Integer"
            Case "Amount"
                Return "Integer"
            Case "PrdAmt"
                Return "Integer"
            Case "Dis"
                Return "Integer"
            Case "NetAmnt"
                Return "Integer"
            Case "DFlag"
                Return "Integer"
            Case "WCondition"
                Return "Integer"
            Case "Product Status"
                Return "Integer"
            Case "Qty"
                Return "Integer"
            Case "Unit Price"
                Return "Integer"
            Case "Service Charge"
                Return "Integer"
            Case "Product Amount"
                Return "Integer"
            Case "Other Charge"
                Return "Integer"
            Case "Discount"
                Return "Integer"
            Case "SRFlag"
                Return "Integer"
            Case "cAdvance"
                Return "Integer"
            Case "cTransportCrg"
                Return "Integer"
            Case "FreeOfCost"
                Return "Integer"
            Case "Advance Amount"
                Return "Integer"
            Case "Vat Amount"
                Return "Integer"
                                '______________________ Start Date Below
            Case "Receive Date"
                Return "Date"
            Case "Approximate Delivery Date"
                Return "Date"
            Case "Purchase Date"
                Return "Date"
            Case "Assign Date"
                Return "Date"
            Case "Repaired Date"
                Return "Date"
            Case "Delivery Date"
                Return "Date"
            Case "Log_Date"
                Return "Date"
            Case "Log_Date"
                Return "Date"
            Case "ReceptDate"
                Return "Date"



            Case Else


        End Select

        Return True


    End Function

    Private Sub optCashSales_Click(sender As Object, e As EventArgs) Handles optCashSales.Click
        optCashSales.Font = New Font(optCashSales.Font, optCashSales.Font.Bold = True)
    End Sub



    Private Sub cmbFirstCriteria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbFirstCriteria.KeyPress
        e.Handled = True

    End Sub

    Private Sub cmbSecondCriteria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbSecondCriteria.KeyPress
        e.Handled = True

    End Sub

    Private Sub cmbThirdCriteria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbThirdCriteria.KeyPress
        e.Handled = True
    End Sub


    Private Sub cmbForthCriteria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbForthCriteria.KeyPress
        e.Handled = True
    End Sub

    Private Sub cmbFirstSearchOperator_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbFirstSearchOperator.KeyPress
        e.Handled = True
    End Sub

    Private Sub cmbSecondSearchOperator_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbSecondSearchOperator.KeyPress
        e.Handled = True
    End Sub

    Private Sub cmbThirdSearchOperator_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbThirdSearchOperator.KeyPress
        e.Handled = True
    End Sub

    Private Sub cmbForthSearchOperator_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbForthSearchOperator.KeyPress
        e.Handled = True

    End Sub






End Class