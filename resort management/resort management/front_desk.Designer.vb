<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class front_desk
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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlRoom = New System.Windows.Forms.Panel()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblClass = New System.Windows.Forms.Label()
        Me.lblRoomNo = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtSearchGuest = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearchCapacity = New System.Windows.Forms.NumericUpDown()
        Me.rbSearchAll = New System.Windows.Forms.RadioButton()
        Me.cmbSearchStatus = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cmbSearchClassicification = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rbSearchNac = New System.Windows.Forms.RadioButton()
        Me.rbSearchAc = New System.Windows.Forms.RadioButton()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTroom = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblTavailable = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblTcheckin = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblTstay = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblTcheckouts = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.pnlRoom.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtSearchCapacity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Controls.Add(Me.pnlRoom)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 353)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1918, 802)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'pnlRoom
        '
        Me.pnlRoom.BackColor = System.Drawing.Color.SpringGreen
        Me.pnlRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlRoom.Controls.Add(Me.lblType)
        Me.pnlRoom.Controls.Add(Me.lblPrice)
        Me.pnlRoom.Controls.Add(Me.lblStatus)
        Me.pnlRoom.Controls.Add(Me.lblClass)
        Me.pnlRoom.Controls.Add(Me.lblRoomNo)
        Me.pnlRoom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlRoom.Location = New System.Drawing.Point(5, 5)
        Me.pnlRoom.Margin = New System.Windows.Forms.Padding(5)
        Me.pnlRoom.Name = "pnlRoom"
        Me.pnlRoom.Size = New System.Drawing.Size(434, 541)
        Me.pnlRoom.TabIndex = 0
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(111, 23)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(72, 17)
        Me.lblType.TabIndex = 4
        Me.lblType.Text = "roomType"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(37, 126)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(72, 17)
        Me.lblPrice.TabIndex = 3
        Me.lblPrice.Text = "roomPrice"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(37, 95)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(80, 17)
        Me.lblStatus.TabIndex = 2
        Me.lblStatus.Text = "roomStatus"
        '
        'lblClass
        '
        Me.lblClass.AutoSize = True
        Me.lblClass.Location = New System.Drawing.Point(35, 61)
        Me.lblClass.Name = "lblClass"
        Me.lblClass.Size = New System.Drawing.Size(74, 17)
        Me.lblClass.TabIndex = 1
        Me.lblClass.Text = "roomClass"
        '
        'lblRoomNo
        '
        Me.lblRoomNo.AutoSize = True
        Me.lblRoomNo.Location = New System.Drawing.Point(37, 23)
        Me.lblRoomNo.Name = "lblRoomNo"
        Me.lblRoomNo.Size = New System.Drawing.Size(69, 17)
        Me.lblRoomNo.TabIndex = 0
        Me.lblRoomNo.Text = "roomNum"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtSearchGuest)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtSearchCapacity)
        Me.GroupBox1.Controls.Add(Me.rbSearchAll)
        Me.GroupBox1.Controls.Add(Me.cmbSearchStatus)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.cmbSearchClassicification)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.rbSearchNac)
        Me.GroupBox1.Controls.Add(Me.rbSearchAc)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana Pro Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(0, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1918, 191)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FILTER BY"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana Pro", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(1298, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(206, 34)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "CHECK-OUT:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana Pro", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(1300, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 34)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "CHECK-IN:"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(1510, 133)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(359, 35)
        Me.DateTimePicker2.TabIndex = 26
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(1510, 68)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(359, 35)
        Me.DateTimePicker1.TabIndex = 25
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Crimson
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(992, 136)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(275, 37)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "CLEAR FILTER"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtSearchGuest
        '
        Me.txtSearchGuest.Location = New System.Drawing.Point(610, 136)
        Me.txtSearchGuest.Name = "txtSearchGuest"
        Me.txtSearchGuest.Size = New System.Drawing.Size(329, 35)
        Me.txtSearchGuest.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana Pro", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(372, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 34)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "GUEST NAME:"
        '
        'txtSearchCapacity
        '
        Me.txtSearchCapacity.Location = New System.Drawing.Point(378, 78)
        Me.txtSearchCapacity.Name = "txtSearchCapacity"
        Me.txtSearchCapacity.Size = New System.Drawing.Size(178, 35)
        Me.txtSearchCapacity.TabIndex = 21
        Me.txtSearchCapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rbSearchAll
        '
        Me.rbSearchAll.AutoSize = True
        Me.rbSearchAll.Font = New System.Drawing.Font("Verdana Pro Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSearchAll.ForeColor = System.Drawing.Color.White
        Me.rbSearchAll.Location = New System.Drawing.Point(44, 68)
        Me.rbSearchAll.Name = "rbSearchAll"
        Me.rbSearchAll.Size = New System.Drawing.Size(82, 33)
        Me.rbSearchAll.TabIndex = 1
        Me.rbSearchAll.TabStop = True
        Me.rbSearchAll.Text = "ALL"
        Me.rbSearchAll.UseVisualStyleBackColor = True
        '
        'cmbSearchStatus
        '
        Me.cmbSearchStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSearchStatus.FormattingEnabled = True
        Me.cmbSearchStatus.Items.AddRange(New Object() {"AVAILABLE", "OCCUPIED", "RESERVED", "CLEANING", "MAINTENANCE", "INACTIVE"})
        Me.cmbSearchStatus.Location = New System.Drawing.Point(994, 76)
        Me.cmbSearchStatus.Name = "cmbSearchStatus"
        Me.cmbSearchStatus.Size = New System.Drawing.Size(267, 37)
        Me.cmbSearchStatus.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana Pro", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(988, 31)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(145, 34)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "STATUS:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana Pro", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(372, 31)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(184, 34)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "CAPACITY:"
        '
        'cmbSearchClassicification
        '
        Me.cmbSearchClassicification.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSearchClassicification.FormattingEnabled = True
        Me.cmbSearchClassicification.Items.AddRange(New Object() {"COUPLE ROOM", "PER PAX", "FAMILY", "GROUP/COMPANY", "DRIVERS ROOM"})
        Me.cmbSearchClassicification.Location = New System.Drawing.Point(610, 78)
        Me.cmbSearchClassicification.Name = "cmbSearchClassicification"
        Me.cmbSearchClassicification.Size = New System.Drawing.Size(329, 37)
        Me.cmbSearchClassicification.TabIndex = 5
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana Pro", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(604, 33)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(296, 34)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "CLASSIFICATION:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana Pro", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(24, 31)
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
        Me.rbSearchNac.Location = New System.Drawing.Point(44, 141)
        Me.rbSearchNac.Name = "rbSearchNac"
        Me.rbSearchNac.Size = New System.Drawing.Size(305, 33)
        Me.rbSearchNac.TabIndex = 3
        Me.rbSearchNac.TabStop = True
        Me.rbSearchNac.Text = "NON-AIRCONDITION"
        Me.rbSearchNac.UseVisualStyleBackColor = True
        '
        'rbSearchAc
        '
        Me.rbSearchAc.AutoSize = True
        Me.rbSearchAc.Font = New System.Drawing.Font("Verdana Pro Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSearchAc.ForeColor = System.Drawing.Color.White
        Me.rbSearchAc.Location = New System.Drawing.Point(44, 104)
        Me.rbSearchAc.Name = "rbSearchAc"
        Me.rbSearchAc.Size = New System.Drawing.Size(271, 33)
        Me.rbSearchAc.TabIndex = 2
        Me.rbSearchAc.TabStop = True
        Me.rbSearchAc.Text = "AIRCONDITIONED"
        Me.rbSearchAc.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(6, 11)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(0, 17)
        Me.LinkLabel1.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(25, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 25)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Total Room"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel1.Controls.Add(Me.lblTroom)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(46, 228)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(181, 119)
        Me.Panel1.TabIndex = 30
        '
        'lblTroom
        '
        Me.lblTroom.AutoSize = True
        Me.lblTroom.Font = New System.Drawing.Font("Verdana Pro", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTroom.ForeColor = System.Drawing.Color.White
        Me.lblTroom.Location = New System.Drawing.Point(75, 28)
        Me.lblTroom.Name = "lblTroom"
        Me.lblTroom.Size = New System.Drawing.Size(36, 36)
        Me.lblTroom.TabIndex = 30
        Me.lblTroom.Text = "0"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel2.Controls.Add(Me.lblTavailable)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Location = New System.Drawing.Point(247, 228)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(181, 119)
        Me.Panel2.TabIndex = 31
        '
        'lblTavailable
        '
        Me.lblTavailable.AutoSize = True
        Me.lblTavailable.Font = New System.Drawing.Font("Verdana Pro", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTavailable.ForeColor = System.Drawing.Color.White
        Me.lblTavailable.Location = New System.Drawing.Point(75, 28)
        Me.lblTavailable.Name = "lblTavailable"
        Me.lblTavailable.Size = New System.Drawing.Size(36, 36)
        Me.lblTavailable.TabIndex = 30
        Me.lblTavailable.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(32, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 25)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Available"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel3.Controls.Add(Me.lblTcheckin)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Location = New System.Drawing.Point(448, 228)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(181, 119)
        Me.Panel3.TabIndex = 31
        '
        'lblTcheckin
        '
        Me.lblTcheckin.AutoSize = True
        Me.lblTcheckin.Font = New System.Drawing.Font("Verdana Pro", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTcheckin.ForeColor = System.Drawing.Color.White
        Me.lblTcheckin.Location = New System.Drawing.Point(75, 28)
        Me.lblTcheckin.Name = "lblTcheckin"
        Me.lblTcheckin.Size = New System.Drawing.Size(36, 36)
        Me.lblTcheckin.TabIndex = 30
        Me.lblTcheckin.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(29, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 25)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Check-ins"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel4.Controls.Add(Me.lblTstay)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Location = New System.Drawing.Point(649, 228)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(181, 119)
        Me.Panel4.TabIndex = 32
        '
        'lblTstay
        '
        Me.lblTstay.AutoSize = True
        Me.lblTstay.Font = New System.Drawing.Font("Verdana Pro", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTstay.ForeColor = System.Drawing.Color.White
        Me.lblTstay.Location = New System.Drawing.Point(75, 28)
        Me.lblTstay.Name = "lblTstay"
        Me.lblTstay.Size = New System.Drawing.Size(36, 36)
        Me.lblTstay.TabIndex = 30
        Me.lblTstay.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(45, 79)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 25)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Staying"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel5.Controls.Add(Me.lblTcheckouts)
        Me.Panel5.Controls.Add(Me.Label14)
        Me.Panel5.Location = New System.Drawing.Point(850, 228)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(181, 119)
        Me.Panel5.TabIndex = 32
        '
        'lblTcheckouts
        '
        Me.lblTcheckouts.AutoSize = True
        Me.lblTcheckouts.Font = New System.Drawing.Font("Verdana Pro", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTcheckouts.ForeColor = System.Drawing.Color.White
        Me.lblTcheckouts.Location = New System.Drawing.Point(75, 28)
        Me.lblTcheckouts.Name = "lblTcheckouts"
        Me.lblTcheckouts.Size = New System.Drawing.Size(36, 36)
        Me.lblTcheckouts.TabIndex = 30
        Me.lblTcheckouts.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(25, 79)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(139, 25)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Check-Outs"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Button2.Font = New System.Drawing.Font("Verdana Pro Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(1618, 240)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(288, 52)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "MAKE RESERVATION"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'front_desk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1918, 1175)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "front_desk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.pnlRoom.ResumeLayout(False)
        Me.pnlRoom.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtSearchCapacity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbSearchStatus As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents cmbSearchClassicification As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents rbSearchNac As RadioButton
    Friend WithEvents rbSearchAc As RadioButton
    Friend WithEvents rbSearchAll As RadioButton
    Friend WithEvents txtSearchCapacity As NumericUpDown
    Friend WithEvents txtSearchGuest As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents pnlRoom As Panel
    Friend WithEvents lblType As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblClass As Label
    Friend WithEvents lblRoomNo As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTroom As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblTavailable As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblTcheckin As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblTstay As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblTcheckouts As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Button2 As Button
End Class
