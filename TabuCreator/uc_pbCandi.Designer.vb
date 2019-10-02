<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_pbCandi
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.pb = New System.Windows.Forms.PictureBox()
        Me.txtCandi = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pb
        '
        Me.pb.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pb.Location = New System.Drawing.Point(0, 0)
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(150, 150)
        Me.pb.TabIndex = 0
        Me.pb.TabStop = False
        '
        'txtCandi
        '
        Me.txtCandi.Location = New System.Drawing.Point(0, 166)
        Me.txtCandi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCandi.Name = "txtCandi"
        Me.txtCandi.ReadOnly = True
        Me.txtCandi.Size = New System.Drawing.Size(150, 22)
        Me.txtCandi.TabIndex = 192
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'uc_pbCandi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.txtCandi)
        Me.Controls.Add(Me.pb)
        Me.Name = "uc_pbCandi"
        Me.Size = New System.Drawing.Size(150, 190)
        CType(Me.pb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pb As PictureBox
    Friend WithEvents txtCandi As TextBox
    Friend WithEvents Timer1 As Timer
End Class
