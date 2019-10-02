Imports System.Data.OleDb

Public Class uc_pbCandi
    Dim da As New OleDbDataAdapter
    Dim dset As New DataSet
    Dim dcom As New OleDbCommand

    Dim sql As String
    Dim tbl As String

    Public Sub updateScore()
        Try
            dcom = New OleDbCommand
            dcom.Connection = ultracon
            sql = String.Format("SELECT [{0}] FROM [tbl_conpro] WHERE [CID] = {1} AND [JID] = {2}", frm_Preset2.lbl_cat.Text, pb.Tag.ToString, frm_Flash.lbl_JID.Text)
            dcom.CommandText = sql
            'MsgBox(dcom.CommandText)
            txtCandi.Text = Convert.ToString(dcom.ExecuteScalar)
            'If pb.Tag.ToString = "7" Then
            '    Timer1.Enabled = False
            'End If
        Catch ex As Exception
        End Try
    End Sub

    'da2 = New OleDbDataAdapter("SELECT * FROM tbl_conpro WHERE [JID] = " & frm_Flash.lbl_JID.Text & " ", ultracon)
    'dset2 = New DataSet
    'da2.Fill(dset, "tbl_conpro")

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pb.Click
        'frm_Keypad.lblID.Text = cons.Item(0)
        frm_Keypad.lblID.Text = pb.Tag.ToString

        frm_Keypad.ShowDialog()
        'txtCandi.Text = frm_Keypad.txtScore.Text
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            updateScore()
        Catch ex As Exception
            'Timer1.Enabled = False
            'If MsgBox("Connection to Server has been Lost !", MsgBoxStyle.RetryCancel) = vbRetry Then
            '    Timer1.Enabled = True
            'Else
            'End If
        End Try

    End Sub

    Private Sub uc_pbCandi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Timer1.Enabled = True
        'updateScore()
    End Sub
End Class
