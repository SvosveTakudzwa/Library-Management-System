Imports System.Text.RegularExpressions
Imports System.Data.OleDb
Imports System.IO
Imports iTextSharp
Imports System.Reflection
Imports iTextSharp.text.pdf
'Imports iTextSharp.text
Public Class Form4

    Private Sub Form4_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form2.Enabled = True
        Timer1.Stop()
    End Sub

    Sub FORMLOAD()
        CKLEAR()

        ds.Clear()
        Label1.Text = "MEMBER"
        Label2.Text = "RECORDS"
        Label3.Text = "WELCOME TO"
        Label4.Text = "MEMBER RECORDS"
        Label5.Text = "INTERFACE"
        Label6.Text = "SEARCH"

        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If

        Module1.conn()
        cn.Open()
        str = "select * from MemberTb"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "MemberTb")

        'for registration no
        Dim LastNo As Integer
        LastNo = ds.Tables("MemberTb").Rows.Count + 1
        If LastNo >= 0 Then
            MemberIDTextBox.Text = "MbrID00" & LastNo
        Else
            MemberIDTextBox.Text = "MbrID00" & 0
        End If

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryDbDataSet.MemberTb' table. You can move, or remove it, as needed.
        Me.MemberTbTableAdapter.Fill(Me.LibraryDbDataSet.MemberTb)
        Timer1.Start()

        Button1.Text = "MEMBER REGISTRY"
        Button2.Text = "MEMBER INFO"

        GroupBox4.Visible = False
        GroupBox3.Visible = False

        FORMLOAD()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If GroupBox2.Visible = True Then
            Button2.Text = "RETURN HOME"
            GroupBox2.Visible = False
            GroupBox4.Visible = True
            Button1.Enabled = False
        Else
            GroupBox4.Visible = False
            GroupBox2.Visible = True
            Button2.Text = "MEMBER INFO"
            Button1.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If GroupBox3.Visible = False Then
            GroupBox3.Visible = True
            GroupBox4.Visible = False
            GroupBox2.Visible = False
            Button1.Text = "RETURN HOME"
            Button2.Enabled = False
        Else
            GroupBox3.Visible = False
            GroupBox2.Visible = True
            GroupBox4.Visible = False
            Button1.Text = "MEMBER REGISTRY"
            Button2.Enabled = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CKLEAR()
        FORMLOAD()
    End Sub

    Sub CKLEAR()
        PictureBox3.Image = Nothing
        Label9.Show()
        MemberEmailAddressTextBox.Clear()
        MemberFullNameTextBox.Clear()
        MemberIDTextBox.Clear()
        MemberMobileNoTextBox.Clear()
        MemberPhysicalAddressTextBox.Clear()
        MemberPictureTextBox.Clear()
        cmbMemberGender.SelectedItem = Nothing
        MemberDateRegisteredTextBox.Value = Format(Now, "dd-MMM-yyyy")
        MemberDOBTextBox.Value = Format(Now, "dd-MMM-yyyy")
        MemberRegValTextBox.Value = Format(Now, "dd-MMM-yyyy")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        MemberDateRegisteredTextBox.Value = Format(Now, "dd-MMM-yyyy")

        Dim d1 As DateTime = MemberDateRegisteredTextBox.Value
        Dim tmdate As DateTime

        If MemberIDTextBox.Text = Nothing Then
            MemberRegValTextBox.Value = Format(Now, "dd-MMM-yyyy")
        Else
            MemberIDTextBox.Text = MemberIDTextBox.Text
            tmdate = d1.AddDays(93)
            MemberRegValTextBox.Value = tmdate
        End If

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        OpenFileDialog1.Filter = "Image Files (*.png;*.jpeg;*.ico;*.bmp;*.gif;*.jpg)|*.png;*.jpeg;*.ico;*.bmp;*.gif;*.jpg"
        OpenFileDialog1.ShowDialog()
        MemberPictureTextBox.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub MemberPictureTextBox_TextChanged(sender As Object, e As EventArgs) Handles MemberPictureTextBox.TextChanged
        If (System.IO.File.Exists(MemberPictureTextBox.Text)) Then
            PictureBox3.Image = Image.FromFile(MemberPictureTextBox.Text)
        End If
        If MemberPictureTextBox.Text = "" Then
            PictureBox3.Hide()
        Else
            PictureBox3.Show()
            Label9.Hide()
        End If
    End Sub

    Private Sub MemberEmailAddressTextBox_Validated(sender As Object, e As EventArgs) Handles MemberEmailAddressTextBox.Validated
        Dim p As String

        p = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z]*@[0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"
        If Regex.IsMatch(MemberEmailAddressTextBox.Text, p) Then

        Else
            MsgBox("You entered an invalid format of an email address. Please try again!", MsgBoxStyle.Exclamation, "INVALID EMAIL ADDRESS")
        End If
    End Sub

    Private Sub MemberMobileNoTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MemberMobileNoTextBox.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub MemberFullNameTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MemberFullNameTextBox.KeyPress
        If Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If

    End Sub

    Private Sub cmbMemberGender_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbMemberGender.KeyPress
        If Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If TextBox1.Text = "" Then
            Call notFound()
            Exit Sub
        Else
            MemberTbBindingSource.Filter = "(Convert(MemberID, 'System.String') LIKE '" & TextBox1.Text & "')" & _
            "OR (MemberFullName LIKE '" & TextBox1.Text & "') OR (MemberGender LIKE '" & TextBox1.Text & "')" & _
             "OR (MemberDOB LIKE '" & TextBox1.Text & "') OR (MemberMobileNo LIKE '" & TextBox1.Text & "')" & _
             "OR (MemberPhysicalAddress LIKE '" & TextBox1.Text & "') OR (MemberEmailAddress LIKE '" & TextBox1.Text & "')" & _
             "OR (MemberDateRegistered LIKE '" & TextBox1.Text & "') OR (MemberTermDate LIKE '" & TextBox1.Text & "')" & _
              "OR (MemberPicture LIKE '" & TextBox1.Text & "')"

            If MemberTbBindingSource.Count <> 0 Then
                With DataGridView1
                    .DataSource = MemberTbBindingSource
                End With
            Else
                MsgBox("We couldn't find anything to show here. Double check your search criteria.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ITEM NOT FOUND")
                MemberTbBindingSource.Filter = Nothing
            End If
        End If
    End Sub


    Private Sub notFound()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MemberTbBindingSource.MovePrevious()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        MemberTbBindingSource.MoveNext()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        MemberTbBindingSource.RemoveCurrent()
        Me.Validate()
        Me.MemberTbBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LibraryDbDataSet)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim LastNo As Integer
        LastNo = ds.Tables("MemberTb").Rows.Count + 1
        If LastNo >= 0 Then
            MemberIDTextBox.Text = "MbrID00" & LastNo
        Else
            MemberIDTextBox.Text = "MbrID00" & 0
        End If

        If MemberFullNameTextBox.Text = "" Or cmbMemberGender.Text = "" Or MemberDOBTextBox.Text = Format(Now, "dd-MMM-yyyy") Or MemberMobileNoTextBox.Text = "" Or MemberPhysicalAddressTextBox.Text = "" Or MemberEmailAddressTextBox.Text = "" Or MemberPictureTextBox.Text = "" Then
            MsgBox("Fill in all details!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "INCOMPLETE DETAILS")
        Else
            SAVEDATA()
        End If

    End Sub

    Private Sub SAVEDATA()
        Dim ctr, i As Integer
        Dim membername As String = ""

        ds.Clear()

        str = "select * from MemberTb"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "MemberTb")
        ctr = ds.Tables("MemberTb").Rows.Count - 1

        For i = 0 To ctr
            If MemberFullNameTextBox.Text = ds.Tables("MemberTb").Rows(i)(1).ToString Then
                membername = ds.Tables("MemberTb").Rows(i)(1).ToString
            End If
        Next

        If membername.Contains(MemberFullNameTextBox.Text) Then
            MsgBox("Member already exists.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Operation Failed")
        Else
            Try
                cmd = New OleDbCommand
                cmd.CommandText = " insert into MemberTb values (@MemberID,@MemberFullName,@MemberGender,@MemberDOB,@MemberMobileNo,@MemberPhysicalAddress,@MemberEmailAddress,@MemberDateRegistered,@MemberTermDate,@MemberPicture) "
                cmd.Parameters.AddWithValue("@MemberID", MemberIDTextBox.Text)
                cmd.Parameters.AddWithValue("@MemberFullName", MemberFullNameTextBox.Text)
                cmd.Parameters.AddWithValue("@MemberGender", cmbMemberGender.Text)
                cmd.Parameters.AddWithValue("@MemberDOB", MemberDOBTextBox.Text)
                cmd.Parameters.AddWithValue("@MemberMobileNo", MemberMobileNoTextBox.Text)
                cmd.Parameters.AddWithValue("@MemberPhysicalAddress", MemberPhysicalAddressTextBox.Text)
                cmd.Parameters.AddWithValue("@MemberEmailAddress", MemberEmailAddressTextBox.Text)
                cmd.Parameters.AddWithValue("@MemberDateRegistered", MemberDateRegisteredTextBox.Text)
                cmd.Parameters.AddWithValue("@MemberTermDate", MemberRegValTextBox.Text)
                cmd.Parameters.AddWithValue("@MemberPicture", MemberPictureTextBox.Text)

                cmd.Connection = cn
                cmd.ExecuteNonQuery()
                MsgBox("New Member successfully added.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Operation Successful")
            Catch ex As Exception
                MsgBox("Failed to add new Member. Please try again.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Operation Failed")
            End Try
        End If
    End Sub

   
End Class