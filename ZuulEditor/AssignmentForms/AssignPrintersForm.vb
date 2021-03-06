﻿Public Class AssignPrintersForm

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
            MsgBox("Choose only 1 printer to make default")
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

    Private Sub UnAssignButton_Click(sender As Object, e As EventArgs) Handles UnAssignButton.Click
        OperationBox.Clear()
        Dim cid As Integer = 0
        Dim pid As Integer = 0
        For Each computerRow As DataRowView In ComputerListBox.SelectedItems
            cid = computerRow.Row.Field(Of Integer)("ComputerID")
            For Each printerRow As DataRowView In PrinterListBox.SelectedItems
                pid = printerRow.Row.Field(Of Integer)("PrinterID")
                UnassignPrinter(cid, pid)
            Next
        Next
        DisplayPrintersForSelectedComputers()
    End Sub

    Private Sub ComputerListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComputerListBox.SelectedIndexChanged
        DisplayPrintersForSelectedComputers()
    End Sub

    Private Sub DisplayPrintersForSelectedComputers()
        OperationBox.Clear()
        For Each computerRow As DataRowView In ComputerListBox.SelectedItems
            OperationBox.AppendText(computerRow.Row.Field(Of String)("Name") & vbCrLf)
            Dim plist As List(Of String) = GetPrinterListFor(computerRow.Row.Field(Of Integer)("ComputerID"))
            For Each printer As String In plist
                OperationBox.AppendText(vbTab & printer & vbCrLf)
            Next
        Next
    End Sub

    Private Function GetPrinterListFor(ByRef cid As Integer) As List(Of String)
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
        If isDefault Then
            PrinterLinkTableAdapter.RemoveDefaults(cid)
        End If
        If linkTable.Rows.Count > 1 Then
            MsgBox(String.Format("Database corrupt. Multiple entries for cid = {0}, pid = {1}", cid, pid))
        End If
        If linkTable.Rows.Count = 1 Then
            Dim key As Integer = linkTable.Rows(0).Field(Of Integer)("ID")

            PrinterLinkTableAdapter.UpdateDefault(isDefault, key)
        Else
            PrinterLinkTableAdapter.InsertQuery(cid, pid, isDefault)
        End If
    End Sub

    Private Sub UnassignPrinter(ByVal cid As Integer, ByVal pid As Integer)
        PrinterLinkTableAdapter.DeleteByInstance(cid, pid)
    End Sub

    Private Sub DeletePrinterButton_Click(sender As Object, e As EventArgs) 
        Dim PrinterTableAdapter As New ZuulDataSetTableAdapters.Tbl_PrinterTableAdapter
        Dim pid As Integer = 0
        Dim plural As String = If(PrinterListBox.SelectedItems.Count = 1, "", "s")
        Dim warn As String = String.Format("Are you sure you wish to delete {0} printer{1} permanently from the database?", PrinterListBox.SelectedItems.Count, plural)
        Dim res As MsgBoxResult = MsgBox(warn, MsgBoxStyle.YesNo)
        If res.Equals(MsgBoxResult.Yes) Then
            For Each printer As DataRowView In PrinterListBox.SelectedItems
                pid = printer.Row.Field(Of Integer)("PrinterID")
                PrinterTableAdapter.DeleteByID(pid)
            Next
        End If
        Me.Tbl_PrinterTableAdapter.Fill(Me.ZuulDataSet.Tbl_Printer)
    End Sub

    Private Sub EditPrinterButton_Click(sender As Object, e As EventArgs)
        Dim pd As New PrinterDetail

        Dim pselected As ListBox.SelectedObjectCollection = PrinterListBox.SelectedItems
        Dim pselecteditem As DataRowView = DirectCast(pselected.Item(0), DataRowView)
        Dim selectedPrinter As DataRow = pselecteditem.Row
        Dim pid As String = selectedPrinter.Field(Of String)("Name")
        pd.Show()
        pd.SelectPrinterByName(pid)
        Me.Tbl_PrinterTableAdapter.Fill(Me.ZuulDataSet.Tbl_Printer)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim cd As New ComputerDetails
        Dim selectedComputer As DataRow = DirectCast(ComputerListBox.SelectedItems(0), DataRowView).Row
        Dim cid As String = selectedComputer.Field(Of String)("Name")
        cd.Show()
        'cd.selectComputerByName(cid)
        Me.Tbl_ComputerTableAdapter.Fill(Me.ZuulDataSet.Tbl_Computer)
    End Sub

    Private Sub ComputerListFilterBox_TextChanged(sender As Object, e As EventArgs) Handles ComputerListFilterBox.TextChanged
        'Me.Tbl_ComputerTableAdapter.Fill(Me.ZuulDataSet.Tbl_Computer)
        TblComputerBindingSource.Filter = "[Name] like '" & ComputerListFilterBox.Text & "%'"
    End Sub

    Private Sub PrinterListFilterBox_TextChanged(sender As Object, e As EventArgs) Handles PrinterListFilterBox.TextChanged
        TblPrinterBindingSource.Filter = "[Name] like '" & PrinterListFilterBox.Text & "%'"
    End Sub
End Class