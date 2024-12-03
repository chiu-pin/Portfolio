Imports System.Data.OleDb
Public Class Forminventorysearch
    Dim dr As OleDbDataReader
    Private Sub pdselect_Click(sender As Object, e As EventArgs) Handles pdselect.Click
        '將昌岱庫存清單視窗的原物料編號設定好值
        Try
            With Forminventorylist
                .mnum.Text = DTGLIST.CurrentRow.Cells(1).Value
                Me.Close()
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Forminventorysearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '來源製造公司combobox的設定
        con.Open()
        cobcompany.Items.Clear()
        cobcompany.Items.Add("")
        cmd.CommandText = "select DISTINCT 來源製造公司 from PRODUCEINFO"
        cmd.Connection = con
        dr = cmd.ExecuteReader
        While dr.Read
            cobcompany.Items.Add(dr.GetString(0))
        End While
        dr.Close()
        con.Close()
        '來源國家combobox的設定
        con.Open()
        cobcountry.Items.Clear()
        cobcountry.Items.Add("")
        cmd.CommandText = "select DISTINCT 來源國家 from PRODUCEINFO"
        cmd.Connection = con
        dr = cmd.ExecuteReader
        While dr.Read
            cobcountry.Items.Add(dr.GetString(0))
        End While
        dr.Close()
        con.Close()
        '原物料資料的表格呈現,須符合該公司有進貨過的原物料資料
        query = "Select  識別碼 AS 自動編號,名稱 As 原物料名稱,來源製造公司 As 來源製造公司, 來源國家 As 國家 FROM  PRODUCEINFO WHERE (select distinct(識別碼) from stockin where stockin.原物料編號 =PRODUCEINFO.識別碼 and stockin.檢查碼=1 and stockin.所屬公司名稱='" & TextBox2.Text & "')"
        retrieve(query, DTGLIST)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '依據三個搜尋條件(名稱、來源公司、來源國家)的組合,尋找原物料
        If TextBox1.Text <> "" Then
            If cobcompany.Text <> "" Then
                If cobcountry.Text <> "" Then
                    query = "Select 識別碼 AS 自動編號,名稱 As 原物料名稱,來源製造公司 As 來源製造公司, 來源國家  FROM  PRODUCEINFO WHERE (select distinct(識別碼) from stockin where stockin.原物料編號 =PRODUCEINFO.識別碼 and stockin.檢查碼=1 and stockin.所屬公司名稱='" & TextBox2.Text & "' and 名稱 LIKE '%" & TextBox1.Text & "%' AND 來源製造公司 = '" & cobcompany.Text & "'AND 來源國家 = '" & cobcountry.Text & "')"
                    retrieve(query, DTGLIST)
                Else
                    query = "Select 識別碼 AS 自動編號,名稱 As 原物料名稱,來源製造公司 As 來源製造公司, 來源國家  FROM  PRODUCEINFO WHERE (select distinct(識別碼) from stockin where stockin.原物料編號 =PRODUCEINFO.識別碼 and stockin.檢查碼=1 and stockin.所屬公司名稱='" & TextBox2.Text & "' and 名稱 LIKE '%" & TextBox1.Text & "%' AND 來源製造公司 = '" & cobcompany.Text & "')"
                    retrieve(query, DTGLIST)
                End If
            Else
                If cobcountry.Text <> "" Then
                    query = "Select 識別碼 AS 自動編號,名稱 As 原物料名稱,來源製造公司 As 來源製造公司, 來源國家  FROM  PRODUCEINFO WHERE (select distinct(識別碼) from stockin where stockin.原物料編號 =PRODUCEINFO.識別碼 and stockin.檢查碼=1 and stockin.所屬公司名稱='" & TextBox2.Text & "' and 名稱 LIKE '%" & TextBox1.Text & "%' AND 來源國家 = '" & cobcountry.Text & "')"
                    retrieve(query, DTGLIST)
                Else
                    query = "Select 識別碼 AS 自動編號,名稱 As 原物料名稱,來源製造公司 As 來源製造公司, 來源國家 As 國家 FROM  PRODUCEINFO WHERE (select distinct(識別碼) from stockin where stockin.原物料編號 =PRODUCEINFO.識別碼 and stockin.檢查碼=1 and stockin.所屬公司名稱='" & TextBox2.Text & "' and 名稱 LIKE '%" & TextBox1.Text & "%')"
                    retrieve(query, DTGLIST)
                End If

            End If
        Else
            If cobcompany.Text <> "" Then
                If cobcountry.Text <> "" Then
                    query = "Select 識別碼 AS 自動編號,名稱 As 原物料名稱,來源製造公司 As 來源製造公司, 來源國家  FROM  PRODUCEINFO WHERE (select distinct(識別碼) from stockin where stockin.原物料編號 =PRODUCEINFO.識別碼 and stockin.檢查碼=1 and stockin.所屬公司名稱='" & TextBox2.Text & "' AND 來源製造公司 = '" & cobcompany.Text & "'AND 來源國家 = '" & cobcountry.Text & "')"
                    retrieve(query, DTGLIST)
                Else
                    query = "Select 識別碼 AS 自動編號,名稱 As 原物料名稱,來源製造公司 As 來源製造公司, 來源國家  FROM  PRODUCEINFO WHERE  (select distinct(識別碼) from stockin where stockin.原物料編號 =PRODUCEINFO.識別碼 and stockin.檢查碼=1 and stockin.所屬公司名稱='" & TextBox2.Text & "' AND 來源製造公司 = '" & cobcompany.Text & "')"
                    retrieve(query, DTGLIST)
                End If
            Else
                If cobcountry.Text <> "" Then
                    query = "Select 識別碼 AS 自動編號,名稱 As 原物料名稱,來源製造公司 As 來源製造公司, 來源國家  FROM  PRODUCEINFO WHERE (select distinct(識別碼) from stockin where stockin.原物料編號 =PRODUCEINFO.識別碼 and stockin.檢查碼=1 and stockin.所屬公司名稱='" & TextBox2.Text & "' and 來源國家 = '" & cobcountry.Text & "')"
                    retrieve(query, DTGLIST)
                Else
                    MsgBox("請至少輸入一個欄位值查詢")
                End If

            End If
        End If
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
End Class