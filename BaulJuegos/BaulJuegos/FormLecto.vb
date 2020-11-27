Public Class FormLecto
    Dim Generator As System.Random = New System.Random()
    Dim t1, t2 As String
    Dim aleatorio As Integer

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If aleatorio = 1 Or aleatorio = 2 Then
            Dim preResult As String = "A"
            Dim result As String = TextBox2.Text

            If Not preResult.Equals(result.ToUpper) Then
                MsgBox("Intentalo de nuevo.", MsgBoxStyle.Information, "Politecnico Grancolombiano - Baúl de juegos")
            Else
                MsgBox("Felicitaciones.", MsgBoxStyle.Information, "Politecnico Grancolombiano - Baúl de juegos")
                TextBox2.Text = ""
                Me.Close()
            End If
        ElseIf aleatorio = 3 Or aleatorio = 4 Then
            Dim preResult As String = "E"
            Dim result As String = TextBox2.Text

            If Not preResult.Equals(result.ToUpper) Then
                MsgBox("Intentalo de nuevo.", MsgBoxStyle.Information, "Politecnico Grancolombiano - Baúl de juegos")
            Else
                MsgBox("Felicitaciones.", MsgBoxStyle.Information, "Politecnico Grancolombiano - Baúl de juegos")
                TextBox2.Text = ""
                Me.Close()
            End If
        ElseIf aleatorio = 5 Or aleatorio = 6 Then
            Dim preResult As String = "I"
            Dim result As String = TextBox2.Text

            If Not preResult.Equals(result.ToUpper) Then
                MsgBox("Intentalo de nuevo.", MsgBoxStyle.Information, "Politecnico Grancolombiano - Baúl de juegos")
            Else
                MsgBox("Felicitaciones.", MsgBoxStyle.Information, "Politecnico Grancolombiano - Baúl de juegos")
                TextBox2.Text = ""
                Me.Close()
            End If
        ElseIf aleatorio = 7 Or aleatorio = 8 Then
            Dim preResult As String = "O"
            Dim result As String = TextBox2.Text

            If Not preResult.Equals(result.ToUpper) Then
                MsgBox("Intentalo de nuevo.", MsgBoxStyle.Information, "Politecnico Grancolombiano - Baúl de juegos")
            Else
                MsgBox("Felicitaciones.", MsgBoxStyle.Information, "Politecnico Grancolombiano - Baúl de juegos")
                TextBox2.Text = ""
                Me.Close()
            End If
        ElseIf aleatorio = 9 Or aleatorio = 10 Then
            Dim preResult As String = "U"
            Dim result As String = TextBox2.Text

            If Not preResult.Equals(result.ToUpper) Then
                MsgBox("Intentalo de nuevo.", MsgBoxStyle.Information, "Politecnico Grancolombiano - Baúl de juegos")
            Else
                MsgBox("Felicitaciones.", MsgBoxStyle.Information, "Politecnico Grancolombiano - Baúl de juegos")
                TextBox2.Text = ""
                Me.Close()
            End If
        End If


    End Sub

    Private Sub FormLecto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        aleatorio = Generator.Next(1, 10 + 1)

        If aleatorio = 1 Then
            PictureBox1.Image = My.Resources.avion
            t1 = "A"
            t2 = "vión"
        ElseIf aleatorio = 2 Then
            PictureBox1.Image = My.Resources.arbol
            t1 = "A"
            t2 = "rbol"
        ElseIf aleatorio = 3 Then
            PictureBox1.Image = My.Resources.enano
            t1 = "E"
            t2 = "nano"
        ElseIf aleatorio = 4 Then
            PictureBox1.Image = My.Resources.elefabte
            t1 = "E"
            t2 = "lefante"
        ElseIf aleatorio = 5 Then
            PictureBox1.Image = My.Resources.iglesia
            t1 = "I"
            t2 = "glesia"
        ElseIf aleatorio = 6 Then
            PictureBox1.Image = My.Resources.iman
            t1 = "I"
            t2 = "mán"
        ElseIf aleatorio = 7 Then
            PictureBox1.Image = My.Resources.oso
            t1 = "O"
            t2 = "so"
        ElseIf aleatorio = 8 Then
            PictureBox1.Image = My.Resources.oro
            t1 = "O"
            t2 = "ro"
        ElseIf aleatorio = 9 Then
            PictureBox1.Image = My.Resources.uva
            t1 = "U"
            t2 = "va"
        ElseIf aleatorio = 10 Then
            PictureBox1.Image = My.Resources.uña
            t1 = "U"
            t2 = "ña"
        End If

        TextBox1.Text = t2

    End Sub
End Class