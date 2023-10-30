Imports System.Drawing.Printing
Imports System.Runtime.InteropServices



Public Class frmPrinerSetup


    <Runtime.InteropServices.DllImport("Winspool.drv")> Private Shared Function SetDefaultPrinter(ByVal printerName As String) As Boolean


    End Function


    Private Sub frmPrinerSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim I As Integer
        Dim strName As String = String.Empty



        Try


            Me.Left = 200
            Me.Top = 200





            For I = 0 To PrinterSettings.InstalledPrinters.Count - 1
                strName = PrinterSettings.InstalledPrinters(I)
                lstPrinterList.Items.Add(strName)
            Next


            ViewDefaultPrinter()
            ResizeControl()

        Catch EXPrinterLoad As Exception
            MessageBox.Show(EXPrinterLoad.Message)


        End Try

    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Dispose()

    End Sub

    Private Sub frmPrinerSetup_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        lstPrinterList.Dispose()
        cmdClose.Dispose()
        cmdSetDefault.Dispose()

    End Sub

    Private Sub cmdSetDefault_Click(sender As Object, e As EventArgs) Handles cmdSetDefault.Click
        Try
            'If lstPrinterList.Items.Count > -1 Then
            '    PrintDoc.PrinterSettings.PrinterName = lstPrinterList.Text
            'End If
            If lstPrinterList.Text <> "" Then
                SetDefaultPrinter(lstPrinterList.Text)
                'Shell("rundll32 printui.dll,PrintUIEntry /y/n" & lstPrinterList.Text)
            End If

            ViewDefaultPrinter()
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbTab & ex.StackTrace)
        End Try

    End Sub

    Private Sub frmPrinerSetup_Resize(sender As Object, e As EventArgs) Handles Me.Resize




    End Sub


    Private Sub ResizeControl()

        lblPrinterList.Top = 5
        lblDefaultPrinter.Top = lblPrinterList.Top



        lblPrinterList.Left = lstPrinterList.Left

        cmdClose.Top = Me.ClientSize.Height - (cmdClose.Height + 5)
        cmdSetDefault.Top = cmdClose.Top


        cmdClose.Width = lstPrinterList.Width / 2
        cmdSetDefault.Width = lstPrinterList.Width / 2
        cmdSetDefault.Left = lstPrinterList.Left
        cmdClose.Left = cmdSetDefault.Left + cmdSetDefault.Width
        lstPrinterList.Top = 20
        lstPrinterList.Height = Me.ClientSize.Height - (lstPrinterList.Top + cmdClose.Height - 5)
        lblDefaultPrinter.Left = (lstPrinterList.Left + lstPrinterList.Width) - lblDefaultPrinter.Width
    End Sub


    Private Sub ViewDefaultPrinter()
        Dim DefaultPrint As New PrinterSettings


        lblDefaultPrinter.Text = "Default Printer: " & DefaultPrint.PrinterName

        Dim intLoop As Integer

        For intLoop = 0 To lstPrinterList.Items.Count - 1
            If lstPrinterList.Items(intLoop).ToString = DefaultPrint.PrinterName Then
                lstPrinterList.Select()
                lstPrinterList.Text = lstPrinterList.Items(intLoop).ToString
            End If

        Next





    End Sub

End Class

