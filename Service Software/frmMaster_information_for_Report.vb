Imports System
Imports System.Data.OleDb
Imports System.Text

Public Class frmMaster_information

    Dim strBranchCriteria As String = String.Empty
    Dim strCategoryCriteria As String = String.Empty
    Dim strBrandCriteria As String = String.Empty
    Dim strModelCriteria As String = String.Empty
    Dim strConcatenateCriteria As String = String.Empty


    'Job Status and Warranty Status Variable
    Dim strJobStatusValue As String = String.Empty
    Dim strWarrantyStatus As String
    '_________________________________________________________________

    Dim strDateRange As String

    Dim blnBranchFlag As Boolean
    Dim blnCategoryFlag As Boolean
    Dim blnBrandFlag As Boolean
    Dim blnModelFlag As Boolean
    Dim tempForm As frmReportShow = New frmReportShow
    Dim ReportClass As clsReportClass = New clsReportClass
    Dim strTBranch As String = String.Empty
    Dim strTBrand As String = String.Empty
    Dim strTCategory As String = String.Empty







    Private Sub LoadBranch()

        Dim brMethods As clsBranchMethods = New clsBranchMethods
        Dim branchList As List(Of clsBranch) = brMethods.GetOpenBranches().ToList




        Dim lstBranchItem As ListViewItem = New ListViewItem
        If branchList.Count > 0 Then


            lstReportBranch.Enabled = True
            For Each branch As clsBranch In branchList
                lstBranchItem = lstReportBranch.Items.Add(lstReportBranch.Items.Count + 1)
                lstBranchItem.SubItems.Add(branch.Branch)

            Next



        End If
    End Sub






    Private Sub LoadCategory()
        Dim CategoryMethods As clscTypeMethods = New clscTypeMethods
        Dim Categories As List(Of clscType) = CategoryMethods.GetAllCategory.ToList

        lstReportCategory.Items.Clear()
        If Categories.Count > 0 Then




            Dim lstItem As ListViewItem = New ListViewItem
            For Each Category As clscType In Categories
                lstItem = lstReportCategory.Items.Add(lstReportCategory.Items.Count + 1)
                lstItem.SubItems.Add(Category.CategoryName)
            Next
        End If
        blnCategoryFlag = True

    End Sub





    Private Function IsCheckedAll() As Boolean
        Dim blnFlag As Boolean = True



        If chkReportBranch.Checked = False Then
            blnFlag = False
        End If

        If chkReportCategory.Checked = False Then
            blnFlag = False
        End If


        If chkReportBrand.Checked = False Then
            blnFlag = False
        End If

        If chkReportModel.Checked = False Then
            blnFlag = False
        End If


        Return blnFlag




    End Function
    Private Sub frmChoose_information_for_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        CenterForm(Me)

        If lstReportBranch.Columns.Count = 0 Then
            lstReportBranch.Columns.Add("Sl").Width = 45
            lstReportBranch.Columns.Add("Branch").Width = 95
        End If


        If lstReportCategory.Columns.Count = 0 Then
            lstReportCategory.Columns.Add("Sl").Width = 45
            lstReportCategory.Columns.Add("Category").Width = 95
        End If

        If lstReportBrand.Columns.Count <= 0 Then
            lstReportBrand.Columns.Add("Sl").Width = 45
            lstReportBrand.Columns.Add("Brand").Width = 95
        End If


        If lstReportModel.Columns.Count <= 0 Then
            lstReportModel.Columns.Add("Sl").Width = 45
            lstReportModel.Columns.Add("Model").Width = 95
        End If



        blnBranchFlag = False
        blnCategoryFlag = False
        blnBrandFlag = False
        blnModelFlag = False
        grpStatus.Height = 90

        dtpFrom.Value = Now.ToShortDateString
        dtpTo.Value = Now.ToShortDateString

        CheckedAllStatus(ReportIdentification)

        If UCase(ReportIdentification) = UCase("Receive") Then
            chkEstimateRefuse.Checked = False
            chkEstimateRefuse.Enabled = False
        ElseIf ReportIdentification.ToLower = LCase("Job Storage") Then
            DisableAllStatus()
        ElseIf ReportIdentification.ToLower = LCase("Customer Details") Then
            DisableAllStatus()
        ElseIf ReportIdentification.ToLower = LCase("Job Transfer") Then
            DisableAllStatus()

        ElseIf UCase(ReportIdentification) = UCase("Repair") Then
            DisableAllStatus()

            chkRepaired.Enabled = True
            chkRepaired.Checked = True

            chkDelivered.Enabled = True
            chkDelivered.Checked = True

        ElseIf ReportIdentification = "ReportDiscountDelivered" Then

            DisableAllStatus()
            chkDelivered.Checked = True

        ElseIf ReportIdentification = "Under Process" Then
            DisableAllStatus()
            chkWaitingforService.Checked = True
        ElseIf ReportIdentification.ToLower = LCase("Not Assign Job") Then

            DisableAllStatus()
            chkWaitingforService.Checked = True



        ElseIf UCase(ReportIdentification) = UCase("Delivery") Then
            DisableAllStatus()

            chkDelivered.Checked = True
        ElseIf ReportIdentification = UCase("Pending Repair") Then

            DisableAllStatus()

            chkPending.Checked = True

        ElseIf ReportIdentification = UCase("Estimate Refuse") Then
            DisableAllStatus()
            chkRepaired.Enabled = True
            chkRepaired.Checked = True

            chkDelivered.Enabled = True
            chkDelivered.Checked = True
            chkEstimateRefuse.Checked = True

        ElseIf ReportIdentification = UCase("Pending Delivery") Then

            DisableAllStatus()
            chkRepaired.Checked = True
            chkReplace.Checked = True
            chkNR.Checked = True
        ElseIf ReportIdentification = UCase("NRCR") Then
            DisableAllStatus()
            chkCR.Enabled = True
            chkNR.Enabled = True
            chkCR.Checked = True
            chkNR.Checked = True

        ElseIf ReportIdentification = UCase("Parts Consumption Repair") Or ReportIdentification = UCase("Parts Consumption Delivery") Then
            DisableAllStatus()
            grpStatus.Height = 118

            If optByRepaired.Checked = True Then
                chkRepaired.Checked = True
                chkRepaired.Enabled = True
                chkDelivered.Enabled = True
                chkDelivered.Checked = True
            End If
            If optByDelivery.Checked = True Then
                chkDelivered.Enabled = True
                chkDelivered.Checked = True
            End If

        ElseIf ReportIdentification = UCase("Parts Consumption Summery Repair") Or ReportIdentification = UCase("Parts Consumption Summery Delivery") Then
            DisableAllStatus()
            grpStatus.Height = 118

        ElseIf ReportIdentification = UCase("Technician Performance Details") Or ReportIdentification = UCase("Technician Performance Summery") Or ReportIdentification = UCase("Technician Performance Time Elapsed") Then
            DisableAllStatus()
        ElseIf ReportIdentification = UCase("Receive Summery Category Wise") Or ReportIdentification = UCase("Receive Summery Branch Wise") Or ReportIdentification = UCase("Receive Summery Model Wise") Then
            DisableAllStatus()
        ElseIf ReportIdentification = UCase("Repaired Summery Branch Wise") Or ReportIdentification = UCase("Repaired Summery Category Wise") Or ReportIdentification = UCase("Repaired Summery Brand Wise") Or ReportIdentification = UCase("Repaired Summery Model Wise") Then
            DisableAllStatus()

        ElseIf ReportIdentification = UCase("Delivered Summery Branch Wise") Or ReportIdentification = UCase("Delivered Summery Category Wise") Or ReportIdentification = UCase("Delivered Summery Brand Wise") Or ReportIdentification = UCase("Delivered Summery Model Wise") Then
            DisableAllStatus()
        ElseIf ReportIdentification = UCase("Service Collection Branch") Then
            DisableAllStatus()
            chkDelivered.Checked = True
        End If

        ' DisableCheck()
        'ListViewinvisible()

    End Sub

    Private Sub DisableCheck()
        chkReportBranch.Checked = False
        chkReportCategory.Checked = False
        chkReportBrand.Checked = False
        chkReportModel.Checked = False

    End Sub





    Private Sub ListViewinvisible()
        lstReportBranch.Visible = False
        lstReportCategory.Visible = False
        lstReportBrand.Visible = False
        lstReportModel.Visible = False
        chkReportCategory.Enabled = False
        chkReportBrand.Enabled = False
        chkReportModel.Enabled = False




    End Sub






    Private Function checkedBranch() As String
        Dim strBranch As String = String.Empty
        If lstReportBranch.Items.Count > 0 Then

            For Each item As ListViewItem In lstReportBranch.Items

                If item.Checked = True Then
                    strBranch += "'" & item.SubItems(1).Text & "',"
                End If


            Next

        End If
        If Not String.IsNullOrEmpty(Trim(strBranch)) Then
            If strBranch.Substring(strBranch.Length - 1, 1) = "," Then
                strBranch = strBranch.Substring(0, strBranch.Length - 1)
            End If
        End If


        Return strBranch

    End Function









    Private Function checkSelectedBrandID() As String
        Dim strBrand As String = String.Empty

        If lstReportBrand.Items.Count > 0 Then

            For Each item As ListViewItem In lstReportBrand.Items

                If item.Checked = True Then
                    strBrand += item.Tag & ","
                End If


            Next

        End If
        If Not String.IsNullOrEmpty(Trim(strBrand)) Then
            If strBrand.Substring(strBrand.Length - 1, 1) = "," Then
                strBrand = strBrand.Substring(0, strBrand.Length - 1)
            End If
        End If


        Return strBrand
    End Function







    Private Function CheckedCategory() As String
        Dim strSQLParameter As StringBuilder = New StringBuilder
        Dim strGetValue As String = String.Empty
        If lstReportCategory.Items.Count > 0 Then

            For Each lstItem As ListViewItem In lstReportCategory.Items

                If lstItem.Checked = True Then
                    strSQLParameter.Append("'" & lstItem.SubItems(1).Text & "',")
                End If

            Next

            If strSQLParameter.Length > 0 Then
                strGetValue = strSQLParameter.ToString.TrimEnd(",")
            End If

        End If

        Return strGetValue
    End Function

    Private Sub LoadBrand(ByVal strCategories As String)


        Dim BrandMethods As clsBrandMethods = New clsBrandMethods
        Dim ListOfBrand As List(Of clsBrand) = BrandMethods.GetDistinctBrand(strCategories).ToList

        lstReportBrand.Items.Clear()

        If ListOfBrand.Count > 0 Then

            If lstReportBrand.Columns.Count = 0 Then
                lstReportBrand.Columns.Add("Sl").Width = 45
                lstReportBrand.Columns.Add("Brand").Width = 95
            End If

            Dim lstItem As ListViewItem = New ListViewItem

            For Each Brand As clsBrand In ListOfBrand
                lstItem = lstReportBrand.Items.Add(lstReportBrand.Items.Count + 1)
                lstItem.SubItems.Add(Brand.Brand)
            Next


        End If






    End Sub






    Private Function checkedModel() As String
        Dim strModel As String = String.Empty
        If lstReportModel.Items.Count > 0 Then
            For Each item As ListViewItem In lstReportModel.Items
                If item.Checked = True Then
                    strModel += "'" & item.SubItems(1).Text & "',"
                End If
            Next

            If Not String.IsNullOrEmpty(Trim(strModel)) Then
                If strModel.Substring(strModel.Length - 1) = "," Then
                    strModel = strModel.Substring(0, strModel.Length - 1)
                End If
            End If

        End If
        Return strModel
    End Function
    Private Sub LoadModel()
        Dim strTempWhere As String = checkSelectedBrandID()
        If Not String.IsNullOrEmpty(Trim(strTempWhere)) Then
            strTempWhere = strTempWhere
        End If
        Dim BrandModelMethods As clsBrandModelMethods = New clsBrandModelMethods
        Dim BrandModelList As List(Of clsBrandModel) = BrandModelMethods.Filter(strTempWhere).ToList


        If lstReportModel.Columns.Count <= 0 Then
            lstReportModel.Columns.Add("Sl").Width = 45
            lstReportModel.Columns.Add("Category").Width = 95
        End If


        Dim lstBrandModel As ListViewItem = New ListViewItem

        If BrandModelList.Count > 0 Then



            lstReportModel.Enabled = True

            For Each Model As clsBrandModel In BrandModelList

                lstBrandModel = lstReportModel.Items.Add(lstReportModel.Items.Count + 1)
                lstBrandModel.SubItems.Add(Model.Model)


            Next
        End If
        lstReportModel.Visible = True
    End Sub

    Private Sub cmdShowReport_Click_2(sender As Object, e As EventArgs) Handles cmdShowReport.Click
        Dim frmTempReportShow As New frmReportShow

        Dim strCriteriaValue As String = String.Empty






        JobStatus()
        WarrantyType()
        DateRange()




        If optGroupSelection.Checked = True Then ' if group selection is enabled then 

            If IsCheckedAll() = True Then
                strCriteriaValue = "1=1"
            Else
                If Not String.IsNullOrEmpty(Trim(GetAdditionalCriteria)) Then
                    strCriteriaValue = GetAdditionalCriteria()
                Else
                    strCriteriaValue = "1=1"
                End If
            End If

        ElseIf optSingleSelection.Checked = True Then ' if Single selection is enabled then 

            If Not String.IsNullOrEmpty(Trim(GetAdditionalCriteria)) Then
                strCriteriaValue = GetAdditionalCriteria()
            Else
                strCriteriaValue = "1=1"
            End If

        End If



        If Not String.IsNullOrEmpty(Trim(ReportClass.Wcondition)) Then
            strCriteriaValue += " AND " & ReportClass.Wcondition
        End If

        If Not String.IsNullOrEmpty(Trim(ReportClass.ProductStatus)) Then
            strCriteriaValue += " AND " & ReportClass.ProductStatus
        End If


        If Not String.IsNullOrEmpty(Trim(ReportClass.DateRange)) Then
            strCriteriaValue += " AND " & ReportClass.DateRange
        End If



        frmTempReportShow.strBranchName = strTBranch
        frmTempReportShow.strBrandName = strTBrand
        frmTempReportShow.strCategory = strTCategory



        frmTempReportShow.DeliveryCashsales = tempForm.DeliveryCashsales
        frmTempReportShow.strSQLCriteria = strCriteriaValue.ToString
        strCriteriaValue = String.Empty

        frmTempReportShow.dtStartDate = dtpFrom.Value.ToShortDateString
        frmTempReportShow.dtEndDate = dtpTo.Value.ToShortDateString
        frmTempReportShow.blnSalesWarrPrice = chkSalesWarrPrice.Checked

        frmTempReportShow.Show()

    End Sub

    Private Function GetAdditionalCriteria() As String
        Dim strCriteria As String
        strCriteria = String.Empty
        ReportClass.Branch = String.Empty
        ReportClass.ServiceType = String.Empty
        ReportClass.Brand = String.Empty
        ReportClass.ModelNo = String.Empty
        tempForm.DeliveryCashsales.Branch = "1=1"
        tempForm.DeliveryCashsales.Category = String.Empty
        tempForm.DeliveryCashsales.Brand = String.Empty
        tempForm.DeliveryCashsales.ModelNo = String.Empty

        strTBranch = ""
        strTBrand = ""
        strTCategory = ""




        If optGroupSelection.Checked = True Then
                If Not String.IsNullOrEmpty(Trim(checkedBranch)) Then
                    ReportClass.Branch = "Claiminfo.Branch In (" & checkedBranch() & ")"
                If ReportIdentification = UCase("Delivery") Then
                    tempForm.DeliveryCashsales.Branch = tempForm.DeliveryCashsales.Branch & " AND Cashsales.Branch In (" & checkedBranch() & ")"
                End If
                strTBranch = "Multi-Branch"
            End If

                If Not String.IsNullOrEmpty(Trim(CheckedCategory)) Then
                ReportClass.ServiceType = "Claiminfo.ServiceType In (" & CheckedCategory() & ")"
                strTCategory = "Multi-Category"
            End If

                If Not String.IsNullOrEmpty(Trim(CheckedBrand)) Then
                    ReportClass.Brand = "Claiminfo.brand In (" & CheckedBrand() & ")"
                strTBrand = "Multi-Brand"
            End If

                If Not String.IsNullOrEmpty(Trim(checkedModel)) Then
                    ReportClass.ModelNo = "Claiminfo.ModelNo In (" & checkedModel() & ")"

                End If

            ElseIf optSingleSelection.Checked = True Then

                If Not String.IsNullOrEmpty(Trim(cmbBranch.Text)) Then
                ReportClass.Branch = "Claiminfo.Branch In ('" & cmbBranch.Text & "')"
                If ReportIdentification = UCase("Delivery") Then
                    tempForm.DeliveryCashsales.Branch = tempForm.DeliveryCashsales.Branch & " AND Cashsales.Branch In ('" & cmbBranch.Text & "')"
                End If
                strTBranch = cmbBranch.Text
            End If

                If Not String.IsNullOrEmpty(Trim(cmbCategory.Text)) Then
                ReportClass.ServiceType = "Claiminfo.ServiceType In ('" & cmbCategory.Text & "')"
                strTCategory = cmbCategory.Text
            End If

                If Not String.IsNullOrEmpty(Trim(cmbBrand.Text)) Then
                ReportClass.Brand = "Claiminfo.brand In ('" & cmbBrand.Text & "')"
                strTBrand = cmbBrand.Text
            End If

                If Not String.IsNullOrEmpty(Trim(cmbModel.Text)) Then
                    ReportClass.ModelNo = "Claiminfo.ModelNo In ('" & cmbModel.Text & "')"
                End If


            End If


        With ReportClass
            If Not String.IsNullOrEmpty(Trim(.Branch)) Then

                strCriteria += .Branch & " AND "
            End If



            If Not String.IsNullOrEmpty(Trim(.ServiceType)) Then

                strCriteria += .ServiceType & " AND "
            End If

            If Not String.IsNullOrEmpty(Trim(.Brand)) Then

                strCriteria += .Brand & " AND "
            End If

            If Not String.IsNullOrEmpty(Trim(.ModelNo)) Then

                strCriteria += .ModelNo & " AND "
            End If


            If Not String.IsNullOrEmpty(Trim(strCriteria)) Then
                If strCriteria.Substring(strCriteria.Length - 5).ToLower = LCase(" And ") Then
                    strCriteria = strCriteria.Substring(0, strCriteria.Length - 5)
                End If
            End If
        End With

        Return strCriteria

    End Function




    Private Sub lstReportBranch_ItemChecked(sender As Object, e As ItemCheckedEventArgs)



    End Sub

    Private Sub checkAllItem(ByVal lstTemp As ListView, ByVal strChecked_Unchaked As String)

        'Dim lstTempItem As ListViewItem = Nothing

        'Dim intLoop As Integer = 0



        'If UCase(strChecked_Unchaked) = UCase("Checked") Then
        '    For intLoop = 0 To lstTemp.Items.Count - 1
        '        lstTempItem = lstTemp.Items(intLoop)
        '        lstTempItem.Checked = True
        '    Next
        'ElseIf UCase(strChecked_Unchaked) = UCase("UnChecked") Then
        '    For intLoop = 0 To lstTemp.Items.Count - 1
        '        lstTempItem = lstTemp.Items(intLoop)
        '        lstTempItem.Checked = False
        '    Next
        'End If


    End Sub



    Private Sub CheckItem(ByVal TemplistObject As ListView, ByVal strColumnName As String)

        Dim strTempValue As String

        ' strTempBranchName = String.Empty

        Dim lstItemCheck As ListViewItem = Nothing

        strTempValue = String.Empty


        Dim intLoop As Integer = 0


        If TemplistObject.Items(0).Checked = True Then



            If strColumnName.ToUpper = UCase("Branch") Then
                strBranchCriteria = String.Empty

            ElseIf strColumnName.ToUpper = UCase("Category") Then
                strCategoryCriteria = String.Empty
            ElseIf strColumnName.ToUpper = UCase("Brand") Then
                strBrandCriteria = String.Empty
            ElseIf strColumnName.ToUpper = UCase("Model") Then
                strModelCriteria = String.Empty
            End If

            Exit Sub

        Else

            For intLoop = 1 To TemplistObject.Items.Count - 1
                lstItemCheck = TemplistObject.Items(intLoop)
                If lstItemCheck.Checked = True Then
                    strTempValue = strTempValue & "'" & lstItemCheck.SubItems(1).Text & "',"
                End If
            Next


            If strTempValue <> String.Empty Then
                If strTempValue.Substring(strTempValue.Length - 1) = "," Then
                    strTempValue = strTempValue.Substring(0, strTempValue.Length - 1)
                End If

                If UCase(strColumnName) = UCase("Branch") Then
                    strBranchCriteria = "Claiminfo.Branch In(" & strTempValue & ") AND "
                ElseIf UCase(strColumnName) = UCase("Category") Then

                    strCategoryCriteria = "Claiminfo.ServiceType In(" & strTempValue & ") AND "

                ElseIf UCase(strColumnName) = UCase("Brand") Then


                    strBrandCriteria = "Claiminfo.Brand In(" & strTempValue & ") AND "
                ElseIf UCase(strColumnName) = UCase("Model") Then

                    strModelCriteria = "Claiminfo.ModelNo In(" & strTempValue & ") AND "
                End If
                ConcatenateVariable()

            End If
        End If

    End Sub






    Private Sub ConcatenateVariable()

        strConcatenateCriteria = String.Empty



        If chkReportCategory.Checked = True Then

            strConcatenateCriteria = strConcatenateCriteria & strBranchCriteria
        End If


        If chkReportBrand.Checked = True Then

            strConcatenateCriteria = strConcatenateCriteria & strCategoryCriteria

        End If


        If chkReportModel.Checked = True Then
            strConcatenateCriteria = strConcatenateCriteria & strBrandCriteria
        End If

        If strConcatenateCriteria <> "" Then

            If UCase(strConcatenateCriteria.Substring(strConcatenateCriteria.Length - 4)) = UCase("And ") Then
                strConcatenateCriteria = strConcatenateCriteria.Substring(0, strConcatenateCriteria.Length - 4)
            End If

        End If

    End Sub


    Private Sub ChecktheSelectedBox()

        If chkReportCategory.Checked = False Then
            strBranchCriteria = String.Empty
        End If


        If chkReportBrand.Checked = True Then
            strCategoryCriteria = String.Empty
        End If


        If chkReportModel.Checked = False Then
            strModelCriteria = String.Empty

        End If

    End Sub


    Private Sub JobStatus()
        ReportClass.ProductStatus = String.Empty
        With ReportClass



            If chkWaitingforService.Checked = True Then
                .ProductStatus += strJobStatusValue & "-1,"
            End If


            If chkRepaired.Checked = True Then
                .ProductStatus += strJobStatusValue & "1,"
            End If



            If chkDelivered.Checked = True Then
                .ProductStatus += strJobStatusValue & "0,2,"
            End If


            If chkPending.Checked = True Then
                .ProductStatus += strJobStatusValue & "9,"
            End If


            If chkNR.Checked = True Then
                .ProductStatus += strJobStatusValue & "99,"
            End If


            If chkCR.Checked = True Then
                .ProductStatus += strJobStatusValue & "100,"
            End If



            If chkReplace.Checked = True Then
                .ProductStatus += strJobStatusValue & "101,"
            End If

            If chkReplaceDelivery.Checked = True Then
                .ProductStatus += strJobStatusValue & "102,"
            End If


            If .ProductStatus <> "" Then



                If .ProductStatus.Substring(.ProductStatus.Length - 1) = "," Then
                    .ProductStatus = .ProductStatus.Substring(0, .ProductStatus.Length - 1)
                End If

                .ProductStatus = "Claiminfo.Cflag IN(" & .ProductStatus.ToString & ")"
            End If
        End With

    End Sub


    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()

    End Sub

    Private Sub frmMaster_information_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        strBranchCriteria = String.Empty
        strCategoryCriteria = String.Empty
        strBrandCriteria = String.Empty
        strModelCriteria = String.Empty
        strConcatenateCriteria = String.Empty

        blnBranchFlag = False
        blnCategoryFlag = False
        blnBrandFlag = False
        blnModelFlag = False
    End Sub


    Private Sub CheckedAllStatus(ByVal strReportName As String)
        chkWaitingforService.Checked = True
        chkRepaired.Checked = True
        chkDelivered.Checked = True
        chkPending.Checked = True
        chkNR.Checked = True
        chkCR.Checked = True
        chkReplace.Checked = True
        chkReplaceDelivery.Checked = True
        chkReportSalesWarranty.Checked = True
        chkReportNonWarranty.Checked = True
        chkReportServiceWarranty.Checked = True


        If UCase(strReportName) = UCase("Receive") Or ReportIdentification.ToLower = LCase("Not Assign Job") Or ReportIdentification.ToLower = LCase("Customer Details") Then
            optByReceive.Checked = True
        ElseIf UCase(strReportName) = UCase("Repair") Or UCase(strReportName) = UCase("Pending Repair") Or UCase(strReportName) = UCase("Pending Delivery") Or UCase(strReportName) = UCase("Estimate Refuse") Or UCase(strReportName) = UCase("NRCR") Then
            optByRepaired.Checked = True
        ElseIf UCase(strReportName) = UCase("Delivery") Or UCase(strReportName) = UCase("ReportDiscountDelivered") Then
            optByDelivery.Checked = True
        End If

    End Sub
    Private Sub DateRange()

        With ReportClass

            .DateRange = String.Empty

            If optByReceive.Checked = True Then
                .DateRange = "Claiminfo.ReceptDate Between #" & dtpFrom.Value.ToShortDateString & "# AND #" & dtpTo.Value.ToShortDateString & "#"
            ElseIf optByRepaired.Checked = True Then
                .DateRange = "Claiminfo.Sdate Between #" & dtpFrom.Value.ToShortDateString & "# AND #" & dtpTo.Value.ToShortDateString & "#"
            ElseIf optByDelivery.Checked = True Then
                .DateRange = "Claiminfo.Ddate Between #" & dtpFrom.Value.ToShortDateString & "# AND #" & dtpTo.Value.ToShortDateString & "#"
            ElseIf ReportIdentification = UCase("Technician Performance Details") Or ReportIdentification = UCase("Technician Performance Summery") Or ReportIdentification = UCase("Technician Performance Time Elapsed") Then
                .DateRange = "Claiminfo.IsssueDate Between #" & dtpFrom.Value.ToShortDateString & "# AND #" & dtpTo.Value.ToShortDateString & "#"
            ElseIf ReportIdentification.ToLower = LCase("Under Process") Then
                .DateRange = "Claiminfo.IsssueDate Between #" & dtpFrom.Value.ToShortDateString & "# AND #" & dtpTo.Value.ToShortDateString & "#"
            ElseIf ReportIdentification.ToLower = LCase("Job Transfer") Then
                .DateRange = "TransferJob.TrDate Between #" & dtpFrom.Value.ToShortDateString & "# AND #" & dtpTo.Value.ToShortDateString & "#"
            ElseIf ReportIdentification.ToLower = LCase("Job Storage") Then
                .DateRange = "tbStoregeSET.SendDate Between #" & dtpFrom.Value.ToShortDateString & "# AND #" & dtpTo.Value.ToShortDateString & "#"
            End If


        End With


    End Sub


    Private Sub WarrantyType()

        With ReportClass


            .Wcondition = String.Empty



            If chkReportSalesWarranty.Checked = True Then
                .Wcondition += strWarrantyStatus & "0,"
            End If


            If chkReportNonWarranty.Checked = True Then
                .Wcondition += strWarrantyStatus & "1,"
            End If

            If chkReportServiceWarranty.Checked = True Then
                .Wcondition += strWarrantyStatus & "2,"
            End If


            If Not String.IsNullOrEmpty(Trim(.Wcondition)) Then
                If .Wcondition.Substring(.Wcondition.Length - 1) = "," Then
                    .Wcondition = .Wcondition.Substring(0, .Wcondition.Length - 1)
                End If
                .Wcondition = "Claiminfo.Wcondition IN(" & .Wcondition & ")"
            End If


        End With




    End Sub

    Private Sub DisableAllStatus()
        chkWaitingforService.Checked = False
        chkWaitingforService.Enabled = False

        chkRepaired.Checked = False
        chkRepaired.Enabled = False

        chkDelivered.Checked = False
        chkDelivered.Enabled = False

        chkPending.Checked = False
        chkPending.Enabled = False

        chkEstimateRefuse.Checked = False
        chkEstimateRefuse.Enabled = False

        chkNR.Checked = False
        chkNR.Enabled = False

        chkCR.Checked = False
        chkCR.Enabled = False

        chkReplace.Checked = False
        chkReplace.Enabled = False

        chkReplaceDelivery.Checked = False
        chkReplaceDelivery.Enabled = False

        optByReceive.Enabled = False
        optByRepaired.Enabled = False

        optByDelivery.Enabled = False


    End Sub

    Private Sub EnableAllStatus()
        chkWaitingforService.Enabled = False
        chkRepaired.Enabled = False
        chkDelivered.Enabled = False
        chkPending.Enabled = False
        chkNR.Enabled = False
        chkCR.Enabled = False
        chkReplace.Enabled = False
        chkReplaceDelivery.Enabled = False
    End Sub

    Private Sub frmMaster_information_Click(sender As Object, e As EventArgs) Handles Me.Click

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles grpStatus.Enter

    End Sub

    Private Sub chkReportSalesWarranty_CheckedChanged(sender As Object, e As EventArgs) Handles chkReportSalesWarranty.CheckedChanged

    End Sub

    Private Sub chkReportNonWarranty_CheckedChanged(sender As Object, e As EventArgs) Handles chkReportNonWarranty.CheckedChanged

    End Sub

    Private Sub chkReportServiceWarranty_CheckedChanged(sender As Object, e As EventArgs) Handles chkReportServiceWarranty.CheckedChanged

    End Sub

    Private Sub optByReceive_CheckedChanged(sender As Object, e As EventArgs) Handles optByReceive.CheckedChanged

    End Sub

    Private Sub optByRepaired_CheckedChanged(sender As Object, e As EventArgs) Handles optByRepaired.CheckedChanged

    End Sub

    Private Sub lblLine1_Click(sender As Object, e As EventArgs) Handles lblLine1.Click

    End Sub






    Private Sub lstReportBranch_SizeChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub lstReportCategory_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub lstReportBrand_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub lstReportModel_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub lstReportBranch_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub opGroupSelection_CheckedChanged(sender As Object, e As EventArgs) Handles optGroupSelection.CheckedChanged
        grpSingleSelection.Enabled = False
        grpGroupSelection.Enabled = True

        cmbBranch.Text = ""

        cmbCategory.Text = ""

        cmbBrand.Text = ""
        cmbModel.Text = ""


        lstReportBranch.Items.Clear()
        LoadBranch()
        LoadCategory()

    End Sub

    Private Sub optSingleSelection_CheckedChanged(sender As Object, e As EventArgs) Handles optSingleSelection.CheckedChanged
        grpSingleSelection.Enabled = True
        grpGroupSelection.Enabled = False
        lstReportBranch.Items.Clear()
        lstReportBrand.Items.Clear()
        lstReportCategory.Items.Clear()
        lstReportModel.Items.Clear()

        cmbCategory.Items.Clear()
        cmbBranch.Items.Clear()
        cmbBrand.Items.Clear()
        cmbModel.Items.Clear()

        ' -------------------- Load Branch into cmbBranch Combobox -------------------------------------------
        Dim BranchMethods As clsBranchMethods = New clsBranchMethods

        Dim BranchList As List(Of clsBranch) = BranchMethods.GetBranches.ToList
        If BranchList.Count > 0 Then
            For Each Branch As clsBranch In BranchList
                cmbBranch.Items.Add(Branch.Branch)
            Next
        End If


        ' -------------------- Load Category into cmbCategory Combobox -------------------------------------------
        Dim CategoryMethods As clscTypeMethods = New clscTypeMethods
        Dim CategoryList As List(Of clscType) = CategoryMethods.GetAllCategory.ToList


        If CategoryList.Count > 0 Then
            For Each category As clscType In CategoryList
                cmbCategory.Items.Add(category.CategoryName)
            Next
        End If






    End Sub

    Private Sub chkReportBranch_CheckedChanged(sender As Object, e As EventArgs) Handles chkReportBranch.CheckedChanged
        strTBranch = ""
        If chkReportBranch.Checked = True Then
            lstReportBranch.Enabled = False
            strTBranch = "All"

        Else
            lstReportBranch.Enabled = True
        End If


    End Sub

    Private Sub chkReportCategory_CheckedChanged_1(sender As Object, e As EventArgs) Handles chkReportCategory.CheckedChanged


        If chkReportCategory.Checked = True Then
            lstReportCategory.Enabled = False
            If lstReportCategory.Items.Count > 0 Then
                'For Each item As ListViewItem In lstReportCategory.Items
                '    item.Checked = True
                'Next

                Dim brandMethods As clsBrandMethods = New clsBrandMethods
                Dim Brands As List(Of clsBrand) = brandMethods.GetDistinctBrand("")
                lstReportBrand.Items.Clear()

                If Brands.Count > 0 Then
                    Dim lstItem As ListViewItem = New ListViewItem
                    For Each Brand As clsBrand In Brands
                        lstItem = lstReportBrand.Items.Add(lstReportBrand.Items.Count + 1)
                        lstItem.SubItems.Add(Brand.Brand)
                    Next
                End If
            End If

        Else

            lstReportCategory.Enabled = True
            lstReportBrand.Items.Clear()
            'If lstReportCategory.Items.Count > 0 Then
            '    For Each item As ListViewItem In lstReportCategory.Items
            '        item.Checked = False
            '    Next
            'End If


        End If





        'If chkReportCategory.Checked = True Then
        '    lstReportCategory.Items.Clear()
        '    If String.IsNullOrEmpty(Trim(checkSelectedBranch)) Then
        '        MessageBox.Show("Select Branch")
        '        chkReportCategory.Checked = False
        '        Exit Sub
        '    End If

        '    LoadCategory()
        '    chkReportBranch.Checked = False
        '    chkReportBrand.Checked = False

        'Else
        '    lstReportCategory.Enabled = False
        'End If
    End Sub

    Private Sub chkReportBrand_CheckedChanged_1(sender As Object, e As EventArgs) Handles chkReportBrand.CheckedChanged






        If chkReportBrand.Checked = True Then
            lstReportBrand.Enabled = False
            If lstReportBrand.Items.Count > 0 Then

                'For Each lstItem As ListViewItem In lstReportBrand.Items
                '    lstItem.Checked = True
                'Next


                Dim BrandModelMethod As clsBrandModelMethods = New clsBrandModelMethods
                Dim Models As List(Of clsBrandModel) = BrandModelMethod.GetModelLISTWithBrand("")


                lstReportModel.Items.Clear()

                If Models.Count > 0 Then
                    Dim lstItem As ListViewItem = New ListViewItem

                    For Each model As clsBrandModel In Models
                        lstItem = lstReportModel.Items.Add(lstReportModel.Items.Count + 1)
                        lstItem.SubItems.Add(model.Model)
                    Next

                End If




            End If
        Else
            lstReportBrand.Enabled = True
            lstReportModel.Items.Clear()
            If lstReportBrand.Items.Count > 0 Then
                'For Each item As ListViewItem In lstReportBrand.Items
                '    item.Checked = False
                'Next
            End If
        End If










        'If chkReportBrand.Checked = True Then

        '    lstReportBrand.Items.Clear()
        '    If String.IsNullOrEmpty(Trim(checkSelectedCategory)) Then
        '        MessageBox.Show("Select Category")
        '        chkReportBrand.Checked = False
        '        Exit Sub
        '    End If
        '    lstReportBrand.Items.Clear()

        '    LoadBrand()
        '    chkReportCategory.Checked = False
        '    chkReportModel.Checked = False

        'Else
        '    lstReportBrand.Enabled = False



        'End If
    End Sub

    Private Sub chkReportModel_CheckedChanged_1(sender As Object, e As EventArgs) Handles chkReportModel.CheckedChanged

        If chkReportModel.Checked = True Then
            lstReportModel.Enabled = False
        Else
            lstReportModel.Enabled = True
        End If



    End Sub

    Private Sub SearchBranch_Click(sender As Object, e As EventArgs) Handles SearchBranch.Click

        If Not String.IsNullOrEmpty(Trim(txtSearchBranch.Text)) Then

            If lstReportBranch.Items.Count > 0 Then

                For Each item As ListViewItem In lstReportBranch.Items

                    If item.SubItems(1).Text.ToLower = txtSearchBranch.Text.ToLower Then
                        item.Selected = True
                        item.EnsureVisible()
                        MessageBox.Show("Found The Branch" & vbNewLine & vbNewLine & "SL NO : " & item.Text & vbNewLine & "Branch Name : " & item.SubItems(1).Text)
                        lstReportBranch.Select()
                        Exit For
                    End If
                Next
            Else
                MessageBox.Show("No Branch in List Branch")
            End If
        Else
            MessageBox.Show("Search Filed is Blank")
            txtSearchBranch.Select()
            Exit Sub
        End If
    End Sub

    Private Sub SearchCategory_Click(sender As Object, e As EventArgs) Handles SearchCategory.Click
        If Not String.IsNullOrEmpty(Trim(txtSearchCategory.Text)) Then

            If lstReportCategory.Items.Count > 0 Then

                For Each item As ListViewItem In lstReportCategory.Items

                    If item.SubItems(1).Text.ToLower = txtSearchCategory.Text.ToLower Then
                        item.Selected = True
                        item.EnsureVisible()
                        MessageBox.Show("Found The Category" & vbNewLine & vbNewLine & "SL NO : " & item.Text & vbNewLine & "Category Name : " & item.SubItems(1).Text)
                        lstReportCategory.Select()

                        Exit For
                    End If
                Next
            Else
                MessageBox.Show("No Category in List Branch")
            End If
        Else
            MessageBox.Show("Search Filed is Blank")
            txtSearchCategory.Select()
            Exit Sub
        End If
    End Sub

    Private Sub SearchBrand_Click(sender As Object, e As EventArgs) Handles SearchBrand.Click
        If Not String.IsNullOrEmpty(Trim(txtSearchBrand.Text)) Then

            If lstReportBrand.Items.Count > 0 Then

                For Each item As ListViewItem In lstReportBrand.Items
                    If item.SubItems(1).Text.ToLower = txtSearchBrand.Text.ToLower Then
                        item.Selected = True
                        item.EnsureVisible()
                        MessageBox.Show("Found The Brand" & vbNewLine & vbNewLine & "SL NO : " & item.Text & vbNewLine & "Brand Name : " & item.SubItems(1).Text)
                        lstReportBrand.Select()

                        Exit For
                    End If
                Next
            Else
                MessageBox.Show("No Brand in List Branch")
            End If
        Else
            MessageBox.Show("Search Filed is Blank")
            txtSearchBrand.Select()
            Exit Sub
        End If
    End Sub

    Private Sub SearchModel_Click(sender As Object, e As EventArgs) Handles SearchModel.Click
        If Not String.IsNullOrEmpty(Trim(txtSearchModel.Text)) Then

            If lstReportModel.Items.Count > 0 Then

                For Each item As ListViewItem In lstReportModel.Items

                    If item.SubItems(1).Text.ToLower = txtSearchModel.Text.ToLower Then
                        item.Selected = True
                        item.EnsureVisible()
                        MessageBox.Show("Found The Model" & vbNewLine & vbNewLine & "SL NO : " & item.Text & vbNewLine & "Model Name : " & item.SubItems(1).Text)
                        lstReportModel.Select()
                        Exit For
                    End If
                Next
            Else
                MessageBox.Show("No Model in List Branch")
            End If
        Else
            MessageBox.Show("Search Filed is Blank")
            txtSearchModel.Select()
            Exit Sub
        End If
    End Sub

    Private Sub lstReportCategory_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles lstReportCategory.SelectedIndexChanged



    End Sub

    Private Sub lstReportCategory_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lstReportCategory.ItemCheck

    End Sub

    Private Sub lstReportCategory_ItemChecked(sender As Object, e As ItemCheckedEventArgs) Handles lstReportCategory.ItemChecked

        If lstReportCategory.CheckedItems.Count > 0 Then
            Dim strValue = CheckedCategory()
            Dim strParameter As String = "1=1"

            If Not String.IsNullOrEmpty(strValue.Trim) Then
                strParameter = strParameter & " AND Brand.Ctype IN (" & strValue & ")"
                LoadBrand(strParameter)
            End If


        Else
            lstReportBrand.Items.Clear()
        End If







    End Sub



    Private Function CheckedBrand() As String
        Dim strListBrand As StringBuilder = New StringBuilder
        Dim strSQLParameter As String = String.Empty


        If lstReportBrand.Items.Count > 0 Then
            For Each Item As ListViewItem In lstReportBrand.Items

                If Item.Checked = True Then

                    strListBrand.Append("'" & Item.SubItems(1).Text & "',")
                End If
            Next
            If strListBrand.Length > 0 Then
                strSQLParameter = strListBrand.ToString.Remove(strListBrand.ToString.LastIndexOf(","))
            End If
        End If











        Return strSQLParameter


    End Function

    Private Sub lstReportBrand_ItemChecked(sender As Object, e As ItemCheckedEventArgs) Handles lstReportBrand.ItemChecked
        If lstReportBrand.CheckedItems.Count > 0 Then
            Dim strCategory = CheckedCategory()
            Dim strBrand = CheckedBrand()
            Dim strParametr As String = "1=1"


            If Not String.IsNullOrEmpty(strCategory.Trim) Then
                strParametr = strParametr & " AND Brand.CType in(" & strCategory & ")"
            End If


            If Not String.IsNullOrEmpty(strBrand.Trim) Then
                strParametr = strParametr & " AND Brand.Brand in(" & strBrand & ")"
            End If

            Dim BrandMethods As clsBrandMethods = New clsBrandMethods
            Dim BrandList As List(Of clsBrand) = BrandMethods.GetBrandID(strParametr).ToList()

            Dim ListBrandID As StringBuilder = New StringBuilder
            Dim strListBrandID As String = String.Empty

            If BrandList.Count > 0 Then
                For Each Brand As clsBrand In BrandList
                    ListBrandID.Append(Brand.BrdID & ",")
                Next

                strListBrandID = ListBrandID.ToString.Remove(ListBrandID.ToString.LastIndexOf(","))

                LoadModel(strListBrandID)

            End If



        Else
            lstReportModel.Items.Clear()

        End If
    End Sub



    Private Sub LoadModel(ByVal BrandId As String)

        Dim BrandModelMethods As clsBrandModelMethods = New clsBrandModelMethods

        Dim ListModel As List(Of clsBrandModel) = BrandModelMethods.GetModelListWithBrand(BrandId).ToList

        lstReportModel.Items.Clear()

        If ListModel.Count > 0 Then
            Dim lstItem As ListViewItem = New ListViewItem

            For Each Model As clsBrandModel In ListModel
                lstItem = lstReportModel.Items.Add(lstReportModel.Items.Count + 1)
                lstItem.SubItems.Add(Model.Model)

            Next


        End If





    End Sub
    Private Sub lstReportBrand_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles lstReportBrand.SelectedIndexChanged

    End Sub

    Private Sub lstReportBrand_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lstReportBrand.ItemCheck

    End Sub

    Private Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged
        Dim BrandMethods As clsBrandMethods = New clsBrandMethods

        Dim dt As DataTable = BrandMethods.GetTableFilter(cmbCategory.Text)

        cmbBrand.Items.Clear()

        If dt.Rows.Count > 0 Then

            For Each datarow As DataRow In dt.Rows

                cmbBrand.Items.Add(datarow("Brand"))

            Next

        End If





    End Sub

    Private Sub cmbBranch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBranch.SelectedIndexChanged

    End Sub

    Private Sub cmbBrand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBrand.SelectedIndexChanged
        Dim ModelMethods As clsBrandModelMethods = New clsBrandModelMethods
        Dim bm As clsBrandMethods = New clsBrandMethods
        Dim Brand As clsBrand = bm.GetAllBrands.Single(Function(x) x.Brand.ToLower() = cmbBrand.Text.ToLower() And x.CategoryName.ToLower = cmbCategory.Text.ToLower())



        Dim dt As DataTable = ModelMethods.GetTableFilter(Brand.BrdID)

        cmbModel.DataSource = Nothing
        cmbModel.Items.Clear()

        If dt.Rows.Count > 0 Then

            For Each datarow As DataRow In dt.Rows

                cmbModel.Items.Add(datarow("Model"))

            Next


        End If


    End Sub

    Private Sub txtSearchModel_TextChanged(sender As Object, e As EventArgs) Handles txtSearchModel.TextChanged

    End Sub

    Private Sub txtSearchModel_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSearchModel.KeyUp

    End Sub
End Class

