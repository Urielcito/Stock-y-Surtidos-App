Public Class pCategoria
    Private unaconexion As New Conexion
    Public Function AgregarCategoria(ByVal pcategoria As Categoria) As Boolean 'básicamente el uso de sentencias sql, el programa envía la sentencia sql en forma de string al servidor en el cual está situada nuestra base de datos y esta es ejecutada.
        Dim strInsert As String = ""
        Try
            strInsert = "insert into categoria (nombre) values ('" & pcategoria.nombre & "');"
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

    Public Function EliminarCategoria(ByVal unid As Integer) As Boolean
        Dim strInsert As String = ""
        Try

            strInsert = "DELETE FROM categoria WHERE id= " & unid & ";DELETE FROM producto WHERE id_categoria = " & unid
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

    Public Function ModificarCategoria(ByVal pcategoria As Categoria) As Boolean
        Dim strInsert As String = ""
        Try

            strInsert = "UPDATE categoria SET nombre='" & pcategoria.nombre & "' WHERE id=" & pcategoria.id & ";"
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

    Public Function MostrarCategorias() As ArrayList
        Dim dt As DataTable = Nothing
        Dim strSelect As String
        Dim una_categoria As Categoria
        Dim col_categoria As New ArrayList
        strSelect = "select * from fuente"
        Try
            unaconexion.AbrirConexion()
            dt = unaconexion.TraerDatos(strSelect)
            For i As Integer = 0 To dt.Rows.Count - 1
                una_categoria = New Categoria 'Se construye un objeto vacio de tipo Fuente y se rellena con los datos conseguidos de la base de datos.
                una_categoria.nombre = dt(i).Item("nombre").ToString
                col_categoria.Add(una_categoria)
            Next
            Return col_categoria 'La función devuelve la colección de objetos de tipo Fuente, en la cual yacen todos los objetos generados por los datos conseguidos de la base de datos.
        Catch ex As Exception
            Throw ex
        Finally
            unaconexion.CerrarConexion()
        End Try

    End Function

End Class


