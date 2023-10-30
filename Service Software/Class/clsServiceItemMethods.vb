Imports System.Data
Imports System.Data.OleDb
Imports System.Configuration








Public Class clsServiceItemMethods




    Public Sub SaveItem(ByVal Item As clsServiceItem)


        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Dim TempItem As clsServiceItem = New clsServiceItem



        Using con As OleDbConnection = New OleDbConnection(cs)

            Dim dcSaveItem As OleDbCommand = New OleDbCommand("qryInsertServiceItem", con)

            dcSaveItem.CommandType = CommandType.StoredProcedure

            dcSaveItem.Parameters.Add("paramJobCode", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(Item.JobCode), DBNull.Value, Item.JobCode)
            dcSaveItem.Parameters.Add("paramItem", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(Item.Item), DBNull.Value, Item.Item)

            con.Open()

            dcSaveItem.ExecuteNonQuery()





        End Using

    End Sub




    Public Sub UpdateItem(ByVal tempItem As clsServiceItem, ByVal UpdateCriteria As String)

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString



        Using con = New OleDbConnection(cs)

            Dim dcUpdateItem As OleDbCommand = New OleDbCommand("qryUpdatetServiceItem", con)
            dcUpdateItem.CommandType = CommandType.StoredProcedure
            dcUpdateItem.Parameters.Add("paramJobCode", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tempItem.JobCode), DBNull.Value, tempItem.JobCode)
            dcUpdateItem.Parameters.Add("paramItem", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tempItem.Item), DBNull.Value, tempItem.Item)
            dcUpdateItem.Parameters.Add("paramJobCode2", OleDbType.Char, 255).Value = UpdateCriteria
            con.Open()
            dcUpdateItem.ExecuteNonQuery()



        End Using


    End Sub


    Public Sub DeleteItem(ByVal DeleteCriteria As String)

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcDeleteItem As OleDbCommand = New OleDbCommand("qryDeleteServiceItem", con)
            dcDeleteItem.CommandType = CommandType.StoredProcedure
            dcDeleteItem.Parameters.Add("paramjobCode", OleDbType.Char, 255).Value = DeleteCriteria
            con.Open()
            dcDeleteItem.ExecuteNonQuery()





        End Using


    End Sub


    Public Function GetItem(ByVal SearchCriteria As String) As clsServiceItem


        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim serviceItem As clsServiceItem = New clsServiceItem


        Using con = New OleDbConnection(cs)

            Dim dcserviceItem = New OleDbCommand("qryGet_ServiceItem_byJobCode", con)
            dcserviceItem.CommandType = CommandType.StoredProcedure
            dcserviceItem.Parameters.Add("paramJobCode", OleDbType.Char, 255).Value = SearchCriteria
            con.Open()
            Dim drServiceItem = dcserviceItem.ExecuteReader
            If drServiceItem.HasRows = True Then

                While drServiceItem.Read
                serviceItem.SrvID = Convert.ToInt32(drServiceItem("SrvID").ToString)
                serviceItem.JobCode = drServiceItem("JobCode").ToString
                serviceItem.Item = drServiceItem("Item").ToString
            End While


            End If
        End Using



        Return serviceItem

    End Function



    Public Function IsExist(ByVal SearchCriteria As String) As Boolean
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Dim blnFlag As Boolean = False

        Try




            Using con = New OleDbConnection(cs)
                Dim dcserviceItem = New OleDbCommand("qryGet_ServiceItem_byJobCode", con)
                dcserviceItem.CommandType = CommandType.StoredProcedure
                dcserviceItem.Parameters.Add("paramJobCode", OleDbType.Char, 255).Value = SearchCriteria
                con.Open()
                Dim drServiceItem = dcserviceItem.ExecuteReader
                If drServiceItem.HasRows = True Then
                    blnFlag = True
                End If
            End Using
        Catch ex As Exception
            blnFlag = False

        End Try
        Return blnFlag
    End Function
End Class
