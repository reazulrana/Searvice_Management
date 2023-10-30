Imports System.Data.OleDb




Public Class frmAbort
    Dim intCount As Integer
    Dim strNrCode As String
    Dim NrEr As String 'Not Repairable and Estimate Refuse
    Dim estrefusemethods As clsEstimateRefusedMethods = New clsEstimateRefusedMethods
    Dim estrefuse As clsEstimateRefused = New clsEstimateRefused

    Private Sub frmAbort_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try


            CenterForm(Me)
            chkEstimateRefuse.Checked = False
            EnableControl()


            'If publicClaiminfo.cFlag = 0 Or publicClaiminfo.cFlag = 2 Then
            '    MessageBox.Show("You Can not open the job Because The Job is delivered ('Delivered Mode')")
            '    If ActiveUser.UserType.ToLower = LCase("Admin") Then
            '        chkSavebyforce.Visible = True
            '    Else
            '        chkSavebyforce.Visible = False
            '    End If
            '    Exit Sub
            'ElseIf publicClaiminfo.cFlag = 102 Then
            '    MessageBox.Show("You Can not open the job Because The Job is delivered ('Replace Delivered Mode')")
            '    If ActiveUser.UserType.ToLower = LCase("Admin") Then
            '        chkSavebyforce.Visible = True
            '    Else
            '        chkSavebyforce.Visible = False
            '    End If
            '    Exit Sub
            'End If

            'If publicClaiminfo.cFlag = 100 Then
            '    If ActiveUser.UserType.ToLower = LCase("Admin") Then
            '        chkSavebyforce.Visible = True
            '    Else
            '        chkSavebyforce.Visible = False
            '    End If

            'ElseIf publicClaiminfo.cFlag = 99 Then
            '    If ActiveUser.UserType.ToLower = LCase("Admin") Then
            '        chkSavebyforce.Visible = True
            '    Else
            '        chkSavebyforce.Visible = False
            '    End If
            'Else
            '    chkSavebyforce.Visible = False
            'End If






            estrefuse = estrefusemethods.GetEstimateRefuse(publicClaiminfo.Jobcode)


            NrEr = "Nr"
            Dim strcFlag As String = publicClaiminfo.cFlag.ToString
            Dim MrNo As String = publicClaiminfo.MRNO


            LoadTechnician()
            If strcFlag = "99" Or strcFlag = "100" Then

                LoadNrDetails()
            ElseIf Not IsNothing(estrefuse.JobCode) Then
                LoadEstimateRefuse()



            End If









        Catch ex As Exception
            MessageBox.Show(ex.Message)
            If MsgBox("Do want to quit the NR Section", vbYesNo) = vbYes Then
                Me.Close()
            End If


        End Try



    End Sub


    Private Sub LoadEstimateRefuse()

        Dim strtempJobCode As String = publicClaiminfo.Jobcode

        Dim EstMethod As clsEstimateRefusedMethods = New clsEstimateRefusedMethods

        If EstMethod.IsExist(strtempJobCode) = False Then
            Exit Sub
        End If

        Dim estmateRefuse As clsEstimateRefused = EstMethod.GetEstimateRefuse(strtempJobCode)
        txtAbortOthers.Text = estmateRefuse.EstText
        txtRefuseAmount.Text = Integer.Parse(estmateRefuse.RefuseAmnt)
        cmbAbortedby.Text = estmateRefuse.ServiceBy_ID
        dtpAbort.Value = estmateRefuse.EstDate.ToShortDateString


    End Sub

    Public Sub saveNr(ByVal blnSendMail As Boolean)

        Dim cFlag As String = String.Empty


        Dim strNrDetails As String = String.Empty

        If chkPCBDamage.Checked = True Then
            strNrDetails += chkPCBDamage.Text & ","
        End If



        If chkDropinthewater.Checked = True Then
            strNrDetails += chkDropinthewater.Text & ","
        End If

        If chkDroponthefloor.Checked = True Then
            strNrDetails += chkDroponthefloor.Text & ","
        End If

        If chkConnectAnotherCharger.Checked = True Then
            strNrDetails += chkConnectAnotherCharger.Text & ","
        End If

        If chkPCBCrack.Checked = True Then
            strNrDetails += chkPCBCrack.Text & ","
        End If

        If chkSoftwareProblem.Checked = True Then
            strNrDetails += chkSoftwareProblem.Text & ","
        End If

        If chkUnavilableParts.Checked = True Then
            strNrDetails += chkUnavilableParts.Text & ","
        End If

        If chkTechnicalProblem.Checked = True Then
            strNrDetails += chkTechnicalProblem.Text & ","
        End If

        If chkSetLock.Checked = True Then
            strNrDetails += chkSetLock.Text & ","
        End If

        If chkOpenOutside.Checked = True Then
            strNrDetails += chkOpenOutside.Text & ","
        End If


        If chkOthers.Checked = True Then
            If Not String.IsNullOrEmpty(txtAbortOthers.Text) Then
                strNrDetails += txtAbortOthers.Text & ","
            End If

        End If

        If strNrDetails.Length > 0 Then

            If strNrDetails.Substring(strNrDetails.Length - 1) = "," Then
                strNrDetails = strNrDetails.Substring(0, strNrDetails.Length - 1)
            End If

        End If
        Try


            Dim nrdetailsMethods As clsNrdetailsMethods = New clsNrdetailsMethods
            Dim nrdetails As clsNrdetails = New clsNrdetails
            Dim claiminfomethods As clsClaiminfoMethods = New clsClaiminfoMethods
            Dim claiminfo As clsClaiminfo = New clsClaiminfo

            Dim erm As clsEstimateRefusedMethods = New clsEstimateRefusedMethods
            Dim estRef As clsEstimateRefused = erm.GetEstimateRefuse(publicClaiminfo.Jobcode)
            Dim Pending As clsPendingMethods = New clsPendingMethods
            Dim tmpPending As clsPending = Pending.GetPending(publicClaiminfo.Jobcode)
            Dim serviceDetails As clsServiceDetailsMethods = New clsServiceDetailsMethods
            Dim serviceDetailJob As clsServiceDetails = serviceDetails.GetPartsDetails(publicClaiminfo.Jobcode)

            cFlag = publicClaiminfo.cFlag


            claiminfo = publicClaiminfo
            If cFlag = "100" Then
                claiminfo.cFlag = 100
                claiminfo.MRNO = ""
            Else
                claiminfo.cFlag = 99
                claiminfo.MRNO = ""
            End If

            claiminfo.SvAmt = Integer.Parse("0")
            claiminfo.PrdAmt = Integer.Parse("0")
            claiminfo.OtherAmt = Integer.Parse("0")
            claiminfo.Dis = Integer.Parse("0")

            claiminfo.SDate = dtpAbort.Value.ToShortDateString
            claiminfo.ServiceBy = cmbAbortedby.Text
            nrdetails.JobCode = claiminfo.Jobcode
            nrdetails.NRCode = strNrDetails
            claiminfomethods.updateclaiminfo(claiminfo, publicClaiminfo.Jobcode)

            If claiminfo.cFlag = "99" Or claiminfo.cFlag = "100" Then

                Dim verifyNR As clsNrdetails = nrdetailsMethods.GetNR(claiminfo.Jobcode)

                If IsNothing(verifyNR.JobCode) Then
                    nrdetailsMethods.save(nrdetails)
                Else
                    nrdetailsMethods.Update(nrdetails, publicClaiminfo.Jobcode)
                End If

                MessageBox.Show("Record Update Successfully")
            Else

                If Not IsNothing(tmpPending.JobCode) Then
                    Pending.Delete(tmpPending.JobCode)
                End If

                If Not IsNothing(serviceDetailJob.Jobcode) Then
                    serviceDetails.Delete(serviceDetailJob.Jobcode)
                End If

                If serviceDetails.isExist_Temp_ServiceDetails(serviceDetailJob.Jobcode) = True Then
                    serviceDetails.Delete_Temp_ServiceDetails(serviceDetailJob.Jobcode)
                End If

                If Not IsNothing(estrefuse.JobCode) Then
                    erm.Delete(estrefuse.JobCode)
                End If
                MessageBox.Show("Record Save Successfully")
            End If

            If blnSendMail = True Then
                SendNRMail(strNrDetails)
            End If


            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Public Sub SaveEr(ByVal blnSendMail As Boolean)



        Dim intrefuseamant As Single = 0
        If String.IsNullOrEmpty(txtRefuseAmount.Text) Then
            MessageBox.Show("Refuse amount is blank")
            txtRefuseAmount.Select()
            Exit Sub


        ElseIf Integer.TryParse(txtRefuseAmount.Text, intrefuseamant) = False Then

            MessageBox.Show("Refuse amount is not integer")
            Exit Sub
        Else
            txtRefuseAmount.Text = intrefuseamant

        End If




        If String.IsNullOrEmpty(txtAbortOthers.Text) Then
            MessageBox.Show("Other Field is blank or empty")
            txtAbortOthers.Select()
            Exit Sub

        End If


        Try



            Dim estMethods As clsEstimateRefusedMethods = New clsEstimateRefusedMethods
            Dim estimaterefuse As clsEstimateRefused = New clsEstimateRefused

            Dim claiminfomethods As clsClaiminfoMethods = New clsClaiminfoMethods
            Dim claiminfo As clsClaiminfo = New clsClaiminfo
            Dim pending As clsPendingMethods = New clsPendingMethods
            Dim PendingJob As clsPending = pending.GetPending(publicClaiminfo.Jobcode)
            Dim NRDetails As clsNrdetailsMethods = New clsNrdetailsMethods
            Dim nrDetailsJob = NRDetails.GetNR(publicClaiminfo.Jobcode)
            Dim Service As clsServiceDetailsMethods = New clsServiceDetailsMethods
            Dim serviceDetails As clsServiceDetails = Service.GetPartsDetails(publicClaiminfo.Jobcode)
            Dim serviceDetailsMethods As clsServiceDetailsMethods = New clsServiceDetailsMethods


            claiminfo = publicClaiminfo
            Dim cFlag As String = claiminfo.cFlag.ToString
            Dim MrNo As String = publicClaiminfo.MRNO


            claiminfo.ServiceBy = cmbAbortedby.Text
            claiminfo.SDate = dtpAbort.Value.ToShortDateString
            claiminfo.cFlag = Integer.Parse("1")
            claiminfo.MRNO = "Est Refuse"

            claiminfo.SvAmt = Integer.Parse("0")
            claiminfo.PrdAmt = Integer.Parse("0")
            claiminfo.OtherAmt = Integer.Parse("0")
            claiminfo.Dis = Integer.Parse("0")


            claiminfomethods.updateclaiminfo(claiminfo, publicClaiminfo.Jobcode)


            estimaterefuse.JobCode = claiminfo.Jobcode
            estimaterefuse.RefuseAmnt = Integer.Parse(txtRefuseAmount.Text)
            estimaterefuse.EstDate = dtpAbort.Value.ToShortDateString
            estimaterefuse.EstText = txtAbortOthers.Text
            estimaterefuse.Branch = claiminfo.Branch
            estimaterefuse.ServiceBy_ID = cmbAbortedby.Text





            Dim verifyER As clsEstimateRefused = estMethods.GetEstimateRefuse(claiminfo.Jobcode)

            If IsNothing(verifyER.JobCode) Then
                estMethods.save(estimaterefuse)
                MessageBox.Show("Record Save Successfully")
            Else
                estMethods.Update(estimaterefuse, publicClaiminfo.Jobcode)
                MessageBox.Show("Record Update Successfully")
            End If




            If Not IsNothing(PendingJob.JobCode) Then
                pending.Delete(PendingJob.JobCode)
            End If

            If Not IsNothing(nrDetailsJob.JobCode) Then
                NRDetails.Delete(nrDetailsJob.JobCode)
            End If
            If Not IsNothing(serviceDetails.Jobcode) Then
                serviceDetailsMethods.Delete(serviceDetails.Jobcode)

            End If
            If serviceDetailsMethods.isExist_Temp_ServiceDetails(serviceDetails.Jobcode) = True Then
                serviceDetailsMethods.Delete_Temp_ServiceDetails(serviceDetails.Jobcode)
            End If

            If blnSendMail = True Then
                SendERMail(txtAbortOthers.Text)
            End If

            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try




    End Sub
    Private Sub LoadNrDetails()

        Dim nrdetailsmethods As clsNrdetailsMethods = New clsNrdetailsMethods
        If nrdetailsmethods.IsExist(publicClaiminfo.Jobcode) = False Then
            Exit Sub
        End If

        Dim nrdetails As clsNrdetails = nrdetailsmethods.GetNR(publicClaiminfo.Jobcode)





        Dim nrArry() As String = nrdetails.NRCode.Split(",")

            For Each strnr As String In nrArry
                If chkPCBDamage.Text.ToLower = strnr.ToLower Then
                    chkPCBDamage.Checked = True


                ElseIf chkDropinthewater.Text.ToLower = strnr.ToLower Then
                    chkDropinthewater.Checked = True

                ElseIf chkDroponthefloor.Text.ToLower = strnr.ToLower Then
                    chkDroponthefloor.Checked = True

                ElseIf chkConnectAnotherCharger.Text.ToLower = strnr.ToLower Then
                    chkConnectAnotherCharger.Checked = True

                ElseIf chkPCBCrack.Text.ToLower = strnr.ToLower Then
                    chkPCBCrack.Checked = True

                ElseIf chkSoftwareProblem.Text.ToLower = strnr.ToLower Then
                    chkSoftwareProblem.Checked = True

                ElseIf chkUnavilableParts.Text.ToLower = strnr.ToLower Then
                    chkUnavilableParts.Checked = True

                ElseIf chkTechnicalProblem.Text.ToLower = strnr.ToLower Then
                    chkTechnicalProblem.Checked = True

                ElseIf chkSetLock.Text.ToLower = strnr.ToLower Then
                    chkSetLock.Checked = True

                ElseIf chkOpenOutside.Text.ToLower = strnr.ToLower Then
                    chkOpenOutside.Checked = True
                Else
                    txtAbortOthers.Text = strnr.ToString
                End If


            Next



        cmbAbortedby.Text = publicClaiminfo.ServiceBy.ToString
        dtpAbort.Value = publicClaiminfo.SDate.ToShortDateString



    End Sub

    Private Sub LoadTechnician()
        Dim empMethods As clsPersonalMethods = New clsPersonalMethods
        Dim emp As List(Of clsPersonal) = empMethods.LoadTechnician.ToList

        For Each e As clsPersonal In emp
            cmbAbortedby.Items.Add(e.EmpCode)

        Next
    End Sub


    Private Sub frmAbort_Resize(sender As Object, e As EventArgs) Handles Me.Resize


        ResizeControl(Me, cmdAbortSave, 0, 3)
        ResizeControl(Me, cmdSaveAndMail, cmdAbortSave.Left + cmdAbortSave.Width, 3)
        ResizeControl(Me, cmdAbortClose, cmdSaveAndMail.Left + cmdSaveAndMail.Width, 3)


        'cmdAbortSave.Left = grpAbortDescription.Left
        'cmdAbortSave.Width = grpAbortDescription.Width / 2

        'cmdAbortClose.Left = cmdAbortSave.Left + cmdAbortSave.Width
        'cmdAbortClose.Width = grpAbortDescription.Width / 2

    End Sub



    Private Sub EnableControl()
        chkPCBDamage.Enabled = True
        chkDropinthewater.Enabled = True
        chkDroponthefloor.Enabled = True
        chkOpenOutside.Enabled = True
        chkConnectAnotherCharger.Enabled = True
        chkPCBCrack.Enabled = True
        chkSoftwareProblem.Enabled = True
        chkUnavilableParts.Enabled = True
        chkTechnicalProblem.Enabled = True
        chkSetLock.Enabled = True
        chkOpenOutside.Enabled = True
        chkOthers.Enabled = True
        txtRefuseAmount.Enabled = False


    End Sub

    Private Sub DisableControl()
        chkPCBDamage.Enabled = False
        chkPCBDamage.Checked = False

        chkDropinthewater.Enabled = False
        chkDropinthewater.Checked = False

        chkDroponthefloor.Enabled = False
        chkDroponthefloor.Checked = False

        chkOpenOutside.Enabled = False
        chkOpenOutside.Checked = False

        chkConnectAnotherCharger.Enabled = False
        chkConnectAnotherCharger.Checked = False

        chkPCBCrack.Enabled = False
        chkPCBCrack.Checked = False

        chkSoftwareProblem.Enabled = False
        chkSoftwareProblem.Checked = False

        chkUnavilableParts.Enabled = False
        chkUnavilableParts.Checked = False

        chkTechnicalProblem.Enabled = False
        chkTechnicalProblem.Checked = False

        chkSetLock.Enabled = False
        chkSetLock.Checked = False

        chkOpenOutside.Enabled = False
        chkOpenOutside.Checked = False

        chkOthers.Enabled = False
        chkOthers.Checked = False
        txtRefuseAmount.Enabled = True

    End Sub


    Private Sub cmdAbortClose_Click(sender As Object, e As EventArgs) Handles cmdAbortClose.Click


        Me.Close()

    End Sub

    Private Sub cmdAbortSave_Click(sender As Object, e As EventArgs) Handles cmdAbortSave.Click




        'If publicClaiminfo.cFlag = 0 Or publicClaiminfo.cFlag = 2 Then
        '    MessageBox.Show("You Can not Save Data because the job is in 'Delivered Model'")
        '    Exit Sub
        'ElseIf publicClaiminfo.cFlag = 102 Then
        '    MessageBox.Show("You Can not Save Data because the job is in 'Delivered Model(Replace)'")
        '    Exit Sub
        'End If

        'If Not IsNothing(ActiveUser) Then
        '    If publicClaiminfo.cFlag = 100 Then
        '        If ActiveUser.UserType.ToLower = LCase("Admin") Then
        '            If chkSavebyforce.Checked = False Then
        '                MessageBox.Show("The Product is already delivered on Date " & publicClaiminfo.DDate & vbNewLine & "You can not save untli tick check box")
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


        ' check Date Validation 
        Dim lngReceptDate As Long = DateTime.Compare(dtpAbort.Value.ToShortDateString, publicClaiminfo.ReceptDate.ToShortDateString)




        If lngReceptDate = -1 Then
            MessageBox.Show("'N/R Date' is Greater Than 'NR Date'" & vbNewLine & vbNewLine & "_____________________________________" & vbNewLine & "Receive Date = #" & publicClaiminfo.ReceptDate.ToShortDateString & "#" & vbNewLine & "NR Date= #" & dtpAbort.Value.ToShortDateString & "#")

            Exit Sub

        End If


        ' check Advance Amount Existence

        If RecordVerification(strProvider, "AdvanceInfo", "AdvanceInfo.JobCOde='" & strtmpJobCode & "'") = True Then
            MsgBox("This Job is Taken 'Advance Amount' " & vbCrLf & "You Cant Save it until Deleting Advance Record", vbInformation, "Save Failur")
            Exit Sub

        End If



        'Dim tmpCheckObject
        ControlValidation()

        If intCount = 0 Then
            MsgBox("You have select at least one reason", vbInformation + vbOKOnly)
            Exit Sub

        End If



        If cmbAbortedby.Text.Length = 0 Or lblAnortEmployeeName.Text.ToLower = LCase("Code Not Found") Then
            MsgBox("Fill the Code Field", vbInformation + vbOKOnly, "Code field is blank")
            cmbAbortedby.Select()
            Exit Sub

        End If


        Try


            If NrEr.ToLower = LCase("nr") Then
                saveNr(False)
            Else
                SaveEr(False)

            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try




    End Sub

    Private Sub LoadNRCode()


        Dim conLoadNRCOde As New OleDbConnection(strProvider)
        Try

            If strTmpCFlag = "1" And strtmpMRNo = "Est Refuse" Or strTmpCFlag = "0" And strtmpMRNo = "Est Refuse" Or strTmpCFlag = "2" And strtmpMRNo = "Est Refuse" Then



                If RecordVerification(strProvider, "EstimateRefused", "EstimateRefused.JobCOde='" & strtmpJobCode & "'") = True Then
                    Dim drEstimateRefuse As OleDbDataReader = Nothing

                    LoadAllInformation(conLoadNRCOde, drEstimateRefuse, strProvider, "EstimateRefused", "EstimateRefused.ServiceBy_ID, EstimateRefused.EstDate, EstimateRefused.EstText, EstimateRefused.RefuseAmnt", "EstimateRefused.JobCOde='" & strtmpJobCode & "'")

                    If drEstimateRefuse.HasRows = True Then
                        drEstimateRefuse.Read()
                        txtRefuseAmount.Text = Convert.ToInt64(drEstimateRefuse("RefuseAmnt").ToString)
                        txtAbortOthers.Text = drEstimateRefuse("estText").ToString
                        cmbAbortedby.Text = drEstimateRefuse("ServiceBy_ID").ToString
                        dtpAbort.Value = Convert.ToDateTime(drEstimateRefuse("estDate").ToString)
                        chkEstimateRefuse.Checked = True
                    End If


                    Exit Sub

                End If
            End If


            'For Each tmpCheckObject In grpAbortDescription.Controls
            '    If TypeOf tmpCheckObject Is CheckBox Then
            '        Dim tmpCheckbox As New CheckBox

            '        tmpCheckbox = tmpCheckObject

            '        If RecordVerification(strProvider, "NRDetails", "Nrdetails.JobCode='" & strtmpJobCode & "' and NRDetails.NRCode='" & tmpCheckbox.Text & "'") = True Then
            '            tmpCheckbox.Checked = True
            '        Else
            '            tmpCheckbox.Checked = False

            '        End If



            '    End If

            'Next



            'If RecordVerification(strProvider, "NrOthers", "NrOthers.JobCode='" & strtmpJobCode & "'") = True Then
            '    Dim ConNrOthers As New OleDbConnection(strProvider)
            '    ConNrOthers.Open()

            '    Dim dcNROthers As New OleDbCommand("Select NROthers.NRCOde from NROthers where NrOthers.JobCode='" & strtmpJobCode & "'", ConNrOthers)
            '    Dim drNROthers As OleDbDataReader = Nothing


            '    drNROthers = dcNROthers.ExecuteReader
            '    If drNROthers.HasRows = True Then
            '        drNROthers.Read()
            '        txtAbortOthers.Text = drNROthers("NrCode").ToString
            '        chkOthers.Checked = True
            '    End If

            '    TempDatareaderClose(drNROthers)
            '    TempCommandDispose(dcNROthers)
            '    TempConnectionDispose(ConNrOthers)


            'End If




            '_________________________________________________________________ Load NRDetails _______________________________________________


            Dim conLoadNR As New OleDbConnection(strProvider)

            Dim drLoadNr As OleDbDataReader = Nothing
            Dim strNRArry As String() = Nothing
            Dim intLoopNRArry As Integer = 0

            LoadAllInformation(conLoadNR, drLoadNr, strProvider, "NRDetails", "NRCode", "NRDetails.JobCode='" & strtmpJobCode.ToString & "'")

            If drLoadNr.HasRows = True Then
                While drLoadNr.Read
                    strNRArry = Split(drLoadNr("NRCode").ToString, ":")
                End While


                For intLoopNRArry = 0 To UBound(strNRArry) - 1

                    If strNRArry(intLoopNRArry).ToString = chkPCBDamage.Text Then
                        chkPCBDamage.Checked = True
                    ElseIf strNRArry(intLoopNRArry).ToString = chkDropinthewater.Text Then
                        chkDropinthewater.Checked = True
                    ElseIf strNRArry(intLoopNRArry).ToString = chkDroponthefloor.Text Then
                        chkDroponthefloor.Checked = True
                    ElseIf strNRArry(intLoopNRArry).ToString = chkConnectAnotherCharger.Text Then
                        chkConnectAnotherCharger.Checked = True
                    ElseIf strNRArry(intLoopNRArry).ToString = chkPCBCrack.Text Then
                        chkPCBCrack.Checked = True
                    ElseIf strNRArry(intLoopNRArry).ToString = chkSoftwareProblem.Text Then
                        chkSoftwareProblem.Checked = True
                    ElseIf strNRArry(intLoopNRArry).ToString = chkUnavilableParts.Text Then
                        chkUnavilableParts.Checked = True
                    ElseIf strNRArry(intLoopNRArry).ToString = chkTechnicalProblem.Text Then
                        chkTechnicalProblem.Checked = True
                    ElseIf strNRArry(intLoopNRArry).ToString = chkSetLock.Text Then
                        chkSetLock.Checked = True
                    ElseIf strNRArry(intLoopNRArry).ToString = chkOpenOutside.Text Then
                        chkOpenOutside.Checked = True
                    Else
                        txtAbortOthers.Text += strNRArry(intLoopNRArry).ToString
                        chkOthers.Checked = True
                    End If

                Next

                '__________________________________ Load Claiminfo _________________________________________________________

                Dim drLoadNRClaiminformation As OleDbDataReader = Nothing


                LoadAllInformation(conLoadNRCOde, drLoadNRClaiminformation, strProvider, "CLaiminfo", "Claiminfo.Serviceby,CLaiminfo.Sdate", "Claiminfo.JobCode='" & strtmpJobCode & "'")

                If drLoadNRClaiminformation.HasRows = True Then
                    drLoadNRClaiminformation.Read()
                    cmbAbortedby.Text = drLoadNRClaiminformation("Serviceby").ToString
                    If String.IsNullOrEmpty(drLoadNRClaiminformation("Sdate").ToString) Then
                        dtpAbort.Value = Today
                    Else
                        dtpAbort.Value = Convert.ToDateTime(drLoadNRClaiminformation("Sdate").ToString)
                    End If



                End If



            Else
                Exit Sub



            End If







        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        TempConnectionDispose(conLoadNRCOde)

    End Sub

    Private Sub cmbAbortedby_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAbortedby.SelectedIndexChanged
        Dim empMethods As clsPersonalMethods = New clsPersonalMethods

        Dim emp As List(Of clsPersonal) = empMethods.LoadTechnician(cmbAbortedby.Text)
        If emp.Count > 0 Then
            For Each employee As clsPersonal In emp
                lblAnortEmployeeName.Text = employee.EmpName
            Next

        Else
            lblAnortEmployeeName.Text = "Code Not Found"
        End If




    End Sub

    Private Sub cmbAbortedby_Leave(sender As Object, e As EventArgs) Handles cmbAbortedby.Leave

    End Sub

    Private Sub cmbAbortedby_LostFocus(sender As Object, e As EventArgs) Handles cmbAbortedby.LostFocus
        cmbAbortedby_SelectedIndexChanged(sender, e)
    End Sub


    Private Sub ControlValidation()
        Dim TempObj
        intCount = 0
        For Each TempObj In grpAbortDescription.Controls


            If TypeOf TempObj Is CheckBox Then
                If TempObj.checked = True Then
                    intCount = 1
                End If

            End If
        Next


    End Sub








    Private Sub cmbAbortedby_KeyUp(sender As Object, e As KeyEventArgs) Handles cmbAbortedby.KeyUp
        GotFucus(sender, e, dtpAbort)
    End Sub

    Private Sub txtRefuseAmount_TextChanged(sender As Object, e As EventArgs) Handles txtRefuseAmount.TextChanged

    End Sub

    Private Sub txtRefuseAmount_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles txtRefuseAmount.MouseDoubleClick

    End Sub









    Private Sub GetNRValue()
        strNrCode = String.Empty


        If chkPCBDamage.Checked = True Then
            strNrCode += chkPCBDamage.Text & ":"
        End If



        If chkDropinthewater.Checked = True Then
            strNrCode += chkDropinthewater.Text & ":"
        End If

        If chkDroponthefloor.Checked = True Then
            strNrCode += chkDroponthefloor.Text & ":"
        End If

        If chkConnectAnotherCharger.Checked = True Then
            strNrCode += chkConnectAnotherCharger.Text & ":"
        End If

        If chkPCBCrack.Checked = True Then
            strNrCode += chkPCBCrack.Text & ":"
        End If

        If chkSoftwareProblem.Checked = True Then
            strNrCode += chkSoftwareProblem.Text & ":"
        End If

        If chkUnavilableParts.Checked = True Then
            strNrCode += chkUnavilableParts.Text & ":"
        End If

        If chkTechnicalProblem.Checked = True Then
            strNrCode += chkTechnicalProblem.Text & ":"
        End If

        If chkSetLock.Checked = True Then
            strNrCode += chkSetLock.Text & ":"
        End If

        If chkOpenOutside.Checked = True Then
            strNrCode += chkOpenOutside.Text & ":"
        End If


        If chkOthers.Checked = True Then
            strNrCode += txtAbortOthers.Text & ":"
        End If


    End Sub

    Private Sub txtAbortOthers_TextChanged(sender As Object, e As EventArgs) Handles txtAbortOthers.TextChanged

    End Sub

    Private Sub txtAbortOthers_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAbortOthers.KeyPress
        Dim tempToolTip As New ToolTip

        If RemoveCharacter(e.KeyChar) = True Then
            e.Handled = True
            tempToolTip.Show(":',.?/|\*&^%$#@!~`}]{[;><=+""", txtAbortOthers, 2000)
        End If




    End Sub

    Private Sub txtAbortOthers_Leave(sender As Object, e As EventArgs) Handles txtAbortOthers.Leave
        GetNRValue()

    End Sub

    Private Sub txtRefuseAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRefuseAmount.KeyPress
        'InputDigit(txtRefuseAmount, e)

    End Sub







    Private Sub chkEstimateRefuse_CheckedChanged(sender As Object, e As EventArgs) Handles chkEstimateRefuse.CheckedChanged
        If chkEstimateRefuse.Checked = True Then
            NrEr = "Er"
            DisableControl()
        Else
            NrEr = "Nr"
            EnableControl()
        End If
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




        ' ______________________________________________ Mail Verification Section ________________________________________________________

        If myNetwork.VerifyMail(security.Decrypt(mail.MailFrom)) = False Then
            MessageBox.Show("'Invalid Sending Mail'")
            Me.Close()
                Exit Sub
            End If






#Region "Audit Mail Section"



        If AuditMethods.HasRow = True Then
            ListAudit = AuditMethods.GetAuditList.Where(Function(x) x.NR = True).ToList
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

                If publicClaiminfo.WCondition = 1 Then

                    strAudit = strAudit & publicClaiminfo.CustName & vbNewLine
                    strAudit = strAudit & "Job No: '" & publicClaiminfo.Jobcode & "'," & vbNewLine
                    strAudit = strAudit & "Delivery Branch: '" & publicClaiminfo.Branch & "'," & vbNewLine
                    strAudit = strAudit & " Mailing Date : " & Now() & vbNewLine
                    strAudit = strAudit & " Type of Warranty : Non Warranty" & vbNewLine
                    strAudit = strAudit & " Reason for N/R : " & strNRReason & vbNewLine
                    strAudit = strAudit & " N/R by : " & lblAnortEmployeeName.Text & vbNewLine
                    strAudit = strAudit & " Product Status :  Not Repairable)" & vbNewLine
                Else
                    strAudit = strAudit & publicClaiminfo.CustName & vbNewLine
                    strAudit = strAudit & "Job No: '" & publicClaiminfo.Jobcode & "'," & vbNewLine
                    strAudit = strAudit & "Delivery Branch: '" & publicClaiminfo.Branch & "'," & vbNewLine

                    If publicClaiminfo.WCondition = 0 Then
                        strAudit = strAudit & " Type of Warranty : Sales Warranty" & vbNewLine
                    Else
                        strAudit = strAudit & " Type of Warranty : Service Warranty" & vbNewLine
                    End If

                    strAudit = strAudit & " Mailing Date : " & Now() & vbNewLine
                    strAudit = strAudit & " Reason for N/R : " & strNRReason & vbNewLine
                    strAudit = strAudit & " N/R by : " & lblAnortEmployeeName.Text & vbNewLine
                    strAudit = strAudit & " Product Status : Not Repairable"

                End If







                AuditMail.MailID = mail.MailFrom
                AuditMail.Password = mail.Crediantial
                AuditMail.SMTP = mail.SMTP
                AuditMail.PORT = mail.Port
                AuditMail.SSL = mail.SSL
                AuditMail.MailTo = strMailArray
                AuditMail.Body = strAudit
                AuditMail.Subject = "Prduct Service"


                AuditMail.From = mail.MailFrom
                With myNetwork
                    If .isInternet = True Then
                        .SendMail(AuditMail, False)
                    End If


                End With
            End If
        End If



#End Region

#Region "Customer Mail Section"



        If myNetwork.VerifyMail(publicClaiminfo.Email) = False Then
            MessageBox.Show("Invalid Mail  'Check Customer Email")
            Me.Close()
            Exit Sub
        End If



        If publicClaiminfo.WCondition = 1 Then

            strBody = "Dear Sir/Madam" & vbCrLf
            strBody = strBody & publicClaiminfo.CustName & vbNewLine
            strBody = strBody & " Your Product Is Ready for Delivery " & vbNewLine
            strBody = strBody & "Job No: '" & publicClaiminfo.Jobcode & "'," & vbNewLine
            strBody = strBody & "Delivery Branch: '" & publicClaiminfo.Branch & "'," & vbNewLine
            strBody = strBody & " Mailing Date : " & Now() & vbNewLine
            strBody = strBody & " Type of Warranty : Non Warranty" & vbNewLine
            strBody = strBody & " Reason for N/R : " & strNRReason & "." & vbNewLine
            strBody = strBody & " Product Status :  Not Repairable)" & vbNewLine
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

            strBody = strBody & " Mailing Date : " & Now() & vbNewLine
            strBody = strBody & " Reason for N/R : " & strNRReason & "." & vbNewLine
            strBody = strBody & " Product Status : Not Repairable "

        End If

        aMail.MailID = mail.MailFrom
        aMail.Password = mail.Crediantial
        aMail.SMTP = mail.SMTP
        aMail.PORT = mail.Port
        aMail.SSL = mail.SSL
        aMail.MailTo = publicClaiminfo.Email.ToString
        aMail.From = mail.MailFrom

        aMail.Body = strBody
        aMail.Subject = "Prduct Service"


        With myNetwork
            If .isInternet = True Then
                .SendMail(aMail)
            Else
                MessageBox.Show("Mail is not sent due to 'Internet connection failur'")
            End If


        End With


#End Region

    End Sub




    Private Sub SendERMail(ByVal strERReason As String)

        Dim strBody As String = String.Empty


        Dim mailMethods As clsOptionMethods = New clsOptionMethods
        Dim mail As clsOption = mailMethods.GetActiveMail
        Dim aMail As clsMail = New clsMail 'aMail = Active Mail

        Dim security As clsSecurity = New clsSecurity
        Dim AuditMethods As clsJobAuditMethods = New clsJobAuditMethods
        Dim ListAudit As List(Of clsJobAudit) = New List(Of clsJobAudit)
        Dim strMailArray As String = String.Empty
        Dim AuditMail As clsMail = New clsMail
        Dim myNetwork As clsNetwork = New clsNetwork

        Dim strAudit As String = String.Empty




        If myNetwork.VerifyMail(security.Decrypt(mail.MailFrom)) = False Then

            MessageBox.Show("'Invalid Sending Mail'")
            Me.Close()
            Exit Sub
        End If





#Region "Audit Mail Section"


        If AuditMethods.HasRow = True Then
            ListAudit = AuditMethods.GetAuditList.Where(Function(x) x.ER = True).ToList
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

                If publicClaiminfo.WCondition = 1 Then

                    strAudit = "Dear Sir/Madam" & vbCrLf
                    strAudit = strAudit & publicClaiminfo.CustName & vbNewLine
                    strAudit = strAudit & " Your Product Is Ready for Delivery (" & vbNewLine
                    strAudit = strAudit & "Job No: '" & publicClaiminfo.Jobcode & "'," & vbNewLine
                    strAudit = strAudit & "Delivery Branch: '" & publicClaiminfo.Branch & "'," & vbNewLine
                    strAudit = strAudit & " Mailing Date : " & Now() & vbNewLine
                    strAudit = strAudit & " Type of Warranty : Non Warranty" & vbNewLine
                    strAudit = strAudit & " Product Status : Estimate Refuse" & vbNewLine
                    strAudit = strAudit & " Reason of E/R : " & strERReason & "." & vbNewLine
                    strAudit = strAudit & " Estimate Refused by : " & lblAnortEmployeeName.Text & vbNewLine

                Else
                    strAudit = "Dear Sir/Madam" & vbNewLine
                    strAudit = strAudit & publicClaiminfo.CustName & vbNewLine
                    strAudit = strAudit & " Your Product Is Ready for Delivery (" & vbNewLine
                    strAudit = strAudit & "Job No: '" & publicClaiminfo.Jobcode & "'," & vbNewLine
                    strAudit = strAudit & "Delivery Branch: '" & publicClaiminfo.Branch & "'," & vbNewLine
                    If publicClaiminfo.WCondition = 0 Then
                        strAudit = strAudit & " Type of Warranty : Sales Warranty" & vbNewLine
                    Else
                        strAudit = strAudit & " Type of Warranty : Service Warranty" & vbNewLine
                    End If

                    strAudit = strAudit & " Mailing Date : " & Now() & vbNewLine
                    strAudit = strAudit & " Product Status : Estimate Refuse" & vbNewLine
                    strAudit = strAudit & " Reason of E/R : " & strERReason & "." & vbNewLine
                    strAudit = strAudit & " Estimate Refused by : " & lblAnortEmployeeName.Text & vbNewLine

                End If



                AuditMail.MailID = mail.MailFrom
                AuditMail.Password = mail.Crediantial
                AuditMail.SMTP = mail.SMTP
                AuditMail.PORT = mail.Port
                AuditMail.SSL = mail.SSL
                AuditMail.MailTo = strMailArray
                AuditMail.Body = strAudit
                AuditMail.Subject = "Prduct Service"


                AuditMail.From = mail.MailFrom
                With myNetwork
                    If .isInternet = True Then
                        .SendMail(AuditMail, False)
                    End If


                End With

            End If
        End If



#End Region




#Region "Customer Mail Section"


        If myNetwork.VerifyMail(publicClaiminfo.Email) = False Then
            MessageBox.Show("Invalid Mail  'Check Customer Email'")
            Me.Close()
            Exit Sub
        End If







        aMail.From = mail.MailFrom




        If publicClaiminfo.WCondition = 1 Then

            strBody = "Dear Sir/Madam" & vbCrLf
            strBody = strBody & publicClaiminfo.CustName & vbNewLine
            strBody = strBody & " Your Product Is Ready for Delivery (" & vbNewLine
            strBody = strBody & " Job No: '" & publicClaiminfo.Jobcode & "'," & vbNewLine
            strBody = strBody & " Delivery Branch: '" & publicClaiminfo.Branch & "'," & vbNewLine
            strBody = strBody & " Mailing Date : " & Now() & vbNewLine
            strBody = strBody & " Type of Warranty : Non Warranty" & vbNewLine
            strBody = strBody & " Product Status : Estimate Refuse" & vbNewLine
            strBody = strBody & " Reason of E/R : " & strERReason & vbNewLine
            strBody = strBody & " Fault Finding Charge Will be considered during Deliry time." & ")"





        Else


            strBody = "Dear Sir/Madam" & vbNewLine
            strBody = strBody & publicClaiminfo.CustName & vbNewLine
            strBody = strBody & " Your Product Is Ready for Delivery (" & vbNewLine
            strBody = strBody & " Job No: '" & publicClaiminfo.Jobcode & "'," & vbNewLine
            strBody = strBody & " Delivery Branch: '" & publicClaiminfo.Branch & "'," & vbNewLine
            If publicClaiminfo.WCondition = 0 Then
                strBody = strBody & " Type of Warranty : Sales Warranty" & vbNewLine
            Else
                strBody = strBody & " Type of Warranty : Service Warranty" & vbNewLine
            End If

            strBody = strBody & " Mailing Date : " & Now() & vbNewLine
            strBody = strBody & " Product Status : Estimate Refuse" & vbNewLine &
            strBody = strBody & " Reason of E/R : " & strERReason & vbNewLine
            strBody = strBody & " Fault Finding Charge Will be considered during Deliry time." & ")"

        End If

        aMail.MailID = mail.MailFrom
        aMail.Password = mail.Crediantial
        aMail.SMTP = mail.SMTP
        aMail.PORT = mail.Port
        aMail.SSL = mail.SSL
        aMail.MailTo = publicClaiminfo.Email.ToString
        aMail.Body = strBody
        aMail.Subject = "Prduct Service"



        With myNetwork
            If .isInternet = True Then
                .SendMail(aMail)
            Else
                MessageBox.Show("Mail Is Not sent due To 'Internet connection failur'")
            End If


        End With


#End Region

    End Sub

    Private Sub dtpAbort_ValueChanged(sender As Object, e As EventArgs) Handles dtpAbort.ValueChanged

    End Sub

    Private Sub dtpAbort_KeyUp(sender As Object, e As KeyEventArgs) Handles dtpAbort.KeyUp
        If e.KeyCode = Keys.Enter Then
            cmdAbortSave.Select()
        End If
    End Sub

    Private Sub cmdSaveAndMail_Click(sender As Object, e As EventArgs) Handles cmdSaveAndMail.Click



        'If publicClaiminfo.cFlag = 0 Or publicClaiminfo.cFlag = 2 Then
        '    MessageBox.Show("You Can not Save Data because the job is in 'Delivered Model'")
        '    Exit Sub
        'ElseIf publicClaiminfo.cFlag = 102 Then
        '    MessageBox.Show("You Can not Save Data because the job is in 'Delivered Model(Replace)'")
        '    Exit Sub
        'End If

        'If Not IsNothing(ActiveUser) Then
        '    If publicClaiminfo.cFlag = 100 Then
        '        If ActiveUser.UserType.ToLower = LCase("Admin") Then
        '            If chkSavebyforce.Checked = False Then
        '                MessageBox.Show("The Product is already delivered on Date " & publicClaiminfo.DDate & vbNewLine & "You can not save untli tick check box")
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





        ' check Date Validation 
        Dim lngReceptDate As Long = DateTime.Compare(dtpAbort.Value.ToShortDateString, publicClaiminfo.ReceptDate.ToShortDateString)
        If lngReceptDate = -1 Then
            MessageBox.Show("'N/R Date' is Greater Than 'NR Date'" & vbNewLine & vbNewLine & "_____________________________________" & vbNewLine & "Receive Date = #" & publicClaiminfo.ReceptDate.ToShortDateString & "#" & vbNewLine & "NR Date= #" & dtpAbort.Value.ToShortDateString & "#")
            Exit Sub
        End If



        ' check Advance Amount Existence
        If RecordVerification(strProvider, "AdvanceInfo", "AdvanceInfo.JobCOde='" & strtmpJobCode & "'") = True Then
            MsgBox("This Job is Taken 'Advance Amount' " & vbCrLf & "You Cant Save it until Deleting Advance Record", vbInformation, "Save Failur")
            Exit Sub

        End If



        'Dim tmpCheckObject
        ControlValidation()

        If intCount = 0 Then
            MsgBox("You have select at least one reason", vbInformation + vbOKOnly)
            Exit Sub

        End If



        If cmbAbortedby.Text.Length <= 0 Or lblAnortEmployeeName.Text.ToLower = LCase("Code Not Found") Then
            MsgBox("Fill the Code Field", vbInformation + vbOKOnly, "Code field is blank")
            cmbAbortedby.Select()
            Exit Sub

        End If


        Try



            Dim mailOption As clsOptionMethods = New clsOptionMethods


            If mailOption.IsExistMail = True Then
                If mailOption.IsMailActive = False Then
                    If MessageBox.Show("Mail is not active", "Do you want set mail", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                        Dim optionForm As frmOption = New frmOption
                        optionForm.strTabName = "Mail"
                        optionForm.ShowDialog()
                    End If
                End If

            Else
                If mailOption.IsMailActive = False Then
                    If MessageBox.Show("No Mail Found ", "Do you want to create New Mail", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                        Dim optionForm As frmOption = New frmOption
                        optionForm.strTabName = "Mail"
                        optionForm.ShowDialog()
                    End If
                End If

            End If

            If NrEr.ToLower = LCase("nr") Then
                saveNr(True)
            Else
                SaveEr(True)

            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub chkConnectAnotherCharger_CheckedChanged(sender As Object, e As EventArgs) Handles chkConnectAnotherCharger.CheckedChanged

    End Sub
End Class