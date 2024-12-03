Public Class Formrefix
    Dim AddColumn As New DataGridViewCheckBoxColumn
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
        query = "select * from fixed,inventory where inventory.倉庫識別碼=fixed.倉庫識別碼 AND  產品識別碼=" & TextBox5.Text & " and 整修單編號='" & TextBox10.Text & "' and 檢查碼=1 and 狀態=2 "
        retrieve(query, DataGridView1)
        DataGridView1.Columns.Insert(1, AddColumn)
        DataGridView1.Columns(2).Visible = False
        DataGridView1.Columns(3).Visible = False
        DataGridView1.Columns(7).Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ti As Date
        ti = Format(dpt1.Value, "yy-MM-dd")
        Try

            query = "UPDATE fixed  Set 預計返還日期 = '" & ti & "' WHERE 整修單編號 ='" & TextBox10.Text & "' and 檢查碼=1"
            cudfunctionNOmsg(query)

        Catch ex As Exception
            MsgBox("錯誤")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ti As Date
        ti = Format(Now(), "yy-MM-dd")
        Try
            For i As Integer = 0 To CInt(DataGridView1.Rows.Count - 2)

                If DataGridView1.Rows(i).Cells(1).Value = True Then
                    query = "INSERT INTO fixedback (整修識別碼,送回日期,檢查碼) VALUES (" & DataGridView1.Rows(i).Cells(2).Value & " , '" & ti & "',1)"
                    cudfunction(query)
                    query = "UPDATE inventory  Set 狀態 = 1 WHERE 倉庫識別碼 =" & DataGridView1.Rows(i).Cells(3).Value & ""
                    cudfunctionNOmsg(query)
                    query = "UPDATE fixed  Set 檢查碼 = 0 WHERE 識別碼 =" & DataGridView1.Rows(i).Cells(2).Value & ""
                    cudfunctionNOmsg(query)


                End If

            Next
        Catch ex As Exception
            MsgBox("請勾選要返回倉庫的模具")
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim MsYesNo As MsgBoxResult
        Try
            MsYesNo = MsgBox("確定刪除此筆資料嗎？", MsgBoxStyle.Question Or MsgBoxStyle.OkCancel, "刪除")
            If MsYesNo = MsgBoxResult.Ok Then
                For i As Integer = 0 To CInt(DataGridView1.Rows.Count - 2)
                    query = "UPDATE inventory  Set 狀態 = 1 WHERE 倉庫識別碼 =" & DataGridView1.Rows(i).Cells(3).Value & ""
                    cudfunctionNOmsg(query)
                Next
                query = "delete from fixed   WHERE 整修單編號 ='" & TextBox10.Text & "'"
                cudfunctionNOmsg(query)
            End If
            Me.Close()
        Catch ex As Exception
            MsgBox("請勾選要返回倉庫的模具")
        End Try
    End Sub

    Private Sub Formrefix_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class