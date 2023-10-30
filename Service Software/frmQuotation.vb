Imports CrystalDecisions
Imports CrystalDecisions.CrystalReports.Engine

Imports CrystalDecisions.Shared
Imports System
Imports System.IO
Imports System.ComponentModel

Public Class frmQuotation
    Private Sub frmQuotation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterForm(Me)
        optManual.Enabled = True
        LoadBranch()
        loadField()
        optManual.Checked = True



        Dim intCount As Int16 = 0
        cmbVatPercent.Items.Clear()
        For intCount = 0 To 100 Step 5
            cmbVatPercent.Items.Add(intCount)
        Next
    End Sub

    Private Sub optQuickMail_CheckedChanged(sender As Object, e As EventArgs) Handles optQuickMail.CheckedChanged
        txtMailFrom.Enabled = False
        txtPassword.Enabled = False
        optGmail.Checked = False
        optYahoo.Checked = False
        optHotmail.Checked = False
        optCustom.Checked = False
        txtPassword.Text = String.Empty


        grpManual.Enabled = False

    End Sub

    Private Sub optManual_CheckedChanged(sender As Object, e As EventArgs) Handles optManual.CheckedChanged
        txtMailFrom.Enabled = True
        txtPassword.Enabled = True
        txtMailTo.Enabled = True
        grpManual.Enabled = True
        optGmail.Checked = True

    End Sub

    Private Sub btnSendMail_Click(sender As Object, e As EventArgs) Handles btnSendMail.Click
        Dim NewOptionMethods As clsOptionMethods = New clsOptionMethods
        Try
            If optQuickMail.Checked = True Then
                If NewOptionMethods.IsExistMail() = True Then
                    If NewOptionMethods.IsMailActive() = True Then
                        SendQuickMail()
                    Else
                        MessageBox.Show(" You did not 'set Mail' from Mail Option " & vbNewLine & " You Can 'set Mail' from Mail Optio or You Can use 'Manual Option' to Send Mail")
                        Exit Sub
                    End If
                Else
                    MessageBox.Show(" You have to 'Create Mail' from Mail Option" & vbNewLine & " Because 'No Mail' is exist in the database" & vbNewLine & " You Can use Manual Option to Send Mail")
                    Exit Sub
                End If
            ElseIf optManual.Checked = True Then
                SendManualMail()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub





    Private Sub LoadBranch()
        Dim Brm As clsBranchMethods = New clsBranchMethods
        Dim listBr As List(Of clsBranch) = Brm.GetBranches.ToList
        cmbBranch.Items.Clear()
        If listBr.Count > 0 Then
            For Each b As clsBranch In listBr
                cmbBranch.Items.Add(b.Branch)
            Next
        End If

    End Sub

    Private Sub cmbBranch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBranch.SelectedIndexChanged

        txtDelivery.Text = ""
        Dim brm As clsBranchMethods = New clsBranchMethods
        Dim strBranch As clsBranch = brm.GetBranches.Single(Function(x) x.Branch.ToLower = cmbBranch.Text.ToLower)
        txtDelivery.Text = strBranch.Address & " Phone : " & strBranch.phone


    End Sub


    Private Sub loadField()

        txtHeadLine.Text = "In response to your recent query regarding our following Job we are pleased to quote our Spare parts and Service :"
        txtHeadLine.Text = "In response to your recent query regarding our following Job we are pleased to quote our Spare parts and Service :"
        txtDelivery.Text = ""
        txtValidity.Text = "15 (Fifteen) days from the quotation issue date"
        txtCondition.Text = "Job completion will be subject to the availability of the Spare Parts"
        txtDeliveryTime.Text = "2 (Two) Months from the date of Confirmation"
        txtPayment.Text = "Cash/Cheque (After encashment)"
        txtSubject.Text = "Estimated Repair Cost."
        txtRemarks.Text = "Assuring you of our best co-operation and services at all time."

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        txtPassword.Text = String.Empty
        txtMailFrom.Text = String.Empty
        txtMailTo.Text = String.Empty
        Me.Close()
    End Sub

    Private Sub sumTotal()

        Dim dblParts As Double
        Dim dblTechnicalCharcg As Double
        Dim dblVat As Double
        Dim result As Integer

        If Integer.TryParse(txtSpareCost.Text, dblParts) = False Then
            dblParts = Integer.Parse("0")
        End If

        If Integer.TryParse(txtTechnicalCharge.Text, dblTechnicalCharcg) = False Then
            dblTechnicalCharcg = Integer.Parse("0")
        End If
        If Integer.TryParse(txtvat.Text, dblVat) = False Then
            dblVat = Integer.Parse("0")
        End If

        result = dblParts + dblTechnicalCharcg + dblVat
        txtTotalAmount.Text = result.ToString


    End Sub

    Private Sub cmbVatPercent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbVatPercent.SelectedIndexChanged

        Dim intPercentage As Int16


        If Integer.TryParse(cmbVatPercent.Text, intPercentage) = False Then
            intPercentage = 0
        End If

        txtvat.Text = (Convert.ToDouble(txtTechnicalCharge.Text) / 100) * intPercentage

        sumTotal()
    End Sub

    Private Sub txtSpareCost_TextChanged(sender As Object, e As EventArgs) Handles txtSpareCost.TextChanged

    End Sub

    Private Sub txtSpareCost_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSpareCost.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = Convert.ToChar(Keys.Back) Then

            e.Handled = False
        ElseIf e.KeyChar = Convert.ToChar(Keys.Decimal) Then
            e.Handled = False
        Else
            e.Handled = True


        End If
    End Sub

    Private Sub txtTechnicalCharge_TextChanged(sender As Object, e As EventArgs) Handles txtTechnicalCharge.TextChanged

    End Sub

    Private Sub txtTechnicalCharge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTechnicalCharge.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = Convert.ToChar(Keys.Back) Then

            e.Handled = False
        ElseIf e.KeyChar = Convert.ToChar(Keys.Decimal) Then
            e.Handled = False
        Else
            e.Handled = True


        End If
    End Sub

    Private Sub cmbVatPercent_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbVatPercent.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = Convert.ToChar(Keys.Back) Then

            e.Handled = False
        ElseIf e.KeyChar = Convert.ToChar(Keys.Decimal) Then
            e.Handled = False
        Else
            e.Handled = True


        End If
    End Sub


    Private Sub SendQuickMail()
        Dim NewOptionMethods As clsOptionMethods = New clsOptionMethods
        Dim MailSecurity As clsSecurity = New clsSecurity
        Dim NewMailSend As clsNetwork = New clsNetwork
        Dim MailOption As clsOption = New clsOption
        Dim mail As clsMail = New clsMail


        MailOption = NewOptionMethods.GetActiveMail
        mail.MailID = MailOption.MailFrom
        mail.From = MailOption.MailFrom
        mail.MailTo = txtMailTo.Text
        mail.SSL = MailOption.SSL

        mail.Body = "Dear Sir/Madam." & vbNewLine & vbNewLine &
            "Please check the attachment file (Quotation)" & vbNewLine & vbNewLine & "Rangs Electronics Limited"
        mail.Subject = "Quotation"

        mail.SMTP = MailOption.SMTP
        mail.PORT = MailOption.Port
        mail.Password = MailOption.Crediantial
        mail.PORT = MailOption.Port

        mail.Attachment = GetAttachment()

        If mail.Attachment = "" Then
            MessageBox.Show("File Can not Attach to mail Contact with Administrator")
            Exit Sub
        End If

        NewMailSend.SendMail(mail)


    End Sub


    Private Sub SendManualMail()

        Dim MailSecurity As clsSecurity = New clsSecurity
        Dim NewMailSend As clsNetwork = New clsNetwork
        Dim mail As clsMail = New clsMail
        Dim intPort As Integer





        mail.MailID = MailSecurity.Encrypt(txtMailFrom.Text)
        mail.From = MailSecurity.Encrypt(txtMailFrom.Text)
        mail.Password = MailSecurity.Encrypt(txtPassword.Text)
        mail.Subject = "Quotation"
        mail.MailTo = txtMailTo.Text
        mail.Body = "Dear Sir/Madam." & vbNewLine & vbNewLine &
            "Please check the attachment file (Quotation)" & vbNewLine & vbNewLine & "Rangs Electronics Limited"



        If optCustom.Checked = True Then
            If Integer.TryParse(txtPort.Text, intPort) = False Then
                MessageBox.Show("Port No Should be Number")
                txtPort.Select()
                Exit Sub
            End If
        End If

        If optCustom.Checked = True Then
            mail.PORT = txtPort.Text
            mail.SMTP = txtSMTP.Text
            If chkSSL.Checked = True Then
                mail.SSL = True
            Else
                mail.SSL = False
            End If
        ElseIf optGmail.Checked = True Then
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


        mail.Attachment = GetAttachment()
        If mail.Attachment() = "" Then
            MessageBox.Show("File Can not Attach to mail Contact with Administrator")
            Exit Sub
        End If
        NewMailSend.SendMail(mail)


    End Sub
    Private Function GetAttachment() As String






        Dim NewQuotation As rptQuotation = New rptQuotation
        If NewQuotation.IsLoaded() = True Then
            NewQuotation.Dispose()
            NewQuotation = New rptQuotation


        End If


        DirectCast(NewQuotation.ReportDefinition.ReportObjects("txtPrintDate"), TextObject).Text = dtPrintDate.Value.ToShortDateString
        DirectCast(NewQuotation.ReportDefinition.ReportObjects("txtAddress"), TextObject).Text = txtTo.Text
        DirectCast(NewQuotation.ReportDefinition.ReportObjects("txtSubject"), TextObject).Text = txtSubject.Text
        DirectCast(NewQuotation.ReportDefinition.ReportObjects("txtHeadLine"), TextObject).Text = txtHeadLine.Text
        DirectCast(NewQuotation.ReportDefinition.ReportObjects("txtJobNo"), TextObject).Text = txtJobNo.Text
        DirectCast(NewQuotation.ReportDefinition.ReportObjects("txtItem"), TextObject).Text = txtItem.Text
        DirectCast(NewQuotation.ReportDefinition.ReportObjects("txtSpareCost"), TextObject).Text = txtSpareCost.Text & ".00"
        DirectCast(NewQuotation.ReportDefinition.ReportObjects("txtTechnicalCharge"), TextObject).Text = txtTechnicalCharge.Text & ".00"
        DirectCast(NewQuotation.ReportDefinition.ReportObjects("txtVat"), TextObject).Text = txtvat.Text
        DirectCast(NewQuotation.ReportDefinition.ReportObjects("txtVatPercent"), TextObject).Text = cmbVatPercent.Text & "% (Technical Charge)"
        DirectCast(NewQuotation.ReportDefinition.ReportObjects("txtTotalAmount"), TextObject).Text = txtTotalAmount.Text & ".00"
        DirectCast(NewQuotation.ReportDefinition.ReportObjects("txtInword"), TextObject).Text = Spellnumber(txtTotalAmount.Text)
        DirectCast(NewQuotation.ReportDefinition.ReportObjects("txtPayment"), TextObject).Text = txtPayment.Text
        DirectCast(NewQuotation.ReportDefinition.ReportObjects("txtDeliveryPoint"), TextObject).Text = "Rangs Electronics Ltd."
        DirectCast(NewQuotation.ReportDefinition.ReportObjects("txtDelivery2"), TextObject).Text = txtDelivery.Text
        DirectCast(NewQuotation.ReportDefinition.ReportObjects("txtDeliveryTime"), TextObject).Text = txtDeliveryTime.Text
        DirectCast(NewQuotation.ReportDefinition.ReportObjects("txtValidity"), TextObject).Text = txtValidity.Text
        DirectCast(NewQuotation.ReportDefinition.ReportObjects("txtCondition"), TextObject).Text = txtCondition.Text
        DirectCast(NewQuotation.ReportDefinition.ReportObjects("txtRemarks"), TextObject).Text = txtRemarks.Text
        DirectCast(NewQuotation.ReportDefinition.ReportObjects("txtPreparedby"), TextObject).Text = txtPreparedby.Text
        DirectCast(NewQuotation.ReportDefinition.ReportObjects("txtDesignation"), TextObject).Text = txtDesignation.Text


        Dim strJobName As String

        For Each C As String In txtJobNo.Text
            If C = "\" Or C = "/" Or C = "*" Or C = "?" Or C = "<" Or C = ">" Or C = "|" Or C = ":" Then
                strJobName = strJobName & "-"
            Else
                strJobName = strJobName & C
            End If


        Next


        If Not Directory.Exists("C:\Quotation") Then
            Directory.CreateDirectory("C:\Quotation")
        End If
        Dim strFilePath As String = "C:\Quotation\" & strJobName & " - " & Now.Hour.ToString & "-" & Now.Minute.ToString & "-" & Now.Second.ToString & ".pdf"



        NewQuotation.ExportToDisk(ExportFormatType.PortableDocFormat, strFilePath)


        If File.Exists(strFilePath) Then
            Return strFilePath
        End If





        Return ""


    End Function

    Private Sub frmQuotation_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed

    End Sub

    Private Sub frmQuotation_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        txtPassword.Text = String.Empty
        txtMailFrom.Text = String.Empty
        txtMailTo.Text = String.Empty
    End Sub


End Class