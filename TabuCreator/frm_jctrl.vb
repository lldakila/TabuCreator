Imports System.Data.OleDb
Public Class frm_jctrl
    Dim da As New OleDbDataAdapter
    Dim dset As New DataSet
    Dim dcom As New OleDbCommand
    Dim sql As String = ""

    Public currcatname As String

    Sub updateControl()
        da = New OleDbDataAdapter("SELECT * FROM [tbl_control]", ultracon)
        dset = New DataSet
        da.Fill(dset, "tbl_control")

        lbl_ctrl.Text = dset.Tables("tbl_control").Rows(0).Item(0)
        currcatname = dset.Tables("tbl_control").Rows(0).Item(1)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            updateControl()
        Catch ex As Exception
            Timer1.Enabled = False
            If MsgBox(ex.Message, MsgBoxStyle.RetryCancel) = vbRetry Then
                Timer1.Enabled = True
            Else
            End If
        End Try

        If lbl_ctrl.Text = "0" Then
            frm_Flash.Show()
            frm_Preset2.Hide()
        ElseIf lbl_ctrl.Text = "1" Then
            frm_Flash.Hide()
            frm_Preset2.lbl_cat.Text = currcatname
            frm_Preset2.Show()
        End If
    End Sub

    Private Sub frm_jctrl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ramcon()
    End Sub

    Private Sub frm_jctrl_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("You sure you want to close this? This will close the entire program", "Close Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then

            ' Cancel the Closing event from closing the form.

            e.Cancel = True

        End If
    End Sub

    Private Sub frm_jctrl_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        dcom = New OleDbCommand
        dcom.Connection = ultracon

        sql = String.Format("UPDATE tbl_judges SET [status] = 'Offline' WHERE [JID]  = {0}", frm_Flash.lbl_JID.Text)
        dcom.CommandText = sql
        dcom.ExecuteNonQuery()
        MsgBox("You have been logged out. Now closing...")
        Application.Exit()
    End Sub
End Class