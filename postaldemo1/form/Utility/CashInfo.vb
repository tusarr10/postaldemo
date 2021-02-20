Imports System.Data.OleDb
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports Dapper
Public Class CashInfo
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = mainfrm.css
    Dim htext As String

    Dim str2000, str1000, str500, str200, str100, str50, str20, str10 As String

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click

        calculate()

        SimpleButton2.Enabled = True
    End Sub
    Dim x, y, z, a, b, c, d, e As Double
    Dim a2, b2, c2, d2, e2, f2, g2, h2, total As Double
    Private Sub calculate()
        str2000 = "0" + TextEdit1.Text
        str1000 = "0" + TextEdit2.Text
        str500 = "0" + TextEdit3.Text
        str200 = "0" + TextEdit4.Text
        str100 = "0" + TextEdit5.Text
        str50 = "0" + TextEdit6.Text
        str20 = "0" + TextEdit7.Text
        str10 = "0" + TextEdit8.Text
      

        Try
            x = str2000
            y = str1000
            z = str500
            a = str200
            b = str100
            c = str50
            d = str20
            e = str10
        Catch ex As Exception
            MsgBox("Unable To Convert String To Number")
        End Try
        LabelControl2.Text = "0" + 2000 * x
        LabelControl3.Text = "0" + 1000 * y
        LabelControl5.Text = "0" + 500 * z
        LabelControl7.Text = "0" + 200 * a
        LabelControl9.Text = "0" + 100 * b
        LabelControl11.Text = "0" + 50 * c
        LabelControl13.Text = "0" + 20 * d
        LabelControl15.Text = "0" + 10 * e

        a2 = LabelControl2.Text
        b2 = LabelControl3.Text
        c2 = LabelControl5.Text
        d2 = LabelControl7.Text
        e2 = LabelControl9.Text
        f2 = LabelControl11.Text
        g2 = LabelControl13.Text
        h2 = LabelControl15.Text

        total = a2 + b2 + c2 + d2 + e2 + f2 + g2 + h2

        LabelControl17.Text = " = " + total.ToString



    End Sub

    Private Sub TextEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit1.EditValueChanged

        Try
            str2000 = "0" + TextEdit1.Text
            x = str2000
            LabelControl2.Text = "0" + 2000 * x
        Catch ex As Exception

        End Try
       

    End Sub

    Private Sub TextEdit2_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit2.EditValueChanged
        Try
            str1000 = "0" + TextEdit2.Text
            x = str1000
            LabelControl3.Text = "0" + 1000 * x
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextEdit3_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit3.EditValueChanged
        Try
            str500 = "0" + TextEdit3.Text
            x = str500
            LabelControl5.Text = "0" + 500 * x
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextEdit4_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit4.EditValueChanged
        Try
            str200 = "0" + TextEdit4.Text
            x = str200
            LabelControl7.Text = "0" + 200 * x
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextEdit5_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit5.EditValueChanged
        Try
            str100 = "0" + TextEdit5.Text
            x = str100
            LabelControl9.Text = "0" + 100 * x
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextEdit6_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit6.EditValueChanged
        Try
            str50 = "0" + TextEdit6.Text
            x = str50
            LabelControl11.Text = "0" + 50 * x
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextEdit7_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit7.EditValueChanged
        Try
            str20 = "0" + TextEdit7.Text
            x = str20
            LabelControl13.Text = "0" + 20 * x
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextEdit8_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit8.EditValueChanged
        Try
            str10 = "0" + TextEdit8.Text
            x = str10
            LabelControl15.Text = "0" + 10 * x
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        waitopen()
        connect_Add()
        MsgBox("Saved !!.. ")
        waitclose()
    End Sub
    Sub connect_Add()
        Try
            con = New OleDbConnection(cs)
            con.Open()
            Dim cb1 As String = "insert into CashInfo(D_ate,2000,1000,500,200,100,50,20,10,t_ime) VALUES('" & DateTimePicker1.Text & "','0" & TextEdit1.Text & "','0" & TextEdit2.Text & "','0" & TextEdit3.Text & "','0" & TextEdit4.Text & "','0" & TextEdit5.Text & "','0" & TextEdit6.Text & "','0" & TextEdit7.Text & "','0" & TextEdit8.Text & "','" & ComboBox1.Text & "')"
            'Dim cb1 As String = "insert into CashInfo(D_ate) VALUES('" & DateTimePicker1.Text & "')"
            cmd = New OleDbCommand(cb1)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox("Opps Error" + ex.Message)
        End Try

    End Sub

    Private Sub CashInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd MMMM yyyy"
        DateTimePicker1.Text = mainfrm.LabelControl2.Text
    End Sub

    Private Sub TextEdit8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextEdit8.KeyPress, TextEdit7.KeyPress, TextEdit6.KeyPress, TextEdit5.KeyPress, TextEdit4.KeyPress, TextEdit3.KeyPress, TextEdit2.KeyPress, TextEdit1.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True

            End If
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        accountSettingList.Show()
        accountSettingList.filt3(DateTimePicker1.Text, ComboBox1.Text)
    End Sub
End Class