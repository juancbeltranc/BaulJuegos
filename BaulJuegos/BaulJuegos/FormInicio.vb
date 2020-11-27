Public Class FormInicio
    Private Sub ButtonMath_Click(sender As Object, e As EventArgs) Handles ButtonMath.Click
        Dim nombrePlayer = ""
        nombrePlayer = nombreJugador.Text
        If Not nombrePlayer.Equals("") Then
            My.Settings.nombreUser = nombrePlayer

            Dim formuMate As New FormMate
            formuMate.Show()
        Else
            MsgBox("Por favor ingrese el nombre del jugador.", MsgBoxStyle.Information, "Politecnico Grancolombiano - Baúl de juegos")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim nombrePlayer = ""
        nombrePlayer = nombreJugador.Text
        If Not nombrePlayer.Equals("") Then
            My.Settings.nombreUser = nombrePlayer

            Dim formulec As New FormLecto
            formulec.Show()
        Else
            MsgBox("Por favor ingrese el nombre del jugador.", MsgBoxStyle.Information, "Politecnico Grancolombiano - Baúl de juegos")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nombrePlayer = ""
        nombrePlayer = nombreJugador.Text
        If Not nombrePlayer.Equals("") Then
            My.Settings.nombreUser = nombrePlayer

            Dim formufig As New FormFigura
            formufig.Show()
        Else
            MsgBox("Por favor ingrese el nombre del jugador.", MsgBoxStyle.Information, "Politecnico Grancolombiano - Baúl de juegos")
        End If
    End Sub
End Class
