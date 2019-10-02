Imports System.Data.OleDb
Public Class frm_Login
    Dim da As New OleDbDataAdapter
    Dim dset As New DataSet
    Dim dcom As New OleDbCommand

    Sub login_admin()
        da = New OleDbDataAdapter("SELECT * FROM tbl_users WHERE username = '" & txt_user.Text & "' AND password = '" & txt_pass.Text & "' And accesslvl = '" & cb_lvl.Text & "'", ultracon)
        dset = New DataSet
        da.Fill(dset, "tbl_users")
        If (dset.Tables("tbl_users").Rows.Count <> 0) Then
            da = New OleDbDataAdapter("SELECT * FROM tbl_users WHERE username = '" & txt_user.Text & "' AND password = '" & txt_pass.Text & "' And accesslvl = '" & cb_lvl.Text & "' AND status = 'Offline'", ultracon)
            dset = New DataSet
            da.Fill(dset, "tbl_users")
            If (dset.Tables("tbl_users").Rows.Count <> 0) Then
                If (cb_lvl.Text = "Admin") Then
                    edit_status_admin()
                    Me.Hide()
                    'frmChecker.Show()
                    frm_Flash.lbl_Access.Text = txt_user.Text
                    frm_AdminConfig.Show()

                    'frm_AdminPCtrl.Show()
                End If
            Else
                MsgBox("The user is already Logged in!", MsgBoxStyle.Critical, "Try Again!")
                txt_user.Text = ""
                txt_pass.Text = ""
                txt_user.Focus()
            End If
        Else
            MsgBox("Username and Password is Invalid!", MsgBoxStyle.Critical, "Try Again!")
            txt_user.Text = ""
            txt_pass.Text = ""
            txt_user.Focus()
        End If
    End Sub

    Sub login_judge()
        da = New OleDbDataAdapter("SELECT * FROM tbl_judges WHERE username = '" & txt_user.Text & "' AND password = '" & txt_pass.Text & "' And accesslvl = '" & cb_lvl.Text & "'", ultracon)
        dset = New DataSet
        da.Fill(dset, "tbl_judges")
        If (dset.Tables("tbl_judges").Rows.Count <> 0) Then
            da = New OleDbDataAdapter("SELECT * FROM tbl_judges WHERE username = '" & txt_user.Text & "' AND password = '" & txt_pass.Text & "' And accesslvl = '" & cb_lvl.Text & "' AND status = 'Offline'", ultracon)
            dset = New DataSet
            da.Fill(dset, "tbl_judges")
            If (dset.Tables("tbl_judges").Rows.Count <> 0) Then
                If (cb_lvl.Text = "Judge") Then
                    edit_status_judge()
                    Me.Hide()
                    'frmClientController.Show()
                    'frmFlash.lblJudge.Text = txt_user.Text
                    frm_Flash.lbl_Access.Text = txt_user.Text
                    frm_Flash.lbl_JID.Text = dset.Tables("tbl_judges").Rows(0).Item(0)
                    'frm_Flash.Show()
                    frm_jctrl.Show()
                End If
            Else
                MsgBox("The user is already Logged in!", MsgBoxStyle.Critical, "Try Again!")
                txt_user.Text = ""
                txt_pass.Text = ""
                txt_user.Focus()
            End If
        Else
            MsgBox("Username and Password is Invalid!", MsgBoxStyle.Critical, "Try Again!")
            txt_user.Text = ""
            txt_pass.Text = ""
            txt_user.Focus()
        End If
    End Sub

    Sub edit_status_admin()
        dcom = New OleDbCommand
        With dcom
            .Connection = ultracon
            .CommandText = "UPDATE tbl_users SET status = 'Online' WHERE username = '" & txt_user.Text & "'"
            .ExecuteNonQuery()
        End With
    End Sub

    Sub edit_status_judge()
        dcom = New OleDbCommand
        With dcom
            .Connection = ultracon
            .CommandText = "UPDATE tbl_judges SET status = 'Online' WHERE username = '" & txt_user.Text & "'"
            .ExecuteNonQuery()
        End With
    End Sub
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ramcon()
        Catch ex As Exception
            MsgBox("Something went wrong " & ex.Message, MsgBoxStyle.Critical)
        End Try

        cb_lvl.Items.Add("Admin")
        cb_lvl.Items.Add("Judge")
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        'login()
        If cb_lvl.Text = "Admin" Then
            login_admin()
        ElseIf cb_lvl.Text = "Judge" Then
            login_judge()
        Else
            MsgBox("Check User Level")
        End If
    End Sub

    Private Sub cb_lvl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_lvl.SelectedIndexChanged

    End Sub

    Private Sub cb_lvl_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cb_lvl.KeyPress
        e.Handled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Me.Close()
        If MessageBox.Show("You sure you want to close this? This will close the entire program", "Close Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            ' Cancel the Closing event from closing the form.
        Else
            Me.Close()
        End If
    End Sub

    Private Sub frm_Login_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub frm_Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub
End Class