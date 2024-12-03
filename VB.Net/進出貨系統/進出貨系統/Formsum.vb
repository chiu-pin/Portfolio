Imports System.Data.OleDb
Public Class Formsum
    '總表功能
    Dim dr As OleDbDataReader
    Dim count As Integer
    Private Sub Formsum_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'cbomater選項的item設定
        cbomater.Items.Clear()
        con.Open()
        cmd.CommandText = "select distinct 材質 from PRODUCEINFO where 檢查碼=1"
        cmd.Connection = con
        dr = cmd.ExecuteReader
        While dr.Read
            cbomater.Items.Add(dr.GetString(0))
        End While
        dr.Close()
        con.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '設定完尋找材質後判斷是否要找全部的剩餘數量
        If cbomater.Text <> "" Then
            If owncompany.Text = "全部" Then

                query = "SELECT I.進貨直徑 AS 材料直徑,IIF(I.進貨總噸數 Is Not NULL,I.進貨總噸數,0 ) AS 進貨總數,IIF(O.出庫總噸數 IS NOT NULL,O.出庫總噸數,0 ) AS 出庫總數,(進貨總數-出庫總數) AS 剩餘噸數 FROM (select 直徑 AS 進貨直徑,sum(進貨噸數) as 進貨總噸數 from PRODUCEINFO LEFT JOIN stockin ON ( PRODUCEINFO.識別碼= stockin.原物料編號 And stockin.檢查碼 <> 0)  where 材質 = '" & cbomater.Text & "'  group by 直徑) AS I , (select 直徑 AS 出庫直徑,sum(出庫噸數) as 出庫總噸數  from PRODUCEINFO LEFT JOIN STOCKOUT ON (PRODUCEINFO.識別碼 = STOCKOUT.原物料編號 AND STOCKOUT.檢查碼 <> 0) WHERE 材質 = '" & cbomater.Text & "' group by 直徑 ) AS O WHERE I.進貨直徑 = O.出庫直徑 "
                retrieve(query, dtgsum)
                dtgsum.Columns(0).Visible = False
            ElseIf owncompany.Text = "昌岱" Then

                query = "SELECT I.進貨直徑 AS 材料直徑,IIF(I.進貨總噸數 Is Not NULL,I.進貨總噸數,0 ) AS 進貨總數,IIF(O.出庫總噸數 IS NOT NULL,O.出庫總噸數,0 ) AS 出庫總數,(進貨總數-出庫總數) AS 剩餘噸數 FROM (select 直徑 AS 進貨直徑,sum(進貨噸數) as 進貨總噸數 from PRODUCEINFO LEFT JOIN stockin ON ( PRODUCEINFO.識別碼= stockin.原物料編號 And stockin.檢查碼 <> 0 And 所屬公司名稱='" & owncompany.Text & "')  where 材質 = '" & cbomater.Text & "'  group by 直徑) AS I , (select 直徑 AS 出庫直徑,sum(出庫噸數) as 出庫總噸數  from PRODUCEINFO LEFT JOIN STOCKOUT ON (PRODUCEINFO.識別碼 = STOCKOUT.原物料編號 AND STOCKOUT.檢查碼 <> 0 AND 虛擬公司='" & owncompany.Text & "') WHERE 材質 = '" & cbomater.Text & "' group by 直徑 ) AS O WHERE I.進貨直徑 = O.出庫直徑 "
                retrieve(query, dtgsum)
                dtgsum.Columns(0).Visible = False

            Else
                MsgBox("請選擇所屬公司條件")
            End If
        Else
            MsgBox("請選取材質")
        End If



    End Sub


End Class