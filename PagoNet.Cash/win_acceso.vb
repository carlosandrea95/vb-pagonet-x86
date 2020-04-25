Imports PagoNet.FormComponents
Imports PagoNet.Engine

Public Class win_acceso
    Dim Auth As New ControlAcceso
    Dim NewPass As Boolean = False

    Sub ClearUpdate(ByVal AppPath As String)
        'MsgBox(AppPath + "PagoNet.Update2.exe")
        If My.Computer.FileSystem.FileExists(AppPath + "PagoNet.Update2.exe") = True Then
            If My.Computer.FileSystem.FileExists(AppPath + "PagoNet.Update.exe") = True Then
                'MsgBox(My.Computer.FileSystem.FileExists(AppPath + "PagoNet.Update.exe"))
                My.Computer.FileSystem.DeleteFile(AppPath + "PagoNet.Update.exe")
            End If
            My.Computer.FileSystem.RenameFile(AppPath + "PagoNet.Update2.exe", "PagoNet.Update.exe")

        End If
    End Sub

    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim AppPath As String = System.AppDomain.CurrentDomain.BaseDirectory
        ClearUpdate(AppPath)
        Txt_Usuario.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim fd As New FormDataManager
        Dim data = fd.Serialize(Me)
        Dim Username, Password, RePassword As String
        Username = fd.Value(data, "Txt_Usuario")
        Password = fd.Value(data, "Txt_Clave")
        RePassword = fd.Value(data, "Txt_ReClave")
        Dim Response = Auth.CanLogin(Username, Password, RePassword)
        If Response = "GRANTED" Then
            Dim Win As New win_apuertura
            Auth.SetPermissionsByRol(Win)
            Me.Close()
        ElseIf Response = "OLDPASS" Then
            MsgBox("Por medidas de seguridad debe actualizar su contraseña.", MsgBoxStyle.Information, My.Application.Info.Title)
            Label3.Show()
            Txt_ReClave.Show()
            Txt_Clave.Clear()
            Txt_Clave.Focus()
            NewPass = True
        ElseIf Response = "GRONDPASS" Then
            MsgBox("La contraseña proporcionada no coincide, intente nuevamente.", MsgBoxStyle.Information, My.Application.Info.Title)
            Txt_ReClave.Clear()
            Txt_Clave.Clear()
            Txt_Clave.Focus()
        ElseIf Response = "FAILED" Then
            MsgBox("El usuario y/o contraseña invalidos, intente nuevamente.", MsgBoxStyle.Information, My.Application.Info.Title)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub
End Class