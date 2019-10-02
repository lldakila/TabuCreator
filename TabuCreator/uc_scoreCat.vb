Public Class uc_scoreCat
    Dim dotss As Integer

    Sub seeDotsss()
        dotss = 0
        For looop = 1 To (Len(txtScore.Text))
            If (Mid(txtScore.Text, looop, 1) = ".") Then
                dotss = 1
            End If
        Next
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
End Class
