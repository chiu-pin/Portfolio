<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Formsum
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formsum))
        Me.cbomater = New System.Windows.Forms.ComboBox()
        Me.owncompany = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtgsum = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dtgsum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbomater
        '
        Me.cbomater.BackColor = System.Drawing.SystemColors.MenuBar
        Me.cbomater.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbomater.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cbomater.FormattingEnabled = True
        Me.cbomater.Location = New System.Drawing.Point(136, 101)
        Me.cbomater.Name = "cbomater"
        Me.cbomater.Size = New System.Drawing.Size(230, 38)
        Me.cbomater.TabIndex = 2
        '
        'owncompany
        '
        Me.owncompany.BackColor = System.Drawing.SystemColors.MenuBar
        Me.owncompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.owncompany.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.owncompany.FormattingEnabled = True
        Me.owncompany.Items.AddRange(New Object() {"全部", "昌岱"})
        Me.owncompany.Location = New System.Drawing.Point(520, 101)
        Me.owncompany.Name = "owncompany"
        Me.owncompany.Size = New System.Drawing.Size(218, 38)
        Me.owncompany.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(69, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 30)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "材質"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(405, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 30)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "所屬公司"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Azure
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Button1.Location = New System.Drawing.Point(780, 97)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 45)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "搜尋"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1009, 289)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 18)
        Me.Label3.TabIndex = 9
        '
        'dtgsum
        '
        Me.dtgsum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgsum.Location = New System.Drawing.Point(51, 165)
        Me.dtgsum.Name = "dtgsum"
        Me.dtgsum.RowHeadersWidth = 62
        Me.dtgsum.RowTemplate.Height = 31
        Me.dtgsum.Size = New System.Drawing.Size(1082, 600)
        Me.dtgsum.TabIndex = 10
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SandyBrown
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1184, 75)
        Me.Panel1.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微軟正黑體", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(497, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(182, 50)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "總        表"
        '
        'Formsum
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1181, 820)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dtgsum)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.owncompany)
        Me.Controls.Add(Me.cbomater)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Formsum"
        Me.Text = "總表"
        CType(Me.dtgsum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbomater As ComboBox
    Friend WithEvents owncompany As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents dtgsum As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
End Class
