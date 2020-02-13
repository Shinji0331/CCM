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
        Me.Label2.Location = New System.Drawing.Point(46, 172)
        Me.Label2.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "パスワード"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(46, 254)
        Me.Label3.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "パスワード（確認）"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(46, 86)
        Me.Label1.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ID"
        '
        'newUserIdtxt
        '
        Me.newUserIdtxt.Location = New System.Drawing.Point(251, 80)
        Me.newUserIdtxt.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.newUserIdtxt.Name = "newUserIdtxt"
        Me.newUserIdtxt.Size = New System.Drawing.Size(461, 31)
        Me.newUserIdtxt.TabIndex = 4
        '
        'newUserEntryPassTxt
        '
        Me.newUserEntryPassTxt.Location = New System.Drawing.Point(251, 166)
        Me.newUserEntryPassTxt.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.newUserEntryPassTxt.Name = "newUserEntryPassTxt"
        Me.newUserEntryPassTxt.Size = New System.Drawing.Size(461, 31)
        Me.newUserEntryPassTxt.TabIndex = 5
        '
        'newUserEntryRePassTxt
        '
        Me.newUserEntryRePassTxt.Location = New System.Drawing.Point(249, 254)
        Me.newUserEntryRePassTxt.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.newUserEntryRePassTxt.Name = "newUserEntryRePassTxt"
        Me.newUserEntryRePassTxt.Size = New System.Drawing.Size(461, 31)
        Me.newUserEntryRePassTxt.TabIndex = 6
        '
        'newUserEntryBtn
        '
        Me.newUserEntryBtn.BackColor = System.Drawing.Color.White
        Me.newUserEntryBtn.Location = New System.Drawing.Point(50, 346)
        Me.newUserEntryBtn.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.newUserEntryBtn.Name = "newUserEntryBtn"
        Me.newUserEntryBtn.Size = New System.Drawing.Size(258, 68)
        Me.newUserEntryBtn.TabIndex = 7
        Me.newUserEntryBtn.Text = "新規登録"
        Me.newUserEntryBtn.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(457, 346)
        Me.Button2.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(258, 68)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "キャンセル"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'frmUserEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(769, 492)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.newUserEntryBtn)
        Me.Controls.Add(Me.newUserEntryRePassTxt)
        Me.Controls.Add(Me.newUserEntryPassTxt)
        Me.Controls.Add(Me.newUserIdtxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "frmUserEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
