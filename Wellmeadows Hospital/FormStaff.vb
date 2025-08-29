Public Class FormStaff
    Private Sub Ward_Click(sender As Object, e As EventArgs) Handles Ward.Click, Ward.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim SearchQualification = New SearchQualification
        SearchQualification.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim formJob_Experience = New FormJob_Experience
        formJob_Experience.Show()
        Me.Hide()
    End Sub
End Class