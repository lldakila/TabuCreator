Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frm_AdminPCtrl

    'Dim ptitle As String = "Total Averages"

    ''' <summary>
    ''' structire to hold printed page details
    ''' </summary>
    ''' <remarks></remarks>
    Private Structure pageDetails
        Dim columns As Integer
        Dim rows As Integer
        Dim startCol As Integer
        Dim startRow As Integer
    End Structure
    ''' <summary>
    ''' dictionary to hold printed page details, with index key
    ''' </summary>
    ''' <remarks></remarks>
    Private pages As Dictionary(Of Integer, pageDetails)

    Dim maxPagesWide As Integer
    Dim maxPagesTall As Integer

    Dim da As New OleDbDataAdapter
    Dim dset As New DataSet
    Dim dcom As New OleDbCommand

    Dim cmd As New SqlCommand

    Dim conCount As Integer

    Dim ctrl As String

    Dim sql As String
    Dim tbl As String

    Sub popCat()
        Dim tbl As String = "tbl_category"
        da = New OleDbDataAdapter("select * from [tbl_category] order by [cat_id] asc", ultracon)
        dset = New DataSet
        da.Fill(dset, tbl)
        For Each cat As DataRow In dset.Tables(tbl).Rows
            cb_category.Items.Add(cat.Item(1).ToString)
        Next
    End Sub

    Sub popDgvScores()
        tbl = "tbl_conpro"
        sql = "SELECT * FROM [tbl_conpro] order by [CID] asc, [JID] asc"
        da = New OleDbDataAdapter(sql, ultracon)
        dset = New DataSet
        da.Fill(dset, tbl)
        dgv_scores.DataSource = dset.Tables(tbl).DefaultView
        With dgv_scores
            .Columns(1).HeaderText = "CID"
            .Columns(2).HeaderText = "Contestant Name"
            .Columns(3).HeaderText = "JID"

            .Columns(0).Visible = False
            .Columns(1).Width = 50
            .Columns(2).Width = 350
            .Columns(3).Width = 50
        End With
    End Sub

    Sub popDgvAve()
        tbl = "tbl_ave"
        sql = "SELECT * FROM [tbl_ave] order by [CID] asc"
        da = New OleDbDataAdapter(sql, ultracon)
        dset = New DataSet
        da.Fill(dset, tbl)
        dgv_ave.DataSource = dset.Tables(tbl).DefaultView
        With dgv_ave
            .Columns(0).HeaderText = "CID"
            .Columns(1).HeaderText = "Contestant Name"
            .Columns(2).HeaderText = "Total"

            .Columns(0).Width = 75
            .Columns(1).Width = 350
            .Columns(2).Width = 75
        End With
    End Sub

    Private Sub frm_AdminPCtrl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ramcon()
        popCat()
        popDgvScores()
        popDgvAve()
    End Sub

    Sub controlClient()
        dcom = New OleDbCommand
        dcom.Connection = ultracon
        sql = String.Format("UPDATE tbl_control SET [ClientControl] = {0}, [cat_name] = '{1}'", ctrl, cb_category.Text)
        dcom.CommandText = sql
        dcom.ExecuteNonQuery()
    End Sub

    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click
        If cb_category.Text <> "" And MsgBox(cb_category.Text & " Na?", MsgBoxStyle.YesNo) = vbYes Then
            ctrl = 1
            'frm_Preset2.lbl_cat.Text = cb_category.Text
            controlClient()
        Else

        End If
    End Sub

    Private Sub frm_AdminPCtrl_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("You sure you want to close this? This will close the entire program", "Close Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            ' Cancel the Closing event from closing the form.
            e.Cancel = True
        End If
    End Sub

    Private Sub frm_AdminPCtrl_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        dcom = New OleDbCommand
        dcom.Connection = ultracon

        sql = String.Format("UPDATE tbl_users SET [status] = 'Offline' WHERE [accesslvl]  = 'admin'")
        dcom.CommandText = sql
        dcom.ExecuteNonQuery()
        MsgBox("You have been logged out. Now closing...")
        Application.Exit()
    End Sub

    Sub stopClient()
        dcom = New OleDbCommand
        dcom.Connection = ultracon
        dcom.CommandText = "UPDATE tbl_control SET [ClientControl] = 0, [cat_name] = 'None'"
        dcom.ExecuteNonQuery()
    End Sub

    Sub countCon()
        dcom = New OleDbCommand
        dcom.Connection = ultracon
        sql = String.Format("SELECT COUNT(CID) FROM [tbl_contestants]")
        dcom.CommandText = sql
        conCount = Convert.ToInt32(dcom.ExecuteScalar)
        MsgBox("Number of contestants are: " & conCount)
        'dcom.ExecuteNonQuery()
    End Sub

    Sub computeTotal()
        dcom = New OleDbCommand
        dcom.Connection = ultracon
        sql = String.Format("SELECT COUNT(CID) FROM [tbl_contestants]")
        dcom.CommandText = sql
        conCount = Convert.ToInt32(dcom.ExecuteScalar)
        For index = 1 To conCount
            dcom = New OleDbCommand
            dcom.Connection = ultracon
            sql = String.Format("SELECT AVG([{0}]) FROM [tbl_conpro] WHERE [CID] = {1}", cb_category.Text, index)
            dcom.CommandText = sql
            'MsgBox(dcom.CommandText)
            'Dim avg As Double = dcom.ExecuteScalar()
            Dim avg = dcom.ExecuteScalar()
            'MsgBox("Average of con" & index & ": " & avg)

            dcom = New OleDbCommand
            dcom.Connection = ultracon
            sql = String.Format("UPDATE tbl_ave SET [{0}] = '{1}' WHERE [CID] = {2}", cb_category.Text, avg, index)
            dcom.CommandText = sql
            'MsgBox(dcom.CommandText)
            dcom.ExecuteNonQuery()
        Next
        popDgvAve()
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        If cb_category.Text <> "" Then
            If MsgBox("Tapos na ung " & cb_category.Text, MsgBoxStyle.YesNo) = vbYes Then
                stopClient()
                computeTotal()
            End If
        ElseIf cb_category.Text = "" Then
            MsgBox("Select A Category")
        Else
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        popDgvScores()
        'popDgvAve()
    End Sub

    Sub totalTotal()
        dcom = New OleDbCommand
        dcom.Connection = ultracon
        sql = String.Format("SELECT COUNT(CID) FROM [tbl_contestants]")
        dcom.CommandText = sql
        conCount = Convert.ToInt32(dcom.ExecuteScalar)

        dcom = New OleDbCommand
        dcom.Connection = ultracon
        sql = String.Format("SELECT COUNT(cat_id) FROM [tbl_category]")
        dcom.CommandText = sql
        Dim catCount As Integer
        catCount = Convert.ToInt32(dcom.ExecuteScalar)

        sql = String.Format("SELECT * FROM [tbl_ave]")
        da = New OleDbDataAdapter(sql, ultracon)
        dset = New DataSet
        da.Fill(dset, "tbl_ave")
        dcom = New OleDbCommand
        dcom.Connection = ultracon

        For a = 0 To conCount - 1
            Dim total As Double = 0
            For b = 3 To 2 + catCount
                total += dset.Tables("tbl_ave").Rows(a).Item(b)
                'MsgBox(dset.Tables("tbl_ave").Rows(a).Item(b))
                'MsgBox(total)
            Next
            'MsgBox(total)
            total = total / catCount
            'MsgBox(total)
            sql = String.Format("UPDATE [tbl_ave] SET [Total] = {0} WHERE [CID] = {1}", total, a + 1)
            dcom.CommandText = sql
            'MsgBox(dcom.CommandText)
            dcom.ExecuteNonQuery()
        Next
        MsgBox("Total Computed")
    End Sub

    Private Sub btnComputeTotalAll_Click(sender As Object, e As EventArgs) Handles btnComputeTotalAll.Click
        'compute total ave for tbl_ave
        totalTotal()
    End Sub

    Private Sub btn_conCount_Click(sender As Object, e As EventArgs)
        countCon()
    End Sub

    Private Sub btn_config_Click(sender As Object, e As EventArgs) Handles btn_config.Click
        Me.Hide()
        frm_AdminConfig.Show()
    End Sub

    Private Sub frm_AdminPCtrl_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        popDgvAve()
    End Sub


    ''' <summary>
    ''' starts print job
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btn_rptAve_Click(sender As Object, e As EventArgs) Handles btn_rptAve.Click
        'Dim crTables As Tables
        'Dim crTableLogonInfo As New TableLogOnInfo
        'Dim crConnectionInfo As New ConnectionInfo
        'Dim crTable As Table

        'Dim rptDoc As New ReportDocument()
        'rptDoc.Load(Application.StartupPath & "\cr_ave.rpt")

        'With crConnectionInfo
        '    .ServerName = Application.StartupPath & "\db_tabu.mdb"
        'End With

        'crTables = rptDoc.Database.Tables

        'For Each crTable In crTables
        '    crTableLogonInfo = crTable.LogOnInfo
        '    crTableLogonInfo.ConnectionInfo = crConnectionInfo
        '    crTable.ApplyLogOnInfo(crTableLogonInfo)
        'Next

        'Dim reportQuery As String = String.Empty
        'reportQuery = "SELECT * FROM [tbl_ave]"
        'With frm_rptAve.crv1
        '    .SelectionFormula = reportQuery
        '    .ReportSource = rptDoc
        '    .Refresh()
        '    .RefreshReport()
        'End With
        'frm_rptAve.Show()

        'Dim ppd As New PrintPreviewDialog
        'ppd.Document = pd1
        'ppd.WindowState = FormWindowState.Maximized
        'ppd.ShowDialog()

        pd1.Print()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub


    '''' <summary>
    '''' the majority of this Sub is calculating printed page ranges
    '''' </summary>
    '''' <param name="sender"></param>
    '''' <param name="e"></param>
    '''' <remarks></remarks>
    'Private Sub pd1_BeginPrint(sender As Object, e As Printing.PrintEventArgs) Handles pd1.BeginPrint
    '    ''this removes the printed page margins
    '    pd1.OriginAtMargins = True
    '    pd1.DefaultPageSettings.Margins = New Drawing.Printing.Margins(0, 0, 0, 0)

    '    pages = New Dictionary(Of Integer, pageDetails)

    '    Dim maxWidth As Integer = CInt(pd1.DefaultPageSettings.PrintableArea.Width) - 40
    '    Dim maxHeight As Integer = CInt(pd1.DefaultPageSettings.PrintableArea.Height) - 40 + lbl_ptitle.Height

    '    Dim pageCounter As Integer = 0
    '    pages.Add(pageCounter, New pageDetails)

    '    Dim columnCounter As Integer = 0

    '    Dim columnSum As Integer = dgv_ave.RowHeadersWidth

    '    For c As Integer = 0 To dgv_ave.Columns.Count - 1
    '        If columnSum + dgv_ave.Columns(c).Width < maxWidth Then
    '            columnSum += dgv_ave.Columns(c).Width
    '            columnCounter += 1
    '        Else
    '            pages(pageCounter) = New pageDetails With {.columns = columnCounter, .rows = 0, .startCol = pages(pageCounter).startCol}
    '            columnSum = dgv_ave.RowHeadersWidth + dgv_ave.Columns(c).Width
    '            columnCounter = 1
    '            pageCounter += 1
    '            pages.Add(pageCounter, New pageDetails With {.startCol = c})
    '        End If
    '        If c = dgv_ave.Columns.Count - 1 Then
    '            If pages(pageCounter).columns = 0 Then
    '                pages(pageCounter) = New pageDetails With {.columns = columnCounter, .rows = 0, .startCol = pages(pageCounter).startCol}
    '            End If
    '        End If
    '    Next

    '    maxPagesWide = pages.Keys.Max + 1

    '    pageCounter = 0

    '    Dim rowCounter As Integer = 0

    '    Dim rowSum As Integer = dgv_ave.ColumnHeadersHeight

    '    For r As Integer = 0 To dgv_ave.Rows.Count - 2
    '        If rowSum + dgv_ave.Rows(r).Height < maxHeight Then
    '            rowSum += dgv_ave.Rows(r).Height
    '            rowCounter += 1
    '        Else
    '            pages(pageCounter) = New pageDetails With {.columns = pages(pageCounter).columns, .rows = rowCounter, .startCol = pages(pageCounter).startCol, .startRow = pages(pageCounter).startRow}
    '            For x As Integer = 1 To maxPagesWide - 1
    '                pages(pageCounter + x) = New pageDetails With {.columns = pages(pageCounter + x).columns, .rows = rowCounter, .startCol = pages(pageCounter + x).startCol, .startRow = pages(pageCounter).startRow}
    '            Next

    '            pageCounter += maxPagesWide
    '            For x As Integer = 0 To maxPagesWide - 1
    '                pages.Add(pageCounter + x, New pageDetails With {.columns = pages(x).columns, .rows = 0, .startCol = pages(x).startCol, .startRow = r})
    '            Next

    '            rowSum = dgv_ave.ColumnHeadersHeight + dgv_ave.Rows(r).Height
    '            rowCounter = 1
    '        End If
    '        If r = dgv_ave.Rows.Count - 2 Then
    '            For x As Integer = 0 To maxPagesWide - 1
    '                If pages(pageCounter + x).rows = 0 Then
    '                    pages(pageCounter + x) = New pageDetails With {.columns = pages(pageCounter + x).columns, .rows = rowCounter, .startCol = pages(pageCounter + x).startCol, .startRow = pages(pageCounter + x).startRow}
    '                End If
    '            Next
    '        End If
    '    Next

    '    maxPagesTall = pages.Count \ maxPagesWide

    'End Sub

    'Private mRow As Integer = 0
    'Private newpage As Boolean = True
    Private Sub pd1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pd1.PrintPage
        Dim mRow As Integer = 0
        Dim newpage As Boolean = True
        ' sets it to show '...' for long text
        Dim fmt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
        fmt.LineAlignment = StringAlignment.Center
        fmt.Trimming = StringTrimming.EllipsisCharacter
        Dim y As Int32 = e.MarginBounds.Top
        Dim rc As Rectangle
        Dim x As Int32
        Dim h As Int32 = 0
        Dim row As DataGridViewRow

        ' print the header text for a new page
        '   use a grey bg just like the control
        If newpage Then
            row = dgv_ave.Rows(mRow)
            x = e.MarginBounds.Left
            For Each cell As DataGridViewCell In row.Cells
                ' since we are printing the control's view,
                ' skip invidible columns
                If cell.Visible Then
                    rc = New Rectangle(x, y, cell.Size.Width, cell.Size.Height)

                    e.Graphics.FillRectangle(Brushes.LightGray, rc)
                    e.Graphics.DrawRectangle(Pens.Black, rc)

                    ' reused in the data pront - should be a function
                    Select Case dgv_ave.Columns(cell.ColumnIndex).DefaultCellStyle.Alignment
                        Case DataGridViewContentAlignment.BottomRight,
                         DataGridViewContentAlignment.MiddleRight
                            fmt.Alignment = StringAlignment.Far
                            rc.Offset(-1, 0)
                        Case DataGridViewContentAlignment.BottomCenter,
                        DataGridViewContentAlignment.MiddleCenter
                            fmt.Alignment = StringAlignment.Center
                        Case Else
                            fmt.Alignment = StringAlignment.Near
                            rc.Offset(2, 0)
                    End Select

                    e.Graphics.DrawString(dgv_ave.Columns(cell.ColumnIndex).HeaderText,
                                            dgv_ave.Font, Brushes.Black, rc, fmt)
                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                End If
            Next
            y += h

        End If
        newpage = False

        ' now print the data for each row
        Dim thisNDX As Int32
        For thisNDX = mRow To dgv_ave.RowCount - 1
            ' no need to try to print the new row
            If dgv_ave.Rows(thisNDX).IsNewRow Then Exit For

            row = dgv_ave.Rows(thisNDX)
            x = e.MarginBounds.Left
            h = 0

            ' reset X for data
            x = e.MarginBounds.Left

            ' print the data
            For Each cell As DataGridViewCell In row.Cells
                If cell.Visible Then
                    rc = New Rectangle(x, y, cell.Size.Width, cell.Size.Height)

                    ' SAMPLE CODE: How To 
                    ' up a RowPrePaint rule
                    'If Convert.ToDecimal(row.Cells(5).Value) < 9.99 Then
                    '    Using br As New SolidBrush(Color.MistyRose)
                    '        e.Graphics.FillRectangle(br, rc)
                    '    End Using
                    'End If

                    e.Graphics.DrawRectangle(Pens.Black, rc)

                    Select Case dgv_ave.Columns(cell.ColumnIndex).DefaultCellStyle.Alignment
                        Case DataGridViewContentAlignment.BottomRight,
                         DataGridViewContentAlignment.MiddleRight
                            fmt.Alignment = StringAlignment.Far
                            rc.Offset(-1, 0)
                        Case DataGridViewContentAlignment.BottomCenter,
                        DataGridViewContentAlignment.MiddleCenter
                            fmt.Alignment = StringAlignment.Center
                        Case Else
                            fmt.Alignment = StringAlignment.Near
                            rc.Offset(2, 0)
                    End Select

                    e.Graphics.DrawString(cell.FormattedValue.ToString(),
                                      dgv_ave.Font, Brushes.Black, rc, fmt)

                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                End If

            Next
            y += h
            ' next row to print
            mRow = thisNDX + 1

            If y + h > e.MarginBounds.Bottom Then
                e.HasMorePages = True
                ' mRow -= 1   causes last row to rePrint on next page
                newpage = True
                Return
            End If
        Next
    End Sub


    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreviewAve.Click
        Dim ppd As New PrintPreviewDialog
        ppd.Document = pd1
        ppd.WindowState = FormWindowState.Maximized
        ppd.ShowDialog()
    End Sub

    Private Sub btnPreviewCat_Click(sender As Object, e As EventArgs) Handles btn_prevCat.Click
        Dim ppd_cat As New PrintPreviewDialog
        ppd_cat.Document = pd_cat
        ppd_cat.WindowState = FormWindowState.Maximized
        ppd_cat.ShowDialog()
    End Sub

    Private Sub pd_cat_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pd_cat.PrintPage
        Dim mRow As Integer = 0
        Dim newpage As Boolean = True
        ' sets it to show '...' for long text
        Dim fmt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
        fmt.LineAlignment = StringAlignment.Center
        fmt.Trimming = StringTrimming.EllipsisCharacter
        Dim y As Int32 = e.MarginBounds.Top
        Dim rc As Rectangle
        Dim x As Int32
        Dim h As Int32 = 0
        Dim row As DataGridViewRow

        ' print the header text for a new page
        '   use a grey bg just like the control
        If newpage Then
            row = dgv_scores.Rows(mRow)
            x = e.MarginBounds.Left
            For Each cell As DataGridViewCell In row.Cells
                ' since we are printing the control's view,
                ' skip invidible columns
                If cell.Visible Then
                    rc = New Rectangle(x, y, cell.Size.Width, cell.Size.Height)

                    e.Graphics.FillRectangle(Brushes.LightGray, rc)
                    e.Graphics.DrawRectangle(Pens.Black, rc)

                    ' reused in the data pront - should be a function
                    Select Case dgv_scores.Columns(cell.ColumnIndex).DefaultCellStyle.Alignment
                        Case DataGridViewContentAlignment.BottomRight,
                         DataGridViewContentAlignment.MiddleRight
                            fmt.Alignment = StringAlignment.Far
                            rc.Offset(-1, 0)
                        Case DataGridViewContentAlignment.BottomCenter,
                        DataGridViewContentAlignment.MiddleCenter
                            fmt.Alignment = StringAlignment.Center
                        Case Else
                            fmt.Alignment = StringAlignment.Near
                            rc.Offset(2, 0)
                    End Select

                    e.Graphics.DrawString(dgv_scores.Columns(cell.ColumnIndex).HeaderText,
                                            dgv_scores.Font, Brushes.Black, rc, fmt)
                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                End If
            Next
            y += h

        End If
        newpage = False

        ' now print the data for each row
        Dim thisNDX As Int32
        For thisNDX = mRow To dgv_scores.RowCount - 1
            ' no need to try to print the new row
            If dgv_scores.Rows(thisNDX).IsNewRow Then Exit For

            row = dgv_scores.Rows(thisNDX)
            x = e.MarginBounds.Left
            h = 0

            ' reset X for data
            x = e.MarginBounds.Left

            ' print the data
            For Each cell As DataGridViewCell In row.Cells
                If cell.Visible Then
                    rc = New Rectangle(x, y, cell.Size.Width, cell.Size.Height)

                    ' SAMPLE CODE: How To 
                    ' up a RowPrePaint rule
                    'If Convert.ToDecimal(row.Cells(5).Value) < 9.99 Then
                    '    Using br As New SolidBrush(Color.MistyRose)
                    '        e.Graphics.FillRectangle(br, rc)
                    '    End Using
                    'End If

                    e.Graphics.DrawRectangle(Pens.Black, rc)

                    Select Case dgv_scores.Columns(cell.ColumnIndex).DefaultCellStyle.Alignment
                        Case DataGridViewContentAlignment.BottomRight,
                         DataGridViewContentAlignment.MiddleRight
                            fmt.Alignment = StringAlignment.Far
                            rc.Offset(-1, 0)
                        Case DataGridViewContentAlignment.BottomCenter,
                        DataGridViewContentAlignment.MiddleCenter
                            fmt.Alignment = StringAlignment.Center
                        Case Else
                            fmt.Alignment = StringAlignment.Near
                            rc.Offset(2, 0)
                    End Select

                    e.Graphics.DrawString(cell.FormattedValue.ToString(),
                                      dgv_scores.Font, Brushes.Black, rc, fmt)

                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                End If

            Next
            y += h
            ' next row to print
            mRow = thisNDX + 1

            If y + h > e.MarginBounds.Bottom Then
                e.HasMorePages = True
                ' mRow -= 1   causes last row to rePrint on next page
                newpage = True
                Return
            End If
        Next
    End Sub
End Class