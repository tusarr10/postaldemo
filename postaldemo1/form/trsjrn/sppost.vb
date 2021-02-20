Public Class sppost

    Private Sub sppost_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd MMMM YYYY"
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sppostlist.MdiParent = mainfrm
        sppostlist.WindowState = FormWindowState.Normal
        sppostlist.Show()
    End Sub

    Private Sub btnNewRecord_Click(sender As Object, e As EventArgs) Handles btnNewRecord.Click

    End Sub

    Sub reset()
        article_no.Text = ""
        vppamt.Text = 0
        sender_address.Text = ""
        NameOfrecever.Text = ""
        to_date.Text = ""
        Contact_num.Text = ""
        Notes.Text = ""
        deltype.TabIndex = ""
        DateTimePicker1.Text = ""

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

    End Sub
End Class