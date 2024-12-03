Imports System.Data.OleDb
Public Class Formaddproduct
    Dim nn As Long
    Dim ss As String
    Private Sub clearNew()
        '清除欄位
        mnum.Text = ""
        mname.Text = ""
        material.Text = ""
        msize.Text = " "
        mcompany.Text = ""
        mcountry.Text = ""
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '填寫原物料的欄位不可少了名稱材質及直徑
        If mname.Text = "" Or material.Text = "" Or msize.Text = " " Then
            MsgBox("欄位資料都必須填寫", MsgBoxStyle.Exclamation, "Required")

        Else '填寫原物料的資料進入資料庫
            '檢查是否原物料有重複存檔
            query = "SELECT 識別碼 FROM PRODUCEINFO WHERE 名稱='" & mname.Text & "' and 來源製造公司='" & mcompany.Text & "' and 來源國家='" & mcountry.Text & "' and 檢查碼=1"
            retrieveSingleResult(query)
            If dt.Rows.Count > 0 Then
                MsgBox("已有相同名稱、來源國家、來源製造公司的原物料資料存檔了")
            Else
                '無重複存檔則可新增進資料庫
                query = "insert into PRODUCEINFO (名稱,材質,直徑,來源製造公司,來源國家,檢查碼) values ('" & mname.Text & "' , '" & material.Text & "', '" & msize.Text & "', '" & mcompany.Text & "', '" & mcountry.Text & "',1)"
                cudfunctionNOmsg(query)
                msgfalse = "新增原物料未成功"
                msgtrue = "已成功新增原物料"

            End If
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        clearNew()
    End Sub

    Private Sub msize_KeyPress(sender As Object, e As KeyPressEventArgs) Handles msize.KeyPress
        Try
            '設定mise.text只能輸入數字
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

    Private Sub Formaddproduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class