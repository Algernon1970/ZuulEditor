Imports System.Management
Imports System.Net.NetworkInformation
Imports System.Text

Module Utils
    Public Function ArrayReverse(ByVal inp() As String) As String()
        Dim outArray(inp.Count - 1) As String
        For i As Integer = 0 To inp.Count - 1
            outArray((inp.Count - i) - 1) = inp(i)
        Next
        Return outArray
    End Function

    ''' <summary>
    ''' ''' Change format of String from as/unit/container to CN=[container],OU=[unit],DC=[as]... etc
    ''' </summary>
    ''' <param name="path"></param>
    ''' <returns></returns>
    Public Function PathToOU(ByVal path As String) As String
        Dim ouPath As String = ""
        Dim pathParts As String() = path.Split("\"c)
        pathParts = ArrayReverse(pathParts)
        For Each pp As String In pathParts
            If pp.Equals("as") Or pp.Equals("Internal") Then
                ouPath = String.Format("{0}, dc={1}", ouPath, pp)
            Else
                'if blank ou={1} else , ou={1}
                If ouPath.Length = 0 Then
                    ouPath = "OU=" & pp
                Else
                    ouPath = String.Format("{0}, OU={1}", ouPath, pp)
                End If
            End If
        Next
        Return ouPath
    End Function

    ''' <summary>
    ''' Change format of String from  CN=[container],OU=[unit],DC=[as]... etc  to  as/unit/container
    ''' </summary>
    ''' <param name="ouPath"></param>
    ''' <returns></returns>
    Public Function OUToPath(ByVal ouPath As String) As String
        Dim path As String = ""
        Dim pathParts As String() = ouPath.Split(","c)
        Dim strNamePart As String = ""
        pathParts = ArrayReverse(pathParts)
        For Each pp As String In pathParts
            strNamePart = pp.Split("="c)(1)
            path = String.Format("{0}\{1}", path, strNamePart)
        Next
        path = path.Replace("\internal\", "")
        Return path
    End Function

    Public Function ValidPing(ByVal systemName As String) As Boolean
        Dim PingReplied As Boolean = False

        Try
            Dim PingSender As New Ping
            ' Use default TTL of 128
            ' Change to not fragment
            Dim Options As New PingOptions With {
                .DontFragment = True
            }
            ' Create 32 byte data buffer to send
            Dim PingData As String = "******Computer*****Details******"
            Dim Pingbuffer() As Byte = Encoding.ASCII.GetBytes(PingData)

            Dim PingTimeout As Integer = 120
            Dim PingReply As PingReply = PingSender.Send(systemName, PingTimeout, Pingbuffer)
            If PingReply.Status = IPStatus.Success Then
                PingReplied = True
            Else
                PingReplied = False
            End If

            Return PingReplied
        Catch ex As Exception
            Return PingReplied
        End Try
    End Function

    Public Function GetWMI(ByVal systemName As String) As ManagementObjectCollection
        Dim scope As System.Management.ManagementScope
        Try
            Dim MyConOptions As New System.Management.ConnectionOptions
            With MyConOptions
                .Impersonation = System.Management.ImpersonationLevel.Impersonate
                ' This entry required for Windows XP and newer
                .Authentication = System.Management.AuthenticationLevel.Packet
                ' Replace above code line with following code line for Windows systems prior to XP
                ' .Authentication = System.Management.AuthenticationLevel.Connect
            End With

            ' Connect to WMI namespace

            scope = New System.Management.ManagementScope("\\" &
                         systemName & "\root\cimv2", MyConOptions)
            scope.Connect()

            If scope.IsConnected = False Then
                ' Error connecting to computer 
                Return Nothing
            End If
            Dim query As New ObjectQuery("SELECT * FROM Win32_VideoController")
            'Dim query As New ObjectQuery("SELECT Capacity FROM Win32_PhysicalMemory where tag = 'Physical Memory 0'")
            Dim searcher As New ManagementObjectSearcher(scope, query)

            Dim queryCollection As ManagementObjectCollection = searcher.Get()
            Return queryCollection
        Catch ex As Exception
            Return Nothing
        End Try


    End Function

    Public Function GetWMI(ByVal systemName As String, propertyName As String, queryString As String) As String
        Dim scope As System.Management.ManagementScope
        Try
            Dim MyConOptions As New System.Management.ConnectionOptions
            With MyConOptions
                .Impersonation = System.Management.ImpersonationLevel.Impersonate
                ' This entry required for Windows XP and newer
                .Authentication = System.Management.AuthenticationLevel.Packet
                ' Replace above code line with following code line for Windows systems prior to XP
                ' .Authentication = System.Management.AuthenticationLevel.Connect
            End With

            ' Connect to WMI namespace

            scope = New System.Management.ManagementScope("\\" &
                         systemName & "\root\cimv2", MyConOptions)
            scope.Connect()

            If scope.IsConnected = False Then
                ' Error connecting to computer 
                Return Nothing
            End If
            'Dim query As New ObjectQuery("SELECT * FROM Win32_LogicalDisk where DEVICEID = 'C:'")
            Dim query As New ObjectQuery(String.Format("Select {0} from {1}", propertyName, queryString))
            Dim searcher As New ManagementObjectSearcher(scope, query)

            Dim queryCollection As ManagementObjectCollection = searcher.Get()
            For Each m As ManagementObject In queryCollection
                For Each mp As PropertyData In m.Properties
                    Return m(mp.Name).ToString
                Next
            Next


            Return "ok"
        Catch ex As Exception
            Return Nothing
        End Try


    End Function

End Module
