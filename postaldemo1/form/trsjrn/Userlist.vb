Imports System.Data.OleDb
Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel

Public Class Userlist
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = mainfrm.css
    'Public cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath + "\Database1.accdb" ' "\db_post.accdb"
    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        txtStudentName.Text = ""
        ' cmbCourse.Text = ""
        cmbDepartment.Text = ""
        cmbCourse1.Text = ""
        cmbDepartment1.Text = ""
        cmbSession.Text = ""
        GetData()
    End Sub
    Public Sub GetData()
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT AcNo as [Account Number], CustmorName as [Custmor Name],Gender, FatherName as [Father's Name], MotherName as [Mother's Name], AcType, PAN as [PAN Card], Adhar as [Adhar No], NominiName as [Nomini Name], CautionMoneyReceiptNo as [Caution Money Receipt No], Address as [Temporary Address], Notes as [Permanent Address], DOB, PhoneNo as [Phone No], MobileNo as [Mobile No], Email as [Email ID], Photo , Signiture ,AcBal as [Account Balance ] from Custmor  order by CustmorName", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Custmor")
            '  myDA.Fill(myDataSet, "tb_user")
            DataGridView1.DataSource = myDataSet.Tables("Custmor").DefaultView
            ' DataGridView1.DataSource = myDataSet.Tables("tb_user").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub txtStudentName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStudentName.TextChanged
        Try
            DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(GetType(WaitForm1))

        Catch

        End Try
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT AcNo as [Account No], CustmorName as [Custmor Name],Gender, FatherName as [Father's Name], MotherName as [Mother's Name], AcType, PAN as [PAN],Adhar as [Adhar No], NominiName as [Nomini Name], CautionMoneyReceiptNo as [Money Receipt No], Address as [Temporary Address], Notes as [Permanent Address], DOB, PhoneNo as [Phone No], MobileNo as [Mobile No], Email as [Email ID], Photo ,Signiture ,AcBal as [Account Balance] from Custmor where CustmorName like '%" & txtStudentName.Text & "%' order by CustmorName", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Custmor")
            DataGridView1.DataSource = myDataSet.Tables("Custmor").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Try
            DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm()
        Catch

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
    Private Sub DataGridView1_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        waitopen()

        Try
            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
            Me.Hide()
            UserAc.MdiParent = mainfrm
            UserAc.WindowState = FormWindowState.Normal
            UserAc.Show()
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
            UserAc.txtAdhar.Text = dr.Cells(7).Value.ToString
            UserAc.txtRollNo.Text = dr.Cells(8).Value.ToString()
            UserAc.txtReceiptNo.Text = dr.Cells(9).Value.ToString()
            UserAc.txtTempAddress.Text = dr.Cells(10).Value.ToString()
            UserAc.txtPermanentAddress.Text = dr.Cells(11).Value.ToString()
            UserAc.dtpDOB.Text = dr.Cells(12).Value.ToString()
            UserAc.txtPhoneNo.Text = dr.Cells(13).Value.ToString()
            UserAc.txtMobileNo.Text = dr.Cells(14).Value.ToString()
            UserAc.txtEmail.Text = dr.Cells(15).Value.ToString()
            Dim data As Byte() = DirectCast(dr.Cells(16).Value, Byte())
            Dim ms As New MemoryStream(data)
            UserAc.Picture.Image = Image.FromStream(ms)
            Dim data2 As Byte() = DirectCast(dr.Cells(17).Value, Byte())
            Dim ms2 As New MemoryStream(data2)
            UserAc.PictureBox1.Image = Image.FromStream(ms2)
            UserAc.Acbal.Text = dr.Cells(18).Value.ToString()
            'UserAc.btnUpdate_record.Enabled = True
            'UserAc.btnDelete.Enabled = True
            'UserAc.btnSave.Enabled = False
            'UserAc.Button3.Enabled = True
            'If My.Settings.usertype.ToString = "Admin" Then
            UserAc.btnUpdate_record.Enabled = True
            UserAc.btnDelete.Enabled = True
            '  Else
            UserAc.btnUpdate_record.Enabled = True
            UserAc.btnDelete.Enabled = True
            '  End If

            UserAc.btnSave.Enabled = False
            UserAc.Button3.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        waitclose()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If Len(Trim(cmbSession.Text)) = 0 Then
                MessageBox.Show("Please select session", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbSession.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbCourse1.Text)) = 0 Then
                MessageBox.Show("Please select course", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbCourse1.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbDepartment1.Text)) = 0 Then
                MessageBox.Show("Please select AcType", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbDepartment1.Focus()
                Exit Sub
            End If
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT AcNo as [Account Number], CustmorName as [Custmor Name],Gender, FatherName as [Father's Name], Course, AcType, PAN as [PAN], Adhar as [Adhar No], NominiName as [Nomini], CautionMoneyReceiptNo as [Caution Money Receipt No], Address as [Temporary Address], Notes as [Permanent Address], DOB, PhoneNo as [Phone No], MobileNo as [Mobile No], Email as [Email ID], Photo ,Signiture ,AcBal as [Account Balance] from Custmor where AcType= '" & cmbDepartment1.Text & "' and Course='" & cmbCourse1.Text & "' and PAN='" & cmbSession.Text & "' order by CustmorName", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Custmor")
            DataGridView1.DataSource = myDataSet.Tables("Custmor").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExportExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click
        Dim rowsTotal, colsTotal As Short
        Dim I, j, iC As Short
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim xlApp As New Excel.Application
        Try
            Dim excelBook As Excel.Workbook = xlApp.Workbooks.Add
            Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
            xlApp.Visible = True

            rowsTotal = DataGridView1.RowCount - 1
            colsTotal = DataGridView1.Columns.Count - 1
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = DataGridView1.Columns(iC).HeaderText
                Next
                For I = 0 To rowsTotal - 1
                    For j = 0 To colsTotal
                        .Cells(I + 2, j + 1).value = DataGridView1.Rows(I).Cells(j).Value
                    Next j
                Next I
                .Rows("1:1").Font.FontStyle = "Bold"
                .Rows("1:1").Font.Size = 12

                .Cells.Columns.AutoFit()
                .Cells.Select()
                .Cells.EntireColumn.AutoFit()
                .Cells(1, 1).Select()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'RELEASE ALLOACTED RESOURCES
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            xlApp = Nothing
        End Try
    End Sub

    Private Sub Userlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(GetType(WaitForm1))

        Catch

        End Try

        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("SELECT AcNo as [Account No], CustmorName as [Custmor Name],Gender, FatherName as [Father's Name], MotherName as [Mother's Name], AcType, PAN as [PAN],Adhar as [Adhar No], NominiName as [Nomini Name], CautionMoneyReceiptNo as [Money Receipt No], Address as [Temporary Address], Notes as [Permanent Address], DOB, PhoneNo as [Phone No], MobileNo as [Mobile No], Email as [Email ID], Photo ,Signiture ,AcBal as [Account Balance] from Custmor where AcNo like '%" & TextBox1.Text & "%' order by CustmorName", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Custmor")
            DataGridView1.DataSource = myDataSet.Tables("Custmor").DefaultView
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Try
            DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm()
        Catch

        End Try
    End Sub
End Class