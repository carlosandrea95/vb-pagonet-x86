Imports System.Data
Imports PagoNet.Database
Imports PagoNet.FormComponents
Imports System.Windows.Forms

Public Class VeficarCliente
    Dim EQuery As New MySqlEasyQuery
    Dim params As New List(Of String)
    Dim values As New List(Of String)
    Dim fields As New List(Of String)
    Dim dt As New DataTable
    Dim _dni As Integer

    Function CheckDni(ByVal dni As Integer)
        _dni = dni
        fields.Clear()
        fields.Add("id_entidad")
        EQuery.SetCriteria("nu_documento", dni)
        EQuery.SetTable("mst_entidades")
        dt = EQuery.EasyConsult(fields)
        If dt.Rows.Count <> 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Function GetClientInfo()
        fields.Clear()
        fields.Add("da_descripcion")
        fields.Add("nu_movil")
        fields.Add("da_direccion")
        EQuery.SetCriteria("nu_documento", _dni)
        EQuery.SetTable("mst_entidades")
        dt = EQuery.EasyConsult(fields)
        Return dt
    End Function

    Function CreateClient(ByVal dni As Integer, ByVal desc As String, ByVal nu_movil As String, ByVal direccion As String)
        EQuery.SetTable("mst_entidades")
        params.Clear()
        params.Add("nu_documento")
        params.Add("da_descripcion")
        params.Add("nu_movil")
        params.Add("da_direccion")
        params.Add("da_tipo_entidad")
        values.Clear()
        values.Add(dni)
        values.Add(desc)
        values.Add(nu_movil)
        values.Add(direccion)
        values.Add(1)

        If EQuery.EasyInsert(params, values) = True Then
            Return True
        Else
            Return False
        End If
    End Function


    Function ProcesarMovClient()
        Dim bool As Boolean = False
        If SetMovCa() = True Then
            If SetMovClient() = True Then
                bool = True
            End If
        End If
        Return bool
    End Function

    Private Function getIdEntidad()
        fields.Clear()
        fields.Add("id_entidad")
        EQuery.SetCriteria("nu_documento", _dni)
        EQuery.SetTable("mst_entidades")
        dt = EQuery.EasyConsult(fields)
        Return dt.Rows(0)(0).ToString
    End Function
    Private Function SetMovClient()
        params.Clear()
        params.Add("id_mov_caja")
        params.Add("id_entidad")
        values.Clear()
        values.Add(getMaxMovCaja(My.Settings.REGCAID))
        values.Add(getIdEntidad)
        EQuery.SetTable("tra_mov_caja_entidad")
        If EQuery.EasyInsert(params, values) = True Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Function getNumDoc()
        fields.Clear()
        fields.Add("Max(nu_documento)")
        EQuery.SetCriteria("da_tipo_mov", "F")
        EQuery.SetTable("tra_mov_caja")
        dt = EQuery.EasyConsult(fields)
        'EQuery.CheckQuery()
        Dim numDoc As String = dt.Rows(0)(0).ToString
        If numDoc = String.Empty Then
            numDoc = 1
        Else
            numDoc = numDoc + 1
        End If
        My.Settings.NUMDOC = numDoc
        My.Settings.Save()
        My.Settings.Reload()
        Return numDoc
    End Function

    Function NumDoc()
        Return My.Settings.NUMDOC
    End Function
    Private Function getMaxMovCaja(ByVal RegCaja As Integer)
        fields.Clear()
        fields.Add("MAX(id_mov_caja)")
        EQuery.SetCriteria("id_reg_caja", RegCaja)
        EQuery.SetCriteria("da_estatus", "A")
        EQuery.SetTable("tra_mov_caja")
        dt = EQuery.EasyConsult(fields)
        My.Settings.MOVCAID = dt.Rows(0)(0).ToString
        My.Settings.Save()
        My.Settings.Reload()
        Return dt.Rows(0)(0).ToString
    End Function

    Private Function SetMovCa()
        EQuery.SetTable("tra_mov_caja")
        params.Clear()
        params.Add("id_reg_caja")
        params.Add("da_tipo_mov")
        params.Add("da_fecha")
        params.Add("da_hora")
        params.Add("id_cajero")
        params.Add("id_turno")
        params.Add("da_estatus")
        params.Add("nu_documento")
        values.Clear()
        values.Add(My.Settings.REGCAID)
        values.Add("F")
        values.Add(Now.ToString("yyyy-MM-dd"))
        values.Add(Now.ToString("HH:mm:ss"))
        values.Add(My.Settings.USERID)
        values.Add(My.Settings.TURNOID)
        values.Add("A")
        values.Add(getNumDoc)
        If EQuery.EasyInsert(params, values) = True Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
