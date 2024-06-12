
Imports System.IO
Imports System.Net

Public Class AgregarProducto
    Dim cont As New Controladora
    Dim col_fuentes As New ArrayList
    Dim col_categorias As New ArrayList
    Dim col_prod As New ArrayList
    Dim cantidad = ""
    Private Sub limpiarCampos()
        pbImagen.Image = Nothing
        txtNombre.Text = ""
        cmbCategorias.SelectedItem = Nothing
        cmbFuentes.SelectedItem = Nothing
        txtPrecio.Text = ""

    End Sub
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
            .SelectedItem = Nothing
        End With

        With cmbCategorias
            .DisplayMember = "nombre"
            .DataSource = bs_categorias
            .SelectedItem = Nothing
        End With


    End Sub
    Private Sub nuevaCategoria(ByVal nombre As String)
        cont.AgregarCategoria(nombre)
    End Sub

    Private Sub agregarProducto(ByVal una_fuente As Fuente, ByVal una_categoria As Categoria, ByVal nombre As String, ByVal precio As String, ByVal cuanto_tenemos As String, ByVal importante As Boolean, ByVal nombre_imagen As String)
        cont.AgregarProducto(una_fuente, una_categoria, nombre, CDbl(precio), cuanto_tenemos, chkImportante.Checked, nombre_imagen)
        Me.Dispose()
    End Sub

    Private Sub AgregarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarListas()
        cmbFuentes.SelectedItem = Nothing
        cmbCategorias.SelectedItem = Nothing
    End Sub

    Private Sub chequearCampos()
        Dim d As Double
        Dim combosRellenados = cmbCategorias.Text <> "" And cmbFuentes.Text <> ""
        Dim textosRellenados = txtNombre.Text <> "" And Double.TryParse(txtPrecio.Text, d) And cantidad <> "" And chequearRoundButtons()

        If (combosRellenados And textosRellenados) Then
            btnImagen.Enabled = True
            btnAgregar.Enabled = True
        Else
            btnAgregar.Enabled = False
            btnImagen.Enabled = False
        End If
    End Sub

    Private Function chequearRoundButtons() As Boolean
        Return rbNada.Checked Or rbPoco.Checked Or rbBien.Checked Or rbSobra.Checked
    End Function
    Private Sub cmbCuantoTenemos_SelectedIndexChanged(sender As Object, e As EventArgs)
        chequearCampos()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim ruta_imagen = pbImagen.ImageLocation
        Dim la_fuente = cmbFuentes.SelectedItem
        Dim la_categoria = cmbCategorias.SelectedItem
        agregarProducto(la_fuente, la_categoria, txtNombre.Text, txtPrecio.Text, cantidad, chkImportante.Checked, ruta_imagen)
        limpiarCampos()
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

    Private Sub cmbCategorias_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbCategorias.SelectionChangeCommitted
        If (cmbCategorias.SelectedIndex = 0) Then
            cmbCategorias.SelectedItem = Nothing
            Dim existe = False
            Dim nombre = ""
            nombre = InputBox("Nombre de la nueva categoria:", "Nueva Categoria")
            For Each c As Categoria In col_categorias
                If (c.nombre = nombre) Then
                    existe = True
                End If
            Next
            If (existe = True) Then
                MessageBox.Show("Ya existe una categoria con el mismo nombre.")
            ElseIf (nombre = "") Then
                MessageBox.Show("No puede ingresar un nombre vacio")
            Else
                cont.AgregarCategoria(nombre)
                cargarListas()
            End If
        End If
    End Sub

    Private Sub rbNada_CheckedChanged(sender As Object, e As EventArgs) Handles rbNada.CheckedChanged
        chequearCampos()
        cantidad = "NADA"
    End Sub

    Private Sub rbPoco_CheckedChanged(sender As Object, e As EventArgs) Handles rbPoco.CheckedChanged
        chequearCampos()
        cantidad = "POCO"
    End Sub

    Private Sub rbBien_CheckedChanged(sender As Object, e As EventArgs) Handles rbBien.CheckedChanged
        chequearCampos()
        cantidad = "BIEN"
    End Sub

    Private Sub rbSobra_CheckedChanged(sender As Object, e As EventArgs) Handles rbSobra.CheckedChanged
        chequearCampos()
        cantidad = "SOBRA"
    End Sub

    Private Function extraerExtension(ByVal ruta_archivo As String) As String
        Dim extension = ""
        Dim c_anterior As Char
        For Each c As Char In ruta_archivo
            If (c_anterior = ".") Then
                extension = ""
            End If
            extension = extension & "" & c
            c_anterior = c
        Next
        Return extension
    End Function

    Private Sub btnImagen_Click(sender As Object, e As EventArgs) Handles btnImagen.Click
        Dim lector As New OpenFileDialog()
        lector.Title = "Seleccione una imagen"
        lector.Filter = "Imagen PNG|*.png| Imagen JPG|*.jpg| Imagen JPEG|*.jpeg"
        Dim ruta_imagen = ""
        If (lector.ShowDialog <> DialogResult.Cancel) Then
            Dim ext = extraerExtension(lector.FileName)
            If (System.IO.Directory.Exists("imagenes/productos/")) Then
                System.IO.Directory.CreateDirectory("imagenes/productos/")
            End If
            ruta_imagen = "imagenes/productos/" & txtNombre.Text & "." & ext

            FileSystem.FileCopy(lector.FileName, ruta_imagen)
            pbImagen.SizeMode = PictureBoxSizeMode.Zoom
            pbImagen.ImageLocation = ruta_imagen
        End If

    End Sub

    Public Function productoCreado() As Producto

    End Function
End Class