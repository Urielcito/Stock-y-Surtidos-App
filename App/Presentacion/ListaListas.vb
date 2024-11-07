Imports System.IO
Public Class ListaListas

    Dim listaCompra As New ListaCompra()
    Dim cont As New Controladora()
    Dim nombreLista As String = ""

    Private Sub ListaListas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        visibilidadInformacion(False)
        cargarListaListas()
    End Sub

    Public Sub cargarListaListas()
        Me.lstListas.Items.Clear()
        Dim lista As New ListViewItem
        Dim listaArchivos = Directory.EnumerateFiles("lists\")
        For Each str As String In listaArchivos
            str = str.Substring(str.IndexOf("\") + 1)
            str = str.Split(".").ElementAt(0)
            lista = New ListViewItem(str)
            lista.SubItems.Add(str)
            Me.lstListas.Items.Add(lista)
        Next

    End Sub
    Public Sub cargarListaCompra(ruta As String)

        Dim colProductos = cont.listadoproducto()
        Me.lstCompras.Items.Clear()
        Dim lista As New ListViewItem
        Dim precioTotal As Double = 0.0
        Dim precioDebito As Double = 0.0
        Dim precioEfectivo As Double = 0.0
        listaCompra.loadFromCSV(cont, ruta)
        For Each p As Producto In listaCompra.mproductos
            lista = New ListViewItem(p.id)
            lista.SubItems.Add(p.nombre)
            lista.SubItems.Add(p.fuente.nombre)
            Dim cant = listaCompra.mcantidades.ElementAt(listaCompra.mproductos.IndexOf(p))
            lista.SubItems.Add(cant)
            lista.SubItems.Add(p.precio * cant)
            If p.fuente.aceptan_tarjeta Then
                precioDebito += p.precio * cant
            Else
                precioEfectivo += p.precio * cant
            End If
            precioTotal += p.precio * cant
            lista.SubItems.Add(p.precio)
            Me.lstCompras.Items.Add(lista)
        Next

        ' Rellenado de campos con informacion de los productos de la lista.
        Me.lblPrecioDebito.Text = "$" & precioDebito
        Me.lblPrecioEfectivo.Text = "$" & precioEfectivo
        Me.lblPrecioTotal.Text = "$" & precioTotal


    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        cargarListaListas()
    End Sub

    Private Sub visibilidadInformacion(b As Boolean)
        lblEfectivo.Visible = b
        lblDebito.Visible = b
        lblTotal.Visible = b
        lblPrecioEfectivo.Visible = b
        lblPrecioDebito.Visible = b
        lblPrecioTotal.Visible = b
        btnEliminar.Visible = b
        btnGuardar.Visible = b
        If (nombreLista = "lista temporal") Then
            btnGuardar.Text = "Guardar..."
        Else
            btnGuardar.Text = "Cambiar nombre..."
        End If
        If (b = False) Then
            Me.lstCompras.Items.Clear()
        End If
    End Sub

    Private Sub lstListas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstListas.SelectedIndexChanged
        If lstListas.SelectedItems.Count > 0 Then
            nombreLista = lstListas.SelectedItems(0).Text
        End If
        visibilidadInformacion(True)

        Dim ruta As String = "lists\" + (nombreLista) + ".csv"

        cargarListaCompra(ruta)
    End Sub

    Private Sub ListaListas_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dim princi As New Principal
        princi.Visible = True
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim ruta As String = "lists\" + (nombreLista) + ".csv"
        listaCompra.deleteCSV(ruta)
        cargarListaListas()
        visibilidadInformacion(False)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim originalPath As String = "lists\" + (nombreLista) + ".csv"
        Dim filePath As String = InputBox("Ingrese nombre de la lista", "Nombre de la lista", "")
        If Not filePath.Equals("") Then
            filePath &= ".csv"
            If nombreLista.Equals("lista temporal") Then
                ' Guarda la lista en un nuevo archivo
                listaCompra.saveToNewCSV(filePath)
            Else
                listaCompra.deleteCSV(originalPath)
                listaCompra.saveToNewCSV(filePath)
            End If
        End If
        cargarListaListas()
        visibilidadInformacion(False)
    End Sub
End Class