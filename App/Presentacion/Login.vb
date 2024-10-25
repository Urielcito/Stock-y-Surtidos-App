Imports System.IO
Imports System.Net

Public Class Login

    Private unaConexion As New Conexion
    Private ip As String = ""
    Private user As String = ""
    Private pass As String = ""
    Private local As String = "192.168.1."
    Private Function txtVacio(t As TextBox) As Boolean
        Return t.Text.Equals("")
    End Function

    Private Sub chequearCampos()
        If Not txtVacio(txtIp3) And Not txtVacio(txtUser) And Not txtVacio(txtPass) Then
            ip = txtIp3.Text
            user = txtUser.Text
            pass = txtUser.Text
            btnConectar.Enabled = True
        End If
    End Sub
    Private Sub txtIp_TextChanged(sender As Object, e As EventArgs) Handles txtIp3.TextChanged
        chequearCampos()
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

    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
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
            Dim princi As New Principal()
            princi.Show()
            Me.Hide()
        End If
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
End Class