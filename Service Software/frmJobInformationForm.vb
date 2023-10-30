Imports System.Data.OleDb



Public Class frmJobInformationForm


    'Dim strtmpCflag As String = ""

    Dim strJobStatus As String = String.Empty


    Private Sub frmJobInformationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If intWarrCondition = -1 Then
        '    LoadInformation_from_NewEntry_Form()
        'End If
        'Me.Left = (My.Computer.Screen.Bounds.Width - Me.Width) / 2
        'Me.Top = (My.Computer.Screen.Bounds.Height - Me.Height) / 2





        Try


            Dim ERM As clsEstimateRefusedMethods = New clsEstimateRefusedMethods
            Dim ER As clsEstimateRefused = ERM.GetEstimateRefuse(publicClaiminfo.Jobcode)

            Dim claiminfomethods As clsClaiminfoMethods = New clsClaiminfoMethods







            ' check Estimate refuse Null or emptry

            If Not IsNothing(ER.JobCode) Then
                strJobStatus = "ER"

            End If


            CenterForm(Me)
            LoadStatus()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Event Error: frmJobInformationForm_Load")
        End Try




    End Sub

    Private Sub LoadStatus()







        With publicClaiminfo


            lblJobNo.Text = .Jobcode
            lblServiceProduct.Text = .ServiceType
            lblBranch.Text = .Branch
            lblName.Text = .CustName
            lblAddress1.Text = .CustAddress1
            lblAddress2.Text = .CustAddress2
            lblEmail.Text = .Email
            lblReceptDate.Text = .ReceptDate.ToShortDateString
            lblAssignto.Text = .IssueTo
            lblExpDelivery.Text = .AppDelDate.ToShortDateString
            lblAssignDate.Text = .IsssueDate.ToShortDateString
            lblReceivedBy.Text = .ReceptBy
            lblServiceby.Text = .ServiceBy
            lblServiceDate.Text = .SDate
            lblCategory.Text = .ServiceType
            lblBrand.Text = .Brand
            lblModel.Text = .ModelNo
            lblSerial.Text = .SLNo
            lblESNno.Text = .ESN

            If .WCondition = 0 Then
                optTBSalesWarranty.Checked = True
                txtTBPurchaseDate.Text = .PDate.ToShortDateString
            ElseIf .WCondition = 1 Then
                optTBNonWarranty.Checked = True
            Else
                optTBServiceWarranty.Checked = True

            End If

            If (.cFlag = 0 Or .cFlag = 1 Or .cFlag = 2) Then 'On Payment (0 = On Payment Delivered and 2 = Sales Warranty Parts Payment Delivered 1 = Pending Delivery)

                If strJobStatus.ToLower <> LCase("ER") Then
                    LoadParts()
                Else
                    LoadEstimatRefuse()
                End If





            ElseIf (.cFlag = 99 Or .cFlag = 100) Then '99 = Nr and 100 = CR
                NRDetails()

            ElseIf (.cFlag = 101 Or .cFlag = 102) Then '101 = Replace Pending Delivery and 102 = Replace Delivered

                ReplaceProduct()
            ElseIf .cFlag = 9 Then '9 = Pending
                Pending()

            ElseIf .cFlag = -1 Then '-1 = Not Service

                lblJobStatus.Text = "Waiting for Service"
                lblJobStatus.ForeColor = Color.White

            End If


        End With
        tbLoadFaultList()
        CallServiceItem()

    End Sub

    Private Sub ReplaceProduct()

    End Sub



    Private Sub Pending()
        Dim pendingMethods As clsPendingMethods = New clsPendingMethods
        Dim Pending As clsPending = pendingMethods.GetPending(publicClaiminfo.Jobcode)

        Dim lstItem As ListViewItem = New ListViewItem
        lblJobStatus.Text = "Pending"
        lblJobStatus.ForeColor = Color.DarkBlue

        If pendingMethods.IsExist(publicClaiminfo.Jobcode) = False Then
            Exit Sub
        End If



        If Not String.IsNullOrEmpty(Pending.PenCode) Then
            lstPartsInformation.Items.Clear()
            lstItem = lstPartsInformation.Items.Add(lstPartsInformation.Items.Count + 1)
            lstItem.SubItems.Add(Pending.PenCode)

        End If
    End Sub

    Private Sub NRDetails()
        Dim NRDetailsMethods As clsNrdetailsMethods = New clsNrdetailsMethods
        Dim NRDetails As clsNrdetails = NRDetailsMethods.GetNR(publicClaiminfo.Jobcode)
        Dim lstItem As ListViewItem = New ListViewItem





        If publicClaiminfo.cFlag = 99 Then
            lblJobStatus.Text = "Not Repairable"
        ElseIf publicClaiminfo.cFlag = 100 Then
            lblJobStatus.Text = "Not Repairable Delivered"
        End If

        If NRDetailsMethods.IsExist(publicClaiminfo.Jobcode) = False Then
            Exit Sub
        End If


        If Not String.IsNullOrEmpty(NRDetails.NRCode) Then
            lstPartsInformation.Items.Clear()
            lstItem = lstPartsInformation.Items.Add(lstPartsInformation.Items.Count + 1)
            lstItem.SubItems.Add(NRDetails.NRCode)

            lblJobStatus.ForeColor = Color.DarkRed

        End If



    End Sub
    Private Sub LoadEstimatRefuse()
        Dim estMethods As clsEstimateRefusedMethods = New clsEstimateRefusedMethods
        Dim est As clsEstimateRefused = estMethods.GetEstimateRefuse(publicClaiminfo.Jobcode)

        Dim lstItem As ListViewItem = New ListViewItem

        If publicClaiminfo.cFlag = 1 Then
            lblJobStatus.Text = "Estimate Refuse"
        Else publicClaiminfo.cFlag = 0 Or publicClaiminfo.cFlag = 2
            lblJobStatus.Text = "Estimate Refuse Delivered"
        End If

        If estMethods.IsExist(publicClaiminfo.Jobcode) = False Then
            Exit Sub
        End If


        lstPartsInformation.Items.Clear()

        If Not String.IsNullOrEmpty(est.JobCode) Then


            lstItem = lstPartsInformation.Items.Add(lstPartsInformation.Items.Count + 1)
            lstItem.SubItems.Add("Description: " & est.EstText & ", Amount: " & est.RefuseAmnt & ", Date: " & est.EstDate.ToShortDateString)


            lblJobStatus.ForeColor = Color.DarkRed
        End If


    End Sub

    Private Sub LoadParts()

        Dim strJobCode As String = String.Empty

        strJobCode = publicClaiminfo.Jobcode
        Dim serviceDetailsMethods As clsServiceDetailsMethods = New clsServiceDetailsMethods
        Dim serviceDetails As clsServiceDetails = serviceDetailsMethods.GetPartsDetails(strJobCode)
        If publicClaiminfo.cFlag = 0 Or publicClaiminfo.cFlag = 2 Then
            lblJobStatus.Text = "Delivered"
        ElseIf publicClaiminfo.cFlag = 1 Then
            lblJobStatus.Text = "Service Complete"
        End If

        lblJobStatus.ForeColor = Color.DarkRed

        If serviceDetailsMethods.IsExist(strJobCode) = False Then
            Exit Sub
        End If


        Dim lstItem As ListViewItem = New ListViewItem

        lstPartsInformation.Items.Clear()


        For Each TempDetails As String In serviceDetails.Description.Split("|")
            Dim TempSubDetails As String() = TempDetails.Split(",")


            If Not String.IsNullOrEmpty(TempSubDetails(0).ToString) Then

                If TempSubDetails(0).Length >= 7 Then

                    If TempSubDetails(0).Substring(0, 7).ToLower = LCase("Remarks") Then
                        lstItem = lstPartsInformation.Items.Add(lstPartsInformation.Items.Count + 1)
                        lstItem.SubItems.Add(TempSubDetails(0))



                    Else


                        lstItem = lstPartsInformation.Items.Add(lstPartsInformation.Items.Count + 1)
                        lstItem.SubItems.Add(TempSubDetails(0))
                        lstItem.SubItems.Add(TempSubDetails(1))
                        lstItem.SubItems.Add(String.Empty)
                        lstItem.SubItems.Add(TempSubDetails(2))
                        lstItem.SubItems.Add(TempSubDetails(3))
                        lstItem.SubItems.Add(Convert.ToInt32(TempSubDetails(2)) * Convert.ToDouble(TempSubDetails(3)))

                    End If
                Else
                    lstItem = lstPartsInformation.Items.Add(lstPartsInformation.Items.Count + 1)
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






    Private Sub cmdService_Click(sender As Object, e As EventArgs) Handles cmdService.Click
        Dim frmTempProductEntry As New frmProductEntry

        If publicClaiminfo.cFlag = 0 Or publicClaiminfo.cFlag = 2 Or publicClaiminfo.cFlag = 100 Or publicClaiminfo.cFlag = 102 Then

            If MessageBox.Show("Job is already delivered mode.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then

                Exit Sub
            End If



        End If

            FormOpecityDecrease(Me, 0.5)


        frmTempProductEntry.ShowDialog()
        FormOpecityIncrease(Me, 1)

        'LoadServiceInformation(strTmpCFlag, strtmpMRNo)
        'TechnicianName(strTempTechnicianCode, lblServiceby)
        'getProductStatus(strTmpCFlag, strtmpMRNo)


    End Sub

    Private Sub frmJobInformationForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        cmdService.Left = grpServiceStatus.Left
        cmdService.Width = (grpServiceStatus.Width / 6) - 1
        cmdPending.Left = (cmdService.Left + cmdService.Width) + 1
        cmdPending.Width = (grpServiceStatus.Width / 6) - 5
        cmdAbort.Left = (cmdPending.Left + cmdPending.Width) + 1
        cmdAbort.Width = (grpServiceStatus.Width / 6) - 1
        cmdReplace.Left = (cmdAbort.Left + cmdAbort.Width) + 1
        cmdReplace.Width = (grpServiceStatus.Width / 6) - 1
        cmdBill.Left = (cmdReplace.Left + cmdReplace.Width) + 1
        cmdBill.Width = (grpServiceStatus.Width / 6) - 1
        cmdClose.Left = (cmdBill.Left + cmdBill.Width) + 1
        cmdClose.Width = (grpServiceStatus.Width / 6) - 1


        cmdService.Top = Me.ClientSize.Height - cmdService.Height
        cmdPending.Top = Me.ClientSize.Height - cmdService.Height
        cmdAbort.Top = Me.ClientSize.Height - cmdService.Height

        cmdReplace.Top = Me.ClientSize.Height - cmdService.Height
        cmdBill.Top = Me.ClientSize.Height - cmdService.Height
        cmdClose.Top = Me.ClientSize.Height - cmdService.Height


    End Sub

    Private Sub cmdPending_Click(sender As Object, e As EventArgs) Handles cmdPending.Click
        Dim frmTempPending As New frmPending
        'Dim frmTempJobInformation As New frmJobInformationForm


        If publicClaiminfo.cFlag = 0 Or publicClaiminfo.cFlag = 2 Or publicClaiminfo.cFlag = 100 Or publicClaiminfo.cFlag = 102 Then

            If MessageBox.Show("Job is already delivered mode.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then

                Exit Sub
            End If

        End If


        FormOpecityDecrease(Me, 0.5)



        frmTempPending.ShowDialog()




        FormOpecityIncrease(Me, 1)

        'LoadServiceInformation(strTmpCFlag, strtmpMRNo)
        'TechnicianName(strTempTechnicianCode, lblServiceby)
        'getProductStatus(strTmpCFlag, strtmpMRNo)



    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click


        Me.Close()


    End Sub

    Private Sub cmdAbort_Click(sender As Object, e As EventArgs) Handles cmdAbort.Click
        Dim frmtmpAbort As New frmAbort


        If publicClaiminfo.cFlag = 0 Or publicClaiminfo.cFlag = 2 Or publicClaiminfo.cFlag = 100 Or publicClaiminfo.cFlag = 102 Then
            If MessageBox.Show("Job is already delivered mode.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then

                Exit Sub
            End If

        End If


        FormOpecityDecrease(Me, 0.5)

        frmtmpAbort.ShowDialog()

        FormOpecityIncrease(Me, 1)

        'LoadServiceInformation(strTmpCFlag, strtmpMRNo)
        'TechnicianName(strTempTechnicianCode, lblServiceby)
        'getProductStatus(strTmpCFlag, strtmpMRNo)


    End Sub

    Private Sub cmdReplace_Click(sender As Object, e As EventArgs) Handles cmdReplace.Click
        Dim frmtmpReplaceEntry As New frmReplaceEntry


        If publicClaiminfo.cFlag = 0 Or publicClaiminfo.cFlag = 2 Or publicClaiminfo.cFlag = 100 Or publicClaiminfo.cFlag = 102 Then

            MessageBox.Show("Job is already delivered mode. You cannot modify it ")
            Exit Sub

        End If

        FormOpecityDecrease(frmMdimain, 0.25)
        FormOpecityDecrease(Me, 0.5)





        frmtmpReplaceEntry.ShowDialog()
        FormOpecityIncrease(Me, 1)



        'LoadServiceInformation(strTmpCFlag, strtmpMRNo)
        'TechnicianName(strTempTechnicianCode, lblServiceby)
        'getProductStatus(strTmpCFlag, strtmpMRNo)



    End Sub

    Private Sub cmdBill_Click(sender As Object, e As EventArgs) Handles cmdBill.Click
        Dim frmOnePaymenttmp As New frmOnpayment_Bill_Format
        Try



            If publicClaiminfo.cFlag = -1 Then
                MessageBox.Show("Product is in 'Waiting for Service' Mode")
                Exit Sub
            ElseIf publicClaiminfo.cFlag = 9 Then
                MessageBox.Show("Product is in 'Pending' Mode")
                Exit Sub
            End If

            FormOpecityDecrease(Me, 0.7)

            frmOnePaymenttmp.ShowDialog()
            FormOpecityIncrease(Me, 1)
        Catch BillEX As Exception
            MsgBox(BillEX.Message & " " & BillEX.StackTrace, vbCritical, "Event Error: cmdBill_Click")
        End Try





    End Sub





    Private Sub RemoveJobStatus(ByVal strtmpJobFlag As String, Optional strtmpMRNOforestRefuse As String = "")
        Dim tmpConnection As New OleDbConnection(strProvider)
        Dim dcRemoveJobStatus As OleDbCommand = Nothing

        Dim strSQLRemoveCriteria As String = ""
        Dim strSQLRemoveCriteriaOthers As String = ""


        Select Case strtmpJobFlag

            Case 1
                strSQLRemoveCriteria = "Delete * from ServiceDetails where ServiceDetails.JobCode='" & strtmpJobCode & "'"
                dcRemoveJobStatus = New OleDbCommand(strSQLRemoveCriteria, tmpConnection)

            Case 9
                strSQLRemoveCriteria = "Delete * from Pending where Pending.JobCode='" & strtmpJobCode & "'"
                dcRemoveJobStatus = New OleDbCommand(strSQLRemoveCriteria, tmpConnection)
                dcRemoveJobStatus.ExecuteNonQuery()
                dcRemoveJobStatus.Dispose()

                strSQLRemoveCriteriaOthers = "Delete * from PendingOther where PendingOther.JobCode= '" & strtmpJobCode & "'"
                dcRemoveJobStatus = New OleDbCommand(strSQLRemoveCriteriaOthers, tmpConnection)
            Case 99
                strSQLRemoveCriteria = "Delete * from NRDetails where NRDetails.JobCode='" & strtmpJobCode & "'"
                dcRemoveJobStatus = New OleDbCommand(strSQLRemoveCriteria, tmpConnection)
                dcRemoveJobStatus.ExecuteNonQuery()
                dcRemoveJobStatus.Dispose()

                strSQLRemoveCriteriaOthers = "Delete * from NROthers where NROthers.JobCode= '" & strtmpJobCode & "'"
                dcRemoveJobStatus = New OleDbCommand(strSQLRemoveCriteriaOthers, tmpConnection)
            Case 0
                If strtmpMRNOforestRefuse = "Est Refuse" Then
                    strSQLRemoveCriteria = "Delete * from EstimateRefused where EstimateRefused.JobCode='" & strtmpJobCode & "'"
                    dcRemoveJobStatus = New OleDbCommand(strSQLRemoveCriteria, tmpConnection)
                End If

        End Select





        dcRemoveJobStatus.ExecuteNonQuery()
        dcRemoveJobStatus.Dispose()









    End Sub





    Private Sub LoadServiceInformation(ByVal strtempCflag As String, ByVal strServiceMrNo As String)

        Dim conLoadServiceInformation As New OleDbConnection(strProvider)
        If strTmpCFlag = "1" Or strTmpCFlag = "0" Or strTmpCFlag = "2" Then
            If strServiceMrNo = "Est Refuse" Then
                LoadEstimateRefused()
            Else
                RepaireStatus()
            End If







        ElseIf strTmpCFlag = "9" Then
            LoadPendingStatus()


        ElseIf strTmpCFlag = "99" Then
            LoadNRInformation()

        ElseIf strtmpJobCode = "100" Then
            LoadNRInformation()


        ElseIf strTmpCFlag = "101" Or strTmpCFlag = "102" Then
            LoadReplaceInformation()

        End If

        If strTmpCFlag <> "-1" Then
            Dim drLoadSdate As OleDbDataReader = Nothing

            LoadAllInformation(conLoadServiceInformation, drLoadSdate, strProvider, "Claiminfo", "Claiminfo.Sdate", "Claiminfo.JobCOde='" & strtmpJobCode & "'")

            If drLoadSdate.HasRows = True Then
                drLoadSdate.Read()
                lblServiceDate.Text = Convert.ToDateTime(drLoadSdate("Sdate").ToString).ToShortDateString

            End If
        End If


        TempConnectionDispose(conLoadServiceInformation)

    End Sub

    Private Sub tbLoadFaultList()





        Dim CustClaimMethods As clsCustomerClaimMethods = New clsCustomerClaimMethods
        Dim Customerclaim As clsCustomerClaim = New clsCustomerClaim
        Dim lstItem As ListViewItem = New ListViewItem
        lstTBFaultList.Items.Clear()

        If CustClaimMethods.IsExist(publicClaiminfo.Jobcode) Then
            Customerclaim = CustClaimMethods.GetCustomerClaim(publicClaiminfo.Jobcode)
            lstItem = lstTBFaultList.Items.Add(lstTBFaultList.Items.Count + 1)
            lstItem.SubItems.Add(Customerclaim.ClaimCode)
        End If




    End Sub



    Private Sub CallServiceItem()





        Dim ServiceItemMethods As clsServiceItemMethods = New clsServiceItemMethods
        Dim serviceItem As clsServiceItem = New clsServiceItem
        Dim lstItem As ListViewItem = New ListViewItem
        lstTBItemList.Items.Clear()

        If ServiceItemMethods.IsExist(publicClaiminfo.Jobcode) = True Then

            serviceItem = ServiceItemMethods.GetItem(publicClaiminfo.Jobcode)
            lstItem = lstTBItemList.Items.Add(lstTBItemList.Items.Count + 1)
            lstItem.SubItems.Add(serviceItem.Item)
        End If




    End Sub

    Private Sub CallFaultEvents()
        loadFaultList(strtmpJobCode, lstTBFaultList)
    End Sub



    Private Sub LoadPendingStatus()

        Dim ConPendingStatus As New OleDbConnection(strProvider)
        ConPendingStatus.Open()
        Dim dcPendingStatus As OleDbCommand = Nothing
        Dim drPendingStatus As OleDbDataReader = Nothing


        Dim lstPendingItem As ListViewItem = Nothing
        Dim shrtSL As Short = 0


        Dim strSQLLoadPendingInformation As String = ""

        strSQLLoadPendingInformation = "Select Pending.Pencode from Pending where Pending.JobCOde='" & strtmpJobCode & "'"


        dcPendingStatus = New OleDbCommand(strSQLLoadPendingInformation, ConPendingStatus)
        drPendingStatus = dcPendingStatus.ExecuteReader

        If drPendingStatus.HasRows = True Then
            lstPartsInformation.Items.Clear()

            While drPendingStatus.Read
                shrtSL = shrtSL + 1

                lstPendingItem = lstPartsInformation.Items.Add(shrtSL)
                lstPendingItem.SubItems.Add(drPendingStatus("Pencode").ToString)
            End While

        End If

        If RecordVerification(strProvider, "PendingOther", "PendingOther.JobCode='" & strtmpJobCode & "'") = True Then
            Dim strLoadPendingOtherInformation As String = ""
            Dim drLoadPendingothers As OleDbDataReader = Nothing
            Dim dcLoadPendingOther As OleDbCommand = Nothing


            strLoadPendingOtherInformation = "Select PendingOther.PenCode from PendingOther where PendingOther.JobCOde='" & strtmpJobCode & "'"

            dcLoadPendingOther = New OleDbCommand(strLoadPendingOtherInformation, ConPendingStatus)

            drLoadPendingothers = dcLoadPendingOther.ExecuteReader

            If drLoadPendingothers.HasRows = True Then
                drLoadPendingothers.Read()
                shrtSL = shrtSL + 1
                lstPendingItem = lstPartsInformation.Items.Add(shrtSL)
                lstPendingItem.SubItems.Add(drLoadPendingothers("Pencode").ToString)

            End If
            TempDatareaderClose(drLoadPendingothers)
            TempCommandDispose(dcLoadPendingOther)



        End If

        TempDatareaderClose(drPendingStatus)
        TempCommandDispose(dcPendingStatus)
        TempConnectionDispose(ConPendingStatus)


    End Sub




    Private Sub RepaireStatus()

        Dim conRepaireStatus As New OleDbConnection(strProvider)
        conRepaireStatus.Open()
        Dim dcLoadserviceInformation As OleDbCommand = Nothing
        Dim drLoadserviceInformation As OleDbDataReader = Nothing
        Dim strSQLLoadServiceInformation As String = ""

        Dim lstPartsrepairedItem As ListViewItem = Nothing
        Dim shrtSL As Short = 0

        strSQLLoadServiceInformation = "Select Servicedetails.JobCode,ServiceDetails.ProductCode,Product.Measure,Servicedetails.Qty,Servicedetails.UnitPrice,Servicedetails.Remarks,Product.ProdName from Servicedetails left Join Product on Servicedetails.Productcode=Product.Code where Servicedetails.JobCode='" & strtmpJobCode & "'"

        dcLoadserviceInformation = New OleDbCommand(strSQLLoadServiceInformation, conRepaireStatus)

        drLoadserviceInformation = dcLoadserviceInformation.ExecuteReader

        If drLoadserviceInformation.HasRows = True Then
            lstPartsInformation.Items.Clear()
            lstPartsInformation.Refresh()



            While drLoadserviceInformation.Read
                shrtSL = shrtSL + 1


                If drLoadserviceInformation("Remarks").ToString = "" Then
                    lstPartsrepairedItem = lstPartsInformation.Items.Add(shrtSL)
                    lstPartsrepairedItem.SubItems.Add(drLoadserviceInformation("ProductCode").ToString)
                    If String.IsNullOrEmpty(drLoadserviceInformation("ProdName").ToString) Then
                        lstPartsrepairedItem.SubItems.Add("Product Name not found")
                        lstPartsrepairedItem.BackColor = Color.PaleGoldenrod

                        lstPartsrepairedItem.ForeColor = Color.Red

                    Else
                        lstPartsrepairedItem.SubItems.Add(drLoadserviceInformation("ProdName").ToString)
                    End If

                    lstPartsrepairedItem.SubItems.Add(drLoadserviceInformation("Measure").ToString)
                    lstPartsrepairedItem.SubItems.Add(drLoadserviceInformation("Qty").ToString)

                    lstPartsrepairedItem.SubItems.Add(drLoadserviceInformation("UnitPrice").ToString)
                    lstPartsrepairedItem.SubItems.Add(Convert.ToInt32(drLoadserviceInformation("Qty").ToString) * Convert.ToInt32(drLoadserviceInformation("UnitPrice").ToString))
                Else
                    lstPartsrepairedItem = lstPartsInformation.Items.Add(shrtSL)
                    lstPartsrepairedItem.SubItems.Add(drLoadserviceInformation("Remarks").ToString)

                End If

            End While


        End If

        TempDatareaderClose(drLoadserviceInformation)
        TempCommandDispose(dcLoadserviceInformation)

        TempConnectionDispose(conRepaireStatus)
    End Sub



    Private Sub LoadNRInformation()
        Dim drLoadNRInformation As OleDbDataReader = Nothing

        Dim conLoadNRInformation As New OleDbConnection(strProvider)

        LoadAllInformation(conLoadNRInformation, drLoadNRInformation, strProvider, "NRDetails", "NRDetails.NRCOde", "NRDetails.JobCOde='" & strtmpJobCode & "'")
        Dim lstItem As ListViewItem = Nothing



        If drLoadNRInformation.HasRows = True Then
            lstPartsInformation.Items.Clear()

            Do While drLoadNRInformation.Read
                lstItem = lstPartsInformation.Items.Add(lstPartsInformation.Items.Count + 1)
                lstItem.SubItems.Add(drLoadNRInformation("NRCODE").ToString)

            Loop
        End If

        If RecordVerification(strProvider, "NROthers", "NROthers.JobCode='" & strtmpJobCode & "'") = True Then
                Dim drLoadNROthersInformation As OleDbDataReader = Nothing

            LoadAllInformation(conLoadNRInformation, drLoadNROthersInformation, strProvider, "NROthers", "NROthers.NRCOde", "NROthers.JobCOde='" & strtmpJobCode & "'")

            If drLoadNROthersInformation.HasRows = True Then
                    While drLoadNROthersInformation.Read
                        lstItem = lstPartsInformation.Items.Add(lstPartsInformation.Items.Count + 1)
                        lstItem.SubItems.Add(drLoadNROthersInformation("NRCODE").ToString)
                    End While

                End If
            End If





        'TempDatareaderClose(drLoadNRInformation)
        lstItem = Nothing

        TempConnectionDispose(conLoadNRInformation)

    End Sub

    Private Sub LoadEstimateRefused()
        Dim drLoadEstimateRefuse As OleDbDataReader = Nothing
        Dim lstEstimateRefusedItem As ListViewItem = Nothing
        Dim strEstimateRefused As String = ""

        Dim conLoadEstimateRefused As New OleDbConnection(strProvider)
        LoadAllInformation(conLoadEstimateRefused, drLoadEstimateRefuse, strProvider, "EstimateRefused", "*", "EstimateRefused.JobCode='" & strtmpJobCode & "'")


        If drLoadEstimateRefuse.HasRows = True Then
            lstPartsInformation.Items.Clear()
            While drLoadEstimateRefuse.Read
                strEstimateRefused = strEstimateRefused & drLoadEstimateRefuse("EstText").ToString & ","
                strEstimateRefused = strEstimateRefused & drLoadEstimateRefuse("RefuseAmnt").ToString & ","
                TechnicianName(drLoadEstimateRefuse("ServiceBy_ID").ToString, lblServiceby)
                lblServiceDate.Text = Convert.ToDateTime(drLoadEstimateRefuse("EstDate").ToString)

            End While
            lstEstimateRefusedItem = lstPartsInformation.Items.Add(lstPartsInformation.Items.Count + 1)
            lstEstimateRefusedItem.SubItems.Add(strEstimateRefused)

        End If


        TempDatareaderClose(drLoadEstimateRefuse)
        TempConnectionDispose(conLoadEstimateRefused)
    End Sub


    Private Sub getProductStatus(ByVal strTempPFLag As String, ByVal strTempMRValue As String)

        Dim drReapiredCompleted As OleDbDataReader = Nothing
        Dim conGetProductStatus As New OleDbConnection(strProvider)
        Select Case strTempPFLag





            Case 1
                If strTempMRValue = "Est Refuse" Then
                    lblJobStatus.Text = "Pending Delivery (Estimate Refuse)"
                Else
                    lblJobStatus.Text = "Pending Delivery (Repair Completed)"
                End If




            Case "9"
                lblJobStatus.Text = "Pending"

            Case "99"
                lblJobStatus.Text = "Pending Delivery NR(Abort)"

            Case "100"
                lblJobStatus.Text = "Delivered (Return to Customer)"

            Case "0"
                If strTempMRValue = "Est Refuse" Then
                    lblJobStatus.Text = "Delivered (Estimate Refuse)"

                Else
                    lblJobStatus.Text = "Delivered"
                End If

            Case "2"
                If strTempMRValue = "Est Refuse" Then
                    lblJobStatus.Text = "Delivered (Estimate Refuse)"

                Else
                    lblJobStatus.Text = "Delivered"
                End If

            Case "101"
                lblJobStatus.Text = "Replace"
            Case "102"
                lblJobStatus.Text = "Replace Delivered"

            Case Else
                lblJobStatus.Text = "Waiting for Service"

                LoadAllInformation(conGetProductStatus, drReapiredCompleted, strProvider, "Claiminfo", "Claiminfo.IssueTo", "Claiminfo.JobCode='" & strtmpJobCode & "'")

                If drReapiredCompleted.HasRows = True Then
                    While drReapiredCompleted.Read
                        strTempTechnicianCode = drReapiredCompleted("IssueTo").ToString


                    End While
                End If


                Exit Sub

        End Select



        LoadAllInformation(conGetProductStatus, drReapiredCompleted, strProvider, "Claiminfo", "Claiminfo.ServiceBy,Claiminfo.Sdate", "Claiminfo.JobCode='" & strtmpJobCode & "'")
        If drReapiredCompleted.HasRows = True Then
            While drReapiredCompleted.Read
                strTempTechnicianCode = drReapiredCompleted("Serviceby").ToString
                TechnicianName(strTempTechnicianCode, lblServiceby)

            End While


        End If

        TempConnectionDispose(conGetProductStatus)

    End Sub



    Private Sub LoadReplaceInformation()
        Dim drLoadReplaceInformation As OleDbDataReader = Nothing

        Dim shrtReplaceFieldCount As Short = 0
        Dim lstReplaceInformation As ListViewItem 
        Dim strReplaceInformation As String = String.Empty

        Dim conLoadReplaceInformation As New OleDbConnection(strProvider)

        LoadAllInformation(conLoadReplaceInformation, drLoadReplaceInformation, strProvider, "Replace", "Replace.JobCode,Replace.Brand,Replace.Model,Replace.ESN,Replace.ESNb,Replace.SLNo,Replace.Other,Replace.RDate,Replace.ReplaceBy", "Replace.JobCOde='" & strtmpJobCode & "'")

        lstPartsInformation.Items.Clear()

        If drLoadReplaceInformation.HasRows Then


            While drLoadReplaceInformation.Read
                For shrtReplaceFieldCount = 0 To drLoadReplaceInformation.FieldCount - 1
                    If drLoadReplaceInformation.GetName(shrtReplaceFieldCount).Equals("Rdate", StringComparison.InvariantCultureIgnoreCase) Then
                        strReplaceInformation = strReplaceInformation & Convert.ToDateTime(drLoadReplaceInformation(shrtReplaceFieldCount).ToString).ToShortDateString & ","
                    Else

                        strReplaceInformation = strReplaceInformation & drLoadReplaceInformation(shrtReplaceFieldCount).ToString & ","
                    End If


                Next
            End While
            If strReplaceInformation.Length > 0 Then

                If strReplaceInformation.Substring(strReplaceInformation.Length - 1) = "," Then
                strReplaceInformation = strReplaceInformation.Substring(0, strReplaceInformation.Length - 1)
            End If

            End If

            lstReplaceInformation = lstPartsInformation.Items.Add(lstPartsInformation.Items.Count + 1)
            lstReplaceInformation.SubItems.Add(strReplaceInformation)

        End If
        TempConnectionDispose(conLoadReplaceInformation)


    End Sub

    Private Sub frmJobInformationForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        LoadStatus()

    End Sub
End Class