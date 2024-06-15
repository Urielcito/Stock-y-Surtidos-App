<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListaFuentes
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
        Me.components = New System.ComponentModel.Container()
        Me.lstFuentes = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Nombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Aceptan_tarjeta = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Telefono = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.menuFuente = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.eliminarProducto = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAgregarFuente = New System.Windows.Forms.Button()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblAceptanTarjeta = New System.Windows.Forms.Label()
        Me.lblTituloTelefono = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblTituloCant = New System.Windows.Forms.Label()
        Me.lblCant = New System.Windows.Forms.Label()
        Me.menuFuente.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstFuentes
        '
        Me.lstFuentes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Nombre, Me.Aceptan_tarjeta, Me.Telefono})
        Me.lstFuentes.ContextMenuStrip = Me.menuFuente
        Me.lstFuentes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstFuentes.FullRowSelect = True
        Me.lstFuentes.GridLines = True
        Me.lstFuentes.HideSelection = False
        Me.lstFuentes.Location = New System.Drawing.Point(231, 12)
        Me.lstFuentes.Name = "lstFuentes"
        Me.lstFuentes.Size = New System.Drawing.Size(940, 837)
        Me.lstFuentes.TabIndex = 0
        Me.lstFuentes.UseCompatibleStateImageBehavior = False
        Me.lstFuentes.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 0
        '
        'Nombre
        '
        Me.Nombre.Text = "Nombre"
        Me.Nombre.Width = 664
        '
        'Aceptan_tarjeta
        '
        Me.Aceptan_tarjeta.Text = "Aceptan tarjeta?"
        Me.Aceptan_tarjeta.Width = 136
        '
        'Telefono
        '
        Me.Telefono.Text = "Telefono"
        Me.Telefono.Width = 136
        '
        'menuFuente
        '
        Me.menuFuente.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.eliminarProducto})
        Me.menuFuente.Name = "menuProducto"
        Me.menuFuente.Size = New System.Drawing.Size(118, 26)
        Me.menuFuente.Text = "Eliminar Producto"
        '
        'eliminarProducto
        '
        Me.eliminarProducto.Name = "eliminarProducto"
        Me.eliminarProducto.Size = New System.Drawing.Size(117, 22)
        Me.eliminarProducto.Text = "Eliminar"
        '
        'btnAgregarFuente
        '
        Me.btnAgregarFuente.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarFuente.Location = New System.Drawing.Point(12, 12)
        Me.btnAgregarFuente.Name = "btnAgregarFuente"
        Me.btnAgregarFuente.Size = New System.Drawing.Size(127, 113)
        Me.btnAgregarFuente.TabIndex = 5
        Me.btnAgregarFuente.Text = "+"
        Me.btnAgregarFuente.UseVisualStyleBackColor = True
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(1177, 12)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(202, 55)
        Me.lblNombre.TabIndex = 12
        Me.lblNombre.Text = "Nombre"
        '
        'lblAceptanTarjeta
        '
        Me.lblAceptanTarjeta.AutoSize = True
        Me.lblAceptanTarjeta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblAceptanTarjeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAceptanTarjeta.Location = New System.Drawing.Point(1180, 119)
        Me.lblAceptanTarjeta.Name = "lblAceptanTarjeta"
        Me.lblAceptanTarjeta.Size = New System.Drawing.Size(253, 37)
        Me.lblAceptanTarjeta.TabIndex = 13
        Me.lblAceptanTarjeta.Text = "aceptan_tarjeta"
        Me.lblAceptanTarjeta.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTituloTelefono
        '
        Me.lblTituloTelefono.AutoSize = True
        Me.lblTituloTelefono.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblTituloTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloTelefono.Location = New System.Drawing.Point(1180, 211)
        Me.lblTituloTelefono.Name = "lblTituloTelefono"
        Me.lblTituloTelefono.Size = New System.Drawing.Size(149, 37)
        Me.lblTituloTelefono.TabIndex = 14
        Me.lblTituloTelefono.Text = "Telefono"
        Me.lblTituloTelefono.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(1180, 248)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(175, 55)
        Me.lblTelefono.TabIndex = 15
        Me.lblTelefono.Text = "Label2"
        Me.lblTelefono.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblTituloCant
        '
        Me.lblTituloCant.AutoSize = True
        Me.lblTituloCant.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTituloCant.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloCant.Location = New System.Drawing.Point(1183, 812)
        Me.lblTituloCant.Name = "lblTituloCant"
        Me.lblTituloCant.Size = New System.Drawing.Size(181, 37)
        Me.lblTituloCant.TabIndex = 16
        Me.lblTituloCant.Text = "Productos:"
        Me.lblTituloCant.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblCant
        '
        Me.lblCant.AutoSize = True
        Me.lblCant.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCant.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCant.Location = New System.Drawing.Point(1370, 812)
        Me.lblCant.Name = "lblCant"
        Me.lblCant.Size = New System.Drawing.Size(36, 37)
        Me.lblCant.TabIndex = 17
        Me.lblCant.Text = "n"
        Me.lblCant.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ListaFuentes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1584, 861)
        Me.Controls.Add(Me.lblCant)
        Me.Controls.Add(Me.lblTituloCant)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblTituloTelefono)
        Me.Controls.Add(Me.lblAceptanTarjeta)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.btnAgregarFuente)
        Me.Controls.Add(Me.lstFuentes)
        Me.Name = "ListaFuentes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock y Surtidos App"
        Me.menuFuente.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstFuentes As ListView
    Friend WithEvents ID As ColumnHeader
    Friend WithEvents Nombre As ColumnHeader
    Friend WithEvents Aceptan_tarjeta As ColumnHeader
    Friend WithEvents Telefono As ColumnHeader
    Friend WithEvents menuFuente As ContextMenuStrip
    Friend WithEvents eliminarProducto As ToolStripMenuItem
    Friend WithEvents btnAgregarFuente As Button
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblAceptanTarjeta As Label
    Friend WithEvents lblTituloTelefono As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblTituloCant As Label
    Friend WithEvents lblCant As Label
End Class
