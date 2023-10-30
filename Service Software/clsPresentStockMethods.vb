Imports System.Configuration
Imports System.Data
Imports System.Data.OleDb


Public  Class  clsPresentStockMethods

    Public Sub InsertPresentStock(ByVal intStatus As Integer)
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Dim ListofBranches As List(Of clsBranch) = New List(Of clsBranch)

        Dim strSqlQuery As String = String.Empty


        If intStatus = -1 Then

            strSqlQuery = "insert into tblPresentStock(JobCode,Branch,CustomerName,Category,Brand,Model,ReceptDate,Sdate,
                       ProductStatus,Warranty,Remarks) 
                       Select Claiminfo.JobCode,Claiminfo.Branch,Claiminfo.CustName,Claiminfo.ServiceType,Claiminfo.Brand,Claiminfo.ModelNo,
                       Claiminfo.ReceptDate,Claiminfo.Sdate,iif(claiminfo.cflag=1,'R',iif(claiminfo.cflag=-1,'WS',iif(claiminfo.cflag=99,'NR',iif(claiminfo.cflag=9,'P','')))) as ProductStatus,iif(Claiminfo.Wcondition=0,'SW',iif(Claiminfo.Wcondition=1,'NW',iif(Claiminfo.Wcondition=2,SVW))),EstimateRefused.EstText from Claiminfo left join EstimateRefused on claiminfo.JobCode=EstimateRefused.JobCode"
        ElseIf intStatus = 1 Then
        ElseIf intStatus = 9 Then
        ElseIf intStatus = 99 Then
        ElseIf intStatus = 101 Then


        End If

        Using con As OleDbConnection = New OleDbConnection(cs)

        End Using

    End Sub

End Class
