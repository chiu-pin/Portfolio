<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formnewstockin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formnewstockin))
        Me.LBLMSG = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cbodealer = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.owncompany = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.stnnumber = New System.Windows.Forms.TextBox()
        Me.stnDateTime = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.mnum = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.mcountry = New System.Windows.Forms.TextBox()
        Me.mcompany = New System.Windows.Forms.TextBox()
        Me.mname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.stnadd = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'LBLMSG
        '
        Me.LBLMSG.AutoSize = True
        Me.LBLMSG.Font = New System.Drawing.Font("微軟正黑體", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LBLMSG.ForeColor = System.Drawing.Color.Tan
        Me.LBLMSG.Location = New System.Drawing.Point(12, 78)
        Me.LBLMSG.Name = "LBLMSG"
        Me.LBLMSG.Size = New System.Drawing.Size(56, 28)
        Me.LBLMSG.TabIndex = 26
        Me.LBLMSG.Text = "紀錄"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel2.Controls.Add(Me.cbodealer)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.owncompany)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.RichTextBox1)
        Me.Panel2.Controls.Add(Me.stnnumber)
        Me.Panel2.Controls.Add(Me.stnDateTime)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Panel2.Location = New System.Drawing.Point(571, 119)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(472, 485)
        Me.Panel2.TabIndex = 23
        '
        'cbodealer
        '
        Me.cbodealer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbodealer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbodealer.BackColor = System.Drawing.Color.White
        Me.cbodealer.FormattingEnabled = True
        Me.cbodealer.Location = New System.Drawing.Point(181, 385)
        Me.cbodealer.Name = "cbodealer"
        Me.cbodealer.Size = New System.Drawing.Size(250, 38)
        Me.cbodealer.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(53, 388)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(97, 30)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "經 銷 商"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("微軟正黑體", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(186, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 38)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "進貨單"
        '
        'owncompany
        '
        Me.owncompany.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.owncompany.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.owncompany.BackColor = System.Drawing.Color.White
        Me.owncompany.FormattingEnabled = True
        Me.owncompany.Location = New System.Drawing.Point(181, 80)
        Me.owncompany.Name = "owncompany"
        Me.owncompany.Size = New System.Drawing.Size(250, 38)
        Me.owncompany.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(47, 84)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 30)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "所屬公司"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.White
        Me.RichTextBox1.Location = New System.Drawing.Point(181, 250)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(250, 115)
        Me.RichTextBox1.TabIndex = 12
        Me.RichTextBox1.Text = ""
        '
        'stnnumber
        '
        Me.stnnumber.Location = New System.Drawing.Point(181, 193)
        Me.stnnumber.Name = "stnnumber"
        Me.stnnumber.Size = New System.Drawing.Size(250, 39)
        Me.stnnumber.TabIndex = 11
        '
        'stnDateTime
        '
        Me.stnDateTime.Location = New System.Drawing.Point(181, 136)
        Me.stnDateTime.Name = "stnDateTime"
        Me.stnDateTime.Size = New System.Drawing.Size(250, 39)
        Me.stnDateTime.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(47, 249)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 30)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "用        途"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(47, 194)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 30)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "進貨噸數"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 30)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "進貨日期"
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.SystemColors.Control
        Me.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclear.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnclear.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnclear.Location = New System.Drawing.Point(907, 638)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(136, 45)
        Me.btnclear.TabIndex = 25
        Me.btnclear.Text = "清空"
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PapayaWhip
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.mnum)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.mcountry)
        Me.Panel1.Controls.Add(Me.mcompany)
        Me.Panel1.Controls.Add(Me.mname)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Panel1.Location = New System.Drawing.Point(67, 119)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(443, 327)
        Me.Panel1.TabIndex = 22
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Azure
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("微軟正黑體", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Button1.Location = New System.Drawing.Point(296, 76)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 42)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "搜尋"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'mnum
        '
        Me.mnum.BackColor = System.Drawing.Color.White
        Me.mnum.Enabled = False
        Me.mnum.Location = New System.Drawing.Point(210, 78)
        Me.mnum.Name = "mnum"
        Me.mnum.Size = New System.Drawing.Size(80, 39)
        Me.mnum.TabIndex = 16
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.DimGray
        Me.Label12.Location = New System.Drawing.Point(48, 83)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(133, 30)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "原物料編號"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("微軟正黑體", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label8.Location = New System.Drawing.Point(138, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(167, 38)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "原物料資料"
        '
        'mcountry
        '
        Me.mcountry.BackColor = System.Drawing.Color.White
        Me.mcountry.Enabled = False
        Me.mcountry.Location = New System.Drawing.Point(210, 252)
        Me.mcountry.Name = "mcountry"
        Me.mcountry.Size = New System.Drawing.Size(190, 39)
        Me.mcountry.TabIndex = 5
        '
        'mcompany
        '
        Me.mcompany.BackColor = System.Drawing.Color.White
        Me.mcompany.Enabled = False
        Me.mcompany.Location = New System.Drawing.Point(210, 194)
        Me.mcompany.Name = "mcompany"
        Me.mcompany.Size = New System.Drawing.Size(190, 39)
        Me.mcompany.TabIndex = 4
        '
        'mname
        '
        Me.mname.BackColor = System.Drawing.Color.White
        Me.mname.Enabled = False
        Me.mname.Location = New System.Drawing.Point(210, 136)
        Me.mname.Name = "mname"
        Me.mname.Size = New System.Drawing.Size(190, 39)
        Me.mname.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微軟正黑體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(48, 258)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "來源製造國家"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(48, 201)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "來源製造公司"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(48, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "原物料名稱"
        '
        'stnadd
        '
        Me.stnadd.BackColor = System.Drawing.Color.Bisque
        Me.stnadd.Cursor = System.Windows.Forms.Cursors.Default
        Me.stnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.stnadd.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.stnadd.ForeColor = System.Drawing.Color.Peru
        Me.stnadd.Location = New System.Drawing.Point(742, 638)
        Me.stnadd.Name = "stnadd"
        Me.stnadd.Size = New System.Drawing.Size(136, 45)
        Me.stnadd.TabIndex = 24
        Me.stnadd.Text = "新增進貨"
        Me.stnadd.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SandyBrown
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1104, 75)
        Me.Panel3.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("微軟正黑體", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(60, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 40)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "新增進貨"
        '
        'Formnewstockin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1102, 741)
        Me.Controls.Add(Me.LBLMSG)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.stnadd)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Formnewstockin"
        Me.Text = "新增進貨"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBLMSG As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cbodealer As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents owncompany As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents stnnumber As TextBox
    Friend WithEvents stnDateTime As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnclear As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents mnum As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents mcountry As TextBox
    Friend WithEvents mcompany As TextBox
    Friend WithEvents mname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents stnadd As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
End Class
