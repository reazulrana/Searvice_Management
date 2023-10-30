Imports System.Configuration
Imports System.Data.OleDb
Imports System.Threading


Public Class frmProductInformation
    Dim strBranchList As String = String.Empty

    Dim strCategoryList As String = String.Empty

    Dim strBrand As String = String.Empty
    Dim strWarrType As String = String.Empty
    Dim strDateRange As String
    Dim strProductStatus As String = String.Empty
    Dim strBranch As String = String.Empty
    Dim strCategory As String = String.Empty
    Dim intDistanceCheckBoxesWarrTyep As Integer
    Dim intDistanceCheckBoxesPresentStatus As Integer













    Private Sub loadCategory()
        Dim drLoadCategory As OleDbDataReader = Nothing

        Dim dt As DataTable = New DataTable

        Dim conLoadCategory As New OleDbConnection(strProvider)
        LoadAllInformation(conLoadCategory, drLoadCategory, strProvider, "Ctype", "Ctype", "''")

        Dim lstTempCategory As ListViewItem = Nothing

        lstCategory.DataSource = Nothing
        lstCategory.Items.Clear()


        If drLoadCategory.HasRows = True Then


            dt.Load(drLoadCategory)


            lstCategory.DataSource = dt
            lstCategory.DisplayMember = "Ctype"
            lstCategory.ValueMember = "Ctype"


        End If



        TempConnectionDispose(conLoadCategory)


    End Sub

    Private Sub frmJobStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Me.WindowState = FormWindowState.Maximized


            spltButton.Width = Me.ClientSize.Width

            lstBrand.Visible = False
            lstBranch.Visible = False
            lstCategory.Visible = False
            lstCustomerName.Visible = False
            lstAddress.Visible = False

            LoadBranch()
            loadCategory()
            LoadBrand()



            optAll.Checked = True
            ResizeCheckBoxes()



        Catch LoadErrorex As Exception
            MessageBox.Show(LoadErrorex.Message)

        End Try
    End Sub

    Private Sub DisableCheck()
        chkNotService.Checked = False
        chkService.Checked = False
        chkDelivery.Checked = False
        chkPending.Checked = False
        chkNR.Checked = False
        chkCR.Checked = False
        chkReplace.Checked = False

        chkNotService.Enabled = False
        chkService.Enabled = False
        chkDelivery.Enabled = False
        chkPending.Enabled = False
        chkNR.Enabled = False
        chkCR.Enabled = False
        chkReplace.Enabled = False
    End Sub

    Private Sub DisableEstmateRefuse()
        chkEstimateRefuse.Checked = False
        chkEstimateRefuse.Enabled = False
    End Sub

    Private Sub EnableCheck()

        chkNotService.Checked = False
        chkService.Checked = False
        chkDelivery.Checked = False
        chkPending.Checked = False
        chkNR.Checked = False
        chkCR.Checked = False
        chkReplace.Checked = False

        chkNotService.Enabled = True
        chkService.Enabled = True
        chkDelivery.Enabled = True
        chkPending.Enabled = True
        chkNR.Enabled = True
        chkCR.Enabled = True
        chkReplace.Enabled = True
    End Sub
    Private Sub EnableEstmateRefuse()
        chkEstimateRefuse.Checked = False
        chkEstimateRefuse.Enabled = True
    End Sub

    Private Function Verifycheckstatus() As Boolean
        Dim blnFlag As Boolean = False

        If chkNotService.Checked = True Then
            blnFlag = True

        End If
        If chkService.Checked = True Then
            blnFlag = True

        End If
        If chkDelivery.Checked = True Then
            blnFlag = True

        End If
        If chkPending.Checked = True Then
            blnFlag = True

        End If
        If chkNR.Checked = True Then
            blnFlag = True

        End If
        If chkCR.Checked = True Then
            blnFlag = True

        End If
        If chkReplace.Checked = True Then
            blnFlag = True

        End If






        Return blnFlag

    End Function


    'Private Sub lstCategory_MouseHover(sender As Object, e As EventArgs) Handles lstCategory.MouseHover
    '    If lstCategory.Items.Count > 0 Then
    '        lstCategory.Visible = True
    '        lstCategory.Height = 250
    '        grpControl.Height = grpControl.Height + 250
    '        If lstBrand.Visible = True Then
    '            lstBrand.Visible = False

    '        End If
    '    End If
    'End Sub












    'Private Sub lstBranch_MouseHover(sender As Object, e As EventArgs) Handles lstBranch.MouseHover
    '    If lstBranch.Items.Count > 0 Then
    '        lstBranch.Visible = True
    '        lstBranch.Height = 250
    '        grpControl.Height = grpControl.Height + 250
    '        If lstBrand.Visible = True Then
    '            lstBrand.Visible = False
    '        End If
    '    End If
    'End Sub



    'Private Sub lstBranch_MouseLeave(sender As Object, e As EventArgs) Handles lstBranch.MouseLeave
    '    If lstBranch.Height <> 10 Then
    '        lstBranch.Visible = False
    '        grpControl.Height = 108
    '    End If
    'End Sub


    'Private Sub lstCategory_MouseHover(sender As Object, e As EventArgs) Handles lstCategory.MouseHover
    '    If lstCategory.Items.Count > 0 Then
    '        lstCategory.Height = 400
    '        grpControl.Height = grpControl.Height + 405
    '    End If
    'End Sub

    'Private Sub lstCategory_MouseLeave(sender As Object, e As EventArgs) Handles lstCategory.MouseLeave
    '    If lstCategory.Height <> 10 Then
    '        lstCategory.Visible = False
    '        grpControl.Height = 108
    '    End If
    'End Sub



    'Private Sub lstBrand_MouseLeave(sender As Object, e As EventArgs) Handles lstBrand.MouseLeave
    '    If lstBrand.Height <> 10 Then
    '        lstBrand.Visible = False
    '        grpControl.Height = 108
    '    End If
    'End Sub

    'Private Sub lstBrand_MouseHover(sender As Object, e As EventArgs) Handles lstBrand.MouseHover
    '    If lstBrand.Items.Count > 0 Then
    '        lstBrand.Visible = True
    '        lstBrand.Height = 250
    '        grpControl.Height = grpControl.Height + 250
    '        If lstCategory.Visible = True Then
    '            lstCategory.Visible = False

    '        End If
    '    End If
    'End Sub

    Private Sub LoadBranch()


        Dim dt As DataTable = New DataTable

        Dim drLoadBranch As OleDbDataReader = Nothing
        Dim lstTempBranch As ListViewItem = Nothing

        Dim conLoadBranch As New OleDbConnection(strProvider)
        LoadAllInformation(conLoadBranch, drLoadBranch, strProvider, "Branch", "Branch.Branch", "''")

        If drLoadBranch.HasRows = True Then
            dt.Load(drLoadBranch)


            lstBranch.DataSource = Nothing
            lstBranch.Items.Clear()

            lstBranch.DataSource = dt
            lstBranch.DisplayMember = "Branch"
            lstBranch.ValueMember = "Branch"


        End If


        TempConnectionDispose(conLoadBranch)


    End Sub


    Private Sub LoadCustomerName()

        Dim dt As DataTable = New DataTable

        Dim cs As String = ConfigurationManager.ConnectionStrings("dbcService").ConnectionString

        Using con As OleDbConnection = New OleDbConnection(cs)

            Dim dc = New OleDbCommand("Select Distinct CustName as Customer from Claiminfo order by CLaiminfo.CustName", con)

            con.Open()
            Dim dr As OleDbDataReader = dc.ExecuteReader

            If dr.HasRows = True Then
                dt.Load(dr)
            End If

            lstCustomerName.DataSource = Nothing
            lstCustomerName.Items.Clear()
            lstCustomerName.DataSource = dt
            lstCustomerName.DisplayMember = "Customer"
            lstCustomerName.ValueMember = "Customer"
        End Using




    End Sub

    Private Function GetCustomerName() As String
        Dim strName As String


        strName = String.Empty



        For Each Name As DataRowView In lstCustomerName.CheckedItems

            strName += "'" & Name(0).ToString & "',"

        Next


        If strName.Length > 1 Then
            If strName.Substring(strName.Length - 1) = "," Then
                strName = strName.Substring(0, strName.Length - 1)
            End If
        End If



        Return strName

    End Function



    Private Function GetCustomerAddress() As String
        Dim strAddress As String

        strAddress = String.Empty

        For Each Address As DataRowView In lstAddress.CheckedItems

            strAddress += "'" & Address(0).ToString & "',"

        Next

        If strAddress.Length > 1 Then
            If strAddress.Substring(strAddress.Length - 1) = "," Then
                strAddress = strAddress.Substring(0, strAddress.Length - 1)
            End If
        End If

        Return strAddress

    End Function

    Private Sub LoadCustomerAddress()

        Dim dt As DataTable = New DataTable

        Dim cs As String = ConfigurationManager.ConnectionStrings("dbcService").ConnectionString

        Using con As OleDbConnection = New OleDbConnection(cs)

            Dim dc = New OleDbCommand("Select Distinct CustAddress1 as Address from Claiminfo order by CLaiminfo.CustAddress1", con)

            con.Open()

            Dim dr As OleDbDataReader = dc.ExecuteReader

            If dr.HasRows = True Then
                dt.Load(dr)
            End If

            lstAddress.DataSource = Nothing
            lstAddress.Items.Clear()
            lstAddress.DataSource = dt
            lstAddress.DisplayMember = "Address"
            lstAddress.ValueMember = "Address"
        End Using




    End Sub





    Private Sub grpControl_MouseLeave(sender As Object, e As EventArgs) Handles grpControl.MouseLeave
        HideAllListView()

    End Sub

    Private Sub HideAllListView()



        If lstBranch.Visible = True Then
            lstBranch.Height = 4
            lstBranch.Visible = False
        End If
        If lstCategory.Visible = True Then
            lstCategory.Height = 4
            lstCategory.Visible = False
        End If
        If lstBrand.Visible = True Then
            lstBrand.Height = 4
            lstBrand.Visible = False
        End If

        If lstCustomerName.Visible = True Then
            lstCustomerName.Height = 4
            lstCustomerName.Visible = False
        End If

        If lstAddress.Visible = True Then
            lstAddress.Height = 4
            lstAddress.Visible = False
        End If


    End Sub

    Private Sub SelectBranchs()

        Dim lstTempBranch As ListViewItem = Nothing


        Dim shrtLoop As Short = 0
        Dim strKeepTempValue As String = String.Empty

        For shrtLoop = 0 To lstBranch.Items.Count - 1
            lstTempBranch = lstBranch.Items(shrtLoop)

            If lstTempBranch.Checked = True Then
                strKeepTempValue = strKeepTempValue & "'" & lstTempBranch.SubItems(2).ToString & "',"
            End If
        Next


        If strKeepTempValue <> "" Then
            strBranchList = "Claiminfo.Branch IN(" & strKeepTempValue.ToString & ")"
        End If


    End Sub

    Private Sub frmJobStatus_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        ClearStringValue()


    End Sub


    Private Sub ClearStringValue()
        strBranchList = String.Empty
        strCategoryList = String.Empty
        strBrand = String.Empty
        strBranch = String.Empty
        strCategory = String.Empty
        strWarrType = String.Empty
        strDateRange = String.Empty
        strProductStatus = String.Empty
        intDistanceCheckBoxesPresentStatus = 0
        intDistanceCheckBoxesWarrTyep = 0
    End Sub


    Private Sub LoadBrand()
        Dim drLoadBrand As OleDbDataReader = Nothing
        Dim lstTempBrand As ListViewItem = Nothing
        Dim conLoadBrand As New OleDbConnection(strProvider)
        Dim dt As DataTable = New DataTable


        LoadAllInformation(conLoadBrand, drLoadBrand, strProvider, "Brand", "Distinct Brand.Brand", "''")

        If drLoadBrand.HasRows = True Then

            lstBrand.DataSource = Nothing
            lstBrand.Items.Clear()
            dt.Load(drLoadBrand)



            lstBrand.DataSource = dt
            lstBrand.DisplayMember = "Brand"
            lstBrand.ValueMember = "Brand"

        End If

        TempConnectionDispose(conLoadBrand)

    End Sub



    Private Sub Label5_MouseHover(sender As Object, e As EventArgs) Handles lblBrand.MouseHover
        NotVisible()

        If lstBrand.Items.Count > 0 Then
            lstBrand.Visible = True
            lstBrand.Height = 250
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_MouseHover(sender As Object, e As EventArgs)

    End Sub


    Private Sub Label3_MouseHover(sender As Object, e As EventArgs)





    End Sub


    Private Sub cmdLoad_Click(sender As Object, e As EventArgs) Handles cmdLoad.Click

        Dim drLoadProductInformation As OleDbDataReader = Nothing
        Dim strSubQueryWhereClause As String = String.Empty
        Dim conProductInformation As New OleDbConnection(strProvider)

        HideAllListView() ' Hide All ListView on click

        dgvJobStatus.DataSource = Nothing
        dgvJobStatus.Rows().Clear()


        Dim strSubQeury As String = String.Empty

        GetBranchlist()

        GetCategoryList()
        GetBrandList()

        If GetBranchlist.Length > 0 Then
            strSubQueryWhereClause += GetBranchlist() & " AND "
        End If
        If GetCategoryList.Length > 0 Then
            strSubQueryWhereClause += GetCategoryList() & " AND "
        End If

        If GetBrandList.Length > 0 Then
            strSubQueryWhereClause += GetBrandList() & " AND "
        End If



        If strWarrType.Length > 0 Then
            strSubQueryWhereClause += "Claiminfo.Wcondition in(" & strWarrType & ") AND "
        End If

        If strProductStatus.Length > 0 Then
            strSubQueryWhereClause += "Claiminfo.Cflag in(" & strProductStatus & ") AND "
        End If






        If GetCustomerName.Length > 0 Then

            strSubQueryWhereClause += "Claiminfo.CustName in(" & GetCustomerName() & ") AND "
        End If


        If GetCustomerAddress.Length > 0 Then

            strSubQueryWhereClause += "Claiminfo.custaddress1 in(" & GetCustomerAddress() & ") AND "
        End If




        If strSubQueryWhereClause.Length > 5 Then
            If strSubQueryWhereClause.Substring(strSubQueryWhereClause.Length - 5).ToLower = LCase(" AND ") Then
                strSubQueryWhereClause = strSubQueryWhereClause.Substring(0, strSubQueryWhereClause.Length - 5)
            End If
        End If





        Try


            If optAll.Checked = True Then


                If strSubQueryWhereClause.Length > 0 And chkEstimateRefuse.Checked = False Then
                    strSubQeury = "SELECT  CLaiminfo.JobCode,CLaiminfo.ReceptDate,CLaiminfo.Branch,CLaiminfo.CustName,CLaiminfo.CustAddress1,CLaiminfo.CustAddress2,Claiminfo.ServiceType,CLaiminfo.Brand,
                               CLaiminfo.ModelNo,CustomerClaim.ClaimCode as Fault,Claiminfo.pDate as [PurDate],WarrantyType.Wcondition as [Warr Type],Claiminfo.Cflag as Code,ProductStatus.Status, Claiminfo.IsssueDate, CLaiminfo.Sdate, CLaiminfo.Ddate,Claiminfo.ReceptBy, Claiminfo.IssueTo ,Claiminfo.ServiceBy as ServiceBy,Claiminfo.DeliverBy, '' as Remarks into PorductInformation FROM ((((Claiminfo left JOIN WarrantyType ON Claiminfo.WCondition = WarrantyType.WID) 
                               left JOIN ProductStatus ON Claiminfo.cFlag = ProductStatus.Code) left JOIN EstimateRefused ON Claiminfo.JobCode = EstimateRefused.JobCode) 
                               left Join Personal on Claiminfo.Issueto=personal.empcode) Left join CustomerClaim on Claiminfo.JobCode=CustomerClaim.JobCode where 1=1 AND isnull(EstimateRefused.JobCode)=true and " & strSubQueryWhereClause
                ElseIf strSubQueryWhereClause.Length <= 0 And chkEstimateRefuse.Checked = True Then
                    strSubQeury = "SELECT  CLaiminfo.JobCode,CLaiminfo.ReceptDate,CLaiminfo.Branch,CLaiminfo.CustName,CLaiminfo.CustAddress1,CLaiminfo.CustAddress2,Claiminfo.ServiceType,CLaiminfo.Brand,
                               CLaiminfo.ModelNo,CustomerClaim.ClaimCode as Fault,Claiminfo.pDate as [PurDate], WarrantyType.Wcondition as [Warr Type],Claiminfo.Cflag as Code,ProductStatus.Status, Claiminfo.IsssueDate, CLaiminfo.Sdate, CLaiminfo.Ddate,Claiminfo.ReceptBy, Claiminfo.IssueTo ,Claiminfo.ServiceBy as ServiceBy,Claiminfo.DeliverBy, ('Est Refuse Date:' & EstimateRefused.estDate & space(1) & 'Reason:' & EstimateRefused.EstText & space(1) & 'Amount :' &  EstimateRefused.RefuseAmnt) as Remarks into PorductInformation FROM ((((Claiminfo left JOIN WarrantyType ON Claiminfo.WCondition = WarrantyType.WID) 
                               left JOIN ProductStatus ON Claiminfo.cFlag = ProductStatus.Code) left JOIN EstimateRefused ON Claiminfo.JobCode = EstimateRefused.JobCode) 
                               left Join Personal on Claiminfo.Issueto=personal.empcode)  Left join CustomerClaim on Claiminfo.JobCode=CustomerClaim.JobCode where 1=1 AND isnull(EstimateRefused.JobCode)=false"
                Else
                    strSubQeury = "SELECT  CLaiminfo.JobCode,CLaiminfo.ReceptDate,CLaiminfo.Branch,CLaiminfo.CustName,CLaiminfo.CustAddress1,CLaiminfo.CustAddress2,Claiminfo.ServiceType,CLaiminfo.Brand,
                               CLaiminfo.ModelNo,CustomerClaim.ClaimCode as Fault,Claiminfo.pDate as [PurDate], WarrantyType.Wcondition as [Warr Type],Claiminfo.Cflag as Code,ProductStatus.Status, Claiminfo.IsssueDate, CLaiminfo.Sdate, CLaiminfo.Ddate,Claiminfo.ReceptBy, Claiminfo.IssueTo ,Claiminfo.ServiceBy as ServiceBy,Claiminfo.DeliverBy,('Est Refuse Date:' & EstimateRefused.estDate & space(1) & 'Reason:' & EstimateRefused.EstText & space(1) & 'Amount :' &  EstimateRefused.RefuseAmnt) as Remarks into PorductInformation FROM ((((Claiminfo left JOIN WarrantyType ON Claiminfo.WCondition = WarrantyType.WID) 
                               left JOIN ProductStatus ON Claiminfo.cFlag = ProductStatus.Code) left JOIN EstimateRefused ON Claiminfo.JobCode = EstimateRefused.JobCode) 
                               left Join Personal on Claiminfo.Issueto=personal.empcode)  Left join CustomerClaim on Claiminfo.JobCode=CustomerClaim.JobCode"
                End If




            ElseIf optDateRange.Checked = True Then


                If strSubQueryWhereClause.Length > 0 And chkEstimateRefuse.Checked = False Then
                    strSubQeury = "SELECT  CLaiminfo.JobCode,CLaiminfo.ReceptDate,CLaiminfo.Branch,CLaiminfo.CustName,CLaiminfo.CustAddress1,CLaiminfo.CustAddress2,Claiminfo.ServiceType,CLaiminfo.Brand,
                               CLaiminfo.ModelNo,CustomerClaim.ClaimCode as Fault,Claiminfo.pDate as [PurDate], WarrantyType.Wcondition as [Warr Type],Claiminfo.Cflag as Code,ProductStatus.Status, Claiminfo.IsssueDate, CLaiminfo.Sdate, CLaiminfo.Ddate,Claiminfo.ReceptBy, Claiminfo.IssueTo ,Claiminfo.ServiceBy as ServiceBy,Claiminfo.DeliverBy, '' as Remarks into PorductInformation FROM ((((Claiminfo left JOIN WarrantyType ON Claiminfo.WCondition = WarrantyType.WID) 
                               left JOIN ProductStatus ON Claiminfo.cFlag = ProductStatus.Code) left JOIN EstimateRefused ON Claiminfo.JobCode = EstimateRefused.JobCode) 
                               left Join Personal on Claiminfo.Issueto=personal.empcode) Left join CustomerClaim on Claiminfo.JobCode=CustomerClaim.JobCode where 1=1 AND isnull(EstimateRefused.JobCode)=true and " & strSubQueryWhereClause & " AND " & strDateRange
                ElseIf strSubQueryWhereClause.Length <= 0 And chkEstimateRefuse.Checked = True Then
                    strSubQeury = "SELECT  CLaiminfo.JobCode,CLaiminfo.ReceptDate,CLaiminfo.Branch,CLaiminfo.CustName,CLaiminfo.CustAddress1,CLaiminfo.CustAddress2,Claiminfo.ServiceType,CLaiminfo.Brand,
                               CLaiminfo.ModelNo,CustomerClaim.ClaimCode as Fault,Claiminfo.pDate as [PurDate], WarrantyType.Wcondition as [Warr Type],Claiminfo.Cflag as Code,ProductStatus.Status, Claiminfo.IsssueDate, CLaiminfo.Sdate, CLaiminfo.Ddate,Claiminfo.ReceptBy, Claiminfo.IssueTo ,Claiminfo.ServiceBy as ServiceBy,Claiminfo.DeliverBy, ('Est Refuse Date:' & EstimateRefused.estDate & space(1) & 'Reason:' & EstimateRefused.EstText & space(1) & 'Amount :' &  EstimateRefused.RefuseAmnt) as Remarks into PorductInformation FROM ((((Claiminfo left JOIN WarrantyType ON Claiminfo.WCondition = WarrantyType.WID) 
                               left JOIN ProductStatus ON Claiminfo.cFlag = ProductStatus.Code) left JOIN EstimateRefused ON Claiminfo.JobCode = EstimateRefused.JobCode) 
                               left Join Personal on Claiminfo.Issueto=personal.empcode) Left join CustomerClaim on Claiminfo.JobCode=CustomerClaim.JobCode where 1=1 AND isnull(EstimateRefused.JobCode)=false AND " & strDateRange
                Else
                    strSubQeury = "SELECT  CLaiminfo.JobCode,CLaiminfo.ReceptDate,CLaiminfo.Branch,CLaiminfo.CustName,CLaiminfo.CustAddress1,CLaiminfo.CustAddress2,Claiminfo.ServiceType,CLaiminfo.Brand,
                               CLaiminfo.ModelNo,CustomerClaim.ClaimCode as Fault,Claiminfo.pDate as [PurDate], WarrantyType.Wcondition as [Warr Type],Claiminfo.Cflag as Code,ProductStatus.Status, Claiminfo.IsssueDate, CLaiminfo.Sdate, CLaiminfo.Ddate,Claiminfo.ReceptBy, Claiminfo.IssueTo ,Claiminfo.ServiceBy as ServiceBy,Claiminfo.DeliverBy, ('Est Refuse Date:' & EstimateRefused.estDate & space(1) & 'Reason:' & EstimateRefused.EstText & space(1) & 'Amount :' &  EstimateRefused.RefuseAmnt) as Remarks into PorductInformation FROM ((((Claiminfo left JOIN WarrantyType ON Claiminfo.WCondition = WarrantyType.WID) 
                               left JOIN ProductStatus ON Claiminfo.cFlag = ProductStatus.Code) left JOIN EstimateRefused ON Claiminfo.JobCode = EstimateRefused.JobCode) 
                               left Join Personal on Claiminfo.Issueto=personal.empcode) Left join CustomerClaim on Claiminfo.JobCode=CustomerClaim.JobCode where 1=1 AND " & strDateRange
                End If


            End If


            CreateInformation(strSubQeury)

            dgvJobStatus.DataSource = Nothing
            dgvJobStatus.Rows.Clear()
            dgvJobStatus.DataSource = GetInformation()




            lblRecordCount.Text = "Total Record Found : " & dgvJobStatus.Rows().Count - 1
        Catch ProductLoadex As Exception
            MessageBox.Show(ProductLoadex.Message)

        End Try

        TempConnectionDispose(conProductInformation)

    End Sub


    Private Sub CreateInformation(ByVal strParameter As String)




        Dim cs As String = String.Empty
        cs = ConfigurationManager.ConnectionStrings("dbcService").ConnectionString



        Using con As OleDbConnection = New OleDbConnection(cs)

            Dim dc As OleDbCommand = New OleDbCommand()
            dc.Connection = con


            con.Open()
            If isTempTableExist("PorductInformation") = True Then
                dc.CommandText = "Drop Table PorductInformation"
                dc.ExecuteNonQuery()
            End If
            dc.CommandText = strParameter

            dc.ExecuteNonQuery()
            'Claiminfo.ReceptBy, Claiminfo.IssueTo ,Claiminfo.ServiceBy as ServiceBy,Claiminfo.DeliverBy
            If isTempTableExist("PorductInformation") = True Then
                dc.CommandText = "Update PorductInformation inner join Personal on PorductInformation.ReceptBy= Personal.empcode  set  ReceptBy=PorductInformation.ReceptBy & space(3) & Personal.EmpName "
                dc.ExecuteNonQuery()

                dc.CommandText = "Update PorductInformation inner join Personal on PorductInformation.IssueTo= Personal.empcode  set  IssueTo=PorductInformation.IssueTo & space(3) & Personal.EmpName "
                dc.ExecuteNonQuery()

                dc.CommandText = "Update PorductInformation inner join Personal on PorductInformation.ServiceBy= Personal.empcode  set  ServiceBy=PorductInformation.ServiceBy & space(3) & Personal.EmpName "
                dc.ExecuteNonQuery()
                dc.CommandText = "Update PorductInformation inner join Personal on PorductInformation.DeliverBy= Personal.empcode  set  DeliverBy=PorductInformation.DeliverBy & space(3) & Personal.EmpName "
                dc.ExecuteNonQuery()



                dc.CommandText = "Update PorductInformation inner join nrDetails on PorductInformation.JobCode= nrDetails.jobCode  set  PorductInformation.Remarks=nrDetails.NRCode where  PorductInformation.Code in(99,100)"
                dc.ExecuteNonQuery()

                dc.CommandText = "Update PorductInformation inner join Pending on PorductInformation.JobCode= Pending.jobCode  set  PorductInformation.Remarks=Pending.PenCode where  PorductInformation.Code in(9)"
                dc.ExecuteNonQuery()

                dc.CommandText = "Update PorductInformation inner join ServiceDetails on PorductInformation.JobCode= ServiceDetails.jobCode  set  PorductInformation.Remarks=ServiceDetails.Description where  PorductInformation.Code in(1,0,2)"
                dc.ExecuteNonQuery()


            End If


        End Using


    End Sub

    Private Function GetInformation() As DataTable
        Dim dt As DataTable = New DataTable

        Dim cs As String = String.Empty
        cs = ConfigurationManager.ConnectionStrings("dbcService").ConnectionString


        Dim strSqlQuery = "Select * from PorductInformation"
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dc As OleDbCommand = New OleDbCommand(strSqlQuery, con)
            con.Open()
            Dim dr As OleDbDataReader = dc.ExecuteReader
            If dr.HasRows = True Then
                dt.Load(dr)
            End If

        End Using



        Return dt
    End Function


    Private Function isTempTableExist(ByVal strTableName As String) As Boolean

        Dim blnFlag As Boolean = False

        Try

            Dim cs As String = String.Empty
            cs = ConfigurationManager.ConnectionStrings("dbcService").ConnectionString

            Dim strSqlQuery As String = "Select * from " & strTableName


            Using con As OleDbConnection = New OleDbConnection(cs)

                Dim dc As OleDbCommand = New OleDbCommand(strSqlQuery, con)

                con.Open()

                Dim dr As OleDbDataReader = dc.ExecuteReader




                blnFlag = True





            End Using

        Catch ex As Exception
            blnFlag = False
        End Try


        Return blnFlag

    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblRecordCount.Text = CheckInternetConnection()

    End Sub

    Private Sub optRange_CheckedChanged(sender As Object, e As EventArgs) Handles optDateRange.CheckedChanged
        dtpFrom.Enabled = True
        dtpTo.Enabled = True
        optReceive.Enabled = True
        optRepaired.Enabled = True
        optDelivery.Enabled = True
        optReceive.Checked = True
        GetDateRange()
        GetBranchlist()
        GetBrandList()
        GetCategoryList()
        GetWarrStatus()
        GetProductStatus()
    End Sub

    Private Sub optAll_CheckedChanged(sender As Object, e As EventArgs) Handles optAll.CheckedChanged
        dtpFrom.Enabled = False

        dtpTo.Enabled = False
        'optReceive.Enabled = False
        'optRepaired.Enabled = False
        'optDelivery.Enabled = False
        optReceive.Checked = True
        'optRepaired.Checked = False
        'optDelivery.Checked = False
        'GetDateRange()
        'GetBranchlist()
        'GetBrandList()
        'GetCategoryList()
        'GetWarrStatus()
        'GetProductStatus()

    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Dispose()

    End Sub




    Private Sub GetWarrStatus()
        strWarrType = ""

        If chkSlsWarr.Checked = True Then
            strWarrType = strWarrType & "0,"
        End If
        If chkNonWarr.Checked = True Then
            strWarrType = strWarrType & "1,"
        End If

        If chkSvcWarr.Checked = True Then
            strWarrType = strWarrType & "2,"
        End If



        If strWarrType.Length > 1 Then
            If strWarrType.Substring(strWarrType.Length - 1) = "," Then
                strWarrType = strWarrType.Substring(0, strWarrType.Length - 1)
            End If
        End If






    End Sub

    Private Sub chkSlsWarr_CheckedChanged(sender As Object, e As EventArgs) Handles chkSlsWarr.CheckedChanged
        GetWarrStatus()
    End Sub

    Private Sub chkNonWarr_CheckedChanged(sender As Object, e As EventArgs) Handles chkNonWarr.CheckedChanged
        GetWarrStatus()
    End Sub

    Private Sub chkSvcWarr_CheckedChanged(sender As Object, e As EventArgs) Handles chkSvcWarr.CheckedChanged
        GetWarrStatus()
    End Sub


    Private Sub GetDateRange()
        strDateRange = String.Empty

        If optReceive.Checked = True Then
            strDateRange = "Claiminfo.ReceptDate  Between #" & dtpFrom.Value.ToShortDateString & "# AND #" & dtpTo.Value.ToShortDateString & "#"
        ElseIf optRepaired.Checked = True Then
            strDateRange = "Claiminfo.Sdate  Between #" & dtpFrom.Value.ToShortDateString & "# AND #" & dtpTo.Value.ToShortDateString & "#"
        ElseIf optDelivery.Checked = True Then
            strDateRange = "Claiminfo.Ddate  Between #" & dtpFrom.Value.ToShortDateString & "# AND #" & dtpTo.Value.ToShortDateString & "#"
        End If




    End Sub



    Private Sub GetProductStatus()
        strProductStatus = String.Empty


        If chkNotService.Checked = True Then
            strProductStatus = strProductStatus & "-1,"
        End If

        If chkService.Checked = True Then
            strProductStatus = strProductStatus & "1,"
        End If

        If chkDelivery.Checked = True Then
            strProductStatus = strProductStatus & "0,"
        End If

        If chkPending.Checked = True Then
            strProductStatus = strProductStatus & "9,"
        End If

        If chkNR.Checked = True Then
            strProductStatus = strProductStatus & "99,"
        End If

        If chkCR.Checked = True Then
            strProductStatus = strProductStatus & "100,"
        End If

        If chkReplace.Checked = True Then
            strProductStatus = strProductStatus & "101,102"
        End If

        If strProductStatus.Length > 1 Then
            If strProductStatus.Substring(strProductStatus.Length - 1) = "," Then
                strProductStatus = strProductStatus.Substring(0, strProductStatus.Length - 1)
            End If
        End If



    End Sub

    Private Sub optReceive_CheckedChanged(sender As Object, e As EventArgs) Handles optReceive.CheckedChanged
        GetDateRange()
    End Sub

    Private Sub optRepaired_CheckedChanged(sender As Object, e As EventArgs) Handles optRepaired.CheckedChanged
        GetDateRange()
    End Sub

    Private Sub optDelivery_CheckedChanged(sender As Object, e As EventArgs) Handles optDelivery.CheckedChanged
        GetDateRange()
    End Sub

    Private Sub dtpFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpFrom.ValueChanged
        GetDateRange()
    End Sub

    Private Sub dtpTo_ValueChanged(sender As Object, e As EventArgs) Handles dtpTo.ValueChanged
        GetDateRange()
    End Sub


    Private Function GetBranchlist() As String
        strBranch = String.Empty


        If lstBranch.Items.Count <= 0 Then
            strBranch = ""
        End If
        Dim intLoop As Integer = 0



        For Each lst As DataRowView In lstBranch.CheckedItems
            strBranch = strBranch & "'" & lst(0).ToString & "',"
        Next

        If strBranch.Length > 0 Then


            If strBranch.Substring(strBranch.Length - 1) = "," Then
                strBranch = strBranch.Substring(0, strBranch.Length - 1)

            End If

            strBranch = "Claiminfo.Branch IN (" & strBranch & ")"
        End If
        Return strBranch
    End Function



    Private Function GetCategoryList() As String

        strCategory = String.Empty



        If lstCategory.Items.Count <= 0 Then
            strCategory = ""
        End If

        Dim intLoop As Integer = 0

        Dim lstCheckCategoryList As ListViewItem = Nothing



        For Each Category As DataRowView In lstCategory.CheckedItems
            strCategory = strCategory & "'" & Category(0).ToString & "',"
        Next



        If strCategory <> "" Then
            If strCategory.Substring(strCategory.Length - 1) = "," Then
                strCategory = strCategory.Substring(0, strCategory.Length - 1)
            End If

            strCategory = "Claiminfo.ServiceType IN (" & strCategory & ")"
        End If
        Return strCategory

    End Function



    Private Function GetBrandList() As String
        strBrand = String.Empty

        If lstBrand.Items.Count <= 0 Then

            strBrand = ""

        End If


        For Each strBrandName As DataRowView In lstBrand.CheckedItems

            strBrand = strBrand & "'" & strBrandName(0).ToString & "',"


        Next



        If strBrand.Length > 0 Then
            If strBrand.Substring(strBrand.Length - 1) = "," Then
                strBrand = strBrand.Substring(0, strBrand.Length - 1)
            End If
            strBrand = "Claiminfo.Brand IN (" & strBrand.ToString & ")"
        End If
        Return strBrand
    End Function

    Private Sub chkNotService_CheckedChanged(sender As Object, e As EventArgs) Handles chkNotService.CheckedChanged
        If Verifycheckstatus() = True Then
            DisableEstmateRefuse()
            GetProductStatus()
        Else
            EnableEstmateRefuse()
            GetProductStatus()
        End If


    End Sub

    Private Sub chkService_CheckedChanged(sender As Object, e As EventArgs) Handles chkService.CheckedChanged
        If Verifycheckstatus() = True Then
            DisableEstmateRefuse()
            GetProductStatus()
        Else
            EnableEstmateRefuse()
            GetProductStatus()
        End If

    End Sub

    Private Sub chkDelivery_CheckedChanged(sender As Object, e As EventArgs) Handles chkDelivery.CheckedChanged
        If Verifycheckstatus() = True Then
            DisableEstmateRefuse()
            GetProductStatus()
        Else
            EnableEstmateRefuse()
            GetProductStatus()
        End If


    End Sub

    Private Sub chkPending_CheckedChanged(sender As Object, e As EventArgs) Handles chkPending.CheckedChanged
        If Verifycheckstatus() = True Then
            DisableEstmateRefuse()
            GetProductStatus()
        Else
            EnableEstmateRefuse()
            GetProductStatus()
        End If


    End Sub

    Private Sub chkNR_CheckedChanged(sender As Object, e As EventArgs) Handles chkNR.CheckedChanged
        If Verifycheckstatus() = True Then
            DisableEstmateRefuse()
            GetProductStatus()
        Else
            EnableEstmateRefuse()
            GetProductStatus()
        End If


    End Sub

    Private Sub chkCR_CheckedChanged(sender As Object, e As EventArgs) Handles chkCR.CheckedChanged
        If Verifycheckstatus() = True Then
            DisableEstmateRefuse()
            GetProductStatus()
        Else
            EnableEstmateRefuse()
            GetProductStatus()
        End If

    End Sub

    Private Sub chkReplace_CheckedChanged(sender As Object, e As EventArgs) Handles chkReplace.CheckedChanged
        If Verifycheckstatus() = True Then
            DisableEstmateRefuse()
            GetProductStatus()
        Else
            EnableEstmateRefuse()
            GetProductStatus()
        End If


    End Sub

    Private Sub chkEstimateRefuse_CheckedChanged(sender As Object, e As EventArgs) Handles chkEstimateRefuse.CheckedChanged
        If chkEstimateRefuse.Checked = True Then
            DisableCheck()

        Else
            EnableCheck()

        End If

    End Sub

    Private Sub frmProductInformation_Resize(sender As Object, e As EventArgs) Handles Me.Resize


        grpControl.Width = Me.ClientSize.Width
        dgvJobStatus.Width = Me.ClientSize.Width
        grpControl.Left = 0
        dgvJobStatus.Left = 0
        dgvJobStatus.Top = lstBranch.Top + lstBranch.Height + 2
        dgvJobStatus.Height = Me.ClientSize.Height - (lstBranch.Top + lstBranch.Height + spltButton.Height + 2)
        'Commanbutton LabelBox Resize
        ResizeCheckBoxes()

    End Sub

    Private Sub ResizeCheckBoxes()
        intDistanceCheckBoxesPresentStatus = (((grpControl.Width - 10) - (chkNotService.Width * 8)) / 8)

        intDistanceCheckBoxesWarrTyep = ((grpControl.Width - 5) - (grpDate.Left + grpDate.Width + (chkSlsWarr.Width * 3))) / 3



        'Resize Combox, Checkbox and Label


        'optAll.Left = 10
        'optDateRange.Left = optAll.Left + optAll.Width + intDistanceCheckBoxesWarrTyep
        'lblFrom.AutoEllipsis = optDateRange.Left + optDateRange.Width + intDistanceCheckBoxesWarrTyep
        'dtpFrom.Left = lblFrom.Left + lblFrom.Width + 5
        'lblTo.Left = dtpFrom.Left + dtpFrom.Width + intDistanceCheckBoxesWarrTyep
        'dtpTo.Left = lblTo.Left + lblTo.Width + intDistanceCheckBoxesWarrTyep + 5


        lblRecordCount.Top = Me.ClientSize.Height - (lblRecordCount.Height + (spltButton.Height / 7))

        cmdLoad.Left = lblRecordCount.Left + lblRecordCount.Width + 2
        cmdLoad.Width = ((spltButton.Width - (lblRecordCount.Left + lblRecordCount.Width)) / 3) - 2


        cmdLoad.Top = Me.ClientSize.Height - (cmdLoad.Height + (spltButton.Height / 7))


        cmdExport.Width = cmdLoad.Width
        cmdExport.Left = cmdLoad.Left + cmdLoad.Width + 2
        cmdExport.Top = cmdLoad.Top
        cmdClose.Left = cmdExport.Left + cmdExport.Width + 2
        cmdClose.Width = cmdLoad.Width
        cmdClose.Top = cmdLoad.Top



        lblLine2.Left = grpControl.Left
        lblLine2.Width = grpControl.Width

        chkNotService.Left = 10
        chkService.Left = intDistanceCheckBoxesPresentStatus + chkNotService.Left + chkNotService.Width
        chkDelivery.Left = chkService.Left + chkService.Width + intDistanceCheckBoxesPresentStatus
        chkPending.Left = chkDelivery.Left + chkDelivery.Width + intDistanceCheckBoxesPresentStatus
        chkNR.Left = chkPending.Left + chkPending.Width + intDistanceCheckBoxesPresentStatus
        chkCR.Left = chkNR.Left + chkNR.Width + intDistanceCheckBoxesPresentStatus
        chkReplace.Left = chkCR.Left + chkCR.Width + intDistanceCheckBoxesPresentStatus
        chkEstimateRefuse.Left = chkReplace.Left + chkReplace.Width + intDistanceCheckBoxesPresentStatus
        chkSlsWarr.Left = grpDate.Left + grpDate.Width + 5
        chkNonWarr.Left = chkSlsWarr.Left + chkSlsWarr.Width + intDistanceCheckBoxesWarrTyep
        chkSvcWarr.Left = chkNonWarr.Left + chkNonWarr.Width + intDistanceCheckBoxesWarrTyep



    End Sub

    Private Sub cmdExport_Click(sender As Object, e As EventArgs) Handles cmdExport.Click
        HideAllListView() ' Hide All ListView on click
        ExportDataIntoExcel(dgvJobStatus)
    End Sub

    Private Sub grpControl_Enter(sender As Object, e As EventArgs) Handles grpControl.Enter

    End Sub

    Private Sub frmProductInformation_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter

    End Sub

    Private Sub frmProductInformation_ResizeBegin(sender As Object, e As EventArgs) Handles Me.ResizeBegin


    End Sub

    Private Sub dgvJobStatus_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvJobStatus.CellContentClick

    End Sub

    Private Sub lblLine2_GotFocus(sender As Object, e As EventArgs) Handles lblLine2.GotFocus

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles lblBrand.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click_1(sender As Object, e As EventArgs) Handles lblCategory.Click

    End Sub








    Private Sub lblBranch_MouseHover(sender As Object, e As EventArgs) Handles lblBranch.MouseHover
        NotVisible()

        If lstBranch.Items.Count > 0 Then
            lstBranch.Visible = True
            lstBranch.Height = 250
            'lblBranch.Font = New Font("Times New Roamn", FontStyle.Bold)

        Else
            MsgBox("No Branch in the list", vbInformation, "Show Fail")
        End If
    End Sub

    Private Sub NotVisible()
        If lstBranch.Visible = True Then
            lstBranch.Visible = False
        End If

        If lstCategory.Visible = True Then
            lstCategory.Visible = False
        End If


        If lstBrand.Visible = True Then
            lstBrand.Visible = False
        End If



        If lstCustomerName.Visible = True Then
            lstCustomerName.Visible = False
        End If


        If lstAddress.Visible = True Then
            lstAddress.Visible = False
        End If

    End Sub

    Private Sub lblCategory_MouseHover(sender As Object, e As EventArgs) Handles lblCategory.MouseHover
        NotVisible()

        If lstCategory.Items.Count > 0 Then
            lstCategory.Visible = True
            lstCategory.Height = 250

        Else
            MsgBox("No Category in the list", vbInformation, "Show Fail")
        End If
    End Sub

    Private Sub lblBranch_Click(sender As Object, e As EventArgs) Handles lblBranch.Click

    End Sub

    Private Sub lblCustomerName_Click(sender As Object, e As EventArgs) Handles lblCustomerName.Click

    End Sub

    Private Sub lblCustomerName_MouseHover(sender As Object, e As EventArgs) Handles lblCustomerName.MouseHover
        NotVisible()

        If lstCustomerName.Items.Count > 0 Then
            lstCustomerName.Visible = True
            lstCustomerName.Height = 250
        End If
    End Sub

    Private Sub lblAddress_Click(sender As Object, e As EventArgs) Handles lblAddress.Click

    End Sub

    Private Sub lblAddress_MouseHover(sender As Object, e As EventArgs) Handles lblAddress.MouseHover
        NotVisible()


        If lstAddress.Items.Count > 0 Then
            lstAddress.Visible = True
            lstAddress.Height = 250
        End If
    End Sub

    Private Sub spltButton_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles spltButton.SplitterMoved

    End Sub

    Private Sub lblBranch_MouseLeave(sender As Object, e As EventArgs) Handles lblBranch.MouseLeave

    End Sub

    Private Sub frmProductInformation_MenuStart(sender As Object, e As EventArgs) Handles Me.MenuStart

    End Sub

    Private Sub dgvJobStatus_Click(sender As Object, e As EventArgs) Handles dgvJobStatus.Click
        HideAllListView() ' Hide All ListView on click
    End Sub

    Private Sub picLoadCustomer_Click(sender As Object, e As EventArgs) Handles picLoadCustomer.Click
        LoadCustomerName()
    End Sub

    Private Sub picLoadAddress_Click(sender As Object, e As EventArgs) Handles picLoadAddress.Click
        LoadCustomerAddress()
    End Sub
End Class