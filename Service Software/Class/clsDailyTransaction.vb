Imports System
Imports System.DateTime
Imports System.Data.OleDb
Imports System.Configuration



Public Class clsDailyTransaction



#Region "Previous Data Section"

#Region "Previous Data Branch Section"


    ' ___________________________________________________ Start of Previous Data Branch Section ______________________________________________


    Public Function PreviousReceiveBranch(ByVal strBranch As String, strCategory As String, ByVal strBrand As String, ByVal strModelNo As String, StartDate As DateTime, ByVal EndDate As DateTime, ByVal strWarranty As String) As Integer
        Dim dblTotalReceive As Integer = 0
        Dim cs As String = ConfigurationManager.ConnectionStrings("dbcService").ConnectionString
        Dim strSql As String = String.Empty
        strSql = "Select count(CLaiminfo.JobCode) as TTlQty from Claiminfo where  1=1 AND ReceptDate between #" & StartDate & "# and #" & EndDate & "# AND " & strWarranty
        Try

            If strBranch.Length > 0 Then
                strSql += " AND Branch=@Branch"
            End If

            If strCategory.Length > 0 Then
                strSql += " AND ServiceType=@ServiceType"
            End If

            If strBrand.Length > 0 Then
                strSql += " AND Brand=@Brand"
            End If

            If strModelNo.Length > 0 Then
                strSql += " AND ModelNo=@ModelNo"
            End If
            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dc As OleDbCommand = New OleDbCommand(strSql, con)
                If strBranch.Length > 0 Then
                    dc.Parameters.Add("@Branch", OleDbType.Char, 255).Value = strBranch
                End If

                If strCategory.Length > 0 Then
                    dc.Parameters.Add("@ServiceType", OleDbType.Char, 255).Value = strCategory
                End If

                If strBrand.Length > 0 Then
                    dc.Parameters.Add("@Brand", OleDbType.Char, 255).Value = strBrand
                End If

                If strModelNo.Length > 0 Then
                    dc.Parameters.Add("@ModelNo", OleDbType.Char, 255).Value = strModelNo
                End If
                con.Open()

                If Not IsDBNull(dc.ExecuteScalar()) Then
                    dblTotalReceive = Double.Parse(dc.ExecuteScalar())
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            dblTotalReceive = 0
        End Try
        Return dblTotalReceive

    End Function





    Public Function PreviousRepairedBranch(ByVal strBranch As String, strCategory As String, ByVal strBrand As String, ByVal strModelNo As String, StartDate As DateTime, ByVal EndDate As DateTime, ByVal strWarranty As String) As Integer
        Dim dblTotalReceive As Integer = 0
        Dim cs As String = ConfigurationManager.ConnectionStrings("dbcService").ConnectionString
        Dim strSql As String = String.Empty

        strSql = "Select count(CLaiminfo.JobCode) as TTlQty from Claiminfo where  1=1 AND Sdate between #" & StartDate & "# and #" & EndDate & "# AND not Claiminfo.CFlag in(9,99,100,101,102) AND " & strWarranty '"# AND CFlag=1 AND " & strWarranty
        Try

            If strBranch.Length > 0 Then
                strSql += " AND Branch=@Branch"
            End If

            If strCategory.Length > 0 Then
                strSql += " AND ServiceType=@ServiceType"
            End If

            If strBrand.Length > 0 Then
                strSql += " AND Brand=@Brand"
            End If

            If strModelNo.Length > 0 Then
                strSql += " AND ModelNo=@ModelNo"
            End If
            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dc As OleDbCommand = New OleDbCommand(strSql, con)
                If strBranch.Length > 0 Then
                    dc.Parameters.Add("@Branch", OleDbType.Char, 255).Value = strBranch
                End If

                If strCategory.Length > 0 Then
                    dc.Parameters.Add("@ServiceType", OleDbType.Char, 255).Value = strCategory
                End If

                If strBrand.Length > 0 Then
                    dc.Parameters.Add("@Brand", OleDbType.Char, 255).Value = strBrand
                End If

                If strModelNo.Length > 0 Then
                    dc.Parameters.Add("@ModelNo", OleDbType.Char, 255).Value = strModelNo
                End If
                con.Open()


                If Not IsDBNull(dc.ExecuteScalar()) Then
                    dblTotalReceive = Double.Parse(dc.ExecuteScalar())
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            dblTotalReceive = 0
        End Try
        Return dblTotalReceive

    End Function



    Public Function PreviousDeliveredBranch(ByVal strBranch As String, strCategory As String, ByVal strBrand As String, ByVal strModelNo As String, StartDate As DateTime, ByVal EndDate As DateTime, ByVal strWarranty As String) As Integer
        Dim dblTotalReceive As Integer = 0
        Dim cs As String = ConfigurationManager.ConnectionStrings("dbcService").ConnectionString
        Dim strSql As String = String.Empty

        strSql = "Select count(CLaiminfo.JobCode) as TTlQty from Claiminfo where  1=1 AND Ddate between #" & StartDate & "# and #" & EndDate & "# AND CFlag in(0,2) AND " & strWarranty
        Try

            If strBranch.Length > 0 Then
                strSql += " AND Branch=@Branch"
            End If

            If strCategory.Length > 0 Then
                strSql += " AND ServiceType=@ServiceType"
            End If

            If strBrand.Length > 0 Then
                strSql += " AND Brand=@Brand"
            End If

            If strModelNo.Length > 0 Then
                strSql += " AND ModelNo=@ModelNo"
            End If
            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dc As OleDbCommand = New OleDbCommand(strSql, con)
                If strBranch.Length > 0 Then
                    dc.Parameters.Add("@Branch", OleDbType.Char, 255).Value = strBranch
                End If

                If strCategory.Length > 0 Then
                    dc.Parameters.Add("@ServiceType", OleDbType.Char, 255).Value = strCategory
                End If

                If strBrand.Length > 0 Then
                    dc.Parameters.Add("@Brand", OleDbType.Char, 255).Value = strBrand
                End If

                If strModelNo.Length > 0 Then
                    dc.Parameters.Add("@ModelNo", OleDbType.Char, 255).Value = strModelNo
                End If
                con.Open()


                If Not IsDBNull(dc.ExecuteScalar()) Then
                    dblTotalReceive = Double.Parse(dc.ExecuteScalar())
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            dblTotalReceive = 0
        End Try
        Return dblTotalReceive

    End Function



    Public Function PreviousNRBranch(ByVal strBranch As String, strCategory As String, ByVal strBrand As String, ByVal strModelNo As String, StartDate As DateTime, ByVal EndDate As DateTime, ByVal strWarranty As String) As Integer
        Dim dblTotalReceive As Integer = 0
        Dim cs As String = ConfigurationManager.ConnectionStrings("dbcService").ConnectionString
        Dim strSql As String = String.Empty

        strSql = "Select count(CLaiminfo.JobCode) as TTlQty from Claiminfo where  1=1 AND sdate between #" & StartDate & "# and #" & EndDate & "# AND CFlag in(99) AND " & strWarranty
        Try

            If strBranch.Length > 0 Then
                strSql += " AND Branch=@Branch"
            End If

            If strCategory.Length > 0 Then
                strSql += " AND ServiceType=@ServiceType"
            End If

            If strBrand.Length > 0 Then
                strSql += " AND Brand=@Brand"
            End If

            If strModelNo.Length > 0 Then
                strSql += " AND ModelNo=@ModelNo"
            End If
            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dc As OleDbCommand = New OleDbCommand(strSql, con)
                If strBranch.Length > 0 Then
                    dc.Parameters.Add("@Branch", OleDbType.Char, 255).Value = strBranch
                End If

                If strCategory.Length > 0 Then
                    dc.Parameters.Add("@ServiceType", OleDbType.Char, 255).Value = strCategory
                End If

                If strBrand.Length > 0 Then
                    dc.Parameters.Add("@Brand", OleDbType.Char, 255).Value = strBrand
                End If

                If strModelNo.Length > 0 Then
                    dc.Parameters.Add("@ModelNo", OleDbType.Char, 255).Value = strModelNo
                End If
                con.Open()

                If Not IsDBNull(dc.ExecuteScalar()) Then
                    dblTotalReceive = Double.Parse(dc.ExecuteScalar())
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            dblTotalReceive = 0
        End Try
        Return dblTotalReceive

    End Function



    Public Function PreviousCRBranch(ByVal strBranch As String, strCategory As String, ByVal strBrand As String, ByVal strModelNo As String, StartDate As DateTime, ByVal EndDate As DateTime, ByVal strWarranty As String) As Integer
        Dim dblTotalReceive As Integer = 0
        Dim cs As String = ConfigurationManager.ConnectionStrings("dbcService").ConnectionString
        Dim strSql As String = String.Empty

        strSql = "Select count(CLaiminfo.JobCode) as TTlQty from Claiminfo where  1=1 AND Ddate between #" & StartDate & "# and #" & EndDate & "# AND CFlag in(100) AND " & strWarranty
        Try

            If strBranch.Length > 0 Then
                strSql += " AND Branch=@Branch"
            End If

            If strCategory.Length > 0 Then
                strSql += " AND ServiceType=@ServiceType"
            End If

            If strBrand.Length > 0 Then
                strSql += " AND Brand=@Brand"
            End If

            If strModelNo.Length > 0 Then
                strSql += " AND ModelNo=@ModelNo"
            End If
            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dc As OleDbCommand = New OleDbCommand(strSql, con)
                If strBranch.Length > 0 Then
                    dc.Parameters.Add("@Branch", OleDbType.Char, 255).Value = strBranch
                End If

                If strCategory.Length > 0 Then
                    dc.Parameters.Add("@ServiceType", OleDbType.Char, 255).Value = strCategory
                End If

                If strBrand.Length > 0 Then
                    dc.Parameters.Add("@Brand", OleDbType.Char, 255).Value = strBrand
                End If

                If strModelNo.Length > 0 Then
                    dc.Parameters.Add("@ModelNo", OleDbType.Char, 255).Value = strModelNo
                End If
                con.Open()

                If Not IsDBNull(dc.ExecuteScalar()) Then
                    dblTotalReceive = Double.Parse(dc.ExecuteScalar())
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            dblTotalReceive = 0
        End Try
        Return dblTotalReceive

    End Function


    Public Function PreviousReplaceServiceBranch(ByVal strBranch As String, strCategory As String, ByVal strBrand As String, ByVal strModelNo As String, StartDate As DateTime, ByVal EndDate As DateTime, ByVal strWarranty As String) As Integer
        Dim dblTotalReceive As Integer = 0
        Dim cs As String = ConfigurationManager.ConnectionStrings("dbcService").ConnectionString
        Dim strSql As String = String.Empty

        strSql = "Select count(CLaiminfo.JobCode) as TTlQty from Claiminfo where  1=1 AND sDate between #" & StartDate & "# and #" & EndDate & "# AND CFlag in(101) AND " & strWarranty
        Try

            If strBranch.Length > 0 Then
                strSql += " AND Branch=@Branch"
            End If

            If strCategory.Length > 0 Then
                strSql += " AND ServiceType=@ServiceType"
            End If

            If strBrand.Length > 0 Then
                strSql += " AND Brand=@Brand"
            End If

            If strModelNo.Length > 0 Then
                strSql += " AND ModelNo=@ModelNo"
            End If
            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dc As OleDbCommand = New OleDbCommand(strSql, con)
                If strBranch.Length > 0 Then
                    dc.Parameters.Add("@Branch", OleDbType.Char, 255).Value = strBranch
                End If

                If strCategory.Length > 0 Then
                    dc.Parameters.Add("@ServiceType", OleDbType.Char, 255).Value = strCategory
                End If

                If strBrand.Length > 0 Then
                    dc.Parameters.Add("@Brand", OleDbType.Char, 255).Value = strBrand
                End If

                If strModelNo.Length > 0 Then
                    dc.Parameters.Add("@ModelNo", OleDbType.Char, 255).Value = strModelNo
                End If
                con.Open()

                If Not IsDBNull(dc.ExecuteScalar()) Then
                    dblTotalReceive = Double.Parse(dc.ExecuteScalar())
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            dblTotalReceive = 0
        End Try
        Return dblTotalReceive

    End Function




    Public Function PreviousReplaceDeliveredBranch(ByVal strBranch As String, strCategory As String, ByVal strBrand As String, ByVal strModelNo As String, StartDate As DateTime, ByVal EndDate As DateTime, ByVal strWarranty As String) As Integer
        Dim dblTotalReceive As Integer = 0
        Dim cs As String = ConfigurationManager.ConnectionStrings("dbcService").ConnectionString
        Dim strSql As String = String.Empty

        strSql = "Select count(CLaiminfo.JobCode) as TTlQty from Claiminfo where  1=1 AND dDate between #" & StartDate & "# and #" & EndDate & "# AND CFlag in(102) AND " & strWarranty
        Try

            If strBranch.Length > 0 Then
                strSql += " AND Branch=@Branch"
            End If

            If strCategory.Length > 0 Then
                strSql += " AND ServiceType=@ServiceType"
            End If

            If strBrand.Length > 0 Then
                strSql += " AND Brand=@Brand"
            End If

            If strModelNo.Length > 0 Then
                strSql += " AND ModelNo=@ModelNo"
            End If
            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dc As OleDbCommand = New OleDbCommand(strSql, con)
                If strBranch.Length > 0 Then
                    dc.Parameters.Add("@Branch", OleDbType.Char, 255).Value = strBranch
                End If

                If strCategory.Length > 0 Then
                    dc.Parameters.Add("@ServiceType", OleDbType.Char, 255).Value = strCategory
                End If

                If strBrand.Length > 0 Then
                    dc.Parameters.Add("@Brand", OleDbType.Char, 255).Value = strBrand
                End If

                If strModelNo.Length > 0 Then
                    dc.Parameters.Add("@ModelNo", OleDbType.Char, 255).Value = strModelNo
                End If
                con.Open()

                If Not IsDBNull(dc.ExecuteScalar()) Then
                    dblTotalReceive = Double.Parse(dc.ExecuteScalar())
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            dblTotalReceive = 0
        End Try
        Return dblTotalReceive

    End Function

    Public Function PreviousTotalAmountBranch(ByVal strBranch As String, strCategory As String, ByVal strBrand As String, ByVal strModelNo As String, StartDate As DateTime, ByVal EndDate As DateTime, ByVal strWarranty As String) As Integer
        Dim dblTotalReceive As Integer = 0
        Dim cs As String = ConfigurationManager.ConnectionStrings("dbcService").ConnectionString
        Dim strSql As String = String.Empty

        strSql = "Select Sum((CLaiminfo.SvAmt+CLaiminfo.PrdAmt+CLaiminfo.OtherAmt+Claiminfo.VatAmnt)-(CLaiminfo.Dis-CLaiminfo.AdvanceAmnt)) as TotalAmount from Claiminfo where  1=1 AND ddate between #" & StartDate & "# and #" & EndDate & "# AND CFlag in(0,2) AND " & strWarranty
        Try

            If strBranch.Length > 0 Then
                strSql += " AND Branch=@Branch"
            End If

            If strCategory.Length > 0 Then
                strSql += " AND ServiceType=@ServiceType"
            End If

            If strBrand.Length > 0 Then
                strSql += " AND Brand=@Brand"
            End If

            If strModelNo.Length > 0 Then
                strSql += " AND ModelNo=@ModelNo"
            End If
            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dc As OleDbCommand = New OleDbCommand(strSql, con)
                If strBranch.Length > 0 Then
                    dc.Parameters.Add("@Branch", OleDbType.Char, 255).Value = strBranch
                End If

                If strCategory.Length > 0 Then
                    dc.Parameters.Add("@ServiceType", OleDbType.Char, 255).Value = strCategory
                End If

                If strBrand.Length > 0 Then
                    dc.Parameters.Add("@Brand", OleDbType.Char, 255).Value = strBrand
                End If

                If strModelNo.Length > 0 Then
                    dc.Parameters.Add("@ModelNo", OleDbType.Char, 255).Value = strModelNo
                End If
                con.Open()


                If Not IsDBNull(dc.ExecuteScalar()) Then
                    dblTotalReceive = Double.Parse(dc.ExecuteScalar())
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            dblTotalReceive = 0
        End Try
        Return dblTotalReceive

    End Function

    ' ___________________________________________________ End of Previous Data Branch Section ______________________________________________

#End Region
#Region "Previous Data Other Branch Section"



    ' ___________________________________________________ Start of Previous Data Other Branch Section ______________________________________________


    Public Function PreviousReceiveOtherBranch(ByVal strBranch As String, strCategory As String, ByVal strBrand As String, ByVal strModelNo As String, ByVal StartDate As DateTime, ByVal EndDate As DateTime, ByVal strWarranty As String) As Double
        Dim dblTotalReceive As Double = 0
        Dim cs As String = ConfigurationManager.ConnectionStrings("dbcService").ConnectionString
        Dim strSql As String = String.Empty
        strSql = "Select count(CLaiminfo.JobCode) as TTlQty from Claiminfo where  1=1 AND ReceptDate between #" & StartDate & "# and #" & EndDate & "# AND " & strWarranty
        Try

            If strBranch.Length > 0 Then
                strSql += " AND Branch<>@Branch "
            End If

            If strCategory.Length > 0 Then
                strSql += " AND ServiceType=@ServiceType "
            End If

            If strBrand.Length > 0 Then
                strSql += " AND Brand=@Brand "
            End If

            If strModelNo.Length > 0 Then
                strSql += " AND ModelNo=@ModelNo "
            End If


            Using con As OleDbConnection = New OleDbConnection(cs)


                Dim dc As OleDbCommand = New OleDbCommand(strSql, con)

                If strBranch.Length > 0 Then
                    dc.Parameters.Add("@Branch", OleDbType.Char, 255).Value = strBranch
                End If

                If strCategory.Length > 0 Then
                    dc.Parameters.Add("@ServiceType", OleDbType.Char, 255).Value = strCategory
                End If

                If strBrand.Length > 0 Then
                    dc.Parameters.Add("@Brand", OleDbType.Char, 255).Value = strBrand
                End If

                If strModelNo.Length > 0 Then
                    dc.Parameters.Add("@ModelNo", OleDbType.Char, 255).Value = strModelNo
                End If


                con.Open()


                If Not IsDBNull(dc.ExecuteScalar()) Then
                    dblTotalReceive = Double.Parse(dc.ExecuteScalar())
                End If



            End Using


        Catch ex As Exception
            dblTotalReceive = 0
        End Try
        Return dblTotalReceive

    End Function




    Public Function PreviousRepairedOtherBranch(ByVal strBranch As String, strCategory As String, ByVal strBrand As String, ByVal strModelNo As String, ByVal StartDate As DateTime, ByVal EndDate As DateTime, ByVal strWarranty As String) As Double
        Dim dblTotalReceive As Double = 0
        Dim cs As String = ConfigurationManager.ConnectionStrings("dbcService").ConnectionString
        Dim strSql As String = String.Empty
        strSql = "Select count(CLaiminfo.JobCode) as TTlQty from Claiminfo where  1=1 AND Sdate between #" & StartDate & "# and #" & EndDate & "# AND not  Claiminfo.CFlag in(9,99,100,101,102) AND " & strWarranty
        Try

            If strBranch.Length > 0 Then
                strSql += " AND Branch<>@Branch "
            End If

            If strCategory.Length > 0 Then
                strSql += " AND ServiceType=@ServiceType "
            End If

            If strBrand.Length > 0 Then
                strSql += " AND Brand=@Brand "
            End If

            If strModelNo.Length > 0 Then
                strSql += " AND ModelNo=@ModelNo "
            End If


            Using con As OleDbConnection = New OleDbConnection(cs)


                Dim dc As OleDbCommand = New OleDbCommand(strSql, con)
                If strBranch.Length > 0 Then
                    dc.Parameters.Add("@Branch", OleDbType.Char, 255).Value = strBranch
                End If

                If strCategory.Length > 0 Then
                    dc.Parameters.Add("@ServiceType", OleDbType.Char, 255).Value = strCategory
                End If

                If strBrand.Length > 0 Then
                    dc.Parameters.Add("@Brand", OleDbType.Char, 255).Value = strBrand
                End If

                If strModelNo.Length > 0 Then
                    dc.Parameters.Add("@ModelNo", OleDbType.Char, 255).Value = strModelNo
                End If


                con.Open()


                If Not IsDBNull(dc.ExecuteScalar()) Then
                    dblTotalReceive = Double.Parse(dc.ExecuteScalar())
                End If



            End Using


        Catch ex As Exception
            dblTotalReceive = 0
        End Try
        Return dblTotalReceive

    End Function




    Public Function PreviousDeliveredOtherBranch(ByVal strBranch As String, strCategory As String, ByVal strBrand As String, ByVal strModelNo As String, ByVal StartDate As DateTime, ByVal EndDate As DateTime, ByVal strWarranty As String) As Double
        Dim dblTotalReceive As Double = 0
        Dim cs As String = ConfigurationManager.ConnectionStrings("dbcService").ConnectionString
        Dim strSql As String = String.Empty
        strSql = "Select count(CLaiminfo.JobCode) as TTlQty from Claiminfo where  1=1 AND Ddate between #" & StartDate & "# and #" & EndDate & "# AND CFlag in(0,2) AND " & strWarranty
        Try

            If strBranch.Length > 0 Then
                strSql += " AND Branch<>@Branch "
            End If

            If strCategory.Length > 0 Then
                strSql += " AND ServiceType=@ServiceType "
            End If

            If strBrand.Length > 0 Then
                strSql += " AND Brand=@Brand "
            End If

            If strModelNo.Length > 0 Then
                strSql += " AND ModelNo=@ModelNo "
            End If


            Using con As OleDbConnection = New OleDbConnection(cs)


                Dim dc As OleDbCommand = New OleDbCommand(strSql, con)

                If strBranch.Length > 0 Then
                    dc.Parameters.Add("@Branch", OleDbType.Char, 255).Value = strBranch
                End If

                If strCategory.Length > 0 Then
                    dc.Parameters.Add("@ServiceType", OleDbType.Char, 255).Value = strCategory
                End If

                If strBrand.Length > 0 Then
                    dc.Parameters.Add("@Brand", OleDbType.Char, 255).Value = strBrand
                End If

                If strModelNo.Length > 0 Then
                    dc.Parameters.Add("@ModelNo", OleDbType.Char, 255).Value = strModelNo
                End If


                con.Open()

                If Not IsDBNull(dc.ExecuteScalar()) Then
                    dblTotalReceive = Double.Parse(dc.ExecuteScalar())
                End If



            End Using


        Catch ex As Exception
            dblTotalReceive = 0
        End Try
        Return dblTotalReceive

    End Function





    Public Function PreviousNrOtherBranch(ByVal strBranch As String, strCategory As String, ByVal strBrand As String, ByVal strModelNo As String, ByVal StartDate As DateTime, ByVal EndDate As DateTime, ByVal strWarranty As String) As Double
        Dim dblTotalReceive As Double = 0
        Dim cs As String = ConfigurationManager.ConnectionStrings("dbcService").ConnectionString
        Dim strSql As String = String.Empty
        strSql = "Select count(CLaiminfo.JobCode) as TTlQty from Claiminfo where  1=1 AND sdate between #" & StartDate & "# and #" & EndDate & "# AND CFlag in(99) AND " & strWarranty
        Try

            If strBranch.Length > 0 Then
                strSql += " AND Branch<>@Branch "
            End If

            If strCategory.Length > 0 Then
                strSql += " AND ServiceType=@ServiceType "
            End If

            If strBrand.Length > 0 Then
                strSql += " AND Brand=@Brand "
            End If

            If strModelNo.Length > 0 Then
                strSql += " AND ModelNo=@ModelNo "
            End If
            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dc As OleDbCommand = New OleDbCommand(strSql, con)
                If strBranch.Length > 0 Then
                    dc.Parameters.Add("@Branch", OleDbType.Char, 255).Value = strBranch
                End If

                If strCategory.Length > 0 Then
                    dc.Parameters.Add("@ServiceType", OleDbType.Char, 255).Value = strCategory
                End If

                If strBrand.Length > 0 Then
                    dc.Parameters.Add("@Brand", OleDbType.Char, 255).Value = strBrand
                End If

                If strModelNo.Length > 0 Then
                    dc.Parameters.Add("@ModelNo", OleDbType.Char, 255).Value = strModelNo
                End If
                con.Open()

                If Not IsDBNull(dc.ExecuteScalar()) Then
                    dblTotalReceive = Double.Parse(dc.ExecuteScalar())
                End If
            End Using

        Catch ex As Exception
            dblTotalReceive = 0
        End Try
        Return dblTotalReceive

    End Function



    Public Function PreviousCROtherBranch(ByVal strBranch As String, strCategory As String, ByVal strBrand As String, ByVal strModelNo As String, ByVal StartDate As DateTime, ByVal EndDate As DateTime, ByVal strWarranty As String) As Double
        Dim dblTotalReceive As Double = 0
        Dim cs As String = ConfigurationManager.ConnectionStrings("dbcService").ConnectionString
        Dim strSql As String = String.Empty
        strSql = "Select count(CLaiminfo.JobCode) as TTlQty from Claiminfo where  1=1 AND Ddate between #" & StartDate & "# and #" & EndDate & "# AND CFlag in(100) AND " & strWarranty
        Try

            If strBranch.Length > 0 Then
                strSql += " AND Branch<>@Branch "
            End If

            If strCategory.Length > 0 Then
                strSql += " AND ServiceType=@ServiceType "
            End If

            If strBrand.Length > 0 Then
                strSql += " AND Brand=@Brand "
            End If

            If strModelNo.Length > 0 Then
                strSql += " AND ModelNo=@ModelNo "
            End If
            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dc As OleDbCommand = New OleDbCommand(strSql, con)
                If strBranch.Length > 0 Then
                    dc.Parameters.Add("@Branch", OleDbType.Char, 255).Value = strBranch
                End If

                If strCategory.Length > 0 Then
                    dc.Parameters.Add("@ServiceType", OleDbType.Char, 255).Value = strCategory
                End If

                If strBrand.Length > 0 Then
                    dc.Parameters.Add("@Brand", OleDbType.Char, 255).Value = strBrand
                End If

                If strModelNo.Length > 0 Then
                    dc.Parameters.Add("@ModelNo", OleDbType.Char, 255).Value = strModelNo
                End If
                con.Open()

                If Not IsDBNull(dc.ExecuteScalar()) Then
                    dblTotalReceive = Double.Parse(dc.ExecuteScalar())
                End If
            End Using

        Catch ex As Exception
            dblTotalReceive = 0
        End Try
        Return dblTotalReceive

    End Function





    Public Function PreviousReplaceServiceOtherBranch(ByVal strBranch As String, strCategory As String, ByVal strBrand As String, ByVal strModelNo As String, ByVal StartDate As DateTime, ByVal EndDate As DateTime, ByVal strWarranty As String) As Double
        Dim dblTotalReceive As Double = 0
        Dim cs As String = ConfigurationManager.ConnectionStrings("dbcService").ConnectionString
        Dim strSql As String = String.Empty
        strSql = "Select count(CLaiminfo.JobCode) as TTlQty from Claiminfo where  1=1 AND sdate between #" & StartDate & "# and #" & EndDate & "# AND CFlag in(101) AND " & strWarranty
        Try

            If strBranch.Length > 0 Then
                strSql += " AND Branch<>@Branch"
            End If

            If strCategory.Length > 0 Then
                strSql += " AND ServiceType=@ServiceType"
            End If

            If strBrand.Length > 0 Then
                strSql += " AND Brand=@Brand"
            End If

            If strModelNo.Length > 0 Then
                strSql += " AND ModelNo=@ModelNo"
            End If
            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dc As OleDbCommand = New OleDbCommand(strSql, con)
                If strBranch.Length > 0 Then
                    dc.Parameters.Add("@Branch", OleDbType.Char, 255).Value = strBranch
                End If

                If strCategory.Length > 0 Then
                    dc.Parameters.Add("@ServiceType", OleDbType.Char, 255).Value = strCategory
                End If

                If strBrand.Length > 0 Then
                    dc.Parameters.Add("@Brand", OleDbType.Char, 255).Value = strBrand
                End If

                If strModelNo.Length > 0 Then
                    dc.Parameters.Add("@ModelNo", OleDbType.Char, 255).Value = strModelNo
                End If
                con.Open()

                If Not IsDBNull(dc.ExecuteScalar()) Then
                    dblTotalReceive = Double.Parse(dc.ExecuteScalar())
                End If
            End Using

        Catch ex As Exception
            dblTotalReceive = 0
        End Try
        Return dblTotalReceive

    End Function



    Public Function PreviousReplaceDeliveredOtherBranch(ByVal strBranch As String, strCategory As String, ByVal strBrand As String, ByVal strModelNo As String, ByVal StartDate As DateTime, ByVal EndDate As DateTime, ByVal strWarranty As String) As Double
        Dim dblTotalReceive As Double = 0
        Dim cs As String = ConfigurationManager.ConnectionStrings("dbcService").ConnectionString
        Dim strSql As String = String.Empty
        strSql = "Select count(CLaiminfo.JobCode) as TTlQty from Claiminfo where  1=1 AND Ddate between #" & StartDate & "# and #" & EndDate & "# AND CFlag in(102) AND " & strWarranty
        Try

            If strBranch.Length > 0 Then
                strSql += " AND Branch<>@Branch"
            End If

            If strCategory.Length > 0 Then
                strSql += " AND ServiceType=@ServiceType"
            End If

            If strBrand.Length > 0 Then
                strSql += " AND Brand=@Brand"
            End If

            If strModelNo.Length > 0 Then
                strSql += " AND ModelNo=@ModelNo"
            End If
            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dc As OleDbCommand = New OleDbCommand(strSql, con)
                If strBranch.Length > 0 Then
                    dc.Parameters.Add("@Branch", OleDbType.Char, 255).Value = strBranch
                End If

                If strCategory.Length > 0 Then
                    dc.Parameters.Add("@ServiceType", OleDbType.Char, 255).Value = strCategory
                End If

                If strBrand.Length > 0 Then
                    dc.Parameters.Add("@Brand", OleDbType.Char, 255).Value = strBrand
                End If

                If strModelNo.Length > 0 Then
                    dc.Parameters.Add("@ModelNo", OleDbType.Char, 255).Value = strModelNo
                End If
                con.Open()

                If Not IsDBNull(dc.ExecuteScalar()) Then
                    dblTotalReceive = Double.Parse(dc.ExecuteScalar())
                End If
            End Using

        Catch ex As Exception
            dblTotalReceive = 0
        End Try
        Return dblTotalReceive

    End Function




    Public Function PreviousTotalAmountOtherBranch(ByVal strBranch As String, strCategory As String, ByVal strBrand As String, ByVal strModelNo As String, StartDate As DateTime, ByVal EndDate As DateTime, ByVal strWarranty As String) As Integer
        Dim dblTotalReceive As Integer = 0
        Dim cs As String = ConfigurationManager.ConnectionStrings("dbcService").ConnectionString
        Dim strSql As String = String.Empty

        strSql = "Select Sum((CLaiminfo.SvAmt+CLaiminfo.PrdAmt+CLaiminfo.OtherAmt+Claiminfo.VatAmnt)-(CLaiminfo.Dis-CLaiminfo.AdvanceAmnt)) as TotalAmount from Claiminfo where  1=1 AND dDate between #" & StartDate & "# and #" & EndDate & "# AND CFlag in(0,2) AND " & strWarranty
        Try

            If strBranch.Length > 0 Then
                strSql += " AND Branch<>@Branch"
            End If

            If strCategory.Length > 0 Then
                strSql += " AND ServiceType=@ServiceType"
            End If

            If strBrand.Length > 0 Then
                strSql += " AND Brand=@Brand"
            End If

            If strModelNo.Length > 0 Then
                strSql += " AND ModelNo=@ModelNo"
            End If
            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dc As OleDbCommand = New OleDbCommand(strSql, con)
                If strBranch.Length > 0 Then
                    dc.Parameters.Add("@Branch", OleDbType.Char, 255).Value = strBranch
                End If

                If strCategory.Length > 0 Then
                    dc.Parameters.Add("@ServiceType", OleDbType.Char, 255).Value = strCategory
                End If

                If strBrand.Length > 0 Then
                    dc.Parameters.Add("@Brand", OleDbType.Char, 255).Value = strBrand
                End If

                If strModelNo.Length > 0 Then
                    dc.Parameters.Add("@ModelNo", OleDbType.Char, 255).Value = strModelNo
                End If
                con.Open()

                If Not IsDBNull(dc.ExecuteScalar()) Then
                    dblTotalReceive = Double.Parse(dc.ExecuteScalar())
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            dblTotalReceive = 0
        End Try
        Return dblTotalReceive

    End Function


    ' ___________________________________________________ End of Previous Data Other Branch Section ______________________________________________

#End Region




#End Region





#Region "Today Data Section"

#Region "Branch Section"

    '_________________________________ Start of Today Data Branch Section __________________________________________________________
    Public Function TodayReceiveBranch(ByVal strBranch As String, strCategory As String, ByVal strBrand As String, ByVal strModelNo As String, StartDate As DateTime, ByVal EndDate As DateTime, ByVal strWarranty As String) As Integer
        Dim dblTotalReceive As Integer = 0
        Dim cs As String = ConfigurationManager.ConnectionStrings("dbcService").ConnectionString
        Dim strSql As String = String.Empty

        strSql = "Select count(CLaiminfo.JobCode) as TTlQty from Claiminfo where  1=1 AND ReceptDate between #" & StartDate & "# and #" & EndDate & "# AND " & strWarranty
        Try

            If strBranch.Length > 0 Then
                strSql += " AND Branch=@Branch"
            End If

            If strCategory.Length > 0 Then
                strSql += " AND ServiceType=@ServiceType"
            End If

            If strBrand.Length > 0 Then
                strSql += " AND Brand=@Brand"
            End If

            If strModelNo.Length > 0 Then
                strSql += " AND ModelNo=@ModelNo"
            End If
            Using con As OleDbConnection = New OleDbConnection(cs)



                Dim dc As OleDbCommand = New OleDbCommand(strSql, con)
                If strBranch.Length > 0 Then
                    dc.Parameters.Add("@Branch", OleDbType.Char, 255).Value = strBranch
                End If

                If strCategory.Length > 0 Then
                    dc.Parameters.Add("@ServiceType", OleDbType.Char, 255).Value = strCategory
                End If

                If strBrand.Length > 0 Then
                    dc.Parameters.Add("@Brand", OleDbType.Char, 255).Value = strBrand
                End If

                If strModelNo.Length > 0 Then
                    dc.Parameters.Add("@ModelNo", OleDbType.Char, 255).Value = strModelNo
                End If
                con.Open()
                'Dim dr As OleDbDataReader = dc.ExecuteReader
                If Not IsDBNull(dc.ExecuteScalar()) Then
                    dblTotalReceive = Double.Parse(dc.ExecuteScalar())
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            dblTotalReceive = 0
        End Try
        Return dblTotalReceive

    End Function





    Public Function TodayRepairedBranch(ByVal strBranch As String, strCategory As String, ByVal strBrand As String, ByVal strModelNo As String, StartDate As DateTime, ByVal EndDate As DateTime, ByVal strWarranty As String) As Integer
        Dim dblTotalReceive As Integer = 0
        Dim cs As String = ConfigurationManager.ConnectionStrings("dbcService").ConnectionString
        Dim strSql As String = String.Empty

        strSql = "Select count(CLaiminfo.JobCode) as TTlQty from Claiminfo where  1=1 AND Sdate between #" & StartDate & "# and #" & EndDate & "# AND not Claiminfo.CFlag in(9,99,100,101,102) AND " & strWarranty
        Try

            If strBranch.Length > 0 Then
                strSql += " AND Branch=@Branch"
            End If

            If strCategory.Length > 0 Then
                strSql += " AND ServiceType=@ServiceType"
            End If

            If strBrand.Length > 0 Then
                strSql += " AND Brand=@Brand"
            End If

            If strModelNo.Length > 0 Then
                strSql += " AND ModelNo=@ModelNo"
            End If
            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dc As OleDbCommand = New OleDbCommand(strSql, con)
                If strBranch.Length > 0 Then
                    dc.Parameters.Add("@Branch", OleDbType.Char, 255).Value = strBranch
                End If

                If strCategory.Length > 0 Then
                    dc.Parameters.Add("@ServiceType", OleDbType.Char, 255).Value = strCategory
                End If

                If strBrand.Length > 0 Then
                    dc.Parameters.Add("@Brand", OleDbType.Char, 255).Value = strBrand
                End If

                If strModelNo.Length > 0 Then
                    dc.Parameters.Add("@ModelNo", OleDbType.Char, 255).Value = strModelNo
                End If
                con.Open()
                'Dim dr As OleDbDataReader = dc.ExecuteReader
                If Not IsDBNull(dc.ExecuteScalar()) Then
                    dblTotalReceive = Double.Parse(dc.ExecuteScalar())
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            dblTotalReceive = 0
        End Try
        Return dblTotalReceive

    End Function




    Public Function TodayDeliveredBranch(ByVal strBranch As String, strCategory As String, ByVal strBrand As String, ByVal strModelNo As String, StartDate As DateTime, ByVal EndDate As DateTime, ByVal strWarranty As String) As Integer
        Dim dblTotalReceive As Integer = 0
        Dim cs As String = ConfigurationManager.ConnectionStrings("dbcService").ConnectionString
        Dim strSql As String = String.Empty

        strSql = "Select count(CLaiminfo.JobCode) as TTlQty from Claiminfo where  1=1 AND Ddate between #" & StartDate & "# and #" & EndDate & "# AND CFlag in(0,2) AND " & strWarranty
        Try

            If strBranch.Length > 0 Then
                strSql += " AND Branch=@Branch"
            End If

            If strCategory.Length > 0 Then
                strSql += " AND ServiceType=@ServiceType"
            End If

            If strBrand.Length > 0 Then
                strSql += " AND Brand=@Brand"
            End If

            If strModelNo.Length > 0 Then
                strSql += " AND ModelNo=@ModelNo"
            End If
            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dc As OleDbCommand = New OleDbCommand(strSql, con)


                If strBranch.Length > 0 Then
                    dc.Parameters.Add("@Branch", OleDbType.Char, 255).Value = strBranch
                End If

                If strCategory.Length > 0 Then
                    dc.Parameters.Add("@ServiceType", OleDbType.Char, 255).Value = strCategory
                End If

                If strBrand.Length > 0 Then
                    dc.Parameters.Add("@Brand", OleDbType.Char, 255).Value = strBrand
                End If

                If strModelNo.Length > 0 Then
                    dc.Parameters.Add("@ModelNo", OleDbType.Char, 255).Value = strModelNo
                End If




                con.Open()







                'Dim dr As OleDbDataReader = dc.ExecuteReader


                If Not IsDBNull(dc.ExecuteScalar()) Then
                    dblTotalReceive = Convert.ToInt32(dc.ExecuteScalar())
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            dblTotalReceive = 0
        End Try
        Return dblTotalReceive

    End Function



    Public Function TodayNRBranch(ByVal strBranch As String, strCategory As String, ByVal strBrand As String, ByVal strModelNo As String, StartDate As DateTime, ByVal EndDate As DateTime, ByVal strWarranty As String) As Integer
        Dim dblTotalReceive As Integer = 0
        Dim cs As String = ConfigurationManager.ConnectionStrings("dbcService").ConnectionString
        Dim strSql As String = String.Empty

        strSql = "Select count(CLaiminfo.JobCode) as TTlQty from Claiminfo where  1=1 AND sdate between #" & StartDate & "# and #" & EndDate & "# AND CFlag in(99) AND " & strWarranty
        Try

            If strBranch.Length > 0 Then
                strSql += " AND Branch=@Branch"
            End If

            If strCategory.Length > 0 Then
                strSql += " AND ServiceType=@ServiceType"
            End If

            If strBrand.Length > 0 Then
                strSql += " AND Brand=@Brand"
            End If

            If strModelNo.Length > 0 Then
                strSql += " AND ModelNo=@ModelNo"
            End If
            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dc As OleDbCommand = New OleDbCommand(strSql, con)
                If strBranch.Length > 0 Then
                    dc.Parameters.Add("@Branch", OleDbType.Char, 255).Value = strBranch
                End If

                If strCategory.Length > 0 Then
                    dc.Parameters.Add("@ServiceType", OleDbType.Char, 255).Value = strCategory
                End If

                If strBrand.Length > 0 Then
                    dc.Parameters.Add("@Brand", OleDbType.Char, 255).Value = strBrand
                End If

                If strModelNo.Length > 0 Then
                    dc.Parameters.Add("@ModelNo", OleDbType.Char, 255).Value = strModelNo
                End If
                con.Open()
                'Dim dr As OleDbDataReader = dc.ExecuteReader
                If Not IsDBNull(dc.ExecuteScalar()) Then
                    dblTotalReceive = Double.Parse(dc.ExecuteScalar())
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            dblTotalReceive = 0
        End Try
        Return dblTotalReceive

    End Function



    Public Function TodayCRBranch(ByVal strBranch As String, strCategory As String, ByVal strBrand As String, ByVal strModelNo As String, StartDate As DateTime, ByVal EndDate As DateTime, ByVal strWarranty As String) As Integer
        Dim dblTotalReceive As Integer = 0
        Dim cs As String = ConfigurationManager.ConnectionStrings("dbcService").ConnectionString
        Dim strSql As String = String.Empty

        strSql = "Select count(CLaiminfo.JobCode) as TTlQty from Claiminfo where  1=1 AND Ddate between #" & StartDate & "# and #" & EndDate & "# AND CFlag in(100) AND " & strWarranty
        Try

            If strBranch.Length > 0 Then
                strSql += " AND Branch=@Branch"
            End If

            If strCategory.Length > 0 Then
                strSql += " AND ServiceType=@ServiceType"
            End If

            If strBrand.Length > 0 Then
                strSql += " AND Brand=@Brand"
            End If

            If strModelNo.Length > 0 Then
                strSql += " AND ModelNo=@ModelNo"
            End If
            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dc As OleDbCommand = New OleDbCommand(strSql, con)
                If strBranch.Length > 0 Then
                    dc.Parameters.Add("@Branch", OleDbType.Char, 255).Value = strBranch
                End If

                If strCategory.Length > 0 Then
                    dc.Parameters.Add("@ServiceType", OleDbType.Char, 255).Value = strCategory
                End If

                If strBrand.Length > 0 Then
                    dc.Parameters.Add("@Brand", OleDbType.Char, 255).Value = strBrand
                End If

                If strModelNo.Length > 0 Then
                    dc.Parameters.Add("@ModelNo", OleDbType.Char, 255).Value = strModelNo
                End If
                con.Open()
                'Dim dr As OleDbDataReader = dc.ExecuteReader
                If Not IsDBNull(dc.ExecuteScalar()) Then
                    dblTotalReceive = Double.Parse(dc.ExecuteScalar())
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            dblTotalReceive = 0
        End Try
        Return dblTotalReceive

    End Function




    Public Function TodayReplaceServiceBranch(ByVal strBranch As String, strCategory As String, ByVal strBrand As String, ByVal strModelNo As String, StartDate As DateTime, ByVal EndDate As DateTime, ByVal strWarranty As String) As Integer
        Dim dblTotalReceive As Integer = 0
        Dim cs As String = ConfigurationManager.ConnectionStrings("dbcService").ConnectionString
        Dim strSql As String = String.Empty

        strSql = "Select count(CLaiminfo.JobCode) as TTlQty from Claiminfo where  1=1 AND sDate between #" & StartDate & "# and #" & EndDate & "# AND CFlag in(101) AND " & strWarranty
        Try

            If strBranch.Length > 0 Then
                strSql += " AND Branch=@Branch"
            End If

            If strCategory.Length > 0 Then
                strSql += " AND ServiceType=@ServiceType"
            End If

            If strBrand.Length > 0 Then
                strSql += " AND Brand=@Brand"
            End If

            If strModelNo.Length > 0 Then
                strSql += " AND ModelNo=@ModelNo"
            End If
            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dc As OleDbCommand = New OleDbCommand(strSql, con)
                If strBranch.Length > 0 Then
                    dc.Parameters.Add("@Branch", OleDbType.Char, 255).Value = strBranch
                End If

                If strCategory.Length > 0 Then
                    dc.Parameters.Add("@ServiceType", OleDbType.Char, 255).Value = strCategory
                End If

                If strBrand.Length > 0 Then
                    dc.Parameters.Add("@Brand", OleDbType.Char, 255).Value = strBrand
                End If

                If strModelNo.Length > 0 Then
                    dc.Parameters.Add("@ModelNo", OleDbType.Char, 255).Value = strModelNo
                End If
                con.Open()
                'Dim dr As OleDbDataReader = dc.ExecuteReader
                If Not IsDBNull(dc.ExecuteScalar()) Then
                    dblTotalReceive = Double.Parse(dc.ExecuteScalar())
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            dblTotalReceive = 0
        End Try
        Return dblTotalReceive

    End Function




    Public Function TodayReplaceDeliveredBranch(ByVal strBranch As String, strCategory As String, ByVal strBrand As String, ByVal strModelNo As String, StartDate As DateTime, ByVal EndDate As DateTime, ByVal strWarranty As String) As Integer
        Dim dblTotalReceive As Integer = 0
        Dim cs As String = ConfigurationManager.ConnectionStrings("dbcService").ConnectionString
        Dim strSql As String = String.Empty

        strSql = "Select count(CLaiminfo.JobCode) as TTlQty from Claiminfo where  1=1 AND dDate between #" & StartDate & "# and #" & EndDate & "# AND CFlag in(102) AND " & strWarranty
        Try

            If strBranch.Length > 0 Then
                strSql += " AND Branch=@Branch"
            End If

            If strCategory.Length > 0 Then
                strSql += " AND ServiceType=@ServiceType"
            End If

            If strBrand.Length > 0 Then
                strSql += " AND Brand=@Brand"
            End If

            If strModelNo.Length > 0 Then
                strSql += " AND ModelNo=@ModelNo"
            End If
            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dc As OleDbCommand = New OleDbCommand(strSql, con)
                If strBranch.Length > 0 Then
                    dc.Parameters.Add("@Branch", OleDbType.Char, 255).Value = strBranch
                End If

                If strCategory.Length > 0 Then
                    dc.Parameters.Add("@ServiceType", OleDbType.Char, 255).Value = strCategory
                End If

                If strBrand.Length > 0 Then
                    dc.Parameters.Add("@Brand", OleDbType.Char, 255).Value = strBrand
                End If

                If strModelNo.Length > 0 Then
                    dc.Parameters.Add("@ModelNo", OleDbType.Char, 255).Value = strModelNo
                End If
                con.Open()
                'Dim dr As OleDbDataReader = dc.ExecuteReader
                If Not IsDBNull(dc.ExecuteScalar()) Then
                    dblTotalReceive = Double.Parse(dc.ExecuteScalar())
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            dblTotalReceive = 0
        End Try
        Return dblTotalReceive

    End Function


    Public Function TodayTotalAmountBranch(ByVal strBranch As String, strCategory As String, ByVal strBrand As String, ByVal strModelNo As String, StartDate As DateTime, ByVal EndDate As DateTime, ByVal strWarranty As String) As Integer
        Dim dblTotalReceive As Integer = 0
        Dim cs As String = ConfigurationManager.ConnectionStrings("dbcService").ConnectionString
        Dim strSql As String = String.Empty
        strSql = "Select Sum((CLaiminfo.SvAmt+CLaiminfo.PrdAmt+CLaiminfo.OtherAmt+Claiminfo.VatAmnt)-(CLaiminfo.Dis-CLaiminfo.AdvanceAmnt)) as TotalAmount from Claiminfo where  1=1 AND dDate between #" & StartDate & "# and #" & EndDate & "# AND CFlag in(0,2) AND " & strWarranty
        'strSql = "Select count(CLaiminfo.JobCode) as TTlQty from Claiminfo where  1=1 AND ddate between #" & StartDate & "# and #" & EndDate & "# AND CFlag in(0,2) AND " & strWarranty
        Try

            If strBranch.Length > 0 Then
                strSql += " AND Branch=@Branch"
            End If

            If strCategory.Length > 0 Then
                strSql += " AND ServiceType=@ServiceType"
            End If

            If strBrand.Length > 0 Then
                strSql += " AND Brand=@Brand"
            End If

            If strModelNo.Length > 0 Then
                strSql += " AND ModelNo=@ModelNo"
            End If
            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dc As OleDbCommand = New OleDbCommand(strSql, con)
                If strBranch.Length > 0 Then
                    dc.Parameters.Add("@Branch", OleDbType.Char, 255).Value = strBranch
                End If

                If strCategory.Length > 0 Then
                    dc.Parameters.Add("@ServiceType", OleDbType.Char, 255).Value = strCategory
                End If

                If strBrand.Length > 0 Then
                    dc.Parameters.Add("@Brand", OleDbType.Char, 255).Value = strBrand
                End If

                If strModelNo.Length > 0 Then
                    dc.Parameters.Add("@ModelNo", OleDbType.Char, 255).Value = strModelNo
                End If
                con.Open()
                'Dim dr As OleDbDataReader = dc.ExecuteReader
                If Not IsDBNull(dc.ExecuteScalar()) Then
                    dblTotalReceive = Double.Parse(dc.ExecuteScalar())
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            dblTotalReceive = 0
        End Try
        Return dblTotalReceive

    End Function

    '_________________________________ End of Today Data Branch Section __________________________________________________________

#End Region

#Region "Others Branch Section"


    '_________________________________ Start of Today Data Others Branch Section __________________________________________________________

    Public Function TodayReceiveOtherBranch(ByVal strBranch As String, strCategory As String, ByVal strBrand As String, ByVal strModelNo As String, ByVal StartDate As DateTime, ByVal EndDate As DateTime, ByVal strWarranty As String) As Double
        Dim dblTotalReceive As Double = 0
        Dim cs As String = ConfigurationManager.ConnectionStrings("dbcService").ConnectionString
        Dim strSql As String = String.Empty
        strSql = "Select count(CLaiminfo.JobCode) as TTlQty from Claiminfo where  1=1 AND ReceptDate between #" & StartDate & "# and #" & EndDate & "# AND CFlag=-1 AND " & strWarranty
        Try

            If strBranch.Length > 0 Then
                strSql += " AND Branch<>@Branch"
            End If

            If strCategory.Length > 0 Then
                strSql += " AND ServiceType=@ServiceType"
            End If

            If strBrand.Length > 0 Then
                strSql += " AND Brand=@Brand"
            End If

            If strModelNo.Length > 0 Then
                strSql += " AND ModelNo=@ModelNo"
            End If


            Using con As OleDbConnection = New OleDbConnection(cs)


                Dim dc As OleDbCommand = New OleDbCommand(strSql, con)

                If strBranch.Length > 0 Then
                    dc.Parameters.Add("@Branch", OleDbType.Char, 255).Value = strBranch
                End If

                If strCategory.Length > 0 Then
                    dc.Parameters.Add("@ServiceType", OleDbType.Char, 255).Value = strCategory
                End If

                If strBrand.Length > 0 Then
                    dc.Parameters.Add("@Brand", OleDbType.Char, 255).Value = strBrand
                End If

                If strModelNo.Length > 0 Then
                    dc.Parameters.Add("@ModelNo", OleDbType.Char, 255).Value = strModelNo
                End If


                con.Open()

                If Not IsDBNull(dc.ExecuteScalar()) Then
                    dblTotalReceive = Double.Parse(dc.ExecuteScalar())
                End If



            End Using


        Catch ex As Exception
            dblTotalReceive = 0
        End Try
        Return dblTotalReceive

    End Function




    Public Function TodayRepairedOtherBranch(ByVal strBranch As String, strCategory As String, ByVal strBrand As String, ByVal strModelNo As String, ByVal StartDate As DateTime, ByVal EndDate As DateTime, ByVal strWarranty As String) As Double
        Dim dblTotalReceive As Double = 0
        Dim cs As String = ConfigurationManager.ConnectionStrings("dbcService").ConnectionString
        Dim strSql As String = String.Empty
        strSql = "Select count(CLaiminfo.JobCode) as TTlQty from Claiminfo where  1=1 AND Sdate between #" & StartDate & "# and #" & EndDate & "# AND not Claiminfo.CFlag in(9,99,100,101,102) AND " & strWarranty
        Try

            If strBranch.Length > 0 Then
                strSql += " AND Branch<>@Branch"
            End If

            If strCategory.Length > 0 Then
                strSql += " AND ServiceType=@ServiceType"
            End If

            If strBrand.Length > 0 Then
                strSql += " AND Brand=@Brand"
            End If

            If strModelNo.Length > 0 Then
                strSql += " AND ModelNo=@ModelNo"
            End If


            Using con As OleDbConnection = New OleDbConnection(cs)


                Dim dc As OleDbCommand = New OleDbCommand(strSql, con)

                If strBranch.Length > 0 Then
                    dc.Parameters.Add("@Branch", OleDbType.Char, 255).Value = strBranch
                End If

                If strCategory.Length > 0 Then
                    dc.Parameters.Add("@ServiceType", OleDbType.Char, 255).Value = strCategory
                End If

                If strBrand.Length > 0 Then
                    dc.Parameters.Add("@Brand", OleDbType.Char, 255).Value = strBrand
                End If

                If strModelNo.Length > 0 Then
                    dc.Parameters.Add("@ModelNo", OleDbType.Char, 255).Value = strModelNo
                End If


                con.Open()

                If Not IsDBNull(dc.ExecuteScalar()) Then
                    dblTotalReceive = Double.Parse(dc.ExecuteScalar())
                End If
            End Using


        Catch ex As Exception
            dblTotalReceive = 0
        End Try
        Return dblTotalReceive

    End Function




    Public Function TodayDeliveredOtherBranch(ByVal strBranch As String, strCategory As String, ByVal strBrand As String, ByVal strModelNo As String, ByVal StartDate As DateTime, ByVal EndDate As DateTime, ByVal strWarranty As String) As Double
        Dim dblTotalReceive As Double = 0
        Dim cs As String = ConfigurationManager.ConnectionStrings("dbcService").ConnectionString
        Dim strSql As String = String.Empty
        strSql = "Select count(CLaiminfo.JobCode) as TTlQty from Claiminfo where  1=1 AND Ddate between #" & StartDate & "# and #" & EndDate & "# AND CFlag in(0,2) AND " & strWarranty
        Try

            If strBranch.Length > 0 Then
                strSql += " AND Branch<>@Branch"
            End If

            If strCategory.Length > 0 Then
                strSql += " AND ServiceType=@ServiceType"
            End If

            If strBrand.Length > 0 Then
                strSql += " AND Brand=@Brand"
            End If

            If strModelNo.Length > 0 Then
                strSql += " AND ModelNo=@ModelNo"
            End If


            Using con As OleDbConnection = New OleDbConnection(cs)


                Dim dc As OleDbCommand = New OleDbCommand(strSql, con)
                If strBranch.Length > 0 Then
                    dc.Parameters.Add("@Branch", OleDbType.Char, 255).Value = strBranch
                End If

                If strCategory.Length > 0 Then
                    dc.Parameters.Add("@ServiceType", OleDbType.Char, 255).Value = strCategory
                End If

                If strBrand.Length > 0 Then
                    dc.Parameters.Add("@Brand", OleDbType.Char, 255).Value = strBrand
                End If

                If strModelNo.Length > 0 Then
                    dc.Parameters.Add("@ModelNo", OleDbType.Char, 255).Value = strModelNo
                End If

                con.Open()

                If Not IsDBNull(dc.ExecuteScalar()) Then
                    dblTotalReceive = Double.Parse(dc.ExecuteScalar())
                End If



            End Using


        Catch ex As Exception
            dblTotalReceive = 0
        End Try
        Return dblTotalReceive

    End Function





    Public Function TodayNROtherBranch(ByVal strBranch As String, strCategory As String, ByVal strBrand As String, ByVal strModelNo As String, ByVal StartDate As DateTime, ByVal EndDate As DateTime, ByVal strWarranty As String) As Double
        Dim dblTotalReceive As Double = 0
        Dim cs As String = ConfigurationManager.ConnectionStrings("dbcService").ConnectionString
        Dim strSql As String = String.Empty
        strSql = "Select count(CLaiminfo.JobCode) as TTlQty from Claiminfo where  1=1 AND sdate between #" & StartDate & "# and #" & EndDate & "# AND CFlag in(99) AND " & strWarranty
        Try

            If strBranch.Length > 0 Then
                strSql += " AND Branch<>@Branch"
            End If

            If strCategory.Length > 0 Then
                strSql += " AND ServiceType=@ServiceType"
            End If

            If strBrand.Length > 0 Then
                strSql += " AND Brand=@Brand"
            End If

            If strModelNo.Length > 0 Then
                strSql += " AND ModelNo=@ModelNo"
            End If
            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dc As OleDbCommand = New OleDbCommand(strSql, con)
                If strBranch.Length > 0 Then
                    dc.Parameters.Add("@Branch", OleDbType.Char, 255).Value = strBranch
                End If

                If strCategory.Length > 0 Then
                    dc.Parameters.Add("@ServiceType", OleDbType.Char, 255).Value = strCategory
                End If

                If strBrand.Length > 0 Then
                    dc.Parameters.Add("@Brand", OleDbType.Char, 255).Value = strBrand
                End If

                If strModelNo.Length > 0 Then
                    dc.Parameters.Add("@ModelNo", OleDbType.Char, 255).Value = strModelNo
                End If
                con.Open()
                If Not IsDBNull(dc.ExecuteScalar()) Then
                    dblTotalReceive = Double.Parse(dc.ExecuteScalar())
                End If
            End Using

        Catch ex As Exception
            dblTotalReceive = 0
        End Try
        Return dblTotalReceive

    End Function



    Public Function TodayCROtherBranch(ByVal strBranch As String, strCategory As String, ByVal strBrand As String, ByVal strModelNo As String, ByVal StartDate As DateTime, ByVal EndDate As DateTime, ByVal strWarranty As String) As Double
        Dim dblTotalReceive As Double = 0
        Dim cs As String = ConfigurationManager.ConnectionStrings("dbcService").ConnectionString
        Dim strSql As String = String.Empty
        strSql = "Select count(CLaiminfo.JobCode) as TTlQty from Claiminfo where  1=1 AND Ddate between #" & StartDate & "# and #" & EndDate & "# AND CFlag in(100) AND " & strWarranty
        Try

            If strBranch.Length > 0 Then
                strSql += " AND Branch<>@Branch"
            End If

            If strCategory.Length > 0 Then
                strSql += " AND ServiceType=@ServiceType"
            End If

            If strBrand.Length > 0 Then
                strSql += " AND Brand=@Brand"
            End If

            If strModelNo.Length > 0 Then
                strSql += " AND ModelNo=@ModelNo"
            End If
            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dc As OleDbCommand = New OleDbCommand(strSql, con)
                If strBranch.Length > 0 Then
                    dc.Parameters.Add("@Branch", OleDbType.Char, 255).Value = strBranch
                End If

                If strCategory.Length > 0 Then
                    dc.Parameters.Add("@ServiceType", OleDbType.Char, 255).Value = strCategory
                End If

                If strBrand.Length > 0 Then
                    dc.Parameters.Add("@Brand", OleDbType.Char, 255).Value = strBrand
                End If

                If strModelNo.Length > 0 Then
                    dc.Parameters.Add("@ModelNo", OleDbType.Char, 255).Value = strModelNo
                End If
                con.Open()
                If Not IsDBNull(dc.ExecuteScalar()) Then
                    dblTotalReceive = Double.Parse(dc.ExecuteScalar())
                End If
            End Using

        Catch ex As Exception
            dblTotalReceive = 0
        End Try
        Return dblTotalReceive

    End Function





    Public Function TodayReplaceServiceOtherBranch(ByVal strBranch As String, strCategory As String, ByVal strBrand As String, ByVal strModelNo As String, ByVal StartDate As DateTime, ByVal EndDate As DateTime, ByVal strWarranty As String) As Double
        Dim dblTotalReceive As Double = 0
        Dim cs As String = ConfigurationManager.ConnectionStrings("dbcService").ConnectionString
        Dim strSql As String = String.Empty
        strSql = "Select count(CLaiminfo.JobCode) as TTlQty from Claiminfo where  1=1 AND sdate between #" & StartDate & "# and #" & EndDate & "# AND CFlag in(101) AND " & strWarranty
        Try

            If strBranch.Length > 0 Then
                strSql += " AND Branch<>@Branch"
            End If

            If strCategory.Length > 0 Then
                strSql += " AND ServiceType=@ServiceType"
            End If

            If strBrand.Length > 0 Then
                strSql += " AND Brand=@Brand"
            End If

            If strModelNo.Length > 0 Then
                strSql += " AND ModelNo=@ModelNo"
            End If
            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dc As OleDbCommand = New OleDbCommand(strSql, con)
                If strBranch.Length > 0 Then
                    dc.Parameters.Add("@Branch", OleDbType.Char, 255).Value = strBranch
                End If

                If strCategory.Length > 0 Then
                    dc.Parameters.Add("@ServiceType", OleDbType.Char, 255).Value = strCategory
                End If

                If strBrand.Length > 0 Then
                    dc.Parameters.Add("@Brand", OleDbType.Char, 255).Value = strBrand
                End If

                If strModelNo.Length > 0 Then
                    dc.Parameters.Add("@ModelNo", OleDbType.Char, 255).Value = strModelNo
                End If
                con.Open()
                If Not IsDBNull(dc.ExecuteScalar()) Then
                    dblTotalReceive = Double.Parse(dc.ExecuteScalar())
                End If
            End Using

        Catch ex As Exception
            dblTotalReceive = 0
        End Try
        Return dblTotalReceive

    End Function



    Public Function TodayReplaceDeliveredOtherBranch(ByVal strBranch As String, strCategory As String, ByVal strBrand As String, ByVal strModelNo As String, ByVal StartDate As DateTime, ByVal EndDate As DateTime, ByVal strWarranty As String) As Double
        Dim dblTotalReceive As Double = 0
        Dim cs As String = ConfigurationManager.ConnectionStrings("dbcService").ConnectionString
        Dim strSql As String = String.Empty
        strSql = "Select count(CLaiminfo.JobCode) as TTlQty from Claiminfo where  1=1 AND Ddate between #" & StartDate & "# and #" & EndDate & "# AND CFlag in(102) AND " & strWarranty
        Try

            If strBranch.Length > 0 Then
                strSql += " AND Branch<>@Branch"
            End If

            If strCategory.Length > 0 Then
                strSql += " AND ServiceType=@ServiceType"
            End If

            If strBrand.Length > 0 Then
                strSql += " AND Brand=@Brand"
            End If

            If strModelNo.Length > 0 Then
                strSql += " AND ModelNo=@ModelNo"
            End If
            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dc As OleDbCommand = New OleDbCommand(strSql, con)
                If strBranch.Length > 0 Then
                    dc.Parameters.Add("@Branch", OleDbType.Char, 255).Value = strBranch
                End If

                If strCategory.Length > 0 Then
                    dc.Parameters.Add("@ServiceType", OleDbType.Char, 255).Value = strCategory
                End If

                If strBrand.Length > 0 Then
                    dc.Parameters.Add("@Brand", OleDbType.Char, 255).Value = strBrand
                End If

                If strModelNo.Length > 0 Then
                    dc.Parameters.Add("@ModelNo", OleDbType.Char, 255).Value = strModelNo
                End If
                con.Open()
                If Not IsDBNull(dc.ExecuteScalar()) Then
                    dblTotalReceive = Double.Parse(dc.ExecuteScalar())
                End If
            End Using

        Catch ex As Exception
            dblTotalReceive = 0
        End Try
        Return dblTotalReceive

    End Function









    Public Function TodayTotalAmountOtherBranch(ByVal strBranch As String, strCategory As String, ByVal strBrand As String, ByVal strModelNo As String, StartDate As DateTime, ByVal EndDate As DateTime, ByVal strWarranty As String) As Integer
        Dim dblTotalReceive As Integer = 0
        Dim cs As String = ConfigurationManager.ConnectionStrings("dbcService").ConnectionString
        Dim strSql As String = String.Empty
        strSql = "Select Sum((CLaiminfo.SvAmt+CLaiminfo.PrdAmt+CLaiminfo.OtherAmt+Claiminfo.VatAmnt)-(CLaiminfo.Dis-CLaiminfo.AdvanceAmnt)) as TotalAmount from Claiminfo where  1=1 AND dDate between #" & StartDate & "# and #" & EndDate & "# AND CFlag in(0,2) AND " & strWarranty
        'strSql = "Select count(CLaiminfo.JobCode) as TTlQty from Claiminfo where  1=1 AND dDate between #" & StartDate & "# and #" & EndDate & "# AND CFlag in(0,2) AND " & strWarranty
        Try

            If strBranch.Length > 0 Then
                strSql += " AND Branch<>@Branch"
            End If

            If strCategory.Length > 0 Then
                strSql += " AND ServiceType=@ServiceType"
            End If

            If strBrand.Length > 0 Then
                strSql += " AND Brand=@Brand"
            End If

            If strModelNo.Length > 0 Then
                strSql += " AND ModelNo=@ModelNo"
            End If
            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dc As OleDbCommand = New OleDbCommand(strSql, con)
                If strBranch.Length > 0 Then
                    dc.Parameters.Add("@Branch", OleDbType.Char, 255).Value = strBranch
                End If

                If strCategory.Length > 0 Then
                    dc.Parameters.Add("@ServiceType", OleDbType.Char, 255).Value = strCategory
                End If

                If strBrand.Length > 0 Then
                    dc.Parameters.Add("@Brand", OleDbType.Char, 255).Value = strBrand
                End If

                If strModelNo.Length > 0 Then
                    dc.Parameters.Add("@ModelNo", OleDbType.Char, 255).Value = strModelNo
                End If
                con.Open()
                'Dim dr As OleDbDataReader = dc.ExecuteReader
                If Not IsDBNull(dc.ExecuteScalar()) Then
                    dblTotalReceive = Double.Parse(dc.ExecuteScalar())
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            dblTotalReceive = 0
        End Try
        Return dblTotalReceive
    End Function
    '_________________________________ End of Today Data Others Branch Section __________________________________________________________
#End Region

#End Region


End Class
