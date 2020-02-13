<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.pnlTitleBar = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.PictureBox()
        Me.btnMinimize = New System.Windows.Forms.PictureBox()
        Me.pnlTitleBar.SuspendLayout()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTitleBar
        '
        Me.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.pnlTitleBar.Controls.Add(Me.btnMinimize)
        Me.pnlTitleBar.Controls.Add(Me.btnClose)
        Me.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitleBar.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitleBar.Name = "pnlTitleBar"
        Me.pnlTitleBar.Size = New System.Drawing.Size(407, 30)
        Me.pnlTitleBar.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 463)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(407, 15)
        Me.Panel1.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.Location = New System.Drawing.Point(378, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(26, 20)
        Me.btnClose.TabIndex = 2
        Me.btnClose.TabStop = False
        '
        'btnMinimize
        '
        Me.btnMinimize.Image = CType(resources.GetObject("btnMinimize.Image"), System.Drawing.Image)
        Me.btnMinimize.Location = New System.Drawing.Point(346, 12)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(26, 20)
        Me.btnMinimize.TabIndex = 3
        Me.btnMinimize.TabStop = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(407, 478)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlTitleBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.Name = "frmLogin"
        Me.Text = "frmLogin"
        Me.pnlTitleBar.ResumeLayout(False)
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTitleBar As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnMinimize As PictureBox
    Friend WithEvents btnClose As PictureBox
End Class
