
Public Class Connection
    Private _HOST, _USERNAME, _PASSWORD, _PORT, _DATABASE
    
    Public Property Database As String
        Get
            Return _DATABASE
        End Get
        Set(ByVal value As String)
            _DATABASE = value
        End Set
    End Property


    Sub New(ByVal Host As String)
        _HOST = Host
    End Sub



End Class

Class test

    Sub conectar()
        Dim conn As Connection = New Connection("localhost")
        conn.Database = "pn_masterdb"
    End Sub

End Class

