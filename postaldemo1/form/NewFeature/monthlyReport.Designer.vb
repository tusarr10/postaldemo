<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class monthlyReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(monthlyReport))
        Me.XpDataView1 = New DevExpress.Xpo.XPDataView(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.D_ate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OpeningBalance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CashReceive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SavingBalance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RDDeposit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RDFine = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SSADeposit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SSAFine = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TDDeposit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RPLIDeposit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RPLIFine = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RPLITax = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VPP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OtherColl1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OtherColl2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TotalDep = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CashRemt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SBWith = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RDWith = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TDWith = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SSAWith = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RPLIWith = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MONwith = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.othwith = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.totalwith = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.curr_ency = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.stamp1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.stamp2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colsebal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        CType(Me.XpDataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"January", "Fabuary", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.ComboBox1.Location = New System.Drawing.Point(15, 7)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(160, 24)
        Me.ComboBox1.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(184, 7)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(132, 23)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.Tag = "Enter year"
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GridControl1.Location = New System.Drawing.Point(-1, 54)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1517, 612)
        Me.GridControl1.TabIndex = 7
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView1.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.FooterPanel.Options.UseFont = True
        Me.GridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.D_ate, Me.OpeningBalance, Me.CashReceive, Me.SavingBalance, Me.RDDeposit, Me.RDFine, Me.SSADeposit, Me.SSAFine, Me.TDDeposit, Me.RPLIDeposit, Me.RPLIFine, Me.RPLITax, Me.VPP, Me.OtherColl1, Me.OtherColl2, Me.TotalDep, Me.CashRemt, Me.SBWith, Me.RDWith, Me.TDWith, Me.SSAWith, Me.RPLIWith, Me.MONwith, Me.othwith, Me.totalwith, Me.curr_ency, Me.stamp1, Me.stamp2, Me.colsebal})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'D_ate
        '
        Me.D_ate.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.D_ate.AppearanceCell.BackColor2 = System.Drawing.Color.Magenta
        Me.D_ate.AppearanceCell.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.D_ate.AppearanceCell.Options.UseBackColor = True
        Me.D_ate.AppearanceCell.Options.UseBorderColor = True
        Me.D_ate.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.D_ate.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.D_ate.AppearanceHeader.BorderColor = System.Drawing.Color.Green
        Me.D_ate.AppearanceHeader.Options.UseBackColor = True
        Me.D_ate.AppearanceHeader.Options.UseBorderColor = True
        Me.D_ate.Caption = "Date"
        Me.D_ate.FieldName = "D_ate"
        Me.D_ate.Name = "D_ate"
        Me.D_ate.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.D_ate.Visible = True
        Me.D_ate.VisibleIndex = 0
        Me.D_ate.Width = 60
        '
        'OpeningBalance
        '
        Me.OpeningBalance.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.OpeningBalance.AppearanceCell.BackColor2 = System.Drawing.Color.Magenta
        Me.OpeningBalance.AppearanceCell.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.OpeningBalance.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpeningBalance.AppearanceCell.Options.UseBackColor = True
        Me.OpeningBalance.AppearanceCell.Options.UseBorderColor = True
        Me.OpeningBalance.AppearanceCell.Options.UseFont = True
        Me.OpeningBalance.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.OpeningBalance.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.OpeningBalance.AppearanceHeader.BorderColor = System.Drawing.Color.Green
        Me.OpeningBalance.AppearanceHeader.Options.UseBackColor = True
        Me.OpeningBalance.AppearanceHeader.Options.UseBorderColor = True
        Me.OpeningBalance.Caption = "OpeningBalance"
        Me.OpeningBalance.FieldName = "OpeningBalance"
        Me.OpeningBalance.Name = "OpeningBalance"
        Me.OpeningBalance.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.OpeningBalance.Visible = True
        Me.OpeningBalance.VisibleIndex = 1
        Me.OpeningBalance.Width = 98
        '
        'CashReceive
        '
        Me.CashReceive.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CashReceive.AppearanceCell.BackColor2 = System.Drawing.Color.Magenta
        Me.CashReceive.AppearanceCell.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CashReceive.AppearanceCell.Options.UseBackColor = True
        Me.CashReceive.AppearanceCell.Options.UseBorderColor = True
        Me.CashReceive.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.CashReceive.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CashReceive.AppearanceHeader.BorderColor = System.Drawing.Color.Green
        Me.CashReceive.AppearanceHeader.Options.UseBackColor = True
        Me.CashReceive.AppearanceHeader.Options.UseBorderColor = True
        Me.CashReceive.Caption = "CashReceive"
        Me.CashReceive.FieldName = "CashReceive"
        Me.CashReceive.Name = "CashReceive"
        Me.CashReceive.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CashReceive", "{0:0.##}", 1)})
        Me.CashReceive.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.CashReceive.Visible = True
        Me.CashReceive.VisibleIndex = 2
        Me.CashReceive.Width = 49
        '
        'SavingBalance
        '
        Me.SavingBalance.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SavingBalance.AppearanceCell.BackColor2 = System.Drawing.Color.Magenta
        Me.SavingBalance.AppearanceCell.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SavingBalance.AppearanceCell.Options.UseBackColor = True
        Me.SavingBalance.AppearanceCell.Options.UseBorderColor = True
        Me.SavingBalance.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.SavingBalance.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SavingBalance.AppearanceHeader.BorderColor = System.Drawing.Color.Green
        Me.SavingBalance.AppearanceHeader.Options.UseBackColor = True
        Me.SavingBalance.AppearanceHeader.Options.UseBorderColor = True
        Me.SavingBalance.Caption = "SavingBalance"
        Me.SavingBalance.FieldName = "SavingBalance"
        Me.SavingBalance.Name = "SavingBalance"
        Me.SavingBalance.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SavingBalance", "{0:0.##}")})
        Me.SavingBalance.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.SavingBalance.Visible = True
        Me.SavingBalance.VisibleIndex = 3
        Me.SavingBalance.Width = 34
        '
        'RDDeposit
        '
        Me.RDDeposit.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RDDeposit.AppearanceCell.BackColor2 = System.Drawing.Color.Magenta
        Me.RDDeposit.AppearanceCell.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RDDeposit.AppearanceCell.Options.UseBackColor = True
        Me.RDDeposit.AppearanceCell.Options.UseBorderColor = True
        Me.RDDeposit.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.RDDeposit.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RDDeposit.AppearanceHeader.BorderColor = System.Drawing.Color.Green
        Me.RDDeposit.AppearanceHeader.Options.UseBackColor = True
        Me.RDDeposit.AppearanceHeader.Options.UseBorderColor = True
        Me.RDDeposit.Caption = "RDDeposit"
        Me.RDDeposit.FieldName = "RDDeposit"
        Me.RDDeposit.Name = "RDDeposit"
        Me.RDDeposit.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RDDeposit", "{0:0.##}")})
        Me.RDDeposit.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.RDDeposit.Visible = True
        Me.RDDeposit.VisibleIndex = 4
        Me.RDDeposit.Width = 30
        '
        'RDFine
        '
        Me.RDFine.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RDFine.AppearanceCell.BackColor2 = System.Drawing.Color.Magenta
        Me.RDFine.AppearanceCell.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RDFine.AppearanceCell.Options.UseBackColor = True
        Me.RDFine.AppearanceCell.Options.UseBorderColor = True
        Me.RDFine.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.RDFine.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RDFine.AppearanceHeader.BorderColor = System.Drawing.Color.Green
        Me.RDFine.AppearanceHeader.Options.UseBackColor = True
        Me.RDFine.AppearanceHeader.Options.UseBorderColor = True
        Me.RDFine.Caption = "RDFine"
        Me.RDFine.FieldName = "RDFine"
        Me.RDFine.Name = "RDFine"
        Me.RDFine.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RDFine", "{0:0.##}")})
        Me.RDFine.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.RDFine.Visible = True
        Me.RDFine.VisibleIndex = 5
        Me.RDFine.Width = 30
        '
        'SSADeposit
        '
        Me.SSADeposit.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SSADeposit.AppearanceCell.BackColor2 = System.Drawing.Color.Magenta
        Me.SSADeposit.AppearanceCell.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SSADeposit.AppearanceCell.Options.UseBackColor = True
        Me.SSADeposit.AppearanceCell.Options.UseBorderColor = True
        Me.SSADeposit.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.SSADeposit.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SSADeposit.AppearanceHeader.BorderColor = System.Drawing.Color.Green
        Me.SSADeposit.AppearanceHeader.Options.UseBackColor = True
        Me.SSADeposit.AppearanceHeader.Options.UseBorderColor = True
        Me.SSADeposit.Caption = "SSADeposit"
        Me.SSADeposit.FieldName = "SSADeposit"
        Me.SSADeposit.Name = "SSADeposit"
        Me.SSADeposit.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SSADeposit", "{0:0.##}")})
        Me.SSADeposit.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.SSADeposit.Visible = True
        Me.SSADeposit.VisibleIndex = 6
        Me.SSADeposit.Width = 30
        '
        'SSAFine
        '
        Me.SSAFine.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SSAFine.AppearanceCell.BackColor2 = System.Drawing.Color.Magenta
        Me.SSAFine.AppearanceCell.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SSAFine.AppearanceCell.Options.UseBackColor = True
        Me.SSAFine.AppearanceCell.Options.UseBorderColor = True
        Me.SSAFine.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.SSAFine.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SSAFine.AppearanceHeader.BorderColor = System.Drawing.Color.Green
        Me.SSAFine.AppearanceHeader.Options.UseBackColor = True
        Me.SSAFine.AppearanceHeader.Options.UseBorderColor = True
        Me.SSAFine.Caption = "SSAFine"
        Me.SSAFine.FieldName = "SSAFine"
        Me.SSAFine.Name = "SSAFine"
        Me.SSAFine.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SSAFine", "{0:0.##}")})
        Me.SSAFine.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.SSAFine.Visible = True
        Me.SSAFine.VisibleIndex = 7
        Me.SSAFine.Width = 30
        '
        'TDDeposit
        '
        Me.TDDeposit.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TDDeposit.AppearanceCell.BackColor2 = System.Drawing.Color.Magenta
        Me.TDDeposit.AppearanceCell.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TDDeposit.AppearanceCell.Options.UseBackColor = True
        Me.TDDeposit.AppearanceCell.Options.UseBorderColor = True
        Me.TDDeposit.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.TDDeposit.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TDDeposit.AppearanceHeader.BorderColor = System.Drawing.Color.Green
        Me.TDDeposit.AppearanceHeader.Options.UseBackColor = True
        Me.TDDeposit.AppearanceHeader.Options.UseBorderColor = True
        Me.TDDeposit.Caption = "TDDeposit"
        Me.TDDeposit.FieldName = "TDDeposit"
        Me.TDDeposit.Name = "TDDeposit"
        Me.TDDeposit.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TDDeposit", "{0:0.##}")})
        Me.TDDeposit.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.TDDeposit.Visible = True
        Me.TDDeposit.VisibleIndex = 8
        Me.TDDeposit.Width = 46
        '
        'RPLIDeposit
        '
        Me.RPLIDeposit.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RPLIDeposit.AppearanceCell.BackColor2 = System.Drawing.Color.Magenta
        Me.RPLIDeposit.AppearanceCell.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RPLIDeposit.AppearanceCell.Options.UseBackColor = True
        Me.RPLIDeposit.AppearanceCell.Options.UseBorderColor = True
        Me.RPLIDeposit.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.RPLIDeposit.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RPLIDeposit.AppearanceHeader.BorderColor = System.Drawing.Color.Green
        Me.RPLIDeposit.AppearanceHeader.Options.UseBackColor = True
        Me.RPLIDeposit.AppearanceHeader.Options.UseBorderColor = True
        Me.RPLIDeposit.Caption = "RPLIDeposit"
        Me.RPLIDeposit.FieldName = "RPLIDeposit"
        Me.RPLIDeposit.Name = "RPLIDeposit"
        Me.RPLIDeposit.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RPLIDeposit", "{0:0.##}")})
        Me.RPLIDeposit.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.RPLIDeposit.Visible = True
        Me.RPLIDeposit.VisibleIndex = 9
        Me.RPLIDeposit.Width = 29
        '
        'RPLIFine
        '
        Me.RPLIFine.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RPLIFine.AppearanceCell.BackColor2 = System.Drawing.Color.Magenta
        Me.RPLIFine.AppearanceCell.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RPLIFine.AppearanceCell.Options.UseBackColor = True
        Me.RPLIFine.AppearanceCell.Options.UseBorderColor = True
        Me.RPLIFine.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.RPLIFine.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RPLIFine.AppearanceHeader.BorderColor = System.Drawing.Color.Green
        Me.RPLIFine.AppearanceHeader.Options.UseBackColor = True
        Me.RPLIFine.AppearanceHeader.Options.UseBorderColor = True
        Me.RPLIFine.Caption = "RPLIFine"
        Me.RPLIFine.FieldName = "RPLIFine"
        Me.RPLIFine.Name = "RPLIFine"
        Me.RPLIFine.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RPLIFine", "{0:0.##}")})
        Me.RPLIFine.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.RPLIFine.Visible = True
        Me.RPLIFine.VisibleIndex = 10
        Me.RPLIFine.Width = 29
        '
        'RPLITax
        '
        Me.RPLITax.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RPLITax.AppearanceCell.BackColor2 = System.Drawing.Color.Magenta
        Me.RPLITax.AppearanceCell.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RPLITax.AppearanceCell.Options.UseBackColor = True
        Me.RPLITax.AppearanceCell.Options.UseBorderColor = True
        Me.RPLITax.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.RPLITax.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RPLITax.AppearanceHeader.BorderColor = System.Drawing.Color.Green
        Me.RPLITax.AppearanceHeader.Options.UseBackColor = True
        Me.RPLITax.AppearanceHeader.Options.UseBorderColor = True
        Me.RPLITax.Caption = "RPLITax"
        Me.RPLITax.FieldName = "RPLITax"
        Me.RPLITax.Name = "RPLITax"
        Me.RPLITax.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RPLITax", "{0:0.##}")})
        Me.RPLITax.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.RPLITax.Visible = True
        Me.RPLITax.VisibleIndex = 11
        Me.RPLITax.Width = 29
        '
        'VPP
        '
        Me.VPP.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.VPP.AppearanceCell.BackColor2 = System.Drawing.Color.Magenta
        Me.VPP.AppearanceCell.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.VPP.AppearanceCell.Options.UseBackColor = True
        Me.VPP.AppearanceCell.Options.UseBorderColor = True
        Me.VPP.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.VPP.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.VPP.AppearanceHeader.BorderColor = System.Drawing.Color.Green
        Me.VPP.AppearanceHeader.Options.UseBackColor = True
        Me.VPP.AppearanceHeader.Options.UseBorderColor = True
        Me.VPP.Caption = "VPP"
        Me.VPP.FieldName = "VPP"
        Me.VPP.Name = "VPP"
        Me.VPP.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "VPP", "{0:0.##}")})
        Me.VPP.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.VPP.Visible = True
        Me.VPP.VisibleIndex = 12
        Me.VPP.Width = 29
        '
        'OtherColl1
        '
        Me.OtherColl1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.OtherColl1.AppearanceCell.BackColor2 = System.Drawing.Color.Magenta
        Me.OtherColl1.AppearanceCell.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.OtherColl1.AppearanceCell.Options.UseBackColor = True
        Me.OtherColl1.AppearanceCell.Options.UseBorderColor = True
        Me.OtherColl1.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.OtherColl1.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.OtherColl1.AppearanceHeader.BorderColor = System.Drawing.Color.Green
        Me.OtherColl1.AppearanceHeader.Options.UseBackColor = True
        Me.OtherColl1.AppearanceHeader.Options.UseBorderColor = True
        Me.OtherColl1.Caption = "IPPB COL"
        Me.OtherColl1.FieldName = "OtherColl1"
        Me.OtherColl1.Name = "OtherColl1"
        Me.OtherColl1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OtherColl1", "{0:0.##}")})
        Me.OtherColl1.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.OtherColl1.Visible = True
        Me.OtherColl1.VisibleIndex = 13
        Me.OtherColl1.Width = 29
        '
        'OtherColl2
        '
        Me.OtherColl2.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.OtherColl2.AppearanceCell.BackColor2 = System.Drawing.Color.Magenta
        Me.OtherColl2.AppearanceCell.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.OtherColl2.AppearanceCell.Options.UseBackColor = True
        Me.OtherColl2.AppearanceCell.Options.UseBorderColor = True
        Me.OtherColl2.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.OtherColl2.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.OtherColl2.AppearanceHeader.BorderColor = System.Drawing.Color.Green
        Me.OtherColl2.AppearanceHeader.Options.UseBackColor = True
        Me.OtherColl2.AppearanceHeader.Options.UseBorderColor = True
        Me.OtherColl2.Caption = "OtherColl2"
        Me.OtherColl2.FieldName = "OtherColl2"
        Me.OtherColl2.Name = "OtherColl2"
        Me.OtherColl2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OtherColl2", "{0:0.##}")})
        Me.OtherColl2.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.OtherColl2.Visible = True
        Me.OtherColl2.VisibleIndex = 14
        Me.OtherColl2.Width = 29
        '
        'TotalDep
        '
        Me.TotalDep.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TotalDep.AppearanceCell.BackColor2 = System.Drawing.Color.Magenta
        Me.TotalDep.AppearanceCell.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TotalDep.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalDep.AppearanceCell.Options.UseBackColor = True
        Me.TotalDep.AppearanceCell.Options.UseBorderColor = True
        Me.TotalDep.AppearanceCell.Options.UseFont = True
        Me.TotalDep.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.TotalDep.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TotalDep.AppearanceHeader.BorderColor = System.Drawing.Color.Green
        Me.TotalDep.AppearanceHeader.Options.UseBackColor = True
        Me.TotalDep.AppearanceHeader.Options.UseBorderColor = True
        Me.TotalDep.Caption = "TotalDep"
        Me.TotalDep.FieldName = "TotalDep"
        Me.TotalDep.Name = "TotalDep"
        Me.TotalDep.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalDep", "{0:0.##}")})
        Me.TotalDep.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.TotalDep.Visible = True
        Me.TotalDep.VisibleIndex = 15
        Me.TotalDep.Width = 29
        '
        'CashRemt
        '
        Me.CashRemt.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CashRemt.AppearanceCell.BackColor2 = System.Drawing.Color.Magenta
        Me.CashRemt.AppearanceCell.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CashRemt.AppearanceCell.Options.UseBackColor = True
        Me.CashRemt.AppearanceCell.Options.UseBorderColor = True
        Me.CashRemt.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.CashRemt.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CashRemt.AppearanceHeader.BorderColor = System.Drawing.Color.Green
        Me.CashRemt.AppearanceHeader.Options.UseBackColor = True
        Me.CashRemt.AppearanceHeader.Options.UseBorderColor = True
        Me.CashRemt.Caption = "CashRemt"
        Me.CashRemt.FieldName = "CashRemt"
        Me.CashRemt.Name = "CashRemt"
        Me.CashRemt.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CashRemt", "{0:0.##}")})
        Me.CashRemt.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.CashRemt.Visible = True
        Me.CashRemt.VisibleIndex = 16
        Me.CashRemt.Width = 29
        '
        'SBWith
        '
        Me.SBWith.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SBWith.AppearanceCell.BackColor2 = System.Drawing.Color.Magenta
        Me.SBWith.AppearanceCell.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SBWith.AppearanceCell.Options.UseBackColor = True
        Me.SBWith.AppearanceCell.Options.UseBorderColor = True
        Me.SBWith.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.SBWith.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SBWith.AppearanceHeader.BorderColor = System.Drawing.Color.Green
        Me.SBWith.AppearanceHeader.Options.UseBackColor = True
        Me.SBWith.AppearanceHeader.Options.UseBorderColor = True
        Me.SBWith.Caption = "SBWith"
        Me.SBWith.FieldName = "SBWith"
        Me.SBWith.Name = "SBWith"
        Me.SBWith.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SBWith", "{0:0.##}")})
        Me.SBWith.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.SBWith.Visible = True
        Me.SBWith.VisibleIndex = 17
        Me.SBWith.Width = 29
        '
        'RDWith
        '
        Me.RDWith.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RDWith.AppearanceCell.BackColor2 = System.Drawing.Color.Magenta
        Me.RDWith.AppearanceCell.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RDWith.AppearanceCell.Options.UseBackColor = True
        Me.RDWith.AppearanceCell.Options.UseBorderColor = True
        Me.RDWith.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.RDWith.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RDWith.AppearanceHeader.BorderColor = System.Drawing.Color.Green
        Me.RDWith.AppearanceHeader.Options.UseBackColor = True
        Me.RDWith.AppearanceHeader.Options.UseBorderColor = True
        Me.RDWith.Caption = "RDWith"
        Me.RDWith.FieldName = "RDWith"
        Me.RDWith.Name = "RDWith"
        Me.RDWith.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RDWith", "{0:0.##}")})
        Me.RDWith.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.RDWith.Visible = True
        Me.RDWith.VisibleIndex = 18
        Me.RDWith.Width = 29
        '
        'TDWith
        '
        Me.TDWith.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TDWith.AppearanceCell.BackColor2 = System.Drawing.Color.Magenta
        Me.TDWith.AppearanceCell.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TDWith.AppearanceCell.Options.UseBackColor = True
        Me.TDWith.AppearanceCell.Options.UseBorderColor = True
        Me.TDWith.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.TDWith.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TDWith.AppearanceHeader.BorderColor = System.Drawing.Color.Green
        Me.TDWith.AppearanceHeader.Options.UseBackColor = True
        Me.TDWith.AppearanceHeader.Options.UseBorderColor = True
        Me.TDWith.Caption = "TDWith"
        Me.TDWith.FieldName = "TDWith"
        Me.TDWith.Name = "TDWith"
        Me.TDWith.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TDWith", "{0:0.##}")})
        Me.TDWith.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.TDWith.Visible = True
        Me.TDWith.VisibleIndex = 19
        Me.TDWith.Width = 29
        '
        'SSAWith
        '
        Me.SSAWith.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SSAWith.AppearanceCell.BackColor2 = System.Drawing.Color.Magenta
        Me.SSAWith.AppearanceCell.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SSAWith.AppearanceCell.Options.UseBackColor = True
        Me.SSAWith.AppearanceCell.Options.UseBorderColor = True
        Me.SSAWith.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.SSAWith.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SSAWith.AppearanceHeader.BorderColor = System.Drawing.Color.Green
        Me.SSAWith.AppearanceHeader.Options.UseBackColor = True
        Me.SSAWith.AppearanceHeader.Options.UseBorderColor = True
        Me.SSAWith.Caption = "SSAWith"
        Me.SSAWith.FieldName = "SSAWith"
        Me.SSAWith.Name = "SSAWith"
        Me.SSAWith.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SSAWith", "{0:0.##}")})
        Me.SSAWith.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.SSAWith.Visible = True
        Me.SSAWith.VisibleIndex = 20
        Me.SSAWith.Width = 29
        '
        'RPLIWith
        '
        Me.RPLIWith.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RPLIWith.AppearanceCell.BackColor2 = System.Drawing.Color.Magenta
        Me.RPLIWith.AppearanceCell.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RPLIWith.AppearanceCell.Options.UseBackColor = True
        Me.RPLIWith.AppearanceCell.Options.UseBorderColor = True
        Me.RPLIWith.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.RPLIWith.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RPLIWith.AppearanceHeader.BorderColor = System.Drawing.Color.Green
        Me.RPLIWith.AppearanceHeader.Options.UseBackColor = True
        Me.RPLIWith.AppearanceHeader.Options.UseBorderColor = True
        Me.RPLIWith.Caption = "RPLIWith"
        Me.RPLIWith.FieldName = "RPLIWith"
        Me.RPLIWith.Name = "RPLIWith"
        Me.RPLIWith.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RPLIWith", "{0:0.##}")})
        Me.RPLIWith.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.RPLIWith.Visible = True
        Me.RPLIWith.VisibleIndex = 21
        Me.RPLIWith.Width = 29
        '
        'MONwith
        '
        Me.MONwith.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.MONwith.AppearanceCell.BackColor2 = System.Drawing.Color.Magenta
        Me.MONwith.AppearanceCell.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MONwith.AppearanceCell.Options.UseBackColor = True
        Me.MONwith.AppearanceCell.Options.UseBorderColor = True
        Me.MONwith.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.MONwith.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MONwith.AppearanceHeader.BorderColor = System.Drawing.Color.Green
        Me.MONwith.AppearanceHeader.Options.UseBackColor = True
        Me.MONwith.AppearanceHeader.Options.UseBorderColor = True
        Me.MONwith.Caption = "MONwith"
        Me.MONwith.FieldName = "MONwith"
        Me.MONwith.Name = "MONwith"
        Me.MONwith.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MONwith", "{0:0.##}")})
        Me.MONwith.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.MONwith.Visible = True
        Me.MONwith.VisibleIndex = 22
        Me.MONwith.Width = 29
        '
        'othwith
        '
        Me.othwith.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.othwith.AppearanceCell.BackColor2 = System.Drawing.Color.Magenta
        Me.othwith.AppearanceCell.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.othwith.AppearanceCell.Options.UseBackColor = True
        Me.othwith.AppearanceCell.Options.UseBorderColor = True
        Me.othwith.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.othwith.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.othwith.AppearanceHeader.BorderColor = System.Drawing.Color.Green
        Me.othwith.AppearanceHeader.Options.UseBackColor = True
        Me.othwith.AppearanceHeader.Options.UseBorderColor = True
        Me.othwith.Caption = "IPPBWITH"
        Me.othwith.FieldName = "othwith"
        Me.othwith.Name = "othwith"
        Me.othwith.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "othwith", "{0:0.##}")})
        Me.othwith.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.othwith.Visible = True
        Me.othwith.VisibleIndex = 23
        Me.othwith.Width = 29
        '
        'totalwith
        '
        Me.totalwith.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.totalwith.AppearanceCell.BackColor2 = System.Drawing.Color.Magenta
        Me.totalwith.AppearanceCell.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.totalwith.AppearanceCell.Options.UseBackColor = True
        Me.totalwith.AppearanceCell.Options.UseBorderColor = True
        Me.totalwith.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.totalwith.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.totalwith.AppearanceHeader.BorderColor = System.Drawing.Color.Green
        Me.totalwith.AppearanceHeader.Options.UseBackColor = True
        Me.totalwith.AppearanceHeader.Options.UseBorderColor = True
        Me.totalwith.Caption = "totalwith"
        Me.totalwith.FieldName = "totalwith"
        Me.totalwith.Name = "totalwith"
        Me.totalwith.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "totalwith", "{0:0.##}")})
        Me.totalwith.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.totalwith.Visible = True
        Me.totalwith.VisibleIndex = 24
        Me.totalwith.Width = 55
        '
        'curr_ency
        '
        Me.curr_ency.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.curr_ency.AppearanceCell.BackColor2 = System.Drawing.Color.Magenta
        Me.curr_ency.AppearanceCell.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.curr_ency.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.curr_ency.AppearanceCell.Options.UseBackColor = True
        Me.curr_ency.AppearanceCell.Options.UseBorderColor = True
        Me.curr_ency.AppearanceCell.Options.UseFont = True
        Me.curr_ency.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.curr_ency.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.curr_ency.AppearanceHeader.BorderColor = System.Drawing.Color.Green
        Me.curr_ency.AppearanceHeader.Options.UseBackColor = True
        Me.curr_ency.AppearanceHeader.Options.UseBorderColor = True
        Me.curr_ency.Caption = "curr_ency"
        Me.curr_ency.FieldName = "curr_ency"
        Me.curr_ency.Name = "curr_ency"
        Me.curr_ency.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "curr_ency", "{0:0.##}")})
        Me.curr_ency.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.curr_ency.Visible = True
        Me.curr_ency.VisibleIndex = 25
        Me.curr_ency.Width = 60
        '
        'stamp1
        '
        Me.stamp1.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.stamp1.AppearanceCell.BackColor2 = System.Drawing.Color.Magenta
        Me.stamp1.AppearanceCell.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.stamp1.AppearanceCell.Options.UseBackColor = True
        Me.stamp1.AppearanceCell.Options.UseBorderColor = True
        Me.stamp1.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.stamp1.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.stamp1.AppearanceHeader.BorderColor = System.Drawing.Color.Green
        Me.stamp1.AppearanceHeader.Options.UseBackColor = True
        Me.stamp1.AppearanceHeader.Options.UseBorderColor = True
        Me.stamp1.Caption = "stamp1"
        Me.stamp1.FieldName = "stamp1"
        Me.stamp1.Name = "stamp1"
        Me.stamp1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "stamp1", "{0:0.##}")})
        Me.stamp1.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.stamp1.Visible = True
        Me.stamp1.VisibleIndex = 26
        Me.stamp1.Width = 44
        '
        'stamp2
        '
        Me.stamp2.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.stamp2.AppearanceCell.BackColor2 = System.Drawing.Color.Magenta
        Me.stamp2.AppearanceCell.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.stamp2.AppearanceCell.Options.UseBackColor = True
        Me.stamp2.AppearanceCell.Options.UseBorderColor = True
        Me.stamp2.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.stamp2.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.stamp2.AppearanceHeader.BorderColor = System.Drawing.Color.Green
        Me.stamp2.AppearanceHeader.Options.UseBackColor = True
        Me.stamp2.AppearanceHeader.Options.UseBorderColor = True
        Me.stamp2.Caption = "stamp2"
        Me.stamp2.FieldName = "stamp2"
        Me.stamp2.Name = "stamp2"
        Me.stamp2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "stamp2", "{0:0.##}")})
        Me.stamp2.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.stamp2.Visible = True
        Me.stamp2.VisibleIndex = 27
        Me.stamp2.Width = 20
        '
        'colsebal
        '
        Me.colsebal.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.colsebal.AppearanceCell.BackColor2 = System.Drawing.Color.Magenta
        Me.colsebal.AppearanceCell.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.colsebal.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colsebal.AppearanceCell.Options.UseBackColor = True
        Me.colsebal.AppearanceCell.Options.UseBorderColor = True
        Me.colsebal.AppearanceCell.Options.UseFont = True
        Me.colsebal.AppearanceHeader.BackColor = System.Drawing.Color.Yellow
        Me.colsebal.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.colsebal.AppearanceHeader.BorderColor = System.Drawing.Color.Green
        Me.colsebal.AppearanceHeader.Options.UseBackColor = True
        Me.colsebal.AppearanceHeader.Options.UseBorderColor = True
        Me.colsebal.Caption = "colsebal"
        Me.colsebal.FieldName = "colsebal"
        Me.colsebal.Name = "colsebal"
        Me.colsebal.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.colsebal.Visible = True
        Me.colsebal.VisibleIndex = 28
        Me.colsebal.Width = 99
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SimpleButton3.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SimpleButton3.Appearance.BorderColor = System.Drawing.Color.Blue
        Me.SimpleButton3.Appearance.Options.UseBackColor = True
        Me.SimpleButton3.Appearance.Options.UseBorderColor = True
        Me.SimpleButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SimpleButton3.Location = New System.Drawing.Point(413, 0)
        Me.SimpleButton3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(55, 47)
        Me.SimpleButton3.TabIndex = 11
        Me.SimpleButton3.Text = "&Print"
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
        Me.SimpleButton1.Location = New System.Drawing.Point(325, 0)
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(55, 47)
        Me.SimpleButton1.TabIndex = 12
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Controls.Add(Me.SimpleButton3)
        Me.PanelControl1.Location = New System.Drawing.Point(0, 5)
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1516, 49)
        Me.PanelControl1.TabIndex = 13
        '
        'PanelControl2
        '
        Me.PanelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PanelControl2.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PanelControl2.Appearance.BorderColor = System.Drawing.Color.Red
        Me.PanelControl2.Appearance.Options.UseBackColor = True
        Me.PanelControl2.Appearance.Options.UseBorderColor = True
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.PanelControl2.Controls.Add(Me.TextBox1)
        Me.PanelControl2.Controls.Add(Me.SimpleButton1)
        Me.PanelControl2.Controls.Add(Me.ComboBox1)
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(405, 49)
        Me.PanelControl2.TabIndex = 6
        '
        'monthlyReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1515, 661)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.GridControl1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "monthlyReport"
        Me.Text = "monthlyReport"
        CType(Me.XpDataView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XpDataView1 As DevExpress.Xpo.XPDataView
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents D_ate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OpeningBalance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CashReceive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SavingBalance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RDDeposit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RDFine As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SSADeposit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SSAFine As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TDDeposit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RPLIDeposit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RPLIFine As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RPLITax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents VPP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OtherColl1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OtherColl2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TotalDep As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CashRemt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SBWith As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RDWith As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TDWith As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SSAWith As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RPLIWith As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MONwith As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents othwith As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents totalwith As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents curr_ency As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents stamp1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents stamp2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsebal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
End Class
