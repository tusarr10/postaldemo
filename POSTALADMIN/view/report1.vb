Public Class report1

    
    Private Sub report1_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Me.BeforePrint

    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Public Sub getinfo1()

        XrLabel2.Text = workload.TextEdit1.Text
        XrLabel3.Text = workload.ComboBoxEdit1.Text
        XrTableCell2.Text = workload.tb_nb.Text
        XrTableCell4.Text = workload.tb_ns.Text
        XrTableCell14.Text = workload.tb_nh.Text
        XrTableCell6.Text = workload.tb_hb.Text
        XrTableCell8.Text = workload.tb_twh.Text
        XrTableCell12.Text = workload.tb_dog.Text
        XrTableCell10.Text = workload.tb_pyl.Text

    End Sub
    Public Sub getinfo(ByVal d_ate As String, ByVal y_ear As String, ByVal boname As String, ByVal soname As String, ByVal ho As String, ByVal bh As String, ByVal tw As String, ByVal deg As String, ByVal plv As String) ' not in use

        XrLabel2.Text = d_ate
        XrLabel3.Text = y_ear
        XrTableCell2.Text = boname
        XrTableCell4.Text = soname
        XrTableCell14.Text = ho
        XrTableCell6.Text = bh
        XrTableCell8.Text = tw
        XrTableCell12.Text = deg
        XrTableCell10.Text = plv

    End Sub
    Public Sub wc(ByVal m1 As String, ByVal m2 As String, ByVal m3 As String, ByVal m4 As String, ByVal nuahdm1 As String, ByVal nuahdm2 As String, ByVal nuahdm3 As String, ByVal nuahdm4 As String, ByVal nuahdtotal As String, ByVal nuahdavg As String, ByVal nuahdpt As String)

    End Sub
    Public Sub wc1()
        XrTableCell25.Text = "YEAR : -" + workload.ComboBoxEdit1.Text + "AND MONTH : -"
        XrTableCell26.Text = workload.tb_1fm.Text
        XrTableCell27.Text = workload.tb_2fm.Text
        XrTableCell28.Text = workload.tb_3fm.Text
        XrTableCell29.Text = workload.tb_4fm.Text

        XrTableCell41.Text = workload.tb_1nuahd.Text
        XrTableCell42.Text = workload.tb_2nuahd.Text
        XrTableCell43.Text = workload.tb_3nuahd.Text
        XrTableCell44.Text = workload.tb_4nuahd.Text
        XrTableCell45.Text = workload.rs_5nuahd.Text
        XrTableCell46.Text = workload.rs_6nuahd.Text
        XrTableCell47.Text = workload.rs_7nuahd.Text

        XrTableCell21.Text = workload.tb_1nrahm.Text
        XrTableCell33.Text = workload.tb_2nrahm.Text
        XrTableCell34.Text = workload.tb_3nrahm.Text
        XrTableCell35.Text = workload.tb_4nrahm.Text
        XrTableCell36.Text = workload.rs_5nrahm.Text
        XrTableCell37.Text = workload.rs_6nrahm.Text
        XrTableCell38.Text = workload.rs_7nrahm.Text


        XrTableCell122.Text = workload.tb_1nmhm.Text
        XrTableCell123.Text = workload.tb_2nmhm.Text
        XrTableCell124.Text = workload.tb_3nmhm.Text
        XrTableCell125.Text = workload.tb_4nmhm.Text
        XrTableCell126.Text = workload.rs_5nmhm.Text
        XrTableCell127.Text = workload.rs_6nmhm.Text
        XrTableCell128.Text = workload.rs_7nmhm.Text


        XrTableCell59.Text = workload.tb_1ssm.Text
        XrTableCell60.Text = workload.tb_2ssm.Text
        XrTableCell61.Text = workload.tb_3ssm.Text
        XrTableCell62.Text = workload.tb_4ssm.Text
        XrTableCell63.Text = workload.rs_5ssm.Text
        XrTableCell64.Text = workload.rs_6ssm.Text
        XrTableCell65.Text = workload.rs_7ssm.Text

        XrTableCell95.Text = workload.tb_1acthm.Text
        XrTableCell96.Text = workload.tb_2acthm.Text : XrTableCell97.Text = workload.tb_3acthm.Text
        XrTableCell98.Text = workload.tb_4acthm.Text : XrTableCell99.Text = workload.rs_5acthm.Text
        XrTableCell100.Text = workload.rs_6acthm.Text : XrTableCell101.Text = workload.rs_7acthm.Text


        XrTableCell131.Text = workload.tb_1nptm.Text
        XrTableCell132.Text = workload.tb_2nptm.Text : XrTableCell133.Text = workload.tb_3nptm.Text
        XrTableCell134.Text = workload.tb_4nptm.Text : XrTableCell135.Text = workload.rs_5nptm.Text
        XrTableCell136.Text = workload.rs_6nptm.Text : XrTableCell137.Text = workload.rs_7nptm.Text

        XrTableCell104.Text = workload.tb_1npp.Text
        XrTableCell105.Text = workload.tb_2npp.Text : XrTableCell106.Text = workload.tb_3npp.Text
        XrTableCell107.Text = workload.tb_4npp.Text : XrTableCell108.Text = workload.rs_5npp.Text
        XrTableCell109.Text = workload.rs_6npp.Text : XrTableCell110.Text = workload.rs_7npp.Text


        XrTableCell86.Text = workload.tb_1ntbcm.Text
        XrTableCell87.Text = workload.tb_2ntbcm.Text : XrTableCell88.Text = workload.tb_3ntbcm.Text
        XrTableCell89.Text = workload.tb_4ntbcm.Text : XrTableCell90.Text = workload.rs_5ntbcm.Text
        XrTableCell91.Text = workload.rs_6ntbcm.Text : XrTableCell92.Text = workload.rs_7ntbcm.Text

        XrTableCell113.Text = workload.tb_1noapdtmo.Text
        XrTableCell114.Text = workload.tb_2noapdtmo.Text : XrTableCell115.Text = workload.tb_3noapdtmo.Text
        XrTableCell116.Text = workload.tb_4noapdtmo.Text : XrTableCell117.Text = workload.rs_5noapdtmo.Text
        XrTableCell118.Text = workload.rs_6noapdtmo.Text : XrTableCell119.Text = workload.rs_7noapdtmo.Text


        XrTableCell77.Text = workload.tb_1noapdtba.Text
        XrTableCell78.Text = workload.tb_2noapdtba.Text : XrTableCell79.Text = workload.tb_3noapdtba.Text
        XrTableCell80.Text = workload.tb_4noapdtba.Text : XrTableCell81.Text = workload.rs_5noapdtba.Text
        XrTableCell82.Text = workload.rs_6noapdtba.Text : XrTableCell83.Text = workload.rs_7noapdtba.Text

        'XrTableCell68.Text = workload.tb_1awrdd.Text
        'XrTableCell69.Text = workload.tb_2awrdd.Text : XrTableCell69.Text = workload.tb_3awrdd.Text
        'XrTableCell70.Text = workload.tb_4awrdd.Text : XrTableCell71.Text = workload.rs_5awrdd.Text
        'XrTableCell72.Text = workload.rs_6awrdd.Text
        XrTableCell74.Text = workload.rs_7awrdd.Text

        XrTableCell56.Text = workload.rs_tp.Text


    End Sub

    Public Sub wcost()
        XrTableCell140.Text = dialouge1.ComboBoxEdit2.Text + "-" + dialouge1.ComboBoxEdit1.Text
        XrTableCell141.Text = dialouge1.ComboBoxEdit3.Text + "-" + dialouge1.ComboBoxEdit1.Text
        XrTableCell142.Text = dialouge1.ComboBoxEdit4.Text + "-" + dialouge1.ComboBoxEdit1.Text
        XrTableCell143.Text = dialouge1.ComboBoxEdit5.Text + "-" + dialouge1.ComboBoxEdit1.Text

        XrTableCell146.Text = dialouge1.tb_1mri.Text
        XrTableCell147.Text = dialouge1.tb_2mri.Text
        XrTableCell148.Text = dialouge1.tb_3mri.Text
        XrTableCell149.Text = dialouge1.tb_4mri.Text

        XrTableCell158.Text = dialouge1.tb_1rc.Text
        XrTableCell159.Text = dialouge1.tb_2rc.Text
        XrTableCell160.Text = dialouge1.tb_3rc.Text
        XrTableCell161.Text = dialouge1.tb_4rc.Text

        XrTableCell164.Text = dialouge1.tb_1sbd.Text
        XrTableCell165.Text = dialouge1.tb_2sbd.Text
        XrTableCell166.Text = dialouge1.tb_3sbd.Text
        XrTableCell167.Text = dialouge1.tb_4sbd.Text

        XrTableCell188.Text = dialouge1.tb_1rdw.Text
        XrTableCell189.Text = dialouge1.tb_2rdw.Text
        XrTableCell190.Text = dialouge1.tb_3rdw.Text
        XrTableCell191.Text = dialouge1.tb_4rdw.Text

        XrTableCell170.Text = dialouge1.tb_1tdw.Text
        XrTableCell171.Text = dialouge1.tb_2tdw.Text
        XrTableCell172.Text = dialouge1.tb_3tdw.Text
        XrTableCell173.Text = dialouge1.tb_4tdw.Text

        XrTableCell182.Text = dialouge1.tb_1sdw.Text
        XrTableCell183.Text = dialouge1.tb_2sdw.Text
        XrTableCell184.Text = dialouge1.tb_3sdw.Text
        XrTableCell185.Text = dialouge1.tb_4sdw.Text

        XrTableCell176.Text = dialouge1.tb_1mop.Text
        XrTableCell177.Text = dialouge1.tb_2mop.Text
        XrTableCell178.Text = dialouge1.tb_3mop.Text
        XrTableCell179.Text = dialouge1.tb_4mop.Text

        XrTableCell152.Text = dialouge1.rs_1tp.Text
        XrTableCell153.Text = dialouge1.rs_2tp.Text
        XrTableCell154.Text = dialouge1.rs_3tp.Text
        XrTableCell155.Text = dialouge1.rs_4tp.Text
    End Sub
End Class