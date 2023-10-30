Imports System.Data.OleDb
Imports System.Data




Public Class FrmAdvance
    Dim strNewEdit As String = String.Empty
    Dim TT As New ToolTip()
    Dim blnListFlag As Boolean
    Dim strKeepJobNo As String = String.Empty
    Dim strKeepMrNo As String = String.Empty


    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Dispose()


    End Sub



    Private Sub DisableField()
        txtMR.Enabled = False
        txtJobCode.Enabled = False
        txtCustomerName.Enabled = False
        txtPhone.Enabled = False
        txtReceiveDate.Enabled = False
        txtModelNo.Enabled = False
        txtSLNo.Enabled = False
        txtAddress.Enabled = False
        txtPayment.Enabled = False
        txtChecque.Enabled = False
        txtBankName.Enabled = False
        txtRemarks.Enabled = False

        cmbBranch.Enabled = False
        cmbPayType.Enabled = False
        dtpPaymentDate.Enabled = False
        chkPrintPreview.Enabled = False
        cmdDelete.Enabled = False
        cmdSave.Enabled = False
        cmdClose.Enabled = True
        cmdNew.Enabled = True
        cmdEdit.Enabled = True
        lstJobMR.Items.Clear()
        lstJobMR.Visible = False



    End Sub



    Private Sub EnabledField()
        txtMR.Enabled = True
        txtJobCode.Enabled = True
        txtCustomerName.Enabled = True
        txtPhone.Enabled = True
        txtReceiveDate.Enabled = True
        txtModelNo.Enabled = True
        txtSLNo.Enabled = True
        txtAddress.Enabled = True
        txtPayment.Enabled = True
        txtChecque.Enabled = False
        txtBankName.Enabled = False
        txtRemarks.Enabled = True
        cmbBranch.Enabled = True
        cmbPayType.Enabled = True
        dtpPaymentDate.Enabled = True
        chkPrintPreview.Enabled = True
        cmdDelete.Enabled = True
        cmdSave.Enabled = True
        lstJobMR.Visible = False

    End Sub


    Private Sub LoadBranch()

        Dim drLoadBranch As OleDbDataReader = Nothing

        Dim conLoadBranch As New OleDbConnection(strProvider)

        LoadAllInformation(conLoadBranch, drLoadBranch, strProvider, "Branch", "Branch.Branch", "Branch.Flag=-1")


        If drLoadBranch.HasRows = True Then
            While drLoadBranch.Read
                cmbBranch.Items.Add(drLoadBranch("Branch").ToString)
            End While
        End If

        TempConnectionDispose(conLoadBranch)

    End Sub



    Private Sub AddPaymentType()
        cmbPayType.Items.Add("Cash")
        cmbPayType.Items.Add("Cheque")
        cmbPayType.Items.Add("Bank Draft")
        cmbPayType.Items.Add("DD")
        cmbPayType.Items.Add("TT")
        cmbPayType.Items.Add("Visa Card")
        cmbPayType.Items.Add("Master Card")
        cmbPayType.Items.Add("Others")



    End Sub





    Private Sub FrmAdvance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CenterForm(Me)
        AddPaymentType()
        LoadBranch()

        DisableField()
    End Sub

    Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click
        strNewEdit = "New"

        EnabledField()
        cmdEdit.Enabled = False
        cmdDelete.Enabled = False

        txtMR.Select()
        cmdSave.Text = "&Save"

        cmbPayType.Text = cmbPayType.Items(0)
        GetDefaultBranchName()

    End Sub

    Private Sub txtMR_TextChanged(sender As Object, e As EventArgs) Handles txtMR.TextChanged

        If txtMR.TextLength = 0 Then
            If lstJobMR.Visible = True Then
                lstJobMR.Visible = False
                Exit Sub

            End If
        End If



        If strNewEdit = "Edit" Then
            If strKeepJobNo = "" Then
                If RecordVerification(strProvider, "AdvanceInfo", "AdvanceInfo.JobCode='" & txtJobCode.Text & "'") = False Then
                    MsgBox("Money Receipt No Not Found", vbInformation, "Search Unsuccessfull")
                    txtMR.Select()
                    Exit Sub
                End If
            End If
        End If




        If strNewEdit = "Edit" Then
            LoadJobMRList(txtMR.Text, 1)
            lstJobMR.Left = txtMR.Left
            lstJobMR.Top = txtMR.Top + txtMR.Height + 2

        End If

    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        strNewEdit = "Edit"


        EnabledField()

        cmdNew.Enabled = False


        txtMR.Select()
        cmdSave.Text = "&Update"
        GetDefaultBranchName()
    End Sub


    Private Sub LoadJobMRList(ByVal strJobMR As String, ByVal shrtDefined As Short)

        Dim drLoadJobMR As OleDbDataReader = Nothing
        Dim lstJobMRList As ListViewItem
        Dim conJobMRLIst As New OleDbConnection(strProvider)
        lstJobMR.Visible = True

        lstJobMR.Items.Clear()

        If strNewEdit = "New" Then
            LoadAllInformation(conJobMRLIst, drLoadJobMR, strProvider, "Claiminfo", "Claiminfo.JobCode", "left(Claiminfo.JobCOde," & strJobMR.Length & ")='" & strJobMR & "' and Claiminfo.Branch='" & cmbBranch.Text & "'")
        Else
            If shrtDefined = 1 Then
                LoadAllInformation(conJobMRLIst, drLoadJobMR, strProvider, "AdvanceInfo Inner Join Claiminfo on Advanceinfo.JobCode=Claiminfo.JobCOde", "AdvanceInfo.JobCOde,AdvanceInfo.AdvNo", "left(AdvanceInfo.AdvNo," & strJobMR.Length & ")='" & strJobMR & "' and AdvanceInfo.Branch='" & cmbBranch.Text & "'")
            ElseIf shrtDefined = 2 Then
                LoadAllInformation(conJobMRLIst, drLoadJobMR, strProvider, "AdvanceInfo Inner Join Claiminfo on Advanceinfo.JobCode=Claiminfo.JobCOde", "AdvanceInfo.JobCOde,AdvanceInfo.AdvNo", "left(AdvanceInfo.JobCOde," & strJobMR.Length & ")='" & strJobMR & "' and AdvanceInfo.Branch='" & cmbBranch.Text & "'")
            End If
        End If


        If drLoadJobMR.HasRows = True Then
            While drLoadJobMR.Read
                lstJobMRList = lstJobMR.Items.Add(lstJobMR.Items.Count + 1)
                lstJobMRList.SubItems.Add(drLoadJobMR("JobCode").ToString)
                If strNewEdit = "Edit" Then
                    lstJobMRList.SubItems.Add(drLoadJobMR("AdvNo").ToString)
                End If
            End While
        Else
            lstJobMR.Visible = False

        End If




        TempConnectionDispose(conJobMRLIst)




    End Sub

    Private Sub txtJobCode_TextChanged(sender As Object, e As EventArgs) Handles txtJobCode.TextChanged




        If txtJobCode.TextLength = 0 Then
            If lstJobMR.Visible = True Then
                lstJobMR.Visible = False
                Exit Sub
            End If
        End If

        If strNewEdit = "Edit" Then
            LoadJobMRList(txtJobCode.Text, 2)
        Else
            LoadJobMRList(txtJobCode.Text, 2)
        End If

        lstJobMR.Left = txtJobCode.Left
        lstJobMR.Top = txtJobCode.Top + txtJobCode.Height + 2

    End Sub

    Private Sub txtMR_Leave(sender As Object, e As EventArgs) Handles txtMR.Leave

        If blnListFlag = True Then
            If lstJobMR.Visible = True Then
                lstJobMR.Visible = False
            End If
        End If






    End Sub

    Private Sub txtJobCode_Leave(sender As Object, e As EventArgs) Handles txtJobCode.Leave



        If blnListFlag = True Then
            If lstJobMR.Visible = True Then
                lstJobMR.Visible = False
            End If
        End If

        If lstJobMR.Visible = False Then
            If strNewEdit = "Edit" Then
                If strKeepJobNo = "" Then
                    If RecordVerification(strProvider, "AdvanceInfo", "AdvanceInfo.JobCode='" & txtJobCode.Text & "'") = False Then
                        MsgBox("Job No Not Found", vbInformation, "Search Unsuccessfull")
                        txtJobCode.Select()
                        Exit Sub
                    End If
                End If
            End If

        End If

        If RecordVerification(strProvider, "AdvanceInfo", "AdvanceInfo.JobCOde='" & txtJobCode.Text & "'") = True Then
            PicJobNotification.Image = Image.FromFile("e:\Software\My software\Visual Studio 2015 Projct\Service Software\Service Software\Resources\ExclamationMark.JPG")


        Else
            PicJobNotification.Image = Nothing
        End If

    End Sub


    Private Sub DuplicateAdvanceJob(ByVal strJobCode As String)
        Dim conDuplicateAdvanceJob As New OleDbConnection(strProvider)

        Dim drDuplicateJob As OleDbDataReader = Nothing
        LoadAllInformation(conDuplicateAdvanceJob, drDuplicateJob, strProvider, "AdvanceInfo", "AdvanceInfo.AdvNo,AdvanceInfo.advamnt", "AdvanceInfo.JobCode='" & strJobCode & "'")
        Dim strMRNo As String = String.Empty
        Dim strAmount As String = String.Empty


        If drDuplicateJob.HasRows = True Then
            While drDuplicateJob.Read

                strMRNo = strMRNo & drDuplicateJob("advNo").ToString & ", "
                strAmount = strAmount & drDuplicateJob("Advamnt").ToString & ", "
            End While


        End If



        ToolTip.SetToolTip(PicJobNotification, "MRNO : (" & strMRNo & ")" & "Amount : (" & strAmount & ")")



        TempConnectionDispose(conDuplicateAdvanceJob)


    End Sub

    Private Sub PicJobNotification_Click(sender As Object, e As EventArgs) Handles PicJobNotification.Click
        DuplicateAdvanceJob(txtJobCode.Text)

    End Sub



    Private Sub txtJobCode_KeyUp(sender As Object, e As KeyEventArgs) Handles txtJobCode.KeyUp
        If e.KeyCode = Keys.Down Then
            If lstJobMR.Items.Count > 0 Then
                lstJobMR.Select()
                lstJobMR.Items(0).Selected = True
            End If


        End If
    End Sub

    Private Sub txtMR_KeyUp(sender As Object, e As KeyEventArgs) Handles txtMR.KeyUp
        If e.KeyCode = Keys.Down Then
            If lstJobMR.Items.Count > 0 Then
                blnListFlag = False

                lstJobMR.Select()
                lstJobMR.Items(0).Selected = True
            End If
        End If

    End Sub

    Private Sub lstJobMR_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstJobMR.SelectedIndexChanged


    End Sub

    Private Sub lstJobMR_KeyUp(sender As Object, e As KeyEventArgs) Handles lstJobMR.KeyUp
        Dim lstItem As ListViewItem = Nothing



        If e.KeyCode = Keys.Enter Then

            lstItem = lstJobMR.Items(lstJobMR.FocusedItem.Index)

            txtJobCode.Text = lstItem.SubItems(1).Text

            If strNewEdit = "Edit" Then
                txtMR.Text = lstItem.SubItems(2).Text
            End If

            If strNewEdit = "Edit" Then
                strKeepMrNo = txtMR.Text
                strKeepJobNo = txtJobCode.Text

            End If

            lstJobMR.Visible = False
            LoadInformation(txtJobCode.Text)
        End If





    End Sub




    Private Sub LoadInformation(ByVal StrJobCode As String)


        Dim drLoadInformation As OleDbDataReader = Nothing
        Dim conLoadInformation As New OleDbConnection(strProvider)



        If strNewEdit = "New" Then
            LoadAllInformation(conLoadInformation, drLoadInformation, strProvider, "Claiminfo", "Claiminfo.JobCode,Claiminfo.CustName,Claiminfo.CustAddress1,Claiminfo.CustAddress2,Claiminfo.ModelNo,Claiminfo.SLNo,Claiminfo.ReceptDate", "Claiminfo.JobCOde='" & txtJobCode.Text & "' and Claiminfo.Branch='" & cmbBranch.Text & "'")
        Else
            LoadAllInformation(conLoadInformation, drLoadInformation, strProvider, "Claiminfo Inner Join Advanceinfo on CLaiminfo.JobCOde=Advanceinfo.JobCOde", "Claiminfo.JobCode,Claiminfo.CustName,Claiminfo.CustAddress1,Claiminfo.CustAddress2,Claiminfo.ModelNo,Claiminfo.SLNo,Claiminfo.ReceptDate,advanceinfo.AdvDate,advanceinfo.AdvAmnt,advanceinfo.Branch,advanceinfo.PayType,advanceinfo.BankName,advanceinfo.CardNo,advanceinfo.advRemarks", "advanceinfo.JobCOde='" & txtJobCode.Text & "' and Advanceinfo.advNo='" & txtMR.Text & "' and advanceinfo.Branch='" & cmbBranch.Text & "'")
        End If



        If drLoadInformation.HasRows = True Then
            While drLoadInformation.Read
                txtJobCode.Text = drLoadInformation("JobCOde").ToString
                txtCustomerName.Text = drLoadInformation("CustName").ToString
                txtAddress.Text = drLoadInformation("CustAddress1").ToString
                txtPhone.Text = drLoadInformation("CustAddress2").ToString
                txtModelNo.Text = drLoadInformation("ModelNo").ToString
                txtSLNo.Text = drLoadInformation("SlNo").ToString
                txtReceiveDate.Text = drLoadInformation("ReceptDate").ToString
                If strNewEdit = "Edit" Then
                    cmbPayType.Text = drLoadInformation("PayType").ToString
                    txtPayment.Text = drLoadInformation("AdvAmnt").ToString

                    dtpPaymentDate.Value = drLoadInformation("AdvDate").ToString
                    txtChecque.Text = drLoadInformation("CardNo").ToString
                    txtBankName.Text = drLoadInformation("BankName").ToString
                    txtRemarks.Text = drLoadInformation("AdvRemarks").ToString
                End If
            End While
        End If

        TempConnectionDispose(conLoadInformation)


    End Sub

    Private Sub cmbPayType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPayType.SelectedIndexChanged
        If cmbPayType.Text <> "Cash" Then
            txtChecque.Enabled = True
            txtBankName.Enabled = True
        Else
            txtChecque.Enabled = False
            txtBankName.Enabled = False
            txtBankName.Text = String.Empty
            txtChecque.Text = String.Empty

        End If
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If RecordVerification(strProvider, "Advanceinfo", "Advanceinfo.JobCode='" & txtJobCode.Text & "' and Advanceinfo.advNo='" & txtMR.Text & "'") = True Then
            If MsgBox("Do you want delete this MR Record", vbYesNo, "Advance Record") = vbYes Then
                DeleteRecord("Advanceinfo", "Advanceinfo.advNo='" & txtMR.Text & "' and Advanceinfo.JobCOde='" & txtJobCode.Text & "'", "OFF")
            End If

            UpdateAdvance(txtJobCode.Text)
            MsgBox("Record Deleted Successfully", vbInformation, "Successfully Deleted")
            ClearField()
        End If
    End Sub






    Private Sub UpdateAdvance(ByVal strUpdateJob As String)
        Dim drUpdateAdvanceAmount As OleDbDataReader = Nothing
        Dim conUpdateAdvance As New OleDbConnection(strProvider)

        If RecordVerification(strProvider, "Advanceinfo", "Advanceinfo.JobCode='" & strUpdateJob & "'") = True Then
            LoadAllInformation(conUpdateAdvance, drUpdateAdvanceAmount, strProvider, "Advanceinfo", "sum(Advamnt) as AdvanceAmount", "Advanceinfo.JobCode='" & strUpdateJob & "'")

            If drUpdateAdvanceAmount.HasRows = True Then
                drUpdateAdvanceAmount.Read()
                UpdateRecords("Advanceamnt", Convert.ToInt32(drUpdateAdvanceAmount("AdvanceAmount").ToString), "Claiminfo", "Claiminfo.JobCOde='" & strUpdateJob & "'")
            End If

        Else
            UpdateRecords("Advanceamnt", 0, "Claiminfo", "Claiminfo.JobCOde='" & strUpdateJob & "'")
        End If


        TempDatareaderClose(drUpdateAdvanceAmount)

        TempConnectionDispose(conUpdateAdvance)

    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click

        Try




            If strNewEdit = "New" Then

                If ActiveUser.UserType.ToLower = LCase("User") Then
                    If Not ActiveUser.Ins = True Then
                        MessageBox.Show("User is not permitted to Insert New Record")
                        Exit Sub
                    End If
                End If

                If cmbPayType.Text = "Cash" Then
                    InsertNewRecord(strProvider, "Advanceinfo", "JobCode,Branch,advNo,advDate,advamnt,advremarks,Paytype", "'" & txtJobCode.Text & "','" & cmbBranch.Text & "','" & txtMR.Text & "',#" & dtpPaymentDate.Value.ToShortDateString & "#," & Convert.ToInt32(txtPayment.Text) & ",'" & txtRemarks.Text & "','" & cmbPayType.Text & "'")
                Else

                    InsertNewRecord(strProvider, "Advanceinfo", "JobCode,Branch,advNo,advDate,advamnt,advremarks,Paytype,BankName,CardNo", "'" & txtJobCode.Text & "','" & cmbBranch.Text & "','" & txtMR.Text & "',#" & dtpPaymentDate.Value.ToShortDateString & "#," & Convert.ToInt32(txtPayment.Text) & ",'" & txtRemarks.Text & "','" & cmbPayType.Text & "','" & txtBankName.Text & "','" & txtChecque.Text & "'")
                End If

            ElseIf strNewEdit = "Edit" Then

                If ActiveUser.UserType.ToLower = LCase("User") Then
                    If Not ActiveUser.Upd = True Then
                        MessageBox.Show("User is not permitted to Update Record")
                        Exit Sub

                    End If
                End If

                If cmbPayType.Text = "Cash" Then
                    If strKeepJobNo <> "" Or strKeepMrNo <> "" Then
                        UpdateRecords("JobCode,Branch,advNo,advDate,advamnt,advremarks,Paytype", "'" & txtJobCode.Text & "','" & cmbBranch.Text & "','" & txtMR.Text & "',#" & dtpPaymentDate.Value.ToShortDateString & "#," & Convert.ToInt32(txtPayment.Text) & ",'" & txtRemarks.Text & "','" & cmbPayType.Text & "'", "Advanceinfo", "Advanceinfo.JobCOde='" & strKeepJobNo & "' and Advanceinfo.advNo='" & strKeepMrNo & "'")
                    Else
                        UpdateRecords("JobCode,Branch,advNo,advDate,advamnt,advremarks,Paytype", "'" & txtJobCode.Text & "','" & cmbBranch.Text & "','" & txtMR.Text & "',#" & dtpPaymentDate.Value.ToShortDateString & "#," & Convert.ToInt32(txtPayment.Text) & ",'" & txtRemarks.Text & "','" & cmbPayType.Text & "'", "Advanceinfo", "Advanceinfo.JobCOde='" & txtJobCode.Text & "' and Advanceinfo.advNo='" & txtMR.Text & "'")
                    End If

                Else
                    If strKeepJobNo <> "" Or strKeepMrNo <> "" Then
                        UpdateRecords("JobCode,Branch,advNo,advDate,advamnt,advremarks,Paytype,BankName,CardNo", "'" & txtJobCode.Text & "','" & cmbBranch.Text & "','" & txtMR.Text & "',#" & dtpPaymentDate.Value.ToShortDateString & "#," & Convert.ToInt32(txtPayment.Text) & ",'" & txtRemarks.Text & "','" & cmbPayType.Text & "','" & txtBankName.Text & "','" & txtChecque.Text & "'", "AdvanceInfo", "Advanceinfo.JobCOde='" & strKeepJobNo & "' and Advanceinfo.advNo='" & strKeepMrNo & "'")
                    Else
                        UpdateRecords("JobCode,Branch,advNo,advDate,advamnt,advremarks,Paytype,BankName,CardNo", "'" & txtJobCode.Text & "','" & cmbBranch.Text & "','" & txtMR.Text & "',#" & dtpPaymentDate.Value.ToShortDateString & "#," & Convert.ToInt32(txtPayment.Text) & ",'" & txtRemarks.Text & "','" & cmbPayType.Text & "','" & txtBankName.Text & "','" & txtChecque.Text & "'", "Advanceinfo", "Advanceinfo.JobCOde='" & txtJobCode.Text & "' and Advanceinfo.advNo='" & txtMR.Text & "'")
                    End If

                End If
            End If
            UpdateAdvance(txtJobCode.Text)
            If strNewEdit = "New" Then
                MsgBox("New Record Insert Successfullt", vbInformation, "Successfull")
            Else
                MsgBox(" Record is Updated Successfullt", vbInformation, "Successfull")
            End If
            DisableField()
            ClearField()
        Catch AdvanceSave As Exception
            MessageBox.Show(AdvanceSave.Message)
        End Try


    End Sub


    Private Sub GetDefaultBranchName()
        cmbBranch.Text = My.Computer.Registry.CurrentUser.OpenSubKey("Software\Company Software\Service").GetValue("Default_Branch")
    End Sub

    Private Sub ClearField()
        txtMR.Text = String.Empty
        txtJobCode.Text = String.Empty
        txtAddress.Text = String.Empty
        txtPhone.Text = String.Empty
        txtReceiveDate.Text = String.Empty
        txtSLNo.Text = String.Empty
        txtModelNo.Text = String.Empty
        txtCustomerName.Text = String.Empty
        txtPayment.Text = "0"
        txtBankName.Text = String.Empty
        txtChecque.Text = String.Empty
        txtRemarks.Text = String.Empty
        PicJobNotification.Image = Nothing

    End Sub

    Private Sub PicJobNotification_MouseHover(sender As Object, e As EventArgs) Handles PicJobNotification.MouseHover
        DuplicateAdvanceJob(txtJobCode.Text)
    End Sub
End Class
