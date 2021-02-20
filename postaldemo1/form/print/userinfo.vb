Imports DevExpress.XtraPrinting.BarCode
Imports DevExpress.XtraReports.UI
Public Class userinfo

    Public Sub GET_DATA(ByVal AcNo As String, ByVal acName As String, ByVal fthname As String, ByVal motname As String, ByVal nomname As String, ByVal ac_type As String, ByVal add_ress As String, ByVal adhar As String, ByVal bal As String, ByVal D_OB As String, ByVal email As String, ByVal mobno As String, ByVal g_ender As String, ByVal monrec As String, ByVal nots As String, ByVal paan As String, ByVal phno As String, ByVal photo As Image, ByVal sign As Image)
        xlblAcNo.Text = AcNo
        xlblName.Text = acName
        xlblfname.Text = fthname
        xlblmname.Text = motname
        xlblnomini.Text = nomname
        xlblAcType.Text = ac_type
        xlbladdress.Text = add_ress
        xlbladhar.Text = adhar
        xlblbal.Text = bal
        xlblDOB.Text = D_OB
        xlblemail.Text = email
        xlblgender.Text = g_ender
        xlblmno.Text = monrec
        xlblmobno.Text = mobno
        xlblnote.Text = nots
        xlblPan.Text = paan
        xlblphno.Text = phno
        XrPictureBox1.Image = photo
        XrPictureBox2.Image = sign
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Function CreateCode128BarCode(ByVal BarCodeText As String) As XRBarCode
        ' Create a bar code control.
        Dim barCode As New XRBarCode()

        ' Set the bar code's type to Code 128.
        barCode.Symbology = New Code128Generator()

        ' Adjust the bar code's main properties.
        barCode.Text = BarCodeText
        barCode.Width = 400
        barCode.Height = 100

        ' Adjust the properties specific to the bar code type.
        CType(barCode.Symbology, Code128Generator).CharacterSet = Code128Charset.CharsetB

        Return barCode
    End Function

    Private Sub userinfo_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles Me.BeforePrint
        ' Me.Detail.Controls.Add(CreateCode128BarCode(xlblAcNo.Text))
        XrBarCode1.Text = xlblAcNo.Text '+ " " + xlblName.Text
        XrBarCode1.Symbology = New Code128Generator()
        CType(XrBarCode1.Symbology, Code128Generator).CharacterSet = Code128Charset.CharsetB
        XrBarCode2.Symbology = New QRCodeGenerator()
        XrBarCode2.AutoModule = True
        XrBarCode2.Text = xlblAcNo.Text + " NAME " + xlblName.Text
        CType(XrBarCode2.Symbology, QRCodeGenerator).CompactionMode = QRCodeCompactionMode.AlphaNumeric
        CType(XrBarCode2.Symbology, QRCodeGenerator).ErrorCorrectionLevel = QRCodeErrorCorrectionLevel.H
        CType(XrBarCode2.Symbology, QRCodeGenerator).Version = QRCodeVersion.AutoVersion
    End Sub
End Class