<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.lblIP = New System.Windows.Forms.Label()
        Me.txtIp0 = New System.Windows.Forms.TextBox()
        Me.txtIp1 = New System.Windows.Forms.TextBox()
        Me.txtIp3 = New System.Windows.Forms.TextBox()
        Me.txtIp2 = New System.Windows.Forms.TextBox()
        Me.btnOlvide = New System.Windows.Forms.Button()
        Me.lblIp0 = New System.Windows.Forms.Label()
        Me.lblIp1 = New System.Windows.Forms.Label()
        Me.lblIp2 = New System.Windows.Forms.Label()
        Me.btnConectar = New System.Windows.Forms.Button()
        Me.lblLocalhost = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 37)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 37)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Contraseña"
        '
        'txtUser
        '
        Me.txtUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.Location = New System.Drawing.Point(19, 49)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(238, 29)
        Me.txtUser.TabIndex = 27
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(19, 121)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9829)
        Me.txtPass.Size = New System.Drawing.Size(238, 29)
        Me.txtPass.TabIndex = 28
        '
        'lblIP
        '
        Me.lblIP.AutoSize = True
        Me.lblIP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIP.Location = New System.Drawing.Point(12, 190)
        Me.lblIP.Name = "lblIP"
        Me.lblIP.Size = New System.Drawing.Size(48, 37)
        Me.lblIP.TabIndex = 29
        Me.lblIP.Text = "IP"
        '
        'txtIp0
        '
        Me.txtIp0.Enabled = False
        Me.txtIp0.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIp0.Location = New System.Drawing.Point(12, 230)
        Me.txtIp0.Name = "txtIp0"
        Me.txtIp0.ReadOnly = True
        Me.txtIp0.Size = New System.Drawing.Size(41, 29)
        Me.txtIp0.TabIndex = 30
        Me.txtIp0.Text = "192"
        '
        'txtIp1
        '
        Me.txtIp1.Enabled = False
        Me.txtIp1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIp1.Location = New System.Drawing.Point(80, 230)
        Me.txtIp1.Name = "txtIp1"
        Me.txtIp1.ReadOnly = True
        Me.txtIp1.Size = New System.Drawing.Size(41, 29)
        Me.txtIp1.TabIndex = 31
        Me.txtIp1.Text = "168"
        '
        'txtIp3
        '
        Me.txtIp3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIp3.Location = New System.Drawing.Point(216, 230)
        Me.txtIp3.Name = "txtIp3"
        Me.txtIp3.Size = New System.Drawing.Size(41, 29)
        Me.txtIp3.TabIndex = 33
        '
        'txtIp2
        '
        Me.txtIp2.Enabled = False
        Me.txtIp2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIp2.Location = New System.Drawing.Point(148, 230)
        Me.txtIp2.Name = "txtIp2"
        Me.txtIp2.ReadOnly = True
        Me.txtIp2.Size = New System.Drawing.Size(41, 29)
        Me.txtIp2.TabIndex = 32
        Me.txtIp2.Text = "1"
        '
        'btnOlvide
        '
        Me.btnOlvide.Location = New System.Drawing.Point(19, 156)
        Me.btnOlvide.Name = "btnOlvide"
        Me.btnOlvide.Size = New System.Drawing.Size(128, 23)
        Me.btnOlvide.TabIndex = 34
        Me.btnOlvide.Text = "Olvide mi contraseña"
        Me.btnOlvide.UseVisualStyleBackColor = True
        '
        'lblIp0
        '
        Me.lblIp0.AutoSize = True
        Me.lblIp0.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIp0.Location = New System.Drawing.Point(59, 238)
        Me.lblIp0.Name = "lblIp0"
        Me.lblIp0.Size = New System.Drawing.Size(15, 24)
        Me.lblIp0.TabIndex = 35
        Me.lblIp0.Text = "."
        '
        'lblIp1
        '
        Me.lblIp1.AutoSize = True
        Me.lblIp1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIp1.Location = New System.Drawing.Point(127, 238)
        Me.lblIp1.Name = "lblIp1"
        Me.lblIp1.Size = New System.Drawing.Size(15, 24)
        Me.lblIp1.TabIndex = 36
        Me.lblIp1.Text = "."
        '
        'lblIp2
        '
        Me.lblIp2.AutoSize = True
        Me.lblIp2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIp2.Location = New System.Drawing.Point(195, 238)
        Me.lblIp2.Name = "lblIp2"
        Me.lblIp2.Size = New System.Drawing.Size(15, 24)
        Me.lblIp2.TabIndex = 37
        Me.lblIp2.Text = "."
        '
        'btnConectar
        '
        Me.btnConectar.Enabled = False
        Me.btnConectar.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConectar.Location = New System.Drawing.Point(12, 265)
        Me.btnConectar.Name = "btnConectar"
        Me.btnConectar.Size = New System.Drawing.Size(245, 54)
        Me.btnConectar.TabIndex = 38
        Me.btnConectar.Text = "Conectar"
        Me.btnConectar.UseVisualStyleBackColor = True
        '
        'lblLocalhost
        '
        Me.lblLocalhost.AutoSize = True
        Me.lblLocalhost.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblLocalhost.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocalhost.Location = New System.Drawing.Point(104, 190)
        Me.lblLocalhost.Name = "lblLocalhost"
        Me.lblLocalhost.Size = New System.Drawing.Size(153, 37)
        Me.lblLocalhost.TabIndex = 39
        Me.lblLocalhost.Text = "localhost"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(269, 331)
        Me.Controls.Add(Me.lblLocalhost)
        Me.Controls.Add(Me.btnConectar)
        Me.Controls.Add(Me.lblIp2)
        Me.Controls.Add(Me.lblIp1)
        Me.Controls.Add(Me.lblIp0)
        Me.Controls.Add(Me.btnOlvide)
        Me.Controls.Add(Me.txtIp3)
        Me.Controls.Add(Me.txtIp2)
        Me.Controls.Add(Me.txtIp1)
        Me.Controls.Add(Me.txtIp0)
        Me.Controls.Add(Me.lblIP)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents lblIP As Label
    Friend WithEvents txtIp0 As TextBox
    Friend WithEvents txtIp1 As TextBox
    Friend WithEvents txtIp3 As TextBox
    Friend WithEvents txtIp2 As TextBox
    Friend WithEvents btnOlvide As Button
    Friend WithEvents lblIp0 As Label
    Friend WithEvents lblIp1 As Label
    Friend WithEvents lblIp2 As Label
    Friend WithEvents btnConectar As Button
    Friend WithEvents lblLocalhost As Label
End Class
