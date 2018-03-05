Module Utils
    Public Function ArrayReverse(ByVal inp() As String) As String()
        Dim outArray(inp.Count - 1) As String
        For i As Integer = 0 To inp.Count - 1
            outArray((inp.Count - i) - 1) = inp(i)
        Next
        Return outArray
    End Function

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

End Module
