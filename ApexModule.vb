Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.io
Module ApexModule
    Public strConnect As String
    Public Password, SysPwd As String
    Public UserID As String
    Public IntegratedSecurity As Boolean
    Public strApptitle As String = "ApexStipends"
    Public sysOwner As String = "OFFICE OF THE SPECIAL ADVISER TO THE PRESIDENT ON NIGER DELTA"
    Public ServerName As String = My.Computer.Name
    Public sysUserName As String = ""
    Public ThePhase As String = ""

    Public AttachName As String = "ApexStipends"
    Public AppPath As String
    Public MSAccessCn As String
    Public LogOnFail As Boolean = False
    Public arrayLogo() As Byte
    Public strOwnerFromServer As String = "OFFICE OF THE SPECIAL ADVISER TO THE PRESIDENT ON NIGER DELTA"
    Public strLevel As String = ""
    Public Fmt As String = "###,##0.00" 'used format number to the format
    Public Enum AppAction
        Add = 1
        Edit = 2
        Delete = 3
        Browse = 4
        Open = 6
    End Enum
    Sub New()
        sysOwner = "MegaHit Systems, Abuja"
        AppPath = IIf(Len(My.Application.Info.DirectoryPath) <= 3, My.Application.Info.DirectoryPath, My.Application.Info.DirectoryPath + "\")
        AppPath = "c:\Applications\ApexStipends\"
        MSAccessCn = "Provider=Microsoft.jet.oledb.4.0;Data Source=" + AppPath + "ConfigDir\Config.gif;Jet OLEDB:Database Password=secret" ' & 
        InitialiseEntireSystem()
    End Sub
    Public Sub InitialiseEntireSystem()
        On Error GoTo handler
        'sysOwner = "MegaHit Systems, Abuja"
        Dim cnOle As OleDbConnection
        Dim cmOle As OleDbCommand
        Dim drOle As OleDbDataReader

        cnOle = New OleDbConnection("Provider=Microsoft.jet.oledb.4.0;Data Source=" & AppPath & "ConfigDir\Config.gif;Jet OLEDB:Database Password=secret")
        cnOle.Open()

        cmOle = New OleDbCommand("SELECT * FROM SvrParam", cnOle)
        drOle = cmOle.ExecuteReader()

        If drOle.HasRows = False Then
            MsgBox("Invalid Configuration Parameter" & Chr(13) & "System Halted", MsgBoxStyle.Information)
            End
        End If
        If drOle.Read Then
            ServerName = IIf(IsDBNull(drOle.Item("ServerName").ToString()), "", drOle.Item("ServerName").ToString())
            UserID = IIf(IsDBNull(drOle.Item("UserID").ToString()), "", drOle.Item("UserID").ToString())
            Password = IIf(IsDBNull(drOle.Item("Password").ToString()), "", drOle.Item("Password").ToString())
            IntegratedSecurity = drOle.Item("IntegratedSecurity")
            sysOwner = IIf(IsDBNull(drOle.Item("Owner").ToString()), "Invalid User", drOle.Item("Owner").ToString())
            strOwnerFromServer = sysOwner
            AttachName = IIf(IsDBNull(drOle.Item("AttachName").ToString()), "", drOle.Item("AttachName").ToString())
        End If
        If drOle.Item("IntegratedSecurity") = False Then
            strConnect = "Data Source=" & ServerName & ";Initial Catalog=" & AttachName & ";Persist Security Info=True;User ID=" & UserID & ";Password=" & Password
        Else
            strConnect = "Data Source=" & ServerName & ";Initial Catalog=" & AttachName & ";Integrated Security=True"
        End If
        'strConnect = "Data Source=MHCLIENT;Initial Catalog=BnkReconcile;Persist Security Info=True;User ID=sa;Password=penny"
        drOle.Close()
        cnOle.Close()
        cmOle.Dispose()
        cnOle.Dispose()

        Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
        Dim cmSQL As SqlCommand = cnSQL.CreateCommand
        Dim drSQL As SqlDataReader

        cnSQL.Open()

        cmSQL.CommandText = "FetchAllSystemParameters"
        cmSQL.CommandType = CommandType.StoredProcedure
        drSQL = cmSQL.ExecuteReader()
        If drSQL.HasRows = False Then
            MsgBox("Invalid System Parameters")
            End
        Else
            If drSQL.Read Then
                ThePhase = drSQL.Item("Me")
                arrayLogo = CType(drSQL.Item("Logo"), Byte())
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
        If Err.Description Like "Cannot open database requested in login 'ApexStipends'. Login fails*" Then
            If My.Computer.Name = ServerName Or UCase(ServerName) = "(LOCAL)" Then
                attachDB(AttachName)
            Else
                MsgBox("Database not attached...Pls. refer to the system administrator", MsgBoxStyle.Information, strApptitle)
            End If
        Else
            MsgBox(Err.Description, MsgBoxStyle.Critical, strApptitle)
            If Err.Description Like "*Login fails*" Then LogOnFail = True
        End If
    End Sub
    Sub attachDB(ByVal attachName As String)
        On Error GoTo handler
        Dim connectStr As String = ""

        If IntegratedSecurity Then
            connectStr = "workstation id=" & ServerName & ";packet size=4096;data source=" & ServerName & ";Integrated Security=True;initial catalog=master"
        Else
            connectStr = "workstation id=" & ServerName & ";packet size=4096;user id=" & UserID & ";pwd=" & Password & ";data source=" & ServerName & ";persist security info=False;initial catalog=master"
        End If

        Dim SqlCn As SqlConnection = New SqlConnection(connectStr)
        Dim strConnectMaster As String
        SqlCn.Open()
        On Error Resume Next

        Dim myCommand As SqlCommand = SqlCn.CreateCommand

        On Error GoTo handler
        Dim DBName As String = AppPath + "ConfigDir\ApexStipends.MDF"
        myCommand.CommandText = "EXEC sp_attach_db @dbname = N'" & attachName & "',@filename1 = N'" & DBName & "',@filename2 = N'" & Mid(Trim(DBName), 1, InStr(Trim(DBName), ".") - 1) + ".LDF" & "'"
        myCommand.ExecuteNonQuery()

        myCommand.Connection.Close()
        myCommand.Dispose()
        SqlCn.Close()
        SqlCn.Dispose()
        MsgBox("Pls. restart the application", MsgBoxStyle.Information, strApptitle)
        End
        Exit Sub
        Resume
handler:
        MsgBox("Pls. refer to the system administrator", MsgBoxStyle.Information, strApptitle)

        'MsgBox(Err.Description, MsgBoxStyle.Information, strApptitle)
    End Sub

    Public Sub InitialiseEntireSystem_Prev()
        sysOwner = "MegaHit Systems, Abuja"
        Dim cnOle As OleDbConnection
        Dim cmOle As OleDbCommand
        Dim drOle As OleDbDataReader

        Try
            cnOle = New OleDbConnection("Provider=Microsoft.jet.oledb.4.0;Data Source=" & AppPath & "Config.gif;Jet OLEDB:Database Password=secret")
            cnOle.Open()

            cmOle = New OleDbCommand("SELECT * FROM SvrParam", cnOle)
            drOle = cmOle.ExecuteReader()

            If drOle.HasRows = False Then
                MsgBox("Invalid Configuration Parameter" & Chr(13) & "System Halted", MsgBoxStyle.Information)
                End
            End If
            If drOle.Read Then
                ServerName = IIf(IsDBNull(drOle.Item("ServerName").ToString()), "", drOle.Item("ServerName").ToString())
                UserID = IIf(IsDBNull(drOle.Item("UserID").ToString()), "", drOle.Item("UserID").ToString())
                Password = IIf(IsDBNull(drOle.Item("Password").ToString()), "", drOle.Item("Password").ToString())
                IntegratedSecurity = drOle.Item("IntegratedSecurity")
                sysOwner = IIf(IsDBNull(drOle.Item("Owner").ToString()), "MegaHit Systems", drOle.Item("Owner").ToString())
                AttachName = IIf(IsDBNull(drOle.Item("AttachName").ToString()), "", drOle.Item("AttachName").ToString())
            End If

            If drOle.Item("IntegratedSecurity") = False Then
                strConnect = "Data Source=" & ServerName & ";Initial Catalog=" & AttachName & ";Persist Security Info=True;User ID=" & UserID & ";Password=" & Password
            Else
                strConnect = "Data Source=" & ServerName & ";Initial Catalog=" & AttachName & ";Integrated Security=True"
            End If

            drOle.Close()
            cnOle.Close()
            cmOle.Dispose()
            cnOle.Dispose()

            Dim cnSQL As SqlConnection = New SqlConnection(strConnect)
            Dim cmSQL As SqlCommand = cnSQL.CreateCommand
            Dim drSQL As SqlDataReader

            cnSQL.Open()

            cmSQL.CommandText = "FetchAllSystemParameters"
            cmSQL.CommandType = CommandType.StoredProcedure
            drSQL = cmSQL.ExecuteReader()
            If drSQL.HasRows = False Then
                MsgBox("Invalid System Parameters")
                End
            Else
                If drSQL.Read Then
                    arrayLogo = CType(drSQL.Item("Logo"), Byte())
                End If
            End If
            cmSQL.Connection.Close()
            cmSQL.Dispose()
            drSQL.Close()
            cnSQL.Close()
            cnSQL.Dispose()

        Catch e As Exception
            MsgBox(e.Message, MsgBoxStyle.Critical, strApptitle)
            If e.Message Like "*Login fails*" Then LogOnFail = True

        End Try
    End Sub
    Public Function formatDate(ByVal dtp As DateTimePicker) As Date
        If dtp.ShowCheckBox = True Then
            If dtp.Checked = False Then
                formatDate = "31-Dec-9998"
            Else
                formatDate = Format(dtp.Value, "dd-MMM-yyyy")
            End If
        Else
            formatDate = Format(dtp.Value, "dd-MMM-yyyy")
        End If
    End Function
    Public Function ChkNull(ByVal TheStr) As String
        ChkNull = IIf(IsDBNull(TheStr).ToString, "", TheStr.ToString)
    End Function
End Module
