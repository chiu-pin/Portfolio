Public Class Formdetai


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        query = "SELECT 模類 FROM inventory where 倉庫識別碼=" & TextBox1.Text & ""
        retrieveSingleResult(query) '看到這種英文後面括號的都是程式的方法，丟參數進去就會跑結果出來，可以節省重複撰寫的時間
        If dt.Rows.Count > 0 Then
            For Each r As DataRow In dt.Rows
                TextBox4.Text = r.Item(0)
            Next
        End If
        query = "SELECT IIF(sum(鍛造數量) Is Not NULL,sum(鍛造數量),0 ),IIF(sum(沖壓數量) Is Not NULL,sum(沖壓數量),0 ),IIF(max(使用日期) Is Not NULL,max(使用日期),0 ) FROM usetime where 倉庫識別碼=" & TextBox1.Text & ""
        retrieveSingleResult(query) '看到這種英文後面括號的都是程式的方法，丟參數進去就會跑結果出來，可以節省重複撰寫的時間
        If dt.Rows.Count > 0 Then
            For Each r As DataRow In dt.Rows
                TextBox2.Text = r.Item(0)
                TextBox3.Text = r.Item(1)
                DateTimePicker1.Value = r.Item(2)
            Next
        End If
        query = "select * from usetime where 倉庫識別碼= " & TextBox1.Text & ""
        retrieve(query, DataGridView1)
        query = "select * from fixed,fixedback where 倉庫識別碼= " & TextBox1.Text & "  and fixedback.整修識別碼=fixed.識別碼"
        retrieve(query, DataGridView2)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox4.Text <> "" Then
            query = "UPDATE inventory  Set 模類名稱 = '" & TextBox4.Text & "' WHERE 倉庫識別碼=" & TextBox1.Text & ""
            cudfunctionNOmsg(query)
        End If

    End Sub


End Class