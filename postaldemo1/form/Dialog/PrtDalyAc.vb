Imports System.Data.OleDb
Imports System.IO
Imports DevExpress.XtraReports.UI
Imports System.Security.Cryptography
Imports System.Text
Imports Dapper
Public Class PrtDalyAc
    Dim con As New OleDbConnection
    Private Sub PrtDalyAc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd MMMM yyyy"

    End Sub
    ' Public dtt As String = DateTimePicker1.Text
    Dim ccs As String = mainfrm.css
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        waitopen()
        dac.DateTimePicker1.Text = DateTimePicker1.Text
        findd()
        Try
            con = New OleDbConnection(ccs)
            Dim comand As String = "SELECT d_ate, AccountType ,accountNumber, AccountHolderName , deposit , withdrow , balance , DLT , remark  from transdetail where d_ate like '%" & DateTimePicker1.Text & "%' order by AccountType"
            Dim list As List(Of CLS_transDetail) = con.Query(Of CLS_transDetail)(comand).ToList
            Using frm As printfrm = New printfrm()
                frm.FmPrit(list)
                frm.ShowDialog()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        waitclose()
    End Sub
    Sub findd()
        daclist.MdiParent = mainfrm
        daclist.WindowState = FormWindowState.Normal
        dac.DateTimePicker1.Text = DateTimePicker1.Text
        daclist.filt223(DateTimePicker1.Text.ToString)
        Try

            Dim dr As DataGridViewRow = daclist.DataGridView1.Rows(0)
            dac.DateTimePicker1.Text = dr.Cells(0).Value.ToString()
            dac.TextBox2.Text = dr.Cells(1).Value.ToString() : dac.TextBox28.Text = dr.Cells(2).Value.ToString() : dac.TextBox3.Text = dr.Cells(3).Value.ToString() : dac.TextBox4.Text = dr.Cells(4).Value.ToString()
            dac.TextBox5.Text = dr.Cells(5).Value.ToString() : dac.TextBox6.Text = dr.Cells(6).Value.ToString() : dac.TextBox7.Text = dr.Cells(7).Value.ToString() : dac.TextBox8.Text = dr.Cells(8).Value.ToString()
            dac.TextBox9.Text = dr.Cells(9).Value.ToString() : dac.TextBox10.Text = dr.Cells(10).Value.ToString() : dac.TextBox11.Text = dr.Cells(11).Value.ToString() : dac.TextBox12.Text = dr.Cells(12).Value.ToString()
            dac.TextBox13.Text = dr.Cells(13).Value.ToString() : dac.TextBox14.Text = dr.Cells(14).Value.ToString() : dac.TextBox1.Text = dr.Cells(15).Value.ToString() : dac.TextBox15.Text = dr.Cells(16).Value.ToString()
            dac.TextBox16.Text = dr.Cells(17).Value.ToString() : dac.TextBox17.Text = dr.Cells(18).Value.ToString() : dac.TextBox18.Text = dr.Cells(19).Value.ToString() : dac.TextBox19.Text = dr.Cells(20).Value.ToString()
            dac.TextBox20.Text = dr.Cells(21).Value.ToString() : dac.TextBox21.Text = dr.Cells(22).Value.ToString() : dac.TextBox23.Text = dr.Cells(24).Value.ToString() : dac.TextBox27.Text = dr.Cells(25).Value.ToString()
            dac.TextBox26.Text = dr.Cells(26).Value.ToString() : dac.TextBox25.Text = dr.Cells(27).Value.ToString() : dac.TextBox24.Text = dr.Cells(28).Value.ToString()
            '************************************************************************************************
        Catch ex As Exception
            MsgBox("ERROR : No Data Found " & ex.Message)
            dac.reset2()
        End Try
    End Sub
End Class
