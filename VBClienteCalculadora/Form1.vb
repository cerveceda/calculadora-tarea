Public Class Form1
    'Declaramos la variable
    Dim servicio As New wsOperaciones.wsCalculadoraSoapClient

    Private Sub btnSumar_Click(sender As Object, e As EventArgs) Handles btnSumar.Click
        'declara varaibles
        Dim Nro1, Nro2, Suma As Double
        Nro1 = txtNro1.Text
        Nro2 = Double.Parse(txtNro2.Text)
        Suma = servicio.Sumar(Nro1, Nro2)
        MessageBox.Show("La suma de los números es:  " + Suma.ToString())
    End Sub

    Private Sub btnRestar_Click(sender As Object, e As EventArgs) Handles btnRestar.Click
        'declara varaibles
        Dim Nro1, Nro2, Resta As Double
        Nro1 = txtNro1.Text
        Nro2 = Double.Parse(txtNro2.Text)
        Resta = servicio.Restar(Nro1, Nro2)
        MessageBox.Show("La resta de los números es:  " + Resta.ToString())
    End Sub

    Private Sub btnMultiplicar_Click(sender As Object, e As EventArgs) Handles btnMultiplicar.Click
        'declara varaibles
        Dim Nro1, Nro2, Producto As Double
        Nro1 = txtNro1.Text
        Nro2 = Double.Parse(txtNro2.Text)
        Producto = servicio.Multiplicar(Nro1, Nro2)
        MessageBox.Show("El producto de los números es:  " + Producto.ToString())
    End Sub

    Private Sub btnDividir_Click(sender As Object, e As EventArgs) Handles btnDividir.Click
        'declara varaibles
        Dim Nro1, Nro2, Cociente As Double
        Nro1 = txtNro1.Text
        Nro2 = Double.Parse(txtNro2.Text)
        Cociente = servicio.Dividir(Nro1, Nro2)
        MessageBox.Show("El cociente de dividir  los números es:  " + Cociente.ToString())
    End Sub

    Private Sub btnFactorial_Click(sender As Object, e As EventArgs) Handles btnFactorial.Click
        'declara varaibles
        Dim Nro1, Nro2, factor As Double
        Nro1 = txtNro1.Text
        Nro2 = Double.Parse(txtNro2.Text)
        factor = servicio.Factorial(Nro1)
        MessageBox.Show("El factorial del número es:  " + factor.ToString())
    End Sub

    Private Sub btnPotencia_Click(sender As Object, e As EventArgs) Handles btnPotencia.Click
        'declara varaibles
        Dim Nro1, Nro2, potencia1 As Double
        Nro1 = txtNro1.Text
        Nro2 = Double.Parse(txtNro2.Text)
        potencia1 = servicio.Potencia(Nro1, Nro2)
        MessageBox.Show("La potencia del número es:  " + potencia1.ToString())
    End Sub

    Private Sub btnSeno_Click(sender As Object, e As EventArgs) Handles btnSeno.Click
        'declara varaibles
        Dim Nro1, sen As Double
        Nro1 = txtNro1.Text

        sen = servicio.Seno(Nro1)
        MessageBox.Show("El seno del número 1 es:  " + sen.ToString())
    End Sub

    Private Sub btnTangente_Click(sender As Object, e As EventArgs) Handles btnTangente.Click
        'declara varaibles
        Dim Nro1, tan As Double
        Nro1 = txtNro1.Text
        tan = servicio.Tangente(Nro1)
        MessageBox.Show("El seno del número 1 es:  " + tan.ToString())
    End Sub

    Private Sub btnRaizcua_Click(sender As Object, e As EventArgs) Handles btnRaizcua.Click
        'declara varaibles
        Dim Nro1, raizcu As Double
        Nro1 = txtNro1.Text
        raizcu = servicio.RaizCuadrada(Nro1)
        MessageBox.Show("La raíz cuadrada del número es:  " + raizcu.ToString())
    End Sub

    Private Sub btnRaizn_Click(sender As Object, e As EventArgs) Handles btnRaizn.Click
        'declara varaibles
        Dim Nro1, Nro2, raizn As Double
        Nro1 = txtNro1.Text
        Nro2 = txtNro2.Text
        raizn = servicio.RaizEnesima(Nro1, Nro2)
        MessageBox.Show("La raíz N-sima del número es:  " + raizn.ToString())
    End Sub

    Private Sub btnInverso_Click(sender As Object, e As EventArgs) Handles btnInverso.Click
        'declara varaibles
        Dim Nro1 As Double, ninversa As Double
        Nro1 = txtNro1.Text
        ninversa = servicio.numinverso(Nro1)
        MessageBox.Show("El inverso del número es:  " + ninversa.ToString())
    End Sub
End Class
