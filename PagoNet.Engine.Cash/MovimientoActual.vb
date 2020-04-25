Imports System.Data
Imports PagoNet.Database
Imports PagoNet.DataFormats
Imports PagoNet.FormComponents
Imports System.Windows.Forms
Imports System.Drawing
Public Class MovimientoActual
    Dim picService As New PictureBoxService
    Dim lvService As New ListViewService
    Dim Query As New MySqlEasyQuery
    Dim db As New MySqlCommands
    Dim DFormat As New CustomCurrency
    Dim fields As New List(Of String)
    Dim params As New List(Of String)
    Dim values As New List(Of String)
    Dim dt As New DataTable
    Dim bool As Boolean = False
    Dim ObListV As New ListViewService
    Dim _id_articulo As Integer
    Dim _da_titulo, _descripcion As String
    Dim _is_facturable, _is_granel As Boolean
    Dim _precio, _pfinal, _pcantidad, _punitario, _impuesto As Decimal

    Sub Cargar_Logo(ByVal PicBox As PictureBox)
        Query.SetCriteria("id_empresa", 1)
        Query.SetTable("mst_empresas")
        Dim imag As Byte()
        imag = Query.EasyConsultImg("img_logo")
        PicBox.Image = picService.Bytes_Imagen(imag)
    End Sub

    Private Sub CargaLv(ByVal lv As ListView)
        lvService.CargarListView(lv, "SELECT tra_mov_caja_detalle.id_mov_detalle, mst_articulo.co_articulo, mst_articulo.da_titulo, tra_mov_caja_detalle.da_cantidad,tra_mov_caja_detalle.mo_articulo, tra_mov_caja_detalle.po_descuento, tra_mov_caja_detalle.mo_detalle FROM mst_articulo INNER JOIN tra_mov_caja_detalle ON tra_mov_caja_detalle.id_articulo = mst_articulo.id_articulo WHERE tra_mov_caja_detalle.id_mov_caja=" & My.Settings.MOVCAID)
        If lv.Items.Count <> 0 Then
            For x = 0 To lv.Items.Count - 1
                lv.Items(x).SubItems(4).Text = Format(CType(lv.Items(x).SubItems(4).Text, Decimal), "#,##0.00")
                lv.Items(x).SubItems(6).Text = Format(CType(lv.Items(x).SubItems(6).Text, Decimal), "#,##0.00")
            Next
        End If
    End Sub

    Private Function CheckNullBoolean(ByVal value As Boolean)
        Dim valor As Boolean = False
        If value.ToString <> String.Empty Then
            valor = value
        End If
        Return valor
    End Function

    Function BuscarPorCodigo(ByVal _codigo As String)
        If CheckCodigo(_codigo) = True Then
            dt.Clear()
            dt = ArticuloInfo(_codigo)
            If dt.Rows.Count <> 0 Then
                _id_articulo = dt.Rows(0)(0).ToString
                _da_titulo = dt.Rows(0)(1).ToString
                _descripcion = dt.Rows(0)(2).ToString
                _is_facturable = CheckNullBoolean(dt.Rows(0)(3))
                _is_granel = CheckNullBoolean(dt.Rows(0)(4))
                _precio = getPrecio(_id_articulo)
                _impuesto = getImpuesto(_id_articulo)
                dt.Clear()
                dt.Columns.Add("1")
                dt.Columns.Add("2")
                Dim dr As DataRow
                dr = dt.NewRow
                If _is_granel = True Then
                    _da_titulo = _da_titulo + " [Gramos]"
                End If
                dr("1") = _da_titulo
                dr("2") = Format(CType(_precio, Decimal), "#,##0.00")
                dt.Rows.Add(dr)
            End If
        End If
        Return dt
    End Function

    Function CalcMonto(ByVal pcantidad As String)
        Dim cant As Decimal = 0
        If pcantidad <> String.Empty Then
            cant = CType(pcantidad.Replace(".", ","), Decimal)
        End If

        If _is_granel = True Then
            Dim porctajeunitario As Double
            porctajeunitario = _precio * getImpuesto(_id_articulo)
            _punitario = _precio - porctajeunitario
            _pfinal = cant * _punitario / 1000
        Else
            Dim porctajeunitario As Double
            porctajeunitario = _precio * getImpuesto(_id_articulo)
            _punitario = _precio - porctajeunitario
            _pfinal = _punitario * cant
        End If

        _pcantidad = cant
        dt.Clear()
        dt.Columns.Add("1")
        dt.Columns.Add("2")
        Dim dr2 As DataRow
        dr2 = dt.NewRow
        dr2("1") = Format(CType(_punitario, Decimal), "#,##0.00")
        'dr2("2") = DFormat.MoneyFormat(_pfinal, ".", ",")
        dr2("2") = Format(CType(_pfinal, Decimal), "#,##0.00")
        _pfinal = Format(CType(_pfinal, Decimal), "#,##0.00")
        _punitario = Format(CType(_punitario, Decimal), "#,##0.00")
        _precio = Format(CType(_precio, Decimal), "#,##0.00")
        dt.Rows.Add(dr2)
        Return dt
    End Function

    Private Function CheckCodigo(ByVal _codigo)
        If _codigo <> String.Empty Then
            fields.Clear()
            fields.Add("id_articulo")
            Query.SetCriteria("co_articulo", _codigo)
            Query.SetTable("mst_articulo")
            dt = Query.EasyConsult(fields)
            If dt.Rows.Count <> 0 Then
                _id_articulo = dt.Rows(0)(0).ToString
                bool = True
            End If
        End If
        Return bool
    End Function

    Function GuardarDetalle(ByVal lv As ListView)
        If SetDetalleMov() = True Then
            CargaLv(lv)
            bool = True
        End If
        Return bool
    End Function

    Private Function getPrecio(ByVal _articulo As Integer)
        fields.Clear()
        fields.Add("mo_precio")
        Query.SetCriteria("id_articulo", _articulo)
        Query.SetCriteria("is_default", 1)
        Query.SetCriteria("da_estatus", "A")
        Query.SetTable("tab_articulo_precio")
        dt = Query.EasyConsult(fields)
        Return dt.Rows(0)(0).ToString
    End Function

    Private Function getImpuesto(ByVal _articulo As Integer)
        fields.Clear()
        fields.Add("mo_impuesto")
        Query.SetCriteria("id_articulo", _articulo)
        Query.SetCriteria("is_default", 1)
        Query.SetCriteria("da_estatus", "A")
        Query.SetTable("tab_articulo_impuesto")
        dt = Query.EasyConsult(fields)
        If dt.Rows.Count <> 0 Then
            Return dt.Rows(0)(0).ToString
        Else
            Return Nothing
        End If
    End Function
    Private Function ArticuloInfo(ByVal _codigo As String)
        fields.Clear()
        fields.Add("id_articulo")
        fields.Add("da_titulo")
        fields.Add("da_descripcion")
        fields.Add("is_facturable")
        fields.Add("is_granel")
        Query.SetCriteria("co_articulo", _codigo)
        Query.SetTable("mst_articulo")
        dt = Query.EasyConsult(fields)
        Return dt
    End Function
    Sub BuscarPorNombre(ByVal _nombre As String, ByVal lv As ListView)
        ObListV.CargarListView(lv, "SELECT mst_articulo.id_articulo, mst_articulo.co_articulo, mst_articulo.da_titulo, tab_articulo_precio.mo_precio FROM mst_articulo, tab_articulo_precio WHERE tab_articulo_precio.id_articulo=mst_articulo.id_articulo AND tab_articulo_precio.is_default=1 AND tab_articulo_precio.da_estatus='A' AND mst_articulo.is_facturable=1 AND mst_articulo.da_titulo LIKE '%" & _nombre & "%'")
    End Sub

    Private Function SetDetalleMov()
        params.Clear()
        params.Add("id_mov_caja")
        params.Add("id_articulo")
        params.Add("da_cantidad")
        params.Add("po_descuento")
        params.Add("mo_precio")
        params.Add("mo_articulo")
        params.Add("mo_detalle")
        params.Add("da_estatus")
        values.Clear()
        values.Add(My.Settings.MOVCAID)
        values.Add(_id_articulo)
        values.Add(_pcantidad)
        values.Add("")
        values.Add(_precio.ToString.Replace(",", "."))
        values.Add(_punitario.ToString.Replace(",", "."))
        values.Add(_pfinal.ToString.Replace(",", "."))
        values.Add("A")
        Query.SetTable("tra_mov_caja_detalle")
        If Query.EasyInsert(params, values) = True Then
            Return True
        Else
            Return False
        End If
    End Function

    'Sub Guardar_logo(ByVal picbox As PictureBox)
    '    Dim filename As String
    '    Dim openfiler As New OpenFileDialog
    '    'Definiendo propiedades al openfiledialog
    '    With openfiler
    '        'directorio inicial
    '        .InitialDirectory = "C:\"
    '        'archivos que se pueden abrir
    '        .Filter = "Archivos de imágen(All Files (*.*)|*.*"
    '        'indice del archivo de lectura por defecto
    '        .FilterIndex = 1
    '        'restaurar el directorio al cerrar el dialogo
    '        .RestoreDirectory = True
    '    End With
    '    '
    '    'Evalua si el usuario hace click en el boton abrir
    '    If openfiler.ShowDialog = Windows.Forms.DialogResult.OK Then
    '        'Obteniendo la ruta completa del archivo xml
    '        filename = openfiler.FileName
    '        picbox.Image = Image.FromFile(filename)
    '    End If


    '    Query.SetTable("mst_empresas")
    '    Query.SetCriteria("id_empresa", 1)
    '    Query.UpdateImg("img_logo", picService.Imagen_Bytes(picbox.Image))
    'End Sub

End Class
