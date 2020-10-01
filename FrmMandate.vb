Imports System.Data.SqlClient
Imports System.IO
Public Class FrmMandate
    Private bindingSource As New BindingSource()
    Private dataAdapter As New SqlDataAdapter()
    Public ReturnPayperiod As String
    Public RptSelection As String
    Private Sub FrmMandate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mnuEMandateForRemital.ForeColor = Color.Black
        mnuEMandateForTSA.ForeColor = Color.Red
        RptSelection = "TSA1"
        tPeriod.Text = Format(Now, "MMM-yyyy")

        FillStates()


        Me.DGridList.DataSource = bindingSource
        DGridList.AutoGenerateColumns = True

        lblCount.Text = ""

        On Error Resume Next
        cboBudgetLine.Items.Add(My.Settings.BudgetLine)
        cboBudgetLine.Text = My.Settings.BudgetLine

    End Sub
    Private Sub mnuEMandateForRemital_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEMandateForRemital.Click
        mnuEMandateForRemital.ForeColor = Color.Red
        mnuEMandateForTSA.ForeColor = Color.Black
        RptSelection = "Remital"
    End Sub
   
    Private Sub cmdGetFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetFile.Click
        If FolderBrowserDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            tDocFile.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub
    Private Sub Export2ExcelTSAplsClean()
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
        'For hk = 1 To cboState.Items.Count - 1
        '    cboState.SelectedIndex = hk
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
        oExcel.Cells(1, 9) = "DESCRIPTION"
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
            oExcel.Cells(j, 1) = CleanMe(drSQL.Item("Name"))
            oExcel.Cells(j, 2) = CleanMe(IIf(Val(Mid(drSQL.Item("SortCode"), 1, 1)) = 0, "'" + drSQL.Item("SortCode").ToString, drSQL.Item("SortCode")))
            oExcel.Cells(j, 3) = CleanMe(IIf(Val(Mid(drSQL.Item("BankAcctNo"), 1, 1)) = 0, "'" + drSQL.Item("BankAcctNo").ToString, drSQL.Item("BankAcctNo")))
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

        'Next

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        'MsgBox("Export Complete.....")
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub
    Private Sub Export2ExcelTSA()
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
        'For hk = 1 To cboState.Items.Count - 1
        '    cboState.SelectedIndex = hk
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
        oExcel.Cells(1, 9) = "DESCRIPTION"
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

        'Next

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        'MsgBox("Export Complete.....")
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub
    Private Sub Export2ExcelTSA2()
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
        'For hk = 1 To cboState.Items.Count - 1
        '    cboState.SelectedIndex = hk
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

        oExcel.Cells(1, 1) = "Employee"
        oExcel.Cells(1, 2) = "Bank Account"
        oExcel.Cells(1, 3) = "Description"
        oExcel.Cells(1, 4) = "Amount"
        oExcel.Cells(1, 5) = "Currency"
        oExcel.Cells(1, 6) = "Budget Line"
        oExcel.Cells(1, 7) = "Is Advance Payment"


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
            oExcel.Cells(j, 1) = drSQL.Item("IDNo")
            oExcel.Cells(j, 2) = IIf(Val(Mid(drSQL.Item("BankAcctNo"), 1, 1)) = 0, "'" + drSQL.Item("BankAcctNo").ToString, drSQL.Item("BankAcctNo"))
            oExcel.Cells(j, 3) = Format(PayPeriod, "MMM") + " " + Trim(Str(Year(PayPeriod))) + " Allowance " + cboState.Text + " " + ThePhase
            oExcel.Cells(j, 4) = drSQL.Item("Amount")
            oExcel.Cells(j, 5) = "NGN"
            oExcel.Cells(j, 6) = cboBudgetLine.Text
            oExcel.Cells(j, 7) = "0"
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

        'Next

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        'MsgBox("Export Complete.....")

        On Error Resume Next
        'Save BudgetLine to Sysfile
        If cboBudgetLine.Text.Trim.Length > 0 Then
            My.Settings.BudgetLine = cboBudgetLine.Text
        End If
        My.Settings.Save()

        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub

    Private Sub Export2ExcelTSA2plsClean()
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
        'For hk = 1 To cboState.Items.Count - 1
        '    cboState.SelectedIndex = hk
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

        oExcel.Cells(1, 1) = "Employee"
        oExcel.Cells(1, 2) = "Bank Account"
        oExcel.Cells(1, 3) = "Description"
        oExcel.Cells(1, 4) = "Amount"
        oExcel.Cells(1, 5) = "Currency"
        oExcel.Cells(1, 6) = "Budget Line"
        oExcel.Cells(1, 7) = "Is Advance Payment"

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

            oExcel.Cells(j, 1) = CleanMe(drSQL.Item("IDNo"))
            oExcel.Cells(j, 2) = CleanMe(IIf(Val(Mid(drSQL.Item("BankAcctNo"), 1, 1)) = 0, "'" + drSQL.Item("BankAcctNo").ToString, drSQL.Item("BankAcctNo")))
            oExcel.Cells(j, 3) = Format(PayPeriod, "MMM") + " " + Trim(Str(Year(PayPeriod))) + " Allowance " + cboState.Text + " " + ThePhase
            oExcel.Cells(j, 4) = drSQL.Item("Amount")
            oExcel.Cells(j, 5) = "NGN"
            oExcel.Cells(j, 6) = cboBudgetLine.Text
            oExcel.Cells(j, 7) = "0"

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

        'Next

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        'MsgBox("Export Complete.....")

       

        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub
    Private Sub Export2ExcelRemital()
        On Error GoTo errhdl
        Dim PayPeriod As Date = CDate("01-" & Trim(tPeriod.Text))

        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        Dim hk As Integer

        If tDocFile.Text = "" Then
            MsgBox("Please select a location to save the file into", MsgBoxStyle.Information)
            Exit Sub
        End If

        cnSQL.Open()
        'For hk = 1 To cboState.Items.Count - 1
        '    cboState.SelectedIndex = hk

        Dim filename As String = tDocFile.Text + "\" + Trim(cboState.Text) + Format(PayPeriod, "MMM") + Mid(Trim(Str(Year(PayPeriod))), 3) + ".csv" ' Trim(tPeriod.Text) + ".xls" 'Path.GetTempFileName()
        On Error Resume Next

        Kill(filename)

        Dim stLine As String = ""

        On Error GoTo errhdl

        If File.Exists(filename) Then
            File.Delete(filename)
        End If

        Dim objWriter As System.IO.StreamWriter
        objWriter = My.Computer.FileSystem.OpenTextFileWriter(filename, True)


        'If IO.File.Exists(filename) Then
        '    objWriter.Write("00,")
        '    objWriter.Write("00,")
        '    objWriter.Write(20 & ",")
        '    objWriter.Write("0,")
        '    objWriter.Write(",")
        '    objWriter.Write(",")

        '    objWriter.Write("DUMMY,")

        '    objWriter.Write(0 & ",") 'Mobile
        '    objWriter.Write(0 & ",") 'Email
        '    objWriter.Write(0 & ",") 'WITHOLDING TAX(%)
        '    objWriter.Write(0) 'TAX OFFICE
        '    objWriter.Write(Environment.NewLine)
        'End If

        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchPaymentbyState"
        cmSQL.Parameters.AddWithValue("@Period", PayPeriod)
        cmSQL.Parameters.AddWithValue("@State", cboState.Text)
        cmSQL.CommandType = CommandType.StoredProcedure
        drSQL = cmSQL.ExecuteReader()


        Do While drSQL.Read

            If IO.File.Exists(filename) Then

                If drSQL.Item("Amount") > 0 Then
                    objWriter.Write(drSQL.Item("SortCode") & ",")
                    objWriter.Write(drSQL.Item("BankAcctNo") & ",")
                    'objWriter.Write(IIf(Val(Mid(drSQL.Item("SortCode"), 1, 1)) = 0, "'" + drSQL.Item("SortCode").ToString, drSQL.Item("SortCode")) & ",")
                    'objWriter.Write(IIf(Val(Mid(drSQL.Item("BankAcctNo"), 1, 1)) = 0, "'" + drSQL.Item("BankAcctNo").ToString, drSQL.Item("BankAcctNo")) & ",")
                    objWriter.Write(20 & ",")
                    objWriter.Write(drSQL.Item("Amount") & ",")
                    objWriter.Write(Format(PayPeriod, "MMM") + Trim(Str(Year(PayPeriod))) + " Allowance" & ",")
                    objWriter.Write(Format(PayPeriod, "MMM") + " " + Trim(Str(Year(PayPeriod))) + " Allowance " + cboState.Text + " " + ThePhase & ",")


                    If drSQL.Item("Name").Contains(",") Then
                        objWriter.Write(Replace(drSQL.Item("Name"), ",", " ") & ",")
                    Else
                        objWriter.Write(drSQL.Item("Name") & ",")
                    End If
                    ''If value contains comma in the value then you have to perform this opertions
                    'Dim append = If(drSQL.Item("Name").Contains(","), String.Format("""{0}""", drSQL.Item("Name")), drSQL.Item("Name"))
                    'stLine = String.Format("{0}{1},", stLine, append)
                    'objWriter.Write(stLine) 'Name

                    objWriter.Write(0 & ",") 'Mobile
                    objWriter.Write(0 & ",") 'Email
                    objWriter.Write(0 & ",") 'WITHOLDING TAX(%)
                    objWriter.Write(0) 'TAX OFFICE
                    objWriter.Write(Environment.NewLine)
                End If
            End If

        Loop
        objWriter.Close()
        'skipit:
        drSQL.Close()

        'Next

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

    Private Sub Export2ExcelRemitalPlsClean()
        On Error GoTo errhdl
        Dim PayPeriod As Date = CDate("01-" & Trim(tPeriod.Text))

        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        Dim hk As Integer

        If tDocFile.Text = "" Then
            MsgBox("Please select a location to save the file into", MsgBoxStyle.Information)
            Exit Sub
        End If

        cnSQL.Open()
        'For hk = 1 To cboState.Items.Count - 1
        '    cboState.SelectedIndex = hk

        Dim filename As String = tDocFile.Text + "\" + Trim(cboState.Text) + Format(PayPeriod, "MMM") + Mid(Trim(Str(Year(PayPeriod))), 3) + ".csv" ' Trim(tPeriod.Text) + ".xls" 'Path.GetTempFileName()
        On Error Resume Next

        Kill(filename)

        Dim stLine As String = ""

        On Error GoTo errhdl

        If File.Exists(filename) Then
            File.Delete(filename)
        End If

        Dim objWriter As System.IO.StreamWriter
        objWriter = My.Computer.FileSystem.OpenTextFileWriter(filename, True)


        'If IO.File.Exists(filename) Then
        '    objWriter.Write("00,")
        '    objWriter.Write("00,")
        '    objWriter.Write(20 & ",")
        '    objWriter.Write("0,")
        '    objWriter.Write(",")
        '    objWriter.Write(",")

        '    objWriter.Write("DUMMY,")

        '    objWriter.Write(0 & ",") 'Mobile
        '    objWriter.Write(0 & ",") 'Email
        '    objWriter.Write(0 & ",") 'WITHOLDING TAX(%)
        '    objWriter.Write(0) 'TAX OFFICE
        '    objWriter.Write(Environment.NewLine)
        'End If

        cmSQL.Parameters.Clear()
        cmSQL.CommandText = "FetchPaymentbyState"
        cmSQL.Parameters.AddWithValue("@Period", PayPeriod)
        cmSQL.Parameters.AddWithValue("@State", cboState.Text)
        cmSQL.CommandType = CommandType.StoredProcedure
        drSQL = cmSQL.ExecuteReader()


        Do While drSQL.Read

            If IO.File.Exists(filename) Then

                If drSQL.Item("Amount") > 0 Then
                    objWriter.Write(CleanMe(drSQL.Item("SortCode") & ","))
                    objWriter.Write(CleanMe(drSQL.Item("BankAcctNo") & ","))
                    'objWriter.Write(CleanMe(IIf(Val(Mid(drSQL.Item("SortCode"), 1, 1)) = 0, "'" + drSQL.Item("SortCode").ToString, drSQL.Item("SortCode")) & ","))
                    'objWriter.Write(CleanMe(IIf(Val(Mid(drSQL.Item("BankAcctNo"), 1, 1)) = 0, "'" + drSQL.Item("BankAcctNo").ToString, drSQL.Item("BankAcctNo")) & ","))
                    objWriter.Write(20 & ",")
                    objWriter.Write(drSQL.Item("Amount") & ",")
                    objWriter.Write(Format(PayPeriod, "MMM") + Trim(Str(Year(PayPeriod))) + " Allowance" & ",")
                    objWriter.Write(Format(PayPeriod, "MMM") + " " + Trim(Str(Year(PayPeriod))) + " Allowance " + cboState.Text + " " + ThePhase & ",")

                    If drSQL.Item("Name").Contains(",") Then
                        objWriter.Write(Replace(CleanMe(drSQL.Item("Name")), ",", " ") & ",")
                    Else
                        objWriter.Write(CleanMe(drSQL.Item("Name")) & ",")
                    End If

                    ''If value contains comma in the value then you have to perform this opertions
                    'Dim append = If(drSQL.Item("Name").Contains(","), String.Format("""{0}""", drSQL.Item("Name")), drSQL.Item("Name"))
                    'stLine = String.Format("{0}{1},", stLine, append)
                    'objWriter.Write(stLine) 'Name

                    objWriter.Write(0 & ",") 'Mobile
                    objWriter.Write(0 & ",") 'Email
                    objWriter.Write(0 & ",") 'WITHOLDING TAX(%)
                    objWriter.Write(0) 'TAX OFFICE
                    objWriter.Write(Environment.NewLine)
                End If
            End If

        Loop
        objWriter.Close()
        'skipit:
        drSQL.Close()

        'Next

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        ' MsgBox("Export Complete.....")

        Exit Sub
        Resume
errhdl:
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

        'cboState.SelectedIndex = 0

        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub
    Private Sub cboState_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboState.SelectedIndexChanged
        oLoadCamp()
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

    Private Sub oLoadDbgrid()
        On Error GoTo errhdl
        Dim i As Integer

        'DGridList.DataSource = bindingSource
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        Dim strQry1 As String = ""
        Dim strCamp As String = ""
        Dim strQry As String = "SELECT  Sn, Name,State, Camp, Bank, BankAcctNo, SortCode, Amount FROM Payment "
        strQry1 = " WHERE PayPeriod ='" & CDate("01-" & Trim(tPeriod.Text)) & "'"
        If cboState.Text <> "ALL" Then strQry1 = strQry1 + IIf(strQry1 = "", "", " AND ") + " State ='" & cboState.Text & "'"
        If cCamp.Text <> "ALL" Then strQry1 = strQry1 + IIf(strQry1 = "", "", " AND ") + " Camp ='" & cCamp.Text & "'"
        'If strQry1 <> "" Then
        strQry = strQry + strQry1 + " ORDER BY State,Camp,Sn"
        'If strQry1 = "" Then
        '    cmSQL.CommandText = "FetchAllRegister"
        '    cmSQL.CommandType = CommandType.StoredProcedure
        'Else
        cmSQL.CommandText = strQry
        cmSQL.CommandType = CommandType.Text
        'End If
        dataAdapter = New SqlDataAdapter(cmSQL)
        Dim commandBuilder As New SqlCommandBuilder(Me.dataAdapter)
        Dim table As New DataTable()
        table.Locale = System.Globalization.CultureInfo.InvariantCulture
        Me.dataAdapter.Fill(table)
        Me.bindingSource.DataSource = table

        Dim myStyle As New DataGridViewCellStyle
        myStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        myStyle.Format = "N2"

        lblCount.Text = "List count:" + GetCount().ToString

        DGridList.Columns(0).Visible = False
        DGridList.Columns(1).Width = 230
        DGridList.Columns(2).Width = 100
        DGridList.Columns(3).Width = 150
        DGridList.Columns(4).Width = 120
        DGridList.Columns(5).Width = 150
        DGridList.Columns(6).Width = 80
        DGridList.Columns(7).DefaultCellStyle = myStyle

        Exit Sub
        Resume
errhdl:
        If Err.Number = 91 Or Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If


    End Sub

    Function GetCount() As Integer
        GetCount = 0
        Dim j As Integer = -1
        Dim i As Integer
        For i = 0 To DGridList.Rows.Count - 1
            j = j + 1
        Next
        GetCount = j
    End Function

    Private Sub cCamp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cCamp.SelectedIndexChanged
        oLoadDbgrid()

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

        oLoadDbgrid()

        Exit Sub
errhdl:
        MsgBox(Err.Description, vbInformation, strApptitle)
    End Sub

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        If DGridList.RowCount <= 0 Then
            MsgBox("Pls. select Mandate criteria", vbInformation, strApptitle)
            Exit Sub
        End If

        If tDocFile.Text = "" Then
            MsgBox("Please select a location to save the file into", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim hk As Integer = 0
        If RptSelection = "TSA1" Then
            If chkClean.Checked = False Then
                If cboState.Text = "ALL" Then
                    For hk = 1 To cboState.Items.Count - 1
                        cboState.SelectedIndex = hk
                        Export2ExcelTSA()
                    Next
                Else
                    Export2ExcelTSA()
                End If
            Else

                If cboState.Text = "ALL" Then
                    For hk = 1 To cboState.Items.Count - 1
                        cboState.SelectedIndex = hk
                        Export2ExcelTSAplsClean()
                    Next
                Else
                    Export2ExcelTSAplsClean()
                End If
            End If

        End If
        If RptSelection = "TSA2" Then
            If chkClean.Checked = False Then
                If cboState.Text = "ALL" Then
                    For hk = 1 To cboState.Items.Count - 1
                        cboState.SelectedIndex = hk
                        Export2ExcelTSA2()
                    Next
                Else
                    Export2ExcelTSA2()
                End If
            Else

                If cboState.Text = "ALL" Then
                    For hk = 1 To cboState.Items.Count - 1
                        cboState.SelectedIndex = hk
                        Export2ExcelTSA2plsClean()
                    Next
                Else
                    Export2ExcelTSA2plsClean()
                End If
            End If

            On Error Resume Next
            'Save BudgetLine to Sysfile
            If cboBudgetLine.Text.Trim.Length > 0 Then
                My.Settings.BudgetLine = cboBudgetLine.Text
            End If
            My.Settings.Save()

        End If
        If RptSelection = "Remital" Then
            If chkClean.Checked = False Then
                If cboState.Text = "ALL" Then
                    For hk = 1 To cboState.Items.Count - 1
                        cboState.SelectedIndex = hk
                        Export2ExcelRemital()
                    Next
                Else
                    Export2ExcelRemital()
                End If
            Else
                If cboState.Text = "ALL" Then
                    For hk = 1 To cboState.Items.Count - 1
                        cboState.SelectedIndex = hk
                        Export2ExcelRemitalPlsClean()
                    Next
                Else
                    Export2ExcelRemitalPlsClean()
                End If
            End If
        End If

        MsgBox("Export Complete.....")

    End Sub
    Private Function CleanMe(ByVal dText As String)
        On Error GoTo handler
        dText = Trim(dText)
        CleanMe = dText
        If Len(dText) > 0 Then
            If Asc(Mid(dText, 1)) < 32 Or Asc(Mid(dText, 1)) > 126 Then
                dText = Mid(dText, 2)
            End If

            If Asc(Microsoft.VisualBasic.Right(dText, 1)) < 32 Or Asc(Microsoft.VisualBasic.Right(dText, 1)) > 126 Then
                dText = Mid(dText, 1, Len(dText) - 1)
            End If
        End If
        CleanMe = dText

        Exit Function
        Resume
handler:
        If Err.Number = 5 Or Err.Number = 13 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Function
    Private Function AdvanceCleanMe(ByVal theStr As String) As String
        On Error GoTo errh
        Dim j As Integer = 0
        AdvanceCleanMe = ""
        Dim NewStr As String = ""
        For j = 1 To Len(theStr)
            If Asc(Mid(theStr, j, 1)) < 32 Or Asc(Mid(theStr, j, 1)) > 126 Then
            Else
                NewStr = NewStr + Mid(theStr, j, 1)
            End If
        Next
        'If theStr = NewStr Then
        '    AdvanceCleanMe = "@@%%%%%%DDTDTT!!!!!!!!!!!&&***********1223334344"
        'Else
        AdvanceCleanMe = NewStr
        'End If
        Exit Function
errh:
        MsgBox(Err.Description)
    End Function

    Private Sub mnuLAYOUT1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLAYOUT1.Click
       mnuEMandateForRemital.ForeColor = Color.Black
        mnuLAYOUT1.ForeColor = Color.Red
        RptSelection = "TSA1"
    End Sub

    Private Sub mnuLAYOUT2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLAYOUT2.Click
        mnuEMandateForRemital.ForeColor = Color.Black
        mnuLAYOUT2.ForeColor = Color.Red
        RptSelection = "TSA2"
    End Sub
End Class