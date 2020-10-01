Imports System.IO
Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class FrmImportData
    Private bindingSource As New BindingSource()
    Private dataAdapter As New SqlDataAdapter()
    Private Sub FrmImportData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillStates()

    End Sub

    Private Sub cmdGetFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetFile.Click
        Try
            Dgrid.DataSource = Nothing
            Dgrid.Rows.Clear()
            Dgrid.Columns.Clear()

            Dim openFileDialog1 As New OpenFileDialog() 'create openfileDialog Object
            openFileDialog1.Filter = "XML Files (*.xml; *.xls; *.xlsx; *.xlsm; *.xlsb) |*.xml; *.xls; *.xlsx; *.xlsm; *.xlsb" 'open file format define Excel Files(.xls)|*.xls| Excel Files(.xlsx)|*.xlsx|
            openFileDialog1.FilterIndex = 3

            openFileDialog1.Multiselect = False 'not allow multiline selection at the file selection level
            openFileDialog1.Title = "Select file" 'define the name of openfileDialog
            openFileDialog1.InitialDirectory = "Desktop" 'define the initial directory
            cboSheet.Items.Clear()

            If openFileDialog1.ShowDialog() = DialogResult.OK Then 'executing when file open
                Dim pathName As String = openFileDialog1.FileName
                Dim fileName As String = System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.FileName)
                Dim tbContainer As New DataTable()
                Dim strConn As String = String.Empty
                txtFileName.Tag = fileName
                txtFileName.Text = pathName
                Dim file As New FileInfo(pathName)
                If Not file.Exists Then
                    Throw New Exception("Error, file doesn't exists!")
                End If
                Dim extension As String = file.Extension
                Select Case extension
                    Case ".xls"
                        strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & pathName & ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;'"
                    Case ".xlsx"
                        strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & pathName & ";Extended Properties='Excel 12.0;HDR=Yes;IMEX=1;'"
                    Case Else
                        strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & pathName & ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;'"
                End Select

                Me.Tag = strConn

                GetExcelSheetNames(pathName, strConn)

                Import(Me.Tag.ToString(), txtFileName.Text, cboSheet.Text.ToString())

            End If
            'OpenFileDialog fdlg = new OpenFileDialog();
            'fdlg.Title = "Select file";
            'fdlg.InitialDirectory = @"c:\";
            'fdlg.FileName = txtFileName.Text;
            'fdlg.Filter = "Excel Sheet(*.xls)|*.xls|All Files(*.*)|*.*";
            'fdlg.FilterIndex = 1;
            'fdlg.RestoreDirectory = true;
            'if (fdlg.ShowDialog() == DialogResult.OK)
            '{
            '    txtFileName.Text = fdlg.FileName;
            '    Import();
            '    Application.DoEvents();

        Catch ex As Exception
            MessageBox.Show(ex.Message, strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub
    Private Sub Import(ByVal connString As String, ByVal sheetName As String, ByVal dSheetName As String)
        Try
            Dgrid.DataSource = Nothing
            Dgrid.Rows.Clear()
            Dgrid.Columns.Clear()

            Dim tbContainer As New DataTable()
            Dim cnnxls As New OleDbConnection(connString)
            '  OleDbDataAdapter oda = new OleDbDataAdapter(string.Format("select * from [{0}$]", sheetName), cnnxls);
            Dim oda As New OleDbDataAdapter(String.Format("select * from [" & dSheetName & "]", sheetName), cnnxls)

            oda.Fill(tbContainer)

            Dgrid.DataSource = tbContainer


            lblCountUploadData.Text = "List Count:" & Dgrid.RowCount.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message, strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Try
    End Sub
    Private Sub GetExcelSheetNames(ByVal excelFile As String, ByVal connString As String)
        Dim objConn As OleDbConnection = Nothing
        Dim dt As System.Data.DataTable = Nothing

        Try
            Dgrid.DataSource = Nothing
            cboSheet.Items.Clear()
            cboSheet.Text = ""

            objConn = New OleDbConnection(connString)
            objConn.Open()
            dt = objConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, Nothing)

            If dt Is Nothing Then
                Return
            End If

            Dim excelSheets(dt.Rows.Count - 1) As String
            Dim i As Integer = 0

            ' Add the sheet name to the string array.
            For Each row As DataRow In dt.Rows
                cboSheet.Items.Add(row("TABLE_NAME").ToString())
                i += 1
            Next row

            ' Loop through all of the sheets if you want too...
            For j As Integer = 0 To excelSheets.Length - 1
                ' Query each excel sheet.
            Next j
            cboSheet.SelectedIndex = 0
            Return
        Catch ex As Exception
            MessageBox.Show(ex.Message, strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            ' Clean up.
            If objConn IsNot Nothing Then
                objConn.Close()
                objConn.Dispose()
            End If
            If dt IsNot Nothing Then
                dt.Dispose()
            End If
        End Try
    End Sub
    Private Sub cmdLoad_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdLoad.Click
        Import(Me.Tag.ToString(), txtFileName.Text, cboSheet.Text.ToString())
    End Sub
    Private Sub cboSheet_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboSheet.SelectedIndexChanged
        'Dgrid.DataSource = null;
        'Dgrid.Rows.Clear();
        'Dgrid.Columns.Clear();
        cmdLoad_Click(sender, e)
    End Sub
    
    Private Sub cmdUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpload.Click
        Try
            If Dgrid.Columns.Count <> DGridReal.Columns.Count Then
                MessageBox.Show("Invalid Column Mapping", strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
       

            If Dgrid.RowCount < 1 Then
                MessageBox.Show("No record to upload", strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

          

            Dim myTrans As SqlTransaction = Nothing
            Dim cnSQL As New SqlConnection(strConnect)
            Dim cmSQL As New SqlCommand()
            cmSQL.Connection = cnSQL
            cnSQL.Open()

            myTrans = cnSQL.BeginTransaction()
                cmSQL.Transaction = myTrans
            Dim i As Integer = 0
            Dim g As Integer=0
            For i = 0 To Dgrid.RowCount - 1
                If Dgrid(0, i).Value Is Nothing Then GoTo skipIt
                If Trim(Dgrid(0, i).Value) = "" Then GoTo skipIt
                cmSQL.Parameters.Clear()
                cmSQL.CommandText = "InsertRegister4Import"
                cmSQL.CommandType = CommandType.StoredProcedure

                g = GetColumnIndex(0) : cmSQL.Parameters.AddWithValue("@Sn", (If(Dgrid(g, i).Value Is Nothing, g, Dgrid(g, i).Value)))
                g = GetColumnIndex(1) : cmSQL.Parameters.AddWithValue("@Name", (If(Dgrid(g, i).Value Is Nothing, "", Dgrid(g, i).Value)))
                g = GetColumnIndex(2) : cmSQL.Parameters.AddWithValue("@State", (If(Dgrid(g, i).Value Is Nothing, "", Dgrid(g, i).Value)))
                g = GetColumnIndex(3) : cmSQL.Parameters.AddWithValue("@Camp", (If(Dgrid(g, i).Value Is Nothing, "", Dgrid(g, i).Value)))
                g = GetColumnIndex(4) : cmSQL.Parameters.AddWithValue("@Bank", (If(Dgrid(g, i).Value Is Nothing, "", Dgrid(g, i).Value)))
                g = GetColumnIndex(5) : cmSQL.Parameters.AddWithValue("@BankAcctNo", (If(Dgrid(g, i).Value Is Nothing, "", Dgrid(g, i).Value)))
                g = GetColumnIndex(6) : cmSQL.Parameters.AddWithValue("@SortCode", (If(Dgrid(g, i).Value Is Nothing, "", Dgrid(g, i).Value)))
                g = GetColumnIndex(7) : cmSQL.Parameters.AddWithValue("@Remark", (If(Dgrid(g, i).Value Is Nothing, "", Dgrid(g, i).Value)))
                cmSQL.Parameters.AddWithValue("@StopPay", 0) '(If(Dgrid(g, i).Value Is Nothing, False, Convert.ToBoolean(Dgrid(g, i).Value))))
                cmSQL.Parameters.AddWithValue("@NoOfDelegate", 1) ' (If(Dgrid(g, i).Value Is Nothing, 1, Val(Dgrid(g, i).Value))))
                cmSQL.Parameters.AddWithValue("@IDNO", "Uploaded")
                'cmSQL.Parameters.AddWithValue("@IDNo", (If(Dgrid(10, i).Value Is Nothing, "", Dgrid(10, i).Value)))
                'cmSQL.Parameters.AddWithValue("@Phone", (If(Dgrid(11, i).Value Is Nothing, "", Dgrid(11, i).Value)))
                'cmSQL.Parameters.AddWithValue("@Leader", (If(Dgrid(12, i).Value Is Nothing, "", Dgrid(12, i).Value)))
                cmSQL.ExecuteNonQuery()
skipIt:
            Next

            myTrans.Commit()



            oLoadDbgrid()

            MessageBox.Show("Successfull!", strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            If ex.ToString().Contains("Violation of PRIMARY KEY constraint") Then
                MessageBox.Show("Duplicate record exist", strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' myTrans.Rollback();
            Else
                MessageBox.Show(ex.Message, strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End Try

    End Sub
    Function GetColumnIndex(ByVal displayIndex As Integer)

        GetColumnIndex = 0
        For index As Integer = 0 To Dgrid.ColumnCount - 1
            If Dgrid.Columns(index).DisplayIndex = displayIndex Then
                GetColumnIndex = Dgrid.Columns(index).Index 'index
            End If
        Next
    End Function
    Private Sub Dgrid_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles Dgrid.CellClick
        Try
            Dgrid.Tag = Dgrid.Columns(e.ColumnIndex).Index
            Me.Tag = e.ColumnIndex
            panel1.Tag = e.RowIndex

        Catch

        End Try
    End Sub
    Private Sub mnuRemoveColumn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuRemoveColumn.Click
        Try
            Dgrid.Columns.RemoveAt(Dgrid.Tag) '.Remove((Dgrid.Tag.ToString())
            Dim upperBound As Integer = Dgrid.ColumnCount - 1
            Dim columnIndexes(upperBound) As String

            For index As Integer = 0 To upperBound
                Dim column As DataGridViewColumn = Dgrid.Columns(index)

                columnIndexes(column.DisplayIndex) = index.ToString()
            Next
        Catch

        End Try
    End Sub
    Private Sub mnuAddColumn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuAddColumn.Click
        Try
            Dim value As String = ""
            Dim dtCol As New DataGridViewColumn()
            value = InputBox("Add Column", "Enter Column Name:", value)
            If value <> "" Then
                dtCol.HeaderText = value
            End If

            ' dtCol.Name = "ID_New";

            dtCol.CellTemplate = New DataGridViewTextBoxCell()
            Dgrid.Columns.Insert(Dgrid.Tag + 1, dtCol)
            ' Dgrid.Columns.Insert((Dgrid.Columns(Dgrid.Tag.ToString()).Index + 1, dtCol)
         
        Catch

        End Try
    End Sub
    Private Sub mnuInsertColumn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuInsertColumn.Click
        Try
            Dim value As String = ""
            Dim dtCol As New DataGridViewColumn()
            value = InputBox("Insert Column", "Enter Column Name:", value)
            If value <> "" Then
                dtCol.HeaderText = value
            End If

            ' dtCol.Name = "ID_New";

            dtCol.CellTemplate = New DataGridViewTextBoxCell()
            Dgrid.Columns.Insert(Dgrid.Tag, dtCol)
            ' Dgrid.Columns.Insert(Dgrid.Columns(Dgrid.Tag.ToString()).Index, dtCol)
       
        Catch

        End Try
    End Sub
    Private Sub FillStates()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cboState.Items.Clear()

        'cmSQL.CommandText = "SELECT DISTINCT State FROM StateCamp ORDER BY State"
        cmSQL.CommandText = "SELECT DISTINCT State FROM Register ORDER BY State"
        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            cboState.Items.Add(drSQL.Item("State").ToString)
            ' State.Items.Add(drSQL.Item("State").ToString)
        Loop
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()
        ' cboState.Items.Add("ALL")
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
        'If cboState.Text = "ALL" Then
        '    cmSQL.CommandText = "SELECT DISTINCT Camp FROM Register ORDER BY Camp"
        'Else
        cmSQL.CommandText = "SELECT DISTINCT Camp FROM Register WHERE state='" & cboState.Text & "' ORDER BY [Camp]"
        'End If
        cmSQL.CommandType = CommandType.Text
        '   cCamp.Items.Add("ALL")
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

        oLoadDbgrid()



        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, vbInformation, strApptitle)
    End Sub

    Private Sub oLoadDbgrid()
        On Error GoTo errhdl
        Dim i As Integer

     
        DGridReal.DataSource = Nothing
        DGridReal.Rows.Clear()
        DGridReal.Columns.Clear()
        DGridReal.DataSource = bindingSource

        lblListCount.Text = "List Count:0"
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        Dim strQry1 As String = ""
        Dim strCamp As String = ""
        Dim strQry As String = "SELECT Sn, Name, State, Camp, Bank, BankAcctNo, SortCode,Remark FROM Register " ' IDNo, Phone, Leader"
        If cboState.Text <> "ALL" Then strQry1 = " WHERE State ='" & cboState.Text & "'"
        If cCamp.Text <> "ALL" Then strQry1 = strQry1 + IIf(strQry1 = "", " WHERE ", " AND ") + " Camp ='" & cCamp.Text & "'"
        strQry = strQry + strQry1 + " ORDER BY State,Camp,Sn"
       
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
        Dim myStyle1 As New DataGridViewCellStyle
        myStyle.ForeColor = Color.Red
        myStyle1.ForeColor = Color.Black
        '; myStyle1.Format

        lblListCount.Text = "List Count:" & DGridReal.RowCount.ToString()

        DGridReal.Columns(6).HeaderText = "Bank Code"

        'DGridReal.Columns("RefNo").Visible = False
        'DGridReal.Columns("SchoolID").Visible = False
        'DGridReal.Columns("Remark").Visible = False
        'DGridReal.Columns("InActive").Visible = False

        GetLastNo()

        Exit Sub
        Resume
errhdl:
        If Err.Number = 91 Or Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If


    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        On Error GoTo handler

        Me.dataAdapter.Update(CType(bindingSource.DataSource, DataTable))
        MsgBox("Update successfull", MsgBoxStyle.Information, strApptitle)

        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cmSQL.CommandText = "UPDATE Register SET Camp='' WHERE Camp is null"
        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        cmSQL.ExecuteNonQuery()

        cmSQL.CommandText = "UPDATE Register SET SortCode='' WHERE SortCode is null"
        cmSQL.CommandType = CommandType.Text
        cmSQL.ExecuteNonQuery()
        cmSQL.CommandText = "UPDATE Register SET StopPay=0 WHERE StopPay is null"
        cmSQL.CommandType = CommandType.Text
        cmSQL.ExecuteNonQuery()

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()


        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub

    Private Sub cCamp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cCamp.SelectedIndexChanged
        oLoadDbgrid()
    End Sub

    Private Sub cboState_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboState.SelectedIndexChanged
        oLoadCamp()
    End Sub

    Private Sub cboSheet_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSheet.SelectedIndexChanged
        cmdLoad_Click(sender, e)
    End Sub
    Private Sub GetLastNo()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        Dim strQry As String = "SELECT ISNULL(MAX(Sn),0) AS Sn FROM Register WHERE State ='" & cboState.Text & "'"
        If cCamp.Text <> "ALL" Then strQry = strQry + " AND " + " Camp ='" & cCamp.Text & "'"

        cmSQL.CommandText = strQry
        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then GoTo SkipIt
        If drSQL.Read() Then
            lnkLast.Text = "Last Sn:" + drSQL.Item("Sn").ToString
            lnkLast.Tag = drSQL.Item("Sn")
        End If
SkipIt:
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        Exit Sub
        Resume
handler:
        If Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If
    End Sub

    Private Sub lnkLast_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkLast.LinkClicked
        If Dgrid.RowCount < 1 Then
            MessageBox.Show("No record to update SN", strApptitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

      
        Dim i As Integer = 0
        Dim j As Integer = Val(lnkLast.Tag) + 1
        For i = 0 To Dgrid.RowCount - 1
            Dgrid.Item("Sn", i).Value = j
            j = j + 1
        Next

    End Sub

    Private Sub Dgrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dgrid.CellContentClick

    End Sub

    Private Sub mnuReplicateValueDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReplicateValueDown.Click
        Try
            Dim i As Integer = 0
            Dim theValue As String = Dgrid.Item(Me.Tag, panel1.Tag).Value
            For i = panel1.Tag + 1 To Dgrid.RowCount - 1
                Dgrid.Item(Me.Tag, i).Value = theValue
            Next
        Catch

        End Try
    End Sub

    Private Sub mnuIncrement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuIncrement.Click
        Try
            Dim i As Integer = 0
            Dim j As Integer = 1
            Dim theValue As Integer = Dgrid.Item(Me.Tag, panel1.Tag).Value
            For i = panel1.Tag + 1 To Dgrid.RowCount - 1
                If Dgrid.Item(1, i).Value Is Nothing Then GoTo skipIt
                If Trim(Dgrid.Item(1, i).Value) = "" Then GoTo skipIt
                Dgrid.Item(Me.Tag, i).Value = theValue + j
                j = j + 1
skipIt:
            Next
        Catch

        End Try
    End Sub

    Private Sub Dgrid_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles Dgrid.RowsRemoved
        lblCountUploadData.Text = "List Count:" & Dgrid.RowCount.ToString()
    End Sub
End Class