﻿Public Class Producto
    Private mid As Integer
    Private mfuente As Fuente
    Private mcategoria As Categoria
    Private mnombre As String
    Private mprecio As Double
    Private mcuanto_tenemos As String
    Private mimportante As Boolean
    Private mnombre_imagen As String

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

    Public Property cuanto_tenemos As String
        Get
            Return mcuanto_tenemos
        End Get
        Set(value As String)
            mcuanto_tenemos = value
        End Set
    End Property

    Public Property importante As Boolean
        Get
            Return mimportante
        End Get
        Set(value As Boolean)
            mimportante = value
        End Set
    End Property

    Public Property nombre_imagen As String
        Get
            Return mnombre_imagen
        End Get
        Set(value As String)
            mnombre_imagen = value
        End Set
    End Property

    Public Sub New(pid As Integer, pfuente As Fuente, pcategoria As Categoria, pnombre As String, pprecio As Double, pcuanto_tenemos As String, pimportante As Boolean, pnombre_imagen As String)
        id = pid
        fuente = pfuente
        categoria = pcategoria
        nombre = pnombre
        precio = pprecio
        cuanto_tenemos = pcuanto_tenemos
        importante = pimportante
        nombre_imagen = pnombre_imagen
    End Sub
    Public Sub New()
    End Sub
End Class
