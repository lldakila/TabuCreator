<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_setServerDb
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_setServerDb))
        Me.txt_serverPath = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_setServer = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btn_browse = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_serverPath
        '
        Me.txt_serverPath.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_serverPath.Location = New System.Drawing.Point(18, 43)
        Me.txt_serverPath.Name = "txt_serverPath"
        Me.txt_serverPath.Size = New System.Drawing.Size(455, 38)
        Me.txt_serverPath.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 31)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Server Path:"
        '
        'btn_setServer
        '
        Me.btn_setServer.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_setServer.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_setServer.Location = New System.Drawing.Point(297, 89)
        Me.btn_setServer.Name = "btn_setServer"
        Me.btn_setServer.Size = New System.Drawing.Size(176, 42)
        Me.btn_setServer.TabIndex = 18
        Me.btn_setServer.Text = "Set Server"
        Me.btn_setServer.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "db_tabu.mdb"
        Me.OpenFileDialog1.Filter = "Database Files|*.mdb"
        Me.OpenFileDialog1.Title = "Find Database"
        '
        'btn_browse
        '
        Me.btn_browse.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_browse.Font = New System.Drawing.Font("Microsoft YaHei", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_browse.Location = New System.Drawing.Point(115, 89)
        Me.btn_browse.Name = "btn_browse"
        Me.btn_browse.Size = New System.Drawing.Size(176, 42)
        Me.btn_browse.TabIndex = 19
        Me.btn_browse.Text = "Browse File"
        Me.btn_browse.UseVisualStyleBackColor = False
        '
        'frm_setServerDb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 143)
        Me.Controls.Add(Me.btn_browse)
        Me.Controls.Add(Me.btn_setServer)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_serverPath)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_setServerDb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Set Server Path"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_serverPath As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_setServer As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btn_browse As Button
End Class
