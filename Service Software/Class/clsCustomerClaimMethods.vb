Imports System.Data
Imports System.Data.OleDb
Imports System.Configuration
Imports System.Transactions




Public Class clsCustomerClaimMethods







    Public Function GetCustomerClaim(ByVal SearchCriteria As String) As clsCustomerClaim
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim customerclaim As clsCustomerClaim = New clsCustomerClaim


        Using con As OleDbConnection = New OleDbConnection(cs)

            Dim dcCustomerClaim As OleDbCommand = New OleDbCommand("qryGet_Customerclaim_byJobcode", con)
            dcCustomerClaim.CommandType = CommandType.StoredProcedure

            dcCustomerClaim.Parameters.Add("paramJobCode", OleDbType.Char, 255).Value = SearchCriteria

            con.Open()
            Dim drCustomerClaim = dcCustomerClaim.ExecuteReader


            While drCustomerClaim.Read
                If Not String.IsNullOrEmpty(drCustomerClaim("ClaimID").ToString) Then
                    customerclaim.ClaimID = Convert.ToInt32(drCustomerClaim("ClaimID").ToString)
                End If

                If Not String.IsNullOrEmpty(drCustomerClaim("JobCode").ToString) Then
                    customerclaim.Jobcode = drCustomerClaim("JobCode").ToString
                End If
                If Not String.IsNullOrEmpty(drCustomerClaim("ClaimCode").ToString) Then
                    customerclaim.ClaimCode = drCustomerClaim("ClaimCode").ToString
                End If


            End While






        End Using




        Return customerclaim










    End Function

    Public Function IsExist(ByVal SearchCriteria) As Boolean
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Dim blnFlag As Boolean = False
        Try


            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dcCustomerClaim As OleDbCommand = New OleDbCommand("qryGet_Customerclaim_byJobcode", con)
                dcCustomerClaim.CommandType = CommandType.StoredProcedure
                dcCustomerClaim.Parameters.Add("paramJobCode", OleDbType.Char, 255).Value = SearchCriteria
                con.Open()
                Dim drCustomerClaim = dcCustomerClaim.ExecuteReader
                If drCustomerClaim.HasRows = True Then
                    blnFlag = True
                End If
            End Using
        Catch ex As Exception
            blnFlag = False

        End Try
        Return blnFlag
    End Function






    Public Sub Save(ByVal tmpcustomerclaim As clsCustomerClaim)


        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Using con As OleDbConnection = New OleDbConnection(cs)

            Dim dcInsertCustomerClaim As OleDbCommand = New OleDbCommand("qryInsertCustomerClaim", con)
            dcInsertCustomerClaim.CommandType = CommandType.StoredProcedure
            dcInsertCustomerClaim.Parameters.Add("paraJobCode1", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tmpcustomerclaim.Jobcode), DBNull.Value, tmpcustomerclaim.Jobcode)
            dcInsertCustomerClaim.Parameters.Add("paraClaimCode1", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tmpcustomerclaim.ClaimCode), DBNull.Value, tmpcustomerclaim.ClaimCode)

            con.Open()


            dcInsertCustomerClaim.ExecuteNonQuery()




        End Using


    End Sub



    Public Sub Update(ByVal tmpcustomerclaim As clsCustomerClaim, ByVal whereClause As String)


        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Using con As OleDbConnection = New OleDbConnection(cs)

            Dim dcInsertCustomerClaim As OleDbCommand = New OleDbCommand("qryUpdateCustomerClaim", con)
            dcInsertCustomerClaim.CommandType = CommandType.StoredProcedure
            dcInsertCustomerClaim.Parameters.Add("paraJobCode1", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tmpcustomerclaim.Jobcode), DBNull.Value, tmpcustomerclaim.Jobcode)
            dcInsertCustomerClaim.Parameters.Add("paraClaimCode1", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tmpcustomerclaim.ClaimCode), DBNull.Value, tmpcustomerclaim.ClaimCode)
            dcInsertCustomerClaim.Parameters.Add("paraJobCode2", OleDbType.Char, 255).Value = whereClause

            con.Open()


            dcInsertCustomerClaim.ExecuteNonQuery()



        End Using


    End Sub




    Public Sub Delete(ByVal DeleteCriteria As String)


        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Using con As OleDbConnection = New OleDbConnection(cs)

            Dim dcInsertCustomerClaim As OleDbCommand = New OleDbCommand("qryDeleteCustomerClaim", con)
            dcInsertCustomerClaim.CommandType = CommandType.StoredProcedure

            dcInsertCustomerClaim.Parameters.Add("paraJobCode1", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(DeleteCriteria), DBNull.Value, DeleteCriteria)
            con.Open()

            dcInsertCustomerClaim.ExecuteNonQuery()



        End Using


    End Sub

End Class
