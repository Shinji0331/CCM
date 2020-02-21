Module basSetSql

#Region "ユーザ登録SQL"
    Public Function sqlUserEntry(ByVal userId As String, ByVal password As String) As String

        Dim resultSql As String = ""

        resultSql &= "INSERT INTO USER_INFO (USER_ID, USER_PASS,REGISTRATION_DATE) VALUES "
        resultSql &= "('" & userId & "', '" & password & "', '" & System.DateTime.Now & "')"

        Debug.Print(resultSql)

        Return resultSql

    End Function
#End Region

#Region "取得テストL"
    Public Function getsql() As String

        Dim resultSql As String = ""

        resultSql &= "SELECT USER_ID FROM USER WHERE USER_PASS = '1234'"


        Return resultSql

    End Function
#End Region


End Module
