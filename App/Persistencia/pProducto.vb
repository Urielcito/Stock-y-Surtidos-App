Public Class pProducto
    Private unaconexion As New Conexion

    Public Function AgregarProducto(ByVal pProducto As Producto) As Boolean
        Dim strInsert As String = ""
        Try
            strInsert = "insert into producto (id_fuente, id_categoria, nombre, precio, hay_en_casa, cuanto_tenemos) values ('" & pProducto.fuente.id & "','" & pProducto.categoria.id & "','" & pProducto.nombre & "', '" & pProducto.precio & "', '" & pProducto.hay_en_casa & "', '" & pProducto.cuanto_tenemos & "');"
            unaconexion.AbrirConexion()
            unaconexion.EjecutarSQL(strInsert)

            Return True
        Catch ex As Exception
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
            strModify = "UPDATE producto SET id_fuente='" & pProd.fuente.id 'TERMINAR ESTO
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
