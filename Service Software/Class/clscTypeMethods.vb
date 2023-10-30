Imports System.Data
Imports System.Data.OleDb
Imports System.Configuration





Public Class clscTypeMethods


    Public ReadOnly Property GetAllCategory As IEnumerable(Of clscType)
        Get

            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

            Dim ListofCategory As List(Of clscType) = New List(Of clscType)


            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dcGetAllCategory As OleDbCommand = New OleDbCommand("qryGet_All_cType", con)
                dcGetAllCategory.CommandType = CommandType.StoredProcedure
                con.Open()

                Dim drgetAllCategory = dcGetAllCategory.ExecuteReader


                While drgetAllCategory.Read
                    Dim category As clscType = New clscType

                    category.CatID = Convert.ToInt32(drgetAllCategory("CatID"))
                    category.CategoryName = drgetAllCategory("cType").ToString


                    ListofCategory.Add(category)

                End While




            End Using



            Return ListofCategory



        End Get
    End Property


    Public ReadOnly Property Filter(ByVal where As String) As IEnumerable(Of clscType)
        Get

            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

            Dim ListofCategory As List(Of clscType) = New List(Of clscType)


            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dcGetAllCategory As OleDbCommand = New OleDbCommand("Select distinct ctype.CatID, cType.cType from Ctype inner join claiminfo on ctype.ctype=claiminfo.servicetype where Claiminfo.Branch in(" + where + ")", con)
                dcGetAllCategory.CommandType = CommandType.Text
                con.Open()

                Dim drgetAllCategory = dcGetAllCategory.ExecuteReader


                While drgetAllCategory.Read
                    Dim category As clscType = New clscType

                    category.CatID = Convert.ToInt32(drgetAllCategory("CatID"))
                    category.CategoryName = drgetAllCategory("cType").ToString


                    ListofCategory.Add(category)

                End While




            End Using



            Return ListofCategory



        End Get
    End Property




    Public Sub Save(ByVal Catagory As clscType)
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Dim ListofCategory As List(Of clscType) = New List(Of clscType)


        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcGetAllCategory As OleDbCommand = New OleDbCommand("Insert into ctype(cType) values(@cType)", con)
            dcGetAllCategory.CommandType = CommandType.Text
            dcGetAllCategory.Parameters.Add("@cType", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(Catagory.CategoryName), DBNull.Value, Catagory.CategoryName)

            con.Open()
            dcGetAllCategory.ExecuteNonQuery()



        End Using








    End Sub



    Public ReadOnly Property IsExist(ByVal Checkvalue As String) As Boolean
        Get
            Dim blnFlag As Boolean = False
            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

            Dim ListofCategory As List(Of clscType) = New List(Of clscType)

            Try



                Using con As OleDbConnection = New OleDbConnection(cs)
                    Dim dcGetAllCategory As OleDbCommand = New OleDbCommand("Select * from Ctype  where Ctype.Ctype=@Ctype", con)
                    dcGetAllCategory.CommandType = CommandType.Text
                    dcGetAllCategory.Parameters.Add("@Ctype", OleDbType.Char, 255).Value = Checkvalue
                    con.Open()

                    Dim drgetAllCategory = dcGetAllCategory.ExecuteReader

                    If drgetAllCategory.HasRows = True Then


                        blnFlag = True

                    End If


                End Using
            Catch ex As Exception
                blnFlag = False

            End Try


            Return blnFlag



        End Get
    End Property


End Class
