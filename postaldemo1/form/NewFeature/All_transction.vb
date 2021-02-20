Imports System.Data.OleDb
Imports System.IO
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports System.Windows.Forms.ImageList
Imports Dapper

Public Class All_transction
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim cmd0 As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = mainfrm.css

    Private Sub All_transction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GridView1.IndicatorWidth = 40
        waitopen()
        getdata() : waitclose()
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
    Sub getdata()
        Try
            '*******************************For Account Ditels**************************************
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT ACNO as [AcNo], Name as [CustName], acType as [Actype], today as [D_ate],Transtype as [TransType], Amount as [Trans_Amount], fine, Notes from CMB  order by Name", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "CMB")
            GridControl1.DataSource = myDataSet.Tables("CMB").DefaultView
            con.Close()
            '***********************************For Account Balance Ditels************************************
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GridView1_ShownEditor(sender As Object, e As EventArgs) Handles GridView1.ShownEditor
       

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        waitopen()
        filt1()
        waitclose()
    End Sub
    Sub filt1()
        Dim xm, xy, xt, xtt As String

        Try
            '******************************************
            If ComboBoxEdit1.Text = "All" Then : xt = "" : Else : xt = ComboBoxEdit1.Text : End If
            If ComboBoxEdit2.Text = "All" Then : xtt = "" : Else : xtt = ComboBoxEdit2.Text : End If
            If ComboBoxEdit3.Text = "All" Then : xm = "" : Else : xm = ComboBoxEdit3.Text : End If
            If ComboBoxEdit4.Text = "All" Then : xy = "" : Else : xy = ComboBoxEdit4.Text : End If
            '*******************************************
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT ACNO as [AcNo], Name as [CustName], acType as [Actype], today as [D_ate],Transtype as [TransType], Amount as [Trans_Amount], fine, Notes from CMB where today like '%" & xm.ToString + " " + xy & "%' and acType like '%" & xt & "%' and Transtype like '%" & xtt & "%'  order by DateValue(Format$(today,'dd mmmm yyyy')) ASC", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "CMB")
            GridControl1.DataSource = myDataSet.Tables("CMB").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        waitopen()
        clear() : getdata()
        waitclose()
    End Sub
    '"""""""""""""""""""""""""""""""""""""**********************************************""""""""""""""""""""""
    Sub clear()
        ComboBoxEdit1.Text = "All" : ComboBoxEdit1.Text = "All" : ComboBoxEdit2.Text = "All" : ComboBoxEdit3.Text = "All" : ComboBoxEdit4.Text = "All"
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        printform()
    End Sub
    Sub printform()
        waitopen()
        Dim xm, xy, xt, xtt As String
        '******************************************
        If ComboBoxEdit1.Text = "All" Then : xt = "" : Else : xt = ComboBoxEdit1.Text : End If
        If ComboBoxEdit2.Text = "All" Then : xtt = "" : Else : xtt = ComboBoxEdit2.Text : End If
        If ComboBoxEdit3.Text = "All" Then : xm = "" : Else : xm = ComboBoxEdit3.Text : End If
        If ComboBoxEdit4.Text = "All" Then : xy = "" : Else : xy = ComboBoxEdit4.Text : End If
        Try
            con = New OleDbConnection(cs)
            Dim comand As String = "SELECT ACNO, Name, acType  , today  ,Transtype  , Amount , fine, Notes from CMB where today like '%" & xm.ToString + " " + xy & "%' and acType like '%" & xt & "%' and Transtype like '%" & xtt & "%'  order by DateValue(Format$(today,'dd mmmm yyyy')) ASC"
            Dim list As List(Of CLS_allTranction) = con.Query(Of CLS_allTranction)(comand).ToList
            Using frm As printfrm = New printfrm()
                frm.PrintAllTransction_Print(list)
                frm.ShowDialog()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        waitclose()
    End Sub
End Class