Imports System.IO
Public Class ListaCompra
    Public Property mproductos As List(Of Producto)
    Public Sub New()
        mproductos = New List(Of Producto)
    End Sub

    Public Sub loadFromCSV(cont As Controladora, filePath As String)
        Try
            If (Not File.Exists("productlist.csv")) Then
                File.Create("productlist.csv").Dispose()
            End If
            Using sr As New StreamReader(filePath)
                Dim line As String
                While (sr.Peek() >= 0)
                    line = sr.ReadLine()
                    Dim value = Convert.ToInt32(line)
                    Dim elProducto = cont.devolverProducto(value)
                    mproductos.Add(elProducto)
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al leer el archivo CSV: " & ex.Message)
        End Try
    End Sub

    Public Sub addIDToCSV(elProducto As Producto, filePath As String)
        Try
            Dim cont As New Controladora()
            Using sw As StreamWriter = File.AppendText(filePath)
                sw.WriteLine(elProducto.id().ToString())
            End Using
            mproductos.Add(elProducto)
        Catch ex As Exception
            MessageBox.Show("Error al escribir al archivo CSV: " & ex.Message)
        End Try
    End Sub

    Public Sub saveToCSV(filePath As String)
        clearCSV(filePath)
        Try
            Dim listaIDs As New List(Of String)
            For i As Integer = 0 To mproductos.Count - 1
                Dim unProducto = mproductos.ElementAt(i)
                Dim idProducto = unProducto.id()
                listaIDs.Append(idProducto)
            Next
            File.WriteAllLines(filePath, listaIDs) ' NO SE PUEDE HACER ESTO CON FILE = EMPTY, SOLUCION: USAR STREAMWRITER ITERANDO SOBRE MPRODUCTOS.
        Catch ex As Exception
            MessageBox.Show("Error al guardar toda la lista al CSV: " & ex.Message)
        End Try


    End Sub
    Public Sub removeFromCSV(elProducto As Producto, filePath As String)
        Try
            mproductos.Remove(elProducto)
            saveToCSV(filePath)
        Catch ex As Exception
            MessageBox.Show("Error al eliminar del archivo CSV: " & ex.Message)
        End Try
    End Sub
    Public Sub clearCSV(filePath As String)
        Try
            File.WriteAllText(filePath, String.Empty)
        Catch ex As Exception
            MessageBox.Show("Error al limpiar el archivo CSV: " & ex.Message)
        End Try
    End Sub
End Class
