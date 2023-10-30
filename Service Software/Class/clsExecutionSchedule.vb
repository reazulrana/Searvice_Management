Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Configuration


Public Class clsExecutionSchedule
    Public Property ID As Integer
    Public Property ActionName As String
    Public Property ExceededDay As Integer
    Public Property ActionTime As DateTime
    Public Property IsActive As Boolean









    Public ReadOnly Property GetSchduleID(ByVal ActionName As String) As Integer
        Get
            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
            Dim intTempId As Integer = 0
            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dc As OleDbCommand = New OleDbCommand("qryGetExecutionScheduleID", con)
                dc.CommandType = CommandType.StoredProcedure
                dc.Parameters.Add("ActionName1", OleDbType.Char, 255).Value = ActionName
                con.Open()
                Dim dr As OleDbDataReader = dc.ExecuteReader
                If dr.HasRows = True Then
                    While dr.Read
                        intTempId = Convert.ToInt32(dr("ID").ToString)
                    End While
                End If
            End Using

            Return intTempId
        End Get
    End Property

    Public Sub update(ByVal ExecutionSchedule As clsExecutionSchedule)


        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dc As OleDbCommand = New OleDbCommand("qryUpdateExecutionSchedule", con)
            dc.CommandType = CommandType.StoredProcedure
            dc.Parameters.Add("ExceededDay1", OleDbType.Integer).Value = ExecutionSchedule.ExceededDay
            dc.Parameters.Add("ActionTime1", OleDbType.Date).Value = ExecutionSchedule.ActionTime
            dc.Parameters.Add("IsActive1", OleDbType.Boolean).Value = ExecutionSchedule.IsActive
            dc.Parameters.Add("ActionName1", OleDbType.Char, 255).Value = ExecutionSchedule.ActionName

            con.Open()
            dc.ExecuteNonQuery()

        End Using

        'qryUpdateExecutionSchedule


    End Sub



    Public ReadOnly Property IsExist(ByVal ActionName As String) As Boolean
        Get
            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
            Dim blnFlag As Boolean = False

            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dc As OleDbCommand = New OleDbCommand("qryGetExecutionScheduleID", con)
                dc.CommandType = CommandType.StoredProcedure
                dc.Parameters.Add("ActionName1", OleDbType.Char, 255).Value = ActionName
                con.Open()
                Dim dr As OleDbDataReader = dc.ExecuteReader
                Try

                    If dr.HasRows = True Then
                        blnFlag = True
                    End If

                Catch ex As Exception
                    blnFlag = False
                End Try
            End Using

            Return blnFlag
        End Get
    End Property


    Public ReadOnly Property GetActiveSchedules() As IEnumerable(Of clsExecutionSchedule)
        Get
            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
            Dim blnFlag As Boolean = False

            Dim ActiveList As List(Of clsExecutionSchedule) = New List(Of clsExecutionSchedule)

            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dc As OleDbCommand = New OleDbCommand("qryGetExecutionScheduleActive", con)
                dc.CommandType = CommandType.StoredProcedure


                con.Open()
                Dim dr As OleDbDataReader = dc.ExecuteReader

                If dr.HasRows = True Then
                    While dr.Read
                        Dim tmpSchedule As clsExecutionSchedule = New clsExecutionSchedule

                        tmpSchedule.ID = Convert.ToInt32(dr("ID").ToString)
                        tmpSchedule.ActionName = dr("ActionName").ToString
                        tmpSchedule.ExceededDay = Convert.ToInt32(dr("ExceededDay").ToString)
                        tmpSchedule.ActionTime = Date.Parse(dr("ActionTime").ToString).ToString("h:mm:ss tt")
                        tmpSchedule.IsActive = Convert.ToBoolean(dr("IsActive").ToString)
                        ActiveList.Add(tmpSchedule)
                    End While
                End If


            End Using

            Return ActiveList
        End Get
    End Property




    Public ReadOnly Property GetAllSchedule() As IEnumerable(Of clsExecutionSchedule)
        Get
            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
            Dim blnFlag As Boolean = False

            Dim ActiveList As List(Of clsExecutionSchedule) = New List(Of clsExecutionSchedule)

            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dc As OleDbCommand = New OleDbCommand("QryGetExecutionSchedule_ALL", con)
                dc.CommandType = CommandType.StoredProcedure
                con.Open()
                Dim dr As OleDbDataReader = dc.ExecuteReader

                If dr.HasRows = True Then
                    While dr.Read
                        Dim tmpSchedule As clsExecutionSchedule = New clsExecutionSchedule

                        tmpSchedule.ID = Convert.ToInt32(dr("ID").ToString)
                        tmpSchedule.ActionName = dr("ActionName").ToString
                        tmpSchedule.ExceededDay = Convert.ToInt32(dr("ExceededDay").ToString)
                        tmpSchedule.ActionTime = Date.Parse(dr("ID").ToString).ToString("h:mm:ss tt")
                        ActiveList.Add(tmpSchedule)
                    End While
                End If


            End Using

            Return ActiveList
        End Get
    End Property

End Class
