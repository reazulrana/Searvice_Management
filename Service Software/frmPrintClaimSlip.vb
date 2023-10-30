Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions
Imports System.Drawing.Printing




Public Class frmPrintClaimSlip


    Public strPrinJob As String = String.Empty
    Public JobBill As clsJobJobBill = New clsJobJobBill


    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()



    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()

    End Sub

    Private Sub optAll_CheckedChanged(sender As Object, e As EventArgs) Handles optAll.CheckedChanged
        ClearBoldOptionButtnon()

        optAll.Font = New Font(optAll.Font.Name, 9, FontStyle.Bold)





    End Sub

    Private Sub ClearBoldOptionButtnon()
        optAll.Font = New Font(optAll.Font.Name, 9, FontStyle.Regular)
        optClaimSlip.Font = New Font(optClaimSlip.Font.Name, 9, FontStyle.Regular)
        optJobSlip1.Font = New Font(optJobSlip1.Font.Name, 9, FontStyle.Regular)
        optJobSlip2.Font = New Font(optJobSlip2.Font.Name, 9, FontStyle.Regular)



    End Sub




    Private Sub frmPrintClaimSlip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterForm(Me)
        ClearBoldOptionButtnon()

        If Double.TryParse(JobBill.TechnicalCharge, txtServiceCharge.Text) = False Then
            txtServiceCharge.Text = Integer.Parse("0")
        End If



    End Sub

    Private Sub optClaimSlip_CheckedChanged(sender As Object, e As EventArgs) Handles optClaimSlip.CheckedChanged
        ClearBoldOptionButtnon()

        optClaimSlip.Font = New Font(optClaimSlip.Font.Name, 9, FontStyle.Bold)

    End Sub

    Private Sub optJobSlip1_CheckedChanged(sender As Object, e As EventArgs) Handles optJobSlip1.CheckedChanged
        ClearBoldOptionButtnon()

        optJobSlip1.Font = New Font(optJobSlip1.Font.Name, 9, FontStyle.Bold)
    End Sub

    Private Sub optJobSlip2_CheckedChanged(sender As Object, e As EventArgs) Handles optJobSlip2.CheckedChanged
        ClearBoldOptionButtnon()

        optJobSlip2.Font = New Font(optJobSlip2.Font.Name, 9, FontStyle.Bold)
    End Sub

    Private Sub txtServiceCharge_TextChanged(sender As Object, e As EventArgs) Handles txtServiceCharge.TextChanged

    End Sub

    Private Sub txtServiceCharge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtServiceCharge.KeyPress


        If Not IsNumeric(e.KeyChar) Then
            If Not (e.KeyChar = Convert.ToChar(Keys.Back) Or e.KeyChar = Convert.ToChar(Keys.Delete)) Then
                e.Handled = True
            End If


        End If
    End Sub

    Private Sub txtTransportCharge_TextChanged(sender As Object, e As EventArgs) Handles txtTransportCharge.TextChanged

    End Sub

    Private Sub txtTransportCharge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTransportCharge.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            If Not (e.KeyChar = Convert.ToChar(Keys.Back) Or e.KeyChar = Convert.ToChar(Keys.Delete)) Then
                e.Handled = True
            End If


        End If
    End Sub

    Private Sub txtAdvance_TextChanged(sender As Object, e As EventArgs) Handles txtAdvance.TextChanged

    End Sub

    Private Sub txtAdvance_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAdvance.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            If Not (e.KeyChar = Convert.ToChar(Keys.Back) Or e.KeyChar = Convert.ToChar(Keys.Delete)) Then
                e.Handled = True
            End If


        End If
    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        'Dim slipreport As rptClaimSlip = New rptClaimSlip
        'Dim Printer As PrinterSettings = New PrinterSettings
        'slipreport.PrintOptions.PrinterName = Printer.PrinterName
        'slipreport.PrintToPrinter(1, False, 0, 0)
        Dim dblTechCharge As Double = Double.Parse("0") 'Technical Charge
        Dim dblTransportationCharge As Double = Double.Parse("0")   'Transportation Charge
        Dim dblAdvanceCharge As Double = Double.Parse("0") 'Advance Amount


        If Double.TryParse(txtServiceCharge.Text, dblTechCharge) = False Then
            dblTechCharge = Double.Parse("0")
        End If


        If Double.TryParse(txtTransportCharge.Text, dblTransportationCharge) = False Then
            dblTransportationCharge = Double.Parse("0")
        End If

        If Double.TryParse(txtAdvance.Text, dblAdvanceCharge) = False Then
            dblAdvanceCharge = Double.Parse("0")
        End If




        JobBill.TechnicalCharge = dblTechCharge
        JobBill.TransportationCharge = dblTransportationCharge
        JobBill.Advance = dblAdvanceCharge

        If optAll.Checked = True Then
            PrintClaimSlip()
            PrintClaimSlipParts()
            PrintClaimSlipParts1()
        End If
        If optClaimSlip.Checked = True Then
            PrintClaimSlip()
        End If
        If optJobSlip1.Checked = True Then
            PrintClaimSlipParts()
        End If
        If optJobSlip2.Checked = True Then
            PrintClaimSlipParts1()
        End If


        ' _____________________If it is enabled then you can see preview of the report in report viewer _________________________

        'Dim ShowReport As New frmReportShow

        'ReportIdentification = UCase("ClaimSlip")
        'ShowReport.strClaimSlipJobCode = strPrinJob
        'ShowReport.JobBill.TechnicalCharge = dblTechCharge
        'ShowReport.JobBill.TransportationCharge = dblTransportationCharge
        'ShowReport.JobBill.Advance = dblAdvanceCharge
        'ShowReport.ShowDialog()

    End Sub


    Private Sub PrintClaimSlip()
        Dim claimSlip As New rptClaimSlip
        Dim printer As PrinterSettings = New PrinterSettings
        Try

            Dim claiminfomethods As clsClaiminfoMethods = New clsClaiminfoMethods

            Dim claiminfo As clsClaiminfo = claiminfomethods.LoadClaiminfo_byJobCode(strPrinJob)


            If Not IsNothing(claiminfo.Jobcode) Then


                '   __________________________ Load Customer Claim Class ______________________________________
                Dim csClaimMethods As clsCustomerClaimMethods = New clsCustomerClaimMethods
                Dim csclaim As clsCustomerClaim = csClaimMethods.GetCustomerClaim(claiminfo.Jobcode)

                '   __________________________ Load Branch Class ______________________________________
                Dim branchMethods As clsBranchMethods = New clsBranchMethods
                Dim branch As clsBranch = branchMethods.VerifyBranch(claiminfo.Branch)

                '   __________________________ Load Service Item ______________________________________
                Dim ServiceItemMethods As clsServiceItemMethods = New clsServiceItemMethods
                Dim serviceitem As clsServiceItem = ServiceItemMethods.GetItem(claiminfo.Jobcode)
                '   __________________________ Load Employe Information ______________________________________
                Dim empmethods As clsPersonalMethods = New clsPersonalMethods
                Dim emp As List(Of clsPersonal) = empmethods.LoadTechnician(claiminfo.ReceptBy).ToList



                With claimSlip


                    'Claiminfo Section
                    DirectCast(.ReportDefinition.ReportObjects("txtJobCode"), TextObject).Text = "Job No : " & claiminfo.Branch.Substring(0, 3) & claiminfo.Jobcode
                    DirectCast(.ReportDefinition.ReportObjects("txtCustomerName"), TextObject).Text = claiminfo.CustName
                    DirectCast(.ReportDefinition.ReportObjects("txtCustomerAddress"), TextObject).Text = claiminfo.CustAddress1
                    DirectCast(.ReportDefinition.ReportObjects("txtCustomerContact"), TextObject).Text = claiminfo.CustAddress2
                    DirectCast(.ReportDefinition.ReportObjects("txtCustomerEmail"), TextObject).Text = claiminfo.Email
                    DirectCast(.ReportDefinition.ReportObjects("txtCategory"), TextObject).Text = claiminfo.ServiceType
                    DirectCast(.ReportDefinition.ReportObjects("txtBrand"), TextObject).Text = claiminfo.Brand
                    DirectCast(.ReportDefinition.ReportObjects("txtModel"), TextObject).Text = claiminfo.ModelNo
                    DirectCast(.ReportDefinition.ReportObjects("txtSerial"), TextObject).Text = claiminfo.SLNo
                    DirectCast(.ReportDefinition.ReportObjects("txtReceiveDate"), TextObject).Text = claiminfo.ReceptDate
                    DirectCast(.ReportDefinition.ReportObjects("txtDelDTApprox"), TextObject).Text = claiminfo.AppDelDate
                    DirectCast(.ReportDefinition.ReportObjects("txtPhysicalCondition"), TextObject).Text = claiminfo.PhyCond
                    DirectCast(.ReportDefinition.ReportObjects("txtTechnicalCharge"), TextObject).Text = JobBill.TechnicalCharge
                    DirectCast(.ReportDefinition.ReportObjects("txtTransportCharge"), TextObject).Text = JobBill.TransportationCharge
                    DirectCast(.ReportDefinition.ReportObjects("txtAdvance"), TextObject).Text = JobBill.Advance



                    If emp.Count > 0 Then
                        For Each employee As clsPersonal In emp
                            DirectCast(.ReportDefinition.ReportObjects("txtReceivedby"), TextObject).Text = employee.EmpName
                        Next

                    End If
                    DirectCast(.ReportDefinition.ReportObjects("txtReturnedItem"), TextObject).Text = claiminfo.ReturnedItems
                    DirectCast(.ReportDefinition.ReportObjects("txtDeliverdPerson"), TextObject).Text = claiminfo.CustName

                    If claiminfo.WCondition = Integer.Parse("0") Then
                        DirectCast(.ReportDefinition.ReportObjects("txtWarrantyType"), TextObject).Text = "Warranty"
                        DirectCast(.ReportDefinition.ReportObjects("txtWarrantyStatus"), TextObject).Text = "Date of Purchase: " & claiminfo.PDate

                    ElseIf claiminfo.WCondition = Integer.Parse("1") Then
                        DirectCast(.ReportDefinition.ReportObjects("txtWarrantyType"), TextObject).Text = "Non-Warranty"
                        DirectCast(.ReportDefinition.ReportObjects("txtWarrantyStatus"), TextObject).Text = "ON-Payment: "

                    Else
                        DirectCast(.ReportDefinition.ReportObjects("txtWarrantyType"), TextObject).Text = "Svc-Warranty"
                    End If


                    'Service Item Section
                    If Not IsNothing(serviceitem.JobCode) Then
                        DirectCast(.ReportDefinition.ReportObjects("txtAccessoies"), TextObject).Text = serviceitem.Item
                    End If


                    'Branch Section
                    If Not IsNothing(branch.Branch) Then

                        DirectCast(.ReportDefinition.ReportObjects("txtReceiveAt"), TextObject).Text = branch.Branch
                        DirectCast(.ReportDefinition.ReportObjects("txtBranchAddress"), TextObject).Text = branch.Address


                        If Not String.IsNullOrEmpty(branch.phone) Then
                            DirectCast(.ReportDefinition.ReportObjects("txtPhone"), TextObject).Text = branch.phone
                        End If

                        If Not String.IsNullOrEmpty(branch.OfficeTime) Then
                            DirectCast(.ReportDefinition.ReportObjects("txtOfficeHour"), TextObject).Text = branch.OfficeTime
                        End If
                        If Not String.IsNullOrEmpty(branch.Holiday) Then
                            DirectCast(.ReportDefinition.ReportObjects("txtLeaveDay"), TextObject).Text = branch.Holiday
                        End If


                    End If

                    'Customer Claim Section

                    If Not IsNothing(csclaim.Jobcode) Then
                        DirectCast(.ReportDefinition.ReportObjects("txtFault"), TextObject).Text = Microsoft.VisualBasic.StrConv(csclaim.ClaimCode, VbStrConv.ProperCase)
                    End If
                End With

            End If
            claimSlip.PrintOptions.PrinterName = printer.PrinterName
            claimSlip.PrintToPrinter(1, False, 0, 0)



        Catch exSummary As Exception
            MessageBox.Show(exSummary.Message)
        End Try



    End Sub



    Private Sub PrintClaimSlipParts()
        Dim claimSlip As New rptClaimSlipParts
        Dim printer As PrinterSettings = New PrinterSettings
        Try

            Dim claiminfomethods As clsClaiminfoMethods = New clsClaiminfoMethods

            Dim claiminfo As clsClaiminfo = claiminfomethods.LoadClaiminfo_byJobCode(strPrinJob)
            Dim tbGradeMethods As clstbGradeMethods = New clstbGradeMethods
            Dim tbGrade As clstbGrade = New clstbGrade

            If tbGradeMethods.IsExist(strPrinJob) = True Then
                tbGrade = tbGradeMethods.GetCustomerGrade(strPrinJob)
            End If


            If Not IsNothing(claiminfo.Jobcode) Then


                '   __________________________ Load Customer Claim Class ______________________________________
                Dim csClaimMethods As clsCustomerClaimMethods = New clsCustomerClaimMethods
                Dim csclaim As clsCustomerClaim = csClaimMethods.GetCustomerClaim(claiminfo.Jobcode)

                '   __________________________ Load Branch Class ______________________________________
                Dim branchMethods As clsBranchMethods = New clsBranchMethods
                Dim branch As clsBranch = branchMethods.VerifyBranch(claiminfo.Branch)

                '   __________________________ Load Service Item ______________________________________
                Dim ServiceItemMethods As clsServiceItemMethods = New clsServiceItemMethods
                Dim serviceitem As clsServiceItem = ServiceItemMethods.GetItem(claiminfo.Jobcode)




                With claimSlip


                    'Claiminfo Section
                    DirectCast(.ReportDefinition.ReportObjects("txtJobCode"), TextObject).Text = "Job No : " & claiminfo.Jobcode
                    DirectCast(.ReportDefinition.ReportObjects("txtCustomerName"), TextObject).Text = claiminfo.CustName
                    DirectCast(.ReportDefinition.ReportObjects("txtCustomerAddress"), TextObject).Text = claiminfo.CustAddress1
                    If Not tbGrade Is Nothing Then
                        If Not String.IsNullOrEmpty(tbGrade.cRemarks) Then
                            DirectCast(.ReportDefinition.ReportObjects("txtReferences"), TextObject).Text = tbGrade.cRemarks 'claiminfo.CustAddress2
                        End If

                    End If

                    ' DirectCast(.ReportDefinition.ReportObjects("txtCustomerEmail"), TextObject).Text = "" 'claiminfo.Email
                    DirectCast(.ReportDefinition.ReportObjects("txtCategory"), TextObject).Text = claiminfo.ServiceType
                    DirectCast(.ReportDefinition.ReportObjects("txtBrand"), TextObject).Text = claiminfo.Brand
                    DirectCast(.ReportDefinition.ReportObjects("txtModel"), TextObject).Text = claiminfo.ModelNo
                    DirectCast(.ReportDefinition.ReportObjects("txtSerial"), TextObject).Text = claiminfo.SLNo
                    DirectCast(.ReportDefinition.ReportObjects("txtReceiveDate"), TextObject).Text = claiminfo.ReceptDate
                    DirectCast(.ReportDefinition.ReportObjects("txtDelDTApprox"), TextObject).Text = claiminfo.AppDelDate

                    DirectCast(.ReportDefinition.ReportObjects("txtPhysicalCondition"), TextObject).Text = claiminfo.PhyCond


                    ' _____________________________________ Product Charge Section ______________________________________________

                    'DirectCast(.ReportDefinition.ReportObjects("txtTechnicalCharge"), TextObject).Text = JobBill.TechnicalCharge
                    'DirectCast(.ReportDefinition.ReportObjects("txtTransportCharge"), TextObject).Text = JobBill.TransportationCharge
                    'DirectCast(.ReportDefinition.ReportObjects("txtAdvance"), TextObject).Text = JobBill.Advance



                    DirectCast(.ReportDefinition.ReportObjects("txtReturnedItem"), TextObject).Text = claiminfo.ReturnedItems
                    DirectCast(.ReportDefinition.ReportObjects("txtCustomerNameSignature"), TextObject).Text = claiminfo.CustName

                    If claiminfo.WCondition = Integer.Parse("0") Then
                        DirectCast(.ReportDefinition.ReportObjects("txtWarrantyType"), TextObject).Text = "Warranty"
                        DirectCast(.ReportDefinition.ReportObjects("txtWarrantyStatus"), TextObject).Text = "Date of Purchase: " & claiminfo.PDate

                    ElseIf claiminfo.WCondition = Integer.Parse("1") Then
                        DirectCast(.ReportDefinition.ReportObjects("txtWarrantyType"), TextObject).Text = "Non-Warranty"
                        DirectCast(.ReportDefinition.ReportObjects("txtWarrantyStatus"), TextObject).Text = "ON-Payment"

                    Else
                        DirectCast(.ReportDefinition.ReportObjects("txtWarrantyType"), TextObject).Text = "Svc-Warranty"
                    End If


                    'Service Item Section
                    If Not IsNothing(serviceitem.JobCode) Then
                        DirectCast(.ReportDefinition.ReportObjects("txtAccessoies"), TextObject).Text = serviceitem.Item
                    End If


                    'Branch Section
                    If Not IsNothing(branch.Branch) Then

                        DirectCast(.ReportDefinition.ReportObjects("txtReceiveAt"), TextObject).Text = branch.Branch
                        DirectCast(.ReportDefinition.ReportObjects("txtAddress"), TextObject).Text = branch.Address

                        If Not String.IsNullOrEmpty(branch.phone) Then
                            DirectCast(.ReportDefinition.ReportObjects("txtPhone"), TextObject).Text = branch.phone
                        End If

                        If Not String.IsNullOrEmpty(branch.OfficeTime) Then
                            DirectCast(.ReportDefinition.ReportObjects("txtOfficeHour"), TextObject).Text = branch.OfficeTime
                        End If
                        If Not String.IsNullOrEmpty(branch.Holiday) Then
                            DirectCast(.ReportDefinition.ReportObjects("txtLeaveDay"), TextObject).Text = branch.Holiday
                        End If


                    End If

                    'Customer Claim Section

                    If Not IsNothing(csclaim.Jobcode) Then
                        DirectCast(.ReportDefinition.ReportObjects("txtFault"), TextObject).Text = Microsoft.VisualBasic.StrConv(csclaim.ClaimCode, VbStrConv.ProperCase)
                    End If
                End With

            End If
            claimSlip.PrintOptions.PrinterName = printer.PrinterName
            claimSlip.PrintToPrinter(1, False, 0, 0)



        Catch exSummary As Exception
            MessageBox.Show(exSummary.Message)
        End Try



    End Sub



    Private Sub PrintClaimSlipParts1()
        Dim claimSlip As New rptClaimSlipParts1
        Dim printer As PrinterSettings = New PrinterSettings
        Try

            Dim claiminfomethods As clsClaiminfoMethods = New clsClaiminfoMethods

            Dim claiminfo As clsClaiminfo = claiminfomethods.LoadClaiminfo_byJobCode(strPrinJob)
            Dim tbGradeMethods As clstbGradeMethods = New clstbGradeMethods
            Dim tbGrade As clstbGrade = New clstbGrade

            If tbGradeMethods.IsExist(strPrinJob) = True Then
                tbGrade = tbGradeMethods.GetCustomerGrade(strPrinJob)
            End If

            If Not IsNothing(claiminfo.Jobcode) Then


                '   __________________________ Load Customer Claim Class ______________________________________
                Dim csClaimMethods As clsCustomerClaimMethods = New clsCustomerClaimMethods
                Dim csclaim As clsCustomerClaim = csClaimMethods.GetCustomerClaim(claiminfo.Jobcode)

                '   __________________________ Load Branch Class ______________________________________
                Dim branchMethods As clsBranchMethods = New clsBranchMethods
                Dim branch As clsBranch = branchMethods.VerifyBranch(claiminfo.Branch)

                '   __________________________ Load Service Item ______________________________________
                Dim ServiceItemMethods As clsServiceItemMethods = New clsServiceItemMethods
                Dim serviceitem As clsServiceItem = ServiceItemMethods.GetItem(claiminfo.Jobcode)




                With claimSlip


                    'Claiminfo Section
                    DirectCast(.ReportDefinition.ReportObjects("txtJobCode"), TextObject).Text = "Job No : " & claiminfo.Jobcode
                    DirectCast(.ReportDefinition.ReportObjects("txtCustomerName"), TextObject).Text = claiminfo.CustName
                    DirectCast(.ReportDefinition.ReportObjects("txtCustomerAddress"), TextObject).Text = claiminfo.CustAddress1
                    If Not tbGrade Is Nothing Then
                        If Not String.IsNullOrEmpty(tbGrade.cRemarks) Then
                            DirectCast(.ReportDefinition.ReportObjects("txtReferences"), TextObject).Text = tbGrade.cRemarks 'claiminfo.CustAddress2
                        End If

                    End If
                    ' DirectCast(.ReportDefinition.ReportObjects("txtCustomerEmail"), TextObject).Text = claiminfo.Email
                    DirectCast(.ReportDefinition.ReportObjects("txtCategory"), TextObject).Text = claiminfo.ServiceType
                    DirectCast(.ReportDefinition.ReportObjects("txtBrand"), TextObject).Text = claiminfo.Brand
                    DirectCast(.ReportDefinition.ReportObjects("txtModel"), TextObject).Text = claiminfo.ModelNo
                    DirectCast(.ReportDefinition.ReportObjects("txtSerial"), TextObject).Text = claiminfo.SLNo
                    DirectCast(.ReportDefinition.ReportObjects("txtReceiveDate"), TextObject).Text = claiminfo.ReceptDate
                    DirectCast(.ReportDefinition.ReportObjects("txtDelDTApprox"), TextObject).Text = claiminfo.AppDelDate
                    DirectCast(.ReportDefinition.ReportObjects("txtPhysicalCondition"), TextObject).Text = claiminfo.PhyCond
                    ' _____________________________________ Product Charge Section ______________________________________________
                    'DirectCast(.ReportDefinition.ReportObjects("txtTechnicalCharge"), TextObject).Text = JobBill.TechnicalCharge
                    'DirectCast(.ReportDefinition.ReportObjects("txtTransportCharge"), TextObject).Text = JobBill.TransportationCharge
                    'DirectCast(.ReportDefinition.ReportObjects("txtAdvance"), TextObject).Text = JobBill.Advance





                    If claiminfo.WCondition = Integer.Parse("0") Then
                        DirectCast(.ReportDefinition.ReportObjects("txtWarrantyType"), TextObject).Text = "Warranty"
                        DirectCast(.ReportDefinition.ReportObjects("txtWarrantyStatus"), TextObject).Text = "Date of Purchase: " & claiminfo.PDate

                    ElseIf claiminfo.WCondition = Integer.Parse("1") Then
                        DirectCast(.ReportDefinition.ReportObjects("txtWarrantyType"), TextObject).Text = "Non-Warranty"
                        DirectCast(.ReportDefinition.ReportObjects("txtWarrantyStatus"), TextObject).Text = "ON-Payment"

                    Else
                        DirectCast(.ReportDefinition.ReportObjects("txtWarrantyType"), TextObject).Text = "Svc-Warranty"
                    End If


                    'Service Item Section
                    If Not IsNothing(serviceitem.JobCode) Then
                        DirectCast(.ReportDefinition.ReportObjects("txtAccessoies"), TextObject).Text = serviceitem.Item
                    End If


                    'Branch Section
                    If Not IsNothing(branch.Branch) Then

                        DirectCast(.ReportDefinition.ReportObjects("txtReceiveAt"), TextObject).Text = branch.Branch
                        DirectCast(.ReportDefinition.ReportObjects("txtAddress"), TextObject).Text = branch.Address

                        If Not String.IsNullOrEmpty(branch.phone) Then
                            DirectCast(.ReportDefinition.ReportObjects("txtPhone"), TextObject).Text = branch.phone
                        End If

                        If Not String.IsNullOrEmpty(branch.OfficeTime) Then
                            DirectCast(.ReportDefinition.ReportObjects("txtOfficeHour"), TextObject).Text = branch.OfficeTime
                        End If
                        If Not String.IsNullOrEmpty(branch.Holiday) Then
                            DirectCast(.ReportDefinition.ReportObjects("txtLeaveDay"), TextObject).Text = branch.Holiday
                        End If


                    End If

                    'Customer Claim Section

                    If Not IsNothing(csclaim.Jobcode) Then
                        DirectCast(.ReportDefinition.ReportObjects("txtFault"), TextObject).Text = DirectCast(.ReportDefinition.ReportObjects("txtFault"), TextObject).Text = Microsoft.VisualBasic.StrConv(csclaim.ClaimCode, VbStrConv.ProperCase)
                    End If
                End With

            End If
            claimSlip.PrintOptions.PrinterName = printer.PrinterName
            claimSlip.PrintToPrinter(1, False, 0, 0)



        Catch exSummary As Exception
            MessageBox.Show(exSummary.Message)
        End Try



    End Sub

    Private Sub lblHeader_Click(sender As Object, e As EventArgs) Handles lblHeader.Click

    End Sub

    Private Sub lblHeader_MouseDown(sender As Object, e As MouseEventArgs) Handles lblHeader.MouseDown
        ReleaseCapture()
        SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
    End Sub

    Private Sub frmPrintClaimSlip_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        ReleaseCapture()
        SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
    End Sub
End Class