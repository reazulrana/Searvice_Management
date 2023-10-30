Imports System.ComponentModel
Imports System.Configuration
Imports System.Data.OleDb
Imports System.Threading
Imports System.Runtime.CompilerServices
Imports System.Text

<Assembly: SuppressIldasmAttribute()> 'Protecet From Exposing Code

Public Class frmMdimain



    Dim blnFlag = True 'Define for stop 'Update Command' execution for frequent time of  MailingInformation Table 
    Private Sub frmMDIMAIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Try












            If DatabaseConnection() = True Then

                SetMDIFORM()

                Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString

                Dim conCompanyName As New OleDbConnection(cs)
                Dim drloadCompanyName As OleDbDataReader = Nothing


                LoadAllInformation(conCompanyName, drloadCompanyName, cs, "CompanyInformation", "CompanyName", "CompanyInformation.MakeDefault='Set Default'")

                If drloadCompanyName.HasRows = True Then
                    drloadCompanyName.Read()
                    strCompanyTitle = drloadCompanyName("Companyname").ToString
                End If
                'DetailsToolStripMenuItem_Click(sender, e)
            Else
                MessageBox.Show("Connection can not Not built in application")
                Me.Close()

                Exit Sub

            End If




            Dim frmTempLogIn As frmLogIn = New frmLogIn

            CenterForm(frmTempLogIn)

            frmTempLogIn.ShowDialog()


            If blnLogInFLag = True Then
                Me.Close()
            End If


            If IsNothing(ActiveUser) Then
                tlNewParts.Enabled = False
                tlsNewProduct.Enabled = False
                tlsDeleteJob.Enabled = False
                tlsSubUpdateAndDelete.Enabled = False
                tlsUserManagement.Enabled = False
                DatabseFormateToolStripMenuItem.Enabled = False
            Else

                If ActiveUser.UserType.ToLower = LCase("User") Then
                    tlNewParts.Enabled = False
                    tlsNewProduct.Enabled = False
                    tlsDeleteJob.Enabled = False
                    tlsSubUpdateAndDelete.Enabled = False
                    tlsUserManagement.Enabled = False
                    DatabseFormateToolStripMenuItem.Enabled = False
                ElseIf ActiveUser.UserType.ToLower = LCase("Admin") Then
                    If Not ActiveUser.UserName.ToLower = LCase("Rana") Then
                        DatabseFormateToolStripMenuItem.Enabled = False
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Unsuccessfull Connection")
            Me.Close()


        End Try




    End Sub



    Private Sub mnuExit_Click(sender As Object, e As EventArgs)
        Close()

    End Sub

    Private Sub mnuNew_Click(sender As Object, e As EventArgs) Handles mnuNew.Click

        Dim frmNewCustomer As New NewCustomer

        shrtFormType = 1
        ShowCustomerClaim(frmNewCustomer)

        ' ResizeForm(frm, True)


    End Sub





    Private Sub ShowToolsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowToolsToolStripMenuItem.Click
        If MainTools.Visible = False Then

            Me.Controls("MainTools").Visible = True


        End If

    End Sub

    Private Sub HideToolsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HideToolsToolStripMenuItem.Click
        MainTools.Visible = False

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)
        mnuNew_Click(sender, e)


    End Sub



    Private Sub SettingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingToolStripMenuItem.Click
        'If MainTools.Visible = True Then
        '    MainTools.Visible = False
        'End If
        'Dim frm As frmSetting

        'frm = New frmSetting
        'frm.MdiParent = Me
        'frm.Show()




    End Sub






    Private Sub ShowCustomerClaim(ByVal frmTemp As Form)

        Static intCount As Int32



        intCount = intCount + 1
        Me.IsMdiContainer = True
        frmTemp.MdiParent = Me
        frmTemp.Text = "New Customer " & intCount
        frmTemp.Width = Me.ClientSize.Width
        frmTemp.Height = Me.ClientSize.Height
        frmTemp.Left = Me.Left
        frmTemp.Top = Me.Top




        frmTemp.Show()


        'frmNewCustomer.Activate()
        frmTemp.WindowState = FormWindowState.Maximized
        HideMainTools()


    End Sub



    Private Sub frmMDIMAIN_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.S AndAlso e.Modifiers = Keys.Control Then

            MainTools.Visible = True

        ElseIf e.KeyCode = Keys.H AndAlso e.Modifiers = Keys.Control Then
            MainTools.Visible = False

        End If
    End Sub

    Private Sub mnuWorkingProcess_Click(sender As Object, e As EventArgs) Handles mnuWorkingProcess.Click

    End Sub

    Private Sub CategoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoryToolStripMenuItem.Click
        Dim frmtmpCategory As New frmCategory

        frmtmpCategory.MdiParent = Me

        frmtmpCategory.Show()


    End Sub



    Private Sub FindToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindToolStripMenuItem.Click
        Dim frmTempProductSearch As New frmproductsearch

        CenterForm(Me)

        frmTempProductSearch.ShowDialog()
    End Sub

    Private Sub NewEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewEntryToolStripMenuItem.Click
        Dim frmTempAdvancePayment As New FrmAdvance


        frmTempAdvancePayment.ShowDialog()




    End Sub

    Private Sub DataBackupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataBackupToolStripMenuItem.Click
        Dim frmTempBackup As New frmBackUp



        frmTempBackup.ShowDialog()


    End Sub

    Private Sub PrinterSetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrinterSetupToolStripMenuItem.Click
        Dim frmTempPrinterSetup As New frmPrinerSetup



        frmTempPrinterSetup.ShowDialog()

    End Sub

    Private Sub WaitingForServiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WaitingForServiceToolStripMenuItem.Click
        Dim frmTempJobStatus As New frmProductInformation ' Check frmJobStatus From from Solution Explorer

        frmTempJobStatus.MdiParent = Me


        frmTempJobStatus.Show()


    End Sub

    Private Sub TotalConnectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TotalConnectionToolStripMenuItem.Click
        Dim frmTempNetworkConnection As New frmSysteminformation


        frmTempNetworkConnection.ShowDialog()


    End Sub









    'Private Sub frmMDIMAIN_Activated(sender As Object, e As EventArgs) Handles Me.Activated
    '    FormOpecityIncrease(Me, 1)
    'End Sub



    'Private Sub frmMDIMAIN_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
    '    FormOpecityDecrease(Me, 0.5)
    'End Sub

    Private Sub HideMainTools()


























        If MainTools.Visible = True Then
            Me.MainTools.Visible = False
        End If


    End Sub
    Private Sub ShowMainTools()
        If Me.MainTools.Visible = False Then
            Me.MainTools.Visible = True
        End If
    End Sub

    Private Sub frmMDIMAIN_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Try


            Dim tmpuserinfomethods As clsUserInfoMethods = New clsUserInfoMethods



            TempConnectionDispose(MyCon)

            If Not ActiveUser Is Nothing Then
                tmpuserinfomethods.UserDeActive(ActiveUser.UserID)
            End If


        Catch ex As Exception

        End Try
    End Sub


    Private Sub frmMDIMAIN_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        ShowMainTools()
    End Sub

    Private Sub UpdateModelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tlsSubUpdateAndDelete.Click
        Dim frmTempModelUpdate As New frmUpdate_Delete

        frmTempModelUpdate.MdiParent = Me
        frmTempModelUpdate.Show()


    End Sub

    Private Sub ResizeRecordToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frmTempFormateDatabase As New frmMerge



        frmTempFormateDatabase.ShowDialog()


    End Sub

    Private Sub PersonalInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonalInformationToolStripMenuItem.Click
        Dim frmTempPersonalInformation As New frmPersonalInformation

        frmTempPersonalInformation.ShowDialog()


    End Sub

    Private Sub BranchToolStripMenuItem_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub SetBranchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetBranchToolStripMenuItem.Click
        Dim frm As frmSetBranch
        frm = New frmSetBranch


        frm.ShowDialog()
    End Sub

    Private Sub NewBranchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewBranchToolStripMenuItem.Click
        Dim frmTempNewBranch As New frmNewBranch
        Me.IsMdiContainer = True
        frmTempNewBranch.MdiParent = Me
        frmTempNewBranch.Show()



    End Sub

    Private Sub OpenCashSalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenCashSalesToolStripMenuItem.Click
        Dim frmTempNewCashsales As New frmCashsale

        frmTempNewCashsales.strFormMode = UCase("New")


        frmTempNewCashsales.ShowDialog()





    End Sub

    Private Sub DetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetailsToolStripMenuItem.Click
        Dim frmTempMasterReport As New frmMaster_information


        ReportIdentification = "Receive"
        frmTempMasterReport.Text = "Receive Report"
        frmTempMasterReport.ShowDialog()


    End Sub

    Private Sub NewComapanyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewComapanyToolStripMenuItem.Click
        Dim frmTempCompanyInformation As New frmCompanyInformation

        frmTempCompanyInformation.strRecocdModeIdentity = "New"
        frmTempCompanyInformation.Show()


    End Sub

    Private Sub EditToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem1.Click
        Dim frmTempCompanyInformation As New frmCompanyInformation

        frmTempCompanyInformation.strRecocdModeIdentity = "Edit"
        frmTempCompanyInformation.Show()
    End Sub

    Private Sub OptionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionToolStripMenuItem.Click
        Dim frmTempOption As New frmOption
        frmTempOption.ShowDialog()


    End Sub

    Private Sub MasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterToolStripMenuItem.Click
        Dim frmTempRepaired As New frmMaster_information


        ReportIdentification = UCase("Repair")
        frmTempRepaired.Text = "Repaird Report"
        frmTempRepaired.ShowDialog()


    End Sub

    Private Sub MasterToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MasterToolStripMenuItem1.Click

        Dim frmTempDelivery As New frmMaster_information


        ReportIdentification = UCase("Delivery")
        frmTempDelivery.Text = "Delivery Report"
        frmTempDelivery.ShowDialog()


    End Sub

    Private Sub tlNewJobs_Click(sender As Object, e As EventArgs) Handles tlNewJobs.Click

        mnuNew_Click(sender, e)



    End Sub

    Private Sub tlOpenJobs_Click(sender As Object, e As EventArgs) Handles tlOpenJobs.Click

        Try


            Dim frm As New frmOpenCustomerClaim

            FormOpecityDecrease(Me, 0.9)
            frm.strFormType = "Repair"
            ResizeForm(frm, False)
            FormOpecityIncrease(Me, 1)


            If blnJobCodeFlag = True Then

                Dim frmEditCustmer As New NewCustomer
                shrtFormType = 2 'edit

                ShowCustomerClaim(frmEditCustmer)

            End If

        Catch ex As Exception
            MessageBox.Show(Err.Number & Err.Description)
        End Try

    End Sub

    Private Sub PendingRepairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PendingRepairToolStripMenuItem.Click



    End Sub





    Private Sub RefuseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefuseToolStripMenuItem.Click
        Dim frmEstimateRefuse As New frmMaster_information


        ReportIdentification = UCase("Estimate Refuse")
        frmEstimateRefuse.Text = "Estimate Refuse Report"
        frmEstimateRefuse.ShowDialog()
    End Sub

    Private Sub DetailsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DetailsToolStripMenuItem1.Click
        Dim frmTempPendingRepair As New frmMaster_information

        ReportIdentification = UCase("Pending Repair")
        frmTempPendingRepair.Text = "Pending Report"

        frmTempPendingRepair.ShowDialog()
    End Sub

    Private Sub DetailsToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles DetailsToolStripMenuItem2.Click

        Dim frmTempPendingDelivery As New frmMaster_information

        ReportIdentification = UCase("Pending Delivery")
        frmTempPendingDelivery.Text = "Pending Delivery Report (Not Delivered)"

        frmTempPendingDelivery.ShowDialog()







    End Sub

    Private Sub NotRepairableNRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotRepairableNRToolStripMenuItem.Click
        Dim frmTempNrCR As New frmMaster_information

        ReportIdentification = UCase("NRCR")
        frmTempNrCR.Text = "N/R Report"
        frmTempNrCR.ShowDialog()




    End Sub

    Private Sub PartsConsumptionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PartsConsumptionToolStripMenuItem.Click





    End Sub

    Private Sub OnRepairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OnRepairToolStripMenuItem.Click
        Dim frmTempPartsConsumptionOnRepair As New frmMaster_information

        ReportIdentification = UCase("Parts Consumption Repair")
        frmTempPartsConsumptionOnRepair.optByRepaired.Checked = True
        frmTempPartsConsumptionOnRepair.Text = "Parts Consumption Report (Repair) "
        frmTempPartsConsumptionOnRepair.ShowDialog()
    End Sub

    Private Sub OnDeliveryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OnDeliveryToolStripMenuItem.Click
        Dim frmTempPartsConsumptionOnRepair As New frmMaster_information

        ReportIdentification = UCase("Parts Consumption Delivery")
        frmTempPartsConsumptionOnRepair.optByDelivery.Checked = True
        frmTempPartsConsumptionOnRepair.Text = "Parts Consumption Report (Delivery)"
        frmTempPartsConsumptionOnRepair.ShowDialog()
    End Sub

    Private Sub OnRepairToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OnRepairToolStripMenuItem1.Click
        Dim frmTempPartsConsumptionSummeryRepair As New frmMaster_information

        ReportIdentification = UCase("Parts Consumption Summery Repair")
        frmTempPartsConsumptionSummeryRepair.optByRepaired.Checked = True
        frmTempPartsConsumptionSummeryRepair.Text = "Parts Consumption Summery Report (Repair)"
        frmTempPartsConsumptionSummeryRepair.ShowDialog()
    End Sub

    Private Sub OnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OnToolStripMenuItem.Click
        Dim frmTempPartsConsumptionDelivery As New frmMaster_information

        ReportIdentification = UCase("Parts Consumption Summery Delivery")
        frmTempPartsConsumptionDelivery.optByDelivery.Checked = True
        frmTempPartsConsumptionDelivery.Text = "Parts Consumption Summery Report (Delivery)"
        frmTempPartsConsumptionDelivery.ShowDialog()
    End Sub

    Private Sub TechnicianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TechnicianToolStripMenuItem.Click

    End Sub

    Private Sub PersonalToolStripMenuItem_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub ALLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ALLToolStripMenuItem.Click
        Dim frmTempTechnicianReportDetails As New frmMaster_information

        ReportIdentification = UCase("Technician Performance Details")
        frmTempTechnicianReportDetails.Text = "Technician Performance Report (Details)"
        frmTempTechnicianReportDetails.ShowDialog()


    End Sub

    Private Sub SummeryToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles SummeryToolStripMenuItem3.Click

    End Sub

    Private Sub SummeryToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles SummeryToolStripMenuItem8.Click
        Dim frmTempTechnicianReportsummery As New frmMaster_information

        ReportIdentification = UCase("Technician Performance Summery")
        frmTempTechnicianReportsummery.Text = "Technician Performance Report (Summery)"
        frmTempTechnicianReportsummery.ShowDialog()
    End Sub

    Private Sub TimeComparisonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimeComparisonToolStripMenuItem.Click
        Dim frmTempTechnicianReportTimeElapsed As New frmMaster_information

        ReportIdentification = UCase("Technician Performance Time Elapsed")
        frmTempTechnicianReportTimeElapsed.Text = "Technician Performance Report Time Elapsed"
        frmTempTechnicianReportTimeElapsed.ShowDialog()
    End Sub

    Private Sub ReceivingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReceivingToolStripMenuItem.Click

    End Sub



    Private Sub BrandWiseToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Dim frmTEMpReceiveSummeryBranch As New frmMaster_information

        ReportIdentification = UCase("Receive Summery Branch Wise")
        frmTEMpReceiveSummeryBranch.optByReceive.Checked = True
        frmTEMpReceiveSummeryBranch.Text = "Receive Summery Report (Branch)"
        frmTEMpReceiveSummeryBranch.ShowDialog()

    End Sub

    Private Sub ModelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModelToolStripMenuItem.Click
        Dim frmTEMpReceiveSummeryModel As New frmMaster_information

        ReportIdentification = UCase("Receive Summery Model Wise")
        frmTEMpReceiveSummeryModel.optByReceive.Checked = True
        frmTEMpReceiveSummeryModel.Text = "Receive Summery Report (Moedel) "
        frmTEMpReceiveSummeryModel.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim frmTEMpReceiveSummery As New frmMaster_information

        ReportIdentification = UCase("Receive Summery Branch Wise")
        frmTEMpReceiveSummery.optByReceive.Checked = True
        frmTEMpReceiveSummery.Text = "Receive Summery Report (Branch)"
        frmTEMpReceiveSummery.ShowDialog()
    End Sub

    Private Sub BrandWiseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BrandWiseToolStripMenuItem.Click
        Dim frmTEMpReceiveSummeryBrand As New frmMaster_information

        ReportIdentification = UCase("Receive Summery Brand Wise")
        frmTEMpReceiveSummeryBrand.optByReceive.Checked = True
        frmTEMpReceiveSummeryBrand.Text = "Receive Summery Report (Brand) "

        frmTEMpReceiveSummeryBrand.ShowDialog()
    End Sub

    Private Sub RegularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegularToolStripMenuItem.Click
        Dim frmTEMpReceiveSummeryBrand As New frmMaster_information

        ReportIdentification = UCase("Receive Summery Category Wise")
        frmTEMpReceiveSummeryBrand.optByReceive.Checked = True
        frmTEMpReceiveSummeryBrand.Text = "Receive Summery Report (Category) "
        frmTEMpReceiveSummeryBrand.ShowDialog()
    End Sub

    Private Sub BranchToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles BranchToolStripMenuItem.Click
        Dim frmTEMpRepairedSummeryBranch As New frmMaster_information

        ReportIdentification = UCase("Repaired Summery Branch Wise")
        frmTEMpRepairedSummeryBranch.optByRepaired.Checked = True
        frmTEMpRepairedSummeryBranch.Text = "Repair Summery(Branch) Report"
        frmTEMpRepairedSummeryBranch.ShowDialog()
    End Sub

    Private Sub CategoryToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CategoryToolStripMenuItem1.Click
        Dim frmTEMpRepairedSummeryCategory As New frmMaster_information

        ReportIdentification = UCase("Repaired Summery Category Wise")
        frmTEMpRepairedSummeryCategory.optByRepaired.Checked = True
        frmTEMpRepairedSummeryCategory.Text = "Repair Summery(Category) Report"
        frmTEMpRepairedSummeryCategory.ShowDialog()
    End Sub

    Private Sub BrandToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BrandToolStripMenuItem.Click
        Dim frmTEMpRepairedSummeryBrand As New frmMaster_information

        ReportIdentification = UCase("Repaired Summery Brand Wise")
        frmTEMpRepairedSummeryBrand.optByRepaired.Checked = True
        frmTEMpRepairedSummeryBrand.Text = "Repair Summery(Brand) Report"
        frmTEMpRepairedSummeryBrand.ShowDialog()
    End Sub

    Private Sub ModelToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ModelToolStripMenuItem1.Click
        Dim frmTEMpRepairedSummeryModel As New frmMaster_information

        ReportIdentification = UCase("Repaired Summery Model Wise")
        frmTEMpRepairedSummeryModel.optByRepaired.Checked = True
        frmTEMpRepairedSummeryModel.Text = "Repair Summery(Model) Report"
        frmTEMpRepairedSummeryModel.ShowDialog()
    End Sub

    Private Sub BranchToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BranchToolStripMenuItem1.Click
        Dim frmTEMpDeliveredSummeryBranch As New frmMaster_information

        ReportIdentification = UCase("Delivered Summery Branch Wise")
        frmTEMpDeliveredSummeryBranch.optByDelivery.Checked = True
        frmTEMpDeliveredSummeryBranch.Text = "Delivery Summery Report (Branch)"
        frmTEMpDeliveredSummeryBranch.ShowDialog()
    End Sub

    Private Sub CategoryToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles CategoryToolStripMenuItem2.Click
        Dim frmTEMpDeliveredSummeryBranch As New frmMaster_information

        ReportIdentification = UCase("Delivered Summery Category Wise")
        frmTEMpDeliveredSummeryBranch.optByDelivery.Checked = True
        frmTEMpDeliveredSummeryBranch.Text = "Delivery Summery Report (Category)"
        frmTEMpDeliveredSummeryBranch.ShowDialog()
    End Sub

    Private Sub BrandToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BrandToolStripMenuItem1.Click
        Dim frmTEMpDeliveredSummeryBranch As New frmMaster_information

        ReportIdentification = UCase("Delivered Summery Brand Wise")
        frmTEMpDeliveredSummeryBranch.Text = "Delivery Summery Report (Brand)"
        frmTEMpDeliveredSummeryBranch.optByDelivery.Checked = True
        frmTEMpDeliveredSummeryBranch.ShowDialog()
    End Sub

    Private Sub ModelToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ModelToolStripMenuItem2.Click
        Dim frmTEMpDeliveredSummeryBranch As New frmMaster_information

        ReportIdentification = UCase("Delivered Summery Model Wise")
        frmTEMpDeliveredSummeryBranch.Text = "Delivery Summery Report (Model)"
        frmTEMpDeliveredSummeryBranch.optByDelivery.Checked = True
        frmTEMpDeliveredSummeryBranch.ShowDialog()
    End Sub

    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim frmTempNewCashsale As New frmCashsale


        frmTempNewCashsale.strFormMode = UCase("New")

        frmTempNewCashsale.ShowDialog()


    End Sub

    Private Sub EditCashSalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditCashSalesToolStripMenuItem.Click
        Dim frmTempCashsales As New frmCashsale

        frmTempCashsales.strFormMode = UCase("Edit")
        frmTempCashsales.ShowDialog()

    End Sub

    Private Sub PresentStockToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'Dim frmTempPresentStock As New frmPresentStock



        'frmTempPresentStock.ShowDialog()




    End Sub

    Private Sub BranchToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles BranchToolStripMenuItem2.Click
        Dim frmTempServiceCollection As New frmMaster_information
        ReportIdentification = UCase("Service Collection Branch")
        frmTempServiceCollection.optByDelivery.Checked = True
        frmTempServiceCollection.Text = "Service Collection Report"
        frmTempServiceCollection.ShowDialog()

    End Sub

    Private Sub UserManagementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tlsUserManagement.Click
        Dim tmpfrmUser As frmCreateUser = New frmCreateUser

        tmpfrmUser.ShowDialog()
        CenterForm(Me)

    End Sub

    Private Sub Main_menu_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Main_menu.ItemClicked

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        'Dim NetCheck As clsNetwork = New clsNetwork

        ''If NetCheck.Internet = True Then
        ''    MessageBox.Show("Internet is connected")
        ''Else
        ''    MessageBox.Show("Internet is not connected")
        ''End If


        Try
            Dim frm As New frmOpenCustomerClaim

            FormOpecityDecrease(Me, 0.5)
            frm.strFormType = "JobStatus"
            ResizeForm(frm, False)
            FormOpecityIncrease(Me, 1)

            If blnJobCodeFlag = True Then
                Dim frmJobinformation As frmOnpayment_Bill_Format = New frmOnpayment_Bill_Format
                frmJobinformation.strFormType = "JobStatus" ' Check Bill Form Status
                frmJobinformation.ShowDialog()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try




    End Sub

    Private Sub MergeDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MergeDatabaseToolStripMenuItem.Click
        Dim frmtmpMerge As frmMergeDatabase = New frmMergeDatabase
        frmtmpMerge.ShowDialog()


    End Sub



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblTime.Click

    End Sub

    Private Sub tlDeliverys_Click(sender As Object, e As EventArgs) Handles tlDeliverys.Click
        Try
            Dim frm As New frmOpenCustomerClaim

            FormOpecityDecrease(Me, 0.5)
            frm.strFormType = "Delivery"
            ResizeForm(frm, False)
            FormOpecityIncrease(Me, 1)
            If blnJobCodeFlag = True Then

                Dim frmDelivery As frmOnpayment_Bill_Format = New frmOnpayment_Bill_Format
                frmDelivery.ShowDialog()


            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub



    Private Sub tlNewProduct_Click(sender As Object, e As EventArgs) Handles tlNewParts.Click
        Dim frmtmpProduct As frmNewProduct = New frmNewProduct



        frmtmpProduct.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles tlsNewProduct.Click
        Dim frmtmpProduct As frmNewProduct = New frmNewProduct



        frmtmpProduct.ShowDialog()
    End Sub

    Private Sub tlsDeleteJob_Click(sender As Object, e As EventArgs) Handles tlsDeleteJob.Click

        Dim frmtempDeleteJob As frmDeleteJob = New frmDeleteJob

        frmtempDeleteJob.ShowDialog()







    End Sub

    Private Sub DetailsToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles DetailsToolStripMenuItem3.Click
        Dim frmTempMasterReport As New frmCashSalesReport
        ReportIdentification = "CashSalesDetails"
        frmTempMasterReport.lblHeader.Text = "Cash Sales Report (Details)"
        frmTempMasterReport.ShowDialog()


    End Sub

    Private Sub SummeryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SummeryToolStripMenuItem.Click
        Dim frmTempMasterReport As New frmCashSalesReport
        ReportIdentification = "CashSalesSummery"
        frmTempMasterReport.lblHeader.Text = "Cash Sales Report (Summery)"
        frmTempMasterReport.ShowDialog()

    End Sub

    Private Sub DailyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DailyToolStripMenuItem.Click
        Dim frmTempMasterReport As New frmCashSalesReport
        ReportIdentification = "DailyTransactionSingleDate"
        frmTempMasterReport.lblHeader.Text = "Daily Transaction Report (Single Date)"
        frmTempMasterReport.dtpFrom.Visible = False
        frmTempMasterReport.lblFrom.Visible = False
        frmTempMasterReport.lblTo.Text = "Transaction Date:"
        frmTempMasterReport.lblTo.TextAlign = ContentAlignment.BottomRight
        frmTempMasterReport.ShowDialog()
    End Sub

    Private Sub DateWiseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DateWiseToolStripMenuItem.Click
        Dim frmTempMasterReport As New frmCashSalesReport
        ReportIdentification = "DailyTransactionDateWise"
        frmTempMasterReport.lblHeader.Text = "Daily Transaction Report (Date Wise)"
        frmTempMasterReport.ShowDialog()
    End Sub

    Private Sub ALLToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ALLToolStripMenuItem1.Click
        Dim frmTempMasterReport As New frmCashSalesReport
        ReportIdentification = "PresentStockALL"
        frmTempMasterReport.dtpFrom.Visible = False
        frmTempMasterReport.dtpTo.Visible = False
        frmTempMasterReport.lblFrom.Visible = False
        frmTempMasterReport.lblTo.Visible = False
        frmTempMasterReport.grpInformation.Enabled = False
        frmTempMasterReport.lblHeader.Text = "Present Stock Reoport (ALL)"



        frmTempMasterReport.ShowDialog()
    End Sub

    Private Sub ByDateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ByDateToolStripMenuItem.Click
        Dim frmTempMasterReport As New frmCashSalesReport
        ReportIdentification = "PresentStockByDate"
        frmTempMasterReport.lblHeader.Text = "Present Stock Report (By Date)"
        frmTempMasterReport.ShowDialog()
    End Sub

    Private Sub QuatationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuatationToolStripMenuItem.Click
        Dim QuotationForm As frmQuotation = New frmQuotation

        QuotationForm.ShowDialog()


    End Sub

    Private Sub ProductStorageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductStorageToolStripMenuItem.Click
        Dim tbStorage As frmtbStorageSet = New frmtbStorageSet
        tbStorage.ShowDialog()


    End Sub

    Private Sub ProductTransferToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductTransferToolStripMenuItem.Click
        Dim TransferForm As frmTransfer = New frmTransfer

        TransferForm.Show()

    End Sub

    Private Sub DatabseFormateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatabseFormateToolStripMenuItem.Click

    End Sub



    Private Sub JobLiseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JobLiseToolStripMenuItem.Click
        Dim jobupdate As frmJobUpdate = New frmJobUpdate

        jobupdate.ShowDialog()

    End Sub






    Private Sub DeliveredToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeliveredToolStripMenuItem.Click
        ReportIdentification = "ReportDiscountDelivered"
        Dim frmTempMasterReport As New frmMaster_information
        frmTempMasterReport.Text = "Discount Report (Delivery)"
        frmTempMasterReport.ShowDialog()
    End Sub

    Private Sub NotAssignedJobToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotAssignedJobToolStripMenuItem.Click
        ReportIdentification = "Not Assign Job"
        Dim frmTempMasterReport As New frmMaster_information
        frmTempMasterReport.Text = "Not Assign Report"
        frmTempMasterReport.ShowDialog()
    End Sub

    Private Sub UnderProcessToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnderProcessToolStripMenuItem.Click
        ReportIdentification = "Under Process"
        Dim frmTempMasterReport As New frmMaster_information
        frmTempMasterReport.Text = "Under Process Report"
        frmTempMasterReport.ShowDialog()
    End Sub

    Private Sub JobTransferToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JobTransferToolStripMenuItem.Click
        ReportIdentification = "Job Transfer"
        Dim frmTempMasterReport As New frmMaster_information
        frmTempMasterReport.Text = "Job Transfer Report"
        frmTempMasterReport.ShowDialog()
    End Sub

    Private Sub StorageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StorageToolStripMenuItem.Click
        ReportIdentification = "Job Storage"
        Dim frmTempMasterReport As New frmMaster_information
        frmTempMasterReport.Text = "Storage Report"
        frmTempMasterReport.ShowDialog()
    End Sub

    Private Sub frmMdimain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing


    End Sub

    Private Sub DetailsToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles DetailsToolStripMenuItem4.Click
        ReportIdentification = "Customer Details"
        Dim frmTempMasterReport As New frmMaster_information
        frmTempMasterReport.Text = "Customer Details"
        frmTempMasterReport.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Me.Close()
        'Me.Dispose()
        Application.Exit()


    End Sub

    Private Sub EventViewerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EventViewerToolStripMenuItem.Click

    End Sub

    Private Sub DeleteJobsToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DailyReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DailyReportToolStripMenuItem.Click
        Dim DailyReport As frmDailyreport = New frmDailyreport

        DailyReport.ShowDialog()

    End Sub

    Private Sub AddNewMailToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewMailToolStripMenuItem.Click
        Dim NewMail As frmMaliList = New frmMaliList
        NewMail.ShowDialog()


    End Sub

    Private Sub SummeryToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles SummeryToolStripMenuItem9.Click

    End Sub




    Private Sub ServiceCollectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServiceCollectionToolStripMenuItem.Click

    End Sub

    Private Sub ReplaceToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BrandModelToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub INOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles INOUTToolStripMenuItem.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = DateTime.Parse(Now).ToString("h:mm:ss tt") ' Date.Now.Hour & ":" & Date.Now.Minute & ":" & Date.Now.Second





    End Sub

    Private Sub mnuDataLoad_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub LoadDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadDatabaseToolStripMenuItem.Click
        Dim DataLoad As frmLoadDatabase = New frmLoadDatabase

        DataLoad.ShowDialog()
    End Sub

    Private Sub mnuExit_Click_1(sender As Object, e As EventArgs) Handles mnuExit.Click

        Dim objsender As Object = New Object



        tlOpenJobs_Click(objsender, e)

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick


        'Schedule(DateTime.Parse(Now).ToString("h:mm:ss tt"))


    End Sub


    Private Sub Schedule(ByVal strTime As String)

        Dim exeSchedule As clsExecutionSchedule = New clsExecutionSchedule

        Dim listSchedule As List(Of clsExecutionSchedule) = exeSchedule.GetActiveSchedules.ToList ' Get selected Schedule from ExecutionSchedule Table
        Dim tmpExecutionDay As clsExecutionDay = New clsExecutionDay

        Dim MailInformation As clsMailingInformation = New clsMailingInformation
        Dim CTime As String = strTime ' Date.Parse(Now).ToString("h:mm:ss tt")
        If listSchedule.Count > 0 Then ' Check Schedule exist or not from ExecutionSchedule Table

            If MailInformation.HasRow = True Then
                If blnFlag = True Then 'if blnflag =False then never execute this command
                    MailInformation.UpdateAll()
                    ' If Job Status Become Delivery Mode then Delete from the Mailinginformation Table 
                    MailInformation.Delete(0)
                    MailInformation.Delete(2)

                    ' Update Only Status and pStatus Column of the Mailinginformation Table 
                    MailInformation.UpdatePartial()
                    blnFlag = False
                End If
            End If


            For Each tS As clsExecutionSchedule In listSchedule ' Looping each execution Schedule 
                If tS.ActionTime = CTime Then
                    If tmpExecutionDay.IsExist(tS.ID) = True Then ' Check Day exist or not from ExecutionDay Table
                        Dim lstDay As List(Of clsExecutionDay) = tmpExecutionDay.GetDayListByID(tS.ID).ToList ' Get selected Schedule from ExecutionSchedule Table
                        If lstDay.Count > 0 Then
                            For Each day As clsExecutionDay In lstDay
                                If Now.DayOfWeek = day.DayID Then


                                    Dim JobStatusMethods As clsExecutionJobStatus = New clsExecutionJobStatus
                                    Dim lstJobStatus As List(Of clsExecutionJobStatus) = JobStatusMethods.GetJobStatus.Where(Function(x) x.ActionID = tS.ID).ToList
                                    If lstJobStatus.Count > 0 Then
                                        For Each JS As clsExecutionJobStatus In lstJobStatus
                                            MailInformation.Insert(JS.cFlag, tS.ActionName, tS.ExceededDay)
                                        Next
                                    End If

                                    If MailInformation.HasRow = True Then
                                        SendAuditMail()
                                        MessageBox.Show("Mail Sent successfylly")
                                    End If

                                End If
                            Next
                        End If
                    End If
                End If
            Next
        End If


    End Sub
    Private Sub SendAuditMail()
        Dim Audit As clsJobAuditMethods = New clsJobAuditMethods
        Dim lstAudit As List(Of clsJobAudit) = Audit.GetAuditList.ToList

        ' ExecutionSchedule Section
        Dim exs As clsExecutionSchedule = New clsExecutionSchedule
        Dim lstexs As List(Of clsExecutionSchedule) = exs.GetActiveSchedules.ToList
        ' ExecutionDay Section
        Dim exsday As clsExecutionDay = New clsExecutionDay


        Try


            Dim strB As StringBuilder = New StringBuilder
        If lstexs.Count > 0 Then
            For Each schedule As clsExecutionSchedule In lstexs

                If lstAudit.Count > 0 Then

                    For Each Tempaudit As clsJobAudit In lstAudit



                        If schedule.ActionName.ToLower = "Not Issued".ToLower Then



                            If Tempaudit.NotIssued = True Then
                                strB = GetMailinginformation(-1, schedule.ActionName)
                                If strB.Length > 0 Then
                                    SendMail(Tempaudit.MailNo, "Not Assigned", strB)
                                End If
                            End If


                        End If


                        If schedule.ActionName.ToLower = "Assigned".ToLower Then
                            If Tempaudit.AfterIssue = True Then ' Define Assigned field of 'Assigned Field in JobAudit Table'
                                strB = GetMailinginformation(-1, schedule.ActionName)
                                If strB.Length > 0 Then
                                    SendMail(Tempaudit.MailNo, "Assigned", strB)
                                End If
                            End If
                        End If


                        If schedule.ActionName.ToLower = "Waiting for Delivery".ToLower Then

                            If Tempaudit.WaitingforDelivery = True Then ' Define Assigned field of 'Assigned Field in JobAudit Table'

                                strB = GetMailinginformation(9, schedule.ActionName)
                                If strB.Length > 0 Then
                                    SendMail(Tempaudit.MailNo, "Pending", strB)
                                End If


                                strB = GetMailinginformation(99, schedule.ActionName)
                                If strB.Length > 0 Then
                                    SendMail(Tempaudit.MailNo, "NR", strB)
                                End If



                                strB = GetMailinginformation(1, schedule.ActionName)
                                If strB.Length > 0 Then
                                    SendMail(Tempaudit.MailNo, "Service Completed", strB)
                                End If



                            End If


                        End If

                    Next
                End If
            Next
        End If


        Catch ex As Exception
            MessageBox.Show(ex.StackTrace, ex.Message)
        End Try





    End Sub



    Private Function GetMailinginformation(ByVal intStatus As Integer, ByVal Type As String) As StringBuilder

        Dim MI As clsMailingInformation = New clsMailingInformation
        Dim strRecord As StringBuilder = New StringBuilder


        Dim dt As DataTable = MI.GetMailInformation(intStatus, Type)
        Dim intLoopRow As Integer = 0
        Dim intLoopColumn As Integer = 0
        If dt.Rows.Count > 0 Then



            strRecord.Append("<table border='1' padding='0' width='40%'>")

            strRecord.Append("<tr>")

            strRecord.Append("<th>")
            strRecord.Append("Job Code")
            strRecord.Append("</th>")



            strRecord.Append("<th>")
            strRecord.Append("Branch")
            strRecord.Append("</th>")



            strRecord.Append("<th>")
            strRecord.Append("Category")
            strRecord.Append("</th>")



            strRecord.Append("<th>")
            strRecord.Append("Model")
            strRecord.Append("</th>")


            strRecord.Append("<th>")
            strRecord.Append("Receve Date")
            strRecord.Append("</th>")


            strRecord.Append("<th>")
            strRecord.Append("Issue Date")
            strRecord.Append("</th>")


            strRecord.Append("<th>")
            strRecord.Append("Repair Date")
            strRecord.Append("</th>")

            strRecord.Append("<th>")
            strRecord.Append("WarrType")
            strRecord.Append("</th>")


            strRecord.Append("<th>")
            strRecord.Append("Status")
            strRecord.Append("</th>")



            strRecord.Append("<th>")
            strRecord.Append("S. Charge")
            strRecord.Append("</th>")


            strRecord.Append("<th>")
            strRecord.Append("Parts")
            strRecord.Append("</th>")

            strRecord.Append("<th>")
            strRecord.Append("Tat")
            strRecord.Append("</th>")



            strRecord.Append("</tr>")


            ' Header Section
            For intLoopRow = 0 To dt.Rows.Count - 1
                strRecord.Append("<tr>")
                For intLoopColumn = 0 To dt.Columns.Count - 1

                    strRecord.Append("<td>")
                    strRecord.Append(dt.Rows(intLoopRow)(intLoopColumn).ToString)
                    strRecord.Append("</td>")

                Next
                    strRecord.Append("</tr>")
            Next

            strRecord.Append("</table>")






        End If

        Return strRecord


    End Function


    Private Sub SendMail(ByVal ToMail As String, ByVal Subject As String, ByVal Body As StringBuilder)


        Dim Mail As clsMail = New clsMail
        Dim Network As clsNetwork = New clsNetwork
        Dim OptionMethods As clsOptionMethods = New clsOptionMethods

        If Network.isInternet = False Then
            Exit Sub
        End If

        Dim MOption As clsOption = OptionMethods.GetActiveMail


        If Not MOption Is Nothing Then


            Mail.MailID = MOption.MailFrom
            Mail.From = MOption.MailFrom
            Mail.Password = MOption.Crediantial
            Mail.PORT = MOption.Port
            Mail.SMTP = MOption.SMTP
            Mail.SSL = True
            Mail.MailTo = ToMail
            Mail.Subject = Subject
            Mail.Body = Body.ToString
            Network.SendMail(Mail, False, True)

        End If
    End Sub



    Private Sub ScheduleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScheduleToolStripMenuItem.Click
        Dim frmSchedule As frmTimeSchedule = New frmTimeSchedule

        frmSchedule.ShowDialog()



    End Sub
End Class