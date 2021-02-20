﻿Imports System.Data.OleDb
Imports System.IO
Public Class ssalist
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = mainfrm.css
    '  Public cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath + "\Database1.accdb" '"\db_post.accdb"
    Public Sub GetData()
        Try
            '*******************************For Account Ditels**************************************
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT AcNo as [Account Number], CustmorName as [Account Holder Name],Gender, FatherName as [Father's Name], MotherName as [Mother's Name], AcType as [Account Type], PAN as [PAN], NominiName as [Nomini Name], CautionMoneyReceiptNo as [Receipt No], Address as [Full Address], Notes as [Notes], DOB as [Date Of Birth], PhoneNo as [Phone No], MobileNo as [Mobile No], Email as [Email ID], Photo , Signiture ,AcBal as [Account Balance ] from Custmor  order by CustmorName", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Custmor")
            '  myDA.Fill(myDataSet, "tb_user")
            DataGridView1.DataSource = myDataSet.Tables("Custmor").DefaultView
            ' DataGridView1.DataSource = myDataSet.Tables("tb_user").DefaultView
            con.Close()
            '***********************************For Account Balance Ditels************************************
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("select acno as [account number],custmorname as [account holder name],acbal as [account balance],dlt,dlt2,actype as [account type] from sbbal order by custmorname", con)
            Dim myda1 As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim mydataset1 As DataSet = New DataSet()
            myda1.Fill(mydataset1, "sbbal")
            DataGridView2.DataSource = mydataset1.Tables("sbbal").DefaultView
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub filt()
        Try
            '**************************for ac ditels****************************************
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT AcNo as [Account Number], CustmorName as [Account Holder Name],Gender, FatherName as [Father's Name], MotherName as [Mother's Name], AcType as [Account Type], PAN as [PAN],Adhar as [Adhar no] , NominiName as [Nomini Name], CautionMoneyReceiptNo as [Receipt No], Address as [Full Address], Notes as [Notes], DOB as [Date Of Birth], PhoneNo as [Phone No], MobileNo as [Mobile No], Email as [Email ID], Photo ,Signiture ,AcBal as [Account Balance] from Custmor where AcNo like '%" & SSA.account_no.Text & "%' and AcType = 'SS Account' order by CustmorName", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Custmor")
            DataGridView1.DataSource = myDataSet.Tables("Custmor").DefaultView
            con.Close()
            '**************************************fro ac balance ditels****************************
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT AcNo as [Account Number],CustmorName as [Account Holder Name],Acbal as [Account Balance],DLT,DLT2,AcType as [Account Type] from sbbal where AcNo like '%" & SSA.account_no.Text & "%' and AcType = 'SS Account' order by CustmorName", con)
            Dim myDA1 As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet1 As DataSet = New DataSet()
            myDA1.Fill(myDataSet1, "sbbal")
            DataGridView2.DataSource = myDataSet1.Tables("sbbal").DefaultView
            con.Close()

        Catch ex As Exception
            MessageBox.Show("File Not Found Or May Be :- " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
    Private Sub DataGridView1_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        waitopen()
        Try

            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
            '  Me.Hide()
            '  rdac.Hide()
            If Len(Trim(SSA.account_no.Text)) = 0 Then
                SSA.account_no.Text = dr.Cells(0).Value.ToString()
                SSA.AccountHolderName.Text = dr.Cells(1).Value.ToString()
                Dim data As Byte() = DirectCast(dr.Cells(16).Value, Byte())
                Dim ms As New MemoryStream(data)
                SSA.PictureEdit1.Image = Image.FromStream(ms)
                Dim data2 As Byte() = DirectCast(dr.Cells(17).Value, Byte())
                Dim ms2 As New MemoryStream(data2)
                SSA.PictureEdit2.Image = Image.FromStream(ms2)
                SSA.account_no.Focus()
                '   Exit Sub
            Else
                SSA.account_no.Text = dr.Cells(0).Value.ToString()
                SSA.AccountHolderName.Text = dr.Cells(1).Value.ToString()
                Dim data As Byte() = DirectCast(dr.Cells(16).Value, Byte())
                Dim ms As New MemoryStream(data)
                SSA.PictureEdit1.Image = Image.FromStream(ms)
                Dim data2 As Byte() = DirectCast(dr.Cells(17).Value, Byte())
                Dim ms2 As New MemoryStream(data2)
                SSA.PictureEdit2.Image = Image.FromStream(ms2)
            End If

            'rdac.Accountbal.Text = dr.Cells(17).Value.ToString()
            '*********************************************************************
            '*********************************************************************
            'Dim dr1 As DataGridViewRow = DataGridView2.SelectedRows(0)
            'rdac.Accountbal.Text = dr1.Cells(2).Value.ToString()
            'rdac.DLT.Text = dr1.Cells(3).Value.ToString()
            'rdac.DNT.Text = dr1.Cells(4).Value.ToString()
            '*******************************For verification*********************************
            UserAc.txtStudentID.Text = dr.Cells(0).Value.ToString()
            UserAc.txtStudentName.Text = dr.Cells(1).Value.ToString()
            If (dr.Cells(2).Value.ToString() = "Male") Then
                UserAc.rbMale.Checked = True
            End If
            If (dr.Cells(2).Value.ToString() = "Female") Then
                UserAc.rbFemale.Checked = True
            End If
            UserAc.txtFatherName.Text = dr.Cells(3).Value.ToString()
            UserAc.cmbCourse.Text = dr.Cells(4).Value.ToString()
            UserAc.cmbDepartment.Text = dr.Cells(5).Value.ToString()
            UserAc.txtSession.Text = dr.Cells(6).Value.ToString()
            UserAc.txtAdhar.Text = dr.Cells(7).Value.ToString()

            UserAc.txtRollNo.Text = dr.Cells(8).Value.ToString()
            UserAc.txtReceiptNo.Text = dr.Cells(9).Value.ToString()
            UserAc.txtTempAddress.Text = dr.Cells(10).Value.ToString()
            UserAc.txtPermanentAddress.Text = dr.Cells(11).Value.ToString()
            UserAc.dtpDOB.Text = dr.Cells(12).Value.ToString()
            UserAc.txtPhoneNo.Text = dr.Cells(13).Value.ToString()
            UserAc.txtMobileNo.Text = dr.Cells(14).Value.ToString()
            UserAc.txtEmail.Text = dr.Cells(15).Value.ToString()
            Dim data3 As Byte() = DirectCast(dr.Cells(16).Value, Byte())
            Dim ms3 As New MemoryStream(data3)
            UserAc.Picture.Image = Image.FromStream(ms3)
            Dim data4 As Byte() = DirectCast(dr.Cells(17).Value, Byte())
            Dim ms4 As New MemoryStream(data4)
            UserAc.PictureBox1.Image = Image.FromStream(ms4)
            UserAc.Acbal.Text = dr.Cells(18).Value.ToString()
            UserAc.btnUpdate_record.Enabled = False
            UserAc.btnDelete.Enabled = False
            UserAc.btnSave.Enabled = False

            '************************************************************************************************
            MsgBox("choose Account balance Ditels")
            Try
                con = New OleDbConnection(cs)
                con.Open()
                cmd = New OleDbCommand("SELECT AcNo as [Account Number],CustmorName as [Account Holder Name],Acbal as [Account Balance],DLT,DLT2,AcType as [Account Type] from sbbal where AcNo = '" & SSA.account_no.Text & "'and AcType = 'SS Account' order by CustmorName", con)
                Dim myDA1 As OleDbDataAdapter = New OleDbDataAdapter(cmd)
                Dim myDataSet1 As DataSet = New DataSet()
                myDA1.Fill(myDataSet1, "sbbal")
                DataGridView2.DataSource = myDataSet1.Tables("sbbal").DefaultView
                con.Close()
            Catch ex As Exception
                MsgBox("Error in filter for ac balance " & ex.Message)
            End Try
            DataGridView2.Enabled = True

        Catch ex As Exception
            MsgBox("ERROR" & ex.Message)
        End Try
        waitclose()
    End Sub
    Private Sub DataGridView2_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView2.RowHeaderMouseClick
        waitopen()
        Try

            ' Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
            Me.Hide()
            SSA.Show()
            'rdac.AccountHolderName.Text = dr.Cells(1).Value.ToString()
            'Dim data As Byte() = DirectCast(dr.Cells(15).Value, Byte())
            'Dim ms As New MemoryStream(data)
            'rdac.PictureEdit1.Image = Image.FromStream(ms)
            'Dim data2 As Byte() = DirectCast(dr.Cells(16).Value, Byte())
            'Dim ms2 As New MemoryStream(data2)
            'rdac.PictureEdit2.Image = Image.FromStream(ms2)
            ' rdac.Accountbal.Text = dr.Cells(17).Value.ToString()
            '*********************************************************************
            '*********************************************************************
            Dim dr1 As DataGridViewRow = DataGridView2.SelectedRows(0)
            SSA.Accountbal.Text = dr1.Cells(2).Value.ToString()
            SSA.DLT.Text = dr1.Cells(3).Value.ToString()
            SSA.DNT.Text = dr1.Cells(4).Value.ToString()



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        waitclose()
    End Sub
    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        MsgBox("Choose Ac ditel first")
    End Sub

    Private Sub ssalist_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class