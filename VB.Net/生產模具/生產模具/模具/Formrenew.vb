Imports System.Data.OleDb
Imports System.IO
Public Class Formrenew
    Dim sql As String
    Dim caption As String
    Dim pdid As Integer
    Dim arrImage() As Byte
    Dim mstream As New System.IO.MemoryStream()
    Dim nu As String
    Private Sub showImage(sql As String)
        Try
            con.Open()
            cmd = New OleDb.OleDbCommand
            With cmd
                .Connection = con
                .CommandText = sql
            End With

            Dim da As New OleDbDataAdapter
            Dim dt As New DataTable

            da.SelectCommand = cmd
            da.Fill(dt)


            Dim by As Byte() = dt.Rows(0)("img")
            Dim ms As MemoryStream = New MemoryStream(by)
            PictureBox1.Image = Image.FromStream(ms)
            ms.Dispose()
            con.Close()
            da.Dispose()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try
            With OpenFileDialog1

                'CHECK THE SELECTED FILE IF IT EXIST OTHERWISE THE DIALOG BOX WILL DISPLAY A WARNING.
                .CheckFileExists = True

                'CHECK THE SELECTED PATH IF IT EXIST OTHERWISE THE DIALOG BOX WILL DISPLAY A WARNING.
                .CheckPathExists = True

                'GET AND SET THE DEFAULT EXTENSION
                .DefaultExt = "jpg"

                'RETURN THE FILE LINKED TO THE LNK FILE
                .DereferenceLinks = True

                'SET THE FILE NAME TO EMPTY 
                .FileName = ""

                'FILTERING THE FILES
                .Filter = "(*.jpg)|*.jpg|(*.png)|*.png|(*.jpg)|*.jpg|All files|*.*"
                'SET THIS FOR ONE FILE SELECTION ONLY.
                .Multiselect = False

                'SET THIS TO PUT THE CURRENT FOLDER BACK TO WHERE IT HAS STARTED.
                .RestoreDirectory = True

                'SET THE TITLE OF THE DIALOG BOX.
                .Title = "Select a file to open"

                'ACCEPT ONLY THE VALID WIN32 FILE NAMES.
                .ValidateNames = True

                If .ShowDialog = DialogResult.OK Then
                    Try
                        PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
                    Catch fileException As Exception
                        Throw fileException
                    End Try
                End If

            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        query = "UPDATE  produce  Set 客戶代碼 = '" & TextBox1.Text & "',名稱='" & TextBox2.Text & "',編號='" & TextBox3.Text & "',材質='" & TextBox4.Text & "',熱處理條件='" & TextBox10.Text & "',開模廠商1='" & TextBox6.Text & "',開模廠商2 = '" & TextBox11.Text & "',備註 = '" & RichTextBox1.Text & "',總類='" & ComboBox1.Text & "' WHERE 產品識別碼 =" & TextBox5.Text
        cudfunction(query)
    End Sub

    Private Sub saveImage(sql As String, nu As String)
        Try
            'SPECIFIES THE FILE FORMAT OF THE IMAGE
            PictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)

            'RETURNS THE ARRAY OF UNSIGNED BYTES FROM WHICH THIS STREAM WAS CREATED
            arrImage = mstream.GetBuffer()

            'GET THE SIZE OF THE STREAM IN BYTES
            Dim FileSize As UInt32
            FileSize = mstream.Length
            'CLOSES THE CURRENT STREAM AND RELEASE ANY RESOURCES ASSOCIATED WITH THE CURRENT STREAM
            mstream.Close()

            con.Open()

            cmd = New OleDbCommand
            With cmd
                .Connection = con
                .CommandText = sql
                .Parameters.AddWithValue("@id", nu)
                .Parameters.AddWithValue("@img", arrImage)
                .ExecuteNonQuery()
            End With
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dr As DialogResult = Me.OpenFileDialog1.ShowDialog()
        If dr = DialogResult.OK Then
            Dim file As New FileInfo(OpenFileDialog1.FileName)
            Dim by(file.Length) As Byte
            file.OpenRead().Read(by, 0, file.Length)
            Dim cmd As New OleDbCommand("Update tblimage Set img=? Where id= '" & TextBox5.Text & "'", con)
            cmd.Parameters.Add(New OleDbParameter("img", by))
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        query = "SELECT * FROM produce  WHERE 產品識別碼 =" & TextBox5.Text & ""
        retrieveSingleResult(query) '看到這種英文後面括號的都是程式的方法，丟參數進去就會跑結果出來，可以節省重複撰寫的時間
        If dt.Rows.Count > 0 Then
            For Each r As DataRow In dt.Rows
                TextBox1.Text = r.Item(1)
                TextBox2.Text = r.Item(2)
                TextBox3.Text = r.Item(3)
                TextBox4.Text = r.Item(4)
                TextBox10.Text = r.Item(5)
                TextBox6.Text = r.Item(6)
                TextBox11.Text = r.Item(7)
                RichTextBox1.Text = r.Item(8)
                ComboBox1.Text = r.Item(9)
            Next
        End If
        query = " select * from tblimage where ID ='" & TextBox5.Text & "'"
        showImage(query)
        query = "select * from prddetail where 產品識別碼 = '" & TextBox5.Text & "' and 檢查碼 = 1 "
        retrieve(query, DataGridView1)
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox9.Text <> "" And TextBox12.Text <> "" Then
            query = "INSERT INTO prddetail (產品識別碼,模類,尺寸,重量,檢查碼) VALUES ('" & TextBox5.Text & "','" & TextBox9.Text & "','" & TextBox12.Text & "','" & TextBox13.Text & "',1)"
            cudfunction(query)
        End If
        query = "select * from prddetail where 產品識別碼 = '" & TextBox5.Text & "' and 檢查碼=1 "
        retrieve(query, DataGridView1)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        query = "UPDATE prddetail  Set 檢查碼 = 0  WHERE 產品識別碼 =" & DataGridView1.CurrentRow.Cells(1).Value
        cudfunction(query)
        query = "select * from prddetail where 產品識別碼 = '" & TextBox5.Text & "' and 檢查碼=1 "
        retrieve(query, DataGridView1)
    End Sub
End Class