Imports System.Data.OleDb
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports System.Windows.Forms.ImageList

Public Class expdlist
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = mainforfm.css
    Private Sub expdlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GridView1.IndicatorWidth = 30
        waitopen()
        GetData()
        waitclose()

    End Sub
    Private Sub GridView1_CustomDrawRowIndicator(sender As Object, e As RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator

        If e.RowHandle >= 0 Then e.Info.DisplayText = e.RowHandle + 1.ToString()
    End Sub
    Private Sub GridView1_RowClick_1(sender As Object, e As RowClickEventArgs) Handles GridView1.RowClick
        Try
            waitopen()

            Dim id As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("ID")

            Dim d_ate As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("d_ate")
            expd_usr.TextEdit2.Text = d_ate

            Dim y_ear As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("y_ear")
            expd_usr.TextEdit1.Text = y_ear

            Dim type As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("type")
            expd_usr.cb_income.Text = type

            Dim boname As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("N_BO")
            expd_usr.tb_boname.Text = boname

            Dim soname As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("N_SO")
            expd_usr.tb_soname.Text = soname

            Dim honame As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("N_HO")
            expd_usr.tb_honame.Text = honame

            Dim pss25 As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("PSS_25")
            expd_usr.tb_25pss.Text = pss25

            Dim pss720 As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("PSS_720")
            expd_usr.tb_720pss.Text = pss720

            Dim upd34 As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("UPD_34")
            expd_usr.tb_34upd.Text = upd34

            Dim upd18 As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("UPD_18")
            expd_usr.tb_18upp.Text = upd18

            Dim mocisu24 As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("MOCISU_24")
            expd_usr.tb_24moi.Text = mocisu24

            Dim mocpaid35 As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("MOCPAID_35")
            expd_usr.tb_35mop.Text = mocpaid35

            Dim iposold25 As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("IPOSOLD_25")
            expd_usr.tb_25ipos.Text = iposold25

            Dim ipopaid25 As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("IPOPAID_25")
            expd_usr.tb_25ipop.Text = ipopaid25

            Dim liveac As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("LIVEAC_6374")
            expd_usr.tb_6374lposb.Text = liveac

            Dim silentac As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("SILANTAC_967")
            expd_usr.tb_967sa.Text = silentac

            Dim ssctrns As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("SSCSBTRNS_2185")
            expd_usr.tb_2185sc.Text = ssctrns

            Dim mnrgs As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("MGNREG_2488")
            expd_usr.tb_2488mgn.Text = mnrgs

            Dim bpm As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("GDSBPM_PAY")
            expd_usr.tb_bpm.Text = bpm

            Dim md As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("GDSMD_PAY")
            expd_usr.tb_md.Text = md

            Dim mc As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("GDSMC_PAY")
            expd_usr.tb_mc.Text = mc

            Dim fixad As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("FIXADD")
            expd_usr.tb_fa.Text = fixad

            Dim pos As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("PSOLD5")
            expd_usr.rs_5ps.Text = pos

            Dim ioc As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("IOC")
            expd_usr.tb_ioc.Text = ioc

            Dim plb As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("PLB")
            expd_usr.tb_plb.Text = plb

            Me.Close()
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
            cmd = New OleDbCommand("SELECT * from IAE  order by ID", con)
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
    Public Sub Getfilt()
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT * from IAE where N_BO like '%" & TextEdit1.Text.ToString & "%' order by ID", con)
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
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub TextEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit1.EditValueChanged
        Getfilt()

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        TextEdit1.Text = ""
        GetData()

    End Sub
End Class