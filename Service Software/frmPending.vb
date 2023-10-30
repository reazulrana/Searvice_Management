Imports System.Data.OleDb


Public Class frmPending
    Dim strGetPendingValue As String = String.Empty




    Private Sub frmPending_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            dtpPending.Value = Now.ToShortDateString
            'If publicClaiminfo.cFlag = 0 Or publicClaiminfo.cFlag = 2 Then
            '    MessageBox.Show("You Can not Save Data because the job is in 'Delivered Mode'")
            '    If ActiveUser.UserType.ToLower = LCase("Admin") Then
            '        chkSavebyforce.Visible = True
            '    Else
            '        chkSavebyforce.Visible = False
            '    End If
            '    Exit Sub
            'ElseIf publicClaiminfo.cFlag = 102 Then
            '    MessageBox.Show("You Can not Save Data because the job is in 'Delivered Mode(Replace)'")
            '    If ActiveUser.UserType.ToLower = LCase("Admin") Then
            '        chkSavebyforce.Visible = True
            '    Else
            '        chkSavebyforce.Visible = False
            '    End If
            '    Exit Sub
            'ElseIf publicClaiminfo.cFlag = 100 Then
            '    MessageBox.Show("You Can not Save Data because the job is in 'Delivered Mode(N/R)'")
            '    If ActiveUser.UserType.ToLower = LCase("Admin") Then
            '        chkSavebyforce.Visible = True
            '    Else
            '        chkSavebyforce.Visible = False
            '    End If
            '    Exit Sub
            'End If

            'If Not IsNothing(ActiveControl) Then





            '    If publicClaiminfo.cFlag = 9 Then
            '        If ActiveUser.UserType.ToLower = LCase("Admin") Then
            '            chkSavebyforce.Visible = True
            '        Else
            '            chkSavebyforce.Visible = False
            '        End If

            '    Else
            '        chkSavebyforce.Visible = False
            'End If

            'End If



            CenterForm(Me)
            LoadAllCode()
            txtPendingOthers.Enabled = False
            If publicClaiminfo.cFlag = 9 Then
                LoadPendingReason()
            End If

            

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error Event: frmPending_Load")
        End Try


    End Sub

    Public Sub LoadAllCode()
        Dim employeemethods As clsPersonalMethods = New clsPersonalMethods
        Dim AllEmployee As List(Of clsPersonal) = employeemethods.LoadTechnician().ToList


        For Each tmpemp As clsPersonal In AllEmployee
            cmbPendingCode.Items.Add(tmpemp.EmpCode)

        Next
    End Sub


    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdPendingClose.Click
        Me.Close()

    End Sub

    Private Sub frmPending_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        cmdPendingSave.Left = grpPendingDescription.Left
        cmdPendingSave.Width = grpPendingDescription.Width / 2
        cmdPendingClose.Left = cmdPendingSave.Left + cmdPendingSave.Width
        cmdPendingClose.Width = grpPendingDescription.Width / 2

    End Sub

    Private Sub cmbPendingCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPendingCode.SelectedIndexChanged
        Dim empMethods As clsPersonalMethods = New clsPersonalMethods

        Dim emp As List(Of clsPersonal) = empMethods.LoadTechnician(cmbPendingCode.Text)
        If emp.Count > 0 Then
            For Each employee As clsPersonal In emp
                lblPendingEmployeeName.Text = employee.EmpName
            Next

        Else
            lblPendingEmployeeName.Text = "Code Not Found"
        End If

    End Sub

    Private Sub cmbPendingCode_LostFocus(sender As Object, e As EventArgs) Handles cmbPendingCode.LostFocus
        cmbPendingCode_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub cmdPendingSave_Click(sender As Object, e As EventArgs) Handles cmdPendingSave.Click

        'If publicClaiminfo.cFlag = 0 Or publicClaiminfo.cFlag = 2 Then
        '    MessageBox.Show("You Can not Save Data because the job is in 'Delivered Mode'")
        '    Exit Sub
        'ElseIf publicClaiminfo.cFlag = 102 Then
        '    MessageBox.Show("You Can not Save Data because the job is in 'Delivered Mode(Replace)'")
        '    Exit Sub
        'ElseIf publicClaiminfo.cFlag = 100 Then
        '    MessageBox.Show("You Can not Save Data because the job is in 'Delivered Mode(N/R)'")
        '    Exit Sub
        'End If

        'If Not IsNothing(ActiveUser) Then
        '    If publicClaiminfo.cFlag = 9 Then
        '        If ActiveUser.UserType.ToLower = LCase("Admin") Then
        '            If chkSavebyforce.Checked = False Then
        '                MessageBox.Show("The Job can not update untli tick check box")
        '                Exit Sub
        '            End If
        '        Else
        '            MessageBox.Show("You do not have permission of udatedaing delivery Product")
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

        Dim pendingMethods As clsPendingMethods = New clsPendingMethods
        Dim pending As clsPending = New clsPending
        Dim EstMethods As clsEstimateRefusedMethods = New clsEstimateRefusedMethods
        Dim estRefuse As clsEstimateRefused = EstMethods.GetEstimateRefuse(publicClaiminfo.Jobcode)
        Dim nrDetails As clsNrdetailsMethods = New clsNrdetailsMethods
        Dim nrDetailsJob As clsNrdetails = nrDetails.GetNR(publicClaiminfo.Jobcode)
        Dim serviceDetails As clsServiceDetailsMethods = New clsServiceDetailsMethods
        Dim serviceDetailsJob As clsServiceDetails = serviceDetails.GetPartsDetails(publicClaiminfo.Jobcode)
        Dim empMethods As clsPersonalMethods = New clsPersonalMethods
        Dim empList As List(Of clsPersonal) = empMethods.LoadTechnician(cmbPendingCode.Text).ToList




        If dtpPending.Value.Subtract(dtReceiveDate).TotalDays < 0 Then
            MessageBox.Show("'Assign Date' is Greater Than 'Pending Date'" & vbNewLine & "Receive Date = #" & dtReceiveDate.ToShortDateString & "# Pending Date= #" & dtpPending.Value.ToShortDateString & "#")
            Exit Sub
        End If


        If empList.Count <> 1 Then
            MessageBox.Show("Code is not found in the datavase")
            Exit Sub
        ElseIf Convert.ToDateTime(publicClaiminfo.ReceptDate.ToShortDateString) > Convert.ToDateTime(dtpPending.Value.ToShortDateString) Then
            MessageBox.Show("Receive Date is Greater Than Repair Date ")
            Exit Sub
        End If





        Try


            Dim strPending As String = String.Empty

            If chkWaitingforServiceManual.Checked = True Then
                strPending += chkWaitingforServiceManual.Text & ","
            End If

            If chkWatingForParts.Checked = True Then
                strPending += chkWatingForParts.Text & ","
            End If

            If chkTechnicalProblem.Checked = True Then
                strPending += chkTechnicalProblem.Text & ","
            End If


            If chkTechnicalHelp.Checked = True Then
                strPending += chkTechnicalHelp.Text & ","
            End If

            If chkUnderEstimate.Checked = True Then
                strPending += chkUnderEstimate.Text & ","
            End If

            If chkOthers.Checked = True Then
                If Not String.IsNullOrEmpty(txtPendingOthers.Text) Then
                    strPending += txtPendingOthers.Text & ","
                End If
            Else
            End If
            If strPending.Length > 0 Then

                If strPending.Substring(strPending.Length - 1) = "," Then
                strPending = strPending.Substring(0, strPending.Length - 1)
            End If

            End If

            pending.JobCode = publicClaiminfo.Jobcode.ToString
            pending.PenCode = strPending

            Dim claiminfoMethods As clsClaiminfoMethods = New clsClaiminfoMethods
            Dim claiminfo As clsClaiminfo = New clsClaiminfo

            Dim intCFlag As Integer = Convert.ToInt32(publicClaiminfo.cFlag.ToString)

            claiminfo = publicClaiminfo

            claiminfo.Jobcode = publicClaiminfo.Jobcode
            claiminfo.ServiceBy = cmbPendingCode.Text
            claiminfo.SDate = dtpPending.Value.ToShortDateString
            claiminfo.cFlag = 9
            claiminfo.MRNO = ""
            claiminfo.SvAmt = Integer.Parse("0")
            claiminfo.PrdAmt = Integer.Parse("0")
            claiminfo.OtherAmt = Integer.Parse("0")
            claiminfo.Dis = Integer.Parse("0")


            claiminfoMethods.updateclaiminfo(claiminfo, publicClaiminfo.Jobcode)



            Dim verifyPending As clsPending = pendingMethods.GetPending(claiminfo.Jobcode)

            If IsNothing(verifyPending.JobCode) Then
                pendingMethods.save(pending)
                MessageBox.Show("Save Record Successfully")
            Else
                pendingMethods.Update(pending, publicClaiminfo.Jobcode.ToString)
                MessageBox.Show("Update Record Successfully")
            End If

            If Not IsNothing(estRefuse.JobCode) Then
                EstMethods.Delete(estRefuse.JobCode)
            End If

            If Not IsNothing(serviceDetailsJob.Jobcode) Then
                serviceDetails.Delete(serviceDetailsJob.Jobcode)
            End If

            If Not IsNothing(nrDetailsJob.JobCode) Then
                nrDetails.Delete(nrDetailsJob.JobCode)
            End If



            Dim Mail As clsOptionMethods = New clsOptionMethods

            If Mail.IsExistMail = True Then
                If Mail.IsMailActive = True Then
                    SendNRMail(strPending)
                Else
                    If MessageBox.Show("Mail is not active", "Do you want set mail", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                        Dim optionForm As frmOption = New frmOption


                        optionForm.strTabName = "Mail"
                        optionForm.ShowDialog()
                        SendNRMail(strPending)

                    End If
                End If


            Else

                MessageBox.Show("No Email found")

            End If





            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try


    End Sub





    Private Sub SendNRMail(ByVal strNRReason As String)

        Dim strBody As String = String.Empty
        Dim myNetwork As clsNetwork = New clsNetwork

        Dim mailMethods As clsOptionMethods = New clsOptionMethods
        Dim mail As clsOption = mailMethods.GetActiveMail
        Dim aMail As clsMail = New clsMail 'aMail = Active Mail

        Dim security As clsSecurity = New clsSecurity

        Dim AuditMethods As clsJobAuditMethods = New clsJobAuditMethods
        Dim ListAudit As List(Of clsJobAudit) = New List(Of clsJobAudit)
        Dim strMailArray As String = String.Empty
        Dim AuditMail As clsMail = New clsMail



#Region "Audit Mail Section"


        ' ___________________________________________ Audit Mail Section _______________________________________________________________



        If AuditMethods.HasRow = True Then
            ListAudit = AuditMethods.GetAuditList.Where(Function(x) x.Pending = True).ToList

            If ListAudit.Count > 0 Then
                For Each Audit As clsJobAudit In ListAudit
                    If myNetwork.VerifyMail(Audit.MailNo) = True Then
                        strMailArray += Audit.MailNo & ","
                    End If
                Next



                If strMailArray.Length > 0 Then
                    If strMailArray.Substring(strMailArray.Length - 1) = "," Then
                        strMailArray = strMailArray.Substring(0, strMailArray.Length - 1)
                    End If
                End If




                Dim strAudit As String = String.Empty

                ' Audit Mail Section

                If publicClaiminfo.WCondition = 1 Then


                    strAudit = strAudit & "Job No: '" & publicClaiminfo.Jobcode & "'," & vbNewLine
                    strAudit = strAudit & "Delivery Branch: '" & publicClaiminfo.Branch & "'," & vbNewLine
                    strAudit = strAudit & " Mailing Date : " & Now() & vbNewLine
                    strAudit = strAudit & " Type of Warranty : Non Warranty" & vbNewLine
                    strAudit = strAudit & " Reason for Pending : " & strNRReason & vbNewLine
                    strAudit = strAudit & " Pending By : " & lblPendingEmployeeName.Text & vbNewLine
                    strAudit = strAudit & " Product Status :  Pending)" & vbNewLine
                Else

                    strAudit = strAudit & " Product Status : Pending )"
                    strAudit = strAudit & "Job No: '" & publicClaiminfo.Jobcode & "'," & vbNewLine
                    strAudit = strAudit & "Delivery Branch: '" & publicClaiminfo.Branch & "'," & vbNewLine
                    If publicClaiminfo.WCondition = 0 Then
                        strAudit = strAudit & " Type of Warranty : Sales Warranty" & vbNewLine
                    Else
                        strAudit = strAudit & " Type of Warranty : Service Warranty" & vbNewLine
                    End If

                    strAudit = strAudit & " Pending Date : " & dtpPending.Value.ToShortDateString & vbNewLine
                    strAudit = strAudit & " Reason for Pending : " & strNRReason & vbNewLine
                    strAudit = strAudit & " Pending by : " & lblPendingEmployeeName.Text & vbNewLine

                    strAudit = strAudit & " Mailing Date : " & Now() & vbNewLine
                End If




                AuditMail.MailID = mail.MailFrom
                AuditMail.Password = mail.Crediantial
                AuditMail.SMTP = mail.SMTP
                AuditMail.PORT = mail.Port
                AuditMail.SSL = mail.SSL
                AuditMail.MailTo = strMailArray
                AuditMail.Body = strAudit
                AuditMail.Subject = "Pending Status"
                AuditMail.From = mail.MailFrom
                With myNetwork
                    If .isInternet = True Then
                        .SendMail(AuditMail, False)
                    End If


                End With
            End If
        End If


#End Region
    End Sub



    Private Sub chkOthers_CheckedChanged(sender As Object, e As EventArgs) Handles chkOthers.CheckedChanged
        If chkOthers.Checked = True Then
            txtPendingOthers.Enabled = True
            txtPendingOthers.Select()

        Else

            If txtPendingOthers.Text <> "" Then
                If MessageBox.Show("Other Filed will lost data", "Warning", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    txtPendingOthers.Text = ""
                End If
            End If
            txtPendingOthers.Enabled = False
            GetPendingValue()

        End If
    End Sub


    Private Sub LoadPendingReason()


        Dim empMethods As clsPersonalMethods = New clsPersonalMethods

        Dim lstEmp As List(Of clsPersonal) = empMethods.LoadTechnician(publicClaiminfo.ServiceBy)
        If empMethods.IsExist(publicClaiminfo.ServiceBy) = True Then

            For Each emp As clsPersonal In lstEmp
            cmbPendingCode.Text = emp.EmpCode
            lblPendingEmployeeName.Text = emp.EmpName
            dtpPending.Value = publicClaiminfo.SDate.ToShortDateString
        Next

        End If
        Dim pendingmethods As clsPendingMethods = New clsPendingMethods()

        If pendingmethods.IsExist(publicClaiminfo.Jobcode.ToString) = False Then
            Exit Sub

        End If
        Dim pending = pendingmethods.GetPending(publicClaiminfo.Jobcode.ToString)


        If not IsNothing(pending) Then
            Dim strPendingList() As String = pending.PenCode.Split(",")





            For Each tempPending As String In strPendingList

                If tempPending.ToString.ToLower = chkWatingForParts.Text.ToLower Then
                    chkWatingForParts.Checked = True

                ElseIf tempPending.ToString = chkWaitingforServiceManual.Text Then
                    chkWaitingforServiceManual.Checked = True


                ElseIf tempPending.ToString = chkWaitingforServiceManual.Text Then
                    chkWaitingforServiceManual.Checked = True


                ElseIf tempPending.ToString = chkTechnicalProblem.Text Then
                    chkTechnicalProblem.Checked = True


                ElseIf tempPending.ToString = chkTechnicalHelp.Text Then
                    chkTechnicalHelp.Checked = True


                ElseIf tempPending.ToString = chkUnderEstimate.Text Then
                    chkUnderEstimate.Checked = True

                Else
                    txtPendingOthers.Text = tempPending.ToString
                End If

            Next

        End If









    End Sub









    Private Sub GetPendingValue()

        strGetPendingValue = String.Empty



        If chkWaitingforServiceManual.Checked = True Then
            strGetPendingValue += chkWaitingforServiceManual.Text & ":"
        End If



        If chkWatingForParts.Checked = True Then
            strGetPendingValue += chkWatingForParts.Text & ":"
        End If



        If chkTechnicalProblem.Checked = True Then
            strGetPendingValue += chkTechnicalProblem.Text & ":"
        End If


        If chkTechnicalHelp.Checked = True Then
            strGetPendingValue += chkTechnicalHelp.Text & ":"
        End If


        If chkUnderEstimate.Checked = True Then
            strGetPendingValue += chkUnderEstimate.Text & ":"
        End If


        If chkOthers.Checked = True Then
            strGetPendingValue += txtPendingOthers.Text & ":"
        End If












    End Sub

    Private Sub chkWaitingforServiceManual_CheckedChanged(sender As Object, e As EventArgs) Handles chkWaitingforServiceManual.CheckedChanged
        GetPendingValue()
    End Sub

    Private Sub chkWatingForParts_CheckedChanged(sender As Object, e As EventArgs) Handles chkWatingForParts.CheckedChanged
        GetPendingValue()
    End Sub

    Private Sub chkTechnicalProblem_CheckedChanged(sender As Object, e As EventArgs) Handles chkTechnicalProblem.CheckedChanged
        GetPendingValue()
    End Sub

    Private Sub chkTechnicalHelp_CheckedChanged(sender As Object, e As EventArgs) Handles chkTechnicalHelp.CheckedChanged
        GetPendingValue()
    End Sub

    Private Sub chkUnderEstimate_CheckedChanged(sender As Object, e As EventArgs) Handles chkUnderEstimate.CheckedChanged
        GetPendingValue()
    End Sub


    Private Sub txtPendingOthers_Leave(sender As Object, e As EventArgs) Handles txtPendingOthers.Leave
        GetPendingValue()
    End Sub

    Private Sub txtPendingOthers_TextChanged(sender As Object, e As EventArgs) Handles txtPendingOthers.TextChanged

    End Sub

    Private Sub txtPendingOthers_MouseMove(sender As Object, e As MouseEventArgs) Handles txtPendingOthers.MouseMove

    End Sub

    Private Sub txtPendingOthers_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPendingOthers.KeyPress
        Dim tempToolTip As New ToolTip

        If RemoveCharacter(e.KeyChar) = True Then
            e.Handled = True
            tempToolTip.Show(":',.?/|\*&^%$#@!~`}]{[;><=+""", txtPendingOthers, 2000)
        End If




    End Sub

    Private Sub cmbPendingCode_KeyUp(sender As Object, e As KeyEventArgs) Handles cmbPendingCode.KeyUp
        If e.KeyCode = Keys.Enter Then
            dtpPending.Select()
        End If
    End Sub

    Private Sub dtpPending_ValueChanged(sender As Object, e As EventArgs) Handles dtpPending.ValueChanged

    End Sub

    Private Sub dtpPending_KeyUp(sender As Object, e As KeyEventArgs) Handles dtpPending.KeyUp
        If e.KeyCode = Keys.Enter Then
            cmdPendingSave.Select()
        End If
    End Sub
End Class