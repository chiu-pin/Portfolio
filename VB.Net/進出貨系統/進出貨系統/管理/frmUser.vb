Public Class frmUser
    Private Sub frmUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '使用者的資料表格呈現
        frmMaxMinSize(Me, 638, 591)
        query = "SELECT USERID , U_NAME AS [Name],U_UNAME AS [Username],U_TYPE AS [Role] FROM tblUser WHERE 檢查碼=1"
        retrieve(query, dtglist)
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        '新增使用者資料
        If txtname.Text <> "" And txtusername.Text <> "" And txtpass.Text <> "" And cbotype.Text <> "" Then
            If LBLUSERID.Text = "USERID" Then
                query = "SELECT USERID , U_NAME AS [Name],U_UNAME AS [Username],U_TYPE AS [Role] FROM tblUser WHERE 檢查碼=1 and U_UNAME = '" & txtusername.Text & "'"
                retrieveSingleResult(query)
                If dt.Rows.Count > 0 Then
                    MsgBox("帳號不得重複") '限制帳號不能重複+
                Else
                    msgtrue = "New user has been saved."
                    msgfalse = "User not saved."
                    query = "INSERT INTO tblUser ( U_NAME,U_UNAME,U_PASS,U_TYPE,檢查碼) VALUES ('" & txtname.Text & "','" & txtusername.Text _
                & "','" & txtpass.Text & "','" & cbotype.Text & "',1)"
                    cudfunction(query) '新增使用者資料成功
                End If

            Else
                msgtrue = "User has been updated."
                msgfalse = "User is not updated."
                query = "UPDATE tblUser SET U_NAME='" & txtname.Text & "',U_UNAME='" & txtusername.Text _
            & "',U_PASS='" & txtpass.Text & "',U_TYPE='" & cbotype.Text & "' WHERE USERID=" & LBLUSERID.Text
                cudfunction(query) '編輯使用者資料成功
            End If
            Call btnnew_Click(sender, e)
            query = "SELECT USERID , U_NAME AS [Name],U_UNAME AS [Username], U_TYPE AS [Role] FROM tblUser where 檢查碼=1"
            retrieve(query, dtglist)
        Else
            MsgBox("請填寫欄位", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        '清空欄位
        clear(Panel2)
        cbotype.Text = ""
        LBLUSERID.Text = "USERID"
        query = "SELECT USERID , U_NAME AS [Name],U_UNAME AS [Username], U_TYPE AS [Role] FROM tblUser WHERE 檢查碼=1"
        retrieve(query, dtglist)
    End Sub

    Private Sub dtglist_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtglist.CellClick
        '表格選擇上面的使用者資料更著變動
        Try
            LBLUSERID.Text = dtglist.CurrentRow.Cells(1).Value
            query = "SELECT * FROM tblUser WHERE USERID=" & LBLUSERID.Text
            retrieveSingleResult(query)
            With dt.Rows(0)
                If dt.Rows.Count > 0 Then
                    txtname.Text = .Item(1)
                    txtusername.Text = .Item(2)
                    txtpass.Text = .Item(3)
                    cbotype.Text = .Item(4)
                End If
            End With

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        msgtrue = "User has been deleted."
        msgfalse = "User is not deleted."
        query = "UPDATE tblUser SET 檢查碼=0 WHERE USERID = " & dtglist.CurrentRow.Cells(1).Value
        cudfunction(query)
        '刪除使用者資料
        Call btnnew_Click(sender, e)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class