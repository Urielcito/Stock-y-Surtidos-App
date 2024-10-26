Imports System.IO

Public Class Login

    Private unaConexion As New Conexion
    Private ip As String = ""
    Private user As String = ""
    Private pass As String = ""
    Private local As String = "192.168.1."


    Private Function txtVacio(t As TextBox) As Boolean
        Return t.Text.Equals("")
    End Function

    Private Function chequearCampos() As Boolean
        Dim permitir = False
        If Not txtVacio(txtIp3) And Not txtVacio(txtUser) And Not txtVacio(txtPass) Then
            ip = txtIp3.Text
            user = txtUser.Text
            pass = txtUser.Text
            btnConectar.Enabled = True
            permitir = True
        Else
            permitir = False
        End If
        Return permitir
    End Function
    Private Sub txtIp3_TextChanged(sender As Object, e As EventArgs) Handles txtIp3.TextChanged
        chequearCampos()
        If txtIp3.Text.Contains("l") Then
            'Me.local = ""
            'txtIp3.Text = "localhost"
            'abrirPrograma()
            lblLocalhost_Click(sender, e)
        End If

    End Sub

    Private Sub txtUser_TextChanged(sender As Object, e As EventArgs) Handles txtUser.TextChanged
        chequearCampos()
    End Sub

    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged
        chequearCampos()
    End Sub

    Private Sub btnOlvide_Click(sender As Object, e As EventArgs) Handles btnOlvide.Click
        MessageBox.Show("Usuario en laptop: laptop. " + Environment.NewLine + "Contraseña en laptop: laptop." + Environment.NewLine + "IP de la PC: cmd -> ipconfig -> iPv4 :)")
    End Sub

    Private Sub abrirPrograma()
        If (Not Directory.Exists("credentials")) Then
            Directory.CreateDirectory("credentials")
        End If

        If (Not File.Exists("credentials\ip.txt")) Then
            File.Create("credentials\ip.txt").Dispose()
        End If

        File.WriteAllText("credentials\ip.txt", local + ip)


        If (Not File.Exists("credentials\user.txt")) Then
            File.Create("credentials\user.txt").Dispose()
        End If

        File.WriteAllText("credentials\user.txt", user)


        If (Not File.Exists("credentials\pass.txt")) Then
            File.Create("credentials\pass.txt").Dispose()
        End If

        File.WriteAllText("credentials\pass.txt", pass)

        If (unaConexion.AbrirConexion()) Then
            unaConexion.CerrarConexion()
            Dim princi As New Principal()
            princi.Show()
            Me.Hide()
        End If
    End Sub
    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
        abrirPrograma()
    End Sub

    Private Sub lblLocalhost_Click(sender As Object, e As EventArgs) Handles lblLocalhost.Click
        Me.local = ""
        lblLocalhost.ForeColor = Color.Black
        lblIP.ForeColor = Color.Gray
        txtIp0.Visible = False
        txtIp1.Visible = False
        txtIp2.Visible = False
        txtIp3.Visible = False

        lblIp0.Visible = False
        lblIp1.Visible = False
        lblIp2.Visible = False
        txtIp3.Text = "localhost"
    End Sub

    Private Sub lblIP_Click(sender As Object, e As EventArgs) Handles lblIP.Click
        Me.local = "192.168.1."
        lblLocalhost.ForeColor = Color.Gray
        lblIP.ForeColor = Color.Black
        txtIp0.Visible = True
        txtIp1.Visible = True
        txtIp2.Visible = True
        txtIp3.Visible = True

        lblIp0.Visible = True
        lblIp1.Visible = True
        lblIp2.Visible = True
        txtIp3.Text = ""
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ruta As String = "credentials\ip.txt"
        Dim ultimaIp As String = ""
        If File.Exists(ruta) Then
            ultimaIp = File.ReadAllText(ruta)
        End If
        If (Not ultimaIp.Equals("localhost")) Then
            ultimaIp = ultimaIp.Split(".").Last()
            txtIp3.Text = ultimaIp
            txtIp3.ForeColor = Color.Gray
        Else
            lblUltimaIp.Text = "Ultima IP usada: localhost"
        End If

    End Sub

    Private Sub txtPass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPass.KeyDown, txtIp3.KeyDown
        If e.KeyCode = Keys.Enter And chequearCampos() Then
            abrirPrograma()
        End If
    End Sub
End Class