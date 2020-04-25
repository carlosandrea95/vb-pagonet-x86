Public Class AlertBox
    Private _alertTitle
    Private _alertMessage
    Private _alertSubjet
    Private _ok
    Private _img_icon As Drawing.Image

    Public Property ImageIcon As Drawing.Image
        Get
            Return _img_icon
        End Get
        Set(ByVal value As Drawing.Image)
            _img_icon = value
            PictureBox1.Image = value
        End Set
    End Property

    Public Property Mensaje As String
        Get
            Return _alertMessage
        End Get
        Set(ByVal value As String)
            _alertMessage = value
            lblMessage.Text = _alertMessage
        End Set
    End Property
    Public Property Asunto As String
        Get
            Return _alertSubjet
        End Get
        Set(ByVal value As String)
            _alertSubjet = value
            lblAsunto.Text = value
        End Set
    End Property



End Class
