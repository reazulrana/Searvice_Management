Imports System.Data.OleDb
Imports System.Data
Imports System
Imports System.Configuration




Public Class clsCashsalesMethods


    Public Sub Save(ByVal cashsale As clsCashsales)

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString


        Using con As OleDbConnection = New OleDbConnection(cs)

            Dim dcSaveCashsale As OleDbCommand = New OleDbCommand("qryInsertCashsakes", con)
            dcSaveCashsale.CommandType = CommandType.StoredProcedure

            dcSaveCashsale.Parameters.Add("MRNO1", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(cashsale.MRNO), DBNull.Value, cashsale.MRNO)
            dcSaveCashsale.Parameters.Add("JobCode1", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(cashsale.JobCode), DBNull.Value, cashsale.JobCode)
            dcSaveCashsale.Parameters.Add("Branch1", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(cashsale.Branch), DBNull.Value, cashsale.Branch)
            dcSaveCashsale.Parameters.Add("CustName1", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(cashsale.CustName), DBNull.Value, cashsale.CustName)
            dcSaveCashsale.Parameters.Add("CustAddress11", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(cashsale.CustAddress1), DBNull.Value, cashsale.CustAddress1)
            dcSaveCashsale.Parameters.Add("CustAddress21", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(cashsale.CustAddress2), DBNull.Value, cashsale.CustAddress2)
            dcSaveCashsale.Parameters.Add("Brand1", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(cashsale.Brand), DBNull.Value, cashsale.Brand)
            dcSaveCashsale.Parameters.Add("ModelNo1", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(cashsale.ModelNo), DBNull.Value, cashsale.ModelNo)
            dcSaveCashsale.Parameters.Add("ESN1", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(cashsale.ESN), DBNull.Value, cashsale.ESN)
            dcSaveCashsale.Parameters.Add("SLNo1", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(cashsale.SLNo), DBNull.Value, cashsale.SLNo)
            dcSaveCashsale.Parameters.Add("ReceptDate1", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(cashsale.ReceptDate), DBNull.Value, cashsale.ReceptDate)
            dcSaveCashsale.Parameters.Add("ReceptBy1", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(cashsale.ReceptBy), DBNull.Value, cashsale.ReceptBy)
            dcSaveCashsale.Parameters.Add("Code1", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(cashsale.Code), DBNull.Value, cashsale.Code)
            dcSaveCashsale.Parameters.Add("ProdName1", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(cashsale.ProdName), DBNull.Value, cashsale.ProdName)
            dcSaveCashsale.Parameters.Add("Rate1", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(cashsale.Rate), DBNull.Value, cashsale.Rate)
            dcSaveCashsale.Parameters.Add("Qty1", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(cashsale.Qty), DBNull.Value, cashsale.Qty)
            dcSaveCashsale.Parameters.Add("Amount1", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(cashsale.Amount), DBNull.Value, cashsale.Amount)
            dcSaveCashsale.Parameters.Add("PrdAmt1", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(cashsale.PrdAmt), DBNull.Value, cashsale.PrdAmt)
            dcSaveCashsale.Parameters.Add("Dis1", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(cashsale.Dis), DBNull.Value, cashsale.Dis)
            dcSaveCashsale.Parameters.Add("NetAmnt1", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(cashsale.NetAmnt), DBNull.Value, cashsale.NetAmnt)
            dcSaveCashsale.Parameters.Add("Log_User1", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(cashsale.Log_User), DBNull.Value, cashsale.Log_User)
            dcSaveCashsale.Parameters.Add("Log_Date1", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(cashsale.Log_Date), DBNull.Value, cashsale.Log_Date)
            dcSaveCashsale.Parameters.Add("DFlag1", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(cashsale.DFlag), DBNull.Value, cashsale.DFlag)
            dcSaveCashsale.Parameters.Add("Category1", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(cashsale.Category), DBNull.Value, cashsale.Category)
            con.Open()

            dcSaveCashsale.ExecuteNonQuery()






        End Using







    End Sub






    Public Sub Update(ByVal cashsale As clsCashsales, ByVal UpdateID As String, ByVal UpdateCode As String)

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString


        Using con As OleDbConnection = New OleDbConnection(cs)

            Dim dcSaveCashsale As OleDbCommand = New OleDbCommand("qryUpdateCashsales", con)
            dcSaveCashsale.CommandType = CommandType.StoredProcedure

            dcSaveCashsale.Parameters.Add("MRNO1", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(cashsale.MRNO), DBNull.Value, cashsale.MRNO)
            dcSaveCashsale.Parameters.Add("JobCode1", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(cashsale.JobCode), DBNull.Value, cashsale.JobCode)
            dcSaveCashsale.Parameters.Add("Branch1", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(cashsale.Branch), DBNull.Value, cashsale.Branch)
            dcSaveCashsale.Parameters.Add("CustName1", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(cashsale.CustName), DBNull.Value, cashsale.CustName)
            dcSaveCashsale.Parameters.Add("CustAddress11", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(cashsale.CustAddress1), DBNull.Value, cashsale.CustAddress1)
            dcSaveCashsale.Parameters.Add("CustAddress21", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(cashsale.CustAddress2), DBNull.Value, cashsale.CustAddress2)
            dcSaveCashsale.Parameters.Add("Brand1", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(cashsale.Brand), DBNull.Value, cashsale.Brand)
            dcSaveCashsale.Parameters.Add("ModelNo1", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(cashsale.ModelNo), DBNull.Value, cashsale.ModelNo)
            dcSaveCashsale.Parameters.Add("ESN1", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(cashsale.ESN), DBNull.Value, cashsale.ESN)
            dcSaveCashsale.Parameters.Add("SLNo1", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(cashsale.SLNo), DBNull.Value, cashsale.SLNo)
            dcSaveCashsale.Parameters.Add("ReceptDate1", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(cashsale.ReceptDate), DBNull.Value, cashsale.ReceptDate)
            dcSaveCashsale.Parameters.Add("ReceptBy1", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(cashsale.ReceptBy), DBNull.Value, cashsale.ReceptBy)
            dcSaveCashsale.Parameters.Add("Code1", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(cashsale.Code), DBNull.Value, cashsale.Code)
            dcSaveCashsale.Parameters.Add("ProdName1", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(cashsale.ProdName), DBNull.Value, cashsale.ProdName)
            dcSaveCashsale.Parameters.Add("Rate1", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(cashsale.Rate), DBNull.Value, cashsale.Rate)
            dcSaveCashsale.Parameters.Add("Qty1", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(cashsale.Qty), DBNull.Value, cashsale.Qty)
            dcSaveCashsale.Parameters.Add("Amount1", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(cashsale.Amount), DBNull.Value, cashsale.Amount)
            dcSaveCashsale.Parameters.Add("PrdAmt1", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(cashsale.PrdAmt), DBNull.Value, cashsale.PrdAmt)
            dcSaveCashsale.Parameters.Add("Dis1", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(cashsale.Dis), DBNull.Value, cashsale.Dis)
            dcSaveCashsale.Parameters.Add("NetAmnt1", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(cashsale.NetAmnt), DBNull.Value, cashsale.NetAmnt)
            dcSaveCashsale.Parameters.Add("Log_User1", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(cashsale.Log_User), DBNull.Value, cashsale.Log_User)
            dcSaveCashsale.Parameters.Add("Log_Date1", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(cashsale.Log_Date), DBNull.Value, cashsale.Log_Date)
            dcSaveCashsale.Parameters.Add("DFlag1", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(cashsale.DFlag), DBNull.Value, cashsale.DFlag)
            dcSaveCashsale.Parameters.Add("MRNO2", OleDbType.Char, 255).Value = UpdateID
            dcSaveCashsale.Parameters.Add("Code1", OleDbType.Char, 255).Value = UpdateCode

            con.Open()



            dcSaveCashsale.ExecuteNonQuery()






        End Using







    End Sub






    Public Function GetCashsales(ByVal searchcirteria As String) As DataTable


        Dim dt As DataTable = New DataTable




        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Dim strQuery = "Select * from Cashsales where 1=1 and " & searchcirteria


        Using con As OleDbConnection = New OleDbConnection(cs)

            Dim dcCashsales As OleDbCommand = New OleDbCommand(strQuery, con)
            dcCashsales.CommandType = CommandType.Text

            'dcCashsales.Parameters.Add("@WhereClause", OleDbType.Char, 255).Value = searchcirteria


            con.Open()

            Dim drcashsales As OleDbDataReader = dcCashsales.ExecuteReader

            If drcashsales.HasRows Then
                dt.Load(drcashsales)
            End If





        End Using


        Return dt



    End Function




    Public Function IsExist(ByVal searchcirteria As String) As Boolean
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim strQuery = "Select * from Cashsales where 1=1 and Cashsales.MRNO=@MRNO"

        Dim blnFlag As Boolean = False
        Try


            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dcCashsales As OleDbCommand = New OleDbCommand(strQuery, con)
                dcCashsales.CommandType = CommandType.Text
                dcCashsales.Parameters.Add("@MRNO", OleDbType.Char, 255).Value = searchcirteria
                con.Open()
                Dim drcashsales As OleDbDataReader = dcCashsales.ExecuteReader
                If drcashsales.HasRows = True Then
                    blnFlag = True
                End If
            End Using

        Catch ex As Exception
            blnFlag = False
        End Try

        Return blnFlag
    End Function


    Public Function IsExist(ByVal CheckID As String, ByVal checkCode As String) As Boolean
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim strQuery = "Select * from Cashsales where 1=1 and Cashsales.MRNO=@MRNO and Code=@Code"
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcCashsales As OleDbCommand = New OleDbCommand(strQuery, con)
            dcCashsales.CommandType = CommandType.Text
            dcCashsales.Parameters.Add("@MRNO", OleDbType.Char, 255).Value = CheckID
            dcCashsales.Parameters.Add("@Code", OleDbType.Char, 255).Value = checkCode
            con.Open()
            Dim drcashsales As OleDbDataReader = dcCashsales.ExecuteReader
            If drcashsales.HasRows = True Then
                Return True
            End If
        End Using
        Return False
    End Function



    Public Sub DeleteMR(ByVal CheckID As String)
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim strQuery = "Delete * from Cashsales where 1=1 and Cashsales.MRNO=@MRNO"
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcCashsales As OleDbCommand = New OleDbCommand(strQuery, con)
            dcCashsales.CommandType = CommandType.Text
            dcCashsales.Parameters.Add("@MRNO", OleDbType.Char, 255).Value = CheckID

            con.Open()
            dcCashsales.ExecuteNonQuery()
        End Using

    End Sub

    Public Sub DeleteMR(ByVal DeleteID As String, ByVal DeleteCode As String)
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim strQuery = "Delete * from Cashsales where 1=1 and Cashsales.MRNO=@MRNO and Code=@Code"
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcCashsales As OleDbCommand = New OleDbCommand(strQuery, con)
            dcCashsales.CommandType = CommandType.Text
            dcCashsales.Parameters.Add("@MRNO", OleDbType.Char, 255).Value = DeleteID
            dcCashsales.Parameters.Add("@Code", OleDbType.Char, 255).Value = DeleteCode
            con.Open()
            dcCashsales.ExecuteNonQuery()
        End Using

    End Sub


    Public Function GetCashsales(ByVal DateFrom As String, ByVal DateTo As String, Optional Additional As String = "") As DataTable

        Dim dt As DataTable = New DataTable

        Dim strQuery As String = String.Empty

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        If Additional.Length <= 0 Then
            strQuery = "Select cashsales.MRNO,cashsales.JobCode, cashsales.Branch,cashsales.CustName,cashsales.Brand,cashsales.ModelNo,cashsales.ReceptDate,cashsales.Receptby,cashsales.Code,cashsales.ProdName,cashsales.Rate,cashsales.Qty,cashsales.Dis,cashsales.Category from Cashsales where ReceptDate Between @ParamStartDate And @ParamEndDate order by ReceptDate, MrNo"
        Else
            strQuery = "Select cashsales.MRNO,cashsales.JobCode, cashsales.Branch,cashsales.CustName,cashsales.Brand,cashsales.ModelNo,cashsales.ReceptDate,cashsales.Receptby,cashsales.Code,cashsales.ProdName,cashsales.Rate,cashsales.Qty,cashsales.Dis,cashsales.Category from Cashsales where ReceptDate Between @ParamStartDate And @ParamEndDate AND " & Additional & " order by ReceptDate, MrNo"
        End If

        Using con As OleDbConnection = New OleDbConnection(cs)

            Dim dcCashsales As OleDbCommand = New OleDbCommand(strQuery, con)
            dcCashsales.CommandType = CommandType.Text

            dcCashsales.Parameters.Add("@ParamStartDate", OleDbType.Date).Value = DateFrom
            dcCashsales.Parameters.Add("@ParamEndDate", OleDbType.Date).Value = DateTo
            'dcCashsales.Parameters.Add("@Additional", OleDbType.Char, 255).Value = Additional


            con.Open()

            Dim drcashsales As OleDbDataReader = dcCashsales.ExecuteReader

            If drcashsales.HasRows = True Then
                dt.Load(drcashsales)
            End If
        End Using
        Return dt
    End Function



    Public Function GetCashsalesSummeryReport(ByVal DateFrom As String, ByVal DateTo As String, Optional Additional As String = "") As DataTable

        Dim dt As DataTable = New DataTable

        Dim strQuery As String = String.Empty

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        If String.IsNullOrEmpty(Additional.Trim) Then
            strQuery = "Select cashsales.MRNO, cashsales.ReceptDate, cashsales.Branch,cashsales.CustName,sum(cashsales.Rate) as Rate,sum(cashsales.Qty) as Qty,cashsales.Dis from Cashsales where ReceptDate Between @ParamStartDate And @ParamEndDate group by cashsales.MRNO,cashsales.ReceptDate, cashsales.Branch,cashsales.CustName,cashsales.Dis order by ReceptDate, MrNo"
        Else
            strQuery = "Select cashsales.MRNO,cashsales.ReceptDate, cashsales.Branch,cashsales.CustName,sum(cashsales.Rate) as Rate,sum(cashsales.Qty) as Qty,cashsales.Dis from Cashsales where ReceptDate Between @ParamStartDate And @ParamEndDate AND " & Additional & " group by cashsales.MRNO,cashsales.ReceptDate, cashsales.Branch,cashsales.CustName,cashsales.Dis order by ReceptDate, MrNo"
        End If

        Using con As OleDbConnection = New OleDbConnection(cs)

            Dim dcCashsales As OleDbCommand = New OleDbCommand(strQuery, con)
            dcCashsales.CommandType = CommandType.Text

            dcCashsales.Parameters.Add("@ParamStartDate", OleDbType.Date).Value = DateFrom
            dcCashsales.Parameters.Add("@ParamEndDate", OleDbType.Date).Value = DateTo
            'dcCashsales.Parameters.Add("@Additional", OleDbType.Char, 255).Value = Additional


            con.Open()

            Dim drcashsales As OleDbDataReader = dcCashsales.ExecuteReader

            If drcashsales.HasRows = True Then
                dt.Load(drcashsales)
            End If
        End Using
        Return dt
    End Function




    Public Function GetCashsalesTotalAmount() As List(Of clsCashsales)

        Dim ListofCashsale As List(Of clsCashsales) = New List(Of clsCashsales)


        Dim strQuery As String = String.Empty

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString


        strQuery = "Select cashsales.MRNO,cashsales.ReceptDate,cashsales.Branch, (sum(cashsales.Rate*cashsales.Qty)-cashsales.Dis) as Amount from Cashsales group by cashsales.MRNO,cashsales.Dis,cashsales.ReceptDate,cashsales.Branch order by MrNo"

        Using con As OleDbConnection = New OleDbConnection(cs)

            Dim dcCashsales As OleDbCommand = New OleDbCommand(strQuery, con)
            dcCashsales.CommandType = CommandType.Text
            con.Open()
            Dim drcashsales As OleDbDataReader = dcCashsales.ExecuteReader
            If drcashsales.HasRows = True Then
                While drcashsales.Read
                    Dim cashsales As clsCashsales = New clsCashsales
                    'cashsales.MRNO, cashsales.ReceptDate, cashsales.Branch,cashsales.CustName,sum(cashsales.Rate) as Rate,sum(cashsales.Qty) as Qty,cashsales.Dis
                    cashsales.MRNO = drcashsales("MRNO").ToString
                    cashsales.Branch = drcashsales("Branch").ToString
                    cashsales.ReceptDate = DateTime.Parse(drcashsales("ReceptDate").ToString)
                    cashsales.NetAmnt = Double.Parse(drcashsales("Amount").ToString)

                    ListofCashsale.Add(cashsales)
                End While
            End If
        End Using
        Return ListofCashsale
    End Function

    Public Function GetCashsalesNetTotalAmount(ByVal strParameter As String) As Double

        Dim dbtAmount As Double


        Dim strQuery As String = String.Empty
        Dim strJobCode As String = String.Empty

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Try

            strQuery = "Select Sum(Cash.TotalAmount) as Total from (Select Cashsales.MrNo ,(Cashsales.PrdAmt-Cashsales.Dis) as TotalAmount from Cashsales where " & strParameter & " group by Cashsales.MrNo,(Cashsales.PrdAmt-Cashsales.Dis)) as Cash"



            '  strQuery = "select count(Cashsales.NetAmnt)  from Cashsales"
            Dim dblObject As Object = New Object
            Dim dblAmount As Double = 0
            Using con As OleDbConnection = New OleDbConnection(cs)

                Dim dcCashsales As OleDbCommand = New OleDbCommand(strQuery, con)
                dcCashsales.CommandType = CommandType.Text
                con.Open()
                If Not IsDBNull(dcCashsales.ExecuteScalar()) Then

                    dbtAmount = Double.Parse(dcCashsales.ExecuteScalar())

                End If



            End Using
            Return dbtAmount

        Catch ex As Exception
            MessageBox.Show(ex.Message)

            Return 0
        End Try
    End Function


    Public ReadOnly Property CasheBill(ByVal MRNO As String) As DataTable
        Get

            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
            Dim dt As DataTable = New DataTable
            Dim strSql = "Select Cashsales.MRNO, Cashsales.JobCode,cashsales.Code,Cashsales.Prodname,cashsales.Rate,Cashsales.Qty,Cashsales.Dis,Cashsales.Branch,Cashsales.CustName,Cashsales.CustAddress1,Cashsales.CustAddress2 from Cashsales where cashsales.MrNO=@MrNO"
            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dc As OleDbCommand = New OleDbCommand(strSql, con)
                dc.CommandType = CommandType.Text
                dc.Parameters.Add("@MRNO", OleDbType.Char, 255).Value = MRNO
                con.Open()

                Dim dr As OleDbDataReader = dc.ExecuteReader

                If dr.HasRows = True Then
                    dt.Load(dr)

                End If


            End Using


            Return dt

        End Get
    End Property

End Class
