Public Class printmain 

    Private Sub printmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ' Public Sub print_workload(ByVal get_year As String, ByVal get_dt As String, ByVal get_boname As String, ByVal get_soname As String, ByVal get_honame As String, ByVal _25pss As String, ByVal rs25pss As String, ByVal _720psi As String, ByVal rs720psi As String, ByVal _34upd As String, ByVal rs34upd As String, ByVal _18upd As String, ByVal rs18upd As String, ByVal _24moi As String, ByVal rs24moi As String, ByVal _35mop As String, ByVal rs35mop As String, ByVal _25ipos As String, ByVal rs25ipos As String, ByVal _25ipop As String, ByVal rs25ipop As String, ByVal _637iposb As String, ByVal rs6374iposb As String, ByVal _967sa As String, ByVal rs967sa As String, ByVal _2185sc As String, ByVal rs2185sc As String, ByVal _2488mgn As String, ByVal rs2488mgn As String, ByVal rstotal As String, ByVal tmont As String, ByVal rstmont As String, ByVal rstai As String, ByVal rsbpm As String, ByVal rsmd As String, ByVal rsmc As String, ByVal rsfa As String, ByVal rs5ps As String, ByVal rsioc As String, ByVal rstmc As String, ByVal rsaca As String, ByVal rsplb As String, ByVal rstac As String, ByVal rsgai As String, ByVal rsgac As String, ByVal rsal As String, ByVal rsgic As String)
    Public Sub print_workload(ByVal inc As String, ByVal _25pss As String, ByVal rs25pss As String, ByVal _720psi As String, ByVal rs720psi As String, ByVal _34upd As String, ByVal rs34upd As String, ByVal _18upd As String, ByVal rs18upd As String, ByVal _24moi As String, ByVal rs24moi As String, ByVal _35mop As String, ByVal rs35mop As String, ByVal _25ipos As String, ByVal rs25ipos As String, ByVal _25ipop As String, ByVal rs25ipop As String, ByVal _637iposb As String, ByVal rs6374iposb As String, ByVal _967sa As String, ByVal rs967sa As String, ByVal _2185sc As String, ByVal rs2185sc As String, ByVal _2488mgn As String, ByVal rs2488mgn As String, ByVal rstotal As String, ByVal tmont As String, ByVal rstmont As String, ByVal rstai As String)
        waitopen()
        Dim report As print_work = New print_work()
        report.get_incomedata(inc, _25pss, rs25pss, _720psi, rs720psi, _34upd, rs34upd, _18upd, rs18upd, _24moi, rs24moi, _35mop, rs35mop, _25ipos, rs25ipos, _25ipop, rs25ipop, _637iposb, rs6374iposb, _967sa, rs967sa, _2185sc, rs2185sc, _2488mgn, rs2488mgn, rstotal, tmont, rstai, rstai)
        report.getinfodata(expd_usr.TextEdit1.Text, expd_usr.TextEdit2.Text, expd_usr.tb_boname.Text, expd_usr.tb_soname.Text, expd_usr.tb_honame.Text)
        report.getrptdata(expd_usr.rs_gai.Text, expd_usr.rs_gac.Text, expd_usr.rs_gal.Text, expd_usr.rs_gic.Text)
        report.getexpddata(expd_usr.rs_bpm.Text, expd_usr.rs_md.Text, expd_usr.rs_mc.Text, expd_usr.rs_fa.Text, expd_usr.rs_5ps.Text, expd_usr.rs_ioc.Text, expd_usr.rs_tmc.Text, expd_usr.rs_ac.Text, expd_usr.rs_plb.Text, expd_usr.rs_tac.Text)

        DocumentViewer1.DocumentSource = report
        report.CreateDocument() : waitclose()
    End Sub
End Class