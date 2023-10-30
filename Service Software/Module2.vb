Imports System.Data.OleDb
Imports System.Runtime.InteropServices
Imports System.Configuration
Imports Microsoft.Office.Interop


Imports System.Net.Mail
Imports System.Threading





Module Module2

    <DllImportAttribute("user32.dll")>
    Public Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer) As Integer
    End Function

    <DllImportAttribute("user32.dll")> Public Function ReleaseCapture() As Boolean
    End Function
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2

    Public frmMDI As frmMdimain

    Public strProvider As String
    'Public strProdiver As String
    Public MyCon As OleDbConnection

    Public shrtFormType As Integer
    Public blnJobCodeFlag As Boolean
    Public strtmpJobCode As String
    Public strTmpCFlag As String = String.Empty
    Public strtmpMRNo As String = String.Empty
    Public strTempTechnicianCode As String = String.Empty
    Public strTempTechnicianName As String = String.Empty
    Public strTempBranchName As String = String.Empty
    Public ReportIdentification As String = String.Empty
    Public strCompanyTitle As String = String.Empty
    Public strUnSpecificValueDefined As String 'Take All Kind of value which are unspecific
    Public dtReceiveDate As Date
    Public publicClaiminfo As clsClaiminfo

    Public blnLogInFLag As Boolean
    Public ActiveUser As clsUserInfo


    Public Function DatabaseConnection() As Boolean


        ' Dim strDatabasLocaltion As String

        'strDatabasLocaltion = My.Computer.FileSystem.ReadAllText(Environment.CurrentDirectory & "\Database.txt")

        'strProvider = "Provider= Microsoft.Jet.OLEDB.4.0; Data source=" & strDatabasLocaltion
        On Error GoTo connectionError

        Dim blnConFlag As Boolean = False
        Dim intMaximumTry As Byte
        strProvider = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString



VerifyConnect:

        If blnConFlag = False Then
            intMaximumTry = intMaximumTry + 1
            strProvider = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Else
            intMaximumTry = intMaximumTry + 1
            strProvider = ConfigurationManager.ConnectionStrings("DBCService1").ConnectionString

        End If


        MyCon = New OleDbConnection(strProvider)
        If MyCon.State = ConnectionState.Open Then
            MyCon.Close()
            MyCon.Open()
        Else
            MyCon.Open()

        End If

        Return True



connectionError:
        If blnConFlag = False Then
            blnConFlag = True
        Else
            blnConFlag = False

        End If


        If intMaximumTry >= 3 Then

            Return False
        Else
            Resume VerifyConnect
        End If

    End Function




    Public Sub SetMDIFORM()

        frmMDI = New frmMdimain

    End Sub


    Public Sub ResizeForm(ByVal frmTemp As Form, ByVal blnResize As Boolean)
        Dim frmM As New frmOpenCustomerClaim
        Dim main As frmMdimain = New frmMdimain
        frmTemp.MdiParent = main.MdiParent



        If blnResize = True Then
            frmTemp.Top = frmMDI.MainMenuStrip.Top + frmMDI.MainMenuStrip.Height
            frmTemp.Left = frmMDI.Left
            frmTemp.Height = frmMDI.ClientSize.Height - (frmMDI.MainMenuStrip.Top + frmMDI.MainMenuStrip.Height)
            frmTemp.WindowState = FormWindowState.Maximized
            frmTemp.Width = frmMDI.ClientSize.Height
            frmMDI.MainTools.Visible = False

            If frmTemp.Name = "frmOpenCustomerClaim" Then
                frmTemp.ShowDialog()
            Else

                frmTemp.Show()

            End If


            Exit Sub

        End If

        If frmTemp.Name = "frmOpenCustomerClaim" Then
            frmTemp.ShowDialog()
        Else

            frmTemp.Show()

        End If




    End Sub




    Public Sub GetBranch(ByVal tmpCombobox As ComboBox)
        Try
            tmpCombobox.Text = My.Computer.Registry.CurrentUser.OpenSubKey("Software\Company Software\Service").GetValue("Default_Branch")
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & "Event: GetBranch")
        End Try

    End Sub


    Public Sub UpdateRecord(ByVal strJobCode As String, ByVal strTableName As String, Optional strFldName As String = "", Optional lsttmpItem As ListView = Nothing)


        Dim lstItemtmp As ListViewItem
        Dim shrtLoop As Short
        Dim MytmpCon As New OleDbConnection(strProvider)


        MytmpCon.Open()




        Try


            If strTableName = "CustomerCLaim" Then
                For shrtLoop = 0 To lsttmpItem.Items.Count - 1
                    lstItemtmp = lsttmpItem.Items(shrtLoop)
                    If lstItemtmp.Checked = True Then
                        Debug.Print(lstItemtmp.Text)
                        'Dim dcInsertRecord As New OleDbCommand("Insert into CustomerClaim(JobCode,ClaimCOde) Valuse ('" & strJobCode & "','" & lstItemtmp.Text & "'", MyCon)
                        Dim dcCheckValue As New OleDbCommand("Select CustomerCLaim.JobCode,CustomerClaim.ClaimCode from CustomerClaim where CustomerClaim.JobCode='" & strtmpJobCode & "' and CustomerClaim.CLaimcode='" & lstItemtmp.Text & "'", MyCon)
                        Dim drCheckValue As OleDbDataReader

                        drCheckValue = dcCheckValue.ExecuteReader
                        Dim strInsertUpdate As String = ""

                        If drCheckValue.HasRows = False Then
                            strInsertUpdate = "Insert into CustomerClaim(JobCode,ClaimCOde) Values ('" & strJobCode & "','" & lstItemtmp.Text & "')"
                            'Dim dcInsertRecord As New OleDbCommand("Insert into CustomerClaim(JobCode,ClaimCOde) Values ('" & strJobCode & "','" & lstItemtmp.Text & "')", MytmpCon)

                            'dcInsertRecord.ExecuteNonQuery()

                            'dcInsertRecord = Nothing
                        Else
                            strInsertUpdate = "Update CustomerClaim Set CustomerClaim.JobCode='" & strJobCode & "', CustomerClaim.CLaimcode='" & lstItemtmp.Text & "' where  CustomerClaim.JobCode='" & strtmpJobCode & "' and  CustomerClaim.CLaimcode='" & lstItemtmp.Text & "'"
                        End If

                        Dim dcInsertUpdateRecord As New OleDbCommand(strInsertUpdate, MyCon)

                        dcInsertUpdateRecord.ExecuteNonQuery()

                        dcInsertUpdateRecord = Nothing

                        drCheckValue.Close()
                        drCheckValue = Nothing
                        dcCheckValue = Nothing





                    Else


                        Dim dcCheckValue As New OleDbCommand("Select CustomerCLaim.JobCode,CustomerClaim.ClaimCode from CustomerClaim where CustomerClaim.JobCode='" & strtmpJobCode & "' and CustomerClaim.CLaimcode='" & lstItemtmp.Text & "'", MyCon)
                        Dim drCheckValue As OleDbDataReader

                        drCheckValue = dcCheckValue.ExecuteReader

                        If drCheckValue.HasRows = True Then


                            Dim dcDeleteRecord As New OleDbCommand("Delete * from CustomerClaim where CustomerClaim.JobCode='" & strtmpJobCode & "' and CustomerClaim.ClaimCode='" & lstItemtmp.Text & "'", MyCon)


                            dcDeleteRecord.ExecuteNonQuery()

                        End If


                        drCheckValue.Close()
                        drCheckValue = Nothing
                        dcCheckValue = Nothing
















                    End If


                Next

            ElseIf strTableName = "ServiceItem" Then

                For shrtLoop = 0 To lsttmpItem.Items.Count - 1
                    lstItemtmp = lsttmpItem.Items(shrtLoop)
                    If lstItemtmp.Checked = True Then

                        'Dim dcInsertRecord As New OleDbCommand("Insert into CustomerClaim(JobCode,ClaimCOde) Valuse ('" & strJobCode & "','" & lstItemtmp.Text & "'", MyCon)
                        Dim dcCheckValue As New OleDbCommand("Select ServiceItem.JobCode,ServiceItem.Item from ServiceItem where ServiceItem.JobCode='" & strJobCode & "' and ServiceItem.Item='" & lstItemtmp.Text & "'", MytmpCon)
                        Dim drCheckValue As OleDbDataReader

                        drCheckValue = dcCheckValue.ExecuteReader

                        If drCheckValue.HasRows = False Then

                            Dim dcInsertRecord As New OleDbCommand("Insert into ServiceItem(JobCode,Item) Values ('" & strJobCode & "','" & lstItemtmp.Text & "')", MytmpCon)

                            dcInsertRecord.ExecuteNonQuery()

                            dcInsertRecord = Nothing

                        End If

                        drCheckValue.Close()
                        drCheckValue = Nothing
                        dcCheckValue = Nothing





                    Else


                        Dim dcCheckValue As New OleDbCommand("Select ServiceItem.JobCode,ServiceItem.Item from ServiceItem where ServiceItem.JobCode='" & strJobCode & "' and ServiceItem.Item='" & lstItemtmp.Text & "'", MytmpCon)
                        Dim drCheckValue As OleDbDataReader

                        drCheckValue = dcCheckValue.ExecuteReader

                        If drCheckValue.HasRows = True Then


                            Dim dcDeleteRecord As New OleDbCommand("Delete * from ServiceItem where ServiceItem.JobCode='" & strJobCode & "' and ServiceItem.Item='" & lstItemtmp.Text & "'", MytmpCon)


                            dcDeleteRecord.ExecuteNonQuery()

                        End If


                        drCheckValue.Close()
                        drCheckValue = Nothing
                        dcCheckValue = Nothing
















                    End If


                Next



            End If

















        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Event Name: Delete_unMatched_Record, Module Name:Module2")
        End Try


    End Sub





    Public Sub UpdateRecords(ByVal tmpColumnName As String, ByVal TmpValue As String, ByVal TmpTableName As String, ByVal tmpUpdateWhereClause As String)

        Dim strFieldName() As String
        Dim strValue() As String
        Dim strUpdateCriteria As String = ""


        strFieldName = Split(tmpColumnName, ",")
        strValue = Split(TmpValue, ",")
        'Try


        Dim shrtFieldCount = UBound(strFieldName)
            Dim shrtValueCount = UBound(strValue)
            If shrtFieldCount = shrtValueCount Then
                Dim shrtLoop As Short

                For shrtLoop = 0 To UBound(strFieldName)

                    strUpdateCriteria = strUpdateCriteria & TmpTableName & "." & strFieldName(shrtLoop) & "=" & strValue(shrtLoop) & ","


                Next
            Else
                MsgBox("Criteria is not matched", vbInformation, "Failed Update")
                Exit Sub

            End If



            If strUpdateCriteria.Substring(strUpdateCriteria.Length - 1) = "," Then
                strUpdateCriteria = strUpdateCriteria.Substring(0, strUpdateCriteria.Length - 1)

            End If
        If tmpUpdateWhereClause = "" Or tmpUpdateWhereClause = "''" Then
            strUpdateCriteria = "Update " & TmpTableName & " Set " & strUpdateCriteria
        Else
            strUpdateCriteria = "Update " & TmpTableName & " Set " & strUpdateCriteria & " Where " & tmpUpdateWhereClause
        End If



        Dim ConUpdateData As New OleDbConnection(strProvider)
            ConUpdateData.Open()

            Dim dcUpdateData As New OleDbCommand(strUpdateCriteria, ConUpdateData)
            dcUpdateData.ExecuteNonQuery()

            'dcUpdateData.Dispose()
            'ConUpdateData.Close()
            ' ConUpdateData.Dispose()
            TempCommandDispose(dcUpdateData)
            TempConnectionDispose(ConUpdateData)
        'Catch EXUpdateRecords As Exception
        '    MsgBox(EXUpdateRecords.Message & vbCrLf & EXUpdateRecords.StackTrace, vbCritical, "Error Event: UpdateRecords")
        'End Try



    End Sub



    Public Sub CenterForm(ByRef frmTemp As Form)


        frmTemp.Left = (My.Computer.Screen.WorkingArea.Width - frmTemp.ClientSize.Width) / 2
        frmTemp.Top = (My.Computer.Screen.WorkingArea.Height - frmTemp.ClientSize.Height) / 2


    End Sub



    Public Sub ShowPreviousJob(Optional strtmpPreviousJob As String = "", Optional ByVal strTmpClaiminfoCategory As String = "", Optional ByVal strTempClaiminfoBrand As String = "", Optional ByVal strTempClaiminfoModel As String = "", Optional ByVal strtmpClaiminfoSLNO As String = "", Optional ByRef strGetPreviousJobResult As String = "")

        Dim strPreviousJob As String = ""
        Try


            If strtmpPreviousJob = "" Then
                strPreviousJob = "Select Claiminfo.JobCode from Claiminfo where Claiminfo.JobCode<>'nil' and Claiminfo.Servicetype='" & strTmpClaiminfoCategory & "' and Claiminfo.Brand='" & strTempClaiminfoBrand & "' and claiminfo.Modelno='" & strTempClaiminfoModel & "' and slNo='" & strtmpClaiminfoSLNO & "'"


            Else
                strPreviousJob = "Select Claiminfo.JobCode from Claiminfo where Claiminfo.JobCode<>'nil' and Claiminfo.JobCode<>'" & strtmpJobCode & "' and Claiminfo.Servicetype='" & strTmpClaiminfoCategory & "' and Claiminfo.Brand='" & strTempClaiminfoBrand & "' and claiminfo.Modelno='" & strTempClaiminfoModel & "' and slNo='" & strtmpClaiminfoSLNO & "'"
            End If

            Dim comShowPreviousJob As New OleDbCommand(strPreviousJob, MyCon)



            Dim readShowPreviosJob As OleDbDataReader
            readShowPreviosJob = comShowPreviousJob.ExecuteReader


            Dim strCheckComma As String




            While readShowPreviosJob.Read
                strGetPreviousJobResult = strGetPreviousJobResult & readShowPreviosJob("JobCode").ToString & ","
            End While

            strCheckComma = strGetPreviousJobResult
            If strCheckComma <> "" Then
                If strCheckComma.Substring(strCheckComma.Length - 1) = "," Then
                    strCheckComma = strCheckComma.Substring(0, strCheckComma.Length - 1)
                    strGetPreviousJobResult = strCheckComma


                End If
            End If
        Catch exShowPreviousJob As Exception
            MsgBox(exShowPreviousJob.Message & vbCrLf & exShowPreviousJob.StackTrace, vbCritical, "Event Error: ShowPreviousJob")
        End Try
    End Sub


    Public Sub loadServiceItem(ByVal strTempJFJobCode As String, ByVal tmpServiceItemControl As ListView)






        Dim tmpServiceItemConnection As New OleDbConnection(strProvider)
        tmpServiceItemConnection.Open()


        Dim strSQLserviceItem As String = "Select ServiceItem.Item from ServiceItem where ServiceItem.JobCode='" & strTempJFJobCode & "'"
        Dim dcServiceItem As New OleDbCommand(strSQLserviceItem, tmpServiceItemConnection)
        Dim drServiceItem As OleDbDataReader = Nothing

        drServiceItem = dcServiceItem.ExecuteReader


        If drServiceItem.HasRows = True Then
            Dim lstTempServiceItem As ListViewItem = Nothing

            Dim shrtServiceItemCount As Short = 0


            While drServiceItem.Read

                shrtServiceItemCount = shrtServiceItemCount + 1

                lstTempServiceItem = tmpServiceItemControl.Items.Add(shrtServiceItemCount)
                lstTempServiceItem.SubItems.Add(drServiceItem("Item").ToString)


            End While



        End If







    End Sub








    Public Sub loadFaultList(ByVal strTempJFJobCode As String, ByVal tmpFaultListControl As ListView)





        Dim tmpFaultListConnection As New OleDbConnection(strProvider)
        tmpFaultListConnection.Open()


        Dim strSQLFaultList As String = "Select CustomerClaim.ClaimCode from CustomerClaim where CustomerClaim.JobCode='" & strTempJFJobCode & "'"
        Dim strSQLCustomerClaimOthers As String = "Select CustomerClaimothers.ClaimCode from CustomerClaimothers where CustomerClaimothers.JobCode='" & strTempJFJobCode & "'"



        Dim dcFaultList As New OleDbCommand(strSQLFaultList, tmpFaultListConnection)
        Dim dcCustomerClaimOthers As New OleDbCommand(strSQLCustomerClaimOthers, tmpFaultListConnection)


        Dim drFaultList As OleDbDataReader = Nothing
        Dim drCustomerClaimOthers As OleDbDataReader = Nothing
        Dim shrtServiceItemCount As Short = 0

        drCustomerClaimOthers = dcCustomerClaimOthers.ExecuteReader




        drFaultList = dcFaultList.ExecuteReader


        If drFaultList.HasRows = True Then
            Dim lstTempServiceItem As ListViewItem = Nothing




            While drFaultList.Read

                shrtServiceItemCount = shrtServiceItemCount + 1

                lstTempServiceItem = tmpFaultListControl.Items.Add(shrtServiceItemCount)
                lstTempServiceItem.SubItems.Add(drFaultList("ClaimCode").ToString)

            End While


            If drCustomerClaimOthers.HasRows = True Then
                drCustomerClaimOthers.Read()
                shrtServiceItemCount = shrtServiceItemCount + 1
                lstTempServiceItem = tmpFaultListControl.Items.Add(shrtServiceItemCount)
                lstTempServiceItem.SubItems.Add(drCustomerClaimOthers("Claimcode").ToString)
            End If


        End If



        drCustomerClaimOthers.Close()
        drFaultList.Close()

        dcCustomerClaimOthers.Dispose()
        dcFaultList.Dispose()
        tmpFaultListConnection.Dispose()




    End Sub






    Public Sub LoadTechnicianCode(ByVal Tempcontrol As Control)







        'Dim tmpObjEmpCode

        'Dim ConLoadTechnicianCode As New OleDbConnection(strProvider)
        'ConLoadTechnicianCode.Open()
        'Dim strLoadTechnicianCode = ""
        'strLoadTechnicianCode = "Select distinct Personal.EmpCode from Personal"
        'Dim dcLoadTechnicianCode As New OleDbCommand(strLoadTechnicianCode, ConLoadTechnicianCode)
        'Dim drLoadTechnicianCode As OleDbDataReader = Nothing









        'Try


        '    tmpObjEmpCode = TempControl



        '    drLoadTechnicianCode = dcLoadTechnicianCode.ExecuteReader


        '    If TypeOf tmpObjEmpCode Is ComboBox Then

        '        Dim tmpCombo As New ComboBox
        '        tmpCombo = tmpObjEmpCode


        '        tmpCombo.Items.Clear()


        '        If drLoadTechnicianCode.HasRows = True Then
        '            While drLoadTechnicianCode.Read
        '                tmpCombo.Items.Add(drLoadTechnicianCode("EmpCode").ToString)

        '            End While

        '        End If




        '        tmpCombo = Nothing





        '    End If


        '    'drLoadTechnicianCode.Close()

        '    'dcLoadTechnicianCode.Dispose()
        '    tmpObjEmpCode = Nothing

        'Catch ex As Exception
        '    MsgBox(ex.Message, vbCritical, "Event Error: LoadTechnicianCode")
        'End Try

        'TempDatareaderClose(drLoadTechnicianCode)
        'TempCommandDispose(dcLoadTechnicianCode)
        'TempConnectionDispose(ConLoadTechnicianCode)

    End Sub



    Public Sub TechnicianName(ByVal strtmpTechnicianName As String, ByVal TempEmpNameControl As Control)
        Dim tmpObjEmpName = Nothing
        Dim conTechnicianName As New OleDbConnection(strProvider)

        Try


            conTechnicianName.Open()
            Dim strTechnicianName As String = ""

            strTechnicianName = "Select Personal.EmpName from Personal where Personal.EmpCOde='" & strtmpTechnicianName & "'"



            Dim dcTechnicianName As New OleDbCommand(strTechnicianName, conTechnicianName)

            Dim drTechnicianName As OleDbDataReader = Nothing

            drTechnicianName = dcTechnicianName.ExecuteReader


            tmpObjEmpName = TempEmpNameControl

            If drTechnicianName.HasRows = True Then
                drTechnicianName.Read()


                If TypeOf tmpObjEmpName Is Label Then
                    Dim tmpLabel As New Label

                    tmpLabel = tmpObjEmpName

                    tmpLabel.Text = drTechnicianName("EmpName").ToString


                ElseIf TypeOf tmpObjEmpName Is TextBox Then
                    Dim tmpTextbox As New TextBox

                    tmpTextbox = tmpObjEmpName
                    tmpTextbox.Text = drTechnicianName("EmpName").ToString




                End If
            Else

                If TypeOf tmpObjEmpName Is Label Then
                    Dim tmpLabel As New Label

                    tmpLabel = tmpObjEmpName

                    tmpLabel.Text = "Missing Name"


                ElseIf TypeOf tmpObjEmpName Is TextBox Then
                    Dim tmpTextbox As New TextBox

                    tmpTextbox = tmpObjEmpName
                    tmpTextbox.Text = "Missing Name"

                End If

            End If


            TempCommandDispose(dcTechnicianName)
            TempDatareaderClose(drTechnicianName)

        Catch EXTechnicianName As Exception
            MsgBox(EXTechnicianName.Message)
        End Try

        TempConnectionDispose(conTechnicianName)

    End Sub


    'Public Sub InsertPendingReason(ByVal strPendingJob As String, ByVal TempPendingReason As String)

    '    Dim ConPendingReason As New OleDbConnection(strProdiver)
    '    ConPendingReason.Open()
    '    Dim strUpdateClaiminfo = ""

    '    Dim strPendingReason As String = ""


    '    If TempPendingReason <> "Others" Then
    '        strPendingReason = "Insert into Pending(JobCode,PenCode)values('" & strPendingJob & "','" & TempPendingReason & "')"
    '        Dim dcPendingReason As New OleDbCommand(strPendingReason, ConPendingReason)
    '        dcPendingReason.ExecuteNonQuery()
    '        dcPendingReason.Dispose()

    '    End If

    '    ConPendingReason.Dispose()






    'End Sub


    'Public Sub InsertPendingOthers(ByVal strPendingOtherJob As String, ByVal TempPendingReasonOther As String)
    '    Dim ConPendingReasonOthers As New OleDbConnection(strProdiver)
    '    ConPendingReasonOthers.Open()
    '    Dim strPendingReasonOther As String = ""

    '    If TempPendingReasonOther = "Others" Then
    '        strPendingReasonOther = "Insert into PendingOther(JobCode,PenCode)values('" & strPendingOtherJob & "','" & TempPendingReasonOther & "')"
    '        Dim dcPendingReasonOther As New OleDbCommand(strPendingReasonOther, ConPendingReasonOthers)
    '        dcPendingReasonOther.ExecuteNonQuery()
    '        dcPendingReasonOther.Dispose()
    '    End If
    '    ConPendingReasonOthers.Dispose()

    'End Sub





    'Public Sub RemovependingReason()

    'End Sub


    Public Sub DeleteRecord(ByVal tmpTableName As String, ByVal tmpWhereClause As String, ByVal MessageNotification_ON_OFF As String)


        MessageNotification_ON_OFF = UCase(MessageNotification_ON_OFF)

        If (MessageNotification_ON_OFF <> "ON") And MessageNotification_ON_OFF <> "OFF" Then
            MsgBox("You only type ON/OFF", vbInformation, "Notify ON/OFF")
            Exit Sub

        End If


        Dim ConDeleteConnection As New OleDbConnection(strProvider)
        ConDeleteConnection.Open()
        Dim strDeleteRecord As String = ""

        If tmpWhereClause <> "" Then
            strDeleteRecord = "Delete * from " & tmpTableName & " Where " & tmpWhereClause
        Else
            strDeleteRecord = "Delete * from " & tmpTableName
        End If



        If MessageNotification_ON_OFF = "ON" Then
            If MsgBox("Do you want to Delete Record from Database", vbInformation + vbYesNo, "Delete Notification") = vbYes Then
                Dim dcDeleteRecord As New OleDbCommand(strDeleteRecord, ConDeleteConnection)
                dcDeleteRecord.ExecuteNonQuery()
                dcDeleteRecord.Dispose()

            End If
        Else
            Dim dcDeleteRecord As New OleDbCommand(strDeleteRecord, ConDeleteConnection)
            dcDeleteRecord.ExecuteNonQuery()

            dcDeleteRecord.Dispose()

        End If

        TempConnectionDispose(ConDeleteConnection)





    End Sub




    Public Sub InsertNewRecord(ByVal strTmpConnection As String, ByVal tmpTableName As String, ByVal tmpColumns As String, ByVal tmpValues As String)

        Dim ConInsertNewRecord As New OleDbConnection(strTmpConnection)


        Dim strSQLInsertNewRecord As String = ""

        strSQLInsertNewRecord = "Insert into " & tmpTableName & "(" & tmpColumns & ") Values (" & tmpValues & ")"

        Dim dcInsertNewRecord As New OleDbCommand(strSQLInsertNewRecord, ConInsertNewRecord)

        Try
            ConInsertNewRecord.Open()
            dcInsertNewRecord.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message & "  " & ex.StackTrace, vbCritical, "Event Error: InsertNewRecord")

        End Try


        dcInsertNewRecord.Dispose()
        'ConInsertNewRecord.Close()

        ConInsertNewRecord.Dispose()



    End Sub



    Public Function RecordVerification(ByVal strTempConnection As String, ByVal tmpTableName As String, ByVal tmpWhereClause As String) As Boolean
        RecordVerification = False


        Dim ConVerification As New OleDbConnection(strTempConnection)
        Dim strSQLCriteria As String = ""
        strSQLCriteria = "Select * from " & tmpTableName & " Where " & tmpWhereClause

        Dim dcVerification As OleDbCommand = Nothing


        Try



            dcVerification = New OleDbCommand(strSQLCriteria, ConVerification)



            Dim drVerification As OleDbDataReader = Nothing
            ConVerification.Open()
            drVerification = dcVerification.ExecuteReader



            If drVerification.HasRows = True Then

                dcVerification.Dispose()
                ConVerification.Close()
                ConVerification.Dispose()
                Return True
            End If




            dcVerification.Dispose()
            ConVerification.Close()
            ConVerification.Dispose()
            Return False



        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Event Error:RecordVerification ")
            ConVerification.Close()
            dcVerification.Dispose()
            ConVerification.Dispose()

        End Try


    End Function


















    Public Function RecordVerification1(ByVal strTempConnection As String, ByVal tmpTableName As String, ByVal tmpWhereClause As String, ByVal ConVerification As OleDbConnection) As Boolean



        'Dim ConVerification As New OleDbConnection(strTempConnection)
        Dim strSQLCriteria As String = ""
        strSQLCriteria = "Select * from " & tmpTableName & " Where " & tmpWhereClause
        Dim blnFlag As Boolean = False
        Dim dcVerification As OleDbCommand = Nothing


        Try



            dcVerification = New OleDbCommand(strSQLCriteria, ConVerification)



            Dim drVerification As OleDbDataReader = Nothing
            'ConVerification.Open()
            drVerification = dcVerification.ExecuteReader



            If drVerification.HasRows = True Then

                dcVerification.Dispose()
                '   ConVerification.Close()

                'ConVerification.Dispose()

                blnFlag = True

            End If




            dcVerification.Dispose()
            'ConVerification.Close()
            'ConVerification.Dispose()

            blnFlag = False

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Event Error:RecordVerification ")
            'ConVerification.Close()
            dcVerification.Dispose()
            'ConVerification.Dispose()

        End Try
        Return blnFlag

    End Function























    Public Sub TempDatareaderClose(ByVal tmpOledbdatareader As OleDbDataReader)


        If tmpOledbdatareader Is Nothing Then
            Exit Sub
        ElseIf tmpOledbdatareader.IsClosed = False Then
            tmpOledbdatareader.Close()

        End If





    End Sub

    Public Sub TempCommandDispose(ByVal tmpoledbCommand As OleDbCommand)

        If tmpoledbCommand Is Nothing Then
            Exit Sub
        ElseIf tmpoledbCommand.Connection.State = ConnectionState.Open Then
            tmpoledbCommand.Dispose()


        End If

    End Sub

    Public Sub TempConnectionDispose(ByVal tmpOledbConnection As OleDbConnection)

        If tmpOledbConnection Is Nothing Then
            Exit Sub
        ElseIf tmpOledbConnection.State = ConnectionState.Open Then

            tmpOledbConnection.Dispose()



        End If



    End Sub
    '

    Public Sub LoadAllInformation(ByVal OledbTempConnection As OleDbConnection, ByRef tempDatareader As OleDbDataReader, ByVal strTempConnection As String, ByVal TableName As String, ByVal ColumnName As String, ByVal tempWhereClause As String)

        'Dim conLoadAllInformation As New OleDbConnection(strTempConnection)





        Dim strSQLLoadAllInformation As String = ""

        If tempWhereClause = "''" Or tempWhereClause = "" Then
            strSQLLoadAllInformation = "Select " & ColumnName & " from " & TableName
        Else

            strSQLLoadAllInformation = "Select " & ColumnName & " from " & TableName & " Where " & tempWhereClause
        End If


        Dim dcLoadAllinformation As New OleDbCommand(strSQLLoadAllInformation, OledbTempConnection)

        If OledbTempConnection.State = ConnectionState.Closed Then
            OledbTempConnection.Open()
        End If



        tempDatareader = dcLoadAllinformation.ExecuteReader




        'TempConnectionDispose(conLoadAllInformation)

    End Sub


    Public Sub ProductStatusVerify_and_Delete(ByVal strTempCflag As String)

        Select Case strTempCflag

            Case "99" 'N/R
                DeleteRecord("NRDetails", "NRDetails.JobCode='" & strtmpJobCode & "'", "OFF")
                DeleteRecord("NRDetailsReport", "NRDetailsReport.JobCode='" & strtmpJobCode & "'", "OFF")
                DeleteRecord("NROthers", "NROthers.JobCode='" & strtmpJobCode & "'", "OFF")
                DeleteRecord("NROthersReport", "NROthersReport.JobCode='" & strtmpJobCode & "'", "OFF")
            Case "100" 'N/R Customer Return
                DeleteRecord("NRDetails", "NRDetails.JobCode='" & strtmpJobCode & "'", "OFF")
                DeleteRecord("NRDetailsReport", "NRDetailsReport.JobCode='" & strtmpJobCode & "'", "OFF")
                DeleteRecord("NROthers", "NROthers.JobCode='" & strtmpJobCode & "'", "OFF")
                DeleteRecord("NROthersReport", "NROthersReport.JobCode='" & strtmpJobCode & "'", "OFF")
            Case "1" ' Service
                If strtmpMRNo = "Est Refuse" Then
                    DeleteRecord("EstimateRefused", "EstimateRefused.JobCode='" & strtmpJobCode & "'", "OFF")
                Else
                    DeleteRecord("ServiceDetails", "ServiceDetails.JobCode='" & strtmpJobCode & "'", "OFF")
                    DeleteRecord("ServiceDetailsReport", "ServiceDetailsReport.JobCode='" & strtmpJobCode & "'", "OFF")
                End If
            Case "0" ' Delivery
                If strtmpMRNo = "Est Refuse" Then
                    DeleteRecord("EstimateRefused", "EstimateRefused.JobCode='" & strtmpJobCode & "'", "OFF")
                Else
                    DeleteRecord("ServiceDetails", "ServiceDetails.JobCode='" & strtmpJobCode & "'", "OFF")
                    DeleteRecord("ServiceDetailsReport", "ServiceDetailsReport.JobCode='" & strtmpJobCode & "'", "OFF")
                End If

            Case "2" ' Delivery
                If strtmpMRNo = "Est Refuse" Then
                    DeleteRecord("EstimateRefused", "EstimateRefused.JobCode='" & strtmpJobCode & "'", "OFF")
                Else
                    DeleteRecord("ServiceDetails", "ServiceDetails.JobCode='" & strtmpJobCode & "'", "OFF")
                    DeleteRecord("ServiceDetailsReport", "ServiceDetailsReport.JobCode='" & strtmpJobCode & "'", "OFF")
                End If

            Case "9" ' Pending
                DeleteRecord("Pending", "Pending.JobCode='" & strtmpJobCode & "'", "OFF")
                DeleteRecord("PendingReport", "PendingReport.JobCode='" & strtmpJobCode & "'", "OFF")
                DeleteRecord("PendingOther", "PendingOther.JobCode='" & strtmpJobCode & "'", "OFF")
                DeleteRecord("PendingOtherReport", "PendingOtherReport.JobCode='" & strtmpJobCode & "'", "OFF")
            Case "101" ' Non Warranty Replace

                DeleteRecord("Replace", "Replace.JobCode='" & strtmpJobCode & "'", "OFF")

            Case "102" ' Replace Sales Warr and Service Warr

                DeleteRecord("Replace", "Replace.JobCode='" & strtmpJobCode & "'", "OFF")

        End Select



    End Sub




    Public Sub FormOpecityDecrease(ByVal frmOpecityDecrease As Form, ByVal dblOpecityDecrease As Double)




        frmOpecityDecrease.Opacity = dblOpecityDecrease


    End Sub


    Public Sub FormOpecityIncrease(ByVal frmOpecityIncrease As Form, ByVal dblOpecityIncrease As Double)

        frmOpecityIncrease.AllowTransparency = True

        frmOpecityIncrease.Opacity = dblOpecityIncrease



    End Sub



    Public Sub GotFucus(sender As Object, e As KeyEventArgs, tmpAllControl As Control)

        If e.KeyCode = Keys.Enter Then
            tmpAllControl.Select()

        End If


    End Sub



    Public Sub ResizeControl(ByVal frmTemp As Form, ByVal TempObj As Control, ByVal IntLeft As Integer, ByVal shrtDivideby As Short)


        TempObj.Left = IntLeft
        TempObj.Width = frmTemp.ClientSize.Width / shrtDivideby




    End Sub



    <Runtime.InteropServices.StructLayout(Runtime.InteropServices.LayoutKind.Sequential)> Public Structure side
        Public Left As Integer
        Public Right As Integer
        Public Top As Integer
        Public Bottom As Integer
    End Structure
    <Runtime.InteropServices.DllImport("dwmapi.dll")> Public Function DwmExtendFrameIntoClientArea(ByVal hwnd As IntPtr, ByRef MSide As side) As Integer



    End Function


    Public Function sideP() As side

        Dim Iside As New side
        Iside.Left = -1
        Iside.Right = 1
        Iside.Top = -1
        Iside.Bottom = 1

        sideP = Iside




    End Function

































































































    Public Function Spellnumber(ByVal Mynumber)
        Dim Result As String
        ' Convert Hundred 1 to 99
        ' Here is started the length 2
        '
        '

        If Len(Mynumber) = 0 Or Mynumber = "0" Then
            Mynumber = "In Word: No Taka "
            Result = Mynumber
            Return Mynumber

        End If




        If Len(Mynumber) = 2 Or Len(Mynumber) = 1 Then
            Result = GetDigit(Right(Mynumber, 2))
            Return "(Total Amount In Word: " & Result & " Taka Only)"

        End If

        ' Convert Hundred 100 to 999
        ' Here is started the length 3
        '
        If Len(Mynumber) = 3 Then
            Result = GetDigit(Left(Mynumber, 1)) & " Hundred And "
            Result = Result & GetDigit(Right(Mynumber, 2))
            Return "(Total Amount In Word: " & Result & " Taka Only)"

        End If



        ' Here is started the length 4
        '
        '



        If Len(Mynumber) = 4 And Mid(Mynumber, 2, 1) = "0" Then
            Result = GetDigit(Left(Mynumber, 1)) & " Thousand "
            Result = Result + GetDigit(Right(Mynumber, 2))
            Return "(Total Amount In Word: " & Result & " Taka Only)"

        End If

        If Len(Mynumber) = 4 And Right(Mynumber, 3) = "000" Then
            Result = GetDigit(Left(Mynumber, 1)) & " Thousand "
            Return "(Total Amount In Word: " & Result & " Taka Only)"

        End If

        If Len(Mynumber) = 4 And (Not (Right(Mynumber, 3)) = "000") Then
            Result = GetDigit(Left(Mynumber, 1)) & " Thousand "
            Result = Result + GetDigit(Mid(Mynumber, 2, 1)) & " Hundred And "
            Result = Result + GetDigit(Right(Mynumber, 2))
            Return "(Total Amount In Word: " & Result & " Taka Only)"

        End If



        ' Here is started the length 5
        '
        '




        If Len(Mynumber) = 5 And Mid(Mynumber, 3, 3) = "000" Then
            Result = GetDigit(Left(Mynumber, 2)) & " Thousand "
            Return "(Total Amount In Word: " & Result & " Taka Only)"

        Else
        End If


        If Len(Mynumber) = 5 And Mid(Mynumber, 3, 1) = "0" Then
            Result = GetDigit(Left(Mynumber, 2)) & " Thousand "
            Result = Result & GetDigit(Right(Mynumber, 2))
            Return "(Total Amount In Word: " & Result & " Taka Only)"

        End If

        If Len(Mynumber) = 5 And (Not (Right(Mynumber, 3)) = "000") Then
            Result = GetDigit(Left(Mynumber, 2)) & " Thousand "
            Result = Result & GetDigit(Mid(Mynumber, 3, 1)) & " Hundred And "
            Result = Result & GetDigit(Right(Mynumber, 2))
            Return "(Total Amount In Word: " & Result & " Taka Only)"

        End If



        ' Here is started the length 6
        '
        '





        If Len(Mynumber) = 6 And (Right(Mynumber, 5)) = "00000" Then
            Result = GetDigit(Left(Mynumber, 1)) & " Lac "
            Return "(Total Amount In Word: " & Result & " Taka Only)"

        End If

        If Len(Mynumber) = 6 And (Mid(Mynumber, 2, 3)) = "000" Then
            Result = GetDigit(Left(Mynumber, 1)) & " Lac "
            Result = Result & GetDigit(Right(Mynumber, 2))
            Return "(Total Amount In Word: " & Result & " Taka Only)"

        End If

        If Len(Mynumber) = 6 And (Mid(Mynumber, 2, 2) = "00") Then
            Result = GetDigit(Left(Mynumber, 1)) & " Lac "
            Result = Result & GetDigit(Mid(Mynumber, 4, 1)) & " Hundred And "
            Result = Result & GetDigit(Right(Mynumber, 2))
            Return "(Total Amount In Word: " & Result & " Taka Only)"

        End If


        If Len(Mynumber) = 6 And (Mid(Mynumber, 4, 1) = "0") Then
            Result = GetDigit(Left(Mynumber, 1)) & " Lac "
            Result = Result & GetDigit(Mid(Mynumber, 2, 2)) & " Thousand "
            Result = Result & GetDigit(Right(Mynumber, 2))
            Return "(Total Amount In Word: " & Result & " Taka Only)"

        End If



        If Len(Mynumber) = 6 And (Not (Mid(Mynumber, 2, 5)) = "00000") Then
            Result = GetDigit(Left(Mynumber, 1)) & " Lac "
            Result = Result & GetDigit(Mid(Mynumber, 2, 2)) & " Thousand "
            Result = Result & GetDigit(Mid(Mynumber, 4, 1)) & " Hundred And "
            Result = Result & GetDigit(Right(Mynumber, 2))
            Return "(Total Amount In Word: " & Result & " Taka Only)"

        End If



        ' Here is started the length 7
        '
        '



        If Len(Mynumber) = 7 And (Right(Mynumber, 5)) = "00000" Then
            Result = GetDigit(Left(Mynumber, 2)) & " Lac "
            Return "(Total Amount In Word: " & Result & " Taka Only)"

        End If

        If Len(Mynumber) = 7 And (Mid(Mynumber, 3, 3)) = "000" Then
            Result = GetDigit(Left(Mynumber, 2)) & " Lac "
            Result = Result & GetDigit(Right(Mynumber, 2))
            Return "(Total Amount In Word: " & Result & " Taka Only)"

        End If

        If Len(Mynumber) = 7 And (Mid(Mynumber, 3, 2) = "00") Then
            Result = GetDigit(Left(Mynumber, 2)) & " Lac "
            Result = Result & GetDigit(Mid(Mynumber, 5, 1)) & " Hundred And "
            Result = Result & GetDigit(Right(Mynumber, 2))
            Return "(Total Amount In Word: " & Result & " Taka Only)"

        End If

        If Len(Mynumber) = 7 And (Mid(Mynumber, 5, 1) = "0") Then
            Result = GetDigit(Left(Mynumber, 2)) & " Lac "
            Result = Result & GetDigit(Mid(Mynumber, 3, 2)) & " Thousand "
            Result = Result & GetDigit(Right(Mynumber, 2))
            Return "(Total Amount In Word: " & Result & " Taka Only)"

        End If




        If Len(Mynumber) = 7 And (Not (Mid(Mynumber, 2, 5)) = "00000") Then
            Result = GetDigit(Left(Mynumber, 2)) & " Lac "
            Result = Result & GetDigit(Mid(Mynumber, 3, 2)) & " Thousand "
            Result = Result & GetDigit(Mid(Mynumber, 5, 1)) & " Hundred And "
            Result = Result & GetDigit(Right(Mynumber, 2))
            Return "(Total Amount In Word: " & Result & " Taka Only)"

        End If




        ' Here is started the length 8
        '
        '




        If Len(Mynumber) = 8 And (Right(Mynumber, 6)) = "000000" Then
            Result = GetDigit(Left(Mynumber, 1)) & " Corrore "
            Return "(Total Amount In Word: " & Result & " Taka Only)"

        End If

        If Len(Mynumber) = 8 And (Mid(Mynumber, 2, 5)) = "00000" Then
            Result = GetDigit(Left(Mynumber, 2)) & " Corrore "
            Result = Result & GetDigit(Right(Mynumber, 2))
            Return "(Total Amount In Word: " & Result & " Taka Only)"

        End If


        If Len(Mynumber) = 8 And (Mid(Mynumber, 2, 4)) = "0000" Then
            Result = GetDigit(Left(Mynumber, 2)) & " Corrore "
            Result = Result & GetDigit(Mid(Mynumber, 6, 1)) & " Hundred And "
            Result = Result & GetDigit(Right(Mynumber, 2))
            Return "(Total Amount In Word: " & Result & " Taka Only)"

        End If




        If Len(Mynumber) = 8 And (Mid(Mynumber, 2, 2) = "00") And (Not (Mid(Mynumber, 6, 3)) = "000") Then
            Result = GetDigit(Left(Mynumber, 1)) & " Corrore "
            Result = Result & GetDigit(Mid(Mynumber, 4, 2)) & " Thousand "
            Result = Result & GetDigit(Mid(Mynumber, 6, 1)) & " Hundred And "
            Result = Result & GetDigit(Right(Mynumber, 2))
            Return "(Total Amount In Word: " & Result & " Taka Only)"

        End If


        If Len(Mynumber) = 8 And (Mid(Mynumber, 2, 2)) = "00" And Mid(Mynumber, 6, 3) = "000" Then
            Result = GetDigit(Left(Mynumber, 1)) & " Corrore "
            Result = Result & GetDigit(Mid(Mynumber, 4, 2)) & " Thousand "
            Return "(Total Amount In Word: " & Result & " Taka Only)"

        End If



        If Len(Mynumber) = 8 And (Mid(Mynumber, 6, 1) = "0") Then
            Result = GetDigit(Left(Mynumber, 1)) & " Corrore "
            Result = Result & GetDigit(Mid(Mynumber, 2, 2)) & " Lac "
            Result = Result & GetDigit(Mid(Mynumber, 4, 2)) & " Thousand "
            Result = Result & GetDigit(Right(Mynumber, 2))
            Return "(Total Amount In Word: " & Result & " Taka Only)"

        End If




        If Len(Mynumber) = 8 And (Not (Mid(Mynumber, 2, 7)) = "0000000") Then
            Result = GetDigit(Left(Mynumber, 1)) & " Corrore "
            Result = Result & GetDigit(Mid(Mynumber, 2, 2)) & " Lac "
            Result = Result & GetDigit(Mid(Mynumber, 4, 2)) & " Thousand "
            Result = Result & GetDigit(Mid(Mynumber, 6, 1)) & " Hundred And "
            Result = Result & GetDigit(Right(Mynumber, 2))
            Return "(Total Amount In Word: " & Result & " Taka Only)"

        End If









        ' Here is started the length 9
        '
        '


        If Len(Mynumber) = 9 And (Right(Mynumber, 8)) = "00000000" Then
            Result = GetDigit(Left(Mynumber, 2)) & " Corrore "
            Return "(Total Amount In Word: " & Result & " Taka Only)"

        End If



        If Len(Mynumber) = 9 And (Mid(Mynumber, 2, 6)) = "000000" Then
            Result = GetDigit(Left(Mynumber, 2)) & " Corrore "
            Result = Result & GetDigit(Right(Mynumber, 2))
            Return "(Total Amount In Word: " & Result & " Taka Only)"

        End If


        If Len(Mynumber) = 9 And (Mid(Mynumber, 3, 4)) = "0000" Then
            Result = GetDigit(Left(Mynumber, 2)) & " Corrore "
            Result = Result & GetDigit(Mid(Mynumber, 7, 1)) & " Hundred And "
            Result = Result & GetDigit(Right(Mynumber, 2))
            Return "(Total Amount In Word: " & Result & " Taka Only)"

        End If



        If Len(Mynumber) = 9 And (Mid(Mynumber, 3, 3)) = "000" And Mid(Mynumber, 7, 1) = "0" Then
            Result = GetDigit(Left(Mynumber, 2)) & " Corrore "
            Result = Result & GetDigit(Mid(Mynumber, 5, 2)) & " Thousand "
            Result = Result & GetDigit(Right(Mynumber, 2))
            Return "(Total Amount In Word: " & Result & " Taka Only)"

        End If



        If Len(Mynumber) = 9 And (Mid(Mynumber, 3, 7)) = "0000000" Then
            Result = GetDigit(Left(Mynumber, 2)) & " Corrore "
            Result = Result & GetDigit(Mid(Mynumber, 5, 2)) & " Thousand "
            Result = Result & GetDigit(Mid(Mynumber, 7, 1)) & " Hundred And "
            Result = Result & GetDigit(Right(Mynumber, 2))
            Return "(Total Amount In Word: " & Result & " Taka Only)"

        End If


        If Len(Mynumber) = 9 And (Mid(Mynumber, 5, 2)) = "00" And (Not (Mid(Mynumber, 7, 1)) = "0") Then
            Result = GetDigit(Left(Mynumber, 2)) & " Corrore "
            Result = Result & GetDigit(Mid(Mynumber, 3, 2)) & " Lac "
            Result = Result & GetDigit(Mid(Mynumber, 7, 1)) & " Hundred And "
            Result = Result & GetDigit(Right(Mynumber, 2))
            Return "(Total Amount In Word: " & Result & " Taka Only)"

        End If


        If Len(Mynumber) = 9 And (Mid(Mynumber, 3, 2)) = "00" And (Not (Mid(Mynumber, 7, 1)) = "0") Then
            Result = GetDigit(Left(Mynumber, 2)) & " Corrore "
            Result = Result & GetDigit(Mid(Mynumber, 5, 2)) & " Thousand "
            Result = Result & GetDigit(Mid(Mynumber, 7, 1)) & " Hundred And "
            Result = Result & GetDigit(Right(Mynumber, 2))
            Return "(Total Amount In Word: " & Result & " Taka Only)"

        End If

        If Len(Mynumber) = 9 And (Mid(Mynumber, 3, 2)) = "00" And (Mid(Mynumber, 7, 1)) = "0" Then
            Result = GetDigit(Left(Mynumber, 2)) & " Corrore "
            Result = Result & GetDigit(Mid(Mynumber, 5, 2)) & " Thousand "
            Result = Result & GetDigit(Right(Mynumber, 2))
            Return "(Total Amount In Word: " & Result & " Taka Only)"

        End If


        If Len(Mynumber) = 9 And (Mid(Mynumber, 7, 1)) = "0" Then
            Result = GetDigit(Left(Mynumber, 2)) & " Corrore "
            Result = Result & GetDigit(Mid(Mynumber, 3, 2)) & " Lac "
            Result = Result & GetDigit(Mid(Mynumber, 5, 2)) & " Thousand "
            Result = Result & GetDigit(Right(Mynumber, 2))
            Return "(Total Amount In Word: " & Result & " Taka Only)"

        End If

        If Len(Mynumber) = 9 And (Not (Right(Mynumber, 7)) = "0000000") Then
            Result = GetDigit(Left(Mynumber, 2)) & " Corrore "
            Result = Result & GetDigit(Mid(Mynumber, 3, 2)) & " Lac "
            Result = Result & GetDigit(Mid(Mynumber, 5, 2)) & " Thousand "
            Result = Result & GetDigit(Mid(Mynumber, 7, 1)) & " Hundred And "
            Result = Result & GetDigit(Right(Mynumber, 2))
            Return "(Total Amount In Word: " & Result & " Taka Only)"

        End If

        If Len(Mynumber) > 9 Then
            Mynumber = "Length is out of range"
            Result = Mynumber
            Return Result

        End If
        Return True
    End Function


    ' Converts a number from 1 to 9 into text.
    Public Function GetDigit(ByVal Digit) As String
        Select Case Digit
            Case 0 : Digit = ""
            Case 1 : Digit = "One"
            Case 2 : Digit = "Two"
            Case 3 : Digit = "Three"
            Case 4 : Digit = "Four"
            Case 5 : Digit = "Five"
            Case 6 : Digit = "Six"
            Case 7 : Digit = "Seven"
            Case 8 : Digit = "Eight"
            Case 9 : Digit = "Nine"
            Case 10 : Digit = "Ten"
            Case 11 : Digit = "Eleven"
            Case 12 : Digit = "Twelve"
            Case 13 : Digit = "Thirteen"
            Case 14 : Digit = "Fourteen"
            Case 15 : Digit = "Fifteen"
            Case 16 : Digit = "Sixteen"
            Case 17 : Digit = "Seventeen"
            Case 18 : Digit = "Eighteen"
            Case 19 : Digit = "Nineteen"
            Case 20 : Digit = "Twenty "
            Case 21 : Digit = "Twenty One"
            Case 22 : Digit = "Twenty Two"
            Case 23 : Digit = "Twenty Three"
            Case 24 : Digit = "Twenty Four"
            Case 25 : Digit = "Twenty Five"
            Case 26 : Digit = "Twenty Six"
            Case 27 : Digit = "Twenty Seven"
            Case 28 : Digit = "Twenty Eight"
            Case 29 : Digit = "Twenty Nine"
            Case 30 : Digit = "Thirty "
            Case 31 : Digit = "Thirty One"
            Case 32 : Digit = "Thirty Two"
            Case 33 : Digit = "Thirty Three"
            Case 34 : Digit = "Thirty Four"
            Case 35 : Digit = "Thirty Five"
            Case 36 : Digit = "Thirty Six"
            Case 37 : Digit = "Thirty Seven"
            Case 38 : Digit = "Thirty Eight"
            Case 39 : Digit = "Thirty Nine"
            Case 40 : Digit = "Forty "
            Case 41 : Digit = "Forty One"
            Case 42 : Digit = "Forty Two"
            Case 43 : Digit = "Forty Three"
            Case 44 : Digit = "Forty Four"
            Case 45 : Digit = "Forty Five"
            Case 46 : Digit = "Forty Six"
            Case 47 : Digit = "Forty Seven"
            Case 48 : Digit = "Forty Eight"
            Case 49 : Digit = "Forty Nine"
            Case 50 : Digit = "Fifty "
            Case 51 : Digit = "Fifty One"
            Case 52 : Digit = "Fifty Two"
            Case 53 : Digit = "Fifty Three"
            Case 54 : Digit = "Fifty Four"
            Case 55 : Digit = "Fifty Five"
            Case 56 : Digit = "Fifty Six"
            Case 57 : Digit = "Fifty Seven"
            Case 58 : Digit = "Fifty Eight"
            Case 59 : Digit = "Fifty Nine"
            Case 60 : Digit = "Sixty "
            Case 61 : Digit = "Sixty One"
            Case 62 : Digit = "Sixty Two"
            Case 63 : Digit = "Sixty Three"
            Case 64 : Digit = "Sixty Four"
            Case 65 : Digit = "Sixty Five"
            Case 66 : Digit = "Sixty Six"
            Case 67 : Digit = "Sixty Seven"
            Case 68 : Digit = "Sixty Eight"
            Case 69 : Digit = "Sixty Nine"
            Case 70 : Digit = "Seventy "
            Case 71 : Digit = "Seventy One"
            Case 72 : Digit = "Seventy Two"
            Case 73 : Digit = "Seventy Three"
            Case 74 : Digit = "Seventy Four"
            Case 75 : Digit = "Seventy Five"
            Case 76 : Digit = "Seventy Six"
            Case 77 : Digit = "Seventy Seven"
            Case 78 : Digit = "Seventy Eight"
            Case 79 : Digit = "Seventy Nine"
            Case 80 : Digit = "Eighty "
            Case 81 : Digit = "Eighty One"
            Case 82 : Digit = "Eighty Two"
            Case 83 : Digit = "Eighty Three"
            Case 84 : Digit = "Eighty Four"
            Case 85 : Digit = "Eighty Five"
            Case 86 : Digit = "Eighty Six"
            Case 87 : Digit = "Eighty Seven"
            Case 88 : Digit = "Eighty Eight"
            Case 89 : Digit = "Eighty Nine"
            Case 90 : Digit = "Ninety "
            Case 91 : Digit = "Ninety One"
            Case 92 : Digit = "Ninety Two"
            Case 93 : Digit = "Ninety Three"
            Case 94 : Digit = "Ninety Four"
            Case 95 : Digit = "Ninety Five"
            Case 96 : Digit = "Ninety Six"
            Case 97 : Digit = "Ninety Seven"
            Case 98 : Digit = "Ninety Eight"
            Case 99 : Digit = "Ninety Nine"
            Case 100 : Digit = "One Hundred "
        End Select
        Return Digit
    End Function




    Public Function CheckInternetConnection() As String
        Try
            If My.Computer.Network.Ping("www.google.com") Then
                Return "Network Connected to the Internet "
            End If
        Catch ex As Exception
            Return "Network Not Connected to the Internet "
        End Try
        Return True
    End Function





    Public Sub ExportDataIntoExcel(ByVal TempDatagridview As DataGridView)
        Dim xlApp As Object = System.Activator.CreateInstance(System.Type.GetTypeFromProgID("Excel.Application"))
        'Excel.Application
        'xlApp = "Excel.Application"



        Dim xlWorkBook As Object
        Dim xlSheet As Object


        xlWorkBook = xlApp.Workbooks.Add
        xlSheet = xlWorkBook.Sheets("Sheet1")


        Dim intCol As Integer
        Dim intRow As Integer
        Dim intHeaderName As Integer

        For intHeaderName = 0 To TempDatagridview.ColumnCount - 1
            xlSheet.Cells(1, intHeaderName + 1) = TempDatagridview.Columns(intHeaderName).Name


        Next
        Try


            For intRow = 0 To TempDatagridview.Rows().Count - 1
                For intCol = 0 To TempDatagridview.ColumnCount - 1
                    xlSheet.Cells(intRow + 2, intCol + 1) = TempDatagridview.Rows(intRow).Cells(intCol).Value

                Next
            Next

            xlApp.Visible = True
        Catch excelExport As Exception
            MsgBox(excelExport.Message)


        End Try
    End Sub


    Public Sub InputDigit(ByVal TempObj As Object, ByVal e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = Chr(Keys.Back) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub




    'SourceTable = Distinct Value Getting From Table, TargetTable=Insert New Record into Table,
    'DistinctFiled= Getting Distinct Value from SourceTable and Also You Can define only one field, Column to be matched from both table
    'conCatenateField= Gatherig All Duplicate Value into One Row and also it contains multyple Column value
    'InsertFiled= Insert Filed only can define only Two Rows
    Public Sub ConcatenateMultyRow(ByVal SourceTable As String, ByVal TargetTable As String, ByVal DistinctFiled As String, ByVal conCatenateField As String, ByVal InsertFiled As String, ByVal pbLoadTemp As ProgressBar, ByVal lblTempTotalRecord As Label, ByVal lblTempProgress As Label)

        Dim intRecordCount As Integer = 0
        Dim conConcatenate As New OleDbConnection(strProvider)
        Dim drLoadUniqeJob As OleDbDataReader = Nothing
        Dim intCount As Integer = 0
        Dim intLoop As Integer = 0

        If DistinctFiled.Substring(DistinctFiled.Length - 1) = "," Then
                MessageBox.Show("Error in distinctField Please fix the error")
                Exit Sub
            End If


            If SourceTable = "" Or TargetTable = "" Or DistinctFiled = "" Or conCatenateField = "" Or InsertFiled = "" Then
                MessageBox.Show("Please fill All Parameter")
            End If





            For intLoop = 1 To Len(InsertFiled)

                If Mid(InsertFiled, intLoop, 1) = "," Then
                    intCount = intCount + 1
                End If

            Next


            If intCount >= 2 Then ' Verify Insert Field (One Insert Field to be Defined"
                MessageBox.Show("Insert Table More Than two field or something wrong with parameter")
                Exit Sub
            End If



            Dim strGetValue As String = String.Empty

            Dim drTotalRecord As OleDbDataReader = Nothing
            pbLoadTemp.Minimum = 0
            pbLoadTemp.Maximum = 0

            LoadAllInformation(conConcatenate, drLoadUniqeJob, strProvider, SourceTable & " Left Join " & TargetTable & " ON " & SourceTable & "." & DistinctFiled & "=" & TargetTable & "." & DistinctFiled, " Distinct " & SourceTable & "." & DistinctFiled, "Isnull(" & TargetTable & "." & DistinctFiled & ")")

            Dim intLoopJob As Integer = 0

            If drLoadUniqeJob.HasRows = True Then


                lblTempTotalRecord.Refresh()
                'LoadAllInformation(conConcatenate,drLoadUniqeJob,strProvider,)
                ' Count Unqinqe JobNo Table SQL Query: Select Count(ServiceDetails.JobCode) as Qty from (Select Distinct ServiceDetails.JobCode From ServiceDetails)
                'Count Unqinqe JobNo from NonMatched Table SQL Query: Select Count(ServiceDetails.JobCode) as Qty from (Select Distinct ServiceDetails.JobCode From ServiceDetails Left Join ServiceDetailsReport on ServiceDetails.JobCode=ServiceDetailsReport.JobCode where isnull(ServiceDetailsReport.JobCode))

                LoadAllInformation(conConcatenate, drTotalRecord, strProvider, "(Select Distinct " & SourceTable & "." & DistinctFiled & " From " & SourceTable & " left Join " & TargetTable & " ON " & SourceTable & "." & DistinctFiled & "=" & TargetTable & "." & DistinctFiled & " where Isnull(" & TargetTable & "." & DistinctFiled & "))", " count( " & DistinctFiled & ") as TTLJob", "''")

                If drTotalRecord.HasRows = True Then
                    drTotalRecord.Read()
                    pbLoadTemp.Maximum = Convert.ToInt32(drTotalRecord("TTlJob").ToString)
                lblTempTotalRecord.Text = "Total Record :" & Convert.ToInt32(drTotalRecord("TTlJob").ToString)
                lblTempTotalRecord.Refresh()
            End If

                While drLoadUniqeJob.Read
                    intRecordCount = intRecordCount + 1

                    lblTempProgress.Text = intRecordCount.ToString
                    lblTempProgress.Refresh()
                    Dim conLoadServiceDetails As New OleDbConnection(strProvider)
                    Dim dcLoadServiceDetails As New OleDbCommand("Select " & conCatenateField & " from " & SourceTable & " where " & SourceTable & "." & DistinctFiled & "='" & drLoadUniqeJob("JobCode").ToString & "'", conLoadServiceDetails)

                    Dim drLoadCertainJob As OleDbDataReader = Nothing
                    conLoadServiceDetails.Open()
                    drLoadCertainJob = dcLoadServiceDetails.ExecuteReader

                    If drLoadCertainJob.HasRows = True Then
                        While drLoadCertainJob.Read()
                            If UCase(SourceTable) = "SERVICEDETAILS" Then
                                For intLoopJob = 0 To drLoadCertainJob.FieldCount - 1
                                    'If drLoadCertainJob.GetName(intLoopJob).Equals("Qty", StringComparison.InvariantCultureIgnoreCase) Then
                                    '    strGetValue = strGetValue & " Qty : " & drLoadCertainJob(intLoopJob).ToString & " "
                                    'ElseIf drLoadCertainJob.GetName(intLoopJob).Equals("UnitPrice", StringComparison.InvariantCultureIgnoreCase) Then
                                    '    strGetValue = strGetValue & " UnitPrice : " & drLoadCertainJob(intLoopJob).ToString & "."
                                    'Else
                                    '    strGetValue = strGetValue & drLoadCertainJob(intLoopJob).ToString & " "
                                    'End If
                                    strGetValue = strGetValue & drLoadCertainJob(intLoopJob).ToString & " "
                                Next
                                If strGetValue <> "" Then
                                    strGetValue = strGetValue & ","
                                End If
                            Else
                                For intLoopJob = 0 To drLoadCertainJob.FieldCount - 1
                                    strGetValue = strGetValue & drLoadCertainJob(intLoopJob).ToString & ","
                                Next
                            End If



                            'strGetValue = strGetValue & drLoadCertainJob("ProductCode").ToString & " "
                            'strGetValue = strGetValue & drLoadCertainJob("Qty").ToString & " "
                            'strGetValue = strGetValue & drLoadCertainJob("UnitPrice").ToString & " ,"
                        End While
                    End If
                    'strGetValue = strGetValue & "."
                    drLoadCertainJob.Close()
                    TempCommandDispose(dcLoadServiceDetails)
                    TempConnectionDispose(conLoadServiceDetails)

                    If strGetValue <> String.Empty Then

                        Dim conInsertRecord As New OleDbConnection(strProvider)
                        Dim dcInsertRecord As New OleDbCommand("Insert into " & TargetTable & "(" & InsertFiled & ") Values('" & drLoadUniqeJob("JobCode").ToString & "','" & strGetValue & "')", conInsertRecord)

                        conInsertRecord.Open()



                        dcInsertRecord.ExecuteNonQuery()


                        conInsertRecord.Dispose()
                        dcInsertRecord.Dispose()


                    End If

                    strGetValue = String.Empty
                    pbLoadTemp.Value = pbLoadTemp.Value + 1
                    pbLoadTemp.CreateGraphics().DrawString(Math.Round((pbLoadTemp.Value / pbLoadTemp.Maximum) * 100, 1) & "%", New Font("Times New Roman", 10, FontStyle.Regular), Brushes.Red, New PointF(pbLoadTemp.Width / 2 - 10, pbLoadTemp.Height / 2 - 7))
                End While
                'MsgBox(pbLoadTemp.Maximum & " Record Update Successfully", vbInformation)
            End If




        TempDatareaderClose(drLoadUniqeJob)
        TempConnectionDispose(conConcatenate)

    End Sub






    'Public Sub BreakintoMultyColumn()


    '    Dim drLoadMaxComma As OleDbDataReader = Nothing

    '    Dim conMaxComma As New OleDbConnection(strProvider)
    '    Dim intMaxComma As Integer = 0
    '    Dim strMaxCommaRecord As String = String.Empty
    '    Dim intLoop As Integer = 0

    '    Dim strInsertValue As String = String.Empty
    '    Dim strColumn As String = String.Empty


    '    'for Counting Highest Comma in Record
    '    Dim strSQLMaxComma = "SELECT T.ProductCode, T.LN FROM [Select ServiceDetailsTemp.ProductCode,len(ServiceDetailsTemp.ProductCode)-len(Replace(ServiceDetailsTemp.ProductCode,',','')) as LN  from  ServiceDetailsTemp group by ServiceDetailsTemp.ProductCode]. AS T INNER JOIN [Select max(len(ServiceDetailsTemp.ProductCode)-len(Replace(ServiceDetailsTemp.ProductCode,',',''))) as MLN from ServiceDetailsTemp]. AS Tmln ON T.LN=tmln.mln"

    '    Dim dcMaxComma As New OleDbCommand(strSQLMaxComma, conMaxComma)
    '    conMaxComma.Open()
    '    drLoadMaxComma = dcMaxComma.ExecuteReader

    '    If drLoadMaxComma.HasRows = True Then
    '        While drLoadMaxComma.Read
    '            strMaxCommaRecord = drLoadMaxComma("ProductCode").ToString
    '            intMaxComma = drLoadMaxComma("LN").ToString
    '        End While
    '    End If


    '    For intlooop = 1 To Len(strMaxCommaRecord)

    '        If intLoop = 1 Then
    '            strColumn = "Inser into ServiceDetailsTest(ProductCode,Qty,UnitPrice) Values("
    '            strInsertValue = "Select Mid(ServiceDetailsTemp.ProductCode,1,instr(" & intLoop & ",ServiceDetailsTemp.ProductCode,'Qty')-1) as PartNo,"
    '            strInsertValue = strInsertValue & "Mid(ServiceDetailsTemp.ProductCode," & intLoop & "+ Instr(ServiceDetailsTemp.ProductCode,'Qty')+5)),ServiceDetailsTemp.ProductCode,'Rate')-"
    '            strInsertValue = strInsertValue & intLoop & " + Instr(ServiceDetailsTemp.ProductCode,'Qty')+5)) as Qty,"
    '            strInsertValue = strInsertValue & "Mid(ServiceDetailsTemp.ProductCode," & intLoop & "+ Instr(ServiceDetailsTemp.ProductCode,'Rate')+5)),"
    '            strInsertValue = strInsertValue & "ServiceDetailsTemp.ProductCode,'Rate')-" & intLoop & "+ Instr(ServiceDetailsTemp.ProductCode,'Qty')+5)) as Rate "
    '            strInsertValue = strInsertValue & " from ServiceDetailsTemp "

    '            Dim dcInsetrValue As New OleDbCommand(strColumn & strInsertValue & ")", conMaxComma)


    '            dcInsetrValue.ExecuteNonQuery()


    '        ElseIf Mid(strMaxCommaRecord, intLoop, 1) = "," Then
    '        End If
    '    Next

    '    TempConnectionDispose(conMaxComma)

    'End Sub





    Private Function GetPositionComma(ByVal CommaStartPos As Integer, ByVal strSearchString As String) As Integer
        Dim intLoop As Integer

        For intLoop = CommaStartPos To Len(strSearchString)
            If Mid(strSearchString, intLoop, 1) = "," Then

                Return intLoop
            End If

        Next
        Return True
    End Function




    Public Sub getsummary(ByVal TempConnection As OleDbConnection, ByRef TempDataReader As OleDbDataReader, ByVal TempColumnName As String, ByVal TempTableName As String, ByVal TempInnerJoin As String, ByVal TempWhereClause As String, ByVal TempGroupColumn As String)


        Dim strQrySelect As String







        If TempWhereClause = String.Empty Or TempWhereClause = "" Then
            strQrySelect = "Select " & TempColumnName & " From " & TempTableName & TempInnerJoin & " Group by " & TempGroupColumn
        Else
            strQrySelect = "Select " & TempColumnName & " From " & TempTableName & TempInnerJoin & " Where " & TempWhereClause & " Group by " & TempGroupColumn
        End If

        Dim dcTempSummary As New OleDbCommand(strQrySelect, TempConnection)

        TempDataReader = dcTempSummary.ExecuteReader









    End Sub












    Public Function CheckCharacterSymbol(ByVal strKey As String, ByVal IncludeSpace As Boolean) As Boolean

        Dim strCharacterSymbol As String = Nothing

        If IncludeSpace = True Then
            strCharacterSymbol = "<>,./?';:[{]}\|=+_-()*&^%$#@!~` "
        Else
            strCharacterSymbol = "<>,./?';:[{]}\|=+_-()*&^%$#@!~`"
        End If


        If InStr(1, strCharacterSymbol, strKey) Then
            Return True
        Else
            Return False

        End If





    End Function



    Public Function ShowToolTip(ByVal tmpobj As Object, ByVal Show_Close As Boolean) As ToolTip


        ShowToolTip = New ToolTip



        ShowToolTip.AutomaticDelay = 500
        ShowToolTip.AutoPopDelay = 2000
        ShowToolTip.ReshowDelay = 100

        If Show_Close = True Then ' define true for appearing Tooltip in object

            ShowToolTip.Show("You Cannot Type <>,./?';:[{]}\|=+_-()*&^%$#@!~`", tmpobj)
        ElseIf Show_Close = False Then ' define false for disappearing Tooltip in object

            ShowToolTip.Hide(tmpobj)

        End If






    End Function



    Public Function RemoveCharacter(ByVal InputText As String) As Boolean




        Dim intLoop As Integer = 0
        Dim strRejectChar = ":',.?/|\*&^%$#@!~`}]{[;><=+"""

        'For intLoop = 1 To InputText.Length

        '    If InStr(1, strRejectChar, Mid(InputText, intLoop, 1)) = 1 Then

        '        Return True


        '    End If




        'Next

        For intLoop = 1 To strRejectChar.Length
            If InputText = Mid(strRejectChar, intLoop, 1) Then
                Return True
            End If
        Next




        Return False



    End Function















End Module









