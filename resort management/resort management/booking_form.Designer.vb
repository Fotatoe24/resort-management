<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class booking_form
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
        Me.btnCheckIN = New System.Windows.Forms.Button()
        Me.dtCheckIn = New System.Windows.Forms.DateTimePicker()
        Me.dtCheckOut = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtGuestContact = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtGuestAddress = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblRoomNo = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblRoomType = New System.Windows.Forms.Label()
        Me.lblRoomClass = New System.Windows.Forms.Label()
        Me.lblNights = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.rbFullPayment = New System.Windows.Forms.RadioButton()
        Me.rbDownPayment = New System.Windows.Forms.RadioButton()
        Me.txtDownpayment = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.cboGuest = New System.Windows.Forms.ComboBox()
        Me.lblGuestID = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnReserve = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblRoomName = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.nudExtraMat = New System.Windows.Forms.NumericUpDown()
        Me.nudDriversRoom = New System.Windows.Forms.NumericUpDown()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.lblBookingID = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnNoshow = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.nudExtraMat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDriversRoom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCheckIN
        '
        Me.btnCheckIN.BackColor = System.Drawing.Color.Lime
        Me.btnCheckIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckIN.ForeColor = System.Drawing.Color.Black
        Me.btnCheckIN.Location = New System.Drawing.Point(19, 785)
        Me.btnCheckIN.Name = "btnCheckIN"
        Me.btnCheckIN.Size = New System.Drawing.Size(294, 56)
        Me.btnCheckIN.TabIndex = 0
        Me.btnCheckIN.Text = "CHECK-IN"
        Me.btnCheckIN.UseVisualStyleBackColor = False
        '
        'dtCheckIn
        '
        Me.dtCheckIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtCheckIn.Location = New System.Drawing.Point(37, 111)
        Me.dtCheckIn.Name = "dtCheckIn"
        Me.dtCheckIn.Size = New System.Drawing.Size(336, 30)
        Me.dtCheckIn.TabIndex = 1
        '
        'dtCheckOut
        '
        Me.dtCheckOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtCheckOut.Location = New System.Drawing.Point(37, 193)
        Me.dtCheckOut.Name = "dtCheckOut"
        Me.dtCheckOut.Size = New System.Drawing.Size(335, 30)
        Me.dtCheckOut.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana Pro", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(15, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 29)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "GUEST NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana Pro", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(449, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 29)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "CONTACT NO."
        '
        'txtGuestContact
        '
        Me.txtGuestContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuestContact.Location = New System.Drawing.Point(454, 134)
        Me.txtGuestContact.Name = "txtGuestContact"
        Me.txtGuestContact.ReadOnly = True
        Me.txtGuestContact.Size = New System.Drawing.Size(325, 34)
        Me.txtGuestContact.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana Pro", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(800, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 29)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "ADDRESS"
        '
        'txtGuestAddress
        '
        Me.txtGuestAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGuestAddress.Location = New System.Drawing.Point(805, 134)
        Me.txtGuestAddress.Name = "txtGuestAddress"
        Me.txtGuestAddress.ReadOnly = True
        Me.txtGuestAddress.Size = New System.Drawing.Size(340, 34)
        Me.txtGuestAddress.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(10, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(521, 58)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "GUEST INFORMATION"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana Pro", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(31, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 29)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "CHECK-IN"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana Pro", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(31, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(167, 29)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "CHECK-OUT"
        '
        'lblRoomNo
        '
        Me.lblRoomNo.AutoSize = True
        Me.lblRoomNo.Font = New System.Drawing.Font("Verdana Pro", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoomNo.ForeColor = System.Drawing.Color.White
        Me.lblRoomNo.Location = New System.Drawing.Point(584, 79)
        Me.lblRoomNo.Name = "lblRoomNo"
        Me.lblRoomNo.Size = New System.Drawing.Size(126, 29)
        Me.lblRoomNo.TabIndex = 13
        Me.lblRoomNo.Text = "room No"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(9, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(295, 58)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "ROOM INFO"
        '
        'lblRoomType
        '
        Me.lblRoomType.AutoSize = True
        Me.lblRoomType.Font = New System.Drawing.Font("Verdana Pro", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoomType.ForeColor = System.Drawing.Color.White
        Me.lblRoomType.Location = New System.Drawing.Point(584, 136)
        Me.lblRoomType.Name = "lblRoomType"
        Me.lblRoomType.Size = New System.Drawing.Size(150, 29)
        Me.lblRoomType.TabIndex = 15
        Me.lblRoomType.Text = "room type"
        '
        'lblRoomClass
        '
        Me.lblRoomClass.AutoSize = True
        Me.lblRoomClass.Font = New System.Drawing.Font("Verdana Pro", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoomClass.ForeColor = System.Drawing.Color.White
        Me.lblRoomClass.Location = New System.Drawing.Point(584, 193)
        Me.lblRoomClass.Name = "lblRoomClass"
        Me.lblRoomClass.Size = New System.Drawing.Size(156, 29)
        Me.lblRoomClass.TabIndex = 16
        Me.lblRoomClass.Text = "room class"
        '
        'lblNights
        '
        Me.lblNights.AutoSize = True
        Me.lblNights.Font = New System.Drawing.Font("Verdana Pro", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNights.ForeColor = System.Drawing.Color.White
        Me.lblNights.Location = New System.Drawing.Point(935, 588)
        Me.lblNights.Name = "lblNights"
        Me.lblNights.Size = New System.Drawing.Size(167, 29)
        Me.lblNights.TabIndex = 17
        Me.lblNights.Text = "total nights"
        Me.lblNights.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Verdana Pro", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(160, 9)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(108, 40)
        Me.lblTotal.TabIndex = 18
        Me.lblTotal.Text = "Total"
        '
        'rbFullPayment
        '
        Me.rbFullPayment.AutoSize = True
        Me.rbFullPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFullPayment.Location = New System.Drawing.Point(43, 651)
        Me.rbFullPayment.Name = "rbFullPayment"
        Me.rbFullPayment.Size = New System.Drawing.Size(185, 33)
        Me.rbFullPayment.TabIndex = 19
        Me.rbFullPayment.TabStop = True
        Me.rbFullPayment.Text = "Full Payment"
        Me.rbFullPayment.UseVisualStyleBackColor = True
        '
        'rbDownPayment
        '
        Me.rbDownPayment.AutoSize = True
        Me.rbDownPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDownPayment.Location = New System.Drawing.Point(43, 693)
        Me.rbDownPayment.Name = "rbDownPayment"
        Me.rbDownPayment.Size = New System.Drawing.Size(207, 33)
        Me.rbDownPayment.TabIndex = 20
        Me.rbDownPayment.TabStop = True
        Me.rbDownPayment.Text = "Down Payment"
        Me.rbDownPayment.UseVisualStyleBackColor = True
        '
        'txtDownpayment
        '
        Me.txtDownpayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDownpayment.Location = New System.Drawing.Point(278, 694)
        Me.txtDownpayment.Name = "txtDownpayment"
        Me.txtDownpayment.Size = New System.Drawing.Size(143, 34)
        Me.txtDownpayment.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Palatino Linotype", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(12, 559)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(239, 58)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "PAYMENT"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Turquoise
        Me.Panel1.Controls.Add(Me.btnNew)
        Me.Panel1.Controls.Add(Me.cboGuest)
        Me.Panel1.Controls.Add(Me.lblGuestID)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtGuestAddress)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtGuestContact)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1169, 188)
        Me.Panel1.TabIndex = 23
        '
        'btnNew
        '
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ForeColor = System.Drawing.Color.Black
        Me.btnNew.Location = New System.Drawing.Point(973, 62)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(172, 33)
        Me.btnNew.TabIndex = 43
        Me.btnNew.Text = "NEW GUEST"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'cboGuest
        '
        Me.cboGuest.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGuest.FormattingEnabled = True
        Me.cboGuest.Location = New System.Drawing.Point(16, 134)
        Me.cboGuest.Name = "cboGuest"
        Me.cboGuest.Size = New System.Drawing.Size(417, 33)
        Me.cboGuest.TabIndex = 14
        '
        'lblGuestID
        '
        Me.lblGuestID.AutoSize = True
        Me.lblGuestID.Font = New System.Drawing.Font("Verdana Pro", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuestID.ForeColor = System.Drawing.Color.White
        Me.lblGuestID.Location = New System.Drawing.Point(182, 62)
        Me.lblGuestID.Name = "lblGuestID"
        Me.lblGuestID.Size = New System.Drawing.Size(132, 29)
        Me.lblGuestID.TabIndex = 13
        Me.lblGuestID.Text = "GUEST ID"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana Pro", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(15, 62)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(151, 29)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "GUEST ID:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana Pro", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(417, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(151, 29)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "ROOM NO."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana Pro", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(417, 136)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 29)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "TYPE:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana Pro", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(421, 195)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(107, 29)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "CLASS."
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana Pro", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(679, 588)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(235, 29)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "TOTAL NIGHT/S:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana Pro", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(3, 8)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(145, 40)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "TOTAL:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana Pro", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(761, 136)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(210, 29)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "PRICE/NIGHT:"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Verdana Pro", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.ForeColor = System.Drawing.Color.White
        Me.lblPrice.Location = New System.Drawing.Point(977, 136)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(158, 29)
        Me.lblPrice.TabIndex = 30
        Me.lblPrice.Text = "room Price"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana Pro", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(767, 624)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(147, 29)
        Me.Label18.TabIndex = 31
        Me.Label18.Text = "BALANCE:"
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.Font = New System.Drawing.Font("Verdana Pro", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalance.ForeColor = System.Drawing.Color.White
        Me.lblBalance.Location = New System.Drawing.Point(935, 624)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(118, 29)
        Me.lblBalance.TabIndex = 32
        Me.lblBalance.Text = "Balance"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Crimson
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(766, 785)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(357, 56)
        Me.btnCancel.TabIndex = 33
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnReserve
        '
        Me.btnReserve.BackColor = System.Drawing.Color.Yellow
        Me.btnReserve.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReserve.ForeColor = System.Drawing.Color.Black
        Me.btnReserve.Location = New System.Drawing.Point(336, 785)
        Me.btnReserve.Name = "btnReserve"
        Me.btnReserve.Size = New System.Drawing.Size(155, 56)
        Me.btnReserve.TabIndex = 34
        Me.btnReserve.Text = "RESERVED"
        Me.btnReserve.UseVisualStyleBackColor = False
        Me.btnReserve.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana Pro", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(761, 79)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(191, 29)
        Me.Label20.TabIndex = 35
        Me.Label20.Text = "ROOM NAME:"
        '
        'lblRoomName
        '
        Me.lblRoomName.AutoSize = True
        Me.lblRoomName.Font = New System.Drawing.Font("Verdana Pro", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoomName.ForeColor = System.Drawing.Color.White
        Me.lblRoomName.Location = New System.Drawing.Point(977, 79)
        Me.lblRoomName.Name = "lblRoomName"
        Me.lblRoomName.Size = New System.Drawing.Size(167, 29)
        Me.lblRoomName.TabIndex = 36
        Me.lblRoomName.Text = "room Name"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Turquoise
        Me.Panel2.Controls.Add(Me.lblTotal)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Location = New System.Drawing.Point(684, 664)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(451, 64)
        Me.Panel2.TabIndex = 37
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.nudExtraMat)
        Me.Panel3.Controls.Add(Me.nudDriversRoom)
        Me.Panel3.Controls.Add(Me.CheckBox2)
        Me.Panel3.Controls.Add(Me.CheckBox1)
        Me.Panel3.Controls.Add(Me.lblRoomName)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.lblPrice)
        Me.Panel3.Controls.Add(Me.dtCheckIn)
        Me.Panel3.Controls.Add(Me.dtCheckOut)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.lblRoomNo)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.lblRoomType)
        Me.Panel3.Controls.Add(Me.lblRoomClass)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Location = New System.Drawing.Point(0, 188)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1168, 342)
        Me.Panel3.TabIndex = 38
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana Pro", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(713, 301)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(155, 23)
        Me.Label19.TabIndex = 42
        Me.Label19.Text = "500/quantity"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana Pro", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(225, 301)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(155, 23)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "700/quantity"
        '
        'nudExtraMat
        '
        Me.nudExtraMat.Enabled = False
        Me.nudExtraMat.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudExtraMat.Location = New System.Drawing.Point(548, 294)
        Me.nudExtraMat.Name = "nudExtraMat"
        Me.nudExtraMat.Size = New System.Drawing.Size(159, 34)
        Me.nudExtraMat.TabIndex = 40
        Me.nudExtraMat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'nudDriversRoom
        '
        Me.nudDriversRoom.Enabled = False
        Me.nudDriversRoom.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudDriversRoom.Location = New System.Drawing.Point(60, 294)
        Me.nudDriversRoom.Name = "nudDriversRoom"
        Me.nudDriversRoom.Size = New System.Drawing.Size(159, 34)
        Me.nudDriversRoom.TabIndex = 39
        Me.nudDriversRoom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(524, 255)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(186, 33)
        Me.CheckBox2.TabIndex = 38
        Me.CheckBox2.Text = "Extra Mattress"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(37, 255)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(182, 33)
        Me.CheckBox1.TabIndex = 37
        Me.CheckBox1.Text = "Drivers Room"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'lblBookingID
        '
        Me.lblBookingID.AutoSize = True
        Me.lblBookingID.Font = New System.Drawing.Font("Verdana Pro", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookingID.ForeColor = System.Drawing.Color.White
        Me.lblBookingID.Location = New System.Drawing.Point(216, 617)
        Me.lblBookingID.Name = "lblBookingID"
        Me.lblBookingID.Size = New System.Drawing.Size(137, 29)
        Me.lblBookingID.TabIndex = 15
        Me.lblBookingID.Text = "bookingID"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana Pro", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(17, 617)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(193, 29)
        Me.Label17.TabIndex = 14
        Me.Label17.Text = "BOOKING ID:"
        '
        'btnNoshow
        '
        Me.btnNoshow.BackColor = System.Drawing.Color.DarkGray
        Me.btnNoshow.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNoshow.ForeColor = System.Drawing.Color.Black
        Me.btnNoshow.Location = New System.Drawing.Point(524, 785)
        Me.btnNoshow.Name = "btnNoshow"
        Me.btnNoshow.Size = New System.Drawing.Size(223, 56)
        Me.btnNoshow.TabIndex = 39
        Me.btnNoshow.Text = "NO SHOW"
        Me.btnNoshow.UseVisualStyleBackColor = False
        Me.btnNoshow.Visible = False
        '
        'booking_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(1168, 879)
        Me.Controls.Add(Me.btnNoshow)
        Me.Controls.Add(Me.lblBookingID)
        Me.Controls.Add(Me.btnReserve)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblBalance)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtDownpayment)
        Me.Controls.Add(Me.rbDownPayment)
        Me.Controls.Add(Me.rbFullPayment)
        Me.Controls.Add(Me.lblNights)
        Me.Controls.Add(Me.btnCheckIN)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "booking_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.nudExtraMat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDriversRoom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCheckIN As Button
    Friend WithEvents dtCheckIn As DateTimePicker
    Friend WithEvents dtCheckOut As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtGuestContact As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtGuestAddress As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblRoomNo As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblRoomType As Label
    Friend WithEvents lblRoomClass As Label
    Friend WithEvents lblNights As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents rbFullPayment As RadioButton
    Friend WithEvents rbDownPayment As RadioButton
    Friend WithEvents txtDownpayment As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents lblBalance As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnReserve As Button
    Friend WithEvents Label20 As Label
    Friend WithEvents lblRoomName As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblGuestID As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblBookingID As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents nudExtraMat As NumericUpDown
    Friend WithEvents nudDriversRoom As NumericUpDown
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents cboGuest As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnNew As Button
    Friend WithEvents btnNoshow As Button
End Class
