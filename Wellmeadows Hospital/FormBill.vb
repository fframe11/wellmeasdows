Public Class FormBill
    Private Sub Ward_Click(sender As Object, e As EventArgs) Handles Ward.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim formReport_Bill = New FormReport_Bill
        formReport_Bill.Show()
        Me.Hide()
    End Sub
End Class