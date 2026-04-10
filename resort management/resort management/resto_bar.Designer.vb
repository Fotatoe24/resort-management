<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class resto_bar
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.totopcmd = New System.Windows.Forms.ToolStripMenuItem()
        Me.nextcmd = New System.Windows.Forms.ToolStripMenuItem()
        Me.prevcmd = New System.Windows.Forms.ToolStripMenuItem()
        Me.tobttmcmd = New System.Windows.Forms.ToolStripMenuItem()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.NavigationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.browsepic = New System.Windows.Forms.LinkLabel()
        Me.Picbox = New System.Windows.Forms.PictureBox()
        Me.extcmd = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtsellp = New System.Windows.Forms.TextBox()
        Me.txtcrit = New System.Windows.Forms.TextBox()
        Me.txtquan = New System.Windows.Forms.TextBox()
        Me.txtdes = New System.Windows.Forms.TextBox()
        Me.txtiname = New System.Windows.Forms.TextBox()
        Me.txtbrcd = New System.Windows.Forms.TextBox()
        Me.dgstock = New System.Windows.Forms.DataGridView()
        Me.Crystalprint = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.nwitemcmd = New System.Windows.Forms.ToolStripMenuItem()
        Me.svcmd = New System.Windows.Forms.ToolStripMenuItem()
        Me.edtcmd = New System.Windows.Forms.ToolStripMenuItem()
        Me.searchcmd = New System.Windows.Forms.ToolStripMenuItem()
        Me.delcmd = New System.Windows.Forms.ToolStripMenuItem()
        Me.cnlcmd = New System.Windows.Forms.ToolStripMenuItem()
        Me.prntcmd = New System.Windows.Forms.ToolStripMenuItem()
        Me.excelprint = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbxCategory = New System.Windows.Forms.ComboBox()
        Me.cbxFilterCategory = New System.Windows.Forms.ComboBox()
        CType(Me.Picbox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgstock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'totopcmd
        '
        Me.totopcmd.Image = Global.resort_management.My.Resources.Resources.arrow_upward_90dp_000000_FILL0_wght400_GRAD0_opsz48
        Me.totopcmd.Name = "totopcmd"
        Me.totopcmd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Up), System.Windows.Forms.Keys)
        Me.totopcmd.Size = New System.Drawing.Size(309, 28)
        Me.totopcmd.Text = "To top"
        '
        'nextcmd
        '
        Me.nextcmd.Image = Global.resort_management.My.Resources.Resources.arrow_forward_90dp_000000_FILL0_wght400_GRAD0_opsz48
        Me.nextcmd.Name = "nextcmd"
        Me.nextcmd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Right), System.Windows.Forms.Keys)
        Me.nextcmd.Size = New System.Drawing.Size(309, 28)
        Me.nextcmd.Text = "Next"
        '
        'prevcmd
        '
        Me.prevcmd.Image = Global.resort_management.My.Resources.Resources.arrow_left_alt_90dp_000000_FILL0_wght400_GRAD0_opsz48
        Me.prevcmd.Name = "prevcmd"
        Me.prevcmd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Left), System.Windows.Forms.Keys)
        Me.prevcmd.Size = New System.Drawing.Size(309, 28)
        Me.prevcmd.Text = "Previous"
        '
        'tobttmcmd
        '
        Me.tobttmcmd.Image = Global.resort_management.My.Resources.Resources.arrow_downward_90dp_000000_FILL0_wght400_GRAD0_opsz48
        Me.tobttmcmd.Name = "tobttmcmd"
        Me.tobttmcmd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Down), System.Windows.Forms.Keys)
        Me.tobttmcmd.Size = New System.Drawing.Size(309, 28)
        Me.tobttmcmd.Text = "To bottom"
        '
        'ofd
        '
        Me.ofd.FileName = "OpenFileDialog1"
        '
        'NavigationToolStripMenuItem
        '
        Me.NavigationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.totopcmd, Me.nextcmd, Me.prevcmd, Me.tobttmcmd})
        Me.NavigationToolStripMenuItem.Font = New System.Drawing.Font("Verdana Pro Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NavigationToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.NavigationToolStripMenuItem.Name = "NavigationToolStripMenuItem"
        Me.NavigationToolStripMenuItem.Size = New System.Drawing.Size(130, 27)
        Me.NavigationToolStripMenuItem.Text = "Navigation"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Perpetua Titling MT", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(491, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(563, 96)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "INVENTORY"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft JhengHei UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(252, 916)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(218, 36)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "SELLING PRICE"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft JhengHei UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(276, 813)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 36)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "CRITICAL"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft JhengHei UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(61, 923)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(167, 36)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "CATEGORY"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft JhengHei UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(55, 813)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 36)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "QUANTITY"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft JhengHei UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(61, 702)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(206, 36)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "DESCRIPTION"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft JhengHei UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(63, 589)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(248, 36)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "PRODUCT NAME"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft JhengHei UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(63, 486)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 36)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "BARCODE"
        '
        'browsepic
        '
        Me.browsepic.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.browsepic.AutoSize = True
        Me.browsepic.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.browsepic.LinkColor = System.Drawing.Color.White
        Me.browsepic.Location = New System.Drawing.Point(167, 422)
        Me.browsepic.Name = "browsepic"
        Me.browsepic.Size = New System.Drawing.Size(144, 31)
        Me.browsepic.TabIndex = 33
        Me.browsepic.TabStop = True
        Me.browsepic.Text = "Browse pic"
        '
        'Picbox
        '
        Me.Picbox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Picbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Picbox.Location = New System.Drawing.Point(72, 70)
        Me.Picbox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Picbox.Name = "Picbox"
        Me.Picbox.Size = New System.Drawing.Size(346, 339)
        Me.Picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picbox.TabIndex = 31
        Me.Picbox.TabStop = False
        '
        'extcmd
        '
        Me.extcmd.Image = Global.resort_management.My.Resources.Resources.logout_90dp_000000_FILL0_wght400_GRAD0_opsz48
        Me.extcmd.Name = "extcmd"
        Me.extcmd.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.extcmd.Size = New System.Drawing.Size(268, 30)
        Me.extcmd.Text = "Exit"
        '
        'txtsellp
        '
        Me.txtsellp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtsellp.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsellp.Location = New System.Drawing.Point(282, 961)
        Me.txtsellp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtsellp.Name = "txtsellp"
        Me.txtsellp.Size = New System.Drawing.Size(128, 38)
        Me.txtsellp.TabIndex = 30
        Me.txtsellp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcrit
        '
        Me.txtcrit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtcrit.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcrit.Location = New System.Drawing.Point(282, 855)
        Me.txtcrit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcrit.Name = "txtcrit"
        Me.txtcrit.Size = New System.Drawing.Size(128, 38)
        Me.txtcrit.TabIndex = 28
        Me.txtcrit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtquan
        '
        Me.txtquan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtquan.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtquan.Location = New System.Drawing.Point(69, 855)
        Me.txtquan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtquan.Name = "txtquan"
        Me.txtquan.Size = New System.Drawing.Size(152, 38)
        Me.txtquan.TabIndex = 27
        Me.txtquan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtdes
        '
        Me.txtdes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtdes.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdes.Location = New System.Drawing.Point(69, 740)
        Me.txtdes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtdes.Name = "txtdes"
        Me.txtdes.Size = New System.Drawing.Size(346, 38)
        Me.txtdes.TabIndex = 26
        Me.txtdes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtiname
        '
        Me.txtiname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtiname.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtiname.Location = New System.Drawing.Point(67, 634)
        Me.txtiname.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtiname.Name = "txtiname"
        Me.txtiname.Size = New System.Drawing.Size(346, 38)
        Me.txtiname.TabIndex = 25
        Me.txtiname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtbrcd
        '
        Me.txtbrcd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtbrcd.Enabled = False
        Me.txtbrcd.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbrcd.Location = New System.Drawing.Point(67, 528)
        Me.txtbrcd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtbrcd.Name = "txtbrcd"
        Me.txtbrcd.Size = New System.Drawing.Size(346, 38)
        Me.txtbrcd.TabIndex = 24
        Me.txtbrcd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgstock
        '
        Me.dgstock.AllowUserToAddRows = False
        Me.dgstock.AllowUserToDeleteRows = False
        Me.dgstock.AllowUserToResizeColumns = False
        Me.dgstock.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkCyan
        Me.dgstock.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgstock.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgstock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgstock.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.dgstock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgstock.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgstock.GridColor = System.Drawing.Color.PaleTurquoise
        Me.dgstock.Location = New System.Drawing.Point(507, 166)
        Me.dgstock.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgstock.Name = "dgstock"
        Me.dgstock.ReadOnly = True
        Me.dgstock.RowHeadersVisible = False
        Me.dgstock.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.NullValue = Nothing
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Honeydew
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgstock.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgstock.RowTemplate.Height = 28
        Me.dgstock.Size = New System.Drawing.Size(1395, 1003)
        Me.dgstock.TabIndex = 23
        '
        'Crystalprint
        '
        Me.Crystalprint.Image = Global.resort_management.My.Resources.Resources.crysttal
        Me.Crystalprint.Name = "Crystalprint"
        Me.Crystalprint.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.Crystalprint.Size = New System.Drawing.Size(301, 28)
        Me.Crystalprint.Text = "Crystal Report"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.NavigationToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1902, 31)
        Me.MenuStrip1.TabIndex = 32
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.nwitemcmd, Me.svcmd, Me.edtcmd, Me.searchcmd, Me.delcmd, Me.cnlcmd, Me.prntcmd, Me.extcmd})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Verdana Pro Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(58, 27)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'nwitemcmd
        '
        Me.nwitemcmd.Image = Global.resort_management.My.Resources.Resources.add_90dp_000000_FILL0_wght400_GRAD0_opsz48
        Me.nwitemcmd.Name = "nwitemcmd"
        Me.nwitemcmd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.nwitemcmd.Size = New System.Drawing.Size(268, 30)
        Me.nwitemcmd.Text = "New Item"
        '
        'svcmd
        '
        Me.svcmd.Image = Global.resort_management.My.Resources.Resources.save_90dp_000000_FILL0_wght400_GRAD0_opsz48
        Me.svcmd.Name = "svcmd"
        Me.svcmd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.svcmd.Size = New System.Drawing.Size(268, 30)
        Me.svcmd.Text = "Save"
        '
        'edtcmd
        '
        Me.edtcmd.Image = Global.resort_management.My.Resources.Resources.edit_90dp_000000_FILL0_wght400_GRAD0_opsz48
        Me.edtcmd.Name = "edtcmd"
        Me.edtcmd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.edtcmd.Size = New System.Drawing.Size(268, 30)
        Me.edtcmd.Text = "Edit"
        '
        'searchcmd
        '
        Me.searchcmd.Image = Global.resort_management.My.Resources.Resources.search_90dp_000000_FILL0_wght400_GRAD0_opsz48
        Me.searchcmd.Name = "searchcmd"
        Me.searchcmd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.searchcmd.Size = New System.Drawing.Size(268, 30)
        Me.searchcmd.Text = "Search"
        '
        'delcmd
        '
        Me.delcmd.Image = Global.resort_management.My.Resources.Resources.delete_90dp_000000_FILL0_wght400_GRAD0_opsz48
        Me.delcmd.Name = "delcmd"
        Me.delcmd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Delete), System.Windows.Forms.Keys)
        Me.delcmd.Size = New System.Drawing.Size(268, 30)
        Me.delcmd.Text = "Delete"
        '
        'cnlcmd
        '
        Me.cnlcmd.Image = Global.resort_management.My.Resources.Resources.cancel_90dp_000000_FILL0_wght400_GRAD0_opsz48
        Me.cnlcmd.Name = "cnlcmd"
        Me.cnlcmd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.cnlcmd.Size = New System.Drawing.Size(268, 30)
        Me.cnlcmd.Text = "Cancel"
        '
        'prntcmd
        '
        Me.prntcmd.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.excelprint, Me.Crystalprint})
        Me.prntcmd.Name = "prntcmd"
        Me.prntcmd.Size = New System.Drawing.Size(268, 30)
        Me.prntcmd.Text = "Print"
        '
        'excelprint
        '
        Me.excelprint.Image = Global.resort_management.My.Resources.Resources.excel
        Me.excelprint.Name = "excelprint"
        Me.excelprint.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.excelprint.Size = New System.Drawing.Size(301, 28)
        Me.excelprint.Text = "Excel"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Turquoise
        Me.Panel1.Controls.Add(Me.cbxCategory)
        Me.Panel1.Controls.Add(Me.Picbox)
        Me.Panel1.Controls.Add(Me.txtbrcd)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtiname)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtdes)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtquan)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtcrit)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtsellp)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.browsepic)
        Me.Panel1.Location = New System.Drawing.Point(0, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(478, 1150)
        Me.Panel1.TabIndex = 42
        '
        'cbxCategory
        '
        Me.cbxCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCategory.FormattingEnabled = True
        Me.cbxCategory.Items.AddRange(New Object() {"Food", "Drink"})
        Me.cbxCategory.Location = New System.Drawing.Point(67, 963)
        Me.cbxCategory.Name = "cbxCategory"
        Me.cbxCategory.Size = New System.Drawing.Size(154, 37)
        Me.cbxCategory.TabIndex = 41
        '
        'cbxFilterCategory
        '
        Me.cbxFilterCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxFilterCategory.FormattingEnabled = True
        Me.cbxFilterCategory.Location = New System.Drawing.Point(1341, 88)
        Me.cbxFilterCategory.Name = "cbxFilterCategory"
        Me.cbxFilterCategory.Size = New System.Drawing.Size(286, 39)
        Me.cbxFilterCategory.TabIndex = 43
        '
        'resto_bar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1902, 1153)
        Me.ControlBox = False
        Me.Controls.Add(Me.cbxFilterCategory)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dgstock)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "resto_bar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Picbox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgstock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents totopcmd As ToolStripMenuItem
    Friend WithEvents nextcmd As ToolStripMenuItem
    Friend WithEvents prevcmd As ToolStripMenuItem
    Friend WithEvents tobttmcmd As ToolStripMenuItem
    Friend WithEvents ofd As OpenFileDialog
    Friend WithEvents NavigationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents browsepic As LinkLabel
    Friend WithEvents Picbox As PictureBox
    Friend WithEvents extcmd As ToolStripMenuItem
    Friend WithEvents txtsellp As TextBox
    Friend WithEvents txtcrit As TextBox
    Friend WithEvents txtquan As TextBox
    Friend WithEvents txtdes As TextBox
    Friend WithEvents txtiname As TextBox
    Friend WithEvents txtbrcd As TextBox
    Friend WithEvents dgstock As DataGridView
    Friend WithEvents Crystalprint As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents nwitemcmd As ToolStripMenuItem
    Friend WithEvents svcmd As ToolStripMenuItem
    Friend WithEvents edtcmd As ToolStripMenuItem
    Friend WithEvents searchcmd As ToolStripMenuItem
    Friend WithEvents delcmd As ToolStripMenuItem
    Friend WithEvents cnlcmd As ToolStripMenuItem
    Friend WithEvents prntcmd As ToolStripMenuItem
    Friend WithEvents excelprint As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cbxCategory As ComboBox
    Friend WithEvents cbxFilterCategory As ComboBox
End Class
