<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
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
        Me.btnListaProductos = New System.Windows.Forms.Button()
        Me.btnListaFuentes = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnListaProductos
        '
        Me.btnListaProductos.Font = New System.Drawing.Font("High Tower Text", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListaProductos.Location = New System.Drawing.Point(12, 12)
        Me.btnListaProductos.Name = "btnListaProductos"
        Me.btnListaProductos.Size = New System.Drawing.Size(776, 78)
        Me.btnListaProductos.TabIndex = 0
        Me.btnListaProductos.Text = "LISTA DE PRODUCTOS"
        Me.btnListaProductos.UseVisualStyleBackColor = True
        '
        'btnListaFuentes
        '
        Me.btnListaFuentes.Font = New System.Drawing.Font("High Tower Text", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListaFuentes.Location = New System.Drawing.Point(12, 96)
        Me.btnListaFuentes.Name = "btnListaFuentes"
        Me.btnListaFuentes.Size = New System.Drawing.Size(776, 78)
        Me.btnListaFuentes.TabIndex = 1
        Me.btnListaFuentes.Text = "LISTA DE FUENTES"
        Me.btnListaFuentes.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(428, 285)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnListaFuentes)
        Me.Controls.Add(Me.btnListaProductos)
        Me.Name = "Principal"
        Me.Text = "Stock y Surtidos"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnListaProductos As Button
    Friend WithEvents btnListaFuentes As Button
    Friend WithEvents Button1 As Button
End Class
