Public Class Form1
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using ofd As New OpenFileDialog
            Dim result As DialogResult = ofd.ShowDialog()
            If result = DialogResult.OK Then
                Using noel = New NoelShackProvider
                    Dim response = Await noel.UploadFile(ofd.FileName)
                    RichTextBox1.Text = response.ToString
                End Using
            End If
        End Using
    End Sub
End Class
