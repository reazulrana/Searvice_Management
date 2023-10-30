Imports System.Data.OleDb




Public Class frmRepairedForm
    Private Sub frmRepairedForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBrand()
        optAll.Checked = True
        optSAll.Checked = True

    End Sub

    Private Sub frmRepairedForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        cmbBrand.Left = lblBrand.Left + lblBrand.Width
        cmbBrand.Top = 10


        lblBrand.Top = (cmbBrand.Height / 2) - 1

        lblBrand.Left = 10



        cmdLoadData.Left = cmbBrand.Left + cmbBrand.Width
        cmdLoadData.Top = 10

        cmdClose.Left = cmdLoadData.Left + cmdLoadData.Width
        cmdClose.Top = 10




        lstCategory.Left = 10
        lstCategory.Width = Me.ClientSize.Width - 20
        lstCategory.Top = grpProductStatus.Top + grpProductStatus.Height + 4

        lstRepairedStatus.Top = lstCategory.Top + lstCategory.Height + 2
        lstRepairedStatus.Left = 10
        lstRepairedStatus.Width = Me.ClientSize.Width - 20
        lstRepairedStatus.Height = Me.ClientSize.Height - (lstCategory.Top + lstCategory.Height)
        lstRepairedStatus.Columns(1).Width = 100
        lstRepairedStatus.Columns(2).Width = 100
        lstRepairedStatus.Columns(3).Width = 100
        lstRepairedStatus.Columns(4).Width = 100
        lstRepairedStatus.Columns(5).Width = 100
        lstRepairedStatus.Columns(6).Width = 100
        lstRepairedStatus.Columns(7).Width = 100
        lstRepairedStatus.Columns(8).Width = 90
        lstRepairedStatus.Columns(9).Width = 80
        lstRepairedStatus.Columns(10).Width = 70
        lstRepairedStatus.Columns(11).Width = 70
        lstRepairedStatus.Columns(12).Width = 300


    End Sub

    Private Sub LoadBrand()
        Dim comLoadBrand As New OleDbCommand("Select Distinct Brand.Brand from Brand", MyCon)


        Dim readLoadBrand As OleDbDataReader
        readLoadBrand = comLoadBrand.ExecuteReader

        If cmbBrand.Items.Count > 0 Then
            cmbBrand.Items.Clear()

        End If

        While readLoadBrand.Read
            cmbBrand.Items.Add(readLoadBrand("Brand").ToString)
        End While




    End Sub

    Private Sub LoadCategory(ByVal strtempBrand As String)

        Dim comLoadCategory As New OleDbCommand("Select Distinct Claiminfo.Servicetype from Claiminfo where Claiminfo.Brand='" & strtempBrand & "'", MyCon)


        Dim readLoadCategory As OleDbDataReader

        Dim lsttmpItem As ListViewItem

        readLoadCategory = comLoadCategory.ExecuteReader


        lstCategory.Items.Clear()

        While readLoadCategory.Read

            lsttmpItem = lstCategory.Items().Add(readLoadCategory("ServiceType").ToString)

        End While





    End Sub

    Private Sub cmbBrand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBrand.SelectedIndexChanged
        LoadCategory(cmbBrand.Text)
        DefaultSelect()
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()



    End Sub

    Private Sub lbldtpFrom_Click(sender As Object, e As EventArgs) Handles lbldtpFrom.Click

    End Sub

    Private Sub cmdLoadData_Click(sender As Object, e As EventArgs) Handles cmdLoadData.Click
        If CheckSelectedItem() = "" Then
            MsgBox("Not Item is selected")
            Exit Sub

        End If

        loadInformation(CheckSelectedItem)



    End Sub



    Private Function CheckSelectedItem() As String


        Dim shrtLoop As Short
        Dim strGetResult As String = ""

        Try

            For shrtLoop = 0 To lstCategory.Items.Count - 1
                If lstCategory.Items(shrtLoop).Checked = True Then
                    strGetResult = strGetResult & "'" & lstCategory.Items(shrtLoop).Text & "',"

                End If
            Next



            If strGetResult.Substring(strGetResult.Length - 1) = "," Then
                strGetResult = strGetResult.Substring(0, strGetResult.Length - 1)
            End If


        Catch ex As Exception
            MsgBox(ex.Message, vbInformation, "Event:CheckSelectedItem")
            Return ""

        End Try
        Return strGetResult

    End Function

    Private Sub loadInformation(ByVal strtmpCriteria As String)

        Dim strWarrType As String = ""

        If optAll.Checked = True Then
            strWarrType = ""
        ElseIf optSlsWarranty.Checked = True Then
            strWarrType = "'0'"
            ElseIf optNonWarranty.Checked = True Then
            strWarrType = "'1'"
        ElseIf optSvcWarranty.Checked = True Then
            strWarrType = "'2'"
        End If

        Dim strProductStatus As String = ""

        If optSAll.Checked = True Then
            strProductStatus = ""
        ElseIf optReceive.Checked = True Then
            strProductStatus = "'-1'"
        ElseIf optRepaired.Checked = True Then
            strProductStatus = "'1'"
        ElseIf optDelivery.Checked = True Then
            strProductStatus = "'0'"

        End If

        Dim strsqlInformation As String = ""

        If strWarrType = "" And strProductStatus = "" Then
            'If chkSlsWarrantyPrice.Checked = True Then

            'strsqlInformation = "Select Claiminfo.JobCode,Claiminfo.Branch,CLaiminfo.Servicetype,Claiminfo.Modelno,Claiminfo.SLno,Claiminfo.ReceptDate,Claiminfo.Sdate,Claiminfo.Ddate,iif(Claiminfo.Wcondition=0,'Sls-Warr',iif(Claiminfo.Wcondition=1,'Non-Warr','Svc-Warr')) as Wcondition,Claiminfo.MrNo from Claiminfo where Claiminfo.Cflag=1 and CLaiminfo.Sdate Between #" & dtpFrom.Value & "# and #" & dtpTo.Value & "# and CLaiminfo.Brand='" & cmbBrand.Text & "' and Claiminfo.Servicetype in (" & CheckSelectedItem() & ")"
            'Else
            strsqlInformation = "Select Claiminfo.JobCode,Claiminfo.Branch,CLaiminfo.Servicetype,Claiminfo.Modelno,Claiminfo.SLno,Claiminfo.ReceptDate,Claiminfo.Sdate,Claiminfo.Ddate,Claiminfo.MrNo,iif(Claiminfo.Wcondition=0,'Sls-Warr',iif(Claiminfo.Wcondition=1,'Non-Warr','Svc-Warr')) as Wcondition ,iif(((CLaiminfo.Cflag=0 or CLaiminfo.Cflag=1) and (Claiminfo.Wcondition=1 or Claiminfo.Wcondition=2)),(Claiminfo.SvAmt+Claiminfo.PrdAmt+Claiminfo.OtherAmt)-(Claiminfo.Dis),0) as Amount   from Claiminfo where Claiminfo.Cflag=1 and Claiminfo.Wcondition=0 and CLaiminfo.Sdate Between #" & dtpFrom.Value & "# and #" & dtpTo.Value & "#"
            '   End If

        End If



        Try
            MyCon.Close()

            DatabaseConnection()

            Dim ComloadInformation As New OleDbCommand(strsqlInformation, MyCon)
            lstRepairedStatus.Items.Clear()

            Dim lstTempItem As ListViewItem

            Dim readLoadInformation As OleDbDataReader



            readLoadInformation = ComloadInformation.ExecuteReader


            Dim intRecordCount As Integer = 0

            While readLoadInformation.Read
                intRecordCount = intRecordCount + 1
                lstTempItem = lstRepairedStatus.Items.Add(intRecordCount)
                lstTempItem.SubItems.Add(readLoadInformation("JobCode").ToString)
                lstTempItem.SubItems.Add(readLoadInformation("Branch").ToString)
                lstTempItem.SubItems.Add(readLoadInformation("ServiceType").ToString)
                lstTempItem.SubItems.Add(readLoadInformation("ModelNo").ToString)
                lstTempItem.SubItems.Add(readLoadInformation("SlNo").ToString)
                lstTempItem.SubItems.Add(readLoadInformation("ReceptDate").ToString)
                lstTempItem.SubItems.Add(readLoadInformation("Sdate").ToString)
                lstTempItem.SubItems.Add(readLoadInformation("DDate").ToString)
                lstTempItem.SubItems.Add(readLoadInformation("WCondition").ToString)
                lstTempItem.SubItems.Add(readLoadInformation("MrNo").ToString)
                If chkSlsWarrantyPrice.Checked = True And readLoadInformation("Wcondition").ToString = "Sls-Warr" Then
                    lstTempItem.SubItems.Add(GetPartsAmount(readLoadInformation("JobCOde").ToString, readLoadInformation("Mrno").ToString))
                    'lstTempItem.SubItems.Add("")
                Else

                    lstTempItem.SubItems.Add(readLoadInformation("Amount").ToString)
                End If

                lstTempItem.SubItems.Add(readLoadInformation("JobCode").ToString)

            End While
        Catch ex As Exception
            MsgBox(ex.Message & " Event:loadInformation")
        End Try





    End Sub

    Private Function GetPartsAmount(ByVal strTempJobCode As String, ByVal strMrType As String) As String



        Dim strDatabasLocaltiontmp As String = ""
        Dim strprovidertmp As String = ""
        strDatabasLocaltiontmp = My.Computer.FileSystem.ReadAllText(Environment.CurrentDirectory & "\Database.txt")

        strprovidertmp = "Provider= Microsoft.Jet.OLEDB.4.0; Data source=" & strDatabasLocaltiontmp

        Dim mycontmp As OleDbConnection

        mycontmp = New OleDbConnection(strprovidertmp)

        mycontmp.Open()

        Dim comPartsAmount As New OleDbCommand("Select sum(ServiceDetails.UnitPrice) as Price from Servicedetails where Servicedetails.JobCode='" & strTempJobCode & "'", mycontmp)

        Dim readPartsAmount As OleDbDataReader


        Try
            readPartsAmount = comPartsAmount.ExecuteReader




            'Dim intAMount As Integer = 0

            'While readPartsAmount.Read
            '    intAMount = intAMount + (CInt(readPartsAmount("UnitPrice").ToString))

            'End While
            If readPartsAmount.Read = True Then
                Return readPartsAmount("Price").ToString
            End If




            readPartsAmount.Close()
            readPartsAmount = Nothing

            comPartsAmount = Nothing

        Catch ex As Exception


            MsgBox(ex.Message & " Event: GetPartsAmount")

        End Try

        mycontmp.Close()
        mycontmp = Nothing

        Return ""

    End Function


    Private Sub DefaultSelect()
        Dim intLoop As Integer


        For intLoop = 0 To lstRepairedStatus.Items.Count - 1
            If lstRepairedStatus.Items(intLoop).Text = "MOBIL" Or lstRepairedStatus.Items(intLoop).Text = "MOBILE" Or lstRepairedStatus.Items(intLoop).Text = "MOBILE PHONE" Then
                lstRepairedStatus.Items(intLoop).Checked = True

            End If
        Next
    End Sub

End Class
