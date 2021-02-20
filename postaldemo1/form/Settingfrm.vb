Imports System.Data.OleDb
'Imports MySql.Data.MySqlClient

Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Public Class Settingfrm
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim gender As String
    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        waitopen() ' Wait form 
        dbstring = TextBox1.Text
        dbpas = TextBox2.Text
        mainfrm.css = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & TextBox1.Text & ";Jet OLEDB:Database Password=" & TextBox2.Text & ";"
        '  mainfrm.css = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath + "\" & TextBox1.Text & ";Jet OLEDB:Database Password=" & TextBox2.Text & ";"

        Dim cs As String = mainfrm.css
        con = New OleDbConnection(cs)

        Try
            con.Open()
            MsgBox("Connection success")
            Try
                My.Settings.usertype = "Admin"
            Catch exx As Exception
                MsgBox(exx.Message)
            End Try

            mainfrm.Show()
            Me.Hide()
            con.Close()
            waitclose()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
            waitclose()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        waitopen()

        mainfrm.css = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath + "\" & TextBox1.Text & ";Jet OLEDB:Database Password=" & TextBox2.Text & ";"
        mainfrm.Show()
        mainfrm.css = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath + "\" & TextBox1.Text & ";Jet OLEDB:Database Password=" & TextBox2.Text & ";"
        Me.Hide()
        waitclose()

    End Sub

    Private Sub Settingfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        waitopen() ' Wait form 
        dbstring = TextBox1.Text
        dbpas = TextBox2.Text
        mainfrm.css = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & TextBox1.Text & ";Jet OLEDB:Database Password=" & TextBox2.Text & ";"
        '  mainfrm.css = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath + "\" & TextBox1.Text & ";Jet OLEDB:Database Password=" & TextBox2.Text & ";"

        Dim cs As String = mainfrm.css
        con = New OleDbConnection(cs)

        Try
            con.Open()
            MsgBox("Connection success")
            Try
                My.Settings.usertype = "Admin"
            Catch exx As Exception
                MsgBox(exx.Message)
            End Try

            mainfrm.Show()
            Me.Hide()
            con.Close()
            waitclose()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
            waitclose()
        End Try
    End Sub
End Class