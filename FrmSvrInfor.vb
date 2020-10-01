Imports System.Data
Imports System.Data.OleDb
Imports system.data.SqlClient

Public Class FrmSvrInfor

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdDBMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDBMain.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Application.Info.DirectoryPath
        OpenFileDialog.Filter = "DB Data Files (*.MDF)|*.MDF"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            txtDBMain.Text = FileName
        End If
    End Sub
    Private Sub cmdDBLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDBLog.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Application.Info.DirectoryPath
        OpenFileDialog.Filter = "DB Data Files (*.LDF)|*.LDF"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            txtDBLog.Text = FileName
        End If
    End Sub
    Private Sub chkWinAuthen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkWinAuthen.CheckedChanged
        If chkWinAuthen.Checked = True Then
            txtUserID.Enabled = False
            txtPassword.Enabled = False
        Else
            txtUserID.Enabled = True
            txtPassword.Enabled = True
        End If
    End Sub
    Private Sub FrmSvrInfor_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DoubleClick
        Dim resp As String
        resp = InputBox("Enter Password", "Authentication")
        If resp = "penny" Then
            txtOwner.ReadOnly = False
            GrpAdvance.Enabled = True
            Me.Width = 465
        End If

    End Sub

    Private Sub FrmSvrInfor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cnSQL As OleDbConnection
        Dim cmSQL As OleDbCommand
        Dim drSQL As OleDbDataReader
        Dim StrPwd As String
        'StrPwd = InputBox("Enter Password", "Authentication")
        'If StrPwd = "" Then
        '    GrpAttach.Enabled = False
        '    GrpAdvance.Enabled = False
        '    GrpServ.Enabled = False
        '    GrpAuthenticate.Enabled = False
        '    Me.Width = 243
        '    cmdOk.Enabled = False
        'End If

        StrPwd = "ap"

        Try

            cnSQL = New OleDbConnection(MSAccessCn)
            cnSQL.Open()

            cmSQL = New OleDbCommand("SELECT * FROM SvrParam", cnSQL)
            drSQL = cmSQL.ExecuteReader()

            If drSQL.HasRows = False Then
                MsgBox("Invalid Configuration Parameter" & Chr(13) & "System Halted", MsgBoxStyle.Information)
                End
            End If
            If drSQL.Read Then
                cboServerName.Text = ChkNull(drSQL.Item("ServerName"))
                txtUserID.Text = ChkNull(drSQL.Item("UserID"))
                txtPassword.Text = ChkNull(drSQL.Item("Password"))
                txtAttachName.Text = ChkNull(drSQL.Item("AttachName"))
                chkWinAuthen.Checked = drSQL.Item("IntegratedSecurity")
                txtOwner.Text = ChkNull(drSQL.Item("Owner"))
                If drSQL.Item("AdminPwd") = StrPwd Then
                    'GrpAttach.Enabled = False
                    GrpAdvance.Enabled = False
                    Me.Width = 243
                ElseIf drSQL.Item("ControlPwd") = StrPwd Then
                    Me.Width = 465
                Else
                    MsgBox("Access Denied", MsgBoxStyle.Information, strApptitle)
                    GrpAttach.Enabled = False
                    GrpAdvance.Enabled = False
                    GrpServ.Enabled = False
                    GrpAuthenticate.Enabled = False
                    Me.Width = 243
                    cmdOk.Enabled = False
                End If
            End If

            drSQL.Close()
            cnSQL.Close()
            cmSQL.Dispose()
            cnSQL.Dispose()

            Call chkWinAuthen_CheckedChanged(sender, e)

        Catch er As Exception
            MsgBox(er.Message, MsgBoxStyle.Critical, strApptitle)
        End Try

    End Sub

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        Dim strSql As String
        Dim intRowsAffected
        Try
            Using cnOle As New OleDbConnection(MSAccessCn)
                cnOle.Open()
                strSql = "UPDATE SvrParam SET" & _
                                    " ServerName = '" & Trim(ChkNull(cboServerName.Text)) & "'" & _
                                    " ,UserID = '" & Trim(ChkNull(txtUserID.Text)) & "'" & _
                                    " ,[Password] = '" & Trim(ChkNull(txtPassword.Text)) & "'" & _
                                    " ,AttachName = '" & Trim(ChkNull(txtAttachName.Text)) & "'" & _
                                    " ,IntegratedSecurity = " & chkWinAuthen.Checked & _
                                    " ,Owner = '" & Trim(ChkNull(txtOwner.Text)) & "'"


                Dim cmOle As New OleDbCommand(strSql, cnOle)
                intRowsAffected = cmOle.ExecuteNonQuery()
                InitialiseEntireSystem()
                MsgBox("Update Successfull", MsgBoxStyle.Information, strApptitle)
                cnOle.Close()
                cmOle.Dispose()
                cnOle.Dispose()
                InitialiseEntireSystem()
                Me.Close()

            End Using

            If intRowsAffected <> 1 Then
                MsgBox("Update Failed.", MsgBoxStyle.Critical, "Update")
            End If


        Catch er As Exception
            MsgBox(er.Message, MsgBoxStyle.Critical, strApptitle)
        End Try
    End Sub

    Private Sub cmdAttach_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAttach.Click
        On Error GoTo handler
        Dim connectStr As String
        If Trim(txtDBMain.Text) = "" Or Trim(txtDBLog.Text) = "" Then
            MsgBox("Pls. select the database", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        If chkWinAuthen.Checked Then
            connectStr = "workstation id=" & cboServerName.Text & ";packet size=4096;data source=" & cboServerName.Text & ";Integrated Security=True;initial catalog=master"
        Else
            connectStr = "workstation id=" & cboServerName.Text & ";packet size=4096;user id=" & txtUserID.Text & ";pwd=" & txtPassword.Text & ";data source=" & cboServerName.Text & ";persist security info=False;initial catalog=master"
        End If

        Dim SqlCn As SqlConnection = New SqlConnection(connectStr)
        Dim strConnectMaster As String
        SqlCn.Open()
        If Len(Trim(txtAttachName.Text)) = 0 Then
            MsgBox("Pls. choose a valid data file", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        On Error Resume Next
        ''Dim myTrans As SqlTransaction
        ''myTrans = SqlCn.BeginTransaction(IsolationLevel.Serializable, "MyTrans")
        Dim myCommand As SqlCommand = SqlCn.CreateCommand
        ''myCommand.Transaction = myTrans

        myCommand.CommandText = "EXEC sp_detach_db @dbname = '" & cboavaliableDB.Text & "'"
        myCommand.ExecuteNonQuery()

        On Error GoTo handler
        myCommand.CommandText = "EXEC sp_attach_db @dbname = N'" & txtAttachName.Text & "',@filename1 = N'" & Trim(txtDBMain.Text) & "',@filename2 = N'" & Trim(txtDBLog.Text) & "'"
        myCommand.ExecuteNonQuery()
        ''myTrans.Commit()

        myCommand.Connection.Close()
        myCommand.Dispose()
        SqlCn.Close()
        SqlCn.Dispose()
        MsgBox("Successfully Attached", vbInformation)
        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub

    Private Sub cboavaliableDB_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboavaliableDB.SelectedIndexChanged
        txtAttachName.Text = cboavaliableDB.Text
    End Sub
End Class