<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserEntry
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.newUserIdtxt = New System.Windows.Forms.TextBox()
        Me.newUserEntryPassTxt = New System.Windows.Forms.TextBox()
        Me.newUserEntryRePassTxt = New System.Windows.Forms.TextBox()
        Me.newUserEntryBtn = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(21, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "パスワード"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(21, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 12)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "パスワード（確認）"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(21, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ID"
        '
        'newUserIdtxt
        '
        Me.newUserIdtxt.Location = New System.Drawing.Point(116, 40)
        Me.newUserIdtxt.Name = "newUserIdtxt"
        Me.newUserIdtxt.Size = New System.Drawing.Size(215, 19)
        Me.newUserIdtxt.TabIndex = 4
        '
        'newUserEntryPassTxt
        '
        Me.newUserEntryPassTxt.Location = New System.Drawing.Point(116, 83)
        Me.newUserEntryPassTxt.Name = "newUserEntryPassTxt"
        Me.newUserEntryPassTxt.Size = New System.Drawing.Size(215, 19)
        Me.newUserEntryPassTxt.TabIndex = 5
        '
        'newUserEntryRePassTxt
        '
        Me.newUserEntryRePassTxt.Location = New System.Drawing.Point(115, 127)
        Me.newUserEntryRePassTxt.Name = "newUserEntryRePassTxt"
        Me.newUserEntryRePassTxt.Size = New System.Drawing.Size(215, 19)
        Me.newUserEntryRePassTxt.TabIndex = 6
        '
        'newUserEntryBtn
        '
        Me.newUserEntryBtn.BackColor = System.Drawing.Color.White
        Me.newUserEntryBtn.Location = New System.Drawing.Point(23, 173)
        Me.newUserEntryBtn.Name = "newUserEntryBtn"
        Me.newUserEntryBtn.Size = New System.Drawing.Size(119, 34)
        Me.newUserEntryBtn.TabIndex = 7
        Me.newUserEntryBtn.Text = "新規登録"
        Me.newUserEntryBtn.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(211, 173)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(119, 34)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "キャンセル"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'frmUserEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(355, 246)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.newUserEntryBtn)
        Me.Controls.Add(Me.newUserEntryRePassTxt)
        Me.Controls.Add(Me.newUserEntryPassTxt)
        Me.Controls.Add(Me.newUserIdtxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmUserEntry"
        Me.Text = "frmUserEntry"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents newUserIdtxt As TextBox
    Friend WithEvents newUserEntryPassTxt As TextBox
    Friend WithEvents newUserEntryRePassTxt As TextBox
    Friend WithEvents newUserEntryBtn As Button
    Friend WithEvents Button2 As Button
End Class
