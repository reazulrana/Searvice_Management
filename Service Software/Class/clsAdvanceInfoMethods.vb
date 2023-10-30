Imports System.Configuration
Imports System.Data
Imports System.Data.OleDb


Public Class clsAdvanceInfoMethods
    Public Sub Save(ByVal AdvanceClass As clsAdvanceInfo)

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Dim strQuery As String = "Insert Into AdvanceInfo(JobCode,Branch,AdvNo,AdvDate,AdvAmnt,AdvRemarks,PayType,BankName,CardNo) values(@JobCode,@Branch,@AdvNo,@AdvDate,@AdvAmnt,@AdvRemarks,@PayType,@BankName,@CardNo)"


        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcInsert As OleDbCommand = New OleDbCommand(strQuery, con)
            '@JobCode,@Branch,@AdvNo,@AdvDate,@AdvAmnt,@AdvRemarks,@PayType,@BankName,@CardNo)"
            dcInsert.Parameters.Add("@JobCode", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(AdvanceClass.JobCode), DBNull.Value, AdvanceClass.JobCode)
            dcInsert.Parameters.Add("@Branch", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(AdvanceClass.Branch), DBNull.Value, AdvanceClass.Branch)
            dcInsert.Parameters.Add("@AdvNo", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(AdvanceClass.AdvNo), DBNull.Value, AdvanceClass.AdvNo)
            dcInsert.Parameters.Add("@AdvDate", OleDbType.Date).Value = If(String.IsNullOrEmpty(AdvanceClass.AdvDate), DBNull.Value, AdvanceClass.AdvDate)
            dcInsert.Parameters.Add("@AdvAmnt", OleDbType.Double).Value = If(String.IsNullOrEmpty(AdvanceClass.AdvAmnt), DBNull.Value, AdvanceClass.AdvAmnt)
            dcInsert.Parameters.Add("@AdvRemarks", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(AdvanceClass.AdvRemarks), DBNull.Value, AdvanceClass.AdvRemarks)
            dcInsert.Parameters.Add("@PayType", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(AdvanceClass.PayType), DBNull.Value, AdvanceClass.PayType)
            dcInsert.Parameters.Add("@BankName", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(AdvanceClass.BankName.Trim), DBNull.Value, AdvanceClass.BankName)
            dcInsert.Parameters.Add("@CardNo", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(AdvanceClass.CardNo), DBNull.Value, AdvanceClass.CardNo)

            con.Open()
            dcInsert.ExecuteNonQuery()
        End Using
    End Sub



    Public Sub UPdate(ByVal AdvanceClass As clsAdvanceInfo, ByVal UpdateID As String)

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Dim strQuery As String = "Update clsAdvanceInfo set JobCode=@JobCode,Branch=@Branch,AdvNo=@AdvNo,AdvDate=@AdvDate,AdvAmnt=@AdvAmnt,AdvRemarks=@AdvRemarks,PayType=@PayType,BankName=@BankName,CardNo=@CardNo WHERE clsAdvanceInfo.JobCode=@JobCode1"


        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcInsert As OleDbCommand = New OleDbCommand(strQuery, con)

            dcInsert.Parameters.Add("@JobCode", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(AdvanceClass.JobCode.Trim), DBNull.Value, AdvanceClass.JobCode)
            dcInsert.Parameters.Add("@Branch", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(AdvanceClass.Branch.Trim), DBNull.Value, AdvanceClass.Branch)
            dcInsert.Parameters.Add("@AdvNo", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(AdvanceClass.AdvNo.Trim), DBNull.Value, AdvanceClass.AdvNo)
            dcInsert.Parameters.Add("@AdvDate", OleDbType.Date).Value = If(String.IsNullOrEmpty(AdvanceClass.AdvDate), DBNull.Value, AdvanceClass.AdvDate)
            dcInsert.Parameters.Add("@AdvAmnt", OleDbType.Double).Value = If(String.IsNullOrEmpty(AdvanceClass.AdvAmnt), DBNull.Value, AdvanceClass.AdvAmnt)
            dcInsert.Parameters.Add("@AdvRemarks", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(AdvanceClass.AdvRemarks.Trim), DBNull.Value, AdvanceClass.AdvRemarks)
            dcInsert.Parameters.Add("@PayType", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(AdvanceClass.PayType.Trim), DBNull.Value, AdvanceClass.PayType)
            dcInsert.Parameters.Add("@BankName", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(AdvanceClass.BankName.Trim), DBNull.Value, AdvanceClass.BankName)
            dcInsert.Parameters.Add("@CardNo", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(AdvanceClass.CardNo.Trim), DBNull.Value, AdvanceClass.CardNo)
            dcInsert.Parameters.Add("@JobCode1", OleDbType.Char, 255).Value = UpdateID

            con.Open()
            dcInsert.ExecuteNonQuery()
        End Using
    End Sub

    Public ReadOnly Property GetAllAdvanceInfo() As IEnumerable(Of clsAdvanceInfo)
        Get
            Dim ListofAdvance As List(Of clsAdvanceInfo) = New List(Of clsAdvanceInfo)


            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
            Dim strQuery As String = "Select * from AdvanceInfo"
            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dcGetAdvance As OleDbCommand = New OleDbCommand(strQuery, con)

                con.Open()

                Dim drGetAdvance As OleDbDataReader = dcGetAdvance.ExecuteReader


                If drGetAdvance.HasRows = True Then
                    While drGetAdvance.Read
                        Dim Advance As clsAdvanceInfo = New clsAdvanceInfo
                        If Not String.IsNullOrEmpty(drGetAdvance("AdvAID")) Then
                            Advance.AdvAID = Convert.ToInt32(drGetAdvance("AdvAID").ToString)
                        End If
                        'JobCode,Branch,AdvNo,AdvDate,AdvAmnt,AdvRemarks,PayType,BankName,CardNo
                        Advance.JobCode = drGetAdvance("JobCode").ToString
                        Advance.Branch = drGetAdvance("Branch").ToString
                        Advance.AdvNo = drGetAdvance("AdvNo").ToString
                        If Not String.IsNullOrEmpty(drGetAdvance("AdvDate")) Then
                            Advance.AdvDate = Convert.ToDateTime(drGetAdvance("AdvDate").ToString)
                        End If
                        If Not String.IsNullOrEmpty(drGetAdvance("AdvAmnt")) Then
                            Advance.AdvAmnt = Convert.ToDouble(drGetAdvance("AdvAmnt").ToString)
                        End If
                        Advance.AdvRemarks = drGetAdvance("AdvRemarks").ToString
                        Advance.PayType = drGetAdvance("PayType").ToString
                        Advance.BankName = drGetAdvance("BankName").ToString
                        Advance.CardNo = drGetAdvance("CardNo").ToString
                        ListofAdvance.Add(Advance)
                    End While
                End If
            End Using
            Return ListofAdvance
        End Get
    End Property



    Public ReadOnly Property GetSingleAdvanceInfo(ByVal strSearchID As String) As clsAdvanceInfo
        Get

            Dim Advance As clsAdvanceInfo = New clsAdvanceInfo
            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
            Dim strQuery As String = "Select * from AdvanceInfo where AdvanceInfo.JobCode=@JobCode"
            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dcGetAdvance As OleDbCommand = New OleDbCommand(strQuery, con)
                dcGetAdvance.Parameters.Add("@JobCode", OleDbType.Char, 255).Value = strSearchID
                con.Open()

                Dim drGetAdvance As OleDbDataReader = dcGetAdvance.ExecuteReader


                If drGetAdvance.HasRows = True Then
                    While drGetAdvance.Read

                        If Not String.IsNullOrEmpty(drGetAdvance("AdvAID")) Then
                            Advance.AdvAID = Convert.ToInt32(drGetAdvance("AdvAID").ToString)
                        End If
                        'JobCode,Branch,AdvNo,AdvDate,AdvAmnt,AdvRemarks,PayType,BankName,CardNo
                        Advance.JobCode = drGetAdvance("JobCode").ToString
                        Advance.Branch = drGetAdvance("Branch").ToString
                        Advance.AdvNo = drGetAdvance("AdvNo").ToString
                        If Not String.IsNullOrEmpty(drGetAdvance("AdvDate")) Then
                            Advance.AdvDate = Convert.ToDateTime(drGetAdvance("AdvDate").ToString)
                        End If
                        If Not String.IsNullOrEmpty(drGetAdvance("AdvAmnt")) Then
                            Advance.AdvAmnt = Convert.ToDouble(drGetAdvance("AdvAmnt").ToString)
                        End If
                        Advance.AdvRemarks = drGetAdvance("AdvRemarks").ToString
                        Advance.PayType = drGetAdvance("PayType").ToString
                        Advance.BankName = drGetAdvance("BankName").ToString
                        Advance.CardNo = drGetAdvance("CardNo").ToString


                    End While
                End If
            End Using
            Return Advance
        End Get
    End Property




    Public Sub Delete(ByVal strSearchID As String)
        Dim Advance As clsAdvanceInfo = New clsAdvanceInfo
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim strQuery As String = "Delete * from AdvanceInfo where AdvanceInfo.JobCode=@JobCode"
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcGetAdvance As OleDbCommand = New OleDbCommand(strQuery, con)
            dcGetAdvance.Parameters.Add("@JobCode", OleDbType.Char, 255).Value = strSearchID
            con.Open()
            dcGetAdvance.ExecuteNonQuery()

        End Using

    End Sub



    Public Function IsExist(ByVal CheckID As String) As Boolean
        Dim Advance As clsAdvanceInfo = New clsAdvanceInfo
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim strQuery As String = "Select * from AdvanceInfo where AdvanceInfo.JobCode=@JobCode"
        Dim blnFlag As Boolean = False

        Try




            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dcGetAdvance As OleDbCommand = New OleDbCommand(strQuery, con)
                dcGetAdvance.Parameters.Add("@JobCode", OleDbType.Char, 255).Value = CheckID
                con.Open()
                Dim drExist As OleDbDataReader = dcGetAdvance.ExecuteReader

                If drExist.HasRows = True Then
                    blnFlag = True
                End If
            End Using
        Catch ex As Exception
            blnFlag = False

        End Try
        Return blnFlag

    End Function

End Class
