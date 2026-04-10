<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Addclass = New System.Windows.Forms.Button()
        Me.revClass = New System.Windows.Forms.Button()
        Me.lbclass = New System.Windows.Forms.ListBox()
        Me.txtClassName = New System.Windows.Forms.TextBox()
        Me.picbox = New System.Windows.Forms.PictureBox()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lbfoodCat = New System.Windows.Forms.ListBox()
        Me.revCategory = New System.Windows.Forms.Button()
        Me.addCategory = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabconrol1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        CType(Me.picbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tabconrol1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana Pro Cond", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(380, 59)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "System Settings"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana Pro", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(32, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(291, 34)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Room Classification"
        '
        'Addclass
        '
        Me.Addclass.Location = New System.Drawing.Point(37, 405)
        Me.Addclass.Name = "Addclass"
        Me.Addclass.Size = New System.Drawing.Size(159, 68)
        Me.Addclass.TabIndex = 3
        Me.Addclass.Text = "Add"
        Me.Addclass.UseVisualStyleBackColor = True
        '
        'revClass
        '
        Me.revClass.Location = New System.Drawing.Point(213, 405)
        Me.revClass.Name = "revClass"
        Me.revClass.Size = New System.Drawing.Size(156, 68)
        Me.revClass.TabIndex = 4
        Me.revClass.Text = "Remove"
        Me.revClass.UseVisualStyleBackColor = True
        '
        'lbclass
        '
        Me.lbclass.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbclass.FormattingEnabled = True
        Me.lbclass.ItemHeight = 31
        Me.lbclass.Location = New System.Drawing.Point(38, 95)
        Me.lbclass.Name = "lbclass"
        Me.lbclass.Size = New System.Drawing.Size(320, 252)
        Me.lbclass.TabIndex = 5
        '
        'txtClassName
        '
        Me.txtClassName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClassName.Location = New System.Drawing.Point(38, 353)
        Me.txtClassName.Name = "txtClassName"
        Me.txtClassName.Size = New System.Drawing.Size(320, 34)
        Me.txtClassName.TabIndex = 6
        '
        'picbox
        '
        Me.picbox.Location = New System.Drawing.Point(400, 91)
        Me.picbox.Name = "picbox"
        Me.picbox.Size = New System.Drawing.Size(387, 252)
        Me.picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picbox.TabIndex = 7
        Me.picbox.TabStop = False
        '
        'ofd
        '
        Me.ofd.FileName = "OpenFileDialog1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana Pro", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(394, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 34)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Background" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(531, 363)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(137, 29)
        Me.LinkLabel1.TabIndex = 9
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Change Pic"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(461, 353)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(320, 34)
        Me.TextBox1.TabIndex = 14
        '
        'lbfoodCat
        '
        Me.lbfoodCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbfoodCat.FormattingEnabled = True
        Me.lbfoodCat.ItemHeight = 31
        Me.lbfoodCat.Location = New System.Drawing.Point(461, 95)
        Me.lbfoodCat.Name = "lbfoodCat"
        Me.lbfoodCat.Size = New System.Drawing.Size(320, 252)
        Me.lbfoodCat.TabIndex = 13
        '
        'revCategory
        '
        Me.revCategory.Location = New System.Drawing.Point(625, 405)
        Me.revCategory.Name = "revCategory"
        Me.revCategory.Size = New System.Drawing.Size(156, 68)
        Me.revCategory.TabIndex = 12
        Me.revCategory.Text = "Remove"
        Me.revCategory.UseVisualStyleBackColor = True
        '
        'addCategory
        '
        Me.addCategory.Location = New System.Drawing.Point(460, 405)
        Me.addCategory.Name = "addCategory"
        Me.addCategory.Size = New System.Drawing.Size(159, 68)
        Me.addCategory.TabIndex = 11
        Me.addCategory.Text = "Add"
        Me.addCategory.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana Pro", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(455, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(242, 34)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Food Categories"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabconrol1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(20, 72)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1272, 693)
        Me.TabControl1.TabIndex = 15
        '
        'tabconrol1
        '
        Me.tabconrol1.BackColor = System.Drawing.Color.DarkCyan
        Me.tabconrol1.Controls.Add(Me.Label4)
        Me.tabconrol1.Controls.Add(Me.lbfoodCat)
        Me.tabconrol1.Controls.Add(Me.TextBox1)
        Me.tabconrol1.Controls.Add(Me.revClass)
        Me.tabconrol1.Controls.Add(Me.Addclass)
        Me.tabconrol1.Controls.Add(Me.revCategory)
        Me.tabconrol1.Controls.Add(Me.txtClassName)
        Me.tabconrol1.Controls.Add(Me.addCategory)
        Me.tabconrol1.Controls.Add(Me.lbclass)
        Me.tabconrol1.Controls.Add(Me.Label2)
        Me.tabconrol1.Location = New System.Drawing.Point(4, 27)
        Me.tabconrol1.Name = "tabconrol1"
        Me.tabconrol1.Padding = New System.Windows.Forms.Padding(3)
        Me.tabconrol1.Size = New System.Drawing.Size(1264, 662)
        Me.tabconrol1.TabIndex = 0
        Me.tabconrol1.Text = "Categories"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.DarkCyan
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.LinkLabel1)
        Me.TabPage2.Controls.Add(Me.picbox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1264, 662)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Preferences"
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1304, 777)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.picbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tabconrol1.ResumeLayout(False)
        Me.tabconrol1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Addclass As Button
    Friend WithEvents revClass As Button
    Friend WithEvents lbclass As ListBox
    Friend WithEvents txtClassName As TextBox
    Friend WithEvents picbox As PictureBox
    Friend WithEvents ofd As OpenFileDialog
    Friend WithEvents Label3 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lbfoodCat As ListBox
    Friend WithEvents revCategory As Button
    Friend WithEvents addCategory As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabconrol1 As TabPage
    Friend WithEvents TabPage2 As TabPage
End Class
