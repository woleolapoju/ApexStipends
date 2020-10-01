Imports System.Data.SqlClient
Public Class FrmNewUser
    Public Action As String
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        If Action = "New" Then
            If Trim(tPwd.Text) = "" Or Trim(tConfirmPwd.Text) = "" Or Trim(tUserName.Text) = "" Then
                MsgBox("Incomplete data", MsgBoxStyle.Information, strApptitle)
                Exit Sub
            End If

            If tPwd.Text <> tConfirmPwd.Text Then
                MsgBox("Inconsistent Password", MsgBoxStyle.Information, strApptitle)
                Exit Sub
            End If
            cnSQL.Open()
            cmSQL.CommandText = "InsertUserAccess"
            cmSQL.CommandType = CommandType.StoredProcedure
            cmSQL.Parameters.AddWithValue("@UserID", tUserName.Text)
            cmSQL.Parameters.AddWithValue("@UserPassword", tPwd.Text)
            cmSQL.Parameters.AddWithValue("@Level", cboLevel.Text)
            cmSQL.ExecuteNonQuery()
            cmSQL.Parameters.Clear()
            MsgBox("Successfull!", MsgBoxStyle.Information, strApptitle)
            tUserName.Text = ""
            tPwd.Text = ""
            tConfirmPwd.Text = ""
            tUserName.Focus()
        End If
        If Action = "Delete" Then
            If UCase(Trim(cboUser.Text)) = "ADMIN" Then
                MsgBox("This User cannot be deleted", MsgBoxStyle.Information, strApptitle)
                Exit Sub
            End If
            If Trim(cboUser.Text) = "" Then
                MsgBox("Pls. specify user", MsgBoxStyle.Information, strApptitle)
                Exit Sub
            End If
            If MsgBox("Do You Want To Delete This Record?", vbQuestion + vbYesNo, strApptitle) = vbNo Then Exit Sub
            cnSQL.Open()
            cmSQL.CommandText = "DELETE FROM UserAccess WHERE UserID='" & cboUser.Text & "'"
            cmSQL.CommandType = CommandType.Text
            cmSQL.ExecuteNonQuery()
            MsgBox("Delete Successfull!", MsgBoxStyle.Information, strApptitle)
            Me.Close()
        End If
        If Action = "Change" Then
            If Trim(tPwd.Text) = "" Or Trim(tConfirmPwd.Text) = "" Or Trim(tUserName.Text) = "" Then
                MsgBox("Incomplete data", MsgBoxStyle.Information, strApptitle)
                Exit Sub
            End If
            If tPwd.Text <> tConfirmPwd.Text Then
                MsgBox("Inconsistent Password", MsgBoxStyle.Information, strApptitle)
                Exit Sub
            End If

            cnSQL.Open()
            cmSQL.CommandText = "UPDATE UserAccess SET UserPassword='" & tPwd.Text & "' WHERE UserID='" & tUserName.Text & "'"
            cmSQL.CommandType = CommandType.Text
            cmSQL.ExecuteNonQuery()

            MsgBox("Password Change Successfull!", MsgBoxStyle.Information, strApptitle)
            Me.Close()
        End If
        Exit Sub
handler:
        If Err.Number = 5 Then
            MsgBox("User already exist", MsgBoxStyle.Information, strApptitle)
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub
    Private Sub FrmNewUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboLevel.SelectedIndex = 0
        If Action = "New" Then Me.Text = "New User"
        If Action = "Delete" Then
            Me.Text = "Delete User"
            cboUser.Enabled = True
            LoadUser()
            cboUser.BringToFront()
        End If
        If Action = "Change" Then
            Me.Text = "Change Password"
            tUserName.Text = sysUserName
            tUserName.ReadOnly = True
            tPwd.Focus()
        End If
    End Sub
    Private Sub LoadUser()
        On Error GoTo errhdl
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        cboUser.Items.Clear()
        cmSQL.CommandText = "SELECT * FROM UserAccess"
        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            cboUser.Items.Add(drSQL.Item("UserID").ToString)
        Loop
        Exit Sub
        drSQL.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub
End Class