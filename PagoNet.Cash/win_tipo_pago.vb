Public Class win_tipo_pago

    Private Sub win_tipo_pago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LblResumenTotalizar1.Moneda = My.Settings.SIMCURRENCY
        LblResumenTotalizar2.Moneda = My.Settings.SIMCURRENCY
        LblResumenTotalizar3.Moneda = My.Settings.SIMCURRENCY
        LblResumenTotalizar4.Moneda = My.Settings.SIMCURRENCY
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class