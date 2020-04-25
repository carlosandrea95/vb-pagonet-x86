Imports MySql.Data.MySqlClient
Imports MySql.Data.Types
Public Class MySqlEasyQuery
    Dim MySqlComm As New MySqlCommands
    Dim MySqlLocalDB As New MySqlLocalConn
    Dim UpdateList As New List(Of String)
    Dim CriteriaList As New List(Of String)
    Dim CriteriaStr As String
    Dim Query As String
    Dim Table As String
    Function CheckQuery()
        Return MsgBox(Query)
    End Function
    Function EasyInsert(ByVal paramList As List(Of String), ByVal valueList As List(Of String))
        Try
            Dim bool As Boolean = False
            If Table = String.Empty Then
                MsgBox("No se ha establecido una tabla utiliza la funcion --> {SetTable}", MsgBoxStyle.Information)
            Else

                Dim paramStr As String = String.Join("`,`", paramList)
                Dim ValueStr As String = String.Join("','", valueList)
                Query = "INSERT INTO " + Table + " (`" + paramStr + "`) VALUES ('" + ValueStr + "')"
                'MsgBox(Query)
                If MySqlComm.MySqlQuery(Query) = True Then
                    bool = True
                Else
                    bool = False
                End If
            End If
            Return bool
        Catch ex As Exception
            Return MsgBox("ERROR " + ex.ToString + " | " + ex.Message, MsgBoxStyle.Critical)
        End Try
    End Function

    Function EasyConsult(ByVal FieldList As List(Of String), Optional ByVal OrderCriteria As String = "1 DESC")

        Try
            Dim fieldStr As String = String.Join(",", FieldList)
            Dim dt, data As New DataTable
            If Table = String.Empty Then
                MsgBox("No se ha establecido una tabla utiliza la funcion --> {SetTable}", MsgBoxStyle.Information)
            Else

                If CriteriaList.Count <> 0 Then
                    CriteriaStr = String.Join(" AND ", CriteriaList)
                    Query = "SELECT " + fieldStr + " FROM " + Table + " WHERE " + CriteriaStr + " ORDER BY " + OrderCriteria
                Else
                    Query = "SELECT " + fieldStr + " FROM " + Table + " ORDER BY " + OrderCriteria
                End If
                
                dt = MySqlComm.MySqlDataTable(Query)
                If dt.Rows.Count <> 0 Then
                    data = dt
                End If
            End If
            Return data
        Catch ex As Exception
            Return MsgBox("ERROR " + ex.ToString + " | " + ex.Message, MsgBoxStyle.Critical)
        Finally
            CriteriaList.Clear()
        End Try

    End Function

    Function EasyUpdate()
        Dim bool As Boolean = False
        Try
            If Table = String.Empty Then
                MsgBox("No se ha establecido una tabla utiliza la funcion --> {SetTable}", MsgBoxStyle.Information)
            Else
                Dim paramStr As String = String.Join(",", UpdateList)


                If CriteriaList.Count <> 0 Then
                    CriteriaStr = String.Join(" AND ", CriteriaList)
                    Query = "UPDATE " + Table + " SET " + paramStr + " WHERE " + CriteriaStr
                Else
                    MsgBox("No se ha establecido un criterio utiliza la funcion --> {SetCriteria}", MsgBoxStyle.Information)
                End If
                'MsgBox(Query)
                If MySqlComm.MySqlQuery(Query) = True Then
                    bool = True
                Else
                    bool = False
                End If
            End If
            Return bool
        Catch ex As Exception
            Return MsgBox("ERROR " + ex.ToString + " | " + ex.Message, MsgBoxStyle.Critical)
        Finally
            CriteriaList.Clear()
        End Try
    End Function

    Sub SetTable(ByVal TableName As String)
        Table = TableName
    End Sub

    Sub BindParam(ByVal Param As String, ByVal Value As String)
        UpdateList.Add(Param + "='" + Value + "'")
    End Sub

    Sub UpdateImg(ByVal Param As String, ByVal ValueImg As Byte())
        Dim adp As New MySqlDataAdapter
        CriteriaStr = String.Join(" AND ", CriteriaList)
        MySqlLocalDB.MySqlDisconnect()
        MySqlLocalDB.MySqlConnect()
        With adp
            .UpdateCommand = New MySqlCommand("UPDATE " + Table + " SET " + Param + "=@img_val" + " WHERE " + CriteriaStr)
            .UpdateCommand.Parameters.Add("@img_val", MySqlDbType.Blob).Value = ValueImg
            .UpdateCommand.Connection = MySqlLocalDB.ConnDSN
            .UpdateCommand.ExecuteNonQuery()
        End With
    End Sub

    Function EasyConsultImg(ByVal fieldStr As String, Optional ByVal OrderCriteria As String = "1 DESC")
        If CriteriaList.Count <> 0 Then
            CriteriaStr = String.Join(" AND ", CriteriaList)
            Query = "SELECT " + fieldStr + " FROM " + Table + " WHERE " + CriteriaStr + " ORDER BY " + OrderCriteria
        Else
            Query = "SELECT " + fieldStr + " FROM " + Table + " ORDER BY " + OrderCriteria
        End If
        Dim Sql As String = "select img_logo from mst_empresas where id_empresa=1"
        Dim lector As MySqlDataReader

        MySqlLocalDB.MySqlConnect()
        Dim Imag As Byte() = New Byte() {0}
        Dim Comando As New MySqlCommand(Query, MySqlLocalDB.ConnDSN)
        lector = Comando.ExecuteReader
        While lector.Read
            Imag = lector("img_logo")
        End While
        Return Imag
        MySqlLocalDB.MySqlDisconnect()
    End Function

    Sub SetCriteria(ByVal Criteria As String, ByVal Value As String, Optional ByVal endSubConsult As String = "")
        CriteriaList.Clear()
        CriteriaList.Add(Criteria + "='" + Value + "'" + endSubConsult)
    End Sub




End Class
