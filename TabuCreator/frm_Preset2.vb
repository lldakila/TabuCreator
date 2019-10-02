Imports System.Data.OleDb
Public Class frm_Preset2
    Dim da As New OleDbDataAdapter
    Dim dset As New DataSet
    Dim dcom As New OleDbCommand

    Dim da2 As New OleDbDataAdapter
    Dim dset2 As New DataSet
    Dim dcom2 As New OleDbCommand

    Dim sql As String
    Dim tbl As String

    Public con_pb As New uc_pbCandi

    Dim sum

    'Sub updateScore()
    '    Try
    '        dcom = New OleDbCommand
    '        dcom.Connection = ultracon
    '        sql = String.Format("SELECT [{0}] FROM [tbl_conpro] WHERE [ID] = {1}", lbl_cat.Text, pb.Tag.to)
    '        dcom.CommandText = sql
    '        MsgBox(dcom.CommandText)
    '        uc_pbCandi.txtCandi.Text = Convert.ToString(dcom.ExecuteScalar)
    '    Catch ex As Exception
    '    End Try
    'End Sub

    Sub updateScore()
        'da2 = New OleDbDataAdapter("SELECT * FROM tbl_conpro WHERE [JID] = " & frm_Flash.lbl_JID.Text & " ", ultracon)
        'dset2 = New DataSet
        'da2.Fill(dset, "tbl_conpro")
    End Sub

    Sub pbcandiload()
        Dim tbl As String = "tbl_contestants"
        da = New OleDbDataAdapter("select * from tbl_contestants order by CID asc", ultracon)
        dset = New DataSet
        da.Fill(dset, tbl)

        'da2 = New OleDbDataAdapter("SELECT * FROM tbl_conpro WHERE [JID] = " & frm_Flash.lbl_JID.Text & " ", ultracon)
        'dset2 = New DataSet
        'da2.Fill(dset, "tbl_conpro")
        For Each cons As DataRow In dset.Tables(tbl).Rows
            Dim con_pb As New uc_pbCandi
            con_pb.pb.BackgroundImage = Image.FromFile(Application.StartupPath & "/Images/" & cons.Item(2))
            con_pb.Size = New Size(150, 190)
            con_pb.pb.Size = New Size(150, 150)
            con_pb.Draggable(True)
            con_pb.pb.Tag = cons.Item(0)
            con_pb.txtCandi.Tag = cons.Item(0)
            'con_pb.Anchor.None
            'con_pb.pb.Draggable(True)
            'con_pb.txtCandi.Text = dset2.Tables("tbl_conpro").Rows((cons.Item(0) - 1)).Item(frm_Flash.lbl_JID.Text)
            frm_Keypad.lblID.Text = cons.Item(0)
            flp.Controls.Add(con_pb)

        Next
    End Sub

    Private Sub frm_Preset2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If frm_Flash.lbl_Access.Text = "Judge" Then
            Me.Text = "Judge " & frm_Flash.lbl_JID.Text
            lbl_cat.Text = frm_jctrl.currcatname
        ElseIf frm_Flash.lbl_Access.Text = "Admin" Then

        End If

        bgpresload()
        pbcandiload()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Try
        '    'uc_pbCandi.updateScore()
        '    'updateScore()
        '    'lbl_cat.Text = frm_jctrl.currcatname
        'Catch ex As Exception
        '    Timer1.Enabled = False
        '    If MsgBox("Connection to Server has been Lost !", MsgBoxStyle.RetryCancel) = vbRetry Then
        '        Timer1.Enabled = True
        '    Else

        '    End If
        'End Try
    End Sub

End Class