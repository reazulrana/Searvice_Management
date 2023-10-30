Imports System.Configuration
Imports System.Data.OleDb
Imports System.Data
Imports System.Collections.Generic
Imports System.Collections
Imports System.ComponentModel

Public Class frmTransfer

    Public TransferJobClass As clsTransferJob = New clsTransferJob
    Private Sub frmTransfer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterForm(Me)
        loadBranch()
        LoadPersonal()
        LoadInformation()
    End Sub


    Private Sub loadBranch()
        Dim bm As clsBranchMethods = New clsBranchMethods
        Dim listBranch As List(Of clsBranch) = bm.GetBranches.ToList
        cmbBranch.Items.Clear()
        cmbBranchFrom.Items.Clear()

        If listBranch.Count > 0 Then
            For Each branch As clsBranch In listBranch
                cmbBranch.Items.Add(branch.Branch)
                cmbBranchFrom.Items.Add(branch.Branch)
            Next
        End If
    End Sub

    Private Sub LoadInformation()
        Dim tfm As clsTransferJobMethods = New clsTransferJobMethods
        Dim transfer As clsTransferJob = New clsTransferJob
        ClearAll()
        txtJobCode.Text = TransferJobClass.JobCode


        Try
            If Not String.IsNullOrEmpty(TransferJobClass.TransferFrom) Then
                cmbBranchFrom.Text = TransferJobClass.TransferFrom
            Else
                cmbBranchFrom.Text = My.Computer.Registry.CurrentUser.OpenSubKey("Software\Company Software\Service").GetValue("Default_Branch")
            End If
        Catch ex As Exception

        End Try




        If tfm.IsExist(TransferJobClass.JobCode) = True Then
            transfer = tfm.GetSingleTransfer(TransferJobClass.JobCode)
            cmbBranch.Text = transfer.TransferTo
            If Not String.IsNullOrEmpty(transfer.TrDate) Then
                dtTrDate.Value = transfer.TrDate.ToShortDateString
            End If
            txtRemarks.Text = transfer.Remarks
            cmbTansferby.Text = transfer.TrByCode
            lblTransferby.Text = transfer.TrByName
        End If

    End Sub


    Private Sub ClearAll()
        txtJobCode.Text = String.Empty
        cmbBranchFrom.Text = String.Empty



        cmbBranch.Text = String.Empty

        dtTrDate.Value = Now.ToShortDateString
        txtRemarks.Text = String.Empty
        cmbTansferby.Text = String.Empty
        lblTransferby.Text = String.Empty
    End Sub


    Private Sub LoadPersonal()
        Dim empMethods As clsPersonalMethods = New clsPersonalMethods
        Dim ListEmployee As List(Of clsPersonal) = empMethods.LoadTechnician.ToList

        If ListEmployee.Count > 0 Then
            For Each p As clsPersonal In ListEmployee
                cmbTansferby.Items.Add(p.EmpCode)

            Next
        End If

    End Sub

    Private Sub cmbTansferby_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTansferby.SelectedIndexChanged
        lblTransferby.Text = TechName(cmbTansferby.Text)
    End Sub

    Private Function TechName(ByVal empCode As String) As String
        Dim empM As clsPersonalMethods = New clsPersonalMethods

        Dim emp As List(Of clsPersonal) = empM.LoadTechnician(empCode).ToList
        Dim strTechName As String
        If emp.Count > 0 Then
            For Each e As clsPersonal In emp
                strTechName = e.EmpName
            Next

        End If

        Return strTechName


    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub




    Private Function Checkvalidation(ByRef msg As String) As Boolean

        Dim blnFlag As Boolean = True

        Dim claim As clsClaiminfoMethods = New clsClaiminfoMethods




        If cmbBranchFrom.Text.Length <= 0 Then
            blnFlag = False
            msg = "BranchFrom"
        End If


        If claim.IsExist(txtJobCode.Text) = False Then
            blnFlag = False
            msg = "JobCode"
        End If


        If cmbBranch.Text.Length <= 0 Then
            blnFlag = False
            msg = "Branch"
        End If

        If cmbTansferby.Text.Length <= 0 Then
            blnFlag = False
            msg = "Transferby"
        End If




        Return blnFlag




    End Function





    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim strMsg As String = String.Empty


        If Checkvalidation(strMsg) = False Then

            If strMsg.ToLower() = "JobCOde".ToLower Then

                chkActiveJob.Checked = True
                txtJobCode.Select()


            End If

            If strMsg.ToLower = "BranchFrom".ToLower Then
                chkActiveBranch.Checked = True
                cmbBranchFrom.Select()

            End If


            If strMsg.ToLower = "Branch".ToLower Then
                cmbBranch.Select()

            End If


            If strMsg.ToLower = "Transferby".ToLower Then
                cmbTansferby.Select()
            End If


            Exit Sub

        End If




        Dim Trm As clsTransferJobMethods = New clsTransferJobMethods
        Dim Transfer As clsTransferJob = New clsTransferJob
        Transfer.JobCode = txtJobCode.Text
        Transfer.TransferFrom = cmbBranchFrom.Text
        Transfer.TransferTo = cmbBranch.Text
        Transfer.Remarks = txtRemarks.Text
        Transfer.TrDate = dtTrDate.Value.ToShortDateString
        Transfer.TrByCode = cmbTansferby.Text
        Transfer.TrByName = lblTransferby.Text

        Try

            If Trm.IsExist(txtJobCode.Text) = True Then
                Trm.Update(Transfer, Transfer.JobCode)
            Else
                Trm.Save(Transfer)
            End If
            MessageBox.Show("Job Transfer Successfully")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub chkActiveJob_CheckedChanged(sender As Object, e As EventArgs) Handles chkActiveJob.CheckedChanged
        If chkActiveJob.Checked = True Then
            txtJobCode.Enabled = True
        Else
            txtJobCode.Enabled = False
        End If
    End Sub

    Private Sub chkActiveBranch_CheckedChanged(sender As Object, e As EventArgs) Handles chkActiveBranch.CheckedChanged
        If chkActiveBranch.Checked = True Then
            cmbBranchFrom.Enabled = True
        Else
            cmbBranchFrom.Enabled = False
        End If
    End Sub



    Private Sub LoadJobList()

        Dim bm As clsBranchMethods = New clsBranchMethods


        If bm.Isexist(cmbBranchFrom.Text) = True Then

            Dim dt As DataTable = dtJobList()

            dgvJobList.DataSource = Nothing

            If dt.Rows.Count > 0 Then
                dgvJobList.Rows.Clear()
                dgvJobList.DataSource = dtJobList()

                dgvJobList.Columns(0).Width = 100
                dgvJobList.Columns(1).Width = 120
                dgvJobList.Columns(2).Width = 160

            End If



        Else
            MessageBox.Show("Branch not correct")
            chkActiveBranch.Checked = False
            cmbBranchFrom.Select()
            Exit Sub
        End If












    End Sub

    Private Sub txtJobCode_TextChanged(sender As Object, e As EventArgs) Handles txtJobCode.TextChanged








    End Sub


    Private Sub txtJobCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtJobCode.KeyDown

        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Up Then
            If dgvJobList.Visible = True Then
                dgvJobList.Select()
                dgvJobList.Rows(0).Selected = True
                txtJobCode.Text = dgvJobList.CurrentRow.Cells(0).Value
            End If

        End If

    End Sub




    Private Sub txtJobCode_KeyUp(sender As Object, e As KeyEventArgs) Handles txtJobCode.KeyUp
        If txtJobCode.Text.Length <= 0 Then
            dgvJobList.Visible = False
            Exit Sub
        Else
            dgvJobList.Visible = True
        End If


        LoadJobList()


    End Sub



    Private Sub dgvJobList_KeyUp(sender As Object, e As KeyEventArgs) Handles dgvJobList.KeyUp



        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.Up Then
            txtJobCode.Text = dgvJobList.CurrentRow.Cells(0).Value
        End If

        If e.KeyCode = Keys.Tab Then
            cmbBranch.Select()

        End If

    End Sub


    Private Function dtJobList() As DataTable

        Dim dt As DataTable = New DataTable

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Dim strParameter = txtJobCode.Text & "%"

        Dim strQuery = "select Claiminfo.JobCode, Claiminfo.Branch, Claiminfo.CustName from Claiminfo where Claiminfo.Jobcode like [@JobCode] and Claiminfo.Branch=@Branch and Claiminfo.cFlag in(-1,9)"


        Using con As OleDbConnection = New OleDbConnection(cs)

            Dim dc As OleDbCommand = New OleDbCommand(strQuery, con)

            dc.Parameters.Add("@JobCode", OleDbType.Char, 255).Value = strParameter
            dc.Parameters.Add("@Branch", OleDbType.Char, 255).Value = cmbBranchFrom.Text

            con.Open()
            Dim dr As OleDbDataReader = dc.ExecuteReader


            If dr.HasRows = True Then
                dt.Load(dr)
            End If




        End Using


        Return dt

    End Function

    Private Sub dgvJobList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvJobList.CellContentClick

    End Sub

    Private Sub dgvJobList_Click(sender As Object, e As EventArgs) Handles dgvJobList.Click

    End Sub

    Private Sub dgvJobList_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvJobList.MouseClick



    End Sub

    Private Sub dgvJobList_Leave(sender As Object, e As EventArgs) Handles dgvJobList.Leave
        dgvJobList.Visible = False
    End Sub



    Private Sub txtJobCode_Validating(sender As Object, e As CancelEventArgs) Handles txtJobCode.Validating
        Dim clm As clsClaiminfoMethods = New clsClaiminfoMethods
        If txtJobCode.Text.Length > 0 Then

            If clm.IsExist(txtJobCode.Text) = False Then

            MessageBox.Show("Job not found")
            e.Cancel = True

        End If


        End If

    End Sub


End Class
