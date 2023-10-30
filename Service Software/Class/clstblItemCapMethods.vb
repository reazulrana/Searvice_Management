Imports System.Data.OleDb
Imports System.Data
Imports System.Configuration



Public Class clstblItemCapMethods


    Public ReadOnly Property GetAccessories(Optional strTempCategory As String = "") As IEnumerable(Of clstblItemCap)

        Get

            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

            Dim ListAccessories As List(Of clstblItemCap) = New List(Of clstblItemCap)



            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dcGetAccessories As OleDbCommand = New OleDbCommand()
                If String.IsNullOrEmpty(strTempCategory) Then
                    dcGetAccessories.CommandText = "qryGet_All_tblItemCap"


                Else
                    dcGetAccessories.CommandText = "qryGet_tblItemCap_byCategory"




                    dcGetAccessories.Parameters.Add("paraCtype", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(strTempCategory), DBNull.Value, strTempCategory)
                End If
                dcGetAccessories.Connection = con
                dcGetAccessories.CommandType = CommandType.StoredProcedure



                con.Open()


                Dim drGetAccessories As OleDbDataReader = dcGetAccessories.ExecuteReader


                While drGetAccessories.Read
                    Dim tempAccessories As clstblItemCap = New clstblItemCap

                    tempAccessories.ItemCode = Convert.ToInt32(drGetAccessories("ItemCode").ToString)
                    tempAccessories.CategoryName = drGetAccessories("cType").ToString
                    tempAccessories.cItem = drGetAccessories("cItem").ToString

                    ListAccessories.Add(tempAccessories)
                End While



            End Using



            Return ListAccessories

        End Get

    End Property


    Public Sub Save(ByVal Accessories As clstblItemCap)

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString





        Using con As OleDbConnection = New OleDbConnection(cs)







            Dim dc As OleDbCommand = New OleDbCommand

            dc.Parameters.Add("ItemCode", OleDbType.Integer).Value = Accessories.ItemCode
            dc.Parameters.Add("cType", OleDbType.Char, 255).Value = Accessories.CategoryName
            dc.Parameters.Add("cItem", OleDbType.Char, 255).Value = Accessories.cItem
            dc.CommandText = "Insert into tblItemCap(ItemCode,cType,cItem) Values(ItemCode,cType,cItem)"
            dc.Connection = con
            con.Open()
            dc.ExecuteNonQuery()


        End Using







    End Sub

    Public Sub Delete(ByVal Accessories As clstblItemCap)

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString





        Using con As OleDbConnection = New OleDbConnection(cs)







            Dim dc As OleDbCommand = New OleDbCommand

            dc.Parameters.Add("@cType", OleDbType.Char, 255).Value = Accessories.CategoryName
            dc.Parameters.Add("@cItem", OleDbType.Char, 255).Value = Accessories.cItem
            dc.CommandText = "Delete * from tblItemCap where  tblItemCap.cType=@cType and tblItemCap.cItem=@cItem"
            dc.Connection = con
            con.Open()
            dc.ExecuteNonQuery()


        End Using







    End Sub



End Class
