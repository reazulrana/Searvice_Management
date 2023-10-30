Imports System.Data
Imports System.Data.OleDb
Imports System.Configuration
Imports System.Collections.Generic


Public Class clsClaimlistMethods

    Public ReadOnly Property GetAllClaimList() As IEnumerable(Of clsClaimlist)
        Get
            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
            Dim GetClaimlist As List(Of clsClaimlist) = New List(Of clsClaimlist)


            Using con As OleDbConnection = New OleDbConnection(cs)

                Dim dcgetclaimlist As OleDbCommand = New OleDbCommand("qryGet_All_Claimlist", con)
                dcgetclaimlist.CommandType = CommandType.StoredProcedure


                con.Open()

                Dim drgetclaimlist As OleDbDataReader = dcgetclaimlist.ExecuteReader

                While drgetclaimlist.Read
                    Dim tmpclaimlist As clsClaimlist = New clsClaimlist

                    tmpclaimlist.ClaimCode = Convert.ToInt32(drgetclaimlist("ClaimCode").ToString)
                    tmpclaimlist.CategoryName = drgetclaimlist("cType").ToString
                    tmpclaimlist.Claim = drgetclaimlist("Claim").ToString

                    GetClaimlist.Add(tmpclaimlist)

                End While





            End Using


            Return GetClaimlist

        End Get
    End Property







    Public ReadOnly Property GetAllClaimList(ByVal strCategory As String) As IEnumerable(Of clsClaimlist)
        Get
            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
            Dim GetClaimlist As List(Of clsClaimlist) = New List(Of clsClaimlist)


            Using con As OleDbConnection = New OleDbConnection(cs)

                Dim dcgetclaimlist As OleDbCommand = New OleDbCommand("qryGet_Claimlist_byCategory", con)
                dcgetclaimlist.CommandType = CommandType.StoredProcedure

                dcgetclaimlist.Parameters.Add("paractpe", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(strCategory), DBNull.Value, strCategory)

                con.Open()


                Dim drgetclaimlist As OleDbDataReader = dcgetclaimlist.ExecuteReader

                While drgetclaimlist.Read
                    Dim tmpclaimlist As clsClaimlist = New clsClaimlist

                    tmpclaimlist.ClaimCode = Convert.ToInt32(drgetclaimlist("ClaimCode").ToString)
                    tmpclaimlist.CategoryName = drgetclaimlist("cType").ToString
                    tmpclaimlist.Claim = drgetclaimlist("Claim").ToString

                    GetClaimlist.Add(tmpclaimlist)

                End While





            End Using


            Return GetClaimlist

        End Get
    End Property



    Public Sub Insert(ByVal InsertClaim As clsClaimlist)
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dc As OleDbCommand = New OleDbCommand("qryInsertClaimList", con)
            dc.CommandType = CommandType.StoredProcedure
            dc.Parameters.Add("@ClaimCode", OleDbType.Integer).Value = IIf(String.IsNullOrEmpty(InsertClaim.ClaimCode), DBNull.Value, InsertClaim.ClaimCode)
            dc.Parameters.Add("@cType", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(InsertClaim.CategoryName), DBNull.Value, InsertClaim.CategoryName)
            dc.Parameters.Add("@Claim", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(InsertClaim.Claim), DBNull.Value, InsertClaim.Claim)
            con.Open()
            dc.ExecuteNonQuery()
        End Using
    End Sub

    Public Sub Update(ByVal PresentClaim As clsClaimlist, ByVal PreviousClaim As clsClaimlist)
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dc As OleDbCommand = New OleDbCommand("qryUpdateClaimList", con)
            dc.CommandType = CommandType.StoredProcedure
            dc.Parameters.Add("ClaimCode1", OleDbType.Integer).Value = IIf(String.IsNullOrEmpty(PresentClaim.ClaimCode), DBNull.Value, PresentClaim.ClaimCode)
            dc.Parameters.Add("cType1", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(PresentClaim.CategoryName), DBNull.Value, PresentClaim.CategoryName)
            dc.Parameters.Add("Claim1", OleDbType.Char, 255).Value = IIf(String.IsNullOrEmpty(PresentClaim.Claim), DBNull.Value, PresentClaim.Claim)
            dc.Parameters.Add("cType2", OleDbType.Char, 255).Value = PreviousClaim.CategoryName
            dc.Parameters.Add("Claim2", OleDbType.Char, 255).Value = PreviousClaim.Claim
            con.Open()
            dc.ExecuteNonQuery()
        End Using
    End Sub




    Public Sub Delete(ByVal DeleteClaim As clsClaimlist)
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dc As OleDbCommand = New OleDbCommand("qryDeleteClaimList", con)
            dc.CommandType = CommandType.StoredProcedure
            dc.Parameters.Add("cType2", OleDbType.Char, 255).Value = DeleteClaim.CategoryName
            dc.Parameters.Add("Claim2", OleDbType.Char, 255).Value = DeleteClaim.Claim
            con.Open()
            dc.ExecuteNonQuery()
        End Using
    End Sub






End Class









