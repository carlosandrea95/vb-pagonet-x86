Imports System.Windows.Forms
Imports PagoNet.Database
Imports MySql.Data.MySqlClient

Public Class DataGridViewService
    Inherits MySqlCommands
    Public Class ElementoComboBoxCell
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

    Sub CargaComboBoxElements(ByVal DGW As DataGridView, ByVal Colindex As Integer, ByVal Sql As String)

        Dim Lista As New ArrayList

        Dim db As New MySqlCommands
        Try
            Dim dr As MySqlDataReader
            dr = db.MySqlRead(Sql)
            While dr.Read
                'MsgBox(dr.GetValue(0).ToString + " " + dr.GetValue(1).ToString)
                Lista.Add(New ElementoComboBoxCell(dr.GetValue(0).ToString, dr.GetValue(1).ToString))
            End While
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Metodo CargarComboDesdeSql", MessageBoxButtons.OK)
        End Try
       

        For filas = 0 To DGW.RowCount - 1
            For cols = 0 To DGW.ColumnCount - 1
                If cols = Colindex Then
                    Dim comboboxColumn As DataGridViewComboBoxCell = TryCast(DGW.Rows(filas).Cells(cols), DataGridViewComboBoxCell)
                    With comboboxColumn
                        .DataSource = Lista
                        .ValueMember = "Codigo"
                        .DisplayMember = "Texto"
                    End With
                End If
            Next
        Next




        'For Fila = 0 To DGW.RowCount - 1
        '    Dim comboboxColumn As DataGridViewComboBoxCell = TryCast(DGW.Rows(Fila).Cells(Colindex), DataGridViewComboBoxCell)
        '    With comboboxColumn
        '        .DataSource = Lista
        '        .ValueMember = "Codigo"
        '        .DisplayMember = "Texto"
        '    End With
        '    MsgBox(comboboxColumn.ValueMember.ToString + " val " + comboboxColumn.Value + " val " + comboboxColumn.DisplayMember)
        'Next

    End Sub

End Class
