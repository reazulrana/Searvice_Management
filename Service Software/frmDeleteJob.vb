Public Class frmDeleteJob
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim brmethods As clsBranchMethods = New clsBranchMethods
        Dim claiminfomethods As clsClaiminfoMethods = New clsClaiminfoMethods

        Dim claiminfo As clsClaiminfo = New clsClaiminfo



        If Not String.IsNullOrEmpty(Trim(cmbBranch.Text)) Then
            Dim branch As clsBranch = brmethods.VerifyBranch(cmbBranch.Text)
            If IsNothing(branch.Branch) Then
                MessageBox.Show("Branch Name Is Incorrect")
                cmbBranch.Select()
                Exit Sub
            End If
        Else
            MessageBox.Show("Branch is Blank")
            cmbBranch.Select()
            Exit Sub
        End If

        If String.IsNullOrEmpty(Trim(txtJobCode.Text)) Then
            MessageBox.Show("Job code is blank")
            txtJobCode.Select()

            Exit Sub

        End If

        claiminfo = claiminfomethods.LoadClaiminfo_byJobCode(txtJobCode.Text)

        If IsNothing(claiminfo.Jobcode) Then
            MessageBox.Show("Job not found please Check")
            txtJobCode.Select()

            Exit Sub
        Else

            If MessageBox.Show("Note: The Job Will completely be Deleted From Database", "Delete Job", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                claiminfomethods.Delete(claiminfo.Jobcode)
                MessageBox.Show("Deleted Job Successfully; Job No:' " & claiminfo.Jobcode & "'")
                Me.Close()
            End If
        End If







    End Sub

    Private Sub frmDeleteJob_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBranch()
    End Sub


    Private Sub LoadBranch()

        Dim brmethods As clsBranchMethods = New clsBranchMethods
        Dim branches As List(Of clsBranch) = brmethods.GetBranches.ToList

        For Each b As clsBranch In branches
            cmbBranch.Items.Add(b.Branch)

        Next





    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub
End Class