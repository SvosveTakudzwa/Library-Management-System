Public NotInheritable Class WelcomeForm

    Private Sub WelcomeForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load 
        ApplicationTitle.Show()

        ProgressBar1.Value = 0
        ProgressBar1.Visible = False

        'Copyright info
        Copyright.Text = " Copyright " + vbNewLine + " HyLand GraFics Designs Co.®"
        Label1.Text = Format(Now, "yyyy")
        Label2.Text = "©"

        Timer1.Start()
       
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = ProgressBar1.Value + 2
        If (ProgressBar1.Value = 100) Then
            Form1.Show()
            Timer1.Enabled = False
            Me.Hide()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
