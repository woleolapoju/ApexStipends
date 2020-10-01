<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.GeneralSetupsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPaymentDetails = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CompanyInformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SystemUsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDeleteUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuBackupDB = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.LogOffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RadRegister = New System.Windows.Forms.RadioButton()
        Me.RadGenerate = New System.Windows.Forms.RadioButton()
        Me.RadStipends = New System.Windows.Forms.RadioButton()
        Me.RadNewDB = New System.Windows.Forms.RadioButton()
        Me.RadRevert = New System.Windows.Forms.RadioButton()
        Me.RadImport = New System.Windows.Forms.RadioButton()
        Me.RadMandate = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadReport = New System.Windows.Forms.RadioButton()
        Me.OwnerLogo = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblOwner = New System.Windows.Forms.Label()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.lnkPayDetails = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lnkBankCode = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lnkNewUser = New System.Windows.Forms.LinkLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lnkDeleteUser = New System.Windows.Forms.LinkLabel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lnkChangePwd = New System.Windows.Forms.LinkLabel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lnkCoyInfor = New System.Windows.Forms.LinkLabel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblPhase = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        CType(Me.OwnerLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackgroundImage = Global.ApexStipends.My.Resources.Resources.BackGrdImage3
        Me.TableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.OwnerLogo, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblPhase, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 108.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1126, 541)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableLayoutPanel2.ColumnCount = 10
        Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel2, 2)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.MenuStrip, 8, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.RadRegister, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.RadGenerate, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.RadStipends, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.RadNewDB, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.RadRevert, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.RadImport, 6, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.RadMandate, 5, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.RadioButton2, 9, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.RadReport, 7, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(982, 73)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'MenuStrip
        '
        Me.MenuStrip.AllowMerge = False
        Me.MenuStrip.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuStrip.AutoSize = False
        Me.MenuStrip.BackColor = System.Drawing.Color.SteelBlue
        Me.MenuStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GeneralSetupsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(672, 48)
        Me.MenuStrip.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(110, 25)
        Me.MenuStrip.TabIndex = 27
        Me.MenuStrip.Text = "MenuStrip"
        Me.MenuStrip.Visible = False
        '
        'GeneralSetupsToolStripMenuItem
        '
        Me.GeneralSetupsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPaymentDetails, Me.ToolStripMenuItem3, Me.CompanyInformationToolStripMenuItem, Me.SystemUsersToolStripMenuItem, Me.mnuDeleteUser, Me.ChangePasswordToolStripMenuItem, Me.ToolStripMenuItem2, Me.mnuBackupDB})
        Me.GeneralSetupsToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GeneralSetupsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.GeneralSetupsToolStripMenuItem.Name = "GeneralSetupsToolStripMenuItem"
        Me.GeneralSetupsToolStripMenuItem.Size = New System.Drawing.Size(59, 21)
        Me.GeneralSetupsToolStripMenuItem.Text = "&Admin"
        '
        'mnuPaymentDetails
        '
        Me.mnuPaymentDetails.Name = "mnuPaymentDetails"
        Me.mnuPaymentDetails.Size = New System.Drawing.Size(178, 22)
        Me.mnuPaymentDetails.Text = "Payment Details"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(175, 6)
        '
        'CompanyInformationToolStripMenuItem
        '
        Me.CompanyInformationToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.CompanyInformationToolStripMenuItem.Name = "CompanyInformationToolStripMenuItem"
        Me.CompanyInformationToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.CompanyInformationToolStripMenuItem.Text = "Company Information"
        '
        'SystemUsersToolStripMenuItem
        '
        Me.SystemUsersToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.SystemUsersToolStripMenuItem.Name = "SystemUsersToolStripMenuItem"
        Me.SystemUsersToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.SystemUsersToolStripMenuItem.Text = "New User"
        '
        'mnuDeleteUser
        '
        Me.mnuDeleteUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.mnuDeleteUser.Name = "mnuDeleteUser"
        Me.mnuDeleteUser.Size = New System.Drawing.Size(178, 22)
        Me.mnuDeleteUser.Text = "Delete User"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(175, 6)
        '
        'mnuBackupDB
        '
        Me.mnuBackupDB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.mnuBackupDB.Name = "mnuBackupDB"
        Me.mnuBackupDB.Size = New System.Drawing.Size(178, 22)
        Me.mnuBackupDB.Text = "Backup DB"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem1, Me.ToolStripMenuItem1, Me.LogOffToolStripMenuItem})
        Me.ExitToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ExitToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(43, 21)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(107, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(104, 6)
        '
        'LogOffToolStripMenuItem
        '
        Me.LogOffToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.LogOffToolStripMenuItem.Name = "LogOffToolStripMenuItem"
        Me.LogOffToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.LogOffToolStripMenuItem.Text = "Log off"
        '
        'RadRegister
        '
        Me.RadRegister.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadRegister.BackColor = System.Drawing.Color.DarkOrange
        Me.RadRegister.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadRegister.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.RadRegister.ForeColor = System.Drawing.Color.White
        Me.RadRegister.ImageKey = "(none)"
        Me.RadRegister.Location = New System.Drawing.Point(6, 1)
        Me.RadRegister.Margin = New System.Windows.Forms.Padding(6, 1, 6, 3)
        Me.RadRegister.Name = "RadRegister"
        Me.RadRegister.Size = New System.Drawing.Size(95, 69)
        Me.RadRegister.TabIndex = 6
        Me.RadRegister.Text = "REGISTER"
        Me.RadRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadRegister.UseVisualStyleBackColor = False
        '
        'RadGenerate
        '
        Me.RadGenerate.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadGenerate.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.RadGenerate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadGenerate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadGenerate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.RadGenerate.ForeColor = System.Drawing.Color.White
        Me.RadGenerate.ImageKey = "(none)"
        Me.RadGenerate.Location = New System.Drawing.Point(113, 1)
        Me.RadGenerate.Margin = New System.Windows.Forms.Padding(6, 1, 6, 3)
        Me.RadGenerate.Name = "RadGenerate"
        Me.RadGenerate.Size = New System.Drawing.Size(95, 69)
        Me.RadGenerate.TabIndex = 29
        Me.RadGenerate.Text = "COMPUTE STIPENDS"
        Me.RadGenerate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadGenerate.UseVisualStyleBackColor = False
        '
        'RadStipends
        '
        Me.RadStipends.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadStipends.BackColor = System.Drawing.Color.SlateBlue
        Me.RadStipends.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadStipends.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadStipends.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadStipends.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RadStipends.ForeColor = System.Drawing.Color.White
        Me.RadStipends.ImageKey = "(none)"
        Me.RadStipends.Location = New System.Drawing.Point(327, 1)
        Me.RadStipends.Margin = New System.Windows.Forms.Padding(6, 1, 6, 3)
        Me.RadStipends.Name = "RadStipends"
        Me.RadStipends.Size = New System.Drawing.Size(95, 69)
        Me.RadStipends.TabIndex = 28
        Me.RadStipends.Text = "STIPENDS ANALYSIS"
        Me.RadStipends.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadStipends.UseVisualStyleBackColor = False
        '
        'RadNewDB
        '
        Me.RadNewDB.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadNewDB.BackColor = System.Drawing.Color.Khaki
        Me.RadNewDB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadNewDB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadNewDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadNewDB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RadNewDB.ForeColor = System.Drawing.Color.White
        Me.RadNewDB.ImageKey = "(none)"
        Me.RadNewDB.Location = New System.Drawing.Point(434, 1)
        Me.RadNewDB.Margin = New System.Windows.Forms.Padding(6, 1, 6, 3)
        Me.RadNewDB.Name = "RadNewDB"
        Me.RadNewDB.Size = New System.Drawing.Size(95, 69)
        Me.RadNewDB.TabIndex = 32
        Me.RadNewDB.Text = "INITIALIZE NEW DB"
        Me.RadNewDB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadNewDB.UseVisualStyleBackColor = False
        '
        'RadRevert
        '
        Me.RadRevert.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadRevert.BackColor = System.Drawing.Color.CadetBlue
        Me.RadRevert.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadRevert.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadRevert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadRevert.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.RadRevert.ForeColor = System.Drawing.Color.White
        Me.RadRevert.ImageKey = "(none)"
        Me.RadRevert.Location = New System.Drawing.Point(220, 1)
        Me.RadRevert.Margin = New System.Windows.Forms.Padding(6, 1, 6, 3)
        Me.RadRevert.Name = "RadRevert"
        Me.RadRevert.Size = New System.Drawing.Size(95, 69)
        Me.RadRevert.TabIndex = 31
        Me.RadRevert.Text = "REVERSE STIPENDS"
        Me.RadRevert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadRevert.UseVisualStyleBackColor = False
        '
        'RadImport
        '
        Me.RadImport.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadImport.BackColor = System.Drawing.Color.Red
        Me.RadImport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadImport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadImport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RadImport.ForeColor = System.Drawing.Color.White
        Me.RadImport.ImageKey = "(none)"
        Me.RadImport.Location = New System.Drawing.Point(652, 1)
        Me.RadImport.Margin = New System.Windows.Forms.Padding(6, 1, 6, 4)
        Me.RadImport.Name = "RadImport"
        Me.RadImport.Size = New System.Drawing.Size(95, 68)
        Me.RadImport.TabIndex = 34
        Me.RadImport.Text = "IMPORT DATA"
        Me.RadImport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadImport.UseVisualStyleBackColor = False
        '
        'RadMandate
        '
        Me.RadMandate.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadMandate.BackColor = System.Drawing.Color.SteelBlue
        Me.RadMandate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadMandate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadMandate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadMandate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RadMandate.ForeColor = System.Drawing.Color.White
        Me.RadMandate.ImageKey = "(none)"
        Me.RadMandate.Location = New System.Drawing.Point(541, 1)
        Me.RadMandate.Margin = New System.Windows.Forms.Padding(6, 1, 6, 4)
        Me.RadMandate.Name = "RadMandate"
        Me.RadMandate.Size = New System.Drawing.Size(99, 68)
        Me.RadMandate.TabIndex = 33
        Me.RadMandate.Text = "E-MANDATE"
        Me.RadMandate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadMandate.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.RadioButton2.ForeColor = System.Drawing.Color.Black
        Me.RadioButton2.ImageKey = "(none)"
        Me.RadioButton2.Location = New System.Drawing.Point(866, 1)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(6, 1, 6, 3)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(46, 69)
        Me.RadioButton2.TabIndex = 30
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "REGISTER"
        Me.RadioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton2.UseVisualStyleBackColor = True
        Me.RadioButton2.Visible = False
        '
        'RadReport
        '
        Me.RadReport.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadReport.BackColor = System.Drawing.Color.RosyBrown
        Me.RadReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.RadReport.ForeColor = System.Drawing.Color.White
        Me.RadReport.ImageKey = "(none)"
        Me.RadReport.Location = New System.Drawing.Point(759, 1)
        Me.RadReport.Margin = New System.Windows.Forms.Padding(6, 1, 6, 4)
        Me.RadReport.Name = "RadReport"
        Me.RadReport.Size = New System.Drawing.Size(95, 68)
        Me.RadReport.TabIndex = 7
        Me.RadReport.Text = "REPORTS"
        Me.RadReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadReport.UseVisualStyleBackColor = False
        '
        'OwnerLogo
        '
        Me.OwnerLogo.AccessibleDescription = ""
        Me.OwnerLogo.BackColor = System.Drawing.Color.Transparent
        Me.OwnerLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OwnerLogo.Location = New System.Drawing.Point(3, 436)
        Me.OwnerLogo.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
        Me.OwnerLogo.Name = "OwnerLogo"
        Me.OwnerLogo.Size = New System.Drawing.Size(105, 104)
        Me.OwnerLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.OwnerLogo.TabIndex = 9
        Me.OwnerLogo.TabStop = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel3, 2)
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.lblOwner, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 0, 2)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(114, 436)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 4
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(871, 102)
        Me.TableLayoutPanel3.TabIndex = 10
        '
        'lblOwner
        '
        Me.lblOwner.AutoEllipsis = True
        Me.lblOwner.BackColor = System.Drawing.Color.Transparent
        Me.lblOwner.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblOwner.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOwner.ForeColor = System.Drawing.Color.White
        Me.lblOwner.Location = New System.Drawing.Point(3, 0)
        Me.lblOwner.Name = "lblOwner"
        Me.lblOwner.Size = New System.Drawing.Size(865, 47)
        Me.lblOwner.TabIndex = 8
        Me.lblOwner.Text = "Megahit Systems"
        Me.lblOwner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblOwner.UseMnemonic = False
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 15
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.lnkPayDetails, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label1, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label2, 3, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lnkBankCode, 4, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label3, 5, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lnkNewUser, 6, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label4, 7, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lnkDeleteUser, 8, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label5, 9, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lnkChangePwd, 10, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label6, 11, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lnkCoyInfor, 12, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label7, 13, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 60)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(865, 15)
        Me.TableLayoutPanel4.TabIndex = 9
        '
        'lnkPayDetails
        '
        Me.lnkPayDetails.ActiveLinkColor = System.Drawing.Color.Yellow
        Me.lnkPayDetails.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lnkPayDetails.AutoSize = True
        Me.lnkPayDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkPayDetails.LinkColor = System.Drawing.Color.Yellow
        Me.lnkPayDetails.Location = New System.Drawing.Point(126, 1)
        Me.lnkPayDetails.Name = "lnkPayDetails"
        Me.lnkPayDetails.Size = New System.Drawing.Size(122, 13)
        Me.lnkPayDetails.TabIndex = 0
        Me.lnkPayDetails.TabStop = True
        Me.lnkPayDetails.Text = "PAYMENT DETAILS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(111, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(9, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "|"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(254, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "|"
        '
        'lnkBankCode
        '
        Me.lnkBankCode.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lnkBankCode.AutoSize = True
        Me.lnkBankCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkBankCode.LinkColor = System.Drawing.Color.Yellow
        Me.lnkBankCode.Location = New System.Drawing.Point(270, 1)
        Me.lnkBankCode.Name = "lnkBankCode"
        Me.lnkBankCode.Size = New System.Drawing.Size(86, 13)
        Me.lnkBankCode.TabIndex = 3
        Me.lnkBankCode.TabStop = True
        Me.lnkBankCode.Text = "BANK CODES"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(362, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(10, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "|"
        '
        'lnkNewUser
        '
        Me.lnkNewUser.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lnkNewUser.AutoSize = True
        Me.lnkNewUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkNewUser.LinkColor = System.Drawing.Color.Yellow
        Me.lnkNewUser.Location = New System.Drawing.Point(378, 1)
        Me.lnkNewUser.Name = "lnkNewUser"
        Me.lnkNewUser.Size = New System.Drawing.Size(62, 13)
        Me.lnkNewUser.TabIndex = 5
        Me.lnkNewUser.TabStop = True
        Me.lnkNewUser.Text = "New User"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(446, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "|"
        '
        'lnkDeleteUser
        '
        Me.lnkDeleteUser.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lnkDeleteUser.AutoSize = True
        Me.lnkDeleteUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkDeleteUser.LinkColor = System.Drawing.Color.Yellow
        Me.lnkDeleteUser.Location = New System.Drawing.Point(462, 1)
        Me.lnkDeleteUser.Name = "lnkDeleteUser"
        Me.lnkDeleteUser.Size = New System.Drawing.Size(74, 13)
        Me.lnkDeleteUser.TabIndex = 7
        Me.lnkDeleteUser.TabStop = True
        Me.lnkDeleteUser.Text = "Delete User"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(542, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(10, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "|"
        '
        'lnkChangePwd
        '
        Me.lnkChangePwd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lnkChangePwd.AutoSize = True
        Me.lnkChangePwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkChangePwd.LinkColor = System.Drawing.Color.Yellow
        Me.lnkChangePwd.Location = New System.Drawing.Point(558, 1)
        Me.lnkChangePwd.Name = "lnkChangePwd"
        Me.lnkChangePwd.Size = New System.Drawing.Size(108, 13)
        Me.lnkChangePwd.TabIndex = 9
        Me.lnkChangePwd.TabStop = True
        Me.lnkChangePwd.Text = "Change Password"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(672, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(10, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "|"
        '
        'lnkCoyInfor
        '
        Me.lnkCoyInfor.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lnkCoyInfor.AutoSize = True
        Me.lnkCoyInfor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkCoyInfor.LinkColor = System.Drawing.Color.Yellow
        Me.lnkCoyInfor.Location = New System.Drawing.Point(688, 1)
        Me.lnkCoyInfor.Name = "lnkCoyInfor"
        Me.lnkCoyInfor.Size = New System.Drawing.Size(50, 13)
        Me.lnkCoyInfor.TabIndex = 11
        Me.lnkCoyInfor.TabStop = True
        Me.lnkCoyInfor.Text = "Backup"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(744, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "|"
        '
        'Label8
        '
        Me.Label8.AutoEllipsis = True
        Me.Label8.BackColor = System.Drawing.Color.SteelBlue
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(991, 3)
        Me.Label8.Margin = New System.Windows.Forms.Padding(3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 73)
        Me.Label8.TabIndex = 11
        Me.Label8.Tag = ""
        Me.Label8.Text = "Designed and Developed by Megahit Systems 0803-311-6212"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPhase
        '
        Me.lblPhase.BackColor = System.Drawing.Color.Transparent
        Me.lblPhase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPhase.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPhase.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPhase.ForeColor = System.Drawing.Color.Yellow
        Me.lblPhase.Location = New System.Drawing.Point(991, 436)
        Me.lblPhase.Margin = New System.Windows.Forms.Padding(3)
        Me.lblPhase.Name = "lblPhase"
        Me.lblPhase.Size = New System.Drawing.Size(132, 102)
        Me.lblPhase.TabIndex = 25
        Me.lblPhase.Text = "????"
        Me.lblPhase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.GroupBox1, 4)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(3, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1120, 2)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1126, 541)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMain1"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        CType(Me.OwnerLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents GeneralSetupsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPaymentDetails As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CompanyInformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SystemUsersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDeleteUser As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuBackupDB As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LogOffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadReport As System.Windows.Forms.RadioButton
    Friend WithEvents RadStipends As System.Windows.Forms.RadioButton
    Friend WithEvents RadRegister As System.Windows.Forms.RadioButton
    Friend WithEvents RadRevert As System.Windows.Forms.RadioButton
    Friend WithEvents RadGenerate As System.Windows.Forms.RadioButton
    Friend WithEvents OwnerLogo As System.Windows.Forms.PictureBox
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblOwner As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lnkPayDetails As System.Windows.Forms.LinkLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lnkBankCode As System.Windows.Forms.LinkLabel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lnkNewUser As System.Windows.Forms.LinkLabel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lnkDeleteUser As System.Windows.Forms.LinkLabel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lnkChangePwd As System.Windows.Forms.LinkLabel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lnkCoyInfor As System.Windows.Forms.LinkLabel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblPhase As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents RadNewDB As System.Windows.Forms.RadioButton
    Friend WithEvents RadMandate As System.Windows.Forms.RadioButton
    Friend WithEvents RadImport As System.Windows.Forms.RadioButton
End Class
