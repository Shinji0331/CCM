Imports System.Runtime.InteropServices
Public Class frmUserEntry

#Region "初期表示"
    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        CustomizeComponents()
    End Sub
    Private Sub CustomizeComponents()

        '' UserNameのテキストボックスサイズ調整
        txtUserId.AutoSize = False
        txtUserId.Size = New Size(300, 35)

        ''Passwordのテキストボックスサイズ調整
        txtPassword.AutoSize = False
        txtPassword.Size = New Size(300, 35)

        ''Re-enter Passwordのテキストボックスサイズ調整
        txtRePassword.AutoSize = False
        txtRePassword.Size = New Size(300, 35)

        '' Entryボタンのテキストボックスサイズ調整
        btnEntry.AutoSize = False
        btnEntry.Size = New Size(300, 45)

        '' Cancelボタンのテキストボックスサイズ調整
        btnCancel.AutoSize = False
        btnCancel.Size = New Size(300, 45)

        '' パスワードマスク処理
        txtPassword.PasswordChar = "*"c
        txtRePassword.PasswordChar = "*"c
    End Sub
    '' Entryボタンのborder-radiusの調整
    Private Sub btnLogin_Paint(sender As Object, e As PaintEventArgs) Handles btnEntry.Paint
        Dim buttomPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath
        Dim myRectangle As Rectangle = btnEntry.ClientRectangle
        myRectangle.Inflate(0, 30)
        buttomPath.AddEllipse(myRectangle)
        btnEntry.Region = New Region(buttomPath)
    End Sub

    '' Cancelボタンのborder-radiusの調整
    Private Sub btnCancel_Paint(sender As Object, e As PaintEventArgs) Handles btnCancel.Paint
        Dim buttomPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath
        Dim myRectangle As Rectangle = btnCancel.ClientRectangle
        myRectangle.Inflate(0, 30)
        buttomPath.AddEllipse(myRectangle)
        btnCancel.Region = New Region(buttomPath)
    End Sub
#End Region

#Region "クローズボタン"
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
#End Region

#Region "最小化ボタン"
    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
#End Region

#Region "フォームをドラッグで移動させる"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub

    Private Sub pnlTitleBar_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlTitleBar.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
#End Region

#Region "Entryボタン"

    Private Sub btnEntry_Click(sender As Object, e As EventArgs) Handles btnEntry.Click

        Dim hashPass As String
        Dim setsql As String

        '' IDチェック
        If txtUserId.Text = "" Then
            MessageBox.Show("IDを設定してください。", toolName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        '' パスワードチェック
        If txtPassword.Text.Length <= 7 Then
            MessageBox.Show("パスワードは8桁以上を設定してください。", toolName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        '' 確認用パスワードチェック
        If txtPassword.Text <> txtRePassword.Text Then
            MessageBox.Show("パスワードとパスワード（確認）の設定値が同一ではありません。", toolName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        '' ハッシュ化したパスワードを生成
        hashPass = SHA512(txtPassword.Text)

        '' ユーザ登録用SQL生成
        setsql = sqlUserEntry(txtUserId.Text, txtPassword.Text)

        Using dbAccess As New ClsDBAccess(dbFilePath)

        End Using
    End Sub




#End Region

#Region "Calcelボタン"
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
#End Region

End Class