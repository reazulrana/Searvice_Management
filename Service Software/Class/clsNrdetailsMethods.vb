Imports System.Data
Imports System.Data.OleDb
Imports System.Configuration


Public Class clsNrdetailsMethods


    Public Sub save(ByVal InsertModel As clsNrdetails)

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Using con As OleDbConnection = New OleDbConnection(cs)

            Dim dcSaveNR As OleDbCommand = New OleDbCommand("qryInsertNRDetails", con)
            dcSaveNR.CommandType = CommandType.StoredProcedure
            dcSaveNR.Parameters.Add("paramJobCode", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(InsertModel.JobCode), DBNull.Value, InsertModel.JobCode)
            dcSaveNR.Parameters.Add("paramNrCode", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(InsertModel.NRCode), DBNull.Value, InsertModel.NRCode)
            con.Open()
            dcSaveNR.ExecuteNonQuery()


        End Using

    End Sub




    Public Sub Update(ByVal UpdateModel As clsNrdetails, ByVal UpdateCriteria As String)

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Using con As OleDbConnection = New OleDbConnection(cs)

            Dim dcUpdateNR As OleDbCommand = New OleDbCommand("qryUpdateNRDetails", con)
            dcUpdateNR.CommandType = CommandType.StoredProcedure
            dcUpdateNR.Parameters.Add("paramJobCode", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(UpdateModel.JobCode), DBNull.Value, UpdateModel.JobCode)
            dcUpdateNR.Parameters.Add("paramNrCode", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(UpdateModel.NRCode), DBNull.Value, UpdateModel.NRCode)
            dcUpdateNR.Parameters.Add("paramJobCode2", OleDbType.Char, 255).Value = UpdateCriteria
            con.Open()
            dcUpdateNR.ExecuteNonQuery()

        End Using

    End Sub




    Public Sub Delete(ByVal DeleteCriteria As String)

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Using con As OleDbConnection = New OleDbConnection(cs)

            Dim dcDeleteNR As OleDbCommand = New OleDbCommand("qryDeleteNrDetails", con)
            dcDeleteNR.CommandType = CommandType.StoredProcedure
            dcDeleteNR.Parameters.Add("paramJobCode", OleDbType.Char, 255).Value = DeleteCriteria
            con.Open()
            dcDeleteNR.ExecuteNonQuery()

        End Using

    End Sub



    Public Function GetNR(ByVal SearchCriteria As String) As clsNrdetails

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim NrDetails As clsNrdetails = New clsNrdetails
        Using con As OleDbConnection = New OleDbConnection(cs)

            Dim dcGetNR As OleDbCommand = New OleDbCommand("qryGet_NrDetails_byJobCode", con)
            dcGetNR.CommandType = CommandType.StoredProcedure
            dcGetNR.Parameters.Add("paramJobCode", OleDbType.Char, 255).Value = SearchCriteria

            con.Open()
            Dim drGetNR As OleDbDataReader = dcGetNR.ExecuteReader

            While drGetNR.Read
                NrDetails.ClaimID = Convert.ToInt32(drGetNR("ClaimID").ToString)
                NrDetails.JobCode = drGetNR("JobCode").ToString
                NrDetails.NRCode = drGetNR("NRCode").ToString
            End While


        End Using
        Return NrDetails
    End Function


    Public Function IsExist(ByVal SearchCriteria As String) As Boolean

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim NrDetails As clsNrdetails = New clsNrdetails

        Dim blnFlag As Boolean = False
        Try


            Using con As OleDbConnection = New OleDbConnection(cs)

                Dim dcGetNR As OleDbCommand = New OleDbCommand("qryGet_NrDetails_byJobCode", con)
                dcGetNR.CommandType = CommandType.StoredProcedure
                dcGetNR.Parameters.Add("paramJobCode", OleDbType.Char, 255).Value = SearchCriteria

                con.Open()
                Dim drGetNR As OleDbDataReader = dcGetNR.ExecuteReader
                If drGetNR.HasRows = True Then
                    blnFlag = True
                End If
            End Using
        Catch ex As Exception
            blnFlag = False

        End Try


        Return blnFlag
    End Function

End Class
