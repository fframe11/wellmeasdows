Public Class FormWard01
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim formAppointments = New FormAppointments
        formAppointments.Show()
        Me.Hide()
    End Sub
End Class