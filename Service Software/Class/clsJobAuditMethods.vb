Imports System
Imports System.Data.OleDb
Imports System.Configuration



Public Class clsJobAuditMethods



    Public Sub Save(ByVal JobAudit As clsJobAudit)

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Dim strQuery = "Insert into JobAudit(MailNo,Service,NR,ER,Pending,NotIssued,Assigned,WaitingforDelivery) Values(@MailNo,@Service,@NR,@ER,@Pending,@NotIssued,@Assigned,@WaitingforDelivery)"


        Using con As OleDbConnection = New OleDbConnection(cs)

            Dim dcInsert As OleDbCommand = New OleDbCommand(strQuery, con)

            dcInsert.Parameters.Add("@MailNo", OleDbType.Char, 255).Value = If(JobAudit.MailNo.Length = 0, DBNull.Value, JobAudit.MailNo)
            dcInsert.Parameters.Add("@Service", OleDbType.Boolean).Value = JobAudit.Service
            dcInsert.Parameters.Add("@NR", OleDbType.Boolean).Value = JobAudit.NR
            dcInsert.Parameters.Add("@ER", OleDbType.Boolean).Value = JobAudit.ER
            dcInsert.Parameters.Add("@Pending", OleDbType.Boolean).Value = JobAudit.Pending
            dcInsert.Parameters.Add("@NotIssued", OleDbType.Boolean).Value = JobAudit.NotIssued
            dcInsert.Parameters.Add("@Assigned", OleDbType.Boolean).Value = JobAudit.AfterIssue
            dcInsert.Parameters.Add("@WaitingforDelivery", OleDbType.Boolean).Value = JobAudit.WaitingforDelivery
            con.Open()
            dcInsert.ExecuteNonQuery()




        End Using



    End Sub


    Public Sub Update(ByVal JobAudit As clsJobAudit, ByVal UpdateMail As String)
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim strQuery = "Update JobAudit set MailNo=@MailNo,Service=@Service,NR=@NR,ER=@ER,Pending=@Pending,NotIssued=@NotIssued,Assigned=@Assigned,WaitingforDelivery=@WaitingforDelivery  Where  JobAudit.MailNo=@MailNo1"
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim DcUpdate As OleDbCommand = New OleDbCommand(strQuery, con)
            DcUpdate.Parameters.Add("@MailNo", OleDbType.Char, 255).Value = If(JobAudit.MailNo.Length = 0, DBNull.Value, JobAudit.MailNo)
            DcUpdate.Parameters.Add("@Service", OleDbType.Boolean).Value = JobAudit.Service
            DcUpdate.Parameters.Add("@NR", OleDbType.Boolean).Value = JobAudit.NR
            DcUpdate.Parameters.Add("@ER", OleDbType.Boolean).Value = JobAudit.ER
            DcUpdate.Parameters.Add("@Pending", OleDbType.Boolean).Value = JobAudit.Pending
            DcUpdate.Parameters.Add("@NotIssued", OleDbType.Boolean).Value = JobAudit.NotIssued
            DcUpdate.Parameters.Add("@Assigned", OleDbType.Boolean).Value = JobAudit.AfterIssue
            DcUpdate.Parameters.Add("@WaitingforDelivery", OleDbType.Boolean).Value = JobAudit.WaitingforDelivery
            DcUpdate.Parameters.Add("@MailNo1", OleDbType.Char, 255).Value = UpdateMail
            con.Open()
            DcUpdate.ExecuteNonQuery()
        End Using
    End Sub


    Public Sub Delete(ByVal DeleteMail As String)
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim strQuery = "Delete * from JobAudit Where  JobAudit.MailNo=@MailNo1"
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim DcDelete As OleDbCommand = New OleDbCommand(strQuery, con)
            DcDelete.Parameters.Add("@MailNo1", OleDbType.Char,255).Value = DeleteMail
            con.Open()
            DcDelete.ExecuteNonQuery()
        End Using
    End Sub





    Public Function isExist(ByVal MailNo As String) As Boolean
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim strQuery = "Select * from JobAudit Where JobAudit.MailNo=@MailNo1"
        Dim blnFlag As Boolean = False
        Try

            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dcExist As OleDbCommand = New OleDbCommand(strQuery, con)
                dcExist.Parameters.Add("@MailNo1", OleDbType.Char, 255).Value = MailNo
                con.Open()
                Dim drExist As OleDbDataReader = dcExist.ExecuteReader
                If drExist.HasRows = True Then
                    blnFlag = True
                End If
            End Using

        Catch ex As Exception
            blnFlag = False
        End Try
        Return blnFlag
    End Function






    Public ReadOnly Property GetAuditList() As IEnumerable(Of clsJobAudit)
        Get
            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
            Dim lstJobAudit As List(Of clsJobAudit) = New List(Of clsJobAudit)

            Dim strQuery = "Select * from JobAudit"

            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dcExist As OleDbCommand = New OleDbCommand(strQuery, con)
                con.Open()
                Dim drExist As OleDbDataReader = dcExist.ExecuteReader
                If drExist.HasRows = True Then
                    While drExist.Read
                        Dim JobAudit As clsJobAudit = New clsJobAudit

                        JobAudit.MailID = Integer.Parse(drExist("SL").ToString)
                        JobAudit.MailNo = drExist("MailNo").ToString
                        JobAudit.Service = Boolean.Parse(drExist("Service").ToString)
                        JobAudit.NR = Boolean.Parse(drExist("NR").ToString)
                        JobAudit.ER = Boolean.Parse(drExist("ER").ToString)
                        JobAudit.Pending = Boolean.Parse(drExist("Pending").ToString)
                        JobAudit.NotIssued = Boolean.Parse(drExist("NotIssued").ToString)
                        JobAudit.AfterIssue = Boolean.Parse(drExist("Assigned").ToString)
                        JobAudit.WaitingforDelivery = Boolean.Parse(drExist("WaitingforDelivery").ToString)

                        lstJobAudit.Add(JobAudit)
                    End While

                End If
            End Using
            Return lstJobAudit
        End Get
    End Property



    Public ReadOnly Property HasRow() As Boolean
        Get
            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString


            Dim strQuery = "Select * from JobAudit"
            Dim blnFlag As Boolean = False

            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dcExist As OleDbCommand = New OleDbCommand(strQuery, con)
                con.Open()
                Try


                    Dim drExist As OleDbDataReader = dcExist.ExecuteReader
                    If drExist.HasRows = True Then
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
