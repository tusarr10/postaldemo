﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tdAc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tdAc))
        Me.DNT = New System.Windows.Forms.DateTimePicker()
        Me.DLT = New System.Windows.Forms.DateTimePicker()
        Me.PictureEdit2 = New DevExpress.XtraEditors.PictureEdit()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.btnUpdate_record = New DevExpress.XtraEditors.SimpleButton()
        Me.Button1 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDelete = New DevExpress.XtraEditors.SimpleButton()
        Me.btnNewRecord = New DevExpress.XtraEditors.SimpleButton()
        Me.Remark = New DevExpress.XtraEditors.MemoEdit()
        Me.ACBAL = New System.Windows.Forms.Label()
        Me.BalAfterTrans = New System.Windows.Forms.TextBox()
        Me.Accountbal = New System.Windows.Forms.TextBox()
        Me.tranfamt = New System.Windows.Forms.TextBox()
        Me.to_date = New System.Windows.Forms.DateTimePicker()
        Me.NameOfDepositer = New System.Windows.Forms.TextBox()
        Me.AccountHolderName = New System.Windows.Forms.TextBox()
        Me.account_no = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.Label7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.Label6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.Button2 = New DevExpress.XtraEditors.SimpleButton()
        Me.Button3 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        CType(Me.Remark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DNT
        '
        Me.DNT.Location = New System.Drawing.Point(220, 496)
        Me.DNT.Name = "DNT"
        Me.DNT.Size = New System.Drawing.Size(141, 20)
        Me.DNT.TabIndex = 666
        '
        'DLT
        '
        Me.DLT.Location = New System.Drawing.Point(225, 456)
        Me.DLT.Name = "DLT"
        Me.DLT.Size = New System.Drawing.Size(141, 20)
        Me.DLT.TabIndex = 66
        '
        'PictureEdit2
        '
        Me.PictureEdit2.Location = New System.Drawing.Point(417, 271)
        Me.PictureEdit2.Name = "PictureEdit2"
        Me.PictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit2.Size = New System.Drawing.Size(180, 88)
        Me.PictureEdit2.TabIndex = 158
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Location = New System.Drawing.Point(417, 153)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit1.Size = New System.Drawing.Size(180, 112)
        Me.PictureEdit1.TabIndex = 157
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(85, 50)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 140
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(19, 46)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 18)
        Me.Label11.TabIndex = 139
        Me.Label11.Text = "Auto Fill"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(30, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 18)
        Me.Label1.TabIndex = 130
        Me.Label1.Text = "SN"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton2.Location = New System.Drawing.Point(19, 22)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(80, 20)
        Me.RadioButton2.TabIndex = 30
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Deposit"
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'panel1
        '
        Me.panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel1.BackColor = System.Drawing.Color.Transparent
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel1.Controls.Add(Me.btnUpdate_record)
        Me.panel1.Controls.Add(Me.Button1)
        Me.panel1.Controls.Add(Me.btnSave)
        Me.panel1.Controls.Add(Me.btnDelete)
        Me.panel1.Controls.Add(Me.btnNewRecord)
        Me.panel1.Location = New System.Drawing.Point(455, 365)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(129, 210)
        Me.panel1.TabIndex = 155
        '
        'btnUpdate_record
        '
        Me.btnUpdate_record.Appearance.BackColor = System.Drawing.Color.Blue
        Me.btnUpdate_record.Appearance.BackColor2 = System.Drawing.Color.Red
        Me.btnUpdate_record.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUpdate_record.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate_record.Appearance.ForeColor = System.Drawing.Color.Yellow
        Me.btnUpdate_record.Appearance.Options.UseBackColor = True
        Me.btnUpdate_record.Appearance.Options.UseBorderColor = True
        Me.btnUpdate_record.Appearance.Options.UseFont = True
        Me.btnUpdate_record.Appearance.Options.UseForeColor = True
        Me.btnUpdate_record.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btnUpdate_record.Image = CType(resources.GetObject("btnUpdate_record.Image"), System.Drawing.Image)
        Me.btnUpdate_record.Location = New System.Drawing.Point(21, 130)
        Me.btnUpdate_record.Name = "btnUpdate_record"
        Me.btnUpdate_record.Size = New System.Drawing.Size(84, 35)
        Me.btnUpdate_record.TabIndex = 658
        Me.btnUpdate_record.Text = "&Update"
        '
        'Button1
        '
        Me.Button1.Appearance.BackColor = System.Drawing.Color.Blue
        Me.Button1.Appearance.BackColor2 = System.Drawing.Color.Red
        Me.Button1.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Appearance.ForeColor = System.Drawing.Color.Yellow
        Me.Button1.Appearance.Options.UseBackColor = True
        Me.Button1.Appearance.Options.UseBorderColor = True
        Me.Button1.Appearance.Options.UseFont = True
        Me.Button1.Appearance.Options.UseForeColor = True
        Me.Button1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(21, 169)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 35)
        Me.Button1.TabIndex = 659
        Me.Button1.Text = "&Verify"
        '
        'btnSave
        '
        Me.btnSave.Appearance.BackColor = System.Drawing.Color.Blue
        Me.btnSave.Appearance.BackColor2 = System.Drawing.Color.Red
        Me.btnSave.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Appearance.ForeColor = System.Drawing.Color.Yellow
        Me.btnSave.Appearance.Options.UseBackColor = True
        Me.btnSave.Appearance.Options.UseBorderColor = True
        Me.btnSave.Appearance.Options.UseFont = True
        Me.btnSave.Appearance.Options.UseForeColor = True
        Me.btnSave.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btnSave.Enabled = False
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(21, 89)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(84, 35)
        Me.btnSave.TabIndex = 657
        Me.btnSave.Text = "&Save"
        '
        'btnDelete
        '
        Me.btnDelete.Appearance.BackColor = System.Drawing.Color.Blue
        Me.btnDelete.Appearance.BackColor2 = System.Drawing.Color.Red
        Me.btnDelete.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDelete.Appearance.Font = New System.Drawing.Font("Tahoma", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Appearance.ForeColor = System.Drawing.Color.Yellow
        Me.btnDelete.Appearance.Options.UseBackColor = True
        Me.btnDelete.Appearance.Options.UseBorderColor = True
        Me.btnDelete.Appearance.Options.UseFont = True
        Me.btnDelete.Appearance.Options.UseForeColor = True
        Me.btnDelete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.Location = New System.Drawing.Point(21, 48)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(84, 35)
        Me.btnDelete.TabIndex = 656
        Me.btnDelete.Text = "&Calculate"
        '
        'btnNewRecord
        '
        Me.btnNewRecord.Appearance.BackColor = System.Drawing.Color.Blue
        Me.btnNewRecord.Appearance.BackColor2 = System.Drawing.Color.Red
        Me.btnNewRecord.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnNewRecord.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewRecord.Appearance.ForeColor = System.Drawing.Color.Yellow
        Me.btnNewRecord.Appearance.Options.UseBackColor = True
        Me.btnNewRecord.Appearance.Options.UseBorderColor = True
        Me.btnNewRecord.Appearance.Options.UseFont = True
        Me.btnNewRecord.Appearance.Options.UseForeColor = True
        Me.btnNewRecord.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.btnNewRecord.Image = CType(resources.GetObject("btnNewRecord.Image"), System.Drawing.Image)
        Me.btnNewRecord.Location = New System.Drawing.Point(21, 7)
        Me.btnNewRecord.Name = "btnNewRecord"
        Me.btnNewRecord.Size = New System.Drawing.Size(84, 35)
        Me.btnNewRecord.TabIndex = 655
        Me.btnNewRecord.Text = "&New"
        '
        'Remark
        '
        Me.Remark.EditValue = ""
        Me.Remark.Location = New System.Drawing.Point(220, 525)
        Me.Remark.Name = "Remark"
        Me.Remark.Size = New System.Drawing.Size(191, 50)
        Me.Remark.TabIndex = 7
        '
        'ACBAL
        '
        Me.ACBAL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ACBAL.AutoSize = True
        Me.ACBAL.BackColor = System.Drawing.Color.Transparent
        Me.ACBAL.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ACBAL.ForeColor = System.Drawing.Color.Black
        Me.ACBAL.Location = New System.Drawing.Point(421, 121)
        Me.ACBAL.Name = "ACBAL"
        Me.ACBAL.Size = New System.Drawing.Size(0, 18)
        Me.ACBAL.TabIndex = 152
        '
        'BalAfterTrans
        '
        Me.BalAfterTrans.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.BalAfterTrans.Enabled = False
        Me.BalAfterTrans.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BalAfterTrans.Location = New System.Drawing.Point(225, 416)
        Me.BalAfterTrans.Name = "BalAfterTrans"
        Me.BalAfterTrans.Size = New System.Drawing.Size(141, 22)
        Me.BalAfterTrans.TabIndex = 55
        '
        'Accountbal
        '
        Me.Accountbal.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Accountbal.Enabled = False
        Me.Accountbal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Accountbal.Location = New System.Drawing.Point(225, 332)
        Me.Accountbal.Name = "Accountbal"
        Me.Accountbal.Size = New System.Drawing.Size(141, 22)
        Me.Accountbal.TabIndex = 44
        '
        'tranfamt
        '
        Me.tranfamt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tranfamt.Location = New System.Drawing.Point(225, 376)
        Me.tranfamt.Name = "tranfamt"
        Me.tranfamt.Size = New System.Drawing.Size(141, 22)
        Me.tranfamt.TabIndex = 5
        '
        'to_date
        '
        Me.to_date.Location = New System.Drawing.Point(225, 286)
        Me.to_date.Name = "to_date"
        Me.to_date.Size = New System.Drawing.Size(141, 20)
        Me.to_date.TabIndex = 4
        '
        'NameOfDepositer
        '
        Me.NameOfDepositer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameOfDepositer.Location = New System.Drawing.Point(225, 243)
        Me.NameOfDepositer.Name = "NameOfDepositer"
        Me.NameOfDepositer.Size = New System.Drawing.Size(186, 22)
        Me.NameOfDepositer.TabIndex = 3
        '
        'AccountHolderName
        '
        Me.AccountHolderName.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.AccountHolderName.Enabled = False
        Me.AccountHolderName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccountHolderName.Location = New System.Drawing.Point(225, 203)
        Me.AccountHolderName.Name = "AccountHolderName"
        Me.AccountHolderName.Size = New System.Drawing.Size(186, 22)
        Me.AccountHolderName.TabIndex = 2
        '
        'account_no
        '
        Me.account_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.account_no.Location = New System.Drawing.Point(225, 163)
        Me.account_no.Name = "account_no"
        Me.account_no.Size = New System.Drawing.Size(141, 22)
        Me.account_no.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(222, 131)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(27, 18)
        Me.Label14.TabIndex = 144
        Me.Label14.Text = "SN"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton1.Location = New System.Drawing.Point(123, 22)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(104, 20)
        Me.RadioButton1.TabIndex = 75
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "WithDrowal"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Blue
        Me.Label13.Location = New System.Drawing.Point(164, -2)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(327, 25)
        Me.Label13.TabIndex = 143
        Me.Label13.Text = "Time Deposit Account Journal"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(182, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(229, 58)
        Me.GroupBox1.TabIndex = 142
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transction Type"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LabelControl9.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl9.LineVisible = True
        Me.LabelControl9.Location = New System.Drawing.Point(28, 523)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(43, 18)
        Me.LabelControl9.TabIndex = 680
        Me.LabelControl9.Text = "Notes :"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LabelControl6.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl6.LineVisible = True
        Me.LabelControl6.Location = New System.Drawing.Point(28, 485)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(145, 18)
        Me.LabelControl6.TabIndex = 679
        Me.LabelControl6.Text = "Last 2 Transction Date  :"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LabelControl7.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl7.LineVisible = True
        Me.LabelControl7.Location = New System.Drawing.Point(28, 443)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(135, 18)
        Me.LabelControl7.TabIndex = 678
        Me.LabelControl7.Text = " Last Transction Date :"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LabelControl8.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl8.LineVisible = True
        Me.LabelControl8.Location = New System.Drawing.Point(28, 409)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(157, 18)
        Me.LabelControl8.TabIndex = 677
        Me.LabelControl8.Text = "Balance After Transction :"
        '
        'Label7
        '
        Me.Label7.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label7.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label7.Appearance.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.LineVisible = True
        Me.Label7.Location = New System.Drawing.Point(30, 369)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 18)
        Me.Label7.TabIndex = 676
        Me.Label7.Text = "Transction Amount:"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LabelControl10.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl10.LineVisible = True
        Me.LabelControl10.Location = New System.Drawing.Point(30, 329)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(167, 18)
        Me.LabelControl10.TabIndex = 675
        Me.LabelControl10.Text = "Balance Before Transction :"
        '
        'Label6
        '
        Me.Label6.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label6.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.Appearance.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.LineVisible = True
        Me.Label6.Location = New System.Drawing.Point(294, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 18)
        Me.Label6.TabIndex = 674
        Me.Label6.Text = "Account  Balance  :"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LabelControl4.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl4.LineVisible = True
        Me.LabelControl4.Location = New System.Drawing.Point(31, 281)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(103, 18)
        Me.LabelControl4.TabIndex = 673
        Me.LabelControl4.Text = "Date And Time  :"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LabelControl3.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl3.LineVisible = True
        Me.LabelControl3.Location = New System.Drawing.Point(31, 247)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(126, 18)
        Me.LabelControl3.TabIndex = 672
        Me.LabelControl3.Text = "Name Of Depositer :"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LabelControl2.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.LineVisible = True
        Me.LabelControl2.Location = New System.Drawing.Point(33, 207)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(143, 18)
        Me.LabelControl2.TabIndex = 671
        Me.LabelControl2.Text = "Account  Holder Nmae:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LabelControl1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.LineVisible = True
        Me.LabelControl1.Location = New System.Drawing.Point(33, 167)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(114, 18)
        Me.LabelControl1.TabIndex = 670
        Me.LabelControl1.Text = "Account  Number :"
        '
        'Button2
        '
        Me.Button2.Appearance.BackColor = System.Drawing.Color.Blue
        Me.Button2.Appearance.BackColor2 = System.Drawing.Color.Red
        Me.Button2.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Appearance.ForeColor = System.Drawing.Color.Yellow
        Me.Button2.Appearance.Options.UseBackColor = True
        Me.Button2.Appearance.Options.UseBorderColor = True
        Me.Button2.Appearance.Options.UseFont = True
        Me.Button2.Appearance.Options.UseForeColor = True
        Me.Button2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(393, 163)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(20, 20)
        Me.Button2.TabIndex = 681
        Me.Button2.Text = "&Find"
        '
        'Button3
        '
        Me.Button3.Appearance.BackColor = System.Drawing.Color.Blue
        Me.Button3.Appearance.BackColor2 = System.Drawing.Color.Red
        Me.Button3.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Appearance.ForeColor = System.Drawing.Color.Yellow
        Me.Button3.Appearance.Options.UseBackColor = True
        Me.Button3.Appearance.Options.UseBorderColor = True
        Me.Button3.Appearance.Options.UseFont = True
        Me.Button3.Appearance.Options.UseForeColor = True
        Me.Button3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(370, 163)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(20, 20)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "&Find"
        '
        'tdAc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(637, 612)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.DNT)
        Me.Controls.Add(Me.DLT)
        Me.Controls.Add(Me.PictureEdit2)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.Remark)
        Me.Controls.Add(Me.ACBAL)
        Me.Controls.Add(Me.BalAfterTrans)
        Me.Controls.Add(Me.Accountbal)
        Me.Controls.Add(Me.tranfamt)
        Me.Controls.Add(Me.to_date)
        Me.Controls.Add(Me.NameOfDepositer)
        Me.Controls.Add(Me.AccountHolderName)
        Me.Controls.Add(Me.account_no)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.GroupBox1)
        Me.KeyPreview = True
        Me.Name = "tdAc"
        Me.Text = "tdAc"
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        CType(Me.Remark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DNT As System.Windows.Forms.DateTimePicker
    Friend WithEvents DLT As System.Windows.Forms.DateTimePicker
    Friend WithEvents PictureEdit2 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Private WithEvents Label11 As System.Windows.Forms.Label
    Private WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Friend WithEvents Remark As DevExpress.XtraEditors.MemoEdit
    Private WithEvents ACBAL As System.Windows.Forms.Label
    Friend WithEvents BalAfterTrans As System.Windows.Forms.TextBox
    Friend WithEvents Accountbal As System.Windows.Forms.TextBox
    Friend WithEvents tranfamt As System.Windows.Forms.TextBox
    Friend WithEvents to_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents NameOfDepositer As System.Windows.Forms.TextBox
    Friend WithEvents AccountHolderName As System.Windows.Forms.TextBox
    Friend WithEvents account_no As System.Windows.Forms.TextBox
    Private WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnUpdate_record As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNewRecord As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Button3 As DevExpress.XtraEditors.SimpleButton
End Class
