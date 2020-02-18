Module basSetSql

#Region "ユーザ登録SQL"
    Public Function sqlUserEntry(ByVal userId As String, ByVal password As String) As String

        Dim resultSql As String = ""

        resultSql &= "INSERT INTO USER (USER_ID, USER_PASS) VALUES "
        resultSql &= "('" & userId & "', '" & password & "')"


        Return resultSql

    End Function
#End Region


End Module
