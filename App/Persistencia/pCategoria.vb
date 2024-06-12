Public Class pCategoria
    Private unaconexion As New Conexion

    'FUNCIONES ABM
    Public Function ReadException(ByVal ex As Exception) As String
        Dim msg As String = ex.Message
        If ex.InnerException IsNot Nothing Then
            msg = msg & vbCrLf & "---------" & vbCrLf & ReadException(ex.InnerException)
        End If
        Return msg
    End Function

    Public Function AgregarCategoria(ByVal pcategoria As Categoria) As Boolean 'básicamente el uso de sentencias sql, el programa envía la sentencia sql en forma de string al servidor en el cual está situada nuestra base de datos y esta es ejecutada.
        Dim strInsert As String = ""
        Try
            strInsert = "insert into categoria (nombre) values ('" & pcategoria.nombre & "')"
            unaconexion.AbrirConexion()
            unaconexion.EjecutarSQL(strInsert)

            Return True
        Catch ex As Exception
            MessageBox.Show(ReadException(ex))
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
        strSelect = "select * from categoria"
        Try
            unaconexion.AbrirConexion()
            dt = unaconexion.TraerDatos(strSelect)
            For i As Integer = 0 To dt.Rows.Count - 1
                una_categoria = New Categoria 'Se construye un objeto vacio de tipo Categoria y se rellena con los datos conseguidos de la base de datos.
                una_categoria.id = CInt(dt(i).Item("id"))
                una_categoria.nombre = dt(i).Item("nombre").ToString
                col_categoria.Add(una_categoria)
            Next
            Return col_categoria 'La función devuelve la colección de objetos de tipo Categoria, en la cual yacen todos los objetos generados por los datos conseguidos de la base de datos.
        Catch ex As Exception
            Throw ex
        Finally
            unaconexion.CerrarConexion()
        End Try

    End Function

End Class


