
Public Class AgregarProducto
    Dim cont As New Controladora
    Dim col_fuentes As New ArrayList
    Dim col_categorias As New ArrayList
    Dim col_prod As New ArrayList
    Dim cantidades = New String() {"", "NADA", "POCO", "BIEN", "BASTANTE"}

    Private Sub cargarListas()
        col_fuentes = cont.listadofuente
        col_categorias = cont.listadocategoria
        col_prod = cont.listadoproducto


        Dim bs_fuentes As New BindingSource
        Dim bs_categorias As New BindingSource


        bs_fuentes.DataSource = col_fuentes
        bs_categorias.DataSource = col_categorias

        With cmbFuentes
            .DisplayMember = "nombre"
            .DataSource = bs_fuentes
        End With

        With cmbCategorias
            .DisplayMember = "nombre"
            .DataSource = bs_categorias
        End With
    End Sub
    Private Sub nuevaCategoria(ByVal nombre As String)
        cont.AgregarCategoria(nombre)
    End Sub

    Private Sub agregarProducto(ByVal una_fuente As Fuente, ByVal una_categoria As Categoria, ByVal nombre As String, ByVal precio As String, ByVal cuanto_tenemos As String)
        cont.AgregarProducto(una_fuente, una_categoria, nombre, CDbl(precio), cuanto_tenemos)
    End Sub

    Private Sub AgregarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarListas()
        cmbCuantoTenemos.DataSource = cantidades
        cmbFuentes.SelectedItem = Nothing
        cmbCategorias.SelectedItem = Nothing
    End Sub

    Private Sub AgregarProducto_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Dispose()
    End Sub

    Private Sub chequearCampos()
        Dim d As Double
        Dim combosRellenados = cmbCategorias.Text <> "" And cmbCuantoTenemos.Text <> "" And cmbFuentes.Text <> ""
        Dim textosRellenados = txtNombre.Text <> "" And Double.TryParse(txtPrecio.Text, d)

        If (combosRellenados And textosRellenados) Then
            btnAgregar.Enabled = True
        Else
            btnAgregar.Enabled = False
        End If
    End Sub
    Private Sub cmbCuantoTenemos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCuantoTenemos.SelectedIndexChanged
        chequearCampos()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        agregarProducto(cmbFuentes.SelectedItem, cmbCategorias.SelectedItem, txtNombre.Text, txtPrecio.Text, cmbCuantoTenemos.SelectedItem)
    End Sub

    Private Sub cmbCategorias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategorias.SelectedIndexChanged
        chequearCampos()
    End Sub

    Private Sub cmbFuentes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFuentes.SelectedIndexChanged
        chequearCampos()
    End Sub

    Private Sub numPrecio_ValueChanged(sender As Object, e As EventArgs)
        chequearCampos()
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        chequearCampos()
    End Sub

    Private Sub numPrecio_KeyPress(sender As Object, e As KeyPressEventArgs)
        chequearCampos()
    End Sub

    Private Sub txtPrecio_TextChanged(sender As Object, e As EventArgs) Handles txtPrecio.TextChanged
        chequearCampos()
    End Sub
End Class