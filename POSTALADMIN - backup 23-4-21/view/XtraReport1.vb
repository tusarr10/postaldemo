Public Class print_work

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Public Sub getinfodata(ByVal get_year As String, ByVal get_dt As String, ByVal get_boname As String, ByVal get_soname As String, ByVal get_honame As String) ' Enter Information
        lb_year.Text = get_year ' Enter Year
        lb_dt.Text = get_dt 'Enter Date
        lb_boname.Text = get_boname ' Enter BoName
        lb_honame.Text = get_honame ' Enter Ho name
        lb_soname.Text = get_soname ' Enter So Name
    End Sub
    Public Sub get_incomedata(ByVal inc As String, ByVal _25pss As String, ByVal rs25pss As String, ByVal _720psi As String, ByVal rs720psi As String, ByVal _34upd As String, ByVal rs34upd As String, ByVal _18upd As String, ByVal rs18upd As String, ByVal _24moi As String, ByVal rs24moi As String, ByVal _35mop As String, ByVal rs35mop As String, ByVal _25ipos As String, ByVal rs25ipos As String, ByVal _25ipop As String, ByVal rs25ipop As String, ByVal _637iposb As String, ByVal rs6374iposb As String, ByVal _967sa As String, ByVal rs967sa As String, ByVal _2185sc As String, ByVal rs2185sc As String, ByVal _2488mgn As String, ByVal rs2488mgn As String, ByVal rstotal As String, ByVal tmont As String, ByVal rstmont As String, ByVal rstai As String) 'Get Income Data
        lb_income.Text = inc
        lb_25pss.Text = _25pss ' Enter 2/5 post stamp
        lb_rs_25pss.Text = rs25pss ' Enter value 2/5 post stamp
        lb_720psi.Text = _720psi ' 7/20 post 
        lb_rs_720psi.Text = rs720psi
        lb_34upd.Text = _34upd  ' unpaid art
        lb_rs_34upd.Text = rs34upd
        lb_18upd.Text = _18upd  ' 18 upd
        lb_rs_18upd.Text = rs18upd
        lb_24moi.Text = _24moi ' 2/4 moi
        lb_rs_24moi.Text = rs24moi
        lb_35mop.Text = _35mop '3/5 mop
        lb_rs_35mop.Text = rs35mop
        lb_25ipos.Text = _25ipos '2/5 ipos
        lb_rs_ipos.Text = rs25ipos
        lb_rs_ipop.Text = rs25ipop '2/5 ipop
        lb_25ipop.Text = _25ipop
        lb_6374iposb.Text = _637iposb '63.7 iposb
        lb_rs_63741posb.Text = rs6374iposb
        lb_967sa.Text = _967sa ' 9.67 iposb
        lb_rs_967sa.Text = rs967sa
        lb_2185sc.Text = _2185sc
        lb_rs_2185sc.Text = rs2185sc
        lb_2488mgn.Text = _2488mgn ' mangera
        lb_rs_2488mgn.Text = rs2488mgn
        lb_rs_total.Text = rstotal ' total
        lb_tmont.Text = tmont ' total percent
        lb_rs_tmont.Text = rstmont ' total
        ' lb_tai.Text = tai ' total anual optional
        lb_rs_tai.Text = rstai ' total anual 


    End Sub

    Public Sub getexpddata(ByVal rsbpm As String, ByVal rsmd As String, ByVal rsmc As String, ByVal rsfa As String, ByVal rs5ps As String, ByVal rsioc As String, ByVal rstmc As String, ByVal rsaca As String, ByVal rsplb As String, ByVal rstac As String)
        lb_rsbpm.Text = rsbpm
        lb_rsmd.Text = rsmd
        lb_rsmc.Text = rsmc
        lb_rsfa.Text = rsfa
        lb_rs5ps.Text = rs5ps
        lb_rsioc.Text = rsioc
        lb_rstmc.Text = rstmc
        lb_rsac.Text = rsaca
        lb_rsplb.Text = rsplb
        lb_rstac.Text = rstac

    End Sub
    Public Sub getrptdata(ByVal rsgai As String, ByVal rsgac As String, ByVal rsal As String, ByVal rsgic As String)
        lb_rsgai.Text = rsgai
        lb_rs_gac.Text = rsgac
        lb_rsal.Text = rsal
        lb_rsgic.Text = rsgic

    End Sub

    Private Sub print_work_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Me.BeforePrint
        Print_date.Text = DateAndTime.Now

    End Sub
End Class