Public Class Formccnew
    Dim n1 As Integer
    Dim n2 As Integer
    Dim n3 As Integer
    Dim n4 As Integer
    Dim n5 As Integer
    Dim n6 As Integer
    Dim n7 As Integer
    Dim n8 As Integer
    Dim dfrom As Date
    Private Sub TextBox10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox10.KeyPress
        Try
            '限制輸入數字
            If e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
                If e.KeyChar <> "." Then
                    If IsNumeric(e.KeyChar) Then
                        e.Handled = False '

                    End If

                Else
                    e.Handled = False
                End If
            End If
        Catch ex As Exception
            logs(ex.Message & " at TXTQTY_KeyPress")
            MsgBox(ex.Message & " at TXTQTY_KeyPress")
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox10.Enabled = True
        Else
            TextBox10.Text = 0
            TextBox10.Enabled = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            TextBox11.Enabled = True
        Else
            TextBox11.Text = 0
            TextBox11.Enabled = False
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            TextBox12.Enabled = True
        Else
            TextBox12.Text = 0
            TextBox12.Enabled = False
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            TextBox13.Enabled = True
        Else
            TextBox13.Text = 0
            TextBox13.Enabled = False
        End If
    End Sub

    Private Sub Label11_KeyPress(sender As Object, e As KeyPressEventArgs)
        Try
            ' 限制輸入數字
            If e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
                If e.KeyChar <> "." Then
                    If IsNumeric(e.KeyChar) Then
                        e.Handled = False '

                    End If

                Else
                    e.Handled = False
                End If
            End If

        Catch ex As Exception
            logs(ex.Message & " at TXTQTY_KeyPress")
            MsgBox(ex.Message & " at TXTQTY_KeyPress")
        End Try
    End Sub
    Private Sub TextBox12_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox12.KeyPress
        Try
            '限制輸入數字
            If e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
                If e.KeyChar <> "." Then
                    If IsNumeric(e.KeyChar) Then
                        e.Handled = False '

                    End If

                Else
                    e.Handled = False
                End If
            End If

        Catch ex As Exception
            logs(ex.Message & " at TXTQTY_KeyPress")
            MsgBox(ex.Message & " at TXTQTY_KeyPress")
        End Try
    End Sub
    Private Sub TextBox13_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox13.KeyPress
        Try
            '限制輸入數字
            If e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
                If e.KeyChar <> "." Then
                    If IsNumeric(e.KeyChar) Then
                        e.Handled = False '

                    End If

                Else
                    e.Handled = False
                End If
            End If

        Catch ex As Exception
            logs(ex.Message & " at TXTQTY_KeyPress")
            MsgBox(ex.Message & " at TXTQTY_KeyPress")
        End Try
    End Sub

    Private Sub Forminsertsq_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox10.Text = 0
        TextBox11.Text = 0
        TextBox12.Text = 0
        TextBox13.Text = 0
        TextBox17.Text = 0
        TextBox18.Text = 0
        TextBox19.Text = 0
        TextBox20.Text = 0
        txtAutoNumber(2, TextBox15)
    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged
        If TextBox10.Text <> "" Then
            n1 = CInt(TextBox10.Text)

        Else
            n1 = 0
        End If

        TextBox16.Text = n1 + n2 + n3 + n4 + n5 + n6 + n7 + n8
    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged
        If TextBox11.Text <> "" Then
            n2 = CInt(TextBox11.Text)
        Else
            n2 = 0
        End If
        TextBox16.Text = n1 + n2 + n3 + n4 + n5 + n6 + n7 + n8
    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged
        If TextBox12.Text <> "" Then
            n3 = CInt(TextBox12.Text)
        Else
            n3 = 0
        End If
        TextBox16.Text = n1 + n2 + n3 + n4 + n5 + n6 + n7 + n8
    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged
        If TextBox13.Text <> "" Then
            n4 = CInt(TextBox13.Text)
        Else
            n4 = 0
        End If
        TextBox16.Text = n1 + n2 + n3 + n4 + n5 + n6 + n7 + n8
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If n1 <> 0 And CheckBox1.Checked = True Then
                For number As Integer = 1 To n1
                    query = "INSERT INTO ordersi (產品識別碼,採購單編號,模類,預計進貨日,進貨廠商,檢查碼) VALUES (" & TextBox5.Text & ",'" & TextBox15.Text & "','" & CheckBox1.Text & "','" & dtp1.Value & "','" & ComboBox1.Text & "',1)"
                    cudfunctionNOmsg(query)
                Next
            End If
            If n2 <> 0 And CheckBox2.Checked = True Then
                For number As Integer = 1 To n2
                    query = "INSERT INTO ordersi (產品識別碼,採購單編號,模類,預計進貨日,進貨廠商,檢查碼) VALUES (" & TextBox5.Text & ",'" & TextBox15.Text & "','" & CheckBox2.Text & "','" & dtp1.Value & "','" & ComboBox1.Text & "',1)"
                    cudfunctionNOmsg(query)
                Next
            End If
            If n3 <> 0 And CheckBox3.Checked = True Then
                For number As Integer = 1 To n3
                    query = "INSERT INTO ordersi (產品識別碼,採購單編號,模類,預計進貨日,進貨廠商,檢查碼) VALUES (" & TextBox5.Text & ",'" & TextBox15.Text & "','" & CheckBox3.Text & "','" & dtp1.Value & "','" & ComboBox1.Text & "',1)"
                    cudfunctionNOmsg(query)
                Next
            End If
            If n4 <> 0 And CheckBox4.Checked = True Then
                For number As Integer = 1 To n4
                    query = "INSERT INTO ordersi (產品識別碼,採購單編號,模類,預計進貨日,進貨廠商,檢查碼) VALUES (" & TextBox5.Text & ",'" & TextBox15.Text & "','" & CheckBox4.Text & "','" & dtp1.Value & "','" & ComboBox1.Text & "',1)"
                    cudfunctionNOmsg(query)
                Next
            End If
            If n5 <> 0 And CheckBox5.Checked = True Then
                For number As Integer = 1 To n5
                    query = "INSERT INTO ordersi (產品識別碼,採購單編號,模類,預計進貨日,進貨廠商,檢查碼) VALUES (" & TextBox5.Text & ",'" & TextBox15.Text & "','" & CheckBox5.Text & "','" & dtp1.Value & "','" & ComboBox1.Text & "',1)"
                    cudfunctionNOmsg(query)
                Next
            End If
            If n6 <> 0 And CheckBox5.Checked = True Then
                For number As Integer = 1 To n6
                    query = "INSERT INTO ordersi (產品識別碼,採購單編號,模類,預計進貨日,進貨廠商,檢查碼) VALUES (" & TextBox5.Text & ",'" & TextBox15.Text & "','" & CheckBox6.Text & "','" & dtp1.Value & "','" & ComboBox1.Text & "',1)"
                    cudfunctionNOmsg(query)
                Next
            End If
            If n7 <> 0 And CheckBox7.Checked = True Then
                For number As Integer = 1 To n5
                    query = "INSERT INTO ordersi (產品識別碼,採購單編號,模類,預計進貨日,進貨廠商,檢查碼) VALUES (" & TextBox5.Text & ",'" & TextBox15.Text & "','" & CheckBox7.Text & "','" & dtp1.Value & "','" & ComboBox1.Text & "',1)"
                    cudfunctionNOmsg(query)
                Next
            End If
            If n8 <> 0 And CheckBox8.Checked = True Then
                For number As Integer = 1 To n8
                    query = "INSERT INTO ordersi (產品識別碼,採購單編號,模類,預計進貨日,進貨廠商,檢查碼) VALUES (" & TextBox5.Text & ",'" & TextBox15.Text & "','" & CheckBox8.Text & "','" & dtp1.Value & "','" & ComboBox1.Text & "',1)"
                    cudfunctionNOmsg(query)
                Next
            End If
            query = "INSERT INTO remark (採購單編號,備註,檢查碼) VALUES ('" & TextBox15.Text & "','" & RichTextBox1.Text & "',1)"
            cudfunction(query)
            updateAutoNumber(2)
            Me.Close()
        Catch ex As Exception
            MsgBox("QQ")
        End Try
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        query = "SELECT * FROM produce  WHERE 產品識別碼 =" & TextBox5.Text & ""
        retrieveSingleResult(query) '看到這種英文後面括號的都是程式的方法，丟參數進去就會跑結果出來，可以節省重複撰寫的時間
        If dt.Rows.Count > 0 Then
            For Each r As DataRow In dt.Rows
                TextBox8.Text = r.Item(1)
                TextBox6.Text = r.Item(2)
                TextBox3.Text = r.Item(3)
                TextBox4.Text = r.Item(4)
                TextBox2.Text = r.Item(5)
                TextBox7.Text = r.Item(6)
                TextBox1.Text = r.Item(7)
                RichTextBox2.Text = r.Item(8)
                ComboBox2.Text = r.Item(9)
            Next
        End If

    End Sub

    Private Sub TextBox17_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox17.KeyPress
        Try
            '限制輸入數字
            If e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
                If e.KeyChar <> "." Then
                    If IsNumeric(e.KeyChar) Then
                        e.Handled = False '

                    End If

                Else
                    e.Handled = False
                End If
            End If
        Catch ex As Exception
            logs(ex.Message & " at TXTQTY_KeyPress")
            MsgBox(ex.Message & " at TXTQTY_KeyPress")
        End Try
    End Sub

    Private Sub TextBox18_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox18.KeyPress
        Try
            '限制輸入數字
            If e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
                If e.KeyChar <> "." Then
                    If IsNumeric(e.KeyChar) Then
                        e.Handled = False '

                    End If

                Else
                    e.Handled = False
                End If
            End If
        Catch ex As Exception
            logs(ex.Message & " at TXTQTY_KeyPress")
            MsgBox(ex.Message & " at TXTQTY_KeyPress")
        End Try

    End Sub

    Private Sub TextBox19_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox19.KeyPress
        Try
            '限制輸入數字

            If e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
                If e.KeyChar <> "." Then
                    If IsNumeric(e.KeyChar) Then
                        e.Handled = False '

                    End If

                Else
                    e.Handled = False
                End If
            End If
        Catch ex As Exception
            logs(ex.Message & " at TXTQTY_KeyPress")
            MsgBox(ex.Message & " at TXTQTY_KeyPress")
        End Try
    End Sub

    Private Sub TextBox20_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox20.KeyPress
        Try
            '限制輸入數字
            If e.KeyChar <> ChrW(Keys.Back) Then
                e.Handled = True
                If e.KeyChar <> "." Then
                    If IsNumeric(e.KeyChar) Then
                        e.Handled = False '

                    End If

                Else
                    e.Handled = False
                End If
            End If
        Catch ex As Exception
            logs(ex.Message & " at TXTQTY_KeyPress")
            MsgBox(ex.Message & " at TXTQTY_KeyPress")
        End Try
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            TextBox17.Enabled = True
        Else
            TextBox17.Text = 0
            TextBox17.Enabled = False
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = True Then
            TextBox18.Enabled = True
        Else
            TextBox18.Text = 0
            TextBox18.Enabled = False
        End If
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox7.Checked = True Then
            TextBox19.Enabled = True
        Else
            TextBox19.Text = 0
            TextBox19.Enabled = False
        End If
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        If CheckBox8.Checked = True Then
            TextBox20.Enabled = True
        Else
            TextBox20.Text = 0
            TextBox20.Enabled = False
        End If
    End Sub

    Private Sub TextBox17_TextChanged(sender As Object, e As EventArgs) Handles TextBox17.TextChanged
        If TextBox17.Text <> "" Then
            n5 = CInt(TextBox10.Text)

        Else
            n5 = 0
        End If

        TextBox16.Text = n1 + n2 + n3 + n4 + n5 + n6 + n7 + n8
    End Sub

    Private Sub TextBox18_TextChanged(sender As Object, e As EventArgs) Handles TextBox18.TextChanged
        If TextBox18.Text <> "" Then
            n6 = CInt(TextBox10.Text)

        Else
            n6 = 0
        End If

        TextBox16.Text = n1 + n2 + n3 + n4 + n5 + n6 + n7 + n8
    End Sub

    Private Sub TextBox19_TextChanged(sender As Object, e As EventArgs) Handles TextBox19.TextChanged
        If TextBox19.Text <> "" Then
            n7 = CInt(TextBox10.Text)

        Else
            n7 = 0
        End If

        TextBox16.Text = n1 + n2 + n3 + n4 + n5 + n6 + n7 + n8
    End Sub

    Private Sub TextBox20_TextChanged(sender As Object, e As EventArgs) Handles TextBox20.TextChanged
        If TextBox20.Text <> "" Then
            n8 = CInt(TextBox10.Text)

        Else
            n8 = 0
        End If

        TextBox16.Text = n1 + n2 + n3 + n4 + n5 + n6 + n7 + n8
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub
End Class