Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Configuration


Public Class frmLoadDatabase

    Dim strFileName As String

    Dim chkConstrainErrorFlag As Boolean
    Dim blnJoinFlag As Boolean
    Dim strPreviousModel() As String
    Dim strCurrentModel() As String
    Dim intCurrentbrdid() As Long
    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Me.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub pnlHeader_Paint(sender As Object, e As PaintEventArgs) Handles pnlHeader.Paint

    End Sub

    Private Sub pnlHeader_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlHeader.MouseDown
        ReleaseCapture()
        SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)

    End Sub

    Private Sub frmLoadDatabase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        JoinRelationshiptmptmp("Drop")
        JoinRelationshiptmptmp("Join")
    End Sub

    Private Sub frmLoadDatabase_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        ReleaseCapture()
        SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)

    End Sub

    Private Sub pnlFooter_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlFooter.MouseDown
        ReleaseCapture()
        SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)

    End Sub

    Private Sub btnSetBranch_Click(sender As Object, e As EventArgs) Handles btnSetBranch.Click



        cmnFileName.Filter = "mdb|*.mdb"

        cmnFileName.ShowDialog()


        strFileName = cmnFileName.FileName

        If strFileName.Length <= 0 Then

            Exit Sub
        Else
            LoadBranch(strFileName)


        End If



    End Sub

    Private Sub LoadBranch(ByVal PathName As String)

        Dim strProvider As String = "Provider=Microsoft.Jet.Oledb.4.0; Data Source=" & PathName



        Using con As OleDbConnection = New OleDbConnection(strProvider)


            Dim dc As OleDbCommand = New OleDbCommand("Select Distinct Branch from Claiminfo", con)

            con.Open()
            Dim dr As OleDbDataReader = dc.ExecuteReader

            If dr.HasRows = True Then
                cmbBranch.Items.Clear()

                While dr.Read()

                    cmbBranch.Items.Add(dr("Branch").ToString)
                End While

            End If



        End Using



    End Sub

    Private Sub btnLoadBranch_Click(sender As Object, e As EventArgs) Handles btnLoadBranch.Click
        'Check Branch Combo box is blank or not
        If cmbBranch.Text.Length <= 0 Then
            MessageBox.Show("Branch Not Set")
            cmbBranch.Select()
            Exit Sub
        End If


        Try
            DeleteRecord() ' Delete All Previous Records by Seleted Branch Before Date Load Started

            cmdDeleteTable() ' Delete All Temp Table which are imported from other database

            ' Insert Table into Destination Database from source database

            Dim StrConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & strFileName

            Dim DataBasePath As String = GetDataBasePath()




            Dim strSQL As String
            Using con As OleDbConnection = New OleDbConnection(StrConnection)


                Dim dc As OleDbCommand = New OleDbCommand
                dc.Connection = con
                con.Open()

                strSQL = ""
                strSQL = "SELECT AdvanceInfo.JobCode, AdvanceInfo.Branch, AdvanceInfo.AdvNo, AdvanceInfo.AdvDate, AdvanceInfo.AdvAmnt, "
                strSQL = strSQL & "AdvanceInfo.AdvRemarks, AdvanceInfo.PayType, AdvanceInfo.BankName, AdvanceInfo.CardNo "
                strSQL = strSQL & "into AdvanceInfo1 in '" & DataBasePath & "' FROM AdvanceInfo inner Join Claiminfo on AdvanceInfo.JobCode=Claiminfo.JobCode where Claiminfo.ReceptDate Between #" & dtpFrom.Value & "# and #" & dtpTo.Value & "# and Claiminfo.Branch='" & cmbBranch.Text & "'"
                dc.CommandText = strSQL
                dc.ExecuteNonQuery()

                '____________________________________________________________________________________________________________________

                strSQL = ""

                strSQL = "SELECT * "
                strSQL = strSQL & " into cType1 in '" & DataBasePath & "' FROM cType"
                dc.CommandText = strSQL
                dc.ExecuteNonQuery()
                '____________________________________________________________________________________________________________________


                strSQL = ""

                strSQL = "SELECT Brand.brdid, Brand.cType,Brand.Brand,Brand.Item,Brand.SlNo,Brand.Tat,'' as Pbrdid "
                strSQL = strSQL & " into Brand1 in '" & DataBasePath & "' FROM Brand"
                dc.CommandText = strSQL
                dc.ExecuteNonQuery()
                '____________________________________________________________________________________________________________________

                strSQL = ""

                strSQL = "SELECT BrandModel.Model, BrandModel.BrdID, BrandModel.Charge, BrandModel.WPeriod, BrandModel.Item, BrandModel.SLNO, BrandModel.EntryDate"
                strSQL = strSQL & " into BrandModel1 in '" & DataBasePath & "' From BrandModel"
                dc.CommandText = strSQL
                dc.ExecuteNonQuery()
                '____________________________________________________________________________________________________________________





                strSQL = ""
                strSQL = "SELECT ClaimInfo.JobCode, ClaimInfo.Branch, ClaimInfo.CustName, ClaimInfo.CustAddress1, ClaimInfo.CustAddress2, ClaimInfo.Brand,"
                strSQL = strSQL & "ClaimInfo.ModelNo, ClaimInfo.MobileNo, ClaimInfo.ESN, ClaimInfo.SLNo, ClaimInfo.ReceptDate, ClaimInfo.AppDelDate,"
                strSQL = strSQL & "ClaimInfo.ServiceType, ClaimInfo.PDate, ClaimInfo.ReceptBy, ClaimInfo.IssueTo, ClaimInfo.IsssueDate, ClaimInfo.SDate,"
                strSQL = strSQL & "ClaimInfo.ServiceBy, ClaimInfo.DDate, ClaimInfo.DeliverBy, ClaimInfo.WCondition, ClaimInfo.cFlag, ClaimInfo.SvAmt,"
                strSQL = strSQL & "ClaimInfo.PrdAmt, ClaimInfo.OtherAmt, ClaimInfo.Dis, ClaimInfo.SRFlag, ClaimInfo.Remk, ClaimInfo.PhyCond, ClaimInfo.Log_User,"
                strSQL = strSQL & "ClaimInfo.Log_Date, ClaimInfo.MRNO, ClaimInfo.LastJobNO, ClaimInfo.cAdvance, ClaimInfo.cTransportCrg,"
                strSQL = strSQL & "ClaimInfo.ReturnedItems, ClaimInfo.ItemRemarks, ClaimInfo.FreeOfCost, ClaimInfo.AdvanceAmnt, ClaimInfo.VatAmnt"
                strSQL = strSQL & " into Claiminfo1 in '" & DataBasePath & "' FROM ClaimInfo where Claiminfo.ReceptDate Between #" & dtpFrom.Value & "# and #" & dtpTo.Value & "# and Claiminfo.Branch='" & cmbBranch.Text & "'"
                dc.CommandText = strSQL
                dc.ExecuteNonQuery()

                '____________________________________________________________________________________________________________________


                strSQL = ""
                strSQL = "Select CustomerClaim.JobCode,CustomerClaim.ClaimCode into CustomerClaim1 in '" & DataBasePath & "'  from CustomerClaim inner Join Claiminfo on CustomerClaim.JobCode=Claiminfo.JobCode where Claiminfo.ReceptDate Between #" & dtpFrom.Value & "# and #" & dtpTo.Value & "# and Claiminfo.Branch='" & cmbBranch.Text & "'"
                dc.CommandText = strSQL
                dc.ExecuteNonQuery()
                '____________________________________________________________________________________________________________________

                'strSQL = ""
                'strSQL = "Select CustomerClaimOthers.JobCode,CustomerClaimOthers.ClaimCode into CustomerClaimOthers1 in '" & DataBasePath() & "'  from CustomerClaimOthers inner Join Claiminfo on CustomerClaimOthers.JobCode=Claiminfo.JobCode where Claiminfo.ReceptDate Between #" & dtpFrom.Value & "# and #" & dtpTo.Value & "# and Claiminfo.Branch='" & cmbBranch.Text & "'"
                'dc.CommandText = strSQL
                'dc.ExecuteNonQuery()
                '____________________________________________________________________________________________________________________

                strSQL = ""
                strSQL = "SELECT CashSales.MRNO, CashSales.JobCode, CashSales.Branch, CashSales.CustName, CashSales.CustAddress1, CashSales.CustAddress2, CashSales.Brand, CashSales.ModelNo, CashSales.ESN, CashSales.SLNo, CashSales.ReceptDate, CashSales.ReceptBy, CashSales.Code, CashSales.ProdName, CashSales.Rate, CashSales.Qty, CashSales.Amount, CashSales.PrdAmt, CashSales.Dis, CashSales.NetAmnt, CashSales.Log_User, CashSales.Log_Date, CashSales.DFlag into CashSales1"
                strSQL = strSQL & " in '" & DataBasePath & "' From CashSales where CashSales.ReceptDate between #" & dtpFrom.Value & "# and #" & dtpTo.Value & "# and Cashsales.Branch='" & cmbBranch.Text & "'"
                dc.CommandText = strSQL
                dc.ExecuteNonQuery()
                '____________________________________________________________________________________________________________________

                'strSQL = ""
                'strSQL = "SELECT ServiceDetails.JobCode, ServiceDetails.ProductCode, ServiceDetails.Qty, ServiceDetails.UnitPrice, ServiceDetails.Remarks into ServiceDetails1"
                'strSQL = strSQL & " in '" & DataBasePath & "' From Servicedetails inner Join Claiminfo on  Servicedetails.jobCode=Claiminfo.JobCode where Claiminfo.ReceptDate between #" & dtpFrom.Value & "# and #" & dtpTo.Value & "# and Claiminfo.Branch='" & cmbBranch.Text & "'"
                'dc.CommandText = strSQL
                'dc.ExecuteNonQuery()

                '____________________________________________________________________________________________________________________

                strSQL = ""
                strSQL = "SELECT ServiceDetails.JobCode, ServiceDetails.Description into ServiceDetails1"
                strSQL = strSQL & " in '" & DataBasePath & "' From ServiceDetails inner Join Claiminfo on  ServiceDetails.jobCode=Claiminfo.JobCode where Claiminfo.ReceptDate between #" & dtpFrom.Value & "# and #" & dtpTo.Value & "# and Claiminfo.Branch='" & cmbBranch.Text & "'"
                dc.CommandText = strSQL
                dc.ExecuteNonQuery()

                '____________________________________________________________________________________________________________________

                strSQL = ""
                strSQL = "SELECT ServiceDetailsDetails.JobCode, ServiceDetailsDetails.ProductCode, ServiceDetailsDetails.Qty, ServiceDetailsDetails.UnitPrice, ServiceDetailsDetails.Remarks into ServiceDetailsDetails1"
                strSQL = strSQL & " in '" & DataBasePath & "' From ServiceDetailsDetails inner Join Claiminfo on  ServiceDetailsDetails.jobCode=Claiminfo.JobCode where Claiminfo.ReceptDate between #" & dtpFrom.Value & "# and #" & dtpTo.Value & "# and Claiminfo.Branch='" & cmbBranch.Text & "'"
                dc.CommandText = strSQL
                dc.ExecuteNonQuery()

                '____________________________________________________________________________________________________________________

                'strSQL = ""
                'strSQL = "SELECT LogUser.UserName, LogUser.LogIn, LogUser.LogOut  into LogUser1"
                'strSQL = strSQL & " in '" & Opentxt & "' From LogUser"
                'cn.Execute strSQL

                '____________________________________________________________________________________________________________________

                strSQL = ""
                strSQL = "SELECT NRDetails.JobCode, NRDetails.NRCode into NRDetails1"
                strSQL = strSQL & " in '" & DataBasePath & "' From NRDetails inner Join Claiminfo on  NRDetails.jobCode=Claiminfo.JobCode where Claiminfo.ReceptDate between #" & dtpFrom.Value & "# and #" & dtpTo.Value & "# and Claiminfo.Branch='" & cmbBranch.Text & "'"
                dc.CommandText = strSQL
                dc.ExecuteNonQuery()

                '____________________________________________________________________________________________________________________


                'strSQL = ""
                'strSQL = "SELECT NROthers.JobCode, NROthers.NRCode into NROthers1"
                'strSQL = strSQL & " in '" & DataBasePath & "' From NROthers inner Join Claiminfo on  NROthers.jobCode=Claiminfo.JobCode where Claiminfo.ReceptDate between #" & dtpFrom.Value & "# and #" & dtpTo.Value & "# and Claiminfo.Branch='" & cmbBranch.Text & "'"
                'dc.CommandText = strSQL
                'dc.ExecuteNonQuery()

                '____________________________________________________________________________________________________________________


                strSQL = ""
                strSQL = "SELECT Pending.JobCode, Pending.PenCode Into Pending1"
                strSQL = strSQL & " in '" & DataBasePath & "' FROM Pending inner Join Claiminfo on  Pending.jobCode=Claiminfo.JobCode where Claiminfo.ReceptDate between #" & dtpFrom.Value & "# and #" & dtpTo.Value & "# and Claiminfo.Branch='" & cmbBranch.Text & "'"
                dc.CommandText = strSQL
                dc.ExecuteNonQuery()

                '____________________________________________________________________________________________________________________


                'strSQL = ""
                'strSQL = "SELECT PendingOther.JobCode, PendingOther.PenCode Into PendingOther1"
                'strSQL = strSQL & " in '" & DataBasePath & "' FROM PendingOther inner Join Claiminfo on  PendingOther.jobCode=Claiminfo.JobCode where Claiminfo.ReceptDate between #" & dtpFrom.Value & "# and #" & dtpTo.Value & "# and Claiminfo.Branch='" & cmbBranch.Text & "'"
                'dc.CommandText = strSQL
                'dc.ExecuteNonQuery()

                '____________________________________________________________________________________________________________________


                strSQL = ""
                strSQL = "SELECT Replace.JobCode, Replace.Brand, Replace.Model, Replace.ESN, Replace.ESNb, Replace.SLNo, Replace.Other, Replace.RDate, Replace.ReplaceBy into Replace1"
                strSQL = strSQL & " in '" & DataBasePath & "' From Replace inner Join Claiminfo on  Replace.jobCode=Claiminfo.JobCode where Claiminfo.ReceptDate between #" & dtpFrom.Value & "# and #" & dtpTo.Value & "# and Claiminfo.Branch='" & cmbBranch.Text & "'"
                dc.CommandText = strSQL
                dc.ExecuteNonQuery()

                '____________________________________________________________________________________________________________________

                strSQL = ""
                strSQL = "SELECT ServiceItem.JobCode, ServiceItem.Item into ServiceItem1"
                strSQL = strSQL & " in '" & DataBasePath & "' From ServiceItem inner Join Claiminfo on  ServiceItem.jobCode=Claiminfo.JobCode where Claiminfo.ReceptDate between #" & dtpFrom.Value & "# and #" & dtpTo.Value & "# and Claiminfo.Branch='" & cmbBranch.Text & "'"
                dc.CommandText = strSQL
                dc.ExecuteNonQuery()

                '____________________________________________________________________________________________________________________

                strSQL = ""
                strSQL = "SELECT tbGrade.JobCode, tbGrade.cGrade, tbGrade.cRemarks into tbGrade1"
                strSQL = strSQL & " in '" & DataBasePath & "' From tbGrade inner Join Claiminfo on  tbGrade.jobCode=Claiminfo.JobCode where Claiminfo.ReceptDate between #" & dtpFrom.Value & "# and #" & dtpTo.Value & "# and Claiminfo.Branch='" & cmbBranch.Text & "'"
                dc.CommandText = strSQL
                dc.ExecuteNonQuery()

                '____________________________________________________________________________________________________________________


                'strSQL = ""
                'strSQL = "SELECT CancelJob.JobCode, CancelJob.CancelDesc Into CancelJob1"
                'strSQL = strSQL & " in '" & DataBasePath & "' From CancelJob inner Join Claiminfo on  CancelJob.jobCode=Claiminfo.JobCode where Claiminfo.ReceptDate between #" & dtpFrom.Value & "# and #" & dtpTo.Value & "# and Claiminfo.Branch='" & cmbBranch.Text & "'"
                'dc.CommandText = strSQL
                'dc.ExecuteNonQuery()

                '____________________________________________________________________________________________________________________


                strSQL = ""
                strSQL = "SELECT TransferJob.JobCode, TransferJob.Remarks, TransferJob.TransferFrom, TransferJob.TransferTo, TransferJob.TrDate, TransferJob.TrByCode, TransferJob.TrByName into TransferJob1"
                strSQL = strSQL & " in '" & DataBasePath & "' From TransferJob inner Join Claiminfo on  TransferJob.jobCode=Claiminfo.JobCode where Claiminfo.ReceptDate between #" & dtpFrom.Value & "# and #" & dtpTo.Value & "# and Claiminfo.Branch='" & cmbBranch.Text & "'"
                dc.CommandText = strSQL
                dc.ExecuteNonQuery()

                '____________________________________________________________________________________________________________________


                strSQL = ""
                strSQL = "SELECT EstimateRefused.JobCode, EstimateRefused.ServiceBy_ID, EstimateRefused.EstDate, EstimateRefused.EstText, EstimateRefused.RefuseAmnt, EstimateRefused.Branch into EstimateRefused1"
                strSQL = strSQL & " in '" & DataBasePath & "' From EstimateRefused inner Join Claiminfo on  EstimateRefused.jobCode=Claiminfo.JobCode where Claiminfo.ReceptDate between #" & dtpFrom.Value & "# and #" & dtpTo.Value & "# and Claiminfo.Branch='" & cmbBranch.Text & "'"
                dc.CommandText = strSQL
                dc.ExecuteNonQuery()
                '____________________________________________________________________________________________________________________
                strSQL = ""
                strSQL = "SELECT tbBill.BillNO, tbBill.JobNO into tbBill1"
                strSQL = strSQL & " in '" & DataBasePath & "' From tbBill inner Join Claiminfo on  tbBill.JobNO=Claiminfo.JobCode where Claiminfo.ReceptDate between #" & dtpFrom.Value & "# and #" & dtpTo.Value & "# and Claiminfo.Branch='" & cmbBranch.Text & "'"
                dc.CommandText = strSQL
                dc.ExecuteNonQuery()
                '____________________________________________________________________________________________________________________
                strSQL = ""
                strSQL = "SELECT tbBill_FFC.JobCode, tbBill_FFC.FaultCharge,tbBill_FFC.ServiceCharge into tbBill_FFC1"
                strSQL = strSQL & " in '" & DataBasePath & "' From tbBill_FFC inner Join Claiminfo on  tbBill_FFC.JobCode=Claiminfo.JobCode where Claiminfo.ReceptDate between #" & dtpFrom.Value & "# and #" & dtpTo.Value & "# and Claiminfo.Branch='" & cmbBranch.Text & "'"
                dc.CommandText = strSQL
                dc.ExecuteNonQuery()


                Threading.Thread.Sleep(3000)


                Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

                Using Dcon As OleDbConnection = New OleDbConnection(cs) ' D Means Destination

                    Dim Ddc As OleDbCommand = New OleDbCommand
                    Ddc.Connection = Dcon


                    Dcon.Open()
                    tmpUpdateTables()
                    JoinRelationshiptmptmp("Join")
                    If chkFullBranchName.Checked = True Then

                        Ddc.CommandText = "Update CLaiminfo1 set Claiminfo1.JobCode= Claiminfo1.JobCode & Claiminfo1.Branch where Claiminfo1.ReceptDate between #" & dtpFrom.Value & "# and #" & dtpTo.Value & "# and Claiminfo1.Branch='" & cmbBranch.Text & "'"
                        Ddc.ExecuteNonQuery()

                        Ddc.CommandText = "Update Cashsales1 set Cashsales1.MRNO= Cashsales1.MRNO & Cashsales1.Branch where Cashsales1.ReceptDate between #" & dtpFrom.Value & "# and #" & dtpTo.Value & "# and Cashsales1.Branch='" & cmbBranch.Text & "'"
                        Ddc.ExecuteNonQuery()
                    Else
                        Ddc.CommandText = "Update CLaiminfo1 set Claiminfo1.JobCode= Claiminfo1.JobCode & left(Claiminfo1.Branch,6) where Claiminfo1.ReceptDate between #" & dtpFrom.Value & "# and #" & dtpTo.Value & "# and Claiminfo1.Branch='" & cmbBranch.Text & "'"
                        Ddc.ExecuteNonQuery()
                        Ddc.CommandText = "Update Cashsales1 set Cashsales1.MRNO= Cashsales1.MRNO & left(Cashsales1.Branch,5) where Cashsales1.ReceptDate between #" & dtpFrom.Value & "# and #" & dtpTo.Value & "# and Cashsales1.Branch='" & cmbBranch.Text & "'"
                        Ddc.ExecuteNonQuery()
                    End If



                    'UpdateClaiminfoTable strCon
                    'UpdateCashsales1 strCon





                    JoinRelationshiptmptmp("Drop")

                    ' Insert All The Records from Temp Table

                    Dim strInsert As String
                    Dim strInsertTable As String

                    ListBox1.Items.Clear()
                    ListBox1.Items.Add(cmbBranch.Text & " Branch: Loading : ")
                    strInsertTable = "Claiminfo Load Completed"
                    strInsert = ""
                    strInsert = "Insert into Claiminfo(JobCode, Branch, CustName, CustAddress1, CustAddress2, Brand, ModelNo, MobileNo, ESN, SLNo, ReceptDate, AppDelDate, ServiceType, PDate, ReceptBy, IssueTo, IsssueDate, SDate, ServiceBy, DDate, DeliverBy, WCondition, cFlag, SvAmt, PrdAmt, OtherAmt, Dis, SRFlag, Remk, PhyCond, Log_User, Log_Date, MRNO, LastJobNO, cAdvance, cTransportCrg, ReturnedItems, ItemRemarks, FreeOfCost, AdvanceAmnt,VatAmnt) "
                    strInsert = strInsert & " Select ClaimInfo1.JobCode , ClaimInfo1.Branch, ClaimInfo1.CustName, ClaimInfo1.CustAddress1, ClaimInfo1.CustAddress2, ClaimInfo1.Brand, ClaimInfo1.ModelNo, ClaimInfo1.MobileNo, ClaimInfo1.ESN, ClaimInfo1.SLNo, ClaimInfo1.ReceptDate, ClaimInfo1.AppDelDate, ClaimInfo1.ServiceType, ClaimInfo1.PDate, ClaimInfo1.ReceptBy, ClaimInfo1.IssueTo, ClaimInfo1.IsssueDate, ClaimInfo1.SDate, ClaimInfo1.ServiceBy, ClaimInfo1.DDate, ClaimInfo1.DeliverBy, ClaimInfo1.WCondition, ClaimInfo1.cFlag, ClaimInfo1.SvAmt, ClaimInfo1.PrdAmt, ClaimInfo1.OtherAmt, ClaimInfo1.Dis, ClaimInfo1.SRFlag, ClaimInfo1.Remk, ClaimInfo1.PhyCond, ClaimInfo1.Log_User, ClaimInfo1.Log_Date, ClaimInfo1.MRNO, ClaimInfo1.LastJobNO, ClaimInfo1.cAdvance, ClaimInfo1.cTransportCrg, ClaimInfo1.ReturnedItems, ClaimInfo1.ItemRemarks, ClaimInfo1.FreeOfCost, ClaimInfo1.AdvanceAmnt, ClaimInfo1.VatAmnt From ClaimInfo1"

                    Ddc.CommandText = strInsert
                    Ddc.ExecuteNonQuery()


                    Ddc.CommandText = "Drop Table Claiminfo1"
                    Ddc.ExecuteNonQuery()
                    Application.DoEvents()
                    prgBar.Value = 100 / 17

                    ListBox1.Items.Add(strInsertTable)
                    'GoTo UPDATE
                    '____________________________________________________________________________________________________________________

                    ' InsertCategoryBrandModel   Not Completed will be continued later


                    '____________________________________________________________________________________________________________________

                    strInsertTable = "CustomerClaim Load Completed"
                    strInsert = ""
                    strInsert = "Insert into CustomerClaim(JobCode,Claimcode) Select CustomerClaim1.JobCode,CustomerClaim1.ClaimCode from CustomerCLaim1"
                    Ddc.CommandText = strInsert
                    Ddc.ExecuteNonQuery()
                    Ddc.CommandText = "Drop Table CustomerClaim1"
                    Ddc.ExecuteNonQuery()
                    Application.DoEvents()
                    prgBar.Value = 100 / 16

                    ListBox1.Items.Add(strInsertTable) '& vbTab & " Time : " & Format(EndTime - PreviousTime, "HH:MM:SS")


                    '____________________________________________________________________________________________________________________

                    'strInsertTable = "CustomerClaimOthers Load Completed"
                    'strInsert = ""
                    'strInsert = "Insert into CustomerClaimOthers(JobCode,Claimcode) Select CustomerClaimOthers1.JobCode,CustomerClaimOthers1.ClaimCode from CustomerClaimOthers1"
                    'Ddc.CommandText = strInsert
                    'Ddc.ExecuteNonQuery()

                    'Ddc.CommandText = "Drop Table CustomerClaimOthers1"
                    'Ddc.ExecuteNonQuery()

                    'prgBar.Value = 100 / 15
                    'ListBox1.Items.Add(strInsertTable) '& vbTab & " Time : " & Format(EndTime - PreviousTime, "HH:MM:SS")

                    '____________________________________________________________________________________________________________________
                    'strInsert = ""
                    'strInsert = "Insert into CustomerClaimOthers(JobCode,Claimcode) Select CustomerClaim1.JobCode,CustomerClaimOthers.ClaimCode from CustomerClaimOthers1"
                    'cnDestination.Execute strInsert
                    'cnDestination.Execute "Drop Table CustomerClaimOthers1"
                    ''____________________________________________________________________________________________________________________

                    strInsertTable = "Cashsales Load Completed"
                    strInsert = ""
                    strInsert = "Insert into Cashsales(MRNO, JobCode, Branch, CustName, CustAddress1, CustAddress2, Brand, ModelNo, ESN, SLNo, ReceptDate, ReceptBy, Code, ProdName, Rate, Qty, Amount, PrdAmt, Dis, NetAmnt, Log_User, Log_Date, DFlag ) Select CashSales1.MRNO, CashSales1.JobCode, CashSales1.Branch, CashSales1.CustName, CashSales1.CustAddress1, CashSales1.CustAddress2, CashSales1.Brand, CashSales1.ModelNo, CashSales1.ESN, CashSales1.SLNo, CashSales1.ReceptDate, CashSales1.ReceptBy, CashSales1.Code, CashSales1.ProdName, CashSales1.Rate, CashSales1.Qty, CashSales1.Amount, CashSales1.PrdAmt, CashSales1.Dis, CashSales1.NetAmnt, CashSales1.Log_User, CashSales1.Log_Date, CashSales1.DFlag from Cashsales1"
                    Ddc.CommandText = strInsert
                    Ddc.ExecuteNonQuery()

                    Ddc.CommandText = "Drop Table Cashsales1"
                    Ddc.ExecuteNonQuery()
                    Application.DoEvents()
                    prgBar.Value = 100 / 14

                    ListBox1.Items.Add(strInsertTable) '& vbTab & " Time : " & Format(EndTime - PreviousTime, "HH:MM:SS")

                    '____________________________________________________________________________________________________________________

                    '____________________________________________________________________________________________________________________

                    strInsertTable = "Servicedetails Load Completed"
                    strInsert = ""
                    strInsert = "Insert into Servicedetails(JobCode, Description) Select ServiceDetails1.JobCode, ServiceDetails1.Description from Servicedetails1"
                    Ddc.CommandText = strInsert
                    Ddc.ExecuteNonQuery()

                    Ddc.CommandText = "Drop Table Servicedetails1"
                    Ddc.ExecuteNonQuery()
                    Application.DoEvents()
                    prgBar.Value = 100 / 13

                    ListBox1.Items.Add(strInsertTable) ' & vbTab & " Time : " & Format(EndTime - PreviousTime, "HH:MM:SS")


                    '____________________________________________________________________________________________________________________

                    strInsertTable = "ServiceDetailsDetails Load Completed"
                    strInsert = ""
                    strInsert = "Insert into ServiceDetailsDetails(JobCode, ProductCode, Qty, UnitPrice, Remarks ) Select ServiceDetailsDetails1.JobCode, ServiceDetailsDetails1.ProductCode, ServiceDetailsDetails1.Qty, ServiceDetailsDetails1.UnitPrice, ServiceDetailsDetails1.Remarks from ServiceDetailsDetails1"
                    Ddc.CommandText = strInsert
                    Ddc.ExecuteNonQuery()

                    Ddc.CommandText = "Drop Table ServiceDetailsDetails1"
                    Ddc.ExecuteNonQuery()
                    Application.DoEvents()
                    prgBar.Value = 100 / 13

                    ListBox1.Items.Add(strInsertTable) ' & vbTab & " Time : " & Format(EndTime - PreviousTime, "HH:MM:SS")

                    '____________________________________________________________________________________________________________________
                    '
                    'strInsertTable = "Loguser Load Cmpleted"
                    'strInsert = ""
                    'strInsert = "Insert into Loguser(UserName, LogIn, LogOut) SELECT LogUser1.UserName, LogUser1.LogIn, LogUser1.LogOut from Loguser1"
                    'cnDestination.Execute strInsert
                    'cnDestination.Execute "Drop Table Loguser1"
                    'List1.AddItem strInsertTable
                    'DoEvents
                    '____________________________________________________________________________________________________________________

                    strInsertTable = "NRDetails Load Completed"
                    strInsert = ""
                    strInsert = "Insert into NRDetails(JobCode, NRCode) Select NRDetails1.JobCode, NRDetails1.NRCode from NRDetails1"
                    Ddc.CommandText = strInsert
                    Ddc.ExecuteNonQuery()

                    Ddc.CommandText = "Drop Table NRDetails1"
                    Ddc.ExecuteNonQuery()
                    Application.DoEvents()
                    prgBar.Value = 100 / 12

                    ListBox1.Items.Add(strInsertTable) ' & vbTab & " Time : " & Format(EndTime - PreviousTime, "HH:MM:SS")

                    '____________________________________________________________________________________________________________________

                    'strInsertTable = "NROthers Load Completed"
                    'strInsert = ""
                    'strInsert = "Insert into NROthers(JobCode, NRCode) Select NROthers1.JobCode, NROthers1.NRCode from NROthers1"
                    'Ddc.CommandText = strInsert
                    'Ddc.ExecuteNonQuery()

                    'Ddc.CommandText = "Drop Table NROthers1"
                    'Ddc.ExecuteNonQuery()

                    'prgBar.Value = 100 / 11

                    'ListBox1.Items.Add(strInsertTable) ' & vbTab & " Time : " & Format(EndTime - PreviousTime, "HH:MM:SS")

                    '____________________________________________________________________________________________________________________

                    strInsertTable = "Pending Load Completed"
                    strInsert = ""
                    strInsert = "Insert into Pending(JobCode, Pencode) Select Pending1.JobCode, Pending1.Pencode from Pending1"
                    Ddc.CommandText = strInsert
                    Ddc.ExecuteNonQuery()

                    Ddc.CommandText = "Drop Table Pending1"
                    Ddc.ExecuteNonQuery()
                    Application.DoEvents()
                    prgBar.Value = 100 / 10

                    ListBox1.Items.Add(strInsertTable) ' & vbTab & " Time : " & Format(EndTime - PreviousTime, "HH:MM:SS")


                    '____________________________________________________________________________________________________________________

                    'strInsertTable = "PendingOther Load Completed"
                    'strInsert = ""
                    'strInsert = "Insert into PendingOther(JobCode, Pencode) Select PendingOther1.JobCode, PendingOther1.Pencode from PendingOther1"
                    'Ddc.CommandText = strInsert
                    'Ddc.ExecuteNonQuery()

                    'Ddc.CommandText = "Drop Table PendingOther1"
                    'Ddc.ExecuteNonQuery()

                    'prgBar.Value = 100 / 9

                    'ListBox1.Items.Add(strInsertTable) ' & vbTab & " Time : " & Format(EndTime - PreviousTime, "HH:MM:SS")

                    '____________________________________________________________________________________________________________________

                    strInsertTable = "Replace Load Completed"
                    strInsert = ""
                    strInsert = "Insert into Replace(JobCode, Brand, Model, ESN, ESNb, SLNo, Other, RDate, ReplaceBy) Select Replace1.JobCode, Replace1.Brand, Replace1.Model, Replace1.ESN, Replace1.ESNb, Replace1.SLNo, Replace1.Other, Replace1.RDate, Replace1.ReplaceBy from Replace1"
                    Ddc.CommandText = strInsert
                    Ddc.ExecuteNonQuery()

                    Ddc.CommandText = "Drop Table Replace1"
                    Ddc.ExecuteNonQuery()

                    Application.DoEvents()
                    ListBox1.Items.Add(strInsertTable) ' & vbTab & " Time : " & Format(EndTime - PreviousTime, "HH:MM:SS")
                    prgBar.Value = 100 / 8

                    '____________________________________________________________________________________________________________________

                    strInsertTable = "ServiceItem Load Completed"
                    strInsert = ""
                    strInsert = "Insert into ServiceItem(JobCode, Item) Select ServiceItem1.JobCode, ServiceItem1.Item From ServiceItem1"
                    Ddc.CommandText = strInsert
                    Ddc.ExecuteNonQuery()

                    Ddc.CommandText = "Drop Table ServiceItem1"
                    Ddc.ExecuteNonQuery()

                    Application.DoEvents()
                    ListBox1.Items.Add(strInsertTable) ' & vbTab & " Time : " & Format(EndTime - PreviousTime, "HH:MM:SS")
                    prgBar.Value = 100 / 7

                    '____________________________________________________________________________________________________________________

                    strInsertTable = "tbGrade Load Completed"
                    strInsert = ""
                    strInsert = "Insert into tbGrade(JobCode, cGrade, cRemarks) Select tbGrade1.JobCode, tbGrade1.cGrade, tbGrade1.cRemarks From tbGrade1"
                    Ddc.CommandText = strInsert
                    Ddc.ExecuteNonQuery()

                    Ddc.CommandText = "Drop Table tbGrade1"
                    Ddc.ExecuteNonQuery()
                    Application.DoEvents()
                    prgBar.Value = 100 / 6

                    ListBox1.Items.Add(strInsertTable) ' & vbTab & " Time : " & Format(EndTime - PreviousTime, "HH:MM:SS")


                    ''____________________________________________________________________________________________________________________

                    'strInsertTable = "CancelJob Load Completed"
                    'strInsert = ""
                    'strInsert = "Insert into CancelJob(JobCode, CancelDesc) Select CancelJob1.JobCode, CancelJob1.CancelDesc From CancelJob1"
                    'Ddc.CommandText = strInsert
                    'Ddc.ExecuteNonQuery()

                    'Ddc.CommandText = "Drop Table CancelJob1"
                    'Ddc.ExecuteNonQuery()

                    'prgBar.Value = 100 / 5

                    'ListBox1.Items.Add(strInsertTable) ' & vbTab & " Time : " & Format(EndTime - PreviousTime, "HH:MM:SS")

                    '____________________________________________________________________________________________________________________

                    strInsertTable = "TransferJob Load Completed"
                    strInsert = ""
                    strInsert = "Insert into TransferJob(JobCode, Remarks, TransferFrom, TransferTo, TrDate, TrByCode, TrByName) Select TransferJob1.JobCode, TransferJob1.Remarks, TransferJob1.TransferFrom, TransferJob1.TransferTo, TransferJob1.TrDate, TransferJob1.TrByCode, TransferJob1.TrByName From TransferJob1"
                    Ddc.CommandText = strInsert
                    Ddc.ExecuteNonQuery()

                    Ddc.CommandText = "Drop Table TransferJob1"
                    Ddc.ExecuteNonQuery()
                    Application.DoEvents()
                    prgBar.Value = 100 / 4

                    ListBox1.Items.Add(strInsertTable) ' & vbTab & " Time : " & Format(EndTime - PreviousTime, "HH:MM:SS")

                    '____________________________________________________________________________________________________________________

                    strInsertTable = "EstimateRefused Load Completed"
                    strInsert = ""
                    strInsert = "Insert into EstimateRefused(JobCode, ServiceBy_ID, EstDate, EstText, RefuseAmnt, Branch) Select EstimateRefused1.JobCode, EstimateRefused1.ServiceBy_ID, EstimateRefused1.EstDate, EstimateRefused1.EstText, EstimateRefused1.RefuseAmnt, EstimateRefused1.Branch From EstimateRefused1"
                    Ddc.CommandText = strInsert
                    Ddc.ExecuteNonQuery()

                    Ddc.CommandText = "Drop Table EstimateRefused1"
                    Ddc.ExecuteNonQuery()
                    Application.DoEvents()
                    prgBar.Value = 100 / 3

                    ListBox1.Items.Add(strInsertTable) ' & vbTab & " Time : " & Format(EndTime - PreviousTime, "HH:MM:SS")

                    '____________________________________________________________________________________________________________________

                    strInsertTable = "tbBill Load Completed"
                    strInsert = ""
                    strInsert = "Insert into tbBill(BillNO, JobNO) Select tbBill1.BillNO, tbBill1.JobNO From tbBill1"
                    Ddc.CommandText = strInsert
                    Ddc.ExecuteNonQuery()

                    Ddc.CommandText = "Drop Table tbBill1"
                    Ddc.ExecuteNonQuery()
                    Application.DoEvents()
                    prgBar.Value = 100 / 2

                    ListBox1.Items.Add(strInsertTable) ' & vbTab & " Time : " & Format(EndTime - PreviousTime, "HH:MM:SS")

                    '____________________________________________________________________________________________________________________

                    strInsertTable = "tbBill_FFC Load Completed"
                    strInsert = ""
                    strInsert = "Insert into tbBill_FFC(JobCode, FaultCharge,ServiceCharge) Select tbBill_FFC1.JobCode, tbBill_FFC1.FaultCharge,tbBill_FFC1.ServiceCharge From tbBill_FFC1"
                    Ddc.CommandText = strInsert
                    Ddc.ExecuteNonQuery()
                    Ddc.CommandText = "Drop Table tbBill_FFC1"
                    Ddc.ExecuteNonQuery()
                    Application.DoEvents()
                    prgBar.Value = 100 / 1

                    ListBox1.Items.Add(strInsertTable) ' & vbTab & " Time : " & Format(EndTime - PreviousTime, "HH:MM:SS")
                    '____________________________________________________________________________________________________________________



                End Using


            End Using

            lblBottomStatus.Text = "Data Load Successfully"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub tmpUpdateTables()

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dc As OleDbCommand = New OleDbCommand


            dc.Connection = con
            con.Open()

            dc.CommandText = "alter table Cashsales1 alter column Mrno text(50)"
            dc.ExecuteNonQuery()


            dc.CommandText = "alter table claiminfo1 alter column Jobcode text(50)"
            dc.ExecuteNonQuery()
            dc.CommandText = "alter table advanceinfo1 alter column Jobcode text(50)"
            dc.ExecuteNonQuery()
            dc.CommandText = "alter table CustomerClaim1 alter column Jobcode text(50)"
            dc.ExecuteNonQuery()
            'dc.CommandText = "Alter Table CustomerClaimOthers1 alter column Jobcode text(50)"
            'dc.ExecuteNonQuery()
            dc.CommandText = "Alter Table EstimateRefused1 alter column Jobcode text(50)"
            dc.ExecuteNonQuery()
            dc.CommandText = "Alter Table NRDetails1 alter column Jobcode text(50)"
            dc.ExecuteNonQuery()
            'dc.CommandText = "Alter Table NROThers1 alter column Jobcode text(50)"
            'dc.ExecuteNonQuery()
            dc.CommandText = "Alter Table Pending1 alter column Jobcode text(50)"
            dc.ExecuteNonQuery()
            'dc.CommandText = "Alter Table PendingOther1 alter column Jobcode text(50)"
            'dc.ExecuteNonQuery()
            dc.CommandText = "Alter Table Replace1 alter column Jobcode text(50)"
            dc.ExecuteNonQuery()
            dc.CommandText = "Alter Table ServiceDetails1 alter column Jobcode text(50)"
            dc.ExecuteNonQuery()
            dc.CommandText = "Alter Table ServiceDetailsDetails1 alter column Jobcode text(50)"
            dc.ExecuteNonQuery()
            dc.CommandText = "Alter Table ServiceItem1 alter column Jobcode text(50)"
            dc.ExecuteNonQuery()
            dc.CommandText = "Alter Table tbGrade1 alter column Jobcode text(50)"
            dc.ExecuteNonQuery()
            'dc.CommandText = "Alter Table CancelJob1 alter column Jobcode text(50)"
            'dc.ExecuteNonQuery()
            dc.CommandText = "Alter Table TransferJob1 alter column Jobcode text(50)"
            dc.ExecuteNonQuery()
            dc.CommandText = "Alter Table tbBill1 alter column Jobno text(50)"
            dc.ExecuteNonQuery()
            dc.CommandText = "Alter Table tbBill_FFC1 alter column JobCode text(50)"
            dc.ExecuteNonQuery()

        End Using
    End Sub




    Private Sub JoinRelationshiptmptmp(ByVal strJoin As String)

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim dc As OleDbCommand = New OleDbCommand


        Try

            Using con As OleDbConnection = New OleDbConnection(cs)
                con.Open()


                dc.Connection = con




                'blnJoinFlag = False
                If strJoin.ToLower = "Drop".ToLower Then


                    RemoveConstraint("Alter Table advanceinfo1 Drop constraint FK_advanceinfoJobCode1")

                    RemoveConstraint("Alter Table CustomerClaim1 Drop constraint FK_CustomerClaimJobCode1")

                    'dc.CommandText = "Alter Table CustomerClaimOthers1 Drop constraint FK_CustomerClaimOthersJobCode1"
                    'dc.ExecuteNonQuery()
                    RemoveConstraint("Alter Table EstimateRefused1 Drop constraint FK_EstimateRefusedOthersJobCode1")

                    RemoveConstraint("Alter Table NRDetails1 Drop constraint FK_NRDetailsJobCode1")

                    'dc.CommandText = "Alter Table NROThers1 Drop constraint FK_NROThersJobCode1"
                    'dc.ExecuteNonQuery()
                    RemoveConstraint("Alter Table Pending1 Drop constraint FK_PendingJobCode1")

                    'dc.CommandText = "Alter Table PendingOther1 Drop constraint FK_PendingOtherJobCode1"
                    'dc.ExecuteNonQuery()
                    RemoveConstraint("Alter Table Replace1 Drop constraint FK_ReplaceJobCode1")

                    RemoveConstraint("Alter Table ServiceDetails1 Drop constraint FK_ServiceDetailsJobCode1")

                    RemoveConstraint("Alter Table ServiceDetailsDetails1 Drop constraint FK_ServiceDetailsDetails1JobCode1")

                    RemoveConstraint("Alter Table ServiceItem1 Drop constraint FK_ServiceItemJobCode1")

                    RemoveConstraint("Alter Table tbGrade1 Drop constraint FK_tbGradeJobCode1")

                    RemoveConstraint("Alter Table CancelJob1 Drop constraint FK_CancelJobJobCode1")

                    RemoveConstraint("Alter Table TransferJob1 Drop constraint FK_TransferJobJobCode1")

                    RemoveConstraint("Alter Table tbBill1 Drop constraint FK_tbBillJobJobCode1")

                    RemoveConstraint("Alter Table tbBill_FFC1 Drop constraint FK_tbBill_FFCJobJobCode1")
















                    'dc.CommandText = "Alter Table advanceinfo1 Drop constraint FK_advanceinfoJobCode1"
                    'dc.ExecuteNonQuery()
                    'dc.CommandText = "Alter Table CustomerClaim1 Drop constraint FK_CustomerClaimJobCode1"
                    'dc.ExecuteNonQuery()
                    ''dc.CommandText = "Alter Table CustomerClaimOthers1 Drop constraint FK_CustomerClaimOthersJobCode1"
                    ''dc.ExecuteNonQuery()
                    'dc.CommandText = "Alter Table EstimateRefused1 Drop constraint FK_EstimateRefusedOthersJobCode1"
                    'dc.ExecuteNonQuery()
                    'dc.CommandText = "Alter Table NRDetails1 Drop constraint FK_NRDetailsJobCode1"
                    'dc.ExecuteNonQuery()
                    ''dc.CommandText = "Alter Table NROThers1 Drop constraint FK_NROThersJobCode1"
                    ''dc.ExecuteNonQuery()
                    'dc.CommandText = "Alter Table Pending1 Drop constraint FK_PendingJobCode1"
                    'dc.ExecuteNonQuery()
                    ''dc.CommandText = "Alter Table PendingOther1 Drop constraint FK_PendingOtherJobCode1"
                    ''dc.ExecuteNonQuery()
                    'dc.CommandText = "Alter Table Replace1 Drop constraint FK_ReplaceJobCode1"
                    'dc.ExecuteNonQuery()
                    'dc.CommandText = "Alter Table ServiceDetails1 Drop constraint FK_ServiceDetailsJobCode1"
                    'dc.ExecuteNonQuery()
                    'dc.CommandText = "Alter Table ServiceDetailsDetails1 Drop constraint FK_ServiceDetailsDetails1JobCode1"
                    'dc.ExecuteNonQuery()
                    'dc.CommandText = "Alter Table ServiceItem1 Drop constraint FK_ServiceItemJobCode1"
                    'dc.ExecuteNonQuery()
                    'dc.CommandText = "Alter Table tbGrade1 Drop constraint FK_tbGradeJobCode1"
                    'dc.ExecuteNonQuery()
                    'dc.CommandText = "Alter Table CancelJob1 Drop constraint FK_CancelJobJobCode1"
                    'dc.ExecuteNonQuery()
                    'dc.CommandText = "Alter Table TransferJob1 Drop constraint FK_TransferJobJobCode1"
                    'dc.ExecuteNonQuery()
                    'dc.CommandText = "Alter Table tbBill1 Drop constraint FK_tbBillJobJobCode1"
                    'dc.ExecuteNonQuery()
                    'dc.CommandText = "Alter Table tbBill_FFC1 Drop constraint FK_tbBill_FFCJobJobCode1"
                    'dc.ExecuteNonQuery()






                ElseIf strJoin.ToLower = "Join".ToLower Then


                    CreateConstraint("alter table Claiminfo1 add constraint PK_CLaiminfo1 Primary key(JobCode)")

                    CreateConstraint("Alter Table advanceinfo1 add constraint FK_advanceinfoJobcode1 foreign key(JobCode) references Claiminfo1(JobCode) on Delete Cascade on update cascade")

                    CreateConstraint("Alter Table CustomerClaim1 add constraint FK_CustomerClaimJobCode1 foreign key(JobCode) references Claiminfo1(JobCode) on Delete Cascade on update cascade")

                    'dc.CommandText = "Alter Table CustomerClaimOthers1 add constraint FK_CustomerClaimOthersJobCode1 foreign key(JobCode) references Claiminfo1(JobCode) on Delete Cascade on update cascade"
                    'dc.ExecuteNonQuery()
                    CreateConstraint("Alter Table EstimateRefused1 add constraint FK_EstimateRefusedOthersJobCode1 foreign key(JobCode) references Claiminfo1(JobCode) on Delete Cascade on update cascade")

                    CreateConstraint("Alter Table NRDetails1 add constraint FK_NRDetailsJobCode1 foreign key(JobCode) references Claiminfo1(JobCode) on Delete Cascade on update cascade")

                    'dc.CommandText = "Alter Table NROThers1 add constraint FK_NROThersJobCode1 foreign key(JobCode) references Claiminfo1(JobCode) on Delete Cascade on update cascade"
                    'dc.ExecuteNonQuery()
                    CreateConstraint("Alter Table Pending1 add constraint FK_PendingJobCode1 foreign key(JobCode) references Claiminfo1(JobCode) on Delete Cascade on update cascade")

                    'dc.CommandText = "Alter Table PendingOther1 add constraint FK_PendingOtherJobCode1 foreign key(JobCode) references Claiminfo1(JobCode) on Delete Cascade on update cascade"
                    'dc.ExecuteNonQuery()
                    CreateConstraint("Alter Table Replace1 add constraint FK_ReplaceJobCode1 foreign key(JobCode) references Claiminfo1(JobCode) on Delete Cascade on update cascade")

                    CreateConstraint("Alter Table ServiceDetails1 add constraint FK_ServiceDetailsJobCode1 foreign key(JobCode) references Claiminfo1(JobCode) on Delete Cascade on update cascade")

                    CreateConstraint("Alter Table ServiceDetailsDetails1 add constraint FK_ServiceDetailsDetails1JobCode1 foreign key(JobCode) references Claiminfo1(JobCode) on Delete Cascade on update cascade")




                    CreateConstraint("Alter Table ServiceItem1 add constraint FK_ServiceItemJobCode1 foreign key(JobCode) references Claiminfo1(JobCode) on Delete Cascade on update cascade")

                    CreateConstraint("Alter Table tbGrade1 add constraint FK_tbGradeJobCode1 foreign key(JobCode) references Claiminfo1(JobCode) on Delete Cascade on update cascade")

                    CreateConstraint("Alter Table CancelJob1 add constraint FK_CancelJobJobCode1 foreign key(JobCode) references Claiminfo1(JobCode) on Delete Cascade on update cascade")

                    CreateConstraint("Alter Table TransferJob1 add constraint FK_TransferJobJobCode1 foreign key(JobCode) references Claiminfo1(JobCode) on Delete Cascade on update cascade")

                    CreateConstraint("Alter Table tbBill1 add constraint FK_tbBillJobJobCode1 foreign key(JobNo) references Claiminfo1(JobCode) on Delete Cascade on update cascade")

                    CreateConstraint("Alter Table tbBill_FFC1 add constraint FK_tbBill_FFCJobJobCode1 foreign key(JobCode) references Claiminfo1(JobCode) on Delete Cascade on update cascade")












                    'dc.CommandText = "alter table Claiminfo1 add constraint PK_CLaiminfo1 Primary key(JobCode)"
                    'dc.ExecuteNonQuery()
                    'dc.CommandText = "Alter Table advanceinfo1 add constraint FK_advanceinfoJobcode1 foreign key(JobCode) references Claiminfo1(JobCode) on Delete Cascade on update cascade"
                    'dc.ExecuteNonQuery()
                    'dc.CommandText = "Alter Table CustomerClaim1 add constraint FK_CustomerClaimJobCode1 foreign key(JobCode) references Claiminfo1(JobCode) on Delete Cascade on update cascade"
                    'dc.ExecuteNonQuery()
                    ''dc.CommandText = "Alter Table CustomerClaimOthers1 add constraint FK_CustomerClaimOthersJobCode1 foreign key(JobCode) references Claiminfo1(JobCode) on Delete Cascade on update cascade"
                    ''dc.ExecuteNonQuery()
                    'dc.CommandText = "Alter Table EstimateRefused1 add constraint FK_EstimateRefusedOthersJobCode1 foreign key(JobCode) references Claiminfo1(JobCode) on Delete Cascade on update cascade"
                    'dc.ExecuteNonQuery()
                    'dc.CommandText = "Alter Table NRDetails1 add constraint FK_NRDetailsJobCode1 foreign key(JobCode) references Claiminfo1(JobCode) on Delete Cascade on update cascade"
                    'dc.ExecuteNonQuery()
                    ''dc.CommandText = "Alter Table NROThers1 add constraint FK_NROThersJobCode1 foreign key(JobCode) references Claiminfo1(JobCode) on Delete Cascade on update cascade"
                    ''dc.ExecuteNonQuery()
                    'dc.CommandText = "Alter Table Pending1 add constraint FK_PendingJobCode1 foreign key(JobCode) references Claiminfo1(JobCode) on Delete Cascade on update cascade"
                    'dc.ExecuteNonQuery()
                    ''dc.CommandText = "Alter Table PendingOther1 add constraint FK_PendingOtherJobCode1 foreign key(JobCode) references Claiminfo1(JobCode) on Delete Cascade on update cascade"
                    ''dc.ExecuteNonQuery()
                    'dc.CommandText = "Alter Table Replace1 add constraint FK_ReplaceJobCode1 foreign key(JobCode) references Claiminfo1(JobCode) on Delete Cascade on update cascade"
                    'dc.ExecuteNonQuery()
                    'dc.CommandText = "Alter Table ServiceDetails1 add constraint FK_ServiceDetailsJobCode1 foreign key(JobCode) references Claiminfo1(JobCode) on Delete Cascade on update cascade"
                    'dc.ExecuteNonQuery()
                    'dc.CommandText = "Alter Table ServiceDetailsDetails1 add constraint FK_ServiceDetailsDetails1JobCode1"
                    'dc.ExecuteNonQuery()

                    'dc.CommandText = "Alter Table ServiceItem1 add constraint FK_ServiceItemJobCode1 foreign key(JobCode) references Claiminfo1(JobCode) on Delete Cascade on update cascade"
                    'dc.ExecuteNonQuery()
                    'dc.CommandText = "Alter Table tbGrade1 add constraint FK_tbGradeJobCode1 foreign key(JobCode) references Claiminfo1(JobCode) on Delete Cascade on update cascade"
                    'dc.ExecuteNonQuery()
                    'dc.CommandText = "Alter Table CancelJob1 add constraint FK_CancelJobJobCode1 foreign key(JobCode) references Claiminfo1(JobCode) on Delete Cascade on update cascade"
                    'dc.ExecuteNonQuery()
                    'dc.CommandText = "Alter Table TransferJob1 add constraint FK_TransferJobJobCode1 foreign key(JobCode) references Claiminfo1(JobCode) on Delete Cascade on update cascade"
                    'dc.ExecuteNonQuery()
                    'dc.CommandText = "Alter Table tbBill1 add constraint FK_tbBillJobJobCode1 foreign key(JobNo) references Claiminfo1(JobCode) on Delete Cascade on update cascade"
                    'dc.ExecuteNonQuery()
                    'dc.CommandText = "Alter Table tbBill_FFC1 add constraint FK_tbBill_FFCJobJobCode1 foreign key(JobCode) references Claiminfo1(JobCode) on Delete Cascade on update cascade"
                    'dc.ExecuteNonQuery()










                End If
            End Using

        Catch ex As OleDbException

            MessageBox.Show(ex.Message)

        End Try


    End Sub


    Private Sub RemoveConstraint(ByVal strRemoveConstraint As String)

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Using con As OleDbConnection = New OleDbConnection(cs)

            Try


                Dim dc As OleDbCommand = New OleDbCommand(strRemoveConstraint, con)
                con.Open()
                dc.ExecuteNonQuery()

            Catch ex As Exception

            End Try


        End Using


    End Sub

    Private Sub CreateConstraint(ByVal strRemoveConstraint As String)

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Using con As OleDbConnection = New OleDbConnection(cs)

            Try


                Dim dc As OleDbCommand = New OleDbCommand(strRemoveConstraint, con)
                con.Open()
                dc.ExecuteNonQuery()

            Catch ex As Exception

            End Try


        End Using


    End Sub




    Private Function GetDataBasePath() As String

        Dim strPath As String

        strPath = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Dim strArry() As String = strPath.Split(";")

        strPath = strArry(1)

        strPath = strPath.Substring(13, strPath.Length - 13)



        Return strPath
    End Function


    Private Sub cmbBranch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbBranch.KeyPress
        If e.KeyChar = vbBack Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub DeleteRecord()
        'Dim rsRecord As Recordset
        'Dim cn As Connection


        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString


        'Set cn = New ADODB.Connection

        'Set rsRecord = New ADODB.Recordset


        Using con As OleDbConnection = New OleDbConnection(cs)

            Dim dc As OleDbCommand = New OleDbCommand("Select Claiminfo.Branch from Claiminfo where Claiminfo.Branch=@Branch", con)
            dc.CommandType = CommandType.Text
            dc.Parameters.Add("@Branch", OleDbType.Char, 255).Value = cmbBranch.Text
            con.Open()

            Dim dr As OleDbDataReader = dc.ExecuteReader

            Try

                If dr.HasRows = True Then
                    Dim dcDelete As OleDbCommand = New OleDbCommand
                    ' Delete From Claiminfo By Branch Before Data Load
                    dcDelete.Connection = con
                    dcDelete.CommandText = "Delete * from Claiminfo where Claiminfo.ReceptDate Between @ReceptDate1 and @ReceptDate2 and Claiminfo.Branch=@Branch"
                    dcDelete.Parameters.Add("@ReceptDate1", OleDbType.Date).Value = DateTime.Parse(dtpFrom.Value.ToShortDateString).ToString("dd-MMM-yy")
                    dcDelete.Parameters.Add("@ReceptDate2", OleDbType.Date).Value = DateTime.Parse(dtpTo.Value.ToShortDateString).ToString("dd-MMM-yy")
                    dcDelete.Parameters.Add("@Branch", OleDbType.Char, 255).Value = cmbBranch.Text
                    dcDelete.CommandType = CommandType.Text


                    dcDelete.ExecuteNonQuery()

                    ' Delete From Cashsales By Branch Before Data Load
                    dcDelete.Connection = con
                    dcDelete.CommandText = "Delete * from Cashsales where Cashsales.ReceptDate Between @ReceptDate1 and @ReceptDate2 and Cashsales.Branch=@Branch"
                    dcDelete.CommandType = CommandType.Text
                    dcDelete.Parameters.Add("@ReceptDate1", OleDbType.Char, 255).Value = DateTime.Parse(dtpFrom.Value.ToShortDateString).ToString("dd-MMM-yy")
                    dcDelete.Parameters.Add("@ReceptDate2", OleDbType.Char, 255).Value = DateTime.Parse(dtpTo.Value.ToShortDateString).ToString("dd-MMM-yy")
                    dcDelete.Parameters.Add("@Branch", OleDbType.Char, 255).Value = cmbBranch.Text

                    dcDelete.ExecuteNonQuery()
                End If


            Catch ex As Exception

                MessageBox.Show(ex.Message)

            End Try


        End Using



    End Sub





    Private Sub cmdDeleteTable()

        DeleteTempTable("AdvanceInfo1")

        DeleteTempTable("Brand1")

        DeleteTempTable("BrandModel1")


        DeleteTempTable("cType1")




        DeleteTempTable("Claiminfo1")

        DeleteTempTable("CashSales1")

        DeleteTempTable("CustomerClaim1")
        'DeleteTempTable("CustomerClaimOthers1")
        DeleteTempTable("EstimateRefused1")
        'DeleteTempTable("LogUser1")
        DeleteTempTable("NRDetails1")

        'DeleteTempTable("NROthers1")
        DeleteTempTable("Pending1")
        'DeleteTempTable("PendingOther1")
        DeleteTempTable("Replace1")
        DeleteTempTable("ServiceDetails1")
        DeleteTempTable("ServiceDetailsDetails1")
        DeleteTempTable("ServiceItem1")
        DeleteTempTable("tbGrade1")
        'DeleteTempTable("CancelJob1")
        DeleteTempTable("TransferJob1")
        DeleteTempTable("tbBill1")
        DeleteTempTable("tbBill_FFC1")









    End Sub

    Private Sub DeleteTempTable(ByVal strTempTable As String)
        '        Dim conDeleteTempTable As New ADODB.Connection


        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Try
            Using con As OleDbConnection = New OleDbConnection(cs)

                Dim dc As OleDbCommand = New OleDbCommand("Drop Table " & strTempTable, con)
                con.Open()
                dc.ExecuteNonQuery()

            End Using


            Exit Sub


        Catch ex As Exception

        End Try




    End Sub
#Region "Import Category"







    Private Sub InsertCategoryBrandModel()
        Dim strProviderDestination As String
        Dim dc As OleDbCommand = New OleDbCommand()
        'Dim PreviousTime As Date
        'Dim EndTime As Date
        'Dim blnPassword As Boolean
        'Dim intCount As Integer



        Try





            'PreviousTime = Time
            'Password:
            'If blnPassword = False Then
            'strProviderDestination = "provider=Microsoft.Jet.OLEDB.4.0; Data Source=" & Opentxt & "; User Id=Admin; Jet OLEDB:Database Password=asl2004"
            'Else
            'strProviderDestination = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Opentxt
            'End If

            strProviderDestination = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString




            'Set cnDestination = New ADODB.Connection



            Dim tr As OleDbTransaction




            Using con As OleDbConnection = New OleDbConnection(strProviderDestination)

                ' Insert New Category/Brand/Model
                dc.Connection = con
                con.Open()


                tr = con.BeginTransaction


                dc.CommandText = "Insert into cType(cType) Select cType1.cType from cType1 left Join ctype on ctype1.cType=ctype.ctype where isnull(ctype.ctype)"
                dc.ExecuteNonQuery()
                'EndTime = Time
                ListBox1.Items.Add("Category Load Completed") ' & vbTab & " Time: " & Format(EndTime - PreviousTime, "HH-MM-SS")
                Application.DoEvents()
                'PreviousTime = Time
                dc.CommandText = "Insert into Brand(Ctype,Brand,Item,SLNo,Tat) Select Brand1.Ctype,Brand1.Brand,Brand1.Item,Brand1.SLNO,Brand1.Tat From Brand1 Left Join Brand on (Brand1.Ctype=Brand.Ctype) and (Brand1.Brand=Brand.Brand) where isnull(Brand.brdid)"
                dc.ExecuteNonQuery()
                'EndTime = Time
                ListBox1.Items.Add("Brand Load Completed") '& vbTab & " Time: " & Format(EndTime - PreviousTime, "HH-MM-SS")
                Application.DoEvents()

                ' PreviousTime = Time
                dc.CommandText = "Update Brand1 inner Join Brand on (Brand1.ctype=Brand.ctype) and (Brand1.Brand=Brand.Brand) set Brand1.pbrdid=Brand.brdid"
                dc.ExecuteNonQuery()

                dc.CommandText = "Update BrandModel1 inner Join Brand1 on (BrandModel1.brdid=Brand1.brdid)  set BrandModel1.brdid=Brand1.pbrdid"
                dc.ExecuteNonQuery()

                tr.Commit()



                '_________________________________________________________________________________________
                '
                'cnDestination.Execute ("UPDATE BrandModel1 SET BrandModel1.Model = replace(BrandModel1.Model,'- ','-'")
                '
                'cnDestination.Execute ("UPDATE BrandModel1 SET BrandModel1.Model = replace(BrandModel1.Model,' ',''")

                '_________________________________________________________________________________________

                GetModels()

                tr = con.BeginTransaction

                dc.CommandText = "Delete * from  BrandModel1 where BrandModel1.Model in (Select BrandModel1.Model  from BrandModel1 Group by BrandModel1.Model having count(BrandModel1.Model)>1)"
                dc.ExecuteNonQuery()

                'With rsCheckModel
                '
                'If .State = adStateOpen Then
                '.Close
                'End If
                '
                '.CursorLocation = adUseClient
                '.LockType = adLockReadOnly
                '.CursorType = adOpenKeyset
                '.Source = "Select BrandModel.Model From BrandModel right join BrandModel1 on (BrandModel.Model=BrandModel1.Model and Brandmodel.brdid=BrandModel1.brdid) where isnull(BrandModel.Model)"
                '.ActiveConnection = cnDestination
                '.Open
                'End With

                'If rsCheckModel.RecordCount > 0 Then


                dc.CommandText = "Insert into BrandModel(Model,brdid,Charge,Wperiod,Item,SLNO,EntryDate) Select BrandModel1.Model,BrandModel1.brdid,BrandModel1.Charge,BrandModel1.Wperiod,BrandModel1.Item,BrandModel1.SLNO,BrandModel1.EntryDate from BrandModel1 Left Join BrandModel on BrandModel1.Model=BrandModel.Model and BrandModel1.brdid=BrandModel.brdid where isnull(BrandModel.Model)"
                dc.ExecuteNonQuery()

                tr.Commit()
                'EndTime = Time
                Application.DoEvents()
                ListBox1.Items.Add("Model Load Completed") ' & vbTab & " Time: " & Format(EndTime - PreviousTime, "HH-MM-SS")
                'End If




            End Using





        Catch ex As Exception

        End Try

    End Sub
        Private Sub GetModels()

        '            Dim strModel As String
        '            Dim lngTotal As Long
        '            Dim strGetValue As String
        '            Dim lngIncrement As Long
        '            strModel = "Select BrandModel1.Model,BrandModel1.brdid from BrandModel1 where instr(1,BrandModel1.Model,' ')"



        '            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        '            Using con As OleDbConnection = New OleDbConnection(cs)
        '                Dim dc As OleDbCommand = New OleDbCommand(strModel, con)

        '                Dim dr As OleDbDataReader = dc.ExecuteReader

        '                If dr.HasRows = True Then
        '                    dr.r
        '                End If

        '            End Using

        '            With rsModel
        '                If .State = adStateOpen Then
        '                    .Close
        '                End If
        '                .CursorLocation = adUseClient
        '                .LockType = adLockOptimistic
        '                .CursorType = adOpenKeyset
        '                .Source = strModel
        '                .ActiveConnection = strCon
        '                .Open
        '                lngTotal = 0
        '                lngIncrement = 0
        '                If .RecordCount > 0 Then

        '                ReDim strPreviousModel(5000000)
        '                ReDim strCurrentModel(5000000)
        '                ReDim intCurrentbrdid(5000000)

        '                .MoveFirst

        '                    Do While Not .EOF


        '                        For lngTotal = 1 To Len(.Fields("Model").Value)
        '                            If Mid(.Fields("Model").Value, lngTotal, 1) = " " Or Mid(.Fields("Model").Value, lngTotal, 1) = "'" Then
        '                            Else
        '                                strGetValue = strGetValue & Mid(.Fields("Model").Value, lngTotal, 1)
        '                            End If
        '                        Next

        '                        If strGetValue <> .Fields("Model").Value Then
        '                            strPreviousModel(lngIncrement) = .Fields("Model").Value
        '                            strCurrentModel(lngIncrement) = strGetValue
        '                            intCurrentbrdid(lngIncrement) = .Fields("brdid").Value
        '                            lngIncrement = lngIncrement + 1
        '                        End If

        '                        lngTotal = 0
        '                        strGetValue = ""
        '                        .MoveNext
        '                    Loop

        '                End If

        '            End With
        '            rsModel.Close
        'Set rsModel = Nothing
        'UpdateModel()


    End Sub
    Private Sub UpdateModel()
        '        Dim intLoop As Long
        '        Dim conTemp As ADODB.Connection
        '        Dim strProviderTemp As String
        '        Dim blnPassword As Boolean
        '        Dim intCount As Integer


        '        'On Error GoTo LocalErr

        '        'Password:
        '        '
        '        'If blnPassword = False Then
        '        'strProviderTemp = "provider=Microsoft.Jet.OLEDB.4.0; Data Source=" & Opentxt & "; User Id=Admin; Jet OLEDB:Database Password=asl2004"
        '        'Else
        '        'strProviderTemp = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Opentxt
        '        'End If

        '        strProviderTemp = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Opentxt
        'Set conTemp = New ADODB.Connection


        'conTemp = strProviderTemp
        '        With conTemp
        '            If .State = adStateOpen Then
        '                .Close
        '            End If
        '            .CursorLocation = adUseClient
        '            .ConnectionString = strProviderTemp
        '            .Open
        '        End With


        '        For intLoop = 0 To UBound(strCurrentModel)
        '            If Right(strPreviousModel(intLoop), 1) = "'" Then
        '                conTemp.Execute("Update BrandModel1 set BrandModel1.Model='" & strCurrentModel(intLoop) & "' Where BrandModel1.Model='" & strPreviousModel(intLoop) & " and BrandModel1.brdid=" & intCurrentbrdid(intLoop))
        '            Else
        '                conTemp.Execute("Update BrandModel1 set BrandModel1.Model='" & strCurrentModel(intLoop) & "' Where BrandModel1.Model='" & strPreviousModel(intLoop) & "' and BrandModel1.brdid=" & intCurrentbrdid(intLoop))
        '            End If
        '        Next

        'LocalErr:

        '        'blnPassword = True
        '        '
        '        'If intCount >= 3 Then
        '        'Exit Sub
        '        'Else
        '        'intCount = intCount + 1
        '        'End If
        '        '
        '        'Resume Password
        '        '
        '        'Next


    End Sub

#End Region
End Class