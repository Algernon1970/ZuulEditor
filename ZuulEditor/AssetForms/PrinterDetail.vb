Public Class PrinterDetail
    Dim defaultPid As Integer = 0

    Private Sub AddHandlers()
        Dim box As TextBox
        Dim cbox As ComboBox
        Dim panel As SplitterPanel = SplitContainer1.Panel1
        For Each control In panel.Controls
            If TypeOf control Is TextBox Then
                box = DirectCast(control, TextBox)
                AddHandler box.TextChanged, AddressOf FormChanged
            ElseIf TypeOf control Is combobox Then
                cbox = DirectCast(control, ComboBox)
                AddHandler cbox.SelectedIndexChanged, AddressOf FormChanged
            End If
        Next
    End Sub

    Private Sub FormChanged()
        SavePrinterButton.Enabled = True
    End Sub

    Private Sub PrinterDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Tbl_LocationTableAdapter.Fill(Me.ZuulDataSet.Tbl_Location)
        Me.Tbl_SupplierTableAdapter.Fill(Me.ZuulDataSet.Tbl_Supplier)
        LoadDetails()
        SelectPrinter()
        AddHandlers()
    End Sub

    Private Sub LoadDetails()
        Me.Tbl_PrinterTableAdapter.Fill(Me.ZuulDataSet.Tbl_Printer)
    End Sub

    Private Sub SelectPrinter()
        Try
            Dim printerName As String = Tbl_PrinterTableAdapter.GetPrinterByPrinterID(defaultPid).Rows(0).Field(Of String)("Name")
            Dim index As Integer = PrinterListBox.FindString(printerName)
            If index > -1 Then
                PrinterListBox.SetSelected(index, True)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Public Sub SelectPrinter(ByVal pid As Integer)
        defaultPid = pid
        SelectPrinter()
    End Sub

    Private Sub PrinterListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PrinterListBox.SelectedIndexChanged
        Dim printerrow As DataRow = GetSelectedPrinter()
        defaultPid = printerrow.Field(Of Integer)("PrinterID")
        DisplayPrinter(printerrow)
        DisplayNotesForPrinter(printerrow)
    End Sub

    Private Function GetSelectedPrinter() As DataRow
        Dim printerrow As DataRow = Nothing
        If PrinterListBox.SelectedItems.Count = 1 Then
            printerrow = PrinterListBox.SelectedItem.row
        Else
            printerrow = Tbl_PrinterTableAdapter.GetPrinterByPrinterID(defaultPid)(0)
        End If
        Return printerrow
    End Function

    Private Sub DisplayPrinter(ByVal printerrow As DataRow)
        Dim LocationTableAdapter As New ZuulDataSetTableAdapters.Tbl_LocationTableAdapter
        NameBox.Text = printerrow.Field(Of String)("Name")
        ConnectionStringBox.Text = printerrow.Field(Of String)("ConnectionString")
        MakeBox.Text = printerrow.Field(Of String)("Make")
        ModelBox.Text = printerrow.Field(Of String)("Model")
        IPAddressBox.Text = printerrow.Field(Of String)("IPAddress")
        Dim LocationNumber As Integer = printerrow.Field(Of Integer)("Location")
        PurchaseDateBox.Text = printerrow.Field(Of Date)("PurchaseDate").ToShortDateString
        PurchaseCostBox.Text = printerrow.Field(Of Decimal)("PurchaseCost").ToString
        Dim LocationName As String = LocationTableAdapter.GetLocationName(LocationNumber).Rows(0).Field(Of String)("LocationName")
        LocationCombo.SelectedIndex = LocationCombo.FindString(LocationName)
        SavePrinterButton.Enabled = False
    End Sub

    Private Sub CreatePrinterButton_Click(sender As Object, e As EventArgs) Handles CreatePrinterButton.Click
        Dim req As New RequestString("Name", "New Printer", 300)
        Dim res As DialogResult = req.ShowDialog
        If res.Equals(DialogResult.OK) Then
            CreatePrinter(req.ResultTextBox.Text)
            LoadDetails()
        End If
    End Sub

    Private Sub CreatePrinter(ByVal name As String)
        If Tbl_PrinterTableAdapter.alreadyExists(name) > 0 Then
            MsgBox("A printer with that name already exists")
        Else
            Dim todaysDate As Date = Now().Date

            Tbl_PrinterTableAdapter.CreatePrinter(name, "", "", "", "", 1, 1, todaysDate.ToLongDateString, 0)

            defaultPid = Tbl_PrinterTableAdapter.GetPrinterByName(name).Rows(0).Field(Of Integer)("PrinterID")

            SelectPrinter()
        End If
    End Sub

    Private Sub SavePrinterButton_Click(sender As Object, e As EventArgs) Handles SavePrinterButton.Click
        SavePrinterButton.Enabled = False
        Dim printerrow As DataRow = GetSelectedPrinter()
        Dim pid = printerrow.Field(Of Integer)("PrinterID")
        Dim loc As DataRow = DirectCast(LocationCombo.SelectedItem, DataRowView).Row

        Dim sup As DataRow = DirectCast(SupplierCombo.SelectedItem, DataRowView).Row

        Tbl_PrinterTableAdapter.UpdatePrinterByID(NameBox.Text, ConnectionStringBox.Text, MakeBox.Text, ModelBox.Text, IPAddressBox.Text, loc.Field(Of Integer)("LocationID"), sup.Field(Of Integer)("SupplierID"), Decimal.Parse(PurchaseCostBox.Text), PurchaseDateBox.Text, pid)

        Tbl_PrinterTableAdapter.Fill(ZuulDataSet.Tbl_Printer)
        SelectPrinter()
        DisplayPrinter(GetSelectedPrinter())
    End Sub

    Private Sub DisplayNotesForPrinter(ByVal printerrow As DataRow)
        Dim infotable As DataTable = Lnk_PrinterInfoTableAdapter1.GetInfoByPID(printerrow.Field(Of Integer)("PrinterID"))
        PrinterInfoList.DataSource = New DataView(infotable)
        For Each col In PrinterInfoList.Columns
            col.visible = False
        Next
        PrinterInfoList.Columns("Datestamp").Visible = True
        PrinterInfoList.Columns("Title").Visible = True
    End Sub

    Private Sub PrinterInfoList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles PrinterInfoList.CellDoubleClick
        If e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = PrinterInfoList.Rows(e.RowIndex)
            Dim dt As DataView = PrinterInfoList.DataSource
            Dim row As DataRowView
            row = selectedRow.DataBoundItem
            Dim dr As DataRow = row.Row
            Dim id As Integer = dr.Field(Of Integer)("InfoID")
            Dim notes As String = dr.Field(Of String)("Notes")
            MsgBox(notes)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Not yet")
    End Sub
End Class