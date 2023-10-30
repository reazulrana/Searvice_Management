Imports System.Runtime.InteropServices




Public Class frmPersonalInformation






    Dim strPreviousEmpCode As String = String.Empty
    Private Sub frmPersonalInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try


            CenterForm(Me)
            LoadTechnicianinfo()
            If lstEmployeInformation.Items.Count > 0 Then
                If lstEmployeInformation.Items.Count <= 9 Then
                    txtEmpCode.Text = "0" & Convert.ToInt32(lstEmployeInformation.Items(lstEmployeInformation.Items.Count - 1).SubItems(2).Text) + 1
                Else
                    txtEmpCode.Text = Convert.ToInt32(lstEmployeInformation.Items(lstEmployeInformation.Items.Count - 1).SubItems(2).Text) + 1
                End If
            Else

                txtEmpCode.Text = "01"
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, Err.Number.ToString)
            Me.Dispose()
        End Try
    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Me.Close()


    End Sub


    Private Sub LoadTechnicianinfo()

        Dim personalmethods As clsPersonalMethods = New clsPersonalMethods
        Dim Employees As List(Of clsPersonal) = personalmethods.LoadTechnician.ToList

        lstEmployeInformation.Items.Clear()

        If Employees.Count > 0 Then
            For Each employee As clsPersonal In Employees
                Dim lstEmpItem As ListViewItem = New ListViewItem


                lstEmpItem = lstEmployeInformation.Items.Add(employee.EmpID)
                lstEmpItem.SubItems.Add(lstEmployeInformation.Items.Count)
                lstEmpItem.SubItems.Add(employee.EmpCode.ToString)
                lstEmpItem.SubItems.Add(employee.EmpName.ToString)
                lstEmpItem.SubItems.Add(employee.Sex.ToString)
                lstEmpItem.SubItems.Add(employee.Department.ToString)
                lstEmpItem.SubItems.Add(employee.Designation.ToString)



            Next




        End If




    End Sub




    Private Sub GetPersonalInformation()

        If chkEdit.Checked = True Then


            If lstEmployeInformation.SelectedItems.Count > 0 Then

                Dim empmethods As clsPersonalMethods = New clsPersonalMethods
                Dim employees As List(Of clsPersonal) = empmethods.LoadTechnician(lstEmployeInformation.FocusedItem.SubItems(2).Text).ToList


                If employees.Count = 1 Then
                    For Each employee As clsPersonal In employees
                        txtEmpCode.Text = employee.EmpCode
                        strPreviousEmpCode = employee.EmpCode
                        txtEmpName.Text = employee.EmpName
                        txtFatherName.Text = employee.FathersName
                        cmbSex.Text = employee.Sex
                        cmbDepartment.Text = employee.Department
                        cmbDesignation.Text = employee.Designation
                        cmbQualification.Text = employee.EduQua
                        cmbMaritalStatus.Text = employee.MaritalStatus
                        cmbJobType.Text = employee.JobType
                        If Not String.IsNullOrEmpty(employee.DateOfBirth) Then
                            dtpDateofBirth.Value = Convert.ToDateTime(employee.DateOfBirth).ToShortDateString
                        Else
                            dtpDateofBirth.Value = Now.Date.ToShortDateString
                        End If
                        If Not String.IsNullOrEmpty(employee.DateOfJoin) Then
                            dtpDateofJoin.Value = Convert.ToDateTime(employee.DateOfJoin).ToShortDateString
                        Else
                            dtpDateofJoin.Value = Now.Date.ToShortDateString
                        End If

                        txtPreAdd.Text = employee.PreAdd
                        txtPrePo.Text = employee.PrePO
                        txtPreDist.Text = employee.PreDist
                        txtPrePhone.Text = employee.PrePhone

                        txtPerAdd.Text = employee.PerAdd
                        txtPerPO.Text = employee.PerPO
                        txtPerDist.Text = employee.PerDist
                        txtPerPhone.Text = employee.PerPhone



                    Next


                End If



            End If
        End If


    End Sub

    Private Sub chkEdit_CheckedChanged(sender As Object, e As EventArgs) Handles chkEdit.CheckedChanged

        Try

            If chkEdit.Checked = True Then

                GetPersonalInformation()
                btnSave.Text = "&Update"
            Else
                ClearField()
                btnSave.Text = "&Save"
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ClearField()
        txtEmpCode.Text = ""
        txtEmpName.Text = ""
        txtFatherName.Text = ""
        cmbSex.Text = ""
        cmbDepartment.Text = ""
        cmbDesignation.Text = ""
        cmbQualification.Text = ""
        cmbMaritalStatus.Text = ""
        cmbJobType.Text = ""

        dtpDateofBirth.Value = Now.Date.ToShortDateString


        dtpDateofBirth.Value = Now.Date.ToShortDateString


        txtPreAdd.Text = ""
        txtPrePo.Text = ""
        txtPreDist.Text = ""
        txtPrePhone.Text = ""

        txtPerAdd.Text = ""
        txtPerPO.Text = ""
        txtPerDist.Text = ""
        txtPerPhone.Text = ""
    End Sub

    Private Sub lstEmployeInformation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstEmployeInformation.SelectedIndexChanged
        Try


            GetPersonalInformation()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ClearField()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If lstEmployeInformation.SelectedItems.Count > 0 Then

                If ActiveUser.UserType.ToLower = LCase("Admin") Or ActiveUser.Del = True Then
                    Dim delEmp As clsPersonalMethods = New clsPersonalMethods
                    delEmp.Delete(lstEmployeInformation.FocusedItem.SubItems(2).Text)

                    lblEmployeeStatus.Text = "Employee Information is delete Successfully 'Employee Code is=" + lstEmployeInformation.FocusedItem.SubItems(2).Text + "'"
                    LoadTechnicianinfo()
                Else
                    lblEmployeeStatus.ForeColor = Color.Yellow
                    lblEmployeeStatus.Text = "User do not have delete permission"
                End If


            End If
        Catch ex As Exception
            lblEmployeeStatus.Text = ex.Message
            lblEmployeeStatus.ForeColor = Color.White
        End Try

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub frmPersonalInformation_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        lblEmployeeStatus.Top = Me.Height - lblEmployeeStatus.Height
        btnSave.Left = lstEmployeInformation.Left
        btnSave.Width = lstEmployeInformation.Width / 4
        btnDelete.Left = btnSave.Width + btnSave.Left
        btnDelete.Width = btnSave.Width
        btnReset.Left = btnDelete.Left + btnDelete.Width
        btnReset.Width = btnDelete.Width
        btnClose.Left = btnReset.Left + btnReset.Width
        btnClose.Width = btnReset.Width
        btnSave.Top = lblEmployeeStatus.Top - btnSave.Height + 1
        btnDelete.Top = btnSave.Top
        btnReset.Top = btnDelete.Top
        btnClose.Top = btnReset.Top
        chkEdit.Top = btnSave.Top - chkEdit.Height + 1
        chkEdit.Left = lstEmployeInformation.Left



    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If chkEdit.Checked = False Then
            InsertNewRecord()
        Else
            UpdateRecord()

        End If
    End Sub


    Private Sub InsertNewRecord()
        Dim EmpMethods As clsPersonalMethods = New clsPersonalMethods

        Dim NewEmployee As clsPersonal = New clsPersonal
        Try


            With NewEmployee


                If String.IsNullOrEmpty(Trim(txtEmpCode.Text)) Then

                    MessageBox.Show("Employee Code is Blank")
                    txtEmpCode.Select()
                Else
                    .EmpCode = Trim(txtEmpCode.Text)
                End If
                If String.IsNullOrEmpty(Trim(txtEmpName.Text)) Then
                    MessageBox.Show("Employee Name is Blank")
                    txtEmpName.Select()
                Else
                    .EmpName = Trim(txtEmpName.Text)
                End If

                .FathersName = "" & Trim(cmbDepartment.Text)
                .Sex = "" & Trim(cmbSex.Text)
                .Department = "" & Trim(cmbDepartment.Text)
                .Designation = "" & Trim(cmbDesignation.Text)
                .EduQua = "" & Trim(cmbQualification.Text)
                .MaritalStatus = "" & Trim(cmbMaritalStatus.Text)
                .JobType = "" & Trim(cmbJobType.Text)
                .DateOfBirth = "" & dtpDateofBirth.Value.ToShortDateString
                .DateOfJoin = "" & dtpDateofJoin.Value.ToShortDateString
                .PreAdd = "" & Trim(txtPreAdd.Text)
                .PrePO = "" & Trim(txtPrePo.Text)
                .PreDist = "" & Trim(txtPreDist.Text)
                .PrePhone = "" & Trim(txtPrePhone.Text)
                .PerAdd = "" & Trim(txtPerAdd.Text)
                .PerPO = "" & Trim(txtPerPO.Text)
                .PerDist = "" & Trim(txtPerDist.Text)
                .PerPhone = "" & Trim(txtPerPhone.Text)

            End With
            EmpMethods.NewEmployee(NewEmployee)
            MessageBox.Show("Record Saved Successfully")
            LoadTechnicianinfo()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub UpdateRecord()
        Dim EmpMethods As clsPersonalMethods = New clsPersonalMethods

        Dim NewEmployee As clsPersonal = New clsPersonal
        Try


            With NewEmployee


                If String.IsNullOrEmpty(Trim(txtEmpCode.Text)) Then

                    MessageBox.Show("Employee Code is Blank")
                    txtEmpCode.Select()
                Else
                    .EmpCode = Trim(txtEmpCode.Text)
                End If
                If String.IsNullOrEmpty(Trim(txtEmpName.Text)) Then
                    MessageBox.Show("Employee Name is Blank")
                    txtEmpName.Select()
                Else
                    .EmpName = Trim(txtEmpName.Text)
                End If

                .FathersName = "" & Trim(cmbDepartment.Text)
                .Sex = "" & Trim(cmbSex.Text)
                .Department = "" & Trim(cmbDepartment.Text)
                .Designation = "" & Trim(cmbDesignation.Text)
                .EduQua = "" & Trim(cmbQualification.Text)
                .MaritalStatus = "" & Trim(cmbMaritalStatus.Text)
                .JobType = "" & Trim(cmbJobType.Text)
                .DateOfBirth = "" & dtpDateofBirth.Value.ToShortDateString
                .DateOfJoin = "" & dtpDateofJoin.Value.ToShortDateString
                .PreAdd = "" & Trim(txtPreAdd.Text)
                .PrePO = "" & Trim(txtPrePo.Text)
                .PreDist = "" & Trim(txtPreDist.Text)
                .PrePhone = "" & Trim(txtPrePhone.Text)
                .PerAdd = "" & Trim(txtPerAdd.Text)
                .PerPO = "" & Trim(txtPerPO.Text)
                .PerDist = "" & Trim(txtPerDist.Text)
                .PerPhone = "" & Trim(txtPerPhone.Text)

            End With
            EmpMethods.Update(NewEmployee, strPreviousEmpCode)
            MessageBox.Show("Record Update Successfully")
            LoadTechnicianinfo()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click

    End Sub

    Private Sub Label22_MouseDown(sender As Object, e As MouseEventArgs) Handles Label22.MouseDown
        ReleaseCapture()
        SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
    End Sub

    Private Sub frmPersonalInformation_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        ReleaseCapture()
        SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
    End Sub

    Private Sub lstEmployeInformation_DoubleClick(sender As Object, e As EventArgs) Handles lstEmployeInformation.DoubleClick

    End Sub

    Private Sub lstEmployeInformation_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lstEmployeInformation.MouseDoubleClick


    End Sub
End Class