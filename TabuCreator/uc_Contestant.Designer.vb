<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_Contestant
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
        Me.btn_updateCon = New System.Windows.Forms.Button()
        Me.btn_deleteCon = New System.Windows.Forms.Button()
        Me.dgv_con = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_saveConn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.txt_ = New System.Windows.Forms.TextBox()
        CType(Me.dgv_con, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_updateCon
        '
        Me.btn_updateCon.Location = New System.Drawing.Point(419, 159)
        Me.btn_updateCon.Name = "btn_updateCon"
        Me.btn_updateCon.Size = New System.Drawing.Size(122, 46)
        Me.btn_updateCon.TabIndex = 37
        Me.btn_updateCon.Text = "Update"
        Me.btn_updateCon.UseVisualStyleBackColor = True
        '
        'btn_deleteCon
        '
        Me.btn_deleteCon.Location = New System.Drawing.Point(547, 159)
        Me.btn_deleteCon.Name = "btn_deleteCon"
        Me.btn_deleteCon.Size = New System.Drawing.Size(122, 46)
        Me.btn_deleteCon.TabIndex = 36
        Me.btn_deleteCon.Text = "Delete"
        Me.btn_deleteCon.UseVisualStyleBackColor = True
        '
        'dgv_con
        '
        Me.dgv_con.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_con.Location = New System.Drawing.Point(37, 211)
        Me.dgv_con.Name = "dgv_con"
        Me.dgv_con.RowTemplate.Height = 24
        Me.dgv_con.Size = New System.Drawing.Size(750, 215)
        Me.dgv_con.TabIndex = 35
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(451, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(21, 17)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "ID"
        '
        'btn_saveConn
        '
        Me.btn_saveConn.Location = New System.Drawing.Point(291, 159)
        Me.btn_saveConn.Name = "btn_saveConn"
        Me.btn_saveConn.Size = New System.Drawing.Size(122, 46)
        Me.btn_saveConn.TabIndex = 33
        Me.btn_saveConn.Text = "Save"
        Me.btn_saveConn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 17)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Contestant Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 17)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Contestant Number:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(288, 115)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(381, 22)
        Me.TextBox2.TabIndex = 30
        '
        'txt_
        '
        Me.txt_.Location = New System.Drawing.Point(288, 63)
        Me.txt_.Name = "txt_"
        Me.txt_.Size = New System.Drawing.Size(129, 22)
        Me.txt_.TabIndex = 29
        '
        'uc_Contestant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btn_updateCon)
        Me.Controls.Add(Me.btn_deleteCon)
        Me.Controls.Add(Me.dgv_con)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btn_saveConn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.txt_)
        Me.Name = "uc_Contestant"
        Me.Size = New System.Drawing.Size(820, 489)
        CType(Me.dgv_con, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_updateCon As Button
    Friend WithEvents btn_deleteCon As Button
    Friend WithEvents dgv_con As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_saveConn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents txt_ As TextBox
End Class
