<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AdminPCtrl
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_AdminPCtrl))
        Me.lblMs = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cb_category = New System.Windows.Forms.ComboBox()
        Me.btn_start = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnComputeTotalAll = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgv_scores = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnPreviewAve = New System.Windows.Forms.Button()
        Me.btn_rptAve = New System.Windows.Forms.Button()
        Me.dgv_ave = New System.Windows.Forms.DataGridView()
        Me.btn_config = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_ptitle = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.pd1 = New System.Drawing.Printing.PrintDocument()
        Me.btn_prevCat = New System.Windows.Forms.Button()
        Me.pd_cat = New System.Drawing.Printing.PrintDocument()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgv_scores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgv_ave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMs
        '
        Me.lblMs.AutoSize = True
        Me.lblMs.BackColor = System.Drawing.SystemColors.Control
        Me.lblMs.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMs.ForeColor = System.Drawing.Color.Black
        Me.lblMs.Location = New System.Drawing.Point(317, 23)
        Me.lblMs.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMs.Name = "lblMs"
        Me.lblMs.Size = New System.Drawing.Size(64, 23)
        Me.lblMs.TabIndex = 22
        Me.lblMs.Text = "Label1"
        Me.lblMs.Visible = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.GroupBox5.Controls.Add(Me.cb_category)
        Me.GroupBox5.Controls.Add(Me.btn_start)
        Me.GroupBox5.Controls.Add(Me.btnStop)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.White
        Me.GroupBox5.Location = New System.Drawing.Point(18, 163)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Size = New System.Drawing.Size(368, 113)
        Me.GroupBox5.TabIndex = 21
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Category"
        '
        'cb_category
        '
        Me.cb_category.BackColor = System.Drawing.SystemColors.Control
        Me.cb_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_category.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_category.ForeColor = System.Drawing.Color.Black
        Me.cb_category.FormattingEnabled = True
        Me.cb_category.Location = New System.Drawing.Point(8, 23)
        Me.cb_category.Margin = New System.Windows.Forms.Padding(4)
        Me.cb_category.Name = "cb_category"
        Me.cb_category.Size = New System.Drawing.Size(348, 37)
        Me.cb_category.TabIndex = 7
        '
        'btn_start
        '
        Me.btn_start.BackColor = System.Drawing.SystemColors.Control
        Me.btn_start.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_start.ForeColor = System.Drawing.Color.Black
        Me.btn_start.Location = New System.Drawing.Point(8, 68)
        Me.btn_start.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(140, 39)
        Me.btn_start.TabIndex = 8
        Me.btn_start.Text = "Start !"
        Me.btn_start.UseVisualStyleBackColor = False
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.SystemColors.Control
        Me.btnStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop.ForeColor = System.Drawing.Color.Black
        Me.btnStop.Location = New System.Drawing.Point(216, 68)
        Me.btnStop.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(140, 39)
        Me.btnStop.TabIndex = 9
        Me.btnStop.Text = "Stop !"
        Me.btnStop.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.btnComputeTotalAll)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(18, 313)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(363, 63)
        Me.GroupBox4.TabIndex = 23
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Total"
        '
        'btnComputeTotalAll
        '
        Me.btnComputeTotalAll.BackColor = System.Drawing.SystemColors.Control
        Me.btnComputeTotalAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComputeTotalAll.ForeColor = System.Drawing.Color.Black
        Me.btnComputeTotalAll.Location = New System.Drawing.Point(107, 23)
        Me.btnComputeTotalAll.Margin = New System.Windows.Forms.Padding(4)
        Me.btnComputeTotalAll.Name = "btnComputeTotalAll"
        Me.btnComputeTotalAll.Size = New System.Drawing.Size(156, 32)
        Me.btnComputeTotalAll.TabIndex = 6
        Me.btnComputeTotalAll.Text = "Total Din !"
        Me.btnComputeTotalAll.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(401, 48)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(387, 681)
        Me.TabControl1.TabIndex = 25
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btn_prevCat)
        Me.TabPage1.Controls.Add(Me.dgv_scores)
        Me.TabPage1.Location = New System.Drawing.Point(4, 32)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(379, 645)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Criteria"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgv_scores
        '
        Me.dgv_scores.AllowUserToAddRows = False
        Me.dgv_scores.AllowUserToDeleteRows = False
        Me.dgv_scores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_scores.BackgroundColor = System.Drawing.Color.White
        Me.dgv_scores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.dgv_scores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_scores.GridColor = System.Drawing.SystemColors.ButtonShadow
        Me.dgv_scores.Location = New System.Drawing.Point(7, 44)
        Me.dgv_scores.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_scores.Name = "dgv_scores"
        Me.dgv_scores.ReadOnly = True
        Me.dgv_scores.RowHeadersWidth = 40
        Me.dgv_scores.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgv_scores.RowTemplate.Height = 37
        Me.dgv_scores.Size = New System.Drawing.Size(365, 594)
        Me.dgv_scores.TabIndex = 21
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnPreviewAve)
        Me.TabPage2.Controls.Add(Me.btn_rptAve)
        Me.TabPage2.Controls.Add(Me.dgv_ave)
        Me.TabPage2.Location = New System.Drawing.Point(4, 32)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(379, 645)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Average"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnPreviewAve
        '
        Me.btnPreviewAve.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPreviewAve.BackColor = System.Drawing.SystemColors.Control
        Me.btnPreviewAve.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPreviewAve.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreviewAve.ForeColor = System.Drawing.Color.Black
        Me.btnPreviewAve.Location = New System.Drawing.Point(216, 7)
        Me.btnPreviewAve.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPreviewAve.Name = "btnPreviewAve"
        Me.btnPreviewAve.Size = New System.Drawing.Size(156, 32)
        Me.btnPreviewAve.TabIndex = 23
        Me.btnPreviewAve.Text = "Report Preview"
        Me.btnPreviewAve.UseVisualStyleBackColor = False
        '
        'btn_rptAve
        '
        Me.btn_rptAve.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_rptAve.BackColor = System.Drawing.SystemColors.Control
        Me.btn_rptAve.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_rptAve.ForeColor = System.Drawing.Color.Black
        Me.btn_rptAve.Location = New System.Drawing.Point(52, 7)
        Me.btn_rptAve.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_rptAve.Name = "btn_rptAve"
        Me.btn_rptAve.Size = New System.Drawing.Size(156, 32)
        Me.btn_rptAve.TabIndex = 7
        Me.btn_rptAve.Text = "Report"
        Me.btn_rptAve.UseVisualStyleBackColor = False
        Me.btn_rptAve.Visible = False
        '
        'dgv_ave
        '
        Me.dgv_ave.AllowUserToAddRows = False
        Me.dgv_ave.AllowUserToDeleteRows = False
        Me.dgv_ave.AllowUserToOrderColumns = True
        Me.dgv_ave.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_ave.BackgroundColor = System.Drawing.Color.White
        Me.dgv_ave.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal
        Me.dgv_ave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_ave.GridColor = System.Drawing.SystemColors.ButtonShadow
        Me.dgv_ave.Location = New System.Drawing.Point(7, 46)
        Me.dgv_ave.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_ave.Name = "dgv_ave"
        Me.dgv_ave.ReadOnly = True
        Me.dgv_ave.RowHeadersWidth = 40
        Me.dgv_ave.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgv_ave.RowTemplate.Height = 37
        Me.dgv_ave.Size = New System.Drawing.Size(365, 592)
        Me.dgv_ave.TabIndex = 22
        '
        'btn_config
        '
        Me.btn_config.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btn_config.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_config.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_config.ForeColor = System.Drawing.Color.Transparent
        Me.btn_config.Location = New System.Drawing.Point(0, 79)
        Me.btn_config.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_config.Name = "btn_config"
        Me.btn_config.Size = New System.Drawing.Size(395, 45)
        Me.btn_config.TabIndex = 26
        Me.btn_config.Text = "Pageant Config"
        Me.btn_config.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbl_ptitle)
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Controls.Add(Me.btn_config)
        Me.Panel1.Controls.Add(Me.GroupBox5)
        Me.Panel1.Controls.Add(Me.lblMs)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(395, 741)
        Me.Panel1.TabIndex = 27
        '
        'lbl_ptitle
        '
        Me.lbl_ptitle.AutoSize = True
        Me.lbl_ptitle.Location = New System.Drawing.Point(251, 420)
        Me.lbl_ptitle.Name = "lbl_ptitle"
        Me.lbl_ptitle.Size = New System.Drawing.Size(97, 17)
        Me.lbl_ptitle.TabIndex = 27
        Me.lbl_ptitle.Text = "Total Average"
        Me.lbl_ptitle.Visible = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(717, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 48)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(640, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 48)
        Me.Button2.TabIndex = 36
        Me.Button2.Text = "_"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'pd1
        '
        '
        'btn_prevCat
        '
        Me.btn_prevCat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_prevCat.BackColor = System.Drawing.SystemColors.Control
        Me.btn_prevCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_prevCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_prevCat.ForeColor = System.Drawing.Color.Black
        Me.btn_prevCat.Location = New System.Drawing.Point(216, 7)
        Me.btn_prevCat.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_prevCat.Name = "btn_prevCat"
        Me.btn_prevCat.Size = New System.Drawing.Size(156, 32)
        Me.btn_prevCat.TabIndex = 24
        Me.btn_prevCat.Text = "Report Preview"
        Me.btn_prevCat.UseVisualStyleBackColor = False
        '
        'pd_cat
        '
        '
        'frm_AdminPCtrl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 741)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_AdminPCtrl"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Pageant Control"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgv_scores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgv_ave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblMs As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents cb_category As ComboBox
    Friend WithEvents btn_start As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnComputeTotalAll As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents dgv_scores As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgv_ave As DataGridView
    Friend WithEvents btn_config As Button
    Friend WithEvents btn_rptAve As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents pd1 As Printing.PrintDocument
    Friend WithEvents lbl_ptitle As Label
    Friend WithEvents btnPreviewAve As Button
    Friend WithEvents btn_prevCat As Button
    Friend WithEvents pd_cat As Printing.PrintDocument
End Class
