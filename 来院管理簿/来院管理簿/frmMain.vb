Imports System.Runtime.InteropServices
Public Class frmMain
#Region "サイドバーボタンの右パネル反映処理"
    Private Sub AbrirFormEnPanel(Of Miform As {Form, New})()
        Dim Formulario As Form
        Formulario = PanelFormularios.Controls.OfType(Of Miform)().FirstOrDefault()

        If Formulario Is Nothing Then
            Formulario = New Miform()
            Formulario.TopLevel = False
            Formulario.FormBorderStyle = FormBorderStyle.None
            Formulario.Dock = DockStyle.Fill
            PanelFormularios.Controls.Add(Formulario)
            PanelFormularios.Tag = Formulario
            Formulario.Show()
            Formulario.BringToFront()
        Else
            Formulario.BringToFront()
        End If
    End Sub
#End Region

#Region "サイドバーボタン"
    Private Sub settingBtn_Click(sender As Object, e As EventArgs) Handles settingBtn.Click
        AbrirFormEnPanel(Of frmSetting)()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PanelFormularios_Paint(sender As Object, e As PaintEventArgs) Handles PanelFormularios.Paint

    End Sub

#End Region
End Class
