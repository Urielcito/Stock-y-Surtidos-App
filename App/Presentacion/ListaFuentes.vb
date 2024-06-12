Public Class ListaFuentes
    Dim cont As New Controladora
    Dim col_productos As New ArrayList
    Dim col_fuentes As New ArrayList
    Dim id_fuente As Integer

    Private Sub cargarListView(ByVal col_fuentes As ArrayList)
        Me.lstFuentes.Items.Clear()
        Dim lista As ListViewItem
        For Each una_fuente As Fuente In col_fuentes
            lista = New ListViewItem(una_fuente.id)
            lista.SubItems.Add(una_fuente.nombre)
            Dim aceptan_tarjeta = "NO"
            If (una_fuente.aceptan_tarjeta) Then
                aceptan_tarjeta = "SI"
            End If
            lista.SubItems.Add(aceptan_tarjeta)
            lista.SubItems.Add(una_fuente.telefono)
            Me.lstFuentes.Items.Add(lista)
        Next
    End Sub
    Private Sub cargarListas()
        Dim bs_fuentes As New BindingSource
        col_fuentes = cont.listadofuente
        bs_fuentes.DataSource = col_fuentes
        cargarListView(col_fuentes)
    End Sub

    Private Sub lstFuentes_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles lstFuentes.ItemSelectionChanged
        If lstFuentes.SelectedItems.Count > 0 Then
            id_fuente = lstFuentes.SelectedItems(0).Text
        End If
        Dim la_fuente = cont.devolverFuente(id_fuente)
        'lblNombre.Text = "Nombre: " & la_fuente.nombre
        'lblAceptan_tarjeta.Text = lstFuentes.SelectedItems(2).Text & " aceptan tarjeta."
        'lblTelefono.Text = "Telefono: " & la_fuente.telefono
        'lblCant.Text = cont.devolverCantProductosFuente(la_fuente) & " Productos."


    End Sub


End Class