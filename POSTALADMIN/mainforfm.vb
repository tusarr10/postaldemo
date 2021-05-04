Imports System.Windows.Forms
Imports System.Data.OleDb

Public Class mainforfm
    Dim con As OleDbConnection = Nothing

    Public css As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath + "\" & "Data\BONAI.accdb" & ";Jet OLEDB:Database Password=" & "" & ";"
    Public wxss As String = Application.StartupPath + "\" & "Data\Workload.xlsx"
    Public iexss As String = Application.StartupPath + "\" & "Data\ice.xlsx"

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub


    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer


    Private Sub SettingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingToolStripMenuItem.Click

        waitopen()
        Form1.MdiParent = Me
        Form1.WindowState = FormWindowState.Normal
        Form1.Show() : waitclose()

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        waitopen()
        expd_usr.MdiParent = Me
        expd_usr.WindowState = FormWindowState.Normal
        expd_usr.Show()
        waitclose()

    End Sub

    Private Sub WorkloadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WorkloadToolStripMenuItem.Click
        waitopen()
        workload.MdiParent = Me
        workload.WindowState = FormWindowState.Normal
        workload.Show()
        waitclose()


    End Sub

    Private Sub mainforfm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

        ' to be delete just for testing
        waitopen()
        con = New OleDbConnection(css)
        Try
            con.Open()
            MsgBox("Connection success")
            con.Close()
            waitclose()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
            waitclose()
        End Try

    End Sub

    Private Sub IRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IRToolStripMenuItem.Click
        waitopen()
        ir_form.MdiParent = Me
        ir_form.WindowState = FormWindowState.Normal
        ir_form.Show()
        waitclose()


    End Sub
End Class
