Imports System.Data.OleDb
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Windows.Forms.ImageList

Public Class newUserData
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = mainfrm.css
    Private Sub newUserData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GridView1.IndicatorWidth = 30
        GetData()
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
    Private Sub GridView1_CustomDrawRowIndicator(sender As Object, e As RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator

        If e.RowHandle >= 0 Then e.Info.DisplayText = e.RowHandle + 1.ToString()
    End Sub
    Public Sub GetData()

        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT * from New_ac  order by D_ATE", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "New_ac")
            GridControl1.DataSource = myDataSet.Tables("New_ac").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub nameFilt()
        waitopen()
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT * from New_ac where N_AME like '%" & TextEdit1.Text.ToString & "%' order by N_AME", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "New_ac")
            GridControl1.DataSource = myDataSet.Tables("New_ac").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        waitclose()
    End Sub
    Public Sub ciffilt()
        waitopen()
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT * from New_ac where CIF like '%" & TextEdit2.Text.ToString & "%'order by id", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "New_ac")
            GridControl1.DataSource = myDataSet.Tables("New_ac").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        waitclose()
    End Sub

    Private Sub TextEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit1.EditValueChanged
        nameFilt()

    End Sub

    Private Sub TextEdit2_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit2.EditValueChanged
        ciffilt()

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        GetData()

    End Sub

    Private Sub GridView1_RowClick_1(sender As Object, e As RowClickEventArgs) Handles GridView1.RowClick
        Try
            new_account.TextBox1.Text = (TryCast(sender, GridView)).GetFocusedRowCellValue("ACNO")
            new_account.txtStudentName.Text = (TryCast(sender, GridView)).GetFocusedRowCellValue("N_AME")
            If ((TryCast(sender, GridView)).GetFocusedRowCellValue("GENDER") = "Male") Then
                new_account.rbMale.Checked = True
            End If
            If ((TryCast(sender, GridView)).GetFocusedRowCellValue("GENDER") = "Female") Then
                new_account.rbFemale.Checked = True
            End If
            new_account.txtStudentID.Text = (TryCast(sender, GridView)).GetFocusedRowCellValue("id")
            new_account.txtEmail.Text = (TryCast(sender, GridView)).GetFocusedRowCellValue("CIF")
            new_account.txtFatherName.Text = (TryCast(sender, GridView)).GetFocusedRowCellValue("FNAME")
            new_account.dtpDOB.Text = (TryCast(sender, GridView)).GetFocusedRowCellValue("D_ATE")
            new_account.txtTempAddress.Text = (TryCast(sender, GridView)).GetFocusedRowCellValue("aDDRESS")
            new_account.cmbCourse.Text = (TryCast(sender, GridView)).GetFocusedRowCellValue("dob")
            new_account.txtAdhar.Text = (TryCast(sender, GridView)).GetFocusedRowCellValue("aDHAR")
            new_account.txtSession.Text = (TryCast(sender, GridView)).GetFocusedRowCellValue("PAN")
            new_account.txtRollNo.Text = (TryCast(sender, GridView)).GetFocusedRowCellValue("NOMINI")
            new_account.cmbDepartment.Text = (TryCast(sender, GridView)).GetFocusedRowCellValue("ACTYPE")
            new_account.txtPermanentAddress.Text = (TryCast(sender, GridView)).GetFocusedRowCellValue("NOTES")
            new_account.Acbal.Text = (TryCast(sender, GridView)).GetFocusedRowCellValue("AMOUNT")
            new_account.txtPhoneNo.Text = (TryCast(sender, GridView)).GetFocusedRowCellValue("rEFF_NO")
            new_account.txtMobileNo.Text = (TryCast(sender, GridView)).GetFocusedRowCellValue("mobile")
            new_account.txtReceiptNo.Text = (TryCast(sender, GridView)).GetFocusedRowCellValue("recno")
            waitopen()
            new_account.MdiParent = mainfrm
            new_account.WindowState = FormWindowState.Normal
            new_account.Show() : Me.Close() : waitclose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class