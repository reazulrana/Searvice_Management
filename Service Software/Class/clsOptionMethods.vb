Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Configuration
Imports System.IO


Public Class clsOptionMethods

    Public Sub Save(ByVal mail As clsOption)

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Using con As OleDbConnection = New OleDbConnection(cs)


            Dim dcMail As OleDbCommand = New OleDbCommand("qryInsertMailSMS", con)
            dcMail.CommandType = CommandType.StoredProcedure
            dcMail.Parameters.Add("Type1", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(mail.type), DBNull.Value, mail.type)
            dcMail.Parameters.Add("MailFrom1", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(mail.MailFrom), DBNull.Value, mail.MailFrom)
            dcMail.Parameters.Add("Crediantial1", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(mail.Crediantial), DBNull.Value, mail.Crediantial)
            dcMail.Parameters.Add("Port1", OleDbType.Integer).Value = If(String.IsNullOrEmpty(mail.Port), DBNull.Value, mail.Port)
            dcMail.Parameters.Add("smtp1", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(mail.SMTP), DBNull.Value, mail.SMTP)
            dcMail.Parameters.Add("SSL1", OleDbType.Boolean).Value = If(String.IsNullOrEmpty(mail.SSL), DBNull.Value, mail.SSL)


            con.Open()
            dcMail.ExecuteNonQuery()
        End Using

    End Sub



    Public Sub Update(ByVal mail As clsOption, MSID As Integer)

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Using con As OleDbConnection = New OleDbConnection(cs)


            Dim dcMail As OleDbCommand = New OleDbCommand("qryUpdateMailSMS", con)
            dcMail.CommandType = CommandType.StoredProcedure
            dcMail.Parameters.Add("Type1", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(mail.type), DBNull.Value, mail.type)
            dcMail.Parameters.Add("MailFrom1", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(mail.MailFrom), DBNull.Value, mail.MailFrom)
            dcMail.Parameters.Add("Crediantial1", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(mail.Crediantial), DBNull.Value, mail.Crediantial)
            dcMail.Parameters.Add("Port1", OleDbType.Integer).Value = If(String.IsNullOrEmpty(mail.Port), DBNull.Value, mail.Port)
            dcMail.Parameters.Add("smtp1", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(mail.SMTP), DBNull.Value, mail.SMTP)
            dcMail.Parameters.Add("SSL1", OleDbType.Boolean).Value = If(String.IsNullOrEmpty(mail.SSL), DBNull.Value, mail.SSL)
            dcMail.Parameters.Add("Active1", OleDbType.Boolean).Value = If(String.IsNullOrEmpty(mail.Active), DBNull.Value, mail.Active)

            dcMail.Parameters.Add("MSID2", OleDbType.Integer, 255).Value = MSID
            con.Open()
            dcMail.ExecuteNonQuery()
        End Using

    End Sub





    Public Sub MakeDefault(ByVal mail As clsOption, MSID As Integer)

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Using con As OleDbConnection = New OleDbConnection(cs)


            Dim dcMail As OleDbCommand = New OleDbCommand("Update MailSMS Set Active=@Active where MSID=@MSID", con)
            dcMail.CommandType = CommandType.Text

            dcMail.Parameters.Add("@Active", OleDbType.Boolean).Value = If(String.IsNullOrEmpty(mail.Active), DBNull.Value, mail.Active)

            dcMail.Parameters.Add("@MSID", OleDbType.Integer, 255).Value = MSID
            con.Open()
            dcMail.ExecuteNonQuery()
        End Using

    End Sub



    Public Sub Delete(ByVal MSID As Integer)

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Using con As OleDbConnection = New OleDbConnection(cs)


            Dim dcMail As OleDbCommand = New OleDbCommand("qryDeleteMailSMS", con)
            dcMail.CommandType = CommandType.StoredProcedure
            dcMail.Parameters.Add("MSID2", OleDbType.Integer, 255).Value = MSID
            con.Open()
            dcMail.ExecuteNonQuery()
        End Using

    End Sub




    Public Function GetMailIDList() As List(Of clsOption)


        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim tempList As List(Of clsOption) = New List(Of clsOption)



        Using con As OleDbConnection = New OleDbConnection(cs)


            Dim dcMailList As OleDbCommand = New OleDbCommand("qryGetMail", con)
            dcMailList.CommandType = CommandType.StoredProcedure
            con.Open()
            Dim drMailList As OleDbDataReader = dcMailList.ExecuteReader

            If drMailList.HasRows = True Then
                While drMailList.Read
                    Dim tempOption As clsOption = New clsOption
                    tempOption.MSID = drMailList("MSID").ToString

                    tempOption.type = drMailList("type").ToString
                    tempOption.SMTP = drMailList("SMTP").ToString
                    tempOption.Port = Integer.Parse(drMailList("Port").ToString)

                    tempOption.MailFrom = drMailList("MailFrom").ToString
                    tempOption.Active = Convert.ToBoolean(drMailList("Active").ToString)
                    tempList.Add(tempOption)
                End While
            End If



        End Using
        Return tempList
    End Function



    Public Function GetMailList_All_Information() As List(Of clsOption)


        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim tempList As List(Of clsOption) = New List(Of clsOption)



        Using con As OleDbConnection = New OleDbConnection(cs)


            Dim dcMailList As OleDbCommand = New OleDbCommand("qryGetMail", con)
            dcMailList.CommandType = CommandType.StoredProcedure
            con.Open()
            Dim drMailList As OleDbDataReader = dcMailList.ExecuteReader

            If drMailList.HasRows = True Then
                While drMailList.Read
                    Dim tempOption As clsOption = New clsOption
                    tempOption.MSID = drMailList("MSID").ToString
                    tempOption.type = drMailList("type").ToString
                    tempOption.MailFrom = drMailList("MailFrom").ToString
                    tempOption.Crediantial = drMailList("Crediantial").ToString
                    tempOption.Port = Integer.Parse(drMailList("Port").ToString)
                    tempOption.SMTP = drMailList("SMTP").ToString
                    tempOption.SSL = Convert.ToBoolean(drMailList("SSL").ToString)
                    tempOption.Active = Convert.ToBoolean(drMailList("Active").ToString)
                    tempList.Add(tempOption)
                End While
            End If



        End Using
        Return tempList
    End Function





    Public Function GetMailBYID(ByVal MSID As Integer) As clsOption


        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString


        Dim tempOption As clsOption = New clsOption

        Using con As OleDbConnection = New OleDbConnection(cs)


            Dim dcMailList As OleDbCommand = New OleDbCommand("Select * from MailSMS where MSID=@MSID", con)
            dcMailList.CommandType = CommandType.Text
            dcMailList.Parameters.Add("@MSID", OleDbType.Integer).Value = MSID
            con.Open()
            Dim drMailList As OleDbDataReader = dcMailList.ExecuteReader

            If drMailList.HasRows = True Then
                While drMailList.Read

                    tempOption.MSID = drMailList("MSID").ToString
                    tempOption.type = drMailList("type").ToString
                    tempOption.MailFrom = drMailList("MailFrom").ToString
                    tempOption.Crediantial = drMailList("Crediantial").ToString
                    tempOption.Port = Integer.Parse(drMailList("Port").ToString)
                    tempOption.SMTP = drMailList("SMTP").ToString
                    tempOption.SSL = Convert.ToBoolean(drMailList("SSL").ToString)
                    tempOption.Active = Convert.ToBoolean(drMailList("Active").ToString)

                End While
            End If



        End Using
        Return tempOption
    End Function






    Public Function GetActiveMail() As clsOption


        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString


        Dim tempOption As clsOption = New clsOption

        Using con As OleDbConnection = New OleDbConnection(cs)


            Dim dcMailList As OleDbCommand = New OleDbCommand("Select * from MailSMS where Active=@Active", con)
            dcMailList.CommandType = CommandType.Text
            dcMailList.Parameters.Add("@Active", OleDbType.Boolean).Value = True
            con.Open()
            Dim drMailList As OleDbDataReader = dcMailList.ExecuteReader

            If drMailList.HasRows = True Then
                While drMailList.Read

                    tempOption.MSID = drMailList("MSID").ToString
                    tempOption.type = drMailList("type").ToString
                    tempOption.MailFrom = drMailList("MailFrom").ToString
                    tempOption.Crediantial = drMailList("Crediantial").ToString
                    tempOption.Port = Integer.Parse(drMailList("Port").ToString)
                    tempOption.SMTP = drMailList("SMTP").ToString
                    tempOption.SSL = Convert.ToBoolean(drMailList("SSL").ToString)
                    tempOption.Active = Convert.ToBoolean(drMailList("Active").ToString)

                End While
            End If



        End Using
        Return tempOption
    End Function


    Public Sub DisableMail()


        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString


        Dim tempOption As clsOption = New clsOption

        Using con As OleDbConnection = New OleDbConnection(cs)


            Dim dcMailList As OleDbCommand = New OleDbCommand("update MailSMS set Active=@Active where Active=@Active2", con)
            dcMailList.CommandType = CommandType.Text
            dcMailList.Parameters.Add("@Active", OleDbType.Boolean).Value = False
            dcMailList.Parameters.Add("@Active", OleDbType.Boolean).Value = True
            con.Open()
            dcMailList.ExecuteNonQuery()

        End Using

    End Sub



    Public Function IsMailActive() As Boolean


        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Dim blnFlag As Boolean = False

        Dim tempOption As clsOption = New clsOption

        Try



            Using con As OleDbConnection = New OleDbConnection(cs)


                Dim dcMailList As OleDbCommand = New OleDbCommand("Select * from MailSMS where Active=true", con)
                dcMailList.CommandType = CommandType.Text

                con.Open()
                Dim drExist As OleDbDataReader = dcMailList.ExecuteReader
                If drExist.HasRows = True Then
                    blnFlag = True


                End If

            End Using
        Catch ex As Exception
            blnFlag = False

        End Try


        Return blnFlag



    End Function



    Public Function IsExistMail() As Boolean


        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString


        Dim tempOption As clsOption = New clsOption

        Using con As OleDbConnection = New OleDbConnection(cs)


            Dim dcMailList As OleDbCommand = New OleDbCommand("Select * from MailSMS", con)
            dcMailList.CommandType = CommandType.Text

            con.Open()
            Dim drExist As OleDbDataReader = dcMailList.ExecuteReader
            If drExist.HasRows = True Then
                Return True


            End If

        End Using
        Return False



    End Function



End Class
