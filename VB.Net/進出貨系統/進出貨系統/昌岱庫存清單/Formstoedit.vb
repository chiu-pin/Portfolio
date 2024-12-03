Imports System.Data.OleDb
Public Class Formstoedit
    Dim dr As OleDbDataReader
    Private Sub Formstoedit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub

    Private Sub mnum_TextChanged(sender As Object, e As EventArgs) Handles mnum.TextChanged
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
        '編輯出貨資料存檔

        Try
            If owncompany.SelectedIndex = -1 Then
                MsgBox("公司名稱或經銷商不存在") '檢查是否有此公司或經銷商存在
            Else

                msgfalse = "編輯錯誤."
                msgtrue = "編輯原物料成功"

                query = "UPDATE  STOCKOUT Set 原物料編號='" & mnum.Text & "' ,虛擬公司='" & owncompany.Text & "',出庫日期='" & stnDateTime.Value & "',出庫噸數=" & stnnumber.Text & ",用途='" & RichTextBox1.Text & "',指令= '" & tbooo.Text & "' WHERE 出貨識別 =" & Label13.Text
                cudfunction(query)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Label13_TextChanged(sender As Object, e As EventArgs) Handles Label13.TextChanged
        '取得出貨識別碼後讀取出貨資料
        Try
            query = "SELECT 虛擬公司,出庫日期,出庫噸數,用途,指令 FROM STOCKOUT WHERE  出貨識別 =" & Label13.Text & " and 檢查碼=1 "
            retrieveSingleResult(query)

            If dt.Rows.Count > 0 Then
                With dt.Rows(0)
                    owncompany.Text = .Item("虛擬公司")
                    stnDateTime.Value = CDate(.Item("出庫日期"))
                    stnnumber.Text = .Item("出庫噸數")
                    RichTextBox1.Text = .Item("用途")
                    tbooo.Text = .Item("指令")

                End With
            Else
                owncompany.Text = ""
                stnDateTime.Text = ""
                stnnumber.Text = ""
                RichTextBox1.Text = ""
                tbooo.Text = ""
            End If
        Catch ex As Exception

        End Try

    End Sub
End Class