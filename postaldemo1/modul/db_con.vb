
option Explicit On
Option Strict On
Imports System.Data
Imports System.Data.OleDb
Imports System.Globalization

Module db_con
    Public dbstring As String
    Public dbpas As String
    Public comd As String
    '******************************************START****************************************
    Public rdr As OleDbDataReader = Nothing
    Public dtable As DataTable
    Public con As OleDbConnection = Nothing
    Public adp As OleDbDataAdapter
    Public ds As DataSet
    Public cmd As OleDbCommand = Nothing
    Public dt As New DataTable
    Public gender As String
    'Public css As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath + "\Database1.accdb" '"\db_post.accdb"
    'Public cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath + "\Database1.accdb;Jet OLEDB:Database Password=prahallad89;"
    'Public cs As String

    '******************************************************END*****************************************************

    ' Public cmd As OleDb.OleDbCommand
    Public datst As DataSet
    Public adapter As OleDbDataAdapter
    Public bindingsrc As BindingSource
    Public reader As OleDbDataReader
    Public sql As String

    ' Public dt As DateTime = DateTime.Now
    Public dtinfo As DateTimeFormatInfo = DateTimeFormatInfo.InvariantInfo

    Public myDay As String = "dd"
    Public myMnth As String = "MMM"
    Public myYear As String = "YYY"
    Public dtID As String
    Public accType As Integer
    Public IsFind As Boolean = False

End Module
