Imports System.Text.RegularExpressions
Public Class Form2

    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        lblshtdwn.Hide()
        lblsettngs.Hide()
        lblsgnout.Hide()
        Label11.Hide()
        Label2.Hide()
        Label1.Text = " KWEKWE LIBRARY (Pvt) " + vbNewLine + "MANAGEMENT SYSTEM " + Format(Now, "yyyy")
        Label9.Text = " Copyright : HyLand GraFics Designs Co.®"
        Label8.Text = "©" + Format(Now, "yyyy")
        Label10.Text = "LIBRARY MANAGEMENT SYSTEM"

        Label2.Text = "Welcome: "
        Label3.Text = "Logged In As: "
        Label4.Text = "Date:"
        Label7.Text = "Time:"

        Button4.Text = "BOOK RECORDS"
        Button5.Text = "SUPPLIER RECORDS"
        Button6.Text = "STAFF RECORDS"
        Button7.Text = "MEMBER RECORDS"

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim ilog As MsgBoxResult
        ilog = MsgBox("Are you sure you want Log Off?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "LOG OFF PROMPT")
        If ilog = MsgBoxResult.Yes Then
            Me.Hide()
            Form1.txtusername.Clear()
            Form1.txtpass.Clear()
            Form1.Cursor = Cursors.Arrow
            Form1.Show()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label5.Text = Format(Now, "dd-MMM-yyyy")
        Label6.Text = Format(Now, "hh:mm tt")

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form3.aktvate.Start()
        Form3.Show()
        Me.Enabled = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form4.Show()
        Me.Enabled = False

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form5.Show()
        Me.Enabled = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form6.Show()
        Me.Enabled = False
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Dim ilog As MsgBoxResult
        ilog = MsgBox("Are you sure you want Sign Out?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "LOG OFF PROMPT")
        If ilog = MsgBoxResult.Yes Then
            Me.Hide()
            Form1.txtusername.Clear()
            Form1.txtpass.Clear()
            Form1.Cursor = Cursors.Arrow
            Form1.Show()
        End If
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Dim ishut As MsgBoxResult
        ishut = MsgBox("Are you sure you want Shut Down the System?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "SHUT DOWN")
        If ishut = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Dim icont As MsgBoxResult
        Dim thestring As String = "ADMIN"

        If Label3.Text.Contains(thestring) Then
            adminprompt()
        Else
            icont = MsgBox("You don't currently have permission to access this folder." + vbNewLine + " Click Ok to permanently get access to this folder.", MsgBoxStyle.OkCancel + MsgBoxStyle.Exclamation, "UNAVAILABLE")
            If icont = MsgBoxResult.Ok Then
                MsgBox("You have been denied permission to acess this folder." + vbNewLine + "To gain access to this folder you will need to be promoted to a higher Access Level.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "UNAVAILABLE")
            Else
                Me.Enabled = True
            End If
        End If
    End Sub

    Sub adminprompt()
        Dim iwish As MsgBoxResult
        iwish = MsgBox("     Do you wish to" + vbNewLine + "ADD/DELETE/UPDATE " + vbNewLine + "          User(s) ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "ADMIN PROMPT")
        If iwish = MsgBoxResult.Yes Then
            Me.Enabled = False
            Form12.Show()
        End If
    End Sub

    Private Sub PictureBox8_MouseHover(sender As Object, e As EventArgs) Handles PictureBox8.MouseHover
        Me.PictureBox8.Location = New System.Drawing.Point(817, 3)
        lblsgnout.Show()
    End Sub

    Private Sub PictureBox8_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox8.MouseLeave
        Me.PictureBox8.Location = New System.Drawing.Point(817, 15)
        lblsgnout.Hide()
    End Sub

    Private Sub PictureBox7_MouseHover(sender As Object, e As EventArgs) Handles PictureBox7.MouseHover
        Me.PictureBox7.Location = New System.Drawing.Point(866, 3)
        lblsettngs.Show()
    End Sub

    Private Sub PictureBox7_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox7.MouseLeave
        Me.PictureBox7.Location = New System.Drawing.Point(866, 15)
        lblsettngs.Hide()
    End Sub

    Private Sub PictureBox6_MouseHover(sender As Object, e As EventArgs) Handles PictureBox6.MouseHover
        Me.PictureBox6.Location = New System.Drawing.Point(915, 0)
        lblshtdwn.Show()
    End Sub

    Private Sub PictureBox6_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox6.MouseLeave
        Me.PictureBox6.Location = New System.Drawing.Point(915, 15)
        lblshtdwn.Hide()
    End Sub

    Private Sub Button5_MouseHover(sender As Object, e As EventArgs) Handles Button5.MouseHover
        Me.PictureBox3.Location = New System.Drawing.Point(45, 185)
    End Sub

    Private Sub Button5_MouseLeave(sender As Object, e As EventArgs) Handles Button5.MouseLeave
        Me.PictureBox3.Location = New System.Drawing.Point(45, 222)
    End Sub

    Private Sub Button4_MouseHover(sender As Object, e As EventArgs) Handles Button4.MouseHover
        Me.PictureBox2.Location = New System.Drawing.Point(269, 185)
    End Sub

    Private Sub Button4_MouseLeave(sender As Object, e As EventArgs) Handles Button4.MouseLeave
        Me.PictureBox2.Location = New System.Drawing.Point(269, 222)
    End Sub

    Private Sub Button7_MouseHover(sender As Object, e As EventArgs) Handles Button7.MouseHover
        Me.PictureBox5.Location = New System.Drawing.Point(502, 185)
    End Sub

    Private Sub Button7_MouseLeave(sender As Object, e As EventArgs) Handles Button7.MouseLeave
        Me.PictureBox5.Location = New System.Drawing.Point(502, 222)
    End Sub

    Private Sub Button6_MouseHover(sender As Object, e As EventArgs) Handles Button6.MouseHover
        Me.PictureBox4.Location = New System.Drawing.Point(729, 185)
    End Sub

    Private Sub Button6_MouseLeave(sender As Object, e As EventArgs) Handles Button6.MouseLeave
        Me.PictureBox4.Location = New System.Drawing.Point(729, 222)
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Form10.Show()
        Me.Enabled = False
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Form10.Show()
        Me.Enabled = False
    End Sub

    Private Sub PictureBox10_MouseHover(sender As Object, e As EventArgs) Handles PictureBox10.MouseHover
        Me.PictureBox10.Location = New System.Drawing.Point(768, 5)
        Label11.Show()

    End Sub

    Private Sub PictureBox10_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox10.MouseLeave
        Me.PictureBox10.Location = New System.Drawing.Point(768, 15)
        Label11.Hide()
    End Sub
End Class