Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports System.IO
Public Class FrmReport
    Dim RptFilename, SelFormula, RptDestination, RptTitle As String
    Dim myReportDocument As ReportDocument
    Dim PaperSize, POrientation As String
    Dim ReportName As String
    Public ReturnPeriod As String
    Public ReturnPayperiod As String
    Private Sub ConfigureCrystalReports()
        On Error GoTo handler
        Dim intCounter As Integer
        Dim ConInfo As New CrystalDecisions.Shared.TableLogOnInfo
        ConInfo.ConnectionInfo.DatabaseName = AttachName
        ConInfo.ConnectionInfo.ServerName = ServerName
        If IntegratedSecurity Then
            ConInfo.ConnectionInfo.IntegratedSecurity = True
        Else
            ConInfo.ConnectionInfo.UserID = UserID
            ConInfo.ConnectionInfo.Password = Password
        End If

        For intCounter = 0 To myReportDocument.Database.Tables.Count - 1
            myReportDocument.Database.Tables(intCounter).ApplyLogOnInfo(ConInfo)
        Next

        'Dim connection As IConnectionInfo

        '' Set Database Logon to main report
        'For Each connection In myReportDocument.DataSourceConnections
        '    Select Case connection.ServerName
        '        Case ServerName
        '            connection.SetLogon(UserID, Password)
        '    End Select
        'Next

        '' Set Database Logon to subreport
        'Dim subreport As ReportDocument
        'For Each subreport In myReportDocument.Subreports
        '    For Each connection In subreport.DataSourceConnections
        '        Select Case connection.ServerName
        '            Case ServerName
        '                connection.SetLogon(UserID, Password)
        '        End Select
        '    Next
        'Next


        If RptDestination = "Printer" Then
            ' You can change more print options via PrintOptions property of ReportDocument
            ' myCrystalReportViewer.PrintReport()
            myReportDocument.PrintToPrinter(1, True, 0, 0)
            myReportDocument.Close()
        End If
        Exit Sub
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub
    Private Sub FillStates()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cboState.Items.Clear()
        cboState.Items.Add("ALL")
        cmSQL.CommandText = "SELECT DISTINCT State FROM StateCamp ORDER BY State"
        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            cboState.Items.Add(drSQL.Item("State").ToString)
        Loop
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        cboState.SelectedIndex = 0

        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub
    Private Sub oLoadCamp()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        cCamp.Items.Clear()
        If cboState.Text = "ALL" Then
            cmSQL.CommandText = "SELECT DISTINCT Camp FROM StateCamp ORDER BY Camp"
        Else
            cmSQL.CommandText = "SELECT DISTINCT Camp FROM StateCamp WHERE state='" & cboState.Text & "' ORDER BY [Camp]"
        End If
        cmSQL.CommandType = CommandType.Text
        cCamp.Items.Add("ALL")
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then Exit Sub
        Do While drSQL.Read
            cCamp.Items.Add(ChkNull(drSQL.Item("Camp")))
        Loop
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()
        cCamp.SelectedIndex = 0

        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, vbInformation, strApptitle)
    End Sub
    Private Sub FrmRptDisplay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        tPeriod.Text = Format(Now, "MMM-yyyy")

        FillStates()

        On Error Resume Next
        If Not arrayLogo Is Nothing Then
            Dim ms As New MemoryStream(arrayLogo)
            OwnerLogo.Image = Image.FromStream(ms)
        End If
        lblOwner.Text = UCase(sysOwner)


        Exit Sub
errhdl:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        On Error GoTo errhdl

        Dim SelFormular As String = ""
        Dim RptFilename As ReportDocument = New ReportDocument

        'Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        'Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim PayPeriod As Date = CDate("01-" & Trim(tPeriod.Text))

        If UCase(Trim(ReportName)) = "STIPENDS  SCHEDULE" Then
            RptFilename = New StipendSchedule
            SelFormular = " {RptPayment.NoOfDelegate}<=1 AND {RptPayment.PayPeriod}=cdate('" & PayPeriod & "')"
            If cboState.Text <> "ALL" Then SelFormular = SelFormular + " AND {RptPayment.State}='" & cboState.Text & "'"
            If cCamp.Text <> "ALL" Then SelFormular = SelFormular + " AND {RptPayment.Camp}='" & cCamp.Text & "'"
        ElseIf UCase(Trim(ReportName)) = UCase("STIPENDS  SCHEDULE (Exclude Unpaid Delegates)") Then
            RptFilename = New StipendSchedule
            SelFormular = " {RptPayment.Amount}>0 AND {RptPayment.NoOfDelegate}<=1 AND {RptPayment.PayPeriod}=cdate('" & PayPeriod & "')"
            If cboState.Text <> "ALL" Then SelFormular = SelFormular + " AND {RptPayment.State}='" & cboState.Text & "'"
            If cCamp.Text <> "ALL" Then SelFormular = SelFormular + " AND {RptPayment.Camp}='" & cCamp.Text & "'"
        ElseIf UCase(Trim(ReportName)) = UCase("STIPENDS  SCHEDULE With IDNo") Then
            RptFilename = New StipendScheduleWithIDNo
            SelFormular = " {RptPayment.Amount}>0 AND {RptPayment.NoOfDelegate}<=1 AND {RptPayment.PayPeriod}=cdate('" & PayPeriod & "')"
            If cboState.Text <> "ALL" Then SelFormular = SelFormular + " AND {RptPayment.State}='" & cboState.Text & "'"
            If cCamp.Text <> "ALL" Then SelFormular = SelFormular + " AND {RptPayment.Camp}='" & cCamp.Text & "'"
        ElseIf UCase(Trim(ReportName)) = UCase("STIPENDS  SCHEDULE (Excel)") Then
            Export2Excel()
            Exit Sub
        ElseIf UCase(Trim(ReportName)) = "STIPENDS SUMMARY (NAMES ONLY)" Then
            RptFilename = New StipendScheduleNamesAlone
            SelFormular = " {RptPayment.PayPeriod}=cdate('" & PayPeriod & "')"
            If cboState.Text <> "ALL" Then SelFormular = SelFormular + " AND {RptPayment.State}='" & cboState.Text & "'"
            If cCamp.Text <> "ALL" Then SelFormular = SelFormular + " AND {RptPayment.Camp}='" & cCamp.Text & "'"
        ElseIf UCase(Trim(ReportName)) = "STIPENDS SUMMARY - 1" Then
            RptFilename = New StipendsSummary1
            SelFormular = " {RptPayment.PayPeriod}=cdate('" & PayPeriod & "')"
            If cboState.Text <> "ALL" Then SelFormular = SelFormular + " AND {RptPayment.State}='" & cboState.Text & "'"
            If cCamp.Text <> "ALL" Then SelFormular = SelFormular + " AND {RptPayment.Camp}='" & cCamp.Text & "'"
        ElseIf UCase(Trim(ReportName)) = "STIPENDS SUMMARY - 2" Then
            RptFilename = New StipendsSummary
            SelFormular = " {RptPayment.PayPeriod}=cdate('" & PayPeriod & "')"
            If cboState.Text <> "ALL" Then SelFormular = SelFormular + " AND {RptPayment.State}='" & cboState.Text & "'"
            If cCamp.Text <> "ALL" Then SelFormular = SelFormular + " AND {RptPayment.Camp}='" & cCamp.Text & "'"
        ElseIf UCase(Trim(ReportName)) = "ANNUAL STIPEND ANALYSIS" Then
            RptFilename = New AnnualStipend
            SelFormular = " year({RptPayment.PayPeriod})=" & Year(CDate(PayPeriod))
            If cboState.Text <> "ALL" Then SelFormular = SelFormular + " AND {RptPayment.State}='" & cboState.Text & "'"
            If cCamp.Text <> "ALL" Then SelFormular = SelFormular + " AND {RptPayment.Camp}='" & cCamp.Text & "'"
        ElseIf UCase(Trim(ReportName)) = "PAYROLL SUMMARY" Then
            RptFilename = New PayrollSummary
            SelFormular = " year({RptPayment.PayPeriod})=" & Year(CDate(PayPeriod))
            If cboState.Text <> "ALL" Then SelFormular = SelFormular + " AND {RptPayment.State}='" & cboState.Text & "'"
            If cCamp.Text <> "ALL" Then SelFormular = SelFormular + " AND {RptPayment.Camp}='" & cCamp.Text & "'"
        ElseIf UCase(Trim(ReportName)) = "PAY SLIP" Then
            RptFilename = New Payslip
            SelFormular = " year({RptPayment.PayPeriod})=" & Year(CDate(PayPeriod))
            If cboState.Text <> "ALL" Then SelFormular = SelFormular + " AND {RptPayment.State}='" & cboState.Text & "'"
            If cCamp.Text <> "ALL" Then SelFormular = SelFormular + " AND {RptPayment.Camp}='" & cCamp.Text & "'"
            If cCamp.Text <> "ALL" Then SelFormular = SelFormular + " AND {RptPayment.Camp}='" & cCamp.Text & "'"
        ElseIf UCase(Trim(ReportName)) = "PAY SLIP WITH PHOTO" Then
            RptFilename = New PayslipWithPict
            SelFormular = " year({RptPayment.PayPeriod})=" & Year(CDate(PayPeriod))
            If cboState.Text <> "ALL" Then SelFormular = SelFormular + " AND {RptPayment.State}='" & cboState.Text & "'"
            If cCamp.Text <> "ALL" Then SelFormular = SelFormular + " AND {RptPayment.Camp}='" & cCamp.Text & "'"
        ElseIf UCase(Trim(ReportName)) = "LIST OF SUSPENDED EX-MILITANT" Then
            RptFilename = New SuspendedRegister
        End If
        RptDestination = "Screen"
        myReportDocument = RptFilename
        If SelFormular <> "" Then myCrystalReportViewer.SelectionFormula = SelFormular
        ConfigureCrystalReports()
        Me.Text = "Report: " + UCase(RptTitle)
        myCrystalReportViewer.ReportSource = myReportDocument
        myCrystalReportViewer.Zoom(100)

        If UCase(Trim(ReportName)) = "STIPENDS  SCHEDULE" Then
            RptFilename = New StipendSchedule1
            SelFormular = " {RptPayment.NoOfDelegate}>1 AND {RptPayment.PayPeriod}=cdate('" & PayPeriod & "')"
            If cboState.Text <> "ALL" Then SelFormular = SelFormular + " AND {RptPayment.State}='" & cboState.Text & "'"
            If cCamp.Text <> "ALL" Then SelFormular = SelFormular + " AND {RptPayment.Camp}='" & cCamp.Text & "'"

            'RptDestination = "Screen"
            'myReportDocument = RptFilename
            'If SelFormular <> "" Then myCrystalReportViewer.SelectionFormula = SelFormular
            'ConfigureCrystalReports()
            'Me.Text = "Report: " + UCase(RptTitle)
            'myCrystalReportViewer.ReportSource = myReportDocument
            'myCrystalReportViewer.Zoom(100)

            Dim ChildForm As New FrmRptDisplay
            ChildForm.RptTitle = UCase(Trim(ReportName))
            ChildForm.RptDestination = "Screen"
            ChildForm.myReportDocument = RptFilename
            If SelFormular <> "" Then ChildForm.SelFormula = SelFormular
            ChildForm.ShowDialog()


        End If
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)

    End Sub

    Private Sub cmdPeriod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPeriod.Click
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
        tPeriod.Text = Format(CDate(ReturnPayperiod), "MMM-yyyy")

        tPeriod.Focus()

        Exit Sub
errhdl:
        MsgBox(Err.Description, vbInformation, strApptitle)
    End Sub
    Private Sub mnuSchedule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSchedule.Click
        ReportName = mnuSchedule.Text
        lblReportTitle.Text = UCase(ReportName)
        'lblPeriod.ForeColor = Color.Red
        'lblState.ForeColor = Color.Red
        'lblCamp.ForeColor = Color.Red
        Panel6.Visible = False
    End Sub
    Private Sub mnuConSchedule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSummary1.Click
        ReportName = mnuSummary1.Text
        lblReportTitle.Text = UCase(ReportName)
        'lblPeriod.ForeColor = Color.Red
        'lblState.ForeColor = Color.Red
        'lblCamp.ForeColor = Color.Red
    End Sub

    Private Sub mnuAnnual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAnnual.Click
        ReportName = mnuAnnual.Text
        lblReportTitle.Text = UCase(ReportName)
        'lblPeriod.ForeColor = Color.Red
        'lblState.ForeColor = Color.Red
        'lblCamp.ForeColor = Color.Red
        Panel6.Visible = False
    End Sub
    Private Sub cboState_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboState.SelectedIndexChanged
        oLoadCamp()
    End Sub
    Private Sub mnuSummary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSummary.Click
        ReportName = mnuSummary.Text
        lblReportTitle.Text = UCase(ReportName)
        Panel6.Visible = False
    End Sub
    Private Sub mnuPayrollSummary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPayrollSummary.Click
        ReportName = mnuPayrollSummary.Text
        lblReportTitle.Text = UCase(ReportName)
        Panel6.Visible = False
    End Sub

    Private Sub mnuPaySlip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPaySlip.Click
        ReportName = mnuPaySlip.Text
        lblReportTitle.Text = UCase(ReportName)
        Panel6.Visible = False
    End Sub

    Private Sub mnuPayslipWithPict_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPayslipWithPict.Click
        ReportName = mnuPayslipWithPict.Text
        lblReportTitle.Text = UCase(ReportName)
        Panel6.Visible = False
    End Sub

    Private Sub mnuScheduleUnpaid_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuScheduleUnpaid.Click
        ReportName = mnuScheduleUnpaid.Text
        lblReportTitle.Text = UCase(ReportName)
        Panel6.Visible = False
    End Sub

    Private Sub mnuSuspended_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSuspended.Click
        ReportName = mnuSuspended.Text
        lblReportTitle.Text = UCase(ReportName)
        Panel6.Visible = False
    End Sub
    Private Sub Export2Excel()
        'Create a new workbook in Excel
        'On Error Resume Next
        'My.Application.DoEvents()
        On Error GoTo errhdl
        Dim PayPeriod As Date = CDate("01-" & Trim(tPeriod.Text))

        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        Dim hk As Integer
        cnSQL.Open()
        For hk = 1 To cboState.Items.Count - 1
            cboState.SelectedIndex = hk
            Dim oExcel As Object
            Dim xlbook As Object
            Dim xlsheet As Object
            oExcel = CreateObject("Excel.Application")

            If tDocFile.Text = "" Then
                MsgBox("Please select a location to save the file into", MsgBoxStyle.Information)
                Exit Sub
            End If
            Dim filename As String = tDocFile.Text + "\" + Trim(cboState.Text) + Format(PayPeriod, "MMM") + Mid(Trim(Str(Year(PayPeriod))), 3) + ".xls" ' Trim(tPeriod.Text) + ".xls" 'Path.GetTempFileName()
            On Error Resume Next

            Kill(filename)

            FileCopy(AppPath & "ConfigDir\" + "ExcelTemplate.xls", filename)

            On Error GoTo errhdl
            oExcel.Workbooks.open(filename)



            oExcel.Sheets(1).Select()

            oExcel.Visible = True

            oExcel.Cells(1, 1) = "BENEFICIARY NAME"
            oExcel.Cells(1, 2) = "BANK CODE"
            oExcel.Cells(1, 3) = "BANK ACCOUNT NO"
            oExcel.Cells(1, 4) = "AMOUNT"
            oExcel.Cells(1, 5) = "CURRENCY"
            oExcel.Cells(1, 6) = "COA ACCOUNT"
            oExcel.Cells(1, 7) = "FUND"
            oExcel.Cells(1, 8) = "PROGRAM"
            oExcel.Cells(1, 9) = "DISCRIPTION"
            oExcel.Cells(1, 10) = "PHONE"
            oExcel.Cells(1, 11) = "EMAIL"
            oExcel.Cells(1, 12) = "REFERENCE NO"

            Dim i As Integer

            cmSQL.Parameters.Clear()
            cmSQL.CommandText = "FetchPaymentbyState"
            cmSQL.Parameters.AddWithValue("@Period", PayPeriod)
            cmSQL.Parameters.AddWithValue("@State", cboState.Text)
            cmSQL.CommandType = CommandType.StoredProcedure
            drSQL = cmSQL.ExecuteReader()

            ' If drSQL.HasRows = False Then GoTo skipit

            Dim j As Integer = 2
            'Dim k As Integer = 0
            Do While drSQL.Read
                '  PayPeriod, Sn, Name, State, Camp, Bank, BankAcctNo, SortCode, Amount, NoInCamp, NoInState, NoOverall, NoOfDelegate, IDNo, Phone, Leader
                oExcel.Cells(j, 1) = drSQL.Item("Name")
                oExcel.Cells(j, 2) = IIf(Val(Mid(drSQL.Item("SortCode"), 1, 1)) = 0, "'" + drSQL.Item("SortCode").ToString, drSQL.Item("SortCode"))
                oExcel.Cells(j, 3) = IIf(Val(Mid(drSQL.Item("BankAcctNo"), 1, 1)) = 0, "'" + drSQL.Item("BankAcctNo").ToString, drSQL.Item("BankAcctNo"))
                oExcel.Cells(j, 4) = drSQL.Item("Amount")
                oExcel.Cells(j, 5) = "NGN"
                oExcel.Cells(j, 6) = "21020101"
                oExcel.Cells(j, 7) = "02430"
                oExcel.Cells(j, 8) = ""
                oExcel.Cells(j, 9) = Format(PayPeriod, "MMM") + " " + Trim(Str(Year(PayPeriod))) + " Allowance " + cboState.Text + " " + ThePhase
                oExcel.Cells(j, 10) = "0"
                oExcel.Cells(j, 11) = "0"
                oExcel.Cells(j, 12) = ""
                j = j + 1
                '  k = 1
            Loop
            'skipit:
            drSQL.Close()
            oExcel.Workbooks(1).Save()   'As(filename)

            'oExcel.Workbooks(1).PrintPreview()
            'End If
            oExcel.Workbooks(1).Close()
            oExcel.Quit()

        Next

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        MsgBox("Export Complete.....")
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub

    Private Sub mnuScheduleExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuScheduleExcel.Click
        ReportName = mnuScheduleExcel.Text
        lblReportTitle.Text = UCase(ReportName)
        Panel6.Visible = True
    End Sub

    Private Sub cmdGetFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetFile.Click
        If FolderBrowserDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            tDocFile.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub btnReportBuilder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReportBuilder.Click
        FrmReportBuilder.ShowDialog()
    End Sub

    Private Sub mnuStipendsNamesOnly_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuStipendsNamesOnly.Click
        ReportName = mnuStipendsNamesOnly.Text
        lblReportTitle.Text = UCase(ReportName)
        Panel6.Visible = False
    End Sub

    Private Sub mnuStipendsWithIDNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuStipendsWithIDNo.Click
        ReportName = mnuStipendsWithIDNo.Text
        lblReportTitle.Text = UCase(ReportName)
        'lblPeriod.ForeColor = Color.Red
        'lblState.ForeColor = Color.Red
        'lblCamp.ForeColor = Color.Red
        Panel6.Visible = False
    End Sub
End Class