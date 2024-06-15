Public Class pFuente 'USAR DE REFERENCIA PARA LAS DEMAS CLASES de PERSISTENCIA
    Private unaconexion As New Conexion
    'FUNCIONES ABM
    Public Function AgregarFuente(ByVal pfuente As Fuente) As Boolean 'básicamente el uso de sentencias sql, el programa envía la sentencia sql en forma de string al servidor en el cual está situada nuestra base de datos y esta es ejecutada.
        Dim strInsert As String = ""
        Try
            strInsert = "insert into fuente (nombre, aceptan_tarjeta, telefono) values ('" & pfuente.nombre & "', '" & -CInt(pfuente.aceptan_tarjeta) & "', '" & pfuente.telefono & "');"
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

    Public Function EliminarFuente(ByVal unid As Integer) As Boolean
        Dim strInsert As String = ""
        Try

            strInsert = "DELETE FROM fuente WHERE id= " & unid & ";DELETE FROM producto WHERE id_fuente = " & unid
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

    Public Function ModificarFuente(ByVal un_id As Integer, ByVal p_fuente As Fuente) As Boolean
        Dim strInsert As String = ""
        Try

            strInsert = "UPDATE fuente SET nombre='" & p_fuente.nombre & "', aceptan_tarjeta='" & -CInt(p_fuente.aceptan_tarjeta) & "', telefono='" & p_fuente.telefono & "' WHERE id=" & un_id & ";"
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

    Public Function MostrarFuentes(ByVal orden As String) As ArrayList
        Dim dt As DataTable = Nothing
        Dim strSelect As String
        Dim una_fuente As Fuente
        Dim col_fuente As New ArrayList
        strSelect = "select * from fuente order by " & orden
        Try
            unaconexion.AbrirConexion()
            dt = unaconexion.TraerDatos(strSelect)
            For i As Integer = 0 To dt.Rows.Count - 1
                una_fuente = New Fuente 'Se construye un objeto vacio de tipo Fuente y se rellena con los datos conseguidos de la base de datos.
                una_fuente.id = CInt(dt(i).Item("id"))
                una_fuente.nombre = dt(i).Item("nombre").ToString
                una_fuente.aceptan_tarjeta = CBool(dt(i).Item("aceptan_tarjeta"))
                una_fuente.telefono = CInt(dt(i).Item("telefono"))
                col_fuente.Add(una_fuente)
            Next
            Return col_fuente 'La función devuelve la colección de objetos de tipo Fuente, en la cual yacen todos los objetos generados por los datos conseguidos de la base de datos.
        Catch ex As Exception
            Throw ex
        Finally
            unaconexion.CerrarConexion()
        End Try

    End Function

End Class

