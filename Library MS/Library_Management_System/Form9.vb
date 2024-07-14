Imports System.IO
Imports iTextSharp
Imports System.Reflection
Imports iTextSharp.text.pdf
Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Imports iTextSharp.text

Public Class Form9

    Function PrintReceipt()
        Dim aPath As String
        Dim aName As String

        aName = Assembly.GetExecutingAssembly.GetModules()(0).FullyQualifiedName
        Randomize()
        Dim RandGen As New Random
        aPath = System.IO.Path.GetDirectoryName(aName).Replace("\bin\Debug", "\Receipts\" + Form1.txtusername.Text + RandGen.Next(1000, 10000).ToString + ".pdf")

        Dim pgsize As New iTextSharp.text.Rectangle(200, 570)
        Dim doc As New iTextSharp.text.Document(pgsize, 10, 10, 35, 35)
        Dim path As String = System.IO.Path.Combine(Application.StartupPath, "\Receipts\" + Form1.txtusername.Text + RandGen.Next(1000, 10000).ToString + ".pdf")
        Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(aPath, FileMode.Create))
        Dim pAddress As New Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 14, iTextSharp.text.Font.BOLD, BaseColor.BLACK)
        Dim pBody As New Font(iTextSharp.text.Font.FontFamily.UNDEFINED, 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)
        doc.Open()

        'Dim imageurl As String = "E:\Takudzwa A.Svosve\School Stuff\Study Materials\Advanced Level\Computer Science\Visual Basic\Visual Basic Tutorials\Icons\Begginning Ethical Hacking With Python.jpg"
        'Dim imagebmp As iTextSharp.text.Image
        'imagebmp = iTextSharp.text.Image.GetInstance(imageurl)
        'imagebmp.ScaleToFit(100.0F, 100.0F)
        'imagebmp.SpacingBefore = 200.0F
        'imagebmp.SpacingAfter = 10.0F
        'imagebmp.SetAbsolutePosition(10, 290)

        Dim paragraph1 As New Paragraph
        Dim paragraph2 As New Paragraph
        Dim paragraph3 As New Paragraph
        Dim paragraph4 As New Paragraph
        Dim paragraph5 As New Paragraph
        Dim paragraph6 As New Paragraph
        Dim paragraph7 As New Paragraph '("Date Issued Out : " + DateTimePicker3.Text)
        Dim paragraph12 As New Paragraph 'iTextSharp.text.Paragraph("Return Date        : " + DateTimePicker2.Text)
        Dim paragraph13 As New Paragraph 'iTextSharp.text.Paragraph("Date Returned    : " + DateReturnedPicker.Text)
        Dim paragraph14 As New iTextSharp.text.Paragraph("Amount Paid  : " + FormatCurrency(TextBox19.Text, 2))
        Dim paragraph15 As New iTextSharp.text.Paragraph("Amount Fined : " + FormatCurrency(AmountFinedTextBox.Text, 2))
        Dim paragraph16 As New iTextSharp.text.Paragraph("Change         : " + FormatCurrency(TextBox18.Text, 2))
        Dim paragraph17 As New Paragraph 'iTextSharp.text.Paragraph("Served By " + TextBox17.Text)
        Dim paragraph18 As New Paragraph
        Dim paragraph19 As New Paragraph
        Dim paragraph20 As New iTextSharp.text.Paragraph("-------------------------------------------")
        Dim paragraph21 As New iTextSharp.text.Paragraph("__________________________")

        paragraph1 = New Paragraph(New Chunk("KweKwe Library", pAddress))
        paragraph1.Alignment = Element.ALIGN_CENTER
        paragraph1.SpacingAfter = 0.0F

        paragraph2 = New Paragraph(New Chunk("1009/3 Mbizo", pAddress))
        paragraph2.Alignment = Element.ALIGN_CENTER
        paragraph2.SpacingAfter = 0.0F

        paragraph3 = New Paragraph(New Chunk("KweKwe", pAddress))
        paragraph3.Alignment = Element.ALIGN_CENTER
        paragraph3.SpacingAfter = 0.0F

        paragraph4 = New Paragraph(New Chunk("Transaction ID." + TextBox14.Text, pBody))
        paragraph4.Alignment = Element.ALIGN_JUSTIFIED
        paragraph4.SpacingAfter = 0.0F

        paragraph5 = New Paragraph(New Chunk("Book ID. " + TextBox8.Text, pBody))
        paragraph5.Alignment = Element.ALIGN_JUSTIFIED
        paragraph5.SpacingAfter = 0.0F

        paragraph6 = New Paragraph(New Chunk("Member ID. " + TextBox8.Text, pBody))
        paragraph6.Alignment = Element.ALIGN_JUSTIFIED
        paragraph6.SpacingAfter = 0.0F

        paragraph7 = New Paragraph(New Chunk("Date Issued Out : " + DateTimePicker3.Text, pBody))
        paragraph7.Alignment = Element.ALIGN_JUSTIFIED
        paragraph7.SpacingAfter = 0.0F

        paragraph12 = New Paragraph(New Chunk("Return Date : " + DateTimePicker2.Text, pBody))
        paragraph12.Alignment = Element.ALIGN_JUSTIFIED
        paragraph12.SpacingAfter = 0.0F

        paragraph13 = New Paragraph(New Chunk("Date Returned : " + DateReturnedPicker.Text, pBody))
        paragraph13.Alignment = Element.ALIGN_JUSTIFIED
        paragraph13.SpacingAfter = 0.0F

        paragraph17 = New Paragraph(New Chunk("Served By " + TextBox17.Text, pBody))
        paragraph17.Alignment = Element.ALIGN_CENTER
        paragraph17.SpacingAfter = 0.0F

        paragraph18 = New Paragraph(New Chunk(Format(Now, "dd-MMM-yyyy") + "       " + Format(Now, "HH:mm tt")))
        paragraph18.Alignment = Element.ALIGN_CENTER
        paragraph18.SpacingAfter = 5.0F

        paragraph19 = New Paragraph(New Chunk("END OF FISCAL RECEIPT"))
        paragraph19.Alignment = Element.ALIGN_CENTER
        paragraph19.SpacingAfter = 5.0F

        'doc.Add(imagebmp)
        doc.Add(paragraph1)
        doc.Add(paragraph2)
        doc.Add(paragraph3)
        doc.Add(paragraph20)
        doc.Add(paragraph4)
        doc.Add(paragraph5)
        doc.Add(paragraph6)
        doc.Add(paragraph20)
        doc.Add(paragraph7)
        doc.Add(paragraph12)
        doc.Add(paragraph13)
        doc.Add(paragraph20)
        doc.Add(paragraph14)
        doc.Add(paragraph15)
        doc.Add(paragraph16)
        doc.Add(paragraph20)
        doc.Add(paragraph18)
        doc.Add(paragraph17)
        doc.Add(paragraph20)
        doc.Add(paragraph19)
        doc.Add(paragraph21)

        doc.Close()
        Process.Start(aPath)
        Return True
    End Function

    Private Sub Form9_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form3.bukreturnklear()
        Form3.Enabled = True
        Form3.Button13.Enabled = True
        Form3.lblAmountFined.Text = "Amount Fined"
        Form3.Show()
        frm9clear()
        Timer1.Stop()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = " Pay your pending balances here and get " + vbNewLine + "  your name cleared! It's that simple!"
        Label4.Text = "NOTE : Your balance due is $ " + Format(Val(Form3.AmountFinedTextBox.Text), "0.00")
        Label14.Text = "Served by " + TextBox17.Text

        Label15.Hide()
        Label16.Hide()
        TextBox17.Hide()
        TextBox18.Hide()
        TextBox19.Hide()
        lblAmountFined.Hide()
        AmountFinedTextBox.Hide()

        Me.TextBox8.Text = Form3.TextBox8.Text
        Me.TextBox9.Text = Form3.TextBox9.Text
        Me.TextBox11.Text = Form3.TextBox11.Text
        Me.TextBox14.Text = Form3.TextBox14.Text
        Me.TextBox16.Text = Form3.TextBox16.Text
        Me.TextBox17.Text = Form3.TextBox7.Text
        Me.TextBox20.Text = Form3.TextBox20.Text
        Me.AmountFinedTextBox.Text = Form3.AmountFinedTextBox.Text
        Me.ComboBox1.SelectedItem = Form3.ComboBox1.SelectedItem
        Me.DateReturnedPicker.Value = Form3.DateReturnedPicker.Value
        Me.DateTimePicker2.Value = Form3.DateTimePicker2.Value
        Me.DateTimePicker3.Value = Form3.DateTimePicker3.Value

    End Sub

    Sub RdBtton1()
        Dim change As Single
        change = Val(TextBox3.Text) - Val(AmountFinedTextBox.Text)
        TextBox18.Text = change

        If RadioButton1.Checked = True Then
            RichTextBox1.Text = vbNewLine + vbNewLine + vbNewLine + "Mode of Payment  " + vbNewLine + "Cash" + vbNewLine + "______________________" + vbNewLine + vbNewLine + "Amount Paid: $ " + Format(Val(TextBox3.Text), "0.00") + vbNewLine + "Amount Due : $ " + Format(Val(AmountFinedTextBox.Text), "0.00") + vbNewLine + "______________________" + vbNewLine + vbNewLine + "Change     : $ " + Format(Val(TextBox18.Text), "0.00")
            TextBox19.Text = TextBox3.Text
        Else
            RichTextBox1.Clear()
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            TextBox3.Focus()
            RichTextBox1.Text = vbNewLine + vbNewLine + vbNewLine + "Mode of Payment  " + vbNewLine + "Cash"
        Else
            RichTextBox1.Clear()
            TextBox3.Clear()
            TextBox18.Clear()
            TextBox19.Clear()
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

        If RadioButton1.Checked = True Then
            RichTextBox1.Text = vbNewLine + vbNewLine + vbNewLine + "Mode of Payment  " + vbNewLine + "Cash" + vbNewLine + "______________________" + vbNewLine + vbNewLine + "Amount Paid: $ " + Format(Val(TextBox3.Text), "0.00") + vbNewLine + "Amount Due : $ " + Format(Val(AmountFinedTextBox.Text), "0.00")
        Else
            RichTextBox1.Clear()
        End If

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            TextBox4.Focus()
            RichTextBox1.Text = vbNewLine + "Mode of Payment  " + vbNewLine + "EcoCash"
        Else
            RichTextBox1.Clear()
            TextBox1.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox18.Clear()
            TextBox19.Clear()
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        If RadioButton2.Checked = True Then
            RichTextBox1.Text = vbNewLine + "Mode of Payment  " + vbNewLine + "EcoCash" + vbNewLine + "______________________" + vbNewLine + vbNewLine + "Amount Paid: $ " + Format(Val(TextBox4.Text), "0.00") + vbNewLine + "Amount Due : $ " + Format(Val(AmountFinedTextBox.Text), "0.00")
        Else
            RichTextBox1.Clear()
        End If
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        If RadioButton3.Checked = True Then
            RichTextBox1.Text = vbNewLine + "Mode of Payment  " + vbNewLine + "Visa Card" + vbNewLine + "______________________" + vbNewLine + vbNewLine + "Amount Paid: $ " + Format(Val(TextBox7.Text), "0.00") + vbNewLine + "Amount Due : $ " + Format(Val(AmountFinedTextBox.Text), "0.00")
        Else
            RichTextBox1.Clear()
        End If
    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged
        If RadioButton4.Checked = True Then
            RichTextBox1.Text = vbNewLine + "Mode of Payment  " + vbNewLine + "Debit Card" + vbNewLine + "______________________" + vbNewLine + vbNewLine + "Amount Paid: $ " + Format(Val(TextBox12.Text), "0.00") + vbNewLine + "Amount Due : $ " + Format(Val(AmountFinedTextBox.Text), "0.00")
        Else
            RichTextBox1.Clear()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Val(TextBox3.Text) >= Val(AmountFinedTextBox.Text) Or Val(TextBox4.Text) >= Val(AmountFinedTextBox.Text) Or Val(TextBox7.Text) >= Val(AmountFinedTextBox.Text) Or Val(TextBox12.Text) >= Val(AmountFinedTextBox.Text) Then
            Dim SAPI
            SAPI = CreateObject("SAPI.spvoice")

            If RadioButton1.Checked = True Then
                RdBtton1()
            ElseIf RadioButton2.Checked = True Then
                RdBtton2()
            ElseIf RadioButton3.Checked = True Then
                RdBtton3()
            ElseIf RadioButton4.Checked = True Then
                RdBtton4()
            End If
            'MsgBox("Fine payment cleared. You are good to go!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "FINE CLEARED.")
            SAPI.speak("Processing Payment.")
            Button4.Enabled = True
        Else
            Dim insuff As MsgBoxResult
            insuff = MsgBox("Insufficient funds." + vbNewLine + "Please Topup!", MsgBoxStyle.Critical + MsgBoxStyle.OkCancel, "INSUFFICIENT FUNDS")
            If insuff = MsgBoxResult.Ok Then
                If RadioButton1.Checked = True Then
                    TextBox3.Focus()
                ElseIf RadioButton2.Checked = True Then
                    TextBox4.Focus()
                ElseIf RadioButton3.Checked = True Then
                    TextBox7.Focus()
                ElseIf RadioButton4.Checked = True Then
                    TextBox12.Focus()
                End If
            Else
                MsgBox("System will now return you to the Book Return Interface." + vbNewLine + "Please call again.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Ooooops!")
                Timer1.Stop()
                Me.Close()

            End If
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            TextBox12.Focus()
            RichTextBox1.Text = vbNewLine + "Mode of Payment  " + vbNewLine + "Debit Card"
        Else
            RichTextBox1.Clear()
            TextBox12.Clear()
            TextBox13.Clear()
            TextBox10.Clear()
            TextBox18.Clear()
            TextBox19.Clear()
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        If RadioButton2.Checked = True Then
            RichTextBox1.Text = vbNewLine + "Mode of Payment  " + vbNewLine + "EcoCash" + vbNewLine + "Mobile Number " + vbNewLine + TextBox5.Text + vbNewLine + "______________________" + vbNewLine + vbNewLine + "Amount Paid: $ " + Format(Val(TextBox4.Text), "0.00") + vbNewLine + "Amount Due : $ " + Format(Val(AmountFinedTextBox.Text), "0.00")
        Else
            RichTextBox1.Clear()
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            TextBox7.Focus()
            RichTextBox1.Text = vbNewLine + "Mode of Payment  " + vbNewLine + "Visa Card"
        Else
            RichTextBox1.Clear()
            TextBox7.Clear()
            TextBox6.Clear()
            TextBox2.Clear()
            TextBox18.Clear()
            TextBox19.Clear()
        End If
    End Sub


    Sub RdBtton2()
        Dim change As Single
        change = Val(TextBox4.Text) - Val(AmountFinedTextBox.Text)
        TextBox18.Text = change

        If RadioButton2.Checked = True Then
            RichTextBox1.Text = vbNewLine + "Mode of Payment  " + vbNewLine + "EcoCash" + vbNewLine + "Mobile Number " + vbNewLine + TextBox5.Text + vbNewLine + "Security Key " + vbNewLine + TextBox1.Text + vbNewLine + "______________________" + vbNewLine + vbNewLine + "Amount Paid: $ " + Format(Val(TextBox4.Text), "0.00") + vbNewLine + "Amount Due : $ " + Format(Val(AmountFinedTextBox.Text), "0.00") + vbNewLine + "______________________" + vbNewLine + vbNewLine + "Change     : $ " + Format(Val(TextBox18.Text), "0.00")
            TextBox19.Text = TextBox4.Text
        Else
            RichTextBox1.Clear()
        End If
    End Sub


    Sub RdBtton3()
        Dim change As Single
        change = Val(TextBox7.Text) - Val(AmountFinedTextBox.Text)
        TextBox18.Text = change

        If RadioButton3.Checked = True Then
            RichTextBox1.Text = vbNewLine + "Mode of Payment  " + vbNewLine + "Visa Card" + vbNewLine + "Account Number " + vbNewLine + TextBox6.Text + vbNewLine + "Security Key " + vbNewLine + TextBox2.Text + vbNewLine + "______________________" + vbNewLine + vbNewLine + "Amount Paid: $ " + Format(Val(TextBox7.Text), "0.00") + vbNewLine + "Amount Due : $ " + Format(Val(AmountFinedTextBox.Text), "0.00") + vbNewLine + "______________________" + vbNewLine + vbNewLine + "Change     : $ " + Format(Val(TextBox18.Text), "0.00")
            TextBox19.Text = TextBox7.Text
        Else
            RichTextBox1.Clear()
        End If
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        If RadioButton3.Checked = True Then
            RichTextBox1.Text = vbNewLine + "Mode of Payment  " + vbNewLine + "Visa Card" + vbNewLine + "Account Number " + vbNewLine + TextBox6.Text + vbNewLine + "______________________" + vbNewLine + vbNewLine + "Amount Paid: $ " + Format(Val(TextBox7.Text), "0.00") + vbNewLine + "Amount Due : $ " + Format(Val(AmountFinedTextBox.Text), "0.00")
        Else
            RichTextBox1.Clear()
        End If

    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged
        If RadioButton4.Checked = True Then
            RichTextBox1.Text = vbNewLine + "Mode of Payment  " + vbNewLine + "Debit Card" + vbNewLine + "Account Number " + vbNewLine + TextBox10.Text + vbNewLine + "______________________" + vbNewLine + vbNewLine + "Amount Paid: $ " + Format(Val(TextBox12.Text), "0.00") + vbNewLine + "Amount Due : $ " + Format(Val(AmountFinedTextBox.Text), "0.00")
        Else
            RichTextBox1.Clear()
        End If
    End Sub

    Sub RdBtton4()
        Dim change As Single
        change = Val(TextBox12.Text) - Val(AmountFinedTextBox.Text)
        TextBox18.Text = change

        If RadioButton4.Checked = True Then
            RichTextBox1.Text = vbNewLine + "Mode of Payment  " + vbNewLine + "Debit Card" + vbNewLine + "Account Number " + vbNewLine + TextBox10.Text + vbNewLine + "Security Key " + vbNewLine + TextBox13.Text + vbNewLine + "_____________________" + vbNewLine + vbNewLine + "Amount Paid: $ " + Format(Val(TextBox12.Text), "0.00") + vbNewLine + "Amount Due : $ " + Format(Val(AmountFinedTextBox.Text), "0.00") + vbNewLine + "_____________________" + vbNewLine + vbNewLine + "Change     : $ " + Format(Val(TextBox18.Text), "0.00")
            TextBox19.Text = TextBox12.Text
        Else
            RichTextBox1.Clear()
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If RadioButton2.Checked = True Then
            RichTextBox1.Text = vbNewLine + "Mode of Payment  " + vbNewLine + "EcoCash" + vbNewLine + "Mobile Number " + vbNewLine + TextBox5.Text + vbNewLine + "Security Key " + vbNewLine + TextBox1.Text + vbNewLine + "______________________" + vbNewLine + vbNewLine + "Amount Paid: $ " + Format(Val(TextBox4.Text), "0.00") + vbNewLine + "Amount Due : $ " + Format(Val(AmountFinedTextBox.Text), "0.00")
        Else
            RichTextBox1.Clear()
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If RadioButton3.Checked = True Then
            RichTextBox1.Text = vbNewLine + "Mode of Payment  " + vbNewLine + "Visa Card" + vbNewLine + "Account Number " + vbNewLine + TextBox6.Text + vbNewLine + "Security Key " + vbNewLine + TextBox2.Text + vbNewLine + "______________________" + vbNewLine + vbNewLine + "Amount Paid: $ " + Format(Val(TextBox7.Text), "0.00") + vbNewLine + "Amount Due : $ " + Format(Val(AmountFinedTextBox.Text), "0.00")
        Else
            RichTextBox1.Clear()
        End If
    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged
        If RadioButton4.Checked = True Then
            RichTextBox1.Text = vbNewLine + "Mode of Payment  " + vbNewLine + "Debit Card" + vbNewLine + "Account Number " + vbNewLine + TextBox10.Text + vbNewLine + "Security Key " + vbNewLine + TextBox13.Text + vbNewLine + "______________________" + vbNewLine + vbNewLine + "Amount Paid: $ " + Format(Val(TextBox12.Text), "0.00") + vbNewLine + "Amount Due : $ " + Format(Val(AmountFinedTextBox.Text), "0.00")
        Else
            RichTextBox1.Clear()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frm9clear()
        Frm9Load()
    End Sub

    Sub frm9clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox10.Clear()
        TextBox12.Clear()
        TextBox13.Clear()
        TextBox18.Clear()
        TextBox19.Clear()
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RichTextBox1.Clear()
        Button4.Enabled = False
        Button2.Enabled = False
    End Sub

    Private Sub TextBox11_Validated(sender As Object, e As EventArgs) Handles TextBox11.Validated
        Dim p As String

        p = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z]*@[0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"
        If Regex.IsMatch(TextBox11.Text, p) Then

        Else
            MsgBox("You entered an invalid format of an email address. Please try again!", MsgBoxStyle.Exclamation, "INVALID EMAIL ADDRESS")
        End If
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox10.KeyPress
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

    Private Sub TextBox20_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox20.KeyPress
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

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Frm9Load()
    End Sub

    Sub Frm9Load()

        ds.Clear()

        frm9clear()

        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If

        Module1.conn()
        cn.Open()
        str = "select * from FinePaymentTb"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "FinePaymentTb")

        'for registration no
        Dim LastNo As Integer
        LastNo = ds.Tables("FinePaymentTb").Rows.Count + 1
        If LastNo >= 0 Then
            TextBox15.Text = "Fno00" & LastNo
        Else
            TextBox15.Text = "Fn00" & 0
        End If

        str = "select * from BookReturnTb"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "BookReturnTb")
        TextBox14.Focus()
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        'Declaring Local variables
        Dim finetrn As Integer = 0
        Dim booktrn As Integer = 0
        Dim ctr, i As Integer
        Dim TrnsID As String = ""
        Dim BkID As String = ""
        Dim MbrID As String = ""
        Dim dteissout As String = ""
        Dim duedate As String = ""

        'Initialising Global Variables
        ds.Clear()

        str = "select * from FinePaymentTb"
        cmd = New OleDbCommand(str, cn)
        da.SelectCommand = cmd
        da.Fill(ds, "FinePaymentTb")
        ctr = ds.Tables("FinePaymentTb").Rows.Count - 1

        Dim LastNo As Integer
        LastNo = ds.Tables("FinePaymentTb").Rows.Count + 1
        If LastNo >= 0 Then
            TextBox15.Text = "Fno00" & LastNo
        Else
            TextBox15.Text = "Fno00" & 0
        End If

        'Initialising Local Variables
        For i = 0 To ctr
            If TextBox14.Text = ds.Tables("FinePaymentTb").Rows(i)(1).ToString Or TextBox16.Text = ds.Tables("FinePaymentTb").Rows(i)(2).ToString Or TextBox8.Text = ds.Tables("FinePaymentTb").Rows(i)(5).ToString Then
                TrnsID = ds.Tables("FinePaymentTb").Rows(i)(1).ToString
                BkID = ds.Tables("FinePaymentTb").Rows(i)(2).ToString
                MbrID = ds.Tables("FinePaymentTb").Rows(i)(5).ToString
                dteissout = ds.Tables("FinePaymentTb").Rows(i)(8).ToString
                duedate = ds.Tables("FinePaymentTb").Rows(i)(9).ToString
            End If
        Next

        If TrnsID.Contains(TextBox14.Text) And BkID.Contains(TextBox16.Text) And MbrID.Contains(TextBox8.Text) And dteissout.Contains(DateTimePicker3.Text) And duedate.Contains(DateTimePicker2.Text) Then
            MsgBox("Fine already cleared.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Fine Already Cleared")

        Else

            Try
                Try
                    cmd = New OleDbCommand
                    cmd.CommandText = " insert into FinePaymentTb values (@FineNo,@TransactionID,@BookID,@BookName,@BookCondition,@MemberID,@MemberFullName,@MemberEmailAddress,@DateIssuedOut,@ExpectedReturnDate,@DateReturned,@AmountFined,@AmountPaid,@Change,@UserFullName) "
                    cmd.Parameters.AddWithValue("@FineNo", TextBox15.Text)
                    cmd.Parameters.AddWithValue("@TransactionID", TextBox14.Text)
                    cmd.Parameters.AddWithValue("@BookID", TextBox16.Text)
                    cmd.Parameters.AddWithValue("@BookName", TextBox20.Text)
                    cmd.Parameters.AddWithValue("@BookCondition", ComboBox1.Text)
                    cmd.Parameters.AddWithValue("@MemberID", TextBox8.Text)
                    cmd.Parameters.AddWithValue("@MemberFullName", TextBox9.Text)
                    cmd.Parameters.AddWithValue("@MemberEmailAddress", TextBox11.Text)
                    cmd.Parameters.AddWithValue("@DateIssuedOut", DateTimePicker3.Text)
                    cmd.Parameters.AddWithValue("@ExpectedReturnDate", DateTimePicker2.Text)
                    cmd.Parameters.AddWithValue("@DateReturned", DateReturnedPicker.Text)
                    cmd.Parameters.AddWithValue("@AmountFined", AmountFinedTextBox.Text)
                    cmd.Parameters.AddWithValue("@AmountPaid", TextBox19.Text)
                    cmd.Parameters.AddWithValue("@Change", TextBox18.Text)
                    cmd.Parameters.AddWithValue("@UserFullName", TextBox17.Text)

                    cmd.Connection = cn
                    cmd.ExecuteNonQuery()
                    finetrn = 1
                Catch ex As Exception
                    finetrn = 0
                End Try

                Try
                    cmd = New OleDbCommand
                    cmd.CommandText = " insert into BookReturnTb values (@TransactionID,@BookID,@BookName,@BookAvailability,@YearPublished,@BookPublisher,@BookAuthor,@BookISBN,@BookEdition,@NoOfPages,@BookPicture,@MemberID,@MemberFullName,@MemberMobileNo,@MemberEmailAddress,@MemberPhysicalAddress,@MemberPicture,@DateIssuedOut,@ExpectedReturnDate,@DateReturned,@LateReturnDays,@BookCondition,@UserFullName,@AmountFined) "
                    cmd.Parameters.AddWithValue("@TransactionID", Form3.TextBox14.Text)
                    cmd.Parameters.AddWithValue("@BookID", Form3.TextBox16.Text)
                    cmd.Parameters.AddWithValue("@BookName", Form3.TextBox20.Text)
                    cmd.Parameters.AddWithValue("@BookAvailability", Form3.CheckBox2.CheckState)
                    cmd.Parameters.AddWithValue("@YearPublished", Form3.DateTimePicker4.Text)
                    cmd.Parameters.AddWithValue("@BookPublisher", Form3.TextBox18.Text)
                    cmd.Parameters.AddWithValue("@BookAuthor", Form3.TextBox15.Text)
                    cmd.Parameters.AddWithValue("@BookISBN", Form3.TextBox17.Text)
                    cmd.Parameters.AddWithValue("@BookEdition", Form3.ComboBox2.Text)
                    cmd.Parameters.AddWithValue("@NoOfPages", Form3.NumericUpDown2.Value)
                    cmd.Parameters.AddWithValue("@BookPicture", Form3.TextBox19.Text)
                    cmd.Parameters.AddWithValue("@MemberID", Form3.TextBox8.Text)
                    cmd.Parameters.AddWithValue("@MemberFullName", Form3.TextBox9.Text)
                    cmd.Parameters.AddWithValue("@MemberMobileNo", Form3.TextBox13.Text)
                    cmd.Parameters.AddWithValue("@MemberEmailAddress", Form3.TextBox11.Text)
                    cmd.Parameters.AddWithValue("@MemberPhysicalAddress", Form3.TextBox12.Text)
                    cmd.Parameters.AddWithValue("@MemberPicture", Form3.TextBox10.Text)
                    cmd.Parameters.AddWithValue("@DateIssuedOut", Form3.DateTimePicker3.Text)
                    cmd.Parameters.AddWithValue("@ExpectedReturnDate", Form3.DateTimePicker2.Text)
                    cmd.Parameters.AddWithValue("@DateReturned", Form3.DateReturnedPicker.Text)
                    cmd.Parameters.AddWithValue("@LateReturnDays", Form3.LateReturnDaysTextBox.Text)
                    cmd.Parameters.AddWithValue("@BookCondition", Form3.ComboBox1.Text)
                    cmd.Parameters.AddWithValue("@UserFullName", Form3.TextBox7.Text)
                    cmd.Parameters.AddWithValue("@AmountFined", Form3.AmountFinedTextBox.Text)

                    cmd.Connection = cn
                    cmd.ExecuteNonQuery()
                    booktrn = 1
                Catch ex As Exception
                    booktrn = 0
                End Try

                Button4.Enabled = False

            Catch ex As Exception

            End Try

            If booktrn = 1 And finetrn = 1 Then
                Button2.Enabled = True
                MsgBox("Book Return and Fine Payment Transactions Successful", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Transactions Successful")
            ElseIf booktrn = 0 Then
                MsgBox("Book Return Transaction Failed. Please try again.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Transaction Failed")
            ElseIf finetrn = 0 Then
                MsgBox("Fine Payment Transaction Failed. Please try again.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Transaction Failed")
            Else
                MsgBox("Transactions Failed. Please try again.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Transaction Failed")
            End If
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            PrintReceipt()
        Catch ex As Exception
            MsgBox("System not connected to a printer!")
        End Try
    End Sub

End Class