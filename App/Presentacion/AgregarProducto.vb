﻿
Imports System.IO
Imports System.Net

Public Class AgregarProducto
    Dim cont As New Controladora
    Dim col_fuentes As New ArrayList
    Dim col_categorias As New ArrayList
    Dim col_prod As New ArrayList
    Dim cantidad = ""
    Dim id_fuente = 0
    Dim id_categoria = 0



    'Campos o Datos:'

    Private Sub limpiarCampos() 'Campos o Datos
        pbImagen.Image = Nothing
        txtNombre.Text = ""
        'cmbCategorias.SelectedItem = Nothing // naty quiere que no se cambien
        'cmbFuentes.SelectedItem = Nothing //
        txtPrecio.Text = ""

        rbPoco.Checked = False
        rbNada.Checked = False
        rbBien.Checked = False

    End Sub
    Private Sub cargarListas() 'Campos o Datos
        col_fuentes = cont.listadofuente("id")
        col_categorias = cont.listadocategoria
        col_prod = cont.listadoproducto("p1.nombre", False, "", 0, 0)

        Dim bs_fuentes As New BindingSource
        Dim bs_categorias As New BindingSource


        bs_fuentes.DataSource = col_fuentes
        bs_categorias.DataSource = col_categorias
        bs_fuentes.RemoveAt(0)
        bs_categorias.RemoveAt(1)

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

    Private Sub AgregarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Campos o Datos
        cargarListas()
        cmbFuentes.SelectedItem = Nothing
        cmbCategorias.SelectedItem = Nothing
    End Sub

    Private Sub chequearComboBoxes()
        If (cmbFuentes.SelectedIndex = 0) Then
            id_fuente = 0
        ElseIf Not (cmbFuentes.SelectedItem Is Nothing) Then
            Dim una_fuente As New Fuente
            una_fuente = cmbFuentes.SelectedItem
            id_fuente = una_fuente.id
        End If
        If (cmbCategorias.SelectedIndex = 0) Then
            id_categoria = 0
        ElseIf Not (cmbCategorias.SelectedItem Is Nothing) Then
            Dim una_categoria As New Categoria
            una_categoria = cmbCategorias.SelectedItem
            id_categoria = una_categoria.id
        End If

        cargarListView()
    End Sub

    Private Function chequearCampos() As Boolean 'Campos o Datos
        Dim d As Double
        Dim todoBien = False
        Dim combosRellenados = cmbCategorias.Text <> "" And cmbFuentes.Text <> ""
        Dim textosRellenados = txtNombre.Text <> "" And Double.TryParse(txtPrecio.Text, d) And cantidad <> "" And chequearRoundButtons()
        If (combosRellenados And textosRellenados) Then
            lblError.Visible = False
            todoBien = True
            btnImagen.Enabled = True
            btnAgregar.Enabled = True
        Else
            btnAgregar.Enabled = False
            btnImagen.Enabled = False
        End If

        lblInfo.Visible = False
        Return todoBien
    End Function

    Private Function chequearRoundButtons() As Boolean 'Campos o Datos
        Return rbNada.Checked Or rbPoco.Checked Or rbBien.Checked Or rbSobra.Checked
    End Function
    Private Sub cmbCuantoTenemos_SelectedIndexChanged(sender As Object, e As EventArgs) 'Campos o Datos
        chequearCampos()
    End Sub

    Private Sub rbNada_CheckedChanged(sender As Object, e As EventArgs) Handles rbNada.CheckedChanged 'Campos o Datos
        chequearCampos()
        cantidad = "NADA"
    End Sub

    Private Sub rbPoco_CheckedChanged(sender As Object, e As EventArgs) Handles rbPoco.CheckedChanged 'Campos o Datos
        chequearCampos()
        cantidad = "POCO"
    End Sub

    Private Sub rbBien_CheckedChanged(sender As Object, e As EventArgs) Handles rbBien.CheckedChanged 'Campos o Datos
        chequearCampos()
        cantidad = "BIEN"
    End Sub

    Private Sub rbSobra_CheckedChanged(sender As Object, e As EventArgs) Handles rbSobra.CheckedChanged 'Campos o Datos
        chequearCampos()
        cantidad = "SOBRA"
    End Sub



    'ABM:'

    Private Sub nuevaCategoria(ByVal nombre As String) 'Agregar categoria
        cont.AgregarCategoria(nombre)
    End Sub

    Private Sub agregarProducto(ByVal una_fuente As Fuente, ByVal una_categoria As Categoria, ByVal nombre As String, ByVal precio As String, ByVal cuanto_tenemos As String, ByVal importante As Boolean, ByVal nombre_imagen As String) 'Agregar producto segundo paso
        cont.AgregarProducto(una_fuente, una_categoria, nombre, CDbl(precio), cuanto_tenemos, chkImportante.Checked, nombre_imagen)
    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click 'Agregar producto primer paso
        Dim ruta_imagen = pbImagen.ImageLocation
        Dim la_fuente = cmbFuentes.SelectedItem
        Dim la_categoria = cmbCategorias.SelectedItem
        If (chequearCampos()) Then
            agregarProducto(la_fuente, la_categoria, txtNombre.Text, txtPrecio.Text, cantidad, chkImportante.Checked, ruta_imagen)
            limpiarCampos()
            lblInfo.Visible = True
        Else
            lblError.Visible = True
        End If
    End Sub



    Private Sub cmbCategorias_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmbCategorias.SelectionChangeCommitted 'Crear nueva categoria
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

    Private Sub btnImagen_Click(sender As Object, e As EventArgs) Handles btnImagen.Click 'Seleccionar imagen del producto
        Dim lector As New OpenFileDialog()
        lector.Title = "Seleccione una imagen"
        lector.Filter = "Imagen PNG|*.png| Imagen JPG|*.jpg| Imagen JPEG|*.jpeg"
        Dim ruta_imagen = ""
        If (lector.ShowDialog <> DialogResult.Cancel) Then
            Dim ext = extraerExtension(lector.FileName)
            If (Not (System.IO.Directory.Exists("/imagenes/productos/"))) Then
                System.IO.Directory.CreateDirectory("/imagenes/productos/")
            End If
            ruta_imagen = "/imagenes/productos/" & txtNombre.Text & "." & ext

            FileSystem.FileCopy(lector.FileName, ruta_imagen)
            pbImagen.SizeMode = PictureBoxSizeMode.Zoom
            pbImagen.ImageLocation = ruta_imagen
        End If

    End Sub



    'UPDATERS:'

    Private Sub cmbCategorias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategorias.SelectedIndexChanged 'UPDATERS
        chequearCampos()
    End Sub

    Private Sub cmbFuentes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFuentes.SelectedIndexChanged 'UPDATERS
        chequearCampos()
    End Sub

    Private Sub numPrecio_ValueChanged(sender As Object, e As EventArgs) 'UPDATERS
        chequearCampos()
    End Sub

    Private Sub cargarListView()
        Me.lstProductos.Items.Clear()
        Dim col_productos As New ArrayList
        Dim buscando As Boolean = False
        If (txtNombre.Text <> "") Then
            buscando = True
        End If
        col_productos = cont.listadoproducto("p1.nombre ASC", buscando, txtNombre.Text, id_fuente, id_categoria)

        ' CARGAR LA FUTURA LIST VIEW
        Dim lista As New ListViewItem
        For Each p As Producto In col_productos
            lista = New ListViewItem(p.nombre)
            Me.lstProductos.Items.Add(lista)
        Next
    End Sub
    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged 'UPDATERS
        cargarListView()
        chequearCampos()
    End Sub

    Private Sub numPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) 'UPDATERS
        chequearCampos()
    End Sub

    Private Sub txtPrecio_TextChanged(sender As Object, e As EventArgs) Handles txtPrecio.TextChanged 'UPDATERS
        chequearCampos()
    End Sub



    'Utilidades:'

    Private Function extraerExtension(ByVal ruta_archivo As String) As String 'Utilidades
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

    Private Sub rbNada_MouseClick(sender As Object, e As MouseEventArgs) Handles rbNada.MouseClick
        chequearCampos()
    End Sub

    Private Sub rbPoco_MouseClick(sender As Object, e As MouseEventArgs) Handles rbPoco.MouseClick
        chequearCampos()
    End Sub

    Private Sub rbBien_MouseClick(sender As Object, e As MouseEventArgs) Handles rbBien.MouseClick
        chequearCampos()
    End Sub

    Private Sub rbSobra_MouseClick(sender As Object, e As MouseEventArgs) Handles rbSobra.MouseClick
        chequearCampos()
    End Sub

    Private Sub AgregarProducto_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        If (Not chequearCampos()) Then
            lblError.Visible = True
        End If
    End Sub
End Class