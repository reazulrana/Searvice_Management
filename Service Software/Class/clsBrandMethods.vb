Imports System.Data.OleDb
Imports System.Data
Imports System.Configuration


Public Class clsBrandMethods

    Public ReadOnly Property GetAllBrands As IEnumerable(Of clsBrand)
        Get

            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

            Dim ListofBrand As List(Of clsBrand) = New List(Of clsBrand)


            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dcGetAllCategory As OleDbCommand = New OleDbCommand("Select * from Brand", con)
                dcGetAllCategory.CommandType = CommandType.Text
                con.Open()

                Dim drgetAllCategory = dcGetAllCategory.ExecuteReader


                While drgetAllCategory.Read
                    Dim Brand As clsBrand = New clsBrand
                    If Not String.IsNullOrEmpty(drgetAllCategory("BrdID").ToString) Then
                        Brand.BrdID = Convert.ToInt32(drgetAllCategory("BrdID").ToString)
                    Else
                        Brand.BrdID = 0
                    End If

                    Brand.CategoryName = drgetAllCategory("cType").ToString
                    Brand.Brand = drgetAllCategory("Brand").ToString
                    Brand.Item = drgetAllCategory("Item").ToString
                    If Not String.IsNullOrEmpty(drgetAllCategory("SLNO").ToString) Then
                        Brand.SLNO = Convert.ToInt32(drgetAllCategory("SLNO").ToString)
                    Else
                        Brand.SLNO = 0
                    End If

                    If Not String.IsNullOrEmpty(drgetAllCategory("TAT").ToString) Then
                        Brand.TAT = Convert.ToInt32(drgetAllCategory("TAT").ToString)
                    Else
                        Brand.TAT = 0
                    End If


                    ListofBrand.Add(Brand)

                End While




            End Using



            Return ListofBrand



        End Get
    End Property


    Public Function getBrand_byCategory(ByVal TempCategory As String) As IEnumerable(Of clsBrand)

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString


        Dim lstBrand As List(Of clsBrand) = New List(Of clsBrand)


        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcGetAllCategory As OleDbCommand = New OleDbCommand("qryGet_All_Brand", con)
            dcGetAllCategory.CommandType = CommandType.StoredProcedure
            dcGetAllCategory.Parameters.Add("paracType", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(TempCategory), DBNull.Value, TempCategory)
            con.Open()

            Dim drgetAllCategory = dcGetAllCategory.ExecuteReader


            While drgetAllCategory.Read

                Dim Brand As clsBrand = New clsBrand
                Brand.BrdID = Convert.ToInt32(drgetAllCategory("BrdID"))
                Brand.CategoryName = drgetAllCategory("cType").ToString
                Brand.Brand = drgetAllCategory("Brand").ToString
                Brand.Item = drgetAllCategory("Item").ToString
                If Not String.IsNullOrEmpty(drgetAllCategory("SLNO").ToString) Then
                    Brand.SLNO = Convert.ToInt32(drgetAllCategory("SLNO").ToString)
                End If

                If Not String.IsNullOrEmpty(drgetAllCategory("TAT").ToString) Then
                    Brand.TAT = Convert.ToInt32(drgetAllCategory("TAT").ToString)
                End If
                lstBrand.Add(Brand)
            End While




        End Using



        Return lstBrand





    End Function






    Public ReadOnly Property GetMultyBrand(ByVal Where As String) As IEnumerable(Of clsBrand)
        Get

            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

            Dim ListofBrand As List(Of clsBrand) = New List(Of clsBrand)


            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dcGetAllCategory As OleDbCommand = New OleDbCommand("Select Distinct Brand.brdid, Brand.Brand from Brand where   Brand.Ctype in(" + Where + ")  order by Brand ", con)
                dcGetAllCategory.CommandType = CommandType.Text
                con.Open()

                Dim drgetAllCategory As OleDbDataReader = dcGetAllCategory.ExecuteReader


                While drgetAllCategory.Read
                    Dim Brand As clsBrand = New clsBrand
                    Brand.BrdID = Convert.ToInt32(drgetAllCategory("BrdID"))
                    Brand.Brand = drgetAllCategory("Brand").ToString
                    ListofBrand.Add(Brand)
                End While
            End Using
            Return ListofBrand
        End Get
    End Property




    Public ReadOnly Property GetTableFilter(ByVal Where As String) As DataTable
        Get

            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

            Dim dt As DataTable = New DataTable


            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dcGetTableFilter As OleDbCommand = New OleDbCommand("Select Distinct Brand.brdid, Brand.Brand from Brand where   Brand.Ctype=@Ctype  order by Brand ", con)
                dcGetTableFilter.CommandType = CommandType.Text
                dcGetTableFilter.Parameters.Add("@Ctype", OleDbType.Char, 255).Value = Where
                con.Open()

                Dim drGetTableFilter As OleDbDataReader = dcGetTableFilter.ExecuteReader


                If drGetTableFilter.HasRows = True Then

                    dt.Load(drGetTableFilter)
                End If




            End Using



            Return dt



        End Get
    End Property





    Public Function GetDistinctBrand(ByVal Where As String) As List(Of clsBrand)


        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Dim ListOfBrand As List(Of clsBrand) = New List(Of clsBrand)

        Dim strSQL As String
        If String.IsNullOrEmpty(Where.Trim) Or Where = "1=1" Then
            strSQL = "Select Distinct Brand.Brand from Brand order by Brand"
        Else
            strSQL = "Select Distinct Brand.Brand from Brand where " & Where & " order by Brand "
        End If
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcGetTableFilter As OleDbCommand = New OleDbCommand(strSQL, con)
            dcGetTableFilter.CommandType = CommandType.Text
            con.Open()
            Dim drGetTableFilter As OleDbDataReader = dcGetTableFilter.ExecuteReader

            If drGetTableFilter.HasRows = True Then
                While drGetTableFilter.Read
                    Dim Brand As clsBrand = New clsBrand
                    Brand.Brand = drGetTableFilter("Brand").ToString
                    ListOfBrand.Add(Brand)
                End While

            End If

        End Using

        Return ListOfBrand

    End Function


    Public Function GetBrandID(ByVal Where As String) As List(Of clsBrand)


        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Dim ListOfBrand As List(Of clsBrand) = New List(Of clsBrand)

        Dim strSQL As String
        If String.IsNullOrEmpty(Where.Trim) Or Where = "1=1" Then
            strSQL = "Select Brand.brdID from Brand order by brdID"
        Else
            strSQL = "Select Brand.brdID from Brand where " & Where & " order by brdID "
        End If
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcGetTableFilter As OleDbCommand = New OleDbCommand(strSQL, con)
            dcGetTableFilter.CommandType = CommandType.Text
            con.Open()
            Dim drGetTableFilter As OleDbDataReader = dcGetTableFilter.ExecuteReader

            If drGetTableFilter.HasRows = True Then
                While drGetTableFilter.Read
                    Dim Brand As clsBrand = New clsBrand
                    Brand.BrdID = drGetTableFilter("brdID").ToString
                    ListOfBrand.Add(Brand)
                End While

            End If

        End Using

        Return ListOfBrand

    End Function


    Public Function GetSingleID(ByVal strCategory As String, ByVal strBrand As String) As clsBrand


        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Dim Brand As clsBrand = New clsBrand

        Dim strSQL As String


        strSQL = "Select Brand.brdID from Brand where Brand.Ctype=@Ctype and Brand.Brand=@Brand  order by brdID "

        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcGetTableFilter As OleDbCommand = New OleDbCommand(strSQL, con)
            dcGetTableFilter.CommandType = CommandType.Text
            dcGetTableFilter.Parameters.Add("@Ctype", OleDbType.Char, 255).Value = strCategory
            dcGetTableFilter.Parameters.Add("@Brand", OleDbType.Char, 255).Value = strBrand

            con.Open()
            Dim drGetTableFilter As OleDbDataReader = dcGetTableFilter.ExecuteReader

            If drGetTableFilter.HasRows = True Then
                While drGetTableFilter.Read

                    Brand.BrdID = drGetTableFilter("brdID").ToString
                End While

            End If

        End Using

        Return Brand

    End Function



    Public Function IsExist(ByVal strCategory As String, ByVal strBrand As String) As Boolean


        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Dim Brand As clsBrand = New clsBrand

        Dim strSQL As String

        Dim blnFlag As Boolean = False

        strSQL = "Select Brand.brdID from Brand where Brand.Ctype=@Ctype and Brand.Brand=@Brand  order by brdID "
        Try


            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dcGetTableFilter As OleDbCommand = New OleDbCommand(strSQL, con)
                dcGetTableFilter.CommandType = CommandType.Text
                dcGetTableFilter.Parameters.Add("@Ctype", OleDbType.Char, 255).Value = strCategory
                dcGetTableFilter.Parameters.Add("@Brand", OleDbType.Char, 255).Value = strBrand

                con.Open()
                Dim drGetTableFilter As OleDbDataReader = dcGetTableFilter.ExecuteReader

                If drGetTableFilter.HasRows = True Then

                    blnFlag = True


                End If

            End Using

        Catch ex As Exception
            blnFlag = False
        End Try
        Return blnFlag

    End Function


    Public Sub Save(ByVal Brand As clsBrand)

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Dim ListofCategory As List(Of clscType) = New List(Of clscType)


        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcGetAllCategory As OleDbCommand = New OleDbCommand("Insert into Brand(cType,Brand) values(@cType,@Brand)", con)
            dcGetAllCategory.CommandType = CommandType.Text
            dcGetAllCategory.Parameters.Add("@cType", OleDbType.Char, 255).Value = Brand.CategoryName
            dcGetAllCategory.Parameters.Add("@Brand", OleDbType.Char, 255).Value = Brand.Brand
            con.Open()
            dcGetAllCategory.ExecuteNonQuery()



        End Using



    End Sub

End Class
