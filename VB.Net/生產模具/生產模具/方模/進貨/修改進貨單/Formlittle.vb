Public Class Formlittle
    Dim nnn As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If nnn <> 0 And TextBox2.Text <> "" Then
            For number As Integer = 1 To nnn
                query = "INSERT INTO ordersi (產品識別碼,採購單編號,模類,預計進貨日,進貨廠商,檢查碼) VALUES (" & TextBox5.Text & ",'" & TextBox4.Text & "','" & TextBox2.Text & "','" & dtp1.Value & "','" & TextBox1.Text & "',1)"
                cudfunctionNOmsg(query)
                MsgBox("新增成功")
            Next
            Me.Close()
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If TextBox3.Text <> "" Then
            nnn = CInt(TextBox3.Text)
        Else
            nnn = 0
        End If
    End Sub

    Private Sub Formlittle_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class