<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class payment_Type
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
        Me.btnPayNow = New System.Windows.Forms.Button()
        Me.btnCharge = New System.Windows.Forms.Button()
        Me.dgvGuest = New System.Windows.Forms.DataGridView()
        CType(Me.dgvGuest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPayNow
        '
        Me.btnPayNow.BackColor = System.Drawing.Color.Gold
        Me.btnPayNow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayNow.Location = New System.Drawing.Point(32, 655)
        Me.btnPayNow.Name = "btnPayNow"
        Me.btnPayNow.Size = New System.Drawing.Size(432, 91)
        Me.btnPayNow.TabIndex = 0
        Me.btnPayNow.Text = "Pay Now"
        Me.btnPayNow.UseVisualStyleBackColor = False
        '
        'btnCharge
        '
        Me.btnCharge.BackColor = System.Drawing.Color.Crimson
        Me.btnCharge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCharge.ForeColor = System.Drawing.Color.White
        Me.btnCharge.Location = New System.Drawing.Point(691, 655)
        Me.btnCharge.Name = "btnCharge"
        Me.btnCharge.Size = New System.Drawing.Size(450, 91)
        Me.btnCharge.TabIndex = 1
        Me.btnCharge.Text = "Charge to Room"
        Me.btnCharge.UseVisualStyleBackColor = False
        '
        'dgvGuest
        '
        Me.dgvGuest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvGuest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGuest.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvGuest.Location = New System.Drawing.Point(32, 46)
        Me.dgvGuest.Name = "dgvGuest"
        Me.dgvGuest.ReadOnly = True
        Me.dgvGuest.RowHeadersVisible = False
        Me.dgvGuest.RowTemplate.Height = 24
        Me.dgvGuest.Size = New System.Drawing.Size(1109, 555)
        Me.dgvGuest.TabIndex = 2
        '
        'payment_Type
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.ClientSize = New System.Drawing.Size(1175, 789)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgvGuest)
        Me.Controls.Add(Me.btnCharge)
        Me.Controls.Add(Me.btnPayNow)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "payment_Type"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgvGuest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPayNow As Button
    Friend WithEvents btnCharge As Button
    Friend WithEvents dgvGuest As DataGridView
End Class
