Imports System.Data.OleDb
Imports excel = Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop.Excel

Public Class workload

    'FOR EXCEL COMMNAD
    Dim xlApp As excel.Application
    Dim xlWorkBook As excel.Workbook
    Dim xlWorkSheet As excel.Worksheet

    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As System.Data.DataTable
    Dim con As System.Data.OleDb.OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New System.Data.DataTable
    Dim cs As String = mainforfm.css

    'Private Sub TextEdit33_EditValueChanged(sender As Object, e As EventArgs) Handles tb_4npp.EditValueChanged
    '    Dim a, b, c, d, rs1, rs2, rs3 As Double
    '    Try
    '        a = tb_1npp.Text
    '        b = tb_2npp.Text
    '        c = tb_3npp.Text
    '        d = tb_1npp.Text
    '        rs1 = a + b + c + d
    '        rs2 = rs1 / 4
    '        rs3 = rs2 / 10
    '        rs_5npp.Text = rs1
    '        rs_6npp.Text = rs2
    '        rs_7npp.Text = rs3

    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Sub TextEdit34_EditValueChanged(sender As Object, e As EventArgs) Handles tb_3ntbcm.EditValueChanged 'apdtba.EditValueChanged, tb_1noapdtba.EditValueChanged, tb_3noapdtmo.EditValueChanged, tb_2ntbcm.EditValueChanged, tb_1ntbcm.EditValueChanged, tb_4awrdd.EditValueChanged, tb_3awrdd.EditValueChanged, tb_2awrdd.EditValueChanged, tb_1awrdd.EditValueChanged, tb_2noapdtmo.EditValueChanged, tb_1noapdtmo.EditValueChanged
    '    Dim a, b, c, d, rs1, rs2, rs3 As Double
    '    Try
    '        a = tb_1awrdd.Text
    '        b = tb_2awrdd.Text
    '        c = tb_3awrdd.Text
    '        d = tb_4awrdd.Text
    '        rs1 = a + b + c + d
    '        rs2 = rs1 / 4
    '        rs3 = rs2 / 25
    '        rs_5awrdd.Text = rs1
    '        rs_6awrdd.Text = rs2
    '        rs_7awrdd.Text = rs3

    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Sub TextEdit35_EditValueChanged(sender As Object, e As EventArgs) Handles tb_4ntbcm.EditValueChanged ', tb_4noapdtba.EditValueChanged, tb_4noapdtmo.EditValueChanged, tb_3noapdtba.EditValueChanged
    '    Dim a, b, c, d, rs1, rs2, rs3 As Double
    '    Try
    '        a = tb_1ntbcm.Text
    '        b = tb_2ntbcm.Text
    '        c = tb_3ntbcm.Text
    '        d = tb_4ntbcm.Text
    '        rs1 = a + b + c + d
    '        rs2 = rs1 / 4
    '        rs3 = rs2 / 20
    '        rs_5ntbcm.Text = rs1
    '        rs_6ntbcm.Text = rs2
    '        rs_7ntbcm.Text = rs3

    '    Catch ex As Exception

    '    End Try
    'End Sub


    'Private Sub tb_4nuahd_EditValueChanged(sender As Object, e As EventArgs) Handles tb_4nuahd.EditValueChanged
    '    Dim w, x, y, z, rs1, rs2, rs3 As Double
    '    Try
    '        w = tb_1nuahd.Text
    '        x = tb_2nuahd.Text
    '        y = tb_3nuahd.Text
    '        z = tb_4nuahd.Text
    '        rs1 = x + y + z + w
    '        rs2 = rs1 / 4
    '        rs3 = rs2 / 25
    '        rs_5nuahd.Text = rs1
    '        rs_6nuahd.Text = rs2
    '        rs_7nuahd.Text = rs3

    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Sub tb_4nrahm_EditValueChanged(sender As Object, e As EventArgs) Handles tb_4nrahm.EditValueChanged
    '    Dim w, x, y, z, rs1, rs2, rs3 As Double
    '    Try
    '        w = tb_1nrahm.Text
    '        x = tb_2nrahm.Text
    '        y = tb_3nrahm.Text
    '        z = tb_4nrahm.Text
    '        rs1 = x + y + z + w
    '        rs2 = rs1 / 4
    '        rs3 = rs2 / 22
    '        rs_5nrahm.Text = rs1
    '        rs_6nrahm.Text = rs2
    '        rs_7nrahm.Text = rs3
    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Sub tb_4nmhm_EditValueChanged(sender As Object, e As EventArgs) Handles tb_4nmhm.EditValueChanged
    '    Dim a, b, c, d, rs1, rs2, rs3 As Double
    '    Try
    '        a = tb_1nmhm.Text
    '        b = tb_2nmhm.Text
    '        c = tb_3nmhm.Text
    '        d = tb_4nmhm.Text
    '        rs1 = a + b + c + d
    '        rs2 = rs1 / 4
    '        rs3 = rs2 / 15
    '        rs_5nmhm.Text = rs1
    '        rs_6nmhm.Text = rs2
    '        rs_7nmhm.Text = rs3




    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Sub tb_4ssm_EditValueChanged(sender As Object, e As EventArgs) Handles tb_4ssm.EditValueChanged
    '    Dim a, b, c, d, rs1, rs2, rs3 As Double
    '    Try
    '        a = tb_1ssm.Text
    '        b = tb_2ssm.Text
    '        c = tb_3ssm.Text
    '        d = tb_4ssm.Text
    '        rs1 = a + b + c + d
    '        rs2 = rs1 / 4
    '        rs3 = rs2 / 900
    '        rs_5ssm.Text = rs1
    '        rs_6ssm.Text = rs2
    '        rs_7ssm.Text = rs3


    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Sub tb_4acthm_EditValueChanged(sender As Object, e As EventArgs) Handles tb_4acthm.EditValueChanged
    '    Dim a, b, c, d, rs1, rs2, rs3 As Double
    '    Try
    '        a = tb_1acthm.Text
    '        b = tb_2acthm.Text
    '        c = tb_3acthm.Text
    '        d = tb_4acthm.Text
    '        rs1 = a + b + c + d
    '        rs2 = rs1 / 4
    '        rs3 = rs2 / 20000
    '        rs_5acthm.Text = rs1
    '        rs_6acthm.Text = rs2
    '        rs_7acthm.Text = rs3

    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Sub tb_4nptm_EditValueChanged(sender As Object, e As EventArgs) Handles tb_4nptm.EditValueChanged
    '    Dim a, b, c, d, rs1, rs2, rs3 As Double
    '    Try
    '        a = tb_1nptm.Text
    '        b = tb_2nptm.Text
    '        c = tb_3nptm.Text
    '        d = tb_4nptm.Text
    '        rs1 = a + b + c + d
    '        rs2 = rs1 / 4
    '        rs3 = rs2 / 10
    '        rs_5nptm.Text = rs1
    '        rs_6nptm.Text = rs2
    '        rs_7nptm.Text = rs3

    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Sub tb_4noapdtmo_EditValueChanged(sender As Object, e As EventArgs) Handles tb_4noapdtmo.EditValueChanged
    '    Dim a, b, c, d, rs1, rs2, rs3 As Double
    '    Try
    '        a = tb_1noapdtmo.Text
    '        b = tb_2noapdtmo.Text
    '        c = tb_3noapdtmo.Text
    '        d = tb_4noapdtmo.Text
    '        rs1 = a + b + c + d
    '        rs2 = rs1 / 4
    '        rs3 = rs2 / 15
    '        rs_5noapdtmo.Text = rs1
    '        rs_6noapdtmo.Text = rs2
    '        rs_7noapdtmo.Text = rs3

    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Sub tb_4noapdtba_EditValueChanged(sender As Object, e As EventArgs) Handles tb_4noapdtba.EditValueChanged
    '    Dim a, b, c, d, rs1, rs2, rs3 As Double
    '    Try
    '        a = tb_1noapdtba.Text
    '        b = tb_2noapdtba.Text
    '        c = tb_3noapdtba.Text
    '        d = tb_4noapdtba.Text
    '        rs1 = a + b + c + d
    '        rs2 = rs1 / 4
    '        rs3 = rs2 / 10
    '        rs_5noapdtba.Text = rs1
    '        rs_6noapdtba.Text = rs2
    '        rs_7noapdtba.Text = rs3

    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Sub rs_7awrdd_EditValueChanged(sender As Object, e As EventArgs) Handles rs_7awrdd.EditValueChanged

    '    Dim a, b, c, d, l, f, g, h, i, j, k, rs1, rs2 As Double
    '    Try
    '        '  a = "0" + rs_7fm.Text
    '        b = "0" + rs_7nuahd.Text
    '        c = "0" + rs_7nrahm.Text
    '        d = "0" + rs_7nmhm.Text
    '        l = "0" + rs_7ssm.Text
    '        f = "0" + rs_7acthm.Text
    '        g = "0" + rs_7nptm.Text
    '        h = "0" + rs_7npp.Text
    '        i = "0" + rs_7ntbcm.Text
    '        j = "0" + rs_7noapdtmo.Text
    '        k = "0" + rs_7noapdtba.Text
    '        ' rs2 = "0" + rs_7awrdd.Text
    '        rs1 = 0 + b + c + d + f + g + h + i + j + k + l '+ rs2
    '        rs_tp.Text = rs1
    '    Catch ex As Exception

    '    End Try
    'End Sub


    Public Sub calculate_work() ' for calculate

        Dim a11, b11, c11, d11, rs111, rs211, rs311 As Double
        Try
            a11 = tb_1npp.Text
            b11 = tb_2npp.Text
            c11 = tb_3npp.Text
            d11 = tb_1npp.Text
            rs111 = a11 + b11 + c11 + d11
            rs211 = rs111 / 4
            rs311 = rs211 / 10
            rs_5npp.Text = rs111
            rs_6npp.Text = rs211
            rs_7npp.Text = rs311

        Catch ex As Exception

        End Try

        Dim a10, b10, c10, d10, rs110, rs210, rs310 As Double
        Try
            a10 = tb_1awrdd.Text
            b10 = tb_2awrdd.Text
            c10 = tb_3awrdd.Text
            d10 = tb_4awrdd.Text
            rs110 = a10 + b10 + c10 + d10
            rs210 = rs110 / 4
            rs310 = rs210 / 25
            rs_5awrdd.Text = rs110
            rs_6awrdd.Text = rs210
            rs_7awrdd.Text = rs310

        Catch ex As Exception

        End Try

        Dim a9, b9, c9, d9, rs19, rs29, rs39 As Double
        Try
            a9 = tb_1ntbcm.Text
            b9 = tb_2ntbcm.Text
            c9 = tb_3ntbcm.Text
            d9 = tb_4ntbcm.Text
            rs19 = a9 + b9 + c9 + d9
            rs29 = rs19 / 4
            rs39 = rs29 / 20
            rs_5ntbcm.Text = rs19
            rs_6ntbcm.Text = rs29
            rs_7ntbcm.Text = rs39

        Catch ex As Exception

        End Try

        Dim w8, x8, y8, z8, rs18, rs28, rs38 As Double
        Try
            w8 = tb_1nuahd.Text
            x8 = tb_2nuahd.Text
            y8 = tb_3nuahd.Text
            z8 = tb_4nuahd.Text
            rs18 = x8 + y8 + z8 + w8
            rs28 = rs18 / 4
            rs38 = rs28 / 25
            rs_5nuahd.Text = rs18
            rs_6nuahd.Text = rs28
            rs_7nuahd.Text = rs38

        Catch ex As Exception

        End Try

        Dim w, x, y, z, rs17, rs27, rs37 As Double
        Try
            w = tb_1nrahm.Text
            x = tb_2nrahm.Text
            y = tb_3nrahm.Text
            z = tb_4nrahm.Text
            rs17 = x + y + z + w
            rs27 = rs17 / 4
            rs37 = rs27 / 22
            rs_5nrahm.Text = rs17
            rs_6nrahm.Text = rs27
            rs_7nrahm.Text = rs37
        Catch ex As Exception

        End Try

        Dim a6, b6, c6, d6, rs16, rs26, rs36 As Double
        Try
            a6 = tb_1nmhm.Text
            b6 = tb_2nmhm.Text
            c6 = tb_3nmhm.Text
            d6 = tb_4nmhm.Text
            rs16 = a6 + b6 + c6 + d6
            rs26 = rs16 / 4
            rs36 = rs26 / 15
            rs_5nmhm.Text = rs16
            rs_6nmhm.Text = rs26
            rs_7nmhm.Text = rs36




        Catch ex As Exception

        End Try

        Dim a5, b5, c5, d5, rs15, rs25, rs35 As Double
        Try
            a5 = tb_1ssm.Text
            b5 = tb_2ssm.Text
            c5 = tb_3ssm.Text
            d5 = tb_4ssm.Text
            rs15 = a5 + b5 + c5 + d5
            rs25 = rs15 / 4
            rs35 = rs25 / 900
            rs_5ssm.Text = rs15
            rs_6ssm.Text = rs25
            rs_7ssm.Text = rs35


        Catch ex As Exception

        End Try

        Dim a4, b4, c4, d4, rs14, rs24, rs34 As Double
        Try
            a4 = tb_1acthm.Text
            b4 = tb_2acthm.Text
            c4 = tb_3acthm.Text
            d4 = tb_4acthm.Text
            rs14 = a4 + b4 + c4 + d4
            rs24 = rs14 / 4
            rs34 = rs24 / 20000
            rs_5acthm.Text = rs14
            rs_6acthm.Text = rs24
            rs_7acthm.Text = rs34

        Catch ex As Exception

        End Try

        Dim a3, b3, c3, d3, rs13, rs23, rs33 As Double
        Try
            a3 = tb_1nptm.Text
            b3 = tb_2nptm.Text
            c3 = tb_3nptm.Text
            d3 = tb_4nptm.Text
            rs13 = a3 + b3 + c3 + d3
            rs23 = rs13 / 4
            rs33 = rs23 / 10
            rs_5nptm.Text = rs13
            rs_6nptm.Text = rs23
            rs_7nptm.Text = rs33

        Catch ex As Exception

        End Try

        Dim a2, b2, c2, d2, rs12, rs22, rs32 As Double
        Try
            a2 = tb_1noapdtmo.Text
            b2 = tb_2noapdtmo.Text
            c2 = tb_3noapdtmo.Text
            d2 = tb_4noapdtmo.Text
            rs12 = a2 + b2 + c2 + d2
            rs22 = rs12 / 4
            rs32 = rs22 / 15
            rs_5noapdtmo.Text = rs12
            rs_6noapdtmo.Text = rs22
            rs_7noapdtmo.Text = rs32

        Catch ex As Exception

        End Try

        Dim a1, b1, c1, d1, rs11, rs21, rs31 As Double
        Try
            a1 = tb_1noapdtba.Text
            b1 = tb_2noapdtba.Text
            c1 = tb_3noapdtba.Text
            d1 = tb_4noapdtba.Text
            rs11 = a1 + b1 + c1 + d1
            rs21 = rs11 / 4
            rs31 = rs21 / 10
            rs_5noapdtba.Text = rs11
            rs_6noapdtba.Text = rs21
            rs_7noapdtba.Text = rs31

        Catch ex As Exception

        End Try

        Dim a, b, c, d, l, f, g, h, i, j, k, rs1, rs2 As Double
        Try
            '' a = "0" + rs_7fm.Text
            b = "0" + rs_7nuahd.Text
            c = "0" + rs_7nrahm.Text
            d = "0" + rs_7nmhm.Text
            l = "0" + rs_7ssm.Text
            f = "0" + rs_7acthm.Text
            g = "0" + rs_7nptm.Text
            h = "0" + rs_7npp.Text
            i = "0" + rs_7ntbcm.Text
            j = "0" + rs_7noapdtmo.Text
            k = "0" + rs_7noapdtba.Text
            rs2 = "0" + rs_7awrdd.Text
            rs1 = 0 + b + c + d + f + g + h + i + j + k + l + rs2
            rs_tp.Text = rs1
        Catch ex As Exception

        End Try

    End Sub


    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        dialouge1.ShowDialog()
    End Sub

    Private Sub SimpleButton10_Click(sender As Object, e As EventArgs) Handles SimpleButton10.Click
        Using frm As printmain = New printmain
            frm.print_myworkload(TextEdit1.Text, ComboBoxEdit1.Text, tb_nb.Text, tb_ns.Text, tb_nh.Text, tb_hb.Text, tb_twh.Text, tb_dog.Text, tb_pyl.Text)

            frm.ShowDialog()

        End Using
    End Sub

    Private Sub tb_4nuahd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_4ssm.KeyPress, tb_4nuahd.KeyPress, tb_4ntbcm.KeyPress, tb_4nrahm.KeyPress, tb_4nptm.KeyPress, tb_4npp.KeyPress, tb_4noapdtmo.KeyPress, tb_4noapdtba.KeyPress, tb_4nmhm.KeyPress, tb_4awrdd.KeyPress, tb_4acthm.KeyPress, tb_3ssm.KeyPress, tb_3nuahd.KeyPress, tb_3ntbcm.KeyPress, tb_3nrahm.KeyPress, tb_3nptm.KeyPress, tb_3npp.KeyPress, tb_3noapdtmo.KeyPress, tb_3noapdtba.KeyPress, tb_3nmhm.KeyPress, tb_3awrdd.KeyPress, tb_3acthm.KeyPress, tb_2ssm.KeyPress, tb_2nuahd.KeyPress, tb_2ntbcm.KeyPress, tb_2nrahm.KeyPress, tb_2nptm.KeyPress, tb_2npp.KeyPress, tb_2noapdtmo.KeyPress, tb_2noapdtba.KeyPress, tb_2nmhm.KeyPress, tb_2awrdd.KeyPress, tb_2acthm.KeyPress, tb_1ssm.KeyPress, tb_1nuahd.KeyPress, tb_1ntbcm.KeyPress, tb_1nrahm.KeyPress, tb_1nptm.KeyPress, tb_1npp.KeyPress, tb_1noapdtmo.KeyPress, tb_1noapdtba.KeyPress, tb_1nmhm.KeyPress, tb_1awrdd.KeyPress, tb_1acthm.KeyPress, rs_7awrdd.KeyPress, rs_6awrdd.KeyPress, rs_5awrdd.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) AndAlso Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        Try
            dialouge1.Close()
            resetall()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub workload_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            dialouge1.Close()

        Catch ex As Exception

        End Try
    End Sub

    Public Sub resetall()
        ComboBoxEdit1.Text = ""
        TextEdit1.Text = ""
        tb_nb.Text = ""
        tb_ns.Text = ""
        tb_nh.Text = ""
        tb_hb.Text = ""
        tb_twh.Text = ""
        tb_pyl.Text = ""
        tb_dog.Text = ""
        tb_1fm.Text = ""
        tb_2fm.Text = ""
        tb_3fm.Text = ""
        tb_4fm.Text = ""
        'nuahd
        tb_1nuahd.Text = ""
        tb_2nuahd.Text = ""
        tb_3nuahd.Text = ""
        tb_4nuahd.Text = ""
        rs_5nuahd.Text = ""
        rs_6nuahd.Text = ""
        rs_7nuahd.Text = ""
        'nrahm
        tb_1nrahm.Text = ""
        tb_2nrahm.Text = ""
        tb_3nrahm.Text = ""
        tb_4nrahm.Text = ""
        rs_5nrahm.Text = ""
        rs_6nrahm.Text = ""
        rs_7nrahm.Text = ""

        tb_1nmhm.Text = ""
        tb_2nmhm.Text = ""
        tb_3nmhm.Text = ""
        tb_4nmhm.Text = ""
        rs_5nmhm.Text = ""
        rs_6nmhm.Text = ""
        rs_7nmhm.Text = ""

        tb_1ssm.Text = ""
        tb_2ssm.Text = ""
        tb_3ssm.Text = ""
        tb_4ssm.Text = ""
        rs_5ssm.Text = ""
        rs_6ssm.Text = ""
        rs_7ssm.Text = ""

        tb_1acthm.Text = ""
        tb_2acthm.Text = ""
        tb_3acthm.Text = ""
        tb_4acthm.Text = ""
        rs_5acthm.Text = ""
        rs_6acthm.Text = ""
        rs_7acthm.Text = ""

        tb_1npp.Text = ""
        tb_2npp.Text = ""
        tb_3npp.Text = ""
        tb_4npp.Text = ""
        rs_5npp.Text = ""
        rs_6npp.Text = ""
        rs_7npp.Text = ""

        tb_1ntbcm.Text = ""
        tb_2ntbcm.Text = ""
        tb_3ntbcm.Text = ""
        tb_4ntbcm.Text = ""
        rs_5ntbcm.Text = ""
        rs_6ntbcm.Text = ""
        rs_7ntbcm.Text = ""

        tb_1noapdtmo.Text = ""
        tb_2noapdtmo.Text = ""
        tb_3noapdtmo.Text = ""
        tb_4noapdtmo.Text = ""
        rs_5noapdtmo.Text = ""
        rs_6noapdtmo.Text = ""
        rs_7noapdtmo.Text = ""

        tb_1noapdtba.Text = ""
        tb_2noapdtba.Text = ""
        tb_3noapdtba.Text = ""
        tb_4noapdtba.Text = ""
        rs_5noapdtba.Text = ""
        rs_6noapdtba.Text = ""
        rs_7noapdtba.Text = ""

        tb_1awrdd.Text = ""
        tb_2awrdd.Text = ""
        tb_3awrdd.Text = ""
        tb_4awrdd.Text = ""
        rs_5awrdd.Text = ""
        rs_6awrdd.Text = ""
        rs_7awrdd.Text = ""

        tb_1nptm.Text = ""
        tb_2nptm.Text = ""
        tb_3nptm.Text = ""
        tb_4nptm.Text = ""
        rs_5nptm.Text = ""
        rs_6nptm.Text = ""
        rs_7nptm.Text = ""

        rs_tp.Text = ""


    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        calculate_work()
        SimpleButton9.Enabled = True
        SimpleButton10.Enabled = True
        SimpleButton8.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        calculate_work()

    End Sub
    Public Sub save_data_workload()
        Dim cb As String

        Try
            con = New System.Data.OleDb.OleDbConnection(cs)
            con.Open()
            cb = "INSERT INTO `WOKLOD` (`ID`, `N_AME`, `BO`, `SO`, `HO`, `DES`, `BUSHOUR`, `WORKINGHOUR`,`Y_EAR`,`D_ATE`, `PAYLVL`, `M1`, `M2`, `M3`, `M4`, `M1UAH`, `M1RAH`, `M1MO`, `M1SS`, `M1ACTHM`, `M1SRTSTRS`, `M1PLI`, `M1TELBILL`, `M1OLDMO`, `M1OLDBANK`, `M1MOI`, `M1RPLICOL`, `M1SBDEP`, `M1RDDEP`, `M1TDDEP`, `M1SSA`, `M1MOP`,`ACCWORK`, `M2UAH`, `M2RAH`, `M2MO`, `M2SS`, `M2ACTHM`, `M2SRTSTRS`, `M2PLI`, `M2TELBILL`, `M2OLDMO`, `M2OLDBANK`, `M2MOI`, `M2RPLICOL`, `M2SBDEP`, `M2RDDEP`, `M2TDDEP`, `M2SSA`, `M2MOP`, `M3UAH`, `M3RAH`, `M3MO`, `M3SS`, `M3ACTHM`, `M3SRTSTRS`, `M3PLI`, `M3TELBILL`, `M3OLDMO`, `M3OLDBANK`, `M3MOI`, `M3RPLICOL`, `M3SBDEP`, `M3RDDEP`, `M3TDDEP`, `M3SSA`, `M3MOP`, `M4UAH`, `M4RAH`, `M4MO`, `M4SS`, `M4ACTHM`, `M4SRTSTRS`, `M4PLI`, `M4TELBILL`, `M4OLDMO`, `M4OLDBANK`, `M4MOI`, `M4RPLICOL`, `M4SBDEP`, `M4RDDEP`, `M4TDDEP`, `M4SSA`, `M4MOP`) VALUES ('" & tb_nb.Text + ComboBoxEdit1.Text + tb_dog.Text & "', '" & "" & "', '" & tb_nb.Text & "', '" & tb_ns.Text & "', '" & tb_nh.Text & "', '" & tb_dog.Text & "', '" & tb_hb.Text & "', '" & tb_twh.Text & "', '" & ComboBoxEdit1.Text & "','" & TextEdit1.Text & "','" & tb_pyl.Text & "', '" & tb_1fm.Text & "', '" & tb_2fm.Text & "', '" & tb_3fm.Text & "', '" & tb_4fm.Text & "', '" & tb_1nuahd.Text & "', '" & tb_1nrahm.Text & "', '" & tb_1nmhm.Text & "', '" & tb_1ssm.Text & "', '" & tb_1acthm.Text & "', '" & tb_1nptm.Text & "', '" & tb_1npp.Text & "', '" & tb_1ntbcm.Text & "', '" & tb_1noapdtmo.Text & "', '" & tb_1noapdtba.Text & "','" & dialouge1.tb_1mri.Text & "', '" & dialouge1.tb_1rc.Text & "', '" & dialouge1.tb_1sbd.Text & "', '" & dialouge1.tb_1rdw.Text & "', '" & dialouge1.tb_1tdw.Text & "', '" & dialouge1.tb_1sdw.Text & "', '" & dialouge1.tb_1mop.Text & "','" & rs_7awrdd.Text & "',  '" & tb_2nuahd.Text & "', '" & tb_2nrahm.Text & "', '" & tb_2nmhm.Text & "', '" & tb_2ssm.Text & "',  '" & tb_2acthm.Text & "', '" & tb_2nptm.Text & "', '" & tb_2npp.Text & "', '" & tb_2ntbcm.Text & "', '" & tb_2noapdtmo.Text & "', '" & tb_2noapdtba.Text & "', '" & dialouge1.tb_2mri.Text & "', '" & dialouge1.tb_2rc.Text & "', '" & dialouge1.tb_2sbd.Text & "', '" & dialouge1.tb_2rdw.Text & "', '" & dialouge1.tb_2tdw.Text & "', '" & dialouge1.tb_2sdw.Text & "', '" & dialouge1.tb_2mop.Text & "', '" & tb_3nuahd.Text & "', '" & tb_3nrahm.Text & "', '" & tb_3nmhm.Text & "', '" & tb_3ssm.Text & "', '" & tb_3acthm.Text & "', '" & tb_3nptm.Text & "', '" & tb_3npp.Text & "', '" & tb_3ntbcm.Text & "', '" & tb_3noapdtmo.Text & "', '" & tb_3noapdtba.Text & "', '" & dialouge1.tb_3mri.Text & "', '" & dialouge1.tb_3rc.Text & "', '" & dialouge1.tb_3sbd.Text & "', '" & dialouge1.tb_3rdw.Text & "', '" & dialouge1.tb_3tdw.Text & "', '" & dialouge1.tb_3sdw.Text & "', '" & dialouge1.tb_3mop.Text & "','" & tb_4nuahd.Text & "', '" & tb_4nrahm.Text & "', '" & tb_4nmhm.Text & "', '" & tb_4ssm.Text & "', '" & tb_4acthm.Text & "', '" & tb_4nptm.Text & "', '" & tb_4npp.Text & "', '" & tb_4ntbcm.Text & "', '" & tb_4noapdtmo.Text & "', '" & tb_4noapdtba.Text & "', '" & dialouge1.tb_4mri.Text & "', '" & dialouge1.tb_4rc.Text & "', '" & dialouge1.tb_4sbd.Text & "', '" & dialouge1.tb_4rdw.Text & "', '" & dialouge1.tb_4tdw.Text & "', '" & dialouge1.tb_4sdw.Text & "', '" & dialouge1.tb_4mop.Text & "')"
            cmd = New OleDbCommand(cb)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Successfully saved", "  Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SimpleButton8_Click(sender As Object, e As EventArgs) Handles SimpleButton8.Click
        save_data_workload()

    End Sub
    Public Sub update_data_workload(ByVal x As String)
        waitopen()
        Try
            MsgBox("Bo name and year and degi can not be updat")
            con = New System.Data.OleDb.OleDbConnection(cs)
            con.Open()
            Dim cb As String

            cb = "UPDATE `WOKLOD` SET `N_AME`='" & x & "',`BO`='" & tb_nb.Text & "',`DES`='" & tb_dog.Text & "',`SO`='" & tb_ns.Text & "', `HO`='" & tb_nh.Text & "',`BUSHOUR`='" & tb_hb.Text & "',`WORKINGHOUR`='" & tb_twh.Text & "',`D_ATE`='" & TextEdit1.Text & "',`PAYLVL`='" & tb_pyl.Text & "',`M1`='" & tb_1fm.Text & "',`M2`='" & tb_2fm.Text & "',`M3`='" & tb_3fm.Text & "',`M4`='" & tb_4fm.Text & "',`M1UAH`='" & tb_1nuahd.Text & "',`M2UAH`='" & tb_2nuahd.Text & "',`M3UAH`='" & tb_3nuahd.Text & "',`M4UAH`='" & tb_4nuahd.Text & "',`M1RAH`='" & tb_1nrahm.Text & "',`M2RAH`='" & tb_2nrahm.Text & "',`M3RAH`='" & tb_3nrahm.Text & "',`M4RAH`='" & tb_4nrahm.Text & "',`M1MO`='" & tb_1nmhm.Text & "',`M2MO`='" & tb_2nmhm.Text & "',`M3MO`='" & tb_3nmhm.Text & "',`M4MO`='" & tb_4nmhm.Text & "',`M1SS`='" & tb_1ssm.Text & "',`M2SS`='" & tb_2ssm.Text & "',`M3SS`='" & tb_3ssm.Text & "',`M4SS`='" & tb_4ssm.Text & "',`M1ACTHM`='" & tb_1acthm.Text & "',`M2ACTHM`='" & tb_2acthm.Text & "',`M3ACTHM`='" & tb_3acthm.Text & "',`M4ACTHM`='" & tb_4acthm.Text & "',`M1SRTSTRS`='" & tb_1nptm.Text & "',`M2SRTSTRS`='" & tb_2nptm.Text & "',`M3SRTSTRS`='" & tb_3nptm.Text & "',`M4SRTSTRS`='" & tb_4nptm.Text & "',`M1PLI`='" & tb_1npp.Text & "',`M2PLI`='" & tb_2npp.Text & "',`M3PLI`='" & tb_3npp.Text & "',`M4PLI`='" & tb_4npp.Text & "',`M1TELBILL`='" & tb_1ntbcm.Text & "',`M2TELBILL`='" & tb_2ntbcm.Text & "',`M3TELBILL`='" & tb_3ntbcm.Text & "',`M4TELBILL`='" & tb_4ntbcm.Text & "',`M1OLDMO`='" & tb_1noapdtmo.Text & "',`M2OLDMO`='" & tb_2noapdtmo.Text & "',`M3OLDMO`='" & tb_3noapdtmo.Text & "',`M4OLDMO`='" & tb_4noapdtmo.Text & "',`M1OLDBANK`='" & tb_1noapdtba.Text & "',`M2OLDBANK`='" & tb_2noapdtba.Text & "',`M3OLDBANK`='" & tb_3noapdtba.Text & "',`M4OLDBANK`='" & tb_4noapdtba.Text & "',`ACCWORK`='" & rs_7awrdd.Text & "',`M1MOI`='" & dialouge1.tb_1mri.Text & "',`M2MOI`='" & dialouge1.tb_2mri.Text & "',`M3MOI` = '" & dialouge1.tb_3mri.Text & "',`M4MOI`='" & dialouge1.tb_4mri.Text & "',`M1RPLICOL`='" & dialouge1.tb_1rc.Text & "',`M2RPLICOL`='" & dialouge1.tb_2rc.Text & "',`M3RPLICOL`='" & dialouge1.tb_3rc.Text & "',`M4RPLICOL`='" & dialouge1.tb_4rc.Text & "',`M1SBDEP`='" & dialouge1.tb_1sbd.Text & "',`M2SBDEP`='" & dialouge1.tb_2sbd.Text & "',`M3SBDEP`='" & dialouge1.tb_3sbd.Text & "',`M4SBDEP`='" & dialouge1.tb_4sbd.Text & "',`M1RDDEP`='" & dialouge1.tb_1rdw.Text & "',`M2RDDEP`='" & dialouge1.tb_2rdw.Text & "',`M3RDDEP`='" & dialouge1.tb_3rdw.Text & "',`M4RDDEP`='" & dialouge1.tb_4rdw.Text & "',`M1TDDEP`='" & dialouge1.tb_1tdw.Text & "',`M2TDDEP`='" & dialouge1.tb_2tdw.Text & "',`M3TDDEP`='" & dialouge1.tb_3tdw.Text & "',`M4TDDEP`='" & dialouge1.tb_4tdw.Text & "',`M1SSA`='" & dialouge1.tb_1sdw.Text & "',`M2SSA`='" & dialouge1.tb_2sdw.Text & "',`M3SSA`='" & dialouge1.tb_3sdw.Text & "',`M4SSA`='" & dialouge1.tb_4sdw.Text & "',`M1MOP`='" & dialouge1.tb_1mop.Text & "',`M2MOP`='" & dialouge1.tb_2mop.Text & "',`M3MOP`='" & dialouge1.tb_3mop.Text & "',`M4MOP`='" & dialouge1.tb_4mop.Text & "' WHERE `WOKLOD`.`ID`='" & tb_nb.Text + ComboBoxEdit1.Text + tb_dog.Text & "'" '82 update

            cmd = New OleDbCommand(cb)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Data Update Successful", "Updated : " & x, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Unable to Update !")
        End Try
        waitclose()
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        waitopen()
        workloadlist.MdiParent = mainforfm
        workloadlist.WindowState = FormWindowState.Maximized
        workloadlist.Show()
        waitclose()
    End Sub

    Private Sub SimpleButton9_Click(sender As Object, e As EventArgs) Handles SimpleButton9.Click
        update_data_workload(" ")
    End Sub

    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click
        Try
            xlApp = New excel.Application
            xlWorkBook = xlApp.Workbooks.Open(System.Windows.Forms.Application.StartupPath + "/Data/Workload.xlsx")           ' WORKBOOK TO OPEN THE EXCEL FILE.
            xlWorkSheet = xlWorkBook.Worksheets("Sheet1")
            Try
                xlWorkSheet.Range("A1").Value = "Workload Calculation Sheet for GDSBPM  " & tb_nb.Text & " BO i.a.w  SO " & tb_ns.Text & " SO"
                xlWorkSheet.Range("B14").Value = "Year - " & ComboBoxEdit1.Text
                xlWorkSheet.Range("A2").Value = "Date - " & TextEdit1.Text


                xlWorkSheet.Range("C3").Value = tb_nb.Text
                xlWorkSheet.Range("C4").Value = tb_ns.Text
                xlWorkSheet.Range("C5").Value = tb_nh.Text
                xlWorkSheet.Range("C8").Value = tb_dog.Text
                xlWorkSheet.Range("C6").Value = tb_hb.Text
                xlWorkSheet.Range("C7").Value = tb_twh.Text
                xlWorkSheet.Range("C9").Value = tb_pyl.Text

                xlWorkSheet.Range("C14").Value = "0" & tb_1fm.Text
                xlWorkSheet.Range("D14").Value = "0" & tb_2fm.Text
                xlWorkSheet.Range("E14").Value = "0" & tb_3fm.Text
                xlWorkSheet.Range("F14").Value = "0" & tb_4fm.Text

                xlWorkSheet.Range("C15").Value = "0" & tb_1nuahd.Text
                xlWorkSheet.Range("D15").Value = "0" & tb_2nuahd.Text
                xlWorkSheet.Range("E15").Value = "0" & tb_3nuahd.Text
                xlWorkSheet.Range("F15").Value = "0" & tb_4nuahd.Text

                xlWorkSheet.Range("C16").Value = "0" & tb_1nrahm.Text
                xlWorkSheet.Range("D16").Value = "0" & tb_2nrahm.Text
                xlWorkSheet.Range("E16").Value = "0" & tb_3nrahm.Text
                xlWorkSheet.Range("F16").Value = "0" & tb_4nrahm.Text

                xlWorkSheet.Range("C17").Value = "0" & tb_1nmhm.Text
                xlWorkSheet.Range("D17").Value = "0" & tb_2nmhm.Text
                xlWorkSheet.Range("E17").Value = "0" & tb_3nmhm.Text
                xlWorkSheet.Range("F17").Value = "0" & tb_4nmhm.Text

                xlWorkSheet.Range("C18").Value = "0" & tb_1ssm.Text
                xlWorkSheet.Range("D18").Value = "0" & tb_2ssm.Text
                xlWorkSheet.Range("E18").Value = "0" & tb_3ssm.Text
                xlWorkSheet.Range("F18").Value = "0" & tb_4ssm.Text

                xlWorkSheet.Range("C19").Value = "0" & tb_1acthm.Text
                xlWorkSheet.Range("D19").Value = "0" & tb_2acthm.Text
                xlWorkSheet.Range("E19").Value = "0" & tb_3acthm.Text
                xlWorkSheet.Range("F19").Value = "0" & tb_4acthm.Text

                xlWorkSheet.Range("C20").Value = "0" & tb_1nptm.Text
                xlWorkSheet.Range("D20").Value = "0" & tb_2nptm.Text
                xlWorkSheet.Range("E20").Value = "0" & tb_3nptm.Text
                xlWorkSheet.Range("F20").Value = "0" & tb_4nptm.Text

                xlWorkSheet.Range("C21").Value = "0" & tb_1npp.Text
                xlWorkSheet.Range("D21").Value = "0" & tb_2npp.Text
                xlWorkSheet.Range("E21").Value = "0" & tb_3npp.Text
                xlWorkSheet.Range("F21").Value = "0" & tb_4npp.Text

                xlWorkSheet.Range("C22").Value = "0" & tb_1ntbcm.Text
                xlWorkSheet.Range("D22").Value = "0" & tb_2ntbcm.Text
                xlWorkSheet.Range("E22").Value = "0" & tb_3ntbcm.Text
                xlWorkSheet.Range("F22").Value = "0" & tb_4ntbcm.Text

                xlWorkSheet.Range("C23").Value = "0" & tb_1noapdtmo.Text
                xlWorkSheet.Range("D23").Value = "0" & tb_2noapdtmo.Text
                xlWorkSheet.Range("E23").Value = "0" & tb_3noapdtmo.Text
                xlWorkSheet.Range("F23").Value = "0" & tb_4noapdtmo.Text

                xlWorkSheet.Range("C24").Value = "0" & tb_1noapdtba.Text
                xlWorkSheet.Range("D24").Value = "0" & tb_2noapdtba.Text
                xlWorkSheet.Range("E24").Value = "0" & tb_3noapdtba.Text
                xlWorkSheet.Range("F24").Value = "0" & tb_4noapdtba.Text

                xlWorkSheet.Range("I25").Value = "0" & rs_7awrdd.Text

                xlWorkSheet.Range("C35").Value = "0" & dialouge1.tb_1mri.Text
                xlWorkSheet.Range("D35").Value = "0" & dialouge1.tb_2mri.Text
                xlWorkSheet.Range("E35").Value = "0" & dialouge1.tb_3mri.Text
                xlWorkSheet.Range("F35").Value = "0" & dialouge1.tb_4mri.Text

                xlWorkSheet.Range("C36").Value = "0" & dialouge1.tb_1rc.Text
                xlWorkSheet.Range("D36").Value = "0" & dialouge1.tb_2rc.Text
                xlWorkSheet.Range("E36").Value = "0" & dialouge1.tb_3rc.Text
                xlWorkSheet.Range("F36").Value = "0" & dialouge1.tb_4rc.Text

                xlWorkSheet.Range("C37").Value = "0" & dialouge1.tb_1sbd.Text
                xlWorkSheet.Range("D37").Value = "0" & dialouge1.tb_2sbd.Text
                xlWorkSheet.Range("E37").Value = "0" & dialouge1.tb_3sbd.Text
                xlWorkSheet.Range("F37").Value = "0" & dialouge1.tb_4sbd.Text

                xlWorkSheet.Range("C38").Value = "0" & dialouge1.tb_1rdw.Text
                xlWorkSheet.Range("D38").Value = "0" & dialouge1.tb_2rdw.Text
                xlWorkSheet.Range("E38").Value = "0" & dialouge1.tb_3rdw.Text
                xlWorkSheet.Range("F38").Value = "0" & dialouge1.tb_4rdw.Text

                xlWorkSheet.Range("C39").Value = "0" & dialouge1.tb_1tdw.Text
                xlWorkSheet.Range("D39").Value = "0" & dialouge1.tb_2tdw.Text
                xlWorkSheet.Range("E39").Value = "0" & dialouge1.tb_3tdw.Text
                xlWorkSheet.Range("F39").Value = "0" & dialouge1.tb_4tdw.Text

                xlWorkSheet.Range("C40").Value = "0" & dialouge1.tb_1sdw.Text
                xlWorkSheet.Range("D40").Value = "0" & dialouge1.tb_2sdw.Text
                xlWorkSheet.Range("E40").Value = "0" & dialouge1.tb_3sdw.Text
                xlWorkSheet.Range("F40").Value = "0" & dialouge1.tb_4sdw.Text

                xlWorkSheet.Range("C41").Value = "0" & dialouge1.tb_1mop.Text
                xlWorkSheet.Range("D41").Value = "0" & dialouge1.tb_2mop.Text
                xlWorkSheet.Range("E41").Value = "0" & dialouge1.tb_3mop.Text
                xlWorkSheet.Range("F41").Value = "0" & dialouge1.tb_4mop.Text

                xlApp.DisplayAlerts = False
                xlWorkBook.SaveAs(System.Windows.Forms.Application.StartupPath + "\Files\workload\" & tb_nb.Text + ComboBoxEdit1.Text & ".xlsx", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, True, False, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing)
                '   xlWorkBook.SaveAs(Application.StartupPath + "\Files\" & tb_boname.Text + TextEdit1.Text & ".xlsx")
                xlWorkBook.Close(True)
                MsgBox("Successfully Save Data At Files\" & tb_nb.Text + ComboBoxEdit1.Text & ".xlsx")
            Catch ex As Exception
                MsgBox("Error In Data Save" & ex.Message)
                quit()
            End Try
        Catch ex As Exception
            MsgBox("woorkload (ice.xlsx) excel File Not Fount")
            quit()

        End Try

    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        waitopen()
        '  workloadlist.Show()
        Dim X, Y, Z As String

        workloadlist.getfilt1("SELECT * from WOKLOD where ID like '%" & tb_nb.Text + ComboBoxEdit1.Text + tb_dog.Text & "%' order by ID")
        X = tb_nb.Text
        Y = ComboBoxEdit1.Text
        Z = tb_dog.Text

        workloadlist.takedata(1)
        If tb_nb.Text = Nothing Then
            tb_nb.Text = X
            tb_dog.Text = Z
            ComboBoxEdit1.Text = Y
            MsgBox("No Data Found ...")
        End If
        waitclose()

    End Sub
End Class