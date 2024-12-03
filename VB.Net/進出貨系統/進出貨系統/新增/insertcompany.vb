Public Class insertcompany
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '新增客戶公司名稱或經銷商名稱
        If comname.Text = "" Or cbocom.Text = "" Then
            MsgBox("請輸入公司名稱或其類別")
        ElseIf cbocom.Text = "客戶公司" Then
            query = "select 所屬公司名稱 from 所屬公司 where 所屬公司名稱='" & cbocom.Text & "'"
            If result = True Then
                MsgBox("已經有此公司名稱")
            Else
                query = "INSERT INTO owncompany (所屬公司名稱,檢查碼) values ('" & comname.Text & "',1)"
                cudfunction(query)
            End If
        Else
            query = "select 中盤商名稱 dealer from 中盤商名稱 where ='" & cbocom.Text & "'"
            If result = True Then
                MsgBox("已經有此公司名稱")
            Else
                query = "INSERT INTO dealer (中盤商名稱,檢查碼) values ('" & comname.Text & "',1)"
                cudfunction(query)
            End If
        End If
    End Sub

    Private Sub insertcompany_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class