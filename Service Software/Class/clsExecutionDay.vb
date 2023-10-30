Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Configuration



Public Class clsExecutionDay
    Public Property ID As Integer
    Public Property ActionID As Integer
    Public Property DayName As String
    Public Property DayID As Integer



    Public Sub Save(ByVal executeday As clsExecutionDay)

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Using con As OleDbConnection = New OleDbConnection(cs)

            Dim dc As OleDbCommand = New OleDbCommand("qryInsertExecutionDay", con)
            dc.CommandType = CommandType.StoredProcedure
            dc.Parameters.Add("ActionID1", OleDbType.Integer).Value = executeday.ActionID
            dc.Parameters.Add("DayName1", OleDbType.Char,255).Value = executeday.DayName
            dc.Parameters.Add("DayID1", OleDbType.Integer).Value = executeday.DayID
            con.Open()

            dc.ExecuteNonQuery()

        End Using

    End Sub


    Public Sub Delete(ByVal ActionID As Integer)

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Using con As OleDbConnection = New OleDbConnection(cs)

            Dim dc As OleDbCommand = New OleDbCommand("qryDeleteExecutionDay", con)
            dc.CommandType = CommandType.StoredProcedure
            dc.Parameters.Add("ActionID1", OleDbType.Integer).Value = ActionID

            con.Open()

            dc.ExecuteNonQuery()

        End Using

    End Sub


    Public ReadOnly Property GetDayListByID(ByVal Actionid As Integer) As IEnumerable(Of clsExecutionDay)
        Get
            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
            Dim lstDays As List(Of clsExecutionDay) = New List(Of clsExecutionDay)
            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dc As OleDbCommand = New OleDbCommand("qryGetExecutionDayByID", con)
                dc.CommandType = CommandType.StoredProcedure
                dc.Parameters.Add("ActionID1", OleDbType.Integer).Value = Actionid
                con.Open()
                Dim dr As OleDbDataReader = dc.ExecuteReader
                If dr.HasRows = True Then
                    While dr.Read
                        Dim TempDay As clsExecutionDay = New clsExecutionDay
                        TempDay.ID = Convert.ToInt32(dr("ID").ToString)
                        TempDay.ActionID = Convert.ToInt32(dr("ActionID").ToString)
                        TempDay.DayName = dr("DayName").ToString
                        TempDay.DayID = Convert.ToInt32(dr("DayID").ToString)
                        lstDays.Add(TempDay)
                    End While
                End If
            End Using
            Return lstDays
        End Get
    End Property


    Public ReadOnly Property IsExist(ByVal Actionid As Integer) As Boolean
        Get
            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
            Dim blnFlag As Boolean = False

            Using con As OleDbConnection = New OleDbConnection(cs)
                Try

                    Dim dc As OleDbCommand = New OleDbCommand("qryGetExecutionDayByID", con)
                    dc.CommandType = CommandType.StoredProcedure
                    dc.Parameters.Add("ActionID1", OleDbType.Integer).Value = Actionid
                    con.Open()
                    Dim dr As OleDbDataReader = dc.ExecuteReader
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


End Class
