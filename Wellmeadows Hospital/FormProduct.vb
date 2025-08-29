Public Class FormProduct
    Private Sub FlowLayoutPanel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim formItem = New FormItem
        formItem.Show()
        Me.Hide()
    End Sub

End Class