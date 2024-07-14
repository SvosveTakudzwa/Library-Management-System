Imports System.Data.OleDb
Imports System.Data

Module Module1

    Public cn As New OleDb.OleDbConnection
    Public cmd As OleDb.OleDbCommand
    Public da As New OleDbDataAdapter
    Public ds As New DataSet
    Public ds1 As New DataSet
    Public ds2 As New DataSet
    Public str As String

    Public Sub conn()

        cn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\LibraryDb.mdb"

    End Sub


End Module
