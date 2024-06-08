Public Class Controladora
    Dim col_fuente As New ArrayList
    Private p_fuente As New pFuente

    Public Function AgregarFuente(ByVal un_nombre As String, ByVal un_aceptan_tarjeta As Boolean, ByVal un_telefono As Integer)
        Try
            Dim una_fuente As Fuente
            una_fuente = New Fuente(0, un_nombre, un_aceptan_tarjeta, un_telefono)
            If p_fuente.AgregarFuente(una_fuente) = True Then
            End If

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function BorrarEmpleado(ByVal un_id As Integer) As Boolean
        If p_fuente.EliminarFuente(un_id) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function ModificarFuente(ByVal un_id As Integer, ByVal un_nombre As String, ByVal un_aceptan_tarjeta As Boolean, ByVal un_telefono As Integer)
        Dim una_fuente As New Fuente()
        una_fuente.id = un_id
        una_fuente.nombre = un_nombre
        una_fuente.aceptan_tarjeta = un_aceptan_tarjeta
        una_fuente.telefono = un_telefono
        If p_fuente.ModificarFuente(una_fuente) = True Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function listadofuente() As ArrayList
        col_fuente = p_fuente.MostrarFuentes
        Return col_fuente
    End Function 'TO-DO: Hacer la base de datos y todos los P
End Class
