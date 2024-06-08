Public Class Producto
    Private mid As Integer
    Private mfuente As Fuente
    Private mcategoria As Categoria
    Private mnombre As String
    Private mprecio As Double
    Private mhay_en_casa As Boolean
    Private mcuanto_tenemos As String

    Public Property id() As Integer
        Get
            Return mid
        End Get
        Set(value As Integer)
            mid = value
        End Set
    End Property

    Public Property fuente() As Fuente
        Get
            Return mfuente
        End Get
        Set(value As Fuente)
            mfuente = value
        End Set
    End Property

    Public Property categoria() As Categoria
        Get
            Return mcategoria
        End Get
        Set(value As Categoria)
            mcategoria = value
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

    Public Property precio() As Double
        Get
            Return mprecio
        End Get
        Set(value As Double)
            mprecio = value
        End Set
    End Property

    Public Property hay_en_casa() As Boolean
        Get
            Return mhay_en_casa
        End Get
        Set(value As Boolean)
            mhay_en_casa = value
        End Set
    End Property

    Public Property cuanto_tenemos As String
        Get
            Return mcuanto_tenemos
        End Get
        Set(value As String)
            mcuanto_tenemos = value
        End Set
    End Property

    Public Sub New(pid As Integer, pfuente As Fuente, pcategoria As Categoria, pnombre As String, pprecio As Double, phay_en_casa As Boolean, pcuanto_tenemos As String)
        id = pid
        fuente = pfuente
        categoria = pcategoria
        nombre = pnombre
        precio = pprecio
        hay_en_casa = phay_en_casa
        cuanto_tenemos = pcuanto_tenemos
    End Sub

    Public Sub New()
    End Sub
End Class
