Public Class CurrencyTextBox
    Private _valor As Double
    Private _simbolo As String
    Public Property Valor As Double
        Get
            Return _valor
        End Get
        Set(ByVal value As Double)
            _valor = value
            MostrarValor()
        End Set
    End Property
    Public Property Simbolo As String
        Get
            Return _simbolo
        End Get
        Set(ByVal value As String)
            _simbolo = value
        End Set
    End Property

    Sub MostrarValor()
        TextBox1.Text = FormatNumber(_valor) & " " & _simbolo
    End Sub

End Class
