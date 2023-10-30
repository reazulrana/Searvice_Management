Imports System
Imports System.Data.OleDb
Imports System.Data
Imports System.Configuration


Public Class clsServiceDetailsMethods




    Public Sub save(ByVal Insertmodel As clsServiceDetails)

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcSaveService As OleDbCommand = New OleDbCommand("qryInsertServiceDetails", con)
            dcSaveService.CommandType = CommandType.StoredProcedure
            dcSaveService.Parameters.Add("paramJobCode", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(Insertmodel.Jobcode), DBNull.Value, Insertmodel.Jobcode)
            dcSaveService.Parameters.Add("paramDescription", OleDbType.Char, 10000).Value = If(String.IsNullOrEmpty(Insertmodel.Description), DBNull.Value, Insertmodel.Description)

            con.Open()
            dcSaveService.ExecuteNonQuery()
        End Using

    End Sub











    Public Sub Update(ByVal Updatemodel As clsServiceDetails, ByVal UpdateCriteria As String)

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcSaveService As OleDbCommand = New OleDbCommand("qryUpdateServiceDetails", con)
            dcSaveService.CommandType = CommandType.StoredProcedure
            dcSaveService.Parameters.Add("paramJobCode", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(Updatemodel.Jobcode), DBNull.Value, Updatemodel.Jobcode)
            dcSaveService.Parameters.Add("paramDescription", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(Updatemodel.Description), DBNull.Value, Updatemodel.Description)
            dcSaveService.Parameters.Add("paramJobCode2", OleDbType.Char, 10000).Value = UpdateCriteria

            con.Open()
            dcSaveService.ExecuteNonQuery()




        End Using

    End Sub






    Public Sub Delete(ByVal DeleteCriteria As String)

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcSaveService As OleDbCommand = New OleDbCommand("qryDeleteServiceDetails", con)
            dcSaveService.CommandType = CommandType.StoredProcedure
            dcSaveService.Parameters.Add("paramJobCode", OleDbType.Char, 255).Value = DeleteCriteria

            con.Open()
            dcSaveService.ExecuteNonQuery()




        End Using

    End Sub

    Public Function GetPartsDetails(ByVal SearchCriteria As String) As clsServiceDetails
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim servicedetails As clsServiceDetails = New clsServiceDetails
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcGetParts As OleDbCommand = New OleDbCommand("qryGet_ServiceDetails_byJobCode", con)
            dcGetParts.CommandType = CommandType.StoredProcedure
            dcGetParts.Parameters.Add("paramJobCode", OleDbType.Char, 255).Value = SearchCriteria
            con.Open()
            Dim drGetParts As OleDbDataReader = dcGetParts.ExecuteReader
            While drGetParts.Read
                servicedetails.SDID = Convert.ToInt32(drGetParts("SDID").ToString)
                servicedetails.Jobcode = drGetParts("JobCode").ToString
                servicedetails.Description = drGetParts("Description").ToString
            End While
        End Using
        Return servicedetails
    End Function


    Public Function IsExist(ByVal SearchCriteria As String) As Boolean

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim blnFlag As Boolean = False

        Try



            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dcGetParts As OleDbCommand = New OleDbCommand("qryGet_ServiceDetails_byJobCode", con)
                dcGetParts.CommandType = CommandType.StoredProcedure
                dcGetParts.Parameters.Add("paramJobCode", OleDbType.Char, 255).Value = SearchCriteria

                con.Open()
                Dim drGetParts As OleDbDataReader = dcGetParts.ExecuteReader

                If drGetParts.HasRows = True Then
                    blnFlag = True
                End If
            End Using
        Catch ex As Exception
            blnFlag = False

        End Try
        Return blnFlag
    End Function






    Public Sub Save_Temp_ServiceDetails(ByVal Insertmodel As clsServiceDetails)

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Dim strSqlQuery = "insert into ServiceDetailsDetails(JobCode,ProductCode,Qty,UnitPrice,Remarks) values(@JobCode,@ProductCode,@Qty,@UnitPrice,@Remarks)"

        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcSaveService As OleDbCommand = New OleDbCommand(strSqlQuery, con)
            dcSaveService.CommandType = CommandType.Text
            dcSaveService.Parameters.Add("@JobCode", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(Insertmodel.Jobcode), DBNull.Value, Insertmodel.Jobcode)
            dcSaveService.Parameters.Add("@ProductCode", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(Insertmodel.ProductCode), DBNull.Value, Insertmodel.ProductCode)
            dcSaveService.Parameters.Add("@Qty", OleDbType.Double, 255).Value = If(String.IsNullOrEmpty(Insertmodel.Qty), DBNull.Value, Insertmodel.Qty)
            dcSaveService.Parameters.Add("@UnitPrice", OleDbType.Double, 255).Value = If(String.IsNullOrEmpty(Insertmodel.UnitPrice), DBNull.Value, Insertmodel.UnitPrice)
            dcSaveService.Parameters.Add("@Remarks", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(Insertmodel.Remarks), DBNull.Value, Insertmodel.Remarks)
            con.Open()
            dcSaveService.ExecuteNonQuery()
        End Using

    End Sub



    Public ReadOnly Property GetALL_Temp_ServiceDetails() As IEnumerable(Of clsServiceDetails)
        Get

            Dim ListServiceDetails As List(Of clsServiceDetails) = New List(Of clsServiceDetails)

            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

            Dim strSqlQuery = "Select * from ServiceDetailsDetails"

            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dcServiceDetails As OleDbCommand = New OleDbCommand(strSqlQuery, con)

                con.Open()

                Dim drServicedetails As OleDbDataReader = dcServiceDetails.ExecuteReader
                If drServicedetails.HasRows = True Then
                    While drServicedetails.Read

                        Dim servicedetails As clsServiceDetails = New clsServiceDetails
                        If Not String.IsNullOrEmpty(drServicedetails("Remarks").ToString) Then
                            servicedetails.Remarks = drServicedetails("Remarks").ToString
                        Else
                            servicedetails.Jobcode = drServicedetails("JobCode").ToString
                            servicedetails.ProductCode = drServicedetails("ProductCode").ToString
                            If Not String.IsNullOrEmpty(drServicedetails("Qty").ToString) Then
                                servicedetails.Qty = drServicedetails("Qty").ToString
                            End If
                            If Not String.IsNullOrEmpty(drServicedetails("UnitPrice").ToString) Then
                                servicedetails.UnitPrice = drServicedetails("UnitPrice").ToString
                            End If

                        End If

                        ListServiceDetails.Add(servicedetails)
                    End While
                End If


            End Using
            Return ListServiceDetails

        End Get
    End Property


    Public ReadOnly Property GetSingle_Temp_ServiceDetails(ByVal Checkid As String) As IEnumerable(Of clsServiceDetails)
        Get
            Dim ListServiceDetails As List(Of clsServiceDetails) = New List(Of clsServiceDetails)

            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

            Dim strSqlQuery = "Select * from ServiceDetailsDetails where ServiceDetailsDetails.JobCode=@JobCode"

            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dcServiceDetails As OleDbCommand = New OleDbCommand(strSqlQuery, con)
                dcServiceDetails.Parameters.Add("@JobCode", OleDbType.Char, 255).Value = Checkid
                con.Open()

                Dim drServicedetails As OleDbDataReader = dcServiceDetails.ExecuteReader
                If drServicedetails.HasRows = True Then
                    While drServicedetails.Read
                        Dim servicedetails As clsServiceDetails = New clsServiceDetails
                        If Not String.IsNullOrEmpty(drServicedetails("Remarks").ToString) Then
                            servicedetails.Remarks = drServicedetails("Remarks").ToString
                        Else
                            servicedetails.Jobcode = drServicedetails("JobCode").ToString
                            servicedetails.ProductCode = drServicedetails("ProductCode").ToString
                            If Not String.IsNullOrEmpty(drServicedetails("Qty").ToString) Then
                                servicedetails.Qty = drServicedetails("Qty").ToString
                            End If
                            If Not String.IsNullOrEmpty(drServicedetails("UnitPrice").ToString) Then
                                servicedetails.UnitPrice = drServicedetails("UnitPrice").ToString
                            End If

                        End If
                        ListServiceDetails.Add(servicedetails)
                    End While
                End If
            End Using
            Return ListServiceDetails

        End Get
    End Property

    Public ReadOnly Property isExist_Temp_ServiceDetails(ByVal Checkid As String) As Boolean
        Get
            Dim blnFlag As Boolean = False


            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

            Dim strSqlQuery = "Select * from ServiceDetailsDetails where ServiceDetailsDetails.JobCode=@JobCode"
            Try

                Using con As OleDbConnection = New OleDbConnection(cs)
                    Dim dcServiceDetails As OleDbCommand = New OleDbCommand(strSqlQuery, con)
                    dcServiceDetails.Parameters.Add("@JobCode", OleDbType.Char, 255).Value = Checkid
                    con.Open()

                    Dim drServicedetails As OleDbDataReader = dcServiceDetails.ExecuteReader
                    If drServicedetails.HasRows = True Then
                        blnFlag = True
                    End If
                End Using


            Catch ex As Exception
                blnFlag = False

            End Try

            Return blnFlag
        End Get
    End Property

    Public Sub Delete_Temp_ServiceDetails(ByVal Checkid As String)


        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Dim strSqlQuery = "Delete * from ServiceDetailsDetails where ServiceDetailsDetails.JobCode=@JobCode"

        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcServiceDetails As OleDbCommand = New OleDbCommand(strSqlQuery, con)
            dcServiceDetails.Parameters.Add("@JobCode", OleDbType.Char, 255).Value = Checkid
            con.Open()
            dcServiceDetails.ExecuteNonQuery()

        End Using
    End Sub


    Public Sub save_Temp_Invoice(ByVal Insertmodel As clsServiceDetails)

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcSaveService As OleDbCommand = New OleDbCommand("qryInserttbiBillServiceDetails", con)
            dcSaveService.CommandType = CommandType.StoredProcedure
            dcSaveService.Parameters.Add("paramSDID", OleDbType.Integer, 255).Value = If(String.IsNullOrEmpty(Insertmodel.SDID), DBNull.Value, Insertmodel.SDID)
            dcSaveService.Parameters.Add("paramJobCode", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(Insertmodel.Jobcode), DBNull.Value, Insertmodel.Jobcode)
            dcSaveService.Parameters.Add("paramProductCode", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(Insertmodel.ProductCode), DBNull.Value, Insertmodel.ProductCode)
            dcSaveService.Parameters.Add("paramProdName", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(Insertmodel.Description), DBNull.Value, Insertmodel.Description)
            dcSaveService.Parameters.Add("paramQty", OleDbType.Double, 255).Value = If(String.IsNullOrEmpty(Insertmodel.Qty), DBNull.Value, Insertmodel.Qty)
            dcSaveService.Parameters.Add("paramUnitPrice", OleDbType.Double, 255).Value = If(String.IsNullOrEmpty(Insertmodel.UnitPrice), DBNull.Value, Insertmodel.UnitPrice)
            dcSaveService.Parameters.Add("paramRemarks", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(Insertmodel.Remarks), DBNull.Value, Insertmodel.Remarks)

            con.Open()
            dcSaveService.ExecuteNonQuery()
        End Using

    End Sub




    Public Sub UpdateInvoice(ByVal Updatemodel As clsServiceDetails, ByVal UpdateCriteria As String)

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcSaveService As OleDbCommand = New OleDbCommand("qryUpdatetbiBillServiceDetails", con)
            dcSaveService.CommandType = CommandType.StoredProcedure
            dcSaveService.Parameters.Add("paramJobCode", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(Updatemodel.Jobcode), DBNull.Value, Updatemodel.Jobcode)
            dcSaveService.Parameters.Add("paramProductCode", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(Updatemodel.ProductCode), DBNull.Value, Updatemodel.ProductCode)
            dcSaveService.Parameters.Add("paramQty", OleDbType.Double, 255).Value = If(String.IsNullOrEmpty(Updatemodel.Qty), DBNull.Value, Updatemodel.Qty)
            dcSaveService.Parameters.Add("paramUnitPrice", OleDbType.Double, 255).Value = If(String.IsNullOrEmpty(Updatemodel.UnitPrice), DBNull.Value, Updatemodel.UnitPrice)
            dcSaveService.Parameters.Add("paramRemarks", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(Updatemodel.Remarks), DBNull.Value, Updatemodel.Remarks)
            dcSaveService.Parameters.Add("paramJobCode2", OleDbType.Char, 255).Value = UpdateCriteria

            con.Open()
            dcSaveService.ExecuteNonQuery()




        End Using

    End Sub





    Public Sub Delete_tmp_invoice_PartsDetails(ByVal DeleteCriteria As String)

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcSaveService As OleDbCommand = New OleDbCommand("qryDeletetbiBillServiceDetails", con)
            dcSaveService.CommandType = CommandType.StoredProcedure
            dcSaveService.Parameters.Add("paramJobCode", OleDbType.Char, 255).Value = DeleteCriteria

            con.Open()
            dcSaveService.ExecuteNonQuery()




        End Using

    End Sub






    Public Function Get_Temp_Invoice_PartsDetails(ByVal SearchCriteria As String) As IEnumerable(Of clsServiceDetails)

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString


        Dim lstServiceDetails As List(Of clsServiceDetails) = New List(Of clsServiceDetails)


        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcGetParts As OleDbCommand = New OleDbCommand("qryGet_tbiBillServiceDetails_Job", con)
            dcGetParts.CommandType = CommandType.StoredProcedure
            dcGetParts.Parameters.Add("paramJobCode", OleDbType.Char, 255).Value = SearchCriteria

            con.Open()
            Dim drGetParts As OleDbDataReader = dcGetParts.ExecuteReader

            While drGetParts.Read
                Dim servicedetails As clsServiceDetails = New clsServiceDetails
                servicedetails.SDID = Convert.ToInt32(drGetParts("SDID").ToString)
                servicedetails.Jobcode = drGetParts("JobCode").ToString
                servicedetails.ProductCode = drGetParts("ProductCode").ToString
                If Not String.IsNullOrEmpty(drGetParts("Qty").ToString) Then

                    servicedetails.Qty = Convert.ToInt32(drGetParts("Qty").ToString)

                End If
                If Not String.IsNullOrEmpty(drGetParts("UnitPrice").ToString) Then
                    servicedetails.UnitPrice = Convert.ToInt32(drGetParts("UnitPrice").ToString)
                End If

                servicedetails.Remarks = drGetParts("Remarks").ToString

                lstServiceDetails.Add(servicedetails)


            End While




        End Using
        Return lstServiceDetails
    End Function







    Public Function SearchoDetails(ByVal SearchCriteria As String) As DataTable

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString


        Dim strQuery As String = "SELECT ClaimInfo.JobCode, ClaimInfo.Branch, ClaimInfo.CustName, ClaimInfo.CustAddress1, ClaimInfo.CustAddress2, ClaimInfo.Brand, ClaimInfo.ModelNo, ClaimInfo.MobileNo, ClaimInfo.ESN, ClaimInfo.SLNo, ClaimInfo.ReceptDate, ClaimInfo.AppDelDate, ClaimInfo.ServiceType, ClaimInfo.PDate, ClaimInfo.ReceptBy, ClaimInfo.IssueTo, ClaimInfo.IsssueDate, ClaimInfo.SDate, ClaimInfo.ServiceBy, ClaimInfo.DDate, ClaimInfo.DeliverBy, ClaimInfo.WCondition,ClaimInfo.cFlag, ClaimInfo.SvAmt, ClaimInfo.PrdAmt,ClaimInfo.OtherAmt,ClaimInfo.Dis, ClaimInfo.SRFlag, ClaimInfo.Remk, ClaimInfo.PhyCond, ClaimInfo.Log_User, ClaimInfo.Log_Date, ClaimInfo.MRNO, ClaimInfo.LastJobNO, ClaimInfo.cAdvance,ClaimInfo.cTransportCrg, ClaimInfo.ReturnedItems, ClaimInfo.ItemRemarks,"
        strQuery = strQuery & "ClaimInfo.FreeOfCost, ClaimInfo.AdvanceAmnt, ClaimInfo.VatAmnt, ClaimInfo.Email, ServiceDetails.Description "
        strQuery = strQuery & "From ClaimInfo LEFT Join ServiceDetails On ClaimInfo.JobCode = ServiceDetails.JobCode Where  1=1 AND " & SearchCriteria

        Dim con As OleDbConnection = New OleDbConnection(cs)

        Dim dcProductSearch As OleDbCommand = New OleDbCommand(strQuery, con)
        dcProductSearch.CommandType = CommandType.Text
        'dcProductSearch.Parameters.Add("parameter1", OleDbType.Char, 255).Value = SearchCriteria


        con.Open()
        Dim drProductSearch = dcProductSearch.ExecuteReader


        Dim dt As DataTable = New DataTable


        dt.Load(drProductSearch)



        Return dt


    End Function


    'Private Sub appconfig()
    '    Dim con As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
    '    If Not IsNothing(con.AppSettings) Then

    '    End If
    'End Sub



End Class
