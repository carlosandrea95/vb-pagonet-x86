Imports PagoNet.Database
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Public Class ComboBoxService
    Inherits MySqlCommands
    Public Sub CargarComboBoxByDataTable(ByRef ElComboBox As Windows.Forms.ComboBox, ByVal Sql As String)
        Dim Lista As New ArrayList
        Dim db As New MySqlCommands
        Try
            Dim dt As DataTable
            dt = db.MySqlDataTable(Sql)
            For Each row As DataRow In dt.Rows
                Lista.Add(New ElementoCombo(row(0).ToString, row(1).ToString))
            Next
            dt.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Metodo CargarComboDesdeSql", MessageBoxButtons.OK)
        End Try

        With ElComboBox
            .DropDownStyle = ComboBoxStyle.DropDown
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
            .DataSource = Lista
            .ValueMember = "Codigo"
            .DisplayMember = "Texto"
        End With
    End Sub
    Public Sub CargarComboBox(ByRef ElComboBox As Windows.Forms.ComboBox, ByVal Sql As String)
        Dim Lista As New ArrayList
        Dim db As New MySqlCommands
        Try
            Dim dr As MySqlDataReader
            dr = db.MySqlRead(Sql)
            While dr.Read
                Lista.Add(New ElementoCombo(dr.GetValue(0).ToString, dr.GetValue(1).ToString))
            End While
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Metodo CargarComboDesdeSql", MessageBoxButtons.OK)
        End Try

        With ElComboBox
            .DropDownStyle = ComboBoxStyle.DropDown
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
            .DataSource = Lista
            .ValueMember = "Codigo"
            .DisplayMember = "Texto"
        End With
    End Sub
    Public Sub CargarComboBoxFull(ByRef ElComboBox As Windows.Forms.ComboBox, ByVal Sql As String)
        Dim Lista As New ArrayList
        Dim db As New MySqlCommands
        Try
            Dim dr As MySqlDataReader
            dr = db.MySqlRead(Sql)
            While dr.Read
                Lista.Add(New ElementoCombo(dr.GetValue(0).ToString, dr.GetValue(0).ToString + " " + dr.GetValue(1).ToString))
            End While
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Metodo CargarComboDesdeSql", MessageBoxButtons.OK)
        End Try

        With ElComboBox
            .DropDownStyle = ComboBoxStyle.DropDown
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
            .DataSource = Lista
            .ValueMember = "Codigo"
            .DisplayMember = "Texto"
        End With
    End Sub
    Public Sub CargarComboBoxWithTittle(ByRef ElComboBox As Windows.Forms.ComboBox, ByVal Sql As String, ByVal Tittle As String)
        Dim Lista As New ArrayList
        Lista.Add(New ElementoCombo(0, Tittle))
        Dim db As New MySqlCommands
        Try
            Dim dr As MySqlDataReader
            dr = db.MySqlRead(Sql)
            While dr.Read
                Lista.Add(New ElementoCombo(dr.GetValue(0).ToString, dr.GetValue(1).ToString))
            End While
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Metodo CargarComboDesdeSql", MessageBoxButtons.OK)
        End Try

        With ElComboBox
            .DropDownStyle = ComboBoxStyle.DropDown
            .AutoCompleteMode = AutoCompleteMode.Suggest
            .AutoCompleteSource = AutoCompleteSource.ListItems
            .DataSource = Lista
            .ValueMember = "Codigo"
            .DisplayMember = "Texto"
        End With
    End Sub
    Public Class ElementoCombo
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
End Class
