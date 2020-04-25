Imports PagoNet.Engine, PagoNet.Engine.Cash
Imports PagoNet.FormComponents
Public Class win_apuertura
    Dim combService As New ComboBoxservice
    Dim Eng As New AperturaCaja
    Dim DtForm As New FormDataManager
    Dim Auth As New ControlAcceso

    Private Sub StartCashRegister_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F2 Then
            MsgBox("F2")
        End If
    End Sub

    Private Sub StartCashRegister_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Eng.CheckApertura = True Then
            Auth.SetPermissionsByRol(win_terminal)
            Me.Close()
        Else
            Eng.GetTurno(CombTurno)
            Eng.GetCajaro(lbl_cajero)
            Eng.GetCajas(CombCaja)
            Eng.GetMonedas(DTG_Apertura)
        End If
    End Sub

    Private Sub CombTurno_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CombTurno.SelectedValueChanged
        Eng.GetTurnoHorario(CombTurno.SelectedValue.ToString, lbl_de, lbl_hasta)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub DTG_Apertura_RowLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DTG_Apertura.RowLeave
        Eng.GetMonedas(DTG_Apertura)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim FormData As String
        FormData = DtForm.Serialize(Me)
        If Eng.ProcesarApertura(DtForm.Value(FormData, "CombCaja"), DtForm.Value(FormData, "CombTurno"), DtForm.DataGridViewSerialize(DTG_Apertura)) = True Then
            Auth.SetPermissionsByRol(win_terminal)
            Me.Close()
        End If
    End Sub
End Class