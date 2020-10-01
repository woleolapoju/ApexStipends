Imports System.Data.Sqlclient
Imports System.IO
Public Class FrmRegistration
    Dim ReturnID As String
    Dim selectedTVQry As String
    Dim OnlyFirstItem As Boolean = False
    Private bindingSource As New BindingSource()
    Private dataAdapter As New SqlDataAdapter()
    Dim imageIndex As Integer = 0
    Private Sub FrmRegister_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillStates()
        FillBank()

        Me.DGridList.DataSource = bindingSource
        DGridList.AutoGenerateColumns = False
        oLoadDbgrid()

        cboCriteria.SelectedIndex = 1

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
        cboState.Items.Add("ALL")
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
    Private Sub FillBank()
        'On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        ' Bank1.Items.Clear()
        cboBank.Items.Clear()
        ' cboBank.Items.Add("")
        cmSQL.CommandText = "SELECT DISTINCT Bank FROM Bank ORDER BY Bank"
        'cmSQL.CommandText = "SELECT DISTINCT Bank FROM Register ORDER BY Bank"
        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Do While drSQL.Read
            ' Bank1.Items.Add(drSQL.Item("Bank"))
            cboBank.Items.Add(drSQL.Item("Bank"))
        Loop
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
    Private Sub oLoadDbgrid()
        On Error GoTo errhdl
        Dim i As Integer

        'FillBank()
        'oLoadCampCombox("ffff")
        'DGridList.DataSource = Nothing

        'DGridList.DataSource = bindingSource
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        Dim strQry1 As String = ""
        Dim strCamp As String = ""
        Dim strQry As String = "SELECT * FROM Register "
        If cboState.Text <> "ALL" Then strQry1 = " WHERE State ='" & cboState.Text & "'"
        If cCamp.Text <> "ALL" Then strQry1 = strQry1 + IIf(strQry1 = "", " WHERE ", " AND ") + " Camp ='" & cCamp.Text & "'"
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
        Dim myStyle1 As New DataGridViewCellStyle
        myStyle.ForeColor = Color.Red
        myStyle1.ForeColor = Color.Black
        '; myStyle1.Format

        lblCount.Text = GetCount()

        DGridList.Columns(6).HeaderText = "Bank Code"

        Exit Sub
        Resume
errhdl:
        If Err.Number = 91 Or Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If


    End Sub
    Private Sub DGridList_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGridList.CellClick
        On Error GoTo skipIt
        'cmdNew.Tag = ""
        'cmdNew.Tag = DGridList.Item(0, e.RowIndex).Value
        imageIndex = e.ColumnIndex

        FrmImage.Sn = DGridList.Item(0, e.RowIndex).Value

        If DGridList.Item(2, e.RowIndex).Value Is Nothing Then
            FrmImage.tState = ""
        Else
            FrmImage.tState = DGridList.Item(2, e.RowIndex).Value
        End If
        If DGridList.Item(3, e.RowIndex).Value Is Nothing Then
            FrmImage.tCamp = ""
        Else
            FrmImage.tCamp = DGridList.Item(3, e.RowIndex).Value
        End If

        Exit Sub
skipIt:
        Err.Clear()
    End Sub
    Private Sub DGridList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGridList.DoubleClick
        If imageIndex = 13 Then
            imageIndex = 1
            FrmImage.ShowDialog()
        End If

    End Sub
    Private Sub DGridList_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGridList.CellEndEdit
        On Error GoTo errhdl
        'If e.ColumnIndex = 2 Then
        '    oLoadCampCombox(DGridList.Item(e.ColumnIndex, e.RowIndex).Value)
        'End If
        '    DGridList.Item(5, e.RowIndex).Value = Format(DGridList.Item(5, e.RowIndex).Value, "standard")

        'End If
        'If e.ColumnIndex = 6 Then
        '    DGridList.Item(6, e.RowIndex).Value = Format(DGridList.Item(6, e.RowIndex).Value, "standard")

        'End If

        Exit Sub
errhdl:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub

    Private Sub oLoadCamp()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        cCamp.Items.Clear()
        If cboState.Text = "ALL" Then
            cmSQL.CommandText = "SELECT DISTINCT Camp FROM Register ORDER BY Camp"
        Else
            cmSQL.CommandText = "SELECT DISTINCT Camp FROM Register WHERE state='" & cboState.Text & "' ORDER BY [Camp]"
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

        oLoadDbgrid()



        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, vbInformation, strApptitle)
    End Sub

    '    Private Sub oLoadCampCombox(ByVal theState As String)
    '        On Error GoTo handler
    '        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
    '        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
    '        Dim drSQL As SqlDataReader
    '        Camp1.Items.Clear()
    '        'cmSQL.CommandText = "SELECT DISTINCT Camp FROM StatesAndCamps WHERE state='" & theState & "' ORDER BY [Camp]"
    '        cmSQL.CommandText = "SELECT DISTINCT Camp FROM StatesAndCamps ORDER BY [Camp]"
    '        cmSQL.CommandType = CommandType.Text
    '        cnSQL.Open()
    '        drSQL = cmSQL.ExecuteReader()
    '        If drSQL.HasRows = False Then Exit Sub
    '        Do While drSQL.Read
    '            Camp1.Items.Add(ChkNull(drSQL.Item("Camp")))
    '        Loop
    '        cmSQL.Connection.Close()
    '        cmSQL.Dispose()
    '        drSQL.Close()
    '        cnSQL.Close()
    '        cnSQL.Dispose()

    '        Exit Sub
    '        Resume
    'handler:
    '        MsgBox(Err.Description, vbInformation, strApptitle)
    '    End Sub


    Private Sub cboType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboState.SelectedIndexChanged
        oLoadCamp()
    End Sub
    Private Sub cCamp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cCamp.SelectedIndexChanged
        oLoadDbgrid()
    End Sub
    Private Sub DGridList_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DGridList.DataError
        If e.Context = DataGridViewDataErrorContexts.Commit Then
            DGridList.Rows(e.RowIndex).ErrorText = e.Exception.ToString
            e.Cancel = True
        End If
        ' MsgBox(e.Exception.Message)
    End Sub
    Private Sub lnkBank_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkBank.LinkClicked
        FrmBank.ShowDialog()
        FillBank()
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
    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        oLoadDbgrid()
    End Sub
    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        If Not DGridList.IsCurrentCellInEditMode Then
            DGridList.Focus()
            DGridList.CurrentCell = DGridList.Rows(DGridList.Rows.Count - 1).Cells("Sn")
            DGridList.Focus()
            'SendKeys.Send("{BS}")

            'SendKeys.Send("11")

        End If
    End Sub
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
   
    Private Sub cmdUpdateBank_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdateBank.Click
        On Error GoTo errhdl
        If cboBank.Text = "" Then
            MsgBox("Pls. select Bank", MsgBoxStyle.Information, strApptitle)
            Exit Sub
        End If
        Dim i As Integer
        Dim j As Integer = 0
        Dim k As Integer = 0
        For i = 0 To DGridList.RowCount - 1
            If DGridList.Rows(i).Selected = True Then
                If k = 0 Then k = i
                DGridList.Item(4, i).Value = cboBank.Text
                j = j + 1
            End If
        Next
        If k <> 0 Then DGridList.Item(4, k).Value = cboBank.Text
        If j > 0 Then
            MsgBox(j.ToString + " records affected", MsgBoxStyle.Information, strApptitle)
        Else
            MsgBox("Pls. select records", MsgBoxStyle.Information, strApptitle)
        End If
        Exit Sub
errhdl:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub
    Private Sub cmdPaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPaste.Click
        On Error GoTo erhh
        txt.Text = ""
        txt.Text = Clipboard.GetText()
        
        On Error GoTo handler

        Dim j As Integer = 0
        Dim i As Integer = 0
        Select Case cPaste.Text
            Case Is = "Sn" : j = 0
            Case Is = "Name" : j = 1
            Case Is = "State" : j = 2
            Case Is = "Camp" : j = 3
            Case Is = "Bank"
                j = 4
                'DGridList.Columns(j).DefaultCellStyle
                Dim Bank1 As New System.Windows.Forms.DataGridViewTextBoxColumn
            Case Is = "BankAcctNo" : j = 5
            Case Is = "SortCode" : j = 6
            Case Is = "NoofDelegate" : j = 7
            Case Else
                j = -1
        End Select

        If j = -1 Then
            MsgBox("Pls select column to paste", MsgBoxStyle.Information, strApptitle)
        End If
        Dim f As Integer = 0
        If chkPaste.Checked = True Then
            Dim jk As Integer = InStr(txt.Text, Chr(13))
            '  DGridList.DataSource = Nothing

            Do While jk > 0
                'DGridList.Rows.Add()

                cmdNew_Click(sender, e)
                f = DGridList.Rows.Count - 1
                ' DGridList.Item(j, f).Value = SendKeys.Send("{BS}")
                DGridList.Item(j, f).Value = Microsoft.VisualBasic.Mid(txt.Text, 1, jk - 1) + Chr(13)
                txt.Text = Microsoft.VisualBasic.Mid(txt.Text, jk + 1)
                jk = InStr(txt.Text, Chr(13))
                ' cmdNew_Click(sender, e)
            Loop
            '  DGridList.DataSource = bindingSource

        Else
            For i = 0 To DGridList.RowCount - 1
                If DGridList.Item(j, i).Selected Then DGridList.Item(j, i).Value = getData4Pasting()
            Next i
        End If

        Exit Sub
        Resume

erhh:
        MsgBox("The Clipboard could not be accessed. Please try again.", MsgBoxStyle.Information, strApptitle)
        Exit Sub
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub
    Function getData4Pasting() As String
        getData4Pasting = ""
        Dim i As Integer = InStr(txt.Text, Chr(13))
        If i > 0 Then
            getData4Pasting = Microsoft.VisualBasic.Mid(txt.Text, 1, i - 1)
            txt.Text = Microsoft.VisualBasic.Mid(txt.Text, i + 1)
        End If
    End Function
    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim jk As Integer = 0
        Dim kj As Integer
        Dim wr As Integer = 0
        Dim containStr As Boolean = False

        oLoadDbgrid()
        ' Row indexes we'll remove later on.
        Dim deleteIndexList As List(Of Integer) = New List(Of Integer)


        Dim myStyle As New DataGridViewCellStyle
        'myStyle.ForeColor = Color.Red
        myStyle.ForeColor = Color.White
        myStyle.BackColor = Color.MediumPurple

        Dim strNewFilter As String = ""
        Select Case cboCriteria.Text
            Case Is = "="
                strNewFilter = tFilterText2.Text
            Case Is = "Containing"
                strNewFilter = "*" + tFilterText2.Text + "*"
            Case Is = "Start With"
                strNewFilter = tFilterText2.Text + "*"
            Case Is = "End with"
                strNewFilter = "*" + tFilterText2.Text
        End Select
        Dim x As Integer = 0
        While i < DGridList.Rows.Count

            kj = 1
            jk = 1

            'End If
            For j = kj To jk
                If Not DGridList.Item(j, i).Value Is DBNull.Value Or Nothing Then
                    If LCase(DGridList.Item(j, i).Value) Like LCase(strNewFilter) Then
                        DGridList.Item(j, i).Selected = True
                        DGridList.Rows(i).DefaultCellStyle = myStyle
                        x = i
                        '                DGridList.Item(j, i).Style.ForeColor = Color.Red
                        'Exit For
                    End If
                End If
            Next j
            i = i + 1
        End While
        If x > 0 Then
            DGridList.CurrentCell = DGridList.Rows(x).Cells("tName")
            DGridList.Focus()
        End If
        'SendKeys.Send("{BS}")

        'SendKeys.Send("11")

        Exit Sub

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

    Private Sub DGridList_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGridList.CellContentClick

    End Sub

    Private Sub chkSelectAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSelectAll.CheckedChanged
        Dim i As Integer
        For i = 0 To DGridList.RowCount - 1
            DGridList.Item("StopPay", i).Value = IIf(chkSelectAll.Checked, 1, 0)
        Next
    End Sub

    Private Sub cmdCleanUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCleanUp.Click
        On Error GoTo handler
        DGridList.Enabled = False
        Dim i As Integer
        For i = 0 To DGridList.RowCount - 1
            If Asc(DGridList.Item(1, i).Value) <= 31 Then DGridList.Item(1, i).Value = Mid(DGridList.Item(1, i).Value, 2) 'Name
            If Asc(DGridList.Item(2, i).Value) <= 31 Then DGridList.Item(2, i).Value = Mid(DGridList.Item(2, i).Value, 2) 'State
            If Asc(DGridList.Item(3, i).Value) <= 31 Then DGridList.Item(3, i).Value = Mid(DGridList.Item(3, i).Value, 2) 'Camp
            If Asc(DGridList.Item(4, i).Value) <= 31 Then DGridList.Item(4, i).Value = Mid(DGridList.Item(4, i).Value, 2) 'Bank
            If Asc(DGridList.Item(5, i).Value) <= 31 Then DGridList.Item(5, i).Value = Mid(DGridList.Item(5, i).Value, 2) 'BankAcctNo
            If Asc(DGridList.Item(6, i).Value) <= 31 Then DGridList.Item(6, i).Value = Mid(DGridList.Item(6, i).Value, 2) 'SortCode
            If Asc(DGridList.Item(7, i).Value) <= 31 Then DGridList.Item(7, i).Value = Mid(DGridList.Item(7, i).Value, 2) 'StopPay
            If Asc(DGridList.Item(8, i).Value) <= 31 Then DGridList.Item(8, i).Value = Mid(DGridList.Item(8, i).Value, 2) 'Remark
            DGridList.Item(1, i).Value = Trim(DGridList.Item(1, i).Value)
        Next

        newCleanSpace()

        DGridList.Enabled = True
        MsgBox("Successfull")

        Exit Sub
        Resume
handler:
        If Err.Number = 5 Or Err.Number = 13 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
            DGridList.Enabled = True
        End If

    End Sub

    Sub newCleanSpace()
        On Error GoTo handler
        Dim FountIt As Boolean
        Dim i As Integer
        Dim jk As Integer = 0
DoItAgain:
        FountIt = False
        For i = 0 To DGridList.RowCount - 1
            If Asc(DGridList.Item(1, i).Value) <= 31 Then DGridList.Item(1, i).Value = Mid(DGridList.Item(1, i).Value, 2) 'Name
            jk = 0
            jk = InStr(DGridList.Item(1, i).Value, "  ")
            If jk > 0 Then
                DGridList.Item(1, i).Value = Trim(Mid(DGridList.Item(1, i).Value, 1, jk - 1)) + " " + Trim(Mid(DGridList.Item(1, i).Value, jk))
                DGridList.Rows(i).DefaultCellStyle.ForeColor = Color.Red
                FountIt = True
            End If
        Next

        If FountIt = True Then GoTo DoItAgain

        Exit Sub
        Resume
handler:
        If Err.Number = 5 Or Err.Number = 13 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
            DGridList.Enabled = True
        End If

    End Sub
    Private Sub cmdUpdateBankCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdateBankCode.Click
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        cmSQL.CommandText = "UPDATE Register SET SortCode =(SELECT TOP 1 Code FROM Bank WHERE Bank=Register.Bank)"
        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        cmSQL.ExecuteNonQuery()
        cmSQL.Connection.Close()
        cmSQL.Dispose()
        cnSQL.Close()
        cnSQL.Dispose()

        MsgBox("Successfull", vbInformation)

        Exit Sub
        Resume
handler:
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        
    End Sub
End Class