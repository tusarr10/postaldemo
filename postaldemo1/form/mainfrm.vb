Imports System.Windows.Forms
Imports System.Xml

Public Class mainfrm
    Public css As String
    ' Public css As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath + "\" & Settingfrm.TextBox1.Text & ";Jet OLEDB:Database Password=" & Settingfrm.TextBox2.Text & ";"

    Private Sub mainfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Try
            Dim xy As Date = Now

            LabelControl2.Text = xy.ToString

        Catch ex As Exception
            MsgBox("Unable Find Date")
        End Try
        waitopen()
        Account_Setting.MdiParent = Me
        Account_Setting.WindowState = FormWindowState.Normal
        Account_Setting.Show()
        waitclose()

    End Sub

    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub UserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserToolStripMenuItem.Click
        waitopen()

        GroupBox1.Enabled = True
        UserAc.MdiParent = Me
        UserAc.WindowState = FormWindowState.Normal
        UserAc.Show()
        waitclose()

    End Sub

    Private Sub WithDrawalDepositToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WithDrawalDepositToolStripMenuItem.Click
        waitopen()

        SBAc.MdiParent = Me
        SBAc.WindowState = FormWindowState.Normal
        SBAc.Show()
        waitclose()

    End Sub

    Private Sub AllTransctionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllTransctionToolStripMenuItem.Click
        UserAc.GroupBox1.Enabled = True
        waitopen() : Userlist.MdiParent = Me
        Userlist.WindowState = FormWindowState.Normal
        Userlist.Show()
        Userlist.GetData()
        waitclose()
    End Sub

    Private Sub BOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BOToolStripMenuItem.Click
        waitopen() : Bojurnal.MdiParent = Me
        Bojurnal.WindowState = FormWindowState.Maximized
        Bojurnal.Show()
        waitclose()
    End Sub

    Private Sub RequiringDepositToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RequiringDepositToolStripMenuItem.Click
        waitopen()

        RdAc.MdiParent = Me
        RdAc.WindowState = FormWindowState.Normal
        RdAc.Show()
        waitclose()

    End Sub

    Private Sub TDAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TDAccountToolStripMenuItem.Click
        waitopen() : tdAc.MdiParent = Me
        tdAc.WindowState = FormWindowState.Normal
        tdAc.Show() : waitclose()

    End Sub

    Private Sub SSAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SSAccountToolStripMenuItem.Click
        waitopen() : SSA.MdiParent = Me
        SSA.WindowState = FormWindowState.Normal
        SSA.Show()
        waitclose()

    End Sub

    Private Sub TransctionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransctionToolStripMenuItem.Click
        waitopen()

        translist.MdiParent = Me
        translist.WindowState = FormWindowState.Maximized
        translist.Show()
        waitclose()

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.ShowDialog()

    End Sub

    Private Sub ContactToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactToolStripMenuItem.Click
        Form1.ShowDialog()

    End Sub

    Private Sub DalyAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DalyAccountToolStripMenuItem.Click
        waitopen()

        dac.MdiParent = Me
        dac.WindowState = FormWindowState.Normal
        dac.Show() : waitclose()

        'MsgBox("Under Construction Please Wait for Next Update")
    End Sub

    Private Sub RPLIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RPLIToolStripMenuItem.Click
        MsgBox("Under Construction Please Wait for Next Update")
    End Sub

    Private Sub SpeedPostToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpeedPostToolStripMenuItem.Click
        MsgBox("Under Construction Please Wait for Next Update")
    End Sub

    Private Sub SettingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingToolStripMenuItem.Click
        waitopen()
        Account_Setting.MdiParent = Me
        Account_Setting.WindowState = FormWindowState.Normal
        Account_Setting.Show() : waitclose()
        ' MsgBox("Acces Start time only")
    End Sub

    Private Sub mainfrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()

    End Sub

    Private Sub VersionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VersionToolStripMenuItem.Click
        AboutBox2.ShowDialog()


    End Sub

    Private Sub ReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportToolStripMenuItem.Click
        waitopen() : transdetails.MdiParent = Me
        transdetails.WindowState = FormWindowState.Maximized

        transdetails.Show() : waitclose()

    End Sub

    Private Sub AccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccountToolStripMenuItem.Click
        waitopen() : monthlyReport.MdiParent = Me
        monthlyReport.WindowState = FormWindowState.Maximized
        monthlyReport.Show() : waitclose()
    End Sub

    Private Sub UserToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UserToolStripMenuItem1.Click
        waitopen()
        prinUser.MdiParent = Me
        prinUser.WindowState = FormWindowState.Maximized
        prinUser.Show()
        waitclose()
    End Sub

    Private Sub TransctionToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TransctionToolStripMenuItem1.Click
        waitopen()
        All_transction.MdiParent = Me
        All_transction.WindowState = FormWindowState.Normal
        All_transction.Show()
        waitclose()
    End Sub

    Private Sub DalyAccountToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DalyAccountToolStripMenuItem1.Click

    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        waitopen() : PrintAll.MdiParent = Me
        PrintAll.WindowState = FormWindowState.Normal
        PrintAll.Show() : waitclose()
    End Sub

    Private Sub FlyoutPanelControl1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        waitopen()
        BackUpGoogl.MdiParent = Me
        BackUpGoogl.WindowState = FormWindowState.Normal
        BackUpGoogl.Show() : waitclose()
    End Sub

    Private Sub HyperlinkLabelControl1_Click(sender As Object, e As EventArgs) Handles HyperlinkLabelControl1.Click
        waitopen()
        Account_Setting.MdiParent = Me
        Account_Setting.WindowState = FormWindowState.Normal
        Account_Setting.Show() : waitclose()
    End Sub

    Private Sub DayEndToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DayEndToolStripMenuItem.Click
        'code goes here
        Dim x As String = ""
        Dim xmlr = XmlReader.Create("Resources/extension.xml")
        xmlr.Read()
        If xmlr.NodeType = XmlNodeType.Element AndAlso xmlr.Name = "module1" Then
            x = xmlr.ReadElementString
        End If

        MsgBox(x)

        ' Process.Start(x + "D:\MATI2\MATI.EXE")
        'end

        '  Application.Exit()

    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Application.Exit()

    End Sub

    Private Sub ShutDownToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShutDownToolStripMenuItem.Click
        Application.Exit()

    End Sub

    Private Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartToolStripMenuItem.Click
        Application.Restart()

    End Sub

    Private Sub OpenNewAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenNewAccountToolStripMenuItem.Click
        waitopen()
        new_account.MdiParent = Me
        new_account.WindowState = FormWindowState.Normal
        new_account.Show() : waitclose()
    End Sub
End Class
