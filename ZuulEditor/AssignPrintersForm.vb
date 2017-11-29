Public Class AssignPrintersForm

    Dim PrinterLinkTableAdapter As New ZuulDataSetTableAdapters.Lnk_ComputerPrinterTableAdapter

    Private Sub AssignPrintersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Tbl_ComputerTableAdapter.Fill(Me.ZuulDataSet.Tbl_Computer)
        Me.Tbl_PrinterTableAdapter.Fill(Me.ZuulDataSet.Tbl_Printer)
    End Sub

    Private Sub AssignButton_Click(sender As Object, e As EventArgs) Handles AssignButton.Click
        OperationBox.Clear()
        Dim cid As Integer = 0
        Dim pid As Integer = 0
        For Each computerRow As DataRowView In ComputerListBox.SelectedItems
            cid = computerRow.Row.Field(Of Integer)("ComputerID")
            For Each printerRow As DataRowView In PrinterListBox.SelectedItems
                pid = printerRow.Row.Field(Of Integer)("PrinterID")
                AddPrinter(cid, pid)
            Next
        Next
        DisplayPrintersForSelectedComputers()
    End Sub

    Private Sub DefaultButton_Click(sender As Object, e As EventArgs) Handles DefaultButton.Click
        If PrinterListBox.SelectedItems.Count <> 1 Then
            OperationBox.AppendText("Choose only 1 printer to make default")
        Else
            Dim cid As Integer = 0
            Dim pid As Integer = 0
            For Each computerRow As DataRowView In ComputerListBox.SelectedItems
                cid = computerRow.Row.Field(Of Integer)("ComputerID")
                For Each printerRow As DataRowView In PrinterListBox.SelectedItems
                    pid = printerRow.Row.Field(Of Integer)("PrinterID")
                    AddPrinter(cid, pid, True)
                Next
            Next
        End If
        DisplayPrintersForSelectedComputers()
    End Sub

    Private Sub ComputerListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComputerListBox.SelectedIndexChanged
        DisplayPrintersForSelectedComputers()
    End Sub

    Private Sub DisplayPrintersForSelectedComputers()
        OperationBox.Clear()
        For Each computerRow As DataRowView In ComputerListBox.SelectedItems
            OperationBox.AppendText(computerRow.Row.Field(Of String)("Name") & vbCrLf)
            Dim plist As List(Of String) = GetPrinterListFor(computerRow.Row.Field(Of Integer)("ComputerID").ToString)
            For Each printer As String In plist
                OperationBox.AppendText(vbTab & printer & vbCrLf)
            Next
        Next
    End Sub

    Private Function GetPrinterListFor(ByRef cid As String) As List(Of String)
        Dim PrinterLinks As DataTable = PrinterLinkTableAdapter.GetPrinterLinkByComputerID(cid)
        Dim plist As New List(Of String)
        For Each printerlink As DataRow In PrinterLinks.Rows
            Dim pname As String = Tbl_PrinterTableAdapter.GetPrinterByPrinterID(printerlink.Field(Of Integer)("PrinterID")).Rows(0).Field(Of String)("Name")
            If printerlink.Field(Of Boolean)("isDefaultPrinter") Then
                pname = pname & "*"
            End If
            plist.Add(pname)
        Next
        Return plist
    End Function

    Private Sub AddPrinter(ByVal cid As Integer, ByVal pid As Integer, Optional ByVal isDefault As Boolean = False)
        Dim linkTable As DataTable = PrinterLinkTableAdapter.GetLink(cid, pid)
        If linkTable.Rows.Count > 1 Then
            MsgBox(String.Format("Database corrupt. Multiple entries for cid = {0}, pid = {1}", cid, pid))
        End If
        If linkTable.Rows.Count = 1 Then
            Dim key As Integer = linkTable.Rows(0).Field(Of Integer)("ID")
            If isDefault Then
                PrinterLinkTableAdapter.RemoveDefaults(cid)
            End If
            PrinterLinkTableAdapter.UpdateDefault(isDefault, key)
        Else
            PrinterLinkTableAdapter.InsertQuery(cid, pid, isDefault)
        End If
    End Sub
End Class