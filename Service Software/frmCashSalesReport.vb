Imports System.Linq


Public Class frmCashSalesReport


    Dim tmpCashsales As frmReportShow = New frmReportShow

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Me.Close()

    End Sub



    Private Sub frmCashSalesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            DefaultBranch()
            dtpFrom.Value = Now
            dtpTo.Value = Now
            CenterForm(Me)
            loadBranch()
            loadCategory()

            If ReportIdentification.ToUpper = UCase("CashSalesDetails") Or ReportIdentification.ToUpper = UCase("CashSalesSummery") Then
                CheckboxDisable()
            Else
                CheckboxEnable()
                chkNonWarranty.Checked = True
            End If
            If ReportIdentification.ToUpper = UCase("PresentStockALL") Then
                CheckboxDisable()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub DefaultBranch()
        Try
            cmbBranch.Text = My.Computer.Registry.CurrentUser.OpenSubKey("Software\Company Software\Service").GetValue("Default_Branch")
        Catch ex As Exception

        End Try
    End Sub



    Private Sub loadBranch()
        Dim brMethods As clsBranchMethods = New clsBranchMethods
        Dim listofBranch As List(Of clsBranch) = brMethods.GetBranches.ToList


        If listofBranch.Count > 0 Then

            If cmbBranch.Items.Count > 0 Then
                cmbBranch.Items.Clear()
            End If

            For Each branch As clsBranch In listofBranch
                cmbBranch.Items.Add(branch.Branch)
            Next

        End If

    End Sub


    Private Sub loadCategory()
        Dim categoryMethods As clscTypeMethods = New clscTypeMethods
        Dim categoryList As List(Of clscType) = categoryMethods.GetAllCategory.ToList

        If categoryList.Count > 0 Then

            If cmbCategory.Items.Count > 0 Then
                cmbCategory.Items.Clear()

            End If

            For Each category As clscType In categoryList
                cmbCategory.Items.Add(category.CategoryName)
            Next
        End If


    End Sub

    Private Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged
        LoadBrand(cmbCategory.Text)
    End Sub



    Private Sub LoadBrand(ByVal Criteria As String)

        Dim brandmethods As clsBrandMethods = New clsBrandMethods
        Dim dt As DataTable = brandmethods.GetTableFilter(Criteria)




        If dt.Rows.Count > 0 Then






            cmbBrand.DisplayMember = "Brand"
            cmbBrand.ValueMember = "brdid"
            cmbBrand.DataSource = dt





        End If



    End Sub

    Private Sub cmbBrand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBrand.SelectedIndexChanged
        loadModel(cmbBrand.SelectedValue)
    End Sub


    Private Sub loadModel(ByVal Criteria As String)
        Dim brandModelMethods As clsBrandModelMethods = New clsBrandModelMethods
        Dim dt As DataTable = brandModelMethods.GetTableFilter(Criteria)


        If dt.Rows.Count > 0 Then



            cmbModel.DisplayMember = "Model"
            cmbModel.ValueMember = "Model"
            cmbModel.DataSource = dt




        End If





    End Sub

    Private Sub btnReportShow_Click(sender As Object, e As EventArgs)

    End Sub



    Private Function verifyCheckboxChecked() As Boolean
        If ReportIdentification.ToUpper = UCase("PresentStockALL") Then

            Return True

        End If

        If chkSalesWarranty.Checked = True Then
            Return True
        End If

        If chkNonWarranty.Checked = True Then
            Return True
        End If
        If chkSvcWarranty.Checked = True Then
            Return True
        End If
        Return False

    End Function

    Private Function GetParameter() As String
        Dim strParameter As String = String.Empty

        tmpCashsales.transClaiminfo.Branch = ""
        tmpCashsales.transClaiminfo.ServiceType = ""
        tmpCashsales.transClaiminfo.Brand = ""
        tmpCashsales.transClaiminfo.ModelNo = ""

        tmpCashsales.strBranchName = ""
        tmpCashsales.strCategory = ""
        tmpCashsales.strBrandName = ""

        tmpCashsales.strModel = ""


        'With tmpCashsales.CashSales

        If (ReportIdentification.ToUpper = UCase("CashSalesDetails") Or ReportIdentification.ToUpper = UCase("CashSalesSummery")) Then

            If Not String.IsNullOrEmpty(Trim(cmbBranch.Text)) Then

                strParameter += "Cashsales.Branch='" & cmbBranch.Text & "' AND "
                tmpCashsales.strBranchName = cmbBranch.Text
            End If

            If Not String.IsNullOrEmpty(Trim(cmbCategory.Text)) Then

                strParameter += "Cashsales.Category='" & cmbBranch.Text & "' AND "
                tmpCashsales.strCategory = cmbCategory.Text
            End If


            If Not String.IsNullOrEmpty(Trim(cmbBrand.Text)) Then

                strParameter += "Cashsales.Brand='" & cmbBrand.Text & "' AND "
                tmpCashsales.strBrandName = cmbBrand.Text
            End If


            If Not String.IsNullOrEmpty(Trim(cmbModel.Text)) Then

                strParameter += "Cashsales.ModelNo='" & cmbModel.Text & "' AND "
                tmpCashsales.strModel = cmbModel.Text
            End If


            If strParameter.Length > 0 Then

                If strParameter.Substring(strParameter.Length - 4).ToLower = LCase("AND ") Then
                    strParameter = strParameter.Substring(0, strParameter.Length - 4)
                End If
            End If

        Else


            If Not String.IsNullOrEmpty(Trim(cmbBranch.Text)) Then

                strParameter += "CLaiminfo.Branch='" & cmbBranch.Text & "' AND "
                tmpCashsales.transClaiminfo.Branch = cmbBranch.Text

            End If

            If Not String.IsNullOrEmpty(Trim(cmbCategory.Text)) Then

                strParameter += "CLaiminfo.ServiceType='" & cmbCategory.Text & "' AND "
                tmpCashsales.transClaiminfo.ServiceType = cmbCategory.Text
            End If


            If Not String.IsNullOrEmpty(Trim(cmbBrand.Text)) Then

                strParameter += "CLaiminfo.Brand='" & cmbBrand.Text & "' AND "
                tmpCashsales.transClaiminfo.Brand = cmbBrand.Text
            End If


            If Not String.IsNullOrEmpty(Trim(cmbModel.Text)) Then

                strParameter += "CLaiminfo.ModelNo='" & cmbModel.Text & "' AND "
                tmpCashsales.transClaiminfo.ModelNo = cmbModel.Text
            End If


            strParameter = strParameter & CheckWarrantiCondition()

            If Not String.IsNullOrEmpty(Trim(strParameter)) Then
                If strParameter.Length > 4 Then


                    If strParameter.Substring(strParameter.Length - 4).ToLower = LCase("AND ") Then
                        strParameter = strParameter.Substring(0, strParameter.Length - 4)
                    End If
                End If

            End If
        End If









        tmpCashsales.strSQLCriteria = strParameter
        tmpCashsales.strWarrantyType = CheckWarrantiCondition()

        If dtpFrom.Visible = True Then
            tmpCashsales.dtStartDate = dtpFrom.Value.ToShortDateString
        Else
            tmpCashsales.dtStartDate = "01-01-6000"
        End If
        If dtpTo.Visible = True Then
            tmpCashsales.dtEndDate = dtpTo.Value.ToShortDateString
        Else
            tmpCashsales.dtEndDate = "01-01-6000"
        End If





        Return strParameter


    End Function



    Private Sub CheckboxDisable()
        chkSalesWarranty.Checked = False
        chkSalesWarranty.Enabled = False
        chkNonWarranty.Checked = False
        chkNonWarranty.Enabled = False
        chkSvcWarranty.Checked = False
        chkSvcWarranty.Enabled = False
    End Sub




    Private Sub CheckboxEnable()
        chkSalesWarranty.Checked = False
        chkSalesWarranty.Enabled = True
        chkNonWarranty.Checked = False
        chkNonWarranty.Enabled = True
        chkSvcWarranty.Checked = False
        chkSvcWarranty.Enabled = True
    End Sub


    Private Function CheckWarrantiCondition() As String
        Dim strCondition As String = ""

        If chkSalesWarranty.Checked = True Then

            strCondition = "0,"

        End If

        If chkNonWarranty.Checked = True Then
            strCondition = strCondition + "1,"
        End If
        If chkSvcWarranty.Checked = True Then
            strCondition = strCondition + "2,"
        End If


        If Not String.IsNullOrEmpty(strCondition) Then
            If strCondition.Substring(strCondition.Length - 1) = "," Then
                strCondition = strCondition.Substring(0, strCondition.Length - 1)
                strCondition = "Claiminfo.Wcondition In(" & strCondition & ")"
            End If
        End If

        If String.IsNullOrEmpty(strCondition) Then
            strCondition = "1=1"
        End If



        Return strCondition



    End Function

    Private Sub btnReportShow_Click_1(sender As Object, e As EventArgs) Handles btnReportShow.Click
        Try
            If dtpFrom.Visible = True Then


                If Date.Compare(dtpTo.Value.ToShortDateString, dtpFrom.Value.ToShortDateString) = -1 Then
                    MessageBox.Show("'Startind Date' greater than 'Ending Date'" & vbNewLine & "Select Valid Date", "Invalid Date Time")
                    dtpFrom.Select()
                    Exit Sub
                End If
            End If



            If verifyCheckboxChecked() = False Then
                If Not (ReportIdentification.ToUpper = UCase("CashSalesDetails") Or ReportIdentification.ToUpper = UCase("CashSalesSummery")) Then
                    MessageBox.Show("No Warranty Type is selected")
                    Exit Sub
                End If

            End If

            GetParameter()
            tmpCashsales.ShowDialog()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnClose_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub lblHeader_Click(sender As Object, e As EventArgs) Handles lblHeader.Click

    End Sub
End Class