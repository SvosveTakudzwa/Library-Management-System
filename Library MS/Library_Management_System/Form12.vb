Public Class Form12

    Private Sub Form12_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form2.Enabled = True
    End Sub

    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "    WELCOME TO THE" + vbNewLine + " ADMINISTRATION PORTAL"

        Button1.Text = "USER"
        Button2.Text = "MAIL" + vbNewLine + "MERGE"
        Button3.Text = "RECORDS"
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Me.PictureBox3.Location = New System.Drawing.Point(158, 188)
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Me.PictureBox3.Location = New System.Drawing.Point(158, 218)
    End Sub

    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        Me.PictureBox4.Location = New System.Drawing.Point(378, 188)
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Me.PictureBox4.Location = New System.Drawing.Point(378, 218)
    End Sub

    Private Sub Button3_MouseHover(sender As Object, e As EventArgs) Handles Button3.MouseHover
        Me.PictureBox5.Location = New System.Drawing.Point(598, 188)
    End Sub

    Private Sub Button3_MouseLeave(sender As Object, e As EventArgs) Handles Button3.MouseLeave
        Me.PictureBox5.Location = New System.Drawing.Point(598, 218)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Enabled = False
        Form7.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("WINWORD")
    End Sub
End Class