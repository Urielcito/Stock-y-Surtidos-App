Imports System.IO
Public Class ListaCompra
    Public Property mproductos As List(Of Producto)
    Public Sub New()
        mproductos = New List(Of Producto)
        loadFromCSV("productlist.csv")
    End Sub

    Public Sub loadFromCSV(filePath As String)
        Try
            If (Not File.Exists("productlist.csv")) Then
                File.Create("productlist.csv").Dispose()
            End If
            Dim cont As New Controladora()
            Using sr As New StreamReader(filePath)
                Dim line As String
                While (sr.Peek() >= 0)
                    line = sr.ReadLine()
                    Dim value = Convert.ToInt32(line)
                    Dim elProducto = cont.devolverProducto(value)
                    mproductos.Add(elProducto)
                End While
            End Using
            MessageBox.Show("CSV Cargado")
        Catch ex As Exception
            MessageBox.Show("Error al leer el archivo CSV: " & ex.Message)
        End Try
    End Sub

    Public Sub addIDToCSV(id As Integer, filePath As String)
        Try
            Dim cont As New Controladora()
            Using sw As StreamWriter = File.AppendText(filePath)
                sw.WriteLine(id.ToString())
            End Using
            Dim elProducto = cont.devolverProducto(id)
            mproductos.Add(elProducto)
            MessageBox.Show("Producto agregado a la lista.")
        Catch ex As Exception
            MessageBox.Show("Error al escribir al archivo CSV: " & ex.Message)
        End Try
    End Sub

    Public Sub clearCSV(filePath As String)
        Try
            File.WriteAllText(filePath, String.Empty)
            mproductos.Clear()
        Catch ex As Exception
            MessageBox.Show("Error al limpiar el archivo CSV: " & ex.Message)
        End Try
    End Sub
End Class
