<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newUserData
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(newUserData))
        Me.ToolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
        Me.mobile = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.recno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dob = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rEFF_NO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.aDDRESS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.D_ATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NOMINI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PAN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.aDHAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ACTYPE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FNAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CIF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GENDER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.N_AME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ACNO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.AMOUNT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.ComboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NOTES = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mobile
        '
        Me.mobile.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.mobile.AppearanceCell.BackColor2 = System.Drawing.Color.Lime
        Me.mobile.AppearanceCell.BorderColor = System.Drawing.Color.Blue
        Me.mobile.AppearanceCell.Options.UseBackColor = True
        Me.mobile.AppearanceCell.Options.UseBorderColor = True
        Me.mobile.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.mobile.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.mobile.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.mobile.AppearanceHeader.Options.UseBackColor = True
        Me.mobile.AppearanceHeader.Options.UseBorderColor = True
        Me.mobile.Caption = "MobileNo"
        Me.mobile.FieldName = "mobile"
        Me.mobile.Name = "mobile"
        Me.mobile.Visible = True
        Me.mobile.VisibleIndex = 14
        '
        'recno
        '
        Me.recno.AppearanceCell.BackColor = System.Drawing.Color.Red
        Me.recno.AppearanceCell.BackColor2 = System.Drawing.Color.Fuchsia
        Me.recno.AppearanceCell.BorderColor = System.Drawing.Color.Blue
        Me.recno.AppearanceCell.Options.UseBackColor = True
        Me.recno.AppearanceCell.Options.UseBorderColor = True
        Me.recno.AppearanceHeader.BackColor = System.Drawing.Color.Blue
        Me.recno.AppearanceHeader.BackColor2 = System.Drawing.Color.Lime
        Me.recno.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.recno.AppearanceHeader.Options.UseBackColor = True
        Me.recno.AppearanceHeader.Options.UseBorderColor = True
        Me.recno.Caption = "PR No"
        Me.recno.FieldName = "recno"
        Me.recno.Name = "recno"
        Me.recno.Visible = True
        Me.recno.VisibleIndex = 13
        '
        'dob
        '
        Me.dob.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dob.AppearanceCell.BackColor2 = System.Drawing.Color.Lime
        Me.dob.AppearanceCell.BorderColor = System.Drawing.Color.Blue
        Me.dob.AppearanceCell.Options.UseBackColor = True
        Me.dob.AppearanceCell.Options.UseBorderColor = True
        Me.dob.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dob.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dob.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dob.AppearanceHeader.Options.UseBackColor = True
        Me.dob.AppearanceHeader.Options.UseBorderColor = True
        Me.dob.Caption = "DOB"
        Me.dob.FieldName = "dob"
        Me.dob.Name = "dob"
        Me.dob.Visible = True
        Me.dob.VisibleIndex = 12
        '
        'rEFF_NO
        '
        Me.rEFF_NO.AppearanceCell.BackColor = System.Drawing.Color.Red
        Me.rEFF_NO.AppearanceCell.BackColor2 = System.Drawing.Color.Fuchsia
        Me.rEFF_NO.AppearanceCell.BorderColor = System.Drawing.Color.Blue
        Me.rEFF_NO.AppearanceCell.Options.UseBackColor = True
        Me.rEFF_NO.AppearanceCell.Options.UseBorderColor = True
        Me.rEFF_NO.AppearanceHeader.BackColor = System.Drawing.Color.Blue
        Me.rEFF_NO.AppearanceHeader.BackColor2 = System.Drawing.Color.Lime
        Me.rEFF_NO.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rEFF_NO.AppearanceHeader.Options.UseBackColor = True
        Me.rEFF_NO.AppearanceHeader.Options.UseBorderColor = True
        Me.rEFF_NO.Caption = "Refference No"
        Me.rEFF_NO.FieldName = "rEFF_NO"
        Me.rEFF_NO.Name = "rEFF_NO"
        Me.rEFF_NO.Visible = True
        Me.rEFF_NO.VisibleIndex = 11
        '
        'aDDRESS
        '
        Me.aDDRESS.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.aDDRESS.AppearanceCell.BackColor2 = System.Drawing.Color.Lime
        Me.aDDRESS.AppearanceCell.BorderColor = System.Drawing.Color.Blue
        Me.aDDRESS.AppearanceCell.Options.UseBackColor = True
        Me.aDDRESS.AppearanceCell.Options.UseBorderColor = True
        Me.aDDRESS.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.aDDRESS.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.aDDRESS.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.aDDRESS.AppearanceHeader.Options.UseBackColor = True
        Me.aDDRESS.AppearanceHeader.Options.UseBorderColor = True
        Me.aDDRESS.Caption = "Address"
        Me.aDDRESS.FieldName = "aDDRESS"
        Me.aDDRESS.Name = "aDDRESS"
        Me.aDDRESS.Visible = True
        Me.aDDRESS.VisibleIndex = 6
        '
        'D_ATE
        '
        Me.D_ATE.AppearanceCell.BackColor = System.Drawing.Color.Red
        Me.D_ATE.AppearanceCell.BackColor2 = System.Drawing.Color.Fuchsia
        Me.D_ATE.AppearanceCell.BorderColor = System.Drawing.Color.Blue
        Me.D_ATE.AppearanceCell.Options.UseBackColor = True
        Me.D_ATE.AppearanceCell.Options.UseBorderColor = True
        Me.D_ATE.AppearanceHeader.BackColor = System.Drawing.Color.Blue
        Me.D_ATE.AppearanceHeader.BackColor2 = System.Drawing.Color.Lime
        Me.D_ATE.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.D_ATE.AppearanceHeader.Options.UseBackColor = True
        Me.D_ATE.AppearanceHeader.Options.UseBorderColor = True
        Me.D_ATE.Caption = "DATE"
        Me.D_ATE.FieldName = "D_ATE"
        Me.D_ATE.Name = "D_ATE"
        Me.D_ATE.Visible = True
        Me.D_ATE.VisibleIndex = 5
        '
        'NOMINI
        '
        Me.NOMINI.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.NOMINI.AppearanceCell.BackColor2 = System.Drawing.Color.Lime
        Me.NOMINI.AppearanceCell.BorderColor = System.Drawing.Color.Blue
        Me.NOMINI.AppearanceCell.Options.UseBackColor = True
        Me.NOMINI.AppearanceCell.Options.UseBorderColor = True
        Me.NOMINI.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.NOMINI.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.NOMINI.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.NOMINI.AppearanceHeader.Options.UseBackColor = True
        Me.NOMINI.AppearanceHeader.Options.UseBorderColor = True
        Me.NOMINI.Caption = "NominiName"
        Me.NOMINI.FieldName = "NOMINI"
        Me.NOMINI.Name = "NOMINI"
        Me.NOMINI.Visible = True
        Me.NOMINI.VisibleIndex = 8
        '
        'PAN
        '
        Me.PAN.AppearanceCell.BackColor = System.Drawing.Color.Red
        Me.PAN.AppearanceCell.BackColor2 = System.Drawing.Color.Fuchsia
        Me.PAN.AppearanceCell.BorderColor = System.Drawing.Color.Blue
        Me.PAN.AppearanceCell.Options.UseBackColor = True
        Me.PAN.AppearanceCell.Options.UseBorderColor = True
        Me.PAN.AppearanceHeader.BackColor = System.Drawing.Color.Blue
        Me.PAN.AppearanceHeader.BackColor2 = System.Drawing.Color.Lime
        Me.PAN.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PAN.AppearanceHeader.Options.UseBackColor = True
        Me.PAN.AppearanceHeader.Options.UseBorderColor = True
        Me.PAN.Caption = "PAN"
        Me.PAN.FieldName = "PAN"
        Me.PAN.Name = "PAN"
        Me.PAN.Visible = True
        Me.PAN.VisibleIndex = 7
        '
        'aDHAR
        '
        Me.aDHAR.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.aDHAR.AppearanceCell.BackColor2 = System.Drawing.Color.Lime
        Me.aDHAR.AppearanceCell.BorderColor = System.Drawing.Color.Blue
        Me.aDHAR.AppearanceCell.Options.UseBackColor = True
        Me.aDHAR.AppearanceCell.Options.UseBorderColor = True
        Me.aDHAR.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.aDHAR.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.aDHAR.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.aDHAR.AppearanceHeader.Options.UseBackColor = True
        Me.aDHAR.AppearanceHeader.Options.UseBorderColor = True
        Me.aDHAR.Caption = "Adhar"
        Me.aDHAR.FieldName = "aDHAR"
        Me.aDHAR.Name = "aDHAR"
        Me.aDHAR.Visible = True
        Me.aDHAR.VisibleIndex = 6
        '
        'ACTYPE
        '
        Me.ACTYPE.AppearanceCell.BackColor = System.Drawing.Color.Red
        Me.ACTYPE.AppearanceCell.BackColor2 = System.Drawing.Color.Fuchsia
        Me.ACTYPE.AppearanceCell.BorderColor = System.Drawing.Color.Blue
        Me.ACTYPE.AppearanceCell.Options.UseBackColor = True
        Me.ACTYPE.AppearanceCell.Options.UseBorderColor = True
        Me.ACTYPE.AppearanceHeader.BackColor = System.Drawing.Color.Blue
        Me.ACTYPE.AppearanceHeader.BackColor2 = System.Drawing.Color.Lime
        Me.ACTYPE.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ACTYPE.AppearanceHeader.Options.UseBackColor = True
        Me.ACTYPE.AppearanceHeader.Options.UseBorderColor = True
        Me.ACTYPE.Caption = "AcType"
        Me.ACTYPE.FieldName = "ACTYPE"
        Me.ACTYPE.Name = "ACTYPE"
        Me.ACTYPE.Visible = True
        Me.ACTYPE.VisibleIndex = 5
        '
        'FNAME
        '
        Me.FNAME.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.FNAME.AppearanceCell.BackColor2 = System.Drawing.Color.Lime
        Me.FNAME.AppearanceCell.BorderColor = System.Drawing.Color.Blue
        Me.FNAME.AppearanceCell.Options.UseBackColor = True
        Me.FNAME.AppearanceCell.Options.UseBorderColor = True
        Me.FNAME.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.FNAME.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FNAME.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.FNAME.AppearanceHeader.Options.UseBackColor = True
        Me.FNAME.AppearanceHeader.Options.UseBorderColor = True
        Me.FNAME.Caption = "GUARDIAN"
        Me.FNAME.FieldName = "FNAME"
        Me.FNAME.Name = "FNAME"
        Me.FNAME.Visible = True
        Me.FNAME.VisibleIndex = 4
        '
        'CIF
        '
        Me.CIF.AppearanceCell.BackColor = System.Drawing.Color.Red
        Me.CIF.AppearanceCell.BackColor2 = System.Drawing.Color.Fuchsia
        Me.CIF.AppearanceCell.BorderColor = System.Drawing.Color.Blue
        Me.CIF.AppearanceCell.Options.UseBackColor = True
        Me.CIF.AppearanceCell.Options.UseBorderColor = True
        Me.CIF.AppearanceHeader.BackColor = System.Drawing.Color.Blue
        Me.CIF.AppearanceHeader.BackColor2 = System.Drawing.Color.Lime
        Me.CIF.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CIF.AppearanceHeader.Options.UseBackColor = True
        Me.CIF.AppearanceHeader.Options.UseBorderColor = True
        Me.CIF.Caption = "CIF"
        Me.CIF.FieldName = "CIF"
        Me.CIF.Name = "CIF"
        Me.CIF.Visible = True
        Me.CIF.VisibleIndex = 2
        '
        'GENDER
        '
        Me.GENDER.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GENDER.AppearanceCell.BackColor2 = System.Drawing.Color.Lime
        Me.GENDER.AppearanceCell.BorderColor = System.Drawing.Color.Blue
        Me.GENDER.AppearanceCell.Options.UseBackColor = True
        Me.GENDER.AppearanceCell.Options.UseBorderColor = True
        Me.GENDER.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GENDER.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GENDER.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GENDER.AppearanceHeader.Options.UseBackColor = True
        Me.GENDER.AppearanceHeader.Options.UseBorderColor = True
        Me.GENDER.Caption = "Gender"
        Me.GENDER.FieldName = "GENDER"
        Me.GENDER.Name = "GENDER"
        Me.GENDER.Visible = True
        Me.GENDER.VisibleIndex = 2
        '
        'N_AME
        '
        Me.N_AME.AppearanceCell.BackColor = System.Drawing.Color.Red
        Me.N_AME.AppearanceCell.BackColor2 = System.Drawing.Color.Fuchsia
        Me.N_AME.AppearanceCell.BorderColor = System.Drawing.Color.Blue
        Me.N_AME.AppearanceCell.Options.UseBackColor = True
        Me.N_AME.AppearanceCell.Options.UseBorderColor = True
        Me.N_AME.AppearanceHeader.BackColor = System.Drawing.Color.Blue
        Me.N_AME.AppearanceHeader.BackColor2 = System.Drawing.Color.Lime
        Me.N_AME.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.N_AME.AppearanceHeader.Options.UseBackColor = True
        Me.N_AME.AppearanceHeader.Options.UseBorderColor = True
        Me.N_AME.Caption = "CustmorName"
        Me.N_AME.FieldName = "N_AME"
        Me.N_AME.Name = "N_AME"
        Me.N_AME.Visible = True
        Me.N_AME.VisibleIndex = 1
        '
        'ACNO
        '
        Me.ACNO.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ACNO.AppearanceCell.BackColor2 = System.Drawing.Color.Lime
        Me.ACNO.AppearanceCell.BorderColor = System.Drawing.Color.Blue
        Me.ACNO.AppearanceCell.Options.UseBackColor = True
        Me.ACNO.AppearanceCell.Options.UseBorderColor = True
        Me.ACNO.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ACNO.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ACNO.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ACNO.AppearanceHeader.Options.UseBackColor = True
        Me.ACNO.AppearanceHeader.Options.UseBorderColor = True
        Me.ACNO.Caption = "AcNo"
        Me.ACNO.FieldName = "ACNO"
        Me.ACNO.Name = "ACNO"
        Me.ACNO.Visible = True
        Me.ACNO.VisibleIndex = 0
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.id, Me.N_AME, Me.CIF, Me.ACNO, Me.FNAME, Me.D_ATE, Me.aDDRESS, Me.dob, Me.aDHAR, Me.PAN, Me.NOMINI, Me.GENDER, Me.ACTYPE, Me.NOTES, Me.AMOUNT, Me.rEFF_NO, Me.mobile, Me.recno})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.EnableAppearanceOddRow = True
        '
        'AMOUNT
        '
        Me.AMOUNT.AppearanceCell.BackColor = System.Drawing.Color.Yellow
        Me.AMOUNT.AppearanceCell.BackColor2 = System.Drawing.Color.Red
        Me.AMOUNT.AppearanceCell.BorderColor = System.Drawing.Color.Blue
        Me.AMOUNT.AppearanceCell.Options.UseBackColor = True
        Me.AMOUNT.AppearanceCell.Options.UseBorderColor = True
        Me.AMOUNT.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.AMOUNT.AppearanceHeader.BackColor2 = System.Drawing.Color.Red
        Me.AMOUNT.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.AMOUNT.AppearanceHeader.Options.UseBackColor = True
        Me.AMOUNT.AppearanceHeader.Options.UseBorderColor = True
        Me.AMOUNT.Caption = "AcBal"
        Me.AMOUNT.FieldName = "AMOUNT"
        Me.AMOUNT.Name = "AMOUNT"
        Me.AMOUNT.Visible = True
        Me.AMOUNT.VisibleIndex = 15
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl1.Location = New System.Drawing.Point(2, 24)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1274, 542)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.AutoSize = True
        Me.GroupControl2.Controls.Add(Me.GridControl1)
        Me.GroupControl2.Location = New System.Drawing.Point(1, 71)
        Me.GroupControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(1278, 568)
        Me.GroupControl2.TabIndex = 3
        '
        'TextEdit2
        '
        Me.TextEdit2.EditValue = ""
        Me.TextEdit2.Location = New System.Drawing.Point(215, 19)
        Me.TextEdit2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextEdit2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextEdit2.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit2.Properties.Appearance.Options.UseFont = True
        Me.TextEdit2.Properties.Appearance.Options.UseForeColor = True
        Me.TextEdit2.Size = New System.Drawing.Size(164, 24)
        Me.TextEdit2.TabIndex = 14
        '
        'TextEdit1
        '
        Me.TextEdit1.EditValue = ""
        Me.TextEdit1.Location = New System.Drawing.Point(19, 20)
        Me.TextEdit1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit1.Properties.Appearance.Options.UseFont = True
        Me.TextEdit1.Properties.Appearance.Options.UseForeColor = True
        Me.TextEdit1.Size = New System.Drawing.Size(164, 24)
        Me.TextEdit1.TabIndex = 13
        '
        'ComboBoxEdit1
        '
        Me.ComboBoxEdit1.EditValue = "All"
        Me.ComboBoxEdit1.Location = New System.Drawing.Point(719, 28)
        Me.ComboBoxEdit1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
        Me.ComboBoxEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ComboBoxEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.ComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBoxEdit1.Properties.Items.AddRange(New Object() {"All", "Saving", "Requiring Deposit", "SS Account", "Time deposit", "RPLI"})
        Me.ComboBoxEdit1.Size = New System.Drawing.Size(117, 22)
        Me.ComboBoxEdit1.TabIndex = 12
        Me.ComboBoxEdit1.Visible = False
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SimpleButton2.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SimpleButton2.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SimpleButton2.Appearance.Options.UseBackColor = True
        Me.SimpleButton2.Appearance.Options.UseBorderColor = True
        Me.SimpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SimpleButton2.Location = New System.Drawing.Point(493, 11)
        Me.SimpleButton2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(48, 47)
        Me.SimpleButton2.TabIndex = 11
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SimpleButton1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SimpleButton1.Appearance.BorderColor = System.Drawing.Color.Aqua
        Me.SimpleButton1.Appearance.Options.UseBackColor = True
        Me.SimpleButton1.Appearance.Options.UseBorderColor = True
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SimpleButton1.Location = New System.Drawing.Point(421, 10)
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(48, 47)
        Me.SimpleButton1.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(873, 18)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 28)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Print All"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Controls.Add(Me.TextEdit2)
        Me.GroupControl1.Controls.Add(Me.TextEdit1)
        Me.GroupControl1.Controls.Add(Me.ComboBoxEdit1)
        Me.GroupControl1.Controls.Add(Me.SimpleButton2)
        Me.GroupControl1.Controls.Add(Me.SimpleButton1)
        Me.GroupControl1.Controls.Add(Me.Button1)
        Me.GroupControl1.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(1275, 152)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "GroupControl1"
        '
        'id
        '
        Me.id.AppearanceCell.BackColor = System.Drawing.Color.Blue
        Me.id.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.id.AppearanceCell.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.id.AppearanceCell.Options.UseBackColor = True
        Me.id.AppearanceCell.Options.UseBorderColor = True
        Me.id.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.id.AppearanceHeader.BackColor2 = System.Drawing.Color.Red
        Me.id.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.id.AppearanceHeader.Options.UseBackColor = True
        Me.id.AppearanceHeader.Options.UseBorderColor = True
        Me.id.Caption = "ID"
        Me.id.FieldName = "id"
        Me.id.Name = "id"
        Me.id.Visible = True
        Me.id.VisibleIndex = 0
        '
        'NOTES
        '
        Me.NOTES.AppearanceCell.BackColor = System.Drawing.Color.Aqua
        Me.NOTES.AppearanceCell.BackColor2 = System.Drawing.Color.Blue
        Me.NOTES.AppearanceCell.BorderColor = System.Drawing.Color.Fuchsia
        Me.NOTES.AppearanceCell.Options.UseBackColor = True
        Me.NOTES.AppearanceCell.Options.UseBorderColor = True
        Me.NOTES.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.NOTES.AppearanceHeader.BackColor2 = System.Drawing.Color.Fuchsia
        Me.NOTES.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.NOTES.AppearanceHeader.Options.UseBackColor = True
        Me.NOTES.AppearanceHeader.Options.UseBorderColor = True
        Me.NOTES.Caption = "Notes"
        Me.NOTES.FieldName = "NOTES"
        Me.NOTES.Name = "NOTES"
        Me.NOTES.Visible = True
        Me.NOTES.VisibleIndex = 17
        '
        'newUserData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1287, 647)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "newUserData"
        Me.Text = "newUserData"
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTipController1 As DevExpress.Utils.ToolTipController
    Friend WithEvents mobile As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents recno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dob As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rEFF_NO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents aDDRESS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents D_ATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NOMINI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PAN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents aDHAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ACTYPE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FNAME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CIF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GENDER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents N_AME As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ACNO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AMOUNT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NOTES As DevExpress.XtraGrid.Columns.GridColumn
End Class
