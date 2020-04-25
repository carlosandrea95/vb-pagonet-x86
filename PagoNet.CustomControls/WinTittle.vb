Public Class WinTittle
    Private _titulo As String
    Private _BottomHide As Boolean = True
    Private _align As ContentAlignment = ContentAlignment.MiddleLeft
    Private _color As Drawing.Color = Drawing.Color.SteelBlue
    Private _TextColor As Drawing.Color = Drawing.Color.White
    Private _form As Form

    Public Property Titulo As String
        Get
            Return _titulo
        End Get
        Set(ByVal value As String)
            _titulo = value
            Label4.Text = _titulo.ToUpper
        End Set
    End Property

    Public Property BottomHide As Boolean
        Get
            Return _BottomHide
        End Get
        Set(ByVal value As Boolean)
            _BottomHide = value
            Label1.Visible = value
        End Set
    End Property
    Public Property AlingText As ContentAlignment
        Get
            Return _align
        End Get
        Set(ByVal value As ContentAlignment)
            _align = value
            Label4.TextAlign = value
        End Set
    End Property

    Public Property Color As Drawing.Color
        Get
            Return _color
        End Get
        Set(ByVal value As Drawing.Color)
            _color = value
            Label4.BackColor = value
        End Set
    End Property
    Public Property TextColor As Drawing.Color
        Get
            Return _TextColor
        End Get
        Set(ByVal value As Drawing.Color)
            _TextColor = value
            Label4.ForeColor = value
        End Set
    End Property

    Public Property FormParent As Form
        Get
            Return _form
        End Get
        Set(ByVal value As Form)
            _form = value
        End Set
    End Property
    
    Private Sub Label1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label1.Click
        _form.Close()
    End Sub

    Private Sub WinTittle_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Label1.Visible = False Then
            Label4.Width = Me.Width
        End If
    End Sub
End Class
