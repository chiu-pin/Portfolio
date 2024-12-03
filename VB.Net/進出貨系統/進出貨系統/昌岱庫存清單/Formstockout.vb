Imports System.Data.OleDb

Public Class Formstockout
    Dim dr As OleDbDataReader
    Dim ss As String
    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        stnDateTime.Value = DateTime.Now
        stnnumber.Text = ""
        RichTextBox1.Text = ""
        tbooo.Text = " "
    End Sub

    Private Sub tbooo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbooo.KeyPress, TextBox1.KeyPress
        '限定輸入數字
        Try

            If e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
                If e.KeyChar <> "." Then
                    If IsNumeric(e.KeyChar) Then e.Handled = False '
                Else
                    e.Handled = False
                End If
            End If

        Catch ex As Exception
            logs(ex.Message & " at TXTPRICE_KeyUp")
            MsgBox(ex.Message & " at TXTPRICE_KeyUp")
        End Try
    End Sub

    Private Sub stnnumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles stnnumber.KeyPress, TextBox2.KeyPress
        '限定輸入數字
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
        '原物料編碼取得後，相關原物料資料的存取
        Try
            query = "SELECT 名稱,來源製造公司,來源國家 FROM PRODUCEINFO  WHERE  識別碼 =" & mnum.Text & ""
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
                mcountry.Text = "" '原物料編碼沒成功取得
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Formstockout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '公司cobobox的item設定
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
    End Sub
    Private Sub stnadd_Click(sender As Object, e As EventArgs) Handles stnadd.Click
        '新增出貨，不同條件組合的結果
        If owncompany.SelectedIndex = -1 Then
            MsgBox("公司名稱不存在") '檢查是否有此公司存在
        Else
            If mnum.Text <> "" And owncompany.Text <> "" And stnnumber.Text <> "" Then '出貨單據必填欄位
                query = "INSERT INTO STOCKOUT (原物料編號,出庫日期,出庫噸數,指令,用途,虛擬公司,檢查碼) VALUES (" & mnum.Text & " , '" & stnDateTime.Value & "', " & stnnumber.Text & ", '" & tbooo.Text & "','" & RichTextBox1.Text & "', '" & owncompany.Text & "',1)"
                cudfunctionNOmsg(query)
                Label13.Text = mname.Text & " 出貨紀錄成功."
                Label13.BackColor = Color.Aquamarine
                Label13.ForeColor = Color.Black
                Call btnclear_Click(sender, e)
            Else
                Label13.Text = "進貨單欄位填寫不完整！"
                Label13.BackColor = Color.Red
                Label13.ForeColor = Color.White
            End If
        End If

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub
End Class