Imports System.Data.OleDb
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Public Class accountSettingList
    Dim cs As String = mainfrm.css
    Private Sub accountSettingList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub filt2()
        Try
            con = New OleDbConnection(cs)
            con.Open()

            cmd = New OleDbCommand("SELECT D_ate as [Date], Balance as [Opening Balance] ,AvlBal as [Available Balance], Person1 as [Info 1], Person2 as [Person2], Person3 as [Person3], Person4 as [Person4],Balance2 as [Balance2] from CashSetting where D_ate like '" & Account_Setting.DateTimePicker1.Text & "%' order by D_ate", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "dacdb")
            DataGridView1.DataSource = myDataSet.Tables("dacdb").DefaultView
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub filt3(ByVal x As String, ByVal y As String)
        '  Try
        con = New OleDbConnection(cs)
        con.Open()

        '  cmd = New OleDbCommand("SELECT D_ate as [Date],2000 as [2000] ,'1000' as [1000], '500' as [500], '200' as [200], '100' as [100], '50' as [50],'20' as [20],'10' as [10],t_ime as [Status] from CashInfo where D_ate like '%" & x & "%' and t_ime like '%" & y & "%' order by D_ate", con)
        cmd = New OleDbCommand("SELECT * from CashInfo where D_ate like '%" & x & "%' and t_ime like '%" & y & "%' order by D_ate", con)
        ' cmd = New OleDbCommand("SELECT D_ate,'2000','1000','500','200','100','50','20','10',t_ime as [Status] from CashInfo where D_ate like '" & x & "%' order by D_ate", con)
        Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
        Dim myDataSet As DataSet = New DataSet()
        myDA.Fill(myDataSet, "CashInfo")
        DataGridView1.DataSource = myDataSet.Tables("CashInfo").DefaultView
        con.Close()
        '   Catch ex As Exception
        '  MsgBox(ex.Message)
        'End Try
    End Sub





End Class