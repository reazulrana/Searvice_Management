Imports System.ComponentModel

Public Class frmTimeSchedule
    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim blnFlag As Boolean


        blnFlag = CheckValidation()

        If blnFlag = False Then
            MessageBox.Show("Select at least one Action")
            Exit Sub
        End If

        Dim exeSchedule As clsExecutionSchedule = New clsExecutionSchedule
        Dim TempExecutionSchedule As clsExecutionSchedule = New clsExecutionSchedule

        Dim blnIsexist As Boolean = True

        Try



            'check Not Issued is exist in ExecutionSchedule Table ?
            If exeSchedule.IsExist(chkNotIssued.Text) = True Then
                If chkNotIssued.Checked = True Then
                    TempExecutionSchedule.ExceededDay = Integer.Parse(txtNotIssued.Text)
                    TempExecutionSchedule.ActionTime = Date.Parse(dtNotIssued.Text).ToString("h:mm:ss tt")
                    TempExecutionSchedule.IsActive = chkNotIssued.Checked
                    TempExecutionSchedule.ActionName = chkNotIssued.Text
                    exeSchedule.update(TempExecutionSchedule)
                End If

            Else
                blnIsexist = False
            End If


            'check After Issued is exist in ExecutionSchedule Table ?
            If exeSchedule.IsExist(chkAfterIssue.Text) = True Then
                If chkAfterIssue.Checked = True Then

                    TempExecutionSchedule.ExceededDay = Integer.Parse(txtAfterIssue.Text)
                    TempExecutionSchedule.ActionTime = Date.Parse(dtAfterIssue.Text).ToString("h:mm:ss tt")
                    TempExecutionSchedule.IsActive = chkAfterIssue.Checked
                    TempExecutionSchedule.ActionName = chkAfterIssue.Text
                    exeSchedule.update(TempExecutionSchedule)

                End If
            Else
                blnIsexist = False
            End If


            'check After Waiting for Delivery is exist in ExecutionSchedule Table ?
            If exeSchedule.IsExist(chkWaitingForDelivery.Text) = True Then
                If chkWaitingForDelivery.Checked = True Then
                    TempExecutionSchedule.ExceededDay = Integer.Parse(txtWaitingForDelivery.Text)
                    TempExecutionSchedule.ActionTime = Date.Parse(dtWaitingForDelivery.Text).ToString("h:mm:ss tt")
                    TempExecutionSchedule.IsActive = chkWaitingForDelivery.Checked
                    TempExecutionSchedule.ActionName = chkWaitingForDelivery.Text
                    exeSchedule.update(TempExecutionSchedule)
                End If
            Else
                blnIsexist = False
            End If





            If blnIsexist = False Then
                MessageBox.Show("No Record found in database")
                Exit Sub

            End If

            MessageBox.Show("Update Sucessfully")


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try







    End Sub


#Region "Check Validation"

    Private Function CheckValidation() As Boolean
        Dim blnFlag As Boolean = False


        If chkNotIssued.Checked = True Then


            blnFlag = True

        End If


        If chkAfterIssue.Checked = True Then
            blnFlag = True
        End If


        If chkWaitingForDelivery.Checked = True Then
            blnFlag = True
        End If




        Return blnFlag




    End Function



#End Region







#Region "Test Time"

    Private Sub TimeTest()
        Dim d As Date = New Date
        d = Now
        Dim tmpD As Date = d





        If d.DayOfWeek = d.DayOfWeek.Saturday Then
            MessageBox.Show(d)
        End If
        d = d.AddDays(+7)




        If d.DayOfWeek = 6 Then
            MessageBox.Show(d)
        End If
    End Sub

#End Region

    Private Sub pnlHeader_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlHeader.MouseDown
        ReleaseCapture()
        SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
    End Sub

    Private Sub pnlHeader_Paint(sender As Object, e As PaintEventArgs) Handles pnlHeader.Paint

    End Sub

    Private Sub frmTimeSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterForm(Me)
    End Sub



    Private Sub frmTimeSchedule_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        ReleaseCapture()
        SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
    End Sub



    Private Sub grpAction_MouseDown(sender As Object, e As MouseEventArgs) Handles grpAction.MouseDown
        ReleaseCapture()
        SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
    End Sub



    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Me.Close()
    End Sub

    Private Sub chkNotIssued_CheckedChanged(sender As Object, e As EventArgs) Handles chkNotIssued.CheckedChanged
        If chkNotIssued.Checked = True Then
            Dim executionschedule As clsExecutionSchedule = New clsExecutionSchedule

            Dim frm As frmExecutionDay = New frmExecutionDay

            Dim intID As Integer = executionschedule.GetSchduleID(chkNotIssued.Text)
            If intID <= 0 Then
                MessageBox.Show("Invalid ID")
                Exit Sub
            End If
            frm.executionDay.ActionID = intID
            frm.ShowDialog()

            Dim TmpexecutionDay As clsExecutionDay = New clsExecutionDay

            'Chekck ActionID is exist in executionday Table
            If TmpexecutionDay.IsExist(intID) = True Then
                txtNotIssued.Enabled = True
                txtNotIssued.Select()
                dtNotIssued.Enabled = True
            Else
                chkNotIssued.Checked = False

            End If
        Else

            txtNotIssued.Enabled = False
            dtNotIssued.Enabled = False

        End If
    End Sub

    Private Sub cmbClose_Click(sender As Object, e As EventArgs) Handles cmbClose.Click


        Me.Close()
    End Sub



    Private Sub txtNotIssued_Validating(sender As Object, e As CancelEventArgs) Handles txtNotIssued.Validating
        lblStatus.Text = ""

        If txtNotIssued.Enabled = True Then

            If txtNotIssued.Text.Length <= 0 Or txtNotIssued.Text = "0" Then
                MessageBox.Show("Invalid Number")
                lblStatus.Text = "Note: Preiod Field should be greater than 0"
                e.Cancel = True
            End If

        End If
    End Sub



    Private Sub txtAfterIssue_Validating(sender As Object, e As CancelEventArgs) Handles txtAfterIssue.Validating

        lblStatus.Text = ""
        If txtAfterIssue.Enabled = False Then

            If txtAfterIssue.Text.Length <= 0 Or txtAfterIssue.Text = "0" Then
                MessageBox.Show("Invalid Number")
                lblStatus.Text = "Note: Preiod Field should be greater than 0"
                e.Cancel = True
            End If

        End If
    End Sub



    Private Sub txtWaitingForDelivery_Validating(sender As Object, e As CancelEventArgs) Handles txtWaitingForDelivery.Validating
        lblStatus.Text = ""
        If txtWaitingForDelivery.Enabled = False Then

            If txtWaitingForDelivery.Text.Length <= 0 Or txtWaitingForDelivery.Text = "0" Then
                MessageBox.Show("Invalid Number")
                lblStatus.Text = "Note: Preiod Field should be greater than 0"
                e.Cancel = True
            End If

        End If
    End Sub

    Private Sub chkAfterIssue_CheckedChanged(sender As Object, e As EventArgs) Handles chkAfterIssue.CheckedChanged
        If chkAfterIssue.Checked = True Then
            Dim executionschedule As clsExecutionSchedule = New clsExecutionSchedule

            Dim frm As frmExecutionDay = New frmExecutionDay

            Dim intID As Integer = executionschedule.GetSchduleID(chkAfterIssue.Text)
            If intID <= 0 Then
                MessageBox.Show("Invalid ID")
                Exit Sub
            End If
            frm.executionDay.ActionID = intID
            frm.ShowDialog()
            Dim TmpexecutionDay As clsExecutionDay = New clsExecutionDay

            'Chekck ActionID is exist in executionday Table
            If TmpexecutionDay.IsExist(intID) = True Then
                txtAfterIssue.Enabled = True
                txtAfterIssue.Select()
                dtAfterIssue.Enabled = True
            Else
                chkAfterIssue.Checked = False
            End If
        Else
            txtAfterIssue.Enabled = False
            txtAfterIssue.Enabled = False
        End If
    End Sub

    Private Sub chkWaitingForDelivery_CheckedChanged(sender As Object, e As EventArgs) Handles chkWaitingForDelivery.CheckedChanged
        If chkWaitingForDelivery.Checked = True Then
            Dim executionschedule As clsExecutionSchedule = New clsExecutionSchedule

            Dim frm As frmExecutionDay = New frmExecutionDay

            Dim intID As Integer = executionschedule.GetSchduleID(chkWaitingForDelivery.Text)
            If intID <= 0 Then
                MessageBox.Show("Invalid ID")
                Exit Sub
            End If
            frm.executionDay.ActionID = intID
            frm.ShowDialog()
            Dim TmpexecutionDay As clsExecutionDay = New clsExecutionDay

            'Chekck ActionID is exist in executionday Table
            If TmpexecutionDay.IsExist(intID) = True Then
                txtWaitingForDelivery.Enabled = True
                txtWaitingForDelivery.Select()
                dtWaitingForDelivery.Enabled = True
            Else
                chkWaitingForDelivery.Checked = False
            End If
        Else
            txtWaitingForDelivery.Enabled = False
            txtWaitingForDelivery.Enabled = False
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim t As String = Date.Parse(Now).ToString("h:mm:ss tt")

        If dtNotIssued.Text.ToLower = t.ToLower Then
            MessageBox.Show("Time Match")

        End If
    End Sub



    Private Sub dtNotIssued_Validating(sender As Object, e As CancelEventArgs) Handles dtNotIssued.Validating

        lblStatus.Text = ""

        If dtNotIssued.Enabled = True Then
            If dtNotIssued.Text.Length <= 0 Then
                lblStatus.Text = "Example : 12:00:00 AM"
                MessageBox.Show("Imvalid Time Set")
                dtNotIssued.Text = "12:00:00 AM"
                e.Cancel = True
            End If
        End If



    End Sub


    Private Sub dtAfterIssue_Validating(sender As Object, e As CancelEventArgs) Handles dtAfterIssue.Validating

        lblStatus.Text = ""
        If dtAfterIssue.Enabled = True Then
            If dtAfterIssue.Text.Length <= 0 Then
                lblStatus.Text = "Example : 12:00:00 AM"
                MessageBox.Show("Imvalid Time Set")
                dtAfterIssue.Text = "12:00:00 AM"
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub dtWaitingForDelivery_Validating(sender As Object, e As CancelEventArgs) Handles dtWaitingForDelivery.Validating
        lblStatus.Text = ""
        If dtWaitingForDelivery.Enabled = True Then
            If dtWaitingForDelivery.Text.Length <= 0 Then
                lblStatus.Text = "Example : 12:00:00 AM"
                MessageBox.Show("Imvalid Time Set")
                dtWaitingForDelivery.Text = "12:00:00 AM"
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub txtNotIssued_TextChanged(sender As Object, e As EventArgs) Handles txtNotIssued.TextChanged

    End Sub
End Class