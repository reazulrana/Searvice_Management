Imports System.Data.OleDb


Public Class frmSetBranch
    Private Sub frmSetBranch_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Dim clsTempBranchMethods As clsBranchMethods = New clsBranchMethods
        Dim BranchList As List(Of clsBranch) = clsTempBranchMethods.GetBranches
        CenterForm(Me)

        For Each Branch As clsBranch In BranchList
            cmbBranch.Items.Add(Branch.Branch)

        Next
        FieldDefaultValue()
    End Sub
    Private Sub FieldDefaultValue()
        Try

            cmbBranch.Text = My.Computer.Registry.CurrentUser.OpenSubKey("Software\Company Software\Service").GetValue("Default_Branch")
        Catch ex As Exception

        End Try




    End Sub

    Private Sub cmdSet_Click(sender As Object, e As EventArgs) Handles cmdSet.Click

        If String.IsNullOrEmpty(cmbBranch.Text) Then

            MessageBox.Show("No Branch Selected")
            Exit Sub

        Else

            My.Computer.Registry.CurrentUser.CreateSubKey("Software\Company SoftWare\Service").SetValue("Default_Branch", cmbBranch.Text)
            MsgBox("New Branch Set", vbInformation + vbOKOnly, "Brancg Set Successfully")
        End If




    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click

        If IsNothing(My.Computer.Registry.CurrentUser.CreateSubKey("Software\Company SoftWare\Service").GetValue("Default_Branch", cmbBranch.Text)) Then
            MessageBox.Show("No Branch Selected")
            Exit Sub

        End If
        Me.Close()

    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim frmTempNewBranch As New frmNewBranch
        frmTempNewBranch.ShowDialog()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label1_MouseDown(sender As Object, e As MouseEventArgs) Handles Label1.MouseDown
        ReleaseCapture()
        SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
    End Sub

    Private Sub frmSetBranch_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        ReleaseCapture()
        SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
    End Sub
End Class