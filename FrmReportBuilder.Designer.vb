<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReportBuilder
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReportBuilder))
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.grpDataManipulate = New System.Windows.Forms.Panel()
        Me.lblPageNums = New System.Windows.Forms.Label()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.grpSqlServers = New System.Windows.Forms.GroupBox()
        Me.lblTotRecords = New System.Windows.Forms.Label()
        Me.GrpAuthenticate = New System.Windows.Forms.GroupBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.chkWinAuthen = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.prgProgress = New System.Windows.Forms.ProgressBar()
        Me.cmbTables = New System.Windows.Forms.ComboBox()
        Me.btnGetAllTables = New System.Windows.Forms.Button()
        Me.cmbAllDataBases = New System.Windows.Forms.ComboBox()
        Me.btnGetAllDataBases = New System.Windows.Forms.Button()
        Me.btnNoOfPages = New System.Windows.Forms.Button()
        Me.btnLoadSqlServers = New System.Windows.Forms.Button()
        Me.cmbNoOfRecords = New System.Windows.Forms.ComboBox()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.lblNoOfPages = New System.Windows.Forms.Label()
        Me.cmbSqlServers = New System.Windows.Forms.ComboBox()
        Me.panel3 = New System.Windows.Forms.Panel()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.userDataGridView = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdQuery = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdLoad = New System.Windows.Forms.Button()
        Me.cmdInsert = New System.Windows.Forms.Button()
        Me.cmdOR = New System.Windows.Forms.Button()
        Me.cmdAND = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboSortBy = New System.Windows.Forms.ComboBox()
        Me.chkSortOrder = New System.Windows.Forms.CheckBox()
        Me.chkLoadPeriod = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboValue = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboCondition = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboDataField = New System.Windows.Forms.ComboBox()
        Me.tQuery = New System.Windows.Forms.TextBox()
        Me.notifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ContextExport = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuExportToExcel = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuCopyToClipboard = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtCondition = New System.Windows.Forms.TextBox()
        Me.tableLayoutPanel1.SuspendLayout()
        Me.grpDataManipulate.SuspendLayout()
        Me.grpSqlServers.SuspendLayout()
        Me.GrpAuthenticate.SuspendLayout()
        Me.panel3.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.userDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ContextExport.SuspendLayout()
        Me.SuspendLayout()
        '
        'tableLayoutPanel1
        '
        Me.tableLayoutPanel1.ColumnCount = 2
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel1.Controls.Add(Me.grpDataManipulate, 1, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.grpSqlServers, 0, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.panel3, 0, 2)
        Me.tableLayoutPanel1.Controls.Add(Me.SplitContainer1, 1, 1)
        Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 3
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(978, 558)
        Me.tableLayoutPanel1.TabIndex = 11
        '
        'grpDataManipulate
        '
        Me.grpDataManipulate.BackColor = System.Drawing.Color.Khaki
        Me.grpDataManipulate.Controls.Add(Me.lblPageNums)
        Me.grpDataManipulate.Controls.Add(Me.btnFirst)
        Me.grpDataManipulate.Controls.Add(Me.label1)
        Me.grpDataManipulate.Controls.Add(Me.btnNext)
        Me.grpDataManipulate.Controls.Add(Me.btnPrevious)
        Me.grpDataManipulate.Controls.Add(Me.btnLast)
        Me.grpDataManipulate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpDataManipulate.Location = New System.Drawing.Point(239, 3)
        Me.grpDataManipulate.Name = "grpDataManipulate"
        Me.grpDataManipulate.Size = New System.Drawing.Size(736, 32)
        Me.grpDataManipulate.TabIndex = 15
        '
        'lblPageNums
        '
        Me.lblPageNums.AutoSize = True
        Me.lblPageNums.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPageNums.Location = New System.Drawing.Point(299, 10)
        Me.lblPageNums.Name = "lblPageNums"
        Me.lblPageNums.Size = New System.Drawing.Size(0, 13)
        Me.lblPageNums.TabIndex = 18
        Me.lblPageNums.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(75, 3)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(50, 23)
        Me.btnFirst.TabIndex = 11
        Me.btnFirst.Text = "&First"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(1, 8)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(72, 13)
        Me.label1.TabIndex = 8
        Me.label1.Text = "Navigation:"
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(178, 3)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(50, 23)
        Me.btnNext.TabIndex = 13
        Me.btnNext.Text = ">>"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(127, 3)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(50, 23)
        Me.btnPrevious.TabIndex = 12
        Me.btnPrevious.Text = "<<"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(229, 3)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(50, 23)
        Me.btnLast.TabIndex = 14
        Me.btnLast.Text = "L&ast"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'grpSqlServers
        '
        Me.grpSqlServers.Controls.Add(Me.lblTotRecords)
        Me.grpSqlServers.Controls.Add(Me.GrpAuthenticate)
        Me.grpSqlServers.Controls.Add(Me.prgProgress)
        Me.grpSqlServers.Controls.Add(Me.cmbTables)
        Me.grpSqlServers.Controls.Add(Me.btnGetAllTables)
        Me.grpSqlServers.Controls.Add(Me.cmbAllDataBases)
        Me.grpSqlServers.Controls.Add(Me.btnGetAllDataBases)
        Me.grpSqlServers.Controls.Add(Me.btnNoOfPages)
        Me.grpSqlServers.Controls.Add(Me.btnLoadSqlServers)
        Me.grpSqlServers.Controls.Add(Me.cmbNoOfRecords)
        Me.grpSqlServers.Controls.Add(Me.btnLoad)
        Me.grpSqlServers.Controls.Add(Me.lblNoOfPages)
        Me.grpSqlServers.Controls.Add(Me.cmbSqlServers)
        Me.grpSqlServers.Dock = System.Windows.Forms.DockStyle.Left
        Me.grpSqlServers.Location = New System.Drawing.Point(3, 3)
        Me.grpSqlServers.Name = "grpSqlServers"
        Me.tableLayoutPanel1.SetRowSpan(Me.grpSqlServers, 2)
        Me.grpSqlServers.Size = New System.Drawing.Size(230, 509)
        Me.grpSqlServers.TabIndex = 8
        Me.grpSqlServers.TabStop = False
        Me.grpSqlServers.Text = "Load and login to SQL server"
        '
        'lblTotRecords
        '
        Me.lblTotRecords.AutoSize = True
        Me.lblTotRecords.BackColor = System.Drawing.Color.AntiqueWhite
        Me.lblTotRecords.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotRecords.Location = New System.Drawing.Point(12, 238)
        Me.lblTotRecords.Name = "lblTotRecords"
        Me.lblTotRecords.Size = New System.Drawing.Size(0, 13)
        Me.lblTotRecords.TabIndex = 10
        '
        'GrpAuthenticate
        '
        Me.GrpAuthenticate.Controls.Add(Me.txtPassword)
        Me.GrpAuthenticate.Controls.Add(Me.txtUserName)
        Me.GrpAuthenticate.Controls.Add(Me.chkWinAuthen)
        Me.GrpAuthenticate.Controls.Add(Me.Label3)
        Me.GrpAuthenticate.Controls.Add(Me.Label4)
        Me.GrpAuthenticate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpAuthenticate.Location = New System.Drawing.Point(5, 43)
        Me.GrpAuthenticate.Name = "GrpAuthenticate"
        Me.GrpAuthenticate.Size = New System.Drawing.Size(218, 93)
        Me.GrpAuthenticate.TabIndex = 9
        Me.GrpAuthenticate.TabStop = False
        Me.GrpAuthenticate.Text = "Authentication"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(69, 64)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(138, 23)
        Me.txtPassword.TabIndex = 5
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(69, 36)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(138, 23)
        Me.txtUserName.TabIndex = 4
        '
        'chkWinAuthen
        '
        Me.chkWinAuthen.AutoSize = True
        Me.chkWinAuthen.Location = New System.Drawing.Point(9, 18)
        Me.chkWinAuthen.Name = "chkWinAuthen"
        Me.chkWinAuthen.Size = New System.Drawing.Size(157, 19)
        Me.chkWinAuthen.TabIndex = 3
        Me.chkWinAuthen.Text = "Windows Authentication"
        Me.chkWinAuthen.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chkWinAuthen.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "User ID:"
        '
        'prgProgress
        '
        Me.prgProgress.Location = New System.Drawing.Point(8, 488)
        Me.prgProgress.Name = "prgProgress"
        Me.prgProgress.Size = New System.Drawing.Size(217, 23)
        Me.prgProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.prgProgress.TabIndex = 8
        Me.prgProgress.Visible = False
        '
        'cmbTables
        '
        Me.cmbTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTables.FormattingEnabled = True
        Me.cmbTables.Location = New System.Drawing.Point(8, 163)
        Me.cmbTables.Name = "cmbTables"
        Me.cmbTables.Size = New System.Drawing.Size(217, 21)
        Me.cmbTables.TabIndex = 7
        '
        'btnGetAllTables
        '
        Me.btnGetAllTables.Location = New System.Drawing.Point(192, 232)
        Me.btnGetAllTables.Name = "btnGetAllTables"
        Me.btnGetAllTables.Size = New System.Drawing.Size(19, 23)
        Me.btnGetAllTables.TabIndex = 6
        Me.btnGetAllTables.Text = "Get All &Tables"
        Me.btnGetAllTables.UseVisualStyleBackColor = True
        Me.btnGetAllTables.Visible = False
        '
        'cmbAllDataBases
        '
        Me.cmbAllDataBases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAllDataBases.FormattingEnabled = True
        Me.cmbAllDataBases.Location = New System.Drawing.Point(8, 139)
        Me.cmbAllDataBases.Name = "cmbAllDataBases"
        Me.cmbAllDataBases.Size = New System.Drawing.Size(217, 21)
        Me.cmbAllDataBases.TabIndex = 5
        '
        'btnGetAllDataBases
        '
        Me.btnGetAllDataBases.Location = New System.Drawing.Point(168, 232)
        Me.btnGetAllDataBases.Name = "btnGetAllDataBases"
        Me.btnGetAllDataBases.Size = New System.Drawing.Size(19, 23)
        Me.btnGetAllDataBases.TabIndex = 4
        Me.btnGetAllDataBases.Text = "Get All &Databases"
        Me.btnGetAllDataBases.UseVisualStyleBackColor = True
        Me.btnGetAllDataBases.Visible = False
        '
        'btnNoOfPages
        '
        Me.btnNoOfPages.Location = New System.Drawing.Point(163, 257)
        Me.btnNoOfPages.Name = "btnNoOfPages"
        Me.btnNoOfPages.Size = New System.Drawing.Size(40, 23)
        Me.btnNoOfPages.TabIndex = 10
        Me.btnNoOfPages.Text = "&Set"
        Me.btnNoOfPages.UseVisualStyleBackColor = True
        '
        'btnLoadSqlServers
        '
        Me.btnLoadSqlServers.Location = New System.Drawing.Point(144, 232)
        Me.btnLoadSqlServers.Name = "btnLoadSqlServers"
        Me.btnLoadSqlServers.Size = New System.Drawing.Size(19, 23)
        Me.btnLoadSqlServers.TabIndex = 0
        Me.btnLoadSqlServers.Text = "Get all &Sql servers  on network"
        Me.btnLoadSqlServers.UseVisualStyleBackColor = True
        Me.btnLoadSqlServers.Visible = False
        '
        'cmbNoOfRecords
        '
        Me.cmbNoOfRecords.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNoOfRecords.FormatString = "N2"
        Me.cmbNoOfRecords.FormattingEnabled = True
        Me.cmbNoOfRecords.Items.AddRange(New Object() {"15", "25", "35", "45", "55", "ALL"})
        Me.cmbNoOfRecords.Location = New System.Drawing.Point(103, 258)
        Me.cmbNoOfRecords.Name = "cmbNoOfRecords"
        Me.cmbNoOfRecords.Size = New System.Drawing.Size(57, 21)
        Me.cmbNoOfRecords.TabIndex = 9
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(8, 188)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(218, 43)
        Me.btnLoad.TabIndex = 8
        Me.btnLoad.Text = "&Load data"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'lblNoOfPages
        '
        Me.lblNoOfPages.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoOfPages.Location = New System.Drawing.Point(9, 255)
        Me.lblNoOfPages.Name = "lblNoOfPages"
        Me.lblNoOfPages.Size = New System.Drawing.Size(93, 27)
        Me.lblNoOfPages.TabIndex = 7
        Me.lblNoOfPages.Text = "No. of records per page: "
        '
        'cmbSqlServers
        '
        Me.cmbSqlServers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSqlServers.FormattingEnabled = True
        Me.cmbSqlServers.Location = New System.Drawing.Point(9, 16)
        Me.cmbSqlServers.Name = "cmbSqlServers"
        Me.cmbSqlServers.Size = New System.Drawing.Size(217, 21)
        Me.cmbSqlServers.TabIndex = 1
        '
        'panel3
        '
        Me.panel3.BackColor = System.Drawing.Color.Goldenrod
        Me.tableLayoutPanel1.SetColumnSpan(Me.panel3, 2)
        Me.panel3.Controls.Add(Me.btnRefresh)
        Me.panel3.Controls.Add(Me.btnUpdate)
        Me.panel3.Controls.Add(Me.btnDelete)
        Me.panel3.Controls.Add(Me.btnAdd)
        Me.panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel3.Location = New System.Drawing.Point(3, 518)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(972, 37)
        Me.panel3.TabIndex = 16
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.Location = New System.Drawing.Point(895, 7)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 18
        Me.btnRefresh.Text = "&REFRESH"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(320, 7)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 16
        Me.btnUpdate.Text = "&Commit"
        Me.btnUpdate.UseVisualStyleBackColor = True
        Me.btnUpdate.Visible = False
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(401, 7)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 17
        Me.btnDelete.Text = "&Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        Me.btnDelete.Visible = False
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(239, 7)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "&Add/Update"
        Me.btnAdd.UseVisualStyleBackColor = True
        Me.btnAdd.Visible = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(239, 41)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.userDataGridView)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(736, 471)
        Me.SplitContainer1.SplitterDistance = 311
        Me.SplitContainer1.TabIndex = 17
        '
        'userDataGridView
        '
        Me.userDataGridView.AllowUserToOrderColumns = True
        Me.userDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.userDataGridView.BackgroundColor = System.Drawing.Color.Khaki
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.userDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.userDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.userDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.userDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.userDataGridView.Name = "userDataGridView"
        Me.userDataGridView.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.userDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.userDataGridView.Size = New System.Drawing.Size(734, 309)
        Me.userDataGridView.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtCondition)
        Me.Panel1.Controls.Add(Me.cmdQuery)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.tQuery)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(734, 154)
        Me.Panel1.TabIndex = 0
        '
        'cmdQuery
        '
        Me.cmdQuery.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdQuery.Location = New System.Drawing.Point(597, 59)
        Me.cmdQuery.Name = "cmdQuery"
        Me.cmdQuery.Size = New System.Drawing.Size(134, 89)
        Me.cmdQuery.TabIndex = 12
        Me.cmdQuery.Text = "&Load Query"
        Me.cmdQuery.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdLoad)
        Me.GroupBox1.Controls.Add(Me.cmdInsert)
        Me.GroupBox1.Controls.Add(Me.cmdOR)
        Me.GroupBox1.Controls.Add(Me.cmdAND)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cboSortBy)
        Me.GroupBox1.Controls.Add(Me.chkSortOrder)
        Me.GroupBox1.Controls.Add(Me.chkLoadPeriod)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cboValue)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cboCondition)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cboDataField)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(588, 89)
        Me.GroupBox1.TabIndex = 135
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Report Condition"
        '
        'cmdLoad
        '
        Me.cmdLoad.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLoad.Location = New System.Drawing.Point(512, 33)
        Me.cmdLoad.Name = "cmdLoad"
        Me.cmdLoad.Size = New System.Drawing.Size(43, 24)
        Me.cmdLoad.TabIndex = 13
        Me.cmdLoad.Text = "Load"
        Me.cmdLoad.UseVisualStyleBackColor = True
        '
        'cmdInsert
        '
        Me.cmdInsert.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdInsert.ForeColor = System.Drawing.Color.Red
        Me.cmdInsert.Location = New System.Drawing.Point(93, 57)
        Me.cmdInsert.Name = "cmdInsert"
        Me.cmdInsert.Size = New System.Drawing.Size(97, 27)
        Me.cmdInsert.TabIndex = 12
        Me.cmdInsert.Text = "Insert Criteria"
        Me.cmdInsert.UseVisualStyleBackColor = True
        '
        'cmdOR
        '
        Me.cmdOR.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOR.Location = New System.Drawing.Point(50, 56)
        Me.cmdOR.Name = "cmdOR"
        Me.cmdOR.Size = New System.Drawing.Size(41, 27)
        Me.cmdOR.TabIndex = 11
        Me.cmdOR.Text = "OR"
        Me.cmdOR.UseVisualStyleBackColor = True
        '
        'cmdAND
        '
        Me.cmdAND.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAND.Location = New System.Drawing.Point(8, 56)
        Me.cmdAND.Name = "cmdAND"
        Me.cmdAND.Size = New System.Drawing.Size(41, 27)
        Me.cmdAND.TabIndex = 10
        Me.cmdAND.Text = "AND"
        Me.cmdAND.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(202, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Sort By:"
        '
        'cboSortBy
        '
        Me.cboSortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSortBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboSortBy.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSortBy.FormattingEnabled = True
        Me.cboSortBy.Location = New System.Drawing.Point(246, 58)
        Me.cboSortBy.Name = "cboSortBy"
        Me.cboSortBy.Size = New System.Drawing.Size(168, 21)
        Me.cboSortBy.TabIndex = 8
        '
        'chkSortOrder
        '
        Me.chkSortOrder.AutoSize = True
        Me.chkSortOrder.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkSortOrder.Checked = True
        Me.chkSortOrder.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSortOrder.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSortOrder.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.chkSortOrder.Location = New System.Drawing.Point(416, 61)
        Me.chkSortOrder.Name = "chkSortOrder"
        Me.chkSortOrder.Size = New System.Drawing.Size(150, 17)
        Me.chkSortOrder.TabIndex = 7
        Me.chkSortOrder.Text = "Sort in Ascending Order"
        Me.chkSortOrder.UseVisualStyleBackColor = True
        '
        'chkLoadPeriod
        '
        Me.chkLoadPeriod.AutoSize = True
        Me.chkLoadPeriod.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkLoadPeriod.Checked = True
        Me.chkLoadPeriod.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkLoadPeriod.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLoadPeriod.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.chkLoadPeriod.Location = New System.Drawing.Point(363, 16)
        Me.chkLoadPeriod.Name = "chkLoadPeriod"
        Me.chkLoadPeriod.Size = New System.Drawing.Size(206, 17)
        Me.chkLoadPeriod.TabIndex = 6
        Me.chkLoadPeriod.Text = "Load Values in Current Period Only"
        Me.chkLoadPeriod.UseVisualStyleBackColor = True
        Me.chkLoadPeriod.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(244, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Value:"
        '
        'cboValue
        '
        Me.cboValue.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboValue.FormattingEnabled = True
        Me.cboValue.Location = New System.Drawing.Point(246, 35)
        Me.cboValue.Name = "cboValue"
        Me.cboValue.Size = New System.Drawing.Size(265, 21)
        Me.cboValue.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(153, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Condition:"
        '
        'cboCondition
        '
        Me.cboCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCondition.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboCondition.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCondition.FormattingEnabled = True
        Me.cboCondition.Items.AddRange(New Object() {"=", ">", "<", ">=", "<=", "<>", "Like", "Start with", "End with"})
        Me.cboCondition.Location = New System.Drawing.Point(155, 35)
        Me.cboCondition.Name = "cboCondition"
        Me.cboCondition.Size = New System.Drawing.Size(89, 21)
        Me.cboCondition.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(7, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Select Data Field:"
        '
        'cboDataField
        '
        Me.cboDataField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDataField.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboDataField.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDataField.FormattingEnabled = True
        Me.cboDataField.Location = New System.Drawing.Point(9, 35)
        Me.cboDataField.Name = "cboDataField"
        Me.cboDataField.Size = New System.Drawing.Size(140, 21)
        Me.cboDataField.TabIndex = 0
        '
        'tQuery
        '
        Me.tQuery.BackColor = System.Drawing.Color.LemonChiffon
        Me.tQuery.Location = New System.Drawing.Point(3, 0)
        Me.tQuery.Multiline = True
        Me.tQuery.Name = "tQuery"
        Me.tQuery.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tQuery.Size = New System.Drawing.Size(728, 56)
        Me.tQuery.TabIndex = 11
        '
        'notifyIcon1
        '
        Me.notifyIcon1.Text = "notifyIcon1"
        Me.notifyIcon1.Visible = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 250
        '
        'ContextExport
        '
        Me.ContextExport.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExportToExcel, Me.ToolStripMenuItem1, Me.mnuCopyToClipboard})
        Me.ContextExport.Name = "ContextMenuStrip1"
        Me.ContextExport.Size = New System.Drawing.Size(172, 54)
        '
        'mnuExportToExcel
        '
        Me.mnuExportToExcel.Name = "mnuExportToExcel"
        Me.mnuExportToExcel.Size = New System.Drawing.Size(171, 22)
        Me.mnuExportToExcel.Text = "Export to Excel"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(168, 6)
        '
        'mnuCopyToClipboard
        '
        Me.mnuCopyToClipboard.Name = "mnuCopyToClipboard"
        Me.mnuCopyToClipboard.Size = New System.Drawing.Size(171, 22)
        Me.mnuCopyToClipboard.Text = "Copy to Clipboard"
        '
        'txtCondition
        '
        Me.txtCondition.Location = New System.Drawing.Point(352, 24)
        Me.txtCondition.Name = "txtCondition"
        Me.txtCondition.Size = New System.Drawing.Size(126, 20)
        Me.txtCondition.TabIndex = 144
        Me.txtCondition.Visible = False
        '
        'FrmReportBuilder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(978, 558)
        Me.Controls.Add(Me.tableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmReportBuilder"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report Builder"
        Me.tableLayoutPanel1.ResumeLayout(False)
        Me.grpDataManipulate.ResumeLayout(False)
        Me.grpDataManipulate.PerformLayout()
        Me.grpSqlServers.ResumeLayout(False)
        Me.grpSqlServers.PerformLayout()
        Me.GrpAuthenticate.ResumeLayout(False)
        Me.GrpAuthenticate.PerformLayout()
        Me.panel3.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.userDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ContextExport.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Private WithEvents grpDataManipulate As System.Windows.Forms.Panel
    Private WithEvents lblPageNums As System.Windows.Forms.Label
    Private WithEvents btnFirst As System.Windows.Forms.Button
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents btnNext As System.Windows.Forms.Button
    Private WithEvents btnPrevious As System.Windows.Forms.Button
    Private WithEvents btnLast As System.Windows.Forms.Button
    Private WithEvents panel3 As System.Windows.Forms.Panel
    Private WithEvents btnRefresh As System.Windows.Forms.Button
    Private WithEvents btnUpdate As System.Windows.Forms.Button
    Private WithEvents btnDelete As System.Windows.Forms.Button
    Private WithEvents btnAdd As System.Windows.Forms.Button
    Private WithEvents grpSqlServers As System.Windows.Forms.GroupBox
    Private WithEvents lblTotRecords As System.Windows.Forms.Label
    Friend WithEvents GrpAuthenticate As System.Windows.Forms.GroupBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents chkWinAuthen As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents prgProgress As System.Windows.Forms.ProgressBar
    Private WithEvents cmbTables As System.Windows.Forms.ComboBox
    Private WithEvents btnGetAllTables As System.Windows.Forms.Button
    Private WithEvents cmbAllDataBases As System.Windows.Forms.ComboBox
    Private WithEvents btnGetAllDataBases As System.Windows.Forms.Button
    Private WithEvents btnNoOfPages As System.Windows.Forms.Button
    Private WithEvents btnLoadSqlServers As System.Windows.Forms.Button
    Private WithEvents cmbNoOfRecords As System.Windows.Forms.ComboBox
    Private WithEvents btnLoad As System.Windows.Forms.Button
    Private WithEvents lblNoOfPages As System.Windows.Forms.Label
    Private WithEvents cmbSqlServers As System.Windows.Forms.ComboBox
    Private WithEvents userDataGridView As System.Windows.Forms.DataGridView
    Private WithEvents notifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Private WithEvents cmdQuery As System.Windows.Forms.Button
    Friend WithEvents tQuery As System.Windows.Forms.TextBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdLoad As System.Windows.Forms.Button
    Friend WithEvents cmdInsert As System.Windows.Forms.Button
    Friend WithEvents cmdOR As System.Windows.Forms.Button
    Friend WithEvents cmdAND As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboSortBy As System.Windows.Forms.ComboBox
    Friend WithEvents chkSortOrder As System.Windows.Forms.CheckBox
    Friend WithEvents chkLoadPeriod As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboValue As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboCondition As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboDataField As System.Windows.Forms.ComboBox
    Friend WithEvents ContextExport As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuExportToExcel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuCopyToClipboard As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtCondition As System.Windows.Forms.TextBox
End Class
