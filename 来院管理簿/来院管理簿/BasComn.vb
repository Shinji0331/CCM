Module basComn

    Public toolName As String = "Client Condition Management"
    Public dbFilePath As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) &
                                  "\ccmDB.accdb"

    Public Function setsql(ByVal mode As Integer) As String

        Dim resultSql As String = ""

        '' ユーザID取得SQL
        If mode = 1 Then
            resultSql &= "SELECT ユーザID"
            resultSql &= " FROM "

        End If

        Return resultSql

    End Function
End Module
