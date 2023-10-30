Imports System.Configuration
Imports System.Data
Imports System.Data.OleDb


Public Class clstbStorageSetMethods


    Public Sub Save(ByVal tbStorageSet As clstbStorageSet)
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim strQuery As String = "Insert Into tbStoregeSET(JobCode, Location, SendDate, Bin, Remarks, Branch) values(@JobCode, @Location, @SendDate, @Bin, @Remarks, @Branch)"
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcInsertTbGrade = New OleDbCommand(strQuery, con)
            dcInsertTbGrade.CommandType = CommandType.Text
            dcInsertTbGrade.Parameters.Add("@JobCode", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tbStorageSet.JobCode), DBNull.Value, tbStorageSet.JobCode)
            dcInsertTbGrade.Parameters.Add("@Location", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tbStorageSet.Location), DBNull.Value, tbStorageSet.Location)
            dcInsertTbGrade.Parameters.Add("@SendDate", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tbStorageSet.SendDate), DBNull.Value, tbStorageSet.SendDate)
            dcInsertTbGrade.Parameters.Add("@Bin", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tbStorageSet.Bin), DBNull.Value, tbStorageSet.Bin)
            dcInsertTbGrade.Parameters.Add("@Remarks", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tbStorageSet.Remarks), DBNull.Value, tbStorageSet.Remarks)
            dcInsertTbGrade.Parameters.Add("@Branch", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tbStorageSet.Branch), DBNull.Value, tbStorageSet.Branch)
            con.Open()
            dcInsertTbGrade.ExecuteNonQuery()
        End Using
    End Sub


    Public Sub Update(ByVal tbStorageSet As clstbStorageSet, ByVal UpdateID As String)
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim strQuery As String = "Update tbStoregeSET set JobCode=@JobCode, Location=@Location, SendDate=@SendDate, Bin=@Bin, Remarks=@Remarks, Branch=@Branch where tbStoregeSET.JobCode=@JobCode1"
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcInsertTbGrade = New OleDbCommand(strQuery, con)
            dcInsertTbGrade.CommandType = CommandType.StoredProcedure
            dcInsertTbGrade.Parameters.Add("@JobCode", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tbStorageSet.JobCode), DBNull.Value, tbStorageSet.JobCode)
            dcInsertTbGrade.Parameters.Add("@Location", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tbStorageSet.Location), DBNull.Value, tbStorageSet.Location)
            dcInsertTbGrade.Parameters.Add("@SendDate", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tbStorageSet.SendDate), DBNull.Value, tbStorageSet.SendDate)
            dcInsertTbGrade.Parameters.Add("@Bin", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tbStorageSet.Bin), DBNull.Value, tbStorageSet.Bin)
            dcInsertTbGrade.Parameters.Add("@Remarks", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tbStorageSet.Remarks), DBNull.Value, tbStorageSet.Remarks)
            dcInsertTbGrade.Parameters.Add("@Branch", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tbStorageSet.Branch), DBNull.Value, tbStorageSet.Branch)
            dcInsertTbGrade.Parameters.Add("@JobCode1", OleDbType.Char, 255).Value = UpdateID
            con.Open()
            dcInsertTbGrade.ExecuteNonQuery()
        End Using
    End Sub



    Public Sub Delete(ByVal UpdateID As String)
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim strQuery As String = "Delete * from tbStoregeSET where tbStoregeSET.JobCode=@JobCode"
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcInsertTbGrade = New OleDbCommand(strQuery, con)
            dcInsertTbGrade.Parameters.Add("@JobCode", OleDbType.Char, 255).Value = UpdateID
            con.Open()
            dcInsertTbGrade.ExecuteNonQuery()
        End Using
    End Sub

    Public ReadOnly Property GetALLStorageSet() As IEnumerable(Of clstbStorageSet)
        Get
            Dim ListStorage As List(Of clstbStorageSet) = New List(Of clstbStorageSet)
            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

            Dim strQuery As String = "Select * from tbStoregeSET"
            Using con As OleDbConnection = New OleDbConnection(cs)

                Dim dcStorage As OleDbCommand = New OleDbCommand(strQuery, con)

                con.Open()
                Dim drStorage As OleDbDataReader = dcStorage.ExecuteReader

                If drStorage.HasRows = True Then
                    While drStorage.Read
                        Dim storage As clstbStorageSet = New clstbStorageSet
                        'tbStoregeSET.SSID, tbStoregeSET.JobCode, tbStoregeSET.Location, tbStoregeSET.SendDate, 
                        'tbStoregeSET.Bin,tbStoregeSET.Remarks, tbStoregeSET.Branch
                        If Not String.IsNullOrEmpty(drStorage("SSID").ToString) Then
                            storage.SSID = Convert.ToInt32(drStorage("SSID").ToString)
                        End If
                        storage.JobCode = drStorage("JobCode").ToString
                        storage.Location = drStorage("Location").ToString
                        If Not String.IsNullOrEmpty(drStorage("SendDate").ToString) Then
                            storage.SendDate = drStorage("SendDate").ToString
                        End If

                        storage.Bin = drStorage("Bin").ToString
                        storage.Remarks = drStorage("Remarks").ToString
                        storage.Branch = drStorage("Branch").ToString
                        ListStorage.Add(storage)
                    End While
                End If


            End Using



            Return ListStorage

        End Get
    End Property



    Public ReadOnly Property GetSingleStorageSet(ByVal CheckID As String) As clstbStorageSet
        Get
            Dim storage As clstbStorageSet = New clstbStorageSet
            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
            Dim strQuery As String = "Select * from tbStoregeSET where tbStoregeSET.JobCode=@JobCode"
            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dcStorage As OleDbCommand = New OleDbCommand(strQuery, con)
                dcStorage.Parameters.Add("@JobCode", OleDbType.Char, 255).Value = CheckID
                con.Open()
                Dim drStorage As OleDbDataReader = dcStorage.ExecuteReader
                If drStorage.HasRows = True Then
                    While drStorage.Read
                        'tbStoregeSET.SSID, tbStoregeSET.JobCode, tbStoregeSET.Location, tbStoregeSET.SendDate, 
                        'tbStoregeSET.Bin,tbStoregeSET.Remarks, tbStoregeSET.Branch
                        If Not String.IsNullOrEmpty(drStorage("SSID").ToString) Then
                            storage.SSID = Convert.ToInt32(drStorage("SSID").ToString)
                        End If
                        storage.JobCode = drStorage("JobCode").ToString
                        storage.Location = drStorage("Location").ToString
                        If Not String.IsNullOrEmpty(drStorage("SendDate").ToString) Then
                            storage.SendDate = drStorage("SendDate").ToString
                        End If
                        storage.Bin = drStorage("Bin").ToString
                        storage.Remarks = drStorage("Remarks").ToString
                        storage.Branch = drStorage("Branch").ToString
                    End While
                End If
            End Using
            Return storage
        End Get
    End Property
    Public Function IsExist(ByVal CheckID As String) As Boolean
        Dim storage As clstbStorageSet = New clstbStorageSet
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim strQuery As String = "Select * from tbStoregeSET where tbStoregeSET.JobCode=@JobCode"

        Dim blnFlag As Boolean = False
        Try



            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dcStorage As OleDbCommand = New OleDbCommand(strQuery, con)
                dcStorage.Parameters.Add("@JobCode", OleDbType.Char, 255).Value = CheckID
                con.Open()
                Dim drStorage As OleDbDataReader = dcStorage.ExecuteReader
                If drStorage.HasRows = True Then
                    blnFlag = True
                End If
            End Using
        Catch ex As Exception
            blnFlag = False

        End Try
        Return blnFlag
    End Function


End Class
