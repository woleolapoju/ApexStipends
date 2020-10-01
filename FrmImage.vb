Imports System.Data.SqlClient
Public Class FrmImage
    Public Sn As Integer
    Public tState As String
    Public tCamp As String
    Private Sub FrmImage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        PictPhoto.Image = Nothing
        Dim arrayPict() As Byte = {0}

        cmSQL.CommandText = "SELECT * FROM Register WHERE Sn = " & Sn & " AND State ='" & tState & "' AND Camp ='" & tCamp & "'"
        cmSQL.CommandType = CommandType.Text

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()

        If drSQL.HasRows = False Then Exit Sub
        If drSQL.Read = False Then Exit Sub

        If IsDBNull(drSQL.Item("Photo")) = False Then
            arrayPict = CType(drSQL.Item("Photo"), Byte())
            If arrayPict.Length > 1 Then
                Dim ms As New IO.MemoryStream(arrayPict)
                PictPhoto.Image = Image.FromStream(ms)
                Dim staffPictFileName = My.Computer.FileSystem.GetTempFileName
                staffPictFileName = Mid(staffPictFileName, 1, Len(staffPictFileName) - 3) + "nap"
                Me.Tag = staffPictFileName
                PictPhoto.Image.Save(staffPictFileName)
                ms.Close()
                PictPhoto.Image = Image.FromFile(staffPictFileName)
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
        If Err.Number = 9 Then
            Resume Next
        Else
            MsgBox(Err.Description + Chr(13) + Err.Source, vbInformation, strApptitle)
            Resume Next
        End If
    End Sub
    Private Sub PictPhoto_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictPhoto.DoubleClick
        On Error GoTo handler
        Dim arrayPict() As Byte = {0}
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictPhoto.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
        If IsNothing(PictPhoto.Image) = False Then
            Dim ms As New IO.MemoryStream()
            PictPhoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg) 'OwnerLogo.Image.RawFormat
            arrayPict = ms.GetBuffer
            ms.Close()
        End If

        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand

        cnSQL.Open()
        cmSQL.CommandText = "InsertImage"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@Sn", Sn)
        cmSQL.Parameters.AddWithValue("@State", tState)
        cmSQL.Parameters.AddWithValue("@Camp", tCamp)
        cmSQL.Parameters.AddWithValue("@Photo", arrayPict)
        cmSQL.ExecuteNonQuery()

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()


        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        cnSQL.Close()

    End Sub
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub lnkBank_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkClearImage.LinkClicked
        On Error GoTo handler
        Dim arrayPict() As Byte = {0}
        PictPhoto.Image = Nothing

        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand

        cnSQL.Open()
        cmSQL.CommandText = "InsertImage"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@Sn", Sn)
        cmSQL.Parameters.AddWithValue("@State", tState)
        cmSQL.Parameters.AddWithValue("@Camp", tCamp)
        cmSQL.Parameters.AddWithValue("@Photo", arrayPict)
        cmSQL.ExecuteNonQuery()

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        cnSQL.Close()

    End Sub

    Private Sub PictPhoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictPhoto.Click

    End Sub
End Class