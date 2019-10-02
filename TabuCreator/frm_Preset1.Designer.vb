<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Preset1
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_Next = New System.Windows.Forms.Button()
        Me.btn_Prev = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblCat = New System.Windows.Forms.Label()
        Me.pb_Candi = New System.Windows.Forms.PictureBox()
        Me.flp_scoreCat = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1.SuspendLayout()
        CType(Me.pb_Candi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.flp_scoreCat)
        Me.Panel1.Controls.Add(Me.btn_Next)
        Me.Panel1.Controls.Add(Me.btn_Prev)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblID)
        Me.Panel1.Controls.Add(Me.lblCat)
        Me.Panel1.Controls.Add(Me.pb_Candi)
        Me.Panel1.Location = New System.Drawing.Point(739, 101)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(425, 808)
        Me.Panel1.TabIndex = 1
        '
        'btn_Next
        '
        Me.btn_Next.BackColor = System.Drawing.Color.Teal
        Me.btn_Next.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Next.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btn_Next.Location = New System.Drawing.Point(230, 714)
        Me.btn_Next.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Next.Name = "btn_Next"
        Me.btn_Next.Size = New System.Drawing.Size(149, 63)
        Me.btn_Next.TabIndex = 76
        Me.btn_Next.TabStop = False
        Me.btn_Next.Text = "Next"
        Me.btn_Next.UseVisualStyleBackColor = False
        '
        'btn_Prev
        '
        Me.btn_Prev.BackColor = System.Drawing.Color.Teal
        Me.btn_Prev.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Prev.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btn_Prev.Location = New System.Drawing.Point(43, 719)
        Me.btn_Prev.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Prev.Name = "btn_Prev"
        Me.btn_Prev.Size = New System.Drawing.Size(149, 63)
        Me.btn_Prev.TabIndex = 75
        Me.btn_Prev.TabStop = False
        Me.btn_Prev.Text = "Previous"
        Me.btn_Prev.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(35, 230)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 45)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "Contestant"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Modern No. 20", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblID.Location = New System.Drawing.Point(260, 228)
        Me.lblID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(42, 48)
        Me.lblID.TabIndex = 73
        Me.lblID.Text = "0"
        '
        'lblCat
        '
        Me.lblCat.AutoSize = True
        Me.lblCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCat.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblCat.Location = New System.Drawing.Point(9, 13)
        Me.lblCat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCat.Name = "lblCat"
        Me.lblCat.Size = New System.Drawing.Size(131, 42)
        Me.lblCat.TabIndex = 58
        Me.lblCat.Text = "Label1"
        '
        'pb_Candi
        '
        Me.pb_Candi.BackColor = System.Drawing.Color.White
        Me.pb_Candi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb_Candi.Location = New System.Drawing.Point(153, 63)
        Me.pb_Candi.Name = "pb_Candi"
        Me.pb_Candi.Size = New System.Drawing.Size(150, 150)
        Me.pb_Candi.TabIndex = 0
        Me.pb_Candi.TabStop = False
        '
        'flp_scoreCat
        '
        Me.flp_scoreCat.AutoScroll = True
        Me.flp_scoreCat.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flp_scoreCat.Location = New System.Drawing.Point(16, 293)
        Me.flp_scoreCat.Name = "flp_scoreCat"
        Me.flp_scoreCat.Size = New System.Drawing.Size(392, 388)
        Me.flp_scoreCat.TabIndex = 77
        '
        'frm_Preset1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_Preset1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_Preset1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pb_Candi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pb_Candi As PictureBox
    Friend WithEvents btn_Next As Button
    Friend WithEvents btn_Prev As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblCat As Label
    Friend WithEvents flp_scoreCat As FlowLayoutPanel
End Class
