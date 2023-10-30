Imports System
Imports System.Configuration
Imports System.Data
Imports System.Data.OleDb

Public Class clsExecutionJobStatus
    Public Property ID As Integer

    Public Property StatusName As String
    Public Property ActionID As Integer
    Public Property cFlag As Integer



    Public ReadOnly Property GetJobStatus() As IEnumerable(Of clsExecutionJobStatus)
        Get

            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

            Dim ListJobSattus As List(Of clsExecutionJobStatus) = New List(Of clsExecutionJobStatus)


            Using con As OleDbConnection = New OleDbConnection(cs)

                Dim dc As OleDbCommand = New OleDbCommand("qryGetExecutionJobStatus", con)
                dc.CommandType = CommandType.StoredProcedure


                con.Open()
                Dim dr As OleDbDataReader = dc.ExecuteReader

                If dr.HasRows = True Then
                    While dr.Read
                        Dim jobstatus As clsExecutionJobStatus = New clsExecutionJobStatus

                        jobstatus.ID = Convert.ToInt32(dr("ID").ToString)

                        jobstatus.ID = Convert.ToInt32(dr("ID").ToString)
                        jobstatus.StatusName = dr("StatusName").ToString
                        jobstatus.ActionID = Convert.ToInt32(dr("ActionID").ToString)
                        jobstatus.cFlag = Convert.ToInt32(dr("cFlag").ToString)

                        ListJobSattus.Add(jobstatus)

                    End While
                End If



            End Using


            Return ListJobSattus
        End Get
    End Property

End Class
