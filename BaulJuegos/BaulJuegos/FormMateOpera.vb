Public Class FormMateOpera
    Dim num1 As Integer
    Dim num2 As Integer
    Dim aleatorio As Integer

    Dim Generator As System.Random = New System.Random()
    Private Sub FormMateOpera_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        metodoOpera()
    End Sub

    Private Sub metodoOpera()
        If My.Settings.tipoMat.Equals("suma") Then
            num1 = (CInt(Math.Ceiling(Rnd() * 10)) + 1)
            num2 = (CInt(Math.Ceiling(Rnd() * 10)) + 1)

            TextBox1.Text = num1.ToString
            TextBox2.Text = " + "
            TextBox3.Text = num2.ToString
            TextBox4.Text = " = "
        ElseIf My.Settings.tipoMat.Equals("resta") Then
            num1 = (CInt(Math.Ceiling(Rnd() * 10)) + 1)
            num2 = (CInt(Math.Ceiling(Rnd() * 10)) + 1)

            While num2 > num1
                TextBox3.Text = (CInt(Math.Ceiling(Rnd() * 10)) + 1).ToString
            End While

            TextBox1.Text = num1.ToString
            TextBox2.Text = " - "
            TextBox3.Text = num2.ToString
            TextBox4.Text = " = "

        ElseIf My.Settings.tipoMat.Equals("sumaC") Then
            num1 = (CInt(Math.Ceiling(Rnd() * 10)) + 1)
            num2 = (CInt(Math.Ceiling(Rnd() * 10)) + 1)

            aleatorio = Generator.Next(1, 2 + 1)

            If aleatorio = 1 Then
                'TextBox1.Text = num1.ToString
                TextBox2.Text = " + "
                TextBox3.Text = num2.ToString
                TextBox4.Text = " = "
                Dim preResult As Integer = num1 + num2
                TextBox5.Text = Integer.Parse(preResult)
            ElseIf aleatorio = 2 Then
                TextBox1.Text = num1.ToString
                TextBox2.Text = " + "
                'TextBox3.Text = num2.ToString
                TextBox4.Text = " = "
                Dim preResult As Integer = num1 + num2
                TextBox5.Text = Integer.Parse(preResult)
            End If


        ElseIf My.Settings.tipoMat.Equals("restaC") Then
            num1 = (CInt(Math.Ceiling(Rnd() * 10)) + 1)
            num2 = (CInt(Math.Ceiling(Rnd() * 10)) + 1)

            aleatorio = Generator.Next(1, 2 + 1)

            If aleatorio = 1 Then
                'TextBox1.Text = num1.ToString
                TextBox2.Text = " - "
                TextBox3.Text = num2.ToString
                TextBox4.Text = " = "
                Dim preResult As Integer = num1 - num2
                TextBox5.Text = Integer.Parse(preResult)
            ElseIf aleatorio = 2 Then
                TextBox1.Text = num1.ToString
                TextBox2.Text = " - "
                'TextBox3.Text = num2.ToString
                TextBox4.Text = " = "
                Dim preResult As Integer = num1 - num2
                TextBox5.Text = Integer.Parse(preResult)
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If My.Settings.tipoMat.Equals("suma") Then
            Dim preResult As Integer = num1 + num2
            Dim result As Integer = Integer.Parse(TextBox5.Text)

            If preResult <> result Then
                MsgBox("Intentalo de nuevo.", MsgBoxStyle.Information, "Politecnico Grancolombiano - Baúl de juegos")
            Else
                MsgBox("Felicitaciones.", MsgBoxStyle.Information, "Politecnico Grancolombiano - Baúl de juegos")
                TextBox5.Text = ""
                Me.Close()
            End If
        ElseIf My.Settings.tipoMat.Equals("resta") Then
            Dim preResult As Integer = num1 - num2
            Dim result As Integer = Integer.Parse(TextBox5.Text)

            If preResult <> result Then
                MsgBox("Intentalo de nuevo.", MsgBoxStyle.Information, "Politecnico Grancolombiano - Baúl de juegos")
            Else
                MsgBox("Felicitaciones.", MsgBoxStyle.Information, "Politecnico Grancolombiano - Baúl de juegos")
                TextBox5.Text = ""
                Me.Close()
            End If
        ElseIf My.Settings.tipoMat.Equals("sumaC") Then
            If aleatorio = 1 Then
                Dim t1 As Integer = Integer.Parse(TextBox1.Text)
                If t1 <> num1 Then
                    MsgBox("Intentalo de nuevo.", MsgBoxStyle.Information, "Politecnico Grancolombiano - Baúl de juegos")
                Else
                    MsgBox("Felicitaciones.", MsgBoxStyle.Information, "Politecnico Grancolombiano - Baúl de juegos")
                    TextBox5.Text = ""
                    Me.Close()
                End If
            ElseIf aleatorio = 2 Then
                Dim t2 As Integer = Integer.Parse(TextBox3.Text)
                If t2 <> num2 Then
                    MsgBox("Intentalo de nuevo.", MsgBoxStyle.Information, "Politecnico Grancolombiano - Baúl de juegos")
                Else
                    MsgBox("Felicitaciones.", MsgBoxStyle.Information, "Politecnico Grancolombiano - Baúl de juegos")
                    TextBox5.Text = ""
                    Me.Close()
                End If
            End If
        ElseIf My.Settings.tipoMat.Equals("restaC") Then
            If aleatorio = 1 Then
                Dim t1 As Integer = Integer.Parse(TextBox1.Text)
                If t1 <> num1 Then
                    MsgBox("Intentalo de nuevo.", MsgBoxStyle.Information, "Politecnico Grancolombiano - Baúl de juegos")
                Else
                    MsgBox("Felicitaciones.", MsgBoxStyle.Information, "Politecnico Grancolombiano - Baúl de juegos")
                    TextBox5.Text = ""
                    Me.Close()
                End If
            ElseIf aleatorio = 2 Then
                Dim t2 As Integer = Integer.Parse(TextBox3.Text)
                If t2 <> num2 Then
                    MsgBox("Intentalo de nuevo.", MsgBoxStyle.Information, "Politecnico Grancolombiano - Baúl de juegos")
                Else
                    MsgBox("Felicitaciones.", MsgBoxStyle.Information, "Politecnico Grancolombiano - Baúl de juegos")
                    TextBox5.Text = ""
                    Me.Close()
                End If
            End If
        End If
    End Sub
End Class