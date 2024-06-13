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

    Public Function MostrarProductos() As ArrayList
        Dim p_fuente As New pFuente
        Dim p_categoria As New pCategoria
        Dim col_fuentes As New ArrayList
        Dim col_categorias As New ArrayList
        Dim dt As DataTable = Nothing
        Dim strSelect As String
        Dim un_producto As Producto
        Dim col_producto As New ArrayList




        strSelect = "select * from producto"
        Try
            Dim una_fuente = New Fuente
            Dim una_categoria = New Categoria

            col_fuentes = p_fuente.MostrarFuentes
            col_categorias = p_categoria.MostrarCategorias
            unaconexion.AbrirConexion()
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
                col_producto.Add(un_producto)
            Next
            Return col_producto
        Catch ex As Exception
            Throw ex
        Finally
            unaconexion.CerrarConexion()
        End Try
    End Function

    'FUNCIONES DE LAS DISTINTAS VISTAS
    Public Function queComprar() As ArrayList
        Dim strVista As String
        Dim p_fuente As New pFuente
        Dim p_categoria As New pCategoria
        Dim col_fuentes As New ArrayList
        Dim col_categorias As New ArrayList
        Dim dt As DataTable = Nothing
        Dim un_producto As Producto
        Dim col_vista As New ArrayList

        strVista = "select p.id, p.nombre,  p.id_fuente, p.id_categoria, p.precio, p.importante, p.cuanto_tenemos, p.nombre_imagen FROM producto p where p.importante = '1' and p.cuanto_tenemos = 'NADA' or p.cuanto_tenemos = 'POCO' order by p.id_fuente"

        Try
            Dim una_fuente = New Fuente
            Dim una_categoria = New Categoria

            col_fuentes = p_fuente.MostrarFuentes
            col_categorias = p_categoria.MostrarCategorias
            unaconexion.AbrirConexion()
            dt = unaconexion.TraerDatos(strVista)
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
                col_vista.Add(un_producto)
            Next
            Return col_vista
        Catch ex As Exception
            Throw ex
        Finally
            unaconexion.CerrarConexion()
        End Try

    End Function
End Class
