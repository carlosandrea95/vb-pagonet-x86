
Public Class LblResumenTotalizar
    Private _moneda As String
    Private _monto As Double

    Public Property Moneda As String
        Get
            Return _moneda
        End Get
        Set(ByVal value As String)
            _moneda = value
            LblMoneda.Text = value
        End Set
    End Property
    Public Property Monto As Double
        Get
            Return _monto
        End Get
        Set(ByVal value As Double)
            _monto = value
            LblMonto.Text = value
        End Set
    End Property
End Class
