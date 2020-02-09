Imports System
Imports System.Text
Imports System.Security.Cryptography
Public Class clsPasswordMask

#Region "ハッシュ化"
	Private Function SHA512(ByVal Content As String) As String

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





End Class
