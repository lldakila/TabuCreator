Imports System.Data.OleDb
Public Class frm_setServerDb
    Dim testcon As New OleDbConnection
    Public constrs As String
    Public conCon As String

    Sub testServer()
        Try
            conCon = txt_serverPath.Text
            'constrs = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & conCon & "\db_tabu.mdb"
            constrs = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & conCon
            'constr0 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & txt_serverPath.Text & "\db_tabu.mdb"
            Try
                Dim testcon As New OleDbConnection(constrs)
                If testcon.State = ConnectionState.Closed Then
                    testcon.Open()
                End If
                testcon.Close()
                'constr = constr0
                'constrs = constr0
                'ultracon.ConnectionString = constrs
                ramcon()
                MsgBox("Server Set")
                frm_Login.Show()
                Me.Hide()
            Catch ex As Exception
                MsgBox(ex.Message)
                'constr0 = ""
                conCon = ""
                txt_serverPath.Text = ""
                'constrs = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & txt_serverPath.Text & "\db_tabu.mdb"
            End Try

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btn_setServer_Click(sender As Object, e As EventArgs) Handles btn_setServer.Click
        testServer()
    End Sub

    Private Sub frm_setServerDb_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        'txt_serverPath.Text = System.IO.Path.GetFullPath(OpenFileDialog1.SafeFileName)
        txt_serverPath.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub txt_serverPath_Click(sender As Object, e As EventArgs) Handles txt_serverPath.Click
        'OpenFileDialog1.OpenFile()
    End Sub

    Private Sub btn_browse_Click(sender As Object, e As EventArgs) Handles btn_browse.Click
        OpenFileDialog1.ShowDialog()

    End Sub
End Class