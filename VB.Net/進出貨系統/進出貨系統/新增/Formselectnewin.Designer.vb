<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Formselecnewin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formselecnewin))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cobcountry = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cobcompany = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.pdselect = New System.Windows.Forms.Button()
        Me.DTGLIST = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.DTGLIST, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Azure
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Button1.Location = New System.Drawing.Point(932, 113)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 50)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "搜尋"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cobcountry
        '
        Me.cobcountry.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.cobcountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cobcountry.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cobcountry.FormattingEnabled = True
        Me.cobcountry.Location = New System.Drawing.Point(763, 121)
        Me.cobcountry.Name = "cobcountry"
        Me.cobcountry.Size = New System.Drawing.Size(118, 38)
        Me.cobcountry.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(648, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 30)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "來源國家"
        '
        'cobcompany
        '
        Me.cobcompany.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.cobcompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cobcompany.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cobcompany.FormattingEnabled = True
        Me.cobcompany.Location = New System.Drawing.Point(518, 121)
        Me.cobcompany.Name = "cobcompany"
        Me.cobcompany.Size = New System.Drawing.Size(118, 38)
        Me.cobcompany.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(355, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 30)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "來源製造公司"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 30)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "原物料名稱"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(205, 120)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(145, 39)
        Me.TextBox1.TabIndex = 19
        '
        'pdselect
        '
        Me.pdselect.BackColor = System.Drawing.Color.Bisque
        Me.pdselect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pdselect.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.pdselect.ForeColor = System.Drawing.Color.Peru
        Me.pdselect.Location = New System.Drawing.Point(932, 182)
        Me.pdselect.Name = "pdselect"
        Me.pdselect.Size = New System.Drawing.Size(111, 52)
        Me.pdselect.TabIndex = 17
        Me.pdselect.Text = "選取"
        Me.pdselect.UseVisualStyleBackColor = False
        '
        'DTGLIST
        '
        Me.DTGLIST.BackgroundColor = System.Drawing.Color.Silver
        Me.DTGLIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTGLIST.Location = New System.Drawing.Point(71, 182)
        Me.DTGLIST.Name = "DTGLIST"
        Me.DTGLIST.RowHeadersWidth = 62
        Me.DTGLIST.RowTemplate.Height = 31
        Me.DTGLIST.Size = New System.Drawing.Size(840, 458)
        Me.DTGLIST.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AllowDrop = True
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("微軟正黑體", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(75, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(177, 40)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "選取原物料"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SandyBrown
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1098, 75)
        Me.Panel1.TabIndex = 28
        '
        'Formselecnewin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1095, 679)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cobcountry)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cobcompany)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.pdselect)
        Me.Controls.Add(Me.DTGLIST)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Formselecnewin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "選取原物料"
        CType(Me.DTGLIST, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents cobcountry As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cobcompany As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents pdselect As Button
    Friend WithEvents DTGLIST As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
End Class
