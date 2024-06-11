Public Class Principal
    Private Sub btnListaProductos_Click(sender As Object, e As EventArgs) Handles btnListaProductos.Click
        Dim lp As New ListaProductos
        lp.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
