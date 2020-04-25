Imports System.Data
Imports PagoNet.Engine.Cash

Public Class win_terminal
    Public InCheckArticle As Boolean = False
    Dim eng As New MovimientoActual
    Dim dt As New datatable


    Private Sub win_terminal2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode And Not Keys.Modifiers) = Keys.N AndAlso e.Modifiers = Keys.Alt Then
            win_cliente.ShowDialog()
        ElseIf (e.KeyCode And Not Keys.Modifiers) = Keys.X AndAlso e.Modifiers = Keys.Alt Then

        End If
    End Sub


    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        Application.Exit()

    End Sub

    Private Sub win_terminal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        eng.Cargar_Logo(PictureBox1)
    End Sub

    Private Sub btn_eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_eliminar.Click

    End Sub

    Private Sub btn_buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.Click
        win_busqueda.ShowDialog()
    End Sub

    Private Sub txtcodigo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcodigo.LostFocus
        ConsultaArticulo()
    End Sub

    Public Sub ConsultaArticulo()
        If InCheckArticle = False Then
            If txtdescripcion.Text = String.Empty Then
                If txtcodigo.Text <> String.Empty Then
                    InCheckArticle = True
                    dt = eng.BuscarPorCodigo(txtcodigo.Text)
                    For Each item As DataRow In dt.Rows
                        txtdescripcion.Text = item(0).ToString
                        txtprecio.Text = item(1).ToString
                    Next
                    If txtdescripcion.Text <> String.Empty Then
                        txtcodigo.Enabled = False
                        txtdescripcion.Enabled = False
                        txtcantidad.Enabled = True
                        txtcantidad.Focus()
                    End If
                End If
                
            End If
        End If
    End Sub

    Private Sub ActualizarSifras()
        If InCheckArticle = True Then
            Dim total As Decimal
            If lv_detalles.Items.Count <> 0 Then
                For x = 0 To lv_detalles.Items.Count - 1
                    total += lv_detalles.Items(x).SubItems(6).Text
                Next
                btnTotalizar.Enabled = True
            End If
            lbl_total.Text = Format(CType(total, Decimal), "#,##0.00") + " Bs. S"
            lbl_cantidad.Text = "Total de Productos: " & vbCr & "Total de Lineas: " & lv_detalles.Items.Count.ToString
            txtcantidad.Clear()
            txtdescripcion.Clear()
            txtcodigo.Clear()
            txtcodigo.Enabled = True
            txtdescripcion.Enabled = True
            txtcantidad.Enabled = False
            txtcodigo.Focus()
            txtprecio.Clear()
            txtpunitario.Clear()
            txtsubtotal.Clear()

        End If
    End Sub

    Private Sub getMontos()
        dt = eng.CalcMonto(txtcantidad.Text)
        txtpunitario.Text = dt.Rows(0)(0).ToString
        txtsubtotal.Text = dt.Rows(0)(1).ToString
    End Sub

    Private Sub txtcantidad_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcantidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            getMontos()
            If eng.GuardarDetalle(lv_detalles) = True Then
                ActualizarSifras()
                InCheckArticle = False
            End If
        End If
    End Sub

    Private Sub txtcantidad_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcantidad.LostFocus
        getMontos()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Process.Start("calc.exe")
    End Sub

    Private Sub btn_precios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_precios.Click
        win_precios.ShowDialog()
    End Sub

    Private Sub btnTotalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTotalizar.Click
        win_tipo_pago.ShowDialog()
    End Sub

    Private Sub btn_cargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cargar.Click
        win_carga.ShowDialog()
    End Sub
End Class