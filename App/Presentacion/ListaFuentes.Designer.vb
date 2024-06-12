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
        Me.menuProducto = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.eliminarProducto = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuProducto.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstFuentes
        '
        Me.lstFuentes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Nombre, Me.Aceptan_tarjeta, Me.Telefono})
        Me.lstFuentes.HideSelection = False
        Me.lstFuentes.Location = New System.Drawing.Point(107, 87)
        Me.lstFuentes.Name = "lstFuentes"
        Me.lstFuentes.Size = New System.Drawing.Size(424, 97)
        Me.lstFuentes.TabIndex = 0
        Me.lstFuentes.UseCompatibleStateImageBehavior = False
        Me.lstFuentes.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 37
        '
        'Nombre
        '
        Me.Nombre.Text = "Nombre"
        Me.Nombre.Width = 168
        '
        'Aceptan_tarjeta
        '
        Me.Aceptan_tarjeta.Text = "Aceptan tarjeta?"
        Me.Aceptan_tarjeta.Width = 97
        '
        'Telefono
        '
        Me.Telefono.Text = "Telefono"
        Me.Telefono.Width = 118
        '
        'menuProducto
        '
        Me.menuProducto.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.eliminarProducto})
        Me.menuProducto.Name = "menuProducto"
        Me.menuProducto.Size = New System.Drawing.Size(181, 48)
        Me.menuProducto.Text = "Eliminar Producto"
        '
        'eliminarProducto
        '
        Me.eliminarProducto.Name = "eliminarProducto"
        Me.eliminarProducto.Size = New System.Drawing.Size(180, 22)
        Me.eliminarProducto.Text = "Eliminar"
        '
        'ListaFuentes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1584, 861)
        Me.Controls.Add(Me.lstFuentes)
        Me.Name = "ListaFuentes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock y Surtidos App"
        Me.menuProducto.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstFuentes As ListView
    Friend WithEvents ID As ColumnHeader
    Friend WithEvents Nombre As ColumnHeader
    Friend WithEvents Aceptan_tarjeta As ColumnHeader
    Friend WithEvents Telefono As ColumnHeader
    Friend WithEvents menuProducto As ContextMenuStrip
    Friend WithEvents eliminarProducto As ToolStripMenuItem
End Class
