Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Data.OleDb
Imports Microsoft.Office.Interop.Excel

Public Class expd_usr
    'FOR EXCEL COMMNAD
    Dim xlApp As Excel.Application
    Dim xlWorkBook As Excel.Workbook
    Dim xlWorkSheet As Excel.Worksheet

    'FOR ACCESS DATABASE
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As System.Data.DataTable
    Dim con As System.Data.OleDb.OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New System.Data.DataTable


    Dim cs As String = mainforfm.css
    Private Sub expd_usr_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        reset_txt()
        'MsgBox("under development") 'Call reset_txt
    End Sub


    Sub reset_txt() ' Clear all Text Box
        '*********** For clear result **************
        rs_gic.Text = 0
        rs_gac.Text = 0
        rs_gal.Text = 0
        rs_gic.Text = 0
        rs_gai.Text = 0
        '******************Clear Cost Text box ************************
        rs_bpm.Text = 0 : tb_bpm.Text = 0
        rs_md.Text = 0 : tb_md.Text = 0
        rs_mc.Text = 0 : tb_mc.Text = 0
        rs_fa.Text = 0 : tb_fa.Text = 0
        tb_ioc.Text = 0 : rs_ioc.Text = 0
        tb_5ps.Text = 0 : rs_5ps.Text = 0
        tb_plb.Text = 0 : rs_plb.Text = 0
        rs_tmc.Text = 0 : rs_ac.Text = 0
        rs_tac.Text = 0

        '******************************Clear total income **************
        rs_total.Text = 0
        rs_tmont.Text = 0
        rs_tai.Text = 0
        '***********************Clear Income ************************
        tb_25pss.Text = 0 : rs_720pss.Text = 0
        tb_720pss.Text = 0 : rs_720pss.Text = 0
        tb_34upd.Text = 0 : rs_34upd.Text = 0
        tb_18upp.Text = 0 : rs_18upp.Text = 0
        tb_24moi.Text = 0 : rs_24moi.Text = 0
        tb_35mop.Text = 0 : rs_35mop.Text = 0
        tb_25ipos.Text = 0 : rs_25ipos.Text = 0
        tb_25ipop.Text = 0 : rs_25ipop.Text = 0
        tb_6374lposb.Text = 0 : rs_6374lposb.Text = 0
        tb_967sa.Text = 0 : rs_967sa.Text = 0
        tb_2185sc.Text = 0 : rs_2185sc.Text = 0
        tb_2488mgn.Text = 0 : rs_2488mgn.Text = 0

        '****************clear Info ********************
        TextEdit1.Text = ""
        TextEdit2.Text = ""
        tb_boname.Text = ""
        tb_soname.Text = ""
        tb_honame.Text = ""
        cb_income.Text = ""


    End Sub

    Private Sub tb_25pss_EditValueChanged(sender As Object, e As EventArgs) Handles tb_25pss.EditValueChanged
        Dim x As Double
        Try
            x = "0" + tb_25pss.Text
            rs_25pss.Text = x * 2 / 5
        Catch ex As Exception
            MsgBox(ex.Message)
            tb_25pss.Text = 0
            rs_25pss.Text = 0
        End Try


    End Sub

    Private Sub tb_720pss_EditValueChanged(sender As Object, e As EventArgs) Handles tb_720pss.EditValueChanged
        Dim x As Double
        Try
            x = "0" + tb_720pss.Text
            rs_720pss.Text = x * 7 / 20

        Catch ex As Exception
            MsgBox(ex.Message)
            tb_720pss.Text = 0
            rs_720pss.Text = 0
        End Try
    End Sub

    Private Sub tb_25ipop_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tb_tmont.KeyPress, tb_plb.KeyPress, tb_md.KeyPress, tb_mc.KeyPress, tb_ioc.KeyPress, tb_fa.KeyPress, tb_bpm.KeyPress, tb_967sa.KeyPress, tb_720pss.KeyPress, tb_6374lposb.KeyPress, tb_5ps.KeyPress, tb_35mop.KeyPress, tb_34upd.KeyPress, tb_25pss.KeyPress, tb_25ipos.KeyPress, tb_25ipop.KeyPress, tb_24moi.KeyPress, tb_2488mgn.KeyPress, tb_2185sc.KeyPress, tb_18upp.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) AndAlso Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub
    Dim a, b, c, d, f, g, h, i, j, k, l, m, n, o As Double
    Sub count()
        Try
            a = "0" + rs_25pss.Text : b = "0" + rs_720pss.Text : c = "0" + rs_34upd.Text : d = "0" + rs_18upp.Text : f = "0" + rs_24moi.Text : g = "0" + rs_35mop.Text : h = "0" + rs_25ipos.Text
            i = "0" + rs_25ipop.Text
            j = "0" + rs_6374lposb.Text
            k = "0" + rs_967sa.Text
            l = "0" + rs_2185sc.Text
            m = "0" + rs_2488mgn.Text
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub btn_cal_Click(sender As Object, e As EventArgs) Handles btn_cal.Click
        Try
            count()


            Dim x, z, t As Double
            x = a + b + c + d + f + g + h + i + j + k + l + m
            rs_total.Text = x
            Dim y As Double = x * 1.01
            rs_tmont.Text = y
            rs_tai.Text = y * 12

            count2()
            Dim za As Double = op + p + q + r + s + tp
            rs_tmc.Text = za
            rs_ac.Text = za * 12

            z = "0" + rs_ac.Text
            t = "0" + rs_plb.Text
            rs_tac.Text = z + t


            rs_gai.Text = "0" + rs_tai.Text
            rs_gac.Text = "0" + rs_tac.Text
            Dim fn, sn As Double
            fn = "0" + rs_gai.Text
            sn = "0" + rs_gac.Text
            Dim rs As Double
            rs = sn - fn
            rs_gal.Text = rs
            rs_gic.Text = fn / sn * 100

            btn_save.Enabled = True
            btn_updae.Enabled = True
            btn_print.Enabled = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub tb_tmont_EditValueChanged(sender As Object, e As EventArgs) Handles tb_tmont.EditValueChanged

        Try
            count()

            Dim x As Double
            x = a + b + c + d + f + g + h + i + j + k + l + m
            rs_total.Text = x
            rs_tmont.Text = x * 1.01

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub tb_34upd_EditValueChanged(sender As Object, e As EventArgs) Handles tb_34upd.EditValueChanged
        Dim x As Double
        Try
            x = "0" + tb_34upd.Text
            rs_34upd.Text = x * 3 / 4

        Catch ex As Exception
            MsgBox(ex.Message)
            tb_34upd.Text = 0
            rs_34upd.Text = 0

        End Try
    End Sub

    Private Sub tb_18upp_EditValueChanged(sender As Object, e As EventArgs) Handles tb_18upp.EditValueChanged
        Dim x As Double
        Try
            x = "0" + tb_18upp.Text
            rs_18upp.Text = x * 1 / 8

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_show_Click(sender As Object, e As EventArgs) Handles btn_show.Click
        waitopen()
        expdlist.MdiParent = mainforfm
        expdlist.WindowState = FormWindowState.Maximized
        expdlist.Show()
        waitclose()

    End Sub

    Private Sub tb_24moi_EditValueChanged(sender As Object, e As EventArgs) Handles tb_24moi.EditValueChanged
        Dim x As Double
        Try
            x = "0" + tb_24moi.Text
            rs_24moi.Text = x * 24 / 100

        Catch ex As Exception

        End Try
    End Sub

    Private Sub tb_35mop_EditValueChanged(sender As Object, e As EventArgs) Handles tb_35mop.EditValueChanged
        Dim x As Double
        Try
            x = "0" + tb_35mop.Text
            rs_35mop.Text = x * 35 / 100

        Catch ex As Exception

        End Try
    End Sub

    Private Sub tb_25ipos_EditValueChanged(sender As Object, e As EventArgs) Handles tb_25ipos.EditValueChanged
        Dim x As Double
        Try
            x = "0" + tb_25ipos.Text
            rs_25ipos.Text = x * 2 / 5

        Catch ex As Exception

        End Try

    End Sub

    Private Sub tb_25ipop_EditValueChanged(sender As Object, e As EventArgs) Handles tb_25ipop.EditValueChanged
        Dim x As Double
        Try
            x = "0" + tb_25ipop.Text
            rs_25ipop.Text = x * 2 / 5

        Catch ex As Exception

        End Try
    End Sub

    Private Sub tb_6374lposb_EditValueChanged(sender As Object, e As EventArgs) Handles tb_6374lposb.EditValueChanged
        Dim c As Double
        Try
            c = "0" + tb_6374lposb.Text
            rs_6374lposb.Text = c * 63.74 / 12

        Catch ex As Exception

        End Try
    End Sub

    Private Sub tb_967sa_EditValueChanged(sender As Object, e As EventArgs) Handles tb_967sa.EditValueChanged
        Dim x As Double
        Try
            x = "0" + tb_967sa.Text
            rs_967sa.Text = x * 9.67 / 12

        Catch ex As Exception

        End Try
    End Sub

    Private Sub tb_2185sc_EditValueChanged(sender As Object, e As EventArgs) Handles tb_2185sc.EditValueChanged
        Dim x As Double
        Try
            x = "0" + tb_2185sc.Text
            rs_2185sc.Text = x * 21.85 / 12

        Catch ex As Exception

        End Try
    End Sub

    Private Sub tb_2488mgn_EditValueChanged(sender As Object, e As EventArgs) Handles tb_2488mgn.EditValueChanged
        Dim x As Double
        Try
            x = "0" + tb_2488mgn.Text
            rs_2488mgn.Text = x * 24.88 / 12

        Catch ex As Exception

        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Try
            count()

            Dim x As Double
            x = a + b + c + d + f + g + h + i + j + k + l + m
            rs_total.Text = x
            Dim y As Double = x * 1.01
            rs_tmont.Text = y
            rs_tai.Text = y * 12


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub tb_bpm_EditValueChanged(sender As Object, e As EventArgs) Handles tb_bpm.EditValueChanged
        rs_bpm.Text = "0" + tb_bpm.Text

    End Sub

    Private Sub tb_md_EditValueChanged(sender As Object, e As EventArgs) Handles tb_md.EditValueChanged
        rs_md.Text = "0" + tb_md.Text

    End Sub

    Private Sub tb_mc_EditValueChanged(sender As Object, e As EventArgs) Handles tb_mc.EditValueChanged
        rs_mc.Text = "0" + tb_mc.Text

    End Sub

    Private Sub tb_fa_EditValueChanged(sender As Object, e As EventArgs) Handles tb_fa.EditValueChanged
        rs_fa.Text = "0" + tb_fa.Text

    End Sub

    Private Sub tb_ioc_EditValueChanged(sender As Object, e As EventArgs) Handles tb_ioc.EditValueChanged
        rs_ioc.Text = "0" + tb_ioc.Text

    End Sub
    Dim op, p, q, r, s, tp, u As Double
    Sub count2()
        Try
            op = "0" + rs_bpm.Text
            p = "0" + rs_md.Text
            q = "0" + rs_mc.Text
            r = "0" + rs_fa.Text
            s = "0" + rs_ioc.Text
            tp = "0" + rs_5ps.Text


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub tb_5ps_EditValueChanged(sender As Object, e As EventArgs) Handles tb_5ps.EditValueChanged
        Dim x As Double
        Try
            x = "0" + tb_5ps.Text
            rs_5ps.Text = x * 1.05

            count2()

            Dim y As Double = op + p + q + r + s + tp
            rs_tmc.Text = y
            rs_ac.Text = y * 12


        Catch ex As Exception

        End Try
    End Sub

    Private Sub tb_plb_EditValueChanged(sender As Object, e As EventArgs) Handles tb_plb.EditValueChanged
        rs_plb.Text = "0" + tb_plb.Text
        Dim x, y As Double
        Try
            x = "0" + rs_ac.Text
            y = "0" + rs_plb.Text
            rs_tac.Text = x + y
            count2()

            Dim yx As Double = op + p + q + r + s + tp
            rs_tmc.Text = yx
            rs_ac.Text = yx * 12

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        Using frm As printmain = New printmain
            frm.print_workload(cb_income.Text, tb_25pss.Text, rs_25pss.Text, tb_720pss.Text, rs_720pss.Text, tb_34upd.Text, rs_34upd.Text, tb_18upp.Text, rs_18upp.Text, tb_24moi.Text, rs_24moi.Text, tb_35mop.Text, rs_35mop.Text, tb_25ipos.Text, rs_25ipos.Text, tb_25ipop.Text, rs_25ipop.Text, tb_6374lposb.Text, rs_6374lposb.Text, tb_967sa.Text, rs_967sa.Text, tb_2185sc.Text, rs_2185sc.Text, tb_2488mgn.Text, rs_2488mgn.Text, rs_total.Text, tb_tmont.Text, rs_tmont.Text, rs_tai.Text)
            frm.ShowDialog()

        End Using
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            con = New System.Data.OleDb.OleDbConnection(cs)
            con.Open()
            '  Dim cb1 As String = "insert into IAE() VALUES('" & txtStudentID.Text & "','" & txtStudentName.Text & "','" & Acbal.Text & "','" & DateAndTime.Today & "','" & DateAndTime.Today & "','" & cmbDepartment.Text & "')"
            Dim cb As String = "INSERT INTO `iae` (`ID`, `d_ate`, `y_ear`, `type`, `N_BO`, `N_SO`, `N_HO`, `PSS_25`, `PSS_720`, `UPD_34`, `UPD_18`, `MOCISU_24`, `MOCPAID_35`, `IPOSOLD_25`, `IPOPAID_25`, `LIVEAC_6374`, `SILANTAC_967`, `SSCSBTRNS_2185`, `MGNREG_2488`, `GDSBPM_PAY`, `GDSMD_PAY`, `GDSMC_PAY`, `FIXADD`, `PSOLD5`, `IOC`, `PLB`) VALUES ('" & TextEdit1.Text + tb_boname.Text & "','" & TextEdit2.Text & "', '" & TextEdit1.Text & "', '" & cb_income.Text & "', '" & tb_boname.Text & "', '" & tb_soname.Text & "', '" & tb_honame.Text & "', '" & tb_25pss.Text & "', '" & tb_720pss.Text & "', '" & tb_34upd.Text & "', '" & tb_18upp.Text & "', '" & tb_24moi.Text & "', '" & tb_35mop.Text & "', '" & tb_25ipos.Text & "', '" & tb_25ipop.Text & "', '" & tb_6374lposb.Text & "', '" & tb_967sa.Text & "', '" & tb_2185sc.Text & "', '" & tb_2488mgn.Text & "', '" & tb_bpm.Text & "', '" & tb_md.Text & "', '" & tb_mc.Text & "', '" & tb_fa.Text & "', '" & rs_5ps.Text & "', '" & tb_ioc.Text & "', '" & tb_plb.Text & "')"
            cmd = New OleDbCommand(cb)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Successfully saved", "  Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_updae_Click(sender As Object, e As EventArgs) Handles btn_updae.Click
        ' MsgBox("under dev")
        Dim CMD1 As String = "UPDATE `IAE` SET `d_ate` = '" & TextEdit2.Text & "', `y_ear` = '" & TextEdit1.Text & "', `type` = '" & cb_income.Text & "', `N_BO` = '" & tb_boname.Text & "', `N_SO` = '" & tb_soname.Text & "', `N_HO` = '" & tb_honame.Text & "', `PSS_25` = '" & tb_25pss.Text & "', `PSS_720` = '" & tb_720pss.Text & "', `UPD_34` = '" & tb_18upp.Text & "', `UPD_18` = '" & tb_18upp.Text & "', `MOCISU_24` = '" & tb_24moi.Text & "', `MOCPAID_35` = '" & tb_35mop.Text & "', `IPOSOLD_25` = '" & tb_25ipos.Text & "', `IPOPAID_25` = '" & tb_25ipop.Text & "', `LIVEAC_6374` = '" & tb_6374lposb.Text & "', `SILANTAC_967` = '" & tb_967sa.Text & "', `SSCSBTRNS_2185` = '" & tb_2185sc.Text & "', `MGNREG_2488` = '" & tb_2488mgn.Text & "', `GDSBPM_PAY` = '" & rs_bpm.Text & "', `GDSMD_PAY` = '" & rs_md.Text & "', `GDSMC_PAY` = '" & rs_mc.Text & "', `FIXADD` = '" & rs_fa.Text & "', `PSOLD5` = '" & rs_5ps.Text & "', `IOC` = '" & rs_ioc.Text & "', `PLB` = '" & rs_plb.Text & "' WHERE `IAE`.`ID` = '2021t'"

        Try
            con = New System.Data.OleDb.OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand(CMD1)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Successfully Updated", "  Record", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Try
            xlApp = New Excel.Application
            xlWorkBook = xlApp.Workbooks.Open(System.Windows.Forms.Application.StartupPath + "/Data/ice.xlsx")           ' WORKBOOK TO OPEN THE EXCEL FILE.
            xlWorkSheet = xlWorkBook.Worksheets("Sheet1")
            Try
                xlWorkSheet.Range("A1").Value = "Income and Expenditure Calculation Sheet of " & tb_boname.Text & " BO i.a.w " & tb_soname.Text & " SO"
                xlWorkSheet.Range("A2").Value = "Year - " & TextEdit1.Text
                xlWorkSheet.Range("D2").Value = "Date - " & TextEdit2.Text
                xlWorkSheet.Range("A3").Value = "Income (" & cb_income.Text & " )"

                xlWorkSheet.Range("C6").Value = "0" & tb_25pss.Text
                xlWorkSheet.Range("C7").Value = "0" & tb_720pss.Text
                xlWorkSheet.Range("C8").Value = "0" & tb_34upd.Text
                xlWorkSheet.Range("C9").Value = "0" & tb_18upp.Text
                xlWorkSheet.Range("C10").Value = "0" & tb_24moi.Text
                xlWorkSheet.Range("C11").Value = "0" & tb_35mop.Text
                xlWorkSheet.Range("C12").Value = "0" & tb_25ipos.Text
                xlWorkSheet.Range("C13").Value = "0" & tb_25ipop.Text
                xlWorkSheet.Range("C14").Value = "0" & tb_6374lposb.Text
                xlWorkSheet.Range("C15").Value = "0" & tb_967sa.Text
                xlWorkSheet.Range("C16").Value = "0" & tb_2185sc.Text
                xlWorkSheet.Range("C17").Value = "0" & tb_2488mgn.Text

                xlWorkSheet.Range("C25").Value = "0" & tb_bpm.Text
                xlWorkSheet.Range("C26").Value = "0" & tb_md.Text
                xlWorkSheet.Range("C27").Value = "0" & tb_mc.Text
                xlWorkSheet.Range("C28").Value = "0" & tb_fa.Text
                xlWorkSheet.Range("C30").Value = "0" & tb_ioc.Text
                xlWorkSheet.Range("C29").Value = "0" & rs_5ps.Text
                xlWorkSheet.Range("C33").Value = "0" & tb_plb.Text

                xlApp.DisplayAlerts = False
                xlWorkBook.SaveAs(System.Windows.Forms.Application.StartupPath + "\Files\income\" & tb_boname.Text + TextEdit1.Text & ".xlsx", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, True, False, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing)
                '   xlWorkBook.SaveAs(Application.StartupPath + "\Files\" & tb_boname.Text + TextEdit1.Text & ".xlsx")
                xlWorkBook.Close(True)
                MsgBox("Successfully Save Data At Files\" & tb_boname.Text + TextEdit1.Text & ".xlsx")
            Catch ex As Exception
                MsgBox("Error In Data Save" & ex.Message)
                quit()
            End Try
        Catch ex As Exception
            MsgBox("woorkload (ice.xlsx) excel File Not Fount")
            quit()

        End Try

    End Sub
   
End Class