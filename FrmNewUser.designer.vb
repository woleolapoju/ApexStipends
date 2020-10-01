<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNewUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNewUser))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.OK = New System.Windows.Forms.Button()
        Me.tPwd = New System.Windows.Forms.TextBox()
        Me.tUserName = New System.Windows.Forms.TextBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.tConfirmPwd = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboUser = New System.Windows.Forms.ComboBox()
        Me.cboLevel = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(128, -5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(2, 150)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Cancel.Location = New System.Drawing.Point(135, 74)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(52, 37)
        Me.Cancel.TabIndex = 4
        Me.Cancel.Text = "&Close"
        '
        'OK
        '
        Me.OK.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.OK.Location = New System.Drawing.Point(135, 33)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(53, 35)
        Me.OK.TabIndex = 3
        Me.OK.Text = "&OK"
        '
        'tPwd
        '
        Me.tPwd.Location = New System.Drawing.Point(5, 65)
        Me.tPwd.Name = "tPwd"
        Me.tPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tPwd.Size = New System.Drawing.Size(107, 20)
        Me.tPwd.TabIndex = 1
        Me.tPwd.UseSystemPasswordChar = True
        '
        'tUserName
        '
        Me.tUserName.Location = New System.Drawing.Point(5, 23)
        Me.tUserName.Name = "tUserName"
        Me.tUserName.Size = New System.Drawing.Size(106, 20)
        Me.tUserName.TabIndex = 0
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Location = New System.Drawing.Point(3, 46)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(117, 23)
        Me.PasswordLabel.TabIndex = 10
        Me.PasswordLabel.Text = "&Password"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Location = New System.Drawing.Point(5, 1)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(117, 21)
        Me.UsernameLabel.TabIndex = 8
        Me.UsernameLabel.Text = "&User name"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tConfirmPwd
        '
        Me.tConfirmPwd.Location = New System.Drawing.Point(5, 105)
        Me.tConfirmPwd.Name = "tConfirmPwd"
        Me.tConfirmPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tConfirmPwd.Size = New System.Drawing.Size(105, 20)
        Me.tConfirmPwd.TabIndex = 2
        Me.tConfirmPwd.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(3, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 23)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "&Confirm Password"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboUser
        '
        Me.cboUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUser.Enabled = False
        Me.cboUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboUser.FormattingEnabled = True
        Me.cboUser.Location = New System.Drawing.Point(6, 22)
        Me.cboUser.Name = "cboUser"
        Me.cboUser.Size = New System.Drawing.Size(122, 21)
        Me.cboUser.TabIndex = 16
        '
        'cboLevel
        '
        Me.cboLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboLevel.FormattingEnabled = True
        Me.cboLevel.Items.AddRange(New Object() {"ALL", "Accounts", "Pension"})
        Me.cboLevel.Location = New System.Drawing.Point(6, 131)
        Me.cboLevel.Name = "cboLevel"
        Me.cboLevel.Size = New System.Drawing.Size(122, 21)
        Me.cboLevel.TabIndex = 17
        Me.cboLevel.Visible = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(5, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 21)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "&Level"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Visible = False
        '
        'FrmNewUser
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(195, 145)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboLevel)
        Me.Controls.Add(Me.tConfirmPwd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.tPwd)
        Me.Controls.Add(Me.tUserName)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.cboUser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmNewUser"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New User"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents tPwd As System.Windows.Forms.TextBox
    Friend WithEvents tUserName As System.Windows.Forms.TextBox
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents tConfirmPwd As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboUser As System.Windows.Forms.ComboBox
    Friend WithEvents cboLevel As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
