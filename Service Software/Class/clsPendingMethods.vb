Imports System.Data.OleDb
Imports System.Data
Imports System.Configuration


Public Class clsPendingMethods


    Public Sub save(ByVal TempPending As clsPending)

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Using con As OleDbConnection = New OleDbConnection(cs)

            Dim dcSavePending As OleDbCommand = New OleDbCommand("qryInsertPending", con)
            dcSavePending.CommandType = CommandType.StoredProcedure

            dcSavePending.Parameters.Add("paramJobCode", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(TempPending.JobCode), DBNull.Value, TempPending.JobCode)
            dcSavePending.Parameters.Add("paramPencode", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(TempPending.PenCode), DBNull.Value, TempPending.PenCode)

            con.Open()

            dcSavePending.ExecuteNonQuery()

        End Using

    End Sub



    Public Sub Update(ByVal tmpPending As clsPending, ByVal UpdateCriteria As String)

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcUpdatePending As OleDbCommand = New OleDbCommand("qryUpdatePending", con)
            dcUpdatePending.CommandType = CommandType.StoredProcedure
            dcUpdatePending.Parameters.Add("paramJobCode1", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tmpPending.JobCode), DBNull.Value, tmpPending.JobCode)
            dcUpdatePending.Parameters.Add("paramPencode", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tmpPending.PenCode), DBNull.Value, tmpPending.PenCode)
            dcUpdatePending.Parameters.Add("paramJobCode2", OleDbType.Char, 255).Value = UpdateCriteria

            con.Open()

            dcUpdatePending.ExecuteNonQuery()



        End Using


    End Sub




    Public Sub Delete(ByVal DeleteCriteria As String)

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcDeletePending As OleDbCommand = New OleDbCommand("qryDeletePending", con)
            dcDeletePending.CommandType = CommandType.StoredProcedure
            dcDeletePending.Parameters.Add("paramJobCode2", OleDbType.Char, 255).Value = DeleteCriteria

            con.Open()

            dcDeletePending.ExecuteNonQuery()



        End Using


    End Sub



    Public Function GetPending(ByVal SearchCriteria As String) As clsPending

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim pending As clsPending = New clsPending

        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcGetPending As OleDbCommand = New OleDbCommand("qryGet_Pending_byJobCode", con)
            dcGetPending.CommandType = CommandType.StoredProcedure
            dcGetPending.Parameters.Add("paramJobCode", OleDbType.Char, 255).Value = SearchCriteria.ToString
            con.Open()
            Dim drGetPending As OleDbDataReader = dcGetPending.ExecuteReader

            While drGetPending.Read
                pending.ClaimID = Convert.ToInt32(drGetPending("ClaimID").ToString)
                pending.JobCode = drGetPending("JobCode").ToString
                pending.PenCode = drGetPending("Pencode").ToString

            End While





        End Using
        Return pending

    End Function



    Public Function IsExist(ByVal SearchCriteria As String) As Boolean

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim pending As clsPending = New clsPending
        Dim blnflag As Boolean = False

        Try


            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dcGetPending As OleDbCommand = New OleDbCommand("qryGet_Pending_byJobCode", con)
                dcGetPending.CommandType = CommandType.StoredProcedure
                dcGetPending.Parameters.Add("paramJobCode", OleDbType.Char, 255).Value = SearchCriteria.ToString
                con.Open()
                Dim drGetPending As OleDbDataReader = dcGetPending.ExecuteReader
                If drGetPending.HasRows = True Then
                    blnflag = True
                End If
            End Using

        Catch ex As Exception
            blnflag = False

        End Try
        Return blnflag
    End Function

End Class
