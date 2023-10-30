Imports System.Net.NetworkInformation
Imports System.Net





Public Class frmSysteminformation
    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    '    Dim intInformation() As NetworkInformation.NetworkInterface = NetworkInformation.NetworkInterface.GetAllNetworkInterfaces


    '    lblConnectionSpeed.Text = (intInformation(0).Speed / 1048576) / 8


    'End Sub

    Private Sub frmNetwork_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetSystemInformation()

    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs)
    '    Dim nics() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces
    '    Dim lstItem As ListViewItem = Nothing


    '    lstNetwork.Items.Clear()

    '    For Each nic As NetworkInterface In nics



    '        If nic.NetworkInterfaceType = NetworkInterfaceType.Ethernet And nic.OperationalStatus = OperationalStatus.Up Then
    '            lstItem = lstNetwork.Items.Add(lstNetwork.Items.Count + 1)
    '            lstItem.SubItems.Add(nic.GetPhysicalAddress.ToString)
    '        End If


    '    Next








    '    'If My.Computer.Network.IsAvailable Then
    '    '    MsgBox("Network Available")





    '    'Else
    '    '    MsgBox("Network is not Available")
    '    'End If


    'End Sub


    'Public Shared Function GetAllIP(Optional ByVal args As String() = Nothing) As Collection
    '    Dim strHostName As New String("")
    '    Dim col = New Collection
    '    ' Getting Ip address of local machine...
    '    ' First get the host name of local machine.
    '    strHostName = Dns.GetHostName()
    '    Console.WriteLine("Local Machine's Host Name: " + strHostName)
    '    ' Then using host name, get the IP address list..
    '    Dim ipEntry As IPHostEntry = Dns.GetHostEntry(strHostName)
    '    Dim addr As IPAddress() = ipEntry.AddressList
    '    Dim i As Integer = 0
    '    While i < addr.Length
    '        col.Add(addr(i).ToString())
    '        MsgBox(addr(i).ToString)
    '        i = i + 1
    '    End While
    '    Return col
    'End Function

    'Private Sub Button2_Click(sender As Object, e As EventArgs)
    '    Dim IpA As String = Dns.GetHostName
    '    Dim Ipaddr() As IPAddress

    '    Ipaddr = Dns.GetHostAddresses(IpA)
    '    Dim lstItem As ListViewItem = Nothing



    '    lstNetwork.Items.Clear()

    '    Dim I As Integer

    '    For I = 0 To Ipaddr.Count - 1
    '        lstItem = lstNetwork.Items.Add(lstNetwork.Items.Count + 1)
    '        lstItem.SubItems.Add(Ipaddr(I).ToString)
    '    Next

    'End Sub

    'Private Sub Button3_Click(sender As Object, e As EventArgs)
    '    Getinterface()

    'End Sub

    'Private Sub Getinterface()

    '    'Get all available interface in system
    '    Dim nics As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces
    '    Dim lstItem As ListViewItem = Nothing



    '    'counting nics

    '    If nics.Length < 0 Or nics Is Nothing Then
    '        MessageBox.Show("No Interface found")
    '        Exit Sub
    '    End If

    '    lstNetwork.Items.Clear()

    '    For Each netadaptor As NetworkInterface In nics

    '        Dim ipProperties As IPInterfaceProperties = netadaptor.GetIPProperties

    '        lstItem = lstNetwork.Items.Add(lstNetwork.Items.Count + 1)
    '        lstItem.SubItems.Add(netadaptor.Name)

    '        Dim MacAddress As PhysicalAddress = netadaptor.GetPhysicalAddress
    '        Dim MacByte As Byte() = MacAddress.GetAddressBytes

    '        Dim strMacAddress As String = String.Empty

    '        Dim I As Integer


    '        For I = 0 To MacByte.Length - 1
    '            strMacAddress &= MacByte(I).ToString("X2") ' Change string to hex

    '            If I <> MacByte.Length - 1 Then
    '                strMacAddress &= "-"
    '            End If

    '        Next


    '        Try


    '            lstItem.SubItems.Add(strMacAddress)
    '            'lstItem.SubItems.Add(ipProperties.UnicastAddresses(2).Address.ToString)
    '            'lstItem.SubItems.Add(ipProperties.UnicastAddresses(2).IPv4Mask.ToString)
    '            'lstItem.SubItems.Add(ipProperties.UnicastAddresses(0).Address.ToString)
    '            'lstItem.SubItems.Add(ipProperties.UnicastAddresses(1).Address.ToString)
    '            MessageBox.Show(ipProperties.UnicastAddresses(2).Address.ToString)
    '            'lstItem.SubItems.Add(ipProperties.UnicastAddresses(2).IPv4Mask.ToString)
    '            'lstItem.SubItems.Add(ipProperties.UnicastAddresses(0).Address.ToString)
    '            'lstItem.SubItems.Add(ipProperties.UnicastAddresses(1).Address.ToString)
    '        Catch ex As Exception
    '            MsgBox(Err.Description, Err.Number)

    '        End Try
    '    Next


    '    lstNetwork.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)


    'End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub tbComputerInformation_TabIndexChanged(sender As Object, e As EventArgs) Handles tbComputerInformation.TabIndexChanged

    End Sub

    Private Sub GetSystemInformation()
        Dim Nics As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces
        Dim IpAdd As IPHostEntry = Dns.GetHostByName(Dns.GetHostName)

        Dim Is64Bit As Boolean

        Is64Bit = Not String.IsNullOrEmpty(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432"))

        Try



            txtUserName.Text = System.Environment.UserName

            txtOS.Text = System.Environment.OSVersion().ToString

            txtOSVersion.Text = System.Environment.OSVersion.Version.ToString
            txtSubnetMask.Text = Dns.GetHostEntry(Dns.GetHostName).AddressList(0).ToString
            If Is64Bit = True Then
                txtOSBit.Text = "64 Bit"
            Else
                txtOSBit.Text = System.Environment.MachineName.ToString
            End If
            txtProcessor.Text = CreateObject("WScript.Shell").RegRead("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\CentralProcessor\0\ProcessorNameString")
            txtRam.Text = Math.Round((((My.Computer.Info.TotalPhysicalMemory / 1024) / 1024) / 1024), 2)



            If My.Computer.Network.IsAvailable = True Then

                For Each nic As NetworkInterface In Nics


                    If nic.NetworkInterfaceType = NetworkInterfaceType.Ethernet And nic.OperationalStatus = OperationalStatus.Up Then

                        txtMACAddress.Text = nic.GetPhysicalAddress.ToString




                    End If
                Next
                txtIpAddress.Text = IpAdd.AddressList(0).ToString


            End If









        Catch ex As Exception

        End Try


    End Sub



    Private Sub tbComputerInformation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tbComputerInformation.SelectedIndexChanged

        If tbComputerInformation.SelectedTab.TabIndex = 1 Then
            GetSystemInformation()

        End If
    End Sub
End Class