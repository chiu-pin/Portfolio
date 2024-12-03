Imports System.ComponentModel

Public Class Formhome
    Private Sub 新增模具ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 新增模具ToolStripMenuItem.Click
        With Forminsertnew
            .Show()
        End With
    End Sub

    Private Sub 模具全目錄ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 模具全目錄ToolStripMenuItem.Click
        With Formnew
            .Show()
        End With
    End Sub

    Private Sub 方模ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 方模ToolStripMenuItem.Click
        With Form1
            .ComboBox2.Text = "方模"
            .Show()
        End With
    End Sub



    Private Sub 關閉ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 關閉ToolStripMenuItem.Click
        Me.Hide()
        With LoginForm1
            .Close()
        End With
    End Sub

    Private Sub 圓模ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 圓模ToolStripMenuItem.Click
        With Form1
            .ComboBox2.Text = "圓模"
            .Show()
        End With
    End Sub

    Private Sub 廠商ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 廠商ToolStripMenuItem.Click
        With Formlist
            .Show()
        End With
    End Sub

    Private Sub 總表ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 總表ToolStripMenuItem.Click
        With Formall
            .Show()
        End With
    End Sub

    Private Sub 登出ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 登出ToolStripMenuItem.Click
        Me.Hide()
        With LoginForm1
            .UsernameTextBox.Text = ""
            .PasswordTextBox.Text = ""
            .Show()
        End With
    End Sub

    Private Sub 管理ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 管理ToolStripMenuItem.Click
        With Formad
            .Show()
        End With
    End Sub
    Private Sub Formhome_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Hide()
        With LoginForm1
            .Close()
        End With
    End Sub
End Class