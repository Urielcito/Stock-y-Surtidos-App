﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarProducto
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
        Me.lblFuente = New System.Windows.Forms.Label()
        Me.cmbFuentes = New System.Windows.Forms.ComboBox()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.cmbCategorias = New System.Windows.Forms.ComboBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.rbNada = New System.Windows.Forms.RadioButton()
        Me.rbPoco = New System.Windows.Forms.RadioButton()
        Me.rbBien = New System.Windows.Forms.RadioButton()
        Me.rbSobra = New System.Windows.Forms.RadioButton()
        Me.chkImportante = New System.Windows.Forms.CheckBox()
        Me.btnImagen = New System.Windows.Forms.Button()
        Me.pbImagen = New System.Windows.Forms.PictureBox()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFuente
        '
        Me.lblFuente.AutoSize = True
        Me.lblFuente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFuente.Location = New System.Drawing.Point(8, 9)
        Me.lblFuente.Name = "lblFuente"
        Me.lblFuente.Size = New System.Drawing.Size(70, 24)
        Me.lblFuente.TabIndex = 0
        Me.lblFuente.Text = "Fuente"
        '
        'cmbFuentes
        '
        Me.cmbFuentes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFuentes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFuentes.FormattingEnabled = True
        Me.cmbFuentes.Items.AddRange(New Object() {""})
        Me.cmbFuentes.Location = New System.Drawing.Point(12, 36)
        Me.cmbFuentes.Name = "cmbFuentes"
        Me.cmbFuentes.Size = New System.Drawing.Size(346, 32)
        Me.cmbFuentes.TabIndex = 1
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoria.Location = New System.Drawing.Point(8, 71)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(90, 24)
        Me.lblCategoria.TabIndex = 2
        Me.lblCategoria.Text = "Categoria"
        '
        'cmbCategorias
        '
        Me.cmbCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategorias.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCategorias.FormattingEnabled = True
        Me.cmbCategorias.Items.AddRange(New Object() {""})
        Me.cmbCategorias.Location = New System.Drawing.Point(12, 98)
        Me.cmbCategorias.Name = "cmbCategorias"
        Me.cmbCategorias.Size = New System.Drawing.Size(346, 32)
        Me.cmbCategorias.TabIndex = 3
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(395, 9)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(79, 24)
        Me.lblNombre.TabIndex = 4
        Me.lblNombre.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(399, 36)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(356, 29)
        Me.txtNombre.TabIndex = 5
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio.Location = New System.Drawing.Point(395, 71)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(64, 24)
        Me.lblPrecio.TabIndex = 7
        Me.lblPrecio.Text = "Precio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 24)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Cuanto tenemos en casa?"
        '
        'btnAgregar
        '
        Me.btnAgregar.Enabled = False
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(761, 33)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(116, 94)
        Me.btnAgregar.TabIndex = 10
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtPrecio
        '
        Me.txtPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio.Location = New System.Drawing.Point(399, 98)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(65, 29)
        Me.txtPrecio.TabIndex = 11
        '
        'rbNada
        '
        Me.rbNada.AutoSize = True
        Me.rbNada.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNada.Location = New System.Drawing.Point(11, 167)
        Me.rbNada.Name = "rbNada"
        Me.rbNada.Size = New System.Drawing.Size(81, 28)
        Me.rbNada.TabIndex = 12
        Me.rbNada.TabStop = True
        Me.rbNada.Text = "NADA"
        Me.rbNada.UseVisualStyleBackColor = True
        '
        'rbPoco
        '
        Me.rbPoco.AutoSize = True
        Me.rbPoco.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPoco.Location = New System.Drawing.Point(11, 201)
        Me.rbPoco.Name = "rbPoco"
        Me.rbPoco.Size = New System.Drawing.Size(83, 28)
        Me.rbPoco.TabIndex = 13
        Me.rbPoco.TabStop = True
        Me.rbPoco.Text = "POCO"
        Me.rbPoco.UseVisualStyleBackColor = True
        '
        'rbBien
        '
        Me.rbBien.AutoSize = True
        Me.rbBien.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbBien.Location = New System.Drawing.Point(11, 235)
        Me.rbBien.Name = "rbBien"
        Me.rbBien.Size = New System.Drawing.Size(71, 28)
        Me.rbBien.TabIndex = 14
        Me.rbBien.TabStop = True
        Me.rbBien.Text = "BIEN"
        Me.rbBien.UseVisualStyleBackColor = True
        '
        'rbSobra
        '
        Me.rbSobra.AutoSize = True
        Me.rbSobra.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSobra.Location = New System.Drawing.Point(11, 269)
        Me.rbSobra.Name = "rbSobra"
        Me.rbSobra.Size = New System.Drawing.Size(93, 28)
        Me.rbSobra.TabIndex = 15
        Me.rbSobra.TabStop = True
        Me.rbSobra.Text = "SOBRA"
        Me.rbSobra.UseVisualStyleBackColor = True
        '
        'chkImportante
        '
        Me.chkImportante.AutoSize = True
        Me.chkImportante.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkImportante.Location = New System.Drawing.Point(399, 140)
        Me.chkImportante.Name = "chkImportante"
        Me.chkImportante.Size = New System.Drawing.Size(117, 28)
        Me.chkImportante.TabIndex = 16
        Me.chkImportante.Text = "Importante"
        Me.chkImportante.UseVisualStyleBackColor = True
        '
        'btnImagen
        '
        Me.btnImagen.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImagen.Location = New System.Drawing.Point(610, 267)
        Me.btnImagen.Name = "btnImagen"
        Me.btnImagen.Size = New System.Drawing.Size(116, 30)
        Me.btnImagen.TabIndex = 17
        Me.btnImagen.Text = "Examinar..."
        Me.btnImagen.UseVisualStyleBackColor = True
        '
        'pbImagen
        '
        Me.pbImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbImagen.Location = New System.Drawing.Point(732, 167)
        Me.pbImagen.Name = "pbImagen"
        Me.pbImagen.Size = New System.Drawing.Size(145, 130)
        Me.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbImagen.TabIndex = 18
        Me.pbImagen.TabStop = False
        '
        'AgregarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 309)
        Me.Controls.Add(Me.pbImagen)
        Me.Controls.Add(Me.btnImagen)
        Me.Controls.Add(Me.chkImportante)
        Me.Controls.Add(Me.rbSobra)
        Me.Controls.Add(Me.rbBien)
        Me.Controls.Add(Me.rbPoco)
        Me.Controls.Add(Me.rbNada)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.cmbCategorias)
        Me.Controls.Add(Me.lblCategoria)
        Me.Controls.Add(Me.cmbFuentes)
        Me.Controls.Add(Me.lblFuente)
        Me.Name = "AgregarProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock y Surtidos"
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFuente As Label
    Friend WithEvents cmbFuentes As ComboBox
    Friend WithEvents lblCategoria As Label
    Friend WithEvents cmbCategorias As ComboBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblPrecio As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents rbNada As RadioButton
    Friend WithEvents rbPoco As RadioButton
    Friend WithEvents rbBien As RadioButton
    Friend WithEvents rbSobra As RadioButton
    Friend WithEvents chkImportante As CheckBox
    Friend WithEvents btnImagen As Button
    Friend WithEvents pbImagen As PictureBox
End Class
