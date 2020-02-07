<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetting
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSetting))
        Me.userEntry = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'userEntry
        '
        Me.userEntry.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.userEntry.Image = CType(resources.GetObject("userEntry.Image"), System.Drawing.Image)
        Me.userEntry.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.userEntry.Location = New System.Drawing.Point(34, 37)
        Me.userEntry.Name = "userEntry"
        Me.userEntry.Size = New System.Drawing.Size(172, 76)
        Me.userEntry.TabIndex = 0
        Me.userEntry.Text = "ユーザ登録"
        Me.userEntry.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.userEntry.UseVisualStyleBackColor = True
        '
        'frmSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(683, 360)
        Me.Controls.Add(Me.userEntry)
        Me.Name = "frmSetting"
        Me.Text = "frmSetting"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents userEntry As Button
End Class
