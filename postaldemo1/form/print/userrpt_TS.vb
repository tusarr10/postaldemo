Imports DevExpress.XtraPrinting.BarCode
Imports DevExpress.XtraReports.UI
Public Class userrpt_TS
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        '''''''Call ''''''
        XrLabel3.Text = DateAndTime.DateString
        Try
            lblacno.Text = UserAc.txtStudentID.Text.ToString
            lblactype.Text = UserAc.cmbDepartment.Text.ToString
            lblname.Text = UserAc.txtStudentName.Text.ToString
            lblfmane.Text = UserAc.txtFatherName.Text.ToString.ToString
            lblmname.Text = UserAc.cmbCourse.Text.ToString
            lblnname.Text = UserAc.txtRollNo.Text.ToString
            lblpan.Text = UserAc.txtSession.Text.ToString
            lbladress.Text = UserAc.txtTempAddress.Text.ToString
            lbladhar.Text = UserAc.txtAdhar.Text.ToString
            lblemail.Text = UserAc.txtEmail.Text.ToString
            lblmobilenumber.Text = UserAc.txtMobileNo.Text.ToString
            lblbanance.Text = UserAc.Acbal.Text.ToString
            lbldob.Text = UserAc.dtpDOB.Text.ToString
            XrPictureBox1.Image = UserAc.Picture.Image
            XrPictureBox2.Image = UserAc.PictureBox1.Image
            If UserAc.rbMale.Checked = True Then
                lblgender.Text = "Male"
            End If
            If UserAc.rbFemale.Checked = True Then
                lblgender.Text = "female"
            End If
        Catch ex As Exception
            MsgBox("Probleam in geting result from Here" + ex.Message)
        End Try
    End Sub

    Public Sub GetintDatausrrpt_TS(ByVal data As List(Of Cls_TS_userdetails))
        ObjectDataSource1.DataSource = data
    End Sub

    Private Sub userrpt_TS_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Me.BeforePrint
        XrBarCode2.Text = lblacno.Text '+ " " + xlblName.Text
        XrBarCode2.Symbology = New Code128Generator()
        CType(XrBarCode2.Symbology, Code128Generator).CharacterSet = Code128Charset.CharsetB
        XrBarCode1.Symbology = New QRCodeGenerator()
        XrBarCode1.AutoModule = True
        XrBarCode1.Text = lblacno.Text + " NAME " + lblname.Text
        CType(XrBarCode1.Symbology, QRCodeGenerator).CompactionMode = QRCodeCompactionMode.AlphaNumeric
        CType(XrBarCode1.Symbology, QRCodeGenerator).ErrorCorrectionLevel = QRCodeErrorCorrectionLevel.H
        CType(XrBarCode1.Symbology, QRCodeGenerator).Version = QRCodeVersion.AutoVersion
    End Sub
End Class