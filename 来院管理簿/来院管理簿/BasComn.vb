Module basComn

    Public toolName As String = "Client Condition Management"
    Public dbFilePath As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) &
                                  "\ccmDB.accdb"



#Region "ハッシュ化"
    Public Function SHA512(ByVal Content As String) As String

        Dim hashString As String = Nothing

        Dim MoLeCuL3 As New Security.Cryptography.SHA512CryptoServiceProvider
        Dim ByteString() As Byte = System.Text.Encoding.ASCII.GetBytes(Content)
        ByteString = MoLeCuL3.ComputeHash(ByteString)

        For Each bt As Byte In ByteString
            hashString &= bt.ToString("x2")
        Next

        Return hashString
    End Function
#End Region
End Module
