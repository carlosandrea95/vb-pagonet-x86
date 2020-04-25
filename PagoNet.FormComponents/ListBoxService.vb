Imports PagoNet.Database
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Public Class ListBoxService
    Inherits MySqlCommands
    Public Class ElementoListBox
        Private CodigoElemento As String
        Private TextoElemento As String

        Public Sub New(ByVal NuevoCodigo As String, ByVal NuevoTexto As String)
            CodigoElemento = NuevoCodigo
            TextoElemento = NuevoTexto
        End Sub

        Public ReadOnly Property Codigo() As String
            Get
                Return CodigoElemento
            End Get
        End Property

        Public ReadOnly Property Texto() As String
            Get
                Return TextoElemento
            End Get
        End Property
    End Class

    Sub Cargar_ListBox(ByVal listbox As ListBox, ByVal sql As String)
        Dim Lista As New ArrayList
        Dim db As New MySqlCommands
        Try
            Dim dr As MySqlDataReader
            dr = db.MySqlRead(sql)
            While dr.Read
                Lista.Add(New ElementoListBox(dr.GetValue(0).ToString, dr.GetValue(1).ToString))
            End While
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Metodo CargarComboDesdeSql", MessageBoxButtons.OK)
        End Try

        With listbox
            .DataSource = Lista
            .ValueMember = "Codigo"
            .DisplayMember = "Texto"
        End With
    End Sub

    Sub Cargar_ListBoxFull(ByVal listbox As ListBox, ByVal sql As String)
        Dim Lista As New ArrayList
        Dim db As New MySqlCommands
        Try
            Dim dr As MySqlDataReader
            dr = db.MySqlRead(sql)
            While dr.Read
                Lista.Add(New ElementoListBox(dr.GetValue(0).ToString, dr.GetValue(0).ToString + " " + dr.GetValue(1).ToString))
            End While
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Metodo CargarComboDesdeSql", MessageBoxButtons.OK)
        End Try

        With listbox
            .DataSource = Lista
            .ValueMember = "Codigo"
            .DisplayMember = "Texto"
        End With
    End Sub
End Class
