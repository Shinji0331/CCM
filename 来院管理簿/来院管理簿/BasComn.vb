Module basComn

    Public toolName As String = "Client Condition Management"

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
