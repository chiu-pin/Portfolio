Public Class LoginForm1
    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        LoginUser(UsernameTextBox, PasswordTextBox)
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
End Class