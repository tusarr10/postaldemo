Imports System.Data.OleDb
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Public Class daclist
    Dim cs As String = mainfrm.css
    Private Sub daclist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getdata()
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd MMMM yyyy"
    End Sub
    Sub getdata()
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT D_ate as [Date], Open_bal as [Opening Balance] ,cashrec as [Cash Receive], Sbdep as [Saving Deposit], rddep as [RD Deposit], rdfine as [RD Fine], ssadep as [SSA Deposit], ssafine as [SSA Fine], tddep as [TD Deposit], rplidep as [RPLI Deposit], rplifine as [RPLI Fine], rplitax as [RPLI Tax], vpp as [VPP], othcol1 as [Other Collection 1], othcol2 as [Other Collection 2], totaldep as [Total Deposit], cashremet as [Cash Remet], sbwith as [SB Withdraw] ,rdwith as [RD Withdrow],tdwith as [TD Withdraw] ,ssawith as [SSA Withdraw],rpliwith as [RPLI Withdraw],MONwith as [Money Order],othwith as [Other Withdraw],totalwith as [Total Withdraw],curr_ency as [Currency],stamp1 as [Stamp],stamp2 as [Indian Stamp],colsebal as [Closing Balance] from dacdb order by D_ate", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "dacdb")
            '  myDA.Fill(myDataSet, "tb_user")
            DataGridView1.DataSource = myDataSet.Tables("dacdb").DefaultView
            ' DataGridView1.DataSource = myDataSet.Tables("tb_user").DefaultView
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub filt()
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT D_ate as [Date], Open_bal as [Opening Balance] ,cashrec as [Cash Receive], Sbdep as [Saving Deposit], rddep as [RD Deposit], rdfine as [RD Fine], ssadep as [SSA Deposit], ssafine as [SSA Fine], tddep as [TD Deposit], rplidep as [RPLI Deposit], rplifine as [RPLI Fine], rplitax as [RPLI Tax], vpp as [VPP], othcol1 as [Other Collection 1], othcol2 as [Other Collection 2], totaldep as [Total Deposit], cashremet as [Cash Remet], sbwith as [SB Withdraw] ,rdwith as [RD Withdrow],tdwith as [TD Withdraw] ,ssawith as [SSA Withdraw],rpliwith as [RPLI Withdraw],MONwith as [Money Order],othwith as [Other Withdraw],totalwith as [Total Withdraw],curr_ency as [Currency],stamp1 as [Stamp],stamp2 as [Indian Stamp],colsebal as [Closing Balance] from dacdb where D_ate like '" & DateTimePicker1.Text & "%' order by D_ate", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "dacdb")
            '  myDA.Fill(myDataSet, "tb_user")
            DataGridView1.DataSource = myDataSet.Tables("dacdb").DefaultView
            ' DataGridView1.DataSource = myDataSet.Tables("tb_user").DefaultView
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub filt2()
        Try
            con = New OleDbConnection(cs)
            con.Open()

            cmd = New OleDbCommand("SELECT D_ate as [Date], Open_bal as [Opening Balance] ,cashrec as [Cash Receive], Sbdep as [Saving Deposit], rddep as [RD Deposit], rdfine as [RD Fine], ssadep as [SSA Deposit], ssafine as [SSA Fine], tddep as [TD Deposit], rplidep as [RPLI Deposit], rplifine as [RPLI Fine], rplitax as [RPLI Tax], vpp as [VPP], othcol1 as [Other Collection 1], othcol2 as [Other Collection 2], totaldep as [Total Deposit], cashremet as [Cash Remet], sbwith as [SB Withdraw] ,rdwith as [RD Withdrow],tdwith as [TD Withdraw] ,ssawith as [SSA Withdraw],rpliwith as [RPLI Withdraw],MONwith as [Money Order],othwith as [Other Withdraw],totalwith as [Total Withdraw],curr_ency as [Currency],stamp1 as [Stamp],stamp2 as [Indian Stamp],colsebal as [Closing Balance] from dacdb where D_ate like '" & dac.DateTimePicker1.Text & "%' order by D_ate", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "dacdb")
            DataGridView1.DataSource = myDataSet.Tables("dacdb").DefaultView
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub filt223(ByVal dtta As String)
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT D_ate as [Date], Open_bal as [Opening Balance] ,cashrec as [Cash Receive], Sbdep as [Saving Deposit], rddep as [RD Deposit], rdfine as [RD Fine], ssadep as [SSA Deposit], ssafine as [SSA Fine], tddep as [TD Deposit], rplidep as [RPLI Deposit], rplifine as [RPLI Fine], rplitax as [RPLI Tax], vpp as [VPP], othcol1 as [Other Collection 1], othcol2 as [Other Collection 2], totaldep as [Total Deposit], cashremet as [Cash Remet], sbwith as [SB Withdraw] ,rdwith as [RD Withdrow],tdwith as [TD Withdraw] ,ssawith as [SSA Withdraw],rpliwith as [RPLI Withdraw],MONwith as [Money Order],othwith as [Other Withdraw],totalwith as [Total Withdraw],curr_ency as [Currency],stamp1 as [Stamp],stamp2 as [Indian Stamp],colsebal as [Closing Balance] from dacdb where D_ate like '" & dtta & "%' order by D_ate", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "dacdb")
            DataGridView1.DataSource = myDataSet.Tables("dacdb").DefaultView
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub DataGridView1_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles DataGridView1.RowPostPaint
        Dim strRowNumber As String = (e.RowIndex + 1).ToString()
        Dim size As SizeF = e.Graphics.MeasureString(strRowNumber, Me.Font)
        If DataGridView1.RowHeadersWidth < Convert.ToInt32((size.Width + 20)) Then
            DataGridView1.RowHeadersWidth = Convert.ToInt32((size.Width + 20))
        End If
        Dim b As Brush = SystemBrushes.ControlText
        e.Graphics.DrawString(strRowNumber, Me.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)

        'filt()

    End Sub
    '******************************************************************
    Private Sub DataGridView1_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        Try
            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
            '  Me.Hide()
            '  rdac.Hide()
           
            dac.DateTimePicker1.Text = dr.Cells(0).Value.ToString()
            dac.TextBox2.Text = dr.Cells(1).Value.ToString() : dac.TextBox28.Text = dr.Cells(2).Value.ToString() : dac.TextBox3.Text = dr.Cells(3).Value.ToString() : dac.TextBox4.Text = dr.Cells(4).Value.ToString()
            dac.TextBox5.Text = dr.Cells(5).Value.ToString() : dac.TextBox6.Text = dr.Cells(6).Value.ToString() : dac.TextBox7.Text = dr.Cells(7).Value.ToString() : dac.TextBox8.Text = dr.Cells(8).Value.ToString()
            dac.TextBox9.Text = dr.Cells(9).Value.ToString() : dac.TextBox10.Text = dr.Cells(10).Value.ToString() : dac.TextBox11.Text = dr.Cells(11).Value.ToString() : dac.TextBox12.Text = dr.Cells(12).Value.ToString()
            dac.TextBox13.Text = dr.Cells(13).Value.ToString() : dac.TextBox14.Text = dr.Cells(14).Value.ToString() : dac.TextBox1.Text = dr.Cells(15).Value.ToString() : dac.TextBox15.Text = dr.Cells(16).Value.ToString()
            dac.TextBox16.Text = dr.Cells(17).Value.ToString() : dac.TextBox17.Text = dr.Cells(18).Value.ToString() : dac.TextBox18.Text = dr.Cells(19).Value.ToString() : dac.TextBox19.Text = dr.Cells(20).Value.ToString()
            dac.TextBox20.Text = dr.Cells(21).Value.ToString() : dac.TextBox21.Text = dr.Cells(22).Value.ToString() : dac.TextBox23.Text = dr.Cells(24).Value.ToString() : dac.TextBox27.Text = dr.Cells(25).Value.ToString()
            dac.TextBox26.Text = dr.Cells(26).Value.ToString() : dac.TextBox25.Text = dr.Cells(27).Value.ToString() : dac.TextBox24.Text = dr.Cells(28).Value.ToString()
            '************************************************************************************************
        Catch ex As Exception
            MsgBox("ERROR" & ex.Message)
        End Try
    End Sub


    '**********************************************************

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        filt()

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        waitopen()
        getdata()
        waitclose()
    End Sub
End Class