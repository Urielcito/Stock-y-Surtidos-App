Public Class AgregarFuente
    Dim cont As New Controladora



    'Formulario
    Private Sub AgregarFuente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnAgregar.Enabled = False
    End Sub



    'ABM
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim nombre = txtNombre.Text
        Dim aceptan_tarjeta = chkAceptaTarjeta.Checked
        Dim telefono = CInt(txtTelefono.Text)
        If (cont.AgregarFuente(nombre, aceptan_tarjeta, telefono)) Then
            MessageBox.Show("Fuente agregada con exito")
        Else
            MessageBox.Show("Hubo un problema al agregar la fuente, chequee su conexion a la base de datos.")
        End If

        Me.Dispose()
    End Sub



    'Utilidades
    Private Sub sePuedeAgregar()
        Dim hay_un_campo_vacio = txtNombre.Text = "" Or txtTelefono.Text = ""
        Dim telefono_correcto = chequearTelefono()
        btnAgregar.Enabled = Not hay_un_campo_vacio And telefono_correcto
    End Sub

    Private Function chequearTelefono() As Boolean
        Dim un_integer As Integer
        Dim es_correcto = Integer.TryParse(txtTelefono.Text, un_integer)
        btnAgregar.Enabled = es_correcto
        Return es_correcto
    End Function

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        sePuedeAgregar()
    End Sub

    Private Sub txtTelefono_TextChanged(sender As Object, e As EventArgs) Handles txtTelefono.TextChanged
        sePuedeAgregar()
    End Sub
End Class