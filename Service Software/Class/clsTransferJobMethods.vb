Imports System.Configuration
Imports System.Data
Imports System.Data.OleDb



Public Class clsTransferJobMethods


    Public Sub Save(ByVal TransferJob As clsTransferJob)



        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim strQuery As String = "Insert Into TransferJob(JobCode, Remarks, TransferFrom, TransferTo, TrDate, TrByCode,TrByName) values(@JobCode, @Remarks, @TransferFrom, @TransferTo, @TrDate, @TrByCode,@TrByName)"
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcTransferJob = New OleDbCommand(strQuery, con)
            dcTransferJob.CommandType = CommandType.Text
            dcTransferJob.Parameters.Add("@JobCode", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(TransferJob.JobCode), DBNull.Value, TransferJob.JobCode)
            dcTransferJob.Parameters.Add("@Remarks", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(TransferJob.Remarks), DBNull.Value, TransferJob.Remarks)
            dcTransferJob.Parameters.Add("@TransferFrom", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(TransferJob.TransferFrom), DBNull.Value, TransferJob.TransferFrom)
            dcTransferJob.Parameters.Add("@TransferTo", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(TransferJob.TransferTo), DBNull.Value, TransferJob.TransferTo)
            dcTransferJob.Parameters.Add("@TrDate", OleDbType.Date).Value = If(String.IsNullOrEmpty(TransferJob.TrDate), DBNull.Value, TransferJob.TrDate)
            dcTransferJob.Parameters.Add("@TrByCode", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(TransferJob.TrByCode), DBNull.Value, TransferJob.TrByCode)
            dcTransferJob.Parameters.Add("@TrByName", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(TransferJob.TrByName), DBNull.Value, TransferJob.TrByName)
            con.Open()
            dcTransferJob.ExecuteNonQuery()
        End Using



    End Sub



    Public Sub Update(ByVal TransferJob As clsTransferJob, ByVal UpdateID As String)



        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim strQuery As String = "Update TransferJob Set JobCode=@JobCode, Remarks=@Remarks, TransferFrom=@TransferFrom, TransferTo=@TransferTo, TrDate=@TrDate, TrByCode=@TrByCode,TrByName=@TrByName where TransferJob.JobCode=@JobCode1"
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcTransferJob = New OleDbCommand(strQuery, con)
            dcTransferJob.CommandType = CommandType.Text
            dcTransferJob.Parameters.Add("@JobCode", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(TransferJob.JobCode), DBNull.Value, TransferJob.JobCode)
            dcTransferJob.Parameters.Add("@Remarks", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(TransferJob.Remarks), DBNull.Value, TransferJob.Remarks)
            dcTransferJob.Parameters.Add("@TransferFrom", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(TransferJob.TransferFrom), DBNull.Value, TransferJob.TransferFrom)
            dcTransferJob.Parameters.Add("@TransferTo", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(TransferJob.TransferTo), DBNull.Value, TransferJob.TransferTo)
            dcTransferJob.Parameters.Add("@TrDate", OleDbType.Date).Value = If(String.IsNullOrEmpty(TransferJob.TrDate), DBNull.Value, TransferJob.TrDate)
            dcTransferJob.Parameters.Add("@TrByCode", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(TransferJob.TrByCode), DBNull.Value, TransferJob.TrByCode)
            dcTransferJob.Parameters.Add("@TrByName", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(TransferJob.TrByName), DBNull.Value, TransferJob.TrByName)
            dcTransferJob.Parameters.Add("@JobCode1", OleDbType.Char, 255).Value = UpdateID
            con.Open()
            dcTransferJob.ExecuteNonQuery()
        End Using



    End Sub



    Public Sub Delete(ByVal DeleteID As String)
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim strQuery As String = "Delete * from TransferJob where TransferJob.JobCode=@JobCode1"
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcTransferJob = New OleDbCommand(strQuery, con)
            dcTransferJob.CommandType = CommandType.StoredProcedure
            dcTransferJob.Parameters.Add("@JobCode1", OleDbType.Char, 255).Value = DeleteID
            con.Open()
            dcTransferJob.ExecuteNonQuery()
        End Using
    End Sub



    Public ReadOnly Property GetAllTransfer() As IEnumerable(Of clsTransferJob)
        Get

            Dim listTransderjob As List(Of clsTransferJob) = New List(Of clsTransferJob)

            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

            Dim strQuery As String = "Select * from TransferJob"



            Using con As OleDbConnection = New OleDbConnection(cs)

                Dim dcTransferJob As OleDbCommand = New OleDbCommand(strQuery, con)

                con.Open()
                Dim drTransferJob As OleDbDataReader = dcTransferJob.ExecuteReader


                If drTransferJob.HasRows = True Then
                    While drTransferJob.Read
                        'JobCode, Remarks, TransferFrom, TransferTo, TrDate, TrByCode,TrByName

                        Dim Transferjob As clsTransferJob = New clsTransferJob
                        If Not String.IsNullOrEmpty(drTransferJob("TrID").ToString.Trim) Then
                            Transferjob.TrID = Convert.ToInt32(drTransferJob("TrID").ToString)
                        End If
                        Transferjob.JobCode = drTransferJob("JobCode").ToString
                        Transferjob.Remarks = drTransferJob("Remarks").ToString
                        Transferjob.TransferFrom = drTransferJob("TransferFrom").ToString
                        Transferjob.TransferTo = drTransferJob("TransferTo").ToString
                        If Not String.IsNullOrEmpty(drTransferJob("TrDate").ToString) Then
                            Transferjob.TrDate = drTransferJob("TrDate").ToString
                        End If
                        Transferjob.TrByCode = drTransferJob("TrByCode").ToString
                        Transferjob.TrByName = drTransferJob("TrByName").ToString

                        listTransderjob.Add(Transferjob)

                    End While
                End If







            End Using



            Return listTransderjob

        End Get
    End Property





    Public ReadOnly Property GetSingleTransfer(ByVal SearchID As String) As clsTransferJob
        Get

            Dim Transferjob As clsTransferJob = New clsTransferJob

            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

            Dim strQuery As String = "Select * from TransferJob where TransferJob.JobCode=@JobCode"



            Using con As OleDbConnection = New OleDbConnection(cs)

                Dim dcTransferJob As OleDbCommand = New OleDbCommand(strQuery, con)

                dcTransferJob.Parameters.Add("@JobCode", OleDbType.Char, 255).Value = SearchID

                con.Open()
                Dim drTransferJob As OleDbDataReader = dcTransferJob.ExecuteReader


                If drTransferJob.HasRows = True Then
                    While drTransferJob.Read
                        'JobCode, Remarks, TransferFrom, TransferTo, TrDate, TrByCode,TrByName


                        If Not String.IsNullOrEmpty(drTransferJob("TrID").ToString.Trim) Then
                            Transferjob.TrID = Convert.ToInt32(drTransferJob("TrID").ToString)
                        End If
                        Transferjob.JobCode = drTransferJob("JobCode").ToString
                        Transferjob.Remarks = drTransferJob("Remarks").ToString
                        Transferjob.TransferFrom = drTransferJob("TransferFrom").ToString
                        Transferjob.TransferTo = drTransferJob("TransferTo").ToString
                        If Not String.IsNullOrEmpty(drTransferJob("TrDate").ToString) Then
                            Transferjob.TrDate = drTransferJob("TrDate").ToString
                        End If
                        Transferjob.TrByCode = drTransferJob("TrByCode").ToString
                        Transferjob.TrByName = drTransferJob("TrByName").ToString
                    End While
                End If







            End Using



            Return Transferjob

        End Get
    End Property


    Public Function IsExist(ByVal SearchID As String) As Boolean

        Dim Transferjob As clsTransferJob = New clsTransferJob
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim strQuery As String = "Select * from TransferJob where TransferJob.JobCode=@JobCode"
        Dim blnFlag As Boolean = False

        Try


            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dcTransferJob As OleDbCommand = New OleDbCommand(strQuery, con)
                dcTransferJob.Parameters.Add("@JobCode", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(SearchID), DBNull.Value, SearchID)
                con.Open()
                Dim drTransferJob As OleDbDataReader = dcTransferJob.ExecuteReader
                If drTransferJob.HasRows = True Then
                    blnFlag = True
                End If
            End Using
        Catch ex As Exception
            blnFlag = False

        End Try
        Return blnFlag
    End Function



End Class
