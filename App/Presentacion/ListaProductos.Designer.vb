﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListaProductos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
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
        Me.btnRefrescar = New System.Windows.Forms.Button()
        Me.pbImagen = New System.Windows.Forms.PictureBox()
        Me.btnImportante = New System.Windows.Forms.Button()
        Me.btnHay = New System.Windows.Forms.Button()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.rdSobra = New System.Windows.Forms.RadioButton()
        Me.rdBien = New System.Windows.Forms.RadioButton()
        Me.rdPoco = New System.Windows.Forms.RadioButton()
        Me.lblCuanto = New System.Windows.Forms.Label()
        Me.lblFuente = New System.Windows.Forms.Label()
        Me.lblCategoria = New System.Windows.Forms.Label()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lstProductos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lstProductos.FullRowSelect = True
        Me.lstProductos.GridLines = True
        Me.lstProductos.HideSelection = False
        Me.lstProductos.Location = New System.Drawing.Point(228, 55)
        Me.lstProductos.MultiSelect = False
        Me.lstProductos.Name = "lstProductos"
        Me.lstProductos.Size = New System.Drawing.Size(901, 625)
        Me.lstProductos.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lstProductos.TabIndex = 5
        Me.lstProductos.UseCompatibleStateImageBehavior = False
        Me.lstProductos.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 42
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
        Me.ColumnHeader4.Width = 143
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Precio"
        Me.ColumnHeader5.Width = 75
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Importancia"
        Me.ColumnHeader6.Width = 107
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Cuanto hay"
        Me.ColumnHeader7.Width = 76
        '
        'btnRefrescar
        '
        Me.btnRefrescar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefrescar.Location = New System.Drawing.Point(228, 10)
        Me.btnRefrescar.Name = "btnRefrescar"
        Me.btnRefrescar.Size = New System.Drawing.Size(145, 39)
        Me.btnRefrescar.TabIndex = 6
        Me.btnRefrescar.Text = "Refrescar lista"
        Me.btnRefrescar.UseVisualStyleBackColor = True
        '
        'pbImagen
        '
        Me.pbImagen.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pbImagen.Location = New System.Drawing.Point(1136, 55)
        Me.pbImagen.Name = "pbImagen"
        Me.pbImagen.Size = New System.Drawing.Size(392, 241)
        Me.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbImagen.TabIndex = 7
        Me.pbImagen.TabStop = False
        '
        'btnImportante
        '
        Me.btnImportante.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImportante.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportante.Location = New System.Drawing.Point(1136, 346)
        Me.btnImportante.Name = "btnImportante"
        Me.btnImportante.Size = New System.Drawing.Size(392, 67)
        Me.btnImportante.TabIndex = 8
        Me.btnImportante.UseVisualStyleBackColor = True
        '
        'btnHay
        '
        Me.btnHay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHay.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHay.Location = New System.Drawing.Point(1136, 419)
        Me.btnHay.Name = "btnHay"
        Me.btnHay.Size = New System.Drawing.Size(392, 67)
        Me.btnHay.TabIndex = 9
        Me.btnHay.UseVisualStyleBackColor = True
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(1137, 316)
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
        Me.lblPrecio.Location = New System.Drawing.Point(1409, 303)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(119, 37)
        Me.lblPrecio.TabIndex = 11
        Me.lblPrecio.Text = "Label2"
        '
        'rdSobra
        '
        Me.rdSobra.AutoSize = True
        Me.rdSobra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdSobra.Location = New System.Drawing.Point(1259, 525)
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
        Me.rdBien.Location = New System.Drawing.Point(1259, 555)
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
        Me.rdPoco.Location = New System.Drawing.Point(1259, 583)
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
        Me.lblCuanto.Location = New System.Drawing.Point(1132, 524)
        Me.lblCuanto.Name = "lblCuanto"
        Me.lblCuanto.Size = New System.Drawing.Size(121, 24)
        Me.lblCuanto.TabIndex = 15
        Me.lblCuanto.Text = "Cuanto hay:"
        '
        'lblFuente
        '
        Me.lblFuente.AutoSize = True
        Me.lblFuente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFuente.Location = New System.Drawing.Point(1137, 656)
        Me.lblFuente.Name = "lblFuente"
        Me.lblFuente.Size = New System.Drawing.Size(137, 24)
        Me.lblFuente.TabIndex = 16
        Me.lblFuente.Text = "Comprado en"
        Me.lblFuente.UseMnemonic = False
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoria.Location = New System.Drawing.Point(1137, 632)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(99, 24)
        Me.lblCategoria.TabIndex = 17
        Me.lblCategoria.Text = "Categoria"
        Me.lblCategoria.UseMnemonic = False
        '
        'ListaProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1540, 692)
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
        Me.Controls.Add(Me.btnRefrescar)
        Me.Controls.Add(Me.lstProductos)
        Me.Controls.Add(Me.btnAgregarProducto)
        Me.Controls.Add(Me.lblCategorias)
        Me.Controls.Add(Me.lblFuentes)
        Me.Controls.Add(Me.cmbCategorias)
        Me.Controls.Add(Me.cmbFuentes)
        Me.Name = "ListaProductos"
        Me.Text = "ListaProductos"
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnRefrescar As Button
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
End Class