<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStipends
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmStipends))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tblHeader = New System.Windows.Forms.TableLayoutPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblLBPeriod = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboState = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cCamp = New System.Windows.Forms.ComboBox()
        Me.cMonth = New System.Windows.Forms.ComboBox()
        Me.cYear = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTotalPayable = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTotalNoStopPay = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblTotalNo = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblNet = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblSTOP = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblGross = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.DGridList = New System.Windows.Forms.DataGridView()
        Me.Code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemAttribute = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.State = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Payitem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PFA = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.tblHeader.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1112, 587)
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
        Me.Label7.Text = "STIPENDS POSTINGS"
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
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(243, 525)
        Me.TableLayoutPanel3.TabIndex = 53
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.cboState)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.cCamp)
        Me.Panel2.Controls.Add(Me.cMonth)
        Me.Panel2.Controls.Add(Me.cYear)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(237, 77)
        Me.Panel2.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(-1, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 15)
        Me.Label3.TabIndex = 563
        Me.Label3.Text = "State:"
        '
        'cboState
        '
        Me.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboState.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboState.FormattingEnabled = True
        Me.cboState.Items.AddRange(New Object() {"LGA", "MDA"})
        Me.cboState.Location = New System.Drawing.Point(49, 0)
        Me.cboState.Name = "cboState"
        Me.cboState.Size = New System.Drawing.Size(184, 21)
        Me.cboState.TabIndex = 562
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(-1, 28)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 15)
        Me.Label13.TabIndex = 561
        Me.Label13.Text = "Camp:"
        '
        'cCamp
        '
        Me.cCamp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cCamp.DropDownWidth = 243
        Me.cCamp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cCamp.FormattingEnabled = True
        Me.cCamp.Location = New System.Drawing.Point(49, 24)
        Me.cCamp.Name = "cCamp"
        Me.cCamp.Size = New System.Drawing.Size(184, 21)
        Me.cCamp.TabIndex = 560
        '
        'cMonth
        '
        Me.cMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cMonth.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cMonth.FormattingEnabled = True
        Me.cMonth.Items.AddRange(New Object() {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"})
        Me.cMonth.Location = New System.Drawing.Point(49, 48)
        Me.cMonth.Name = "cMonth"
        Me.cMonth.Size = New System.Drawing.Size(78, 23)
        Me.cMonth.TabIndex = 218
        '
        'cYear
        '
        Me.cYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cYear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cYear.FormattingEnabled = True
        Me.cYear.Location = New System.Drawing.Point(134, 48)
        Me.cYear.Name = "cYear"
        Me.cYear.Size = New System.Drawing.Size(99, 23)
        Me.cYear.TabIndex = 215
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(-1, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 23)
        Me.Label2.TabIndex = 216
        Me.Label2.Text = "Period:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblTotalPayable)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.lblTotalNoStopPay)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.lblTotalNo)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.lblNet)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.lblSTOP)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.lblGross)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel7)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 86)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(237, 436)
        Me.Panel1.TabIndex = 55
        '
        'lblTotalPayable
        '
        Me.lblTotalPayable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalPayable.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPayable.ForeColor = System.Drawing.Color.DarkRed
        Me.lblTotalPayable.Location = New System.Drawing.Point(118, 209)
        Me.lblTotalPayable.Name = "lblTotalPayable"
        Me.lblTotalPayable.Size = New System.Drawing.Size(69, 22)
        Me.lblTotalPayable.TabIndex = 74
        Me.lblTotalPayable.Text = "0"
        Me.lblTotalPayable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 212)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 15)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "TOTAL No PAYABLE:"
        '
        'lblTotalNoStopPay
        '
        Me.lblTotalNoStopPay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalNoStopPay.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalNoStopPay.ForeColor = System.Drawing.Color.DarkRed
        Me.lblTotalNoStopPay.Location = New System.Drawing.Point(118, 185)
        Me.lblTotalNoStopPay.Name = "lblTotalNoStopPay"
        Me.lblTotalNoStopPay.Size = New System.Drawing.Size(69, 19)
        Me.lblTotalNoStopPay.TabIndex = 72
        Me.lblTotalNoStopPay.Text = "0"
        Me.lblTotalNoStopPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(2, 190)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 15)
        Me.Label10.TabIndex = 71
        Me.Label10.Text = "TOTAL No STOP PAY:"
        '
        'lblTotalNo
        '
        Me.lblTotalNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalNo.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalNo.ForeColor = System.Drawing.Color.DarkRed
        Me.lblTotalNo.Location = New System.Drawing.Point(119, 161)
        Me.lblTotalNo.Name = "lblTotalNo"
        Me.lblTotalNo.Size = New System.Drawing.Size(67, 19)
        Me.lblTotalNo.TabIndex = 70
        Me.lblTotalNo.Text = "0"
        Me.lblTotalNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(2, 169)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 15)
        Me.Label12.TabIndex = 69
        Me.Label12.Text = "TOTAL No:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(1, 131)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(230, 11)
        Me.GroupBox1.TabIndex = 68
        Me.GroupBox1.TabStop = False
        '
        'lblNet
        '
        Me.lblNet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNet.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNet.ForeColor = System.Drawing.Color.DarkRed
        Me.lblNet.Location = New System.Drawing.Point(119, 80)
        Me.lblNet.Name = "lblNet"
        Me.lblNet.Size = New System.Drawing.Size(113, 38)
        Me.lblNet.TabIndex = 67
        Me.lblNet.Text = "0.0"
        Me.lblNet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(4, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 15)
        Me.Label8.TabIndex = 66
        Me.Label8.Text = "TOTAL PAYABLE"
        '
        'lblSTOP
        '
        Me.lblSTOP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSTOP.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSTOP.ForeColor = System.Drawing.Color.DarkRed
        Me.lblSTOP.Location = New System.Drawing.Point(119, 43)
        Me.lblSTOP.Name = "lblSTOP"
        Me.lblSTOP.Size = New System.Drawing.Size(113, 34)
        Me.lblSTOP.TabIndex = 65
        Me.lblSTOP.Text = "0.0"
        Me.lblSTOP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 15)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "TOTAL STOP PAY"
        '
        'lblGross
        '
        Me.lblGross.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGross.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGross.ForeColor = System.Drawing.Color.DarkRed
        Me.lblGross.Location = New System.Drawing.Point(119, 6)
        Me.lblGross.Name = "lblGross"
        Me.lblGross.Size = New System.Drawing.Size(113, 34)
        Me.lblGross.TabIndex = 60
        Me.lblGross.Text = "0.0"
        Me.lblGross.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 15)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "TOTAL"
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset
        Me.TableLayoutPanel7.ColumnCount = 1
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.cmdClose, 0, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(0, 363)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(235, 71)
        Me.TableLayoutPanel7.TabIndex = 58
        '
        'cmdClose
        '
        Me.cmdClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdClose.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdClose.Location = New System.Drawing.Point(5, 5)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(225, 69)
        Me.cmdClose.TabIndex = 41
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'DGridList
        '
        Me.DGridList.AllowUserToAddRows = False
        Me.DGridList.AllowUserToDeleteRows = False
        Me.DGridList.AllowUserToOrderColumns = True
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
        Me.DGridList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Code, Me.Type, Me.ItemAttribute, Me.State, Me.Payitem, Me.PFA, Me.Amount})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGridList.DefaultCellStyle = DataGridViewCellStyle10
        Me.DGridList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGridList.GridColor = System.Drawing.Color.RoyalBlue
        Me.DGridList.Location = New System.Drawing.Point(246, 65)
        Me.DGridList.Name = "DGridList"
        Me.DGridList.ReadOnly = True
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGridList.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.DGridList.RowHeadersWidth = 15
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGridList.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.DGridList.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGridList.Size = New System.Drawing.Size(863, 519)
        Me.DGridList.TabIndex = 54
        '
        'Code
        '
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LightCyan
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Code.DefaultCellStyle = DataGridViewCellStyle3
        Me.Code.HeaderText = "Sn"
        Me.Code.Name = "Code"
        Me.Code.ReadOnly = True
        Me.Code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Code.Width = 40
        '
        'Type
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.LightCyan
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Type.DefaultCellStyle = DataGridViewCellStyle4
        Me.Type.HeaderText = "Name"
        Me.Type.Name = "Type"
        Me.Type.ReadOnly = True
        Me.Type.Width = 180
        '
        'ItemAttribute
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.LightCyan
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ItemAttribute.DefaultCellStyle = DataGridViewCellStyle5
        Me.ItemAttribute.HeaderText = "Bank"
        Me.ItemAttribute.Name = "ItemAttribute"
        Me.ItemAttribute.ReadOnly = True
        Me.ItemAttribute.Width = 180
        '
        'State
        '
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.LightCyan
        Me.State.DefaultCellStyle = DataGridViewCellStyle6
        Me.State.HeaderText = "State"
        Me.State.Name = "State"
        Me.State.ReadOnly = True
        Me.State.Width = 120
        '
        'Payitem
        '
        Me.Payitem.DataPropertyName = "PSN"
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.LightCyan
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Payitem.DefaultCellStyle = DataGridViewCellStyle7
        Me.Payitem.HeaderText = "Camp"
        Me.Payitem.Name = "Payitem"
        Me.Payitem.ReadOnly = True
        Me.Payitem.Width = 120
        '
        'PFA
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.LightCyan
        DataGridViewCellStyle8.NullValue = False
        Me.PFA.DefaultCellStyle = DataGridViewCellStyle8
        Me.PFA.HeaderText = "StopPay"
        Me.PFA.Name = "PFA"
        Me.PFA.ReadOnly = True
        Me.PFA.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PFA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.PFA.Width = 80
        '
        'Amount
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = "0"
        Me.Amount.DefaultCellStyle = DataGridViewCellStyle9
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        Me.Amount.ReadOnly = True
        Me.Amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'FrmStipends
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(1112, 587)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmStipends"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "STIPENDS POSTINGS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.tblHeader.ResumeLayout(False)
        Me.tblHeader.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        CType(Me.DGridList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tblHeader As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblLBPeriod As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cYear As System.Windows.Forms.ComboBox
    Friend WithEvents DGridList As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblGross As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel7 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cMonth As System.Windows.Forms.ComboBox
    Friend WithEvents cboState As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cCamp As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemAttribute As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents State As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Payitem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PFA As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblNet As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblSTOP As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblTotalPayable As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblTotalNoStopPay As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblTotalNo As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
