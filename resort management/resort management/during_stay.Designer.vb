<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class during_stay
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtGname = New System.Windows.Forms.TextBox()
        Me.txtGcontact = New System.Windows.Forms.TextBox()
        Me.txtGaddress = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblRoomNo = New System.Windows.Forms.Label()
        Me.lblRoomType = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblRoomClass = New System.Windows.Forms.Label()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.nudExtraMat = New System.Windows.Forms.NumericUpDown()
        Me.nudDriversRoom = New System.Windows.Forms.NumericUpDown()
        Me.btncheckout = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblAmountpd = New System.Windows.Forms.Label()
        Me.lblbalance = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblOrdersTotal = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblaccom = New System.Windows.Forms.Label()
        Me.dvgOrders = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        CType(Me.nudExtraMat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDriversRoom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dvgOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'txtGname
        '
        Me.txtGname.Enabled = False
        Me.txtGname.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGname.Location = New System.Drawing.Point(177, 70)
        Me.txtGname.Name = "txtGname"
        Me.txtGname.Size = New System.Drawing.Size(271, 34)
        Me.txtGname.TabIndex = 0
        '
        'txtGcontact
        '
        Me.txtGcontact.Enabled = False
        Me.txtGcontact.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGcontact.Location = New System.Drawing.Point(177, 115)
        Me.txtGcontact.Name = "txtGcontact"
        Me.txtGcontact.Size = New System.Drawing.Size(271, 34)
        Me.txtGcontact.TabIndex = 1
        '
        'txtGaddress
        '
        Me.txtGaddress.Enabled = False
        Me.txtGaddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGaddress.Location = New System.Drawing.Point(177, 160)
        Me.txtGaddress.Name = "txtGaddress"
        Me.txtGaddress.Size = New System.Drawing.Size(271, 34)
        Me.txtGaddress.TabIndex = 2
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(33, 534)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(415, 34)
        Me.DateTimePicker1.TabIndex = 3
        '
        'lblRoomNo
        '
        Me.lblRoomNo.AutoSize = True
        Me.lblRoomNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoomNo.ForeColor = System.Drawing.Color.White
        Me.lblRoomNo.Location = New System.Drawing.Point(171, 237)
        Me.lblRoomNo.Name = "lblRoomNo"
        Me.lblRoomNo.Size = New System.Drawing.Size(149, 36)
        Me.lblRoomNo.TabIndex = 4
        Me.lblRoomNo.Text = "Room No."
        '
        'lblRoomType
        '
        Me.lblRoomType.AutoSize = True
        Me.lblRoomType.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoomType.ForeColor = System.Drawing.Color.White
        Me.lblRoomType.Location = New System.Drawing.Point(168, 287)
        Me.lblRoomType.Name = "lblRoomType"
        Me.lblRoomType.Size = New System.Drawing.Size(81, 36)
        Me.lblRoomType.TabIndex = 5
        Me.lblRoomType.Text = "Type"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.ForeColor = System.Drawing.Color.White
        Me.lblPrice.Location = New System.Drawing.Point(182, 387)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(155, 36)
        Me.lblPrice.TabIndex = 32
        Me.lblPrice.Text = "room price"
        '
        'lblRoomClass
        '
        Me.lblRoomClass.AutoSize = True
        Me.lblRoomClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoomClass.ForeColor = System.Drawing.Color.White
        Me.lblRoomClass.Location = New System.Drawing.Point(162, 337)
        Me.lblRoomClass.Name = "lblRoomClass"
        Me.lblRoomClass.Size = New System.Drawing.Size(158, 36)
        Me.lblRoomClass.TabIndex = 31
        Me.lblRoomClass.Text = "room class"
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.SpringGreen
        Me.btnsave.Enabled = False
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(11, 733)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(235, 70)
        Me.btnsave.TabIndex = 33
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.Color.LightCoral
        Me.btnedit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.Location = New System.Drawing.Point(252, 733)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(235, 70)
        Me.btnedit.TabIndex = 34
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'nudExtraMat
        '
        Me.nudExtraMat.Enabled = False
        Me.nudExtraMat.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudExtraMat.Location = New System.Drawing.Point(289, 643)
        Me.nudExtraMat.Name = "nudExtraMat"
        Me.nudExtraMat.Size = New System.Drawing.Size(159, 34)
        Me.nudExtraMat.TabIndex = 44
        Me.nudExtraMat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'nudDriversRoom
        '
        Me.nudDriversRoom.Enabled = False
        Me.nudDriversRoom.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudDriversRoom.Location = New System.Drawing.Point(33, 643)
        Me.nudDriversRoom.Name = "nudDriversRoom"
        Me.nudDriversRoom.ReadOnly = True
        Me.nudDriversRoom.Size = New System.Drawing.Size(159, 34)
        Me.nudDriversRoom.TabIndex = 43
        Me.nudDriversRoom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btncheckout
        '
        Me.btncheckout.BackColor = System.Drawing.Color.Red
        Me.btncheckout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncheckout.ForeColor = System.Drawing.Color.White
        Me.btncheckout.Location = New System.Drawing.Point(1065, 736)
        Me.btncheckout.Name = "btncheckout"
        Me.btncheckout.Size = New System.Drawing.Size(266, 70)
        Me.btncheckout.TabIndex = 45
        Me.btncheckout.Text = "Check-out"
        Me.btncheckout.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(18, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 29)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Guest Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(18, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 29)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Contact:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(18, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 29)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Address:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana Pro", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(16, 611)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 29)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Drivers Room"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana Pro", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(16, 493)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(195, 29)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Check-out date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana Pro", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(263, 611)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(185, 29)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Extra Mattress"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(12, 237)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(149, 36)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Room No."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(15, 287)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 36)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Type"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(12, 337)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 36)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "Class."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(14, 387)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(162, 36)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "Price/Night"
        '
        'lblAmountpd
        '
        Me.lblAmountpd.AutoSize = True
        Me.lblAmountpd.Font = New System.Drawing.Font("Verdana Pro", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountpd.ForeColor = System.Drawing.Color.White
        Me.lblAmountpd.Location = New System.Drawing.Point(1048, 631)
        Me.lblAmountpd.Name = "lblAmountpd"
        Me.lblAmountpd.Size = New System.Drawing.Size(162, 29)
        Me.lblAmountpd.TabIndex = 56
        Me.lblAmountpd.Text = "amount Paid"
        '
        'lblbalance
        '
        Me.lblbalance.AutoSize = True
        Me.lblbalance.Font = New System.Drawing.Font("Verdana Pro", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbalance.ForeColor = System.Drawing.Color.White
        Me.lblbalance.Location = New System.Drawing.Point(532, 6)
        Me.lblbalance.Name = "lblbalance"
        Me.lblbalance.Size = New System.Drawing.Size(150, 41)
        Me.lblbalance.TabIndex = 57
        Me.lblbalance.Text = "Balance"
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.ForeColor = System.Drawing.Color.White
        Me.lbltotal.Location = New System.Drawing.Point(320, 7)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(103, 32)
        Me.lbltotal.TabIndex = 58
        Me.lbltotal.Text = "10,000"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(15, 7)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(114, 32)
        Me.Label11.TabIndex = 61
        Me.Label11.Text = "TOTAL:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana Pro", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(19, 12)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(135, 29)
        Me.Label12.TabIndex = 60
        Me.Label12.Text = "BALANCE:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana Pro", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(527, 631)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(175, 29)
        Me.Label13.TabIndex = 59
        Me.Label13.Text = "Amount Paid:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Turquoise
        Me.Panel1.Controls.Add(Me.lbltotal)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Location = New System.Drawing.Point(511, 583)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(855, 45)
        Me.Panel1.TabIndex = 62
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana Pro", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(527, 542)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(182, 29)
        Me.Label14.TabIndex = 63
        Me.Label14.Text = "Food Order/s:"
        '
        'lblOrdersTotal
        '
        Me.lblOrdersTotal.AutoSize = True
        Me.lblOrdersTotal.Font = New System.Drawing.Font("Verdana Pro", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrdersTotal.ForeColor = System.Drawing.Color.White
        Me.lblOrdersTotal.Location = New System.Drawing.Point(832, 542)
        Me.lblOrdersTotal.Name = "lblOrdersTotal"
        Me.lblOrdersTotal.Size = New System.Drawing.Size(80, 29)
        Me.lblOrdersTotal.TabIndex = 62
        Me.lblOrdersTotal.Text = "foodP"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana Pro", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(527, 500)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(194, 29)
        Me.Label16.TabIndex = 65
        Me.Label16.Text = "Accomudation:"
        '
        'lblaccom
        '
        Me.lblaccom.AutoSize = True
        Me.lblaccom.Font = New System.Drawing.Font("Verdana Pro", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblaccom.ForeColor = System.Drawing.Color.White
        Me.lblaccom.Location = New System.Drawing.Point(832, 500)
        Me.lblaccom.Name = "lblaccom"
        Me.lblaccom.Size = New System.Drawing.Size(79, 29)
        Me.lblaccom.TabIndex = 64
        Me.lblaccom.Text = "Acco."
        '
        'dvgOrders
        '
        Me.dvgOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dvgOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgOrders.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dvgOrders.Location = New System.Drawing.Point(503, 68)
        Me.dvgOrders.Name = "dvgOrders"
        Me.dvgOrders.ReadOnly = True
        Me.dvgOrders.RowHeadersVisible = False
        Me.dvgOrders.RowTemplate.Height = 24
        Me.dvgOrders.Size = New System.Drawing.Size(855, 413)
        Me.dvgOrders.TabIndex = 63
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Cyan
        Me.Panel2.Controls.Add(Me.lblbalance)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Location = New System.Drawing.Point(511, 663)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(855, 54)
        Me.Panel2.TabIndex = 66
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.nudExtraMat)
        Me.Panel3.Controls.Add(Me.nudDriversRoom)
        Me.Panel3.Controls.Add(Me.btnedit)
        Me.Panel3.Controls.Add(Me.btnsave)
        Me.Panel3.Controls.Add(Me.lblPrice)
        Me.Panel3.Controls.Add(Me.lblRoomClass)
        Me.Panel3.Controls.Add(Me.lblRoomType)
        Me.Panel3.Controls.Add(Me.lblRoomNo)
        Me.Panel3.Controls.Add(Me.DateTimePicker1)
        Me.Panel3.Controls.Add(Me.txtGaddress)
        Me.Panel3.Controls.Add(Me.txtGcontact)
        Me.Panel3.Controls.Add(Me.txtGname)
        Me.Panel3.Location = New System.Drawing.Point(0, -2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(495, 840)
        Me.Panel3.TabIndex = 67
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Palatino Linotype", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(501, -2)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(266, 46)
        Me.Label15.TabIndex = 56
        Me.Label15.Text = "FOOD ORDERS"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Palatino Linotype", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(3, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(391, 46)
        Me.Label17.TabIndex = 68
        Me.Label17.Text = "GUEST INFORMATION"
        '
        'during_stay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1368, 835)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lblaccom)
        Me.Controls.Add(Me.dvgOrders)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblOrdersTotal)
        Me.Controls.Add(Me.lblAmountpd)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btncheckout)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "during_stay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.nudExtraMat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDriversRoom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dvgOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtGname As TextBox
    Friend WithEvents txtGcontact As TextBox
    Friend WithEvents txtGaddress As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents lblRoomNo As Label
    Friend WithEvents lblRoomType As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblRoomClass As Label
    Friend WithEvents btnsave As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents nudExtraMat As NumericUpDown
    Friend WithEvents nudDriversRoom As NumericUpDown
    Friend WithEvents btncheckout As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblAmountpd As Label
    Friend WithEvents lblbalance As Label
    Friend WithEvents lbltotal As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents lblOrdersTotal As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lblaccom As Label
    Friend WithEvents dvgOrders As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents Label15 As Label
End Class
