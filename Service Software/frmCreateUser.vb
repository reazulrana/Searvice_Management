Public Class frmCreateUser


    Private strSaveUpdate As String = String.Empty
    Dim lstItem As ListViewItem = New ListViewItem ' Uses to Get UserID to Delete User

    Private Function isValidate() As Boolean





        Dim blnFlag As Boolean = True

        If chkInsert.Checked = False Then
            blnFlag = False
        End If

        If chkUpdate.Checked = False Then
            blnFlag = False
        End If


        If chkDelete.Checked = False Then
            blnFlag = False
        End If


        If chkSelect.Checked = False Then
            blnFlag = False
        End If


        Return blnFlag

    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try

            If strSaveUpdate.ToLower = LCase("Edit") Then


                If checkUserCrediantial() = False Then 'check User Exist or not
                    MessageBox.Show("User Name Or Password does not matched")
                    txtUserName.Select()
                End If
            End If

            ' check Insert, update, Delete, Select checkbox checked or not. If none of them is checked then throw exception
            If isValidate() = False Then
                MessageBox.Show("You Have to Select at least One option")
                Exit Sub
            End If



            Dim userMethods As clsUserInfoMethods = New clsUserInfoMethods
            Dim user As clsUserInfo = New clsUserInfo



            user.UserName = txtUserName.Text
            user.Password = txtNewPassword.Text
            user.UserType = cmbUserType.SelectedItem.ToString


            If chkInsert.Checked = True Then
                user.Ins = True
            Else
                user.Ins = False

            End If

            If chkUpdate.Checked = True Then
                user.Upd = True
            Else
                user.Upd = False
            End If



            If chkDelete.Checked = True Then
                user.Del = True
            Else
                user.Del = False

            End If


            If chkSelect.Checked = True Then
                user.Sel = True
            Else
                user.Sel = False

            End If



            If strSaveUpdate.ToLower = LCase("Edit") Then
                userMethods.Update(user, lblID.Text)
                MessageBox.Show("Record Update Successfully")
            Else
                userMethods.Save(user)
                MessageBox.Show("Record Insert Successfully")
            End If
            loadUser()
            ClearField()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        strSaveUpdate = "New"
        DisableControls(strSaveUpdate)
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        strSaveUpdate = "Edit"
        DisableControls(strSaveUpdate)
    End Sub

    Private Sub cmbUserType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUserType.SelectedIndexChanged
        If cmbUserType.Text.ToLower = LCase("Admin") Then
            chkInsert.Checked = True
            chkUpdate.Checked = True
            chkDelete.Checked = True
            chkSelect.Checked = True
        ElseIf cmbUserType.Text.ToLower = LCase("User") Then
            chkInsert.Checked = True
            chkUpdate.Checked = False
            chkDelete.Checked = False
            chkSelect.Checked = True

        End If
    End Sub

    Private Sub frmCreateUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            chkInsert.Enabled = False
            chkUpdate.Enabled = False
            chkDelete.Enabled = False
            chkSelect.Enabled = False


            CenterForm(Me)
            loadUser()
            DisableControls("")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub




    Private Sub DisableControls(ByVal FormStatus As String)


        If FormStatus = "" Then


            txtUserName.Enabled = False
            txtOldPassword.Enabled = False
            txtNewPassword.Enabled = False
            chkInsert.Enabled = False
            chkUpdate.Enabled = False
            chkDelete.Enabled = False
            chkSelect.Enabled = False
            btnSave.Enabled = False

            btnCreate.Enabled = True
            btnEdit.Enabled = True
        ElseIf FormStatus.ToLower = LCase("New") Then
            txtUserName.Enabled = True
            txtOldPassword.Enabled = False
            txtNewPassword.Enabled = True
            chkInsert.Enabled = True
            chkUpdate.Enabled = True
            chkDelete.Enabled = True
            chkSelect.Enabled = True
            btnEdit.Enabled = False

        ElseIf FormStatus.ToLower = LCase("Edit") Then
            txtUserName.Enabled = True
            txtOldPassword.Enabled = True
            txtNewPassword.Enabled = True
            chkInsert.Enabled = True
            chkUpdate.Enabled = True
            chkDelete.Enabled = True
            chkSelect.Enabled = True
            btnCreate.Enabled = False

        End If


        If FormStatus.ToLower = LCase("New") Or FormStatus.ToLower = LCase("Edit") Then
            btnSave.Enabled = True
            btnExit.Enabled = True
        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        strSaveUpdate = "New"
        DisableControls("")
        ClearField()
    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Me.Close()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub



    Private Sub loadUser()

        Try

            Dim usermethods As clsUserInfoMethods = New clsUserInfoMethods
            Dim Security As clsSecurity = New clsSecurity
            lstUser.Items.Clear()
            Dim ListUser As List(Of clsUserInfo) = usermethods.GetUsers.ToList
            Dim strPrivilege As String = String.Empty
            If ListUser.Count > 0 Then

                Dim lstViewItem As ListViewItem = New ListViewItem
                For Each tempUser As clsUserInfo In ListUser

                    strPrivilege = ""
                    lstViewItem = lstUser.Items.Add(lstUser.Items.Count + 1)
                    lstViewItem.Tag = tempUser.UserID.ToString
                    lstViewItem.SubItems.Add(tempUser.UserName.ToString)
                    lstViewItem.SubItems.Add(Security.Decrypt(tempUser.Password.ToString))
                    lstViewItem.SubItems.Add(tempUser.UserType.ToString)

                    If tempUser.Ins = True Then
                        strPrivilege = "Insert, "
                    End If


                    If tempUser.Upd = True Then
                        strPrivilege += "Update, "
                    End If


                    If tempUser.Sel = True Then
                        strPrivilege += "Select, "
                    End If

                    If tempUser.Del = True Then
                        strPrivilege += "Delete, "
                    End If

                    If strPrivilege.Length > 0 Then

                        If strPrivilege.Substring(strPrivilege.Length - 2, 2) = ", " Then
                            strPrivilege = strPrivilege.Substring(0, strPrivilege.Length - 2)
                        End If
                        lstViewItem.SubItems.Add(strPrivilege)
                    Else
                        lstViewItem.SubItems.Add("")
                    End If





                Next

            End If

        Catch ex As Exception
            MessageBox.Show(ex.StackTrace, ex.Message)
        End Try



    End Sub

    Private Sub lstUser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstUser.SelectedIndexChanged
        If strSaveUpdate.ToLower = LCase("new") Or String.IsNullOrEmpty(strSaveUpdate) Then
            Exit Sub
        End If



        Dim lstItem As ListViewItem = New ListViewItem


        lstItem = lstUser.FocusedItem


        txtUserName.Text = lstItem.SubItems(1).Text
        cmbUserType.Text = lstItem.SubItems(3).Text
        lblID.Text = lstItem.Tag.ToString



    End Sub


    Private Sub ClearField()

        txtUserName.Text = String.Empty
        txtOldPassword.Text = String.Empty
        txtNewPassword.Text = String.Empty
        cmbUserType.Text = String.Empty
        chkInsert.Checked = False
        chkUpdate.Checked = False
        chkDelete.Checked = False
        chkSelect.Checked = False


    End Sub



    Private Function checkUserCrediantial() As Boolean
        Dim userMethods As clsUserInfoMethods = New clsUserInfoMethods

        Return userMethods.UserCreadiantial(txtUserName.Text, txtOldPassword.Text)
    End Function

    Private Sub cmbUserType_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbUserType.KeyPress
        e.Handled = True
    End Sub

    Private Sub lblHeader_Click(sender As Object, e As EventArgs) Handles lblHeader.Click

    End Sub

    Private Sub lblHeader_MouseDown(sender As Object, e As MouseEventArgs) Handles lblHeader.MouseDown
        ReleaseCapture()
        SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles GroupBox1.MouseDown
        ReleaseCapture()
        SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
    End Sub

    Private Sub frmCreateUser_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        ReleaseCapture()
        SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuDelete.Click

        Dim UserMethods As clsUserInfoMethods = New clsUserInfoMethods

        If Not lstItem Is Nothing Then

            UserMethods.Delete(lstItem.Tag)
            MessageBox.Show("Delete User Successfully " & vbTab & " Deleted User: " & lstItem.SubItems(1).Text, "Delete")
            lstItem = Nothing
            loadUser()
            cntxDelete.Visible = False
            mnuDelete.Visible = False


        End If



    End Sub

    Private Sub lstUser_MouseDown(sender As Object, e As MouseEventArgs) Handles lstUser.MouseDown

        lstItem = Nothing
        If e.Button = System.Windows.Forms.MouseButtons.Right Then

            lstItem = lstUser.HitTest(e.Location).Item

            If Not lstItem Is Nothing Then
                cntxDelete.Visible = True
                mnuDelete.Visible = True

            Else
                cntxDelete.Visible = False
                mnuDelete.Visible = False
            End If
        End If
    End Sub

End Class