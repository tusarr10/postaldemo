<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settingfrm
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
        Dim SuperToolTip8 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem15 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settingfrm))
        Dim ToolTipItem8 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipTitleItem16 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip9 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem17 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem9 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipTitleItem18 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip10 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem19 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem10 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipTitleItem20 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip11 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem21 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem11 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim ToolTipTitleItem22 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.ToolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(83, 240)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(349, 48)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Test"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 55)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 30)
        ToolTipTitleItem15.Appearance.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        ToolTipTitleItem15.Appearance.Options.UseImage = True
        ToolTipTitleItem15.Image = CType(resources.GetObject("ToolTipTitleItem15.Image"), System.Drawing.Image)
        ToolTipTitleItem15.Text = "Database Connect !!.."
        ToolTipItem8.Appearance.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        ToolTipItem8.Appearance.Options.UseImage = True
        ToolTipItem8.Image = CType(resources.GetObject("ToolTipItem8.Image"), System.Drawing.Image)
        ToolTipItem8.LeftIndent = 6
        ToolTipItem8.Text = "Enter Your Office Name To Connect !!.."
        ToolTipTitleItem16.Appearance.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        ToolTipTitleItem16.Appearance.Options.UseImage = True
        ToolTipTitleItem16.Image = CType(resources.GetObject("ToolTipTitleItem16.Image"), System.Drawing.Image)
        ToolTipTitleItem16.LeftIndent = 6
        ToolTipTitleItem16.Text = "Information !!.."
        SuperToolTip8.Items.Add(ToolTipTitleItem15)
        SuperToolTip8.Items.Add(ToolTipItem8)
        SuperToolTip8.Items.Add(ToolTipTitleItem16)
        Me.ToolTipController1.SetSuperTip(Me.Label1, SuperToolTip8)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Data Base Name :"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(225, 60)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(183, 24)
        ToolTipTitleItem17.Appearance.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
        ToolTipTitleItem17.Appearance.Options.UseImage = True
        ToolTipTitleItem17.Image = CType(resources.GetObject("ToolTipTitleItem17.Image"), System.Drawing.Image)
        ToolTipTitleItem17.Text = "Database Connect !!.."
        ToolTipItem9.Appearance.Image = CType(resources.GetObject("resource.Image4"), System.Drawing.Image)
        ToolTipItem9.Appearance.Options.UseImage = True
        ToolTipItem9.Image = CType(resources.GetObject("ToolTipItem9.Image"), System.Drawing.Image)
        ToolTipItem9.LeftIndent = 6
        ToolTipItem9.Text = "Enter Your Office Name To Connect !!.."
        ToolTipTitleItem18.Appearance.Image = CType(resources.GetObject("resource.Image5"), System.Drawing.Image)
        ToolTipTitleItem18.Appearance.Options.UseImage = True
        ToolTipTitleItem18.Image = CType(resources.GetObject("ToolTipTitleItem18.Image"), System.Drawing.Image)
        ToolTipTitleItem18.LeftIndent = 6
        ToolTipTitleItem18.Text = "Information !!.."
        SuperToolTip9.Items.Add(ToolTipTitleItem17)
        SuperToolTip9.Items.Add(ToolTipItem9)
        SuperToolTip9.Items.Add(ToolTipTitleItem18)
        Me.ToolTipController1.SetSuperTip(Me.TextBox1, SuperToolTip9)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = "Database1.accdb"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 126)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(205, 30)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Data Base Password :"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(225, 124)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(183, 24)
        ToolTipTitleItem19.Appearance.Image = CType(resources.GetObject("resource.Image6"), System.Drawing.Image)
        ToolTipTitleItem19.Appearance.Options.UseImage = True
        ToolTipTitleItem19.Image = CType(resources.GetObject("ToolTipTitleItem19.Image"), System.Drawing.Image)
        ToolTipTitleItem19.Text = "Enter Your Password !!.."
        ToolTipItem10.Appearance.Image = CType(resources.GetObject("resource.Image7"), System.Drawing.Image)
        ToolTipItem10.Appearance.Options.UseImage = True
        ToolTipItem10.Image = CType(resources.GetObject("ToolTipItem10.Image"), System.Drawing.Image)
        ToolTipItem10.LeftIndent = 6
        ToolTipItem10.Text = "Enter Your Password If you Provide any password in your database !!.."
        ToolTipTitleItem20.Appearance.Image = CType(resources.GetObject("resource.Image8"), System.Drawing.Image)
        ToolTipTitleItem20.Appearance.Options.UseImage = True
        ToolTipTitleItem20.Image = CType(resources.GetObject("ToolTipTitleItem20.Image"), System.Drawing.Image)
        ToolTipTitleItem20.LeftIndent = 6
        ToolTipTitleItem20.Text = "Password !!.."
        SuperToolTip10.Items.Add(ToolTipTitleItem19)
        SuperToolTip10.Items.Add(ToolTipItem10)
        SuperToolTip10.Items.Add(ToolTipTitleItem20)
        Me.ToolTipController1.SetSuperTip(Me.TextBox2, SuperToolTip10)
        Me.TextBox2.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(83, 295)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(349, 48)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "GO"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SimpleButton1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SimpleButton1.Appearance.BorderColor = System.Drawing.Color.Blue
        Me.SimpleButton1.Appearance.Options.UseBackColor = True
        Me.SimpleButton1.Appearance.Options.UseBorderColor = True
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(83, 167)
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(281, 46)
        ToolTipTitleItem21.Appearance.Image = CType(resources.GetObject("resource.Image9"), System.Drawing.Image)
        ToolTipTitleItem21.Appearance.Options.UseImage = True
        ToolTipTitleItem21.Image = CType(resources.GetObject("ToolTipTitleItem21.Image"), System.Drawing.Image)
        ToolTipTitleItem21.Text = "Login !!.."
        ToolTipItem11.Appearance.Image = CType(resources.GetObject("resource.Image10"), System.Drawing.Image)
        ToolTipItem11.Appearance.Options.UseImage = True
        ToolTipItem11.Image = CType(resources.GetObject("ToolTipItem11.Image"), System.Drawing.Image)
        ToolTipItem11.LeftIndent = 6
        ToolTipItem11.Text = "Test And Login !!.."
        ToolTipTitleItem22.Appearance.Image = CType(resources.GetObject("resource.Image11"), System.Drawing.Image)
        ToolTipTitleItem22.Appearance.Options.UseImage = True
        ToolTipTitleItem22.Image = CType(resources.GetObject("ToolTipTitleItem22.Image"), System.Drawing.Image)
        ToolTipTitleItem22.LeftIndent = 6
        ToolTipTitleItem22.Text = "Let's Go !!.."
        SuperToolTip11.Items.Add(ToolTipTitleItem21)
        SuperToolTip11.Items.Add(ToolTipItem11)
        SuperToolTip11.Items.Add(ToolTipTitleItem22)
        Me.SimpleButton1.SuperTip = SuperToolTip11
        Me.SimpleButton1.TabIndex = 6
        Me.SimpleButton1.Text = "&Login"
        '
        'Settingfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(421, 219)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Settingfrm"
        Me.Text = "Settingfrm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ToolTipController1 As DevExpress.Utils.ToolTipController
End Class
