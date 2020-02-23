Public Class frmClientEntry

#Region "初期表示"
    Private Sub frmClientEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '' コンボボックスの初期化
        cmbBirthdayYear.Items.Clear()
        cmbBirthdayMonth.Items.Clear()
        cmbBirthdayDay.Items.Clear()

        '' 生年月日のコンボボックス作成
        '' 年
        For i As Integer = 1900 To Now.Year
            cmbBirthdayYear.Items.Add(i)
        Next
        '' 月
        For i As Integer = 1 To 12
            cmbBirthdayMonth.Items.Add(i)
        Next
        '' 日
        For i As Integer = 1 To 31
            cmbBirthdayDay.Items.Add(i)
        Next
    End Sub
#End Region


End Class