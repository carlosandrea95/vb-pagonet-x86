
Imports PagoNet.Engine.Cash
Public Class win_carga
    Dim ld As New CargarDocumento
    Private Sub win_carga_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ld.CargaLv(ListView1)

    End Sub
End Class