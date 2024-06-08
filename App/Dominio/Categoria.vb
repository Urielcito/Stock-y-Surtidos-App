Public Class Categoria
    Private mid As Integer
    Private mnombre As String

    Public Property id() As Integer
        Get
            Return mid
        End Get
        Set(value As Integer)
            mid = value
        End Set
    End Property

    Public Property nombre() As String
        Get
            Return mnombre
        End Get
        Set(value As String)
            mnombre = value
        End Set
    End Property

    Public Sub New(ByVal pid As Integer, ByVal pnombre As String)
        id = pid
        nombre = pnombre
    End Sub

    Public Sub New()

    End Sub
End Class
