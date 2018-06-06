Public Class Form1
    Private Sub PrinterAssignButton_Click(sender As Object, e As EventArgs) Handles PrinterAssignButton.Click
        Dim screen As New AssignPrintersForm
        screen.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles PrinterDetailsButton.Click
        Dim screen As New PrinterDetail
        screen.Show()
        screen.SelectPrinterByName("")
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Dim req As New RequestString("Search")
        Dim res As DialogResult = req.ShowDialog
        If res.Equals(DialogResult.Cancel) Then
            Return
        End If
        Dim searchString As String = req.ResultTextBox.Text
        DisplayFormFor(searchString)
        req.Dispose()
    End Sub

    Private Sub DisplayFormFor(ByVal searchString As String)
        Dim PrinterTableAdapter As New ZuulDataSetTableAdapters.Tbl_PrinterTableAdapter
        Dim ProjectorTableAdapter As New ZuulDataSetTableAdapters.Tbl_ProjectorTableAdapter
        Dim ComputerTableAdapter As New ZuulDataSetTableAdapters.Tbl_ComputerTableAdapter
        Dim dt As DataTable

        dt = PrinterTableAdapter.GetDataByInv(searchString)
        If dt.Rows.Count > 0 Then
            Dim screen As New PrinterDetail
            screen.Show()
            screen.SelectByIndex(-1)
            screen.SetState(CheckState.Indeterminate)
            screen.SelectPrinterByName(dt.Rows(0).Field(Of String)("Name"))
            Return
        End If

        dt = ProjectorTableAdapter.GetDataByInv(searchString)
        If dt.Rows.Count > 0 Then
            Dim screen As New ProjectorDetails
            screen.Show()
            'screen.SelectProjectorByName(dt.Rows(0).Field(Of String)("Name"))
            Return
        End If

        dt = ComputerTableAdapter.GetDataByInv(searchString)
        If dt.Rows.Count > 0 Then
            Dim screen As New ComputerDetails
            screen.Show()
            'screen.SelectComputerByName(dt.Rows(0).Field(Of String)("Name"))
            Return
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim uploader As New UploadFileForm
        uploader.Show()
    End Sub

    Private Sub ComputerDetailButton_Click(sender As Object, e As EventArgs) Handles ComputerDetailButton.Click
        Dim compForm As New ComputerDetails
        compForm.Show()
    End Sub

    Private Sub ImportComputersButton_Click(sender As Object, e As EventArgs) Handles ImportComputersButton.Click
        Dim impcomp As New ImportFromAD(Importer.computersFromAD)
        impcomp.Show()

    End Sub

    Private Sub ImportUsersButton_Click(sender As Object, e As EventArgs) Handles ImportUsersButton.Click
        Dim impcomp As New ImportFromAD(Importer.usersFromAD)
        impcomp.Show()
    End Sub

    Private Sub PrivAssignButton_Click(sender As Object, e As EventArgs) Handles PrivAssignButton.Click
        Dim privform As New AssignPrivUser()
        privform.Show()
    End Sub

    Private Sub PrivImportButton_Click(sender As Object, e As EventArgs) Handles PrivImportButton.Click
        Dim privimport As New ImportFromCSV(Importer.privs)
        privimport.Show()
    End Sub

    Private Sub AssignPrintersToComptuersCSVButton_Click(sender As Object, e As EventArgs) Handles AssignPrintersToComptuersCSVButton.Click
        Dim assignPrinterImport As New ImportFromCSV(Importer.assignPrinters)
        assignPrinterImport.Show()
    End Sub

    Private Sub ImportPrinterDetailsButton_Click(sender As Object, e As EventArgs) Handles ImportPrinterDetailsButton.Click
        Dim printerDetailsImport As New ImportFromCSV(Importer.printerDetails)
        printerDetailsImport.Show()
    End Sub

    Private Sub ImportComputersFromCSVButton_Click(sender As Object, e As EventArgs) Handles ImportComputersFromCSVButton.Click
        Dim computerDetailsImport As New ImportFromCSV(Importer.computerDetails)
        computerDetailsImport.Show()
    End Sub

    Private Sub ProjectorDetailButton_Click(sender As Object, e As EventArgs) Handles ProjectorDetailButton.Click
        Dim ProjectorWindow As New ProjectorDetails
        ProjectorDetails.Show()
    End Sub
End Class
