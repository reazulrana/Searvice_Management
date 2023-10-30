Imports System.Data.OleDb



Public Class frmUpdate_Delete
    Private strModelArray() As String
    Private intGetbrandID As Integer = 0



    Private Sub chkSelectAll_CheckedChanged(sender As Object, e As EventArgs) Handles chkSelectAll.CheckedChanged
        If chkSelectAll.Checked = True Then
            KeepModelList()
            SelectAll()
        Else
            Unselect()
            LoadArray()

        End If

    End Sub



    Private Sub KeepModelList()
        Dim intLoop As Integer = 0
        Dim lstTempModel As ListViewItem = Nothing
        Dim intCountArray As Integer = 0
        Dim intTotalModelSelect As Integer = 0

        intTotalModelSelect = TotalModelSelected()
        If intTotalModelSelect <> 0 Then
            ReDim strModelArray(intTotalModelSelect)
            For intLoop = 0 To lstModelDetails.Items.Count - 1
                lstTempModel = lstModelDetails.Items(intLoop)

                If lstTempModel.Checked = True Then
                    strModelArray(intCountArray) = lstTempModel.SubItems(1).Text
                    intCountArray = intCountArray + 1
                End If
            Next
        End If

    End Sub

    Private Sub LoadArray()

        Dim intLoop As Integer
        Dim intLoop1 As Integer
        'Dim lsttmpModel As ListViewItem = Nothing
        If Not IsNothing(strModelArray) Then
            For intLoop = 0 To UBound(strModelArray)
                For intLoop1 = 0 To lstModelDetails.Items.Count - 1
                    If strModelArray(intLoop) = lstModelDetails.Items(intLoop1).SubItems(1).Text Then
                        lstModelDetails.Items(intLoop1).Checked = True
                        Exit For
                    End If

                Next
                intLoop1 = 0
            Next
        End If
    End Sub

    Private Sub SelectAll()

        Dim intLoop As Integer = 0
        Dim lstSelectAllItem As ListViewItem = Nothing

        For intLoop = 0 To lstModelDetails.Items.Count - 1
            lstSelectAllItem = lstModelDetails.Items(intLoop)
            lstSelectAllItem.Checked = True
        Next



    End Sub

    Private Sub Unselect()

        Dim intLoop As Integer = 0
        Dim lstUnselectAllItem As ListViewItem = Nothing

        For intLoop = 0 To lstModelDetails.Items.Count - 1
            lstUnselectAllItem = lstModelDetails.Items(intLoop)
            lstUnselectAllItem.Checked = False
        Next



    End Sub

    Private Sub frmUpdate_Delete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        CenterForm(Me)


        loadCategory(cmbCategory)
        cmbField.Items.Add("Charge")
        cmbField.Items.Add("Warranty Period")
        cmbField.Items.Add("Item")
        cmbField.Items.Add("Slno")
        cmbField.Items.Add("Size")

        cmbField.Items.Add("Remarks")
        optAll.Checked = True
        optQuickDelete.Checked = True



    End Sub


    Private Sub loadCategory(ByVal TempObject As ComboBox)
        Dim ConCategory As New OleDb.OleDbConnection(strProvider)
        Dim dcCategory As New OleDbCommand("Select Ctype.cType from Ctype", ConCategory)

        Dim drCategory As OleDbDataReader = Nothing

        Try

            TempObject.Items.Clear()
            ConCategory.Open()
            drCategory = dcCategory.ExecuteReader


            If drCategory.HasRows = True Then
                While drCategory.Read
                    TempObject.Items.Add(drCategory("Ctype").ToString)
                End While
            End If






        Catch LoadCategoryEx As Exception
            MessageBox.Show(LoadCategoryEx.Message)

        End Try



        TempCommandDispose(dcCategory) : TempConnectionDispose(ConCategory)






    End Sub





    Private Sub loadBrand(ByVal strTempCategory As String, ByVal TempBrandObject As ComboBox)
        Dim ConBrand As New OleDb.OleDbConnection(strProvider)
        Dim dcBrand As New OleDbCommand("Select distinct brand.brdid, Brand.Brand from Brand where Brand.Ctype='" & strTempCategory & "'", ConBrand)

        Dim drBrand As OleDbDataReader = Nothing
        TempBrandObject.Items.Clear()

        Try


            ConBrand.Open()
            drBrand = dcBrand.ExecuteReader


            If drBrand.HasRows = True Then

                While drBrand.Read
                    TempBrandObject.Items.Add(drBrand("Brand").ToString)

                End While
            End If






        Catch LoadCategoryEx As Exception
            MessageBox.Show(LoadCategoryEx.Message)

        End Try


        TempConnectionDispose(ConBrand)






    End Sub

    Private Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged
        If RecordVerification(strProvider, "Brand", "Brand.ctype='" & cmbCategory.Text & "'") = True Then
            cmbBrand.Text = ""
            lstModelDetails.Items.Clear()
            loadBrand(cmbCategory.Text, cmbBrand)

        Else

            lblNotification.Text = "'No Brand' found for this Category"
        End If


    End Sub

    Private Sub cmbBrand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBrand.SelectedIndexChanged




        LoadModelList(cmbCategory.Text, cmbBrand.Text)








        'If RecordVerification(strProvider, "Brand", "Brand.ctype='" & cmbCategory.Text & "' and Brand.Brand='" & cmbBrand.Text & "'") = True Then
        '    Dim cnGetBrandId As New OleDbConnection(strProvider)
        '    Dim dcGetBrandId As New OleDbCommand("Select Brand.brdid from Brand where Brand.ctype='" & cmbCategory.Text & "' and Brand.Brand='" & cmbBrand.Text & "'", cnGetBrandId)


        '    Dim drGetBrandId As OleDbDataReader = Nothing
        '    cnGetBrandId.Open()
        '    drGetBrandId = dcGetBrandId.ExecuteReader

        '    If drGetBrandId.HasRows = True Then
        '        While drGetBrandId.Read
        '            If RecordVerification(strProvider, "BrandModel", "BrandModel.brdid=" & Convert.ToInt32(drGetBrandId("brdid").ToString)) = True Then
        '                intGetbrandID = Convert.ToInt32(drGetBrandId("brdid").ToString)
        '                LoadModel(intGetbrandID, lstModelDetails)
        '            Else
        '                lblNotification.Text = "'No Model' found for this Brand"
        '            End If
        '        End While
        '    End If
        '    TempConnectionDispose(cnGetBrandId)

        'End If





    End Sub




    Private Sub LoadModel(ByVal intBrandID As Integer, ByVal TempListView As ListView)

        Dim cnModel As New OleDbConnection(strProvider)
        Dim strSQLModelLoad As String = String.Empty


        If optAll.Checked = True Then
            strSQLModelLoad = "Select BrandModel.Model,BrandModel.Charge,BrandModel.WPeriod,BrandModel.Item,BrandModel.SLNO,BrandModel.[Size],BrandModel.Remarks from BrandModel where BrandModel.brdid=" & intBrandID
        Else
            strSQLModelLoad = "Select BrandModel.Model,BrandModel.Charge,BrandModel.WPeriod,BrandModel.Item,BrandModel.SLNO,BrandModel.[Size],BrandModel.Remarks from BrandModel where Brandmodel.Charge=0 and BrandModel.brdid=" & intBrandID
        End If

        Dim dcModel As New OleDbCommand(strSQLModelLoad, cnModel)

        Dim lstTempModelLoad As ListViewItem = Nothing

        Dim drModel As OleDbDataReader = Nothing




        Try
            cnModel.Open()
            drModel = dcModel.ExecuteReader
            TempListView.Items.Clear()

            If drModel.HasRows = True Then
                While drModel.Read

                    lstTempModelLoad = TempListView.Items.Add(TempListView.Items.Count + 1)
                    If String.IsNullOrEmpty(drModel("Model").ToString) Then
                        lstTempModelLoad.SubItems.Add("")
                    Else

                        lstTempModelLoad.SubItems.Add(drModel("Model").ToString)
                    End If

                    If String.IsNullOrEmpty(drModel("Charge").ToString) Then
                        lstTempModelLoad.SubItems.Add("")
                    Else
                        lstTempModelLoad.SubItems.Add(drModel("Charge").ToString)
                    End If

                    If String.IsNullOrEmpty(drModel("Wperiod").ToString) Then
                        lstTempModelLoad.SubItems.Add("")
                    Else
                        lstTempModelLoad.SubItems.Add(drModel("Wperiod").ToString)
                    End If


                    If String.IsNullOrEmpty(drModel("Item").ToString) Then
                        lstTempModelLoad.SubItems.Add("")
                    Else

                        lstTempModelLoad.SubItems.Add(drModel("Item").ToString)
                    End If

                    If String.IsNullOrEmpty(drModel("SLNo").ToString) Then
                        lstTempModelLoad.SubItems.Add("")
                    Else

                        lstTempModelLoad.SubItems.Add(drModel("SLNo").ToString)
                    End If
                    If String.IsNullOrEmpty(drModel("Size").ToString) Then
                        lstTempModelLoad.SubItems.Add("")
                    Else
                        lstTempModelLoad.SubItems.Add(drModel("Size").ToString)
                    End If


                    If String.IsNullOrEmpty(drModel("Remarks").ToString) Then
                        lstTempModelLoad.SubItems.Add("")
                    Else
                        lstTempModelLoad.SubItems.Add(drModel("Remarks").ToString)
                    End If

                End While



            End If


        Catch LoadModelex As Exception
            MessageBox.Show(LoadModelex.Message)

        End Try


        TempConnectionDispose(cnModel)

    End Sub


    Private Function TotalModelSelected() As Integer
        Dim intloop As Integer = 0
        Dim intTempModelCount As Integer = 0


        For intloop = 0 To lstModelDetails.Items.Count - 1
            If lstModelDetails.Items(intloop).Checked = True Then
                intTempModelCount = intTempModelCount + 1
            End If
        Next

        Return intTempModelCount


    End Function

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Dispose()


    End Sub

    Private Sub frmUpdate_Delete_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Dispose(intGetbrandID)

        If Not IsNothing(strModelArray) Then
            Dim intLoop As Integer = 0

            For intLoop = 0 To UBound(strModelArray)
                strModelArray(intLoop) = String.Empty


            Next

        End If







    End Sub

    Private Sub frmUpdate_Delete_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If tbPriceUpdate.SelectedTab.TabIndex = 0 Then



            tbPriceUpdate.Left = 5
            tbPriceUpdate.Top = 5

            tbPriceUpdate.Width = Me.ClientSize.Width - 5
            tbPriceUpdate.Height = Me.ClientSize.Height - 5
            grpBrand.Left = 5
            grpBrand.Top = 5
            grpModel.Left = grpBrand.Left
            grpModel.Top = grpBrand.Top + grpBrand.Height + 5



            lstModelDetails.Left = 10
            grpModel.Width = tbPriceUpdate.Width - 12

            lstModelDetails.Width = grpModel.Width - 17
            lstModelDetails.Columns(0).Width = lstModelDetails.Columns(0).Width * 1.1
            lstModelDetails.Columns(1).Width = lstModelDetails.Columns(1).Width * 1.1
            lstModelDetails.Columns(2).Width = lstModelDetails.Columns(2).Width * 1.25
            lstModelDetails.Columns(3).Width = lstModelDetails.Columns(3).Width * 1
            lstModelDetails.Columns(4).Width = lstModelDetails.Columns(4).Width * 1
            lstModelDetails.Columns(5).Width = lstModelDetails.Columns(5).Width * 1.25
            lstModelDetails.Columns(6).Width = lstModelDetails.Columns(6).Width * 1
            lstModelDetails.Columns(7).Width = lstModelDetails.Columns(7).Width * 1.4


            cmdUpdate.Top = tbPriceUpdate.Height - (cmdUpdate.Height + 25)
            cmdClose.Top = cmdUpdate.Top
            cmdClose.Width = grpModel.Width / 4
            cmdClose.Left = (grpModel.Left + grpModel.Width) - cmdClose.Width
            cmdUpdate.Width = cmdClose.Width
            cmdUpdate.Left = cmdClose.Left - cmdClose.Width


            grpModel.Top = grpBrand.Top + grpBrand.Height + 5

            grpModel.Height = tbPriceUpdate.Height - (grpModel.Top + cmdUpdate.Height + 30)
            lstModelDetails.Top = chkSelectAll.Top + chkSelectAll.Height + 2
            lstModelDetails.Height = grpModel.Height - (chkSelectAll.Top + chkSelectAll.Height + 5)

        Else

            tbPriceUpdate.Top = 5
            tbPriceUpdate.Left = 5
            tbPriceUpdate.Width = Me.ClientSize.Width - 5

            optQuickDelete.Left = 10
            optQuickDelete.Top = 10
            optCustomDelete.Top = 10
            optCustomDelete.Left = optQuickDelete.Left + optQuickDelete.Width + 10
            chkDeleteBrand.Top = optCustomDelete.Top

            lblLine1.Left = -5
            lblLine1.Width = tbPriceUpdate.Width + Math.Abs(lblLine1.Left)


            cmdLoadModel.Top = chkDeleteBrand.Top
            cmdLoadModel.Left = chkDeleteBrand.Left + chkDeleteBrand.Width + 10
            cmdLoadModel.Width = (tbPriceUpdate.Width - (chkDeleteBrand.Left + chkDeleteBrand.Width + 19)) / 4

            cmdDelete.Left = cmdLoadModel.Left + cmdLoadModel.Width
            cmdDelete.Top = cmdLoadModel.Top
            cmdDelete.Width = cmdLoadModel.Width


            cmdDeleteClear.Left = cmdDelete.Left + cmdDelete.Width
            cmdDeleteClear.Top = cmdDelete.Top
            cmdDeleteClear.Width = cmdDelete.Width
            cmdDeleteClose.Left = cmdDeleteClear.Left + cmdDeleteClear.Width
            cmdDeleteClose.Top = cmdDeleteClear.Top
            cmdDeleteClose.Width = cmdDeleteClear.Width


            grpcustomDelete.Left = tbPriceUpdate.Left + 2


            lstDeleteModel.Left = grpcustomDelete.Left + 2
            grpcustomDelete.Width = tbPriceUpdate.Width - (tbPriceUpdate.Left + grpcustomDelete.Left + 5)

            lstDeleteModel.Width = grpcustomDelete.Width - 17
            lstDeleteModel.Columns(0).Width = lstModelDetails.Columns(0).Width * 1.1
            lstDeleteModel.Columns(1).Width = lstModelDetails.Columns(1).Width * 1.1
            lstDeleteModel.Columns(2).Width = lstModelDetails.Columns(2).Width * 1.25
            lstDeleteModel.Columns(3).Width = lstModelDetails.Columns(3).Width * 1
            lstDeleteModel.Columns(4).Width = lstModelDetails.Columns(4).Width * 1
            lstDeleteModel.Columns(5).Width = lstModelDetails.Columns(5).Width * 1.25
            lstDeleteModel.Columns(6).Width = lstModelDetails.Columns(6).Width * 1
            lstDeleteModel.Columns(7).Width = lstModelDetails.Columns(7).Width * 1.4




            grpcustomDelete.Top = cmbDeleteCategory.Top + cmbDeleteCategory.Height + 1

            grpcustomDelete.Height = tbPriceUpdate.Height - (tbPriceUpdate.Top + grpcustomDelete.Top + 30)


            lstDeleteModel.Top = 12
            lstDeleteModel.Height = grpcustomDelete.Height - 20


        End If


    End Sub



    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        If cmbField.Text = "" Then
            MsgBox("Field not set")
            cmbField.Select()
            Exit Sub

        ElseIf txtSetValue.Text = "" Then
            MsgBox("Field not set")
            txtSetValue.Select()
            Exit Sub
        End If


        Dim lstUpdateModel As ListViewItem = Nothing

        Dim intLoop As Integer = 0

        For intLoop = 0 To lstModelDetails.Items.Count - 1

            lstUpdateModel = lstModelDetails.Items(intLoop)
            If lstUpdateModel.Checked = True Then


                If cmbField.Text = "Charge" Then

                    UpdateRecords("Charge", Convert.ToInt32(txtSetValue.Text), "BrandModel", "BrandModel.Model='" & lstUpdateModel.SubItems(1).Text & "' and BrandModel.brdid=" & intGetbrandID)


                ElseIf cmbField.Text = "Warranty Period" Then
                    UpdateRecords("WPeriod", Convert.ToInt32(txtSetValue.Text), "BrandModel", "BrandModel.Model='" & lstUpdateModel.SubItems(1).Text & "' and BrandModel.brdid=" & intGetbrandID)

                ElseIf cmbField.Text = "Item" Then
                    UpdateRecords("Item", "'" & txtSetValue.Text & "'", "BrandModel", "BrandModel.Model='" & lstUpdateModel.SubItems(1).Text & "' and BrandModel.brdid=" & intGetbrandID)
                ElseIf cmbField.Text = "Slno" Then
                    UpdateRecords("SLNO", Convert.ToInt32(txtSetValue.Text), "BrandModel", "BrandModel.Model='" & lstUpdateModel.SubItems(1).Text & "' and BrandModel.brdid=" & intGetbrandID)

                ElseIf cmbField.Text = "Size" Then
                    UpdateRecords("Size", Convert.ToInt32(txtSetValue.Text), "BrandModel", "BrandModel.Model='" & lstUpdateModel.SubItems(1).Text & "' and BrandModel.brdid=" & intGetbrandID)


                ElseIf cmbField.Text = "Remarks" Then
                    UpdateRecords("Remarks", "'" & txtSetValue.Text & "'", "BrandModel", "BrandModel.Model='" & lstUpdateModel.SubItems(1).Text & "' and BrandModel.brdid=" & intGetbrandID)
                End If
            End If

        Next

        MessageBox.Show("Update Successfully")


        KeepModelList()
        cmbBrand_SelectedIndexChanged(sender, e)
        LoadArray()



    End Sub

    Private Sub cmbField_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbField.KeyPress
        If e.KeyChar = Chr(Keys.Back) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub optAll_CheckedChanged(sender As Object, e As EventArgs) Handles optAll.CheckedChanged

        If cmbCategory.Text = String.Empty Or cmbBrand.Text = String.Empty Then
            Exit Sub

        End If
        cmbBrand_SelectedIndexChanged(sender, e)

    End Sub

    Private Sub optWithoutCharge_CheckedChanged(sender As Object, e As EventArgs) Handles optWithoutCharge.CheckedChanged
        If cmbCategory.Text = String.Empty Or cmbBrand.Text = String.Empty Then
            Exit Sub

        End If
        cmbBrand_SelectedIndexChanged(sender, e)
    End Sub


    Private Sub optQuickDelete_CheckedChanged(sender As Object, e As EventArgs) Handles optQuickDelete.CheckedChanged
        lstDeleteModel.Items.Clear()
        grpcustomDelete.Enabled = False
        grpcustomDelete.Visible = False
        cmdLoadModel.Enabled = False


    End Sub





    Private Sub tbPriceUpdate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tbPriceUpdate.SelectedIndexChanged
        If tbPriceUpdate.SelectedTab.TabIndex = 1 Then
            intGetbrandID = 0
            TempListViewResized(lstDeleteModel)
            frmUpdate_Delete_Resize(sender, e)
            loadCategory(cmbDeleteCategory)
            chkDeleteBrand.Checked = False
        ElseIf tbPriceUpdate.SelectedTab.TabIndex = 0 Then
            intGetbrandID = 0
            TempListViewResized(lstModelDetails)
            frmUpdate_Delete_Resize(sender, e)
            loadCategory(cmbCategory)

        End If

    End Sub




    '    Private Sub cmdInsert_Click(sender As Object, e As EventArgs) Handles cmdInsert.Click
    '        Dim strProviderModel As String = String.Empty


    '        strProvider = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\dbTest\db1.mdb"
    '        Dim strSQLInsert As String = String.Empty

    '        'Insert New Model

    '        strSQLInsert = "INSERT INTO Brandmodel ( Model, brdid, Charge, Wperiod, Item, SlNo, EntryDate )
    'SELECT BrandModel1.Model, BrandModel1.brdid, BrandModel1.Charge, BrandModel1.Wperiod,BrandModel1.Item, BrandModel1.SLNO,  BrandModel1.EntryDate
    'FROM BrandModel1 LEFT JOIN BrandModel ON (BrandModel1.brdid=BrandModel.brdid) AND (BrandModel1.Model=BrandModel.Model)
    'WHERE isnull(BrandModel.Model)"

    '        Dim ConModel As New OleDbConnection(strProvider)

    '        Dim dcInsertModel As New OleDbCommand(strSQLInsert, ConModel)
    '        ConModel.Open()
    '        dcInsertModel.ExecuteNonQuery()
    '        ConModel.Close()
    '        MessageBox.Show("Insert Successfully")


    '        TempCommandDispose(dcInsertModel)
    '        TempConnectionDispose(ConModel)


    '    End Sub




    Private Sub LoadModelList(ByVal strTempCategoryName As String, ByVal strTempBrandName As String)

        If tbPriceUpdate.SelectedTab.TabIndex = 0 Then
            lstModelDetails.Items.Clear()
        Else
            lstDeleteModel.Items.Clear()

        End If

        If RecordVerification(strProvider, "Brand", "Brand.ctype='" & strTempCategoryName & "' and Brand.Brand='" & strTempBrandName & "'") = True Then
            Dim cnGetBrandId As New OleDbConnection(strProvider)
            Dim dcGetBrandId As New OleDbCommand("Select Brand.brdid from Brand where Brand.ctype='" & strTempCategoryName & "' and Brand.Brand='" & strTempBrandName & "'", cnGetBrandId)


            Dim drGetBrandId As OleDbDataReader = Nothing
            cnGetBrandId.Open()
            drGetBrandId = dcGetBrandId.ExecuteReader

            If drGetBrandId.HasRows = True Then
                While drGetBrandId.Read
                    If RecordVerification(strProvider, "BrandModel", "BrandModel.brdid=" & Convert.ToInt32(drGetBrandId("brdid").ToString)) = True Then
                        intGetbrandID = Convert.ToInt32(drGetBrandId("brdid").ToString)
                        If tbPriceUpdate.SelectedTab.TabIndex = 0 Then
                            LoadModel(intGetbrandID, lstModelDetails)
                        Else
                            LoadModel(intGetbrandID, lstDeleteModel)
                        End If

                    Else
                        lblNotification.Text = "'No Model' found for this Brand"
                    End If
                End While
            End If
            TempConnectionDispose(cnGetBrandId)

        End If
    End Sub


    Private Sub optCustomDelete_CheckedChanged(sender As Object, e As EventArgs) Handles optCustomDelete.CheckedChanged
        grpcustomDelete.Visible = True
        grpcustomDelete.Enabled = True
        cmdLoadModel.Enabled = True



    End Sub




    Private Sub TempListViewResized(ByVal TempResizeListView As ListView)


        TempResizeListView.Columns(0).Width = 60
        TempResizeListView.Columns(1).Width = 130
        TempResizeListView.Columns(2).Width = 80
        TempResizeListView.Columns(3).Width = 60
        TempResizeListView.Columns(4).Width = 80
        TempResizeListView.Columns(5).Width = 60
        TempResizeListView.Columns(6).Width = 50
        TempResizeListView.Columns(7).Width = 200

    End Sub


    Private Sub chkDeleteBrand_CheckedChanged(sender As Object, e As EventArgs) Handles chkDeleteBrand.CheckedChanged
        If chkDeleteBrand.Checked = True Then
            chkDeleteBrand.Text = "Delete Permission On"
            chkDeleteBrand.ForeColor = Color.Red
        Else
            chkDeleteBrand.Text = "Delete Permission OFF"
            chkDeleteBrand.ForeColor = Color.DarkBlue
        End If
    End Sub

    Private Sub cmbDeleteCategory_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbDeleteCategory.SelectedIndexChanged
        If cmbDeleteCategory.Text <> String.Empty Then
            loadBrand(cmbDeleteCategory.Text, cmbDeleteBrand)
        Else
            lblDeleteRemarks.Text = "Select Category"

        End If

    End Sub

    Private Sub cmbDeleteBrand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDeleteBrand.SelectedIndexChanged

        If optCustomDelete.Checked = True Then
            If cmbDeleteCategory.Text <> "" Then

                LoadModelList(cmbDeleteCategory.Text, cmbDeleteBrand.Text)
                lblDeleteRemarks.Text = "Total Model Found: " & lstDeleteModel.Items.Count - 1
            Else
                lblDeleteRemarks.Text = "Category Field is Blank please fill this field"
            End If

        End If

    End Sub

    Private Sub cmdLoadModel_Click(sender As Object, e As EventArgs) Handles cmdLoadModel.Click
        If optCustomDelete.Checked = True Then
            cmbDeleteBrand_SelectedIndexChanged(sender, e)
        Else
            MessageBox.Show("You have to select custom Delete")
            lblDeleteRemarks.Text = "select custom Delete Option to makee task"
        End If
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click

        lblDeleteRemarks.Text = String.Empty
        Dim conDeleteCategory As New OleDbConnection(strProvider)

        If chkDeleteBrand.Checked = True Then
            If optQuickDelete.Checked = True Then
                If RecordVerification(strProvider, "Brand", "Brand.ctype='" & cmbDeleteCategory.Text & "' and Brand.Brand='" & cmbDeleteBrand.Text & "'") = True Then
                    Dim drLoadTempModelCount As OleDbDataReader = Nothing
                    Dim intTotalRecord As Integer = 0
                    Dim drLoadBrandId As OleDbDataReader = Nothing

                    LoadAllInformation(conDeleteCategory, drLoadBrandId, strProvider, "Brand", "Brand.brdid", "Brand.ctype='" & cmbDeleteCategory.Text & "' and Brand.Brand='" & cmbDeleteBrand.Text & "'")
                    If drLoadBrandId.HasRows = True Then
                        While drLoadBrandId.Read
                            intGetbrandID = drLoadBrandId("brdid").ToString
                        End While
                    End If


                    LoadAllInformation(conDeleteCategory, drLoadTempModelCount, strProvider, "BrandModel", "Count(BrandModel.brdid) as TtlBrandIDCount", "BrandModel.brdid=" & intGetbrandID)

                    If Not IsNothing(drLoadTempModelCount) Then
                        If drLoadTempModelCount.HasRows = True Then
                            While drLoadTempModelCount.Read
                                intTotalRecord = drLoadTempModelCount("ttlBrandIDCount").ToString
                            End While


                            If MsgBox("Are sure to delete: '" & intTotalRecord & "' model from Database", vbYesNo, "Model Delete") = vbYes Then
                                DeleteRecord("BrandModel", "BrandModel.brdid=" & intGetbrandID, "OFF")

                                lblDeleteRemarks.Text = "Total Model Deleted from Database is: " & intTotalRecord

                            End If
                        End If
                    End If
                    DeleteRecord("Brand", "Brand.brdid=" & intGetbrandID, "OFF")
                    cmbDeleteBrand.Text = String.Empty
                End If

            ElseIf optCustomDelete.Checked = True Then
                DeleteModelWithCustomMode()

            End If



        Else
            lblDeleteRemarks.Text = "Delete Permission OFF"
        End If

        TempConnectionDispose(conDeleteCategory)

    End Sub

    Private Sub cmdDeleteClear_Click(sender As Object, e As EventArgs) Handles cmdDeleteClear.Click
        cmbDeleteCategory.Text = String.Empty
        cmbDeleteBrand.Text = String.Empty

        If chkDeleteBrand.Checked = True Then
            chkDeleteBrand.Checked = False
        End If


    End Sub

    Private Sub cmdDeleteClose_Click(sender As Object, e As EventArgs) Handles cmdDeleteClose.Click
        Me.Dispose()

    End Sub





    Private Sub DeleteModelWithCustomMode()
        Dim intLoop As Integer = 0
        Dim intTotalDeletedRecord As Integer
        Dim lstTempModel As ListViewItem = Nothing
        Dim TempObject As New Object
        Dim E As New EventArgs
        If lstDeleteModel.Items.Count > 0 Then

            For intLoop = 0 To lstDeleteModel.Items.Count - 1
                lstTempModel = lstDeleteModel.Items(intLoop)

                If lstTempModel.Checked = True Then
                    intTotalDeletedRecord = intTotalDeletedRecord + 1
                    DeleteRecord("BrandModel", "BrandModel.Model='" & lstTempModel.SubItems(1).Text & "' and BrandModel.brdid=" & intGetbrandID, "OFF")
                End If

            Next



            cmbDeleteBrand_SelectedIndexChanged(TempObject, E)







        End If



    End Sub
End Class