Imports System.Security.Cryptography
Imports System.Text
Imports System.Configuration



Public Class clsSecurity








    Public Function Encrypt(ByVal value As String) As String


        Return _Encrypt(value)
    End Function




    Public Function Decrypt(ByVal value As String)


        Return _Decrypt(value)
    End Function



    Private Function _Encrypt(ByVal value As String) As String
        Dim SecurityKey As String = ConfigurationManager.AppSettings("Encryption")


        Dim utf8 As UTF8Encoding = New UTF8Encoding


        Dim Tbyte As Byte() = utf8.GetBytes(value)  'TempByte


        Using Tmpmd5 As MD5CryptoServiceProvider = New MD5CryptoServiceProvider

            Dim hashvalue As Byte() = Tmpmd5.ComputeHash(utf8.GetBytes(SecurityKey))

            Using tripdes As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider
                tripdes.Key = hashvalue
                tripdes.Mode = CipherMode.ECB
                tripdes.Padding = PaddingMode.PKCS7

                Dim Icryptranform As ICryptoTransform = tripdes.CreateEncryptor

                Dim eResult As Byte() = Icryptranform.TransformFinalBlock(Tbyte, 0, Tbyte.Length)

                Return Convert.ToBase64String(eResult, 0, eResult.Length)



            End Using


        End Using

    End Function


    Private Function _Decrypt(ByVal value As String) As String

        Dim SecurityKey As String = String.Empty


        SecurityKey = ConfigurationManager.AppSettings("Encryption")



        Dim utf8 As UTF8Encoding = New UTF8Encoding


        Dim Tbyte As Byte() = Convert.FromBase64String(value) 'TempByte
        Using Tmpmd5 As MD5CryptoServiceProvider = New MD5CryptoServiceProvider


            Dim hashvalue As Byte() = Tmpmd5.ComputeHash(utf8.GetBytes(SecurityKey))


            Using tripdes As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider

                tripdes.Key = hashvalue
                tripdes.Mode = CipherMode.ECB
                tripdes.Padding = PaddingMode.PKCS7



                Dim Icryptranform As ICryptoTransform = tripdes.CreateDecryptor

                Dim dResult As Byte() = Icryptranform.TransformFinalBlock(Tbyte, 0, Tbyte.Length)

                Return utf8.GetString(dResult)



            End Using


        End Using

    End Function

End Class
