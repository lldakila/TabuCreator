Imports System.Data.OleDb
Public Class frm_Preset1
    Dim ctr As Integer = 1
    Dim maxcon As Integer

    Dim da As New OleDbDataAdapter
    Dim dset As New DataSet
    Dim dcom As New OleDbCommand

    Sub candiload()
        Dim tbl As String = "tbl_contestants"
        da = New OleDbDataAdapter("select * from tbl_contestants order by CID asc", ultracon)
        dset = New DataSet
        da.Fill(dset, tbl)
        For Each cat As DataRow In dset.Tables(tbl).Rows
            Dim score_cat As New uc_scoreCat

            flp_scoreCat.Controls.Add(score_cat)
        Next
    End Sub

    Sub pop()
        Dim tbl As String = "tbl_contestants"
        da = New OleDbDataAdapter("select * from tbl_contestants where [CID]=" & ctr & "", ultracon)
        dset = New DataSet
        da.Fill(dset, tbl)
        Dim pbcandloc As String = dset.Tables("tbl_contestants").Rows(0).Item(2)
        pb_Candi.BackgroundImage = Image.FromFile(Application.StartupPath & "\Images\" & pbcandloc)
        lblID.Text = dset.Tables("tbl_contestants").Rows(0).Item(0)
    End Sub

    Sub countmaxcon()
        Dim tbl As String = "tbl_contestants"
        da = New OleDbDataAdapter("select * from tbl_contestants order by [CID] desc", ultracon)
        dset = New DataSet
        da.Fill(dset, tbl)
        maxcon = dset.Tables("tbl_contestants").Rows(0).Item(0)
    End Sub

    Private Sub frm_Preset1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        countmaxcon()
        bgpresload()
        pop()
        btn_Prev.Enabled = False
    End Sub

    Private Sub btn_Next_Click(sender As Object, e As EventArgs) Handles btn_Next.Click
        ctr = ctr + 1
        pop()
        btn_Prev.Enabled = True
        If ctr = maxcon Then
            btn_Next.Enabled = False
        Else
        End If
    End Sub

    Private Sub btn_Prev_Click(sender As Object, e As EventArgs) Handles btn_Prev.Click
        ctr = ctr - 1
        pop()
        btn_Next.Enabled = True
        If ctr = 1 Then
            btn_Prev.Enabled = False

        Else
            btn_Prev.Enabled = True
        End If
    End Sub

    Private Sub frm_Preset1_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        'If ctr = 1 Then
        '    btn_Prev.Enabled = False
        'Else
        '    btn_Prev.Enabled = True
        'End If

    End Sub
End Class