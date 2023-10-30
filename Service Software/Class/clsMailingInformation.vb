Imports System.Configuration

Imports System.Data.OleDb
Imports System.Data

Public Class clsMailingInformation
    Public Property sl As Integer

    Public Property JobCode As String
    Public Property Branch As String
    Public Property Customer As String
    Public Property Address As String
    Public Property Category As String
    Public Property Brand As String
    Public Property Model As String
    Public Property ReceveDate As String
    Public Property IssueDate As String
    Public Property RepairDate As String
    Public Property WarrType As String
    Public Property Status As String
    Public Property CurrentStatus As String
    Public Property ServiceCharge As Double
    Public Property Parts As Double
    Public Property PStatus As String

    Public Property Tat As String




    Public ReadOnly Property GetMailInformation(ByVal Criteria As Integer, ByVal Type As String) As DataTable
        Get
            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

            Dim dt As DataTable = New DataTable

            Using con As OleDbConnection = New OleDbConnection(cs)


                Dim dc As OleDbCommand = New OleDbCommand()
                If Type.ToLower = "Assigned".ToLower Then
                    dc.CommandText = "qryGetMailinginformation_Assigned"
                Else
                    dc.CommandText = "qryGetMailingInformation_byStatus"
                End If
                dc.Connection = con
                dc.CommandType = CommandType.StoredProcedure
                dc.Parameters.Add("pstatus1", OleDbType.Char, 255).Value = "New"
                dc.Parameters.Add("Status1", OleDbType.Integer).Value = Criteria
                con.Open()

                Dim dr As OleDbDataReader = dc.ExecuteReader

                If dr.HasRows = True Then

                    dt.Load(dr)
                End If

            End Using
            Return dt
        End Get
    End Property



    Public Sub UpdateAll()

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString



        Using con As OleDbConnection = New OleDbConnection(cs)

            Dim dc As OleDbCommand = New OleDbCommand("qryUpdateMailingInformation", con)
            dc.CommandType = CommandType.StoredProcedure

            con.Open()
            dc.ExecuteNonQuery()

        End Using

    End Sub


    Public Sub UpdatePartial()

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString


        Dim strUpdate As String = "Update Mailinginformation inner Join Claiminfo on Mailinginformation.JobCode=Claiminfo.JobCode  Set pstatus=iif(Claiminfo.Cflag=Mailinginformation.Status,'Old','New')"
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dc As OleDbCommand = New OleDbCommand
            dc.Connection = con
            dc.CommandText = strUpdate

            con.Open()
            dc.ExecuteNonQuery()
            strUpdate = "Update Mailinginformation inner Join Claiminfo on Mailinginformation.JobCode=Claiminfo.JobCode  Set Mailinginformation.Status=Claiminfo.cflag"
            dc.CommandText = strUpdate
            dc.ExecuteNonQuery()

        End Using

    End Sub


    Public Sub Delete(ByVal DeleteStatus As Integer)

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString



        Using con As OleDbConnection = New OleDbConnection(cs)

            Dim dc As OleDbCommand = New OleDbCommand("qryDeleteMailingInformation", con)
            dc.CommandType = CommandType.StoredProcedure
            dc.Parameters.Add("CurrentStatus1", OleDbType.Integer).Value = DeleteStatus

            con.Open()
            dc.ExecuteNonQuery()

        End Using

    End Sub





    Public ReadOnly Property HasRow() As Boolean
        Get
            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

            Dim blnFlag As Boolean = False

            Using con As OleDbConnection = New OleDbConnection(cs)

                Dim dc As OleDbCommand = New OleDbCommand("Select * from MailingInformation", con)
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




    Public Sub Insert(ByVal Status As Integer, ByVal ActionName As String, ByVal intExcededDay As Integer)


        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim strSqlQuery As String = String.Empty

        Dim dc As OleDbCommand = New OleDbCommand





        Using con As OleDbConnection = New OleDbConnection(cs)


            If Status = -1 And ActionName.ToLower = "Not Issued".ToLower Then
                strSqlQuery = "qrySendReceive"
                dc.CommandText = strSqlQuery
                dc.CommandType = CommandType.StoredProcedure
                dc.Parameters.Add("@ReceptDate", OleDbType.Integer).Value = intExcededDay
            End If

            If Status = -1 And ActionName.ToLower = "Assigned".ToLower Then
                strSqlQuery = "qrySendAssigned"
                dc.CommandText = strSqlQuery
                dc.CommandType = CommandType.StoredProcedure
                dc.Parameters.Add("@Isssuedate", OleDbType.Integer).Value = intExcededDay
            End If



            If Status = 9 And ActionName.ToLower = "Waiting for Delivery".ToLower Then
                strSqlQuery = "qrySendPending"
                dc.CommandText = strSqlQuery
                dc.CommandType = CommandType.StoredProcedure
                dc.Parameters.Add("@Sdate", OleDbType.Integer).Value = intExcededDay
            End If



            If Status = 1 And ActionName.ToLower = "Waiting for Delivery".ToLower Then
                strSqlQuery = "qrySendService"
                dc.CommandText = strSqlQuery
                dc.CommandType = CommandType.StoredProcedure
                dc.Parameters.Add("@Sdate", OleDbType.Integer).Value = intExcededDay
            End If



            If Status = 99 And ActionName.ToLower = "Waiting for Delivery".ToLower Then
                strSqlQuery = "qrySendNR"
                dc.CommandText = strSqlQuery
                dc.CommandType = CommandType.StoredProcedure
                dc.Parameters.Add("@Sdate", OleDbType.Integer).Value = intExcededDay
            End If



            If Status = 101 And ActionName.ToLower = "Waiting for Delivery".ToLower Then
                strSqlQuery = "qrySendReplace"
                dc.CommandText = strSqlQuery
                dc.CommandType = CommandType.StoredProcedure
                dc.Parameters.Add("@Sdate", OleDbType.Integer).Value = intExcededDay
            End If


            dc.Connection = con
            con.Open()
            dc.ExecuteNonQuery()

        End Using




    End Sub

End Class
