<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Preset2
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Preset2))
        Me.flp = New System.Windows.Forms.FlowLayoutPanel()
        Me.lbl_cat = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'flp
        '
        Me.flp.BackColor = System.Drawing.Color.Transparent
        Me.flp.Location = New System.Drawing.Point(396, 200)
        Me.flp.Name = "flp"
        Me.flp.Size = New System.Drawing.Size(1144, 720)
        Me.flp.TabIndex = 0
        '
        'lbl_cat
        '
        Me.lbl_cat.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_cat.AutoSize = True
        Me.lbl_cat.BackColor = System.Drawing.Color.Transparent
        Me.lbl_cat.Font = New System.Drawing.Font("Lucida Calligraphy", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cat.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_cat.Location = New System.Drawing.Point(826, 97)
        Me.lbl_cat.Name = "lbl_cat"
        Me.lbl_cat.Size = New System.Drawing.Size(318, 44)
        Me.lbl_cat.TabIndex = 327
        Me.lbl_cat.Text = "Category Name"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'frm_Preset2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1902, 1033)
        Me.Controls.Add(Me.lbl_cat)
        Me.Controls.Add(Me.flp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Preset2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Scoring"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents flp As FlowLayoutPanel
    Friend WithEvents lbl_cat As Label
    Friend WithEvents Timer1 As Timer
End Class
