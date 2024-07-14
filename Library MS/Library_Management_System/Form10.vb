Imports System.Text.RegularExpressions
Public Class Form10

    Private Sub Form10_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Form2.Enabled = True
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Form11.Show()
        Me.Hide()
    End Sub
End Class