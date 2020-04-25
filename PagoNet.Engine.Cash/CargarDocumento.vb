Imports PagoNet.FormComponents
Imports System.Windows.Forms
Public Class CargarDocumento
    Dim lvService As New ListViewService

    Sub CargaLv(ByVal lv As listview)
        lvService.CargarListView(lv, "SELECT tra_mov_caja.id_mov_caja, tra_mov_caja.nu_documento, tra_mov_caja.da_fecha, tra_mov_caja.da_hora, mst_entidades.da_descripcion FROM tra_mov_caja INNER JOIN tra_mov_caja_entidad ON tra_mov_caja.id_mov_caja = tra_mov_caja_entidad.id_mov_caja INNER JOIN mst_entidades ON tra_mov_caja_entidad.id_entidad = mst_entidades.id_entidad WHERE id_reg_caja=" & My.Settings.REGCAID & " and da_estatus='P' ORDER BY 1 ")
        For x = 0 To lv.Items.Count - 1
            Dim fecha As String = lv.Items(x).SubItems(2).Text
            MsgBox(fecha)
            'lv.Items(x).SubItems(2).Text = MsgBox
        Next
    End Sub

End Class
