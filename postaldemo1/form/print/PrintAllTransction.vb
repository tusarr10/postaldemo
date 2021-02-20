Public Class PrintAllTransction
    Public Sub GetintDataPrintAllTransction(ByVal data As List(Of CLS_allTranction))
        ObjectDataSource1.DataSource = data
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        XrLabel5.Text = DateAndTime.Today.ToString
        XrLabel1.Text = All_transction.ComboBoxEdit1.Text
        XrLabel2.Text = All_transction.ComboBoxEdit2.Text
        XrLabel3.Text = All_transction.ComboBoxEdit3.Text
        XrLabel4.Text = All_transction.ComboBoxEdit4.Text

        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class