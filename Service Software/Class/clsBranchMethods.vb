Imports System.Data.OleDb
Imports System.Data
Imports System
Imports System.Configuration





Public Class clsBranchMethods


    Public ReadOnly Property GetBranches() As IEnumerable(Of clsBranch)
        Get
            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

            Dim ListofBranches As List(Of clsBranch) = New List(Of clsBranch)

            Using con As OleDbConnection = New OleDbConnection(cs)

                Dim dcGetBranchs As OleDbCommand = New OleDbCommand()

                dcGetBranchs.CommandText = "qryGet_All_Branch"
                dcGetBranchs.CommandType = CommandType.StoredProcedure
                dcGetBranchs.Connection = con



                con.Open()


                Dim drgetBranch As OleDbDataReader = dcGetBranchs.ExecuteReader


                While drgetBranch.Read





                    Dim clstempBranch As clsBranch = New clsBranch

                    clstempBranch.BrID = Convert.ToInt32(drgetBranch("BrID").ToString)
                    clstempBranch.Branch = drgetBranch("Branch").ToString
                    clstempBranch.phone = drgetBranch("phone").ToString
                    clstempBranch.Flag = Convert.ToBoolean(drgetBranch("Flag").ToString)
                    clstempBranch.OfficeTime = drgetBranch("OfficeTime").ToString
                    clstempBranch.Holiday = drgetBranch("Holiday").ToString
                    clstempBranch.Address = drgetBranch("Address").ToString


                    ListofBranches.Add(clstempBranch)


                End While


            End Using



            Return ListofBranches

        End Get
    End Property






    Public ReadOnly Property GetOpenBranches() As IEnumerable(Of clsBranch)
        Get
            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

            Dim ListofBranches As List(Of clsBranch) = New List(Of clsBranch)

            Using con As OleDbConnection = New OleDbConnection(cs)

                Dim dcGetBranchs As OleDbCommand = New OleDbCommand()

                dcGetBranchs.CommandText = "Select * from Branch where flag=true"
                dcGetBranchs.CommandType = CommandType.Text
                dcGetBranchs.Connection = con



                con.Open()


                Dim drgetBranch As OleDbDataReader = dcGetBranchs.ExecuteReader


                While drgetBranch.Read





                    Dim clstempBranch As clsBranch = New clsBranch

                    clstempBranch.BrID = Convert.ToInt32(drgetBranch("BrID").ToString)
                    clstempBranch.Branch = drgetBranch("Branch").ToString
                    clstempBranch.phone = drgetBranch("phone").ToString
                    clstempBranch.Flag = Convert.ToBoolean(drgetBranch("Flag").ToString)
                    clstempBranch.OfficeTime = drgetBranch("OfficeTime").ToString
                    clstempBranch.Holiday = drgetBranch("Holiday").ToString
                    clstempBranch.Address = drgetBranch("Address").ToString

                    ListofBranches.Add(clstempBranch)


                End While


            End Using



            Return ListofBranches

        End Get
    End Property



    Public Sub Save(ByVal Branch As clsBranch)

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString



        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcSaveBranch As OleDbCommand = New OleDbCommand("qryInsertBranch", con)
            dcSaveBranch.CommandType = CommandType.StoredProcedure

            dcSaveBranch.Parameters.Add("paramBranch", OleDbType.Char, 255).Value = Branch.Branch

            dcSaveBranch.Parameters.Add("paramPhone", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(Branch.phone), DBNull.Value, Branch.phone)

            dcSaveBranch.Parameters.Add("paramFlag", OleDbType.Boolean, 255).Value = IIf(String.IsNullOrEmpty(Branch.Flag), DBNull.Value, Branch.Flag)

            dcSaveBranch.Parameters.Add("paramOfficeTime", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(Branch.OfficeTime), DBNull.Value, Branch.OfficeTime)

            dcSaveBranch.Parameters.Add("paramHoliday", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(Branch.Holiday), DBNull.Value, Branch.Holiday)
            dcSaveBranch.Parameters.Add("paramAddress", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(Branch.Holiday), DBNull.Value, Branch.Address)
            con.Open()

            dcSaveBranch.ExecuteNonQuery()


        End Using




    End Sub
















    Public Sub Update(ByVal Branch As clsBranch, ByVal UpdateBranch As String)

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString



        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcUpdateBranch As OleDbCommand = New OleDbCommand("qryUpdateBranch", con)
            dcUpdateBranch.CommandType = CommandType.StoredProcedure

            dcUpdateBranch.Parameters.Add("paramBranch", OleDbType.Char, 255).Value = Branch.Branch

            dcUpdateBranch.Parameters.Add("paramPhone", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(Branch.phone), DBNull.Value, Branch.phone)

            dcUpdateBranch.Parameters.Add("paramFlag", OleDbType.Boolean, 255).Value = IIf(String.IsNullOrEmpty(Branch.Flag), DBNull.Value, Branch.Flag)

            dcUpdateBranch.Parameters.Add("paramOfficeTime", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(Branch.OfficeTime), DBNull.Value, Branch.OfficeTime)

            dcUpdateBranch.Parameters.Add("paramHoliday", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(Branch.Holiday), DBNull.Value, Branch.Holiday)
            dcUpdateBranch.Parameters.Add("paramAddress", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(Branch.Address), DBNull.Value, Branch.Address)
            dcUpdateBranch.Parameters.Add("paramBranch2", OleDbType.Char, 255).Value = UpdateBranch
            con.Open()

            dcUpdateBranch.ExecuteNonQuery()

        End Using




    End Sub





    Public Sub Delete(ByVal DeleteBranch As String)

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString



        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcUpdateBranch As OleDbCommand = New OleDbCommand("qryDeleteBranch", con)
            dcUpdateBranch.CommandType = CommandType.StoredProcedure

            dcUpdateBranch.Parameters.Add("paramBranch2", OleDbType.Char, 255).Value = DeleteBranch
            con.Open()

            dcUpdateBranch.ExecuteNonQuery()

        End Using




    End Sub





    Public ReadOnly Property VerifyBranch(ByVal BranchName) As clsBranch
        Get
            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString


            Dim clstempBranch As clsBranch = New clsBranch
            Using con As OleDbConnection = New OleDbConnection(cs)

                Dim dcGetBranchs As OleDbCommand = New OleDbCommand()

                dcGetBranchs.CommandText = "Select * from Branch where Branch=@Branch"
                dcGetBranchs.CommandType = CommandType.Text
                dcGetBranchs.Connection = con

                dcGetBranchs.Parameters.Add("@Branch", OleDbType.Char, 255).Value = BranchName


                con.Open()


                Dim drgetBranch As OleDbDataReader = dcGetBranchs.ExecuteReader


                While drgetBranch.Read







                    clstempBranch.BrID = Convert.ToInt32(drgetBranch("BrID").ToString)
                    clstempBranch.Branch = drgetBranch("Branch").ToString
                    clstempBranch.phone = drgetBranch("phone").ToString
                    clstempBranch.Flag = Convert.ToBoolean(drgetBranch("Flag").ToString)
                    clstempBranch.OfficeTime = drgetBranch("OfficeTime").ToString
                    clstempBranch.Holiday = drgetBranch("Holiday").ToString
                    clstempBranch.Address = drgetBranch("Address").ToString



                End While


            End Using



            Return clstempBranch

        End Get
    End Property


    Public ReadOnly Property Isexist(ByVal BranchName As String) As Boolean
        Get
            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
            Dim blnFlag As Boolean = False


            Dim clstempBranch As clsBranch = New clsBranch

            Try


                Using con As OleDbConnection = New OleDbConnection(cs)

                    Dim dcGetBranchs As OleDbCommand = New OleDbCommand()

                    dcGetBranchs.CommandText = "Select * from Branch where Branch=@Branch"
                    dcGetBranchs.CommandType = CommandType.Text
                    dcGetBranchs.Connection = con
                    dcGetBranchs.Parameters.Add("@Branch", OleDbType.Char, 255).Value = BranchName
                    con.Open()
                    Dim drgetBranch As OleDbDataReader = dcGetBranchs.ExecuteReader

                    If drgetBranch.HasRows = True Then
                        blnFlag = True

                    End If
                End Using
            Catch ex As Exception
                blnFlag = False

            End Try
            Return blnFlag

        End Get
    End Property

End Class
