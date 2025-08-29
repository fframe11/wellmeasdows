Public Class FormHome
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnWord_Click(sender As Object, e As EventArgs) Handles btnWord.Click
    End Sub

    Private Sub btnPatient_Click(sender As Object, e As EventArgs) Handles btnPatient.Click
        Dim formWard01 = New FormWard01
        formWard01.Show()
    End Sub
    Private Sub switchForm(form As Form)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnpatient1.Click
        Dim formPatient = New FormPatient
        formPatient.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim formTreatment As New FormTreatment()
        formTreatment.Show()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim formPayment As New FormPayment()
        formPayment.Show()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim formStaff As New FormStaff()
        formStaff.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim formMedecine As New FormMedecine()
        formMedecine.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim formShifting As New FormShifting()
        formShifting.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim formItemStock As New FormItemStock()
        formItemStock.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim formProduce As New FormProduct()
        formProduce.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim formSupplier As New FormSupplier()
        formSupplier.Show()
    End Sub
End Class

