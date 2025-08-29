Public Class FormItem
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim formProduct = New FormProduct
        formProduct.Show()
        Me.Hide()
    End Sub


End Class