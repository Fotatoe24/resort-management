<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class log_in_form
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Extcmd = New System.Windows.Forms.Button()
        Me.sbmtcmd = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtuserid = New System.Windows.Forms.TextBox()
        Me.shwpass = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(381, 271)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 70)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "LOG-IN"
        '
        'Extcmd
        '
        Me.Extcmd.BackColor = System.Drawing.Color.LightCoral
        Me.Extcmd.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray
        Me.Extcmd.FlatAppearance.BorderSize = 2
        Me.Extcmd.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Extcmd.Location = New System.Drawing.Point(481, 615)
        Me.Extcmd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Extcmd.Name = "Extcmd"
        Me.Extcmd.Size = New System.Drawing.Size(196, 87)
        Me.Extcmd.TabIndex = 23
        Me.Extcmd.Text = "Exit"
        Me.Extcmd.UseVisualStyleBackColor = False
        '
        'sbmtcmd
        '
        Me.sbmtcmd.BackColor = System.Drawing.Color.SpringGreen
        Me.sbmtcmd.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray
        Me.sbmtcmd.FlatAppearance.BorderSize = 2
        Me.sbmtcmd.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sbmtcmd.Location = New System.Drawing.Point(254, 615)
        Me.sbmtcmd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.sbmtcmd.Name = "sbmtcmd"
        Me.sbmtcmd.Size = New System.Drawing.Size(196, 87)
        Me.sbmtcmd.TabIndex = 22
        Me.sbmtcmd.Text = "Log-In"
        Me.sbmtcmd.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft JhengHei UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(254, 470)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 30)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "PASSWORD"
        '
        'txtuserid
        '
        Me.txtuserid.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuserid.Location = New System.Drawing.Point(259, 421)
        Me.txtuserid.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtuserid.Name = "txtuserid"
        Me.txtuserid.Size = New System.Drawing.Size(418, 46)
        Me.txtuserid.TabIndex = 18
        Me.txtuserid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'shwpass
        '
        Me.shwpass.AutoSize = True
        Me.shwpass.BackColor = System.Drawing.Color.Transparent
        Me.shwpass.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shwpass.ForeColor = System.Drawing.Color.White
        Me.shwpass.Location = New System.Drawing.Point(254, 566)
        Me.shwpass.Name = "shwpass"
        Me.shwpass.Size = New System.Drawing.Size(163, 28)
        Me.shwpass.TabIndex = 21
        Me.shwpass.Text = "Show password"
        Me.shwpass.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft JhengHei UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(261, 389)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 30)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "USER ID"
        '
        'txtpassword
        '
        Me.txtpassword.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(259, 502)
        Me.txtpassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtpassword.Size = New System.Drawing.Size(418, 46)
        Me.txtpassword.TabIndex = 19
        Me.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'log_in_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1902, 1153)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Extcmd)
        Me.Controls.Add(Me.sbmtcmd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtuserid)
        Me.Controls.Add(Me.shwpass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtpassword)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "log_in_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Extcmd As Button
    Friend WithEvents sbmtcmd As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtuserid As TextBox
    Friend WithEvents shwpass As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtpassword As TextBox
End Class
