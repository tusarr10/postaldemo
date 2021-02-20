
Imports System.Data.OleDb
Imports System.IO
Public Class translist
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim cmd0 As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = mainfrm.css
    'Public cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath + "\Database1.accdb" '"\db_post.accdb"

    Public Sub GetData1()
        Try
            '*******************************For Account Ditels**************************************
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT AcNo as [Account Number], CustmorName as [Account Holder Name],depositerName as [depositer Name], todate as [Date of transction], BBT as [Balance Before Transction], transType as [Type Of Transction], transAmt as [Amount Of Transction], DNT as [Last Transction Date], DLT as [2_nd Last Transction Date], AcBal as [Account Balance], Notes as [Notes] from Savingac  order by CustmorName", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Savingac")
            '  myDA.Fill(myDataSet, "tb_user")
            DataGridView1.DataSource = myDataSet.Tables("Savingac").DefaultView
            ' DataGridView1.DataSource = myDataSet.Tables("tb_user").DefaultView
            con.Close()
            '***********************************For Account Balance Ditels************************************
          

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    '*************************************
    '*********************************************
   

    '*************************************************88
    '**************************************************


    Sub filt1()
        Try
            '**************************for sbac transction ditels****************************************
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT AcNo as [Account Number], CustmorName as [Account Holder Name],depositerName as [depositer Name], todate as [Date of transction], BBT as [Balance Before Transction], transType as [Type Of Transction], transAmt as [Amount Of Transction], DNT as [Last Transction Date], DLT as [2_nd Last Transction Date], AcBal as [Account Balance], Notes as [Notes] from Savingac where AcNo like '" & UserAc.txtStudentID.Text & "%' ORDER BY CustmorName , DateValue(Format$(todate,'dd mmmm yyyy')) ASC", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Savingac")
            DataGridView1.DataSource = myDataSet.Tables("Savingac").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show("File Not Found Or May Be :- " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub filt11()
        Try
            '**************************for rdac transction ditels****************************************
            con = New OleDbConnection(cs)
            con.Open()

            cmd = New OleDbCommand("SELECT ACNO as [Account Number], Name as [Name], Depositer as [Depositer Name], today as [Date of Transction], BBT as [Balance Before Trans],Transtype as [Type Of Transction],Amount as [Amount], m_onth as [For The Month Of], balance as [Balance],fine as [Fine], DLT as [DLT], Notes from Rdac where ACNO like '" & UserAc.txtStudentID.Text & "%' ORDER BY Name, DateValue(Format$(today,'dd mmmm yyyy')) ASC", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Rdac")
            DataGridView1.DataSource = myDataSet.Tables("Rdac").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show("File Not Found Or May Be :- " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub filt111()
        Try
            con = New OleDbConnection(cs)
            con.Open()

            cmd = New OleDbCommand("SELECT ACNO as [Account Number], Name as [Name], Depositer as [Depositer], today as [Date of transction], BBT as [Balance Before transction], Transtype as [Transction Type], Amount as [Amount], fine as [Fine], balance as [Balance], m_onth as [For The Month Of], DLT as [DLT], Notes from SSAC where ACNO like '" & UserAc.txtStudentID.Text & "%'ORDER BY Name ,DateValue(Format$(today,'dd mmmm yyyy')) ASC", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "SSAC")
            DataGridView1.DataSource = myDataSet.Tables("SSAC").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show("File Not Found Or May Be :- " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub filt1111()
        Try
            con = New OleDbConnection(cs)
            con.Open()
          
            cmd = New OleDbCommand("SELECT AcNo as [Account Number], CustmorName, depositerName, todate as [Date Of Transction], BBT as [Balance Before Transction], transType as [transction Type],transAmt as [Amount], DNT,DLT, AcBal as [Account Balance], Notes from td_ac where AcNo like '" & UserAc.txtStudentID.Text & "%' ORDER BY CustmorName ,DateValue(Format$(todate,'dd mmmm yyyy')) ASC", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "td_ac")
            DataGridView1.DataSource = myDataSet.Tables("td_ac").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show("File Not Found Or May Be :- " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    '**********************************Code for journal*******************************************************
    Sub filt2()
        Try
            '**************************for ac ditels****************************************
            con = New OleDbConnection(cs)
            con.Open()

            cmd = New OleDbCommand("SELECT ACNO as [Account Number], Name as [Account Holder Name], acType as [Account Type], today as [Date Of Transction],Transtype as [Transction Type], Amount, fine, Notes from CMB where today like '" & Bojurnal.DateTimePicker1.Text & "%' order by Name", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "CMB")
            DataGridView1.DataSource = myDataSet.Tables("CMB").DefaultView
            con.Close()


        Catch ex As Exception
            MessageBox.Show("File Not Found Or May Be :- " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub translist_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Alt + Keys.S Then
            Button1.PerformClick()

            'End If
        End If
    End Sub


    Private Sub translist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd MMMM yyyy"
        DataGridView1.GridColor = Color.Red

        DataGridView1.BackgroundColor = Color.Blue

        DataGridView1.ForeColor = Color.DarkGreen
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

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

    End Sub
 
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim d, g, f, h, i, j As Double

            h = 0 & TextBox2.Text
            i = 0 & TextBox4.Text
            j = 0 & TextBox7.Text
            d = 0 & TextBox1.Text
            g = 0 & TextBox5.Text
            f = 0 & TextBox3.Text
            TextBox6.Text = d + g + i + j + h - f


        Catch ex As Exception
            MsgBox("Error in calculetion" & ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        dac.WindowState = FormWindowState.Normal
        dac.Show()

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        waitopen()
        TextBox1.Text = 0
        TextBox2.Text = 0
        TextBox3.Text = 0
        TextBox4.Text = 0
        TextBox5.Text = 0
        TextBox6.Text = 0
        TextBox7.Text = 0
        Dim table As DataTable
        Try
            '**************************for ac ditels****************************************
            con = New OleDbConnection(cs)
            con.Open()

            cmd = New OleDbCommand("SELECT ACNO as [Account Number], Name as [Account Holder Name], acType as [AccountType], today as [Date Of Transction],Transtype as [TransctionType], Amount, fine, Notes from CMB where today like '" & DateTimePicker1.Text & "%' order by Name", con)

            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "CMB")
            DataGridView1.DataSource = myDataSet.Tables("CMB").DefaultView
            ' con.Close()
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            DataGridView1.AllowUserToAddRows = False

            Try
                table = myDataSet.Tables("CMB")
                If table.Rows.Count > 1 Then
                    Try
                        Dim wit, sad, ssd, rdd, tdd As String
                        sad = 0 & table.Compute("Sum(Amount)", "TransctionType = 'Deposit'  AND AccountType = 'Saving Account'")
                        TextBox1.Text = sad
                        ssd = 0 & table.Compute("Sum(Amount)", "TransctionType = 'Deposit'  AND AccountType = 'SS Account'")
                        TextBox7.Text = ssd
                        rdd = 0 & table.Compute("Sum(Amount)", "TransctionType = 'Deposit'  AND AccountType = 'Requiring Deposit'")
                        TextBox2.Text = rdd
                        tdd = 0 & table.Compute("Sum(Amount)", "TransctionType = 'Deposit'  AND AccountType = 'Time Deposit'")
                        TextBox4.Text = tdd
                        wit = 0 & table.Compute("Sum(Amount)", "TransctionType = 'Withdrowal'")
                        TextBox3.Text = wit
                    Catch ex As Exception
                        TextBox3.Text = 0
                    End Try

                    TextBox5.Text = table.Compute("Sum(fine)", "")
                ElseIf table.Rows.Count = 1 Then
                    Dim dr1 As DataGridViewRow = DataGridView1.Rows(0)
                    TextBox1.Text = dr1.Cells(5).Value.ToString()
                    TextBox5.Text = dr1.Cells(6).Value.ToString()
                    MsgBox("I can not reconize transction type")
                    Button2.Enabled = True

                Else
                    MessageBox.Show("No data found Try anather date")
                    TextBox1.Text = 0
                    TextBox5.Text = 0
                    TextBox3.Text = 0
                    TextBox2.Text = 0
                    TextBox4.Text = 0
                    TextBox6.Text = 0
                    TextBox7.Text = 0


                End If
                con.Close()
            Catch ex As Exception
                MsgBox("erron" & ex.Message)
            End Try
            Try
                Dim d, g, f, h, i, j As Double

                h = 0 & TextBox2.Text
                i = 0 & TextBox4.Text
                j = 0 & TextBox7.Text
                d = 0 & TextBox1.Text
                g = 0 & TextBox5.Text
                f = 0 & TextBox3.Text
                TextBox6.Text = d + g + i + j + h - f


            Catch ex As Exception
                MsgBox("Error in calculetion" & ex.Message)
            End Try
        Catch ex As Exception
            MessageBox.Show("File Not Found Or May Be :- " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        waitclose()
    End Sub

    Private Sub LabelControl1_Click(sender As Object, e As EventArgs) Handles LabelControl1.Click

    End Sub
End Class