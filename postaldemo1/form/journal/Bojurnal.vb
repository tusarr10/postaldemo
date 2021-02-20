Public Class Bojurnal

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Bojurnal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd MMMM yyyy"
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        waitopen()
        translist.MdiParent = mainfrm
        translist.WindowState = FormWindowState.Normal
        translist.Show()
        translist.GetData1()
        translist.filt2()
        RichTextBox1.Text = ""
        Try
            For i As Integer = 0 To translist.DataGridView1.Rows.Count - 2

                RichTextBox1.Text = RichTextBox1.Text + "**"

                For j As Integer = 0 To translist.DataGridView1.Columns.Count - 1


                    RichTextBox1.Text = RichTextBox1.Text + vbTab + "||" + translist.DataGridView1.Rows(i).Cells(j).Value.ToString() + " || " + vbTab
                Next

                RichTextBox1.Text = RichTextBox1.Text + vbLf
                RichTextBox1.Text = RichTextBox1.Text + "------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------"
                RichTextBox1.Text = RichTextBox1.Text + vbLf
            Next

            translist.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        waitclose()
    End Sub
End Class