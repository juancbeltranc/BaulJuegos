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
End Class
