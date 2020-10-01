<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistration
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRegistration))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tblHeader = New System.Windows.Forms.TableLayoutPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblLBPeriod = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboState = New System.Windows.Forms.ComboBox()
        Me.Camp = New System.Windows.Forms.Label()
        Me.cCamp = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdUpdateBankCode = New System.Windows.Forms.Button()
        Me.cmdCleanUp = New System.Windows.Forms.Button()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cboCriteria = New System.Windows.Forms.ComboBox()
        Me.cmdFind = New System.Windows.Forms.Button()
        Me.tFilterText2 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkPaste = New System.Windows.Forms.CheckBox()
        Me.cPaste = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdPaste = New System.Windows.Forms.Button()
        Me.txt = New System.Windows.Forms.TextBox()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdNew = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdUpdateBank = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboBank = New System.Windows.Forms.ComboBox()
        Me.cmdRefresh = New System.Windows.Forms.Button()
        Me.lnkBank = New System.Windows.Forms.LinkLabel()
        Me.DGridList = New System.Windows.Forms.DataGridView()
        Me.chkSelectAll = New System.Windows.Forms.CheckBox()
        Me.Sn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.State = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Camp1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bank1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Account = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SortCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoOfDelegate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StopPay = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Remark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Phone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Leader = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.tblHeader.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGridList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.tblHeader, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DGridList, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1112, 678)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'tblHeader
        '
        Me.tblHeader.BackColor = System.Drawing.Color.MintCream
        Me.tblHeader.ColumnCount = 1
        Me.TableLayoutPanel1.SetColumnSpan(Me.tblHeader, 2)
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblHeader.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblHeader.Controls.Add(Me.Label7, 0, 0)
        Me.tblHeader.Controls.Add(Me.lblLBPeriod, 0, 1)
        Me.tblHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.tblHeader.Location = New System.Drawing.Point(0, 0)
        Me.tblHeader.Margin = New System.Windows.Forms.Padding(0)
        Me.tblHeader.Name = "tblHeader"
        Me.tblHeader.RowCount = 2
        Me.tblHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.76923!))
        Me.tblHeader.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.23077!))
        Me.tblHeader.Size = New System.Drawing.Size(1112, 62)
        Me.tblHeader.TabIndex = 50
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Goldenrod
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Khaki
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(1112, 34)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "BENEFICIARY LISTINGS"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLBPeriod
        '
        Me.lblLBPeriod.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLBPeriod.AutoSize = True
        Me.lblLBPeriod.BackColor = System.Drawing.Color.GhostWhite
        Me.lblLBPeriod.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLBPeriod.ForeColor = System.Drawing.Color.Goldenrod
        Me.lblLBPeriod.Location = New System.Drawing.Point(0, 34)
        Me.lblLBPeriod.Margin = New System.Windows.Forms.Padding(0)
        Me.lblLBPeriod.Name = "lblLBPeriod"
        Me.lblLBPeriod.Size = New System.Drawing.Size(1112, 28)
        Me.lblLBPeriod.TabIndex = 1
        Me.lblLBPeriod.Text = "-"
        Me.lblLBPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 62)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(192, 616)
        Me.TableLayoutPanel3.TabIndex = 53
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.cboState)
        Me.Panel2.Controls.Add(Me.Camp)
        Me.Panel2.Controls.Add(Me.cCamp)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(186, 53)
        Me.Panel2.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(2, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 12)
        Me.Label3.TabIndex = 563
        Me.Label3.Text = "State:"
        '
        'cboState
        '
        Me.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboState.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboState.FormattingEnabled = True
        Me.cboState.Items.AddRange(New Object() {"LGA", "MDA"})
        Me.cboState.Location = New System.Drawing.Point(39, 0)
        Me.cboState.Name = "cboState"
        Me.cboState.Size = New System.Drawing.Size(143, 21)
        Me.cboState.TabIndex = 562
        '
        'Camp
        '
        Me.Camp.AutoSize = True
        Me.Camp.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Camp.ForeColor = System.Drawing.Color.Black
        Me.Camp.Location = New System.Drawing.Point(1, 29)
        Me.Camp.Name = "Camp"
        Me.Camp.Size = New System.Drawing.Size(30, 12)
        Me.Camp.TabIndex = 561
        Me.Camp.Text = "Camp"
        '
        'cCamp
        '
        Me.cCamp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cCamp.DropDownWidth = 243
        Me.cCamp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cCamp.FormattingEnabled = True
        Me.cCamp.Location = New System.Drawing.Point(39, 24)
        Me.cCamp.Name = "cCamp"
        Me.cCamp.Size = New System.Drawing.Size(143, 21)
        Me.cCamp.TabIndex = 560
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmdUpdateBankCode)
        Me.Panel1.Controls.Add(Me.cmdCleanUp)
        Me.Panel1.Controls.Add(Me.lblCount)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.cmdClose)
        Me.Panel1.Controls.Add(Me.cmdSave)
        Me.Panel1.Controls.Add(Me.cmdNew)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.cmdRefresh)
        Me.Panel1.Controls.Add(Me.lnkBank)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 62)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(186, 551)
        Me.Panel1.TabIndex = 5
        '
        'cmdUpdateBankCode
        '
        Me.cmdUpdateBankCode.Location = New System.Drawing.Point(60, 460)
        Me.cmdUpdateBankCode.Name = "cmdUpdateBankCode"
        Me.cmdUpdateBankCode.Size = New System.Drawing.Size(124, 23)
        Me.cmdUpdateBankCode.TabIndex = 572
        Me.cmdUpdateBankCode.Text = "UPDATE BANK CODE"
        Me.cmdUpdateBankCode.UseVisualStyleBackColor = True
        '
        'cmdCleanUp
        '
        Me.cmdCleanUp.Location = New System.Drawing.Point(91, 489)
        Me.cmdCleanUp.Name = "cmdCleanUp"
        Me.cmdCleanUp.Size = New System.Drawing.Size(93, 23)
        Me.cmdCleanUp.TabIndex = 19
        Me.cmdCleanUp.Text = "CLEAN DATA"
        Me.cmdCleanUp.UseVisualStyleBackColor = True
        '
        'lblCount
        '
        Me.lblCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.Location = New System.Drawing.Point(54, 490)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(122, 23)
        Me.lblCount.TabIndex = 571
        Me.lblCount.Text = "0"
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(3, 488)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 23)
        Me.Label4.TabIndex = 570
        Me.Label4.Text = "List Count"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Khaki
        Me.GroupBox4.Controls.Add(Me.cboCriteria)
        Me.GroupBox4.Controls.Add(Me.cmdFind)
        Me.GroupBox4.Controls.Add(Me.tFilterText2)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Location = New System.Drawing.Point(5, 365)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(179, 88)
        Me.GroupBox4.TabIndex = 569
        Me.GroupBox4.TabStop = False
        '
        'cboCriteria
        '
        Me.cboCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCriteria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboCriteria.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCriteria.FormattingEnabled = True
        Me.cboCriteria.Items.AddRange(New Object() {"=", "Containing", "Start With", "End With"})
        Me.cboCriteria.Location = New System.Drawing.Point(66, 13)
        Me.cboCriteria.Name = "cboCriteria"
        Me.cboCriteria.Size = New System.Drawing.Size(82, 20)
        Me.cboCriteria.TabIndex = 18
        '
        'cmdFind
        '
        Me.cmdFind.Location = New System.Drawing.Point(55, 61)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(73, 22)
        Me.cmdFind.TabIndex = 16
        Me.cmdFind.Text = "Find"
        Me.cmdFind.UseVisualStyleBackColor = True
        '
        'tFilterText2
        '
        Me.tFilterText2.Location = New System.Drawing.Point(7, 38)
        Me.tFilterText2.Name = "tFilterText2"
        Me.tFilterText2.Size = New System.Drawing.Size(165, 20)
        Me.tFilterText2.TabIndex = 14
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label12.Location = New System.Drawing.Point(5, 11)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 23)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Find Name"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkPaste)
        Me.GroupBox2.Controls.Add(Me.cPaste)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cmdPaste)
        Me.GroupBox2.Controls.Add(Me.txt)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 260)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(173, 102)
        Me.GroupBox2.TabIndex = 568
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PASTE DATA"
        '
        'chkPaste
        '
        Me.chkPaste.AutoSize = True
        Me.chkPaste.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPaste.ForeColor = System.Drawing.Color.Red
        Me.chkPaste.Location = New System.Drawing.Point(7, 61)
        Me.chkPaste.Name = "chkPaste"
        Me.chkPaste.Size = New System.Drawing.Size(98, 16)
        Me.chkPaste.TabIndex = 570
        Me.chkPaste.Text = "Paste as new row"
        Me.chkPaste.UseVisualStyleBackColor = True
        Me.chkPaste.Visible = False
        '
        'cPaste
        '
        Me.cPaste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cPaste.DropDownWidth = 200
        Me.cPaste.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cPaste.FormattingEnabled = True
        Me.cPaste.Items.AddRange(New Object() {"SN", "Name", "State", "Camp", "Bank", "BankAcctNo", "SortCode", "NoofDelegate"})
        Me.cPaste.Location = New System.Drawing.Point(6, 35)
        Me.cPaste.Name = "cPaste"
        Me.cPaste.Size = New System.Drawing.Size(163, 21)
        Me.cPaste.TabIndex = 565
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(4, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 12)
        Me.Label2.TabIndex = 566
        Me.Label2.Text = "Column to Paste"
        '
        'cmdPaste
        '
        Me.cmdPaste.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmdPaste.Location = New System.Drawing.Point(3, 61)
        Me.cmdPaste.Name = "cmdPaste"
        Me.cmdPaste.Size = New System.Drawing.Size(167, 38)
        Me.cmdPaste.TabIndex = 566
        Me.cmdPaste.Text = "Paste Clipboard"
        Me.cmdPaste.UseVisualStyleBackColor = True
        '
        'txt
        '
        Me.txt.Location = New System.Drawing.Point(78, 8)
        Me.txt.Multiline = True
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(47, 22)
        Me.txt.TabIndex = 568
        Me.txt.Visible = False
        '
        'cmdClose
        '
        Me.cmdClose.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmdClose.Location = New System.Drawing.Point(0, 513)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(186, 38)
        Me.cmdClose.TabIndex = 12
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdSave.Location = New System.Drawing.Point(0, 76)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(186, 38)
        Me.cmdSave.TabIndex = 11
        Me.cmdSave.Text = "Update"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdNew
        '
        Me.cmdNew.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdNew.Location = New System.Drawing.Point(0, 38)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(186, 38)
        Me.cmdNew.TabIndex = 10
        Me.cmdNew.Text = "New"
        Me.cmdNew.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdUpdateBank)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboBank)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 148)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(178, 107)
        Me.GroupBox1.TabIndex = 55
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MULTI-BANK CHANGE"
        '
        'cmdUpdateBank
        '
        Me.cmdUpdateBank.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmdUpdateBank.Location = New System.Drawing.Point(3, 66)
        Me.cmdUpdateBank.Name = "cmdUpdateBank"
        Me.cmdUpdateBank.Size = New System.Drawing.Size(172, 38)
        Me.cmdUpdateBank.TabIndex = 565
        Me.cmdUpdateBank.Text = "Update Bank"
        Me.cmdUpdateBank.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(6, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 12)
        Me.Label1.TabIndex = 564
        Me.Label1.Text = "BANK"
        '
        'cboBank
        '
        Me.cboBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBank.DropDownWidth = 200
        Me.cboBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboBank.FormattingEnabled = True
        Me.cboBank.Location = New System.Drawing.Point(8, 36)
        Me.cboBank.Name = "cboBank"
        Me.cboBank.Size = New System.Drawing.Size(163, 21)
        Me.cboBank.TabIndex = 563
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdRefresh.Location = New System.Drawing.Point(0, 0)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(186, 38)
        Me.cmdRefresh.TabIndex = 8
        Me.cmdRefresh.Text = "Refresh"
        Me.cmdRefresh.UseVisualStyleBackColor = True
        '
        'lnkBank
        '
        Me.lnkBank.AutoSize = True
        Me.lnkBank.Location = New System.Drawing.Point(3, 126)
        Me.lnkBank.Name = "lnkBank"
        Me.lnkBank.Size = New System.Drawing.Size(32, 13)
        Me.lnkBank.TabIndex = 7
        Me.lnkBank.TabStop = True
        Me.lnkBank.Text = "Bank"
        Me.lnkBank.Visible = False
        '
        'DGridList
        '
        Me.DGridList.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.GhostWhite
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGridList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGridList.BackgroundColor = System.Drawing.Color.Khaki
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGridList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGridList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGridList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Sn, Me.tName, Me.State, Me.Camp1, Me.Bank1, Me.Account, Me.SortCode, Me.NoOfDelegate, Me.StopPay, Me.Remark, Me.IDNo, Me.Phone, Me.Leader})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Khaki
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGridList.DefaultCellStyle = DataGridViewCellStyle4
        Me.DGridList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGridList.GridColor = System.Drawing.Color.RoyalBlue
        Me.DGridList.Location = New System.Drawing.Point(195, 65)
        Me.DGridList.Name = "DGridList"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGridList.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DGridList.RowHeadersWidth = 15
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGridList.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DGridList.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGridList.Size = New System.Drawing.Size(914, 610)
        Me.DGridList.TabIndex = 54
        '
        'chkSelectAll
        '
        Me.chkSelectAll.AutoSize = True
        Me.chkSelectAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSelectAll.ForeColor = System.Drawing.Color.Red
        Me.chkSelectAll.Location = New System.Drawing.Point(1039, 43)
        Me.chkSelectAll.Name = "chkSelectAll"
        Me.chkSelectAll.Size = New System.Drawing.Size(61, 16)
        Me.chkSelectAll.TabIndex = 571
        Me.chkSelectAll.Text = "Select all"
        Me.chkSelectAll.UseVisualStyleBackColor = True
        '
        'Sn
        '
        Me.Sn.DataPropertyName = "Sn"
        Me.Sn.HeaderText = "SN"
        Me.Sn.Name = "Sn"
        Me.Sn.Width = 50
        '
        'tName
        '
        Me.tName.DataPropertyName = "Name"
        Me.tName.HeaderText = "Name"
        Me.tName.Name = "tName"
        Me.tName.Width = 200
        '
        'State
        '
        Me.State.DataPropertyName = "State"
        Me.State.HeaderText = "State"
        Me.State.Name = "State"
        Me.State.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.State.Width = 120
        '
        'Camp1
        '
        Me.Camp1.DataPropertyName = "Camp"
        Me.Camp1.HeaderText = "Camp"
        Me.Camp1.Name = "Camp1"
        Me.Camp1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Camp1.Width = 120
        '
        'Bank1
        '
        Me.Bank1.DataPropertyName = "Bank"
        Me.Bank1.FillWeight = 200.0!
        Me.Bank1.HeaderText = "Bank"
        Me.Bank1.Name = "Bank1"
        Me.Bank1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Bank1.Width = 150
        '
        'Account
        '
        Me.Account.DataPropertyName = "BankAcctNo"
        Me.Account.HeaderText = "BankAcctNo"
        Me.Account.Name = "Account"
        '
        'SortCode
        '
        Me.SortCode.DataPropertyName = "SortCode"
        Me.SortCode.HeaderText = "SortCode"
        Me.SortCode.Name = "SortCode"
        '
        'NoOfDelegate
        '
        Me.NoOfDelegate.DataPropertyName = "NoOfDelegate"
        Me.NoOfDelegate.HeaderText = "No Of Delegate"
        Me.NoOfDelegate.Name = "NoOfDelegate"
        '
        'StopPay
        '
        Me.StopPay.DataPropertyName = "StopPay"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.StopPay.DefaultCellStyle = DataGridViewCellStyle3
        Me.StopPay.HeaderText = "StopPay"
        Me.StopPay.Name = "StopPay"
        Me.StopPay.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.StopPay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.StopPay.Width = 80
        '
        'Remark
        '
        Me.Remark.DataPropertyName = "Remark"
        Me.Remark.HeaderText = "Remark"
        Me.Remark.Name = "Remark"
        Me.Remark.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'IDNo
        '
        Me.IDNo.DataPropertyName = "IDNo"
        Me.IDNo.HeaderText = "IDNo"
        Me.IDNo.Name = "IDNo"
        Me.IDNo.Width = 50
        '
        'Phone
        '
        Me.Phone.DataPropertyName = "Phone"
        Me.Phone.HeaderText = "Phone"
        Me.Phone.Name = "Phone"
        Me.Phone.Width = 50
        '
        'Leader
        '
        Me.Leader.DataPropertyName = "Leader"
        Me.Leader.HeaderText = "Leader"
        Me.Leader.Name = "Leader"
        '
        'FrmRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(1112, 678)
        Me.Controls.Add(Me.chkSelectAll)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmRegistration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Beneficiary Information"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.tblHeader.ResumeLayout(False)
        Me.tblHeader.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGridList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tblHeader As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblLBPeriod As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents DGridList As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cboState As System.Windows.Forms.ComboBox
    Friend WithEvents Camp As System.Windows.Forms.Label
    Friend WithEvents cCamp As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lnkBank As System.Windows.Forms.LinkLabel
    Friend WithEvents cmdRefresh As System.Windows.Forms.Button
    Friend WithEvents cmdNew As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboBank As System.Windows.Forms.ComboBox
    Friend WithEvents cmdUpdateBank As System.Windows.Forms.Button
    Friend WithEvents cmdPaste As System.Windows.Forms.Button
    Friend WithEvents txt As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cPaste As System.Windows.Forms.ComboBox
    Friend WithEvents chkPaste As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cboCriteria As System.Windows.Forms.ComboBox
    Friend WithEvents cmdFind As System.Windows.Forms.Button
    Friend WithEvents tFilterText2 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkSelectAll As System.Windows.Forms.CheckBox
    Friend WithEvents cmdCleanUp As System.Windows.Forms.Button
    Friend WithEvents cmdUpdateBankCode As System.Windows.Forms.Button
    Friend WithEvents Sn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents State As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Camp1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Bank1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Account As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SortCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoOfDelegate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StopPay As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Remark As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Phone As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Leader As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
