Imports MySql.Data.MySqlClient
Public Class Conexion
    Private MysqlCommand As New MySqlCommand
    Private conexion As MySqlConnection
    Public Sub AbrirConexion()
        Dim ip As String
        Dim user As String
        'ip = InputBox("Escribe la ip del servidor de la base de datos, sea localhost o la ip de un servidor CENTOS", "ip")
        'ip = My.Computer.FileSystem.ReadAllText("C:\CUNT TimeSheet Manager\ipaddress.txt")
        'user = My.Computer.FileSystem.ReadAllText("C:\CUNT TimeSheet Manager\user.txt")
        Try
            Dim MysqlConnString As String = "server=localhost; port=3306;user id=root;password=kuro234098576;database=stockysurtidosapp;Convert Zero Datetime=True"

            conexion = New MySqlConnection(MysqlConnString)
            conexion.Open()
        Catch ex As MySqlException
            Throw ex
        End Try
    End Sub

    Public Sub CerrarConexion()
        Me.conexion.Close()
    End Sub


    Public Function TraerDatos(ByVal CadenaConsulta As String) As DataTable
        Try
            Dim sql As MySqlCommand = New MySqlCommand
            sql.CommandTimeout = 300
            sql.Connection = conexion
            sql.CommandText = CadenaConsulta
            sql.CommandType = CommandType.Text
            Dim DA As New MySqlDataAdapter(sql)
            Dim DT As New DataTable
            DA.Fill(DT)
            Return DT
        Catch ex As MySqlException
            Throw New Exception("No es posible obtener datos.", ex)
        End Try
        Return Nothing
    End Function

    Public Function EjecutarSQL(ByVal sentencias As String) As Boolean

        Dim result As Boolean = False
        Dim myCommand As MySqlCommand = conexion.CreateCommand()
        Dim myTrans As MySqlTransaction
        myTrans = conexion.BeginTransaction()
        myCommand.Connection = conexion
        myCommand.Transaction = myTrans

        Try

            myCommand.CommandText = sentencias
            myCommand.ExecuteNonQuery()
            myTrans.Commit()
            result = True
        Catch ex As MySqlException
            myTrans.Rollback()
            result = False
            Throw ex
        End Try
        Return result
    End Function

End Class

