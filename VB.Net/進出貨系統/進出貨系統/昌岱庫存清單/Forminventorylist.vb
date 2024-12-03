Imports System.Data.OleDb
Public Class Forminventorylist
    Dim ss As String
    Dim mnumber As String
    Dim dr As OleDbDataReader
    Dim sti As Double
    Dim sto As Double
    Dim oc As String
    Private Sub pdsearch_Click(sender As Object, e As EventArgs) Handles pdsearch.Click
        '連結原物料搜尋視窗
        With Forminventorysearch
            .TextBox2.Text = owncompany.Text
            .ShowDialog()
        End With
    End Sub

    Private Sub mnum_TextChanged(sender As Object, e As EventArgs) Handles mnum.TextChanged
        '當原物料選定後出現進貨及出貨資料
        sti = 0
        sto = 0
        Try
            '存取原物料詳細資料
            If owncompany.Text <> "" Then
                query = "SELECT 名稱,材質,直徑,來源製造公司,來源國家 FROM PRODUCEINFO  WHERE 識別碼 =" & mnum.Text & ""
                retrieveSingleResult(query) '看到這種英文後面括號的都是程式的方法，丟參數進去就會跑結果出來，可以節省重複撰寫的時間
                If dt.Rows.Count > 0 Then
                    For Each r As DataRow In dt.Rows
                        mname.Text = r.Item(0)
                        material.Text = r.Item(1)
                        msize.Text = r.Item(2)
                        mcompany.Text = r.Item(3)
                        mcountry.Text = r.Item(4)
                    Next
                End If
                mnumber = mnum.Text

                '存取原物料進貨資料
                query = "SELECT 進貨日期,進貨噸數,用途,經銷商,進貨識別 FROM stockin WHERE 原物料編號 =" & mnum.Text & " and 所屬公司名稱 = '" & owncompany.Text & "' and 檢查碼=1 "
                retrieve(query, dtgin)
                dtgin.Columns(0).Visible = False '可以調整dtg這個物件裡面的欄位是否可以使用者看見，這邊設定flase所以不能被看見
                dtgin.Columns(5).Visible = False
                dtgin.Columns(3).Width = 200 '可以調整寬度，dtg裡面的格式向excel然後我從query選了五個欄位，進貨日期是第一欄位以此類推第三蘭是用途就給寬度大一點，裡面的Columns換成row會變成列
                If dtgin.Rows.Count = 1 Then
                    tbxstn.Text = 0
                End If
                '存取原物料出貨資料
                query = "SELECT 出庫日期,出庫噸數,指令,用途,出貨識別 FROM STOCKOUT WHERE 原物料編號 =" & mnum.Text & " and 虛擬公司 = '" & owncompany.Text & "'and 檢查碼=1"
                retrieve(query, dtgout)
                dtgout.Columns(0).Visible = False
                dtgout.Columns(5).Visible = False
                If dtgout.Rows.Count = 1 Then
                    tbxsto.Text = 0
                End If
            Else
                MsgBox("請選取所屬公司")
            End If
        Catch ex As Exception
            MsgBox(ex.Message & " //Please Select a corresponding records.", MsgBoxStyle.Exclamation)
        End Try
    End Sub
    Private Sub Forminventorylist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '所屬公司向下選單combobox的item匯入
        ss = "昌岱"
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
        owncompany.Text = "昌岱"
    End Sub

    Private Sub dtgin_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dtgin.CellValueChanged
        '設定TBX進貨噸數總和
        sti = 0
        For index As Integer = 0 To CInt(dtgin.Rows.Count - 1)
            sti = sti + CDbl(dtgin.Rows(index).Cells(2).Value)
        Next
        tbxstn.Text = sti
    End Sub

    Private Sub dtgout_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dtgout.CellValueChanged
        '設定TBX出貨噸數總和
        sto = 0
        For index As Integer = 0 To CInt(dtgout.Rows.Count - 1)
            sto = sto + CDbl(dtgout.Rows(index).Cells(2).Value)
        Next
        tbxsto.Text = CStr(sto)
    End Sub

    Private Sub tbxstn_TextChanged(sender As Object, e As EventArgs) Handles tbxstn.TextChanged
        '設定剩餘數量
        inquty.Text = sti - sto
    End Sub

    Private Sub tbxsto_TextChanged(sender As Object, e As EventArgs) Handles tbxsto.TextChanged
        '設定剩餘數量
        inquty.Text = sti - sto
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles delin.Click
        '刪除進貨資料
        Try

            msgfalse = "Failed To delete"
            msgtrue = "Product has been deleted."
            query = "UPDATE stockin Set 檢查碼=0 WHERE 進貨識別 = " & dtgin.CurrentRow.Cells(5).Value
            cudfunction(query)
            '重整進貨資料
            query = "SELECT 進貨日期,進貨噸數,用途,經銷商,進貨識別 FROM stockin WHERE 原物料編號 =" & mnum.Text & " and 所屬公司名稱 = '" & owncompany.Text & "' and 檢查碼=1 "
            retrieve(query, dtgin)
            dtgin.Columns(0).Visible = False
            dtgin.Columns(5).Visible = False
            If dtgin.Rows.Count = 1 Then
                tbxstn.Text = 0
            End If

        Catch ex As Exception
            MsgBox(ex.Message & "//請選取一筆原物料紀錄.", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles insertin.Click
        '新增進貨
        If mnum.Text = "" Then
            MsgBox("請先選取原物料")
        Else
            '開啟新增進貨的視窗
            With Formstockin
                .mnum.Text = mnumber
                .owncompany.Text = owncompany.Text
                .ShowDialog()
            End With
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnrfin.Click
        '重整進出貨資料
        '存取原物料進貨資料
        query = "SELECT 進貨日期,進貨噸數,用途,經銷商,進貨識別 FROM stockin WHERE 原物料編號 =" & mnum.Text & " and 所屬公司名稱 = '" & owncompany.Text & "' and 檢查碼=1 "
        retrieve(query, dtgin)
        dtgin.Columns(0).Visible = False
        dtgin.Columns(5).Visible = False
        If dtgin.Rows.Count = 1 Then
            tbxstn.Text = 0
        End If
        query = "SELECT 出庫日期,出庫噸數,指令,用途,出貨識別 FROM STOCKOUT WHERE 原物料編號 =" & mnum.Text & " and 虛擬公司 = '" & owncompany.Text & "'and 檢查碼=1"
        retrieve(query, dtgout)
        dtgout.Columns(0).Visible = False
        dtgout.Columns(5).Visible = False
        If dtgout.Rows.Count = 1 Then
            tbxsto.Text = 0
        End If
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles delsto.Click
        '刪除出貨資料
        Try
            msgfalse = "Failed To delete"
            msgtrue = "Product has been deleted."
            query = "UPDATE STOCKOUT Set 檢查碼=0 WHERE 出貨識別 = " & dtgout.CurrentRow.Cells(5).Value
            cudfunction(query)
            '重整出貨資料
            query = "SELECT 出庫日期,出庫噸數,指令,用途,出貨識別 FROM STOCKOUT WHERE 原物料編號 =" & mnum.Text & " and 虛擬公司 = '" & owncompany.Text & "'and 檢查碼=1"
            retrieve(query, dtgout)
            dtgout.Columns(0).Visible = False
            dtgout.Columns(5).Visible = False
            If dtgout.Rows.Count = 1 Then
                tbxsto.Text = 0
            End If
        Catch ex As Exception
            MsgBox("//請選取一筆原物料紀錄.", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles insertout.Click
        '新增出貨
        If mnum.Text = "" Then
            MsgBox("請先選取原物料")
        Else
            '開啟新增出貨的視窗
            With Formstockout
                .mnum.Text = mnumber
                .owncompany.Text = owncompany.Text
                .ShowDialog()
            End With
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles edstn.Click
        If mnum.Text = "" Then
            MsgBox("請先選取原物料")
        Else
            Try
                With Formstnedit '開啟編輯進貨的視窗
                    .mnum.Text = mnumber
                    .labstn.Text = dtgin.CurrentRow.Cells(5).Value
                    .ShowDialog()
                End With
            Catch ex As Exception
                MsgBox("請選取要編輯的進貨資料.", MsgBoxStyle.Exclamation)
            End Try

        End If
    End Sub

    Private Sub owncompany_SelectedValueChanged(sender As Object, e As EventArgs) Handles owncompany.SelectedValueChanged
        oc = owncompany.Text
        If mnum.Text <> "" Then
            query = "SELECT 進貨日期,進貨噸數,用途,經銷商,進貨識別 FROM stockin WHERE 原物料編號 =" & mnum.Text & " and 所屬公司名稱 = '" & owncompany.Text & "' and 檢查碼=1 "
            retrieve(query, dtgin)
            dtgin.Columns(0).Visible = False
            dtgin.Columns(5).Visible = False
            If dtgin.Rows.Count = 1 Then
                tbxstn.Text = 0
            End If
            query = "SELECT 出庫日期,出庫噸數,指令,用途,出貨識別 FROM STOCKOUT WHERE 原物料編號 =" & mnum.Text & " and 虛擬公司 = '" & owncompany.Text & "'and 檢查碼=1"
            retrieve(query, dtgout)
            dtgout.Columns(0).Visible = False
            dtgout.Columns(5).Visible = False
            If dtgout.Rows.Count = 1 Then
                tbxsto.Text = 0
            End If

        End If
    End Sub

    Private Sub edsto_Click(sender As Object, e As EventArgs) Handles edsto.Click
        If mnum.Text = "" Then
            MsgBox("請先選取原物料")
        Else
            Try
                With Formstoedit '開啟編輯出貨的視窗
                    .mnum.Text = mnumber
                    .Label13.Text = dtgout.CurrentRow.Cells(5).Value
                    .ShowDialog()
                End With
            Catch ex As Exception
                MsgBox("請選取要編輯的出貨資料.", MsgBoxStyle.Exclamation)
            End Try

        End If
    End Sub

End Class