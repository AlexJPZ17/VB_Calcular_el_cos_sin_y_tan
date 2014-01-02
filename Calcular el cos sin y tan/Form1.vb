Public Class Form1
    Private Sub Trigonometria()
        'Declaramos las variables
        Dim angulo, res As Double
        Dim funcion As String

        'Condición para validar el TextBox_Angulo si este se encuentra vacío 
        If TextBox_Angulo.Text = "" Then
            MessageBox.Show("Ingrese un angulo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Coloca el Focus en el TextBox_Angulo
            TextBox_Angulo.Focus()
        Else
            'Función que convierte en un tipo double el valor que se ingrese por 
            'el TextBox_Angulo y lo almacena en la variable ángulo 
            angulo = Double.Parse(TextBox_Angulo.Text)
            'Método para extraer los Item seleccionado en el ComboBox
            funcion = ComboBox_Funciones.Text
            'Condición que evalúa la variable función si es igual a las funciones 
            'seleccionada en el ComboBox 
            If funcion = "Funciones" Then
                MessageBox.Show("Seleccione una de las funciones", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                'Select Case nos permitirá controlar
                'las opciones que escojamos por el ComboBox
                Select Case funcion
                    Case "Cos"
                        'Método que saca el Coseno del dato que este almacenado 
                        'en la varia ángulo y lo almacena en la variable res
                        res = Math.Cos(Math.PI * Val(angulo) / 180)
                        MessageBox.Show("El coseno del angulo " & angulo & " es " & res)

                    Case "Sin"
                        'Método que saca el Seno del dato que este almacenado 
                        'en la varia ángulo y lo almacena en la variable res
                        res = Math.Sin(Math.PI * Val(angulo) / 180)
                        MessageBox.Show("El Seno del angulo " & angulo & " es " & res)

                    Case "Tan"
                        'Método que saca el Tangente del dato que este almacenado 
                        'en la varia ángulo y lo almacena en la variable res
                        res = Math.Tan(Math.PI * Val(angulo) / 180)
                        MessageBox.Show("El Tangente del angulo " & angulo & " es " & res)
                End Select
            End If

        End If

    End Sub
   
    Private Sub Button_Run_Click(sender As Object, e As EventArgs) Handles Button_Run.Click
        Trigonometria()
    End Sub
End Class
