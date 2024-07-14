Imports System.Text.RegularExpressions
Imports System.Data.OleDb
Imports System.IO
Public Class Form3

    Private Sub Form3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form2.Enabled = True
    End Sub

    Sub FormLoad()
        Label1.Text = "BOOK"
        Label2.Text = "RECORDS"
        Label3.Text = "WELCOME TO"
        Label4.Text = "BOOK RECORDS"
        Label5.Text = "INTERFACE"
        ds.Clear()
        DateIssuedOutTextBox.Text = Format(Now, "dd-MMM-yyyy")
        ExpectedReturnDatePicker.Text = Format(Now, "dd-MMM-yyyy")
        DateReturnedPicker.Text = Format(Now, "dd-MMM-yyyy")
        DateTimePicker2.Text = Format(Now, "dd-MMM-yyyy")
        DateTimePicker3.Text = Format(Now, "dd-MMM-yyyy")

        LateReturnDaysTextBox.Hide()
        btnPay.Hide()
        lbllatereturndays.Hide()
        Label12.Hide()
        Label37.Hide()
        Label38.Hide()
        Label39.Hide()

        TaxFee()

        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        Module1.conn()
        cn.Open()

        BooKInvntryClear()
        BooKInventryLoad()
        bkissueclear()
        BooKIssuanceLoad()
        bukreturnklear()
        bkreturnload()
       
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryDbDataSet.BookReturnTb' table. You can move, or remove it, as needed.
        Me.BookReturnTbTableAdapter.Fill(Me.LibraryDbDataSet.BookReturnTb)
        'TODO: This line of code loads data into the 'LibraryDbDataSet.BookInventryTb' table. You can move, or remove it, as needed.
        Me.BookInventryTbTableAdapter.Fill(Me.LibraryDbDataSet.BookInventryTb)
        'TODO: This line of code loads data into the 'LibraryDbDataSet.BookIssueTb' table. You can move, or remove it, as needed.
        Me.BookIssueTbTableAdapter.Fill(Me.LibraryDbDataSet.BookIssueTb)
        Timer1.Start()

        lblAmountFined.Text = "Amount Fined"

        Button1.Text = "BOOK INVENTORY"
        Button2.Text = "BOOK ISSUANCE"
        Button3.Text = "BOOK RETURN"
        Button4.Text = "BOOK SEARCH"

        GroupBox3.Hide()
        GroupBox7.Hide()
        GroupBox10.Hide()

        FormLoad()
       
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If GroupBox3.Visible = False Then
            GroupBox3.Show()
            Button1.Text = "RETURN HOME"
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
        Else
            GroupBox3.Hide()
            Button1.Text = "BOOK INVENTORY"
            Button2.Enabled = True
            Button3.Enabled = True
            Button4.Enabled = True
        End If
    End Sub

    Private Sub BookPictureTextBox_TextChanged(sender As Object, e As EventArgs) Handles BookPictureTextBox.TextChanged
        If (System.IO.File.Exists(BookPictureTextBox.Text)) Then
            PictureBox3.Image = Image.FromFile(BookPictureTextBox.Text)
        End If
        If BookPictureTextBox.Text = "" Then
            PictureBox3.Hide()
        Else
            PictureBox3.Show()
            Label9.Hide()
        End If
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        OpenFileDialog1.Filter = "Image Files (*.png;*.jpeg;*.ico;*.bmp;*.gif;*.jpg)|*.png;*.jpeg;*.ico;*.bmp;*.gif;*.jpg"
        OpenFileDialog1.ShowDialog()
        BookPictureTextBox.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        OpenFileDialog1.Filter = "Image Files (*.png;*.jpeg;*.ico;*.bmp;*.gif;*.jpg)|*.png;*.jpeg;*.ico;*.bmp;*.gif;*.jpg"
        OpenFileDialog1.ShowDialog()
        TextBox5.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        OpenFileDialog1.Filter = "Image Files (*.png;*.jpeg;*.ico;*.bmp;*.gif;*.jpg)|*.png;*.jpeg;*.ico;*.bmp;*.gif;*.jpg"
        OpenFileDialog1.ShowDialog()
        MemberPictureTextBox.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        If (System.IO.File.Exists(TextBox5.Text)) Then
            PictureBox6.Image = Image.FromFile(TextBox5.Text)
        End If
        If TextBox5.Text = "" Then
            PictureBox6.Hide()
        Else
            PictureBox6.Show()
            lbl12.Hide()
        End If
    End Sub

    Private Sub MemberPictureTextBox_TextChanged(sender As Object, e As EventArgs) Handles MemberPictureTextBox.TextChanged
        If (System.IO.File.Exists(MemberPictureTextBox.Text)) Then
            PictureBox4.Image = Image.FromFile(MemberPictureTextBox.Text)
        End If
        If MemberPictureTextBox.Text = "" Then
            PictureBox4.Hide()
        Else
            PictureBox4.Show()
            Label6.Hide()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        DateIssuedOutTextBox.Text = Format(Now, "dd-MMM-yyyy")
        DateReturnedPicker.Text = Format(Now, "dd-MMM-yyyy")

        Dim d1 As DateTime = DateIssuedOutTextBox.Value
        Dim result As DateTime

        Select Case NumericUpDown1.Value
            Case 0
                result = Format(Now, "dd-MMM-yyyy")
            Case 1 To 25
                result = d1.AddDays(4)
            Case 1 To 50
                result = d1.AddDays(4)
            Case 51 To 75
                result = d1.AddDays(9)
            Case 51 To 99
                result = d1.AddDays(9)
            Case 100 To 124
                result = d1.AddDays(14)
            Case 125 To 200
                result = d1.AddDays(22)
            Case 201 To 300
                result = d1.AddDays(25)
            Case Else
                result = d1.AddDays(31)
        End Select

        ExpectedReturnDatePicker.Value = result
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If GroupBox10.Visible = False Then
            GroupBox10.Visible = True
            Button3.Text = "RETURN HOME"
            Button1.Enabled = False
            Button2.Enabled = False
            Button4.Enabled = False
        Else
            GroupBox10.Visible = False
            Button3.Text = "BOOK RETURN"
            Button1.Enabled = True
            Button2.Enabled = True
            Button4.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If GroupBox7.Visible = False And Button2.Text = "BOOK ISSUANCE" Then
            GroupBox7.Visible = True
            Button2.Text = "RETURN HOME"
            Button1.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
        Else
            Button2.Text = "BOOK ISSUANCE"
            GroupBox7.Visible = False
            Button1.Enabled = True
            Button3.Enabled = True
            Button4.Enabled = True
        End If
    End Sub

    Sub OverDueCalc()

        Dim d1 As DateTime = DateReturnedPicker.Value
        Dim d2 As DateTime = DateTimePicker2.Value

        Dim result As TimeSpan = d1.Subtract(d2)
        LateReturnDaysTextBox.Text = result.TotalDays

    End Sub

    Sub BookState()
        Dim Fcnd As Double

        Select Case ComboBox1.SelectedItem
            Case Is = "Bad"
                Fcnd = 1.25
            Case Is = "Good"
                Fcnd = 0
            Case Is = "Moderate"
                Fcnd = 0.5
        End Select

        Label37.Text = Fcnd
    End Sub

    Sub LrFineCalc()
        Dim Lrdfine As Double
        Dim Lconst As Double

        OverDueCalc()

        Dim dtot As Integer = Val(LateReturnDaysTextBox.Text)


        Select Case Val(dtot)

            Case Is <= 0
                Lconst = 0
            Case 1 To 3
                Lconst = 0.2
            Case 4 To 7
                Lconst = 0.3
            Case 5 To 9
                Lconst = 0.4
            Case 10 To 15
                Lconst = 0.5
            Case Else
                Lconst = 1.5

        End Select

        Lrdfine = ((dtot) * (Lconst))
        Label38.Text = Lrdfine
    End Sub

    Sub TotFine()
        Dim TotalFine As Double
        Dim Fcnd As Double = Val(Label37.Text)
        Dim Lrdfine As Double = Val(Label38.Text)
        Dim TaxFee As Double = Val(Label39.Text)

        TotalFine = Fcnd + Lrdfine + TaxFee
        AmountFinedTextBox.Text = TotalFine
        AmountFinedTextBox.Text = Format(Val(AmountFinedTextBox.Text), "0.00")
    End Sub

    Private Sub bkLoStFeE()
        Dim bkFee As Single

        Select Case NumericUpDown2.Value
            Case 0
                bkFee = 0
            Case 1 To 25
                bkFee = 13 * 0.25
            Case 1 To 50
                bkFee = 25 * 0.25
            Case 51 To 75
                bkFee = 38 * 0.25
            Case 51 To 99
                bkFee = 50 * 0.25
            Case 100 To 124
                bkFee = 62 * 0.25
            Case 125 To 200
                bkFee = 75 * 0.25
            Case 201 To 300
                bkFee = 85 * 0.25
            Case Else
                bkFee = 90.5 * 0.25
        End Select
        Label12.Text = bkFee
    End Sub

    Sub BookLost()
        Dim FTax As Double = Format(Val(Label39.Text), "0.00")
        Dim bkFee As Double = Format(Val(Label12.Text), "0.00")
        Dim fee As Double
        fee = 75

        lblAmountFined.Text = "Book Lost Fee"
        AmountFinedTextBox.Text = fee + FTax + bkFee
        AmountFinedTextBox.Text = Format(Val(AmountFinedTextBox.Text), "0.00")
    End Sub

    Sub TaxFee()
        Dim CatridgeFee As Double = 0.25
        Dim LibrarianFee As Double = 0.15
        Dim GovTax As Double
        Dim FTax As Double

        GovTax = ((((0.5) * (CatridgeFee)) + ((0.5) * (LibrarianFee))) + 0.25)

        FTax = CatridgeFee + LibrarianFee + GovTax
        Label39.Text = FTax

    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Me.Enabled = False
        Form9.Timer1.Start()
        Form9.Show()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim ctr, i As Integer
        Dim bkstion As String = ""
        Dim idate As DateTime = DateTimePicker2.Value
        Dim midate As DateTime = DateReturnedPicker.Value

        ds.Clear()

        str = "select * from BookIssueTb"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "BookIssueTb")
        ctr = ds.Tables("BookIssueTb").Rows.Count - 1

        For i = 0 To ctr
            If ComboBox1.Text = ds.Tables("BookIssueTb").Rows(i)(19).ToString Then
                bkstion = ds.Tables("BookIssueTb").Rows(i)(19).ToString
            End If
        Next

        If idate = midate And ComboBox1.SelectedItem = "Good" Then
            lbllatereturndays.Show()
            lbllatereturndays.Text = "Book brought just in time."
            AmountFinedTextBox.Text = "0.00"
        ElseIf idate > midate And ComboBox1.SelectedItem = "Good" Then
            lbllatereturndays.Show()
            lbllatereturndays.Text = "Book brought in earlier than expected. Thank you."
            AmountFinedTextBox.Text = "0.00"
        Else
            If ComboBox1.SelectedItem = bkstion Then
                cndtion()
            Else
                LrFineCalc()
                BookState()
                TotFine()
            End If
        End If
        Timer2.Stop()
    End Sub

    Sub cndtion()
        LrFineCalc()
        TotFine()
    End Sub

    Private Sub LateReturnDaysTextBox_TextChanged(sender As Object, e As EventArgs) Handles LateReturnDaysTextBox.TextChanged
        bkReturn()

    End Sub

    Sub bkReturn()
        Select Case Val(LateReturnDaysTextBox.Text)
            Case Is < 0
                lbllatereturndays.Text = "Bravo, book brought in before the Due Date."
            Case Is = 0
                lbllatereturndays.Text = "Book brought in just in time. Bravo!"
            Case Is > 0
                lbllatereturndays.Text = "Book return delayed by " + LateReturnDaysTextBox.Text + " days."
            Case Else
                lbllatereturndays.Hide()
        End Select
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If TextBox14.Text = "" And CheckBox2.CheckState = CheckState.Unchecked Then
            MsgBox("Fill in all details!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "INCOMPLETE DETAILS")
        ElseIf TextBox14.Text = TextBox14.Text And CheckBox2.CheckState = CheckState.Checked Then
            Timer2.Start()
        ElseIf TextBox14.Text = TextBox14.Text And CheckBox2.CheckState = CheckState.Unchecked Then
            Dim ilost As MsgBoxResult
            ilost = MsgBox("Is the book is lost?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "BOOK LOST PROMPT")
            If ilost = MsgBoxResult.Yes Then
                ComboBox1.Text = "LOST"
                bkLoStFeE()
                BookLost()
                lbllatereturndays.Hide()
            Else
                MsgBox("Indicate that the book is available then.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "BOOK LOST PROMPT")
            End If
        End If
    End Sub

    Sub proceed()
        If Val(AmountFinedTextBox.Text) > 0 Then
            Button13.Enabled = False
            btnPay.Show()
            lbllatereturndays.Show()
        Else
            Button13.Enabled = True
            btnPay.Hide()
            lbllatereturndays.Hide()
        End If
    End Sub

    Private Sub AmountFinedTextBox_TextChanged(sender As Object, e As EventArgs) Handles AmountFinedTextBox.TextChanged
        proceed()

    End Sub

    Private Sub TextBox11_Validated(sender As Object, e As EventArgs) Handles TextBox11.Validated
        Dim p As String

        p = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z]*@[0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"
        If Regex.IsMatch(TextBox11.Text, p) Then

        Else
            MsgBox("You entered an invalid format of an email address. Please try again!", MsgBoxStyle.Exclamation, "INVALID EMAIL ADDRESS")
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

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        'Button9.Text = "SAVE"
        'Button10.Text = "UPDATE"
        UserFullNameTextBox.Text = Form1.txtuserfullname.Text
        TextBox7.Text = Form1.txtuserfullname.Text
    End Sub

    Private Sub aktvate_Tick(sender As Object, e As EventArgs) Handles aktvate.Tick
        If Form2.Label3.Text.Contains("ADMIN") Then
            Me.Button1.Show()
            Me.Button2.Location = New System.Drawing.Point(231, 9)
            Me.Button3.Location = New System.Drawing.Point(451, 9)
            Me.Button4.Location = New System.Drawing.Point(667, 9)
        Else
            Me.Button1.Hide()
            Me.Button2.Location = New System.Drawing.Point(124, 9)
            Me.Button3.Location = New System.Drawing.Point(344, 9)
            Me.Button4.Location = New System.Drawing.Point(560, 9)
        End If
    End Sub

    Private Sub TextBox17_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox17.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub NumericUpDown2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NumericUpDown2.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub AmountFinedTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AmountFinedTextBox.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox13_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox13.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub NumericUpDown1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NumericUpDown1.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub MemberMobileNoTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MemberMobileNoTextBox.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub BookISBNTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BookISBNTextBox.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub pagenumericupdown_KeyPress(sender As Object, e As KeyPressEventArgs) Handles pagenumericupdown.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox20_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox20.KeyPress
        If Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox15_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox15.KeyPress
        If Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ComboBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox2.KeyPress
        If Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox18_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox18.KeyPress
        If Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox7.KeyPress
        If Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        If Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox9_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox9.KeyPress
        If Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        If Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ComboBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox3.KeyPress
        If Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub UserFullNameTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles UserFullNameTextBox.KeyPress
        If Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BookConditionCombo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BookConditionCombo.KeyPress
        If Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub MemberFullNameTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MemberFullNameTextBox.KeyPress
        If Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BookNameTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BookNameTextBox.KeyPress
        If Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BookEditionComboBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BookEditionComboBox.KeyPress
        If Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BookAuthorTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BookAuthorTextBox.KeyPress
        If Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BookCategoryComboBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BookCategoryComboBox.KeyPress
        If Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BookTypeComboBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BookTypeComboBox.KeyPress
        If Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BookPublisherTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BookPublisherTextBox.KeyPress
        If Char.IsNumber(e.KeyChar) AndAlso Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Sub BooKInvntryClear()
        BookAuthorTextBox.Clear()
        BookAvailabilityCheckBox.CheckState = CheckState.Unchecked
        SupplierIDTextBox.Clear()
        pagenumericupdown.Value = 0
        BookPublisherTextBox.Clear()
        PictureBox3.Image = Nothing
        Label6.Show()
        Label9.Show()
        lbl12.Show()
        BookISBNTextBox.Clear()
        BookEditionComboBox.Text = ""
        YearPublishedDatePicker.Value = Format(Now, "dd-MMM-yyyy")
        BookTypeComboBox.Text = ""
        BookPictureTextBox.Clear()
        BookIDTextBox.Clear()
        BookCategoryComboBox.Text = ""
        BookNameTextBox.Clear()
        Button6.Text = "SAVE"
        Button7.Text = "UPDATE"
        BookIDTextBox.ReadOnly = True
    End Sub

    Sub BooKInventryLoad()
        BooKInvntryClear()
        ds.Clear()
        str = "select * from BookInventryTb"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "BookInventryTb")

        'for registration no
        Dim LastNo As Integer
        LastNo = ds.Tables("BookInventryTb").Rows.Count + 1
        If LastNo >= 0 Then
            BookIDTextBox.Text = "BkID00" & LastNo
        Else
            BookIDTextBox.Text = "BkID00" & 0
        End If
    End Sub


    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        BooKInvntryClear()
        FormLoad()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim LastNo As Integer
        LastNo = ds.Tables("BookInventryTb").Rows.Count + 1
        If LastNo >= 0 Then
            BookIDTextBox.Text = "BkID00" & LastNo
        Else
            BookIDTextBox.Text = "BkID00" & 0
        End If

        If BookNameTextBox.Text = "" Or BookAvailabilityCheckBox.CheckState = CheckState.Unchecked Or BookPublisherTextBox.Text = "" Or BookAuthorTextBox.Text = "" Or BookISBNTextBox.Text = "" Or BookEditionComboBox.SelectedItem = Nothing Or pagenumericupdown.Value = 0 Or BookTypeComboBox.Text = "" Or BookCategoryComboBox.SelectedItem = Nothing Or BookPictureTextBox.Text = "" Or SupplierIDTextBox.Text = "" Then
            MsgBox("Fill in all details!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "INCOMPLETE DETAILS")
        Else
            SaVeBoOk()
        End If

    End Sub

    Private Sub SaVeBoOk()
        Dim ctr, i As Integer
        Dim bookname As String = ""
        Dim booknisbn As String = ""

        ds.Clear()

        str = "select * from BookInventryTb"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "BookInventryTb")
        ctr = ds.Tables("BookInventryTb").Rows.Count - 1

        For i = 0 To ctr
            If BookNameTextBox.Text = ds.Tables("BookInventryTb").Rows(i)(1).ToString And BookISBNTextBox.Text = ds.Tables("BookInventryTb").Rows(i)(6).ToString Then
                bookname = ds.Tables("BookInventryTb").Rows(i)(1).ToString
                booknisbn = ds.Tables("BookInventryTb").Rows(i)(6).ToString
            End If
        Next

        If bookname.Contains(BookNameTextBox.Text) And booknisbn.Contains(BookISBNTextBox.Text) Then
            MsgBox("Book already exists.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Operation Failed")
        Else
            Try
                cmd = New OleDbCommand
                cmd.CommandText = " insert into BookInventryTb values (@BookID,@BookName,@BookAvailability,@YearPublished,@BookPublisher,@BookAuthor,@BookISBN,@BookEdition,@NoOfPages,@BookType,@BookCategory,@BookPicture,@SupplierID) "
                cmd.Parameters.AddWithValue("@BookID", BookIDTextBox.Text)
                cmd.Parameters.AddWithValue("@BookName", BookNameTextBox.Text)
                cmd.Parameters.AddWithValue("@BookAvailability", BookAvailabilityCheckBox.CheckState)
                cmd.Parameters.AddWithValue("@YearPublished", YearPublishedDatePicker.Text)
                cmd.Parameters.AddWithValue("@BookPublisher", BookPublisherTextBox.Text)
                cmd.Parameters.AddWithValue("@BookAuthor", BookAuthorTextBox.Text)
                cmd.Parameters.AddWithValue("@BookISBN", BookISBNTextBox.Text)
                cmd.Parameters.AddWithValue("@BookEdition", BookEditionComboBox.Text)
                cmd.Parameters.AddWithValue("@NoOfPages", pagenumericupdown.Value)
                cmd.Parameters.AddWithValue("@BookType", BookTypeComboBox.Text)
                cmd.Parameters.AddWithValue("@BookCategory", BookCategoryComboBox.Text)
                cmd.Parameters.AddWithValue("@BookPicture", BookPictureTextBox.Text)
                cmd.Parameters.AddWithValue("@SupplierID", SupplierIDTextBox.Text)

                cmd.Connection = cn
                cmd.ExecuteNonQuery()
                MsgBox("New Book successfully added.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Operation Successful")
            Catch ex As Exception
                MsgBox("Failed to add new Book. Please try again.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Operation Failed")
            End Try
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        bkissueclear()
        FormLoad()
    End Sub

    Sub bkissueclear()
        MemberEmailAddressTextBox.Clear()
        PictureBox6.Image = Nothing
        TansactionIDTextBox.Clear()
        TextBox6.Clear()
        MemberPictureTextBox.Clear()
        TextBox2.Clear()
        TextBox5.Clear()
        PictureBox4.Image = Nothing
        DateTimePicker1.Value = Format(Now, "dd-MMM-yyyy")
        TextBox1.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        MemberFullNameTextBox.Clear()
        MemberPhysicalAddressTextBox.Clear()
        MemberMobileNoTextBox.Clear()
        MemberIDTextBox.Clear()
        NumericUpDown1.Value = 0
        DateIssuedOutTextBox.Value = Format(Now, "dd-MMM-yyyy")
        BookConditionCombo.Text = ""
        CheckBox1.CheckState = CheckState.Unchecked
        ExpectedReturnDatePicker.Value = Format(Now, "dd-MMM-yyyy")
        ComboBox3.Text = ""
        Label6.Show()
        Label9.Show()
        lbl12.Show()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim ctr, i As Integer
        Dim bkname As String = ""
        Dim bkauthor As String = ""
        Dim bkisbn As String = ""
        Dim bkedition As String = ""
        Dim bkpublisher As String = ""
        Dim bkpicpath As String = ""
        Dim pages As Integer
        'Dim bkyrpubl As datetime
        'Dim bkavaibty As String = ""

        ds.Clear()

        str = "select * from BookInventryTb"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "BookInventryTb")
        ctr = ds.Tables("BookInventryTb").Rows.Count - 1

        For i = 0 To ctr
            If TextBox2.Text = ds.Tables("BookInventryTb").Rows(i)(0).ToString Then
                bkname = ds.Tables("BookInventryTb").Rows(i)(1).ToString
                bkauthor = ds.Tables("BookInventryTb").Rows(i)(5).ToString
                bkisbn = ds.Tables("BookInventryTb").Rows(i)(6).ToString
                bkedition = ds.Tables("BookInventryTb").Rows(i)(7).ToString
                bkpublisher = ds.Tables("BookInventryTb").Rows(i)(4).ToString
                bkpicpath = ds.Tables("BookInventryTb").Rows(i)(11).ToString
                pages = ds.Tables("BookInventryTb").Rows(i)(8).ToString
                'bkyrpubl = ds.Tables("BookInventryTb").Rows(i)(3).ToString
                'bkavaibty = ds.Tables("BookInventryTb").Rows(i)(2).ToString
            Else
                PictureBox6.Image = Nothing
                lbl12.Show()
            End If
        Next
        TextBox6.Text = bkname
        TextBox1.Text = bkauthor
        TextBox3.Text = bkisbn
        ComboBox3.Text = bkedition
        TextBox4.Text = bkpublisher
        TextBox5.Text = bkpicpath
        NumericUpDown1.Value = pages
        'DateTimePicker1.Text = bkyrpubl
        'CheckBox1.CheckState = bkavaibty
    End Sub

    Private Sub MemberIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles MemberIDTextBox.TextChanged
        Dim ctr, i As Integer
        Dim fullname As String = ""
        Dim mobno As String = ""
        Dim emailadd As String = ""
        Dim phyadd As String = ""
        Dim mbrpicpath As String = ""

        ds.Clear()

        str = "select * from MemberTb"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "MemberTb")
        ctr = ds.Tables("MemberTb").Rows.Count - 1

        For i = 0 To ctr
            If MemberIDTextBox.Text = ds.Tables("MemberTb").Rows(i)(0).ToString Then
                fullname = ds.Tables("MemberTb").Rows(i)(1).ToString
                mobno = ds.Tables("MemberTb").Rows(i)(4).ToString
                emailadd = ds.Tables("MemberTb").Rows(i)(6).ToString
                phyadd = ds.Tables("MemberTb").Rows(i)(5).ToString
                mbrpicpath = ds.Tables("MemberTb").Rows(i)(9).ToString
            Else
                PictureBox4.Image = Nothing
                Label6.Show()
            End If
        Next
        MemberFullNameTextBox.Text = fullname
        MemberMobileNoTextBox.Text = mobno
        MemberEmailAddressTextBox.Text = emailadd
        MemberPhysicalAddressTextBox.Text = phyadd
        MemberPictureTextBox.Text = mbrpicpath
    End Sub

    Private Sub TextBox19_TextChanged(sender As Object, e As EventArgs) Handles TextBox19.TextChanged
        If (System.IO.File.Exists(TextBox19.Text)) Then
            PictureBox11.Image = Image.FromFile(TextBox19.Text)
        End If
        If TextBox19.Text = "" Then
            PictureBox11.Hide()
        Else
            PictureBox11.Show()
            Labell12.Hide()
        End If
    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged
        If (System.IO.File.Exists(TextBox10.Text)) Then
            PictureBox8.Image = Image.FromFile(TextBox10.Text)
        End If
        If TextBox10.Text = "" Then
            PictureBox8.Hide()
        Else
            PictureBox8.Show()
            lble12.Hide()
        End If
    End Sub

    Sub BooKIssuanceLoad()

        bkissueclear()

        str = "select * from BookIssueTb"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "BookIssueTb")

        'for registration no
        Dim LastNo As Integer
        LastNo = ds.Tables("BookIssueTb").Rows.Count + 1
        If LastNo >= 0 Then
            TansactionIDTextBox.Text = "TrnID00" & LastNo
        Else
            TansactionIDTextBox.Text = "TrnID00" & 0
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim LastNo As Integer
        LastNo = ds.Tables("BookIssueTb").Rows.Count + 1
        If LastNo >= 0 Then
            BookIDTextBox.Text = "TrnID00" & LastNo
        Else
            BookIDTextBox.Text = "TrnID00" & 0
        End If

        If TextBox2.Text = "" Or CheckBox1.CheckState = CheckState.Unchecked Or TextBox6.Text = "" Or TextBox4.Text = "" Or TextBox1.Text = "" Or ComboBox3.SelectedItem = Nothing Or TextBox3.Text = "" Or NumericUpDown1.Value = 0 Or TextBox5.Text = "" Or MemberIDTextBox.Text = "" Or MemberFullNameTextBox.Text = "" Or MemberMobileNoTextBox.Text = "" Or MemberEmailAddressTextBox.Text = "" Or MemberPhysicalAddressTextBox.Text = "" Or MemberPictureTextBox.Text = "" Or DateIssuedOutTextBox.Value <> Format(Now, "dd-MMM-yyyy") Or ExpectedReturnDatePicker.Value = Format(Now, "dd-MMM-yyyy") Or BookConditionCombo.SelectedItem = Nothing Or UserFullNameTextBox.Text = "" Then
            MsgBox("Fill in all details!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "INCOMPLETE DETAILS")
        Else
            SaVEIssuance()
        End If

    End Sub

    Private Sub SaVEIssuance()
        Dim ctr, i As Integer
        Dim bookid As String = ""
        Dim mbrid As String = ""
        Dim mbrName As String = ""
        Dim dtereturn As DateTime
        ds.Clear()

        str = "select * from BookIssueTb"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "BookIssueTb")
        ctr = ds.Tables("BookIssueTb").Rows.Count - 1

        For i = 0 To ctr
            If TextBox2.Text = ds.Tables("BookIssueTb").Rows(i)(1).ToString Or MemberIDTextBox.Text = ds.Tables("BookIssueTb").Rows(i)(11).ToString Then
                bookid = ds.Tables("BookIssueTb").Rows(i)(1).ToString
                mbrid = ds.Tables("BookIssueTb").Rows(i)(11).ToString
                mbrName = ds.Tables("BookIssueTb").Rows(i)(12).ToString
                dtereturn = ds.Tables("BookIssueTb").Rows(i)(18).ToString
            End If
        Next

        If bookid.Contains(TextBox2.Text) And dtereturn > DateIssuedOutTextBox.Value Then
            MsgBox("Book already issued out.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Operation Failed")
        ElseIf mbrid.Contains(MemberIDTextBox.Text) And dtereturn > DateIssuedOutTextBox.Value Then
            MsgBox(mbrName + " already borrowed a book.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Operation Failed")
        Else
            Try
                cmd = New OleDbCommand
                cmd.CommandText = " insert into BookIssueTb values (@TransactionID,@BookID,@BookName,@BookAvailability,@YearPublished,@BookPublisher,@BookAuthor,@BookISBN,@BookEdition,@NoOfPages,@BookPicture,@MemberID,@MemberFullName,@MemberMobileNo,@MemberEmailAddress,@MemberPhysicalAddress,@MemberPicture,@DateIssuedOut,@ExpectedReturnDate,@BookCondition,@UserFullName) "
                cmd.Parameters.AddWithValue("@TransactionID", TansactionIDTextBox.Text)
                cmd.Parameters.AddWithValue("@BookID", TextBox2.Text)
                cmd.Parameters.AddWithValue("@BookName", TextBox6.Text)
                cmd.Parameters.AddWithValue("@BookAvailability", CheckBox1.CheckState)
                cmd.Parameters.AddWithValue("@YearPublished", DateTimePicker1.Text) 'did not use this one
                cmd.Parameters.AddWithValue("@BookPublisher", TextBox4.Text)
                cmd.Parameters.AddWithValue("@BookAuthor", TextBox1.Text)
                cmd.Parameters.AddWithValue("@BookISBN", TextBox3.Text)
                cmd.Parameters.AddWithValue("@BookEdition", ComboBox3.Text)
                cmd.Parameters.AddWithValue("@NoOfPages", NumericUpDown1.Value)
                cmd.Parameters.AddWithValue("@BookPicture", TextBox5.Text)
                cmd.Parameters.AddWithValue("@MemberID", MemberIDTextBox.Text)
                cmd.Parameters.AddWithValue("@MemberFullName", MemberFullNameTextBox.Text)
                cmd.Parameters.AddWithValue("@MemberMobileNo", MemberMobileNoTextBox.Text)
                cmd.Parameters.AddWithValue("@MemberEmailAddress", MemberEmailAddressTextBox.Text)
                cmd.Parameters.AddWithValue("@MemberPhysicalAddress", MemberPhysicalAddressTextBox.Text)
                cmd.Parameters.AddWithValue("@MemberPicture", MemberPictureTextBox.Text)
                cmd.Parameters.AddWithValue("@DateIssuedOut", DateIssuedOutTextBox.Text)
                cmd.Parameters.AddWithValue("@ExpectedReturnDate", ExpectedReturnDatePicker.Text)
                cmd.Parameters.AddWithValue("@BookCondition", BookConditionCombo.Text)
                cmd.Parameters.AddWithValue("@UserFullName", UserFullNameTextBox.Text)

                cmd.Connection = cn
                cmd.ExecuteNonQuery()
                MsgBox("Book Issue Transaction Successful..", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Transaction Successful")
            Catch ex As Exception
                MsgBox("Transaction Failed. Please try again.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Transaction Failed")
            End Try
        End If
    End Sub


    Sub bkreturnload()
        bukreturnklear()
       
        str = "select * from BookIssueTb"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "BookIssueTb")


        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If

        Module1.conn()
        cn.Open()
        str = "select * from BookReturnTb"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "BookReturnTb")

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        bukreturnklear()
    End Sub

    Sub bukreturnklear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
        TextBox11.Clear()
        TextBox12.Clear()
        TextBox13.Clear()
        TextBox14.Clear()
        TextBox15.Clear()
        TextBox16.Clear()
        TextBox17.Clear()
        TextBox18.Clear()
        TextBox19.Clear()
        TextBox20.Clear()
        CheckBox2.CheckState = CheckState.Unchecked
        ComboBox1.ResetText()
        ComboBox2.ResetText()
        PictureBox8.Image = Nothing
        PictureBox11.Image = Nothing
        lble12.Show()
        Labell12.Show()
        lblAmountFined.Text = "Amount Fined"
        NumericUpDown2.Value = 0
        DateTimePicker2.Value = Format(Now, "dd-MMM-yyyy")
        DateTimePicker3.Value = Format(Now, "dd-MMM-yyyy")
        DateTimePicker4.Value = Format(Now, "dd-MMM-yyyy")
        DateReturnedPicker.Value = Format(Now, "dd-MMM-yyyy")
        AmountFinedTextBox.Clear()
    End Sub

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles TextBox14.TextChanged
        Dim ctr, i As Integer
        Dim bkkidd As String = ""
        Dim bktitle As String = ""
        Dim bkkauth As String = ""
        Dim bkkisbn As String = ""
        Dim bkkedition As String = ""
        Dim bkkpublisher As String = ""
        'Dim dtissud As DateTime
        'Dim bkkduedte As DateTime
        Dim bkkpic As String = ""
        'Dim yrpubl As String
        Dim bkkpages As Integer
        Dim mbpic As String = ""
        Dim mbid As String = ""
        Dim mbfllnme As String = ""
        Dim mbmobno As Decimal
        Dim mbemadd As String = ""
        Dim mbphyadd As String = ""

        ds.Clear()

        str = "select * from BookIssueTb"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "BookIssueTb")
        ctr = ds.Tables("BookIssueTb").Rows.Count - 1

        For i = 0 To ctr
            If TextBox14.Text = ds.Tables("BookIssueTb").Rows(i)(0).ToString Then
                bkkidd = ds.Tables("BookIssueTb").Rows(i)(1).ToString
                bktitle = ds.Tables("BookIssueTb").Rows(i)(2).ToString
                bkkauth = ds.Tables("BookIssueTb").Rows(i)(6).ToString
                bkkisbn = ds.Tables("BookIssueTb").Rows(i)(7).ToString
                bkkedition = ds.Tables("BookIssueTb").Rows(i)(8).ToString
                bkkpublisher = ds.Tables("BookIssueTb").Rows(i)(5).ToString
                'dtissud = ds.Tables("BookIssueTb").Rows(i)(17).ToString
                'bkkduedte = ds.Tables("BookIssueTb").Rows(i)(18).ToString
                bkkpic = ds.Tables("BookIssueTb").Rows(i)(10).ToString
                'yrpubl = ds.Tables("BookIssueTb").Rows(i)(4).ToString
                bkkpages = ds.Tables("BookIssueTb").Rows(i)(9).ToString
                mbpic = ds.Tables("BookIssueTb").Rows(i)(16).ToString
                mbid = ds.Tables("BookIssueTb").Rows(i)(11).ToString
                mbfllnme = ds.Tables("BookIssueTb").Rows(i)(12).ToString
                mbmobno = ds.Tables("BookIssueTb").Rows(i)(13).ToString
                mbemadd = ds.Tables("BookIssueTb").Rows(i)(14).ToString
                mbphyadd = ds.Tables("BookIssueTb").Rows(i)(15).ToString
            Else
                PictureBox11.Image = Nothing
                Labell12.Show()
                PictureBox8.Image = Nothing
                lble12.Show()
            End If
        Next
        TextBox16.Text = bkkidd
        TextBox20.Text = bktitle
        TextBox15.Text = bkkauth
        TextBox17.Text = bkkisbn
        ComboBox2.Text = bkkedition
        TextBox18.Text = bkkpublisher
        'DateTimePicker3.Value = Convert.ToDateTime(dtissud)
        'DateTimePicker2.Value = bkkduedte
        TextBox19.Text = bkkpic
        'DateTimePicker4.Value = Convert.ToDateTime(yrpubl)
        NumericUpDown2.Value = bkkpages
        TextBox10.Text = mbpic
        TextBox8.Text = mbid
        TextBox9.Text = mbfllnme
        TextBox13.Text = mbmobno
        TextBox11.Text = mbemadd
        TextBox12.Text = mbphyadd
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim LastNo As Integer
        LastNo = ds.Tables("BookReturnTb").Rows.Count + 1
        If LastNo >= 0 Then
            BookIDTextBox.Text = "TrnID00" & LastNo
        Else
            BookIDTextBox.Text = "TrnID00" & 0
        End If

        If TextBox16.Text = "" Or CheckBox2.CheckState = CheckState.Unchecked Or TextBox20.Text = "" Or TextBox18.Text = "" Or TextBox15.Text = "" Or ComboBox2.SelectedItem = Nothing Or TextBox17.Text = "" Or NumericUpDown2.Value = 0 Or TextBox19.Text = "" Or TextBox8.Text = "" Or TextBox9.Text = "" Or TextBox13.Text = "" Or TextBox11.Text = "" Or TextBox12.Text = "" Or TextBox10.Text = "" Or DateTimePicker3.Value = Format(Now, "dd-MMM-yyyy") Or ComboBox1.SelectedItem = Nothing Or TextBox7.Text = "" Or AmountFinedTextBox.Text = "" Then
            MsgBox("Fill in all details!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "INCOMPLETE DETAILS")
        Else
            BkReturnSave()
        End If
    End Sub

    Private Sub BkReturnSave()
        Dim ctr, i As Integer
        Dim trnsid As String = ""
        Dim dteissuedout As String = ""

        ds.Clear()

        str = "select * from BookReturnTb"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "BookReturnTb")
        ctr = ds.Tables("BookReturnTb").Rows.Count - 1

        For i = 0 To ctr
            If TextBox14.Text = ds.Tables("BookReturnTb").Rows(i)(0).ToString Then
                trnsid = ds.Tables("BookReturnTb").Rows(i)(0).ToString
                dteissuedout = ds.Tables("BookReturnTb").Rows(i)(0).ToString
            End If
        Next

        If trnsid.Contains(TextBox14.Text) And dteissuedout.Contains(DateTimePicker3.Text) Then
            MsgBox("Book already returned.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Operation Failed")
        Else
            Try
                cmd = New OleDbCommand
                cmd.CommandText = " insert into BookReturnTb values (@TransactionID,@BookID,@BookName,@BookAvailability,@YearPublished,@BookPublisher,@BookAuthor,@BookISBN,@BookEdition,@NoOfPages,@BookPicture,@MemberID,@MemberFullName,@MemberMobileNo,@MemberEmailAddress,@MemberPhysicalAddress,@MemberPicture,@DateIssuedOut,@ExpectedReturnDate,@DateReturned,@LateReturnDays,@BookCondition,@UserFullName,@AmountFined) "
                cmd.Parameters.AddWithValue("@TransactionID", TextBox14.Text)
                cmd.Parameters.AddWithValue("@BookID", TextBox16.Text)
                cmd.Parameters.AddWithValue("@BookName", TextBox20.Text)
                cmd.Parameters.AddWithValue("@BookAvailability", CheckBox2.CheckState)
                cmd.Parameters.AddWithValue("@YearPublished", DateTimePicker4.Text) 'did not include this one
                cmd.Parameters.AddWithValue("@BookPublisher", TextBox18.Text)
                cmd.Parameters.AddWithValue("@BookAuthor", TextBox15.Text)
                cmd.Parameters.AddWithValue("@BookISBN", TextBox17.Text)
                cmd.Parameters.AddWithValue("@BookEdition", ComboBox2.Text)
                cmd.Parameters.AddWithValue("@NoOfPages", NumericUpDown2.Value)
                cmd.Parameters.AddWithValue("@BookPicture", TextBox19.Text)
                cmd.Parameters.AddWithValue("@MemberID", TextBox8.Text)
                cmd.Parameters.AddWithValue("@MemberFullName", TextBox9.Text)
                cmd.Parameters.AddWithValue("@MemberMobileNo", TextBox13.Text)
                cmd.Parameters.AddWithValue("@MemberEmailAddress", TextBox11.Text)
                cmd.Parameters.AddWithValue("@MemberPhysicalAddress", TextBox12.Text)
                cmd.Parameters.AddWithValue("@MemberPicture", TextBox10.Text)
                cmd.Parameters.AddWithValue("@DateIssuedOut", DateTimePicker3.Text)
                cmd.Parameters.AddWithValue("@ExpectedReturnDate", DateTimePicker2.Text) 'did not include this one
                cmd.Parameters.AddWithValue("@DateReturned", DateReturnedPicker.Text) 'did not include this one
                cmd.Parameters.AddWithValue("@LateReturnDays", LateReturnDaysTextBox.Text)
                cmd.Parameters.AddWithValue("@BookCondition", ComboBox1.Text)
                cmd.Parameters.AddWithValue("@UserFullName", TextBox7.Text)
                cmd.Parameters.AddWithValue("@AmountFined", AmountFinedTextBox.Text)

                cmd.Connection = cn
                cmd.ExecuteNonQuery()
                MsgBox("Book Return Transaction Successful..", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Transaction Successful")
            Catch ex As Exception
                MsgBox("Transaction Failed. Please try again.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Transaction Failed")
            End Try
        End If
    End Sub

    Private Sub SupplierIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles SupplierIDTextBox.TextChanged
        If SupplierIDTextBox.Text = SupplierIDTextBox.Text Then
            Timer4.Start()
        End If

    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Dim ctr, i As Integer
        Dim bkkidd As String = ""
        Dim bktype As String = ""

        ds.Clear()

        str = "select * from SupplierTb"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "SupplierTb")
        ctr = ds.Tables("SupplierTb").Rows.Count - 1

        For i = 0 To ctr
            If SupplierIDTextBox.Text = ds.Tables("SupplierTb").Rows(i)(0).ToString Then
                bktype = ds.Tables("SupplierTb").Rows(i)(2).ToString
            End If
        Next
        BookTypeComboBox.Text = bktype
        Timer4.Stop()
    End Sub
End Class