Public Class Principal
    Private Sub btnListaProductos_Click(sender As Object, e As EventArgs) Handles btnListaProductos.Click
        Dim lp As New ListaProductos
        lp.Show()
        Me.Hide()
    End Sub

    Private Sub btnListaFuentes_Click(sender As Object, e As EventArgs) Handles btnListaFuentes.Click
        Dim lf As New ListaFuentes
        lf.Show()
        Me.Hide()
    End Sub

    Private Sub Principal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        End
    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
