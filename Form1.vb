Public Class Form1

    Public numeroGenerado As Integer



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGenerarNumero.Click
        'Generar numero del 1 al 100 inlusive'
        numeroGenerado = CInt(Math.Ceiling(Rnd() * 100)) + 1

        btnGenerarNumero.Enabled = False


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        numeroGenerado = 0

        btnGenerarNumero.Enabled = True

        ListView1.Clear()



    End Sub

    'Boton salir'
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.Exit()

    End Sub


    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown

        If e.KeyCode = Keys.KeyCode.Enter Then

            'Si el valor es numerico entra'
            If IsNumeric(TextBox1.Text) Then
                Dim numeroIntroducido As Integer = CInt(TextBox1.Text)
                ListView1.Items.Add(numeroIntroducido)

                If numeroIntroducido > numeroGenerado Then
                    ListView1.Items.Add("El numero secreto es menor")

                ElseIf numeroIntroducido < numeroGenerado Then

                    ListView1.Items.Add("El numero secreto es mayor")

                Else
                    ListView1.Items.Add("Correcto el numero era " + numeroGenerado.ToString)
                    numeroGenerado = 0
                    btnGenerarNumero.Enabled = True

                End If

            Else
                ListView1.Items.Add("Introduce un numero")


            End If

        End If
    End Sub

End Class
