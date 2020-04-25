Public Class BtnTerminal

    Private _TEXTO As String
    Private _IMG As Drawing.Image
    Private _FUNCION As String
    Public Property Funcion As String
        Get
            Return _FUNCION
        End Get
        Set(ByVal value As String)
            _FUNCION = value.ToUpper
        End Set
    End Property
    Public Property Texto As String
        Get
            Return _TEXTO
        End Get
        Set(ByVal value As String)
            _TEXTO = value.ToUpper
            Label1.Text = _FUNCION.ToUpper + vbCr + value.ToUpper
        End Set
    End Property
    Public Property ImageIcon As Drawing.Image
        Get
            Return _IMG
        End Get
        Set(ByVal value As Drawing.Image)
            _IMG = value
            Label1.Image = value
        End Set
    End Property

End Class
