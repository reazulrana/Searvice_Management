Imports System.Data.OleDb




Public Class frmReplaceEntry

    Private strReplaceCategory As String



    Private Sub frmReplaceEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load




        CenterForm(Me)

        Dim conReplaceEntry As New OleDbConnection(strProvider)
        GetReplaceCategory()




        LoadReplaceBrand(strReplaceCategory)

        Dim drLoadReplace As OleDbDataReader = Nothing

        If strTmpCFlag = "101" Or strTmpCFlag = "102" Then

            LoadAllInformation(conReplaceEntry, drLoadReplace, strProvider, "Replace", "Replace.JobCode,Replace.Brand,Replace.Model,Replace.ESN,Replace.ESNb,Replace.SLNo,Replace.Other,Replace.RDate,Replace.ReplaceBy", "Replace.JobCOde='" & strtmpJobCode & "'")

            LoadTechnicianCode(cmbReplaceby)

            If drLoadReplace.HasRows = True Then
                While drLoadReplace.Read
                    txtReplaceJobCode.Text = drLoadReplace("JobCOde").ToString

                    cmbReplaceBrand.Text = drLoadReplace("Brand").ToString
                    cmbReplaceModel.Text = "" & drLoadReplace("Model").ToString
                    txtReplaceSLno.Text = "" & drLoadReplace("SlNo").ToString
                    txtReplaceESN.Text = "" & drLoadReplace("Esn").ToString
                    txtReplaceESNB.Text = "" & drLoadReplace("ESNB").ToString
                    txtReplaceOthers.Text = "" & drLoadReplace("Other").ToString
                    cmbReplaceby.Text = "" & drLoadReplace("Replaceby").ToString
                    dtpReplaceDate.Text = Convert.ToDateTime(drLoadReplace("Rdate").ToString).ToShortDateString


                End While
            Else
                txtReplaceJobCode.Text = strtmpJobCode
            End If
        Else
            txtReplaceJobCode.Text = strtmpJobCode

        End If


        TempConnectionDispose(conReplaceEntry)


    End Sub

    Private Sub frmReplaceEntry_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        cmdSave.Top = grpReplaceInformation.Top + grpReplaceInformation.Height + 10
        cmdSave.Left = grpReplaceInformation.Left
        cmdSave.Width = grpReplaceInformation.Width / 2
        cmdClose.Top = cmdSave.Top
        cmdClose.Left = cmdSave.Left + cmdSave.Width
        cmdClose.Width = grpReplaceInformation.Width / 2


    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()

    End Sub


    Private Sub GetReplaceCategory()
        Dim conGetReplaceCategory As New OleDbConnection(strProvider)
        Dim drLoadReplaceCategory As OleDbDataReader = Nothing


        LoadAllInformation(conGetReplaceCategory, drLoadReplaceCategory, strProvider, "Claiminfo", "Claiminfo.Servicetype,Claiminfo.IsssueDate", "Claiminfo.JobCOde='" & strtmpJobCode & "'")


        If drLoadReplaceCategory.HasRows = True Then

            While drLoadReplaceCategory.Read
                strReplaceCategory = drLoadReplaceCategory("Servicetype").ToString
                txtReplaceNrDate.Text = Convert.ToDateTime(drLoadReplaceCategory("IsssueDate").ToString).ToShortDateString

            End While

        End If






        TempConnectionDispose(conGetReplaceCategory)


    End Sub

    Private Sub LoadReplaceBrand(ByVal strTempReplaceCategory_for_Brand As String)

        Dim conLoadReplaceBrand As New OleDbConnection(strProvider)
        Dim drLoadReplaceBrand As OleDbDataReader = Nothing


        If strTempReplaceCategory_for_Brand = "" Then
            LoadAllInformation(conLoadReplaceBrand, drLoadReplaceBrand, strProvider, "Brand", "Brand.Brand", "''")
        Else

            LoadAllInformation(conLoadReplaceBrand, drLoadReplaceBrand, strProvider, "Brand", "Brand.Brand", "Brand.cType='" & strTempReplaceCategory_for_Brand & "'")
        End If

        If drLoadReplaceBrand.HasRows = True Then
            While drLoadReplaceBrand.Read

                cmbReplaceBrand.Items.Add(drLoadReplaceBrand("Brand").ToString)

            End While
        End If
        TempConnectionDispose(conLoadReplaceBrand)
    End Sub

    Private Sub cmbReplaceby_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbReplaceby.SelectedIndexChanged
        TechnicianName(cmbReplaceby.Text, lblReplaceByName)
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click


        If RecordVerification(strProvider, "AdvanceInfo", "AdvanceInfo.JobCOde='" & strtmpJobCode & "'") = True Then
            MsgBox("This Job is Taken 'Advance Amount' " & vbCrLf & "You Cant Save it untin Deleting Advance Record", vbInformation, "Save Failur")
            Exit Sub
        End If


        If cmbReplaceby.Text = "" Or lblReplaceByName.Text = "Missing Name" Then

            MsgBox("Please Select TechnicianCode", vbInformation, "Empty Technician Field")

            cmbReplaceby.Select()
            Exit Sub

        End If





        If RecordVerification(strProvider, "Replace", "Replace.JobCode='" & strtmpJobCode & "'") = False Then
            InsertNewRecord(strProvider, "Replace", "JobCode,Brand,Model,ESN,ESNb,SLNo,Other,RDate,ReplaceBy", "'" & txtReplaceJobCode.Text & "','" & cmbReplaceBrand.Text & "','" & cmbReplaceModel.Text & "','" & txtReplaceESN.Text & "','" & txtReplaceESNB.Text & "','" & txtReplaceSLno.Text & "','" & txtReplaceOthers.Text & "',#" & dtpReplaceDate.Value.ToShortDateString & "#,'" & cmbReplaceby.Text & "'")
        Else
            UpdateRecords("JobCode,Brand,Model,ESN,ESNb,SLNo,Other,RDate,ReplaceBy", "'" & txtReplaceJobCode.Text & "','" & cmbReplaceBrand.Text & "','" & cmbReplaceModel.Text & "','" & txtReplaceESN.Text & "','" & txtReplaceESNB.Text & "','" & txtReplaceSLno.Text & "','" & txtReplaceOthers.Text & "',#" & dtpReplaceDate.Value.ToShortDateString & "#,'" & cmbReplaceby.Text & "'", "Replace", "Replace.JobCode='" & strtmpJobCode & "'")
        End If

        UpdateRecords("Serviceby,Sdate,Cflag", "'" & cmbReplaceby.Text & "',#" & dtpReplaceDate.Value.ToShortDateString & "#,'101'", "Claiminfo", "Claiminfo.JobCode='" & strtmpJobCode & "'")
        MsgBox("Record Is Update")

        If strTmpCFlag = "101" Or strTmpCFlag = "102" Then
        Else

            ProductStatusVerify_and_Delete(strTmpCFlag)
        End If
        strTmpCFlag = "101"
        strtmpMRNo = ""
        strTempTechnicianCode = cmbReplaceby.Text

        'Me.Close()

        Me.Dispose()


    End Sub

    Private Sub cmbReplaceby_LostFocus(sender As Object, e As EventArgs) Handles cmbReplaceby.LostFocus
        TechnicianName(cmbReplaceby.Text, lblReplaceByName)
    End Sub






    Private Sub cmbReplaceBrand_KeyUp(sender As Object, e As KeyEventArgs) Handles cmbReplaceBrand.KeyUp
        GotFucus(sender, e, cmbReplaceModel)

    End Sub




    Private Sub txtReplaceESN_KeyUp(sender As Object, e As KeyEventArgs) Handles txtReplaceESN.KeyUp
        GotFucus(sender, e, txtReplaceESNB)
    End Sub



    Private Sub cmbReplaceModel_KeyUp(sender As Object, e As KeyEventArgs) Handles cmbReplaceModel.KeyUp
        GotFucus(sender, e, txtReplaceSLno)
    End Sub



    Private Sub txtReplaceSLno_KeyUp(sender As Object, e As KeyEventArgs) Handles txtReplaceSLno.KeyUp
        GotFucus(sender, e, txtReplaceESN)
    End Sub

    Private Sub txtReplaceESNB_TextChanged(sender As Object, e As EventArgs) Handles txtReplaceESNB.TextChanged

    End Sub

    Private Sub txtReplaceESNB_KeyUp(sender As Object, e As KeyEventArgs) Handles txtReplaceESNB.KeyUp
        GotFucus(sender, e, txtReplaceOthers)

    End Sub

    Private Sub txtReplaceOthers_TextChanged(sender As Object, e As EventArgs) Handles txtReplaceOthers.TextChanged

    End Sub

    Private Sub txtReplaceOthers_KeyUp(sender As Object, e As KeyEventArgs) Handles txtReplaceOthers.KeyUp
        GotFucus(sender, e, cmbReplaceby)
    End Sub

    Private Sub cmbReplaceby_KeyUp(sender As Object, e As KeyEventArgs) Handles cmbReplaceby.KeyUp
        GotFucus(sender, e, dtpReplaceDate)

    End Sub

    Private Sub dtpReplaceDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpReplaceDate.ValueChanged

    End Sub

    Private Sub dtpReplaceDate_KeyUp(sender As Object, e As KeyEventArgs) Handles dtpReplaceDate.KeyUp
        GotFucus(sender, e, cmdSave)

    End Sub

    Private Sub cmdSave_KeyUp(sender As Object, e As KeyEventArgs) Handles cmdSave.KeyUp
        GotFucus(sender, e, cmdClose)
    End Sub
End Class