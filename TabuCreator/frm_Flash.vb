Imports System.Data.OleDb

Public Class frm_Flash
    Dim da As New OleDbDataAdapter
    Dim dset As New DataSet
    Dim dcom As New OleDbCommand

    Dim sql As String = ""

    Sub bgload()
        Dim tbl As String = "tbl_design"
        da = New OleDbDataAdapter("select * from tbl_design where col_form='frm_Flash'", ultracon)
        dset = New DataSet
        da.Fill(dset, tbl)
        Dim bgloc As String = dset.Tables("tbl_design").Rows(0).Item(2)
        Me.BackgroundImage = Image.FromFile(Application.StartupPath & "\Images\" & bgloc)
    End Sub
    Private Sub frm_Flash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bgload()
    End Sub

    Private Sub frm_Flash_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        bgload()
    End Sub

    Private Sub frm_Flash_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If lbl_Access.Text = "Judge" Then
            If MessageBox.Show("You sure you want to close this? This will close the entire program", "Close Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then

                ' Cancel the Closing event from closing the form.

                e.Cancel = True

            End If
        Else
        End If
    End Sub

    Private Sub frm_Flash_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If lbl_Access.Text = "Judge" Then
            dcom = New OleDbCommand
            dcom.Connection = ultracon

            sql = String.Format("UPDATE tbl_judges SET [status] = 'Offline' WHERE [JID]  = {0}", lbl_JID.Text)
            dcom.CommandText = sql
            dcom.ExecuteNonQuery()
            MsgBox("You have been logged out. Now closing...")
            Application.Exit()
        Else

        End If
    End Sub
End Class