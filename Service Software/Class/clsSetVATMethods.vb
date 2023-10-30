Imports System
Imports System.Data
Imports System.Configuration
Imports System.Data.OleDb


Public Class clsSetVATMethods




    Public ReadOnly Property GetVats As IEnumerable(Of clsSetVAT)
        Get
            Dim ListVat As List(Of clsSetVAT) = New List(Of clsSetVAT)

            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dc As OleDbCommand = New OleDbCommand("qryGETALLSETVAT", con)
                dc.CommandType = CommandType.StoredProcedure
                con.Open()
                Dim dr As OleDbDataReader = dc.ExecuteReader
                If dr.HasRows = True Then
                    While dr.Read
                        Dim VAT As clsSetVAT = New clsSetVAT

                        VAT.VATID = Convert.ToInt32(dr("VATID").ToString)
                        VAT.ServiceCharge = Convert.ToInt32(dr("ServiceCharge").ToString)
                        VAT.Parts = Convert.ToInt32(dr("Parts").ToString)

                        VAT.IsActive = Convert.ToBoolean(dr("IsActive"))
                        ListVat.Add(VAT)
                    End While

                End If
            End Using
            Return ListVat
        End Get

    End Property



    Public Sub Save(ByVal Vat As clsSetVAT)
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dc As OleDbCommand = New OleDbCommand("qryInsertSETVAT", con)
            dc.CommandType = CommandType.StoredProcedure
            dc.Parameters.Add("@ServiceCharge", OleDbType.Single).Value = IIf(String.IsNullOrEmpty(Vat.ServiceCharge), DBNull.Value, Vat.ServiceCharge)
            dc.Parameters.Add("@Parts", OleDbType.Single).Value = IIf(String.IsNullOrEmpty(Vat.Parts), DBNull.Value, Vat.Parts)
            dc.Parameters.Add("@IsActive", OleDbType.Boolean).Value = IIf(String.IsNullOrEmpty(Vat.IsActive), DBNull.Value, Vat.IsActive)
            con.Open()
            dc.ExecuteNonQuery()

        End Using


    End Sub

    Public Sub Delete(ByVal ServiceCharge As Single, ByVal Parts As Single)
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dc As OleDbCommand = New OleDbCommand("qryDeleteSETVAT", con)
            dc.CommandType = CommandType.StoredProcedure
            dc.Parameters.Add("@ServiceCharge", OleDbType.Single).Value = ServiceCharge 'IIf(String.IsNullOrEmpty(ServiceCharge), DBNull.Value, ServiceCharge)
            dc.Parameters.Add("@Parts", OleDbType.Single).Value = Parts ' IIf(String.IsNullOrEmpty(Parts), DBNull.Value, Parts)

            con.Open()
            dc.ExecuteNonQuery()

        End Using


    End Sub


    Public Sub ResetDefault()
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dc As OleDbCommand = New OleDbCommand("qryResetIsActiveSETVAT", con)
            dc.CommandType = CommandType.StoredProcedure
            con.Open()
            dc.ExecuteNonQuery()

        End Using


    End Sub


    Public Sub MakeDefault(ByVal Vat As clsSetVAT)
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dc As OleDbCommand = New OleDbCommand("qryUpdate_MakeDefault_SETVAT", con)
            dc.CommandType = CommandType.StoredProcedure

            dc.Parameters.Add("@IsActive", OleDbType.Integer).Value = IIf(String.IsNullOrEmpty(Vat.IsActive), vbNull, Vat.IsActive)
            dc.Parameters.Add("@VAT", OleDbType.Integer).Value = IIf(String.IsNullOrEmpty(Vat.ServiceCharge), vbNull, Vat.ServiceCharge)
            dc.Parameters.Add("@Parts", OleDbType.Integer).Value = IIf(String.IsNullOrEmpty(Vat.Parts), vbNull, Vat.Parts)
            con.Open()
            dc.ExecuteNonQuery()

        End Using


    End Sub

End Class
