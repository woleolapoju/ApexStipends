<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCoyInfo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCoyInfo))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tAddress = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tPhone = New System.Windows.Forms.TextBox()
        Me.CMLogo = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.InsertLogoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClearLogoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdGetLogo = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.OwnerLogo = New System.Windows.Forms.PictureBox()
        Me.tblHeader = New System.Windows.Forms.TableLayoutPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.CMLogo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.OwnerLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tblHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Name:"
        '
        'tName
        '
        Me.tName.AcceptsReturn = True
        Me.tName.Enabled = False
        Me.tName.Location = New System.Drawing.Point(104, 53)
        Me.tName.Multiline = True
        Me.tName.Name = "tName"
        Me.tName.Size = New System.Drawing.Size(226, 40)
        Me.tName.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Address:"
        '
        'tAddress
        '
        Me.tAddress.Location = New System.Drawing.Point(104, 95)
        Me.tAddress.Multiline = True
        Me.tAddress.Name = "tAddress"
        Me.tAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tAddress.Size = New System.Drawing.Size(226, 47)
        Me.tAddress.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Phone:"
        '
        'tPhone
        '
        Me.tPhone.Location = New System.Drawing.Point(104, 144)
        Me.tPhone.Name = "tPhone"
        Me.tPhone.Size = New System.Drawing.Size(226, 20)
        Me.tPhone.TabIndex = 11
        '
        'CMLogo
        '
        Me.CMLogo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertLogoToolStripMenuItem, Me.ToolStripMenuItem1, Me.ClearLogoToolStripMenuItem})
        Me.CMLogo.Name = "CMLogo"
        Me.CMLogo.Size = New System.Drawing.Size(134, 54)
        '
        'InsertLogoToolStripMenuItem
        '
        Me.InsertLogoToolStripMenuItem.Name = "InsertLogoToolStripMenuItem"
        Me.InsertLogoToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.InsertLogoToolStripMenuItem.Text = "Insert Logo"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(130, 6)
        '
        'ClearLogoToolStripMenuItem
        '
        Me.ClearLogoToolStripMenuItem.Name = "ClearLogoToolStripMenuItem"
        Me.ClearLogoToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.ClearLogoToolStripMenuItem.Text = "Clear Logo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 177)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Logo"
        '
        'cmdGetLogo
        '
        Me.cmdGetLogo.Location = New System.Drawing.Point(48, 174)
        Me.cmdGetLogo.Name = "cmdGetLogo"
        Me.cmdGetLogo.Size = New System.Drawing.Size(30, 24)
        Me.cmdGetLogo.TabIndex = 18
        Me.cmdGetLogo.Text = "..."
        Me.cmdGetLogo.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.OwnerLogo)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(103, 165)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(147, 191)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        '
        'OwnerLogo
        '
        Me.OwnerLogo.AccessibleDescription = ""
        Me.OwnerLogo.ContextMenuStrip = Me.CMLogo
        Me.OwnerLogo.Location = New System.Drawing.Point(2, 8)
        Me.OwnerLogo.Name = "OwnerLogo"
        Me.OwnerLogo.Size = New System.Drawing.Size(143, 180)
        Me.OwnerLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.OwnerLogo.TabIndex = 17
        Me.OwnerLogo.TabStop = False
        '
        'tblHeader
        '
        Me.tblHeader.BackColor = System.Drawing.Color.MintCream
        Me.tblHeader.ColumnCount = 1
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblHeader.Controls.Add(Me.Label7, 0, 0)
        Me.tblHeader.Controls.Add(Me.Label8, 0, 1)
        Me.tblHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.tblHeader.Location = New System.Drawing.Point(0, 0)
        Me.tblHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.tblHeader.Name = "tblHeader"
        Me.tblHeader.RowCount = 2
        Me.tblHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.76923!))
        Me.tblHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.23077!))
        Me.tblHeader.Size = New System.Drawing.Size(346, 50)
        Me.tblHeader.TabIndex = 49
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Goldenrod
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(346, 27)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "EDIT COMPANY INFORMATION"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.GhostWhite
        Me.Label8.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Goldenrod
        Me.Label8.Location = New System.Drawing.Point(0, 27)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(346, 23)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Change user organisation information"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(103, 361)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(74, 34)
        Me.cmdOk.TabIndex = 50
        Me.cmdOk.Text = "&Ok"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(177, 361)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(74, 34)
        Me.cmdClose.TabIndex = 51
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'FrmCoyInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(346, 397)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.tblHeader)
        Me.Controls.Add(Me.cmdGetLogo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tPhone)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tAddress)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tName)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCoyInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Company Information"
        Me.CMLogo.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.OwnerLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tblHeader.ResumeLayout(False)
        Me.tblHeader.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdGetLogo As System.Windows.Forms.Button
    Friend WithEvents CMLogo As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents InsertLogoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ClearLogoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents OwnerLogo As System.Windows.Forms.PictureBox
    Friend WithEvents tblHeader As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
End Class
