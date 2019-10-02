Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frm_rptAve
    'Dim crTables As Tables
    'Dim crTableLogonInfo As New TableLogOnInfo
    'Dim rptDoc As New ReportDocument()

    Private Sub frm_rptAve_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '    Dim crTables As Tables
        '    Dim crTableLogonInfo As New TableLogOnInfo
        '    Dim crConnectionInfo As New ConnectionInfo

        '    Dim rptDoc As New ReportDocument()
        '    rptDoc.Load(Application.StartupPath & "\cr_ave.rpt")

        '    With crConnectionInfo
        '        .ServerName = Application.StartupPath & "\db_tabu.mdb"
        '    End With

        '    crTables = rptDoc.Database.Tables

        '    For Each crTable As Object In crTables
        '        crTableLogonInfo = crTable.logOnInfo
        '        crTableLogonInfo.ConnectionInfo = crConnectionInfo
        '        crTable.ApplyLogOnInfo(crTableLogonInfo)
        '    Next

        '    Dim reportQuery As String = String.Empty
        '    reportQuery = "SELECT * FROM [tbl_ave]"
        '    crv1.SelectionFormula = reportQuery
        '    crv1.Refresh()
        '    crv1.RefreshReport()
    End Sub
    'rptDoc.Load(Application.StartupPath & "\cr_ave.rpt")
End Class