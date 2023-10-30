Imports System.ComponentModel
Imports System.Security.Cryptography
Imports System.Text
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports System.Drawing


Public Class frmLogIn

    Dim blnClose As Boolean

    <DllImportAttribute("user32.dll")>
    Public Shared Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer) As Integer
    End Function

    <DllImportAttribute("user32.dll")> Public Shared Function ReleaseCapture() As Boolean
    End Function
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2









    Private Sub UnloadForm()


        If blnLogInFLag = True Then
            blnClose = False
            Me.Close()

        Else
            Me.Close()

        End If








    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Try

            blnLogInFLag = True
            UnloadForm()

        Catch ex As Exception
            blnLogInFLag = True
            MessageBox.Show(ex.Message)
            Me.Close()

        End Try
    End Sub



    Private Sub frmLogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CenterForm(Me)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnSignin_Click(sender As Object, e As EventArgs) Handles btnSignin.Click
        Dim Encrytion As clsSecurity = New clsSecurity
        Dim userMethods As clsUserInfoMethods = New clsUserInfoMethods
        Dim CheckUserActivate As clsUserInfo = New clsUserInfo

        'Dim tmpMDIForm As frmMdimain = New frmMdimain
        Try
            lblStatus.Text = String.Empty

            blnClose = False
            If userMethods.UserCreadiantial(txtUserName.Text.ToLower, txtPassoword.Text) = True Then 'Check User Exist or not in the Database
                CheckUserActivate = userMethods.UserActive(txtUserName.Text.ToLower, txtPassoword.Text) 'Get Active User's Information
                ActiveUser = userMethods.GetUsersByID(CheckUserActivate.UserID) 'Load User Information by User ID
                UnloadForm()



                ' Below code is completely 'Ok' You Can Active it Anytime there is no 'Code Bug'

                'CheckUserActivate = userMethods.UserActive(txtUserName.Text.ToLower, txtPassoword.Text) 'Get Active User's Information
                'If CheckUserActivate.Active = False Then ' check either user active or not
                '    blnClose = False
                '    userMethods.UserActive(CheckUserActivate.UserID)
                '    ActiveUser = userMethods.GetUsersBuID(CheckUserActivate.UserID) 'Load User Information by User ID
                '    blnLogInFLag = False
                '    UnloadForm()
                'Else
                '    blnClose = True
                '    lblStatus.Text = "Someone is using the 'User Account' Try Another Account or wait until the user is free"
                '    blnLogInFLag = False
                '    Exit Sub
                'End If

            Else
                lblStatus.Text = "Your Security key is not valid" & vbNewLine & " Please Enter Correct Security Key or Contact Administrator"
                blnClose = True

            End If


        Catch ex As Exception
            lblStatus.Text = ex.Message
        End Try


    End Sub

    Private Sub frmLogIn_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        e.Cancel = blnClose



    End Sub

    Private Sub txtUserName_TextChanged(sender As Object, e As EventArgs) Handles txtUserName.TextChanged

    End Sub

    Private Sub txtUserName_KeyUp(sender As Object, e As KeyEventArgs) Handles txtUserName.KeyUp

    End Sub

    Private Sub txtPassoword_TextChanged(sender As Object, e As EventArgs) Handles txtPassoword.TextChanged

    End Sub

    Private Sub txtPassoword_KeyUp(sender As Object, e As KeyEventArgs) Handles txtPassoword.KeyUp

    End Sub

    Private Sub txtUserName_Enter(sender As Object, e As EventArgs) Handles txtUserName.Enter
        If txtUserName.Text.ToLower = LCase("User Name") Then
            txtUserName.Text = String.Empty
            ' txtUserName.ForeColor = Color.Black


        End If
    End Sub



    Private Sub txtPassoword_Leave(sender As Object, e As EventArgs) Handles txtPassoword.Leave
        If txtPassoword.Text.ToLower.Length = 0 Then
            txtPassoword.Text = "Password"
            txtPassoword.PasswordChar = ""
            'txtPassoword.ForeColor = Color.Black

        End If
    End Sub

    Private Sub txtUserName_Leave(sender As Object, e As EventArgs) Handles txtUserName.Leave
        If txtUserName.Text.Length = 0 Then
            txtUserName.Text = "User Name"
            ' txtUserName.ForeColor = Color.Black

        End If
    End Sub

    Private Sub frmLogIn_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)

    End Sub

    Private Sub Label3_MouseDown(sender As Object, e As MouseEventArgs)
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
    End Sub

    Private Sub lblStatus_Click(sender As Object, e As EventArgs) Handles lblStatus.Click

    End Sub

    Private Sub lblStatus_MouseDown(sender As Object, e As MouseEventArgs) Handles lblStatus.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
    End Sub

    Private Sub txtPassoword_Enter(sender As Object, e As EventArgs) Handles txtPassoword.Enter
        If txtPassoword.Text.ToLower = LCase("Password") Then
            txtPassoword.Text = String.Empty
            txtPassoword.PasswordChar = "*"
            ' txtPassoword.ForeColor = Color.Black


        End If
    End Sub

    Private Sub frmLogIn_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint

        Dim myPen As Pen = New Pen(Color.Green, 0.2)


        e.Graphics.DrawLine(myPen, txtUserName.Left, txtUserName.Top + txtUserName.Height, txtUserName.Left + txtUserName.Width, txtUserName.Top + txtUserName.Height)
        e.Graphics.DrawLine(myPen, txtPassoword.Left, txtPassoword.Top + txtPassoword.Height, txtPassoword.Left + txtPassoword.Width, txtPassoword.Top + txtPassoword.Height)
    End Sub

    Private Sub btnSignin_MouseEnter(sender As Object, e As EventArgs) Handles btnSignin.MouseEnter
        'btnSignin.ForeColor = Color.Black


    End Sub

    Private Sub btnSignin_MouseLeave(sender As Object, e As EventArgs) Handles btnSignin.MouseLeave
        'btnSignin.ForeColor = Color.Black
    End Sub

    Private Sub txtPassoword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassoword.KeyDown

    End Sub

    Private Sub txtUserName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUserName.KeyDown

    End Sub

    Private Sub txtPassoword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassoword.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            btnSignin.Select()
        End If
    End Sub

    Private Sub txtUserName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUserName.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            txtPassoword.Select()
        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel2.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
    End Sub
End Class