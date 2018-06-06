Imports System.Management

Public Class ComputerDetails
    Dim defaultCid As Integer = 0
    Dim searchPaused As Boolean = False
    Dim CurrentComputerRow As DataRow
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
        CurrentComputerRow = computerrow
        searchPaused = True
        Dim LocationTableAdapter As New ZuulDataSetTableAdapters.Tbl_LocationTableAdapter
        Dim SupplierTableAdapter As New ZuulDataSetTableAdapters.Tbl_SupplierTableAdapter

        Dim LocationNumber As Integer = computerrow.Field(Of Integer)("Location")
        Dim SupplierNumber As Integer = computerrow.Field(Of Integer)("Supplier")
        PurchaseDateBox.Text = computerrow.Field(Of Date)("PurchaseDate").ToShortDateString
        PurchaseCostBox.Text = computerrow.Field(Of Decimal)("PurchaseCost").ToString("£0.00")
        Dim LocationName As String = LocationTableAdapter.GetLocationName(LocationNumber).Rows(0).Field(Of String)("LocationName")
        LocationCombo.SelectedIndex = LocationCombo.FindString(LocationName)
        Dim SupplierName As String = SupplierTableAdapter.GetSupplierName(SupplierNumber).Rows(0).Field(Of String)("Name")
        SupplierCombo.SelectedIndex = SupplierCombo.FindString(SupplierName)

        DisposedTick.Checked = computerrow.Field(Of Boolean)("Disposed")
        If DisposedTick.Checked Then
            PictureBox1.Image = My.Resources.DisposedComputer
        Else
            PictureBox1.Image = My.Resources.Computer
        End If

        If Not SearchName.Checked Then NameBox.Text = computerrow.Field(Of String)("Name")
        If Not SearchMake.Checked Then MakeBox.Text = computerrow.Field(Of String)("Make").ToString
        If Not SearchInv.Checked Then InventoryBox.Text = computerrow.Field(Of String)("InventoryNumber")
        If Not SearchSerial.Checked Then SerialNumberBox.Text = computerrow.Field(Of String)("SerialNumber")
        If Not SearchModel.Checked Then ModelBox.Text = computerrow.Field(Of String)("Model")
        ProcessorBox.Text = computerrow.Field(Of String)("Processor")
        RamBox.Text = computerrow.Field(Of Integer)("RamGB").ToString
        HDDBox.Text = computerrow.Field(Of Integer)("HDDGB").ToString
        SSDBox.Checked = computerrow.Field(Of Boolean)("SSD")
        DisposedTick.Checked = computerrow.Field(Of Boolean)("Disposed")
        WiredMACBox.Text = computerrow.Field(Of String)("WiredMac")
        WirelessMACBox.Text = computerrow.Field(Of String)("WirelessMac")
        Try
            ADPathBox.Text = OUToPath(computerrow.Field(Of String)("ADPath"))
        Catch ex As Exception
            ADPathBox.Text = "Unparsable ADPath"
        End Try

        'If DisposedTick.Checked Then
        '    PictureBox1.Image = My.Resources.DisposedComputer
        'Else
        '    PictureBox1.Image = My.Resources.Computer
        'End If
        SaveComputerButton.Enabled = False
        searchPaused = False
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
        req.Dispose()
    End Sub

    Private Sub CreateComputer(ByVal name As String)
        If Tbl_ComputerTableAdapter.alreadyExists(name) > 0 Then
            MsgBox("A computer with that name already exists")
        Else
            Dim todaysDate As Date = Now().Date

            Tbl_ComputerTableAdapter.CreateComputer(name, "", "", "", "", 0, 0, False, 2, 2, "", "", "", 0, False, "", "")

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
        Tbl_ComputerTableAdapter.UpdateDetails(NameBox.Text, InventoryBox.Text, SerialNumberBox.Text, ProcessorBox.Text, ADPathBox.Text, IsDisposed, Decimal.Parse(PurchaseCostBox.Text.Replace("£", "")), PurchaseDateBox.Text, WirelessMACBox.Text, WiredMACBox.Text, sup.Field(Of Integer)("SupplierID"), loc.Field(Of Integer)("LocationID"), SSDBox.Checked, Integer.Parse(HDDBox.Text), Integer.Parse(RamBox.Text), ModelBox.Text, MakeBox.Text)
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

#Region "Search from form"
    ' Handle Check Changed
    Private Sub SearchMake_CheckedChanged(sender As Object, e As EventArgs) Handles SearchMake.CheckedChanged
        If SearchMake.Checked Then
            MakeBox.Text = ""
            MakeBox.BackColor = Color.AliceBlue
            SearchInv.Checked = False
            SearchSerial.Checked = False
            SearchModel.Checked = False
            SearchName.Checked = False
        Else
            MakeBox.Text = CurrentComputerRow.Field(Of String)("Make").ToString
            MakeBox.BackColor = Color.White
            TblComputerBindingSource.Filter = ""
        End If
    End Sub
    Private Sub SearchModel_CheckedChanged(sender As Object, e As EventArgs) Handles SearchModel.CheckedChanged
        If SearchModel.Checked Then
            ModelBox.Text = ""
            ModelBox.BackColor = Color.AliceBlue
            SearchMake.Checked = False
            SearchInv.Checked = False
            SearchSerial.Checked = False
            SearchName.Checked = False
        Else
            ModelBox.Text = Currentcomputerrow.Field(Of String)("Model")
            ModelBox.BackColor = Color.White
            TblComputerBindingSource.Filter = ""
        End If
    End Sub
    Private Sub SearchName_CheckedChanged(sender As Object, e As EventArgs) Handles SearchName.CheckedChanged
        If SearchName.Checked Then
            NameBox.Text = ""
            NameBox.BackColor = Color.AliceBlue
            SearchModel.Checked = False
            SearchMake.Checked = False
            SearchInv.Checked = False
            SearchSerial.Checked = False
        Else
            NameBox.Text = CurrentComputerRow.Field(Of String)("Name")
            NameBox.BackColor = Color.White
            TblComputerBindingSource.Filter = ""
        End If
    End Sub
    Private Sub SearchSerial_CheckedChanged(sender As Object, e As EventArgs) Handles SearchSerial.CheckedChanged
        If SearchSerial.Checked Then
            SerialNumberBox.Text = ""
            SerialNumberBox.BackColor = Color.AliceBlue
            SearchModel.Checked = False
            SearchMake.Checked = False
            SearchInv.Checked = False
            SearchName.Checked = False
        Else
            SerialNumberBox.Text = CurrentComputerRow.Field(Of String)("SerialNumber")
            SerialNumberBox.BackColor = Color.White
            TblComputerBindingSource.Filter = ""
        End If
    End Sub
    Private Sub SearchInventory_CheckedChanged(sender As Object, e As EventArgs) Handles SearchInv.CheckedChanged
        If SearchInv.Checked Then
            InventoryBox.Text = ""
            InventoryBox.BackColor = Color.AliceBlue
            SearchModel.Checked = False
            SearchMake.Checked = False
            SearchSerial.Checked = False
            SearchName.Checked = False
        Else
            InventoryBox.Text = CurrentComputerRow.Field(Of String)("InventoryNumber")
            InventoryBox.BackColor = Color.White
            TblComputerBindingSource.Filter = ""
        End If
    End Sub

    ' Handle searches
    Private Sub MakeBox_TextChanged(sender As Object, e As EventArgs) Handles MakeBox.TextChanged
        If SearchMake.Checked And Not searchPaused Then
            TblComputerBindingSource.Filter = "[Make] like '%" & MakeBox.Text & "%'"
        Else
            SaveComputerButton.Enabled = True
        End If
    End Sub

    Private Sub SerialNumberBox_TextChanged(sender As Object, e As EventArgs) Handles SerialNumberBox.TextChanged
        If SearchSerial.Checked And Not searchPaused Then
            TblComputerBindingSource.Filter = "[SerialNumber] like '%" & SerialNumberBox.Text & "%'"
        Else
            SaveComputerButton.Enabled = True
        End If
    End Sub

    Private Sub ModelBox_TextChanged(sender As Object, e As EventArgs) Handles ModelBox.TextChanged
        If SearchModel.Checked And Not searchPaused Then
            TblComputerBindingSource.Filter = "[Model] like '%" & ModelBox.Text & "%'"
        Else
            SaveComputerButton.Enabled = True
        End If
    End Sub

    Private Sub NameBox_TextChanged(sender As Object, e As EventArgs) Handles NameBox.TextChanged
        If SearchName.Checked And Not searchPaused Then
            TblComputerBindingSource.Filter = "[Name] like '%" & NameBox.Text & "%'"
        Else
            SaveComputerButton.Enabled = True
        End If
    End Sub

    Private Sub InventoryBox_TextChanged(sender As Object, e As EventArgs) Handles InventoryBox.TextChanged
        If SearchInv.Checked And Not searchPaused Then
            TblComputerBindingSource.Filter = "[InventoryNumber] like '%" & InventoryBox.Text & "%'"
        Else
            SaveComputerButton.Enabled = True
        End If
    End Sub

#End Region

    Private Sub ComputerListBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComputerListBox.SelectedValueChanged
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

    Private Sub ComputerListBox_MouseClick(sender As Object, e As MouseEventArgs) Handles ComputerListBox.MouseClick
        If ComputerListBox.SelectedIndex > -1 Then
            Try
                Dim computerrow As DataRow = GetSelectedComputer()
                SearchModel.Checked = False
                SearchMake.Checked = False
                SearchInv.Checked = False
                SearchSerial.Checked = False
                SearchName.Checked = False
                SelectComputerByName(computerrow.Field(Of String)("Name"))
            Catch ex As Exception
                ClearDisplay()
                SelectByIndex(-1)
            End Try
        Else
            ClearDisplay()
        End If

    End Sub

    Private Sub FindByPriv_Click(sender As Object, e As EventArgs) Handles FindByPriv.Click
        Dim tbl_PersonTableAdapter As New ZuulDataSetTableAdapters.Tbl_PersonTableAdapter
        Dim lnk_ComputerPersonAdapter As New ZuulDataSetTableAdapters.Lnk_ComputerPersonTableAdapter

        Dim req As New RequestString("Username", "Username", 250)
        Dim res As DialogResult = req.ShowDialog
        If res = DialogResult.OK Then
            Dim uName As String = req.ResultTextBox.Text
            If uName.Equals("") Then
                Me.Tbl_ComputerTableAdapter.Fill(Me.ZuulDataSet.Tbl_Computer)
            Else
                Me.Tbl_ComputerTableAdapter.FillByPrivUser(Me.ZuulDataSet.Tbl_Computer, uName)
            End If
        Else
            Me.Tbl_ComputerTableAdapter.Fill(Me.ZuulDataSet.Tbl_Computer)

        End If
        req.Dispose()
    End Sub
End Class