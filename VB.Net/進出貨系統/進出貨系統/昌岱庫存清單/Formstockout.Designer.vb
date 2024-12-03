<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Formstockout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formstockout))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.mnum = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.mcountry = New System.Windows.Forms.TextBox()
        Me.mcompany = New System.Windows.Forms.TextBox()
        Me.mname = New System.Windows.Forms.TextBox()
        Me.Label122 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tbooo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.owncompany = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.stnnumber = New System.Windows.Forms.TextBox()
        Me.stnDateTime = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.stnadd = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PapayaWhip
        Me.Panel1.Controls.Add(Me.mnum)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.mcountry)
        Me.Panel1.Controls.Add(Me.mcompany)
        Me.Panel1.Controls.Add(Me.mname)
        Me.Panel1.Controls.Add(Me.Label122)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Panel1.Location = New System.Drawing.Point(67, 119)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(443, 327)
        Me.Panel1.TabIndex = 14
        '
        'mnum
        '
        Me.mnum.Enabled = False
        Me.mnum.Location = New System.Drawing.Point(211, 80)
        Me.mnum.Name = "mnum"
        Me.mnum.Size = New System.Drawing.Size(190, 39)
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
        Me.Label8.Location = New System.Drawing.Point(141, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(167, 38)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "原物料資料"
        '
        'mcountry
        '
        Me.mcountry.Enabled = False
        Me.mcountry.Location = New System.Drawing.Point(211, 239)
        Me.mcountry.Name = "mcountry"
        Me.mcountry.Size = New System.Drawing.Size(190, 39)
        Me.mcountry.TabIndex = 5
        '
        'mcompany
        '
        Me.mcompany.Enabled = False
        Me.mcompany.Location = New System.Drawing.Point(211, 186)
        Me.mcompany.Name = "mcompany"
        Me.mcompany.Size = New System.Drawing.Size(190, 39)
        Me.mcompany.TabIndex = 4
        '
        'mname
        '
        Me.mname.Enabled = False
        Me.mname.Location = New System.Drawing.Point(211, 133)
        Me.mname.Name = "mname"
        Me.mname.Size = New System.Drawing.Size(190, 39)
        Me.mname.TabIndex = 3
        '
        'Label122
        '
        Me.Label122.AutoSize = True
        Me.Label122.Font = New System.Drawing.Font("微軟正黑體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label122.ForeColor = System.Drawing.Color.DimGray
        Me.Label122.Location = New System.Drawing.Point(48, 248)
        Me.Label122.Name = "Label122"
        Me.Label122.Size = New System.Drawing.Size(144, 28)
        Me.Label122.TabIndex = 2
        Me.Label122.Text = "來源製造國家"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(48, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "來源製造公司"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(48, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "原物料名稱"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel2.Controls.Add(Me.tbooo)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.owncompany)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.RichTextBox1)
        Me.Panel2.Controls.Add(Me.stnnumber)
        Me.Panel2.Controls.Add(Me.stnDateTime)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(571, 119)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(472, 485)
        Me.Panel2.TabIndex = 15
        '
        'tbooo
        '
        Me.tbooo.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.tbooo.Location = New System.Drawing.Point(181, 384)
        Me.tbooo.Name = "tbooo"
        Me.tbooo.Size = New System.Drawing.Size(250, 39)
        Me.tbooo.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label11.Location = New System.Drawing.Point(55, 393)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(109, 30)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "指        令"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("微軟正黑體", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label10.Location = New System.Drawing.Point(185, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 38)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "出貨單"
        '
        'owncompany
        '
        Me.owncompany.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.owncompany.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.owncompany.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.owncompany.FormattingEnabled = True
        Me.owncompany.Location = New System.Drawing.Point(181, 80)
        Me.owncompany.Name = "owncompany"
        Me.owncompany.Size = New System.Drawing.Size(250, 38)
        Me.owncompany.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label9.Location = New System.Drawing.Point(55, 83)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 30)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "所屬公司"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(181, 251)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(250, 120)
        Me.RichTextBox1.TabIndex = 12
        Me.RichTextBox1.Text = ""
        '
        'stnnumber
        '
        Me.stnnumber.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.stnnumber.Location = New System.Drawing.Point(181, 195)
        Me.stnnumber.Name = "stnnumber"
        Me.stnnumber.Size = New System.Drawing.Size(250, 39)
        Me.stnnumber.TabIndex = 11
        '
        'stnDateTime
        '
        Me.stnDateTime.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.stnDateTime.Location = New System.Drawing.Point(181, 135)
        Me.stnDateTime.Name = "stnDateTime"
        Me.stnDateTime.Size = New System.Drawing.Size(250, 39)
        Me.stnDateTime.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label7.Location = New System.Drawing.Point(55, 254)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 30)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "用        途"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.Location = New System.Drawing.Point(55, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 30)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "出貨噸數"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 18)
        Me.Label5.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.Location = New System.Drawing.Point(55, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 30)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "出貨日期"
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(752, 632)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(129, 45)
        Me.btnclear.TabIndex = 21
        Me.btnclear.Text = "清空"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'stnadd
        '
        Me.stnadd.Location = New System.Drawing.Point(911, 632)
        Me.stnadd.Name = "stnadd"
        Me.stnadd.Size = New System.Drawing.Size(129, 45)
        Me.stnadd.TabIndex = 20
        Me.stnadd.Text = "存檔"
        Me.stnadd.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("微軟正黑體", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.Tan
        Me.Label13.Location = New System.Drawing.Point(12, 78)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 28)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "紀錄"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.ComboBox1)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.RichTextBox2)
        Me.Panel3.Controls.Add(Me.TextBox2)
        Me.Panel3.Controls.Add(Me.DateTimePicker1)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Panel3.Location = New System.Drawing.Point(582, 78)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(495, 417)
        Me.Panel3.TabIndex = 15
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(148, 373)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(110, 39)
        Me.TextBox1.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 376)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 30)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "指令"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("新細明體", 20.0!)
        Me.Label14.Location = New System.Drawing.Point(199, 14)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(137, 40)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "出貨單"
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(148, 93)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(188, 38)
        Me.ComboBox1.TabIndex = 14
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(44, 93)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(109, 30)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "所屬公司"
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Location = New System.Drawing.Point(148, 247)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(263, 96)
        Me.RichTextBox2.TabIndex = 12
        Me.RichTextBox2.Text = ""
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(148, 191)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 39)
        Me.TextBox2.TabIndex = 11
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(148, 134)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 39)
        Me.DateTimePicker1.TabIndex = 10
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(44, 247)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(61, 30)
        Me.Label16.TabIndex = 9
        Me.Label16.Text = "用途"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(44, 194)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(109, 30)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "出貨噸數"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(38, 87)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(0, 30)
        Me.Label18.TabIndex = 7
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(44, 141)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(109, 30)
        Me.Label19.TabIndex = 6
        Me.Label19.Text = "出貨日期"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.SandyBrown
        Me.Panel4.Controls.Add(Me.Panel3)
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1152, 75)
        Me.Panel4.TabIndex = 27
        '
        'Formstockout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1102, 741)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.stnadd)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Formstockout"
        Me.Text = "Formstockout"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents mnum As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents mcountry As TextBox
    Friend WithEvents mcompany As TextBox
    Friend WithEvents mname As TextBox
    Friend WithEvents Label122 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents tbooo As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents owncompany As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents stnnumber As TextBox
    Friend WithEvents stnDateTime As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnclear As Button
    Friend WithEvents stnadd As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Panel4 As Panel
End Class
