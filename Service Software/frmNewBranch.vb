Imports System
Imports System.Data
Imports System.Data.OleDb




Public Class frmNewBranch

    Dim blnFlag As Boolean = False
    Dim strPreviousBranchName As String = String.Empty
    Dim checkListViewItem As ListView = Nothing


    Private Sub frmNewBranch_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Try





            cmdNewBranch.Text = "Save New"

            LoadBranch()

            CenterForm(Me)





        Catch ExLoadBranch As Exception
            MsgBox("Branch Loading Problem", vbCritical, "Not Successfully loaded")


        End Try

    End Sub

    Private Sub LoadBranch()
        blnFlag = False
        Dim loadBranchmethods As clsBranchMethods = New clsBranchMethods

        Dim ListBranch As List(Of clsBranch) = loadBranchmethods.GetBranches.ToList




        If ListBranch.Count > 0 Then

            If lstNewBranch.Items.Count > 0 Then
                lstNewBranch.Items.Clear()
            End If

            For Each tmpBranch As clsBranch In ListBranch

                Dim lstitem As New ListViewItem





                lstitem = lstNewBranch.Items.Add(lstNewBranch.Items.Count + 1)
                lstitem.SubItems.Add(tmpBranch.Branch)
                lstitem.SubItems.Add(tmpBranch.phone)
                If tmpBranch.Flag = True Then
                    lstitem.SubItems.Add("Opened")
                    lstitem.ForeColor = Color.White
                    lstitem.Checked = True
                Else
                    lstitem.SubItems.Add("Closed")
                    lstitem.ForeColor = Color.Red


                End If

                lstitem.SubItems.Add(tmpBranch.OfficeTime)
                lstitem.SubItems.Add(tmpBranch.Holiday)
                lstitem.SubItems.Add(tmpBranch.Address)


            Next


        End If
        blnFlag = True


    End Sub



    Private Sub cmdNewBranch_Click(sender As Object, e As EventArgs) Handles cmdNewBranch.Click
        Try


            Dim strMsg As String = String.Empty

            If txtBranchName.Text = String.Empty Then
                MsgBox("Branch Name is Blanked")
                txtBranchName.Select()
                Exit Sub

            End If

            Dim BranchMethods As clsBranchMethods = New clsBranchMethods
            Dim Branch As clsBranch = New clsBranch


            Branch.Branch = txtBranchName.Text
            Branch.phone = txtContactName.Text
            Branch.Flag = True
            Branch.OfficeTime = txtOfficeTime.Text

            Branch.Holiday = txtHoliday.Text
            Branch.Address = txtAddress.Text


            If chkEdit.Checked = False Then
                BranchMethods.Save(Branch)
                strMsg = "Save Successfully"

            Else
                BranchMethods.Update(Branch, strPreviousBranchName)
                strMsg = "Update Successfully"

            End If
            LoadBranch()
            ClearField()

            MessageBox.Show(strMsg)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try




    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Dispose()



    End Sub

    Private Sub frmNewBranch_Resize(sender As Object, e As EventArgs) Handles Me.Resize


        lblBottomLayer.Top = Me.Height - lblBottomLayer.Height
        cmdNewBranch.Left = lstNewBranch.Left
        cmdNewBranch.Width = (lstNewBranch.Width - lstNewBranch.Left) / 3
        cmdDelete.Left = cmdNewBranch.Left + cmdNewBranch.Width
        cmdDelete.Width = (lstNewBranch.Width - lstNewBranch.Left) / 3

        cmdClose.Width = (lstNewBranch.Width - lstNewBranch.Left) / 3
        cmdClose.Left = cmdDelete.Width + cmdDelete.Left


        cmdNewBranch.Top = lblBottomLayer.Top - (cmdNewBranch.Height + 2)
        cmdClose.Top = cmdNewBranch.Top
        cmdDelete.Top = cmdClose.Top
    End Sub

    Private Sub lstNewBranch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstNewBranch.SelectedIndexChanged
        If chkEdit.Checked = True Then
            If lstNewBranch.FocusedItem.Selected = True Then
                txtBranchName.Text = lstNewBranch.FocusedItem.SubItems(1).Text
                txtContactName.Text = lstNewBranch.FocusedItem.SubItems(2).Text
                txtOfficeTime.Text = "" & lstNewBranch.FocusedItem.SubItems(4).Text
                txtHoliday.Text = "" & lstNewBranch.FocusedItem.SubItems(5).Text
                txtAddress.Text = "" & lstNewBranch.FocusedItem.SubItems(6).Text

                strPreviousBranchName = lstNewBranch.FocusedItem.SubItems(1).Text

            End If





        End If
    End Sub

    Private Sub lstNewBranch_ItemChecked(sender As Object, e As ItemCheckedEventArgs) Handles lstNewBranch.ItemChecked
        Try

            If blnFlag = True Then
            Dim branchMethods As clsBranchMethods = New clsBranchMethods

            Dim branch As clsBranch = New clsBranch
            branch.Branch = e.Item.SubItems(1).Text
            branch.phone = e.Item.SubItems(2).Text

                branch.OfficeTime = e.Item.SubItems(4).Text
                branch.Holiday = e.Item.SubItems(5).Text

                If e.Item.Checked = True Then

                branch.Flag = True



                branchMethods.Update(branch, e.Item.SubItems(1).Text)

                e.Item.SubItems(3).Text = "Opend"
                    e.Item.ForeColor = Color.White
                Else
                branch.Flag = False
                branchMethods.Update(branch, e.Item.SubItems(1).Text)
                e.Item.SubItems(3).Text = "Closed"
                e.Item.ForeColor = Color.Red
            End If
        End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub ClearField()

        txtBranchName.Text = String.Empty
        txtContactName.Text = String.Empty
        txtOfficeTime.Text = String.Empty
        txtHoliday.Text = String.Empty
        txtAddress.Text = String.Empty

    End Sub

    Private Sub frmNewBranch_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Dispose(blnFlag)

    End Sub






    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtHoliday_TextChanged(sender As Object, e As EventArgs) Handles txtHoliday.TextChanged

    End Sub

    Private Sub chkEdit_CheckedChanged(sender As Object, e As EventArgs) Handles chkEdit.CheckedChanged
        Try


            If chkEdit.Checked = True Then
                cmdNewBranch.Text = "Update"
                If lstNewBranch.SelectedItems.Count > 0 Then
                    txtBranchName.Text = lstNewBranch.FocusedItem.SubItems(1).Text
                    txtContactName.Text = lstNewBranch.FocusedItem.SubItems(2).Text
                    txtOfficeTime.Text = "" & lstNewBranch.FocusedItem.SubItems(4).Text
                    txtHoliday.Text = "" & lstNewBranch.FocusedItem.SubItems(5).Text
                    txtAddress.Text = "" & lstNewBranch.FocusedItem.SubItems(6).Text
                    strPreviousBranchName = lstNewBranch.FocusedItem.SubItems(1).Text
                End If
            Else
                cmdNewBranch.Text = "Save New"
                ClearField()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Me.Dispose()

    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        Dim BranchMethods As clsBranchMethods = New clsBranchMethods

        If lstNewBranch.SelectedItems.Count = 0 Then

            MessageBox.Show("Branch is not selected")
            Exit Sub
        Else
            If MessageBox.Show("Are you sure to delete the record from Database", "Delete Record", MessageBoxButtons.YesNo) = DialogResult.Yes Then


                BranchMethods.Delete(lstNewBranch.FocusedItem.SubItems(1).Text)
                MessageBox.Show("Branch is deleted")
                LoadBranch()
            End If
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label5_MouseDown(sender As Object, e As MouseEventArgs) Handles Label5.MouseDown
        ReleaseCapture()
        SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
    End Sub

    Private Sub frmNewBranch_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        ReleaseCapture()
        SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
    End Sub
End Class