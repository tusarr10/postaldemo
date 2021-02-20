Imports System.Data.OleDb
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
'*************************wrong in withsdrow***********************
Public Class SBAc
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim gender As String
    Dim cs As String = mainfrm.css
    '   Public cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath + "\Database1.accdb" '"\db_post.accdb"
    Dim x, y, z As Double
    Dim withamt, depoamt, transtype As String
    Sub resetall()
        account_no.Text = ""
        AccountHolderName.Text = ""
        NameOfDepositer.Text = ""
        tranfamt.Text = ""
        Remark.Text = ""
        BalAfterTrans.Text = ""
        Accountbal.Text = ""
        PictureEdit1.Image = My.Resources.Photo
        PictureEdit2.Image = My.Resources.Photo


    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Label7.Text = "Withdrowal Amount "
        reset2()
        resetall()

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Label7.Text = "Deposit Amount "
        reset2()
        resetall()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        waitopen() : x = 0 & Accountbal.Text
        y = 0 & tranfamt.Text
        If RadioButton1.Checked Then
            z = x - y
            BalAfterTrans.Text = z.ToString
            withamt = y.ToString
            depoamt = 0
            transtype = "Withdrowal"
        Else
            z = x + y
            BalAfterTrans.Text = z.ToString
            depoamt = y.ToString
            withamt = 0
            transtype = "Deposit"

        End If
        btnSave.Enabled = True
        waitclose()
    End Sub

    Private Sub SBAc_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Alt + Keys.N Then
            btnNewRecord.PerformClick()
        ElseIf e.KeyCode = Keys.Alt + Keys.S Then
            btnSave.PerformClick()
        ElseIf e.KeyCode = Keys.Alt + Keys.U Then
            btnUpdate_record.PerformClick()
        ElseIf e.KeyCode = Keys.Alt + Keys.G Then
            Button3.PerformClick()
        ElseIf e.KeyCode = Keys.Alt + Keys.V Then
            Button1.PerformClick()
        ElseIf e.KeyCode = Keys.Alt + Keys.C Then
            btnDelete.PerformClick()
        ElseIf e.KeyCode = Keys.Alt + Keys.F Then
            Button2.PerformClick()
        ElseIf e.KeyCode = Keys.Alt + Keys.D Then
            RadioButton2.PerformClick()
        ElseIf e.KeyCode = Keys.Alt + Keys.W Then
            RadioButton1.PerformClick()
            'End If
        End If
    End Sub

    Private Sub SBAc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton2.Checked = True
        Label7.Text = " Deposit Amount "
        reset2()
        resetall()
        '  reset()
        to_date.Format = DateTimePickerFormat.Custom
        to_date.CustomFormat = "dd MMMM yyyy"
        to_date.Text = mainfrm.LabelControl2.Text
        DLT.Format = DateTimePickerFormat.Custom
        DLT.CustomFormat = "dd MMMM yyyy"
        DNT.Format = DateTimePickerFormat.Custom
        DNT.CustomFormat = "dd MMMM yyyy"
    End Sub
    Sub reset()
        Button1.Enabled = False
        btnSave.Enabled = False
        btnDelete.Enabled = False
        btnNewRecord.Enabled = False
        btnUpdate_record.Enabled = False
        account_no.Enabled = False

    End Sub
    Sub reset2()
        Button1.Enabled = True
        btnSave.Enabled = False
        btnDelete.Enabled = True
        btnNewRecord.Enabled = True
        btnUpdate_record.Enabled = False
        account_no.Enabled = True

    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        '********************************dissable all buttyon and textbox and make a report and print it then clear all textbox ********************************
        waitopen()
        Try
          
            If RadioButton1.Checked Then
                z = x - y
                BalAfterTrans.Text = z.ToString
                withamt = y.ToString
                depoamt = 0
                transtype = "Withdrowal"
            Else
                z = x + y
                BalAfterTrans.Text = z.ToString
                depoamt = y.ToString
                withamt = 0
                transtype = "Deposit"

            End If
            '***************************Save Data in SB journal ***************************************
            con = New OleDbConnection(cs)
            con.Open()
            Dim cb As String
            cb = "insert into Savingac(AcNo,CustmorName,depositerName,todate,BBT,transType,transAmt,DNT,DLT,Notes,AcBal)VALUES('" & account_no.Text & "','" & AccountHolderName.Text & "','" & NameOfDepositer.Text & "','" & to_date.Text & "','" & Accountbal.Text & "','" & transtype.ToString & "','" & tranfamt.Text & "','" & DNT.Text & "','" & DLT.Text & "','" & Remark.Text.ToString & "','" & BalAfterTrans.Text & "')"
            cmd = New OleDbCommand(cb)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()
            '***************************update acbal in sbbal journal by AcNo ***************************************
            con = New OleDbConnection(cs)
            con.Open()
            Dim cb1 As String = "update sbbal set DLT='" & to_date.Text & "',DLT2='" & DLT.Text & "',Acbal='" & BalAfterTrans.Text & "' where AcNo= '" & account_no.Text & "'"
            cmd = New OleDbCommand(cb1)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()
            '******************************update to userac main balance *********************************************
            con = New OleDbConnection(cs)
            con.Open()
            Dim cb2 As String = "update Custmor set AcBal='" & BalAfterTrans.Text & "' where AcNo= '" & account_no.Text & "'"
            cmd = New OleDbCommand(cb2)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()
            '****************************************End*************************************************
            '****************************************Update BO journal **********************************
            con = New OleDbConnection(cs)
            con.Open()
            Dim cb3 As String = "insert into CMB(ACNO,Name,acType,today,Transtype,Amount,fine,Notes)VALUES('" & account_no.Text & "','" & AccountHolderName.Text & "','Saving Account','" & to_date.Text & "','" & transtype.ToString & "','" & tranfamt.Text & "','00','" & Remark.Text.ToString & "')"
            cmd = New OleDbCommand(cb3)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()
            '**********************************END********************************************************
            ' ************************************Update transction details *********************************************
            con = New OleDbConnection(cs)
            con.Open()
            Dim cb4 As String = "insert into transdetail(d_ate,AccountType,accountNumber,AccountHolderName,deposit,withdrow,balance,DLT,remark)VALUES('" & to_date.Text & "','Saving Account','" & account_no.Text & "','" & AccountHolderName.Text & "','" & tranfamt.Text & "','00','" & BalAfterTrans.Text & "','" & DLT.Text & "','" & Remark.Text.ToString & "')"

            Dim cb5 As String = "insert into transdetail(d_ate,AccountType,accountNumber,AccountHolderName,withdrow,deposit,balance,DLT,remark)VALUES('" & to_date.Text & "','Saving Account','" & account_no.Text & "','" & AccountHolderName.Text & "','" & tranfamt.Text & "','00','" & BalAfterTrans.Text & "','" & DLT.Text & "','" & Remark.Text.ToString & "')"
            If transtype = "Deposit" Then
                cmd = New OleDbCommand(cb4)
                cmd.Connection = con
                cmd.ExecuteNonQuery()
                con.Close()
            Else
                cmd = New OleDbCommand(cb5)
                cmd.Connection = con
                cmd.ExecuteNonQuery()
                con.Close()
            End If
            '****************************************END***********************************************************************
            '*********************************************Update Bo Balance ***********************************************
            con = New OleDbConnection(cs)
            con.Open()
            Dim xbal As Double
            Dim avbal As Double = mainfrm.HyperlinkLabelControl1.Text
            Dim newbal As Double
            If transtype = "Deposit" Then
                newbal = avbal + tranfamt.Text
                mainfrm.HyperlinkLabelControl1.Text = newbal
                Dim cb6 As String = "update CashSetting set AvlBal='" & newbal.ToString & "' where D_ate= '" & mainfrm.LabelControl2.Text & "'"
                cmd = New OleDbCommand(cb6)
                cmd.Connection = con
                cmd.ExecuteNonQuery()
                con.Close()
            Else
                Try
                    newbal = avbal - tranfamt.Text
                        mainfrm.HyperlinkLabelControl1.Text = newbal
                        Dim cb7 As String = "update CashSetting set AvlBal='" & newbal.ToString & "' where D_ate= '" & mainfrm.LabelControl2.Text & "'"
                        cmd = New OleDbCommand(cb7)
                        cmd.Connection = con
                        cmd.ExecuteNonQuery()
                        con.Close()


                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                
            End If
            '***************************************************END***********************************************

            ACBAL.Text = Accountbal.Text
            MsgBox("Saved")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        btnSave.Enabled = False
        waitclose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        waitopen() : sbaclist.MdiParent = mainfrm
        sbaclist.WindowState = FormWindowState.Normal
        sbaclist.Show()
        sbaclist.GetData()
        sbaclist.filt()
        btnSave.Enabled = False
        btnUpdate_record.Enabled = False

        ACBAL.Text = Accountbal.Text
        waitclose()
    End Sub

    Private Sub btnNewRecord_Click(sender As Object, e As EventArgs) Handles btnNewRecord.Click
        waitopen() : resetall()
        waitclose()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        waitopen()
        UserAc.GroupBox1.Enabled = False
        UserAc.gropbox2.Enabled = False
        UserAc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        UserAc.Show()
        waitclose()
    End Sub

    Private Sub NameOfDepositer_TextChanged(sender As Object, e As EventArgs) Handles NameOfDepositer.TextChanged
        ACBAL.Text = Accountbal.Text
    End Sub

    Private Sub PictureEdit1_Click(sender As Object, e As EventArgs) Handles PictureEdit1.Click
        Try
            PhotoShow.MdiParent = mainfrm
            PhotoShow.Show()
            PhotoShow.PictureEdit1.Image = PictureEdit1.Image
            PhotoShow.PictureEdit1.Properties.AllowZoomOnMouseWheel = DevExpress.Utils.DefaultBoolean.True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PictureEdit2_Click(sender As Object, e As EventArgs) Handles PictureEdit2.Click
        Try
            ImageShow.MdiParent = mainfrm

            ImageShow.Show()
            ImageShow.PictureEdit1.Image = PictureEdit2.Image
            ImageShow.PictureEdit1.Properties.AllowZoomOnMouseWheel = DevExpress.Utils.DefaultBoolean.True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_record_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton1_Click(sender As Object, e As EventArgs) Handles RadioButton1.Click
        resetall()
    End Sub

    Private Sub RadioButton2_Click(sender As Object, e As EventArgs) Handles RadioButton2.Click
        resetall()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        waitopen() : pressentr() : waitclose()

    End Sub
    Sub pressentr()
        sbaclist.MdiParent = mainfrm
        sbaclist.WindowState = FormWindowState.Normal
        'sbaclist.Show()
        'sbaclist.GetData()
        sbaclist.filt()
        '********** short listed  ********************
        Try

            Dim dr As DataGridViewRow = sbaclist.DataGridView1.Rows(0)
            '  Me.Hide()
            '  SBAc.Hide()
            If Len(Trim(account_no.Text)) = 0 Then
                account_no.Text = dr.Cells(0).Value.ToString()
                AccountHolderName.Text = dr.Cells(1).Value.ToString()
                Dim data As Byte() = DirectCast(dr.Cells(16).Value, Byte())
                Dim ms As New MemoryStream(data)
                PictureEdit1.Image = Image.FromStream(ms)
                Dim data2 As Byte() = DirectCast(dr.Cells(17).Value, Byte())
                Dim ms2 As New MemoryStream(data2)
                PictureEdit2.Image = Image.FromStream(ms2)
                account_no.Focus()
                ' Exit Sub
            Else
                account_no.Text = dr.Cells(0).Value.ToString()
                AccountHolderName.Text = dr.Cells(1).Value.ToString()
                Dim data As Byte() = DirectCast(dr.Cells(16).Value, Byte())
                Dim ms As New MemoryStream(data)
                PictureEdit1.Image = Image.FromStream(ms)
                Dim data2 As Byte() = DirectCast(dr.Cells(17).Value, Byte())
                Dim ms2 As New MemoryStream(data2)
                PictureEdit2.Image = Image.FromStream(ms2)
            End If

            '**************************
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
            '****************************

            Dim dr1 As DataGridViewRow = sbaclist.DataGridView2.Rows(0)
            Accountbal.Text = dr1.Cells(2).Value.ToString()
            DLT.Text = dr1.Cells(3).Value.ToString()
            DNT.Text = dr1.Cells(4).Value.ToString()
        Catch ex As Exception
            MsgBox("ERROR = Account Does Not Exist ")
            resetall()


        End Try

        '************** End short listed ************

        btnSave.Enabled = False
        btnUpdate_record.Enabled = False

        ACBAL.Text = Accountbal.Text
    End Sub

    Private Sub account_no_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles account_no.MouseDoubleClick
        pressentr()
    End Sub

    Private Sub Button3_Enter(sender As Object, e As EventArgs)
        pressentr()

    End Sub

    Private Sub tranfamt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tranfamt.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            
            End If
        End If
    End Sub

    Private Sub btnUpdate_record_Click_1(sender As Object, e As EventArgs) Handles btnUpdate_record.Click

    End Sub

    Private Sub Button3_Enter_1(sender As Object, e As EventArgs) Handles Button3.Enter
        waitopen()
        pressentr() : waitclose()
    End Sub
End Class