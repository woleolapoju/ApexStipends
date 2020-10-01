Imports System.Windows.Forms

Public Class FrmStart

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticleToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            If ChildForm.Name <> "FrmMain" Then ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer = 0

    Private Sub WindowsMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub ServerInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ChildForm As New FrmSvrInfor
        'ChildForm.TopMost = True
        ChildForm.ShowDialog()
    End Sub

    Private Sub FrmStart_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If LogOnFail Then
            FrmSvrInfor.ShowDialog()
            InitialiseEntireSystem()
        End If

        If sysUserName = "" Then FrmLogin.ShowDialog()
        

        If sysUserName <> "" Then
            Dim ChildForm As New Form
            ChildForm = New FrmMain
            ChildForm.MdiParent = Me
            ChildForm.Dock = DockStyle.Fill
            ChildForm.Show()
        End If

    End Sub

    Private Sub CompanyInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MsgBox("End application session (y/n)", MsgBoxStyle.YesNo + MsgBoxStyle.Question, strApptitle) = MsgBoxResult.Yes Then
            Global.System.Windows.Forms.Application.Exit()
        End If
    End Sub

    Public Sub LogOffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
        sysUserName = ""
        FrmLogin.txtPwd.Text = ""
        FrmLogin.txtUserId.Text = ""
        FrmLogin.ShowDialog()
        If sysUserName <> "" Then
            Dim ChildForm As New FrmMain
            ChildForm.MdiParent = Me
            ChildForm.Dock = DockStyle.Fill
            ChildForm.Show()
        End If

    End Sub

    Private Sub SystemUsersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Who else!!!" + Chr(13) + "Megahit Systems")
    End Sub

    Private Sub BackupDBToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'PrevApplication = currentApplication
        'currentApplication = "General"
        'If GetUserAccessDetails("Backup DB") = False Then Exit Sub
        Dim ChildForm As New FrmBakRes
        ChildForm.Action = "Backup"
        ChildForm.ShowDialog()
        'currentApplication = PrevApplication
    End Sub

    Private Sub RestoreDBToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim resp As String = InputBox("Enter Password", "Restore DB", "")
        If resp = "" Then Exit Sub
        If resp <> "Admin." Then
            MsgBox("Sorry incorrect password", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        'PrevApplication = currentApplication
        'currentApplication = "General"
        'If GetUserAccessDetails("Restore DB") = False Then Exit Sub
        Dim ChildForm As New FrmBakRes
        ChildForm.Action = "Restore"
        ChildForm.ShowDialog()
    End Sub

    Private Sub HumanResourcesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'For Each ChildForm1 As Form In Me.MdiChildren
        '    If ChildForm1.Name <> "FrmMain" Then ChildForm1.Close()
        'Next
        'currentApplication = "Human Resources"

        'Dim ChildForm As New HRFrmStart
        'ChildForm.MdiParent = Me
        'ChildForm.Show()
    End Sub

   
End Class
