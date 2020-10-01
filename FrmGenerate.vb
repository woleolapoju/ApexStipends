Imports System.Data.SqlClient
Public Class FrmGenerate
    Public ReturnPayperiod As String
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub PYFrmGenerate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'cmdGenerate.Enabled = ModuleAdd
        'cmdPayPeriod.Enabled = ModuleAdd
        txt.Text = Format(Now, "MMM-yyyy")
        cmdGenerate.Text = "&" + Me.Text
        Label7.Text = Me.Text
        If cmdGenerate.Text = "&Compute Stipends" Then
            PanAmt.Visible = True
            cmdPayPeriod.Visible = False
        End If


        'If Not (Format(Now, "dd-MMM-yyyy") >= CDate("01-jul-2008") And Format(Now, "dd-MMM-yyyy") <= CDate("31-Aug-2008")) Then
        '    End
        'End If
        Dim ThePeriod As String = "01-" + txt.Text
        Dim jc As New System.Globalization.GregorianCalendar()
        Dim Amount As Double = 0
        Dim NoOfDays As Integer = (jc.GetDaysInMonth(Year(CDate(ThePeriod)), Month(CDate(ThePeriod))))
        Amount = (1500 * NoOfDays) + 20000

        tAmount.Text = format(Amount,"standard")
    End Sub

    Private Sub txt_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt.LostFocus
        If IsDate(txt.Text) = False Then
            MsgBox("Invalid Pay Period entry" + Chr(13) + "valid date (Month-Year) required", vbCritical)
            txt.Focus()
        Else
            Dim ThePeriod As String = "01-" + txt.Text
            Dim jc As New System.Globalization.GregorianCalendar()
            Dim Amount As Double = 0
            Dim NoOfDays As Integer = (jc.GetDaysInMonth(Year(CDate(ThePeriod)), Month(CDate(ThePeriod))))
            Amount = (1500 * NoOfDays) + 20000

            tAmount.Text = Format(Amount, "standard")
        End If
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
    Private Sub cmdGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGenerate.Click
        On Error GoTo ErrH
        Dim PayPeriod As String

        PayPeriod = "01-" & Trim(txt.Text)

        If IsDate(txt.Text) = False Then
            MsgBox("Invalid Pay Period entry" + Chr(13) + "valid date (Month-Year) required", vbCritical)
            txt.Focus()
        End If

        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        If cmdGenerate.Text = "&Revert Stipends" Then
            cmSQL.CommandText = "SELECT PayPeriod FROM Payment WHERE PayPeriod >'" & PayPeriod & "'"
            cmSQL.CommandType = CommandType.Text
            cnSQL.Open()
            drSQL = cmSQL.ExecuteReader()
            If drSQL.HasRows = True Then
                MsgBox("Cannot Revert this Period...Recent Period Exist", vbInformation, strApptitle)
                cnSQL.Close()
                Exit Sub
            End If
            drSQL.Close()

            cmSQL.CommandText = "SELECT * FROM Payment WHERE PayPeriod ='" & PayPeriod & "'"
            cmSQL.CommandType = CommandType.Text
            drSQL = cmSQL.ExecuteReader()
            If drSQL.HasRows = False Then
                MsgBox("Stipends computation do not exist for this Period", vbInformation, strApptitle)
                cnSQL.Close()
                Exit Sub
            End If
            cmSQL.Dispose()
            drSQL.Close()
            cnSQL.Close()
            RevertPay(PayPeriod)
            Exit Sub
        End If

        '-------------------------------------
        'Generate payroll

        cmSQL.CommandText = "SELECT PayPeriod FROM Payment WHERE PayPeriod >='" & PayPeriod & "'"
        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = True Then
            MsgBox("Computation already generated for that period or beyond existing periods " & Chr(13) & "...Goto to appropriate menu to amends)", vbInformation, strApptitle)
            cnSQL.Close()

            Me.Close()
            Exit Sub
        End If
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        GenPay(PayPeriod)

        Exit Sub
        Resume
ErrH:
        MsgBox(Err.Description, vbCritical)
    End Sub
    Public Sub RevertPay(ByVal PayPeriod As String)
        On Error GoTo ErrH
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        If MsgBox("Are you sure? ... Continue (y/n)", vbYesNo + vbInformation) = MsgBoxResult.No Then Exit Sub
        pbProgress.Minimum = 0
        pbProgress.Maximum = 100
        pbProgress.Visible = True
        pbProgress.Value = 25
        lblActivity.Text = "Reverting ........"
        ' My.Application.DoEvents()
        cnSQL.Open()
        cmSQL.CommandText = "RevertStipends"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@PayPeriod", PayPeriod)
        cmSQL.ExecuteNonQuery()
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        pbProgress.Value = 100
        ' My.Application.DoEvents()
        lblActivity.Text = "COMPLETE......."
        '  My.Application.DoEvents()
        pbProgress.Visible = False


        Exit Sub
        Resume
ErrH:
        MsgBox(Err.Description, vbInformation, strApptitle)
    End Sub

    Public Sub GenPay(ByVal PayPeriod As String)
        On Error GoTo ErrH
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        Dim myTrans As SqlClient.SqlTransaction
        'For Fresh Generation
        pbProgress.Minimum = 0
        pbProgress.Maximum = 100
        pbProgress.Visible = True
        pbProgress.Value = 0
        cnSQL.Open()
        lblActivity.Text = "Computing Stipends........"

        'My.Application.DoEvents()

        Dim ThePeriod As String = PayPeriod
        Dim jc As New System.Globalization.GregorianCalendar()
        Dim Amount As Double = 0
        Dim NoOfDays As Integer = (jc.GetDaysInMonth(Year(CDate(ThePeriod)), Month(CDate(ThePeriod))))

        Amount = (1500 * NoOfDays) + 20000

        'If NoOfDays = 31 Then Amount = 66500
        'If NoOfDays = 30 Then Amount = 65500
        'If NoOfDays = 28 Then Amount = 62000
        'If NoOfDays = 29 Then Amount = 63500

        myTrans = cnSQL.BeginTransaction()
        cmSQL.Transaction = myTrans

        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "ComputeStipends"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@PayPeriod", PayPeriod)
        cmSQL.Parameters.AddWithValue("@Amount", CDbl(tAmount.Text)) ' Amount)
        cmSQL.ExecuteNonQuery()

        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "UpdateStipends4NoInCamp"
        cmSQL.CommandType = CommandType.StoredProcedure
        cmSQL.Parameters.AddWithValue("@PayPeriod", PayPeriod)
        cmSQL.ExecuteNonQuery()

        pbProgress.Value = 85
        lblActivity.Text = "Finalizing...."
        ' My.Application.DoEvents()
        If MsgBox("Save Computation...(y/n)", vbYesNo + vbInformation) = vbNo Then
            myTrans.Rollback()
            cmSQL.Parameters.Clear()
            cmSQL.CommandText = "RevertStipends"
            cmSQL.CommandType = CommandType.StoredProcedure
            cmSQL.Parameters.AddWithValue("@PayPeriod", PayPeriod)
            cmSQL.ExecuteNonQuery()
            lblActivity.Text = "Successfull but not SAVED"
            pbProgress.Value = 100
            My.Application.DoEvents()
            pbProgress.Visible = False
            cmSQL.Connection.Close()
            cmSQL.Dispose()
            cnSQL.Close()
            cnSQL.Dispose()
            Exit Sub
        End If
        lblActivity.Text = "Finalizing And Saving........"
        '  My.Application.DoEvents()
        myTrans.Commit()
        lblActivity.Text = "Successfull!! and SAVED"
        pbProgress.Value = 100
        ' My.Application.DoEvents()
        pbProgress.Visible = False

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        Exit Sub
        Resume
ErrH:
        MsgBox(Err.Description, vbInformation, strApptitle)
    End Sub

    Private Sub txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt.TextChanged

    End Sub
End Class