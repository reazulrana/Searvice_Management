Imports System.Configuration
Imports System.Data
Imports System.Data.OleDb


Public Class clsRPTHowTimeBillPrintMethods


    Public Sub save(ByVal SaveBillPrint As clsRPTHowTimeBillPrint)
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim strQuery As String = "Insert into RPTHowTimeBillPrint(JobNo,BillNo) values(@JobNo,@BillNo)"
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcProductList As OleDbCommand = New OleDbCommand(strQuery, con)
            dcProductList.CommandType = CommandType.Text
            dcProductList.Parameters.Add("@JobNo", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(SaveBillPrint.JobNo), DBNull.Value, SaveBillPrint.JobNo)
            dcProductList.Parameters.Add("@BillNo", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(SaveBillPrint.BillNo), DBNull.Value, SaveBillPrint.BillNo)
            con.Open()
            dcProductList.ExecuteNonQuery()
        End Using
    End Sub



    Public Sub Update(ByVal SaveBillPrint As clsRPTHowTimeBillPrint, ByVal UpdateID As String, ByVal BillNo As String)
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim strQuery As String = "Update RPTHowTimeBillPrint Set JobNo=@JobNo,BillNo=@BillNo where RPTHowTimeBillPrint.JobNo=@JobNo1 and RPTHowTimeBillPrint.BillNo=@BillNo1"
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcProductList As OleDbCommand = New OleDbCommand(strQuery, con)
            dcProductList.CommandType = CommandType.StoredProcedure
            dcProductList.Parameters.Add("@JobNo", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(SaveBillPrint.JobNo), DBNull.Value, SaveBillPrint.JobNo)
            dcProductList.Parameters.Add("@BillNo", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(SaveBillPrint.BillNo), DBNull.Value, SaveBillPrint.BillNo)
            dcProductList.Parameters.Add("@JobNo1", OleDbType.Integer).Value = UpdateID
            dcProductList.Parameters.Add("@BillNo1", OleDbType.Char, 255).Value = BillNo
            con.Open()
            dcProductList.ExecuteNonQuery()
        End Using
    End Sub



    Public Sub Delete(ByVal DeleteID As String, ByVal BillNo As String)
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim strQuery As String = "Delete * From RPTHowTimeBillPrint where RPTHowTimeBillPrint.JobNo=@JobNo1 and RPTHowTimeBillPrint.BillNo=@BillNo1"
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcProductList As OleDbCommand = New OleDbCommand(strQuery, con)
            dcProductList.CommandType = CommandType.StoredProcedure
            dcProductList.Parameters.Add("@JobNo1", OleDbType.Char, 255).Value = DeleteID
            dcProductList.Parameters.Add("@BillNo1", OleDbType.Char, 255).Value = BillNo
            con.Open()
            dcProductList.ExecuteNonQuery()
        End Using
    End Sub







    Public ReadOnly Property GetALLBillNo() As IEnumerable(Of clsRPTHowTimeBillPrint)
        Get
            Dim ListBill As List(Of clsRPTHowTimeBillPrint) = New List(Of clsRPTHowTimeBillPrint)
            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
            Dim strQuery As String = "Select * From RPTHowTimeBillPrint"
            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dcGetBill As OleDbCommand = New OleDbCommand(strQuery, con)
                con.Open()
                Dim drGetBill As OleDbDataReader = dcGetBill.ExecuteReader
                If drGetBill.HasRows = True Then
                    While drGetBill.Read
                        Dim rptBill As clsRPTHowTimeBillPrint = New clsRPTHowTimeBillPrint
                        If Not String.IsNullOrEmpty(drGetBill("HTID").ToString) Then
                            rptBill.HTID = Convert.ToInt32(drGetBill("HTID").ToString)
                        End If
                        rptBill.JobNo = drGetBill("JobNo").ToString
                        rptBill.BillNo = drGetBill("BillNo").ToString
                        ListBill.Add(rptBill)
                    End While
                End If
            End Using
            Return ListBill
        End Get
    End Property

    Public ReadOnly Property GetSingleBillNo(ByVal SearchID As String, ByVal SearchBillNo As String) As clsRPTHowTimeBillPrint
        Get
            Dim rptBill As clsRPTHowTimeBillPrint = New clsRPTHowTimeBillPrint
            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
            Dim strQuery As String = "Select * From RPTHowTimeBillPrint where RPTHowTimeBillPrint.JobCode=@JobCode and RPTHowTimeBillPrint.BillNo=@BillNo"
            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dcGetBill As OleDbCommand = New OleDbCommand(strQuery, con)
                dcGetBill.Parameters.Add("@JobNo", OleDbType.Char, 255).Value = SearchID
                dcGetBill.Parameters.Add("@BillNo", OleDbType.Char, 255).Value = SearchBillNo
                con.Open()
                Dim drGetBill As OleDbDataReader = dcGetBill.ExecuteReader
                If drGetBill.HasRows = True Then
                    While drGetBill.Read
                        If Not String.IsNullOrEmpty(drGetBill("HTID").ToString) Then
                            rptBill.HTID = Convert.ToInt32(drGetBill("HTID").ToString)
                        End If
                        rptBill.JobNo = drGetBill("JobNo").ToString
                        rptBill.BillNo = drGetBill("BillNo").ToString
                    End While
                End If
            End Using
            Return rptBill
        End Get
    End Property

    Public Function IsExist(ByVal CheckID As String) As Boolean
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim strQuery As String = "Select * From RPTHowTimeBillPrint where RPTHowTimeBillPrint.JobNo=@JobNo1"

        Dim blnFlag As Boolean = False

        Try


            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dcProductList As OleDbCommand = New OleDbCommand(strQuery, con)
                dcProductList.CommandType = CommandType.Text
                dcProductList.Parameters.Add("@JobNo1", OleDbType.Char, 255).Value = CheckID
                con.Open()
                Dim drBillPrint As OleDbDataReader = dcProductList.ExecuteReader
                If drBillPrint.HasRows = True Then
                    blnFlag = True
                End If
            End Using

        Catch ex As Exception
            blnFlag = False
        End Try

        Return blnFlag
    End Function

    Public Function IsExist(ByVal CheckID As String, ByVal CheckBill As String) As Boolean
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim strQuery As String = "Select * From RPTHowTimeBillPrint where RPTHowTimeBillPrint.JobNo=@JobNo1 and RPTHowTimeBillPrint.BillNo=@BillNo"
        Dim blnFlag As Boolean = False

        Try


            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dcProductList As OleDbCommand = New OleDbCommand(strQuery, con)
                dcProductList.CommandType = CommandType.Text
                dcProductList.Parameters.Add("@JobNo1", OleDbType.Char, 255).Value = CheckID
                dcProductList.Parameters.Add("@BillNo", OleDbType.Char, 255).Value = CheckBill
                con.Open()
                Dim drBillPrint As OleDbDataReader = dcProductList.ExecuteReader
                If drBillPrint.HasRows = True Then
                    blnFlag = True
                End If
            End Using
        Catch ex As Exception
            blnFlag = False
        End Try

        Return blnFlag
    End Function

End Class
