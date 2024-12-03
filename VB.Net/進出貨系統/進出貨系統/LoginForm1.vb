Public Class LoginForm1
    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        LoginUser(UsernameTextBox, PasswordTextBox) '登錄操作
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close() '關閉程式
    End Sub

End Class