Imports System.Data.SqlClient
Public Class Formorin
    Dim AddColumn As New DataGridViewCheckBoxColumn
    Dim tim As Date
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ComboBox2.Text = "方模" Then '選擇訂購單要開啟方模訂購單還是園模訂購單
            With Forminsertsq
                .TextBox5.Text = TextBox5.Text
                .Show()
            End With
        Else
            With Formccnew
                .TextBox5.Text = TextBox5.Text
                .Show()
            End With
        End If
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        query = "select * from ordersi where 產品識別碼='" & TextBox5.Text & "' and 檢查碼=1" '重整介面
        retrieve(query, DataGridView1)
        DataGridView1.Columns.Insert(1, AddColumn)
        DataGridView1.Columns(2).Visible = False
        DataGridView1.Columns(3).Visible = False
        DataGridView1.Columns(7).Visible = False
        DataGridView1.Sort(DataGridView1.Columns(4), System.ComponentModel.ListSortDirection.Descending)
    End Sub

    Private Sub Formorin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With AddColumn '介面載入的初始質
            .HeaderText = "勾選"
            .Name = "Column Name that will be displayed"
            .Width = 80
        End With
        query = "select * from ordersi where 產品識別碼='" & TextBox5.Text & "' and 檢查碼=1"
        retrieve(query, DataGridView1)
        DataGridView1.Columns.Insert(1, AddColumn)
        DataGridView1.Columns(2).Visible = False
        DataGridView1.Columns(3).Visible = False
        DataGridView1.Columns(7).Visible = False
        DataGridView1.Sort(DataGridView1.Columns(4), System.ComponentModel.ListSortDirection.Descending)
        tim = Format(Now, "yy-MM-dd")
        query = "select 廠商 from fixcom  "
        combox(query, ComboBox1)
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Try
            TextBox10.Text = DataGridView1.CurrentRow.Cells(4).Value '獲得訂購單編號的值
        Catch ex As Exception
            MsgBox(ex.Message & "//請選取一筆紀錄.", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox10.Text = "" Then
            MsgBox("請選取採購單資料") '開啟修改採購單的介面
        Else
            With Forminrewrite
                .TextBox10.Text = TextBox10.Text
                .RichTextBox1.Text = RichTextBox1.Text
                .TextBox5.Text = TextBox5.Text
                .TextBox11.Text = DataGridView1.CurrentRow.Cells(7).Value
                .Show()
            End With
        End If
    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged
        query = "SELECT 備註 FROM remark  WHERE 採購單編號 ='" & DataGridView1.CurrentRow.Cells(4).Value & "'"
        retrieveSingleResult(query) '看到這種英文後面括號的都是程式的方法，丟參數進去就會跑結果出來，可以節省重複撰寫的時間
        If dt.Rows.Count > 0 Then
            For Each r As DataRow In dt.Rows
                RichTextBox1.Text = r.Item(0) '讀取採購單的備註
            Next
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        For i As Integer = 0 To CInt(DataGridView1.Rows.Count - 2) '全選按鈕

            If DataGridView1.Rows(i).Cells(1).Value = False Then

                DataGridView1.Rows(i).Cells(1).Value = True

            End If

        Next
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        For ui As Integer = 0 To CInt(DataGridView1.Rows.Count - 2) '取消全選

            If DataGridView1.Rows(ui).Cells(1).Value = True Then

                DataGridView1.Rows(ui).Cells(1).Value = False

            End If
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try

            For i As Integer = 0 To CInt(DataGridView1.Rows.Count - 1)
                If DataGridView1.Rows(i).Cells(1).Value = True Then
                    query = "INSERT INTO inventory (倉庫識別碼,產品識別碼,採購單編號,模類,到貨日期,狀態,模類名稱) VALUES (" & DataGridView1.Rows(i).Cells(2).Value & " , " & TextBox5.Text & ",'" & TextBox10.Text & "','" & DataGridView1.Rows(i).Cells(5).Value & "', '" & tim & "',1,'" & DataGridView1.Rows(i).Cells(5).Value & "')"
                    cudfunctionNOmsg(query)
                    query = "UPDATE  ordersi  Set 檢查碼 = 0 WHERE 識別碼 =" & DataGridView1.Rows(i).Cells(2).Value & ""
                    cudfunctionNOmsg(query)
                End If
            Next
            Call Button2_Click(sender, e)
            '進倉庫
        Catch ex As Exception
            MsgBox(ex.Message & "//請選取一筆原物料紀錄.", MsgBoxStyle.Exclamation)
        End Try
    End Sub

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


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text <> "" Then
            If RadioButton1.Checked = True Then
                Dim dfrom As Date = DateTimePicker1.Text
                query = "select * from ordersi where   產品識別碼='" & TextBox5.Text & "' and 檢查碼=1 and 預計進貨日 <  #" & dfrom & "#  and 整修廠商='" & ComboBox1.Text & "'"
                retrieve(query, DataGridView1)
                DataGridView1.Columns.Insert(1, AddColumn)
                DataGridView1.Columns(2).Visible = False
                DataGridView1.Columns(3).Visible = False
                DataGridView1.Columns(7).Visible = False
                DataGridView1.Columns(8).Visible = False


            Else
                query = "select * from ordersi where   產品識別碼='" & TextBox5.Text & "' and 檢查碼=1  and 整修廠商='" & ComboBox1.Text & "'"
                retrieve(query, DataGridView1)
                DataGridView1.Columns.Insert(1, AddColumn)
                DataGridView1.Columns(2).Visible = False
                DataGridView1.Columns(3).Visible = False
                DataGridView1.Columns(7).Visible = False
                DataGridView1.Columns(8).Visible = False

            End If
        Else
            If RadioButton1.Checked = True Then
                Dim dfrom As Date = DateTimePicker1.Text
                query = "select * from ordersi where   產品識別碼='" & TextBox5.Text & "' and 檢查碼=1 and 預計進貨日 <  #" & dfrom & "#  "
                retrieve(query, DataGridView1)
                DataGridView1.Columns.Insert(1, AddColumn)
                DataGridView1.Columns(2).Visible = False
                DataGridView1.Columns(3).Visible = False
                DataGridView1.Columns(7).Visible = False
                DataGridView1.Columns(8).Visible = False



            Else
                MsgBox("請選取挑選條件")
            End If
            '搜尋符合條件的訂購單
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            DateTimePicker1.Visible = True
        Else
            DateTimePicker1.Visible = False
        End If
        '選取是否需要日期
    End Sub
End Class