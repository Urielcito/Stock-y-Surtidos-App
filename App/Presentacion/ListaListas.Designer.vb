<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListaListas
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
        Me.lstCompras = New System.Windows.Forms.ListView()
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstListas = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblListas = New System.Windows.Forms.Label()
        Me.lblPrecioTotal = New System.Windows.Forms.Label()
        Me.lblDebito = New System.Windows.Forms.Label()
        Me.lblPrecioDebito = New System.Windows.Forms.Label()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.lblPrecioEfectivo = New System.Windows.Forms.Label()
        Me.lblEfectivo = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstCompras
        '
        Me.lstCompras.Alignment = System.Windows.Forms.ListViewAlignment.Left
        Me.lstCompras.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader11, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader10})
        Me.lstCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCompras.FullRowSelect = True
        Me.lstCompras.GridLines = True
        Me.lstCompras.HideSelection = False
        Me.lstCompras.Location = New System.Drawing.Point(522, 12)
        Me.lstCompras.MultiSelect = False
        Me.lstCompras.Name = "lstCompras"
        Me.lstCompras.Size = New System.Drawing.Size(1050, 837)
        Me.lstCompras.TabIndex = 26
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
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "Precio Total"
        Me.ColumnHeader15.Width = 120
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Precio Unit."
        Me.ColumnHeader10.Width = 120
        '
        'lstListas
        '
        Me.lstListas.Alignment = System.Windows.Forms.ListViewAlignment.Left
        Me.lstListas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.lstListas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstListas.FullRowSelect = True
        Me.lstListas.GridLines = True
        Me.lstListas.HideSelection = False
        Me.lstListas.Location = New System.Drawing.Point(19, 45)
        Me.lstListas.MultiSelect = False
        Me.lstListas.Name = "lstListas"
        Me.lstListas.Size = New System.Drawing.Size(162, 804)
        Me.lstListas.TabIndex = 27
        Me.lstListas.UseCompatibleStateImageBehavior = False
        Me.lstListas.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nombre"
        Me.ColumnHeader1.Width = 162
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(187, 810)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(110, 39)
        Me.lblTotal.TabIndex = 28
        Me.lblTotal.Text = "Total:"
        '
        'lblListas
        '
        Me.lblListas.AutoSize = True
        Me.lblListas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblListas.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListas.Location = New System.Drawing.Point(53, 12)
        Me.lblListas.Name = "lblListas"
        Me.lblListas.Size = New System.Drawing.Size(81, 29)
        Me.lblListas.TabIndex = 29
        Me.lblListas.Text = "Listas"
        '
        'lblPrecioTotal
        '
        Me.lblPrecioTotal.AutoSize = True
        Me.lblPrecioTotal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblPrecioTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioTotal.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblPrecioTotal.Location = New System.Drawing.Point(291, 813)
        Me.lblPrecioTotal.Name = "lblPrecioTotal"
        Me.lblPrecioTotal.Size = New System.Drawing.Size(57, 39)
        Me.lblPrecioTotal.TabIndex = 30
        Me.lblPrecioTotal.Text = "$0"
        '
        'lblDebito
        '
        Me.lblDebito.AutoSize = True
        Me.lblDebito.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblDebito.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDebito.Location = New System.Drawing.Point(187, 754)
        Me.lblDebito.Name = "lblDebito"
        Me.lblDebito.Size = New System.Drawing.Size(134, 39)
        Me.lblDebito.TabIndex = 31
        Me.lblDebito.Text = "Debito:"
        '
        'lblPrecioDebito
        '
        Me.lblPrecioDebito.AutoSize = True
        Me.lblPrecioDebito.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblPrecioDebito.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioDebito.ForeColor = System.Drawing.Color.Blue
        Me.lblPrecioDebito.Location = New System.Drawing.Point(318, 754)
        Me.lblPrecioDebito.Name = "lblPrecioDebito"
        Me.lblPrecioDebito.Size = New System.Drawing.Size(57, 39)
        Me.lblPrecioDebito.TabIndex = 32
        Me.lblPrecioDebito.Text = "$0"
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(187, 45)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnActualizar.TabIndex = 33
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'lblPrecioEfectivo
        '
        Me.lblPrecioEfectivo.AutoSize = True
        Me.lblPrecioEfectivo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblPrecioEfectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioEfectivo.ForeColor = System.Drawing.Color.Green
        Me.lblPrecioEfectivo.Location = New System.Drawing.Point(354, 700)
        Me.lblPrecioEfectivo.Name = "lblPrecioEfectivo"
        Me.lblPrecioEfectivo.Size = New System.Drawing.Size(57, 39)
        Me.lblPrecioEfectivo.TabIndex = 35
        Me.lblPrecioEfectivo.Text = "$0"
        '
        'lblEfectivo
        '
        Me.lblEfectivo.AutoSize = True
        Me.lblEfectivo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblEfectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEfectivo.Location = New System.Drawing.Point(187, 700)
        Me.lblEfectivo.Name = "lblEfectivo"
        Me.lblEfectivo.Size = New System.Drawing.Size(161, 39)
        Me.lblEfectivo.TabIndex = 34
        Me.lblEfectivo.Text = "Efectivo:"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(268, 45)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 36
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(349, 45)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(167, 23)
        Me.btnGuardar.TabIndex = 37
        Me.btnGuardar.Text = "Guardar..."
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'ListaListas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1584, 861)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.lblPrecioEfectivo)
        Me.Controls.Add(Me.lblEfectivo)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.lblPrecioDebito)
        Me.Controls.Add(Me.lblDebito)
        Me.Controls.Add(Me.lblPrecioTotal)
        Me.Controls.Add(Me.lblListas)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lstListas)
        Me.Controls.Add(Me.lstCompras)
        Me.Name = "ListaListas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ListaListas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstCompras As ListView
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents ColumnHeader15 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents lstListas As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblListas As Label
    Friend WithEvents lblPrecioTotal As Label
    Friend WithEvents lblDebito As Label
    Friend WithEvents lblPrecioDebito As Label
    Friend WithEvents btnActualizar As Button
    Friend WithEvents lblPrecioEfectivo As Label
    Friend WithEvents lblEfectivo As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnGuardar As Button
End Class
