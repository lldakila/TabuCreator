<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Flash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Flash))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lbl_JID = New System.Windows.Forms.Label()
        Me.lbl_Access = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lbl_JID
        '
        Me.lbl_JID.AutoSize = True
        Me.lbl_JID.Location = New System.Drawing.Point(12, 87)
        Me.lbl_JID.Name = "lbl_JID"
        Me.lbl_JID.Size = New System.Drawing.Size(55, 17)
        Me.lbl_JID.TabIndex = 1
        Me.lbl_JID.Text = "Judge0"
        Me.lbl_JID.Visible = False
        '
        'lbl_Access
        '
        Me.lbl_Access.AutoSize = True
        Me.lbl_Access.Location = New System.Drawing.Point(12, 9)
        Me.lbl_Access.Name = "lbl_Access"
        Me.lbl_Access.Size = New System.Drawing.Size(53, 17)
        Me.lbl_Access.TabIndex = 2
        Me.lbl_Access.Text = "Access"
        Me.lbl_Access.Visible = False
        '
        'frm_Flash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl_Access)
        Me.Controls.Add(Me.lbl_JID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Flash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Flash Screen"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents lbl_JID As Label
    Friend WithEvents lbl_Access As Label
End Class
