Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class pProducto
    Private unaconexion As New Conexion

    'FUNCIONES ABM
    Public Function AgregarProducto(ByVal pProducto As Producto) As Boolean
        Dim strInsert As String = ""
        Try
            strInsert = "insert into producto (id_fuente, id_categoria, nombre, precio, cuanto_tenemos, importante, nombre_imagen) values ('" & pProducto.fuente.id & "', '" & pProducto.categoria.id & "', '" & pProducto.nombre & "', '" & pProducto.precio & "', '" & pProducto.cuanto_tenemos & "', '" & -CInt(pProducto.importante) & "', '" & pProducto.nombre_imagen & "');"
            unaconexion.AbrirConexion()
            unaconexion.EjecutarSQL(strInsert)

            Return True
        Catch ex As Exception
            MessageBox.Show("Sentencia SQL: " & strInsert & "\nError: " & ex.Message)
            Throw ex
        Finally
            unaconexion.CerrarConexion()
        End Try
        Return False
    End Function

    Public Function EliminarProducto(ByVal unid As Integer) As Boolean
        Dim strDelete As String = ""
        Try
            strDelete = "DELETE FROM producto WHERE id = " & unid
            unaconexion.AbrirConexion()
            unaconexion.EjecutarSQL(strDelete)

            Return True
        Catch ex As Exception
            Throw ex
        Finally
            unaconexion.CerrarConexion()
        End Try
        Return False
    End Function

    Public Function ModificarProducto(ByVal pProd As Producto) As Boolean
        Dim strModify As String = ""
        Try
            strModify = "UPDATE producto SET id_fuente='" & pProd.fuente.id & "', id_categoria='" & pProd.categoria.id & "', nombre = '" & pProd.nombre & "', precio = '" & pProd.precio & "', cuanto_tenemos = '" & pProd.cuanto_tenemos & "', importante = '" & -CInt(pProd.importante) & "', nombre_imagen ='" & pProd.nombre_imagen & "' WHERE id = " & pProd.id & ";"
            unaconexion.AbrirConexion()
            unaconexion.EjecutarSQL(strModify)
            Return True
        Catch ex As Exception
            Throw ex
        Finally
            unaconexion.CerrarConexion()
        End Try
        Return False
    End Function

    Private Function extraerProductosAColeccion(ByVal dt As DataTable, ByVal col_productos As ArrayList, ByVal strSelect As String)
        Dim p_fuente As New pFuente
        Dim p_categoria As New pCategoria
        Dim col_fuentes As ArrayList
        Dim col_categorias As ArrayList
        Dim un_producto As Producto
        col_fuentes = p_fuente.MostrarFuentes
        col_categorias = p_categoria.MostrarCategorias
        dt = unaconexion.TraerDatos(strSelect)
        For i As Integer = 0 To dt.Rows.Count - 1
            un_producto = New Producto
            un_producto.id = CInt(dt(i).Item("id"))
            Dim id_fuente = CInt(dt(i).Item("id_fuente"))
            Dim id_categoria = CInt(dt(i).Item("id_categoria"))
            un_producto.fuente = New Fuente
            un_producto.categoria = New Categoria
            For Each una_fuente In col_fuentes
                If (una_fuente.id = id_fuente) Then
                    un_producto.fuente = una_fuente
                    Exit For
                End If
            Next
            For Each una_categoria In col_categorias
                If (una_categoria.id = id_categoria) Then
                    un_producto.categoria = una_categoria
                    Exit For
                End If
            Next

            un_producto.nombre = dt(i).Item("nombre")
            un_producto.precio = CDbl(dt(i).Item("precio"))
            un_producto.cuanto_tenemos = dt(i).Item("cuanto_tenemos")
            un_producto.importante = CBool(dt(i).Item("importante"))
            un_producto.nombre_imagen = dt(i).Item("nombre_imagen")
            col_productos.Add(un_producto)
        Next
        Return col_productos

    End Function

    Public Sub calcularStringsQuery(ByVal defaultSelect As Boolean, ByRef stringBusqueda As String, ByRef stringDeFuente As String, ByRef stringDeCategoria As String, ByVal id_fuente As Integer, ByVal id_categoria As Integer, ByVal buscando As Boolean, ByVal txt_busqueda As String)
        Dim primerPalabra As String = "and "
        If (defaultSelect) Then
            primerPalabra = "where "
        End If
        If (id_fuente <> 0) Then
            stringDeFuente = primerPalabra & "p1.id_fuente = '" & id_fuente & "'"
        End If
        If (id_categoria <> 0) Then
            stringDeCategoria = primerPalabra & "p1.id_categoria = '" & id_categoria & "'"
        End If
        If (id_fuente <> 0 And id_categoria <> 0) Then
            stringDeFuente = primerPalabra & "p1.id_fuente = '" & id_fuente & "'"
            stringDeCategoria = primerPalabra & "p1.id_categoria = '" & id_categoria & "'"
        End If
        If (buscando) Then
            If (id_categoria <> 0 Or id_fuente <> 0) Then
                stringBusqueda = primerPalabra & "p1.nombre like '%" & txt_busqueda & "%'"
            Else
                stringBusqueda = primerPalabra & "p1.nombre like '%" & txt_busqueda & "%'"
            End If
        End If
    End Sub
    Public Function MostrarProductos(ByVal buscando As Boolean, ByVal txt_busqueda As String, ByVal id_fuente As Integer, ByVal id_categoria As Integer) As ArrayList
        Dim defaultSelect = True
        Dim stringBusqueda As String = ""
        Dim stringDeFuente As String = ""
        Dim stringDeCategoria As String = ""
        calcularStringsQuery(defaultSelect, stringBusqueda, stringDeFuente, stringDeCategoria, id_fuente, id_categoria, buscando, txt_busqueda)
        Dim strSelect = "select * from producto as p1 " & stringDeFuente & stringDeCategoria & stringBusqueda & " order by nombre"
        Dim col_producto As New ArrayList
        Dim dt As DataTable = Nothing
        Try
            unaconexion.AbrirConexion()
            Return extraerProductosAColeccion(dt, col_producto, strSelect)
        Catch ex As Exception
            MessageBox.Show(strSelect)
            Throw ex
        Finally
            unaconexion.CerrarConexion()
        End Try
    End Function

    'FUNCIONES DE LAS DISTINTAS VISTAS
    Public Function queComprar(ByVal buscando As Boolean, ByVal txt_busqueda As String, ByVal id_fuente As Integer, ByVal id_categoria As Integer) As ArrayList
        'q onda
        Dim stringBusqueda As String = ""
        Dim stringDeFuente As String = ""
        Dim stringDeCategoria As String = ""
        calcularStringsQuery(False, stringBusqueda, stringDeFuente, stringDeCategoria, id_fuente, id_categoria, buscando, txt_busqueda)
        Dim strVista = "select p1.id, p1.id_fuente, p1.id_categoria, t2.nombre, t2.min_precio as precio, p1.importante, p1.cuanto_tenemos, p1.nombre_imagen from producto as p1 join (select min(p2.precio) as min_precio, p2.nombre from producto as p2 group by nombre) as t2 on p1.nombre = t2.nombre and p1.precio = t2.min_precio and p1.importante = '1' and (p1.cuanto_tenemos = 'NADA' or p1.cuanto_tenemos = 'POCO') " & stringDeFuente & stringDeCategoria & stringBusqueda
        Dim dt As DataTable = Nothing
        Dim col_vista As New ArrayList
        Try
            unaconexion.AbrirConexion()
            Return extraerProductosAColeccion(dt, col_vista, strVista)
        Catch ex As Exception
            Throw ex
        Finally
            unaconexion.CerrarConexion()
        End Try

    End Function

    Public Function productosAlMejorPrecio(ByVal buscando As Boolean, ByVal txt_busqueda As String, ByVal id_fuente As Integer, ByVal id_categoria As Integer) As ArrayList
        Dim stringBusqueda As String = ""
        Dim stringDeFuente As String = ""
        Dim stringDeCategoria As String = ""
        calcularStringsQuery(False, stringBusqueda, stringDeFuente, stringDeCategoria, id_fuente, id_categoria, buscando, txt_busqueda)
        Dim strVista = "select p1.id, p1.id_fuente, p1.id_categoria, t2.nombre, t2.min_precio as precio, p1.importante, p1.cuanto_tenemos, p1.nombre_imagen from producto as p1 join (select min(p2.precio) as min_precio, p2.nombre from producto as p2 group by nombre) as t2 on p1.nombre = t2.nombre and p1.precio = t2.min_precio " & stringDeFuente & stringDeCategoria & stringBusqueda
        Dim dt As DataTable = Nothing
        Dim col_vista As New ArrayList
        Try
            unaconexion.AbrirConexion()
            Return extraerProductosAColeccion(dt, col_vista, strVista)
        Catch ex As Exception
            MessageBox.Show(strVista)
            Throw ex
        Finally
            unaconexion.CerrarConexion()
        End Try
    End Function

    Public Function queFaltaEnCasa(ByVal buscando As Boolean, ByVal txt_busqueda As String, ByVal id_fuente As Integer, ByVal id_categoria As Integer) As ArrayList
        Dim stringBusqueda As String = ""
        Dim stringDeFuente As String = ""
        Dim stringDeCategoria As String = ""
        calcularStringsQuery(False, stringBusqueda, stringDeFuente, stringDeCategoria, id_fuente, id_categoria, buscando, txt_busqueda)
        Dim strVista = "select p1.id, p1.id_fuente, p1.id_categoria, t2.nombre, t2.min_precio as precio, p1.importante, p1.cuanto_tenemos, p1.nombre_imagen from producto as p1 join (select min(p2.precio) as min_precio, p2.nombre from producto as p2 group by nombre) as t2 on p1.nombre = t2.nombre and p1.precio = t2.min_precio and (p1.cuanto_tenemos = 'NADA') " & stringDeFuente & stringDeCategoria & stringBusqueda
        Dim dt As DataTable = Nothing
        Dim col_vista As New ArrayList
        Try
            unaconexion.AbrirConexion()
            Return extraerProductosAColeccion(dt, col_vista, strVista)
        Catch ex As Exception
            Console.WriteLine(strVista)
            Throw ex
        Finally
            unaconexion.CerrarConexion()
        End Try
    End Function
End Class
