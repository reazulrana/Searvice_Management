Imports System
Imports System.Data.OleDb
Imports System.Configuration


Public Class frmOption

    Public strTabName As String = String.Empty


    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()

    End Sub




    Private Sub LoadComapnyList()
        Dim ConCompanyList As New OleDbConnection(strProvider)

        Dim drCompanylist As OleDbDataReader = Nothing

        Dim lstTempLoadList As ListViewItem = Nothing


        LoadAllInformation(ConCompanyList, drCompanylist, strProvider, "CompanyInformation", "CompanyName,OwnerName,Address,ContactNo,Department,TotalStaff,MakeDefault", "''")

        lstCompanylist.Items.Clear()

        Try


            If drCompanylist.HasRows = True Then
                While drCompanylist.Read
                    lstTempLoadList = lstCompanylist.Items.Add(lstCompanylist.Items.Count + 1)
                    lstTempLoadList.SubItems.Add(drCompanylist("CompanyName").ToString)
                    lstTempLoadList.SubItems.Add(drCompanylist("OwnerName").ToString)
                    lstTempLoadList.SubItems.Add(drCompanylist("Address").ToString)
                    lstTempLoadList.SubItems.Add(drCompanylist("ContactNo").ToString)
                    lstTempLoadList.SubItems.Add(drCompanylist("Department").ToString)
                    lstTempLoadList.SubItems.Add(drCompanylist("TotalStaff").ToString)

                    If UCase(drCompanylist("MakeDefault").ToString) = UCase("Set Default") Then
                        lblDefaultCompanyName.Text = drCompanylist("CompanyName").ToString
                        strCompanyTitle = drCompanylist("CompanyName").ToString
                    End If
                End While
            End If

            ItemSelected()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try




    End Sub


    Private Sub tbComapny_TabIndexChanged(sender As Object, e As EventArgs) Handles tbComapny.TabIndexChanged

    End Sub

    Private Sub frmOption_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            CenterForm(Me)







            If Not IsNothing(ActiveUser) Then
                If Not ActiveUser.UserType.ToLower = LCase("Admin") Then
                    For Each tab As TabPage In tbComapny.TabPages
                        If tab.Text.ToLower = LCase("email/sms") Then
                            tab.Enabled = False
                        End If
                    Next
                End If
            End If

            Dim Mail As clsOptionMethods = New clsOptionMethods

            If Mail.IsExistMail = True Then
                If Mail.IsMailActive = True Then
                    optNone.Checked = True
                Else
                    optNone.Checked = False
                    optSMS.Checked = True
                End If
            Else
                optNone.Checked = False
                optSMS.Checked = True
            End If



            If strTabName.Length > 0 Then
                If strTabName.ToLower = LCase("Mail") Then
                    tbComapny.SelectTab(1)
                End If
            Else
                tbComapny.SelectTab(0)
                tbComapny_Click(sender, e)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Me.Close()
            Me.Dispose()
        End Try

    End Sub

    Private Sub tbComapny_Click(sender As Object, e As EventArgs) Handles tbComapny.Click
        If tbComapny.TabIndex = 0 Then
            LoadComapnyList()
        End If
    End Sub

    Private Sub cmdMakeDefault_Click(sender As Object, e As EventArgs) Handles cmdMakeDefault.Click
        If lstCompanylist.FocusedItem.Selected = True Then
            UpdateRecords("MakeDefault", "''", "CompanyInformation", "CompanyInformation.MakeDefault='Set Default'")
            UpdateRecords("MakeDefault", "'Set Default'", "CompanyInformation", "CompanyInformation.CompanyName='" & lstCompanylist.FocusedItem.SubItems(1).Text & "' and CompanyInformation.Department='" & lstCompanylist.FocusedItem.SubItems(5).Text & "'")
            MsgBox("Default Company Name Set Successfully")
            LoadComapnyList()


        End If
    End Sub


    Private Sub ItemSelected()

        Dim intLoop As Integer = 0
        Dim lstSelectItem As ListViewItem = Nothing


        For intLoop = 0 To lstCompanylist.Items.Count - 1
            lstSelectItem = lstCompanylist.Items(intLoop)

            If lstSelectItem.SubItems(1).Text = lblDefaultCompanyName.Text Then
                lstCompanylist.Select()
                lstSelectItem.Selected = True

                Exit For
            End If

        Next







    End Sub


    Private Sub myAppconfig(ByVal key As String, ByVal value As String)
        Dim con = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        Dim setting = con.AppSettings.Settings


        If IsNothing(setting(key)) Then

            setting.Add(key, value)
        Else

            setting(key).Value = value
        End If
        con.Save(ConfigurationSaveMode.Modified, True)
        ConfigurationManager.RefreshSection("appSettings")
        MessageBox.Show("Update Completed")

        'rana12312344@gmail.com


    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs)




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim con = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        Dim s = con.AppSettings.Settings



        MessageBox.Show(s("gmailaccount").Value)
    End Sub

    Private Sub tbEmailSMS_Click(sender As Object, e As EventArgs) Handles tbEmailSMS.Click

    End Sub

    Private Sub LoadMailSMS()
        Dim optionMethods As clsOptionMethods = New clsOptionMethods
        Dim MailList As List(Of clsOption) = optionMethods.GetMailIDList.ToList
        Dim security As clsSecurity = New clsSecurity

        If MailList.Count > 0 Then

            lstMailList.Items.Clear()

            For Each mail As clsOption In MailList

                Dim lstItem As ListViewItem = New ListViewItem

                lstItem = lstMailList.Items.Add(lstMailList.Items.Count + 1)
                lstItem.SubItems.Add(security.Decrypt(mail.MailFrom))
                lstItem.SubItems.Add(mail.SMTP)
                lstItem.SubItems.Add(mail.Port)
                lstItem.SubItems.Add(mail.type)
                lstItem.SubItems.Add(If(mail.Active = False, "Inactive", "Active"))
                If mail.Active = True Then
                    lstMailList.Select()
                    lstItem.Selected = True
                End If
                lstItem.Tag = mail.MSID




            Next


        End If










    End Sub


    Private Sub tbComapny_Selected(sender As Object, e As TabControlEventArgs) Handles tbComapny.Selected
        If e.TabPageIndex = 1 Then



            LoadMailSMS()
            Dim CheckDefaulMail As clsOption = New clsOption
            Dim optMethods As clsOptionMethods = New clsOptionMethods
            CheckDefaulMail = optMethods.GetActiveMail

            If IsNothing(CheckDefaulMail.MailFrom) Then
                optNone.Checked = True
            ElseIf CheckDefaulMail.type.ToLower = LCase("Mail") Then

                optMail.Checked = True
            ElseIf CheckDefaulMail.type.ToLower = LCase("SMS") Then
                optSMS.Checked = True

            End If



        End If
    End Sub



    Private Sub HideAdvanceOption()
        grpClientInformaion.Visible = False

    End Sub

    Private Sub ShowAdvanceOption()
        grpClientInformaion.Visible = True
    End Sub




    Private Sub Gmailsettings(ByRef SMTP As String, ByRef PORT As Integer, ByRef SSL As Boolean)

        SMTP = "smtp.gmail.com"
        PORT = Integer.Parse("587")
        SSL = True

    End Sub



    Private Sub Yahoosettings(ByRef SMTP As String, ByRef PORT As Integer, ByRef SSL As Boolean)

        SMTP = "smtp.mail.yahoo.com"
        PORT = Integer.Parse("587")  'available port 465 or 587
        SSL = True

    End Sub



    Private Sub HotMailsettings(ByRef SMTP As String, ByRef PORT As Integer, ByRef SSL As Boolean)

        SMTP = "smtp.live.com"
        PORT = Integer.Parse("25")  'available port 25 or 587
        SSL = True

    End Sub

    Private Sub optNone_CheckedChanged(sender As Object, e As EventArgs) Handles optNone.CheckedChanged
        If tbComapny.SelectedTab.TabIndex = 1 Then
            If optNone.Checked = True Then

                grpMailSection.Enabled = False
                grpMailList.Enabled = False
                Dim optMethods As clsOptionMethods = New clsOptionMethods

                optMethods.DisableMail()

            End If
        End If


    End Sub

    Private Sub btnMailClear_Click(sender As Object, e As EventArgs) Handles btnMailClear.Click
        CleareFields()
    End Sub

    Private Sub optMail_CheckedChanged(sender As Object, e As EventArgs) Handles optMail.CheckedChanged
        If tbComapny.SelectedTab.TabIndex = 1 Then
            If optMail.Checked = True Then
                grpMailSection.Enabled = True
                grpMailList.Enabled = True

            End If
        End If

    End Sub
    Private Sub CleareFields()
        txtEmail.Text = String.Empty
        txtPassword.Text = String.Empty
        If grpClientInformaion.Visible = True Then
            txtsmtp.Text = String.Empty
            txtPort.Text = Integer.Parse("0")
            chkssl.Checked = False
        End If
    End Sub
    Private Sub btnMailAdd_Click(sender As Object, e As EventArgs) Handles btnMailAdd.Click
        'myAppconfig("gmailaccount", txtEmail.Text)





        Dim optionmethods As clsOptionMethods = New clsOptionMethods
        Dim Mail As clsOption = New clsOption
        Dim networks As clsNetwork = New clsNetwork
        Dim security As clsSecurity = New clsSecurity

        Dim port As Integer
        Dim smtp As String
        Dim ssl As Boolean




        Try


            If networks.VerifyMail(txtEmail.Text) = True Then
                Mail.MailFrom = security.Encrypt(txtEmail.Text)
            Else
                MessageBox.Show("Email is invalid")
                txtEmail.Select()
                Exit Sub
            End If

            If Not String.IsNullOrEmpty(txtPassword.Text) Then
                Mail.Crediantial = security.Encrypt(txtPassword.Text)
            Else
                MessageBox.Show("Password is blank")
                txtPassword.Select()
                Exit Sub

            End If


            Dim Portno As Integer = 0
            If optCustom.Checked = True Then


                If Integer.Parse(txtPort.Text, Portno) = False Then
                    MessageBox.Show("Invalid Port No")
                    txtPort.Select()
                    Exit Sub
                End If
            End If


            If optGmail.Checked = True Then
                Gmailsettings(smtp, port, ssl)
            End If


            If optYahoo.Checked = True Then
                Gmailsettings(smtp, port, ssl)
            End If


            If optHotMail.Checked = True Then
                Gmailsettings(smtp, port, ssl)
            End If
            Mail.SMTP = smtp
            Mail.Port = port
            Mail.SSL = ssl

            If optCustom.Checked = True Then
                Mail.SMTP = txtsmtp.Text
                Mail.Port = txtPort.Text
                Mail.SSL = If(chkssl.Checked = True, True, False)
            End If


            If optMail.Checked = True Then
                Mail.type = optMail.Text
            Else
                Mail.type = optSMS.Text
            End If



            optionmethods.Save(Mail)

            MessageBox.Show("Mail Saved Successfully")
            LoadMailSMS()
            CleareFields()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub




    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim optionmethods As clsOptionMethods = New clsOptionMethods
        Dim Mail As clsOption = New clsOption
        Dim networks As clsNetwork = New clsNetwork
        Dim security As clsSecurity = New clsSecurity

        Dim port As Integer
        Dim smtp As String
        Dim ssl As Boolean




        Try
            If lstMailList.Items.Count > 0 Then
                If lstMailList.SelectedItems.Count > 0 Then
                    Dim lstitem As ListViewItem = lstMailList.FocusedItem
                    Mail.MSID = lstitem.Tag
                Else
                    MessageBox.Show("MAIL NOT SELECTED")
                    Exit Sub

                End If
            Else
                MessageBox.Show("Mail List Is Blank")
                Exit Sub
            End If

            If networks.VerifyMail(txtEmail.Text) = True Then
                Mail.MailFrom = security.Encrypt(txtEmail.Text)
            Else
                MessageBox.Show("Email is invalid")
                txtEmail.Select()
                Exit Sub
            End If

            If Not String.IsNullOrEmpty(txtPassword.Text) Then
                Mail.Crediantial = security.Encrypt(txtPassword.Text)
            Else
                MessageBox.Show("Password is blank")
                txtPassword.Select()
                Exit Sub

            End If


            Dim Portno As Integer = 0
            If optCustom.Checked = True Then


                If Integer.Parse(txtPort.Text, Portno) = False Then
                    MessageBox.Show("Invalid Port No")
                    txtPort.Select()
                    Exit Sub
                End If
            End If


            If optGmail.Checked = True Then
                Gmailsettings(smtp, port, ssl)
            End If


            If optYahoo.Checked = True Then
                Gmailsettings(smtp, port, ssl)
            End If


            If optHotMail.Checked = True Then
                Gmailsettings(smtp, port, ssl)
            End If
            Mail.SMTP = smtp
            Mail.Port = port
            Mail.SSL = ssl

            If optCustom.Checked = True Then
                Mail.SMTP = txtsmtp.Text
                Mail.Port = txtPort.Text
                Mail.SSL = If(chkssl.Checked = True, True, False)
            End If


            If optMail.Checked = True Then
                Mail.type = optMail.Text
            Else
                Mail.type = optSMS.Text
            End If



            optionmethods.Update(Mail, Mail.MSID)

            MessageBox.Show("Mail Saved Successfully")
            CleareFields()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub




    Private Sub btnMailDelete_Click(sender As Object, e As EventArgs) Handles btnMailDelete.Click
        DeleteMail()
    End Sub

    Private Sub optGmail_CheckedChanged_1(sender As Object, e As EventArgs) Handles optGmail.CheckedChanged
        HideAdvanceOption()
    End Sub

    Private Sub optYahoo_CheckedChanged(sender As Object, e As EventArgs) Handles optYahoo.CheckedChanged
        HideAdvanceOption()
    End Sub

    Private Sub optHotMail_CheckedChanged(sender As Object, e As EventArgs) Handles optHotMail.CheckedChanged
        HideAdvanceOption()
    End Sub

    Private Sub optCustom_CheckedChanged(sender As Object, e As EventArgs) Handles optCustom.CheckedChanged
        ShowAdvanceOption()

    End Sub

    Private Sub optSMS_CheckedChanged(sender As Object, e As EventArgs) Handles optSMS.CheckedChanged
        grpMailSection.Enabled = True
        grpMailList.Enabled = True

    End Sub

    Private Sub btnMailUpdate_Click_1(sender As Object, e As EventArgs) Handles btnMailUpdate.Click
        Dim optionMethods As clsOptionMethods = New clsOptionMethods
        Dim MailUpdate As clsOption = New clsOption
        Try

            optionMethods.DisableMail()

            If lstMailList.Items.Count > 0 Then
                Dim lstItem As ListViewItem = New ListViewItem
                lstItem = lstMailList.FocusedItem


                If lstItem IsNot Nothing Then

                    MailUpdate.Active = True
                    optionMethods.MakeDefault(MailUpdate, lstItem.Tag)
                    MessageBox.Show("Mail is active")
                    LoadMailSMS()
                Else
                    MessageBox.Show("Mail is not selected")
                End If




            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub




    Private Sub tbCompanylist_TabIndexChanged(sender As Object, e As EventArgs) Handles tbCompanylist.TabIndexChanged

    End Sub

    Private Sub tbCompanylist_Click(sender As Object, e As EventArgs) Handles tbCompanylist.Click

    End Sub

    Private Sub tbComapny_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tbComapny.SelectedIndexChanged
        If tbComapny.SelectedTab.TabIndex = 1 Then
            optNone_CheckedChanged(sender, e)
        End If



    End Sub

    Private Sub SetDefaultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetDefaultToolStripMenuItem.Click
        btnMailUpdate_Click_1(sender, e)
    End Sub

    Private Sub lstMailList_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles lstMailList.SelectedIndexChanged

    End Sub

    Private Sub lstMailList_MouseUp(sender As Object, e As MouseEventArgs) Handles lstMailList.MouseUp
        If e.Button = MouseButtons.Right Then
            If lstMailList.Items.Count > 0 Then
                cntxMenu.Enabled = True
            Else
                cntxMenu.Enabled = False
            End If
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        DeleteMail()
    End Sub
    Private Sub DeleteMail()
        If lstMailList.Items.Count > 0 Then
            If lstMailList.SelectedItems.Count > 0 Then
                Dim optMethods As clsOptionMethods = New clsOptionMethods
                Dim lstItem As ListViewItem = lstMailList.FocusedItem
                optMethods.Delete(lstItem.Tag)
                MessageBox.Show("Mail Deleted Successfully")
                LoadMailSMS()
            Else
                MessageBox.Show("Mail Is Not Selected")
                Exit Sub

            End If
        Else
            MessageBox.Show("No Mail Found In the list")
            Exit Sub

        End If
    End Sub
    Private Sub btnMailRefresh_Click(sender As Object, e As EventArgs) Handles btnMailRefresh.Click
        LoadMailSMS()
    End Sub
End Class