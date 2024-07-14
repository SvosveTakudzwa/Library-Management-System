Imports System.Text.RegularExpressions
Imports System.Data.OleDb
Imports System.IO
Public Class Form5

    Sub FORMLOAD()
        ds.Clear()
        Label1.Text = "SUPPLIER"
        Label2.Text = "RECORDS"
        Label3.Text = "WELCOME TO"
        Label4.Text = "SUPPLIER RECORDS"
        Label5.Text = "INTERFACE"
        Label6.Text = "SEARCH"

        clear()

        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        Module1.conn()
        cn.Open()
        str = "select * from SupplierTb"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "SupplierTb")

        'for registration no
        Dim LastNo As Integer
        LastNo = ds.Tables("SupplierTb").Rows.Count + 1
        If LastNo >= 0 Then
            SupplierIDTextBox.Text = "SpID00" & LastNo
        Else
            SupplierIDTextBox.Text = "SpID00" & 0
        End If
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryDbDataSet.SupplierTb' table. You can move, or remove it, as needed.
        Me.SupplierTbTableAdapter.Fill(Me.LibraryDbDataSet.SupplierTb)

        Button1.Text = "SUPPLIER REGISTRY"
        Button2.Text = "SUPPLIER INFO"

        GroupBox2.Visible = True
        GroupBox3.Visible = False
        GroupBox4.Visible = False

        FORMLOAD()
    End Sub

    Private Sub Form5_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form2.Enabled = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If GroupBox2.Visible = True Then
            Button1.Text = "RETURN HOME"
            GroupBox2.Visible = False
            GroupBox3.Visible = True
            Button2.Enabled = False
        Else
            GroupBox3.Visible = False
            GroupBox2.Visible = True
            Button1.Text = "SUPPLIER REGISTRY"
            Button2.Enabled = True
        End If
        Me.DataGridView1.Refresh()
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        OpenFileDialog1.Filter = "Image Files (*.png;*.jpeg;*.ico;*.bmp;*.gif;*.jpg)|*.png;*.jpeg;*.ico;*.bmp;*.gif;*.jpg"
        OpenFileDialog1.ShowDialog()
        SupplierPictureTextBox.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub SupplierPictureTextBox_TextChanged(sender As Object, e As EventArgs) Handles SupplierPictureTextBox.TextChanged
        If (System.IO.File.Exists(SupplierPictureTextBox.Text)) Then
            PictureBox3.Image = Image.FromFile(SupplierPictureTextBox.Text)
        End If
        If SupplierPictureTextBox.Text = "" Then
            PictureBox3.Hide()
        Else
            PictureBox3.Show()
            Label9.Hide()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        clear()
        FORMLOAD()
    End Sub

    Sub clear()
        PictureBox3.Image = Nothing
        Label9.Show()
        SupplierEmailAddressTextBox.Clear()
        SupplierPhysicalAddressTextBox.Clear()
        SupplierPictureTextBox.Clear()
        SupplierIDTextBox.Clear()
        SupplierNameTextBox.Clear()
        SupplierMobileNoTextBox.Clear()
        cmbTypeOfSupplies.SelectedItem = Nothing
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
            Button2.Text = "SUPPLIER INFO"
            Button1.Enabled = True
        End If
        Me.DataGridView1.Refresh()
    End Sub

    Private Sub SupplierEmailAddressTextBox_Validated(sender As Object, e As EventArgs) Handles SupplierEmailAddressTextBox.Validated
        Dim p As String

        p = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z]*@[0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"
        If Regex.IsMatch(SupplierEmailAddressTextBox.Text, p) Then

        Else
            MsgBox("You entered an invalid format of an email address. Please try again!", MsgBoxStyle.Exclamation, "INVALID EMAIL ADDRESS")
        End If
    End Sub

    Private Sub SupplierMobileNoTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SupplierMobileNoTextBox.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub SupplierNameTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SupplierNameTextBox.KeyPress
        If Char.isnumber(e.keychar) AndAlso Not e.keychar = chr(keys.back) Then
            e.handled = True
        End If
    End Sub

    Private Sub cmbTypeOfSupplies_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbTypeOfSupplies.KeyPress
        If Char.isnumber(e.keychar) AndAlso Not e.keychar = chr(keys.back) Then
            e.handled = True
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim LastNo As Integer
        LastNo = ds.Tables("SupplierTb").Rows.Count + 1
        If LastNo >= 0 Then
            SupplierIDTextBox.Text = "SpID00" & LastNo
        Else
            SupplierIDTextBox.Text = "SpID00" & 0
        End If

        If SupplierNameTextBox.Text = "" Or cmbTypeOfSupplies.Text = "" Or SupplierEmailAddressTextBox.Text = "" Or SupplierPhysicalAddressTextBox.Text = "" Or SupplierMobileNoTextBox.Text = "" Or SupplierPictureTextBox.Text = "" Then
            MsgBox("Fill in all details!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "INCOMPLETE DETAILS")
        Else
            SaveDaTa()
        End If
       
    End Sub

    Private Sub SaveDaTa()
        Dim ctr, i As Integer
        Dim suppliername As String = ""

        ds.Clear()

        str = "select * from SupplierTb"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "SupplierTb")
        ctr = ds.Tables("SupplierTb").Rows.Count - 1

        For i = 0 To ctr
            If SupplierNameTextBox.Text = ds.Tables("SupplierTb").Rows(i)(1).ToString Then
                suppliername = ds.Tables("SupplierTb").Rows(i)(1).ToString
            End If
        Next

        If suppliername.Contains(SupplierNameTextBox.Text) Then
            MsgBox("Staff already exists.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Operation Failed")
        Else
            Try
                cmd = New OleDbCommand
                cmd.CommandText = " insert into SupplierTb values (@SupplierID,@SupplierName,@TypeOfSupplies,@SupplierEmailAddress,@SupplierPhysicalAddress,@SupplierMobileNo,@SupplierPicture) "
                cmd.Parameters.AddWithValue("@SupplierID", SupplierIDTextBox.Text)
                cmd.Parameters.AddWithValue("@SupplierName", SupplierNameTextBox.Text)
                cmd.Parameters.AddWithValue("@TypeOfSupplies", cmbTypeOfSupplies.Text)
                cmd.Parameters.AddWithValue("@SupplierEmailAddress", SupplierEmailAddressTextBox.Text)
                cmd.Parameters.AddWithValue("@SupplierPhysicalAddress", SupplierPhysicalAddressTextBox.Text)
                cmd.Parameters.AddWithValue("@SupplierMobileNo", SupplierMobileNoTextBox.Text)
                cmd.Parameters.AddWithValue("@SupplierPicture", SupplierPictureTextBox.Text)

                cmd.Connection = cn
                cmd.ExecuteNonQuery()
                MsgBox("New Supplier successfully added.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Operation Successful")
            Catch ex As Exception
                MsgBox("Failed to add new Supplier. Please try again.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Operation Failed")
            End Try
            Me.Validate()
            Me.SupplierTbBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.LibraryDbDataSet)
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If TextBox1.Text = "" Then
            Call notFound()
            Exit Sub
        Else
            SupplierTbBindingSource.Filter = "(Convert(SupplierID, 'System.String') LIKE '" & TextBox1.Text & "')" & _
            "OR (SupplierName LIKE '" & TextBox1.Text & "') OR (TypeOfSupplies LIKE '" & TextBox1.Text & "')" & _
             "OR (SupplierEmailAddress LIKE '" & TextBox1.Text & "') OR (SupplierPhysicalAddress LIKE '" & TextBox1.Text & "')" & _
              "OR (SupplierMobileNo LIKE '" & TextBox1.Text & "')" & _
              "OR (SupplierPicture LIKE '" & TextBox1.Text & "')"

            If SupplierTbBindingSource.Count <> 0 Then
                With DataGridView1
                    .DataSource = SupplierTbBindingSource
                End With
            Else
                MsgBox("We couldn't find anything to show here. Double check your search criteria.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ITEM NOT FOUND")
                SupplierTbBindingSource.Filter = Nothing
            End If

        End If
    End Sub

    Private Sub notFound()

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        'btn delet
        SupplierTbBindingSource.RemoveCurrent()
        Me.Validate()
        Me.SupplierTbBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LibraryDbDataSet)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'btnnext
        SupplierTbBindingSource.MoveNext()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ' btnprev
        SupplierTbBindingSource.MovePrevious()
    End Sub
End Class