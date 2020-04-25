Imports System.IO
Imports System.IO.Compression
Imports System.IO.Compression.ZipFile
Imports System.Threading.Tasks
Imports System.Net

Public Class update
   

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.Location = New Point(My.Computer.Screen.WorkingArea.Width * 2, My.Computer.Screen.WorkingArea.Height * 2)

        Dim AppPath As String = System.AppDomain.CurrentDomain.BaseDirectory
        Dim rutaExecutable As String = ""
        Dim KeyFind As String = ""
        Dim ExecFind As String = ""
        Dim AppFind As String = ""
        Dim inif As New IniFile



        If My.Computer.FileSystem.FileExists(System.IO.Path.Combine(AppPath, "PagoNet.Cash.exe")) Then
            rutaExecutable = System.IO.Path.Combine(AppPath, "PagoNet.Cash.exe")
            AppFind = "PagoNet.Cash"
            ExecFind = "PagoNet.Cash.exe"
            KeyFind = "PNCashVersion"
        ElseIf My.Computer.FileSystem.FileExists(System.IO.Path.Combine(AppPath, "PagoNet.Administrativo.exe")) Then
            rutaExecutable = System.IO.Path.Combine(AppPath, "PagoNet.Administrativo.exe")
            AppFind = "PagoNet.Administrativo"
            ExecFind = "PagoNet.Administrativo.exe"
            KeyFind = "PNAdminVersion"
        End If
        'MsgBox("Exe a actualizar -> " + AppFind + " key=" + KeyFind)
        If ExecFind <> String.Empty Then
            Dim newVersion As String = inif.DownIniValue("Update", KeyFind, "http://localhost/update/update.ini", "update.ini")
            Dim oldversion As String = System.Diagnostics.FileVersionInfo.GetVersionInfo(rutaExecutable).FileVersion()

            If My.Computer.FileSystem.FileExists(AppPath + "\update.ini") Then
                My.Computer.FileSystem.DeleteFile(AppPath + "\update.ini")
            End If

            'MsgBox(newVersion + " > " + oldversion)

            If newVersion <> String.Empty Then
                If newVersion > oldversion Then

                    'MsgBox("Descargando nueva Version " & newVersion)
                    Dim downZip As String = newVersion + ".zip"

                    If My.Computer.FileSystem.FileExists(AppPath + downZip) Then
                        My.Computer.FileSystem.DeleteFile(AppPath + downZip)
                    End If

                    Dim fileDown As String = "http://localhost/update/lasted/" & AppFind & "." & newVersion & ".zip"

                    My.Computer.Network.DownloadFile(fileDown, downZip)
                    Unzip(downZip)
                    Process.Start(ExecFind)
                    Application.Exit()
                End If
            Else
                Application.Exit()
            End If
        End If
        Application.Exit()
    End Sub

    Sub Unzip(ByVal zip As String)
        Dim zipPath As String = zip
        Dim extractPath As String = System.AppDomain.CurrentDomain.BaseDirectory
        ' Normalizes the path.
        extractPath = Path.GetFullPath(extractPath)
        ' Ensures that the last character on the extraction path
        ' is the directory separator char. 
        ' Without this, a malicious zip file could try to traverse outside of the expected
        ' extraction path.
        If Not extractPath.EndsWith(Path.DirectorySeparatorChar) Then
            extractPath += Path.DirectorySeparatorChar
        End If

        Using archive As ZipArchive = ZipFile.OpenRead(zipPath)
            For Each entry As ZipArchiveEntry In archive.Entries
                ' Gets the full path to ensure that relative segments are removed.
                Dim destinationPath As String = Path.GetFullPath(Path.Combine(extractPath, entry.FullName))
                ' Ordinal match is safest, case-sensitive volumes can be mounted within volumes that
                ' are case-insensitive.
                If destinationPath.StartsWith(extractPath, StringComparison.Ordinal) Then
                    entry.ExtractToFile(destinationPath, True)
                End If
            Next
        End Using
        My.Computer.FileSystem.DeleteFile(zip)
    End Sub

End Class
