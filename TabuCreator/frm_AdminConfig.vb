Imports System.Data.OleDb
Public Class frm_AdminConfig
    Dim da As New OleDbDataAdapter
    Dim dset As New DataSet
    Dim dcom As New OleDbCommand

    Dim sql As String
    Dim tbl As String

    Dim frmname As String
    Dim frmid As String
    Dim flashname As String
    Dim flashpath As String

    Dim conimgpath As String

    Private Sub frm_AdminConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ramcon()
        popDgvCon()
        popDgvJudge()
        popDgvCat()
    End Sub

    Private Sub frm_AdminConfig_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        popDgvCon()
        popDgvJudge()
        popDgvCat()
    End Sub

    Sub popDgvCon()
        tbl = "tbl_contestants"
        sql = "SELECT * FROM tbl_contestants order by [CID] asc"
        da = New OleDbDataAdapter(sql, ultracon)
        dset = New DataSet
        da.Fill(dset, tbl)
        dgv_con.DataSource = dset.Tables(tbl).DefaultView
        With dgv_con
            .Columns(0).HeaderText = "Contestant Number"
            .Columns(1).HeaderText = "Contestant Name"
            .Columns(2).HeaderText = "Image"

            .Columns(0).Width = 200
            .Columns(1).Width = 350
            .Columns(2).Width = 200
        End With
    End Sub

    Sub clearCon()
        txt_conNum.Text = ""
        txt_conName.Text = ""
        lbl_cid.Text = ""
        lbl_conImg.Text = ""
        pb_con.BackgroundImage = Nothing
        btn_saveCon.Enabled = True
        btn_upCat.Enabled = False
        btn_delCat.Enabled = False
    End Sub

    Sub addCon()
        Try
            'pb_con.BackgroundImage = Nothing
            FileCopy(conimgpath, Application.StartupPath + "\Images\" + lbl_conImg.Text)
            'MsgBox("File Successfully Uploaded")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Try
            Dim dcom As New OleDbCommand
            dcom.Connection = ultracon
            dcom.CommandText = "INSERT INTO tbl_contestants([CID],[con_name],[con_pic]) VALUES(@num, @name, @pic)"
            dcom.Parameters.AddWithValue("@num", txt_conNum.Text)
            dcom.Parameters.AddWithValue("@name", txt_conName.Text)
            dcom.Parameters.AddWithValue("@pic", lbl_conImg.Text)
            dcom.CommandType = CommandType.Text
            dcom.ExecuteNonQuery()
            dcom.Parameters.Clear()

            dcom.Connection = ultracon
            dcom.CommandText = "INSERT INTO tbl_ave([CID],[con_name]) VALUES(@num, @name)"
            dcom.Parameters.AddWithValue("@num", txt_conNum.Text)
            dcom.Parameters.AddWithValue("@name", txt_conName.Text)
            dcom.CommandType = CommandType.Text
            dcom.ExecuteNonQuery()
            dcom.Parameters.Clear()

            'dcom.Connection = ultracon
            'dcom.CommandText = "INSERT INTO tbl_conpro([CID],[con_name]) VALUES(@num, @name)"
            'dcom.Parameters.AddWithValue("@num", txt_conNum.Text)
            'dcom.Parameters.AddWithValue("@name", txt_conName.Text)
            'dcom.CommandType = CommandType.Text
            'dcom.ExecuteNonQuery()
            'dcom.Parameters.Clear()
            addConJudge()
        Catch ex As Exception
            'MsgBox(ex.ToString)
            MsgBox("Something went wrong check all fields")
        End Try
    End Sub

    Sub addConJudge()
        Try
            Dim dcom As New OleDbCommand
            dcom.Connection = ultracon

            Dim tbl As String = "tbl_judges"
            da = New OleDbDataAdapter("select * from tbl_judges order by JID asc", ultracon)
            dset = New DataSet
            da.Fill(dset, tbl)

            For Each judges As DataRow In dset.Tables(tbl).Rows
                dcom.CommandText = "INSERT INTO tbl_conpro([CID],[con_name],[JID]) VALUES(@cid, @conname, @jid)"
                dcom.Parameters.AddWithValue("@cid", txt_conNum.Text)
                dcom.Parameters.AddWithValue("@conname", txt_conName.Text)
                dcom.Parameters.AddWithValue("@jid", judges.Item(0))
                dcom.CommandType = CommandType.Text
                dcom.ExecuteNonQuery()
                dcom.Parameters.Clear()
            Next
            clearCon()
            MsgBox("Contestant Added.")
        Catch ex As Exception
        End Try
    End Sub

    Sub upCon()
        Try
            pb_con.BackgroundImage = Nothing
            FileCopy(conimgpath, Application.StartupPath + "\Images\" + lbl_conImg.Text)
            'MsgBox("File Successfully Uploaded")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Dim dcom As New OleDbCommand
        Try
            dcom.Connection = ultracon
            dcom.CommandText = "UPDATE tbl_contestants SET [CID] = @num, [con_name] = @name, [con_pic] = @pic WHERE [CID] = @id"
            dcom.Parameters.AddWithValue("@num", txt_conNum.Text)
            dcom.Parameters.AddWithValue("@name", txt_conName.Text)
            dcom.Parameters.AddWithValue("@pic", lbl_conImg.Text)
            dcom.Parameters.AddWithValue("@id", lbl_cid.Text)
            dcom.CommandType = CommandType.Text
            dcom.ExecuteNonQuery()
            dcom.Parameters.Clear()
            'MsgBox(dcom.CommandText)
            'Debug.WriteLine(txtUname.Text + " " + txtPass.Text + " " + txtAccess.Text + " " + txtId.Text)
            MsgBox("Contestant Updated")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        clearCon()
    End Sub

    Sub delCon()
        dcom.Connection = ultracon
        dcom.CommandText = "DELETE FROM tbl_contestants WHERE [CID] =" & txt_conNum.Text
        dcom.CommandType = CommandType.Text
        dcom.ExecuteNonQuery()
        MsgBox("Contestant Deleted")

        clearCon()
    End Sub

    Private Sub btn_upConImg_Click(sender As Object, e As EventArgs) Handles btn_upConImg.Click
        ofd_con.ShowDialog()
    End Sub

    Private Sub ofd_con_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ofd_con.FileOk
        lbl_conImg.Text = ofd_con.SafeFileName
        conimgpath = ofd_con.FileName
        pb_con.BackgroundImage = Image.FromFile(conimgpath)
    End Sub

    Private Sub btn_saveCon_Click(sender As Object, e As EventArgs) Handles btn_saveCon.Click
        If txt_conName.Text <> "" And txt_conNum.Text <> "" And lbl_conImg.Text <> "" Then
            addCon()
            'addConJudge()
        Else
            MsgBox("Fill All Fields")
        End If
    End Sub

    Private Sub btn_upCon_Click(sender As Object, e As EventArgs) Handles btn_upCon.Click
        If txt_conName.Text <> "" And txt_conNum.Text <> "" Then
            upCon()
        Else
            MsgBox("Fill All Fields")
        End If
    End Sub

    Private Sub btn_delCon_Click(sender As Object, e As EventArgs) Handles btn_delCon.Click
        If txt_conName.Text <> "" And txt_conNum.Text <> "" Then
            delCon()
        Else
            MsgBox("No contestant to delete is selected")
        End If
    End Sub

    Private Sub btn_clearCon_Click(sender As Object, e As EventArgs) Handles btn_clearCon.Click
        'clear
        clearCon()
        btn_saveCon.Enabled = True
        btn_upCon.Enabled = False
        btn_delCon.Enabled = False
    End Sub

    Private Sub dgv_con_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_con.CellClick

        If e.RowIndex <> -1 Then
            'lblstatus.Text = "Edit"
            'txtId.Enabled = False
            btn_saveCon.Enabled = False
            btn_upCon.Enabled = True
            btn_delCon.Enabled = True
            lbl_cid.Text = dgv_con.Item(0, e.RowIndex).Value.ToString
            txt_conNum.Text = dgv_con.Item(0, e.RowIndex).Value.ToString
            txt_conName.Text = dgv_con.Item(1, e.RowIndex).Value.ToString
            lbl_conImg.Text = dgv_con.Item(2, e.RowIndex).Value.ToString
            If dgv_con.Item(2, e.RowIndex).Value.ToString = "Nothing" Then
                pb_con.BackgroundImage = Nothing
            Else
                pb_con.BackgroundImage = Image.FromFile(Application.StartupPath & "/Images/" & dgv_con.Item(2, e.RowIndex).Value.ToString)
            End If
        End If
    End Sub

    Sub popDgvJudge()
        tbl = "tbl_judges"
        sql = "SELECT * FROM tbl_judges order by [JID] asc"
        da = New OleDbDataAdapter(sql, ultracon)
        dset = New DataSet
        da.Fill(dset, tbl)
        dgv_judges.DataSource = dset.Tables(tbl).DefaultView
        With dgv_judges
            .Columns(0).HeaderText = "JID"
            .Columns(1).HeaderText = "Username"
            .Columns(2).HeaderText = "Password"

            .Columns(0).Width = 70
            '.Columns(0).Visible = False
            .Columns(1).Width = 200
            .Columns(2).Width = 200
            .Columns(3).Visible = False
            .Columns(4).Visible = False
        End With
    End Sub

    Sub addJudge()
        Try
            Dim dcom As New OleDbCommand
            dcom.Connection = ultracon
            dcom.CommandText = "INSERT INTO tbl_judges([JID], [username],[password]) VALUES(@jid, @jname, @jpass)"
            dcom.Parameters.AddWithValue("@jid", txt_jid.Text)
            dcom.Parameters.AddWithValue("@jname", txt_juser.Text)
            dcom.Parameters.AddWithValue("@jpass", txt_jpass.Text)
            dcom.CommandType = CommandType.Text
            dcom.ExecuteNonQuery()
            dcom.Parameters.Clear()

            addJudgeCon()
            MsgBox("Judge Added.")
        Catch ex As Exception
            'MsgBox(ex.Message)
            MsgBox("Duplicate Judge No. Detected")
        End Try
    End Sub

    Sub addJudgeCon()
        Try
            Dim dcom As New OleDbCommand
            dcom.Connection = ultracon
            'UPDATE [your table] SET [your table].[newcolumn] = [your table].[old column]
            'dcom.CommandText = "UPDATE [tbl_conpro] SET [tbl_conpro].[CID] = [tbl_contestants].[CID]"
            'dcom.CommandType = CommandType.Text
            'dcom.ExecuteNonQuery()

            Dim tbl As String = "tbl_contestants"
            da = New OleDbDataAdapter("select * from tbl_contestants order by CID asc", ultracon)
            dset = New DataSet
            da.Fill(dset, tbl)

            'Dim tbljid As String = "tbl_judges"
            'Dim dajid = New OleDbDataAdapter("select ID from tbl_judges where [username] = " & txt_user.Text & "", ultracon)
            'Dim dsetjid As New DataSet
            'dajid.Fill(dsetjid, tbljid)
            'Dim conjid As Integer = dsetjid.Tables("tbl_judges").Rows(0).Item(0)

            For Each cons As DataRow In dset.Tables(tbl).Rows
                dcom.CommandText = "INSERT INTO tbl_conpro([CID],[con_name],[JID]) VALUES(@cid, @conname, @jid)"
                dcom.Parameters.AddWithValue("@cid", cons.Item(0).ToString)
                dcom.Parameters.AddWithValue("@conname", cons.Item(1).ToString)
                dcom.Parameters.AddWithValue("@jid", txt_jid.Text)
                dcom.CommandType = CommandType.Text
                dcom.ExecuteNonQuery()
                dcom.Parameters.Clear()
            Next
        Catch ex As Exception
            MsgBox("Something Went Wrong")
        End Try
    End Sub

    Sub upJudge()
        Dim dcom As New OleDbCommand
        dcom.Connection = ultracon
        dcom.CommandText = "UPDATE tbl_judges SET [JID] = @jid, [username] = @jname, [password] = @jpass WHERE [JID] = @id"
        dcom.Parameters.AddWithValue("@jid", txt_jid.Text)
        dcom.Parameters.AddWithValue("@jname", txt_juser.Text)
        dcom.Parameters.AddWithValue("@jpass", txt_jpass.Text)
        dcom.Parameters.AddWithValue("@id", lbl_jid.Text)
        dcom.CommandType = CommandType.Text
        dcom.ExecuteNonQuery()
        dcom.Parameters.Clear()

        MsgBox("Judge Updated")

        txt_juser.Text = ""
        txt_jpass.Text = ""
        txt_jid.Text = ""
        lbl_jid.Text = ""
        btn_saveJudge.Enabled = True
        btn_upJudge.Enabled = False
        btn_delJudge.Enabled = False
    End Sub

    Sub delJudge()
        dcom.Connection = ultracon
        dcom.CommandText = "DELETE FROM tbl_judges WHERE [JID] =" & txt_jid.Text
        dcom.CommandType = CommandType.Text
        dcom.ExecuteNonQuery()
        MsgBox("Judge Deleted")

        txt_juser.Text = ""
        txt_jpass.Text = ""
        txt_jid.Clear()
        lbl_jid.Text = ""
        btn_saveJudge.Enabled = True
        btn_upJudge.Enabled = False
        btn_delJudge.Enabled = False
    End Sub

    'Sub delJudgeCon()
    '    dcom.Connection = ultracon
    '    dcom.CommandText = "DELETE FROM tbl_conpro WHERE [JID] =" & txt_jid.Text
    '    dcom.CommandType = CommandType.Text
    '    dcom.ExecuteNonQuery()
    'End Sub

    Private Sub btn_newJudge_Click(sender As Object, e As EventArgs) Handles btn_newJudge.Click
        txt_juser.Clear()
        txt_jpass.Clear()
        txt_jid.Clear()
        btn_saveJudge.Enabled = True
        btn_upJudge.Enabled = False
        btn_delJudge.Enabled = False
    End Sub

    Private Sub btn_saveJudge_Click(sender As Object, e As EventArgs) Handles btn_saveJudge.Click
        If txt_juser.Text <> "" And txt_jpass.Text <> "" And txt_jid.Text <> "" Then
            addJudge()
        Else
            MsgBox("Fill All Fields")
        End If
    End Sub

    Private Sub btn_upJudge_Click(sender As Object, e As EventArgs) Handles btn_upJudge.Click
        If txt_juser.Text <> "" And txt_jpass.Text <> "" And txt_jid.Text <> "" Then
            upJudge()
        Else
            MsgBox("Fill All Fields")
        End If
    End Sub

    Private Sub btn_delJudge_Click(sender As Object, e As EventArgs) Handles btn_delJudge.Click
        If txt_juser.Text <> "" And txt_jpass.Text <> "" Then
            'delJudgeCon()
            delJudge()
        Else
            MsgBox("No judge is selected to be deleted")
        End If
    End Sub

    Private Sub dgv_judges_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_judges.CellClick

        If e.RowIndex <> -1 Then
            'lblstatus.Text = "Edit"
            'txtId.Enabled = False

            btn_saveJudge.Enabled = False
            btn_newJudge.Enabled = True
            btn_upJudge.Enabled = True
            btn_delJudge.Enabled = True
            'txt_jid.Enabled = False

            txt_jid.Text = dgv_judges.Item(0, e.RowIndex).Value.ToString
            txt_juser.Text = dgv_judges.Item(1, e.RowIndex).Value.ToString
            txt_jpass.Text = dgv_judges.Item(2, e.RowIndex).Value.ToString
        Else

        End If
    End Sub

    Sub popDgvCat()
        tbl = "tbl_category"
        sql = "SELECT * FROM tbl_category order by [cat_id] asc"
        da = New OleDbDataAdapter(sql, ultracon)
        dset = New DataSet
        da.Fill(dset, tbl)
        dgv_cat.DataSource = dset.Tables(tbl).DefaultView
        With dgv_cat
            .Columns(0).HeaderText = "Category Sequence"
            .Columns(1).HeaderText = "Category Name"

            .Columns(0).Width = 150
            .Columns(1).Width = 300
        End With
    End Sub

    Sub addCat()
        Dim dcom As New OleDbCommand
        dcom.Connection = ultracon
        dcom.CommandText = "INSERT INTO tbl_category([cat_id],[cat_name]) VALUES(@catnum, @catname)"
        dcom.Parameters.AddWithValue("@catNum", txt_catNum.Text)
        dcom.Parameters.AddWithValue("@catName", txt_catName.Text)
        dcom.CommandType = CommandType.Text
        dcom.ExecuteNonQuery()
        dcom.Parameters.Clear()

        MsgBox("Category Added.")

        txt_catNum.Text = ""
        txt_catName.Text = ""
    End Sub

    Sub addColCat()
        Dim dcom As New OleDbCommand
        dcom.Connection = ultracon
        dcom.CommandText = "ALTER TABLE tbl_conpro ADD [" & txt_catName.Text & "] FLOAT DEFAULT 0"
        dcom.CommandType = CommandType.Text
        dcom.ExecuteNonQuery()
        dcom.Parameters.Clear()

        dcom.Connection = ultracon
        dcom.CommandText = "ALTER TABLE tbl_ave ADD [" & txt_catName.Text & "] FLOAT DEFAULT 0"
        dcom.CommandType = CommandType.Text
        dcom.ExecuteNonQuery()
        dcom.Parameters.Clear()
    End Sub

    Sub upCat()
        Dim dcom As New OleDbCommand
        dcom.Connection = ultracon
        dcom.CommandText = "UPDATE tbl_category SET [cat_id] = @catNum, [cat_name] = @catName WHERE [cat_id] = @id"
        dcom.Parameters.AddWithValue("@catNum", txt_catNum.Text)
        dcom.Parameters.AddWithValue("@catName", txt_catName.Text)
        dcom.Parameters.AddWithValue("@id", lbl_catid.Text)
        dcom.CommandType = CommandType.Text
        dcom.ExecuteNonQuery()
        dcom.Parameters.Clear()

        MsgBox("Category Updated")

        txt_catNum.Text = ""
        txt_catName.Text = ""
        lblUpCat.Text = ""
        lbl_catid.Text = ""
        btn_newCat.Enabled = True
        btn_saveCat.Enabled = True
        btn_upCat.Enabled = False
        btn_delCat.Enabled = False
    End Sub

    Sub upColCat()
        Dim dcom As New OleDbCommand
        dcom.Connection = ultracon
        'dcom.CommandText = "ALTER TABLE tbl_conpro RENAME COLUMN " & lblUpCat.Text & " TO " & txt_catName.Text
        'dcom.CommandText = "sp_rename 'tbl_conpro.'," & lblUpCat.Text & "' '" & txt_catName.Text & "', 'COLUMN';"
        dcom.CommandText = "ALTER TABLE tbl_conpro ADD [" & txt_catName.Text & "] FLOAT DEFAULT 0"
        dcom.CommandType = CommandType.Text
        dcom.ExecuteNonQuery()

        'copy column a to column b
        'UPDATE [your table] SET [your table].[newcolumn] = [your table].[old column]

        dcom.CommandText = "ALTER TABLE tbl_conpro DROP COLUMN [" & lblUpCat.Text & "]"
        dcom.CommandType = CommandType.Text
        dcom.ExecuteNonQuery()

        'tbl_ave
        dcom.Connection = ultracon
        dcom.CommandText = "ALTER TABLE tbl_ave ADD [" & txt_catName.Text & "] FLOAT DEFAULT 0"
        dcom.CommandType = CommandType.Text
        dcom.ExecuteNonQuery()

        dcom.CommandText = "ALTER TABLE tbl_ave DROP COLUMN [" & lblUpCat.Text & "]"
        dcom.CommandType = CommandType.Text
        dcom.ExecuteNonQuery()
    End Sub

    Sub delCat()
        'Dim dcom As New OleDbCommand
        dcom.Connection = ultracon
        dcom.CommandText = "DELETE FROM [tbl_category] WHERE [cat_id] =" & lbl_catid.Text
        dcom.CommandType = CommandType.Text
        dcom.ExecuteNonQuery()
        MsgBox("Category Deleted")

        txt_catNum.Text = ""
        txt_catName.Text = ""
        lblUpCat.Text = ""
        lbl_catid.Text = ""
        btn_newCat.Enabled = True
        btn_saveCat.Enabled = True
        btn_upCat.Enabled = False
        btn_delCat.Enabled = False
    End Sub

    Sub delColCat()
        Dim dcom As New OleDbCommand
        dcom.Connection = ultracon
        dcom.CommandText = "ALTER TABLE [tbl_conpro] DROP COLUMN [" & txt_catName.Text & "]"
        dcom.CommandType = CommandType.Text
        dcom.ExecuteNonQuery()

        dcom.Connection = ultracon
        dcom.CommandText = "ALTER TABLE [tbl_ave] DROP COLUMN [" & txt_catName.Text & "]"
        dcom.CommandType = CommandType.Text
        dcom.ExecuteNonQuery()
    End Sub

    Private Sub btn_newCat_Click(sender As Object, e As EventArgs) Handles btn_newCat.Click
        txt_catNum.Clear()
        txt_catName.Clear()
        btn_saveCat.Enabled = True
        btn_upCat.Enabled = False
        btn_delCat.Enabled = False
    End Sub

    Private Sub btn_saveCat_Click(sender As Object, e As EventArgs) Handles btn_saveCat.Click
        If txt_catName.Text <> "" And txt_catNum.Text <> "" Then
            addColCat()
            addCat()
        Else
            MsgBox("Fill All Fields")
        End If
        'create table tbl_'+txt_catName.text+'
    End Sub

    Private Sub btnUpCat_Click(sender As Object, e As EventArgs) Handles btn_upCat.Click
        If txt_catName.Text <> "" And txt_catNum.Text <> "" Then
            If txt_catName.Text = lblUpCat.Text Then
                upCat()
            Else
                upColCat()
                upCat()
            End If
        Else
            MsgBox("Fill All Fields")
        End If
    End Sub

    Private Sub btn_delCat_Click(sender As Object, e As EventArgs) Handles btn_delCat.Click
        If txt_catName.Text <> "" And txt_catNum.Text <> "" Then
            delColCat()
            delCat()
        Else
            MsgBox("No Category Is Selected")
        End If
    End Sub

    Private Sub dgv_cat_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_cat.CellClick
        If e.RowIndex <> -1 Then
            btn_saveCat.Enabled = False
            btn_upCat.Enabled = True
            btn_delCat.Enabled = True

            lbl_catid.Text = dgv_cat.Item(0, e.RowIndex).Value.ToString
            txt_catNum.Text = dgv_cat.Item(0, e.RowIndex).Value.ToString
            txt_catName.Text = dgv_cat.Item(1, e.RowIndex).Value.ToString
            lblUpCat.Text = dgv_cat.Item(1, e.RowIndex).Value.ToString
        Else

        End If
    End Sub

    Sub upload()
        Try
            FileCopy(flashpath, Application.StartupPath + "\Images\" + flashname)
            Dim dcom As New OleDbCommand
            dcom.Connection = ultracon
            dcom.CommandText = "UPDATE tbl_design SET [col_path] = @colname WHERE [ID] = @id"
            dcom.Parameters.AddWithValue("@colname", flashname)
            dcom.Parameters.AddWithValue("@id", frmid)
            'dcom.Parameters.AddWithValue("@colname", Application.StartupPath + "\Images\" + flashname)
            dcom.CommandType = CommandType.Text
            dcom.ExecuteNonQuery()
            dcom.Parameters.Clear()
            MsgBox("File Successfully Uploaded")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btn_upload_Click(sender As Object, e As EventArgs) Handles btn_upload.Click
        frmid = "1"
        ofd_bg.ShowDialog()
        upload()
        frm_Flash.bgload()
    End Sub

    Private Sub btn_preview_Click(sender As Object, e As EventArgs) Handles btn_preview.Click
        'Me.Hide()
        frm_Flash.Show()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ofd_bg.FileOk
        'frmid = 1
        flashpath = ofd_bg.FileName
        flashname = ofd_bg.SafeFileName
    End Sub

    Private Sub btn_pres1_Click(sender As Object, e As EventArgs) Handles btn_pres1.Click
        frm_Preset1.Show()
    End Sub

    Private Sub btn_pres2_Click(sender As Object, e As EventArgs) Handles btn_pres2.Click
        frm_Preset2.Show()
    End Sub

    Private Sub btn_pres3_Click(sender As Object, e As EventArgs) Handles btn_pres3.Click

    End Sub

    Private Sub btn_uppresbg_Click(sender As Object, e As EventArgs) Handles btn_uppresbg.Click
        frmid = "2"
        ofd_bg.ShowDialog()
        upload()
        bgpresload()
    End Sub

    Private Sub btn_pctrl_Click(sender As Object, e As EventArgs) Handles btn_pctrl.Click
        Me.Hide()
        frm_AdminPCtrl.Show()
    End Sub

    Private Sub frm_AdminConfig_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("You sure you want to close this? This will close the entire program", "Close Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            ' Cancel the Closing event from closing the form.
            e.Cancel = True
        End If
    End Sub

    Private Sub frm_AdminConfig_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        dcom = New OleDbCommand
        dcom.Connection = ultracon

        sql = String.Format("UPDATE tbl_users SET [status] = 'Offline' WHERE [accesslvl]  = 'admin'")
        dcom.CommandText = sql
        dcom.ExecuteNonQuery()
        MsgBox("You have been logged out. Now closing...")
        Application.Exit()
    End Sub

    Private Sub txt_conName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_conName.KeyPress
#Disable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
        If e.KeyChar.IsLetter(e.KeyChar) = False And e.KeyChar.IsControl(e.KeyChar) = False And e.KeyChar.IsSeparator(e.KeyChar) = False Then
#Enable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
            e.Handled = True
        End If
    End Sub

    Private Sub txt_conNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_conNum.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or Asc(e.KeyChar) = 8)
    End Sub

    Private Sub txt_juser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_juser.KeyPress
#Disable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
        If e.KeyChar.IsLetter(e.KeyChar) = False And e.KeyChar.IsControl(e.KeyChar) = False And e.KeyChar.IsSeparator(e.KeyChar) = False Then
#Enable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
            e.Handled = True
        End If
    End Sub

    Private Sub txt_jpass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_jpass.KeyPress
#Disable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
        If e.KeyChar.IsLetter(e.KeyChar) = False And e.KeyChar.IsControl(e.KeyChar) = False And e.KeyChar.IsSeparator(e.KeyChar) = False Then
#Enable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
            e.Handled = True
        End If
    End Sub

    Private Sub txt_jid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_jid.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or Asc(e.KeyChar) = 8)
    End Sub

    Private Sub txt_catName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_catName.KeyPress
#Disable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
        If e.KeyChar.IsLetter(e.KeyChar) = False And e.KeyChar.IsControl(e.KeyChar) = False And e.KeyChar.IsSeparator(e.KeyChar) = False Then
#Enable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
            e.Handled = True
        End If
    End Sub

    Private Sub txt_catNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_catNum.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or Asc(e.KeyChar) = 8)
    End Sub

    Private Sub btnContestant_Click(sender As Object, e As EventArgs) Handles btnContestant.Click
        btnContestant.BackColor = Color.FromArgb(80, 255, 255, 255)
        pnlContestant.Visible = True
        pnlJudges.Visible = False
        pnlCategory.Visible = False
        pnlDesign.Visible = False
        pnlKeypad.Visible = False
    End Sub

    Private Sub btnJudges_Click(sender As Object, e As EventArgs) Handles btnJudges.Click
        btnJudges.BackColor = Color.FromArgb(80, 255, 255, 255)
        pnlContestant.Visible = False
        pnlJudges.Visible = True
        pnlCategory.Visible = False
        pnlDesign.Visible = False
        pnlKeypad.Visible = False
    End Sub

    Private Sub btnCategory_Click(sender As Object, e As EventArgs) Handles btnCategory.Click
        btnCategory.BackColor = Color.FromArgb(80, 255, 255, 255)
        pnlContestant.Visible = False
        pnlJudges.Visible = False
        pnlCategory.Visible = True
        pnlDesign.Visible = False
        pnlKeypad.Visible = False
    End Sub

    Private Sub btnDesign_Click(sender As Object, e As EventArgs) Handles btnDesign.Click
        btnDesign.BackColor = Color.FromArgb(80, 255, 255, 255)
        pnlContestant.Visible = False
        pnlJudges.Visible = False
        pnlCategory.Visible = False
        pnlDesign.Visible = True
        pnlKeypad.Visible = False

    End Sub

    Private Sub btnKeypad_Click(sender As Object, e As EventArgs) Handles btnKeypad.Click
        btnKeypad.BackColor = Color.FromArgb(80, 255, 255, 255)
        pnlContestant.Visible = False
        pnlJudges.Visible = False
        pnlCategory.Visible = False
        pnlDesign.Visible = False
        pnlKeypad.Visible = True
    End Sub

    Private Sub btnContestant_Leave(sender As Object, e As EventArgs) Handles btnContestant.Leave
        btnContestant.BackColor = Color.Transparent
    End Sub

    Private Sub btnJudges_Leave(sender As Object, e As EventArgs) Handles btnJudges.Leave
        btnJudges.BackColor = Color.Transparent
    End Sub

    Private Sub btnCategory_Leave(sender As Object, e As EventArgs) Handles btnCategory.Leave
        btnCategory.BackColor = Color.Transparent
    End Sub

    Private Sub btnDesign_Leave(sender As Object, e As EventArgs) Handles btnDesign.Leave
        btnDesign.BackColor = Color.Transparent
    End Sub

    Private Sub btnKeypad_Leave(sender As Object, e As EventArgs) Handles btnKeypad.Leave
        btnKeypad.BackColor = Color.Transparent
    End Sub

    Private Sub btn_clearCon_MouseHover(sender As Object, e As EventArgs) Handles btn_clearCon.MouseHover
        btn_clearCon.BackColor = Color.FromArgb(240, 85, 134)
    End Sub

    Private Sub btn_clearCon_MouseLeave(sender As Object, e As EventArgs) Handles btn_clearCon.MouseLeave
        btn_clearCon.BackColor = Color.FromArgb(191, 192, 194)
    End Sub

    Private Sub btn_saveCon_MouseHover(sender As Object, e As EventArgs) Handles btn_saveCon.MouseHover
        btn_saveCon.BackColor = Color.FromArgb(240, 85, 134)
    End Sub

    Private Sub btn_saveCon_MouseLeave(sender As Object, e As EventArgs) Handles btn_saveCon.MouseLeave
        btn_saveCon.BackColor = Color.FromArgb(191, 192, 194)
    End Sub

    Private Sub btn_upCon_MouseHover(sender As Object, e As EventArgs) Handles btn_upCon.MouseHover
        btn_upCon.BackColor = Color.FromArgb(240, 85, 134)
    End Sub

    Private Sub btn_upCon_MouseLeave(sender As Object, e As EventArgs) Handles btn_upCon.MouseLeave
        btn_upCon.BackColor = Color.FromArgb(191, 192, 194)
    End Sub

    Private Sub btn_delCon_MouseHover(sender As Object, e As EventArgs) Handles btn_delCon.MouseHover
        btn_delCon.BackColor = Color.FromArgb(240, 85, 134)
    End Sub

    Private Sub btn_delCon_MouseLeave(sender As Object, e As EventArgs) Handles btn_delCon.MouseLeave
        btn_delCon.BackColor = Color.FromArgb(191, 192, 194)
    End Sub

    Private Sub btn_newJudge_MouseHover(sender As Object, e As EventArgs) Handles btn_newJudge.MouseHover
        btn_newJudge.BackColor = Color.FromArgb(240, 85, 134)
    End Sub

    Private Sub btn_newJudge_MouseLeave(sender As Object, e As EventArgs) Handles btn_newJudge.MouseLeave
        btn_newJudge.BackColor = Color.FromArgb(191, 192, 194)
    End Sub

    Private Sub btn_saveJudge_MouseHover(sender As Object, e As EventArgs) Handles btn_saveJudge.MouseHover
        btn_saveJudge.BackColor = Color.FromArgb(240, 85, 134)
    End Sub

    Private Sub btn_saveJudge_MouseLeave(sender As Object, e As EventArgs) Handles btn_saveJudge.MouseLeave
        btn_saveJudge.BackColor = Color.FromArgb(191, 192, 194)
    End Sub

    Private Sub btn_upJudge_MouseHover(sender As Object, e As EventArgs) Handles btn_upJudge.MouseHover
        btn_upJudge.BackColor = Color.FromArgb(240, 85, 134)
    End Sub

    Private Sub btn_upJudge_MouseLeave(sender As Object, e As EventArgs) Handles btn_upJudge.MouseLeave
        btn_upJudge.BackColor = Color.FromArgb(191, 192, 194)
    End Sub

    Private Sub btn_delJudge_MouseHover(sender As Object, e As EventArgs) Handles btn_delJudge.MouseHover
        btn_delJudge.BackColor = Color.FromArgb(240, 85, 134)
    End Sub

    Private Sub btn_delJudge_MouseLeave(sender As Object, e As EventArgs) Handles btn_delJudge.MouseLeave
        btn_delJudge.BackColor = Color.FromArgb(191, 192, 194)
    End Sub

    Private Sub btn_newCat_MouseHover(sender As Object, e As EventArgs) Handles btn_newCat.MouseHover
        btn_newCat.BackColor = Color.FromArgb(240, 85, 134)
    End Sub

    Private Sub btn_newCat_MouseLeave(sender As Object, e As EventArgs) Handles btn_newCat.MouseLeave
        btn_newCat.BackColor = Color.FromArgb(191, 192, 194)
    End Sub

    Private Sub btn_saveCat_MouseHover(sender As Object, e As EventArgs) Handles btn_saveCat.MouseHover
        btn_saveCat.BackColor = Color.FromArgb(240, 85, 134)
    End Sub

    Private Sub btn_saveCat_MouseLeave(sender As Object, e As EventArgs) Handles btn_saveCat.MouseLeave
        btn_saveCat.BackColor = Color.FromArgb(191, 192, 194)
    End Sub

    Private Sub btn_upCat_MouseHover(sender As Object, e As EventArgs) Handles btn_upCat.MouseHover
        btn_upCat.BackColor = Color.FromArgb(240, 85, 134)
    End Sub

    Private Sub btn_upCat_MouseLeave(sender As Object, e As EventArgs) Handles btn_upCat.MouseLeave
        btn_upCat.BackColor = Color.FromArgb(191, 192, 194)
    End Sub

    Private Sub btn_delCat_MouseHover(sender As Object, e As EventArgs) Handles btn_delCat.MouseHover
        btn_delCat.BackColor = Color.FromArgb(240, 85, 134)
    End Sub

    Private Sub btn_delCat_MouseLeave(sender As Object, e As EventArgs) Handles btn_delCat.MouseLeave
        btn_delCat.BackColor = Color.FromArgb(191, 192, 194)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub
End Class