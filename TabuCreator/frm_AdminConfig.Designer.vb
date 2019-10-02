<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_AdminConfig
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_AdminConfig))
        Me.btn_saveLimit = New System.Windows.Forms.Button()
        Me.txt_lower = New System.Windows.Forms.TextBox()
        Me.txt_upper = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblUpCat = New System.Windows.Forms.Label()
        Me.lbl_catid = New System.Windows.Forms.Label()
        Me.btn_newCat = New System.Windows.Forms.Button()
        Me.btn_delCat = New System.Windows.Forms.Button()
        Me.btn_upCat = New System.Windows.Forms.Button()
        Me.btn_saveCat = New System.Windows.Forms.Button()
        Me.dgv_cat = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_catName = New System.Windows.Forms.TextBox()
        Me.txt_catNum = New System.Windows.Forms.TextBox()
        Me.lbl_jid = New System.Windows.Forms.Label()
        Me.txt_jid = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_newJudge = New System.Windows.Forms.Button()
        Me.btn_upJudge = New System.Windows.Forms.Button()
        Me.btn_delJudge = New System.Windows.Forms.Button()
        Me.dgv_judges = New System.Windows.Forms.DataGridView()
        Me.btn_saveJudge = New System.Windows.Forms.Button()
        Me.txt_jpass = New System.Windows.Forms.TextBox()
        Me.txt_juser = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_conImg = New System.Windows.Forms.Label()
        Me.btn_upConImg = New System.Windows.Forms.Button()
        Me.lbl_cid = New System.Windows.Forms.Label()
        Me.btn_clearCon = New System.Windows.Forms.Button()
        Me.btn_upCon = New System.Windows.Forms.Button()
        Me.btn_delCon = New System.Windows.Forms.Button()
        Me.dgv_con = New System.Windows.Forms.DataGridView()
        Me.btn_saveCon = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_conName = New System.Windows.Forms.TextBox()
        Me.txt_conNum = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_pres2 = New System.Windows.Forms.Button()
        Me.btn_uppresbg = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_upload = New System.Windows.Forms.Button()
        Me.btn_preview = New System.Windows.Forms.Button()
        Me.btn_pres3 = New System.Windows.Forms.Button()
        Me.btn_pres1 = New System.Windows.Forms.Button()
        Me.btn_pctrl = New System.Windows.Forms.Button()
        Me.ofd_bg = New System.Windows.Forms.OpenFileDialog()
        Me.ofd_con = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ptcbLogo = New System.Windows.Forms.PictureBox()
        Me.btnContestant = New System.Windows.Forms.Button()
        Me.btnJudges = New System.Windows.Forms.Button()
        Me.btnCategory = New System.Windows.Forms.Button()
        Me.btnDesign = New System.Windows.Forms.Button()
        Me.btnKeypad = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.pnlContestant = New System.Windows.Forms.Panel()
        Me.pb_con = New System.Windows.Forms.PictureBox()
        Me.pnlJudges = New System.Windows.Forms.Panel()
        Me.pnlCategory = New System.Windows.Forms.Panel()
        Me.pnlDesign = New System.Windows.Forms.Panel()
        Me.pnlKeypad = New System.Windows.Forms.Panel()
        CType(Me.dgv_cat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_judges, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_con, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ptcbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.pnlContestant.SuspendLayout()
        CType(Me.pb_con, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlJudges.SuspendLayout()
        Me.pnlCategory.SuspendLayout()
        Me.pnlDesign.SuspendLayout()
        Me.pnlKeypad.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_saveLimit
        '
        Me.btn_saveLimit.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_saveLimit.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_saveLimit.Location = New System.Drawing.Point(322, 145)
        Me.btn_saveLimit.Name = "btn_saveLimit"
        Me.btn_saveLimit.Size = New System.Drawing.Size(133, 42)
        Me.btn_saveLimit.TabIndex = 23
        Me.btn_saveLimit.Text = "Save Limits"
        Me.btn_saveLimit.UseVisualStyleBackColor = False
        '
        'txt_lower
        '
        Me.txt_lower.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_lower.Location = New System.Drawing.Point(222, 101)
        Me.txt_lower.Name = "txt_lower"
        Me.txt_lower.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_lower.Size = New System.Drawing.Size(233, 38)
        Me.txt_lower.TabIndex = 21
        '
        'txt_upper
        '
        Me.txt_upper.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_upper.Location = New System.Drawing.Point(222, 62)
        Me.txt_upper.Name = "txt_upper"
        Me.txt_upper.Size = New System.Drawing.Size(233, 38)
        Me.txt_upper.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(37, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 31)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Lower Limit:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 31)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Upper Limit:"
        '
        'lblUpCat
        '
        Me.lblUpCat.AutoSize = True
        Me.lblUpCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpCat.Location = New System.Drawing.Point(591, 110)
        Me.lblUpCat.Name = "lblUpCat"
        Me.lblUpCat.Size = New System.Drawing.Size(169, 29)
        Me.lblUpCat.TabIndex = 25
        Me.lblUpCat.Text = "Prev CatName"
        Me.lblUpCat.Visible = False
        '
        'lbl_catid
        '
        Me.lbl_catid.AutoSize = True
        Me.lbl_catid.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_catid.Location = New System.Drawing.Point(358, 39)
        Me.lbl_catid.Name = "lbl_catid"
        Me.lbl_catid.Size = New System.Drawing.Size(36, 29)
        Me.lbl_catid.TabIndex = 24
        Me.lbl_catid.Text = "ID"
        Me.lbl_catid.Visible = False
        '
        'btn_newCat
        '
        Me.btn_newCat.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btn_newCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_newCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_newCat.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_newCat.Location = New System.Drawing.Point(43, 171)
        Me.btn_newCat.Name = "btn_newCat"
        Me.btn_newCat.Size = New System.Drawing.Size(168, 71)
        Me.btn_newCat.TabIndex = 8
        Me.btn_newCat.Text = "Clear"
        Me.btn_newCat.UseVisualStyleBackColor = False
        '
        'btn_delCat
        '
        Me.btn_delCat.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btn_delCat.Enabled = False
        Me.btn_delCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delCat.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_delCat.Location = New System.Drawing.Point(592, 171)
        Me.btn_delCat.Name = "btn_delCat"
        Me.btn_delCat.Size = New System.Drawing.Size(168, 71)
        Me.btn_delCat.TabIndex = 7
        Me.btn_delCat.Text = "Delete"
        Me.btn_delCat.UseVisualStyleBackColor = False
        '
        'btn_upCat
        '
        Me.btn_upCat.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btn_upCat.Enabled = False
        Me.btn_upCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_upCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_upCat.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_upCat.Location = New System.Drawing.Point(409, 171)
        Me.btn_upCat.Name = "btn_upCat"
        Me.btn_upCat.Size = New System.Drawing.Size(168, 71)
        Me.btn_upCat.TabIndex = 6
        Me.btn_upCat.Text = "Update"
        Me.btn_upCat.UseVisualStyleBackColor = False
        '
        'btn_saveCat
        '
        Me.btn_saveCat.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btn_saveCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_saveCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_saveCat.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_saveCat.Location = New System.Drawing.Point(229, 171)
        Me.btn_saveCat.Name = "btn_saveCat"
        Me.btn_saveCat.Size = New System.Drawing.Size(168, 71)
        Me.btn_saveCat.TabIndex = 5
        Me.btn_saveCat.Text = "Add"
        Me.btn_saveCat.UseVisualStyleBackColor = False
        '
        'dgv_cat
        '
        Me.dgv_cat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_cat.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv_cat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_cat.Location = New System.Drawing.Point(17, 287)
        Me.dgv_cat.Name = "dgv_cat"
        Me.dgv_cat.RowTemplate.Height = 24
        Me.dgv_cat.Size = New System.Drawing.Size(1668, 683)
        Me.dgv_cat.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(38, 110)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(187, 29)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Category Name:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(39, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(160, 29)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Category No.:"
        '
        'txt_catName
        '
        Me.txt_catName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_catName.Location = New System.Drawing.Point(229, 105)
        Me.txt_catName.Name = "txt_catName"
        Me.txt_catName.Size = New System.Drawing.Size(326, 34)
        Me.txt_catName.TabIndex = 1
        '
        'txt_catNum
        '
        Me.txt_catNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_catNum.Location = New System.Drawing.Point(205, 34)
        Me.txt_catNum.MaxLength = 2
        Me.txt_catNum.Name = "txt_catNum"
        Me.txt_catNum.Size = New System.Drawing.Size(123, 34)
        Me.txt_catNum.TabIndex = 0
        '
        'lbl_jid
        '
        Me.lbl_jid.AutoSize = True
        Me.lbl_jid.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_jid.Location = New System.Drawing.Point(612, 119)
        Me.lbl_jid.Name = "lbl_jid"
        Me.lbl_jid.Size = New System.Drawing.Size(39, 29)
        Me.lbl_jid.TabIndex = 36
        Me.lbl_jid.Text = "jid"
        Me.lbl_jid.Visible = False
        '
        'txt_jid
        '
        Me.txt_jid.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_jid.Location = New System.Drawing.Point(599, 44)
        Me.txt_jid.MaxLength = 2
        Me.txt_jid.Name = "txt_jid"
        Me.txt_jid.Size = New System.Drawing.Size(57, 38)
        Me.txt_jid.TabIndex = 35
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(456, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 31)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Judge No.:"
        '
        'btn_newJudge
        '
        Me.btn_newJudge.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btn_newJudge.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_newJudge.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_newJudge.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_newJudge.Location = New System.Drawing.Point(24, 187)
        Me.btn_newJudge.Name = "btn_newJudge"
        Me.btn_newJudge.Size = New System.Drawing.Size(144, 71)
        Me.btn_newJudge.TabIndex = 33
        Me.btn_newJudge.Text = "Clear"
        Me.btn_newJudge.UseVisualStyleBackColor = False
        '
        'btn_upJudge
        '
        Me.btn_upJudge.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btn_upJudge.Enabled = False
        Me.btn_upJudge.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_upJudge.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_upJudge.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_upJudge.Location = New System.Drawing.Point(355, 186)
        Me.btn_upJudge.Name = "btn_upJudge"
        Me.btn_upJudge.Size = New System.Drawing.Size(144, 71)
        Me.btn_upJudge.TabIndex = 32
        Me.btn_upJudge.Text = "Update"
        Me.btn_upJudge.UseVisualStyleBackColor = False
        '
        'btn_delJudge
        '
        Me.btn_delJudge.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btn_delJudge.Enabled = False
        Me.btn_delJudge.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delJudge.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delJudge.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_delJudge.Location = New System.Drawing.Point(507, 187)
        Me.btn_delJudge.Name = "btn_delJudge"
        Me.btn_delJudge.Size = New System.Drawing.Size(144, 71)
        Me.btn_delJudge.TabIndex = 31
        Me.btn_delJudge.Text = "Delete"
        Me.btn_delJudge.UseVisualStyleBackColor = False
        '
        'dgv_judges
        '
        Me.dgv_judges.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_judges.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgv_judges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_judges.Location = New System.Drawing.Point(6, 287)
        Me.dgv_judges.Name = "dgv_judges"
        Me.dgv_judges.RowTemplate.Height = 24
        Me.dgv_judges.Size = New System.Drawing.Size(1684, 709)
        Me.dgv_judges.TabIndex = 24
        '
        'btn_saveJudge
        '
        Me.btn_saveJudge.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btn_saveJudge.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_saveJudge.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_saveJudge.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_saveJudge.Location = New System.Drawing.Point(185, 187)
        Me.btn_saveJudge.Name = "btn_saveJudge"
        Me.btn_saveJudge.Size = New System.Drawing.Size(155, 71)
        Me.btn_saveJudge.TabIndex = 22
        Me.btn_saveJudge.Text = "Add"
        Me.btn_saveJudge.UseVisualStyleBackColor = False
        '
        'txt_jpass
        '
        Me.txt_jpass.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_jpass.Location = New System.Drawing.Point(157, 112)
        Me.txt_jpass.Name = "txt_jpass"
        Me.txt_jpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9675)
        Me.txt_jpass.Size = New System.Drawing.Size(270, 38)
        Me.txt_jpass.TabIndex = 21
        '
        'txt_juser
        '
        Me.txt_juser.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_juser.Location = New System.Drawing.Point(194, 45)
        Me.txt_juser.Name = "txt_juser"
        Me.txt_juser.Size = New System.Drawing.Size(233, 38)
        Me.txt_juser.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 31)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Password:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(165, 31)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Judge Name:"
        '
        'lbl_conImg
        '
        Me.lbl_conImg.AutoSize = True
        Me.lbl_conImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_conImg.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_conImg.Location = New System.Drawing.Point(553, 46)
        Me.lbl_conImg.Name = "lbl_conImg"
        Me.lbl_conImg.Size = New System.Drawing.Size(2, 31)
        Me.lbl_conImg.TabIndex = 33
        Me.lbl_conImg.Visible = False
        '
        'btn_upConImg
        '
        Me.btn_upConImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_upConImg.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_upConImg.Location = New System.Drawing.Point(1005, 173)
        Me.btn_upConImg.Name = "btn_upConImg"
        Me.btn_upConImg.Size = New System.Drawing.Size(150, 35)
        Me.btn_upConImg.TabIndex = 32
        Me.btn_upConImg.Text = "Choose Image"
        Me.btn_upConImg.UseVisualStyleBackColor = True
        '
        'lbl_cid
        '
        Me.lbl_cid.AutoSize = True
        Me.lbl_cid.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cid.Location = New System.Drawing.Point(374, 46)
        Me.lbl_cid.Name = "lbl_cid"
        Me.lbl_cid.Size = New System.Drawing.Size(36, 29)
        Me.lbl_cid.TabIndex = 30
        Me.lbl_cid.Text = "ID"
        Me.lbl_cid.Visible = False
        '
        'btn_clearCon
        '
        Me.btn_clearCon.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btn_clearCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clearCon.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clearCon.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_clearCon.Location = New System.Drawing.Point(34, 171)
        Me.btn_clearCon.Name = "btn_clearCon"
        Me.btn_clearCon.Size = New System.Drawing.Size(177, 64)
        Me.btn_clearCon.TabIndex = 29
        Me.btn_clearCon.Text = "Clear"
        Me.btn_clearCon.UseVisualStyleBackColor = False
        '
        'btn_upCon
        '
        Me.btn_upCon.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btn_upCon.Enabled = False
        Me.btn_upCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_upCon.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_upCon.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_upCon.Location = New System.Drawing.Point(400, 171)
        Me.btn_upCon.Name = "btn_upCon"
        Me.btn_upCon.Size = New System.Drawing.Size(177, 64)
        Me.btn_upCon.TabIndex = 28
        Me.btn_upCon.Text = "Update"
        Me.btn_upCon.UseVisualStyleBackColor = False
        '
        'btn_delCon
        '
        Me.btn_delCon.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btn_delCon.Enabled = False
        Me.btn_delCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delCon.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delCon.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_delCon.Location = New System.Drawing.Point(583, 171)
        Me.btn_delCon.Name = "btn_delCon"
        Me.btn_delCon.Size = New System.Drawing.Size(177, 64)
        Me.btn_delCon.TabIndex = 27
        Me.btn_delCon.Text = "Delete"
        Me.btn_delCon.UseVisualStyleBackColor = False
        '
        'dgv_con
        '
        Me.dgv_con.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_con.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgv_con.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_con.Location = New System.Drawing.Point(36, 273)
        Me.dgv_con.Name = "dgv_con"
        Me.dgv_con.RowTemplate.Height = 24
        Me.dgv_con.Size = New System.Drawing.Size(1654, 673)
        Me.dgv_con.TabIndex = 26
        '
        'btn_saveCon
        '
        Me.btn_saveCon.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btn_saveCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_saveCon.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_saveCon.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_saveCon.Location = New System.Drawing.Point(217, 171)
        Me.btn_saveCon.Name = "btn_saveCon"
        Me.btn_saveCon.Size = New System.Drawing.Size(177, 64)
        Me.btn_saveCon.TabIndex = 4
        Me.btn_saveCon.Text = "Add"
        Me.btn_saveCon.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(204, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Contestant Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Contestant Number:"
        '
        'txt_conName
        '
        Me.txt_conName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_conName.Location = New System.Drawing.Point(254, 112)
        Me.txt_conName.Name = "txt_conName"
        Me.txt_conName.Size = New System.Drawing.Size(360, 34)
        Me.txt_conName.TabIndex = 1
        '
        'txt_conNum
        '
        Me.txt_conNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_conNum.Location = New System.Drawing.Point(257, 43)
        Me.txt_conNum.MaxLength = 2
        Me.txt_conNum.Name = "txt_conNum"
        Me.txt_conNum.Size = New System.Drawing.Size(91, 34)
        Me.txt_conNum.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_pres2)
        Me.GroupBox2.Controls.Add(Me.btn_uppresbg)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(105, 352)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(223, 209)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Scoring Form"
        '
        'btn_pres2
        '
        Me.btn_pres2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_pres2.Location = New System.Drawing.Point(26, 122)
        Me.btn_pres2.Name = "btn_pres2"
        Me.btn_pres2.Size = New System.Drawing.Size(170, 73)
        Me.btn_pres2.TabIndex = 3
        Me.btn_pres2.Text = "Preview Preset 2"
        Me.btn_pres2.UseVisualStyleBackColor = True
        '
        'btn_uppresbg
        '
        Me.btn_uppresbg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_uppresbg.Location = New System.Drawing.Point(26, 37)
        Me.btn_uppresbg.Name = "btn_uppresbg"
        Me.btn_uppresbg.Size = New System.Drawing.Size(170, 79)
        Me.btn_uppresbg.TabIndex = 5
        Me.btn_uppresbg.Text = "Upload Background"
        Me.btn_uppresbg.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_upload)
        Me.GroupBox1.Controls.Add(Me.btn_preview)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(105, 87)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(223, 209)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Flash Screen"
        '
        'btn_upload
        '
        Me.btn_upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_upload.Location = New System.Drawing.Point(26, 37)
        Me.btn_upload.Name = "btn_upload"
        Me.btn_upload.Size = New System.Drawing.Size(170, 79)
        Me.btn_upload.TabIndex = 0
        Me.btn_upload.Text = "Upload Background"
        Me.btn_upload.UseVisualStyleBackColor = True
        '
        'btn_preview
        '
        Me.btn_preview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_preview.Location = New System.Drawing.Point(26, 122)
        Me.btn_preview.Name = "btn_preview"
        Me.btn_preview.Size = New System.Drawing.Size(170, 73)
        Me.btn_preview.TabIndex = 1
        Me.btn_preview.Text = "Preview"
        Me.btn_preview.UseVisualStyleBackColor = True
        '
        'btn_pres3
        '
        Me.btn_pres3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_pres3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pres3.Location = New System.Drawing.Point(947, 248)
        Me.btn_pres3.Name = "btn_pres3"
        Me.btn_pres3.Size = New System.Drawing.Size(170, 73)
        Me.btn_pres3.TabIndex = 4
        Me.btn_pres3.Text = "Preview Preset 3"
        Me.btn_pres3.UseVisualStyleBackColor = True
        Me.btn_pres3.Visible = False
        '
        'btn_pres1
        '
        Me.btn_pres1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_pres1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pres1.Location = New System.Drawing.Point(947, 90)
        Me.btn_pres1.Name = "btn_pres1"
        Me.btn_pres1.Size = New System.Drawing.Size(170, 73)
        Me.btn_pres1.TabIndex = 2
        Me.btn_pres1.Text = "Preview Preset 1"
        Me.btn_pres1.UseVisualStyleBackColor = True
        Me.btn_pres1.Visible = False
        '
        'btn_pctrl
        '
        Me.btn_pctrl.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btn_pctrl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_pctrl.Font = New System.Drawing.Font("Microsoft YaHei", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pctrl.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_pctrl.Location = New System.Drawing.Point(1, 986)
        Me.btn_pctrl.Name = "btn_pctrl"
        Me.btn_pctrl.Size = New System.Drawing.Size(218, 44)
        Me.btn_pctrl.TabIndex = 0
        Me.btn_pctrl.Text = "Pageant Control"
        Me.btn_pctrl.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_pctrl.UseVisualStyleBackColor = False
        '
        'ofd_bg
        '
        Me.ofd_bg.FileName = "Some Image"
        Me.ofd_bg.Filter = "Image Files|*.png|Image Files|*.jpg"
        Me.ofd_bg.Title = "Choose Background Image"
        '
        'ofd_con
        '
        Me.ofd_con.FileName = "Some Image"
        Me.ofd_con.Filter = "Image Files|*.png|Image Files|*.jpg"
        Me.ofd_con.Title = "Choose Contestant Image"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Panel1.Controls.Add(Me.ptcbLogo)
        Me.Panel1.Controls.Add(Me.btnContestant)
        Me.Panel1.Controls.Add(Me.btnJudges)
        Me.Panel1.Controls.Add(Me.btnCategory)
        Me.Panel1.Controls.Add(Me.btnDesign)
        Me.Panel1.Controls.Add(Me.btnKeypad)
        Me.Panel1.Controls.Add(Me.btn_pctrl)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(219, 1055)
        Me.Panel1.TabIndex = 1
        '
        'ptcbLogo
        '
        Me.ptcbLogo.BackgroundImage = CType(resources.GetObject("ptcbLogo.BackgroundImage"), System.Drawing.Image)
        Me.ptcbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ptcbLogo.Location = New System.Drawing.Point(0, 12)
        Me.ptcbLogo.Name = "ptcbLogo"
        Me.ptcbLogo.Size = New System.Drawing.Size(213, 176)
        Me.ptcbLogo.TabIndex = 19
        Me.ptcbLogo.TabStop = False
        '
        'btnContestant
        '
        Me.btnContestant.BackColor = System.Drawing.Color.Transparent
        Me.btnContestant.FlatAppearance.BorderSize = 0
        Me.btnContestant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnContestant.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContestant.ForeColor = System.Drawing.SystemColors.Control
        Me.btnContestant.Location = New System.Drawing.Point(3, 196)
        Me.btnContestant.Name = "btnContestant"
        Me.btnContestant.Size = New System.Drawing.Size(213, 70)
        Me.btnContestant.TabIndex = 2
        Me.btnContestant.Text = "Contestant"
        Me.btnContestant.UseVisualStyleBackColor = False
        '
        'btnJudges
        '
        Me.btnJudges.BackColor = System.Drawing.Color.Transparent
        Me.btnJudges.FlatAppearance.BorderSize = 0
        Me.btnJudges.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJudges.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJudges.ForeColor = System.Drawing.SystemColors.Control
        Me.btnJudges.Location = New System.Drawing.Point(3, 293)
        Me.btnJudges.Name = "btnJudges"
        Me.btnJudges.Size = New System.Drawing.Size(213, 70)
        Me.btnJudges.TabIndex = 3
        Me.btnJudges.Text = "Judges"
        Me.btnJudges.UseVisualStyleBackColor = False
        '
        'btnCategory
        '
        Me.btnCategory.BackColor = System.Drawing.Color.Transparent
        Me.btnCategory.FlatAppearance.BorderSize = 0
        Me.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCategory.ForeColor = System.Drawing.SystemColors.Control
        Me.btnCategory.Location = New System.Drawing.Point(4, 391)
        Me.btnCategory.Name = "btnCategory"
        Me.btnCategory.Size = New System.Drawing.Size(213, 70)
        Me.btnCategory.TabIndex = 4
        Me.btnCategory.Text = "Category"
        Me.btnCategory.UseVisualStyleBackColor = False
        '
        'btnDesign
        '
        Me.btnDesign.BackColor = System.Drawing.Color.Transparent
        Me.btnDesign.FlatAppearance.BorderSize = 0
        Me.btnDesign.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDesign.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDesign.ForeColor = System.Drawing.SystemColors.Control
        Me.btnDesign.Location = New System.Drawing.Point(4, 489)
        Me.btnDesign.Name = "btnDesign"
        Me.btnDesign.Size = New System.Drawing.Size(213, 70)
        Me.btnDesign.TabIndex = 5
        Me.btnDesign.Text = "Design"
        Me.btnDesign.UseVisualStyleBackColor = False
        '
        'btnKeypad
        '
        Me.btnKeypad.BackColor = System.Drawing.Color.Transparent
        Me.btnKeypad.FlatAppearance.BorderSize = 0
        Me.btnKeypad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKeypad.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeypad.ForeColor = System.Drawing.SystemColors.Control
        Me.btnKeypad.Location = New System.Drawing.Point(5, 579)
        Me.btnKeypad.Name = "btnKeypad"
        Me.btnKeypad.Size = New System.Drawing.Size(213, 70)
        Me.btnKeypad.TabIndex = 6
        Me.btnKeypad.Text = "Keypad"
        Me.btnKeypad.UseVisualStyleBackColor = False
        Me.btnKeypad.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(219, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1702, 47)
        Me.Panel2.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(1541, -1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 48)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "_"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(1619, -1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 48)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'pnlContestant
        '
        Me.pnlContestant.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pnlContestant.Controls.Add(Me.lbl_conImg)
        Me.pnlContestant.Controls.Add(Me.Label1)
        Me.pnlContestant.Controls.Add(Me.dgv_con)
        Me.pnlContestant.Controls.Add(Me.lbl_cid)
        Me.pnlContestant.Controls.Add(Me.btn_upConImg)
        Me.pnlContestant.Controls.Add(Me.pb_con)
        Me.pnlContestant.Controls.Add(Me.txt_conNum)
        Me.pnlContestant.Controls.Add(Me.Label2)
        Me.pnlContestant.Controls.Add(Me.btn_clearCon)
        Me.pnlContestant.Controls.Add(Me.btn_upCon)
        Me.pnlContestant.Controls.Add(Me.txt_conName)
        Me.pnlContestant.Controls.Add(Me.btn_delCon)
        Me.pnlContestant.Controls.Add(Me.btn_saveCon)
        Me.pnlContestant.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContestant.Location = New System.Drawing.Point(219, 47)
        Me.pnlContestant.Name = "pnlContestant"
        Me.pnlContestant.Size = New System.Drawing.Size(1702, 1008)
        Me.pnlContestant.TabIndex = 3
        '
        'pb_con
        '
        Me.pb_con.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb_con.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb_con.Location = New System.Drawing.Point(1005, 17)
        Me.pb_con.Name = "pb_con"
        Me.pb_con.Size = New System.Drawing.Size(150, 150)
        Me.pb_con.TabIndex = 31
        Me.pb_con.TabStop = False
        '
        'pnlJudges
        '
        Me.pnlJudges.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.pnlJudges.Controls.Add(Me.dgv_judges)
        Me.pnlJudges.Controls.Add(Me.btn_newJudge)
        Me.pnlJudges.Controls.Add(Me.txt_jid)
        Me.pnlJudges.Controls.Add(Me.btn_upJudge)
        Me.pnlJudges.Controls.Add(Me.btn_delJudge)
        Me.pnlJudges.Controls.Add(Me.lbl_jid)
        Me.pnlJudges.Controls.Add(Me.btn_saveJudge)
        Me.pnlJudges.Controls.Add(Me.Label7)
        Me.pnlJudges.Controls.Add(Me.Label6)
        Me.pnlJudges.Controls.Add(Me.txt_jpass)
        Me.pnlJudges.Controls.Add(Me.txt_juser)
        Me.pnlJudges.Controls.Add(Me.Label5)
        Me.pnlJudges.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlJudges.Location = New System.Drawing.Point(219, 47)
        Me.pnlJudges.Name = "pnlJudges"
        Me.pnlJudges.Size = New System.Drawing.Size(1702, 1008)
        Me.pnlJudges.TabIndex = 34
        '
        'pnlCategory
        '
        Me.pnlCategory.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pnlCategory.Controls.Add(Me.btn_newCat)
        Me.pnlCategory.Controls.Add(Me.lbl_catid)
        Me.pnlCategory.Controls.Add(Me.btn_delCat)
        Me.pnlCategory.Controls.Add(Me.btn_upCat)
        Me.pnlCategory.Controls.Add(Me.lblUpCat)
        Me.pnlCategory.Controls.Add(Me.btn_saveCat)
        Me.pnlCategory.Controls.Add(Me.dgv_cat)
        Me.pnlCategory.Controls.Add(Me.Label8)
        Me.pnlCategory.Controls.Add(Me.txt_catNum)
        Me.pnlCategory.Controls.Add(Me.Label9)
        Me.pnlCategory.Controls.Add(Me.txt_catName)
        Me.pnlCategory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCategory.Location = New System.Drawing.Point(219, 47)
        Me.pnlCategory.Name = "pnlCategory"
        Me.pnlCategory.Size = New System.Drawing.Size(1702, 1008)
        Me.pnlCategory.TabIndex = 34
        '
        'pnlDesign
        '
        Me.pnlDesign.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pnlDesign.Controls.Add(Me.GroupBox2)
        Me.pnlDesign.Controls.Add(Me.GroupBox1)
        Me.pnlDesign.Controls.Add(Me.btn_pres1)
        Me.pnlDesign.Controls.Add(Me.btn_pres3)
        Me.pnlDesign.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDesign.Location = New System.Drawing.Point(219, 47)
        Me.pnlDesign.Name = "pnlDesign"
        Me.pnlDesign.Size = New System.Drawing.Size(1702, 1008)
        Me.pnlDesign.TabIndex = 34
        '
        'pnlKeypad
        '
        Me.pnlKeypad.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pnlKeypad.Controls.Add(Me.btn_saveLimit)
        Me.pnlKeypad.Controls.Add(Me.txt_lower)
        Me.pnlKeypad.Controls.Add(Me.Label3)
        Me.pnlKeypad.Controls.Add(Me.txt_upper)
        Me.pnlKeypad.Controls.Add(Me.Label4)
        Me.pnlKeypad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlKeypad.Location = New System.Drawing.Point(219, 47)
        Me.pnlKeypad.Name = "pnlKeypad"
        Me.pnlKeypad.Size = New System.Drawing.Size(1702, 1008)
        Me.pnlKeypad.TabIndex = 34
        '
        'frm_AdminConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1921, 1055)
        Me.Controls.Add(Me.pnlContestant)
        Me.Controls.Add(Me.pnlJudges)
        Me.Controls.Add(Me.pnlCategory)
        Me.Controls.Add(Me.pnlDesign)
        Me.Controls.Add(Me.pnlKeypad)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_AdminConfig"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pageant Config"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgv_cat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_judges, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_con, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.ptcbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.pnlContestant.ResumeLayout(False)
        Me.pnlContestant.PerformLayout()
        CType(Me.pb_con, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlJudges.ResumeLayout(False)
        Me.pnlJudges.PerformLayout()
        Me.pnlCategory.ResumeLayout(False)
        Me.pnlCategory.PerformLayout()
        Me.pnlDesign.ResumeLayout(False)
        Me.pnlKeypad.ResumeLayout(False)
        Me.pnlKeypad.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_saveLimit As Button
    Friend WithEvents txt_lower As TextBox
    Friend WithEvents txt_upper As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_catid As Label
    Friend WithEvents btn_newCat As Button
    Friend WithEvents btn_delCat As Button
    Friend WithEvents btn_upCat As Button
    Friend WithEvents btn_saveCat As Button
    Friend WithEvents dgv_cat As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_catName As TextBox
    Friend WithEvents txt_catNum As TextBox
    Friend WithEvents btn_newJudge As Button
    Friend WithEvents btn_upJudge As Button
    Friend WithEvents btn_delJudge As Button
    Friend WithEvents dgv_judges As DataGridView
    Friend WithEvents btn_saveJudge As Button
    Friend WithEvents txt_jpass As TextBox
    Friend WithEvents txt_juser As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_clearCon As Button
    Friend WithEvents btn_upCon As Button
    Friend WithEvents btn_delCon As Button
    Friend WithEvents dgv_con As DataGridView
    Friend WithEvents btn_saveCon As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_conName As TextBox
    Friend WithEvents txt_conNum As TextBox
    Friend WithEvents btn_preview As Button
    Friend WithEvents btn_upload As Button
    Friend WithEvents ofd_bg As OpenFileDialog
    Friend WithEvents btn_pres1 As Button
    Friend WithEvents btn_pres3 As Button
    Friend WithEvents btn_pres2 As Button
    Friend WithEvents btn_uppresbg As Button
    Friend WithEvents lblUpCat As Label
    Friend WithEvents txt_jid As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_cid As Label
    Friend WithEvents lbl_jid As Label
    Friend WithEvents pb_con As PictureBox
    Friend WithEvents btn_upConImg As Button
    Friend WithEvents ofd_con As OpenFileDialog
    Friend WithEvents lbl_conImg As Label
    Friend WithEvents btn_pctrl As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnKeypad As Button
    Friend WithEvents btnDesign As Button
    Friend WithEvents btnCategory As Button
    Friend WithEvents btnJudges As Button
    Friend WithEvents btnContestant As Button
    Friend WithEvents pnlContestant As Panel
    Friend WithEvents pnlJudges As Panel
    Friend WithEvents pnlCategory As Panel
    Friend WithEvents pnlDesign As Panel
    Friend WithEvents pnlKeypad As Panel
    Friend WithEvents ptcbLogo As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
