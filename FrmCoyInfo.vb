Imports System.Data.SqlClient
Imports System.Drawing
Public Class FrmCoyInfo
    Private Sub cmdGetLogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetLogo.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Application.Info.DirectoryPath
        OpenFileDialog.Filter = "All Files|*.*|Bitmaps|*.bmp|GIFs|*.gif|JPEGs|*.jpg"
        OpenFileDialog.FilterIndex = 2

        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            OwnerLogo.Image = Image.FromFile(FileName)
        End If
    End Sub

    Private Sub FrmCoyInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo handler

        tName.Text = sysOwner
        Dim arrayLogo() As Byte = {0}
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cnSQL.Open()

        cmSQL.CommandText = "FetchAllSystemParameters"
        cmSQL.CommandType = CommandType.StoredProcedure
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then
            MsgBox("Invalid System parameter", MsgBoxStyle.Information, strApptitle)
            End
        Else
            If drSQL.Read Then
                tAddress.Text = drSQL.Item("Address")
                tPhone.Text = drSQL.Item("Phone")
                If IsDBNull(drSQL.Item("Logo")) = False Then
                    arrayLogo = CType(drSQL.Item("Logo"), Byte())
                    If arrayLogo.Length > 1 Then
                        Dim ms As New IO.MemoryStream(arrayLogo)
                        OwnerLogo.Image = Image.FromStream(ms)
                        Dim logoPictFileName = My.Computer.FileSystem.GetTempFileName
                        logoPictFileName = Mid(logoPictFileName, 1, Len(logoPictFileName) - 3) + "nap"
                        OwnerLogo.Image.Save(logoPictFileName)
                        ms.Close()
                        OwnerLogo.Image = Image.FromFile(logoPictFileName)
                    End If
                End If

            End If
        End If
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        On Error GoTo handler

        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand

        cnSQL.Open()

        Dim arrayLogo() As Byte = {0}

        If IsNothing(OwnerLogo.Image) = False Then
            Dim ms As New IO.MemoryStream()
            OwnerLogo.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg) 'OwnerLogo.Image.RawFormat
            arrayLogo = ms.GetBuffer
            ms.Close()
        End If

        cmSQL.CommandText = "UpdateSysParam4CoySetup"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@NName", tName.Text)
        cmSQL.Parameters.AddWithValue("@logo", arrayLogo)
        cmSQL.Parameters.AddWithValue("@Address", tAddress.Text)
        cmSQL.Parameters.AddWithValue("@Phone", tPhone.Text)

        cmSQL.ExecuteNonQuery()

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        MsgBox("Update successfull, Pls. restart the application", MsgBoxStyle.Critical, "Company Information")

        End

        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub
    Private Sub InsertLogoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsertLogoToolStripMenuItem.Click
        cmdGetLogo_Click(sender, e)
    End Sub

    Private Sub ClearLogoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearLogoToolStripMenuItem.Click
        On Error GoTo handler
        OwnerLogo.Image = Nothing
        Exit Sub
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub
    Private Sub CmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
End Class