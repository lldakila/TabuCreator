Imports System.Data.OleDb
Public Class frm_Keypad
    Dim da As New OleDbDataAdapter
    Dim dset As New DataSet

    Dim dcom As New OleDbCommand
    Dim sql As String
    Dim dotss As Integer

    Sub seeDotsss()
        dotss = 0
        For looop = 1 To (Len(txtScore.Text))
            If (Mid(txtScore.Text, looop, 1) = ".") Then
                dotss = 1
            End If
        Next
    End Sub

    Private Sub frmKeypad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCat.Text = frm_Preset2.lbl_cat.Text
        'da = New OleDbDataAdapter("SELECT * FROM tbl_conpro WHERE [JID] = " & frm_Flash.lbl_JID.Text & " AND [CID] = " & lblID.Text & "", ultracon)
        'dset = New DataSet
        'da.Fill(dset, "tbl_conpro")
        'txtScore.Text = dset.Tables("tbl_conpro").Rows(0).Item(lblCat.Text)
        Me.ActiveControl = txtScore

        'lblID.Text =  


    End Sub

    Private Sub txtScore_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtScore.KeyPress
        'Dim Allowed As String = "1234567890" + vbBack
        Dim Allowed As String = ""
        If Allowed.IndexOf(e.KeyChar) = -1 Then
            e.Handled = True
        End If

        'backspace
        If Asc(e.KeyChar) = 8 Then
            If (txtScore.Text <> "") Then
                txtScore.Text = Microsoft.VisualBasic.Left(txtScore.Text, (Len(txtScore.Text)) - 1)
            End If
        End If

        'dot
        If Asc(e.KeyChar) = 46 Then
            seeDotsss()
            If (txtScore.Text <> "") Then
                If ((dotss = 0) And (Len(txtScore.Text) < 2)) Then
                    txtScore.Text += "."
                End If
            End If
        End If

        'enter/carriage return
        If Asc(e.KeyChar) = 13 Then
            'MsgBox("You have pressed ASCII code " & Asc(e.KeyChar))
            If txtScore.Text <> "" Then
                dcom = New OleDbCommand
                dcom.Connection = ultracon
                If lblTable.Text = "tblMsTop5" Then
                    sql = String.Format("UPDATE {0} SET [{1}] = {2} WHERE [ID] = {3}", lblTable.Text, frm_Flash.lbl_JID.Text, txtScore.Text, Val(lblID2.Text))
                    dcom.CommandText = sql
                    dcom.ExecuteNonQuery()
                    txtScore.Text = ""
                    Me.Hide()
                ElseIf lblTable.Text = "tblMrTop5" Then
                    sql = String.Format("UPDATE {0} SET [{1}] = {2} WHERE [ID] = {3}", lblTable.Text, frm_Flash.lbl_JID.Text, txtScore.Text, Val(lblID2.Text))
                    dcom.CommandText = sql
                    dcom.ExecuteNonQuery()
                    txtScore.Text = ""
                    Me.Hide()
                Else
                    sql = String.Format("UPDATE tbl_conpro SET [{0}] = '{1}' WHERE [CID] = {2} AND [JID] = {3}", lblCat.Text, txtScore.Text, lblID.Text, frm_Flash.lbl_JID.Text)
                    dcom.CommandText = sql
                    dcom.ExecuteNonQuery()
                    'uc_pbCandi.txtCandi.Text = txtScore.Text
                    'frm_Preset2.con_pb.Tag(lblID.Text).txtCandi.Text = txtScore.Text
                    txtScore.Text = ""
                    Me.Hide()
                End If
            End If
        End If

        If Asc(e.KeyChar) = 48 Then
            seeDotsss()
            If ((txtScore.Text <> "") And (Val(txtScore.Text) < 2) And (Len(txtScore.Text) < 4)) Then
                txtScore.Text += "0"
            ElseIf (dotss = 1) And (Len(txtScore.Text) < 4) Then
                txtScore.Text += "0"
            End If
        End If

        If Asc(e.KeyChar) = 49 Then
            seeDotsss()
            If (Val(txtScore.Text) < 10) And (Len(txtScore.Text) < 1) Then
                txtScore.Text += "1"
            ElseIf (dotss = 1) And (Len(txtScore.Text) < 4) Then
                txtScore.Text += "1"
            End If
        End If

        If Asc(e.KeyChar) = 50 Then
            seeDotsss()
            If (Val(txtScore.Text) < 10) And (Len(txtScore.Text) < 1) Then
                txtScore.Text += "2"
            ElseIf (dotss = 1) And (Len(txtScore.Text) < 4) Then
                txtScore.Text += "2"
            End If
        End If

        If Asc(e.KeyChar) = 51 Then
            seeDotsss()
            If (Val(txtScore.Text) < 10) And (Len(txtScore.Text) < 1) Then
                txtScore.Text += "3"
            ElseIf (dotss = 1) And (Len(txtScore.Text) < 4) Then
                txtScore.Text += "3"
            End If
        End If

        If Asc(e.KeyChar) = 52 Then
            seeDotsss()
            If (Val(txtScore.Text) < 10) And (Len(txtScore.Text) < 1) Then
                txtScore.Text += "4"
            ElseIf (dotss = 1) And (Len(txtScore.Text) < 4) Then
                txtScore.Text += "4"
            End If
        End If

        If Asc(e.KeyChar) = 53 Then
            seeDotsss()
            If (Val(txtScore.Text) < 10) And (Len(txtScore.Text) < 1) Then
                txtScore.Text += "5"
            ElseIf (dotss = 1) And (Len(txtScore.Text) < 4) Then
                txtScore.Text += "5"
            End If
        End If

        If Asc(e.KeyChar) = 54 Then
            seeDotsss()
            If (Val(txtScore.Text) < 10) And (Len(txtScore.Text) < 1) Then
                txtScore.Text += "6"
            ElseIf (dotss = 1) And (Len(txtScore.Text) < 4) Then
                txtScore.Text += "6"
            End If
        End If

        If Asc(e.KeyChar) = 55 Then
            seeDotsss()
            If (Val(txtScore.Text) < 10) And (Len(txtScore.Text) < 1) Then
                txtScore.Text += "7"
            ElseIf (dotss = 1) And (Len(txtScore.Text) < 4) Then
                txtScore.Text += "7"
            End If
        End If

        If Asc(e.KeyChar) = 56 Then
            seeDotsss()
            If (Val(txtScore.Text) < 10) And (Len(txtScore.Text) < 1) Then
                txtScore.Text += "8"
            ElseIf (dotss = 1) And (Len(txtScore.Text) < 4) Then
                txtScore.Text += "8"
            End If
        End If

        If Asc(e.KeyChar) = 57 Then
            seeDotsss()
            If (Val(txtScore.Text) < 10) And (Len(txtScore.Text) < 1) Then
                txtScore.Text += "9"
            ElseIf (dotss = 1) And (Len(txtScore.Text) < 4) Then
                txtScore.Text += "9"
            End If
        End If
    End Sub

    Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        seeDotsss()
        If (Val(txtScore.Text) < 10) And (Len(txtScore.Text) < 1) Then
            txtScore.Text += "1"
        ElseIf (dotss = 1) And (Len(txtScore.Text) < 4) Then
            txtScore.Text += "1"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        seeDotsss()
        If (Val(txtScore.Text) < 10) And (Len(txtScore.Text) < 1) Then
            txtScore.Text += "2"
        ElseIf (dotss = 1) And (Len(txtScore.Text) < 4) Then
            txtScore.Text += "2"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        seeDotsss()
        If (Val(txtScore.Text) < 10) And (Len(txtScore.Text) < 1) Then
            txtScore.Text += "3"
        ElseIf (dotss = 1) And (Len(txtScore.Text) < 4) Then
            txtScore.Text += "3"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        seeDotsss()
        If (Val(txtScore.Text) < 10) And (Len(txtScore.Text) < 1) Then
            txtScore.Text += "4"
        ElseIf (dotss = 1) And (Len(txtScore.Text) < 4) Then
            txtScore.Text += "4"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        seeDotsss()
        If (Val(txtScore.Text) < 10) And (Len(txtScore.Text) < 1) Then
            txtScore.Text += "5"
        ElseIf (dotss = 1) And (Len(txtScore.Text) < 4) Then
            txtScore.Text += "5"
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        seeDotsss()
        If (Val(txtScore.Text) < 10) And (Len(txtScore.Text) < 1) Then
            txtScore.Text += "6"
        ElseIf (dotss = 1) And (Len(txtScore.Text) < 4) Then
            txtScore.Text += "6"
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        seeDotsss()
        If (Val(txtScore.Text) < 10) And (Len(txtScore.Text) < 1) Then
            txtScore.Text += "7"
        ElseIf (dotss = 1) And (Len(txtScore.Text) < 4) Then
            txtScore.Text += "7"
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        seeDotsss()
        If (Val(txtScore.Text) < 10) And (Len(txtScore.Text) < 1) Then
            txtScore.Text += "8"
        ElseIf (dotss = 1) And (Len(txtScore.Text) < 4) Then
            txtScore.Text += "8"
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        seeDotsss()
        If (Val(txtScore.Text) < 10) And (Len(txtScore.Text) < 1) Then
            txtScore.Text += "9"
        ElseIf (dotss = 1) And (Len(txtScore.Text) < 4) Then
            txtScore.Text += "9"
        End If
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        seeDotsss()
        If ((txtScore.Text <> "") And (Val(txtScore.Text) < 2) And (Len(txtScore.Text) < 4)) Then
            txtScore.Text += "0"
        ElseIf (dotss = 1) And (Len(txtScore.Text) < 4) Then
            txtScore.Text += "0"
        End If
    End Sub

    Private Sub btnDot_Click(sender As Object, e As EventArgs) Handles btnDot.Click
        seeDotsss()
        If (txtScore.Text <> "") Then
            If ((dotss = 0) And (Len(txtScore.Text) < 2)) Then
                txtScore.Text += "."
            End If
        End If
    End Sub

    Private Sub btnClr_Click(sender As Object, e As EventArgs) Handles btnClr.Click
        If (txtScore.Text <> "") Then
            txtScore.Text = Microsoft.VisualBasic.Left(txtScore.Text, (Len(txtScore.Text)) - 1)
        End If
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        If txtScore.Text <> "" Then
            dcom = New OleDbCommand
            dcom.Connection = ultracon
            If lblTable.Text = "tblMsTop5" Then
                sql = String.Format("UPDATE {0} SET [{1}] = {2} WHERE [ID] = {3}", lblTable.Text, frm_Flash.lbl_JID.Text, txtScore.Text, Val(lblID2.Text))
                dcom.CommandText = sql
                dcom.ExecuteNonQuery()
                txtScore.Text = ""
                Me.Hide()
            ElseIf lblTable.Text = "tblMrTop5" Then
                sql = String.Format("UPDATE {0} SET [{1}] = {2} WHERE [ID] = {3}", lblTable.Text, frm_Flash.lbl_JID.Text, txtScore.Text, Val(lblID2.Text))
                dcom.CommandText = sql
                dcom.ExecuteNonQuery()
                txtScore.Text = ""
                Me.Hide()
            Else
                sql = String.Format("UPDATE tbl_conpro SET [{0}] = '{1}' WHERE [CID] = {2} AND [JID] = {3}", lblCat.Text, txtScore.Text, lblID.Text, frm_Flash.lbl_JID.Text)
                dcom.CommandText = sql
                dcom.ExecuteNonQuery()
                frm_Preset2.con_pb.txtCandi.Text = txtScore.Text
                txtScore.Text = ""
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'me.hide
        Me.Close()
    End Sub
End Class