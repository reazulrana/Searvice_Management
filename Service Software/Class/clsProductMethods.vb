Imports System
Imports System.Configuration
Imports System.Data.OleDb
Imports System.Data




Public Class clsProductMethods


    Public Function GetProductList() As List(Of clsProduct)

        Dim ProductList As List(Of clsProduct) = New List(Of clsProduct)

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Using con As OleDbConnection = New OleDbConnection(cs)

            Dim dcProductList As OleDbCommand = New OleDbCommand("qryGetAllProduct", con)
            dcProductList.CommandType = CommandType.StoredProcedure
            con.Open()
            Dim drProductList As OleDbDataReader = dcProductList.ExecuteReader

            While drProductList.Read

                Dim tmpProduct As clsProduct = New clsProduct

                If Not String.IsNullOrEmpty(drProductList("ProductID").ToString) Then
                    tmpProduct.ProductID = Integer.Parse(drProductList("ProductID").ToString)
                End If

                tmpProduct.Code = drProductList("Code").ToString
                tmpProduct.RPCode = drProductList("RPCode").ToString
                If Not String.IsNullOrEmpty(drProductList("CatagoryID").ToString) Then
                    tmpProduct.CatagoryID = Integer.Parse(drProductList("CatagoryID").ToString)
                End If

                tmpProduct.ProdName = drProductList("ProdName").ToString
                tmpProduct.LocationCode = drProductList("LocationCode").ToString
                tmpProduct.Model = drProductList("Model").ToString
                tmpProduct.BinNmbr = drProductList("BinNmbr").ToString
                tmpProduct.Country = drProductList("Country").ToString
                tmpProduct.Maker = drProductList("Maker").ToString
                tmpProduct.Measure = drProductList("Measure").ToString
                If Not String.IsNullOrEmpty(drProductList("QtyAvl").ToString) Then
                    tmpProduct.QtyAvl = Integer.Parse(drProductList("QtyAvl").ToString)
                End If
                If Not String.IsNullOrEmpty(drProductList("UnitPrice").ToString) Then
                    tmpProduct.UnitPrice = Double.Parse(drProductList("UnitPrice").ToString)
                End If

                If Not String.IsNullOrEmpty(drProductList("MaxOrder").ToString) Then
                    tmpProduct.MaxOrder = Integer.Parse(drProductList("MaxOrder").ToString)
                End If

                If Not String.IsNullOrEmpty(drProductList("Discontinued").ToString) Then
                    tmpProduct.Discontinued = Convert.ToBoolean(drProductList("Discontinued").ToString)
                End If

                If Not String.IsNullOrEmpty(drProductList("Sales").ToString) Then
                    tmpProduct.Sales = Convert.ToBoolean(drProductList("Sales").ToString)
                End If

                tmpProduct.Tag = drProductList("Tag").ToString
                tmpProduct.UserName = drProductList("UserName").ToString
                If Not String.IsNullOrEmpty(drProductList("Date_Time").ToString) Then
                    tmpProduct.Date_Time = Date.Parse(drProductList("Date_Time").ToString)
                End If
                If Not String.IsNullOrEmpty(drProductList("ReorderDate").ToString) Then
                    tmpProduct.ReorderDate = Date.Parse(drProductList("ReorderDate").ToString)
                End If

                tmpProduct.ReorderTag = Convert.ToBoolean(drProductList("ReorderTag").ToString)
                If Not String.IsNullOrEmpty(drProductList("DollerPrice").ToString) Then
                    tmpProduct.DollerPrice = Double.Parse(drProductList("DollerPrice").ToString)
                End If

                If Not String.IsNullOrEmpty(drProductList("OP").ToString) Then
                    tmpProduct.OP = Integer.Parse(drProductList("OP").ToString)
                End If

                If Not String.IsNullOrEmpty(drProductList("UPNO").ToString) Then
                    tmpProduct.UPNO = Integer.Parse(drProductList("UPNO").ToString)
                End If

                tmpProduct.TrackNO = drProductList("TrackNO").ToString

                ProductList.Add(tmpProduct)

            End While

        End Using

        Return ProductList


    End Function




    Public Function GetProductByCode(ByVal SearchCode As String) As clsProduct


        Dim tmpProduct As clsProduct = New clsProduct
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Using con As OleDbConnection = New OleDbConnection(cs)

            Dim dcProductList As OleDbCommand = New OleDbCommand("qryGetProductByCode", con)
            dcProductList.CommandType = CommandType.StoredProcedure
            dcProductList.Parameters.Add("ParaCode1", OleDbType.Char, 255).Value = SearchCode

            Dim drProductList As OleDbDataReader = dcProductList.ExecuteReader
            con.Open()

            While drProductList.Read



                If Not String.IsNullOrEmpty(drProductList("ProductID").ToString) Then
                    tmpProduct.ProductID = Integer.Parse(drProductList("ProductID").ToString)
                End If

                tmpProduct.Code = drProductList("Code").ToString
                tmpProduct.RPCode = drProductList("RPCode").ToString
                If Not String.IsNullOrEmpty(drProductList("CatagoryID").ToString) Then
                    tmpProduct.CatagoryID = Integer.Parse(drProductList("CatagoryID").ToString)
                End If

                tmpProduct.ProdName = drProductList("ProdName").ToString
                tmpProduct.LocationCode = drProductList("LocationCode").ToString
                tmpProduct.Model = drProductList("Model").ToString
                tmpProduct.BinNmbr = drProductList("BinNmbr").ToString
                tmpProduct.Country = drProductList("Country").ToString
                tmpProduct.Maker = drProductList("Maker").ToString
                tmpProduct.Measure = drProductList("Measure").ToString
                If Not String.IsNullOrEmpty(drProductList("QtyAvl").ToString) Then
                    tmpProduct.QtyAvl = Integer.Parse(drProductList("QtyAvl").ToString)
                End If
                If Not String.IsNullOrEmpty(drProductList("UnitPrice").ToString) Then
                    tmpProduct.UnitPrice = Double.Parse(drProductList("UnitPrice").ToString)
                End If

                If Not String.IsNullOrEmpty(drProductList("MaxOrder").ToString) Then
                    tmpProduct.MaxOrder = Integer.Parse(drProductList("MaxOrder").ToString)
                End If

                If Not String.IsNullOrEmpty(drProductList("Discontinued").ToString) Then
                    tmpProduct.Discontinued = Integer.Parse(drProductList("Discontinued").ToString)
                End If

                If Not String.IsNullOrEmpty(drProductList("Sales").ToString) Then
                    tmpProduct.Sales = Integer.Parse(drProductList("Sales").ToString)
                End If

                tmpProduct.Tag = drProductList("Tag").ToString
                tmpProduct.UserName = drProductList("UserName").ToString
                If Not String.IsNullOrEmpty(drProductList("Date_Time").ToString) Then
                    tmpProduct.Date_Time = Date.Parse(drProductList("Date_Time").ToString)
                End If
                If Not String.IsNullOrEmpty(drProductList("ReorderDate").ToString) Then
                    tmpProduct.ReorderDate = Date.Parse(drProductList("ReorderDate").ToString)
                End If

                tmpProduct.ReorderTag = drProductList("ReorderTag").ToString
                If Not String.IsNullOrEmpty(drProductList("DollerPrice").ToString) Then
                    tmpProduct.DollerPrice = Double.Parse(drProductList("DollerPrice").ToString)
                End If

                If Not String.IsNullOrEmpty(drProductList("OP").ToString) Then
                    tmpProduct.OP = Integer.Parse(drProductList("OP").ToString)
                End If

                If Not String.IsNullOrEmpty(drProductList("UPNO").ToString) Then
                    tmpProduct.UPNO = Integer.Parse(drProductList("UPNO").ToString)
                End If

                tmpProduct.TrackNO = drProductList("TrackNO").ToString



            End While

        End Using

        Return tmpProduct


    End Function


    Public Function GetProductStartWithLetter(ByVal SearchCode As String) As clsProduct


        Dim tmpProduct As clsProduct = New clsProduct
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString




        Using con As OleDbConnection = New OleDbConnection(cs)

            Dim dcProductList As OleDbCommand = New OleDbCommand("qryGetProductStartWithLetter", con)

            dcProductList.CommandType = CommandType.StoredProcedure
            dcProductList.Parameters.Add("ParamCode1", OleDbType.Char, 255).Value = SearchCode & "%"

            con.Open()

            Dim drProductList As OleDbDataReader = dcProductList.ExecuteReader

            While drProductList.Read



                If Not String.IsNullOrEmpty(drProductList("ProductID").ToString) Then
                    tmpProduct.ProductID = Integer.Parse(drProductList("ProductID").ToString)
                End If

                tmpProduct.Code = drProductList("Code").ToString
                tmpProduct.RPCode = drProductList("RPCode").ToString
                If Not String.IsNullOrEmpty(drProductList("CatagoryID").ToString) Then
                    tmpProduct.CatagoryID = Integer.Parse(drProductList("CatagoryID").ToString)
                End If

                tmpProduct.ProdName = drProductList("ProdName").ToString
                tmpProduct.LocationCode = drProductList("LocationCode").ToString
                tmpProduct.Model = drProductList("Model").ToString
                tmpProduct.BinNmbr = drProductList("BinNmbr").ToString
                tmpProduct.Country = drProductList("Country").ToString
                tmpProduct.Maker = drProductList("Maker").ToString
                tmpProduct.Measure = drProductList("Measure").ToString
                If Not String.IsNullOrEmpty(drProductList("QtyAvl").ToString) Then
                    tmpProduct.QtyAvl = Integer.Parse(drProductList("QtyAvl").ToString)
                End If
                If Not String.IsNullOrEmpty(drProductList("UnitPrice").ToString) Then
                    tmpProduct.UnitPrice = Double.Parse(drProductList("UnitPrice").ToString)
                End If

                If Not String.IsNullOrEmpty(drProductList("MaxOrder").ToString) Then
                    tmpProduct.MaxOrder = Integer.Parse(drProductList("MaxOrder").ToString)
                End If

                If Not String.IsNullOrEmpty(drProductList("Discontinued").ToString) Then
                    tmpProduct.Discontinued = Integer.Parse(drProductList("Discontinued").ToString)
                End If

                If Not String.IsNullOrEmpty(drProductList("Sales").ToString) Then
                    tmpProduct.Sales = Integer.Parse(drProductList("Sales").ToString)
                End If

                tmpProduct.Tag = drProductList("Tag").ToString
                tmpProduct.UserName = drProductList("UserName").ToString
                If Not String.IsNullOrEmpty(drProductList("Date_Time").ToString) Then
                    tmpProduct.Date_Time = Date.Parse(drProductList("Date_Time").ToString)
                End If
                If Not String.IsNullOrEmpty(drProductList("ReorderDate").ToString) Then
                    tmpProduct.ReorderDate = Date.Parse(drProductList("ReorderDate").ToString)
                End If

                tmpProduct.ReorderTag = drProductList("ReorderTag").ToString
                If Not String.IsNullOrEmpty(drProductList("DollerPrice").ToString) Then
                    tmpProduct.DollerPrice = Double.Parse(drProductList("DollerPrice").ToString)
                End If

                If Not String.IsNullOrEmpty(drProductList("OP").ToString) Then
                    tmpProduct.OP = Integer.Parse(drProductList("OP").ToString)
                End If

                If Not String.IsNullOrEmpty(drProductList("UPNO").ToString) Then
                    tmpProduct.UPNO = Integer.Parse(drProductList("UPNO").ToString)
                End If

                tmpProduct.TrackNO = drProductList("TrackNO").ToString



            End While

        End Using

        Return tmpProduct


    End Function





    Public Sub Save(ByVal Product As clsProduct)


        Dim tmpProduct As clsProduct = New clsProduct
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcProductList As OleDbCommand = New OleDbCommand("qryInsertProduct", con)

            dcProductList.CommandType = CommandType.StoredProcedure

            dcProductList.Parameters.Add("ProductID1", OleDbType.Integer).Value = If(String.IsNullOrEmpty(Product.ProductID), DBNull.Value, Product.ProductID)
            dcProductList.Parameters.Add("Code1", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(Product.Code), DBNull.Value, Product.Code)
            dcProductList.Parameters.Add("RPCode1", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(Product.RPCode), DBNull.Value, Product.RPCode)
            dcProductList.Parameters.Add("CatagoryID1", OleDbType.Integer).Value = If(String.IsNullOrEmpty(Product.CatagoryID), DBNull.Value, Product.CatagoryID)
            dcProductList.Parameters.Add("ProdName1", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(Product.ProdName), DBNull.Value, Product.ProdName)
            dcProductList.Parameters.Add("LocationCode1", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(Product.LocationCode), DBNull.Value, Product.LocationCode)
            dcProductList.Parameters.Add("Model1", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(Product.Model), DBNull.Value, Product.Model)
            dcProductList.Parameters.Add("BinNmbr1", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(Product.BinNmbr), DBNull.Value, Product.BinNmbr)
            dcProductList.Parameters.Add("Country1", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(Product.Country), DBNull.Value, Product.Country)
            dcProductList.Parameters.Add("Maker1", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(Product.Maker), DBNull.Value, Product.Maker)
            dcProductList.Parameters.Add("Measure1", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(Product.Measure), DBNull.Value, Product.Measure)
            dcProductList.Parameters.Add("QtyAvl1", OleDbType.Integer).Value = If(String.IsNullOrEmpty(Product.QtyAvl), DBNull.Value, Product.QtyAvl)
            dcProductList.Parameters.Add("UnitPrice1", OleDbType.Double).Value = If(String.IsNullOrEmpty(Product.UnitPrice), DBNull.Value, Product.UnitPrice)
            dcProductList.Parameters.Add("MaxOrder1", OleDbType.Integer).Value = If(String.IsNullOrEmpty(Product.MaxOrder), DBNull.Value, Product.MaxOrder)
            dcProductList.Parameters.Add("Discontinued1", OleDbType.Boolean).Value = If(String.IsNullOrEmpty(Product.Discontinued), DBNull.Value, Product.Discontinued) ' Discontinued Should be 0 or -1
            dcProductList.Parameters.Add("Sales1", OleDbType.Boolean).Value = If(String.IsNullOrEmpty(Product.Sales), DBNull.Value, Product.Sales) ' Sales Should be 0 or -1
            dcProductList.Parameters.Add("Tag1", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(Product.Tag), DBNull.Value, Product.Tag)
            dcProductList.Parameters.Add("UserName1", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(Product.UserName), DBNull.Value, Product.UserName)
            dcProductList.Parameters.Add("Date_Time1", OleDbType.Date).Value = If(String.IsNullOrEmpty(Product.Date_Time), DBNull.Value, Product.Date_Time)
            dcProductList.Parameters.Add("ReorderDate1", OleDbType.Date, 255).Value = If(String.IsNullOrEmpty(Product.ReorderDate), DBNull.Value, Product.ReorderDate)
            dcProductList.Parameters.Add("ReorderTag1", OleDbType.Boolean, 255).Value = If(String.IsNullOrEmpty(Product.ReorderTag), DBNull.Value, Product.ReorderTag) ' Reorder Tag Should be 0 or -1
            dcProductList.Parameters.Add("DollerPrice1", OleDbType.Double).Value = If(String.IsNullOrEmpty(Product.DollerPrice), DBNull.Value, Product.DollerPrice)
            dcProductList.Parameters.Add("OP1", OleDbType.Double).Value = If(String.IsNullOrEmpty(Product.OP), DBNull.Value, Product.OP)
            dcProductList.Parameters.Add("UPNO1", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(Product.UPNO), DBNull.Value, Product.UPNO)
            dcProductList.Parameters.Add("TrackNO1", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(Product.TrackNO), DBNull.Value, Product.TrackNO)

            con.Open()

            dcProductList.ExecuteNonQuery()


        End Using




    End Sub





    Public Sub Update(ByVal Product As clsProduct, ByVal SearchCode As String)


        Dim tmpProduct As clsProduct = New clsProduct
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString




        Using con As OleDbConnection = New OleDbConnection(cs)

            Dim dcProductList As OleDbCommand = New OleDbCommand("qryUpdateProduct", con)

            dcProductList.CommandType = CommandType.StoredProcedure


            dcProductList.Parameters.Add("Code1", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(Product.Code), DBNull.Value, Product.Code)
            dcProductList.Parameters.Add("RPCode1", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(Product.RPCode), DBNull.Value, Product.RPCode)
            dcProductList.Parameters.Add("CatagoryID1", OleDbType.Integer).Value = If(String.IsNullOrEmpty(Product.CatagoryID), DBNull.Value, Product.CatagoryID)
            dcProductList.Parameters.Add("ProdName1", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(Product.ProdName), DBNull.Value, Product.ProdName)
            dcProductList.Parameters.Add("LocationCode1", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(Product.LocationCode), DBNull.Value, Product.LocationCode)
            dcProductList.Parameters.Add("Model1", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(Product.Model), DBNull.Value, Product.Model)
            dcProductList.Parameters.Add("BinNmbr1", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(Product.BinNmbr), DBNull.Value, Product.BinNmbr)
            dcProductList.Parameters.Add("Country1", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(Product.Country), DBNull.Value, Product.Country)
            dcProductList.Parameters.Add("Maker1", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(Product.Maker), DBNull.Value, Product.Maker)
            dcProductList.Parameters.Add("Measure1", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(Product.Measure), DBNull.Value, Product.Measure)
            dcProductList.Parameters.Add("QtyAvl1", OleDbType.Integer).Value = If(String.IsNullOrEmpty(Product.QtyAvl), DBNull.Value, Product.QtyAvl)
            dcProductList.Parameters.Add("UnitPrice1", OleDbType.Double).Value = If(String.IsNullOrEmpty(Product.UnitPrice), DBNull.Value, Product.UnitPrice)
            dcProductList.Parameters.Add("MaxOrder1", OleDbType.Integer).Value = If(String.IsNullOrEmpty(Product.MaxOrder), DBNull.Value, Product.MaxOrder)
            dcProductList.Parameters.Add("Discontinued1", OleDbType.Boolean).Value = If(String.IsNullOrEmpty(Product.Discontinued), DBNull.Value, Product.Discontinued) ' Discontinued Should be 0 or -1
            dcProductList.Parameters.Add("Sales1", OleDbType.Boolean).Value = If(String.IsNullOrEmpty(Product.Sales), DBNull.Value, Product.Sales) ' Sales Should be 0 or -1
            dcProductList.Parameters.Add("Tag1", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(Product.Tag), DBNull.Value, Product.Tag)
            dcProductList.Parameters.Add("UserName1", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(Product.UserName), DBNull.Value, Product.UserName)
            dcProductList.Parameters.Add("Date_Time1", OleDbType.Date).Value = If(String.IsNullOrEmpty(Product.Date_Time), DBNull.Value, Product.Date_Time)
            dcProductList.Parameters.Add("ReorderDate1", OleDbType.Date, 255).Value = If(String.IsNullOrEmpty(Product.ReorderDate), DBNull.Value, Product.ReorderDate)
            dcProductList.Parameters.Add("ReorderTag1", OleDbType.Boolean, 255).Value = If(String.IsNullOrEmpty(Product.ReorderTag), DBNull.Value, Product.ReorderTag) ' Reorder Tag Should be 0 or -1
            dcProductList.Parameters.Add("DollerPrice1", OleDbType.Double).Value = If(String.IsNullOrEmpty(Product.DollerPrice), DBNull.Value, Product.DollerPrice)
            dcProductList.Parameters.Add("OP1", OleDbType.Double).Value = If(String.IsNullOrEmpty(Product.OP), DBNull.Value, Product.OP)
            dcProductList.Parameters.Add("UPNO1", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(Product.UPNO), DBNull.Value, Product.UPNO)
            dcProductList.Parameters.Add("TrackNO1", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(Product.TrackNO), DBNull.Value, Product.TrackNO)
            dcProductList.Parameters.Add("Code2", OleDbType.Char, 255).Value = SearchCode

            con.Open()

            dcProductList.ExecuteNonQuery()


        End Using




    End Sub




    Public Sub Delete(ByVal DeleteCode As String)


        Dim tmpProduct As clsProduct = New clsProduct
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString




        Using con As OleDbConnection = New OleDbConnection(cs)

            Dim dcProductList As OleDbCommand = New OleDbCommand("qryDeleteProduct", con)

            dcProductList.CommandType = CommandType.StoredProcedure

            dcProductList.Parameters.Add("ParamCode1", OleDbType.Char, 255).Value = DeleteCode

            con.Open()

            dcProductList.ExecuteNonQuery()


        End Using




    End Sub



    Public Function GetMaxID() As Integer
        Dim tmpProduct As clsProduct = New clsProduct
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Dim GetId As Integer



        Using con As OleDbConnection = New OleDbConnection(cs)

            Dim dcProductList As OleDbCommand = New OleDbCommand("Select max(Product.ProductID) from Product", con)

            dcProductList.CommandType = CommandType.Text



            con.Open()

            GetId = dcProductList.ExecuteScalar()
            GetId += 1

        End Using



        Return GetId
    End Function



    Public Function LoadProductModel() As DataTable
        Dim tmpProduct As clsProduct = New clsProduct
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Dim tmpdt As DataTable = New DataTable



        Using con As OleDbConnection = New OleDbConnection(cs)

            Dim dcModelList As OleDbCommand = New OleDbCommand("Select Distinct Model from Product", con)

            dcModelList.CommandType = CommandType.Text



            con.Open()
            Dim drModelList As OleDbDataReader = dcModelList.ExecuteReader

            If drModelList.HasRows = True Then

                tmpdt.Load(drModelList)


            End If



        End Using



        Return tmpdt
    End Function


    Public Function LoadProductSource() As DataTable
        Dim tmpProduct As clsProduct = New clsProduct
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Dim tmpdt As DataTable = New DataTable



        Using con As OleDbConnection = New OleDbConnection(cs)

            Dim dcSourceList As OleDbCommand = New OleDbCommand("Select Distinct Country from Product", con)

            dcSourceList.CommandType = CommandType.Text



            con.Open()
            Dim drSourceList As OleDbDataReader = dcSourceList.ExecuteReader

            If drSourceList.HasRows = True Then

                tmpdt.Load(drSourceList)


            End If



        End Using



        Return tmpdt
    End Function


End Class
