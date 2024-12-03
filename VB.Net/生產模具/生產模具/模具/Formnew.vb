Imports System.Data.OleDb
Imports System.IO
Public Class Formnew
    Dim NUM As String
    Private Sub Formnew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        query = "select * from produce where 檢查碼=1"
        retrieve(query, DTGLIST)
        DTGLIST.Columns(10).Visible = False
        PictureBox1.Image = Nothing
        PictureBox2.Image = Nothing
        cobcompany.Items.Add("")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        With Forminsertnew
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

        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            With Formrenew
                .TextBox5.Text = DTGLIST.CurrentRow.Cells(1).Value
                .Show()
            End With
        Catch ex As Exception
            MsgBox("請選取產品")
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        query = "select * from produce where 檢查碼=1"
        retrieve(query, DTGLIST)
        DTGLIST.Columns(10).Visible = False
        PictureBox1.Image = Nothing
    End Sub

    Private Sub cobcompany_SelectedValueChanged(sender As Object, e As EventArgs) Handles cobcompany.SelectedValueChanged

        If cobcompany.Text = "中部" Then
            TextBox3.Text = "B"
            query = "select 公司名稱 from company where 編號 LIKE '%" & TextBox3.Text & "%' "
            combox(query, ComboBox1)
        ElseIf cobcompany.Text = "南部" Then
            TextBox3.Text = "C"
            query = "select 公司名稱 from company where 編號 LIKE '%" & TextBox3.Text & "%' "
            combox(query, ComboBox1)
        ElseIf cobcompany.Text = "北部" Then
            TextBox3.Text = "A"
            query = "select 公司名稱 from company where 編號 LIKE '%" & TextBox3.Text & "%' "
            combox(query, ComboBox1)
        Else
            ComboBox1.Items.Clear()
        End If
    End Sub





    Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedValueChanged
        If ComboBox1.Text <> "" Then
            query = "SELECT 編號 FROM company  WHERE 公司名稱 ='" & ComboBox1.Text & "'"
            retrieveSingleResult(query) '看到這種英文後面括號的都是程式的方法，丟參數進去就會跑結果出來，可以節省重複撰寫的時間
            If dt.Rows.Count > 0 Then
                For Each r As DataRow In dt.Rows
                    TextBox4.Text = r.Item(0)

                Next
            End If
        Else
            TextBox4.Text = ""

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" Then
            If cobcompany.Text <> "" Then
                If TextBox2.Text <> "" Then
                    If ComboBox1.Text <> "" Then
                        query = "select * from produce where 名稱 LIKE '%" & TextBox1.Text & "%' and 客戶代碼 ='" & TextBox4.Text & "' and 編號 LIKE '%" & TextBox2.Text & "%' and 檢查碼=1"
                        retrieve(query, DTGLIST)
                    Else
                        query = "select * from produce where 名稱 LIKE '%" & TextBox1.Text & "%' and 客戶代碼 LIKE '%" & TextBox3.Text & "%' and 編號 LIKE '%" & TextBox2.Text & "%' and 檢查碼=1"
                        retrieve(query, DTGLIST)
                    End If
                Else
                    If ComboBox1.Text <> "" Then
                        query = "select * from produce where 名稱 LIKE '%" & TextBox1.Text & "%' and 客戶代碼 ='" & TextBox4.Text & "' and 檢查碼=1"
                        retrieve(query, DTGLIST)
                    Else
                        query = "select * from produce where 名稱 LIKE '%" & TextBox1.Text & "%' and 客戶代碼 LIKE '%" & TextBox3.Text & "%' and 檢查碼=1"
                        retrieve(query, DTGLIST)
                    End If
                End If
            Else
                If TextBox2.Text <> "" Then
                    query = "select * from produce where 名稱 LIKE '%" & TextBox1.Text & "%' and 編號 LIKE '%" & TextBox2.Text & "%' and 檢查碼=1 "
                    retrieve(query, DTGLIST)
                Else
                    query = "select * from produce where 名稱 LIKE '%" & TextBox1.Text & "%' and 檢查碼=1"
                    retrieve(query, DTGLIST)

                End If
            End If
        Else
            If cobcompany.Text <> "" Then
                If TextBox2.Text <> "" Then
                    If ComboBox1.Text <> "" Then
                        query = "select * from produce where  客戶代碼 ='" & TextBox4.Text & "' and 編號 LIKE '%" & TextBox2.Text & "%' and 檢查碼=1"
                        retrieve(query, DTGLIST)
                    Else
                        query = "select * from produce where  客戶代碼 LIKE '%" & TextBox3.Text & "%' and 編號 LIKE '%" & TextBox2.Text & "%' and 檢查碼=1"
                        retrieve(query, DTGLIST)
                    End If
                Else
                    If ComboBox1.Text <> "" Then
                        query = "select * from produce where   客戶代碼 ='" & TextBox4.Text & "' and 檢查碼=1"
                        retrieve(query, DTGLIST)
                    Else
                        query = "select * from produce where  客戶代碼 LIKE '%" & TextBox3.Text & "%' and 檢查碼=1 "
                        retrieve(query, DTGLIST)
                    End If
                End If
            Else
                If TextBox2.Text <> "" Then
                    query = "select * from produce where   編號 LIKE '%" & TextBox2.Text & "%' and 檢查碼=1"
                    retrieve(query, DTGLIST)
                Else
                    MsgBox("請輸入選取條件")
                End If
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim MsYesNo As MsgBoxResult
        Try
            MsYesNo = MsgBox("確定刪除此筆資料嗎？", MsgBoxStyle.Question Or MsgBoxStyle.OkCancel, "刪除")
            If MsYesNo = MsgBoxResult.Ok Then
                query = "UPDATE produce  Set 檢查碼 = 0 WHERE 產品識別碼 =" & DTGLIST.CurrentRow.Cells(1).Value & " "
                cudfunctionNOmsg(query)

            End If

        Catch ex As Exception
            MsgBox("請勾選要返回倉庫的模具")
        End Try
    End Sub

    Private Sub DTGLIST_CurrentCellChanged(sender As Object, e As EventArgs) Handles DTGLIST.CurrentCellChanged
        Try
            NUM = DTGLIST.CurrentRow.Cells(1).Value
            query = " select * from tblimage where ID ='" & NUM & "'"
            showImage(query)
            PictureBox2.Image = Image.FromFile("C:\Users\user\OneDrive\生產模具\生產模具\圖片昌岱\" & DTGLIST.CurrentRow.Cells(1).Value & ".PNG")
        Catch ex As Exception
            con.Close()
            da.Dispose()
            PictureBox2.Image = Nothing

        End Try

    End Sub
End Class