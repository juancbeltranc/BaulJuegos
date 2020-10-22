Public Class FormMate

    Dim tipo As String

    Private Sub FormMate_load(sender As Object, e As EventArgs) Handles MyBase.Load
        TableLayoutPanel1.Visible = True
        TableLayoutPanel2.Visible = False
    End Sub

    Private Sub metodoOpera()
        If tipo.Equals("suma") Then
            TextBox1.Text = (CInt(Math.Ceiling(Rnd() * 10)) + 1).ToString
            TextBox2.Text = " + "
            TextBox3.Text = (CInt(Math.Ceiling(Rnd() * 10)) + 1).ToString
            TextBox4.Text = " = "
        ElseIf tipo.Equals("resta") Then
            TextBox1.Text = (CInt(Math.Ceiling(Rnd() * 10)) + 1).ToString
            TextBox2.Text = " - "
            TextBox3.Text = (CInt(Math.Ceiling(Rnd() * 10)) + 1).ToString
            TextBox4.Text = " = "
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        TableLayoutPanel1.Visible = False
        TableLayoutPanel2.Visible = True
        tipo = "suma"
        metodoOpera()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TableLayoutPanel1.Visible = False
        TableLayoutPanel2.Visible = True
        tipo = "resta"
        metodoOpera()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        If tipo.Equals("suma") Then
            Dim preResult As Integer = Integer.Parse(TextBox1.Text) + Integer.Parse(TextBox3.Text)
            Dim result As Integer = Integer.Parse(TextBox5.Text)

            If preResult <> result Then
                MsgBox("Intentalo de nuevo.", MsgBoxStyle.Information, "Politecnico Grancolombiano - Baúl de juegos")
            Else
                MsgBox("Felicitaciones.", MsgBoxStyle.Information, "Politecnico Grancolombiano - Baúl de juegos")
                TableLayoutPanel2.Visible = False
                TableLayoutPanel1.Visible = True
                TextBox5.Text = ""
            End If
        ElseIf tipo.Equals("resta") Then
            Dim preResult As Integer = Integer.Parse(TextBox1.Text) - Integer.Parse(TextBox3.Text)
            Dim result As Integer = Integer.Parse(TextBox5.Text)

            If preResult <> result Then
                MsgBox("Intentalo de nuevo.", MsgBoxStyle.Information, "Politecnico Grancolombiano - Baúl de juegos")
            Else
                MsgBox("Felicitaciones.", MsgBoxStyle.Information, "Politecnico Grancolombiano - Baúl de juegos")
                TableLayoutPanel2.Visible = False
                TableLayoutPanel1.Visible = True
                TextBox5.Text = ""
            End If
        End If
    End Sub
End Class