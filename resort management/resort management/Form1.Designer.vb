<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MENUToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdSearch = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdCancel = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXCELToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CRYSTALREPORTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.NAVIGATIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TOTOPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NEXTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PREVIOUSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TOBOTTOMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.rb_Ac = New System.Windows.Forms.RadioButton()
        Me.rb_Nac = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbClass = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRcapacity = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.picbox = New System.Windows.Forms.PictureBox()
        Me.lnkbrowse = New System.Windows.Forms.LinkLabel()
        Me.dgvRooms = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtRnum = New System.Windows.Forms.TextBox()
        Me.txtRoomID = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbSearchStatus = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtSearchCapacity = New System.Windows.Forms.TextBox()
        Me.cmbSearchClassicification = New System.Windows.Forms.ComboBox()
        Me.txtSearchPrice = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rbSearchNac = New System.Windows.Forms.RadioButton()
        Me.rbSearchAc = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.picbox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRooms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MENUToolStripMenuItem, Me.NAVIGATIONToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1918, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MENUToolStripMenuItem
        '
        Me.MENUToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAdd, Me.cmdSave, Me.cmdEdit, Me.cmdSearch, Me.cmdDelete, Me.cmdCancel, Me.cmdPrint, Me.cmdClose})
        Me.MENUToolStripMenuItem.Font = New System.Drawing.Font("Verdana Pro Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MENUToolStripMenuItem.Name = "MENUToolStripMenuItem"
        Me.MENUToolStripMenuItem.Size = New System.Drawing.Size(87, 29)
        Me.MENUToolStripMenuItem.Text = "MENU"
        '
        'cmdAdd
        '
        Me.cmdAdd.Image = Global.resort_management.My.Resources.Resources.add_90dp_000000_FILL0_wght400_GRAD0_opsz48
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.cmdAdd.Size = New System.Drawing.Size(276, 30)
        Me.cmdAdd.Text = "ADD"
        '
        'cmdSave
        '
        Me.cmdSave.Image = Global.resort_management.My.Resources.Resources.save_90dp_000000_FILL0_wght400_GRAD0_opsz48
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.cmdSave.Size = New System.Drawing.Size(276, 30)
        Me.cmdSave.Text = "SAVE"
        '
        'cmdEdit
        '
        Me.cmdEdit.Image = Global.resort_management.My.Resources.Resources.edit_90dp_000000_FILL0_wght400_GRAD0_opsz48
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.cmdEdit.Size = New System.Drawing.Size(276, 30)
        Me.cmdEdit.Text = "EDIT"
        '
        'cmdSearch
        '
        Me.cmdSearch.Image = Global.resort_management.My.Resources.Resources.search_90dp_000000_FILL0_wght400_GRAD0_opsz48
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.cmdSearch.Size = New System.Drawing.Size(276, 30)
        Me.cmdSearch.Text = "SEARCH"
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = Global.resort_management.My.Resources.Resources.delete_90dp_000000_FILL0_wght400_GRAD0_opsz48
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Delete), System.Windows.Forms.Keys)
        Me.cmdDelete.Size = New System.Drawing.Size(276, 30)
        Me.cmdDelete.Text = "DELETE"
        '
        'cmdCancel
        '
        Me.cmdCancel.Image = Global.resort_management.My.Resources.Resources.cancel_90dp_000000_FILL0_wght400_GRAD0_opsz48
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.cmdCancel.Size = New System.Drawing.Size(276, 30)
        Me.cmdCancel.Text = "CANCEL"
        '
        'cmdPrint
        '
        Me.cmdPrint.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EXCELToolStripMenuItem, Me.CRYSTALREPORTToolStripMenuItem})
        Me.cmdPrint.Image = Global.resort_management.My.Resources.Resources.print_90dp_000000_FILL0_wght400_GRAD0_opsz48
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(276, 30)
        Me.cmdPrint.Text = "PRINT"
        '
        'EXCELToolStripMenuItem
        '
        Me.EXCELToolStripMenuItem.Image = Global.resort_management.My.Resources.Resources.excel
        Me.EXCELToolStripMenuItem.Name = "EXCELToolStripMenuItem"
        Me.EXCELToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.EXCELToolStripMenuItem.Size = New System.Drawing.Size(353, 30)
        Me.EXCELToolStripMenuItem.Text = "Excel"
        '
        'CRYSTALREPORTToolStripMenuItem
        '
        Me.CRYSTALREPORTToolStripMenuItem.Image = Global.resort_management.My.Resources.Resources.crysttal
        Me.CRYSTALREPORTToolStripMenuItem.Name = "CRYSTALREPORTToolStripMenuItem"
        Me.CRYSTALREPORTToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CRYSTALREPORTToolStripMenuItem.Size = New System.Drawing.Size(353, 30)
        Me.CRYSTALREPORTToolStripMenuItem.Text = "CRYSTAL REPORT"
        '
        'cmdClose
        '
        Me.cmdClose.Image = Global.resort_management.My.Resources.Resources.logout_90dp_000000_FILL0_wght400_GRAD0_opsz48
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.cmdClose.Size = New System.Drawing.Size(276, 30)
        Me.cmdClose.Text = "EXIT"
        '
        'NAVIGATIONToolStripMenuItem
        '
        Me.NAVIGATIONToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TOTOPToolStripMenuItem, Me.NEXTToolStripMenuItem, Me.PREVIOUSToolStripMenuItem, Me.TOBOTTOMToolStripMenuItem})
        Me.NAVIGATIONToolStripMenuItem.Font = New System.Drawing.Font("Verdana Pro Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NAVIGATIONToolStripMenuItem.Name = "NAVIGATIONToolStripMenuItem"
        Me.NAVIGATIONToolStripMenuItem.Size = New System.Drawing.Size(166, 29)
        Me.NAVIGATIONToolStripMenuItem.Text = "NAVIGATION"
        '
        'TOTOPToolStripMenuItem
        '
        Me.TOTOPToolStripMenuItem.Image = Global.resort_management.My.Resources.Resources.arrow_upward_90dp_000000_FILL0_wght400_GRAD0_opsz48
        Me.TOTOPToolStripMenuItem.Name = "TOTOPToolStripMenuItem"
        Me.TOTOPToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Up), System.Windows.Forms.Keys)
        Me.TOTOPToolStripMenuItem.Size = New System.Drawing.Size(347, 30)
        Me.TOTOPToolStripMenuItem.Text = "TO TOP"
        '
        'NEXTToolStripMenuItem
        '
        Me.NEXTToolStripMenuItem.Image = Global.resort_management.My.Resources.Resources.arrow_forward_90dp_000000_FILL0_wght400_GRAD0_opsz48
        Me.NEXTToolStripMenuItem.Name = "NEXTToolStripMenuItem"
        Me.NEXTToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Right), System.Windows.Forms.Keys)
        Me.NEXTToolStripMenuItem.Size = New System.Drawing.Size(347, 30)
        Me.NEXTToolStripMenuItem.Text = "NEXT"
        '
        'PREVIOUSToolStripMenuItem
        '
        Me.PREVIOUSToolStripMenuItem.Image = Global.resort_management.My.Resources.Resources.arrow_left_alt_90dp_000000_FILL0_wght400_GRAD0_opsz48
        Me.PREVIOUSToolStripMenuItem.Name = "PREVIOUSToolStripMenuItem"
        Me.PREVIOUSToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Left), System.Windows.Forms.Keys)
        Me.PREVIOUSToolStripMenuItem.Size = New System.Drawing.Size(347, 30)
        Me.PREVIOUSToolStripMenuItem.Text = "PREVIOUS"
        '
        'TOBOTTOMToolStripMenuItem
        '
        Me.TOBOTTOMToolStripMenuItem.Image = Global.resort_management.My.Resources.Resources.arrow_downward_90dp_000000_FILL0_wght400_GRAD0_opsz48
        Me.TOBOTTOMToolStripMenuItem.Name = "TOBOTTOMToolStripMenuItem"
        Me.TOBOTTOMToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Down), System.Windows.Forms.Keys)
        Me.TOBOTTOMToolStripMenuItem.Size = New System.Drawing.Size(347, 30)
        Me.TOBOTTOMToolStripMenuItem.Text = "TO BOTTOM"
        '
        'rb_Ac
        '
        Me.rb_Ac.AutoSize = True
        Me.rb_Ac.Font = New System.Drawing.Font("Verdana Pro Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_Ac.ForeColor = System.Drawing.Color.White
        Me.rb_Ac.Location = New System.Drawing.Point(56, 70)
        Me.rb_Ac.Name = "rb_Ac"
        Me.rb_Ac.Size = New System.Drawing.Size(271, 33)
        Me.rb_Ac.TabIndex = 5
        Me.rb_Ac.TabStop = True
        Me.rb_Ac.Text = "AIRCONDITIONED"
        Me.rb_Ac.UseVisualStyleBackColor = True
        '
        'rb_Nac
        '
        Me.rb_Nac.AutoSize = True
        Me.rb_Nac.Font = New System.Drawing.Font("Verdana Pro Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_Nac.ForeColor = System.Drawing.Color.White
        Me.rb_Nac.Location = New System.Drawing.Point(56, 118)
        Me.rb_Nac.Name = "rb_Nac"
        Me.rb_Nac.Size = New System.Drawing.Size(305, 33)
        Me.rb_Nac.TabIndex = 6
        Me.rb_Nac.TabStop = True
        Me.rb_Nac.Text = "NON-AIRCONDITION"
        Me.rb_Nac.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbStatus)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.rb_Nac)
        Me.Panel1.Controls.Add(Me.cmbClass)
        Me.Panel1.Controls.Add(Me.rb_Ac)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(439, 146)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(393, 375)
        Me.Panel1.TabIndex = 3
        '
        'cmbStatus
        '
        Me.cmbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"AVAILABLE", "OCCUPIED", "RESERVED", "CLEANING", "MAINTENANCE", "INACTIVE"})
        Me.cmbStatus.Location = New System.Drawing.Point(56, 316)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(290, 37)
        Me.cmbStatus.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana Pro", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(21, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 34)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ROOM TYPE:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana Pro", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(33, 267)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(145, 34)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "STATUS:"
        '
        'cmbClass
        '
        Me.cmbClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbClass.FormattingEnabled = True
        Me.cmbClass.Location = New System.Drawing.Point(56, 215)
        Me.cmbClass.Name = "cmbClass"
        Me.cmbClass.Size = New System.Drawing.Size(290, 37)
        Me.cmbClass.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana Pro", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(26, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(296, 34)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "CLASSIFICATION:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana Pro", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(22, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 34)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "NAME:"
        '
        'txtRname
        '
        Me.txtRname.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRname.Location = New System.Drawing.Point(29, 61)
        Me.txtRname.Name = "txtRname"
        Me.txtRname.Size = New System.Drawing.Size(378, 34)
        Me.txtRname.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana Pro", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(223, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(184, 34)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "CAPACITY:"
        '
        'txtRcapacity
        '
        Me.txtRcapacity.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRcapacity.Location = New System.Drawing.Point(251, 180)
        Me.txtRcapacity.Name = "txtRcapacity"
        Me.txtRcapacity.Size = New System.Drawing.Size(156, 34)
        Me.txtRcapacity.TabIndex = 8
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(38, 302)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(369, 34)
        Me.txtPrice.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana Pro", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(32, 251)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 34)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "PRICE:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Turquoise
        Me.Panel2.Controls.Add(Me.picbox)
        Me.Panel2.Controls.Add(Me.lnkbrowse)
        Me.Panel2.Location = New System.Drawing.Point(807, 18)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(397, 502)
        Me.Panel2.TabIndex = 11
        '
        'picbox
        '
        Me.picbox.BackColor = System.Drawing.Color.LightSeaGreen
        Me.picbox.Location = New System.Drawing.Point(20, 18)
        Me.picbox.Name = "picbox"
        Me.picbox.Size = New System.Drawing.Size(360, 360)
        Me.picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picbox.TabIndex = 1
        Me.picbox.TabStop = False
        '
        'lnkbrowse
        '
        Me.lnkbrowse.AutoSize = True
        Me.lnkbrowse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkbrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkbrowse.LinkColor = System.Drawing.Color.Black
        Me.lnkbrowse.Location = New System.Drawing.Point(18, 452)
        Me.lnkbrowse.Name = "lnkbrowse"
        Me.lnkbrowse.Size = New System.Drawing.Size(149, 25)
        Me.lnkbrowse.TabIndex = 0
        Me.lnkbrowse.TabStop = True
        Me.lnkbrowse.Text = "BROWSE PIC"
        '
        'dgvRooms
        '
        Me.dgvRooms.AllowUserToResizeColumns = False
        Me.dgvRooms.AllowUserToResizeRows = False
        Me.dgvRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRooms.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRooms.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRooms.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvRooms.Location = New System.Drawing.Point(25, 654)
        Me.dgvRooms.MultiSelect = False
        Me.dgvRooms.Name = "dgvRooms"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRooms.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvRooms.RowHeadersVisible = False
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRooms.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvRooms.RowTemplate.Height = 24
        Me.dgvRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRooms.Size = New System.Drawing.Size(1867, 541)
        Me.dgvRooms.TabIndex = 12
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.txtRnum)
        Me.Panel3.Controls.Add(Me.txtRcapacity)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.txtPrice)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.txtRname)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(6, 147)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(432, 374)
        Me.Panel3.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana Pro", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(23, 133)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(162, 34)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "NUMBER:"
        '
        'txtRnum
        '
        Me.txtRnum.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRnum.Location = New System.Drawing.Point(29, 180)
        Me.txtRnum.Name = "txtRnum"
        Me.txtRnum.Size = New System.Drawing.Size(156, 34)
        Me.txtRnum.TabIndex = 2
        '
        'txtRoomID
        '
        Me.txtRoomID.BackColor = System.Drawing.Color.Teal
        Me.txtRoomID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRoomID.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoomID.Location = New System.Drawing.Point(34, 102)
        Me.txtRoomID.Name = "txtRoomID"
        Me.txtRoomID.ReadOnly = True
        Me.txtRoomID.Size = New System.Drawing.Size(201, 27)
        Me.txtRoomID.TabIndex = 1
        Me.txtRoomID.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbSearchStatus)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtSearchCapacity)
        Me.GroupBox1.Controls.Add(Me.cmbSearchClassicification)
        Me.GroupBox1.Controls.Add(Me.txtSearchPrice)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.rbSearchNac)
        Me.GroupBox1.Controls.Add(Me.rbSearchAc)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana Pro Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(672, 527)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FILTER BY"
        '
        'cmbSearchStatus
        '
        Me.cmbSearchStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSearchStatus.FormattingEnabled = True
        Me.cmbSearchStatus.Items.AddRange(New Object() {"AVAILABLE", "OCCUPIED", "RESERVED", "CLEANING", "MAINTENANCE", "INACTIVE"})
        Me.cmbSearchStatus.Location = New System.Drawing.Point(373, 220)
        Me.cmbSearchStatus.Name = "cmbSearchStatus"
        Me.cmbSearchStatus.Size = New System.Drawing.Size(267, 37)
        Me.cmbSearchStatus.TabIndex = 14
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana Pro", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(372, 178)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(145, 34)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "STATUS:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(15, 347)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(134, 25)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "max value:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana Pro", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(372, 82)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(184, 34)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "CAPACITY:"
        '
        'txtSearchCapacity
        '
        Me.txtSearchCapacity.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchCapacity.Location = New System.Drawing.Point(373, 129)
        Me.txtSearchCapacity.Name = "txtSearchCapacity"
        Me.txtSearchCapacity.Size = New System.Drawing.Size(267, 34)
        Me.txtSearchCapacity.TabIndex = 13
        '
        'cmbSearchClassicification
        '
        Me.cmbSearchClassicification.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSearchClassicification.FormattingEnabled = True
        Me.cmbSearchClassicification.Location = New System.Drawing.Point(378, 372)
        Me.cmbSearchClassicification.Name = "cmbSearchClassicification"
        Me.cmbSearchClassicification.Size = New System.Drawing.Size(262, 37)
        Me.cmbSearchClassicification.TabIndex = 15
        '
        'txtSearchPrice
        '
        Me.txtSearchPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchPrice.Location = New System.Drawing.Point(52, 375)
        Me.txtSearchPrice.Name = "txtSearchPrice"
        Me.txtSearchPrice.Size = New System.Drawing.Size(236, 34)
        Me.txtSearchPrice.TabIndex = 12
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana Pro", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(349, 299)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(296, 34)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "CLASSIFICATION:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana Pro", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(24, 299)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(243, 34)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "PRICE RANGE:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana Pro", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(24, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(213, 34)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "ROOM TYPE:"
        '
        'rbSearchNac
        '
        Me.rbSearchNac.AutoSize = True
        Me.rbSearchNac.Font = New System.Drawing.Font("Verdana Pro Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSearchNac.ForeColor = System.Drawing.Color.White
        Me.rbSearchNac.Location = New System.Drawing.Point(64, 209)
        Me.rbSearchNac.Name = "rbSearchNac"
        Me.rbSearchNac.Size = New System.Drawing.Size(305, 33)
        Me.rbSearchNac.TabIndex = 11
        Me.rbSearchNac.TabStop = True
        Me.rbSearchNac.Text = "NON-AIRCONDITION"
        Me.rbSearchNac.UseVisualStyleBackColor = True
        '
        'rbSearchAc
        '
        Me.rbSearchAc.AutoSize = True
        Me.rbSearchAc.Font = New System.Drawing.Font("Verdana Pro Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSearchAc.ForeColor = System.Drawing.Color.White
        Me.rbSearchAc.Location = New System.Drawing.Point(64, 146)
        Me.rbSearchAc.Name = "rbSearchAc"
        Me.rbSearchAc.Size = New System.Drawing.Size(271, 33)
        Me.rbSearchAc.TabIndex = 10
        Me.rbSearchAc.TabStop = True
        Me.rbSearchAc.Text = "AIRCONDITIONED"
        Me.rbSearchAc.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Palatino Linotype", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(7, 543)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(365, 108)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "ROOMS"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Palatino Linotype", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(20, 18)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(718, 81)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "ROOM INFORMATION"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Panel3)
        Me.GroupBox2.Controls.Add(Me.Panel2)
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Controls.Add(Me.txtRoomID)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(690, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox2.Size = New System.Drawing.Size(1216, 527)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        '
        'ofd
        '
        Me.ofd.FileName = "ofd"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1918, 1198)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvRooms)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.picbox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRooms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MENUToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents rb_Ac As RadioButton
    Friend WithEvents rb_Nac As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtRname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtRcapacity As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cmbClass As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmdAdd As ToolStripMenuItem
    Friend WithEvents cmdEdit As ToolStripMenuItem
    Friend WithEvents cmdDelete As ToolStripMenuItem
    Friend WithEvents cmdPrint As ToolStripMenuItem
    Friend WithEvents NAVIGATIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dgvRooms As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents rbSearchNac As RadioButton
    Friend WithEvents rbSearchAc As RadioButton
    Friend WithEvents txtSearchPrice As TextBox
    Friend WithEvents cmdClose As ToolStripMenuItem
    Friend WithEvents Label9 As Label
    Friend WithEvents txtRoomID As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtRnum As TextBox
    Friend WithEvents cmdCancel As ToolStripMenuItem
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmdSave As ToolStripMenuItem
    Friend WithEvents TOTOPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NEXTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PREVIOUSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TOBOTTOMToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmdSearch As ToolStripMenuItem
    Friend WithEvents cmbSearchStatus As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cmbSearchClassicification As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtSearchCapacity As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents EXCELToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CRYSTALREPORTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents picbox As PictureBox
    Friend WithEvents lnkbrowse As LinkLabel
    Friend WithEvents ofd As OpenFileDialog
End Class
