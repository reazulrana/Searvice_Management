Public Class clsOthers


    Public Function Showtooltip(ByVal TempObject As TextBox) As ToolTip
        Dim tmptooltip As New ToolTip





        If TempObject.Text = "R" Then
            tmptooltip.Show(TempObject.Text, TempObject, TempObject.Left - 25, TempObject.Top, 1000)
            tmptooltip.UseFading = True


        End If

        Return tmptooltip





    End Function


End Class
