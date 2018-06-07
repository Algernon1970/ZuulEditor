Imports System.ComponentModel

Public Class PrinterDetail
    Dim defaultPid As Integer = 0
    Dim PrinterWMI As New PrinterInfo
    Dim bg As New BackgroundWorker
    Dim currentPrinterRow As DataRow
    Dim searchMode As SearchField
    Dim lastkey As Keys = Keys.A

    Private Sub AddHandlers()
        Dim box As TextBox
        Dim cbox As ComboBox
        Dim chbox As CheckBox
        Dim panel As SplitterPanel = SplitContainer1.Panel1
        For Each control In panel.Controls
            If TypeOf control Is TextBox Then
                box = DirectCast(control, TextBox)
                AddHandler box.TextChanged, AddressOf FormChanged
            ElseIf TypeOf control Is ComboBox Then
                cbox = DirectCast(control, ComboBox)
                AddHandler cbox.SelectedIndexChanged, AddressOf FormChanged
            ElseIf TypeOf control Is CheckBox Then
                chbox = DirectCast(control, CheckBox)
                AddHandler chbox.CheckStateChanged, AddressOf FormChanged
            End If
        Next
    End Sub

    Private Sub FormChanged(sender As Object, e As EventArgs)
        SavePrinterButton.Enabled = True
    End Sub

    Private Sub PrinterDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Tbl_LocationTableAdapter.Fill(Me.ZuulDataSet.Tbl_Location)
        Me.Tbl_SupplierTableAdapter.Fill(Me.ZuulDataSet.Tbl_Supplier)
        Me.Tbl_PrinterTableAdapter.Fill(Me.ZuulDataSet.Tbl_Printer)
        Me.TblPrinterBindingSource.Filter = "disposed = false"
        ShowDisposedButton.Text = "Showing Active"
        AddHandlers()
    End Sub

    Public Function SelectPrinterByName(ByVal printerName As String) As Boolean
        Dim index As Integer = PrinterListBox.FindString(printerName)
        If index > -1 Then
            PrinterListBox.SetSelected(index, True)
            Return True
        Else
            'PrinterListBox.SetSelected(1, True)
            Return False
        End If
    End Function

    Public Sub SelectByIndex(ByVal index As Integer)
        PrinterListBox.SelectedIndex = index
    End Sub

    Private Sub PrinterListBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles PrinterListBox.SelectedValueChanged
        If PrinterListBox.SelectedIndex > -1 Then
            Try
                Dim printerrow As DataRow = GetSelectedPrinter()
                defaultPid = printerrow.Field(Of Integer)("PrinterID")
                DisplayPrinter(printerrow)
                DisplayNotesForPrinter(printerrow)
            Catch ex As Exception
                ClearDisplay()
                SelectByIndex(-1)
            End Try
        Else
            ClearDisplay()
        End If
    End Sub

    Private Function GetSelectedPrinter() As DataRow
        Dim printerrow As DataRow = Nothing
        If PrinterListBox.SelectedItems.Count = 1 Then
            printerrow = DirectCast(PrinterListBox.SelectedItem, DataRowView).Row
        Else
            Try
                printerrow = Tbl_PrinterTableAdapter.GetPrinterByPrinterID(defaultPid)(0)
            Catch ex As Exception
                PrinterListBox.SelectedIndex = 1
                printerrow = DirectCast(PrinterListBox.SelectedItem, DataRowView).Row
            End Try

        End If
        Return printerrow
    End Function

    Private Sub ClearDisplay()
        Dim LocationTableAdapter As New ZuulDataSetTableAdapters.Tbl_LocationTableAdapter
        NameBox.Text = ""
        ConnectionStringBox.Text = ""
        MakeBox.Text = ""
        ModelBox.Text = ""
        IPAddressBox.Text = ""
        Dim LocationNumber As Integer = 1
        PurchaseDateBox.Text = ""
        PurchaseCostBox.Text = ""
        Dim LocationName As String = ""
        DisposedTick.Checked = False
        PictureBox1.Image = My.Resources.Printer

        InventoryBox.Text = ""
        SerialNumberBox.Text = ""
        Try
            LocationCombo.SelectedIndex = 1
        Catch ex As Exception

        End Try
        SavePrinterButton.Enabled = False
    End Sub

    Private Sub DisplayPrinter(ByVal printerrow As DataRow)
        currentPrinterRow = printerrow
        Dim LocationTableAdapter As New ZuulDataSetTableAdapters.Tbl_LocationTableAdapter
        Dim SupplierTableAdapter As New ZuulDataSetTableAdapters.Tbl_SupplierTableAdapter
        NameBox.Text = printerrow.Field(Of String)("Name")
        ConnectionStringBox.Text = printerrow.Field(Of String)("ConnectionString")
        MakeBox.Text = printerrow.Field(Of String)("Make")
        ModelBox.Text = printerrow.Field(Of String)("Model")
        IPAddressBox.Text = printerrow.Field(Of String)("IPAddress")
        Dim LocationNumber As Integer = printerrow.Field(Of Integer)("Location")
        Dim SupplierNumber As Integer = printerrow.Field(Of Integer)("Supplier")
        PurchaseDateBox.Text = printerrow.Field(Of Date)("PurchaseDate").ToShortDateString
        PurchaseCostBox.Text = printerrow.Field(Of Decimal)("PurchaseCost").ToString("£0.00")
        Dim LocationName As String = LocationTableAdapter.GetLocationName(LocationNumber).Rows(0).Field(Of String)("LocationName")
        LocationCombo.SelectedIndex = LocationCombo.FindString(LocationName)
        Dim SupplierName As String = Tbl_SupplierTableAdapter.GetSupplierName(SupplierNumber).Rows(0).Field(Of String)("Name")
        SupplierCombo.SelectedIndex = SupplierCombo.FindString(SupplierName)
        DisposedTick.Checked = printerrow.Field(Of Boolean)("Disposed")
        If DisposedTick.Checked Then
            PictureBox1.Image = My.Resources.DisposedPrinter
        Else
            PictureBox1.Image = My.Resources.Printer
        End If
        InventoryBox.Text = printerrow.Field(Of String)("InventoryNumber")
        SerialNumberBox.Text = printerrow.Field(Of String)("SerialNumber")
        UserSelectable.Checked = printerrow.Field(Of Boolean)("UserSelectable")
        SavePrinterButton.Enabled = False
    End Sub

    Private Sub CreatePrinterButton_Click(sender As Object, e As EventArgs) Handles CreatePrinterButton.Click
        Dim req As New RequestString("Name", "New Printer", 300)
        Dim res As DialogResult = req.ShowDialog
        If res.Equals(DialogResult.OK) Then
            CreatePrinter(req.ResultTextBox.Text)
            PrinterListBox.SelectedIndex = -1
            Me.Tbl_PrinterTableAdapter.Fill(Me.ZuulDataSet.Tbl_Printer)
            SelectPrinterByName(req.ResultTextBox.Text)
        End If
    End Sub

    Private Sub CreatePrinter(ByVal name As String)
        If Tbl_PrinterTableAdapter.alreadyExists(name) > 0 Then
            MsgBox("A printer with that name already exists")
        Else
            Dim todaysDate As Date = Now().Date

            Tbl_PrinterTableAdapter.CreatePrinter(name, "", "", "", "", 1, 1, todaysDate.ToLongDateString, 0, False)

            SelectPrinterByName(Tbl_PrinterTableAdapter.GetPrinterByName(name).Rows(0).Field(Of String)("Name"))
        End If
    End Sub

    ''' <summary>
    ''' Check if can create new
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SavePrinterButton_Click(sender As Object, e As EventArgs) Handles SavePrinterButton.Click
        SavePrinterButton.Enabled = False
        Dim printerrow As DataRow = GetSelectedPrinter()
        Dim pid = printerrow.Field(Of Integer)("PrinterID")
        Dim loc As DataRow = DirectCast(LocationCombo.SelectedItem, DataRowView).Row

        Dim sup As DataRow = DirectCast(SupplierCombo.SelectedItem, DataRowView).Row
        Dim cost As Decimal
        If Not Decimal.TryParse(PurchaseCostBox.Text.Replace("£", ""), cost) Then
            cost = Decimal.Parse("0.0")
        End If
        Dim testDate As Date
        Dim purchaseDate As String
        If Date.TryParse(PurchaseDateBox.Text, testDate) Then
            purchaseDate = PurchaseDateBox.Text
        Else
            purchaseDate = "1/1/1970"
        End If
        Tbl_PrinterTableAdapter.UpdatePrinterByID(NameBox.Text, ConnectionStringBox.Text, MakeBox.Text, ModelBox.Text, IPAddressBox.Text, loc.Field(Of Integer)("LocationID"), sup.Field(Of Integer)("SupplierID"), cost, purchaseDate, DisposedTick.Checked, InventoryBox.Text, SerialNumberBox.Text, UserSelectable.Checked, pid)
        Dim name As String = NameBox.Text
        PrinterListBox.SelectedIndex = -1
        FillByDisposedButton()
        SelectPrinterByName(name)
    End Sub

    Private Sub FillByDisposedButton()
        If ShowDisposedButton.CheckState = CheckState.Checked Then
            Me.Tbl_PrinterTableAdapter.FillByDisposed(Me.ZuulDataSet.Tbl_Printer)
            ShowDisposedButton.Text = "Showing Disposed"
        ElseIf ShowDisposedButton.CheckState = CheckState.Unchecked Then
            Me.Tbl_PrinterTableAdapter.Fill(Me.ZuulDataSet.Tbl_Printer)
            ShowDisposedButton.Text = "Showing Active"
        ElseIf ShowDisposedButton.CheckState = CheckState.Indeterminate Then
            Me.Tbl_PrinterTableAdapter.FillByAll(Me.ZuulDataSet.Tbl_Printer)
            ShowDisposedButton.Text = "Showing All"
        End If
    End Sub

    Private Sub DisplayNotesForPrinter(ByVal printerrow As DataRow)
        Dim infotable As DataTable = Lnk_PrinterInfoTableAdapter1.GetInfoByPID(printerrow.Field(Of Integer)("PrinterID"))
        PrinterInfoList.DataSource = New DataView(infotable)

        For x As Integer = 0 To PrinterInfoList.Columns.GetColumnCount(DataGridViewElementStates.Visible) - 1
            PrinterInfoList.Columns(x).Visible = False
        Next
        PrinterInfoList.Columns("Datestamp").Visible = True
        PrinterInfoList.Columns("Title").Visible = True
    End Sub

    Private Sub PrinterInfoList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles PrinterInfoList.CellDoubleClick
        If e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = PrinterInfoList.Rows(e.RowIndex)
            Dim dt As DataView = DirectCast(PrinterInfoList.DataSource, DataView)
            Dim row As DataRowView = DirectCast(selectedRow.DataBoundItem, DataRowView)
            Dim dr As DataRow = row.Row
            Dim id As Integer = dr.Field(Of Integer)("InfoID")
            Dim notes As String = dr.Field(Of String)("Notes")
            MsgBox(notes)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Not yet")
    End Sub

    Private Sub ShowDisposedButton_CheckStateChanged(sender As Object, e As EventArgs) Handles ShowDisposedButton.CheckStateChanged
        PrinterListBox.SelectedIndex = -1
        FillByDisposedButton()

        Dim printerrow As DataRow = GetSelectedPrinter()
        defaultPid = printerrow.Field(Of Integer)("PrinterID")
        DisplayPrinter(printerrow)
        DisplayNotesForPrinter(printerrow)
    End Sub

    Public Sub SetState(ByVal check As CheckState)
        ShowDisposedButton.CheckState = check
    End Sub

    Private Sub DeletePrinterButton_Click(sender As Object, e As EventArgs) Handles DeletePrinterButton.Click
        Dim pid As Integer = 0
        Dim plural As String = If(PrinterListBox.SelectedItems.Count = 1, "", "s")
        Dim warn As String = String.Format("Are you sure you wish to delete {0} printer{1} permanently from the database?", PrinterListBox.SelectedItems.Count, plural)
        Dim res As MsgBoxResult = MsgBox(warn, MsgBoxStyle.YesNo)
        If res.Equals(MsgBoxResult.Yes) Then
            For Each printer As DataRowView In PrinterListBox.SelectedItems
                pid = printer.Row.Field(Of Integer)("PrinterID")
                Tbl_PrinterTableAdapter.DeleteByID(pid)
            Next
        End If
        PrinterListBox.SelectedIndex = -1
        FillByDisposedButton()
    End Sub

    Private Sub DisposedTick_CheckedChanged(sender As Object, e As EventArgs) Handles DisposedTick.CheckedChanged
        If DisposedTick.Checked Then
            NameBox.Text = String.Format("{0}({1})", NameBox.Text, Now.ToShortDateString)
        Else
            NameBox.Text = NameBox.Text.Split("("c)(0)
        End If
    End Sub

#Region "Search"
#Region "Serial"

    Private Sub SearchSerialRadio_CheckedChanged(sender As Object, e As EventArgs) Handles SearchSerialRadio.CheckedChanged
        If SearchSerialRadio.Checked Then
            searchMode = SearchField.Serial
            SerialNumberBox.Clear()
            SerialNumberBox.Focus()
        Else
            SerialNumberBox.Text = currentPrinterRow.Field(Of String)("SerialNumber")
        End If
    End Sub

    Private Sub SerialNumberBox_Leave(sender As Object, e As EventArgs) Handles SerialNumberBox.Leave
        If SearchSerialRadio.Checked Then
            SerialNumberBox.Text = currentPrinterRow.Field(Of String)("SerialNumber")
            SearchSerialRadio.Checked = False
        End If
    End Sub

    Private Sub SerialNumberBox_KeyDown(sender As Object, e As KeyEventArgs) Handles SerialNumberBox.KeyDown
        If lastkey = Keys.Return Then
            SerialNumberBox.Clear()
        End If
        lastkey = CType(e.KeyValue, Keys)
        If SearchSerialRadio.Checked Then
            If e.KeyValue = Keys.Return Then
                'find and display record from serialbox.text
                Dim dt As DataTable = Tbl_PrinterTableAdapter.GetPrinterBySerial(SerialNumberBox.Text)
                If dt.Rows.Count = 1 Then
                    DisplayPrinter(dt.Rows(0))
                    PrinterListBox.SelectedIndex = PrinterListBox.FindString(NameBox.Text)
                ElseIf dt.Rows.Count > 1 Then
                    MsgBox(String.Format("Error: {0} Printers have the same Serial Number", dt.Rows.Count))
                Else
                    SearchInvRadio.Checked = True
                End If
            End If
        End If

    End Sub

#End Region
#Region "Inventory"

#End Region
#End Region

    Private Sub IPAddressButton_Click(sender As Object, e As EventArgs) Handles IPAddressButton.Click
        Dim iface As New WebBrowserForm With {
            .Text = IPAddressBox.Text
        }
        iface.WebBrowser1.Url = New Uri("http://" & IPAddressBox.Text)
        iface.Show()
    End Sub

End Class

Public Enum SearchField
    Inventory
    Make
    Model
    Serial
    None
End Enum