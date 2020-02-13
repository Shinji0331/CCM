Public Class frmUserEntry

#Region "初期表示"
    Private Sub frmUserEntry_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '' パスワードマスク処理
        newUserEntryPassTxt.PasswordChar = "*"c
        newUserEntryRePassTxt.PasswordChar = "*"c

        Me.Opacity = 0.8
    End Sub

#End Region

#Region "新規登録ボタン"
    Private Sub newUserEntryBtn_Click(sender As Object, e As EventArgs) Handles newUserEntryBtn.Click

        '' IDチェック
        If newUserIdtxt.Text = "" Then
            MessageBox.Show("IDを設定してください。", toolName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        '' パスワードチェック
        If newUserEntryPassTxt.Text.Length <= 7 Then
            MessageBox.Show("パスワードは8桁以上を設定してください。", toolName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        '' 確認用パスワードチェック
        If newUserEntryPassTxt.Text <> newUserEntryRePassTxt.Text Then
            MessageBox.Show("パスワードとパスワード（確認）の設定値が同一ではありません。", toolName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If



        '' 入力されたIDがデータベースに存在するかを確認する。


        '' 


    End Sub
#End Region


End Class