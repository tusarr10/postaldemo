<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class userinfo
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Code128Generator1 As DevExpress.XtraPrinting.BarCode.Code128Generator = New DevExpress.XtraPrinting.BarCode.Code128Generator()
        Dim QrCodeGenerator1 As DevExpress.XtraPrinting.BarCode.QRCodeGenerator = New DevExpress.XtraPrinting.BarCode.QRCodeGenerator()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.XrPanel1 = New DevExpress.XtraReports.UI.XRPanel()
        Me.XrPictureBox2 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.xlblName = New DevExpress.XtraReports.UI.XRLabel()
        Me.xlblmname = New DevExpress.XtraReports.UI.XRLabel()
        Me.xlblfname = New DevExpress.XtraReports.UI.XRLabel()
        Me.xlblgender = New DevExpress.XtraReports.UI.XRLabel()
        Me.xlblnomini = New DevExpress.XtraReports.UI.XRLabel()
        Me.xlbladdress = New DevExpress.XtraReports.UI.XRLabel()
        Me.xlblnote = New DevExpress.XtraReports.UI.XRLabel()
        Me.xlblPan = New DevExpress.XtraReports.UI.XRLabel()
        Me.xlblmno = New DevExpress.XtraReports.UI.XRLabel()
        Me.xlblAcType = New DevExpress.XtraReports.UI.XRLabel()
        Me.xlbladhar = New DevExpress.XtraReports.UI.XRLabel()
        Me.xlblbal = New DevExpress.XtraReports.UI.XRLabel()
        Me.xlblmobno = New DevExpress.XtraReports.UI.XRLabel()
        Me.xlblemail = New DevExpress.XtraReports.UI.XRLabel()
        Me.xlblphno = New DevExpress.XtraReports.UI.XRLabel()
        Me.xlblDOB = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.xlblAcNo = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrBarCode1 = New DevExpress.XtraReports.UI.XRBarCode()
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrBarCode2 = New DevExpress.XtraReports.UI.XRBarCode()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Expanded = False
        Me.Detail.HeightF = 100.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1, Me.XrBarCode1})
        Me.TopMargin.HeightF = 116.6154!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel1
        '
        Me.XrLabel1.BorderColor = System.Drawing.Color.Fuchsia
        Me.XrLabel1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(194.0477!, 10.00001!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(271.875!, 51.04166!)
        Me.XrLabel1.StylePriority.UseBorderColor = False
        Me.XrLabel1.StylePriority.UseBorders = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseForeColor = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "User Information"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'BottomMargin
        '
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo1})
        Me.BottomMargin.HeightF = 15.47619!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(588.0952!, 0.0!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(60.71429!, 15.47619!)
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPanel1, Me.XrLabel19})
        Me.GroupHeader1.HeightF = 451.5714!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'XrPanel1
        '
        Me.XrPanel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.XrPanel1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dot
        Me.XrPanel1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrPanel1.BorderWidth = 2.0!
        Me.XrPanel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrBarCode2, Me.XrPictureBox2, Me.xlblName, Me.xlblmname, Me.xlblfname, Me.xlblgender, Me.xlblnomini, Me.xlbladdress, Me.xlblnote, Me.xlblPan, Me.xlblmno, Me.xlblAcType, Me.xlbladhar, Me.xlblbal, Me.xlblmobno, Me.xlblemail, Me.xlblphno, Me.xlblDOB, Me.XrPictureBox1, Me.xlblAcNo, Me.XrLabel2, Me.XrLabel3, Me.XrLabel4, Me.XrLabel7, Me.XrLabel6, Me.XrLabel5, Me.XrLabel8, Me.XrLabel12, Me.XrLabel11, Me.XrLabel9, Me.XrLabel17, Me.XrLabel16, Me.XrLabel15, Me.XrLabel14, Me.XrLabel13, Me.XrLabel10, Me.XrLabel18})
        Me.XrPanel1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrPanel1.Name = "XrPanel1"
        Me.XrPanel1.SizeF = New System.Drawing.SizeF(639.5833!, 428.5714!)
        Me.XrPanel1.StylePriority.UseBorderColor = False
        Me.XrPanel1.StylePriority.UseBorderDashStyle = False
        Me.XrPanel1.StylePriority.UseBorders = False
        Me.XrPanel1.StylePriority.UseBorderWidth = False
        '
        'XrPictureBox2
        '
        Me.XrPictureBox2.LocationFloat = New DevExpress.Utils.PointFloat(432.4107!, 306.3541!)
        Me.XrPictureBox2.Name = "XrPictureBox2"
        Me.XrPictureBox2.SizeF = New System.Drawing.SizeF(194.0476!, 65.625!)
        '
        'xlblName
        '
        Me.xlblName.ForeColor = System.Drawing.Color.Blue
        Me.xlblName.LocationFloat = New DevExpress.Utils.PointFloat(135.4168!, 40.62492!)
        Me.xlblName.Name = "xlblName"
        Me.xlblName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xlblName.SizeF = New System.Drawing.SizeF(102.0833!, 25.0!)
        Me.xlblName.StylePriority.UseForeColor = False
        Me.xlblName.Text = "xlblName"
        '
        'xlblmname
        '
        Me.xlblmname.ForeColor = System.Drawing.Color.Blue
        Me.xlblmname.LocationFloat = New DevExpress.Utils.PointFloat(135.4168!, 154.7083!)
        Me.xlblmname.Name = "xlblmname"
        Me.xlblmname.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xlblmname.SizeF = New System.Drawing.SizeF(102.0833!, 25.0!)
        Me.xlblmname.StylePriority.UseForeColor = False
        Me.xlblmname.Text = "xlblName"
        '
        'xlblfname
        '
        Me.xlblfname.ForeColor = System.Drawing.Color.Blue
        Me.xlblfname.LocationFloat = New DevExpress.Utils.PointFloat(134.3752!, 116.1666!)
        Me.xlblfname.Name = "xlblfname"
        Me.xlblfname.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xlblfname.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.xlblfname.StylePriority.UseForeColor = False
        Me.xlblfname.Text = "xlblAcNo"
        '
        'xlblgender
        '
        Me.xlblgender.ForeColor = System.Drawing.Color.Blue
        Me.xlblgender.LocationFloat = New DevExpress.Utils.PointFloat(135.4168!, 231.7917!)
        Me.xlblgender.Name = "xlblgender"
        Me.xlblgender.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xlblgender.SizeF = New System.Drawing.SizeF(102.0833!, 25.0!)
        Me.xlblgender.StylePriority.UseForeColor = False
        Me.xlblgender.Text = "xlblName"
        '
        'xlblnomini
        '
        Me.xlblnomini.ForeColor = System.Drawing.Color.Blue
        Me.xlblnomini.LocationFloat = New DevExpress.Utils.PointFloat(135.4168!, 190.4791!)
        Me.xlblnomini.Name = "xlblnomini"
        Me.xlblnomini.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xlblnomini.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.xlblnomini.StylePriority.UseForeColor = False
        Me.xlblnomini.Text = "xlblAcNo"
        '
        'xlbladdress
        '
        Me.xlbladdress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.xlbladdress.LocationFloat = New DevExpress.Utils.PointFloat(365.9227!, 156.7083!)
        Me.xlbladdress.Name = "xlbladdress"
        Me.xlbladdress.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xlbladdress.SizeF = New System.Drawing.SizeF(246.7262!, 43.2381!)
        Me.xlbladdress.StylePriority.UseForeColor = False
        Me.xlbladdress.Text = "xlblAcNo"
        '
        'xlblnote
        '
        Me.xlblnote.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.xlblnote.LocationFloat = New DevExpress.Utils.PointFloat(361.7561!, 212.7439!)
        Me.xlblnote.Name = "xlblnote"
        Me.xlblnote.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xlblnote.SizeF = New System.Drawing.SizeF(250.8928!, 44.04762!)
        Me.xlblnote.StylePriority.UseForeColor = False
        Me.xlblnote.Text = "xlblName"
        '
        'xlblPan
        '
        Me.xlblPan.ForeColor = System.Drawing.Color.Blue
        Me.xlblPan.LocationFloat = New DevExpress.Utils.PointFloat(134.3752!, 353.5923!)
        Me.xlblPan.Name = "xlblPan"
        Me.xlblPan.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xlblPan.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.xlblPan.StylePriority.UseForeColor = False
        Me.xlblPan.Text = "xlblAcNo"
        '
        'xlblmno
        '
        Me.xlblmno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.xlblmno.LocationFloat = New DevExpress.Utils.PointFloat(363.8394!, 2.708308!)
        Me.xlblmno.Name = "xlblmno"
        Me.xlblmno.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xlblmno.SizeF = New System.Drawing.SizeF(102.0833!, 25.0!)
        Me.xlblmno.StylePriority.UseForeColor = False
        Me.xlblmno.Text = "xlblName"
        '
        'xlblAcType
        '
        Me.xlblAcType.ForeColor = System.Drawing.Color.Blue
        Me.xlblAcType.LocationFloat = New DevExpress.Utils.PointFloat(133.3336!, 77.84814!)
        Me.xlblAcType.Name = "xlblAcType"
        Me.xlblAcType.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xlblAcType.SizeF = New System.Drawing.SizeF(102.0833!, 25.0!)
        Me.xlblAcType.StylePriority.UseForeColor = False
        Me.xlblAcType.Text = "xlblName"
        '
        'xlbladhar
        '
        Me.xlbladhar.ForeColor = System.Drawing.Color.Blue
        Me.xlbladhar.LocationFloat = New DevExpress.Utils.PointFloat(135.4168!, 313.5833!)
        Me.xlbladhar.Name = "xlbladhar"
        Me.xlbladhar.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xlbladhar.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.xlbladhar.StylePriority.UseForeColor = False
        Me.xlbladhar.Text = "xlblAcNo"
        '
        'xlblbal
        '
        Me.xlblbal.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xlblbal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.xlblbal.LocationFloat = New DevExpress.Utils.PointFloat(365.9227!, 271.6249!)
        Me.xlblbal.Name = "xlblbal"
        Me.xlblbal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xlblbal.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.xlblbal.StylePriority.UseFont = False
        Me.xlblbal.StylePriority.UseForeColor = False
        Me.xlblbal.Text = "xlblAcNo"
        '
        'xlblmobno
        '
        Me.xlblmobno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.xlblmobno.LocationFloat = New DevExpress.Utils.PointFloat(363.8394!, 77.84814!)
        Me.xlblmobno.Name = "xlblmobno"
        Me.xlblmobno.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xlblmobno.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.xlblmobno.StylePriority.UseForeColor = False
        Me.xlblmobno.Text = "xlblAcNo"
        '
        'xlblemail
        '
        Me.xlblemail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.xlblemail.LocationFloat = New DevExpress.Utils.PointFloat(361.7561!, 113.1249!)
        Me.xlblemail.Name = "xlblemail"
        Me.xlblemail.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xlblemail.SizeF = New System.Drawing.SizeF(102.0833!, 25.0!)
        Me.xlblemail.StylePriority.UseForeColor = False
        Me.xlblemail.Text = "xlblName"
        '
        'xlblphno
        '
        Me.xlblphno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.xlblphno.LocationFloat = New DevExpress.Utils.PointFloat(363.8394!, 40.62495!)
        Me.xlblphno.Name = "xlblphno"
        Me.xlblphno.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xlblphno.SizeF = New System.Drawing.SizeF(102.0833!, 25.0!)
        Me.xlblphno.StylePriority.UseForeColor = False
        Me.xlblphno.Text = "xlblName"
        '
        'xlblDOB
        '
        Me.xlblDOB.ForeColor = System.Drawing.Color.Blue
        Me.xlblDOB.LocationFloat = New DevExpress.Utils.PointFloat(135.4168!, 270.7916!)
        Me.xlblDOB.Name = "xlblDOB"
        Me.xlblDOB.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xlblDOB.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.xlblDOB.StylePriority.UseForeColor = False
        Me.xlblDOB.Text = "xlblAcNo"
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(481.2501!, 2.708308!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(145.2083!, 122.3958!)
        '
        'xlblAcNo
        '
        Me.xlblAcNo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xlblAcNo.ForeColor = System.Drawing.Color.Blue
        Me.xlblAcNo.LocationFloat = New DevExpress.Utils.PointFloat(134.3752!, 0.0!)
        Me.xlblAcNo.Name = "xlblAcNo"
        Me.xlblAcNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xlblAcNo.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.xlblAcNo.StylePriority.UseFont = False
        Me.xlblAcNo.StylePriority.UseForeColor = False
        Me.xlblAcNo.Text = "xlblAcNo"
        '
        'XrLabel2
        '
        Me.XrLabel2.ForeColor = System.Drawing.Color.Indigo
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0.00006357829!, 0.0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(107.2917!, 26.04167!)
        Me.XrLabel2.StylePriority.UseForeColor = False
        Me.XrLabel2.Text = "Account Number :"
        '
        'XrLabel3
        '
        Me.XrLabel3.ForeColor = System.Drawing.Color.Indigo
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(0.00006357829!, 39.58327!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(107.2917!, 26.04167!)
        Me.XrLabel3.StylePriority.UseForeColor = False
        Me.XrLabel3.Text = "Name :"
        '
        'XrLabel4
        '
        Me.XrLabel4.ForeColor = System.Drawing.Color.Indigo
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(0.00006357829!, 113.125!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(107.2917!, 26.04167!)
        Me.XrLabel4.StylePriority.UseForeColor = False
        Me.XrLabel4.Text = "Father Name :"
        '
        'XrLabel7
        '
        Me.XrLabel7.ForeColor = System.Drawing.Color.Indigo
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(0.00006357829!, 230.7499!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(107.2917!, 26.04167!)
        Me.XrLabel7.StylePriority.UseForeColor = False
        Me.XrLabel7.Text = "Gender :"
        '
        'XrLabel6
        '
        Me.XrLabel6.ForeColor = System.Drawing.Color.Indigo
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(0.00006357829!, 187.4375!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(107.2917!, 26.04167!)
        Me.XrLabel6.StylePriority.UseForeColor = False
        Me.XrLabel6.Text = "Nominee Name :"
        '
        'XrLabel5
        '
        Me.XrLabel5.ForeColor = System.Drawing.Color.Indigo
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(0.00006357829!, 146.3958!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(107.2917!, 26.04167!)
        Me.XrLabel5.StylePriority.UseForeColor = False
        Me.XrLabel5.Text = "Mother Name :"
        '
        'XrLabel8
        '
        Me.XrLabel8.ForeColor = System.Drawing.Color.Indigo
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(0.00006357829!, 77.84814!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(107.2917!, 26.04167!)
        Me.XrLabel8.StylePriority.UseForeColor = False
        Me.XrLabel8.Text = "Account Typpe :"
        '
        'XrLabel12
        '
        Me.XrLabel12.ForeColor = System.Drawing.Color.Indigo
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(0.00006357829!, 304.8958!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(107.2917!, 26.04167!)
        Me.XrLabel12.StylePriority.UseForeColor = False
        Me.XrLabel12.Text = "Adhar Number :"
        '
        'XrLabel11
        '
        Me.XrLabel11.ForeColor = System.Drawing.Color.Indigo
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(0.00006357829!, 345.9374!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(107.2917!, 26.04167!)
        Me.XrLabel11.StylePriority.UseForeColor = False
        Me.XrLabel11.Text = "PAN :"
        '
        'XrLabel9
        '
        Me.XrLabel9.ForeColor = System.Drawing.Color.Indigo
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(0.00006357829!, 271.6249!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(107.2917!, 26.04167!)
        Me.XrLabel9.StylePriority.UseForeColor = False
        Me.XrLabel9.Text = "Date Of Birth :"
        '
        'XrLabel17
        '
        Me.XrLabel17.ForeColor = System.Drawing.Color.Indigo
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(247.6191!, 39.58327!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(107.2917!, 26.04167!)
        Me.XrLabel17.StylePriority.UseForeColor = False
        Me.XrLabel17.Text = "Phone Number :"
        '
        'XrLabel16
        '
        Me.XrLabel16.ForeColor = System.Drawing.Color.Indigo
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(247.6191!, 112.0833!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(107.2917!, 26.04167!)
        Me.XrLabel16.StylePriority.UseForeColor = False
        Me.XrLabel16.Text = "Email :"
        '
        'XrLabel15
        '
        Me.XrLabel15.ForeColor = System.Drawing.Color.Indigo
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(247.6191!, 0.0!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(107.2917!, 26.04167!)
        Me.XrLabel15.StylePriority.UseForeColor = False
        Me.XrLabel15.Text = "Reciept Number :"
        '
        'XrLabel14
        '
        Me.XrLabel14.ForeColor = System.Drawing.Color.Indigo
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(247.6191!, 212.7439!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(107.2917!, 26.04167!)
        Me.XrLabel14.StylePriority.UseForeColor = False
        Me.XrLabel14.Text = "Notes :"
        '
        'XrLabel13
        '
        Me.XrLabel13.ForeColor = System.Drawing.Color.Indigo
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(247.6191!, 74.8065!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(107.2917!, 26.04167!)
        Me.XrLabel13.StylePriority.UseForeColor = False
        Me.XrLabel13.Text = "Mobile Number :"
        '
        'XrLabel10
        '
        Me.XrLabel10.ForeColor = System.Drawing.Color.Indigo
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(247.6191!, 156.7083!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(107.2917!, 26.04167!)
        Me.XrLabel10.StylePriority.UseForeColor = False
        Me.XrLabel10.Text = "Address :"
        '
        'XrLabel18
        '
        Me.XrLabel18.ForeColor = System.Drawing.Color.Indigo
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(247.6191!, 267.7499!)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(107.2917!, 26.04167!)
        Me.XrLabel18.StylePriority.UseForeColor = False
        Me.XrLabel18.Text = "Account Balance :"
        '
        'XrBarCode1
        '
        Me.XrBarCode1.Alignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrBarCode1.Font = New System.Drawing.Font("Times New Roman", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrBarCode1.LocationFloat = New DevExpress.Utils.PointFloat(9.226252!, 63.91841!)
        Me.XrBarCode1.Name = "XrBarCode1"
        Me.XrBarCode1.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100.0!)
        Me.XrBarCode1.SizeF = New System.Drawing.SizeF(639.5833!, 52.69703!)
        Me.XrBarCode1.StylePriority.UseFont = False
        Me.XrBarCode1.StylePriority.UseTextAlignment = False
        Me.XrBarCode1.Symbology = Code128Generator1
        Me.XrBarCode1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel19
        '
        Me.XrLabel19.BorderColor = System.Drawing.Color.Red
        Me.XrLabel19.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dot
        Me.XrLabel19.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel19.BorderWidth = 2.0!
        Me.XrLabel19.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(254.9108!, 428.5714!)
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel19.SizeF = New System.Drawing.SizeF(100.0!, 23.0!)
        Me.XrLabel19.StylePriority.UseBorderColor = False
        Me.XrLabel19.StylePriority.UseBorderDashStyle = False
        Me.XrLabel19.StylePriority.UseBorders = False
        Me.XrLabel19.StylePriority.UseBorderWidth = False
        Me.XrLabel19.StylePriority.UseFont = False
        Me.XrLabel19.StylePriority.UseForeColor = False
        Me.XrLabel19.Text = "END"
        '
        'XrBarCode2
        '
        Me.XrBarCode2.AutoModule = True
        Me.XrBarCode2.Font = New System.Drawing.Font("Times New Roman", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrBarCode2.LocationFloat = New DevExpress.Utils.PointFloat(248.9583!, 303.125!)
        Me.XrBarCode2.Module = 3.0!
        Me.XrBarCode2.Name = "XrBarCode2"
        Me.XrBarCode2.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100.0!)
        Me.XrBarCode2.SizeF = New System.Drawing.SizeF(178.125!, 69.79166!)
        Me.XrBarCode2.StylePriority.UseFont = False
        Me.XrBarCode2.Symbology = QrCodeGenerator1
        '
        'userinfo
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.GroupHeader1})
        Me.Margins = New System.Drawing.Printing.Margins(100, 100, 117, 15)
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "14.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrPictureBox2 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents xlblDOB As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xlblphno As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xlblemail As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xlblmobno As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xlblbal As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xlbladhar As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xlblAcType As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xlblmno As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xlblPan As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xlblnote As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xlbladdress As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xlblnomini As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xlblgender As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xlblfname As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xlblmname As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xlblName As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xlblAcNo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrBarCode1 As DevExpress.XtraReports.UI.XRBarCode
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPanel1 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents XrBarCode2 As DevExpress.XtraReports.UI.XRBarCode
End Class
