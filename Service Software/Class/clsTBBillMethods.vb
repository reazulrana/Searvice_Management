Imports System.Configuration
Imports System.Data
Imports System.Data.OleDb


Public Class clsTBBillMethods



    Public Sub save(ByVal BillClass As clstbBill)
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim strQuery As String = "Insert Into TBBill(BillNO,JobNO) values(@BillNO,@JobNO)"
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcInsertServiceCharge As OleDbCommand = New OleDbCommand(strQuery, con)
            dcInsertServiceCharge.CommandType = CommandType.Text
            dcInsertServiceCharge.Parameters.Add("@BillNO", OleDbType.Integer).Value = If(String.IsNullOrEmpty(BillClass.BillNO), DBNull.Value, BillClass.BillNO)
            dcInsertServiceCharge.Parameters.Add("@JobNO", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(BillClass.JobNO), DBNull.Value, BillClass.JobNO)
            con.Open()
            dcInsertServiceCharge.ExecuteNonQuery()
        End Using
    End Sub


    Public Sub update(ByVal BillClass As clstbBill, ByVal updateID As String)
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim strQuery As String = "Update TBBill set BillNO=@BillNO,JobNO=@JobNO Where Tbbill.JobNO=@JobNO1"
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcInsertServiceCharge As OleDbCommand = New OleDbCommand(strQuery, con)
            dcInsertServiceCharge.CommandType = CommandType.StoredProcedure
            dcInsertServiceCharge.Parameters.Add("@BillNO", OleDbType.Integer).Value = If(String.IsNullOrEmpty(BillClass.BillNO), DBNull.Value, BillClass.BillNO)
            dcInsertServiceCharge.Parameters.Add("@JobNO", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(BillClass.JobNO), DBNull.Value, BillClass.JobNO)
            dcInsertServiceCharge.Parameters.Add("@JobNO1", OleDbType.Char, 255).Value = updateID
            con.Open()
            dcInsertServiceCharge.ExecuteNonQuery()
        End Using
    End Sub




    Public Sub update(ByVal DeleteID As String)
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim strQuery As String = "Delete * from  TBBill Where Tbbill.JobNO=@JobNO1"
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcInsertServiceCharge As OleDbCommand = New OleDbCommand(strQuery, con)
            dcInsertServiceCharge.CommandType = CommandType.StoredProcedure
            dcInsertServiceCharge.Parameters.Add("@JobNO1", OleDbType.Char, 255).Value = DeleteID
            con.Open()
            dcInsertServiceCharge.ExecuteNonQuery()
        End Using
    End Sub


    Public ReadOnly Property GetALLBillNo() As IEnumerable(Of clstbBill)
        Get
            Dim ListBill As List(Of clstbBill) = New List(Of clstbBill)
            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
            Dim strQuery As String = "Select * from  TBBill"
            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dcTbBill As OleDbCommand = New OleDbCommand(strQuery, con)
                con.Open()
                Dim drTbBill As OleDbDataReader = dcTbBill.ExecuteReader
                If drTbBill.HasRows = True Then
                    While drTbBill.Read
                        Dim bill As clstbBill = New clstbBill
                        If Not String.IsNullOrEmpty(drTbBill("BillNO").ToString.Trim) Then
                            bill.BillNO = Convert.ToInt32(drTbBill("BillNO").ToString)
                        End If
                        bill.JobNO = drTbBill("BillNO").ToString
                        ListBill.Add(bill)
                    End While
                End If
            End Using
            Return ListBill
        End Get
    End Property


    Public ReadOnly Property GetSingleBill(ByVal CheckID As String) As clstbBill
        Get
            Dim bill As clstbBill = New clstbBill
            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
            Dim strQuery As String = "Select * from  TBBill where tbbill.JobNo=@JobNo"
            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dcTbBill As OleDbCommand = New OleDbCommand(strQuery, con)
                dcTbBill.Parameters.Add("@JobNo", OleDbType.Char, 255).Value = CheckID
                con.Open()
                Dim drTbBill As OleDbDataReader = dcTbBill.ExecuteReader
                If drTbBill.HasRows = True Then
                    While drTbBill.Read

                        If Not String.IsNullOrEmpty(drTbBill("BillNO").ToString.Trim) Then
                            bill.BillNO = Convert.ToInt32(drTbBill("BillNO").ToString)
                        End If
                        bill.JobNO = drTbBill("JobNO").ToString

                    End While
                End If
            End Using
            Return bill
        End Get
    End Property



    Public ReadOnly Property ISEXIST(ByVal CheckID As String) As Boolean
        Get

            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
            Dim strQuery As String = "Select * from  TBBill where tbbill.JobNo=@JobNo"
            Dim blnFlag As Boolean = False
            Try



                Using con As OleDbConnection = New OleDbConnection(cs)
                    Dim dcTbBill As OleDbCommand = New OleDbCommand(strQuery, con)
                    dcTbBill.Parameters.Add("@JobNo", OleDbType.Char, 255).Value = CheckID
                    con.Open()
                    Dim drTbBill As OleDbDataReader = dcTbBill.ExecuteReader
                    If drTbBill.HasRows = True Then
                        blnFlag = True
                    End If
                End Using
            Catch ex As Exception
                blnFlag = False

            End Try
            Return blnFlag
        End Get
    End Property

    Public ReadOnly Property IsTableEmpty() As Boolean
        Get
            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
            Dim strQuery As String = "Select * from  TBBill"
            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dcTbBill As OleDbCommand = New OleDbCommand(strQuery, con)
                con.Open()
                Dim drTbBill As OleDbDataReader = dcTbBill.ExecuteReader
                If drTbBill.HasRows = True Then
                    Return False
                End If
            End Using
            Return True
        End Get
    End Property

    Public ReadOnly Property GetBillNo() As Integer
        Get
            Dim strGetMaxBill As Integer = 0
            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
            Dim strQuery As String = "Select Max(val(TbBill.BillNo))+1 as MaxBillNo from  TBBill"
            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dcTbBill As OleDbCommand = New OleDbCommand(strQuery, con)
                con.Open()
                strGetMaxBill = Convert.ToInt32(dcTbBill.ExecuteScalar)

            End Using
            Return strGetMaxBill
        End Get
    End Property

End Class
