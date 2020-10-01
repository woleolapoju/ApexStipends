Imports System.IO
Imports System.Data.SqlClient
Public Class FrmMain
    Private Sub frmMain2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblOwner.Text = UCase(sysOwner) + "     |     "
        lblPhase.Text = ThePhase
        Timer1.Start()
        ' lblUserName.Text = sysUserName
        On Error Resume Next
        If Not arrayLogo Is Nothing Then
            Dim ms As New MemoryStream(arrayLogo)
            OwnerLogo.Image = Image.FromStream(ms)
        End If

        '  PicHeader.Image = Image.FromFile(AppPath + "\ConfigDir\BANNER.jpg")
        '  tblBody.BackgroundImage = Image.FromFile(AppPath + "\ConfigDir\BODY.jpg")

    End Sub

    Private Sub lnkNewUser_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkNewUser.LinkClicked
        Dim ChildForm As New FrmNewUser
        ChildForm.Action = "New"
        ChildForm.ShowDialog()
    End Sub

    Private Sub lnkDeleteUser_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkDeleteUser.LinkClicked
        Dim ChildForm As New FrmNewUser
        ChildForm.Action = "Delete"
        ChildForm.ShowDialog()
    End Sub

    Private Sub lnkChangePwd_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkChangePwd.LinkClicked
        Dim ChildForm As New FrmNewUser
        ChildForm.Action = "Change"
        ChildForm.ShowDialog()
    End Sub

    Private Sub lnkCoyInfor_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkCoyInfor.LinkClicked
        Dim ChildForm As New FrmBakRes
        ChildForm.Action = "Backup"
        ChildForm.ShowDialog()
    End Sub

    Public Function MarqueeLeft(ByVal Text As String)
        Dim Str1 As String = Text.Remove(0, 1)
        Dim Str2 As String = Text(0)
        Return Str1 & Str2
    End Function
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblOwner.Text = MarqueeLeft(lblOwner.Text)
    End Sub
    Private Sub lnkPayDetails_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkPayDetails.LinkClicked
        Dim ChildForm As New FrmPayDetails
        ChildForm.ShowDialog()
    End Sub
    Private Sub RadStipends_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadStipends.Click
        Dim ChildForm As New FrmStipends
        ChildForm.ShowDialog()
    End Sub
    Private Sub RadRegister_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadRegister.Click
        Dim ChildForm As New FrmRegistration
        ChildForm.Show()
    End Sub
    Private Sub RadAccounts_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadReport.Click
        FrmReport.ShowDialog()

    End Sub
    Private Sub RadGenerate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadGenerate.Click
        Dim ChildForm As New FrmGenerate
        ChildForm.Text = "Compute Stipends"
        ChildForm.ShowDialog()
    End Sub
    Private Sub RadRevert_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadRevert.Click
        Dim ChildForm As New FrmGenerate
        ChildForm.Text = "Revert Stipends"
        ChildForm.ShowDialog()
    End Sub

    Private Sub lnkBankCode_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkBankCode.LinkClicked
        Dim ChildForm As New FrmBank
        ChildForm.Show()
    End Sub
    Private Sub RadNewDB_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadNewDB.Click
        On Error GoTo errhdl

        If MsgBox("This operation cannot be reversed.....continue (y/n)", vbYesNo + MsgBoxStyle.Information, strApptitle) = vbNo Then
            Exit Sub
        End If

        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cnSQL.Open()

        Dim ThePayment As String = "Payment" + Format(Now, "MMM") + Mid(Trim(Str(Year(Now))), 3)

        cmSQL.CommandText = "EXEC sp_rename 'Payment', '" & ThePayment & "'"
        cmSQL.CommandType = CommandType.Text
        cmSQL.ExecuteNonQuery()


        cmSQL.CommandText = "SELECT * INTO Payment FROM PaymentBlank"
        cmSQL.CommandType = CommandType.Text
        cmSQL.ExecuteNonQuery()


        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        MsgBox("Successful", MsgBoxStyle.Information, strApptitle)

        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)

    End Sub
    'PREVENTING SCREEN FLICKING
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property
    Private Sub PreVentFlicker()
        With Me
            .SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
            .SetStyle(ControlStyles.UserPaint, True)
            .SetStyle(ControlStyles.AllPaintingInWmPaint, True)
            .UpdateStyles()
        End With
    End Sub
    Private Sub RadMandate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadMandate.Click
        Dim ChildForm As New FrmMandate
        ChildForm.ShowDialog()
    End Sub

    Private Sub RadImport_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadImport.CheckedChanged

    End Sub

    Private Sub RadImport_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadImport.Click
        Dim ChildForm As New FrmImportData
        ChildForm.ShowDialog()
    End Sub

    Private Sub RadRegister_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadRegister.CheckedChanged

    End Sub

    Private Sub RadReport_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadReport.CheckedChanged

    End Sub
End Class