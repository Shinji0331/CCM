<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.sidebar = New System.Windows.Forms.Panel()
        Me.settingBtn = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PanelFormularios = New System.Windows.Forms.Panel()
        Me.sidebar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(119, 29)
        Me.Panel1.TabIndex = 0
        '
        'sidebar
        '
        Me.sidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.sidebar.Controls.Add(Me.settingBtn)
        Me.sidebar.Controls.Add(Me.Button2)
        Me.sidebar.Controls.Add(Me.Panel1)
        Me.sidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.sidebar.Location = New System.Drawing.Point(0, 0)
        Me.sidebar.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.sidebar.Name = "sidebar"
        Me.sidebar.Size = New System.Drawing.Size(119, 700)
        Me.sidebar.TabIndex = 0
        '
        'settingBtn
        '
        Me.settingBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.settingBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.settingBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.settingBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.settingBtn.FlatAppearance.BorderSize = 0
        Me.settingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.settingBtn.Font = New System.Drawing.Font("メイリオ", 10.0!)
        Me.settingBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.settingBtn.Image = CType(resources.GetObject("settingBtn.Image"), System.Drawing.Image)
        Me.settingBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.settingBtn.Location = New System.Drawing.Point(0, 77)
        Me.settingBtn.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.settingBtn.Name = "settingBtn"
        Me.settingBtn.Size = New System.Drawing.Size(119, 48)
        Me.settingBtn.TabIndex = 6
        Me.settingBtn.Text = "Setting"
        Me.settingBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.settingBtn.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("メイリオ", 10.0!)
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(0, 29)
        Me.Button2.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(119, 48)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "List"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PanelFormularios
        '
        Me.PanelFormularios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFormularios.Location = New System.Drawing.Point(119, 0)
        Me.PanelFormularios.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.PanelFormularios.Name = "PanelFormularios"
        Me.PanelFormularios.Size = New System.Drawing.Size(881, 700)
        Me.PanelFormularios.TabIndex = 2
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1000, 700)
        Me.Controls.Add(Me.PanelFormularios)
        Me.Controls.Add(Me.sidebar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.sidebar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents sidebar As Panel
    Friend WithEvents settingBtn As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PanelFormularios As Panel
End Class
