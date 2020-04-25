Imports PagoNet.Engine.Cash
Imports PagoNet.FormComponents
Imports System.Data
Public Class win_cliente
    Dim FrmDat As New FormDataManager
    Dim Eng As New VeficarCliente
    Dim dt As New datatable
    Dim _desc, _direccion, _numero As String
    Dim _dni As Integer
    Dim CheckClient As Boolean = False

    Private Sub txtPrefetc(ByVal txt As TextBox, ByVal Texto As String, Optional ByVal disable As Boolean = False)
        txt.BackColor = Color.LemonChiffon
        txt.Text = Texto
        txt.Enabled = disable
    End Sub

    Private Sub txtFix(ByVal txt As TextBox, Optional ByVal disable As Boolean = True)
        txt.BackColor = Color.White
        txt.Enabled = disable
        txt.Clear()
    End Sub
    Sub GetFormData()
        Dim data As String
        data = FrmDat.Serialize(Me)
        _dni = FrmDat.Value(data, "txtdni")
        _desc = FrmDat.Value(data, "txtdesc")
        If FrmDat.Value(data, "txtnumero") = String.Empty Then
            _numero = "null"
        Else
            _numero = FrmDat.Value(data, "txtnumero")
        End If
        _direccion = FrmDat.Value(data, "txtdireccion")
    End Sub

    Private Sub Procesar()
        'MsgBox(Eng.ProcesarMovClient)
        If Eng.ProcesarMovClient = True Then
            win_terminal.lv_detalles.Enabled = True
            win_terminal.txtdescripcion.Enabled = True
            win_terminal.txtcodigo.Enabled = True
            win_terminal.lbl_numdoc.Text = Eng.NumDoc.ToString.PadLeft(20, "0")
            dt = Eng.GetClientInfo()
            For Each dr As DataRow In dt.Rows
                win_terminal.lbl_da_cliente.Text = dr(0).ToString
                win_terminal.lbl_nu_dni.Text = txtdni.Text
            Next
            txtFix(txtdni)
            txtFix(txtdesc)
            txtFix(txtnumero)
            txtFix(txtdireccion)
            win_terminal.txtcodigo.Focus()
            Me.Close()
        End If
    End Sub

    Private Sub btnAceptar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        'win_terminal.lv_detalles.Enabled = True
        If CheckClient = False Then
            GetFormData()
            If Eng.CreateClient(_dni, _desc, _numero, _direccion) = True Then
                txtPrefetc(txtdesc, txtdesc.Text)
                txtPrefetc(txtnumero, txtnumero.Text)
                txtPrefetc(txtdireccion, txtdireccion.Text)
                txtPrefetc(txtdni, txtdni.Text)
                txtdni.Focus()
                Procesar()
            End If
        Else
            Procesar()
        End If
    End Sub

    Private Sub txtdni_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtdni.LostFocus

        If txtdni.Text <> String.Empty Then
            If Eng.CheckDni(txtdni.Text) = True Then
                dt = Eng.GetClientInfo()
                For Each dr As DataRow In dt.Rows
                    txtPrefetc(txtdesc, dr(0).ToString)
                    txtPrefetc(txtnumero, dr(1).ToString)
                    txtPrefetc(txtdireccion, dr(2).ToString)
                    txtPrefetc(txtdni, txtdni.Text)
                    CheckClient = True
                Next
            Else
                CheckClient = False
            End If
        End If

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class