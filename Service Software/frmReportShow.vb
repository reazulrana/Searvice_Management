Imports CrystalDecisions
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.OleDb
Imports System.Drawing.Printing
Imports System.Data
Imports System.Configuration




Public Class frmReportShow
    Dim crBillPayment As New rptBillPayment
    Public strSQLCriteria As String
    Public dtStartDate As Date
    Public dtEndDate As Date

    Public blnSalesWarrPrice As Boolean


    'Bill Invoice Section
    Public dtInvoicePartsDetails As DataTable = New DataTable
    Public tbBillFFCinvoice As clstbBill_FFC = New clstbBill_FFC
    Public claiminfoInvoice As clsClaiminfo = New clsClaiminfo
    Public BranchInvoice As clsBranch = New clsBranch
    Public strWarrantyType As String

    '_______________________________________________________________________________________________
    Public ProductInfo As clsClaiminfo = New clsClaiminfo
    Public CashSales As clsCashsales = New clsCashsales
    Public strClaimSlipJobCode As String
    Public DeliveryCashsales As clsCashsales = New clsCashsales
    'Service Charge, Transportation Charge, Advance Amount
    Public JobBill As clsJobJobBill = New clsJobJobBill

    'Transaction DailyReport Section
    Public transClaiminfo As New clsClaiminfo
    Public strBranchName As String = String.Empty
    Public strBrandName As String = String.Empty
    Public strCategory As String = String.Empty


    Public strModel As String = String.Empty

    Private Sub frmReportShow_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed


        crBillPayment.Dispose()




    End Sub

    Private Sub frmReportShow_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        If UCase(ReportIdentification) = UCase("Bill") Then
            BillReportShow()

        ElseIf ReportIdentification.ToUpper = "CashSales".ToUpper Then
            BillReportCashsale()

        ElseIf ReportIdentification.ToLower = LCase("Job Storage") Then
            ProductStorageReport()
        ElseIf ReportIdentification.ToLower = LCase("Job Transfer") Then
            TransferReport()
        ElseIf ReportIdentification.ToLower = LCase("Customer Details") Then
            CustomerDetailsReport()
        ElseIf UCase(ReportIdentification) = UCase("BillPreview") Then

            BillReportPreview()
        ElseIf UCase(ReportIdentification) = UCase("Receive") Then
            ReceiveReportShow()
        ElseIf ReportIdentification.ToUpper = UCase("Repair") Then
            RepairedReportShow()

        ElseIf ReportIdentification.ToUpper = UCase("ReportDiscountDelivered") Then
            DiscountReportDelivered()
        ElseIf ReportIdentification = UCase("Delivery") Then
            DeliveryReportShow()
        ElseIf ReportIdentification.ToUpper = UCase("Not Assign Job") Then
            NotAssignReport()
        ElseIf ReportIdentification.ToUpper = UCase("Pending Repair") Then
            PendingReportShow()
        ElseIf ReportIdentification.ToUpper = UCase("Estimate Refuse") Then
            EstimateRefuseReportShow()
        ElseIf ReportIdentification.ToUpper = UCase("Pending Delivery") Then
            PendingDelivery()
        ElseIf ReportIdentification.ToLower = LCase("Under Process") Then
            UnderProcessJob()
        ElseIf ReportIdentification.ToUpper = UCase("NRCR") Then
            NRCRReportShow()
        ElseIf ReportIdentification.ToUpper = UCase("Parts Consumption Repair") Or ReportIdentification = UCase("Parts Consumption Delivery") Then
            PartsConsumtionReportShow()
        ElseIf ReportIdentification.ToUpper = UCase("Parts Consumption Summery Repair") Or ReportIdentification = UCase("Parts Consumption Summery Delivery") Then
            PartsConsumtionSummeryReportShow()
        ElseIf ReportIdentification = UCase("Technician Performance Details") Then
            TechnicianPerformanceReportShow()

        ElseIf ReportIdentification = UCase("Technician Performance Summery") Then

            TechnicianPerformanceReportSummery()
        ElseIf ReportIdentification = UCase("Technician Performance Time Elapsed") Then
            TechnicianPerformanceReportTimeElapsed()



        ElseIf ReportIdentification = UCase("Receive Summery Category Wise") Or ReportIdentification = UCase("Receive Summery Brand Wise") _
            Or ReportIdentification = UCase("Receive Summery Branch Wise") Or ReportIdentification = UCase("Receive Summery Model Wise") Or
            ReportIdentification = UCase("Repaired Summery Branch Wise") Or ReportIdentification = UCase("Repaired Summery Category Wise") Or
            ReportIdentification = UCase("Repaired Summery Brand Wise") Or ReportIdentification = UCase("Repaired Summery Model Wise") Or ReportIdentification = UCase("Delivered Summery Branch Wise") Or ReportIdentification = UCase("Delivered Summery Category Wise") Or
            ReportIdentification = UCase("Delivered Summery Brand Wise") Or ReportIdentification = UCase("Delivered Summery Model Wise") Then



            ReceiveSummeryReport()
        ElseIf ReportIdentification = UCase("Service Collection Branch") Then
            ReceiveSummeryReport()
        ElseIf ReportIdentification.ToUpper = UCase("ClaimSlip") Then
            ClaimSlipReport()
        ElseIf ReportIdentification.ToUpper = UCase("CashSalesDetails") Then
            CashSalesDetails()
        ElseIf ReportIdentification.ToUpper = UCase("CashSalesSummery") Then
            CashSalesSummery()
        ElseIf ReportIdentification.ToUpper = UCase("TechnicianReport") Then
            TechnicianReport()
        ElseIf ReportIdentification.ToUpper = UCase("DailyTransactionSingleDate") Then
            DailyTransactionSingleDate()
        ElseIf ReportIdentification.ToUpper = UCase("DailyTransactionDateWise") Then
            DailyTransactionDateWise()
        ElseIf ReportIdentification.ToUpper = UCase("PresentStockALL") Then
            PresentStockALL()
        ElseIf ReportIdentification.ToUpper = UCase("PresentStockByDate") Then
            PresentStock()

        End If




    End Sub
    Private Sub CustomerDetailsReport()

        Dim rptCustomerDetails As rptCustomer = New rptCustomer
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim dt As DataTable = New DataTable


        Try

            Dim strSqlQuery As String = "Select Claiminfo.JobCOde,Claiminfo.Branch,Claiminfo.CustName,iif(CLaiminfo.CustAddress1='',Claiminfo.CustAddress2,CLaiminfo.CustAddress1 & Space(2) & Claiminfo.CustAddress2) as CustAddress1, Claiminfo.ServiceType,Claiminfo.Brand,Claiminfo.ModelNo,Claiminfo.SLNO,Claiminfo.ReceptDate, iif(Claiminfo.Wcondition=0,'SW',iif(Claiminfo.Wcondition=0,'NW','SVW')) as Wcondition from Claiminfo where " & strSQLCriteria & " Order by Claiminfo.JobCode"


            DirectCast(rptCustomerDetails.ReportDefinition.ReportObjects("txtReceiveCompanyTitle"), TextObject).Text = strCompanyTitle
            DirectCast(rptCustomerDetails.ReportDefinition.ReportObjects("txtReportTitle"), TextObject).Text = "Customer Information"
            DirectCast(rptCustomerDetails.ReportDefinition.ReportObjects("txtDateFrom"), TextObject).Text = dtStartDate.ToShortDateString
            DirectCast(rptCustomerDetails.ReportDefinition.ReportObjects("txtDateTo"), TextObject).Text = dtEndDate.ToShortDateString
            If strBranchName.Length > 0 Or strBranchName.Trim <> "" Then
                DirectCast(rptCustomerDetails.ReportDefinition.ReportObjects("txtBranch"), TextObject).Text = strBranchName
            Else
                DirectCast(rptCustomerDetails.ReportDefinition.ReportObjects("txtBranch"), TextObject).Text = "ALL"
            End If


            If strCategory.Length > 0 Or strCategory.Trim <> "" Then
                DirectCast(rptCustomerDetails.ReportDefinition.ReportObjects("txtCategory"), TextObject).Text = strCategory
            Else
                DirectCast(rptCustomerDetails.ReportDefinition.ReportObjects("txtCategory"), TextObject).Text = "ALL"
            End If


            If strBrandName.Length > 0 Or strBrandName.Trim <> "" Then
                DirectCast(rptCustomerDetails.ReportDefinition.ReportObjects("txtBRand"), TextObject).Text = strBrandName
            Else
                DirectCast(rptCustomerDetails.ReportDefinition.ReportObjects("txtBRand"), TextObject).Text = "ALL"
            End If



            Using con As OleDbConnection = New OleDbConnection(cs)

                Dim dc As OleDbCommand = New OleDbCommand(strSqlQuery, con)
                con.Open()

                Dim dr As OleDbDataReader = dc.ExecuteReader


                dt.Load(dr)

                rptCustomerDetails.SetDataSource(dt)

                crvReportShow.ReportSource = rptCustomerDetails

                crBillPayment.Refresh()

            End Using


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub ProductStorageReport()
        Dim rptStorage As rptTbStorage = New rptTbStorage

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Try

            Dim strSqlQuery As String = "Select CLaiminfo.JobCode,Claiminfo.ServiceType,Claiminfo.Brand,Claiminfo.ModelNo,CLaiminfo.SLNO,
                                    tbStoregeSET.Location,tbStoregeSET.SendDate,tbStoregeSET.Bin,tbStoregeSET.Remarks,
tbStoregeSET.Branch, iif(Claiminfo.Wcondition=0,'SW',iif(Claiminfo.Wcondition=1,'NW','SVW')) as Wcondition,
iif(Claiminfo.Cflag=-1,'NS',iif(Claiminfo.Cflag=1,'R',iif(Claiminfo.Cflag=9,'P',iif(Claiminfo.Cflag=99,'NR')))) as cflag from Claiminfo inner Join tbStoregeSET on Claiminfo.JobCode=tbStoregeSET.JobCode where " & strSQLCriteria & " Order by Claiminfo.JobCode"

            Dim dt As DataTable = New DataTable

            Using con As OleDbConnection = New OleDbConnection(cs)

                Dim dc As OleDbCommand = New OleDbCommand(strSqlQuery, con)
                con.Open()

                Dim dr As OleDbDataReader = dc.ExecuteReader

                If dr.HasRows = True Then
                    dt.Load(dr)

                End If


            End Using


            DirectCast(rptStorage.ReportDefinition.ReportObjects("txtReceiveCompanyTitle"), TextObject).Text = strCompanyTitle

            DirectCast(rptStorage.ReportDefinition.ReportObjects("txtReportTitle"), TextObject).Text = "Product Storage Report"
            DirectCast(rptStorage.ReportDefinition.ReportObjects("txtDateFrom"), TextObject).Text = dtStartDate.ToShortDateString
            DirectCast(rptStorage.ReportDefinition.ReportObjects("txtDateTo"), TextObject).Text = dtEndDate.ToShortDateString
            If strBranchName.Length > 0 Or strBranchName.Trim <> "" Then
                DirectCast(rptStorage.ReportDefinition.ReportObjects("txtBranch"), TextObject).Text = strBranchName
            Else
                DirectCast(rptStorage.ReportDefinition.ReportObjects("txtBranch"), TextObject).Text = "ALL"
            End If


            If strCategory.Length > 0 Or strCategory.Trim <> "" Then
                DirectCast(rptStorage.ReportDefinition.ReportObjects("txtCategory"), TextObject).Text = strCategory
            Else
                DirectCast(rptStorage.ReportDefinition.ReportObjects("txtCategory"), TextObject).Text = "ALL"
            End If


            If strBrandName.Length > 0 Or strBrandName.Trim <> "" Then
                DirectCast(rptStorage.ReportDefinition.ReportObjects("txtBRand"), TextObject).Text = strBrandName
            Else
                DirectCast(rptStorage.ReportDefinition.ReportObjects("txtBRand"), TextObject).Text = "ALL"
            End If





            rptStorage.SetDataSource(dt)

            crvReportShow.ReportSource = rptStorage

            crBillPayment.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub





    Private Sub TransferReport()
        Dim rptTReport As rptTransfer = New rptTransfer

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Try

            Dim strSqlQuery As String = "Select CLaiminfo.JobCode,Claiminfo.ServiceType,Claiminfo.Brand,Claiminfo.ModelNo,CLaiminfo.SLNO,
                                    TransferJob.TransferFrom,TransferJob.TransferTo,TransferJob.Remarks,TransferJob.TRDate,
( '(' & TransferJob.TRByCode & ')' & space(2) & TransferJob.TrbyName) as TrbyName, iif(Claiminfo.Wcondition=0,'SW',iif(Claiminfo.Wcondition=1,'NW','SVW')) as Wcondition,
iif(Claiminfo.Cflag=-1,'NS',iif(Claiminfo.Cflag=1,'R',iif(Claiminfo.Cflag=9,'P',iif(Claiminfo.Cflag=99,'NR')))) as cflag from Claiminfo inner Join TransferJob on Claiminfo.JobCode=TransferJob.JobCode where " & strSQLCriteria & " Order by Claiminfo.JobCode"

            Dim dt As DataTable = New DataTable

            Using con As OleDbConnection = New OleDbConnection(cs)

                Dim dc As OleDbCommand = New OleDbCommand(strSqlQuery, con)
                con.Open()

                Dim dr As OleDbDataReader = dc.ExecuteReader

                If dr.HasRows = True Then
                    dt.Load(dr)

                End If


            End Using


            DirectCast(rptTReport.ReportDefinition.ReportObjects("txtReceiveCompanyTitle"), TextObject).Text = strCompanyTitle

            DirectCast(rptTReport.ReportDefinition.ReportObjects("txtReportTitle"), TextObject).Text = "Job Transfer Report"
            DirectCast(rptTReport.ReportDefinition.ReportObjects("txtDateFrom"), TextObject).Text = dtStartDate.ToShortDateString
            DirectCast(rptTReport.ReportDefinition.ReportObjects("txtDateTo"), TextObject).Text = dtEndDate.ToShortDateString
            If strBranchName.Length > 0 Or strBranchName.Trim <> "" Then
                DirectCast(rptTReport.ReportDefinition.ReportObjects("txtBranch"), TextObject).Text = strBranchName
            Else
                DirectCast(rptTReport.ReportDefinition.ReportObjects("txtBranch"), TextObject).Text = "ALL"
            End If


            If strCategory.Length > 0 Or strCategory.Trim <> "" Then
                DirectCast(rptTReport.ReportDefinition.ReportObjects("txtCategory"), TextObject).Text = strCategory
            Else
                DirectCast(rptTReport.ReportDefinition.ReportObjects("txtCategory"), TextObject).Text = "ALL"
            End If


            If strBrandName.Length > 0 Or strBrandName.Trim <> "" Then
                DirectCast(rptTReport.ReportDefinition.ReportObjects("txtBRand"), TextObject).Text = strBrandName
            Else
                DirectCast(rptTReport.ReportDefinition.ReportObjects("txtBRand"), TextObject).Text = "ALL"
            End If





            rptTReport.SetDataSource(dt)

            crvReportShow.ReportSource = rptTReport

            crBillPayment.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub
    Private Sub UnderProcessJob()
        Dim rptUprocess As rptUnderProcess = New rptUnderProcess
        Dim dt As DataTable = New DataTable

        Try

            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

            Dim strSqlQuery As String = "Select Claiminfo.JobCode,Claiminfo.Branch,Claiminfo.ServiceType,Claiminfo.Brand,Claiminfo.ModelNo,Claiminfo.ReceptDate,Claiminfo.IsssueDate as Sdate,(now()-Claiminfo.IsssueDate) as TimeElapse,(  CLaiminfo.Issueto  & space(2) & Personal.EmpName) as Issueto, iif(CLaiminfo.Wcondition=0,'SW',iif(Claiminfo.Wcondition=1,'NW','SVW')) as Wcondition from Claiminfo left Join Personal on Claiminfo.Issueto=Personal.EmpCode where (not isnull(CLaiminfo.Issueto) or CLaiminfo.Issueto<>'')  AND " & strSQLCriteria & " order by Claiminfo.JobCode, Claiminfo.Isssuedate"
            Using con As OleDbConnection = New OleDbConnection(cs)

                Dim dc As OleDbCommand = New OleDbCommand(strSqlQuery, con)

                con.Open()
                Dim dr As OleDbDataReader = dc.ExecuteReader
                If dr.HasRows = True Then
                    dt.Load(dr)
                End If



                DirectCast(rptUprocess.ReportDefinition.ReportObjects("txtReceiveCompanyTitle"), TextObject).Text = strCompanyTitle
                DirectCast(rptUprocess.ReportDefinition.ReportObjects("txtReportTitle"), TextObject).Text = "Job Under Process"
                DirectCast(rptUprocess.ReportDefinition.ReportObjects("txtDateFrom"), TextObject).Text = dtStartDate.ToShortDateString
                DirectCast(rptUprocess.ReportDefinition.ReportObjects("txtDateTo"), TextObject).Text = dtEndDate.ToShortDateString
                If strBranchName.Length > 0 Or strBranchName.Trim <> "" Then
                    DirectCast(rptUprocess.ReportDefinition.ReportObjects("txtBranch"), TextObject).Text = strBranchName
                Else
                    DirectCast(rptUprocess.ReportDefinition.ReportObjects("txtBranch"), TextObject).Text = "ALL"
                End If


                If strCategory.Length > 0 Or strCategory.Trim <> "" Then
                    DirectCast(rptUprocess.ReportDefinition.ReportObjects("txtCategory"), TextObject).Text = strCategory
                Else
                    DirectCast(rptUprocess.ReportDefinition.ReportObjects("txtCategory"), TextObject).Text = "ALL"
                End If


                If strBrandName.Length > 0 Or strBrandName.Trim <> "" Then
                    DirectCast(rptUprocess.ReportDefinition.ReportObjects("txtBRand"), TextObject).Text = strBrandName
                Else
                    DirectCast(rptUprocess.ReportDefinition.ReportObjects("txtBRand"), TextObject).Text = "ALL"
                End If





                rptUprocess.SetDataSource(dt)

                crvReportShow.ReportSource = rptUprocess

                crBillPayment.Refresh()


            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub NotAssignReport()
        Try

            Dim rptNAssignt As rptNotAssigned = New rptNotAssigned

            Dim dt As DataTable = New DataTable
            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

            Dim strSqlQuery As String = "Select Claiminfo.JobCode,Claiminfo.Branch,Claiminfo.ServiceType,Claiminfo.Brand,Claiminfo.ModelNo,Claiminfo.SLNO,Claiminfo.ReceptDate,int(Now()-Claiminfo.ReceptDate) as ElapseTime, Personal.EmpName as ReceiveBy,iif(CLaiminfo.Wcondition=0,'SW',iif(Claiminfo.Wcondition=1,'P','SVW')) as Wcondition from Claiminfo Left Join Personal on Claiminfo.ReceptBy=Personal.EmpCode where  isnull(Claiminfo.Issueto) or Claiminfo.Issueto='' and " & strSQLCriteria & "  Order by Claiminfo.JobCode"

            Using con As OleDbConnection = New OleDbConnection(cs)


                Dim dcGetNotAssignd As OleDbCommand = New OleDbCommand(strSqlQuery, con)

                con.Open()

                Dim drNotAssigned As OleDbDataReader = dcGetNotAssignd.ExecuteReader

                dt.Load(drNotAssigned)

                DirectCast(rptNAssignt.ReportDefinition.ReportObjects("txtReceiveCompanyTitle"), TextObject).Text = strCompanyTitle
                DirectCast(rptNAssignt.ReportDefinition.ReportObjects("txtReportTitle"), TextObject).Text = "Job Assigned Report"
                DirectCast(rptNAssignt.ReportDefinition.ReportObjects("txtDateFrom"), TextObject).Text = dtStartDate.ToShortDateString
                DirectCast(rptNAssignt.ReportDefinition.ReportObjects("txtDateTo"), TextObject).Text = dtEndDate.ToShortDateString
                If strBranchName.Length > 0 Or strBranchName.Trim <> "" Then
                    DirectCast(rptNAssignt.ReportDefinition.ReportObjects("txtBranch"), TextObject).Text = strBranchName
                Else
                    DirectCast(rptNAssignt.ReportDefinition.ReportObjects("txtBranch"), TextObject).Text = "ALL"
                End If


                If strCategory.Length > 0 Or strCategory.Trim <> "" Then
                    DirectCast(rptNAssignt.ReportDefinition.ReportObjects("txtCategory"), TextObject).Text = strCategory
                Else
                    DirectCast(rptNAssignt.ReportDefinition.ReportObjects("txtCategory"), TextObject).Text = "ALL"
                End If


                If strBrandName.Length > 0 Or strBrandName.Trim <> "" Then
                    DirectCast(rptNAssignt.ReportDefinition.ReportObjects("txtBRand"), TextObject).Text = strBrandName
                Else
                    DirectCast(rptNAssignt.ReportDefinition.ReportObjects("txtBRand"), TextObject).Text = "ALL"
                End If




                rptNAssignt.SetDataSource(dt)

                crvReportShow.ReportSource = rptNAssignt

                crBillPayment.Refresh()


            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub





    Private Sub DiscountReportDelivered()
        Dim ReportDiscount As rptDiscount = New rptDiscount
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim dt As DataTable = New DataTable
        Dim strsqlQuery As String = "Select Claiminfo.JobCOde,Claiminfo.Branch,Claiminfo.CustName,tbGrade.cGrade,Claiminfo.DDate,Claiminfo.ServiceType,Claiminfo.Brand,Claiminfo.Modelno,Claiminfo.Dis as Discount,((Claiminfo.PrdAmt+Claiminfo.SvAmt+Claiminfo.Otheramt+CLaiminfo.VatAmnt)- (Claiminfo.Dis+Claiminfo.AdvanceAmnt)) as NetTotal,(Claiminfo.PrdAmt+Claiminfo.SvAmt+Claiminfo.Otheramt) as TotalAmnt, Claiminfo.Wcondition,Claiminfo.Cflag ,Claiminfo.AdvanceAmnt from Claiminfo left join tbGrade on CLaiminfo.JobCode=tbGrade.JobCode where Claiminfo.Dis>0 AND " & strSQLCriteria

        Try



            Using con As OleDbConnection = New OleDbConnection(cs)

                Dim dcGetDiscount As OleDbCommand = New OleDbCommand(strsqlQuery, con)
                con.Open()
                Dim drGetDiscount As OleDbDataReader = dcGetDiscount.ExecuteReader


                If drGetDiscount.HasRows = True Then
                    dt.Load(drGetDiscount)
                End If

            End Using



            If dt.Rows.Count > 0 Then


                DirectCast(ReportDiscount.ReportDefinition.ReportObjects("txtReceiveCompanyTitle"), TextObject).Text = strCompanyTitle
                DirectCast(ReportDiscount.ReportDefinition.ReportObjects("txtReportTitle"), TextObject).Text = "Discount Report (On Delivered)"
                DirectCast(ReportDiscount.ReportDefinition.ReportObjects("txtDateFrom"), TextObject).Text = dtStartDate.ToShortDateString
                DirectCast(ReportDiscount.ReportDefinition.ReportObjects("txtDateTo"), TextObject).Text = dtEndDate.ToShortDateString
                If strBranchName.Length > 0 Or strBranchName.Trim <> "" Then
                    DirectCast(ReportDiscount.ReportDefinition.ReportObjects("txtBranch"), TextObject).Text = strBranchName
                Else
                    DirectCast(ReportDiscount.ReportDefinition.ReportObjects("txtBranch"), TextObject).Text = "ALL"
                End If


                If strCategory.Length > 0 Or strCategory.Trim <> "" Then
                    DirectCast(ReportDiscount.ReportDefinition.ReportObjects("txtCategory"), TextObject).Text = strCategory
                Else
                    DirectCast(ReportDiscount.ReportDefinition.ReportObjects("txtCategory"), TextObject).Text = "ALL"
                End If


                If strBrandName.Length > 0 Or strBrandName.Trim <> "" Then
                    DirectCast(ReportDiscount.ReportDefinition.ReportObjects("txtBRand"), TextObject).Text = strBrandName
                Else
                    DirectCast(ReportDiscount.ReportDefinition.ReportObjects("txtBRand"), TextObject).Text = "ALL"
                End If






                ReportDiscount.SetDataSource(dt)
                crvReportShow.ReportSource = ReportDiscount

                crBillPayment.Refresh()

            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub





    Private Sub GetMaxBillNo(ByRef intTempBillNo As Integer)

        Dim drMaxBillNo As OleDbDataReader = Nothing
        Dim conGetMaxValue As New OleDbConnection(strProvider)

        LoadAllInformation(conGetMaxValue, drMaxBillNo, strProvider, "tbBill", "MAx(tbBill.BillNO) as MaxNo", "''")

        If drMaxBillNo.HasRows = True Then
            While drMaxBillNo.Read
                intTempBillNo = Convert.ToString(Convert.ToInt32(drMaxBillNo("Maxno").ToString) + 1)

            End While
        Else
            intTempBillNo = "1"

        End If

        TempConnectionDispose(conGetMaxValue)

    End Sub


    Private Sub GetAmountValue()

        ' Calculate Product Amount from Data Table
        'Dim dblAmount As Double = 0
        'If dtInvoicePartsDetails.Rows.Count > 0 Then
        '    For Each dw As DataRow In dtInvoicePartsDetails.Rows
        '        dblAmount += dw(3) * dw(4)
        '    Next

        'End If

        'crBillPayment.DataDefinition.FormulaFields("FNTotalPartsAmount").Text = dblAmount

        crBillPayment.DataDefinition.FormulaFields("FNTotalPartsAmount").Text = "'" & Convert.ToDouble(tbBillFFCinvoice.PrdAmt.ToString) & "'"
        crBillPayment.DataDefinition.FormulaFields("fnFaultFindingCharge").Text = "'" & tbBillFFCinvoice.FaultCharge.ToString & "'"
        crBillPayment.DataDefinition.FormulaFields("fnServiceCharge").Text = "'" & tbBillFFCinvoice.ServiceCharge & "'"
        crBillPayment.DataDefinition.FormulaFields("fnOtherCharges").Text = "'" & tbBillFFCinvoice.OtherAmt.ToString & "'"
        crBillPayment.DataDefinition.FormulaFields("fnAdjustment").Text = "'" & tbBillFFCinvoice.Dis.ToString & "'"
        crBillPayment.DataDefinition.FormulaFields("fnAdvance").Text = "'" & tbBillFFCinvoice.AdvanceAmnt.ToString & "'"
        crBillPayment.DataDefinition.FormulaFields("fnVAT").Text = "'" & tbBillFFCinvoice.VatAmnt.ToString & "'"


        crBillPayment.DataDefinition.FormulaFields("fnTotalAmount").Text = Convert.ToInt32(tbBillFFCinvoice.PrdAmt + tbBillFFCinvoice.FaultCharge + tbBillFFCinvoice.ServiceCharge + tbBillFFCinvoice.OtherAmt + tbBillFFCinvoice.VatAmnt - (tbBillFFCinvoice.Dis + tbBillFFCinvoice.AdvanceAmnt))




    End Sub


    Private Sub CountBillPrint()

        InsertNewRecord(strProvider, "rptHowTimeBillPrint", "JobNo,BillNo", "'" & strtmpJobCode & "','" & DirectCast(crBillPayment.ReportDefinition.ReportObjects("txtBillNo"), TextObject).Text & "'")

        Dim drCountInvoicePrint As OleDbDataReader = Nothing
        Dim conLoadCountBillPrint As New OleDbConnection(strProvider)

        LoadAllInformation(conLoadCountBillPrint, drCountInvoicePrint, strProvider, "rptHowTimeBillPrint", "count(rptHowTimeBillPrint.Billno) as TotalPrint", "rptHowTimeBillPrint.JobNo='" & publicClaiminfo.Jobcode.ToString & "' and rptHowTimeBillPrint.BillNo='" & DirectCast(crBillPayment.ReportDefinition.ReportObjects("txtBillNo"), TextObject).Text & "'")
        If drCountInvoicePrint.HasRows = True Then
            While drCountInvoicePrint.Read
                crBillPayment.DataDefinition.FormulaFields("fnPrintCount").Text = "'" & drCountInvoicePrint("TotalPrint").ToString & " - Time Print'"
            End While
        End If


        TempConnectionDispose(conLoadCountBillPrint)
    End Sub


    Private Sub BillReportPreview()






        Dim TempdsBillPayment As New dsBillPayment
        Dim ConBillPayment As New OleDbConnection(strProvider)




        Dim strSQLBillInformation As String = String.Empty
        Dim strPartsInformation As String = String.Empty
        Dim tbBillMethods As clsTBBillMethods = New clsTBBillMethods

        ' Dim getBillNumber As Integer

        Dim drLoadCustomerInformation As OleDbDataReader = Nothing
        Dim BillClass As clstbBill = New clstbBill
        Dim CreateNewBill As clstbBill = New clstbBill

        strtmpJobCode = publicClaiminfo.Jobcode
        Try





            'If tbBillMethods.ISEXIST(publicClaiminfo.Jobcode) = False Then

            '    If tbBillMethods.IsTableEmpty = True Then
            '        getBillNumber = 1
            '    Else
            '        getBillNumber = tbBillMethods.GetBillNo


            '    End If

            '    CreateNewBill.BillNO = getBillNumber
            '    CreateNewBill.JobNO = publicClaiminfo.Jobcode
            '    'InsertNewRecord(strProvider, "tbBill", "BillNo,JobNo", getBillNumber & ",'" & publicClaiminfo.Jobcode & "'")
            '    tbBillMethods.save(CreateNewBill)

            'End If
            'BillClass = tbBillMethods.GetSingleBill(publicClaiminfo.Jobcode)
            ' DirectCast(crBillPayment.ReportDefinition.ReportObjects("txtBillNo"), TextObject).Text = BillClass.BillNO









            GetAmountValue()


            strSQLBillInformation = "ClaimInfo.JobCode, ClaimInfo.Brand, ClaimInfo.ModelNo, ClaimInfo.SLNo, ClaimInfo.CustName, ClaimInfo.CustAddress1, ClaimInfo.CustAddress2, ClaimInfo.ServiceType,ClaimInfo.Remk, Branch.Branch, Branch.phone"



            strPartsInformation = "Select SID,ProductCode,ProdName,Qty,UnitPrice from tbiBillServiceDetails where  tbiBillServiceDetails.JobCode= '" & strtmpJobCode & "'"









            crBillPayment.DataDefinition.FormulaFields("fnJobCode").Text = "'" & claiminfoInvoice.Jobcode.ToString & "'"
            crBillPayment.DataDefinition.FormulaFields("fnCustomerName").Text = "'" & claiminfoInvoice.CustName.ToString & "'"
            crBillPayment.DataDefinition.FormulaFields("fnCustomerAddress").Text = "'" & claiminfoInvoice.CustAddress1.ToString & "'"
            crBillPayment.DataDefinition.FormulaFields("fnContactNo").Text = "'" & claiminfoInvoice.CustAddress2.ToString & "'"
            crBillPayment.DataDefinition.FormulaFields("fnBranch").Text = "'" & BranchInvoice.Branch.ToString & "'"
            crBillPayment.DataDefinition.FormulaFields("fnBranchContact").Text = "'" & BranchInvoice.phone.ToString & "'"
            crBillPayment.DataDefinition.FormulaFields("fnItem").Text = "'" & claiminfoInvoice.ServiceType.ToString & "'"
            crBillPayment.DataDefinition.FormulaFields("fnBrand").Text = "'" & claiminfoInvoice.Brand.ToString & "'"
            crBillPayment.DataDefinition.FormulaFields("fnModelNo").Text = "'" & claiminfoInvoice.ModelNo.ToString & "'"
            crBillPayment.DataDefinition.FormulaFields("fnSerial").Text = "'" & claiminfoInvoice.SLNo.ToString & "'"
            crBillPayment.DataDefinition.FormulaFields("fnDate").Text = "'" & Convert.ToDateTime(Today).ToShortDateString & "'"
            crBillPayment.DataDefinition.FormulaFields("fnRemarks").Text = "'" & claiminfoInvoice.Remk.ToString & "'"



            ' Warrant Field Section Note: This correct code and (you can use it later)

            'DirectCast(crBillPayment.ReportDefinition.ReportObjects("txtWarrType"), TextObject).Text = ""


            DirectCast(crBillPayment.ReportDefinition.ReportObjects("txtBillCompanyTitle"), TextObject).Text = strCompanyTitle & " " & "(Service Center)"



            Dim dtaPartInformation As New OleDbDataAdapter(strPartsInformation, ConBillPayment)

            crBillPayment.SetDataSource(TempdsBillPayment.Tables("Claiminfo"))

            crBillPayment.SetDataSource(dtInvoicePartsDetails)
            If ConBillPayment.State = ConnectionState.Closed Then
                ConBillPayment.Open()
            End If

            'TotalPartsAmount()
            If Not crBillPayment.DataDefinition.FormulaFields("fnTotalAmount").Text = "0.00" Then
                crBillPayment.DataDefinition.FormulaFields("FNinwordtaka").Text = "'" & Spellnumber(crBillPayment.DataDefinition.FormulaFields("fnTotalAmount").Text) & "'"
            End If


            'CountBillPrint()  enable for Print Button not for preview, Count how many time bill printed
            crvReportShow.ReportSource = crBillPayment
            crBillPayment.Refresh()



        Catch ReportLoadError As Exception
            MessageBox.Show(ReportLoadError.Message & vbTab & ReportLoadError.StackTrace)
            TempConnectionDispose(ConBillPayment)
            Me.Dispose()
        End Try


        TempConnectionDispose(ConBillPayment)




        'Dim TempdsBillPayment As New dsBillPayment
        'Dim ConBillPayment As New OleDbConnection(strProvider)




        'Dim strSQLBillInformation As String = String.Empty
        'Dim strPartsInformation As String = String.Empty

        'Dim getBillNo As Integer = 0

        'Dim drLoadCustomerInformation As OleDbDataReader = Nothing

        'strtmpJobCode = publicClaiminfo.Jobcode
        'Try

        '    'Dim drGetExistedBillNo As OleDbDataReader = Nothing

        '    'If RecordVerification(strProvider, "tbBill", "tbBill.JobNO='" & publicClaiminfo.Jobcode & "'") = False Then
        '    '    GetMaxBillNo(getBillNo)
        '    '    InsertNewRecord(strProvider, "tbBill", "BillNo,JobNo", "'" & getBillNo.ToString & "','" & publicClaiminfo.Jobcode & "'")
        '    '    DirectCast(crBillPayment.ReportDefinition.ReportObjects("txtBillNo"), TextObject).Text = Convert.ToString(getBillNo.ToString)
        '    'Else
        '    '    LoadAllInformation(ConBillPayment, drGetExistedBillNo, strProvider, "tbBill", "tbBill.BillNo", "tbBill.JobNo='" & publicClaiminfo.Jobcode & "'")
        '    '    If drGetExistedBillNo.HasRows = True Then
        '    '        Dim intBillNo As Integer = 0
        '    '        While drGetExistedBillNo.Read
        '    '            DirectCast(crBillPayment.ReportDefinition.ReportObjects("txtBillNo"), TextObject).Text = Convert.ToString(drGetExistedBillNo("BillNo").ToString)

        '    '        End While
        '    '    End If

        '    'End If







        '    GetAmountValue()


        '    strSQLBillInformation = "ClaimInfo.JobCode, ClaimInfo.Brand, ClaimInfo.ModelNo, ClaimInfo.SLNo, ClaimInfo.CustName, ClaimInfo.CustAddress1, ClaimInfo.CustAddress2, ClaimInfo.ServiceType,ClaimInfo.Remk, Branch.Branch, Branch.phone"
        '    strPartsInformation = "Select SID,ProductCode,ProdName,Qty,UnitPrice from tbiBillServiceDetails where  tbiBillServiceDetails.JobCode= '" & strtmpJobCode & "'"

        '    crBillPayment.DataDefinition.FormulaFields("fnJobCode").Text = "'" & claiminfoInvoice.Jobcode.ToString & "'"
        '    crBillPayment.DataDefinition.FormulaFields("fnCustomerName").Text = "'" & claiminfoInvoice.CustName.ToString & "'"
        '    crBillPayment.DataDefinition.FormulaFields("fnCustomerAddress").Text = "'" & claiminfoInvoice.CustAddress1.ToString & "'"
        '    crBillPayment.DataDefinition.FormulaFields("fnContactNo").Text = "'" & claiminfoInvoice.CustAddress2.ToString & "'"
        '    crBillPayment.DataDefinition.FormulaFields("fnBranch").Text = "'" & BranchInvoice.Branch.ToString & "'"
        '    crBillPayment.DataDefinition.FormulaFields("fnBranchContact").Text = "'" & BranchInvoice.phone.ToString & "'"
        '    crBillPayment.DataDefinition.FormulaFields("fnItem").Text = "'" & claiminfoInvoice.ServiceType.ToString & "'"
        '    crBillPayment.DataDefinition.FormulaFields("fnBrand").Text = "'" & claiminfoInvoice.Brand.ToString & "'"
        '    crBillPayment.DataDefinition.FormulaFields("fnModelNo").Text = "'" & claiminfoInvoice.ModelNo.ToString & "'"
        '    crBillPayment.DataDefinition.FormulaFields("fnSerial").Text = "'" & claiminfoInvoice.SLNo.ToString & "'"
        '    crBillPayment.DataDefinition.FormulaFields("fnDate").Text = "'" & Convert.ToDateTime(Today).ToShortDateString & "'"
        '    crBillPayment.DataDefinition.FormulaFields("fnRemarks").Text = "'" & claiminfoInvoice.Remk.ToString & "'"

        '    ' Warrant Field Section Note: This correct code and (you can use it later)
        '    'DirectCast(crBillPayment.ReportDefinition.ReportObjects("txtWarrType"), TextObject).Text = ""
        '    'If claiminfoInvoice.WCondition = 0 Then
        '    '    crBillPayment.DataDefinition.FormulaFields("fnJobType").Text = "'Sales Warranty'"
        '    'ElseIf claiminfoInvoice.WCondition = 1 Then
        '    '    crBillPayment.DataDefinition.FormulaFields("fnJobType").Text = "'On Payment'"
        '    'ElseIf claiminfoInvoice.WCondition = 2 Then
        '    '    crBillPayment.DataDefinition.FormulaFields("fnJobType").Text = "'Service Warranty'"
        '    'End If


        '    DirectCast(crBillPayment.ReportDefinition.ReportObjects("txtBillCompanyTitle"), TextObject).Text = strCompanyTitle



        '    Dim dtaPartInformation As New OleDbDataAdapter(strPartsInformation, ConBillPayment)

        '    crBillPayment.SetDataSource(TempdsBillPayment.Tables("Claiminfo"))

        '    crBillPayment.Subreports("ServiceDetailsReport").SetDataSource(dtInvoicePartsDetails)
        '    If ConBillPayment.State = ConnectionState.Closed Then
        '        ConBillPayment.Open()
        '    End If

        '    'TotalPartsAmount()
        '    If Not crBillPayment.DataDefinition.FormulaFields("fnTotalAmount").Text = "0.00" Then
        '        crBillPayment.DataDefinition.FormulaFields("FNinwordtaka").Text = "'" & Spellnumber(crBillPayment.DataDefinition.FormulaFields("fnTotalAmount").Text) & "'"
        '    End If


        '    'Dim BillPrintMethods As clsRPTHowTimeBillPrintMethods = New clsRPTHowTimeBillPrintMethods

        '    'If BillPrintMethods.ISEXIST(claiminfoInvoice.Jobcode.ToString, DirectCast(crBillPayment.ReportDefinition.ReportObjects("txtBillNo"), TextObject).Text) = True Then
        '    '    Dim BillPrintCount As List(Of clsRPTHowTimeBillPrint) = BillPrintMethods.GetALLBillNo.Where(Function(x) x.JobNo = claiminfoInvoice.Jobcode.ToString And x.BillNo = DirectCast(crBillPayment.ReportDefinition.ReportObjects("txtBillNo"), TextObject).Text)
        '    '    crBillPayment.DataDefinition.FormulaFields("fnPrintCount").Text = "'" & BillPrintCount.Count & " - Time Print'"
        '    'Else
        '    '    crBillPayment.DataDefinition.FormulaFields("fnPrintCount").Text = "'01 - Time Print'"
        '    'End If


        '    crvReportShow.ReportSource = crBillPayment
        '    crBillPayment.Refresh()



        'Catch ReportLoadError As Exception
        '    MessageBox.Show(ReportLoadError.Message & vbTab & ReportLoadError.StackTrace)
        '    TempConnectionDispose(ConBillPayment)
        '    Me.Dispose()
        'End Try


        'TempConnectionDispose(ConBillPayment)

    End Sub




    Private Sub BillReportCashsale()


        Dim crcashsale As rptBillPaymentCashsale = New rptBillPaymentCashsale

        Dim csm As clsCashsalesMethods = New clsCashsalesMethods

        Dim dt As DataTable = csm.CasheBill(CashSales.MRNO)





        Try

            If dt.Rows.Count > 0 Then



                Dim BranchMethods As clsBranchMethods = New clsBranchMethods


                If BranchMethods.Isexist(dt.Rows(0)(7).ToString) = True Then
                    Dim Branch As List(Of clsBranch) = BranchMethods.GetBranches.Where(Function(x) x.Branch = dt.Rows(0)(7).ToString).ToList

                    If Branch.Count > 0 Then

                        crBillPayment.DataDefinition.FormulaFields("FNBranchContact").Text = "'" & Branch(0).phone.ToString & "'"

                    End If
                End If

                crBillPayment.DataDefinition.FormulaFields("FNDate").Text = DateTime.Parse(Now).ToString("dd-MMM-yy")





                crcashsale.SetDataSource(dt)


                If Not crcashsale.DataDefinition.FormulaFields("fnTotalAmount").Text = "0.00" Then
                    crBillPayment.DataDefinition.FormulaFields("FNinwordtaka").Text = "'" & Spellnumber(crBillPayment.DataDefinition.FormulaFields("fnTotalAmount").Text) & "'"
                End If











                crvReportShow.ReportSource = crcashsale
                crBillPayment.Refresh()


            End If

        Catch ReportLoadError As Exception
            MessageBox.Show(ReportLoadError.Message & vbTab & ReportLoadError.StackTrace)

            Me.Dispose()
        End Try




    End Sub



    Private Sub BillReportShow()



        Dim TempdsBillPayment As New dsBillPayment
        Dim ConBillPayment As New OleDbConnection(strProvider)




        Dim strSQLBillInformation As String = String.Empty
        Dim strPartsInformation As String = String.Empty
        Dim tbBillMethods As clsTBBillMethods = New clsTBBillMethods

        Dim getBillNumber As Integer

        Dim drLoadCustomerInformation As OleDbDataReader = Nothing
        Dim BillClass As clstbBill = New clstbBill
        Dim CreateNewBill As clstbBill = New clstbBill

        strtmpJobCode = publicClaiminfo.Jobcode
        Try





            If tbBillMethods.ISEXIST(publicClaiminfo.Jobcode) = False Then

                If tbBillMethods.IsTableEmpty = True Then
                    getBillNumber = 1
                Else
                    getBillNumber = tbBillMethods.GetBillNo


                End If

                CreateNewBill.BillNO = getBillNumber
                CreateNewBill.JobNO = publicClaiminfo.Jobcode
                'InsertNewRecord(strProvider, "tbBill", "BillNo,JobNo", getBillNumber & ",'" & publicClaiminfo.Jobcode & "'")
                tbBillMethods.save(CreateNewBill)

            End If
            BillClass = tbBillMethods.GetSingleBill(publicClaiminfo.Jobcode)
            DirectCast(crBillPayment.ReportDefinition.ReportObjects("txtBillNo"), TextObject).Text = BillClass.BillNO












            strSQLBillInformation = "ClaimInfo.JobCode, ClaimInfo.Brand, ClaimInfo.ModelNo, ClaimInfo.SLNo, ClaimInfo.CustName, ClaimInfo.CustAddress1, ClaimInfo.CustAddress2, ClaimInfo.ServiceType,ClaimInfo.Remk, Branch.Branch, Branch.phone"



            strPartsInformation = "Select SID,ProductCode,ProdName,Qty,UnitPrice from tbiBillServiceDetails where  tbiBillServiceDetails.JobCode= '" & strtmpJobCode & "'"









            crBillPayment.DataDefinition.FormulaFields("fnJobCode").Text = "'" & claiminfoInvoice.Jobcode.ToString & "'"
            crBillPayment.DataDefinition.FormulaFields("fnCustomerName").Text = "'" & claiminfoInvoice.CustName.ToString & "'"
            crBillPayment.DataDefinition.FormulaFields("fnCustomerAddress").Text = "'" & claiminfoInvoice.CustAddress1.ToString & "'"
            crBillPayment.DataDefinition.FormulaFields("fnContactNo").Text = "'" & claiminfoInvoice.CustAddress2.ToString & "'"
            crBillPayment.DataDefinition.FormulaFields("fnBranch").Text = "'" & BranchInvoice.Branch.ToString & "'"
            crBillPayment.DataDefinition.FormulaFields("fnBranchContact").Text = "'" & BranchInvoice.phone.ToString & "'"
            crBillPayment.DataDefinition.FormulaFields("fnItem").Text = "'" & claiminfoInvoice.ServiceType.ToString & "'"
            crBillPayment.DataDefinition.FormulaFields("fnBrand").Text = "'" & claiminfoInvoice.Brand.ToString & "'"
            crBillPayment.DataDefinition.FormulaFields("fnModelNo").Text = "'" & claiminfoInvoice.ModelNo.ToString & "'"
            crBillPayment.DataDefinition.FormulaFields("fnSerial").Text = "'" & claiminfoInvoice.SLNo.ToString & "'"
            crBillPayment.DataDefinition.FormulaFields("fnDate").Text = "'" & Convert.ToDateTime(Today).ToShortDateString & "'"
            crBillPayment.DataDefinition.FormulaFields("fnRemarks").Text = "'" & claiminfoInvoice.Remk.ToString & "'"



            ' Warrant Field Section Note: This correct code and (you can use it later)

            'DirectCast(crBillPayment.ReportDefinition.ReportObjects("txtWarrType"), TextObject).Text = ""


            DirectCast(crBillPayment.ReportDefinition.ReportObjects("txtBillCompanyTitle"), TextObject).Text = strCompanyTitle & " " & "(Service Center)"



            Dim dtaPartInformation As New OleDbDataAdapter(strPartsInformation, ConBillPayment)

            crBillPayment.SetDataSource(TempdsBillPayment.Tables("Claiminfo"))

            crBillPayment.SetDataSource(dtInvoicePartsDetails)
            If ConBillPayment.State = ConnectionState.Closed Then
                ConBillPayment.Open()
            End If


            GetAmountValue()
            If Not crBillPayment.DataDefinition.FormulaFields("fnTotalAmount").Text = "0.00" Then
                crBillPayment.DataDefinition.FormulaFields("FNinwordtaka").Text = "'" & Spellnumber(crBillPayment.DataDefinition.FormulaFields("fnTotalAmount").Text) & "'"
            End If


            CountBillPrint()
            crvReportShow.ReportSource = crBillPayment
            crBillPayment.Refresh()



        Catch ReportLoadError As Exception
            MessageBox.Show(ReportLoadError.Message & vbTab & ReportLoadError.StackTrace)
            TempConnectionDispose(ConBillPayment)
            Me.Dispose()
        End Try


        TempConnectionDispose(ConBillPayment)

    End Sub


#Region "' Orginal Invoice Bill Report A4 Paper size"

    Private Sub BillReportShow1()



        Dim TempdsBillPayment As New dsBillPayment
        Dim ConBillPayment As New OleDbConnection(strProvider)




        Dim strSQLBillInformation As String = String.Empty
        Dim strPartsInformation As String = String.Empty
        Dim tbBillMethods As clsTBBillMethods = New clsTBBillMethods

        Dim getBillNumber As Integer

        Dim drLoadCustomerInformation As OleDbDataReader = Nothing
        Dim BillClass As clstbBill = New clstbBill
        Dim CreateNewBill As clstbBill = New clstbBill

        strtmpJobCode = publicClaiminfo.Jobcode
        Try





            If tbBillMethods.ISEXIST(publicClaiminfo.Jobcode) = False Then

                If tbBillMethods.IsTableEmpty = True Then
                    getBillNumber = 1
                Else
                    getBillNumber = tbBillMethods.GetBillNo


                End If

                CreateNewBill.BillNO = getBillNumber
                CreateNewBill.JobNO = publicClaiminfo.Jobcode
                'InsertNewRecord(strProvider, "tbBill", "BillNo,JobNo", getBillNumber & ",'" & publicClaiminfo.Jobcode & "'")
                tbBillMethods.save(CreateNewBill)

            End If
            BillClass = tbBillMethods.GetSingleBill(publicClaiminfo.Jobcode)
            DirectCast(crBillPayment.ReportDefinition.ReportObjects("txtBillNo"), TextObject).Text = BillClass.BillNO




            'Dim drGetExistedBillNo As OleDbDataReader = Nothing

            'If RecordVerification(strProvider, "tbBill", "tbBill.JobNO='" & publicClaiminfo.Jobcode & "'") = False Then
            '    GetMaxBillNo(getBillNo)
            '    InsertNewRecord(strProvider, "tbBill", "BillNo,JobNo", "'" & getBillNo.ToString & "','" & publicClaiminfo.Jobcode & "'")
            '    DirectCast(crBillPayment.ReportDefinition.ReportObjects("txtBillNo"), TextObject).Text = Convert.ToString(getBillNo.ToString)
            'Else
            '    LoadAllInformation(ConBillPayment, drGetExistedBillNo, strProvider, "tbBill", "tbBill.BillNo", "tbBill.JobNo='" & publicClaiminfo.Jobcode & "'")
            '    If drGetExistedBillNo.HasRows = True Then
            '        Dim intBillNo As Integer = 0
            '        While drGetExistedBillNo.Read
            '            DirectCast(crBillPayment.ReportDefinition.ReportObjects("txtBillNo"), TextObject).Text = Convert.ToString(drGetExistedBillNo("BillNo").ToString)

            '        End While
            '    End If

            'End If







            GetAmountValue()


            strSQLBillInformation = "ClaimInfo.JobCode, ClaimInfo.Brand, ClaimInfo.ModelNo, ClaimInfo.SLNo, ClaimInfo.CustName, ClaimInfo.CustAddress1, ClaimInfo.CustAddress2, ClaimInfo.ServiceType,ClaimInfo.Remk, Branch.Branch, Branch.phone"



            strPartsInformation = "Select SID,ProductCode,ProdName,Qty,UnitPrice from tbiBillServiceDetails where  tbiBillServiceDetails.JobCode= '" & strtmpJobCode & "'"









            crBillPayment.DataDefinition.FormulaFields("fnJobCode").Text = "'" & claiminfoInvoice.Jobcode.ToString & "'"
            crBillPayment.DataDefinition.FormulaFields("fnCustomerName").Text = "'" & claiminfoInvoice.CustName.ToString & "'"
            crBillPayment.DataDefinition.FormulaFields("fnCustomerAddress").Text = "'" & claiminfoInvoice.CustAddress1.ToString & "'"
            crBillPayment.DataDefinition.FormulaFields("fnContactNo").Text = "'" & claiminfoInvoice.CustAddress2.ToString & "'"
            crBillPayment.DataDefinition.FormulaFields("fnBranch").Text = "'" & BranchInvoice.Branch.ToString & "'"
            crBillPayment.DataDefinition.FormulaFields("fnBranchContact").Text = "'" & BranchInvoice.phone.ToString & "'"
            crBillPayment.DataDefinition.FormulaFields("fnItem").Text = "'" & claiminfoInvoice.ServiceType.ToString & "'"
            crBillPayment.DataDefinition.FormulaFields("fnBrand").Text = "'" & claiminfoInvoice.Brand.ToString & "'"
            crBillPayment.DataDefinition.FormulaFields("fnModelNo").Text = "'" & claiminfoInvoice.ModelNo.ToString & "'"
            crBillPayment.DataDefinition.FormulaFields("fnSerial").Text = "'" & claiminfoInvoice.SLNo.ToString & "'"
            crBillPayment.DataDefinition.FormulaFields("fnDate").Text = "'" & Convert.ToDateTime(Today).ToShortDateString & "'"
            crBillPayment.DataDefinition.FormulaFields("fnRemarks").Text = "'" & claiminfoInvoice.Remk.ToString & "'"



            ' Warrant Field Section Note: This correct code and (you can use it later)
            DirectCast(crBillPayment.ReportDefinition.ReportObjects("txtWarrType"), TextObject).Text = ""
            'If claiminfoInvoice.WCondition = 0 Then
            '    crBillPayment.DataDefinition.FormulaFields("fnJobType").Text = "'Sales Warranty'"
            'ElseIf claiminfoInvoice.WCondition = 1 Then
            '    crBillPayment.DataDefinition.FormulaFields("fnJobType").Text = "'On Payment'"
            'ElseIf claiminfoInvoice.WCondition = 2 Then
            '    crBillPayment.DataDefinition.FormulaFields("fnJobType").Text = "'Service Warranty'"
            'End If


            DirectCast(crBillPayment.ReportDefinition.ReportObjects("txtBillCompanyTitle"), TextObject).Text = strCompanyTitle



            Dim dtaPartInformation As New OleDbDataAdapter(strPartsInformation, ConBillPayment)

            crBillPayment.SetDataSource(TempdsBillPayment.Tables("Claiminfo"))

            crBillPayment.Subreports("ServiceDetailsReport").SetDataSource(dtInvoicePartsDetails)
            If ConBillPayment.State = ConnectionState.Closed Then
                ConBillPayment.Open()
            End If

            'TotalPartsAmount()
            If Not crBillPayment.DataDefinition.FormulaFields("fnTotalAmount").Text = "0.00" Then
                crBillPayment.DataDefinition.FormulaFields("FNinwordtaka").Text = "'" & Spellnumber(crBillPayment.DataDefinition.FormulaFields("fnTotalAmount").Text) & "'"
            End If


            CountBillPrint()
            crvReportShow.ReportSource = crBillPayment
            crBillPayment.Refresh()



        Catch ReportLoadError As Exception
            MessageBox.Show(ReportLoadError.Message & vbTab & ReportLoadError.StackTrace)
            TempConnectionDispose(ConBillPayment)
            Me.Dispose()
        End Try


        TempConnectionDispose(ConBillPayment)

    End Sub


#End Region






    Private Sub ReceiveReportShow()
        Dim rptTempRecevieReport As New rptReceive_Information
        Dim strSQLReceive As String = String.Empty
        Dim conReceiveInformation As New OleDbConnection(strProvider)
        Dim conSummary As New OleDbConnection(strProvider)

        Dim drSummary As OleDbDataReader = Nothing


        strSQLReceive = "Select Claiminfo.JobCode,Claiminfo.Branch,Claiminfo.CustName,Claiminfo.ServiceType,Claiminfo.Brand,Claiminfo.ModelNo,Claiminfo.SLNO,Claiminfo.ReceptDate,Claiminfo.Wcondition,Claiminfo.Cflag,CustomerClaim.ClaimCode from Claiminfo Left Join CustomerClaim on Claiminfo.JobCode=CustomerClaim.JobCode Where " & strSQLCriteria & " order by Claiminfo.JobCode,Claiminfo.ReceptDate"

        Dim daReceiveInformation As New OleDbDataAdapter(strSQLReceive, conReceiveInformation)

        Dim dsReceiveInformation As New DataSet

        Try
            conSummary.Open()



            getsummary(conSummary, drSummary, "Claiminfo.Wcondition as Type,Count(Wcondition) as Qty", "Claiminfo", " Left Join CustomerClaimReport ON Claiminfo.JobCode=CustomerClaimReport.JobCode", strSQLCriteria.ToString, "Claiminfo.Wcondition")



            daReceiveInformation.Fill(dsReceiveInformation, "ReceiveInformation")

            rptTempRecevieReport.SetDataSource(dsReceiveInformation.Tables(0))
            DirectCast(rptTempRecevieReport.ReportDefinition.ReportObjects("txtReceiveCompanyTitle"), TextObject).Text = strCompanyTitle



            If drSummary.HasRows = True Then
                While drSummary.Read

                    If drSummary("Type").ToString = "0" Then

                        DirectCast(rptTempRecevieReport.ReportDefinition.ReportObjects("txtSalesWarrQty"), TextObject).Text = drSummary("Qty").ToString
                    ElseIf drSummary("Type").ToString = "1" Then
                        DirectCast(rptTempRecevieReport.ReportDefinition.ReportObjects("txtNonWarrQty"), TextObject).Text = drSummary("Qty").ToString
                    ElseIf drSummary("Type").ToString = "2" Then
                        DirectCast(rptTempRecevieReport.ReportDefinition.ReportObjects("txtSvcWarrQty"), TextObject).Text = drSummary("Qty").ToString
                    End If


                End While


            End If



            DirectCast(rptTempRecevieReport.ReportDefinition.ReportObjects("txtDateFrom"), TextObject).Text = dtStartDate.ToShortDateString
            DirectCast(rptTempRecevieReport.ReportDefinition.ReportObjects("txtDateTo"), TextObject).Text = dtEndDate.ToShortDateString



            crvReportShow.ReportSource = rptTempRecevieReport
            crvReportShow.Refresh()



        Catch exSummary As Exception
            MessageBox.Show(exSummary.Message)
        End Try


        conSummary.Dispose()



    End Sub



    '________________________________________________________________________________________ Delivery Report Section ____________________________________



    Private Sub DeliveryReportShow()
        Dim rptTempDeliveryReport As rptDelivery = New rptDelivery
        Dim strSQLDelivery As String = String.Empty
        Dim conDelivery As New OleDbConnection(strProvider)
        Dim conDeliverySummary As New OleDbConnection(strProvider)



        'Declare for Wcondition
        Dim intSalesWarr As Integer
        Dim intNonsWarr As Integer
        Dim intSvcWarr As Integer
        Dim intAll As Integer


        ' -1 means Not Found <>-1 means Found show Position of the Text
        intSalesWarr = strSQLCriteria.IndexOf("Wcondition IN(0)")
        intNonsWarr = strSQLCriteria.IndexOf("Wcondition IN(1)")
        intSvcWarr = strSQLCriteria.IndexOf("Wcondition IN(2)")
        intAll = strSQLCriteria.IndexOf("Wcondition IN(0,1,2)")


        If intAll <> -1 Or intSvcWarr <> -1 Then '-1 is 'Not Found'
            strSQLDelivery = "Select Claiminfo.JobCode,Claiminfo.Branch,Claiminfo.CustName,Claiminfo.Wcondition,Claiminfo.ServiceType,Claiminfo.Brand,Claiminfo.ModelNo,Claiminfo.MrNo,Claiminfo.Ddate,Claiminfo.svAmt,Claiminfo.prdAmt,Claiminfo.OtherAmt,Claiminfo.Dis,CLaiminfo.AdvanceAmnt, (iif( Claiminfo.FreeOfCost =1,0,iif(claiminfo.MRNO='' or isnull(claiminfo.MRNO),0,(Claiminfo.svAmt+Claiminfo.prdAmt+Claiminfo.OtherAmt )-(Claiminfo.Dis+CLaiminfo.AdvanceAmnt)))) as Total, iif(Claiminfo.FreeOfCost=1,'FC',iif((Claiminfo.MRNO='' or isnull(Claiminfo.MRNO))and (Claiminfo.svAmt+Claiminfo.prdAmt+Claiminfo.OtherAmt)>0,'OTS','')) as FC from Claiminfo Where " & strSQLCriteria & " Order by Claiminfo.JobCode"
        ElseIf intSalesWarr <> -1 Then
            strSQLDelivery = "Select CM.JobCode, CM.Branch, CM.CustName, CM.Wcondition, cm.Cflag, CM.ServiceType, CM.Brand, CM.ModelNo, CM.MrNo, 
                             CM.Ddate,iif(cm.cflag=2,0, BM.Charge) as svAmt,CM.prdAmt,  CM.OtherAmt, CM.Dis, CM.AdvanceAmnt, 
                             ((iif(cm.cflag=2,0,BM.Charge)+cm.prdamt+cm.otheramt)-(cm.dis+CM.AdvanceAmnt)) as Total, CM.FC  from (Select Claiminfo.JobCode, Claiminfo.Branch, Claiminfo.CustName, Claiminfo.Wcondition, Claiminfo.ServiceType, Claiminfo.Brand, Claiminfo.ModelNo, Claiminfo.MrNo, Claiminfo.Ddate, sum(iif(claiminfo.cflag=2,0,ServiceDetailsDetails.Qty*ServiceDetailsDetails.UnitPrice)) as prdAmt, Claiminfo.Cflag, Brand.brdid,Claiminfo.OtherAmt,Claiminfo.Dis,CLaiminfo.AdvanceAmnt, iif(Claiminfo.FreeOfCost=1,'FC',iif((Claiminfo.MRNO='' or isnull(Claiminfo.MRNO)) and (Claiminfo.svAmt+Claiminfo.prdAmt+Claiminfo.OtherAmt)>0,'OTS','')) as FC from  
                             ((Claiminfo LEFT JOIN Brand ON (Claiminfo.Brand = Brand.Brand) AND (Claiminfo.ServiceType = Brand.cType)) inner Join ServicedetailsDetails on Claiminfo.JobCode=ServicedetailsDetails.JobCOde)  where " & strSQLCriteria &
                " group by Claiminfo.JobCode, Claiminfo.Branch, Claiminfo.CustName, Claiminfo.Wcondition, Claiminfo.ServiceType, Claiminfo.Brand, Claiminfo.ModelNo, Claiminfo.MrNo, Claiminfo.Ddate,Claiminfo.Cflag, Brand.brdid,Claiminfo.OtherAmt,Claiminfo.Dis,CLaiminfo.AdvanceAmnt, iif(Claiminfo.FreeOfCost=1,'FC',iif((Claiminfo.MRNO='' or isnull(Claiminfo.MRNO)) and (Claiminfo.svAmt+Claiminfo.prdAmt+Claiminfo.OtherAmt)>0,'OTS','')) 
) AS CM left join(Select brandmodel.Model, Brandmodel.brdid, Brandmodel.Charge from Brandmodel) as BM on cm.ModelNo=bm.Model and cm.brdid=bm.brdid
"

        End If











        Dim daDelivery As New OleDbDataAdapter(strSQLDelivery, conDelivery)

        Dim dsDelivery As New DataSet

        Try
            conDeliverySummary.Open()



            '  getsummary(conDeliverySummary, drDeliverySummary, "Claiminfo.Wcondition as Type,Count(Wcondition) as Qty", "Claiminfo", " Left Join CustomerClaimReport ON Claiminfo.JobCode=CustomerClaimReport.JobCode", strSQLCriteria.ToString, "Claiminfo.Wcondition")



            daDelivery.Fill(dsDelivery, "Delivery")

            rptTempDeliveryReport.SetDataSource(dsDelivery.Tables(0))
            DirectCast(rptTempDeliveryReport.ReportDefinition.ReportObjects("txtReceiveCompanyTitle"), TextObject).Text = strCompanyTitle



            'If drDeliverySummary.HasRows = True Then
            '    While drDeliverySummary.Read

            '        If drDeliverySummary("Type").ToString = "0" Then

            '            DirectCast(rptTempDeliveryReport.ReportDefinition.ReportObjects("txtSalesWarrQty"), TextObject).Text = drDeliverySummary("Qty").ToString
            '        ElseIf drDeliverySummary("Type").ToString = "1" Then
            '            DirectCast(rptTempDeliveryReport.ReportDefinition.ReportObjects("txtNonWarrQty"), TextObject).Text = drDeliverySummary("Qty").ToString
            '        ElseIf drDeliverySummary("Type").ToString = "2" Then
            '            DirectCast(rptTempDeliveryReport.ReportDefinition.ReportObjects("txtSvcWarrQty"), TextObject).Text = drDeliverySummary("Qty").ToString
            '        End If

            '    End While


            'End If



            DirectCast(rptTempDeliveryReport.ReportDefinition.ReportObjects("txtDateFrom"), TextObject).Text = dtStartDate.ToShortDateString
            DirectCast(rptTempDeliveryReport.ReportDefinition.ReportObjects("txtDateTo"), TextObject).Text = dtEndDate.ToShortDateString

            Dim cashsalesMethods As clsCashsalesMethods = New clsCashsalesMethods
            Dim Cashsales As Double = cashsalesMethods.GetCashsalesNetTotalAmount(DeliveryCashsales.Branch & " AND ReceptDate Between #" & dtStartDate & "# AND #" & dtEndDate & "#")

            Dim dblAMount As Double = Cashsales






            rptTempDeliveryReport.DataDefinition.FormulaFields("FnCashsales").Text = Convert.ToDouble(dblAMount)

            crvReportShow.ReportSource = rptTempDeliveryReport
            crvReportShow.Refresh()



        Catch exSummary As Exception
            MessageBox.Show(exSummary.Message)
        End Try


        conDeliverySummary.Dispose()



    End Sub

















    '________________________________________________________________________________________ Repaired Report Section ____________________________________



    Private Sub RepairedReportShow()
        Dim rptTempRepairedReport As New rptRepaired_Information
        Dim strSQLRepaired As String = String.Empty
        Dim conReceiveInformation As New OleDbConnection(strProvider)
        Dim conSummary As New OleDbConnection(strProvider)

        Dim drSummary As OleDbDataReader = Nothing


        strSQLRepaired = "Select Claiminfo.JobCode,Claiminfo.Branch,Claiminfo.ServiceType,Claiminfo.Brand,Claiminfo.ModelNo,Claiminfo.SLNO,Claiminfo.ReceptDate,Claiminfo.Sdate,Claiminfo.Wcondition,Claiminfo.Cflag,CustomerClaim.ClaimCode,ServiceDetails.Description from (Claiminfo left Join ServiceDetails on Claiminfo.JobCode=ServiceDetails.JobCode) Left Join CustomerClaim on Claiminfo.JobCode=CustomerClaim.JobCode Where " & strSQLCriteria & " Order by Claiminfo.JobCode"

        Dim daReceiveInformation As New OleDbDataAdapter(strSQLRepaired, conReceiveInformation)

        Dim dsRepairedInformation As New DataSet

        Try
            conSummary.Open()







            daReceiveInformation.Fill(dsRepairedInformation, "Repaird Information")

            rptTempRepairedReport.SetDataSource(dsRepairedInformation.Tables(0))
            DirectCast(rptTempRepairedReport.ReportDefinition.ReportObjects("txtCompanyTitle"), TextObject).Text = strCompanyTitle






            DirectCast(rptTempRepairedReport.ReportDefinition.ReportObjects("txtDateFrom"), TextObject).Text = dtStartDate.ToShortDateString
            DirectCast(rptTempRepairedReport.ReportDefinition.ReportObjects("txtDateTo"), TextObject).Text = dtEndDate.ToShortDateString



            crvReportShow.ReportSource = rptTempRepairedReport
            crvReportShow.Refresh()



        Catch exSummary As Exception
            MessageBox.Show(exSummary.Message)
        End Try


        conSummary.Dispose()



    End Sub






    Private Sub PendingReportShow()
        Dim rptTempPendingReport As New rptPending
        Dim strSQLPending As String = String.Empty
        Dim conReceiveInformation As New OleDbConnection(strProvider)
        Dim conSummary As New OleDbConnection(strProvider)

        Dim drSummary As OleDbDataReader = Nothing


        strSQLPending = "Select Claiminfo.JobCode,Claiminfo.Branch,Claiminfo.ServiceType,Claiminfo.Brand,Claiminfo.ModelNo,Pending.PenCode,Claiminfo.Sdate,Claiminfo.IsssueDate, ( '(' & Claiminfo.ServiceBy & ') ' & Personal.EmpName) as IssueTo,Claiminfo.Wcondition,Claiminfo.Cflag from (Claiminfo Left Join Pending on Claiminfo.JobCode=Pending.JobCode) Left Join Personal on Claiminfo.ServiceBy=Personal.EMPCODE Where " & strSQLCriteria & " Order by Claiminfo.JobCode"

        Dim daPendingInformation As New OleDbDataAdapter(strSQLPending, conReceiveInformation)

        Dim dsPendingInformation As New DataSet

        Try
            conSummary.Open()



            getsummary(conSummary, drSummary, "Claiminfo.Wcondition as Type,Count(Wcondition) as Qty", "Claiminfo", " Left Join PendingReport on Claiminfo.JobCode=PendingReport.JobCode", strSQLCriteria.ToString, "Claiminfo.Wcondition")



            daPendingInformation.Fill(dsPendingInformation, "Pending")

            rptTempPendingReport.SetDataSource(dsPendingInformation.Tables(0))
            DirectCast(rptTempPendingReport.ReportDefinition.ReportObjects("txtCompanyTitle"), TextObject).Text = strCompanyTitle



            If drSummary.HasRows = True Then
                While drSummary.Read

                    If drSummary("Type").ToString = "0" Then

                        DirectCast(rptTempPendingReport.ReportDefinition.ReportObjects("txtSalesWarrQty"), TextObject).Text = drSummary("Qty").ToString
                    ElseIf drSummary("Type").ToString = "1" Then
                        DirectCast(rptTempPendingReport.ReportDefinition.ReportObjects("txtNonWarrQty"), TextObject).Text = drSummary("Qty").ToString
                    ElseIf drSummary("Type").ToString = "2" Then
                        DirectCast(rptTempPendingReport.ReportDefinition.ReportObjects("txtSvcWarrQty"), TextObject).Text = drSummary("Qty").ToString
                    End If

                End While


            End If



            DirectCast(rptTempPendingReport.ReportDefinition.ReportObjects("txtDateFrom"), TextObject).Text = dtStartDate.ToShortDateString
            DirectCast(rptTempPendingReport.ReportDefinition.ReportObjects("txtDateTo"), TextObject).Text = dtEndDate.ToShortDateString



            crvReportShow.ReportSource = rptTempPendingReport
            crvReportShow.Refresh()



        Catch exSummary As Exception
            MessageBox.Show(exSummary.Message)
        End Try


        conSummary.Dispose()



    End Sub








    '___________________________________________________________ Estimate Refuse Report Section _______________________________________




    Private Sub EstimateRefuseReportShow()
        Dim rptTempEstimateRefuseReport As New rptEstimateRefuse
        Dim strSQLEstimateRefuse As String = String.Empty
        Dim conEstimateRefuse As New OleDbConnection(strProvider)
        Dim conEstimateRefuseSummary As New OleDbConnection(strProvider)

        Dim drEstimateRefuseSummary As OleDbDataReader = Nothing


        strSQLEstimateRefuse = "Select Claiminfo.JobCode,Claiminfo.Branch,Claiminfo.ServiceType,Claiminfo.Brand,Claiminfo.ModelNo,Claiminfo.IsssueDate,Claiminfo.Sdate,Claiminfo.Wcondition,Claiminfo.Cflag,('(' & Claiminfo.Serviceby & ') ' & Personal.EmpName) as RefusedBy,EstimateRefused.RefuseAmnt as RefuseAmount,EstimateRefused.EstText from (Claiminfo Inner Join EstimateRefused on Claiminfo.JobCode=EstimateRefused.JobCode) Left Join Personal on Claiminfo.Serviceby=Personal.EmpCode Where " & strSQLCriteria & " Order By Claiminfo.JobCode, Claiminfo.Mrno"

        Dim daEstimateRefuse As New OleDbDataAdapter(strSQLEstimateRefuse, conEstimateRefuse)

        Dim dsEstimateRefuse As New DataSet

        Try
            conEstimateRefuseSummary.Open()



            getsummary(conEstimateRefuseSummary, drEstimateRefuseSummary, "Claiminfo.Wcondition as Type,Count(Wcondition) as Qty", "(Claiminfo", " Inner Join EstimateRefused on Claiminfo.JobCode=EstimateRefused.JobCode) Left Join Personal on Claiminfo.Serviceby=Personal.EmpCode", strSQLCriteria.ToString, "Claiminfo.Wcondition")



            daEstimateRefuse.Fill(dsEstimateRefuse, "Estimate Refuse")

            rptTempEstimateRefuseReport.SetDataSource(dsEstimateRefuse.Tables(0))
            DirectCast(rptTempEstimateRefuseReport.ReportDefinition.ReportObjects("txtCompanyTitle"), TextObject).Text = strCompanyTitle



            If drEstimateRefuseSummary.HasRows = True Then
                While drEstimateRefuseSummary.Read

                    If drEstimateRefuseSummary("Type").ToString = "0" Then

                        DirectCast(rptTempEstimateRefuseReport.ReportDefinition.ReportObjects("txtSalesWarrQty"), TextObject).Text = drEstimateRefuseSummary("Qty").ToString
                    ElseIf drEstimateRefuseSummary("Type").ToString = "1" Then
                        DirectCast(rptTempEstimateRefuseReport.ReportDefinition.ReportObjects("txtNonWarrQty"), TextObject).Text = drEstimateRefuseSummary("Qty").ToString
                    ElseIf drEstimateRefuseSummary("Type").ToString = "2" Then
                        DirectCast(rptTempEstimateRefuseReport.ReportDefinition.ReportObjects("txtSvcWarrQty"), TextObject).Text = drEstimateRefuseSummary("Qty").ToString
                    End If

                End While


            End If



            DirectCast(rptTempEstimateRefuseReport.ReportDefinition.ReportObjects("txtDateFrom"), TextObject).Text = dtStartDate.ToShortDateString
            DirectCast(rptTempEstimateRefuseReport.ReportDefinition.ReportObjects("txtDateTo"), TextObject).Text = dtEndDate.ToShortDateString



            crvReportShow.ReportSource = rptTempEstimateRefuseReport
            crvReportShow.Refresh()



        Catch exSummary As Exception
            MessageBox.Show(exSummary.Message)
        End Try


        conEstimateRefuseSummary.Dispose()



    End Sub







    Private Sub PendingDelivery()

        Dim rptTempPendingDelivery As New rptPendingDelivery
        Dim strSQLPendingDelivery As String = String.Empty
        Dim conPendingDelivery As New OleDbConnection(strProvider)
        Dim conPendingDeliverySummary As New OleDbConnection(strProvider)

        Dim drPendingDeliverySummary As OleDbDataReader = Nothing


        strSQLPendingDelivery = "Select Claiminfo.JobCode,Claiminfo.Branch,Claiminfo.ServiceType,Claiminfo.Brand,Claiminfo.ModelNo,Claiminfo.CustName,Claiminfo.CustAddress2 as Contact,Claiminfo.ReceptDate,Claiminfo.Sdate,Claiminfo.Wcondition,Claiminfo.svAmt as Technical,Claiminfo.prdamt as Parts,CLaiminfo.Otheramt as Others,Claiminfo.Dis as Discount, Claiminfo.AdvanceAmnt as Advance  from Claiminfo Where " & strSQLCriteria & " Order by Claiminfo.JobCode"

        Dim daPendingDelivery As New OleDbDataAdapter(strSQLPendingDelivery, conPendingDelivery)

        Dim dsPendingDelivery As New DataSet

        Try
            conPendingDeliverySummary.Open()



            getsummary(conPendingDeliverySummary, drPendingDeliverySummary, "Claiminfo.Wcondition as Type,Count(Wcondition) as Qty", "Claiminfo", "", strSQLCriteria.ToString, "Claiminfo.Wcondition")



            daPendingDelivery.Fill(dsPendingDelivery, "Estimate Refuse")

            rptTempPendingDelivery.SetDataSource(dsPendingDelivery.Tables(0))
            DirectCast(rptTempPendingDelivery.ReportDefinition.ReportObjects("txtCompanyTitle"), TextObject).Text = strCompanyTitle



            If drPendingDeliverySummary.HasRows = True Then
                While drPendingDeliverySummary.Read

                    If drPendingDeliverySummary("Type").ToString = "0" Then

                        DirectCast(rptTempPendingDelivery.ReportDefinition.ReportObjects("txtSalesWarrQty"), TextObject).Text = drPendingDeliverySummary("Qty").ToString
                    ElseIf drPendingDeliverySummary("Type").ToString = "1" Then
                        DirectCast(rptTempPendingDelivery.ReportDefinition.ReportObjects("txtNonWarrQty"), TextObject).Text = drPendingDeliverySummary("Qty").ToString
                    ElseIf drPendingDeliverySummary("Type").ToString = "2" Then
                        DirectCast(rptTempPendingDelivery.ReportDefinition.ReportObjects("txtSvcWarrQty"), TextObject).Text = drPendingDeliverySummary("Qty").ToString
                    End If

                End While


            End If



            DirectCast(rptTempPendingDelivery.ReportDefinition.ReportObjects("txtDateFrom"), TextObject).Text = dtStartDate.ToShortDateString
            DirectCast(rptTempPendingDelivery.ReportDefinition.ReportObjects("txtDateTo"), TextObject).Text = dtEndDate.ToShortDateString



            crvReportShow.ReportSource = rptTempPendingDelivery
            crvReportShow.Refresh()



        Catch exSummary As Exception
            MessageBox.Show(exSummary.Message)
        End Try


        conPendingDeliverySummary.Dispose()



    End Sub






    Private Sub NRCRReportShow()
        Dim rptNRCRReport As New rptNRCR
        Dim strSQLNRCR As String = String.Empty
        Dim conNRCR As New OleDbConnection(strProvider)
        Dim conNRCRSummary As New OleDbConnection(strProvider)

        Dim drNRCRSummary As OleDbDataReader = Nothing


        strSQLNRCR = "Select Claiminfo.JobCode,Claiminfo.Branch,Claiminfo.ServiceType,Claiminfo.Brand,Claiminfo.ModelNo,NRDetails.NRCode,Claiminfo.Sdate,Claiminfo.IsssueDate, ( '(' & Claiminfo.ServiceBy & ') ' & Personal.EmpName) as IssueTo,Claiminfo.Wcondition,Claiminfo.Cflag from (Claiminfo inner Join NRDetails on Claiminfo.JobCode=NrDetails.JobCode) Left Join Personal on Claiminfo.ServiceBy=Personal.EMPCODE Where " & strSQLCriteria & " Order by Claiminfo.JobCode"

        Dim daNRCR As New OleDbDataAdapter(strSQLNRCR, conNRCR)

        Dim dsNRCR As New DataSet

        Try
            conNRCRSummary.Open()



            getsummary(conNRCRSummary, drNRCRSummary, "Claiminfo.Wcondition as Type,Count(Wcondition) as Qty", "Claiminfo", " Inner Join NRDetails on Claiminfo.JobCode=NRDetails.JobCode", strSQLCriteria.ToString, "Claiminfo.Wcondition")



            daNRCR.Fill(dsNRCR, "NRCR")

            rptNRCRReport.SetDataSource(dsNRCR.Tables(0))
            DirectCast(rptNRCRReport.ReportDefinition.ReportObjects("txtCompanyTitle"), TextObject).Text = strCompanyTitle



            If drNRCRSummary.HasRows = True Then
                While drNRCRSummary.Read

                    If drNRCRSummary("Type").ToString = "0" Then

                        DirectCast(rptNRCRReport.ReportDefinition.ReportObjects("txtSalesWarrQty"), TextObject).Text = drNRCRSummary("Qty").ToString
                    ElseIf drNRCRSummary("Type").ToString = "1" Then
                        DirectCast(rptNRCRReport.ReportDefinition.ReportObjects("txtNonWarrQty"), TextObject).Text = drNRCRSummary("Qty").ToString
                    ElseIf drNRCRSummary("Type").ToString = "2" Then
                        DirectCast(rptNRCRReport.ReportDefinition.ReportObjects("txtSvcWarrQty"), TextObject).Text = drNRCRSummary("Qty").ToString
                    End If

                End While


            End If



            DirectCast(rptNRCRReport.ReportDefinition.ReportObjects("txtDateFrom"), TextObject).Text = dtStartDate.ToShortDateString
            DirectCast(rptNRCRReport.ReportDefinition.ReportObjects("txtDateTo"), TextObject).Text = dtEndDate.ToShortDateString



            crvReportShow.ReportSource = rptNRCRReport
            crvReportShow.Refresh()



        Catch exSummary As Exception
            MessageBox.Show(exSummary.Message)
        End Try


        conNRCRSummary.Dispose()



    End Sub








    Private Sub PartsConsumtionReportShow()
        Dim cs As String = System.Configuration.ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim rptTempPartsConsumtionReport As New rptSparePartsConsumption
        Dim strSQLPartsConsumtion As String = String.Empty
        Dim conPartsConsumtion As New OleDbConnection(cs)
        Dim dt As DataTable = New DataTable



        Try
            If blnSalesWarrPrice = True Then
                strSQLPartsConsumtion = "Select Claiminfo.JobCode,Claiminfo.Branch,Claiminfo.ServiceType,Claiminfo.Brand,Claiminfo.ModelNo,Claiminfo.Wcondition,Claiminfo.Cflag,ServiceDetailsDetails.ProductCode,Product.ProdName,ServiceDetailsDetails.qty,ServiceDetailsDetails.UnitPrice,ServiceDetailsDetails.Remarks,(ServiceDetailsDetails.qty*ServiceDetailsDetails.UnitPrice) as TotalAmount from Claiminfo inner Join (ServiceDetailsDetails Left Join Product on ServiceDetailsDetails.ProductCOde=Product.Code) on Claiminfo.JobCode=ServiceDetailsDetails.JobCode  Where " & strSQLCriteria & " Order by Claiminfo.JobCode"

            Else
                ' strSQLPartsConsumtion = "Select Claiminfo.JobCode,Claiminfo.Branch,Claiminfo.ServiceType,Claiminfo.Brand,Claiminfo.ModelNo,Claiminfo.Wcondition,Claiminfo.Cflag,ServiceDetails.ProductCode,Product.ProdName,ServiceDetails.qty,ServiceDetails.UnitPrice,ServiceDetails.Remarks,iif(Claiminfo.Wcondition=0 or Claiminfo.Wcondition=2,0,(ServiceDetails.qty*ServiceDetails.UnitPrice)) as TotalAmount from Claiminfo inner Join (ServiceDetails Left Join Product on ServiceDetails.ProductCOde=Product.Code) on Claiminfo.JobCode=Servicedetails.JobCode  Where " & strSQLCriteria

                strSQLPartsConsumtion = "Select Claiminfo.JobCode,Claiminfo.Branch,Claiminfo.ServiceType,Claiminfo.Brand,Claiminfo.ModelNo,Claiminfo.Wcondition,Claiminfo.Cflag,ServiceDetailsDetails.ProductCode,Product.ProdName,ServiceDetailsDetails.qty,ServiceDetailsDetails.UnitPrice,ServiceDetailsDetails.Remarks from Claiminfo inner Join (ServiceDetailsDetails Left Join Product on ServiceDetailsDetails.ProductCode=Product.ProdName ) on Claiminfo.JobCode=ServiceDetailsDetails.JobCode  Where " & strSQLCriteria & " Order by Claiminfo.JobCode"





                Using con As OleDbConnection = New OleDbConnection(cs)
                    Dim dcPCR As OleDbCommand = New OleDbCommand(strSQLPartsConsumtion, con) 'Parts Consumption

                    con.Open()

                    Dim drGetPart As OleDbDataReader = dcPCR.ExecuteReader

                    dt.Load(drGetPart)

                End Using






            End If




            Dim daPartsConsumtion As New OleDbDataAdapter(strSQLPartsConsumtion, conPartsConsumtion)

            Dim dsPartsConsumtion As New DataSet





            daPartsConsumtion.Fill(dsPartsConsumtion, "PartsConsumption")

            rptTempPartsConsumtionReport.SetDataSource(dt)

            DirectCast(rptTempPartsConsumtionReport.ReportDefinition.ReportObjects("txtCompanyTitle"), TextObject).Text = strCompanyTitle

            If ReportIdentification = UCase("Parts Consumption Repair") Then
                DirectCast(rptTempPartsConsumtionReport.ReportDefinition.ReportObjects("txtReportTitle"), TextObject).Text = "Spare Parts Consumption (Repair)"
            Else
                DirectCast(rptTempPartsConsumtionReport.ReportDefinition.ReportObjects("txtReportTitle"), TextObject).Text = "Spare Parts Consumption (Delivery)"
            End If






            DirectCast(rptTempPartsConsumtionReport.ReportDefinition.ReportObjects("txtDateFrom"), TextObject).Text = dtStartDate.ToShortDateString
            DirectCast(rptTempPartsConsumtionReport.ReportDefinition.ReportObjects("txtDateTo"), TextObject).Text = dtEndDate.ToShortDateString



            crvReportShow.ReportSource = rptTempPartsConsumtionReport

            crvReportShow.Refresh()







        Catch exSummary As Exception
            MessageBox.Show(exSummary.Message)
        End Try






    End Sub





    Private Sub PartsConsumtionSummeryReportShow()
        Dim rptTempPartsConsumtionSummeryReport As New rptSparePartsConsumptionSummery
        Dim strSQLPartsConsumtionSummery As String = String.Empty
        Dim conPartsConsumtionSummery As New OleDbConnection(strProvider)



        If blnSalesWarrPrice = True Then
            strSQLPartsConsumtionSummery = "Select ServiceDetailsDetails.ProductCode,Product.ProdName,sum(ServiceDetailsDetails.qty) as Qty, sum(ServiceDetailsDetails.UnitPrice) as UnitPrice ,ServiceDetailsDetails.Remarks,sum((ServiceDetailsDetails.qty*ServiceDetailsDetails.UnitPrice)) as TotalAmount from Claiminfo inner Join (ServiceDetailsDetails Left Join Product on ServiceDetailsDetails.ProductCOde=Product.Code) on Claiminfo.JobCode=ServiceDetailsDetails.JobCode  Where " & strSQLCriteria & " Group By  ServiceDetailsDetails.ProductCode,Product.ProdName,ServiceDetailsDetails.Remarks Order by Claiminfo.JobCode"
        Else
            strSQLPartsConsumtionSummery = "Select ServiceDetailsDetails.ProductCode,Product.ProdName,sum(iif(Claiminfo.Wcondition=0 or Claiminfo.Wcondition=2, 0,ServiceDetailsDetails.Qty)) as Qty,sum(iif(Claiminfo.Wcondition=0 or Claiminfo.Wcondition=2, 0,ServiceDetailsDetails.UnitPrice)) as UnitPrice ,ServiceDetailsDetails.Remarks,sum(iif(Claiminfo.Wcondition=0 or Claiminfo.Wcondition=2, 0,ServiceDetailsDetails.qty * ServiceDetailsDetails.UnitPrice)) as TotalAmount from Claiminfo inner Join (ServiceDetailsDetails Left Join Product on ServiceDetailsDetails.ProductCOde=Product.Code) on Claiminfo.JobCode=ServiceDetailsDetails.JobCode  Where " & strSQLCriteria & " Group By ServiceDetailsDetails.ProductCode,Product.ProdName,ServiceDetailsDetails.Remarks Order by Claiminfo.JobCode"


        End If




        Dim daPartsConsumtion As New OleDbDataAdapter(strSQLPartsConsumtionSummery, conPartsConsumtionSummery)

        Dim dsPartsConsumtion As New DataSet

        Try


            daPartsConsumtion.Fill(dsPartsConsumtion, "PartsConsumptionSummery")

            rptTempPartsConsumtionSummeryReport.SetDataSource(dsPartsConsumtion.Tables(0))

            DirectCast(rptTempPartsConsumtionSummeryReport.ReportDefinition.ReportObjects("txtCompanyTitle"), TextObject).Text = strCompanyTitle

            If ReportIdentification = UCase("Parts Consumption Summery Repair") Then
                DirectCast(rptTempPartsConsumtionSummeryReport.ReportDefinition.ReportObjects("txtReportTitle"), TextObject).Text = "Spare Parts Consumption Summery (Repair)"
            Else
                DirectCast(rptTempPartsConsumtionSummeryReport.ReportDefinition.ReportObjects("txtReportTitle"), TextObject).Text = "Spare Parts Consumption Summery (Delivery)"
            End If






            DirectCast(rptTempPartsConsumtionSummeryReport.ReportDefinition.ReportObjects("txtDateFrom"), TextObject).Text = dtStartDate.ToShortDateString
            DirectCast(rptTempPartsConsumtionSummeryReport.ReportDefinition.ReportObjects("txtDateTo"), TextObject).Text = dtEndDate.ToShortDateString



            crvReportShow.ReportSource = rptTempPartsConsumtionSummeryReport
            crvReportShow.Refresh()



        Catch exSummary As Exception
            MessageBox.Show(exSummary.Message)
        End Try






    End Sub



    Private Sub TechnicianPerformanceReportShow()
        Dim rptTempTechnicianPeroformanceReport As New rptTechnicianPerformanceDetails
        Dim strSQLTechnicianPeroformance As String = String.Empty
        Dim conTechnicianPeroformance As New OleDbConnection(strProvider)




        strSQLTechnicianPeroformance = "Select (Personal.EmpName & ' (' & Claiminfo.Issueto & ')' ) as TechinicianName,Claiminfo.Servicetype as Category, count(Claiminfo.Issueto) as TotalAssign, sum(iif(Claiminfo.Wcondition=0,1,0)) as Sls, sum(iif(Claiminfo.Wcondition=1,1,0)) as Non, sum(iif(Claiminfo.Wcondition=2,1,0)) as svc, sum(iif(Claiminfo.cflag=1,1,0)) as Rep, sum(iif(Claiminfo.cflag=0 or Claiminfo.cflag=2,1,0)) as Del, sum(iif(Claiminfo.cflag=9,1,0)) as Pending, sum(iif(Claiminfo.cflag=99 or Claiminfo.cflag=100,1,0)) as NR, sum(iif(not isnull(Claiminfo.Issueto) and isnull(Claiminfo.sdate),1,0)) as Unp from Claiminfo Left Join Personal on Claiminfo.Issueto=Personal.empCode  Where " & strSQLCriteria & " Group by  Claiminfo.Issueto,Personal.EmpName,Claiminfo.Servicetype Order by Claiminfo.JobCode, Claiminfo.Issueto"





        Dim daTechnicianPeroformance As New OleDbDataAdapter(strSQLTechnicianPeroformance, conTechnicianPeroformance)

        Dim dsTechnicianPeroformance As New DataSet

        Try


            daTechnicianPeroformance.Fill(dsTechnicianPeroformance, "PartsConsumptionSummery")

            rptTempTechnicianPeroformanceReport.SetDataSource(dsTechnicianPeroformance.Tables(0))

            DirectCast(rptTempTechnicianPeroformanceReport.ReportDefinition.ReportObjects("txtCompanyTitle"), TextObject).Text = strCompanyTitle


            DirectCast(rptTempTechnicianPeroformanceReport.ReportDefinition.ReportObjects("txtReportTitle"), TextObject).Text = "Technician Performance Report (Details)"







            DirectCast(rptTempTechnicianPeroformanceReport.ReportDefinition.ReportObjects("txtDateFrom"), TextObject).Text = dtStartDate.ToShortDateString
            DirectCast(rptTempTechnicianPeroformanceReport.ReportDefinition.ReportObjects("txtDateTo"), TextObject).Text = dtEndDate.ToShortDateString



            crvReportShow.ReportSource = rptTempTechnicianPeroformanceReport
            crvReportShow.Refresh()



        Catch exSummary As Exception
            MessageBox.Show(exSummary.Message)
        End Try






    End Sub






    Private Sub TechnicianPerformanceReportSummery()
        Dim rptTempTechnicianPeroformanceReportSummery As New rptTechnicianPerformanceSummery
        Dim strSQLTechnicianPeroformanceSummery As String = String.Empty
        Dim conTechnicianPeroformanceSummery As New OleDbConnection(strProvider)




        strSQLTechnicianPeroformanceSummery = "Select (Personal.EmpName & ' (' & Claiminfo.Issueto & ')' ) as TechinicianName, count(Claiminfo.Issueto) as TotalAssign, sum(iif(Claiminfo.Wcondition=0,1,0)) as Sls, sum(iif(Claiminfo.Wcondition=1,1,0)) as Non, sum(iif(Claiminfo.Wcondition=2,1,0)) as svc, sum(iif(Claiminfo.cflag=1,1,0)) as Rep, sum(iif(Claiminfo.cflag=0 or Claiminfo.cflag=2,1,0)) as Del, sum(iif(Claiminfo.cflag=9,1,0)) as Pending, sum(iif(Claiminfo.cflag=99 or Claiminfo.cflag=100,1,0)) as NR, sum(iif(not isnull(Claiminfo.Issueto) and isnull(Claiminfo.sdate),1,0)) as Unp from Claiminfo Left Join Personal on Claiminfo.Issueto=Personal.empCode  Where " & strSQLCriteria & " Group by  Claiminfo.Issueto,Personal.EmpName Order by Claiminfo.JobCode, Claiminfo.Issueto"





        Dim daTechnicianPeroformanceSummery As New OleDbDataAdapter(strSQLTechnicianPeroformanceSummery, conTechnicianPeroformanceSummery)

        Dim dsTechnicianPeroformanceSummery As New DataSet

        Try


            daTechnicianPeroformanceSummery.Fill(dsTechnicianPeroformanceSummery, "PartsConsumptionSummery")

            rptTempTechnicianPeroformanceReportSummery.SetDataSource(dsTechnicianPeroformanceSummery.Tables(0))

            DirectCast(rptTempTechnicianPeroformanceReportSummery.ReportDefinition.ReportObjects("txtCompanyTitle"), TextObject).Text = strCompanyTitle


            DirectCast(rptTempTechnicianPeroformanceReportSummery.ReportDefinition.ReportObjects("txtReportTitle"), TextObject).Text = "Technician Performance Report (Summery)"







            DirectCast(rptTempTechnicianPeroformanceReportSummery.ReportDefinition.ReportObjects("txtDateFrom"), TextObject).Text = dtStartDate.ToShortDateString
            DirectCast(rptTempTechnicianPeroformanceReportSummery.ReportDefinition.ReportObjects("txtDateTo"), TextObject).Text = dtEndDate.ToShortDateString



            crvReportShow.ReportSource = rptTempTechnicianPeroformanceReportSummery
            crvReportShow.Refresh()



        Catch exSummary As Exception
            MessageBox.Show(exSummary.Message)
        End Try






    End Sub



    Private Sub TechnicianPerformanceReportTimeElapsed()
        Dim rptTempTechnicianPeroformanceReportTimeElapsed As New rptTechnicianPerformanceTimeElapsed

        Dim strSQLTechnicianPeroformanceTimeElapsed As String = String.Empty
        Dim conTechnicianPeroformanceTimeElapsed As New OleDbConnection(strProvider)




        strSQLTechnicianPeroformanceTimeElapsed = "Select (Personal.EmpName & ' (' & Claiminfo.Issueto & ')' ) as TechinicianName, count(Claiminfo.Issueto) as TotalAssign, 
Sum(iif(Claiminfo.Sdate-Claiminfo.IsssueDate>-1,Claiminfo.Sdate-Claiminfo.IsssueDate+1,0)) as Tat, 

sum(iif( Claiminfo.Sdate-Claiminfo.IsssueDate<0,1,0)) as Irrelevant, 
sum(iif( Claiminfo.Sdate-Claiminfo.IsssueDate>-1 and Claiminfo.Sdate-Claiminfo.IsssueDate<=5,1,0)) as 1to5, 
sum(iif(Claiminfo.Sdate-Claiminfo.IsssueDate>5 and Claiminfo.Sdate-Claiminfo.IsssueDate<11,1,0)) as 1to10,
sum(iif(Claiminfo.Sdate-Claiminfo.IsssueDate>10 and Claiminfo.Sdate-Claiminfo.IsssueDate<16,1,0)) as 1to15,
sum(iif(Claiminfo.Sdate-Claiminfo.IsssueDate>15 and Claiminfo.Sdate-Claiminfo.IsssueDate<21,1,0)) as 1to20,
sum(iif(Claiminfo.Sdate-Claiminfo.IsssueDate>20 and Claiminfo.Sdate-Claiminfo.IsssueDate<26,1,0)) as 1to25,
sum(iif(Claiminfo.Sdate-Claiminfo.IsssueDate>25 and Claiminfo.Sdate-Claiminfo.IsssueDate<31,1,0)) as 1to30, 
sum(iif(Claiminfo.Sdate-Claiminfo.IsssueDate>30,1,0)) as Over30   
from Claiminfo Left Join Personal on Claiminfo.Issueto=Personal.empCode  Where " & strSQLCriteria & " Group by  Claiminfo.Issueto,
Personal.EmpName Order by Claiminfo.JobCOde, Claiminfo.Issueto"





        Dim daTechnicianPeroformanceTimeElapsed As New OleDbDataAdapter(strSQLTechnicianPeroformanceTimeElapsed, conTechnicianPeroformanceTimeElapsed)

        Dim dsTechnicianPeroformanceTimeElapsed As New DataSet

        Try


            daTechnicianPeroformanceTimeElapsed.Fill(dsTechnicianPeroformanceTimeElapsed, "TechnicianPeroformanceTimeElapsed")

            rptTempTechnicianPeroformanceReportTimeElapsed.SetDataSource(dsTechnicianPeroformanceTimeElapsed.Tables(0))

            DirectCast(rptTempTechnicianPeroformanceReportTimeElapsed.ReportDefinition.ReportObjects("txtCompanyTitle"), TextObject).Text = strCompanyTitle


            DirectCast(rptTempTechnicianPeroformanceReportTimeElapsed.ReportDefinition.ReportObjects("txtReportTitle"), TextObject).Text = "Technician Performance Report (Average)"







            DirectCast(rptTempTechnicianPeroformanceReportTimeElapsed.ReportDefinition.ReportObjects("txtDateFrom"), TextObject).Text = dtStartDate.ToShortDateString
            DirectCast(rptTempTechnicianPeroformanceReportTimeElapsed.ReportDefinition.ReportObjects("txtDateTo"), TextObject).Text = dtEndDate.ToShortDateString



            crvReportShow.ReportSource = rptTempTechnicianPeroformanceReportTimeElapsed
            crvReportShow.Refresh()



        Catch exSummary As Exception
            MessageBox.Show(exSummary.Message)
        End Try






    End Sub




    Private Sub ReceiveSummeryReport()
        Dim rptReciveSummeryReport As New rptReceiveSummery
        Dim frmTemp As New frmMaster_information

        Dim strSQLReciveSummeryReport As String = String.Empty
        Dim conReciveSummeryReport As New OleDbConnection(strProvider)
        'Dim intDate As Date = dtEndDate - dtStartDate

        DirectCast(rptReciveSummeryReport.ReportDefinition.ReportObjects("Text1"), TextObject).Text = ""
        DirectCast(rptReciveSummeryReport.ReportDefinition.ReportObjects("Text4"), TextObject).Text = ""
        DirectCast(rptReciveSummeryReport.ReportDefinition.ReportObjects("Text5"), TextObject).Text = ""
        DirectCast(rptReciveSummeryReport.ReportDefinition.ReportObjects("txtSlsWarr"), TextObject).Text = "SLS WARR"
        DirectCast(rptReciveSummeryReport.ReportDefinition.ReportObjects("txtNonWarr"), TextObject).Text = "NON WARR"
        DirectCast(rptReciveSummeryReport.ReportDefinition.ReportObjects("txtSvcWarr"), TextObject).Text = "SVC WARR"


        If ReportIdentification = UCase("Receive Summery Branch Wise") Or ReportIdentification = UCase("Repaired Summery Branch Wise") Or ReportIdentification = UCase("Delivered Summery Branch Wise") Then
            strSQLReciveSummeryReport = "Select Claiminfo.Branch as fs1,sum(iif(CLaiminfo.Wcondition=0,1,0)) as Fint2,sum(iif(CLaiminfo.Wcondition=1,1,0)) as Fint3,sum(iif(CLaiminfo.Wcondition=2,1,0)) as Fint4, count(Claiminfo.JobCode) as fint1, count(Claiminfo.JobCode)/" & dtEndDate.Subtract(dtStartDate).Days + 1 & " as fdbl1 from Claiminfo where " & strSQLCriteria & " Group by  Claiminfo.Branch order by Claiminfo.Branch"
            DirectCast(rptReciveSummeryReport.ReportDefinition.ReportObjects("Text1"), TextObject).Text = "Branch"
            DirectCast(rptReciveSummeryReport.ReportDefinition.ReportObjects("Text4"), TextObject).Text = "Qty"
            DirectCast(rptReciveSummeryReport.ReportDefinition.ReportObjects("Text5"), TextObject).Text = "Avg (Per Day)"
            If ReportIdentification = UCase("Receive Summery Branch Wise") Then
                DirectCast(rptReciveSummeryReport.ReportDefinition.ReportObjects("txtReportTitle"), TextObject).Text = "Summery Statement on Receive (Branch Wise)"
            ElseIf ReportIdentification = UCase("Repaired Summery Branch Wise") Then
                DirectCast(rptReciveSummeryReport.ReportDefinition.ReportObjects("txtReportTitle"), TextObject).Text = "Summery Statement on Repair (Branch Wise)"
            ElseIf ReportIdentification = UCase("Delivered Summery Branch Wise") Then
                DirectCast(rptReciveSummeryReport.ReportDefinition.ReportObjects("txtReportTitle"), TextObject).Text = "Summery Statement on Delivery (Branch Wise)"
            End If
        ElseIf ReportIdentification = UCase("Receive Summery Brand Wise") Or ReportIdentification = UCase("Repaired Summery Brand Wise") Or ReportIdentification = UCase("Delivered Summery Brand Wise") Then
            strSQLReciveSummeryReport = "Select Claiminfo.Brand as fs1,sum(iif(CLaiminfo.Wcondition=0,1,0)) as Fint2,sum(iif(CLaiminfo.Wcondition=1,1,0)) as Fint3,sum(iif(CLaiminfo.Wcondition=2,1,0)) as Fint4, count(Claiminfo.JobCode) as fint1, count(Claiminfo.JobCode)/" & dtEndDate.Subtract(dtStartDate).Days + 1 & " as fdbl1 from Claiminfo where " & strSQLCriteria & " Group by  Claiminfo.Brand order by Claiminfo.Brand"

            DirectCast(rptReciveSummeryReport.ReportDefinition.ReportObjects("Text1"), TextObject).Text = "Brand"
            DirectCast(rptReciveSummeryReport.ReportDefinition.ReportObjects("Text4"), TextObject).Text = "Qty"
            DirectCast(rptReciveSummeryReport.ReportDefinition.ReportObjects("Text5"), TextObject).Text = "Avg (Per Day)"
            If ReportIdentification = UCase("Receive Summery Brand Wise") Then
                DirectCast(rptReciveSummeryReport.ReportDefinition.ReportObjects("txtReportTitle"), TextObject).Text = "Summery Statement on Receive (Brand Wise)"
            ElseIf ReportIdentification = UCase("Repaired Summery Brand Wise") Then
                DirectCast(rptReciveSummeryReport.ReportDefinition.ReportObjects("txtReportTitle"), TextObject).Text = "Summery Statement on Repair (Brand Wise)"
            ElseIf ReportIdentification = UCase("Delivered Summery Brand Wise") Then
                DirectCast(rptReciveSummeryReport.ReportDefinition.ReportObjects("txtReportTitle"), TextObject).Text = "Summery Statement on Delivery (Brand Wise)"
            End If

        ElseIf ReportIdentification = UCase("Receive Summery Category Wise") Or ReportIdentification = UCase("Repaired Summery Category Wise") Or ReportIdentification = UCase("Delivered Summery Category Wise") Then
            strSQLReciveSummeryReport = "Select Claiminfo.ServiceType as fs1,sum(iif(CLaiminfo.Wcondition=0,1,0)) as Fint2,sum(iif(CLaiminfo.Wcondition=1,1,0)) as Fint3,sum(iif(CLaiminfo.Wcondition=2,1,0)) as Fint4, count(Claiminfo.JobCode) as fint1, count(Claiminfo.JobCode)/" & dtEndDate.Subtract(dtStartDate).Days + 1 & " as fdbl1 from Claiminfo where " & strSQLCriteria & " Group by  Claiminfo.ServiceType Order by Claiminfo.ServiceType"

            DirectCast(rptReciveSummeryReport.ReportDefinition.ReportObjects("Text1"), TextObject).Text = "Category"
            DirectCast(rptReciveSummeryReport.ReportDefinition.ReportObjects("Text4"), TextObject).Text = "Qty"
            DirectCast(rptReciveSummeryReport.ReportDefinition.ReportObjects("Text5"), TextObject).Text = "Avg (Per Day)"

            If ReportIdentification = UCase("Receive Summery Category Wise") Then
                DirectCast(rptReciveSummeryReport.ReportDefinition.ReportObjects("txtReportTitle"), TextObject).Text = "Summery Statement on Receive (Category Wise)"
            ElseIf ReportIdentification = UCase("Repaired Summery Category Wise") Then
                DirectCast(rptReciveSummeryReport.ReportDefinition.ReportObjects("txtReportTitle"), TextObject).Text = "Summery Statement on Repair (Category Wise)"
            ElseIf ReportIdentification = UCase("Delivered Summery Category Wise") Then
                DirectCast(rptReciveSummeryReport.ReportDefinition.ReportObjects("txtReportTitle"), TextObject).Text = "Summery Statement on Delivery (Category Wise)"
            End If

        ElseIf ReportIdentification = UCase("Receive Summery Model Wise") Or ReportIdentification = UCase("Repaired Summery Model Wise") Or ReportIdentification = UCase("Delivered Summery Model Wise") Then
            strSQLReciveSummeryReport = "Select Claiminfo.ModelNo as fs1,sum(iif(CLaiminfo.Wcondition=0,1,0)) as Fint2,sum(iif(CLaiminfo.Wcondition=1,1,0)) as Fint3,sum(iif(CLaiminfo.Wcondition=2,1,0)) as Fint4, count(Claiminfo.JobCode) as fint1, count(Claiminfo.JobCode)/" & dtEndDate.Subtract(dtStartDate).Days + 1 & " as fdbl1 from Claiminfo where " & strSQLCriteria & " Group by  Claiminfo.ModelNo Order by Claiminfo.ModelNo"
            DirectCast(rptReciveSummeryReport.ReportDefinition.ReportObjects("Text1"), TextObject).Text = "Category"
            DirectCast(rptReciveSummeryReport.ReportDefinition.ReportObjects("Text4"), TextObject).Text = "Qty"
            DirectCast(rptReciveSummeryReport.ReportDefinition.ReportObjects("Text5"), TextObject).Text = "Avg (Per Day)"
            If ReportIdentification = UCase("Receive Summery Model Wise") Then
                DirectCast(rptReciveSummeryReport.ReportDefinition.ReportObjects("txtReportTitle"), TextObject).Text = "Summery Statement on Receive (Model Wise)"
            ElseIf ReportIdentification = UCase("Repaired Summery Model Wise") Then
                DirectCast(rptReciveSummeryReport.ReportDefinition.ReportObjects("txtReportTitle"), TextObject).Text = "Summery Statement on Repair (Model Wise)"
            ElseIf ReportIdentification = UCase("Delivered Summery Model Wise") Then
                DirectCast(rptReciveSummeryReport.ReportDefinition.ReportObjects("txtReportTitle"), TextObject).Text = "Summery Statement on Delivery (Model Wise)"
            End If


        ElseIf ReportIdentification = UCase("Service Collection Branch") Then ' Service Collection Branch Wise
            strSQLReciveSummeryReport = "SELECT CL.Branch as fs1, 0 as fint2, Cl.Amount as fint3, cs.CsAmnt as fint4, clng(iif(count(cl.Branch)=count(cs.csBranch),Cl.Amount+ cs.CsAmnt,iif(count(cl.branch)>count(cs.csbranch),cl.amount,cs.csamnt))) as Fint1, clng(iif(count(cl.Branch)=count(cs.csBranch),Cl.Amount+ cs.CsAmnt,iif(count(cl.branch)>count(cs.csbranch),cl.amount,cs.csamnt)))/ " & dtEndDate.Subtract(dtStartDate).Days + 1 & " as fdbl1
FROM [SELECT Branch.Branch,  Sum(Claiminfo.svamt+Claiminfo.prdamt+Claiminfo.otheramt-(Claiminfo.Dis+Claiminfo.Advanceamnt)) As Amount
From Claiminfo Right Join Branch On Claiminfo.Branch=Branch.Branch
Where " & strSQLCriteria & " And Claiminfo.FreeOfCost=0 And Claiminfo.MrNo<>'' and BRanch.Flag=-1
Group By Branch.Branch]. AS cl LEFT Join [Select Cashsales.Branch As csBranch,sum(Cashsales.Qty*Cashsales.Rate-(Cashsales.Dis)) as CsAmnt From Cashsales Where Cashsales.ReceptDate between #" & dtStartDate & "# And #" & dtEndDate & "# group by  Cashsales.Branch]. As Cs On cl.Branch= cs.csbranch group by CL.Branch, Cl.Amount , cs.CsAmnt"
            DirectCast(rptReciveSummeryReport.ReportDefinition.ReportObjects("Text1"), TextObject).Text = "Branch"
            DirectCast(rptReciveSummeryReport.ReportDefinition.ReportObjects("Text4"), TextObject).Text = "Total Income"
            DirectCast(rptReciveSummeryReport.ReportDefinition.ReportObjects("Text5"), TextObject).Text = "Avg (Per Day)"
            DirectCast(rptReciveSummeryReport.ReportDefinition.ReportObjects("txtSlsWarr"), TextObject).Text = ""
            DirectCast(rptReciveSummeryReport.ReportDefinition.ReportObjects("txtNonWarr"), TextObject).Text = "Collection"
            DirectCast(rptReciveSummeryReport.ReportDefinition.ReportObjects("txtSvcWarr"), TextObject).Text = "Cash Sales"
            DirectCast(rptReciveSummeryReport.ReportDefinition.ReportObjects("txtReportTitle"), TextObject).Text = "Service Collection"

            DirectCast(rptReciveSummeryReport.ReportDefinition.ReportObjects("txtTotal3"), TextObject).Text = "Cash Sale"
            DirectCast(rptReciveSummeryReport.ReportDefinition.ReportObjects("txtTotalName2"), TextObject).Text = ""
            DirectCast(rptReciveSummeryReport.ReportDefinition.ReportObjects("txtTotal2"), TextObject).Text = "Collection"

            'rptReciveSummeryReport.DataDefinition.FormulaFields("txtTotal3").Text = "Cash Sale"
            'rptReciveSummeryReport.DataDefinition.FormulaFields("txtTotalName2").Text = ""
            'rptReciveSummeryReport.DataDefinition.FormulaFields("txtTotal2").Text = "Service Collection"


        End If




        Dim daReciveSummeryReport As New OleDbDataAdapter(strSQLReciveSummeryReport, conReciveSummeryReport)

        Dim dsReciveSummeryReport As New DataSet

        Try


            daReciveSummeryReport.Fill(dsReciveSummeryReport, "TechnicianPeroformanceTimeElapsed")

            rptReciveSummeryReport.SetDataSource(dsReciveSummeryReport.Tables(0))

            DirectCast(rptReciveSummeryReport.ReportDefinition.ReportObjects("txtCompanyTitle"), TextObject).Text = strCompanyTitle










            DirectCast(rptReciveSummeryReport.ReportDefinition.ReportObjects("txtDateFrom"), TextObject).Text = dtStartDate.ToShortDateString
            DirectCast(rptReciveSummeryReport.ReportDefinition.ReportObjects("txtDateTo"), TextObject).Text = dtEndDate.ToShortDateString



            crvReportShow.ReportSource = rptReciveSummeryReport
            crvReportShow.Refresh()



        Catch exSummary As Exception
            MessageBox.Show(exSummary.Message)
        End Try






    End Sub


    Private Sub ClaimSlipReport()
        Dim claimSlip As New rptClaimSlip



        Try

            Dim claiminfomethods As clsClaiminfoMethods = New clsClaiminfoMethods

            Dim claiminfo As clsClaiminfo = claiminfomethods.LoadClaiminfo_byJobCode(strClaimSlipJobCode)


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
                    DirectCast(.ReportDefinition.ReportObjects("txtJobCode"), TextObject).Text = "Job No : " & claiminfo.Jobcode
                    DirectCast(.ReportDefinition.ReportObjects("txtCustomerName"), TextObject).Text = claiminfo.CustName
                    DirectCast(.ReportDefinition.ReportObjects("txtCustomerAddress"), TextObject).Text = claiminfo.CustAddress1
                    DirectCast(.ReportDefinition.ReportObjects("txtCustomerContact"), TextObject).Text = claiminfo.CustAddress2
                    DirectCast(.ReportDefinition.ReportObjects("txtCustomerEmail"), TextObject).Text = claiminfo.Email
                    DirectCast(.ReportDefinition.ReportObjects("txtCategory"), TextObject).Text = claiminfo.ServiceType
                    DirectCast(.ReportDefinition.ReportObjects("txtBrand"), TextObject).Text = claiminfo.Brand
                    DirectCast(.ReportDefinition.ReportObjects("txtModel"), TextObject).Text = claiminfo.ModelNo
                    DirectCast(.ReportDefinition.ReportObjects("txtSerial"), TextObject).Text = claiminfo.SLNo

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
                    ElseIf claiminfo.WCondition = Integer.Parse("1") Then
                        DirectCast(.ReportDefinition.ReportObjects("txtWarrantyType"), TextObject).Text = "On-Payment"
                    Else
                        DirectCast(.ReportDefinition.ReportObjects("txtWarrantyType"), TextObject).Text = "Svc-Payment"
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
                        DirectCast(.ReportDefinition.ReportObjects("txtFault"), TextObject).Text = csclaim.ClaimCode.ToLower
                    End If



                End With








                crvReportShow.ReportSource = claimSlip
                crvReportShow.Refresh()


                claimSlip = Nothing

            Else
                MessageBox.Show("No jobCode Is Found")

            End If

        Catch exSummary As Exception
            MessageBox.Show(exSummary.Message)
        End Try






    End Sub



    Private Sub CashSalesDetails()
        Dim ReportCashsalesDetails As New rptCashSalesDetails
        Try
            Dim cm As clsCashsalesMethods = New clsCashsalesMethods

            Dim dt As DataTable = cm.GetCashsales(dtStartDate, dtEndDate, strSQLCriteria)

            DirectCast(ReportCashsalesDetails.ReportDefinition.ReportObjects("txtCompanyTitle"), TextObject).Text = strCompanyTitle
            DirectCast(ReportCashsalesDetails.ReportDefinition.ReportObjects("txtFromDate"), TextObject).Text = dtStartDate
            DirectCast(ReportCashsalesDetails.ReportDefinition.ReportObjects("txtToDate"), TextObject).Text = dtEndDate

            crvReportShow.ReportSource = Nothing

            If dt.Rows.Count <= 0 Then

                MessageBox.Show("No Record Found")
                Me.Close()

            Else

                ReportCashsalesDetails.SetDataSource(dt)

                crvReportShow.ReportSource = ReportCashsalesDetails


            End If

            crvReportShow.Refresh()





        Catch exSummary As Exception
            MessageBox.Show(exSummary.Message)
        End Try
    End Sub


    Private Sub CashSalesSummery()
        Dim ReportCashsalesDetails As New rptCashSalesSummery
        Try
            Dim cm As clsCashsalesMethods = New clsCashsalesMethods

            Dim dt As DataTable = cm.GetCashsalesSummeryReport(dtStartDate, dtEndDate, strSQLCriteria)

            DirectCast(ReportCashsalesDetails.ReportDefinition.ReportObjects("txtCompanyTitle"), TextObject).Text = strCompanyTitle
            DirectCast(ReportCashsalesDetails.ReportDefinition.ReportObjects("txtFromDate"), TextObject).Text = dtStartDate
            DirectCast(ReportCashsalesDetails.ReportDefinition.ReportObjects("txtToDate"), TextObject).Text = dtEndDate
            DirectCast(ReportCashsalesDetails.ReportDefinition.ReportObjects("txtToDate"), TextObject).Text = dtEndDate


            DirectCast(ReportCashsalesDetails.ReportDefinition.ReportObjects("txtBranch"), TextObject).Text = strBranchName
            DirectCast(ReportCashsalesDetails.ReportDefinition.ReportObjects("txtCategory"), TextObject).Text = strCategory
            DirectCast(ReportCashsalesDetails.ReportDefinition.ReportObjects("txtBrand"), TextObject).Text = strBrandName
            DirectCast(ReportCashsalesDetails.ReportDefinition.ReportObjects("txtModel"), TextObject).Text = strModel
            If dt.Rows.Count > 0 Then
                ReportCashsalesDetails.SetDataSource(dt)
                crvReportShow.ReportSource = ReportCashsalesDetails
            Else
                MessageBox.Show("No Record Found")
                crvReportShow.Dispose()
                Me.Close()
            End If

            crvReportShow.Refresh()
        Catch exSummary As Exception
            MessageBox.Show(exSummary.Message)
        End Try
    End Sub



    Private Sub TechnicianReport()
        Dim rpTech As New rptTechnicianReport
        Dim strsql As String = String.Empty
        Dim dt As DataTable = New DataTable


        Try


            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

            strsql = "SELECT Personal.EmpName, claiminfo.serviceby, claiminfo.Branch, format(claiminfo.sdate,'MMM-YY') AS sdate, count(claiminfo.JobCode) AS TotalRepair
FROM claiminfo LEFT JOIN personal ON claiminfo.serviceby=personal.empcode
WHERE claiminfo.cflag Not In (-1,9) And claiminfo.sdate Between #1/1/2011# And #1/31/2019#
GROUP BY Personal.EmpName, claiminfo.serviceby, claiminfo.Branch, format(claiminfo.sdate,'MMM-YY')
ORDER BY claiminfo.serviceby"


            Using con As OleDbConnection = New OleDbConnection(cs)


                Dim dcTechReport As OleDbCommand = New OleDbCommand(strsql, con)
                dcTechReport.CommandType = CommandType.Text
                con.Open()

                Dim drTechReport As OleDbDataReader = dcTechReport.ExecuteReader


                If drTechReport.HasRows = True Then

                    dt.Load(drTechReport)

                End If



                'For Each dtrow As DataRow In dt.Rows

                '    MessageBox.Show(dtrow("Sdate").ToString)

                'Next


                'Exit Sub




            End Using


            rpTech.SetDataSource(dt)




            crvReportShow.ReportSource = rpTech
            crvReportShow.Refresh()
        Catch exSummary As Exception
            MessageBox.Show(exSummary.Message)
        End Try
    End Sub

    Private Sub PresentStockALL()

        Dim PresentStockReport As rptPresentStock = New rptPresentStock
        Dim PresentStockMethods As clsPresentStockMethods = New clsPresentStockMethods

        PresentStockMethods.DeleteAll()

        PresentStockMethods.InsertPresentStock("-1", "ALL")
        PresentStockMethods.InsertPresentStock("1", "ALL")
        PresentStockMethods.InsertPresentStock("9", "ALL")
        PresentStockMethods.InsertPresentStock("99", "ALL")
        DirectCast(PresentStockReport.ReportDefinition.ReportObjects("txtBranch"), TextObject).Text = "ALL"
        DirectCast(PresentStockReport.ReportDefinition.ReportObjects("txtBrand"), TextObject).Text = "ALL"
        DirectCast(PresentStockReport.ReportDefinition.ReportObjects("txtCategory"), TextObject).Text = "ALL"







        DirectCast(PresentStockReport.ReportDefinition.ReportObjects("txtCompanyTitle"), TextObject).Text = strCompanyTitle




        Dim listPresentStock As List(Of clsPresentStock) = PresentStockMethods.GetAllPresentStock.ToList
        PresentStockReport.SetDataSource(listPresentStock)


        crvReportShow.ReportSource = PresentStockReport
        crvReportShow.Refresh()



    End Sub

    Private Sub PresentStock()

        Dim PresentStockReport As rptPresentStock = New rptPresentStock
        Dim PresentStockMethods As clsPresentStockMethods = New clsPresentStockMethods

        PresentStockMethods.DeleteAll()
        PresentStockMethods.InsertPresentStock("-1", strSQLCriteria & " AND  ReceptDate between #" & dtStartDate.ToShortDateString & "# AND #" & dtEndDate.ToShortDateString & "#")
        PresentStockMethods.InsertPresentStock("1", strSQLCriteria & " AND  Sdate between #" & dtStartDate.ToShortDateString & "# AND #" & dtEndDate.ToShortDateString & "#")
        PresentStockMethods.InsertPresentStock("9", strSQLCriteria & " AND  Sdate between #" & dtStartDate.ToShortDateString & "# AND #" & dtEndDate.ToShortDateString & "#")
        PresentStockMethods.InsertPresentStock("99", strSQLCriteria & " AND  Sdate between #" & dtStartDate.ToShortDateString & "# AND #" & dtEndDate.ToShortDateString & "#")



        Dim strBranch As String = String.Empty
        Dim strBrand As String = String.Empty
        Dim strModel As String = String.Empty
        Dim listPresentStock As List(Of clsPresentStock) = PresentStockMethods.GetAllPresentStock.ToList
        If strSQLCriteria.Length > 30 Then
            If listPresentStock.Count > 0 Then
                strBranch = listPresentStock(1).Branch
                strBrand = listPresentStock(1).Brand
                strModel = listPresentStock(1).Model
            End If
        Else
            strBranch = "ALL"
            strBrand = "ALL"
            strModel = "ALL"
        End If
        DirectCast(PresentStockReport.ReportDefinition.ReportObjects("txtBranch"), TextObject).Text = strBranch
        DirectCast(PresentStockReport.ReportDefinition.ReportObjects("txtBrand"), TextObject).Text = strBrand
        DirectCast(PresentStockReport.ReportDefinition.ReportObjects("txtCategory"), TextObject).Text = strModel
        DirectCast(PresentStockReport.ReportDefinition.ReportObjects("txtCompanyTitle"), TextObject).Text = strCompanyTitle
        DirectCast(PresentStockReport.ReportDefinition.ReportObjects("txtFrom"), TextObject).Text = "From : " & dtStartDate.ToShortDateString.ToString & " To : " & dtEndDate.ToShortDateString.ToString


        PresentStockReport.SetDataSource(listPresentStock)



        crvReportShow.ReportSource = PresentStockReport
        crvReportShow.Refresh()



    End Sub


    Private Sub DailyTransactionSingleDate()
        Dim DailyReport As rptTransactionDailyReport = New rptTransactionDailyReport
        Dim claiminfoMethods As clsClaiminfoMethods = New clsClaiminfoMethods
        Dim strReceive As String
        Dim strRepair As String
        Dim strDelivery As String
        Dim strPreviousOtherBranchQuery As String = strSQLCriteria ' Replace = to <> for Getting Information of other Branch
        strPreviousOtherBranchQuery = strPreviousOtherBranchQuery.Replace("Branch=", "Branch<>")

#Region "Header Section"
        If Not String.IsNullOrEmpty(strSQLCriteria.Trim) Then
            strReceive = strSQLCriteria & " AND Claiminfo.ReceptDate= #" & dtEndDate & "# AND Claiminfo.Cflag in(-1)"
            strRepair = strSQLCriteria & " AND Claiminfo.Sdate= #" & dtEndDate & "# AND Claiminfo.Cflag in(1,99,101)"
            strDelivery = strSQLCriteria & " AND Claiminfo.Ddate= #" & dtEndDate & "# AND Claiminfo.Cflag in(0,2,100,102)"
        Else
            strReceive = "Claiminfo.ReceptDate=#" & dtEndDate & "# AND Claiminfo.Cflag in(-1)"
            strRepair = " AND Claiminfo.Sdate= #" & dtEndDate & "# AND Claiminfo.Cflag in(1,99,101)"
            strDelivery = " AND Claiminfo.Ddate= #" & dtEndDate & "# AND Claiminfo.Cflag in(0,2,100,102)"
        End If

        Dim dtReceive As DataTable = claiminfoMethods.GetDailyTracationJob(strReceive)
        Dim dtRepaired As DataTable = claiminfoMethods.GetDailyTracationJob(strRepair)
        Dim dtDelivered As DataTable = claiminfoMethods.GetDailyTracationJob(strDelivery)


        DirectCast(DailyReport.ReportDefinition.ReportObjects("txtCompanyName"), TextObject).Text = strCompanyTitle

        DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTransactionDate"), TextObject).Text = dtEndDate

        If Not String.IsNullOrEmpty(transClaiminfo.Branch.Trim) Then
            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtBranch"), TextObject).Text = transClaiminfo.Branch
        Else
            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtBranch"), TextObject).Text = "All"
        End If

        If Not String.IsNullOrEmpty(transClaiminfo.ServiceType.Trim) Then
            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtCategory"), TextObject).Text = transClaiminfo.ServiceType
        Else
            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtCategory"), TextObject).Text = "All"
        End If

        If Not String.IsNullOrEmpty(transClaiminfo.Brand.Trim) Then
            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtBrand"), TextObject).Text = transClaiminfo.Brand
        Else
            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtBrand"), TextObject).Text = "All"
        End If


        If Not String.IsNullOrEmpty(transClaiminfo.ModelNo.Trim) Then
            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtModel"), TextObject).Text = transClaiminfo.ModelNo
        Else
            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtModel"), TextObject).Text = "All"
        End If
        DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayDate"), TextObject).Text = dtEndDate



        Dim cashsalesMethods As clsCashsalesMethods = New clsCashsalesMethods


        Dim strSqlPreviuosData As String
        strSqlPreviuosData = "1=1"
        If transClaiminfo.Branch.Length > 0 Then
            strSqlPreviuosData += " AND Cashsales.Branch='" & transClaiminfo.Branch & "'"
        End If
        strSqlPreviuosData += " AND Cashsales.ReceptDate between # 01-" & dtEndDate.ToString("MMM") & "-" & Year(dtEndDate) & "# AND #" & dtEndDate & "#"
        Dim cashsalespreviousAMount As Double = cashsalesMethods.GetCashsalesNetTotalAmount(strSqlPreviuosData)



        Dim strSqlPreviuosDataOthers As String
        strSqlPreviuosDataOthers = "1=1"
        If transClaiminfo.Branch.Length > 0 Then
            strSqlPreviuosDataOthers += " AND Cashsales.Branch <>'" & transClaiminfo.Branch & "'"
        End If
        strSqlPreviuosDataOthers += " AND Cashsales.ReceptDate between # 01-" & dtEndDate.ToString("MMM") & "-" & Year(dtEndDate) & "# AND #" & dtEndDate & "#"
        Dim cashsalespreviousAMountOthers As Double = cashsalesMethods.GetCashsalesNetTotalAmount(strSqlPreviuosDataOthers)


#End Region
#Region "Cashsales Section"



        Dim strSQLTodayData As String
        strSQLTodayData = "1=1"
        If transClaiminfo.Branch.Length > 0 Then
            strSQLTodayData += " AND Cashsales.Branch = '" & transClaiminfo.Branch & "'"
        End If

        strSQLTodayData += " AND Cashsales.ReceptDate=#" & dtEndDate & "#"

        Dim cashsalesTodayAMount As Double = cashsalesMethods.GetCashsalesNetTotalAmount(strSQLTodayData)


        Dim strSQLTodayDataOthers As String
        strSQLTodayDataOthers = "1=1"
        If transClaiminfo.Branch.Length > 0 Then
            strSQLTodayDataOthers += " AND Cashsales.Branch ='" & transClaiminfo.Branch & "'"
        End If

        strSQLTodayDataOthers += " AND Cashsales.ReceptDate=#" & dtEndDate & "#"

        Dim cashsalesTodayAMountOthers As Double = cashsalesMethods.GetCashsalesNetTotalAmount(strSQLTodayDataOthers)





#End Region
#Region "Summery Sum Amount, Qty Section"


        Dim Transaction As clsDailyTransaction = New clsDailyTransaction

#Region "Getiing Previous Days Data From Database by Sql Query Section"


        '________________________ Get Data from Seleted Branch Section ___________________________

        Dim PreviousReceiveBranch As Double

        Dim PreviousRepairedeBranch As Double

        Dim PreviousDeliveredBranch As Double

        Dim PreviousNRBranch As Double

        Dim PreviousReplaceBranch As Double

        Dim PreviousTotalAmountBranch As Double


        PreviousReceiveBranch = Transaction.PreviousReceiveBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, "01-" & Month(dtEndDate) & "-" & Year(dtEndDate), dtEndDate.AddDays(-1), strSQLCriteria)

        PreviousRepairedeBranch = Transaction.PreviousRepairedBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, "01-" & Month(dtEndDate) & "-" & Year(dtEndDate), dtEndDate.AddDays(-1), strSQLCriteria)

        PreviousDeliveredBranch = Transaction.PreviousDeliveredBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, "01-" & Month(dtEndDate) & "-" & Year(dtEndDate), dtEndDate.AddDays(-1), strSQLCriteria)

        PreviousNRBranch = Transaction.PreviousNRBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, "01-" & Month(dtEndDate) & "-" & Year(dtEndDate), dtEndDate.AddDays(-1), strSQLCriteria)

        PreviousNRBranch += Transaction.PreviousCRBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, "01-" & Month(dtEndDate) & "-" & Year(dtEndDate), dtEndDate.AddDays(-1), strSQLCriteria)

        PreviousReplaceBranch = Transaction.PreviousReplaceServiceBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, "01-" & Month(dtEndDate) & "-" & Year(dtEndDate), dtEndDate.AddDays(-1), strSQLCriteria)

        PreviousReplaceBranch += Transaction.PreviousReplaceDeliveredBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, "01-" & Month(dtEndDate) & "-" & Year(dtEndDate), dtEndDate.AddDays(-1), strSQLCriteria)

        PreviousTotalAmountBranch += Transaction.PreviousTotalAmountBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, "01-" & Month(dtEndDate) & "-" & Year(dtEndDate), dtEndDate.AddDays(-1), strSQLCriteria)


        '________________________ Get Data from Others Branch Section ___________________________
        Dim PreviousReceiveOtherBranch As Double

        Dim PreviousRepairedOtherBranch As Double

        Dim PreviousDeliveredOtherBranch As Double

        Dim PreviousNROtherBranch As Double

        Dim PreviousReplaceOtherBranch As Double

        Dim PreviousTotalAmountOtherBranch As Double






        PreviousReceiveOtherBranch = Transaction.PreviousReceiveOtherBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, "01-" & Month(dtEndDate) & "-" & Year(dtEndDate), dtEndDate.AddDays(-1), strPreviousOtherBranchQuery)

        PreviousRepairedOtherBranch = Transaction.PreviousRepairedOtherBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, "01-" & Month(dtEndDate) & "-" & Year(dtEndDate), dtEndDate.AddDays(-1), strPreviousOtherBranchQuery)

        PreviousDeliveredOtherBranch = Transaction.PreviousDeliveredOtherBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, "01-" & Month(dtEndDate) & "-" & Year(dtEndDate), dtEndDate.AddDays(-1), strPreviousOtherBranchQuery)

        PreviousNROtherBranch = Transaction.PreviousNrOtherBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, "01-" & Month(dtEndDate) & "-" & Year(dtEndDate), dtEndDate.AddDays(-1), strPreviousOtherBranchQuery)

        PreviousNROtherBranch += Transaction.PreviousCROtherBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, "01-" & Month(dtEndDate) & "-" & Year(dtEndDate), dtEndDate.AddDays(-1), strPreviousOtherBranchQuery)

        PreviousReplaceOtherBranch = Transaction.PreviousReplaceServiceOtherBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, "01-" & Month(dtEndDate) & "-" & Year(dtEndDate), dtEndDate.AddDays(-1), strPreviousOtherBranchQuery)

        PreviousTotalAmountOtherBranch += Transaction.PreviousTotalAmountOtherBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, "01-" & Month(dtEndDate) & "-" & Year(dtEndDate), dtEndDate.AddDays(-1), strPreviousOtherBranchQuery)





#End Region

#Region "Getiing Today's Data From Database by Sql Query"

        '________________________ Get Data from Selected Branch Section ___________________________
        Dim TodayReceiveBranch As Double

        Dim TodayRepairedBranch As Double

        Dim TodayDeliveredBranch As Double

        Dim TodayNRBranch As Double

        Dim TodayReplaceBranch As Double

        Dim TodayTotalAmountBranch As Double



        TodayReceiveBranch = Transaction.TodayReceiveBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, dtEndDate, dtEndDate, strWarrantyType)

        TodayRepairedBranch = Transaction.TodayRepairedBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, dtEndDate, dtEndDate, strWarrantyType)

        TodayDeliveredBranch = Transaction.TodayDeliveredBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, dtEndDate, dtEndDate, strWarrantyType)

        TodayNRBranch = Transaction.TodayNRBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, dtEndDate, dtEndDate, strWarrantyType)

        TodayNRBranch += Transaction.TodayCRBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, dtEndDate, dtEndDate, strWarrantyType)

        TodayReplaceBranch = Transaction.TodayReplaceServiceBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, dtEndDate, dtEndDate, strWarrantyType)

        TodayReplaceBranch += Transaction.TodayReplaceDeliveredBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, dtEndDate, dtEndDate, strWarrantyType)

        TodayTotalAmountBranch += Transaction.TodayTotalAmountBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, dtEndDate, dtEndDate, strWarrantyType)


        '________________________ Get Data from Others Branch Section ___________________________



        Dim TodayReceiveOtherBranch As Double

        Dim TodayRepairedOtherBranch As Double

        Dim TodayDeliveredOtherBranch As Double

        Dim TodayNROtherBranch As Double

        Dim TodayReplaceOtherBranch As Double

        Dim TodayTotalAmountOtherBranch As Double



        ' Getting today's Information of Other Branchs from Database by Query
        TodayReceiveOtherBranch = Transaction.TodayReceiveOtherBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, dtEndDate, dtEndDate, strPreviousOtherBranchQuery)

        TodayRepairedOtherBranch = Transaction.TodayRepairedOtherBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, dtEndDate, dtEndDate, strPreviousOtherBranchQuery)

        TodayDeliveredOtherBranch = Transaction.TodayDeliveredOtherBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, dtEndDate, dtEndDate, strPreviousOtherBranchQuery)

        TodayNROtherBranch = Transaction.TodayNROtherBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, dtEndDate, dtEndDate, strPreviousOtherBranchQuery)

        TodayNROtherBranch += Transaction.TodayCROtherBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, dtEndDate, dtEndDate, strPreviousOtherBranchQuery)

        TodayReplaceOtherBranch = Transaction.TodayReplaceServiceOtherBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, dtEndDate, dtEndDate, strPreviousOtherBranchQuery)

        TodayReplaceOtherBranch += Transaction.TodayReplaceDeliveredOtherBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, dtEndDate, dtEndDate, strPreviousOtherBranchQuery)

        TodayTotalAmountOtherBranch += Transaction.TodayTotalAmountOtherBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, dtEndDate, dtEndDate, strPreviousOtherBranchQuery)



#End Region


#End Region
#Region "Assgning All Value Gatherd From Previous Day Section and Todays Section of above"

#Region "Assgning Collected Value From vraible To Previous Filed Section"






        If Not dtEndDate.Day = 1 Then
            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousDate"), TextObject).Text = "01-" & dtEndDate.ToString("MMM") & "-" & Year(dtEndDate) & " To " & dtEndDate.AddDays(-1)


            ' Branch Section




            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousReceiveBranch"), TextObject).Text = PreviousReceiveBranch
            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousRepairBranch"), TextObject).Text = PreviousRepairedeBranch
            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousDeliveryBranch"), TextObject).Text = PreviousDeliveredBranch
            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousNRBranch"), TextObject).Text = PreviousNRBranch
            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousReplaceBranch"), TextObject).Text = PreviousReplaceBranch
            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousTotalAmountBranch"), TextObject).Text = PreviousTotalAmountBranch
            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousCashsaleBranch"), TextObject).Text = cashsalespreviousAMount
            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousGrossAmountBranch"), TextObject).Text = Double.Parse(DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousTotalAmountBranch"), TextObject).Text) + Double.Parse(DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousCashsaleBranch"), TextObject).Text)



            ' Other Branch Section
            If Not String.IsNullOrEmpty(transClaiminfo.Branch.Trim) Then


                DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousReceiveOtherBranch"), TextObject).Text = PreviousReceiveOtherBranch
                DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousRepairOtherBranch"), TextObject).Text = PreviousRepairedOtherBranch
                DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousDeliveryOtherBranch"), TextObject).Text = PreviousDeliveredOtherBranch

                DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousNROtherBranch"), TextObject).Text = PreviousNROtherBranch
                DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousReplaceOtherBranch"), TextObject).Text = PreviousReplaceOtherBranch
                DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousTotalAmountOtherBranch"), TextObject).Text = PreviousTotalAmountOtherBranch
                DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousCashsaleOtherBranch"), TextObject).Text = cashsalespreviousAMountOthers
                DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousGrossAmountOtherBranch"), TextObject).Text = Double.Parse(DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousTotalAmountOtherBranch"), TextObject).Text) + Double.Parse(DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousCashsaleOtherBranch"), TextObject).Text)


                '' Total Section
                DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousReceiveTotal"), TextObject).Text = PreviousReceiveBranch + PreviousReceiveOtherBranch
                DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousRepairTotal"), TextObject).Text = PreviousRepairedeBranch + PreviousRepairedOtherBranch
                DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousDeliveryTotal"), TextObject).Text = PreviousDeliveredBranch + PreviousDeliveredOtherBranch
                DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousNRTotal"), TextObject).Text = PreviousNRBranch + PreviousNROtherBranch
                DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousReplaceTotal"), TextObject).Text = PreviousReplaceBranch + PreviousReplaceOtherBranch
                DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousTotalAmountTotal"), TextObject).Text = PreviousTotalAmountBranch + PreviousTotalAmountOtherBranch
                DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousCashsaleTotal"), TextObject).Text = cashsalespreviousAMount + cashsalespreviousAMountOthers
                DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousGrossAmountTotal"), TextObject).Text = Double.Parse(DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousTotalAmountTotal"), TextObject).Text) + Double.Parse(DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousCashsaleTotal"), TextObject).Text)
            Else
                DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousReceiveTotal"), TextObject).Text = PreviousReceiveBranch
                DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousRepairTotal"), TextObject).Text = PreviousRepairedeBranch
                DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousDeliveryTotal"), TextObject).Text = PreviousDeliveredBranch
                DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousNRTotal"), TextObject).Text = PreviousNRBranch
                DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousReplaceTotal"), TextObject).Text = PreviousReplaceBranch
                DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousTotalAmountTotal"), TextObject).Text = PreviousTotalAmountBranch
                DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousCashsaleTotal"), TextObject).Text = cashsalespreviousAMount
                DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousGrossAmountTotal"), TextObject).Text = Double.Parse(DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousTotalAmountTotal"), TextObject).Text) + Double.Parse(DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousCashsaleTotal"), TextObject).Text)

            End If
        End If


#End Region



#Region "Assgning Value To Today Field Data Section"












        ' Branch Section
        DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayReceiveBranch"), TextObject).Text = TodayReceiveBranch
        DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayRepairBranch"), TextObject).Text = TodayRepairedBranch
        DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayDeliveryBranch"), TextObject).Text = TodayDeliveredBranch
        DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayNRBranch"), TextObject).Text = TodayNRBranch
        DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayReplaceBranch"), TextObject).Text = TodayReplaceBranch
        DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayTotalAmountBranch"), TextObject).Text = TodayTotalAmountBranch
        DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayCashsaleBranch"), TextObject).Text = cashsalesTodayAMount
        DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayGrossAmountBranch"), TextObject).Text = Double.Parse(DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayTotalAmountBranch"), TextObject).Text) + Double.Parse(DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayCashsaleBranch"), TextObject).Text)
        '' Other Branch Section
        If Not String.IsNullOrEmpty(transClaiminfo.Branch.Trim) Then


            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayReceiveOtherBranch"), TextObject).Text = TodayReceiveOtherBranch
            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayRepairOtherBranch"), TextObject).Text = TodayRepairedOtherBranch
            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayDeliveryOtherBranch"), TextObject).Text = TodayDeliveredOtherBranch
            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayNROtherBranch"), TextObject).Text = TodayNROtherBranch
            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayReplaceOtherBranch"), TextObject).Text = TodayReplaceOtherBranch
            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayTotalAmountOtherBranch"), TextObject).Text = TodayTotalAmountOtherBranch
            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayCashsaleOtherBranch"), TextObject).Text = cashsalesTodayAMountOthers
            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayGrossAmountOtherBranch"), TextObject).Text = Double.Parse(DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayTotalAmountOtherBranch"), TextObject).Text) + Double.Parse(DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayCashsaleOtherBranch"), TextObject).Text)
            '' Total Section
            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayReceiveTotal"), TextObject).Text = TodayReceiveBranch + TodayReceiveOtherBranch
            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayRepairTotal"), TextObject).Text = TodayRepairedBranch + TodayRepairedOtherBranch
            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayDeliveryTotal"), TextObject).Text = TodayDeliveredBranch + TodayDeliveredOtherBranch
            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayNRTotal"), TextObject).Text = TodayNRBranch + TodayNROtherBranch
            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayReplaceTotal"), TextObject).Text = TodayReplaceBranch + TodayReplaceOtherBranch
            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayTotalAmountTotal"), TextObject).Text = TodayTotalAmountBranch + TodayTotalAmountOtherBranch
            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayCashsaleTotal"), TextObject).Text = cashsalesTodayAMount + cashsalesTodayAMountOthers
            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayGrossAmountTotal"), TextObject).Text = Double.Parse(DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayTotalAmountTotal"), TextObject).Text) + Double.Parse(DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayCashsaleTotal"), TextObject).Text)
        Else
            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayReceiveTotal"), TextObject).Text = TodayReceiveBranch
            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayRepairTotal"), TextObject).Text = TodayRepairedBranch
            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayDeliveryTotal"), TextObject).Text = TodayDeliveredBranch
            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayNRTotal"), TextObject).Text = TodayNRBranch
            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayReplaceTotal"), TextObject).Text = TodayReplaceBranch
            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayTotalAmountTotal"), TextObject).Text = TodayTotalAmountBranch
            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayCashsaleTotal"), TextObject).Text = cashsalesTodayAMount
            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayGrossAmountTotal"), TextObject).Text = Double.Parse(DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayTotalAmountTotal"), TextObject).Text) + Double.Parse(DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayCashsaleTotal"), TextObject).Text)
        End If
#End Region

#Region "Progressh Data Section"
        ' Branch Section
        DirectCast(DailyReport.ReportDefinition.ReportObjects("txtProgressiveReceiveBranch"), TextObject).Text = PreviousReceiveBranch + TodayReceiveBranch
        DirectCast(DailyReport.ReportDefinition.ReportObjects("txtProgressiveRepairBranch"), TextObject).Text = PreviousRepairedeBranch + TodayRepairedBranch
        DirectCast(DailyReport.ReportDefinition.ReportObjects("txtProgressiveDeliveryBranch"), TextObject).Text = PreviousDeliveredBranch + TodayDeliveredBranch
        DirectCast(DailyReport.ReportDefinition.ReportObjects("txtProgressiveNRBranch"), TextObject).Text = PreviousNRBranch + TodayNRBranch
        DirectCast(DailyReport.ReportDefinition.ReportObjects("txtProgressiveReplaceBranch"), TextObject).Text = PreviousReplaceBranch + TodayReplaceBranch
        DirectCast(DailyReport.ReportDefinition.ReportObjects("txtProgressiveTotalAmountBranch"), TextObject).Text = PreviousTotalAmountBranch + TodayTotalAmountBranch
        DirectCast(DailyReport.ReportDefinition.ReportObjects("txtProgressiveCashsaleBranch"), TextObject).Text = cashsalespreviousAMount + cashsalesTodayAMount
        DirectCast(DailyReport.ReportDefinition.ReportObjects("txtProgressiveGrossAmountBranch"), TextObject).Text = Double.Parse(DirectCast(DailyReport.ReportDefinition.ReportObjects("txtProgressiveTotalAmountBranch"), TextObject).Text) + Double.Parse(DirectCast(DailyReport.ReportDefinition.ReportObjects("txtProgressiveCashsaleBranch"), TextObject).Text)
        ' Other Branch Section
        If Not String.IsNullOrEmpty(transClaiminfo.Branch.Trim) Then
            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtProgressiveReceiveOtherBranch"), TextObject).Text = PreviousReceiveOtherBranch + TodayReceiveOtherBranch
            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtProgressiveRepairOtherBranch"), TextObject).Text = PreviousRepairedOtherBranch + TodayRepairedOtherBranch
            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtProgressiveDeliveryOtherBranch"), TextObject).Text = PreviousDeliveredOtherBranch + TodayDeliveredOtherBranch
            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtProgressiveNROtherBranch"), TextObject).Text = PreviousNROtherBranch + TodayNROtherBranch
            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtProgressiveReplaceOtherBranch"), TextObject).Text = PreviousNROtherBranch + TodayNROtherBranch
            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtProgressiveTotalAmountOtherBranch"), TextObject).Text = PreviousTotalAmountOtherBranch + TodayTotalAmountOtherBranch
            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtProgressiveCashsaleOtherBranch"), TextObject).Text = cashsalespreviousAMountOthers + cashsalesTodayAMountOthers
            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtProgressiveGrossAmountOtherBranch"), TextObject).Text = Double.Parse(DirectCast(DailyReport.ReportDefinition.ReportObjects("txtProgressiveTotalAmountOtherBranch"), TextObject).Text) + Double.Parse(DirectCast(DailyReport.ReportDefinition.ReportObjects("txtProgressiveCashsaleOtherBranch"), TextObject).Text)
        End If

        ' Total Section
        DirectCast(DailyReport.ReportDefinition.ReportObjects("txtProgressiveReceiveTotal"), TextObject).Text = Double.Parse(DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousReceiveTotal"), TextObject).Text) + Double.Parse(DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayReceiveTotal"), TextObject).Text)
        DirectCast(DailyReport.ReportDefinition.ReportObjects("txtProgressiveRepairTotal"), TextObject).Text = Double.Parse(DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousRepairTotal"), TextObject).Text) + Double.Parse(DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayRepairTotal"), TextObject).Text)
        DirectCast(DailyReport.ReportDefinition.ReportObjects("txtProgressiveDeliveryTotal"), TextObject).Text = Double.Parse(DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousDeliveryTotal"), TextObject).Text) + Double.Parse(DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayDeliveryTotal"), TextObject).Text)
        DirectCast(DailyReport.ReportDefinition.ReportObjects("txtProgressiveNRTotal"), TextObject).Text = Double.Parse(DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousNRTotal"), TextObject).Text) + Double.Parse(DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayNRTotal"), TextObject).Text)
        DirectCast(DailyReport.ReportDefinition.ReportObjects("txtProgressiveReplaceTotal"), TextObject).Text = Double.Parse(DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousReplaceTotal"), TextObject).Text) + Double.Parse(DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayReplaceTotal"), TextObject).Text)
        DirectCast(DailyReport.ReportDefinition.ReportObjects("txtProgressiveTotalAmountTotal"), TextObject).Text = Double.Parse(DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousTotalAmountTotal"), TextObject).Text) + Double.Parse(DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayTotalAmountTotal"), TextObject).Text)
        DirectCast(DailyReport.ReportDefinition.ReportObjects("txtProgressiveCashsaleTotal"), TextObject).Text = Double.Parse(DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousCashsaleTotal"), TextObject).Text) + Double.Parse(DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayCashsaleTotal"), TextObject).Text)
        DirectCast(DailyReport.ReportDefinition.ReportObjects("txtProgressiveGrossAmountTotal"), TextObject).Text = Double.Parse(DirectCast(DailyReport.ReportDefinition.ReportObjects("txtProgressiveTotalAmountTotal"), TextObject).Text) + Double.Parse(DirectCast(DailyReport.ReportDefinition.ReportObjects("txtProgressiveCashsaleTotal"), TextObject).Text)

#End Region

#End Region
#Region "Old Data Process OK but Slow Process"



        '#Region "Previous Data Section"
        '        If Not dtEndDate.Day = 1 Then
        '            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousDate"), TextObject).Text = "01-" & dtEndDate.ToString("MMM") & "-" & Year(dtEndDate) & " To " & dtEndDate.AddDays(-1)


        '            ' Branch Section





        '            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousReceiveBranch"), TextObject).Text = GetPreviousTotalReceive()
        '            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousRepairBranch"), TextObject).Text = GetPreviousTotalRepair()
        '            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousDeliveryBranch"), TextObject).Text = GetPreviousTotalDelivery()
        '            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousNRBranch"), TextObject).Text = GetPreviousTotalNR()
        '            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousReplaceBranch"), TextObject).Text = GetPreviousTotalReplace()
        '            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousTotalAmountBranch"), TextObject).Text = GetPreviousTotalTotalAmount()
        '            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousCashsaleBranch"), TextObject).Text = GetPreviousTotalCashsale()
        '            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousGrossAmountBranch"), TextObject).Text = GetPreviousGrossAmount()



        '            ' Other Branch Section
        '            If Not String.IsNullOrEmpty(transClaiminfo.Branch.Trim) Then


        '                DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousReceiveOtherBranch"), TextObject).Text = GetPreviousTotalReceiveOtherBranch()
        '                DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousRepairOtherBranch"), TextObject).Text = GetPreviousTotalRepairOtherBranch()
        '                DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousDeliveryOtherBranch"), TextObject).Text = GetPreviousTotalDeliveryOtherBranch()
        '                DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousNROtherBranch"), TextObject).Text = GetPreviousTotalNROtherBranch()
        '                DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousReplaceOtherBranch"), TextObject).Text = GetPreviousTotalReplaceOtherBranch()
        '                DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousTotalAmountOtherBranch"), TextObject).Text = GetPreviousTotalTotalAmountOtherBranch()
        '                DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousCashsaleOtherBranch"), TextObject).Text = GetPreviousTotalCashsaleOtherBranch()
        '                DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousGrossAmountOtherBranch"), TextObject).Text = GetPreviousGrossAmountOtherBranch()


        '                '' Total Section
        '                DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousReceiveTotal"), TextObject).Text = GetPreviousTotalReceive() + GetPreviousTotalReceiveOtherBranch()
        '                DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousRepairTotal"), TextObject).Text = GetPreviousTotalRepair() + GetPreviousTotalRepairOtherBranch()
        '                DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousDeliveryTotal"), TextObject).Text = GetPreviousTotalDelivery() + GetPreviousTotalDeliveryOtherBranch()
        '                DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousNRTotal"), TextObject).Text = GetPreviousTotalNR() + GetPreviousTotalNROtherBranch()
        '                DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousReplaceTotal"), TextObject).Text = GetPreviousTotalReplace() + GetPreviousTotalReplaceOtherBranch()
        '                DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousTotalAmountTotal"), TextObject).Text = GetPreviousTotalTotalAmount() + GetPreviousTotalTotalAmountOtherBranch()
        '                DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousCashsaleTotal"), TextObject).Text = GetPreviousTotalCashsale() + GetPreviousTotalCashsaleOtherBranch()
        '                DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousGrossAmountTotal"), TextObject).Text = GetPreviousGrossAmount() + GetPreviousGrossAmountOtherBranch()
        '            Else
        '                DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousReceiveTotal"), TextObject).Text = GetPreviousTotalReceive()
        '                DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousRepairTotal"), TextObject).Text = GetPreviousTotalRepair()
        '                DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousDeliveryTotal"), TextObject).Text = GetPreviousTotalDelivery()
        '                DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousNRTotal"), TextObject).Text = GetPreviousTotalNR()
        '                DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousReplaceTotal"), TextObject).Text = GetPreviousTotalReplace()
        '                DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousTotalAmountTotal"), TextObject).Text = GetPreviousTotalTotalAmount()
        '                DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousCashsaleTotal"), TextObject).Text = GetPreviousTotalCashsale()
        '                DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousGrossAmountTotal"), TextObject).Text = GetPreviousGrossAmount()

        '            End If
        '        End If


        '#End Region

        '#Region "Today Data Section"
        '        ' Branch Section
        '        DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayReceiveBranch"), TextObject).Text = GetTodayTotalReceive()
        '        DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayRepairBranch"), TextObject).Text = GetTodayTotalRepair()
        '        DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayDeliveryBranch"), TextObject).Text = GetTodayTotalDelivery()
        '        DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayNRBranch"), TextObject).Text = GetTodayTotalNR()
        '        DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayReplaceBranch"), TextObject).Text = GetTodayTotalReplace()
        '        DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayTotalAmountBranch"), TextObject).Text = GetTodayTotalTotalAmount()
        '        DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayCashsaleBranch"), TextObject).Text = GetTodayTotalCashsale()
        '        DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayGrossAmountBranch"), TextObject).Text = GetTodayGrossAmount()
        '        '' Other Branch Section
        '        If Not String.IsNullOrEmpty(transClaiminfo.Branch.Trim) Then


        '            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayReceiveOtherBranch"), TextObject).Text = GetTodayTotalReceiveOtherBranch()
        '            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayRepairOtherBranch"), TextObject).Text = GetTodayTotalRepairOtherBranch()
        '            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayDeliveryOtherBranch"), TextObject).Text = GetTodayTotalDeliveryOtherBranch()
        '            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayNROtherBranch"), TextObject).Text = GetTodayTotalNROtherBranch()
        '            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayReplaceOtherBranch"), TextObject).Text = GetTodayTotalReplaceOtherBranch()
        '            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayTotalAmountOtherBranch"), TextObject).Text = GetTodayTotalTotalAmountOtherBranch()
        '            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayCashsaleOtherBranch"), TextObject).Text = GetTodayTotalCashsaleOtherBranch()
        '            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayGrossAmountOtherBranch"), TextObject).Text = GetTodayGrossAmountOtherBranch()
        '            '' Total Section
        '            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayReceiveTotal"), TextObject).Text = GetTodayTotalReceive() + GetTodayTotalReceiveOtherBranch()
        '            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayRepairTotal"), TextObject).Text = GetTodayTotalRepair() + GetTodayTotalRepairOtherBranch()
        '            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayDeliveryTotal"), TextObject).Text = GetTodayTotalDelivery() + GetTodayTotalDeliveryOtherBranch()
        '            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayNRTotal"), TextObject).Text = GetTodayTotalNR() + GetTodayTotalNROtherBranch()
        '            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayReplaceTotal"), TextObject).Text = GetTodayTotalReplace() + GetTodayTotalReplaceOtherBranch()
        '            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayTotalAmountTotal"), TextObject).Text = GetTodayTotalTotalAmount() + GetTodayTotalTotalAmountOtherBranch()
        '            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayCashsaleTotal"), TextObject).Text = GetTodayTotalCashsale() + GetTodayTotalCashsaleOtherBranch()
        '            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayGrossAmountTotal"), TextObject).Text = GetTodayGrossAmount() + GetTodayGrossAmountOtherBranch()
        '        Else
        '            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayReceiveTotal"), TextObject).Text = GetTodayTotalReceive()
        '            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayRepairTotal"), TextObject).Text = GetTodayTotalRepair()
        '            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayDeliveryTotal"), TextObject).Text = GetTodayTotalDelivery()
        '            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayNRTotal"), TextObject).Text = GetTodayTotalNR()
        '            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayReplaceTotal"), TextObject).Text = GetTodayTotalReplace()
        '            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayTotalAmountTotal"), TextObject).Text = GetTodayTotalTotalAmount()
        '            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayCashsaleTotal"), TextObject).Text = GetTodayTotalCashsale()
        '            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayGrossAmountTotal"), TextObject).Text = GetTodayGrossAmount()
        '        End If
        '#End Region

        '#Region "Progressh Data Section"
        '        ' Branch Section
        '        DirectCast(DailyReport.ReportDefinition.ReportObjects("txtProgressiveReceiveBranch"), TextObject).Text = GetPreviousTotalReceive() + GetTodayTotalReceive()
        '        DirectCast(DailyReport.ReportDefinition.ReportObjects("txtProgressiveRepairBranch"), TextObject).Text = GetPreviousTotalRepair() + GetTodayTotalRepair()
        '        DirectCast(DailyReport.ReportDefinition.ReportObjects("txtProgressiveDeliveryBranch"), TextObject).Text = GetPreviousTotalDelivery() + GetTodayTotalDelivery()
        '        DirectCast(DailyReport.ReportDefinition.ReportObjects("txtProgressiveNRBranch"), TextObject).Text = GetPreviousTotalNR() + GetTodayTotalNR()
        '        DirectCast(DailyReport.ReportDefinition.ReportObjects("txtProgressiveReplaceBranch"), TextObject).Text = GetPreviousTotalReplace() + GetTodayTotalReplace()
        '        DirectCast(DailyReport.ReportDefinition.ReportObjects("txtProgressiveTotalAmountBranch"), TextObject).Text = GetPreviousTotalTotalAmount() + GetTodayTotalTotalAmount()
        '        DirectCast(DailyReport.ReportDefinition.ReportObjects("txtProgressiveCashsaleBranch"), TextObject).Text = GetPreviousTotalCashsale() + GetTodayTotalCashsale()
        '        DirectCast(DailyReport.ReportDefinition.ReportObjects("txtProgressiveGrossAmountBranch"), TextObject).Text = GetPreviousGrossAmount() + GetTodayGrossAmount()
        '        ' Other Branch Section
        '        If Not String.IsNullOrEmpty(transClaiminfo.Branch.Trim) Then


        '            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtProgressiveReceiveOtherBranch"), TextObject).Text = GetPreviousTotalReceiveOtherBranch() + GetTodayTotalReceiveOtherBranch()
        '            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtProgressiveRepairOtherBranch"), TextObject).Text = GetPreviousTotalRepairOtherBranch() + GetTodayTotalRepairOtherBranch()
        '            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtProgressiveDeliveryOtherBranch"), TextObject).Text = GetPreviousTotalDeliveryOtherBranch() + GetTodayTotalDeliveryOtherBranch()
        '            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtProgressiveNROtherBranch"), TextObject).Text = GetPreviousTotalNROtherBranch() + GetTodayTotalNROtherBranch()
        '            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtProgressiveReplaceOtherBranch"), TextObject).Text = GetPreviousTotalReplaceOtherBranch() + GetTodayTotalReplaceOtherBranch()

        '            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtProgressiveTotalAmountOtherBranch"), TextObject).Text = GetPreviousTotalTotalAmountOtherBranch() + GetTodayTotalTotalAmountOtherBranch()
        '            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtProgressiveCashsaleOtherBranch"), TextObject).Text = GetPreviousTotalCashsaleOtherBranch() + GetTodayTotalCashsaleOtherBranch()
        '            DirectCast(DailyReport.ReportDefinition.ReportObjects("txtProgressiveGrossAmountOtherBranch"), TextObject).Text = GetPreviousGrossAmountOtherBranch() + GetTodayGrossAmountOtherBranch()
        '        End If

        '        ' Total Section
        '        DirectCast(DailyReport.ReportDefinition.ReportObjects("txtProgressiveReceiveTotal"), TextObject).Text = Double.Parse(DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousReceiveTotal"), TextObject).Text) + Double.Parse(DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayReceiveTotal"), TextObject).Text)
        '        DirectCast(DailyReport.ReportDefinition.ReportObjects("txtProgressiveRepairTotal"), TextObject).Text = Double.Parse(DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousRepairTotal"), TextObject).Text) + Double.Parse(DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayRepairTotal"), TextObject).Text)
        '        DirectCast(DailyReport.ReportDefinition.ReportObjects("txtProgressiveDeliveryTotal"), TextObject).Text = Double.Parse(DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousDeliveryTotal"), TextObject).Text) + Double.Parse(DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayDeliveryTotal"), TextObject).Text)
        '        DirectCast(DailyReport.ReportDefinition.ReportObjects("txtProgressiveNRTotal"), TextObject).Text = Double.Parse(DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousNRTotal"), TextObject).Text) + Double.Parse(DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayNRTotal"), TextObject).Text)
        '        DirectCast(DailyReport.ReportDefinition.ReportObjects("txtProgressiveReplaceTotal"), TextObject).Text = Double.Parse(DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousReplaceTotal"), TextObject).Text) + Double.Parse(DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayReplaceTotal"), TextObject).Text)
        '        DirectCast(DailyReport.ReportDefinition.ReportObjects("txtProgressiveTotalAmountTotal"), TextObject).Text = Double.Parse(DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousTotalAmountTotal"), TextObject).Text) + Double.Parse(DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayTotalAmountTotal"), TextObject).Text)
        '        DirectCast(DailyReport.ReportDefinition.ReportObjects("txtProgressiveCashsaleTotal"), TextObject).Text = Double.Parse(DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousCashsaleTotal"), TextObject).Text) + Double.Parse(DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayCashsaleTotal"), TextObject).Text)
        '        DirectCast(DailyReport.ReportDefinition.ReportObjects("txtProgressiveGrossAmountTotal"), TextObject).Text = Double.Parse(DirectCast(DailyReport.ReportDefinition.ReportObjects("txtPreviousGrossAmountTotal"), TextObject).Text) + Double.Parse(DirectCast(DailyReport.ReportDefinition.ReportObjects("txtTodayGrossAmountTotal"), TextObject).Text)

        '#End Region




#End Region
#Region "Report Section"
        If dtReceive.Rows.Count > 0 Then
            DailyReport.Subreports("TransactionReceive").SetDataSource(dtReceive)
        End If

        If dtRepaired.Rows.Count > 0 Then
            DailyReport.Subreports("TransactionRepair").SetDataSource(dtRepaired)
        End If

        If dtDelivered.Rows.Count > 0 Then
            DailyReport.Subreports("TransactionDelivery").SetDataSource(dtDelivered)
        End If



        crvReportShow.ReportSource = DailyReport
        crvReportShow.Refresh()
#End Region

    End Sub
    Private Sub DailyTransactionDateWise()
        Dim DailyReportDatewise As rptTransactionDailyReport = New rptTransactionDailyReport
        Dim claiminfoMethods As clsClaiminfoMethods = New clsClaiminfoMethods
        Dim strReceive As String
        Dim strRepair As String
        Dim strDelivery As String
        Dim strPreviousOtherBranchQuery As String = strSQLCriteria ' Replace = to <> for Getting Information of other Branch
        strPreviousOtherBranchQuery = strPreviousOtherBranchQuery.Replace("Branch=", "Branch<>")
        If DailyReportDatewise.IsLoaded = True Then
            DailyReportDatewise.Close()
        End If
#Region "Header Section"
        If Not String.IsNullOrEmpty(strSQLCriteria.Trim) Then
            strReceive = strSQLCriteria & " AND Claiminfo.ReceptDate between #" & dtStartDate & "# AND #" & dtEndDate & "# AND Claiminfo.Cflag in(-1)"
            strRepair = strSQLCriteria & " AND Claiminfo.Sdate Between #" & dtStartDate & "# AND #" & dtEndDate & "# AND Claiminfo.Cflag in(1,99,101)"
            strDelivery = strSQLCriteria & " AND Claiminfo.Ddate Between #" & dtStartDate & "# AND #" & dtEndDate & "# AND Claiminfo.Cflag in(0,2,100,102)"
        Else
            strReceive = "Claiminfo.ReceptDate=#" & dtStartDate & "# AND #" & dtEndDate & "# AND Claiminfo.Cflag in(-1)"
            strRepair = " AND Claiminfo.Sdate= #" & dtStartDate & "# AND #" & dtEndDate & "# AND Claiminfo.Cflag in(1,99,101)"
            strDelivery = " AND Claiminfo.Ddate= #" & dtStartDate & "# AND #" & dtEndDate & "# AND Claiminfo.Cflag in(0,2,100,102)"
        End If

        Dim dtReceive As DataTable = claiminfoMethods.GetDailyTracationJob(strReceive)
        Dim dtRepaired As DataTable = claiminfoMethods.GetDailyTracationJob(strRepair)
        Dim dtDelivered As DataTable = claiminfoMethods.GetDailyTracationJob(strDelivery)


        DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtCompanyName"), TextObject).Text = strCompanyTitle

        DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtTransactionDate"), TextObject).Text = "From " & dtStartDate & " To " & dtEndDate

        If Not String.IsNullOrEmpty(transClaiminfo.Branch.Trim) Then
            DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtBranch"), TextObject).Text = transClaiminfo.Branch
        Else
            DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtBranch"), TextObject).Text = "All"
        End If

        If Not String.IsNullOrEmpty(transClaiminfo.ServiceType.Trim) Then
            DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtCategory"), TextObject).Text = transClaiminfo.ServiceType
        Else
            DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtCategory"), TextObject).Text = "All"
        End If

        If Not String.IsNullOrEmpty(transClaiminfo.Brand.Trim) Then
            DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtBrand"), TextObject).Text = transClaiminfo.Brand
        Else
            DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtBrand"), TextObject).Text = "All"
        End If


        If Not String.IsNullOrEmpty(transClaiminfo.ModelNo.Trim) Then
            DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtModel"), TextObject).Text = transClaiminfo.ModelNo
        Else
            DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtModel"), TextObject).Text = "All"
        End If
        DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtTodayDate"), TextObject).Text = dtEndDate



        Dim cashsalesMethods As clsCashsalesMethods = New clsCashsalesMethods


        Dim strSqlPreviuosData As String
        strSqlPreviuosData = "1=1"
        If transClaiminfo.Branch.Length > 0 Then
            strSqlPreviuosData += " AND Cashsales.Branch='" & transClaiminfo.Branch & "'"
        End If
        strSqlPreviuosData += " AND Cashsales.ReceptDate between # 01-" & dtEndDate.ToString("MMM") & "-" & Year(dtEndDate) & "# AND #" & dtEndDate & "#"
        Dim cashsalespreviousAMount As Double = cashsalesMethods.GetCashsalesNetTotalAmount(strSqlPreviuosData)



        Dim strSqlPreviuosDataOthers As String
        strSqlPreviuosDataOthers = "1=1"
        If transClaiminfo.Branch.Length > 0 Then
            strSqlPreviuosDataOthers += " AND Cashsales.Branch <>'" & transClaiminfo.Branch & "'"
        End If
        strSqlPreviuosDataOthers += " AND Cashsales.ReceptDate between # 01-" & dtEndDate.ToString("MMM") & "-" & Year(dtEndDate) & "# AND #" & dtEndDate & "#"
        Dim cashsalespreviousAMountOthers As Double = cashsalesMethods.GetCashsalesNetTotalAmount(strSqlPreviuosDataOthers)


#End Region
#Region "Cashsales Section"



        Dim strSQLTodayData As String
        strSQLTodayData = "1=1"
        If transClaiminfo.Branch.Length > 0 Then
            strSQLTodayData += " AND Cashsales.Branch = '" & transClaiminfo.Branch & "'"
        End If

        strSQLTodayData += " AND Cashsales.ReceptDate=#" & dtEndDate & "#"

        Dim cashsalesTodayAMount As Double = cashsalesMethods.GetCashsalesNetTotalAmount(strSQLTodayData)


        Dim strSQLTodayDataOthers As String
        strSQLTodayDataOthers = "1=1"
        If transClaiminfo.Branch.Length > 0 Then
            strSQLTodayDataOthers += " AND Cashsales.Branch ='" & transClaiminfo.Branch & "'"
        End If

        strSQLTodayDataOthers += " AND Cashsales.ReceptDate=#" & dtEndDate & "#"

        Dim cashsalesTodayAMountOthers As Double = cashsalesMethods.GetCashsalesNetTotalAmount(strSQLTodayDataOthers)





#End Region
#Region "Summery Total Section"


        Dim Transaction As clsDailyTransaction = New clsDailyTransaction

#Region "Previous Date Section"


        '________________________ Get Data from Selected Branch Section ___________________________

        Dim PreviousReceiveBranch As Double

        Dim PreviousRepairedeBranch As Double

        Dim PreviousDeliveredBranch As Double

        Dim PreviousNRBranch As Double

        Dim PreviousReplaceBranch As Double

        Dim PreviousTotalAmountBranch As Double


        PreviousReceiveBranch = Transaction.PreviousReceiveBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, dtStartDate, dtEndDate.AddDays(-1), strWarrantyType)

        PreviousRepairedeBranch = Transaction.PreviousRepairedBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, dtStartDate, dtEndDate.AddDays(-1), strWarrantyType)

        PreviousDeliveredBranch = Transaction.PreviousDeliveredBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, dtStartDate, dtEndDate.AddDays(-1), strWarrantyType)

        PreviousNRBranch = Transaction.PreviousNRBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, dtStartDate, dtEndDate.AddDays(-1), strWarrantyType)

        PreviousNRBranch += Transaction.PreviousCRBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, dtStartDate, dtEndDate.AddDays(-1), strWarrantyType)

        PreviousReplaceBranch = Transaction.PreviousReplaceServiceBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, dtStartDate, dtEndDate.AddDays(-1), strWarrantyType)

        PreviousReplaceBranch += Transaction.PreviousReplaceDeliveredBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, dtStartDate, dtEndDate.AddDays(-1), strWarrantyType)

        PreviousTotalAmountBranch = Transaction.PreviousTotalAmountBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, dtStartDate, dtEndDate.AddDays(-1), strWarrantyType)


        '________________________ Get Data from Others Branch Section ___________________________
        Dim PreviousReceiveOtherBranch As Double

        Dim PreviousRepairedOtherBranch As Double

        Dim PreviousDeliveredOtherBranch As Double

        Dim PreviousNROtherBranch As Double

        Dim PreviousReplaceOtherBranch As Double

        Dim PreviousTotalAmountOtherBranch As Double


        PreviousReceiveOtherBranch = Transaction.PreviousReceiveOtherBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, dtStartDate, dtEndDate.AddDays(-1), strPreviousOtherBranchQuery)

        PreviousRepairedOtherBranch = Transaction.PreviousRepairedOtherBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, dtStartDate, dtEndDate.AddDays(-1), strPreviousOtherBranchQuery)

        PreviousDeliveredOtherBranch = Transaction.PreviousDeliveredOtherBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, dtStartDate, dtEndDate.AddDays(-1), strPreviousOtherBranchQuery)

        PreviousNROtherBranch = Transaction.PreviousNrOtherBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, dtStartDate, dtEndDate.AddDays(-1), strPreviousOtherBranchQuery)

        PreviousNROtherBranch += Transaction.PreviousCROtherBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, dtStartDate, dtEndDate.AddDays(-1), strPreviousOtherBranchQuery)

        PreviousReplaceOtherBranch = Transaction.PreviousReplaceServiceOtherBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, dtStartDate, dtEndDate.AddDays(-1), strPreviousOtherBranchQuery)

        PreviousTotalAmountOtherBranch = Transaction.PreviousTotalAmountOtherBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, dtStartDate, dtEndDate.AddDays(-1), strPreviousOtherBranchQuery)





#End Region

#Region "Today Date Section"

        '________________________ Get Data From Selected Branch Section ___________________________
        Dim TodayReceiveBranch As Double

        Dim TodayRepairedBranch As Double

        Dim TodayDeliveredBranch As Double

        Dim TodayNRBranch As Double

        Dim TodayReplaceBranch As Double

        Dim TodayTotalAmountBranch As Double



        TodayReceiveBranch = Transaction.TodayReceiveBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, dtEndDate, dtEndDate, strWarrantyType)

        TodayRepairedBranch = Transaction.TodayRepairedBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, dtEndDate, dtEndDate, strWarrantyType)

        TodayDeliveredBranch = Transaction.TodayDeliveredBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, dtEndDate, dtEndDate, strWarrantyType)

        TodayNRBranch = Transaction.TodayNRBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, dtEndDate, dtEndDate, strWarrantyType)

        TodayNRBranch += Transaction.TodayCRBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, dtEndDate, dtEndDate, strWarrantyType)

        TodayReplaceBranch = Transaction.TodayReplaceServiceBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, dtEndDate, dtEndDate, strWarrantyType)

        TodayReplaceBranch += Transaction.TodayReplaceDeliveredBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, dtEndDate, dtEndDate, strWarrantyType)

        TodayTotalAmountBranch += Transaction.TodayTotalAmountBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, dtEndDate, dtEndDate, strWarrantyType)


        '________________________ Get Data from Others Branch Section ___________________________



        Dim TodayReceiveOtherBranch As Double

        Dim TodayRepairedOtherBranch As Double

        Dim TodayDeliveredOtherBranch As Double

        Dim TodayNROtherBranch As Double

        Dim TodayReplaceOtherBranch As Double

        Dim TodayTotalAmountOtherBranch As Double




        TodayReceiveOtherBranch = Transaction.TodayReceiveOtherBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, dtEndDate, dtEndDate, strPreviousOtherBranchQuery)

        TodayRepairedOtherBranch = Transaction.TodayRepairedOtherBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, dtEndDate, dtEndDate, strPreviousOtherBranchQuery)

        TodayDeliveredOtherBranch = Transaction.TodayDeliveredOtherBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, dtEndDate, dtEndDate, strPreviousOtherBranchQuery)

        TodayNROtherBranch = Transaction.TodayNROtherBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, dtEndDate, dtEndDate, strPreviousOtherBranchQuery)

        TodayNROtherBranch += Transaction.TodayCROtherBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, dtEndDate, dtEndDate, strPreviousOtherBranchQuery)

        TodayReplaceOtherBranch = Transaction.TodayReplaceServiceOtherBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, dtEndDate, dtEndDate, strPreviousOtherBranchQuery)

        TodayReplaceOtherBranch += Transaction.TodayReplaceDeliveredOtherBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, dtEndDate, dtEndDate, strPreviousOtherBranchQuery)

        TodayTotalAmountOtherBranch = Transaction.TodayTotalAmountOtherBranch(transClaiminfo.Branch, transClaiminfo.ServiceType, transClaiminfo.Brand, transClaiminfo.ModelNo, dtEndDate, dtEndDate, strPreviousOtherBranchQuery)



#End Region


#End Region
#Region "Assing All Value Gatherd From Previous Day Section and Todays Section of above"

#Region "Previous Data Section"






        If Not dtEndDate.Day = 1 Then
            DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtPreviousDate"), TextObject).Text = "01-" & dtEndDate.ToString("MMM") & "-" & Year(dtEndDate) & " To " & dtEndDate.AddDays(-1)


            ' Branch Section




            DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtPreviousReceiveBranch"), TextObject).Text = PreviousReceiveBranch
            DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtPreviousRepairBranch"), TextObject).Text = PreviousRepairedeBranch
            DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtPreviousDeliveryBranch"), TextObject).Text = PreviousDeliveredBranch
            DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtPreviousNRBranch"), TextObject).Text = PreviousNRBranch
            DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtPreviousReplaceBranch"), TextObject).Text = PreviousReplaceBranch
            DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtPreviousTotalAmountBranch"), TextObject).Text = PreviousTotalAmountBranch
            DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtPreviousCashsaleBranch"), TextObject).Text = cashsalespreviousAMount
            DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtPreviousGrossAmountBranch"), TextObject).Text = Double.Parse(DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtPreviousTotalAmountBranch"), TextObject).Text) + Double.Parse(DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtPreviousCashsaleBranch"), TextObject).Text)



            ' Other Branch Section
            If Not String.IsNullOrEmpty(transClaiminfo.Branch.Trim) Then


                DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtPreviousReceiveOtherBranch"), TextObject).Text = PreviousReceiveOtherBranch
                DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtPreviousRepairOtherBranch"), TextObject).Text = PreviousRepairedOtherBranch
                DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtPreviousDeliveryOtherBranch"), TextObject).Text = PreviousDeliveredOtherBranch

                DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtPreviousNROtherBranch"), TextObject).Text = PreviousNROtherBranch
                DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtPreviousReplaceOtherBranch"), TextObject).Text = PreviousReplaceOtherBranch
                DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtPreviousTotalAmountOtherBranch"), TextObject).Text = PreviousTotalAmountOtherBranch
                DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtPreviousCashsaleOtherBranch"), TextObject).Text = cashsalespreviousAMountOthers
                DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtPreviousGrossAmountOtherBranch"), TextObject).Text = Double.Parse(DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtPreviousTotalAmountOtherBranch"), TextObject).Text) + Double.Parse(DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtPreviousCashsaleOtherBranch"), TextObject).Text)


                '' Total Section
                DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtPreviousReceiveTotal"), TextObject).Text = PreviousReceiveBranch + PreviousReceiveOtherBranch
                DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtPreviousRepairTotal"), TextObject).Text = PreviousRepairedeBranch + PreviousRepairedOtherBranch
                DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtPreviousDeliveryTotal"), TextObject).Text = PreviousDeliveredBranch + PreviousDeliveredOtherBranch
                DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtPreviousNRTotal"), TextObject).Text = PreviousNRBranch + PreviousNROtherBranch
                DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtPreviousReplaceTotal"), TextObject).Text = PreviousReplaceBranch + PreviousReplaceOtherBranch
                DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtPreviousTotalAmountTotal"), TextObject).Text = PreviousTotalAmountBranch + PreviousTotalAmountOtherBranch
                DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtPreviousCashsaleTotal"), TextObject).Text = cashsalespreviousAMount + cashsalespreviousAMountOthers
                DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtPreviousGrossAmountTotal"), TextObject).Text = Double.Parse(DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtPreviousTotalAmountTotal"), TextObject).Text) + Double.Parse(DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtPreviousCashsaleTotal"), TextObject).Text)
            Else
                DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtPreviousReceiveTotal"), TextObject).Text = PreviousReceiveBranch
                DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtPreviousRepairTotal"), TextObject).Text = PreviousRepairedeBranch
                DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtPreviousDeliveryTotal"), TextObject).Text = PreviousDeliveredBranch
                DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtPreviousNRTotal"), TextObject).Text = PreviousNRBranch
                DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtPreviousReplaceTotal"), TextObject).Text = PreviousReplaceBranch
                DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtPreviousTotalAmountTotal"), TextObject).Text = PreviousTotalAmountBranch
                DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtPreviousCashsaleTotal"), TextObject).Text = cashsalespreviousAMount
                DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtPreviousGrossAmountTotal"), TextObject).Text = Double.Parse(DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtPreviousTotalAmountTotal"), TextObject).Text) + Double.Parse(DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtPreviousCashsaleTotal"), TextObject).Text)

            End If
        End If


#End Region
#Region "Today Data Section"












        ' Branch Section
        DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtTodayReceiveBranch"), TextObject).Text = TodayReceiveBranch
        DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtTodayRepairBranch"), TextObject).Text = TodayRepairedBranch
        DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtTodayDeliveryBranch"), TextObject).Text = TodayDeliveredBranch
        DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtTodayNRBranch"), TextObject).Text = TodayNRBranch
        DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtTodayReplaceBranch"), TextObject).Text = TodayReplaceBranch
        DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtTodayTotalAmountBranch"), TextObject).Text = TodayTotalAmountBranch
        DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtTodayCashsaleBranch"), TextObject).Text = cashsalesTodayAMount
        DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtTodayGrossAmountBranch"), TextObject).Text = Double.Parse(DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtTodayTotalAmountBranch"), TextObject).Text) + Double.Parse(DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtTodayCashsaleBranch"), TextObject).Text)
        '' Other Branch Section
        If Not String.IsNullOrEmpty(transClaiminfo.Branch.Trim) Then


            DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtTodayReceiveOtherBranch"), TextObject).Text = TodayReceiveOtherBranch
            DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtTodayRepairOtherBranch"), TextObject).Text = TodayRepairedOtherBranch
            DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtTodayDeliveryOtherBranch"), TextObject).Text = TodayDeliveredOtherBranch
            DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtTodayNROtherBranch"), TextObject).Text = TodayNROtherBranch
            DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtTodayReplaceOtherBranch"), TextObject).Text = TodayReplaceOtherBranch
            DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtTodayTotalAmountOtherBranch"), TextObject).Text = TodayTotalAmountOtherBranch
            DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtTodayCashsaleOtherBranch"), TextObject).Text = cashsalesTodayAMountOthers
            DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtTodayGrossAmountOtherBranch"), TextObject).Text = Double.Parse(DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtTodayTotalAmountOtherBranch"), TextObject).Text) + Double.Parse(DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtTodayCashsaleOtherBranch"), TextObject).Text)
            '' Total Section
            DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtTodayReceiveTotal"), TextObject).Text = TodayReceiveBranch + TodayReceiveOtherBranch
            DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtTodayRepairTotal"), TextObject).Text = TodayRepairedBranch + TodayRepairedOtherBranch
            DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtTodayDeliveryTotal"), TextObject).Text = TodayDeliveredBranch + TodayDeliveredOtherBranch
            DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtTodayNRTotal"), TextObject).Text = TodayNRBranch + TodayNROtherBranch
            DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtTodayReplaceTotal"), TextObject).Text = TodayReplaceBranch + TodayReplaceOtherBranch
            DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtTodayTotalAmountTotal"), TextObject).Text = TodayTotalAmountBranch + TodayTotalAmountOtherBranch
            DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtTodayCashsaleTotal"), TextObject).Text = cashsalesTodayAMount + cashsalesTodayAMountOthers
            DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtTodayGrossAmountTotal"), TextObject).Text = Double.Parse(DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtTodayTotalAmountTotal"), TextObject).Text) + Double.Parse(DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtTodayCashsaleTotal"), TextObject).Text)
        Else
            DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtTodayReceiveTotal"), TextObject).Text = TodayReceiveBranch
            DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtTodayRepairTotal"), TextObject).Text = TodayRepairedBranch
            DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtTodayDeliveryTotal"), TextObject).Text = TodayDeliveredBranch
            DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtTodayNRTotal"), TextObject).Text = TodayNRBranch
            DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtTodayReplaceTotal"), TextObject).Text = TodayReplaceBranch
            DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtTodayTotalAmountTotal"), TextObject).Text = TodayTotalAmountBranch
            DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtTodayCashsaleTotal"), TextObject).Text = cashsalesTodayAMount
            DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtTodayGrossAmountTotal"), TextObject).Text = Double.Parse(DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtTodayTotalAmountTotal"), TextObject).Text) + Double.Parse(DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtTodayCashsaleTotal"), TextObject).Text)
        End If
#End Region
#Region "Progressh Data Section"
        ' Branch Section
        DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtProgressiveReceiveBranch"), TextObject).Text = PreviousReceiveBranch + TodayReceiveBranch
        DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtProgressiveRepairBranch"), TextObject).Text = PreviousRepairedeBranch + TodayRepairedBranch
        DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtProgressiveDeliveryBranch"), TextObject).Text = PreviousDeliveredBranch + TodayDeliveredBranch
        DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtProgressiveNRBranch"), TextObject).Text = PreviousNRBranch + TodayNRBranch
        DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtProgressiveReplaceBranch"), TextObject).Text = PreviousReplaceBranch + TodayReplaceBranch
        DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtProgressiveTotalAmountBranch"), TextObject).Text = PreviousTotalAmountBranch + TodayTotalAmountBranch
        DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtProgressiveCashsaleBranch"), TextObject).Text = cashsalespreviousAMount + cashsalesTodayAMount
        DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtProgressiveGrossAmountBranch"), TextObject).Text = Double.Parse(DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtProgressiveTotalAmountBranch"), TextObject).Text) + Double.Parse(DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtProgressiveCashsaleBranch"), TextObject).Text)
        ' Other Branch Section
        If Not String.IsNullOrEmpty(transClaiminfo.Branch.Trim) Then
            DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtProgressiveReceiveOtherBranch"), TextObject).Text = PreviousReceiveOtherBranch + TodayReceiveOtherBranch
            DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtProgressiveRepairOtherBranch"), TextObject).Text = PreviousRepairedOtherBranch + TodayRepairedOtherBranch
            DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtProgressiveDeliveryOtherBranch"), TextObject).Text = PreviousDeliveredOtherBranch + TodayDeliveredOtherBranch
            DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtProgressiveNROtherBranch"), TextObject).Text = PreviousNROtherBranch + TodayNROtherBranch
            DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtProgressiveReplaceOtherBranch"), TextObject).Text = PreviousNROtherBranch + TodayNROtherBranch
            DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtProgressiveTotalAmountOtherBranch"), TextObject).Text = PreviousTotalAmountOtherBranch + TodayTotalAmountOtherBranch
            DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtProgressiveCashsaleOtherBranch"), TextObject).Text = cashsalespreviousAMountOthers + cashsalesTodayAMountOthers
            DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtProgressiveGrossAmountOtherBranch"), TextObject).Text = Double.Parse(DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtProgressiveTotalAmountOtherBranch"), TextObject).Text) + Double.Parse(DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtProgressiveCashsaleOtherBranch"), TextObject).Text)
        End If

        ' Total Section
        DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtProgressiveReceiveTotal"), TextObject).Text = Double.Parse(DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtPreviousReceiveTotal"), TextObject).Text) + Double.Parse(DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtTodayReceiveTotal"), TextObject).Text)
        DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtProgressiveRepairTotal"), TextObject).Text = Double.Parse(DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtPreviousRepairTotal"), TextObject).Text) + Double.Parse(DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtTodayRepairTotal"), TextObject).Text)
        DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtProgressiveDeliveryTotal"), TextObject).Text = Double.Parse(DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtPreviousDeliveryTotal"), TextObject).Text) + Double.Parse(DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtTodayDeliveryTotal"), TextObject).Text)
        DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtProgressiveNRTotal"), TextObject).Text = Double.Parse(DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtPreviousNRTotal"), TextObject).Text) + Double.Parse(DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtTodayNRTotal"), TextObject).Text)
        DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtProgressiveReplaceTotal"), TextObject).Text = Double.Parse(DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtPreviousReplaceTotal"), TextObject).Text) + Double.Parse(DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtTodayReplaceTotal"), TextObject).Text)
        DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtProgressiveTotalAmountTotal"), TextObject).Text = Double.Parse(DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtPreviousTotalAmountTotal"), TextObject).Text) + Double.Parse(DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtTodayTotalAmountTotal"), TextObject).Text)
        DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtProgressiveCashsaleTotal"), TextObject).Text = Double.Parse(DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtPreviousCashsaleTotal"), TextObject).Text) + Double.Parse(DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtTodayCashsaleTotal"), TextObject).Text)
        DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtProgressiveGrossAmountTotal"), TextObject).Text = Double.Parse(DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtProgressiveTotalAmountTotal"), TextObject).Text) + Double.Parse(DirectCast(DailyReportDatewise.ReportDefinition.ReportObjects("txtProgressiveCashsaleTotal"), TextObject).Text)

#End Region

#End Region

#Region "Report Section"
        If dtReceive.Rows.Count > 0 Then
            DailyReportDatewise.Subreports("TransactionReceive").SetDataSource(dtReceive)
        End If

        If dtRepaired.Rows.Count > 0 Then
            DailyReportDatewise.Subreports("TransactionRepair").SetDataSource(dtRepaired)
        End If

        If dtDelivered.Rows.Count > 0 Then
            DailyReportDatewise.Subreports("TransactionDelivery").SetDataSource(dtDelivered)
        End If



        crvReportShow.ReportSource = DailyReportDatewise
        crvReportShow.Refresh()
#End Region


    End Sub









#Region "Daily Transaction Report Function"
#Region "Previous Data Section"
#Region "Previous Data Branch Section"

    Private Function GetPreviousTotalReceive() As Integer
        Dim claimTranMethods As clsClaiminfoMethods = New clsClaiminfoMethods
        Dim ListClaim As List(Of clsClaiminfo) = claimTranMethods.LoadClaiminfo.ToList
        Dim intTotalReceive As Integer = 0
        If ReportIdentification.ToUpper = UCase("DailyTransactionSingleDate") Then


            If Not String.IsNullOrEmpty(transClaiminfo.Branch.Trim) Then
                Dim TotalReceive = From x In ListClaim
                                   Where x.cFlag = -1 And x.ReceptDate >= "01-" & Month(dtEndDate) & "-" & Year(dtEndDate) And x.ReceptDate <= dtEndDate.AddDays(-1) And x.Branch = transClaiminfo.Branch
                intTotalReceive = TotalReceive.Count
            Else

                Dim TotalReceive = From x In ListClaim
                                   Where x.cFlag = -1 And x.ReceptDate >= "01-" & Month(dtEndDate) & "-" & Year(dtEndDate) And x.ReceptDate <= dtEndDate.AddDays(-1)
                intTotalReceive = TotalReceive.Count

            End If
        Else
            If Not String.IsNullOrEmpty(transClaiminfo.Branch.Trim) Then
                Dim TotalReceive = From x In ListClaim
                                   Where x.cFlag = -1 And x.ReceptDate >= dtStartDate And x.ReceptDate <= dtEndDate.AddDays(-1) And x.Branch = transClaiminfo.Branch
                intTotalReceive = TotalReceive.Count
            Else

                Dim TotalReceive = From x In ListClaim
                                   Where x.cFlag = -1 And x.ReceptDate >= dtStartDate And x.ReceptDate <= dtEndDate.AddDays(-1)
                intTotalReceive = TotalReceive.Count

            End If
        End If

        Return intTotalReceive
    End Function

    Private Function GetPreviousTotalRepair() As Integer
        Dim claimTranMethods As clsClaiminfoMethods = New clsClaiminfoMethods
        Dim ListClaim As List(Of clsClaiminfo) = claimTranMethods.LoadClaiminfo.ToList
        Dim intTotalRepair As Integer = 0
        If ReportIdentification.ToUpper = UCase("DailyTransactionSingleDate") Then

            If Not String.IsNullOrEmpty(transClaiminfo.Branch.Trim) Then

                Dim TotalRepair = From x In ListClaim
                                  Where x.cFlag = "1" And x.SDate >= "01-" & Month(dtEndDate) & "-" & Year(dtEndDate) And x.SDate <= dtEndDate.AddDays(-1) And x.Branch = transClaiminfo.Branch

                intTotalRepair = TotalRepair.Count
            Else

                Dim TotalRepair = From x In ListClaim
                                  Where x.cFlag = "1" And x.SDate >= "01-" & Month(dtEndDate) & "-" & Year(dtEndDate) And x.SDate <= dtEndDate.AddDays(-1)

                intTotalRepair = TotalRepair.Count
            End If
        Else
            If Not String.IsNullOrEmpty(transClaiminfo.Branch.Trim) Then

                Dim TotalRepair = From x In ListClaim
                                  Where x.cFlag = "1" And x.SDate >= dtStartDate And x.SDate <= dtEndDate.AddDays(-1) And x.Branch = transClaiminfo.Branch

                intTotalRepair = TotalRepair.Count
            Else

                Dim TotalRepair = From x In ListClaim
                                  Where x.cFlag = "1" And x.SDate >= dtStartDate And x.SDate <= dtEndDate.AddDays(-1)

                intTotalRepair = TotalRepair.Count
            End If

        End If
        Return intTotalRepair
    End Function

    Private Function GetPreviousTotalDelivery() As Integer
        Dim claimTranMethods As clsClaiminfoMethods = New clsClaiminfoMethods
        Dim intTotalRepair As Integer
        If ReportIdentification.ToUpper = UCase("DailyTransactionSingleDate") Then
            If Not String.IsNullOrEmpty(transClaiminfo.Branch.Trim) Then
                intTotalRepair = claimTranMethods.LoadClaiminfo.Where(Function(x) x.cFlag = 2 And x.DDate >= "01-" & Month(dtEndDate) & "-" & Year(dtEndDate) And x.DDate <= dtEndDate.AddDays(-1) And x.Branch = transClaiminfo.Branch).Count
                intTotalRepair = intTotalRepair + claimTranMethods.LoadClaiminfo.Where(Function(x) x.cFlag = 0 And x.DDate >= "01-" & Month(dtEndDate) & "-" & Year(dtEndDate) And x.DDate <= dtEndDate.AddDays(-1) And x.Branch = transClaiminfo.Branch).Count
            Else

                intTotalRepair = claimTranMethods.LoadClaiminfo.Where(Function(x) x.cFlag = 2 And x.DDate >= "01-" & Month(dtEndDate) & "-" & Year(dtEndDate) And x.DDate <= dtEndDate.AddDays(-1)).Count
                intTotalRepair = intTotalRepair + claimTranMethods.LoadClaiminfo.Where(Function(x) x.cFlag = 0 And x.DDate >= "01-" & Month(dtEndDate) & "-" & Year(dtEndDate) And x.DDate <= dtEndDate.AddDays(-1)).Count

            End If
        Else
            If Not String.IsNullOrEmpty(transClaiminfo.Branch.Trim) Then
                intTotalRepair = claimTranMethods.LoadClaiminfo.Where(Function(x) x.cFlag = 2 And x.DDate >= dtStartDate And x.DDate <= dtEndDate.AddDays(-1) And x.Branch = transClaiminfo.Branch).Count
                intTotalRepair = intTotalRepair + claimTranMethods.LoadClaiminfo.Where(Function(x) x.cFlag = 0 And x.DDate >= dtStartDate And x.DDate <= dtEndDate.AddDays(-1) And x.Branch = transClaiminfo.Branch).Count
            Else

                intTotalRepair = claimTranMethods.LoadClaiminfo.Where(Function(x) x.cFlag = 2 And x.DDate >= dtStartDate And x.DDate <= dtEndDate.AddDays(-1)).Count
                intTotalRepair = intTotalRepair + claimTranMethods.LoadClaiminfo.Where(Function(x) x.cFlag = 0 And x.DDate >= dtStartDate And x.DDate <= dtEndDate.AddDays(-1)).Count

            End If

        End If





        Return intTotalRepair
    End Function


    Private Function GetPreviousTotalNR() As Integer
        Dim clm As clsClaiminfoMethods = New clsClaiminfoMethods
        Dim intCountNR As Integer
        If ReportIdentification.ToUpper = UCase("DailyTransactionSingleDate") Then

            If Not String.IsNullOrEmpty(transClaiminfo.Branch.Trim) Then
                intCountNR = clm.LoadClaiminfo.Where(Function(x) x.cFlag = 99 And x.SDate >= "01-" & Month(dtEndDate) & "-" & Year(dtEndDate) And x.SDate <= dtEndDate.AddDays(-1) And x.Branch = transClaiminfo.Branch).Count()
                intCountNR = intCountNR + clm.LoadClaiminfo.Where(Function(x) x.cFlag = 100 And x.DDate >= "01-" & Month(dtEndDate) & "-" & Year(dtEndDate) And x.DDate <= dtEndDate.AddDays(-1) And x.Branch = transClaiminfo.Branch).Count()
            Else
                intCountNR = clm.LoadClaiminfo.Where(Function(x) x.cFlag = 99 And x.SDate >= "01-" & Month(dtEndDate) & "-" & Year(dtEndDate) And x.SDate <= dtEndDate.AddDays(-1)).Count()
                intCountNR = intCountNR + clm.LoadClaiminfo.Where(Function(x) x.cFlag = 100 And x.DDate >= "01-" & Month(dtEndDate) & "-" & Year(dtEndDate) And x.DDate <= dtEndDate.AddDays(-1)).Count()
            End If
        Else
            If Not String.IsNullOrEmpty(transClaiminfo.Branch.Trim) Then
                intCountNR = clm.LoadClaiminfo.Where(Function(x) x.cFlag = 99 And x.SDate >= dtStartDate And x.SDate <= dtEndDate.AddDays(-1) And x.Branch = transClaiminfo.Branch).Count()
                intCountNR = intCountNR + clm.LoadClaiminfo.Where(Function(x) x.cFlag = 100 And x.DDate >= dtStartDate And x.DDate <= dtEndDate.AddDays(-1) And x.Branch = transClaiminfo.Branch).Count()
            Else
                intCountNR = clm.LoadClaiminfo.Where(Function(x) x.cFlag = 99 And x.SDate >= dtStartDate And x.SDate <= dtEndDate.AddDays(-1)).Count()
                intCountNR = intCountNR + clm.LoadClaiminfo.Where(Function(x) x.cFlag = 100 And x.DDate >= dtStartDate And x.DDate <= dtEndDate.AddDays(-1)).Count()
            End If
        End If
        Return intCountNR
    End Function

    Private Function GetPreviousTotalReplace() As Integer
        Dim clm As clsClaiminfoMethods = New clsClaiminfoMethods
        Dim intCountReplace As Integer
        If ReportIdentification.ToUpper = UCase("DailyTransactionSingleDate") Then
            If Not String.IsNullOrEmpty(transClaiminfo.Branch.Trim) Then
                intCountReplace = clm.LoadClaiminfo.Where(Function(x) x.cFlag = 101 And x.SDate >= "01-" & Month(dtEndDate) & "-" & Year(dtEndDate) And x.SDate <= dtEndDate.AddDays(-1) And x.Branch = transClaiminfo.Branch).Count()
                intCountReplace = intCountReplace + clm.LoadClaiminfo.Where(Function(x) x.cFlag = 102 And x.DDate >= "01-" & Month(dtEndDate) & "-" & Year(dtEndDate) And x.DDate <= dtEndDate.AddDays(-1) And x.Branch = transClaiminfo.Branch).Count()
            Else
                intCountReplace = clm.LoadClaiminfo.Where(Function(x) x.cFlag = 101 And x.SDate >= "01-" & Month(dtEndDate) & "-" & Year(dtEndDate) And x.SDate <= dtEndDate.AddDays(-1)).Count()
                intCountReplace = intCountReplace + clm.LoadClaiminfo.Where(Function(x) x.cFlag = 102 And x.DDate >= "01-" & Month(dtEndDate) & "-" & Year(dtEndDate) And x.DDate <= dtEndDate.AddDays(-1)).Count()
            End If
        Else
            If Not String.IsNullOrEmpty(transClaiminfo.Branch.Trim) Then
                intCountReplace = clm.LoadClaiminfo.Where(Function(x) x.cFlag = 101 And x.SDate >= dtStartDate And x.SDate <= dtEndDate.AddDays(-1) And x.Branch = transClaiminfo.Branch).Count()
                intCountReplace = intCountReplace + clm.LoadClaiminfo.Where(Function(x) x.cFlag = 102 And x.DDate >= dtStartDate And x.DDate <= dtEndDate.AddDays(-1) And x.Branch = transClaiminfo.Branch).Count()
            Else
                intCountReplace = clm.LoadClaiminfo.Where(Function(x) x.cFlag = 101 And x.SDate >= dtStartDate And x.SDate <= dtEndDate.AddDays(-1)).Count()
                intCountReplace = intCountReplace + clm.LoadClaiminfo.Where(Function(x) x.cFlag = 102 And x.DDate >= dtStartDate And x.DDate <= dtEndDate.AddDays(-1)).Count()
            End If
        End If
        Return intCountReplace
    End Function

    Private Function GetPreviousTotalTotalAmount() As Double
        Dim clm As clsClaiminfoMethods = New clsClaiminfoMethods
        Dim dblTotalAmount As Double
        If ReportIdentification.ToUpper = UCase("DailyTransactionSingleDate") Then

            If Not String.IsNullOrEmpty(transClaiminfo.Branch.Trim) Then
                dblTotalAmount = clm.LoadClaiminfo.Where(Function(x) x.cFlag = 2 And x.DDate >= "01-" & Month(dtEndDate) & "-" & Year(dtEndDate) And x.DDate <= dtEndDate.AddDays(-1) And x.Branch = transClaiminfo.Branch).Sum(Function(x) (x.SvAmt + x.PrdAmt + x.OtherAmt + x.VatAmnt) - (x.Dis + x.AdvanceAmnt))
                dblTotalAmount = clm.LoadClaiminfo.Where(Function(x) x.cFlag = 0 And x.DDate >= "01-" & Month(dtEndDate) & "-" & Year(dtEndDate) And x.DDate <= dtEndDate.AddDays(-1) And x.Branch = transClaiminfo.Branch).Sum(Function(x) (x.SvAmt + x.PrdAmt + x.OtherAmt + x.VatAmnt) - (x.Dis + x.AdvanceAmnt))
            Else
                dblTotalAmount = clm.LoadClaiminfo.Where(Function(x) x.cFlag = 2 And x.DDate >= "01-" & Month(dtEndDate) & "-" & Year(dtEndDate) And x.DDate <= dtEndDate.AddDays(-1)).Sum(Function(x) (x.SvAmt + x.PrdAmt + x.OtherAmt + x.VatAmnt) - (x.Dis + x.AdvanceAmnt))
                dblTotalAmount = dblTotalAmount + clm.LoadClaiminfo.Where(Function(x) x.cFlag = 0 And x.DDate >= "01-" & Month(dtEndDate) & "-" & Year(dtEndDate) And x.DDate <= dtEndDate.AddDays(-1)).Sum(Function(x) (x.SvAmt + x.PrdAmt + x.OtherAmt + x.VatAmnt) - (x.Dis + x.AdvanceAmnt))
            End If
        Else
            If Not String.IsNullOrEmpty(transClaiminfo.Branch.Trim) Then
                dblTotalAmount = clm.LoadClaiminfo.Where(Function(x) x.cFlag = 2 And x.DDate >= dtStartDate And x.DDate <= dtEndDate.AddDays(-1) And x.Branch = transClaiminfo.Branch).Sum(Function(x) (x.SvAmt + x.PrdAmt + x.OtherAmt + x.VatAmnt) - (x.Dis + x.AdvanceAmnt))
                dblTotalAmount = clm.LoadClaiminfo.Where(Function(x) x.cFlag = 0 And x.DDate >= dtStartDate And x.DDate <= dtEndDate.AddDays(-1) And x.Branch = transClaiminfo.Branch).Sum(Function(x) (x.SvAmt + x.PrdAmt + x.OtherAmt + x.VatAmnt) - (x.Dis + x.AdvanceAmnt))
            Else
                dblTotalAmount = clm.LoadClaiminfo.Where(Function(x) x.cFlag = 2 And x.DDate >= dtStartDate And x.DDate <= dtEndDate.AddDays(-1)).Sum(Function(x) (x.SvAmt + x.PrdAmt + x.OtherAmt + x.VatAmnt) - (x.Dis + x.AdvanceAmnt))
                dblTotalAmount = dblTotalAmount + clm.LoadClaiminfo.Where(Function(x) x.cFlag = 0 And x.DDate >= dtStartDate And x.DDate <= dtEndDate.AddDays(-1)).Sum(Function(x) (x.SvAmt + x.PrdAmt + x.OtherAmt + x.VatAmnt) - (x.Dis + x.AdvanceAmnt))
            End If
        End If
        Return dblTotalAmount
    End Function
    Private Function GetPreviousTotalCashsale() As Double
        Dim cashsalesMethods As clsCashsalesMethods = New clsCashsalesMethods
        Dim dblTotalAmount As Double
        If ReportIdentification.ToUpper = UCase("DailyTransactionSingleDate") Then

            If Not String.IsNullOrEmpty(transClaiminfo.Branch.Trim) Then
                dblTotalAmount = cashsalesMethods.GetCashsalesTotalAmount.Where(Function(x) x.ReceptDate >= "01-" & Month(dtEndDate) & "-" & Year(dtEndDate) And x.ReceptDate <= dtEndDate.AddDays(-1) And x.Branch = transClaiminfo.Branch).Sum(Function(x) x.NetAmnt)
            Else
                dblTotalAmount = cashsalesMethods.GetCashsalesTotalAmount.Where(Function(x) x.ReceptDate >= "01-" & Month(dtEndDate) & "-" & Year(dtEndDate) And x.ReceptDate <= dtEndDate.AddDays(-1)).Sum(Function(x) x.NetAmnt)
            End If
        Else
            If Not String.IsNullOrEmpty(transClaiminfo.Branch.Trim) Then
                dblTotalAmount = cashsalesMethods.GetCashsalesTotalAmount.Where(Function(x) x.ReceptDate >= dtStartDate And x.ReceptDate <= dtEndDate.AddDays(-1) And x.Branch = transClaiminfo.Branch).Sum(Function(x) x.NetAmnt)
            Else
                dblTotalAmount = cashsalesMethods.GetCashsalesTotalAmount.Where(Function(x) x.ReceptDate >= dtStartDate And x.ReceptDate <= dtEndDate.AddDays(-1)).Sum(Function(x) x.NetAmnt)
            End If
        End If

        Return dblTotalAmount
    End Function

    Private Function GetPreviousGrossAmount() As Double
        Dim dblGrossAmount As Double


        dblGrossAmount = GetPreviousTotalTotalAmount()
        dblGrossAmount += GetPreviousTotalCashsale()

        Return dblGrossAmount

    End Function



#End Region
#Region "Previous Data Other Branch Section"
    Private Function GetPreviousTotalReceiveOtherBranch() As Integer
        Dim claimTranMethods As clsClaiminfoMethods = New clsClaiminfoMethods
        Dim ListClaim As List(Of clsClaiminfo) = claimTranMethods.LoadClaiminfo.ToList
        Dim intTotalReceive As Integer = 0
        If ReportIdentification.ToUpper = UCase("DailyTransactionSingleDate") Then
            Dim TotalReceive = From x In ListClaim
                               Where x.cFlag = -1 And x.ReceptDate >= "01-" & Month(dtEndDate) & "-" & Year(dtEndDate) And x.ReceptDate <= dtEndDate.AddDays(-1) And x.Branch <> transClaiminfo.Branch

            intTotalReceive = TotalReceive.Count
        Else
            Dim TotalReceive = From x In ListClaim
                               Where x.cFlag = -1 And x.ReceptDate >= dtStartDate And x.ReceptDate <= dtEndDate.AddDays(-1) And x.Branch <> transClaiminfo.Branch

            intTotalReceive = TotalReceive.Count
        End If
        Return intTotalReceive

    End Function

    Private Function GetPreviousTotalRepairOtherBranch() As Integer
        Dim claimTranMethods As clsClaiminfoMethods = New clsClaiminfoMethods
        Dim ListClaim As List(Of clsClaiminfo) = claimTranMethods.LoadClaiminfo.ToList
        Dim intTotalRepair As Integer = 0
        If ReportIdentification.ToUpper = UCase("DailyTransactionSingleDate") Then
            Dim TotalRepair = From x In ListClaim
                              Where x.cFlag = "1" And x.SDate >= "01-" & Month(dtEndDate) & "-" & Year(dtEndDate) And x.SDate <= dtEndDate.AddDays(-1) And x.Branch <> transClaiminfo.Branch


            intTotalRepair = TotalRepair.Count
        Else
            Dim TotalRepair = From x In ListClaim
                              Where x.cFlag = "1" And x.SDate >= dtStartDate And x.SDate <= dtEndDate.AddDays(-1) And x.Branch <> transClaiminfo.Branch
            intTotalRepair = TotalRepair.Count
        End If

        Return intTotalRepair
    End Function

    Private Function GetPreviousTotalDeliveryOtherBranch() As Integer
        Dim claimTranMethods As clsClaiminfoMethods = New clsClaiminfoMethods
        Dim intTotalDelivery As Integer
        If ReportIdentification.ToUpper = UCase("DailyTransactionSingleDate") Then
            intTotalDelivery = claimTranMethods.LoadClaiminfo.Where(Function(x) x.cFlag = 2 And x.DDate >= "01-" & Month(dtEndDate) & "-" & Year(dtEndDate) And x.DDate <= dtEndDate.AddDays(-1) And x.Branch <> transClaiminfo.Branch).Count
            intTotalDelivery += claimTranMethods.LoadClaiminfo.Where(Function(x) x.cFlag = 0 And x.DDate >= "01-" & Month(dtEndDate) & "-" & Year(dtEndDate) And x.DDate <= dtEndDate.AddDays(-1) And x.Branch <> transClaiminfo.Branch).Count
        Else
            intTotalDelivery = claimTranMethods.LoadClaiminfo.Where(Function(x) x.cFlag = 2 And x.DDate >= dtStartDate And x.DDate <= dtEndDate.AddDays(-1) And x.Branch <> transClaiminfo.Branch).Count
            intTotalDelivery += claimTranMethods.LoadClaiminfo.Where(Function(x) x.cFlag = 0 And x.DDate >= dtStartDate And x.DDate <= dtEndDate.AddDays(-1) And x.Branch <> transClaiminfo.Branch).Count
        End If

        Return intTotalDelivery
    End Function


    Private Function GetPreviousTotalNROtherBranch() As Integer
        Dim clm As clsClaiminfoMethods = New clsClaiminfoMethods
        Dim intCountNR As Integer
        If ReportIdentification.ToUpper = UCase("DailyTransactionSingleDate") Then
            intCountNR = clm.LoadClaiminfo.Where(Function(x) x.cFlag = 99 And x.SDate >= "01-" & Month(dtEndDate) & "-" & Year(dtEndDate) And x.SDate <= dtEndDate.AddDays(-1) And x.Branch <> transClaiminfo.Branch).Count()
            intCountNR = intCountNR + clm.LoadClaiminfo.Where(Function(x) x.cFlag = 100 And x.DDate >= "01-" & Month(dtEndDate) & "-" & Year(dtEndDate) And x.DDate <= dtEndDate.AddDays(-1) And x.Branch <> transClaiminfo.Branch).Count()
        Else
            intCountNR = clm.LoadClaiminfo.Where(Function(x) x.cFlag = 99 And x.SDate >= dtStartDate And x.SDate <= dtEndDate.AddDays(-1) And x.Branch <> transClaiminfo.Branch).Count()
            intCountNR = intCountNR + clm.LoadClaiminfo.Where(Function(x) x.cFlag = 100 And x.DDate >= dtStartDate And x.DDate <= dtEndDate.AddDays(-1) And x.Branch <> transClaiminfo.Branch).Count()
        End If

        Return intCountNR
    End Function

    Private Function GetPreviousTotalReplaceOtherBranch() As Integer
        Dim clm As clsClaiminfoMethods = New clsClaiminfoMethods
        Dim intCountReplace As Integer
        If ReportIdentification.ToUpper = UCase("DailyTransactionSingleDate") Then
            intCountReplace = clm.LoadClaiminfo.Where(Function(x) x.cFlag = 101 And x.SDate >= "01-" & Month(dtEndDate) & "-" & Year(dtEndDate) And x.SDate <= dtEndDate.AddDays(-1) And x.Branch <> transClaiminfo.Branch).Count()
            intCountReplace = intCountReplace + clm.LoadClaiminfo.Where(Function(x) x.cFlag = 102 And x.DDate >= "01-" & Month(dtEndDate) & "-" & Year(dtEndDate) And x.DDate <= dtEndDate.AddDays(-1) And x.Branch <> transClaiminfo.Branch).Count()
        Else
            intCountReplace = clm.LoadClaiminfo.Where(Function(x) x.cFlag = 101 And x.SDate >= dtStartDate And x.SDate <= dtEndDate.AddDays(-1) And x.Branch <> transClaiminfo.Branch).Count()
            intCountReplace = intCountReplace + clm.LoadClaiminfo.Where(Function(x) x.cFlag = 102 And x.DDate >= dtStartDate And x.DDate <= dtEndDate.AddDays(-1) And x.Branch <> transClaiminfo.Branch).Count()
        End If

        Return intCountReplace
    End Function

    Private Function GetPreviousTotalTotalAmountOtherBranch() As Double
        Dim clm As clsClaiminfoMethods = New clsClaiminfoMethods
        Dim dblTotalAmount As Double
        If ReportIdentification.ToUpper = UCase("DailyTransactionSingleDate") Then
            dblTotalAmount = clm.LoadClaiminfo.Where(Function(x) x.cFlag = 2 And x.DDate >= "01-" & Month(dtEndDate) & "-" & Year(dtEndDate) And x.DDate <= dtEndDate.AddDays(-1) And x.Branch <> transClaiminfo.Branch).Sum(Function(x) (x.SvAmt + x.PrdAmt + x.OtherAmt + x.VatAmnt) - (x.Dis + x.AdvanceAmnt))
            dblTotalAmount = dblTotalAmount + clm.LoadClaiminfo.Where(Function(x) x.cFlag = 0 And x.DDate >= "01-" & Month(dtEndDate) & "-" & Year(dtEndDate) And x.DDate <= dtEndDate.AddDays(-1) And x.Branch <> transClaiminfo.Branch).Sum(Function(x) (x.SvAmt + x.PrdAmt + x.OtherAmt + x.VatAmnt) - (x.Dis + x.AdvanceAmnt))
        Else
            dblTotalAmount = clm.LoadClaiminfo.Where(Function(x) x.cFlag = 2 And x.DDate >= dtStartDate And x.DDate <= dtEndDate.AddDays(-1) And x.Branch <> transClaiminfo.Branch).Sum(Function(x) (x.SvAmt + x.PrdAmt + x.OtherAmt + x.VatAmnt) - (x.Dis + x.AdvanceAmnt))
            dblTotalAmount = dblTotalAmount + clm.LoadClaiminfo.Where(Function(x) x.cFlag = 0 And x.DDate >= dtStartDate And x.DDate <= dtEndDate.AddDays(-1) And x.Branch <> transClaiminfo.Branch).Sum(Function(x) (x.SvAmt + x.PrdAmt + x.OtherAmt + x.VatAmnt) - (x.Dis + x.AdvanceAmnt))
        End If

        Return dblTotalAmount
    End Function
    Private Function GetPreviousTotalCashsaleOtherBranch() As Double
        Dim cashsalesMethods As clsCashsalesMethods = New clsCashsalesMethods
        Dim dblTotalAmount As Double
        'Dim lstCashsales As List(Of clsCashsales) = New List(Of clsCashsales)
        If ReportIdentification.ToUpper = UCase("DailyTransactionSingleDate") Then
            dblTotalAmount = cashsalesMethods.GetCashsalesTotalAmount.Where(Function(x) x.ReceptDate >= "01-" & Month(dtEndDate) & "-" & Year(dtEndDate) And x.ReceptDate <= dtEndDate.AddDays(-1) And x.Branch <> transClaiminfo.Branch).Sum(Function(x) x.NetAmnt)
        Else
            dblTotalAmount = cashsalesMethods.GetCashsalesTotalAmount.Where(Function(x) x.ReceptDate >= dtStartDate And x.ReceptDate <= dtEndDate.AddDays(-1) And x.Branch <> transClaiminfo.Branch).Sum(Function(x) x.NetAmnt)
        End If
        Return dblTotalAmount
    End Function

    Private Function GetPreviousGrossAmountOtherBranch() As Double
        Dim dblGrossAmount As Double
        dblGrossAmount = GetPreviousTotalTotalAmountOtherBranch()
        dblGrossAmount += GetPreviousTotalCashsaleOtherBranch()
        Return dblGrossAmount
    End Function
#End Region


#End Region

#Region "Today Data Section"
#Region "Today Data Branch Section"

    Private Function GetTodayTotalReceive() As Integer
        Dim claimTranMethods As clsClaiminfoMethods = New clsClaiminfoMethods
        Dim ListClaim As List(Of clsClaiminfo) = claimTranMethods.LoadClaiminfo.ToList
        Dim intTotalReceive As Integer = 0
        If Not String.IsNullOrEmpty(transClaiminfo.Branch.Trim) Then
            Dim TotalReceive = From x In ListClaim
                               Where x.cFlag = -1 And x.ReceptDate = dtEndDate And x.Branch = transClaiminfo.Branch
            intTotalReceive = TotalReceive.Count
        Else

            Dim TotalReceive = From x In ListClaim
                               Where x.cFlag = -1 And x.ReceptDate = dtEndDate
            intTotalReceive = TotalReceive.Count

        End If
        Return intTotalReceive
    End Function

    Private Function GetTodayTotalRepair() As Integer
        Dim claimTranMethods As clsClaiminfoMethods = New clsClaiminfoMethods
        Dim ListClaim As List(Of clsClaiminfo) = claimTranMethods.LoadClaiminfo.ToList
        Dim intTotalRepair As Integer = 0
        If Not String.IsNullOrEmpty(transClaiminfo.Branch.Trim) Then

            Dim TotalRepair = From x In ListClaim
                              Where x.cFlag = "1" And x.SDate = dtEndDate And x.Branch = transClaiminfo.Branch

            intTotalRepair = TotalRepair.Count
        Else

            Dim TotalRepair = From x In ListClaim
                              Where x.cFlag = "1" And x.SDate = dtEndDate

            intTotalRepair = TotalRepair.Count
        End If
        Return intTotalRepair
    End Function

    Private Function GetTodayTotalDelivery() As Integer
        Dim claimTranMethods As clsClaiminfoMethods = New clsClaiminfoMethods
        Dim intTotalRepair As Integer
        If Not String.IsNullOrEmpty(transClaiminfo.Branch.Trim) Then
            intTotalRepair = claimTranMethods.LoadClaiminfo.Where(Function(x) x.cFlag = 2 And x.DDate = dtEndDate And x.Branch = transClaiminfo.Branch).Count
            intTotalRepair = intTotalRepair + claimTranMethods.LoadClaiminfo.Where(Function(x) x.cFlag = 0 And x.DDate = dtEndDate And x.Branch = transClaiminfo.Branch).Count
        Else

            intTotalRepair = claimTranMethods.LoadClaiminfo.Where(Function(x) x.cFlag = 2 And x.DDate = dtEndDate).Count
            intTotalRepair = intTotalRepair + claimTranMethods.LoadClaiminfo.Where(Function(x) x.cFlag = 0 And x.DDate = dtEndDate).Count

        End If
        Return intTotalRepair
    End Function


    Private Function GetTodayTotalNR() As Integer
        Dim clm As clsClaiminfoMethods = New clsClaiminfoMethods
        Dim intCountNR As Integer
        If Not String.IsNullOrEmpty(transClaiminfo.Branch.Trim) Then
            intCountNR = clm.LoadClaiminfo.Where(Function(x) x.cFlag = 99 And x.SDate = dtEndDate And x.Branch = transClaiminfo.Branch).Count()
            intCountNR = intCountNR + clm.LoadClaiminfo.Where(Function(x) x.cFlag = 100 And x.DDate = dtEndDate And x.Branch = transClaiminfo.Branch).Count()
        Else
            intCountNR = clm.LoadClaiminfo.Where(Function(x) x.cFlag = 99 And x.SDate = dtEndDate).Count()
            intCountNR = intCountNR + clm.LoadClaiminfo.Where(Function(x) x.cFlag = 100 And x.DDate = dtEndDate).Count()
        End If

        Return intCountNR
    End Function

    Private Function GetTodayTotalReplace() As Integer
        Dim clm As clsClaiminfoMethods = New clsClaiminfoMethods
        Dim intCountReplace As Integer
        If Not String.IsNullOrEmpty(transClaiminfo.Branch.Trim) Then
            intCountReplace = clm.LoadClaiminfo.Where(Function(x) x.cFlag = 101 And x.SDate = dtEndDate And x.Branch = transClaiminfo.Branch).Count()
            intCountReplace = intCountReplace + clm.LoadClaiminfo.Where(Function(x) x.cFlag = 102 And x.DDate <= dtEndDate And x.Branch = transClaiminfo.Branch).Count()
        Else
            intCountReplace = clm.LoadClaiminfo.Where(Function(x) x.cFlag = 101 And x.SDate = dtEndDate).Count()
            intCountReplace = intCountReplace + clm.LoadClaiminfo.Where(Function(x) x.cFlag = 102 And x.DDate = dtEndDate).Count()
        End If

        Return intCountReplace
    End Function

    Private Function GetTodayTotalTotalAmount() As Double
        Dim clm As clsClaiminfoMethods = New clsClaiminfoMethods
        Dim dblTotalAmount As Double
        If Not String.IsNullOrEmpty(transClaiminfo.Branch.Trim) Then
            dblTotalAmount = clm.LoadClaiminfo.Where(Function(x) x.cFlag = 2 And x.DDate = dtEndDate And x.Branch = transClaiminfo.Branch).Sum(Function(x) (x.SvAmt + x.PrdAmt + x.OtherAmt + x.VatAmnt) - (x.Dis + x.AdvanceAmnt))
            dblTotalAmount = clm.LoadClaiminfo.Where(Function(x) x.cFlag = 0 And x.DDate = dtEndDate And x.Branch = transClaiminfo.Branch).Sum(Function(x) (x.SvAmt + x.PrdAmt + x.OtherAmt + x.VatAmnt) - (x.Dis + x.AdvanceAmnt))
        Else
            dblTotalAmount = clm.LoadClaiminfo.Where(Function(x) x.cFlag = 2 And x.DDate = dtEndDate).Sum(Function(x) (x.SvAmt + x.PrdAmt + x.OtherAmt + x.VatAmnt) - (x.Dis + x.AdvanceAmnt))
            dblTotalAmount = dblTotalAmount + clm.LoadClaiminfo.Where(Function(x) x.cFlag = 0 And x.DDate = dtEndDate).Sum(Function(x) (x.SvAmt + x.PrdAmt + x.OtherAmt + x.VatAmnt) - (x.Dis + x.AdvanceAmnt))
        End If
        Return dblTotalAmount
    End Function
    Private Function GetTodayTotalCashsale() As Double
        Dim cashsalesMethods As clsCashsalesMethods = New clsCashsalesMethods
        Dim dblTotalAmount As Double

        If Not String.IsNullOrEmpty(transClaiminfo.Branch.Trim) Then
            dblTotalAmount = cashsalesMethods.GetCashsalesTotalAmount.Where(Function(x) x.ReceptDate = dtEndDate And x.Branch = transClaiminfo.Branch).Sum(Function(x) x.NetAmnt)
        Else
            dblTotalAmount = cashsalesMethods.GetCashsalesTotalAmount.Where(Function(x) x.ReceptDate = dtEndDate).Sum(Function(x) x.NetAmnt)
        End If

        Return dblTotalAmount
    End Function

    Private Function GetTodayGrossAmount() As Double
        Dim dblGrossAmount As Double


        dblGrossAmount = GetTodayTotalTotalAmount()
        dblGrossAmount += GetTodayTotalCashsale()

        Return dblGrossAmount

    End Function



#End Region
#Region "Today Data Other Branch Section"
    Private Function GetTodayTotalReceiveOtherBranch() As Integer
        Dim claimTranMethods As clsClaiminfoMethods = New clsClaiminfoMethods
        Dim ListClaim As List(Of clsClaiminfo) = claimTranMethods.LoadClaiminfo.ToList
        Dim intTotalReceive As Integer = 0
        Dim TotalReceive = From x In ListClaim
                           Where x.cFlag = -1 And x.ReceptDate = dtEndDate And x.Branch <> transClaiminfo.Branch

        intTotalReceive = TotalReceive.Count
        Return intTotalReceive

    End Function

    Private Function GetTodayTotalRepairOtherBranch() As Integer
        Dim claimTranMethods As clsClaiminfoMethods = New clsClaiminfoMethods
        Dim ListClaim As List(Of clsClaiminfo) = claimTranMethods.LoadClaiminfo.ToList
        Dim intTotalRepair As Integer = 0
        Dim TotalRepair = From x In ListClaim
                          Where x.cFlag = "1" And x.ReceptDate = dtEndDate And x.Branch <> transClaiminfo.Branch


        intTotalRepair = TotalRepair.Count
        Return intTotalRepair
    End Function

    Private Function GetTodayTotalDeliveryOtherBranch() As Integer
        Dim claimTranMethods As clsClaiminfoMethods = New clsClaiminfoMethods
        Dim intTotalDelivery As Integer
        intTotalDelivery = claimTranMethods.LoadClaiminfo.Where(Function(x) x.cFlag = 2 And x.DDate = dtEndDate And x.Branch <> transClaiminfo.Branch).Count
        intTotalDelivery += claimTranMethods.LoadClaiminfo.Where(Function(x) x.cFlag = 0 And x.DDate = dtEndDate And x.Branch <> transClaiminfo.Branch).Count
        Return intTotalDelivery
    End Function


    Private Function GetTodayTotalNROtherBranch() As Integer
        Dim clm As clsClaiminfoMethods = New clsClaiminfoMethods
        Dim intCountNR As Integer
        intCountNR = clm.LoadClaiminfo.Where(Function(x) x.cFlag = 99 And x.SDate = dtEndDate And x.Branch <> transClaiminfo.Branch).Count()
        intCountNR = intCountNR + clm.LoadClaiminfo.Where(Function(x) x.cFlag = 100 And x.DDate = dtEndDate And x.Branch <> transClaiminfo.Branch).Count()
        Return intCountNR
    End Function

    Private Function GetTodayTotalReplaceOtherBranch() As Integer
        Dim clm As clsClaiminfoMethods = New clsClaiminfoMethods
        Dim intCountReplace As Integer
        intCountReplace = clm.LoadClaiminfo.Where(Function(x) x.cFlag = 101 And x.SDate = dtEndDate And x.Branch <> transClaiminfo.Branch).Count()
        intCountReplace = intCountReplace + clm.LoadClaiminfo.Where(Function(x) x.cFlag = 102 And x.DDate = dtEndDate And x.Branch <> transClaiminfo.Branch).Count()
        Return intCountReplace
    End Function

    Private Function GetTodayTotalTotalAmountOtherBranch() As Double
        Dim clm As clsClaiminfoMethods = New clsClaiminfoMethods
        Dim dblTotalAmount As Double
        dblTotalAmount = clm.LoadClaiminfo.Where(Function(x) x.cFlag = 2 And x.DDate = dtEndDate And x.Branch <> transClaiminfo.Branch).Sum(Function(x) (x.SvAmt + x.PrdAmt + x.OtherAmt + x.VatAmnt) - (x.Dis + x.AdvanceAmnt))
        dblTotalAmount = dblTotalAmount + clm.LoadClaiminfo.Where(Function(x) x.cFlag = 0 And x.DDate = dtEndDate And x.Branch <> transClaiminfo.Branch).Sum(Function(x) (x.SvAmt + x.PrdAmt + x.OtherAmt + x.VatAmnt) - (x.Dis + x.AdvanceAmnt))
        Return dblTotalAmount
    End Function
    Private Function GetTodayTotalCashsaleOtherBranch() As Double
        Dim cashsalesMethods As clsCashsalesMethods = New clsCashsalesMethods
        Dim dblTotalAmount As Double
        'Dim lstCashsales As List(Of clsCashsales) = New List(Of clsCashsales)

        dblTotalAmount = cashsalesMethods.GetCashsalesTotalAmount.Where(Function(x) x.ReceptDate = dtEndDate And x.Branch <> transClaiminfo.Branch).Sum(Function(x) x.NetAmnt)

        Return dblTotalAmount
    End Function

    Private Function GetTodayGrossAmountOtherBranch() As Double
        Dim dblGrossAmount As Double
        dblGrossAmount = GetTodayTotalTotalAmountOtherBranch()
        dblGrossAmount += GetTodayTotalCashsaleOtherBranch()
        Return dblGrossAmount
    End Function

    Private Sub crvReportShow_Load(sender As Object, e As EventArgs) Handles crvReportShow.Load

    End Sub
#End Region
#End Region
#End Region 'This is Transaction All Function Section

End Class