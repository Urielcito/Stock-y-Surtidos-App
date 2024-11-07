Imports System.IO
Imports ClosedXML.Excel

Public Class ListaCompra
    Private ruta As String = "lists\lista temporal.csv"

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

    Public Sub loadFromCSV(cont As Controladora, ruta As String)
        Me.mproductos.Clear()
        Me.mcantidades.Clear()
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

    Public Sub saveToCSV() ' TO-DO : esta roto
        Try
            Dim size = mproductos.Count() - 1
            Dim listaDatos As New List(Of String)
            For i As Integer = 0 To size
                Dim idProducto = mproductos(i).id()
                Dim cantidad = mcantidades(devolverIndexProducto(idProducto))
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
                Dim cantidad = mcantidades(devolverIndexProducto(idProducto))
                listaDatos.Add(idProducto.ToString() & "," & cantidad.ToString()) ' Guardar ID y cantidad separados por coma
            Next
            File.WriteAllLines(filePath, listaDatos)
        Catch ex As Exception
            MessageBox.Show("Error al guardar toda la lista al CSV: " & ex.Message)
        End Try
    End Sub
    Public Sub removeFromCSV(elProducto As Producto)
        Dim i As Integer
        Try
            For Each p As Producto In mproductos
                If p.id = elProducto.id Then
                    Exit For
                End If
                i += 1
            Next
            mcantidades.RemoveAt(i)
            mproductos.RemoveAt(i)
            saveToCSV()
        Catch ex As Exception
            MessageBox.Show("Error al eliminar del archivo CSV, index producto = " & mproductos.IndexOf(elProducto) & ", i cantidades = " & i & ", tamaño de cantidades: " & mcantidades.Count() & " tamaño de mproductos: " & mproductos.Count())
        End Try
    End Sub
    Public Sub clearCSV()
        Try
            File.WriteAllText(ruta, String.Empty)
        Catch ex As Exception
            MessageBox.Show("Error al limpiar el archivo CSV: " & ex.Message)
        End Try
    End Sub

    Public Function existsInCSV(id As Integer) As Integer 'returns the position of the product inside the csv file
        Dim exists As Boolean = False
        Dim count As Integer = 0
        Using sr As New StreamReader(ruta)
            Dim line As String
            While (sr.Peek() >= 0 And Not exists)
                line = sr.ReadLine()
                Dim parts As String() = line.Split(","c) ' Dividir la línea en partes (ID, cantidad)
                Dim idProducto As Integer = Convert.ToInt32(parts(0)) ' Tomar el ID del producto
                If (idProducto = id) Then
                    exists = True
                Else
                    count += 1
                End If

            End While
        End Using

        If (Not exists) Then
            count = -1
        End If
        Return count
    End Function

    Public Sub changeProductQuantityInCSV(index As Integer, cant As Integer)
        Dim lines As List(Of String) = File.ReadAllLines(ruta).ToList()
        ' Comprueba si el índice está dentro del rango de líneas del archivo
        If index >= 0 And index < lines.Count Then
            ' Actualiza la línea específica con la cantidad nueva
            Dim originalLine As String = lines(index)
            Dim parts() As String = originalLine.Split(","c) ' Ajusta el delimitador según el formato de tu CSV
            Dim originalCant = Integer.Parse(parts(1))
            cant += originalCant
            mcantidades(index) = cant
            ' Cambia el valor en la columna deseada (ejemplo: columna 2 para la cantidad)
            parts(1) = cant.ToString() ' Cambia el índice según la posición de 'cantidad' en tu CSV
            lines(index) = String.Join(",", parts)

            ' Escribe todas las líneas nuevamente en el archivo
            File.WriteAllLines(ruta, lines)
        Else
            MessageBox.Show("Índice fuera de rango: " & index)
        End If
    End Sub

    Public Sub deleteCSV(ruta As String)
        File.Delete(ruta)
    End Sub
    Public Sub clearList()
        Try
            File.WriteAllText(ruta, String.Empty)
            Me.mproductos.Clear()
            Me.mcantidades.Clear()
        Catch ex As Exception
            MessageBox.Show("Error al limpiar el archivo CSV: " & ex.Message)
        End Try
    End Sub

    Public Function displayMemoryProductList() As String
        Dim s As String = ""
        If Me.mproductos.Count() > 0 Then
            s = Me.mproductos(0).id()
            For index = 1 To Me.mproductos.Count() - 1
                s += ", " & mproductos(index).id()
            Next
        End If

        Return s
    End Function

    Public Function displayMemoryQuantityList() As String
        Dim s As String = ""
        If Me.mcantidades.Count() > 0 Then
            s = Me.mcantidades(0)
            For index = 1 To Me.mcantidades.Count() - 1
                s += ", " & mcantidades(index)
            Next
        End If
        Return s
    End Function

    Public Function devolverIndexProducto(id As Integer) As Integer
        Dim index As Integer = 0
        For Each p As Producto In mproductos
            If (p.id = id) Then
                Exit For
            End If
            index += 1
        Next
        Return index
    End Function
End Class
