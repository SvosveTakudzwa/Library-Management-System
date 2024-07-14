Imports System.Text.RegularExpressions
Imports System.Data.OleDb
Imports System.IO
Public Class Form6

    Private Sub Form6_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form2.Enabled = True
        Timer1.Stop()
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryDbDataSet.StaffTb' table. You can move, or remove it, as needed.
        Me.StaffTbTableAdapter.Fill(Me.LibraryDbDataSet.StaffTb)
        Timer1.Start()

        GroupBox3.Hide()
        GroupBox4.Hide()

        Button1.Text = "STAFF REGISTRY"
        Button2.Text = "STAFF INFO"

        FORMLOAD()
    End Sub

    Sub FORMLOAD()
        Label1.Text = "STAFF"
        Label2.Text = "RECORDS"
        Label3.Text = "WELCOME TO"
        Label4.Text = "STAFF RECORDS"
        Label5.Text = "INTERFACE"
        Label6.Text = "SEARCH"
        ds.Clear()

        CLEAR()

        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If

        Module1.conn()
        cn.Open()
        str = "select * from StaffTb"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "StaffTb")

        'for registration no
        Dim LastNo As Integer
        LastNo = ds.Tables("StaffTb").Rows.Count + 1
        If LastNo >= 0 Then
            StaffIDTextBox.Text = "SfID00" & LastNo
        Else
            StaffIDTextBox.Text = "SfID00" & 0
        End If

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        OpenFileDialog1.Filter = "Image Files (*.png;*.jpeg;*.ico;*.bmp;*.gif;*.jpg)|*.png;*.jpeg;*.ico;*.bmp;*.gif;*.jpg"
        OpenFileDialog1.ShowDialog()
        StaffPictureTextBox.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub StaffPictureTextBox_TextChanged(sender As Object, e As EventArgs) Handles StaffPictureTextBox.TextChanged
        If (System.IO.File.Exists(StaffPictureTextBox.Text)) Then
            PictureBox3.Image = Image.FromFile(StaffPictureTextBox.Text)
        End If
        If StaffPictureTextBox.Text = "" Then
            PictureBox3.Hide()
        Else
            PictureBox3.Show()
            Label9.Hide()
        End If
    End Sub

    Sub CLEAR()
        StaffIDTextBox.Clear()
        StaffEmailAddressTextBox.Clear()
        StaffFullNameTextBox.Clear()
        StaffMobileNoTextBox.Clear()
        StaffPhysicalAddressTextBox.Clear()
        StaffPictureTextBox.Clear()
        StaffProffesionTextBox.SelectedItem = Nothing
        StaffProffesionTextBox.ResetText()
        StaffReligionTextBox.Clear()
        StaffSalaryTextBox.Clear()
        StaffMaritalStatusTextBox.SelectedItem = Nothing
        StaffMaritalStatusTextBox.ResetText()
        StaffGenderTextBox.SelectedItem = Nothing
        StaffGenderTextBox.ResetText()
        StaffDOBTextBox.Value = Format(Now, "dd-MMM-yyyy")
        StaffDateEnrolledTextBox.Value = Format(Now, "dd-MMM-yyyy")
        PictureBox3.Image = Nothing
        Label9.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CLEAR()
        FORMLOAD()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        StaffDateEnrolledTextBox.Value = Format(Now, "dd-MMM-yyyy")
        salary()
    End Sub

    Sub salary()
        Dim salary As Single

        Select Case StaffProffesionTextBox.SelectedItem
            Case "Librarian"
                salary = 500
            Case "Security Personnel"
                salary = 350
            Case "Groundsman/Groundswoman"
                salary = 245
            Case Else
                StaffSalaryTextBox.Clear()
        End Select

        StaffSalaryTextBox.Text = salary
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If GroupBox3.Visible = False Then
            GroupBox3.Visible = True
            GroupBox4.Hide()
            Button2.Enabled = False
            Button1.Text = "RETURN HOME"
        Else
            Button1.Text = "STAFF REGISTRATION"
            Button2.Enabled = True
            GroupBox4.Hide()
            GroupBox3.Hide()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If GroupBox4.Visible = False Then
            GroupBox4.Visible = True
            GroupBox3.Hide()
            Button2.Text = "RETURN HOME"
            Button1.Enabled = False
        Else
            Button2.Text = "STAFF INFO"
            GroupBox4.Hide()
            GroupBox3.Hide()
            Button1.Enabled = True
        End If
    End Sub

    Private Sub StaffEmailAddressTextBox_Validated(sender As Object, e As EventArgs) Handles StaffEmailAddressTextBox.Validated
        Dim p As String

        p = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z]*@[0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"
        If Regex.IsMatch(StaffEmailAddressTextBox.Text, p) Then

        Else
            MsgBox("Invalid email address. Please try again!", MsgBoxStyle.Exclamation, "INVALID EMAIL ADDRESS")
        End If
    End Sub

    Private Sub StaffMobileNoTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles StaffMobileNoTextBox.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub StaffSalaryTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles StaffSalaryTextBox.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub StaffFullNameTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles StaffFullNameTextBox.KeyPress
        If Char.isnumber(e.keychar) AndAlso Not e.keychar = chr(keys.back) Then
            e.handled = True
        End If
    End Sub

    Private Sub StaffReligionTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles StaffReligionTextBox.KeyPress
        If Char.isnumber(e.keychar) AndAlso Not e.keychar = chr(keys.back) Then
            e.handled = True
        End If
    End Sub

    Private Sub StaffProffesionTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles StaffProffesionTextBox.KeyPress
        If Char.isnumber(e.keychar) AndAlso Not e.keychar = chr(keys.back) Then
            e.handled = True
        End If
    End Sub

    Private Sub StaffMaritalStatusTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles StaffMaritalStatusTextBox.KeyPress
        If Char.isnumber(e.keychar) AndAlso Not e.keychar = chr(keys.back) Then
            e.handled = True
        End If
    End Sub

    Private Sub StaffGenderTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles StaffGenderTextBox.KeyPress
        If Char.isnumber(e.keychar) AndAlso Not e.keychar = chr(keys.back) Then
            e.handled = True
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        StaffTbBindingSource.MovePrevious()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        StaffTbBindingSource.MoveNext()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        StaffTbBindingSource.RemoveCurrent()
        Me.Validate()
        Me.StaffTbBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LibraryDbDataSet)
    End Sub
  
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
    
        If txtsearch.Text = "" Then
            Call notFound()
            Exit Sub
        Else
            StaffTbBindingSource.Filter = "(Convert(StaffID, 'System.String') LIKE '" & txtsearch.Text & "')" & _
            "OR (StaffFullName LIKE '" & txtsearch.Text & "') OR (StaffGender LIKE '" & txtsearch.Text & "')" & _
             "OR (StaffDOB LIKE '" & txtsearch.Text & "') OR (StaffMobileNo LIKE '" & txtsearch.Text & "')" & _
             "OR (StaffPhysicalAddress LIKE '" & txtsearch.Text & "') OR (StaffEmailAddress LIKE '" & txtsearch.Text & "')" & _
             "OR (StaffProffesion LIKE '" & txtsearch.Text & "') OR (StaffSalary LIKE '" & txtsearch.Text & "')" & _
             "OR (StaffDateEnrolled LIKE '" & txtsearch.Text & "') OR (StaffMaritalStatus LIKE '" & txtsearch.Text & "')" & _
              "OR (StaffReligion LIKE '" & txtsearch.Text & "')" & _
              "OR (StaffPicture LIKE '" & txtsearch.Text & "')"

            If StaffTbBindingSource.Count <> 0 Then
                With DataGridView1
                    .DataSource = StaffTbBindingSource
                End With
            Else
                MsgBox("We couldn't find anything to show here. Double check your search criteria.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ITEM NOT FOUND")
                StaffTbBindingSource.Filter = Nothing
            End If
        End If
    End Sub


    Private Sub notFound()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim LastNo As Integer
        LastNo = ds.Tables("StaffTb").Rows.Count + 1
        If LastNo >= 0 Then
            StaffIDTextBox.Text = "SfID00" & LastNo
        Else
            StaffIDTextBox.Text = "SfID00" & 0
        End If

        If StaffFullNameTextBox.Text = "" Or StaffGenderTextBox.Text = "" Or StaffDOBTextBox.Value = Format(Now, "dd-MMM-yyyy") Or StaffMobileNoTextBox.Text = "" Or StaffPhysicalAddressTextBox.Text = "" Or StaffEmailAddressTextBox.Text = "" Or StaffProffesionTextBox.Text = "" Or StaffSalaryTextBox.Text = "" Or StaffDateEnrolledTextBox.Text = "" Or StaffMaritalStatusTextBox.Text = "" Or StaffReligionTextBox.Text = "" Or StaffPictureTextBox.Text = "" Then
            MsgBox("Fill in all details!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "INCOMPLETE DETAILS")
        Else
            SaveData()
        End If

    End Sub

    Private Sub SaveData()
        Dim ctr, i As Integer
        Dim staffname As String = ""

        ds.Clear()

        str = "select * from StaffTb"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "StaffTb")
        ctr = ds.Tables("StaffTb").Rows.Count - 1

        For i = 0 To ctr
            If StaffFullNameTextBox.Text = ds.Tables("StaffTb").Rows(i)(1).ToString Then
                staffname = ds.Tables("StaffTb").Rows(i)(1).ToString
            End If
        Next

        If staffname.Contains(StaffFullNameTextBox.Text) Then
            MsgBox("Staff already exists.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Operation Failed")
        Else
            Try
                cmd = New OleDbCommand
                cmd.CommandText = " insert into StaffTb values (@StaffID,@StaffFullName,@StaffGender,@StaffDOB,@StaffMobileNo,@StaffPhysicalAddress,@StaffEmailAddress,@StaffProffesion,@StaffSalary,@StaffDateEnrolled,@StaffMaritalStatus,@StaffReligion,@StaffPicture) "
                cmd.Parameters.AddWithValue("@StaffID", StaffIDTextBox.Text)
                cmd.Parameters.AddWithValue("@StaffFullName", StaffFullNameTextBox.Text)
                cmd.Parameters.AddWithValue("@StaffGender", StaffGenderTextBox.Text)
                cmd.Parameters.AddWithValue("@StaffDOB", StaffDOBTextBox.Text)
                cmd.Parameters.AddWithValue("@StaffMobileNo", StaffMobileNoTextBox.Text)
                cmd.Parameters.AddWithValue("@StaffPhysicalAddress", StaffPhysicalAddressTextBox.Text)
                cmd.Parameters.AddWithValue("@StaffEmailAddress", StaffEmailAddressTextBox.Text)
                cmd.Parameters.AddWithValue("@StaffProffesion", StaffProffesionTextBox.Text)
                cmd.Parameters.AddWithValue("@StaffSalary", StaffSalaryTextBox.Text)
                cmd.Parameters.AddWithValue("@StaffDateEnrolled", StaffDateEnrolledTextBox.Text)
                cmd.Parameters.AddWithValue("@StaffMaritalStatus", StaffMaritalStatusTextBox.Text)
                cmd.Parameters.AddWithValue("@StaffReligion", StaffReligionTextBox.Text)
                cmd.Parameters.AddWithValue("@StaffPicture", StaffPictureTextBox.Text)

                cmd.Connection = cn
                cmd.ExecuteNonQuery()

                MsgBox("New Staff successfully added.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Operation Successful")
            Catch ex As Exception
                MsgBox("Failed to add new Staff. Please try again.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Operation Failed")
            End Try
            Me.DataGridView1.Refresh()
            Me.Validate()
            Me.DataGridView1.Refresh()
            Me.StaffTbTableAdapter.Update(Me.LibraryDbDataSet)
            Me.DataGridView1.Refresh()
        End If

       
    End Sub

End Class