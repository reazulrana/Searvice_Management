'Imports System.ComponentModel
Imports System.Data.OleDb
Imports Microsoft.VisualBasic


Public Class frmOnpayment_Bill_Format



    Public strFormType As String = String.Empty

    Dim dblTServiceCharge As Double = 0 ' Store Vat Percentage
    Dim dblparts As Double = 0 ' Store Vat Percentage




    Dim strJobStatus As String = String.Empty
    Dim ER As clsEstimateRefused = New clsEstimateRefused



    Private Sub frmOnpayment_Bill_Format_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Dim ERM As clsEstimateRefusedMethods = New clsEstimateRefusedMethods
        ER = ERM.GetEstimateRefuse(publicClaiminfo.Jobcode)

            If strFormType.ToLower = LCase("JobStatus") Then
                Me.Text = "Product Status"
                grpBillDescription.Enabled = False
                chkRemarkEnabled.Enabled = False
                chkVatAmount.Enabled = False
                txtMR.Enabled = False
                txtRemarks.Enabled = False
                strFormType = String.Empty
                cmdBill.Enabled = False
                cmdPreview.Enabled = False
                cmdPrint.Enabled = False
                chkFreeofcost.Checked = False


                If publicClaiminfo.cFlag = -1 Then

                    txtProductStatus.Text = "Not Service"
                    txtEstimateRefuse.Text = "Not Service"
                     JobInformation() ' Get All Relevant Product Information
                    Exit Sub
                ElseIf publicClaiminfo.cFlag = 9 Then
                    txtProductStatus.Text = "Pending"
                    txtEstimateRefuse.Text = "Pending"
                    txtEstimateRefuse.BackColor = Color.DarkBlue
                    txtEstimateRefuse.ForeColor = Color.White
                    LoadPening()
                    JobInformation() ' Get All Relevant Product Information
                    Exit Sub


                End If



            End If


            If Not IsNothing(ER.JobCode) Then
            strJobStatus = "ER"
        End If


        If (publicClaiminfo.cFlag = Integer.Parse("99") Or publicClaiminfo.cFlag = Integer.Parse("100") Or publicClaiminfo.cFlag = Integer.Parse("101") Or publicClaiminfo.cFlag = Integer.Parse("102")) Then

            strJobStatus = publicClaiminfo.cFlag.ToString

        End If

        CenterForm(Me)

        chkSpareAmount.Visible = False



        ControllsEnabled()
        JobInformation()





            chkRemarkEnabled.Checked = False

        chkRemarkEnabled_CheckedChanged(sender, e)
        LoadAmount() ' Only Fields are filling with data
            TotalAmount()
            If strJobStatus.ToString.ToLower = LCase("ER") Then
            txtEstimateRefuse.Text = "Estimate Refuse"
            If publicClaiminfo.WCondition = 0 Or publicClaiminfo.WCondition = 2 Then
                chkVatAmount.Enabled = False  ' MR Checkbox will be disabled if Job Warranty is Sales Warranty or Service Warranty
            End If
        End If




        ButtonResize()

            LoadEmpolyeecode()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub LoadPening()

        Dim PM As clsPendingMethods = New clsPendingMethods

        Dim P As clsPending = PM.GetPending(publicClaiminfo.Jobcode)


        If Not P Is Nothing Then
            lstPartsList.Items.Clear()
            Dim lstItem As ListViewItem = New ListViewItem
            lstItem = lstPartsList.Items.Add(lstPartsList.Items.Count + 1)
            If Not String.IsNullOrEmpty(P.PenCode) Then
                lstItem.SubItems.Add(P.PenCode)
            End If
        End If

    End Sub


    Private Sub LoadEmpolyeecode()


        Dim empmethods As clsPersonalMethods = New clsPersonalMethods

        Dim empList As List(Of clsPersonal) = empmethods.LoadTechnician.ToList



        cmbEmployeeCode.Items.Clear()

        For Each emp As clsPersonal In empList

            cmbEmployeeCode.Items.Add(emp.EmpCode)

        Next





    End Sub

    Private Sub LoadAmount()

        Dim tbBill_FFC_Methods As clstbBill_FFCMethods = New clstbBill_FFCMethods
        Dim tbBill_FFC As clstbBill_FFC = tbBill_FFC_Methods.GetServiceCharge(publicClaiminfo.Jobcode)

        Dim ERM As clsEstimateRefusedMethods = New clsEstimateRefusedMethods
        Dim ER As clsEstimateRefused = ERM.GetEstimateRefuse(publicClaiminfo.Jobcode)

        lblTotalSpareCost.Text = Integer.Parse("0")
        txtFaultFindingCharge.Text = Integer.Parse("0")
        txtRepairCharge.Text = Integer.Parse("0")
        lblVatAmount.CausesValidation = Integer.Parse("0")
        txtOtherCharge.Text = Integer.Parse("0")
        txtDiscount.Text = Integer.Parse("0")
        lblVatAmount.Text = Integer.Parse("0")
        lblTotalAmount.Text = Integer.Parse("0")





        With publicClaiminfo

            If (.WCondition = Integer.Parse("0")) Then

                If (.cFlag = Integer.Parse("2")) Then ' if product is delivered
                    If IsNothing(ER.JobCode) Then
                        If .PrdAmt > Integer.Parse("0") Then
                            chkSpareAmount.Checked = True
                        End If
                    End If
                End If

            ElseIf .WCondition = Integer.Parse("1") Then
                If (.cFlag = Integer.Parse("0") Or .cFlag = Integer.Parse("1")) Then
                    If (Not IsNothing(ER.JobCode)) Then
                        If tbBill_FFC.FaultCharge > Integer.Parse("0") Then
                            txtFaultFindingCharge.Text = Integer.Parse(tbBill_FFC.FaultCharge)
                        End If
                    Else
                        If .PrdAmt > Integer.Parse("0") Then
                            lblTotalSpareCost.Text = Integer.Parse(.PrdAmt)
                        End If


                        If tbBill_FFC.FaultCharge > Integer.Parse("0") Then
                            txtFaultFindingCharge.Text = Integer.Parse(tbBill_FFC.FaultCharge)
                        End If
                        If tbBill_FFC.ServiceCharge > Integer.Parse("0") Then
                            txtRepairCharge.Text = Integer.Parse(tbBill_FFC.ServiceCharge)
                        End If

                    End If
                ElseIf (.cFlag = Integer.Parse("1")) Then

                    lblTotalSpareCost.Text = PartsAmount()
                End If

            End If

            If .OtherAmt > Integer.Parse("0") Then
                txtOtherCharge.Text = Integer.Parse(.OtherAmt)
            End If

            If .Dis > Integer.Parse("0") Then
                txtDiscount.Text = Integer.Parse(.Dis)
            End If


            If .VatAmnt > Integer.Parse("0") Then
                chkVatAmount.Checked = True
                'lblVatAmount.Text = Integer.Parse(.VatAmnt)
            End If
            If .AdvanceAmnt > Integer.Parse("0") Then
                txtAdvanceAmount.Text = Integer.Parse(.AdvanceAmnt)
            End If

        End With



    End Sub





    Private Sub StatusBaseControllEnable()
        Dim claim As clsClaiminfoMethods = New clsClaiminfoMethods
        Dim c As clsClaiminfo = claim.LoadClaiminfo_byJobCode(publicClaiminfo.Jobcode)

        If (c.cFlag = 0 Or c.cFlag = 1 Or c.cFlag = 2) And c.MRNO.ToLower = LCase("est refuse") Then


        End If

    End Sub


    Private Sub ControllsEnabled()

        With publicClaiminfo


            If .WCondition = Integer.Parse("0") Or .WCondition = Integer.Parse("2") Then
                txtFaultFindingCharge.Enabled = False
                txtRepairCharge.Enabled = False

                If (.cFlag = Integer.Parse("1") Or .cFlag = Integer.Parse("2") Or .cFlag = Integer.Parse("0")) Then
                    If strJobStatus.ToString.ToLower <> LCase("ER") Then
                        chkSpareAmount.Visible = True
                        chkSpareAmount.Enabled = True
                    End If

                End If


            ElseIf .WCondition = Integer.Parse("1") Then
                If (.cFlag = Integer.Parse("1") Or .cFlag = Integer.Parse("0")) Then

                    If strJobStatus.ToString.ToLower = LCase("ER") Then
                        txtRepairCharge.Enabled = False
                    Else
                        txtRepairCharge.Enabled = True
                    End If
                    txtFaultFindingCharge.Enabled = True
                    chkSpareAmount.Visible = False
                Else
                    txtFaultFindingCharge.Enabled = True
                    txtRepairCharge.Enabled = False
                    chkSpareAmount.Visible = False

                End If




            End If

        End With

        chkFreeofcost.Enabled = True

        chkVatAmount.Enabled = True

        txtOtherCharge.Enabled = True
        txtDiscount.Enabled = True
        txtMR.Enabled = True





    End Sub




    Private Function getTechnicianCode(criteria) As String

        Dim empmethods As clsPersonalMethods = New clsPersonalMethods
        Dim emp As List(Of clsPersonal) = empmethods.LoadTechnician(criteria).ToList



        If emp.Count > 0 Then
            For Each emoloyee As clsPersonal In emp
                Return emoloyee.EmpName
            Next


        End If



        Return "Missing Technician Code"






    End Function



    Private Sub LoadEstimatRefuse()
        Dim estMethods As clsEstimateRefusedMethods = New clsEstimateRefusedMethods
        If estMethods.IsExist(publicClaiminfo.Jobcode) = False Then
            Exit Sub
        End If

        Dim est As clsEstimateRefused = estMethods.GetEstimateRefuse(publicClaiminfo.Jobcode)





        Dim lstItem As ListViewItem = New ListViewItem



        If Not String.IsNullOrEmpty(est.JobCode) Then
            lstPartsList.Items.Clear()

            lstItem = lstPartsList.Items.Add(lstPartsList.Items.Count + 1)
            lstItem.SubItems.Add("Description: " & est.EstText & ", Amount: " & est.RefuseAmnt & ", Date: " & est.EstDate.ToShortDateString)


        End If






    End Sub

    Private Function TotalAmount() As Double

        Dim sngSpareAmount As Double = 0
        Dim sngFFC As Double = 0
        Dim sngServiceCharge = 0
        Dim sngVat As Double = 0
        Dim sngOtherAmount As Double = 0
        Dim sngDiscount As Double = 0
        Dim sngAdvanceAmnt As Double = 0


        lblTotalAmount.Text = Double.Parse("0")



        If Double.TryParse(lblTotalSpareCost.Text, sngSpareAmount) = False Then
            sngSpareAmount = 0
        End If



        If Double.TryParse(txtFaultFindingCharge.Text, sngFFC) = False Then
            sngFFC = 0
        End If


        If Double.TryParse(txtRepairCharge.Text, sngServiceCharge) = False Then
            sngServiceCharge = 0
        End If



        If Double.TryParse(lblVatAmount.Text, sngVat) = False Then
            sngVat = 0
        End If



        If Double.TryParse(txtOtherCharge.Text, sngOtherAmount) = False Then
            sngOtherAmount = 0
        End If



        If Double.TryParse(txtDiscount.Text, sngDiscount) = False Then
            sngDiscount = 0
        End If



        If Double.TryParse(txtAdvanceAmount.Text, sngAdvanceAmnt) = False Then
            sngAdvanceAmnt = 0
        End If


        lblTotalAmount.Text = Double.Parse(sngSpareAmount + sngFFC + sngServiceCharge + sngVat + sngOtherAmount) - Double.Parse(sngDiscount + sngAdvanceAmnt)

        Return lblTotalAmount.Text

    End Function

    Private Sub NRDetails()
        Dim NRDetailsMethods As clsNrdetailsMethods = New clsNrdetailsMethods
        Dim NRDetails As clsNrdetails = NRDetailsMethods.GetNR(publicClaiminfo.Jobcode)


        Dim tbbillFFCMethods As clstbBill_FFCMethods = New clstbBill_FFCMethods
        Dim tbbillFFC As clstbBill_FFC = tbbillFFCMethods.GetServiceCharge(publicClaiminfo.Jobcode)
        Dim lstItem As ListViewItem = New ListViewItem

        If Not String.IsNullOrEmpty(NRDetails.NRCode) Then
            lstPartsList.Items.Clear()
            lstItem = lstPartsList.Items.Add(lstPartsList.Items.Count + 1)
            lstItem.SubItems.Add(NRDetails.NRCode)


        End If


    End Sub




    Private Sub ReplaceProduct()

    End Sub





    Private Sub ButtonResize()
        cmdBill.Left = txtMR.Left + txtMR.Width
        cmdBill.Width = (txtRemarks.Width - (txtMR.Width)) / 5
        cmdPreview.Left = cmdBill.Left + cmdBill.Width
        cmdPreview.Width = (txtRemarks.Width - (txtMR.Width)) / 5
        cmdCR.Left = cmdPreview.Left + cmdPreview.Width
        cmdCR.Width = (txtRemarks.Width - (txtMR.Width)) / 5
        cmdClose.Left = cmdCR.Left + cmdCR.Width
        cmdClose.Width = (txtRemarks.Width - (txtMR.Width)) / 5
        cmdPrint.Left = cmdClose.Left + cmdClose.Width
        cmdPrint.Width = (txtRemarks.Width - (txtMR.Width)) / 5


    End Sub


    Private Sub ResetFieldWithZero()
        txtOtherCharge.Text = "0"
        txtFaultFindingCharge.Text = "0"
        txtRepairCharge.Text = "0"
        lblVatAmount.Text = "0"
        txtDiscount.Text = "0"
        txtAdvanceAmount.Text = "0"
        lblTotalAmount.Text = "0"
    End Sub

    Private Sub JobInformation()








        'Dim ServiceItemMethods As clsServiceItemMethods = New clsServiceItemMethods
        'Dim ServiceItem As clsServiceItem = New clsServiceItem
        'Dim lstItem As ListViewItem = New ListViewItem

        'If ServiceItemMethods.IsExist(publicClaiminfo.Jobcode) = True Then
        '    ServiceItem = ServiceItemMethods.GetItem(publicClaiminfo.Jobcode)

        '    lstItem = lstTBItem.Items.Add(lstTBItem.Items.Count + 1)
        '    lstItem.SubItems.Add(ServiceItem.Item)

        'End If



        With publicClaiminfo


            txtJobCode.Text = .Jobcode
            If .WCondition = 0 Then
                txtWarrStatus.Text = "Sales-Warranty"
                optTBSalesWarranty.Checked = True
                txtTBPurchaseDate.Text = .PDate.ToShortDateString
            ElseIf .WCondition = 1 Then
                txtWarrStatus.Text = "Non-Warranty"
                optTBNonWarranty.Checked = True
            Else
                txtWarrStatus.Text = "Service-Warranty"
                optTBServiceWarranty.Checked = True

            End If

            If .cFlag = 1 And Not IsNothing(ER.JobCode) Then
                txtProductStatus.Text = "Pending Delivery"
                txtEstimateRefuse.Text = "Estimate Refuse"
                txtEstimateRefuse.BackColor = Color.Red
                txtEstimateRefuse.ForeColor = Color.White
            ElseIf .cFlag = 1 And IsNothing(ER.JobCode) Then
                txtProductStatus.Text = "Pending Delivery"
                txtEstimateRefuse.Text = "Service"
                txtEstimateRefuse.BackColor = Color.DarkBlue
                txtEstimateRefuse.ForeColor = Color.White

            ElseIf .cFlag = 99 Then

                txtProductStatus.Text = "Pending Delivery"
                txtEstimateRefuse.Text = "Not Repairable"
                txtEstimateRefuse.BackColor = Color.Red
                txtEstimateRefuse.ForeColor = Color.White


            ElseIf .cFlag = 101 Then

                txtProductStatus.Text = "Pending Delivery"
                txtEstimateRefuse.Text = "Replace"
                txtEstimateRefuse.BackColor = Color.SkyBlue
                txtEstimateRefuse.ForeColor = Color.Blue


            ElseIf (.cFlag = 0 Or .cFlag = 2) And Not IsNothing(ER.JobCode) Then
                txtProductStatus.Text = "Delivered"
                txtEstimateRefuse.Text = "Estimate Refuse"
                txtEstimateRefuse.BackColor = Color.Red
                txtEstimateRefuse.ForeColor = Color.White

            ElseIf (.cFlag = 0 Or .cFlag = 2) And IsNothing(ER.JobCode) Then

                txtEstimateRefuse.Text = "Delivered"

                txtProductStatus.Text = "Delivered"

                txtEstimateRefuse.BackColor = Color.Green
                txtEstimateRefuse.ForeColor = Color.White
            ElseIf .cFlag = 100 Then
                txtProductStatus.Text = "Delivered"
                txtEstimateRefuse.Text = "Not Repairable"
                txtEstimateRefuse.BackColor = Color.Red
                txtEstimateRefuse.ForeColor = Color.White

            ElseIf .cFlag = 102 Then
                txtProductStatus.Text = "Delivered"
                txtEstimateRefuse.Text = "Replace"
                txtEstimateRefuse.ForeColor = Color.Black
                txtEstimateRefuse.BackColor = Color.SkyBlue
                txtEstimateRefuse.ForeColor = Color.Blue




            End If



            If (.cFlag = 0 Or .cFlag = 2 Or .cFlag = 100 Or .cFlag = 102) Then

                If .FreeOfCost = 1 Then
                    chkFreeofcost.Checked = True
                Else
                    chkFreeofcost.Checked = False
                End If
                Dim empMethods As clsPersonalMethods = New clsPersonalMethods
                Dim emp As List(Of clsPersonal) = empMethods.LoadTechnician(.DeliverBy).ToList



                If emp.Count = 1 Then

                    For Each employee As clsPersonal In emp
                        cmbEmployeeCode.Text = employee.EmpCode

                        lblEmployeeName.Text = employee.EmpName
                        txtMR.Text = .MRNO
                        dtpDelivery.Value = .DDate

                    Next

                End If

            End If




            txtBranch.Text = .Branch
            txtName.Text = .CustName
            txtAddress1.Text = .CustAddress1
            txtAddress2.Text = .CustAddress2
            txtReceiptDate.Text = .ReceptDate
            txtServiceby.Text = .ServiceBy
            txtApproxDate.Text = .AppDelDate
            txtServiceDate.Text = .SDate
            txtReceivedBy.Text = .ReceptBy
            txtMR.Text = .MRNO
            txtCategory.Text = .ServiceType
            txtBrand.Text = .Brand
            txtModel.Text = .ModelNo
            txtSerial.Text = .SLNo
            txtESN.Text = .ESN

            If Not String.IsNullOrEmpty(.Remk) Then
                txtRemarks.Text = .Remk
            End If


            If (publicClaiminfo.cFlag = 0 Or publicClaiminfo.cFlag = 1 Or publicClaiminfo.cFlag = 2) Then
                If (IsNothing(ER.JobCode)) Then
                    LoadParts()
                Else
                    LoadEstimatRefuse()
                End If

            End If





            If (publicClaiminfo.cFlag = 99 Or publicClaiminfo.cFlag = 100) Then

                NRDetails()

            End If




            If (publicClaiminfo.cFlag = 101 Or publicClaiminfo.cFlag = 102) Then

                ReplaceProduct()

            End If










        End With


        'If publicClaiminfo.WCondition = Integer.Parse("0") Or publicClaiminfo.WCondition = Integer.Parse("2") Then
        '    txtFaultFindingCharge.Enabled = False
        '    txtRepairCharge.Enabled = False
        'End If



        Dim custclaimMethods As clsCustomerClaimMethods = New clsCustomerClaimMethods
        Dim custclaim As clsCustomerClaim = custclaimMethods.GetCustomerClaim(txtJobCode.Text)
        Dim serviceitemMethods As clsServiceDetailsMethods = New clsServiceDetailsMethods
        Dim serviceitem As clsServiceItem = New clsServiceItem



        Dim lstFaultItem As ListViewItem = New ListViewItem




        If Not String.IsNullOrEmpty(custclaim.ClaimCode) Then
            lstFaultItem = lstTBFaultList.Items.Add(lstTBFaultList.Items.Count + 1)
            lstFaultItem.SubItems.Add(custclaim.ClaimCode)

        End If



        If Not String.IsNullOrEmpty(serviceitem.Item) Then
            lstFaultItem = lstTBFaultList.Items.Add(lstTBFaultList.Items.Count + 1)
            lstFaultItem.SubItems.Add(serviceitem.Item)

        End If









    End Sub
    Private Function PartsAmount() As Double
        Dim dblAmount As Double = Double.Parse("0.00")
        Try
            If lstPartsList.Items.Count > 0 Then
                If (strJobStatus = "ER" Or strJobStatus = "99" Or strJobStatus = "100" Or strJobStatus = "101" Or strJobStatus = "102") Then
                    dblAmount = 0
                Else
                    If lstPartsList.Items.Count > 0 Then
                        For Each lstitem As ListViewItem In lstPartsList.Items
                            If lstitem.SubItems(1).Text.Length >= 7 Then


                                If Not lstitem.SubItems(1).Text.Substring(0, 7).ToLower = LCase("Remarks") Then
                                    dblAmount += lstitem.SubItems(6).Text
                                End If
                            Else
                                dblAmount += lstitem.SubItems(6).Text
                            End If

                        Next
                    End If
                End If

            End If

        Catch ex As Exception

        End Try
        Return dblAmount
    End Function

    Private Sub LoadParts()

        Dim strJobCode As String = String.Empty


        strJobCode = publicClaiminfo.Jobcode
        Dim serviceDetailsMethods As clsServiceDetailsMethods = New clsServiceDetailsMethods
        If serviceDetailsMethods.IsExist(strJobCode) = False Then
            Exit Sub

        End If





        Dim serviceDetails As clsServiceDetails = serviceDetailsMethods.GetPartsDetails(strJobCode)


        Dim lstItem As ListViewItem = New ListViewItem
        lstPartsList.Items.Clear()

        For Each TempDetails As String In serviceDetails.Description.Split("|")
            Dim TempSubDetails As String() = TempDetails.Split(",")


            If Not String.IsNullOrEmpty(TempSubDetails(0).ToString) Then

                If TempSubDetails(0).Length >= 7 Then



                    If TempSubDetails(0).Substring(0, 8).ToString.ToLower = LCase("Remarks:") Then


                        lstItem = lstPartsList.Items.Add(lstPartsList.Items.Count + 1)
                        lstItem.SubItems.Add(TempSubDetails(0))
                    Else

                        lstItem = lstPartsList.Items.Add(lstPartsList.Items.Count + 1)
                        lstItem.SubItems.Add(TempSubDetails(0))
                        lstItem.SubItems.Add(TempSubDetails(1))
                        lstItem.SubItems.Add(String.Empty)
                        lstItem.SubItems.Add(TempSubDetails(2))
                        lstItem.SubItems.Add(TempSubDetails(3))
                        lstItem.SubItems.Add(Convert.ToInt32(TempSubDetails(2)) * Convert.ToDouble(TempSubDetails(3)))
                    End If
                Else
                    lstItem = lstPartsList.Items.Add(lstPartsList.Items.Count + 1)
                    lstItem.SubItems.Add(TempSubDetails(0))
                    lstItem.SubItems.Add(TempSubDetails(1))
                    lstItem.SubItems.Add(String.Empty)
                    lstItem.SubItems.Add(TempSubDetails(2))
                    lstItem.SubItems.Add(TempSubDetails(3))
                    lstItem.SubItems.Add(Convert.ToInt32(TempSubDetails(2)) * Convert.ToDouble(TempSubDetails(3)))
                End If
            End If





        Next






    End Sub





    Private Sub LoadEmployee(ByVal strCodeNo As String)
        Dim empMethods As clsPersonalMethods = New clsPersonalMethods
        Dim emp As List(Of clsPersonal) = New List(Of clsPersonal)


        If String.IsNullOrEmpty(strCodeNo) Then
            emp = empMethods.LoadTechnician
        Else
            emp = empMethods.LoadTechnician(strCodeNo)
        End If



        If emp.Count > 0 Then

            For Each employee As clsPersonal In emp

                cmbEmployeeCode.Items.Add(employee.EmpCode)

                If emp.Count = 1 Then
                    lblEmployeeName.Text = employee.EmpName
                End If


            Next



        End If

    End Sub

    Private Sub cmbEmployeeCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEmployeeCode.SelectedIndexChanged
        LoadEmployee(cmbEmployeeCode.Text)
    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        Try

            ReportIdentification = String.Empty
            ReportIdentification = "Bill"
            PrintSaveData()
            BillInvoice()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub BillInvoice()
        Dim tmpfrmShowReport As New frmReportShow
        Dim shrtLoop As Short = 0
        Dim lstTempPartsList As ListViewItem = Nothing




        Dim tmpcflag As String = publicClaiminfo.cFlag


            If tmpcflag = "99" Or tmpcflag = "100" Then

            MessageBox.Show("You Can not print or Preview Bill In 'N/R Mode'")
            Exit Sub
            ElseIf tmpcflag = "101" Or tmpcflag = "102" Then
            MessageBox.Show("You Can not print or Preview Bill In 'Replace Mode'")
            Exit Sub


            End If







            tmpfrmShowReport.dtInvoicePartsDetails.Columns.Add("SID", Type.GetType("System.Int32"))
            tmpfrmShowReport.dtInvoicePartsDetails.Columns.Add("ProductCode", Type.GetType("System.String"))
            tmpfrmShowReport.dtInvoicePartsDetails.Columns.Add("ProdName", Type.GetType("System.String"))
            tmpfrmShowReport.dtInvoicePartsDetails.Columns.Add("Qty", Type.GetType("System.Double"))
            tmpfrmShowReport.dtInvoicePartsDetails.Columns.Add("UnitPrice", Type.GetType("System.Double"))







        Dim tmpClaimInfoMethods As clsClaiminfoMethods = New clsClaiminfoMethods
        Dim tempBranchMethods As clsBranchMethods = New clsBranchMethods

        'Loop For Matching Branch 
        Dim GetBranchList As List(Of clsBranch) = tempBranchMethods.GetBranches().ToList


            For Each b As clsBranch In GetBranchList
                If b.Branch.ToLower = LCase(txtBranch.Text) Then

                    tmpfrmShowReport.BranchInvoice = b

                    Exit For
                End If


            Next
            tmpfrmShowReport.claiminfoInvoice = tmpClaimInfoMethods.LoadClaiminfo_byJobCode(txtJobCode.Text)
        With tmpfrmShowReport.tbBillFFCinvoice

            If ReportIdentification.ToLower = LCase("BillPreview") Then
                tmpfrmShowReport.claiminfoInvoice.Remk = txtRemarks.Text
            End If


            If Integer.TryParse(lblTotalSpareCost.Text, .PrdAmt) = False Then
                .PrdAmt = 0
            Else
                .PrdAmt = lblTotalSpareCost.Text
            End If

            If Integer.TryParse(txtRepairCharge.Text, .ServiceCharge) = False Then
                .ServiceCharge = 0
            Else
                .ServiceCharge = txtRepairCharge.Text
            End If

            If Integer.TryParse(txtFaultFindingCharge.Text, .FaultCharge) = False Then
                .FaultCharge = 0
            Else
                .FaultCharge = txtFaultFindingCharge.Text
            End If

            If Integer.TryParse(txtOtherCharge.Text, .OtherAmt) = False Then

                .OtherAmt = 0
            Else
                .OtherAmt = txtOtherCharge.Text
            End If


            If Integer.TryParse(lblVatAmount.Text, .VatAmnt) = False Then

                .VatAmnt = 0
            Else
                .VatAmnt = lblVatAmount.Text
            End If


            If Integer.TryParse(txtAdvanceAmount.Text, .AdvanceAmnt) = False Then

                .AdvanceAmnt = 0
            Else
                .AdvanceAmnt = txtAdvanceAmount.Text
            End If





            If Integer.TryParse(txtDiscount.Text, .Dis) = False Then

                .Dis = 0
            Else
                .Dis = txtDiscount.Text
            End If

        End With




        If Not strJobStatus = "ER" Then
                If tmpfrmShowReport.claiminfoInvoice.WCondition = 1 Then
                If lstPartsList.Items.Count > 0 Then

                    For Each lstitem As ListViewItem In lstPartsList.Items
                        If lstitem.SubItems(1).Text.Length >= 7 Then


                            If Not lstitem.SubItems(1).Text.Substring(0, 7).ToLower = LCase("Remarks") Then
                                tmpfrmShowReport.dtInvoicePartsDetails.Rows.Add(Convert.ToInt32(lstitem.SubItems(0).Text), lstitem.SubItems(1).Text, lstitem.SubItems(2).Text, Convert.ToDouble(lstitem.SubItems(4).Text), Convert.ToDouble(lstitem.SubItems(5).Text))
                            Else
                                tmpfrmShowReport.dtInvoicePartsDetails.Rows.Add(Convert.ToInt32(lstitem.SubItems(0).Text), "", lstitem.SubItems(1).Text.Substring(Len("Remarks:"), lstitem.SubItems(1).Text.Length - Len("Remarks:")), 0, 0)
                            End If
                        Else
                            tmpfrmShowReport.dtInvoicePartsDetails.Rows.Add(Convert.ToInt32(lstitem.SubItems(0).Text), lstitem.SubItems(1).Text, lstitem.SubItems(2).Text, Convert.ToDouble(lstitem.SubItems(4).Text), Convert.ToDouble(lstitem.SubItems(5).Text))
                        End If


                    Next

                End If
            ElseIf tmpfrmShowReport.claiminfoInvoice.WCondition = 0 Then

                If chkSpareAmount.Checked = True Then
                    If lstPartsList.Items.Count > 0 Then

                        For Each lstitem As ListViewItem In lstPartsList.Items
                            If lstitem.SubItems(1).Text.Length >= 7 Then


                                If Not lstitem.SubItems(1).Text.Substring(0, 7).ToLower = LCase("Remarks") Then
                                    tmpfrmShowReport.dtInvoicePartsDetails.Rows.Add(Convert.ToInt32(lstitem.SubItems(0).Text), lstitem.SubItems(1).Text, lstitem.SubItems(2).Text, Convert.ToDouble(lstitem.SubItems(4).Text), Convert.ToDouble(lstitem.SubItems(5).Text))
                                Else
                                    tmpfrmShowReport.dtInvoicePartsDetails.Rows.Add(Convert.ToInt32(lstitem.SubItems(0).Text), "", lstitem.SubItems(1).Text.Substring(Len("Remarks:"), lstitem.SubItems(1).Text.Length - Len("Remarks:")), 0, 0)
                                End If
                            Else
                                tmpfrmShowReport.dtInvoicePartsDetails.Rows.Add(Convert.ToInt32(lstitem.SubItems(0).Text), lstitem.SubItems(1).Text, lstitem.SubItems(2).Text, Convert.ToDouble(lstitem.SubItems(4).Text), Convert.ToDouble(lstitem.SubItems(5).Text))
                            End If
                        Next

                    End If
                ElseIf tmpfrmShowReport.claiminfoInvoice.cFlag = 2 Then
                    If lstPartsList.Items.Count > 0 Then

                        For Each lstitem As ListViewItem In lstPartsList.Items
                            If lstitem.SubItems(1).Text.Length >= 7 Then


                                If Not lstitem.SubItems(1).Text.Substring(0, 7).ToLower = LCase("Remarks") Then
                                    tmpfrmShowReport.dtInvoicePartsDetails.Rows.Add(Convert.ToInt32(lstitem.SubItems(0).Text), lstitem.SubItems(1).Text, lstitem.SubItems(2).Text, Convert.ToDouble(lstitem.SubItems(4).Text), Convert.ToDouble(lstitem.SubItems(5).Text))
                                Else
                                    tmpfrmShowReport.dtInvoicePartsDetails.Rows.Add(Convert.ToInt32(lstitem.SubItems(0).Text), "", lstitem.SubItems(1).Text.Substring(Len("Remarks:"), lstitem.SubItems(1).Text.Length - Len("Remarks:")), 0, 0)
                                End If
                            Else
                                tmpfrmShowReport.dtInvoicePartsDetails.Rows.Add(Convert.ToInt32(lstitem.SubItems(0).Text), lstitem.SubItems(1).Text, lstitem.SubItems(2).Text, Convert.ToDouble(lstitem.SubItems(4).Text), Convert.ToDouble(lstitem.SubItems(5).Text))
                            End If
                        Next
                    End If

                End If
            ElseIf tmpfrmShowReport.claiminfoInvoice.WCondition = 2 Then
                If chkSpareAmount.Checked = True Then
                    If lstPartsList.Items.Count > 0 Then

                        For Each lstitem As ListViewItem In lstPartsList.Items
                            If lstitem.SubItems(1).Text.Length >= 7 Then


                                If Not lstitem.SubItems(1).Text.Substring(0, 7).ToLower = LCase("Remarks") Then
                                    tmpfrmShowReport.dtInvoicePartsDetails.Rows.Add(Convert.ToInt32(lstitem.SubItems(0).Text), lstitem.SubItems(1).Text, lstitem.SubItems(2).Text, Convert.ToDouble(lstitem.SubItems(4).Text), Convert.ToDouble(lstitem.SubItems(5).Text))
                                Else
                                    tmpfrmShowReport.dtInvoicePartsDetails.Rows.Add(Convert.ToInt32(lstitem.SubItems(0).Text), "", lstitem.SubItems(1).Text.Substring(Len("Remarks:"), lstitem.SubItems(1).Text.Length - Len("Remarks:")), 0, 0)
                                End If
                            Else
                                tmpfrmShowReport.dtInvoicePartsDetails.Rows.Add(Convert.ToInt32(lstitem.SubItems(0).Text), lstitem.SubItems(1).Text, lstitem.SubItems(2).Text, Convert.ToDouble(lstitem.SubItems(4).Text), Convert.ToDouble(lstitem.SubItems(5).Text))
                            End If
                        Next

                    End If
                ElseIf tmpfrmShowReport.claiminfoInvoice.PrdAmt > Integer.Parse("0") Then
                    If lstPartsList.Items.Count > 0 Then

                        For Each lstitem As ListViewItem In lstPartsList.Items
                            If lstitem.SubItems(1).Text.Length >= 7 Then


                                If Not lstitem.SubItems(1).Text.Substring(0, 7).ToLower = LCase("Remarks") Then
                                    tmpfrmShowReport.dtInvoicePartsDetails.Rows.Add(Convert.ToInt32(lstitem.SubItems(0).Text), lstitem.SubItems(1).Text, lstitem.SubItems(2).Text, Convert.ToDouble(lstitem.SubItems(4).Text), Convert.ToDouble(lstitem.SubItems(5).Text))
                                Else
                                    tmpfrmShowReport.dtInvoicePartsDetails.Rows.Add(Convert.ToInt32(lstitem.SubItems(0).Text), "", lstitem.SubItems(1).Text.Substring(Len("Remarks:"), lstitem.SubItems(1).Text.Length - Len("Remarks:")), 0, 0)
                                End If
                            Else
                                tmpfrmShowReport.dtInvoicePartsDetails.Rows.Add(Convert.ToInt32(lstitem.SubItems(0).Text), lstitem.SubItems(1).Text, lstitem.SubItems(2).Text, Convert.ToDouble(lstitem.SubItems(4).Text), Convert.ToDouble(lstitem.SubItems(5).Text))
                            End If
                        Next
                    End If

                End If
            End If
            Else
                tmpfrmShowReport.claiminfoInvoice.Remk = "Estimate Refused"

            End If







            tmpfrmShowReport.Show()






        Exit Sub


        If RecordVerification(strProvider, "tbiBillServiceDetails", "tbiBillServiceDetails.JobCode='" & strtmpJobCode & "'") = True Then
            DeleteRecord("tbiBillServiceDetails", "tbiBillServiceDetails.JobCode='" & strtmpJobCode & "'", "OFF")
        End If

        If lstPartsList.Items.Count > 0 Then


            For shrtLoop = 0 To lstPartsList.Items.Count - 1
                lstTempPartsList = lstPartsList.Items(shrtLoop)
                InsertNewRecord(strProvider, "tbiBillServiceDetails", "SID,JobCode,ProductCode,ProdName,Qty,UnitPrice", lstTempPartsList.Text & ",'" & strtmpJobCode & "','" & lstTempPartsList.SubItems(1).Text & "','" & lstTempPartsList.SubItems(2).Text & "','" & lstTempPartsList.SubItems(3).Text & "'," & Convert.ToInt32(lstTempPartsList.SubItems(5).Text))




            Next


        End If


        tmpfrmShowReport.Show()

    End Sub


    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()

    End Sub

    Private Sub cmbEmployeeCode_FormatInfoChanged(sender As Object, e As EventArgs) Handles cmbEmployeeCode.FormatInfoChanged

    End Sub

    Private Sub chkRemarkEnabled_CheckedChanged(sender As Object, e As EventArgs) Handles chkRemarkEnabled.CheckedChanged
        If chkRemarkEnabled.Checked = True Then
            txtRemarks.Enabled = True
        Else
            txtRemarks.Enabled = False

        End If
    End Sub

    Private Sub chkRemarkEnabled_CheckStateChanged(sender As Object, e As EventArgs) Handles chkRemarkEnabled.CheckStateChanged

    End Sub

    Private Sub chkVatAmount_CheckedChanged(sender As Object, e As EventArgs) Handles chkVatAmount.CheckedChanged
        getVatAmount()
    End Sub




    Private Sub getVatAmount()
        Dim dblFFC As Double
        Dim dblServiceCharge As Double
        Dim dblPartsCharge As Double
        lblVatAmount.Text = 0
        If Integer.TryParse(txtFaultFindingCharge.Text, dblFFC) = False Then
            dblFFC = 0
        End If

        If Integer.TryParse(txtRepairCharge.Text, dblServiceCharge) = False Then
            dblServiceCharge = 0
        End If

        Dim dblVatPercentage As Double = dblVat()




        If chkVatAmount.Checked = True Then
            ' If No Vat found in Database then file if statement
            If dblVatPercentage <= 0 Then
                Dim sender As Object = New Object
                Dim e As EventArgs = New EventArgs
                lblVatAmount_DoubleClick(sender, e)
            End If
            lblVatAmount.Text = ((dblFFC + dblServiceCharge) / 100) * dblVatPercentage
        End If



        If chkParts.Checked = True Then


            If dblparts > 0 Then
            dblPartsCharge = dblparts
        End If

            If lblTotalSpareCost.Text.Length > 0 Then
                lblVatAmount.Text = Convert.ToDouble(lblVatAmount.Text) + (Convert.ToDouble(lblTotalSpareCost.Text) / 100) * dblparts
            End If

        End If




        TotalAmount()
    End Sub
    Private Function dblVat() As Double




        Dim VatM As clsSetVATMethods = New clsSetVATMethods

        Dim lstVAT As List(Of clsSetVAT) = VatM.GetVats.Where(Function(x) x.IsActive = True).ToList

        Dim Vat As clsSetVAT = New clsSetVAT

        If lstVAT.Count > 0 Then

            Vat = lstVAT(0)

        End If

        If Not Vat Is Nothing Then
            dblTServiceCharge = Vat.ServiceCharge
            dblparts = Vat.Parts
        End If

        Return dblTServiceCharge
    End Function
    Private Sub txtFaultFindingCharge_TextChanged(sender As Object, e As EventArgs) Handles txtFaultFindingCharge.TextChanged
        getVatAmount()
    End Sub

    Private Sub txtFaultFindingCharge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFaultFindingCharge.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtRepairCharge_TextChanged(sender As Object, e As EventArgs) Handles txtRepairCharge.TextChanged
        getVatAmount()
    End Sub

    Private Sub txtRepairCharge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRepairCharge.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtRepairCharge_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRepairCharge.KeyDown
        If txtRepairCharge.TextLength <= 0 Then
            txtRepairCharge.Text = Integer.Parse("0")

        End If
        If e.KeyCode = Keys.Enter Then
            txtOtherCharge.Select()
        End If
    End Sub

    Private Sub txtFaultFindingCharge_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFaultFindingCharge.KeyDown
        If txtFaultFindingCharge.TextLength <= 0 Then
            txtFaultFindingCharge.Text = Integer.Parse("0")

        End If

        If e.KeyCode = Keys.Enter Then
            txtRepairCharge.Select()
        End If
    End Sub


    Private Function isValidate() As Boolean



        Return False

    End Function

    Private Sub cmdBill_Click(sender As Object, e As EventArgs) Handles cmdBill.Click
        Dim PersonalMethods As clsPersonalMethods = New clsPersonalMethods
        ReportIdentification = "Delivered"





        ' Check MR Text Box is Blank or not

        'If String.IsNullOrEmpty(txtMR.Text) Or Trim(txtMR.Text) = "" Then
        '    If Not (publicClaiminfo.cFlag = 99 Or publicClaiminfo.cFlag = 100) Then
        '        MessageBox.Show("Fill MRNo")
        '        txtMR.Select()
        '        Exit Sub
        '    End If

        'End If



        ' Check 'DeliveryBy'  Combo Box is Blank or not

        If String.IsNullOrEmpty(cmbEmployeeCode.Text) Or Trim(cmbEmployeeCode.Text) = "" Then
            MessageBox.Show("Fill EmployeeCode")
            cmbEmployeeCode.Select()
            Exit Sub
        Else
            If PersonalMethods.IsExist(cmbEmployeeCode.Text) = False Then
                MessageBox.Show("Employee Code is not found in database")
                cmbEmployeeCode.Select()
                Exit Sub
            End If

        End If

        SaveData()


    End Sub




    Private Sub SaveData()
        Dim tempJobCode As String = publicClaiminfo.Jobcode
        Dim clsclaiminfoMethods As clsClaiminfoMethods = New clsClaiminfoMethods

        Dim claiminfo As clsClaiminfo = New clsClaiminfo
        Dim FFC_Methods As clstbBill_FFCMethods = New clstbBill_FFCMethods
        Dim ERM As clsEstimateRefusedMethods = New clsEstimateRefusedMethods
        Dim ER As clsEstimateRefused = ERM.GetEstimateRefuse(tempJobCode)
        Dim FFC As clstbBill_FFC = FFC_Methods.GetServiceCharge(tempJobCode)
        Dim tmpFFC As clstbBill_FFC = New clstbBill_FFC




        Dim dblSpareAmount As Double
        Dim dblFFC As Double
        Dim dblServiceCharge As Double
        Dim dblVatAmount As Double
        Dim dblOtherAmount As Double
        Dim dblDiscount As Double
        Dim dblAdvanceAmount As Double



        Try


            If Integer.TryParse(lblTotalSpareCost.Text, dblSpareAmount) = False Then
                dblSpareAmount = Integer.Parse("0")
            End If



            If Integer.TryParse(txtFaultFindingCharge.Text, dblFFC) = False Then
                dblFFC = Integer.Parse("0")
            End If

            If Integer.TryParse(txtRepairCharge.Text, dblServiceCharge) = False Then
                dblServiceCharge = Integer.Parse("0")
            End If

            If Integer.TryParse(lblVatAmount.Text, dblVatAmount) = False Then
                dblVatAmount = Integer.Parse("0")
            End If

            If Integer.TryParse(txtOtherCharge.Text, dblOtherAmount) = False Then
                dblOtherAmount = Integer.Parse("0")
            End If

            If Integer.TryParse(txtDiscount.Text, dblDiscount) = False Then
                dblDiscount = Integer.Parse("0")
            End If

            If Integer.TryParse(txtAdvanceAmount.Text, dblAdvanceAmount) = False Then
                dblAdvanceAmount = Integer.Parse("0")
            End If






            claiminfo = publicClaiminfo
            With publicClaiminfo

                claiminfo.Remk = txtRemarks.Text
                If chkFreeofcost.Checked = True Then
                    claiminfo.FreeOfCost = Integer.Parse("1")
                Else
                    claiminfo.FreeOfCost = Integer.Parse("0")
                End If

                If .WCondition = 0 Then ' Product Status Set base on Warranty type

                    If (.cFlag = Integer.Parse("1") Or .cFlag = Integer.Parse("0") Or .cFlag = Integer.Parse("2")) Then
                        If IsNothing(ER.JobCode) Then


                            If chkSpareAmount.Checked = True Then

                                claiminfo.cFlag = Integer.Parse("2")
                            Else

                                claiminfo.cFlag = Integer.Parse("0")
                            End If
                        Else
                            claiminfo.cFlag = Integer.Parse("0")
                        End If

                    ElseIf (.cFlag = Integer.Parse("99") Or .cFlag = Integer.Parse("100")) Then
                        claiminfo.cFlag = Integer.Parse("100")

                    ElseIf (.cFlag = Integer.Parse("101") Or .cFlag = Integer.Parse("102")) Then
                        claiminfo.cFlag = Integer.Parse("102")

                    End If




                ElseIf .WCondition = Integer.Parse("1") Then

                    If (.cFlag = Integer.Parse("1") Or .cFlag = Integer.Parse("0")) Then

                        claiminfo.cFlag = Integer.Parse("0")

                    ElseIf (.cFlag = Integer.Parse("99") Or .cFlag = Integer.Parse("100")) Then

                        claiminfo.cFlag = Integer.Parse("100")

                    ElseIf (.cFlag = Integer.Parse("101") Or .cFlag = Integer.Parse("102")) Then
                        claiminfo.cFlag = Integer.Parse("102")
                    End If

                ElseIf .WCondition = Integer.Parse("2") Then
                    If (.cFlag = Integer.Parse("1") Or .cFlag = Integer.Parse("0")) Then

                        claiminfo.cFlag = Integer.Parse("0")

                    ElseIf (.cFlag = Integer.Parse("99") Or .cFlag = Integer.Parse("100")) Then

                        claiminfo.cFlag = Integer.Parse("100")
                    ElseIf (.cFlag = Integer.Parse("101") Or .cFlag = Integer.Parse("102")) Then
                        claiminfo.cFlag = Integer.Parse("102")
                    End If

                End If
                claiminfo.PrdAmt = dblSpareAmount
                claiminfo.SvAmt = dblFFC + dblServiceCharge
                claiminfo.OtherAmt = dblOtherAmount
                claiminfo.Dis = dblDiscount
                claiminfo.AdvanceAmnt = dblAdvanceAmount
                claiminfo.MRNO = txtMR.Text
                claiminfo.VatAmnt = dblVatAmount
                claiminfo.DeliverBy = cmbEmployeeCode.Text
                claiminfo.DDate = dtpDelivery.Value.ToShortDateString

                tmpFFC.FaultCharge = dblFFC
                tmpFFC.ServiceCharge = dblServiceCharge
                tmpFFC.Jobcode = tempJobCode


                clsclaiminfoMethods.updateclaiminfo(claiminfo, tempJobCode)


                If Not IsNothing(FFC.Jobcode) Then
                    FFC_Methods.Update_Service_Charge(tmpFFC, tempJobCode)
                Else
                    FFC_Methods.Save_Service_Charge(tmpFFC)
                End If

            End With
            If ReportIdentification.ToLower = LCase("Bill") Then
                Exit Sub
            End If
            MessageBox.Show("Delivered Successfully")
            Me.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub




    Private Sub PrintSaveData() 'cflag will Repair or Nr or Replace mode (Non Deliver State)
        Dim tempJobCode As String = publicClaiminfo.Jobcode
        Dim clsclaiminfoMethods As clsClaiminfoMethods = New clsClaiminfoMethods

        Dim claiminfo As clsClaiminfo = New clsClaiminfo
        Dim FFC_Methods As clstbBill_FFCMethods = New clstbBill_FFCMethods
        Dim ERM As clsEstimateRefusedMethods = New clsEstimateRefusedMethods
        Dim ER As clsEstimateRefused = ERM.GetEstimateRefuse(tempJobCode)
        Dim FFC As clstbBill_FFC = FFC_Methods.GetServiceCharge(tempJobCode)
        Dim tmpFFC As clstbBill_FFC = New clstbBill_FFC




        Dim dblSpareAmount As Double
        Dim dblFFC As Double
        Dim dblServiceCharge As Double
        Dim dblVatAmount As Double
        Dim dblOtherAmount As Double
        Dim dblDiscount As Double
        Dim dblAdvanceAmount As Double



        Try


            If Integer.TryParse(lblTotalSpareCost.Text, dblSpareAmount) = False Then
                dblSpareAmount = Integer.Parse("0")
            End If



            If Integer.TryParse(txtFaultFindingCharge.Text, dblFFC) = False Then
                dblFFC = Integer.Parse("0")
            End If

            If Integer.TryParse(txtRepairCharge.Text, dblServiceCharge) = False Then
                dblServiceCharge = Integer.Parse("0")
            End If

            If Integer.TryParse(lblVatAmount.Text, dblVatAmount) = False Then
                dblVatAmount = Integer.Parse("0")
            End If

            If Integer.TryParse(txtOtherCharge.Text, dblOtherAmount) = False Then
                dblOtherAmount = Integer.Parse("0")
            End If

            If Integer.TryParse(txtDiscount.Text, dblDiscount) = False Then
                dblDiscount = Integer.Parse("0")
            End If

            If Integer.TryParse(txtAdvanceAmount.Text, dblAdvanceAmount) = False Then
                dblAdvanceAmount = Integer.Parse("0")
            End If






            claiminfo = publicClaiminfo
            With claiminfo

                claiminfo.Remk = txtRemarks.Text


                claiminfo.PrdAmt = dblSpareAmount
                claiminfo.SvAmt = dblFFC + dblServiceCharge
                claiminfo.OtherAmt = dblOtherAmount
                claiminfo.Dis = dblDiscount
                claiminfo.AdvanceAmnt = dblAdvanceAmount
                claiminfo.MRNO = txtMR.Text
                claiminfo.VatAmnt = dblVatAmount
                claiminfo.DeliverBy = cmbEmployeeCode.Text
                claiminfo.DDate = dtpDelivery.Value.ToShortDateString

                tmpFFC.FaultCharge = dblFFC
                tmpFFC.ServiceCharge = dblServiceCharge
                tmpFFC.Jobcode = tempJobCode


                clsclaiminfoMethods.updateclaiminfo(claiminfo, tempJobCode)


                If Not IsNothing(FFC.Jobcode) Then
                    FFC_Methods.Update_Service_Charge(tmpFFC, tempJobCode)
                Else
                    FFC_Methods.Save_Service_Charge(tmpFFC)
                End If

            End With



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub





    Private Sub txtOtherCharge_TextChanged(sender As Object, e As EventArgs) Handles txtOtherCharge.TextChanged
        TotalAmount()

    End Sub

    Private Sub txtDiscount_TextChanged(sender As Object, e As EventArgs) Handles txtDiscount.TextChanged
        TotalAmount()
    End Sub

    Private Sub chkSpareAmount_CheckedChanged(sender As Object, e As EventArgs) Handles chkSpareAmount.CheckedChanged
        Try
            lblTotalSpareCost.Text = 0
            If chkSpareAmount.Checked = True Then


                If lstPartsList.Items.Count > 0 Then

                    For Each tempitem As ListViewItem In lstPartsList.Items
                        If Not tempitem.SubItems(1).Text.Substring(0, 7).ToLower = LCase("Remarks") Then
                            lblTotalSpareCost.Text = Convert.ToDouble(lblTotalSpareCost.Text) + Convert.ToDouble(tempitem.SubItems(6).Text)
                        End If


                    Next

                End If
            Else


                lblTotalSpareCost.Text = 0
            End If

            TotalAmount()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Invali Function")
        End Try




    End Sub

    Private Sub cmdPreview_Click(sender As Object, e As EventArgs) Handles cmdPreview.Click
        Try

            ReportIdentification = String.Empty
            ReportIdentification = "BillPreview"

            BillInvoice()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub chkFreeofcost_CheckedChanged(sender As Object, e As EventArgs) Handles chkFreeofcost.CheckedChanged

    End Sub

    Private Sub lblVatAmount_Click(sender As Object, e As EventArgs) Handles lblVatAmount.Click

    End Sub

    Private Sub lblVatAmount_DoubleClick(sender As Object, e As EventArgs) Handles lblVatAmount.DoubleClick
        Dim VatForm As frmVAT = New frmVAT

        VatForm.Location = New Point(132, 116)
        VatForm.ShowDialog()
        getVatAmount()


    End Sub

    Private Sub chkParts_CheckedChanged(sender As Object, e As EventArgs) Handles chkParts.CheckedChanged
        getVatAmount()
    End Sub

    Private Sub txtOtherCharge_KeyDown(sender As Object, e As KeyEventArgs) Handles txtOtherCharge.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtDiscount.Select()
        End If
    End Sub

    Private Sub txtDiscount_KeyUp(sender As Object, e As KeyEventArgs) Handles txtDiscount.KeyUp
        If e.KeyCode = Keys.Enter Then
            cmdBill.Select()
        End If
    End Sub
End Class

