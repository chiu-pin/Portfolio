Imports System.Data.OleDb
Imports System.IO
Public Class Form1
    Dim NUM As String
    Dim uu As String
    Dim AddColumn As New DataGridViewCheckBoxColumn
    Dim AddColumn1 As New DataGridViewCheckBoxColumn

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        With Formorin
            .TextBox5.Text = TextBox5.Text
            .Show()
        End With
    End Sub



    Private Sub showImage(sql As String)
        Try
            con.Open()
            cmd = New OleDb.OleDbCommand
            With cmd
                .Connection = con
                .CommandText = sql
            End With

            Dim da As New OleDbDataAdapter
            Dim dt As New DataTable

            da.SelectCommand = cmd
            da.Fill(dt)


            Dim by As Byte() = dt.Rows(0)("img")
            Dim ms As MemoryStream = New MemoryStream(by)
            PictureBox1.Image = Image.FromStream(ms)
            ms.Dispose()
            con.Close()
            da.Dispose()
        Catch ex As Exception
            MsgBox("開啟")
        End Try

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            For i As Integer = 0 To CInt(DataGridView3.Rows.Count - 2)
                If DataGridView3.Rows(i).Cells(1).Value = True Then

                    query = "INSERT INTO fixed (倉庫識別碼,整修廠商,預計返還日期,整修單編號,檢查碼) VALUES (" & DataGridView3.Rows(i).Cells(2).Value & " , '" & ComboBox1.Text & "','" & DateTimePicker1.Value & "','" & TextBox10.Text & "',1)"
                    cudfunction(query)
                    query = "UPDATE inventory  Set 狀態 = 2 WHERE 倉庫識別碼 =" & DataGridView3.Rows(i).Cells(2).Value & ""
                    cudfunctionNOmsg(query)

                End If
            Next
            query = "INSERT INTO remarkfixed (整修單編號,備註,檢查碼) VALUES ('" & TextBox10.Text & "','" & RichTextBox1.Text & "',1)"
            cudfunction(query)
            updateAutoNumber(3)
            txtAutoNumber(3, TextBox10)
            ComboBox1.Text = ""
            DateTimePicker1.Value = ""
            RichTextBox1.Text = ""

        Catch ex As Exception
            MsgBox("請勾選要整修的模具")
        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        query = " select * from inventory where 產品識別碼 = " & TextBox5.Text & " and 狀態 = 1 "
        retrieve(query, DataGridView3)
        DataGridView3.Columns.Insert(1, AddColumn)
        DataGridView3.Columns(2).Visible = False
        DataGridView3.Columns(3).Visible = False
        DataGridView3.Columns(4).Visible = False
        DataGridView3.Columns(7).Visible = False
        query = " select 模類 , COUNT(模類) as 數量 from inventory where 產品識別碼 = " & TextBox5.Text & " and 狀態 = 1 group by 模類"
        retrieve(query, DataGridView1)
        query = " select * from inventory where 產品識別碼 = " & TextBox5.Text & " and 狀態 = 3 "
        retrieve(query, DataGridView4)
        DataGridView4.Columns.Insert(1, AddColumn1)
        DataGridView4.Columns(2).Visible = False
        DataGridView4.Columns(3).Visible = False
        DataGridView4.Columns(4).Visible = False
        DataGridView4.Columns(7).Visible = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtAutoNumber(3, TextBox10)
        query = "select 廠商 from fixcom  "
        combox(query, ComboBox1)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        With Formfixed
            .TextBox5.Text = TextBox5.Text
            .Show()
        End With
    End Sub

    Private Sub TextBox5_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        txtAutoNumber(3, TextBox10)
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
        query = " select * from tblimage where ID ='" & TextBox5.Text & "'"
        showImage(query)
        query = " select * from inventory where 產品識別碼 = " & TextBox5.Text & " and 狀態 = 1 "
        retrieve(query, DataGridView3)
        DataGridView3.Columns.Insert(1, AddColumn)
        DataGridView3.Columns(2).Visible = False
        DataGridView3.Columns(3).Visible = False
        DataGridView3.Columns(4).Visible = False
        DataGridView3.Columns(7).Visible = False
        query = " select 模類 , COUNT(模類) as 數量 from inventory where 產品識別碼 = " & TextBox5.Text & " and 狀態 = 1 group by 模類"
        retrieve(query, DataGridView1)
        query = " select * from inventory where 產品識別碼 = " & TextBox5.Text & " and 狀態 = 3 "
        retrieve(query, DataGridView4)
        DataGridView4.Columns.Insert(1, AddColumn1)
        DataGridView4.Columns(2).Visible = False
        DataGridView4.Columns(3).Visible = False
        DataGridView4.Columns(4).Visible = False
        DataGridView4.Columns(7).Visible = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If ComboBox2.Text = "方模" Then
            With Formfindin
                .Show()
            End With
        Else
            With Formccfind
                .Show()
            End With
        End If


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        With Formuse
            .TextBox5.Text = TextBox5.Text
            .Show()
        End With
    End Sub

    Private Sub DataGridView3_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellDoubleClick
        With Formdetai
            .TextBox1.Text = DataGridView3.CurrentRow.Cells(2).Value
            .DateTimePicker2.Value = DataGridView3.CurrentRow.Cells(6).Value
            .Show()
        End With
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            For i As Integer = 0 To CInt(DataGridView4.Rows.Count - 2)
                If DataGridView4.Rows(i).Cells(1).Value = True Then

                    query = "UPDATE inventory  Set 狀態 = 1 WHERE 倉庫識別碼 =" & DataGridView4.Rows(i).Cells(2).Value & ""
                    cudfunctionNOmsg(query)

                End If
            Next
            Call Button1_Click(sender, e)

        Catch ex As Exception
            MsgBox("請勾選要返回倉庫的模具")
        End Try

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        With Formprddetail
            .TextBox5.Text = TextBox5.Text
            .Show()
        End With

    End Sub
End Class
