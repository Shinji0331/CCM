Imports System.Runtime.InteropServices
Public Class frmLogin

#Region "クローズボタン"
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
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

        '' Loginボタンのテキストボックスサイズ調整
        btnLogin.AutoSize = False
        btnLogin.Size = New Size(300, 45)
    End Sub
    '' ログインボタンのborder-radiusの調整
    Private Sub btnLogin_Paint(sender As Object, e As PaintEventArgs) Handles btnLogin.Paint
        Dim buttomPath As Drawing2D.GraphicsPath = New Drawing2D.GraphicsPath
        Dim myRectangle As Rectangle = btnLogin.ClientRectangle
        myRectangle.Inflate(0, 30)
        buttomPath.AddEllipse(myRectangle)
        btnLogin.Region = New Region(buttomPath)
    End Sub
#End Region

#Region "ログインボタン"
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        '' 入力されたユーザIDとパスワードを変数に格納

        '' データベースからユーザIDが合致するパスワードを取得




        '' パスワードが取得されない場合、エラーメッセージ表示

        '' パスワードが存在する場合は、入力値と比較

        '' パスワードが合致しない場合はエラーメッセージ表示

        '' パスワードが合致すればメインフォームへ移動


    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
#End Region


End Class