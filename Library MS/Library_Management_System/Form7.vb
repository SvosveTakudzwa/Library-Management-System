Imports System.Text.RegularExpressions
Imports System.Data.OleDb
Imports System.IO
Public Class Form7

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryDbDataSet.UsersTb' table. You can move, or remove it, as needed.
        Me.UsersTbTableAdapter.Fill(Me.LibraryDbDataSet.UsersTb)
        FORMLOAD()
    End Sub

    Sub FORMLOAD()
        klear()

        Button7.Enabled = True
        Button8.Enabled = True
        Button10.Enabled = True
        ds.Clear()
        RadioButton2.Checked = True

        Timer1.Start()

        Label1.Text = "VIEW AS :"
        Label2.Text = "SEARCH"
        Label12.Text = "STAFF ID No."
        Label11.Text = "User ID No."
        RadioButton1.Text = "DataGrid View"
        RadioButton2.Text = "List View"
        GroupBox1.Hide()

        Label4.Text = "Full Name"
        Label5.Text = "Username"
        Label6.Text = "Password"
        Label7.Text = "Security Question"
        Label8.Text = "Answer to Security Question"
        Label10.Text = "Picture Path"
        Label3.Text = "Access Level"

        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If

        Module1.conn()
        cn.Open()
        str = "select * from UsersTb"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "UsersTb")

        staffload()

        'for registration no
        Dim LastNo As Integer
        LastNo = ds.Tables("UsersTb").Rows.Count + 1
        If LastNo >= 0 Then
            TextBox7.Text = "UrID00" & LastNo
        Else
            TextBox7.Text = "UrID00" & 0
        End If

    End Sub

    Private Sub Form7_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form12.Enabled = True
        Timer1.Stop()
        klear()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If RadioButton2.Checked = True Then
            GroupBox2.Visible = True
            GroupBox1.Hide()
        ElseIf RadioButton1.Checked = True Then
            GroupBox1.Visible = True
            GroupBox2.Hide()
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)

    End Sub

    Sub klear()
        PictureBox1.Image = Nothing
        ComboBox1.Text = "Select Access Level"
        ComboBox2.Text = "Select Security Question"
        TextBox2.Text = "Enter Username"
        TextBox3.Text = "Enter Password"
        TextBox4.Text = "Enter Fullname"
        TextBox5.Text = "Enter Answer"
        TextBox6.Text = ""
        TextBox1.Clear()
        TextBox8.Text = "Enter Staff ID No."
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
          If (System.IO.File.Exists(TextBox6.Text)) Then
            PictureBox1.Image = Image.FromFile(TextBox6.Text)
        End If
        If TextBox6.Text = "" Then
            PictureBox1.Hide()
        Else
            PictureBox1.Show()
            Label9.Hide()
        End If
    End Sub

    Sub staffload()
        Dim ctr As Integer
        str = "select * from StaffTb"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "StaffTb")
        ctr = ds.Tables("StaffTb").Rows.Count - 1
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        klear()
        FORMLOAD()
        Label9.Show()
        Button7.Enabled = True
        Button8.Enabled = True
        Button10.Enabled = True
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        klear()
        Me.Close()
        Form2.Enabled = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        klear()
        Label9.Show()
        Me.Close()
        Button7.Enabled = True
        Button8.Enabled = True
        Button10.Enabled = True
    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        If Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ComboBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox2.KeyPress
        If Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Sub STaaff()
        Dim ctr, i As Integer
        Dim profn As String = ""
        Dim spic As String = ""
        Dim sname As String = ""

        str = "select * from StaffTb"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "StaffTb")
        ctr = ds.Tables("StaffTb").Rows.Count - 1

        For i = 0 To ctr
            If ds.Tables("StaffTb").Rows(i)(0).ToString = TextBox8.Text Then
                sname = ds.Tables("StaffTb").Rows(i)(1).ToString
                profn = ds.Tables("StaffTb").Rows(i)(7).ToString
                spic = ds.Tables("StaffTb").Rows(i)(12).ToString
            End If
        Next

        If profn.Contains("Librarian") Then
            TextBox4.Text = sname
            TextBox6.Text = spic
            Button7.Enabled = True
            Button8.Enabled = True
            Button10.Enabled = True
        Else
            TextBox4.Text = "Enter Fullname"
            PictureBox1.Image = Nothing
            Label9.Show()
            Button7.Enabled = False
            Button8.Enabled = False
            Button10.Enabled = False
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        'Declaration of variables
        Dim LastNo As Integer
        LastNo = ds.Tables("UsersTb").Rows.Count + 1
        If LastNo >= 0 Then
            TextBox7.Text = "UrID00" & LastNo
        Else
            TextBox7.Text = "UrID00" & 0
        End If

        If ComboBox1.SelectedItem = Nothing Or TextBox4.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox2.SelectedItem = Nothing Or TextBox5.Text = "" Or TextBox6.Text = "" Then
            MsgBox("Fill in all details!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "INCOMPLETE DETAILS")
        Else
            sAvEdAtA()
        End If

    End Sub

    Private Sub sAvEdAtA()
        'Declaring variables
        Dim ctr, i As Integer
        Dim usrname As String = ""

        ds.Clear()

        str = "select * from UsersTb"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "UsersTb")
        ctr = ds.Tables("UsersTb").Rows.Count - 1

        For i = 0 To ctr
            If TextBox4.Text = ds.Tables("UsersTb").Rows(i)(2).ToString Then
                usrname = ds.Tables("UsersTb").Rows(i)(2).ToString
            End If
        Next

        If usrname.Contains(TextBox4.Text) Then
            'output if User Account already exists
            MsgBox("User Account already exists.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Operation Failed")
        Else
            Try
                'initialisation of global variable
                cmd = New OleDbCommand
                cmd.CommandText = " insert into UsersTb values (@UserID,@UserAccessLevel,@UserFullName,@UserName,@UserPassWord,@UserSecurityQuestion,@UserAnswer,@UserPicture) "
                cmd.Parameters.AddWithValue("@UserID", TextBox7.Text)
                cmd.Parameters.AddWithValue("@UserAccessLevel", ComboBox1.Text)
                cmd.Parameters.AddWithValue("@UserFullName", TextBox4.Text)
                cmd.Parameters.AddWithValue("@UserName", TextBox2.Text)
                cmd.Parameters.AddWithValue("@UserPassWord", TextBox3.Text)
                cmd.Parameters.AddWithValue("@UserSecurityQuestion", ComboBox2.Text)
                cmd.Parameters.AddWithValue("@UserAnswer", TextBox5.Text)
                cmd.Parameters.AddWithValue("@UserPicture", TextBox6.Text)

                cmd.Connection = cn
                cmd.ExecuteNonQuery()
                'output if method is successful
                MsgBox("New User Account successfully added.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Operation Successful")

            Catch ex As Exception
                'output if method is unsuccessful
                MsgBox("Failed to add new Account. Please try again.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Operation Failed")

            End Try 'closing Try statement

        End If 'closing If statement
    End Sub

    Private Sub TextBox8_Validated(sender As Object, e As EventArgs) Handles TextBox8.Validated
        STaaff()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            Call notFound()
            Exit Sub
        Else
            UsersTbBindingSource.Filter = "(Convert(UserID, 'System.String') LIKE '" & TextBox1.Text & "')" & _
            "OR (UserAccessLevel LIKE '" & TextBox1.Text & "') OR (UserFullName LIKE '" & TextBox1.Text & "')" & _
            "OR (UserName LIKE '" & TextBox1.Text & "') OR (UserPassWord LIKE '" & TextBox1.Text & "')" & _
             "OR (UserSecurityQuestion LIKE '" & TextBox1.Text & "') OR (UserAnswer LIKE '" & TextBox1.Text & "')" & _
            "OR (UserAnswer LIKE '" & TextBox1.Text & "')"

            If UsersTbBindingSource.Count <> 0 Then
                With DataGridView1
                    .DataSource = UsersTbBindingSource
                End With
            Else
                MsgBox("We couldn't find anything to show here. Double check your search criteria.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ITEM NOT FOUND")
                UsersTbBindingSource.Filter = Nothing
            End If

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        UsersTbBindingSource.MovePrevious()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        UsersTbBindingSource.MoveNext()
    End Sub

    Private Sub notFound()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        UsersTbBindingSource.RemoveCurrent()
    End Sub
End Class