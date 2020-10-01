<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReport))
        Me.myCrystalReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblReportTitle = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MainMenu = New System.Windows.Forms.MenuStrip()
        Me.mnuSchedule = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuScheduleUnpaid = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuScheduleExcel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSummary = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSummary1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPayrollSummary = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPaySlip = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStipendsNamesOnly = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSuspended = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPayslipWithPict = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAnnual = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblState = New System.Windows.Forms.Label()
        Me.cboState = New System.Windows.Forms.ComboBox()
        Me.lblCamp = New System.Windows.Forms.Label()
        Me.cCamp = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.lblPeriod = New System.Windows.Forms.Label()
        Me.tPeriod = New System.Windows.Forms.TextBox()
        Me.cmdPeriod = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnReportBuilder = New System.Windows.Forms.Button()
        Me.lblOwner = New System.Windows.Forms.Label()
        Me.OwnerLogo = New System.Windows.Forms.PictureBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.cmdGetFile = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tDocFile = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.mnuStipendsWithIDNo = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MainMenu.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.OwnerLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'myCrystalReportViewer
        '
        Me.myCrystalReportViewer.ActiveViewIndex = -1
        Me.myCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.myCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.myCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.myCrystalReportViewer.Location = New System.Drawing.Point(330, 41)
        Me.myCrystalReportViewer.Name = "myCrystalReportViewer"
        Me.TableLayoutPanel1.SetRowSpan(Me.myCrystalReportViewer, 4)
        Me.myCrystalReportViewer.SelectionFormula = ""
        Me.myCrystalReportViewer.ShowGroupTreeButton = False
        Me.myCrystalReportViewer.Size = New System.Drawing.Size(413, 549)
        Me.myCrystalReportViewer.TabIndex = 0
        Me.myCrystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.myCrystalReportViewer.ViewTimeSelectionFormula = ""
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel5, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.myCrystalReportViewer, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel6, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(746, 593)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Goldenrod
        Me.TableLayoutPanel1.SetColumnSpan(Me.Panel5, 2)
        Me.Panel5.Controls.Add(Me.lblReportTitle)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(746, 38)
        Me.Panel5.TabIndex = 550
        '
        'lblReportTitle
        '
        Me.lblReportTitle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblReportTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReportTitle.ForeColor = System.Drawing.Color.Lavender
        Me.lblReportTitle.Location = New System.Drawing.Point(91, 9)
        Me.lblReportTitle.Name = "lblReportTitle"
        Me.lblReportTitle.Size = New System.Drawing.Size(535, 19)
        Me.lblReportTitle.TabIndex = 45
        Me.lblReportTitle.Text = "-"
        Me.lblReportTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Khaki
        Me.Panel1.Controls.Add(Me.MainMenu)
        Me.Panel1.Location = New System.Drawing.Point(0, 58)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0, 20, 0, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(327, 244)
        Me.Panel1.TabIndex = 551
        '
        'MainMenu
        '
        Me.MainMenu.AllowMerge = False
        Me.MainMenu.BackColor = System.Drawing.Color.Khaki
        Me.MainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MainMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.MainMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSchedule, Me.mnuScheduleUnpaid, Me.mnuStipendsWithIDNo, Me.mnuScheduleExcel, Me.mnuSummary, Me.mnuSummary1, Me.mnuPayrollSummary, Me.mnuPaySlip, Me.mnuStipendsNamesOnly, Me.mnuSuspended, Me.mnuPayslipWithPict, Me.mnuAnnual})
        Me.MainMenu.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MainMenu.Size = New System.Drawing.Size(307, 244)
        Me.MainMenu.TabIndex = 247
        Me.MainMenu.Text = "MenuStrip2"
        '
        'mnuSchedule
        '
        Me.mnuSchedule.Font = New System.Drawing.Font("Arial Narrow", 10.0!)
        Me.mnuSchedule.Image = CType(resources.GetObject("mnuSchedule.Image"), System.Drawing.Image)
        Me.mnuSchedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnuSchedule.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuSchedule.Name = "mnuSchedule"
        Me.mnuSchedule.Size = New System.Drawing.Size(294, 21)
        Me.mnuSchedule.Text = "STIPENDS  SCHEDULE"
        '
        'mnuScheduleUnpaid
        '
        Me.mnuScheduleUnpaid.Font = New System.Drawing.Font("Arial Narrow", 10.0!)
        Me.mnuScheduleUnpaid.Image = CType(resources.GetObject("mnuScheduleUnpaid.Image"), System.Drawing.Image)
        Me.mnuScheduleUnpaid.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnuScheduleUnpaid.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuScheduleUnpaid.Name = "mnuScheduleUnpaid"
        Me.mnuScheduleUnpaid.Size = New System.Drawing.Size(294, 21)
        Me.mnuScheduleUnpaid.Text = "STIPENDS  SCHEDULE (Exclude Unpaid Delegates)"
        '
        'mnuScheduleExcel
        '
        Me.mnuScheduleExcel.Font = New System.Drawing.Font("Arial Narrow", 10.0!)
        Me.mnuScheduleExcel.Image = CType(resources.GetObject("mnuScheduleExcel.Image"), System.Drawing.Image)
        Me.mnuScheduleExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnuScheduleExcel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuScheduleExcel.Name = "mnuScheduleExcel"
        Me.mnuScheduleExcel.Size = New System.Drawing.Size(294, 21)
        Me.mnuScheduleExcel.Text = "STIPENDS  SCHEDULE (Excel)"
        Me.mnuScheduleExcel.Visible = False
        '
        'mnuSummary
        '
        Me.mnuSummary.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuSummary.Image = Global.ApexStipends.My.Resources.Resources.CAJEZIV7
        Me.mnuSummary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnuSummary.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuSummary.Name = "mnuSummary"
        Me.mnuSummary.Size = New System.Drawing.Size(294, 21)
        Me.mnuSummary.Text = "STIPENDS SUMMARY - 1"
        '
        'mnuSummary1
        '
        Me.mnuSummary1.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuSummary1.Image = Global.ApexStipends.My.Resources.Resources.CAJEZIV7
        Me.mnuSummary1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnuSummary1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuSummary1.Name = "mnuSummary1"
        Me.mnuSummary1.Size = New System.Drawing.Size(294, 21)
        Me.mnuSummary1.Text = "STIPENDS SUMMARY - 2 "
        '
        'mnuPayrollSummary
        '
        Me.mnuPayrollSummary.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuPayrollSummary.Image = Global.ApexStipends.My.Resources.Resources.CAJEZIV7
        Me.mnuPayrollSummary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnuPayrollSummary.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuPayrollSummary.Name = "mnuPayrollSummary"
        Me.mnuPayrollSummary.Size = New System.Drawing.Size(294, 21)
        Me.mnuPayrollSummary.Text = "PAYROLL SUMMARY"
        '
        'mnuPaySlip
        '
        Me.mnuPaySlip.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuPaySlip.Image = Global.ApexStipends.My.Resources.Resources.CAJEZIV7
        Me.mnuPaySlip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnuPaySlip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuPaySlip.Name = "mnuPaySlip"
        Me.mnuPaySlip.Size = New System.Drawing.Size(294, 21)
        Me.mnuPaySlip.Text = "PAY SLIP"
        '
        'mnuStipendsNamesOnly
        '
        Me.mnuStipendsNamesOnly.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuStipendsNamesOnly.Image = Global.ApexStipends.My.Resources.Resources.CAJEZIV7
        Me.mnuStipendsNamesOnly.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnuStipendsNamesOnly.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuStipendsNamesOnly.Name = "mnuStipendsNamesOnly"
        Me.mnuStipendsNamesOnly.Size = New System.Drawing.Size(294, 21)
        Me.mnuStipendsNamesOnly.Text = "STIPENDS SUMMARY (Names Only) "
        '
        'mnuSuspended
        '
        Me.mnuSuspended.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuSuspended.Image = Global.ApexStipends.My.Resources.Resources.CAJEZIV7
        Me.mnuSuspended.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnuSuspended.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuSuspended.Name = "mnuSuspended"
        Me.mnuSuspended.Size = New System.Drawing.Size(294, 21)
        Me.mnuSuspended.Text = "LIST OF SUSPENDED EX-MILITANT"
        '
        'mnuPayslipWithPict
        '
        Me.mnuPayslipWithPict.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuPayslipWithPict.Image = Global.ApexStipends.My.Resources.Resources.CAJEZIV7
        Me.mnuPayslipWithPict.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnuPayslipWithPict.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuPayslipWithPict.Name = "mnuPayslipWithPict"
        Me.mnuPayslipWithPict.Size = New System.Drawing.Size(294, 21)
        Me.mnuPayslipWithPict.Text = "PAY SLIP WITH PHOTO"
        '
        'mnuAnnual
        '
        Me.mnuAnnual.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuAnnual.Image = Global.ApexStipends.My.Resources.Resources.CAJEZIV7
        Me.mnuAnnual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnuAnnual.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuAnnual.Name = "mnuAnnual"
        Me.mnuAnnual.Size = New System.Drawing.Size(294, 21)
        Me.mnuAnnual.Text = "ANNUAL STIPEND ANALYSIS"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblState)
        Me.Panel2.Controls.Add(Me.cboState)
        Me.Panel2.Controls.Add(Me.lblCamp)
        Me.Panel2.Controls.Add(Me.cCamp)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.lblPeriod)
        Me.Panel2.Controls.Add(Me.tPeriod)
        Me.Panel2.Controls.Add(Me.cmdPeriod)
        Me.Panel2.Location = New System.Drawing.Point(3, 315)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(321, 133)
        Me.Panel2.TabIndex = 552
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.ForeColor = System.Drawing.Color.Black
        Me.lblState.Location = New System.Drawing.Point(2, 8)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(35, 13)
        Me.lblState.TabIndex = 567
        Me.lblState.Text = "State:"
        '
        'cboState
        '
        Me.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboState.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboState.FormattingEnabled = True
        Me.cboState.Items.AddRange(New Object() {"LGA", "MDA"})
        Me.cboState.Location = New System.Drawing.Point(76, 4)
        Me.cboState.Name = "cboState"
        Me.cboState.Size = New System.Drawing.Size(227, 21)
        Me.cboState.TabIndex = 566
        '
        'lblCamp
        '
        Me.lblCamp.AutoSize = True
        Me.lblCamp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCamp.ForeColor = System.Drawing.Color.Black
        Me.lblCamp.Location = New System.Drawing.Point(2, 33)
        Me.lblCamp.Name = "lblCamp"
        Me.lblCamp.Size = New System.Drawing.Size(37, 13)
        Me.lblCamp.TabIndex = 565
        Me.lblCamp.Text = "Camp:"
        '
        'cCamp
        '
        Me.cCamp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cCamp.DropDownWidth = 243
        Me.cCamp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cCamp.FormattingEnabled = True
        Me.cCamp.Location = New System.Drawing.Point(76, 28)
        Me.cCamp.Name = "cCamp"
        Me.cCamp.Size = New System.Drawing.Size(227, 21)
        Me.cCamp.TabIndex = 564
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightYellow
        Me.Panel3.Controls.Add(Me.cmdClose)
        Me.Panel3.Controls.Add(Me.cmdOk)
        Me.Panel3.Location = New System.Drawing.Point(78, 79)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(226, 47)
        Me.Panel3.TabIndex = 563
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.Location = New System.Drawing.Point(122, 5)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(100, 38)
        Me.cmdClose.TabIndex = 246
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'cmdOk
        '
        Me.cmdOk.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdOk.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdOk.Location = New System.Drawing.Point(5, 5)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(115, 38)
        Me.cmdOk.TabIndex = 245
        Me.cmdOk.Text = "&Preview"
        Me.cmdOk.UseVisualStyleBackColor = False
        '
        'lblPeriod
        '
        Me.lblPeriod.AutoSize = True
        Me.lblPeriod.Location = New System.Drawing.Point(2, 55)
        Me.lblPeriod.Name = "lblPeriod"
        Me.lblPeriod.Size = New System.Drawing.Size(40, 13)
        Me.lblPeriod.TabIndex = 243
        Me.lblPeriod.Text = "Period:"
        '
        'tPeriod
        '
        Me.tPeriod.Enabled = False
        Me.tPeriod.Location = New System.Drawing.Point(76, 52)
        Me.tPeriod.Name = "tPeriod"
        Me.tPeriod.Size = New System.Drawing.Size(103, 20)
        Me.tPeriod.TabIndex = 242
        Me.tPeriod.Tag = "Telephone"
        '
        'cmdPeriod
        '
        Me.cmdPeriod.Location = New System.Drawing.Point(181, 51)
        Me.cmdPeriod.Name = "cmdPeriod"
        Me.cmdPeriod.Size = New System.Drawing.Size(32, 21)
        Me.cmdPeriod.TabIndex = 244
        Me.cmdPeriod.Text = "..."
        Me.cmdPeriod.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnReportBuilder)
        Me.Panel4.Controls.Add(Me.lblOwner)
        Me.Panel4.Controls.Add(Me.OwnerLogo)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(3, 486)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(321, 104)
        Me.Panel4.TabIndex = 553
        '
        'btnReportBuilder
        '
        Me.btnReportBuilder.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnReportBuilder.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportBuilder.Location = New System.Drawing.Point(77, 70)
        Me.btnReportBuilder.Name = "btnReportBuilder"
        Me.btnReportBuilder.Size = New System.Drawing.Size(169, 29)
        Me.btnReportBuilder.TabIndex = 11
        Me.btnReportBuilder.Text = "Report Builder"
        Me.btnReportBuilder.UseVisualStyleBackColor = True
        '
        'lblOwner
        '
        Me.lblOwner.AutoEllipsis = True
        Me.lblOwner.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblOwner.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOwner.ForeColor = System.Drawing.Color.Black
        Me.lblOwner.Location = New System.Drawing.Point(0, 75)
        Me.lblOwner.Name = "lblOwner"
        Me.lblOwner.Size = New System.Drawing.Size(321, 29)
        Me.lblOwner.TabIndex = 10
        Me.lblOwner.Text = "Megahit Systems"
        Me.lblOwner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblOwner.UseMnemonic = False
        Me.lblOwner.Visible = False
        '
        'OwnerLogo
        '
        Me.OwnerLogo.AccessibleDescription = ""
        Me.OwnerLogo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OwnerLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OwnerLogo.Location = New System.Drawing.Point(71, 59)
        Me.OwnerLogo.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
        Me.OwnerLogo.Name = "OwnerLogo"
        Me.OwnerLogo.Size = New System.Drawing.Size(103, 10)
        Me.OwnerLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.OwnerLogo.TabIndex = 9
        Me.OwnerLogo.TabStop = False
        Me.OwnerLogo.Visible = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Goldenrod
        Me.Panel6.Controls.Add(Me.cmdGetFile)
        Me.Panel6.Controls.Add(Me.Label15)
        Me.Panel6.Controls.Add(Me.tDocFile)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(3, 454)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(321, 26)
        Me.Panel6.TabIndex = 554
        Me.Panel6.Visible = False
        '
        'cmdGetFile
        '
        Me.cmdGetFile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdGetFile.Location = New System.Drawing.Point(289, 3)
        Me.cmdGetFile.Name = "cmdGetFile"
        Me.cmdGetFile.Size = New System.Drawing.Size(27, 21)
        Me.cmdGetFile.TabIndex = 204
        Me.cmdGetFile.Text = "..."
        Me.cmdGetFile.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(2, 6)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 13)
        Me.Label15.TabIndex = 202
        Me.Label15.Text = "Saving Path:"
        '
        'tDocFile
        '
        Me.tDocFile.Location = New System.Drawing.Point(77, 3)
        Me.tDocFile.Name = "tDocFile"
        Me.tDocFile.Size = New System.Drawing.Size(212, 20)
        Me.tDocFile.TabIndex = 203
        '
        'mnuStipendsWithIDNo
        '
        Me.mnuStipendsWithIDNo.Font = New System.Drawing.Font("Arial Narrow", 10.0!)
        Me.mnuStipendsWithIDNo.Image = CType(resources.GetObject("mnuStipendsWithIDNo.Image"), System.Drawing.Image)
        Me.mnuStipendsWithIDNo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mnuStipendsWithIDNo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnuStipendsWithIDNo.Name = "mnuStipendsWithIDNo"
        Me.mnuStipendsWithIDNo.Size = New System.Drawing.Size(294, 21)
        Me.mnuStipendsWithIDNo.Text = "STIPENDS  SCHEDULE With IDNo"
        '
        'FrmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(746, 593)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmReport"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.OwnerLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents myCrystalReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents lblReportTitle As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdPeriod As System.Windows.Forms.Button
    Friend WithEvents tPeriod As System.Windows.Forms.TextBox
    Friend WithEvents lblPeriod As System.Windows.Forms.Label
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents MainMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuSchedule As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents mnuSummary1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents OwnerLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblOwner As System.Windows.Forms.Label
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents cboState As System.Windows.Forms.ComboBox
    Friend WithEvents lblCamp As System.Windows.Forms.Label
    Friend WithEvents cCamp As System.Windows.Forms.ComboBox
    Friend WithEvents mnuAnnual As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSummary As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPayrollSummary As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPaySlip As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPayslipWithPict As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuScheduleUnpaid As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSuspended As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuScheduleExcel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents cmdGetFile As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents tDocFile As System.Windows.Forms.TextBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnReportBuilder As System.Windows.Forms.Button
    Friend WithEvents mnuStipendsNamesOnly As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuStipendsWithIDNo As System.Windows.Forms.ToolStripMenuItem
End Class
