Imports System.Data
Imports PagoNet.Database
Imports PagoNet.FormComponents
Imports System.Windows.Forms

Public Class AperturaCaja
    Dim CombService As New ComboBoxService
    Dim DTGService As New DataGridViewService
    Dim EQuery As New MySqlEasyQuery
    Dim params As New List(Of String)
    Dim values As New List(Of String)
    Dim fields As New List(Of String)
    Dim dt As New DataTable

    Sub GetMonedas(ByVal DTG As DataGridView)
        DTGService.CargaComboBoxElements(DTG, 1, "SELECT id_moneda,da_descripcion,is_predeterminado FROM mst_moneda WHERE da_estatus='A' ORDER BY 3 DESC,1")
    End Sub

    Sub GetCajaro(ByVal lbl_cashier As Label)
        Dim dt As New DataTable
        Dim field As New List(Of String)
        field.Add("co_usuario")
        EQuery.SetTable("sys_usuarios")
        'MsgBox(My.Settings.USERID)
        EQuery.SetCriteria("id_usuario", My.Settings.USERID)
        dt = EQuery.EasyConsult(field)
        For Each dr As DataRow In dt.Rows
            lbl_cashier.Text = dr(0).ToString.ToUpper
        Next
    End Sub

    Sub GetCajas(ByVal Comb As ComboBox)
        Try
            CombService.CargarComboBox(Comb, "SELECT id_caja,da_descripcion FROM `mst_caja` WHERE da_estatus='Z' and da_tipo_caja='E'")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Sub GetTurno(ByVal Comb As ComboBox)
        Try
            CombService.CargarComboBox(Comb, "SELECT id_turno, da_descripcion FROM tab_turno WHERE da_estatus='A'")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub GetTurnoHorario(ByVal SelectedValue As String, ByVal lbl_de As Label, ByVal lbl_hasta As Label)
        Try
            Dim itemSelect = SelectedValue
            Dim dt As New DataTable
            fields.Clear()
            fields.Add("DATE_FORMAT(ho_inicio,'%h:%i %p')")
            fields.Add("DATE_FORMAT(ho_fin,'%h:%i %p')")
            EQuery.SetCriteria("id_turno", itemSelect)
            EQuery.SetTable("tab_turno")
            dt = EQuery.EasyConsult(fields)
            For Each dr As DataRow In dt.Rows
                lbl_de.Text = dr(0).ToString
                lbl_hasta.Text = dr(1).ToString
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Function IsCajaAbierta()
        If My.Settings.TURNOID = True Then
            Return False
        End If
        Return False
    End Function

    Function CheckApertura()
        If My.Settings.REGCAID <> 0 Then
            Return True
        End If
        Return False
    End Function

    Function ProcesarApertura(ByVal CajaId As String, ByVal TurnoId As String, ByVal DTG As DataTable)
        Dim bool As Boolean = False
        If DTG.Rows.Count <> 0 Then
            fields.Add("id_reg_caja")
            EQuery.SetCriteria("id_caja", CajaId)
            EQuery.SetCriteria("da_estatus", "A")
            EQuery.SetTable("tab_reg_caja")
            dt = EQuery.EasyConsult(fields)
            If dt.Rows.Count = 0 Then
                If setRegCaja(CajaId) = True Then
                    If setMstApertura(CajaId) = True Then
                        setMovIncial(getRegCaja(CajaId), TurnoId)
                        setFondo(DTG, getMovCaja(getRegCaja(CajaId)))
                        My.Settings.TURNOID = TurnoId
                        My.Settings.REGCAID = getMovCaja(getRegCaja(CajaId))
                        My.Settings.Save()
                        My.Settings.Reload()
                        bool = True
                    End If
                End If
            End If
            Return bool
        Else
            Return MsgBox("No se puede procesar la apertura por fondos inical insuficiente.", MsgBoxStyle.Information, "Sistema")
        End If
    End Function

    Private Function setRegCaja(ByVal CajaId)
        EQuery.SetTable("tab_reg_caja")
        params.Add("id_caja")
        params.Add("da_hora")
        params.Add("da_fecha")
        params.Add("da_estatus")
        values.Add(CajaId)
        values.Add(Now.ToString("HH:mm:ss"))
        values.Add(Now.ToString("yyyy-MM-dd"))
        values.Add("A")
        If EQuery.EasyInsert(params, values) = True Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function setMstApertura(ByVal CajaId As Integer)
        EQuery.SetTable("mst_caja")
        EQuery.BindParam("da_estatus", "A")
        EQuery.SetCriteria("id_caja", CajaId)
        If EQuery.EasyUpdate() = True Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function getRegCaja(ByVal CajaId As Integer)
        fields.Clear()
        fields.Add("id_reg_caja")
        EQuery.SetCriteria("id_caja", CajaId)
        EQuery.SetCriteria("da_estatus", "A")
        EQuery.SetTable("tab_reg_caja")
        dt = EQuery.EasyConsult(fields)
        Return dt.Rows(0)(0).ToString
    End Function

    Private Function getMovCaja(ByVal RegCaja As Integer)
        fields.Clear()
        fields.Add("id_mov_caja")
        EQuery.SetCriteria("id_reg_caja", RegCaja)
        EQuery.SetCriteria("da_estatus", "A")
        EQuery.SetTable("tra_mov_caja")
        dt = EQuery.EasyConsult(fields)
        Return dt.Rows(0)(0).ToString
    End Function

    Private Function setMovIncial(ByVal RegCaja As Integer, ByVal TurnoId As Integer)
        EQuery.SetTable("tra_mov_caja")
        params.Clear()
        params.Add("id_reg_caja")
        params.Add("da_tipo_mov")
        params.Add("da_fecha")
        params.Add("da_hora")
        params.Add("id_cajero")
        params.Add("id_turno")
        params.Add("da_estatus")
        values.Clear()
        values.Add(RegCaja)
        values.Add("A")
        values.Add(Now.ToString("yyyy-MM-dd"))
        values.Add(Now.ToString("HH:mm:ss"))
        values.Add(My.Settings.USERID)
        values.Add(TurnoId)
        values.Add("A")
        If EQuery.EasyInsert(params, values) = True Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub setFondo(ByVal DTG As DataTable, ByVal MovCaja As Integer)
        For Each item As DataRow In DTG.Rows
            EQuery.SetTable("tra_mov_caja_inicial")
            params.Clear()
            params.Add("id_mov_caja")
            params.Add("id_moneda")
            params.Add("mo_caja_inicial")
            values.Clear()
            values.Add(MovCaja)
            values.Add(item(1))
            values.Add(item(2))
            If EQuery.EasyInsert(params, values) = True Then
                Continue For
            Else
                MsgBox("Error encontrado al fondear")
            End If
        Next
    End Sub

End Class
