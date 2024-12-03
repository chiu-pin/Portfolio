Imports System.Data.OleDb
Public Class Formproductlist
    Dim dr As OleDbDataReader
    Dim MsYesNo As MsgBoxResult
    Private Sub Formproductlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmMaxMinSize(Me, 905, 520)

        query = "Select 識別碼 AS 自動編號,名稱 As 原物料名稱, 直徑 As 直徑,來源製造公司 As 來源製造公司, 來源國家 As 國家 FROM  PRODUCEINFO WHERE 檢查碼=1"
        retrieve(query, DTGLIST) '原物料資料表格呈現
        DTGLIST.Columns(0).Visible = False
        MaximizeBox = False

        con.Open() '來源製造公司的item設定
        cobcompany.Items.Clear()
        cmd.CommandText = "select DISTINCT 來源製造公司 from PRODUCEINFO"
        cmd.Connection = con
        dr = cmd.ExecuteReader
        While dr.Read
            cobcompany.Items.Add(dr.GetString(0))
        End While
        dr.Close()
        con.Close()

        con.Open() '來源國家的item設定
        cobcountry.Items.Clear()
        cmd.CommandText = "select DISTINCT 來源國家 from PRODUCEINFO"
        cmd.Connection = con
        dr = cmd.ExecuteReader
        While dr.Read
            cobcountry.Items.Add(dr.GetString(0))
        End While
        dr.Close()
        con.Close()
    End Sub
    Private Sub reefresh_Click(sender As Object, e As EventArgs) Handles reefresh.Click
        query = "Select 識別碼 AS 自動編號,名稱 As 原物料名稱, 直徑 As 直徑,來源製造公司 As 來源製造公司, 來源國家 As 國家 FROM  PRODUCEINFO WHERE 檢查碼=1"
        retrieve(query, DTGLIST) '重整原物料資料表
        DTGLIST.Columns(0).Visible = False
    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        Try
            '刪除原物料資料
            MsYesNo = MsgBox("確定刪除此筆資料嗎？", MsgBoxStyle.Question Or MsgBoxStyle.OkCancel, "刪除")
            If MsYesNo = MsgBoxResult.Ok Then
                MsgBox("已經刪除", MsgBoxStyle.Information, "刪除")
                msgfalse = "Failed To delete"
                msgtrue = "Product has been deleted."
                query = "UPDATE PRODUCEINFO Set 檢查碼=0 WHERE 識別碼 = " & DTGLIST.CurrentRow.Cells(1).Value
                cudfunction(query)
                query = "UPDATE stockin Set 檢查碼=0 WHERE 原物料編號 = " & DTGLIST.CurrentRow.Cells(1).Value '相關庫存資料刪掉
                cudfunctionNOmsg(query)
                query = "UPDATE STOCKOUT Set 檢查碼=0 WHERE 原物料編號 = " & DTGLIST.CurrentRow.Cells(1).Value '相關庫存資料刪掉
                cudfunctionNOmsg(query)
                Call reefresh_Click(sender, e)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & "//請選取一筆原物料紀錄.", MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub edit_Click(sender As Object, e As EventArgs) Handles edit.Click
        Try
            With frmEditProduct '編輯原物料資料
                .mnumber.Text = DTGLIST.CurrentRow.Cells(1).Value
                .Show()
                .Focus()
            End With
            Me.Close()
        Catch ex As Exception
            MsgBox("請選取要編輯的原物料.", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        With Formaddproduct '開啟新增原物料的視窗
            .Show()
            .Focus()
        End With
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '查詢條件(來源國家、來源製造公司、名稱)組合下原物料的搜尋結果
        If TextBox1.Text <> "" Then
            If cobcompany.Text <> "" Then
                If cobcountry.Text <> "" Then
                    query = "Select 識別碼 AS 自動編號,名稱 As 原物料名稱, 直徑 As 直徑,來源製造公司 As 來源製造公司, 來源國家 As 國家  FROM  PRODUCEINFO WHERE 名稱 LIKE '%" & TextBox1.Text & "%'AND 來源國家 = '" & cobcountry.Text & "' and 檢查碼=1 AND 來源製造公司 = '" & cobcompany.Text & "'"
                    retrieve(query, DTGLIST)
                    DTGLIST.Columns(0).Visible = False
                Else
                    query = "Select 識別碼 AS 自動編號,名稱 As 原物料名稱, 直徑 As 直徑,來源製造公司 As 來源製造公司, 來源國家 As 國家  FROM  PRODUCEINFO WHERE 名稱 LIKE '%" & TextBox1.Text & "%' and 檢查碼=1 AND 來源製造公司 = '" & cobcompany.Text & "'"
                    retrieve(query, DTGLIST)
                    DTGLIST.Columns(0).Visible = False
                End If
            Else
                If cobcountry.Text <> "" Then
                    query = "Select 識別碼 AS 自動編號,名稱 As 原物料名稱, 直徑 As 直徑,來源製造公司 As 來源製造公司, 來源國家 As 國家  FROM  PRODUCEINFO WHERE 名稱 LIKE '%" & TextBox1.Text & "%'AND 來源國家 = '" & cobcountry.Text & "' and 檢查碼=1"
                    retrieve(query, DTGLIST)
                    DTGLIST.Columns(0).Visible = False
                Else
                    query = "Select 識別碼 AS 自動編號,名稱 As 原物料名稱, 直徑 As 直徑,來源製造公司 As 來源製造公司, 來源國家 As 國家  FROM  PRODUCEINFO WHERE 名稱 LIKE '%" & TextBox1.Text & "%' and 檢查碼=1"
                    retrieve(query, DTGLIST)
                    DTGLIST.Columns(0).Visible = False
                End If

            End If
        Else
            If cobcompany.Text <> "" Then
                If cobcountry.Text <> "" Then
                    query = "Select 識別碼 AS 自動編號,名稱 As 原物料名稱, 直徑 As 直徑,來源製造公司 As 來源製造公司, 來源國家 As 國家  FROM  PRODUCEINFO WHERE 來源製造公司 = '" & cobcompany.Text & "'AND 來源國家 = '" & cobcountry.Text & "'and 檢查碼=1 "
                    retrieve(query, DTGLIST)
                    DTGLIST.Columns(0).Visible = False
                Else
                    query = "Select 識別碼 AS 自動編號,名稱 As 原物料名稱, 直徑 As 直徑,來源製造公司 As 來源製造公司, 來源國家 As 國家  FROM  PRODUCEINFO WHERE  來源製造公司 = '" & cobcompany.Text & "'and 檢查碼=1 "
                    retrieve(query, DTGLIST)
                    DTGLIST.Columns(0).Visible = False
                End If
            Else
                If cobcountry.Text <> "" Then
                    query = "Select 識別碼 AS 自動編號,名稱 As 原物料名稱, 直徑 As 直徑,來源製造公司 As 來源製造公司, 來源國家 As 國家  FROM  PRODUCEINFO WHERE 來源國家 = '" & cobcountry.Text & "'and 檢查碼=1 "
                    retrieve(query, DTGLIST)
                    DTGLIST.Columns(0).Visible = False
                Else
                    query = "Select 識別碼 AS 自動編號,名稱 As 原物料名稱, 直徑 As 直徑,來源製造公司 As 來源製造公司, 來源國家 As 國家 FROM  PRODUCEINFO WHERE 檢查碼=1"
                    retrieve(query, DTGLIST)
                    DTGLIST.Columns(0).Visible = False
                End If
            End If
        End If
    End Sub
End Class