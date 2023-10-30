Imports System.Data
Imports System.Data.OleDb
Imports System.Configuration



Public Class clstbGradeMethods


    Public Function GetCustomerGrade(ByVal SearchCriteria As String) As clstbGrade

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim tbGrade = New clstbGrade

        Using con As OleDbConnection = New OleDbConnection(cs)

            Dim dcCustGrade = New OleDbCommand("qryGet_tbGrade_byJobCode", con)
            dcCustGrade.CommandType = CommandType.StoredProcedure
            dcCustGrade.Parameters.Add("paramJobCode1", OleDbType.Char, 255).Value = SearchCriteria

            con.Open()

            Dim drCustGrade = dcCustGrade.ExecuteReader

            While drCustGrade.Read

                tbGrade.GradeID = Convert.ToInt32(drCustGrade("GradeID").ToString)
                tbGrade.Jobcode = drCustGrade("JobCode").ToString
                tbGrade.cGrade = drCustGrade("cGrade").ToString
                tbGrade.cRemarks = drCustGrade("cRemarks").ToString





            End While



        End Using

        Return tbGrade


    End Function


    Public Function IsExist(ByVal SearchCriteria As String) As Boolean

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim tbGrade = New clstbGrade
        Dim blnFlag As Boolean = False
        Try


            Using con As OleDbConnection = New OleDbConnection(cs)

                Dim dcCustGrade = New OleDbCommand("qryGet_tbGrade_byJobCode", con)
                dcCustGrade.CommandType = CommandType.StoredProcedure
                dcCustGrade.Parameters.Add("paramJobCode1", OleDbType.Char, 255).Value = SearchCriteria

                con.Open()

                Dim drCustGrade = dcCustGrade.ExecuteReader


                If drCustGrade.HasRows = True Then
                    blnFlag = True
                End If


            End Using
        Catch ex As Exception
            blnFlag = False

        End Try
        Return blnFlag


    End Function




    Public Sub save(ByVal tmptbGrade As clstbGrade)

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Using con As OleDbConnection = New OleDbConnection(cs)

            Dim dcInsertTbGrade = New OleDbCommand("qryInserttbGrade", con)
            dcInsertTbGrade.CommandType = CommandType.StoredProcedure
            dcInsertTbGrade.Parameters.Add("paraJobCode1", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tmptbGrade.Jobcode), DBNull.Value, tmptbGrade.Jobcode)
            dcInsertTbGrade.Parameters.Add("paracGrade1", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tmptbGrade.cGrade), DBNull.Value, tmptbGrade.cGrade)
            dcInsertTbGrade.Parameters.Add("paracRemarks1", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tmptbGrade.cRemarks), DBNull.Value, tmptbGrade.cRemarks)
            con.Open()
            dcInsertTbGrade.ExecuteNonQuery()


        End Using

    End Sub



    Public Sub Update(ByVal tmptbGrade As clstbGrade, ByVal whereclause As String)

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Using con As OleDbConnection = New OleDbConnection(cs)

            Dim dcInsertTbGrade = New OleDbCommand("qryUpdatetbGrade", con)
            dcInsertTbGrade.CommandType = CommandType.StoredProcedure
            dcInsertTbGrade.Parameters.Add("JobCode1", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(tmptbGrade.Jobcode), DBNull.Value, tmptbGrade.Jobcode)
            dcInsertTbGrade.Parameters.Add("cGrade1", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(tmptbGrade.cGrade), DBNull.Value, tmptbGrade.cGrade)
            dcInsertTbGrade.Parameters.Add("cRemarks1", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(tmptbGrade.cRemarks), DBNull.Value, tmptbGrade.cRemarks)
            dcInsertTbGrade.Parameters.Add("JobCode2", OleDbType.Char, 255).Value = whereclause

            con.Open()
            dcInsertTbGrade.ExecuteNonQuery()


        End Using

    End Sub


    Public Sub Delete(ByVal DeleteCriteria As String)
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Using con As OleDbConnection = New OleDbConnection(cs)

            Dim dcDeleteCustGrade As OleDbCommand = New OleDbCommand("qryDeletetbGrade", con)
            dcDeleteCustGrade.CommandType = CommandType.StoredProcedure
            dcDeleteCustGrade.Parameters.Add("param", OleDbType.Char, 255).Value = DeleteCriteria
            con.Open()
            dcDeleteCustGrade.ExecuteNonQuery()




        End Using


    End Sub

End Class
