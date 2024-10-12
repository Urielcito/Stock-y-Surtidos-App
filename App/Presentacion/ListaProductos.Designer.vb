<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListaProductos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.cmbFuentes = New System.Windows.Forms.ComboBox()
        Me.cmbCategorias = New System.Windows.Forms.ComboBox()
        Me.lblFuentes = New System.Windows.Forms.Label()
        Me.lblCategorias = New System.Windows.Forms.Label()
        Me.btnAgregarProducto = New System.Windows.Forms.Button()
        Me.lstProductos = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.menuProducto = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.msAgregar = New System.Windows.Forms.ToolStripMenuItem()
        Me.msEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.eliminarProducto = New System.Windows.Forms.ToolStripMenuItem()
        Me.pbImagen = New System.Windows.Forms.PictureBox()
        Me.menuImagen = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cambiarImagen = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnImportante = New System.Windows.Forms.Button()
        Me.btnHay = New System.Windows.Forms.Button()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.rdSobra = New System.Windows.Forms.RadioButton()
        Me.rdBien = New System.Windows.Forms.RadioButton()
        Me.rdPoco = New System.Windows.Forms.RadioButton()
        Me.lblCuanto = New System.Windows.Forms.Label()
        Me.lblFuente = New System.Windows.Forms.Label()
        Me.menuFuentes = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.menuCategorias = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tooltip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnQueComprar = New System.Windows.Forms.Button()
        Me.btnReiniciarFiltros = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.lblFiltro = New System.Windows.Forms.Label()
        Me.btnMejoresPrecios = New System.Windows.Forms.Button()
        Me.lblNoTenemos = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstCompras = New System.Windows.Forms.ListView()
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.menuListaCompra = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.lcEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnLimpiarListaCompra = New System.Windows.Forms.Button()
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblPrecioTotal = New System.Windows.Forms.Label()
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnGuardarListaCompra = New System.Windows.Forms.Button()
        Me.menuProducto.SuspendLayout()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuImagen.SuspendLayout()
        Me.menuListaCompra.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbFuentes
        '
        Me.cmbFuentes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFuentes.FormattingEnabled = True
        Me.cmbFuentes.Location = New System.Drawing.Point(12, 167)
        Me.cmbFuentes.Name = "cmbFuentes"
        Me.cmbFuentes.Size = New System.Drawing.Size(201, 32)
        Me.cmbFuentes.TabIndex = 0
        '
        'cmbCategorias
        '
        Me.cmbCategorias.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCategorias.FormattingEnabled = True
        Me.cmbCategorias.Location = New System.Drawing.Point(12, 251)
        Me.cmbCategorias.Name = "cmbCategorias"
        Me.cmbCategorias.Size = New System.Drawing.Size(201, 32)
        Me.cmbCategorias.TabIndex = 1
        '
        'lblFuentes
        '
        Me.lblFuentes.AutoSize = True
        Me.lblFuentes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFuentes.Location = New System.Drawing.Point(12, 140)
        Me.lblFuentes.Name = "lblFuentes"
        Me.lblFuentes.Size = New System.Drawing.Size(70, 24)
        Me.lblFuentes.TabIndex = 2
        Me.lblFuentes.Text = "Fuente"
        '
        'lblCategorias
        '
        Me.lblCategorias.AutoSize = True
        Me.lblCategorias.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategorias.Location = New System.Drawing.Point(12, 224)
        Me.lblCategorias.Name = "lblCategorias"
        Me.lblCategorias.Size = New System.Drawing.Size(90, 24)
        Me.lblCategorias.TabIndex = 3
        Me.lblCategorias.Text = "Categoria"
        '
        'btnAgregarProducto
        '
        Me.btnAgregarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarProducto.Location = New System.Drawing.Point(12, 12)
        Me.btnAgregarProducto.Name = "btnAgregarProducto"
        Me.btnAgregarProducto.Size = New System.Drawing.Size(127, 113)
        Me.btnAgregarProducto.TabIndex = 4
        Me.btnAgregarProducto.Text = "+"
        Me.btnAgregarProducto.UseVisualStyleBackColor = True
        '
        'lstProductos
        '
        Me.lstProductos.Alignment = System.Windows.Forms.ListViewAlignment.Left
        Me.lstProductos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lstProductos.ContextMenuStrip = Me.menuProducto
        Me.lstProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstProductos.FullRowSelect = True
        Me.lstProductos.GridLines = True
        Me.lstProductos.HideSelection = False
        Me.lstProductos.Location = New System.Drawing.Point(231, 92)
        Me.lstProductos.MultiSelect = False
        Me.lstProductos.Name = "lstProductos"
        Me.lstProductos.Size = New System.Drawing.Size(940, 441)
        Me.lstProductos.TabIndex = 5
        Me.lstProductos.UseCompatibleStateImageBehavior = False
        Me.lstProductos.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nombre"
        Me.ColumnHeader2.Width = 265
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Fuente"
        Me.ColumnHeader3.Width = 192
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Categoria"
        Me.ColumnHeader4.Width = 186
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Precio"
        Me.ColumnHeader5.Width = 57
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Importancia"
        Me.ColumnHeader6.Width = 139
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Cuanto hay"
        Me.ColumnHeader7.Width = 95
        '
        'menuProducto
        '
        Me.menuProducto.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msAgregar, Me.msEliminar, Me.eliminarProducto})
        Me.menuProducto.Name = "menuProducto"
        Me.menuProducto.Size = New System.Drawing.Size(235, 70)
        Me.menuProducto.Text = "Eliminar Producto"
        '
        'msAgregar
        '
        Me.msAgregar.Name = "msAgregar"
        Me.msAgregar.Size = New System.Drawing.Size(234, 22)
        Me.msAgregar.Text = "Agregar a la lista de compras"
        '
        'msEliminar
        '
        Me.msEliminar.Name = "msEliminar"
        Me.msEliminar.Size = New System.Drawing.Size(234, 22)
        Me.msEliminar.Text = "Eliminar de la lista de compras"
        '
        'eliminarProducto
        '
        Me.eliminarProducto.Name = "eliminarProducto"
        Me.eliminarProducto.Size = New System.Drawing.Size(234, 22)
        Me.eliminarProducto.Text = "Eliminar"
        '
        'pbImagen
        '
        Me.pbImagen.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pbImagen.ContextMenuStrip = Me.menuImagen
        Me.pbImagen.Location = New System.Drawing.Point(1181, 55)
        Me.pbImagen.Name = "pbImagen"
        Me.pbImagen.Size = New System.Drawing.Size(392, 241)
        Me.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbImagen.TabIndex = 7
        Me.pbImagen.TabStop = False
        '
        'menuImagen
        '
        Me.menuImagen.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cambiarImagen})
        Me.menuImagen.Name = "menuImagen"
        Me.menuImagen.Size = New System.Drawing.Size(172, 26)
        '
        'cambiarImagen
        '
        Me.cambiarImagen.Name = "cambiarImagen"
        Me.cambiarImagen.Size = New System.Drawing.Size(171, 22)
        Me.cambiarImagen.Text = "Cambiar imagen..."
        '
        'btnImportante
        '
        Me.btnImportante.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImportante.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportante.Location = New System.Drawing.Point(1180, 371)
        Me.btnImportante.Name = "btnImportante"
        Me.btnImportante.Size = New System.Drawing.Size(392, 62)
        Me.btnImportante.TabIndex = 8
        Me.tooltip1.SetToolTip(Me.btnImportante, "Click para cambiar importancia")
        Me.btnImportante.UseVisualStyleBackColor = True
        '
        'btnHay
        '
        Me.btnHay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHay.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHay.Location = New System.Drawing.Point(1181, 471)
        Me.btnHay.Name = "btnHay"
        Me.btnHay.Size = New System.Drawing.Size(392, 62)
        Me.btnHay.TabIndex = 9
        Me.tooltip1.SetToolTip(Me.btnHay, "Click para marcar si hay o no del producto en casa")
        Me.btnHay.UseVisualStyleBackColor = True
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(1182, 316)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(72, 24)
        Me.lblNombre.TabIndex = 10
        Me.lblNombre.Text = "Label1"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio.Location = New System.Drawing.Point(1454, 303)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(119, 37)
        Me.lblPrecio.TabIndex = 11
        Me.lblPrecio.Text = "Label2"
        '
        'rdSobra
        '
        Me.rdSobra.AutoSize = True
        Me.rdSobra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdSobra.Location = New System.Drawing.Point(1304, 576)
        Me.rdSobra.Name = "rdSobra"
        Me.rdSobra.Size = New System.Drawing.Size(89, 24)
        Me.rdSobra.TabIndex = 12
        Me.rdSobra.TabStop = True
        Me.rdSobra.Text = "SOBRA"
        Me.rdSobra.UseVisualStyleBackColor = True
        '
        'rdBien
        '
        Me.rdBien.AutoSize = True
        Me.rdBien.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdBien.Location = New System.Drawing.Point(1304, 606)
        Me.rdBien.Name = "rdBien"
        Me.rdBien.Size = New System.Drawing.Size(69, 24)
        Me.rdBien.TabIndex = 13
        Me.rdBien.TabStop = True
        Me.rdBien.Text = "BIEN"
        Me.rdBien.UseVisualStyleBackColor = True
        '
        'rdPoco
        '
        Me.rdPoco.AutoSize = True
        Me.rdPoco.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdPoco.Location = New System.Drawing.Point(1304, 634)
        Me.rdPoco.Name = "rdPoco"
        Me.rdPoco.Size = New System.Drawing.Size(76, 24)
        Me.rdPoco.TabIndex = 14
        Me.rdPoco.TabStop = True
        Me.rdPoco.Text = "POCO"
        Me.rdPoco.UseVisualStyleBackColor = True
        '
        'lblCuanto
        '
        Me.lblCuanto.AutoSize = True
        Me.lblCuanto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuanto.Location = New System.Drawing.Point(1177, 575)
        Me.lblCuanto.Name = "lblCuanto"
        Me.lblCuanto.Size = New System.Drawing.Size(121, 24)
        Me.lblCuanto.TabIndex = 15
        Me.lblCuanto.Text = "Cuanto hay:"
        '
        'lblFuente
        '
        Me.lblFuente.AutoSize = True
        Me.lblFuente.ContextMenuStrip = Me.menuFuentes
        Me.lblFuente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblFuente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFuente.Location = New System.Drawing.Point(1177, 728)
        Me.lblFuente.Name = "lblFuente"
        Me.lblFuente.Size = New System.Drawing.Size(137, 24)
        Me.lblFuente.TabIndex = 16
        Me.lblFuente.Text = "Comprado en"
        Me.tooltip1.SetToolTip(Me.lblFuente, "Click derecho para cambiar fuente")
        Me.lblFuente.UseMnemonic = False
        '
        'menuFuentes
        '
        Me.menuFuentes.AllowMerge = False
        Me.menuFuentes.Name = "menuFuentes"
        Me.menuFuentes.Size = New System.Drawing.Size(61, 4)
        Me.menuFuentes.Text = "Editar Fuente..."
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.ContextMenuStrip = Me.menuCategorias
        Me.lblCategoria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoria.Location = New System.Drawing.Point(1177, 673)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(99, 24)
        Me.lblCategoria.TabIndex = 17
        Me.lblCategoria.Text = "Categoria"
        Me.tooltip1.SetToolTip(Me.lblCategoria, "Click derecho para cambiar categoria")
        Me.lblCategoria.UseMnemonic = False
        '
        'menuCategorias
        '
        Me.menuCategorias.Name = "ContextMenuStrip1"
        Me.menuCategorias.Size = New System.Drawing.Size(61, 4)
        Me.menuCategorias.Text = "Editar Categoria..."
        '
        'tooltip1
        '
        Me.tooltip1.AutoPopDelay = 5000
        Me.tooltip1.InitialDelay = 250
        Me.tooltip1.ReshowDelay = 100
        '
        'btnQueComprar
        '
        Me.btnQueComprar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQueComprar.Location = New System.Drawing.Point(16, 302)
        Me.btnQueComprar.Name = "btnQueComprar"
        Me.btnQueComprar.Size = New System.Drawing.Size(197, 66)
        Me.btnQueComprar.TabIndex = 18
        Me.btnQueComprar.Text = "Que deberiamos comprar?"
        Me.btnQueComprar.UseVisualStyleBackColor = True
        '
        'btnReiniciarFiltros
        '
        Me.btnReiniciarFiltros.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReiniciarFiltros.Location = New System.Drawing.Point(231, 12)
        Me.btnReiniciarFiltros.Name = "btnReiniciarFiltros"
        Me.btnReiniciarFiltros.Size = New System.Drawing.Size(197, 37)
        Me.btnReiniciarFiltros.TabIndex = 19
        Me.btnReiniciarFiltros.Text = "Reiniciar filtros"
        Me.btnReiniciarFiltros.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtBuscar.Location = New System.Drawing.Point(434, 14)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(736, 35)
        Me.txtBuscar.TabIndex = 20
        Me.txtBuscar.Text = "Buscar..."
        '
        'lblFiltro
        '
        Me.lblFiltro.AutoSize = True
        Me.lblFiltro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiltro.Location = New System.Drawing.Point(224, 52)
        Me.lblFiltro.Name = "lblFiltro"
        Me.lblFiltro.Size = New System.Drawing.Size(243, 37)
        Me.lblFiltro.TabIndex = 21
        Me.lblFiltro.Text = "Filtro: Ninguno"
        '
        'btnMejoresPrecios
        '
        Me.btnMejoresPrecios.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMejoresPrecios.Location = New System.Drawing.Point(16, 374)
        Me.btnMejoresPrecios.Name = "btnMejoresPrecios"
        Me.btnMejoresPrecios.Size = New System.Drawing.Size(197, 66)
        Me.btnMejoresPrecios.TabIndex = 22
        Me.btnMejoresPrecios.Text = "Los mejores precios"
        Me.btnMejoresPrecios.UseVisualStyleBackColor = True
        '
        'lblNoTenemos
        '
        Me.lblNoTenemos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoTenemos.Location = New System.Drawing.Point(16, 446)
        Me.lblNoTenemos.Name = "lblNoTenemos"
        Me.lblNoTenemos.Size = New System.Drawing.Size(197, 66)
        Me.lblNoTenemos.TabIndex = 23
        Me.lblNoTenemos.Text = "Que no tenemos"
        Me.lblNoTenemos.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(563, 568)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(278, 37)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Lista de compras"
        '
        'lstCompras
        '
        Me.lstCompras.Alignment = System.Windows.Forms.ListViewAlignment.Left
        Me.lstCompras.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader11, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader10})
        Me.lstCompras.ContextMenuStrip = Me.menuListaCompra
        Me.lstCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCompras.FullRowSelect = True
        Me.lstCompras.GridLines = True
        Me.lstCompras.HideSelection = False
        Me.lstCompras.Location = New System.Drawing.Point(230, 608)
        Me.lstCompras.MultiSelect = False
        Me.lstCompras.Name = "lstCompras"
        Me.lstCompras.Size = New System.Drawing.Size(940, 240)
        Me.lstCompras.TabIndex = 25
        Me.lstCompras.UseCompatibleStateImageBehavior = False
        Me.lstCompras.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "ID"
        Me.ColumnHeader8.Width = 0
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Nombre"
        Me.ColumnHeader9.Width = 325
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Fuente"
        Me.ColumnHeader11.Width = 300
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Cantidad"
        Me.ColumnHeader14.Width = 100
        '
        'menuListaCompra
        '
        Me.menuListaCompra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lcEliminar})
        Me.menuListaCompra.Name = "menuProducto"
        Me.menuListaCompra.Size = New System.Drawing.Size(235, 26)
        Me.menuListaCompra.Text = "Eliminar Producto"
        '
        'lcEliminar
        '
        Me.lcEliminar.Name = "lcEliminar"
        Me.lcEliminar.Size = New System.Drawing.Size(234, 22)
        Me.lcEliminar.Text = "Eliminar de la lista de compras"
        '
        'btnLimpiarListaCompra
        '
        Me.btnLimpiarListaCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiarListaCompra.Location = New System.Drawing.Point(16, 612)
        Me.btnLimpiarListaCompra.Name = "btnLimpiarListaCompra"
        Me.btnLimpiarListaCompra.Size = New System.Drawing.Size(197, 66)
        Me.btnLimpiarListaCompra.TabIndex = 26
        Me.btnLimpiarListaCompra.Text = "Limpiar lista de compras"
        Me.btnLimpiarListaCompra.UseVisualStyleBackColor = True
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Precio Total"
        Me.ColumnHeader15.Width = 120
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(12, 681)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(80, 29)
        Me.lblTotal.TabIndex = 27
        Me.lblTotal.Text = "Total:"
        '
        'lblPrecioTotal
        '
        Me.lblPrecioTotal.AutoSize = True
        Me.lblPrecioTotal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblPrecioTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioTotal.Location = New System.Drawing.Point(83, 681)
        Me.lblPrecioTotal.Name = "lblPrecioTotal"
        Me.lblPrecioTotal.Size = New System.Drawing.Size(41, 29)
        Me.lblPrecioTotal.TabIndex = 28
        Me.lblPrecioTotal.Text = "$0"
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Precio Unit."
        Me.ColumnHeader10.Width = 120
        '
        'btnGuardarListaCompra
        '
        Me.btnGuardarListaCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarListaCompra.Location = New System.Drawing.Point(12, 774)
        Me.btnGuardarListaCompra.Name = "btnGuardarListaCompra"
        Me.btnGuardarListaCompra.Size = New System.Drawing.Size(197, 66)
        Me.btnGuardarListaCompra.TabIndex = 29
        Me.btnGuardarListaCompra.Text = "Guardar lista de compras"
        Me.btnGuardarListaCompra.UseVisualStyleBackColor = True
        '
        'ListaProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1584, 852)
        Me.Controls.Add(Me.btnGuardarListaCompra)
        Me.Controls.Add(Me.lblPrecioTotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnLimpiarListaCompra)
        Me.Controls.Add(Me.lstCompras)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblNoTenemos)
        Me.Controls.Add(Me.btnMejoresPrecios)
        Me.Controls.Add(Me.lblFiltro)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.btnReiniciarFiltros)
        Me.Controls.Add(Me.btnQueComprar)
        Me.Controls.Add(Me.lblCategoria)
        Me.Controls.Add(Me.lblFuente)
        Me.Controls.Add(Me.lblCuanto)
        Me.Controls.Add(Me.rdPoco)
        Me.Controls.Add(Me.rdBien)
        Me.Controls.Add(Me.rdSobra)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.btnHay)
        Me.Controls.Add(Me.btnImportante)
        Me.Controls.Add(Me.pbImagen)
        Me.Controls.Add(Me.lstProductos)
        Me.Controls.Add(Me.btnAgregarProducto)
        Me.Controls.Add(Me.lblCategorias)
        Me.Controls.Add(Me.lblFuentes)
        Me.Controls.Add(Me.cmbCategorias)
        Me.Controls.Add(Me.cmbFuentes)
        Me.Name = "ListaProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ListaProductos"
        Me.menuProducto.ResumeLayout(False)
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuImagen.ResumeLayout(False)
        Me.menuListaCompra.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbFuentes As ComboBox
    Friend WithEvents cmbCategorias As ComboBox
    Friend WithEvents lblFuentes As Label
    Friend WithEvents lblCategorias As Label
    Friend WithEvents btnAgregarProducto As Button
    Friend WithEvents lstProductos As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents pbImagen As PictureBox
    Friend WithEvents btnImportante As Button
    Friend WithEvents btnHay As Button
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents rdSobra As RadioButton
    Friend WithEvents rdBien As RadioButton
    Friend WithEvents rdPoco As RadioButton
    Friend WithEvents lblCuanto As Label
    Friend WithEvents lblFuente As Label
    Friend WithEvents lblCategoria As Label
    Friend WithEvents menuCategorias As ContextMenuStrip
    Friend WithEvents menuFuentes As ContextMenuStrip
    Friend WithEvents menuProducto As ContextMenuStrip
    Friend WithEvents eliminarProducto As ToolStripMenuItem
    Friend WithEvents menuImagen As ContextMenuStrip
    Friend WithEvents cambiarImagen As ToolStripMenuItem
    Friend WithEvents tooltip1 As ToolTip
    Friend WithEvents btnQueComprar As Button
    Friend WithEvents btnReiniciarFiltros As Button
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents lblFiltro As Label
    Friend WithEvents btnMejoresPrecios As Button
    Friend WithEvents lblNoTenemos As Button
    Friend WithEvents msAgregar As ToolStripMenuItem
    Friend WithEvents msEliminar As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents lstCompras As ListView
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents menuListaCompra As ContextMenuStrip
    Friend WithEvents lcEliminar As ToolStripMenuItem
    Friend WithEvents btnLimpiarListaCompra As Button
    Friend WithEvents ColumnHeader15 As ColumnHeader
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblPrecioTotal As Label
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents btnGuardarListaCompra As Button
End Class
