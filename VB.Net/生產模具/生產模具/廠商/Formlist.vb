Public Class Formlist
    Dim AddColumn As New DataGridViewCheckBoxColumn
    Private Sub Formlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        query = "select * from fixed,inventory where inventory.倉庫識別碼=fixed.倉庫識別碼 and 檢查碼=1 and 狀態=2 "
        retrieve(query, DataGridView1)
        DataGridView1.Columns.Insert(1, AddColumn)
        DataGridView1.Columns(2).Visible = False
        DataGridView1.Columns(3).Visible = False
        DataGridView1.Columns(7).Visible = False
        query = "select 廠商 from fixcom  "
        combox(query, ComboBox1)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        For i As Integer = 0 To CInt(DataGridView1.Rows.Count - 2)

            If DataGridView1.Rows(i).Cells(1).Value = False Then

                DataGridView1.Rows(i).Cells(1).Value = True

            End If

        Next
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        For ui As Integer = 0 To CInt(DataGridView1.Rows.Count - 2)

            If DataGridView1.Rows(ui).Cells(1).Value = True Then

                DataGridView1.Rows(ui).Cells(1).Value = False

            End If
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ComboBox1.Text <> "" Then
            If RadioButton1.Checked = True Then
                Dim dfrom As Date = DateTimePicker1.Text
                query = "select * from fixed,inventory where inventory.倉庫識別碼=fixed.倉庫識別碼 and 檢查碼=1 and 狀態=2 and 預計返還日期 <  #" & dfrom & "#  and 整修廠商='" & ComboBox1.Text & "'"
                retrieve(query, DataGridView1)
                DataGridView1.Columns.Insert(1, AddColumn)
                DataGridView1.Columns(2).Visible = False
                DataGridView1.Columns(3).Visible = False
                DataGridView1.Columns(7).Visible = False
                DataGridView1.Columns(8).Visible = False
                DataGridView1.Columns(9).Visible = False
                DataGridView1.Columns(10).Visible = False
                DataGridView1.Columns(11).Visible = False
                DataGridView1.Columns(12).Visible = False
                DataGridView1.Sort(DataGridView1.Columns(4), System.ComponentModel.ListSortDirection.Descending)

            Else
                query = "select * from fixed,inventory where inventory.倉庫識別碼=fixed.倉庫識別碼 AND   檢查碼=1 and 狀態=2 and 整修廠商='" & ComboBox1.Text & "' "
                retrieve(query, DataGridView1)
                DataGridView1.Columns.Insert(1, AddColumn)
                DataGridView1.Columns(2).Visible = False
                DataGridView1.Columns(3).Visible = False
                DataGridView1.Columns(7).Visible = False
                DataGridView1.Columns(8).Visible = False
                DataGridView1.Columns(9).Visible = False
                DataGridView1.Columns(10).Visible = False
                DataGridView1.Columns(11).Visible = False
                DataGridView1.Columns(12).Visible = False
                DataGridView1.Sort(DataGridView1.Columns(4), System.ComponentModel.ListSortDirection.Descending)
            End If
        Else
            If RadioButton1.Checked = True Then
                Dim dfrom As Date = DateTimePicker1.Text
                query = "select * from fixed,inventory where inventory.倉庫識別碼=fixed.倉庫識別碼  and 檢查碼=1 and 狀態=2 and 預計返還日期 <=  #" & dfrom & "#  "
                retrieve(query, DataGridView1)
                DataGridView1.Columns.Insert(1, AddColumn)
                DataGridView1.Columns(2).Visible = False
                DataGridView1.Columns(3).Visible = False
                DataGridView1.Columns(7).Visible = False
                DataGridView1.Columns(8).Visible = False
                DataGridView1.Columns(9).Visible = False
                DataGridView1.Columns(10).Visible = False
                DataGridView1.Columns(11).Visible = False
                DataGridView1.Columns(12).Visible = False
                DataGridView1.Sort(DataGridView1.Columns(4), System.ComponentModel.ListSortDirection.Descending)

            Else
                MsgBox("請選取挑選條件")
            End If

        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            DateTimePicker1.Visible = True
        Else
            DateTimePicker1.Visible = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        query = "select * from fixed,inventory where inventory.倉庫識別碼=fixed.倉庫識別碼 and 檢查碼=1 and 狀態=2 "
        retrieve(query, DataGridView1)
        DataGridView1.Columns.Insert(1, AddColumn)
        DataGridView1.Columns(2).Visible = False
        DataGridView1.Columns(3).Visible = False
        DataGridView1.Columns(7).Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With Formcompany
            .Show()
        End With

    End Sub
End Class