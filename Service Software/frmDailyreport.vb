Imports System.Configuration
Imports System.Data.OleDb

Public Class frmDailyreport
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles optMail.CheckedChanged
        grpMail.Visible = True


    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles optSMS.CheckedChanged
        grpMail.Visible = False
    End Sub

    Private Sub frmDailyreport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterForm(Me)
        LoadBranch()
        GetDefaultBranch()

        optMail.Checked = True
        optGmail.Checked = True
        optSummery.Checked = True
    End Sub


    Private Sub GetDefaultBranch()
        Try

            lblBranchName.Text = My.Computer.Registry.CurrentUser.OpenSubKey("Software\Company Software\Service").GetValue("Default_Branch")
            cmbBranch.Text = My.Computer.Registry.CurrentUser.OpenSubKey("Software\Company Software\Service").GetValue("Default_Branch")
        Catch ex As Exception

        End Try




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Try

            If optMail.Checked Then
                If optSummery.Checked = True Then
                    SendMailSummery()
                End If
            End If


        Catch ex As Exception
            MessageBox.Show(ex.StackTrace, ex.Message.ToString)

        End Try




    End Sub


    Private Sub SendMailSummery()
        Dim Security As clsSecurity = New clsSecurity
        Dim mail As clsMail = New clsMail
        Dim MailMethods As clsNetwork = New clsNetwork



        If MailMethods.isInternet = False Then
            MessageBox.Show("Internet is disconnected")
            Exit Sub
        End If


        If MailMethods.VerifyMail(txtSender.Text) = False Then
            MessageBox.Show("Invalid Sending Mail")
            txtSender.Select()
            Exit Sub
        End If


        If MailMethods.VerifyMail(txtReceiver.Text) = False Then
            MessageBox.Show("Invalid Receiving Mail")
            txtReceiver.Select()
            Exit Sub
        End If

        If optGmail.Checked = True Then
            mail.PORT = 587
            mail.SMTP = "smtp.gmail.com"
            mail.SSL = True

        ElseIf optYahoo.Checked = True Then
            mail.PORT = 587
            mail.SMTP = "smtp.mail.yahoo.com"
            mail.SSL = True
        ElseIf optHotmail.Checked = True Then
            mail.PORT = 25
            mail.SMTP = "smtp.live.com"
            mail.SSL = True
        End If

        mail.From = Security.Encrypt(txtSender.Text)
        mail.MailID = Security.Encrypt(txtSender.Text)
        mail.MailTo = txtReceiver.Text
        mail.Password = Security.Encrypt(txtPassword.Text)
        mail.Subject = "Daily Report From " & dtpFrom.Value.ToShortDateString & " To " & dtpTo.Value.ToShortDateString

        mail.Body = GetDailyMail()

        MailMethods.SendMail(mail)



    End Sub



    Private Function GetDailyMail() As String
        Dim strValus As String = String.Empty

        strValus = "Receive : (Wating for Service)" & vbNewLine
        strValus += Receive(dtpFrom.Value.ToShortDateString, dtpTo.Value.ToShortDateString)
        strValus += "Repaired : (Service+NR)" & vbNewLine & vbNewLine
        strValus += Repaired(dtpFrom.Value.ToShortDateString, dtpTo.Value.ToShortDateString)
        strValus += "Repaired Others: (Pending+Service Replace)" & vbNewLine & vbNewLine
        strValus += RepairedOthers(dtpFrom.Value.ToShortDateString, dtpTo.Value.ToShortDateString)

        strValus += "Delivery Others: (Delivery Replace)" & vbNewLine & vbNewLine
        strValus += DeliveryOthsers(dtpFrom.Value.ToShortDateString, dtpTo.Value.ToShortDateString)
        strValus += "Delivery Others: (Delivery Replace)" & vbNewLine & vbNewLine

        strValus += "Delivery :" & vbNewLine & vbNewLine
        strValus += Delivery(dtpFrom.Value.ToShortDateString, dtpTo.Value.ToShortDateString)
        strValus += "Cashsales :" & vbNewLine & vbNewLine
        strValus += "Cashsales Amount :" & vbTab & vbTab & Cashsales().ToString

        Return strValus
    End Function

    Private Function Cashsales() As Double
        Dim CashsaleMethods As clsCashsalesMethods = New clsCashsalesMethods

        Dim dblAMount As Double = CashsaleMethods.GetCashsalesNetTotalAmount("Cashsales.ReceptDate Between #" & dtpFrom.Value.ToShortDateString & "# AND #" & dtpTo.Value.ToShortDateString & "# AND Branch='" & lblBranchName.Text & "'")


        Return dblAMount


    End Function

    Private Function Receive(ByVal dtStartDate As DateTime, ByVal dtEndate As DateTime) As String

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim strQuery As String = "Select iif(Claiminfo.ServiceType='CTV','CTV',iif(Claiminfo.ServiceType='LCD' or Claiminfo.ServiceType='LED' ,'LCD',iif(Claiminfo.ServiceType='HIFI','HIFI',iif(Claiminfo.ServiceType='CCD','CCD','Others')))) as Category, count(Claiminfo.JobCode) as Qty from Claiminfo where Claiminfo.ReceptDate Between @StartDate and @EndDate and Branch=@Branch group by  iif(Claiminfo.ServiceType='CTV','CTV',iif(Claiminfo.ServiceType='LCD' or Claiminfo.ServiceType='LED' ,'LCD',iif(Claiminfo.ServiceType='HIFI','HIFI',iif(Claiminfo.ServiceType='CCD','CCD','Others')))) "
        Dim strValue As String = String.Empty


        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcGetReceive As OleDbCommand = New OleDbCommand(strQuery, con)

            dcGetReceive.Parameters.Add("@StartDate", OleDbType.Date).Value = dtStartDate
            dcGetReceive.Parameters.Add("@EndDate", OleDbType.Date).Value = dtEndate
            dcGetReceive.Parameters.Add("@Branch", OleDbType.Char, 255).Value = lblBranchName.Text

            con.Open()


            Dim drGetReceive As OleDbDataReader = dcGetReceive.ExecuteReader

            If drGetReceive.HasRows = True Then

                While drGetReceive.Read
                    strValue += vbTab & vbTab & drGetReceive("Category").ToString & vbTab & drGetReceive("Qty").ToString & vbNewLine
                End While


            End If



        End Using



        Return strValue

    End Function



    Private Function Repaired(ByVal dtStartDate As DateTime, ByVal dtEndate As DateTime) As String

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim strQuery As String = "Select iif(Claiminfo.ServiceType='CTV','CTV',iif(Claiminfo.ServiceType='LCD' or Claiminfo.ServiceType='LED' ,'LCD',iif(Claiminfo.ServiceType='HIFI','HIFI',iif(Claiminfo.ServiceType='CCD','CCD','Others')))) as Category, count(Claiminfo.JobCode) as Qty from Claiminfo where Claiminfo.Sdate Between @StartDate and @EndDate and Branch=@Branch And Claiminfo.Cflag in(1,99) group by  iif(Claiminfo.ServiceType='CTV','CTV',iif(Claiminfo.ServiceType='LCD' or Claiminfo.ServiceType='LED' ,'LCD',iif(Claiminfo.ServiceType='HIFI','HIFI',iif(Claiminfo.ServiceType='CCD','CCD','Others')))) "
        Dim strValue As String = String.Empty


        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcGetReceive As OleDbCommand = New OleDbCommand(strQuery, con)

            dcGetReceive.Parameters.Add("@StartDate", OleDbType.Date).Value = dtStartDate
            dcGetReceive.Parameters.Add("@EndDate", OleDbType.Date).Value = dtEndate
            dcGetReceive.Parameters.Add("@Branch", OleDbType.Char, 255).Value = lblBranchName.Text

            con.Open()


            Dim drGetReceive As OleDbDataReader = dcGetReceive.ExecuteReader

            If drGetReceive.HasRows = True Then

                While drGetReceive.Read
                    strValue += vbTab & vbTab & drGetReceive("Category").ToString & vbTab & drGetReceive("Qty").ToString & vbNewLine
                End While


            End If



        End Using



        Return strValue

    End Function





    Private Function Delivery(ByVal dtStartDate As DateTime, ByVal dtEndate As DateTime) As String

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim strQuery As String = "Select iif(Claiminfo.ServiceType='CTV','CTV',iif(Claiminfo.ServiceType='LCD' or Claiminfo.ServiceType='LED' ,'LCD',iif(Claiminfo.ServiceType='HIFI','HIFI',iif(Claiminfo.ServiceType='CCD','CCD','Others')))) as Category, count(Claiminfo.JobCode) as Qty, (sum(Claiminfo.PrdAmt+Claiminfo.SvAmt+Claiminfo.OtherAmt+Claiminfo.VatAmnt)- sum(Claiminfo.Dis+Claiminfo.AdvanceAmnt)) as Total from Claiminfo where Claiminfo.Ddate Between @StartDate and @EndDate and Branch=@Branch And Claiminfo.Cflag in(0,2,100) group by  iif(Claiminfo.ServiceType='CTV','CTV',iif(Claiminfo.ServiceType='LCD' or Claiminfo.ServiceType='LED' ,'LCD',iif(Claiminfo.ServiceType='HIFI','HIFI',iif(Claiminfo.ServiceType='CCD','CCD','Others')))) "
        Dim strValue As String = String.Empty

        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcGetReceive As OleDbCommand = New OleDbCommand(strQuery, con)

            dcGetReceive.Parameters.Add("@StartDate", OleDbType.Date).Value = dtStartDate
            dcGetReceive.Parameters.Add("@EndDate", OleDbType.Date).Value = dtEndate
            dcGetReceive.Parameters.Add("@Branch", OleDbType.Char, 255).Value = lblBranchName.Text
            Dim dblAmount As Double

            con.Open()


            Dim drGetReceive As OleDbDataReader = dcGetReceive.ExecuteReader

            If drGetReceive.HasRows = True Then

                While drGetReceive.Read
                    strValue += vbTab & vbTab & drGetReceive("Category").ToString & vbTab & vbTab & drGetReceive("Qty").ToString & vbTab & drGetReceive("Total").ToString & vbNewLine
                    dblAmount += Double.Parse(drGetReceive("Total").ToString)

                End While

                strValue += vbTab & vbTab & "Total Amount :" & vbTab & (dblAmount + Cashsales()) & vbNewLine
            End If



        End Using



        Return strValue

    End Function








    Private Function RepairedOthers(ByVal dtStartDate As DateTime, ByVal dtEndate As DateTime) As String

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim strQuery As String = "Select iif(Claiminfo.ServiceType='CTV','CTV',iif(Claiminfo.ServiceType='LCD' or Claiminfo.ServiceType='LED' ,'LCD',iif(Claiminfo.ServiceType='HIFI','HIFI',iif(Claiminfo.ServiceType='CCD','CCD','Others')))) as Category, count(Claiminfo.JobCode) as Qty from Claiminfo where Claiminfo.Sdate Between @StartDate and @EndDate and Branch=@Branch And Claiminfo.Cflag in(9,101) group by  iif(Claiminfo.ServiceType='CTV','CTV',iif(Claiminfo.ServiceType='LCD' or Claiminfo.ServiceType='LED' ,'LCD',iif(Claiminfo.ServiceType='HIFI','HIFI',iif(Claiminfo.ServiceType='CCD','CCD','Others')))) "
        Dim strValue As String = String.Empty


        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcGetReceive As OleDbCommand = New OleDbCommand(strQuery, con)

            dcGetReceive.Parameters.Add("@StartDate", OleDbType.Date).Value = dtStartDate
            dcGetReceive.Parameters.Add("@EndDate", OleDbType.Date).Value = dtEndate
            dcGetReceive.Parameters.Add("@Branch", OleDbType.Char, 255).Value = lblBranchName.Text

            con.Open()


            Dim drGetReceive As OleDbDataReader = dcGetReceive.ExecuteReader

            If drGetReceive.HasRows = True Then

                While drGetReceive.Read
                    strValue += vbTab & vbTab & drGetReceive("Category").ToString & vbTab & drGetReceive("Qty").ToString & vbNewLine
                End While


            End If



        End Using



        Return strValue

    End Function





    Private Function DeliveryOthsers(ByVal dtStartDate As DateTime, ByVal dtEndate As DateTime) As String

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim strQuery As String = "Select iif(Claiminfo.ServiceType='CTV','CTV',iif(Claiminfo.ServiceType='LCD' or Claiminfo.ServiceType='LED' ,'LCD',iif(Claiminfo.ServiceType='HIFI','HIFI',iif(Claiminfo.ServiceType='CCD','CCD','Others')))) as Category, count(Claiminfo.JobCode) as Qty from Claiminfo where Claiminfo.Ddate Between @StartDate and @EndDate and Branch=@Branch And Claiminfo.Cflag in(102) group by  iif(Claiminfo.ServiceType='CTV','CTV',iif(Claiminfo.ServiceType='LCD' or Claiminfo.ServiceType='LED' ,'LCD',iif(Claiminfo.ServiceType='HIFI','HIFI',iif(Claiminfo.ServiceType='CCD','CCD','Others')))) "
        Dim strValue As String = String.Empty

        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcGetReceive As OleDbCommand = New OleDbCommand(strQuery, con)

            dcGetReceive.Parameters.Add("@StartDate", OleDbType.Date).Value = dtStartDate
            dcGetReceive.Parameters.Add("@EndDate", OleDbType.Date).Value = dtEndate
            dcGetReceive.Parameters.Add("@Branch", OleDbType.Char, 255).Value = lblBranchName.Text

            con.Open()


            Dim drGetReceive As OleDbDataReader = dcGetReceive.ExecuteReader

            If drGetReceive.HasRows = True Then

                While drGetReceive.Read
                    strValue += vbTab & vbTab & drGetReceive("Category").ToString & vbTab & drGetReceive("Qty").ToString & vbNewLine
                End While


            End If



        End Using



        Return strValue

    End Function




    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        Me.Dispose()

    End Sub

    Private Sub cmbBranch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBranch.SelectedIndexChanged
        Dim BranchMethods As clsBranchMethods = New clsBranchMethods



        If cmbBranch.Text.Length > 0 Then
            If BranchMethods.Isexist(cmbBranch.Text) = False Then
                MessageBox.Show("Branch not Fount")
                Exit Sub
            End If
            lblBranchName.Text = cmbBranch.Text

        End If

    End Sub


    Private Sub LoadBranch()
        Dim branchMethods As clsBranchMethods = New clsBranchMethods
        Dim ListBranch As List(Of clsBranch) = branchMethods.GetOpenBranches.ToList


        cmbBranch.Items.Clear()

        If ListBranch.Count > 0 Then

            For Each Branch As clsBranch In ListBranch
                cmbBranch.Items.Add(Branch.Branch)
            Next

        End If

    End Sub


End Class