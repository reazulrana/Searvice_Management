Imports System.Collections.Generic
Imports System.Configuration
Imports System.Data
Imports System.Data.OleDb



Public Class clsClaiminfoMethods

    Public ReadOnly Property LoadClaiminfo() As IEnumerable(Of clsClaiminfo)
        Get


            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Dim Claiminfo As List(Of clsClaiminfo) = New List(Of clsClaiminfo)


        Using con As OleDbConnection = New OleDbConnection(cs)



            Dim dcLoadClaiminf As OleDbCommand = New OleDbCommand("qryGet_All_Claiminfo", con)
            dcLoadClaiminf.CommandType = CommandType.StoredProcedure


            con.Open()
            Dim drLoadClaiminfo = dcLoadClaiminf.ExecuteReader

             If drLoadClaiminfo.HasRows = True Then
                    Try

                        While drLoadClaiminfo.Read
                    Dim tmpClaiminfo As clsClaiminfo = New clsClaiminfo
                        


                            tmpClaiminfo.JobID = Convert.ToInt32(drLoadClaiminfo("JobID").ToString())
                    tmpClaiminfo.Jobcode = drLoadClaiminfo("Jobcode").ToString()
                    tmpClaiminfo.Branch = drLoadClaiminfo("Branch").ToString()
                    tmpClaiminfo.CustName = drLoadClaiminfo("CustName").ToString()
                    tmpClaiminfo.CustAddress1 = drLoadClaiminfo("CustAddress1").ToString()
                    tmpClaiminfo.CustAddress2 = drLoadClaiminfo("CustAddress2").ToString()
                    tmpClaiminfo.Brand = drLoadClaiminfo("Brand").ToString()
                    tmpClaiminfo.ModelNo = drLoadClaiminfo("ModelNo").ToString()
                    tmpClaiminfo.MobileNo = drLoadClaiminfo("MobileNo").ToString()
                    tmpClaiminfo.ESN = drLoadClaiminfo("ESN").ToString()
                    tmpClaiminfo.SLNo = drLoadClaiminfo("SLNo").ToString()

                    If Not String.IsNullOrEmpty(drLoadClaiminfo("ReceptDate").ToString()) Then
                        tmpClaiminfo.ReceptDate = Convert.ToDateTime(drLoadClaiminfo("ReceptDate").ToString())
                    End If

                    If Not String.IsNullOrEmpty(drLoadClaiminfo("AppDelDate").ToString()) Then
                        tmpClaiminfo.AppDelDate = Convert.ToDateTime(drLoadClaiminfo("AppDelDate").ToString())
                    End If


                    tmpClaiminfo.ServiceType = drLoadClaiminfo("ServiceType").ToString()
                    If Not String.IsNullOrEmpty(drLoadClaiminfo("PDate").ToString()) Then
                        tmpClaiminfo.PDate = Convert.ToDateTime(drLoadClaiminfo("PDate").ToString())
                    End If

                    tmpClaiminfo.ReceptBy = drLoadClaiminfo("ReceptBy").ToString()
                    tmpClaiminfo.IssueTo = drLoadClaiminfo("IssueTo").ToString()

                    If Not String.IsNullOrEmpty(drLoadClaiminfo("IsssueDate").ToString()) Then
                        tmpClaiminfo.IsssueDate = Convert.ToDateTime(drLoadClaiminfo("IsssueDate").ToString())
                    End If

                    If Not String.IsNullOrEmpty(drLoadClaiminfo("SDate").ToString()) Then
                        tmpClaiminfo.SDate = Convert.ToDateTime(drLoadClaiminfo("SDate").ToString())
                    End If


                    tmpClaiminfo.ServiceBy = drLoadClaiminfo("ServiceBy").ToString()
                    If Not String.IsNullOrEmpty(drLoadClaiminfo("DDate").ToString()) Then
                        tmpClaiminfo.DDate = Convert.ToDateTime(drLoadClaiminfo("DDate").ToString())
                    End If

                            tmpClaiminfo.DeliverBy = drLoadClaiminfo("DeliverBy").ToString()

                            tmpClaiminfo.WCondition = Convert.ToInt32(drLoadClaiminfo("WCondition").ToString())
                            tmpClaiminfo.cFlag = Convert.ToInt32(drLoadClaiminfo("cFlag").ToString())

                            If Double.TryParse(drLoadClaiminfo("SvAmt").ToString(), tmpClaiminfo.SvAmt) = False Then
                                tmpClaiminfo.SvAmt = 0
                            End If


                            If Double.TryParse(drLoadClaiminfo("PrdAmt").ToString(), tmpClaiminfo.PrdAmt) = False Then
                                tmpClaiminfo.PrdAmt = 0
                            End If


                            If Double.TryParse(drLoadClaiminfo("OtherAmt").ToString(), tmpClaiminfo.OtherAmt) = False Then
                                tmpClaiminfo.OtherAmt = 0
                            End If


                            If Double.TryParse(drLoadClaiminfo("Dis").ToString(), tmpClaiminfo.Dis) = False Then
                                tmpClaiminfo.Dis = 0
                            End If

                            

                    If Not String.IsNullOrEmpty(drLoadClaiminfo("SRFlag").ToString()) Then
                        tmpClaiminfo.SRFlag = Convert.ToInt32(drLoadClaiminfo("SRFlag").ToString())
                    End If

                    tmpClaiminfo.Remk = drLoadClaiminfo("Remk").ToString()
                    tmpClaiminfo.PhyCond = drLoadClaiminfo("PhyCond").ToString()
                    tmpClaiminfo.Log_User = drLoadClaiminfo("Log_User").ToString()
                    If Not String.IsNullOrEmpty(drLoadClaiminfo("Log_Date").ToString()) Then
                        tmpClaiminfo.Log_Date = Convert.ToDateTime(drLoadClaiminfo("Log_Date").ToString())
                    End If

                    tmpClaiminfo.MRNO = drLoadClaiminfo("MRNO").ToString()
                            tmpClaiminfo.LastJobNO = drLoadClaiminfo("LastJobNO").ToString()
                            If Double.TryParse(drLoadClaiminfo("cAdvance").ToString(), tmpClaiminfo.cAdvance) = False Then
                                tmpClaiminfo.cAdvance = 0
                            End If

                            If Double.TryParse(drLoadClaiminfo("cTransportCrg").ToString(), tmpClaiminfo.cTransportCrg) = False Then
                                tmpClaiminfo.cTransportCrg = 0
                            End If


                            tmpClaiminfo.ReturnedItems = drLoadClaiminfo("ReturnedItems").ToString()
                            tmpClaiminfo.ItemRemarks = drLoadClaiminfo("ItemRemarks").ToString()

                            If Double.TryParse(drLoadClaiminfo("FreeOfCost").ToString(), tmpClaiminfo.FreeOfCost) = False Then
                                tmpClaiminfo.FreeOfCost = 0
                            End If

                            If Double.TryParse(drLoadClaiminfo("AdvanceAmnt").ToString(), tmpClaiminfo.AdvanceAmnt) = False Then
                                tmpClaiminfo.AdvanceAmnt = 0
                            End If

                            If Double.TryParse(drLoadClaiminfo("VatAmnt").ToString(), tmpClaiminfo.VatAmnt) = False Then
                                tmpClaiminfo.VatAmnt = 0
                            End If



                            tmpClaiminfo.Email = drLoadClaiminfo("Email").ToString()
                    Claiminfo.Add(tmpClaiminfo)
                End While

                    Catch ex As Exception
                        MessageBox.Show(drLoadClaiminfo("Jobcode").ToString())
                    End Try
                End If
        End Using
        Return Claiminfo


        End Get
    End Property


    Public ReadOnly Property LoadClaiminfo(ByVal StrCriteria As String) As IEnumerable(Of clsClaiminfo)
        Get


            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

            Dim Claiminfo As List(Of clsClaiminfo) = New List(Of clsClaiminfo)


            Using con As OleDbConnection = New OleDbConnection(cs)



                Dim dcLoadClaiminf As OleDbCommand = New OleDbCommand("Select * from Claiminfo where " & StrCriteria, con)
                dcLoadClaiminf.CommandType = CommandType.Text


                con.Open()
                Dim drLoadClaiminfo = dcLoadClaiminf.ExecuteReader

                If drLoadClaiminfo.HasRows = True Then

                    While drLoadClaiminfo.Read
                        Dim tmpClaiminfo As clsClaiminfo = New clsClaiminfo

                        tmpClaiminfo.JobID = Convert.ToInt32(drLoadClaiminfo("JobID").ToString())
                        tmpClaiminfo.Jobcode = drLoadClaiminfo("Jobcode").ToString()
                        tmpClaiminfo.Branch = drLoadClaiminfo("Branch").ToString()
                        tmpClaiminfo.CustName = drLoadClaiminfo("CustName").ToString()
                        tmpClaiminfo.CustAddress1 = drLoadClaiminfo("CustAddress1").ToString()
                        tmpClaiminfo.CustAddress2 = drLoadClaiminfo("CustAddress2").ToString()
                        tmpClaiminfo.Brand = drLoadClaiminfo("Brand").ToString()
                        tmpClaiminfo.ModelNo = drLoadClaiminfo("ModelNo").ToString()
                        tmpClaiminfo.MobileNo = drLoadClaiminfo("MobileNo").ToString()
                        tmpClaiminfo.ESN = drLoadClaiminfo("ESN").ToString()
                        tmpClaiminfo.SLNo = drLoadClaiminfo("SLNo").ToString()

                        If Not String.IsNullOrEmpty(drLoadClaiminfo("ReceptDate").ToString()) Then
                            tmpClaiminfo.ReceptDate = Convert.ToDateTime(drLoadClaiminfo("ReceptDate").ToString())
                        End If

                        If Not String.IsNullOrEmpty(drLoadClaiminfo("AppDelDate").ToString()) Then
                            tmpClaiminfo.AppDelDate = Convert.ToDateTime(drLoadClaiminfo("AppDelDate").ToString())
                        End If


                        tmpClaiminfo.ServiceType = drLoadClaiminfo("ServiceType").ToString()
                        If Not String.IsNullOrEmpty(drLoadClaiminfo("PDate").ToString()) Then
                            tmpClaiminfo.PDate = Convert.ToDateTime(drLoadClaiminfo("PDate").ToString())
                        End If

                        tmpClaiminfo.ReceptBy = drLoadClaiminfo("ReceptBy").ToString()
                        tmpClaiminfo.IssueTo = drLoadClaiminfo("IssueTo").ToString()

                        If Not String.IsNullOrEmpty(drLoadClaiminfo("IsssueDate").ToString()) Then
                            tmpClaiminfo.IsssueDate = Convert.ToDateTime(drLoadClaiminfo("IsssueDate").ToString())
                        End If

                        If Not String.IsNullOrEmpty(drLoadClaiminfo("SDate").ToString()) Then
                            tmpClaiminfo.SDate = Convert.ToDateTime(drLoadClaiminfo("SDate").ToString())
                        End If


                        tmpClaiminfo.ServiceBy = drLoadClaiminfo("ServiceBy").ToString()
                        If Not String.IsNullOrEmpty(drLoadClaiminfo("DDate").ToString()) Then
                            tmpClaiminfo.DDate = Convert.ToDateTime(drLoadClaiminfo("DDate").ToString())
                        End If

                        tmpClaiminfo.DeliverBy = drLoadClaiminfo("DeliverBy").ToString()
                        tmpClaiminfo.WCondition = Convert.ToInt32(drLoadClaiminfo("WCondition").ToString())
                        tmpClaiminfo.cFlag = Convert.ToInt32(drLoadClaiminfo("cFlag").ToString())
                        tmpClaiminfo.SvAmt = Convert.ToInt32(drLoadClaiminfo("SvAmt").ToString())
                        tmpClaiminfo.PrdAmt = Convert.ToInt32(drLoadClaiminfo("PrdAmt").ToString())
                        tmpClaiminfo.OtherAmt = Convert.ToInt32(drLoadClaiminfo("OtherAmt").ToString())
                        tmpClaiminfo.Dis = Convert.ToInt32(drLoadClaiminfo("Dis").ToString())

                        If Not String.IsNullOrEmpty(drLoadClaiminfo("SRFlag").ToString()) Then
                            tmpClaiminfo.SRFlag = Convert.ToInt32(drLoadClaiminfo("SRFlag").ToString())
                        End If

                        tmpClaiminfo.Remk = drLoadClaiminfo("Remk").ToString()
                        tmpClaiminfo.PhyCond = drLoadClaiminfo("PhyCond").ToString()
                        tmpClaiminfo.Log_User = drLoadClaiminfo("Log_User").ToString()
                        If Not String.IsNullOrEmpty(drLoadClaiminfo("Log_Date").ToString()) Then
                            tmpClaiminfo.Log_Date = Convert.ToDateTime(drLoadClaiminfo("Log_Date").ToString())
                        End If

                        tmpClaiminfo.MRNO = drLoadClaiminfo("MRNO").ToString()
                        tmpClaiminfo.LastJobNO = drLoadClaiminfo("LastJobNO").ToString()
                        tmpClaiminfo.cAdvance = Convert.ToDouble(drLoadClaiminfo("cAdvance").ToString())
                        tmpClaiminfo.cTransportCrg = Convert.ToDouble(drLoadClaiminfo("cTransportCrg").ToString())
                        tmpClaiminfo.ReturnedItems = drLoadClaiminfo("ReturnedItems").ToString()
                        tmpClaiminfo.ItemRemarks = drLoadClaiminfo("ItemRemarks").ToString()
                        tmpClaiminfo.FreeOfCost = Convert.ToInt32(drLoadClaiminfo("FreeOfCost").ToString())
                        tmpClaiminfo.AdvanceAmnt = Convert.ToDouble(drLoadClaiminfo("AdvanceAmnt").ToString())
                        tmpClaiminfo.VatAmnt = Convert.ToInt32(drLoadClaiminfo("VatAmnt").ToString())
                        tmpClaiminfo.Email = drLoadClaiminfo("Email").ToString()
                        Claiminfo.Add(tmpClaiminfo)
                    End While

                End If
            End Using
            Return Claiminfo


        End Get
    End Property









    Public Function IsExist(ByVal CheckID As String) As Boolean

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Dim blnFlag As Boolean = False

        Try




            Using con As OleDbConnection = New OleDbConnection(cs)



                Dim dcLoadClaiminf As OleDbCommand = New OleDbCommand("Select Claiminfo.JobCode from Claiminfo where Claiminfo.JobCode=@jobCode ", con)
                dcLoadClaiminf.Parameters.Add("@jobCode", OleDbType.Char, 255).Value = CheckID


                con.Open()
                Dim drLoadClaiminfo = dcLoadClaiminf.ExecuteReader

                If drLoadClaiminfo.HasRows = True Then
                    blnFlag = True

                End If
            End Using

        Catch ex As Exception
            blnFlag = False

        End Try
        Return blnFlag


    End Function





    Public Function LoadClaiminfo_StartWithLetter(ByVal StartWithLetter, ByVal Branch) As IEnumerable(Of clsClaiminfo)

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Dim Claiminfo As List(Of clsClaiminfo) = New List(Of clsClaiminfo)

        StartWithLetter = StartWithLetter & "%"

        Dim con As OleDbConnection = New OleDbConnection(cs)

        Dim dcLoadClaiminfo As OleDbCommand = New OleDbCommand("qryGetClaiminfo_StartWithLetter", con)
        dcLoadClaiminfo.CommandType = CommandType.StoredProcedure
        dcLoadClaiminfo.Parameters.Add("paramJobCode", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(StartWithLetter), DBNull.Value, StartWithLetter)
        dcLoadClaiminfo.Parameters.Add("paramBranch", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(Branch), DBNull.Value, Branch)

        con.Open()
        Dim drLoadClaiminfo = dcLoadClaiminfo.ExecuteReader

        If drLoadClaiminfo.HasRows = True Then


            While drLoadClaiminfo.Read
                Dim tmpClaiminfo As clsClaiminfo = New clsClaiminfo

                tmpClaiminfo.JobID = Convert.ToInt32(drLoadClaiminfo("JobID").ToString())
                tmpClaiminfo.Jobcode = drLoadClaiminfo("Jobcode").ToString()
                tmpClaiminfo.Branch = drLoadClaiminfo("Branch").ToString()
                tmpClaiminfo.CustName = drLoadClaiminfo("CustName").ToString()
                tmpClaiminfo.CustAddress1 = drLoadClaiminfo("CustAddress1").ToString()
                tmpClaiminfo.CustAddress2 = drLoadClaiminfo("CustAddress2").ToString()
                tmpClaiminfo.Brand = drLoadClaiminfo("Brand").ToString()
                tmpClaiminfo.ModelNo = drLoadClaiminfo("ModelNo").ToString()
                tmpClaiminfo.MobileNo = drLoadClaiminfo("MobileNo").ToString()
                tmpClaiminfo.ESN = drLoadClaiminfo("ESN").ToString()
                tmpClaiminfo.SLNo = drLoadClaiminfo("SLNo").ToString()

                If Not String.IsNullOrEmpty(drLoadClaiminfo("ReceptDate").ToString()) Then
                    tmpClaiminfo.ReceptDate = Convert.ToDateTime(drLoadClaiminfo("ReceptDate").ToString())
                End If

                If Not String.IsNullOrEmpty(drLoadClaiminfo("AppDelDate").ToString()) Then
                    tmpClaiminfo.AppDelDate = Convert.ToDateTime(drLoadClaiminfo("AppDelDate").ToString())
                End If


                tmpClaiminfo.ServiceType = drLoadClaiminfo("ServiceType").ToString()
                If Not String.IsNullOrEmpty(drLoadClaiminfo("PDate").ToString()) Then
                    tmpClaiminfo.PDate = Convert.ToDateTime(drLoadClaiminfo("PDate").ToString())
                End If

                tmpClaiminfo.ReceptBy = drLoadClaiminfo("ReceptBy").ToString()
                tmpClaiminfo.IssueTo = drLoadClaiminfo("IssueTo").ToString()

                If Not String.IsNullOrEmpty(drLoadClaiminfo("IsssueDate").ToString()) Then
                    tmpClaiminfo.IsssueDate = Convert.ToDateTime(drLoadClaiminfo("IsssueDate").ToString())
                End If

                If Not String.IsNullOrEmpty(drLoadClaiminfo("SDate").ToString()) Then
                    tmpClaiminfo.SDate = Convert.ToDateTime(drLoadClaiminfo("SDate").ToString())
                End If


                tmpClaiminfo.ServiceBy = drLoadClaiminfo("ServiceBy").ToString()
                If Not String.IsNullOrEmpty(drLoadClaiminfo("DDate").ToString()) Then
                    tmpClaiminfo.DDate = Convert.ToDateTime(drLoadClaiminfo("DDate").ToString())
                End If

                tmpClaiminfo.DeliverBy = drLoadClaiminfo("DeliverBy").ToString()
                If Not String.IsNullOrEmpty(drLoadClaiminfo("WCondition").ToString()) Then
                    tmpClaiminfo.WCondition = Convert.ToInt32(drLoadClaiminfo("WCondition").ToString())
                End If

                If Not String.IsNullOrEmpty(drLoadClaiminfo("cFlag").ToString()) Then
                    tmpClaiminfo.cFlag = Convert.ToInt32(drLoadClaiminfo("cFlag").ToString())
                End If
                If Not String.IsNullOrEmpty(drLoadClaiminfo("SvAmt").ToString()) Then
                    tmpClaiminfo.SvAmt = Convert.ToInt32(drLoadClaiminfo("SvAmt").ToString())
                End If

                If Not String.IsNullOrEmpty(drLoadClaiminfo("PrdAmt").ToString()) Then
                    tmpClaiminfo.PrdAmt = Convert.ToInt32(drLoadClaiminfo("PrdAmt").ToString())
                End If
                If Not String.IsNullOrEmpty(drLoadClaiminfo("OtherAmt").ToString()) Then
                    tmpClaiminfo.OtherAmt = Convert.ToInt32(drLoadClaiminfo("OtherAmt").ToString())
                End If
                If Not String.IsNullOrEmpty(drLoadClaiminfo("Dis").ToString()) Then
                    tmpClaiminfo.Dis = Convert.ToInt32(drLoadClaiminfo("Dis").ToString())
                End If


                If Not String.IsNullOrEmpty(drLoadClaiminfo("SRFlag").ToString()) Then
                    tmpClaiminfo.SRFlag = Convert.ToInt32(drLoadClaiminfo("SRFlag").ToString())
                End If

                tmpClaiminfo.Remk = drLoadClaiminfo("Remk").ToString()
                tmpClaiminfo.PhyCond = drLoadClaiminfo("PhyCond").ToString()
                tmpClaiminfo.Log_User = drLoadClaiminfo("Log_User").ToString()
                If Not String.IsNullOrEmpty(drLoadClaiminfo("Log_Date").ToString()) Then
                    tmpClaiminfo.Log_Date = Convert.ToDateTime(drLoadClaiminfo("Log_Date").ToString())
                End If

                tmpClaiminfo.MRNO = drLoadClaiminfo("MRNO").ToString()
                tmpClaiminfo.LastJobNO = drLoadClaiminfo("LastJobNO").ToString()
                If Not String.IsNullOrEmpty(drLoadClaiminfo("cAdvance").ToString()) Then
                    tmpClaiminfo.cAdvance = Convert.ToDouble(drLoadClaiminfo("cAdvance").ToString())
                End If

                If Not String.IsNullOrEmpty(drLoadClaiminfo("cTransportCrg").ToString()) Then
                    tmpClaiminfo.cTransportCrg = Convert.ToDouble(drLoadClaiminfo("cTransportCrg").ToString())
                End If

                tmpClaiminfo.ReturnedItems = drLoadClaiminfo("ReturnedItems").ToString()
                tmpClaiminfo.ItemRemarks = drLoadClaiminfo("ItemRemarks").ToString()
                If Not String.IsNullOrEmpty(drLoadClaiminfo("FreeOfCost").ToString()) Then
                    tmpClaiminfo.FreeOfCost = Convert.ToInt32(drLoadClaiminfo("FreeOfCost").ToString())
                End If
                If Not String.IsNullOrEmpty(drLoadClaiminfo("AdvanceAmnt").ToString()) Then
                    tmpClaiminfo.AdvanceAmnt = Convert.ToDouble(drLoadClaiminfo("AdvanceAmnt").ToString())
                End If
                If Not String.IsNullOrEmpty(drLoadClaiminfo("VatAmnt").ToString()) Then
                    tmpClaiminfo.VatAmnt = Convert.ToInt32(drLoadClaiminfo("VatAmnt").ToString())
                End If

                tmpClaiminfo.Email = drLoadClaiminfo("Email").ToString()

                Claiminfo.Add(tmpClaiminfo)




            End While



        End If




        Return Claiminfo


    End Function




    Public Function LoadClaiminfo_OpenJob(ByVal StartWithLetter As String, ByVal Branch As String, ByVal SearchType As String) As DataTable

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Dim Claiminfo As List(Of clsClaiminfo) = New List(Of clsClaiminfo)
        Dim dt As DataTable = New DataTable
        Dim strQuery As String = ""

        StartWithLetter = StartWithLetter & "%"



        If SearchType.ToLower = LCase("Job") Then
            strQuery = "Select CLaiminfo.JobCode as [Job No],claiminfo.custname as Customer,Claiminfo.Branch,Claiminfo.ServiceType as Category,
Claiminfo.Brand,Claiminfo.ModelNo,iif(Claiminfo.Cflag=-1,'Not Service',iif(Claiminfo.Cflag=1,'Service',iif(Claiminfo.Cflag=9,'Pending',iif(Claiminfo.Cflag=99,'Not Repairable',iif(Claiminfo.Cflag=100,'Customer Returned',iif(Claiminfo.Cflag=0 or Claiminfo.Cflag=2 ,'Delivered')))))) as Status,
iif(CLaiminfo.Wcondition=0,'SW',iif(CLaiminfo.Wcondition=1,'NW','SVW')) as Warranty,Claiminfo.SLNo as Serial
from Claiminfo Where Claiminfo.JobCOde Like [@jobCode] and Claiminfo.Branch=@Branch "
        ElseIf SearchType.ToLower = LCase("Customer") Then
            strQuery = "Select CLaiminfo.JobCode as [Job No],claiminfo.custname as Customer,Claiminfo.Branch,Claiminfo.ServiceType as Category,
Claiminfo.Brand,Claiminfo.ModelNo,iif(Claiminfo.Cflag=-1,'Not Service',iif(Claiminfo.Cflag=1,'Service',iif(Claiminfo.Cflag=9,'Pending',iif(Claiminfo.Cflag=99,'Not Repairable',iif(Claiminfo.Cflag=100,'Customer Returned',iif(Claiminfo.Cflag=0 or Claiminfo.Cflag=2 ,'Delivered')))))) as Status,
iif(CLaiminfo.Wcondition=0,'SW',iif(CLaiminfo.Wcondition=1,'NW','SVW')) as Warranty,Claiminfo.SLNo as Serial
from Claiminfo Where Claiminfo.CustName Like [@jobCode] and Claiminfo.Branch=@Branch "

        ElseIf SearchType.ToLower = LCase("Address") Then
            strQuery = "Select CLaiminfo.JobCode as [Job No],claiminfo.custname as Customer,Claiminfo.CustAddress1 as Address,Claiminfo.Branch,Claiminfo.ServiceType as Category,
Claiminfo.Brand,Claiminfo.ModelNo,iif(Claiminfo.Cflag=-1,'Not Service',iif(Claiminfo.Cflag=1,'Service',iif(Claiminfo.Cflag=9,'Pending',iif(Claiminfo.Cflag=99,'Not Repairable',iif(Claiminfo.Cflag=100,'Customer Returned',iif(Claiminfo.Cflag=0 or Claiminfo.Cflag=2 ,'Delivered')))))) as Status,
iif(CLaiminfo.Wcondition=0,'SW',iif(CLaiminfo.Wcondition=1,'NW','SVW')) as Warranty,Claiminfo.SLNo as Serial
from Claiminfo Where Claiminfo.CustAddress1 Like [@jobCode] and Claiminfo.Branch=@Branch "
        ElseIf SearchType.ToLower = LCase("Contact") Then
            strQuery = "Select CLaiminfo.JobCode as [Job No],claiminfo.custname as Customer,Claiminfo.CustAddress2 as Contact,Claiminfo.Branch,Claiminfo.ServiceType as Category,
Claiminfo.Brand,Claiminfo.ModelNo,iif(Claiminfo.Cflag=-1,'Not Service',iif(Claiminfo.Cflag=1,'Service',iif(Claiminfo.Cflag=9,'Pending',iif(Claiminfo.Cflag=99,'Not Repairable',iif(Claiminfo.Cflag=100,'Customer Returned',iif(Claiminfo.Cflag=0 or Claiminfo.Cflag=2 ,'Delivered')))))) as Status,
iif(CLaiminfo.Wcondition=0,'SW',iif(CLaiminfo.Wcondition=1,'NW','SVW')) as Warranty,Claiminfo.SLNo as Serial
from Claiminfo Where Claiminfo.CustAddress2 Like [@jobCode] and Claiminfo.Branch=@Branch "
        ElseIf SearchType.ToLower = LCase("Email") Then
            strQuery = "Select CLaiminfo.JobCode as [Job No],claiminfo.custname as Customer,Claiminfo.Email,Claiminfo.Branch,Claiminfo.ServiceType as Category,
Claiminfo.Brand,Claiminfo.ModelNo,iif(Claiminfo.Cflag=-1,'Not Service',iif(Claiminfo.Cflag=1,'Service',iif(Claiminfo.Cflag=9,'Pending',iif(Claiminfo.Cflag=99,'Not Repairable',iif(Claiminfo.Cflag=100,'Customer Returned',iif(Claiminfo.Cflag=0 or Claiminfo.Cflag=2 ,'Delivered')))))) as Status,
iif(CLaiminfo.Wcondition=0,'SW',iif(CLaiminfo.Wcondition=1,'NW','SVW')) as Warranty,Claiminfo.SLNo as Serial
from Claiminfo Where Claiminfo.Email Like [@jobCode] and Claiminfo.Branch=@Branch "

        End If
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcLoadClaiminfo As OleDbCommand = New OleDbCommand(strQuery, con)
            dcLoadClaiminfo.CommandType = CommandType.Text
            dcLoadClaiminfo.Parameters.Add("@jobCode", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(StartWithLetter), DBNull.Value, StartWithLetter)
            dcLoadClaiminfo.Parameters.Add("@Branch", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(Branch), DBNull.Value, Branch)

            con.Open()
            Dim drLoadClaiminfo = dcLoadClaiminfo.ExecuteReader

            If drLoadClaiminfo.HasRows = True Then



                dt.Load(drLoadClaiminfo)



            End If


        End Using


        Return dt


    End Function




    Public Function LoadJobswithLetter(ByVal StartWithLetter As String) As DataTable

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Dim dt As DataTable = New DataTable

        StartWithLetter = StartWithLetter & "%"

        Dim con As OleDbConnection = New OleDbConnection(cs)

        Dim dcLoadClaiminfo As OleDbCommand = New OleDbCommand("Select Claiminfo.JobCode,Claiminfo.Branch from Claiminfo where not claiminfo.cflag in(0,2,100,102)  and Claiminfo.JobCode Like @JobCode", con)
        dcLoadClaiminfo.CommandType = CommandType.Text
        dcLoadClaiminfo.Parameters.Add("@JobCode", OleDbType.Char, 255).Value = StartWithLetter


        con.Open()
        Dim drLoadClaiminfo = dcLoadClaiminfo.ExecuteReader

        If drLoadClaiminfo.HasRows = True Then
            dt.Load(drLoadClaiminfo)



        End If




        Return dt


    End Function





    Public Function LoadClaiminfo_GetJobList(ByVal SearchId, ByVal SearchBranch, ByVal Status) As IEnumerable(Of clsClaiminfo)

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Dim Claiminfo As List(Of clsClaiminfo) = New List(Of clsClaiminfo)
        SearchId = SearchId & "%"


        Dim con As OleDbConnection = New OleDbConnection(cs)

        Dim dcLoadClaiminfo As OleDbCommand = New OleDbCommand("Select CLaiminfo.JobCode as Job No,Claiminfo.Branch,Claiminfo.ServiceType as Category,Claiminfo.Brand,Claiminfo.ModelNo,Claiminfo.SLNo as Serial,iif(Claiminfo.Cflag=-1,'Not Service',iif(Claiminfo.Cflag=1,'Service',iif(Claiminfo.Cflag=9,'Pending',iif(Claiminfo.Cflag=99,'Not Repairable',iif(Claiminfo.Cflag=100,'Customer Returned',iif(Claiminfo.Cflag=0 or Claiminfo.Cflag=2 ,'Delivered')))))) as Status,CLaiminfo.Wcodition from Claiminfo Where Claiminfo.JobCOde Like [@jobCode] and Claiminfo.Branch=@Branch and claiminfo.Cflag Not in (@cflag) ", con)
        dcLoadClaiminfo.CommandType = CommandType.Text
        dcLoadClaiminfo.Parameters.Add("@jobCode", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(SearchId), DBNull.Value, SearchId)
        dcLoadClaiminfo.Parameters.Add("@Branch", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(SearchBranch), DBNull.Value, SearchBranch)
        dcLoadClaiminfo.Parameters.Add("@cflag", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(Status), DBNull.Value, Status)


        con.Open()
        Dim drLoadClaiminfo = dcLoadClaiminfo.ExecuteReader

        If drLoadClaiminfo.HasRows = True Then

            While drLoadClaiminfo.Read
                Dim tmpClaiminfo As clsClaiminfo = New clsClaiminfo

                tmpClaiminfo.JobID = Convert.ToInt32(drLoadClaiminfo("JobID").ToString())
                tmpClaiminfo.Jobcode = drLoadClaiminfo("Jobcode").ToString()
                tmpClaiminfo.Branch = drLoadClaiminfo("Branch").ToString()
                tmpClaiminfo.CustName = drLoadClaiminfo("CustName").ToString()
                tmpClaiminfo.CustAddress1 = drLoadClaiminfo("CustAddress1").ToString()
                tmpClaiminfo.CustAddress2 = drLoadClaiminfo("CustAddress2").ToString()
                tmpClaiminfo.Brand = drLoadClaiminfo("Brand").ToString()
                tmpClaiminfo.ModelNo = drLoadClaiminfo("ModelNo").ToString()
                tmpClaiminfo.MobileNo = drLoadClaiminfo("MobileNo").ToString()
                tmpClaiminfo.ESN = drLoadClaiminfo("ESN").ToString()
                tmpClaiminfo.SLNo = drLoadClaiminfo("SLNo").ToString()

                If Not String.IsNullOrEmpty(drLoadClaiminfo("ReceptDate").ToString()) Then
                    tmpClaiminfo.ReceptDate = Convert.ToDateTime(drLoadClaiminfo("ReceptDate").ToString())
                End If

                If Not String.IsNullOrEmpty(drLoadClaiminfo("AppDelDate").ToString()) Then
                    tmpClaiminfo.AppDelDate = Convert.ToDateTime(drLoadClaiminfo("AppDelDate").ToString())
                End If


                tmpClaiminfo.ServiceType = drLoadClaiminfo("ServiceType").ToString()
                If Not String.IsNullOrEmpty(drLoadClaiminfo("PDate").ToString()) Then
                    tmpClaiminfo.PDate = Convert.ToDateTime(drLoadClaiminfo("PDate").ToString())
                End If

                tmpClaiminfo.ReceptBy = drLoadClaiminfo("ReceptBy").ToString()
                tmpClaiminfo.IssueTo = drLoadClaiminfo("IssueTo").ToString()

                If Not String.IsNullOrEmpty(drLoadClaiminfo("IsssueDate").ToString()) Then
                    tmpClaiminfo.IsssueDate = Convert.ToDateTime(drLoadClaiminfo("IsssueDate").ToString())
                End If

                If Not String.IsNullOrEmpty(drLoadClaiminfo("SDate").ToString()) Then
                    tmpClaiminfo.SDate = Convert.ToDateTime(drLoadClaiminfo("SDate").ToString())
                End If


                tmpClaiminfo.ServiceBy = drLoadClaiminfo("ServiceBy").ToString()
                If Not String.IsNullOrEmpty(drLoadClaiminfo("DDate").ToString()) Then
                    tmpClaiminfo.DDate = Convert.ToDateTime(drLoadClaiminfo("DDate").ToString())
                End If


                tmpClaiminfo.DeliverBy = drLoadClaiminfo("DeliverBy").ToString()
                If Not String.IsNullOrEmpty(drLoadClaiminfo("WCondition").ToString()) Then
                    tmpClaiminfo.WCondition = Convert.ToInt32(drLoadClaiminfo("WCondition").ToString())
                End If

                If Not String.IsNullOrEmpty(drLoadClaiminfo("cFlag").ToString()) Then
                    tmpClaiminfo.cFlag = Convert.ToInt32(drLoadClaiminfo("cFlag").ToString())
                End If


                If Not String.IsNullOrEmpty(drLoadClaiminfo("SvAmt").ToString()) Then
                    tmpClaiminfo.SvAmt = Convert.ToInt32(drLoadClaiminfo("SvAmt").ToString())
                End If

                If Not String.IsNullOrEmpty(drLoadClaiminfo("PrdAmt").ToString()) Then
                    tmpClaiminfo.PrdAmt = Convert.ToInt32(drLoadClaiminfo("PrdAmt").ToString())
                End If

                If Not String.IsNullOrEmpty(drLoadClaiminfo("OtherAmt").ToString()) Then
                    tmpClaiminfo.OtherAmt = Convert.ToInt32(drLoadClaiminfo("OtherAmt").ToString())
                End If


                If Not String.IsNullOrEmpty(drLoadClaiminfo("Dis").ToString()) Then
                    tmpClaiminfo.Dis = Convert.ToInt32(drLoadClaiminfo("Dis").ToString())
                End If


                If Not String.IsNullOrEmpty(drLoadClaiminfo("SRFlag").ToString()) Then
                    tmpClaiminfo.SRFlag = Convert.ToInt32(drLoadClaiminfo("SRFlag").ToString())
                End If

                tmpClaiminfo.Remk = drLoadClaiminfo("Remk").ToString()
                tmpClaiminfo.PhyCond = drLoadClaiminfo("PhyCond").ToString()
                tmpClaiminfo.Log_User = drLoadClaiminfo("Log_User").ToString()
                If Not String.IsNullOrEmpty(drLoadClaiminfo("Log_Date").ToString()) Then
                    tmpClaiminfo.Log_Date = Convert.ToDateTime(drLoadClaiminfo("Log_Date").ToString())
                End If

                tmpClaiminfo.MRNO = drLoadClaiminfo("MRNO").ToString()
                tmpClaiminfo.LastJobNO = drLoadClaiminfo("LastJobNO").ToString()
                If Not String.IsNullOrEmpty(drLoadClaiminfo("cAdvance").ToString()) Then
                    tmpClaiminfo.cAdvance = Convert.ToDouble(drLoadClaiminfo("cAdvance").ToString())
                End If

                If Not String.IsNullOrEmpty(drLoadClaiminfo("cTransportCrg").ToString()) Then
                    tmpClaiminfo.cTransportCrg = Convert.ToDouble(drLoadClaiminfo("cTransportCrg").ToString())
                End If

                tmpClaiminfo.ReturnedItems = drLoadClaiminfo("ReturnedItems").ToString()
                tmpClaiminfo.ItemRemarks = drLoadClaiminfo("ItemRemarks").ToString()
                If Not String.IsNullOrEmpty(drLoadClaiminfo("FreeOfCost").ToString()) Then
                    tmpClaiminfo.FreeOfCost = Convert.ToInt32(drLoadClaiminfo("FreeOfCost").ToString())
                End If

                If Not String.IsNullOrEmpty(drLoadClaiminfo("AdvanceAmnt").ToString()) Then
                    tmpClaiminfo.AdvanceAmnt = Convert.ToDouble(drLoadClaiminfo("AdvanceAmnt").ToString())
                End If

                If Not String.IsNullOrEmpty(drLoadClaiminfo("VatAmnt").ToString()) Then
                    tmpClaiminfo.VatAmnt = Convert.ToInt32(drLoadClaiminfo("VatAmnt").ToString())
                End If

                tmpClaiminfo.Email = drLoadClaiminfo("Email").ToString()

                Claiminfo.Add(tmpClaiminfo)




            End While


        End If




        Return Claiminfo


    End Function


    Public Function LoadClaiminfo_GetJobTable(ByVal SearchId As String, ByVal SearchBranch As String, ByVal SearchType As String) As DataTable

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Dim dt As DataTable = New DataTable
        SearchId = SearchId & "%"

        Dim strSqlQuery As String = ""

        If SearchType.ToLower = LCase("Job") Then
            strSqlQuery = "Select CLaiminfo.JobCode as [Job No],claiminfo.custname as Customer,Claiminfo.Branch,Claiminfo.ServiceType as Category,Claiminfo.Brand,
iif(Claiminfo.Cflag=-1,'Not Service',iif(Claiminfo.Cflag=1,'Service',iif(Claiminfo.Cflag=9,'Pending',iif(Claiminfo.Cflag=99,'Not Repairable',
iif(Claiminfo.Cflag=100,'Customer Returned',iif(Claiminfo.Cflag=0 or Claiminfo.Cflag=2 ,'Delivered')))))) as Status,iif(CLaiminfo.Wcondition=0,'SW',
iif(CLaiminfo.Wcondition=1,'NW','SVW')) as Warranty, Claiminfo.ModelNo,Claiminfo.SLNo as Serial from Claiminfo 
Where Claiminfo.JobCOde Like [@jobCode] and Claiminfo.Branch=@Branch and claiminfo.Cflag Not in (-1,9)" '" & Status & ")"

        ElseIf SearchType.ToLower = LCase("Customer") Then
            strSqlQuery = "Select CLaiminfo.JobCode as [Job No],claiminfo.custname as Customer,Claiminfo.Branch,Claiminfo.ServiceType as Category,Claiminfo.Brand,
iif(Claiminfo.Cflag=-1,'Not Service',iif(Claiminfo.Cflag=1,'Service',iif(Claiminfo.Cflag=9,'Pending',iif(Claiminfo.Cflag=99,'Not Repairable',
iif(Claiminfo.Cflag=100,'Customer Returned',iif(Claiminfo.Cflag=0 or Claiminfo.Cflag=2 ,'Delivered')))))) as Status,iif(CLaiminfo.Wcondition=0,'SW',
iif(CLaiminfo.Wcondition=1,'NW','SVW')) as Warranty, Claiminfo.ModelNo,Claiminfo.SLNo as Serial from Claiminfo 
Where Claiminfo.CustName Like [@jobCode] and Claiminfo.Branch=@Branch and claiminfo.Cflag Not in (-1,9)"

        ElseIf SearchType.ToLower = LCase("Address") Then
            strSqlQuery = "Select CLaiminfo.JobCode as [Job No],claiminfo.custname as Customer,Claiminfo.CustAddress1 as Address,Claiminfo.Branch,Claiminfo.ServiceType as Category,Claiminfo.Brand,
iif(Claiminfo.Cflag=-1,'Not Service',iif(Claiminfo.Cflag=1,'Service',iif(Claiminfo.Cflag=9,'Pending',iif(Claiminfo.Cflag=99,'Not Repairable',
iif(Claiminfo.Cflag=100,'Customer Returned',iif(Claiminfo.Cflag=0 or Claiminfo.Cflag=2 ,'Delivered')))))) as Status,iif(CLaiminfo.Wcondition=0,'SW',
iif(CLaiminfo.Wcondition=1,'NW','SVW')) as Warranty, Claiminfo.ModelNo,Claiminfo.SLNo as Serial from Claiminfo 
Where Claiminfo.CustAddress1 Like [@jobCode] and Claiminfo.Branch=@Branch and claiminfo.Cflag Not in (-1,9)"

        ElseIf SearchType.ToLower = LCase("Contact") Then
            strSqlQuery = "Select CLaiminfo.JobCode as [Job No],claiminfo.custname as Customer,Claiminfo.CustAddress2 as Contact,Claiminfo.Branch,Claiminfo.ServiceType as Category,Claiminfo.Brand,
iif(Claiminfo.Cflag=-1,'Not Service',iif(Claiminfo.Cflag=1,'Service',iif(Claiminfo.Cflag=9,'Pending',iif(Claiminfo.Cflag=99,'Not Repairable',
iif(Claiminfo.Cflag=100,'Customer Returned',iif(Claiminfo.Cflag=0 or Claiminfo.Cflag=2 ,'Delivered')))))) as Status,iif(CLaiminfo.Wcondition=0,'SW',
iif(CLaiminfo.Wcondition=1,'NW','SVW')) as Warranty, Claiminfo.ModelNo,Claiminfo.SLNo as Serial from Claiminfo 
Where Claiminfo.CustAddress2 Like [@jobCode] and Claiminfo.Branch=@Branch and claiminfo.Cflag Not in (-1,9)"

        ElseIf SearchType.ToLower = LCase("Email") Then
            strSqlQuery = "Select CLaiminfo.JobCode as [Job No],claiminfo.custname as Customer,Claiminfo.Email,Claiminfo.Branch,Claiminfo.ServiceType as Category,Claiminfo.Brand,
iif(Claiminfo.Cflag=-1,'Not Service',iif(Claiminfo.Cflag=1,'Service',iif(Claiminfo.Cflag=9,'Pending',iif(Claiminfo.Cflag=99,'Not Repairable',
iif(Claiminfo.Cflag=100,'Customer Returned',iif(Claiminfo.Cflag=0 or Claiminfo.Cflag=2 ,'Delivered')))))) as Status,iif(CLaiminfo.Wcondition=0,'SW',
iif(CLaiminfo.Wcondition=1,'NW','SVW')) as Warranty, Claiminfo.ModelNo,Claiminfo.SLNo as Serial from Claiminfo 
Where Claiminfo.Email Like [@jobCode] and Claiminfo.Branch=@Branch and claiminfo.Cflag Not in (-1,9)"
        End If

        Dim con As OleDbConnection = New OleDbConnection(cs)

        Dim dcLoadClaiminfo As OleDbCommand = New OleDbCommand(strSqlQuery, con)

        dcLoadClaiminfo.CommandType = CommandType.Text
        dcLoadClaiminfo.Parameters.Add("@jobCode", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(SearchId), DBNull.Value, SearchId)
        dcLoadClaiminfo.Parameters.Add("@Branch", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(SearchBranch), DBNull.Value, SearchBranch)
        con.Open()
        Dim drLoadClaiminfo = dcLoadClaiminfo.ExecuteReader
        If drLoadClaiminfo.HasRows = True Then
            dt.Load(drLoadClaiminfo)
        End If
        Return dt
    End Function




    Public Function LoadClaiminfo_byJobCode(ByVal strTempJobCode As String) As clsClaiminfo

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

        Dim tmpClaiminfo As clsClaiminfo = New clsClaiminfo


        Dim con As OleDbConnection = New OleDbConnection(cs)

        Dim dcLoadClaiminfo As OleDbCommand = New OleDbCommand("qryGet_Claiminfo_byJobCode", con)
        dcLoadClaiminfo.CommandType = CommandType.StoredProcedure
        dcLoadClaiminfo.Parameters.Add("paramJobCode", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(strTempJobCode), DBNull.Value, strTempJobCode)



        con.Open()
        Dim drLoadClaiminfo = dcLoadClaiminfo.ExecuteReader

        If drLoadClaiminfo.HasRows = True Then

            While drLoadClaiminfo.Read


                tmpClaiminfo.JobID = Convert.ToInt32(drLoadClaiminfo("JobID").ToString())
                tmpClaiminfo.Jobcode = drLoadClaiminfo("Jobcode").ToString()
                tmpClaiminfo.Branch = drLoadClaiminfo("Branch").ToString()
                tmpClaiminfo.CustName = drLoadClaiminfo("CustName").ToString()
                tmpClaiminfo.CustAddress1 = drLoadClaiminfo("CustAddress1").ToString()
                tmpClaiminfo.CustAddress2 = drLoadClaiminfo("CustAddress2").ToString()
                tmpClaiminfo.Brand = drLoadClaiminfo("Brand").ToString()
                tmpClaiminfo.ModelNo = drLoadClaiminfo("ModelNo").ToString()
                tmpClaiminfo.MobileNo = drLoadClaiminfo("MobileNo").ToString()
                tmpClaiminfo.ESN = drLoadClaiminfo("ESN").ToString()
                tmpClaiminfo.SLNo = drLoadClaiminfo("SLNo").ToString()

                If Not String.IsNullOrEmpty(drLoadClaiminfo("ReceptDate").ToString()) Then
                    tmpClaiminfo.ReceptDate = Convert.ToDateTime(drLoadClaiminfo("ReceptDate").ToString())
                End If

                If Not String.IsNullOrEmpty(drLoadClaiminfo("AppDelDate").ToString()) Then
                    tmpClaiminfo.AppDelDate = Convert.ToDateTime(drLoadClaiminfo("AppDelDate").ToString())
                End If


                tmpClaiminfo.ServiceType = drLoadClaiminfo("ServiceType").ToString()
                If Not String.IsNullOrEmpty(drLoadClaiminfo("PDate").ToString()) Then
                    tmpClaiminfo.PDate = Convert.ToDateTime(drLoadClaiminfo("PDate").ToString())
                End If

                tmpClaiminfo.ReceptBy = drLoadClaiminfo("ReceptBy").ToString()
                tmpClaiminfo.IssueTo = drLoadClaiminfo("IssueTo").ToString()

                If Not String.IsNullOrEmpty(drLoadClaiminfo("IsssueDate").ToString()) Then
                    tmpClaiminfo.IsssueDate = Convert.ToDateTime(drLoadClaiminfo("IsssueDate").ToString())
                End If

                If Not String.IsNullOrEmpty(drLoadClaiminfo("SDate").ToString()) Then
                    tmpClaiminfo.SDate = Convert.ToDateTime(drLoadClaiminfo("SDate").ToString())
                End If


                tmpClaiminfo.ServiceBy = drLoadClaiminfo("ServiceBy").ToString()
                If Not String.IsNullOrEmpty(drLoadClaiminfo("DDate").ToString()) Then
                    tmpClaiminfo.DDate = Convert.ToDateTime(drLoadClaiminfo("DDate").ToString())
                End If

                tmpClaiminfo.DeliverBy = drLoadClaiminfo("DeliverBy").ToString()

                If Not String.IsNullOrEmpty(drLoadClaiminfo("WCondition").ToString()) Then
                    tmpClaiminfo.WCondition = Convert.ToInt32(drLoadClaiminfo("WCondition").ToString())
                End If
                If Not String.IsNullOrEmpty(drLoadClaiminfo("cFlag").ToString()) Then
                    tmpClaiminfo.cFlag = Convert.ToInt32(drLoadClaiminfo("cFlag").ToString())
                End If
                If Not String.IsNullOrEmpty(drLoadClaiminfo("SvAmt").ToString()) Then
                    tmpClaiminfo.SvAmt = Convert.ToInt32(drLoadClaiminfo("SvAmt").ToString())
                End If

                If Not String.IsNullOrEmpty(drLoadClaiminfo("PrdAmt").ToString()) Then
                    tmpClaiminfo.PrdAmt = Convert.ToInt32(drLoadClaiminfo("PrdAmt").ToString())
                End If

                If Not String.IsNullOrEmpty(drLoadClaiminfo("OtherAmt").ToString()) Then
                    tmpClaiminfo.OtherAmt = Convert.ToInt32(drLoadClaiminfo("OtherAmt").ToString())
                End If

                If Not String.IsNullOrEmpty(drLoadClaiminfo("Dis").ToString()) Then
                    tmpClaiminfo.Dis = Convert.ToInt32(drLoadClaiminfo("Dis").ToString())
                End If


                If Not String.IsNullOrEmpty(drLoadClaiminfo("SRFlag").ToString()) Then
                    tmpClaiminfo.SRFlag = Convert.ToInt32(drLoadClaiminfo("SRFlag").ToString())
                End If

                tmpClaiminfo.Remk = drLoadClaiminfo("Remk").ToString()
                tmpClaiminfo.PhyCond = drLoadClaiminfo("PhyCond").ToString()
                tmpClaiminfo.Log_User = drLoadClaiminfo("Log_User").ToString()
                If Not String.IsNullOrEmpty(drLoadClaiminfo("Log_Date").ToString()) Then
                    tmpClaiminfo.Log_Date = Convert.ToDateTime(drLoadClaiminfo("Log_Date").ToString())
                End If

                tmpClaiminfo.MRNO = drLoadClaiminfo("MRNO").ToString()
                tmpClaiminfo.LastJobNO = drLoadClaiminfo("LastJobNO").ToString()
                If Not String.IsNullOrEmpty(drLoadClaiminfo("cAdvance").ToString()) Then
                    tmpClaiminfo.cAdvance = Convert.ToDouble(drLoadClaiminfo("cAdvance").ToString())
                End If

                If Not String.IsNullOrEmpty(drLoadClaiminfo("cTransportCrg").ToString()) Then
                    tmpClaiminfo.cTransportCrg = Convert.ToDouble(drLoadClaiminfo("cTransportCrg").ToString())
                End If

                tmpClaiminfo.ReturnedItems = drLoadClaiminfo("ReturnedItems").ToString()
                tmpClaiminfo.ItemRemarks = drLoadClaiminfo("ItemRemarks").ToString()

                If Not String.IsNullOrEmpty(drLoadClaiminfo("FreeOfCost").ToString()) Then
                    tmpClaiminfo.FreeOfCost = Convert.ToInt32(drLoadClaiminfo("FreeOfCost").ToString())
                End If


                If Not String.IsNullOrEmpty(drLoadClaiminfo("AdvanceAmnt").ToString()) Then
                    tmpClaiminfo.AdvanceAmnt = Convert.ToDouble(drLoadClaiminfo("AdvanceAmnt").ToString())
                End If


                If Not String.IsNullOrEmpty(drLoadClaiminfo("VatAmnt").ToString()) Then
                    tmpClaiminfo.VatAmnt = Convert.ToInt32(drLoadClaiminfo("VatAmnt").ToString())
                End If

                tmpClaiminfo.Email = drLoadClaiminfo("Email").ToString()






            End While


        End If




        Return tmpClaiminfo


    End Function


    Public Sub CreateNewJob(ByVal tmpcliminfo As clsClaiminfo)

        Dim cs = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString


        Dim strUpdateCriteria As String = String.Empty

        Dim strField As String = String.Empty











        strUpdateCriteria = strUpdateCriteria + strField




        Using con As OleDbConnection = New OleDbConnection(cs)






            Dim dcUpdateClaiminfo As OleDbCommand = New OleDbCommand("qryInsertClaiminfo", con)
            dcUpdateClaiminfo.CommandType = CommandType.StoredProcedure



            ' ____________________________________________________________________ Parameter Section ______________________________________________________________________________________

            dcUpdateClaiminfo.Parameters.Add("parJobCode", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tmpcliminfo.Jobcode), DBNull.Value, tmpcliminfo.Jobcode)



            dcUpdateClaiminfo.Parameters.Add("parbranch", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tmpcliminfo.Branch), DBNull.Value, tmpcliminfo.Branch)

            dcUpdateClaiminfo.Parameters.Add("parCustName", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tmpcliminfo.CustName), DBNull.Value, tmpcliminfo.CustName)

            dcUpdateClaiminfo.Parameters.Add("parCustAddress1", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tmpcliminfo.CustAddress1), DBNull.Value, tmpcliminfo.CustAddress1)




            dcUpdateClaiminfo.Parameters.Add("parCustAddress2", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tmpcliminfo.CustAddress2), DBNull.Value, tmpcliminfo.CustAddress2)

            dcUpdateClaiminfo.Parameters.Add("parBrand", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tmpcliminfo.Brand), DBNull.Value, tmpcliminfo.Brand)

            dcUpdateClaiminfo.Parameters.Add("parModelNo", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tmpcliminfo.ModelNo), DBNull.Value, tmpcliminfo.ModelNo)
            dcUpdateClaiminfo.Parameters.Add("parMobileNo", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tmpcliminfo.MobileNo), DBNull.Value, tmpcliminfo.MobileNo)
            dcUpdateClaiminfo.Parameters.Add("parESN", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tmpcliminfo.ESN), DBNull.Value, tmpcliminfo.ESN)
            dcUpdateClaiminfo.Parameters.Add("parSLNo", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tmpcliminfo.SLNo), DBNull.Value, tmpcliminfo.SLNo)
            dcUpdateClaiminfo.Parameters.Add("parReceptDate", OleDbType.Date).Value = If(String.IsNullOrEmpty(tmpcliminfo.ReceptDate), DBNull.Value, tmpcliminfo.ReceptDate)
            dcUpdateClaiminfo.Parameters.Add("parAppDelDate", OleDbType.Date).Value = If(String.IsNullOrEmpty(tmpcliminfo.AppDelDate), DBNull.Value, tmpcliminfo.AppDelDate)
            dcUpdateClaiminfo.Parameters.Add("parServiceType", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tmpcliminfo.ServiceType), DBNull.Value, tmpcliminfo.ServiceType)
            dcUpdateClaiminfo.Parameters.Add("parPDate", OleDbType.Date).Value = If(String.IsNullOrEmpty(tmpcliminfo.PDate), DBNull.Value, tmpcliminfo.PDate)
            dcUpdateClaiminfo.Parameters.Add("parReceptBy", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tmpcliminfo.ReceptBy), DBNull.Value, tmpcliminfo.ReceptBy)
            dcUpdateClaiminfo.Parameters.Add("parIssueTo", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tmpcliminfo.IssueTo), DBNull.Value, tmpcliminfo.IssueTo)
            dcUpdateClaiminfo.Parameters.Add("parIsssueDate", OleDbType.Date).Value = If(String.IsNullOrEmpty(tmpcliminfo.IsssueDate), DBNull.Value, tmpcliminfo.IsssueDate)
            dcUpdateClaiminfo.Parameters.Add("parSDate", OleDbType.Date).Value = If(String.IsNullOrEmpty(tmpcliminfo.SDate), DBNull.Value, tmpcliminfo.SDate)
            dcUpdateClaiminfo.Parameters.Add("parServiceBy", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tmpcliminfo.ServiceBy), DBNull.Value, tmpcliminfo.ServiceBy)
            dcUpdateClaiminfo.Parameters.Add("parDDate", OleDbType.Date).Value = If(String.IsNullOrEmpty(tmpcliminfo.DDate), DBNull.Value, tmpcliminfo.DDate)
            dcUpdateClaiminfo.Parameters.Add("parDeliverBy", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tmpcliminfo.DeliverBy), DBNull.Value, tmpcliminfo.DeliverBy)
            dcUpdateClaiminfo.Parameters.Add("parWCondition", OleDbType.BigInt).Value = If(String.IsNullOrEmpty(tmpcliminfo.WCondition), DBNull.Value, tmpcliminfo.WCondition)
            dcUpdateClaiminfo.Parameters.Add("parcFlag", OleDbType.BigInt).Value = If(String.IsNullOrEmpty(tmpcliminfo.cFlag), DBNull.Value, tmpcliminfo.cFlag)
            dcUpdateClaiminfo.Parameters.Add("parSvAmt", OleDbType.Double).Value = If(String.IsNullOrEmpty(tmpcliminfo.SvAmt), DBNull.Value, tmpcliminfo.SvAmt)
            dcUpdateClaiminfo.Parameters.Add("parPrdAmt", OleDbType.Double).Value = If(String.IsNullOrEmpty(tmpcliminfo.PrdAmt), DBNull.Value, tmpcliminfo.PrdAmt)
            dcUpdateClaiminfo.Parameters.Add("parOtherAmt", OleDbType.Double).Value = If(String.IsNullOrEmpty(tmpcliminfo.OtherAmt), DBNull.Value, tmpcliminfo.OtherAmt)
            dcUpdateClaiminfo.Parameters.Add("parDis", OleDbType.Double).Value = If(String.IsNullOrEmpty(tmpcliminfo.Dis), DBNull.Value, tmpcliminfo.Dis)
            dcUpdateClaiminfo.Parameters.Add("parSRFlag", OleDbType.BigInt).Value = If(String.IsNullOrEmpty(tmpcliminfo.SRFlag), DBNull.Value, tmpcliminfo.SRFlag)
            dcUpdateClaiminfo.Parameters.Add("parRemk", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tmpcliminfo.Remk), DBNull.Value, tmpcliminfo.Remk)
            dcUpdateClaiminfo.Parameters.Add("parPhyCond", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tmpcliminfo.PhyCond), DBNull.Value, tmpcliminfo.PhyCond)
            dcUpdateClaiminfo.Parameters.Add("parLog_User", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tmpcliminfo.Log_User), DBNull.Value, tmpcliminfo.Log_User)
            dcUpdateClaiminfo.Parameters.Add("parLog_Date", OleDbType.Date).Value = If(String.IsNullOrEmpty(tmpcliminfo.Log_Date), DBNull.Value, tmpcliminfo.Log_Date)
            dcUpdateClaiminfo.Parameters.Add("parMRNO", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tmpcliminfo.MRNO), DBNull.Value, tmpcliminfo.MRNO)
            dcUpdateClaiminfo.Parameters.Add("parLastJobNO", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tmpcliminfo.LastJobNO), DBNull.Value, tmpcliminfo.LastJobNO)
            dcUpdateClaiminfo.Parameters.Add("parcAdvance", OleDbType.Double).Value = If(String.IsNullOrEmpty(tmpcliminfo.cAdvance), DBNull.Value, tmpcliminfo.cAdvance)
            dcUpdateClaiminfo.Parameters.Add("parcTransportCrg", OleDbType.Double).Value = If(String.IsNullOrEmpty(tmpcliminfo.cTransportCrg), DBNull.Value, tmpcliminfo.cTransportCrg)
            dcUpdateClaiminfo.Parameters.Add("parReturnedItems", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tmpcliminfo.ReturnedItems), DBNull.Value, tmpcliminfo.ReturnedItems)
            dcUpdateClaiminfo.Parameters.Add("parItemRemarks", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tmpcliminfo.ItemRemarks), DBNull.Value, tmpcliminfo.ItemRemarks)
            dcUpdateClaiminfo.Parameters.Add("parFreeOfCost", OleDbType.Double).Value = If(String.IsNullOrEmpty(tmpcliminfo.FreeOfCost), DBNull.Value, tmpcliminfo.FreeOfCost)
            dcUpdateClaiminfo.Parameters.Add("parAdvanceAmnt", OleDbType.Double).Value = If(String.IsNullOrEmpty(tmpcliminfo.AdvanceAmnt), DBNull.Value, tmpcliminfo.AdvanceAmnt)
            dcUpdateClaiminfo.Parameters.Add("parVatAmnt", OleDbType.Double).Value = If(String.IsNullOrEmpty(tmpcliminfo.VatAmnt), DBNull.Value, tmpcliminfo.VatAmnt)
            dcUpdateClaiminfo.Parameters.Add("parEmail", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tmpcliminfo.Email), DBNull.Value, tmpcliminfo.Email)



            con.Open()
            dcUpdateClaiminfo.ExecuteNonQuery()






        End Using





    End Sub



    Public Sub updateclaiminfo(ByVal tmpcliminfo As clsClaiminfo, ByVal WhereClause As String)

        Dim cs = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString


        Dim strUpdateCriteria As String = String.Empty

        Dim strField As String = String.Empty

        strUpdateCriteria = strUpdateCriteria + strField

        Using con As OleDbConnection = New OleDbConnection(cs)

            Dim dcUpdateClaiminfo As OleDbCommand = New OleDbCommand("qryUpdateClaiminfo", con)
            dcUpdateClaiminfo.CommandType = CommandType.StoredProcedure



            ' ____________________________________________________________________ Parameter Section ______________________________________________________________________________________

            dcUpdateClaiminfo.Parameters.Add("parJobCode", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tmpcliminfo.Jobcode), DBNull.Value, tmpcliminfo.Jobcode)



            dcUpdateClaiminfo.Parameters.Add("parbranch", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tmpcliminfo.Branch), DBNull.Value, tmpcliminfo.Branch)

            dcUpdateClaiminfo.Parameters.Add("parCustName", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tmpcliminfo.CustName), DBNull.Value, tmpcliminfo.CustName)

            dcUpdateClaiminfo.Parameters.Add("parCustAddress1", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tmpcliminfo.CustAddress1), DBNull.Value, tmpcliminfo.CustAddress1)




            dcUpdateClaiminfo.Parameters.Add("parCustAddress2", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tmpcliminfo.CustAddress2), DBNull.Value, tmpcliminfo.CustAddress2)

            dcUpdateClaiminfo.Parameters.Add("parBrand", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tmpcliminfo.Brand), DBNull.Value, tmpcliminfo.Brand)

            dcUpdateClaiminfo.Parameters.Add("parModelNo", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tmpcliminfo.ModelNo), DBNull.Value, tmpcliminfo.ModelNo)
            dcUpdateClaiminfo.Parameters.Add("parMobileNo", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tmpcliminfo.MobileNo), DBNull.Value, tmpcliminfo.MobileNo)
            dcUpdateClaiminfo.Parameters.Add("parESN", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tmpcliminfo.ESN), DBNull.Value, tmpcliminfo.ESN)
            dcUpdateClaiminfo.Parameters.Add("parSLNo", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tmpcliminfo.SLNo), DBNull.Value, tmpcliminfo.SLNo)
            dcUpdateClaiminfo.Parameters.Add("parReceptDate", OleDbType.Date).Value = If(String.IsNullOrEmpty(tmpcliminfo.ReceptDate), DBNull.Value, tmpcliminfo.ReceptDate)
            dcUpdateClaiminfo.Parameters.Add("parAppDelDate", OleDbType.Date).Value = If(String.IsNullOrEmpty(tmpcliminfo.AppDelDate), DBNull.Value, tmpcliminfo.AppDelDate)
            dcUpdateClaiminfo.Parameters.Add("parServiceType", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tmpcliminfo.ServiceType), DBNull.Value, tmpcliminfo.ServiceType)
            dcUpdateClaiminfo.Parameters.Add("parPDate", OleDbType.Date).Value = If(String.IsNullOrEmpty(tmpcliminfo.PDate), DBNull.Value, tmpcliminfo.PDate)
            dcUpdateClaiminfo.Parameters.Add("parReceptBy", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tmpcliminfo.ReceptBy), DBNull.Value, tmpcliminfo.ReceptBy)
            dcUpdateClaiminfo.Parameters.Add("parIssueTo", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tmpcliminfo.IssueTo), DBNull.Value, tmpcliminfo.IssueTo)
            dcUpdateClaiminfo.Parameters.Add("parIsssueDate", OleDbType.Date).Value = If(String.IsNullOrEmpty(tmpcliminfo.IsssueDate), DBNull.Value, tmpcliminfo.IsssueDate)
            dcUpdateClaiminfo.Parameters.Add("parSDate", OleDbType.Date).Value = If(String.IsNullOrEmpty(tmpcliminfo.SDate), DBNull.Value, tmpcliminfo.SDate)
            dcUpdateClaiminfo.Parameters.Add("parServiceBy", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tmpcliminfo.ServiceBy), DBNull.Value, tmpcliminfo.ServiceBy)
            dcUpdateClaiminfo.Parameters.Add("parDDate", OleDbType.Date).Value = If(String.IsNullOrEmpty(tmpcliminfo.DDate), DBNull.Value, tmpcliminfo.DDate)
            dcUpdateClaiminfo.Parameters.Add("parDeliverBy", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tmpcliminfo.DeliverBy), DBNull.Value, tmpcliminfo.DeliverBy)
            dcUpdateClaiminfo.Parameters.Add("parWCondition", OleDbType.BigInt).Value = If(String.IsNullOrEmpty(tmpcliminfo.WCondition), DBNull.Value, tmpcliminfo.WCondition)
            dcUpdateClaiminfo.Parameters.Add("parcFlag", OleDbType.BigInt).Value = If(String.IsNullOrEmpty(tmpcliminfo.cFlag), DBNull.Value, tmpcliminfo.cFlag)
            dcUpdateClaiminfo.Parameters.Add("parSvAmt", OleDbType.Double).Value = If(String.IsNullOrEmpty(tmpcliminfo.SvAmt), DBNull.Value, tmpcliminfo.SvAmt)
            dcUpdateClaiminfo.Parameters.Add("parPrdAmt", OleDbType.Double).Value = If(String.IsNullOrEmpty(tmpcliminfo.PrdAmt), DBNull.Value, tmpcliminfo.PrdAmt)
            dcUpdateClaiminfo.Parameters.Add("parOtherAmt", OleDbType.Double).Value = If(String.IsNullOrEmpty(tmpcliminfo.OtherAmt), DBNull.Value, tmpcliminfo.OtherAmt)
            dcUpdateClaiminfo.Parameters.Add("parDis", OleDbType.Double).Value = If(String.IsNullOrEmpty(tmpcliminfo.Dis), DBNull.Value, tmpcliminfo.Dis)
            dcUpdateClaiminfo.Parameters.Add("parSRFlag", OleDbType.BigInt).Value = If(String.IsNullOrEmpty(tmpcliminfo.SRFlag), DBNull.Value, tmpcliminfo.SRFlag)
            dcUpdateClaiminfo.Parameters.Add("parRemk", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tmpcliminfo.Remk), DBNull.Value, tmpcliminfo.Remk)
            dcUpdateClaiminfo.Parameters.Add("parPhyCond", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tmpcliminfo.PhyCond), DBNull.Value, tmpcliminfo.PhyCond)
            dcUpdateClaiminfo.Parameters.Add("parLog_User", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tmpcliminfo.Log_User), DBNull.Value, tmpcliminfo.Log_User)
            dcUpdateClaiminfo.Parameters.Add("parLog_Date", OleDbType.Date).Value = If(String.IsNullOrEmpty(tmpcliminfo.Log_Date), DBNull.Value, tmpcliminfo.Log_Date)
            dcUpdateClaiminfo.Parameters.Add("parMRNO", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tmpcliminfo.MRNO), DBNull.Value, tmpcliminfo.MRNO)
            dcUpdateClaiminfo.Parameters.Add("parLastJobNO", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tmpcliminfo.LastJobNO), DBNull.Value, tmpcliminfo.LastJobNO)
            dcUpdateClaiminfo.Parameters.Add("parcAdvance", OleDbType.Double).Value = If(String.IsNullOrEmpty(tmpcliminfo.cAdvance), DBNull.Value, tmpcliminfo.cAdvance)
            dcUpdateClaiminfo.Parameters.Add("parcTransportCrg", OleDbType.Double).Value = If(String.IsNullOrEmpty(tmpcliminfo.cTransportCrg), DBNull.Value, tmpcliminfo.cTransportCrg)
            dcUpdateClaiminfo.Parameters.Add("parReturnedItems", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tmpcliminfo.ReturnedItems), DBNull.Value, tmpcliminfo.ReturnedItems)
            dcUpdateClaiminfo.Parameters.Add("parItemRemarks", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tmpcliminfo.ItemRemarks), DBNull.Value, tmpcliminfo.ItemRemarks)
            dcUpdateClaiminfo.Parameters.Add("parFreeOfCost", OleDbType.Double).Value = If(String.IsNullOrEmpty(tmpcliminfo.FreeOfCost), DBNull.Value, tmpcliminfo.FreeOfCost)
            dcUpdateClaiminfo.Parameters.Add("parAdvanceAmnt", OleDbType.Double).Value = If(String.IsNullOrEmpty(tmpcliminfo.AdvanceAmnt), DBNull.Value, tmpcliminfo.AdvanceAmnt)
            dcUpdateClaiminfo.Parameters.Add("parVatAmnt", OleDbType.Double).Value = If(String.IsNullOrEmpty(tmpcliminfo.VatAmnt), DBNull.Value, tmpcliminfo.VatAmnt)
            dcUpdateClaiminfo.Parameters.Add("parEmail", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(tmpcliminfo.Email), DBNull.Value, tmpcliminfo.Email)
            dcUpdateClaiminfo.Parameters.Add("parJobCode2", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(WhereClause), DBNull.Value, WhereClause)


            con.Open()
            dcUpdateClaiminfo.ExecuteNonQuery()






        End Using






    End Sub

    Public Sub Delete(ByVal DeleteJob As String)

        Dim cs = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString


        Dim strUpdateCriteria As String = String.Empty

        Dim strField As String = String.Empty

        strUpdateCriteria = strUpdateCriteria + strField

        Using con As OleDbConnection = New OleDbConnection(cs)

            Dim dcUpdateClaiminfo As OleDbCommand = New OleDbCommand("qryDeleteJob", con)
            dcUpdateClaiminfo.CommandType = CommandType.StoredProcedure



            ' ____________________________________________________________________ Parameter Section ______________________________________________________________________________________

            dcUpdateClaiminfo.Parameters.Add("JobCode1", OleDbType.Char, 255).Value = DeleteJob


            con.Open()
            dcUpdateClaiminfo.ExecuteNonQuery()






        End Using






    End Sub



    Public ReadOnly Property GetDailyTracationJob(ByVal StrParameter As String) As DataTable
        Get
            Dim dt As DataTable = New DataTable

            Dim cs = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

            Using con As OleDbConnection = New OleDbConnection(cs)
                Dim dcGetTransactionJob As OleDbCommand = New OleDbCommand("Select Claiminfo.JobCode,Claiminfo.Branch,CLaiminfo.ModelNo,Claiminfo.ServiceType,WarrantyType.WCondition from Claiminfo left Join WarrantyType on Claiminfo.Wcondition=WarrantyType.WID  where " & StrParameter, con)
                con.Open()

                Dim drGetTransactionJob As OleDbDataReader = dcGetTransactionJob.ExecuteReader

                If drGetTransactionJob.HasRows = True Then
                    dt.Load(drGetTransactionJob)

                End If
            End Using
            Return dt


        End Get
    End Property











End Class
