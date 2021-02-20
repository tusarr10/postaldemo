Imports System.Data.OleDb
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports DevExpress.XtraReports.UI
Public Class transdetails
 Dim sbt As Double

    Dim cs As String = mainfrm.css
    Private Sub transdetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getdata()
        getdatatest()
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd MMMM yyyy"
        DateTimePicker1.Value = DateAndTime.Now

    End Sub

    Sub getdata()
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT d_ate as [D_ate], AccountType,accountNumber, AccountHolderName, deposit, withdrow, balance, DLT, remark from transdetail order by AccountType", con)

            Dim myDA1 As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet1 As DataSet = New DataSet()
            myDA1.Fill(myDataSet1, "transdetail")
            GridControl1.DataSource = myDataSet1.Tables("transdetail").DefaultView

            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub getdatatest()
    

    End Sub

    Sub filt()
        Try
            con = New OleDbConnection(cs)
            con.Open()

            cmd = New OleDbCommand("SELECT d_ate as [D_ate], AccountType,accountNumber, AccountHolderName, deposit, withdrow, balance, DLT, remark from transdetail where d_ate like '%" & DateTimePicker1.Text & "%' order by AccountType", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "transdetail")

            GridControl1.DataSource = myDataSet.Tables("transdetail").DefaultView

            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        waitopen()
        filt() : waitclose()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        waitopen()
        Try
            con = New OleDbConnection(cs)
            con.Open()

            cmd = New OleDbCommand("SELECT d_ate as [D_ate], AccountType,accountNumber, AccountHolderName, deposit, withdrow, balance, DLT, remark from transdetail where d_ate like '%" & DateTimePicker1.Text & "%' order by AccountType", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "transdetail")

            GridControl1.DataSource = myDataSet.Tables("transdetail").DefaultView
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        waitclose()
    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub
End Class