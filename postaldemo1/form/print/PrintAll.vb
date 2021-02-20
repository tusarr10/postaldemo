Public Class PrintAll 

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        waitopen()
        Using UserControl1 As PrtDalyAc = New PrtDalyAc()
            Using tmpForm As dialogfrm = New dialogfrm()
                tmpForm.PanelControl1.Controls.Add(UserControl1)
                tmpForm.ShowDialog()
            End Using
        End Using
        waitclose()
    End Sub
End Class