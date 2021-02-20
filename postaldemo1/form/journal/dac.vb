Imports System.Data.OleDb
Imports System.IO
Imports DevExpress.XtraReports.UI
Imports System.Security.Cryptography
Imports System.Text
Imports Dapper

Public Class dac
    Dim ccs As String = mainfrm.css
    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged

    End Sub
    Dim ob, cr, sb, rdd, rdf, td, ssad, ssaf, rplid, rplif, rplit, vpp, oc1, oc2, ttb As Integer
    Dim cs, sbw, rdw, ssaw, tdw, rpliw, monw, othw, ttw As Integer
    Dim cur, ips, stam, clob As Integer
    Dim res1, res2, res3 As Integer

    Private Sub dac_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

    End Sub
    Private Sub dac_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd MMMM yyyy"
        DateTimePicker1.Value = Today

    End Sub
    Sub cal1()
        textdef()
        Try
            res1 = ob + cr + sb + rdd + rdf + td + ssad + ssaf + rplid + rplif + rplit + vpp + oc1 + oc2
            TextBox1.Text = res1

            res2 = cs + sbw + rdw + ssaw + tdw + rpliw + monw + othw
            TextBox23.Text = res2

            res3 = res1 - res2
            TextBox24.Text = res3
            clob = 0 + TextBox24.Text
            cur = clob - ips - stam
            TextBox27.Text = cur

        Catch ex As Exception
            MsgBox("ERROR in calculation")
        End Try



    End Sub
    Sub textdef()
        '************************************
        Try
            ob = 0 + TextBox2.Text : cs = 0 + TextBox15.Text
            cr = 0 + TextBox28.Text : sbw = 0 + TextBox16.Text
            sb = 0 + TextBox3.Text : rdw = 0 + TextBox17.Text
            rdd = 0 + TextBox4.Text : tdw = 0 + TextBox18.Text
            rdf = 0 + TextBox5.Text : ssaw = 0 + TextBox19.Text
            ssad = 0 + TextBox6.Text : rpliw = 0 + TextBox20.Text
            ssaf = 0 + TextBox7.Text : monw = 0 + TextBox21.Text
            td = 0 + TextBox8.Text : othw = 0 + TextBox22.Text
            rplid = 0 + TextBox9.Text : ttw = 0 + TextBox23.Text
            rplif = 0 + TextBox10.Text : cur = 0 + TextBox27.Text
            rplit = 0 + TextBox11.Text : ips = 0 + TextBox26.Text
            vpp = 0 + TextBox12.Text : stam = 0 + TextBox25.Text
            oc1 = 0 + TextBox13.Text : clob = 0 + TextBox24.Text
            oc2 = 0 + TextBox14.Text
            ttb = 0 + TextBox1.Text
        Catch ex As Exception
            MsgBox("try valid containt")
        End Try
        
        '********************************
    End Sub
   
    Private Sub TextBox28_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox9.KeyPress, TextBox8.KeyPress, TextBox7.KeyPress, TextBox6.KeyPress, TextBox5.KeyPress, TextBox4.KeyPress, TextBox3.KeyPress, TextBox28.KeyPress, TextBox26.KeyPress, TextBox25.KeyPress, TextBox22.KeyPress, TextBox21.KeyPress, TextBox20.KeyPress, TextBox2.KeyPress, TextBox19.KeyPress, TextBox18.KeyPress, TextBox17.KeyPress, TextBox16.KeyPress, TextBox15.KeyPress, TextBox14.KeyPress, TextBox13.KeyPress, TextBox12.KeyPress, TextBox11.KeyPress, TextBox10.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub
    Sub resettxt()
        TextBox1.Text = 0 : TextBox2.Text = 0 : TextBox3.Text = 0
        TextBox4.Text = 0 : TextBox5.Text = 0 : TextBox6.Text = 0
        TextBox7.Text = 0 : TextBox8.Text = 0 : TextBox9.Text = 0
        TextBox10.Text = 0 : TextBox11.Text = 0 : TextBox12.Text = 0
        TextBox15.Text = 0 : TextBox14.Text = 0 : TextBox16.Text = 0
        TextBox17.Text = 0 : TextBox18.Text = 0 : TextBox19.Text = 0
        TextBox20.Text = 0 : TextBox21.Text = 0 : TextBox22.Text = 0
        TextBox23.Text = 0 : TextBox24.Text = 0 : TextBox25.Text = 0
        TextBox26.Text = 0 : TextBox27.Text = 0 : TextBox28.Text = 0
        DateTimePicker1.Text = DateAndTime.Today
        TextBox13.Text = 0

    End Sub
    Public Sub reset2()
        TextBox1.Text = 0 : TextBox2.Text = 0 : TextBox3.Text = 0
        TextBox4.Text = 0 : TextBox5.Text = 0 : TextBox6.Text = 0
        TextBox7.Text = 0 : TextBox8.Text = 0 : TextBox9.Text = 0
        TextBox10.Text = 0 : TextBox11.Text = 0 : TextBox12.Text = 0 : TextBox13.Text = 0
        TextBox15.Text = 0 : TextBox14.Text = 0 : TextBox16.Text = 0
        TextBox17.Text = 0 : TextBox18.Text = 0 : TextBox19.Text = 0
        TextBox20.Text = 0 : TextBox21.Text = 0 : TextBox22.Text = 0
        TextBox23.Text = 0 : TextBox24.Text = 0 : TextBox25.Text = 0
        TextBox26.Text = 0 : TextBox27.Text = 0 : TextBox28.Text = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Sub ccmd()
        Try
            con = New OleDbConnection(ccs)
            con.Open()
            Dim ccb As String
            ccb = " insert into dacdb(D_ate,Open_bal,cashrec,Sbdep,rddep,rdfine,ssadep,ssafine,tddep,rplidep,rplifine,rplitax,vpp,othcol1,othcol2,totaldep,cashremet,sbwith,rdwith,tdwith,ssawith,rpliwith,MONwith,othwith,totalwith,curr_ency,stamp1,stamp2,colsebal)VALUES('" & DateTimePicker1.Text.ToString & "','" & TextBox2.Text & "','" & TextBox28.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & TextBox10.Text & "','" & TextBox11.Text & "','" & TextBox12.Text & "','" & TextBox13.Text & "','" & TextBox14.Text & "','" & TextBox1.Text & "','" & TextBox15.Text & "','" & TextBox16.Text & "','" & TextBox17.Text & "','" & TextBox18.Text & "','" & TextBox19.Text & "','" & TextBox20.Text & "','" & TextBox21.Text & "','" & TextBox22.Text & "','" & TextBox23.Text & "','" & TextBox27.Text & "','" & TextBox26.Text & "','" & TextBox25.Text & "','" & TextBox24.Text & "')"
            cmd = New OleDbCommand(ccb)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Data Saved")
        Catch ex As Exception
            MsgBox("EROR in Command in Data Entry :=:" + ex.Message)
        End Try
        
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        waitopen()
        daclist.MdiParent = mainfrm
        daclist.WindowState = FormWindowState.Normal
        daclist.Show()
        waitclose()
    End Sub
    Sub findd()
        Dim yest As String
        daclist.MdiParent = mainfrm
        daclist.WindowState = FormWindowState.Normal
        daclist.filt2()
        Try
            Dim dr As DataGridViewRow = daclist.DataGridView1.Rows(0)
            DateTimePicker1.Text = dr.Cells(0).Value.ToString()
            TextBox2.Text = dr.Cells(1).Value.ToString() : TextBox28.Text = dr.Cells(2).Value.ToString() : TextBox3.Text = dr.Cells(3).Value.ToString() : TextBox4.Text = dr.Cells(4).Value.ToString()
            TextBox5.Text = dr.Cells(5).Value.ToString() : TextBox6.Text = dr.Cells(6).Value.ToString() : TextBox7.Text = dr.Cells(7).Value.ToString() : TextBox8.Text = dr.Cells(8).Value.ToString()
            TextBox9.Text = dr.Cells(9).Value.ToString() : TextBox10.Text = dr.Cells(10).Value.ToString() : TextBox11.Text = dr.Cells(11).Value.ToString() : TextBox12.Text = dr.Cells(12).Value.ToString()
            TextBox13.Text = dr.Cells(13).Value.ToString() : TextBox14.Text = dr.Cells(14).Value.ToString() : TextBox1.Text = dr.Cells(15).Value.ToString() : TextBox15.Text = dr.Cells(16).Value.ToString()
            TextBox16.Text = dr.Cells(17).Value.ToString() : TextBox17.Text = dr.Cells(18).Value.ToString() : TextBox18.Text = dr.Cells(19).Value.ToString() : TextBox19.Text = dr.Cells(20).Value.ToString()
            TextBox20.Text = dr.Cells(21).Value.ToString() : TextBox21.Text = dr.Cells(22).Value.ToString() : TextBox23.Text = dr.Cells(24).Value.ToString() : TextBox27.Text = dr.Cells(25).Value.ToString()
            TextBox26.Text = dr.Cells(26).Value.ToString() : TextBox25.Text = dr.Cells(27).Value.ToString() : TextBox24.Text = dr.Cells(28).Value.ToString()
            '************************************************************************************************
        Catch ex As Exception
            MsgBox("ERROR : No Data Found " & ex.Message)
            reset2()

        End Try

    End Sub
    Sub rst3()
        TextBox1.Text = 0 : TextBox2.Text = 0 : TextBox3.Text = 0
        TextBox4.Text = 0 : TextBox5.Text = 0 : TextBox6.Text = 0
        TextBox7.Text = 0 : TextBox8.Text = 0 : TextBox9.Text = 0
        TextBox10.Text = 0 : TextBox11.Text = 0 : TextBox12.Text = 0
        TextBox15.Text = 0 : TextBox14.Text = 0 : TextBox16.Text = 0
        TextBox17.Text = 0 : TextBox18.Text = 0 : TextBox19.Text = 0
        TextBox20.Text = 0 : TextBox21.Text = 0 : TextBox22.Text = 0
        TextBox23.Text = 0
        TextBox27.Text = 0 : TextBox28.Text = 0
        DateTimePicker1.Text = DateAndTime.Today
        TextBox13.Text = 0
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        waitopen()
        monthlyReport.MdiParent = mainfrm
        monthlyReport.WindowState = FormWindowState.Normal
        monthlyReport.Show() : waitclose()
    End Sub
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        waitopen()
        findd() : waitclose()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        waitopen()

        Try
            con = New OleDbConnection(ccs)
            Dim comand As String = "SELECT d_ate, AccountType ,accountNumber, AccountHolderName , deposit , withdrow , balance , DLT , remark  from transdetail where d_ate like '%" & DateTimePicker1.Text & "%' order by AccountType"
            Dim list As List(Of ClS_transdetail) = con.Query(Of ClS_transdetail)(comand).ToList
            Using frm As printfrm = New printfrm()
                frm.FmPrit(list)
                frm.ShowDialog()
                waitclose()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            waitclose()
        End Try
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        MsgBox("This feature Is Not Avaible R8 9oo")
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles Button1.Click
        waitopen()
        ccmd()
        Button1.Enabled = False
        DateTimePicker1.Text = DateAndTime.Today
        waitclose()
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles Button3.Click
        waitopen()
        Try
            cal1()
            Button1.Enabled = True

        Catch ex As Exception
            MsgBox("Error In Calculate")
        End Try
        waitclose()
    End Sub

    Private Sub SimpleButton4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        waitopen()
        resettxt()
        Button3.Enabled = True
        waitclose()
    End Sub

    Private Sub SimpleButton4_Click_2(sender As Object, e As EventArgs) Handles Button7.Click
        waitopen()
        MessageBox.Show(" Opening balance =" & TextBox24.Text & " stamp = " & TextBox25.Text & " &" & TextBox26.Text & " Last Account Date is =" & DateTimePicker1.Text)
        rst3()
        TextBox2.Text = TextBox24.Text
        DateTimePicker1.Value = Now.AddDays(-1)
        MsgBox("check Date ")
        waitclose()
    End Sub
End Class