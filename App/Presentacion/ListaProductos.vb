Public Class ListaProductos
    Dim cont As New Controladora
    Dim col_productos As New ArrayList
    Dim col_fuentes As New ArrayList
    Dim col_categorias As New ArrayList
    Dim un_id As Integer 'ID DEL PRODUCTO USADA POR TODO EL FORMULARIO


    Private Sub btnAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click
        Dim ap As New AgregarProducto
        ap.Show()
    End Sub

    Public Sub cargarListView()
        Me.lstProductos.Items.Clear()
        col_productos = cont.listadoproducto
        Dim lista As New ListViewItem
        For Each p As Producto In col_productos
            Dim strImportante As String
            lista = New ListViewItem(p.id)
            lista.SubItems.Add(p.nombre)
            lista.SubItems.Add(p.fuente.nombre)
            lista.SubItems.Add(p.categoria.nombre)
            lista.SubItems.Add(p.precio)
            If (p.importante = True) Then
                strImportante = "Importante"
            Else
                strImportante = "No importante"
            End If
            lista.SubItems.Add(strImportante)
            lista.SubItems.Add(p.cuanto_tenemos)
            Me.lstProductos.Items.Add(lista)
        Next
    End Sub

    Private Sub cargarMenuStrips(ByVal col_categorias As ArrayList, ByVal col_fuentes As ArrayList)
        For Each cat As Categoria In col_categorias
            Me.menuCategorias.Items.Add(cat.nombre)
        Next
        For Each fuente As Fuente In col_fuentes
            Me.menuFuentes.Items.Add(fuente.nombre)
        Next
    End Sub
    Private Sub cargarListas()

        col_fuentes = cont.listadofuente
        col_categorias = cont.listadocategoria
        col_productos = cont.listadoproducto

        Dim bs_fuentes As New BindingSource
        Dim bs_categorias As New BindingSource

        bs_fuentes.DataSource = col_fuentes
        bs_categorias.DataSource = col_categorias
        cmbFuentes.SelectedItem = Nothing
        cmbCategorias.SelectedItem = Nothing
        bs_categorias.RemoveAt(0)
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

        cargarMenuStrips(col_categorias, col_fuentes)
        cargarListView()
    End Sub
    Private Sub limpiarInformacion()
        lblNombre.Text = ""
        lblPrecio.Text = ""
        lblFuente.Text = ""
        lblCategoria.Text = ""
        rdSobra.Checked = False
        rdBien.Checked = False
        rdPoco.Checked = False


    End Sub

    Private Sub visibilidadRadioButtons(ByVal b As Boolean)
        lblCuanto.Visible = b
        rdSobra.Visible = b
        rdBien.Visible = b
        rdPoco.Visible = b
    End Sub
    Private Sub visibilidadInformacion(ByVal b As Boolean, ByVal hayProducto As Boolean)
        pbImagen.Visible = b
        lblNombre.Visible = b
        lblPrecio.Visible = b
        lblCuanto.Visible = b
        lblFuente.Visible = b
        lblCategoria.Visible = b
        visibilidadRadioButtons(hayProducto)
        btnImportante.Visible = b
        btnHay.Visible = b
    End Sub
    Private Sub ListaProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        visibilidadInformacion(False, False)
        cargarListas()
        cmbFuentes.SelectedItem = Nothing
        cmbCategorias.SelectedItem = Nothing
    End Sub

    Private Sub btnRefrescar_Click(sender As Object, e As EventArgs) Handles btnRefrescar.Click
        cargarListView()
    End Sub

    Private Sub cambiarBtnHay(ByVal hay As String, ByVal importante As Boolean)
        If (hay = "NADA") Then
            If (importante) Then
                btnHay.BackColor = Color.Red
            Else
                btnHay.BackColor = SystemColors.Control
            End If
            btnHay.Text = "No tenemos esto en casa"
        Else
            btnHay.BackColor = SystemColors.Control
            btnHay.Text = "Tenemos esto en casa"
        End If
    End Sub

    Private Sub cambiarBtnImportante(ByVal importante As Boolean)
        With btnImportante
            If (importante) Then
                .BackColor = Color.Red
                .Text = "IMPORTANTE"
            Else
                .BackColor = SystemColors.Control
                .Text = "No importante"
            End If
        End With

    End Sub
    Private Sub chequearRadioButtons(ByVal cuanto_tenemos As String)
        rdSobra.Checked = False
        rdBien.Checked = False
        rdPoco.Checked = False
        Select Case cuanto_tenemos
            Case "NADA"

            Case "POCO"
                rdPoco.Checked = True
            Case "BIEN"
                rdBien.Checked = True
            Case "SOBRA"
                rdBien.Checked = True
        End Select
    End Sub
    Private Sub lstProductos_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles lstProductos.ItemSelectionChanged


        If lstProductos.SelectedItems.Count > 0 Then

            un_id = lstProductos.SelectedItems(0).Text
            Dim un_producto = cont.devolverProducto(un_id)
            lblNombre.Text = un_producto.nombre
            lblPrecio.Text = "$ " & un_producto.precio
            lblFuente.Text = "Se compra en: " & un_producto.fuente.nombre
            lblCategoria.Text = "Categoria: " & un_producto.categoria.nombre


            chequearRadioButtons(un_producto.cuanto_tenemos)

            cambiarBtnHay(un_producto.cuanto_tenemos, un_producto.importante)
            cambiarBtnImportante(un_producto.importante)
            Dim ruta = un_producto.nombre_imagen
            If (ruta <> "") Then
                pbImagen.ImageLocation = ruta
            Else
                pbImagen.Image = Nothing
            End If
            Dim hayProducto = True
            If (un_producto.cuanto_tenemos = "NADA") Then
                hayProducto = False
            End If
            visibilidadInformacion(True, hayProducto)
        Else
            visibilidadInformacion(False, False)
        End If
    End Sub

    Private Sub lblNombre_Click(sender As Object, e As EventArgs) Handles lblNombre.Click

        Dim un_producto = cont.devolverProducto(un_id)


        Dim nuevo_nombre = InputBox("Ingrese el nuevo nombre del producto: ", "Nuevo nombre", un_producto.nombre)
        un_producto.nombre = nuevo_nombre
        If (cont.ModificarProducto(un_id, un_producto)) Then
            lblNombre.Text = nuevo_nombre
        End If
        cargarListView()
    End Sub

    Private Sub lblPrecio_Click(sender As Object, e As EventArgs) Handles lblPrecio.Click
        Dim un_producto = cont.devolverProducto(un_id)
        Dim d As Double

        Dim nuevo_precio As Double = InputBox("Ingrese el nuevo precio del producto: ", "Nuevo precio", un_producto.precio)
        If (Double.TryParse(nuevo_precio, d)) Then
            un_producto.precio = nuevo_precio
            If (cont.ModificarProducto(un_id, un_producto)) Then
                lblPrecio.Text = "$ " & nuevo_precio
            End If
        Else
            MessageBox.Show("El precio no puede contener ni simbolos ni letras.")
        End If
        cargarListView()
    End Sub
    Private Sub btnImportante_Click(sender As Object, e As EventArgs) Handles btnImportante.Click
        Dim un_producto = cont.devolverProducto(un_id)
        un_producto.importante = Not un_producto.importante
        cont.ModificarProducto(un_id, un_producto)
        cambiarBtnImportante(un_producto.importante)
        cambiarBtnHay(un_producto.cuanto_tenemos, un_producto.importante)
        cargarListView()
    End Sub

    Private Sub btnHay_Click(sender As Object, e As EventArgs) Handles btnHay.Click
        Dim un_producto = cont.devolverProducto(un_id)
        If (un_producto.cuanto_tenemos = "NADA") Then
            un_producto.cuanto_tenemos = "BIEN"
            chequearRadioButtons(un_producto.cuanto_tenemos)
            visibilidadRadioButtons(True)
        Else
            un_producto.cuanto_tenemos = "NADA"
            visibilidadRadioButtons(False)
        End If
        cont.ModificarProducto(un_id, un_producto)
        cambiarBtnHay(un_producto.cuanto_tenemos, un_producto.importante)
        cargarListView()
    End Sub

    Private Sub rdSobra_Click(sender As Object, e As EventArgs) Handles rdSobra.Click
        Dim un_producto = cont.devolverProducto(un_id)
        un_producto.cuanto_tenemos = "SOBRA"
        cont.ModificarProducto(un_id, un_producto)
        cargarListView()
    End Sub

    Private Sub rdBien_Click(sender As Object, e As EventArgs) Handles rdBien.Click
        Dim un_producto = cont.devolverProducto(un_id)
        un_producto.cuanto_tenemos = "BIEN"
        cont.ModificarProducto(un_id, un_producto)
        cargarListView()
    End Sub

    Private Sub rdPoco_Click(sender As Object, e As EventArgs) Handles rdPoco.Click
        Dim un_producto = cont.devolverProducto(un_id)
        un_producto.cuanto_tenemos = "POCO"
        cont.ModificarProducto(un_id, un_producto)
        cargarListView()
    End Sub
    Private Sub menuFuentes_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles menuFuentes.ItemClicked
        Dim el_producto = cont.devolverProducto(un_id)
        Dim col_fuentes = cont.listadofuente
        Dim nombre_fuente = e.ClickedItem.ToString()
        Dim la_fuente As New Fuente()
        For Each una_fuente As Fuente In col_fuentes
            If (una_fuente.nombre = nombre_fuente) Then
                la_fuente = una_fuente
            End If
        Next
        el_producto.fuente = la_fuente
        cont.ModificarProducto(un_id, el_producto)
        Me.lblFuente.Text = "Comprado en " & la_fuente.nombre
        cargarListView()
    End Sub

    Private Sub menuCategorias_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles menuCategorias.ItemClicked
        Dim el_producto = cont.devolverProducto(un_id)
        Dim col_categorias = cont.listadocategoria
        Dim nombre_categoria = e.ClickedItem.ToString()
        Dim la_categoria As New Categoria()
        For Each una_categoria As Categoria In col_categorias
            If (una_categoria.nombre = nombre_categoria) Then
                la_categoria = una_categoria
            End If
        Next
        el_producto.categoria = la_categoria
        cont.ModificarProducto(un_id, el_producto)
        Me.lblCategoria.Text = "Categoria: " & la_categoria.nombre
        cargarListView()
    End Sub

    Private Sub ListaProductos_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dim princi As New Principal
        princi.Visible = True
    End Sub

    Private Sub eliminarProducto_Click(sender As Object, e As EventArgs) Handles eliminarProducto.Click
        Dim eliminar As DialogResult = MessageBox.Show("Estas seguro?", "Eliminar producto", MessageBoxButtons.YesNo)
        If (eliminar = DialogResult.Yes) Then
            cont.BorrarProducto(un_id)
            cargarListView()
            visibilidadInformacion(False, False)
        End If
    End Sub



    Private Sub ListaProductos_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        cargarListView()
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

    Private Sub cambiarImagen_Click(sender As Object, e As EventArgs) Handles cambiarImagen.Click
        Dim el_producto = cont.devolverProducto(un_id)
        Dim lector As New OpenFileDialog()
        lector.Title = "Seleccione una imagen"
        lector.Filter = "Imagen PNG|*.png| Imagen JPG|*.jpg| Imagen JPEG|*.jpeg"
        Dim ruta_imagen = ""
        If (lector.ShowDialog <> DialogResult.Cancel) Then
            Dim ext = extraerExtension(lector.FileName)
            If (System.IO.Directory.Exists("imagenes/productos/")) Then
                System.IO.Directory.CreateDirectory("imagenes/productos/")
            End If

            ruta_imagen = "imagenes/productos/" & el_producto.nombre & "." & ext
            If (System.IO.File.Exists(ruta_imagen)) Then
                System.IO.File.Delete(ruta_imagen)
            End If
            FileSystem.FileCopy(lector.FileName, ruta_imagen)
                pbImagen.SizeMode = PictureBoxSizeMode.Zoom
            pbImagen.ImageLocation = ruta_imagen
            el_producto.nombre_imagen = ruta_imagen
            cont.ModificarProducto(un_id, el_producto)
            cargarListView()
        End If
    End Sub
End Class