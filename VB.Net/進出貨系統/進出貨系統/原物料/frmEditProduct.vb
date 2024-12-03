Imports System.Data.OleDb
Public Class frmEditProduct
    Dim mlon As Long
    Private Sub mnumber_TextChanged(sender As Object, e As EventArgs) Handles mnumber.TextChanged
        '取得原物料編碼後原物料詳細資料的讀取
        Try

            'MsgBox(DTGLIST.CurrentRow.Cells(1).Value)

            query = "SELECT 名稱,材質,直徑,來源製造公司,來源國家 FROM PRODUCEINFO WHERE 識別碼 =" & mnumber.Text
            retrieveSingleResult(query)
            If dt.Rows.Count > 0 Then

                For Each r As DataRow In dt.Rows
                    mname.Text = r.Item(0)
                    material.Text = r.Item(1)
                    msize.Text = r.Item(2)
                    mcompany.Text = r.Item(3)
                    mcountry.Text = r.Item(4)
                Next
            End If


        Catch ex As Exception
            MsgBox(ex.Message & " //Please Select a corresponding records.", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '編輯後的原物料資料更新
        Try
            msgfalse = "編輯錯誤."
            msgtrue = "編輯原物料成功"

            query = "UPDATE  PRODUCEINFO  Set 名稱='" & mname.Text & "' ,材質='" & material.Text & "',直徑='" & msize.Text & "',來源國家='" & mcountry.Text & "',來源製造公司='" & mcompany.Text & "'  WHERE 識別碼 =" & mnumber.Text
            cudfunction(query)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '關閉視窗
        Me.Close()
    End Sub

    Private Sub msize_KeyPress(sender As Object, e As KeyPressEventArgs) Handles msize.KeyPress
        '設定mise只能輸入數字
        Try

            If e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
                If e.KeyChar <> "." Then
                    If IsNumeric(e.KeyChar) Then e.Handled = False '
                ElseIf msize.Text.Contains(".") Then
                    MessageBox.Show("請輸入數字")
                Else
                    e.Handled = False
                End If
            End If

        Catch ex As Exception
            logs(ex.Message & " at TXTPRICE_KeyUp")
            MsgBox(ex.Message & " at TXTPRICE_KeyUp")
        End Try

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class