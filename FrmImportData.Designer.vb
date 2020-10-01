<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImportData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmImportData))
        Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.lblCountUploadData = New System.Windows.Forms.Label()
        Me.cmdLoad = New System.Windows.Forms.Button()
        Me.cboSheet = New System.Windows.Forms.ComboBox()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.cmdGetFile = New System.Windows.Forms.Button()
        Me.lblFilename = New System.Windows.Forms.Label()
        Me.Dgrid = New System.Windows.Forms.DataGridView()
        Me.cntxActions = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuAddColumn = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuInsertColumn = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuRemoveColumn = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuReplicateValueDown = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuIncrement = New System.Windows.Forms.ToolStripMenuItem()
        Me.tableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.DGridReal = New System.Windows.Forms.DataGridView()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.lnkLast = New System.Windows.Forms.LinkLabel()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboState = New System.Windows.Forms.ComboBox()
        Me.Camp = New System.Windows.Forms.Label()
        Me.cCamp = New System.Windows.Forms.ComboBox()
        Me.cmdUpload = New System.Windows.Forms.Button()
        Me.lblListCount = New System.Windows.Forms.Label()
        Me.splitContainer1.Panel1.SuspendLayout()
        Me.splitContainer1.Panel2.SuspendLayout()
        Me.splitContainer1.SuspendLayout()
        Me.tableLayoutPanel1.SuspendLayout()
        Me.panel1.SuspendLayout()
        CType(Me.Dgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cntxActions.SuspendLayout()
        Me.tableLayoutPanel2.SuspendLayout()
        CType(Me.DGridReal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'splitContainer1
        '
        Me.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.splitContainer1.Name = "splitContainer1"
        Me.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitContainer1.Panel1
        '
        Me.splitContainer1.Panel1.Controls.Add(Me.tableLayoutPanel1)
        '
        'splitContainer1.Panel2
        '
        Me.splitContainer1.Panel2.Controls.Add(Me.tableLayoutPanel2)
        Me.splitContainer1.Size = New System.Drawing.Size(924, 563)
        Me.splitContainer1.SplitterDistance = 377
        Me.splitContainer1.TabIndex = 32
        '
        'tableLayoutPanel1
        '
        Me.tableLayoutPanel1.ColumnCount = 1
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel1.Controls.Add(Me.panel1, 0, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.Dgrid, 0, 1)
        Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 2
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(920, 373)
        Me.tableLayoutPanel1.TabIndex = 30
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.Goldenrod
        Me.panel1.Controls.Add(Me.lblCountUploadData)
        Me.panel1.Controls.Add(Me.cmdLoad)
        Me.panel1.Controls.Add(Me.cboSheet)
        Me.panel1.Controls.Add(Me.txtFileName)
        Me.panel1.Controls.Add(Me.cmdGetFile)
        Me.panel1.Controls.Add(Me.lblFilename)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel1.Location = New System.Drawing.Point(3, 3)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(914, 36)
        Me.panel1.TabIndex = 0
        '
        'lblCountUploadData
        '
        Me.lblCountUploadData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCountUploadData.AutoSize = True
        Me.lblCountUploadData.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.lblCountUploadData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountUploadData.ForeColor = System.Drawing.Color.Red
        Me.lblCountUploadData.Location = New System.Drawing.Point(760, 13)
        Me.lblCountUploadData.Name = "lblCountUploadData"
        Me.lblCountUploadData.Size = New System.Drawing.Size(14, 13)
        Me.lblCountUploadData.TabIndex = 589
        Me.lblCountUploadData.Text = "0"
        Me.lblCountUploadData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdLoad
        '
        Me.cmdLoad.Location = New System.Drawing.Point(681, 4)
        Me.cmdLoad.Name = "cmdLoad"
        Me.cmdLoad.Size = New System.Drawing.Size(50, 28)
        Me.cmdLoad.TabIndex = 30
        Me.cmdLoad.Text = "LOAD"
        Me.cmdLoad.UseVisualStyleBackColor = True
        Me.cmdLoad.Visible = False
        '
        'cboSheet
        '
        Me.cboSheet.FormattingEnabled = True
        Me.cboSheet.Location = New System.Drawing.Point(479, 9)
        Me.cboSheet.Name = "cboSheet"
        Me.cboSheet.Size = New System.Drawing.Size(198, 21)
        Me.cboSheet.TabIndex = 29
        '
        'txtFileName
        '
        Me.txtFileName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFileName.Location = New System.Drawing.Point(65, 8)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(379, 23)
        Me.txtFileName.TabIndex = 28
        '
        'cmdGetFile
        '
        Me.cmdGetFile.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGetFile.Location = New System.Drawing.Point(445, 7)
        Me.cmdGetFile.Name = "cmdGetFile"
        Me.cmdGetFile.Size = New System.Drawing.Size(24, 25)
        Me.cmdGetFile.TabIndex = 1
        Me.cmdGetFile.Text = "..."
        Me.cmdGetFile.UseVisualStyleBackColor = True
        '
        'lblFilename
        '
        Me.lblFilename.AutoSize = True
        Me.lblFilename.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilename.Location = New System.Drawing.Point(3, 11)
        Me.lblFilename.Name = "lblFilename"
        Me.lblFilename.Size = New System.Drawing.Size(60, 15)
        Me.lblFilename.TabIndex = 27
        Me.lblFilename.Text = "File Name"
        '
        'Dgrid
        '
        Me.Dgrid.AllowUserToAddRows = False
        Me.Dgrid.AllowUserToOrderColumns = True
        Me.Dgrid.BackgroundColor = System.Drawing.Color.Khaki
        Me.Dgrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Dgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgrid.ContextMenuStrip = Me.cntxActions
        Me.Dgrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgrid.Location = New System.Drawing.Point(3, 45)
        Me.Dgrid.Name = "Dgrid"
        Me.Dgrid.RowHeadersWidth = 23
        Me.Dgrid.Size = New System.Drawing.Size(914, 325)
        Me.Dgrid.TabIndex = 2
        '
        'cntxActions
        '
        Me.cntxActions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAddColumn, Me.ToolStripMenuItem1, Me.mnuInsertColumn, Me.toolStripSeparator1, Me.mnuRemoveColumn, Me.ToolStripMenuItem2, Me.mnuReplicateValueDown, Me.mnuIncrement})
        Me.cntxActions.Name = "ContextMenuStrip1"
        Me.cntxActions.Size = New System.Drawing.Size(195, 132)
        '
        'mnuAddColumn
        '
        Me.mnuAddColumn.Name = "mnuAddColumn"
        Me.mnuAddColumn.Size = New System.Drawing.Size(194, 22)
        Me.mnuAddColumn.Text = "Add Column"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(191, 6)
        '
        'mnuInsertColumn
        '
        Me.mnuInsertColumn.Name = "mnuInsertColumn"
        Me.mnuInsertColumn.Size = New System.Drawing.Size(194, 22)
        Me.mnuInsertColumn.Text = "Insert Column"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(191, 6)
        '
        'mnuRemoveColumn
        '
        Me.mnuRemoveColumn.Name = "mnuRemoveColumn"
        Me.mnuRemoveColumn.Size = New System.Drawing.Size(194, 22)
        Me.mnuRemoveColumn.Text = "Remove Column"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(191, 6)
        '
        'mnuReplicateValueDown
        '
        Me.mnuReplicateValueDown.Name = "mnuReplicateValueDown"
        Me.mnuReplicateValueDown.Size = New System.Drawing.Size(194, 22)
        Me.mnuReplicateValueDown.Text = "Replicate Value Down"
        '
        'mnuIncrement
        '
        Me.mnuIncrement.Name = "mnuIncrement"
        Me.mnuIncrement.Size = New System.Drawing.Size(194, 22)
        Me.mnuIncrement.Text = "Increment Value Down"
        '
        'tableLayoutPanel2
        '
        Me.tableLayoutPanel2.BackColor = System.Drawing.Color.Tan
        Me.tableLayoutPanel2.ColumnCount = 1
        Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel2.Controls.Add(Me.DGridReal, 0, 1)
        Me.tableLayoutPanel2.Controls.Add(Me.panel2, 0, 0)
        Me.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.tableLayoutPanel2.Name = "tableLayoutPanel2"
        Me.tableLayoutPanel2.RowCount = 2
        Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel2.Size = New System.Drawing.Size(920, 178)
        Me.tableLayoutPanel2.TabIndex = 32
        '
        'DGridReal
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.AntiqueWhite
        Me.DGridReal.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGridReal.BackgroundColor = System.Drawing.Color.Khaki
        Me.DGridReal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGridReal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FloralWhite
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGridReal.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGridReal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGridReal.Location = New System.Drawing.Point(3, 39)
        Me.DGridReal.Name = "DGridReal"
        Me.DGridReal.Size = New System.Drawing.Size(914, 136)
        Me.DGridReal.TabIndex = 8
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.Goldenrod
        Me.panel2.Controls.Add(Me.lnkLast)
        Me.panel2.Controls.Add(Me.cmdSave)
        Me.panel2.Controls.Add(Me.Panel3)
        Me.panel2.Controls.Add(Me.cmdUpload)
        Me.panel2.Controls.Add(Me.lblListCount)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel2.Location = New System.Drawing.Point(3, 3)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(914, 30)
        Me.panel2.TabIndex = 3
        '
        'lnkLast
        '
        Me.lnkLast.AutoSize = True
        Me.lnkLast.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkLast.Location = New System.Drawing.Point(655, 6)
        Me.lnkLast.Name = "lnkLast"
        Me.lnkLast.Size = New System.Drawing.Size(60, 17)
        Me.lnkLast.TabIndex = 593
        Me.lnkLast.TabStop = True
        Me.lnkLast.Text = "Last Sn:"
        '
        'cmdSave
        '
        Me.cmdSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.ForeColor = System.Drawing.Color.Red
        Me.cmdSave.Location = New System.Drawing.Point(381, -1)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(101, 30)
        Me.cmdSave.TabIndex = 591
        Me.cmdSave.Text = "UPDATE"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.cboState)
        Me.Panel3.Controls.Add(Me.Camp)
        Me.Panel3.Controls.Add(Me.cCamp)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(377, 30)
        Me.Panel3.TabIndex = 590
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(2, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 12)
        Me.Label3.TabIndex = 563
        Me.Label3.Text = "State:"
        '
        'cboState
        '
        Me.cboState.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboState.FormattingEnabled = True
        Me.cboState.Items.AddRange(New Object() {"LGA", "MDA"})
        Me.cboState.Location = New System.Drawing.Point(39, 3)
        Me.cboState.Name = "cboState"
        Me.cboState.Size = New System.Drawing.Size(143, 21)
        Me.cboState.TabIndex = 562
        '
        'Camp
        '
        Me.Camp.AutoSize = True
        Me.Camp.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Camp.ForeColor = System.Drawing.Color.Black
        Me.Camp.Location = New System.Drawing.Point(188, 8)
        Me.Camp.Name = "Camp"
        Me.Camp.Size = New System.Drawing.Size(30, 12)
        Me.Camp.TabIndex = 561
        Me.Camp.Text = "Camp"
        '
        'cCamp
        '
        Me.cCamp.DropDownWidth = 243
        Me.cCamp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cCamp.FormattingEnabled = True
        Me.cCamp.Location = New System.Drawing.Point(226, 3)
        Me.cCamp.Name = "cCamp"
        Me.cCamp.Size = New System.Drawing.Size(143, 21)
        Me.cCamp.TabIndex = 560
        '
        'cmdUpload
        '
        Me.cmdUpload.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdUpload.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpload.ForeColor = System.Drawing.Color.Black
        Me.cmdUpload.Location = New System.Drawing.Point(780, 0)
        Me.cmdUpload.Name = "cmdUpload"
        Me.cmdUpload.Size = New System.Drawing.Size(134, 30)
        Me.cmdUpload.TabIndex = 589
        Me.cmdUpload.Text = "Upload Data"
        Me.cmdUpload.UseVisualStyleBackColor = True
        '
        'lblListCount
        '
        Me.lblListCount.AutoSize = True
        Me.lblListCount.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.lblListCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListCount.ForeColor = System.Drawing.Color.Red
        Me.lblListCount.Location = New System.Drawing.Point(514, 10)
        Me.lblListCount.Name = "lblListCount"
        Me.lblListCount.Size = New System.Drawing.Size(14, 13)
        Me.lblListCount.TabIndex = 588
        Me.lblListCount.Text = "0"
        Me.lblListCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmImportData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(924, 563)
        Me.Controls.Add(Me.splitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmImportData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import Data"
        Me.splitContainer1.Panel1.ResumeLayout(False)
        Me.splitContainer1.Panel2.ResumeLayout(False)
        Me.splitContainer1.ResumeLayout(False)
        Me.tableLayoutPanel1.ResumeLayout(False)
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.Dgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cntxActions.ResumeLayout(False)
        Me.tableLayoutPanel2.ResumeLayout(False)
        CType(Me.DGridReal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents splitContainer1 As System.Windows.Forms.SplitContainer
    Private WithEvents tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents cmdLoad As System.Windows.Forms.Button
    Private WithEvents cboSheet As System.Windows.Forms.ComboBox
    Private WithEvents txtFileName As System.Windows.Forms.TextBox
    Private WithEvents cmdGetFile As System.Windows.Forms.Button
    Private WithEvents lblFilename As System.Windows.Forms.Label
    Private WithEvents Dgrid As System.Windows.Forms.DataGridView
    Private WithEvents tableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Private WithEvents DGridReal As System.Windows.Forms.DataGridView
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Private WithEvents cmdUpload As System.Windows.Forms.Button
    Friend WithEvents lblListCount As System.Windows.Forms.Label
    Friend WithEvents cntxActions As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuAddColumn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents mnuInsertColumn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuRemoveColumn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboState As System.Windows.Forms.ComboBox
    Friend WithEvents Camp As System.Windows.Forms.Label
    Friend WithEvents cCamp As System.Windows.Forms.ComboBox
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents lnkLast As System.Windows.Forms.LinkLabel
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuReplicateValueDown As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuIncrement As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblCountUploadData As System.Windows.Forms.Label
End Class
