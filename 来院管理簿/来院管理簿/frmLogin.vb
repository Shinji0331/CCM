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

#Region "コントロールカスタマイズ"
    Private Sub CustomizeComponents()

        txtUserName.AutoSize = False
        txtUserName.Size = New Size(300, 35)

        txtPassword.AutoSize = False
        txtPassword.Size = New Size(300, 35)
    End Sub
#End Region

    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        CustomizeComponents()

    End Sub


End Class