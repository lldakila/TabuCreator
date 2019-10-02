Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Imports System.Data.OleDb
Module Connection
    Public constr0 As String
    'Public constr As String = constr0
    Public constr As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\db_tabu.mdb"
    'Public constr As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & frm_setServerDb.conCon & "\db_tabu.mdb"
    'Public constr As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & frm_setServerDb.conCon
    Public ultracon As New OleDbConnection(constr)


    Sub ramcon()
        'ultracon As New OleDbConnection(constr0)
        'ultracon.ConnectionString = frm_setServerDb.constrs
        If (ultracon.State = ConnectionState.Closed) Then
            ultracon.Open()
        End If
    End Sub

    Sub setbg()


        frm_Flash.BackgroundImage = Image.FromFile(Application.StartupPath & "\Images\[filename]")

    End Sub

    Dim da As New OleDbDataAdapter
    Dim dset As New DataSet
    Dim dcom As New OleDbCommand
    Sub bgpresload()
        Dim tbl As String = "tbl_design"
        da = New OleDbDataAdapter("select * from tbl_design where col_form='frm_Preset'", ultracon)
        dset = New DataSet
        da.Fill(dset, tbl)
        Dim bgloc As String = dset.Tables("tbl_design").Rows(0).Item(2)
        frm_Preset1.BackgroundImage = Image.FromFile(Application.StartupPath & "\Images\" & bgloc)
        frm_Preset2.BackgroundImage = Image.FromFile(Application.StartupPath & "\Images\" & bgloc)
    End Sub

End Module
