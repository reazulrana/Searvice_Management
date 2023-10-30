Imports System.Data.OleDb
Imports System.Linq




Public Class frmOpenCustomerClaim
    Dim tempEventAtg As New EventArgs

    Dim blnSearchJobCodecontrol As Boolean

    Public strFormType As String = String.Empty




    Private Sub frmOpenCustomerClaim_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        optJobCode.Checked = True







        CenterForm(Me)


        txtSearchJob.Select()

        LoadBranch()
        GetBranch(cmbBranch)
        blnSearchJobCodecontrol = True

    End Sub



    'Private Sub SearchJob(ByVal strTempJobCode As String)
    '    Dim shrtLen As Short
    '    shrtLen = Len(strTempJobCode)

    '    'Dim comSearchjob As New OleDbCommand("Select Claiminfo.JobCode,Claiminfo.Wcondition,Claiminfo.Pdate,Claiminfo.ModelNo,Claiminfo.SLNo,Claiminfo.ReceptDate,Claiminfo.CustName,Claiminfo.CustAddress2 from Claiminfo where left(Claiminfo.JobCode," & shrtLen & ")='" & strTempJobCode & "' and Claiminfo.Branch='" & cmbBranch.Text & "'", MyCon)
    '    Dim comSearchjob As New OleDbCommand("Select Claiminfo.JobCode,Claiminfo.Wcondition,Claiminfo.Pdate,Claiminfo.ModelNo,Claiminfo.SLNo,Claiminfo.ReceptDate,Claiminfo.CustName,Claiminfo.CustAddress2 from Claiminfo where Claiminfo.JobCode Like '" & strTempJobCode & "%' and Claiminfo.Branch='" & cmbBranch.Text & "'", MyCon)
    '    Dim lstItem As ListViewItem


    '    Dim readSearchJob As OleDbDataReader

    '    readSearchJob = comSearchjob.ExecuteReader

    '    lstOpenLists.Items.Clear()
    '    lstOpenLists.Visible = True

    '    While readSearchJob.Read

    '        lstItem = lstOpenLists.Items.Add(readSearchJob("JobCode").ToString)
    '        If readSearchJob("WCondition").ToString = 0 Then
    '            lstItem.SubItems.Add("sls-Warr")
    '        ElseIf readSearchJob("WCondition").ToString = 1 Then
    '            lstItem.SubItems.Add("Non-Warr")
    '        ElseIf readSearchJob("WCondition").ToString = 2 Then
    '            lstItem.SubItems.Add("Svc-Warr")
    '        End If


    '        lstItem.SubItems.Add(readSearchJob("Pdate").ToString)
    '        lstItem.SubItems.Add(readSearchJob("ModelNo").ToString)
    '        lstItem.SubItems.Add(readSearchJob("SLNo").ToString)
    '        lstItem.SubItems.Add(readSearchJob("ReceptDate").ToString)
    '        lstItem.SubItems.Add(readSearchJob("CustName").ToString)
    '        lstItem.SubItems.Add(readSearchJob("CustAddress2").ToString)


    '    End While







    'End Sub




    Private Sub LoadBranch()
        Dim comLoadBranch As New OleDbCommand("Select Branch.Branch from Branch", MyCon)

        Try
            Dim BranchMethods As clsBranchMethods = New clsBranchMethods

            Dim BranchList As List(Of clsBranch) = BranchMethods.GetBranches.ToList

            If BranchList.Count > 0 Then

                For Each tempBranch As clsBranch In BranchList
                    cmbBranch.Items.Add(tempBranch.Branch)


                Next

            End If

        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & "Event: LoadBranch")
        End Try


    End Sub







    Private Function VerifyJob(ByVal strTempJobCode As String) As Boolean
        Dim intJobLenth As Integer

        intJobLenth = Len(strTempJobCode)

        If intJobLenth = 0 Then
            Return False
            Exit Function
        End If

        Dim comveifyjob As New OleDbCommand("Select Claiminfo.JobCode from Claiminfo where Claiminfo.JobCode LIKE '" & strTempJobCode & "%' and Claiminfo.Branch='" & cmbBranch.Text & "'", MyCon)




        Dim readVerifyJob As OleDbDataReader


        readVerifyJob = comveifyjob.ExecuteReader

        If readVerifyJob.Read = True Then
            Return True
        Else
            Return False

        End If








    End Function

    Private Sub txtSearchJob_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSearchJob.KeyUp

        FindJob()

    End Sub

    Private Sub FindJob()


        If txtSearchJob.Text.Length <= 0 Then
            dgvFindList.Visible = False
            Exit Sub
        End If

        Dim strSearchType As String = String.Empty


        If optJobCode.Checked = True Then
            strSearchType = "Job"
        ElseIf optCustomerName.Checked = True Then
            strSearchType = "Customer"
        ElseIf optAddress.Checked = True Then
            strSearchType = "Address"
        ElseIf optContact.Checked = True Then
            strSearchType = "Contact"
        ElseIf optEmail.Checked = True Then
            strSearchType = "Email"

        End If
        Dim ClaiminfoMethod As clsClaiminfoMethods = New clsClaiminfoMethods
        Dim Claiminfo As DataTable = New DataTable
        If strFormType.ToLower = LCase("Repair") Or strFormType.ToLower = LCase("JobStatus") Then
            Claiminfo = ClaiminfoMethod.LoadClaiminfo_OpenJob(txtSearchJob.Text, cmbBranch.Text, strSearchType)
        ElseIf strFormType.ToLower = LCase("Delivery") Then
            Claiminfo = ClaiminfoMethod.LoadClaiminfo_GetJobTable(txtSearchJob.Text, cmbBranch.Text, strSearchType)
        End If


        If Claiminfo.Rows.Count > 0 Then
            dgvFindList.Visible = True
            dgvFindList.DataSource = Nothing
            dgvFindList.DataSource = Claiminfo
        Else

            dgvFindList.Visible = False

        End If



        lblStatus.Text = "Total Job Count: " & dgvFindList.Rows.Count


    End Sub

    Private Sub cmdOpen_Click(sender As Object, e As EventArgs) Handles cmdOpen.Click

        Try
            Dim claiminfomethod As clsClaiminfoMethods = New clsClaiminfoMethods
            Dim claiminfo As clsClaiminfo = claiminfomethod.LoadClaiminfo_byJobCode(txtSearchJob.Text)

            If claiminfo.Jobcode.Length = 0 Then

                blnJobCodeFlag = False

                MsgBox("Wrong job no typed")
                Exit Sub
            Else
                blnJobCodeFlag = True

                shrtFormType = Convert.ToDecimal(2)

                publicClaiminfo = claiminfo


                Me.Close()

            End If



        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & "Event: cmdOpen_Click")
        End Try
    End Sub

    Private Function VerifyJobCode(ByVal strTempJobCode As String) As Boolean

        Dim comVerifyJobCode As New OleDbCommand("Select Claiminfo.JobCode from Claiminfo where Claiminfo.JobCode='" & strTempJobCode & "'", MyCon)

        Dim readVerifyJobCOde As OleDbDataReader




        readVerifyJobCOde = comVerifyJobCode.ExecuteReader

        If readVerifyJobCOde.Read = True Then
            Return True
        Else
            Return False
        End If

    End Function






    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        blnJobCodeFlag = False
        Me.Close()

    End Sub



    Private Sub dgvFindList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFindList.CellClick

        If e.ColumnIndex() = 0 Then
            txtSearchJob.Text = dgvFindList.CurrentCell().Value
        End If


    End Sub

    Private Sub dgvFindList_KeyUp(sender As Object, e As KeyEventArgs) Handles dgvFindList.KeyUp
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Up Then
            Dim dgvr As DataGridViewRow 'datagridviewRow

            dgvr = dgvFindList.CurrentRow

            txtSearchJob.Text = dgvr.Cells(0).Value

        End If

        If e.KeyCode = Keys.Enter Then
            cmdOpen_Click(sender, e)
        End If

    End Sub

    Private Sub txtSearchJob_TextChanged(sender As Object, e As EventArgs) Handles txtSearchJob.TextChanged

    End Sub

    Private Sub dgvFindList_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvFindList.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdOpen_Click(sender, tempEventAtg)
        End If

        'If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Up Then
        '    Dim dgvr As DataGridViewRow 'datagridviewRow

        '    dgvr = dgvFindList.CurrentRow

        '    txtSearchJob.Text = dgvr.Cells(0).Value

        'End If
    End Sub


    Private Sub optJobCode_CheckedChanged(sender As Object, e As EventArgs) Handles optJobCode.CheckedChanged
        dgvFindList.Top = txtSearchJob.Top + txtSearchJob.Height + 5
        txtSearchJob.Text = String.Empty
        txtSearchJob.Select()

    End Sub
    Private Sub optCustomerName_CheckedChanged(sender As Object, e As EventArgs) Handles optCustomerName.CheckedChanged
        txtSearchJob.Text = String.Empty
        txtSearchJob.Select()
    End Sub
    Private Sub txtCustomer_KeyUp(sender As Object, e As KeyEventArgs)
        FindJob()
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            If dgvFindList.Visible = True Then
                dgvFindList.Rows(0).Selected = True
                dgvFindList.Select()
                Dim dgvrow As DataGridViewRow = New DataGridViewRow
                dgvrow = dgvFindList.Rows(0)
                txtSearchJob.Text = dgvrow.Cells(0).Value
            End If
        End If
    End Sub

    Private Sub txtSearchJob_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchJob.KeyDown
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Enter Then
            If dgvFindList.Visible = True Then
                Dim dgvrow As DataGridViewRow = New DataGridViewRow
                dgvrow = dgvFindList.Rows(0)
                txtSearchJob.Text = dgvrow.Cells(0).Value
                dgvFindList.Rows(0).Selected = True
                dgvFindList.Select()


            End If
        End If
    End Sub


    Private Sub cmbBranch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBranch.SelectedIndexChanged

    End Sub

    Private Sub cmbBranch_KeyUp(sender As Object, e As KeyEventArgs) Handles cmbBranch.KeyUp
        If e.KeyCode = Keys.Enter Then
            txtSearchJob.Select()

        End If
    End Sub

    Private Sub optAddress_CheckedChanged(sender As Object, e As EventArgs) Handles optAddress.CheckedChanged
        txtSearchJob.Text = String.Empty
        txtSearchJob.Select()
    End Sub

    Private Sub optContact_CheckedChanged(sender As Object, e As EventArgs) Handles optContact.CheckedChanged
        txtSearchJob.Text = String.Empty
        txtSearchJob.Select()

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles optEmail.CheckedChanged
        txtSearchJob.Text = String.Empty
        txtSearchJob.Select()
    End Sub

    Private Sub dgvFindList_Click(sender As Object, e As EventArgs) Handles dgvFindList.Click

        If dgvFindList.SelectedRows.Count > 0 Then
            txtSearchJob.Text = dgvFindList.SelectedRows(0).Cells(0).Value

        End If

    End Sub

    Private Sub dgvFindList_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFindList.CellContentDoubleClick
        Try

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


End Class

