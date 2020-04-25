Public Class CustomCurrency
    Public Function MoneyFormat(ByVal Amount As String, ByVal MilSeparator As String, ByVal DecimalSeparator As String)
        Try
            'Dim clearAmount() As String = Amount.Split(fixDecimal)
            'Dim nentero As String = clearAmount(0).ToString
            'Dim ndecimal As String = clearAmount(1).ToString
            'Dim amountStr As String = nentero + "," + ndecimal
            'Dim formatType As String = "#,##0.00"
            'Dim rtamount As Decimal = CType(amountStr, Decimal)

            Dim formateado As String = Format(CType(Amount, Decimal), "#,##0.00")
            MsgBox(formateado)
            formateado.Replace(".", "%$").Replace(",", "&%")
            MsgBox(formateado)
            formateado.Replace("%$", MilSeparator).Replace("&%", DecimalSeparator)
            Return formateado
        Catch ex As Exception
            Return MsgBox(ex.Message)
        End Try
    End Function
End Class
