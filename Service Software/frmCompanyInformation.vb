Imports System
Imports System.Data.OleDb


Public Class frmCompanyInformation
    Public strRecocdModeIdentity As String
    Dim strEditedCompanyName As String = String.Empty
    Dim strEditedDepartment As String = String.Empty




    Private Sub frmCompanyInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterForm(Me)
        If strRecocdModeIdentity = "New" Then
            Me.Text = "New Company"
        Else
            Me.Text = "Edit Company"
            cmdSave.Enabled = False
        End If
        ButtonEnableDisable(strRecocdModeIdentity)
        LoadComapnyList()
    End Sub

    Private Sub frmCompanyInformation_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        'cmdSave.Top = (grpCompanyDetails.Top + grpCompanyDetails.Height - cmdSave.Height) - 5
        'cmdSave.Left = grpCompanyDetails.Left + 5
        'cmdSave.Width = ((grpCompanyDetails.Width - (cmdSave.Left)) / 3) - 5

        'cmdClear.Top = cmdSave.Top
        'cmdClear.Left = cmdSave.Left + cmdSave.Width + 2.5
        'cmdClear.Width = cmdSave.Width

        'cmdClose.Top = cmdClear.Top
        'cmdClose.Left = cmdClear.Left + cmdClear.Width + 2.5
        'cmdClose.Width = cmdSave.Width



    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If String.IsNullOrEmpty(txtCompanyName.Text) Or String.IsNullOrEmpty(txtDepartment.Text) Then
            MsgBox("You must Fill At least 'Company Name & Department Field'")
            Exit Sub
        End If



        Try
            Dim lstCompanyInformation As ListViewItem = Nothing

            If strRecocdModeIdentity = "New" Then


                InsertNewRecord(strProvider, "CompanyInformation", "CompanyName,OwnerName,Address,ContactNo,Department,TotalStaff", "'" & txtCompanyName.Text & "','" & txtOwnerName.Text & "','" & txtAddress.Text & "','" & txtContactNo.Text & "','" & txtDepartment.Text & "'," & Convert.ToInt16(txtTotalEmployee.Text))
                MsgBox("Record Insert Successfully")


            Else
                UpdateRecords("CompanyName,OwnerName,Address,ContactNo,Department,TotalStaff", "'" & txtCompanyName.Text & "','" & txtOwnerName.Text & "','" & txtAddress.Text & "','" & txtContactNo.Text & "','" & txtDepartment.Text & "'," & Convert.ToInt16(txtTotalEmployee.Text), "CompanyInformation", "CompanyInformation.CompanyName='" & strEditedCompanyName.ToString & "' and CompanyInformation.Department='" & strEditedDepartment.ToString & "'")
                MsgBox("Record Insert Successfully")


            End If
            LoadComapnyList()

            'lstCompanyInformation = lstCompanylist.Items.Add(lstCompanylist.Items.Count)
            'lstCompanyInformation.SubItems.Add("" & txtCompanyName.Text)
            'lstCompanyInformation.SubItems.Add("" & txtOwnerName.Text)
            'lstCompanyInformation.SubItems.Add("" & txtAddress.Text)
            'lstCompanyInformation.SubItems.Add("" & txtContactNo.Text)
            'lstCompanyInformation.SubItems.Add("" & txtDepartment.Text)
            'lstCompanyInformation.SubItems.Add(txtTotalEmployee.Text)
            ClearField()



        Catch exInsertError As Exception
            MsgBox(exInsertError.Message)

        End Try






    End Sub


    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub ClearField()

        txtCompanyName.Text = String.Empty
        txtOwnerName.Text = String.Empty
        txtAddress.Text = String.Empty
        txtContactNo.Text = String.Empty
        txtDepartment.Text = String.Empty
        txtTotalEmployee.Text = "0"

        If UCase(strRecocdModeIdentity) = UCase("Edit") Then
            strEditedCompanyName = String.Empty
            strEditedDepartment = String.Empty
            cmdSave.Enabled = False
        End If

    End Sub




    Private Sub ButtonEnableDisable(ByVal strRecordMode As String)


        If strRecordMode = "New" Then
            cmdDelete.Enabled = False
            cmdSave.Text = "&Save"
        Else
            cmdDelete.Enabled = True
            cmdSave.Text = "&Update"
        End If

    End Sub

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        ClearField()

    End Sub

    Private Sub lstCompanylist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCompanylist.SelectedIndexChanged
        strEditedCompanyName = String.Empty
        strEditedDepartment = String.Empty
        If strRecocdModeIdentity = "Edit" Then
            If lstCompanylist.FocusedItem.Selected = True Then
                cmdSave.Enabled = True


                txtCompanyName.Text = lstCompanylist.FocusedItem.SubItems(1).Text
                txtOwnerName.Text = lstCompanylist.FocusedItem.SubItems(2).Text
                txtAddress.Text = lstCompanylist.FocusedItem.SubItems(3).Text
                txtContactNo.Text = lstCompanylist.FocusedItem.SubItems(4).Text
                txtDepartment.Text = lstCompanylist.FocusedItem.SubItems(5).Text
                txtTotalEmployee.Text = lstCompanylist.FocusedItem.SubItems(6).Text
                strEditedCompanyName = lstCompanylist.FocusedItem.SubItems(1).Text
                strEditedDepartment = lstCompanylist.FocusedItem.SubItems(5).Text
            Else
                cmdSave.Enabled = False

            End If
        End If
    End Sub



    Private Sub LoadComapnyList()
        Dim ConCompanyList As New OleDbConnection(strProvider)

        Dim drCompanylist As OleDbDataReader = Nothing

        Dim lstTempLoadList As ListViewItem = Nothing


        LoadAllInformation(ConCompanyList, drCompanylist, strProvider, "CompanyInformation", "CompanyName,OwnerName,Address,ContactNo,Department,TotalStaff", "''")

        lstCompanylist.Items.Clear()

        Try


            If drCompanylist.HasRows = True Then
                While drCompanylist.Read
                    lstTempLoadList = lstCompanylist.Items.Add(lstCompanylist.Items.Count + 1)
                    lstTempLoadList.SubItems.Add(drCompanylist("CompanyName").ToString)
                    lstTempLoadList.SubItems.Add(drCompanylist("OwnerName").ToString)
                    lstTempLoadList.SubItems.Add(drCompanylist("Address").ToString)
                    lstTempLoadList.SubItems.Add(drCompanylist("ContactNo").ToString)
                    lstTempLoadList.SubItems.Add(drCompanylist("Department").ToString)
                    lstTempLoadList.SubItems.Add(drCompanylist("TotalStaff").ToString)


                End While
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try




    End Sub

    Private Sub grpCompanyDetails_Enter(sender As Object, e As EventArgs) Handles grpCompanyDetails.Enter

    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        Try

            DeleteRecord("CompanyInformation", "CompanyInformation.CompanyName='" & strEditedCompanyName & "' and CompanyInformation.Department='" & strEditedDepartment & "'", "ON")

            MessageBox.Show("Record Delete Succssfully" & vbCrLf & "Company : '" & strEditedCompanyName.ToString & "'" & vbCrLf & "Department='" & strEditedDepartment.ToString & "'")

        Catch exDeleteCompany As Exception
            MessageBox.Show(exDeleteCompany.Message)


        End Try
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Dispose()

    End Sub

    Private Sub frmCompanyInformation_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        strRecocdModeIdentity = String.Empty
        strEditedCompanyName = String.Empty
        strEditedDepartment = String.Empty
    End Sub
End Class
