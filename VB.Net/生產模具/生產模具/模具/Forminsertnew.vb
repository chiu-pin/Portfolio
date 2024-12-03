Imports System.Data.OleDb
Public Class Forminsertnew
    Dim sql As String
    Dim caption As String
    Dim pdid As Integer
    Dim arrImage() As Byte
    Dim mstream As New System.IO.MemoryStream()
    Dim nu As String


    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If PictureBox1.Image Is Nothing Then
            MsgBox("欄位沒填到")
        Else
            If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox6.Text <> "" And ComboBox1.Text <> "" And TextBox10.Text <> "" Then
                query = "INSERT INTO produce (客戶代碼,名稱,編號,材質,熱處理條件,開模廠商1,開模廠商2,備註,總類,檢查碼) VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox10.Text & "','" & TextBox6.Text & "','" & TextBox11.Text & "','" & RichTextBox1.Text & "','" & ComboBox1.Text & "',1)"
                cudfunction(query)
                sql = "SELECT MAX(產品識別碼) FROM produce  WHERE 檢查碼=1"
                retrieveSingleResult(sql)
                If dt.Rows.Count > 0 Then
                    For Each r As DataRow In dt.Rows
                        TextBox5.Text = r.Item(0)
                    Next
                End If
                sql = "Insert into tblimage (ID,[img]) Values (@id,@img)"
                saveImage(sql, TextBox5.Text)
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
                TextBox6.Text = ""
                RichTextBox1.Text = ""
                ComboBox1.Text = ""
                PictureBox1.Image.Dispose()
                Me.Close()


            Else
                MsgBox("欄位沒填到")
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        RichTextBox1.Text = ""
        ComboBox1.Text = ""

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

End Class