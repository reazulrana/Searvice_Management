Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Configuration




Public Class clsPersonalMethods



    Public Function LoadTechnician(Optional tempTechcode As String = "") As IEnumerable(Of clsPersonal)

        Dim strCode As String
        Dim techlist As List(Of clsPersonal) = New List(Of clsPersonal)

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString


        Using con As OleDbConnection = New OleDbConnection(cs)


            Dim dcLoadTechnician As OleDbCommand = New OleDbCommand()

            If String.IsNullOrEmpty(tempTechcode) Then

                dcLoadTechnician.CommandText = "qryGet_All_Personal"
                dcLoadTechnician.CommandType = CommandType.StoredProcedure
                dcLoadTechnician.Connection = con

            Else
                dcLoadTechnician.CommandText = "qryGet_Persoanl_byEmpCode"
                dcLoadTechnician.CommandType = CommandType.StoredProcedure
                dcLoadTechnician.Parameters.Add("paramEmpCode", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tempTechcode), DBNull.Value, tempTechcode)
                dcLoadTechnician.Connection = con

            End If

            con.Open()


            Dim drLoadTechnician As OleDbDataReader = dcLoadTechnician.ExecuteReader
            Try

                While drLoadTechnician.Read
                Dim tmpPersonal As clsPersonal = New clsPersonal


                With tmpPersonal

                    If Not String.IsNullOrEmpty(drLoadTechnician("EmpID").ToString) Then
                        .EmpID = Convert.ToInt32(drLoadTechnician("EmpID").ToString)
                    Else
                        .EmpID = 0
                    End If

                    .EmpCode = drLoadTechnician("EmpCode").ToString
                    strCode = drLoadTechnician("EmpCode").ToString
                    .UserName = drLoadTechnician("UserName").ToString
                    .EmpName = drLoadTechnician("EmpName").ToString
                    .Passward = drLoadTechnician("Passward").ToString
                    .FathersName = drLoadTechnician("FathersName").ToString
                    .Sex = drLoadTechnician("Sex").ToString
                    If Not String.IsNullOrEmpty(drLoadTechnician("DateOfBirth").ToString) Then
                        .DateOfBirth = Convert.ToDateTime(drLoadTechnician("DateOfBirth").ToString)

                    End If


                    If Not String.IsNullOrEmpty(drLoadTechnician("DateOfJoin").ToString) Then
                        .DateOfJoin = drLoadTechnician("DateOfJoin").ToString
                    End If

                    .Department = drLoadTechnician("Department").ToString
                    .Designation = drLoadTechnician("Designation").ToString
                    .EduQua = drLoadTechnician("EduQua").ToString
                    .MaritalStatus = drLoadTechnician("MaritalStatus").ToString
                    .PreAdd = drLoadTechnician("PreAdd").ToString
                    .PrePO = drLoadTechnician("PrePO").ToString
                    .PreDist = drLoadTechnician("PreDist").ToString
                    .PrePhone = drLoadTechnician("PrePhone").ToString
                    .PerAdd = drLoadTechnician("PerAdd").ToString
                    .PerPO = drLoadTechnician("PerPO").ToString
                    .PerDist = drLoadTechnician("PerDist").ToString
                    .PerPhone = drLoadTechnician("PerPhone").ToString
                    If Not String.IsNullOrEmpty(drLoadTechnician("Amount").ToString) Then
                        .Amount = Convert.ToDecimal(drLoadTechnician("Amount").ToString)
                    Else
                        .Amount = 0
                    End If

                    .Payscale = drLoadTechnician("Payscale").ToString
                    .JobType = drLoadTechnician("JobType").ToString




                End With

                techlist.Add(tmpPersonal)

            End While

            Catch ex As Exception
                MessageBox.Show(strCode)
            End Try


        End Using

        Return techlist


    End Function




    Public Function IsExist(Optional tempTechcode As String = "") As Boolean



        Dim blnFlag As Boolean = False

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Try


            Using con As OleDbConnection = New OleDbConnection(cs)


                Dim dcLoadTechnician As OleDbCommand = New OleDbCommand()


                dcLoadTechnician.CommandText = "Select * from Personal where Personal.EmpCode=@EmpCode"
                dcLoadTechnician.CommandType = CommandType.Text
                dcLoadTechnician.Connection = con
                dcLoadTechnician.Parameters.Add("@EmpCode", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tempTechcode), DBNull.Value, tempTechcode)


                con.Open()


                Dim drLoadTechnician As OleDbDataReader = dcLoadTechnician.ExecuteReader

                If drLoadTechnician.HasRows = True Then
                    blnFlag = True

                End If

            End Using
        Catch ex As Exception
            blnFlag = False

        End Try
        Return blnFlag


    End Function





    Public Sub NewEmployee(ByVal PersonalInfo As clsPersonal)


        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString


        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcNewTechnician As OleDbCommand = New OleDbCommand("qryInsertPersonal", con)
            dcNewTechnician.CommandType = CommandType.StoredProcedure

            dcNewTechnician.Parameters.Add("paramEmpcode", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(PersonalInfo.EmpCode), DBNull.Value, PersonalInfo.EmpCode)
            dcNewTechnician.Parameters.Add("paramEmpName", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(PersonalInfo.EmpName), DBNull.Value, PersonalInfo.EmpName)
            dcNewTechnician.Parameters.Add("paramFatherName", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(PersonalInfo.FathersName), DBNull.Value, PersonalInfo.FathersName)
            dcNewTechnician.Parameters.Add("paramSex", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(PersonalInfo.Sex), DBNull.Value, PersonalInfo.Sex)
            dcNewTechnician.Parameters.Add("paramDateofBirth", OleDbType.Date, 255).Value = IIf(String.IsNullOrEmpty(PersonalInfo.DateOfBirth), DBNull.Value, PersonalInfo.DateOfBirth)
            dcNewTechnician.Parameters.Add("paramDateOfJoin", OleDbType.Date, 255).Value = IIf(String.IsNullOrEmpty(PersonalInfo.DateOfJoin), DBNull.Value, PersonalInfo.DateOfJoin)
            dcNewTechnician.Parameters.Add("paramDepartment", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(PersonalInfo.Department), DBNull.Value, PersonalInfo.Department)
            dcNewTechnician.Parameters.Add("paramDesignation", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(PersonalInfo.Designation), DBNull.Value, PersonalInfo.Designation)
            dcNewTechnician.Parameters.Add("paramEduQua", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(PersonalInfo.EduQua), DBNull.Value, PersonalInfo.EduQua)
            dcNewTechnician.Parameters.Add("paramMaritalStatus", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(PersonalInfo.MaritalStatus), DBNull.Value, PersonalInfo.MaritalStatus)
            dcNewTechnician.Parameters.Add("paramPreAdd", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(PersonalInfo.PreAdd), DBNull.Value, PersonalInfo.PreAdd)
            dcNewTechnician.Parameters.Add("paramPrePO", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(PersonalInfo.PrePO), DBNull.Value, PersonalInfo.PrePO)
            dcNewTechnician.Parameters.Add("paramPreDist", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(PersonalInfo.PreDist), DBNull.Value, PersonalInfo.PreDist)
            dcNewTechnician.Parameters.Add("paramPrePhone", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(PersonalInfo.PrePhone), DBNull.Value, PersonalInfo.PrePhone)
            dcNewTechnician.Parameters.Add("paramPerAdd", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(PersonalInfo.PerAdd), DBNull.Value, PersonalInfo.PerAdd)
            dcNewTechnician.Parameters.Add("paramPerPO", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(PersonalInfo.PerPO), DBNull.Value, PersonalInfo.PerPO)
            dcNewTechnician.Parameters.Add("paramPerDist", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(PersonalInfo.PerDist), DBNull.Value, PersonalInfo.PerDist)
            dcNewTechnician.Parameters.Add("paramPerPhone", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(PersonalInfo.PerPhone), DBNull.Value, PersonalInfo.PerPhone)
            dcNewTechnician.Parameters.Add("paramJobType", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(PersonalInfo.JobType), DBNull.Value, PersonalInfo.JobType)









            con.Open()

            dcNewTechnician.ExecuteNonQuery()


        End Using







    End Sub




    Public Sub Update(ByVal PersonalInfo As clsPersonal, ByVal UpdateCriteria As String)


        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString


        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcUpdateTechnician As OleDbCommand = New OleDbCommand("qryUpdatePersonal", con)
            dcUpdateTechnician.CommandType = CommandType.StoredProcedure

            dcUpdateTechnician.Parameters.Add("paramEmpcode", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(PersonalInfo.EmpCode), DBNull.Value, PersonalInfo.EmpCode)
            dcUpdateTechnician.Parameters.Add("paramEmpName", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(PersonalInfo.EmpName), DBNull.Value, PersonalInfo.EmpName)
            dcUpdateTechnician.Parameters.Add("paramFatherName", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(PersonalInfo.FathersName), DBNull.Value, PersonalInfo.FathersName)
            dcUpdateTechnician.Parameters.Add("paramSex", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(PersonalInfo.Sex), DBNull.Value, PersonalInfo.Sex)
            dcUpdateTechnician.Parameters.Add("paramDateofBirth", OleDbType.Date, 255).Value = IIf(String.IsNullOrEmpty(PersonalInfo.DateOfBirth), DBNull.Value, PersonalInfo.DateOfBirth)
            dcUpdateTechnician.Parameters.Add("paramDateOfJoin", OleDbType.Date, 255).Value = IIf(String.IsNullOrEmpty(PersonalInfo.DateOfJoin), DBNull.Value, PersonalInfo.DateOfJoin)
            dcUpdateTechnician.Parameters.Add("paramDepartment", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(PersonalInfo.Department), DBNull.Value, PersonalInfo.Department)
            dcUpdateTechnician.Parameters.Add("paramDesignation", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(PersonalInfo.Designation), DBNull.Value, PersonalInfo.Designation)
            dcUpdateTechnician.Parameters.Add("paramEduQua", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(PersonalInfo.EduQua), DBNull.Value, PersonalInfo.EduQua)
            dcUpdateTechnician.Parameters.Add("paramMaritalStatus", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(PersonalInfo.MaritalStatus), DBNull.Value, PersonalInfo.MaritalStatus)
            dcUpdateTechnician.Parameters.Add("paramPreAdd", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(PersonalInfo.PreAdd), DBNull.Value, PersonalInfo.PreAdd)
            dcUpdateTechnician.Parameters.Add("paramPrePO", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(PersonalInfo.PrePO), DBNull.Value, PersonalInfo.PrePO)
            dcUpdateTechnician.Parameters.Add("paramPreDist", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(PersonalInfo.PreDist), DBNull.Value, PersonalInfo.PreDist)
            dcUpdateTechnician.Parameters.Add("paramPrePhone", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(PersonalInfo.PrePhone), DBNull.Value, PersonalInfo.PrePhone)
            dcUpdateTechnician.Parameters.Add("paramPerAdd", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(PersonalInfo.PerAdd), DBNull.Value, PersonalInfo.PerAdd)
            dcUpdateTechnician.Parameters.Add("paramPerPO", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(PersonalInfo.PerPO), DBNull.Value, PersonalInfo.PerPO)
            dcUpdateTechnician.Parameters.Add("paramPerDist", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(PersonalInfo.PerDist), DBNull.Value, PersonalInfo.PerDist)
            dcUpdateTechnician.Parameters.Add("paramPerPhone", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(PersonalInfo.PerPhone), DBNull.Value, PersonalInfo.PerPhone)
            dcUpdateTechnician.Parameters.Add("paramJobType", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(PersonalInfo.JobType), DBNull.Value, PersonalInfo.JobType)
            dcUpdateTechnician.Parameters.Add("paramJobCode2", OleDbType.Char, 255).Value = UpdateCriteria

            con.Open()

            dcUpdateTechnician.ExecuteNonQuery()


        End Using
    End Sub








    Public Sub Delete(ByVal DeleteEmployeeCode As String)


        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString


        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcDeleteTechnician As OleDbCommand = New OleDbCommand("qryDeletePersonal", con)
            dcDeleteTechnician.CommandType = CommandType.StoredProcedure


            dcDeleteTechnician.Parameters.Add("paramJobCode", OleDbType.Char, 255).Value = DeleteEmployeeCode

            con.Open()

            dcDeleteTechnician.ExecuteNonQuery()


        End Using
    End Sub


End Class
