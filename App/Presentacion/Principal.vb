Public Class Principal
    Private cont As New Controladora
    Private colcat As ArrayList
    Private colprod As ArrayList
    Private colfuente As ArrayList


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click
        Dim a As New AgregarProducto
        a.Show()


    End Sub
End Class
