Public Class FormPayment
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim formBill = New FormBill
        formBill.Show()
        Me.Hide()
    End Sub
End Class