Public Class XtraReport1
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        '''''''Call ''''''
        XrLabel25.Text = dac.DateTimePicker1.Text.ToString
        lbldate.Text = dac.DateTimePicker1.Text.ToString
        lbllastbal.Text = dac.TextBox2.Text.ToString
        lblcashrec.Text = dac.TextBox28.Text.ToString
        lblsbdep.Text = dac.TextBox3.Text.ToString
        lblrddep.Text = dac.TextBox4.Text.ToString
        lblrdfine.Text = dac.TextBox5.Text.ToString
        lblssadep.Text = dac.TextBox6.Text.ToString
        lblssafine.Text = dac.TextBox7.Text.ToString
        lbltddep.Text = dac.TextBox8.Text.ToString
        lblrplidep.Text = dac.TextBox9.Text.ToString
        lblrplifine.Text = dac.TextBox10.Text.ToString
        lblrplitax.Text = dac.TextBox11.Text.ToString
        lblvpp.Text = dac.TextBox12.Text.ToString
        lbltotaldep.Text = dac.TextBox1.Text.ToString
        lblcashremit.Text = dac.TextBox15.Text.ToString
        lblsbwith.Text = dac.TextBox16.Text.ToString
        lblrdwith.Text = dac.TextBox17.Text.ToString
        lbltdwith.Text = dac.TextBox18.Text.ToString
        lblssawith.Text = dac.TextBox19.Text.ToString
        lblrpliwith.Text = dac.TextBox20.Text.ToString
        lblmonwith.Text = dac.TextBox21.Text.ToString
        lbltotalwith.Text = dac.TextBox23.Text.ToString
        lblcash.Text = dac.TextBox27.Text.ToString
        lblipo.Text = dac.TextBox26.Text.ToString
        lblstamp.Text = dac.TextBox25.Text.ToString
        lblbalance.Text = dac.TextBox24.Text.ToString
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Public Sub GetIntData(ByVal data As List(Of ClS_transdetail))
        ObjectDataSource2.DataSource = data
    End Sub
End Class