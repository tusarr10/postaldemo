<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class expdlist
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(expdlist))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.d_ate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.y_ear = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.type = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.N_BO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.N_SO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.N_HO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PSS_25 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PSS_720 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UPD_34 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UPD_18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MOCISU_24 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MOCPAID_35 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IPOSOLD_25 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IPOPAID_25 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LIVEAC_6374 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SILANTAC_967 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SSCSBTRNS_2185 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MGNREG_2488 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GDSBPM_PAY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GDSMD_PAY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GDSMC_PAY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FIXADD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PSOLD5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.IOC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PLB = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SimpleButton1)
        Me.Panel1.Controls.Add(Me.TextEdit1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1501, 103)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GridControl1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 103)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1501, 487)
        Me.Panel2.TabIndex = 1
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1501, 487)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ID, Me.d_ate, Me.y_ear, Me.type, Me.N_BO, Me.N_SO, Me.N_HO, Me.PSS_25, Me.PSS_720, Me.UPD_34, Me.UPD_18, Me.MOCISU_24, Me.MOCPAID_35, Me.IPOSOLD_25, Me.IPOPAID_25, Me.LIVEAC_6374, Me.SILANTAC_967, Me.SSCSBTRNS_2185, Me.MGNREG_2488, Me.GDSBPM_PAY, Me.GDSMD_PAY, Me.GDSMC_PAY, Me.FIXADD, Me.PSOLD5, Me.IOC, Me.PLB})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'ID
        '
        Me.ID.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ID.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ID.AppearanceCell.BorderColor = System.Drawing.Color.Fuchsia
        Me.ID.AppearanceCell.Options.UseBackColor = True
        Me.ID.AppearanceCell.Options.UseBorderColor = True
        Me.ID.Caption = "ID"
        Me.ID.FieldName = "ID"
        Me.ID.Name = "ID"
        Me.ID.Visible = True
        Me.ID.VisibleIndex = 0
        '
        'd_ate
        '
        Me.d_ate.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.d_ate.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.d_ate.AppearanceCell.BorderColor = System.Drawing.Color.Red
        Me.d_ate.AppearanceCell.Options.UseBackColor = True
        Me.d_ate.AppearanceCell.Options.UseBorderColor = True
        Me.d_ate.Caption = "Date"
        Me.d_ate.FieldName = "d_ate"
        Me.d_ate.Name = "d_ate"
        Me.d_ate.Visible = True
        Me.d_ate.VisibleIndex = 1
        '
        'y_ear
        '
        Me.y_ear.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.y_ear.AppearanceCell.BackColor2 = System.Drawing.Color.Blue
        Me.y_ear.AppearanceCell.BorderColor = System.Drawing.Color.Fuchsia
        Me.y_ear.AppearanceCell.Options.UseBackColor = True
        Me.y_ear.AppearanceCell.Options.UseBorderColor = True
        Me.y_ear.Caption = "Year"
        Me.y_ear.FieldName = "y_ear"
        Me.y_ear.Name = "y_ear"
        Me.y_ear.Visible = True
        Me.y_ear.VisibleIndex = 2
        '
        'type
        '
        Me.type.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.type.AppearanceCell.BackColor2 = System.Drawing.Color.Red
        Me.type.AppearanceCell.BorderColor = System.Drawing.Color.Lime
        Me.type.AppearanceCell.Options.UseBackColor = True
        Me.type.AppearanceCell.Options.UseBorderColor = True
        Me.type.Caption = "Type"
        Me.type.FieldName = "type"
        Me.type.Name = "type"
        Me.type.Visible = True
        Me.type.VisibleIndex = 3
        '
        'N_BO
        '
        Me.N_BO.Caption = "Bo Name"
        Me.N_BO.FieldName = "N_BO"
        Me.N_BO.Name = "N_BO"
        Me.N_BO.Visible = True
        Me.N_BO.VisibleIndex = 4
        '
        'N_SO
        '
        Me.N_SO.Caption = "So Name"
        Me.N_SO.FieldName = "N_SO"
        Me.N_SO.Name = "N_SO"
        Me.N_SO.Visible = True
        Me.N_SO.VisibleIndex = 5
        '
        'N_HO
        '
        Me.N_HO.Caption = "Ho Name"
        Me.N_HO.FieldName = "N_HO"
        Me.N_HO.Name = "N_HO"
        Me.N_HO.Visible = True
        Me.N_HO.VisibleIndex = 6
        '
        'PSS_25
        '
        Me.PSS_25.Caption = "PSS_25"
        Me.PSS_25.FieldName = "PSS_25"
        Me.PSS_25.Name = "PSS_25"
        Me.PSS_25.Visible = True
        Me.PSS_25.VisibleIndex = 7
        '
        'PSS_720
        '
        Me.PSS_720.Caption = "PSS_720"
        Me.PSS_720.FieldName = "PSS_720"
        Me.PSS_720.Name = "PSS_720"
        Me.PSS_720.Visible = True
        Me.PSS_720.VisibleIndex = 8
        '
        'UPD_34
        '
        Me.UPD_34.Caption = "UPD_34"
        Me.UPD_34.FieldName = "UPD_34"
        Me.UPD_34.Name = "UPD_34"
        Me.UPD_34.Visible = True
        Me.UPD_34.VisibleIndex = 9
        '
        'UPD_18
        '
        Me.UPD_18.Caption = "GridColumn1"
        Me.UPD_18.FieldName = "UPD_18"
        Me.UPD_18.Name = "UPD_18"
        Me.UPD_18.Visible = True
        Me.UPD_18.VisibleIndex = 10
        '
        'MOCISU_24
        '
        Me.MOCISU_24.Caption = "MOCISU_24"
        Me.MOCISU_24.FieldName = "MOCISU_24"
        Me.MOCISU_24.Name = "MOCISU_24"
        Me.MOCISU_24.Visible = True
        Me.MOCISU_24.VisibleIndex = 11
        '
        'MOCPAID_35
        '
        Me.MOCPAID_35.Caption = "MOCPAID_35"
        Me.MOCPAID_35.FieldName = "MOCPAID_35"
        Me.MOCPAID_35.Name = "MOCPAID_35"
        Me.MOCPAID_35.Visible = True
        Me.MOCPAID_35.VisibleIndex = 12
        '
        'IPOSOLD_25
        '
        Me.IPOSOLD_25.Caption = "IPOSOLD_25"
        Me.IPOSOLD_25.FieldName = "IPOSOLD_25"
        Me.IPOSOLD_25.Name = "IPOSOLD_25"
        Me.IPOSOLD_25.Visible = True
        Me.IPOSOLD_25.VisibleIndex = 13
        '
        'IPOPAID_25
        '
        Me.IPOPAID_25.Caption = "IPOPAID_25"
        Me.IPOPAID_25.FieldName = "IPOPAID_25"
        Me.IPOPAID_25.Name = "IPOPAID_25"
        Me.IPOPAID_25.Visible = True
        Me.IPOPAID_25.VisibleIndex = 14
        '
        'LIVEAC_6374
        '
        Me.LIVEAC_6374.Caption = "LIVEAC_6374"
        Me.LIVEAC_6374.FieldName = "LIVEAC_6374"
        Me.LIVEAC_6374.Name = "LIVEAC_6374"
        Me.LIVEAC_6374.Visible = True
        Me.LIVEAC_6374.VisibleIndex = 15
        '
        'SILANTAC_967
        '
        Me.SILANTAC_967.Caption = "SILANTAC_967"
        Me.SILANTAC_967.FieldName = "SILANTAC_967"
        Me.SILANTAC_967.Name = "SILANTAC_967"
        Me.SILANTAC_967.Visible = True
        Me.SILANTAC_967.VisibleIndex = 16
        '
        'SSCSBTRNS_2185
        '
        Me.SSCSBTRNS_2185.Caption = "SSCSBTRNS_2185"
        Me.SSCSBTRNS_2185.FieldName = "SSCSBTRNS_2185"
        Me.SSCSBTRNS_2185.Name = "SSCSBTRNS_2185"
        Me.SSCSBTRNS_2185.Visible = True
        Me.SSCSBTRNS_2185.VisibleIndex = 17
        '
        'MGNREG_2488
        '
        Me.MGNREG_2488.Caption = "MGNREG_2488"
        Me.MGNREG_2488.FieldName = "MGNREG_2488"
        Me.MGNREG_2488.Name = "MGNREG_2488"
        Me.MGNREG_2488.Visible = True
        Me.MGNREG_2488.VisibleIndex = 18
        '
        'GDSBPM_PAY
        '
        Me.GDSBPM_PAY.Caption = "GDSBPM_PAY"
        Me.GDSBPM_PAY.FieldName = "GDSBPM_PAY"
        Me.GDSBPM_PAY.Name = "GDSBPM_PAY"
        Me.GDSBPM_PAY.Visible = True
        Me.GDSBPM_PAY.VisibleIndex = 19
        '
        'GDSMD_PAY
        '
        Me.GDSMD_PAY.Caption = "GDSMD_PAY"
        Me.GDSMD_PAY.FieldName = "GDSMD_PAY"
        Me.GDSMD_PAY.Name = "GDSMD_PAY"
        Me.GDSMD_PAY.Visible = True
        Me.GDSMD_PAY.VisibleIndex = 20
        '
        'GDSMC_PAY
        '
        Me.GDSMC_PAY.Caption = "GDSMC_PAY"
        Me.GDSMC_PAY.FieldName = "GDSMC_PAY"
        Me.GDSMC_PAY.Name = "GDSMC_PAY"
        Me.GDSMC_PAY.Visible = True
        Me.GDSMC_PAY.VisibleIndex = 21
        '
        'FIXADD
        '
        Me.FIXADD.Caption = "FIXADD"
        Me.FIXADD.FieldName = "FIXADD"
        Me.FIXADD.Name = "FIXADD"
        Me.FIXADD.Visible = True
        Me.FIXADD.VisibleIndex = 22
        '
        'PSOLD5
        '
        Me.PSOLD5.Caption = "PSOLD5"
        Me.PSOLD5.FieldName = "PSOLD5"
        Me.PSOLD5.Name = "PSOLD5"
        Me.PSOLD5.Visible = True
        Me.PSOLD5.VisibleIndex = 23
        '
        'IOC
        '
        Me.IOC.Caption = "IOC"
        Me.IOC.FieldName = "IOC"
        Me.IOC.Name = "IOC"
        Me.IOC.Visible = True
        Me.IOC.VisibleIndex = 24
        '
        'PLB
        '
        Me.PLB.Caption = "PLB"
        Me.PLB.FieldName = "PLB"
        Me.PLB.Name = "PLB"
        Me.PLB.Visible = True
        Me.PLB.VisibleIndex = 25
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(12, 60)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(258, 22)
        Me.TextEdit1.TabIndex = 0
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(301, 63)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(39, 23)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "SimpleButton1"
        '
        'expdlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1501, 590)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "expdlist"
        Me.Text = "expdlist"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents d_ate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents y_ear As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents N_BO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents N_SO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents N_HO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PSS_25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PSS_720 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UPD_34 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UPD_18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MOCISU_24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MOCPAID_35 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IPOSOLD_25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IPOPAID_25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LIVEAC_6374 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SILANTAC_967 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SSCSBTRNS_2185 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MGNREG_2488 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GDSBPM_PAY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GDSMD_PAY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GDSMC_PAY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FIXADD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PSOLD5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents IOC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PLB As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
