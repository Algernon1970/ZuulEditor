Public Class PrinterDetail
    Dim defaultPid As Integer = 0

    Private Sub PrinterDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Tbl_LocationTableAdapter.Fill(Me.ZuulDataSet.Tbl_Location)
        Me.Tbl_SupplierTableAdapter.Fill(Me.ZuulDataSet.Tbl_Supplier)
        Me.Tbl_PrinterTableAdapter.Fill(Me.ZuulDataSet.Tbl_Printer)
        SelectPrinter()
    End Sub

    Private Sub SelectPrinter()
        Dim printerName As String = Tbl_PrinterTableAdapter.GetPrinterByPrinterID(defaultPid).Rows(0).Field(Of String)("Name")
        Dim index As Integer = PrinterListBox.FindString(printerName)
        If index > -1 Then
            PrinterListBox.SetSelected(index, True)
        End If
    End Sub

    Public Sub SelectPrinter(ByVal pid As Integer)
        defaultPid = pid

    End Sub

    Private Sub PrinterListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PrinterListBox.SelectedIndexChanged
        If PrinterListBox.SelectedItems.Count = 1 Then
            Dim printerrow As DataRow = PrinterListBox.SelectedItem.row
            DisplayPrinter(printerrow)
        End If

    End Sub

    Private Sub DisplayPrinter(ByVal printerrow As DataRow)
        Dim LocationTableAdapter As New ZuulDataSetTableAdapters.Tbl_LocationTableAdapter
        NameBox.Text = printerrow.Field(Of String)("Name")
        ConnectionStringBox.Text = printerrow.Field(Of String)("ConnectionString")
        MakeBox.Text = printerrow.Field(Of String)("Make")
        ModelBox.Text = printerrow.Field(Of String)("Model")
        IPAddressBox.Text = printerrow.Field(Of String)("IPAddress")
        Dim LocationNumber As Integer = printerrow.Field(Of Integer)("Location")
        ' Dim PurchasedNumber As Integer = printerrow.Field(Of Integer)("Purchased")
        Dim LocationName As String = LocationTableAdapter.GetLocationName(LocationNumber).Rows(0).Field(Of String)("LocationName")
        LocationCombo.SelectedIndex = LocationCombo.FindString(LocationName)
    End Sub

    Private Sub CreatePrinterButton_Click(sender As Object, e As EventArgs) Handles CreatePrinterButton.Click
        Dim req As New RequestString("Name", "New Printer", 300)
        Dim res As DialogResult = req.ShowDialog
        If res.Equals(DialogResult.OK) Then
            CreatePrinter(req.ResultTextBox.Text)
        End If
    End Sub

    Private Sub CreatePrinter(ByVal name As String)
        If Tbl_PrinterTableAdapter.alreadyExists(name) > 0 Then
            MsgBox("A printer with that name already exists")
        Else
            Tbl_PrinterTableAdapter.CreatePrinter(name, "", "", "", "", 1, 1, 1)
            Me.Tbl_PrinterTableAdapter.Fill(Me.ZuulDataSet.Tbl_Printer)
            defaultPid = Tbl_PrinterTableAdapter.GetPrinterByName(name).Rows(0).Field(Of Integer)("PrinterID")

            SelectPrinter()
        End If
    End Sub
End Class