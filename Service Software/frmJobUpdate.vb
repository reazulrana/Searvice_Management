Imports System.Configuration
Imports System.Data
Imports System.Data.OleDb

Public Class frmJobUpdate
    Private Sub btnLoad_ChangeUICues(sender As Object, e As UICuesEventArgs) Handles btnLoad.ChangeUICues

    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click

        If (MessageBox.Show("Your Job will start from 1", "Reset Job", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No) Then

            Exit Sub

        End If


        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Dim strSQLUpdate = "Update Claiminfo Set JobCode=JobCode & '/OLD'"
        Try


            Application.DoEvents()
        lblBottomStatus.Text = "Job is Resetting"
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dc As OleDbCommand = New OleDbCommand(strSQLUpdate, con)
            con.Open()
                If MessageBox.Show("Are You Sure to Reset Job", "Reset Job", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    dc.ExecuteNonQuery()
                End If
                Application.DoEvents()
            lblBottomStatus.Text = "Resetting is Done"
        End Using



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Button1_ClientSizeChanged(sender As Object, e As EventArgs) Handles Button1.ClientSizeChanged

    End Sub

    Private Sub Button1_ControlAdded(sender As Object, e As ControlEventArgs) Handles Button1.ControlAdded

    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Me.Close()

    End Sub

    Private Sub lblHeader_Click(sender As Object, e As EventArgs) Handles lblHeader.Click

    End Sub

    Private Sub lblHeader_MouseDown(sender As Object, e As MouseEventArgs) Handles lblHeader.MouseDown
        ReleaseCapture()
        SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)

    End Sub

    Private Sub frmJobUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class