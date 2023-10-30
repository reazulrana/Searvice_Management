Public Class frmtbStorageSet
    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles txtAccessories.TextChanged

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles txtItem.TextChanged

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub txtBin_TextChanged(sender As Object, e As EventArgs) Handles txtBin.TextChanged

    End Sub

    Private Sub txtSearchJob_TextChanged(sender As Object, e As EventArgs) Handles txtSearchJob.TextChanged
        Dim cm As clsClaiminfoMethods = New clsClaiminfoMethods
        Dim dtClaiminfo As DataTable = cm.LoadJobswithLetter(txtSearchJob.Text)



        If dtClaiminfo.Rows.Count > 0 Then

            If txtSearchJob.TextLength > 0 Then
                dgvJobList.Left = txtSearchJob.Left
                dgvJobList.Top = txtSearchJob.Top + txtSearchJob.Height
                dgvJobList.Height = 250
                dgvJobList.Visible = True
                dgvJobList.DataSource = Nothing
            Else
                dgvJobList.Visible = False
            End If


            dgvJobList.DataSource = dtClaiminfo


        End If


    End Sub

    Private Sub frmtbStorageSet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterForm(Me)
        dgvJobList.Visible = False
        dgvJobList.Width = 300
        LoadBranch()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub


    Private Sub ClearField()
        txtLocaltion.Text = String.Empty
        cmbBranch.Text = String.Empty
        txtBin.Text = String.Empty
        txtRemarks.Text = String.Empty
    End Sub

    Private Sub ClearALL()
        txtLocaltion.Text = String.Empty
        cmbBranch.Text = String.Empty
        txtBin.Text = String.Empty
        txtRemarks.Text = String.Empty
        txtCategory.Text = String.Empty

        txtBrand.Text = String.Empty
        txtModel.Text = String.Empty
        txtSerial.Text = String.Empty
        txtReceptDate.Text = String.Empty

        txtJobCode.Text = String.Empty
        txtBranch.Text = String.Empty
        txtWarrType.Text = String.Empty
        txtStatus.Text = String.Empty
        txtFault.Text = String.Empty
        txtItem.Text = String.Empty
        txtAccessories.Text = String.Empty
        txtSearchJob.Text = String.Empty
        txtSearchJob.Select()


    End Sub

    Private Sub txtSearchJob_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSearchJob.KeyUp
        If e.KeyCode = Keys.Down Then
            If dgvJobList.Visible = True Then
                dgvJobList.Select()
            End If
        End If

    End Sub

    Private Sub dgvJobList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvJobList.CellContentClick

    End Sub

    Private Sub dgvJobList_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dgvJobList.KeyPress

    End Sub

    Private Sub dgvJobList_KeyUp(sender As Object, e As KeyEventArgs) Handles dgvJobList.KeyUp

    End Sub

    Private Sub txtSearchJob_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearchJob.KeyPress

    End Sub

    Private Sub Loadinformation(ByVal SearchID As String)

        Dim cm As clsClaiminfoMethods = New clsClaiminfoMethods

        Dim Claiminfo As clsClaiminfo = cm.LoadClaiminfo_byJobCode(SearchID)

        ClearALL()

        If cm.IsExist(Claiminfo.Jobcode) Then

            txtJobCode.Text = Claiminfo.Jobcode
            txtBranch.Text = Claiminfo.Branch
            If Claiminfo.WCondition = 0 Then
                txtWarrType.Text = "Sales Warranty"
            ElseIf Claiminfo.WCondition = 1 Then
                txtWarrType.Text = "Non Warranty"
            ElseIf Claiminfo.WCondition = 2 Then
                txtWarrType.Text = "Service Warranty"
            End If
            If Claiminfo.cFlag = -1 Then
                txtStatus.Text = "Not Repaired"
            ElseIf Claiminfo.cFlag = 1 Then
                txtStatus.Text = "Repaired"
            ElseIf Claiminfo.cFlag = 99 Then
                txtStatus.Text = "N/R"
            ElseIf Claiminfo.cFlag = 9 Then
                txtStatus.Text = "Pending"
            ElseIf Claiminfo.cFlag = 101 Then
                txtStatus.Text = "Replace"
            ElseIf Claiminfo.cFlag = 110 Then
                txtStatus.Text = "Storage"
            ElseIf Claiminfo.cFlag = 111 Then
                txtStatus.Text = "Transfer"
            End If

            txtCategory.Text = Claiminfo.ServiceType
            txtBrand.Text = Claiminfo.Brand
            txtModel.Text = Claiminfo.ModelNo
            txtSerial.Text = Claiminfo.SLNo
            txtReceptDate.Text = Claiminfo.ReceptDate
            txtItem.Text = Claiminfo.ReturnedItems

            Dim cusm As clsCustomerClaimMethods = New clsCustomerClaimMethods
            Dim Claim As clsCustomerClaim = New clsCustomerClaim

            If cusm.IsExist(Claiminfo.Jobcode) Then

                Claim = cusm.GetCustomerClaim(Claiminfo.Jobcode)
                txtFault.Text = Claim.ClaimCode
            End If

            Dim svm As clsServiceItemMethods = New clsServiceItemMethods
            Dim serviceitem As clsServiceItem = New clsServiceItem

            If svm.IsExist(Claiminfo.Jobcode) = True Then
                serviceitem = svm.GetItem(Claiminfo.Jobcode)
                txtAccessories.Text = serviceitem.Item
            End If

            Dim stm As clstbStorageSetMethods = New clstbStorageSetMethods
            Dim storage As clstbStorageSet = New clstbStorageSet
            If stm.IsExist(Claiminfo.Jobcode) = True Then
                storage = stm.GetSingleStorageSet(Claiminfo.Jobcode)
                txtLocaltion.Text = storage.Location

                If Not String.IsNullOrEmpty(storage.SendDate) Then
                    dtpStorage.Value = storage.SendDate
                End If

                txtBin.Text = storage.Bin
                cmbBranch.Text = storage.Branch
                txtRemarks.Text = storage.Remarks
            End If

        End If

    End Sub

    Private Sub dgvJobList_HandleDestroyed(sender As Object, e As EventArgs) Handles dgvJobList.HandleDestroyed

    End Sub

    Private Sub dgvJobList_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvJobList.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim dgv As DataGridViewRow

            dgv = dgvJobList.CurrentRow
            Loadinformation(dgv.Cells(0).Value)
            txtSearchJob.Text = dgv.Cells(0).Value
            dgvJobList.Visible = False
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim stm As clstbStorageSetMethods = New clstbStorageSetMethods

        Dim storage As clstbStorageSet = New clstbStorageSet
        storage.Location = txtLocaltion.Text
        storage.SendDate = dtpStorage.Value.ToShortDateString
        storage.Bin = txtBin.Text
        storage.Remarks = txtRemarks.Text
        storage.Branch = txtBranch.Text

        If stm.IsExist(txtJobCode.Text) = True Then
            stm.Update(storage, storage.JobCode)
        Else
            stm.Save(storage)
        End If

    End Sub

    Private Sub LoadBranch()

        Dim Bm As clsBranchMethods = New clsBranchMethods
        Dim listBranch As List(Of clsBranch) = Bm.GetBranches().ToList
        cmbBranch.Items.Clear()

        If listBranch.Count > 0 Then
            For Each branch As clsBranch In listBranch
                cmbBranch.Items.Add(branch.Branch)
            Next

        End If

    End Sub

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        ClearALL()
    End Sub
End Class