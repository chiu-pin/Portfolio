<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Formproductlist
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formproductlist))
        Me.DTGLIST = New System.Windows.Forms.DataGridView()
        Me.reefresh = New System.Windows.Forms.Button()
        Me.edit = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.delete = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cobcountry = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cobcompany = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.DTGLIST, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DTGLIST
        '
        Me.DTGLIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTGLIST.Location = New System.Drawing.Point(65, 219)
        Me.DTGLIST.Name = "DTGLIST"
        Me.DTGLIST.RowHeadersWidth = 62
        Me.DTGLIST.RowTemplate.Height = 31
        Me.DTGLIST.Size = New System.Drawing.Size(842, 462)
        Me.DTGLIST.TabIndex = 0
        '
        'reefresh
        '
        Me.reefresh.AllowDrop = True
        Me.reefresh.BackColor = System.Drawing.Color.WhiteSmoke
        Me.reefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.reefresh.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.reefresh.ForeColor = System.Drawing.Color.CadetBlue
        Me.reefresh.Location = New System.Drawing.Point(934, 248)
        Me.reefresh.Name = "reefresh"
        Me.reefresh.Size = New System.Drawing.Size(210, 65)
        Me.reefresh.TabIndex = 1
        Me.reefresh.Text = "重整原物料清單"
        Me.reefresh.UseVisualStyleBackColor = False
        '
        'edit
        '
        Me.edit.AllowDrop = True
        Me.edit.BackColor = System.Drawing.Color.Bisque
        Me.edit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.edit.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.edit.ForeColor = System.Drawing.Color.Peru
        Me.edit.Location = New System.Drawing.Point(934, 341)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(210, 65)
        Me.edit.TabIndex = 2
        Me.edit.Text = "編輯"
        Me.edit.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.AllowDrop = True
        Me.Button2.BackColor = System.Drawing.Color.Bisque
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Peru
        Me.Button2.Location = New System.Drawing.Point(934, 434)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(210, 65)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "新增原物料"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'delete
        '
        Me.delete.AllowDrop = True
        Me.delete.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.delete.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.delete.Location = New System.Drawing.Point(934, 611)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(210, 65)
        Me.delete.TabIndex = 4
        Me.delete.Text = "刪除原物料"
        Me.delete.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(60, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 40)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "原物料清單"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Azure
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Button1.Location = New System.Drawing.Point(754, 132)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 51)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "搜尋"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cobcountry
        '
        Me.cobcountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cobcountry.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cobcountry.FormattingEnabled = True
        Me.cobcountry.Location = New System.Drawing.Point(528, 161)
        Me.cobcountry.Name = "cobcountry"
        Me.cobcountry.Size = New System.Drawing.Size(176, 38)
        Me.cobcountry.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.Location = New System.Drawing.Point(562, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 30)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "來源國家"
        '
        'cobcompany
        '
        Me.cobcompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cobcompany.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cobcompany.FormattingEnabled = True
        Me.cobcompany.Location = New System.Drawing.Point(297, 161)
        Me.cobcompany.Name = "cobcompany"
        Me.cobcompany.Size = New System.Drawing.Size(176, 38)
        Me.cobcompany.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(307, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 30)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "來源製造公司"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.Location = New System.Drawing.Point(88, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 30)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "原物料名稱"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(66, 161)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(176, 39)
        Me.TextBox1.TabIndex = 16
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SandyBrown
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1267, 75)
        Me.Panel1.TabIndex = 23
        '
        'Formproductlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1178, 738)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cobcountry)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cobcompany)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.edit)
        Me.Controls.Add(Me.reefresh)
        Me.Controls.Add(Me.DTGLIST)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Formproductlist"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "原物料清單"
        CType(Me.DTGLIST, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DTGLIST As DataGridView
    Friend WithEvents reefresh As Button
    Friend WithEvents edit As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents delete As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents cobcountry As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cobcompany As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel1 As Panel
End Class
