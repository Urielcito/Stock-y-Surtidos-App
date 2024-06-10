<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.SuspendLayout()
        '
        'lblFuente
        '
        Me.lblFuente.AutoSize = True
        Me.lblFuente.Location = New System.Drawing.Point(13, 9)
        Me.lblFuente.Name = "lblFuente"
        Me.lblFuente.Size = New System.Drawing.Size(40, 13)
        Me.lblFuente.TabIndex = 0
        Me.lblFuente.Text = "Fuente"
        '
        'cmbFuentes
        '
        Me.cmbFuentes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFuentes.FormattingEnabled = True
        Me.cmbFuentes.Items.AddRange(New Object() {""})
        Me.cmbFuentes.Location = New System.Drawing.Point(16, 25)
        Me.cmbFuentes.Name = "cmbFuentes"
        Me.cmbFuentes.Size = New System.Drawing.Size(121, 21)
        Me.cmbFuentes.TabIndex = 1
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Location = New System.Drawing.Point(13, 50)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(52, 13)
        Me.lblCategoria.TabIndex = 2
        Me.lblCategoria.Text = "Categoria"
        '
        'cmbCategorias
        '
        Me.cmbCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategorias.FormattingEnabled = True
        Me.cmbCategorias.Items.AddRange(New Object() {""})
        Me.cmbCategorias.Location = New System.Drawing.Point(16, 66)
        Me.cmbCategorias.Name = "cmbCategorias"
        Me.cmbCategorias.Size = New System.Drawing.Size(121, 21)
        Me.cmbCategorias.TabIndex = 3
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(144, 9)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 4
        Me.lblNombre.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(147, 26)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(188, 20)
        Me.txtNombre.TabIndex = 5
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(338, 9)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(37, 13)
        Me.lblPrecio.TabIndex = 7
        Me.lblPrecio.Text = "Precio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(261, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Cuanto tenemos en casa?"
        '
        'btnAgregar
        '
        Me.btnAgregar.Enabled = False
        Me.btnAgregar.Location = New System.Drawing.Point(413, 9)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(100, 37)
        Me.btnAgregar.TabIndex = 10
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(342, 26)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(65, 20)
        Me.txtPrecio.TabIndex = 11
        '
        'rbNada
        '
        Me.rbNada.AutoSize = True
        Me.rbNada.Location = New System.Drawing.Point(147, 66)
        Me.rbNada.Name = "rbNada"
        Me.rbNada.Size = New System.Drawing.Size(55, 17)
        Me.rbNada.TabIndex = 12
        Me.rbNada.TabStop = True
        Me.rbNada.Text = "NADA"
        Me.rbNada.UseVisualStyleBackColor = True
        '
        'rbPoco
        '
        Me.rbPoco.AutoSize = True
        Me.rbPoco.Location = New System.Drawing.Point(239, 66)
        Me.rbPoco.Name = "rbPoco"
        Me.rbPoco.Size = New System.Drawing.Size(55, 17)
        Me.rbPoco.TabIndex = 13
        Me.rbPoco.TabStop = True
        Me.rbPoco.Text = "POCO"
        Me.rbPoco.UseVisualStyleBackColor = True
        '
        'rbBien
        '
        Me.rbBien.AutoSize = True
        Me.rbBien.Location = New System.Drawing.Point(342, 66)
        Me.rbBien.Name = "rbBien"
        Me.rbBien.Size = New System.Drawing.Size(50, 17)
        Me.rbBien.TabIndex = 14
        Me.rbBien.TabStop = True
        Me.rbBien.Text = "BIEN"
        Me.rbBien.UseVisualStyleBackColor = True
        '
        'rbSobra
        '
        Me.rbSobra.AutoSize = True
        Me.rbSobra.Location = New System.Drawing.Point(433, 66)
        Me.rbSobra.Name = "rbSobra"
        Me.rbSobra.Size = New System.Drawing.Size(62, 17)
        Me.rbSobra.TabIndex = 15
        Me.rbSobra.TabStop = True
        Me.rbSobra.Text = "SOBRA"
        Me.rbSobra.UseVisualStyleBackColor = True
        '
        'AgregarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 96)
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
        Me.Text = "Stock y Surtidos"
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
End Class
