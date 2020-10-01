<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMandate
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMandate))
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblReportTitle = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.DGridList = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkClean = New System.Windows.Forms.CheckBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.cmdGetFile = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tDocFile = New System.Windows.Forms.TextBox()
        Me.cmdPeriod = New System.Windows.Forms.Button()
        Me.lblState = New System.Windows.Forms.Label()
        Me.cboState = New System.Windows.Forms.ComboBox()
        Me.tPeriod = New System.Windows.Forms.TextBox()
        Me.lblCamp = New System.Windows.Forms.Label()
        Me.lblPeriod = New System.Windows.Forms.Label()
        Me.cCamp = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuEMandateForTSA = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLAYOUT1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLAYOUT2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEMandateForRemital = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboBudgetLine = New System.Windows.Forms.ComboBox()
        Me.Panel5.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DGridList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Goldenrod
        Me.Panel5.Controls.Add(Me.lblReportTitle)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(983, 38)
        Me.Panel5.TabIndex = 551
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
        Me.lblReportTitle.Size = New System.Drawing.Size(772, 19)
        Me.lblReportTitle.TabIndex = 45
        Me.lblReportTitle.Text = "-"
        Me.lblReportTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.DGridList, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCount, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 38)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(983, 585)
        Me.TableLayoutPanel1.TabIndex = 552
        '
        'DGridList
        '
        Me.DGridList.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGridList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGridList.BackgroundColor = System.Drawing.Color.Khaki
        Me.DGridList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGridList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGridList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableLayoutPanel1.SetColumnSpan(Me.DGridList, 3)
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Khaki
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGridList.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGridList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGridList.GridColor = System.Drawing.Color.RoyalBlue
        Me.DGridList.Location = New System.Drawing.Point(3, 3)
        Me.DGridList.Name = "DGridList"
        Me.DGridList.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGridList.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DGridList.RowHeadersWidth = 15
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.DGridList.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DGridList.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGridList.Size = New System.Drawing.Size(977, 398)
        Me.DGridList.TabIndex = 555
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cboBudgetLine)
        Me.Panel1.Controls.Add(Me.chkClean)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.cmdPeriod)
        Me.Panel1.Controls.Add(Me.lblState)
        Me.Panel1.Controls.Add(Me.cboState)
        Me.Panel1.Controls.Add(Me.tPeriod)
        Me.Panel1.Controls.Add(Me.lblCamp)
        Me.Panel1.Controls.Add(Me.lblPeriod)
        Me.Panel1.Controls.Add(Me.cCamp)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(263, 407)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(457, 175)
        Me.Panel1.TabIndex = 554
        '
        'chkClean
        '
        Me.chkClean.AutoSize = True
        Me.chkClean.ForeColor = System.Drawing.Color.Tomato
        Me.chkClean.Location = New System.Drawing.Point(323, 37)
        Me.chkClean.Name = "chkClean"
        Me.chkClean.Size = New System.Drawing.Size(135, 17)
        Me.chkClean.TabIndex = 570
        Me.chkClean.Text = "Clean while Generating"
        Me.chkClean.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Goldenrod
        Me.Panel3.Controls.Add(Me.cmdClose)
        Me.Panel3.Controls.Add(Me.cmdOk)
        Me.Panel3.Location = New System.Drawing.Point(339, 56)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(108, 88)
        Me.Panel3.TabIndex = 563
        '
        'cmdClose
        '
        Me.cmdClose.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClose.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Location = New System.Drawing.Point(7, 46)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(95, 38)
        Me.cmdClose.TabIndex = 246
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'cmdOk
        '
        Me.cmdOk.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdOk.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmdOk.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOk.Location = New System.Drawing.Point(7, 5)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(95, 38)
        Me.cmdOk.TabIndex = 245
        Me.cmdOk.Text = "&Generate"
        Me.cmdOk.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Goldenrod
        Me.Panel6.Controls.Add(Me.cmdGetFile)
        Me.Panel6.Controls.Add(Me.Label15)
        Me.Panel6.Controls.Add(Me.tDocFile)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 147)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(455, 26)
        Me.Panel6.TabIndex = 569
        '
        'cmdGetFile
        '
        Me.cmdGetFile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdGetFile.Location = New System.Drawing.Point(300, 3)
        Me.cmdGetFile.Name = "cmdGetFile"
        Me.cmdGetFile.Size = New System.Drawing.Size(27, 22)
        Me.cmdGetFile.TabIndex = 204
        Me.cmdGetFile.Text = "..."
        Me.cmdGetFile.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(2, 6)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(83, 16)
        Me.Label15.TabIndex = 202
        Me.Label15.Text = "Saving Path:"
        '
        'tDocFile
        '
        Me.tDocFile.Location = New System.Drawing.Point(98, 4)
        Me.tDocFile.Name = "tDocFile"
        Me.tDocFile.Size = New System.Drawing.Size(200, 20)
        Me.tDocFile.TabIndex = 203
        '
        'cmdPeriod
        '
        Me.cmdPeriod.Location = New System.Drawing.Point(200, 37)
        Me.cmdPeriod.Name = "cmdPeriod"
        Me.cmdPeriod.Size = New System.Drawing.Size(32, 24)
        Me.cmdPeriod.TabIndex = 244
        Me.cmdPeriod.Text = "..."
        Me.cmdPeriod.UseVisualStyleBackColor = True
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.ForeColor = System.Drawing.Color.Black
        Me.lblState.Location = New System.Drawing.Point(41, 69)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(42, 16)
        Me.lblState.TabIndex = 567
        Me.lblState.Text = "State:"
        '
        'cboState
        '
        Me.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboState.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboState.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboState.FormattingEnabled = True
        Me.cboState.Items.AddRange(New Object() {"LGA", "MDA"})
        Me.cboState.Location = New System.Drawing.Point(98, 64)
        Me.cboState.Name = "cboState"
        Me.cboState.Size = New System.Drawing.Size(227, 24)
        Me.cboState.TabIndex = 566
        '
        'tPeriod
        '
        Me.tPeriod.Enabled = False
        Me.tPeriod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tPeriod.Location = New System.Drawing.Point(96, 38)
        Me.tPeriod.Name = "tPeriod"
        Me.tPeriod.Size = New System.Drawing.Size(103, 22)
        Me.tPeriod.TabIndex = 242
        Me.tPeriod.Tag = "Telephone"
        '
        'lblCamp
        '
        Me.lblCamp.AutoSize = True
        Me.lblCamp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCamp.ForeColor = System.Drawing.Color.Black
        Me.lblCamp.Location = New System.Drawing.Point(36, 99)
        Me.lblCamp.Name = "lblCamp"
        Me.lblCamp.Size = New System.Drawing.Size(47, 16)
        Me.lblCamp.TabIndex = 565
        Me.lblCamp.Text = "Camp:"
        '
        'lblPeriod
        '
        Me.lblPeriod.AutoSize = True
        Me.lblPeriod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeriod.Location = New System.Drawing.Point(32, 41)
        Me.lblPeriod.Name = "lblPeriod"
        Me.lblPeriod.Size = New System.Drawing.Size(51, 16)
        Me.lblPeriod.TabIndex = 243
        Me.lblPeriod.Text = "Period:"
        '
        'cCamp
        '
        Me.cCamp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cCamp.DropDownWidth = 227
        Me.cCamp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cCamp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cCamp.FormattingEnabled = True
        Me.cCamp.Location = New System.Drawing.Point(98, 93)
        Me.cCamp.Name = "cCamp"
        Me.cCamp.Size = New System.Drawing.Size(227, 24)
        Me.cCamp.TabIndex = 564
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEMandateForTSA, Me.mnuEMandateForRemital})
        Me.MenuStrip1.Location = New System.Drawing.Point(56, 5)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(332, 29)
        Me.MenuStrip1.TabIndex = 568
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuEMandateForTSA
        '
        Me.mnuEMandateForTSA.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLAYOUT1, Me.mnuLAYOUT2})
        Me.mnuEMandateForTSA.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.mnuEMandateForTSA.Name = "mnuEMandateForTSA"
        Me.mnuEMandateForTSA.Size = New System.Drawing.Size(149, 25)
        Me.mnuEMandateForTSA.Text = "eMandate For TSA"
        '
        'mnuLAYOUT1
        '
        Me.mnuLAYOUT1.Name = "mnuLAYOUT1"
        Me.mnuLAYOUT1.Size = New System.Drawing.Size(152, 26)
        Me.mnuLAYOUT1.Text = "LAYOUT 1"
        '
        'mnuLAYOUT2
        '
        Me.mnuLAYOUT2.Name = "mnuLAYOUT2"
        Me.mnuLAYOUT2.Size = New System.Drawing.Size(152, 26)
        Me.mnuLAYOUT2.Text = "LAYOUT 2"
        '
        'mnuEMandateForRemital
        '
        Me.mnuEMandateForRemital.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.mnuEMandateForRemital.Name = "mnuEMandateForRemital"
        Me.mnuEMandateForRemital.Size = New System.Drawing.Size(175, 25)
        Me.mnuEMandateForRemital.Text = "eMandate For Remital"
        '
        'lblCount
        '
        Me.lblCount.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.Location = New System.Drawing.Point(3, 562)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(254, 23)
        Me.lblCount.TabIndex = 572
        Me.lblCount.Text = "0"
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(1, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 16)
        Me.Label1.TabIndex = 572
        Me.Label1.Text = "Budget Line:"
        '
        'cboBudgetLine
        '
        Me.cboBudgetLine.DropDownWidth = 227
        Me.cboBudgetLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboBudgetLine.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBudgetLine.FormattingEnabled = True
        Me.cboBudgetLine.Location = New System.Drawing.Point(98, 121)
        Me.cboBudgetLine.Name = "cboBudgetLine"
        Me.cboBudgetLine.Size = New System.Drawing.Size(227, 24)
        Me.cboBudgetLine.TabIndex = 571
        '
        'FrmMandate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(983, 623)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmMandate"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "eMandate"
        Me.Panel5.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.DGridList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents lblReportTitle As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdPeriod As System.Windows.Forms.Button
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents cboState As System.Windows.Forms.ComboBox
    Friend WithEvents tPeriod As System.Windows.Forms.TextBox
    Friend WithEvents lblCamp As System.Windows.Forms.Label
    Friend WithEvents lblPeriod As System.Windows.Forms.Label
    Friend WithEvents cCamp As System.Windows.Forms.ComboBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuEMandateForTSA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEMandateForRemital As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DGridList As System.Windows.Forms.DataGridView
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents cmdGetFile As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents tDocFile As System.Windows.Forms.TextBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents chkClean As System.Windows.Forms.CheckBox
    Friend WithEvents mnuLAYOUT1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLAYOUT2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboBudgetLine As System.Windows.Forms.ComboBox
End Class
