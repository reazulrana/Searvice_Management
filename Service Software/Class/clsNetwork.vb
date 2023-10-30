Imports System.Net
Imports System.Net.Mail

Public Class clsNetwork


    Public Function isInternet() As Boolean
        Try

            My.Computer.Network.Ping("www.google.com")
            Return True





        Catch ex As Exception
            Return False
        End Try

    End Function




    Public Sub SendMail(ByVal tmpMail As clsMail, Optional Message As Boolean = False, Optional IsHTMLFormat As Boolean = False)
        Dim decryptCode As clsSecurity = New clsSecurity
        Dim Smtp_Server As New SmtpClient
        Dim e_mail As New MailMessage()
        Dim emailAttachment As Net.Mail.Attachment = Nothing
        Smtp_Server.UseDefaultCredentials = False

        ' Net.NetworkCredential(decryptCode.Decrypt(tmpMail.MailID), decryptCode.Decrypt(tmpMail.Password))

        ' Smtp_Server.Credentials = New Net.NetworkCredential(decryptCode.Decrypt(tmpMail.MailID), decryptCode.Decrypt(tmpMail.Password))
        'NetworkCredential()
        Smtp_Server.Port = tmpMail.PORT
        Smtp_Server.EnableSsl = tmpMail.SSL
        Smtp_Server.Host = tmpMail.SMTP
        e_mail = New MailMessage()
        e_mail.From = New MailAddress(decryptCode.Decrypt(tmpMail.From))
        e_mail.To.Add(tmpMail.MailTo)
        e_mail.Subject = tmpMail.Subject
        e_mail.IsBodyHtml = IsHTMLFormat
        e_mail.Body = tmpMail.Body
        If tmpMail.Attachment <> "" Then
            emailAttachment = New Net.Mail.Attachment(tmpMail.Attachment)
            e_mail.Attachments.Add(emailAttachment)
        End If


        Smtp_Server.Send(e_mail)
        e_mail.Attachments.Clear()

        If Message = True Then
            MsgBox("Mail sent successfully")
        End If

    End Sub








    Public Function VerifyMail(ByVal From As String) As Boolean

        Try


            Dim e_mail As New MailMessage()


            e_mail = New MailMessage()
            e_mail.From = New MailAddress(From)



            Return True


        Catch ex As Exception
            Return False

        End Try

    End Function



End Class
