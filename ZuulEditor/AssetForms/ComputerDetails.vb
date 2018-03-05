Public Class ComputerDetails
    Dim defaultCid As Integer = 0
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
        SaveComputerButton.Enabled = True
    End Sub

    Private Sub ComputerDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Lnk_ComputerInfoTableAdapter.Fill(Me.ZuulDataSet.Lnk_ComputerInfo)
        Me.Tbl_SupplierTableAdapter.Fill(Me.ZuulDataSet.Tbl_Supplier)
        Me.Tbl_LocationTableAdapter.Fill(Me.ZuulDataSet.Tbl_Location)
        Me.Tbl_ComputerTableAdapter.Fill(Me.ZuulDataSet.Tbl_Computer)
    End Sub

    Public Function SelectComputerByName(ByVal computerName As String) As Boolean
        Dim index As Integer = ComputerListBox.FindString(computerName)
        If index > -1 Then
            ComputerListBox.SetSelected(index, True)
            Return True
        Else
            'ComputerListBox.SetSelected(1, True)
            Return False
        End If
    End Function

    Public Sub SelectByIndex(ByVal index As Integer)
        ComputerListBox.SelectedIndex = index
    End Sub

    Private Sub ComputerListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComputerListBox.SelectedIndexChanged
        If ComputerListBox.SelectedIndex > -1 Then
            Try
                Dim computerrow As DataRow = GetSelectedComputer()
                defaultCid = computerrow.Field(Of Integer)("ComputerID")
                DisplayComputer(computerrow)
                DisplayNotesForComputer(computerrow)
            Catch ex As Exception
                ClearDisplay()
                SelectByIndex(-1)
            End Try
        Else
            ClearDisplay()
        End If
    End Sub
    Private Function GetSelectedComputer() As DataRow
        Dim computerrow As DataRow = Nothing
        If ComputerListBox.SelectedItems.Count = 1 Then
            computerrow = DirectCast(ComputerListBox.SelectedItem, DataRowView).Row
        Else
            Try
                computerrow = Tbl_ComputerTableAdapter.GetComputerByComputerID(defaultCid)(0)
            Catch ex As Exception
                If ComputerListBox.Items.Count > 0 Then
                    ComputerListBox.SelectedIndex = 1
                    computerrow = DirectCast(ComputerListBox.SelectedItem, DataRowView).Row
                End If

            End Try

        End If
        Return computerrow
    End Function
    Private Sub ClearDisplay()
        Dim LocationTableAdapter As New ZuulDataSetTableAdapters.Tbl_LocationTableAdapter
        NameBox.Text = ""
        MakeBox.Text = ""
        ModelBox.Text = ""
        RamBox.Text = ""
        Dim LocationNumber As Integer = 1
        PurchaseDateBox.Text = ""
        PurchaseCostBox.Text = ""
        Dim LocationName As String = ""
        DisposedTick.Checked = False
        PictureBox1.Image = My.Resources.Computer

        InventoryBox.Text = ""
        SerialNumberBox.Text = ""
        Try
            LocationCombo.SelectedIndex = 1
        Catch ex As Exception

        End Try
        SaveComputerButton.Enabled = False
    End Sub

    Private Sub DisplayComputer(ByVal computerrow As DataRow)
        Dim LocationTableAdapter As New ZuulDataSetTableAdapters.Tbl_LocationTableAdapter

        Dim LocationNumber As Integer = computerrow.Field(Of Integer)("Location")
        PurchaseDateBox.Text = computerrow.Field(Of Date)("PurchaseDate").ToShortDateString
        PurchaseCostBox.Text = computerrow.Field(Of Decimal)("PurchaseCost").ToString("£0.00")
        Dim LocationName As String = LocationTableAdapter.GetLocationName(LocationNumber).Rows(0).Field(Of String)("LocationName")
        LocationCombo.SelectedIndex = LocationCombo.FindString(LocationName)
        DisposedTick.Checked = computerrow.Field(Of Boolean)("Disposed")
        If DisposedTick.Checked Then
            PictureBox1.Image = My.Resources.DisposedComputer
        Else
            PictureBox1.Image = My.Resources.Computer
        End If
        InventoryBox.Text = computerrow.Field(Of String)("InventoryNumber")
        SerialNumberBox.Text = computerrow.Field(Of String)("SerialNumber")
        SaveComputerButton.Enabled = False
    End Sub
    Private Sub CreateComputerButton_Click(sender As Object, e As EventArgs) Handles CreateComputerButton.Click
        Dim req As New RequestString("Name", "New Computer", 300)
        Dim res As DialogResult = req.ShowDialog
        If res.Equals(DialogResult.OK) Then
            CreateComputer(req.ResultTextBox.Text)
            ComputerListBox.SelectedIndex = -1
            Me.Tbl_ComputerTableAdapter.Fill(Me.ZuulDataSet.Tbl_Computer)
            SelectComputerByName(req.ResultTextBox.Text)
        End If
    End Sub

    Private Sub CreateComputer(ByVal name As String)
        If Tbl_ComputerTableAdapter.alreadyExists(name) > 0 Then
            MsgBox("A computer with that name already exists")
        Else
            Dim todaysDate As Date = Now().Date

            Tbl_ComputerTableAdapter.CreateComputer(name, "", "", "", "", 0, 0, False, 2, 2, "", "", "", 0, False, "")

            SelectComputerByName(Tbl_ComputerTableAdapter.GetComputerByName(name).Rows(0).Field(Of String)("Name"))
        End If
    End Sub

    Private Sub SaveComputerButton_Click(sender As Object, e As EventArgs) Handles SaveComputerButton.Click
        SaveComputerButton.Enabled = False
        Dim computerrow As DataRow = GetSelectedComputer()
        Dim pid = computerrow.Field(Of Integer)("ComputerID")
        Dim loc As DataRow = DirectCast(LocationCombo.SelectedItem, DataRowView).Row

        Dim sup As DataRow = DirectCast(SupplierCombo.SelectedItem, DataRowView).Row
        Dim cost As Decimal
        cost = Decimal.Parse(PurchaseCostBox.Text.Replace("£", ""))
        'Tbl_ComputerTableAdapter.UpdateComputerByID(NameBox.Text, ConnectionStringBox.Text, MakeBox.Text, ModelBox.Text, IPAddressBox.Text, loc.Field(Of Integer)("LocationID"), sup.Field(Of Integer)("SupplierID"), cost, PurchaseDateBox.Text, DisposedTick.Checked, InventoryBox.Text, SerialNumberBox.Text, pid)
        Dim name As String = NameBox.Text
        ComputerListBox.SelectedIndex = -1
        FillByDisposedButton()
        SelectComputerByName(name)
    End Sub

    Private Sub FillByDisposedButton()
        If ShowDisposedButton.CheckState = CheckState.Checked Then
            Me.Tbl_ComputerTableAdapter.FillByDisposed(Me.ZuulDataSet.Tbl_Computer)
            ShowDisposedButton.Text = "Showing Disposed"
        ElseIf ShowDisposedButton.CheckState = CheckState.Unchecked Then
            Me.Tbl_ComputerTableAdapter.Fill(Me.ZuulDataSet.Tbl_Computer)
            ShowDisposedButton.Text = "Showing Active"
        ElseIf ShowDisposedButton.CheckState = CheckState.Indeterminate Then
            Me.Tbl_ComputerTableAdapter.FillByAll(Me.ZuulDataSet.Tbl_Computer)
            ShowDisposedButton.Text = "Showing All"
        End If
    End Sub

    Private Sub DisplayNotesForComputer(ByVal computerrow As DataRow)
        'Dim infotable As DataTable = Lnk_ComputerInfoTableAdapter.GetInfoByPID(computerrow.Field(Of Integer)("ComputerID"))
        'ComputerInfoList.DataSource = New DataView(infotable)

        'For x As Integer = 0 To ComputerInfoList.Columns.GetColumnCount(DataGridViewElementStates.Visible) - 1
        '    ComputerInfoList.Columns(x).Visible = False
        'Next
        'ComputerInfoList.Columns("Datestamp").Visible = True
        'ComputerInfoList.Columns("Title").Visible = True
    End Sub

    Private Sub ComputerInfoList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ComputerInfoList.CellDoubleClick
        If e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = ComputerInfoList.Rows(e.RowIndex)
            Dim dt As DataView = DirectCast(ComputerInfoList.DataSource, DataView)
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
        ComputerListBox.SelectedIndex = -1
        FillByDisposedButton()

        Dim computerrow As DataRow = GetSelectedComputer()
        defaultCid = computerrow.Field(Of Integer)("ComputerID")
        DisplayComputer(computerrow)
        DisplayNotesForComputer(computerrow)
    End Sub

    Public Sub SetState(ByVal check As CheckState)
        ShowDisposedButton.CheckState = check
    End Sub

    Private Sub DeleteComputerButton_Click(sender As Object, e As EventArgs) Handles DeleteComputerButton.Click
        Dim pid As Integer = 0
        Dim plural As String = If(ComputerListBox.SelectedItems.Count = 1, "", "s")
        Dim warn As String = String.Format("Are you sure you wish to delete {0} computer{1} permanently from the database?", ComputerListBox.SelectedItems.Count, plural)
        Dim res As MsgBoxResult = MsgBox(warn, MsgBoxStyle.YesNo)
        If res.Equals(MsgBoxResult.Yes) Then
            For Each computer As DataRowView In ComputerListBox.SelectedItems
                pid = computer.Row.Field(Of Integer)("ComputerID")
                Tbl_ComputerTableAdapter.DeleteByID(pid)
            Next
        End If
        ComputerListBox.SelectedIndex = -1
        FillByDisposedButton()
    End Sub
End Class