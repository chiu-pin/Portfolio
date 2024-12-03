<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formhome
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formhome))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.結束ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.登出ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.關閉ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.產品ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.新增模具ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.模具全目錄ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.方模ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.圓模ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.廠商ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.總表ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.管理ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.結束ToolStripMenuItem, Me.產品ToolStripMenuItem, Me.方模ToolStripMenuItem, Me.圓模ToolStripMenuItem, Me.廠商ToolStripMenuItem, Me.總表ToolStripMenuItem, Me.管理ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1074, 38)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '結束ToolStripMenuItem
        '
        Me.結束ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.登出ToolStripMenuItem, Me.關閉ToolStripMenuItem})
        Me.結束ToolStripMenuItem.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.結束ToolStripMenuItem.Name = "結束ToolStripMenuItem"
        Me.結束ToolStripMenuItem.Size = New System.Drawing.Size(73, 34)
        Me.結束ToolStripMenuItem.Text = "結束"
        '
        '登出ToolStripMenuItem
        '
        Me.登出ToolStripMenuItem.Name = "登出ToolStripMenuItem"
        Me.登出ToolStripMenuItem.Size = New System.Drawing.Size(146, 34)
        Me.登出ToolStripMenuItem.Text = "登出"
        '
        '關閉ToolStripMenuItem
        '
        Me.關閉ToolStripMenuItem.Name = "關閉ToolStripMenuItem"
        Me.關閉ToolStripMenuItem.Size = New System.Drawing.Size(146, 34)
        Me.關閉ToolStripMenuItem.Text = "關閉"
        '
        '產品ToolStripMenuItem
        '
        Me.產品ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.新增模具ToolStripMenuItem, Me.模具全目錄ToolStripMenuItem})
        Me.產品ToolStripMenuItem.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.產品ToolStripMenuItem.Name = "產品ToolStripMenuItem"
        Me.產品ToolStripMenuItem.Size = New System.Drawing.Size(73, 34)
        Me.產品ToolStripMenuItem.Text = "模具"
        '
        '新增模具ToolStripMenuItem
        '
        Me.新增模具ToolStripMenuItem.Name = "新增模具ToolStripMenuItem"
        Me.新增模具ToolStripMenuItem.Size = New System.Drawing.Size(218, 34)
        Me.新增模具ToolStripMenuItem.Text = "新增模具"
        '
        '模具全目錄ToolStripMenuItem
        '
        Me.模具全目錄ToolStripMenuItem.Name = "模具全目錄ToolStripMenuItem"
        Me.模具全目錄ToolStripMenuItem.Size = New System.Drawing.Size(218, 34)
        Me.模具全目錄ToolStripMenuItem.Text = "模具全目錄"
        '
        '方模ToolStripMenuItem
        '
        Me.方模ToolStripMenuItem.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.方模ToolStripMenuItem.Name = "方模ToolStripMenuItem"
        Me.方模ToolStripMenuItem.Size = New System.Drawing.Size(73, 34)
        Me.方模ToolStripMenuItem.Text = "方模"
        '
        '圓模ToolStripMenuItem
        '
        Me.圓模ToolStripMenuItem.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.圓模ToolStripMenuItem.Name = "圓模ToolStripMenuItem"
        Me.圓模ToolStripMenuItem.Size = New System.Drawing.Size(73, 34)
        Me.圓模ToolStripMenuItem.Text = "圓模"
        '
        '廠商ToolStripMenuItem
        '
        Me.廠商ToolStripMenuItem.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.廠商ToolStripMenuItem.Name = "廠商ToolStripMenuItem"
        Me.廠商ToolStripMenuItem.Size = New System.Drawing.Size(73, 34)
        Me.廠商ToolStripMenuItem.Text = "廠商"
        '
        '總表ToolStripMenuItem
        '
        Me.總表ToolStripMenuItem.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.總表ToolStripMenuItem.Name = "總表ToolStripMenuItem"
        Me.總表ToolStripMenuItem.Size = New System.Drawing.Size(73, 34)
        Me.總表ToolStripMenuItem.Text = "總表"
        '
        '管理ToolStripMenuItem
        '
        Me.管理ToolStripMenuItem.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.管理ToolStripMenuItem.Name = "管理ToolStripMenuItem"
        Me.管理ToolStripMenuItem.Size = New System.Drawing.Size(73, 34)
        Me.管理ToolStripMenuItem.Text = "管理"
        '
        'Formhome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1074, 674)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Formhome"
        Me.Text = "Formhome"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 結束ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 登出ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 關閉ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 產品ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 新增模具ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 模具全目錄ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 方模ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 圓模ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 廠商ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 總表ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 管理ToolStripMenuItem As ToolStripMenuItem
End Class
