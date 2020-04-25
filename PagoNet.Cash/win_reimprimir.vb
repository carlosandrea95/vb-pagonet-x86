
Public Class win_reimprimir

    Private Sub Reprint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        'CrystalReportViewer1.ReportSource = rpt
        'CrystalReportViewer1.Refresh()
        'CrystalReportViewer1.RefreshReport()
        'CrystalReportViewer1.Width = 500
        'CrystalReportViewer1.Height = 600
        'CrystalReportViewer1.su()
        'Dim rpt As New PrepareReport
        'rpt.SetReport("rpt_factura_ticket")
        'MsgBox(rpt.ToString)
        CrystalReportViewer1.Zoom(1)

        'Dim tabFicha As Windows.Forms.TabControl
        'Dim myControl As System.Windows.Forms.Control
        'For Each myControl In CrystalReportViewer1.Controls
        '    If UCase(myControl.GetType.Name) = "PAGEVIEW" Then
        '        tabFicha = CType(myControl.Controls(0), TabControl)
        '        With tabFicha
        '            .ItemSize = New Size(0, 1)
        '            .SizeMode = TabSizeMode.Fixed
        '            .Appearance = TabAppearance.Buttons
        '        End With
        '    End If
        'Next
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class