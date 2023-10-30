Imports System.Configuration
Imports System.Data.OleDb
Imports System.Data


Public Class clstbBill_FFCMethods


    Public Sub Save_Service_Charge(ByVal tmpclsServiceCharge As clstbBill_FFC)


        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Using con As OleDbConnection = New OleDbConnection(cs)


            Dim dcInsertServiceCharge As OleDbCommand = New OleDbCommand("qryInserttbBillFFC", con)
            dcInsertServiceCharge.CommandType = CommandType.StoredProcedure
            dcInsertServiceCharge.Parameters.Add("paraJobCode", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tmpclsServiceCharge.Jobcode), DBNull.Value, tmpclsServiceCharge.Jobcode)
            dcInsertServiceCharge.Parameters.Add("parafc1", OleDbType.Double).Value = If(String.IsNullOrEmpty(tmpclsServiceCharge.FaultCharge), DBNull.Value, tmpclsServiceCharge.FaultCharge)
            dcInsertServiceCharge.Parameters.Add("parasc1", OleDbType.Double).Value = If(String.IsNullOrEmpty(tmpclsServiceCharge.ServiceCharge), DBNull.Value, tmpclsServiceCharge.ServiceCharge)

            con.Open()
            dcInsertServiceCharge.ExecuteNonQuery()

        End Using

    End Sub




    Public Sub Update_Service_Charge(ByVal tmpclsServiceCharge As clstbBill_FFC, ByVal whereClause As String)


        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Using con As OleDbConnection = New OleDbConnection(cs)


            Dim dcInsertServiceCharge As OleDbCommand = New OleDbCommand("qryUpdatetbBillFFC", con)
            dcInsertServiceCharge.CommandType = CommandType.StoredProcedure
            dcInsertServiceCharge.Parameters.Add("parscJobCode", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tmpclsServiceCharge.Jobcode), DBNull.Value, tmpclsServiceCharge.Jobcode)
            dcInsertServiceCharge.Parameters.Add("parafc1", OleDbType.Double).Value = If(String.IsNullOrEmpty(tmpclsServiceCharge.FaultCharge), DBNull.Value, tmpclsServiceCharge.FaultCharge)
            dcInsertServiceCharge.Parameters.Add("parasc1", OleDbType.Double).Value = If(String.IsNullOrEmpty(tmpclsServiceCharge.ServiceCharge), DBNull.Value, tmpclsServiceCharge.ServiceCharge)
            dcInsertServiceCharge.Parameters.Add("parscJobCode2", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(whereClause), DBNull.Value, whereClause)

            con.Open()
            dcInsertServiceCharge.ExecuteNonQuery()

        End Using

    End Sub




    Public Sub Delete_Service_Charge(ByVal whereClause As String)


        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Using con As OleDbConnection = New OleDbConnection(cs)


            Dim dcInsertServiceCharge As OleDbCommand = New OleDbCommand("qryDeletetbBllFFC", con)
            dcInsertServiceCharge.CommandType = CommandType.StoredProcedure
            dcInsertServiceCharge.Parameters.Add("parscJobCode2", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(whereClause), DBNull.Value, whereClause)

            con.Open()
            dcInsertServiceCharge.ExecuteNonQuery()

        End Using

    End Sub


    Public Function GetServiceCharge(ByVal SearchCriteria As String) As clstbBill_FFC
        Dim clsServiceCharge As clstbBill_FFC = New clstbBill_FFC
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcGetServiceCharge As OleDbCommand = New OleDbCommand("qryGet_tbBill_FFC_ByJobCOde", con)
            dcGetServiceCharge.CommandType = CommandType.StoredProcedure
            dcGetServiceCharge.Parameters.Add("paraJobCode", OleDbType.Char, 255).Value = SearchCriteria
            con.Open()
            Dim drgetServiceCharge As OleDbDataReader = dcGetServiceCharge.ExecuteReader()
            While drgetServiceCharge.Read
                clsServiceCharge.Jobcode = drgetServiceCharge("Jobcode").ToString
                If Not String.IsNullOrEmpty(drgetServiceCharge("FaultCharge").ToString) Then
                    clsServiceCharge.FaultCharge = Convert.ToInt32(drgetServiceCharge("FaultCharge").ToString)
                End If
                If Not String.IsNullOrEmpty(drgetServiceCharge("ServiceCharge").ToString) Then
                    clsServiceCharge.ServiceCharge = Convert.ToInt32(drgetServiceCharge("ServiceCharge").ToString)
                End If
            End While
        End Using
        Return clsServiceCharge
    End Function


    Public Function ISEXIST(ByVal SearchCriteria As String) As Boolean
        Dim clsServiceCharge As clstbBill_FFC = New clstbBill_FFC
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Dim blnFlag As Boolean = False
        Try



            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dcGetServiceCharge As OleDbCommand = New OleDbCommand("qryGet_tbBill_FFC_ByJobCOde", con)
                dcGetServiceCharge.CommandType = CommandType.StoredProcedure
                dcGetServiceCharge.Parameters.Add("paraJobCode", OleDbType.Char, 255).Value = SearchCriteria
                con.Open()
                Dim drgetServiceCharge As OleDbDataReader = dcGetServiceCharge.ExecuteReader()
                If drgetServiceCharge.HasRows = True Then
                    blnFlag = True
                End If
            End Using
        Catch ex As Exception
            blnFlag = False
        End Try
        Return blnFlag
    End Function


End Class
