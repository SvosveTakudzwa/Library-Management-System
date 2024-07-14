Imports System.Text.RegularExpressions
Imports System.Data.OleDb
Imports System.IO
Public Class Form8

    Private Sub Form8_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.Enabled = True
        Form1.lblfgpass.Hide()
    End Sub


    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label6.Hide()
        Button8.Enabled = True
        lblaccesslevelcheck.Hide()

        Label1.Text = "Welcome to Password Recovery portal. Fully complete the details " + vbNewLine + "             required below and click SUBMIT to recover your" + vbNewLine + "                               password in a blink of an eye!"
        Label2.Text = "User ID"
        Label5.Text = "Username"
        Label7.Text = "Security Question"
        Label8.Text = "Answer to Security Question"
        Label9.Show()

        Dim ctr As Integer
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        clear()
        Button5.Enabled = True
        Button8.Enabled = True
    End Sub

    Sub clear()
        TextBox1.Text = Nothing
        TextBox2.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        PictureBox3.Image = Nothing
        ComboBox2.Text = ""
        Label9.Show()
        Label6.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Button8.Enabled = True
        clear()
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If TextBox1.Text = Nothing Or TextBox2.Text = Nothing Or ComboBox2.SelectedItem = Nothing Or TextBox5.Text = Nothing Then
            MsgBox("Account Verification details are incomplete." + vbNewLine + "Complete all fields to proceed!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PASSWORD RECOVERY PROMPT")
        Else
            Timer1.Start()
        End If

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        If (System.IO.File.Exists(TextBox6.Text)) Then
            PictureBox3.Image = Image.FromFile(TextBox6.Text)
        End If
        If TextBox6.Text = "" Then
            PictureBox3.Hide()
        Else
            PictureBox3.Show()
            Label9.Hide()
        End If

    End Sub

    Private Sub ComboBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox2.KeyPress
        If Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim icont As MsgBoxResult
        Dim ctr, i As Integer
        Dim che As Integer = 0
        Dim emp As String = ""
        Dim empaa As String = ""
        Dim acclvl As String = ""
        ds.Clear()

        str = "select * from UsersTb"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "UsersTb")
        ctr = ds.Tables("UsersTb").Rows.Count - 1

        For i = 0 To ctr
            If ds.Tables("UsersTb").Rows(i)(0).ToString = TextBox1.Text And ds.Tables("UsersTb").Rows(i)(3).ToString = TextBox2.Text And ds.Tables("UsersTb").Rows(i)(5).ToString = ComboBox2.SelectedItem And ds.Tables("UsersTb").Rows(i)(6).ToString = TextBox5.Text Then
                che = 1
                emp = ds.Tables("UsersTb").Rows(i)(2).ToString
                empaa = ds.Tables("UsersTb").Rows(i)(4).ToString
                acclvl = ds.Tables("UsersTb").Rows(i)(1).ToString
                TextBox6.Text = ds.Tables("UsersTb").Rows(i)(7).ToString
            End If
        Next

        If acclvl.Contains("ADMIN") Then
            Label6.Show()
            Label6.Text = "Your password " + emp + " is " + empaa + "."
            Button8.Enabled = False
        ElseIf acclvl.Contains("USER") Then
            Timer1.Stop()
            MsgBox(emp + ", you have been denied permission to continue accessing this page. To gain access to this page, you will need to visit the Administration for assistance.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "PERMISSION DENIED")
            Button8.Enabled = False
        Else
            Timer1.Stop()
            TextBox6.Clear()
            Label6.Hide()
            Label9.Show()
            Button8.Enabled = False
            icont = MsgBox("You don't currently have permission to access this page." + vbNewLine + " Click Ok to permanently get access to this page.", MsgBoxStyle.OkCancel + MsgBoxStyle.Exclamation, "SERVER UNAVAILABLE")
            If icont = MsgBoxResult.Ok Then
                MsgBox("Please visit the Administration for assistance.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "SERVER UNAVAILABLE")
            End If
        End If
        Button8.Enabled = False
            Timer1.Stop()
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        If TextBox5.Text = "" Then
            TextBox6.Clear()
            Label6.Hide()
            Label9.Show()
        End If

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.SelectedItem = "" Then
            TextBox6.Clear()
            Label6.Hide()
            Label9.Show()
        End If

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text = "" Then
            TextBox6.Clear()
            Label6.Hide()
            Label9.Show()
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            TextBox6.Clear()
            Label6.Hide()
            Label9.Show()
        End If

    End Sub

End Class