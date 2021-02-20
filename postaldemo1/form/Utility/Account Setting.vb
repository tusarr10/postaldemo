Imports System.Data.OleDb
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports Dapper

Public Class Account_Setting
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = mainfrm.css
    Dim htext As String

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        MsgBox("Make sure Balance = Closing Balance ")
        mainfrm.HyperlinkLabelControl1.Text = TextEdit1.Text
        mainfrm.LabelControl2.Text = DateTimePicker1.Text
        Me.Close()
        '*************help***************************
        htext = "May I Help You !!!..."
        mainfrm.lblhelp.Text = "Help : " + htext
        '******************END************************
    End Sub

    Private Sub Account_Setting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd MMMM yyyy"
        '  DateTimePicker1.Text = DateAndTime.Today
        DateTimePicker1.Text = mainfrm.LabelControl2.Text
        btncf()
        '*************help***************************
        htext = "Here You Can Day Begin !!!...Get Data From Last Working Day !!.. Click GET button to get Data ..."
        mainfrm.lblhelp.Text = "Help : " + htext
        '******************END************************
    End Sub
    Sub btncf()
        SimpleButton1.Enabled = False
        SimpleButton2.Enabled = False
        SimpleButton4.Enabled = True

    End Sub
    Sub btnon()
        SimpleButton1.Enabled = True
        SimpleButton2.Enabled = True
        ' SimpleButton4.Enabled = True
    End Sub
    Sub connect_Add()
        Try
            con = New OleDbConnection(cs)
            con.Open()
            Dim cb1 As String = "insert into CashSetting(D_ate,Balance,AvlBal,Balance2,Person1,Person2,Person3,Person4) VALUES('" & DateTimePicker1.Text & "','" & TextEdit10.Text & "','" & TextEdit1.Text & "','" & TextEdit9.Text & "','" & TextEdit3.Text & "','" & TextEdit5.Text & "','" & TextEdit7.Text & "','" & TextEdit8.Text & "')"
            cmd = New OleDbCommand(cb1)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox("Opps Error" + ex.Message)
        End Try
       
    End Sub
    Sub cal()
        Try
            Dim ob, p1, p2, p3, p4, cb As Double
            ob = TextEdit1.Text
            p1 = TextEdit3.Text
            p2 = TextEdit5.Text
            p3 = TextEdit7.Text
            p4 = TextEdit8.Text
            cb = ob + p1 - p2 - p3 - p4
            TextEdit9.Text = cb.ToString
        Catch ex As Exception
            MsgBox("Opps Error" + ex.Message)
        End Try
       

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        waitopen()
        connect_Add()
        MsgBox("Saved !!.. ")
        waitclose()
        '*************help***************************
        htext = "Press Go Button To Go forrword ..!!"
        mainfrm.lblhelp.Text = "Help : " + htext
        '******************END************************

    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        accountSettingList.MdiParent = mainfrm
        accountSettingList.WindowState = FormWindowState.Normal
        accountSettingList.filt2()
        mainfrm.LabelControl2.Text = DateTimePicker1.Text
        Try
            Dim dr As DataGridViewRow = accountSettingList.DataGridView1.Rows(0)
            ' DateTimePicker1.Text = dr.Cells(0).Value.ToString()
            TextEdit10.Text = dr.Cells(1).Value.ToString() ': TextBox28.Text = dr.Cells(2).Value.ToString() : TextBox3.Text = dr.Cells(3).Value.ToString() : TextBox4.Text = dr.Cells(4).Value.ToString()
            TextEdit1.Text = dr.Cells(2).Value.ToString() ': TextBox6.Text = dr.Cells(6).Value.ToString() : TextBox7.Text = dr.Cells(7).Value.ToString() : TextBox8.Text = dr.Cells(8).Value.ToString()
            TextEdit3.Text = dr.Cells(3).Value.ToString() ': TextBox10.Text = dr.Cells(10).Value.ToString() : TextBox11.Text = dr.Cells(11).Value.ToString() : TextBox12.Text = dr.Cells(12).Value.ToString()
            TextEdit5.Text = dr.Cells(4).Value.ToString() ': TextBox14.Text = dr.Cells(14).Value.ToString() : TextBox1.Text = dr.Cells(15).Value.ToString() : TextBox15.Text = dr.Cells(16).Value.ToString()
            TextEdit7.Text = dr.Cells(5).Value.ToString() ': TextBox17.Text = dr.Cells(18).Value.ToString() : TextBox18.Text = dr.Cells(19).Value.ToString() : TextBox19.Text = dr.Cells(20).Value.ToString()
            TextEdit8.Text = dr.Cells(6).Value.ToString() ' : TextBox21.Text = dr.Cells(22).Value.ToString() : TextBox23.Text = dr.Cells(24).Value.ToString() : TextBox27.Text = dr.Cells(25).Value.ToString()
            TextEdit9.Text = dr.Cells(7).Value.ToString() ': TextBox25.Text = dr.Cells(27).Value.ToString() : TextBox24.Text = dr.Cells(28).Value.ToString()
            '************************************************************************************************
        Catch ex As Exception
            MsgBox("ERROR : No Data Found " & ex.Message)


        End Try
        '*************help***************************
        htext = "You Sync Data from Database .. Now Input Data .. Then Click On Calculate To GoForrword !!...."
        mainfrm.lblhelp.Text = "Help : " + htext
        '******************END************************

    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        MsgBox("Check Date")
        TextEdit10.Text = TextEdit9.Text : TextEdit1.Text = TextEdit9.Text
        TextEdit3.Text = 0
        TextEdit5.Text = 0
        TextEdit7.Text = 0
        TextEdit8.Text = 0
        '*************help***************************
        htext = "Now Add New Date ... Click on ADD button ...Change Date First !!.."
        mainfrm.lblhelp.Text = "Help : " + htext
        '******************END************************
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Try
            Update_rec()
            MsgBox("Updated !!.. ")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        '*************help***************************
        htext = "Press GO Button To go FOrrword ..!!"
        mainfrm.lblhelp.Text = "Help : " + htext
        '******************END************************
    End Sub
    Sub Update_rec()
        Try
            con = New OleDbConnection(cs)
            con.Open()
            Dim cb1 As String = "update CashSetting set Balance='" & TextEdit10.Text & "', AvlBal='" & TextEdit9.Text & "',Balance2='" & TextEdit9.Text & "',Person1='" & TextEdit3.Text & "',Person2='" & TextEdit5.Text & "',Person3='" & TextEdit7.Text & "',Person4='" & TextEdit8.Text & "' where D_ate= '" & DateTimePicker1.Text & "'"
            cmd = New OleDbCommand(cb1)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox("Error" & ex.Message)
        End Try
    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click
        cal()
        btnon()
        '*************help***************************
        htext = "If you Change Date Then Click Change Button .. If You Begin new date then Press Add Button ...If you Update Data Of current date then Click Update ... "
        mainfrm.lblhelp.Text = "Help : " + htext
        '******************END************************
    End Sub

    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click
        waitopen()
        CashInfo.MdiParent = mainfrm
        CashInfo.WindowState = FormWindowState.Normal
        CashInfo.Show() : waitclose()
    End Sub
End Class