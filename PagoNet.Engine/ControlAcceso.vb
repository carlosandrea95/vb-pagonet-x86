Imports System.Data
Imports PagoNet.Database
Imports System.Windows.Forms
Imports PagoNet.Cryptographers

Public Class ControlAcceso
    Dim EQuery As New MySqlEasyQuery
    Dim Crypto As New CryptoService

    Function CanLogin(ByVal Username As String, ByVal Password As String, ByVal RePassword As String)

        Try
            Dim dt As New DataTable
            Dim fields As New List(Of String)
            Dim Response As String = "FAILED"
            EQuery.SetTable("sys_usuarios")
            fields.Add("id_usuario")
            fields.Add("is_cambio_clave")
            EQuery.SetCriteria("co_usuario", Username)
            dt = EQuery.EasyConsult(fields)
            For Each dr As DataRow In dt.Rows
                If dr(0).ToString <> String.Empty Then
                    My.Settings.USERID = dr(0).ToString
                    My.Settings.Save()
                    My.Settings.Reload()
                    If dr(1).ToString = True Then
                        If RePassword <> String.Empty Then
                            If Password = RePassword Then
                                EQuery.BindParam("is_cambio_clave", False)
                                EQuery.BindParam("co_clave", Crypto.Encrypt(Password))
                                EQuery.SetCriteria("id_usuario", My.Settings.USERID)
                                EQuery.EasyUpdate()
                                Return Verif(Username, Password)
                            Else
                                Response = "GRONDPASS"
                            End If
                        Else
                            Response = "OLDPASS"
                        End If
                    Else
                        Return Verif(Username, Password)
                    End If

                End If
            Next
            Return Response
        Catch ex As Exception
            Return (MsgBox("Se ha producido un error inesperado" + " | " + ex.Message, MsgBoxStyle.Critical))
        End Try

    End Function

    Function isAllowable(ByVal Ctrl As Control)
        Dim fields As New List(Of String)
        Dim bool As Boolean = False
        Dim dt As New DataTable

        fields.Clear()
        fields.Add("id_permiso_rol")
        fields.Add("co_permiso")
        fields.Add("is_allowable")
        EQuery.SetTable("vw_permisos_roles")
        EQuery.SetCriteria("id_rol=(SELECT id_rol FROM sys_usuarios WHERE id_usuario", My.Settings.USERID, ")")
        dt = EQuery.EasyConsult(fields)
        For Each dr As DataRow In dt.Rows
            If dr(0).ToString <> String.Empty Then
                If Ctrl.Name = dr(1).ToString Then
                    If dr(2).ToString = True Then
                        bool = True
                    Else
                        bool = False
                    End If
                End If
            End If
        Next
        Return bool
    End Function


    Private Function Verif(ByVal Username As String, ByVal Password As String)

        'My.Settings.REGCAID = 0
        'My.Settings.TURNOID = 0
        'My.Settings.MOVCAID = 0
        'My.Settings.CLIENTID = 0
        'My.Settings.Save()
        'My.Settings.Reload()

        Try
            Dim dt As New DataTable
            Dim fields As New List(Of String)
            Dim Response As String = "FAILED"
            fields.Add("id_usuario")
            fields.Add("co_usuario")
            fields.Add("co_clave")
            EQuery.SetCriteria("co_usuario", Username)
            EQuery.SetCriteria("co_clave", Crypto.Encrypt(Password))
            dt = EQuery.EasyConsult(fields)
            For Each dr As DataRow In dt.Rows
                If dr(0).ToString <> String.Empty Then
                    My.Settings.USERID = dr(0).ToString
                    Response = "GRANTED"
                End If
            Next
            Return Response
        Catch ex As Exception
            Return MsgBox("ERROR " + ex.ToString + " | " + ex.Message, MsgBoxStyle.Critical)
        End Try
    End Function

    Sub SetPermissionsByRol(ByVal Win As Form)
        Dim RtrControl As New Control
        Try
            Dim Ctrl As Control
            For x = Win.Controls.Count - 1 To 0 Step -1
                Ctrl = Win.Controls.Item(x)
                If TypeOf (Ctrl) Is GroupBox Then
                    For Each GCtrl As Control In Ctrl.Controls
                        SetPermissionRol(GCtrl)
                    Next
                ElseIf TypeOf (Ctrl) Is Panel Then
                    For Each PCtrl As Control In Ctrl.Controls
                        SetPermissionRol(PCtrl)
                    Next
                ElseIf TypeOf Ctrl Is MenuStrip Then
                    'GetMenuStripElements(Ctrl)
                Else
                    SetPermissionRol(Ctrl)
                End If
            Next
            Win.Show()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            MsgBox("Se ha producido un error inesperado' | " + ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


    Private Sub SetPermissionRol(ByVal ctrl As Control)
        Dim dt, data As New DataTable
        Dim fields As New List(Of String)
        fields.Add("id_permiso_rol")
        fields.Add("co_permiso")
        fields.Add("is_usable")
        fields.Add("is_visible")
        EQuery.SetTable("vw_permisos_roles")
        EQuery.SetCriteria("id_rol=(SELECT id_rol FROM sys_usuarios WHERE id_usuario", My.Settings.USERID, ")")
        dt = EQuery.EasyConsult(fields)
        For Each dr As DataRow In dt.Rows
            If dr(0).ToString <> String.Empty Then
                If ctrl.Name = dr(1).ToString Then
                    SetAttrPermissions(ctrl, dr(2).ToString, dr(3).ToString)
                End If
            End If
        Next
    End Sub
    Private Sub SetPermissionRolMenu(ByVal item As ToolStripMenuItem)
        Dim dt, data As New DataTable
        Dim fields As New List(Of String)
        fields.Add("id_permiso_rol")
        fields.Add("co_permiso")
        fields.Add("is_usable")
        fields.Add("is_visible")
        EQuery.SetTable("vw_permisos_roles")
        EQuery.SetCriteria("id_rol=(SELECT id_rol FROM sys_usuarios WHERE id_usuario", My.Settings.USERID, ")")
        dt = EQuery.EasyConsult(fields)
        For Each dr As DataRow In dt.Rows
            If dr(0).ToString <> String.Empty Then
                If item.Name = dr(1).ToString Then
                    SetAttrPermissionsMenuItem(item, dr(2).ToString, dr(3).ToString)
                End If
            End If
        Next
    End Sub
    Private Sub SetAttrPermissionsMenuItem(ByVal Ctrl As ToolStripMenuItem, ByVal Enabled As Boolean, ByVal visible As Boolean)
        Ctrl.Enabled = Enabled
        Ctrl.Visible = visible
    End Sub
    Private Sub SetAttrPermissions(ByVal Ctrl As Control, ByVal Enabled As Boolean, ByVal visible As Boolean)
        Ctrl.Enabled = Enabled
        Ctrl.Visible = visible
    End Sub

    Private Sub SetMenuPermissionsByRol(ByVal ToolItem As ToolStripMenuItem)
        Dim dt, data As New DataTable
        Dim fields As New List(Of String)
        fields.Add("id_permiso_rol")
        fields.Add("co_permiso")
        fields.Add("is_usable")
        fields.Add("is_visible")
        EQuery.SetTable("vw_permisos_roles")
        EQuery.SetCriteria("id_rol=(SELECT id_rol FROM sys_usuarios WHERE id_usuario", My.Settings.USERID, ")")
        dt = EQuery.EasyConsult(fields)
        For Each row As DataRow In dt.Rows
            If row(0).ToString <> String.Empty Then
                'MsgBox(row(0).ToString + " 1>" + row(1).ToString + " 2>" + row(2).ToString + " 3>" + row(3).ToString)
                If ToolItem.Name = row(1).ToString Then
                    If row(2).ToString = True Then
                        ToolItem.Enabled = True
                    ElseIf row(2).ToString = Nothing Then
                        ToolItem.Enabled = False
                    Else
                        ToolItem.Enabled = False
                    End If
                    If row(3).ToString = True Then
                        ToolItem.Visible = True
                    ElseIf row(3).ToString = Nothing Then
                        ToolItem.Enabled = False
                    Else
                        ToolItem.Visible = False
                    End If
                End If
            End If

        Next
    End Sub

    Sub GetMenuStripElements(ByVal Ctrl As Control)
        If TypeOf Ctrl Is MenuStrip Then
            Dim mCtrl As MenuStrip = Ctrl
            For Each mitem As ToolStripMenuItem In mCtrl.Items
                'MsgBox(mitem.Name + " linea 1")
                GetItemElements(mitem)
                SetMenuPermissionsByRol(mitem)
            Next
        End If
    End Sub

    Sub GetItemElements(ByVal item As ToolStripMenuItem)
        If item.DropDownItems.Count > 0 Then
            For Each ditem As ToolStripMenuItem In item.DropDownItems
                'MsgBox(ditem.Name + " linea 2")
                GetItemElements(ditem)
                SetMenuPermissionsByRol(ditem)
            Next
        Else
        End If
    End Sub


End Class
