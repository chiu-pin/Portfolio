Public Class Formuse
    Dim AddColumn As New DataGridViewCheckBoxColumn
    Dim dat As Date
    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        query = " select * from inventory where 產品識別碼 = " & TextBox5.Text & " and 狀態 = 1 "
        retrieve(query, DataGridView1)
        DataGridView1.Columns.Insert(1, AddColumn)

        DataGridView1.Columns(2).Visible = False
        DataGridView1.Columns(3).Visible = False
        DataGridView1.Columns(7).Visible = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If TextBox1.Text = "" Then
                TextBox1.Text = 0
            End If
            If TextBox2.Text = "" Then
                TextBox2.Text = 0
            End If

            For i As Integer = 0 To CInt(DataGridView1.Rows.Count - 2)
                If DataGridView1.Rows(i).Cells(1).Value = True Then
                    query = "INSERT INTO usetime (倉庫識別碼,鍛造數量,沖壓數量,使用日期,檢查碼) VALUES (" & DataGridView1.Rows(i).Cells(2).Value & " , " & TextBox1.Text & ",'" & TextBox2.Text & "','" & DateTimePicker1.Value & "',1)"
                    cudfunction(query)
                    query = "UPDATE  inventory  Set 狀態 = 3 WHERE 倉庫識別碼 =" & DataGridView1.Rows(i).Cells(2).Value & ""
                    cudfunctionNOmsg(query)
                End If
            Next

        Catch ex As Exception
            MsgBox(ex.Message & "//請選取一筆原物料紀錄.", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub Formuse_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class