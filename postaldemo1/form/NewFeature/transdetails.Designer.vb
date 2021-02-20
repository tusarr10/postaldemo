<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class transdetails
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(transdetails))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.D_ate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.AccountType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.accountNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AccountHolderName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.deposit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.withdrow = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.balance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DLT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.remark = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.Location = New System.Drawing.Point(0, 42)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(967, 495)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.D_ate, Me.AccountType, Me.accountNumber, Me.AccountHolderName, Me.deposit, Me.withdrow, Me.balance, Me.DLT, Me.remark})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'D_ate
        '
        Me.D_ate.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.D_ate.AppearanceCell.BackColor2 = System.Drawing.Color.Cyan
        Me.D_ate.AppearanceCell.BorderColor = System.Drawing.Color.Yellow
        Me.D_ate.AppearanceCell.Options.UseBackColor = True
        Me.D_ate.AppearanceCell.Options.UseBorderColor = True
        Me.D_ate.AppearanceHeader.BackColor = System.Drawing.Color.Magenta
        Me.D_ate.AppearanceHeader.BackColor2 = System.Drawing.Color.Blue
        Me.D_ate.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.D_ate.AppearanceHeader.Options.UseBackColor = True
        Me.D_ate.AppearanceHeader.Options.UseBorderColor = True
        Me.D_ate.Caption = "Date"
        Me.D_ate.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.D_ate.FieldName = "D_ate"
        Me.D_ate.Name = "D_ate"
        Me.D_ate.OptionsColumn.AllowEdit = False
        Me.D_ate.Visible = True
        Me.D_ate.VisibleIndex = 0
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.DisplayFormat.FormatString = "dd MMMM yyyy"
        Me.RepositoryItemDateEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.RepositoryItemDateEdit1.EditFormat.FormatString = "dd MMMM yyyy"
        Me.RepositoryItemDateEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.RepositoryItemDateEdit1.Mask.EditMask = "dd MMMM yyyy"
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        Me.RepositoryItemDateEdit1.ReadOnly = True
        '
        'AccountType
        '
        Me.AccountType.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.AccountType.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.AccountType.AppearanceCell.BorderColor = System.Drawing.Color.Blue
        Me.AccountType.AppearanceCell.Options.UseBackColor = True
        Me.AccountType.AppearanceCell.Options.UseBorderColor = True
        Me.AccountType.FieldName = "AccountType"
        Me.AccountType.Name = "AccountType"
        Me.AccountType.Visible = True
        Me.AccountType.VisibleIndex = 1
        '
        'accountNumber
        '
        Me.accountNumber.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.accountNumber.AppearanceCell.BackColor2 = System.Drawing.Color.Cyan
        Me.accountNumber.AppearanceCell.BorderColor = System.Drawing.Color.Yellow
        Me.accountNumber.AppearanceCell.Options.UseBackColor = True
        Me.accountNumber.AppearanceCell.Options.UseBorderColor = True
        Me.accountNumber.AppearanceHeader.BackColor = System.Drawing.Color.Magenta
        Me.accountNumber.AppearanceHeader.BackColor2 = System.Drawing.Color.Blue
        Me.accountNumber.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.accountNumber.AppearanceHeader.Options.UseBackColor = True
        Me.accountNumber.AppearanceHeader.Options.UseBorderColor = True
        Me.accountNumber.FieldName = "accountNumber"
        Me.accountNumber.Name = "accountNumber"
        Me.accountNumber.Visible = True
        Me.accountNumber.VisibleIndex = 2
        '
        'AccountHolderName
        '
        Me.AccountHolderName.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.AccountHolderName.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.AccountHolderName.AppearanceCell.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AccountHolderName.AppearanceCell.Options.UseBackColor = True
        Me.AccountHolderName.AppearanceCell.Options.UseBorderColor = True
        Me.AccountHolderName.AppearanceHeader.BackColor = System.Drawing.Color.Navy
        Me.AccountHolderName.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AccountHolderName.AppearanceHeader.BorderColor = System.Drawing.Color.Magenta
        Me.AccountHolderName.AppearanceHeader.Options.UseBackColor = True
        Me.AccountHolderName.AppearanceHeader.Options.UseBorderColor = True
        Me.AccountHolderName.FieldName = "AccountHolderName"
        Me.AccountHolderName.Name = "AccountHolderName"
        Me.AccountHolderName.Visible = True
        Me.AccountHolderName.VisibleIndex = 3
        '
        'deposit
        '
        Me.deposit.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.deposit.AppearanceCell.BackColor2 = System.Drawing.Color.Cyan
        Me.deposit.AppearanceCell.BorderColor = System.Drawing.Color.Yellow
        Me.deposit.AppearanceCell.Options.UseBackColor = True
        Me.deposit.AppearanceCell.Options.UseBorderColor = True
        Me.deposit.AppearanceHeader.BackColor = System.Drawing.Color.Magenta
        Me.deposit.AppearanceHeader.BackColor2 = System.Drawing.Color.Blue
        Me.deposit.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.deposit.AppearanceHeader.Options.UseBackColor = True
        Me.deposit.AppearanceHeader.Options.UseBorderColor = True
        Me.deposit.FieldName = "deposit"
        Me.deposit.Name = "deposit"
        Me.deposit.Visible = True
        Me.deposit.VisibleIndex = 4
        '
        'withdrow
        '
        Me.withdrow.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.withdrow.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.withdrow.AppearanceCell.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.withdrow.AppearanceCell.Options.UseBackColor = True
        Me.withdrow.AppearanceCell.Options.UseBorderColor = True
        Me.withdrow.AppearanceHeader.BackColor = System.Drawing.Color.Navy
        Me.withdrow.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.withdrow.AppearanceHeader.BorderColor = System.Drawing.Color.Magenta
        Me.withdrow.AppearanceHeader.Options.UseBackColor = True
        Me.withdrow.AppearanceHeader.Options.UseBorderColor = True
        Me.withdrow.FieldName = "withdrow"
        Me.withdrow.Name = "withdrow"
        Me.withdrow.Visible = True
        Me.withdrow.VisibleIndex = 5
        '
        'balance
        '
        Me.balance.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.balance.AppearanceCell.BackColor2 = System.Drawing.Color.Cyan
        Me.balance.AppearanceCell.BorderColor = System.Drawing.Color.Yellow
        Me.balance.AppearanceCell.Options.UseBackColor = True
        Me.balance.AppearanceCell.Options.UseBorderColor = True
        Me.balance.AppearanceHeader.BackColor = System.Drawing.Color.Magenta
        Me.balance.AppearanceHeader.BackColor2 = System.Drawing.Color.Blue
        Me.balance.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.balance.AppearanceHeader.Options.UseBackColor = True
        Me.balance.AppearanceHeader.Options.UseBorderColor = True
        Me.balance.FieldName = "balance"
        Me.balance.Name = "balance"
        Me.balance.Visible = True
        Me.balance.VisibleIndex = 6
        '
        'DLT
        '
        Me.DLT.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DLT.AppearanceCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DLT.AppearanceCell.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DLT.AppearanceCell.Options.UseBackColor = True
        Me.DLT.AppearanceCell.Options.UseBorderColor = True
        Me.DLT.AppearanceHeader.BackColor = System.Drawing.Color.Navy
        Me.DLT.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DLT.AppearanceHeader.BorderColor = System.Drawing.Color.Magenta
        Me.DLT.AppearanceHeader.Options.UseBackColor = True
        Me.DLT.AppearanceHeader.Options.UseBorderColor = True
        Me.DLT.FieldName = "DLT"
        Me.DLT.Name = "DLT"
        Me.DLT.Visible = True
        Me.DLT.VisibleIndex = 7
        '
        'remark
        '
        Me.remark.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.remark.AppearanceCell.BackColor2 = System.Drawing.Color.Cyan
        Me.remark.AppearanceCell.BorderColor = System.Drawing.Color.Yellow
        Me.remark.AppearanceCell.Options.UseBackColor = True
        Me.remark.AppearanceCell.Options.UseBorderColor = True
        Me.remark.AppearanceHeader.BackColor = System.Drawing.Color.Magenta
        Me.remark.AppearanceHeader.BackColor2 = System.Drawing.Color.Blue
        Me.remark.AppearanceHeader.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.remark.AppearanceHeader.Options.UseBackColor = True
        Me.remark.AppearanceHeader.Options.UseBorderColor = True
        Me.remark.FieldName = "remark"
        Me.remark.Name = "remark"
        Me.remark.Visible = True
        Me.remark.VisibleIndex = 8
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd MMMM yyyy"
        Me.DateTimePicker1.Location = New System.Drawing.Point(8, 5)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 21)
        Me.DateTimePicker1.TabIndex = 1
        Me.DateTimePicker1.Value = New Date(2019, 12, 15, 0, 0, 0, 0)
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
        Me.SimpleButton3.Location = New System.Drawing.Point(287, 4)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(41, 38)
        Me.SimpleButton3.TabIndex = 12
        Me.SimpleButton3.Text = "&Print"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SimpleButton4.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SimpleButton4.Appearance.BorderColor = System.Drawing.Color.Aqua
        Me.SimpleButton4.Appearance.Options.UseBackColor = True
        Me.SimpleButton4.Appearance.Options.UseBorderColor = True
        Me.SimpleButton4.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SimpleButton4.Location = New System.Drawing.Point(226, 0)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(41, 38)
        Me.SimpleButton4.TabIndex = 11
        Me.SimpleButton4.Text = "&Show"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.SimpleButton4)
        Me.Panel1.Location = New System.Drawing.Point(4, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(277, 40)
        Me.Panel1.TabIndex = 13
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.SimpleButton3)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(969, 47)
        Me.Panel2.TabIndex = 14
        '
        'transdetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(968, 539)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "transdetails"
        Me.Text = "transdetails"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents D_ate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AccountType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents accountNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AccountHolderName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents deposit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents withdrow As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents balance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DLT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents remark As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
End Class
