Imports MySql.Data.MySqlClient
Imports System.Net

Public Class MySqlLocalConn

    'Private ConnStr As New MySqlConnection("server=" & My.Settings.DBHOST & ";user id=" & My.Settings.DBUSER & ";password=" & My.Settings.DBPASS & ";database=" & My.Settings.DBNAME & ";port=" & My.Settings.DBPORT & "")

    Private ConnStr As New MySqlConnection("server=localhost;user id=root;password=;database=pnet_masterdb;port=3306")

    'abrir una conexion
    Public Sub MySqlConnect()
        Try
            If ConnStr.State <> ConnectionState.Open Then
                ConnStr.Open()
            End If
        Catch ex As Exception
            MsgBox("Error al establecer la conexion (" + ex.Message + ")")
        End Try
    End Sub

    'cerrar una conexion
    Public Sub MySqlDisconnect()
        Try
            If ConnStr.State <> ConnectionState.Closed Then
                ConnStr.Close()
            End If
        Catch ex As Exception
            MsgBox("error al realizar la desconexion (" + ex.Message + ")")
        End Try
    End Sub

    Function ConnTest()
        Try
            MySqlConnect()
            If ConnStr.State = ConnectionState.Open Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
            MsgBox(ex.Message)
        Finally
            MySqlDisconnect()
        End Try
    End Function

    Function ConnTestConfig(ByVal DBHost As String, ByVal DBUser As String, ByVal DBPass As String, ByVal DBPort As Integer, ByVal DBName As String)
        'MsgBox(DBHost + " " + DBPort.ToString + " " + DBUser + " " + DBPass + " " + DBName.ToString.ToLower)
        Dim ConnStrTest As New MySqlConnection("server=" & DBHost & ";user id=" & DBUser & ";password=" & DBPass & ";database=" & DBName & ";port=" & DBPort.ToString & "")
        Try
            ConnStrTest.Open()
            If ConnStrTest.State = ConnectionState.Open Then
                My.Settings.DBHOST = DBHost.ToString.ToLower
                My.Settings.DBNAME = DBName.ToString.ToLower
                My.Settings.DBPASS = DBPass
                My.Settings.DBPORT = DBPort
                My.Settings.DBUSER = DBUser
                My.Settings.Save()
                My.Settings.Reload()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
            MsgBox(ex.Message)
        Finally
            ConnStrTest.Close()
        End Try
    End Function

    'retornar la conexion segura
    Function ConnDSN() As MySqlConnection
        Return ConnStr
    End Function


    Function FindServer()
        Dim ip As String
        ip = Dns.GetHostEntry(My.Computer.Name).AddressList.FirstOrDefault(Function(i) i.AddressFamily = Sockets.AddressFamily.InterNetwork).ToString
        Dim subs() As String = ip.Split(".")
        'Dim Gateway As String = subs(0) & "." & subs(1) & "." & subs(2) & "." & "1"
        For x = 1 To 255
            Dim adds As String = subs(0) & "." & subs(1) & "." & subs(2) & "." & x
            If ConnTestConfig(adds, "root", "", "3306", "pnet_masterdb") = True Then
                Return adds
            End If
        Next
        Return Nothing
    End Function

End Class
