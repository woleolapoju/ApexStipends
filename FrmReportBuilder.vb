Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.IO
Imports System.Threading
Imports System.Diagnostics
Imports System.Data.Common
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Public Class FrmReportBuilder
    Friend Enum CallFor
        SqlServerList
        SqlDataBases
        SqlTables
    End Enum
    Private connectionString As String
    Private sqlQuery As String
    Private connection As SqlConnection
    Private command As SqlCommand
    Private adapter As SqlDataAdapter
    Private builder As SqlCommandBuilder
    Private ds As DataSet
    Private tempDataSet As DataSet
    Private userTable As DataTable
    Private sqlInfo As FrmReportBuilderClass
    Private reader As SqlDataReader
    Private Delegate Function InternalDelegate() As String()
    Private Delegate Sub TimerDelegate(ByVal sender As Object, ByVal e As System.EventArgs)
    Private intlDelg As InternalDelegate
    Private Delegate Sub AsyncDelegate(ByVal result As IAsyncResult)
    Private called As CallFor
    Private currentIndex As Integer
    Private isLastPage As Boolean
    Private totalRecords As Integer
    Private currentPageStartRecord As Integer
    Private currentPageEndRecord As Integer
    Private Const getTablesFromDataBase As String = "SELECT NAME FROM SYSOBJECTS WHERE TYPE = 'U'"
    Dim LogicalCondition As String
    Private Sub FrmReportBuilder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        btnUpdate.Enabled = False
        sqlInfo = New FrmReportBuilderClass()
        grpDataManipulate.Enabled = False
        btnLoadSqlServers.Select()
        btnLoadSqlServers.Focus()
        prgProgress.Minimum = 0
        prgProgress.Maximum = 200
        '  intlDelg = New InternalDelegate(sqlInfo.EnumerateSQLServers)
        cmbNoOfRecords.SelectedIndex = 0
        btnFirst.Enabled = False
        btnPrevious.Enabled = False
        btnNext.Enabled = False
        btnLast.Enabled = False
        btnAdd.Enabled = False
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        cmbNoOfRecords.Enabled = False

        cmbSqlServers.Items.Add(ServerName)
        cmbSqlServers.Text = ServerName


        txtUserName.Text = UserID
        txtPassword.Text = Password
        cmbAllDataBases.Items.Add(AttachName)
        cmbAllDataBases.Text = AttachName
        chkWinAuthen.Checked = IntegratedSecurity


        'Dim sender As Object = Nothing
        'Dim e As EventArgs = Nothing

        'applyGridTheme(userDataGridView)
        userDataGridView.ReadOnly = True


        btnGetAllTables_Click(sender, e)

    End Sub
    Private Sub SetDataObjects()
        connection = New SqlConnection(connectionString)
        command = New SqlCommand(sqlQuery, connection)
        adapter = New SqlDataAdapter(command)
        builder = New SqlCommandBuilder(adapter)
        ds = New DataSet("MainDataSet")
        tempDataSet = New DataSet("TempDataSet")
    End Sub

    Private Sub btnLoad_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLoad.Click
        oLoad("SELECT * FROM [" & cmbTables.Text.Trim() & "]")
    End Sub
    Private Sub oLoad(ByVal strQuery As String)
        '  lblLoadedTable.Text = "Loading data from table " + cmbTables.Text.Trim();
        btnLoad.Enabled = False
        Me.Cursor = Cursors.WaitCursor
        Try
            If userTable IsNot Nothing Then
                userTable.Clear()
            End If
            userDataGridView.DataSource = Nothing
            userDataGridView.Rows.Clear()
            userDataGridView.Refresh()
            sqlQuery = strQuery '"SELECT * FROM [" & cmbTables.Text.Trim() & "]"
            SetDataObjects()
            connection.Open()
            Timer1.Start()
            adapter.Fill(tempDataSet)
            totalRecords = tempDataSet.Tables(0).Rows.Count
            tempDataSet.Clear()
            tempDataSet.Dispose()
            adapter.Fill(ds, 0, 5, cmbTables.Text.Trim())
            userTable = ds.Tables(cmbTables.Text.Trim())
            tQuery.Tag = "SELECT "
            cboDataField.Items.Clear()
            cboSortBy.Items.Clear()
            For Each dc As DataColumn In userTable.Columns
                Dim column As New DataGridViewTextBoxColumn()
                column.DataPropertyName = dc.ColumnName
                column.HeaderText = dc.ColumnName
                column.Name = dc.ColumnName
                column.SortMode = DataGridViewColumnSortMode.Automatic
                column.ValueType = dc.DataType
                userDataGridView.Columns.Add(column)
                If tQuery.Tag = "SELECT " Then
                    tQuery.Tag = tQuery.Tag + dc.ColumnName
                Else
                    tQuery.Tag = tQuery.Tag + "," + dc.ColumnName
                End If
                cboDataField.Items.Add(dc.ColumnName)
                cboSortBy.Items.Add(dc.ColumnName)
            Next dc
            If tQuery.Tag = "SELECT " Then
                tQuery.Tag = "SELECT * FROM [" & cmbTables.Text.Trim() & "]"
            Else
                tQuery.Tag = tQuery.Tag + " FROM [" & cmbTables.Text.Trim() & "]"
            End If
            tQuery.Text = tQuery.Tag

            '   lblLoadedTable.Text = "Data loaded from table: " + userTable.TableName;
            lblTotRecords.Text = "Total records: " & totalRecords
            btnAdd.Enabled = True
            btnUpdate.Enabled = True
            btnDelete.Enabled = True
            cmbNoOfRecords.Enabled = True

            If cmbNoOfRecords.Text.Trim() = "ALL" Then

                CreateTempTable(0, totalRecords) ' int.Parse(lblTotRecords.Text.Trim()));

                btnFirst.Enabled = False
                btnPrevious.Enabled = False
                btnNext.Enabled = False
                btnLast.Enabled = False
                grpDataManipulate.Enabled = False
            Else
                CreateTempTable(0, Integer.Parse(cmbNoOfRecords.Text.Trim()))
                If Integer.Parse(cmbNoOfRecords.Text.Trim()) > totalRecords Then
                    btnFirst.Enabled = False
                    btnPrevious.Enabled = False
                    btnNext.Enabled = False
                    btnLast.Enabled = False
                    grpDataManipulate.Enabled = False
                Else
                    btnFirst.Enabled = True
                    btnPrevious.Enabled = True
                    btnNext.Enabled = True
                    btnLast.Enabled = True
                    grpDataManipulate.Enabled = True
                End If
                'btnPrevious.Enabled = true;
                'btnFirst.Enabled = true;
                'btnPrevious.Enabled = true;
                'btnNext.Enabled = true;
                'btnLast.Enabled = true;

            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            connection.Close()
            btnLoad.Enabled = True
            Me.Cursor = Cursors.Default
            prgProgress.Value = 0
            prgProgress.Update()
            prgProgress.Refresh()
            Timer1.Stop()
        End Try
    End Sub
    Private Sub CreateTempTable(ByVal startRecord As Integer, ByVal noOfRecords As Integer)
        If startRecord = 0 OrElse startRecord < 0 Then
            btnPrevious.Enabled = False
            startRecord = 0
        End If
        Dim endRecord As Integer = startRecord + noOfRecords
        If endRecord >= totalRecords Then
            btnNext.Enabled = False
            isLastPage = True
            endRecord = totalRecords
        End If
        currentPageStartRecord = startRecord
        currentPageEndRecord = endRecord
        lblPageNums.Text = "Records from " & startRecord & " to " & endRecord & " of " & totalRecords
        currentIndex = endRecord

        Try
            userTable.Rows.Clear()
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            adapter.Fill(ds, startRecord, noOfRecords, cmbTables.Text.Trim())
            userTable = ds.Tables(cmbTables.Text.Trim())
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            connection.Close()
        End Try

        userDataGridView.DataSource = userTable.DefaultView
        userDataGridView.AllowUserToResizeColumns = True
    End Sub
    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        Try
            userDataGridView.ReadOnly = False
            btnAdd.Enabled = False
            btnUpdate.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUpdate.Click
        Try
            connection.Open()
            adapter.Update(userTable)
            userDataGridView.ReadOnly = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            btnUpdate.Enabled = True
        Finally
            btnAdd.Enabled = True
            btnLoad.Enabled = True
            connection.Close()
        End Try
    End Sub
    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Do you really want to delete selected record(s)?", "Delete Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, 0, False) = DialogResult.Yes Then
            Try
                connection.Open()
                Dim cnt As Integer = userDataGridView.SelectedRows.Count
                For i As Integer = 0 To cnt - 1
                    If Me.userDataGridView.SelectedRows.Count > 0 AndAlso Me.userDataGridView.SelectedRows(0).Index <> Me.userDataGridView.Rows.Count - 1 Then
                        Me.userDataGridView.Rows.RemoveAt(Me.userDataGridView.SelectedRows(0).Index)
                    End If
                Next i

                adapter.Update(userTable)
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            Finally
                connection.Close()
                btnLoad.Enabled = True
            End Try
        End If
    End Sub

    Private Sub btnLoadSqlServers_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLoadSqlServers.Click
        Timer1.Start()
        btnLoadSqlServers.Enabled = False
        Me.Cursor = Cursors.WaitCursor
        cmbSqlServers.Items.Clear()
        cmbSqlServers.Items.Add(ServerName)
        called = CallFor.SqlServerList
        intlDelg.BeginInvoke(New AsyncCallback(AddressOf CallBackMethod), intlDelg)

        cmbSqlServers.Text = ServerName

    End Sub

    Private Sub btnGetAllDataBases_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGetAllDataBases.Click
        If cmbSqlServers.Items.Count > 0 AndAlso txtPassword.Text.Trim().CompareTo(String.Empty) <> 0 AndAlso txtUserName.Text.Trim().CompareTo(String.Empty) <> 0 Then
            Timer1.Start()
            btnGetAllDataBases.Enabled = False
            Me.Cursor = Cursors.WaitCursor
            cmbAllDataBases.Items.Clear()
            sqlInfo.SQLServer = cmbSqlServers.Text.Trim()
            sqlInfo.Username = txtUserName.Text.Trim()
            sqlInfo.Password = txtPassword.Text.Trim()
            MessageBox.Show("You may get the list sql servers if user name and password are not correct.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0, False)
            ' intlDelg = New InternalDelegate(sqlInfo.EnumerateSQLServersDatabases)
            called = CallFor.SqlDataBases
            intlDelg.BeginInvoke(New AsyncCallback(AddressOf CallBackMethod), sqlInfo.EnumerateSQLServersDatabases)
        Else
            MessageBox.Show("No sql servers loaded or user name or password empty...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, 0, False)
        End If
    End Sub

    Private Sub btnGetAllTables_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGetAllTables.Click
        If cmbAllDataBases.Text.Trim().CompareTo(String.Empty) <> 0 Then
            btnGetAllTables.Enabled = False
            Me.Cursor = Cursors.WaitCursor
            Dim connStr As New StringBuilder()
            connStr.Append("Database=")
            connStr.Append(cmbAllDataBases.Text)
            connStr.Append(";Server=")
            connStr.Append(cmbSqlServers.Text)
            connStr.Append(";User=")
            connStr.Append(txtUserName.Text.Trim())
            connStr.Append(";Password=")
            connStr.Append(txtPassword.Text.Trim())
            connStr.Append(";Enlist=false; Asynchronous Processing=true")
            connectionString = connStr.ToString()
            sqlQuery = getTablesFromDataBase
            SetDataObjects()
            Try
                Timer1.Start()
                connection.Open()
                command.BeginExecuteReader(New AsyncCallback(AddressOf CallBackMethod), command, CommandBehavior.CloseConnection)
                called = CallFor.SqlTables
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
                Timer1.Stop()
            Finally
                btnGetAllTables.Enabled = True
                Me.Cursor = Cursors.Default
            End Try
        Else
            MessageBox.Show("Please select database first.", "No database", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, 0, False)
        End If
    End Sub
    Private Sub CallBackMethod(ByVal result As IAsyncResult)
        If Me.InvokeRequired Then
            Me.Invoke(New AsyncDelegate(AddressOf CallBackMethod), result)
        Else
            Try
                prgProgress.Value = prgProgress.Maximum
                Select Case called
                    Case CallFor.SqlServerList
                        Dim sqlServers() As String = intlDelg.EndInvoke(result)
                        cmbSqlServers.Items.AddRange(sqlServers)
                        If cmbSqlServers.Items.Count > 0 Then
                            cmbSqlServers.Sorted = True
                            cmbSqlServers.SelectedIndex = 0
                        End If
                        Me.Cursor = Cursors.Default
                        btnLoadSqlServers.Enabled = True
                        txtUserName.Select()
                        txtUserName.Focus()
                    Case CallFor.SqlDataBases
                        Dim sqlDatabases() As String = intlDelg.EndInvoke(result)
                        cmbAllDataBases.Items.AddRange(sqlDatabases)
                        If cmbAllDataBases.Items.Count > 0 Then
                            cmbAllDataBases.Sorted = True
                            cmbAllDataBases.SelectedIndex = 0
                        End If
                        Me.Cursor = Cursors.Default
                        btnGetAllDataBases.Enabled = True
                    Case CallFor.SqlTables
                        reader = command.EndExecuteReader(result)
                        cmbTables.Items.Clear()
                        Do While reader.Read()
                            cmbTables.Items.Add(reader(0).ToString())
                        Loop
                        If cmbTables.Items.Count > 0 Then
                            cmbTables.Sorted = True
                            cmbTables.SelectedIndex = 0
                            grpDataManipulate.Enabled = True
                        Else
                            grpDataManipulate.Enabled = False
                        End If
                End Select
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            Finally
                If called = CallFor.SqlTables Then
                    btnGetAllTables.Enabled = True
                    Me.Cursor = Cursors.Default
                End If
                prgProgress.Value = 0
                prgProgress.Refresh()
                Timer1.Stop()
            End Try
        End If
    End Sub
    Private Sub btnFirst_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFirst.Click
        CreateTempTable(0, Integer.Parse(cmbNoOfRecords.Text))
        btnPrevious.Enabled = False
        btnNext.Enabled = True
        btnLast.Enabled = True
        isLastPage = False
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrevious.Click
        If isLastPage Then
            Dim noc As Integer = FindLastPageRecords()
            CreateTempTable((totalRecords - noc - Integer.Parse(cmbNoOfRecords.Text)), Integer.Parse(cmbNoOfRecords.Text))
        Else
            CreateTempTable((currentIndex - 2 * (Integer.Parse(cmbNoOfRecords.Text))), Integer.Parse(cmbNoOfRecords.Text))
        End If
        btnNext.Enabled = True
        btnLast.Enabled = True
        isLastPage = False
    End Sub

    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNext.Click
        CreateTempTable(currentIndex, Integer.Parse(cmbNoOfRecords.Text))
        btnPrevious.Enabled = True
    End Sub

    Private Sub btnLast_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLast.Click
        'INSTANT VB WARNING: Instant VB cannot determine whether both operands of this division are integer types - if they are then you should use the VB integer division operator:
        Dim totPages As Integer = totalRecords / Integer.Parse(cmbNoOfRecords.Text)
        Dim remainingRecs As Integer = FindLastPageRecords()

        CreateTempTable(totalRecords - remainingRecs, Integer.Parse(cmbNoOfRecords.Text))
        btnPrevious.Enabled = True
        btnNext.Enabled = False
        isLastPage = True
    End Sub
    Private Function FindLastPageRecords() As Integer
        Return (totalRecords Mod Integer.Parse(cmbNoOfRecords.Text))
    End Function

    Private Sub btnNoOfPages_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNoOfPages.Click
        If cmbNoOfRecords.Text.Trim() = "ALL" Then

            CreateTempTable(0, totalRecords) ' int.Parse(lblTotRecords.Text.Trim()));

            btnFirst.Enabled = False
            btnPrevious.Enabled = False
            btnNext.Enabled = False
            btnLast.Enabled = False
            grpDataManipulate.Enabled = False
        Else
            CreateTempTable(0, Integer.Parse(cmbNoOfRecords.Text.Trim()))
            If Integer.Parse(cmbNoOfRecords.Text.Trim()) > totalRecords Then
                btnFirst.Enabled = False
                btnPrevious.Enabled = False
                btnNext.Enabled = False
                btnLast.Enabled = False
                grpDataManipulate.Enabled = False
            Else
                btnFirst.Enabled = True
                btnPrevious.Enabled = True
                btnNext.Enabled = True
                btnLast.Enabled = True
                grpDataManipulate.Enabled = True
            End If
        End If
    End Sub
    Private Sub chkWinAuthen_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkWinAuthen.CheckedChanged
        If chkWinAuthen.Checked = True Then
            txtUserName.Enabled = False
            txtPassword.Enabled = False
        Else
            txtUserName.Enabled = True
            txtPassword.Enabled = True
        End If
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRefresh.Click
        btnLoad_Click(sender, e)

    End Sub

    Private Sub panel3_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles panel3.DoubleClick
        Dim value As String = ""
        value = InputBox("Modification Access", "Enter Passcode:", value, True)
        If value = "Admin.." Then
            btnAdd.Visible = True
            btnUpdate.Visible = True
            btnDelete.Visible = True
            userDataGridView.ReadOnly = False
        End If

    End Sub


    Private Sub panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles panel3.Paint

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.InvokeRequired Then
            Me.Invoke(New TimerDelegate(AddressOf Timer1_Tick), sender, e)
        Else
            If prgProgress.Value = prgProgress.Maximum Then
                prgProgress.Value = 0
            Else
                prgProgress.Value += 20
            End If
        End If
    End Sub
    Private Sub cmdQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQuery.Click
        GroupBox1.Tag = tQuery.Text
        oLoad(tQuery.Text)
        tQuery.Text = GroupBox1.Tag
    End Sub
    Private Sub mnuExportToExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExportToExcel.Click
        On Error GoTo handler
        Dim oXL As Object
        oXL = CreateObject("Excel.Application")
        oXL.Visible = True
        oXL.Workbooks.Add()

        oXL.Sheets(1).Select()

        oXL.Visible = True

        ' Format A1:D1 as bold, vertical alignment = center.
        With oXL.Sheets(1).Range("A1", "AZ1")
            .Font.Bold = True
            ' .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        End With

        Dim jk As Integer = 0
        Dim j As Integer
        Dim i As Integer
        For j = 0 To userDataGridView.ColumnCount - 1
            oXL.Cells(1, j + 1) = userDataGridView.Columns(j).Name.ToString()
        Next

        For i = 0 To userDataGridView.RowCount - 1
            If userDataGridView.Rows(i).Selected = True Then
                For j = 0 To userDataGridView.ColumnCount - 1
                    If IsNumeric(userDataGridView(j, i).Value) = True Then
                        ' If Val(Mid(userDataGridView(j, i).Value, 1, 1)) = 0 Then
                        oXL.Cells(jk + 2, j + 1).NumberFormat = "@"
                        oXL.Cells(jk + 2, j + 1) = userDataGridView(j, i).Value '.ToString()
                        'Else
                        '    oXL.Cells(jk + 2, j + 1) = userDataGridView(j, i).Value '.ToString()
                        'End If
                    Else
                        oXL.Cells(jk + 2, j + 1) = userDataGridView(j, i).Value.ToString()
                    End If
                Next
                jk = jk + 1
            End If
        Next

        ' Make sure Excel is visible and give the user control
        ' of Excel's lifetime.

        oXL.UserControl = True

        ' Make sure that you release object references.
        oXL.Quit()
        oXL = Nothing

        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, vbInformation, strApptitle)
    End Sub

    Private Sub mnuCopyToClipboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCopyToClipboard.Click

        userDataGridView.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText

        If userDataGridView.GetCellCount(DataGridViewElementStates.Selected) > 0 Then

            Try

                ' Add the selection to the clipboard.
                Clipboard.SetDataObject(userDataGridView.GetClipboardContent())

                ' Replace the text box contents with the clipboard text.
                'Me.TextBox1.Text = Clipboard.GetText()
                MsgBox("Successfull!!")
            Catch ex As System.Runtime.InteropServices.ExternalException
                MsgBox("The Clipboard could not be accessed. Please try again.")
            End Try

        End If
    End Sub

    Private Sub cmdLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLoad.Click
        On Error GoTo errorhandle
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        cnSQL.Open()

        cboValue.Items.Clear()

        Dim TheWhere = "" 'IIf(chkLoadPeriod.Checked, " WHERE [Date]>='" & sysStartDate & "' AND [Date]<='" & sysEndDate & "'", "")
1:
        cmSQL.CommandText = "SELECT DISTINCT [" & cboDataField.Text & "] FROM [" & cmbTables.Text.Trim() & "]" & TheWhere
        cmSQL.CommandType = CommandType.Text


        drSQL = cmSQL.ExecuteReader()

        If drSQL.HasRows = False Then Exit Sub

        Do While drSQL.Read
            cboValue.Items.Add(ChkNull(drSQL.GetValue(0)))
        Loop
        cboValue.SelectedIndex = 0
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        Exit Sub
        Resume
errorhandle:
        If Err.Number = 5 Then
            TheWhere = ""
            GoTo 1
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
    End Sub

    Private Sub cboDataField_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDataField.SelectedIndexChanged
        cboValue.Items.Clear()
        cboValue.Text = ""
    End Sub
    Private Sub cmdOR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOR.Click
        LogicalCondition = " OR "
    End Sub

    Private Sub cmdAND_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAND.Click
        LogicalCondition = " AND "
    End Sub

    Private Sub chkSortOrder_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSortOrder.CheckedChanged
        CompileSQLStmt()
    End Sub

    Private Sub cboSortBy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSortBy.SelectedIndexChanged
        CompileSQLStmt()
    End Sub
    Private Sub CompileSQLStmt()
        On Error GoTo errhdl
        'If TheFrom = "" Then Exit Sub
        'txtSQL.Text = ""
        'cboValue.Text = ""
        'Dim choice As Integer = 0
        'Dim SQLstmnt As String = "Select Distinct "
        'Dim i As Integer
        'For i = 0 To lbField.Items.Count - 1
        '    If lbField.GetSelected(i) = True Then
        '        choice = 1
        '        SQLstmnt = SQLstmnt & " [" & Mid(lbField.Items.Item(i).ToString, InStr(lbField.Items.Item(i).ToString, ".") + 1) & "],"
        '    End If
        'Next i
        'If choice = 1 Then
        '    SQLstmnt = Microsoft.VisualBasic.Left(SQLstmnt, Len(SQLstmnt) - 1)
        'Else
        '    SQLstmnt = SQLstmnt & " *"
        'End If
        'SQLstmnt = SQLstmnt & " FROM"

        'SQLstmnt = SQLstmnt & " " & TheFrom & ","
        'SQLstmnt = Microsoft.VisualBasic.Left(SQLstmnt, Len(SQLstmnt) - 1)

        If txtCondition.Text <> "" Then
            tQuery.Text = tQuery.Tag & " WHERE " & txtCondition.Text
        End If
        If cboSortBy.Text <> "" Then tQuery.Text = tQuery.Text & " ORDER BY " & " [" & Mid(cboSortBy.Text, InStr(cboSortBy.Text, ".") + 1) & "]" & IIf(chkSortOrder.Checked, " ASC", " DESC")
        'txtSQL.Text = SQLstmnt

        ' DisplayRpt()

        Exit Sub
errhdl:
        MsgBox(Err.Description, vbInformation, strApptitle)
    End Sub

    Private Sub cmdInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInsert.Click
        On Error GoTo errhdl
        If cboCondition.Text = "" Or cboDataField.Text = "" Or cboValue.Text = "" Then
            MsgBox("Choose A Field, the Condition,and the Value")
            Exit Sub
        End If
        Dim FieldType As System.Type = Nothing
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        cnSQL.Open()

        cmSQL.CommandText = "SELECT * FROM [" & cmbTables.Text.Trim() & "]"
        cmSQL.CommandType = CommandType.Text


        drSQL = cmSQL.ExecuteReader()

        If drSQL.HasRows = False Then Exit Sub
        Dim i As Integer
        For i = 0 To drSQL.FieldCount - 1
            If drSQL.GetName(i) = cboDataField.Text Then
                FieldType = drSQL.GetFieldType(i)
                Exit For
            End If
        Next i
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        Select Case FieldType.ToString
            Case Is = "System.String", "System.Byte", "System.DateTime" '6, 131
                If txtCondition.Text = "" Then
                    txtCondition.Text = txtCondition.Text & " [" & Mid(cboDataField.Text, InStr(cboDataField.Text, ".") + 1) & "] " & IIf(cboCondition.Text = "Start with" Or cboCondition.Text = "End with", "Like", cboCondition.Text) & "'" & IIf(cboCondition.Text = "Like", "%", "") & IIf(cboCondition.Text = "End with", "%", "") & cboValue.Text & IIf(cboCondition.Text = "Like", "%", "") & IIf(cboCondition.Text = "Start with", "%", "") & "'"
                Else
                    If LogicalCondition = "" Then
                        MsgBox("Please select the logical operator 'AND/OR'", vbInformation, strApptitle)
                        Exit Sub
                    End If
                    txtCondition.Text = txtCondition.Text & LogicalCondition & " [" & Mid(cboDataField.Text, InStr(cboDataField.Text, ".") + 1) & "] " & IIf(cboCondition.Text = "Start with" Or cboCondition.Text = "End with", "Like", cboCondition.Text) & "'" & IIf(cboCondition.Text = "Like", "%", "") & IIf(cboCondition.Text = "End with", "%", "") & cboValue.Text & IIf(cboCondition.Text = "Like", "%", "") & IIf(cboCondition.Text = "Start with", "%", "") & "'"
                End If
            Case Is = "System.Boolean" ' Boolean fields
                If txtCondition.Text = "" Then
                    txtCondition.Text = txtCondition.Text & " [" & Mid(cboDataField.Text, InStr(cboDataField.Text, ".") + 1) & "] " & IIf(cboCondition.Text = "Start with" Or cboCondition.Text = "End with", "Like", cboCondition.Text) & IIf(cboValue.Text = "True", 1, 0)
                Else
                    If LogicalCondition = "" Then
                        MsgBox("Please select the logical operator 'AND/OR'", vbInformation, strApptitle)
                        Exit Sub
                    End If
                    txtCondition.Text = txtCondition.Text & LogicalCondition & " [" & Mid(cboDataField.Text, InStr(cboDataField.Text, ".") + 1) & "] " & IIf(cboCondition.Text = "Start with" Or cboCondition.Text = "End with", "Like", cboCondition.Text) & IIf(cboValue.Text = "True", 1, 0)
                End If
            Case Else 'Numbers
                If txtCondition.Text = "" Then
                    txtCondition.Text = txtCondition.Text & " [" & Mid(cboDataField.Text, InStr(cboDataField.Text, ".") + 1) & "] " & IIf(cboCondition.Text = "Start with" Or cboCondition.Text = "End with", "Like", cboCondition.Text) & cboValue.Text
                Else
                    If LogicalCondition = "" Then
                        MsgBox("Please select the logical operator 'AND/OR'", vbInformation, strApptitle)
                        Exit Sub
                    End If
                    txtCondition.Text = txtCondition.Text & LogicalCondition & " [" & Mid(cboDataField.Text, InStr(cboDataField.Text, ".") + 1) & "] " & IIf(cboCondition.Text = "Start with" Or cboCondition.Text = "End with", "Like", cboCondition.Text) & cboValue.Text
                End If
        End Select
        cboValue.Text = ""
        LogicalCondition = ""
        CompileSQLStmt()
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbInformation, strApptitle)

    End Sub
End Class