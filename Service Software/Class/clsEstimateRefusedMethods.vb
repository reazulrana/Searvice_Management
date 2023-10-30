Imports System.Collections.Generic
Imports System.Configuration
Imports System.Data
Imports System.Data.OleDb

Public Class clsEstimateRefusedMethods


    Public Sub save(ByVal InsertModel As clsEstimateRefused)




        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcSaveEr As OleDbCommand = New OleDbCommand("qryInsertEstimateRefused", con)
            dcSaveEr.CommandType = CommandType.StoredProcedure
            With dcSaveEr.Parameters
                .Add("paramJobCode", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(InsertModel.JobCode), DBNull.Value, InsertModel.JobCode)
                .Add("paramServiceby", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(InsertModel.ServiceBy_ID), DBNull.Value, InsertModel.ServiceBy_ID)
                .Add("paramEstDate", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(InsertModel.EstDate), DBNull.Value, InsertModel.EstDate)
                .Add("paramEstText", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(InsertModel.EstText), DBNull.Value, InsertModel.EstText)
                .Add("paramRefuseAmnt", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(InsertModel.RefuseAmnt), DBNull.Value, InsertModel.RefuseAmnt)
                .Add("paramBranch", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(InsertModel.Branch), DBNull.Value, InsertModel.Branch)



            End With

            con.Open()
            dcSaveEr.ExecuteNonQuery()


        End Using



    End Sub



    Public Sub Update(ByVal InsertModel As clsEstimateRefused, ByVal UpdateCriteria As String)
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcSaveEr As OleDbCommand = New OleDbCommand("qryUpdateEstimateRefused", con)
            dcSaveEr.CommandType = CommandType.StoredProcedure
            With dcSaveEr.Parameters
                .Add("paramJobCode", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(InsertModel.JobCode), DBNull.Value, InsertModel.JobCode)
                .Add("paramServiceby", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(InsertModel.ServiceBy_ID), DBNull.Value, InsertModel.ServiceBy_ID)
                .Add("paramEstDate", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(InsertModel.EstDate), DBNull.Value, InsertModel.EstDate)
                .Add("paramEstText", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(InsertModel.EstText), DBNull.Value, InsertModel.EstText)
                .Add("paramRefuseAmnt", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(InsertModel.RefuseAmnt), DBNull.Value, InsertModel.RefuseAmnt)
                .Add("paramBranch", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(InsertModel.Branch), DBNull.Value, InsertModel.Branch)
                .Add("paramJobCode2", OleDbType.Char, 255).Value = UpdateCriteria
            End With

            con.Open()
            dcSaveEr.ExecuteNonQuery()


        End Using
    End Sub



    Public Sub Delete(ByVal DeleteCriteria As String)
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcSaveEr As OleDbCommand = New OleDbCommand("qryDeleteEstimateRefused", con)
            dcSaveEr.CommandType = CommandType.StoredProcedure
            With dcSaveEr.Parameters
                .Add("paramJobCode1", OleDbType.Char, 255).Value = DeleteCriteria
            End With

            con.Open()
            dcSaveEr.ExecuteNonQuery()


        End Using
    End Sub


    Public Function GetEstimateRefuse(ByVal SearchCriteria As String) As clsEstimateRefused
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim EstimateRefuse As clsEstimateRefused = New clsEstimateRefused

        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcSaveEr As OleDbCommand = New OleDbCommand("qryGet_EstimateRefused_byJobCode", con)
            dcSaveEr.CommandType = CommandType.StoredProcedure
            With dcSaveEr.Parameters
                .Add("paramJobCode1", OleDbType.Char, 255).Value = SearchCriteria
            End With

            con.Open()

            Dim drSaveEr = dcSaveEr.ExecuteReader
            While drSaveEr.Read
                With EstimateRefuse
                    .EstRAID = Convert.ToInt32(drSaveEr("EstRAID").ToString)
                    .JobCode = drSaveEr("JobCode").ToString
                    .ServiceBy_ID = drSaveEr("ServiceBy_ID").ToString
                    If Not String.IsNullOrEmpty(drSaveEr("EstDate").ToString) Then
                        .EstDate = Convert.ToDateTime(drSaveEr("EstDate").ToString)
                    End If

                    .EstText = drSaveEr("EstText").ToString
                    If Not String.IsNullOrEmpty(drSaveEr("RefuseAmnt").ToString) Then
                        .RefuseAmnt = Convert.ToDouble(drSaveEr("RefuseAmnt").ToString)
                    End If
                    .Branch = drSaveEr("Branch").ToString



                End With
            End While

        End Using

        Return EstimateRefuse
    End Function



    Public Function IsExist(ByVal SearchCriteria As String) As Boolean
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim blnFlag As Boolean = False

        Try


            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dcSaveEr As OleDbCommand = New OleDbCommand("qryGet_EstimateRefused_byJobCode", con)
                dcSaveEr.CommandType = CommandType.StoredProcedure
                With dcSaveEr.Parameters
                    .Add("paramJobCode1", OleDbType.Char, 255).Value = SearchCriteria
                End With

                con.Open()

                Dim drSaveEr = dcSaveEr.ExecuteReader
                If drSaveEr.HasRows = True Then
                    blnFlag = True
                End If

            End Using
        Catch ex As Exception
            blnFlag = False

        End Try
        Return blnFlag
    End Function

End Class
