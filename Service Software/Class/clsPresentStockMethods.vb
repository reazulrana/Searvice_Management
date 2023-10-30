Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Configuration


Public Class clsPresentStockMethods

    Public Sub InsertPresentStock(ByVal strStatus As String, ByVal AdditionalClause As String)



        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Dim strQuery As String = String.Empty
        If strStatus = -1 Then
            If String.IsNullOrEmpty(AdditionalClause.Trim) Or AdditionalClause.ToLower.Trim = LCase("ALL") Then


                strQuery = "Insert into tblPresentStock(JobCode,Branch,CustomerName,Category,Brand,Model,SLNO,ReceptDate,Sdate,ProductStatus,Warranty,Remarks)
                        SELECT ClaimInfo.JobCode, ClaimInfo.Branch, ClaimInfo.CustName, ClaimInfo.ServiceType, ClaimInfo.Brand, ClaimInfo.ModelNo,Claiminfo.SLNO, ClaimInfo.ReceptDate, ClaimInfo.SDate, 'WS' as ProductStatus,
                        iif(ClaimInfo.WCondition=0,'SW',iif(ClaimInfo.WCondition=1,'NW',iif(ClaimInfo.WCondition=2,'SVW'))) as Warranty,
                        'Waiting for Service' as Remarks FROM ClaimInfo where claiminfo.Cflag=-1;"
            Else
                strQuery = "Insert into tblPresentStock(JobCode,Branch,CustomerName,Category,Brand,Model,SLNO,ReceptDate,Sdate,ProductStatus,Warranty,Remarks)
                        SELECT ClaimInfo.JobCode, ClaimInfo.Branch, ClaimInfo.CustName, ClaimInfo.ServiceType, ClaimInfo.Brand, ClaimInfo.ModelNo,Claiminfo.SLNO, ClaimInfo.ReceptDate, ClaimInfo.SDate, 'WS' as ProductStatus,
                        iif(ClaimInfo.WCondition=0,'SW',iif(ClaimInfo.WCondition=1,'NW',iif(ClaimInfo.WCondition=2,'SVW'))) as Warranty,
                        'Waiting for Service' as Remarks FROM ClaimInfo where claiminfo.Cflag=-1 AND " & AdditionalClause
            End If
        ElseIf strStatus = 1 Then
            If String.IsNullOrEmpty(AdditionalClause.Trim) Or AdditionalClause.ToLower.Trim = LCase("ALL") Then


                strQuery = "Insert into tblPresentStock(JobCode,Branch,CustomerName,Category,Brand,Model,SLNO,ReceptDate,Sdate,ProductStatus,Warranty,Remarks)
                        SELECT ClaimInfo.JobCode, ClaimInfo.Branch, ClaimInfo.CustName, ClaimInfo.ServiceType, ClaimInfo.Brand, ClaimInfo.ModelNo,Claiminfo.SLNO, ClaimInfo.ReceptDate, ClaimInfo.SDate, 'R' as ProductStatus,
                        iif(ClaimInfo.WCondition=0,'SW',iif(ClaimInfo.WCondition=1,'NW',iif(ClaimInfo.WCondition=2,'SVW'))) as Warranty,
                        EstimateRefused.EstText FROM ClaimInfo LEFT JOIN EstimateRefused ON ClaimInfo.JobCode = EstimateRefused.JobCode where claiminfo.Cflag=1;"
            Else
                strQuery = "Insert into tblPresentStock(JobCode,Branch,CustomerName,Category,Brand,Model,SLNO,ReceptDate,Sdate,ProductStatus,Warranty,Remarks)
                        SELECT ClaimInfo.JobCode, ClaimInfo.Branch, ClaimInfo.CustName, ClaimInfo.ServiceType, ClaimInfo.Brand, ClaimInfo.ModelNo,Claiminfo.SLNO, ClaimInfo.ReceptDate, ClaimInfo.SDate, 'R' as ProductStatus,
                        iif(ClaimInfo.WCondition=0,'SW',iif(ClaimInfo.WCondition=1,'NW',iif(ClaimInfo.WCondition=2,'SVW'))) as Warranty,
                        EstimateRefused.EstText FROM ClaimInfo LEFT JOIN EstimateRefused ON ClaimInfo.JobCode = EstimateRefused.JobCode where claiminfo.Cflag=1 AND " & AdditionalClause
            End If
        ElseIf strStatus = 9 Then
            If String.IsNullOrEmpty(AdditionalClause.Trim) Or AdditionalClause.ToLower.Trim = LCase("ALL") Then


                strQuery = "Insert into tblPresentStock(JobCode,Branch,CustomerName,Category,Brand,Model,SLNO,ReceptDate,Sdate,ProductStatus,Warranty,Remarks)
                        SELECT ClaimInfo.JobCode, ClaimInfo.Branch, ClaimInfo.CustName, ClaimInfo.ServiceType, ClaimInfo.Brand, ClaimInfo.ModelNo,Claiminfo.SLNO, ClaimInfo.ReceptDate, ClaimInfo.SDate, 'P' as ProductStatus,
                        iif(ClaimInfo.WCondition=0,'SW',iif(ClaimInfo.WCondition=1,'NW',iif(ClaimInfo.WCondition=2,'SVW'))) as Warranty,
                        Pending.Pencode FROM ClaimInfo LEFT JOIN Pending ON ClaimInfo.JobCode = Pending.JobCode where claiminfo.Cflag=9;"
            Else
                strQuery = "Insert into tblPresentStock(JobCode,Branch,CustomerName,Category,Brand,Model,SLNO,ReceptDate,Sdate,ProductStatus,Warranty,Remarks)
                        SELECT ClaimInfo.JobCode, ClaimInfo.Branch, ClaimInfo.CustName, ClaimInfo.ServiceType, ClaimInfo.Brand, ClaimInfo.ModelNo,Claiminfo.SLNO, ClaimInfo.ReceptDate, ClaimInfo.SDate, 'P' as ProductStatus,
                        iif(ClaimInfo.WCondition=0,'SW',iif(ClaimInfo.WCondition=1,'NW',iif(ClaimInfo.WCondition=2,'SVW'))) as Warranty,
                          Pending.Pencode FROM ClaimInfo LEFT JOIN Pending ON ClaimInfo.JobCode = Pending.JobCode where claiminfo.Cflag=9 AND " & AdditionalClause
            End If
        ElseIf strStatus = 99 Then

            If String.IsNullOrEmpty(AdditionalClause.Trim) Or AdditionalClause.ToLower.Trim = LCase("ALL") Then


                strQuery = "Insert into tblPresentStock(JobCode,Branch,CustomerName,Category,Brand,Model,SLNO,ReceptDate,Sdate,ProductStatus,Warranty,Remarks)
                        SELECT ClaimInfo.JobCode, ClaimInfo.Branch, ClaimInfo.CustName, ClaimInfo.ServiceType, ClaimInfo.Brand, ClaimInfo.ModelNo,Claiminfo.SLNO, ClaimInfo.ReceptDate, ClaimInfo.SDate, 'NR' as ProductStatus,
                        iif(ClaimInfo.WCondition=0,'SW',iif(ClaimInfo.WCondition=1,'NW',iif(ClaimInfo.WCondition=2,'SVW'))) as Warranty,
                        NRDetails.NRCODE FROM ClaimInfo LEFT JOIN NRDetails ON ClaimInfo.JobCode = NRDetails.JobCode where claiminfo.Cflag=99;"
            Else
                strQuery = "Insert into tblPresentStock(JobCode,Branch,CustomerName,Category,Brand,Model,SLNO,ReceptDate,Sdate,ProductStatus,Warranty,Remarks)
                        SELECT ClaimInfo.JobCode, ClaimInfo.Branch, ClaimInfo.CustName, ClaimInfo.ServiceType, ClaimInfo.Brand, ClaimInfo.ModelNo,Claiminfo.SLNO, ClaimInfo.ReceptDate, ClaimInfo.SDate, 'NR' as ProductStatus,
                        iif(ClaimInfo.WCondition=0,'SW',iif(ClaimInfo.WCondition=1,'NW',iif(ClaimInfo.WCondition=2,'SVW'))) as Warranty,
                          NRDetails.NRCODE  FROM ClaimInfo LEFT JOIN NRDetails ON ClaimInfo.JobCode = NRDetails.JobCode where claiminfo.Cflag=99 AND " & AdditionalClause
            End If

        End If


        Using con As OleDbConnection = New OleDbConnection(cs)

            Dim dcInsert As OleDbCommand = New OleDbCommand(strQuery, con)

            con.Open()
            dcInsert.ExecuteNonQuery()



        End Using




    End Sub


    Public ReadOnly Property GetAllPresentStock() As IEnumerable(Of clsPresentStock)
        Get


            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
            Dim ListPresentStock As List(Of clsPresentStock) = New List(Of clsPresentStock)


            Using con As OleDbConnection = New OleDbConnection(cs)

                Dim dcPresentStock As OleDbCommand = New OleDbCommand("Select * from tblPresentStock", con)

                con.Open()

                Dim drPresentStock As OleDbDataReader = dcPresentStock.ExecuteReader

                If drPresentStock.HasRows = True Then

                    While drPresentStock.Read
                        Dim PresentStock As clsPresentStock = New clsPresentStock

                        PresentStock.JobCode = drPresentStock("JobCode").ToString
                        PresentStock.Branch = drPresentStock("Branch").ToString
                        PresentStock.CustomerName = drPresentStock("CustomerName").ToString
                        PresentStock.Category = drPresentStock("Category").ToString
                        PresentStock.Brand = drPresentStock("Brand").ToString
                        PresentStock.Model = drPresentStock("Model").ToString
                        PresentStock.SLNO = drPresentStock("SLNO").ToString
                        PresentStock.ReceptDate = drPresentStock("ReceptDate").ToString
                        PresentStock.Sdate = drPresentStock("Sdate").ToString
                        PresentStock.ProductStatus = drPresentStock("ProductStatus").ToString
                        PresentStock.Warranty = drPresentStock("Warranty").ToString
                        PresentStock.Remarks = drPresentStock("Remarks").ToString
                        ListPresentStock.Add(PresentStock)
                    End While
                End If




            End Using




            Return ListPresentStock


        End Get
    End Property




    Public Sub DeleteAll()



        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
            Dim ListPresentStock As List(Of clsPresentStock) = New List(Of clsPresentStock)


            Using con As OleDbConnection = New OleDbConnection(cs)

            Dim dcPresentStock As OleDbCommand = New OleDbCommand("Delete * from tblPresentStock", con)

            con.Open()

            dcPresentStock.ExecuteNonQuery()




        End Using









    End Sub




End Class
