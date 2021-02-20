Imports DevExpress.XtraReports.UI

Public Class printfrm

    Private Sub printfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Public Sub FmPrit(ByVal data As List(Of ClS_transdetail))
        waitopen()
        Dim report As XtraReport1 = New XtraReport1()
        report.GetIntData(data)
        DocumentViewer1.DocumentSource = report
        report.CreateDocument() : waitclose()
    End Sub
    Public Sub MonthlyrptPrit(ByVal datamonrpt As List(Of CLS_monthlyRpt))
        waitopen()
        Dim report As monthlyrpt = New monthlyrpt()
        report.GetIntDatamonrpt(datamonrpt)
        DocumentViewer1.DocumentSource = report
        report.CreateDocument() : waitclose()
    End Sub

    Public Sub usrinfo(ByVal AcNo As String, ByVal acName As String, ByVal fthname As String, ByVal motname As String, ByVal nomname As String, ByVal ac_type As String, ByVal add_ress As String, ByVal adhar As String, ByVal bal As String, ByVal D_OB As String, ByVal email As String, ByVal mobno As String, ByVal g_ender As String, ByVal monrec As String, ByVal nots As String, ByVal paan As String, ByVal phno As String, ByVal photo As Image, ByVal sign As Image)
        waitopen()
        Dim report As userinfo = New userinfo()
        report.GET_DATA(AcNo, acName, fthname, motname, nomname, ac_type, add_ress, adhar, bal, D_OB, email, mobno, gender, monrec, nots, paan, phno, photo, sign)
        DocumentViewer1.DocumentSource = report
        report.CreateDocument() : waitclose()
    End Sub

    Public Sub userrptPrint()
        waitopen()
        Dim report As userrpt_TS = New userrpt_TS()
        DocumentViewer1.DocumentSource = report
        report.CreateDocument() : waitclose()
    End Sub
    Public Sub userrpt_TS_Print(ByVal datausrrpt_TS As List(Of Cls_TS_userdetails))
        waitopen()
        Dim report As userrpt_TS = New userrpt_TS()
        report.GetintDatausrrpt_TS(datausrrpt_TS)
        DocumentViewer1.DocumentSource = report
        report.CreateDocument() : waitclose()
    End Sub
    Public Sub userrpt_RS_Print(ByVal datausrrpt_RS As List(Of Cls_RS_userdetails))
        waitopen()

        Dim report As userrpt_RS = New userrpt_RS()
        report.GetintDatausrrpt_RS(datausrrpt_RS)
        DocumentViewer1.DocumentSource = report
        report.CreateDocument() : waitclose()
    End Sub
    Public Sub PrintAllTransction_Print(ByVal dataalltransction_print As List(Of CLS_allTranction))
        waitopen()
        Dim report As PrintAllTransction = New PrintAllTransction()
        report.GetintDataPrintAllTransction(dataalltransction_print)
        DocumentViewer1.DocumentSource = report
        report.CreateDocument() : waitclose()
    End Sub
End Class