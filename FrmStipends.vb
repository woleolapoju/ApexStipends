Imports System.Data.Sqlclient
Imports System.IO

Public Class FrmStipends
    Dim ReturnID As String
    Dim selectedTVQry As String
    Dim OnlyFirstItem As Boolean = False
    Private Sub FrmPensionEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        FillStates()

        For i = Year(Now) - 1 To Year(Now) + 1
            cYear.Items.Add(i.ToString)
        Next
        cYear.Text = Year(Now)
        cMonth.Text = Format(Now, "MMM")

    End Sub
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub oLoadDbgrid()
        On Error GoTo errhdl
        Dim i As Integer
        If cMonth.Text = "" Then Exit Sub
        If cYear.Text = "" Then Exit Sub

        lblGross.Text = Format(0, "standard")
        lblSTOP.Text = Format(0, "standard")
        lblNet.Text = Format(0, "standard")

        lblTotalPayable.Text = 0
        lblTotalNoStopPay.Text = 0
        lblTotalNo.Text = 0



        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        DGridList.Rows.Clear()

        Dim ThePeriod As String = "01-" + cMonth.Text + "-" + cYear.Text
        Dim jc As New System.Globalization.GregorianCalendar()
        Dim Amount As Double = 0
        Dim NoOfDays As Integer = (jc.GetDaysInMonth(Year(CDate(ThePeriod)), Month(CDate(ThePeriod))))
        Amount = (1500 * NoOfDays) + 20000

        'If NoOfDays = 31 Then Amount = 66500
        'If NoOfDays = 30 Then Amount = 65500
        'If NoOfDays = 28 Then Amount = 62000
        'If NoOfDays = 29 Then Amount = 63500


        Dim strQry1 As String = ""
        Dim strCamp As String = ""
        Dim strQry As String = "SELECT * FROM Register"
        If cboState.Text <> "ALL" Then strQry1 = " WHERE State ='" & cboState.Text & "'"
        If cCamp.Text <> "ALL" And cCamp.Text <> "" Then strQry1 = strQry1 + IIf(strQry1 = "", " WHERE ", " AND ") + " Camp ='" & cCamp.Text & "'"
        strQry = strQry + strQry1 + " ORDER BY Sn"

        cmSQL.CommandText = strQry
        cmSQL.CommandType = CommandType.Text
        cnSQL.Open()
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then Exit Sub
        Do While drSQL.Read
            '    i = i + 1

            Dim TheRow As String() = {drSQL.Item("Sn"), drSQL.Item("Name"), drSQL.Item("Bank"), drSQL.Item("State"), drSQL.Item("Camp"), drSQL.Item("StopPay"), Format(Amount, "standard")}
            DGridList.Rows.Add(TheRow)
        Loop

        cmSQL.Connection.Close()
        cmSQL.Dispose()
        drSQL.Close()
        cnSQL.Close()
        cnSQL.Dispose()

        CalculateNet()
        Exit Sub
        Resume
errhdl:
        If Err.Number = 91 Or Err.Number = 5 Then
            Resume Next
        Else
            MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
        End If


    End Sub

    Private Sub cMonth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cMonth.SelectedIndexChanged
        oLoadDbgrid()
    End Sub

    Private Sub cYear_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cYear.SelectedIndexChanged
        oLoadDbgrid()
    End Sub

    Private Sub CalculateNet()
        On Error GoTo errhdl
        Dim i As Integer
        Dim j As Integer = 0
        Dim total As Double = 0
        Dim totalStopPay As Double = 0
        Dim totalNoStopPay As Double = 0
       
        For i = 0 To DGridList.Rows.Count - 1
            total = total + CDbl(DGridList.Item(6, i).Value)
            j = j + 1
            If DGridList.Item(5, i).Value = True Then
                totalStopPay = totalStopPay + CDbl(DGridList.Item(6, i).Value)
                totalNoStopPay = totalNoStopPay + 1
            End If

        Next
        lblGross.Text = Format(total, "standard")
        lblSTOP.Text = Format(totalStopPay, "standard")
        lblNet.Text = Format(total - totalStopPay, "standard")

        lblTotalPayable.Text = j - totalNoStopPay
        lblTotalNoStopPay.Text = totalNoStopPay
        lblTotalNo.Text = j
        Exit Sub
errhdl:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub
    Private Sub DGridList_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGridList.CellEndEdit
        On Error GoTo errhdl
        If e.ColumnIndex = 5 Then
            DGridList.Item(5, e.RowIndex).Value = Format(DGridList.Item(5, e.RowIndex).Value, "standard")
            CalculateNet()
        End If
        If e.ColumnIndex = 6 Then
            DGridList.Item(6, e.RowIndex).Value = Format(DGridList.Item(6, e.RowIndex).Value, "standard")
            CalculateNet()
        End If

        Exit Sub
errhdl:
        MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub

    Private Sub cboState_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboState.SelectedIndexChanged
        oLoadCamp()
    End Sub

    Private Sub cCamp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cCamp.SelectedIndexChanged
        oLoadDbgrid()
    End Sub
    Private Sub FillStates()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cboState.Items.Clear()

        cmSQL.CommandText = "SELECT DISTINCT State FROM Register ORDER BY State"
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
    Private Sub oLoadCamp()
        On Error GoTo handler
        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader
        cCamp.Items.Clear()
        If cboState.Text = "ALL" Then
            cmSQL.CommandText = "SELECT DISTINCT Camp FROM Register ORDER BY [Camp]"
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

        Exit Sub
        Resume
handler:
        MsgBox(Err.Description, vbInformation, strApptitle)
    End Sub

    Private Sub lblSTOP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSTOP.Click

    End Sub
End Class