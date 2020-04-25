Imports PagoNet.Engine.Cash

Public Class win_busqueda
    Dim eng As New MovimientoActual
    Private Sub txt_codigo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_codigo.TextChanged
        eng.BuscarPorNombre(txt_codigo.Text, ListView1)
        If ListView1.Items.Count <> 0 Then
            For x = 0 To ListView1.Items.Count - 1
                ListView1.Items(x).SubItems(3).Text = Format(CType(ListView1.Items(x).SubItems(3).Text, Decimal), "#,##0.00")
            Next
        End If
        If txt_codigo.Text = String.Empty Then
            ListView1.Items.Clear()
        End If
    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        SendCode()
    End Sub

    Private Sub SendCode()
        If ListView1.SelectedItems.Count <> 0 Then
            If ListView1.SelectedItems(0).Selected Then
                win_terminal.txtdescripcion.Clear()
                win_terminal.txtcodigo.Text = ListView1.SelectedItems(0).SubItems(1).Text
                win_terminal.txtcodigo.Enabled = False
                win_terminal.txtdescripcion.Enabled = False
                win_terminal.ConsultaArticulo()
                win_terminal.txtcantidad.Focus()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub win_busqueda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub win_busqueda_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If win_terminal.txtdescripcion.Text <> String.Empty Then
            If win_terminal.InCheckArticle = False Then
                txt_codigo.Text = win_terminal.txtdescripcion.Text
            End If
        Else
            txt_codigo.Clear()
            ListView1.Items.Clear()
            txt_codigo.Focus()
        End If
        txt_codigo.Focus()
    End Sub

    
    Private Sub ListView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ListView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendCode()
        End If
    End Sub
End Class