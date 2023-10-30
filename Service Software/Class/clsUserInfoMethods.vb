Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Configuration





Public Class clsUserInfoMethods



    Public Sub Save(ByVal UserInfo As clsUserInfo)
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim Encoder As clsSecurity = New clsSecurity



        Using con As OleDbConnection = New OleDbConnection(cs)

            Dim dcSavePending As OleDbCommand = New OleDbCommand("qryInsertNewUser", con)
            dcSavePending.CommandType = CommandType.StoredProcedure

            dcSavePending.Parameters.Add("paramUserName", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(UserInfo.UserName), DBNull.Value, UserInfo.UserName)
            dcSavePending.Parameters.Add("paramPassword", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(UserInfo.Password), DBNull.Value, Encoder.Encrypt(UserInfo.Password))
            dcSavePending.Parameters.Add("paramUserType", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(UserInfo.UserType), DBNull.Value, UserInfo.UserType)
            dcSavePending.Parameters.Add("paramInsert", OleDbType.Boolean).Value = If(String.IsNullOrEmpty(UserInfo.Ins), DBNull.Value, UserInfo.Ins)
            dcSavePending.Parameters.Add("paramUpdate", OleDbType.Boolean).Value = If(String.IsNullOrEmpty(UserInfo.Upd), DBNull.Value, UserInfo.Upd)
            dcSavePending.Parameters.Add("paramDelete", OleDbType.Boolean).Value = If(String.IsNullOrEmpty(UserInfo.Del), DBNull.Value, UserInfo.Del)
            dcSavePending.Parameters.Add("paramSelect", OleDbType.Boolean).Value = If(String.IsNullOrEmpty(UserInfo.Del), DBNull.Value, UserInfo.Sel)



            con.Open()

            dcSavePending.ExecuteNonQuery()

        End Using

    End Sub



    Public Sub Update(ByVal UserInfo As clsUserInfo, ByVal SearchID As String)
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim Encoder As clsSecurity = New clsSecurity



        Using con As OleDbConnection = New OleDbConnection(cs)

            Dim dcSavePending As OleDbCommand = New OleDbCommand("qryUpdateUser", con)
            dcSavePending.CommandType = CommandType.StoredProcedure

            dcSavePending.Parameters.Add("paramUserName", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(UserInfo.UserName), DBNull.Value, UserInfo.UserName)
            dcSavePending.Parameters.Add("paramPassword", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(UserInfo.Password), DBNull.Value, Encoder.Encrypt(UserInfo.Password))
            dcSavePending.Parameters.Add("paramUserType", OleDbType.Char, 255).Value = If(String.IsNullOrEmpty(UserInfo.UserType), DBNull.Value, UserInfo.UserType)
            dcSavePending.Parameters.Add("paramInsert", OleDbType.Boolean).Value = If(String.IsNullOrEmpty(UserInfo.Ins), DBNull.Value, UserInfo.Ins)
            dcSavePending.Parameters.Add("paramUpdate", OleDbType.Boolean).Value = If(String.IsNullOrEmpty(UserInfo.Upd), DBNull.Value, UserInfo.Upd)
            dcSavePending.Parameters.Add("paramDelete", OleDbType.Boolean).Value = If(String.IsNullOrEmpty(UserInfo.Del), DBNull.Value, UserInfo.Del)
            dcSavePending.Parameters.Add("paramSelect", OleDbType.Boolean).Value = If(String.IsNullOrEmpty(UserInfo.Del), DBNull.Value, UserInfo.Sel)
            dcSavePending.Parameters.Add("paramUserID", OleDbType.Integer).Value = Convert.ToInt32(SearchID)



            con.Open()

            dcSavePending.ExecuteNonQuery()

        End Using


    End Sub









    Public Sub UserActive(UserID As Integer)
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim Encoder As clsSecurity = New clsSecurity



        Using con As OleDbConnection = New OleDbConnection(cs)

            Dim dcSavePending As OleDbCommand = New OleDbCommand("qryUpdateUserActive", con)
            dcSavePending.CommandType = CommandType.StoredProcedure

            dcSavePending.Parameters.Add("paramActive1", OleDbType.Integer).Value = Integer.Parse("1")
            dcSavePending.Parameters.Add("paramUserID", OleDbType.Integer).Value = UserID






            con.Open()

            dcSavePending.ExecuteNonQuery()

        End Using


    End Sub










    Public Sub UserDeActive(UserID As Integer)
        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim Encoder As clsSecurity = New clsSecurity



        Using con As OleDbConnection = New OleDbConnection(cs)

            Dim dcSavePending As OleDbCommand = New OleDbCommand("qryUpdateUserActive", con)
            dcSavePending.CommandType = CommandType.StoredProcedure

            dcSavePending.Parameters.Add("paramActive1", OleDbType.Integer).Value = Integer.Parse("0")
            dcSavePending.Parameters.Add("paramUserID", OleDbType.Integer).Value = UserID






            con.Open()

            dcSavePending.ExecuteNonQuery()

        End Using


    End Sub




    Public Sub Delete(ByVal Id As String)

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim Encoder As clsSecurity = New clsSecurity



        Using con As OleDbConnection = New OleDbConnection(cs)

            Dim dcSavePending As OleDbCommand = New OleDbCommand("qryDeleteUser", con)
            dcSavePending.CommandType = CommandType.StoredProcedure

            dcSavePending.Parameters.Add("paramUserID", OleDbType.Integer).Value = Convert.ToInt32(Id)



            con.Open()

            dcSavePending.ExecuteNonQuery()

        End Using

    End Sub




    Public Function UserCreadiantial(ByVal UserName, ByVal Password) As Boolean


        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim Encoder As clsSecurity = New clsSecurity
        Dim User As clsUserInfo = New clsUserInfo
        Using con As OleDbConnection = New OleDbConnection(cs)
            Dim dcGetUsers As OleDbCommand = New OleDbCommand("qryUserCrediantial", con)
            dcGetUsers.CommandType = CommandType.StoredProcedure
            dcGetUsers.Parameters.Add("paramUserName", OleDbType.Char, 255).Value = UserName.ToString
            dcGetUsers.Parameters.Add("paramPassword", OleDbType.Char, 255).Value = Encoder.Encrypt(Password.ToString)
            con.Open()
            Dim drGetUser As OleDbDataReader = dcGetUsers.ExecuteReader

            If drGetUser.HasRows = True Then
                Return True
            Else
                Return False
            End If








        End Using



    End Function

    Public Property GetUsers() As IEnumerable(Of clsUserInfo)
        Get
            Dim ListUser As List(Of clsUserInfo) = New List(Of clsUserInfo)

            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString



            Using con As OleDbConnection = New OleDbConnection(cs)

                Dim dcGetUsers As OleDbCommand = New OleDbCommand("qryGetALLUser", con)



                dcGetUsers.CommandType = CommandType.StoredProcedure


                dcGetUsers.Connection = con
                con.Open()
                Dim drGetUser As OleDbDataReader = dcGetUsers.ExecuteReader

                While (drGetUser.Read)
                    Dim tmpUser As clsUserInfo = New clsUserInfo
                    tmpUser.UserID = Convert.ToInt32(drGetUser("UserID").ToString)
                    tmpUser.UserName = drGetUser("UserName").ToString
                    tmpUser.UserType = drGetUser("UserType").ToString
                    tmpUser.Password = drGetUser("Password").ToString
                    tmpUser.Ins = Convert.ToBoolean(drGetUser("Ins").ToString)
                    tmpUser.Upd = Convert.ToBoolean(drGetUser("Upd").ToString)
                    tmpUser.Del = Convert.ToBoolean(drGetUser("Del").ToString)
                    tmpUser.Sel = Convert.ToBoolean(drGetUser("Sel").ToString)
                    tmpUser.Active = Convert.ToInt32(drGetUser("Active").ToString)
                    ListUser.Add(tmpUser)

                End While






            End Using


            Return ListUser

        End Get
        Set(value As IEnumerable(Of clsUserInfo))

        End Set

    End Property








    Public Property GetUsersByID(ByVal ID As Int32) As clsUserInfo
        Get
            Dim tmpUser As clsUserInfo = New clsUserInfo

            Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString



            Using con As OleDbConnection = New OleDbConnection(cs)

                Dim dcGetUsers As OleDbCommand = New OleDbCommand("qryGetUserByID", con)





                dcGetUsers.CommandType = CommandType.StoredProcedure


                dcGetUsers.Parameters.Add("paraUserID", OleDbType.Integer).Value = ID

                dcGetUsers.Connection = con
                con.Open()
                Dim drGetUser As OleDbDataReader = dcGetUsers.ExecuteReader

                While (drGetUser.Read)

                    tmpUser.UserID = Convert.ToInt32(drGetUser("UserID").ToString)
                    tmpUser.UserName = drGetUser("UserName").ToString
                    tmpUser.UserType = drGetUser("UserType").ToString
                    tmpUser.Ins = Convert.ToBoolean(drGetUser("Ins").ToString)
                    tmpUser.Upd = Convert.ToBoolean(drGetUser("Upd").ToString)
                    tmpUser.Del = Convert.ToBoolean(drGetUser("Del").ToString)
                    tmpUser.Sel = Convert.ToBoolean(drGetUser("Sel").ToString)
                    tmpUser.Active = Convert.ToInt32(drGetUser("Active").ToString)


                End While






            End Using


            Return tmpUser

        End Get
        Set(value As clsUserInfo)

        End Set

    End Property






    Public Function UserActive(ByVal UserName As String, ByVal Password As String) As clsUserInfo


        Dim Encryption As clsSecurity = New clsSecurity

        Dim cs As String = ConfigurationManager.ConnectionStrings("DBCService").ConnectionString
        Dim tmpActiveUser As clsUserInfo = New clsUserInfo


        Using con As OleDbConnection = New OleDbConnection(cs)

            Dim dcActiveGetUsers As OleDbCommand = New OleDbCommand("qryGetUserbyCrediantial", con)



            dcActiveGetUsers.CommandType = CommandType.StoredProcedure


            dcActiveGetUsers.Parameters.Add("paramUserName", OleDbType.Char, 255).Value = UserName
            dcActiveGetUsers.Parameters.Add("paramPassword", OleDbType.Char, 255).Value = Encryption.Encrypt(Password)

            dcActiveGetUsers.Connection = con
            con.Open()
            Dim drGeActivetUser As OleDbDataReader = dcActiveGetUsers.ExecuteReader

            If drGeActivetUser.HasRows = True Then
                drGeActivetUser.Read()
                tmpActiveUser.UserID = Convert.ToInt32(drGeActivetUser("UserID").ToString)
                tmpActiveUser.Active = Convert.ToInt32(drGeActivetUser("Active").ToString)

            End If











        End Using


        Return tmpActiveUser



    End Function










End Class
