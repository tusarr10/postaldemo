Imports System.Data.OleDb
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports Dapper
Public Class monthlyReport
    Dim sbt As Double
    Dim cs As String = mainfrm.css
    Private Sub monthlyReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        waitopen()
        getdata() : waitclose()
    End Sub
    Sub getdata()
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT D_ate as [D_ate], Open_bal as [OpeningBalance] ,cashrec as [CashReceive], Sbdep as [SavingBalance], rddep as [RDDeposit], rdfine as [RDFine], ssadep as [SSADeposit], ssafine as [SSAFine], tddep as [TDDeposit], rplidep as [RPLIDeposit], rplifine as [RPLIFine], rplitax as [RPLITax], vpp as [VPP], othcol1 as [OtherColl1], othcol2 as [OtherColl2], totaldep as [TotalDep], cashremet as [CashRemt], sbwith as [SBWith] ,rdwith as [RDWith],tdwith as [TDWith] ,ssawith as [SSAWith],rpliwith as [RPLIWith],MONwith as [MONwith],othwith as [othwith],totalwith as [totalwith],curr_ency as [curr_ency],stamp1 as [stamp1],stamp2 as [stamp2],colsebal as [colsebal] from dacdb order by D_ate", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "dacdb")
            GridControl1.DataSource = myDataSet.Tables("dacdb").DefaultView
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub filt()
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT D_ate as [D_ate], Open_bal as [OpeningBalance] ,cashrec as [CashReceive], Sbdep as [SavingBalance], rddep as [RDDeposit], rdfine as [RDFine], ssadep as [SSADeposit], ssafine as [SSAFine], tddep as [TDDeposit], rplidep as [RPLIDeposit], rplifine as [RPLIFine], rplitax as [RPLITax], vpp as [VPP], othcol1 as [OtherColl1], othcol2 as [OtherColl2], totaldep as [TotalDep], cashremet as [CashRemt], sbwith as [SBWith] ,rdwith as [RDWith],tdwith as [TDWith] ,ssawith as [SSAWith],rpliwith as [RPLIWith],MONwith as [MONwith],othwith as [othwith],totalwith as [totalwith],curr_ency as [curr_ency],stamp1 as [stamp1],stamp2 as [stamp2],colsebal as [colsebal] from dacdb where D_ate like '%" & xy & "%' order by D_ate", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "dacdb")
            GridControl1.DataSource = myDataSet.Tables("dacdb").DefaultView
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Dim xy As String

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        waitopen()
        Try
            xy = ComboBox1.Text + " " + TextBox1.Text
            con = New OleDbConnection(cs)
            Dim comand As String = "SELECT D_ate, Open_bal ,cashrec , Sbdep , rddep, rdfine, ssadep , ssafine , tddep , rplidep , rplifine , rplitax , vpp , othcol1 , othcol2 , totaldep , cashremet , sbwith  ,rdwith ,tdwith  ,ssawith,rpliwith ,MONwith ,othwith ,totalwith ,curr_ency ,stamp1 ,stamp2 ,colsebal from dacdb where D_ate like '%" & xy & "%' order by D_ate"
            Dim list As List(Of CLS_monthlyRpt) = con.Query(Of CLS_monthlyRpt)(comand).ToList
            Using frm As printfrm = New printfrm()
                frm.MonthlyrptPrit(list)
                frm.ShowDialog()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        waitclose()
    End Sub

    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        waitopen() : xy = ComboBox1.Text + " " + TextBox1.Text
        filt() : waitclose()
    End Sub
End Class