Imports System.IO
Public Class ListaCompra
    Private ruta As String = "lists\productlist.csv"
    Public Property mproductos As List(Of Producto)
    Public Property mcantidades As List(Of Integer)


    Public Sub New()
        mproductos = New List(Of Producto)
        mcantidades = New List(Of Integer)
    End Sub

    Public Sub loadFromCSV(cont As Controladora)
        Me.mproductos.Clear()
        Me.mcantidades.Clear()
        If (Not Directory.Exists("lists")) Then
            Directory.CreateDirectory("lists")
        End If
        Try
            If (Not File.Exists(ruta)) Then
                File.Create(ruta).Dispose()
            End If
            Using sr As New StreamReader(ruta)
                Dim line As String
                While (sr.Peek() >= 0)
                    line = sr.ReadLine()
                    Dim parts As String() = line.Split(","c) ' Dividir la línea en ID y cantidad
                    Dim idProducto As Integer = Convert.ToInt32(parts(0))
                    Dim cantidad As Integer = Convert.ToInt32(parts(1))
                    Dim elProducto = cont.devolverProducto(idProducto)
                    If elProducto IsNot Nothing Then
                        mproductos.Add(elProducto)
                        mcantidades.Add(cantidad)
                    End If
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al leer el archivo CSV: " & ex.Message)
        End Try
    End Sub

    Public Sub addIDToCSV(elProducto As Producto, cant As Integer)
        Try
            Using sw As StreamWriter = File.AppendText(ruta)
                sw.WriteLine(elProducto.id().ToString() & "," & cant.ToString()) ' Guardar ID y cantidad separados por una coma
            End Using
            Me.mproductos.Add(elProducto)
            Me.mcantidades.Add(cant)
        Catch ex As Exception
            MessageBox.Show("Error al escribir al archivo CSV: " & ex.Message)
        End Try
    End Sub

    Public Sub saveToCSV()
        Try
            Dim listaDatos As New List(Of String)
            For i As Integer = 0 To mproductos.Count - 1
                Dim idProducto = mproductos(i).id()
                Dim cantidad = mcantidades(i)
                listaDatos.Add(idProducto.ToString() & "," & cantidad.ToString()) ' Guardar ID y cantidad separados por coma
            Next
            File.WriteAllLines(ruta, listaDatos)
        Catch ex As Exception
            MessageBox.Show("Error al guardar la lista al archivo CSV: " & ex.Message)
        End Try
    End Sub

    Public Sub saveToNewCSV(filePath As String)
        Try
            filePath = "lists/" & filePath
            If (Not File.Exists(filePath)) Then
                File.Create(filePath).Dispose()
            End If
            Dim listaDatos As New List(Of String)
            For i As Integer = 0 To mproductos.Count - 1
                Dim idProducto = mproductos(i).id()
                Dim cantidad = mcantidades(i)
                listaDatos.Add(idProducto.ToString() & "," & cantidad.ToString()) ' Guardar ID y cantidad separados por coma
            Next
            File.WriteAllLines(filePath, listaDatos)
        Catch ex As Exception
            MessageBox.Show("Error al guardar toda la lista al CSV: " & ex.Message)
        End Try
    End Sub
    Public Sub removeFromCSV(elProducto As Producto)
        Try
            Dim i = mproductos.IndexOf(elProducto)
            mcantidades.RemoveAt(i)
            mproductos.Remove(elProducto)
            saveToCSV()
        Catch ex As Exception
            MessageBox.Show("Error al eliminar del archivo CSV: " & ex.Message)
        End Try
    End Sub
    Public Sub clearCSV()
        Try
            File.WriteAllText(ruta, String.Empty)
        Catch ex As Exception
            MessageBox.Show("Error al limpiar el archivo CSV: " & ex.Message)
        End Try
    End Sub

    Public Function existsInCSV(cont As Controladora, id As Integer) As Boolean
        Dim exists As Boolean = False
        Using sr As New StreamReader(ruta)
            Dim line As String
            While (sr.Peek() >= 0 And Not exists)
                line = sr.ReadLine()
                Dim parts As String() = line.Split(","c) ' Dividir la línea en partes (ID, cantidad)
                Dim idProducto As Integer = Convert.ToInt32(parts(0)) ' Tomar el ID del producto
                If (idProducto = id) Then
                    exists = True
                End If
            End While
        End Using
        Return exists
    End Function


    Public Sub clearList()
        Try
            File.WriteAllText(ruta, String.Empty)
            Me.mproductos.Clear()
            Me.mcantidades.Clear()
        Catch ex As Exception
            MessageBox.Show("Error al limpiar el archivo CSV: " & ex.Message)
        End Try
    End Sub
End Class
