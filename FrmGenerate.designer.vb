<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGenerate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGenerate))
        Me.GrpTax = New System.Windows.Forms.GroupBox()
        Me.txt = New System.Windows.Forms.TextBox()
        Me.cmdPayPeriod = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdGenerate = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.pbProgress = New System.Windows.Forms.ProgressBar()
        Me.lblActivity = New System.Windows.Forms.Label()
        Me.tblHeader = New System.Windows.Forms.TableLayoutPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PanAmt = New System.Windows.Forms.Panel()
        Me.tAmount = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrpTax.SuspendLayout()
        Me.tblHeader.SuspendLayout()
        Me.PanAmt.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpTax
        '
        Me.GrpTax.Controls.Add(Me.txt)
        Me.GrpTax.Controls.Add(Me.cmdPayPeriod)
        Me.GrpTax.Controls.Add(Me.Label6)
        Me.GrpTax.Location = New System.Drawing.Point(30, 63)
        Me.GrpTax.Name = "GrpTax"
        Me.GrpTax.Size = New System.Drawing.Size(214, 41)
        Me.GrpTax.TabIndex = 54
        Me.GrpTax.TabStop = False
        '
        'txt
        '
        Me.txt.Location = New System.Drawing.Point(62, 13)
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(120, 20)
        Me.txt.TabIndex = 50
        '
        'cmdPayPeriod
        '
        Me.cmdPayPeriod.Location = New System.Drawing.Point(182, 13)
        Me.cmdPayPeriod.Name = "cmdPayPeriod"
        Me.cmdPayPeriod.Size = New System.Drawing.Size(25, 21)
        Me.cmdPayPeriod.TabIndex = 51
        Me.cmdPayPeriod.Text = "..."
        Me.cmdPayPeriod.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Pay Period:"
        '
        'cmdGenerate
        '
        Me.cmdGenerate.Location = New System.Drawing.Point(28, 121)
        Me.cmdGenerate.Name = "cmdGenerate"
        Me.cmdGenerate.Size = New System.Drawing.Size(138, 37)
        Me.cmdGenerate.TabIndex = 55
        Me.cmdGenerate.Text = "&Generate Payroll"
        Me.cmdGenerate.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(171, 121)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(73, 37)
        Me.cmdClose.TabIndex = 56
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'pbProgress
        '
        Me.pbProgress.Location = New System.Drawing.Point(30, 108)
        Me.pbProgress.Name = "pbProgress"
        Me.pbProgress.Size = New System.Drawing.Size(213, 11)
        Me.pbProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.pbProgress.TabIndex = 57
        Me.pbProgress.Visible = False
        '
        'lblActivity
        '
        Me.lblActivity.ForeColor = System.Drawing.Color.Red
        Me.lblActivity.Location = New System.Drawing.Point(24, 52)
        Me.lblActivity.Name = "lblActivity"
        Me.lblActivity.Size = New System.Drawing.Size(223, 13)
        Me.lblActivity.TabIndex = 58
        Me.lblActivity.Text = "Click to start..."
        Me.lblActivity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.tblHeader.Size = New System.Drawing.Size(274, 46)
        Me.tblHeader.TabIndex = 59
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Goldenrod
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(274, 25)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "COMPUTE"
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
        Me.Label8.Location = New System.Drawing.Point(0, 25)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(274, 21)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "-"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanAmt
        '
        Me.PanAmt.BackColor = System.Drawing.Color.Goldenrod
        Me.PanAmt.Controls.Add(Me.tAmount)
        Me.PanAmt.Controls.Add(Me.Label1)
        Me.PanAmt.Location = New System.Drawing.Point(76, 160)
        Me.PanAmt.Name = "PanAmt"
        Me.PanAmt.Size = New System.Drawing.Size(167, 24)
        Me.PanAmt.TabIndex = 60
        Me.PanAmt.Visible = False
        '
        'tAmount
        '
        Me.tAmount.BackColor = System.Drawing.Color.Khaki
        Me.tAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tAmount.Location = New System.Drawing.Point(92, 2)
        Me.tAmount.Name = "tAmount"
        Me.tAmount.Size = New System.Drawing.Size(70, 20)
        Me.tAmount.TabIndex = 52
        Me.tAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(9, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Period Amount:"
        '
        'FrmGenerate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(274, 185)
        Me.Controls.Add(Me.PanAmt)
        Me.Controls.Add(Me.tblHeader)
        Me.Controls.Add(Me.lblActivity)
        Me.Controls.Add(Me.pbProgress)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdGenerate)
        Me.Controls.Add(Me.GrpTax)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmGenerate"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compute Stipends"
        Me.TopMost = True
        Me.GrpTax.ResumeLayout(False)
        Me.GrpTax.PerformLayout()
        Me.tblHeader.ResumeLayout(False)
        Me.tblHeader.PerformLayout()
        Me.PanAmt.ResumeLayout(False)
        Me.PanAmt.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpTax As System.Windows.Forms.GroupBox
    Friend WithEvents txt As System.Windows.Forms.TextBox
    Friend WithEvents cmdPayPeriod As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdGenerate As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents pbProgress As System.Windows.Forms.ProgressBar
    Friend WithEvents lblActivity As System.Windows.Forms.Label
    Friend WithEvents tblHeader As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PanAmt As System.Windows.Forms.Panel
    Friend WithEvents tAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
