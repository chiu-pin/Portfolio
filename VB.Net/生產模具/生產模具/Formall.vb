Public Class Formall
    Dim AddColumn As New DataGridViewCheckBoxColumn
    Dim tim As Date
    Private Sub Formall_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        query = "select produce.產品識別碼,客戶代碼,名稱,倉庫,模類,總鍛造數,總沖壓數,最後使用日期 from produce left join(select 產品識別碼,inventory.倉庫識別碼 as 倉庫 , 模類,總鍛造數,總沖壓數,最後使用日期 from inventory left join (SELECT 倉庫識別碼,IIF(sum(鍛造數量) Is Not NULL,sum(鍛造數量),0 ) as 總鍛造數,IIF(sum(沖壓數量) Is Not NULL,sum(沖壓數量),0 ) as 總沖壓數,IIF(max(使用日期) Is Not NULL,max(使用日期),0 ) as 最後使用日期 FROM usetime group by 倉庫識別碼) as U on (inventory.倉庫識別碼=U.倉庫識別碼) ) as I on (produce.產品識別碼 = I.產品識別碼)"
        retrieve(query, DataGridView1)
        DataGridView1.Columns.Insert(1, AddColumn)
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            DateTimePicker1.Visible = True
        Else
            DateTimePicker1.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text <> "" Then
            If RadioButton1.Checked = True Then
                Dim dfrom As Date = DateTimePicker1.Text
                query = "select produce.產品識別碼,客戶代碼,名稱,倉庫,模類,總鍛造數,總沖壓數,最後使用日期 from produce left join(select 產品識別碼,inventory.倉庫識別碼 as 倉庫 , 模類,總鍛造數,總沖壓數,最後使用日期 from inventory left join (SELECT 倉庫識別碼,IIF(sum(鍛造數量) Is Not NULL,sum(鍛造數量),0 ) as 總鍛造數,IIF(sum(沖壓數量) Is Not NULL,sum(沖壓數量),0 ) as 總沖壓數,IIF(max(使用日期) Is Not NULL,max(使用日期),0 ) as 最後使用日期 FROM usetime group by 倉庫識別碼) as U on (inventory.倉庫識別碼=U.倉庫識別碼) ) as I on (produce.產品識別碼 = I.產品識別碼) WHERE 最後使用日期 <  #" & dfrom & "#  and 名稱 LIKE '%" & TextBox1.Text & "%' "
                retrieve(query, DataGridView1)
                DataGridView1.Columns.Insert(1, AddColumn)

            Else
                query = "select produce.產品識別碼,客戶代碼,名稱,倉庫,模類,總鍛造數,總沖壓數,最後使用日期 from produce left join(select 產品識別碼,inventory.倉庫識別碼 as 倉庫 , 模類,總鍛造數,總沖壓數,最後使用日期 from inventory left join (SELECT 倉庫識別碼,IIF(sum(鍛造數量) Is Not NULL,sum(鍛造數量),0 ) as 總鍛造數,IIF(sum(沖壓數量) Is Not NULL,sum(沖壓數量),0 ) as 總沖壓數,IIF(max(使用日期) Is Not NULL,max(使用日期),0 ) as 最後使用日期 FROM usetime group by 倉庫識別碼) as U on (inventory.倉庫識別碼=U.倉庫識別碼) ) as I on (produce.產品識別碼 = I.產品識別碼) WHERE  名稱 LIKE '%" & TextBox1.Text & "%'"
                retrieve(query, DataGridView1)
                DataGridView1.Columns.Insert(1, AddColumn)
            End If
        Else
            If RadioButton1.Checked = True Then
                Dim dfrom As Date = DateTimePicker1.Text
                query = "select produce.產品識別碼,客戶代碼,名稱,倉庫,模類,總鍛造數,總沖壓數,最後使用日期 from produce left join(select 產品識別碼,inventory.倉庫識別碼 as 倉庫 , 模類,總鍛造數,總沖壓數,最後使用日期 from inventory left join (SELECT 倉庫識別碼,IIF(sum(鍛造數量) Is Not NULL,sum(鍛造數量),0 ) as 總鍛造數,IIF(sum(沖壓數量) Is Not NULL,sum(沖壓數量),0 ) as 總沖壓數,IIF(max(使用日期) Is Not NULL,max(使用日期),0 ) as 最後使用日期 FROM usetime group by 倉庫識別碼) as U on (inventory.倉庫識別碼=U.倉庫識別碼) ) as I on (produce.產品識別碼 = I.產品識別碼)  WHERE 最後使用日期 <  #" & dfrom & "#"
                retrieve(query, DataGridView1)
                DataGridView1.Columns.Insert(1, AddColumn)

            Else
                MsgBox("請選取挑選條件")
            End If

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For i As Integer = 0 To CInt(DataGridView1.Rows.Count - 2)

            If DataGridView1.Rows(i).Cells(1).Value = False Then

                DataGridView1.Rows(i).Cells(1).Value = True

            End If

        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For ui As Integer = 0 To CInt(DataGridView1.Rows.Count - 2)

            If DataGridView1.Rows(ui).Cells(1).Value = True Then

                DataGridView1.Rows(ui).Cells(1).Value = False

            End If
        Next
    End Sub
End Class