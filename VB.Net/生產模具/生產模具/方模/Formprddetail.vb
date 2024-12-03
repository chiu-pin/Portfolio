Public Class Formprddetail
    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        query = "SELECT * FROM produce  WHERE 產品識別碼 =" & TextBox5.Text & ""
        retrieveSingleResult(query) '看到這種英文後面括號的都是程式的方法，丟參數進去就會跑結果出來，可以節省重複撰寫的時間
        If dt.Rows.Count > 0 Then
            For Each r As DataRow In dt.Rows
                TextBox8.Text = r.Item(1)
                TextBox6.Text = r.Item(2)
                TextBox3.Text = r.Item(3)
                TextBox4.Text = r.Item(4)
                TextBox2.Text = r.Item(5)
                TextBox7.Text = r.Item(6)
                TextBox1.Text = r.Item(7)
                RichTextBox2.Text = r.Item(8)
                ComboBox2.Text = r.Item(9)
            Next
        End If
    End Sub
End Class