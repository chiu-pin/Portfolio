Public Class Forminrewrite
    Dim AddColumn As New DataGridViewCheckBoxColumn
    Dim MsYesNo As MsgBoxResult


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        With Formlittle
            .TextBox5.Text = TextBox5.Text
            .TextBox4.Text = TextBox10.Text
            .TextBox1.Text = TextBox11.Text
            .Show()
        End With
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        query = "select * from ordersi where 產品識別碼='" & TextBox5.Text & "' and 採購單編號='" & TextBox10.Text & "' and  檢查碼=1 order by 採購單編號  ASC"
        retrieve(query, DataGridView1)
        DataGridView1.Columns.Insert(1, AddColumn)
        DataGridView1.Columns(2).Visible = False
        DataGridView1.Columns(3).Visible = False
        DataGridView1.Columns(7).Visible = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            '刪除原物料資料
            MsYesNo = MsgBox("確定刪除嗎？", MsgBoxStyle.Question Or MsgBoxStyle.OkCancel, "刪除")
            If MsYesNo = MsgBoxResult.Ok Then
                For i As Integer = 0 To CInt(DataGridView1.Rows.Count - 1)
                    If DataGridView1.Rows(i).Cells(1).Value = True Then
                        query = "DELETE FROM ordersi WHERE 識別碼=" & DataGridView1.Rows(i).Cells(2).Value & " "
                        cudfunction(query)

                    End If
                Next
            End If
            Call Button4_Click(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message & "//請選取一筆原物料紀錄.", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub Forminrewrite_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox5_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
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
        query = "select * from ordersi where 產品識別碼='" & TextBox5.Text & "' and 採購單編號='" & TextBox10.Text & "' and  檢查碼=1 order by 採購單編號  ASC"
        retrieve(query, DataGridView1)
        DataGridView1.Columns.Insert(1, AddColumn)
        DataGridView1.Columns(2).Visible = False
        DataGridView1.Columns(3).Visible = False
        DataGridView1.Columns(7).Visible = False
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub
End Class