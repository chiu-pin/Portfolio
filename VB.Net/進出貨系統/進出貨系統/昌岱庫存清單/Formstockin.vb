Imports System.Data.OleDb
Public Class Formstockin
    Dim dr As OleDbDataReader
    Dim ss As String
    Dim nn As Long
    Private Sub Formstockin_Load(sender As Object, e As EventArgs) Handles MyBase.Load '新增進貨單
        '公司往下拉combobox設定
        owncompany.Items.Clear()
        con.Open()
        cmd.CommandText = "select * from owncompany where 檢查碼=1"
        cmd.Connection = con
        dr = cmd.ExecuteReader
        While dr.Read
            owncompany.Items.Add(dr.GetString(0))
        End While
        dr.Close()
        con.Close()
        '經銷商往下拉combobox的設定
        con.Open()
        cbodealer.Items.Clear()
        cmd.CommandText = "select * from dealer where 檢查碼=1"
        cmd.Connection = con
        dr = cmd.ExecuteReader
        While dr.Read
            cbodealer.Items.Add(dr.GetString(0))
        End While
        dr.Close()
        con.Close()
        cbodealer.Items.Add(" ")
        cbodealer.Text = " "
    End Sub
    Private Sub stnnumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles stnnumber.KeyPress
        '設定stnnumber只能輸入數字及小數點
        Try

            If e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
                If e.KeyChar <> "." Then
                    If IsNumeric(e.KeyChar) Then e.Handled = False '
                ElseIf stnnumber.Text.Contains(".") Then
                    MessageBox.Show("只能輸入一個小數點")
                Else
                    e.Handled = False
                End If
            End If

        Catch ex As Exception
            logs(ex.Message & " at TXTPRICE_KeyUp")
            MsgBox(ex.Message & " at TXTPRICE_KeyUp")
        End Try
    End Sub

    Private Sub mnum_TextChanged(sender As Object, e As EventArgs) Handles mnum.TextChanged
        '取得原物料編碼後，原物料詳細資料的讀取
        Try
            query = "SELECT 名稱,來源製造公司,來源國家 FROM PRODUCEINFO WHERE 識別碼 =" & mnum.Text
            retrieveSingleResult(query)
            If dt.Rows.Count > 0 Then
                With dt.Rows(0)
                    mname.Text = .Item("名稱")
                    mcompany.Text = .Item("來源製造公司")
                    mcountry.Text = .Item("來源國家")
                End With
            Else
                mname.Text = ""
                mcompany.Text = ""
                mcountry.Text = ""
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub stnadd_Click(sender As Object, e As EventArgs) Handles stnadd.Click
        '新增新的進貨
        If owncompany.SelectedIndex = -1 Or cbodealer.SelectedIndex = -1 Then
            MsgBox("公司名稱或經銷商不存在") '檢查是否有此公司或經銷商存在
        Else
            If mnum.Text <> "" And owncompany.Text <> "" And stnnumber.Text <> "" Then '進貨單據必填欄位
                query = "INSERT INTO stockin (原物料編號,進貨日期,進貨噸數,用途,經銷商,所屬公司名稱,檢查碼) VALUES (" & mnum.Text & " , '" & stnDateTime.Value & "', " & stnnumber.Text & ", '" & RichTextBox1.Text & "', '" & cbodealer.Text & "','" & owncompany.Text & "',1)"
                cudfunctionNOmsg(query)
                LBLMSG.Text = mname.Text & " 進貨紀錄成功."
                LBLMSG.BackColor = Color.AliceBlue
                LBLMSG.ForeColor = Color.Black
                Call btnclear_Click(sender, e)
            Else
                LBLMSG.Text = "進貨單欄位填寫不完整！"
                LBLMSG.BackColor = Color.Red
                LBLMSG.ForeColor = Color.White
            End If
        End If
    End Sub
    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        '清空欄位
        stnDateTime.Value = DateTime.Now
        stnnumber.Text = ""
        RichTextBox1.Text = ""
        cbodealer.Text = ""
    End Sub
End Class