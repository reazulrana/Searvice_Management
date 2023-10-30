Imports System.Configuration
Imports System.Data.OleDb

Public Class clsBrandModelMethods


    Public ReadOnly Property ModelList() As IEnumerable(Of clsBrandModel)
        Get

            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

            Dim ListofModel As List(Of clsBrandModel) = New List(Of clsBrandModel)


            'Dim strQuery As String = "Select BrandModel.MdID, BrandModel.Model,BrandModel.BrdID,BrandModel.Charge,BrandModel.WPeriod,BrandModel.Item,BrandModel.SLNO,BrandModel.SIze,BrandModel.EntryDate,BrandModel.Remarks from BrandModel order by BrandModel.Model"
            Dim strQuery As String = "Select * from BrandModel order by BrandModel.Model "
            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dcGetFilterModel As OleDbCommand = New OleDbCommand(strQuery, con)
                dcGetFilterModel.CommandType = CommandType.Text

                    con.Open()

                    Dim drgetFilterModel As OleDbDataReader = dcGetFilterModel.ExecuteReader


                    While drgetFilterModel.Read
                        Dim Model As clsBrandModel = New clsBrandModel

                        If Not String.IsNullOrEmpty(drgetFilterModel("MdID").ToString) Then
                            Model.MdID = Convert.ToInt32(drgetFilterModel("MdID").ToString)

                    End If

                        Model.Model = drgetFilterModel("Model").ToString


                        If Not String.IsNullOrEmpty(drgetFilterModel("BrdID").ToString) Then
                            Model.BrdID = drgetFilterModel("BrdID").ToString
                        End If

                        If Not String.IsNullOrEmpty(drgetFilterModel("Charge").ToString) Then
                            Model.Charge = Convert.ToDouble(drgetFilterModel("Charge").ToString)
                        End If

                        If Not String.IsNullOrEmpty(drgetFilterModel("WPeriod").ToString) Then
                            Model.WPeriod = Convert.ToDouble(drgetFilterModel("WPeriod").ToString)
                        End If

                        Model.Item = drgetFilterModel("Item").ToString

                        If Not String.IsNullOrEmpty(drgetFilterModel("SLNO").ToString) Then
                            Model.SLNO = Convert.ToInt32(drgetFilterModel("SLNO").ToString)
                        End If

                        Model.Size = drgetFilterModel("Size").ToString

                    If Not String.IsNullOrEmpty(drgetFilterModel("EntryDate").ToString) Then
                        Model.EntryDate = DateTime.Parse(drgetFilterModel("EntryDate").ToString).ToString("dd-MMM-yy")
                    Else
                        Model.EntryDate = Nothing
                    End If
                        Model.Remarks = drgetFilterModel("Remarks").ToString
                        ListofModel.Add(Model)

                    End While




                End Using


            Return ListofModel



        End Get
    End Property



    Public ReadOnly Property Filter(ByVal Where As String) As IEnumerable(Of clsBrandModel)
        Get

            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

            Dim ListofModel As List(Of clsBrandModel) = New List(Of clsBrandModel)


            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dcGetFilterModel As OleDbCommand = New OleDbCommand("Select Distinct brandmodel.Model from BrandModel where Brandmodel.brdid in(" + Where + ")  order by BrandModel.Model ", con)
                dcGetFilterModel.CommandType = CommandType.Text

                con.Open()

                Dim drgetFilterModel As OleDbDataReader = dcGetFilterModel.ExecuteReader


                While drgetFilterModel.Read
                    Dim Model As clsBrandModel = New clsBrandModel
                    Model.Model = drgetFilterModel("Model").ToString
                    ListofModel.Add(Model)

                End While




            End Using



            Return ListofModel



        End Get
    End Property



    Public ReadOnly Property IsExist(ByVal Model As String, ByVal BrandID As Integer) As Boolean
        Get

            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

            Dim blnFlag As Boolean = False

            Try



                Using con As OleDbConnection = New OleDbConnection(cs)
                    Dim dcGetFilterModel As OleDbCommand = New OleDbCommand("Select  brandmodel.Model from BrandModel where Brandmodel.brdid=@brdid and BrandModel.Model=@Model  order by BrandModel.Model ", con)

                    dcGetFilterModel.CommandType = CommandType.Text
                    dcGetFilterModel.Parameters.Add("@brdid", OleDbType.Integer).Value = BrandID
                    dcGetFilterModel.Parameters.Add("@Model", OleDbType.Char, 255).Value = Model

                    con.Open()

                    Dim drgetFilterModel As OleDbDataReader = dcGetFilterModel.ExecuteReader


                    If drgetFilterModel.HasRows = True Then
                        blnFlag = True
                    End If
                End Using
            Catch ex As Exception
                blnFlag = False

            End Try
            Return blnFlag
        End Get
    End Property


    Public ReadOnly Property HasRow() As Boolean
        Get

            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

            Dim blnFlag As Boolean = False


            Try

                Using con As OleDbConnection = New OleDbConnection(cs)
                    Dim dcGetFilterModel As OleDbCommand = New OleDbCommand("Select  * from BrandModel", con)

                    dcGetFilterModel.CommandType = CommandType.Text

                    con.Open()

                    Dim drgetFilterModel As OleDbDataReader = dcGetFilterModel.ExecuteReader
                    If drgetFilterModel.HasRows = True Then
                        blnFlag = True
                    End If
                End Using

            Catch ex As Exception
                blnFlag = False
            End Try
            Return blnFlag
        End Get
    End Property






    Public ReadOnly Property GetTableFilter(ByVal Where As Integer) As DataTable
        Get
            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
            Dim dt As DataTable = New DataTable

            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dcGetTableFilterModel As OleDbCommand = New OleDbCommand("Select Distinct brandmodel.Model from BrandModel where Brandmodel.brdid=@brdid order by BrandModel.Model ", con)
                dcGetTableFilterModel.CommandType = CommandType.Text
                dcGetTableFilterModel.Parameters.Add("@brdid", OleDbType.Integer).Value = Where
                con.Open()
                Dim drgetTableFilterModel As OleDbDataReader = dcGetTableFilterModel.ExecuteReader
                If drgetTableFilterModel.HasRows = True Then
                    dt.Load(drgetTableFilterModel)
                End If
            End Using
            Return dt
        End Get
    End Property

    Public ReadOnly Property GetModelCharge(ByVal Where As String) As Double
        Get
            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
            Dim dblModelCharge As Double = 0


            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dcGetTableFilterModel As OleDbCommand = New OleDbCommand("Select Distinct brandmodel.Charge from BrandModel where " & Where, con) '" Brandmodel.brdid=@brdid order by BrandModel.Model ", con)
                dcGetTableFilterModel.CommandType = CommandType.Text
                dcGetTableFilterModel.Parameters.Add("@brdid", OleDbType.Char, 255).Value = Where
                con.Open()
                Dim drgetTableFilterModel As OleDbDataReader = dcGetTableFilterModel.ExecuteReader
                If drgetTableFilterModel.HasRows = True Then
                    drgetTableFilterModel.Read()
                    dblModelCharge = Integer.Parse(drgetTableFilterModel("Charge").ToString)

                End If
            End Using
            Return dblModelCharge
        End Get
    End Property


    Public Function GetModelListWithBrand(ByVal WhereClause As String) As List(Of clsBrandModel)

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim dblModelCharge As Double = 0
        Dim ListBrandmodel As List(Of clsBrandModel) = New List(Of clsBrandModel)
        Dim strSQL As String = String.Empty

        If String.IsNullOrEmpty(WhereClause.Trim) Then
            strSQL = "Select Distinct BrandModel.Model from BrandModel"
        Else

            strSQL = "Select Distinct BrandModel.Model from BrandModel where BrandModel.brdid IN(" & WhereClause & ") Order by BrandModel.Model"

        End If


        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcGetTableFilterModel As OleDbCommand = New OleDbCommand(strSQL, con) '" Brandmodel.brdid=@brdid order by BrandModel.Model ", con)
            dcGetTableFilterModel.CommandType = CommandType.Text

            con.Open()
            Dim drgetTableFilterModel As OleDbDataReader = dcGetTableFilterModel.ExecuteReader

            If drgetTableFilterModel.HasRows = True Then
                While drgetTableFilterModel.Read()
                    Dim BrandModel As clsBrandModel = New clsBrandModel

                    BrandModel.Model = drgetTableFilterModel("Model").ToString()

                    ListBrandmodel.Add(BrandModel)

                End While


            End If
        End Using
        Return ListBrandmodel


    End Function




    Public Sub UpdateServiceCharge(ByVal ServiceCharge As Double, ByVal strModel As String, ByVal intBrdID As Integer)
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dc As OleDbCommand = New OleDbCommand("Update BrandModel set BrandModel.Charge=@Charge where BrandModel.Model=@Model and BrandModel.BrdID=@BrdID", con)
            dc.Parameters.Add("@Charge", OleDbType.Double).Value = ServiceCharge
            dc.Parameters.Add("@Model", OleDbType.Char, 50).Value = strModel
            dc.Parameters.Add("@BrdID", OleDbType.Integer).Value = intBrdID
            con.Open()
            dc.ExecuteNonQuery()
        End Using
    End Sub



    Public Sub Save(ByVal BrandModel As clsBrandModel)

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dc As OleDbCommand = New OleDbCommand("qryInsertBrandModel", con)
            dc.CommandType = CommandType.StoredProcedure
            dc.Parameters.Add("@Model", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(BrandModel.Model), DBNull.Value, BrandModel.Model)
            dc.Parameters.Add("@BrdID", OleDbType.Integer).Value = IIf(String.IsNullOrEmpty(BrandModel.BrdID), DBNull.Value, BrandModel.BrdID)
            dc.Parameters.Add("@Charge", OleDbType.Double, 255).Value = IIf(String.IsNullOrEmpty(BrandModel.Charge), DBNull.Value, BrandModel.Charge)
            dc.Parameters.Add("@WPeriod", OleDbType.Integer, 255).Value = IIf(String.IsNullOrEmpty(BrandModel.WPeriod), DBNull.Value, BrandModel.WPeriod)
            dc.Parameters.Add("@Item", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(BrandModel.Item), DBNull.Value, BrandModel.Item)
            dc.Parameters.Add("@SLNO", OleDbType.Integer, 255).Value = IIf(String.IsNullOrEmpty(BrandModel.SLNO), DBNull.Value, BrandModel.SLNO)
            dc.Parameters.Add("@SIze", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(BrandModel.SIze), DBNull.Value, BrandModel.SIze)
            dc.Parameters.Add("@EntryDate", OleDbType.Date, 255).Value = IIf(String.IsNullOrEmpty(DateTime.Parse(BrandModel.EntryDate)), DBNull.Value, DateTime.Parse(BrandModel.EntryDate))
            dc.Parameters.Add("@Remarks", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(BrandModel.Remarks), DBNull.Value, BrandModel.Remarks)
            con.Open()
            dc.ExecuteNonQuery()
        End Using


    End Sub



    Public Sub Update(ByVal BrandModel As clsBrandModel, ByVal Model As String, ByVal BrandID As Integer)

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Dim strQuery As String = String.Empty
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dc As OleDbCommand = New OleDbCommand("qryUpdateBrandModel", con)
            dc.CommandType = CommandType.StoredProcedure
            dc.Parameters.Add("@Model", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(BrandModel.Model), DBNull.Value, BrandModel.Model)
            dc.Parameters.Add("@BrdID", OleDbType.Integer).Value = IIf(String.IsNullOrEmpty(BrandModel.BrdID), DBNull.Value, BrandModel.BrdID)
            dc.Parameters.Add("@Charge", OleDbType.Double, 255).Value = IIf(String.IsNullOrEmpty(BrandModel.Charge), DBNull.Value, BrandModel.Charge)
            dc.Parameters.Add("@WPeriod", OleDbType.Integer, 255).Value = IIf(String.IsNullOrEmpty(BrandModel.WPeriod), DBNull.Value, BrandModel.WPeriod)
            dc.Parameters.Add("@Item", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(BrandModel.Item), DBNull.Value, BrandModel.Item)
            dc.Parameters.Add("@SLNO", OleDbType.Integer, 255).Value = IIf(String.IsNullOrEmpty(BrandModel.SLNO), DBNull.Value, BrandModel.SLNO)
            dc.Parameters.Add("@SIze", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(BrandModel.SIze), DBNull.Value, BrandModel.SIze)
            dc.Parameters.Add("@EntryDate", OleDbType.Date, 255).Value = IIf(String.IsNullOrEmpty(DateTime.Parse(BrandModel.EntryDate)), DBNull.Value, DateTime.Parse(BrandModel.EntryDate))
            dc.Parameters.Add("@Remarks", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(BrandModel.Remarks), DBNull.Value, BrandModel.Remarks)
            dc.Parameters.Add("@Model1", OleDbType.Char, 255).Value = Model
            dc.Parameters.Add("@BrdID1", OleDbType.Char, 255).Value = BrandID


            con.Open()
            dc.ExecuteNonQuery()
        End Using
    End Sub


End Class
