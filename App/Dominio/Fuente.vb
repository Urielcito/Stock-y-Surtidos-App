Public Class Fuente

    Private mid As Integer
    Private mnombre As String
    Private maceptan_tarjeta As Boolean
    Private mtelefono As String
    Public Property id() As Integer
        Get
            Return mid
        End Get
        Set(ByVal value As Integer)
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

    Property aceptan_tarjeta As Boolean
        Get
            Return maceptan_tarjeta
        End Get
        Set(value As Boolean)
            maceptan_tarjeta = value
        End Set
    End Property

    Public Property telefono As String
        Get
            Return mtelefono
        End Get
        Set(value As String)
            mtelefono = value
        End Set
    End Property

    Public Sub New(ByVal pid As Integer, ByVal pnombre As String, ByVal paceptan_tarjeta As Boolean, ByVal ptelefono As String)
        id = pid
        nombre = pnombre
        aceptan_tarjeta = paceptan_tarjeta
        telefono = ptelefono
    End Sub

    Public Sub New() 'constructor vacio
    End Sub
End Class
