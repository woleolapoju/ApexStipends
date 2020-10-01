<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmImage))
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PictPhoto = New System.Windows.Forms.PictureBox()
        Me.lnkClearImage = New System.Windows.Forms.LinkLabel()
        CType(Me.PictPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(124, 184)
        Me.cmdClose.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(63, 30)
        Me.cmdClose.TabIndex = 55
        Me.cmdClose.Text = "&Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "All Image Formats (*.bmp;*.jpg;*.jpeg;*.gif;*.tif)|*.bmp;*.jpg;*.jpeg;*.gif;*.tif" & _
            "|Bitmaps (*.bmp)|*.bmp|GIFs (*.gif)|*.gif|JPEGs (*.jpg)|*.jpg;*.jpeg|TIFs (*.tif" & _
            ")|*.tif"
        '
        'PictPhoto
        '
        Me.PictPhoto.BackColor = System.Drawing.Color.White
        Me.PictPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictPhoto.Location = New System.Drawing.Point(7, 8)
        Me.PictPhoto.Name = "PictPhoto"
        Me.PictPhoto.Size = New System.Drawing.Size(178, 169)
        Me.PictPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictPhoto.TabIndex = 48
        Me.PictPhoto.TabStop = False
        Me.PictPhoto.Tag = "Pict"
        '
        'lnkClearImage
        '
        Me.lnkClearImage.AutoSize = True
        Me.lnkClearImage.Location = New System.Drawing.Point(11, 192)
        Me.lnkClearImage.Name = "lnkClearImage"
        Me.lnkClearImage.Size = New System.Drawing.Size(63, 13)
        Me.lnkClearImage.TabIndex = 56
        Me.lnkClearImage.TabStop = True
        Me.lnkClearImage.Text = "Clear Image"
        '
        'FrmImage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(192, 217)
        Me.Controls.Add(Me.lnkClearImage)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.PictPhoto)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmImage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Image"
        CType(Me.PictPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lnkClearImage As System.Windows.Forms.LinkLabel
End Class
