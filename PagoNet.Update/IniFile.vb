Imports System.Runtime.InteropServices
Imports System.Text
Public Class IniFile

    <DllImport("kernel32")>
    Private Shared Function GetPrivateProfileString(ByVal section As String, ByVal key As String, ByVal def As String, ByVal retVal As StringBuilder, ByVal size As Integer, ByVal filePath As String) As Integer
    End Function

    Public Function GetIniValue(ByVal section As String, ByVal key As String, ByVal filename As String, Optional ByVal defaultValue As String = "") As String
        Dim sb As New StringBuilder(500)
        If GetPrivateProfileString(section, key, defaultValue, sb, sb.Capacity, filename) > 0 Then
            Return sb.ToString
        Else
            Return defaultValue
        End If
    End Function
    Public Function DownIniValue(ByVal section As String, ByVal key As String, ByVal downloadRute As String, ByVal filename As String, Optional ByVal defaultValue As String = "") As String
        Dim sb As New StringBuilder(500)
        Dim AppPath As String = System.AppDomain.CurrentDomain.BaseDirectory
        If My.Computer.FileSystem.FileExists(AppPath + "\" + filename) Then
            My.Computer.FileSystem.DeleteFile(AppPath + "\" + filename)
        End If

        My.Computer.Network.DownloadFile(downloadRute, filename)

        If GetPrivateProfileString(section, key, defaultValue, sb, sb.Capacity, AppPath + "\" + filename) > 0 Then
            Return sb.ToString
        Else
            Return defaultValue
        End If
        My.Computer.FileSystem.DeleteFile(AppPath + "\" + filename)
    End Function
End Class
