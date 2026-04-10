<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class user_form
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
        Me.tobttmcmd = New System.Windows.Forms.ToolStripMenuItem()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtrpw = New System.Windows.Forms.TextBox()
        Me.lblrpw = New System.Windows.Forms.Label()
        Me.txtpw = New System.Windows.Forms.TextBox()
        Me.txtuname = New System.Windows.Forms.TextBox()
        Me.browsecmd = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxpriv = New System.Windows.Forms.ComboBox()
        Me.txtuid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.newusercmd = New System.Windows.Forms.ToolStripMenuItem()
        Me.savecmd = New System.Windows.Forms.ToolStripMenuItem()
        Me.editcmd = New System.Windows.Forms.ToolStripMenuItem()
        Me.srchcmd = New System.Windows.Forms.ToolStripMenuItem()
        Me.delcmd = New System.Windows.Forms.ToolStripMenuItem()
        Me.cancelcmd = New System.Windows.Forms.ToolStripMenuItem()
        Me.Printcmd = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrystalReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.extcmd = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dguser = New System.Windows.Forms.DataGridView()
        Me.NavigationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.totopcmd = New System.Windows.Forms.ToolStripMenuItem()
        Me.nxtcmd = New System.Windows.Forms.ToolStripMenuItem()
        Me.prevcmd = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Picbox = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtpost = New System.Windows.Forms.TextBox()
        CType(Me.dguser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Picbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tobttmcmd
        '
        Me.tobttmcmd.Image = Global.resort_management.My.Resources.Resources.arrow_downward_90dp_000000_FILL0_wght400_GRAD0_opsz48
        Me.tobttmcmd.Name = "tobttmcmd"
        Me.tobttmcmd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Down), System.Windows.Forms.Keys)
        Me.tobttmcmd.Size = New System.Drawing.Size(327, 30)
        Me.tobttmcmd.Text = "To Bottom"
        '
        'ofd
        '
        Me.ofd.FileName = "OpenFileDialog1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(559, 39)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(403, 81)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "EMPLOYEES"
        '
        'txtrpw
        '
        Me.txtrpw.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrpw.Location = New System.Drawing.Point(38, 944)
        Me.txtrpw.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtrpw.Name = "txtrpw"
        Me.txtrpw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtrpw.Size = New System.Drawing.Size(456, 37)
        Me.txtrpw.TabIndex = 28
        '
        'lblrpw
        '
        Me.lblrpw.AutoSize = True
        Me.lblrpw.Font = New System.Drawing.Font("Verdana Pro", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrpw.ForeColor = System.Drawing.Color.White
        Me.lblrpw.Location = New System.Drawing.Point(46, 903)
        Me.lblrpw.Name = "lblrpw"
        Me.lblrpw.Size = New System.Drawing.Size(340, 34)
        Me.lblrpw.TabIndex = 36
        Me.lblrpw.Text = "RE-TYPE PASSWORD"
        '
        'txtpw
        '
        Me.txtpw.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpw.Location = New System.Drawing.Point(38, 836)
        Me.txtpw.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtpw.Name = "txtpw"
        Me.txtpw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtpw.Size = New System.Drawing.Size(456, 37)
        Me.txtpw.TabIndex = 26
        '
        'txtuname
        '
        Me.txtuname.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuname.Location = New System.Drawing.Point(38, 607)
        Me.txtuname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtuname.Name = "txtuname"
        Me.txtuname.Size = New System.Drawing.Size(456, 37)
        Me.txtuname.TabIndex = 24
        '
        'browsecmd
        '
        Me.browsecmd.AutoSize = True
        Me.browsecmd.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.browsecmd.LinkColor = System.Drawing.Color.White
        Me.browsecmd.Location = New System.Drawing.Point(202, 380)
        Me.browsecmd.Name = "browsecmd"
        Me.browsecmd.Size = New System.Drawing.Size(121, 27)
        Me.browsecmd.TabIndex = 32
        Me.browsecmd.TabStop = True
        Me.browsecmd.Text = "Browse Pic"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana Pro", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(36, 566)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 34)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "USERNAME"
        '
        'cbxpriv
        '
        Me.cbxpriv.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxpriv.FormattingEnabled = True
        Me.cbxpriv.Items.AddRange(New Object() {"Admin", "User"})
        Me.cbxpriv.Location = New System.Drawing.Point(38, 1052)
        Me.cbxpriv.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbxpriv.Name = "cbxpriv"
        Me.cbxpriv.Size = New System.Drawing.Size(456, 38)
        Me.cbxpriv.TabIndex = 30
        '
        'txtuid
        '
        Me.txtuid.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuid.Location = New System.Drawing.Point(38, 499)
        Me.txtuid.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtuid.Name = "txtuid"
        Me.txtuid.Size = New System.Drawing.Size(456, 37)
        Me.txtuid.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana Pro", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(36, 458)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 34)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "USER ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana Pro", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(46, 1011)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(188, 34)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "PRIVILEGE"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newusercmd, Me.savecmd, Me.editcmd, Me.srchcmd, Me.delcmd, Me.cancelcmd, Me.Printcmd, Me.extcmd})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Verdana Pro Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(87, 29)
        Me.FileToolStripMenuItem.Text = "MENU"
        '
        'newusercmd
        '
        Me.newusercmd.Image = Global.resort_management.My.Resources.Resources.person_add_70dp_000000_FILL0_wght400_GRAD0_opsz48
        Me.newusercmd.Name = "newusercmd"
        Me.newusercmd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.newusercmd.Size = New System.Drawing.Size(285, 30)
        Me.newusercmd.Text = "ADD USER"
        '
        'savecmd
        '
        Me.savecmd.Enabled = False
        Me.savecmd.Image = Global.resort_management.My.Resources.Resources.save_90dp_000000_FILL0_wght400_GRAD0_opsz48
        Me.savecmd.Name = "savecmd"
        Me.savecmd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.savecmd.Size = New System.Drawing.Size(285, 30)
        Me.savecmd.Text = "SAVE"
        '
        'editcmd
        '
        Me.editcmd.Image = Global.resort_management.My.Resources.Resources.edit_90dp_000000_FILL0_wght400_GRAD0_opsz48
        Me.editcmd.Name = "editcmd"
        Me.editcmd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.editcmd.Size = New System.Drawing.Size(285, 30)
        Me.editcmd.Text = "EDIT"
        '
        'srchcmd
        '
        Me.srchcmd.Image = Global.resort_management.My.Resources.Resources.search_90dp_000000_FILL0_wght400_GRAD0_opsz48
        Me.srchcmd.Name = "srchcmd"
        Me.srchcmd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.srchcmd.Size = New System.Drawing.Size(285, 30)
        Me.srchcmd.Text = "SEARCH"
        '
        'delcmd
        '
        Me.delcmd.Image = Global.resort_management.My.Resources.Resources.delete_90dp_000000_FILL0_wght400_GRAD0_opsz48
        Me.delcmd.Name = "delcmd"
        Me.delcmd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Delete), System.Windows.Forms.Keys)
        Me.delcmd.Size = New System.Drawing.Size(285, 30)
        Me.delcmd.Text = "DELETE"
        '
        'cancelcmd
        '
        Me.cancelcmd.Enabled = False
        Me.cancelcmd.Image = Global.resort_management.My.Resources.Resources.cancel_90dp_000000_FILL0_wght400_GRAD0_opsz48
        Me.cancelcmd.Name = "cancelcmd"
        Me.cancelcmd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.cancelcmd.Size = New System.Drawing.Size(285, 30)
        Me.cancelcmd.Text = "CANCEL"
        '
        'Printcmd
        '
        Me.Printcmd.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExcelToolStripMenuItem, Me.CrystalReportToolStripMenuItem})
        Me.Printcmd.Name = "Printcmd"
        Me.Printcmd.Size = New System.Drawing.Size(285, 30)
        Me.Printcmd.Text = "PRINT"
        '
        'ExcelToolStripMenuItem
        '
        Me.ExcelToolStripMenuItem.Image = Global.resort_management.My.Resources.Resources.excel
        Me.ExcelToolStripMenuItem.Name = "ExcelToolStripMenuItem"
        Me.ExcelToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.ExcelToolStripMenuItem.Size = New System.Drawing.Size(353, 30)
        Me.ExcelToolStripMenuItem.Text = "EXCEL"
        '
        'CrystalReportToolStripMenuItem
        '
        Me.CrystalReportToolStripMenuItem.Image = Global.resort_management.My.Resources.Resources.crysttal
        Me.CrystalReportToolStripMenuItem.Name = "CrystalReportToolStripMenuItem"
        Me.CrystalReportToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CrystalReportToolStripMenuItem.Size = New System.Drawing.Size(353, 30)
        Me.CrystalReportToolStripMenuItem.Text = "CRYSTAL REPORT"
        '
        'extcmd
        '
        Me.extcmd.Image = Global.resort_management.My.Resources.Resources.logout_90dp_000000_FILL0_wght400_GRAD0_opsz48
        Me.extcmd.Name = "extcmd"
        Me.extcmd.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.extcmd.Size = New System.Drawing.Size(285, 30)
        Me.extcmd.Text = "EXIT"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana Pro", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(36, 674)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(177, 34)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "POSITION"
        '
        'dguser
        '
        Me.dguser.AllowUserToAddRows = False
        Me.dguser.AllowUserToDeleteRows = False
        Me.dguser.AllowUserToResizeColumns = False
        Me.dguser.AllowUserToResizeRows = False
        Me.dguser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dguser.BackgroundColor = System.Drawing.Color.DarkCyan
        Me.dguser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dguser.Location = New System.Drawing.Point(573, 124)
        Me.dguser.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dguser.Name = "dguser"
        Me.dguser.ReadOnly = True
        Me.dguser.RowTemplate.Height = 24
        Me.dguser.Size = New System.Drawing.Size(1330, 1050)
        Me.dguser.TabIndex = 20
        '
        'NavigationToolStripMenuItem
        '
        Me.NavigationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.totopcmd, Me.nxtcmd, Me.prevcmd, Me.tobttmcmd})
        Me.NavigationToolStripMenuItem.Font = New System.Drawing.Font("Verdana Pro Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavigationToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.NavigationToolStripMenuItem.Name = "NavigationToolStripMenuItem"
        Me.NavigationToolStripMenuItem.Size = New System.Drawing.Size(166, 29)
        Me.NavigationToolStripMenuItem.Text = "NAVIGATION"
        '
        'totopcmd
        '
        Me.totopcmd.Image = Global.resort_management.My.Resources.Resources.arrow_upward_90dp_000000_FILL0_wght400_GRAD0_opsz48
        Me.totopcmd.Name = "totopcmd"
        Me.totopcmd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Up), System.Windows.Forms.Keys)
        Me.totopcmd.Size = New System.Drawing.Size(327, 30)
        Me.totopcmd.Text = "To Top"
        '
        'nxtcmd
        '
        Me.nxtcmd.Image = Global.resort_management.My.Resources.Resources.arrow_forward_90dp_000000_FILL0_wght400_GRAD0_opsz48
        Me.nxtcmd.Name = "nxtcmd"
        Me.nxtcmd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Right), System.Windows.Forms.Keys)
        Me.nxtcmd.Size = New System.Drawing.Size(327, 30)
        Me.nxtcmd.Text = "Next"
        '
        'prevcmd
        '
        Me.prevcmd.Image = Global.resort_management.My.Resources.Resources.arrow_left_alt_90dp_000000_FILL0_wght400_GRAD0_opsz48
        Me.prevcmd.Name = "prevcmd"
        Me.prevcmd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Left), System.Windows.Forms.Keys)
        Me.prevcmd.Size = New System.Drawing.Size(327, 30)
        Me.prevcmd.Text = "Previous"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.NavigationToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1924, 33)
        Me.MenuStrip1.TabIndex = 21
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Picbox
        '
        Me.Picbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Picbox.Location = New System.Drawing.Point(91, 26)
        Me.Picbox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Picbox.Name = "Picbox"
        Me.Picbox.Size = New System.Drawing.Size(350, 350)
        Me.Picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picbox.TabIndex = 35
        Me.Picbox.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana Pro", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(46, 795)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(198, 34)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "PASSWORD"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Turquoise
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.browsecmd)
        Me.Panel1.Controls.Add(Me.Picbox)
        Me.Panel1.Controls.Add(Me.txtrpw)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.lblrpw)
        Me.Panel1.Controls.Add(Me.txtpost)
        Me.Panel1.Controls.Add(Me.txtpw)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtuid)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cbxpriv)
        Me.Panel1.Controls.Add(Me.txtuname)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(0, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(553, 1146)
        Me.Panel1.TabIndex = 38
        '
        'txtpost
        '
        Me.txtpost.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpost.Location = New System.Drawing.Point(38, 715)
        Me.txtpost.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtpost.Name = "txtpost"
        Me.txtpost.Size = New System.Drawing.Size(456, 37)
        Me.txtpost.TabIndex = 25
        '
        'user_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1924, 1175)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dguser)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "user_form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dguser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Picbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tobttmcmd As ToolStripMenuItem
    Friend WithEvents ofd As OpenFileDialog
    Friend WithEvents Label6 As Label
    Friend WithEvents txtrpw As TextBox
    Friend WithEvents lblrpw As Label
    Friend WithEvents txtpw As TextBox
    Friend WithEvents Picbox As PictureBox
    Friend WithEvents txtuname As TextBox
    Friend WithEvents browsecmd As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents cbxpriv As ComboBox
    Friend WithEvents txtuid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents newusercmd As ToolStripMenuItem
    Friend WithEvents savecmd As ToolStripMenuItem
    Friend WithEvents editcmd As ToolStripMenuItem
    Friend WithEvents srchcmd As ToolStripMenuItem
    Friend WithEvents delcmd As ToolStripMenuItem
    Friend WithEvents cancelcmd As ToolStripMenuItem
    Friend WithEvents Printcmd As ToolStripMenuItem
    Friend WithEvents ExcelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrystalReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents extcmd As ToolStripMenuItem
    Friend WithEvents Label4 As Label
    Friend WithEvents dguser As DataGridView
    Friend WithEvents NavigationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents totopcmd As ToolStripMenuItem
    Friend WithEvents nxtcmd As ToolStripMenuItem
    Friend WithEvents prevcmd As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtpost As TextBox
End Class
