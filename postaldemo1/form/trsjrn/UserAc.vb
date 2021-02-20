Imports System.Data.OleDb
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports Dapper
Public Class UserAc
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = mainfrm.css
    Dim gender As String

    Private Sub UserAc_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Alt + Keys.N Then
            btnNewRecord.PerformClick()
        ElseIf e.KeyCode = Keys.Alt + Keys.S Then
            btnSave.PerformClick()
        ElseIf e.KeyCode = Keys.Alt + Keys.U Then
            btnUpdate_record.PerformClick()
        ElseIf e.KeyCode = Keys.Alt + Keys.T Then
            Button3.PerformClick()
        ElseIf e.KeyCode = Keys.Alt + Keys.F Then
            Button1.PerformClick()
        End If
    End Sub
    'Public cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath + "\Database1.accdb" '"\db_post.accdb"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpDOB.Format = DateTimePickerFormat.Custom
        dtpDOB.CustomFormat = "dd MMMM yyyy"
        If My.Settings.usertype.ToString = "Admin" Then
            btnUpdate_record.Enabled = True
            Acbal.Enabled = True
        Else
            btnUpdate_record.Enabled = True
            Acbal.Enabled = True
        End If
        
    End Sub
    Private Sub Browse_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Browse.Click
        waitopen()
        Try
            With OpenFileDialog1
                .Filter = ("Images |*.png; *.bmp; *.jpg;*.jpeg; *.gif;")
                .FilterIndex = 4
            End With
            'Clear the file name
            OpenFileDialog1.FileName = ""
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Picture.Image = Image.FromFile(OpenFileDialog1.FileName)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
        waitclose()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        waitopen()
        Userlist.MdiParent = mainfrm
        Userlist.WindowState = FormWindowState.Normal
        Userlist.Show()
        Userlist.GetData()
        Userlist.txtStudentName.Text = ""
        ' Userlist.cmbCourse.Text = ""
        '  Userlist.cmbCourse1.Text = ""
        Userlist.cmbDepartment.Text = ""
        Userlist.cmbDepartment1.Text = ""
        Userlist.cmbSession.Text = ""
        waitclose()
    End Sub


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        waitopen()
        Acbal.Enabled = False
        Try
            If Len(Trim(txtStudentName.Text)) = 0 Then
                MessageBox.Show("Please enter custmor name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtStudentName.Focus()
                Exit Sub
            End If
            If rbMale.Checked = False And rbFemale.Checked = False Then
                MessageBox.Show("Please select gender", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If Len(Trim(txtFatherName.Text)) = 0 Then
                MessageBox.Show("Please enter father's name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtFatherName.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbCourse.Text)) = 0 Then
                MessageBox.Show("Please select MotherName", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbCourse.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbDepartment.Text)) = 0 Then
                MessageBox.Show("Please select AcType", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbDepartment.Focus()
                Exit Sub
            End If
            If Len(Trim(txtRollNo.Text)) = 0 Then
                MessageBox.Show("Please enter class nomini name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtRollNo.Focus()
                Exit Sub
            End If
            If Len(Trim(txtReceiptNo.Text)) = 0 Then
                MessageBox.Show("Please enter receipt no.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtReceiptNo.Focus()
                Exit Sub
            End If
            If Len(Trim(txtTempAddress.Text)) = 0 Then
                MessageBox.Show("Please enter temporary address", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtTempAddress.Focus()
                Exit Sub
            End If
            If Len(Trim(txtPermanentAddress.Text)) = 0 Then
                MessageBox.Show("Please enter Notes", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPermanentAddress.Focus()
                Exit Sub
            End If
            If Len(Trim(txtMobileNo.Text)) = 0 Then
                MessageBox.Show("Please enter mobile no.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtMobileNo.Focus()
                Exit Sub
            End If
            If Len(Trim(txtAdhar.Text)) = 0 Then
                MessageBox.Show("Please enter Adhar no.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtAdhar.Focus()
                Exit Sub
            End If
            If rbMale.Checked = True Then
                gender = rbMale.Text
            End If
            If rbFemale.Checked = True Then
                gender = rbFemale.Text
            End If
            '*****************************************************************End**************************************************
            '*****************************************************************start*****************************************************************
            txtStudentID.Text = "ACNo-" & TextBox1.Text
            con = New OleDbConnection(cs)
            con.Open()
            Dim cb As String = "insert into Custmor(AcNo, CustmorName, FatherName, MotherName, AcType, PAN, Adhar, NominiName, CautionMoneyReceiptNo, Address, Notes, DOB, PhoneNo, MobileNo, Email, Photo, gender , Signiture ,AcBal ) VALUES('" & txtStudentID.Text & "','" & txtStudentName.Text & "','" & txtFatherName.Text & "','" & cmbCourse.Text & "','" & cmbDepartment.Text & "','" & txtSession.Text & "','" & txtAdhar.Text & "','" & txtRollNo.Text & "','" & txtReceiptNo.Text & "','" & txtTempAddress.Text & "','" & txtPermanentAddress.Text & "','" & dtpDOB.Text & "','" & txtPhoneNo.Text & "','" & txtMobileNo.Text & "','" & txtEmail.Text & "',@image,'" & gender & "', @image2 ,'" & Acbal.Text & "')"
            cmd = New OleDbCommand(cb)
            cmd.Connection = con

            Dim ms As New MemoryStream()
            Dim bmpImage As New Bitmap(Picture.Image)
            bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim data As Byte() = ms.GetBuffer()
            Dim p As New OleDbParameter("@image", OleDbType.VarBinary)
            p.Value = data

            Dim ms2 As New MemoryStream()
            Dim bmpimage2 As New Bitmap(PictureBox1.Image)
            bmpimage2.Save(ms2, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim data2 As Byte() = ms2.GetBuffer()
            Dim q As New OleDbParameter("@image2", OleDbType.VarBinary)
            q.Value = data2

            cmd.Parameters.Add(p)
            cmd.Parameters.Add(q)
            cmd.ExecuteNonQuery()
            con.Close()
            con = New OleDbConnection(cs)
            con.Open()
            Dim cb1 As String = "insert into sbbal(AcNo,CustmorName,Acbal,DLT,DLT2,AcType) VALUES('" & txtStudentID.Text & "','" & txtStudentName.Text & "','" & Acbal.Text & "','" & DateAndTime.Today & "','" & DateAndTime.Today & "','" & cmbDepartment.Text & "')"
            cmd = New OleDbCommand(cb1)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()
            'con = New OleDbConnection(cs)
            'con.Open()
            'Dim cb2 As String = "insert into Cards_student(StudentID,Status) VALUES('" & txtStudentID.Text & "','No')"
            'cmd = New OleDbCommand(cb2)
            'cmd.Connection = con
            'cmd.ExecuteNonQuery()
            'con.Close()
            'con = New OleDbConnection(cs)
            'con.Open()
            'Dim cb3 As String = "insert into NoDues_Student(StudentID,Status) VALUES('" & txtStudentID.Text & "','No')"
            'cmd = New OleDbCommand(cb3)
            'cmd.Connection = con
            'cmd.ExecuteNonQuery()
            'con.Close()
            MessageBox.Show("Successfully saved", " Student Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnSave.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        waitclose()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        waitopen()
        Try
            If MessageBox.Show("Do you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.Yes Then
                DeleteRecord()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        waitclose()
    End Sub

    Public Sub DeleteRecord()
        Try
            Dim RowsAffected As Integer = 0
            con = New OleDbConnection(cs)
            con.Open()
            Dim cq As String = "delete from Custmor where AcNo = '" & txtStudentID.Text & "'"
            cmd = New OleDbCommand(cq)
            cmd.Connection = con
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then
                MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Reset()
            Else
                MessageBox.Show("No record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Reset()
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
                con.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Sub Reset()
        txtAdhar.Text = ""
        txtStudentID.Text = ""
        gropbox2.Text = ""
        txtEmail.Text = ""
        Acbal.Text = ""
        txtFatherName.Text = ""
        txtMobileNo.Text = ""
        txtPermanentAddress.Text = ""
        txtPhoneNo.Text = ""
        txtReceiptNo.Text = ""
        txtRollNo.Text = ""
        txtSession.Text = ""
        txtStudentName.Text = ""
        txtTempAddress.Text = ""
        txtPermanentAddress.Text = ""
        cmbCourse.Text = ""
        dtpDOB.Text = Today
        cmbDepartment.Text = ""
        Picture.Image = My.Resources.Photo
        PictureBox1.Image = My.Resources.Photo

        rbMale.Checked = False
        rbFemale.Checked = False
        btnSave.Enabled = True
        btnDelete.Enabled = False
        btnUpdate_record.Enabled = False
        txtStudentName.Focus()
    End Sub

    Private Sub btnNewRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewRecord.Click
        waitopen()

        Reset()
        Acbal.Enabled = True
        waitclose()

    End Sub

    Private Sub btnUpdate_record_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate_record.Click
        waitopen()
        Try
            If Len(Trim(txtStudentName.Text)) = 0 Then
                MessageBox.Show("Please enter student name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtStudentName.Focus()
                Exit Sub
            End If
            If rbMale.Checked = False And rbFemale.Checked = False Then
                MessageBox.Show("Please select gender", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If Len(Trim(txtFatherName.Text)) = 0 Then
                MessageBox.Show("Please enter father's name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtFatherName.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbCourse.Text)) = 0 Then
                MessageBox.Show("Please select MotherName", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbCourse.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbDepartment.Text)) = 0 Then
                MessageBox.Show("Please select Account Type", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbDepartment.Focus()
                Exit Sub
            End If
            If Len(Trim(txtRollNo.Text)) = 0 Then
                MessageBox.Show("Please enter class roll no.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtRollNo.Focus()
                Exit Sub
            End If
            If Len(Trim(txtReceiptNo.Text)) = 0 Then
                MessageBox.Show("Please enter receipt no.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtReceiptNo.Focus()
                Exit Sub
            End If
            If Len(Trim(txtTempAddress.Text)) = 0 Then
                MessageBox.Show("Please enter temporary address", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtTempAddress.Focus()
                Exit Sub
            End If
            If Len(Trim(txtPermanentAddress.Text)) = 0 Then
                MessageBox.Show("Please enter Notes", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPermanentAddress.Focus()
                Exit Sub
            End If
            If Len(Trim(txtMobileNo.Text)) = 0 Then
                MessageBox.Show("Please enter mobile no.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtMobileNo.Focus()
                Exit Sub
            End If
            If Len(Trim(txtAdhar.Text)) = 0 Then
                MessageBox.Show("Please enter mobile no.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtAdhar.Focus()
                Exit Sub
            End If
            If rbMale.Checked = True Then
                gender = rbMale.Text
            End If
            If rbFemale.Checked = True Then
                gender = rbFemale.Text
            End If
            con = New OleDbConnection(cs)
            con.Open()
            Dim cb As String = "update Custmor set CustmorName='" & txtStudentName.Text & "',Fathername='" & txtFatherName.Text & "',MotherName='" & cmbCourse.Text & "',AcType='" & cmbDepartment.Text & "',PAN='" & txtSession.Text & "',Adhar='" & txtAdhar.Text & "',NominiName='" & txtRollNo.Text & "',CautionMoneyReceiptNo='" & txtReceiptNo.Text & "',Address='" & txtTempAddress.Text & "',Notes='" & txtPermanentAddress.Text & "',DOB=#" & dtpDOB.Text & "#,PhoneNo='" & txtPhoneNo.Text & "',MobileNo='" & txtMobileNo.Text & "',Email='" & txtEmail.Text & "',AcBal='" & Acbal.Text & "',Photo=@image,Signiture=@image2,Gender='" & gender & "' where AcNo= '" & txtStudentID.Text & "'"
            cmd = New OleDbCommand(cb)
            cmd.Connection = con
            Dim ms As New MemoryStream()
            Dim bmpImage As New Bitmap(Picture.Image)
            bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim data As Byte() = ms.GetBuffer()
            Dim p As New OleDbParameter("@image", OleDbType.VarBinary)
            p.Value = data

            Dim ms2 As New MemoryStream()
            Dim bmpimage2 As New Bitmap(PictureBox1.Image)
            bmpimage2.Save(ms2, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim data2 As Byte() = ms2.GetBuffer()
            Dim q As New OleDbParameter("@image2", OleDbType.VarBinary)
            q.Value = data2

            cmd.Parameters.Add(p)
            cmd.Parameters.Add(q)
            cmd.ExecuteNonQuery()
            con.Close()
            Try
                con = New OleDbConnection(cs)
                con.Open()
                Dim cb1 As String = "update sbbal set Acbal='" & Acbal.Text & "' where AcNo= '" & txtStudentID.Text & "'"
                cmd = New OleDbCommand(cb1)
                cmd.Connection = con
                cmd.ExecuteNonQuery()
                con.Close()
            Catch ex As Exception
                MsgBox("Error" & ex.Message)
            End Try
            MessageBox.Show("Successfully updated", " Student Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnUpdate_record.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        waitclose()
    End Sub

    Private Sub txtEmail_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtEmail.Validating
        Dim rEMail As New System.Text.RegularExpressions.Regex("^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$")
        If txtEmail.Text.Length > 0 Then
            If Not rEMail.IsMatch(txtEmail.Text) Then
                MessageBox.Show("invalid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtEmail.SelectAll()
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub txtMobileNo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtMobileNo.Validating
        If (txtMobileNo.TextLength > 10) Then
            MessageBox.Show("Only 10 digits are allowed", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtMobileNo.Focus()
        End If
    End Sub

    Private Sub txtMobileNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMobileNo.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPhoneNo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPhoneNo.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        waitopen()
        Try
            With OpenFileDialog1
                .Filter = ("Images |*.png; *.bmp; *.jpg;*.jpeg; *.gif;")
                .FilterIndex = 4
            End With
            'Clear the file name
            OpenFileDialog1.FileName = ""
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
        waitclose()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ImageShow.Show()
        Try
            ImageShow.PictureEdit1.Image = PictureBox1.Image
            ImageShow.PictureEdit1.Properties.AllowZoomOnMouseWheel = DevExpress.Utils.DefaultBoolean.True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Picture_Click(sender As Object, e As EventArgs) Handles Picture.Click
        '  PhotoShow.Show()
        PhotoShow.Show()

        Try
            PhotoShow.PictureEdit1.Image = Picture.Image
            PhotoShow.PictureEdit1.Properties.AllowZoomOnMouseWheel = DevExpress.Utils.DefaultBoolean.True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        waitopen()
        translist.MdiParent = mainfrm
        translist.WindowState = FormWindowState.Normal
        If cmbDepartment.Text.ToString = "Saving Account" Then
            translist.Show()
            translist.filt1()
        ElseIf cmbDepartment.Text.ToString = "Requiring Deposit" Then
            translist.Show()
            translist.filt11()
        ElseIf cmbDepartment.Text.ToString = "SS Account" Then
            translist.Show()
            translist.filt111()
        ElseIf cmbDepartment.Text.ToString = "Time Deposit" Then
            translist.Show()
            translist.filt1111()
        Else
            MsgBox("Choose Account Type")
        End If
        waitclose()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        waitopen()
        con = New OleDbConnection(cs)
        Dim comand As String
        If cmbDepartment.Text.ToString = "Time Deposit" Then
            comand = "SELECT AcNo , CustmorName ,depositerName , todate , BBT , transType, transAmt , DNT, DLT , AcBal , Notes  from td_ac where AcNo like '" & txtStudentID.Text & "%'ORDER BY DateValue(Format$(todate,'dd mmmm yyyy')) ASC" ' order by todate> Format$(todate,'yyyy dd mmmm') ASC"
            Try
                Dim list As List(Of Cls_TS_userdetails) = con.Query(Of Cls_TS_userdetails)(comand).ToList
                Using frm As printfrm = New printfrm()
                    frm.userrpt_TS_Print(list)
                    frm.ShowDialog()
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf cmbDepartment.Text.ToString = "Saving Account" Then
            comand = "SELECT AcNo , CustmorName ,depositerName , todate , BBT , transType, transAmt , DNT, DLT , AcBal , Notes  from Savingac where AcNo like '" & txtStudentID.Text & "%'ORDER BY  DateValue(Format$(todate,'dd mmmm yyyy')) ASC" ' ORDER BY todate> Format$(todate,'yyyy dd mmmm') ASC"
            Try
                Dim list As List(Of Cls_TS_userdetails) = con.Query(Of Cls_TS_userdetails)(comand).ToList
                Using frm As printfrm = New printfrm()
                    frm.userrpt_TS_Print(list)
                    frm.ShowDialog()
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf cmbDepartment.Text.ToString = "SS Account" Then
            comand = "SELECT ACNO , Name, Depositer , today, BBT ,Transtype,Amount , m_onth , balance ,fine , DLT, Notes from SSAC where ACNO like '" & txtStudentID.Text & "%'  ORDER BY  DateValue(Format$(today,'dd mmmm yyyy')) ASC"
            Try
                Dim list As List(Of Cls_RS_userdetails) = con.Query(Of Cls_RS_userdetails)(comand).ToList
                Using frm As printfrm = New printfrm()
                    frm.userrpt_RS_Print(list)
                    frm.ShowDialog()
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf cmbDepartment.Text.ToString = "Requiring Deposit" Then
            comand = "SELECT ACNO , Name, Depositer , today, BBT ,Transtype,Amount , m_onth , balance ,fine , DLT, Notes from Rdac where ACNO like '" & txtStudentID.Text & "%'ORDER BY  DateValue(Format$(today,'dd mmmm yyyy')) ASC" ' ORDER BY today> Format$(today,'yyyy dd mmmm') ASC"
            Try
                Dim list As List(Of Cls_RS_userdetails) = con.Query(Of Cls_RS_userdetails)(comand).ToList
                Using frm As printfrm = New printfrm()
                    frm.userrpt_RS_Print(list)
                    frm.ShowDialog()
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Choose Account Type")
        End If
        waitclose()
    End Sub
End Class
