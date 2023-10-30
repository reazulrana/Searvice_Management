Imports System
Imports System.Data.OleDb
Imports System.Data
Imports System.Configuration
Imports System.IO
Imports System.Threading


Public Class frmMergeDatabase
    Dim strPath As String = String.Empty

    Dim beginTime As TimeSpan = Now.TimeOfDay
    Private Sub frmMergeDatabase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterForm(Me)
        Timer1.Enabled = False
        optNormalLoad.Checked = True


    End Sub









    Private Function GetClaiminfo() As IEnumerable(Of clsClaiminfo)
        Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath
        Dim Claiminfo As List(Of clsClaiminfo) = New List(Of clsClaiminfo)
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcLoadClaiminf As OleDbCommand = New OleDbCommand("Select * from Claiminfo", con)
            con.Open()
            Dim drLoadClaiminfo = dcLoadClaiminf.ExecuteReader
            If drLoadClaiminfo.HasRows = True Then
                While drLoadClaiminfo.Read
                    Dim tmpClaiminfo As clsClaiminfo = New clsClaiminfo
                    tmpClaiminfo.JobID = Convert.ToInt32(drLoadClaiminfo("JobID").ToString())
                    tmpClaiminfo.Jobcode = drLoadClaiminfo("Jobcode").ToString()
                    tmpClaiminfo.Branch = drLoadClaiminfo("Branch").ToString()
                    tmpClaiminfo.CustName = drLoadClaiminfo("CustName").ToString()
                    tmpClaiminfo.CustAddress1 = drLoadClaiminfo("CustAddress1").ToString()
                    tmpClaiminfo.CustAddress2 = drLoadClaiminfo("CustAddress2").ToString()
                    tmpClaiminfo.Brand = drLoadClaiminfo("Brand").ToString()
                    tmpClaiminfo.ModelNo = drLoadClaiminfo("ModelNo").ToString()
                    tmpClaiminfo.MobileNo = drLoadClaiminfo("MobileNo").ToString()
                    tmpClaiminfo.ESN = drLoadClaiminfo("ESN").ToString()
                    tmpClaiminfo.SLNo = drLoadClaiminfo("SLNo").ToString()

                    If Not String.IsNullOrEmpty(drLoadClaiminfo("ReceptDate").ToString()) Then
                        tmpClaiminfo.ReceptDate = Convert.ToDateTime(drLoadClaiminfo("ReceptDate").ToString())
                    End If

                    If Not String.IsNullOrEmpty(drLoadClaiminfo("AppDelDate").ToString()) Then
                        tmpClaiminfo.AppDelDate = Convert.ToDateTime(drLoadClaiminfo("AppDelDate").ToString())
                    End If


                    tmpClaiminfo.ServiceType = drLoadClaiminfo("ServiceType").ToString()
                    If Not String.IsNullOrEmpty(drLoadClaiminfo("PDate").ToString()) Then
                        tmpClaiminfo.PDate = Convert.ToDateTime(drLoadClaiminfo("PDate").ToString())
                    End If

                    tmpClaiminfo.ReceptBy = drLoadClaiminfo("ReceptBy").ToString()
                    tmpClaiminfo.IssueTo = drLoadClaiminfo("IssueTo").ToString()

                    If Not String.IsNullOrEmpty(drLoadClaiminfo("IsssueDate").ToString()) Then
                        tmpClaiminfo.IsssueDate = Convert.ToDateTime(drLoadClaiminfo("IsssueDate").ToString())
                    End If

                    If Not String.IsNullOrEmpty(drLoadClaiminfo("SDate").ToString()) Then
                        tmpClaiminfo.SDate = Convert.ToDateTime(drLoadClaiminfo("SDate").ToString())
                    End If


                    tmpClaiminfo.ServiceBy = drLoadClaiminfo("ServiceBy").ToString()
                    If Not String.IsNullOrEmpty(drLoadClaiminfo("DDate").ToString()) Then
                        tmpClaiminfo.DDate = Convert.ToDateTime(drLoadClaiminfo("DDate").ToString())
                    End If

                    tmpClaiminfo.DeliverBy = drLoadClaiminfo("DeliverBy").ToString()
                    If Not String.IsNullOrEmpty(drLoadClaiminfo("WCondition").ToString()) Then
                        tmpClaiminfo.WCondition = Convert.ToInt32(drLoadClaiminfo("WCondition").ToString())
                    End If

                    If Not String.IsNullOrEmpty(drLoadClaiminfo("cFlag").ToString()) Then
                        tmpClaiminfo.cFlag = Convert.ToInt32(drLoadClaiminfo("cFlag").ToString())
                    End If

                    If Not String.IsNullOrEmpty(drLoadClaiminfo("SvAmt").ToString()) Then
                        tmpClaiminfo.SvAmt = Convert.ToInt32(drLoadClaiminfo("SvAmt").ToString())
                    End If

                    If Not String.IsNullOrEmpty(drLoadClaiminfo("PrdAmt").ToString()) Then
                        tmpClaiminfo.PrdAmt = Convert.ToInt32(drLoadClaiminfo("PrdAmt").ToString())
                    End If

                    If Not String.IsNullOrEmpty(drLoadClaiminfo("OtherAmt").ToString()) Then
                        tmpClaiminfo.OtherAmt = Convert.ToInt32(drLoadClaiminfo("OtherAmt").ToString())
                    End If
                    If Not String.IsNullOrEmpty(drLoadClaiminfo("Dis").ToString()) Then
                        tmpClaiminfo.Dis = Convert.ToInt32(drLoadClaiminfo("Dis").ToString())
                    End If


                    If Not String.IsNullOrEmpty(drLoadClaiminfo("SRFlag").ToString()) Then
                        tmpClaiminfo.SRFlag = Convert.ToInt32(drLoadClaiminfo("SRFlag").ToString())
                    End If

                    tmpClaiminfo.Remk = drLoadClaiminfo("Remk").ToString()
                    tmpClaiminfo.PhyCond = drLoadClaiminfo("PhyCond").ToString()
                    tmpClaiminfo.Log_User = drLoadClaiminfo("Log_User").ToString()
                    If Not String.IsNullOrEmpty(drLoadClaiminfo("Log_Date").ToString()) Then
                        tmpClaiminfo.Log_Date = Convert.ToDateTime(drLoadClaiminfo("Log_Date").ToString())
                    End If

                    tmpClaiminfo.MRNO = drLoadClaiminfo("MRNO").ToString()
                    tmpClaiminfo.LastJobNO = drLoadClaiminfo("LastJobNO").ToString()
                    If Not String.IsNullOrEmpty(drLoadClaiminfo("cAdvance").ToString()) Then
                        tmpClaiminfo.cAdvance = Convert.ToDouble(drLoadClaiminfo("cAdvance").ToString())
                    End If

                    If Not String.IsNullOrEmpty(drLoadClaiminfo("cTransportCrg").ToString()) Then
                        tmpClaiminfo.cTransportCrg = Convert.ToDouble(drLoadClaiminfo("cTransportCrg").ToString())
                    End If

                    tmpClaiminfo.ReturnedItems = drLoadClaiminfo("ReturnedItems").ToString()
                    tmpClaiminfo.ItemRemarks = drLoadClaiminfo("ItemRemarks").ToString()
                    If Not String.IsNullOrEmpty(drLoadClaiminfo("FreeOfCost").ToString()) Then
                        tmpClaiminfo.FreeOfCost = Convert.ToInt32(drLoadClaiminfo("FreeOfCost").ToString())
                    End If
                    If Not String.IsNullOrEmpty(drLoadClaiminfo("AdvanceAmnt").ToString()) Then
                        tmpClaiminfo.AdvanceAmnt = Convert.ToDouble(drLoadClaiminfo("AdvanceAmnt").ToString())
                    End If
                    If Not String.IsNullOrEmpty(drLoadClaiminfo("VatAmnt").ToString()) Then
                        tmpClaiminfo.VatAmnt = Convert.ToInt32(drLoadClaiminfo("VatAmnt").ToString())
                    End If


                    Claiminfo.Add(tmpClaiminfo)




                End While


            End If




            Return Claiminfo

        End Using

    End Function

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Me.Dispose()

    End Sub

    Private Sub btnOpenFile_Click(sender As Object, e As EventArgs) Handles btnOpenFile.Click

        dlgFileOpen.Filter = "Ms access (*.mdb)|*.mdb"
        dlgFileOpen.ShowDialog()


        If dlgFileOpen.FileName <> "" Then
            strPath = dlgFileOpen.FileName
            lblMessage.Text = strPath
            btnMerge.Enabled = True


        End If
    End Sub

    Private Sub btnMerge_Click(sender As Object, e As EventArgs) Handles btnMerge.Click


        If strPath = "" Then
            MessageBox.Show("File not Seleted")
            btnOpenFile_Click(sender, e)
            Exit Sub
        End If
        btnOpenFile.Enabled = False
        lblClose.Enabled = False
        btnClose.Enabled = False
        btnMerge.Enabled = False






        Dim strMessage As String = String.Empty


        Dim strJobCode As String = String.Empty

        Try


            If optFastLoad.Checked = True Then



                lblStartTime.Text = beginTime.Hours.ToString & "-" & beginTime.Minutes.ToString & "-" & beginTime.Seconds.ToString
                Timer1.Enabled = True

                prgbarMerger.Minimum = 0
                prgbarMerger.Maximum = 100
                prgbarMerger.Value = 0


                QuickImportData()
                ' Customer Claim

                beginTime = Now.TimeOfDay

                Application.DoEvents()
                lblProcessingTable.Text = " Collecting Data from Customer Claim"

                Dim ListCusClaim As List(Of clsCustomerClaim) = GetAllCustomerClaim.ToList
                strMessage = "Import Tabel: Customer Claim"
                lblProcessingTable.Text = strMessage
                Dim custclaimMethods As clsCustomerClaimMethods = New clsCustomerClaimMethods
                If ListCusClaim.Count > 0 Then
                    prgbarMerger.Minimum = 0
                    prgbarMerger.Maximum = ListCusClaim.Count
                    prgbarMerger.Value = 0
                    For Each cust As clsCustomerClaim In ListCusClaim
                        Application.DoEvents()
                        If custclaimMethods.IsExist(cust.Jobcode) = False Then
                            custclaimMethods.Save(cust)
                        End If
                        lblProcessingTable.Text = strMessage & " Total Record : " & ListCusClaim.Count & " Current Record : " & prgbarMerger.Value
                        prgbarMerger.Value = prgbarMerger.Value + 1
                        lblPercentage.Text = Math.Round((Convert.ToInt32(prgbarMerger.Value) / Convert.ToInt32(prgbarMerger.Maximum)) * 100, 1) & "%"
                    Next
                End If

                ' Customer Claim Others
                beginTime = Now.TimeOfDay


                Application.DoEvents()
                lblProcessingTable.Text = " Collecting Data from CustomerClaim Others"

                Dim ListCustClaimOthers As List(Of clsCustomerClaim) = GetALLCustomerClaimOthers.ToList
                strMessage = "Import Tabel: Customer Claim Others"
                lblProcessingTable.Text = strMessage

                If ListCustClaimOthers.Count > 0 Then
                    prgbarMerger.Minimum = 0
                    prgbarMerger.Maximum = ListCustClaimOthers.Count
                    prgbarMerger.Value = 0
                    For Each CustClaim As clsCustomerClaim In ListCustClaimOthers
                        Application.DoEvents()
                        If custclaimMethods.IsExist(CustClaim.Jobcode) = False Then
                            custclaimMethods.Save(CustClaim)
                        End If
                        lblProcessingTable.Text = strMessage & " Total Record : " & ListCustClaimOthers.Count & " Current Record : " & prgbarMerger.Value
                        prgbarMerger.Value = prgbarMerger.Value + 1
                        lblPercentage.Text = Math.Round((Convert.ToInt32(prgbarMerger.Value) / Convert.ToInt32(prgbarMerger.Maximum)) * 100, 1) & "%"
                    Next


                End If


                ' NrDetails
                beginTime = Now.TimeOfDay

                Application.DoEvents()
                lblProcessingTable.Text = " Collecting Data from NrDetails"


                Dim listNrdetails As List(Of clsNrdetails) = NRALLDetails.ToList
                strMessage = "Import Tabel: NrDetails"
                lblProcessingTable.Text = strMessage

                Dim NrdetailsMethods As clsNrdetailsMethods = New clsNrdetailsMethods
                If listNrdetails.Count > 0 Then
                    prgbarMerger.Minimum = 0
                    prgbarMerger.Maximum = listNrdetails.Count
                    prgbarMerger.Value = 0
                    For Each nrdetails As clsNrdetails In listNrdetails
                        Application.DoEvents()
                        If NrdetailsMethods.IsExist(nrdetails.JobCode) = False Then
                            NrdetailsMethods.save(nrdetails)
                        End If
                        lblProcessingTable.Text = strMessage & " Total Record : " & listNrdetails.Count & " Current Record : " & prgbarMerger.Value
                        prgbarMerger.Value = prgbarMerger.Value + 1
                        lblPercentage.Text = Math.Round((Convert.ToInt32(prgbarMerger.Value) / Convert.ToInt32(prgbarMerger.Maximum)) * 100, 1) & "%"
                    Next
                End If

                ' NrDetails Others
                beginTime = Now.TimeOfDay

                Application.DoEvents()
                lblProcessingTable.Text = " Collecting Data from NrDetails Others"
                Dim listNrDetailsOthers As List(Of clsNrdetails) = New List(Of clsNrdetails)
                strMessage = "Import Tabel: NrDetails Others"
                lblProcessingTable.Text = strMessage
                If listNrDetailsOthers.Count > 0 Then
                    prgbarMerger.Minimum = 0
                    prgbarMerger.Maximum = listNrDetailsOthers.Count
                    prgbarMerger.Value = 0
                    For Each nr As clsNrdetails In listNrDetailsOthers
                        Application.DoEvents()
                        If NrdetailsMethods.IsExist(nr.JobCode) = False Then
                            NrdetailsMethods.save(nr)
                        End If
                        lblProcessingTable.Text = strMessage & " Total Record : " & listNrDetailsOthers.Count & " Current Record : " & prgbarMerger.Value
                        prgbarMerger.Value = prgbarMerger.Value + 1
                        lblPercentage.Text = Math.Round((Convert.ToInt32(prgbarMerger.Value) / Convert.ToInt32(prgbarMerger.Maximum)) * 100, 1) & "%"
                    Next
                End If

                ' Pending
                beginTime = Now.TimeOfDay
                strMessage = "Import Tabel: Pending"
                lblProcessingTable.Text = strMessage
                Dim listPending As List(Of clsPending) = GetAllPending.ToList
                Dim pendingMethods As clsPendingMethods = New clsPendingMethods
                If listPending.Count > 0 Then
                    prgbarMerger.Minimum = 0
                    prgbarMerger.Maximum = listPending.Count
                    prgbarMerger.Value = 0
                    For Each Pending As clsPending In listPending
                        Application.DoEvents()
                        If pendingMethods.IsExist(Pending.JobCode) = False Then
                            pendingMethods.save(Pending)
                        End If
                        lblProcessingTable.Text = strMessage & " Total Record : " & listPending.Count & " Current Record : " & prgbarMerger.Value
                        prgbarMerger.Value = prgbarMerger.Value + 1
                        lblPercentage.Text = Math.Round((Convert.ToInt32(prgbarMerger.Value) / Convert.ToInt32(prgbarMerger.Maximum)) * 100, 1) & "%"
                    Next
                End If

                ' Pending Others
                beginTime = Now.TimeOfDay
                strMessage = "Import Tabel: Pending Others"
                lblProcessingTable.Text = strMessage

                Dim ListPendingOthers As List(Of clsPending) = New List(Of clsPending)
                If ListPendingOthers.Count > 0 Then
                    prgbarMerger.Minimum = 0
                    prgbarMerger.Maximum = ListPendingOthers.Count
                    prgbarMerger.Value = 0
                    For Each pendingOther As clsPending In ListPendingOthers
                        Application.DoEvents()
                        If pendingMethods.IsExist(pendingOther.JobCode) = False Then
                            pendingMethods.save(pendingOther)
                        End If
                        lblProcessingTable.Text = strMessage & " Total Record : " & ListPendingOthers.Count & " Current Record : " & prgbarMerger.Value
                        prgbarMerger.Value = prgbarMerger.Value + 1
                        lblPercentage.Text = Math.Round((Convert.ToInt32(prgbarMerger.Value) / Convert.ToInt32(prgbarMerger.Maximum)) * 100, 1) & "%"
                    Next
                End If

                ' Service Details  new (summery)
                beginTime = Now.TimeOfDay
                strMessage = "Import Tabel: Service Details  new (summery)"
                lblProcessingTable.Text = strMessage
                Dim listServiceDetails As List(Of clsServiceDetails) = GetAllpartsDetails.ToList
                Dim ServiceDetailsMethods As clsServiceDetailsMethods = New clsServiceDetailsMethods
                If listServiceDetails.Count > 0 Then
                    prgbarMerger.Minimum = 0
                    prgbarMerger.Maximum = listServiceDetails.Count
                    prgbarMerger.Value = 0
                    For Each servicedetails As clsServiceDetails In listServiceDetails
                        Application.DoEvents()
                        If ServiceDetailsMethods.IsExist(servicedetails.Jobcode) = False Then
                            ServiceDetailsMethods.save(servicedetails)
                        End If
                        lblProcessingTable.Text = strMessage & " Total Record : " & listServiceDetails.Count & " Current Record : " & prgbarMerger.Value
                        prgbarMerger.Value = prgbarMerger.Value + 1
                        lblPercentage.Text = Math.Round((Convert.ToInt32(prgbarMerger.Value) / Convert.ToInt32(prgbarMerger.Maximum)) * 100, 1) & "%"
                    Next
                End If




                ' Servicetem         
                beginTime = Now.TimeOfDay
                strMessage = "Import Tabel: GetServicetem"
                lblProcessingTable.Text = strMessage
                Dim ListServiceItem As List(Of clsServiceItem) = GetAllItem.ToList
                Dim serviceitemMethods As clsServiceItemMethods = New clsServiceItemMethods
                If ListServiceItem.Count > 0 Then
                    prgbarMerger.Minimum = 0
                    prgbarMerger.Maximum = ListServiceItem.Count
                    prgbarMerger.Value = 0
                    For Each Item As clsServiceItem In ListServiceItem
                        Application.DoEvents()
                        If serviceitemMethods.IsExist(Item.JobCode) = False Then
                            serviceitemMethods.SaveItem(Item)
                        End If
                        lblProcessingTable.Text = strMessage & " Total Record : " & ListServiceItem.Count & " Current Record : " & prgbarMerger.Value
                        prgbarMerger.Value = prgbarMerger.Value + 1
                        lblPercentage.Text = Math.Round((Convert.ToInt32(prgbarMerger.Value) / Convert.ToInt32(prgbarMerger.Maximum)) * 100, 1) & "%"
                    Next
                End If



                lblEndTime.Text = Now.TimeOfDay.Hours.ToString & "-" & Now.TimeOfDay.Minutes.ToString & "-" & Now.TimeOfDay.Seconds.ToString
                Timer1.Enabled = False
                lblProcessingTable.Text = "Process Done Successfully"
                btnOpenFile.Enabled = True
                lblClose.Enabled = True
                btnClose.Enabled = True
                'MessageBox.Show("Data Load has Completed Successfully")
                btnMerge.Enabled = False


                MessageBox.Show("Data Imported Successfully")





            Else



                Dim Claiminfos As List(Of clsClaiminfo) = GetClaiminfo().ToList
                Dim ListCashsales As List(Of clsCashsales) = tmpCashsales().ToList 'Get the List of Cashsales






                '____________________ Table: Ctype , Claimlist, tblItemCap, Personal Not includeed in this load option ________________


                lblStartTime.Text = beginTime.Hours.ToString & "-" & beginTime.Minutes.ToString & "-" & beginTime.Seconds.ToString
                Timer1.Enabled = True
                prgbarMerger.Minimum = 0
                prgbarMerger.Maximum = 100
                prgbarMerger.Value = 0










#Region "New Methods of imoporting"


                'Claiminfo
                strMessage = "Claiminfo"
                lblProcessingTable.Text = strMessage
                Dim claimMethoda As clsClaiminfoMethods = New clsClaiminfoMethods
                If Claiminfos.Count > 0 Then
                    prgbarMerger.Minimum = 0
                    prgbarMerger.Maximum = Claiminfos.Count
                    prgbarMerger.Value = 0
                    For Each c As clsClaiminfo In Claiminfos
                        Application.DoEvents()
                        If claimMethoda.IsExist(c.Jobcode) = False Then
                            claimMethoda.CreateNewJob(c)
                        End If
                        lblProcessingTable.Text = strMessage & " Total Record : " & Claiminfos.Count & " Current Record : " & prgbarMerger.Value
                        prgbarMerger.Value = prgbarMerger.Value + 1
                        lblPercentage.Text = Math.Round((Convert.ToInt32(prgbarMerger.Value) / Convert.ToInt32(prgbarMerger.Maximum)) * 100, 1) & "%"
                    Next

                End If





                ' TransferJob
                beginTime = Now.TimeOfDay

                strMessage = "Import Tabel: TransferJob"
                lblProcessingTable.Text = strMessage
                Dim listTransferJob As List(Of clsTransferJob) = GetALLTransfer.ToList
                Dim trnsMethods As clsTransferJobMethods = New clsTransferJobMethods
                If listTransferJob.Count > 0 Then
                    prgbarMerger.Minimum = 0
                    prgbarMerger.Maximum = listTransferJob.Count
                    prgbarMerger.Value = 0
                    For Each TransferJob As clsTransferJob In listTransferJob
                        Application.DoEvents()
                        If trnsMethods.IsExist(TransferJob.JobCode) = False Then
                            trnsMethods.Save(TransferJob)
                        End If
                        lblProcessingTable.Text = strMessage & " Total Record : " & listTransferJob.Count & " Current Record : " & prgbarMerger.Value
                        prgbarMerger.Value = prgbarMerger.Value + 1
                        lblPercentage.Text = Math.Round((Convert.ToInt32(prgbarMerger.Value) / Convert.ToInt32(prgbarMerger.Maximum)) * 100, 1) & "%"
                    Next
                End If
                ' tbStorageSet
                beginTime = Now.TimeOfDay
                strMessage = "Import Tabel: tbStorageSet"
                lblProcessingTable.Text = strMessage
                Dim ListtbStorageSet As List(Of clstbStorageSet) = GetALLTBtorageSet.ToList
                Dim tbStorageMethods As clstbStorageSetMethods = New clstbStorageSetMethods
                If ListtbStorageSet.Count > 0 Then
                    prgbarMerger.Minimum = 0
                    prgbarMerger.Maximum = ListtbStorageSet.Count
                    prgbarMerger.Value = 0
                    For Each storage As clstbStorageSet In ListtbStorageSet
                        Application.DoEvents()
                        If tbStorageMethods.IsExist(storage.JobCode) = False Then
                            tbStorageMethods.Save(storage)
                        End If
                        lblProcessingTable.Text = strMessage & " Total Record : " & ListtbStorageSet.Count & " Current Record : " & prgbarMerger.Value
                        prgbarMerger.Value = prgbarMerger.Value + 1
                        lblPercentage.Text = Math.Round((Convert.ToInt32(prgbarMerger.Value) / Convert.ToInt32(prgbarMerger.Maximum)) * 100, 1) & "%"
                    Next
                End If
                ' tbGrade 
                beginTime = Now.TimeOfDay
                strMessage = "Import Tabel: tbGrade"
                lblProcessingTable.Text = strMessage
                Dim listTbGrade As List(Of clstbGrade) = GetAllGrade.ToList
                Dim tbGradeMethods As clstbGradeMethods = New clstbGradeMethods
                If listTbGrade.Count > 0 Then
                    prgbarMerger.Minimum = 0
                    prgbarMerger.Maximum = listTbGrade.Count
                    prgbarMerger.Value = 0
                    For Each tbgrade As clstbGrade In listTbGrade
                        Application.DoEvents()
                        If tbGradeMethods.IsExist(tbgrade.Jobcode) = False Then
                            tbGradeMethods.save(tbgrade)
                        End If
                        lblProcessingTable.Text = strMessage & " Total Record : " & listTbGrade.Count & " Current Record : " & prgbarMerger.Value
                        prgbarMerger.Value = prgbarMerger.Value + 1
                        lblPercentage.Text = Math.Round((Convert.ToInt32(prgbarMerger.Value) / Convert.ToInt32(prgbarMerger.Maximum)) * 100, 1) & "%"
                    Next
                End If
                ' tbBill_FFC
                beginTime = Now.TimeOfDay
                strMessage = "Import Tabel: tbBill_FFC"
                lblProcessingTable.Text = strMessage
                Dim listServiceCharge As List(Of clstbBill_FFC) = GetALLServiceCharge.ToList
                Dim tbbillFFCMethods As clstbBill_FFCMethods = New clstbBill_FFCMethods
                If listServiceCharge.Count > 0 Then
                    prgbarMerger.Minimum = 0
                    prgbarMerger.Maximum = listServiceCharge.Count
                    prgbarMerger.Value = 0
                    For Each servicecharge As clstbBill_FFC In listServiceCharge
                        Application.DoEvents()
                        If tbbillFFCMethods.ISEXIST(servicecharge.Jobcode) = False Then
                            tbbillFFCMethods.Save_Service_Charge(servicecharge)
                        End If
                        lblProcessingTable.Text = strMessage & " Total Record : " & listServiceCharge.Count & " Current Record : " & prgbarMerger.Value
                        prgbarMerger.Value = prgbarMerger.Value + 1
                        lblPercentage.Text = Math.Round((Convert.ToInt32(prgbarMerger.Value) / Convert.ToInt32(prgbarMerger.Maximum)) * 100, 1) & "%"
                    Next
                End If
                'RPTHowTimeBillPrint
                beginTime = Now.TimeOfDay
                strMessage = "Import Tabel: RPTHowTimeBillPrint"
                lblProcessingTable.Text = strMessage
                Dim listbillprint As List(Of clsRPTHowTimeBillPrint) = GetALLBillNo.ToList
                Dim BillPrintMethods As clsRPTHowTimeBillPrintMethods = New clsRPTHowTimeBillPrintMethods
                If listbillprint.Count > 0 Then
                    prgbarMerger.Minimum = 0
                    prgbarMerger.Maximum = listbillprint.Count
                    prgbarMerger.Value = 0
                    For Each BillPrint As clsRPTHowTimeBillPrint In listbillprint
                        Application.DoEvents()
                        If BillPrintMethods.ISEXIST(BillPrint.JobNo) = False Then
                            BillPrintMethods.save(BillPrint)
                        End If
                        lblProcessingTable.Text = strMessage & " Total Record : " & listbillprint.Count & " Current Record : " & prgbarMerger.Value
                        prgbarMerger.Value = prgbarMerger.Value + 1
                        lblPercentage.Text = Math.Round((Convert.ToInt32(prgbarMerger.Value) / Convert.ToInt32(prgbarMerger.Maximum)) * 100, 1) & "%"
                    Next
                End If
                'AdvanceInfo
                beginTime = Now.TimeOfDay
                strMessage = "Import Tabel: GetALLAdvanceInfo"
                lblProcessingTable.Text = strMessage
                Dim listAdvance As List(Of clsAdvanceInfo) = GetALLAdvanceInfo.ToList
                Dim AdvanceMethods As clsAdvanceInfoMethods = New clsAdvanceInfoMethods
                If listAdvance.Count > 0 Then
                    prgbarMerger.Minimum = 0
                    prgbarMerger.Maximum = listAdvance.Count
                    prgbarMerger.Value = 0
                    For Each Advance As clsAdvanceInfo In listAdvance
                        Application.DoEvents()
                        If AdvanceMethods.ISEXIST(Advance.JobCode) = False Then
                            AdvanceMethods.Save(Advance)
                        End If
                        lblProcessingTable.Text = strMessage & " Total Record : " & listAdvance.Count & " Current Record : " & prgbarMerger.Value
                        prgbarMerger.Value = prgbarMerger.Value + 1
                        lblPercentage.Text = Math.Round((Convert.ToInt32(prgbarMerger.Value) / Convert.ToInt32(prgbarMerger.Maximum)) * 100, 1) & "%"
                    Next
                End If




                'Replace
                beginTime = Now.TimeOfDay
                strMessage = "Import Tabel: Replace"
                lblProcessingTable.Text = strMessage
                Dim listReplace As List(Of clsReplace) = GetAllReplace.ToList
                Dim rpm As clsReplaceMethods = New clsReplaceMethods
                If listReplace.Count > 0 Then
                    prgbarMerger.Minimum = 0
                    prgbarMerger.Maximum = listReplace.Count
                    prgbarMerger.Value = 0
                    For Each replace As clsReplace In listReplace
                        Application.DoEvents()
                        If rpm.Isexist(replace.JobCode) = False Then
                            rpm.Save(replace)
                        End If
                        lblProcessingTable.Text = strMessage & " Total Record : " & listReplace.Count & " Current Record : " & prgbarMerger.Value
                        prgbarMerger.Value = prgbarMerger.Value + 1
                        lblPercentage.Text = Math.Round((Convert.ToInt32(prgbarMerger.Value) / Convert.ToInt32(prgbarMerger.Maximum)) * 100, 1) & "%"
                    Next
                End If
                'tbBill
                beginTime = Now.TimeOfDay
                strMessage = "Import Tabel: tbBill"
                lblProcessingTable.Text = strMessage
                Dim listBill As List(Of clstbBill) = GetAllBill.ToList
                Dim billmethods As clsTBBillMethods = New clsTBBillMethods
                If listBill.Count > 0 Then
                    prgbarMerger.Minimum = 0
                    prgbarMerger.Maximum = listBill.Count
                    prgbarMerger.Value = 0
                    For Each bill As clstbBill In listBill
                        Application.DoEvents()
                        If billmethods.ISEXIST(bill.JobNO) = False Then
                            billmethods.save(bill)
                        End If
                        lblProcessingTable.Text = strMessage & " Total Record : " & listBill.Count & " Current Record : " & prgbarMerger.Value
                        prgbarMerger.Value = prgbarMerger.Value + 1
                        lblPercentage.Text = Math.Round((Convert.ToInt32(prgbarMerger.Value) / Convert.ToInt32(prgbarMerger.Maximum)) * 100, 1) & "%"
                    Next
                End If
                ' Customer Claim
                beginTime = Now.TimeOfDay
                strMessage = "Import Tabel: Customer Claim"
                lblProcessingTable.Text = strMessage
                Dim ListCusClaim As List(Of clsCustomerClaim) = GetAllCustomerClaim.ToList
                Dim custclaimMethods As clsCustomerClaimMethods = New clsCustomerClaimMethods
                If ListCusClaim.Count > 0 Then
                    prgbarMerger.Minimum = 0
                    prgbarMerger.Maximum = ListCusClaim.Count
                    prgbarMerger.Value = 0
                    For Each cust As clsCustomerClaim In ListCusClaim
                        Application.DoEvents()
                        If custclaimMethods.IsExist(cust.Jobcode) = False Then
                            custclaimMethods.Save(cust)
                        End If
                        lblProcessingTable.Text = strMessage & " Total Record : " & ListCusClaim.Count & " Current Record : " & prgbarMerger.Value
                        prgbarMerger.Value = prgbarMerger.Value + 1
                        lblPercentage.Text = Math.Round((Convert.ToInt32(prgbarMerger.Value) / Convert.ToInt32(prgbarMerger.Maximum)) * 100, 1) & "%"
                    Next
                End If

                ' Customer Claim Others
                beginTime = Now.TimeOfDay
                strMessage = "Import Tabel: Customer Claim Others"
                lblProcessingTable.Text = strMessage
                Dim ListCustClaimOthers As List(Of clsCustomerClaim) = GetALLCustomerClaimOthers.ToList
                If ListCustClaimOthers.Count > 0 Then
                    prgbarMerger.Minimum = 0
                    prgbarMerger.Maximum = ListCustClaimOthers.Count
                    prgbarMerger.Value = 0
                    For Each CustClaim As clsCustomerClaim In ListCustClaimOthers
                        Application.DoEvents()
                        If custclaimMethods.IsExist(CustClaim.Jobcode) = False Then
                            custclaimMethods.Save(CustClaim)
                        End If
                        lblProcessingTable.Text = strMessage & " Total Record : " & ListCustClaimOthers.Count & " Current Record : " & prgbarMerger.Value
                        prgbarMerger.Value = prgbarMerger.Value + 1
                        lblPercentage.Text = Math.Round((Convert.ToInt32(prgbarMerger.Value) / Convert.ToInt32(prgbarMerger.Maximum)) * 100, 1) & "%"
                    Next


                End If


                ' NrDetails
                beginTime = Now.TimeOfDay
                strMessage = "Import Tabel: NrDetails"
                lblProcessingTable.Text = strMessage
                Dim listNrdetails As List(Of clsNrdetails) = NRALLDetails.ToList
                Dim NrdetailsMethods As clsNrdetailsMethods = New clsNrdetailsMethods
                If listNrdetails.Count > 0 Then
                    prgbarMerger.Minimum = 0
                    prgbarMerger.Maximum = listNrdetails.Count
                    prgbarMerger.Value = 0
                    For Each nrdetails As clsNrdetails In listNrdetails
                        Application.DoEvents()
                        If NrdetailsMethods.IsExist(nrdetails.JobCode) = False Then
                            NrdetailsMethods.save(nrdetails)
                        End If
                        lblProcessingTable.Text = strMessage & " Total Record : " & listNrdetails.Count & " Current Record : " & prgbarMerger.Value
                        prgbarMerger.Value = prgbarMerger.Value + 1
                        lblPercentage.Text = Math.Round((Convert.ToInt32(prgbarMerger.Value) / Convert.ToInt32(prgbarMerger.Maximum)) * 100, 1) & "%"
                    Next
                End If

                ' NrDetails Others
                beginTime = Now.TimeOfDay
                strMessage = "Import Tabel: NrDetails Others"
                lblProcessingTable.Text = strMessage
                Dim listNrDetailsOthers As List(Of clsNrdetails) = New List(Of clsNrdetails)
                If listNrDetailsOthers.Count > 0 Then
                    prgbarMerger.Minimum = 0
                    prgbarMerger.Maximum = listNrDetailsOthers.Count
                    prgbarMerger.Value = 0
                    For Each nr As clsNrdetails In listNrDetailsOthers
                        Application.DoEvents()
                        If NrdetailsMethods.IsExist(nr.JobCode) = False Then
                            NrdetailsMethods.save(nr)
                        End If
                        lblProcessingTable.Text = strMessage & " Total Record : " & listNrDetailsOthers.Count & " Current Record : " & prgbarMerger.Value
                        prgbarMerger.Value = prgbarMerger.Value + 1
                        lblPercentage.Text = Math.Round((Convert.ToInt32(prgbarMerger.Value) / Convert.ToInt32(prgbarMerger.Maximum)) * 100, 1) & "%"
                    Next
                End If

                ' Pending
                beginTime = Now.TimeOfDay
                strMessage = "Import Tabel: Pending"
                lblProcessingTable.Text = strMessage
                Dim listPending As List(Of clsPending) = GetAllPending.ToList
                Dim pendingMethods As clsPendingMethods = New clsPendingMethods
                If listPending.Count > 0 Then
                    prgbarMerger.Minimum = 0
                    prgbarMerger.Maximum = listPending.Count
                    prgbarMerger.Value = 0
                    For Each Pending As clsPending In listPending
                        Application.DoEvents()
                        If pendingMethods.IsExist(Pending.JobCode) = False Then
                            pendingMethods.save(Pending)
                        End If
                        lblProcessingTable.Text = strMessage & " Total Record : " & listPending.Count & " Current Record : " & prgbarMerger.Value
                        prgbarMerger.Value = prgbarMerger.Value + 1
                        lblPercentage.Text = Math.Round((Convert.ToInt32(prgbarMerger.Value) / Convert.ToInt32(prgbarMerger.Maximum)) * 100, 1) & "%"
                    Next
                End If

                ' Pending Others
                beginTime = Now.TimeOfDay
                strMessage = "Import Tabel: Pending Others"
                lblProcessingTable.Text = strMessage

                Dim ListPendingOthers As List(Of clsPending) = New List(Of clsPending)
                If ListPendingOthers.Count > 0 Then
                    prgbarMerger.Minimum = 0
                    prgbarMerger.Maximum = ListPendingOthers.Count
                    prgbarMerger.Value = 0
                    For Each pendingOther As clsPending In ListPendingOthers
                        Application.DoEvents()
                        If pendingMethods.IsExist(pendingOther.JobCode) = False Then
                            pendingMethods.save(pendingOther)
                        End If
                        lblProcessingTable.Text = strMessage & " Total Record : " & ListPendingOthers.Count & " Current Record : " & prgbarMerger.Value
                        prgbarMerger.Value = prgbarMerger.Value + 1
                        lblPercentage.Text = Math.Round((Convert.ToInt32(prgbarMerger.Value) / Convert.ToInt32(prgbarMerger.Maximum)) * 100, 1) & "%"
                    Next
                End If

                ' Service Details  new (summery)
                beginTime = Now.TimeOfDay
                strMessage = "Import Tabel: Service Details  new (summery)"
                lblProcessingTable.Text = strMessage
                Dim listServiceDetails As List(Of clsServiceDetails) = GetAllpartsDetails.ToList
                Dim ServiceDetailsMethods As clsServiceDetailsMethods = New clsServiceDetailsMethods
                If listServiceDetails.Count > 0 Then
                    prgbarMerger.Minimum = 0
                    prgbarMerger.Maximum = listServiceDetails.Count
                    prgbarMerger.Value = 0
                    For Each servicedetails As clsServiceDetails In listServiceDetails
                        Application.DoEvents()
                        If ServiceDetailsMethods.IsExist(servicedetails.Jobcode) = False Then
                            ServiceDetailsMethods.save(servicedetails)
                        End If
                        lblProcessingTable.Text = strMessage & " Total Record : " & listServiceDetails.Count & " Current Record : " & prgbarMerger.Value
                        prgbarMerger.Value = prgbarMerger.Value + 1
                        lblPercentage.Text = Math.Round((Convert.ToInt32(prgbarMerger.Value) / Convert.ToInt32(prgbarMerger.Maximum)) * 100, 1) & "%"
                    Next
                End If
                ' Service Details  old (Details)
                beginTime = Now.TimeOfDay
                strMessage = "Import Tabel: Service Details  old (Details)"
                lblProcessingTable.Text = strMessage
                Dim listServiceDetailsDetails As List(Of clsServiceDetails) = GetAllDetailDetails.ToList
                If listServiceDetailsDetails.Count > 0 Then
                    prgbarMerger.Minimum = 0
                    prgbarMerger.Maximum = listServiceDetailsDetails.Count
                    prgbarMerger.Value = 0
                    For Each servicedetailsdetails As clsServiceDetails In listServiceDetailsDetails
                        Application.DoEvents()
                        If ServiceDetailsMethods.isExist_Temp_ServiceDetails(servicedetailsdetails.Jobcode) = False Then
                            ServiceDetailsMethods.Save_Temp_ServiceDetails(servicedetailsdetails)
                        End If
                        lblProcessingTable.Text = strMessage & " Total Record : " & listServiceDetailsDetails.Count & " Current Record : " & prgbarMerger.Value
                        prgbarMerger.Value = prgbarMerger.Value + 1
                        lblPercentage.Text = Math.Round((Convert.ToInt32(prgbarMerger.Value) / Convert.ToInt32(prgbarMerger.Maximum)) * 100, 1) & "%"
                    Next
                End If

                ' Estimate Refuse
                beginTime = Now.TimeOfDay
                strMessage = "Import Tabel: Estimate Refuse"
                lblProcessingTable.Text = strMessage
                Dim ListEstimateRefused As List(Of clsEstimateRefused) = GetAllEstRefused.ToList
                Dim estMethods As clsEstimateRefusedMethods = New clsEstimateRefusedMethods
                If ListEstimateRefused.Count > 0 Then
                    prgbarMerger.Minimum = 0
                    prgbarMerger.Maximum = ListEstimateRefused.Count
                    prgbarMerger.Value = 0
                    For Each estrefues As clsEstimateRefused In ListEstimateRefused
                        Application.DoEvents()
                        If estMethods.IsExist(estrefues.JobCode) = False Then
                            estMethods.save(estrefues)
                        End If
                        lblProcessingTable.Text = strMessage & " Total Record : " & ListEstimateRefused.Count & " Current Record : " & prgbarMerger.Value
                        prgbarMerger.Value = prgbarMerger.Value + 1
                        lblPercentage.Text = Math.Round((Convert.ToInt32(prgbarMerger.Value) / Convert.ToInt32(prgbarMerger.Maximum)) * 100, 1) & "%"
                    Next
                End If
                ' Servicetem
                beginTime = Now.TimeOfDay
                strMessage = "Import Tabel: GetServicetem"
                lblProcessingTable.Text = strMessage
                Dim ListServiceItem As List(Of clsServiceItem) = GetAllItem.ToList
                Dim serviceitemMethods As clsServiceItemMethods = New clsServiceItemMethods
                If ListServiceItem.Count > 0 Then
                    prgbarMerger.Minimum = 0
                    prgbarMerger.Maximum = ListServiceItem.Count
                    prgbarMerger.Value = 0
                    For Each Item As clsServiceItem In ListServiceItem
                        Application.DoEvents()
                        If serviceitemMethods.IsExist(Item.JobCode) = False Then
                            serviceitemMethods.SaveItem(Item)
                        End If
                        lblProcessingTable.Text = strMessage & " Total Record : " & ListServiceItem.Count & " Current Record : " & prgbarMerger.Value
                        prgbarMerger.Value = prgbarMerger.Value + 1
                        lblPercentage.Text = Math.Round((Convert.ToInt32(prgbarMerger.Value) / Convert.ToInt32(prgbarMerger.Maximum)) * 100, 1) & "%"
                    Next
                End If



                'Cashsales
                beginTime = Now.TimeOfDay
                strMessage = "Import Tabel: Cashsales"
                lblProcessingTable.Text = strMessage
                If ListCashsales.Count > 0 Then
                    prgbarMerger.Minimum = 0
                    prgbarMerger.Maximum = ListCashsales.Count
                    prgbarMerger.Value = 0
                    Dim cm As clsCashsalesMethods = New clsCashsalesMethods
                    For Each Cashsales As clsCashsales In ListCashsales
                        Application.DoEvents()
                        strJobCode = Cashsales.MRNO
                        If cm.IsExist(Cashsales.MRNO) = False Then
                            cm.Save(Cashsales)
                        End If
                        lblProcessingTable.Text = strMessage & " Total Record : " & ListCashsales.Count & " Current Record : " & prgbarMerger.Value
                        prgbarMerger.Value = prgbarMerger.Value + 1
                        lblPercentage.Text = Math.Round((Convert.ToInt32(prgbarMerger.Value) / Convert.ToInt32(prgbarMerger.Maximum)) * 100, 1) & "%"


                    Next
                End If









                lblEndTime.Text = Now.TimeOfDay.Hours.ToString & "-" & Now.TimeOfDay.Minutes.ToString & "-" & Now.TimeOfDay.Seconds.ToString
                Timer1.Enabled = False
                lblProcessingTable.Text = "Process Done Successfully"
                btnOpenFile.Enabled = True
                lblClose.Enabled = True
                btnClose.Enabled = True
                MessageBox.Show("Data Load has Completed Successfully")
                btnMerge.Enabled = False
#End Region
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & " Job Code is: " & strJobCode.ToString & "Error Table: " & strMessage)
            btnOpenFile.Enabled = True
            lblClose.Enabled = True
            btnClose.Enabled = True
            lblMessage.Text = " Job Code is: " & strJobCode.ToString & "Error Table: " & strMessage
            Timer1.Enabled = False
            btnMerge.Enabled = False
        End Try
    End Sub
    '___________________________________________________________ Loading Funciont and Event Section __________________________________________



    Private Sub QuickImportData()
        'System.IO.Directory.GetCurrentDirectory()

        Dim strQuery As String = String.Empty



        Dim ListTransfer As List(Of clsTransferJob) = New List(Of clsTransferJob)

        Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath




        DeleteExistTable()
            DeleteAllRecords()

            Using con As OleDbConnection = New OleDbConnection(cs)
                'Claiminfo
                strQuery = "Select Claiminfo.JobCode, ClaimInfo.Branch, ClaimInfo.CustName, ClaimInfo.CustAddress1, ClaimInfo.CustAddress2, ClaimInfo.Brand, ClaimInfo.ModelNo, ClaimInfo.MobileNo, ClaimInfo.ESN, ClaimInfo.SLNo, ClaimInfo.ReceptDate, ClaimInfo.AppDelDate, ClaimInfo.ServiceType, ClaimInfo.PDate, ClaimInfo.ReceptBy, ClaimInfo.IssueTo, ClaimInfo.IsssueDate, ClaimInfo.SDate, ClaimInfo.ServiceBy, ClaimInfo.DDate, ClaimInfo.DeliverBy, ClaimInfo.WCondition, ClaimInfo.cFlag, ClaimInfo.SvAmt, ClaimInfo.PrdAmt, ClaimInfo.OtherAmt, ClaimInfo.Dis, ClaimInfo.SRFlag, ClaimInfo.Remk, ClaimInfo.PhyCond, ClaimInfo.Log_User, ClaimInfo.Log_Date, ClaimInfo.MRNO, ClaimInfo.LastJobNO, ClaimInfo.cAdvance, ClaimInfo.cTransportCrg, ClaimInfo.ReturnedItems, ClaimInfo.ItemRemarks, ClaimInfo.FreeOfCost, ClaimInfo.AdvanceAmnt, ClaimInfo.VatAmnt into ClaimInfo1 in '" & System.IO.Directory.GetCurrentDirectory() & "\Service.mdb' FROM ClaimInfo"
                Dim dcTransferJob As OleDbCommand = New OleDbCommand(strQuery, con)
                con.Open()
                dcTransferJob.ExecuteNonQuery()

                'TransferJob
                strQuery = "SELECT TransferJob.JobCode, TransferJob.Remarks, TransferJob.TransferFrom, TransferJob.TransferTo, TransferJob.TrDate, TransferJob.TrByCode, TransferJob.TrByName into TransferJob1 in '" & System.IO.Directory.GetCurrentDirectory() & "\Service.mdb' From TransferJob inner Join Claiminfo on TransferJob.JobCode=Claiminfo.JobCode"
                dcTransferJob.CommandText = strQuery
                dcTransferJob.ExecuteNonQuery()

                'tbStoregeSET
                strQuery = "SELECT tbStoregeSET.JobCode, tbStoregeSET.Location, tbStoregeSET.SendDate, tbStoregeSET.Bin, tbStoregeSET.Remarks, tbStoregeSET.Branch into tbStoregeSET1 in '" & System.IO.Directory.GetCurrentDirectory() & "\Service.mdb' FROM tbStoregeSET inner Join Claiminfo on tbStoregeSET.JobCode=Claiminfo.JobCode"
                dcTransferJob.CommandText = strQuery
                dcTransferJob.ExecuteNonQuery()

                'tbGrade
                strQuery = "SELECT tbGrade.JobCode, tbGrade.cGrade, tbGrade.cRemarks  into tbGrade1 in '" & System.IO.Directory.GetCurrentDirectory() & "\Service.mdb' FROM tbGrade inner Join Claiminfo on tbGrade.JobCode=Claiminfo.JobCode"
                dcTransferJob.CommandText = strQuery
                dcTransferJob.ExecuteNonQuery()

                'tbBill_FFC
                strQuery = "SELECT tbBill_FFC.JobNO, tbBill_FFC.FaultCharge, tbBill_FFC.ServiceCharge into tbBill_FFC1 in '" & System.IO.Directory.GetCurrentDirectory() & "\Service.mdb' FROM tbBill_FFC inner Join Claiminfo on tbBill_FFC.JobNO=Claiminfo.JobCode"
                dcTransferJob.CommandText = strQuery
                dcTransferJob.ExecuteNonQuery()

                'RPTHowTimeBillPrint
                strQuery = "SELECT RPTHowTimeBillPrint.JobNo, RPTHowTimeBillPrint.BillNo into RPTHowTimeBillPrint1 in '" & System.IO.Directory.GetCurrentDirectory() & "\Service.mdb' FROM RPTHowTimeBillPrint inner Join Claiminfo on RPTHowTimeBillPrint.JobNO=Claiminfo.JobCode"
                dcTransferJob.CommandText = strQuery
                dcTransferJob.ExecuteNonQuery()

                'AdvanceInfo
                strQuery = "SELECT AdvanceInfo.JobCode, AdvanceInfo.Branch, AdvanceInfo.AdvNo, AdvanceInfo.AdvDate, AdvanceInfo.AdvAmnt, AdvanceInfo.AdvRemarks, AdvanceInfo.PayType, AdvanceInfo.BankName, AdvanceInfo.CardNo into AdvanceInfo1 in '" & System.IO.Directory.GetCurrentDirectory() & "\Service.mdb' FROM AdvanceInfo inner Join Claiminfo on AdvanceInfo.JobCode=Claiminfo.JobCode"
                dcTransferJob.CommandText = strQuery
                dcTransferJob.ExecuteNonQuery()

                'Replace
                strQuery = "SELECT Replace.JobCode, Replace.Brand, Replace.Model, Replace.ESN, Replace.ESNb, Replace.SLNo, Replace.Other, Replace.RDate, Replace.ReplaceBy  into Replace1 in '" & System.IO.Directory.GetCurrentDirectory() & "\Service.mdb' FROM Replace inner Join Claiminfo on Replace.JobCode=Claiminfo.JobCode"
                dcTransferJob.CommandText = strQuery
                dcTransferJob.ExecuteNonQuery()

                'tbBil
                strQuery = "SELECT tbBill.BillNO, tbBill.JobNO into tbBill1 in '" & System.IO.Directory.GetCurrentDirectory() & "\Service.mdb' FROM tbBill inner Join Claiminfo on tbBill.JobNO=Claiminfo.JobCode"
                dcTransferJob.CommandText = strQuery
                dcTransferJob.ExecuteNonQuery()

                'ServiceDetails
                strQuery = "SELECT ServiceDetails.JobCode, ServiceDetails.ProductCode, ServiceDetails.Qty, ServiceDetails.UnitPrice, ServiceDetails.Remarks  into ServiceDetails1 in '" & System.IO.Directory.GetCurrentDirectory() & "\Service.mdb' FROM ServiceDetails inner Join Claiminfo on ServiceDetails.JobCode=Claiminfo.JobCode"
                dcTransferJob.CommandText = strQuery
                dcTransferJob.ExecuteNonQuery()

                'EstimateRefused
                strQuery = "SELECT EstimateRefused.JobCode, EstimateRefused.ServiceBy_ID, EstimateRefused.EstDate, EstimateRefused.EstText, EstimateRefused.RefuseAmnt, EstimateRefused.Branch into EstimateRefused1 in '" & System.IO.Directory.GetCurrentDirectory() & "\Service.mdb' FROM EstimateRefused inner Join Claiminfo on EstimateRefused.JobCode=Claiminfo.JobCode"
                dcTransferJob.CommandText = strQuery
                dcTransferJob.ExecuteNonQuery()

                'CashSales
                strQuery = "SELECT CashSales.MRNO, CashSales.JobCode, CashSales.Branch, CashSales.CustName, CashSales.CustAddress1, CashSales.CustAddress2, CashSales.Brand, CashSales.ModelNo, CashSales.ESN, CashSales.SLNo, CashSales.ReceptDate, CashSales.ReceptBy, CashSales.Code, CashSales.ProdName, CashSales.Rate, CashSales.Qty, CashSales.Amount, CashSales.PrdAmt, CashSales.Dis, CashSales.NetAmnt, CashSales.Log_User, CashSales.Log_Date, CashSales.DFlag into CashSales1 in '" & System.IO.Directory.GetCurrentDirectory() & "\Service.mdb' FROM CashSales"
                dcTransferJob.CommandText = strQuery
            dcTransferJob.ExecuteNonQuery()



            'CType
            strQuery = "Select  ctype.CType  into CType1 in '" & System.IO.Directory.GetCurrentDirectory() & "\Service.mdb' FROM CType"
            dcTransferJob.CommandText = strQuery
            dcTransferJob.ExecuteNonQuery()


            'Claimlist
            strQuery = "Select Claimlist.CType, Claimlist.Claim into Claimlist1 in '" & System.IO.Directory.GetCurrentDirectory() & "\Service.mdb' FROM Claimlist"
            dcTransferJob.CommandText = strQuery
            dcTransferJob.ExecuteNonQuery()



            'tblItemCap
            strQuery = "Select CType, cItem  into tblItemCap1 in '" & System.IO.Directory.GetCurrentDirectory() & "\Service.mdb' FROM tblItemCap"
            dcTransferJob.CommandText = strQuery
                dcTransferJob.ExecuteNonQuery()

            'Personal
            strQuery = "SELECT Personal.EmpCode, Personal.UserName, Personal.EmpName, Personal.Passward, Personal.FathersName, Personal.Sex, Personal.DateOfBirth, Personal.DateOfJoin, Personal.Department, Personal.Designation, Personal.EduQua, Personal.MaritalStatus, Personal.PreAdd, Personal.PrePO, Personal.PreDist, Personal.PrePhone, Personal.PerAdd, Personal.PerPO, Personal.PerDist, Personal.PerPhone, Personal.Amount, Personal.Payscale, Personal.JobType into Personal1 in '" & System.IO.Directory.GetCurrentDirectory() & "\Service.mdb' FROM Personal"
            dcTransferJob.CommandText = strQuery
            dcTransferJob.ExecuteNonQuery()

        End Using


        Thread.Sleep(2000)


        cs = ConfigurationManager.ConnectionStrings("dbcService").ConnectionString

            Using con1 As OleDbConnection = New OleDbConnection(cs)
                Dim dcTransferJob As OleDbCommand = New OleDbCommand()
                dcTransferJob.Connection = con1

                con1.Open()

                strQuery = "Insert into Claiminfo(JobCode, Branch, CustName, CustAddress1, CustAddress2, Brand, ModelNo, MobileNo, ESN, SLNo, ReceptDate, AppDelDate, ServiceType, PDate, ReceptBy, IssueTo, IsssueDate, SDate, ServiceBy, DDate, DeliverBy, WCondition, cFlag, SvAmt, PrdAmt, OtherAmt, Dis, SRFlag, Remk, PhyCond, Log_User, Log_Date, MRNO, LastJobNO, cAdvance, cTransportCrg, ReturnedItems, ItemRemarks, FreeOfCost, AdvanceAmnt, VatAmnt) Select Claiminfo1.JobCode, Claiminfo1.Branch, Claiminfo1.CustName, Claiminfo1.CustAddress1, Claiminfo1.CustAddress2, Claiminfo1.Brand, Claiminfo1.ModelNo, Claiminfo1.MobileNo, Claiminfo1.ESN, Claiminfo1.SLNo, Claiminfo1.ReceptDate, Claiminfo1.AppDelDate, Claiminfo1.ServiceType, Claiminfo1.PDate, Claiminfo1.ReceptBy, Claiminfo1.IssueTo, Claiminfo1.IsssueDate, Claiminfo1.SDate, Claiminfo1.ServiceBy, Claiminfo1.DDate, Claiminfo1.DeliverBy, Claiminfo1.WCondition, Claiminfo1.cFlag, Claiminfo1.SvAmt, Claiminfo1.PrdAmt, Claiminfo1.OtherAmt, Claiminfo1.Dis, Claiminfo1.SRFlag, Claiminfo1.Remk, Claiminfo1.PhyCond, Claiminfo1.Log_User, Claiminfo1.Log_Date, Claiminfo1.MRNO, Claiminfo1.LastJobNO, Claiminfo1.cAdvance, Claiminfo1.cTransportCrg, Claiminfo1.ReturnedItems, Claiminfo1.ItemRemarks, Claiminfo1.FreeOfCost, Claiminfo1.AdvanceAmnt, Claiminfo1.VatAmnt FROM ClaimInfo1"
                dcTransferJob.CommandText = strQuery
                dcTransferJob.ExecuteNonQuery()


                strQuery = "Insert Into TransferJob(JobCode, Remarks, TransferFrom, TransferTo, TrDate, TrByCode, TrByName) Select TransferJob1.JobCode, TransferJob1.Remarks, TransferJob1.TransferFrom, TransferJob1.TransferTo, TransferJob1.TrDate, TransferJob1.TrByCode, TransferJob1.TrByName From TransferJob1"
                dcTransferJob.CommandText = strQuery
                dcTransferJob.ExecuteNonQuery()
                strQuery = "Insert into tbStoregeSET( JobCode, Location, SendDate, Bin, Remarks, Branch) Select tbStoregeSET1.JobCode, tbStoregeSET1.Location, tbStoregeSET1.SendDate, tbStoregeSET1.Bin, tbStoregeSET1.Remarks, tbStoregeSET1.Branch FROM tbStoregeSET1"
                dcTransferJob.CommandText = strQuery
                dcTransferJob.ExecuteNonQuery()
                strQuery = "Insert into tbGrade(JobCode, cGrade, cRemarks) Select tbGrade1.JobCode, tbGrade1.cGrade, tbGrade1.cRemarks FROM tbGrade1"
                dcTransferJob.CommandText = strQuery
                dcTransferJob.ExecuteNonQuery()
                strQuery = "Insert into tbBill_FFC(JobCode, FaultCharge, ServiceCharge) Select tbBill_FFC1.JobNo, tbBill_FFC1.FaultCharge, tbBill_FFC1.ServiceCharge FROM tbBill_FFC1"
                dcTransferJob.CommandText = strQuery
                dcTransferJob.ExecuteNonQuery()
                strQuery = "Insert into RPTHowTimeBillPrint(JobNo, BillNo) Select RPTHowTimeBillPrint1.JobNo, RPTHowTimeBillPrint1.BillNo FROM RPTHowTimeBillPrint1"
                dcTransferJob.CommandText = strQuery
                dcTransferJob.ExecuteNonQuery()
                strQuery = "Insert into AdvanceInfo(JobCode, Branch, AdvNo, AdvDate, AdvAmnt, AdvRemarks, PayType, BankName, CardNo) Select AdvanceInfo1.JobCode, AdvanceInfo1.Branch, AdvanceInfo1.AdvNo, AdvanceInfo1.AdvDate, AdvanceInfo1.AdvAmnt, AdvanceInfo1.AdvRemarks, AdvanceInfo1.PayType, AdvanceInfo1.BankName, AdvanceInfo1.CardNo FROM AdvanceInfo1"
                dcTransferJob.CommandText = strQuery
                dcTransferJob.ExecuteNonQuery()
                strQuery = "Insert Into Replace (JobCode, Brand, Model, ESN, ESNb, SLNo, Other, RDate, ReplaceBy) Select Replace1.JobCode, Replace1.Brand, Replace1.Model, Replace1.ESN, Replace1.ESNb, Replace1.SLNo, Replace1.Other, Replace1.RDate, Replace1.ReplaceBy FROM Replace1"
                dcTransferJob.CommandText = strQuery
                dcTransferJob.ExecuteNonQuery()
                strQuery = "Insert into tbBill(BillNO, JobNO) Select tbBill1.BillNO, tbBill1.JobNO FROM tbBill1"
                dcTransferJob.CommandText = strQuery
                dcTransferJob.ExecuteNonQuery()
                strQuery = " Insert into ServiceDetailsDetails(JobCode, ProductCode, Qty, UnitPrice, Remarks) Select ServiceDetails1.JobCode, ServiceDetails1.ProductCode, ServiceDetails1.Qty, ServiceDetails1.UnitPrice, ServiceDetails1.Remarks FROM ServiceDetails1"
                dcTransferJob.CommandText = strQuery
                dcTransferJob.ExecuteNonQuery()
                strQuery = "Insert into EstimateRefused(JobCode, ServiceBy_ID, EstDate, EstText, RefuseAmnt, Branch) Select EstimateRefused1.JobCode, EstimateRefused1.ServiceBy_ID, EstimateRefused1.EstDate, EstimateRefused1.EstText, EstimateRefused1.RefuseAmnt, EstimateRefused1.Branch FROM EstimateRefused1"
                dcTransferJob.CommandText = strQuery
                dcTransferJob.ExecuteNonQuery()
                strQuery = "Insert into CashSales(MRNO, JobCode, Branch, CustName, CustAddress1, CustAddress2, Brand, ModelNo, ESN, SLNo, ReceptDate, ReceptBy, Code, ProdName, Rate, Qty, Amount, PrdAmt, Dis, NetAmnt, Log_User, Log_Date, Dflag) Select CashSales1.MRNO, CashSales1.JobCode, CashSales1.Branch, CashSales1.CustName, CashSales1.CustAddress1, CashSales1.CustAddress2, CashSales1.Brand, CashSales1.ModelNo, CashSales1.ESN, CashSales1.SLNo, CashSales1.ReceptDate, CashSales1.ReceptBy, CashSales1.Code, CashSales1.ProdName, CashSales1.Rate, CashSales1.Qty, CashSales1.Amount, CashSales1.PrdAmt, CashSales1.Dis, CashSales1.NetAmnt, CashSales1.Log_User, CashSales1.Log_Date, CashSales1.DFlag FROM CashSales1"
                dcTransferJob.CommandText = strQuery
            dcTransferJob.ExecuteNonQuery()



            strQuery = "Insert into Ctype(Ctype) Select Ctype1.ctype FROM Ctype1"
            dcTransferJob.CommandText = strQuery
            dcTransferJob.ExecuteNonQuery()
            strQuery = "Insert into ClaimList(Ctype, Claim) Select ClaimList1.Ctype,ClaimList1.Claim FROM ClaimList1"
            dcTransferJob.CommandText = strQuery
            dcTransferJob.ExecuteNonQuery()


            strQuery = "Insert into tblItemCap(cType,cItem) Select tblItemCap1.cType,tblItemCap1.cItem from tblItemCap1"
            dcTransferJob.CommandText = strQuery
            dcTransferJob.ExecuteNonQuery()


            strQuery = "Insert into Personal(EmpCode, UserName, EmpName, Passward, FathersName, Sex, DateOfBirth, DateOfJoin, Department, Designation, EduQua, MaritalStatus, PreAdd, PrePO, PreDist, PrePhone, PerAdd, PerPO, PerDist, PerPhone, Amount, Payscale, JobType) SELECT Personal1.EmpCode, Personal1.UserName, Personal1.EmpName, Personal1.Passward, Personal1.FathersName, Personal1.Sex, Personal1.DateOfBirth, Personal1.DateOfJoin, Personal1.Department, Personal1.Designation, Personal1.EduQua, Personal1.MaritalStatus, Personal1.PreAdd, Personal1.PrePO, Personal1.PreDist, Personal1.PrePhone, Personal1.PerAdd, Personal1.PerPO, Personal1.PerDist, Personal1.PerPhone, Personal1.Amount, Personal1.Payscale, Personal1.JobType FROM Personal1"
            dcTransferJob.CommandText = strQuery
            dcTransferJob.ExecuteNonQuery()


        End Using

            DeleteExistTable()



    End Sub


    Private Sub DeleteAllRecords()


        Dim strQuery As String = String.Empty

            strQuery = "Delete * From Claiminfo"
            Dim cs As String = ConfigurationManager.ConnectionStrings("dbcService").ConnectionString

            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dcCheckTable As OleDbCommand = New OleDbCommand(strQuery, con)
                con.Open()

            dcCheckTable.ExecuteNonQuery()
            dcCheckTable.CommandText = "Delete * from Advanceinfo"
            dcCheckTable.ExecuteNonQuery()

            dcCheckTable.CommandText = "Delete * from Ctype"
            dcCheckTable.ExecuteNonQuery()


            dcCheckTable.CommandText = "Delete * from ClaimList"
            dcCheckTable.ExecuteNonQuery()

            dcCheckTable.CommandText = "Delete * from tblItemCap"
            dcCheckTable.ExecuteNonQuery()


            dcCheckTable.CommandText = "Delete * from Cashsales"
            dcCheckTable.ExecuteNonQuery()


            dcCheckTable.CommandText = "Delete * from Personal"
            dcCheckTable.ExecuteNonQuery()
        End Using
     

    End Sub

    Private Sub DeleteExistTable()
        If IsTableExist("Personal1") = True Then
            DropTable("Personal1")
        End If

        If IsTableExist("tblItemCap1") = True Then
            DropTable("tblItemCap1")
        End If



        If IsTableExist("Ctype1") = True Then
            DropTable("Ctype1")
        End If

        If IsTableExist("ClaimList1") = True Then
            DropTable("ClaimList1")
        End If


        If IsTableExist("Claiminfo1") = True Then
            DropTable("Claiminfo1")
        End If

        If IsTableExist("TransferJob1") = True Then
            DropTable("TransferJob1")
        End If

        If IsTableExist("tbStoregeSET1") = True Then
            DropTable("tbStoregeSET1")
        End If

        If IsTableExist("tbGrade1") = True Then
            DropTable("tbGrade1")
        End If

        If IsTableExist("tbBill_FFC1") = True Then
            DropTable("tbBill_FFC1")
        End If

        If IsTableExist("rptHowtimebillprint1") = True Then
            DropTable("rptHowtimebillprint1")
        End If

        If IsTableExist("AdvanceInfo1") = True Then
            DropTable("AdvanceInfo1")
        End If

        If IsTableExist("Replace1") = True Then
            DropTable("Replace1")
        End If

        If IsTableExist("tbBill1") = True Then
            DropTable("tbBill1")
        End If

        If IsTableExist("ServiceDetails1") = True Then
            DropTable("ServiceDetails1")
        End If

        If IsTableExist("EstimateRefused1") = True Then
            DropTable("EstimateRefused1")
        End If

        If IsTableExist("Cashsales1") = True Then
            DropTable("Cashsales1")
        End If


    End Sub



    Private Function IsTableExist(ByVal strCheckTableName As String) As Boolean

        Dim blnFlag = False

        Try
            Dim strQuery As String = String.Empty

            'strQuery = "Select * From mSysobjects"
            strQuery = "Select * From " & strCheckTableName
            Dim cs As String = ConfigurationManager.ConnectionStrings("dbcService").ConnectionString


            Using con As OleDbConnection = New OleDbConnection(cs)

                Dim dcCheckTable As OleDbCommand = New OleDbCommand(strQuery, con)
                'dcCheckTable.Parameters.Add("@TablName", OleDbType.Char, 255).Value = strCheckTableName
                con.Open()

                Dim drCheckTable As OleDbDataReader = dcCheckTable.ExecuteReader
                blnFlag = True


            End Using


        Catch ex As Exception

            blnFlag = False
        End Try

        Return blnFlag
    End Function


    Private Sub DropTable(ByVal strTableName As String)
        Dim strDropTable As String = String.Empty
        strDropTable = "Drop Table " & strTableName

        Try

            Dim cs As String = ConfigurationManager.ConnectionStrings("dbcService").ConnectionString


        Using con As OleDbConnection = New OleDbConnection(cs)

                Dim dcCheckTable As OleDbCommand = New OleDbCommand(strDropTable, con)
                'dcCheckTable.Parameters.Add("@TableName", OleDbType.Char, 255).Value = strTableName
                con.Open()

                dcCheckTable.ExecuteNonQuery()


            End Using

        Catch ex As Exception

        End Try
    End Sub


#Region "New Data import Functions"
    Public ReadOnly Property GetALLTransfer() As IEnumerable(Of clsTransferJob)
        Get


            Dim ListTransfer As List(Of clsTransferJob) = New List(Of clsTransferJob)

            Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath

            'Dim strQuery As String = "Select * from TransferJob inner join claiminfo on TransferJob.JobCode=Claiminfo.JobCode where TransferJob.JobCode=@JobCode"

            Dim strQuery As String = "SELECT TransferJob.TrID, TransferJob.JobCode, TransferJob.Remarks, TransferJob.TransferFrom, TransferJob.TransferTo, TransferJob.TrDate, TransferJob.TrByCode, TransferJob.TrByName
FROM TransferJob inner join claiminfo on TransferJob.JobCode=Claiminfo.JobCode"
            ' Dim strQuery As String = "Select * from TransferJob"
            Using con As OleDbConnection = New OleDbConnection(cs)

                Dim dcTransferJob As OleDbCommand = New OleDbCommand(strQuery, con)

                'dcTransferJob.Parameters.Add("@JobCode", OleDbType.Char, 255).Value = SearchID

                con.Open()
                Dim drTransferJob As OleDbDataReader = dcTransferJob.ExecuteReader


                If drTransferJob.HasRows = True Then
                    While drTransferJob.Read
                        Dim Transferjob As clsTransferJob = New clsTransferJob
                        If Not String.IsNullOrEmpty(drTransferJob("TrID").ToString.Trim) Then
                            Transferjob.TrID = Convert.ToInt32(drTransferJob("TrID").ToString)
                        End If
                        Transferjob.JobCode = drTransferJob("JobCode").ToString
                        Transferjob.Remarks = drTransferJob("Remarks").ToString
                        Transferjob.TransferFrom = drTransferJob("TransferFrom").ToString
                        Transferjob.TransferTo = drTransferJob("TransferTo").ToString
                        If Not String.IsNullOrEmpty(drTransferJob("TrDate").ToString) Then
                            Transferjob.TrDate = drTransferJob("TrDate").ToString
                        End If
                        Transferjob.TrByCode = drTransferJob("TrByCode").ToString
                        Transferjob.TrByName = drTransferJob("TrByName").ToString
                        ListTransfer.Add(Transferjob)
                    End While
                End If
            End Using
            Return ListTransfer
        End Get
    End Property
    Public ReadOnly Property GetALLTBtorageSet() As IEnumerable(Of clstbStorageSet)
        Get

            Dim listStorage As List(Of clstbStorageSet) = New List(Of clstbStorageSet)


            Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath
            Dim strQuery As String = "SELECT tbStoregeSET.SSID, tbStoregeSET.JobCode, tbStoregeSET.Location, tbStoregeSET.SendDate, tbStoregeSET.Bin, tbStoregeSET.Remarks, tbStoregeSET.Branch
                                      FROM tbStoregeSET inner Join Claiminfo on tbStoregeSET.JobCode=Claiminfo.JobCode"



            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dcStorage As OleDbCommand = New OleDbCommand(strQuery, con)

                con.Open()
                Dim drStorage As OleDbDataReader = dcStorage.ExecuteReader
                If drStorage.HasRows = True Then
                    While drStorage.Read
                        Dim storage As clstbStorageSet = New clstbStorageSet

                        If Not String.IsNullOrEmpty(drStorage("SSID").ToString) Then
                            storage.SSID = Convert.ToInt32(drStorage("SSID").ToString)
                        End If
                        storage.JobCode = drStorage("JobCode").ToString
                        storage.Location = drStorage("Location").ToString
                        If Not String.IsNullOrEmpty(drStorage("SendDate").ToString) Then
                            storage.SendDate = drStorage("SendDate").ToString
                        End If
                        storage.Bin = drStorage("Bin").ToString
                        storage.Remarks = drStorage("Remarks").ToString
                        storage.Branch = drStorage("Branch").ToString
                        listStorage.Add(storage)
                    End While
                End If
            End Using
            Return listStorage
        End Get
    End Property
    Public Function GetAllGrade() As List(Of clstbGrade)
        Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath

        Dim listTbGrade As List(Of clstbGrade) = New List(Of clstbGrade)



        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcCustGrade = New OleDbCommand("SELECT tbGrade.ID, tbGrade.JobCode, tbGrade.cGrade, tbGrade.cRemarks FROM tbGrade Inner Join Claiminfo on tbGrade.JobCode=Claiminfo.JobCode", con)
            dcCustGrade.CommandType = CommandType.Text
            con.Open()
            Dim drCustGrade = dcCustGrade.ExecuteReader
            If drCustGrade.HasRows = True Then
                While drCustGrade.Read
                    Dim tbGrade As clstbGrade = New clstbGrade
                    tbGrade.GradeID = Convert.ToInt32(drCustGrade("ID").ToString)
                    tbGrade.Jobcode = drCustGrade("JobCode").ToString
                    tbGrade.cGrade = drCustGrade("cGrade").ToString
                    tbGrade.cRemarks = drCustGrade("cRemarks").ToString
                    listTbGrade.Add(tbGrade)
                End While
            End If
        End Using
        Return listTbGrade
    End Function
    Public ReadOnly Property GetALLServiceCharge() As List(Of clstbBill_FFC)
        Get
            Dim listTBBILLFFC As List(Of clstbBill_FFC) = New List(Of clstbBill_FFC)
            Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath
            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dcGetServiceCharge As OleDbCommand = New OleDbCommand("SELECT tbBill_FFC.JobNO, tbBill_FFC.FaultCharge, tbBill_FFC.ServiceCharge FROM tbBill_FFC inner Join CLaiminfo on tbBill_FFC.JobNo=Claiminfo.JobCode", con)
                dcGetServiceCharge.CommandType = CommandType.Text
                con.Open()
                Dim drgetServiceCharge As OleDbDataReader = dcGetServiceCharge.ExecuteReader()
                If drgetServiceCharge.HasRows = True Then
                    While drgetServiceCharge.Read
                        Dim clsServiceCharge As clstbBill_FFC = New clstbBill_FFC
                        clsServiceCharge.Jobcode = drgetServiceCharge("JobNO").ToString
                        If Not String.IsNullOrEmpty(drgetServiceCharge("FaultCharge").ToString) Then
                            clsServiceCharge.FaultCharge = Convert.ToInt32(drgetServiceCharge("FaultCharge").ToString)
                        End If
                        If Not String.IsNullOrEmpty(drgetServiceCharge("ServiceCharge").ToString) Then
                            clsServiceCharge.ServiceCharge = Convert.ToInt32(drgetServiceCharge("ServiceCharge").ToString)
                        End If
                        listTBBILLFFC.Add(clsServiceCharge)
                    End While
                End If
            End Using
            Return listTBBILLFFC

        End Get
    End Property
    Private ReadOnly Property GetALLBillNo() As IEnumerable(Of clsRPTHowTimeBillPrint)
        Get
            Dim ListBillPrint As List(Of clsRPTHowTimeBillPrint) = New List(Of clsRPTHowTimeBillPrint)

            Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath
            Dim strQuery As String = "SELECT RPTHowTimeBillPrint.HTID, RPTHowTimeBillPrint.JobNo, RPTHowTimeBillPrint.BillNo FROM RPTHowTimeBillPrint inner join Claiminfo on RPTHowTimeBillPrint.JobNo=Claiminfo.JobCOde"
            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dcGetBill As OleDbCommand = New OleDbCommand(strQuery, con)


                con.Open()
                Dim drGetBill As OleDbDataReader = dcGetBill.ExecuteReader
                If drGetBill.HasRows = True Then
                    While drGetBill.Read
                        Dim rptBill As clsRPTHowTimeBillPrint = New clsRPTHowTimeBillPrint
                        If Not String.IsNullOrEmpty(drGetBill("HTID").ToString) Then
                            rptBill.HTID = Convert.ToInt32(drGetBill("HTID").ToString)
                        End If
                        rptBill.JobNo = drGetBill("JobNo").ToString
                        rptBill.BillNo = drGetBill("BillNo").ToString
                        ListBillPrint.Add(rptBill)
                    End While
                End If
            End Using
            Return ListBillPrint
        End Get
    End Property
    Private ReadOnly Property GetALLAdvanceInfo() As List(Of clsAdvanceInfo)
        Get
            Dim listAdvance As List(Of clsAdvanceInfo) = New List(Of clsAdvanceInfo)
            Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath
            Dim strQuery As String = "SELECT AdvanceInfo.JobCode, AdvanceInfo.Branch, AdvanceInfo.AdvNo, AdvanceInfo.AdvDate, AdvanceInfo.AdvAmnt, AdvanceInfo.AdvRemarks, AdvanceInfo.PayType, AdvanceInfo.BankName, AdvanceInfo.CardNo FROM AdvanceInfo inner Join Claiminfo on  AdvanceInfo.JobCode=claiminfo.JobCode"
            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dcGetAdvance As OleDbCommand = New OleDbCommand(strQuery, con)
                con.Open()
                Dim drGetAdvance As OleDbDataReader = dcGetAdvance.ExecuteReader
                If drGetAdvance.HasRows = True Then
                    While drGetAdvance.Read
                        Dim Advance As clsAdvanceInfo = New clsAdvanceInfo
                        Advance.JobCode = drGetAdvance("JobCode").ToString
                        Advance.Branch = drGetAdvance("Branch").ToString
                        Advance.AdvNo = drGetAdvance("AdvNo").ToString
                        If Not String.IsNullOrEmpty(drGetAdvance("AdvDate")) Then
                            Advance.AdvDate = Convert.ToDateTime(drGetAdvance("AdvDate").ToString)
                        End If
                        If Not String.IsNullOrEmpty(drGetAdvance("AdvAmnt")) Then
                            Advance.AdvAmnt = Convert.ToDouble(drGetAdvance("AdvAmnt").ToString)
                        End If
                        Advance.AdvRemarks = drGetAdvance("AdvRemarks").ToString
                        Advance.PayType = drGetAdvance("PayType").ToString
                        Advance.BankName = drGetAdvance("BankName").ToString
                        Advance.CardNo = drGetAdvance("CardNo").ToString
                        listAdvance.Add(Advance)
                    End While
                End If
            End Using
            Return listAdvance
        End Get
    End Property
    Private ReadOnly Property GetAllReplace() As List(Of clsReplace)
        Get
            Dim listReplace As List(Of clsReplace) = New List(Of clsReplace)
            Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath
            Dim strQuery As String = "SELECT Replace.ClaimID, Replace.JobCode, Replace.Brand, Replace.Model, Replace.ESN, Replace.ESNb, Replace.SLNo, Replace.Other, Replace.RDate, Replace.ReplaceBy FROM Replace inner Join Claiminfo on Replace.JobCode=Claiminfo.JobCode"
            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dcProductList As OleDbCommand = New OleDbCommand(strQuery, con)
                con.Open()
                Dim drReplace As OleDbDataReader = dcProductList.ExecuteReader
                If drReplace.HasRows = True Then
                    While drReplace.Read
                        Dim replace As clsReplace = New clsReplace
                        If Not String.IsNullOrEmpty(drReplace("ClaimID").ToString) Then
                            replace.ClaimID = Convert.ToInt32(drReplace("ClaimID").ToString)
                        End If
                        replace.JobCode = drReplace("JobCode").ToString
                        replace.Brand = drReplace("Brand").ToString
                        replace.Model = drReplace("Model").ToString
                        replace.ESN = drReplace("ESN").ToString
                        replace.ESNb = drReplace("ESNb").ToString
                        replace.SLNo = drReplace("SLNo").ToString
                        replace.Other = drReplace("Other").ToString
                        If Not String.IsNullOrEmpty(drReplace("RDate").ToString) Then
                            replace.RDate = Convert.ToDateTime(drReplace("RDate").ToString)
                        End If
                        replace.ReplaceBy = drReplace("ReplaceBy").ToString
                        listReplace.Add(replace)
                    End While
                End If
            End Using
            Return listReplace
        End Get
    End Property
    Private ReadOnly Property GetAllBill() As List(Of clstbBill)
        Get
            Dim listTbBill As List(Of clstbBill) = New List(Of clstbBill)

            Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath
            Dim strQuery As String = "SELECT tbBill.BillNO, tbBill.JobNO FROM tbBill inner Join Claiminfo on tbbill.JobNo=Claiminfo.JobCode"
            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dcTbBill As OleDbCommand = New OleDbCommand(strQuery, con)

                con.Open()
                Dim drTbBill As OleDbDataReader = dcTbBill.ExecuteReader
                If drTbBill.HasRows = True Then
                    While drTbBill.Read
                        Dim bill As clstbBill = New clstbBill
                        If Not String.IsNullOrEmpty(drTbBill("BillNO").ToString.Trim) Then
                            bill.BillNO = Convert.ToInt32(drTbBill("BillNO").ToString)
                        End If
                        bill.JobNO = drTbBill("JobNO").ToString
                        listTbBill.Add(bill)
                    End While
                End If
            End Using
            Return listTbBill
        End Get
    End Property
    Private Function GetAllCustomerClaim() As List(Of clsCustomerClaim)
        Dim listCustmerClaim As List(Of clsCustomerClaim) = New List(Of clsCustomerClaim)

        Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcLoadClaiminf As OleDbCommand = New OleDbCommand("Select Distinct CustomerClaim.JobCode from  CustomerClaim inner Join Claiminfo on CustomerClaim.JobCode=Claiminfo.JobCode", con)
            con.Open()
            Dim drLoadClaiminfo = dcLoadClaiminf.ExecuteReader
            If drLoadClaiminfo.HasRows = True Then
                While drLoadClaiminfo.Read
                    Dim CustomerClaim As clsCustomerClaim = New clsCustomerClaim
                    CustomerClaim.Jobcode = drLoadClaiminfo("JobCOde").ToString
                    listCustmerClaim.Add(GetCustomerClaim(CustomerClaim.Jobcode))
                End While
            End If

        End Using
        Return listCustmerClaim
    End Function
    Private Function GetCustomerClaim(ByVal strJob As String) As clsCustomerClaim
        Dim CustomerClaim As clsCustomerClaim = New clsCustomerClaim

        Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcLoadClaiminf As OleDbCommand = New OleDbCommand("Select * from CustomerClaim where CustomerClaim.JobCode=@JobCOde", con)

            dcLoadClaiminf.Parameters.Add("@JobCOde", OleDbType.Char, 255).Value = strJob
            con.Open()
            Dim drLoadClaiminfo = dcLoadClaiminf.ExecuteReader
            If drLoadClaiminfo.HasRows = True Then
                While drLoadClaiminfo.Read

                    CustomerClaim.Jobcode = drLoadClaiminfo("JobCOde").ToString
                    CustomerClaim.ClaimCode += drLoadClaiminfo("ClaimCode").ToString & ","
                End While

            End If

            If Not IsNothing(CustomerClaim.Jobcode) Then
                If isExistCustomerClaimOthers(CustomerClaim.Jobcode) = True Then
                    CustomerClaim.ClaimCode += GetCustomerClaimOthers(strJob)
                End If
            Else
                If isExistCustomerClaimOthers(strJob) = True Then
                    CustomerClaim.Jobcode = strJob
                    CustomerClaim.ClaimCode += GetCustomerClaimOthers(strJob)
                End If
            End If


            If CustomerClaim.ClaimCode.Length > 0 Then
                If CustomerClaim.ClaimCode.Substring(CustomerClaim.ClaimCode.Length - 1) = "," Then
                    CustomerClaim.ClaimCode = CustomerClaim.ClaimCode.Substring(0, CustomerClaim.ClaimCode.Length - 1)
                End If

            End If

        End Using
        Return CustomerClaim
    End Function
    Private Function GetCustomerClaimOthers(ByVal JobCode As String) As String
        Dim CustomerClaim As clsCustomerClaim = New clsCustomerClaim
        Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcLoadClaiminf As OleDbCommand = New OleDbCommand("Select * from CustomerClaimOthers where JobCode=@JobCode", con)
            dcLoadClaiminf.Parameters.Add("@JobCOde", OleDbType.Char, 255).Value = JobCode
            con.Open()
            Dim drLoadClaiminfo = dcLoadClaiminf.ExecuteReader
            If drLoadClaiminfo.HasRows = True Then
                While drLoadClaiminfo.Read
                    CustomerClaim.Jobcode = drLoadClaiminfo("JobCOde").ToString
                    CustomerClaim.ClaimCode = drLoadClaiminfo("ClaimCode").ToString & ","
                End While
            End If
        End Using
        Return CustomerClaim.ClaimCode
    End Function


    Private Function GetALLCustomerClaimOthers() As List(Of clsCustomerClaim)

        Dim ListCustClaim As List(Of clsCustomerClaim) = New List(Of clsCustomerClaim)

        Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcLoadClaiminf As OleDbCommand = New OleDbCommand("SELECT CustomerClaimOthers.JobCode, CustomerClaimOthers.ClaimCode FROM CustomerClaimOthers inner join Claiminfo on CustomerClaimOthers.JobCode=Claiminfo.JobCode", con)
            con.Open()
            Dim drLoadClaiminfo = dcLoadClaiminf.ExecuteReader
            If drLoadClaiminfo.HasRows = True Then
                While drLoadClaiminfo.Read
                    Dim CustomerClaim As clsCustomerClaim = New clsCustomerClaim
                    CustomerClaim.Jobcode = drLoadClaiminfo("JobCOde").ToString
                    CustomerClaim.ClaimCode = drLoadClaiminfo("ClaimCode").ToString
                    ListCustClaim.Add(CustomerClaim)
                End While
            End If
        End Using
        Return ListCustClaim
    End Function

    Private Function isExistCustomerClaimOthers(ByVal JobCode As String) As Boolean
        Dim CustomerClaim As clsCustomerClaim = New clsCustomerClaim
        Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcLoadClaiminf As OleDbCommand = New OleDbCommand("Select * from CustomerClaimOthers where JobCode=@JobCode", con)
            dcLoadClaiminf.Parameters.Add("@JobCOde", OleDbType.Char, 255).Value = JobCode
            con.Open()
            Dim drLoadClaiminfo = dcLoadClaiminf.ExecuteReader
            If drLoadClaiminfo.HasRows = True Then
                Return True
            End If
        End Using
        Return False
    End Function
    Private ReadOnly Property NRALLDetails() As List(Of clsNrdetails)
        Get

            Dim listNRDetails As List(Of clsNrdetails) = New List(Of clsNrdetails)

            Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath
            Dim tmpNrDetails As clsNrdetails = New clsNrdetails
            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dcGetNR As OleDbCommand = New OleDbCommand("Select distinct Nrdetails.jobcode from NRDetails inner join Claiminfo on  NRDetails.JobCode=Claiminfo.JobCode", con)
                con.Open()
                Dim drGetNR As OleDbDataReader = dcGetNR.ExecuteReader
                If drGetNR.HasRows = True Then
                    While drGetNR.Read
                        tmpNrDetails.JobCode = drGetNR("JobCode").ToString
                        listNRDetails.Add(NRDetails(tmpNrDetails.JobCode))
                    End While
                End If

            End Using
            Return listNRDetails

        End Get
    End Property
    Private Function NRDetails(ByVal JobCode As String) As clsNrdetails
        Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath
        Dim tmpNrDetails As clsNrdetails = New clsNrdetails
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcGetNR As OleDbCommand = New OleDbCommand("SELECT NRDetails.ClaimID, NRDetails.JobCode, NRDetails.NRCode FROM NRDetails inner join claiminfo on NRDetails.JobCode=claiminfo.JobCode  where NRDetails.JobCOde=@JobCOde", con)
            dcGetNR.Parameters.Add("@JobCOde", OleDbType.Char, 255).Value = JobCode
            con.Open()
            Dim drGetNR As OleDbDataReader = dcGetNR.ExecuteReader
            If drGetNR.HasRows = True Then
                While drGetNR.Read
                    Application.DoEvents()
                    tmpNrDetails.JobCode = drGetNR("JobCode").ToString
                    tmpNrDetails.NRCode += drGetNR("NRCode").ToString & ","
                End While
            End If


            If Not IsNothing(tmpNrDetails.JobCode) Then
                If IsExistNRDetailsOthers(tmpNrDetails.JobCode) = True Then
                    tmpNrDetails.NRCode += NRDetailsOthers(tmpNrDetails.JobCode)
                End If
            Else
                If IsExistNRDetailsOthers(JobCode) = True Then
                    tmpNrDetails.JobCode = JobCode
                    tmpNrDetails.NRCode += NRDetailsOthers(tmpNrDetails.JobCode)
                End If

            End If


            If tmpNrDetails.NRCode.Length > 0 Then
                If tmpNrDetails.NRCode.Substring(tmpNrDetails.NRCode.Length - 1) = "," Then
                    tmpNrDetails.NRCode = tmpNrDetails.NRCode.Substring(0, tmpNrDetails.NRCode.Length - 1)
                End If

            End If

        End Using
        Return tmpNrDetails
    End Function
    Private Function NRDetailsOthers(ByVal JobCode As String) As String
        Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath
        Dim tmpNrDetails As clsNrdetails = New clsNrdetails
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcGetNR As OleDbCommand = New OleDbCommand("Select * from NROthers where JobCOde=@JobCOde", con)
            dcGetNR.Parameters.Add("@JobCOde", OleDbType.Char, 255).Value = JobCode
            con.Open()
            Dim drGetNR As OleDbDataReader = dcGetNR.ExecuteReader
            If drGetNR.HasRows = True Then

                While drGetNR.Read
                    tmpNrDetails.ClaimID = Convert.ToInt32(drGetNR("ClaimID").ToString)
                    tmpNrDetails.JobCode = drGetNR("JobCode").ToString
                    tmpNrDetails.NRCode = drGetNR("NRCode").ToString & ","
                End While

            End If
        End Using
        Return tmpNrDetails.NRCode
    End Function


    Private Function GetALLNRDetailsOthers() As List(Of clsNrdetails)
        Dim listNRDetails As List(Of clsNrdetails) = New List(Of clsNrdetails)

        Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath

        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcGetNR As OleDbCommand = New OleDbCommand("SELECT NROthers.ClaimID, NROthers.JobCode, NROthers.NRCode FROM NROthers inner Join Claiminfo on  NROthers.JobCOde=claiminfo.JobCode", con)

            con.Open()
            Dim drGetNR As OleDbDataReader = dcGetNR.ExecuteReader
            If drGetNR.HasRows = True Then

                While drGetNR.Read
                    Dim tmpNrDetails As clsNrdetails = New clsNrdetails
                    tmpNrDetails.ClaimID = Convert.ToInt32(drGetNR("ClaimID").ToString)
                    tmpNrDetails.JobCode = drGetNR("JobCode").ToString
                    tmpNrDetails.NRCode = drGetNR("NRCode").ToString
                    listNRDetails.Add(tmpNrDetails)
                End While

            End If
        End Using
        Return listNRDetails
    End Function

    Private Function IsExistNRDetailsOthers(ByVal JobCode As String) As Boolean
        Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath
        Dim tmpNrDetails As clsNrdetails = New clsNrdetails
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcGetNR As OleDbCommand = New OleDbCommand("Select * from NROthers where JobCOde=@JobCOde", con)
            dcGetNR.Parameters.Add("@JobCOde", OleDbType.Char, 255).Value = JobCode
            con.Open()
            Dim drGetNR As OleDbDataReader = dcGetNR.ExecuteReader
            If drGetNR.HasRows = True Then
                Return True
            End If
        End Using
        Return False
    End Function
    Public Function GetAllPending() As List(Of clsPending)

        Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath
        Dim pending As clsPending = New clsPending
        Dim ListPending As List(Of clsPending) = New List(Of clsPending)

        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcGetPending As OleDbCommand = New OleDbCommand("Select distinct Pending.JobCode from Pending inner join Claiminfo on Pending.jobCode=Claiminfo.JobCode", con)


            con.Open()
            Dim drGetPending As OleDbDataReader = dcGetPending.ExecuteReader
            If drGetPending.HasRows = True Then

                While drGetPending.Read
                    pending.JobCode = drGetPending("JobCode").ToString
                    ListPending.Add(GetPending(pending.JobCode))

                End While
            End If




        End Using
        Return ListPending

    End Function
    Public Function GetPending(ByVal SearchCriteria As String) As clsPending

        Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath
        Dim pending As clsPending = New clsPending

        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcGetPending As OleDbCommand = New OleDbCommand("SELECT Pending.ClaimID, Pending.JobCode, Pending.PenCode FROM Pending inner join Claiminfo on Pending.jobCode=Claiminfo.JobCode where Pending.JobCode=@JobCode", con)
            dcGetPending.Parameters.Add("@JobCode", OleDbType.Char, 255).Value = SearchCriteria

            con.Open()
            Dim drGetPending As OleDbDataReader = dcGetPending.ExecuteReader
            If drGetPending.HasRows = True Then

                While drGetPending.Read
                    pending.ClaimID = Convert.ToInt32(drGetPending("ClaimID").ToString)
                    pending.JobCode = drGetPending("JobCode").ToString
                    pending.PenCode += drGetPending("Pencode").ToString & ","
                End While
            End If

            If Not IsNothing(pending.JobCode) Then
                If IsExistPendingOthers(pending.JobCode) = True Then
                    pending.PenCode += GetPendingOthers(pending.JobCode)
                End If
            Else
                If IsExistPendingOthers(SearchCriteria) = True Then
                    pending.JobCode = SearchCriteria
                    pending.PenCode += NRDetailsOthers(pending.JobCode)
                End If

            End If


            If pending.PenCode.Length > 0 Then
                If pending.PenCode.Substring(pending.PenCode.Length - 1) = "," Then
                    pending.PenCode = pending.PenCode.Substring(0, pending.PenCode.Length - 1)
                End If

            End If

        End Using
        Return pending

    End Function
    Public Function IsExistPendingOthers(ByVal SearchCriteria As String) As Boolean

        Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath
        Dim pending As clsPending = New clsPending

        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcGetPending As OleDbCommand = New OleDbCommand("SELECT PendingOther.ClaimID, PendingOther.JobCode, PendingOther.PenCode FROM PendingOther where PendingOther.JobCode=@JobCode", con)
            dcGetPending.Parameters.Add("@JobCode", OleDbType.Char, 255).Value = SearchCriteria
            con.Open()
            Dim drGetPending As OleDbDataReader = dcGetPending.ExecuteReader
            If drGetPending.HasRows = True Then

                Return True
            End If
        End Using
        Return False

    End Function
    Public Function GetPendingOthers(ByVal SearchCriteria As String) As String

        Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath
        Dim pending As clsPending = New clsPending

        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcGetPending As OleDbCommand = New OleDbCommand("SELECT PendingOther.ClaimID, PendingOther.JobCode, PendingOther.PenCode FROM PendingOther inner Join Claiminfo on PendingOther.JobCode=Claiminfo.JobCode where PendingOther.JobCode=@JobCode", con)
            dcGetPending.Parameters.Add("@JobCode", OleDbType.Char, 255).Value = SearchCriteria
            con.Open()
            Dim drGetPending As OleDbDataReader = dcGetPending.ExecuteReader
            If drGetPending.HasRows = True Then

                While drGetPending.Read
                    pending.ClaimID = Convert.ToInt32(drGetPending("ClaimID").ToString)
                    pending.JobCode = drGetPending("JobCode").ToString
                    pending.PenCode += drGetPending("Pencode").ToString & ","
                End While
            End If
        End Using
        Return pending.PenCode

    End Function


    Public Function GetALLPendingOthers() As List(Of clsPending)
        Dim listPending As List(Of clsPending) = New List(Of clsPending)

        Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath


        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcGetPending As OleDbCommand = New OleDbCommand("SELECT PendingOther.ClaimID, PendingOther.JobCode, PendingOther.PenCode FROM PendingOther inner Join Claiminfo on PendingOther.JobCode=Claiminfo.JobCode", con)

            con.Open()
            Dim drGetPending As OleDbDataReader = dcGetPending.ExecuteReader
            If drGetPending.HasRows = True Then

                While drGetPending.Read
                    Dim pending As clsPending = New clsPending
                    pending.ClaimID = Convert.ToInt32(drGetPending("ClaimID").ToString)
                    pending.JobCode = drGetPending("JobCode").ToString
                    pending.PenCode += drGetPending("Pencode").ToString
                    listPending.Add(pending)
                End While
            End If
        End Using
        Return listPending

    End Function

    ' ________________________________________________ Service Details Section _______________________________________________________
    Public Function GetAllpartsDetails() As List(Of clsServiceDetails)
        Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath
        Dim servicedetails As clsServiceDetails = New clsServiceDetails
        Dim ListServiceDetails As List(Of clsServiceDetails) = New List(Of clsServiceDetails)
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcGetParts As OleDbCommand = New OleDbCommand("Select distinct Servicedetails.JobCode from ServiceDetails inner join Claiminfo on ServiceDetails.JobCode=Claiminfo.JobCode", con)
            dcGetParts.CommandType = CommandType.Text
            con.Open()
            Dim drGetParts As OleDbDataReader = dcGetParts.ExecuteReader
            If drGetParts.HasRows = True Then
                While drGetParts.Read
                    servicedetails.Jobcode = drGetParts("JobCode").ToString
                    ListServiceDetails.Add(partsDetails(servicedetails.Jobcode))
                End While
            End If
        End Using
        Return ListServiceDetails
    End Function
    Public Function partsDetails(ByVal SearchCriteria As String) As clsServiceDetails

        Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath
        Dim servicedetails As clsServiceDetails = New clsServiceDetails

        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcGetParts As OleDbCommand = New OleDbCommand("SELECT ServiceDetails.SID, ServiceDetails.JobCode, ServiceDetails.ProductCode, ServiceDetails.Qty, ServiceDetails.UnitPrice, ServiceDetails.Remarks FROM ServiceDetails where JobCode=@JobCode", con)
            dcGetParts.CommandType = CommandType.Text
            dcGetParts.Parameters.Add("@JobCode", OleDbType.Char, 255).Value = SearchCriteria
            con.Open()
            Dim drGetParts As OleDbDataReader = dcGetParts.ExecuteReader
            If drGetParts.HasRows = True Then
                While drGetParts.Read
                    If Not String.IsNullOrEmpty(Trim(drGetParts("Remarks").ToString)) Then
                        servicedetails.Jobcode = drGetParts("JobCode").ToString
                        servicedetails.Description = "Remarks:" & drGetParts("Remarks").ToString & "|"
                    Else
                        servicedetails.Jobcode = drGetParts("JobCode").ToString
                        If drGetParts("ProductCode").ToString = "123063341IM" Then
                            servicedetails.Description += drGetParts("ProductCode").ToString & "," & getProductName(drGetParts("ProductCode").ToString) & "," & drGetParts("Qty").ToString & "," & drGetParts("UnitPrice").ToString & "|"


                        End If
                        servicedetails.Description += drGetParts("ProductCode").ToString & "," & getProductName(drGetParts("ProductCode").ToString) & "," & drGetParts("Qty").ToString & "," & drGetParts("UnitPrice").ToString & "|"
                    End If
                End While
            End If
        End Using
        Return servicedetails
    End Function
    Public ReadOnly Property GetAllDetailDetails() As IEnumerable(Of clsServiceDetails)
        Get
            Dim ListServiceDetails As List(Of clsServiceDetails) = New List(Of clsServiceDetails)

            Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath

            Dim strSqlQuery = "SELECT ServiceDetails.SID, ServiceDetails.JobCode, ServiceDetails.ProductCode, ServiceDetails.Qty, ServiceDetails.UnitPrice, ServiceDetails.Remarks FROM ServiceDetails Inner Join Claiminfo on ServiceDetails.JobCode=Claiminfo.JobCode"

            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dcServiceDetails As OleDbCommand = New OleDbCommand(strSqlQuery, con)
                'dcServiceDetails.Parameters.Add("@JobCode", OleDbType.Char, 255).Value = Checkid
                con.Open()

                Dim drServicedetails As OleDbDataReader = dcServiceDetails.ExecuteReader
                If drServicedetails.HasRows = True Then
                    While drServicedetails.Read
                        Dim servicedetails As clsServiceDetails = New clsServiceDetails
                        If Not String.IsNullOrEmpty(drServicedetails("Remarks").ToString) Then
                            servicedetails.Jobcode = drServicedetails("JobCode").ToString
                            servicedetails.Remarks = drServicedetails("Remarks").ToString
                        Else
                            servicedetails.Jobcode = drServicedetails("JobCode").ToString
                            servicedetails.ProductCode = drServicedetails("ProductCode").ToString
                            If Not String.IsNullOrEmpty(drServicedetails("Qty").ToString) Then
                                servicedetails.Qty = drServicedetails("Qty").ToString
                            End If
                            If Not String.IsNullOrEmpty(drServicedetails("UnitPrice").ToString) Then
                                servicedetails.UnitPrice = drServicedetails("UnitPrice").ToString
                            End If
                        End If
                        ListServiceDetails.Add(servicedetails)
                    End While
                End If
            End Using
            Return ListServiceDetails

        End Get
    End Property
    Public ReadOnly Property IsexitServiceDetails(ByVal Checkid As String) As Boolean
        Get


            Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath

            Dim strSqlQuery = "Select * from ServiceDetails where ServiceDetails.JobCode=@JobCode"

            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dcServiceDetails As OleDbCommand = New OleDbCommand(strSqlQuery, con)
                dcServiceDetails.Parameters.Add("@JobCode", OleDbType.Char, 255).Value = Checkid
                con.Open()

                Dim drServicedetails As OleDbDataReader = dcServiceDetails.ExecuteReader
                If drServicedetails.HasRows = True Then
                    Return True
                End If
            End Using
            Return False

        End Get
    End Property
    ' ________________________________________________ End Service Details Section _______________________________________________________
    Private Function GetAllEstRefused() As List(Of clsEstimateRefused)
        Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath

        Dim ListEstRefused As List(Of clsEstimateRefused) = New List(Of clsEstimateRefused)

        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcSaveEr As OleDbCommand = New OleDbCommand("SELECT EstimateRefused.EstRAID, EstimateRefused.JobCode, EstimateRefused.ServiceBy_ID, EstimateRefused.EstDate, EstimateRefused.EstText, EstimateRefused.RefuseAmnt, EstimateRefused.Branch FROM EstimateRefused inner join Claiminfo on EstimateRefused.JobCode=Claiminfo.JobCode", con)
            dcSaveEr.CommandType = CommandType.Text

            con.Open()
            Dim drSaveEr = dcSaveEr.ExecuteReader
            While drSaveEr.Read
                Dim EstimateRefuse As clsEstimateRefused = New clsEstimateRefused
                With EstimateRefuse
                    .EstRAID = Convert.ToInt32(drSaveEr("EstRAID").ToString)
                    .JobCode = drSaveEr("JobCode").ToString
                    .ServiceBy_ID = drSaveEr("ServiceBy_ID").ToString
                    If Not String.IsNullOrEmpty(drSaveEr("EstDate").ToString) Then
                        .EstDate = Convert.ToDateTime(drSaveEr("EstDate").ToString)
                    End If
                    .EstText = drSaveEr("EstText").ToString
                    If Not String.IsNullOrEmpty(drSaveEr("RefuseAmnt").ToString) Then
                        .RefuseAmnt = Convert.ToDouble(drSaveEr("RefuseAmnt").ToString)
                    End If
                    .Branch = drSaveEr("Branch").ToString
                End With

                ListEstRefused.Add(EstimateRefuse)
            End While
        End Using
        Return ListEstRefused
    End Function
    Private Function GetAllItem() As List(Of clsServiceItem)
        Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath
        Dim listGetItem As List(Of clsServiceItem) = New List(Of clsServiceItem)
        Dim strJobCode As String = String.Empty

        Using con = New OleDbConnection(cs)
            Dim dcserviceItem = New OleDbCommand("Select distinct ServiceItem.JobCode from ServiceItem inner Join Claiminfo on ServiceItem.JobCode=Claiminfo.jobCode", con)
            dcserviceItem.CommandType = CommandType.Text

            con.Open()
            Dim drServiceItem = dcserviceItem.ExecuteReader
            If drServiceItem.HasRows = True Then

                '5560
                While drServiceItem.Read
                    Dim serviceItem As clsServiceItem = New clsServiceItem
                        strJobCode = drServiceItem("JobCode").ToString

                        serviceItem.JobCode = drServiceItem("JobCode").ToString

                    listGetItem.Add(GetItem(serviceItem.JobCode))

                End While


            End If
        End Using
        Return listGetItem
    End Function


    Private Function GetItem(ByVal strGetItem As String) As clsServiceItem
        Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath
        Dim serviceItem As clsServiceItem = New clsServiceItem
        Using con = New OleDbConnection(cs)
            Dim dcserviceItem = New OleDbCommand("Select ServiceItem.JobCode,ServiceItem.Item from ServiceItem inner Join Claiminfo on ServiceItem.JobCode=Claiminfo.jobCode where ServiceItem.JobCode=@JobCode", con)
            dcserviceItem.CommandType = CommandType.Text
            dcserviceItem.Parameters.Add("@JobCode", OleDbType.Char, 255).Value = strGetItem
            con.Open()
            Dim drServiceItem = dcserviceItem.ExecuteReader
            If drServiceItem.HasRows = True Then
                While drServiceItem.Read

                    serviceItem.JobCode = drServiceItem("JobCode").ToString
                    serviceItem.Item += drServiceItem("Item").ToString & ","
                End While
                If serviceItem.Item.Count > 0 Then
                    If serviceItem.Item.Substring(serviceItem.Item.Length - 1, 1) = "," Then
                        serviceItem.Item = serviceItem.Item.Substring(0, serviceItem.Item.Length - 1)
                    End If
                End If
            End If
        End Using
        Return serviceItem
    End Function

    Private Function GetTBBill() As List(Of clstbBill)
        Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath
        Dim lstTbBill As List(Of clstbBill) = New List(Of clstbBill)
        Using con = New OleDbConnection(cs)
            Dim dcGetTBBill As OleDbCommand = New OleDbCommand("Select * From tbBill inner join Claiminfo on tbBill.jobno=claiminfo.JobCode")
            dcGetTBBill.CommandType = CommandType.Text

            con.Open()
            Dim drGetTbbill As OleDbDataReader = dcGetTBBill.ExecuteReader
            If drGetTbbill.HasRows = True Then
                While drGetTbbill.Read()
                    Dim getclstbBill As clstbBill = New clstbBill
                    getclstbBill.BillNO = drGetTbbill("BillNO").ToString
                    getclstbBill.JobNO = drGetTbbill("JobNO").ToString
                    lstTbBill.Add(getclstbBill)
                End While
            End If
        End Using
        Return lstTbBill
    End Function
    Private Function getProductName(ByVal Code As String) As String
        Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath
        Dim strProductName As String = String.Empty
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcGetProduct As OleDbCommand = New OleDbCommand("Select * from Product where Product.Code=@Code", con)
            dcGetProduct.Parameters.Add("@Code", OleDb.OleDbType.Char, 255).Value = Code
            con.Open()
            Dim drGetProduct As OleDbDataReader = dcGetProduct.ExecuteReader
            If drGetProduct.HasRows = True Then
                While drGetProduct.Read
                    strProductName = RemoveCommafromText(drGetProduct("ProdName").ToString)
                End While
            Else
                strProductName = "Product Name is Missing"
            End If
        End Using
        Return strProductName
    End Function
    Private Function tmpCashsales() As IEnumerable(Of clsCashsales)
        Dim dt As DataTable = New DataTable
        Dim ListCashsales As List(Of clsCashsales) = New List(Of clsCashsales)
        Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath
        Dim strQuery = "Select * from Cashsales"
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcCashsales As OleDbCommand = New OleDbCommand(strQuery, con)
            con.Open()
            Dim drcashsales As OleDbDataReader = dcCashsales.ExecuteReader
            While drcashsales.Read
                Dim cashsale As clsCashsales = New clsCashsales
                cashsale.MRNO = drcashsales("MRNO").ToString
                cashsale.JobCode = drcashsales("JobCode").ToString
                cashsale.Branch = drcashsales("Branch").ToString
                cashsale.CustName = drcashsales("CustName").ToString
                cashsale.CustAddress1 = drcashsales("CustAddress1").ToString
                cashsale.CustAddress2 = drcashsales("CustAddress2").ToString
                cashsale.Brand = drcashsales("Brand").ToString
                cashsale.ModelNo = drcashsales("ModelNo").ToString
                cashsale.ESN = drcashsales("ESN").ToString
                cashsale.SLNo = drcashsales("SLNo").ToString
                If Not String.IsNullOrEmpty(drcashsales("ReceptDate").ToString) Then
                    cashsale.ReceptDate = drcashsales("ReceptDate").ToString
                End If
                cashsale.ReceptBy = drcashsales("ReceptBy").ToString
                cashsale.Code = drcashsales("Code").ToString
                cashsale.ProdName = drcashsales("ProdName").ToString
                If Not String.IsNullOrEmpty(drcashsales("Rate").ToString) Then
                    cashsale.Rate = Convert.ToDouble(drcashsales("Rate").ToString)
                End If
                If Not String.IsNullOrEmpty(drcashsales("Qty").ToString) Then
                    cashsale.Qty = Convert.ToDouble(drcashsales("Qty").ToString)
                End If
                If Not String.IsNullOrEmpty(drcashsales("Amount").ToString) Then
                    cashsale.Amount = Convert.ToDouble(drcashsales("Amount").ToString)
                End If
                If Not String.IsNullOrEmpty(drcashsales("PrdAmt").ToString) Then
                    cashsale.PrdAmt = Convert.ToDouble(drcashsales("PrdAmt").ToString)
                End If
                If Not String.IsNullOrEmpty(drcashsales("Dis").ToString) Then
                    cashsale.Dis = Convert.ToDouble(drcashsales("Dis").ToString)
                End If
                If Not String.IsNullOrEmpty(drcashsales("NetAmnt").ToString) Then
                    cashsale.NetAmnt = Convert.ToDouble(drcashsales("NetAmnt").ToString)
                End If
                cashsale.Log_User = drcashsales("Log_User").ToString
                If Not String.IsNullOrEmpty(drcashsales("Log_Date").ToString) Then
                    cashsale.Log_Date = Convert.ToDateTime(drcashsales("Log_Date").ToString)
                End If
                If Not String.IsNullOrEmpty(drcashsales("DFlag").ToString) Then
                    cashsale.DFlag = Convert.ToInt32(drcashsales("DFlag").ToString)
                End If
                ListCashsales.Add(cashsale)
            End While
        End Using
        Return ListCashsales
    End Function
    Private Function RemoveCommafromText(ByVal Remove As String) As String

        Dim strReturnValue As String = String.Empty
        For Each tmpstr As String In Remove
            If tmpstr = "," Then
                strReturnValue += "-"
            Else
                strReturnValue += tmpstr
            End If

        Next
        Return strReturnValue

    End Function
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Application.DoEvents()
        lblTime.Text = Now.TimeOfDay.Hours.ToString & "-" & Now.TimeOfDay.Minutes.ToString & "-" & Now.TimeOfDay.Seconds.ToString
        Dim timeElpase As TimeSpan = Now.TimeOfDay.Subtract(beginTime)
        lblElapseTime.Text = timeElpase.Hours.ToString & "-" & timeElpase.Minutes.ToString & "-" & timeElpase.Seconds.ToString

    End Sub

    Private Sub lblProcessingTable_Click(sender As Object, e As EventArgs) Handles lblProcessingTable.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Try




#Region "Compact Database"

            '            Dim File_Path, compact_file As String
            '            'Original file path that u want to compact
            '            File_Path = AppDomain.CurrentDomain.BaseDirectory & "Service.mdb"
            '            'compact file path, a temp file
            '            compact_file = AppDomain.CurrentDomain.BaseDirectory & "Service1.mdb"
            '            'First check the file u want to compact exists or not
            '            If File.Exists(File_Path) Then
            '                Dim db As New DAO.DBEngine()
            '                'CompactDatabase has two parameters, creates a copy of 
            '                'compact DB at the Destination path
            '                db.CompactDatabase(File_Path, compact_file)
            '            End If
            '            'restore the original file from the compacted file
            '            If File.Exists(compact_file) Then
            '                File.Delete(File_Path)
            '                File.Move(compact_file, File_Path)
            '            End If

#End Region
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles optFastLoad.CheckedChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label2_MouseDown(sender As Object, e As MouseEventArgs) Handles Label2.MouseDown
        ReleaseCapture()
        SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
    End Sub


#End Region





#Region "Load Data For Merge"

    'Public ReadOnly Property GetSingleTransfer(ByVal SearchID As String) As  clsTransferJob
    '    Get


    '                      Dim Transferjob As clsTransferJob = New clsTransferJob

    '        Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath

    '        Dim strQuery As String = "Select * from TransferJob inner join claiminfo on TransferJob.JobCode=Claiminfo.JobCode where TransferJob.JobCode=@JobCode"

    '           '        Using con As OleDbConnection = New OleDbConnection(cs)

    '            Dim dcTransferJob As OleDbCommand = New OleDbCommand(strQuery, con)

    '            dcTransferJob.Parameters.Add("@JobCode", OleDbType.Char, 255).Value = SearchID

    '            con.Open()
    '            Dim drTransferJob As OleDbDataReader = dcTransferJob.ExecuteReader


    '            If drTransferJob.HasRows = True Then
    '                While drTransferJob.Read

    '                    If Not String.IsNullOrEmpty(drTransferJob("TrID").ToString.Trim) Then
    '                        Transferjob.TrID = Convert.ToInt32(drTransferJob("TrID").ToString)
    '                    End If
    '                    Transferjob.JobCode = drTransferJob("JobCode").ToString
    '                    Transferjob.Remarks = drTransferJob("Remarks").ToString
    '                    Transferjob.TransferFrom = drTransferJob("TransferFrom").ToString
    '                    Transferjob.TransferTo = drTransferJob("TransferTo").ToString
    '                    If Not String.IsNullOrEmpty(drTransferJob("TrDate").ToString) Then
    '                        Transferjob.TrDate = drTransferJob("TrDate").ToString
    '                    End If
    '                    Transferjob.TrByCode = drTransferJob("TrByCode").ToString
    '                    Transferjob.TrByName = drTransferJob("TrByName").ToString

    '                End While
    '            End If
    '        End Using
    '        Return Transferjob
    '    End Get
    'End Property


    'Public Function IsExistTransferJob(ByVal SearchID As String) As Boolean

    '    Dim Transferjob As clsTransferJob = New clsTransferJob
    '    Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath
    '    Dim strQuery As String = "Select * from TransferJob where TransferJob.JobCode=@JobCode"
    '    Using con As OleDbConnection = New OleDbConnection(cs)
    '        Dim dcTransferJob As OleDbCommand = New OleDbCommand(strQuery, con)
    '        dcTransferJob.Parameters.Add("@JobCode", OleDbType.Char, 255).Value = SearchID
    '        con.Open()
    '        Dim drTransferJob As OleDbDataReader = dcTransferJob.ExecuteReader
    '        If drTransferJob.HasRows = True Then
    '            Return True
    '        End If
    '    End Using
    '    Return False
    'End Function

    'Public ReadOnly Property GetSingleStorageSet(ByVal CheckID As String) As clstbStorageSet
    '    Get
    '        Dim storage As clstbStorageSet = New clstbStorageSet
    '        Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath
    '        Dim strQuery As String = "Select * from tbStoregeSET where tbStoregeSET.JobCode=@JobCode"
    '        Using con As OleDbConnection = New OleDbConnection(cs)
    '            Dim dcStorage As OleDbCommand = New OleDbCommand(strQuery, con)
    '            dcStorage.Parameters.Add("@JobCode", OleDbType.Char, 255).Value = CheckID
    '            con.Open()
    '            Dim drStorage As OleDbDataReader = dcStorage.ExecuteReader
    '            If drStorage.HasRows = True Then
    '                While drStorage.Read
    '                    'tbStoregeSET.SSID, tbStoregeSET.JobCode, tbStoregeSET.Location, tbStoregeSET.SendDate, 
    '                    'tbStoregeSET.Bin,tbStoregeSET.Remarks, tbStoregeSET.Branch
    '                    If Not String.IsNullOrEmpty(drStorage("SSID").ToString) Then
    '                        storage.SSID = Convert.ToInt32(drStorage("SSID").ToString)
    '                    End If
    '                    storage.JobCode = drStorage("JobCode").ToString
    '                    storage.Location = drStorage("Location").ToString
    '                    If Not String.IsNullOrEmpty(drStorage("SendDate").ToString) Then
    '                        storage.SendDate = drStorage("SendDate").ToString
    '                    End If
    '                    storage.Bin = drStorage("Bin").ToString
    '                    storage.Remarks = drStorage("Remarks").ToString
    '                    storage.Branch = drStorage("Branch").ToString
    '                End While
    '            End If
    '        End Using
    '        Return storage
    '    End Get
    'End Property
    'Public Function IsExistTBstorage(ByVal CheckID As String) As Boolean
    '    Dim storage As clstbStorageSet = New clstbStorageSet
    '    Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath
    '    Dim strQuery As String = "Select * from tbStoregeSET where tbStoregeSET.JobCode=@JobCode"
    '    Using con As OleDbConnection = New OleDbConnection(cs)
    '        Dim dcStorage As OleDbCommand = New OleDbCommand(strQuery, con)
    '        dcStorage.Parameters.Add("@JobCode", OleDbType.Char, 255).Value = CheckID
    '        con.Open()
    '        Dim drStorage As OleDbDataReader = dcStorage.ExecuteReader
    '        If drStorage.HasRows = True Then
    '            Return True
    '        End If
    '    End Using
    '    Return False
    'End Function


    'Public Function GetCustomerGrade(ByVal SearchCriteria As String) As clstbGrade
    '    Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath
    '    Dim tbGrade = New clstbGrade
    '    Using con As OleDbConnection = New OleDbConnection(cs)
    '        Dim dcCustGrade = New OleDbCommand("Select * from tbGrade where tbgrade.JobCode=@JobCode", con)
    '        dcCustGrade.CommandType = CommandType.Text
    '        dcCustGrade.Parameters.Add("@JobCode", OleDbType.Char, 255).Value = SearchCriteria
    '        con.Open()
    '        Dim drCustGrade = dcCustGrade.ExecuteReader
    '        If drCustGrade.HasRows = True Then
    '            While drCustGrade.Read
    '                tbGrade.GradeID = Convert.ToInt32(drCustGrade("ID").ToString)
    '                tbGrade.Jobcode = drCustGrade("JobCode").ToString
    '                tbGrade.cGrade = drCustGrade("cGrade").ToString
    '                tbGrade.cRemarks = drCustGrade("cRemarks").ToString
    '            End While
    '        End If
    '    End Using
    '    Return tbGrade
    'End Function


    'Public Function IsExistTBGrade(ByVal SearchCriteria As String) As Boolean
    '    Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath
    '    Dim tbGrade = New clstbGrade
    '    Using con As OleDbConnection = New OleDbConnection(cs)
    '        Dim dcCustGrade = New OleDbCommand("Select * from tbGrade where tbGrade.JobCode=@JobCode", con)
    '        dcCustGrade.CommandType = CommandType.Text 
    '        dcCustGrade.Parameters.Add("@JobCode", OleDbType.Char, 255).Value = SearchCriteria
    '        con.Open()
    '        Dim drCustGrade = dcCustGrade.ExecuteReader
    '        If drCustGrade.HasRows = True Then
    '            Return True
    '        End If
    '    End Using
    '    Return False
    'End Function


    'Public Function GetServiceCharge(ByVal SearchCriteria As String) As clstbBill_FFC
    '    Dim clsServiceCharge As clstbBill_FFC = New clstbBill_FFC
    '    Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath
    '    Using con As OleDbConnection = New OleDbConnection(cs)
    '        Dim dcGetServiceCharge As OleDbCommand = New OleDbCommand("Select * from tbBill_FFC where  tbBill_FFC.JobNO=@JobNO", con)
    '        dcGetServiceCharge.CommandType = CommandType.Text
    '        dcGetServiceCharge.Parameters.Add("@JobNO", OleDbType.Char, 255).Value = SearchCriteria
    '        con.Open()
    '        Dim drgetServiceCharge As OleDbDataReader = dcGetServiceCharge.ExecuteReader()
    '        If drgetServiceCharge.HasRows = True Then

    '            While drgetServiceCharge.Read
    '            clsServiceCharge.Jobcode = drgetServiceCharge("JobNO").ToString
    '            If Not String.IsNullOrEmpty(drgetServiceCharge("FaultCharge").ToString) Then
    '                clsServiceCharge.FaultCharge = Convert.ToInt32(drgetServiceCharge("FaultCharge").ToString)
    '            End If
    '            If Not String.IsNullOrEmpty(drgetServiceCharge("ServiceCharge").ToString) Then
    '                clsServiceCharge.ServiceCharge = Convert.ToInt32(drgetServiceCharge("ServiceCharge").ToString)
    '            End If
    '            End While

    '        End If
    '    End Using
    '    Return clsServiceCharge
    'End Function


    'Public Function ISTBTBILL_FFCEXIST(ByVal SearchCriteria As String) As Boolean
    '    Dim clsServiceCharge As clstbBill_FFC = New clstbBill_FFC
    '    Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath
    '    Using con As OleDbConnection = New OleDbConnection(cs)
    '        Dim dcGetServiceCharge As OleDbCommand = New OleDbCommand("Select * from tbBill_FFC where  tbBill_FFC.JobNO=@JobNO", con)
    '        dcGetServiceCharge.CommandType = CommandType.Text 
    '        dcGetServiceCharge.Parameters.Add("@JobNO", OleDbType.Char, 255).Value = SearchCriteria
    '        con.Open()
    '        Dim drgetServiceCharge As OleDbDataReader = dcGetServiceCharge.ExecuteReader()
    '        If drgetServiceCharge.HasRows = True Then
    '            Return True
    '        End If
    '    End Using
    '    Return False
    'End Function


    'Private ReadOnly Property GetSingleBillNo(ByVal SearchID As String) As IEnumerable(Of clsRPTHowTimeBillPrint)
    '    Get
    '        Dim ListBillPrint As List(Of clsRPTHowTimeBillPrint) = New List(Of clsRPTHowTimeBillPrint)

    '        Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath
    '        Dim strQuery As String = "Select * From RPTHowTimeBillPrint where RPTHowTimeBillPrint.JobNo=@JobNo"
    '        Using con As OleDbConnection = New OleDbConnection(cs)
    '            Dim dcGetBill As OleDbCommand = New OleDbCommand(strQuery, con)
    '            dcGetBill.Parameters.Add("@JobNo", OleDbType.Char, 255).Value = SearchID

    '            con.Open()
    '            Dim drGetBill As OleDbDataReader = dcGetBill.ExecuteReader
    '            If drGetBill.HasRows = True Then
    '                While drGetBill.Read
    '                    Dim rptBill As clsRPTHowTimeBillPrint = New clsRPTHowTimeBillPrint
    '                    If Not String.IsNullOrEmpty(drGetBill("HTID").ToString) Then
    '                        rptBill.HTID = Convert.ToInt32(drGetBill("HTID").ToString)
    '                    End If
    '                    rptBill.JobNo = drGetBill("JobNo").ToString
    '                    rptBill.BillNo = drGetBill("BillNo").ToString
    '                    ListBillPrint.Add(rptBill)
    '                End While
    '            End If
    '        End Using
    '        Return ListBillPrint
    '    End Get
    'End Property

    'Private Function ISBILLNOEXIST(ByVal CheckID As String) As Boolean
    '    Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath
    '    Dim strQuery As String = "Select * From RPTHowTimeBillPrint where RPTHowTimeBillPrint.JobNo=@JobNo1"
    '    Using con As OleDbConnection = New OleDbConnection(cs)
    '        Dim dcProductList As OleDbCommand = New OleDbCommand(strQuery, con)
    '        dcProductList.CommandType = CommandType.Text 
    '        dcProductList.Parameters.Add("@JobNo1", OleDbType.Char, 255).Value = CheckID
    '        con.Open()
    '        Dim drBillPrint As OleDbDataReader = dcProductList.ExecuteReader
    '        If drBillPrint.HasRows = True Then
    '            Return True
    '        End If
    '    End Using
    '    Return False
    'End Function


    'Private ReadOnly Property GetSingleAdvanceInfo(ByVal strSearchID As String) As clsAdvanceInfo
    '    Get

    '        Dim Advance As clsAdvanceInfo = New clsAdvanceInfo
    '        Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath
    '        Dim strQuery As String = "Select * from AdvanceInfo where AdvanceInfo.JobCode=@JobCode"
    '        Using con As OleDbConnection = New OleDbConnection(cs)
    '            Dim dcGetAdvance As OleDbCommand = New OleDbCommand(strQuery, con)
    '            dcGetAdvance.Parameters.Add("@JobCode", OleDbType.Char, 255).Value = strSearchID
    '            con.Open()

    '            Dim drGetAdvance As OleDbDataReader = dcGetAdvance.ExecuteReader


    '            If drGetAdvance.HasRows = True Then
    '                While drGetAdvance.Read


    '                    'JobCode,Branch,AdvNo,AdvDate,AdvAmnt,AdvRemarks,PayType,BankName,CardNo
    '                    Advance.JobCode = drGetAdvance("JobCode").ToString
    '                    Advance.Branch = drGetAdvance("Branch").ToString
    '                    Advance.AdvNo = drGetAdvance("AdvNo").ToString
    '                    If Not String.IsNullOrEmpty(drGetAdvance("AdvDate")) Then
    '                        Advance.AdvDate = Convert.ToDateTime(drGetAdvance("AdvDate").ToString)
    '                    End If
    '                    If Not String.IsNullOrEmpty(drGetAdvance("AdvAmnt")) Then
    '                        Advance.AdvAmnt = Convert.ToDouble(drGetAdvance("AdvAmnt").ToString)
    '                    End If
    '                    Advance.AdvRemarks = drGetAdvance("AdvRemarks").ToString
    '                    Advance.PayType = drGetAdvance("PayType").ToString
    '                    Advance.BankName = drGetAdvance("BankName").ToString
    '                    Advance.CardNo = drGetAdvance("CardNo").ToString


    '                End While
    '            End If
    '        End Using
    '        Return Advance
    '    End Get
    'End Property




    'Private Function ISEXISTAdvance(ByVal CheckID As String) As Boolean
    '    Dim Advance As clsAdvanceInfo = New clsAdvanceInfo
    '    Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath
    '    Dim strQuery As String = "Select * from AdvanceInfo where AdvanceInfo.JobCode=@JobCode"
    '    Using con As OleDbConnection = New OleDbConnection(cs)
    '        Dim dcGetAdvance As OleDbCommand = New OleDbCommand(strQuery, con)
    '        dcGetAdvance.Parameters.Add("@JobCode", OleDbType.Char, 255).Value = CheckID
    '        con.Open()
    '        Dim drExist As OleDbDataReader = dcGetAdvance.ExecuteReader

    '        If drExist.HasRows = True Then
    '            Return True
    '        End If
    '    End Using

    '    Return False

    'End Function


    'Private ReadOnly Property GetSingleReplace(ByVal SearchID As String) As clsReplace
    '    Get
    '        Dim replace As clsReplace = New clsReplace
    '        Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath
    '        Dim strQuery As String = "Select * from Replace where Replace.JobCode=@JobCode"
    '        Using con As OleDbConnection = New OleDbConnection(cs)
    '            Dim dcProductList As OleDbCommand = New OleDbCommand(strQuery, con)

    '            dcProductList.Parameters.Add("@JobCode", OleDbType.Char, 255).Value = SearchID


    '            con.Open()

    '            Dim drReplace As OleDbDataReader = dcProductList.ExecuteReader

    '            If drReplace.HasRows = True Then
    '                While drReplace.Read

    '                    If Not String.IsNullOrEmpty(drReplace("ClaimID").ToString) Then
    '                        replace.ClaimID = Convert.ToInt32(drReplace("ClaimID").ToString)
    '                    End If
    '                    replace.Brand = drReplace("Brand").ToString
    '                    replace.Model = drReplace("Model").ToString
    '                    replace.ESN = drReplace("ESN").ToString
    '                    replace.ESNb = drReplace("ESNb").ToString
    '                    replace.SLNo = drReplace("SLNo").ToString
    '                    replace.Other = drReplace("Other").ToString
    '                    If Not String.IsNullOrEmpty(drReplace("RDate").ToString) Then
    '                        replace.RDate = Convert.ToDateTime(drReplace("RDate").ToString)
    '                    End If

    '                    replace.ReplaceBy = drReplace("ReplaceBy").ToString

    '                End While
    '            End If
    '        End Using
    '        Return replace
    '    End Get
    'End Property




    'Private ReadOnly Property IsexistReplace(ByVal SearchID As String) As Boolean
    '    Get

    '        Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath
    '        Dim strQuery As String = "Select * from Replace where Replace.JobCode=@JobCode"
    '        Using con As OleDbConnection = New OleDbConnection(cs)
    '            Dim dcProductList As OleDbCommand = New OleDbCommand(strQuery, con)

    '            dcProductList.Parameters.Add("@JobCode", OleDbType.Char, 255).Value = SearchID


    '            con.Open()

    '            Dim drReplace As OleDbDataReader = dcProductList.ExecuteReader

    '            If drReplace.HasRows = True Then
    '                Return True
    '            End If
    '        End Using
    '        Return False
    '    End Get
    'End Property



    'Private ReadOnly Property GetSingleBill(ByVal CheckID As String) As clstbBill
    '    Get
    '        Dim bill As clstbBill = New clstbBill
    '        Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath
    '        Dim strQuery As String = "Select * from  TBBill where tbbill.JobNo=@JobNo"
    '        Using con As OleDbConnection = New OleDbConnection(cs)
    '            Dim dcTbBill As OleDbCommand = New OleDbCommand(strQuery, con)
    '            dcTbBill.Parameters.Add("@JobNo", OleDbType.Char, 255).Value = CheckID
    '            con.Open()
    '            Dim drTbBill As OleDbDataReader = dcTbBill.ExecuteReader
    '            If drTbBill.HasRows = True Then
    '                While drTbBill.Read

    '                    If Not String.IsNullOrEmpty(drTbBill("BillNO").ToString.Trim) Then
    '                        bill.BillNO = Convert.ToInt32(drTbBill("BillNO").ToString)
    '                    End If
    '                    bill.JobNO = drTbBill("JobNO").ToString

    '                End While
    '            End If
    '        End Using
    '        Return bill
    '    End Get
    'End Property



    'Private ReadOnly Property iSExistTBBill(ByVal CheckID As String) As Boolean
    '    Get

    '        Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath
    '        Dim strQuery As String = "Select * from  TBBill where tbbill.JobNo=@JobNo"
    '        Using con As OleDbConnection = New OleDbConnection(cs)
    '            Dim dcTbBill As OleDbCommand = New OleDbCommand(strQuery, con)
    '            dcTbBill.Parameters.Add("@JobNo", OleDbType.Char, 255).Value = CheckID
    '            con.Open()
    '            Dim drTbBill As OleDbDataReader = dcTbBill.ExecuteReader
    '            If drTbBill.HasRows = True Then
    '                Return True
    '            End If
    '        End Using
    '        Return False
    '    End Get
    'End Property

    'Private Function GetCustomerClaim(ByVal JobCode As String) As clsCustomerClaim
    '    Dim CustomerClaim As clsCustomerClaim = New clsCustomerClaim
    '    Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath
    '    Using con As OleDbConnection = New OleDbConnection(cs)
    '        Dim dcLoadClaiminf As OleDbCommand = New OleDbCommand("Select * from CustomerClaim where JobCode=@JobCode", con)
    '        dcLoadClaiminf.Parameters.Add("@JobCode", OleDbType.Char, 255).Value = JobCode
    '        con.Open()
    '        Dim drLoadClaiminfo = dcLoadClaiminf.ExecuteReader
    '        If drLoadClaiminfo.HasRows = True Then
    '            While drLoadClaiminfo.Read
    '                CustomerClaim.Jobcode = drLoadClaiminfo("JobCOde").ToString
    '                CustomerClaim.ClaimCode += drLoadClaiminfo("ClaimCode").ToString & ","
    '            End While
    '            Dim strGetCSO = GetCustomerClaimOthers(CustomerClaim.Jobcode)
    '            If strGetCSO <> "" Then
    '                CustomerClaim.ClaimCode += strGetCSO
    '            End If
    '            If CustomerClaim.ClaimCode.Substring(CustomerClaim.ClaimCode.Length - 1, 1) = "," Then
    '                CustomerClaim.ClaimCode = CustomerClaim.ClaimCode.Substring(0, CustomerClaim.ClaimCode.Length - 1)
    '            End If
    '        End If
    '    End Using
    '    Return CustomerClaim
    'End Function

    'Private Function GetCustomerClaimOthers(ByVal JobCode As String) As String
    '    Dim CustomerClaim As clsCustomerClaim = New clsCustomerClaim
    '    Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath
    '    Using con As OleDbConnection = New OleDbConnection(cs)
    '        Dim dcLoadClaiminf As OleDbCommand = New OleDbCommand("Select * from CustomerClaimOthers where JobCode=@JobCode", con)
    '        dcLoadClaiminf.Parameters.Add("@JobCOde", OleDbType.Char, 255).Value = JobCode
    '        con.Open()
    '        Dim drLoadClaiminfo = dcLoadClaiminf.ExecuteReader
    '        If drLoadClaiminfo.HasRows = True Then
    '            While drLoadClaiminfo.Read
    '                CustomerClaim.Jobcode = drLoadClaiminfo("JobCOde").ToString
    '                CustomerClaim.ClaimCode = drLoadClaiminfo("ClaimCode").ToString & ","
    '            End While
    '        End If
    '    End Using
    '    Return CustomerClaim.ClaimCode
    'End Function

    'Private Function NRDetails(ByVal JobCode As String) As clsNrdetails
    '    Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath
    '    Dim tmpNrDetails As clsNrdetails = New clsNrdetails
    '    Using con As OleDbConnection = New OleDbConnection(cs)
    '        Dim dcGetNR As OleDbCommand = New OleDbCommand("Select * from NRDetails where JobCOde=@JobCOde", con)
    '        dcGetNR.Parameters.Add("@JobCOde", OleDbType.Char, 255).Value = JobCode
    '        con.Open()
    '        Dim drGetNR As OleDbDataReader = dcGetNR.ExecuteReader
    '        If drGetNR.HasRows = True Then

    '            While drGetNR.Read
    '                tmpNrDetails.ClaimID = Convert.ToInt32(drGetNR("ClaimID").ToString)
    '                tmpNrDetails.JobCode = drGetNR("JobCode").ToString
    '                tmpNrDetails.NRCode += drGetNR("NRCode").ToString & ","
    '            End While
    '            Dim strNROthers As String = NRDetailsOthers(tmpNrDetails.JobCode)


    '            If strNROthers <> "" Then
    '                tmpNrDetails.NRCode += strNROthers
    '            End If

    '            If tmpNrDetails.NRCode.Substring(tmpNrDetails.NRCode.Length - 1, 1) = "," Then
    '                tmpNrDetails.NRCode = tmpNrDetails.NRCode.Substring(0, tmpNrDetails.NRCode.Length - 1)
    '            End If

    '        End If

    '    End Using
    '    Return tmpNrDetails
    'End Function

    'Private Function NRDetailsOthers(ByVal JobCode As String) As String
    '    Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath
    '    Dim tmpNrDetails As clsNrdetails = New clsNrdetails
    '    Using con As OleDbConnection = New OleDbConnection(cs)
    '        Dim dcGetNR As OleDbCommand = New OleDbCommand("Select * from NROthers where JobCOde=@JobCOde", con)
    '        dcGetNR.Parameters.Add("@JobCOde", OleDbType.Char, 255).Value = JobCode
    '        con.Open()
    '        Dim drGetNR As OleDbDataReader = dcGetNR.ExecuteReader
    '        If drGetNR.HasRows = True Then

    '            While drGetNR.Read
    '                tmpNrDetails.ClaimID = Convert.ToInt32(drGetNR("ClaimID").ToString)
    '                tmpNrDetails.JobCode = drGetNR("JobCode").ToString
    '                tmpNrDetails.NRCode += drGetNR("NRCode").ToString & ","
    '            End While

    '        End If
    '    End Using
    '    Return tmpNrDetails.NRCode
    'End Function

    'Public Function GetPending(ByVal SearchCriteria As String) As clsPending

    '    Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath
    '    Dim pending As clsPending = New clsPending

    '    Using con As OleDbConnection = New OleDbConnection(cs)
    '        Dim dcGetPending As OleDbCommand = New OleDbCommand("Select * from Pending where JobCode=@JobCode", con)
    '        dcGetPending.Parameters.Add("@JobCode", OleDbType.Char, 255).Value = SearchCriteria

    '        con.Open()
    '        Dim drGetPending As OleDbDataReader = dcGetPending.ExecuteReader
    '        If drGetPending.HasRows = True Then

    '            While drGetPending.Read
    '                pending.ClaimID = Convert.ToInt32(drGetPending("ClaimID").ToString)
    '                pending.JobCode = drGetPending("JobCode").ToString
    '                pending.PenCode += drGetPending("Pencode").ToString & ","
    '            End While
    '        End If


    '        Dim strPendingOthers As clsPending = GetPendingOthers(SearchCriteria)

    '        If Not IsNothing(strPendingOthers.JobCode) Then
    '            pending.JobCode=strPendingOthers.JobCode 
    '            pending.PenCode += strPendingOthers.PenCode
    '        End If

    '        If Not IsNothing(pending.JobCode) Then


    '            If pending.PenCode.Length > 0 Then
    '                If pending.PenCode.Substring(pending.PenCode.Length - 1, 1) = "," Then
    '                    pending.PenCode = pending.PenCode.Substring(0, pending.PenCode.Length - 1)

    '                End If
    '            End If
    '        End If

    '    End Using
    '    Return pending

    'End Function

    'Public Function GetPendingOthers(ByVal SearchCriteria As String) As clsPending

    '    Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath
    '    Dim pending As clsPending = New clsPending

    '    Using con As OleDbConnection = New OleDbConnection(cs)
    '        Dim dcGetPending As OleDbCommand = New OleDbCommand("Select * from PendingOther where JobCode=@JobCode", con)
    '        dcGetPending.Parameters.Add("@JobCode", OleDbType.Char, 255).Value = SearchCriteria
    '        con.Open()
    '        Dim drGetPending As OleDbDataReader = dcGetPending.ExecuteReader
    '        If drGetPending.HasRows = True Then

    '            While drGetPending.Read
    '                pending.ClaimID = Convert.ToInt32(drGetPending("ClaimID").ToString)
    '                pending.JobCode = drGetPending("JobCode").ToString
    '                pending.PenCode += drGetPending("Pencode").ToString & ","
    '            End While
    '        End If
    '    End Using
    '    Return pending

    'End Function

    '' ________________________________________________ Service Details Section _______________________________________________________
    'Public Function partsDetails(ByVal SearchCriteria As String) As clsServiceDetails

    '    Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath
    '    Dim servicedetails As clsServiceDetails = New clsServiceDetails

    '    Using con As OleDbConnection = New OleDbConnection(cs)
    '        Dim dcGetParts As OleDbCommand = New OleDbCommand("Select * from ServiceDetails where JobCode=@JobCode", con)
    '        dcGetParts.CommandType = CommandType.Text
    '        dcGetParts.Parameters.Add("@JobCode", OleDbType.Char, 255).Value = SearchCriteria

    '        con.Open()
    '        Dim drGetParts As OleDbDataReader = dcGetParts.ExecuteReader

    '        If drGetParts.HasRows = True Then



    '            '
    '            While drGetParts.Read

    '                If Not String.IsNullOrEmpty(Trim(drGetParts("Remarks").ToString)) Then
    '                    servicedetails.Jobcode = drGetParts("JobCode").ToString
    '                    servicedetails.Description = "Remarks:" & drGetParts("Remarks").ToString & "|"

    '                Else
    '                    servicedetails.Jobcode = drGetParts("JobCode").ToString
    '                    servicedetails.Description += drGetParts("ProductCode").ToString & "," & getProductName(drGetParts("ProductCode").ToString) & "," & drGetParts("Qty").ToString & "," & drGetParts("UnitPrice").ToString & "|"
    '                End If
    '            End While


    '        End If


    '    End Using
    '    Return servicedetails
    'End Function


    'Public ReadOnly Property GetSingleServiceDetailDetails(ByVal Checkid As String) As IEnumerable(Of clsServiceDetails)
    '    Get
    '        Dim ListServiceDetails As List(Of clsServiceDetails) = New List(Of clsServiceDetails)

    '        Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath

    '        Dim strSqlQuery = "Select * from ServiceDetails where ServiceDetails.JobCode=@JobCode"

    '        Using con As OleDbConnection = New OleDbConnection(cs)
    '            Dim dcServiceDetails As OleDbCommand = New OleDbCommand(strSqlQuery, con)
    '            dcServiceDetails.Parameters.Add("@JobCode", OleDbType.Char, 255).Value = Checkid
    '            con.Open()

    '            Dim drServicedetails As OleDbDataReader = dcServiceDetails.ExecuteReader
    '            If drServicedetails.HasRows = True Then
    '                While drServicedetails.Read
    '                    Dim servicedetails As clsServiceDetails = New clsServiceDetails
    '                    If Not String.IsNullOrEmpty(drServicedetails("Remarks").ToString) Then
    '                        servicedetails.Jobcode = drServicedetails("JobCode").ToString
    '                        servicedetails.Remarks = drServicedetails("Remarks").ToString
    '                    Else
    '                        servicedetails.Jobcode = drServicedetails("JobCode").ToString
    '                        servicedetails.ProductCode = drServicedetails("ProductCode").ToString
    '                        If Not String.IsNullOrEmpty(drServicedetails("Qty").ToString) Then
    '                            servicedetails.Qty = drServicedetails("Qty").ToString
    '                        End If
    '                        If Not String.IsNullOrEmpty(drServicedetails("UnitPrice").ToString) Then
    '                            servicedetails.UnitPrice = drServicedetails("UnitPrice").ToString
    '                        End If
    '                    End If
    '                    ListServiceDetails.Add(servicedetails)
    '                End While
    '            End If
    '        End Using
    '        Return ListServiceDetails

    '    End Get
    'End Property


    'Public ReadOnly Property IsexitServiceDetails(ByVal Checkid As String) As Boolean
    '    Get


    '        Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath

    '        Dim strSqlQuery = "Select * from ServiceDetails where ServiceDetails.JobCode=@JobCode"

    '        Using con As OleDbConnection = New OleDbConnection(cs)
    '            Dim dcServiceDetails As OleDbCommand = New OleDbCommand(strSqlQuery, con)
    '            dcServiceDetails.Parameters.Add("@JobCode", OleDbType.Char, 255).Value = Checkid
    '            con.Open()

    '            Dim drServicedetails As OleDbDataReader = dcServiceDetails.ExecuteReader
    '            If drServicedetails.HasRows = True Then
    '                Return True
    '            End If
    '        End Using
    '        Return False

    '    End Get
    'End Property


    '' ________________________________________________ End Service Details Section _______________________________________________________

    'Private Function EstRefused(ByVal SearchCriteria As String) As clsEstimateRefused
    '    Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath



    '    Dim EstimateRefuse As clsEstimateRefused = New clsEstimateRefused

    '    Using con As OleDbConnection = New OleDbConnection(cs)
    '        Dim dcSaveEr As OleDbCommand = New OleDbCommand("Select * from EstimateRefused where JobCode=@SearchCode", con)
    '        dcSaveEr.CommandType = CommandType.Text
    '        dcSaveEr.Parameters.Add("@SearchCode", OleDbType.Char, 255).Value = SearchCriteria

    '        con.Open()

    '        Dim drSaveEr = dcSaveEr.ExecuteReader



    '        While drSaveEr.Read
    '            With EstimateRefuse
    '                .EstRAID = Convert.ToInt32(drSaveEr("EstRAID").ToString)
    '                .JobCode = drSaveEr("JobCode").ToString
    '                .ServiceBy_ID = drSaveEr("ServiceBy_ID").ToString
    '                If Not String.IsNullOrEmpty(drSaveEr("EstDate").ToString) Then
    '                    .EstDate = Convert.ToDateTime(drSaveEr("EstDate").ToString)
    '                End If

    '                .EstText = drSaveEr("EstText").ToString
    '                If Not String.IsNullOrEmpty(drSaveEr("RefuseAmnt").ToString) Then
    '                    .RefuseAmnt = Convert.ToDouble(drSaveEr("RefuseAmnt").ToString)
    '                End If
    '                .Branch = drSaveEr("Branch").ToString



    '            End With
    '        End While


    '    End Using

    '    Return EstimateRefuse
    'End Function

    'Private Function GetItem(ByVal SearchCriteria As String) As clsServiceItem


    '    Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath
    '    Dim serviceItem As clsServiceItem = New clsServiceItem


    '    Using con = New OleDbConnection(cs)

    '        Dim dcserviceItem = New OleDbCommand("Select * from ServiceItem where JobCode=@JobCode", con)
    '        dcserviceItem.CommandType = CommandType.Text

    '        dcserviceItem.Parameters.Add("@JobCode", OleDbType.Char, 255).Value = SearchCriteria
    '        con.Open()
    '        Dim drServiceItem = dcserviceItem.ExecuteReader
    '        If drServiceItem.HasRows = True Then
    '            While drServiceItem.Read
    '                serviceItem.JobCode = drServiceItem("JobCode").ToString
    '                serviceItem.Item += drServiceItem("Item").ToString & ","
    '            End While

    '            If serviceItem.Item.Substring(serviceItem.Item.Length - 1, 1) = "," Then
    '                serviceItem.Item = serviceItem.Item.Substring(0, serviceItem.Item.Length - 1)
    '            End If
    '        End If



    '    End Using





    '    Return serviceItem

    'End Function

    'Private Function GetTBBill() As List(Of clstbBill)



    '    Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath

    '    Dim lstTbBill As List(Of clstbBill) = New List(Of clstbBill)



    '    Using con = New OleDbConnection(cs)
    '        Dim dcGetTBBill As OleDbCommand = New OleDbCommand("Select * From tbBill inner jon Claiminfo on tbBill.jobno=claiminfo.JobCode")
    '        dcGetTBBill.CommandType = CommandType.Text

    '        'dcGetTBBill.Parameters.Add("JobCode", OleDb.OleDbType.Char, 255).Value = strSearch
    '        con.Open()
    '        Dim drGetTbbill As OleDbDataReader = dcGetTBBill.ExecuteReader


    '        If drGetTbbill.HasRows = True Then
    '            While drGetTbbill.Read()
    '                Dim getclstbBill As clstbBill = New clstbBill
    '                getclstbBill.BillNO = drGetTbbill("BillNO").ToString
    '                getclstbBill.JobNO = drGetTbbill("JobNO").ToString

    '                lstTbBill.Add(getclstbBill)
    '            End While



    '        End If




    '    End Using



    '    Return lstTbBill


    'End Function










    'Private Function getProductName(ByVal Code As String) As String


    '    Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath
    '    Dim strProductName As String = String.Empty


    '    Using con As OleDbConnection = New OleDbConnection(cs)


    '        Dim dcGetProduct As OleDbCommand = New OleDbCommand("Select * from Product where Product.Code=@Code", con)
    '        dcGetProduct.Parameters.Add("@Code", OleDb.OleDbType.Char, 255).Value = Code
    '        con.Open()

    '        Dim drGetProduct As OleDbDataReader = dcGetProduct.ExecuteReader


    '        If drGetProduct.HasRows = True Then
    '            While drGetProduct.Read


    '                strProductName = RemoveCommafromText(drGetProduct("ProdName").ToString)


    '            End While

    '        Else
    '            strProductName = "Product Name is Missing"

    '        End If


    '    End Using



    '    Return strProductName


    'End Function

    'Private Function tmpCashsales() As IEnumerable(Of clsCashsales)


    '    Dim dt As DataTable = New DataTable


    '    Dim ListCashsales As List(Of clsCashsales) = New List(Of clsCashsales)


    '    Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & strPath

    '    Dim strQuery = "Select * from Cashsales"


    '    Using con As OleDbConnection = New OleDbConnection(cs)

    '        Dim dcCashsales As OleDbCommand = New OleDbCommand(strQuery, con)

    '        con.Open()

    '        Dim drcashsales As OleDbDataReader = dcCashsales.ExecuteReader

    '        While drcashsales.Read
    '            Dim cashsale As clsCashsales = New clsCashsales

    '            cashsale.MRNO = drcashsales("MRNO").ToString
    '            cashsale.JobCode = drcashsales("JobCode").ToString
    '            cashsale.Branch = drcashsales("Branch").ToString
    '            cashsale.CustName = drcashsales("CustName").ToString
    '            cashsale.CustAddress1 = drcashsales("CustAddress1").ToString
    '            cashsale.CustAddress2 = drcashsales("CustAddress2").ToString
    '            cashsale.Brand = drcashsales("Brand").ToString
    '            cashsale.ModelNo = drcashsales("ModelNo").ToString
    '            cashsale.ESN = drcashsales("ESN").ToString
    '            cashsale.SLNo = drcashsales("SLNo").ToString

    '            If Not String.IsNullOrEmpty(drcashsales("ReceptDate").ToString) Then
    '                cashsale.ReceptDate = drcashsales("ReceptDate").ToString
    '            End If

    '            cashsale.ReceptBy = drcashsales("ReceptBy").ToString
    '            cashsale.Code = drcashsales("Code").ToString
    '            cashsale.ProdName = drcashsales("ProdName").ToString
    '            If Not String.IsNullOrEmpty(drcashsales("Rate").ToString) Then
    '                cashsale.Rate = Convert.ToDouble(drcashsales("Rate").ToString)
    '            End If

    '            If Not String.IsNullOrEmpty(drcashsales("Qty").ToString) Then
    '                cashsale.Qty = Convert.ToDouble(drcashsales("Qty").ToString)
    '            End If

    '            If Not String.IsNullOrEmpty(drcashsales("Amount").ToString) Then
    '                cashsale.Amount = Convert.ToDouble(drcashsales("Amount").ToString)
    '            End If

    '            If Not String.IsNullOrEmpty(drcashsales("PrdAmt").ToString) Then
    '                cashsale.PrdAmt = Convert.ToDouble(drcashsales("PrdAmt").ToString)
    '            End If
    '            If Not String.IsNullOrEmpty(drcashsales("Dis").ToString) Then
    '                cashsale.Dis = Convert.ToDouble(drcashsales("Dis").ToString)
    '            End If

    '            If Not String.IsNullOrEmpty(drcashsales("NetAmnt").ToString) Then
    '                cashsale.NetAmnt = Convert.ToDouble(drcashsales("NetAmnt").ToString)
    '            End If

    '            cashsale.Log_User = drcashsales("Log_User").ToString
    '            If Not String.IsNullOrEmpty(drcashsales("Log_Date").ToString) Then
    '                cashsale.Log_Date = Convert.ToDateTime(drcashsales("Log_Date").ToString)
    '            End If

    '            If Not String.IsNullOrEmpty(drcashsales("DFlag").ToString) Then
    '                cashsale.DFlag = Convert.ToInt32(drcashsales("DFlag").ToString)
    '            End If
    '            ListCashsales.Add(cashsale)
    '        End While
    '    End Using


    '    Return ListCashsales



    'End Function



    'Private Function RemoveCommafromText(ByVal Remove As String) As String

    '    Dim strReturnValue As String = String.Empty
    '    For Each tmpstr As String In Remove
    '        If tmpstr = "," Then
    '            strReturnValue += "-"
    '        Else
    '            strReturnValue += tmpstr
    '        End If

    '    Next
    '    Return strReturnValue

    'End Function

    'Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
    '    Me.Close()

    'End Sub

#End Region
End Class