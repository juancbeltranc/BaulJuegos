Public Class FormFigura
    Dim Generator As System.Random = New System.Random()
    Dim aleatorio As Integer

    Dim preColo As String
    Dim preFigura As String

    Dim Color As String
    Dim figura As String

    Private Sub FormFigura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        aleatorio = Generator.Next(1, 9 + 1)

        If aleatorio = 1 Then
            PictureBox1.Image = My.Resources.triamarillo
            preColo = "Amarillo"
            preFigura = "Triangulo"
        ElseIf aleatorio = 2 Then
            PictureBox1.Image = My.Resources.cuadradoama
            preColo = "Amarillo"
            preFigura = "Cuadrado"
        ElseIf aleatorio = 3 Then
            PictureBox1.Image = My.Resources.cuicuamarillo
            preColo = "Amarillo"
            preFigura = "Circulo"
        ElseIf aleatorio = 4 Then
            PictureBox1.Image = My.Resources.triazul
            preColo = "Azul"
            preFigura = "Triangulo"
        ElseIf aleatorio = 5 Then
            PictureBox1.Image = My.Resources.cuadradoazul
            preColo = "Azul"
            preFigura = "Cuadrado"
        ElseIf aleatorio = 6 Then
            PictureBox1.Image = My.Resources.circuAzul
            preColo = "Azul"
            preFigura = "Circulo"
        ElseIf aleatorio = 4 Then
            PictureBox1.Image = My.Resources.trirojo
            preColo = "Rojo"
            preFigura = "Triangulo"
        ElseIf aleatorio = 5 Then
            PictureBox1.Image = My.Resources.cuadradorojo
            preColo = "Rojo"
            preFigura = "Cuadrado"
        ElseIf aleatorio = 6 Then
            PictureBox1.Image = My.Resources.circurojo
            preColo = "Rojo"
            preFigura = "Circulo"
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        figura = "Triangulo"
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        figura = "Cuadrado"
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        figura = "Circulo"
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Color = "Amarillo"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Color = "Azul"
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Color = "Rojo"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If figura IsNot Nothing And Color IsNot Nothing And preFigura.Equals(figura) And preColo.Equals(Color) Then
            MsgBox("Felicitaciones.", MsgBoxStyle.Information, "Politecnico Grancolombiano - Baúl de juegos")
            Me.Close()
        Else
            MsgBox("Intentalo de nuevo.", MsgBoxStyle.Information, "Politecnico Grancolombiano - Baúl de juegos")
        End If
    End Sub
End Class