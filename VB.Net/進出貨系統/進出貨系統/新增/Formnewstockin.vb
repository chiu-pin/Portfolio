Imports System.Data.OleDb
Public Class Formnewstockin
    Dim dr As OleDbDataReader
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

    Private Sub Formnewstockin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '公司combobox設定
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
        '經銷商combobox的設定
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
        owncompany.Text = "昌岱"
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        '清空欄位
        stnDateTime.Value = DateTime.Now
        stnnumber.Text = ""
        RichTextBox1.Text = ""
        cbodealer.Text = ""
    End Sub

    Private Sub stnadd_Click(sender As Object, e As EventArgs) Handles stnadd.Click
        '公司及經銷商資料表應先有公司名稱資料
        If owncompany.SelectedIndex = -1 Or cbodealer.SelectedIndex = -1 Then
            MsgBox("請先新增所屬公司/經銷商")
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With Formselecnewin
            .ShowDialog()
            .Focus()
        End With
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class