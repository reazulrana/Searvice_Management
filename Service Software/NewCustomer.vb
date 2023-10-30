Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.Transactions
Imports Microsoft.VisualBasic
Imports System.Configuration
Imports System.IO
Imports System.Drawing.Printing

Public Class NewCustomer

    ' Dim strProvider As String = "Provider=Microsoft.jet.OLEDB.4.0; Data Source="
    Dim MyConnection As OleDbConnection
    Dim bytWarrCondition As Byte
    Dim blnEmployeeReceivedByCode As Boolean
    Dim blnEmployeeJobAssignCode As Boolean
    Dim strDuplicateJob As String
    Dim strTempCFlag As String
    Dim strTempMRNo As String
    Dim dblServiceCharge As Double = 0 ' Set Service Charge from Database



    Private Sub NewCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load





        '________________________________________________ below code is ok this is completly ok no problem in it you can use it any time  ____________________________________


        Try




            cmbCustGrade.Items.Add("VIP")
            cmbCustGrade.Items.Add("Frequent")
            cmbCustGrade.Items.Add("Top")
            cmbCustGrade.Items.Add("Special")
            cmbCustGrade.Items.Add("Others")
            cmbCustGrade.Text = "Special"
            cmbSalesWarranty.Enabled = False
            dtpReceiveDate.Value = Now.ToShortDateString
            dtpDelDTApprox.Value = Now.AddDays(+5)
            dtpAssignDate.Value = Now.ToShortDateString
            dtpDateofPurchase.Value = Now.ToShortDateString
            optNonWarranty.Checked = True

            'chkOldFrom.Enabled = True
            'If My.Computer.Screen.WorkingArea.Width > 1024 Then
            '    If HasRow() = False Then
            '        Insert(Me.Name, "Old Form", True)
            '    End If

            '    If HasRow() = True Then
            '        If IsActive() = False Then
            '            chkOldFrom.Checked = False
            '            Resolution_Over_1024()

            '        Else
            '            chkOldFrom.Checked = True
            '        End If

            '    End If
            'Else
            '    chkOldFrom.Enabled = False

            'End If

            If shrtFormType = 1 Then ' New Job

                Me.Activate()

                NewJob()
                FieldDefaultValue()
                LoadCategory()
                LoadTechnician()
                LoadBranch()
            ElseIf shrtFormType = 2 Then ' edit Job
                Dim strJobStatus As String = String.Empty

                If publicClaiminfo.cFlag = -1 Then
                    strJobStatus = "Not Repaired"
                ElseIf publicClaiminfo.cFlag = 1 And publicClaiminfo.MRNO.ToLower <> LCase("est refuse") Then

                    strJobStatus = "Repaired"
                ElseIf publicClaiminfo.cFlag = 1 And publicClaiminfo.MRNO.ToLower = LCase("est refuse") Then
                    strJobStatus = "Estimate Refuse"
                ElseIf publicClaiminfo.cFlag = 9 Then
                    strJobStatus = "Pending"
                ElseIf publicClaiminfo.cFlag = 99 Then
                    strJobStatus = "Not Repairable"
                ElseIf publicClaiminfo.cFlag = 100 Then
                    strJobStatus = "Customer Return (Delivered)"
                ElseIf publicClaiminfo.cFlag = 0 And publicClaiminfo.MRNO.ToLower <> LCase("est refuse") Then
                    strJobStatus = "Delivered"
                ElseIf publicClaiminfo.cFlag = 0 And publicClaiminfo.MRNO.ToLower = LCase("est refuse") Then
                    strJobStatus = "Estimate Refuse"
                ElseIf publicClaiminfo.cFlag = 2 And publicClaiminfo.MRNO.ToLower <> LCase("est refuse") Then
                    strJobStatus = "Delivered"
                ElseIf publicClaiminfo.cFlag = 2 And publicClaiminfo.MRNO.ToLower = LCase("est refuse") Then
                    strJobStatus = "Estimate Refuse"

                End If
                Me.Text = "Update Customer [Job : " & publicClaiminfo.Jobcode & ", Status : " & strJobStatus & "]"
                LoadCategory()
                LoadInformation()
                LoadTechnician()
                GetServiceItem()
                GetFaultList()



            End If






        Catch ex As Exception
            MessageBox.Show(ex.StackTrace, ex.Message)


        End Try



    End Sub




    Private Sub LoadTechnician()

        Dim tmpPersonalMethod As clsPersonalMethods = New clsPersonalMethods


        Dim tmpPersonal As List(Of clsPersonal) = tmpPersonalMethod.LoadTechnician().ToList


        cmbReceivedbyCode.Items.Add("---Show List---")
        cmbJobAssigntoCode.Items.Add("---Show List---")
        If tmpPersonal.Count > 0 Then
            For Each getcode As clsPersonal In tmpPersonal

                cmbReceivedbyCode.Items.Add(getcode.EmpCode)
                cmbJobAssigntoCode.Items.Add(getcode.EmpCode)

            Next
        End If

    End Sub

    Private Sub NewCustomer_Resize(sender As Object, e As EventArgs) Handles Me.Resize


        cmdSave.Top = Me.ClientSize.Height - cmdSave.Height
        cmdSaveandPrint.Top = Me.ClientSize.Height - cmdSave.Height
        cmdFind.Top = Me.ClientSize.Height - cmdSave.Height
        cmdService.Top = Me.ClientSize.Height - cmdSave.Height
        cmdBill.Top = Me.ClientSize.Height - cmdSave.Height
        cmdReport.Top = Me.ClientSize.Height - cmdSave.Height
        cmdClose.Top = Me.ClientSize.Height - cmdSave.Height
        cmdCanceljob.Top = Me.ClientSize.Height - cmdSave.Height
        cmdTransferJob.Top = Me.ClientSize.Height - cmdSave.Height


        cmdSave.Left = 25 '(Me.ClientSize.Width - (cmdSave.Width * 9))
        cmdSave.Width = (Me.ClientSize.Width - 50) / 9

        cmdSaveandPrint.Left = cmdSave.Left + cmdSave.Width
        cmdSaveandPrint.Width = (Me.ClientSize.Width - 25) / 9

        cmdFind.Left = cmdSaveandPrint.Left + cmdSaveandPrint.Width
        cmdFind.Width = (Me.ClientSize.Width - 50) / 9

        cmdService.Left = cmdFind.Left + cmdFind.Width
        cmdService.Width = (Me.ClientSize.Width - 50) / 9

        cmdBill.Left = cmdService.Left + cmdService.Width
        cmdBill.Width = (Me.ClientSize.Width - 50) / 9

        cmdReport.Left = cmdBill.Left + cmdBill.Width
        cmdReport.Width = (Me.ClientSize.Width - 50) / 9

        cmdClose.Left = cmdReport.Left + cmdReport.Width
        cmdClose.Width = (Me.ClientSize.Width - 50) / 9

        cmdCanceljob.Left = cmdClose.Left + cmdClose.Width
        cmdCanceljob.Width = (Me.ClientSize.Width - 50) / 9


        cmdTransferJob.Left = cmdCanceljob.Left + cmdCanceljob.Width
        cmdTransferJob.Width = (Me.ClientSize.Width - 50) / 9


        txtOtherFault.Top = Me.ClientSize.Height - (cmdSave.Height + txtOtherFault.Height + 2)
        txtOtherFault.Left = 25
        txtOtherFault.Width = cmdTransferJob.Width + cmdTransferJob.Left - 25
        lblOtherFault.Top = txtOtherFault.Top - (lblOtherFault.Height + 2)
        lblOtherFault.Left = 25

        If My.Computer.Screen.WorkingArea.Width < 1025 Then

            lblFailurDescription.Top = dtpDateofPurchase.Top + dtpDateofPurchase.Height + 10
            lblFailurDescription.Left = 25
            lstFaultList.Top = lblFailurDescription.Top + lblFailurDescription.Height + 5
            lstFaultList.Left = 25
            lstFaultList.Width = cmdTransferJob.Width + cmdTransferJob.Left - 25
            lstFaultList.Height = (Me.ClientSize.Height - (lblFailurDescription.Top + lblFailurDescription.Height + cmdSave.Height + txtOtherFault.Height + lblOtherFault.Height + 15))
        End If

        lstFaultList.Top = picCreateFault.Top + picCreateFault.Height + 5
        lstFaultList.Height = Me.ClientSize.Height - (picCreateFault.Top + picCreateFault.Height + cmdSave.Height + txtOtherFault.Height + lblOtherFault.Height + 10)


        'If My.Computer.Screen.WorkingArea.Width > 1024 Then
        '    Resolution_Over_1024()
        'Else
        '    Resolution_Below_1024()
        'End If

        'If Me.ClientSize.Width < 1025 Then
        '    Resolution_Below_1024()
        '    Me.Refresh()

        'End If



    End Sub




    Private Sub Resolution_Below_1024()

        chkMakeDuplicate.Left = 119
        chkMakeDuplicate.Top = 7

        '__________________________________ Job Information _____________________________________________________

        lblJobAssignto.Left = 20 : lblJobAssignto.Top = 33

        txtJobCode.Left = 78 : txtJobCode.Top = 29 : txtJobCode.Width = 88 : txtJobCode.Height = 20

        lblCustGrade.Left = 173 : lblCustGrade.Top = 33

        cmbCustGrade.Left = 237 : cmbCustGrade.Top = 29 : cmbCustGrade.Width = 109 : cmbCustGrade.Height = 21

        lblCustReference.Left = 346 : lblCustReference.Top = 33

        txtCustReference.Left = 430 : txtCustReference.Top = 29 : txtCustReference.Width = 125 : txtCustReference.Height = 20

        lblBranchName.Left = 556 : lblBranchName.Top = 33

        cmbBranchName.Left = 637 : cmbBranchName.Top = 29 : cmbBranchName.Width = 131 : cmbBranchName.Height = 21

        lblCustomerInformation.Left = 13 : lblCustomerInformation.Top = 52

        '__________________________________ Customer Information _____________________________________________________
        lblName.Left = 26 : lblName.Top = 75

        txtName.Left = 78 : txtName.Top = 71 : txtName.Width = 249 : txtName.Height = 20

        lblAddress.Left = 16 : lblAddress.Top = 96

        txtAddress.Left = 78 : txtAddress.Top = 92 : txtAddress.Width = 305 : txtAddress.Height = 20

        lblContact.Left = 25 : lblContact.Top = 117

        txtPhone.Left = 78 : txtPhone.Top = 113 : txtPhone.Width = 305 : txtPhone.Height = 20

        lblEMail.Left = 37 : lblEMail.Top = 138

        txtEmail.Left = 79 : txtEmail.Top = 134 : txtEmail.Width = 305 : txtEmail.Height = 20

        '__________________________________ Date Information _____________________________________________________

        lblDateInformation.Left = 415 : lblDateInformation.Top = 52

        lblReceivedDate.Left = 409 : lblReceivedDate.Top = 75

        dtpReceiveDate.Left = 494 : dtpReceiveDate.Top = 71 : dtpReceiveDate.Width = 98 : dtpReceiveDate.Height = 20

        lblAssignDate.Left = 600 : lblAssignDate.Top = 75

        dtpAssignDate.Left = 670 : dtpAssignDate.Top = 71 : dtpAssignDate.Width = 95 : dtpAssignDate.Height = 20

        lblDelDTApprox.Left = 406 : lblDelDTApprox.Top = 97

        dtpDelDTApprox.Left = 494 : dtpDelDTApprox.Top = 93 : dtpDelDTApprox.Width = 98 : dtpDelDTApprox.Height = 20

        lblJobAssignto.Left = 594 : lblJobAssignto.Top = 97

        cmbJobAssigntoCode.Left = 670 : cmbJobAssigntoCode.Top = 93 : cmbJobAssigntoCode.Width = 56 : cmbJobAssigntoCode.Height = 21

        lblReceivedby.Left = 424 : lblReceivedby.Top = 124


        cmbReceivedbyCode.Left = 424 : cmbReceivedbyCode.Top = 124 : cmbReceivedbyCode.Width = 98 : cmbReceivedbyCode.Height = 21

        lblReceivedByCode.Width = 102 : lblReceivedByCode.Height = 20
        lblReceivedByCode.Location = New Point(424, 144)

        lblJobAssigntoCode.Width = 102 : lblJobAssigntoCode.Height = 20
        lblJobAssignto.Location = New Point(625, 123)
        '__________________________________ Date Information _____________________________________________________

        lblProductInformation.Left = 13 : lblProductInformation.Top = 155

        lblCategory.Left = 15 : lblCategory.Top = 177
        lblBrand.Left = 29 : lblBrand.Top = 200
        lblModel.Left = 28 : lblModel.Top = 223
        lblSerialIMEI.Left = 4 : lblSerialIMEI.Top = 246
        lblESNNo.Left = 23 : lblESNNo.Top = 268

        cmbCategory.Left = 79 : cmbCategory.Top = 173 : cmbCategory.Width = 141 : cmbCategory.Height = 21
        cmbBrand.Left = 79 : cmbBrand.Top = 196 : cmbBrand.Width = 141 : cmbBrand.Height = 21
        cmbModel.Left = 79 : cmbModel.Top = 219 : cmbModel.Width = 141 : cmbModel.Height = 21
        picNotification.Left = 222 : picNotification.Top = 225

        txtSerialIMEI.Left = 79 : txtSerialIMEI.Top = 242 : txtSerialIMEI.Width = 141 : txtSerialIMEI.Height = 21
        txtESNNo.Left = 79 : txtESNNo.Top = 264 : txtESNNo.Width = 141 : txtESNNo.Height = 21
        '__________________________________ Accessories Information _____________________________________________________
        lblAccessories.Left = 238 : lblAccessories.Top = 155

        lstAccessoriesList.Left = 238 : lstAccessoriesList.Top = 173 : lstAccessoriesList.Width = 350 : lstAccessoriesList.Height = 53

        txtAccessoriesReceived.Left = 238 : txtAccessoriesReceived.Top = 224 : txtAccessoriesReceived.Width = 350 : txtAccessoriesReceived.Height = 20

        lblReturnedItem.Left = 611 : lblReturnedItem.Top = 141

        txtReturnedItem.Left = 610 : txtReturnedItem.Top = 160 : txtReturnedItem.Width = 168 : txtReturnedItem.Height = 43

        lblPhysicalCondition.Left = 611 : lblPhysicalCondition.Top = 206

        txtPhysicalCondition.Left = 610 : txtPhysicalCondition.Top = 225 : txtPhysicalCondition.Width = 168 : txtPhysicalCondition.Height = 64

        ' _____________________________________ Wrranty Information __________________________________________

        lblWarrantyType.Left = 234 : lblWarrantyType.Top = 246
        optSalesWarranty.Left = 362 : optSalesWarranty.Top = 246
        optNonWarranty.Left = 420 : optNonWarranty.Top = 246
        optServiceWarranty.Left = 506 : optServiceWarranty.Top = 246

        lblWarrLevel.Left = 234 : lblWarrLevel.Top = 274
        lblPreviousJob.Left = 234 : lblPreviousJob.Top = 299

        lblDateofPurchase.Left = 418 : lblDateofPurchase.Top = 274
        dtpDateofPurchase.Left = 498 : dtpDateofPurchase.Top = 274

        cmbSalesWarranty.Left = 308 : cmbSalesWarranty.Top = 271 : cmbSalesWarranty.Width = 108 : cmbSalesWarranty.Height = 21
        txtPreviousJob.Left = 308 : txtPreviousJob.Top = 295 : txtPreviousJob.Width = 299 : txtPreviousJob.Height = 20


        lblFailurDescription.Left = 9 : lblFailurDescription.Top = 312


        lstFaultList.Left = 12 : lstFaultList.Top = 330 : lstFaultList.Width = Me.ClientSize.Width - 20 : lstFaultList.Height = (lblOtherFault.Top - (lstFaultList.Top + 5))


        chkREL.Left = txtName.Left + txtName.Width + 5

        chkREL.Top = txtName.Top + ((txtName.Height - chkREL.Height) / 2)














    End Sub


    Private Sub Resolution_Over_1024()

        Dim intSize As Integer = 5


        '_____________________ Customer Information _________________________

        lblCustomerInformation.Top = 65
        chkREL.Left = lblCustomerInformation.Left + lblCustomerInformation.Width + 5

        chkREL.Top = lblCustomerInformation.Top
        lblName.Name = 20
        txtName.Left = lblName.Left + lblName.Width
        lblName.Top = lblCustomerInformation.Top + lblCustomerInformation.Height + 5
        txtName.Width = (Me.ClientSize.Width - (lblName.Width + lblAddress.Width + lblContact.Width + lblEMail.Width)) / 4
        txtName.Top = lblName.Top
        lblAddress.Left = txtName.Left + txtName.Width
        lblAddress.Top = txtName.Top

        txtAddress.Left = lblAddress.Left + lblAddress.Width
        txtAddress.Top = lblAddress.Top
        txtAddress.Width = (Me.ClientSize.Width - (lblName.Width + lblAddress.Width + lblContact.Width + lblEMail.Width)) / 4

        lblContact.Left = txtAddress.Left + txtAddress.Width
        lblContact.Top = txtName.Top

        txtPhone.Left = lblContact.Left + lblContact.Width
        txtPhone.Top = lblContact.Top
        txtPhone.Width = (Me.ClientSize.Width - (lblName.Width + lblAddress.Width + lblContact.Width + lblEMail.Width)) / 4

        lblEMail.Left = txtPhone.Left + txtPhone.Width
        lblEMail.Top = txtPhone.Top

        txtEmail.Left = lblEMail.Left + lblEMail.Width
        txtEmail.Top = lblEMail.Top
        txtEmail.Width = (Me.ClientSize.Width - (lblName.Width + lblAddress.Width + lblContact.Width + lblEMail.Width)) / 4
        '_____________________ Date Information _________________________
        lblDateInformation.Left = lblCustomerInformation.Left
        lblDateInformation.Top = txtName.Top + txtName.Height + 10

        lblReceivedDate.Left = lblDateInformation.Left
        lblReceivedDate.Top = lblDateInformation.Top + lblDateInformation.Height + 10
        dtpReceiveDate.Left = lblReceivedDate.Left + lblReceivedDate.Width
        dtpReceiveDate.Top = lblReceivedDate.Top


        lblDelDTApprox.Left = dtpReceiveDate.Left + dtpReceiveDate.Width
        lblDelDTApprox.Top = dtpReceiveDate.Top
        dtpDelDTApprox.Left = lblDelDTApprox.Left + lblDelDTApprox.Width
        dtpDelDTApprox.Top = lblDelDTApprox.Top
        lblAssignDate.Left = dtpDelDTApprox.Left + dtpDelDTApprox.Width
        lblAssignDate.Top = dtpDelDTApprox.Top
        dtpAssignDate.Left = lblAssignDate.Left + lblAssignDate.Width
        dtpAssignDate.Top = lblAssignDate.Top


        ' __________________ Technician Code  Section __________________________

        lblReceivedby.Left = dtpAssignDate.Left + dtpAssignDate.Width
        lblReceivedby.Top = dtpAssignDate.Top

        cmbReceivedbyCode.Left = lblReceivedby.Left + lblReceivedby.Width
        cmbReceivedbyCode.Top = lblReceivedby.Top
        cmbReceivedbyCode.Width = 150

        lblReceivedByCode.Left = cmbReceivedbyCode.Left + cmbReceivedbyCode.Width
        lblReceivedByCode.Top = cmbReceivedbyCode.Top
        lblReceivedByCode.Width = 200
        lblJobAssignto.Left = lblReceivedByCode.Left + lblReceivedByCode.Width
        lblJobAssignto.Top = lblReceivedByCode.Top

        cmbJobAssigntoCode.Left = lblJobAssignto.Left + lblJobAssignto.Width
        cmbJobAssigntoCode.Top = lblJobAssignto.Top
        cmbJobAssigntoCode.Width = 150

        lblJobAssigntoCode.Left = lblReceivedByCode.Left + lblReceivedByCode.Width + 5
        lblJobAssigntoCode.Top = lblReceivedByCode.Top
        lblJobAssigntoCode.Width = 200




        '_________________________ Product Information Section _______________________________



        lblProductInformation.Top = dtpReceiveDate.Top + dtpReceiveDate.Height + 10
        lblProductInformation.Left = lblCustomerInformation.Left


        lblCategory.Left = lblProductInformation.Left
        lblCategory.Top = lblProductInformation.Top + lblProductInformation.Height + 5

        cmbCategory.Left = lblCategory.Left + lblCategory.Width
        cmbCategory.Width = (Me.ClientSize.Width - (lblCategory.Width + lblBrand.Width + lblModel.Width + lblSerialIMEI.Width + lblESNNo.Width - picNotification.Width)) / 5
        cmbCategory.Top = lblCategory.Top


        lblBrand.Left = cmbCategory.Left + cmbCategory.Width
        lblBrand.Top = cmbCategory.Top

        cmbBrand.Left = lblBrand.Left + lblBrand.Width
        cmbBrand.Width = (Me.ClientSize.Width - (lblCategory.Width + lblBrand.Width + lblModel.Width + lblSerialIMEI.Width + lblESNNo.Width - picNotification.Width)) / 5
        cmbBrand.Top = lblBrand.Top

        lblModel.Left = cmbBrand.Left + cmbBrand.Width
        lblModel.Top = cmbBrand.Top

        cmbModel.Left = lblModel.Left + lblModel.Width
        cmbModel.Width = (Me.ClientSize.Width - (lblCategory.Width + lblBrand.Width + lblModel.Width + lblSerialIMEI.Width + lblESNNo.Width - picNotification.Width)) / 5
        cmbModel.Top = lblModel.Top
        picNotification.Left = cmbModel.Left + cmbModel.Width + 5
        picNotification.Top = cmbModel.Top
        lblSerialIMEI.Left = picNotification.Left + picNotification.Width
        lblSerialIMEI.Top = cmbModel.Top

        txtSerialIMEI.Left = lblSerialIMEI.Left + lblSerialIMEI.Width
        txtSerialIMEI.Width = (Me.ClientSize.Width - (lblCategory.Width + lblBrand.Width + lblModel.Width + lblSerialIMEI.Width + lblESNNo.Width - picNotification.Width)) / 5
        txtSerialIMEI.Top = lblSerialIMEI.Top

        lblESNNo.Left = txtSerialIMEI.Left + txtSerialIMEI.Width
        lblESNNo.Top = txtSerialIMEI.Top

        txtESNNo.Left = lblESNNo.Left + lblESNNo.Width
        txtESNNo.Width = (Me.ClientSize.Width - (lblCategory.Width + lblBrand.Width + lblModel.Width + lblSerialIMEI.Width + lblESNNo.Width - picNotification.Width)) / 5
        txtESNNo.Top = lblESNNo.Top

        ' ______________________ Accessories ____________________________
        lblAccessories.Left = lblCustomerInformation.Left
        lblAccessories.Top = cmbCategory.Top + cmbCategory.Height + 10

        lblReturnedItem.Top = lblAccessories.Top

        lblPhysicalCondition.Top = lblReturnedItem.Top


        lstAccessoriesList.Left = lblAccessories.Left
        lstAccessoriesList.Top = lblAccessories.Top + lblAccessories.Height + 10
        lstAccessoriesList.Width = ((Me.ClientSize.Width - (lstAccessoriesList.Left + 15)) / 3)
        lstAccessoriesList.Height = 50
        txtReturnedItem.Left = lstAccessoriesList.Left + lstAccessoriesList.Width + 5
        txtReturnedItem.Top = lstAccessoriesList.Top
        txtReturnedItem.Width = ((Me.ClientSize.Width - (lstAccessoriesList.Left + 15)) / 3)
        txtReturnedItem.Height = lstAccessoriesList.Height
        lblReturnedItem.Left = txtReturnedItem.Left

        txtPhysicalCondition.Left = txtReturnedItem.Left + txtReturnedItem.Width + 5
        txtPhysicalCondition.Top = txtReturnedItem.Top
        txtPhysicalCondition.Width = ((Me.ClientSize.Width - (lstAccessoriesList.Left + 15)) / 3)
        txtPhysicalCondition.Height = txtReturnedItem.Height
        lblPhysicalCondition.Left = txtPhysicalCondition.Left

        ' _________________________________ Remarks Section  _________________________
        txtAccessoriesReceived.Top = lstAccessoriesList.Top + lstAccessoriesList.Height
        txtAccessoriesReceived.Left = lstAccessoriesList.Left


        ' _________________________________ Warranty Section  _________________________

        lblWarrantyType.Left = txtAccessoriesReceived.Left + txtAccessoriesReceived.Width + intSize
        lblWarrantyType.Top = txtAccessoriesReceived.Top + 5

        optSalesWarranty.Left = lblWarrantyType.Left + lblWarrantyType.Width + intSize
        optSalesWarranty.Top = lblWarrantyType.Top
        lblWarrLevel.Left = optSalesWarranty.Left + optSalesWarranty.Width + intSize
        lblWarrLevel.Top = optSalesWarranty.Top
        cmbSalesWarranty.Left = lblWarrLevel.Left + lblWarrLevel.Width + intSize
        cmbSalesWarranty.Top = lblWarrLevel.Top

        lblDateofPurchase.Left = cmbSalesWarranty.Left + cmbSalesWarranty.Width + intSize
        lblDateofPurchase.Top = cmbSalesWarranty.Top
        dtpDateofPurchase.Left = lblDateofPurchase.Left + lblDateofPurchase.Width + intSize
        dtpDateofPurchase.Top = lblDateofPurchase.Top

        optNonWarranty.Left = dtpDateofPurchase.Left + dtpDateofPurchase.Width + intSize
        optNonWarranty.Top = dtpDateofPurchase.Top

        optServiceWarranty.Left = optNonWarranty.Left + optNonWarranty.Width + intSize
        optServiceWarranty.Top = optNonWarranty.Top
        lblPreviousJob.Left = optServiceWarranty.Left + optServiceWarranty.Width + intSize
        lblPreviousJob.Top = optServiceWarranty.Top

        txtPreviousJob.Left = lblPreviousJob.Left + lblPreviousJob.Width + intSize
        txtPreviousJob.Width = 230
        txtPreviousJob.Top = lblPreviousJob.Top

        ' _________________________________ Fault  Section  _________________________

        lblFailurDescription.Top = txtAccessoriesReceived.Top + txtAccessoriesReceived.Height + intSize
        lblFailurDescription.Left = lblCustomerInformation.Left


        lstFaultList.Top = lblFailurDescription.Top + lblFailurDescription.Height + intSize
        lstFaultList.Height = lblOtherFault.Top - (lblFailurDescription.Top + lblFailurDescription.Height + intSize)
        lstFaultList.Width = Me.ClientSize.Width - 5
        ' _________________________________ Others Fault  Section  _________________________


        txtOtherFault.Top = cmdSave.Top - cmdSave.Height
        txtOtherFault.Left = lstFaultList.Left
        txtOtherFault.Width = lstFaultList.Width
        lblOtherFault.Left = txtOtherFault.Left

    End Sub



    Private Sub LoadBranch()


        Dim clsbranchTemp As clsBranchMethods = New clsBranchMethods
        Dim tmpList As List(Of clsBranch) = clsbranchTemp.GetBranches


        cmbBranchName.DataSource = Nothing
        cmbBranchName.DisplayMember = "Branch"
        cmbBranchName.ValueMember = "Branch"
        cmbBranchName.DataSource = tmpList

        'For Each Branch As clsBranch In tmpList

        '    cmbBranchName.Items.Add(Branch.Branch)


        'Next

        'Dim ComLoadBranch As New OleDbCommand("Select Distinct Branch.Branch from Branch where Branch.Flag=-1", MyCon)

        'Dim ReadLoadBranch As OleDbDataReader


        'Try


        '    ReadLoadBranch = ComLoadBranch.ExecuteReader
        '    cmbBranchName.Items.Clear()

        '    While ReadLoadBranch.Read
        '        cmbBranchName.Items.Add(ReadLoadBranch("branch").ToString)

        '    End While

        '    ReadLoadBranch.Close()
        '    ReadLoadBranch = Nothing
        '    ComLoadBranch = Nothing
        'Catch ex As Exception
        '    MsgBox(ex.Message & vbCrLf & "Event: LoadBranch")
        'End Try



    End Sub



    Private Sub LoadFault(ByVal strTempCategory As String)



        Dim tmpclm As clsClaimlistMethods = New clsClaimlistMethods
        Dim tmpcl As List(Of clsClaimlist) = tmpclm.GetAllClaimList(strTempCategory.ToLower)

        lstFaultList.Items.Clear()

        For Each c As clsClaimlist In tmpcl
            If c.Claim.Length > 1 Then

                lstFaultList.Items.Add(LTrim(RTrim(c.Claim)))
            End If

        Next
        If My.Computer.Screen.WorkingArea.Height <= 600 Then
            For Each i As ListViewItem In lstFaultList.Items
                i.Font = New Font("Times New Roman", 7, FontStyle.Regular)
            Next

        End If

        'Dim comLoadFault As New OleDbCommand("Select Claimlist.Claim from Claimlist where Claimlist.Ctype='" & strTempCategory & "' order by CLaimlist.ClaimCode", MyCon)
        'Dim lstFaultItem As ListViewItem



        'Dim readLoadFault As OleDbDataReader
        'readLoadFault = comLoadFault.ExecuteReader
        'lstFaultList.Items.Clear()


        'While readLoadFault.Read
        '    lstFaultItem = lstFaultList.Items.Add(readLoadFault("Claim").ToString)

        'End While

        'readLoadFault.Close()

        'readLoadFault = Nothing
        'comLoadFault = Nothing


    End Sub



    Private Sub LoadCategory()


        Dim tmpcategorymethods As clscTypeMethods = New clscTypeMethods

        Dim CategoryList As List(Of clscType) = tmpcategorymethods.GetAllCategory


        cmbCategory.Items.Clear()

        For Each tmpcat As clscType In CategoryList
            cmbCategory.Items.Add(tmpcat.CategoryName)
        Next






        'Dim comLoadCategory As New OleDbCommand("Select Ctype.Ctype from Ctype", MyCon)

        'Dim readLoadCategory As OleDbDataReader

        'Try

        '    readLoadCategory = comLoadCategory.ExecuteReader
        '    cmbCategory.Items.Clear()
        '    While readLoadCategory.Read
        '        cmbCategory.Items.Add(readLoadCategory("Ctype").ToString)


        '    End While
        'Catch ex As Exception
        '    MsgBox(ex.Message & vbCrLf & "Event: LoadCategory")
        'End Try






    End Sub

    Private Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged

        If cmbCategory.Text.Length > 0 Then
            LoadFault(cmbCategory.Text)
            LoadAccessoriesItem(cmbCategory.Text)
            LoadBrand(cmbCategory.Text)

        End If



    End Sub



    Private Sub LoadAccessoriesItem(ByVal strTempCategory As String)



        Dim tempAccessories As clstblItemCapMethods = New clstblItemCapMethods
        Dim ListAccessories As List(Of clstblItemCap) = tempAccessories.GetAccessories(strTempCategory)

        lstAccessoriesList.Items.Clear()

        For Each clsAccessoriess As clstblItemCap In ListAccessories

            lstAccessoriesList.Items.Add(clsAccessoriess.cItem)


        Next


        'Dim comLoadAccessoriesItem As New OleDbCommand("Select tblItemCap.Citem from tblItemcap where tblItemCap.Ctype='" & strTempCategory & "'", MyCon)
        'Dim readAccessoriesItem As OleDbDataReader

        'Dim lstItemAccessories As ListViewItem

        'readAccessoriesItem = comLoadAccessoriesItem.ExecuteReader
        'lstAccessoriesList.Items.Clear()

        'While readAccessoriesItem.Read
        '    lstItemAccessories = lstAccessoriesList.Items.Add(readAccessoriesItem("cItem").ToString)

        'End While



        'readAccessoriesItem.Close()
        'readAccessoriesItem = Nothing
        'comLoadAccessoriesItem = Nothing

    End Sub

    Private Sub optNonWarranty_CheckedChanged(sender As Object, e As EventArgs) Handles optNonWarranty.CheckedChanged
        If dtpDateofPurchase.Enabled = True Then
            dtpDateofPurchase.Enabled = False
        End If
        If txtPreviousJob.Enabled = True Then
            txtPreviousJob.Enabled = False
            txtPreviousJob.Text = ""
        End If
    End Sub

    Private Sub LoadBrand(ByVal strTempCategory As String)



        Dim Tempbrandmethods As clsBrandMethods = New clsBrandMethods
        Dim dtListBrand As DataTable = Tempbrandmethods.GetTableFilter(strTempCategory)
        cmbBrand.DataSource = Nothing
        cmbBrand.Items.Clear()

        If dtListBrand.Rows.Count > 0 Then

            cmbBrand.DisplayMember = "Brand"
            cmbBrand.ValueMember = "brdid"
            cmbBrand.DataSource = dtListBrand

        End If

        'For Each tmpBrand In clsListBrand
        '    cmbBrand.Items.Add(tmpBrand.Brand)
        'Next




    End Sub

    Private Function VerifyField(ByRef intBrandID As Integer) As Boolean
        Dim blnFlag As Boolean = False

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Using con As OleDbConnection = New OleDbConnection(cs)

            Dim dc As OleDbCommand = New OleDbCommand("Select Brand.brdID from brand where brand.Ctype=@Ctype and Brand.Brand=@Brand", con)

            dc.Parameters.Add("@Ctype", OleDbType.Char, 255).Value = cmbCategory.Text
            dc.Parameters.Add("@Brand", OleDbType.Char, 255).Value = cmbBrand.Text

            con.Open()

            Dim readLoadBrandID As OleDbDataReader
            readLoadBrandID = dc.ExecuteReader

            If readLoadBrandID.HasRows = True Then
                readLoadBrandID.Read()
                intBrandID = CInt(readLoadBrandID("brdid").ToString)
                blnFlag = True
            Else
                blnFlag = False


            End If

        End Using
        Return blnFlag

    End Function


    Private Sub LoadModel(ByVal IntTempBrandID As Integer)
        Dim comLoadModel As OleDbCommand

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Using con As OleDbConnection = New OleDbConnection(cs)


            comLoadModel = New OleDbCommand("Select BrandModel.Model from BrandModel where BrandModel.brdid=@brdid", con)

            comLoadModel.Parameters.Add("@brdid", OleDbType.Integer).Value = IntTempBrandID

            Dim readLoadModel As OleDbDataReader
            con.Open()
            readLoadModel = comLoadModel.ExecuteReader()
            cmbModel.Items.Clear()
            cmbModel.Text = ""
            While readLoadModel.Read
                cmbModel.Items.Add(readLoadModel("Model").ToString)

            End While

        End Using



    End Sub



    Private Sub cmbBrand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBrand.SelectedIndexChanged

        picNotification.Image = Nothing
        'Try

        If VerifyField(cmbBrand.SelectedValue) = True Then
            LoadModel(cmbBrand.SelectedValue)
        End If

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try


    End Sub







    Private Sub LoadPersonName(ByVal strTempPersonName As String, ByVal intChoose As Integer)
        Dim comLoadPersonName As New OleDbCommand("Select Personal.EmpName from Personal where Personal.EmpCode='" & strTempPersonName & "'", MyCon)

        Dim readLoadPersonName As OleDbDataReader

        readLoadPersonName = comLoadPersonName.ExecuteReader
        If readLoadPersonName.Read = True Then

            If intChoose = 1 Then
                lblReceivedByCode.Text = readLoadPersonName("EmpName").ToString
            ElseIf intChoose = 2 Then
                lblJobAssigntoCode.Text = readLoadPersonName("EmpName").ToString
            End If

        End If


    End Sub

    Private Sub cmbReceivedbyCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbReceivedbyCode.SelectedIndexChanged




        Dim tmpPersonalMethod As clsPersonalMethods = New clsPersonalMethods
        Dim tmpPersonal As List(Of clsPersonal) = tmpPersonalMethod.LoadTechnician(cmbReceivedbyCode.Text).ToList

        If tmpPersonal.Count > 0 Then
            For Each tmpPersonalName As clsPersonal In tmpPersonal
                lblReceivedByCode.Text = tmpPersonalName.EmpName
            Next
        Else
            lblReceivedByCode.Text = String.Empty
        End If


    End Sub

    Private Sub cmbJobAssigntoCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbJobAssigntoCode.SelectedIndexChanged
        Dim tmpPersonalMethod As clsPersonalMethods = New clsPersonalMethods
        Dim tmpPersonal As List(Of clsPersonal) = tmpPersonalMethod.LoadTechnician(cmbJobAssigntoCode.Text).ToList

        If tmpPersonal.Count > 0 Then
            For Each tmpPersonalName As clsPersonal In tmpPersonal
                lblJobAssigntoCode.Text = tmpPersonalName.EmpName
            Next
        Else
            lblReceivedByCode.Text = String.Empty
        End If
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click

        saveNewJob(True)

    End Sub

    Private Sub saveNewJob(ByVal Message As Boolean)


        'If shrtFormType = 1 Then ' New Form
        '    If Not IsNothing(ActiveUser) Then
        '        If ActiveUser.Ins = False Then
        '            MessageBox.Show("The user does not have ''Add Permission''")
        '            Exit Sub
        '        End If
        '    End If
        'ElseIf shrtFormType = 2 Then 'Edit Form
        '    If Not IsNothing(ActiveUser) Then
        '        If ActiveUser.Ins = False Then
        '            MessageBox.Show("The user does not have ''Update Permission''")
        '            Exit Sub
        '        End If
        '    End If
        'End If





        ' ________________________________________________ Claiminfo Section ________________________________________________

        Dim tempClaiminfo As clsClaiminfo = New clsClaiminfo
        Dim TempClaiminfoMethods As clsClaiminfoMethods = New clsClaiminfoMethods
        Dim strMessage As String = String.Empty


        If DataValidation(strMessage) = False Then
            MessageBox.Show(strMessage)
            Exit Sub
        End If



        Dim productMessage As String = String.Empty
        If productValidation(productMessage) = False Then

            If productMessage.ToLower = "Category".ToLower Then
                MessageBox.Show("Category Not found in database")
                cmbCategory.Select()
                Exit Sub
            End If
            If productMessage.ToLower = "Brand".ToLower Then
                MessageBox.Show("Brand Not found in database")
                cmbBrand.Select()
                Exit Sub
            End If


            If productMessage.ToLower = "Model".ToLower Then
                MessageBox.Show("Model Not found in database")
                cmbModel.Select()
                Exit Sub
            End If

        End If




        With tempClaiminfo
            .Jobcode = txtJobCode.Text
            .Branch = cmbBranchName.Text
            .CustName = txtName.Text
            .CustAddress1 = txtAddress.Text
            .CustAddress2 = txtPhone.Text
            .Email = txtEmail.Text
            .ReceptDate = dtpReceiveDate.Value.ToShortDateString
            .AppDelDate = dtpDelDTApprox.Value.ToShortDateString
            .IsssueDate = dtpAssignDate.Value.ToShortDateString
            .ReceptBy = cmbReceivedbyCode.Text
            If Not String.IsNullOrEmpty(cmbJobAssigntoCode.Text) Then
                .IssueTo = cmbJobAssigntoCode.Text
            End If

            .ServiceType = cmbCategory.Text
            .Brand = cmbBrand.Text
            .ModelNo = cmbModel.Text
            .SLNo = txtSerialIMEI.Text
            .ESN = txtESNNo.Text
            .PhyCond = txtPhysicalCondition.Text
            .ReturnedItems = txtReturnedItem.Text
            .ItemRemarks = txtAccessoriesReceived.Text
            If optNonWarranty.Checked = True Then
                .WCondition = 1
            ElseIf optSalesWarranty.Checked = True Then
                .WCondition = 0
                .PDate = dtpDateofPurchase.Value.ToShortDateString
            ElseIf optServiceWarranty.Checked = True Then
                .WCondition = 2
            Else
                MessageBox.Show("Plese Select One of the Warranty Type")
                optSalesWarranty.Select()

            End If
            If shrtFormType = 1 Then '  New Form
                .cFlag = -1
            Else
                If (publicClaiminfo.cFlag = 1 Or publicClaiminfo.cFlag = 9 Or publicClaiminfo.cFlag = 99 Or publicClaiminfo.cFlag = 100 Or publicClaiminfo.cFlag = 101 Or publicClaiminfo.cFlag = 102 Or publicClaiminfo.cFlag = 0 Or publicClaiminfo.cFlag = 2) Then
                    .SDate = publicClaiminfo.SDate
                    .ServiceBy = publicClaiminfo.ServiceBy
                    .MRNO = publicClaiminfo.MRNO
                End If


                If (publicClaiminfo.cFlag = 0 Or publicClaiminfo.cFlag = 2 Or publicClaiminfo.cFlag = 100 Or publicClaiminfo.cFlag = 102) Then
                    .DDate = publicClaiminfo.DDate
                    .DeliverBy = publicClaiminfo.DeliverBy
                    .MRNO = publicClaiminfo.MRNO
                End If

                .cFlag = publicClaiminfo.cFlag


            End If




        End With
        ' ________________________________________________ Falut Section ________________________________________________




        Dim tempcustomerClaim As clsCustomerClaim = New clsCustomerClaim
        Dim tempcustomerclaimmethods As clsCustomerClaimMethods = New clsCustomerClaimMethods
        Dim intloop As Integer = Int32.Parse("0")
        Dim strTempFault As String = String.Empty

        For Each tempFault As ListViewItem In lstFaultList.Items
            If tempFault.Checked = True Then
                strTempFault += tempFault.Text & ","
            End If
        Next

        If txtOtherFault.Text <> "" Then
            strTempFault += txtOtherFault.Text
        End If

        If Not String.IsNullOrEmpty(strTempFault) Then
            If strTempFault.Substring(strTempFault.Length - 1) = "," Then
                strTempFault = strTempFault.Substring(0, strTempFault.Length - 1)
            End If
        End If


        If Not String.IsNullOrEmpty(strTempFault) Then
            tempcustomerClaim.Jobcode = txtJobCode.Text
            tempcustomerClaim.ClaimCode = strTempFault
        Else
            MessageBox.Show("No Fault Selected")
            lstFaultList.Select()

            Exit Sub




        End If






        ' ________________________________________________ Item Section ________________________________________________


        Dim tempServiceItem As clsServiceItem = New clsServiceItem
        Dim tempserviceItemmethods As clsServiceItemMethods = New clsServiceItemMethods
        Dim strItem As String = String.Empty

        For Each TempItem As ListViewItem In lstAccessoriesList.Items

            If TempItem.Checked = True Then
                strItem += TempItem.Text & ","

            End If
        Next

        If Not String.IsNullOrEmpty(strItem) Then
            If strItem.Substring(strItem.Length - 1) = "," Then
                strItem = strItem.Substring(0, strItem.Length - 1)
            End If
        End If



        If Not String.IsNullOrEmpty(strItem) Then
            tempServiceItem.JobCode = txtJobCode.Text
            tempServiceItem.Item = strItem

        End If


        ' ________________________________________________ tbGrade Section ________________________________________________

        Dim temptbGrade As clstbGrade = New clstbGrade
        Dim temptbgrademethods As clstbGradeMethods = New clstbGradeMethods



        temptbGrade.Jobcode = txtJobCode.Text
        temptbGrade.cGrade = cmbCustGrade.Text
        temptbGrade.cRemarks = txtCustReference.Text







        Try

            If shrtFormType = 1 Then '  New Form

                If String.IsNullOrEmpty(cmbReceivedbyCode.Text) Then
                    MessageBox.Show("Select Receive Code")
                    cmbReceivedbyCode.Select()
                    Exit Sub

                End If


                TempClaiminfoMethods.CreateNewJob(tempClaiminfo)
                tempcustomerclaimmethods.Save(tempcustomerClaim)
                temptbgrademethods.save(temptbGrade)

                If Not String.IsNullOrEmpty(tempServiceItem.Item) Then
                    tempserviceItemmethods.SaveItem(tempServiceItem)
                End If
                MessageBox.Show("Record Save Successfully")
                ClearField()
                NewJob()
                txtJobCode.Select()

            ElseIf shrtFormType = 2 Then ' Edit Form 

                If String.IsNullOrEmpty(cmbReceivedbyCode.Text) Then
                    MessageBox.Show("Select Receive Code")
                    cmbReceivedbyCode.Select()
                    Exit Sub

                End If




                If String.IsNullOrEmpty(cmbJobAssigntoCode.Text) Then
                    MessageBox.Show("Select Assign Code")
                    cmbJobAssigntoCode.Select()
                    Exit Sub

                End If


                TempClaiminfoMethods.updateclaiminfo(tempClaiminfo, publicClaiminfo.Jobcode)
                tempcustomerclaimmethods.Update(tempcustomerClaim, publicClaiminfo.Jobcode)
                temptbgrademethods.Update(temptbGrade, publicClaiminfo.Jobcode)

                If Not String.IsNullOrEmpty(tempServiceItem.Item) Then

                    Dim ServiceItemMethods As clsServiceItemMethods = New clsServiceItemMethods
                    Dim srvitem As clsServiceItem = ServiceItemMethods.GetItem(publicClaiminfo.Jobcode) ' Declare for Check Service Item Existence

                    If String.IsNullOrEmpty(srvitem.Item) Then ' Check Service Item Exist or not
                        tempserviceItemmethods.SaveItem(tempServiceItem)  ' Insert new  Service Item if not Exist
                    Else
                        tempserviceItemmethods.UpdateItem(tempServiceItem, publicClaiminfo.Jobcode) 'update Service Item if Exist
                    End If

                ElseIf String.IsNullOrEmpty(tempServiceItem.Item) Then
                    tempserviceItemmethods.DeleteItem(publicClaiminfo.Jobcode) 'Delete Service Item if Exist

                End If
                If Message = True Then
                    MessageBox.Show("Record Update Successfully")
                End If


                Dim claiminfomethods As clsClaiminfoMethods = New clsClaiminfoMethods
                Dim claiminfo = claiminfomethods.LoadClaiminfo_byJobCode(txtJobCode.Text)
                publicClaiminfo = claiminfo




            End If


        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub
    Private Function productValidation(ByRef PMessage) As Boolean
        Dim category As clscTypeMethods = New clscTypeMethods
        Dim Brand As clsBrandMethods = New clsBrandMethods
        Dim Model As clsBrandModelMethods = New clsBrandModelMethods
        productValidation = True

        If category.IsExist(cmbCategory.Text) = False Then
            productValidation = False
            PMessage = "Category"
            Exit Function
        End If

        If Brand.IsExist(cmbCategory.Text, cmbBrand.Text) = False Then
            productValidation = False
            PMessage = "Brand"
            Exit Function
        End If


        If Model.IsExist(cmbModel.Text, cmbBrand.SelectedValue) = False Then
            productValidation = False
            PMessage = "Model"
            Exit Function
        End If






    End Function



    Private Function DataValidation(ByRef strMessage As String) As Boolean

        Dim blnFlag As Boolean

        Dim personalMethods As clsPersonalMethods = New clsPersonalMethods


        If shrtFormType = 2 Then
            If personalMethods.IsExist(cmbJobAssigntoCode.Text) = False Then
                strMessage = "Assign Code is invalid"
                cmbReceivedbyCode.Select()
                blnFlag = False
                Return blnFlag
            End If

        End If



        If String.IsNullOrEmpty(txtJobCode.Text.Trim) Then

            txtJobCode.Select()
            strMessage = "Job Code is Blank"
            blnFlag = False
            Return blnFlag
        End If



        If dtpReceiveDate.Value > dtpAssignDate.Value Then
            strMessage = "Receive Date is Larger than Assign Date" & vbNewLine & vbNewLine
            strMessage += " Receive Date : " & dtpReceiveDate.Value.ToShortDateString & vbNewLine
            strMessage += " Assign Date : " & dtpAssignDate.Value.ToShortDateString
            dtpReceiveDate.Select()
            blnFlag = False
            Return blnFlag


        End If



        If personalMethods.IsExist(cmbReceivedbyCode.Text) = False Then
            strMessage = "Receive Code is invalid"
            cmbReceivedbyCode.Select()
            blnFlag = False
            Return blnFlag
        End If

        Dim CTypeMethods As clscTypeMethods = New clscTypeMethods
        If CTypeMethods.IsExist(cmbCategory.Text) = False Then
            strMessage = "Category is Blank"
            cmbCategory.Select()
            blnFlag = False
            Return blnFlag

        End If
        Dim BrandMethods As clsBrandMethods = New clsBrandMethods
        'If BrandMethods.i Then

        If String.IsNullOrEmpty(cmbBrand.Text.Trim) Then

            cmbBrand.Select()
            strMessage = "Brand is Blank"
            blnFlag = False
            Return blnFlag

        End If


        If String.IsNullOrEmpty(cmbModel.Text.Trim) Then
            cmbModel.Select()
            strMessage = "Model is Blank"
            blnFlag = False
            Return blnFlag
        End If


        If String.IsNullOrEmpty(cmbBranchName.Text.Trim) Then

            cmbBranchName.Select()
            strMessage = "Branch is Blank"
            blnFlag = False
            Return blnFlag
        End If

        If String.IsNullOrEmpty(txtSerialIMEI.Text.Trim) Then

            txtSerialIMEI.Select()
            strMessage = "Serial is Blank"
            blnFlag = False
            Return blnFlag
        End If
        Return True


    End Function

    Private Sub optSalesWarranty_CheckedChanged(sender As Object, e As EventArgs) Handles optSalesWarranty.CheckedChanged
        If dtpDateofPurchase.Enabled = False Then
            dtpDateofPurchase.Enabled = True
        End If
        If cmbSalesWarranty.Enabled = False Then
            dtpDateofPurchase.Select()
        Else
            cmbSalesWarranty.Select()
        End If

        If txtPreviousJob.Enabled = True Then
            txtPreviousJob.Enabled = False
            txtPreviousJob.Text = ""

        End If
    End Sub



    Private Sub FieldDefaultValue()
        Try
            cmbCustGrade.Text = "Special"
            ''cmbBranchName.Text = My.Computer.Registry.CurrentUser.OpenSubKey("Software\Company Software\Service").GetValue("Default_Branch")
        Catch ex As Exception

        End Try




    End Sub

    Private Sub cmbReceivedbyCode_LostFocus(sender As Object, e As EventArgs) Handles cmbReceivedbyCode.LostFocus
        If verifyEmployeeCode(cmbReceivedbyCode.Text) = True Then
            LoadPersonName(cmbReceivedbyCode.Text, 1)
        Else

            lblReceivedByCode.Text = ""

            Exit Sub


        End If
    End Sub

    Private Sub cmbJobAssigntoCode_LostFocus(sender As Object, e As EventArgs) Handles cmbJobAssigntoCode.LostFocus

        If cmbJobAssigntoCode.Text = "" Then
            Exit Sub
        End If


        If verifyEmployeeCode(cmbJobAssigntoCode.Text) = True Then
            LoadPersonName(cmbJobAssigntoCode.Text, 2)
        Else

            lblJobAssigntoCode.Text = ""

        End If
    End Sub


    Private Function verifyEmployeeCode(ByVal strEmployeeCode As String) As Boolean

        Dim comVerifyEmployeeCode As New OleDbCommand("Select * from Personal where Personal.empCode='" & strEmployeeCode & "'", MyCon)

        Dim readVerifyEmployeeCode As OleDbDataReader

        readVerifyEmployeeCode = comVerifyEmployeeCode.ExecuteReader

        If readVerifyEmployeeCode.Read = True Then
            Return True
        Else
            Return False


        End If

    End Function



    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click




        Me.Dispose()



    End Sub


    Private Sub ClearField()

        txtJobCode.Text = ""
        cmbCustGrade.Text = "Special"
        txtCustReference.Text = ""
        txtName.Text = ""

        If chkREL.Checked = True Then
            chkREL.Checked = False

        End If
        txtAddress.Text = ""
        txtPhone.Text = ""


        dtpReceiveDate.Value = Date.Now
        dtpDelDTApprox.Value = (Date.Now)
        'dtpDelDTApprox.Value = dtpDelDTApprox.Value + 5
        dtpAssignDate.Value = Date.Now
        dtpDateofPurchase.Value = Date.Now

        cmbReceivedbyCode.Text = ""
        lblReceivedByCode.Text = ""
        cmbJobAssigntoCode.Text = ""
        txtSerialIMEI.Text = ""
        txtESNNo.Text = ""
        optNonWarranty.Checked = True
        txtAccessoriesReceived.Text = ""
        txtPhysicalCondition.Text = "Body Scratch"
        txtOtherFault.Text = ""
        lstAccessoriesList.Items.Clear()
        lstFaultList.Items.Clear()
        'cmbBranchName.Text = ""
        cmbBrand.Text = ""
        cmbModel.Text = ""
        txtEmail.Text = String.Empty
        cmbCategory.Text = String.Empty







    End Sub


    Private Sub NewJob()


        'Dim comNewJob As New OleDbCommand("SELECT  max(val(IIf(InStr(1,[claiminfo].[jobcode],'/'),Left([claiminfo].[JobCode],InStr(1,[Claiminfo].[JobCode],'/')-1),val(claiminfo.JobCOde))))+1 AS NewJobCode FROM claiminfo WHERE Right([claiminfo].[JobCode],4)<>'/OLD'", MyCon)
        Dim comNewJob As New OleDbCommand("SELECT  max(val(claiminfo.JobCOde))+1 AS NewJobCode FROM claiminfo WHERE Right([claiminfo].[JobCode],4)<>'/OLD'", MyCon)
        Dim readNewJob As OleDbDataReader


        Try


            readNewJob = comNewJob.ExecuteReader

            'If readNewJob.Read = True Then

            If readNewJob.HasRows = True Then


                While readNewJob.Read


                    txtJobCode.Text = Convert.ToString(readNewJob("NewJobCode").ToString)
                    If txtJobCode.Text = "1" Or txtJobCode.Text = "" Then
                        txtJobCode.Text = 1
                    Else


                        If CInt(txtJobCode.Text) < 9 Then
                            txtJobCode.Text = Convert.ToInt32(txtJobCode.Text)
                        ElseIf CInt(txtJobCode.Text) > 10 And CInt(txtJobCode.Text) < 100 Then
                            txtJobCode.Text = Convert.ToInt32(txtJobCode.Text)
                        Else
                            txtJobCode.Text = Convert.ToInt32(txtJobCode.Text)
                        End If
                    End If
                End While
            End If
            'End If
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & "Event: NewJob")
            txtJobCode.Select()

        End Try


    End Sub

    Private Sub chkMakeDuplicate_CheckedChanged(sender As Object, e As EventArgs) Handles chkMakeDuplicate.CheckedChanged

        Dim strJobCode = String.Empty
        strJobCode = txtJobCode.Text



        If chkMakeDuplicate.Checked = True Then

            If String.IsNullOrEmpty(strJobCode) Then
                MessageBox.Show("Job Code is Blank")
                chkMakeDuplicate.Checked = False
                txtJobCode.Select()
                Exit Sub
            End If
            If cmbBranchName.Text = "MIRPUR-01" Then
                strDuplicateJob = "/Mir-01"
            ElseIf cmbBranchName.Text = "MIRPUR-10" Then
                strDuplicateJob = "/Mir-10"
            Else
                strDuplicateJob = cmbBranchName.Text
                strDuplicateJob = "/" & strDuplicateJob.Substring(0, 5)
                strJobCode += strDuplicateJob

            End If
        Else
            If String.IsNullOrEmpty(strJobCode) Then
                Exit Sub
            End If

            If cmbBranchName.Text = "MIRPUR-01" Then
                strJobCode = strJobCode.Substring(0, strJobCode.Length - 7)
            ElseIf cmbBranchName.Text = "MIRPUR-10" Then
                strJobCode = strJobCode.Substring(0, strJobCode.Length - 7)
            Else
                strJobCode = strJobCode.Substring(0, strJobCode.Length - 6)
            End If


        End If

        txtJobCode.Text = strJobCode
    End Sub

    'Private Sub ShowPreviousJob(Optional strtmpPreviousJob As String = "")

    '    Dim strPreviousJob As String = ""

    '    If strtmpPreviousJob = "" Then
    '        strPreviousJob = "Select Claiminfo.JobCode from Claiminfo where Claiminfo.Servicetype='" & cmbCategory.Text & "' and Claiminfo.Brand='" & cmbBrand.Text & "' and claiminfo.Modelno='" & cmbModel.Text & "' and slNo='" & txtSerialIMEI.Text & "'"


    '    Else
    '        strPreviousJob = "Select Claiminfo.JobCode from Claiminfo where Claiminfo.JobCode<>'" & strtmpJobCode & "' and Claiminfo.Servicetype='" & cmbCategory.Text & "' and Claiminfo.Brand='" & cmbBrand.Text & "' and claiminfo.Modelno='" & cmbModel.Text & "' and slNo='" & txtSerialIMEI.Text & "'"
    '    End If

    '    Dim comShowPreviousJob As New OleDbCommand(strPreviousJob, MyCon)



    '    Dim readShowPreviosJob As OleDbDataReader
    '    readShowPreviosJob = comShowPreviousJob.ExecuteReader


    '    Dim strCheckComma As String




    '    While readShowPreviosJob.Read
    '        txtPreviousJob.Text = txtPreviousJob.Text & readShowPreviosJob("JobCode").ToString & ","
    '    End While

    '    strCheckComma = txtPreviousJob.Text
    '    If strCheckComma <> "" Then
    '        If strCheckComma.Substring(strCheckComma.Length - 1) = "," Then
    '            strCheckComma = strCheckComma.Substring(0, strCheckComma.Length - 1)
    '            txtPreviousJob.Text = strCheckComma


    '        End If
    '    End If

    'End Sub

    Private Sub optServiceWarranty_Click(sender As Object, e As EventArgs) Handles optServiceWarranty.Click
        tmpPreviosJob()

    End Sub



    Private Sub txtSerialIMEI_LostFocus(sender As Object, e As EventArgs) Handles txtSerialIMEI.LostFocus
        If optServiceWarranty.Checked = True Then
            ShowPreviousJob()
        End If
    End Sub



    Private Sub txtJobCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtJobCode.KeyDown

        If e.KeyCode = Keys.Enter Then

            cmbCustGrade.Select()

        End If
    End Sub



    Private Sub cmbCustGrade_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbCustGrade.KeyDown

        If e.KeyCode = Keys.Enter Then

            txtCustReference.Select()


        End If
    End Sub

    Private Sub txtCustReference_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCustReference.KeyDown
        If e.KeyCode = 13 Then
            If cmbBranchName.Enabled = True Then
                cmbBranchName.Select()
            Else
                txtName.Select()
            End If
        End If
    End Sub


    Private Sub cmbBranchName_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbBranchName.KeyDown
        If e.KeyCode = Keys.Enter Then

            txtName.Select()

        End If

    End Sub


    Private Sub txtName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtName.KeyDown
        If e.KeyCode = Keys.Enter Then

            chkREL.Select()



        End If

    End Sub


    Private Sub chkREL_KeyDown(sender As Object, e As KeyEventArgs) Handles chkREL.KeyDown
        If e.KeyCode = 13 Then

            txtAddress.Select()




        End If
    End Sub


    Private Sub txtAddress_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAddress.KeyDown
        If e.KeyCode = 13 Then

            txtPhone.Select()




        End If
    End Sub



    Private Sub txtPhone_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPhone.KeyDown
        If e.KeyCode = 13 Then

            txtEmail.Select()

        End If
    End Sub



    Private Sub dtpReceiveDate_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpReceiveDate.KeyDown
        If e.KeyCode = 13 Then

            dtpDelDTApprox.Select()

        End If
    End Sub


    Private Sub dtpDelDTApprox_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpDelDTApprox.KeyDown
        If e.KeyCode = 13 Then

            cmbReceivedbyCode.Select()


        End If
    End Sub

    Private Sub cmbReceivedbyCode_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbReceivedbyCode.KeyDown
        If e.KeyCode = 13 Then

            dtpAssignDate.Select()

        End If
    End Sub

    Private Sub cmbJobAssigntoCode_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbJobAssigntoCode.KeyDown
        If e.KeyCode = 13 Then

            cmbCategory.Select()


        End If
    End Sub

    Private Sub cmbCategory_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbCategory.KeyDown
        If e.KeyCode = 13 Then

            cmbBrand.Select()


        End If
    End Sub

    Private Sub cmbBrand_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbBrand.KeyDown
        If e.KeyCode = 13 Then

            cmbModel.Select()

        End If
    End Sub


    Private Sub cmbModel_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbModel.KeyDown
        If e.KeyCode = 13 Then

            txtSerialIMEI.Select()

        End If
    End Sub



    Private Sub txtSerialIMEI_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSerialIMEI.KeyDown
        If e.KeyCode = 13 Then
            txtESNNo.Select()
        End If
    End Sub



    Private Sub txtESNNo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtESNNo.KeyDown
        If e.KeyCode = 13 Then

            txtAccessoriesReceived.Select()


        End If
    End Sub



    Private Sub txtAccessoriesReceived_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAccessoriesReceived.KeyDown
        If e.KeyCode = 13 Then

            txtReturnedItem.Select()


        End If
    End Sub



    Private Sub txtReturnedItem_KeyDown(sender As Object, e As KeyEventArgs) Handles txtReturnedItem.KeyDown
        If e.KeyCode = 13 Then

            txtPhysicalCondition.Select()



        End If
    End Sub


    Private Sub txtPhysicalCondition_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPhysicalCondition.KeyDown
        If e.KeyCode = 13 Then

            optSalesWarranty.Select()
            optSalesWarranty.Checked = True

        End If
    End Sub

    Private Sub optSalesWarranty_KeyDown(sender As Object, e As KeyEventArgs) Handles optSalesWarranty.KeyDown
        If e.KeyCode = 13 Then

            optNonWarranty.Select()
            optNonWarranty.Checked = True

        End If
    End Sub

    Private Sub optNonWarranty_KeyDown(sender As Object, e As KeyEventArgs) Handles optNonWarranty.KeyDown
        If e.KeyCode = 13 Then

            optServiceWarranty.Select()
            optServiceWarranty.Checked = True

        End If
    End Sub


    Private Sub optServiceWarranty_KeyDown(sender As Object, e As KeyEventArgs) Handles optServiceWarranty.KeyDown
        If e.KeyCode = 13 Then

            txtPreviousJob.Select()


        End If
    End Sub



    Private Sub txtPreviousJob_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPreviousJob.KeyDown
        If e.KeyCode = 13 Then

            lstFaultList.Select()


        End If
    End Sub



    Private Sub lstFaultList_KeyDown(sender As Object, e As KeyEventArgs) Handles lstFaultList.KeyDown
        If e.KeyCode = 13 Then

            txtOtherFault.Select()


        End If
    End Sub



    Private Sub txtOtherFault_KeyDown(sender As Object, e As KeyEventArgs) Handles txtOtherFault.KeyDown
        If e.KeyCode = 13 Then

            cmdSave.Select()


        End If
    End Sub



    Private Sub dtpAssignDate_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpAssignDate.KeyDown
        If e.KeyCode = 13 Then

            cmbJobAssigntoCode.Select()

        End If
    End Sub








    Private Sub LoadInformation()



        Dim personalmethods As clsPersonalMethods = New clsPersonalMethods
        Dim Allemployee As List(Of clsPersonal) = personalmethods.LoadTechnician.ToList


        Dim ReceiveName As clsPersonal = New clsPersonal


        Dim IssueName As clsPersonal = New clsPersonal

        For Each tmpersonalclass In Allemployee

            If publicClaiminfo.ReceptBy.ToString = tmpersonalclass.EmpCode.ToString Then
                ReceiveName = tmpersonalclass

            End If

            If Not String.IsNullOrEmpty(publicClaiminfo.IssueTo.ToString) Then
                If publicClaiminfo.IssueTo.ToString = tmpersonalclass.EmpCode.ToString Then
                    IssueName = tmpersonalclass

                End If


            End If
        Next






        With publicClaiminfo
            txtJobCode.Text = .Jobcode.ToString
            cmbBranchName.Text = .Branch.ToString
            txtName.Text = .CustName.ToString
            txtAddress.Text = .CustAddress1.ToString
            txtPhone.Text = .CustAddress2.ToString
            txtEmail.Text = .Email.ToString
            dtpReceiveDate.Value = .ReceptDate.ToShortDateString
            dtpDelDTApprox.Value = .AppDelDate.ToShortDateString
            cmbReceivedbyCode.Text = .ReceptBy.ToString

            lblReceivedByCode.Text = ReceiveName.EmpName
            If Not String.IsNullOrEmpty(.IssueTo) Then
                cmbJobAssigntoCode.Text = .IssueTo.ToString
                lblJobAssigntoCode.Text = IssueName.EmpName

            End If
            cmbCategory.Text = .ServiceType.ToString
            cmbBrand.Text = .Brand.ToString
            cmbModel.Text = .ModelNo.ToString
            txtSerialIMEI.Text = .SLNo.ToString
            txtESNNo.Text = .ESN.ToString
            txtAccessoriesReceived.Text = .ItemRemarks.ToString
            txtReturnedItem.Text = .ReturnedItems.ToString
            txtPhysicalCondition.Text = .PhyCond.ToString
            If .WCondition = 0 Then
                optSalesWarranty.Checked = True
                dtpDateofPurchase.Value = .PDate.ToLongDateString

            ElseIf .WCondition = 1 Then
                optNonWarranty.Checked = True

            Else
                optServiceWarranty.Checked = True


            End If

        End With



        ' ____________________________________________ Load TBGrade _____________________________________________________



        Dim CGradeMethods As clstbGradeMethods = New clstbGradeMethods


        Dim CGrade As clstbGrade = CGradeMethods.GetCustomerGrade(publicClaiminfo.Jobcode)


        cmbCustGrade.Text = CGrade.cGrade
        txtCustReference.Text = CGrade.cRemarks









    End Sub


    Private Sub tmpPreviosJob()
        If dtpDateofPurchase.Enabled = True Then
            dtpDateofPurchase.Enabled = False
        End If

        If txtPreviousJob.Enabled = False Then

            txtPreviousJob.Enabled = True


        End If

        If txtSerialIMEI.Text = "" Then
            MsgBox("Serial no is blank please fill the serial no", vbCritical, "Serial Blank")
            txtPreviousJob.Select()

        Else
            Dim strtmpPreviousJob As String = ""

            If shrtFormType = 1 Then
                ShowPreviousJob("", cmbCategory.Text, cmbBrand.Text, cmbModel.Text, txtSerialIMEI.Text, strtmpPreviousJob)
            Else
                ShowPreviousJob(strtmpJobCode, cmbCategory.Text, cmbBrand.Text, cmbModel.Text, txtSerialIMEI.Text, strtmpPreviousJob)
            End If
            txtPreviousJob.Text = strtmpPreviousJob

        End If
    End Sub


    Private Sub GetServiceItem()

        Dim serviceitemmethode = New clsServiceItemMethods

        Dim serviceitem As clsServiceItem = serviceitemmethode.GetItem(publicClaiminfo.Jobcode)

        If Not String.IsNullOrEmpty(serviceitem.Item) Then




            Dim intloop As Integer = 0
            Dim strary() As String

            strary = serviceitem.Item.Split(",")



            For intloop = 0 To UBound(strary)
                For Each svitem As ListViewItem In lstAccessoriesList.Items
                    If svitem.Text.ToLower = strary(intloop).ToLower Then
                        svitem.Checked = True
                        Exit For
                    End If

                Next

            Next

        End If

        'Dim comServiceItem As New OleDbCommand("Select Item from ServiceItem where ServiceItem.JobCOde='" & strSvItemJobCode & "'", MyCon)

        'Dim DRServiceItem As OleDbDataReader


        'DRServiceItem = comServiceItem.ExecuteReader

        'Dim strServiceItem() As String


        'Dim intLoop As Integer = 0
        'Dim IntLoopItem As Integer = 0


        'If DRServiceItem.HasRows = True Then
        '    While DRServiceItem.Read
        '        strServiceItem = Split(DRServiceItem("Item").ToString, ":")
        '    End While

        '    For intLoop = 0 To UBound(strServiceItem) - 1
        '        For IntLoopItem = 0 To lstAccessoriesList.Items.Count - 1

        '            If strServiceItem(intLoop).ToString = lstAccessoriesList.Items(IntLoopItem).Text Then
        '                lstAccessoriesList.Items(IntLoopItem).Checked = True
        '                Exit For

        '            End If
        '        Next

        '    Next
        'End If



        'Try
        '    If readServiceItem.HasRows = True Then
        '        While readServiceItem.Read
        '            Dim shrtLoop As Short

        '            For shrtLoop = 0 To lstAccessoriesList.Items.Count - 1
        '                If readServiceItem("Item").ToString = lstAccessoriesList.Items(shrtLoop).Text Then
        '                    lstAccessoriesList.Items(shrtLoop).Checked = True
        '                    Exit For
        '                End If

        '            Next

        '        End While

        '    End If

        'Catch ex As Exception

        '    MsgBox(ex.Message, vbCritical, Err.Number)
        'End Try




    End Sub


    Private Sub GetFaultList()



        Dim CustClaimmethod As clsCustomerClaimMethods = New clsCustomerClaimMethods

        Dim CustClaim As clsCustomerClaim = CustClaimmethod.GetCustomerClaim(publicClaiminfo.Jobcode)

        If Not String.IsNullOrEmpty(CustClaim.ClaimCode) Then
            Dim strFaultAry() As String
            Dim blnFlag As Boolean
            strFaultAry = CustClaim.ClaimCode.Split(",")





            For Each s As String In strFaultAry


                blnFlag = True
                For Each faultitem As ListViewItem In lstFaultList.Items


                    If faultitem.Text.ToLower = LTrim(RTrim(s.ToLower)) Then

                        faultitem.Checked = True
                        blnFlag = False
                        Exit For
                    End If

                Next
                If blnFlag = True Then
                    txtOtherFault.Text += " " & s
                End If
            Next






        End If




        'Dim strFaultArry() As String
        'Dim dcFaultList As New OleDbCommand("Select CustomerClaim.ClaimCode from CustomerClaim where CustomerClaim.JobCode='" & strFLJobCode & "'", MyCon)

        'Dim drFaultList As OleDbDataReader
        'Dim intLoop As Integer = 0
        'Dim intLoopItem As Integer
        'drFaultList = dcFaultList.ExecuteReader

        'If drFaultList.HasRows = True Then
        '    While drFaultList.Read
        '        strFaultArry = Split(drFaultList("ClaimCode").ToString, ":")
        '    End While

        '    For intLoop = 0 To UBound(strFaultArry) - 1
        '        Dim blnFlag As Boolean
        '        blnFlag = False

        '        For intLoopItem = 0 To lstFaultList.Items.Count - 1
        '            If strFaultArry(intLoop).ToString = lstFaultList.Items(intLoopItem).Text Then
        '                lstFaultList.Items(intLoopItem).Checked = True
        '                blnFlag = True
        '                Exit For

        '            End If
        '        Next
        '        If blnFlag = False Then
        '            txtOtherFault.Text += strFaultArry(intLoop).ToString
        '        End If
        '    Next

        'End If








        'If drFaultList.HasRows = True Then
        '    Dim shrtLoop As Short
        '    While drFaultList.Read
        '        For shrtLoop = 0 To lstFaultList.Items.Count - 1
        '            If UCase(drFaultList("ClaimCode").ToString) = lstFaultList.Items(shrtLoop).Text Then
        '                lstFaultList.Items(shrtLoop).Checked = True
        '                Exit For

        '            End If
        '        Next

        '    End While

        'End If


        'Dim dcFaultistOthers As New OleDbCommand("Select CustomerClaimOthers.ClaimCode from CustomerClaimOthers where CustomerClaimOthers.JobCode='" & strFLJobCode & "'", MyCon)

        'Dim drFaultListOthers As OleDbDataReader
        'drFaultListOthers = dcFaultistOthers.ExecuteReader

        'If drFaultListOthers.HasRows = True Then
        '    While drFaultListOthers.Read
        '        txtOtherFault.Text = "" & drFaultListOthers("ClaimCode").ToString
        '    End While






        'End If



    End Sub



    Private Sub NewRecord()

        Dim strNewJobInsertField As String = ""

        Dim strNewJobFieldValue As String = ""



        Dim ConSaveCustomerInformation As New OleDbConnection(strProvider)

        ConSaveCustomerInformation.Open()
        Dim TempClaiminfoTrans As OleDbTransaction = Nothing

        TempClaiminfoTrans = ConSaveCustomerInformation.BeginTransaction



        If cmbBranchName.Text = String.Empty Then
            MsgBox("please set the branch")
            Exit Sub

        End If


        If lblReceivedByCode.Text = "Missing Name" Or lblReceivedByCode.Text = "" Then
            MsgBox("Employee Code is invalid", vbInformation)
            cmbReceivedbyCode.Select()
            Exit Sub

        End If

        If dtpAssignDate.Value < dtpReceiveDate.Value Then
            MsgBox("'Receive Date' is Larger than 'Assign Date'", vbInformation, "Date Confilction")
            Exit Sub

        End If




        Dim strFaultValue As String = String.Empty


        Dim intLoopFault As Integer = 0


        For intLoopFault = 0 To lstFaultList.Items.Count - 1

            If lstFaultList.Items(intLoopFault).Checked = True Then
                strFaultValue = strFaultValue & lstFaultList.Items(intLoopFault).Text & ","
            End If
        Next


        If txtOtherFault.Text <> String.Empty Then
            strFaultValue = strFaultValue & txtOtherFault.Text & ","
        End If


        If Not String.IsNullOrEmpty(strFaultValue) Then

            If strFaultValue.Length > 2 Then
                If strFaultValue.Substring(strFaultValue.Length, 1) = "," Then
                    strFaultValue = strFaultValue.Substring(0, strFaultValue.Length - 1)
                End If
            End If
        Else
            MessageBox.Show("Select Atleast One Fault")
            Exit Sub
        End If




        If cmbJobAssigntoCode.Text <> "" Then
            If lblJobAssigntoCode.Text = "Missing Name" Then
                MsgBox("Employee Code is invalid", vbInformation)
                cmbJobAssigntoCode.Select()
                Exit Sub
            Else
                If optSalesWarranty.Checked = True Then
                    strNewJobInsertField = "JobCode,Branch,CustName,CustAddress1,CustAddress2,ReceptDate,AppDelDate,ReceptBy,ServiceType,Brand,ModelNo,SLNo,ESN,WCondition,ItemRemarks,ReturnedItems,PhyCond,Cflag,IsssueDate,IssueTo,Pdate"
                Else

                    strNewJobInsertField = "JobCode,Branch,CustName,CustAddress1,CustAddress2,ReceptDate,AppDelDate,ReceptBy,ServiceType,Brand,ModelNo,SLNo,ESN,WCondition,ItemRemarks,ReturnedItems,PhyCond,Cflag,IsssueDate,IssueTo,Email"
                End If

                If optSalesWarranty.Checked = True Then
                    strNewJobFieldValue = "'" & txtJobCode.Text & "','" & cmbBranchName.Text & "','" & txtName.Text & "','" & txtAddress.Text & "','" & txtPhone.Text & "',#" & dtpReceiveDate.Value.ToShortDateString & "#,#" & dtpDelDTApprox.Value.ToShortDateString & "#,'" & cmbReceivedbyCode.Text & "','" & cmbCategory.Text & "','" & cmbBrand.Text & "','" & cmbModel.Text & "','" & txtSerialIMEI.Text & "','" & txtESNNo.Text & "',0,'" & txtAccessoriesReceived.Text & "','" & txtReturnedItem.Text & "','" & txtPhysicalCondition.Text & "',-1,#" & dtpAssignDate.Value.ToShortDateString & "#'" & cmbJobAssigntoCode.Text & "',#" & dtpDateofPurchase.Value.ToShortDateString & "#"
                ElseIf optNonWarranty.Checked = True Then
                    strNewJobFieldValue = "'" & txtJobCode.Text & "','" & cmbBranchName.Text & "','" & txtName.Text & "','" & txtAddress.Text & "','" & txtPhone.Text & "',#" & dtpReceiveDate.Value.ToShortDateString & "#,#" & dtpDelDTApprox.Value.ToShortDateString & "#,'" & cmbReceivedbyCode.Text & "','" & cmbCategory.Text & "','" & cmbBrand.Text & "','" & cmbModel.Text & "','" & txtSerialIMEI.Text & "','" & txtESNNo.Text & "',0,'" & txtAccessoriesReceived.Text & "','" & txtReturnedItem.Text & "','" & txtPhysicalCondition.Text & "',1,#" & dtpAssignDate.Value.ToShortDateString & "#'" & cmbJobAssigntoCode.Text & "'"
                ElseIf optServiceWarranty.Checked = True Then
                    strNewJobFieldValue = "'" & txtJobCode.Text & "','" & cmbBranchName.Text & "','" & txtName.Text & "','" & txtAddress.Text & "','" & txtPhone.Text & "',#" & dtpReceiveDate.Value.ToShortDateString & "#,#" & dtpDelDTApprox.Value.ToShortDateString & "#,'" & cmbReceivedbyCode.Text & "','" & cmbCategory.Text & "','" & cmbBrand.Text & "','" & cmbModel.Text & "','" & txtSerialIMEI.Text & "','" & txtESNNo.Text & "',0,'" & txtAccessoriesReceived.Text & "','" & txtReturnedItem.Text & "','" & txtPhysicalCondition.Text & "',2,#" & dtpAssignDate.Value.ToShortDateString & "#'" & cmbJobAssigntoCode.Text & "','" & txtEmail.Text & "'"
                End If

            End If
        Else

            If optSalesWarranty.Checked = True Then
                strNewJobInsertField = "JobCode,Branch,CustName,CustAddress1,CustAddress2,ReceptDate,AppDelDate,ReceptBy,ServiceType,Brand,ModelNo,SLNo,ESN,WCondition,ItemRemarks,ReturnedItems,PhyCond,Cflag,Pdate"
            Else
                strNewJobInsertField = "JobCode,Branch,CustName,CustAddress1,CustAddress2,ReceptDate,AppDelDate,ReceptBy,ServiceType,Brand,ModelNo,SLNo,ESN,WCondition,ItemRemarks,ReturnedItems,PhyCond,Cflag"
            End If


            If optSalesWarranty.Checked = True Then
                strNewJobFieldValue = "'" & txtJobCode.Text & "','" & cmbBranchName.Text & "','" & txtName.Text & "','" & txtAddress.Text & "','" & txtPhone.Text & "',#" & dtpReceiveDate.Value & "#,#" & dtpDelDTApprox.Value & "#,'" & cmbReceivedbyCode.Text & "','" & cmbCategory.Text & "','" & cmbBrand.Text & "','" & cmbModel.Text & "','" & txtSerialIMEI.Text & "','" & txtESNNo.Text & "',0,'" & txtAccessoriesReceived.Text & "','" & txtReturnedItem.Text & "','" & txtPhysicalCondition.Text & "',-1, #" & dtpDateofPurchase.Value & "#"
            ElseIf optNonWarranty.Checked = True Then
                strNewJobFieldValue = "'" & txtJobCode.Text & "','" & cmbBranchName.Text & "','" & txtName.Text & "','" & txtAddress.Text & "','" & txtPhone.Text & "',#" & dtpReceiveDate.Value & "#,#" & dtpDelDTApprox.Value & "#,'" & cmbReceivedbyCode.Text & "','" & cmbCategory.Text & "','" & cmbBrand.Text & "','" & cmbModel.Text & "','" & txtSerialIMEI.Text & "','" & txtESNNo.Text & "',1,'" & txtAccessoriesReceived.Text & "','" & txtReturnedItem.Text & "','" & txtPhysicalCondition.Text & "',-1"
            ElseIf optServiceWarranty.Checked = True Then
                strNewJobFieldValue = "'" & txtJobCode.Text & "','" & cmbBranchName.Text & "','" & txtName.Text & "','" & txtAddress.Text & "','" & txtPhone.Text & "',#" & dtpReceiveDate.Value & "#,#" & dtpDelDTApprox.Value & "#,'" & cmbReceivedbyCode.Text & "','" & cmbCategory.Text & "','" & cmbBrand.Text & "','" & cmbModel.Text & "','" & txtSerialIMEI.Text & "','" & txtESNNo.Text & "',2,'" & txtAccessoriesReceived.Text & "','" & txtReturnedItem.Text & "','" & txtPhysicalCondition.Text & "',-1"
            End If
        End If


        If txtSerialIMEI.Text = "" Then
            MsgBox("Serial Field Is Blank", vbInformation, "Not Successfull")
            txtSerialIMEI.Select()
            Exit Sub

        End If









        If shrtFormType = 1 Then
            strNewJobInsertField = "Insert into Claiminfo(" & strNewJobInsertField & ") Values(" & strNewJobFieldValue & ")"
        ElseIf shrtFormType = 2 Then
            strNewJobInsertField = "Update Claiminfo"

        End If





        'Dim comInsertNewJob As New OleDbCommand("Insert into Claiminfo(JobCode,Branch,CustName,CustAddress1,CustAddress2) Values('" & txtJobCode.Text & "','" & cmbBranchName.Text & "','" & txtName.Text & "','" & txtAddress.Text & "','" & txtPhone.Text & "')", MyCon)






        Try


            Dim comInsertNewJob As New OleDbCommand(strNewJobInsertField, ConSaveCustomerInformation, TempClaiminfoTrans)





            comInsertNewJob.ExecuteNonQuery()

            Dim comTbGrade As OleDbCommand
            If cmbCustGrade.Text <> "" Then
                comTbGrade = New OleDbCommand("Insert into tbGrade(JobCode,cGrade,cRemarks) Values('" & txtJobCode.Text & "','" & cmbCustGrade.Text & "','" & txtCustReference.Text & "')", ConSaveCustomerInformation, TempClaiminfoTrans)
                comTbGrade.ExecuteNonQuery()
            Else
                comTbGrade = New OleDbCommand("Insert into tbGrade(JobCode,cGrade,cRemarks) Values('" & txtJobCode.Text & "',' Special,'" & txtCustReference.Text & "')", ConSaveCustomerInformation, TempClaiminfoTrans)
                comTbGrade.ExecuteNonQuery()
            End If



            'For shrtLoop = 0 To lstFaultList.Items.Count - 1 ' This Final Fault Insert Code Section
            '    If lstFaultList.Items(shrtLoop).Checked = True Then
            '        comInsertNewJob = New OleDbCommand("Insert into CustomerClaim(JobCode,ClaimCode) Values('" & txtJobCode.Text & "','" & lstFaultList.Items(shrtLoop).Text & "')", MyCon)
            '        comInsertNewJob.ExecuteNonQuery()
            '        '      
            '    End If
            'Next

            'shrtLoop = 0
            'For shrtLoop = 0 To lstAccessoriesList.Items.Count - 1  ' This Final ServiceItem Insert Code Section

            '    If lstFaultList.Items(shrtLoop).Checked = True Then
            '        comInsertNewJob = New OleDbCommand("Insert into ServiceItem(JobCode,Item) Values('" & txtJobCode.Text & "','" & lstAccessoriesList.Items(shrtLoop).Text & "')", MyCon)
            '        comInsertNewJob.ExecuteNonQuery()
            '        comInsertNewJob = Nothing

            '    End If


            'Next



            'If txtOtherFault.Text <> "" Then  ' This Final FaultOthers Insert Code Section
            '    Dim comOtherFault As New OleDbCommand("Insert into CustomerClaimOthers(JobCode,ClaimCode) Values('" & txtJobCode.Text & "','" & txtOtherFault.Text & "')", MyCon)

            '    comOtherFault.ExecuteNonQuery()
            '    comOtherFault = Nothing



            'End If

            '____________________________________________________________________________________________ Add New Fault Section _______________________________________________________________________











            Dim dcUpdateFault As New OleDbCommand("Insert Into CustomerClaim(JobCode,ClaimCode) Values('" & txtJobCode.Text & "','" & strFaultValue.ToString & "')", ConSaveCustomerInformation, TempClaiminfoTrans)

            dcUpdateFault.ExecuteNonQuery()




            '___________________________________________________________________________________ Save New Accessories Section _______________________________________________________________________________

            Dim conSaveItem As New OleDbConnection(strProvider)


            Dim intLoopServiceItem As Integer = 0

            Dim strServiceItem As String = String.Empty




            For intLoopFault = 0 To lstAccessoriesList.Items.Count - 1

                If lstAccessoriesList.Items(intLoopFault).Checked = True Then
                    strServiceItem += lstAccessoriesList.Items(intLoopFault).Text & ":"
                End If


            Next



            If strServiceItem <> String.Empty Then


                Dim dcUpdateServiceItem As New OleDbCommand("Insert Into ServiceItem (JobCode,Item)Values('" & txtJobCode.Text & "','" & strServiceItem.ToString & "')", ConSaveCustomerInformation, TempClaiminfoTrans)

                dcUpdateServiceItem.ExecuteNonQuery()


            End If



            TempClaiminfoTrans.Commit()
            MsgBox("New Job Created")



            ClearField()





        Catch ex As Exception
            TempClaiminfoTrans.Rollback()

            MsgBox(ex.Message & vbCrLf & "Event: cmdSave_Click", vbCritical, "Unsuccessfull")

        End Try


    End Sub



    Private Sub UpdateCustomerInformation()

        Dim strUpdateJobCode As String = "Update Claiminfo set "

        Dim ConUpdate As New OleDbConnection(strProvider)
        Dim TransUpdateClaim As OleDbTransaction = Nothing


        ConUpdate.Open()

        TransUpdateClaim = ConUpdate.BeginTransaction


        'strNewJobInsertField = "JobCode,Branch,CustName,CustAddress1,CustAddress2,ReceptDate,AppDelDate,ReceptBy,ServiceType,Brand,ModelNo,SLNo,ESN,WCondition,ItemRemarks,ReturnedItems,PhyCond,Cflag"
        'End If


        'If optSalesWarranty.Checked = True Then
        '    strNewJobFieldValue = "'" & txtJobCode.Text & "','" & cmbBranchName.Text & "','" & txtName.Text & "','" & txtAddress.Text & "','" & txtPhone.Text & "',#" & dtpReceiveDate.Value & "#,#" & dtpDelDTApprox.Value & "#,'" & cmbReceivedbyCode.Text & "','" & cmbCategory.Text & "','" & cmbBrand.Text & "','" & cmbModel.Text & "','" & txtSerialIMEI.Text & "','" & txtESNNo.Text & "',0,'" & txtAccessoriesReceived.Text & "','" & txtReturnedItem.Text & "','" & txtPhysicalCondition.Text & "',-1, #" & dtpDateofPurchase.Value & "#"
        'ElseIf optNonWarranty.Checked = True Then
        '    strNewJobFieldValue = "'" & txtJobCode.Text & "','" & cmbBranchName.Text & "','" & txtName.Text & "','" & txtAddress.Text & "','" & txtPhone.Text & "',#" & dtpReceiveDate.Value & "#,#" & dtpDelDTApprox.Value & "#,'" & cmbReceivedbyCode.Text & "','" & cmbCategory.Text & "','" & cmbBrand.Text & "','" & cmbModel.Text & "','" & txtSerialIMEI.Text & "','" & txtESNNo.Text & "',1,'" & txtAccessoriesReceived.Text & "','" & txtReturnedItem.Text & "','" & txtPhysicalCondition.Text & "',-1"
        'ElseIf optServiceWarranty.Checked = True Then
        '    strNewJobFieldValue = "'" & txtJobCode.Text & "','" & cmbBranchName.Text & "','" & txtName.Text & "','" & txtAddress.Text & "','" & txtPhone.Text & "',#" & dtpReceiveDate.Value & "#,#" & dtpD
        Try


            strUpdateJobCode = strUpdateJobCode & "Claiminfo.JobCode='" & txtJobCode.Text & "', Claiminfo.Branch='" & cmbBranchName.Text & "',Claiminfo.CustName='" & txtName.Text & "',"
            strUpdateJobCode = strUpdateJobCode & "Claiminfo.CustAddress1='" & txtAddress.Text & "', Claiminfo.CustAddress2='" & txtPhone.Text & "',Claiminfo.ReceptDate=#" & dtpReceiveDate.Value.ToShortDateString & "#,"
            strUpdateJobCode = strUpdateJobCode & "Claiminfo.AppdelDate=#" & dtpDelDTApprox.Value.ToShortDateString & "#, Claiminfo.ReceptBy='" & cmbReceivedbyCode.Text & "',Claiminfo.IsssueDate=#" & dtpAssignDate.Value.ToShortDateString & "#,"
            strUpdateJobCode = strUpdateJobCode & "Claiminfo.Issueto='" & cmbJobAssigntoCode.Text & "', Claiminfo.Servicetype='" & cmbCategory.Text & "',Claiminfo.Brand='" & cmbBrand.Text & "',"
            strUpdateJobCode = strUpdateJobCode & "Claiminfo.ModelNo='" & cmbModel.Text & "', Claiminfo.slNo='" & txtSerialIMEI.Text & "',Claiminfo.ESN='" & txtESNNo.Text & "',"
            strUpdateJobCode = strUpdateJobCode & "Claiminfo.ItemRemarks='" & txtAccessoriesReceived.Text & "', Claiminfo.ReturnedItems='" & txtReturnedItem.Text & "',Claiminfo.PhyCond='" & txtPhysicalCondition.Text & "',Claiminfo.Email='" & Trim(txtEmail.Text).ToString & "',"

            Dim dbnullValue As String = ""
            If optSalesWarranty.Checked = True Then
                strUpdateJobCode = strUpdateJobCode & "Claiminfo.Wcondition=" & 0 & ", Claiminfo.PDate=#" & dtpDateofPurchase.Value.ToShortDateString & "#"
            ElseIf optNonWarranty.Checked = True Then
                strUpdateJobCode = strUpdateJobCode & "Claiminfo.Wcondition=" & 1 & ", Claiminfo.PDate=" & vbNull
            ElseIf optServiceWarranty.Checked = True Then
                strUpdateJobCode = strUpdateJobCode & "Claiminfo.Wcondition=" & 2 & ", Claiminfo.PDate=" & vbNull

            End If







            strUpdateJobCode = strUpdateJobCode & " where CLaiminfo.JobCode ='" & strtmpJobCode & "'"




            Dim dcVerifyJobCod As New OleDbCommand(strUpdateJobCode, ConUpdate, TransUpdateClaim)

            dcVerifyJobCod.ExecuteNonQuery()
            strtmpJobCode = txtJobCode.Text



            '_____________________________________________________________________________ Customer Grade Update Section _____________________________________________________________________________________________



            If RecordVerification(strProvider, "TbGrade", "TbGrade.JobCOde='" & strtmpJobCode.ToString & "'") = True Then

                If cmbCustGrade.Text <> String.Empty Then
                    Dim dctbGradeUpdate As New OleDbCommand("Update tbGrade set JobCode='" & txtJobCode.Text & "', CGrade='" & cmbCustGrade.Text & "', Cremarks='" & txtCustReference.Text & "' where JobCOde='" & strtmpJobCode & "'", ConUpdate, TransUpdateClaim)
                    dctbGradeUpdate.ExecuteNonQuery()
                Else
                    Dim dctbGradeUpdate As New OleDbCommand("Update tbGrade set JobCode='" & txtJobCode.Text & "', CGrade='Special', Cremarks='" & txtCustReference.Text & "' where JobCOde='" & strtmpJobCode & "'", ConUpdate, TransUpdateClaim)
                    dctbGradeUpdate.ExecuteNonQuery()
                End If




            End If



            '_____________________________________________________________________________ Fault Update Section _____________________________________________________________________________________________






            Dim strFaultValue As String = String.Empty


            Dim intLoopFault As Integer = 0


            For intLoopFault = 0 To lstFaultList.Items.Count - 1

                If lstFaultList.Items(intLoopFault).Checked = True Then
                    strFaultValue = strFaultValue & lstFaultList.Items(intLoopFault).Text & ","
                End If
            Next


            If txtOtherFault.Text <> String.Empty Then
                strFaultValue = strFaultValue & txtOtherFault.Text & ","
            End If



            If strFaultValue <> String.Empty Then

                If RecordVerification(strProvider, "CustomerClaim", "CustomerClaim.JobCode='" & strtmpJobCode & "'") = True Then
                    Dim strUpdatSQL = "Update CustomerClaim set CustomerClaim.JobCode='" & txtJobCode.Text & "',CustomerClaim.ClaimCode='" & strFaultValue.ToString & "' where CustomerClaim.JobCode='" & strtmpJobCode.ToString & "'"

                    Dim dcUpdateFault As New OleDbCommand(strUpdatSQL, ConUpdate, TransUpdateClaim)

                    dcUpdateFault.ExecuteNonQuery()
                Else



                    Dim dcUpdateFault As New OleDbCommand("Insert Into CustomerClaim(JobCode,ClaimCode) Values('" & txtJobCode.Text & "','" & strFaultValue.ToString & "')", ConUpdate, TransUpdateClaim)

                    dcUpdateFault.ExecuteNonQuery()

                End If





            End If





            '______________________________________________________________________________________ Update Accessories Section ______________________________________________________________________________





            Dim intLoopServiceItem As Integer = 0

            Dim strServiceItem As String = String.Empty




            For intLoopServiceItem = 0 To lstAccessoriesList.Items.Count - 1

                If lstAccessoriesList.Items(intLoopServiceItem).Checked = True Then
                    strServiceItem += lstAccessoriesList.Items(intLoopServiceItem).Text & ":"
                End If


            Next



            If strServiceItem <> String.Empty Then



                If RecordVerification(strProvider, "ServiceItem", "ServiceItem.JobCode='" & strtmpJobCode & "'") = True Then
                    Dim dcUpdateServiceItem As New OleDbCommand("Update ServiceItem set JobCode='" & txtJobCode.Text & "', Item='" & strServiceItem.ToString & "' where ServiceItem.JobCode='" & strtmpJobCode.ToString & "'", ConUpdate, TransUpdateClaim)

                    dcUpdateServiceItem.ExecuteNonQuery()
                Else

                    Dim dcUpdateServiceItem As New OleDbCommand("Insert Into ServiceItem (JobCode,Item)Values('" & txtJobCode.Text & "','" & strServiceItem.ToString & "')", ConUpdate, TransUpdateClaim)

                    dcUpdateServiceItem.ExecuteNonQuery()


                End If


            End If


            TransUpdateClaim.Commit()



            MsgBox("Update Record", vbCritical, "Update successfully")
        Catch exSaveError As Exception

            TransUpdateClaim.Rollback()

            MessageBox.Show(exSaveError.Message)
        End Try





    End Sub



    Private Sub AddUpdateCustomerClaimOthers(ByVal strTempJobCode As String)

        Dim dcVerifyRecord As New OleDbCommand("Select * from CustomerClaimOthers where CustomerCLaimOthers.JobCode='" & strTempJobCode & "'", MyCon)

        Dim drVerifyRecord As OleDbDataReader

        drVerifyRecord = dcVerifyRecord.ExecuteReader


        If drVerifyRecord.HasRows = True Then
            Dim strDeleteUpdate As String = ""

            If txtOtherFault.Text = "" Then

                strDeleteUpdate = "Delete * from CustomerClaimOthers where CustomerClaimOthers.jobCode='" & strTempJobCode & "'"

            Else

                strDeleteUpdate = "Update CustomerClaimOthers set CustomerClaimOthers.JobCOde='" & txtJobCode.Text & "', CustomerClaimOthers.Claimcode='" & txtOtherFault.Text & "' where CustomerClaimOthers.jobCode='" & strTempJobCode & "'"


            End If
            Dim dcDeleteUpdateRecord As New OleDbCommand(strDeleteUpdate, MyCon)


        Else

            If txtOtherFault.Text <> "" Then
                Dim dcUpdateRecord As New OleDbCommand("Insert Into CustomerCLaimOthers(JobCode,Claimcode) Values('" & txtJobCode.Text & "','" & txtOtherFault.Text & "')", MyCon)

                dcUpdateRecord.ExecuteNonQuery()
            End If


        End If



    End Sub


    Private Sub addupdatetbGrade(ByVal strTempJobCode As String)
        Dim dcVerifytbGrade As New OleDbCommand("Select tbGrade.Cgrade,tbGrade.cRemarks from tbGrade where tbgrade.jobcode=@Jobcode", MyCon)

        dcVerifytbGrade.Parameters.Add("@Jobcode", OleDbType.Char, 255).Value = strTempJobCode
        Dim drVerifytbGrade As OleDbDataReader

        drVerifytbGrade = dcVerifytbGrade.ExecuteReader

        If drVerifytbGrade.HasRows = True Then
            Dim strDeleteUpdate As String = ""
            Dim dcDeleteUpdate As OleDbCommand = New OleDbCommand


            If cmbCustGrade.Text = "" And txtCustReference.Text = "" Then

                strDeleteUpdate = "Delete * from tbgrade where tbgrade.jobcode=@Jobcode"
                dcDeleteUpdate.Parameters.Add("@Jobcode", OleDbType.Char, 255).Value = strTempJobCode
            Else
                If cmbCustGrade.Text = "" Then
                    strDeleteUpdate = "Update tbGrade set tbgrade.JobCode=@Jobcode, tbGrade.cGrade='Special', cRemarks=@cRemarks where tbgrade.JobCode=@JobCode2'" & strTempJobCode & "'"
                    dcVerifytbGrade.Parameters.Add("@Jobcode", OleDbType.Char, 255).Value = txtJobCode.Text
                    dcVerifytbGrade.Parameters.Add("@cRemarks", OleDbType.Char, 255).Value = txtCustReference.Text
                    dcVerifytbGrade.Parameters.Add("@JobCode2", OleDbType.Char, 255).Value = strTempJobCode
                Else

                    strDeleteUpdate = "Update tbGrade set tbgrade.JobCode=@Jobcode, tbGrade.cGrade=@cGrade, cRemarks=@cRemarks where tbgrade.JobCode=@JobCode2"


                    dcVerifytbGrade.Parameters.Add("@Jobcode", OleDbType.Char, 255).Value = txtJobCode.Text
                    dcVerifytbGrade.Parameters.Add("@cGrade", OleDbType.Char, 255).Value = cmbCustGrade.Text
                    dcVerifytbGrade.Parameters.Add("@cRemarks", OleDbType.Char, 255).Value = txtCustReference.Text
                    dcVerifytbGrade.Parameters.Add("@JobCode2", OleDbType.Char, 255).Value = strTempJobCode


                End If
                dcDeleteUpdate.CommandText = strDeleteUpdate
                dcDeleteUpdate.CommandType = CommandType.Text
                dcDeleteUpdate.Connection = MyCon

                dcDeleteUpdate.ExecuteNonQuery()
                dcDeleteUpdate = Nothing
            End If

            'strAddNewtbGrade = "update  tbgrade set tbGrade.cGrade='" & cmbCustGrade.Text & "', cRemarks='" & txtCustReference.Text & "' where tbgrade.JobCode='" & strTempJobCode & "'"
        Else
            Dim strAddNewtbGrade As String = ""
            If cmbCustGrade.Text <> "" Or txtCustReference.Text <> "" Then
                strAddNewtbGrade = "Insert into tbgrade(JobCode,cGrade,cRemarks) values(@JobCode,@cGrade,@cRemarks)"
                Dim dcAddNewtbGrade As New OleDbCommand(strAddNewtbGrade, MyCon)
                dcAddNewtbGrade.Parameters.Add("@Jobcode", OleDbType.Char, 255).Value = txtJobCode.Text
                dcAddNewtbGrade.Parameters.Add("@cGrade", OleDbType.Char, 255).Value = cmbCustGrade.Text
                dcAddNewtbGrade.Parameters.Add("@cRemarks", OleDbType.Char, 255).Value = txtCustReference.Text

                dcAddNewtbGrade.ExecuteNonQuery()
                dcAddNewtbGrade = Nothing
                dcAddNewtbGrade.Dispose()
            End If



        End If
        drVerifytbGrade.Close()
        drVerifytbGrade = Nothing

        dcVerifytbGrade.Dispose()



    End Sub

    Private Sub cmdService_Click(sender As Object, e As EventArgs) Handles cmdService.Click
        Dim frmtmp As New frmJobInformationForm






        If VerifyJobNo(txtJobCode.Text) = False Then
            MessageBox.Show("this is new Job or Not found in the record" & vbCrLf & "please update the 'Job No'")
            Exit Sub




        End If




        If shrtFormType = 1 Then


            MsgBox(" This is New 'Job Entry Form'" & vbCrLf & "The form will be available on 'Job Edit Form'", vbInformation, "Notification Report")
            Exit Sub
        ElseIf shrtFormType = 2 Then
            dtReceiveDate = dtpAssignDate.Value.ToShortDateString
            If lblJobAssigntoCode.Text = "" Or lblJobAssigntoCode.Text = "Missing Name" Then
                MessageBox.Show("Job Assign Code is not set", "Blank Assign Code")
                cmbJobAssigntoCode.Select()
                Exit Sub

            End If
            saveNewJob(False)
            LoadTempInformation()

        End If







    End Sub


    Private Sub LoadTempInformation()




        Dim frmtmpNewCustomer As New frmJobInformationForm
        Try


            FormOpecityDecrease(frmMdimain, 0.8)
            With frmtmpNewCustomer
                '        .intWarrCondition = -1
                '        .strJobCode = "" & txtJobCode.Text

                '        .strCategory = "" & cmbCategory.Text
                '        .strBranch = "" & cmbBranchName.Text
                '        .strName = "" & txtName.Text
                '        .strAddress1 = "" & txtAddress.Text
                '        .straddress2 = "" & txtPhone.Text
                '        .lblReceptDate.Text = dtpReceiveDate.Value.ToShortDateString
                '        .strReceivebyCode = "" & cmbReceivedbyCode.Text
                '        .strAssigntoCode = "" & cmbJobAssigntoCode.Text
                '        .lblAssignDate.Text = dtpAssignDate.Value.ToShortDateString
                '        .strCategory = "" & cmbCategory.Text
                '        .strBrand = "" & cmbBrand.Text
                '        .strModel = "" & cmbModel.Text
                '        .strSLNO = "" & txtSerialIMEI.Text
                '        .strESN = "" & txtESNNo.Text
                '        .strCFlag = strTempCFlag
                '        .strMrNo = strTempMRNo

                .ShowDialog()

                FormOpecityIncrease(frmMdimain, 1)
            End With
        Catch ex As Exception
            MsgBox(ex.Message & vbTab & ex.StackTrace, vbCritical, "Event Name: LoadTempInformation")

        End Try
    End Sub


    Private Function VerifyJobNo(ByVal strTempjobVerify As String) As Boolean
        Dim VerifyJobConnection As New OleDbConnection(Module2.strProvider)
        VerifyJobConnection.Open()

        Dim dcVerifyJobNo As New OleDbCommand("Select Claiminfo.JobCode from CLaiminfo where Claiminfo.JobCode=@Jobcode", VerifyJobConnection)

        dcVerifyJobNo.Parameters.Add("@Jobcode", OleDbType.Char, 255).Value = strTempjobVerify

        Dim drverifyJobNo As OleDbDataReader


        drverifyJobNo = dcVerifyJobNo.ExecuteReader

        If drverifyJobNo.HasRows = True Then
            Return True
        Else
            Return False

        End If







    End Function

    Private Sub optServiceWarranty_CheckedChanged(sender As Object, e As EventArgs) Handles optServiceWarranty.CheckedChanged

    End Sub

    Private Sub lblSetBranch_Click(sender As Object, e As EventArgs) Handles lblSetBranch.Click
        Dim frmTempSetBranch As New frmSetBranch

        frmTempSetBranch.ShowDialog()
        FieldDefaultValue()

    End Sub

    Private Sub cmdReport_Click(sender As Object, e As EventArgs) Handles cmdReport.Click






    End Sub



    Private Sub txtOtherFault_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOtherFault.KeyPress
        'Dim TempTool As New ToolTip

        'If RemoveCharacter(e.KeyChar) = True Then
        '    e.Handled = True
        '    TempTool.Show(":',.?/|\*&^%$#@!~`}]{[;><=+""", txtOtherFault, 1000)
        'End If




    End Sub


    Private Sub SaveFault(ByVal TempFaultTransaction As OleDbTransaction)


        'Dim conFault As New OleDbConnection(strProvider)


        'Dim strFaultValue As String = String.Empty


        'Dim intLoop As Integer = 0


        'For intLoop = 0 To lstFaultList.Items.Count - 1

        '    If lstFaultList.Items(intLoop).Checked = True Then
        '        strFaultValue = strFaultValue & lstFaultList.Items(0).Text & ":"
        '    End If
        'Next


        'If txtOtherFault.Text <> String.Empty Then
        '    strFaultValue = strFaultValue & txtOtherFault.Text & ":"
        'End If



        'If strFaultValue <> String.Empty Then
        '    conFault.Open()
        '    TempFaultTransaction = conFault.BeginTransaction
        '    If RecordVerification(strProvider, "CustomerClaim", "CustomerClaim.JobCode='" & strtmpJobCode & "'") = True Then
        '        Dim dcUpdateFault As New OleDbCommand("Update CustomerClaim set CustomerClaim.JobCode='" & txtJobCode.Text & "',CustomerClaim.ClaimCode='" & strFaultValue.ToString & "' where CustomerClaim.JobCode'" & strtmpJobCode.ToString & "'", conFault, TempFaultTransaction)

        '        dcUpdateFault.ExecuteNonQuery()
        '    Else
        '        'Dim strInsert As String = 


        '        Dim dcUpdateFault As New OleDbCommand("Insert Into CustomerClaim(JobCode,ClaimCode) Values('" & txtJobCode.Text & "','" & strFaultValue.ToString & "')", conFault, TempFaultTransaction)

        '        dcUpdateFault.ExecuteNonQuery()

        '    End If


        '    SaveServiceItem(TempFaultTransaction)

        '    TempFaultTransaction.Commit()
        'End If




    End Sub


    Private Sub SaveServiceItem(ByVal TempServiceItemTrans As OleDbTransaction)

        'Dim conSaveItem As New OleDbConnection(strProvider)


        'Dim intLoop As Integer = 0

        'Dim strServiceItem As String = String.Empty




        'For intLoop = 0 To lstAccessoriesList.Items.Count - 1

        '    If lstAccessoriesList.Items(intLoop).Checked = True Then
        '        strServiceItem += lstAccessoriesList.Items(intLoop).Text & ":"
        '    End If


        'Next



        'If strServiceItem <> String.Empty Then
        '    conSaveItem.Open()
        '    TempServiceItemTrans = conSaveItem.BeginTransaction


        '    If RecordVerification(strProvider, "ServiceItem", "ServiceItem.JobCode='" & strtmpJobCode & "'") = True Then
        '        Dim dcUpdateServiceItem As New OleDbCommand("Update ServiceItem set JobCode='" & txtJobCode.Text & "', Item='" & strServiceItem.ToString & "'", conSaveItem, TempServiceItemTrans)

        '        dcUpdateServiceItem.ExecuteNonQuery()
        '    Else

        '        Dim dcUpdateServiceItem As New OleDbCommand("Insert Into ServiceItem (JobCode,Item)Values('" & txtJobCode.Text & "','" & strServiceItem.ToString & "')", conSaveItem, TempServiceItemTrans)

        '        dcUpdateServiceItem.ExecuteNonQuery()


        '    End If



        '    TempServiceItemTrans.Commit()



        'End If
















    End Sub



    Private Sub cmdSaveandPrint_Click(sender As Object, e As EventArgs) Handles cmdSaveandPrint.Click

        Try

            Dim strMessage As String = String.Empty



            If shrtFormType = 2 Then 'Edit
                If String.IsNullOrEmpty(cmbJobAssigntoCode.Text) Or cmbJobAssigntoCode.Text.Trim = "" Then
                    strMessage = "Assign Code is Blank"
                    MessageBox.Show(strMessage)
                    cmbJobAssigntoCode.Select()
                    Exit Sub
                End If
            Else
                If DataValidation(strMessage) = False Then
                    MessageBox.Show(strMessage)
                    Exit Sub
                End If
            End If


            Dim frmTempPrintSlip As frmPrintClaimSlip = New frmPrintClaimSlip

            frmTempPrintSlip.strPrinJob = txtJobCode.Text
            If optSalesWarranty.Checked = True Or optServiceWarranty.Checked = True Then
                frmTempPrintSlip.JobBill.TechnicalCharge = 0
            Else

                If Double.TryParse(dblServiceCharge, frmTempPrintSlip.JobBill.TechnicalCharge) = False Then
                    frmTempPrintSlip.JobBill.TechnicalCharge = 0
                End If
            End If



            cmdSave_Click(sender, e)









            frmTempPrintSlip.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try










    End Sub


    Private Sub txtOtherFault_TextChanged(sender As Object, e As EventArgs) Handles txtOtherFault.TextChanged
        Dim tmpobj As clsOthers = New clsOthers

        tmpobj.Showtooltip(txtOtherFault)
    End Sub

    Private Sub cmbModel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbModel.SelectedIndexChanged
        picNotification.Image = Nothing
        Dim tempTool As ToolTip = New ToolTip



        If Not String.IsNullOrEmpty(cmbModel.Text.Trim) Then
            Dim mdMethods As clsBrandModelMethods = New clsBrandModelMethods
            Dim strGetValue As String = String.Empty


            strGetValue = " BrandModel.Brdid=" & Convert.ToInt32(cmbBrand.SelectedValue) & " AND BrandModel.Model='" & cmbModel.Text & "'"
            dblServiceCharge = 0


            dblServiceCharge = mdMethods.GetModelCharge(strGetValue)
            If dblServiceCharge = 0 Then



                tempTool.Show("Service Charge not set", picNotification, 1000)

                picNotification.Image = My.Resources.ExclamationMark
                picNotification.Tag = "ExclamationMark"
            Else
                picNotification.Image = My.Resources.Green_Tick_2
                picNotification.Tag = "Tick2"
            End If


        End If
    End Sub




    Private Sub picNotification_Click(sender As Object, e As EventArgs) Handles picNotification.Click
        Dim BrandMethods As clsBrandMethods = New clsBrandMethods
        Dim Brand As clsBrand = BrandMethods.GetSingleID(cmbCategory.Text, cmbBrand.Text)
        Dim GetServiceCharge As clsBrandModelMethods = New clsBrandModelMethods
        Dim strGetValue As String

        Try


            If IsNothing(Brand.BrdID) Then
                MessageBox.Show("BrandId Not Found")
                Exit Sub
            End If

            If GetServiceCharge.IsExist(cmbModel.Text, Brand.BrdID) = False Then
                MessageBox.Show("Invalid Model")
                Exit Sub

            End If

            strGetValue = " BrandModel.Brdid=" & Convert.ToInt32(cmbBrand.SelectedValue) & " AND BrandModel.Model='" & cmbModel.Text & "'"
            Dim dblServiceCharge As Double = Double.Parse("0")
            Dim dblTempValue As String = InputBox("Type Service Charge", "Update Service Charge", GetServiceCharge.GetModelCharge(strGetValue))


            If dblTempValue.Length <= 0 Then
                Exit Sub
            End If





            If Double.TryParse(dblTempValue, dblServiceCharge) = False Then

                MessageBox.Show(" Invalid Type " & vbNewLine & " Please Type Numeric")
                Exit Sub

            End If

            If dblServiceCharge = 0 Then
                MessageBox.Show("Service Charge Should be Greater Than 0")
                Exit Sub
            End If


            Dim BrandModelMethods As clsBrandModelMethods = New clsBrandModelMethods

            BrandModelMethods.UpdateServiceCharge(dblServiceCharge, cmbModel.Text, cmbBrand.SelectedValue)
            MessageBox.Show("Price Update Successfully")

            cmbModel_SelectedIndexChanged(sender, e)


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub txtJobCode_TextChanged(sender As Object, e As EventArgs) Handles txtJobCode.TextChanged

    End Sub

    Private Sub txtJobCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJobCode.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub cmdBill_Click(sender As Object, e As EventArgs) Handles cmdBill.Click
        Try

            Dim strMessage As String = String.Empty
            If DataValidation(strMessage) = False Then
                MessageBox.Show(strMessage)
                Exit Sub
            End If

            If shrtFormType = 2 Then
                If String.IsNullOrEmpty(cmbJobAssigntoCode.Text) Or cmbJobAssigntoCode.Text.Trim = "" Then
                    strMessage = "Assign Code is Blank"
                    MessageBox.Show(strMessage)
                    cmbJobAssigntoCode.Select()
                    Exit Sub
                End If
            End If


            Dim frmTempPrintSlip As frmPrintClaimSlip = New frmPrintClaimSlip

            frmTempPrintSlip.strPrinJob = txtJobCode.Text
            If optNonWarranty.Checked = True Then

                If Double.TryParse(dblServiceCharge, frmTempPrintSlip.JobBill.TechnicalCharge) = False Then
                    frmTempPrintSlip.JobBill.TechnicalCharge = 0
                End If
            Else
                frmTempPrintSlip.JobBill.TechnicalCharge = 0
            End If
            frmTempPrintSlip.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmdTransferJob_Click(sender As Object, e As EventArgs) Handles cmdTransferJob.Click
        Dim TransferJob As frmTransfer = New frmTransfer

        If shrtFormType = 2 Then
            TransferJob.TransferJobClass.JobCode = txtJobCode.Text
            TransferJob.TransferJobClass.TransferFrom = cmbBranchName.Text
            TransferJob.ShowDialog()
        End If
    End Sub



    Private Sub txtEmail_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEmail.KeyDown
        If e.KeyCode = 13 Then

            dtpReceiveDate.Select()

        End If
    End Sub

    Private Sub chkREL_CheckedChanged(sender As Object, e As EventArgs) Handles chkREL.CheckedChanged
        If chkREL.Checked = True Then
            txtName.Text = "REL"
        Else
            txtName.Text = String.Empty
        End If
    End Sub

    Private Sub chkOldFrom_CheckedChanged(sender As Object, e As EventArgs) Handles chkOldFrom.CheckedChanged


        'If chkOldFrom.Checked = True Then
        '    Update(Me.Name, "Old Form", True)
        '    Resolution_Below_1024()


        'Else
        '    Update(Me.Name, "Old Form", False)
        '    Resolution_Over_1024()

        'End If



    End Sub


    Private Function HasRow() As Boolean
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim blnFlag As Boolean = False
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dc As OleDbCommand = New OleDbCommand("Select * from FormStyles", con)
            con.Open()
            Dim dr As OleDbDataReader = dc.ExecuteReader
            If dr.HasRows = True Then
                blnFlag = True
            End If
        End Using
        Return blnFlag
    End Function



    'Private Sub Update(ByVal FormName As String, ByVal FormType As String, ByVal IsActive As Boolean)
    '    Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
    '    Dim strSQL As String = String.Empty
    '    strSQL = "Update FormStyles set FormName=@FormName, FormType=@FormType,IsActive=@IsActive"
    '    Using con As OleDbConnection = New OleDbConnection(cs)
    '        Dim dc As OleDbCommand = New OleDbCommand(strSQL, con)
    '        dc.Parameters.Add("@FormName", OleDbType.Char, 255).Value = If(FormName.Length > 0, FormName, DBNull.Value)
    '        dc.Parameters.Add("@FormType", OleDbType.Char, 255).Value = If(FormType.Length > 0, FormType, DBNull.Value)
    '        dc.Parameters.Add("@IsActive", OleDbType.Boolean).Value = IsActive
    '        con.Open()
    '        dc.ExecuteNonQuery()
    '    End Using

    'End Sub





    Private Sub Insert(ByVal FormName As String, ByVal FormType As String, ByVal IsActive As Boolean)
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim strSQL As String = String.Empty
        strSQL = "Insert into FormStyles(FormName,FormType,IsActive) values(@FormName, @FormType,@IsActive)"
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dc As OleDbCommand = New OleDbCommand(strSQL, con)
            dc.Parameters.Add("@FormName", OleDbType.Char, 255).Value = If(FormName.Length > 0, FormName, DBNull.Value)
            dc.Parameters.Add("@FormType", OleDbType.Char, 255).Value = If(FormType.Length > 0, FormType, DBNull.Value)
            dc.Parameters.Add("@IsActive", OleDbType.Boolean).Value = IsActive
            con.Open()
            dc.ExecuteNonQuery()
        End Using

    End Sub

    Private Function IsActive() As Boolean
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim blnFlag As Boolean = False
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dc As OleDbCommand = New OleDbCommand("Select * from FormStyles where IsActive=True", con)
            con.Open()
            Dim dr As OleDbDataReader = dc.ExecuteReader
            If dr.HasRows = True Then
                blnFlag = True
            End If
        End Using
        Return blnFlag
    End Function

    Private Sub chkOldFrom_CheckStateChanged(sender As Object, e As EventArgs) Handles chkOldFrom.CheckStateChanged



    End Sub

    Private Sub cmbModel_Leave(sender As Object, e As EventArgs) Handles cmbModel.Leave

    End Sub



    Private Function RemoveSpecialCharecter(ByVal ProcessData As String)

        Dim strData = String.Empty
        Dim I As String = "~`!@#$%^&*()-_=+|\<,>.?/:;' "
        For Each C As Char In ProcessData

            If Not I.Contains(C) Then
                strData += C.ToString.ToUpper
            End If

        Next


        Return strData

    End Function

    Private Sub lblDelDTApprox_Click(sender As Object, e As EventArgs) Handles lblDelDTApprox.Click

    End Sub

    Private Sub dtpDelDTApprox_ValueChanged(sender As Object, e As EventArgs) Handles dtpDelDTApprox.ValueChanged

    End Sub

    Private Sub lblReceivedByCode_Click(sender As Object, e As EventArgs) Handles lblReceivedByCode.Click

    End Sub

    Private Sub lblJobAssigntoCode_Click(sender As Object, e As EventArgs) Handles lblJobAssigntoCode.Click

    End Sub

    Private Sub cmbCategory_Leave(sender As Object, e As EventArgs) Handles cmbCategory.Leave

    End Sub

    Private Sub cmbBrand_Leave(sender As Object, e As EventArgs) Handles cmbBrand.Leave

    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub txtName_Leave(sender As Object, e As EventArgs) Handles txtName.Leave
        If txtName.MaxLength > 0 Then
            txtName.Text = txtName.Text.ToUpper
        End If
    End Sub

    Private Sub txtAddress_TextChanged(sender As Object, e As EventArgs) Handles txtAddress.TextChanged

    End Sub

    Private Sub txtAddress_Leave(sender As Object, e As EventArgs) Handles txtAddress.Leave
        If txtAddress.MaxLength > 0 Then
            txtAddress.Text = txtAddress.Text.ToUpper
        End If
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged

    End Sub

    Private Sub txtEmail_Leave(sender As Object, e As EventArgs) Handles txtEmail.Leave
        If txtEmail.MaxLength > 0 Then
            txtEmail.Text = txtEmail.Text.ToLower
        End If
    End Sub

    Private Sub picCategoryRefress_Click(sender As Object, e As EventArgs) Handles picCategoryRefress.Click
        LoadCategory()
    End Sub

    Private Sub picBrandRefresh_Click(sender As Object, e As EventArgs) Handles picBrandRefresh.Click
        LoadBrand(cmbCategory.Text)
    End Sub

    Private Sub picNotification_MouseEnter(sender As Object, e As EventArgs) Handles picNotification.MouseEnter
        'Dim temptool As ToolTip = New ToolTip
        'temptool.RemoveAll()


        If picNotification.Image IsNot Nothing Then
            If picNotification.Tag = "ExclamationMark" Then
                Tool.Show("Service Charge not set", picNotification, 1000)
                '  temptool.Show("Service Charge not set", picNotification, 1000)
            Else
                ' temptool.Show("Service Charge : " & dblServiceCharge, picNotification, 1000)
                Tool.Show("Service Charge : " & dblServiceCharge, picNotification, 1000)
            End If
        End If

    End Sub

    Private Sub cmbBrand_Validating(sender As Object, e As CancelEventArgs) Handles cmbBrand.Validating
        'If cmbBrand.Text.Length > 0 Then
        '    Dim clsBrand As clsBrandMethods = New clsBrandMethods

        '    If clsBrand.IsExist(cmbCategory.Text, cmbBrand.Text) = False Then
        '        MessageBox.Show("Brand not found in database", "Type mismatch", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        e.Cancel = True
        '    End If


        'Else
        '    MessageBox.Show("Brand is Blank")
        '    e.Cancel = True

        'End If
    End Sub

    Private Sub cmbCategory_Validating(sender As Object, e As CancelEventArgs) Handles cmbCategory.Validating
        'If cmbCategory.Text.Length > 0 Then
        '    Dim clsCategory As clscTypeMethods = New clscTypeMethods

        '    If clsCategory.IsExist(cmbCategory.Text) = False Then
        '        MessageBox.Show("Category not found in database", "Type mismatch", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        e.Cancel = True
        '    End If


        'Else
        '    MessageBox.Show("Category is Blank")
        '    e.Cancel = True

        'End If
    End Sub

    Private Sub cmbModel_Validating(sender As Object, e As CancelEventArgs) Handles cmbModel.Validating
        'Dim BrandMethods As clsBrandMethods = New clsBrandMethods
        'Dim Brand As clsBrand = BrandMethods.GetSingleID(cmbCategory.Text, cmbBrand.Text)
        'Dim BrandModel As clsBrandModelMethods = New clsBrandModelMethods

        'Try
        '    If IsNothing(Brand.BrdID) Or Brand.BrdID = 0 Then
        '        MessageBox.Show("Category or Brand is not Correct")
        '        cmbCategory.Select()
        '        Exit Sub
        '    Else
        '        If BrandModel.IsExist(cmbModel.Text, cmbBrand.SelectedValue) = False Then
        '            If MessageBox.Show("Do You Want to create Model", "Invalid Model", MessageBoxButtons.YesNo) = DialogResult.Yes Then
        '                Dim NewModel As frmAdd_EditModel = New frmAdd_EditModel
        '                NewModel.lblCategory.Text = cmbCategory.Text
        '                NewModel.lblBrand.Text = cmbBrand.Text
        '                NewModel.intModelFlag = 1 '1 for Create New Model, 2 for Edit Model
        '                NewModel.txtModel.Text = RemoveSpecialCharecter(cmbModel.Text)
        '                NewModel.intBrandId = cmbBrand.SelectedValue
        '                NewModel.ShowDialog()
        '                cmbModel.Text = NewModel.ModelName
        '                cmbModel.Select()
        '            Else
        '                e.Cancel = True
        '            End If

        '        End If
        '    End If

        'Catch ex As OleDbException
        '    MessageBox.Show(ex.StackTrace, ex.Message)
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Invalid Model", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    cmbModel.Select()
        'End Try
    End Sub

    Private Sub picCreateFault_Click(sender As Object, e As EventArgs) Handles picCreateFault.Click

        If cmbCategory.Text.Length > 0 Then
            Dim ClaimList As frmClaimList = New frmClaimList
            ClaimList.cmbCategory.Text = cmbCategory.Text
            ClaimList.ShowDialog()
        Else
            MessageBox.Show("Category Field is Blank or Invalid")
        End If



    End Sub

    Private Sub picRefreshFault_Click(sender As Object, e As EventArgs) Handles picRefreshFault.Click
        LoadFault(cmbCategory.Text)
    End Sub

    Private Sub picCreateAccessories_Click(sender As Object, e As EventArgs) Handles picCreateAccessories.Click

        Dim claimlist As clstblItemCap = New clstblItemCap
        Dim claimlistmethods As clstblItemCapMethods = New clstblItemCapMethods
        Dim category As clscTypeMethods = New clscTypeMethods



        If category.IsExist(cmbCategory.Text) = False Then
            MessageBox.Show("Category not found in database")
            cmbCategory.Select()
            Exit Sub
        End If


        Dim strClaim As String = InputBox("Type Accessories", "Add Accessories")


        Try


            If strClaim <> "" Then


                claimlist.ItemCode = 0
                claimlist.CategoryName = cmbCategory.Text
                claimlist.cItem = strClaim

                claimlistmethods.Save(claimlist)
                LoadAccessoriesItem(cmbCategory.Text)
                MessageBox.Show("Accessories Save Successfully")
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try



    End Sub

    Private Sub picRefreshAccesorries_Click(sender As Object, e As EventArgs) Handles picRefreshAccesorries.Click
        LoadAccessoriesItem(cmbCategory.Text)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picDeleteAccessories.Click

        If lstAccessoriesList.Items.Count > 0 Then
            If lstAccessoriesList.SelectedItems.Count > 0 Then

                If MessageBox.Show("Do you want to delete accessories", "Delete Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then

                    Dim Accessories As clstblItemCap = New clstblItemCap
                    Dim accessoriesmethos As clstblItemCapMethods = New clstblItemCapMethods
                    Accessories.CategoryName = cmbCategory.Text
                    Accessories.cItem = lstAccessoriesList.FocusedItem().Text

                    accessoriesmethos.Delete(Accessories)
                    MessageBox.Show("Accessories Delete Successfully")
                    LoadAccessoriesItem(cmbCategory.Text)

                End If
            Else
                MessageBox.Show("No Item Seleted")
            End If
        Else

            MessageBox.Show("No Item in the list to delete")

        End If

    End Sub

    Private Sub picDeleteFault_Click(sender As Object, e As EventArgs) Handles picDeleteFault.Click

        If lstFaultList.Items.Count > 0 Then
            If lstFaultList.SelectedItems.Count > 0 Then
                If MessageBox.Show("Do you want to delete Fault", "Delete Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then



                    Dim claimlist As clsClaimlist = New clsClaimlist
                    Dim claimlistmethods As clsClaimlistMethods = New clsClaimlistMethods
                    claimlist.CategoryName = cmbCategory.Text
                    claimlist.Claim = lstFaultList.FocusedItem().Text

                    claimlistmethods.Delete(claimlist)
                    MessageBox.Show("Fault Delete Successfully")
                    LoadFault(cmbCategory.Text)

                End If
            Else
                MessageBox.Show("No Item Seleted")
            End If
        Else

            MessageBox.Show("No Item in the list to delete")

        End If
    End Sub
End Class








