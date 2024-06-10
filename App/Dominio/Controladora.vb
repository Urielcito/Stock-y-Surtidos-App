Public Class Controladora
    Dim col_fuente As New ArrayList
    Dim col_categoria As New ArrayList
    Dim col_producto As New ArrayList

    Private p_fuente As New pFuente
    Private p_categoria As New pCategoria
    Private p_producto As New pProducto

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



    Public Function AgregarCategoria(ByVal un_nombre As String)
        Try
            Dim una_categoria As Categoria
            una_categoria = New Categoria(0, un_nombre)
            If p_categoria.AgregarCategoria(una_categoria) = True Then
            End If

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function BorrarCategoria(ByVal un_id As Integer) As Boolean
        If p_categoria.EliminarCategoria(un_id) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function ModificarCategoria(ByVal un_id As Integer, ByVal un_nombre As String, ByVal un_aceptan_tarjeta As Boolean, ByVal un_telefono As Integer)
        Dim una_categoria As New Categoria()
        una_categoria.id = un_id
        una_categoria.nombre = un_nombre
        If p_categoria.ModificarCategoria(una_categoria) = True Then
            Return True
        Else
            Return False
        End If
    End Function



    Public Function AgregarProducto(ByVal una_fuente As Fuente, ByVal una_categoria As Categoria, ByVal un_nombre As String, ByVal un_precio As Double, ByVal un_cuanto_tenemos As String)
        Try
            Dim un_producto As Producto
            un_producto = New Producto(0, una_fuente, una_categoria, un_nombre, un_precio, un_cuanto_tenemos)
            If p_producto.AgregarProducto(un_producto) = True Then
                MessageBox.Show("Producto añadido con exito")
                Return True
            End If


        Catch ex As Exception
            MessageBox.Show("Hubo un error al añadir el producto")
            Return False
        End Try
    End Function

    Public Function BorrarProducto(ByVal un_id As Integer) As Boolean
        If p_producto.EliminarProducto(un_id) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function ModificarProducto(ByVal un_id As Integer, ByVal una_fuente As Fuente, ByVal una_categoria As Categoria, ByVal un_nombre As String, ByVal un_precio As Double, ByVal un_cuanto_tenemos As String)
        Dim un_producto As New Producto()
        un_producto.id = un_id
        un_producto.fuente = una_fuente
        un_producto.categoria = una_categoria
        un_producto.nombre = un_nombre
        un_producto.precio = un_precio
        un_producto.cuanto_tenemos = un_cuanto_tenemos

        If p_producto.ModificarProducto(un_producto) = True Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function listadofuente() As ArrayList
        col_fuente = p_fuente.MostrarFuentes
        Return col_fuente
    End Function
    Public Function listadocategoria() As ArrayList
        col_categoria = p_categoria.MostrarCategorias
        Return col_categoria
    End Function

    Public Function listadoproducto() As ArrayList
        col_producto = p_producto.MostrarProductos
        Return col_producto
    End Function
End Class
