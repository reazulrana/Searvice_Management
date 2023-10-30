Imports System.IO
Imports System



Public Class frmBackUp
    Private Sub cmdSetLocation_Click(sender As Object, e As EventArgs) Handles cmdSetLocation.Click

        Try

            Dim strPath As String = String.Empty

            If fldLocation.ShowDialog = DialogResult.OK Then

                strPath = fldLocation.SelectedPath
                If strPath.Length > 0 Then

                    If strPath.Substring(strPath.Length - 1) = "\" Then
                    txtDestination.Text = fldLocation.SelectedPath
                Else

                    txtDestination.Text = fldLocation.SelectedPath & "\"

                End If

                End If
            End If






        Catch SetLocation As Exception
            MessageBox.Show(SetLocation.Message)

        End Try


    End Sub

    Private Sub frmBackUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = 250
        Me.Left = 250
        ResizeControl()

        If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.CurrentDirectory() & "\Service.mdb") = True Then
            txtSourceFile.Text = My.Computer.FileSystem.CurrentDirectory() & "\Service.mdb"
        Else
            txtSourceFile.Text = String.Empty

        End If
        OFDSourceFile.Filter = "Access|*.MDB"

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Dispose()

    End Sub

    Private Sub frmBackUp_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        fldLocation.Dispose()
        cmdBackUp.Dispose()
        cmdClose.Dispose()
        cmdSetLocation.Dispose()
        txtDestination.Dispose()
        Label1.Dispose()
        txtSourceFile.Dispose()
        cmdSourceFile.Dispose()


    End Sub

    Private Sub cmdBackUp_Click(sender As Object, e As EventArgs) Handles cmdBackUp.Click
        Dim strSourcePath = String.Empty


        strSourcePath = My.Computer.FileSystem.CurrentDirectory & "\Service.mdb"



        Try



            If My.Computer.FileSystem.FileExists(txtSourceFile.Text) And txtDestination.Text <> "" Then
                If My.Computer.FileSystem.FileExists(txtDestination.Text & "\Service.mdb") Then
                    If MsgBox("Do You Want to Overwrite Database", vbYesNo, "Save Another Back up") = vbYes Then
                        My.Computer.FileSystem.CopyFile(txtSourceFile.Text, txtDestination.Text & "Service.mdb", overwrite:=True)
                    Else
                        If MsgBox("Do You Want to Make Another Back up", vbYesNo, "Save Another Back up") = vbYes Then
                            My.Computer.FileSystem.CopyFile(txtSourceFile.Text, txtDestination.Text & "Service Back up (" & Today & " " & TimeOfDay.Hour & TimeOfDay.Minute & TimeOfDay.Second & ").mdb", overwrite:=False)
                        Else
                            Exit Sub
                        End If
                    End If
                Else
                    My.Computer.FileSystem.CopyFile(txtSourceFile.Text, txtDestination.Text & "Service.mdb", overwrite:=False)

                End If
                MessageBox.Show("Back up Completed Successfully")
            Else

                If txtSourceFile.Text = "" Then
                    MsgBox("Fill the Correct Source File")
                Else
                    MsgBox("Fill the Correct Destination")
                End If
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try


    End Sub



    Private Sub txtDestination_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDestination.KeyPress
        e.Handled = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdSourceFile.Click
        OFDSourceFile.ShowDialog()

        If OFDSourceFile.FileName <> "" Then
            txtSourceFile.Text = OFDSourceFile.FileName
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtSourceFile.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSourceFile.KeyPress
        e.Handled = True

    End Sub


    Private Sub ResizeControl()
        cmdBackUp.Left = txtDestination.Left
        cmdBackUp.Width = txtDestination.Width / 2
        cmdClose.Left = cmdBackUp.Left + cmdBackUp.Width
        cmdClose.Width = txtDestination.Width / 2

    End Sub

End Class