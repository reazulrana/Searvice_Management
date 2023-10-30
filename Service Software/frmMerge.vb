Imports System.Data.OleDb

Public Class frmMerge
    Private Sub cmdLoad_Click(sender As Object, e As EventArgs) Handles cmdLoad.Click



        'lstUpdateStatus.Items.Clear()


        'ConcatenateMultyRow("servicedetails", "ServiceDetailsReport", "JobCode", "iif(Remarks<>'',' Remarks: ' & Remarks ,(ProductCode & ' Qty:' & Qty & ' UnitPrice:' & UnitPrice )) as P", "JobCode,ProductCode", PBLoad, lblTotalRecord, lblProgressRecord)
        'lstUpdateStatus.Items.Add("ServiceDetails Update Completed  " & TimeOfDay)
        'lstUpdateStatus.Refresh()

        'ConcatenateMultyRow("CustomerClaim", "CustomerClaimReport", "JobCode", "Claimcode", "JobCode,Claimcode", PBLoad, lblTotalRecord, lblProgressRecord)
        'lstUpdateStatus.Items.Add("CustomerClaim Update Completed  " & TimeOfDay)
        'lstUpdateStatus.Refresh()
        'ConcatenateMultyRow("CustomerClaimOthers", "CustomerClaimOthersReport", "JobCode", "Claimcode", "JobCode,Claimcode", PBLoad, lblTotalRecord, lblProgressRecord)
        'lstUpdateStatus.Items.Add("CustomerClaimOthers Update Completed  " & TimeOfDay)
        'lstUpdateStatus.Refresh()
        'ConcatenateMultyRow("NRDetails", "NRDetailsReport", "JobCode", "NRCode", "JobCode,NRCode", PBLoad, lblTotalRecord, lblProgressRecord)
        'lstUpdateStatus.Items.Add("NRDetails Update Completed  " & TimeOfDay)
        'lstUpdateStatus.Refresh()
        'ConcatenateMultyRow("NROthers", "NROthersReport", "JobCode", "NRCode", "JobCode,NRCode", PBLoad, lblTotalRecord, lblProgressRecord)
        'lstUpdateStatus.Items.Add("NROthers Update Completed  " & TimeOfDay)
        'lstUpdateStatus.Refresh()
        'ConcatenateMultyRow("Pending", "PendingReport", "JobCode", "PenCode", "JobCode,PenCode", PBLoad, lblTotalRecord, lblProgressRecord)
        'lstUpdateStatus.Items.Add("Pending Update Completed  " & TimeOfDay)
        'lstUpdateStatus.Refresh()
        'ConcatenateMultyRow("PendingOther", "PendingOtherReport", "JobCode", "PenCode", "JobCode,PenCode", PBLoad, lblTotalRecord, lblProgressRecord)
        'lstUpdateStatus.Items.Add("PendingOther Update Completed  " & TimeOfDay)
        'MsgBox(" Record Update Successfully", vbInformation)




        Merge()









    End Sub

    Private Sub frmDatabaseFormat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterForm(Me)

    End Sub






    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Dispose()

    End Sub






    Private Sub CreateTable()



        CallDropTableEvent()
        Dim conTable As New OleDbConnection(strProvider)
        Dim TransCreateTable As OleDbTransaction = Nothing
        Dim dcCreateTable As New OleDbCommand("", conTable, TransCreateTable)
        Try


            conTable.Open()
            TransCreateTable = conTable.BeginTransaction
            If VerifyTableExistence("CustomerClaim1") = False Then
                dcCreateTable.CommandText = "Create Table CustomerClaim1(Sl Autoincrement, JobCode Text(50), ClaimCode Memo"
                dcCreateTable.ExecuteNonQuery()
            End If

            If VerifyTableExistence("NRDetails1") = False Then
                dcCreateTable.CommandText = "Create Table NRDetails1(Sl Autoincrement, JobCode Text(50), NRCode Memo)"
                dcCreateTable.ExecuteNonQuery()
            End If

            If VerifyTableExistence("Pending1") = False Then
                dcCreateTable.CommandText = "Create Table Pending1(Sl Autoincrement, JobCode Text(50), PenCode Memo)"
                dcCreateTable.ExecuteNonQuery()

            End If

            If VerifyTableExistence("ServiceItem1") = False Then
                dcCreateTable.CommandText = "Create Table ServiceItem1(Sl Autoincrement, JobCode Text(50), Item Memo)"
                dcCreateTable.ExecuteNonQuery()
            End If


            If VerifyTableExistence("ServiceDetails1") = False Then
                dcCreateTable.CommandText = "Create Table ServiceDetails1(Sl Autoincrement, JobCode Text(50), Decription Memo)"
                dcCreateTable.ExecuteNonQuery()
            End If



            TransCreateTable.Commit()
        Catch exCreateTableError As Exception
            TransCreateTable.Rollback()


            MessageBox.Show(exCreateTableError.Message)

        End Try
















    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles cmdCreateTable.Click
        CreateTable()
    End Sub




    Private Sub CallDropTableEvent()
        DropTable("CustomerClaim1")
        DropTable("NRDetails1")
        DropTable("Pending1")
        DropTable("ServiceItem1")




    End Sub





    Private Sub DropTable(ByVal tempTable As String)

        Dim conDropTable As New OleDbConnection(strProvider)
        Try
            Dim dcDropTable As New OleDbCommand("Drop Table " & tempTable, conDropTable)
            conDropTable.open

            dcDropTable.ExecuteNonQuery()


        Catch ex As Exception

        End Try




    End Sub



    Private Sub Merge()

        Dim conMerge As New OleDbConnection(strProvider)
        Dim transMerge As OleDbTransaction = Nothing



        Try

            '_______________________________________________ Merge CustomerClaim ________________________________________________

            Dim ConCustomerClaim As New OleDbConnection(strProvider)
            Dim strCustomerClaimUniqueJob As String = String.Empty
            strCustomerClaimUniqueJob = "Select Distinct CustomerClaim.JobCode from CustomerClaim left Join CustomerClaim1 on CustomerClaim.Jobcode=CustomerClaim1.JobCode"

            Dim dcCustomerClaimUniqueJob As New OleDbCommand(strCustomerClaimUniqueJob, ConCustomerClaim)
            Dim drCustomerClaimUniqueJob As OleDbDataReader = Nothing
            ConCustomerClaim.Open()
            drCustomerClaimUniqueJob = dcCustomerClaimUniqueJob.ExecuteReader


            If drCustomerClaimUniqueJob.HasRows = True Then


                While drCustomerClaimUniqueJob.Read
                    If conMerge.State = ConnectionState.Closed Then
                        conMerge.Open()
                        transMerge = conMerge.BeginTransaction
                    End If
                    Dim dcLoadJob As New OleDbCommand("Select CustomerClaim.ClaimCode from CustomerClaim where CustomerClaim.JobCode='" & drCustomerClaimUniqueJob("JobCOde").ToString & "'", ConCustomerClaim)
                    Dim drLoadJob As OleDbDataReader = Nothing
                    Dim strClaimCode As String
                    strClaimCode = String.Empty

                    drLoadJob = dcLoadJob.ExecuteReader

                    If drLoadJob.HasRows = True Then
                        While drLoadJob.Read
                            strClaimCode += drLoadJob("ClaimCode").ToString & ":"
                        End While


                        Dim dcInserCustomerClaimCode As New OleDbCommand("Insert into CustomerClaim1(JobCode,ClaimCode) Values('" & drCustomerClaimUniqueJob("JobCode").ToString & "','" & strClaimCode.ToString & "')", conMerge, transMerge)
                        dcInserCustomerClaimCode.ExecuteNonQuery()

                    End If




                    conMerge.Close()


                End While

            End If

            ConCustomerClaim.Close()



            '_______________________________________________ Merge NRDetails _______________________________

            If conMerge.State = ConnectionState.Closed Then
                conMerge.Open()
            End If


            transMerge.Commit()
            MessageBox.Show("Merge Completed")



        Catch exMergeError As Exception
            transMerge.Rollback()
            MessageBox.Show(exMergeError.Message)
        End Try




    End Sub



    Private Function VerifyTableExistence(ByVal TempTableName As String) As Boolean



        Dim conVerifyTable As New OleDbConnection(strProvider)

        Dim dcVerifyTable As New OleDbCommand("Select mSysobjects.Name from mSysobjects where mSysObjects.Name='" & TempTableName & "'", conVerifyTable)

        Dim drVerifyTable As OleDbDataReader = Nothing
        conVerifyTable.Open()

        drVerifyTable = dcVerifyTable.ExecuteReader

        If drVerifyTable.HasRows = True Then

            If drVerifyTable("Name").ToString.ToUpper = TempTableName.ToUpper Then
                Return True

            End If



        End If



        Return False








    End Function



End Class
