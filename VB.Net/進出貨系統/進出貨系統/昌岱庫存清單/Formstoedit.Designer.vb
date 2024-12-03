<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formstoedit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formstoedit))
        Me.Label13 = New System.Windows.Forms.Label()
        Me.stnadd = New System.Windows.Forms.Button()
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.mnum = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.mcountry = New System.Windows.Forms.TextBox()
        Me.mcompany = New System.Windows.Forms.TextBox()
        Me.mname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("微軟正黑體", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.ForeColor = System.Drawing.Color.Tan
        Me.Label13.Location = New System.Drawing.Point(12, 78)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 28)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "出貨識別"
        '
        'stnadd
        '
        Me.stnadd.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.stnadd.Location = New System.Drawing.Point(903, 622)
        Me.stnadd.Name = "stnadd"
        Me.stnadd.Size = New System.Drawing.Size(138, 45)
        Me.stnadd.TabIndex = 25
        Me.stnadd.Text = "編輯出貨"
        Me.stnadd.UseVisualStyleBackColor = False
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
        Me.Panel2.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Panel2.Location = New System.Drawing.Point(571, 119)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(472, 485)
        Me.Panel2.TabIndex = 24
        '
        'tbooo
        '
        Me.tbooo.Location = New System.Drawing.Point(181, 384)
        Me.tbooo.Name = "tbooo"
        Me.tbooo.Size = New System.Drawing.Size(250, 39)
        Me.tbooo.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(57, 387)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(109, 30)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "指        令"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("微軟正黑體", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label10.Location = New System.Drawing.Point(185, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 38)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "出貨單"
        '
        'owncompany
        '
        Me.owncompany.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.owncompany.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.owncompany.FormattingEnabled = True
        Me.owncompany.Location = New System.Drawing.Point(181, 80)
        Me.owncompany.Name = "owncompany"
        Me.owncompany.Size = New System.Drawing.Size(250, 38)
        Me.owncompany.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(57, 83)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 30)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "所屬公司"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(181, 252)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(250, 120)
        Me.RichTextBox1.TabIndex = 12
        Me.RichTextBox1.Text = ""
        '
        'stnnumber
        '
        Me.stnnumber.Location = New System.Drawing.Point(181, 196)
        Me.stnnumber.Name = "stnnumber"
        Me.stnnumber.Size = New System.Drawing.Size(250, 39)
        Me.stnnumber.TabIndex = 11
        '
        'stnDateTime
        '
        Me.stnDateTime.Location = New System.Drawing.Point(181, 135)
        Me.stnDateTime.Name = "stnDateTime"
        Me.stnDateTime.Size = New System.Drawing.Size(250, 39)
        Me.stnDateTime.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(57, 242)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 30)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "用        途"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(57, 189)
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
        Me.Label5.Size = New System.Drawing.Size(0, 30)
        Me.Label5.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(57, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 30)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "出貨日期"
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
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Panel1.Location = New System.Drawing.Point(67, 119)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(443, 327)
        Me.Panel1.TabIndex = 23
        '
        'mnum
        '
        Me.mnum.Enabled = False
        Me.mnum.Location = New System.Drawing.Point(210, 80)
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
        Me.Label8.Location = New System.Drawing.Point(138, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(167, 38)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "原物料資料"
        '
        'mcountry
        '
        Me.mcountry.Enabled = False
        Me.mcountry.Location = New System.Drawing.Point(210, 242)
        Me.mcountry.Name = "mcountry"
        Me.mcountry.Size = New System.Drawing.Size(190, 39)
        Me.mcountry.TabIndex = 5
        '
        'mcompany
        '
        Me.mcompany.Enabled = False
        Me.mcompany.Location = New System.Drawing.Point(210, 188)
        Me.mcompany.Name = "mcompany"
        Me.mcompany.Size = New System.Drawing.Size(190, 39)
        Me.mcompany.TabIndex = 4
        '
        'mname
        '
        Me.mname.Enabled = False
        Me.mname.Location = New System.Drawing.Point(210, 134)
        Me.mname.Name = "mname"
        Me.mname.Size = New System.Drawing.Size(190, 39)
        Me.mname.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微軟正黑體", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(48, 248)
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SandyBrown
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1152, 75)
        Me.Panel3.TabIndex = 28
        '
        'Formstoedit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1102, 675)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.stnadd)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Formstoedit"
        Me.Text = "Formstoedit"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label13 As Label
    Friend WithEvents stnadd As Button
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
    Friend WithEvents Panel3 As Panel
End Class
