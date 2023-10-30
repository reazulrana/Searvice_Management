Imports System.ComponentModel

Public Class frmClaimList



    Dim strStatus As String ' Decalare for Add, update,Delete Record
    Dim claim As clsClaimlist = New clsClaimlist ' Get Previous Category, Claim for making update

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Me.Close()
    End Sub

    Private Sub frmClaimList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterForm(Me)
        LoadCategory()
        LoadClaimList()




        mnuNew_Click(sender, e)







    End Sub


    Private Sub LoadCategory()
        Dim CM As clscTypeMethods = New clscTypeMethods

        Dim lCategory As List(Of clscType) = CM.GetAllCategory.ToList


        If lCategory.Count > 0 Then
            cmbCategory.Items.Clear()

            For Each Category In lCategory
                cmbCategory.Items.Add(Category.CategoryName)
            Next


        End If

    End Sub


    Private Sub LoadClaimList()

        Dim cm As clsClaimlistMethods = New clsClaimlistMethods

        Dim lClaimList As List(Of clsClaimlist) = cm.GetAllClaimList.ToList.Where(Function(x As clsClaimlist) x.CategoryName.ToLower = cmbCategory.Text.ToLower).OrderBy(Function(ByVal x) x.ClaimCode).ToList
        Dim lstItem As New ListViewItem

        If lClaimList.Count > 0 Then
            lstClaimList.Items.Clear()

            For Each claim As clsClaimlist In lClaimList
                lstItem = lstClaimList.Items.Add(lstClaimList.Items.Count + 1)
                lstItem.Tag = claim.ClaimCode
                lstItem.SubItems.Add(claim.CategoryName)
                lstItem.SubItems.Add(claim.Claim)
            Next

        End If






    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click




        If cmbCategory.Text.Length <= 0 Then
            MessageBox.Show("Category is Blank")
            chkEnable.Enabled = True
            cmbCategory.Select()
            Exit Sub
        End If


        If txtFault.Text.Length <= 0 Then

            MessageBox.Show("Claim Field is Blank")
            txtFault.Select()
            Exit Sub
        End If


        Try
            If strStatus.ToLower = "New".ToLower Then
                SaveNew()
                LoadClaimList()
                MessageBox.Show("Save Record Successfully")
            End If


            If strStatus.ToLower = "Edit".ToLower Then
                EditClaim()
                LoadClaimList()
                MessageBox.Show("Update Record Successfully")
            End If

        Catch dbError As OleDb.OleDbException

            MessageBox.Equals(dbError.Message, dbError.Source)


        Catch ex As Exception

        End Try

    End Sub


    Private Sub SaveNew()
        Dim clm As clsClaimlistMethods = New clsClaimlistMethods


        Dim MaxNo As List(Of clsClaimlist) = clm.GetAllClaimList.Where(Function(ByVal x As clsClaimlist) x.CategoryName.ToLower = cmbCategory.Text.ToLower).ToList



        Dim newClaim As clsClaimlist = New clsClaimlist


        newClaim.ClaimCode = MaxNo.Count + 1
        newClaim.CategoryName = cmbCategory.Text
        newClaim.Claim = txtFault.Text



        clm.Insert(newClaim)
    End Sub

    Private Sub EditClaim()
        Dim clm As clsClaimlistMethods = New clsClaimlistMethods






        Dim newClaim As clsClaimlist = New clsClaimlist


        newClaim.ClaimCode = claim.ClaimCode
        newClaim.CategoryName = cmbCategory.Text
        newClaim.Claim = txtFault.Text



        clm.Update(newClaim, claim)
        newClaim = Nothing
        claim = Nothing

    End Sub

    Private Sub chkEnable_CheckedChanged(sender As Object, e As EventArgs) Handles chkEnable.CheckedChanged
        If chkEnable.Checked = True Then
            cmbCategory.Enabled = True
        Else
            cmbCategory.Enabled = False
        End If
    End Sub

    Private Sub frmClaimList_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        ReleaseCapture()
        SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
    End Sub



    Private Sub pnlHeader_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlHeader.MouseDown
        ReleaseCapture()
        SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
    End Sub





    Private Sub lstClaimList_MouseDown(sender As Object, e As MouseEventArgs) Handles lstClaimList.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then

            Dim lstItem As ListViewItem = lstClaimList.HitTest(e.Location).Item


            If Not lstItem Is Nothing Then
                claim.ClaimCode = lstItem.Tag
                claim.CategoryName = lstItem.SubItems(1).Text
                claim.Claim = lstItem.SubItems(2).Text

                cntxMenu.Visible = True

            End If



        End If
    End Sub

    Private Sub mnuNew_Click(sender As Object, e As EventArgs) Handles mnuNew.Click
        strStatus = "New"
        chkEnable.Enabled = True
        txtFault.Text = String.Empty
        txtFault.Select()

    End Sub

    Private Sub mnuEdit_Click(sender As Object, e As EventArgs) Handles mnuEdit.Click
        strStatus = "Edit"

        If Not claim Is Nothing Then
            cmbCategory.Text = claim.CategoryName
            txtFault.Text = claim.Claim
            chkEnable.Enabled = False
            txtFault.Select()
        End If

    End Sub

    Private Sub lstClaimList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstClaimList.SelectedIndexChanged

    End Sub

    Private Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged

    End Sub

    Private Sub cmbCategory_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbCategory.KeyPress

        e.Handled = True
    End Sub

    Private Sub mnuDelete_Click(sender As Object, e As EventArgs) Handles mnuDelete.Click

        Dim claimMethods As clsClaimlistMethods = New clsClaimlistMethods
        Try

            claimMethods.Delete(claim)
            LoadClaimList()

        Catch ex As Exception
            MessageBox.Show(ex.StackTrace, ex.Message)
        End Try
    End Sub
End Class