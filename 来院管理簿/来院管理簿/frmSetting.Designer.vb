<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSetting
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSetting))
        Me.userEntryBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'userEntryBtn
        '
        Me.userEntryBtn.BackColor = System.Drawing.Color.White
        Me.userEntryBtn.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.userEntryBtn.Image = CType(resources.GetObject("userEntryBtn.Image"), System.Drawing.Image)
        Me.userEntryBtn.Location = New System.Drawing.Point(46, 37)
        Me.userEntryBtn.Name = "userEntryBtn"
        Me.userEntryBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.userEntryBtn.Size = New System.Drawing.Size(169, 102)
        Me.userEntryBtn.TabIndex = 0
        Me.userEntryBtn.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "新規ユーザ登録"
        Me.userEntryBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.userEntryBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.userEntryBtn.UseVisualStyleBackColor = False
        '
        'frmSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(683, 360)
        Me.Controls.Add(Me.userEntryBtn)
        Me.Name = "frmSetting"
        Me.Text = "frmSetting"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents userEntryBtn As Button
End Class
