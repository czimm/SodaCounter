Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lbSodaCount.Text += 1
        lbTotal.Text = CDec(lbSodaCount.Text * 0.5).ToString("C2")

        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\SodaCount.txt", lbSodaCount.Text, False)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lbSodaCount.Text -= 1
        lbTotal.Text = CDec(lbSodaCount.Text * 0.5).ToString("C2")

        My.Computer.FileSystem.WriteAllText(Application.StartupPath & "\SodaCount.txt", lbSodaCount.Text, False)
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        lbSodaCount.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\SodaCount.txt")

        lbTotal.Text = CDec(lbSodaCount.Text * 0.5).ToString("C2")
    End Sub
End Class
