Public Class FormMate

    Dim tipo As String

    Private Sub FormMate_load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.tipoMat = "suma"
        Dim formuMate As New FormMateOpera
        formuMate.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.tipoMat = "resta"
        Dim formuMate As New FormMateOpera
        formuMate.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Settings.tipoMat = "sumaC"
        Dim formuMate As New FormMateOpera
        formuMate.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        My.Settings.tipoMat = "restaC"
        Dim formuMate As New FormMateOpera
        formuMate.Show()
    End Sub


End Class