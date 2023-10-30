Public Class frmVAT

    Dim ItemState As ListViewItem = New ListViewItem
    Private Sub txtVat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtServicecharge.KeyPress
        If Not Char.IsDigit(e.KeyChar) Then
            If e.KeyChar = vbBack Then
                e.Handled = False
            ElseIf Char.IsLetter(e.KeyChar) = Keys.Delete Then
                e.Handled = False
            Else
                e.Handled = True
            End If

        End If
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click

        ' CHeck Vat Text box is blank ro invalid
        If txtServicecharge.Text.Length <= 0 Then
            MessageBox.Show("Set The Vat Amount")
            txtServicecharge.Select()
            Exit Sub
        ElseIf txtServicecharge.Text = Integer.Parse("0") Then
            MessageBox.Show("You Can not Set Vat '0'")
            txtServicecharge.Select()
            Exit Sub
        End If



        If txtParts.Text.Length <= 0 Then
            MessageBox.Show("Empty Service Charge")
            txtParts.Select()
            Exit Sub
        ElseIf txtParts.Text = Integer.Parse("0") Then
            MessageBox.Show("You Can not Parts '0' Percentage")
            txtParts.Select()
            Exit Sub
        End If


        Try

            Dim Vat As clsSetVAT = New clsSetVAT
            Dim VatMethods As clsSetVATMethods = New clsSetVATMethods
            Vat.ServiceCharge = txtServicecharge.Text

            Vat.Parts = txtParts.Text

            If chkMakeDefault.Checked = True Then
                VatMethods.ResetDefault() ' if any VAT is active in database then Reset all Active VAT
                Vat.IsActive = chkMakeDefault.Checked
            End If

            VatMethods.Save(Vat) ' Insert New Data into SetVAT Table


            LoadVAT()
            ClearField()
            MessageBox.Show("Record Save Succesfully")


        Catch ex As Exception
            MessageBox.Show(ex.StackTrace, ex.Message)
        End Try

    End Sub

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Me.Close()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub frmVAT_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CenterForm(Me)
        txtServicecharge.Select()

        Try
            LoadVAT()
        Catch ex As Exception
            MessageBox.Show(ex.StackTrace, ex.Message)
        End Try

    End Sub


    Private Sub LoadVAT()
        Dim VatMethods As clsSetVATMethods = New clsSetVATMethods


        Dim listVat As List(Of clsSetVAT) = VatMethods.GetVats.ToList
        Dim lstItem As ListViewItem = New ListViewItem


        If listVat.Count > 0 Then
            lstVatList.Items.Clear()

            For Each Vat As clsSetVAT In listVat

                lstItem = lstVatList.Items.Add(lstVatList.Items.Count + 1)

                If Not String.IsNullOrEmpty(Vat.ServiceCharge.ToString) Then
                    lstItem.SubItems.Add(Vat.ServiceCharge)
                Else
                    lstItem.SubItems.Add("0")
                End If



                If Not String.IsNullOrEmpty(Vat.Parts.ToString) Then

                    lstItem.SubItems.Add(Vat.Parts)
                Else
                    lstItem.SubItems.Add("0")

                End If

                If Not Vat.IsActive = False Then
                    lstItem.SubItems.Add("Default")
                Else
                    lstItem.SubItems.Add("")
                End If
            Next
        End If
    End Sub



    Private Sub pnlHeader_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlHeader.MouseDown
        ReleaseCapture()
        SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
    End Sub

    Private Sub frmVAT_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        ReleaseCapture()
        SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
    End Sub



    Private Sub frmVAT_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txtServicecharge.Select()
    End Sub




    Private Sub lstVatList_MouseDown(sender As Object, e As MouseEventArgs) Handles lstVatList.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Right Then

            ItemState = lstVatList.HitTest(e.Location).Item


            If Not ItemState Is Nothing Then
                cntxMenu.Visible = True
                mnuDelete.Visible = True
                mnuMakeDefault.Visible = True
            End If




        End If
    End Sub

    Private Sub mnuDelete_Click(sender As Object, e As EventArgs) Handles mnuDelete.Click

        Dim VatMethods As clsSetVATMethods = New clsSetVATMethods
        Try

            Dim listVat As List(Of clsSetVAT) = VatMethods.GetVats.Where(Function(x) x.ServiceCharge = ItemState.SubItems(1).Text And x.Parts = ItemState.SubItems(2).Text).ToList

            If listVat.Count > 0 Then ' Check Vat List is null or not

                VatMethods.Delete(Single.Parse(ItemState.SubItems(1).Text), Single.Parse(ItemState.SubItems(2).Text)) ' Delete VAT Record
                LoadVAT()
                MessageBox.Show("Delete Record Successfully")

            End If



        Catch ex As Exception
            MessageBox.Show(ex.StackTrace, ex.Message)
        End Try


    End Sub

    Private Sub mnuMakeDefault_Click(sender As Object, e As EventArgs) Handles mnuMakeDefault.Click
        Dim VatMethods As clsSetVATMethods = New clsSetVATMethods

        Try

            Dim listVat As List(Of clsSetVAT) = VatMethods.GetVats.Where(Function(x) x.ServiceCharge = Integer.Parse(ItemState.SubItems(1).Text) And x.Parts = Integer.Parse(ItemState.SubItems(2).Text)).ToList


            If listVat.Count > 0 Then

                Dim Vat As clsSetVAT = New clsSetVAT
                Vat.ServiceCharge = Integer.Parse(ItemState.SubItems(1).Text)
                Vat.Parts = Integer.Parse(ItemState.SubItems(2).Text)
                Vat.IsActive = True

                VatMethods.ResetDefault() ' Reset All Active VAT
                VatMethods.MakeDefault(Vat) ' The VAT is Making Default 
                LoadVAT()
                MessageBox.Show("Record Updates  Successfully")


            End If



        Catch ex As Exception
            MessageBox.Show(ex.StackTrace, ex.Message)
        End Try

    End Sub


    Private Sub ClearField()

        txtServicecharge.Text = String.Empty
        chkMakeDefault.Checked = False

    End Sub

    Private Sub txtVat_TextChanged(sender As Object, e As EventArgs) Handles txtServicecharge.TextChanged

    End Sub

    Private Sub cntxMenu_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cntxMenu.Opening

    End Sub
End Class