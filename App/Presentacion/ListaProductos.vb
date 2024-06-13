Public Class ListaProductos
    Dim cont As New Controladora
    Dim un_id As Integer 'ID DEL PRODUCTO USADA POR TODO EL FORMULARIO
    Dim filtros = "default"



    'Formulario 
    Private Sub ListaProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Lo que sucede al cargar el formulario
        visibilidadInformacion(False, False)
        cargarListas()
    End Sub

    Private Sub btnAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click 'Abre la ventana para agregar un producto
        Dim ap As New AgregarProducto
        ap.Show()
    End Sub

    Private Sub ListaProductos_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed 'Cuando cerramos esta ventana, muestra la ventana Principal
        Dim princi As New Principal
        princi.Visible = True
    End Sub



    'Campos o Datos
    Private Sub ListaProductos_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated 'Campos o Datos, Actualiza la lista de productos cuando se abre la ventana del programa
        cargarListView()
    End Sub
    Public Sub cargarListView() 'Limpia el listado de productos y lo vuelve a rellenar con informacion actualizada
        Me.lstProductos.Items.Clear()
        Dim col_productos As New ArrayList
        Select Case filtros
            Case "default"
                lblFiltro.Text = "Filtro: Ninguno"
                col_productos = cont.listadoproducto 'Sin filtro
            Case "que_comprar"
                lblFiltro.Text = "Filtro: Que deberiamos comprar"
                col_productos = cont.queProductosComprar 'Productos de los cuales tenemos NADA o POCO y son importantes
            Case "mejores_precios"
                lblFiltro.Text = "Filtro: Los mejores precios"
                col_productos = cont.productosAlMejorPrecio
            Case "no_tenemos"
                lblFiltro.Text = "Filtro: No hay en casa"
                col_productos = cont.queFaltaEnCasa
        End Select

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

    Private Sub cargarMenuStrips(ByVal col_categorias As ArrayList, ByVal col_fuentes As ArrayList) 'Rellena los menu strips con las listas de la controladora
        For Each cat As Categoria In col_categorias
            Me.menuCategorias.Items.Add(cat.nombre)
        Next
        For Each fuente As Fuente In col_fuentes
            Me.menuFuentes.Items.Add(fuente.nombre)
        Next
    End Sub

    Private Sub cargarListas() 'Rellena las listas que usan los combo boxes y tambien los menu strips con las listas de la controladora
        Dim col_fuentes = cont.listadofuente
        Dim col_categorias = cont.listadocategoria
        Dim col_productos = cont.listadoproducto
        Dim bs_fuentes As New BindingSource
        Dim bs_categorias As New BindingSource
        bs_fuentes.DataSource = col_fuentes
        bs_categorias.DataSource = col_categorias
        bs_categorias.RemoveAt(0)
        With cmbFuentes
            .DisplayMember = "nombre"
            .DataSource = bs_fuentes
        End With
        With cmbCategorias
            .DisplayMember = "nombre"
            .DataSource = bs_categorias
        End With
        cargarMenuStrips(col_categorias, col_fuentes)
        cargarListView()
    End Sub

    Private Sub cambiarBtnHay(ByVal hay As String, ByVal importante As Boolean) 'Cambia el color y el texto del boton encargado de la existencia del producto en la casa
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

    Private Sub cambiarBtnImportante(ByVal importante As Boolean) 'Cambia el color y texto del boton encargado de la Importancia del producto
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

    Private Sub chequearRadioButtons(ByVal cuanto_tenemos As String) 'Chequea uno de los radio buttons dependiendo de la variable cuanto_tenemos del producto
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

    Private Sub lstProductos_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles lstProductos.ItemSelectionChanged 'Despliega la informacion del producto seleccionado
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



    'ABM
    Private Sub lblNombre_Click(sender As Object, e As EventArgs) Handles lblNombre.Click 'Modifica el nombre del producto seleccionado
        Dim un_producto = cont.devolverProducto(un_id)
        Dim nombre_original = un_producto.nombre
        Dim nuevo_nombre = InputBox("Ingrese el nuevo nombre del producto: ", "Nuevo nombre", un_producto.nombre)
        un_producto.nombre = nuevo_nombre
        If (cont.ModificarNombreProducto(un_id, un_producto, nombre_original)) Then
            lblNombre.Text = nuevo_nombre
        End If
        cargarListView()
    End Sub

    Private Sub lblPrecio_Click(sender As Object, e As EventArgs) Handles lblPrecio.Click 'Modifica el precio del producto seleccionado
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

    Private Sub btnImportante_Click(sender As Object, e As EventArgs) Handles btnImportante.Click 'Modifica la importancia del producto seleccionado
        Dim un_producto = cont.devolverProducto(un_id)
        un_producto.importante = Not un_producto.importante
        cont.ModificarProducto(un_id, un_producto)
        cambiarBtnImportante(un_producto.importante)
        cambiarBtnHay(un_producto.cuanto_tenemos, un_producto.importante)
        cargarListView()
    End Sub

    Private Sub btnHay_Click(sender As Object, e As EventArgs) Handles btnHay.Click 'Modifica la variable cuanto_tenemos del producto seleccionado y la deja en BIEN o en NADA
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

    Private Sub rdSobra_Click(sender As Object, e As EventArgs) Handles rdSobra.Click 'Modifica la variable cuanto_tenemos del producto seleccionado y la deja en SOBRA
        Dim un_producto = cont.devolverProducto(un_id)
        un_producto.cuanto_tenemos = "SOBRA"
        cont.ModificarProducto(un_id, un_producto)
        cargarListView()
    End Sub

    Private Sub rdBien_Click(sender As Object, e As EventArgs) Handles rdBien.Click 'Modifica la variable cuanto_tenemos del producto seleccionado y la deja en BIEN
        Dim un_producto = cont.devolverProducto(un_id)
        un_producto.cuanto_tenemos = "BIEN"
        cont.ModificarProducto(un_id, un_producto)
        cargarListView()
    End Sub

    Private Sub rdPoco_Click(sender As Object, e As EventArgs) Handles rdPoco.Click 'Modifica la variable cuanto_tenemos del producto seleccionado y la deja en POCO
        Dim un_producto = cont.devolverProducto(un_id)
        un_producto.cuanto_tenemos = "POCO"
        cont.ModificarProducto(un_id, un_producto)
        cargarListView()
    End Sub

    Private Sub menuFuentes_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles menuFuentes.ItemClicked 'Modifica la fuente del producto seleccionado
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

    Private Sub menuCategorias_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles menuCategorias.ItemClicked 'Modifica la categoria del producto seleccionado
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

    Private Sub eliminarProducto_Click(sender As Object, e As EventArgs) Handles eliminarProducto.Click 'Elimina el producto seleccionado
        Dim eliminar As DialogResult = MessageBox.Show("Estas seguro/a de que quieres eliminar este producto?", "Eliminar producto", MessageBoxButtons.YesNo)
        If (eliminar = DialogResult.Yes) Then
            cont.BorrarProducto(un_id)
            cargarListView()
            visibilidadInformacion(False, False)
        End If
    End Sub

    Private Sub cambiarImagen_Click(sender As Object, e As EventArgs) Handles cambiarImagen.Click 'ABM, Modificar imagen del producto
        Dim el_producto = cont.devolverProducto(un_id)
        Dim lector As New OpenFileDialog()
        lector.Title = "Seleccione una imagen"
        lector.Filter = "Imagen PNG|*.png| Imagen JPG|*.jpg| Imagen JPEG|*.jpeg"
        Dim ruta_imagen = ""
        If (lector.ShowDialog <> DialogResult.Cancel) Then
            Dim ext = extraerExtension(lector.FileName)
            If (Not (System.IO.Directory.Exists("imagenes/productos/"))) Then
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



    'Utilidades
    Private Function extraerExtension(ByVal ruta_archivo As String) As String 'Extrae la extension de un archivo dada su ruta
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

    Private Sub limpiarInformacion() 'Vacia toda la informacion desplegada y desmarca cualquiera de los radio buttons
        lblNombre.Text = ""
        lblPrecio.Text = ""
        lblFuente.Text = ""
        lblCategoria.Text = ""
        rdSobra.Checked = False
        rdBien.Checked = False
        rdPoco.Checked = False
    End Sub

    Private Sub visibilidadRadioButtons(ByVal b As Boolean) 'Cambia la visibilidad de los radio buttons
        lblCuanto.Visible = b
        rdSobra.Visible = b
        rdBien.Visible = b
        rdPoco.Visible = b
    End Sub

    Private Sub visibilidadInformacion(ByVal b As Boolean, ByVal hayProducto As Boolean) 'Cambia la visibilidad de toda la informacion desplegada
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

    Private Sub btnReiniciarFiltros_Click(sender As Object, e As EventArgs) Handles btnReiniciarFiltros.Click
        filtros = "default"
        cargarListView()
    End Sub

    Private Sub btnQueComprar_Click(sender As Object, e As EventArgs) Handles btnQueComprar.Click
        filtros = "que_comprar"
        cargarListView()
    End Sub

    Private Sub txtBuscar_Click(sender As Object, e As EventArgs) Handles txtBuscar.MouseClick
        txtBuscar.Text = ""
        txtBuscar.ForeColor = SystemColors.WindowText
    End Sub

    Private Sub btnMejoresPrecios_Click(sender As Object, e As EventArgs) Handles btnMejoresPrecios.Click
        filtros = "mejores_precios"
        cargarListView()
    End Sub

    Private Sub lblNoTenemos_Click(sender As Object, e As EventArgs) Handles lblNoTenemos.Click
        filtros = "no_tenemos"
        cargarListView()
    End Sub
End Class