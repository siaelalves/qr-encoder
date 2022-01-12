Imports MessagingToolkit.QRCode.Codec
Imports MessagingToolkit.QRCode.Codec.Data

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Dim qrencode As New QRCodeEncoder()
            Dim qrcode As Bitmap = qrencode.Encode(TextBox1.Text)
            PictureBox1.Image = TryCast(qrcode, Image)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "QR Encoder")
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'OpenFileDialog1.Filter = "Imagens|*.jpeg;*.jpg;*.gif;*.png;*.tiff;*.bmp"
        'OpenFileDialog1.Title = "Selecione uma imagem que corresponde a um código QR:"
        'TextBox1.Text = OpenFileDialog1.FileName
        '
        'OpenFileDialog1.ShowDialog()
    End Sub
End Class
