Imports System.Windows.Forms
Public Class FormDataManager

    Function Serialize(ByVal win As Form)
        
        Dim row As New List(Of String)
        Try
            Dim Ctrl As Control
            For x = win.Controls.Count - 1 To 0 Step -1
                Ctrl = win.Controls.Item(x)
                If TypeOf (Ctrl) Is GroupBox Then
                    For Each GCtrl As Control In Ctrl.Controls
                        If TypeOf (GCtrl) Is TextBox Then
                            Dim VControl As TextBox = GCtrl
                            If VControl.Text = String.Empty Then
                                'MsgBox("debe establecer un valor para el campo " + VControl.AccessibleName)

                            Else
                                row.Add(VControl.Name + "," + VControl.Text)
                            End If
                        ElseIf TypeOf (GCtrl) Is ComboBox Then
                            Dim VControl As ComboBox = GCtrl
                            If VControl.SelectedValue = String.Empty Then
                                row.Add(VControl.Name + "," + VControl.Text)
                            Else
                                row.Add(VControl.Name + "," + VControl.SelectedValue)
                            End If
                        End If
                    Next
                ElseIf TypeOf (Ctrl) Is Panel Then
                    For Each GCtrl As Control In Ctrl.Controls
                        If TypeOf (GCtrl) Is TextBox Then
                            Dim VControl As TextBox = GCtrl
                            If VControl.Text = String.Empty Then
                                'MsgBox("debe establecer un valor para el campo " + VControl.AccessibleName)

                            Else
                                row.Add(VControl.Name + "," + VControl.Text)
                            End If
                        ElseIf TypeOf (GCtrl) Is ComboBox Then
                            Dim VControl As ComboBox = GCtrl
                            If VControl.SelectedValue = String.Empty Then
                                row.Add(VControl.Name + "," + VControl.Text)
                            Else
                                row.Add(VControl.Name + "," + VControl.SelectedValue)
                            End If
                        End If
                    Next
                Else
                    If TypeOf (Ctrl) Is TextBox Then
                        Dim VControl As TextBox = Ctrl
                        If VControl.Text = String.Empty Then
                            'MsgBox("debe establecer un valor para el campo " + VControl.AccessibleName)
                        Else
                            row.Add(VControl.Name + "," + VControl.Text)
                        End If
                    ElseIf TypeOf (Ctrl) Is ComboBox Then
                        Dim VControl As ComboBox = Ctrl
                        If VControl.SelectedValue = String.Empty Then
                            row.Add(VControl.Name + "," + VControl.Text)
                        Else
                            row.Add(VControl.Name + "," + VControl.SelectedValue)
                        End If
                    End If
                End If
            Next
            Dim rows As String = String.Join(";", row)
            Return rows
        Catch ex As Exception
            Return MsgBox(ex.Message)
        End Try
    End Function

    Function DataGridViewSerialize(ByVal DataGView As DataGridView) As DataTable
        Dim dt As New DataTable
        Try
            If DataGView.Rows.Count > 0 Then
                With DataGView
                    For c As Integer = 0 To .Columns.Count - 1
                        dt.Columns.Add(c.ToString)
                    Next
                    For f As Integer = 0 To .Rows.Count - 1
                        Dim Renglon As DataRow
                        Renglon = dt.NewRow
                        For x = 0 To dt.Columns.Count - 1
                            If .Rows(f).Cells(1).Value <> String.Empty Then
                                Renglon(x) = "" + .Rows(f).Cells(x).Value
                            End If
                        Next
                        'MsgBox(Renglon("0").ToString)
                        If .Rows(f).Cells(1).Value <> String.Empty Then
                            dt.Rows.Add(Renglon)
                        End If
                    Next
                End With
            End If
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return dt
        End Try
    End Function

    Function Value(ByVal rows As String, ByVal FindCol As String)
        Try
            Dim val As String = ""
            Dim arr As String() = rows.Split(";")
            For Each arrw As String In arr
                If arrw.Contains(FindCol) Then
                    Dim rs As String() = arrw.Split(",")
                    For Each r As String In rs
                        If Not r.Contains(FindCol) Then
                            val = r
                        End If
                    Next
                End If
            Next
            Return val
        Catch ex As Exception
            Return MsgBox(ex.Message)
        End Try
    End Function
End Class
