<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Forminventorylist
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Forminventorylist))
        Me.dtgin = New System.Windows.Forms.DataGridView()
        Me.dtgout = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mname = New System.Windows.Forms.TextBox()
        Me.mcompany = New System.Windows.Forms.TextBox()
        Me.mcountry = New System.Windows.Forms.TextBox()
        Me.pdsearch = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.mnum = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.material = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.msize = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.inquty = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbxstn = New System.Windows.Forms.TextBox()
        Me.tbxsto = New System.Windows.Forms.TextBox()
        Me.insertin = New System.Windows.Forms.Button()
        Me.delin = New System.Windows.Forms.Button()
        Me.insertout = New System.Windows.Forms.Button()
        Me.delsto = New System.Windows.Forms.Button()
        Me.btnrfin = New System.Windows.Forms.Button()
        Me.edstn = New System.Windows.Forms.Button()
        Me.edsto = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.owncompany = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        CType(Me.dtgin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgin
        '
        Me.dtgin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgin.Location = New System.Drawing.Point(516, 154)
        Me.dtgin.Name = "dtgin"
        Me.dtgin.RowHeadersWidth = 62
        Me.dtgin.RowTemplate.Height = 31
        Me.dtgin.Size = New System.Drawing.Size(820, 328)
        Me.dtgin.TabIndex = 16
        '
        'dtgout
        '
        Me.dtgout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgout.Location = New System.Drawing.Point(516, 546)
        Me.dtgout.Name = "dtgout"
        Me.dtgout.RowHeadersWidth = 62
        Me.dtgout.RowTemplate.Height = 31
        Me.dtgout.Size = New System.Drawing.Size(820, 339)
        Me.dtgout.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "名            稱"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 11.0!)
        Me.Label2.Location = New System.Drawing.Point(29, 259)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "來源製造公司"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微軟正黑體", 11.0!)
        Me.Label3.Location = New System.Drawing.Point(29, 308)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "來源製造國家"
        '
        'mname
        '
        Me.mname.Enabled = False
        Me.mname.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.mname.Location = New System.Drawing.Point(193, 102)
        Me.mname.Name = "mname"
        Me.mname.Size = New System.Drawing.Size(173, 39)
        Me.mname.TabIndex = 3
        '
        'mcompany
        '
        Me.mcompany.Enabled = False
        Me.mcompany.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.mcompany.Location = New System.Drawing.Point(193, 252)
        Me.mcompany.Name = "mcompany"
        Me.mcompany.Size = New System.Drawing.Size(173, 39)
        Me.mcompany.TabIndex = 4
        '
        'mcountry
        '
        Me.mcountry.Enabled = False
        Me.mcountry.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.mcountry.Location = New System.Drawing.Point(193, 302)
        Me.mcountry.Name = "mcountry"
        Me.mcountry.Size = New System.Drawing.Size(173, 39)
        Me.mcountry.TabIndex = 5
        '
        'pdsearch
        '
        Me.pdsearch.BackColor = System.Drawing.Color.Azure
        Me.pdsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pdsearch.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.pdsearch.ForeColor = System.Drawing.Color.SteelBlue
        Me.pdsearch.Location = New System.Drawing.Point(273, 53)
        Me.pdsearch.Name = "pdsearch"
        Me.pdsearch.Size = New System.Drawing.Size(93, 36)
        Me.pdsearch.TabIndex = 6
        Me.pdsearch.Text = "尋找"
        Me.pdsearch.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("微軟正黑體", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label8.Location = New System.Drawing.Point(89, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(211, 36)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "原物料詳細資料"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label12.Location = New System.Drawing.Point(29, 55)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(133, 30)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "原物料編號"
        '
        'mnum
        '
        Me.mnum.Enabled = False
        Me.mnum.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.mnum.Location = New System.Drawing.Point(193, 52)
        Me.mnum.Name = "mnum"
        Me.mnum.Size = New System.Drawing.Size(74, 39)
        Me.mnum.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 30)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "材            質"
        '
        'material
        '
        Me.material.Enabled = False
        Me.material.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.material.Location = New System.Drawing.Point(193, 152)
        Me.material.Name = "material"
        Me.material.Size = New System.Drawing.Size(173, 39)
        Me.material.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label5.Location = New System.Drawing.Point(29, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 30)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "直            徑"
        '
        'msize
        '
        Me.msize.Enabled = False
        Me.msize.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.msize.Location = New System.Drawing.Point(193, 202)
        Me.msize.Name = "msize"
        Me.msize.Size = New System.Drawing.Size(173, 39)
        Me.msize.TabIndex = 21
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PapayaWhip
        Me.Panel1.Controls.Add(Me.msize)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.material)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.mcountry)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.mcompany)
        Me.Panel1.Controls.Add(Me.mnum)
        Me.Panel1.Controls.Add(Me.mname)
        Me.Panel1.Controls.Add(Me.pdsearch)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(89, 284)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(397, 348)
        Me.Panel1.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("微軟正黑體", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Tan
        Me.Label6.Location = New System.Drawing.Point(1244, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 25)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "進貨資料"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label7.Location = New System.Drawing.Point(513, 506)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 30)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "出貨噸數"
        '
        'inquty
        '
        Me.inquty.Enabled = False
        Me.inquty.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold)
        Me.inquty.Location = New System.Drawing.Point(240, 136)
        Me.inquty.Name = "inquty"
        Me.inquty.Size = New System.Drawing.Size(149, 39)
        Me.inquty.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label9.Location = New System.Drawing.Point(513, 115)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 30)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "進貨噸數"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("微軟正黑體", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Tan
        Me.Label11.Location = New System.Drawing.Point(1244, 518)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 25)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "出貨資料"
        '
        'tbxstn
        '
        Me.tbxstn.Enabled = False
        Me.tbxstn.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.tbxstn.Location = New System.Drawing.Point(628, 110)
        Me.tbxstn.Name = "tbxstn"
        Me.tbxstn.Size = New System.Drawing.Size(127, 39)
        Me.tbxstn.TabIndex = 31
        '
        'tbxsto
        '
        Me.tbxsto.Enabled = False
        Me.tbxsto.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.tbxsto.Location = New System.Drawing.Point(628, 503)
        Me.tbxsto.Name = "tbxsto"
        Me.tbxsto.Size = New System.Drawing.Size(127, 39)
        Me.tbxsto.TabIndex = 32
        '
        'insertin
        '
        Me.insertin.BackColor = System.Drawing.Color.Bisque
        Me.insertin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.insertin.Font = New System.Drawing.Font("微軟正黑體", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.insertin.ForeColor = System.Drawing.Color.Peru
        Me.insertin.Location = New System.Drawing.Point(1354, 202)
        Me.insertin.Name = "insertin"
        Me.insertin.Size = New System.Drawing.Size(159, 42)
        Me.insertin.TabIndex = 33
        Me.insertin.Text = " 新增進貨"
        Me.insertin.UseVisualStyleBackColor = False
        '
        'delin
        '
        Me.delin.Font = New System.Drawing.Font("微軟正黑體", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.delin.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.delin.Location = New System.Drawing.Point(1354, 431)
        Me.delin.Name = "delin"
        Me.delin.Size = New System.Drawing.Size(159, 42)
        Me.delin.TabIndex = 34
        Me.delin.Text = " 刪除進貨"
        Me.delin.UseVisualStyleBackColor = True
        '
        'insertout
        '
        Me.insertout.BackColor = System.Drawing.Color.Bisque
        Me.insertout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.insertout.Font = New System.Drawing.Font("微軟正黑體", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.insertout.ForeColor = System.Drawing.Color.Peru
        Me.insertout.Location = New System.Drawing.Point(1354, 606)
        Me.insertout.Name = "insertout"
        Me.insertout.Size = New System.Drawing.Size(159, 42)
        Me.insertout.TabIndex = 35
        Me.insertout.Text = " 新增出貨"
        Me.insertout.UseVisualStyleBackColor = False
        '
        'delsto
        '
        Me.delsto.Font = New System.Drawing.Font("微軟正黑體", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.delsto.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.delsto.Location = New System.Drawing.Point(1354, 832)
        Me.delsto.Name = "delsto"
        Me.delsto.Size = New System.Drawing.Size(159, 42)
        Me.delsto.TabIndex = 36
        Me.delsto.Text = "刪除出貨"
        Me.delsto.UseVisualStyleBackColor = True
        '
        'btnrfin
        '
        Me.btnrfin.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnrfin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnrfin.Font = New System.Drawing.Font("微軟正黑體", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.btnrfin.ForeColor = System.Drawing.Color.CadetBlue
        Me.btnrfin.Location = New System.Drawing.Point(1354, 81)
        Me.btnrfin.Name = "btnrfin"
        Me.btnrfin.Size = New System.Drawing.Size(159, 42)
        Me.btnrfin.TabIndex = 37
        Me.btnrfin.Text = "重整資料"
        Me.btnrfin.UseVisualStyleBackColor = False
        '
        'edstn
        '
        Me.edstn.BackColor = System.Drawing.Color.Bisque
        Me.edstn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.edstn.Font = New System.Drawing.Font("微軟正黑體", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.edstn.ForeColor = System.Drawing.Color.Peru
        Me.edstn.Location = New System.Drawing.Point(1354, 154)
        Me.edstn.Name = "edstn"
        Me.edstn.Size = New System.Drawing.Size(159, 42)
        Me.edstn.TabIndex = 39
        Me.edstn.Text = "編輯進貨"
        Me.edstn.UseVisualStyleBackColor = False
        '
        'edsto
        '
        Me.edsto.BackColor = System.Drawing.Color.Bisque
        Me.edsto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.edsto.Font = New System.Drawing.Font("微軟正黑體", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.edsto.ForeColor = System.Drawing.Color.Peru
        Me.edsto.Location = New System.Drawing.Point(1354, 546)
        Me.edsto.Name = "edsto"
        Me.edsto.Size = New System.Drawing.Size(159, 42)
        Me.edsto.TabIndex = 40
        Me.edsto.Text = "編輯出貨"
        Me.edsto.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("微軟正黑體", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label13.Location = New System.Drawing.Point(83, 87)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(127, 36)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "公司名稱"
        '
        'owncompany
        '
        Me.owncompany.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.owncompany.FormattingEnabled = True
        Me.owncompany.Location = New System.Drawing.Point(240, 88)
        Me.owncompany.Name = "owncompany"
        Me.owncompany.Size = New System.Drawing.Size(161, 38)
        Me.owncompany.TabIndex = 42
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SandyBrown
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1643, 75)
        Me.Panel2.TabIndex = 43
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("微軟正黑體", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(60, 20)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(241, 40)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "各公司庫存清單"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(31, 718)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 31
        Me.DataGridView1.Size = New System.Drawing.Size(455, 156)
        Me.DataGridView1.TabIndex = 44
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("微軟正黑體", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button1.Location = New System.Drawing.Point(93, 660)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 42)
        Me.Button1.TabIndex = 46
        Me.Button1.Text = " 刪除訂單"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Bisque
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("微軟正黑體", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Peru
        Me.Button2.Location = New System.Drawing.Point(216, 660)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(106, 42)
        Me.Button2.TabIndex = 47
        Me.Button2.Text = "編輯訂單"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label15.Location = New System.Drawing.Point(26, 665)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(61, 30)
        Me.Label15.TabIndex = 48
        Me.Label15.Text = "訂單"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Bisque
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("微軟正黑體", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Peru
        Me.Button3.Location = New System.Drawing.Point(328, 660)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(110, 42)
        Me.Button3.TabIndex = 49
        Me.Button3.Text = " 新增訂單"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label16.Location = New System.Drawing.Point(101, 195)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(109, 30)
        Me.Label16.TabIndex = 50
        Me.Label16.Text = "預計用量"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label10.Location = New System.Drawing.Point(101, 145)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 30)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "剩餘噸數"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox1.Location = New System.Drawing.Point(240, 186)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(149, 39)
        Me.TextBox1.TabIndex = 52
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label17.Location = New System.Drawing.Point(101, 242)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(85, 30)
        Me.Label17.TabIndex = 53
        Me.Label17.Text = "可用量"
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox2.Location = New System.Drawing.Point(240, 239)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(149, 39)
        Me.TextBox2.TabIndex = 54
        '
        'Forminventorylist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1551, 914)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.owncompany)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.edsto)
        Me.Controls.Add(Me.edstn)
        Me.Controls.Add(Me.btnrfin)
        Me.Controls.Add(Me.delsto)
        Me.Controls.Add(Me.insertout)
        Me.Controls.Add(Me.delin)
        Me.Controls.Add(Me.insertin)
        Me.Controls.Add(Me.tbxsto)
        Me.Controls.Add(Me.tbxstn)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.inquty)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dtgout)
        Me.Controls.Add(Me.dtgin)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Forminventorylist"
        Me.Text = "各公司庫存清單"
        CType(Me.dtgin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtgin As DataGridView
    Friend WithEvents dtgout As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents mname As TextBox
    Friend WithEvents mcompany As TextBox
    Friend WithEvents mcountry As TextBox
    Friend WithEvents pdsearch As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents mnum As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents material As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents msize As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents inquty As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents tbxstn As TextBox
    Friend WithEvents tbxsto As TextBox
    Friend WithEvents insertin As Button
    Friend WithEvents delin As Button
    Friend WithEvents insertout As Button
    Friend WithEvents delsto As Button
    Friend WithEvents btnrfin As Button
    Friend WithEvents edstn As Button
    Friend WithEvents edsto As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents owncompany As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TextBox2 As TextBox
End Class
