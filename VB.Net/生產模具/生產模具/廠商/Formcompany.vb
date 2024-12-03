Public Class Formcompany
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" Then
            query = "INSERT INTO fixcom (廠商) VALUES ('" & TextBox1.Text & "' )"
            msgfalse = "請重試"
            msgtrue = "新增成功"
            cudfunction(query)

        End If
    End Sub
End Class