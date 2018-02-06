Imports System.Management

Public Class PrinterInfo
    Dim dict As New Dictionary(Of String, Details)
    Dim tempdict As New Dictionary(Of String, Details)
    Public Sub Gather()
        Dim options As New ConnectionOptions With
    {
        .Authority = "ntlmdomain:as.internal",
        .Impersonation = ImpersonationLevel.Impersonate
    }
        Dim scope As New ManagementScope("\\svr-docupro\root\cimv2")
        Dim query As New ObjectQuery("SELECT * FROM Win32_Printer")
        scope.Connect()
        Dim searcher As New ManagementObjectSearcher(scope, query)
        Dim pinfo As Details
        Dim a As Integer = 0
        tempdict = New Dictionary(Of String, Details)
        For Each printer As ManagementObject In searcher.Get()
            pinfo = New Details
            If printer("Status") IsNot Nothing Then
                pinfo.Status = printer("Status").ToString
            End If
            If printer("Description") IsNot Nothing Then
                pinfo.Description = printer("Description").ToString
            End If
            If printer("DeviceID") IsNot Nothing Then
                pinfo.DeviceID = printer("DeviceID").ToString
            End If
            If printer("Location") IsNot Nothing Then
                pinfo.Location = printer("Location").ToString
            End If
            If printer("PortName") IsNot Nothing Then
                pinfo.PortName = printer("PortName").ToString
            End If
            If printer("PrinterState") IsNot Nothing Then
                pinfo.PrinterState = DirectCast(printer("PrinterState"), UInt32)
            End If
            If printer("PrinterStatus") IsNot Nothing Then
                pinfo.PrinterStatus = DirectCast(printer("PrinterStatus"), UInt16)
            End If
            tempdict.Add(printer("Name").ToString, pinfo)
        Next
        SyncLock dict
            dict = New Dictionary(Of String, Details)(tempdict)
        End SyncLock
    End Sub

    Public Function GetPrintersWMI() As Dictionary(Of String, Details)
        SyncLock dict
            Return dict
        End SyncLock

    End Function

    Structure Details
        'Dim Name As String
        Dim Driver As String
        Dim Description As String
        Dim DeviceID As String
        Dim Location As String
        Dim PortName As String
        Dim PrinterState As UInt32
        Dim PrinterStatus As UInt16
        Dim Status As String
        Dim ShareName As String
        Dim SystemName As String
    End Structure

End Class

