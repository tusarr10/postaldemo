Imports System
Imports System.Collections.Generic
Imports System.Drawing.Printing
Imports System.Windows.Forms
Imports DevExpress.XtraPrinting.BarCode
Imports DevExpress.XtraReports.UI
Imports Excel = Microsoft.Office.Interop.Excel
Module utility
    Dim xlApp As excel.Application
    Dim xlWorkBook As excel.Workbook
    Dim xlWorkSheet As excel.Worksheet


    Public Sub waitopen()
        Try
            DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(GetType(WaitForm1))
            ' Threading.Thread.Sleep(10)
        Catch

        End Try
    End Sub
    Public Sub waitclose()
        Try
            DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm()
        Catch

        End Try
    End Sub
    'Public Function CreateCode128BarCode(ByVal BarCodeText As String) As XRBarCode
    '    ' Create a bar code control.
    '    Dim barCode As New XRBarCode()

    '    ' Set the bar code's type to Code 128.
    '    barCode.Symbology = New Code128Generator()

    '    ' Adjust the bar code's main properties.
    '    barCode.Text = BarCodeText
    '    barCode.Width = 400
    '    barCode.Height = 100

    '    ' Adjust the properties specific to the bar code type.
    '    CType(barCode.Symbology, Code128Generator).CharacterSet = Code128Charset.CharsetB

    '    Return barCode
    'End Function

    Public Sub quit()
        Try
            xlApp.Quit()
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp) : xlApp = Nothing
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkBook) : xlWorkBook = Nothing
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkSheet) : xlWorkSheet = Nothing
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

    End Sub

End Module
