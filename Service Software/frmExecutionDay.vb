Public Class frmExecutionDay

    Public executionDay As clsExecutionDay = New clsExecutionDay

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Me.Close()


    End Sub

    Private Sub frmExecutionDay_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim TempExeM As clsExecutionDay = New clsExecutionDay
        CenterForm(Me)




        If TempExeM.IsExist(executionDay.ActionID) = True Then
            LoadData()

        End If


    End Sub




    Private Sub LoadData()

        Dim TExecutionData As clsExecutionDay = New clsExecutionDay

        Dim listDay As List(Of clsExecutionDay) = TExecutionData.GetDayListByID(executionDay.ActionID)


        If listDay.Count > 0 Then

            For Each ExeDay As clsExecutionDay In listDay

                If ExeDay.DayName.ToLower = chkSat.Text.ToLower Then

                    chkSat.Checked = True
                End If



                If ExeDay.DayName.ToLower = chkSun.Text.ToLower Then

                    chkSun.Checked = True
                End If

                If ExeDay.DayName.ToLower = chkMon.Text.ToLower Then

                    chkMon.Checked = True
                End If
                If ExeDay.DayName.ToLower = chkTue.Text.ToLower Then

                    chkTue.Checked = True
                End If
                If ExeDay.DayName.ToLower = chkWed.Text.ToLower Then

                    chkWed.Checked = True
                End If
                If ExeDay.DayName.ToLower = chkThu.Text.ToLower Then

                    chkThu.Checked = True
                End If
                If ExeDay.DayName.ToLower = chkFri.Text.ToLower Then

                    chkFri.Checked = True
                End If
            Next
        End If


    End Sub


#Region "Check validation"


    Private Function CheckDaySelected() As Boolean
        Dim blnFlag As Boolean = False

        If chkSat.Checked = True Then
            blnFlag = True

        End If


        If chkSun.Checked = True Then
            blnFlag = True

        End If
        If chkMon.Checked = True Then
            blnFlag = True

        End If
        If chkTue.Checked = True Then
            blnFlag = True

        End If
        If chkWed.Checked = True Then
            blnFlag = True

        End If
        If chkThu.Checked = True Then
            blnFlag = True

        End If
        If chkFri.Checked = True Then
            blnFlag = True

        End If

        Return blnFlag
    End Function

    Private Sub cmdDone_Click(sender As Object, e As EventArgs) Handles cmdDone.Click

        Dim CheckDaySelection As Boolean

        CheckDaySelection = CheckDaySelected()

        If CheckDaySelection = False Then
            MessageBox.Show("No Execution Day Selected, Please Select at least on day")
            Exit Sub

        End If


        Try
            Save()
            MessageBox.Show("Record Save Successfully")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            lblStatus.Text = ex.Message


        End Try



    End Sub

    Private Sub chkSat_CheckedChanged(sender As Object, e As EventArgs) Handles chkSat.CheckedChanged

    End Sub

    Private Sub chkSun_CheckedChanged(sender As Object, e As EventArgs) Handles chkSun.CheckedChanged

    End Sub

    Private Sub chkMon_CheckedChanged(sender As Object, e As EventArgs) Handles chkMon.CheckedChanged

    End Sub

    Private Sub chkTue_CheckedChanged(sender As Object, e As EventArgs) Handles chkTue.CheckedChanged

    End Sub

    Private Sub chkWed_CheckedChanged(sender As Object, e As EventArgs) Handles chkWed.CheckedChanged

    End Sub

    Private Sub chkThu_CheckedChanged(sender As Object, e As EventArgs) Handles chkThu.CheckedChanged

    End Sub




#End Region


#Region "Insert Section"

    Private Sub Save()


        Dim exeM As clsExecutionDay = New clsExecutionDay


        If exeM.IsExist(executionDay.ActionID) = True Then
            exeM.Delete(executionDay.ActionID)

        End If

        If chkSun.Checked = True Then
            executionDay.DayID = 0
            executionDay.DayName = chkSun.Text
            exeM.Save(executionDay)
        End If
        If chkMon.Checked = True Then
            executionDay.DayID = 1
            executionDay.DayName = chkMon.Text
            exeM.Save(executionDay)
        End If
        If chkTue.Checked = True Then
            executionDay.DayID = 2
            executionDay.DayName = chkTue.Text
            exeM.Save(executionDay)
        End If
        If chkWed.Checked = True Then
            executionDay.DayID = 3
            executionDay.DayName = chkWed.Text
            exeM.Save(executionDay)
        End If
        If chkThu.Checked = True Then
            executionDay.DayID = 4
            executionDay.DayName = chkThu.Text
            exeM.Save(executionDay)
        End If
        If chkFri.Checked = True Then
            executionDay.DayID = 5
            executionDay.DayName = chkFri.Text
            exeM.Save(executionDay)
        End If
        If chkSat.Checked = True Then
            executionDay.DayID = 6
            executionDay.DayName = chkSat.Text
            exeM.Save(executionDay)
        End If







    End Sub




#End Region
End Class