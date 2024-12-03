<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.loginmenutool = New System.Windows.Forms.ToolStripMenuItem()
        Me.logouttoolmenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.endmenutool = New System.Windows.Forms.ToolStripMenuItem()
        Me.product = New System.Windows.Forms.ToolStripMenuItem()
        Me.新增產品ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.產品清單ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.庫存ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.庫存清單ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.進貨 = New System.Windows.Forms.ToolStripMenuItem()
        Me.新增進貨ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.新增公司經銷商ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.管理ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.loginmenutool, Me.product, Me.庫存ToolStripMenuItem, Me.進貨, Me.管理ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(974, 38)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'loginmenutool
        '
        Me.loginmenutool.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.logouttoolmenu, Me.endmenutool})
        Me.loginmenutool.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.loginmenutool.Name = "loginmenutool"
        Me.loginmenutool.Size = New System.Drawing.Size(73, 34)
        Me.loginmenutool.Text = "設定"
        '
        'logouttoolmenu
        '
        Me.logouttoolmenu.Name = "logouttoolmenu"
        Me.logouttoolmenu.Size = New System.Drawing.Size(146, 34)
        Me.logouttoolmenu.Text = "登出"
        '
        'endmenutool
        '
        Me.endmenutool.Name = "endmenutool"
        Me.endmenutool.Size = New System.Drawing.Size(146, 34)
        Me.endmenutool.Text = "結束"
        '
        'product
        '
        Me.product.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.新增產品ToolStripMenuItem, Me.產品清單ToolStripMenuItem})
        Me.product.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.product.Name = "product"
        Me.product.Size = New System.Drawing.Size(97, 34)
        Me.product.Text = "原物料"
        '
        '新增產品ToolStripMenuItem
        '
        Me.新增產品ToolStripMenuItem.Name = "新增產品ToolStripMenuItem"
        Me.新增產品ToolStripMenuItem.Size = New System.Drawing.Size(218, 34)
        Me.新增產品ToolStripMenuItem.Text = "新增原物料"
        '
        '產品清單ToolStripMenuItem
        '
        Me.產品清單ToolStripMenuItem.Name = "產品清單ToolStripMenuItem"
        Me.產品清單ToolStripMenuItem.Size = New System.Drawing.Size(218, 34)
        Me.產品清單ToolStripMenuItem.Text = "原物料清單"
        '
        '庫存ToolStripMenuItem
        '
        Me.庫存ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.庫存清單ToolStripMenuItem})
        Me.庫存ToolStripMenuItem.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.庫存ToolStripMenuItem.Name = "庫存ToolStripMenuItem"
        Me.庫存ToolStripMenuItem.Size = New System.Drawing.Size(73, 34)
        Me.庫存ToolStripMenuItem.Text = "庫存"
        '
        '庫存清單ToolStripMenuItem
        '
        Me.庫存清單ToolStripMenuItem.Name = "庫存清單ToolStripMenuItem"
        Me.庫存清單ToolStripMenuItem.Size = New System.Drawing.Size(266, 34)
        Me.庫存清單ToolStripMenuItem.Text = "各公司庫存清單"
        '
        '進貨
        '
        Me.進貨.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.新增進貨ToolStripMenuItem, Me.新增公司經銷商ToolStripMenuItem})
        Me.進貨.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.進貨.Name = "進貨"
        Me.進貨.Size = New System.Drawing.Size(73, 34)
        Me.進貨.Text = "新增"
        '
        '新增進貨ToolStripMenuItem
        '
        Me.新增進貨ToolStripMenuItem.Name = "新增進貨ToolStripMenuItem"
        Me.新增進貨ToolStripMenuItem.Size = New System.Drawing.Size(276, 34)
        Me.新增進貨ToolStripMenuItem.Text = "新增進貨"
        '
        '新增公司經銷商ToolStripMenuItem
        '
        Me.新增公司經銷商ToolStripMenuItem.Name = "新增公司經銷商ToolStripMenuItem"
        Me.新增公司經銷商ToolStripMenuItem.Size = New System.Drawing.Size(276, 34)
        Me.新增公司經銷商ToolStripMenuItem.Text = "新增公司/經銷商"
        '
        '管理ToolStripMenuItem
        '
        Me.管理ToolStripMenuItem.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.管理ToolStripMenuItem.Name = "管理ToolStripMenuItem"
        Me.管理ToolStripMenuItem.Size = New System.Drawing.Size(73, 34)
        Me.管理ToolStripMenuItem.Text = "管理"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(1370, 48)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(44, 18)
        Me.LinkLabel1.TabIndex = 1
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "總表"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(974, 840)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "昌岱倉儲系統"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents loginmenutool As ToolStripMenuItem
    Friend WithEvents logouttoolmenu As ToolStripMenuItem
    Friend WithEvents endmenutool As ToolStripMenuItem
    Friend WithEvents product As ToolStripMenuItem
    Friend WithEvents 新增產品ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 產品清單ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 庫存ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 庫存清單ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 管理ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 進貨 As ToolStripMenuItem
    Friend WithEvents 新增進貨ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 新增公司經銷商ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
