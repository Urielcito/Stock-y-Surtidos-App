﻿Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Conexion
    Private MysqlCommand As New MySqlCommand
    Private conexion As MySqlConnection
    Private ip As String = ""
    Private user As String = ""
    Private pass As String = ""

    Public Function AbrirConexion() As Boolean
        Dim conectado As Boolean = True
        'ip = InputBox("Escribe la ip del servidor de la base de datos, sea localhost o la ip de un servidor CENTOS", "ip")
        'ip = My.Computer.FileSystem.ReadAllText("C:\CUNT TimeSheet Manager\ipaddress.txt")
        'user = My.Computer.FileSystem.ReadAllText("C:\CUNT TimeSheet Manager\user.txt")
        ip = File.ReadAllText("credentials\ip.txt")
        user = File.ReadAllText("credentials\user.txt")
        pass = File.ReadAllText("credentials\pass.txt")
        Try
            Dim MysqlConnString As String = "server=" + ip + "; port=3306;user id=" + user + ";password=" + pass + ";database=stockysurtidosapp;Convert Zero Datetime=True"
            conexion = New MySqlConnection(MysqlConnString)
            conexion.Open()
        Catch ex As MySqlException
            conectado = Not conectado
            If (ex.Message.StartsWith("Authentication to host")) Then
                MessageBox.Show("La IP o contraseña son incorrectos, o el usuario no existe.")
            Else
                MessageBox.Show(ex.Message)
            End If

        End Try

        Return conectado
    End Function

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
            MessageBox.Show("Error MySQL: " & ex.Message & "Sentencia que causo el error: " & sentencias)
            myTrans.Rollback()
            result = False
            Throw ex
        End Try
        Return result
    End Function

End Class

