Imports System.Data.SqlClient
Public Class FrmPayDetails
    Public ReturnPayperiod As String
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
    Private Sub FrmPayDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt.Text = Format(Now, "MMM-yyyy")
    End Sub

    Private Sub cmdPayPeriod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPayPeriod.Click
        On Error GoTo errhdl
        Dim strValue As String
        Dim strPrompt As String
        Dim strCaption(1) As String
        Dim intWidth(1) As Integer
        strCaption(0) = "Pay Period"
        intWidth(0) = 300
        With FrmList
            .frmParent = Me
            .tSelection = "GetGeneratedPayPeriod"
            .LoadLvList(strCaption, intWidth, "GetGeneratedPayPeriod")
            .Text = "List of Generated Pay Periods"
            .TopMost = True
            .ShowDialog()
        End With
        If ReturnPayperiod = "" Then Exit Sub
        txt.Text = Format(CDate(ReturnPayperiod), "MMM-yyyy")

        txt.Focus()

        Exit Sub
errhdl:
        MsgBox(Err.Description, vbInformation, strApptitle)
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        On Error GoTo ErrH
        Dim PayPeriod As String
        If Trim(txt.Text) = "" Or Trim(tMandateNo.Text) = "" Then
            MsgBox("Incomplete data....", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        PayPeriod = "01-" & Trim(txt.Text)

        If IsDate(txt.Text) = False Then
            MsgBox("Invalid Pay Period entry" + Chr(13) + "valid date (Month-Year) required", vbCritical)
            txt.Focus()
        End If

        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cnSQL.Open()
        cmSQL.CommandText = "InsertPaymentDetails"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@Period", PayPeriod)
        cmSQL.Parameters.AddWithValue("@MandateNo", tMandateNo.Text)
        cmSQL.Parameters.AddWithValue("@Date", formatDate(dtpDate))
        cmSQL.ExecuteNonQuery()
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        MsgBox("Successfull...", MsgBoxStyle.Information, strApptitle)

        Exit Sub
        Resume
ErrH:
        MsgBox(Err.Description, vbCritical)
    End Sub
End Class