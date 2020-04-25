Imports PagoNet.Database
Imports System.Windows.Forms
Public Class ListViewService
    Public Sub CargarListView(ByRef ListView As ListView, ByVal sql As String)
        Try
            Dim db As New MySqlCommands
            Dim dataset As DataSet ' Crear nuevo dataset  
            dataset = db.MySqlDataset(sql)
            With ListView
                .Items.Clear()
                '.Columns.Clear()
                .View = View.Details
                .GridLines = True
                .FullRowSelect = True
                .HeaderStyle = ColumnHeaderStyle.Nonclickable
                .BorderStyle = BorderStyle.FixedSingle
                'añadir los nombres de columnas  
                'For c As Integer = 0 To dataset.Tables("tabla").Columns.Count - 1
                '.Columns.Add(dataset.Tables("tabla").Columns(c).Caption)
                ' Next
            End With

            ' Añadir los registros de la tabla  
            With dataset.Tables("tabla")
                For f As Integer = 0 To .Rows.Count - 1

                    Dim dato As New ListViewItem(.Rows(f).Item(0).ToString)
                    ' recorrer las columnas  
                    For c As Integer = 1 To .Columns.Count - 1
                        dato.SubItems.Add(.Rows(f).Item(c).ToString())
                    Next
                    ListView.Items.Add(dato)
                Next
            End With
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Public Sub CargarListViewByDataTable(ByRef ListView As ListView, ByVal DT As DataTable)
        Try
            With ListView
                .Items.Clear()
                .Columns.Clear()
                .View = View.Details
                .GridLines = True
                .FullRowSelect = True
                ' añadir los nombres de columnas  
                For c As Integer = 0 To DT.Columns.Count - 1
                    .Columns.Add(DT.Columns(c).Caption)
                Next
            End With

            ' Añadir los registros de la tabla  
            With DT
                For f As Integer = 0 To .Rows.Count - 1

                    Dim dato As New ListViewItem(.Rows(f).Item(0).ToString)
                    ' recorrer las columnas  
                    For c As Integer = 1 To .Columns.Count - 1
                        dato.SubItems.Add(.Rows(f).Item(c).ToString())
                    Next
                    ListView.Items.Add(dato)
                Next
            End With
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
End Class
