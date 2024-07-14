Imports System.Data.OleDb
Imports System.Data

Public Class Form1
    'THIS IS IT. BUCKLE UP FOLKS.
    Dim counter As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtusername.Focus()

        txtpass.UseSystemPasswordChar = True

        txtuserfullname.Hide()
        Me.txtpass.Size = New Drawing.Size(234, 34)
        Me.Cursor = Cursors.Arrow

        ProgressBar1.Hide()
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100

        lblfgpass.Hide()
        Label2.Hide()
        PictureBox5.Hide()

        lblusername.Text = "Username"
        lblpassword.Text = "Password"
        lblfgpass.Text = "Forgot Password?"
        Label1.Text = "©" + Format(Now, "yyyy")

        btenter.Text = "LOGIN"
        btexit.Text = "EXIT"

        Dim ctr As Integer
        ds.Clear()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        Module1.conn()
        cn.Open()
        str = "select * from UsersTb"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "UsersTb")
        ctr = ds.Tables("UsersTb").Rows.Count - 1

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btexit.Click

        Dim iExit As MsgBoxResult
        iExit = MsgBox("Are you sure you want to Exit?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "EXIT PROMPT")
        If iExit = MsgBoxResult.Yes Then
            Application.Exit()
        Else
            txtusername.Focus()
            Me.Cursor = Cursors.Arrow
        End If
        lblfgpass.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btenter.Click
        If txtusername.Text = Nothing And txtpass.Text = Nothing Then
            lblfgpass.Hide()
            MsgBox("Enter Details to Proceed.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "LOGIN PROMPT")
        ElseIf txtusername.Text = Nothing Or txtpass.Text = Nothing Then
            lblfgpass.Hide()
            MsgBox("Enter Complete Details to Proceed.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "LOGIN PROMPT")
        Else
            Timer1.Enabled = True
            lblfgpass.Hide()
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim userfllname As String
        Dim ctr, i As Integer
        Dim emp As String = ""
        ds.Clear()
        str = "select * from UsersTb"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "UsersTb")
        ctr = ds.Tables("UsersTb").Rows.Count - 1

        For i = 0 To ctr
            If ds.Tables("UsersTb").Rows(i)(3).ToString = txtusername.Text And ds.Tables("UsersTb").Rows(i)(4).ToString = txtpass.Text Then
                emp = ds.Tables("UsersTb").Rows(i)(1).ToString
                userfllname = ds.Tables("UsersTb").Rows(i)(2).ToString
                txtuserfullname.Text = userfllname
            End If
        Next

        If emp = "ADMIN" Then
            Me.Cursor = Cursors.AppStarting
            increment()
            enable()
            Form2.Label3.Text = "Logged In As: ADMIN"
        ElseIf emp = "USER" Then
            Me.Cursor = Cursors.AppStarting
            increment()
            disable()
            Form2.Label3.Text = "Logged In As: USER"
        Else
            ProgressBar1.Value = ProgressBar1.Value + 5
            Me.Cursor = Cursors.AppStarting
            If ProgressBar1.Value >= 15 Then
                err()
                Me.Cursor = Cursors.Arrow
            End If
        End If

    End Sub

    Sub increment()
        ProgressBar1.Value = ProgressBar1.Value + 10
        If ProgressBar1.Value >= 25 Then
            Timer1.Enabled = False
            Me.Hide()
            Form2.Show()
            MsgBox("Login Successful." + vbNewLine + "Welcome " + txtusername.Text + ".", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Success")
            ProgressBar1.Value = 0
            counter = 0
        End If
    End Sub

    Sub err()
        Dim iresponse As MsgBoxResult
        ProgressBar1.Value = ProgressBar1.Value + 10
        If ProgressBar1.Value >= 15 Then
            Timer1.Enabled = False
            Me.Cursor = Cursors.AppStarting
            iresponse = MsgBox("Incorrect Details. Try Again!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "Failed!")
            ProgressBar1.Value = 0
            counter += 1

            If iresponse = MsgBoxResult.Ok Then
                txtusername.Focus()
            End If
        End If

        'Login trys set to three
        If counter = 2 Then
            Me.Cursor = Cursors.Arrow
            lblfgpass.Show()
            Label2.Text = 20
        ElseIf counter = 3 Then

            Dim itoo As MsgBoxResult
            itoo = MsgBox("Too many incorrect details entered." + vbNewLine + " System will self-destruct in " & Val(Label2.Text) & " seconds.", MsgBoxStyle.Exclamation, "TOO MANY INCORRECT LOGINS")
            If itoo = MsgBoxResult.Ok Then
                Label2.Show()
                btenter.Enabled = False
                btexit.Enabled = False
                Timer2.Start()
            End If
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label2.Text = Format(Label2.Text - 1, "00")

    End Sub

    Sub enable()

        Form2.Button5.Show()
        Form2.Button6.Show()
        Form2.PictureBox3.Location = New System.Drawing.Point(45, 222)
        Form2.PictureBox4.Location = New System.Drawing.Point(729, 222)
        Form3.Button1.Location = New System.Drawing.Point(22, 9)
        Form3.Button2.Location = New System.Drawing.Point(233, 9)
        Form3.Button3.Location = New System.Drawing.Point(455, 9)
        Form3.Button4.Location = New System.Drawing.Point(677, 9)
    End Sub

    Sub disable()
        Form2.Button5.Hide()
        Form2.Button6.Hide()
        Form2.PictureBox3.Location = New System.Drawing.Point(45, 282)
        Form2.PictureBox4.Location = New System.Drawing.Point(729, 282)
        Form3.Button1.Hide()
        Form3.Button2.Location = New System.Drawing.Point(136, 9)
        Form3.Button3.Location = New System.Drawing.Point(358, 9)
        Form3.Button4.Location = New System.Drawing.Point(580, 9)
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub lblfgpass_Click(sender As Object, e As EventArgs) Handles lblfgpass.Click
        Form8.Show()
        Me.Enabled = False
    End Sub

    Private Sub PictureBox2_MouseHover(sender As Object, e As EventArgs) Handles PictureBox2.MouseHover
        Me.PictureBox2.Location = New System.Drawing.Point(16, 55)
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        Me.PictureBox2.Location = New System.Drawing.Point(16, 55)
    End Sub

    Private Sub PictureBox3_MouseHover(sender As Object, e As EventArgs) Handles PictureBox3.MouseHover
        Me.PictureBox3.Location = New System.Drawing.Point(16, 128)
    End Sub

    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox3.MouseLeave
        Me.PictureBox3.Location = New System.Drawing.Point(16, 128)
    End Sub

    Private Sub txtusername_MouseHover(sender As Object, e As EventArgs)
        Me.PictureBox2.Location = New System.Drawing.Point(16, 55)
    End Sub

    Private Sub txtusername_MouseLeave(sender As Object, e As EventArgs)
        Me.PictureBox2.Location = New System.Drawing.Point(16, 55)
    End Sub

    Private Sub txtpass_MouseHover(sender As Object, e As EventArgs)
        Me.PictureBox3.Location = New System.Drawing.Point(16, 128)
    End Sub

    Private Sub txtpass_MouseLeave(sender As Object, e As EventArgs)
        Me.PictureBox3.Location = New System.Drawing.Point(16, 128)
    End Sub

    Private Sub txtpass_TextChanged(sender As Object, e As EventArgs)
        If txtpass.Text = Nothing Then
            Me.txtpass.Size = New Drawing.Size(234, 34)
            PictureBox5.Hide()
        Else
            Me.txtpass.Size = New Drawing.Size(234, 34)
            PictureBox5.Show()
        End If

    End Sub

    Private Sub PictureBox5_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox5.MouseLeave
        txtpass.UseSystemPasswordChar = True
        txtpass.Focus()

    End Sub

    Private Sub PictureBox5_MouseHover(sender As Object, e As EventArgs) Handles PictureBox5.MouseHover
        If txtpass.UseSystemPasswordChar = True Then
            txtpass.UseSystemPasswordChar = Nothing
            txtpass.Focus()
        End If

        Me.lblpassword.Location = New System.Drawing.Point(66, 101)
        With txtpass
            .Focus()
        End With
    End Sub

    Private Sub Label2_TextChanged(sender As Object, e As EventArgs) Handles Label2.TextChanged
        If Val(Label2.Text) = -1 Then
            Label2.Hide()
            Timer2.Stop()
            Label2.Text = 20
            Application.Exit()
        End If
    End Sub

    Private Sub txtusername_TextChanged(sender As Object, e As EventArgs) Handles txtusername.TextChanged
        If txtusername.Text = Nothing Then
            Me.lblusername.Location = New System.Drawing.Point(62, 58)
            Me.lblusername.BackColor = Color.Beige
        ElseIf txtusername.TextLength > 0 Then
            Me.lblusername.Location = New System.Drawing.Point(62, 28)
            Me.lblusername.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub txtpass_TextChanged_1(sender As Object, e As EventArgs) Handles txtpass.TextChanged
        If txtpass.Text = Nothing Then
            Me.lblpassword.Location = New System.Drawing.Point(66, 132)
            Me.lblpassword.BackColor = Color.Beige
            PictureBox5.Hide()
        ElseIf txtpass.TextLength > 0 Then
            Me.lblpassword.Location = New System.Drawing.Point(66, 101)
            Me.lblpassword.BackColor = Color.Transparent
            PictureBox5.Show()
        End If
    End Sub

    Private Sub txtusername_MouseHover_1(sender As Object, e As EventArgs) Handles txtusername.MouseHover
        Me.lblusername.Location = New System.Drawing.Point(62, 28)
        With txtusername
            .Focus()
        End With
    End Sub

    Private Sub txtusername_MouseLeave_1(sender As Object, e As EventArgs) Handles txtusername.MouseLeave
        Me.lblusername.Location = New System.Drawing.Point(62, 58)
    End Sub

    Private Sub txtpass_MouseHover_1(sender As Object, e As EventArgs) Handles txtpass.MouseHover
        Me.lblpassword.Location = New System.Drawing.Point(66, 101)
        With txtpass
            .Focus()
        End With
    End Sub

    Private Sub txtpass_MouseLeave_1(sender As Object, e As EventArgs) Handles txtpass.MouseLeave
        Me.lblpassword.Location = New System.Drawing.Point(66, 132)
    End Sub
End Class
