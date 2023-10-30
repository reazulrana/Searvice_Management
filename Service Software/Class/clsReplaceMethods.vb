Imports System.Configuration
Imports System.Data
Imports System.Data.OleDb



Public Class clsReplaceMethods
    Public Sub Save(ByVal ReplaceClass As clsReplace)


        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString


        Dim strQuery As String = "Insert into Replace(JobCode,Brand,Model,ESN,ESNb,SLNo,Other,RDate,ReplaceBy) values(@JobCode,@Brand,@Model,@ESN,@ESNb,@SLNo,@Other,@RDate,@ReplaceBy)"
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcProductList As OleDbCommand = New OleDbCommand(strQuery, con)

            dcProductList.CommandType = CommandType.Text

            dcProductList.Parameters.Add("@JobCode", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(ReplaceClass.JobCode), DBNull.Value, ReplaceClass.JobCode)
            dcProductList.Parameters.Add("@Brand", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(ReplaceClass.Brand), DBNull.Value, ReplaceClass.Brand)
            dcProductList.Parameters.Add("@Model", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(ReplaceClass.Model), DBNull.Value, ReplaceClass.Model)
            dcProductList.Parameters.Add("@ESN", OleDbType.Integer).Value = If(String.IsNullOrEmpty(ReplaceClass.ESN), DBNull.Value, ReplaceClass.ESN)
            dcProductList.Parameters.Add("@ESNb", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(ReplaceClass.ESNb), DBNull.Value, ReplaceClass.ESNb)
            dcProductList.Parameters.Add("@SLNo", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(ReplaceClass.SLNo), DBNull.Value, ReplaceClass.SLNo)
            dcProductList.Parameters.Add("@Other", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(ReplaceClass.Other), DBNull.Value, ReplaceClass.Other)
            dcProductList.Parameters.Add("@RDate", OleDbType.Date).Value = If(String.IsNullOrEmpty(ReplaceClass.RDate), DBNull.Value, ReplaceClass.RDate)
            dcProductList.Parameters.Add("@ReplaceBy", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(ReplaceClass.ReplaceBy), DBNull.Value, ReplaceClass.ReplaceBy)

            con.Open()

            dcProductList.ExecuteNonQuery()


        End Using


    End Sub


    Public Sub Update(ByVal ReplaceClass As clsReplace, ByVal UpdateID As String)


        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString


        Dim strQuery As String = "Update Replace Set JobCode=@JobCode,Brand=@Brand,Model=@Model,ESN=@ESN,ESNb=@ESNb,SLNo=@SLNo,Other=@Other,RDate=@RDate,ReplaceBy=@ReplaceBy where Set JobCode=@JobCode1 "
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcProductList As OleDbCommand = New OleDbCommand(strQuery, con)

            dcProductList.CommandType = CommandType.StoredProcedure

            dcProductList.Parameters.Add("@JobCode", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(ReplaceClass.JobCode), DBNull.Value, ReplaceClass.JobCode)
            dcProductList.Parameters.Add("@Brand", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(ReplaceClass.Brand), DBNull.Value, ReplaceClass.Brand)
            dcProductList.Parameters.Add("@Model", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(ReplaceClass.Model), DBNull.Value, ReplaceClass.Model)
            dcProductList.Parameters.Add("@ESN", OleDbType.Integer).Value = If(String.IsNullOrEmpty(ReplaceClass.ESN), DBNull.Value, ReplaceClass.ESN)
            dcProductList.Parameters.Add("@ESNb", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(ReplaceClass.ESNb), DBNull.Value, ReplaceClass.ESNb)
            dcProductList.Parameters.Add("@SLNo", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(ReplaceClass.SLNo), DBNull.Value, ReplaceClass.SLNo)
            dcProductList.Parameters.Add("@Other", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(ReplaceClass.Other), DBNull.Value, ReplaceClass.Other)
            dcProductList.Parameters.Add("@RDate", OleDbType.Date).Value = If(String.IsNullOrEmpty(ReplaceClass.RDate), DBNull.Value, ReplaceClass.RDate)
            dcProductList.Parameters.Add("@ReplaceBy", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(ReplaceClass.ReplaceBy), DBNull.Value, ReplaceClass.ReplaceBy)
            dcProductList.Parameters.Add("@JobCode1", OleDbType.Char, 255).Value = UpdateID

            con.Open()

            dcProductList.ExecuteNonQuery()


        End Using


    End Sub


    Public ReadOnly Property GetAllReplace() As IEnumerable(Of clsReplace)
        Get
            Dim ListReplace As List(Of clsReplace) = New List(Of clsReplace)
            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
            Dim strQuery As String = "Select * from Replace"
            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dcProductList As OleDbCommand = New OleDbCommand(strQuery, con)

                con.Open()

                Dim drReplace As OleDbDataReader = dcProductList.ExecuteReader

                If drReplace.HasRows = True Then
                    While drReplace.Read
                        Dim replace As clsReplace = New clsReplace
                        If Not String.IsNullOrEmpty(drReplace("ClaimID").ToString) Then
                            replace.ClaimID = Convert.ToInt32(drReplace("ClaimID").ToString)
                        End If
                        replace.Brand = drReplace("Brand").ToString
                        replace.Model = drReplace("Model").ToString
                        replace.ESN = drReplace("ESN").ToString
                        replace.ESNb = drReplace("ESNb").ToString
                        replace.SLNo = drReplace("SLNo").ToString
                        replace.Other = drReplace("Other").ToString
                        If Not String.IsNullOrEmpty(drReplace("RDate").ToString) Then
                            replace.RDate = Convert.ToDateTime(drReplace("RDate").ToString)
                        End If

                        replace.ReplaceBy = drReplace("ReplaceBy").ToString
                        ListReplace.Add(replace)
                    End While
                End If
            End Using
            Return ListReplace
        End Get
    End Property



    Public ReadOnly Property GetSingleReplace(ByVal SearchID As String) As clsReplace
        Get
            Dim replace As clsReplace = New clsReplace
            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
            Dim strQuery As String = "Select * from Replace where Replace.JobCode=@JobCode"
            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dcProductList As OleDbCommand = New OleDbCommand(strQuery, con)

                dcProductList.Parameters.Add("@JobCode", OleDbType.Char, 255).Value = SearchID


                con.Open()

                Dim drReplace As OleDbDataReader = dcProductList.ExecuteReader

                If drReplace.HasRows = True Then
                    While drReplace.Read

                        If Not String.IsNullOrEmpty(drReplace("ClaimID").ToString) Then
                            replace.ClaimID = Convert.ToInt32(drReplace("ClaimID").ToString)
                        End If
                        replace.Brand = drReplace("Brand").ToString
                        replace.Model = drReplace("Model").ToString
                        replace.ESN = drReplace("ESN").ToString
                        replace.ESNb = drReplace("ESNb").ToString
                        replace.SLNo = drReplace("SLNo").ToString
                        replace.Other = drReplace("Other").ToString
                        If Not String.IsNullOrEmpty(drReplace("RDate").ToString) Then
                            replace.RDate = Convert.ToDateTime(drReplace("RDate").ToString)
                        End If

                        replace.ReplaceBy = drReplace("ReplaceBy").ToString

                    End While
                End If
            End Using
            Return replace
        End Get
    End Property




    Public ReadOnly Property Isexist(ByVal SearchID As String) As Boolean
        Get
            Dim blnFlag As Boolean = False

            Try

                Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
            Dim strQuery As String = "Select * from Replace where Replace.JobCode=@JobCode"
                Using con As OleDbConnection = New OleDbConnection(cs)
                    Dim dcProductList As OleDbCommand = New OleDbCommand(strQuery, con)

                    dcProductList.Parameters.Add("@JobCode", OleDbType.Char, 255).Value = SearchID


                    con.Open()

                    Dim drReplace As OleDbDataReader = dcProductList.ExecuteReader

                    If drReplace.HasRows = True Then
                        blnFlag = True
                    End If


                End Using


            Catch ex As Exception
                blnFlag = False

            End Try

            Return blnFlag
        End Get
    End Property



    Public Sub Delete(ByVal SearchID As String)



        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim strQuery As String = "Delete * from Replace where Replace.JobCode=@JobCode"
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcReplace As OleDbCommand = New OleDbCommand(strQuery, con)

            dcReplace.Parameters.Add("@JobCode", OleDbType.Char, 255).Value = SearchID


            con.Open()

            dcReplace.ExecuteNonQuery()
        End Using


    End Sub
End Class
