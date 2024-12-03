<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formstockin
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mname = New System.Windows.Forms.TextBox()
        Me.mcompany = New System.Windows.Forms.TextBox()
        Me.mcountry = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.stnDateTime = New System.Windows.Forms.DateTimePicker()
        Me.stnnumber = New System.Windows.Forms.TextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.mnum = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cbodealer = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.owncompany = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.stnadd = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.LBLMSG = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "原物料名稱"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "來源製造公司"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 216)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "來源製造國家"
        '
        'mname
        '
        Me.mname.Enabled = False
        Me.mname.Location = New System.Drawing.Point(191, 116)
        Me.mname.Name = "mname"
        Me.mname.Size = New System.Drawing.Size(173, 29)
        Me.mname.TabIndex = 3
        '
        'mcompany
        '
        Me.mcompany.Enabled = False
        Me.mcompany.Location = New System.Drawing.Point(191, 162)
        Me.mcompany.Name = "mcompany"
        Me.mcompany.Size = New System.Drawing.Size(173, 29)
        Me.mcompany.TabIndex = 4
        '
        'mcountry
        '
        Me.mcountry.Enabled = False
        Me.mcountry.Location = New System.Drawing.Point(191, 213)
        Me.mcountry.Name = "mcountry"
        Me.mcountry.Size = New System.Drawing.Size(173, 29)
        Me.mcountry.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "進貨日期"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 18)
        Me.Label5.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(50, 194)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 18)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "進貨噸數"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(50, 247)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 18)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "用途"
        '
        'stnDateTime
        '
        Me.stnDateTime.Location = New System.Drawing.Point(148, 134)
        Me.stnDateTime.Name = "stnDateTime"
        Me.stnDateTime.Size = New System.Drawing.Size(200, 29)
        Me.stnDateTime.TabIndex = 10
        '
        'stnnumber
        '
        Me.stnnumber.Location = New System.Drawing.Point(148, 191)
        Me.stnnumber.Name = "stnnumber"
        Me.stnnumber.Size = New System.Drawing.Size(100, 29)
        Me.stnnumber.TabIndex = 11
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(148, 247)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(263, 96)
        Me.RichTextBox1.TabIndex = 12
        Me.RichTextBox1.Text = ""
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.mnum)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.mcountry)
        Me.Panel1.Controls.Add(Me.mcompany)
        Me.Panel1.Controls.Add(Me.mname)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(33, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(495, 263)
        Me.Panel1.TabIndex = 13
        '
        'mnum
        '
        Me.mnum.Enabled = False
        Me.mnum.Location = New System.Drawing.Point(191, 74)
        Me.mnum.Name = "mnum"
        Me.mnum.Size = New System.Drawing.Size(57, 29)
        Me.mnum.TabIndex = 16
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(40, 77)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(98, 18)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "原物料編號"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("新細明體", 20.0!)
        Me.Label8.Location = New System.Drawing.Point(100, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(217, 40)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "原物料資料"
        '
        'Panel2
        '
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
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(33, 312)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(504, 417)
        Me.Panel2.TabIndex = 14
        '
        'cbodealer
        '
        Me.cbodealer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbodealer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbodealer.FormattingEnabled = True
        Me.cbodealer.Location = New System.Drawing.Point(146, 365)
        Me.cbodealer.Name = "cbodealer"
        Me.cbodealer.Size = New System.Drawing.Size(190, 26)
        Me.cbodealer.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(50, 373)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 18)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "經銷商"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("新細明體", 20.0!)
        Me.Label10.Location = New System.Drawing.Point(199, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(137, 40)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "進貨單"
        '
        'owncompany
        '
        Me.owncompany.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.owncompany.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.owncompany.FormattingEnabled = True
        Me.owncompany.Location = New System.Drawing.Point(148, 93)
        Me.owncompany.Name = "owncompany"
        Me.owncompany.Size = New System.Drawing.Size(188, 26)
        Me.owncompany.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(44, 93)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 18)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "所屬公司"
        '
        'stnadd
        '
        Me.stnadd.Location = New System.Drawing.Point(573, 659)
        Me.stnadd.Name = "stnadd"
        Me.stnadd.Size = New System.Drawing.Size(91, 61)
        Me.stnadd.TabIndex = 15
        Me.stnadd.Text = "存檔"
        Me.stnadd.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(573, 580)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(91, 61)
        Me.btnclear.TabIndex = 19
        Me.btnclear.Text = "清空"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'LBLMSG
        '
        Me.LBLMSG.AutoSize = True
        Me.LBLMSG.Location = New System.Drawing.Point(30, 7)
        Me.LBLMSG.Name = "LBLMSG"
        Me.LBLMSG.Size = New System.Drawing.Size(44, 18)
        Me.LBLMSG.TabIndex = 21
        Me.LBLMSG.Text = "紀錄"
        '
        'Formstockin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 741)
        Me.Controls.Add(Me.LBLMSG)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.stnadd)
        Me.Name = "Formstockin"
        Me.Text = "Formstockin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents mname As TextBox
    Friend WithEvents mcompany As TextBox
    Friend WithEvents mcountry As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents stnDateTime As DateTimePicker
    Friend WithEvents stnnumber As TextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents stnadd As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents owncompany As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents mnum As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cbodealer As ComboBox
    Friend WithEvents btnclear As Button
    Friend WithEvents LBLMSG As Label
End Class
