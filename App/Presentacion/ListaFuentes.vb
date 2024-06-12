Public Class ListaFuentes
    Dim cont As New Controladora
    Dim id_fuente As Integer

    'Formulario
    Private Sub ListaFuentes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        visibilidadInformacion(False)
        cargarListas()
    End Sub

    Private Sub btnAgregarFuente_Click(sender As Object, e As EventArgs) Handles btnAgregarFuente.Click
        Dim af As New AgregarFuente()
        af.Show()
    End Sub

    Private Sub ListaFuentes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim princi As New Principal()
        princi.Show()
        Me.Dispose()
    End Sub

    'Campos o Datos
    Private Sub cargarListView() 'Actualiza la lista de fuentes
        Dim col_fuentes = cont.listadofuente
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

    Private Sub cargarListas() 'Rellena los binding sources
        Dim bs_fuentes As New BindingSource
        Dim col_fuentes = cont.listadofuente
        bs_fuentes.DataSource = col_fuentes
        cargarListView()
    End Sub

    'Utilidades
    Private Sub visibilidadInformacion(ByVal visibilidad As Boolean)
        lblNombre.Visible = visibilidad
        lblAceptanTarjeta.Visible = visibilidad
        lblCant.Visible = visibilidad
        lblTelefono.Visible = visibilidad
        lblTituloCant.Visible = visibilidad
        lblTituloTelefono.Visible = visibilidad
    End Sub
    Private Sub aceptanTarjeta(ByVal aceptan As Boolean) 'Cambia de color la label a rojo o verde dependiendo de la variable aceptan_tarjeta
        With lblAceptanTarjeta
            If (aceptan) Then
                .Text = "ACEPTA TARJETA"
                .ForeColor = Color.Green
            Else
                .Text = "NO ACEPTA TARJETA"
                .ForeColor = Color.Red
            End If
        End With
    End Sub
    Private Sub lstFuentes_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles lstFuentes.ItemSelectionChanged 'Despliega la informacion de una fuente
        Dim col_productos = cont.listadoproducto
        If lstFuentes.SelectedItems.Count > 0 Then
            id_fuente = lstFuentes.SelectedItems(0).Text
            Dim la_fuente = cont.devolverFuente(id_fuente)
            lblNombre.Text = la_fuente.nombre
            aceptanTarjeta(la_fuente.aceptan_tarjeta)
            lblTelefono.Text = la_fuente.telefono
            lblCant.Text = cont.devolverCantProductosFuente(la_fuente, col_productos)
            visibilidadInformacion(True)
        Else
            visibilidadInformacion(False)
        End If


    End Sub

    Private Sub ListaFuentes_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        cargarListView()
    End Sub

    Private Sub eliminarProducto_Click(sender As Object, e As EventArgs) Handles eliminarProducto.Click
        Dim eliminar As DialogResult = MessageBox.Show("Estas seguro/a de que quieres eliminar esta fuente?", "Eliminar fuente", MessageBoxButtons.YesNo)
        If (eliminar = DialogResult.Yes) Then
            cont.BorrarFuente(id_fuente)
            cargarListView()
            visibilidadInformacion(False)
        End If
    End Sub

    Private Sub lblNombre_Click(sender As Object, e As EventArgs) Handles lblNombre.Click
        Dim una_fuente = cont.devolverFuente(id_fuente)
        Dim nuevo_nombre = InputBox("Ingrese el nuevo nombre de la fuente: ", "Nueva Fuente", una_fuente.nombre)
        una_fuente.nombre = nuevo_nombre
        If (cont.ModificarFuente(id_fuente, una_fuente)) Then
            lblNombre.Text = nuevo_nombre
        End If
        cargarListView()
    End Sub

    Private Sub lblAceptanTarjeta_Click(sender As Object, e As EventArgs) Handles lblAceptanTarjeta.Click
        Dim una_fuente = cont.devolverFuente(id_fuente)
        una_fuente.aceptan_tarjeta = Not una_fuente.aceptan_tarjeta
        If (cont.ModificarFuente(id_fuente, una_fuente)) Then
            aceptanTarjeta(una_fuente.aceptan_tarjeta)
        End If
        cargarListView()
    End Sub

    Private Sub lblTelefono_Click(sender As Object, e As EventArgs) Handles lblTelefono.Click
        Dim una_fuente = cont.devolverFuente(id_fuente)
        Dim un_integer As Integer
        Dim nuevo_telefono = InputBox("Ingrese el nuevo telefono de la fuente: ", "Nuevo Telefono", una_fuente.telefono)

        If (Integer.TryParse(nuevo_telefono, un_integer)) Then
            una_fuente.telefono = nuevo_telefono
            If (cont.ModificarFuente(id_fuente, una_fuente)) Then
                lblTelefono.Text = nuevo_telefono
            End If
        Else
            MessageBox.Show("El telefono no puede incluir letras ni simbolos.")
        End If
        cargarListView()
    End Sub
End Class