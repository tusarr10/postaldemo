Public Class monthlyrpt

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        '''''''Call ''''''
        XrLabel2.Text = DateAndTime.DateString
        XrLabel3.Text = monthlyReport.ComboBox1.Text + "  " + monthlyReport.TextBox1.Text
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Public Sub GetIntDatamonrpt(ByVal data As List(Of CLS_monthlyRpt))
        ObjectDataSource1.DataSource = data
    End Sub

End Class