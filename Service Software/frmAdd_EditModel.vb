




Public Class frmAdd_EditModel

    Public intModelFlag As String = 0
    Public strPreviousModel As String = String.Empty
    Public intBrandId As Integer = 0
    Dim frmTempCategory As New frmCategory
    Public strChangeStatusFlag As String
    Public MdID As Integer = 0
    Public ModelName As String = String.Empty


    Dim PreviousModel As clsBrandModel = New clsBrandModel



    Private Sub frmAdd_EditModel_Load(sender As Object, e As EventArgs) Handles MyBase.Load




        PreviousModel.Model = txtModel.Text
        PreviousModel.BrdID = intBrandId

        If Not ActiveUser.UserType.ToLower = LCase("Admin") Then

            MessageBox.Show("Only 'Admin User have this permission")
            Exit Sub

        End If










        CenterForm(Me)
        txtModel.Select()



    End Sub

    Private Sub frmAdd_EditModel_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        cmdSave.Width = ((grpModelInformation.Width) / 2) - (grpModelInformation.Left + 1) - 5
        cmdSave.Left = grpModelInformation.Left + 1
        cmdSave.Top = (grpModelInformation.Top + grpModelInformation.Height) - (cmdSave.Height + 5)
        cmdClose.Left = cmdSave.Left + cmdSave.Width + 5
        cmdClose.Width = cmdSave.Width
        cmdClose.Top = cmdSave.Top
        If intModelFlag = 5 Then
            Me.Text = "Edit Model : (Replaced Model : " & strPreviousModel & ")"
        Else
            Me.Text = "New Model"
        End If

    End Sub


    Private Sub Label4_Disposed(sender As Object, e As EventArgs) Handles Label4.Disposed

        intModelFlag = 0
        strPreviousModel = String.Empty
        intBrandId = 0
        strChangeStatusFlag = String.Empty
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click


        Me.Hide()

    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim strMessage = String.Empty

        Try


            If FieldValidation(strMessage) = False  Then ' Check FieldValidation

                If strMessage.ToLower = "SC".ToLower Then
                    MessageBox.Show("Service Charge Not Set", "Save Failed")
                    txtServiceCharge.Select()
                End If

                If strMessage.ToLower = "WP".ToLower Then
                    MessageBox.Show("Warranty period should be number", "Save Failed")
                    txtWarrantyPeriod.Select()
                End If


                If strMessage.ToLower = "SL".ToLower Then
                    MessageBox.Show("SLNO should be number", "Save Failed")
                    txtSLNo.Select()
                End If


                Exit Sub

            End If

            Dim BM As clsBrandModelMethods = New clsBrandModelMethods

            Dim BrandModel As clsBrandModel = New clsBrandModel
            BrandModel.Model = txtModel.Text
            BrandModel.BrdID = intBrandId
            BrandModel.Charge = txtServiceCharge.Text
            BrandModel.WPeriod = txtWarrantyPeriod.Text
            BrandModel.Item = txtItem.Text
            BrandModel.SLNO = txtSLNo.Text
            BrandModel.EntryDate = DateTime.Parse(Now).ToString("dd-MMM-yy")
            BrandModel.SIze = txtSize.Text
            BrandModel.Remarks = txtRemarks.Text


            If intModelFlag = 1 Then 'New model
                BM.Save(BrandModel)
                'InsertNewRecord(strProvider, "BrandModel", "Model,BrdID,Charge,WPeriod,Item,SLNO,EntryDate", "'" & txtModel.Text & "'," & intBrandId & "," & Convert.ToInt32(txtServiceCharge.Text) & "," & Convert.ToInt32(txtWarrantyPeriod.Text) & ",'" & txtItem.Text & "'," & Convert.ToInt32(txtSLNo.Text) & ", #" & Today.ToShortDateString & "#")
                MessageBox.Show("Model Insert Successfully")

            ElseIf intModelFlag = 2 Then ' Edit Model
                BM.Update(BrandModel, PreviousModel.Model, PreviousModel.BrdID)

                'UpdateRecords("Model,BrdID,Charge,WPeriod,Item,SLNO", "'" & txtModel.Text & "'," & intBrandId & "," & Convert.ToInt32(txtServiceCharge.Text) & "," & Convert.ToInt32(txtWarrantyPeriod.Text) & ",'" & txtItem.Text & "'," & Convert.ToInt32(txtSLNo.Text), "BrandModel", "BrandModel.brdid=" & intBrandId & " and BrandModel.Model='" & strPreviousModel & "'")
                MessageBox.Show("Model Updated Successfully")
            End If
            ModelName = txtModel.Text
            strChangeStatusFlag = "C"
        cmdClose_Click(sender, e)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Function FieldValidation(ByRef strMessage As String) As Boolean

        Dim blnFalse = True
        Dim intSL As Integer ' SLNO
        Dim intWP As Integer ' Wrranty Period
        Dim dblServiceCharge As Double


        If Integer.TryParse(txtServiceCharge.Text, dblServiceCharge) = False Then
            strMessage = "SC" ' Service Charge
            blnFalse = False

        End If

        If Integer.TryParse(txtWarrantyPeriod.Text, intWP) = False Then
            strMessage = "WP" ' Warranty Period
            blnFalse = False

        End If


        If Integer.TryParse(txtSLNo.Text, intSL) = False Then
            strMessage = "SL" ' SLNO
            blnFalse = False

        End If

        If txtServiceCharge.Text = "0" Then
            strMessage = "SC" ' Service Charge
            blnFalse = False
        End If


        Return blnFalse


    End Function

    Private Sub txtWarrantyPeriod_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtWarrantyPeriod.KeyPress
        InputDigit(sender, e)
    End Sub



    Private Sub txtServiceCharge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtServiceCharge.KeyPress
        InputDigit(sender, e)

    End Sub

    Private Sub txtSLNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSLNo.KeyPress
        InputDigit(sender, e)
    End Sub



    Private Sub txtItem_Leave(sender As Object, e As EventArgs) Handles txtItem.Leave
        txtItem.Text = UCase(txtItem.Text)
    End Sub

    Private Sub txtModel_Leave(sender As Object, e As EventArgs) Handles txtModel.Leave
        txtModel.Text = UCase(txtModel.Text)
    End Sub

    Private Sub txtModel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtModel.KeyPress


        If CheckCharacterSymbol(e.KeyChar, True) = True Then
            ShowToolTip(txtModel, True)





            e.Handled = True
            tltpNewModel.AutomaticDelay = 500
            tltpNewModel.AutoPopDelay = 5000
            tltpNewModel.ReshowDelay = 100
            tltpNewModel.InitialDelay = 500
            tltpNewModel.Show("You Cannot Type <>,./?';:[{]}\|=+_-()*&^%$#@!~`", txtModel)

            timerTooltip.Enabled = True


        Else

            timerTooltip.Enabled = True

            'ShowToolTip(txtModel, False)

        End If


    End Sub

    Private Sub timerTooltip_Tick(sender As Object, e As EventArgs) Handles timerTooltip.Tick

        tltpNewModel.Hide(txtModel)
        timerTooltip.Enabled = False

    End Sub

    Private Sub txtModel_TextChanged(sender As Object, e As EventArgs) Handles txtModel.TextChanged

    End Sub

    Private Sub txtModel_MouseHover(sender As Object, e As EventArgs) Handles txtModel.MouseHover

    End Sub

    Private Sub txtWarrantyPeriod_TextChanged(sender As Object, e As EventArgs) Handles txtWarrantyPeriod.TextChanged

    End Sub

    Private Sub txtServiceCharge_TextChanged(sender As Object, e As EventArgs) Handles txtServiceCharge.TextChanged

    End Sub

    Private Sub txtServiceCharge_Leave(sender As Object, e As EventArgs) Handles txtServiceCharge.Leave
        If String.IsNullOrEmpty(txtServiceCharge.Text) Then

            txtServiceCharge.Text = Integer.Parse("0")
        End If
    End Sub

    Private Sub txtWarrantyPeriod_Leave(sender As Object, e As EventArgs) Handles txtWarrantyPeriod.Leave
        If String.IsNullOrEmpty(txtWarrantyPeriod.Text) Then

            txtWarrantyPeriod.Text = Integer.Parse("0")
        End If
    End Sub

    Private Sub txtSLNo_TextChanged(sender As Object, e As EventArgs) Handles txtSLNo.TextChanged

    End Sub

    Private Sub txtSLNo_Leave(sender As Object, e As EventArgs) Handles txtSLNo.Leave
        If String.IsNullOrEmpty(txtSLNo.Text) Then

            txtSLNo.Text = Integer.Parse("0")
        End If
    End Sub
End Class