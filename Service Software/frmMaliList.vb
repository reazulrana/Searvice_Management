Imports System.Configuration
Imports System.Data.OleDb




Public Class frmMaliList
    Private Sub frmMaliList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterForm(Me)
        LoadMail()
    End Sub


    Private Sub LoadMail()
        If MailListHasRow = True Then
            GetAuditList()
        End If
    End Sub

    Public ReadOnly Property MailListHasRow() As Boolean
        Get
            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString


            Dim strQuery = "Select * from MailList"
            Dim blnFlag As Boolean = False

            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dcExist As OleDbCommand = New OleDbCommand(strQuery, con)

                con.Open()
                Dim drExist As OleDbDataReader = dcExist.ExecuteReader
                If drExist.HasRows = True Then
                    blnFlag = True
                End If
            End Using
            Return blnFlag
        End Get
    End Property
    Public Sub GetAuditList()

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim lstJobAudit As List(Of clsJobAudit) = New List(Of clsJobAudit)

        Dim strQuery = "Select * from MailList"
        Dim lstMail As ListViewItem = New ListViewItem
        lstMailList.Items.Clear()

        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcExist As OleDbCommand = New OleDbCommand(strQuery, con)
            con.Open()
            Dim drExist As OleDbDataReader = dcExist.ExecuteReader
            If drExist.HasRows = True Then
                While drExist.Read
                    lstMail = lstMailList.Items.Add(lstMailList.Items.Count + 1)
                    lstMail.SubItems.Add(drExist("Mail").ToString)
                End While

            End If
        End Using
    End Sub

    Private Sub txtMailno_TextChanged(sender As Object, e As EventArgs) Handles txtMailno.TextChanged

    End Sub

    Private Sub txtMailno_KeyUp(sender As Object, e As KeyEventArgs) Handles txtMailno.KeyUp
        If e.KeyCode = Keys.Enter Then
            btnSave.Select()

        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try

            If txtMailno.TextLength > 0 Then
                SaveMail(txtMailno.Text)
            End If

            MessageBox.Show("Mail Save Successfully", "Save Record")
            LoadMail()
            ClearField()

        Catch ex As Exception
            MessageBox.Show(ex.StackTrace, ex.Message)
            txtMailno.Select()
        End Try
    End Sub




    Public Sub SaveMail(ByVal Mail As String)

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Dim strQuery = "Insert into MailList(Mail) Values(@Mail)"


        Using con As OleDbConnection = New OleDbConnection(cs)

            Dim dcInsert As OleDbCommand = New OleDbCommand(strQuery, con)

            dcInsert.Parameters.Add("@Mail", OleDbType.Char, 255).Value = Mail


            con.Open()
            dcInsert.ExecuteNonQuery()




        End Using



    End Sub


    Public Sub UpdateMail(ByVal Mail As clsJobAudit, ByVal UpdateMail As String)
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Dim strQuery = "Update MailList set Mail=@Mail where Mail=@Mail1"


        Using con As OleDbConnection = New OleDbConnection(cs)

            Dim dcInsert As OleDbCommand = New OleDbCommand(strQuery, con)

            dcInsert.Parameters.Add("@Mail", OleDbType.Char, 255).Value = Mail
            dcInsert.Parameters.Add("@Mail1", OleDbType.Char, 255).Value = Mail


            con.Open()
            dcInsert.ExecuteNonQuery()




        End Using
    End Sub



    Public Sub DeleteMail(ByVal DeleteMail As String)
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim strQuery = "Delete * from MailList where Mail=@Mail1"
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcInsert As OleDbCommand = New OleDbCommand(strQuery, con)
            dcInsert.Parameters.Add("@Mail", OleDbType.Char, 255).Value = DeleteMail
            con.Open()
            dcInsert.ExecuteNonQuery()
        End Using
    End Sub



    Private Sub lstMailList_MouseUp(sender As Object, e As MouseEventArgs) Handles lstMailList.MouseUp
        If e.Button = MouseButtons.Right Then
            If lstMailList.Items.Count < 0 Then
                conAuditList.Enabled = False
            Else
                If lstMailList.SelectedItems.Count > 0 Then
                    conAuditList.Enabled = True
                Else
                    conAuditList.Enabled = False
                End If

            End If
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub


    Private Sub ClearField()
        txtMailno.Text = String.Empty
        txtMailno.Select()

    End Sub

    Private Sub ConAddAuditList_Click(sender As Object, e As EventArgs) Handles ConAddAuditList.Click
        Dim AuditJob As frmAuditOpetion = New frmAuditOpetion

        AuditJob.MailNo = lstMailList.FocusedItem.SubItems(1).Text
        AuditJob.ShowDialog()



    End Sub

    Private Sub ConRemoveAuditList_Click(sender As Object, e As EventArgs) Handles ConRemoveAuditList.Click
        Try

            Dim AuditMethods As clsJobAuditMethods = New clsJobAuditMethods
        Dim strMail As String = lstMailList.FocusedItem.SubItems(1).Text
            If AuditMethods.isExist(strMail) = True Then
                AuditMethods.Delete(strMail)
                MessageBox.Show("Mail Deleted Successfully")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.StackTrace, ex.Message)
        End Try
    End Sub

    Private Sub ConRemoveAuditList_DoubleClick(sender As Object, e As EventArgs) Handles ConRemoveAuditList.DoubleClick

    End Sub

    Private Sub lstMailList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstMailList.SelectedIndexChanged

    End Sub

    Private Sub lstMailList_KeyUp(sender As Object, e As KeyEventArgs) Handles lstMailList.KeyUp

    End Sub

    Private Sub lstMailList_DoubleClick(sender As Object, e As EventArgs) Handles lstMailList.DoubleClick
        ConAddAuditList_Click(sender, e)
    End Sub

    Private Sub ConDeleteMail_Click(sender As Object, e As EventArgs) Handles ConDeleteMail.Click
        Dim AuditMethods As clsJobAuditMethods = New clsJobAuditMethods
        Dim strMail As String = lstMailList.FocusedItem.SubItems(1).Text

        Try



            If AuditMethods.isExist(strMail) = True Then
                If MessageBox.Show("Do you want to delete Mail. You will loss all services this email provided", "Delete Option", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    AuditMethods.Delete(strMail)
                    DeleteMail(strMail)
                End If

            End If
                MessageBox.Show("Mail Delete Successfully")
        Catch ex As Exception
            MessageBox.Show(ex.StackTrace, ex.Message)
        End Try
    End Sub
End Class