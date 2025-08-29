Public Class FormTreatment
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim formReportMedecine = New FormReportMedecine
        formReportMedecine.Show()
        Me.Hide()
    End Sub
End Class