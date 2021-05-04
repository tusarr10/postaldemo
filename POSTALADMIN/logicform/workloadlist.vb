Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports System.Windows.Forms.ImageList
Imports System.Data.OleDb

Public Class workloadlist

    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = mainforfm.css

    Private Sub workloadlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GridView1.IndicatorWidth = 30
        waitopen()
        GetData()
        ' CODE HERE
        waitclose()
    End Sub

    Private Sub GridView1_CustomDrawRowIndicator(sender As Object, e As RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator

        If e.RowHandle >= 0 Then e.Info.DisplayText = e.RowHandle + 1.ToString()
    End Sub
    Public Shared Sub CustomDrawRowIndicator(ByVal gridControl As GridControl, ByVal gridView As GridView)
        gridView.IndicatorWidth = 50
        ' Handle this event to paint RowIndicator manually 
        AddHandler gridView.CustomDrawRowIndicator, Sub(s, e)
                                                        If Not e.Info.IsRowIndicator Then
                                                            Return
                                                        End If
                                                        Dim view As GridView = TryCast(s, GridView)
                                                        e.Handled = True

                                                        e.Appearance.BackColor = If(view.FocusedRowHandle = e.RowHandle, Color.Chocolate, Color.MediumSpringGreen)
                                                        e.Appearance.FillRectangle(e.Cache, New Rectangle(e.Bounds.X + 2, e.Bounds.Y + 2, e.Bounds.Width - 4, e.Bounds.Y - 4))
                                                        If e.Info.ImageIndex < 0 Then
                                                            Return
                                                        End If
                                                        Dim ic As ImageCollection = TryCast(e.Info.ImageCollection, ImageCollection)

                                                    End Sub

    End Sub

    Public Sub GetData()
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT * from WOKLOD  order by ID", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "IAE")
            '  myDA.Fill(myDataSet, "tb_user")
            GridControl1.DataSource = myDataSet.Tables("IAE").DefaultView
            ' DataGridView1.DataSource = myDataSet.Tables("tb_user").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub getfilt(ByVal x As String)
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT * from WOKLOD where BO like '%" & x & "%' order by ID", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "WOKLOD")
            '  myDA.Fill(myDataSet, "tb_user")
            GridControl1.DataSource = myDataSet.Tables("WOKLOD").DefaultView
            ' DataGridView1.DataSource = myDataSet.Tables("tb_user").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Data Not Found ...", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub getfilt1(ByVal x As String)
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand(x, con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "WOKLOD")
            '  myDA.Fill(myDataSet, "tb_user")
            GridControl1.DataSource = myDataSet.Tables("WOKLOD").DefaultView
            ' DataGridView1.DataSource = myDataSet.Tables("tb_user").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Data Not Found ...", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub TextEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit1.EditValueChanged
        waitopen()

        getfilt(TextEdit1.Text.ToString)

        waitclose()

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        waitopen()
        GetData()
        TextEdit1.Text = ""
        waitclose()

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        waitopen()

        getfilt(TextEdit1.Text.ToString)

        waitclose()
    End Sub

    Private Sub GridView1_RowClick(sender As Object, e As RowClickEventArgs) Handles GridView1.RowClick
        Try
            waitopen()

            workload.resetall()

            Dim ACCWORK As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("ACCWORK")
            workload.rs_7awrdd.Text = ACCWORK

            Dim id As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("ID")

            Dim N_AME As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("N_AME")
            '      dim x as string = N_AME

            Dim BO As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("BO")
            ' BO = (TryCast(sender, GridView)).GetRowCellValue(0, "BO")
            workload.tb_nb.Text = BO

            Dim SO As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("SO")
            workload.tb_ns.Text = SO

            Dim HO As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("HO")
            workload.tb_nh.Text = HO

            Dim DES As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("DES")
            workload.tb_dog.Text = DES

            Dim BUSHOUR As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("BUSHOUR")
            workload.tb_hb.Text = BUSHOUR

            Dim WORKINGHOUR As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("WORKINGHOUR")
            workload.tb_twh.Text = WORKINGHOUR

            Dim Y_EAR As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("Y_EAR")
            workload.ComboBoxEdit1.Text = Y_EAR

            Dim D_ATE As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("D_ATE")
            workload.TextEdit1.Text = D_ATE

            Dim PAYLVL As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("PAYLVL")
            workload.tb_pyl.Text = PAYLVL

            Dim M1 As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M1")
            workload.tb_1fm.Text = M1

            Dim M2 As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M2")
            workload.tb_2fm.Text = M2

            Dim M3 As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M3")
            workload.tb_3fm.Text = M3

            Dim M4 As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M4")
            workload.tb_4fm.Text = M4


            Dim M1UAH As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M1UAH")
            workload.tb_1nuahd.Text = M1UAH

            Dim M2UAH As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M2UAH")
            workload.tb_2nuahd.Text = M2UAH

            Dim M3UAH As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M3UAH")
            workload.tb_3nuahd.Text = M3UAH

            Dim M4UAH As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M4UAH")
            workload.tb_4nuahd.Text = M4UAH


            Dim M1RAH As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M1RAH")
            workload.tb_1nrahm.Text = M1RAH

            Dim M2RAH As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M2RAH")
            workload.tb_2nrahm.Text = M2RAH

            Dim M3RAH As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M3RAH")
            workload.tb_3nrahm.Text = M3RAH

            Dim M4RAH As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M4RAH")
            workload.tb_4nrahm.Text = M4RAH

            Dim M1MO As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M1MO")
            workload.tb_1nmhm.Text = M1MO

            Dim M2MO As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M2MO")
            workload.tb_2nmhm.Text = M2MO

            Dim M3MO As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M3MO")
            workload.tb_3nmhm.Text = M3MO

            Dim M4MO As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M4MO")
            workload.tb_4nmhm.Text = M4MO


            Dim M1SS As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M1SS")
            workload.tb_1ssm.Text = M1SS

            Dim M2SS As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M2SS")
            workload.tb_2ssm.Text = M2SS

            Dim M3SS As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M3SS")
            workload.tb_3ssm.Text = M3SS

            Dim M4SS As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M4SS")
            workload.tb_4ssm.Text = M4SS



            Dim M1ACTHM As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M1ACTHM")
            workload.tb_1acthm.Text = M1ACTHM

            Dim M2ACTHM As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M2ACTHM")
            workload.tb_2acthm.Text = M2ACTHM

            Dim M3ACTHM As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M3ACTHM")
            workload.tb_3acthm.Text = M3ACTHM

            Dim M4ACTHM As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M4ACTHM")
            workload.tb_4acthm.Text = M4ACTHM



            Dim M1SRTSTRS As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M1SRTSTRS")
            workload.tb_1nptm.Text = M1SRTSTRS

            Dim M2SRTSTRS As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M2SRTSTRS")
            workload.tb_2nptm.Text = M2SRTSTRS

            Dim M3SRTSTRS As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M3SRTSTRS")
            workload.tb_3nptm.Text = M3SRTSTRS

            Dim M4SRTSTRS As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M4SRTSTRS")
            workload.tb_4nptm.Text = M4SRTSTRS




            Dim M1PLI As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M1PLI")
            workload.tb_1npp.Text = M1PLI

            Dim M2PLI As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M2PLI")
            workload.tb_2npp.Text = M2PLI

            Dim M3PLI As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M3PLI")
            workload.tb_3npp.Text = M3PLI

            Dim M4PLI As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M4PLI")
            workload.tb_4npp.Text = M4PLI


            Dim M1TELBILL As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M1TELBILL")
            workload.tb_1ntbcm.Text = M1TELBILL

            Dim M2TELBILL As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M2TELBILL")
            workload.tb_2ntbcm.Text = M2TELBILL

            Dim M3TELBILL As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M3TELBILL")
            workload.tb_3ntbcm.Text = M3TELBILL

            Dim M4TELBILL As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M4TELBILL")
            workload.tb_4ntbcm.Text = M4TELBILL


            Dim M1OLDMO As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M1OLDMO")
            workload.tb_1noapdtmo.Text = M1OLDMO

            Dim M2OLDMO As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M2OLDMO")
            workload.tb_2noapdtmo.Text = M2OLDMO

            Dim M3OLDMO As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M3OLDMO")
            workload.tb_3noapdtmo.Text = M3OLDMO

            Dim M4OLDMO As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M4OLDMO")
            workload.tb_4noapdtmo.Text = M4OLDMO

            Dim M1OLDBANK As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M1OLDBANK")
            workload.tb_1noapdtba.Text = M1OLDBANK

            Dim M2OLDBANK As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M2OLDBANK")
            workload.tb_2noapdtba.Text = M2OLDBANK

            Dim M3OLDBANK As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M3OLDBANK")
            workload.tb_3noapdtba.Text = M3OLDBANK

            Dim M4OLDBANK As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M4OLDBANK")
            workload.tb_4noapdtba.Text = M4OLDBANK

            Dim M1MOI As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M1MOI")
            dialouge1.tb_1mri.Text = M1MOI

            Dim M2MOI As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M2MOI")
            dialouge1.tb_2mri.Text = M2MOI

            Dim M3MOI As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M3MOI")
            dialouge1.tb_3mri.Text = M3MOI

            Dim M4MOI As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M4MOI")
            dialouge1.tb_4mri.Text = M4MOI

            Dim M1RPLICOL As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M1RPLICOL")
            dialouge1.tb_1rc.Text = M1RPLICOL

            Dim M2RPLICOL As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M2RPLICOL")
            dialouge1.tb_2rc.Text = M2RPLICOL

            Dim M3RPLICOL As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M3RPLICOL")
            dialouge1.tb_3rc.Text = M3RPLICOL

            Dim M4RPLICOL As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M4RPLICOL")
            dialouge1.tb_4rc.Text = M4RPLICOL



            Dim M1SBDEP As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M1SBDEP")
            dialouge1.tb_1sbd.Text = M1SBDEP

            Dim M2SBDEP As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M2SBDEP")
            dialouge1.tb_2sbd.Text = M2SBDEP

            Dim M3SBDEP As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M3SBDEP")
            dialouge1.tb_3sbd.Text = M3SBDEP

            Dim M4SBDEP As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M4RSBDEPCOL")
            dialouge1.tb_4sbd.Text = M4SBDEP

            Dim M1RDDEP As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M1RDDEP")
            dialouge1.tb_1rdw.Text = M1RDDEP

            Dim M2RDDEP As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M2RDDEP")
            dialouge1.tb_2rdw.Text = M2RDDEP

            Dim M3RDDEP As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M3RDDEP")
            dialouge1.tb_3rdw.Text = M3RDDEP

            Dim M4RDDEP As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M4RDDEP")
            dialouge1.tb_4rdw.Text = M4RDDEP


            Dim M1TDDEP As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M1TDDEP")
            dialouge1.tb_1tdw.Text = M1TDDEP

            Dim M2TDDEP As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M2TDDEP")
            dialouge1.tb_2tdw.Text = M2TDDEP

            Dim M3TDDEP As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M3TDDEP")
            dialouge1.tb_3tdw.Text = M3TDDEP

            Dim M4TDDEP As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M4TDDEP")
            dialouge1.tb_4tdw.Text = M4TDDEP


            Dim M1SSA As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M1SSA")
            dialouge1.tb_1sdw.Text = M1SSA

            Dim M2SSA As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M2SSA")
            dialouge1.tb_2sdw.Text = M2SSA

            Dim M3SSA As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M3SSA")
            dialouge1.tb_3sdw.Text = M3SSA

            Dim M4SSA As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M4SSA")
            dialouge1.tb_4sdw.Text = M4SSA


            Dim M1MOP As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M1MOP")
            dialouge1.tb_1mop.Text = M1MOP

            Dim M2MOP As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M2MOP")
            dialouge1.tb_2mop.Text = M2MOP

            Dim M3MOP As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M3MOP")
            dialouge1.tb_3mop.Text = M3MOP

            Dim M4MOP As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("M4MOP")
            dialouge1.tb_4mop.Text = M4MOP


            Me.Close()
            workload.calculate_work()

            waitclose()

            'Using frm As printfrm = New printfrm()
            '    frm.usrinfo(strAcno, CustmorName, FatherName, MotherName, NominiName, AcType, Address, Adhar, AcBal, DOB, Email, MobileNo, Gender, CautionMoneyReceiptNo, Notes, PAN, PhoneNo, pic, sig)
            '    frm.ShowDialog()
            'End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            waitclose()

        End Try
    End Sub
    Public Sub takedata(ByVal x As Integer)
        Try
            waitopen()

            workload.resetall()

            Dim ACCWORK As String = GridView1.GetRowCellValue(0, "ACCWORK")
            workload.rs_7awrdd.Text = ACCWORK

            Dim id As String = GridView1.GetRowCellValue(0, "ID")

            Dim N_AME As String = GridView1.GetRowCellValue(0, "N_AME")
            '      dim x as string = N_AME

            Dim BO As String = GridView1.GetRowCellValue(0, "BO")
            BO = GridView1.GetRowCellValue(0, "BO")
            workload.tb_nb.Text = BO

            Dim SO As String = GridView1.GetRowCellValue(0, "SO")
            workload.tb_ns.Text = SO

            Dim HO As String = GridView1.GetRowCellValue(0, "HO")
            workload.tb_nh.Text = HO

            Dim DES As String = GridView1.GetRowCellValue(0, "DES")
            workload.tb_dog.Text = DES

            Dim BUSHOUR As String = GridView1.GetRowCellValue(0, "BUSHOUR")
            workload.tb_hb.Text = BUSHOUR

            Dim WORKINGHOUR As String = GridView1.GetRowCellValue(0, "WORKINGHOUR")
            workload.tb_twh.Text = WORKINGHOUR

            Dim Y_EAR As String = GridView1.GetRowCellValue(0, "Y_EAR")
            workload.ComboBoxEdit1.Text = Y_EAR

            Dim D_ATE As String = GridView1.GetRowCellValue(0, "D_ATE")
            workload.TextEdit1.Text = D_ATE

            Dim PAYLVL As String = GridView1.GetRowCellValue(0, "PAYLVL")
            workload.tb_pyl.Text = PAYLVL

            Dim M1 As String = GridView1.GetRowCellValue(0, "M1")
            workload.tb_1fm.Text = M1

            Dim M2 As String = GridView1.GetRowCellValue(0, "M2")
            workload.tb_2fm.Text = M2

            Dim M3 As String = GridView1.GetRowCellValue(0, "M3")
            workload.tb_3fm.Text = M3

            Dim M4 As String = GridView1.GetRowCellValue(0, "M4")
            workload.tb_4fm.Text = M4


            Dim M1UAH As String = GridView1.GetRowCellValue(0, "M1UAH")
            workload.tb_1nuahd.Text = M1UAH

            Dim M2UAH As String = GridView1.GetRowCellValue(0, "M2UAH")
            workload.tb_2nuahd.Text = M2UAH

            Dim M3UAH As String = GridView1.GetRowCellValue(0, "M3UAH")
            workload.tb_3nuahd.Text = M3UAH

            Dim M4UAH As String = GridView1.GetRowCellValue(0, "M4UAH")
            workload.tb_4nuahd.Text = M4UAH


            Dim M1RAH As String = GridView1.GetRowCellValue(0, "M1RAH")
            workload.tb_1nrahm.Text = M1RAH

            Dim M2RAH As String = GridView1.GetRowCellValue(0, "M2RAH")
            workload.tb_2nrahm.Text = M2RAH

            Dim M3RAH As String = GridView1.GetRowCellValue(0, "M3RAH")
            workload.tb_3nrahm.Text = M3RAH

            Dim M4RAH As String = GridView1.GetRowCellValue(0, "M4RAH")
            workload.tb_4nrahm.Text = M4RAH

            Dim M1MO As String = GridView1.GetRowCellValue(0, "M1MO")
            workload.tb_1nmhm.Text = M1MO

            Dim M2MO As String = GridView1.GetRowCellValue(0, "M2MO")
            workload.tb_2nmhm.Text = M2MO

            Dim M3MO As String = GridView1.GetRowCellValue(0, "M3MO")
            workload.tb_3nmhm.Text = M3MO

            Dim M4MO As String = GridView1.GetRowCellValue(0, "M4MO")
            workload.tb_4nmhm.Text = M4MO


            Dim M1SS As String = GridView1.GetRowCellValue(0, "M1SS")
            workload.tb_1ssm.Text = M1SS

            Dim M2SS As String = GridView1.GetRowCellValue(0, "M2SS")
            workload.tb_2ssm.Text = M2SS

            Dim M3SS As String = GridView1.GetRowCellValue(0, "M3SS")
            workload.tb_3ssm.Text = M3SS

            Dim M4SS As String = GridView1.GetRowCellValue(0, "M4SS")
            workload.tb_4ssm.Text = M4SS



            Dim M1ACTHM As String = GridView1.GetRowCellValue(0, "M1ACTHM")
            workload.tb_1acthm.Text = M1ACTHM

            Dim M2ACTHM As String = GridView1.GetRowCellValue(0, "M2ACTHM")
            workload.tb_2acthm.Text = M2ACTHM

            Dim M3ACTHM As String = GridView1.GetRowCellValue(0, "M3ACTHM")
            workload.tb_3acthm.Text = M3ACTHM

            Dim M4ACTHM As String = GridView1.GetRowCellValue(0, "M4ACTHM")
            workload.tb_4acthm.Text = M4ACTHM



            Dim M1SRTSTRS As String = GridView1.GetRowCellValue(0, "M1SRTSTRS")
            workload.tb_1nptm.Text = M1SRTSTRS

            Dim M2SRTSTRS As String = GridView1.GetRowCellValue(0, "M2SRTSTRS")
            workload.tb_2nptm.Text = M2SRTSTRS

            Dim M3SRTSTRS As String = GridView1.GetRowCellValue(0, "M3SRTSTRS")
            workload.tb_3nptm.Text = M3SRTSTRS

            Dim M4SRTSTRS As String = GridView1.GetRowCellValue(0, "M4SRTSTRS")
            workload.tb_4nptm.Text = M4SRTSTRS




            Dim M1PLI As String = GridView1.GetRowCellValue(0, "M1PLI")
            workload.tb_1npp.Text = M1PLI

            Dim M2PLI As String = GridView1.GetRowCellValue(0, "M2PLI")
            workload.tb_2npp.Text = M2PLI

            Dim M3PLI As String = GridView1.GetRowCellValue(0, "M3PLI")
            workload.tb_3npp.Text = M3PLI

            Dim M4PLI As String = GridView1.GetRowCellValue(0, "M4PLI")
            workload.tb_4npp.Text = M4PLI


            Dim M1TELBILL As String = GridView1.GetRowCellValue(0, "M1TELBILL")
            workload.tb_1ntbcm.Text = M1TELBILL

            Dim M2TELBILL As String = GridView1.GetRowCellValue(0, "M2TELBILL")
            workload.tb_2ntbcm.Text = M2TELBILL

            Dim M3TELBILL As String = GridView1.GetRowCellValue(0, "M3TELBILL")
            workload.tb_3ntbcm.Text = M3TELBILL

            Dim M4TELBILL As String = GridView1.GetRowCellValue(0, "M4TELBILL")
            workload.tb_4ntbcm.Text = M4TELBILL


            Dim M1OLDMO As String = GridView1.GetRowCellValue(0, "M1OLDMO")
            workload.tb_1noapdtmo.Text = M1OLDMO

            Dim M2OLDMO As String = GridView1.GetRowCellValue(0, "M2OLDMO")
            workload.tb_2noapdtmo.Text = M2OLDMO

            Dim M3OLDMO As String = GridView1.GetRowCellValue(0, "M3OLDMO")
            workload.tb_3noapdtmo.Text = M3OLDMO

            Dim M4OLDMO As String = GridView1.GetRowCellValue(0, "M4OLDMO")
            workload.tb_4noapdtmo.Text = M4OLDMO

            Dim M1OLDBANK As String = GridView1.GetRowCellValue(0, "M1OLDBANK")
            workload.tb_1noapdtba.Text = M1OLDBANK

            Dim M2OLDBANK As String = GridView1.GetRowCellValue(0, "M2OLDBANK")
            workload.tb_2noapdtba.Text = M2OLDBANK

            Dim M3OLDBANK As String = GridView1.GetRowCellValue(0, "M3OLDBANK")
            workload.tb_3noapdtba.Text = M3OLDBANK

            Dim M4OLDBANK As String = GridView1.GetRowCellValue(0, "M4OLDBANK")
            workload.tb_4noapdtba.Text = M4OLDBANK

            Dim M1MOI As String = GridView1.GetRowCellValue(0, "M1MOI")
            dialouge1.tb_1mri.Text = M1MOI

            Dim M2MOI As String = GridView1.GetRowCellValue(0, "M2MOI")
            dialouge1.tb_2mri.Text = M2MOI

            Dim M3MOI As String = GridView1.GetRowCellValue(0, "M3MOI")
            dialouge1.tb_3mri.Text = M3MOI

            Dim M4MOI As String = GridView1.GetRowCellValue(0, "M4MOI")
            dialouge1.tb_4mri.Text = M4MOI

            Dim M1RPLICOL As String = GridView1.GetRowCellValue(0, "M1RPLICOL")
            dialouge1.tb_1rc.Text = M1RPLICOL

            Dim M2RPLICOL As String = GridView1.GetRowCellValue(0, "M2RPLICOL")
            dialouge1.tb_2rc.Text = M2RPLICOL

            Dim M3RPLICOL As String = GridView1.GetRowCellValue(0, "M3RPLICOL")
            dialouge1.tb_3rc.Text = M3RPLICOL

            Dim M4RPLICOL As String = GridView1.GetRowCellValue(0, "M4RPLICOL")
            dialouge1.tb_4rc.Text = M4RPLICOL



            Dim M1SBDEP As String = GridView1.GetRowCellValue(0, "M1SBDEP")
            dialouge1.tb_1sbd.Text = M1SBDEP

            Dim M2SBDEP As String = GridView1.GetRowCellValue(0, "M2SBDEP")
            dialouge1.tb_2sbd.Text = M2SBDEP

            Dim M3SBDEP As String = GridView1.GetRowCellValue(0, "M3SBDEP")
            dialouge1.tb_3sbd.Text = M3SBDEP

            Dim M4SBDEP As String = GridView1.GetRowCellValue(0, "M4RSBDEPCOL")
            dialouge1.tb_4sbd.Text = M4SBDEP

            Dim M1RDDEP As String = GridView1.GetRowCellValue(0, "M1RDDEP")
            dialouge1.tb_1rdw.Text = M1RDDEP

            Dim M2RDDEP As String = GridView1.GetRowCellValue(0, "M2RDDEP")
            dialouge1.tb_2rdw.Text = M2RDDEP

            Dim M3RDDEP As String = GridView1.GetRowCellValue(0, "M3RDDEP")
            dialouge1.tb_3rdw.Text = M3RDDEP

            Dim M4RDDEP As String = GridView1.GetRowCellValue(0, "M4RDDEP")
            dialouge1.tb_4rdw.Text = M4RDDEP


            Dim M1TDDEP As String = GridView1.GetRowCellValue(0, "M1TDDEP")
            dialouge1.tb_1tdw.Text = M1TDDEP

            Dim M2TDDEP As String = GridView1.GetRowCellValue(0, "M2TDDEP")
            dialouge1.tb_2tdw.Text = M2TDDEP

            Dim M3TDDEP As String = GridView1.GetRowCellValue(0, "M3TDDEP")
            dialouge1.tb_3tdw.Text = M3TDDEP

            Dim M4TDDEP As String = GridView1.GetRowCellValue(0, "M4TDDEP")
            dialouge1.tb_4tdw.Text = M4TDDEP


            Dim M1SSA As String = GridView1.GetRowCellValue(0, "M1SSA")
            dialouge1.tb_1sdw.Text = M1SSA

            Dim M2SSA As String = GridView1.GetRowCellValue(0, "M2SSA")
            dialouge1.tb_2sdw.Text = M2SSA

            Dim M3SSA As String = GridView1.GetRowCellValue(0, "M3SSA")
            dialouge1.tb_3sdw.Text = M3SSA

            Dim M4SSA As String = GridView1.GetRowCellValue(0, "M4SSA")
            dialouge1.tb_4sdw.Text = M4SSA


            Dim M1MOP As String = GridView1.GetRowCellValue(0, "M1MOP")
            dialouge1.tb_1mop.Text = M1MOP

            Dim M2MOP As String = GridView1.GetRowCellValue(0, "M2MOP")
            dialouge1.tb_2mop.Text = M2MOP

            Dim M3MOP As String = GridView1.GetRowCellValue(0, "M3MOP")
            dialouge1.tb_3mop.Text = M3MOP

            Dim M4MOP As String = GridView1.GetRowCellValue(0, "M4MOP")
            dialouge1.tb_4mop.Text = M4MOP


            Me.Close()
            workload.calculate_work()

            waitclose()

            'Using frm As printfrm = New printfrm()
            '    frm.usrinfo(strAcno, CustmorName, FatherName, MotherName, NominiName, AcType, Address, Adhar, AcBal, DOB, Email, MobileNo, Gender, CautionMoneyReceiptNo, Notes, PAN, PhoneNo, pic, sig)
            '    frm.ShowDialog()
            'End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            waitclose()

        End Try
    End Sub
End Class