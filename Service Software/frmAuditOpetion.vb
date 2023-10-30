Public Class frmAuditOpetion


    Public MailNo As String = String.Empty

    Private Sub frmAuditOpetion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterForm(Me)
        EnableJobStatusCheckbox()

        Try

            chkService.Enabled = False
        lblMail.Text = MailNo
        Dim JobAuditMethods As clsJobAuditMethods = New clsJobAuditMethods
            If JobAuditMethods.isExist(MailNo) = True Then
                Dim JobAuditList As List(Of clsJobAudit) = JobAuditMethods.GetAuditList.Where(Function(x) x.MailNo.ToLower = MailNo.ToLower).ToList

                If JobAuditList.Count > 0 Then

                    For Each Audit As clsJobAudit In JobAuditList
                        'If Audit.Service = True Then
                        '    chkService.Checked = True
                        'End If
                        If Audit.NR = True Then
                            chkNR.Checked = True
                        End If
                        If Audit.ER = True Then
                            chkEstimateRefuse.Checked = True
                        End If
                        If Audit.Pending = True Then
                            chkPending.Checked = True
                        End If

                        If Audit.NotIssued = True Then
                            chkNotIssued.Checked = True
                        End If

                        If Audit.AfterIssue = True Then
                            chkAfterIssue.Checked = True
                        End If

                        If Audit.WaitingforDelivery = True Then
                            chkWaitingForDelivery.Checked = True
                        End If


                    Next
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.StackTrace, ex.Message)
            Me.Close()

        End Try
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim JobAudit As clsJobAudit = New clsJobAudit
        Dim AuditMethods As clsJobAuditMethods = New clsJobAuditMethods

        Try

            If checkValidation() = False Then
                If AuditMethods.isExist(MailNo) = True Then
                    AuditMethods.Delete(MailNo)
                End If

                Me.Close()
                Exit Sub
            End If
            If MailNo.Length > 0 Then
                JobAudit.MailNo = MailNo
            End If

            JobAudit.Service = chkService.Checked
        JobAudit.NR = chkNR.Checked
        JobAudit.ER = chkEstimateRefuse.Checked
            JobAudit.Pending = chkPending.Checked
            JobAudit.NotIssued = chkNotIssued.Checked
            JobAudit.AfterIssue = chkAfterIssue.Checked
            JobAudit.WaitingforDelivery = chkWaitingForDelivery.Checked



            If AuditMethods.isExist(MailNo) = True Then
            AuditMethods.Update(JobAudit, MailNo)
        Else
            AuditMethods.Save(JobAudit)
        End If
        MessageBox.Show("Save Record Successfully", "Done")
        btnClose_Click(sender, e)

        Catch ex As Exception
            MessageBox.Show(ex.StackTrace, ex.Message)
        End Try
    End Sub


    Private Function checkValidation() As Boolean

        Dim blnFlag As Boolean = False


        'If chkService.Checked = True Then
        '    blnFlag = True
        'End If

        If chkNR.Checked = True Then
            blnFlag = True
        End If
        If chkEstimateRefuse.Checked = True Then
            blnFlag = True
        End If
        If chkPending.Checked = True Then
            blnFlag = True
        End If

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

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub




    Private Sub EnableJobStatusCheckbox()

        Dim tmpexecutionSchedule As clsExecutionSchedule = New clsExecutionSchedule


        Dim lstSchedule As List(Of clsExecutionSchedule) = tmpexecutionSchedule.GetActiveSchedules.ToList ' get Selected Schedule  from ExecutionSchedule table

        If lstSchedule.Count > 0 Then
            For Each schedule As clsExecutionSchedule In lstSchedule
                If chkNotIssued.Text.ToLower = schedule.ActionName.ToLower Then
                    chkNotIssued.Enabled = schedule.IsActive
                End If

                If chkAfterIssue.Text.ToLower = schedule.ActionName.ToLower Then
                    chkAfterIssue.Enabled = schedule.IsActive
                End If


                If chkWaitingForDelivery.Text.ToLower = schedule.ActionName.ToLower Then
                    chkWaitingForDelivery.Enabled = schedule.IsActive
                End If

            Next
        End If


    End Sub
End Class