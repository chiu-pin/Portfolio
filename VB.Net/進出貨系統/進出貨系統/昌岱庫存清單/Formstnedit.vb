Imports System.Data.OleDb
Public Class Formstnedit
    Dim dr As OleDbDataReader

    Private Sub Formstnedit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub labstn_TextChanged(sender As Object, e As EventArgs) Handles labstn.TextChanged
        '取得進貨識別碼後讀取進貨資料
        Try
            query = "SELECT 所屬公司名稱,進貨日期,進貨噸數,用途,經銷商 FROM stockin WHERE 進貨識別 =" & labstn.Text & " and 檢查碼=1 "
            retrieveSingleResult(query)

            If dt.Rows.Count > 0 Then
                With dt.Rows(0)
                    owncompany.Text = .Item("所屬公司名稱")

                    stnnumber.Text = .Item("進貨噸數")
                    RichTextBox1.Text = .Item("用途")
                    cbodealer.Text = .Item("經銷商")

                End With
            Else
                owncompany.Text = ""
                stnDateTime.Text = ""
                stnnumber.Text = ""
                RichTextBox1.Text = ""
                cbodealer.Text = ""
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub stnadd_Click(sender As Object, e As EventArgs) Handles stnadd.Click
        '編輯進貨資料存檔
        Try
            If owncompany.SelectedIndex = -1 Or cbodealer.SelectedIndex = -1 Then
                MsgBox("公司名稱或經銷商不存在") '檢查是否有此公司或經銷商存在
            Else
                msgfalse = "編輯錯誤."
                msgtrue = "編輯原物料成功"

                query = "UPDATE  stockin  Set 原物料編號='" & mnum.Text & "' ,所屬公司名稱='" & owncompany.Text & "',進貨日期='" & stnDateTime.Value & "',進貨噸數='" & stnnumber.Text & "',用途='" & RichTextBox1.Text & "',經銷商= '" & cbodealer.Text & "' WHERE 進貨識別 =" & labstn.Text
                cudfunction(query)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub stnDateTime_ValueChanged(sender As Object, e As EventArgs) Handles stnDateTime.ValueChanged

    End Sub
End Class