Imports System.ComponentModel
Imports System.Data.OleDb


Public Class frmCategory
    Dim strCategory As String = String.Empty
    Dim strBrand As String = String.Empty
    Dim shrtCategoryBrandFlag As Short
    Dim strModelArray() As String
    Dim intTempBrdid As Integer = 0

    Private Sub LoadCategory()

        Dim CategoryMethods As clscTypeMethods = New clscTypeMethods

        Dim listCategory As List(Of clscType) = CategoryMethods.GetAllCategory


        If listCategory.Count > 0 Then
            trCategory.Nodes.Clear()

            For Each c As clscType In listCategory ' Loop Each category

                trCategory.Nodes.Add(c.CategoryName).Tag = "Category"

                Dim BM As clsBrandMethods = New clsBrandMethods

                Dim listBM As List(Of clsBrand) = BM.GetAllBrands.Where(Function(ByVal x As clsBrand) x.CategoryName = c.CategoryName).ToList



                If listBM.Count > 0 Then

                    For Each B As clsBrand In listBM ' Loop each Brand 


                        trCategory.Nodes(trCategory.Nodes.Count - 1).Nodes.Add(B.Brand).Tag = B.BrdID


                    Next

                End If





            Next

        End If












    End Sub



    Private Sub frmCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.WindowState = FormWindowState.Maximized
        Try


            LoadCategory() ' Load Category and Brand during form load



        Catch ex As Exception
            MessageBox.Show(ex.StackTrace, ex.Message)
        End Try
    End Sub

    Private Sub frmCategory_Resize(sender As Object, e As EventArgs) Handles Me.Resize


        cmdSearch.Top = Me.ClientSize.Height - cmdSearch.Height - 2

        cmdClose.Top = cmdSearch.Top
        lblSearchModel.Top = cmdSearch.Top
        txtSearchModel.Top = cmdSearch.Top




        trCategory.Left = 0
        trCategory.Top = 0
        trCategory.Width = Me.ClientSize.Width / 4
        trCategory.Height = cmdSearch.Top - 2


        lstModel.Left = trCategory.Left + trCategory.Width
        lstModel.Top = 0
        lstModel.Width = Me.ClientSize.Width - (trCategory.Width)
        lstModel.Height = cmdSearch.Top - 2


        lblSearchModel.Left = trCategory.Left

        txtSearchModel.Left = lblSearchModel.Left + lblSearchModel.Width + 2
        txtFindingModel.Left = txtSearchModel.Left + txtSearchModel.Width + 3

        txtFindingModel.Top = txtSearchModel.Top


        cmdSearch.Width = (Me.ClientRectangle.Width - ((txtFindingModel.Left + txtFindingModel.Width) + 4)) / 2.5
        txtFindingModel.Width = txtFindingModel.Width + cmdSearch.Width - ((cmdSearch.Width * 0.5) + 3)
        cmdSearch.Left = txtFindingModel.Left + txtFindingModel.Width
        cmdClose.Width = cmdSearch.Width
        cmdClose.Left = cmdSearch.Left + cmdSearch.Width





    End Sub

    Private Sub trCategory_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles trCategory.AfterSelect



        Try

            If e.Node.Tag.ToString.ToLower <> "Category".ToLower Then


                strBrand = e.Node.Text
                intTempBrdid = Convert.ToInt32(e.Node.Tag)
                LoadModel(intTempBrdid)
                shrtCategoryBrandFlag = 4

            Else
                strCategory = e.Node.Text
                shrtCategoryBrandFlag = 2
            End If

        Catch LoadModelex As Exception
            MessageBox.Show(LoadModelex.StackTrace, LoadModelex.Message)
        End Try

    End Sub






    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click



        If txtSearchModel.Text.Length <= 0 Then
            MessageBox.Show("Search Field is Blank")
            txtSearchModel.Select()
            Exit Sub
        End If


        If lstModel.Items.Count > 0 Then




            For Each lstItem As ListViewItem In lstModel.Items

                If lstItem.Selected = True Then
                    lstItem.Selected = False
                End If

                If lstItem.SubItems(1).Text.ToLower = txtSearchModel.Text.ToLower Then
                    lstModel.Select()
                    lstItem.Selected = True
                    lstItem.EnsureVisible()

                End If


            Next



        End If

        'Dim drGetBrandID As OleDbDataReader = Nothing
        'Dim intMaximumNumber As Integer = 0
        'Dim intCount As Integer = 0
        'Dim conSearchBrandModel As New OleDbConnection(strProvider)
        'cmdSearch.Enabled = False

        'Dim ConVerification As New OleDbConnection(strProvider)

        ''ConVerification.ConnectionTimeout = 1

        'ConVerification.Open()

        'txtFindingModel.Text = String.Empty


        'Try


        '    If txtSearchModel.Text <> "" Then

        '        If RecordVerification1(strProvider, "BrandModel", "BrandModel.Model='" & txtSearchModel.Text & "'", ConVerification) = True Then

        '            Dim drGetArray As OleDbDataReader = Nothing

        '            LoadAllInformation(conSearchBrandModel, drGetArray, strProvider, "BrandModel", "count (BrandModel.brdId) as TtlRecord", "BrandModel.Model='" & txtSearchModel.Text & "'")

        '            While drGetArray.Read()
        '                intMaximumNumber = drGetArray("ttlRecord").ToString
        '            End While



        '            ReDim strModelArray(intMaximumNumber - 1)

        '            LoadAllInformation(conSearchBrandModel, drGetBrandID, strProvider, "BrandModel", "BrandModel.brdId", "BrandModel.Model='" & txtSearchModel.Text & "'")

        '            If drGetBrandID.HasRows = True Then
        '                While drGetBrandID.Read
        '                    strModelArray(intCount) = drGetBrandID("brdid").ToString
        '                    intCount = intCount + 1
        '                End While
        '            End If
        '            TempDatareaderClose(drGetBrandID)
        '            TempDatareaderClose(drGetBrandID)
        '            SearchModelWithBrand()

        '        End If


        '    End If

        'Catch ModelSearchex As Exception
        '    MessageBox.Show(ModelSearchex.Message)
        'End Try

        'ConVerification.Close()
        'TempConnectionDispose(ConVerification)
        'cmdSearch.Enabled = True
        'TempConnectionDispose(conSearchBrandModel)

    End Sub


    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Dispose()

    End Sub





    Private Sub SearchModelWithBrand()
        Dim intloop As Integer = 0
        Dim IntLoopNodesParent As Integer = 0
        Dim IntLoopNodeschild As Integer = 0
        Dim strCategoryFound As String = String.Empty

        Dim strBrandFound As String = String.Empty




        If strModelArray Is Nothing Then
            MsgBox("No Record Found", vbInformation, "Search Failed")

            Exit Sub

        End If




        txtFindingModel.Text = ""

        For intloop = 0 To UBound(strModelArray)
            For IntLoopNodesParent = 0 To trCategory.Nodes.Count - 1
                For IntLoopNodeschild = 0 To trCategory.Nodes(IntLoopNodesParent).Nodes.Count - 1
                    If trCategory.Nodes(IntLoopNodesParent).Nodes(IntLoopNodeschild).Tag = strModelArray(intloop) Then
                        strBrandFound = strBrandFound & trCategory.Nodes(IntLoopNodesParent).Nodes(IntLoopNodeschild).Text & ","
                    End If
                Next

                If strBrandFound.Length > 0 Then
                    If strBrandFound.Substring(strBrandFound.Length - 1) = "," Then
                        strBrandFound = strBrandFound.Substring(0, strBrandFound.Length - 1)

                    End If
                    strCategoryFound = strCategoryFound & "Category : " & trCategory.Nodes(IntLoopNodesParent).Text & " ;  Brand: " & strBrandFound & ",  "
                    strBrandFound = ""
                End If

            Next


        Next

        txtFindingModel.Text = strCategoryFound
        strCategoryFound = String.Empty

        'this Correct Coding if needed then use the the code' this code is for the selection of nodes of treeview


        'For intloop = 0 To UBound(strModelArray)
        '    For IntLoopNodesParent = 0 To trCategory.Nodes.Count - 1
        '        For IntLoopNodeschild = 0 To trCategory.Nodes(IntLoopNodesParent).Nodes.Count - 1
        '            If trCategory.Nodes(IntLoopNodesParent).Nodes(IntLoopNodeschild).Tag = strModelArray(intloop) Then
        '                trCategory.SelectedNode = trCategory.Nodes(IntLoopNodesParent).Nodes(IntLoopNodeschild)
        '            End If
        '        Next
        '        IntLoopNodeschild = 0
        '    Next

        '    IntLoopNodesParent = 0
        'Next


    End Sub

    Private Sub lstModel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstModel.SelectedIndexChanged

    End Sub

    Private Sub tsmNewCategory_Click(sender As Object, e As EventArgs) Handles tsmNewCategory.Click
        Dim frmTempNewCategory As New frmNewCategoryBrand
        Try


            frmTempNewCategory.IntCategoryBrandFlag = 1 ' Define 1 add New Category 2 for add New Brand
            frmTempNewCategory.ShowDialog()
            'frmTempNewCategory.Close()

            If frmTempNewCategory.Status.ToLower = "Insert".ToLower Then
                LoadCategory()
            End If



            frmTempNewCategory.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub





    'My.Computer.Registry.CurrentUser.CreateSubKey("Software\Company\Rana").SetValue("VBtest", TextBox1.Text)
    'My.Computer.Registry.CurrentUser.DeleteSubKey("Rana")
    'TextBox1.Text = My.Computer.Registry.CurrentUser.OpenSubKey("Software\Company\Rana").GetValue("vbtest")


    Private Sub ClearSelection()

        Dim intLoop As Integer = 0



        For intLoop = 0 To trCategory.Nodes.Count - 1
            If trCategory.Nodes(intLoop).IsSelected = True Then
                trCategory.SelectedNode = Nothing





            End If
        Next


    End Sub

    Private Sub trCategory_MouseClick(sender As Object, e As MouseEventArgs) Handles trCategory.MouseClick

        'cntxmsCategoryBrand Context menu show 
        ' Node select on right click


        If e.Button = Windows.Forms.MouseButtons.Right Then
            Dim node As TreeNode = trCategory.HitTest(e.Location).Node
            cntxmsCategoryBrand.Visible = True
            If node Is Nothing Then
                tsmEditCategory.Visible = False
                tsmNewBrand.Visible = False
                tsmEditBrand.Visible = False

            ElseIf node.Tag.ToString.ToLower <> "Category".ToLower Then
                tsmNewCategory.Visible = False
                tsmEditCategory.Visible = False
                tsmNewBrand.Visible = True
                tsmNewBrand.Enabled = True
                tsmEditBrand.Visible = True
            ElseIf node.Tag.ToString.ToLower = "Category".ToLower Then
                tsmNewCategory.Visible = True
                tsmEditCategory.Visible = True
                tsmNewBrand.Visible = True
                tsmEditBrand.Visible = False
            End If
        End If
    End Sub

    Private Sub tsmNewBrand_Click(sender As Object, e As EventArgs) Handles tsmNewBrand.Click

        Dim frmTempNewBrand As New frmNewCategoryBrand
        Try

            frmTempNewBrand.IntCategoryBrandFlag = 2 ' Define 1 add New Category 2 for add New Brand
            frmTempNewBrand.strTempCategory = strCategory

            frmTempNewBrand.ShowDialog()
            frmTempNewBrand.Close()


            If frmTempNewBrand.Status.ToLower = "Insert".ToLower Then
                LoadCategory()
            End If



            frmTempNewBrand.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub tsmEditCategory_Click(sender As Object, e As EventArgs) Handles tsmEditCategory.Click

        Dim frmTempEditCategoryBrand As New frmEditCategoryBrand
        Try

            frmTempEditCategoryBrand.intCategoryBrandFlag = shrtCategoryBrandFlag
            frmTempEditCategoryBrand.strPreviousCategory = strCategory
            frmTempEditCategoryBrand.ShowDialog()

            frmTempEditCategoryBrand.Dispose()
            If frmTempEditCategoryBrand.strChangeStatusFlag = "C" Then
                LoadCategory()
            End If
            frmTempEditCategoryBrand.Dispose()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub tsmEditBrand_Click(sender As Object, e As EventArgs) Handles tsmEditBrand.Click
        Dim frmTempEditCategoryBrand As New frmEditCategoryBrand
        Try

            With frmTempEditCategoryBrand
                .intCategoryBrandFlag = shrtCategoryBrandFlag
                .strTempCategory = strCategory
                .strPreviousBrand = strBrand
                .ShowDialog()

                If .strChangeStatusFlag = "C" Then
                    LoadCategory()
                End If
            End With

            frmTempEditCategoryBrand.Dispose()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub lstModel_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles lstModel.ItemSelectionChanged
        'If e.IsSelected = True Then
        '    shrtCategoryBrandFlag = 5 'Edit Model
        'Else
        '    shrtCategoryBrandFlag = 3 'New Model
        'End If
    End Sub








    Private Sub LoadModel(ByVal TempBrandID As Integer)




        Dim BrandModelMethods As clsBrandModelMethods = New clsBrandModelMethods

        Dim listModel As List(Of clsBrandModel) = BrandModelMethods.ModelList.Where(Function(ByVal x As clsBrandModel) x.BrdID = TempBrandID).ToList

        lstModel.Items.Clear()

        If listModel.Count > 0 Then

            Dim lstitem As ListViewItem = Nothing


            For Each m As clsBrandModel In listModel

                lstitem = lstModel.Items.Add(lstModel.Items.Count + 1)


                If Not String.IsNullOrEmpty(m.Model.ToString) Then
                    lstitem.SubItems.Add("" & m.Model.ToString)
                Else
                    lstitem.SubItems.Add("")

                End If



                If Not String.IsNullOrEmpty(m.Charge.ToString) Then
                    lstitem.SubItems.Add(m.Charge.ToString)
                Else
                    lstitem.SubItems.Add("")
                End If


                If Not String.IsNullOrEmpty(m.WPeriod.ToString) Then
                    lstitem.SubItems.Add(m.WPeriod.ToString)
                Else
                    lstitem.SubItems.Add("")
                End If




                If Not String.IsNullOrEmpty(m.Item.ToString) Then
                    lstitem.SubItems.Add(m.Item.ToString)
                Else
                    lstitem.SubItems.Add("")
                End If

                If Not String.IsNullOrEmpty(m.SLNO.ToString) Then
                    lstitem.SubItems.Add(m.SLNO.ToString)
                Else
                    lstitem.SubItems.Add("")
                End If


                If Not String.IsNullOrEmpty(m.SIze.ToString) Then
                    lstitem.SubItems.Add(m.SIze.ToString)
                Else
                    lstitem.SubItems.Add("")
                End If




                If Not String.IsNullOrEmpty(m.EntryDate) Then
                    lstitem.SubItems.Add("" & m.EntryDate.ToString)
                Else
                    lstitem.SubItems.Add("")
                End If
                If Not String.IsNullOrEmpty(m.Remarks.ToString) Then
                    lstitem.SubItems.Add(m.Remarks.ToString)
                Else
                    lstitem.SubItems.Add("")
                End If

                lstitem.Tag = m.MdID
            Next

        End If





    End Sub

    Private Sub lstModel_DoubleClick(sender As Object, e As EventArgs) Handles lstModel.DoubleClick
        Dim S As Object

        EditModelToolStripMenuItem_Click(S, e)


    End Sub

    Private Sub lstModel_MouseClick(sender As Object, e As MouseEventArgs) Handles lstModel.MouseClick

        If e.Button = Windows.Forms.MouseButtons.Right Then




            Dim lstItem As ListViewItem = Nothing


            lstItem = lstModel.HitTest(e.Location).Item

            cntxmnuModel.Visible = True

            If lstItem Is Nothing Then
                mnuEditModel.Enabled = False
            End If


        End If

    End Sub

    Private Sub NewModelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuNewModel.Click
        Dim frmTempNewModel As New frmAdd_EditModel
        Try

            With frmTempNewModel
                frmTempNewModel.Text = "Create Model"

                .lblCategory.Text = strCategory
                .lblBrand.Text = strBrand
                .intBrandId = intTempBrdid
                .intModelFlag = 1 'New Option
                .txtServiceCharge.Text = 0
                .txtWarrantyPeriod.Text = 0
                .txtSLNo.Text = 0

                .ShowDialog()
                If .strChangeStatusFlag = "C" Then

                    LoadModel(intTempBrdid)
                End If

                frmTempNewModel.Close()
            End With



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub EditModelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuEditModel.Click
        Dim frmTempEditModel As New frmAdd_EditModel
        Try

            Dim lstTempSelectedItem As ListViewItem = lstModel.Items(lstModel.FocusedItem.Index)







            With frmTempEditModel
                frmTempEditModel.Text = "Edit Model"

                .intBrandId = intTempBrdid
                .strPreviousModel = lstTempSelectedItem.SubItems(1).Text
                .lblCategory.Text = strCategory
                .lblBrand.Text = strBrand
                .txtModel.Text = "" & lstTempSelectedItem.SubItems(1).Text
                .txtServiceCharge.Text = lstTempSelectedItem.SubItems(2).Text
                .txtWarrantyPeriod.Text = lstTempSelectedItem.SubItems(3).Text
                .txtItem.Text = lstTempSelectedItem.SubItems(4).Text
                .txtSLNo.Text = lstTempSelectedItem.SubItems(5).Text
                .txtSize.Text = lstTempSelectedItem.SubItems(6).Text
                .txtRemarks.Text = lstTempSelectedItem.SubItems(8).Text
                .intModelFlag = 2 ' Edit Option
                .MdID = lstTempSelectedItem.Tag

                .ShowDialog()
                If .strChangeStatusFlag = "C" Then
                    LoadModel(intTempBrdid)
                End If
            End With

            frmTempEditModel.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub trCategory_AfterExpand(sender As Object, e As TreeViewEventArgs) Handles trCategory.AfterExpand
        strCategory = e.Node.Text
    End Sub

    Private Sub lstModel_MouseDown(sender As Object, e As MouseEventArgs) Handles lstModel.MouseDown

        If intTempBrdid = 0 Then
            mnuNewModel.Visible = False
            mnuEditModel.Visible = False
            Exit Sub
        Else
            mnuNewModel.Visible = True
            mnuEditModel.Visible = True
        End If

    End Sub
End Class