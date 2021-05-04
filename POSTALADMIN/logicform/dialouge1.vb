Public Class dialouge1

    'Private Sub tb_1mop_EditValueChanged(sender As Object, e As EventArgs) Handles tb_1mop.EditValueChanged
    '    Dim a, b, c, d, f, g, h, rs1 As Double
    '    Try
    '        a = "0" + tb_1mri.Text
    '        b = "0" + tb_1rc.Text
    '        c = "0" + tb_1sbd.Text
    '        d = "0" + tb_1rdw.Text
    '        f = "0" + tb_1tdw.Text
    '        g = "0" + tb_1sdw.Text
    '        h = "0" + tb_1mop.Text
    '        rs1 = a + b + c + d + f + g + h
    '        rs_1tp.Text = rs1
    '    Catch ex As Exception
    '    End Try
    'End Sub

    'Private Sub tb_2mop_EditValueChanged(sender As Object, e As EventArgs) Handles tb_2mop.EditValueChanged
    '    Dim a, b, c, d, f, g, h, rs1 As Double
    '    Try
    '        a = "0" + tb_2mri.Text
    '        b = "0" + tb_2rc.Text
    '        c = "0" + tb_2sbd.Text
    '        d = "0" + tb_2rdw.Text
    '        f = "0" + tb_2tdw.Text
    '        g = "0" + tb_2sdw.Text
    '        h = "0" + tb_2mop.Text
    '        rs1 = a + b + c + d + f + g + h
    '        rs_2tp.Text = rs1
    '    Catch ex As Exception
    '    End Try
    'End Sub

    'Private Sub tb_3mop_EditValueChanged(sender As Object, e As EventArgs) Handles tb_3mop.EditValueChanged
    '    Dim a, b, c, d, f, g, h, rs1 As Double
    '    Try
    '        a = "0" + tb_3mri.Text
    '        b = "0" + tb_3rc.Text
    '        c = "0" + tb_3sbd.Text
    '        d = "0" + tb_3rdw.Text
    '        f = "0" + tb_3tdw.Text
    '        g = "0" + tb_3sdw.Text
    '        h = "0" + tb_3mop.Text
    '        rs1 = a + b + c + d + f + g + h
    '        rs_3tp.Text = rs1
    '    Catch ex As Exception
    '    End Try
    'End Sub

    'Private Sub tb_4mop_EditValueChanged(sender As Object, e As EventArgs) Handles tb_4mop.EditValueChanged
    '    Dim a, b, c, d, f, g, h, rs1 As Double
    '    Try
    '        a = "0" + tb_4mri.Text
    '        b = "0" + tb_4rc.Text
    '        c = "0" + tb_4sbd.Text
    '        d = "0" + tb_4rdw.Text
    '        f = "0" + tb_4tdw.Text
    '        g = "0" + tb_4sdw.Text
    '        h = "0" + tb_4mop.Text
    '        rs1 = a + b + c + d + f + g + h
    '        rs_4tp.Text = rs1
    '    Catch ex As Exception
    '    End Try
    'End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)
        Using frm As printmain = New printmain
            frm.print_myworkload(workload.TextEdit1.Text, workload.ComboBoxEdit1.Text, workload.tb_nb.Text, workload.tb_ns.Text, workload.tb_nh.Text, workload.tb_hb.Text, workload.tb_twh.Text, workload.tb_dog.Text, workload.tb_pyl.Text)

            frm.ShowDialog()

        End Using
    End Sub

    Private Sub dialouge1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxEdit1.Text = workload.ComboBoxEdit1.Text
        ComboBoxEdit2.Text = workload.tb_1fm.Text
        ComboBoxEdit3.Text = workload.tb_2fm.Text
        ComboBoxEdit4.Text = workload.tb_3fm.Text
        ComboBoxEdit5.Text = workload.tb_4fm.Text
        'dnotes
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        calculate_dialog()

    End Sub
    Public Sub calculate_dialog()
        Dim a, b, c, d, f, g, h, rs1 As Double
        Try
            a = "0" + tb_1mri.Text
            b = "0" + tb_1rc.Text
            c = "0" + tb_1sbd.Text
            d = "0" + tb_1rdw.Text
            f = "0" + tb_1tdw.Text
            g = "0" + tb_1sdw.Text
            h = "0" + tb_1mop.Text
            rs1 = a + b + c + d + f + g + h
            rs_1tp.Text = rs1
        Catch ex As Exception
            '  MsgBox(ex.Message)
        End Try

        Dim a2, b2, c2, d2, f2, g2, h2, rs12 As Double
        Try
            a2 = "0" + tb_2mri.Text
            b2 = "0" + tb_2rc.Text
            c2 = "0" + tb_2sbd.Text
            d2 = "0" + tb_2rdw.Text
            f2 = "0" + tb_2tdw.Text
            g2 = "0" + tb_2sdw.Text
            h2 = "0" + tb_2mop.Text
            rs12 = a2 + b2 + c2 + d2 + f2 + g2 + h2
            rs_2tp.Text = rs12
        Catch ex As Exception
            '   MsgBox(ex.Message)
        End Try
        Dim a3, b3, c3, d3, f3, g3, h3, rs13 As Double
        Try
            a3 = "0" + tb_3mri.Text
            b3 = "0" + tb_3rc.Text
            c3 = "0" + tb_3sbd.Text
            d3 = "0" + tb_3rdw.Text
            f3 = "0" + tb_3tdw.Text
            g3 = "0" + tb_3sdw.Text
            h3 = "0" + tb_3mop.Text
            rs13 = a3 + b3 + c3 + d3 + f3 + g3 + h3
            rs_3tp.Text = rs13
        Catch ex As Exception
            '  MsgBox(ex.Message)
        End Try
        Dim a4, b4, c4, d4, f4, g4, h4, rs14 As Double
        Try
            a4 = "0" + tb_4mri.Text
            b4 = "0" + tb_4rc.Text
            c4 = "0" + tb_4sbd.Text
            d4 = "0" + tb_4rdw.Text
            f4 = "0" + tb_4tdw.Text
            g4 = "0" + tb_4sdw.Text
            h4 = "0" + tb_4mop.Text
            rs14 = a4 + b4 + c4 + d4 + f4 + g4 + h4
            rs_4tp.Text = rs14
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub tb_4mri_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextEdit2.KeyPress, TextEdit11.KeyPress, tb_4tdw.KeyPress, tb_4sdw.KeyPress, tb_4sbd.KeyPress, tb_4rdw.KeyPress, tb_4rc.KeyPress, tb_4mri.KeyPress, tb_4mop.KeyPress, tb_3tdw.KeyPress, tb_3sdw.KeyPress, tb_3sbd.KeyPress, tb_3rdw.KeyPress, tb_3rc.KeyPress, tb_3mri.KeyPress, tb_3mop.KeyPress, tb_2tdw.KeyPress, tb_2sdw.KeyPress, tb_2sbd.KeyPress, tb_2rdw.KeyPress, tb_2rc.KeyPress, tb_2mri.KeyPress, tb_2mop.KeyPress, tb_1tdw.KeyPress, tb_1sdw.KeyPress, tb_1sbd.KeyPress, tb_1rdw.KeyPress, tb_1rc.KeyPress, tb_1mri.KeyPress, tb_1mop.KeyPress, rs_4tp.KeyPress, rs_3tp.KeyPress, rs_2tp.KeyPress, rs_1tp.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) AndAlso Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.Hide()

    End Sub

    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        workload.tb_1acthm.Text = rs_1tp.Text
        workload.tb_2acthm.Text = rs_2tp.Text
        workload.tb_3acthm.Text = rs_3tp.Text
        workload.tb_4acthm.Text = rs_4tp.Text

        Me.Hide()

    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        MsgBox("No Function !!..")
    End Sub
End Class