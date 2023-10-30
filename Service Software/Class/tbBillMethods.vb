Imports System.Data
Imports System.Data.OleDb
Imports System
Imports System.Configuration



Public Class tbBillMethods


    Public Sub SaveBatch(ByVal tmpbill As DataTable)
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Using con As OleDbConnection = New OleDbConnection(cs)

            Dim dcSaveBatch As OleDbCommand = New OleDbCommand("Insert into tbBill(JobNo) values(@param)", con)
            dcSaveBatch.CommandType = CommandType.Text

            dcSaveBatch.Parameters.Add("param", OleDbType.Char, 255).Value = tmpbill


            dcSaveBatch.ExecuteNonQuery()


        End Using


    End Sub


End Class
