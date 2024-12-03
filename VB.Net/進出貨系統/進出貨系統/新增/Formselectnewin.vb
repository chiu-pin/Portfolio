Imports System.Data.OleDb
Public Class Formselecnewin

    Dim dr As OleDbDataReader

    Private Sub pdselect_Click(sender As Object, e As EventArgs) Handles pdselect.Click
        '在原物料資料匯入到新增進貨的視窗
        Try
            With Formnewstockin
                .mnum.Text = DTGLIST.CurrentRow.Cells(1).Value
                Me.Close()
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '查詢條件(來源國家、來源製造公司、名稱)組合下原物料的搜尋結果
        If TextBox1.Text <> "" Then
            If cobcompany.Text <> "" Then
                If cobcountry.Text <> "" Then
                    query = "Select 識別碼 AS 自動編號,名稱 As 原物料名稱,來源製造公司 As 來源製造公司, 來源國家  FROM  PRODUCEINFO WHERE 名稱 LIKE '%" & TextBox1.Text & "%' AND 來源製造公司 = '" & cobcompany.Text & "'AND 來源國家 = '" & cobcountry.Text & "'and 檢查碼=1 "
                    retrieve(query, DTGLIST)
                Else
                    query = "Select 識別碼 AS 自動編號,名稱 As 原物料名稱,來源製造公司 As 來源製造公司, 來源國家  FROM  PRODUCEINFO WHERE 名稱 LIKE '%" & TextBox1.Text & "%' AND 來源製造公司 = '" & cobcompany.Text & "' and 檢查碼=1"
                    retrieve(query, DTGLIST)
                End If
            Else
                If cobcountry.Text <> "" Then
                    query = "Select 識別碼 AS 自動編號,名稱 As 原物料名稱,來源製造公司 As 來源製造公司, 來源國家  FROM  PRODUCEINFO WHERE 名稱 LIKE '%" & TextBox1.Text & "%'AND 來源國家 = '" & cobcountry.Text & "' and 檢查碼=1"
                    retrieve(query, DTGLIST)
                Else
                    query = "Select 識別碼 AS 自動編號,名稱 As 原物料名稱, 直徑 As 直徑,來源製造公司 As 來源製造公司, 來源國家 As 國家 FROM  PRODUCEINFO WHERE 名稱 LIKE '%" & TextBox1.Text & "%' and 檢查碼=1"
                    retrieve(query, DTGLIST)
                End If

            End If
        Else
            If cobcompany.Text <> "" Then
                If cobcountry.Text <> "" Then
                    query = "Select 識別碼 AS 自動編號,名稱 As 原物料名稱,來源製造公司 As 來源製造公司, 來源國家  FROM  PRODUCEINFO WHERE 來源製造公司 = '" & cobcompany.Text & "'AND 來源國家 = '" & cobcountry.Text & "'and 檢查碼=1 "
                    retrieve(query, DTGLIST)
                Else
                    query = "Select 識別碼 AS 自動編號,名稱 As 原物料名稱,來源製造公司 As 來源製造公司, 來源國家  FROM  PRODUCEINFO WHERE  來源製造公司 = '" & cobcompany.Text & "'and 檢查碼=1 "
                    retrieve(query, DTGLIST)
                End If
            Else
                If cobcountry.Text <> "" Then
                    query = "Select 識別碼 AS 自動編號,名稱 As 原物料名稱,來源製造公司 As 來源製造公司, 來源國家  FROM  PRODUCEINFO WHERE 來源國家 = '" & cobcountry.Text & "'and 檢查碼=1 "
                    retrieve(query, DTGLIST)
                Else
                    MsgBox("請至少輸入一個欄位值查詢")
                End If

            End If
        End If
    End Sub

    Private Sub Formselectout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        '原物料資料表格呈現
        query = "Select 識別碼 AS 自動編號,名稱 As 原物料名稱, 直徑 As 直徑,來源製造公司 As 來源製造公司, 來源國家 As 國家 FROM  PRODUCEINFO WHERE 檢查碼=1"
        retrieve(query, DTGLIST)
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub
End Class
