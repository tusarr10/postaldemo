Imports System.Data.OleDb

Public Class new_account
    Dim cs As String = mainfrm.css
    Private Sub btnNewRecord_Click(sender As Object, e As EventArgs) Handles btnNewRecord.Click
        Reseet()
    End Sub

    Private Sub Reseet()
        TextBox1.Text = ""
        txtAdhar.Text = ""
        txtStudentID.Text = ""
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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        waitopen()
        ' write your method here
        Dim userMsg As String
        userMsg = Microsoft.VisualBasic.InputBox("Enter Transction ID !.", "Entry Form", "")
        Try
            UpdateData(userMsg)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            If rbMale.Checked = True Then
                gender = rbMale.Text
            End If
            If rbFemale.Checked = True Then
                gender = rbFemale.Text
            End If
            con = New OleDbConnection(cs)
            con.Open()
            Dim cb1 As String = "insert into New_ac(N_AME,CIF,ACNO,FNAME,D_ATE,aDDRESS,dob,aDHAR,PAN,NOMINI,GENDER,ACTYPE,NOTES,AMOUNT,rEFF_NO,mobile,recno) VALUES('" & txtStudentName.Text & "','" & txtEmail.Text & "','" & TextBox1.Text & "','" & txtFatherName.Text & "','" & dtpDOB.Text & "','" & txtTempAddress.Text & "','" & cmbCourse.Text & "','" & txtAdhar.Text & "','" & txtSession.Text & "','" & txtRollNo.Text & "','" & gender & "','" & cmbDepartment.Text & "','" & txtPermanentAddress.Text & "','" & Acbal.Text & "','" & txtPhoneNo.Text & "','" & txtMobileNo.Text & "','" & txtReceiptNo.Text & "')"
            cmd = New OleDbCommand(cb1)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Data Saved..", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Error" + ex.Message, MsgBoxStyle.Information)
        End Try


        waitclose()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        waitopen()

        Try
            UserAc.TextBox1.Text = TextBox1.Text
            UserAc.txtEmail.Text = txtEmail.Text
            UserAc.txtStudentName.Text = txtStudentName.Text
            If rbMale.Checked = True Then
                UserAc.rbMale.Checked = True

            End If
            If rbFemale.Checked = True Then
                UserAc.rbFemale.Checked = True

            End If
            UserAc.txtFatherName.Text = txtFatherName.Text
            UserAc.cmbCourse.Text = cmbCourse.Text
            UserAc.txtRollNo.Text = txtRollNo.Text
            UserAc.txtSession.Text = txtSession.Text
            UserAc.txtAdhar.Text = txtAdhar.Text
            UserAc.cmbDepartment.Text = cmbDepartment.Text
            UserAc.txtTempAddress.Text = txtTempAddress.Text
            UserAc.txtPermanentAddress.Text = txtPermanentAddress.Text()
            UserAc.dtpDOB.Text = dtpDOB.Text
            UserAc.txtPhoneNo.Text = txtPhoneNo.Text
            UserAc.txtReceiptNo.Text = txtReceiptNo.Text
            UserAc.txtMobileNo.Text = txtMobileNo.Text
            UserAc.Acbal.Text = Acbal.Text
            UserAc.MdiParent = mainfrm

            UserAc.WindowState = FormWindowState.Normal
            UserAc.Show()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        waitclose()

    End Sub
    Dim transtype As String

    Sub UpdateData(ByVal trid As String)
        '****************************************Update BO journal **********************************
        con = New OleDbConnection(cs)
        con.Open()
        ' Dim X As String = "VALUES('" & txtPhoneNo.Text & " ','" & txtStudentName.Text & "','" & cmbDepartment.Text & " ','" & dtpDOB.Text & "','" & transtype.T & "','" & Acbal.Text & "" ','""00""','"" 00""')"
        Dim cb3 As String = "insert into CMB(ACNO,Name,acType,today,Transtype,Amount,fine,Notes)VALUES('" & txtPhoneNo.Text & "','" & txtStudentName.Text & "','" & cmbDepartment.Text & "','" & dtpDOB.Text & "','Deposit','" & Acbal.Text & "','00',' " & trid & "')"
        cmd = New OleDbCommand(cb3)
        cmd.Connection = con
        cmd.ExecuteNonQuery()
        con.Close()
        '**********************************END********************************************************
        ' ************************************Update transction details *********************************************
        con = New OleDbConnection(cs)
        con.Open()
        Dim cb4 As String = "insert into transdetail(d_ate,AccountType,accountNumber,AccountHolderName,deposit,withdrow,balance,DLT,remark)VALUES('" & dtpDOB.Text & "','" & cmbDepartment.Text & "','" & txtPhoneNo.Text & "','" & txtStudentName.Text & "','" & Acbal.Text & "','00','" & Acbal.Text & "','New Account','" & trid & "')"
        cmd = New OleDbCommand(cb4)
        cmd.Connection = con
        cmd.ExecuteNonQuery()
        con.Close()
        '****************************************END***********************************************************************
    End Sub

    Private Sub new_account_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpDOB.Format = DateTimePickerFormat.Custom
        dtpDOB.CustomFormat = "dd MMMM yyyy"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        waitopen()
        newUserData.MdiParent = mainfrm
        newUserData.WindowState = FormWindowState.Normal
        newUserData.Show()
        waitclose()

    End Sub

    Private Sub btnUpdate_record_Click(sender As Object, e As EventArgs) Handles btnUpdate_record.Click
        waitopen()

        Try
            If rbMale.Checked = True Then
                gender = rbMale.Text
            End If
            If rbFemale.Checked = True Then
                gender = rbFemale.Text
            End If
            con = New OleDbConnection(cs)
            con.Open()                      'N_AME,CIF,ACNO,FNAME,D_ATE,aDDRESS,dob,aDHAR,PAN,                                                                                                                                                                                                                      NOMINI,GENDER,ACTYPE,NOTES,AMOUNT,rEFF_NO,mobile,recno) VALUE
            Dim cb As String = "update New_ac SET N_AME='" & txtStudentName.Text & "',CIF='" & txtEmail.Text & "',ACNO='" & TextBox1.Text & "',FNAME='" & txtFatherName.Text & "',D_ATE='" & dtpDOB.Text & "',aDDRESS='" & txtTempAddress.Text & "',dob='" & cmbCourse.Text & "',aDHAR='" & txtAdhar.Text & "',PAN='" & txtSession.Text & "',NOMINI='" & txtRollNo.Text & "',GENDER=" & gender & ",ACTYPE='" & cmbDepartment.Text & "',NOTES='" & txtPermanentAddress.Text & "',AMOUNT='" & Acbal.Text & "',rEFF_NO='" & txtPhoneNo.Text & "',mobile='" & txtMobileNo.Text & "',recno='" & txtReceiptNo.Text & "',id='" & txtStudentID.Text & "' where id= '" & txtStudentID.Text & "'"
            cmd = New OleDbCommand(cb)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Success")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        waitclose()

    End Sub
End Class