<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main_form
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnCashier = New System.Windows.Forms.Button()
        Me.btnrooms = New System.Windows.Forms.Button()
        Me.btnStock = New System.Windows.Forms.Button()
        Me.btnuser = New System.Windows.Forms.Button()
        Me.btnfrontdesk = New System.Windows.Forms.Button()
        Me.btnreports = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnCashier, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnrooms, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnStock, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnuser, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnfrontdesk, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnreports, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Button2, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button3, 2, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(36, 52)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1853, 1054)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btnCashier
        '
        Me.btnCashier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCashier.Enabled = False
        Me.btnCashier.Font = New System.Drawing.Font("Verdana Pro Black", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCashier.Image = Global.resort_management.My.Resources.Resources.point_of_sale_200dp_000000_FILL0_wght400_GRAD0_opsz48
        Me.btnCashier.Location = New System.Drawing.Point(10, 537)
        Me.btnCashier.Margin = New System.Windows.Forms.Padding(10)
        Me.btnCashier.Name = "btnCashier"
        Me.btnCashier.Padding = New System.Windows.Forms.Padding(20)
        Me.btnCashier.Size = New System.Drawing.Size(443, 507)
        Me.btnCashier.TabIndex = 5
        Me.btnCashier.Text = "AMMENITIES"
        Me.btnCashier.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCashier.UseVisualStyleBackColor = True
        '
        'btnrooms
        '
        Me.btnrooms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnrooms.Font = New System.Drawing.Font("Verdana Pro Black", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrooms.Image = Global.resort_management.My.Resources.Resources.bedroom_parent_200dp_000000_FILL1_wght400_GRAD0_opsz48
        Me.btnrooms.Location = New System.Drawing.Point(473, 10)
        Me.btnrooms.Margin = New System.Windows.Forms.Padding(10)
        Me.btnrooms.Name = "btnrooms"
        Me.btnrooms.Padding = New System.Windows.Forms.Padding(20)
        Me.btnrooms.Size = New System.Drawing.Size(443, 507)
        Me.btnrooms.TabIndex = 0
        Me.btnrooms.Text = "ROOMS"
        Me.btnrooms.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnrooms.UseVisualStyleBackColor = True
        '
        'btnStock
        '
        Me.btnStock.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnStock.Font = New System.Drawing.Font("Verdana Pro Black", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStock.Image = Global.resort_management.My.Resources.Resources.inventory_200dp_000000_FILL1_wght400_GRAD0_opsz48
        Me.btnStock.Location = New System.Drawing.Point(473, 537)
        Me.btnStock.Margin = New System.Windows.Forms.Padding(10)
        Me.btnStock.Name = "btnStock"
        Me.btnStock.Padding = New System.Windows.Forms.Padding(20)
        Me.btnStock.Size = New System.Drawing.Size(443, 507)
        Me.btnStock.TabIndex = 2
        Me.btnStock.Text = "INVENTORY"
        Me.btnStock.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnStock.UseVisualStyleBackColor = True
        '
        'btnuser
        '
        Me.btnuser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnuser.Font = New System.Drawing.Font("Verdana Pro Black", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnuser.Image = Global.resort_management.My.Resources.Resources.account_box_200dp_000000_FILL1_wght400_GRAD0_opsz48
        Me.btnuser.Location = New System.Drawing.Point(10, 10)
        Me.btnuser.Margin = New System.Windows.Forms.Padding(10)
        Me.btnuser.Name = "btnuser"
        Me.btnuser.Padding = New System.Windows.Forms.Padding(20)
        Me.btnuser.Size = New System.Drawing.Size(443, 507)
        Me.btnuser.TabIndex = 4
        Me.btnuser.Text = "USERS"
        Me.btnuser.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnuser.UseVisualStyleBackColor = True
        '
        'btnfrontdesk
        '
        Me.btnfrontdesk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnfrontdesk.Font = New System.Drawing.Font("Verdana Pro Black", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfrontdesk.Image = Global.resort_management.My.Resources.Resources.concierge_200dp_000000_FILL1_wght400_GRAD0_opsz48
        Me.btnfrontdesk.Location = New System.Drawing.Point(1399, 10)
        Me.btnfrontdesk.Margin = New System.Windows.Forms.Padding(10)
        Me.btnfrontdesk.Name = "btnfrontdesk"
        Me.btnfrontdesk.Padding = New System.Windows.Forms.Padding(20)
        Me.btnfrontdesk.Size = New System.Drawing.Size(444, 507)
        Me.btnfrontdesk.TabIndex = 1
        Me.btnfrontdesk.Text = "FRONT DESK"
        Me.btnfrontdesk.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnfrontdesk.UseVisualStyleBackColor = True
        '
        'btnreports
        '
        Me.btnreports.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnreports.Font = New System.Drawing.Font("Verdana Pro Black", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreports.Image = Global.resort_management.My.Resources.Resources.bar_chart_200dp_000000_FILL1_wght400_GRAD0_opsz48
        Me.btnreports.Location = New System.Drawing.Point(1399, 537)
        Me.btnreports.Margin = New System.Windows.Forms.Padding(10)
        Me.btnreports.Name = "btnreports"
        Me.btnreports.Padding = New System.Windows.Forms.Padding(20)
        Me.btnreports.Size = New System.Drawing.Size(444, 507)
        Me.btnreports.TabIndex = 3
        Me.btnreports.Text = "REPORTS"
        Me.btnreports.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnreports.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button2.Font = New System.Drawing.Font("Verdana Pro Black", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.resort_management.My.Resources.Resources.event_upcoming_200dp_000000_FILL1_wght400_GRAD0_opsz48
        Me.Button2.Location = New System.Drawing.Point(936, 10)
        Me.Button2.Margin = New System.Windows.Forms.Padding(10)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(20)
        Me.Button2.Size = New System.Drawing.Size(443, 507)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "RESERVATION"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button3.Font = New System.Drawing.Font("Verdana Pro Black", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.resort_management.My.Resources.Resources.receipt_200dp_000000_FILL1_wght400_GRAD0_opsz48
        Me.Button3.Location = New System.Drawing.Point(936, 537)
        Me.Button3.Margin = New System.Windows.Forms.Padding(10)
        Me.Button3.Name = "Button3"
        Me.Button3.Padding = New System.Windows.Forms.Padding(20)
        Me.Button3.Size = New System.Drawing.Size(443, 507)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "BILLING"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.LightCoral
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(36, 12)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(144, 37)
        Me.Button5.TabIndex = 1
        Me.Button5.Text = "Back"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1795, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 37)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "SETTINGS"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'main_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1924, 1153)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "main_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnreports As Button
    Friend WithEvents btnStock As Button
    Friend WithEvents btnfrontdesk As Button
    Friend WithEvents btnrooms As Button
    Friend WithEvents btnuser As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnCashier As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
