Imports System.Data.OleDb
Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils

Public Class prinUser
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = mainfrm.css
    Private Sub prinUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    Public Sub GetData()

        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT AcNo, CustmorName,Gender, FatherName, MotherName, AcType, PAN, Adhar, NominiName, CautionMoneyReceiptNo, Address, Notes, DOB, PhoneNo, MobileNo, Email , Photo , Signiture ,AcBal from Custmor  order by CustmorName", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Custmor")
            GridControl1.DataSource = myDataSet.Tables("Custmor").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            GridControl1.PrintDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GridView1_CustomDrawRowIndicator(sender As Object, e As RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator

        If e.RowHandle >= 0 Then e.Info.DisplayText = e.RowHandle + 1.ToString()
    End Sub

    Private Sub GridView1_RowClick_1(sender As Object, e As RowClickEventArgs) Handles GridView1.RowClick
        Try
            Dim strAcno As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("AcNo")

            Dim data As Byte() = (TryCast(sender, GridView)).GetFocusedRowCellValue("Photo")
            Dim ms As New MemoryStream(data)
            Dim pic As Image = Image.FromStream(ms)
            Dim data2 As Byte() = (TryCast(sender, GridView)).GetFocusedRowCellValue("Signiture")
            Dim ms2 As New MemoryStream(data2)
            Dim sig As Image = Image.FromStream(ms2)

            Dim CustmorName As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("CustmorName")
            Dim Gender As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("Gender")
            Dim FatherName As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("FatherName")
            Dim MotherName As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("MotherName")
            Dim AcType As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("AcType")
            Dim Adhar As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("Adhar")
            Dim PAN As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("PAN")
            Dim NominiName As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("NominiName")
            Dim CautionMoneyReceiptNo As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("CautionMoneyReceiptNo")
            Dim Address As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("Address")
            Dim Notes As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("Notes")
            Dim DOB As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("DOB")
            Dim PhoneNo As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("PhoneNo")
            Dim MobileNo As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("MobileNo")
            Dim Email As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("Email")
            Dim AcBal As String = (TryCast(sender, GridView)).GetFocusedRowCellValue("AcBal")
            Using frm As printfrm = New printfrm()
                frm.usrinfo(strAcno, CustmorName, FatherName, MotherName, NominiName, AcType, Address, Adhar, AcBal, DOB, Email, MobileNo, Gender, CautionMoneyReceiptNo, Notes, PAN, PhoneNo, pic, sig)
                frm.ShowDialog()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub namefilt()
        Dim xm As String : If ComboBoxEdit1.Text = "All" Then : xm = "" : Else : xm = ComboBoxEdit1.Text : End If
        waitopen()
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT AcNo, CustmorName,Gender, FatherName, MotherName, AcType, PAN, Adhar, NominiName, CautionMoneyReceiptNo, Address, Notes, DOB, PhoneNo, MobileNo, Email , Photo , Signiture ,AcBal from Custmor where CustmorName like '%" & TextEdit1.Text.ToString & "%' and AcType like '%" & xm & "%' order by CustmorName", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Custmor")
            GridControl1.DataSource = myDataSet.Tables("Custmor").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        waitclose()
    End Sub
    Sub acnofilt()
        Dim xa As String : If ComboBoxEdit1.Text = "All" Then : xa = "" : Else : xa = ComboBoxEdit1.Text : End If
        waitopen()
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT AcNo, CustmorName,Gender, FatherName, MotherName, AcType, PAN, Adhar, NominiName, CautionMoneyReceiptNo, Address, Notes, DOB, PhoneNo, MobileNo, Email , Photo , Signiture ,AcBal from Custmor where AcNo like '%" & TextEdit2.Text.ToString & "%' and AcType like '%" & xa & "%' order by AcNo", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Custmor")
            GridControl1.DataSource = myDataSet.Tables("Custmor").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        waitclose()
    End Sub
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        GetData()
    End Sub

    Private Sub TextEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit1.EditValueChanged
        namefilt()
    End Sub

    Private Sub TextEdit2_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit2.EditValueChanged
        acnofilt()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        namefilt()
    End Sub
End Class