<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPayDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPayDetails))
        Me.tblHeader = New System.Windows.Forms.TableLayoutPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.txt = New System.Windows.Forms.TextBox()
        Me.cmdPayPeriod = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.GrpTax = New System.Windows.Forms.GroupBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tMandateNo = New System.Windows.Forms.TextBox()
        Me.tblHeader.SuspendLayout()
        Me.GrpTax.SuspendLayout()
        Me.SuspendLayout()
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
        Me.tblHeader.Size = New System.Drawing.Size(224, 46)
        Me.tblHeader.TabIndex = 66
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
        Me.Label7.Size = New System.Drawing.Size(224, 25)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Payment Details"
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
        Me.Label8.Size = New System.Drawing.Size(224, 21)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "-"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(128, 131)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(77, 37)
        Me.cmdClose.TabIndex = 63
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'txt
        '
        Me.txt.BackColor = System.Drawing.Color.Khaki
        Me.txt.Enabled = False
        Me.txt.Location = New System.Drawing.Point(73, 13)
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(120, 20)
        Me.txt.TabIndex = 50
        '
        'cmdPayPeriod
        '
        Me.cmdPayPeriod.Location = New System.Drawing.Point(193, 13)
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
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(22, 131)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(77, 37)
        Me.cmdSave.TabIndex = 62
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'GrpTax
        '
        Me.GrpTax.Controls.Add(Me.dtpDate)
        Me.GrpTax.Controls.Add(Me.Label2)
        Me.GrpTax.Controls.Add(Me.Label1)
        Me.GrpTax.Controls.Add(Me.tMandateNo)
        Me.GrpTax.Controls.Add(Me.txt)
        Me.GrpTax.Controls.Add(Me.cmdPayPeriod)
        Me.GrpTax.Controls.Add(Me.Label6)
        Me.GrpTax.Location = New System.Drawing.Point(1, 41)
        Me.GrpTax.Name = "GrpTax"
        Me.GrpTax.Size = New System.Drawing.Size(221, 84)
        Me.GrpTax.TabIndex = 61
        Me.GrpTax.TabStop = False
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(73, 59)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(103, 20)
        Me.dtpDate.TabIndex = 55
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Pay Period:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Mandate No:"
        '
        'tMandateNo
        '
        Me.tMandateNo.Location = New System.Drawing.Point(73, 36)
        Me.tMandateNo.Name = "tMandateNo"
        Me.tMandateNo.Size = New System.Drawing.Size(144, 20)
        Me.tMandateNo.TabIndex = 52
        '
        'FrmPayDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(224, 172)
        Me.Controls.Add(Me.tblHeader)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.GrpTax)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPayDetails"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment Details"
        Me.tblHeader.ResumeLayout(False)
        Me.tblHeader.PerformLayout()
        Me.GrpTax.ResumeLayout(False)
        Me.GrpTax.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tblHeader As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents txt As System.Windows.Forms.TextBox
    Friend WithEvents cmdPayPeriod As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents GrpTax As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tMandateNo As System.Windows.Forms.TextBox
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
