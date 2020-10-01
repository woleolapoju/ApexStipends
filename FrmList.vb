Imports System.Data.SqlClient
Public Class FrmList

    Public frmParent As Object
    Public tSelection As String
    Public qryPrm1 As String
    Public qryPrm2 As String
    Dim pstrCaption() As String
    Dim pintWidth() As Integer
    Dim plistQuery As String
    Private Sub applyParameter(ByVal listQuery As String, ByVal strParam As String)
        On Error GoTo errhdl
        
        Exit Sub
errhdl:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub
    Public Sub LoadLvList(ByVal strCaption() As String, ByVal intWidth() As Integer, ByVal listQuery As String, Optional ByVal strParam As String = "")
        On Error GoTo errhdl
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        pstrCaption = strCaption
        pintWidth = intWidth
        plistQuery = listQuery
        Dim i
        lvList.Columns.Clear()
        lvList.Items.Clear()
        For i = 0 To UBound(strCaption) - 1
            lvList.Columns.Add(strCaption(i), intWidth(i))
        Next i
        SelColumn.Maximum = UBound(strCaption)
        cmSQL.CommandType = CommandType.StoredProcedure
        Select Case listQuery
            Case "GetGeneratedPayPeriod"
                cmSQL.CommandText = "SELECT DISTINCT PayPeriod FROM RptPayment ORDER BY PayPeriod DESC"
                cmSQL.CommandType = CommandType.Text
        End Select

        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        Dim j As Long = 0
        Dim initialText As String
        Do While drSQL.Read
            j += 1
            If drSQL.Item(0).GetType.ToString = "System.DateTime" Then
                initialText = IIf(IsDBNull(drSQL.Item(0)), "", Format(drSQL.Item(0), "dd-MMM-yyyy"))
            Else
                initialText = drSQL.Item(0).ToString
            End If
            Dim LvItems As New ListViewItem(initialText)
            For i = 1 To UBound(strCaption) - 1
                If drSQL.Item(i).GetType.ToString = "System.DateTime" Then
                    LvItems.SubItems.Add(IIf(IsDBNull(drSQL.Item(i)), "", Format(drSQL.Item(i), "dd-MMM-yyyy")))
                ElseIf drSQL.Item(i).GetType.ToString = "System.Decimal" Then
                    LvItems.SubItems.Add(IIf(IsDBNull(drSQL.Item(i)), "0", Format(drSQL.Item(i), Fmt)))
                Else
                    LvItems.SubItems.Add(ChkNull(drSQL.Item(i)))
                End If

            Next
            lvList.Items.AddRange(New ListViewItem() {LvItems})
        Loop
        drSQL.Close()
        cmSQL.Connection.Close()
        cmSQL.Dispose()

        cnSQL.Close()
        cnSQL.Dispose()

        lblCount.Text = j
        If strParam <> "" Then applyParameter(listQuery, strParam)
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbCritical, strApptitle)
    End Sub
    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        On Error GoTo handler
        Select Case tSelection
            Case "GetGeneratedPayPeriod"
                frmParent.ReturnPayperiod = lvList.SelectedItems(0).Text
        End Select
        Me.Close()
        Exit Sub
handler:
        If Err.Number = 5 Then
            MsgBox("Please select an entry", vbInformation, strApptitle)
        ElseIf Err.Number = 438 Then
            Resume Next
        Else
            MsgBox(Err.Description, vbInformation, strApptitle)
        End If
    End Sub
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub lvList_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvList.ColumnClick
        SelColumn.Value = e.Column + 1
    End Sub

    Private Sub cmdSort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSort.Click
        On Error GoTo handler
        Dim lvwColumnSorter As ListViewSorter

        lvwColumnSorter = New ListViewSorter()
        lvList.ListViewItemSorter = lvwColumnSorter
        If RadAscend.Checked Then
            lvwColumnSorter.Order = 1
        Else
            lvwColumnSorter.Order = 2
        End If
        lvwColumnSorter.SortColumn = SelColumn.Value - 1
        lvList.Sort()
        Exit Sub
handler:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        On Error GoTo errhdl
        LoadLvList(pstrCaption, pintWidth, plistQuery)
        tFilter.Text = ""
        Exit Sub
errhdl:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub

    Private Sub cmdFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFilter.Click
        filterList()
    End Sub
    Private Sub filterList()
        On Error GoTo errhdl
        Dim i As Integer
        Dim j As Integer = SelColumn.Value
        Dim price As Double = 0.0
        i = lvList.Items.Count - 1
        Do While i >= 0
            If j = 1 Then
                If Not LCase(lvList.Items(i).Text) Like LCase(tFilter.Text) Then
                    lvList.Items(i).Remove()
                End If
            Else
                If Not LCase(lvList.Items(i).SubItems(j - 1).Text) Like LCase(tFilter.Text) Then
                    lvList.Items(i).Remove()
                End If
            End If
            i = i - 1
        Loop
        Exit Sub
        Resume
errhdl:
        MsgBox(Err.Description, vbInformation, strApptitle)
    End Sub
   

    Private Sub lvList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvList.DoubleClick
        cmdOk_Click(sender, e)
    End Sub

    Private Sub tFilter_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tFilter.KeyDown
        If e.KeyCode = Keys.Enter Then
            filterList()
        End If
    End Sub

    Private Sub FrmList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class

