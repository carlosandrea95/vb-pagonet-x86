Imports CrystalDecisions.CrystalReports.Engine
Imports PagoNet.Reports
Public Class PrepareReport
    Function SetReport(ByVal RptName As ReportDocument)
        Dim rpt As New ReportDocument
        rpt = RptName
        Return rpt.ToString
    End Function


    Sub ExternoReport(ByVal ValorParametro As String, ByVal RutaRPT As String)
        Dim Rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Rpt.Load(RutaRPT)
        Rpt.SetParameterValue("NombreParametro", ValorParametro)
    End Sub

End Class
