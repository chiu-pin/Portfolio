Imports System.IO
Public Class Form1

    Private Sub 新增產品ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 新增產品ToolStripMenuItem.Click
        '開啟新增原物料的視窗
        With Formaddproduct
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub 產品清單ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 產品清單ToolStripMenuItem.Click
        '開啟原物料產品清單的視窗
        With Formproductlist
            .Show()
            .Focus()
        End With
    End Sub
    Private Sub 庫存清單ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 庫存清單ToolStripMenuItem.Click
        '開啟各公司庫存清單的視窗
        With Forminventorylist
            .Show()
            .Focus()
        End With
    End Sub
    Private Sub logouttoolmenu_Click(sender As Object, e As EventArgs) Handles logouttoolmenu.Click
        '開啟登入視窗，並把先前的登入資料清除
        Dim acc As String
        acc = LoginForm1.UsernameTextBox.Text
        logoutlog(acc)
        With LoginForm1
            .UsernameTextBox.Text = ""
            .PasswordTextBox.Text = ""
            .Show()
            .Focus()
        End With
        Me.Close()

    End Sub

    Private Sub endmenutool_Click(sender As Object, e As EventArgs) Handles endmenutool.Click
        '關閉程式
        Dim acc As String
        acc = LoginForm1.UsernameTextBox.Text
        logoutlog(acc)
        With LoginForm1
            .Close()
        End With
        Me.Close()
    End Sub
    Private Sub 管理ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 管理ToolStripMenuItem.Click
        '開啟管理視窗
        With frmUser
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub 新增進貨ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 新增進貨ToolStripMenuItem.Click
        With Formnewstockin
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub 新增公司經銷商ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 新增公司經銷商ToolStripMenuItem.Click
        With insertcompany
            .Show()
            .Focus()
        End With
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        With Formsum
            .Show()
            .Focus()
        End With
    End Sub

    Public Sub logoutlog(ByVal account As String)
        Try
            'DECLARE A STRING VARIABLE TO HOLD THE PATH AND THE NAME OF THE TEXT FILE 
            Dim path_file As String = String.Format(Application.StartupPath & "\login\loginlog.log", DateTime.Today.ToString("dd-MMM-yyyy"))
            'DECLARE A BOOLEAN VARIABLE TO DETERMINE WHETHER THE SPECIFIED FILE EXIST.
            Dim exist_file As Boolean = File.Exists(path_file)
            'CALL STREAMWRITER AND USE IT TO CREATE A TXT FILE.
            Using stream_writer As New StreamWriter(path_file, True)
                If Not exist_file Then 'CHECK THE TXT FILE IF IT DOES'NT EXIST.
                    'RESULT
                    'WRITE THE TEXT IN THE FIRST LINE.
                    stream_writer.WriteLine("Log starts")
                End If
                'WRITE THE ERROR MESSAGE.
                stream_writer.WriteLine("登出時間及登出者" & DateTime.Now & " :: " & account)
            End Using
        Catch ex As Exception
            MsgBox(ex.Message & "at logs sub")
        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
