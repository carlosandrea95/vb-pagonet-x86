Imports MySql.Data.MySqlClient
Public Class MySqlCommands
    Dim db As New MySqlLocalConn
    Function MySqlQuery(ByVal Sql As String)
        Try
            db.MySqlConnect()
            Dim cmd As New MySqlCommand
            With cmd
                .Connection = db.ConnDSN()
                .CommandText = Sql
            End With
            If cmd.ExecuteNonQuery = True Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Return MsgBox(ex.Message + " (" + Sql + ").", MsgBoxStyle.Critical, "SISTEMA")
        End Try
    End Function

    Function MySqlDataTable(ByVal Sql As String) As DataTable
        Try
            Dim dt As New DataTable
            Dim cmd As New MySqlCommand
            Dim apt As New MySqlDataAdapter
            With cmd
                .Connection = db.ConnDSN()
                .CommandText = Sql
            End With
            With apt
                .SelectCommand = cmd
                .Fill(dt)
            End With
            Return dt
        Catch ex As Exception
            Dim dt As New DataTable
            Return dt
            MsgBox(ex.Message + " (" + Sql + ").", MsgBoxStyle.Critical, "SISTEMA")
        End Try
    End Function
    Function MySqlRead(ByVal Sql As String) As MySqlDataReader
        Try
            db.MySqlConnect()
            Dim dr As MySqlDataReader
            Dim cmd As New MySqlCommand
            With cmd
                .Connection = db.ConnDSN()
                .CommandText = Sql
            End With
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                Return dr
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message + " (" + Sql + ").", MsgBoxStyle.Critical, "SISTEMA")
        End Try
    End Function
    Function MySqlDataset(ByVal Sql As String) As DataSet
        Try
            Dim cmd As New MySqlCommand
            Dim apt As New MySqlDataAdapter
            Dim ds As New DataSet
            With cmd
                .Connection = db.ConnDSN()
                .CommandText = Sql
            End With
            With apt
                .SelectCommand = cmd
                .Fill(ds, "tabla")
            End With
            Return ds
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message + " (" + Sql + ").", MsgBoxStyle.Critical, "SISTEMA")
        End Try
    End Function
End Class
